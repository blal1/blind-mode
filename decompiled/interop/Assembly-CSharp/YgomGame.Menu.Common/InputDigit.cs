using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace YgomGame.Menu.Common;

[Token(Token = "0x2001401")]
public static class InputDigit
{
	[Token(Token = "0x6007C76")]
	[Address(RVA = "0xC64080", Offset = "0xC63280", VA = "0x180C64080")]
	public static void OpenDialog(string title, string message, int initValue, int maxValue, int minValue, int largeChangeAmount, [Optional] Action<int> onInputEnd, [Optional] Dictionary<string, object> args)
	{
	}
}
