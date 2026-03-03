using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppMono.Security;

public sealed class BitConverterLE : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_GetUIntBytes_Private_Static_Il2CppStructArray_1_Byte_ptr_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetULongBytes_Private_Static_Il2CppStructArray_1_Byte_ptr_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBytes_Internal_Static_Il2CppStructArray_1_Byte_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBytes_Internal_Static_Il2CppStructArray_1_Byte_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UIntFromBytes_Private_Static_Void_ptr_Byte_Il2CppStructArray_1_Byte_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ULongFromBytes_Private_Static_Void_ptr_Byte_Il2CppStructArray_1_Byte_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToSingle_Internal_Static_Single_Il2CppStructArray_1_Byte_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToDouble_Internal_Static_Double_Il2CppStructArray_1_Byte_Int32_0;

	static BitConverterLE()
	{
		Il2CppClassPointerStore<BitConverterLE>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Mono.Security", "BitConverterLE");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BitConverterLE>.NativeClassPtr);
		NativeMethodInfoPtr_GetUIntBytes_Private_Static_Il2CppStructArray_1_Byte_ptr_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitConverterLE>.NativeClassPtr, 100663579);
		NativeMethodInfoPtr_GetULongBytes_Private_Static_Il2CppStructArray_1_Byte_ptr_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitConverterLE>.NativeClassPtr, 100663580);
		NativeMethodInfoPtr_GetBytes_Internal_Static_Il2CppStructArray_1_Byte_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitConverterLE>.NativeClassPtr, 100663581);
		NativeMethodInfoPtr_GetBytes_Internal_Static_Il2CppStructArray_1_Byte_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitConverterLE>.NativeClassPtr, 100663582);
		NativeMethodInfoPtr_UIntFromBytes_Private_Static_Void_ptr_Byte_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitConverterLE>.NativeClassPtr, 100663583);
		NativeMethodInfoPtr_ULongFromBytes_Private_Static_Void_ptr_Byte_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitConverterLE>.NativeClassPtr, 100663584);
		NativeMethodInfoPtr_ToSingle_Internal_Static_Single_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitConverterLE>.NativeClassPtr, 100663585);
		NativeMethodInfoPtr_ToDouble_Internal_Static_Double_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitConverterLE>.NativeClassPtr, 100663586);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 698337, XrefRangeEnd = 698340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<byte> GetUIntBytes(byte* bytes)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)bytes;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetUIntBytes_Private_Static_Il2CppStructArray_1_Byte_ptr_Byte_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 698340, XrefRangeEnd = 698343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<byte> GetULongBytes(byte* bytes)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)bytes;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetULongBytes_Private_Static_Il2CppStructArray_1_Byte_ptr_Byte_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 698346, RefRangeEnd = 698347, XrefRangeStart = 698343, XrefRangeEnd = 698346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<byte> GetBytes(float value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBytes_Internal_Static_Il2CppStructArray_1_Byte_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 698350, RefRangeEnd = 698351, XrefRangeStart = 698347, XrefRangeEnd = 698350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<byte> GetBytes(double value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBytes_Internal_Static_Il2CppStructArray_1_Byte_Double_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
	}

	[CallerCount(0)]
	public unsafe static void UIntFromBytes(byte* dst, Il2CppStructArray<byte> src, int startIndex)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)dst;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)src);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &startIndex;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UIntFromBytes_Private_Static_Void_ptr_Byte_Il2CppStructArray_1_Byte_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe static void ULongFromBytes(byte* dst, Il2CppStructArray<byte> src, int startIndex)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)dst;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)src);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &startIndex;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ULongFromBytes_Private_Static_Void_ptr_Byte_Il2CppStructArray_1_Byte_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 698351, RefRangeEnd = 698352, XrefRangeStart = 698351, XrefRangeEnd = 698351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float ToSingle(Il2CppStructArray<byte> value, int startIndex)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &startIndex;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToSingle_Internal_Static_Single_Il2CppStructArray_1_Byte_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 698352, RefRangeEnd = 698353, XrefRangeStart = 698352, XrefRangeEnd = 698352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static double ToDouble(Il2CppStructArray<byte> value, int startIndex)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &startIndex;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToDouble_Internal_Static_Double_Il2CppStructArray_1_Byte_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(double*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public BitConverterLE(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
