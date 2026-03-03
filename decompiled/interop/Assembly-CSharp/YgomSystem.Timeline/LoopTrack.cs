using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

namespace YgomSystem.Timeline;

[Serializable]
[Token(Token = "0x2000200")]
[TrackColor(0.8f, 0.9f, 0.8f)]
[TrackClipType(typeof(LoopClip))]
[ExcludeFromPreset]
public class LoopTrack : TrackAsset
{
	[Token(Token = "0x6000C24")]
	[Address(RVA = "0xC0E270", Offset = "0xC0D470", VA = "0x180C0E270", Slot = "30")]
	protected override void OnCreateClip(TimelineClip clip)
	{
	}

	[Token(Token = "0x6000C25")]
	[Address(RVA = "0xC0E100", Offset = "0xC0D300", VA = "0x180C0E100", Slot = "24")]
	public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
	{
		return default(Playable);
	}

	[Token(Token = "0x6000C26")]
	[Address(RVA = "0xC0E370", Offset = "0xC0D570", VA = "0x180C0E370")]
	public LoopTrack()
	{
	}
}
