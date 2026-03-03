using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.Utility;

[Token(Token = "0x20003A0")]
[CreateAssetMenu(menuName = "Scriptable Object/AssetLinkContainer")]
public class AssetLinkContainer : ScriptableObject
{
	[Serializable]
	[Token(Token = "0x20003A1")]
	public class Container
	{
		[Token(Token = "0x4001274")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string label;

		[Token(Token = "0x4001275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string assetPath;

		[Token(Token = "0x6001614")]
		[Address(RVA = "0x5B9F90", Offset = "0x5B9190", VA = "0x1805B9F90")]
		public Container Copy()
		{
			return null;
		}

		[Token(Token = "0x6001615")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public Container()
		{
		}
	}

	[Token(Token = "0x4001273")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<Container> containers;

	[Token(Token = "0x6001611")]
	[Address(RVA = "0x5A0310", Offset = "0x59F510", VA = "0x1805A0310", Slot = "4")]
	public virtual Container GetContainer(string label)
	{
		return null;
	}

	[Token(Token = "0x6001612")]
	[Address(RVA = "0x5A01D0", Offset = "0x59F3D0", VA = "0x1805A01D0")]
	public void GetAsset(string label, Action<UnityEngine.Object> onFinished, [Optional] Type systemTypeInstance)
	{
	}

	[Token(Token = "0x6001613")]
	[Address(RVA = "0x5A0150", Offset = "0x59F350", VA = "0x1805A0150")]
	public AssetLinkContainer()
	{
	}
}
