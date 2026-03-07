using System;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasterDuelAccessibilityInstaller
{
    /// <summary>
    /// Orchestrates the full install / uninstall flow.
    /// All user interaction is via MessageBox so screen readers work.
    /// </summary>
    internal static class InstallerEngine
    {
        // ── Public entry points ───────────────────────────────────────────────

        public static async Task RunInstallAsync()
        {
            Logger.Init();
            Logger.Log("Starting installation.");

            // Step 1 — Preflight
            if (!Preflight(out var gameDir)) return;

            // Step 2 — Version check / update prompt
            string? latestTag, dllUrl, bepInExUrl;
            try
            {
                Logger.Log("Fetching latest release info from GitHub...");
                (latestTag, dllUrl, bepInExUrl) =
                    await GitHubClient.GetLatestReleaseInfoAsync();
                Logger.Log($"Latest release: {latestTag}");
            }
            catch (Exception ex)
            {
                Logger.Log($"ERROR fetching release: {ex.Message}");
                MessageBox.Show(
                    $"Could not contact GitHub to check for the latest version.\n\n{ex.Message}\n\n" +
                    "Please check your internet connection and try again.",
                    "Network Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var installedVersion = ModInstaller.GetInstalledVersion(gameDir);
            if (!ConfirmInstall(installedVersion, latestTag)) return;

            // Step 3 — Install BepInEx if needed
            if (!BepInExInstaller.IsInstalled(gameDir))
            {
                Logger.Log("BepInEx not found. Installing...");
                var progress = MakeProgress();
                try
                {
                    await BepInExInstaller.InstallAsync(
                        gameDir, bepInExUrl, progress.status, progress.download);
                    Logger.Log("BepInEx installed.");
                }
                catch (Exception ex)
                {
                    Logger.Log($"ERROR installing BepInEx: {ex.Message}");
                    MessageBox.Show(
                        $"Failed to install BepInEx:\n\n{ex.Message}",
                        "Installation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                Logger.Log("BepInEx already installed — skipping.");
            }

            // Step 4 — Install mod files
            Logger.Log("Installing mod files...");
            try
            {
                var progress = MakeProgress();
                await ModInstaller.InstallAsync(
                    gameDir, dllUrl, progress.status, progress.download);
            }
            catch (Exception ex)
            {
                Logger.Log($"ERROR installing mod: {ex.Message}");
                MessageBox.Show(
                    $"Failed to install the mod:\n\n{ex.Message}",
                    "Installation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Step 5 — Registry
            var installerPath = Process.GetCurrentProcess().MainModule?.FileName ?? "";
            RegistryHelper.Register(gameDir, latestTag, installerPath);
            Logger.Log("Registry entry written.");

            // Step 6 — Done
            Logger.Log("Installation complete.");
            var launchGame = MessageBox.Show(
                $"YGO Master Duel Accessibility Mod {latestTag} installed successfully!\n\n" +
                $"Game folder: {gameDir}\n\n" +
                $"A log has been saved to your Desktop: {Logger.LogPath}\n\n" +
                "Launch the game now?",
                "Installation Complete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information);

            if (launchGame == DialogResult.Yes)
                LaunchGame(gameDir);
        }

        public static void RunUninstall(string? gameDir)
        {
            Logger.Init();
            Logger.Log("Starting uninstall.");

            // Resolve game dir from argument or registry
            if (string.IsNullOrEmpty(gameDir))
                gameDir = RegistryHelper.GetInstalledGameDir();

            if (string.IsNullOrEmpty(gameDir) || !Directory.Exists(gameDir))
            {
                gameDir = PromptGameDir();
                if (gameDir == null) return;
            }

            var confirm = MessageBox.Show(
                $"Remove YGO Master Duel Accessibility Mod from:\n{gameDir}\n\n" +
                "This will delete the mod DLL and Tolk dependencies.\n" +
                "BepInEx itself will NOT be removed.\n\n" +
                "Continue?",
                "Confirm Uninstall",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes) return;

            var progress = new Progress<string>(msg => Logger.Log(msg));
            ModInstaller.Uninstall(gameDir!, progress);
            RegistryHelper.Unregister();

            Logger.Log("Uninstall complete.");
            MessageBox.Show(
                "The mod has been removed.\n\n" +
                $"Log saved to Desktop: {Logger.LogPath}",
                "Uninstall Complete",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        // ── Private helpers ───────────────────────────────────────────────────

        private static bool Preflight(out string gameDir)
        {
            gameDir = "";

            // Check game not running
            if (GameLocator.IsGameRunning())
            {
                Logger.Log("Preflight: game is running.");
                var result = MessageBox.Show(
                    "Yu-Gi-Oh! Master Duel is currently running.\n\n" +
                    "Please close the game before installing the mod, then click Retry.",
                    "Game Is Running",
                    MessageBoxButtons.RetryCancel,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.Cancel) return false;
                if (GameLocator.IsGameRunning())
                {
                    MessageBox.Show(
                        "The game is still running. Please close it and re-run the installer.",
                        "Game Still Running",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            // Find game dir
            var found = GameLocator.TryFind();
            if (found != null)
            {
                Logger.Log($"Game found at: {found}");
                var confirm = MessageBox.Show(
                    $"Found the game at:\n{found}\n\nInstall here?",
                    "Game Found",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirm == DialogResult.No)
                    found = PromptGameDir();
            }
            else
            {
                Logger.Log("Game not found automatically.");
                MessageBox.Show(
                    "Could not find Yu-Gi-Oh! Master Duel automatically.\n\n" +
                    "Please select the game folder in the next dialog.",
                    "Game Not Found",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                found = PromptGameDir();
            }

            if (found == null) return false;

            gameDir = found;
            return true;
        }

        private static string? PromptGameDir()
        {
            using var dialog = new FolderBrowserDialog
            {
                Description = "Select Yu-Gi-Oh! Master Duel installation folder " +
                              "(the folder containing masterduel.exe):",
                ShowNewFolderButton = false,
            };

            if (dialog.ShowDialog() != DialogResult.OK) return null;

            var selected = dialog.SelectedPath;
            if (!File.Exists(Path.Combine(selected, "masterduel.exe")))
            {
                MessageBox.Show(
                    $"masterduel.exe not found in:\n{selected}\n\nPlease select the correct folder.",
                    "Invalid Folder",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            Logger.Log($"User selected game folder: {selected}");
            return selected;
        }

        private static bool ConfirmInstall(string? installedVersion, string latestTag)
        {
            string msg;
            if (installedVersion == null)
                msg = $"Install YGO Master Duel Accessibility Mod {latestTag}?";
            else if (installedVersion == latestTag)
                msg = $"Version {latestTag} is already installed.\n\nRe-install / repair?";
            else
                msg = $"Update from {installedVersion} → {latestTag}?";

            var result = MessageBox.Show(msg, "Install", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return result == DialogResult.Yes;
        }

        private static void LaunchGame(string gameDir)
        {
            try
            {
                var exe = Path.Combine(gameDir, "masterduel.exe");
                Process.Start(new ProcessStartInfo(exe) { WorkingDirectory = gameDir });
                Logger.Log("Launched game.");
            }
            catch (Exception ex)
            {
                Logger.Log($"Could not launch game: {ex.Message}");
                MessageBox.Show(
                    $"Could not launch the game automatically:\n{ex.Message}\n\n" +
                    "Please start the game from Steam.",
                    "Launch Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private static (IProgress<string> status, IProgress<(long, long)> download) MakeProgress()
        {
            var status = new Progress<string>(msg => Logger.Log(msg));
            var download = new Progress<(long dl, long total)>(p =>
            {
                if (p.total > 0)
                    Logger.Log($"  {p.dl / 1024} KB / {p.total / 1024} KB");
            });
            return (status, download);
        }
    }
}
