using System.Collections.Generic;
using Il2CppDummyDll;
using YgomSystem.ElementSystem;

namespace YgomGame.Duel;

[Token(Token = "0x2001914")]
public class LogShowText : LogItemBase
{
	[Token(Token = "0x400EA77")]
	[FieldOffset(Offset = "0x0")]
	public static List<string> m_TextTable;

	[Token(Token = "0x400EA78")]
	[FieldOffset(Offset = "0x50")]
	protected string LABEL_EO_CONTENT;

	[Token(Token = "0x400EA79")]
	[FieldOffset(Offset = "0x58")]
	protected string LABEL_EO_COLORBARTEAM0;

	[Token(Token = "0x400EA7A")]
	[FieldOffset(Offset = "0x60")]
	protected string LABEL_EO_COLORBARTEAM1;

	[Token(Token = "0x400EA7B")]
	[FieldOffset(Offset = "0x68")]
	protected string LABEL_EO_TEXT;

	[Token(Token = "0x400EA7C")]
	[FieldOffset(Offset = "0x70")]
	private ElementObjectManager m_EOManager_Origin;

	[Token(Token = "0x170018B8")]
	protected ElementObjectManager m_EOManager
	{
		[Token(Token = "0x600A1B0")]
		[Address(RVA = "0xEF3E50", Offset = "0xEF3050", VA = "0x180EF3E50")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600A1AF")]
	[Address(RVA = "0xEF3B70", Offset = "0xEF2D70", VA = "0x180EF3B70")]
	public void SetData(ShowTextData data)
	{
	}

	[Token(Token = "0x600A1B1")]
	[Address(RVA = "0xEF3D80", Offset = "0xEF2F80", VA = "0x180EF3D80")]
	public LogShowText()
	{
	}
}
