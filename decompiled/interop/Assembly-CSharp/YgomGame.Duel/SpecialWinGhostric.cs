using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomGame.Duel;

[Token(Token = "0x200192E")]
public class SpecialWinGhostric : SpecialWinBase
{
	[Token(Token = "0x400EAFC")]
	[FieldOffset(Offset = "0x20")]
	private List<string> _seList;

	[Token(Token = "0x170018E1")]
	protected override string prefabPath
	{
		[Token(Token = "0x600A272")]
		[Address(RVA = "0xEFD3C0", Offset = "0xEFC5C0", VA = "0x180EFD3C0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170018E2")]
	protected override List<string> seList
	{
		[Token(Token = "0x600A273")]
		[Address(RVA = "0x3D8370", Offset = "0x3D7570", VA = "0x1803D8370", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600A274")]
	[Address(RVA = "0xEFD2C0", Offset = "0xEFC4C0", VA = "0x180EFD2C0")]
	public SpecialWinGhostric()
	{
	}
}
