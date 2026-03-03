using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppZXing.OneD;

public sealed class EANManufacturerOrgSupport : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_ranges;

	private static readonly System.IntPtr NativeFieldInfoPtr_countryIdentifiers;

	private static readonly System.IntPtr NativeMethodInfoPtr_lookupCountryIdentifier_Internal_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_add_Private_Void_Il2CppStructArray_1_Int32_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_initIfNeeded_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe List<Il2CppStructArray<int>> ranges
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ranges);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Il2CppStructArray<int>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ranges)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe List<string> countryIdentifiers
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_countryIdentifiers);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_countryIdentifiers)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static EANManufacturerOrgSupport()
	{
		Il2CppClassPointerStore<EANManufacturerOrgSupport>.NativeClassPtr = IL2CPP.GetIl2CppClass("zxing.unity.dll", "ZXing.OneD", "EANManufacturerOrgSupport");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EANManufacturerOrgSupport>.NativeClassPtr);
		NativeFieldInfoPtr_ranges = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EANManufacturerOrgSupport>.NativeClassPtr, "ranges");
		NativeFieldInfoPtr_countryIdentifiers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EANManufacturerOrgSupport>.NativeClassPtr, "countryIdentifiers");
		NativeMethodInfoPtr_lookupCountryIdentifier_Internal_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EANManufacturerOrgSupport>.NativeClassPtr, 100664111);
		NativeMethodInfoPtr_add_Private_Void_Il2CppStructArray_1_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EANManufacturerOrgSupport>.NativeClassPtr, 100664112);
		NativeMethodInfoPtr_initIfNeeded_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EANManufacturerOrgSupport>.NativeClassPtr, 100664113);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EANManufacturerOrgSupport>.NativeClassPtr, 100664114);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1421595, RefRangeEnd = 1421596, XrefRangeStart = 1421587, XrefRangeEnd = 1421595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string lookupCountryIdentifier(string productCode)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(productCode);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_lookupCountryIdentifier_Internal_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(106)]
	[CachedScanResults(RefRangeStart = 1421607, RefRangeEnd = 1421713, XrefRangeStart = 1421596, XrefRangeEnd = 1421607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void add(Il2CppStructArray<int> range, string id)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)range);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(id);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_add_Private_Void_Il2CppStructArray_1_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1422241, RefRangeEnd = 1422242, XrefRangeStart = 1421713, XrefRangeEnd = 1422241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void initIfNeeded()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_initIfNeeded_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1422257, RefRangeEnd = 1422258, XrefRangeStart = 1422242, XrefRangeEnd = 1422257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe EANManufacturerOrgSupport()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EANManufacturerOrgSupport>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public EANManufacturerOrgSupport(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
