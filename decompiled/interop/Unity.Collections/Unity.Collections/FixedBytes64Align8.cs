using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Unity.Collections;

[Serializable]
[StructLayout(2)]
[Token(Token = "0x2000028")]
[GenerateTestsForBurstCompatibility]
internal struct FixedBytes64Align8
{
	[Token(Token = "0x400005E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[SerializeField]
	internal FixedBytes16Align8 offset0000;

	[Token(Token = "0x400005F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[SerializeField]
	internal FixedBytes16Align8 offset0016;

	[Token(Token = "0x4000060")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	internal FixedBytes16Align8 offset0032;

	[Token(Token = "0x4000061")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	internal FixedBytes16Align8 offset0048;
}
