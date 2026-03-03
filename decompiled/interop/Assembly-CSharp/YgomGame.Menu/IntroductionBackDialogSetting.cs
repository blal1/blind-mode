using Il2CppDummyDll;

namespace YgomGame.Menu;

[Token(Token = "0x20011A4")]
public class IntroductionBackDialogSetting
{
	[Token(Token = "0x400B855")]
	[FieldOffset(Offset = "0x10")]
	public string title;

	[Token(Token = "0x400B856")]
	[FieldOffset(Offset = "0x18")]
	public string message;

	[Token(Token = "0x400B857")]
	[FieldOffset(Offset = "0x20")]
	public string bottonLabel;

	[Token(Token = "0x6006EBE")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public IntroductionBackDialogSetting()
	{
	}
}
