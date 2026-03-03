using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;
using YgomSystem.UI;

namespace YgomSystem.Timeline;

[Serializable]
[Token(Token = "0x2000218")]
[TrackColor(0.8f, 0.9f, 0.8f)]
[TrackClipType(typeof(WaitClickClip))]
[TrackBindingType(typeof(SelectionButton))]
[ExcludeFromPreset]
public class WaitClickTrack : TrackAsset
{
	[Token(Token = "0x6000C7B")]
	[Address(RVA = "0xD43980", Offset = "0xD42B80", VA = "0x180D43980", Slot = "30")]
	protected override void OnCreateClip(TimelineClip clip)
	{
	}

	[Token(Token = "0x6000C7C")]
	[Address(RVA = "0xD435B0", Offset = "0xD427B0", VA = "0x180D435B0", Slot = "24")]
	public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
	{
		return default(Playable);
	}

	[Token(Token = "0x6000C7D")]
	[Address(RVA = "0xD43A80", Offset = "0xD42C80", VA = "0x180D43A80")]
	public WaitClickTrack()
	{
	}
}
