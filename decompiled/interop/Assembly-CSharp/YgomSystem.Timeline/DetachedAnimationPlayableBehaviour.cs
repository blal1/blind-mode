using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

namespace YgomSystem.Timeline;

[Serializable]
[Token(Token = "0x20001EE")]
public class DetachedAnimationPlayableBehaviour : PlayableBehaviour
{
	[Token(Token = "0x4000A71")]
	[FieldOffset(Offset = "0x10")]
	public AnimationClip animClip;

	[NonSerialized]
	[Token(Token = "0x4000A72")]
	[FieldOffset(Offset = "0x18")]
	public Animator target;

	[Token(Token = "0x4000A73")]
	[FieldOffset(Offset = "0x20")]
	private PlayableGraph m_PlayableGraph;

	[Token(Token = "0x6000BC6")]
	[Address(RVA = "0xC07AA0", Offset = "0xC06CA0", VA = "0x180C07AA0", Slot = "15")]
	public override void OnPlayableCreate(Playable playable)
	{
	}

	[Token(Token = "0x6000BC7")]
	[Address(RVA = "0xC07A30", Offset = "0xC06C30", VA = "0x180C07A30", Slot = "17")]
	public override void OnBehaviourPlay(Playable playable, FrameData info)
	{
	}

	[Token(Token = "0x6000BC8")]
	[Address(RVA = "0xC079C0", Offset = "0xC06BC0", VA = "0x180C079C0", Slot = "18")]
	public override void OnBehaviourPause(Playable playable, FrameData info)
	{
	}

	[Token(Token = "0x6000BC9")]
	[Address(RVA = "0xC07BF0", Offset = "0xC06DF0", VA = "0x180C07BF0", Slot = "16")]
	public override void OnPlayableDestroy(Playable playable)
	{
	}

	[Token(Token = "0x6000BCA")]
	[Address(RVA = "0x3DC070", Offset = "0x3DB270", VA = "0x1803DC070")]
	public DetachedAnimationPlayableBehaviour()
	{
	}
}
