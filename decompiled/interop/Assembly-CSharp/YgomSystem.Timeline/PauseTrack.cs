using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

namespace YgomSystem.Timeline;

[Serializable]
[Token(Token = "0x2000203")]
[TrackColor(0.8f, 0.9f, 0.8f)]
[TrackClipType(typeof(PauseClip))]
[ExcludeFromPreset]
public class PauseTrack : TrackAsset
{
	[Token(Token = "0x6000C31")]
	[Address(RVA = "0xC10400", Offset = "0xC0F600", VA = "0x180C10400", Slot = "30")]
	protected override void OnCreateClip(TimelineClip clip)
	{
	}

	[Token(Token = "0x6000C32")]
	[Address(RVA = "0xC100F0", Offset = "0xC0F2F0", VA = "0x180C100F0", Slot = "24")]
	public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
	{
		return default(Playable);
	}

	[Token(Token = "0x6000C33")]
	[Address(RVA = "0xC10500", Offset = "0xC0F700", VA = "0x180C10500")]
	public PauseTrack()
	{
	}
}
