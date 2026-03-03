using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace YgomGame.Duel;

[Token(Token = "0x2001A13")]
public class DuelCursor
{
	[Token(Token = "0x170019F8")]
	public LocationInfo selectLocation
	{
		[Token(Token = "0x600A885")]
		[Address(RVA = "0x40C440", Offset = "0x40B640", VA = "0x18040C440")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600A886")]
		[Address(RVA = "0x439010", Offset = "0x438210", VA = "0x180439010")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x170019F9")]
	public LocationInfo decideLocation
	{
		[Token(Token = "0x600A887")]
		[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600A888")]
		[Address(RVA = "0x417C80", Offset = "0x416E80", VA = "0x180417C80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x600A889")]
	[Address(RVA = "0xF4A130", Offset = "0xF49330", VA = "0x180F4A130")]
	public void Initialize(DuelClient host)
	{
	}

	[Token(Token = "0x600A88A")]
	[Address(RVA = "0xF4A220", Offset = "0xF49420", VA = "0x180F4A220")]
	public void Terminate()
	{
	}

	[Token(Token = "0x600A88B")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public DuelCursor()
	{
	}
}
