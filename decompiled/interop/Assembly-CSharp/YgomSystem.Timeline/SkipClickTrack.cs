using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;
using YgomSystem.UI;

namespace YgomSystem.Timeline;

[Serializable]
[Token(Token = "0x200020A")]
[TrackColor(0.8f, 0.9f, 0.8f)]
[TrackClipType(typeof(SkipClickClip))]
[TrackBindingType(typeof(SelectionButton))]
[ExcludeFromPreset]
public class SkipClickTrack : TrackAsset
{
	[Token(Token = "0x6000C4B")]
	[Address(RVA = "0xC152F0", Offset = "0xC144F0", VA = "0x180C152F0", Slot = "30")]
	protected override void OnCreateClip(TimelineClip clip)
	{
	}

	[Token(Token = "0x6000C4C")]
	[Address(RVA = "0xC14F20", Offset = "0xC14120", VA = "0x180C14F20", Slot = "24")]
	public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
	{
		return default(Playable);
	}

	[Token(Token = "0x6000C4D")]
	[Address(RVA = "0xC153F0", Offset = "0xC145F0", VA = "0x180C153F0")]
	public SkipClickTrack()
	{
	}
}
