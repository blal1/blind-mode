using System.Collections.Generic;
using HarmonyLib;
using UnityEngine;
using YgomSystem.UI;

namespace BlindMode;

[HarmonyPatch(/*Could not decode attribute arguments.*/)]
internal class PatchOnClick
{
	private static List<string> previewElements = new List<string>
	{
		"CardPict", "CardClone", "CreateButton", "ImageCard", "NextButton", "PrevButton", "Related Cards", "ThumbButton", "SlotTemplate(Clone)", "Locator",
		"GoldpassRewardButton", "NormalpassRewardButton", "ButtonDuelPass"
	};

	[HarmonyPostfix]
	private static void Postfix(SelectionButton __instance)
	{
		try
		{
			if (BaseClass.menuNames.TryGetValue(BaseClass.FindExtendedTextElement(((Component)__instance).gameObject), out var value))
			{
				BaseClass.currentMenu = value;
				BaseClass.textRecord.Clear();
			}
		}
		catch
		{
		}
		if (((Object)__instance).name.Equals("ButtonDecidePositive(Clone)") && BaseClass.IsInDuel)
		{
			BaseClass.IsInDuel = false;
			BaseClass.cardsInDuel.Clear();
			BaseClass.currenElement.Clear();
		}
		if (previewElements.Contains(((Object)__instance).name))
		{
			((MonoBehaviour)BaseClass.Instance).Invoke("CopyUI", (BaseClass.currentMenu == BaseClass.Menus.DuelPass) ? 1.5f : 0.5f);
		}
	}
}
