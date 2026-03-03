using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomGame.Menu.CountrySelect;

[Token(Token = "0x20013FB")]
public class Parameter
{
	[Token(Token = "0x400C4B7")]
	[FieldOffset(Offset = "0x10")]
	public int defaultCountry;

	[Token(Token = "0x400C4B8")]
	[FieldOffset(Offset = "0x18")]
	public IReadOnlyList<int> codeList;

	[Token(Token = "0x400C4B9")]
	[FieldOffset(Offset = "0x20")]
	public IReadOnlyList<string> nameList;

	[Token(Token = "0x400C4BA")]
	[FieldOffset(Offset = "0x28")]
	public Action<int> resultCallback;

	[Token(Token = "0x400C4BB")]
	[FieldOffset(Offset = "0x30")]
	public IntroductionBackDialogSetting backDialogSetting;

	[Token(Token = "0x6007C53")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public Parameter()
	{
	}
}
