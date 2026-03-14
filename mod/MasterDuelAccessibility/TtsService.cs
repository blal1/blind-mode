using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using DavyKager;
using MasterDuelAccessibility.Models;

namespace MasterDuelAccessibility
{
    /// <summary>
    /// Text-to-speech service via Tolk (NVDA, JAWS, SAPI fallback).
    /// Tolk.dll et ses dépendances sont lus depuis le sous-dossier
    /// lib/screen-reader-libs/windows/ du répertoire du plugin.
    ///
    /// Installation des dépendances Tolk :
    ///   UserLibs\TolkDotNet.dll
    ///   Mods\MasterDuelAccessibility\lib\screen-reader-libs\windows\
    ///     Tolk.dll, nvdaControllerClient64.dll, SAAPI64.dll
    /// </summary>
    public sealed class TtsService : IDisposable
    {
        private static void LogMsg(string msg)  => Plugin.Instance?.LogMsg(msg);
        private static void LogWarn(string msg) => Plugin.Instance?.LogWarn(msg);
        private static void LogErr(string msg)  => Plugin.Instance?.LogErr(msg);

        private bool _initialized;
        private bool _disposed;

        public bool Enabled { get; set; } = true;

        /// <summary>Dernier texte prononcé (pour la commande Répéter).</summary>
        public string LastSpoken { get; private set; } = string.Empty;

        // ── Historique circulaire des N dernières annonces ──────────────────
        private const int HistorySize = 10;
        private readonly string[] _history = new string[HistorySize];
        private int _historyHead = 0; // prochain index d'écriture
        /// <summary>Nombre d'entrées stockées dans l'historique (0–10).</summary>
        internal int HistoryCount { get; private set; } = 0;

        [DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        private static extern bool SetDllDirectory(string lpPathName);

        public TtsService()
        {
            Initialize();
        }

        private void Initialize()
        {
            try
            {
                // Pointe SetDllDirectory vers le dossier contenant Tolk.dll,
                // nvdaControllerClient64.dll, SAAPI64.dll, etc.
                string asmDir = Path.GetDirectoryName(
                    Assembly.GetExecutingAssembly().Location) ?? string.Empty;

                if (!string.IsNullOrEmpty(asmDir))
                {
                    string tolkDir = Path.Combine(
                        asmDir, "lib", "screen-reader-libs", "windows");
                    SetDllDirectory(tolkDir);
                }

                Tolk.TrySAPI(true);     // Utilise SAPI si aucun lecteur d'écran détecté
                Tolk.PreferSAPI(false); // Préfère le lecteur natif s'il est disponible
                Tolk.Load();

                _initialized = Tolk.IsLoaded();

                if (_initialized)
                {
                    string sr = Tolk.DetectScreenReader() ?? "SAPI";
                    LogMsg($"[Tolk] Initialisé. Lecteur : {sr}");
                }
                else
                {
                    LogWarn("[Tolk] Échec d'initialisation — aucun lecteur détecté.");
                }
            }
            catch (DllNotFoundException ex)
            {
                LogErr($"[Tolk] Tolk.dll introuvable : {ex.Message}");
            }
            catch (Exception ex)
            {
                LogErr($"[Tolk] Erreur d'initialisation : {ex.Message}");
            }
        }

        /// <summary>
        /// Prononce <paramref name="text"/> via le lecteur d'écran ou SAPI.
        /// </summary>
        /// <param name="interrupt">
        /// Si <c>true</c> (par défaut), interrompt la lecture en cours.
        /// </param>
        /// <param name="addToHistory">
        /// Si <c>true</c> (par défaut), ajoute le texte à l'historique circulaire.
        /// Mettre <c>false</c> pour les répétitions et la navigation dans l'historique
        /// afin d'éviter de polluer l'historique avec des méta-annonces.
        /// </param>
        public void Speak(string text, bool interrupt = true, bool addToHistory = true)
        {
            if (!Enabled || _disposed || string.IsNullOrWhiteSpace(text)) return;
            if (!_initialized) return;

            try
            {
                Tolk.Speak(text, interrupt);
                LastSpoken = text;
                if (addToHistory)
                {
                    _history[_historyHead] = text;
                    _historyHead = (_historyHead + 1) % HistorySize;
                    if (HistoryCount < HistorySize) HistoryCount++;
                }
            }
            catch (Exception ex)
            {
                LogWarn($"[Tolk] Speak() échoué : {ex.Message}");
            }
        }

        /// <summary>
        /// Prononce <paramref name="text"/> avec la priorité spécifiée.
        /// Inspiré de MTGA AccessibleArena — IAnnouncementService.Announce(message, priority).
        ///
        ///   Low / Normal  → interrupt: false  (mise en queue)
        ///   High / Immediate → interrupt: false  (interruption)
        /// </summary>
        public void Speak(string text, AnnouncementPriority priority, bool addToHistory = true)
            => Speak(text, interrupt: false, addToHistory);

        /// <summary>Relit le dernier texte prononcé (sans l'ajouter à l'historique).</summary>
        public void Repeat()
        {
            if (!string.IsNullOrEmpty(LastSpoken))
                Speak(LastSpoken, interrupt: false, addToHistory: false);
        }

        /// <summary>
        /// Retourne la Nième annonce la plus récente.
        /// offset=0 → la plus récente, offset=1 → l'avant-dernière, etc.
        /// Retourne <c>null</c> si offset est hors plage.
        /// </summary>
        internal string? GetHistoryEntry(int offset)
        {
            if (offset < 0 || offset >= HistoryCount) return null;
            int idx = ((_historyHead - 1 - offset) % HistorySize + HistorySize) % HistorySize;
            return _history[idx];
        }

        /// <summary>Coupe la lecture en cours.</summary>
        public void Silence()
        {
            if (!_initialized || _disposed) return;
            try { Tolk.Silence(); }
            catch { /* silencieux */ }
        }

        public void Dispose()
        {
            if (_disposed) return;
            _disposed = true;
            if (_initialized)
            {
                try { Tolk.Unload(); }
                catch { /* silencieux */ }
                _initialized = false;
            }
        }
    }
}
