using HarmonyLib;
using YgomSystem.UI;

namespace BlindMode;

[HarmonyPatch(/*Could not decode attribute arguments.*/)]
internal class PatchOnDeselected
{
	[HarmonyPostfix]
	private static void Postfix(SelectionButton __instance)
	{
		BaseClass.DeselectButton();
	}
}
