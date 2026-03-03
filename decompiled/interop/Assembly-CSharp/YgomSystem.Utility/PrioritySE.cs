using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.Utility;

[Token(Token = "0x20003F5")]
public class PrioritySE : MonoBehaviour
{
	[Token(Token = "0x40013BD")]
	[FieldOffset(Offset = "0x0")]
	private static SortedDictionary<string, int> priority;

	[Token(Token = "0x40013BE")]
	[FieldOffset(Offset = "0x8")]
	private static string crntSe;

	[Token(Token = "0x40013BF")]
	[FieldOffset(Offset = "0x10")]
	private static int crntSePrio;

	[Token(Token = "0x40013C0")]
	[FieldOffset(Offset = "0x14")]
	private static bool disableFrame;

	[Token(Token = "0x600194E")]
	[Address(RVA = "0x5D2120", Offset = "0x5D1320", VA = "0x1805D2120")]
	public static void SetPriority(string se, int prio)
	{
	}

	[Token(Token = "0x600194F")]
	[Address(RVA = "0x5D1C90", Offset = "0x5D0E90", VA = "0x1805D1C90")]
	public static void DisableFrame()
	{
	}

	[Token(Token = "0x6001950")]
	[Address(RVA = "0x5D1FA0", Offset = "0x5D11A0", VA = "0x1805D1FA0")]
	public static void Play(string se)
	{
	}

	[Token(Token = "0x6001951")]
	[Address(RVA = "0x5D1CE0", Offset = "0x5D0EE0", VA = "0x1805D1CE0")]
	public static void ExecPlay()
	{
	}

	[Token(Token = "0x6001952")]
	[Address(RVA = "0x5D21B0", Offset = "0x5D13B0", VA = "0x1805D21B0")]
	private void Start()
	{
	}

	[Token(Token = "0x6001953")]
	[Address(RVA = "0x5D1E20", Offset = "0x5D1020", VA = "0x1805D1E20")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6001954")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public PrioritySE()
	{
	}
}
