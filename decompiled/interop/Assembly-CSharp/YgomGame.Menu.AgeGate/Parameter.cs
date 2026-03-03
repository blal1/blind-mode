using System;
using Il2CppDummyDll;

namespace YgomGame.Menu.AgeGate;

[Token(Token = "0x20013EF")]
public class Parameter
{
	[Token(Token = "0x400C493")]
	[FieldOffset(Offset = "0x10")]
	public int defaultYear;

	[Token(Token = "0x400C494")]
	[FieldOffset(Offset = "0x14")]
	public int defaultMonth;

	[Token(Token = "0x400C495")]
	[FieldOffset(Offset = "0x18")]
	public int defaultDay;

	[Token(Token = "0x400C496")]
	[FieldOffset(Offset = "0x20")]
	public Action<int, int, int> resultCallback;

	[Token(Token = "0x6007C0E")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public Parameter()
	{
	}
}
