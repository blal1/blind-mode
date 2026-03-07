using System;
using System.IO;
using Microsoft.Win32;

namespace MasterDuelAccessibilityInstaller
{
    internal static class RegistryHelper
    {
        private const string UninstallRoot =
            @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall";
        private const string AppKey = "AccessibleMasterDuel";

        public static void Register(string gameDir, string version, string installerPath)
        {
            try
            {
                using var key = Registry.LocalMachine
                    .CreateSubKey($@"{UninstallRoot}\{AppKey}", writable: true);

                key.SetValue("DisplayName", "YGO Master Duel Accessibility Mod");
                key.SetValue("DisplayVersion", version);
                key.SetValue("Publisher", "blal1");
                key.SetValue("InstallLocation", gameDir);
                key.SetValue("UninstallString",
                    $"\"{installerPath}\" /uninstall \"{gameDir}\"");
                key.SetValue("NoModify", 1, RegistryValueKind.DWord);
                key.SetValue("NoRepair", 1, RegistryValueKind.DWord);
                key.SetValue("EstimatedSize", 4096, RegistryValueKind.DWord);
            }
            catch (Exception ex)
            {
                // Registry write failure is non-fatal
                Logger.Log($"Warning: could not write registry entry: {ex.Message}");
            }
        }

        public static void Unregister()
        {
            try
            {
                Registry.LocalMachine.DeleteSubKeyTree(
                    $@"{UninstallRoot}\{AppKey}", throwOnMissingSubKey: false);
            }
            catch (Exception ex)
            {
                Logger.Log($"Warning: could not remove registry entry: {ex.Message}");
            }
        }

        /// <summary>Returns the InstallLocation from the registry, or null.</summary>
        public static string? GetInstalledGameDir()
        {
            try
            {
                using var key = Registry.LocalMachine
                    .OpenSubKey($@"{UninstallRoot}\{AppKey}");
                return key?.GetValue("InstallLocation") as string;
            }
            catch
            {
                return null;
            }
        }
    }
}
