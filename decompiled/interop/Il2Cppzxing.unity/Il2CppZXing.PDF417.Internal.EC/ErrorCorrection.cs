using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppZXing.PDF417.Internal.EC;

public sealed class ErrorCorrection : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_field;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_decode_Public_Boolean_Il2CppStructArray_1_Int32_Int32_Il2CppStructArray_1_Int32_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_runEuclideanAlgorithm_Private_Il2CppReferenceArray_1_ModulusPoly_ModulusPoly_ModulusPoly_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_findErrorLocations_Private_Il2CppStructArray_1_Int32_ModulusPoly_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_findErrorMagnitudes_Private_Il2CppStructArray_1_Int32_ModulusPoly_ModulusPoly_Il2CppStructArray_1_Int32_0;

	public unsafe ModulusGF field
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_field);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ModulusGF>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_field)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static ErrorCorrection()
	{
		Il2CppClassPointerStore<ErrorCorrection>.NativeClassPtr = IL2CPP.GetIl2CppClass("zxing.unity.dll", "ZXing.PDF417.Internal.EC", "ErrorCorrection");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ErrorCorrection>.NativeClassPtr);
		NativeFieldInfoPtr_field = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ErrorCorrection>.NativeClassPtr, "field");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ErrorCorrection>.NativeClassPtr, 100664010);
		NativeMethodInfoPtr_decode_Public_Boolean_Il2CppStructArray_1_Int32_Int32_Il2CppStructArray_1_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ErrorCorrection>.NativeClassPtr, 100664011);
		NativeMethodInfoPtr_runEuclideanAlgorithm_Private_Il2CppReferenceArray_1_ModulusPoly_ModulusPoly_ModulusPoly_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ErrorCorrection>.NativeClassPtr, 100664012);
		NativeMethodInfoPtr_findErrorLocations_Private_Il2CppStructArray_1_Int32_ModulusPoly_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ErrorCorrection>.NativeClassPtr, 100664013);
		NativeMethodInfoPtr_findErrorMagnitudes_Private_Il2CppStructArray_1_Int32_ModulusPoly_ModulusPoly_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ErrorCorrection>.NativeClassPtr, 100664014);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1420059, XrefRangeEnd = 1420065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ErrorCorrection()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ErrorCorrection>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1420093, RefRangeEnd = 1420095, XrefRangeStart = 1420065, XrefRangeEnd = 1420093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool decode(Il2CppStructArray<int> received, int numECCodewords, Il2CppStructArray<int> erasures, out int errorLocationsCount)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)received);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &numECCodewords;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)erasures);
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref errorLocationsCount);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_decode_Public_Boolean_Il2CppStructArray_1_Int32_Int32_Il2CppStructArray_1_Int32_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1420114, RefRangeEnd = 1420115, XrefRangeStart = 1420095, XrefRangeEnd = 1420114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppReferenceArray<ModulusPoly> runEuclideanAlgorithm(ModulusPoly a, ModulusPoly b, int R)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)a);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)b);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &R;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_runEuclideanAlgorithm_Private_Il2CppReferenceArray_1_ModulusPoly_ModulusPoly_ModulusPoly_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ModulusPoly>>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1420115, XrefRangeEnd = 1420121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppStructArray<int> findErrorLocations(ModulusPoly errorLocator)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)errorLocator);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_findErrorLocations_Private_Il2CppStructArray_1_Int32_ModulusPoly_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1420135, RefRangeEnd = 1420136, XrefRangeStart = 1420121, XrefRangeEnd = 1420135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppStructArray<int> findErrorMagnitudes(ModulusPoly errorEvaluator, ModulusPoly errorLocator, Il2CppStructArray<int> errorLocations)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)errorEvaluator);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)errorLocator);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)errorLocations);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_findErrorMagnitudes_Private_Il2CppStructArray_1_Int32_ModulusPoly_ModulusPoly_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
	}

	public ErrorCorrection(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
