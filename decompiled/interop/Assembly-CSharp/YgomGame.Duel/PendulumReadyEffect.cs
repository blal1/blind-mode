using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Playables;

namespace YgomGame.Duel;

[Token(Token = "0x2001A94")]
public class PendulumReadyEffect
{
	[Token(Token = "0x400F4D4")]
	[FieldOffset(Offset = "0x10")]
	private PlayableDirector timeline;

	[Token(Token = "0x400F4D5")]
	[FieldOffset(Offset = "0x18")]
	private bool playing;

	[Token(Token = "0x400F4D6")]
	[FieldOffset(Offset = "0x19")]
	private bool loopout;

	[Token(Token = "0x400F4D7")]
	[FieldOffset(Offset = "0x1A")]
	private bool cancel;

	[Token(Token = "0x17001AC6")]
	public bool isNear
	{
		[Token(Token = "0x600ACDD")]
		[Address(RVA = "0x444C90", Offset = "0x443E90", VA = "0x180444C90")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600ACDE")]
		[Address(RVA = "0x444CA0", Offset = "0x443EA0", VA = "0x180444CA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x600ACDF")]
	[Address(RVA = "0x444AF0", Offset = "0x443CF0", VA = "0x180444AF0")]
	public void Play(bool near, Action onFinished)
	{
	}

	[Token(Token = "0x600ACE0")]
	[Address(RVA = "0x4447A0", Offset = "0x4439A0", VA = "0x1804447A0")]
	public void LoopOut()
	{
	}

	[Token(Token = "0x600ACE1")]
	[Address(RVA = "0x4446E0", Offset = "0x4438E0", VA = "0x1804446E0")]
	public void Cancel()
	{
	}

	[Token(Token = "0x600ACE2")]
	[Address(RVA = "0x444790", Offset = "0x443990", VA = "0x180444790")]
	public bool IsPlaying()
	{
		return default(bool);
	}

	[Token(Token = "0x600ACE3")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public PendulumReadyEffect()
	{
	}
}
