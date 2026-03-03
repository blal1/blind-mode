using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppZXing.PDF417.Internal;

public static class PDF417ErrorCorrection : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_EC_COEFFICIENTS;

	private static readonly System.IntPtr NativeMethodInfoPtr_getErrorCorrectionCodewordCount_Internal_Static_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getErrorCorrectionLevel_Internal_Static_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getRecommendedMinimumErrorCorrectionLevel_Internal_Static_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_generateErrorCorrection_Internal_Static_String_String_Int32_0;

	public unsafe static Il2CppReferenceArray<Il2CppStructArray<int>> EC_COEFFICIENTS
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_EC_COEFFICIENTS, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppStructArray<int>>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_EC_COEFFICIENTS, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static PDF417ErrorCorrection()
	{
		Il2CppClassPointerStore<PDF417ErrorCorrection>.NativeClassPtr = IL2CPP.GetIl2CppClass("zxing.unity.dll", "ZXing.PDF417.Internal", "PDF417ErrorCorrection");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PDF417ErrorCorrection>.NativeClassPtr);
		NativeFieldInfoPtr_EC_COEFFICIENTS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PDF417ErrorCorrection>.NativeClassPtr, "EC_COEFFICIENTS");
		NativeMethodInfoPtr_getErrorCorrectionCodewordCount_Internal_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PDF417ErrorCorrection>.NativeClassPtr, 100663987);
		NativeMethodInfoPtr_getErrorCorrectionLevel_Internal_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PDF417ErrorCorrection>.NativeClassPtr, 100663988);
		NativeMethodInfoPtr_getRecommendedMinimumErrorCorrectionLevel_Internal_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PDF417ErrorCorrection>.NativeClassPtr, 100663989);
		NativeMethodInfoPtr_generateErrorCorrection_Internal_Static_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PDF417ErrorCorrection>.NativeClassPtr, 100663990);
	}

	[CallerCount(0)]
	public unsafe static int getErrorCorrectionCodewordCount(int errorCorrectionLevel)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&errorCorrectionLevel);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getErrorCorrectionCodewordCount_Internal_Static_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1419712, XrefRangeEnd = 1419713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int getErrorCorrectionLevel(int errorCorrectionLevel, int sourceCodeWords)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&errorCorrectionLevel);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &sourceCodeWords;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getErrorCorrectionLevel_Internal_Static_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1419713, RefRangeEnd = 1419715, XrefRangeStart = 1419713, XrefRangeEnd = 1419713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int getRecommendedMinimumErrorCorrectionLevel(int n)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&n);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getRecommendedMinimumErrorCorrectionLevel_Internal_Static_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1419747, RefRangeEnd = 1419748, XrefRangeStart = 1419715, XrefRangeEnd = 1419747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string generateErrorCorrection(string dataCodewords, int errorCorrectionLevel)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(dataCodewords);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &errorCorrectionLevel;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_generateErrorCorrection_Internal_Static_String_String_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	public PDF417ErrorCorrection(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
