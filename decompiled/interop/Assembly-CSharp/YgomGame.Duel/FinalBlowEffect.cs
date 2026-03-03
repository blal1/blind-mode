using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.Playables;

namespace YgomGame.Duel;

[Token(Token = "0x2001A3A")]
public class FinalBlowEffect
{
	[Token(Token = "0x2001A3B")]
	public enum Type
	{
		[Token(Token = "0x400F229")]
		Default,
		[Token(Token = "0x400F22A")]
		Sp01
	}

	[Token(Token = "0x2001A3C")]
	public enum State
	{
		[Token(Token = "0x400F22C")]
		None,
		[Token(Token = "0x400F22D")]
		Load,
		[Token(Token = "0x400F22E")]
		In,
		[Token(Token = "0x400F22F")]
		Loop,
		[Token(Token = "0x400F230")]
		Out,
		[Token(Token = "0x400F231")]
		Finish
	}

	[Token(Token = "0x400F222")]
	[FieldOffset(Offset = "0x10")]
	private PlayableDirector timeline;

	[Token(Token = "0x400F223")]
	[FieldOffset(Offset = "0x18")]
	private Dictionary<Type, string> paths;

	[Token(Token = "0x400F224")]
	[FieldOffset(Offset = "0x20")]
	private State state;

	[Token(Token = "0x400F225")]
	[FieldOffset(Offset = "0x24")]
	private float timer;

	[Token(Token = "0x400F226")]
	private const float waitTime = 1f;

	[Token(Token = "0x400F227")]
	[FieldOffset(Offset = "0x28")]
	private Action<State> onStateChanged;

	[Token(Token = "0x600A9EF")]
	[Address(RVA = "0xF66640", Offset = "0xF65840", VA = "0x180F66640")]
	public static FinalBlowEffect Create()
	{
		return null;
	}

	[Token(Token = "0x600A9F0")]
	[Address(RVA = "0xF66A90", Offset = "0xF65C90", VA = "0x180F66A90")]
	public void Terminate()
	{
	}

	[Token(Token = "0x600A9F1")]
	[Address(RVA = "0xF66760", Offset = "0xF65960", VA = "0x180F66760")]
	public void Play(int player, Action<State> onStateChanged)
	{
	}

	[Token(Token = "0x600A9F2")]
	[Address(RVA = "0xF66B90", Offset = "0xF65D90", VA = "0x180F66B90")]
	public void Update()
	{
	}

	[Token(Token = "0x600A9F3")]
	[Address(RVA = "0xF66970", Offset = "0xF65B70", VA = "0x180F66970")]
	private void SetState(State state)
	{
	}

	[Token(Token = "0x600A9F4")]
	[Address(RVA = "0xC0E530", Offset = "0xC0D730", VA = "0x180C0E530")]
	private void InvokeStateChanged(State state)
	{
	}

	[Token(Token = "0x600A9F5")]
	[Address(RVA = "0xF669A0", Offset = "0xF65BA0", VA = "0x180F669A0")]
	public void Stop()
	{
	}

	[Token(Token = "0x600A9F6")]
	[Address(RVA = "0xF66750", Offset = "0xF65950", VA = "0x180F66750")]
	public bool IsPlaying()
	{
		return default(bool);
	}

	[Token(Token = "0x600A9F7")]
	[Address(RVA = "0xF66CA0", Offset = "0xF65EA0", VA = "0x180F66CA0")]
	public FinalBlowEffect()
	{
	}
}
