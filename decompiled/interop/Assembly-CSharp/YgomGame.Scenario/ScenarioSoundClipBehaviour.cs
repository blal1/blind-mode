using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Serialization;
using UnityEngine.Timeline;

namespace YgomGame.Scenario;

[Serializable]
[Token(Token = "0x2000AD8")]
public class ScenarioSoundClipBehaviour : PlayableBehaviour
{
	[Token(Token = "0x4009427")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	[FormerlySerializedAs("editModeSoundLabel")]
	public string soundLabel;

	[NonSerialized]
	[Token(Token = "0x4009428")]
	[FieldOffset(Offset = "0x18")]
	public TimelineClip timelineClip;

	[Token(Token = "0x170008F4")]
	public string voiceCommandLabel
	{
		[Token(Token = "0x60042DB")]
		[Address(RVA = "0x8A17D0", Offset = "0x8A09D0", VA = "0x1808A17D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60042DC")]
	[Address(RVA = "0x8A17B0", Offset = "0x8A09B0", VA = "0x1808A17B0", Slot = "21")]
	public override void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
	}

	[Token(Token = "0x60042DD")]
	[Address(RVA = "0x3DC070", Offset = "0x3DB270", VA = "0x1803DC070")]
	public ScenarioSoundClipBehaviour()
	{
	}
}
