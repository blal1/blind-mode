using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using TMPro;
using YgomSystem.YGomTMPro;

namespace YgomSystem;

[Token(Token = "0x20001AD")]
public class RubyTextEx : ExtendedTextMeshProUGUI
{
	[Token(Token = "0x20001AE")]
	public enum Mode
	{
		[Token(Token = "0x4000A21")]
		BaseText,
		[Token(Token = "0x4000A22")]
		RubyText
	}

	[Token(Token = "0x4000A1B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7E8")]
	private string orgStr;

	[Token(Token = "0x4000A1C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7F0")]
	private Mode textMode;

	[Token(Token = "0x4000A1D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7F4")]
	private RubyRoot.Lang textLang;

	[Token(Token = "0x4000A1E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7F8")]
	private List<RubyRoot.RubyInfo> rubyInfoList;

	[Token(Token = "0x4000A1F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x800")]
	private Action populatedAction;

	[Token(Token = "0x17000125")]
	public bool RubyInfoCalculated
	{
		[Token(Token = "0x6000AB7")]
		[Address(RVA = "0xC14300", Offset = "0xC13500", VA = "0x180C14300")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000AB8")]
		[Address(RVA = "0xC14310", Offset = "0xC13510", VA = "0x180C14310")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x6000AB9")]
	[Address(RVA = "0xC14270", Offset = "0xC13470", VA = "0x180C14270")]
	public RubyTextEx()
	{
	}

	[Token(Token = "0x6000ABA")]
	[Address(RVA = "0xC14070", Offset = "0xC13270", VA = "0x180C14070")]
	public void SetText(string str, Mode mode, RubyRoot.Lang lang, List<RubyRoot.RubyInfo> infoList, [Optional] Action populated)
	{
	}

	[Token(Token = "0x6000ABB")]
	[Address(RVA = "0xC13100", Offset = "0xC12300", VA = "0x180C13100")]
	protected void OnPopulateRubyText(TMP_TextInfo tmpinfo)
	{
	}
}
