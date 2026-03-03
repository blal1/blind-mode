using Il2CppDummyDll;

namespace YgomGame.Duel;

[Token(Token = "0x200179C")]
public class Evaluator
{
	[Token(Token = "0x600949B")]
	[Address(RVA = "0xDEB290", Offset = "0xDEA490", VA = "0x180DEB290")]
	public static bool MaybeFinishingBlow(int player)
	{
		return default(bool);
	}

	[Token(Token = "0x600949C")]
	[Address(RVA = "0xDEBD30", Offset = "0xDEAF30", VA = "0x180DEBD30")]
	public static bool MaybeLastAttack(int player, int srcLocate, int dstLocate)
	{
		return default(bool);
	}

	[Token(Token = "0x600949D")]
	[Address(RVA = "0xDEBAF0", Offset = "0xDEACF0", VA = "0x180DEBAF0")]
	private static bool MaybeLastAttackImpl(int player, int srcLocate, int dstLocate)
	{
		return default(bool);
	}

	[Token(Token = "0x600949E")]
	[Address(RVA = "0xDEA510", Offset = "0xDE9710", VA = "0x180DEA510")]
	public static int GetMaxDamage(int turnPlayer)
	{
		return default(int);
	}

	[Token(Token = "0x600949F")]
	[Address(RVA = "0xDEB190", Offset = "0xDEA390", VA = "0x180DEB190")]
	public static int GetTotalAtk(int player)
	{
		return default(int);
	}

	[Token(Token = "0x60094A0")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public Evaluator()
	{
	}
}
