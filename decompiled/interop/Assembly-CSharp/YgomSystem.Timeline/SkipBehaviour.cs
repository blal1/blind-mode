using System;
using Il2CppDummyDll;
using UnityEngine.Playables;

namespace YgomSystem.Timeline;

[Serializable]
[Token(Token = "0x2000206")]
public class SkipBehaviour : PlayableBehaviour
{
	[Token(Token = "0x4000AA7")]
	[FieldOffset(Offset = "0x10")]
	private PlayableDirector m_Director;

	[NonSerialized]
	[Token(Token = "0x4000AA8")]
	[FieldOffset(Offset = "0x18")]
	public double endTime;

	[Token(Token = "0x6000C3A")]
	[Address(RVA = "0xC147D0", Offset = "0xC139D0", VA = "0x180C147D0", Slot = "15")]
	public override void OnPlayableCreate(Playable playable)
	{
	}

	[Token(Token = "0x6000C3B")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "13")]
	public override void OnGraphStart(Playable playable)
	{
	}

	[Token(Token = "0x6000C3C")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "14")]
	public override void OnGraphStop(Playable playable)
	{
	}

	[Token(Token = "0x6000C3D")]
	[Address(RVA = "0xC147A0", Offset = "0xC139A0", VA = "0x180C147A0", Slot = "17")]
	public override void OnBehaviourPlay(Playable playable, FrameData info)
	{
	}

	[Token(Token = "0x6000C3E")]
	[Address(RVA = "0xC14760", Offset = "0xC13960", VA = "0x180C14760", Slot = "18")]
	public override void OnBehaviourPause(Playable playable, FrameData info)
	{
	}

	[Token(Token = "0x6000C3F")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "20")]
	public override void PrepareFrame(Playable playable, FrameData info)
	{
	}

	[Token(Token = "0x6000C40")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "16")]
	public override void OnPlayableDestroy(Playable playable)
	{
	}

	[Token(Token = "0x6000C41")]
	[Address(RVA = "0x3DC070", Offset = "0x3DB270", VA = "0x1803DC070")]
	public SkipBehaviour()
	{
	}
}
