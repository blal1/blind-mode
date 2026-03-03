using HarmonyLib;
using UnityEngine;
using YgomSystem.UI;

namespace BlindMode;

[HarmonyPatch(typeof(ViewController), "OnBack")]
internal class PatchViewController
{
	[HarmonyPostfix]
	public static void Postfix(ViewController __instance)
	{
		if (((Object)__instance.manager.GetFocusViewController(false)).name == "Home")
		{
			BaseClass.currentMenu = BaseClass.Menus.NONE;
		}
	}
}
