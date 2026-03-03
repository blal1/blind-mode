using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements.Layout;

[Token(Token = "0x20005A2")]
internal struct FixedBuffer2<T> where T : struct
{
	[Token(Token = "0x400142E")]
	[FieldOffset(Offset = "0x0")]
	private T __0;

	[Token(Token = "0x400142F")]
	[FieldOffset(Offset = "0x0")]
	private T __1;

	[Token(Token = "0x17000A1D")]
	public unsafe ref T this[int index]
	{
		[MethodImpl(256)]
		[Token(Token = "0x60027A4")]
		get
		{
			return ref *(T*)null;
		}
	}
}
