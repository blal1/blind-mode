using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.IO;

namespace UnityEngine;

public static class ManagedStreamHelpers : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_ValidateLoadFromStream_Internal_Static_Void_Stream_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ManagedStreamRead_Internal_Static_Void_Il2CppStructArray_1_Byte_Int32_Int32_Stream_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ManagedStreamSeek_Internal_Static_Void_Int64_UInt32_Stream_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ManagedStreamLength_Internal_Static_Void_Stream_IntPtr_0;

	static ManagedStreamHelpers()
	{
		Il2CppClassPointerStore<ManagedStreamHelpers>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "ManagedStreamHelpers");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ManagedStreamHelpers>.NativeClassPtr);
		NativeMethodInfoPtr_ValidateLoadFromStream_Internal_Static_Void_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedStreamHelpers>.NativeClassPtr, 100666394);
		NativeMethodInfoPtr_ManagedStreamRead_Internal_Static_Void_Il2CppStructArray_1_Byte_Int32_Int32_Stream_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedStreamHelpers>.NativeClassPtr, 100666395);
		NativeMethodInfoPtr_ManagedStreamSeek_Internal_Static_Void_Int64_UInt32_Stream_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedStreamHelpers>.NativeClassPtr, 100666396);
		NativeMethodInfoPtr_ManagedStreamLength_Internal_Static_Void_Stream_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedStreamHelpers>.NativeClassPtr, 100666397);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1202960, RefRangeEnd = 1202963, XrefRangeStart = 1202960, XrefRangeEnd = 1202960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ValidateLoadFromStream(Stream stream)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)stream);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ValidateLoadFromStream_Internal_Static_Void_Stream_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1202963, XrefRangeEnd = 1202965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ManagedStreamRead(Il2CppStructArray<byte> buffer, int offset, int count, Stream stream, System.IntPtr returnValueAddress)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buffer);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &offset;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)stream);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &returnValueAddress;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ManagedStreamRead_Internal_Static_Void_Il2CppStructArray_1_Byte_Int32_Int32_Stream_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1202965, XrefRangeEnd = 1202967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ManagedStreamSeek(long offset, uint origin, Stream stream, System.IntPtr returnValueAddress)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&offset);
		*(uint**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &origin;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)stream);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &returnValueAddress;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ManagedStreamSeek_Internal_Static_Void_Int64_UInt32_Stream_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1202967, XrefRangeEnd = 1202969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ManagedStreamLength(Stream stream, System.IntPtr returnValueAddress)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)stream);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &returnValueAddress;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ManagedStreamLength_Internal_Static_Void_Stream_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public ManagedStreamHelpers(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
