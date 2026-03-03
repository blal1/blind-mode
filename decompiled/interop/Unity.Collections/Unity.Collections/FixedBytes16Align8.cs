using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Unity.Collections;

[Serializable]
[StructLayout(2)]
[Token(Token = "0x2000026")]
[GenerateTestsForBurstCompatibility]
internal struct FixedBytes16Align8
{
	[Token(Token = "0x400005A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[SerializeField]
	public ulong byte0000;

	[Token(Token = "0x400005B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	[SerializeField]
	public ulong byte0008;
}
