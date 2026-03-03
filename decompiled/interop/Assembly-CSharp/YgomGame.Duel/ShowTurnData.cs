using Il2CppDummyDll;

namespace YgomGame.Duel;

[Token(Token = "0x2001916")]
public struct ShowTurnData
{
	[Token(Token = "0x400EA84")]
	[FieldOffset(Offset = "0x0")]
	public ulong bitdata0;

	[Token(Token = "0x400EA85")]
	[FieldOffset(Offset = "0x8")]
	public uint bitdata1;

	[Token(Token = "0x400EA86")]
	[FieldOffset(Offset = "0xC")]
	public int restlpl;

	[Token(Token = "0x400EA87")]
	[FieldOffset(Offset = "0x10")]
	public int restlpr;

	[Token(Token = "0x170018B9")]
	public int playeridc
	{
		[Token(Token = "0x600A1BA")]
		[Address(RVA = "0xEF93E0", Offset = "0xEF85E0", VA = "0x180EF93E0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170018BA")]
	public int turn
	{
		[Token(Token = "0x600A1BB")]
		[Address(RVA = "0xEF9410", Offset = "0xEF8610", VA = "0x180EF9410")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170018BB")]
	public int playeridl
	{
		[Token(Token = "0x600A1BC")]
		[Address(RVA = "0xEF93F0", Offset = "0xEF85F0", VA = "0x180EF93F0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170018BC")]
	public int playeridr
	{
		[Token(Token = "0x600A1BD")]
		[Address(RVA = "0xEF9400", Offset = "0xEF8600", VA = "0x180EF9400")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x600A1BE")]
	[Address(RVA = "0xEF93A0", Offset = "0xEF85A0", VA = "0x180EF93A0")]
	public ShowTurnData(int playeridl, int playeridr, int restlpl, int restlpr, int turn, int playerid)
	{
	}
}
