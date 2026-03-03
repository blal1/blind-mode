using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

namespace YgomSystem.Timeline;

[Serializable]
[Token(Token = "0x20001EF")]
[TrackColor(0.9f, 0.9f, 0.9f)]
[TrackClipType(typeof(DetachedAnimationPlayableAsset))]
[TrackBindingType(typeof(Animator))]
[ExcludeFromPreset]
public class DetachedAnimationTrack : TrackAsset
{
	[Token(Token = "0x6000BCB")]
	[Address(RVA = "0xC08020", Offset = "0xC07220", VA = "0x180C08020", Slot = "30")]
	protected override void OnCreateClip(TimelineClip clip)
	{
	}

	[Token(Token = "0x6000BCC")]
	[Address(RVA = "0xC07C60", Offset = "0xC06E60", VA = "0x180C07C60", Slot = "24")]
	public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
	{
		return default(Playable);
	}

	[Token(Token = "0x6000BCD")]
	[Address(RVA = "0xC08120", Offset = "0xC07320", VA = "0x180C08120")]
	public DetachedAnimationTrack()
	{
	}
}
