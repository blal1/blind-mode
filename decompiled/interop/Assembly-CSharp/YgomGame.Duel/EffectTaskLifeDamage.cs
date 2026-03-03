using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomGame.Duel;

[Token(Token = "0x2001B27")]
public class EffectTaskLifeDamage : EffectTask
{
	[Token(Token = "0x2001B28")]
	private enum Step
	{
		[Token(Token = "0x400F7D3")]
		WaitCardEffect,
		[Token(Token = "0x400F7D4")]
		WaitDamageEffect,
		[Token(Token = "0x400F7D5")]
		Finished
	}

	[Token(Token = "0x400F7CC")]
	[FieldOffset(Offset = "0x18")]
	private Step step;

	[Token(Token = "0x400F7CD")]
	[FieldOffset(Offset = "0x1C")]
	private int player;

	[Token(Token = "0x400F7CE")]
	[FieldOffset(Offset = "0x20")]
	private int damage;

	[Token(Token = "0x400F7CF")]
	[FieldOffset(Offset = "0x24")]
	private bool isPrev;

	[Token(Token = "0x400F7D0")]
	[FieldOffset(Offset = "0x28")]
	private Engine.DamageType type;

	[Token(Token = "0x400F7D1")]
	[FieldOffset(Offset = "0x2C")]
	private int currentLP;

	[Token(Token = "0x600AFBF")]
	[Address(RVA = "0x46FE50", Offset = "0x46F050", VA = "0x18046FE50")]
	public static void MinimumEffect(RunEffectWorker worker, int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600AFC0")]
	[Address(RVA = "0x4705F0", Offset = "0x46F7F0", VA = "0x1804705F0")]
	public static Dictionary<string, object> PreCreate(RunEffectWorker worker, int param1, int param2, int param3)
	{
		return null;
	}

	[Token(Token = "0x600AFC1")]
	[Address(RVA = "0x46FD70", Offset = "0x46EF70", VA = "0x18046FD70")]
	public static EffectTask Create(RunEffectWorker worker, int param1, int param2, int param3, Dictionary<string, object> immediateWork)
	{
		return null;
	}

	[Token(Token = "0x600AFC2")]
	[Address(RVA = "0x470770", Offset = "0x46F970", VA = "0x180470770")]
	public EffectTaskLifeDamage(RunEffectWorker worker, int param1, int param2, int param3, Dictionary<string, object> immediateWork)
	{
	}

	[Token(Token = "0x600AFC3")]
	[Address(RVA = "0x4706D0", Offset = "0x46F8D0", VA = "0x1804706D0", Slot = "4")]
	public override bool Update()
	{
		return default(bool);
	}

	[Token(Token = "0x600AFC4")]
	[Address(RVA = "0x470720", Offset = "0x46F920", VA = "0x180470720")]
	private void WaitCardEffect()
	{
	}

	[Token(Token = "0x600AFC5")]
	[Address(RVA = "0x46FEF0", Offset = "0x46F0F0", VA = "0x18046FEF0")]
	private void PlayDamageEffect()
	{
	}
}
