using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using YgomGame.Card;
using YgomGame.Menu;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

namespace YgomGame.Deck;

[Token(Token = "0x200108C")]
public class CardCraftResultDialog : InformDialogViewControllerBase<Dictionary<int, int>, Action<Dictionary<int, Dictionary<int, int>>>>, IBokeSupported
{
	[Token(Token = "0x400B023")]
	private const string k_ArgsKeyDeckID = "CardId";

	[Token(Token = "0x400B024")]
	private const string k_ArgsKeyBoostMode = "IsBoostMode";

	[Token(Token = "0x400B025")]
	private const string k_ArgsKeyBeforeCP = "BeforeCP";

	[Token(Token = "0x400B026")]
	private const string k_ArgsKeyAfterCP = "AfterCP";

	[Token(Token = "0x400B027")]
	private const string LABEL_SBN_CRAFTGROUP = "CraftCardGroup";

	[Token(Token = "0x400B028")]
	private const string LABEL_SBN_BOOSTCRAFTGROUP = "BoostCardGroup";

	[Token(Token = "0x400B029")]
	private const string LABEL_SBN_CLOSEBUTTON = "CloseButton";

	[Token(Token = "0x400B02A")]
	private const string k_PREF_PATH = "Prefabs/DeckEdit/CraftPaidCPWidget";

	[Token(Token = "0x400B02B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private ElementObjectManager m_CardGroupEom;

	[Token(Token = "0x400B02C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private SelectionButton m_CloseButton;

	[Token(Token = "0x400B02D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private bool isBoostMode;

	[Token(Token = "0x400B02E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
	private int craftCardID;

	[Token(Token = "0x400B02F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private int beforeCP;

	[Token(Token = "0x400B030")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
	private int afterCP;

	[Token(Token = "0x400B031")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private Dictionary<int, int> resultCardPrem;

	[Token(Token = "0x400B032")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private List<ElementObjectManager> m_ResultCards;

	[Token(Token = "0x400B033")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private Action<Dictionary<int, Dictionary<int, int>>> OnResultParamsCallback;

	[Token(Token = "0x6006589")]
	[Address(RVA = "0xAAA730", Offset = "0xAA9930", VA = "0x180AAA730")]
	public static void Open(bool isBoost, CardCollectionInfo.Premium targetPrem, int cardID, int beforeCP, int afterCP, Dictionary<int, int> resultPrems, [Optional] Action<Dictionary<int, Dictionary<int, int>>> resultParamsCallback)
	{
	}

	[Token(Token = "0x600658A")]
	[Address(RVA = "0xAAA3A0", Offset = "0xAA95A0", VA = "0x180AAA3A0", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x600658B")]
	[Address(RVA = "0xAAA5D0", Offset = "0xAA97D0", VA = "0x180AAA5D0", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x600658C")]
	[Address(RVA = "0xAA9EC0", Offset = "0xAA90C0", VA = "0x180AA9EC0")]
	private void InitializeElements()
	{
	}

	[Token(Token = "0x600658D")]
	[Address(RVA = "0xAAAB20", Offset = "0xAA9D20", VA = "0x180AAAB20")]
	private void SetCardImage()
	{
	}

	[Token(Token = "0x600658E")]
	[Address(RVA = "0xAA9AB0", Offset = "0xAA8CB0", VA = "0x180AA9AB0")]
	public static string GetResultMessage(int cardID, Dictionary<int, int> resultPrem)
	{
		return null;
	}

	[Token(Token = "0x600658F")]
	[Address(RVA = "0xAAA5F0", Offset = "0xAA97F0", VA = "0x180AAA5F0")]
	private static void OpenResultDialog(int cardID, int beforeCP, int afterCP, string message, [Optional] Dictionary<int, int> resultParams, [Optional] Action<Dictionary<int, Dictionary<int, int>>> resultParamsCallback)
	{
	}

	[Token(Token = "0x6006590")]
	[Address(RVA = "0xAAB460", Offset = "0xAAA660", VA = "0x180AAB460")]
	public CardCraftResultDialog()
	{
	}
}
