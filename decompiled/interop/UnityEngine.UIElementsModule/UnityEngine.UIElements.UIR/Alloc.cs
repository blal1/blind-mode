using Il2CppDummyDll;

namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x2000525")]
internal struct Alloc
{
	[Token(Token = "0x4001122")]
	[FieldOffset(Offset = "0x0")]
	public uint start;

	[Token(Token = "0x4001123")]
	[FieldOffset(Offset = "0x4")]
	public uint size;

	[Token(Token = "0x4001124")]
	[FieldOffset(Offset = "0x8")]
	internal object handle;

	[Token(Token = "0x4001125")]
	[FieldOffset(Offset = "0x10")]
	internal bool shortLived;
}
