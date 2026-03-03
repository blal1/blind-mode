using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace YgomGame.Duel;

[Token(Token = "0x2001A14")]
public class LocationInfo
{
	[Token(Token = "0x2001A15")]
	public delegate void UpdateCallback();

	[Token(Token = "0x400F08C")]
	[FieldOffset(Offset = "0x10")]
	public int player;

	[Token(Token = "0x400F08D")]
	[FieldOffset(Offset = "0x14")]
	public int position;

	[Token(Token = "0x400F08E")]
	[FieldOffset(Offset = "0x18")]
	public int index;

	[Token(Token = "0x140000DA")]
	public event UpdateCallback updateCallback
	{
		[Token(Token = "0x600A88C")]
		[Address(RVA = "0xF5E700", Offset = "0xF5D900", VA = "0x180F5E700")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x600A88D")]
		[Address(RVA = "0xF5E7A0", Offset = "0xF5D9A0", VA = "0x180F5E7A0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x600A88E")]
	[Address(RVA = "0xF5E680", Offset = "0xF5D880", VA = "0x180F5E680")]
	public void Initialize()
	{
	}

	[Token(Token = "0x600A88F")]
	[Address(RVA = "0xF5E6D0", Offset = "0xF5D8D0", VA = "0x180F5E6D0")]
	public void Set(int player, int position, int index)
	{
	}

	[Token(Token = "0x600A890")]
	[Address(RVA = "0xF5E680", Offset = "0xF5D880", VA = "0x180F5E680")]
	public void Reset()
	{
	}

	[Token(Token = "0x600A891")]
	[Address(RVA = "0xF5E6B0", Offset = "0xF5D8B0", VA = "0x180F5E6B0")]
	public bool IsEquals(int player, int position, int index)
	{
		return default(bool);
	}

	[Token(Token = "0x600A892")]
	[Address(RVA = "0xF5E660", Offset = "0xF5D860", VA = "0x180F5E660")]
	public int GetIndex(int player, int position)
	{
		return default(int);
	}

	[Token(Token = "0x600A893")]
	[Address(RVA = "0x615660", Offset = "0x614860", VA = "0x180615660")]
	public void Terminate()
	{
	}

	[Token(Token = "0x600A894")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public LocationInfo()
	{
	}
}
