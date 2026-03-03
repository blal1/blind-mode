using System;
using System.Diagnostics;
using Il2CppDummyDll;

namespace YgomSystem;

[Token(Token = "0x2000188")]
public class XboxActivity
{
	[Token(Token = "0x60009C8")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	[Conditional("UNUSED_METHOD_ON_OTHER_PLATFORM_BUT_XBOX")]
	public static void Set(uint maxPlayerNum, uint currentPlayerNum, string connectionPhrase, string groupId, Action<bool> onEnd)
	{
	}

	[Token(Token = "0x60009C9")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	[Conditional("UNUSED_METHOD_ON_OTHER_PLATFORM_BUT_XBOX")]
	public static void Unset(Action<bool> onEnd)
	{
	}

	[Token(Token = "0x60009CA")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public XboxActivity()
	{
	}
}
