using HarmonyLib;
using UnityEngine;
using YgomGame.CardBrowser;
using YgomSystem.UI;

namespace BlindMode;

[HarmonyPatch(typeof(CardBrowserViewController), "Start")]
internal class PatchBrowserViewControllerStart
{
	[HarmonyPostfix]
	private static void Postfix(CardBrowserViewController __instance)
	{
		BaseClass.SnapContentManager = ((Component)__instance).GetComponentInChildren<SnapContentManager>();
	}
}
