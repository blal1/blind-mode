using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppMono;

public static class RuntimeMarshal : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_PtrToUtf8String_Internal_Static_String_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MarshalString_Internal_Static_SafeStringMarshal_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DecodeBlobSize_Private_Static_Int32_IntPtr_byref_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DecodeBlobArray_Internal_Static_Il2CppStructArray_1_Byte_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AsciHexDigitValue_Internal_Static_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FreeAssemblyName_Internal_Static_Void_byref_MonoAssemblyName_Boolean_0;

	static RuntimeMarshal()
	{
		Il2CppClassPointerStore<RuntimeMarshal>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Mono", "RuntimeMarshal");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RuntimeMarshal>.NativeClassPtr);
		NativeMethodInfoPtr_PtrToUtf8String_Internal_Static_String_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeMarshal>.NativeClassPtr, 100663398);
		NativeMethodInfoPtr_MarshalString_Internal_Static_SafeStringMarshal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeMarshal>.NativeClassPtr, 100663399);
		NativeMethodInfoPtr_DecodeBlobSize_Private_Static_Int32_IntPtr_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeMarshal>.NativeClassPtr, 100663400);
		NativeMethodInfoPtr_DecodeBlobArray_Internal_Static_Il2CppStructArray_1_Byte_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeMarshal>.NativeClassPtr, 100663401);
		NativeMethodInfoPtr_AsciHexDigitValue_Internal_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeMarshal>.NativeClassPtr, 100663402);
		NativeMethodInfoPtr_FreeAssemblyName_Internal_Static_Void_byref_MonoAssemblyName_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeMarshal>.NativeClassPtr, 100663403);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 696585, RefRangeEnd = 696587, XrefRangeStart = 696581, XrefRangeEnd = 696585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string PtrToUtf8String(System.IntPtr ptr)
	{
		System.IntPtr* ptr2 = stackalloc System.IntPtr[1];
		*ptr2 = (nint)(&ptr);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PtrToUtf8String_Internal_Static_String_IntPtr_0, (System.IntPtr)0, (void**)ptr2, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 696588, RefRangeEnd = 696590, XrefRangeStart = 696587, XrefRangeEnd = 696588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static SafeStringMarshal MarshalString(string str)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MarshalString_Internal_Static_SafeStringMarshal_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new SafeStringMarshal(pointer);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 696590, XrefRangeEnd = 696594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int DecodeBlobSize(System.IntPtr in_ptr, out System.IntPtr out_ptr)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&in_ptr);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref out_ptr);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DecodeBlobSize_Private_Static_Int32_IntPtr_byref_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 696605, RefRangeEnd = 696606, XrefRangeStart = 696594, XrefRangeEnd = 696605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<byte> DecodeBlobArray(System.IntPtr ptr)
	{
		System.IntPtr* ptr2 = stackalloc System.IntPtr[1];
		*ptr2 = (nint)(&ptr);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DecodeBlobArray_Internal_Static_Il2CppStructArray_1_Byte_IntPtr_0, (System.IntPtr)0, (void**)ptr2, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
	}

	[CallerCount(0)]
	public unsafe static int AsciHexDigitValue(int c)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&c);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AsciHexDigitValue_Internal_Static_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 696607, RefRangeEnd = 696609, XrefRangeStart = 696606, XrefRangeEnd = 696607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void FreeAssemblyName(ref MonoAssemblyName name, bool freeStruct)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref name);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &freeStruct;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FreeAssemblyName_Internal_Static_Void_byref_MonoAssemblyName_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public RuntimeMarshal(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
