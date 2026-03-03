using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200009C")]
public class USndPlugin : MonoBehaviour
{
	[Token(Token = "0x4000317")]
	[FieldOffset(Offset = "0x0")]
	public static bool isSetAudioFocus;

	[Token(Token = "0x4000318")]
	[FieldOffset(Offset = "0x8")]
	private static USndPlugin_abstract plugin;

	[Token(Token = "0x6000302")]
	[Address(RVA = "0x6834B0", Offset = "0x6826B0", VA = "0x1806834B0")]
	public static void Init(string objName, string funcName)
	{
	}

	[Token(Token = "0x6000303")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	public static void UpdateAndroidMusicStatus()
	{
	}

	[Token(Token = "0x6000304")]
	[Address(RVA = "0x6836D0", Offset = "0x6828D0", VA = "0x1806836D0")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000305")]
	[Address(RVA = "0x683660", Offset = "0x682860", VA = "0x180683660")]
	private void OnApplicationFocus(bool focus)
	{
	}

	[Token(Token = "0x6000306")]
	[Address(RVA = "0x683540", Offset = "0x682740", VA = "0x180683540")]
	public static bool IsMusicPlaying()
	{
		return default(bool);
	}

	[Token(Token = "0x6000307")]
	[Address(RVA = "0x6835A0", Offset = "0x6827A0", VA = "0x1806835A0")]
	public static bool IsOtherAudioPlaying()
	{
		return default(bool);
	}

	[Token(Token = "0x6000308")]
	[Address(RVA = "0x683600", Offset = "0x682800", VA = "0x180683600")]
	public static bool IsSpeaker()
	{
		return default(bool);
	}

	[Token(Token = "0x6000309")]
	[Address(RVA = "0x6834E0", Offset = "0x6826E0", VA = "0x1806834E0")]
	public static bool IsMannerMode()
	{
		return default(bool);
	}

	[Token(Token = "0x600030A")]
	[Address(RVA = "0x683760", Offset = "0x682960", VA = "0x180683760")]
	public static void SetAudioFocus()
	{
	}

	[Token(Token = "0x600030B")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public USndPlugin()
	{
	}
}
