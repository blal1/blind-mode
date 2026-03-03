using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem;

public static class Marvin : Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr__DefaultSeed_k__BackingField;

	private static readonly System.IntPtr NativeMethodInfoPtr_ComputeHash32_Public_Static_Int32_ReadOnlySpan_1_Byte_UInt64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ComputeHash32_Public_Static_Int32_byref_Byte_Int32_UInt64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Block_Private_Static_Void_byref_UInt32_byref_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__rotl_Private_Static_UInt32_UInt32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_DefaultSeed_Public_Static_get_UInt64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GenerateSeed_Private_Static_UInt64_0;

	public unsafe static ulong _DefaultSeed_k__BackingField
	{
		get
		{
			Unsafe.SkipInit(out ulong result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__DefaultSeed_k__BackingField, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__DefaultSeed_k__BackingField, (void*)(&value));
		}
	}

	public unsafe static ulong DefaultSeed
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 731721, XrefRangeEnd = 731725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_DefaultSeed_Public_Static_get_UInt64_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(ulong*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static Marvin()
	{
		Il2CppClassPointerStore<Marvin>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "Marvin");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Marvin>.NativeClassPtr);
		NativeFieldInfoPtr__DefaultSeed_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Marvin>.NativeClassPtr, "<DefaultSeed>k__BackingField");
		NativeMethodInfoPtr_ComputeHash32_Public_Static_Int32_ReadOnlySpan_1_Byte_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marvin>.NativeClassPtr, 100665342);
		NativeMethodInfoPtr_ComputeHash32_Public_Static_Int32_byref_Byte_Int32_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marvin>.NativeClassPtr, 100665343);
		NativeMethodInfoPtr_Block_Private_Static_Void_byref_UInt32_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marvin>.NativeClassPtr, 100665344);
		NativeMethodInfoPtr__rotl_Private_Static_UInt32_UInt32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marvin>.NativeClassPtr, 100665345);
		NativeMethodInfoPtr_get_DefaultSeed_Public_Static_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marvin>.NativeClassPtr, 100665346);
		NativeMethodInfoPtr_GenerateSeed_Private_Static_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marvin>.NativeClassPtr, 100665347);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 731667, XrefRangeEnd = 731675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int ComputeHash32(ReadOnlySpan<byte> data, ulong seed)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)data));
		*(ulong**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &seed;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ComputeHash32_Public_Static_Int32_ReadOnlySpan_1_Byte_UInt64_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 731715, RefRangeEnd = 731718, XrefRangeStart = 731675, XrefRangeEnd = 731715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int ComputeHash32(ref byte data, int count, ulong seed)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)Unsafe.AsPointer(ref data);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		*(ulong**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &seed;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ComputeHash32_Public_Static_Int32_byref_Byte_Int32_UInt64_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 731718, XrefRangeEnd = 731721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Block(ref uint rp0, ref uint rp1)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref rp0);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref rp1);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Block_Private_Static_Void_byref_UInt32_byref_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe static uint _rotl(uint value, int shift)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&value);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &shift;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__rotl_Private_Static_UInt32_UInt32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static ulong GenerateSeed()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GenerateSeed_Private_Static_UInt64_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(ulong*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public Marvin(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
