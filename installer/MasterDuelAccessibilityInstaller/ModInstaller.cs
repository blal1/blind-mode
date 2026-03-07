using System;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;

namespace MasterDuelAccessibilityInstaller
{
    internal static class ModInstaller
    {
        // Relative to game dir
        private const string PluginsDir = @"BepInEx\plugins";
        private const string DepsDir = @"BepInEx\plugins\dependencies";
        private const string TolkLibDir = @"BepInEx\plugins\dependencies\lib\screen-reader-libs\windows";
        private const string ModDllName = "MasterDuelAccessibility.dll";
        private const string TolkDotNetName = "TolkDotNet.dll";

        // Names of Tolk native DLLs embedded as resources
        private static readonly string[] TolkNativeDlls =
        {
            "Tolk.dll",
            "nvdaControllerClient64.dll",
            "SAAPI64.dll",
        };

        /// <summary>
        /// Returns the existing mod version string, or null if not installed.
        /// </summary>
        public static string? GetInstalledVersion(string gameDir)
        {
            var path = Path.Combine(gameDir, PluginsDir, ModDllName);
            if (!File.Exists(path)) return null;
            try
            {
                return AssemblyName.GetAssemblyName(path).Version?.ToString();
            }
            catch
            {
                return "unknown";
            }
        }

        /// <summary>
        /// Downloads the mod DLL from <paramref name="dllUrl"/> and copies all required
        /// files to the game directory.
        /// </summary>
        public static async Task InstallAsync(
            string gameDir,
            string dllUrl,
            IProgress<string>? status = null,
            IProgress<(long downloaded, long total)>? downloadProgress = null)
        {
            // Ensure directories exist
            Directory.CreateDirectory(Path.Combine(gameDir, PluginsDir));
            Directory.CreateDirectory(Path.Combine(gameDir, DepsDir));
            Directory.CreateDirectory(Path.Combine(gameDir, TolkLibDir));

            // Download mod DLL
            status?.Report($"Downloading {ModDllName}...");
            var dllBytes = await GitHubClient.DownloadBytesAsync(dllUrl, downloadProgress);
            var dllDest = Path.Combine(gameDir, PluginsDir, ModDllName);
            File.WriteAllBytes(dllDest, dllBytes);
            status?.Report($"{ModDllName} installed.");

            // Extract TolkDotNet.dll from embedded resources
            status?.Report("Installing Tolk dependencies...");
            ExtractEmbeddedResource(TolkDotNetName, Path.Combine(gameDir, DepsDir, TolkDotNetName));

            // Extract native Tolk DLLs
            foreach (var name in TolkNativeDlls)
            {
                ExtractEmbeddedResource(name, Path.Combine(gameDir, TolkLibDir, name));
            }

            status?.Report("All mod files installed.");
        }

        /// <summary>
        /// Removes the mod DLL and Tolk dependencies from <paramref name="gameDir"/>.
        /// </summary>
        public static void Uninstall(string gameDir, IProgress<string>? status = null)
        {
            TryDelete(Path.Combine(gameDir, PluginsDir, ModDllName), status);
            TryDelete(Path.Combine(gameDir, DepsDir, TolkDotNetName), status);
            foreach (var name in TolkNativeDlls)
                TryDelete(Path.Combine(gameDir, TolkLibDir, name), status);

            // Clean up empty directories
            TryDeleteDir(Path.Combine(gameDir, TolkLibDir), status);
            TryDeleteDir(Path.Combine(gameDir, DepsDir), status);

            status?.Report("Mod files removed.");
        }

        // ── helpers ──────────────────────────────────────────────────────────

        private static void ExtractEmbeddedResource(string resourceName, string destPath)
        {
            var asm = Assembly.GetExecutingAssembly();
            // Resources are embedded under the namespace + "Resources." prefix
            var fullName = $"MasterDuelAccessibilityInstaller.Resources.{resourceName}";
            using var stream = asm.GetManifestResourceStream(fullName);
            if (stream == null)
                throw new InvalidOperationException(
                    $"Embedded resource '{fullName}' not found. " +
                    "Make sure all Tolk DLLs are in installer/Resources/ and marked as EmbeddedResource.");

            Directory.CreateDirectory(Path.GetDirectoryName(destPath)!);
            using var fs = new FileStream(destPath, FileMode.Create, FileAccess.Write);
            stream.CopyTo(fs);
        }

        private static void TryDelete(string path, IProgress<string>? status)
        {
            try
            {
                if (File.Exists(path))
                {
                    File.Delete(path);
                    status?.Report($"Removed: {Path.GetFileName(path)}");
                }
            }
            catch (Exception ex)
            {
                status?.Report($"Warning: could not delete {path}: {ex.Message}");
            }
        }

        private static void TryDeleteDir(string path, IProgress<string>? status)
        {
            try
            {
                if (Directory.Exists(path) && IsDirectoryEmpty(path))
                {
                    Directory.Delete(path);
                    status?.Report($"Removed directory: {path}");
                }
            }
            catch { /* best-effort */ }
        }

        private static bool IsDirectoryEmpty(string path) =>
            Directory.GetFiles(path).Length == 0 &&
            Directory.GetDirectories(path).Length == 0;
    }
}
