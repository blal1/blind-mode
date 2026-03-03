using Il2CppDummyDll;

namespace YgomSystem;

[Token(Token = "0x20001E3")]
public static class TimeManager
{
	[Token(Token = "0x4000A58")]
	[FieldOffset(Offset = "0x0")]
	private static float _gameTimeScale;

	[Token(Token = "0x17000133")]
	public static float gameTimeScale
	{
		[Token(Token = "0x6000B43")]
		[Address(RVA = "0xC16CD0", Offset = "0xC15ED0", VA = "0x180C16CD0")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000B44")]
		[Address(RVA = "0xC16DB0", Offset = "0xC15FB0", VA = "0x180C16DB0")]
		set
		{
		}
	}

	[Token(Token = "0x17000134")]
	public static float timeScale
	{
		[Token(Token = "0x6000B45")]
		[Address(RVA = "0xC16D20", Offset = "0xC15F20", VA = "0x180C16D20")]
		get
		{
			return default(float);
		}
	}
}
