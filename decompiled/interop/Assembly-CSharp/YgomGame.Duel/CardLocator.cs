using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Duel;

[Serializable]
[Token(Token = "0x2001983")]
public class CardLocator
{
	[Token(Token = "0x400EC9A")]
	[FieldOffset(Offset = "0x14")]
	private int m_index;

	[Token(Token = "0x400EC9B")]
	[FieldOffset(Offset = "0x18")]
	private int m_viewIndex;

	[Token(Token = "0x400EC9C")]
	[FieldOffset(Offset = "0x1C")]
	private Vector3 _pos;

	[Token(Token = "0x400EC9D")]
	[FieldOffset(Offset = "0x28")]
	private Quaternion _rot;

	[Token(Token = "0x17001900")]
	public bool removed
	{
		[Token(Token = "0x600A3B0")]
		[Address(RVA = "0x465880", Offset = "0x464A80", VA = "0x180465880")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600A3B1")]
		[Address(RVA = "0x71FA70", Offset = "0x71EC70", VA = "0x18071FA70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17001901")]
	public int index
	{
		[Token(Token = "0x600A3B2")]
		[Address(RVA = "0x64B770", Offset = "0x64A970", VA = "0x18064B770")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600A3B3")]
		[Address(RVA = "0xF08280", Offset = "0xF07480", VA = "0x180F08280")]
		set
		{
		}
	}

	[Token(Token = "0x17001902")]
	public int viewIndex
	{
		[Token(Token = "0x600A3B4")]
		[Address(RVA = "0x5C7C60", Offset = "0x5C6E60", VA = "0x1805C7C60")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600A3B5")]
		[Address(RVA = "0x615AB0", Offset = "0x614CB0", VA = "0x180615AB0")]
		set
		{
		}
	}

	[Token(Token = "0x17001903")]
	public Vector3 pos
	{
		[Token(Token = "0x600A3B6")]
		[Address(RVA = "0xF08080", Offset = "0xF07280", VA = "0x180F08080")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x600A3B7")]
		[Address(RVA = "0xF082B0", Offset = "0xF074B0", VA = "0x180F082B0")]
		set
		{
		}
	}

	[Token(Token = "0x17001904")]
	public Quaternion rot
	{
		[Token(Token = "0x600A3B8")]
		[Address(RVA = "0xF080F0", Offset = "0xF072F0", VA = "0x180F080F0")]
		get
		{
			return default(Quaternion);
		}
		[Token(Token = "0x600A3B9")]
		[Address(RVA = "0xF082D0", Offset = "0xF074D0", VA = "0x180F082D0")]
		set
		{
		}
	}

	[Token(Token = "0x17001905")]
	public Vector3 scale
	{
		[Token(Token = "0x600A3BA")]
		[Address(RVA = "0xF08260", Offset = "0xF07460", VA = "0x180F08260")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x600A3BB")]
		[Address(RVA = "0xF082E0", Offset = "0xF074E0", VA = "0x180F082E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17001906")]
	public CardPlace cardPlace
	{
		[Token(Token = "0x600A3BC")]
		[Address(RVA = "0x414E80", Offset = "0x414080", VA = "0x180414E80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600A3BD")]
		[Address(RVA = "0x414E90", Offset = "0x414090", VA = "0x180414E90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17001907")]
	public int refCounter
	{
		[Token(Token = "0x600A3BE")]
		[Address(RVA = "0x49BD90", Offset = "0x49AF90", VA = "0x18049BD90")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600A3BF")]
		[Address(RVA = "0x49C4A0", Offset = "0x49B6A0", VA = "0x18049C4A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17001908")]
	public Vector3 posOffsetORU
	{
		[Token(Token = "0x600A3C0")]
		[Address(RVA = "0xF08060", Offset = "0xF07260", VA = "0x180F08060")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x600A3C1")]
		[Address(RVA = "0xF082A0", Offset = "0xF074A0", VA = "0x180F082A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17001909")]
	public Quaternion rotOffsetORU
	{
		[Token(Token = "0x600A3C2")]
		[Address(RVA = "0xF080E0", Offset = "0xF072E0", VA = "0x180F080E0")]
		[CompilerGenerated]
		get
		{
			return default(Quaternion);
		}
		[Token(Token = "0x600A3C3")]
		[Address(RVA = "0xF082C0", Offset = "0xF074C0", VA = "0x180F082C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x1700190A")]
	public Vector3 posOffsetHand
	{
		[Token(Token = "0x600A3C4")]
		[Address(RVA = "0xF08040", Offset = "0xF07240", VA = "0x180F08040")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x600A3C5")]
		[Address(RVA = "0xF08290", Offset = "0xF07490", VA = "0x180F08290")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x600A3C6")]
	[Address(RVA = "0xF07D80", Offset = "0xF06F80", VA = "0x180F07D80", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x600A3C7")]
	[Address(RVA = "0xF07E90", Offset = "0xF07090", VA = "0x180F07E90", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600A3C8")]
	[Address(RVA = "0xF07F30", Offset = "0xF07130", VA = "0x180F07F30")]
	public void ResetOffset()
	{
	}

	[Token(Token = "0x600A3C9")]
	[Address(RVA = "0xF07FF0", Offset = "0xF071F0", VA = "0x180F07FF0")]
	public CardLocator()
	{
	}
}
