using System;
using Il2CppDummyDll;

namespace YgomGame.Menu;

[Token(Token = "0x20011AC")]
public class GameEntryApprovalParameter
{
	[Token(Token = "0x400B881")]
	[FieldOffset(Offset = "0x10")]
	public Action<bool> resultCallback;

	[Token(Token = "0x400B882")]
	[FieldOffset(Offset = "0x18")]
	public IntroductionBackDialogSetting backDialogSetting;

	[Token(Token = "0x6006EEC")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public GameEntryApprovalParameter()
	{
	}
}
