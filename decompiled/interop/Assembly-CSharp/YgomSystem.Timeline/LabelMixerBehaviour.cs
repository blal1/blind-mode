using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.Playables;
using UnityEngine.Timeline;

namespace YgomSystem.Timeline;

[Serializable]
[Token(Token = "0x20001FB")]
public class LabelMixerBehaviour : PlayableBehaviour
{
	[Token(Token = "0x4000A95")]
	[FieldOffset(Offset = "0x10")]
	private PlayableDirector m_Director;

	[Token(Token = "0x4000A96")]
	[FieldOffset(Offset = "0x18")]
	private Dictionary<string, TimelineClip> m_TrackClips;

	[Token(Token = "0x17000156")]
	public IReadOnlyDictionary<string, TimelineClip> trackClips
	{
		[Token(Token = "0x6000C0F")]
		[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000C10")]
	[Address(RVA = "0xC0BA60", Offset = "0xC0AC60", VA = "0x180C0BA60")]
	public void Initialize(IReadOnlyList<TimelineClip> trackClips)
	{
	}

	[Token(Token = "0x6000C11")]
	[Address(RVA = "0xC0BDD0", Offset = "0xC0AFD0", VA = "0x180C0BDD0", Slot = "15")]
	public override void OnPlayableCreate(Playable playable)
	{
	}

	[Token(Token = "0x6000C12")]
	[Address(RVA = "0x3DC070", Offset = "0x3DB270", VA = "0x1803DC070")]
	public LabelMixerBehaviour()
	{
	}
}
