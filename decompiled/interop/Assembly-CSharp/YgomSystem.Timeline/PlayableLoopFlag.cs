using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

namespace YgomSystem.Timeline;

[Token(Token = "0x2000204")]
public class PlayableLoopFlag : MonoBehaviour
{
	[Token(Token = "0x4000AA5")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private bool m_IsLoop;

	[Token(Token = "0x6000C34")]
	[Address(RVA = "0xC11190", Offset = "0xC10390", VA = "0x180C11190")]
	public static bool GetLoopFlag(PlayableDirector director)
	{
		return default(bool);
	}

	[Token(Token = "0x6000C35")]
	[Address(RVA = "0xC11210", Offset = "0xC10410", VA = "0x180C11210")]
	public static void SetLoopFlag(PlayableDirector director, bool value)
	{
	}

	[Token(Token = "0x6000C36")]
	[Address(RVA = "0xC112A0", Offset = "0xC104A0", VA = "0x180C112A0")]
	public PlayableLoopFlag()
	{
	}
}
