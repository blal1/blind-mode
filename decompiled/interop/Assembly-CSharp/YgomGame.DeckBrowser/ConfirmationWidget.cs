using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

namespace YgomGame.DeckBrowser;

[Token(Token = "0x2001020")]
public class ConfirmationWidget : DeckBrowserOptionWidget
{
	[Token(Token = "0x400ACBC")]
	private const string k_PrefPath = "Prefabs/UI/DeckBrowser/Optionals/DeckBrowserOptionForConfirmation";

	[Token(Token = "0x400ACBD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	private ShortcutKeySetter m_ShortcutSettings;

	[Token(Token = "0x400ACBE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	private int m_DeckID;

	[Token(Token = "0x400ACBF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
	private int m_EventID;

	[Token(Token = "0x400ACC0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	private DeckSelectViewController2.DeckEventType m_DeckType;

	[Token(Token = "0x400ACC1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	private Dictionary<string, object> m_Accsesories;

	[Token(Token = "0x400ACC2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	public Action popViewCallback;

	[Token(Token = "0x400ACC3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	public Action deleteWCSFinalDeckCallback;

	[Token(Token = "0x600616A")]
	[Address(RVA = "0xA72610", Offset = "0xA71810", VA = "0x180A72610")]
	public ConfirmationWidget(ElementObjectManager eom)
	{
	}

	[Token(Token = "0x600616B")]
	[Address(RVA = "0xA70150", Offset = "0xA6F350", VA = "0x180A70150")]
	public static void Create(Transform parent, Action<ConfirmationWidget> onCreated)
	{
	}

	[Token(Token = "0x600616C")]
	[Address(RVA = "0xA70120", Offset = "0xA6F320", VA = "0x180A70120")]
	public void Binding(int deckId, int eventId, DeckSelectViewController2.DeckEventType deckType, [Optional] Dictionary<string, object> accsesories)
	{
	}

	[Token(Token = "0x600616D")]
	[Address(RVA = "0xA70250", Offset = "0xA6F450", VA = "0x180A70250")]
	private void DeleteDeckDialog()
	{
	}

	[Token(Token = "0x600616E")]
	[Address(RVA = "0xA71000", Offset = "0xA70200", VA = "0x180A71000")]
	private void GetNeuronToken()
	{
	}

	[Token(Token = "0x600616F")]
	[Address(RVA = "0xA70ED0", Offset = "0xA700D0", VA = "0x180A70ED0")]
	private void ExportMyDeck(bool isFirst = false)
	{
	}

	[Token(Token = "0x6006170")]
	[Address(RVA = "0xA70460", Offset = "0xA6F660", VA = "0x180A70460")]
	private void DeleteDeck()
	{
	}
}
