using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.Utility;

[Token(Token = "0x200039E")]
[CreateAssetMenu(menuName = "Scriptable Object/AssetContainer")]
public class AssetContainer : ScriptableObject
{
	[Serializable]
	[Token(Token = "0x200039F")]
	public class Container
	{
		[Token(Token = "0x4001271")]
		[FieldOffset(Offset = "0x10")]
		public string label;

		[Token(Token = "0x4001272")]
		[FieldOffset(Offset = "0x18")]
		public UnityEngine.Object asset;

		[Token(Token = "0x6001610")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public Container()
		{
		}
	}

	[Token(Token = "0x4001270")]
	[FieldOffset(Offset = "0x18")]
	public List<Container> containers;

	[Token(Token = "0x600160C")]
	[Address(RVA = "0x59FEC0", Offset = "0x59F0C0", VA = "0x18059FEC0")]
	public Container GetContainer(string label)
	{
		return null;
	}

	[Token(Token = "0x600160D")]
	[Address(RVA = "0x59FEA0", Offset = "0x59F0A0", VA = "0x18059FEA0")]
	public UnityEngine.Object GetAsset(string label)
	{
		return null;
	}

	[Token(Token = "0x600160E")]
	public T GetAsset<T>(string label) where T : UnityEngine.Object
	{
		return null;
	}

	[Token(Token = "0x600160F")]
	[Address(RVA = "0x5A0010", Offset = "0x59F210", VA = "0x1805A0010")]
	public AssetContainer()
	{
	}
}
