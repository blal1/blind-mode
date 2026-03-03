using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.Utility;

[Token(Token = "0x2000407")]
[CreateAssetMenu(menuName = "Scriptable Object/SpriteContainer")]
public class SpriteContainer : ScriptableObject
{
	[Serializable]
	[Token(Token = "0x2000408")]
	public class Container
	{
		[Token(Token = "0x4001402")]
		[FieldOffset(Offset = "0x10")]
		public string label;

		[Token(Token = "0x4001403")]
		[FieldOffset(Offset = "0x18")]
		public Sprite sprite;

		[Token(Token = "0x60019B9")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public Container()
		{
		}
	}

	[Token(Token = "0x4001400")]
	[FieldOffset(Offset = "0x18")]
	public List<Container> containers;

	[Token(Token = "0x4001401")]
	[FieldOffset(Offset = "0x20")]
	public UnityEngine.Object extraAsset;

	[Token(Token = "0x60019B6")]
	[Address(RVA = "0x5D7940", Offset = "0x5D6B40", VA = "0x1805D7940")]
	public Container GetContainer(string label)
	{
		return null;
	}

	[Token(Token = "0x60019B7")]
	[Address(RVA = "0x5D7A90", Offset = "0x5D6C90", VA = "0x1805D7A90")]
	public Sprite GetSprite(string label)
	{
		return null;
	}

	[Token(Token = "0x60019B8")]
	[Address(RVA = "0x5D7AB0", Offset = "0x5D6CB0", VA = "0x1805D7AB0")]
	public SpriteContainer()
	{
	}
}
