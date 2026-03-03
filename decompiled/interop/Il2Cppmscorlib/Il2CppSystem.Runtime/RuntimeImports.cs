using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime;

public static class RuntimeImports : Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_RhZeroMemory_Internal_Static_Void_byref_Byte_UInt64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ZeroMemory_Private_Static_Void_ptr_Void_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Memmove_Internal_Static_Void_ptr_Byte_ptr_Byte_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Memmove_wbarrier_Internal_Static_Void_ptr_Byte_ptr_Byte_UInt32_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ecvt_s_Internal_Static_Void_ptr_Byte_Int32_Double_Int32_ptr_Int32_ptr_Int32_0;

	static RuntimeImports()
	{
		Il2CppClassPointerStore<RuntimeImports>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime", "RuntimeImports");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RuntimeImports>.NativeClassPtr);
		NativeMethodInfoPtr_RhZeroMemory_Internal_Static_Void_byref_Byte_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeImports>.NativeClassPtr, 100669770);
		NativeMethodInfoPtr_ZeroMemory_Private_Static_Void_ptr_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeImports>.NativeClassPtr, 100669771);
		NativeMethodInfoPtr_Memmove_Internal_Static_Void_ptr_Byte_ptr_Byte_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeImports>.NativeClassPtr, 100669772);
		NativeMethodInfoPtr_Memmove_wbarrier_Internal_Static_Void_ptr_Byte_ptr_Byte_UInt32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeImports>.NativeClassPtr, 100669773);
		NativeMethodInfoPtr__ecvt_s_Internal_Static_Void_ptr_Byte_Int32_Double_Int32_ptr_Int32_ptr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeImports>.NativeClassPtr, 100669774);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 789687, XrefRangeEnd = 789688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RhZeroMemory(ref byte b, ulong byteLength)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref b);
		*(ulong**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &byteLength;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RhZeroMemory_Internal_Static_Void_byref_Byte_UInt64_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ZeroMemory(void* p, uint byteLength)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)p;
		*(uint**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &byteLength;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ZeroMemory_Private_Static_Void_ptr_Void_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 789689, RefRangeEnd = 789692, XrefRangeStart = 789688, XrefRangeEnd = 789689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Memmove(byte* dest, byte* src, uint len)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)dest;
		*(byte**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = src;
		*(uint**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &len;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Memmove_Internal_Static_Void_ptr_Byte_ptr_Byte_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 789693, RefRangeEnd = 789695, XrefRangeStart = 789692, XrefRangeEnd = 789693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Memmove_wbarrier(byte* dest, byte* src, uint len, System.IntPtr type_handle)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)dest;
		*(byte**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = src;
		*(uint**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &len;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &type_handle;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Memmove_wbarrier_Internal_Static_Void_ptr_Byte_ptr_Byte_UInt32_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 789696, RefRangeEnd = 789697, XrefRangeStart = 789695, XrefRangeEnd = 789696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void _ecvt_s(byte* buffer, int sizeInBytes, double value, int count, int* dec, int* sign)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)buffer;
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &sizeInBytes;
		*(double**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = dec;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = sign;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ecvt_s_Internal_Static_Void_ptr_Byte_Int32_Double_Int32_ptr_Int32_ptr_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public RuntimeImports(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
