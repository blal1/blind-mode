using HarmonyLib;
using UnityEngine;
using YgomGame.Duel;

namespace BlindMode;

[HarmonyPatch(/*Could not decode attribute arguments.*/)]
internal class PatchChangeLP
{
	[HarmonyPostfix]
	private static void Postfix(DuelLP __instance)
	{
		BaseClass.SpeakText(string.Format("{0} current life points: {1}", ((Object)__instance).name.Contains("Far") ? "Opponent's" : "Your", __instance.currentLP));
		if (__instance.currentLP < 1)
		{
			BaseClass.IsInDuel = false;
			BaseClass.cardsInDuel.Clear();
		}
	}
}
