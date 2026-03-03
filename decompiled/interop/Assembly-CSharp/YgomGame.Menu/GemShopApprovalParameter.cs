using System;
using Il2CppDummyDll;

namespace YgomGame.Menu;

[Token(Token = "0x200119A")]
public class GemShopApprovalParameter
{
	[Token(Token = "0x400B829")]
	[FieldOffset(Offset = "0x10")]
	public Action<bool> resultCallback;

	[Token(Token = "0x6006E91")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public GemShopApprovalParameter()
	{
	}
}
