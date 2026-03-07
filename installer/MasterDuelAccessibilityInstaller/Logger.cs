using System;
using System.IO;
using System.Text;

namespace MasterDuelAccessibilityInstaller
{
    internal static class Logger
    {
        private static readonly object Lock = new object();
        private static string? _logPath;

        public static string LogPath => _logPath ??= BuildLogPath();

        private static string BuildLogPath()
        {
            var desktop = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            return Path.Combine(desktop, "MasterDuelAccessibility_Install.log");
        }

        public static void Init()
        {
            lock (Lock)
            {
                File.WriteAllText(LogPath,
                    $"=== YGO Master Duel Accessibility Mod Installer ==={Environment.NewLine}" +
                    $"Date: {DateTime.Now:yyyy-MM-dd HH:mm:ss}{Environment.NewLine}" +
                    $"=============================={Environment.NewLine}",
                    Encoding.UTF8);
            }
        }

        public static void Log(string message)
        {
            var line = $"[{DateTime.Now:HH:mm:ss}] {message}";
            Console.WriteLine(line);
            try
            {
                lock (Lock)
                    File.AppendAllText(LogPath, line + Environment.NewLine, Encoding.UTF8);
            }
            catch { /* never throw from logger */ }
        }
    }
}
