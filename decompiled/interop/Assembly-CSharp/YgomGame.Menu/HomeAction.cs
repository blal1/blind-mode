using System;
using Il2CppDummyDll;

namespace YgomGame.Menu;

[Token(Token = "0x20012C4")]
public class HomeAction
{
	[Token(Token = "0x400BD3D")]
	[FieldOffset(Offset = "0x10")]
	public int priority;

	[Token(Token = "0x400BD3E")]
	[FieldOffset(Offset = "0x18")]
	public Action<Action> action;

	[Token(Token = "0x6007495")]
	[Address(RVA = "0x500960", Offset = "0x4FFB60", VA = "0x180500960")]
	public HomeAction(int priority, Action<Action> action)
	{
	}
}
