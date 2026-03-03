using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.UI;

namespace YgomGame.Colosseum;

[Token(Token = "0x2001BCA")]
[DisallowMultipleComponent]
public class ColosseumFlagManager : MonoBehaviour
{
	[Token(Token = "0x400FB69")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private int m_SeasonID;

	[Token(Token = "0x400FB6A")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private int m_LastPlayMode;

	[Token(Token = "0x17001BAB")]
	public int SeasonID
	{
		[Token(Token = "0x600B4DA")]
		[Address(RVA = "0x4BDC30", Offset = "0x4BCE30", VA = "0x1804BDC30")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17001BAC")]
	public int LastPlayMode
	{
		[Token(Token = "0x600B4DB")]
		[Address(RVA = "0x416290", Offset = "0x415490", VA = "0x180416290")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x600B4DC")]
	[Address(RVA = "0x4BDBE0", Offset = "0x4BCDE0", VA = "0x1804BDBE0")]
	public static void SetFlagManager(int seasonId, int lastPlayMode)
	{
	}

	[Token(Token = "0x600B4DD")]
	private static void SetFlagManager<T>(int seasonId, int lastPlayMode) where T : ViewController
	{
	}

	[Token(Token = "0x600B4DE")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public ColosseumFlagManager()
	{
	}
}
