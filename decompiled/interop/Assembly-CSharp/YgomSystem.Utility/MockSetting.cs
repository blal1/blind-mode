using System;
using Il2CppDummyDll;

namespace YgomSystem.Utility;

[Serializable]
[Token(Token = "0x20003EE")]
public class MockSetting
{
	[Token(Token = "0x40013AB")]
	[FieldOffset(Offset = "0x10")]
	public Mock mock1;

	[Token(Token = "0x40013AC")]
	[FieldOffset(Offset = "0x18")]
	public Mock mock2;

	[Token(Token = "0x40013AD")]
	[FieldOffset(Offset = "0x20")]
	public Mock mock3;

	[Token(Token = "0x6001936")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public MockSetting()
	{
	}
}
