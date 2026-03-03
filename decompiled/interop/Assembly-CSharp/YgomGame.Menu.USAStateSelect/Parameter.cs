using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomGame.Menu.USAStateSelect;

[Token(Token = "0x20013F5")]
public class Parameter
{
	[Token(Token = "0x400C4A3")]
	[FieldOffset(Offset = "0x10")]
	public int defaultState;

	[Token(Token = "0x400C4A4")]
	[FieldOffset(Offset = "0x18")]
	public IReadOnlyList<int> codeList;

	[Token(Token = "0x400C4A5")]
	[FieldOffset(Offset = "0x20")]
	public IReadOnlyList<string> nameList;

	[Token(Token = "0x400C4A6")]
	[FieldOffset(Offset = "0x28")]
	public Action<int> resultCallback;

	[Token(Token = "0x400C4A7")]
	[FieldOffset(Offset = "0x30")]
	public IntroductionBackDialogSetting backDialogSetting;

	[Token(Token = "0x6007C36")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public Parameter()
	{
	}
}
