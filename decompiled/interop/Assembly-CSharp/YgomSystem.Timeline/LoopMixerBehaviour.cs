using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.Playables;
using UnityEngine.Timeline;

namespace YgomSystem.Timeline;

[Serializable]
[Token(Token = "0x20001FF")]
public class LoopMixerBehaviour : PlayableBehaviour
{
	[Token(Token = "0x4000A98")]
	[FieldOffset(Offset = "0x10")]
	private readonly double k_SecMargine;

	[Token(Token = "0x4000A99")]
	[FieldOffset(Offset = "0x18")]
	private PlayableDirector m_Director;

	[NonSerialized]
	[Token(Token = "0x4000A9A")]
	[FieldOffset(Offset = "0x20")]
	public readonly List<TimelineClip> loopClips;

	[Token(Token = "0x4000A9B")]
	[FieldOffset(Offset = "0x28")]
	private bool m_Initialized;

	[Token(Token = "0x6000C19")]
	[Address(RVA = "0xC0DAB0", Offset = "0xC0CCB0", VA = "0x180C0DAB0", Slot = "15")]
	public override void OnPlayableCreate(Playable playable)
	{
	}

	[Token(Token = "0x6000C1A")]
	[Address(RVA = "0xC0DAA0", Offset = "0xC0CCA0", VA = "0x180C0DAA0", Slot = "17")]
	public override void OnBehaviourPlay(Playable playable, FrameData info)
	{
	}

	[Token(Token = "0x6000C1B")]
	[Address(RVA = "0xC0DAA0", Offset = "0xC0CCA0", VA = "0x180C0DAA0", Slot = "18")]
	public override void OnBehaviourPause(Playable playable, FrameData info)
	{
	}

	[Token(Token = "0x6000C1C")]
	[Address(RVA = "0xC0DAA0", Offset = "0xC0CCA0", VA = "0x180C0DAA0", Slot = "19")]
	public override void PrepareData(Playable playable, FrameData info)
	{
	}

	[Token(Token = "0x6000C1D")]
	[Address(RVA = "0xC0DAA0", Offset = "0xC0CCA0", VA = "0x180C0DAA0", Slot = "21")]
	public override void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
	}

	[Token(Token = "0x6000C1E")]
	[Address(RVA = "0xC0DAA0", Offset = "0xC0CCA0", VA = "0x180C0DAA0", Slot = "20")]
	public override void PrepareFrame(Playable playable, FrameData info)
	{
	}

	[Token(Token = "0x6000C1F")]
	[Address(RVA = "0xC0D770", Offset = "0xC0C970", VA = "0x180C0D770")]
	private void CheckLoopClip()
	{
	}

	[Token(Token = "0x6000C20")]
	[Address(RVA = "0xC0DE00", Offset = "0xC0D000", VA = "0x180C0DE00")]
	private void SetNextClipDuration()
	{
	}

	[Token(Token = "0x6000C21")]
	[Address(RVA = "0xC0DBC0", Offset = "0xC0CDC0", VA = "0x180C0DBC0")]
	private TimelineClip SearchCurrentClip()
	{
		return null;
	}

	[Token(Token = "0x6000C22")]
	[Address(RVA = "0xC0DCF0", Offset = "0xC0CEF0", VA = "0x180C0DCF0")]
	private TimelineClip SearchNextClip()
	{
		return null;
	}

	[Token(Token = "0x6000C23")]
	[Address(RVA = "0xC0E070", Offset = "0xC0D270", VA = "0x180C0E070")]
	public LoopMixerBehaviour()
	{
	}
}
