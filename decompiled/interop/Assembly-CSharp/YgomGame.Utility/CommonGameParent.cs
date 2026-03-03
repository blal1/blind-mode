using System;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Utility;

[Token(Token = "0x2000916")]
public class CommonGameParent
{
	[Token(Token = "0x4008993")]
	[FieldOffset(Offset = "0x0")]
	private static Transform _root;

	[Token(Token = "0x17000689")]
	public static Transform root
	{
		[Token(Token = "0x600368C")]
		[Address(RVA = "0x7B8A80", Offset = "0x7B7C80", VA = "0x1807B8A80")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600368D")]
	[Address(RVA = "0x7B8840", Offset = "0x7B7A40", VA = "0x1807B8840")]
	public static GameObject Create(string name, params Type[] c)
	{
		return null;
	}

	[Token(Token = "0x600368E")]
	[Address(RVA = "0x7B89C0", Offset = "0x7B7BC0", VA = "0x1807B89C0")]
	public static void DestroyGameRoot()
	{
	}

	[Token(Token = "0x600368F")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public CommonGameParent()
	{
	}
}
