using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.Utility;

[Token(Token = "0x20003A4")]
public class AssetLinker : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x20003A5")]
	public class LinkInfo
	{
		[Token(Token = "0x400127E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string label;

		[Token(Token = "0x400127F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string assetPath;

		[Token(Token = "0x6001620")]
		[Address(RVA = "0x5BF510", Offset = "0x5BE710", VA = "0x1805BF510")]
		public LinkInfo Copy()
		{
			return null;
		}

		[Token(Token = "0x6001621")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public LinkInfo()
		{
		}
	}

	[Token(Token = "0x4001279")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<LinkInfo> infoList;

	[Token(Token = "0x400127A")]
	private const string dirNameResources = "/Resources/";

	[Token(Token = "0x400127B")]
	private const int dirNameResourcesLength = 11;

	[Token(Token = "0x400127C")]
	private const string dirNameResourcesAB = "/ResourcesAssetBundle/";

	[Token(Token = "0x400127D")]
	private const int dirNameResourcesABLength = 22;

	[Token(Token = "0x600161A")]
	[Address(RVA = "0x5A0820", Offset = "0x59FA20", VA = "0x1805A0820")]
	public void Instantiate(string label, Transform parent, Action<GameObject> onFinished)
	{
	}

	[Token(Token = "0x600161B")]
	[Address(RVA = "0x5A05B0", Offset = "0x59F7B0", VA = "0x1805A05B0")]
	public string GetAssetPath(string label)
	{
		return null;
	}

	[Token(Token = "0x600161C")]
	[Address(RVA = "0x5A05F0", Offset = "0x59F7F0", VA = "0x1805A05F0")]
	public void GetAsset(string label, Action<UnityEngine.Object> onFinished, [Optional] Type systemTypeInstance)
	{
	}

	[Token(Token = "0x600161D")]
	[Address(RVA = "0x5A0460", Offset = "0x59F660", VA = "0x1805A0460")]
	private LinkInfo FindLinkInfo(string label)
	{
		return null;
	}

	[Token(Token = "0x600161E")]
	[Address(RVA = "0x5A0740", Offset = "0x59F940", VA = "0x1805A0740")]
	public static string GetResourcePath(string fullPath)
	{
		return null;
	}

	[Token(Token = "0x600161F")]
	[Address(RVA = "0x5A0A00", Offset = "0x59FC00", VA = "0x1805A0A00")]
	public AssetLinker()
	{
	}
}
