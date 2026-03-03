using System;
using Il2CppDummyDll;

namespace YgomGame.Menu;

[Token(Token = "0x2001229")]
public class OnDemandLogoParameter
{
	[Token(Token = "0x400BA60")]
	[FieldOffset(Offset = "0x10")]
	public OnDemandLogoData logoData;

	[Token(Token = "0x400BA61")]
	[FieldOffset(Offset = "0x18")]
	public Action resultCallback;

	[Token(Token = "0x600712A")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public OnDemandLogoParameter()
	{
	}
}
