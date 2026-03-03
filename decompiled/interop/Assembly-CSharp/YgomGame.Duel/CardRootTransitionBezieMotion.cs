using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Duel;

[Token(Token = "0x20019CB")]
public class CardRootTransitionBezieMotion : CardRootTransitionTimeBase
{
	[Token(Token = "0x400EE49")]
	[FieldOffset(Offset = "0x38")]
	private ChainedBezierMotion motion;

	[Token(Token = "0x400EE4A")]
	[FieldOffset(Offset = "0x40")]
	private Camera camera;

	[Token(Token = "0x17001994")]
	public ChainedBezierMotion bezierMotion
	{
		[Token(Token = "0x600A656")]
		[Address(RVA = "0x404860", Offset = "0x403A60", VA = "0x180404860")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001995")]
	protected override float dulation
	{
		[Token(Token = "0x600A65A")]
		[Address(RVA = "0xF1BE70", Offset = "0xF1B070", VA = "0x180F1BE70", Slot = "9")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x600A657")]
	[Address(RVA = "0xF1BDC0", Offset = "0xF1AFC0", VA = "0x180F1BDC0")]
	public CardRootTransitionBezieMotion(BezierMotionSetting[] motion, Camera camera)
	{
	}

	[Token(Token = "0x600A658")]
	[Address(RVA = "0xF1BD00", Offset = "0xF1AF00", VA = "0x180F1BD00")]
	public CardRootTransitionBezieMotion(BezierMotionSetting motion, Camera camera)
	{
	}

	[Token(Token = "0x600A659")]
	[Address(RVA = "0xF1B930", Offset = "0xF1AB30", VA = "0x180F1B930", Slot = "7")]
	public override void SetCardLocator(CardLocator fromLocator, CardLocator toLocator)
	{
	}

	[Token(Token = "0x600A65B")]
	[Address(RVA = "0xF1BA70", Offset = "0xF1AC70", VA = "0x180F1BA70", Slot = "8")]
	protected override void UpdateTransition(float t)
	{
	}
}
