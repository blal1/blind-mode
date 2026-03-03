using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

namespace YgomSystem.Timeline;

[Token(Token = "0x2000205")]
public class PlayablePauseFlag : MonoBehaviour
{
	[Token(Token = "0x4000AA6")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private bool m_IsPause;

	[Token(Token = "0x6000C37")]
	[Address(RVA = "0xC112B0", Offset = "0xC104B0", VA = "0x180C112B0")]
	public static bool GetPauseFlag(PlayableDirector director)
	{
		return default(bool);
	}

	[Token(Token = "0x6000C38")]
	[Address(RVA = "0xC11330", Offset = "0xC10530", VA = "0x180C11330")]
	public static void SetPauseFlag(PlayableDirector director, bool value)
	{
	}

	[Token(Token = "0x6000C39")]
	[Address(RVA = "0xC112A0", Offset = "0xC104A0", VA = "0x180C112A0")]
	public PlayablePauseFlag()
	{
	}
}
