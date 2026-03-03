using HarmonyLib;
using YgomGame.Duel;

namespace BlindMode;

[HarmonyPatch(/*Could not decode attribute arguments.*/)]
internal class PatchCardRoot
{
	[HarmonyPostfix]
	private static void Postfix(CardRoot __instance)
	{
		BaseClass.cardsInDuel.Add(__instance);
	}
}
