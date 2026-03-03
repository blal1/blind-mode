using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomGame.Duel;

[Token(Token = "0x2001930")]
public class SpecialWinVija : SpecialWinBase
{
	[Token(Token = "0x400EAFE")]
	[FieldOffset(Offset = "0x20")]
	private List<string> _seList;

	[Token(Token = "0x170018E5")]
	protected override string prefabPath
	{
		[Token(Token = "0x600A278")]
		[Address(RVA = "0xEFD620", Offset = "0xEFC820", VA = "0x180EFD620", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170018E6")]
	protected override List<string> seList
	{
		[Token(Token = "0x600A279")]
		[Address(RVA = "0x3D8370", Offset = "0x3D7570", VA = "0x1803D8370", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600A27A")]
	[Address(RVA = "0xEFD520", Offset = "0xEFC720", VA = "0x180EFD520")]
	public SpecialWinVija()
	{
	}
}
