using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x200050B")]
internal struct GfxUpdateBufferRange
{
	[Token(Token = "0x4001091")]
	[FieldOffset(Offset = "0x0")]
	public uint offsetFromWriteStart;

	[Token(Token = "0x4001092")]
	[FieldOffset(Offset = "0x4")]
	public uint size;

	[Token(Token = "0x4001093")]
	[FieldOffset(Offset = "0x8")]
	public UIntPtr source;
}
