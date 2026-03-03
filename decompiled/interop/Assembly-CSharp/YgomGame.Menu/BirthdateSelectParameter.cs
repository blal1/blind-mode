using System;
using Il2CppDummyDll;

namespace YgomGame.Menu;

[Token(Token = "0x20011AA")]
public class BirthdateSelectParameter
{
	[Token(Token = "0x400B873")]
	[FieldOffset(Offset = "0x10")]
	public int defaultYear;

	[Token(Token = "0x400B874")]
	[FieldOffset(Offset = "0x14")]
	public int defaultMonth;

	[Token(Token = "0x400B875")]
	[FieldOffset(Offset = "0x18")]
	public int defaultDay;

	[Token(Token = "0x400B876")]
	[FieldOffset(Offset = "0x1C")]
	public int yearOfsNear;

	[Token(Token = "0x400B877")]
	[FieldOffset(Offset = "0x20")]
	public int yearOfsFar;

	[Token(Token = "0x400B878")]
	[FieldOffset(Offset = "0x28")]
	public Action<int, int, int> resultCallback;

	[Token(Token = "0x400B879")]
	[FieldOffset(Offset = "0x30")]
	public IntroductionBackDialogSetting backDialogSetting;

	[Token(Token = "0x6006EDB")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public BirthdateSelectParameter()
	{
	}
}
