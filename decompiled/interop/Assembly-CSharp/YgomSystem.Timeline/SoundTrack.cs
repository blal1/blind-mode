using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Timeline;

namespace YgomSystem.Timeline;

[Serializable]
[Token(Token = "0x2000211")]
[TrackClipType(typeof(SoundPlayableAsset))]
[TrackClipType(typeof(SoundStopPlayableAsset))]
[ExcludeFromPreset]
public class SoundTrack : TrackAsset
{
	[Token(Token = "0x6000C5F")]
	[Address(RVA = "0xD39AF0", Offset = "0xD38CF0", VA = "0x180D39AF0")]
	public void StopAllSound()
	{
	}

	[Token(Token = "0x6000C60")]
	[Address(RVA = "0xD398A0", Offset = "0xD38AA0", VA = "0x180D398A0")]
	public void SetMute(bool mute)
	{
	}

	[Token(Token = "0x6000C61")]
	[Address(RVA = "0xD39D50", Offset = "0xD38F50", VA = "0x180D39D50")]
	public SoundTrack()
	{
	}
}
