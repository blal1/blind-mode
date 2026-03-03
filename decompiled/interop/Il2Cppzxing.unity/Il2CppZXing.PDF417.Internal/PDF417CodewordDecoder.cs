using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppZXing.PDF417.Internal;

public static class PDF417CodewordDecoder : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_RATIOS_TABLE;

	private static readonly System.IntPtr NativeMethodInfoPtr_getDecodedValue_Public_Static_Int32_Il2CppStructArray_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_sampleBitCounts_Private_Static_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getDecodedCodewordValue_Private_Static_Int32_Il2CppStructArray_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getBitValue_Private_Static_Int32_Il2CppStructArray_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getClosestDecodedValue_Private_Static_Int32_Il2CppStructArray_1_Int32_0;

	public unsafe static Il2CppReferenceArray<Il2CppStructArray<float>> RATIOS_TABLE
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_RATIOS_TABLE, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppStructArray<float>>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_RATIOS_TABLE, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static PDF417CodewordDecoder()
	{
		Il2CppClassPointerStore<PDF417CodewordDecoder>.NativeClassPtr = IL2CPP.GetIl2CppClass("zxing.unity.dll", "ZXing.PDF417.Internal", "PDF417CodewordDecoder");
		NativeFieldInfoPtr_RATIOS_TABLE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PDF417CodewordDecoder>.NativeClassPtr, "RATIOS_TABLE");
		NativeMethodInfoPtr_getDecodedValue_Public_Static_Int32_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PDF417CodewordDecoder>.NativeClassPtr, 100663914);
		NativeMethodInfoPtr_sampleBitCounts_Private_Static_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PDF417CodewordDecoder>.NativeClassPtr, 100663915);
		NativeMethodInfoPtr_getDecodedCodewordValue_Private_Static_Int32_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PDF417CodewordDecoder>.NativeClassPtr, 100663916);
		NativeMethodInfoPtr_getBitValue_Private_Static_Int32_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PDF417CodewordDecoder>.NativeClassPtr, 100663917);
		NativeMethodInfoPtr_getClosestDecodedValue_Private_Static_Int32_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PDF417CodewordDecoder>.NativeClassPtr, 100663918);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1418813, XrefRangeEnd = 1418851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int getDecodedValue(Il2CppStructArray<int> moduleBitCount)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)moduleBitCount);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getDecodedValue_Public_Static_Int32_Il2CppStructArray_1_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1418851, XrefRangeEnd = 1418865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<int> sampleBitCounts(Il2CppStructArray<int> moduleBitCount)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)moduleBitCount);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_sampleBitCounts_Private_Static_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1418865, XrefRangeEnd = 1418878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int getDecodedCodewordValue(Il2CppStructArray<int> moduleBitCount)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)moduleBitCount);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getDecodedCodewordValue_Private_Static_Int32_Il2CppStructArray_1_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1418878, XrefRangeEnd = 1418881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int getBitValue(Il2CppStructArray<int> moduleBitCount)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)moduleBitCount);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getBitValue_Private_Static_Int32_Il2CppStructArray_1_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1418908, RefRangeEnd = 1418909, XrefRangeStart = 1418881, XrefRangeEnd = 1418908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int getClosestDecodedValue(Il2CppStructArray<int> moduleBitCount)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)moduleBitCount);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getClosestDecodedValue_Private_Static_Int32_Il2CppStructArray_1_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public PDF417CodewordDecoder(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
