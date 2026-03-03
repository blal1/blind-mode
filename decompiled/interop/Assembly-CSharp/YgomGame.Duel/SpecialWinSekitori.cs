using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomGame.Duel;

[Token(Token = "0x200192F")]
public class SpecialWinSekitori : SpecialWinBase
{
	[Token(Token = "0x400EAFD")]
	[FieldOffset(Offset = "0x20")]
	private List<string> _seList;

	[Token(Token = "0x170018E3")]
	protected override string prefabPath
	{
		[Token(Token = "0x600A275")]
		[Address(RVA = "0xEFD4F0", Offset = "0xEFC6F0", VA = "0x180EFD4F0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170018E4")]
	protected override List<string> seList
	{
		[Token(Token = "0x600A276")]
		[Address(RVA = "0x3D8370", Offset = "0x3D7570", VA = "0x1803D8370", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600A277")]
	[Address(RVA = "0xEFD3F0", Offset = "0xEFC5F0", VA = "0x180EFD3F0")]
	public SpecialWinSekitori()
	{
	}
}
