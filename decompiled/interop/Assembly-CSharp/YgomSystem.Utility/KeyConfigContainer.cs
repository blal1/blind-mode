using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.UI;

namespace YgomSystem.Utility;

[Token(Token = "0x20003E5")]
[CreateAssetMenu(menuName = "Scriptable Object/KeyConfigContainer")]
public class KeyConfigContainer : ScriptableObject
{
	[Serializable]
	[Token(Token = "0x20003E6")]
	public class KeyConfig
	{
		[Token(Token = "0x4001388")]
		[FieldOffset(Offset = "0x10")]
		public string label;

		[Token(Token = "0x4001389")]
		[FieldOffset(Offset = "0x18")]
		public SelectorManager.KeyType keyTypeMain;

		[Token(Token = "0x400138A")]
		[FieldOffset(Offset = "0x1C")]
		public SelectorManager.KeyType keyTypeSub;

		[Token(Token = "0x6001907")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public KeyConfig()
		{
		}
	}

	[Token(Token = "0x4001387")]
	[FieldOffset(Offset = "0x18")]
	public List<KeyConfig> keyConfigList;

	[Token(Token = "0x6001905")]
	[Address(RVA = "0x5CE8E0", Offset = "0x5CDAE0", VA = "0x1805CE8E0")]
	public (SelectorManager.KeyType, SelectorManager.KeyType) GetKeyType(string label)
	{
		return default((SelectorManager.KeyType, SelectorManager.KeyType));
	}

	[Token(Token = "0x6001906")]
	[Address(RVA = "0x3D4F30", Offset = "0x3D4130", VA = "0x1803D4F30")]
	public KeyConfigContainer()
	{
	}
}
