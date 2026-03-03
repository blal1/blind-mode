using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Duel;

[Token(Token = "0x20019CE")]
public class CardRootTransitionShuffle : CardRootTransitionTimeBase
{
	[Token(Token = "0x20019CF")]
	private enum Step
	{
		[Token(Token = "0x400EE53")]
		GoCenter,
		[Token(Token = "0x400EE54")]
		WaitPause,
		[Token(Token = "0x400EE55")]
		GoToLocator,
		[Token(Token = "0x400EE56")]
		Finish
	}

	[Token(Token = "0x400EE4C")]
	[FieldOffset(Offset = "0x38")]
	private Vector3 pausePos;

	[Token(Token = "0x400EE4D")]
	[FieldOffset(Offset = "0x44")]
	private Step step;

	[Token(Token = "0x400EE4E")]
	private const float timeToMove1 = 0f;

	[Token(Token = "0x400EE4F")]
	private const float timeToPause = 0.3f;

	[Token(Token = "0x400EE50")]
	private const float timeToMove2 = 0.7f;

	[Token(Token = "0x400EE51")]
	private const float timeOfEnd = 1f;

	[Token(Token = "0x600A660")]
	[Address(RVA = "0xF1C7D0", Offset = "0xF1B9D0", VA = "0x180F1C7D0")]
	public CardRootTransitionShuffle(Vector3 pausePos)
	{
	}

	[Token(Token = "0x600A661")]
	[Address(RVA = "0xF1C4B0", Offset = "0xF1B6B0", VA = "0x180F1C4B0", Slot = "8")]
	protected override void UpdateTransition(float t)
	{
	}
}
