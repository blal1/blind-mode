using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame;

[Token(Token = "0x2000700")]
public class OnDemandLogoData
{
	[Token(Token = "0x4002317")]
	[FieldOffset(Offset = "0x10")]
	public string logoImagePath;

	[Token(Token = "0x4002318")]
	[FieldOffset(Offset = "0x18")]
	public Color bgColor;

	[Token(Token = "0x6002E64")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public OnDemandLogoData()
	{
	}
}
