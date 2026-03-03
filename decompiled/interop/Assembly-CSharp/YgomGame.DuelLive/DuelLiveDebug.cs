using System.Diagnostics;
using Il2CppDummyDll;

namespace YgomGame.DuelLive;

[Token(Token = "0x2000F11")]
public static class DuelLiveDebug
{
	[Token(Token = "0x6005B66")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	[Conditional("YGO_DEBUG")]
	public static void Log(string msg)
	{
	}
}
