using Il2CppDummyDll;
using UnityEngine.Playables;

namespace YgomSystem.Extension;

[Token(Token = "0x2000353")]
public static class PlayableExtension
{
	[Token(Token = "0x60014C9")]
	[Address(RVA = "0x5262C0", Offset = "0x5254C0", VA = "0x1805262C0")]
	public static PlayableDirector GetDirector(this Playable playable)
	{
		return null;
	}

	[Token(Token = "0x60014CA")]
	[Address(RVA = "0x526380", Offset = "0x525580", VA = "0x180526380")]
	public static bool IsPlaying(this Playable playable)
	{
		return default(bool);
	}
}
