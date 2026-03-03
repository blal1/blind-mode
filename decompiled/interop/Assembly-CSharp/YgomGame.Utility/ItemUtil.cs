using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomGame.Dialog.CommonDialog;
using YgomGame.Menu.Common;

namespace YgomGame.Utility;

[Token(Token = "0x20008FA")]
public class ItemUtil
{
	[Token(Token = "0x20008FB")]
	public enum EquipTargetFlags
	{
		[Token(Token = "0x4008915")]
		None = 0,
		[Token(Token = "0x4008916")]
		Profile = 2,
		[Token(Token = "0x4008917")]
		RankDeck = 4
	}

	[Token(Token = "0x20008FC")]
	public enum DialogButtonFlags
	{
		[Token(Token = "0x4008919")]
		None = 0,
		[Token(Token = "0x400891A")]
		UsePushOnHome = 2,
		[Token(Token = "0x400891B")]
		UsePush = 4,
		[Token(Token = "0x400891C")]
		UseSwap = 8,
		[Token(Token = "0x400891D")]
		Use = 14,
		[Token(Token = "0x400891E")]
		UseReadOnly = 16,
		[Token(Token = "0x400891F")]
		Equip = 32,
		[Token(Token = "0x4008920")]
		StructureCopy = 64
	}

	[Token(Token = "0x20008FD")]
	public enum Category
	{
		[Token(Token = "0x4008922")]
		NONE,
		[Token(Token = "0x4008923")]
		CONSUME,
		[Token(Token = "0x4008924")]
		CARD,
		[Token(Token = "0x4008925")]
		AVATAR,
		[Token(Token = "0x4008926")]
		ICON,
		[Token(Token = "0x4008927")]
		PROFILE_TAG,
		[Token(Token = "0x4008928")]
		ICON_FRAME,
		[Token(Token = "0x4008929")]
		PROTECTOR,
		[Token(Token = "0x400892A")]
		DECK_CASE,
		[Token(Token = "0x400892B")]
		FIELD,
		[Token(Token = "0x400892C")]
		FIELD_OBJ,
		[Token(Token = "0x400892D")]
		AVATAR_HOME,
		[Token(Token = "0x400892E")]
		STRUCTURE,
		[Token(Token = "0x400892F")]
		WALLPAPER,
		[Token(Token = "0x4008930")]
		PACK_TICKET,
		[Token(Token = "0x4008931")]
		DECK_LIMIT,
		[Token(Token = "0x4008932")]
		REPLAY_LIMIT,
		[Token(Token = "0x4008933")]
		CARD_FILE,
		[Token(Token = "0x4008934")]
		COIN,
		[Token(Token = "0x4008935")]
		BOOKMARK_LIMIT
	}

	[Token(Token = "0x20008FE")]
	public enum ItemType
	{
		[Token(Token = "0x4008937")]
		NONE,
		[Token(Token = "0x4008938")]
		DELUXE
	}

	[Token(Token = "0x20008FF")]
	public enum PeriodCategory
	{
		[Token(Token = "0x400893A")]
		NONE,
		[Token(Token = "0x400893B")]
		EVENT,
		[Token(Token = "0x400893C")]
		PACK_TICKET,
		[Token(Token = "0x400893D")]
		DUEL_PASS,
		[Token(Token = "0x400893E")]
		CAMPAIGN_PACK_TICKET,
		[Token(Token = "0x400893F")]
		UNPACK_RIGHT,
		[Token(Token = "0x4008940")]
		SEASON_POINT
	}

	[Token(Token = "0x2000900")]
	public enum ItemDetailType
	{
		[Token(Token = "0x4008942")]
		CARD_BROWSER,
		[Token(Token = "0x4008943")]
		DECK_BROWSER,
		[Token(Token = "0x4008944")]
		ITEM_PREVIEW
	}

	[Token(Token = "0x4008905")]
	public const string k_OptionArgsKey_ToastArgs = "toast_args";

	[Token(Token = "0x4008906")]
	public const string k_OptionArgsKey_OnEquipCallback = "receiveDialog_onEquipCallback";

	[Token(Token = "0x4008907")]
	public const int k_ItemIdFreeGem = 1;

	[Token(Token = "0x4008908")]
	public const int k_ItemIdPaidGem = 2;

	[Token(Token = "0x4008909")]
	public const int k_ItemIdCardRareShine = 100000;

	[Token(Token = "0x400890A")]
	public const int k_ItemIdCardRareRoyal = 200000;

	[Token(Token = "0x400890B")]
	public const int k_ItemId_LegacyPackTicket = 1140001;

	[Token(Token = "0x400890C")]
	public const int DEFAULT_DECK_CASE_ID = 1080001;

	[Token(Token = "0x400890D")]
	public const int SOLO_DECK_CASE_ID = 1081001;

	[Token(Token = "0x400890E")]
	public const int PUBLIC_DECK_CASE_ID = 1081005;

	[Token(Token = "0x400890F")]
	public const int NEURON_DECK_CASE_ID = 1081006;

	[Token(Token = "0x4008910")]
	public const int WCS_DECK_CASE_ID = 1081008;

	[Token(Token = "0x4008911")]
	internal const string k_ItemArgKey_Card_Premium = "Card_Premium";

	[Token(Token = "0x4008912")]
	internal const string k_ItemArgKey_Dialog_Desc = "Dialog_DialogDesc";

	[Token(Token = "0x4008913")]
	internal const string k_ItemArgKey_Dialog_UseButtonLabel = "Dialog_UseButtonLabel";

	[Token(Token = "0x60035D1")]
	[Address(RVA = "0x7C5250", Offset = "0x7C4450", VA = "0x1807C5250")]
	public static bool ValidateStructureCopyButton(params int[] structureIds)
	{
		return default(bool);
	}

	[Token(Token = "0x60035D2")]
	[Address(RVA = "0x7C4C20", Offset = "0x7C3E20", VA = "0x1807C4C20")]
	public static int TryGetStructureIdByItem(bool isPeriod, int itemCategory, int itemId)
	{
		return default(int);
	}

	[Token(Token = "0x60035D3")]
	[Address(RVA = "0x7C03E0", Offset = "0x7BF5E0", VA = "0x1807C03E0")]
	public static string GetStructureCopyConfirmMessage()
	{
		return null;
	}

	[Token(Token = "0x60035D4")]
	[Address(RVA = "0x7C0380", Offset = "0x7BF580", VA = "0x1807C0380")]
	public static string GetStructureCopyButtonLabel()
	{
		return null;
	}

	[Token(Token = "0x60035D5")]
	[Address(RVA = "0x7C0830", Offset = "0x7BFA30", VA = "0x1807C0830")]
	public static bool HandleStructureCopyResult(int resultCode, out string resultMessage)
	{
		return default(bool);
	}

	[Token(Token = "0x60035D6")]
	[Address(RVA = "0x7C45F0", Offset = "0x7C37F0", VA = "0x1807C45F0")]
	public static EntryButtonData TryCreateStructureCopyButtonEntiry(bool isPeriod, int itemCategory, int itemId, [Optional] Action callback)
	{
		return null;
	}

	[Token(Token = "0x60035D7")]
	[Address(RVA = "0x7C4810", Offset = "0x7C3A10", VA = "0x1807C4810")]
	public static EntryButtonData TryCreateStructureCopyButtonEntiry(List<EntryItemListData.Context> itemContexts, [Optional] Action callback)
	{
		return null;
	}

	[Token(Token = "0x60035D8")]
	[Address(RVA = "0x7C36B0", Offset = "0x7C28B0", VA = "0x1807C36B0")]
	private static void RequestStructureToDeckCopy([Optional] Action<int, string> onComplete, params int[] structureIds)
	{
	}

	[Token(Token = "0x60035D9")]
	[Address(RVA = "0x7C51C0", Offset = "0x7C43C0", VA = "0x1807C51C0")]
	public static bool ValidateEquipButton(bool isPeriod, int itemCategory, int itemId)
	{
		return default(bool);
	}

	[Token(Token = "0x60035DA")]
	[Address(RVA = "0x7BEDE0", Offset = "0x7BDFE0", VA = "0x1807BEDE0")]
	public static EquipTargetFlags GetEquipTargetFlags(List<EntryItemListData.Context> itemContexts)
	{
		return default(EquipTargetFlags);
	}

	[Token(Token = "0x60035DB")]
	[Address(RVA = "0x7BEF10", Offset = "0x7BE110", VA = "0x1807BEF10")]
	public static EquipTargetFlags GetEquipTargetFlags(bool isPeriod, int itemCategory, int itemId)
	{
		return default(EquipTargetFlags);
	}

	[Token(Token = "0x60035DC")]
	[Address(RVA = "0x7BED30", Offset = "0x7BDF30", VA = "0x1807BED30")]
	public static string GetEquipConfirmMessage(EquipTargetFlags equipTargetFlags)
	{
		return null;
	}

	[Token(Token = "0x60035DD")]
	[Address(RVA = "0x7BECC0", Offset = "0x7BDEC0", VA = "0x1807BECC0")]
	public static string GetEquipButtonLabel(EquipTargetFlags equipTargetFlags)
	{
		return null;
	}

	[Token(Token = "0x60035DE")]
	[Address(RVA = "0x7C04B0", Offset = "0x7BF6B0", VA = "0x1807C04B0")]
	public static bool HandleEquipResult(EquipTargetFlags equipTargetFlags, int resultCode, List<string> res)
	{
		return default(bool);
	}

	[Token(Token = "0x60035DF")]
	[Address(RVA = "0x7C41B0", Offset = "0x7C33B0", VA = "0x1807C41B0")]
	public static EntryButtonData TryCreateEquipButtonEntry(bool isPeriod, int itemCategory, int itemId, [Optional] Dictionary<string, object> itemArgs, [Optional] Action callback, [Optional] Dictionary<string, object> optionArgs)
	{
		return null;
	}

	[Token(Token = "0x60035E0")]
	[Address(RVA = "0x7C3F10", Offset = "0x7C3110", VA = "0x1807C3F10")]
	public static EntryButtonData TryCreateEquipButtonEntry(EquipTargetFlags equipTargetFlags, bool isPeriod, int itemCategory, int itemId, [Optional] Dictionary<string, object> itemArgs, [Optional] Action callback, [Optional] Dictionary<string, object> optionArgs)
	{
		return null;
	}

	[Token(Token = "0x60035E1")]
	[Address(RVA = "0x7C4230", Offset = "0x7C3430", VA = "0x1807C4230")]
	public static EntryButtonData TryCreateEquipButtonEntry(List<EntryItemListData.Context> itemContexts, [Optional] Dictionary<string, object> itemArgs, [Optional] Action callback, [Optional] Dictionary<string, object> optionArgs)
	{
		return null;
	}

	[Token(Token = "0x60035E2")]
	[Address(RVA = "0x7C3D20", Offset = "0x7C2F20", VA = "0x1807C3D20")]
	public static EntryButtonData TryCreateEquipButtonEntry(EquipTargetFlags equipTargetFlags, List<EntryItemListData.Context> itemContexts, [Optional] Dictionary<string, object> itemArgs, [Optional] Action callback, [Optional] Dictionary<string, object> optionArgs)
	{
		return null;
	}

	[Token(Token = "0x60035E3")]
	[Address(RVA = "0x7C3FF0", Offset = "0x7C31F0", VA = "0x1807C3FF0")]
	public static EntryButtonData TryCreateEquipButtonEntry(EquipTargetFlags equipTargetFlags, Dictionary<string, object> equipUpdateInfo, [Optional] Dictionary<string, object> itemArgs, [Optional] Action callback, [Optional] Dictionary<string, object> optionArgs)
	{
		return null;
	}

	[Token(Token = "0x60035E4")]
	[Address(RVA = "0x7BF000", Offset = "0x7BE200", VA = "0x1807BF000")]
	private static string GetEquipUpdateKey(bool isPeriod, int itemCategory, int itemId)
	{
		return null;
	}

	[Token(Token = "0x60035E5")]
	[Address(RVA = "0x7BE190", Offset = "0x7BD390", VA = "0x1807BE190")]
	public static void EmbedEquipUpdateInfo(bool isPeriod, int itemCategory, int itemId, Dictionary<string, object> itemArgs, Dictionary<string, object> equipUpdateInfo, bool allowOverride = false)
	{
	}

	[Token(Token = "0x60035E6")]
	[Address(RVA = "0x7BE120", Offset = "0x7BD320", VA = "0x1807BE120")]
	public static void EmbedEquipUpdateInfoByItemArgs(string argKey, Dictionary<string, object> itemArgs, Dictionary<string, object> equipUpdateInfo)
	{
	}

	[Token(Token = "0x60035E7")]
	[Address(RVA = "0x7C35D0", Offset = "0x7C27D0", VA = "0x1807C35D0")]
	private static void RequestEquipApplyAPI(EquipTargetFlags equipTargetFlags, Dictionary<string, object> equipUpdateInfo, [Optional] Action<int, List<string>> onFinish)
	{
	}

	[Token(Token = "0x60035E8")]
	[Address(RVA = "0x7C52E0", Offset = "0x7C44E0", VA = "0x1807C52E0")]
	public static bool ValidateUseButton(bool isPeriod, int itemCategory, int itemId)
	{
		return default(bool);
	}

	[Token(Token = "0x60035E9")]
	[Address(RVA = "0x7C1350", Offset = "0x7C0550", VA = "0x1807C1350")]
	public static string MakeUseButtonLabel(bool isPeriod, int itemCategory, int itemId, [Optional] Dictionary<string, object> itemArgs)
	{
		return null;
	}

	[Token(Token = "0x60035EA")]
	[Address(RVA = "0x7C42A0", Offset = "0x7C34A0", VA = "0x1807C42A0")]
	public static EntryButtonData TryCreateOpenItemUseButtonEntry(bool isPeriod, int itemCategory, int itemId, DialogButtonFlags buttonFlags, [Optional] Dictionary<string, object> itemArgs, [Optional] Action callback)
	{
		return null;
	}

	[Token(Token = "0x60035EB")]
	[Address(RVA = "0x7BE620", Offset = "0x7BD820", VA = "0x1807BE620")]
	public static DialogButtonFlags ExcludeOnSingleItem(DialogButtonFlags dialogButtonFlags, bool isPeriod, int itemCategory, int itemId)
	{
		return default(DialogButtonFlags);
	}

	[Token(Token = "0x60035EC")]
	[Address(RVA = "0x7BE4E0", Offset = "0x7BD6E0", VA = "0x1807BE4E0")]
	public static DialogButtonFlags ExcludeOnMultiItem(DialogButtonFlags dialogButtonFlags, List<EntryItemListData.Context> itemContexts)
	{
		return default(DialogButtonFlags);
	}

	[Token(Token = "0x60035ED")]
	[Address(RVA = "0x7C4E40", Offset = "0x7C4040", VA = "0x1807C4E40")]
	public static (EntryButtonData, string, string) TryMakeActionButtonInfoOnSingle(DialogButtonFlags dialogButtonFlags, bool isPeriod, int itemCategory, int itemId, [Optional] Dictionary<string, object> itemArgs, [Optional] Action callback, [Optional] Dictionary<string, object> optionArgs)
	{
		return default((EntryButtonData, string, string));
	}

	[Token(Token = "0x60035EE")]
	[Address(RVA = "0x7C4C60", Offset = "0x7C3E60", VA = "0x1807C4C60")]
	public static (EntryButtonData, string, string) TryMakeActionButtonInfoOnMulti(DialogButtonFlags dialogButtonFlags, List<EntryItemListData.Context> itemContexts, [Optional] Dictionary<string, object> itemArgs, [Optional] Action callback, [Optional] Dictionary<string, object> optionArgs)
	{
		return default((EntryButtonData, string, string));
	}

	[Token(Token = "0x60035EF")]
	[Address(RVA = "0x7C11C0", Offset = "0x7C03C0", VA = "0x1807C11C0")]
	public static string MakeItemDialogDesc(bool isPeriod, int itemCategory, int itemId, [Optional] Dictionary<string, object> itemArgs)
	{
		return null;
	}

	[Token(Token = "0x60035F0")]
	[Address(RVA = "0x7C14E0", Offset = "0x7C06E0", VA = "0x1807C14E0")]
	public static void OpenItemConfirmDialog(string title, bool isPeriod, int itemCategory, int itemId, int itemNum, [Optional] Action callback, bool hideNum = false, [Optional] Dictionary<string, object> itemArgs)
	{
	}

	[Token(Token = "0x60035F1")]
	[Address(RVA = "0x7C3480", Offset = "0x7C2680", VA = "0x1807C3480")]
	public static void OpenItemRecieveListOrHighlightDialog(EntryItemListData recievedItems, bool isSendPresent, [Optional] string title, [Optional] Action action, DialogButtonFlags buttonFlags = DialogButtonFlags.None, [Optional] Dictionary<string, object> optionArgs)
	{
	}

	[Token(Token = "0x60035F2")]
	[Address(RVA = "0x7C3190", Offset = "0x7C2390", VA = "0x1807C3190")]
	public static void OpenItemRecieveHighlightDialogs(string title, IReadOnlyList<(EntryItemListData.Context itemContext, bool isSendPresent)> receivedItems, [Optional] Action action, int playIdx = 0)
	{
	}

	[Token(Token = "0x60035F3")]
	[Address(RVA = "0x7C30E0", Offset = "0x7C22E0", VA = "0x1807C30E0")]
	public static void OpenItemRecieveHighlightDialog(string title, bool isPeriod, int itemCategory, int itemId, int itemNum, bool isSendPresent, [Optional] Action callback, bool isEffect = true, bool hideNum = false, bool isRecieve = true, [Optional] Dictionary<string, object> itemArgs, DialogButtonFlags buttonFlags = DialogButtonFlags.None, [Optional] string additionalButtonLabel, [Optional] Action additionalButtonCallback, [Optional] Dictionary<string, object> optionArgs)
	{
	}

	[Token(Token = "0x60035F4")]
	[Address(RVA = "0x7C1E40", Offset = "0x7C1040", VA = "0x1807C1E40")]
	public static void OpenItemReceiveHighlightDialogBase(string title, bool isPeriod, int itemCategory, int itemId, int itemNum, bool isSendPresent, EntryButtonData[] entryButtons, bool isEffect, bool hideNum, bool isRecieve, [Optional] Dictionary<string, object> itemArgs, DialogButtonFlags buttonFlags = DialogButtonFlags.None, [Optional] string additionalButtonLabel, [Optional] Action additionalButtonCallback, [Optional] Action callback, [Optional] Dictionary<string, object> optionArgs)
	{
	}

	[Token(Token = "0x60035F5")]
	[Address(RVA = "0x7C28C0", Offset = "0x7C1AC0", VA = "0x1807C28C0")]
	public static void OpenItemRecieveDialog(string title, bool isPeriod, int itemCategory, int itemId, int itemNum, bool isSendPresent, [Optional] Action action, DialogButtonFlags buttonFlags = DialogButtonFlags.None, [Optional] Dictionary<string, object> optionArgs)
	{
	}

	[Token(Token = "0x60035F6")]
	[Address(RVA = "0x7C2FC0", Offset = "0x7C21C0", VA = "0x1807C2FC0")]
	public static void OpenItemRecieveDialog(EntryItemListData receiveItemListData, bool isSendPresent, [Optional] Action action, [Optional] string title, DialogButtonFlags buttonFlags = DialogButtonFlags.None, [Optional] Dictionary<string, object> optionArgs)
	{
	}

	[Token(Token = "0x60035F7")]
	[Address(RVA = "0x7C29C0", Offset = "0x7C1BC0", VA = "0x1807C29C0")]
	public static void OpenItemRecieveDialog(string title, EntryItemListData receiveItemListData, bool isSendPresent, [Optional] Action action, DialogButtonFlags buttonFlags = DialogButtonFlags.None, [Optional] Dictionary<string, object> optionArgs)
	{
	}

	[Token(Token = "0x60035F8")]
	[Address(RVA = "0x7C0FE0", Offset = "0x7C01E0", VA = "0x1807C0FE0")]
	public static bool IsValidItem(bool isPerild, int itemCategory, int itemId)
	{
		return default(bool);
	}

	[Token(Token = "0x60035F9")]
	[Address(RVA = "0x7C0AB0", Offset = "0x7BFCB0", VA = "0x1807C0AB0")]
	public static bool IsGemItem(bool isPerild, int itemCategory, int itemId)
	{
		return default(bool);
	}

	[Token(Token = "0x60035FA")]
	[Address(RVA = "0x7C0E40", Offset = "0x7C0040", VA = "0x1807C0E40")]
	public static bool IsPaidGemItem(bool isPerild, int itemCategory, int itemId)
	{
		return default(bool);
	}

	[Token(Token = "0x60035FB")]
	[Address(RVA = "0x7C0FA0", Offset = "0x7C01A0", VA = "0x1807C0FA0")]
	public static bool IsTicketItem(bool isPerild, int itemCategory, int itemId)
	{
		return default(bool);
	}

	[Token(Token = "0x60035FC")]
	[Address(RVA = "0x7C0980", Offset = "0x7BFB80", VA = "0x1807C0980")]
	public static bool IsCardItem(bool isPerild, int itemCategory, int itemId)
	{
		return default(bool);
	}

	[Token(Token = "0x60035FD")]
	[Address(RVA = "0x7C09E0", Offset = "0x7BFBE0", VA = "0x1807C09E0")]
	public static bool IsDeckCaseItem(bool isPerild, int itemId)
	{
		return default(bool);
	}

	[Token(Token = "0x60035FE")]
	[Address(RVA = "0x7C09A0", Offset = "0x7BFBA0", VA = "0x1807C09A0")]
	public static bool IsConsumeItem(bool isPeriod, int itemCategory, int itemId)
	{
		return default(bool);
	}

	[Token(Token = "0x60035FF")]
	[Address(RVA = "0x7C0E80", Offset = "0x7C0080", VA = "0x1807C0E80")]
	public static bool IsPeriodConsumeItem(PeriodCategory periodCategory)
	{
		return default(bool);
	}

	[Token(Token = "0x6003600")]
	[Address(RVA = "0x7C0990", Offset = "0x7BFB90", VA = "0x1807C0990")]
	public static bool IsConsumeItem(Category itemCategory)
	{
		return default(bool);
	}

	[Token(Token = "0x6003601")]
	[Address(RVA = "0x7C0EA0", Offset = "0x7C00A0", VA = "0x1807C0EA0")]
	public static bool IsSkippableCategoryNameItem(bool isPeriod, int itemCategory, int itemId)
	{
		return default(bool);
	}

	[Token(Token = "0x6003602")]
	[Address(RVA = "0x7C0F00", Offset = "0x7C0100", VA = "0x1807C0F00")]
	public static bool IsSkippableDescItem(bool isPeriod, int itemCategory, int itemId)
	{
		return default(bool);
	}

	[Token(Token = "0x6003603")]
	[Address(RVA = "0x7C0F30", Offset = "0x7C0130", VA = "0x1807C0F30")]
	public static bool IsSkippableNum(bool isPeriod, int itemCategory, int itemId)
	{
		return default(bool);
	}

	[Token(Token = "0x6003604")]
	[Address(RVA = "0x7BE060", Offset = "0x7BD260", VA = "0x1807BE060")]
	public static BindingItemThumb BindItemThumb(GameObject target, int itemID, bool isBoxScale = false, BindingItemThumb.DxBadgeMode dxBadgeMode = BindingItemThumb.DxBadgeMode.None, bool useLargeDeckCase = false)
	{
		return null;
	}

	[Token(Token = "0x6003605")]
	[Address(RVA = "0x7BDFB0", Offset = "0x7BD1B0", VA = "0x1807BDFB0")]
	public static BindingItemThumb BindItemThumb(GameObject target, bool isPeriod, int itemCategory, int itemID, bool isBoxScale = false, BindingItemThumb.DxBadgeMode dxBadgeMode = BindingItemThumb.DxBadgeMode.None, bool useLargeDeckCase = false)
	{
		return null;
	}

	[Token(Token = "0x6003606")]
	[Address(RVA = "0x7BDE50", Offset = "0x7BD050", VA = "0x1807BDE50")]
	public static BindingItemThumb BindItemThumbLarge(GameObject target, int itemID, bool isBoxScale = false, [Optional] Dictionary<string, object> itemArgs)
	{
		return null;
	}

	[Token(Token = "0x6003607")]
	[Address(RVA = "0x7BDF00", Offset = "0x7BD100", VA = "0x1807BDF00")]
	public static BindingItemThumb BindItemThumbLarge(GameObject target, bool isPerild, int itemCategory, int itemID, bool isBoxScale = false, [Optional] Dictionary<string, object> itemArgs)
	{
		return null;
	}

	[Token(Token = "0x6003608")]
	[Address(RVA = "0x7BDD90", Offset = "0x7BCF90", VA = "0x1807BDD90")]
	public static BindingGameObjectEx BindDeluxBadge(GameObject target, bool isSimple = false, bool isLarge = false, bool cacheResource = false)
	{
		return null;
	}

	[Token(Token = "0x6003609")]
	[Address(RVA = "0x7BFE80", Offset = "0x7BF080", VA = "0x1807BFE80")]
	public static string GetItemName(int itemID, [Optional] TextGroupLoadHolder textGroupLoadHolder)
	{
		return null;
	}

	[Token(Token = "0x600360A")]
	[Address(RVA = "0x7BFAF0", Offset = "0x7BECF0", VA = "0x1807BFAF0")]
	public static string GetItemName(bool isPerild, int itemCategory, int itemID, [Optional] TextGroupLoadHolder textGroupLoadHolder)
	{
		return null;
	}

	[Token(Token = "0x600360B")]
	[Address(RVA = "0x7BFA10", Offset = "0x7BEC10", VA = "0x1807BFA10")]
	public static string GetItemNameWithFreePaidCheck(int itemID, [Optional] TextGroupLoadHolder textGroupLoadHolder)
	{
		return null;
	}

	[Token(Token = "0x600360C")]
	[Address(RVA = "0x7BF570", Offset = "0x7BE770", VA = "0x1807BF570")]
	public static string GetItemDesc(int itemID, bool useMobileSfx = false)
	{
		return null;
	}

	[Token(Token = "0x600360D")]
	[Address(RVA = "0x7BF5B0", Offset = "0x7BE7B0", VA = "0x1807BF5B0")]
	public static string GetItemDesc(bool isPeriod, int itemCategory, int itemID, bool useMobileSfx = false, [Optional] TextGroupLoadHolder textGroupLoadHolder)
	{
		return null;
	}

	[Token(Token = "0x600360E")]
	[Address(RVA = "0x7BF500", Offset = "0x7BE700", VA = "0x1807BF500")]
	public static string GetItemCategoryName(bool isPeriod, int category, int itemId, [Optional] TextGroupLoadHolder textGroupLoadHolder)
	{
		return null;
	}

	[Token(Token = "0x600360F")]
	[Address(RVA = "0x7BEBC0", Offset = "0x7BDDC0", VA = "0x1807BEBC0")]
	public static string GetCategoryName(bool isPeriod, int category, [Optional] TextGroupLoadHolder textGroupLoadHolder, bool isDx = false)
	{
		return null;
	}

	[Token(Token = "0x6003610")]
	[Address(RVA = "0x7BE9A0", Offset = "0x7BDBA0", VA = "0x1807BE9A0")]
	public static string GetCategoryName(Category category, [Optional] TextGroupLoadHolder textGroupLoadHolder, bool isDx = false)
	{
		return null;
	}

	[Token(Token = "0x6003611")]
	[Address(RVA = "0x7C01A0", Offset = "0x7BF3A0", VA = "0x1807C01A0")]
	public static string GetPeriodCategoryName(PeriodCategory periodCategory, [Optional] TextGroupLoadHolder textGroupLoadHolder)
	{
		return null;
	}

	[Token(Token = "0x6003612")]
	[Address(RVA = "0x7C0440", Offset = "0x7BF640", VA = "0x1807C0440")]
	public static string GetTagLabel(int tagId, [Optional] TextGroupLoadHolder textGroupLoadHolder)
	{
		return null;
	}

	[Token(Token = "0x6003613")]
	[Address(RVA = "0x7BF990", Offset = "0x7BEB90", VA = "0x1807BF990")]
	public static Dictionary<string, object> GetItemDic(Category category)
	{
		return null;
	}

	[Token(Token = "0x6003614")]
	[Address(RVA = "0x7BF4D0", Offset = "0x7BE6D0", VA = "0x1807BF4D0")]
	public static int GetHasTotalGem()
	{
		return default(int);
	}

	[Token(Token = "0x6003615")]
	[Address(RVA = "0x7BF250", Offset = "0x7BE450", VA = "0x1807BF250")]
	public static int GetHasFreeGem()
	{
		return default(int);
	}

	[Token(Token = "0x6003616")]
	[Address(RVA = "0x7BF4C0", Offset = "0x7BE6C0", VA = "0x1807BF4C0")]
	public static int GetHasPaidGem()
	{
		return default(int);
	}

	[Token(Token = "0x6003617")]
	[Address(RVA = "0x7BF440", Offset = "0x7BE640", VA = "0x1807BF440")]
	public static int GetHasItemQuantity(int itemID)
	{
		return default(int);
	}

	[Token(Token = "0x6003618")]
	[Address(RVA = "0x7BF1F0", Offset = "0x7BE3F0", VA = "0x1807BF1F0")]
	public static Dictionary<string, object> GetHasAllItemDic()
	{
		return null;
	}

	[Token(Token = "0x6003619")]
	[Address(RVA = "0x7BF260", Offset = "0x7BE460", VA = "0x1807BF260")]
	public static List<object> GetHasItemList(Category category)
	{
		return null;
	}

	[Token(Token = "0x600361A")]
	[Address(RVA = "0x7C0100", Offset = "0x7BF300", VA = "0x1807C0100")]
	public static bool GetMrkStyleIdFromID(int itemId, out int mrk, out int styleId)
	{
		return default(bool);
	}

	[Token(Token = "0x600361B")]
	[Address(RVA = "0x7BE7D0", Offset = "0x7BD9D0", VA = "0x1807BE7D0")]
	public static Category GetCategoryFromID(int itemID)
	{
		return default(Category);
	}

	[Token(Token = "0x600361C")]
	[Address(RVA = "0x7BEBF0", Offset = "0x7BDDF0", VA = "0x1807BEBF0")]
	public static int GetCategoryOffset(Category category)
	{
		return default(int);
	}

	[Token(Token = "0x600361D")]
	[Address(RVA = "0x7BE730", Offset = "0x7BD930", VA = "0x1807BE730")]
	public static (int, int) GetCardIDandDecoID(int itemId)
	{
		return default((int, int));
	}

	[Token(Token = "0x600361E")]
	[Address(RVA = "0x7C3780", Offset = "0x7C2980", VA = "0x1807C3780")]
	public static int SelectValidCategory(bool isPeriod, int categoryID, int itemID)
	{
		return default(int);
	}

	[Token(Token = "0x600361F")]
	[Address(RVA = "0x7C0A10", Offset = "0x7BFC10", VA = "0x1807C0A10")]
	public static bool IsDeluxe(bool isPeriod, int categoryID, int itemID)
	{
		return default(bool);
	}

	[Token(Token = "0x6003620")]
	[Address(RVA = "0x7C0A30", Offset = "0x7BFC30", VA = "0x1807C0A30")]
	public static bool IsDeluxe(int itemID)
	{
		return default(bool);
	}

	[Token(Token = "0x6003621")]
	[Address(RVA = "0x7C0AF0", Offset = "0x7BFCF0", VA = "0x1807C0AF0")]
	private static bool IsMatchingCategoryRange(Category category, object value)
	{
		return default(bool);
	}

	[Token(Token = "0x6003622")]
	[Address(RVA = "0x7BFEC0", Offset = "0x7BF0C0", VA = "0x1807BFEC0")]
	private static Dictionary<string, int> GetItemOrder(List<object> list)
	{
		return null;
	}

	[Token(Token = "0x6003623")]
	[Address(RVA = "0x7C1090", Offset = "0x7C0290", VA = "0x1807C1090")]
	private static int ItemSorter(object a, object b, Dictionary<string, int> itemOrder)
	{
		return default(int);
	}

	[Token(Token = "0x6003624")]
	[Address(RVA = "0x7C37A0", Offset = "0x7C29A0", VA = "0x1807C37A0")]
	public static List<object> SortItem(List<object> list)
	{
		return null;
	}

	[Token(Token = "0x6003625")]
	[Address(RVA = "0x7BF950", Offset = "0x7BEB50", VA = "0x1807BF950")]
	public static ItemDetailType GetItemDetailType(bool isPeriod, int itemCategory, int itemId)
	{
		return default(ItemDetailType);
	}

	[Token(Token = "0x6003626")]
	[Address(RVA = "0x7C1550", Offset = "0x7C0750", VA = "0x1807C1550")]
	public static void OpenItemDetail(bool isPeriod, int itemCategory, int itemId, int itemNum = -1, [Optional] Action callback, [Optional] Dictionary<string, object> itemArgs, DialogButtonFlags buttonFlags = DialogButtonFlags.None)
	{
	}

	[Token(Token = "0x6003627")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public ItemUtil()
	{
	}
}
