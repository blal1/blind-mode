using System;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.UI;

[Serializable]
[Token(Token = "0x200044A")]
public class ColorLabelProperty
{
	[Token(Token = "0x40014F8")]
	[FieldOffset(Offset = "0x10")]
	[ColorLabelString]
	public string label;

	[Token(Token = "0x40014F9")]
	[FieldOffset(Offset = "0x18")]
	public Color rgba;

	[Token(Token = "0x6001B7E")]
	[Address(RVA = "0x5E2E70", Offset = "0x5E2070", VA = "0x1805E2E70")]
	public Color GetColor()
	{
		return default(Color);
	}

	[Token(Token = "0x6001B7F")]
	[Address(RVA = "0x5E2F60", Offset = "0x5E2160", VA = "0x1805E2F60")]
	public ColorLabelProperty()
	{
	}
}
