using System;
using Il2CppDummyDll;

namespace YgomGame.Menu;

[Token(Token = "0x20011F5")]
public class PrivacyPolicyParameter
{
	[Token(Token = "0x400B995")]
	[FieldOffset(Offset = "0x10")]
	public UserAgreementType type;

	[Token(Token = "0x400B996")]
	[FieldOffset(Offset = "0x18")]
	public Action<int> resultCallback;

	[Token(Token = "0x400B997")]
	[FieldOffset(Offset = "0x20")]
	public IntroductionBackDialogSetting backDialogSetting;

	[Token(Token = "0x6007032")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public PrivacyPolicyParameter()
	{
	}
}
