using System;
using Il2CppDummyDll;

namespace YgomGame.GemShop;

[Token(Token = "0x2000DA6")]
public class GemShopPermissionParameter
{
	[Token(Token = "0x4009FBA")]
	[FieldOffset(Offset = "0x10")]
	public Action<GemShopPermissionResult> resultCallback;

	[Token(Token = "0x60051F2")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public GemShopPermissionParameter()
	{
	}
}
