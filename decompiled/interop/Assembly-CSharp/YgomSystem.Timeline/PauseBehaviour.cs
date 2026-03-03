using System;
using Il2CppDummyDll;
using UnityEngine.Playables;

namespace YgomSystem.Timeline;

[Serializable]
[Token(Token = "0x2000201")]
public class PauseBehaviour : PlayableBehaviour
{
	[Token(Token = "0x4000A9C")]
	[FieldOffset(Offset = "0x10")]
	private PlayableDirector m_Director;

	[NonSerialized]
	[Token(Token = "0x4000A9D")]
	[FieldOffset(Offset = "0x18")]
	public double startTime;

	[NonSerialized]
	[Token(Token = "0x4000A9E")]
	[FieldOffset(Offset = "0x20")]
	public double endTime;

	[Token(Token = "0x4000A9F")]
	[FieldOffset(Offset = "0x28")]
	private bool m_Ready;

	[Token(Token = "0x4000AA0")]
	[FieldOffset(Offset = "0x29")]
	private bool m_IsCompletePause;

	[Token(Token = "0x4000AA1")]
	[FieldOffset(Offset = "0x2A")]
	private bool m_IsCompleteResume;

	[Token(Token = "0x6000C27")]
	[Address(RVA = "0xC0FE70", Offset = "0xC0F070", VA = "0x180C0FE70", Slot = "15")]
	public override void OnPlayableCreate(Playable playable)
	{
	}

	[Token(Token = "0x6000C28")]
	[Address(RVA = "0xC0FE60", Offset = "0xC0F060", VA = "0x180C0FE60", Slot = "13")]
	public override void OnGraphStart(Playable playable)
	{
	}

	[Token(Token = "0x6000C29")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "14")]
	public override void OnGraphStop(Playable playable)
	{
	}

	[Token(Token = "0x6000C2A")]
	[Address(RVA = "0xC0FD40", Offset = "0xC0EF40", VA = "0x180C0FD40", Slot = "17")]
	public override void OnBehaviourPlay(Playable playable, FrameData info)
	{
	}

	[Token(Token = "0x6000C2B")]
	[Address(RVA = "0xC0FC10", Offset = "0xC0EE10", VA = "0x180C0FC10", Slot = "18")]
	public override void OnBehaviourPause(Playable playable, FrameData info)
	{
	}

	[Token(Token = "0x6000C2C")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "20")]
	public override void PrepareFrame(Playable playable, FrameData info)
	{
	}

	[Token(Token = "0x6000C2D")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "16")]
	public override void OnPlayableDestroy(Playable playable)
	{
	}

	[Token(Token = "0x6000C2E")]
	[Address(RVA = "0x3DC070", Offset = "0x3DB270", VA = "0x1803DC070")]
	public PauseBehaviour()
	{
	}
}
