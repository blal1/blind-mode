using System;
using Il2CppDummyDll;

namespace YgomGame.Menu.TermOfService;

[Token(Token = "0x20013F7")]
public class Parameter
{
	[Token(Token = "0x400C4AD")]
	[FieldOffset(Offset = "0x10")]
	public string url;

	[Token(Token = "0x400C4AE")]
	[FieldOffset(Offset = "0x18")]
	public Action<int> resultCallback;

	[Token(Token = "0x400C4AF")]
	[FieldOffset(Offset = "0x20")]
	public UserAgreementType type;

	[Token(Token = "0x400C4B0")]
	[FieldOffset(Offset = "0x28")]
	public IntroductionBackDialogSetting backDialogSetting;

	[Token(Token = "0x6007C42")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public Parameter()
	{
	}
}
