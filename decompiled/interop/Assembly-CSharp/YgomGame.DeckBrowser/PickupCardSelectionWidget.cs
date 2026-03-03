using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomGame.Menu;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

namespace YgomGame.DeckBrowser;

[Token(Token = "0x2001030")]
public class PickupCardSelectionWidget : DeckBrowserOptionWidget
{
	[Token(Token = "0x400AD44")]
	private const string k_PrefPath = "Prefabs/UI/DeckBrowser/Optionals/DeckBrowserOptionForPickupCardSelection";

	[Token(Token = "0x400AD45")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	private ShortcutKeySetter m_ShortcutSettings;

	[Token(Token = "0x400AD46")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	public Action popViewCallback;

	[Token(Token = "0x400AD47")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	private int m_DeckID;

	[Token(Token = "0x400AD48")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x174")]
	private int m_EventID;

	[Token(Token = "0x400AD49")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	private ProfileEditViewController.EditType m_EditType;

	[Token(Token = "0x400AD4A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
	private int m_DeckCaseId;

	[Token(Token = "0x400AD4B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	private int m_ProtecterId;

	[Token(Token = "0x400AD4C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	private int[] m_PickCardIds;

	[Token(Token = "0x400AD4D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	private int[] m_PickPremiumIds;

	[Token(Token = "0x400AD4E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	private readonly string k_ELabelDeckCase;

	[Token(Token = "0x400AD4F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
	private GameObject m_DeckCaseImage;

	[Token(Token = "0x400AD50")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
	public PickupCursorManager pickupCursorManager;

	[Token(Token = "0x400AD51")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
	public Action<DeckBrowserViewController> pickupCardsActionCallback;

	[Token(Token = "0x6006212")]
	[Address(RVA = "0xA942B0", Offset = "0xA934B0", VA = "0x180A942B0")]
	public PickupCardSelectionWidget(ElementObjectManager eom, int id, int eventId, int deckcaseId, ProfileEditViewController.EditType editType, [Optional] Dictionary<string, object> pcards)
	{
	}

	[Token(Token = "0x6006213")]
	[Address(RVA = "0xA92B10", Offset = "0xA91D10", VA = "0x180A92B10")]
	public static void Create(Transform parent, int id, int eventId, ProfileEditViewController.EditType editType, int deckcaseId, Action<PickupCardSelectionWidget> onCreated, [Optional] Dictionary<string, object> pcards)
	{
	}

	[Token(Token = "0x6006214")]
	[Address(RVA = "0xA92E20", Offset = "0xA92020", VA = "0x180A92E20")]
	private void InitializeAccsesary()
	{
	}

	[Token(Token = "0x6006215")]
	[Address(RVA = "0xA93C50", Offset = "0xA92E50", VA = "0x180A93C50")]
	public void SetInitialPcards(Dictionary<string, object> dic)
	{
	}

	[Token(Token = "0x6006216")]
	[Address(RVA = "0xA92C50", Offset = "0xA91E50", VA = "0x180A92C50")]
	private int[] DictToArray(Dictionary<string, object> dict)
	{
		return null;
	}

	[Token(Token = "0x6006217")]
	[Address(RVA = "0xA935A0", Offset = "0xA927A0", VA = "0x180A935A0")]
	public void SavePickups(int myId = 0, long did = 0L)
	{
	}
}
