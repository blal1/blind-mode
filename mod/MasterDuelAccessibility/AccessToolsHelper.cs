using System;
using System.Reflection;
using HarmonyLib;

namespace MasterDuelAccessibility
{
    /// <summary>
    /// Wrapper léger autour de <see cref="AccessTools.TypeByName"/>
    /// pour centraliser la résolution de types du jeu par réflexion.
    /// </summary>
    internal static class AccessToolsHelper
    {
        private static readonly BindingFlags PubInst =
            BindingFlags.Public | BindingFlags.Instance;
        private static readonly BindingFlags PubStat =
            BindingFlags.Public | BindingFlags.Static;
        /// <summary>
        /// Cherche un type par son nom court (ex. "CardInfo") ou son nom complet
        /// (ex. "YgomGame.Duel.CardInfo") dans tous les assemblies chargés.
        /// Retourne <c>null</c> si le type n'est pas trouvé.
        /// </summary>
        public static Type? FindType(string typeName)
        {
            try
            {
                return AccessTools.TypeByName(typeName);
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// Appelle <c>UnityEngine.GameObject.Find(path)</c> via réflexion statique.
        /// Retourne l'objet trouvé, ou <c>null</c> si introuvable.
        /// </summary>
        public static object? FindGameObjectByPath(string path)
        {
            try
            {
                var goType = FindType("UnityEngine.GameObject");
                if (goType == null) return null;
                var findM = goType.GetMethod("Find",
                    BindingFlags.Public | BindingFlags.Static, null,
                    new[] { typeof(string) }, null);
                return findM?.Invoke(null, new object[] { path });
            }
            catch { return null; }
        }

        /// <summary>
        /// Résout un identifiant de carte en nom lisible via Content.Instance.GetName().
        /// Retourne <c>null</c> si la résolution échoue.
        /// </summary>
        public static string? GetCardName(int cardId)
        {
            try
            {
                var contentType = FindType("Content");
                if (contentType == null) return null;

                var instanceProp = contentType.GetProperty("Instance",
                    BindingFlags.Public | BindingFlags.Static);
                var content = instanceProp?.GetValue(null);
                if (content == null) return null;

                var getNameMethod = contentType.GetMethod("GetName",
                    BindingFlags.Public | BindingFlags.Instance,
                    null, new[] { typeof(int), typeof(bool) }, null);

                return getNameMethod?.Invoke(content, new object[] { cardId, false }) as string;
            }
            catch { return null; }
        }

        /// <summary>
        /// Trouve le nom et l'ATK de la carte à une position précise du terrain.
        /// Retourne (null, -1) si introuvable. atk=-1 si la propriété n'est pas accessible.
        /// </summary>
        public static (string? Name, int Atk) GetCardNameAndAtkAt(int team, int position)
        {
            try
            {
                var rootType = FindType("CardRoot");
                if (rootType == null) return (null, -1);

                var findM = typeof(UnityEngine.Object).GetMethod(
                    "FindObjectsOfType", PubStat, null, new[] { typeof(Type) }, null);
                if (findM?.Invoke(null, new object[] { rootType }) is not Array roots)
                    return (null, -1);

                var teamProp   = rootType.GetProperty("team",   PubInst);
                var cardIdProp = rootType.GetProperty("cardId", PubInst);
                var posField   = rootType.GetField("position",  PubInst);
                var atkProp    = rootType.GetProperty("atk",    PubInst);

                foreach (var root in roots)
                {
                    if (root == null) continue;
                    if (teamProp?.GetValue(root) is not int t || t != team) continue;
                    if (posField?.GetValue(root) is not int pos || pos != position) continue;
                    if (cardIdProp?.GetValue(root) is not int cardId || cardId <= 0) continue;
                    string? name = GetCardName(cardId);
                    int atk = atkProp?.GetValue(root) is int a ? a : -1;
                    return (name, atk);
                }
                return (null, -1);
            }
            catch { return (null, -1); }
        }

        /// <summary>
        /// Trouve le nom de la carte à une position précise du terrain.
        /// team=0 = joueur local, team=1 = adversaire.
        /// position = zone CardRoot (0-12 terrain, 13 main, 14 extra deck, 16 cimetière…)
        /// Retourne null si aucune carte trouvée ou si la résolution échoue.
        /// </summary>
        public static string? GetCardNameAt(int team, int position)
        {
            try
            {
                var rootType = FindType("CardRoot");
                if (rootType == null) return null;

                var findM = typeof(UnityEngine.Object).GetMethod(
                    "FindObjectsOfType", PubStat, null, new[] { typeof(Type) }, null);
                if (findM?.Invoke(null, new object[] { rootType }) is not Array roots)
                    return null;

                var teamProp   = rootType.GetProperty("team",   PubInst);
                var cardIdProp = rootType.GetProperty("cardId", PubInst);
                var posField   = rootType.GetField("position",  PubInst);

                foreach (var root in roots)
                {
                    if (root == null) continue;
                    if (teamProp?.GetValue(root) is not int t || t != team) continue;
                    if (posField?.GetValue(root) is not int pos || pos != position) continue;
                    if (cardIdProp?.GetValue(root) is not int cardId || cardId <= 0) continue;
                    return GetCardName(cardId);
                }
                return null;
            }
            catch { return null; }
        }
    }
}
