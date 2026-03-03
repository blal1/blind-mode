using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

namespace YgomSystem.Timeline;

[Serializable]
[Token(Token = "0x20001FC")]
[TrackColor(0.8f, 0.9f, 0.8f)]
[TrackClipType(typeof(LabelClip))]
[ExcludeFromPreset]
public class LabelTrack : TrackAsset
{
	[Token(Token = "0x6000C13")]
	[Address(RVA = "0xC0C010", Offset = "0xC0B210", VA = "0x180C0C010", Slot = "30")]
	protected override void OnCreateClip(TimelineClip clip)
	{
	}

	[Token(Token = "0x6000C14")]
	[Address(RVA = "0xC0BEE0", Offset = "0xC0B0E0", VA = "0x180C0BEE0", Slot = "24")]
	public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
	{
		return default(Playable);
	}

	[Token(Token = "0x6000C15")]
	[Address(RVA = "0xC0C1B0", Offset = "0xC0B3B0", VA = "0x180C0C1B0")]
	public LabelTrack()
	{
	}
}
