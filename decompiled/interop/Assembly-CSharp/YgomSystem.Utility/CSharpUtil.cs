using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.Utility;

[Token(Token = "0x20003C8")]
public class CSharpUtil
{
	[Token(Token = "0x400130E")]
	[FieldOffset(Offset = "0x10")]
	private Light light;

	[Token(Token = "0x400130F")]
	[FieldOffset(Offset = "0x18")]
	private Flare flare;

	[Token(Token = "0x4001310")]
	[FieldOffset(Offset = "0x20")]
	private LensFlare lensFlare;

	[Token(Token = "0x4001311")]
	[FieldOffset(Offset = "0x28")]
	private SkinnedMeshRenderer smr;

	[Token(Token = "0x6001822")]
	public static List<T> ToList<T>(object o)
	{
		return null;
	}

	[Token(Token = "0x6001823")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public CSharpUtil()
	{
	}
}
