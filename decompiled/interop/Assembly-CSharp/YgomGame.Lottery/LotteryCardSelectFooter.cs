using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.Utility;

namespace YgomGame.Lottery;

[Token(Token = "0x20016F1")]
public class LotteryCardSelectFooter
{
	[Token(Token = "0x20016F2")]
	public enum FooterType
	{
		[Token(Token = "0x400D980")]
		CursorJump,
		[Token(Token = "0x400D981")]
		OptionL1,
		[Token(Token = "0x400D982")]
		OptionR1,
		[Token(Token = "0x400D983")]
		AddDeckCard,
		[Token(Token = "0x400D984")]
		RemoveDeckCard,
		[Token(Token = "0x400D985")]
		CardDetail,
		[Token(Token = "0x400D986")]
		ChangeActiveWindow
	}

	[Token(Token = "0x20016F3")]
	private class DisplayRequest
	{
		[Token(Token = "0x400D987")]
		[FieldOffset(Offset = "0x10")]
		public bool display;

		[Token(Token = "0x400D988")]
		[FieldOffset(Offset = "0x11")]
		public bool isDispSubkey;

		[Token(Token = "0x6008F82")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public DisplayRequest()
		{
		}
	}

	[Token(Token = "0x400D975")]
	private const string k_ELabelIconMain = "IconMain";

	[Token(Token = "0x400D976")]
	private const string k_ELabelIconSub = "IconSub";

	[Token(Token = "0x400D977")]
	private const string k_ELabelIconPlus = "IconPlus";

	[Token(Token = "0x400D978")]
	private const string k_ELabelText = "Text";

	[Token(Token = "0x400D979")]
	[FieldOffset(Offset = "0x10")]
	private ElementObjectManager template;

	[Token(Token = "0x400D97A")]
	[FieldOffset(Offset = "0x18")]
	private Transform parent;

	[Token(Token = "0x400D97B")]
	[FieldOffset(Offset = "0x20")]
	private KeyConfigContainer keyConfig;

	[Token(Token = "0x400D97C")]
	[FieldOffset(Offset = "0x28")]
	private Dictionary<FooterType, ElementObjectManager> footerList;

	[Token(Token = "0x400D97D")]
	[FieldOffset(Offset = "0x30")]
	private Dictionary<FooterType, DisplayRequest> dispRequest;

	[Token(Token = "0x400D97E")]
	[FieldOffset(Offset = "0x38")]
	private bool requestUpdateDisplay;

	[Token(Token = "0x6008F79")]
	[Address(RVA = "0xAC02A0", Offset = "0xABF4A0", VA = "0x180AC02A0")]
	public void Setup(ElementObjectManager template, Transform parent, KeyConfigContainer keyConfig)
	{
	}

	[Token(Token = "0x6008F7A")]
	[Address(RVA = "0xD96A30", Offset = "0xD95C30", VA = "0x180D96A30")]
	public void CreateFooterDescription(FooterType footerType, string keyLabel, string text)
	{
	}

	[Token(Token = "0x6008F7B")]
	[Address(RVA = "0xD96990", Offset = "0xD95B90", VA = "0x180D96990")]
	public void CreateFooterDescription(FooterType footerType, string text, SelectorManager.KeyType mainKeyType, SelectorManager.KeyType subKeyType = SelectorManager.KeyType.None)
	{
	}

	[Token(Token = "0x6008F7C")]
	[Address(RVA = "0xD96AA0", Offset = "0xD95CA0", VA = "0x180D96AA0")]
	public void CreateFooterDescription(FooterType footerType, string text, int mainButtonID, int subButtonID = -1)
	{
	}

	[Token(Token = "0x6008F7D")]
	[Address(RVA = "0xD97140", Offset = "0xD96340", VA = "0x180D97140")]
	private void SetDisp(FooterType footerType, DisplayRequest request)
	{
	}

	[Token(Token = "0x6008F7E")]
	[Address(RVA = "0xD97320", Offset = "0xD96520", VA = "0x180D97320")]
	public void Update()
	{
	}

	[Token(Token = "0x6008F7F")]
	[Address(RVA = "0xD96EB0", Offset = "0xD960B0", VA = "0x180D96EB0")]
	public void RequestDisplay(FooterType footerType, bool disp, bool isDispSubkey = false)
	{
	}

	[Token(Token = "0x6008F80")]
	[Address(RVA = "0xD96FD0", Offset = "0xD961D0", VA = "0x180D96FD0")]
	public void RequestHideAll()
	{
	}

	[Token(Token = "0x6008F81")]
	[Address(RVA = "0xD97470", Offset = "0xD96670", VA = "0x180D97470")]
	public LotteryCardSelectFooter()
	{
	}
}
