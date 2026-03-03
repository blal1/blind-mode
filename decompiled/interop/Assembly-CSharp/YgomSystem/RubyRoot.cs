using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem;

[Token(Token = "0x20001A8")]
public class RubyRoot : MonoBehaviour
{
	[Token(Token = "0x20001A9")]
	public enum Lang
	{
		[Token(Token = "0x4000A09")]
		JP,
		[Token(Token = "0x4000A0A")]
		EN,
		[Token(Token = "0x4000A0B")]
		KR,
		[Token(Token = "0x4000A0C")]
		CN,
		[Token(Token = "0x4000A0D")]
		TW
	}

	[Token(Token = "0x20001AA")]
	public class RubyInfo
	{
		[Token(Token = "0x4000A0E")]
		[FieldOffset(Offset = "0x10")]
		public int rubyTextIdx;

		[Token(Token = "0x4000A0F")]
		[FieldOffset(Offset = "0x14")]
		public int rubyCount;

		[Token(Token = "0x4000A10")]
		[FieldOffset(Offset = "0x18")]
		public int baseTextIdx;

		[Token(Token = "0x4000A11")]
		[FieldOffset(Offset = "0x1C")]
		public int wordCount;

		[Token(Token = "0x4000A12")]
		[FieldOffset(Offset = "0x20")]
		public float wordPos;

		[Token(Token = "0x4000A13")]
		[FieldOffset(Offset = "0x24")]
		public float wordWidth;

		[Token(Token = "0x4000A14")]
		[FieldOffset(Offset = "0x28")]
		public string word;

		[Token(Token = "0x6000AB3")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public RubyInfo()
		{
		}
	}

	[Token(Token = "0x40009FF")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private int fontSize;

	[Token(Token = "0x4000A00")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	public List<RubyInfo> rubyInfoList;

	[Token(Token = "0x4000A01")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private RubyTextEx rubyText;

	[Token(Token = "0x4000A02")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private RubyTextEx baseText;

	[Token(Token = "0x4000A03")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private float rubySizeRatio;

	[Token(Token = "0x4000A04")]
	private const string tagRuby = "$R";

	[Token(Token = "0x4000A05")]
	private const string tagRubyBegin = "(";

	[Token(Token = "0x4000A06")]
	private const string tagRubyEnd = ")";

	[Token(Token = "0x4000A07")]
	[FieldOffset(Offset = "0x48")]
	private RectTransform _rt;

	[Token(Token = "0x17000124")]
	private RectTransform rectTransform
	{
		[Token(Token = "0x6000AA9")]
		[Address(RVA = "0xC12B80", Offset = "0xC11D80", VA = "0x180C12B80")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000AAA")]
	[Address(RVA = "0xC121A0", Offset = "0xC113A0", VA = "0x180C121A0")]
	public static Lang GetLang(string locale)
	{
		return default(Lang);
	}

	[Token(Token = "0x6000AAB")]
	[Address(RVA = "0xC123D0", Offset = "0xC115D0", VA = "0x180C123D0")]
	public void SetText(string str, Lang lang, int fontsize, Color col)
	{
	}

	[Token(Token = "0x6000AAC")]
	[Address(RVA = "0xC126A0", Offset = "0xC118A0", VA = "0x180C126A0")]
	private void SetupText(string str, Lang lang)
	{
	}

	[Token(Token = "0x6000AAD")]
	[Address(RVA = "0xC12360", Offset = "0xC11560", VA = "0x180C12360")]
	private void SetFont(Lang lang)
	{
	}

	[Token(Token = "0x6000AAE")]
	[Address(RVA = "0xC12300", Offset = "0xC11500", VA = "0x180C12300")]
	private void SetFontSize(int size)
	{
	}

	[Token(Token = "0x6000AAF")]
	[Address(RVA = "0xC12280", Offset = "0xC11480", VA = "0x180C12280")]
	public void SetColor(Color col)
	{
	}

	[Token(Token = "0x6000AB0")]
	[Address(RVA = "0xC12170", Offset = "0xC11370", VA = "0x180C12170")]
	public float GetBaseTextWidth()
	{
		return default(float);
	}

	[Token(Token = "0x6000AB1")]
	[Address(RVA = "0xC12C10", Offset = "0xC11E10", VA = "0x180C12C10")]
	private void parseRubyTag(string sourceText, out string baseStr, out string rubyStr, string rubyTag = "$R", string rtTag = "(", string endTag = ")")
	{
	}

	[Token(Token = "0x6000AB2")]
	[Address(RVA = "0xC12B00", Offset = "0xC11D00", VA = "0x180C12B00")]
	public RubyRoot()
	{
	}
}
