using System;
using Il2CppDummyDll;
using YgomGame.Utility;

namespace YgomGame.Duel;

[Token(Token = "0x2001949")]
public class BezierMotionContainerManager : ScriptableObjectManager<BezierMotionContainer>
{
	[Token(Token = "0x400EB92")]
	public const string motionPathDrawPhaseDrawFirst = "Duel/ScriptableObject/BezierMotion/MotionContainerDrawFirst";

	[Token(Token = "0x400EB93")]
	public const string motionPathDrawPhaseDrawLatter = "Duel/ScriptableObject/BezierMotion/MotionContainerDrawLatter";

	[Token(Token = "0x400EB94")]
	public const string motionPathDrawPhaseToHand = "Duel/ScriptableObject/BezierMotion/MotionContainerDrawToHand";

	[Token(Token = "0x400EB95")]
	public const string motionPathDrawPhaseDeckCenter = "Duel/ScriptableObject/BezierMotion/MotionContainerDeckCenter";

	[Token(Token = "0x400EB96")]
	public const string motionPathDrawPhaseDeckBack = "Duel/ScriptableObject/BezierMotion/MotionContainerDeckBack";

	[Token(Token = "0x400EB97")]
	public const string motionPathCardMoveStrongSummon = "Duel/ScriptableObject/BezierMotion/CardMoveMotion/MotionContainerStrongSummon";

	[Token(Token = "0x400EB98")]
	public const string motionPathCardMoveSearchEffect = "Duel/ScriptableObject/BezierMotion/CardMoveMotion/MotionContainerSearchEffect";

	[Token(Token = "0x400EB99")]
	public const string motionPathDeckReverse = "Duel/ScriptableObject/BezierMotion/MosionContainerDeckReverse";

	[Token(Token = "0x600A2DF")]
	[Address(RVA = "0xEEA4D0", Offset = "0xEE96D0", VA = "0x180EEA4D0")]
	public static void Setup(Action on_finished)
	{
	}

	[Token(Token = "0x600A2E0")]
	[Address(RVA = "0xEEA780", Offset = "0xEE9980", VA = "0x180EEA780")]
	public BezierMotionContainerManager()
	{
	}
}
