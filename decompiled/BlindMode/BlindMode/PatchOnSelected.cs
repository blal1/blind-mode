using HarmonyLib;
using UnityEngine;
using YgomSystem.UI;

namespace BlindMode;

[HarmonyPatch(/*Could not decode attribute arguments.*/)]
internal class PatchOnSelected
{
	[HarmonyPostfix]
	private static void Postfix(SelectionButton __instance)
	{
		BaseClass.textToCopy = BaseClass.FindExtendedTextElement(((Component)__instance).gameObject);
		switch (BaseClass.currentMenu)
		{
		case BaseClass.Menus.NONE:
			BaseClass.ProcessNotificationsPopup(__instance);
			BaseClass.ProcessFriendsMenu(__instance);
			BaseClass.ProcessProfile(__instance);
			BaseClass.ProcessEventBanner(__instance);
			BaseClass.ProcessTopicsBanner(__instance);
			break;
		case BaseClass.Menus.Settings:
			BaseClass.ProcessSettingsMenu(__instance);
			break;
		case BaseClass.Menus.Notifications:
			BaseClass.ProcessNotifications(__instance);
			break;
		case BaseClass.Menus.Missions:
			BaseClass.ProcessMissionsMenu(__instance);
			break;
		case BaseClass.Menus.SHOP:
			BaseClass.ProcessPacks(__instance);
			BaseClass.ProcessCardPack(__instance);
			break;
		case BaseClass.Menus.DuelPass:
			BaseClass.ProcessDuelPass(__instance);
			break;
		case BaseClass.Menus.DECK:
			BaseClass.ProcessDecksMenu(__instance);
			BaseClass.ProcessNewDeck(__instance);
			break;
		case BaseClass.Menus.SOLO:
			BaseClass.ProcessDuelGame(__instance);
			BaseClass.ProcessDuelMenu(__instance);
			break;
		case BaseClass.Menus.DUEL:
			BaseClass.ProcessDuelGame(__instance);
			BaseClass.ProcessDuelMenu(__instance);
			break;
		}
		BaseClass.SpeakText();
	}
}
