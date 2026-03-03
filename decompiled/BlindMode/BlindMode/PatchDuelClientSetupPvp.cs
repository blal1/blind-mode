using HarmonyLib;
using YgomGame.Duel;

namespace BlindMode;

[HarmonyPatch(typeof(DuelClient), "Awake")]
internal class PatchDuelClientSetupPvp
{
	[HarmonyPostfix]
	private static void Postfix(DuelClient __instance)
	{
		BaseClass.currentMenu = BaseClass.Menus.DUEL;
		BaseClass.IsInDuel = true;
	}
}
