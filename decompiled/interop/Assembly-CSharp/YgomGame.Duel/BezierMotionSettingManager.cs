using System;
using Il2CppDummyDll;
using YgomGame.Utility;

namespace YgomGame.Duel;

[Token(Token = "0x200195A")]
public class BezierMotionSettingManager : ScriptableObjectManager<BezierMotionSetting>
{
	[Token(Token = "0x400EBE7")]
	public const string motionPathCardShowMoveHandNear = "Duel/ScriptableObject/BezierMotion/CardShowMoveHandNear";

	[Token(Token = "0x400EBE8")]
	public const string motionPathCardShowMoveHandFar = "Duel/ScriptableObject/BezierMotion/CardShowMoveHandFar";

	[Token(Token = "0x400EBE9")]
	public const string motionPathCardShowMoveFieldNear = "Duel/ScriptableObject/BezierMotion/CardShowMoveFieldNear";

	[Token(Token = "0x400EBEA")]
	public const string motionPathCardShowMoveFieldFar = "Duel/ScriptableObject/BezierMotion/CardShowMoveFieldFar";

	[Token(Token = "0x400EBEB")]
	public const string motionPathCardShowBackHandNear = "Duel/ScriptableObject/BezierMotion/CardShowBackHandNear";

	[Token(Token = "0x400EBEC")]
	public const string motionPathCardShowBackHandFar = "Duel/ScriptableObject/BezierMotion/CardShowBackHandFar";

	[Token(Token = "0x400EBED")]
	public const string motionPathCardShowBackFieldNear = "Duel/ScriptableObject/BezierMotion/CardShowBackFieldNear";

	[Token(Token = "0x400EBEE")]
	public const string motionPathCardShowBackFieldFar = "Duel/ScriptableObject/BezierMotion/CardShowBackFieldFar";

	[Token(Token = "0x400EBEF")]
	public const string motionPathCardShowApplyMoveHandNear = "Duel/ScriptableObject/BezierMotion/CardShowApplyMoveHandNear";

	[Token(Token = "0x400EBF0")]
	public const string motionPathCardShowApplyMoveHandFar = "Duel/ScriptableObject/BezierMotion/CardShowApplyMoveHandFar";

	[Token(Token = "0x400EBF1")]
	public const string motionPathCardShowApplyMoveFieldNear = "Duel/ScriptableObject/BezierMotion/CardShowApplyMoveFieldNear";

	[Token(Token = "0x400EBF2")]
	public const string motionPathCardShowApplyMoveFieldFar = "Duel/ScriptableObject/BezierMotion/CardShowApplyMoveFieldFar";

	[Token(Token = "0x400EBF3")]
	public const string motionPathCardShowApplyBack = "Duel/ScriptableObject/BezierMotion/CardShowApplyBack";

	[Token(Token = "0x400EBF4")]
	public const string motionPathCardShowHappen = "Duel/ScriptableObject/BezierMotion/CardShowHappen";

	[Token(Token = "0x400EBF5")]
	public const string motionPathCardShowDisabled = "Duel/ScriptableObject/BezierMotion/CardShowDisabled";

	[Token(Token = "0x400EBF6")]
	public const string motionPathCardShowApply = "Duel/ScriptableObject/BezierMotion/CardShowApply";

	[Token(Token = "0x400EBF7")]
	public const string motionPathCardFlipCard = "Duel/ScriptableObject/BezierMotion/CardFlipCard";

	[Token(Token = "0x400EBF8")]
	public const string motionPathCardFlipPlateMonster = "Duel/ScriptableObject/BezierMotion/CardFlipPlateMonster";

	[Token(Token = "0x400EBF9")]
	public const string motionPathCardFlipPlateMagic = "Duel/ScriptableObject/BezierMotion/CardFlipPlateMagic";

	[Token(Token = "0x400EBFA")]
	public const string motionPathCardFlipDeckCard = "Duel/ScriptableObject/BezierMotion/CardFlipDeckCard";

	[Token(Token = "0x600A2F8")]
	[Address(RVA = "0xF00630", Offset = "0xEFF830", VA = "0x180F00630")]
	public static void Setup(Action on_finished)
	{
	}

	[Token(Token = "0x600A2F9")]
	[Address(RVA = "0xF00A10", Offset = "0xEFFC10", VA = "0x180F00A10")]
	public BezierMotionSettingManager()
	{
	}
}
