using System;
using Il2CppDummyDll;

namespace YgomGame.MDMarkup;

[Serializable]
[Token(Token = "0x2000C86")]
public class MDMarkupContentH2 : MDMarkupContentH1
{
	[Token(Token = "0x17000A68")]
	public override MDMarkupDef.MarkupType markupType
	{
		[Token(Token = "0x6004BE1")]
		[Address(RVA = "0x44E380", Offset = "0x44D580", VA = "0x18044E380", Slot = "15")]
		get
		{
			return default(MDMarkupDef.MarkupType);
		}
	}

	[Token(Token = "0x17000A69")]
	public override int contentIndent
	{
		[Token(Token = "0x6004BE2")]
		[Address(RVA = "0x44E380", Offset = "0x44D580", VA = "0x18044E380", Slot = "16")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6004BE3")]
	[Address(RVA = "0x938990", Offset = "0x937B90", VA = "0x180938990")]
	public MDMarkupContentH2()
	{
	}

	[Token(Token = "0x6004BE4")]
	[Address(RVA = "0x938940", Offset = "0x937B40", VA = "0x180938940")]
	public MDMarkupContentH2(string rawText)
	{
	}
}
