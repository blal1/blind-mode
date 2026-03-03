using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Duel;

[Token(Token = "0x20019CA")]
public class CardRootTransitionArc : CardRootTransitionTimeBase
{
	[Token(Token = "0x400EE43")]
	[FieldOffset(Offset = "0x38")]
	private float time;

	[Token(Token = "0x400EE44")]
	[FieldOffset(Offset = "0x3C")]
	private Vector3 viaPos;

	[Token(Token = "0x400EE45")]
	[FieldOffset(Offset = "0x48")]
	private float p1;

	[Token(Token = "0x400EE46")]
	[FieldOffset(Offset = "0x4C")]
	private float p2;

	[Token(Token = "0x400EE47")]
	[FieldOffset(Offset = "0x50")]
	private float p3;

	[Token(Token = "0x400EE48")]
	[FieldOffset(Offset = "0x54")]
	private float dulVal;

	[Token(Token = "0x17001993")]
	protected override float dulation
	{
		[Token(Token = "0x600A654")]
		[Address(RVA = "0xF1B920", Offset = "0xF1AB20", VA = "0x180F1B920", Slot = "9")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x600A653")]
	[Address(RVA = "0xF1B8B0", Offset = "0xF1AAB0", VA = "0x180F1B8B0")]
	public CardRootTransitionArc(Vector3 viaPos, float p1, float p2, float p3, float dulVal)
	{
	}

	[Token(Token = "0x600A655")]
	[Address(RVA = "0xF1B600", Offset = "0xF1A800", VA = "0x180F1B600", Slot = "8")]
	protected override void UpdateTransition(float t)
	{
	}
}
