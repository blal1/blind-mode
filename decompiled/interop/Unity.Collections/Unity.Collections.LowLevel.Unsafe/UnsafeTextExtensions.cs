using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Unity.Collections.LowLevel.Unsafe;

[Token(Token = "0x200008C")]
internal static class UnsafeTextExtensions
{
	[MethodImpl(256)]
	[Token(Token = "0x6000204")]
	[Address(RVA = "0x22FDDF0", Offset = "0x22FCFF0", VA = "0x1822FDDF0")]
	public unsafe static ref UnsafeList<byte> AsUnsafeListOfBytes(this ref UnsafeText text)
	{
		return ref *(UnsafeList<byte>*)null;
	}

	[MethodImpl(256)]
	[Token(Token = "0x6000205")]
	[Address(RVA = "0x22FDDA0", Offset = "0x22FCFA0", VA = "0x1822FDDA0")]
	public static UnsafeList<byte> AsUnsafeListOfBytesRO(this UnsafeText text)
	{
		return default(UnsafeList<byte>);
	}
}
