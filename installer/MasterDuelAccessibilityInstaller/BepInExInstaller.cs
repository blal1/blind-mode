using System;
using System.IO;
using System.IO.Compression;
using System.Threading.Tasks;

namespace MasterDuelAccessibilityInstaller
{
    internal static class BepInExInstaller
    {
        private const string CoreDll = "BepInEx\\core\\BepInEx.Core.dll";

        /// <summary>Returns true if BepInEx is already present in <paramref name="gameDir"/>.</summary>
        public static bool IsInstalled(string gameDir) =>
            File.Exists(Path.Combine(gameDir, CoreDll));

        /// <summary>
        /// Downloads BepInEx 6 IL2CPP zip and extracts it into <paramref name="gameDir"/>.
        /// </summary>
        public static async Task InstallAsync(
            string gameDir,
            string zipUrl,
            IProgress<string>? status = null,
            IProgress<(long downloaded, long total)>? downloadProgress = null)
        {
            status?.Report("Downloading BepInEx...");
            var zipBytes = await GitHubClient.DownloadBytesAsync(zipUrl, downloadProgress);

            status?.Report("Extracting BepInEx...");
            using var ms = new MemoryStream(zipBytes);
            using var archive = new ZipArchive(ms, ZipArchiveMode.Read);

            foreach (var entry in archive.Entries)
            {
                // Skip directories
                if (string.IsNullOrEmpty(entry.Name)) continue;

                var destPath = Path.Combine(gameDir, entry.FullName.Replace('/', '\\'));
                var destDir = Path.GetDirectoryName(destPath)!;
                Directory.CreateDirectory(destDir);

                using var entryStream = entry.Open();
                using var fileStream = new FileStream(
                    destPath, FileMode.Create, FileAccess.Write, FileShare.None);
                await entryStream.CopyToAsync(fileStream);
            }

            status?.Report("BepInEx extracted.");
        }
    }
}
