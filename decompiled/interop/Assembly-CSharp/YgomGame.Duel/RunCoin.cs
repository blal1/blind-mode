using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;
using YgomSystem.ElementSystem;

namespace YgomGame.Duel;

[Token(Token = "0x2001B3F")]
public class RunCoin
{
	[Token(Token = "0x2001B40")]
	private class Coin
	{
		[Token(Token = "0x2001B41")]
		public enum State
		{
			[Token(Token = "0x400F82B")]
			Wait,
			[Token(Token = "0x400F82C")]
			Playing,
			[Token(Token = "0x400F82D")]
			Played
		}

		[Token(Token = "0x400F822")]
		[FieldOffset(Offset = "0x10")]
		public PlayableDirector timeline;

		[Token(Token = "0x400F823")]
		[FieldOffset(Offset = "0x18")]
		public GameObject obj;

		[Token(Token = "0x400F824")]
		[FieldOffset(Offset = "0x20")]
		public float timer;

		[Token(Token = "0x400F825")]
		[FieldOffset(Offset = "0x24")]
		public State state;

		[Token(Token = "0x400F826")]
		[FieldOffset(Offset = "0x28")]
		public bool isFace;

		[Token(Token = "0x400F827")]
		[FieldOffset(Offset = "0x29")]
		public bool turned;

		[Token(Token = "0x400F828")]
		[FieldOffset(Offset = "0x2A")]
		public bool decideSePlayed;

		[Token(Token = "0x400F829")]
		[FieldOffset(Offset = "0x2B")]
		public bool isMyself;

		[Token(Token = "0x600B016")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public Coin()
		{
		}
	}

	[Token(Token = "0x2001B42")]
	private enum STEP
	{
		[Token(Token = "0x400F82F")]
		MAIN,
		[Token(Token = "0x400F830")]
		PRE_END,
		[Token(Token = "0x400F831")]
		END
	}

	[Token(Token = "0x400F81E")]
	[FieldOffset(Offset = "0x10")]
	private float timer;

	[Token(Token = "0x400F81F")]
	[FieldOffset(Offset = "0x14")]
	private bool isSkipped;

	[Token(Token = "0x400F820")]
	[FieldOffset(Offset = "0x18")]
	private List<Coin> coins;

	[Token(Token = "0x400F821")]
	[FieldOffset(Offset = "0x20")]
	private STEP step;

	[Token(Token = "0x600B00F")]
	[Address(RVA = "0x478A90", Offset = "0x477C90", VA = "0x180478A90")]
	public RunCoin(int numThrows, int faceBits, int shineBits, bool sameTime, bool isMySelf, int coinID)
	{
	}

	[Token(Token = "0x600B010")]
	[Address(RVA = "0x477B10", Offset = "0x476D10", VA = "0x180477B10")]
	private void SetupMeshRender(GameObject target, int coinID, bool isHead, bool isMySelf)
	{
	}

	[Token(Token = "0x600B011")]
	[Address(RVA = "0x477E70", Offset = "0x477070", VA = "0x180477E70")]
	private void SetupParticleMaterial(ElementObjectManager eom, int coinid)
	{
	}

	[Token(Token = "0x600B012")]
	[Address(RVA = "0x478890", Offset = "0x477A90", VA = "0x180478890")]
	public bool Update()
	{
		return default(bool);
	}

	[Token(Token = "0x600B013")]
	[Address(RVA = "0x4785B0", Offset = "0x4777B0", VA = "0x1804785B0")]
	private bool UpdateCoin(Coin coin)
	{
		return default(bool);
	}

	[Token(Token = "0x600B014")]
	[Address(RVA = "0x4784A0", Offset = "0x4776A0", VA = "0x1804784A0")]
	public void Skip()
	{
	}

	[Token(Token = "0x600B015")]
	[Address(RVA = "0x4784B0", Offset = "0x4776B0", VA = "0x1804784B0")]
	public void Terminate()
	{
	}
}
