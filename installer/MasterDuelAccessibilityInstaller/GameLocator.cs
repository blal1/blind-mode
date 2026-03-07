using System;
using System.IO;
using Microsoft.Win32;

namespace MasterDuelAccessibilityInstaller
{
    internal static class GameLocator
    {
        private const string GameExe = "masterduel.exe";

        private static readonly string[] DefaultPaths =
        {
            @"C:\Program Files (x86)\Steam\steamapps\common\Yu-Gi-Oh!  Master Duel",
            @"C:\Program Files\Steam\steamapps\common\Yu-Gi-Oh!  Master Duel",
            @"D:\Steam\steamapps\common\Yu-Gi-Oh!  Master Duel",
            @"D:\SteamLibrary\steamapps\common\Yu-Gi-Oh!  Master Duel",
            @"E:\SteamLibrary\steamapps\common\Yu-Gi-Oh!  Master Duel",
        };

        /// <summary>
        /// Tries to find the game directory. Returns null if not found automatically.
        /// </summary>
        public static string? TryFind()
        {
            // 1. Check well-known Steam paths
            foreach (var path in DefaultPaths)
            {
                if (Directory.Exists(path) &&
                    File.Exists(Path.Combine(path, GameExe)))
                    return path;
            }

            // 2. Walk Steam library folders via registry
            try
            {
                var steamPath = Registry.GetValue(
                    @"HKEY_LOCAL_MACHINE\SOFTWARE\WOW6432Node\Valve\Steam",
                    "InstallPath", null) as string
                    ?? Registry.GetValue(
                    @"HKEY_LOCAL_MACHINE\SOFTWARE\Valve\Steam",
                    "InstallPath", null) as string;

                if (!string.IsNullOrEmpty(steamPath))
                {
                    var libraryFolders = Path.Combine(steamPath, "steamapps", "libraryfolders.vdf");
                    if (File.Exists(libraryFolders))
                    {
                        foreach (var line in File.ReadAllLines(libraryFolders))
                        {
                            var parts = line.Trim().Trim('"').Split('"');
                            // VDF lines: "N" "path"
                            if (parts.Length >= 3 && int.TryParse(parts[0], out _))
                            {
                                var libPath = parts[2].Replace(@"\\", @"\");
                                var candidate = Path.Combine(
                                    libPath, "steamapps", "common",
                                    "Yu-Gi-Oh!  Master Duel");
                                if (Directory.Exists(candidate) &&
                                    File.Exists(Path.Combine(candidate, GameExe)))
                                    return candidate;
                            }
                        }
                    }
                }
            }
            catch
            {
                // Registry access may fail; fall through
            }

            return null;
        }

        /// <summary>
        /// Returns true if masterduel.exe is currently running.
        /// </summary>
        public static bool IsGameRunning()
        {
            foreach (var p in System.Diagnostics.Process.GetProcesses())
            {
                try
                {
                    if (p.ProcessName.Equals("masterduel", StringComparison.OrdinalIgnoreCase))
                        return true;
                }
                catch { /* Access denied on some system processes */ }
            }
            return false;
        }
    }
}
