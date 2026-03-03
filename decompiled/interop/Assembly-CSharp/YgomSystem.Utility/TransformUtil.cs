using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.Utility;

[Token(Token = "0x200041B")]
public static class TransformUtil
{
	[Token(Token = "0x6001A7F")]
	[Address(RVA = "0x5F1420", Offset = "0x5F0620", VA = "0x1805F1420")]
	public static (int, int) GetHierarchyDepth(Transform target, [Optional] Transform root)
	{
		return default((int, int));
	}

	[Token(Token = "0x6001A80")]
	[Address(RVA = "0x5F1550", Offset = "0x5F0750", VA = "0x1805F1550")]
	public static int GetHierarchyIndex(Transform target, Transform root)
	{
		return default(int);
	}

	[Token(Token = "0x6001A81")]
	[Address(RVA = "0x5F1310", Offset = "0x5F0510", VA = "0x1805F1310")]
	private static bool GetChildCount(Transform parent, Transform findTarget, ref int index)
	{
		return default(bool);
	}

	[Token(Token = "0x6001A82")]
	[Address(RVA = "0x5F1580", Offset = "0x5F0780", VA = "0x1805F1580")]
	public static string GetHierarchyPath(Transform target)
	{
		return null;
	}
}
