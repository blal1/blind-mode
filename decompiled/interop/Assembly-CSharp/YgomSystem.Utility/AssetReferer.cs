using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.Utility;

[Token(Token = "0x20003AA")]
public class AssetReferer : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x20003AB")]
	public class ReferenceInfo
	{
		[Token(Token = "0x4001289")]
		[FieldOffset(Offset = "0x10")]
		public string label;

		[Token(Token = "0x400128A")]
		[FieldOffset(Offset = "0x18")]
		public UnityEngine.Object assetRef;

		[Token(Token = "0x600162E")]
		[Address(RVA = "0x5C1070", Offset = "0x5C0270", VA = "0x1805C1070")]
		public ReferenceInfo Copy()
		{
			return null;
		}

		[Token(Token = "0x600162F")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public ReferenceInfo()
		{
		}
	}

	[Token(Token = "0x4001288")]
	[FieldOffset(Offset = "0x20")]
	public List<ReferenceInfo> infoList;

	[Token(Token = "0x6001629")]
	[Address(RVA = "0x5A0D00", Offset = "0x59FF00", VA = "0x1805A0D00")]
	public GameObject Instantiate(string label, Transform parent)
	{
		return null;
	}

	[Token(Token = "0x600162A")]
	[Address(RVA = "0x5A0CE0", Offset = "0x59FEE0", VA = "0x1805A0CE0")]
	public UnityEngine.Object GetAsset(string label)
	{
		return null;
	}

	[Token(Token = "0x600162B")]
	public T GetAsset<T>(string label) where T : UnityEngine.Object
	{
		return null;
	}

	[Token(Token = "0x600162C")]
	[Address(RVA = "0x5A0B90", Offset = "0x59FD90", VA = "0x1805A0B90")]
	private ReferenceInfo FindReferenceInfo(string label)
	{
		return null;
	}

	[Token(Token = "0x600162D")]
	[Address(RVA = "0x5A0E00", Offset = "0x5A0000", VA = "0x1805A0E00")]
	public AssetReferer()
	{
	}
}
