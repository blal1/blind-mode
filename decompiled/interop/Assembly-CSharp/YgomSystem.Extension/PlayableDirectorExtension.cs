using Il2CppDummyDll;
using UnityEngine.Playables;

namespace YgomSystem.Extension;

[Token(Token = "0x2000354")]
public static class PlayableDirectorExtension
{
	[Token(Token = "0x60014CB")]
	[Address(RVA = "0x526100", Offset = "0x525300", VA = "0x180526100")]
	public static void PauseTimeline(this PlayableDirector director)
	{
	}

	[Token(Token = "0x60014CC")]
	[Address(RVA = "0x526190", Offset = "0x525390", VA = "0x180526190")]
	public static void ResumeTimeline(this PlayableDirector director)
	{
	}

	[Token(Token = "0x60014CD")]
	[Address(RVA = "0x526220", Offset = "0x525420", VA = "0x180526220")]
	public static void SetTimelineSpeed(this PlayableDirector director, double speed = 1.0)
	{
	}
}
