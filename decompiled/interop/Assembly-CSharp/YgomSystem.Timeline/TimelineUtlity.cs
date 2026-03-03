using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.Playables;
using UnityEngine.Timeline;

namespace YgomSystem.Timeline;

[Token(Token = "0x2000225")]
public static class TimelineUtlity
{
	[Token(Token = "0x6000CD3")]
	[Address(RVA = "0xD41170", Offset = "0xD40370", VA = "0x180D41170")]
	public static TrackAsset GetTrackAsset(this PlayableDirector pd, string tracklabel)
	{
		return null;
	}

	[Token(Token = "0x6000CD4")]
	[Address(RVA = "0xD40E40", Offset = "0xD40040", VA = "0x180D40E40")]
	public static TimelineClip GetTimelineClip(this TrackAsset ta, string cliplabel)
	{
		return null;
	}

	[Token(Token = "0x6000CD5")]
	[Address(RVA = "0xD40C50", Offset = "0xD3FE50", VA = "0x180D40C50")]
	public static TimelineClip GetTimelineClip(this PlayableDirector pd, string tracklabel, string cliplabel)
	{
		return null;
	}

	[Token(Token = "0x6000CD6")]
	[Address(RVA = "0xD40F20", Offset = "0xD40120", VA = "0x180D40F20")]
	public static TimelineClip GetTimelineClip(this PlayableDirector pd, string cliplabel)
	{
		return null;
	}

	[Token(Token = "0x6000CD7")]
	[Address(RVA = "0xD40A20", Offset = "0xD3FC20", VA = "0x180D40A20")]
	public static SignalEmitter GetSignalEmitter(this PlayableDirector pd, string label)
	{
		return null;
	}

	[Token(Token = "0x6000CD8")]
	public static T GetTrack<T>(this PlayableDirector pd) where T : TrackAsset
	{
		return null;
	}

	[Token(Token = "0x6000CD9")]
	public static List<T> GetTracks<T>(this PlayableDirector pd) where T : TrackAsset
	{
		return null;
	}

	[Token(Token = "0x6000CDA")]
	[Address(RVA = "0xD41580", Offset = "0xD40780", VA = "0x180D41580")]
	public static TrackAsset GetTrack(this PlayableDirector pd, string label)
	{
		return null;
	}

	[Token(Token = "0x6000CDB")]
	[Address(RVA = "0xD41720", Offset = "0xD40920", VA = "0x180D41720")]
	public static List<TrackAsset> GetTracks(this PlayableDirector pd, string label)
	{
		return null;
	}

	[Token(Token = "0x6000CDC")]
	public static T GetTrack<T>(this PlayableDirector pd, string label) where T : TrackAsset
	{
		return null;
	}

	[Token(Token = "0x6000CDD")]
	public static List<T> GetTracks<T>(this PlayableDirector pd, string label) where T : TrackAsset
	{
		return null;
	}

	[Token(Token = "0x6000CDE")]
	[Address(RVA = "0xD413E0", Offset = "0xD405E0", VA = "0x180D413E0")]
	public static TrackAsset GetTrackGroup(this PlayableDirector pd, string label)
	{
		return null;
	}

	[Token(Token = "0x6000CDF")]
	[Address(RVA = "0xD41300", Offset = "0xD40500", VA = "0x180D41300")]
	public static TrackAsset GetTrackGroup(this TrackAsset ta, string label)
	{
		return null;
	}

	[Token(Token = "0x6000CE0")]
	[Address(RVA = "0xD41A40", Offset = "0xD40C40", VA = "0x180D41A40")]
	public static void SetSpeed(this PlayableDirector pd, double speed)
	{
	}
}
