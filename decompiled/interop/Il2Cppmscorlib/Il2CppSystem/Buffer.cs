using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Reflection;

namespace Il2CppSystem;

public static class Buffer : Object
{
	private sealed class MethodInfoStoreGeneric_Memmove_Internal_Static_Void_byref_T_byref_T_UInt64_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_Memmove_Internal_Static_Void_byref_T_byref_T_UInt64_0, Il2CppClassPointerStore<Buffer>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[1] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalBlockCopy_Internal_Static_Boolean_Array_Int32_Array_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IndexOfByte_Internal_Static_Int32_ptr_Byte_Byte_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ByteLength_Private_Static_Int32_Array_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ZeroMemory_Internal_Static_Void_ptr_Byte_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Memcpy_Internal_Static_Void_ptr_Byte_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalMemcpy_Internal_Static_Void_ptr_Byte_ptr_Byte_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ByteLength_Public_Static_Int32_Array_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BlockCopy_Public_Static_Void_Array_Int32_Array_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MemoryCopy_Public_Static_Void_ptr_Void_ptr_Void_Int64_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_memcpy4_Internal_Static_Void_ptr_Byte_ptr_Byte_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_memcpy2_Internal_Static_Void_ptr_Byte_ptr_Byte_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_memcpy1_Private_Static_Void_ptr_Byte_ptr_Byte_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Memcpy_Internal_Static_Void_ptr_Byte_ptr_Byte_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Memmove_Internal_Static_Void_ptr_Byte_ptr_Byte_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Memmove_Internal_Static_Void_byref_T_byref_T_UInt64_0;

	static Buffer()
	{
		Il2CppClassPointerStore<Buffer>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "Buffer");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Buffer>.NativeClassPtr);
		NativeMethodInfoPtr_InternalBlockCopy_Internal_Static_Boolean_Array_Int32_Array_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Buffer>.NativeClassPtr, 100666634);
		NativeMethodInfoPtr_IndexOfByte_Internal_Static_Int32_ptr_Byte_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Buffer>.NativeClassPtr, 100666635);
		NativeMethodInfoPtr__ByteLength_Private_Static_Int32_Array_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Buffer>.NativeClassPtr, 100666636);
		NativeMethodInfoPtr_ZeroMemory_Internal_Static_Void_ptr_Byte_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Buffer>.NativeClassPtr, 100666637);
		NativeMethodInfoPtr_Memcpy_Internal_Static_Void_ptr_Byte_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Buffer>.NativeClassPtr, 100666638);
		NativeMethodInfoPtr_InternalMemcpy_Internal_Static_Void_ptr_Byte_ptr_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Buffer>.NativeClassPtr, 100666639);
		NativeMethodInfoPtr_ByteLength_Public_Static_Int32_Array_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Buffer>.NativeClassPtr, 100666640);
		NativeMethodInfoPtr_BlockCopy_Public_Static_Void_Array_Int32_Array_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Buffer>.NativeClassPtr, 100666641);
		NativeMethodInfoPtr_MemoryCopy_Public_Static_Void_ptr_Void_ptr_Void_Int64_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Buffer>.NativeClassPtr, 100666642);
		NativeMethodInfoPtr_memcpy4_Internal_Static_Void_ptr_Byte_ptr_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Buffer>.NativeClassPtr, 100666643);
		NativeMethodInfoPtr_memcpy2_Internal_Static_Void_ptr_Byte_ptr_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Buffer>.NativeClassPtr, 100666644);
		NativeMethodInfoPtr_memcpy1_Private_Static_Void_ptr_Byte_ptr_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Buffer>.NativeClassPtr, 100666645);
		NativeMethodInfoPtr_Memcpy_Internal_Static_Void_ptr_Byte_ptr_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Buffer>.NativeClassPtr, 100666646);
		NativeMethodInfoPtr_Memmove_Internal_Static_Void_ptr_Byte_ptr_Byte_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Buffer>.NativeClassPtr, 100666647);
		NativeMethodInfoPtr_Memmove_Internal_Static_Void_byref_T_byref_T_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Buffer>.NativeClassPtr, 100666648);
	}

	[CallerCount(41)]
	[CachedScanResults(RefRangeStart = 753840, RefRangeEnd = 753881, XrefRangeStart = 753839, XrefRangeEnd = 753840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool InternalBlockCopy(Array src, int srcOffsetBytes, Array dst, int dstOffsetBytes, int byteCount)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)src);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &srcOffsetBytes;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dst);
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &dstOffsetBytes;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &byteCount;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalBlockCopy_Internal_Static_Boolean_Array_Int32_Array_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 753881, RefRangeEnd = 753882, XrefRangeStart = 753881, XrefRangeEnd = 753881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int IndexOfByte(byte* src, byte value, int index, int count)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)src;
		*(byte**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IndexOfByte_Internal_Static_Int32_ptr_Byte_Byte_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 753882, XrefRangeEnd = 753883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int _ByteLength(Array array)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)array);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ByteLength_Private_Static_Int32_Array_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 753883, RefRangeEnd = 753886, XrefRangeStart = 753883, XrefRangeEnd = 753883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ZeroMemory(byte* src, long len)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)src;
		*(long**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &len;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ZeroMemory_Internal_Static_Void_ptr_Byte_Int64_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 753888, RefRangeEnd = 753890, XrefRangeStart = 753886, XrefRangeEnd = 753888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Memcpy(byte* pDest, int destIndex, Il2CppStructArray<byte> src, int srcIndex, int len)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)pDest;
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &destIndex;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)src);
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &srcIndex;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &len;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Memcpy_Internal_Static_Void_ptr_Byte_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 753890, XrefRangeEnd = 753891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InternalMemcpy(byte* dest, byte* src, int count)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)dest;
		*(byte**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = src;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalMemcpy_Internal_Static_Void_ptr_Byte_ptr_Byte_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 753892, RefRangeEnd = 753894, XrefRangeStart = 753891, XrefRangeEnd = 753892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int ByteLength(Array array)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)array);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ByteLength_Public_Static_Int32_Array_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(225)]
	[CachedScanResults(RefRangeStart = 753897, RefRangeEnd = 754122, XrefRangeStart = 753894, XrefRangeEnd = 753897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void BlockCopy(Array src, int srcOffset, Array dst, int dstOffset, int count)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)src);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &srcOffset;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dst);
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &dstOffset;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BlockCopy_Public_Static_Void_Array_Int32_Array_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 754128, RefRangeEnd = 754130, XrefRangeStart = 754122, XrefRangeEnd = 754128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void MemoryCopy(void* source, void* destination, long destinationSizeInBytes, long sourceBytesToCopy)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)source;
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = destination;
		*(long**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &destinationSizeInBytes;
		*(long**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &sourceBytesToCopy;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MemoryCopy_Public_Static_Void_ptr_Void_ptr_Void_Int64_Int64_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe static void memcpy4(byte* dest, byte* src, int size)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)dest;
		*(byte**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = src;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &size;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_memcpy4_Internal_Static_Void_ptr_Byte_ptr_Byte_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe static void memcpy2(byte* dest, byte* src, int size)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)dest;
		*(byte**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = src;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &size;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_memcpy2_Internal_Static_Void_ptr_Byte_ptr_Byte_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe static void memcpy1(byte* dest, byte* src, int size)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)dest;
		*(byte**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = src;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &size;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_memcpy1_Private_Static_Void_ptr_Byte_ptr_Byte_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(20)]
	[CachedScanResults(RefRangeStart = 754130, RefRangeEnd = 754150, XrefRangeStart = 754130, XrefRangeEnd = 754130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Memcpy(byte* dest, byte* src, int len)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)dest;
		*(byte**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = src;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &len;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Memcpy_Internal_Static_Void_ptr_Byte_ptr_Byte_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(45)]
	[CachedScanResults(RefRangeStart = 754152, RefRangeEnd = 754197, XrefRangeStart = 754150, XrefRangeEnd = 754152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 754202, RefRangeEnd = 754208, XrefRangeStart = 754197, XrefRangeEnd = 754202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Memmove<T>(ref T destination, ref T source, ulong elementCount)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)Unsafe.As<T, object>(ref destination));
		*ptr = (nint)(&intPtr);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)Unsafe.As<T, object>(ref source));
		*(System.IntPtr**)num = &intPtr2;
		*(ulong**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &elementCount;
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr4 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_Memmove_Internal_Static_Void_byref_T_byref_T_UInt64_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr5 = intPtr;
		Unsafe.As<T, object>(ref destination) = ((intPtr5 == (System.IntPtr)0) ? ((T)null) : IL2CPP.PointerToValueGeneric<T>(intPtr5, false, false));
		System.IntPtr intPtr6 = intPtr2;
		Unsafe.As<T, object>(ref source) = ((intPtr6 == (System.IntPtr)0) ? ((T)null) : IL2CPP.PointerToValueGeneric<T>(intPtr6, false, false));
	}

	public Buffer(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
