using System;
using Il2CppDummyDll;
using Spine.Unity;
using Spine.Unity.Playables;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

namespace YgomSystem.Timeline;

[Serializable]
[Token(Token = "0x2000214")]
[TrackColor(0.4f, 0.8f, 0.8f)]
[TrackClipType(typeof(SpineAnimationStateClip))]
[TrackBindingType(typeof(SkeletonAnimation))]
public class SpineAnimationPlayTrack : TrackAsset
{
	[Token(Token = "0x4000AC9")]
	[FieldOffset(Offset = "0xA0")]
	public int trackIndex;

	[Token(Token = "0x4000ACA")]
	[FieldOffset(Offset = "0xA4")]
	public bool setEmptyOnEndWithClip;

	[Token(Token = "0x6000C6C")]
	[Address(RVA = "0xD3A690", Offset = "0xD39890", VA = "0x180D3A690", Slot = "32")]
	protected override Playable CreatePlayable(PlayableGraph graph, GameObject gameObject, TimelineClip clip)
	{
		return default(Playable);
	}

	[Token(Token = "0x6000C6D")]
	[Address(RVA = "0xD3A850", Offset = "0xD39A50", VA = "0x180D3A850", Slot = "24")]
	public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
	{
		return default(Playable);
	}

	[Token(Token = "0x6000C6E")]
	[Address(RVA = "0xD3A960", Offset = "0xD39B60", VA = "0x180D3A960")]
	public SpineAnimationPlayTrack()
	{
	}
}
