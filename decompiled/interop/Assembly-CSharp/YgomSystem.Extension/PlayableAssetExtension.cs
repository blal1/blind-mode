using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;
using YgomGame.Scenario;

namespace YgomSystem.Extension;

[Token(Token = "0x2000364")]
public static class PlayableAssetExtension
{
	[Token(Token = "0x6001521")]
	[Address(RVA = "0x525AE0", Offset = "0x524CE0", VA = "0x180525AE0")]
	public static Dictionary<string, TimelineClip> CollectTrackClipsMap(this PlayableAsset playableAsset, string trackName)
	{
		return null;
	}

	[Token(Token = "0x6001522")]
	[Address(RVA = "0x525EE0", Offset = "0x5250E0", VA = "0x180525EE0")]
	public static TrackAsset FindTrack(this PlayableAsset playableAsset, string trackName)
	{
		return null;
	}

	[Token(Token = "0x6001523")]
	[Address(RVA = "0x525DE0", Offset = "0x524FE0", VA = "0x180525DE0")]
	public static TimelineClip FindClicp(this TrackAsset trackAsset, string clipName)
	{
		return null;
	}

	[Token(Token = "0x6001524")]
	[Address(RVA = "0x526040", Offset = "0x525240", VA = "0x180526040")]
	public static PlayableDirector GetSourcePlayableDirector(this ControlPlayableAsset controlClip, PlayableDirector director)
	{
		return null;
	}

	[Token(Token = "0x6001525")]
	[Address(RVA = "0x525350", Offset = "0x524550", VA = "0x180525350")]
	public static void BindObjectCamera(this PlayableDirector director, Camera camera, ScenarioBGLoader.BgGeneratedResource r)
	{
	}
}
