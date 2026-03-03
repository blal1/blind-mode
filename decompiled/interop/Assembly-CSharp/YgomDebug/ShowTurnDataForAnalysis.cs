using System;
using Il2CppDummyDll;
using YgomGame.Duel;

namespace YgomDebug;

[Serializable]
[Token(Token = "0x2000139")]
public struct ShowTurnDataForAnalysis
{
	[Token(Token = "0x4000781")]
	[FieldOffset(Offset = "0x0")]
	public ulong bitdata0;

	[Token(Token = "0x4000782")]
	[FieldOffset(Offset = "0x8")]
	public uint bitdata1;

	[Token(Token = "0x4000783")]
	[FieldOffset(Offset = "0xC")]
	public int restlpl;

	[Token(Token = "0x4000784")]
	[FieldOffset(Offset = "0x10")]
	public int restlpr;

	[Token(Token = "0x170000DB")]
	public int playeridc
	{
		[Token(Token = "0x60007EE")]
		[Address(RVA = "0x9E5580", Offset = "0x9E4780", VA = "0x1809E5580")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170000DC")]
	public int turn
	{
		[Token(Token = "0x60007EF")]
		[Address(RVA = "0x9E55E0", Offset = "0x9E47E0", VA = "0x1809E55E0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170000DD")]
	public int playeridl
	{
		[Token(Token = "0x60007F0")]
		[Address(RVA = "0x9E55A0", Offset = "0x9E47A0", VA = "0x1809E55A0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170000DE")]
	public int playeridr
	{
		[Token(Token = "0x60007F1")]
		[Address(RVA = "0x9E55C0", Offset = "0x9E47C0", VA = "0x1809E55C0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x60007F2")]
	[Address(RVA = "0x9E5560", Offset = "0x9E4760", VA = "0x1809E5560")]
	public ShowTurnDataForAnalysis(ShowTurnData showTurnData)
	{
	}
}
