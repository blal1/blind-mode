using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace YgomGame.Deck;

[Serializable]
[Token(Token = "0x2001067")]
public struct CardBaseData : IEquatable<CardBaseData>
{
	[Token(Token = "0x17000FBD")]
	public int CardID
	{
		[Token(Token = "0x60063E4")]
		[Address(RVA = "0x8C8B50", Offset = "0x8C7D50", VA = "0x1808C8B50")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Token(Token = "0x60063E5")]
		[Address(RVA = "0x8C8B60", Offset = "0x8C7D60", VA = "0x1808C8B60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000FBE")]
	public int PremiumID
	{
		[Token(Token = "0x60063E6")]
		[Address(RVA = "0x9D59A0", Offset = "0x9D4BA0", VA = "0x1809D59A0")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Token(Token = "0x60063E7")]
		[Address(RVA = "0xAA0C40", Offset = "0xA9FE40", VA = "0x180AA0C40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000FBF")]
	public bool IsOwned
	{
		[Token(Token = "0x60063E8")]
		[Address(RVA = "0xAA0BB0", Offset = "0xA9FDB0", VA = "0x180AA0BB0")]
		[CompilerGenerated]
		readonly get
		{
			return default(bool);
		}
		[Token(Token = "0x60063E9")]
		[Address(RVA = "0xAA0C20", Offset = "0xA9FE20", VA = "0x180AA0C20")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000FC0")]
	public int Obtained
	{
		[Token(Token = "0x60063EA")]
		[Address(RVA = "0xAA0BC0", Offset = "0xA9FDC0", VA = "0x180AA0BC0")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Token(Token = "0x60063EB")]
		[Address(RVA = "0xAA0C30", Offset = "0xA9FE30", VA = "0x180AA0C30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000FC1")]
	public int Inventory
	{
		[Token(Token = "0x60063EC")]
		[Address(RVA = "0x3C7100", Offset = "0x3C6300", VA = "0x1803C7100")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Token(Token = "0x60063ED")]
		[Address(RVA = "0x5F4710", Offset = "0x5F3910", VA = "0x1805F4710")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000FC2")]
	public int Rarity
	{
		[Token(Token = "0x60063EE")]
		[Address(RVA = "0x64B770", Offset = "0x64A970", VA = "0x18064B770")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Token(Token = "0x60063EF")]
		[Address(RVA = "0x64B780", Offset = "0x64A980", VA = "0x18064B780")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000FC3")]
	public bool IsRental
	{
		[Token(Token = "0x60063F0")]
		[Address(RVA = "0x444790", Offset = "0x443990", VA = "0x180444790")]
		[CompilerGenerated]
		readonly get
		{
			return default(bool);
		}
		[Token(Token = "0x60063F1")]
		[Address(RVA = "0x662770", Offset = "0x661970", VA = "0x180662770")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000FC4")]
	public bool IsAutoBuild
	{
		[Token(Token = "0x60063F2")]
		[Address(RVA = "0x7CE720", Offset = "0x7CD920", VA = "0x1807CE720")]
		[CompilerGenerated]
		readonly get
		{
			return default(bool);
		}
		[Token(Token = "0x60063F3")]
		[Address(RVA = "0xAA0C10", Offset = "0xA9FE10", VA = "0x180AA0C10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x60063F4")]
	[Address(RVA = "0xAA0B00", Offset = "0xA9FD00", VA = "0x180AA0B00")]
	public CardBaseData(int c_id = 0, int p_id = 0, bool owned = true, bool rental = false, bool autoBuild = false)
	{
	}

	[Token(Token = "0x60063F5")]
	[Address(RVA = "0xAA0BD0", Offset = "0xA9FDD0", VA = "0x180AA0BD0")]
	public static bool operator ==(CardBaseData a, CardBaseData b)
	{
		return default(bool);
	}

	[Token(Token = "0x60063F6")]
	[Address(RVA = "0xAA0BF0", Offset = "0xA9FDF0", VA = "0x180AA0BF0")]
	public static bool operator !=(CardBaseData a, CardBaseData b)
	{
		return default(bool);
	}

	[Token(Token = "0x60063F7")]
	[Address(RVA = "0xAA0A40", Offset = "0xA9FC40", VA = "0x180AA0A40", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x60063F8")]
	[Address(RVA = "0xAA0A20", Offset = "0xA9FC20", VA = "0x180AA0A20", Slot = "4")]
	public bool Equals(CardBaseData data)
	{
		return default(bool);
	}

	[Token(Token = "0x60063F9")]
	[Address(RVA = "0xAA0AF0", Offset = "0xA9FCF0", VA = "0x180AA0AF0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
