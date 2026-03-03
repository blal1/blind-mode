using System.Diagnostics;
using Il2CppDummyDll;

namespace YgomSystem;

[Token(Token = "0x2000186")]
public static class XboxActivityRoom
{
	[Token(Token = "0x400093A")]
	[FieldOffset(Offset = "0x0")]
	public static readonly string INVITE_PREFIX;

	[Token(Token = "0x400093B")]
	[FieldOffset(Offset = "0x8")]
	public static readonly string INVITE_GP_PREFIX;

	[Token(Token = "0x60009C3")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	[Conditional("UNUSED_METHOD_ON_OTHER_PLATFORM_BUT_XBOX")]
	public static void Set(int roomID)
	{
	}
}
