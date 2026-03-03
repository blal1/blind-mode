using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Duel;

[Token(Token = "0x20019CC")]
public class CardRootTransitionDeckToDeck : CardRootTransitionTimeBase
{
	[Token(Token = "0x400EE4B")]
	[FieldOffset(Offset = "0x38")]
	private Vector3 ofs;

	[Token(Token = "0x600A65C")]
	[Address(RVA = "0xF1C160", Offset = "0xF1B360", VA = "0x180F1C160")]
	public CardRootTransitionDeckToDeck(int team)
	{
	}

	[Token(Token = "0x600A65D")]
	[Address(RVA = "0xF1BE90", Offset = "0xF1B090", VA = "0x180F1BE90", Slot = "8")]
	protected override void UpdateTransition(float t)
	{
	}
}
