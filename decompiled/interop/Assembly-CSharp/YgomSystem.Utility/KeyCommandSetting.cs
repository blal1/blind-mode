using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.UI;

namespace YgomSystem.Utility;

[Token(Token = "0x20003DE")]
[CreateAssetMenu(menuName = "Scriptable Object/KeyCommandSetting")]
public class KeyCommandSetting : ScriptableObject
{
	[Serializable]
	[Token(Token = "0x20003DF")]
	public class KeyCommandInfo
	{
		[Token(Token = "0x4001378")]
		[FieldOffset(Offset = "0x10")]
		public string label;

		[Token(Token = "0x4001379")]
		[FieldOffset(Offset = "0x18")]
		public List<SelectorManager.KeyType> keyList;

		[Token(Token = "0x60018F7")]
		[Address(RVA = "0x5CDFD0", Offset = "0x5CD1D0", VA = "0x1805CDFD0")]
		public KeyCommandInfo()
		{
		}
	}

	[Token(Token = "0x4001377")]
	[FieldOffset(Offset = "0x18")]
	public List<KeyCommandInfo> infoList;

	[Token(Token = "0x60018F5")]
	[Address(RVA = "0x5CE050", Offset = "0x5CD250", VA = "0x1805CE050")]
	public KeyCommandInfo Get(string label)
	{
		return null;
	}

	[Token(Token = "0x60018F6")]
	[Address(RVA = "0x5CE1A0", Offset = "0x5CD3A0", VA = "0x1805CE1A0")]
	public KeyCommandSetting()
	{
	}
}
