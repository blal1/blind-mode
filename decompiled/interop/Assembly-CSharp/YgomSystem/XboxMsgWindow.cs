using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace YgomSystem;

[Token(Token = "0x200018A")]
public class XboxMsgWindow
{
	[Token(Token = "0x60009CB")]
	[Address(RVA = "0xB0D230", Offset = "0xB0C430", VA = "0x180B0D230")]
	public static void OpenConfirm(string title, string message, string btnLabel, [Optional] Action onEnd)
	{
	}

	[Token(Token = "0x60009CC")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public XboxMsgWindow()
	{
	}
}
