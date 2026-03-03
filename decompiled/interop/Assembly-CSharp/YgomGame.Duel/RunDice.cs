using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

namespace YgomGame.Duel;

[Token(Token = "0x2001B4C")]
public class RunDice
{
	[Token(Token = "0x2001B4D")]
	public enum STEP
	{
		[Token(Token = "0x400F85D")]
		MAIN,
		[Token(Token = "0x400F85E")]
		END
	}

	[Token(Token = "0x2001B4E")]
	private class Dice
	{
		[Token(Token = "0x400F85F")]
		[FieldOffset(Offset = "0x10")]
		public GameObject obj;

		[Token(Token = "0x400F860")]
		[FieldOffset(Offset = "0x18")]
		public PlayableDirector timeline;

		[Token(Token = "0x400F861")]
		[FieldOffset(Offset = "0x20")]
		public float timer;

		[Token(Token = "0x400F862")]
		[FieldOffset(Offset = "0x24")]
		public int number;

		[Token(Token = "0x400F863")]
		[FieldOffset(Offset = "0x28")]
		public bool turned;

		[Token(Token = "0x400F864")]
		[FieldOffset(Offset = "0x2C")]
		public int seid1;

		[Token(Token = "0x400F865")]
		[FieldOffset(Offset = "0x30")]
		public int seid2;

		[Token(Token = "0x400F866")]
		[FieldOffset(Offset = "0x34")]
		public bool playing;

		[Token(Token = "0x600B03D")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public Dice()
		{
		}
	}

	[Token(Token = "0x400F855")]
	[FieldOffset(Offset = "0x10")]
	private bool myself;

	[Token(Token = "0x400F856")]
	[FieldOffset(Offset = "0x0")]
	private static Vector3[] rotsMyself;

	[Token(Token = "0x400F857")]
	[FieldOffset(Offset = "0x8")]
	private static Vector3[] rotsRival;

	[Token(Token = "0x400F858")]
	[FieldOffset(Offset = "0x14")]
	public STEP step;

	[Token(Token = "0x400F859")]
	[FieldOffset(Offset = "0x18")]
	private List<Dice> dices;

	[Token(Token = "0x400F85A")]
	private const float TOTAL_FRAME = 80f;

	[Token(Token = "0x400F85B")]
	private const float N_STABLE_FRAME = 0.675f;

	[Token(Token = "0x600B038")]
	[Address(RVA = "0x488D90", Offset = "0x487F90", VA = "0x180488D90")]
	public RunDice(int numThrows, int number, bool myself)
	{
	}

	[Token(Token = "0x600B039")]
	[Address(RVA = "0x488990", Offset = "0x487B90", VA = "0x180488990")]
	public bool Update(bool isSkip)
	{
		return default(bool);
	}

	[Token(Token = "0x600B03A")]
	[Address(RVA = "0x488560", Offset = "0x487760", VA = "0x180488560")]
	private bool UpdateDice(Dice dice, bool isSkip)
	{
		return default(bool);
	}

	[Token(Token = "0x600B03B")]
	[Address(RVA = "0x488460", Offset = "0x487660", VA = "0x180488460")]
	public void Terminate()
	{
	}
}
