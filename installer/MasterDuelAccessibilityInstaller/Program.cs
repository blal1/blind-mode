using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasterDuelAccessibilityInstaller
{
    internal static class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Handle /uninstall [gameDir]
            if (args.Length >= 1 &&
                args[0].Equals("/uninstall", StringComparison.OrdinalIgnoreCase))
            {
                var gameDir = args.Length >= 2 ? args[1] : null;
                InstallerEngine.RunUninstall(gameDir);
                return;
            }

            // Normal install — run async but pump the message loop so WinForms works
            Task.Run(async () =>
            {
                try
                {
                    await InstallerEngine.RunInstallAsync();
                }
                catch (Exception ex)
                {
                    Logger.Log($"Unhandled error: {ex}");
                    MessageBox.Show(
                        $"An unexpected error occurred:\n\n{ex.Message}\n\n" +
                        $"Log saved to Desktop: {Logger.LogPath}",
                        "Installer Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }).Wait();
        }
    }
}
