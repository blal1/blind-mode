using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Security.Cryptography;

public static class CryptographicOperations : Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_ZeroMemory_Public_Static_Void_Span_1_Byte_0;

	static CryptographicOperations()
	{
		Il2CppClassPointerStore<CryptographicOperations>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "CryptographicOperations");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CryptographicOperations>.NativeClassPtr);
		NativeMethodInfoPtr_ZeroMemory_Public_Static_Void_Span_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptographicOperations>.NativeClassPtr, 100669198);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 784742, RefRangeEnd = 784750, XrefRangeStart = 784739, XrefRangeEnd = 784742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ZeroMemory(Span<byte> buffer)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)buffer));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ZeroMemory_Public_Static_Void_Span_1_Byte_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public CryptographicOperations(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
