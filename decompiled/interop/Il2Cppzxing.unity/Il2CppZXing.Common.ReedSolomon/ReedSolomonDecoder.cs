using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppZXing.Common.ReedSolomon;

public sealed class ReedSolomonDecoder : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_field;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_GenericGF_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_decode_Public_Boolean_Il2CppStructArray_1_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_runEuclideanAlgorithm_Internal_Il2CppReferenceArray_1_GenericGFPoly_GenericGFPoly_GenericGFPoly_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_findErrorLocations_Private_Il2CppStructArray_1_Int32_GenericGFPoly_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_findErrorMagnitudes_Private_Il2CppStructArray_1_Int32_GenericGFPoly_Il2CppStructArray_1_Int32_0;

	public unsafe GenericGF field
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_field);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GenericGF>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_field)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static ReedSolomonDecoder()
	{
		Il2CppClassPointerStore<ReedSolomonDecoder>.NativeClassPtr = IL2CPP.GetIl2CppClass("zxing.unity.dll", "ZXing.Common.ReedSolomon", "ReedSolomonDecoder");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReedSolomonDecoder>.NativeClassPtr);
		NativeFieldInfoPtr_field = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReedSolomonDecoder>.NativeClassPtr, "field");
		NativeMethodInfoPtr__ctor_Public_Void_GenericGF_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReedSolomonDecoder>.NativeClassPtr, 100664816);
		NativeMethodInfoPtr_decode_Public_Boolean_Il2CppStructArray_1_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReedSolomonDecoder>.NativeClassPtr, 100664817);
		NativeMethodInfoPtr_runEuclideanAlgorithm_Internal_Il2CppReferenceArray_1_GenericGFPoly_GenericGFPoly_GenericGFPoly_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReedSolomonDecoder>.NativeClassPtr, 100664818);
		NativeMethodInfoPtr_findErrorLocations_Private_Il2CppStructArray_1_Int32_GenericGFPoly_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReedSolomonDecoder>.NativeClassPtr, 100664819);
		NativeMethodInfoPtr_findErrorMagnitudes_Private_Il2CppStructArray_1_Int32_GenericGFPoly_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReedSolomonDecoder>.NativeClassPtr, 100664820);
	}

	[CallerCount(215)]
	[CachedScanResults(RefRangeStart = 79185, RefRangeEnd = 79400, XrefRangeStart = 79185, XrefRangeEnd = 79400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ReedSolomonDecoder(GenericGF field)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReedSolomonDecoder>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)field);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_GenericGF_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(12)]
	[CachedScanResults(RefRangeStart = 1429677, RefRangeEnd = 1429689, XrefRangeStart = 1429650, XrefRangeEnd = 1429677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool decode(Il2CppStructArray<int> received, int twoS)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)received);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &twoS;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_decode_Public_Boolean_Il2CppStructArray_1_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1429707, RefRangeEnd = 1429708, XrefRangeStart = 1429689, XrefRangeEnd = 1429707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppReferenceArray<GenericGFPoly> runEuclideanAlgorithm(GenericGFPoly a, GenericGFPoly b, int R)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)a);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)b);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &R;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_runEuclideanAlgorithm_Internal_Il2CppReferenceArray_1_GenericGFPoly_GenericGFPoly_GenericGFPoly_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GenericGFPoly>>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1429708, XrefRangeEnd = 1429714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppStructArray<int> findErrorLocations(GenericGFPoly errorLocator)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)errorLocator);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_findErrorLocations_Private_Il2CppStructArray_1_Int32_GenericGFPoly_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1429725, RefRangeEnd = 1429726, XrefRangeStart = 1429714, XrefRangeEnd = 1429725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppStructArray<int> findErrorMagnitudes(GenericGFPoly errorEvaluator, Il2CppStructArray<int> errorLocations)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)errorEvaluator);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)errorLocations);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_findErrorMagnitudes_Private_Il2CppStructArray_1_Int32_GenericGFPoly_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
	}

	public ReedSolomonDecoder(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
