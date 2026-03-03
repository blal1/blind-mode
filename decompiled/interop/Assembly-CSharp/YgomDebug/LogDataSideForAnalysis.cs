using System;
using Il2CppDummyDll;
using YgomGame.Duel;

namespace YgomDebug;

[Serializable]
[Token(Token = "0x200012A")]
public struct LogDataSideForAnalysis
{
	[Token(Token = "0x4000719")]
	[FieldOffset(Offset = "0x0")]
	private int dataint;

	[Token(Token = "0x400071A")]
	[FieldOffset(Offset = "0x4")]
	private byte boolbits;

	[Token(Token = "0x400071B")]
	[FieldOffset(Offset = "0x5")]
	private byte databyte0;

	[Token(Token = "0x400071C")]
	[FieldOffset(Offset = "0x6")]
	private byte databyte1;

	[Token(Token = "0x400071D")]
	[FieldOffset(Offset = "0x7")]
	private byte datatype;

	[Token(Token = "0x170000B5")]
	private bool show
	{
		[Token(Token = "0x600078B")]
		[Address(RVA = "0x9D5DA0", Offset = "0x9D4FA0", VA = "0x1809D5DA0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170000B6")]
	public bool isCardDataShow
	{
		[Token(Token = "0x6000793")]
		[Address(RVA = "0x9D5D40", Offset = "0x9D4F40", VA = "0x1809D5D40")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170000B7")]
	public int cardid
	{
		[Token(Token = "0x6000794")]
		[Address(RVA = "0x9D5900", Offset = "0x9D4B00", VA = "0x1809D5900")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170000B8")]
	public int effectid
	{
		[Token(Token = "0x6000795")]
		[Address(RVA = "0x9D5910", Offset = "0x9D4B10", VA = "0x1809D5910")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170000B9")]
	public int position
	{
		[Token(Token = "0x6000796")]
		[Address(RVA = "0x9D5D90", Offset = "0x9D4F90", VA = "0x1809D5D90")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170000BA")]
	public int owner
	{
		[Token(Token = "0x6000797")]
		[Address(RVA = "0x9D5D80", Offset = "0x9D4F80", VA = "0x1809D5D80")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170000BB")]
	public bool turned
	{
		[Token(Token = "0x6000798")]
		[Address(RVA = "0x9D5DB0", Offset = "0x9D4FB0", VA = "0x1809D5DB0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170000BC")]
	public bool insight
	{
		[Token(Token = "0x6000799")]
		[Address(RVA = "0x9D5D30", Offset = "0x9D4F30", VA = "0x1809D5D30")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170000BD")]
	public bool face
	{
		[Token(Token = "0x600079A")]
		[Address(RVA = "0x9D5D20", Offset = "0x9D4F20", VA = "0x1809D5D20")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170000BE")]
	public bool isoverlayunit
	{
		[Token(Token = "0x600079B")]
		[Address(RVA = "0x9D5D70", Offset = "0x9D4F70", VA = "0x1809D5D70")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170000BF")]
	public bool isIconDataShow
	{
		[Token(Token = "0x600079C")]
		[Address(RVA = "0x9D5D60", Offset = "0x9D4F60", VA = "0x1809D5D60")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170000C0")]
	public bool isDataValid
	{
		[Token(Token = "0x600079D")]
		[Address(RVA = "0x9D5D50", Offset = "0x9D4F50", VA = "0x1809D5D50")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170000C1")]
	public int playerid
	{
		[Token(Token = "0x600079E")]
		[Address(RVA = "0x8C8B50", Offset = "0x8C7D50", VA = "0x1808C8B50")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x600078C")]
	[Address(RVA = "0x9D5CF0", Offset = "0x9D4EF0", VA = "0x1809D5CF0")]
	public LogDataSideForAnalysis(LogDataSide logDataSide)
	{
	}

	[Token(Token = "0x600078D")]
	[Address(RVA = "0x9D5CD0", Offset = "0x9D4ED0", VA = "0x1809D5CD0")]
	public LogDataSideForAnalysis(byte datatype)
	{
	}

	[Token(Token = "0x600078E")]
	[Address(RVA = "0x9D5BA0", Offset = "0x9D4DA0", VA = "0x1809D5BA0")]
	public LogDataSideForAnalysis(bool show, int cardid, int owner, int position, bool turned, bool face, bool insight, int effectid)
	{
	}

	[Token(Token = "0x600078F")]
	[Address(RVA = "0x9D5B00", Offset = "0x9D4D00", VA = "0x1809D5B00")]
	public LogDataSideForAnalysis(bool show, int cardid, int owner, int position, bool turned, bool face, bool insight)
	{
	}

	[Token(Token = "0x6000790")]
	[Address(RVA = "0x9D5C40", Offset = "0x9D4E40", VA = "0x1809D5C40")]
	public LogDataSideForAnalysis(bool show, int cardid, int owner, int position, int index, bool turned, bool face, bool insight)
	{
	}

	[Token(Token = "0x6000791")]
	[Address(RVA = "0x9D5B90", Offset = "0x9D4D90", VA = "0x1809D5B90")]
	public LogDataSideForAnalysis(bool show, int playerid)
	{
	}

	[Token(Token = "0x6000792")]
	[Address(RVA = "0x9D59D0", Offset = "0x9D4BD0", VA = "0x1809D59D0")]
	public void AddEffectId(int effectid)
	{
	}

	[Token(Token = "0x600079F")]
	[Address(RVA = "0x9D59E0", Offset = "0x9D4BE0", VA = "0x1809D59E0")]
	public (int, byte, byte, bool, bool) GetCardData()
	{
		return default((int, byte, byte, bool, bool));
	}

	[Token(Token = "0x60007A0")]
	[Address(RVA = "0x9D5A90", Offset = "0x9D4C90", VA = "0x1809D5A90")]
	public (int, bool) GetIconData()
	{
		return default((int, bool));
	}
}
