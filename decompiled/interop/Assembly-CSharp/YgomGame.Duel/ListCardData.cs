using Il2CppDummyDll;

namespace YgomGame.Duel;

[Token(Token = "0x20018EB")]
public class ListCardData
{
	[Token(Token = "0x20018EC")]
	public enum DataSource
	{
		[Token(Token = "0x400E953")]
		FromPosSelectList,
		[Token(Token = "0x400E954")]
		FromGetCommandMask,
		[Token(Token = "0x400E955")]
		FromRunList,
		[Token(Token = "0x400E956")]
		FromLocalCollection
	}

	[Token(Token = "0x20018ED")]
	public struct ArrowInfo
	{
		[Token(Token = "0x400E957")]
		[FieldOffset(Offset = "0x0")]
		public int player;

		[Token(Token = "0x400E958")]
		[FieldOffset(Offset = "0x4")]
		public int position;
	}

	[Token(Token = "0x400E942")]
	[FieldOffset(Offset = "0x10")]
	public bool selectted;

	[Token(Token = "0x400E943")]
	[FieldOffset(Offset = "0x11")]
	public bool forceinsgiht;

	[Token(Token = "0x400E944")]
	[FieldOffset(Offset = "0x12")]
	public bool extraExcludeFlag;

	[Token(Token = "0x400E945")]
	[FieldOffset(Offset = "0x13")]
	public bool targetted;

	[Token(Token = "0x400E946")]
	[FieldOffset(Offset = "0x14")]
	public byte styleid;

	[Token(Token = "0x400E947")]
	[FieldOffset(Offset = "0x15")]
	public byte chainnum;

	[Token(Token = "0x400E948")]
	[FieldOffset(Offset = "0x18")]
	public int cardid;

	[Token(Token = "0x400E949")]
	[FieldOffset(Offset = "0x1C")]
	public int badgeindex;

	[Token(Token = "0x400E94A")]
	[FieldOffset(Offset = "0x20")]
	public int listIndexForEngine;

	[Token(Token = "0x400E94B")]
	[FieldOffset(Offset = "0x24")]
	public int dataindex;

	[Token(Token = "0x400E94C")]
	[FieldOffset(Offset = "0x28")]
	public int textid;

	[Token(Token = "0x400E94D")]
	[FieldOffset(Offset = "0x2C")]
	public int targetUid;

	[Token(Token = "0x400E94E")]
	[FieldOffset(Offset = "0x30")]
	public Engine.CardStatus cardstatus;

	[Token(Token = "0x400E94F")]
	[FieldOffset(Offset = "0x48")]
	public Engine.BasicVal basicval;

	[Token(Token = "0x400E950")]
	[FieldOffset(Offset = "0x68")]
	public ArrowInfo arrowInfo;

	[Token(Token = "0x400E951")]
	[FieldOffset(Offset = "0x70")]
	public DataSource dataSource;

	[Token(Token = "0x17001861")]
	public bool hasInstance
	{
		[Token(Token = "0x600A08F")]
		[Address(RVA = "0xEDEFC0", Offset = "0xEDE1C0", VA = "0x180EDEFC0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001862")]
	public int uniqueid
	{
		[Token(Token = "0x600A090")]
		[Address(RVA = "0xEDF0F0", Offset = "0xEDE2F0", VA = "0x180EDF0F0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17001863")]
	public bool insight
	{
		[Token(Token = "0x600A091")]
		[Address(RVA = "0xEDEFE0", Offset = "0xEDE1E0", VA = "0x180EDEFE0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001864")]
	public bool isknown
	{
		[Token(Token = "0x600A092")]
		[Address(RVA = "0xEDF060", Offset = "0xEDE260", VA = "0x180EDF060")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600A093")]
	[Address(RVA = "0xEDEF00", Offset = "0xEDE100", VA = "0x180EDEF00")]
	public ListCardData(int cardid, int styleid, Engine.BasicVal basicval, Engine.CardStatus cardstatus, ArrowInfo arrowInfo, bool forceinsgiht, int listIndexForEngine, int chainnum, DataSource dataSource, int textid = 0, int targetUid = -1, bool extraExcludeFlag = false)
	{
	}

	[Token(Token = "0x600A094")]
	[Address(RVA = "0xEDEE40", Offset = "0xEDE040", VA = "0x180EDEE40")]
	public ListCardData(int cardid, int listIndexForEngine)
	{
	}
}
