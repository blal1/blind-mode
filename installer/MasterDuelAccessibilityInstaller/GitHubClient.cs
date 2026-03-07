using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace MasterDuelAccessibilityInstaller
{
    internal static class GitHubClient
    {
        private const string RepoOwner = "blal1";
        private const string RepoName = "blind-mode";
        private const string ApiBase = "https://api.github.com";

        private static readonly HttpClient Http = new HttpClient();

        static GitHubClient()
        {
            Http.DefaultRequestHeaders.UserAgent.Add(
                new ProductInfoHeaderValue("MasterDuelAccessibilityInstaller", "1.0"));
            Http.Timeout = TimeSpan.FromSeconds(30);
        }

        /// <summary>
        /// Returns the latest release tag (e.g. "v1.2.3") and download URL for
        /// the MasterDuelAccessibility.dll asset. Throws on network/parse failure.
        /// </summary>
        public static async Task<(string Tag, string DllUrl, string BepInExUrl)> GetLatestReleaseInfoAsync()
        {
            var url = $"{ApiBase}/repos/{RepoOwner}/{RepoName}/releases/latest";
            var json = await Http.GetStringAsync(url);
            var obj = JObject.Parse(json);

            var tag = obj["tag_name"]?.ToString()
                ?? throw new InvalidOperationException("No tag_name in GitHub response.");

            string? dllUrl = null;
            var assets = obj["assets"] as JArray;
            if (assets != null)
            {
                foreach (var asset in assets)
                {
                    var name = asset["name"]?.ToString() ?? "";
                    if (name.Equals("MasterDuelAccessibility.dll", StringComparison.OrdinalIgnoreCase))
                    {
                        dllUrl = asset["browser_download_url"]?.ToString();
                        break;
                    }
                }
            }

            if (string.IsNullOrEmpty(dllUrl))
                throw new InvalidOperationException(
                    $"Release {tag} has no MasterDuelAccessibility.dll asset.");

            // BepInEx 6 IL2CPP x64 latest stable
            const string BepInEx6Url =
                "https://github.com/BepInEx/BepInEx/releases/download/v6.0.0-be.700/" +
                "BepInEx-Unity.IL2CPP-win-x64-6.0.0-be.700+46abb59.zip";

            return (tag, dllUrl!, BepInEx6Url);
        }

        /// <summary>
        /// Downloads bytes from <paramref name="url"/> with a progress callback.
        /// </summary>
        public static async Task<byte[]> DownloadBytesAsync(
            string url,
            IProgress<(long downloaded, long total)>? progress = null)
        {
            using var response = await Http.GetAsync(url, HttpCompletionOption.ResponseHeadersRead);
            response.EnsureSuccessStatusCode();

            var total = response.Content.Headers.ContentLength ?? -1L;
            var buffer = new byte[81920];
            long downloaded = 0;

            using var stream = await response.Content.ReadAsStreamAsync();
            using var ms = new System.IO.MemoryStream(total > 0 ? (int)total : 4 * 1024 * 1024);

            int read;
            while ((read = await stream.ReadAsync(buffer, 0, buffer.Length)) > 0)
            {
                ms.Write(buffer, 0, read);
                downloaded += read;
                progress?.Report((downloaded, total));
            }

            return ms.ToArray();
        }
    }
}
