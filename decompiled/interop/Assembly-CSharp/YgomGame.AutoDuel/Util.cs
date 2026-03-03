using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace YgomGame.AutoDuel;

[Token(Token = "0x2001DB3")]
public static class Util
{
	[Token(Token = "0x600BDEA")]
	[Address(RVA = "0x594EE0", Offset = "0x5940E0", VA = "0x180594EE0")]
	public static bool SetText(TMP_Text target, string text)
	{
		return default(bool);
	}

	[Token(Token = "0x600BDEB")]
	[Address(RVA = "0x594D70", Offset = "0x593F70", VA = "0x180594D70")]
	public static bool SetActive(GameObject target, bool active)
	{
		return default(bool);
	}

	[Token(Token = "0x600BDEC")]
	[Address(RVA = "0x594E00", Offset = "0x594000", VA = "0x180594E00")]
	public static bool SetGameObjectActive(Component target, bool active)
	{
		return default(bool);
	}

	[Token(Token = "0x600BDED")]
	public static bool ActionFor<T>(T target, Action<T> action) where T : UnityEngine.Object
	{
		return default(bool);
	}
}
