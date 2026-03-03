using System;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.Utility;

[Token(Token = "0x20003A8")]
public class AssetPathAttribute : PropertyAttribute
{
	[Token(Token = "0x20003A9")]
	public enum PathType
	{
		[Token(Token = "0x4001286")]
		ResourceManager,
		[Token(Token = "0x4001287")]
		AssetDatabase
	}

	[Token(Token = "0x4001283")]
	[FieldOffset(Offset = "0x18")]
	public readonly Type assetType;

	[Token(Token = "0x4001284")]
	[FieldOffset(Offset = "0x20")]
	public readonly PathType pathType;

	[Token(Token = "0x6001626")]
	[Address(RVA = "0x5A0B10", Offset = "0x59FD10", VA = "0x1805A0B10")]
	public AssetPathAttribute()
	{
	}

	[Token(Token = "0x6001627")]
	[Address(RVA = "0x5A0AD0", Offset = "0x59FCD0", VA = "0x1805A0AD0")]
	public AssetPathAttribute(Type assetType)
	{
	}

	[Token(Token = "0x6001628")]
	[Address(RVA = "0x5A0A80", Offset = "0x59FC80", VA = "0x1805A0A80")]
	public AssetPathAttribute(Type assetType, PathType pathType)
	{
	}
}
