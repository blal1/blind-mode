using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

namespace YgomSystem.Timeline;

[Serializable]
[Token(Token = "0x200020C")]
[TrackColor(0.8f, 0.9f, 0.8f)]
[TrackClipType(typeof(SkipClip))]
[ExcludeFromPreset]
public class SkipTrack : TrackAsset
{
	[Token(Token = "0x6000C50")]
	[Address(RVA = "0xC158A0", Offset = "0xC14AA0", VA = "0x180C158A0", Slot = "30")]
	protected override void OnCreateClip(TimelineClip clip)
	{
	}

	[Token(Token = "0x6000C51")]
	[Address(RVA = "0xC155A0", Offset = "0xC147A0", VA = "0x180C155A0", Slot = "24")]
	public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
	{
		return default(Playable);
	}

	[Token(Token = "0x6000C52")]
	[Address(RVA = "0xC159A0", Offset = "0xC14BA0", VA = "0x180C159A0")]
	public SkipTrack()
	{
	}
}
