using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.Utility;

namespace YgomGame.Deck;

[Token(Token = "0x20010A7")]
public class DeckEditFooter
{
	[Token(Token = "0x20010A8")]
	public enum FooterType
	{
		[Token(Token = "0x400B12E")]
		CursorJump,
		[Token(Token = "0x400B12F")]
		OptionL1,
		[Token(Token = "0x400B130")]
		OptionR1,
		[Token(Token = "0x400B131")]
		AddDeckCard,
		[Token(Token = "0x400B132")]
		RemoveDeckCard,
		[Token(Token = "0x400B133")]
		CardDetail,
		[Token(Token = "0x400B134")]
		ChangeActiveWindow,
		[Token(Token = "0x400B135")]
		Undo,
		[Token(Token = "0x400B136")]
		ResetDeck
	}

	[Token(Token = "0x20010A9")]
	private class DisplayRequest
	{
		[Token(Token = "0x400B137")]
		[FieldOffset(Offset = "0x10")]
		public bool display;

		[Token(Token = "0x400B138")]
		[FieldOffset(Offset = "0x11")]
		public bool isDispSubkey;

		[Token(Token = "0x600673D")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public DisplayRequest()
		{
		}
	}

	[Token(Token = "0x400B123")]
	private const string k_ELabelIconMain = "IconMain";

	[Token(Token = "0x400B124")]
	private const string k_ELabelIconSub = "IconSub";

	[Token(Token = "0x400B125")]
	private const string k_ELabelIconPlus = "IconPlus";

	[Token(Token = "0x400B126")]
	private const string k_ELabelText = "Text";

	[Token(Token = "0x400B127")]
	[FieldOffset(Offset = "0x10")]
	private ElementObjectManager template;

	[Token(Token = "0x400B128")]
	[FieldOffset(Offset = "0x18")]
	private Transform parent;

	[Token(Token = "0x400B129")]
	[FieldOffset(Offset = "0x20")]
	private KeyConfigContainer keyConfig;

	[Token(Token = "0x400B12A")]
	[FieldOffset(Offset = "0x28")]
	private Dictionary<FooterType, ElementObjectManager> footerList;

	[Token(Token = "0x400B12B")]
	[FieldOffset(Offset = "0x30")]
	private Dictionary<FooterType, DisplayRequest> dispRequest;

	[Token(Token = "0x400B12C")]
	[FieldOffset(Offset = "0x38")]
	private bool requestUpdateDisplay;

	[Token(Token = "0x6006734")]
	[Address(RVA = "0xAC02A0", Offset = "0xABF4A0", VA = "0x180AC02A0")]
	public void Setup(ElementObjectManager template, Transform parent, KeyConfigContainer keyConfig)
	{
	}

	[Token(Token = "0x6006735")]
	[Address(RVA = "0xABF8B0", Offset = "0xABEAB0", VA = "0x180ABF8B0")]
	public void CreateFooterDescription(FooterType footerType, string keyLabel, string text)
	{
	}

	[Token(Token = "0x6006736")]
	[Address(RVA = "0xABF980", Offset = "0xABEB80", VA = "0x180ABF980")]
	public void CreateFooterDescription(FooterType footerType, string text, SelectorManager.KeyType mainKeyType, SelectorManager.KeyType subKeyType = SelectorManager.KeyType.None)
	{
	}

	[Token(Token = "0x6006737")]
	[Address(RVA = "0xABFA20", Offset = "0xABEC20", VA = "0x180ABFA20")]
	public void CreateFooterDescription(FooterType footerType, string text, int mainButtonID, int subButtonID = -1)
	{
	}

	[Token(Token = "0x6006738")]
	[Address(RVA = "0xAC00C0", Offset = "0xABF2C0", VA = "0x180AC00C0")]
	private void SetDisp(FooterType footerType, DisplayRequest request)
	{
	}

	[Token(Token = "0x6006739")]
	[Address(RVA = "0xAC0300", Offset = "0xABF500", VA = "0x180AC0300")]
	public void Update()
	{
	}

	[Token(Token = "0x600673A")]
	[Address(RVA = "0xABFE30", Offset = "0xABF030", VA = "0x180ABFE30")]
	public void RequestDisplay(FooterType footerType, bool disp, bool isDispSubkey = false)
	{
	}

	[Token(Token = "0x600673B")]
	[Address(RVA = "0xABFF50", Offset = "0xABF150", VA = "0x180ABFF50")]
	public void RequestHideAll()
	{
	}

	[Token(Token = "0x600673C")]
	[Address(RVA = "0xAC0450", Offset = "0xABF650", VA = "0x180AC0450")]
	public DeckEditFooter()
	{
	}
}
