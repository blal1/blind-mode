using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

namespace YgomGame.Scenario;

[Serializable]
[Token(Token = "0x2000ADB")]
[TrackClipType(typeof(ScenarioSoundClip))]
[TrackBindingType(typeof(ScenarioSoundTrackBinder))]
[TrackColor(0.8f, 0.9f, 0.8f)]
public class ScenarioSoundTrack : TrackAsset
{
	[Token(Token = "0x60042E6")]
	[Address(RVA = "0x8A24A0", Offset = "0x8A16A0", VA = "0x1808A24A0", Slot = "30")]
	protected override void OnCreateClip(TimelineClip clip)
	{
	}

	[Token(Token = "0x60042E7")]
	[Address(RVA = "0x8A2270", Offset = "0x8A1470", VA = "0x1808A2270", Slot = "32")]
	protected override Playable CreatePlayable(PlayableGraph graph, GameObject gameObject, TimelineClip clip)
	{
		return default(Playable);
	}

	[Token(Token = "0x60042E8")]
	[Address(RVA = "0x8A23C0", Offset = "0x8A15C0", VA = "0x1808A23C0", Slot = "24")]
	public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
	{
		return default(Playable);
	}

	[Token(Token = "0x60042E9")]
	[Address(RVA = "0x8A2640", Offset = "0x8A1840", VA = "0x1808A2640")]
	public ScenarioSoundTrack()
	{
	}
}
