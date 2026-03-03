using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem;

[Token(Token = "0x20001D6")]
public class FrameRateManager : MonoBehaviour
{
	[Token(Token = "0x20001D7")]
	public enum Mode
	{
		[Token(Token = "0x4000A28")]
		FullFrame,
		[Token(Token = "0x4000A29")]
		Var60,
		[Token(Token = "0x4000A2A")]
		Fix30,
		[Token(Token = "0x4000A2B")]
		Var30,
		[Token(Token = "0x4000A2C")]
		Fix20
	}

	[Token(Token = "0x4000A23")]
	[FieldOffset(Offset = "0x0")]
	private static Mode mode;

	[Token(Token = "0x4000A24")]
	[FieldOffset(Offset = "0x4")]
	private static float highPerfReq;

	[Token(Token = "0x4000A25")]
	[FieldOffset(Offset = "0x8")]
	private static float rate;

	[Token(Token = "0x4000A26")]
	[FieldOffset(Offset = "0xC")]
	private static float rate2;

	[Token(Token = "0x6000AFC")]
	[Address(RVA = "0xC08C90", Offset = "0xC07E90", VA = "0x180C08C90")]
	public static void SetMode(Mode m)
	{
	}

	[Token(Token = "0x6000AFD")]
	[Address(RVA = "0xC088C0", Offset = "0xC07AC0", VA = "0x180C088C0")]
	public static void KeepHighRateMomentary(float time = 1E-45f)
	{
	}

	[Token(Token = "0x6000AFE")]
	[Address(RVA = "0xC08940", Offset = "0xC07B40", VA = "0x180C08940")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000AFF")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public FrameRateManager()
	{
	}
}
