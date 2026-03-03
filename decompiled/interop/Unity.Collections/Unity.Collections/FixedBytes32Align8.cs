using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Unity.Collections;

[Serializable]
[StructLayout(2)]
[Token(Token = "0x2000027")]
[GenerateTestsForBurstCompatibility]
internal struct FixedBytes32Align8
{
	[Token(Token = "0x400005C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[SerializeField]
	internal FixedBytes16Align8 offset0000;

	[Token(Token = "0x400005D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[SerializeField]
	internal FixedBytes16Align8 offset0016;
}
