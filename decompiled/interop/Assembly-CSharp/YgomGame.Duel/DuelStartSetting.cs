using Il2CppDummyDll;

namespace YgomGame.Duel;

[Token(Token = "0x2001A35")]
public class DuelStartSetting
{
	[Token(Token = "0x400F20B")]
	private const string DUEL_START_CAMERA_NORMAL = "Duel/ScriptableObject/BezierMotion/DuelStartCamera";

	[Token(Token = "0x400F20C")]
	private const string DUEL_START_CAMERA_WCS = "Duel/ScriptableObject/BezierMotion/DuelStartCameraWCS";

	[Token(Token = "0x400F20D")]
	private const string DUEL_START_CAMERA_WCS_FINAL = "Duel/ScriptableObject/BezierMotion/DuelStartCameraWCSFinal";

	[Token(Token = "0x600A9CD")]
	[Address(RVA = "0xF65300", Offset = "0xF64500", VA = "0x180F65300")]
	public static void DuelCameraWorkBegin()
	{
	}

	[Token(Token = "0x600A9CE")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public DuelStartSetting()
	{
	}
}
