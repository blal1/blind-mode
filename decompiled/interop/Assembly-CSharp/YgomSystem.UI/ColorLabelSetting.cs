using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.UI;

[Token(Token = "0x200044B")]
public class ColorLabelSetting : ScriptableObject
{
	[Serializable]
	[Token(Token = "0x200044C")]
	public class ValueContainer
	{
		[Token(Token = "0x40014FC")]
		[FieldOffset(Offset = "0x10")]
		public string label;

		[Token(Token = "0x40014FD")]
		[FieldOffset(Offset = "0x18")]
		public Color color;

		[Token(Token = "0x6001B84")]
		[Address(RVA = "0x5F90D0", Offset = "0x5F82D0", VA = "0x1805F90D0")]
		public ValueContainer Copy()
		{
			return null;
		}

		[Token(Token = "0x6001B85")]
		[Address(RVA = "0x5F9160", Offset = "0x5F8360", VA = "0x1805F9160")]
		public ValueContainer()
		{
		}
	}

	[Token(Token = "0x40014FA")]
	[FieldOffset(Offset = "0x18")]
	public List<ValueContainer> list;

	[Token(Token = "0x40014FB")]
	[FieldOffset(Offset = "0x20")]
	private Dictionary<string, ValueContainer> m_labelMap;

	[Token(Token = "0x6001B80")]
	[Address(RVA = "0x5E30D0", Offset = "0x5E22D0", VA = "0x1805E30D0")]
	public void Setup()
	{
	}

	[Token(Token = "0x6001B81")]
	[Address(RVA = "0x5E2F80", Offset = "0x5E2180", VA = "0x1805E2F80")]
	public ValueContainer Get(string label)
	{
		return null;
	}

	[Token(Token = "0x6001B82")]
	[Address(RVA = "0x5E3010", Offset = "0x5E2210", VA = "0x1805E3010")]
	public bool Get(string label, out Color res)
	{
		return default(bool);
	}

	[Token(Token = "0x6001B83")]
	[Address(RVA = "0x5E3200", Offset = "0x5E2400", VA = "0x1805E3200")]
	public ColorLabelSetting()
	{
	}
}
