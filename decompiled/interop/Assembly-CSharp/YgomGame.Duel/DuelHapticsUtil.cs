using System.Collections.Generic;
using Il2CppDummyDll;
using YgomSystem;

namespace YgomGame.Duel;

[Token(Token = "0x200179E")]
public static class DuelHapticsUtil
{
	[Token(Token = "0x200179F")]
	public enum Type
	{
		[Token(Token = "0x400DD79")]
		None,
		[Token(Token = "0x400DD7A")]
		MonsterCutin,
		[Token(Token = "0x400DD7B")]
		LandingMiddle,
		[Token(Token = "0x400DD7C")]
		LandingHigh,
		[Token(Token = "0x400DD7D")]
		CardBreak,
		[Token(Token = "0x400DD7E")]
		AttackLow,
		[Token(Token = "0x400DD7F")]
		AttackHigh,
		[Token(Token = "0x400DD80")]
		DirectAttack,
		[Token(Token = "0x400DD81")]
		EffectDamage,
		[Token(Token = "0x400DD82")]
		BgBreak,
		[Token(Token = "0x400DD83")]
		LethalEffect
	}

	[Token(Token = "0x400DD77")]
	[FieldOffset(Offset = "0x0")]
	private static Dictionary<Type, GamePad.VIBRATION> intensityList;

	[Token(Token = "0x60094A6")]
	[Address(RVA = "0xDE3AC0", Offset = "0xDE2CC0", VA = "0x180DE3AC0")]
	public static void SetVibrateFlag(bool enable)
	{
	}

	[Token(Token = "0x60094A7")]
	[Address(RVA = "0xDE3B10", Offset = "0xDE2D10", VA = "0x180DE3B10")]
	public static void Vibrate(Type type)
	{
	}
}
