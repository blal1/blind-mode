using System;
using Il2CppDummyDll;

namespace YgomGame.Menu;

[Token(Token = "0x20011A7")]
public class AgeSelectParameter
{
	[Token(Token = "0x400B865")]
	[FieldOffset(Offset = "0x10")]
	public int ageDefault;

	[Token(Token = "0x400B866")]
	[FieldOffset(Offset = "0x14")]
	public int ageAvailable;

	[Token(Token = "0x400B867")]
	[FieldOffset(Offset = "0x18")]
	public int ageRangeMin;

	[Token(Token = "0x400B868")]
	[FieldOffset(Offset = "0x1C")]
	public int ageRangeMax;

	[Token(Token = "0x400B869")]
	[FieldOffset(Offset = "0x20")]
	public Action<int> resultCallback;

	[Token(Token = "0x400B86A")]
	[FieldOffset(Offset = "0x28")]
	public IntroductionBackDialogSetting backDialogSetting;

	[Token(Token = "0x6006ECF")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public AgeSelectParameter()
	{
	}
}
