using HarmonyLib;
using UnityEngine;
using UnityEngine.UI;
using YgomSystem.UI;

namespace BlindMode;

[HarmonyPatch(typeof(ColorContainerGraphic), "SetColor")]
internal class PatchColorContainerGraphic
{
	[HarmonyPostfix]
	private static void Postfix(ColorContainerGraphic __instance)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Invalid comparison between Unknown and I4
		try
		{
			if ((int)((ColorContainer)__instance).currentStatusMode != 2)
			{
				return;
			}
			if (BaseClass.IsInDuel && ((Object)((Component)__instance).transform.parent.parent).name.Contains("DuelListCard"))
			{
				((Component)((Component)__instance).transform.parent.parent).GetComponent<SelectionButton>().Click();
				BaseClass.Instance.CopyUI();
				return;
			}
			BaseClass.textToCopy = "";
			switch (((Object)((Component)__instance).transform.parent.parent).name)
			{
			case "ButtonMaintenance":
				BaseClass.textToCopy = "Maintenance";
				break;
			case "ButtonBug":
				BaseClass.textToCopy = "Issues";
				break;
			case "ButtonNotification":
				BaseClass.textToCopy = "Notification";
				break;
			case "InputButton":
				if (((Object)((Component)__instance).transform.parent.parent).name.Equals("NameAreaGroup") || BaseClass.currentMenu == BaseClass.Menus.NONE)
				{
					BaseClass.textToCopy = "Rename button/input";
				}
				else
				{
					BaseClass.textToCopy = "Search card input";
				}
				break;
			case "AutoBuildButton":
				BaseClass.textToCopy = "Auto-build button";
				break;
			case "ButtonBookmark":
				BaseClass.textToCopy = "Add card to bookmark button";
				break;
			case "BookmarkButton":
				BaseClass.textToCopy = "Bookmarked cards button";
				break;
			case "HowToGetButton":
				BaseClass.textToCopy = "How to get button";
				break;
			case "RelatedCard":
				BaseClass.textToCopy = "Related cards button";
				break;
			case "DismantleButton":
			{
				string value = BaseClass.FindExtendedTextElement(((Component)((Component)__instance).transform.parent.parent.GetChild(6)).gameObject);
				BaseClass.textToCopy = (string.IsNullOrEmpty(value) ? "Cant be dismantled" : $"Dismantle card for: {BaseClass.FindExtendedTextElement(((Component)((Component)__instance).transform.parent.parent.GetChild(6)).gameObject)} {BaseClass.GetRarity(((Object)((Component)((Component)__instance).transform.parent.parent.GetChild(6)).GetComponentInChildren<Image>().sprite).name)} cp") ?? "";
				break;
			}
			case "CreateButton":
				BaseClass.textToCopy = $"Create card for: {BaseClass.FindExtendedTextElement(((Component)((Component)__instance).transform.parent.parent.GetChild(6)).gameObject)} {BaseClass.GetRarity(((Object)((Component)((Component)__instance).transform.parent.parent.GetChild(6)).GetComponentInChildren<Image>().sprite).name)} cp";
				break;
			case "AddButton":
				BaseClass.textToCopy = "Add +1";
				break;
			case "RemoveButton":
				BaseClass.textToCopy = "Remove -1";
				break;
			case "CardListButton":
				BaseClass.textToCopy = "Card list button";
				break;
			case "HistotyButton":
				BaseClass.textToCopy = "Card history button";
				break;
			case "ButtonRegulation":
				BaseClass.textToCopy = "Regulation button";
				break;
			case "ButtonSecretPack":
				BaseClass.textToCopy = "Secret pack button";
				break;
			case "ButtonInfoSwitching":
				BaseClass.textToCopy = "Switch display mode button";
				break;
			case "ButtonSave":
				BaseClass.textToCopy = "Save button";
				break;
			case "ButtonMenu":
				BaseClass.textToCopy = "Menu button";
				break;
			case "ButtonPickupCard":
				BaseClass.textToCopy = "Show cards on decks preview";
				break;
			case "BulkDecksDeletionButton":
				BaseClass.textToCopy = "Bulk deck deletion button";
				break;
			case "ButtonOpenNeuronDecks":
				BaseClass.textToCopy = "Link with Yu Gi Oh Database";
				break;
			case "FilterButton":
				BaseClass.textToCopy = "Filters button";
				break;
			case "SortButton":
				BaseClass.textToCopy = "Sort button";
				break;
			case "ClearButton":
				BaseClass.textToCopy = "Clear filters button";
				break;
			case "Button0":
				BaseClass.textToCopy = BaseClass.FindExtendedTextElement(((Component)((Component)__instance).transform.parent.parent.parent).gameObject) + ", lower to higher";
				break;
			case "Button1":
				BaseClass.textToCopy = BaseClass.FindExtendedTextElement(((Component)((Component)__instance).transform.parent.parent.parent).gameObject) + ", higher to lower";
				break;
			case "ButtonDismantleIncrement":
				BaseClass.textToCopy = "Increment dismantle amount";
				break;
			case "ButtonDismantleDecrement":
				BaseClass.textToCopy = "Decrement dismantle amount";
				break;
			case "ButtonEnter":
				BaseClass.textToCopy = "Play";
				break;
			case "CopyButton":
				BaseClass.textToCopy = "Copy deck button";
				break;
			case "OKButton":
				BaseClass.textToCopy = "Ok";
				break;
			case "ShowOwnedNumToggle":
				BaseClass.textToCopy = "Show owned button";
				break;
			}
			switch (((Object)((Component)__instance).transform.parent.parent.parent).name)
			{
			case "TabMyDeck":
				BaseClass.textToCopy = "My Deck";
				break;
			case "TabRental":
				BaseClass.textToCopy = "Loaner";
				break;
			case "ChapterDuel(Clone)":
				BaseClass.textToCopy = "Duel, " + BaseClass.FindExtendedTextElement(((Component)((Component)__instance).transform.parent.parent.GetChild(4)).gameObject) + " stars";
				break;
			case "DuelMenuButton":
				BaseClass.textToCopy = "Menu button";
				break;
			}
			if (BaseClass.textToCopy != "")
			{
				BaseClass.SpeakText();
			}
		}
		catch
		{
		}
	}
}
