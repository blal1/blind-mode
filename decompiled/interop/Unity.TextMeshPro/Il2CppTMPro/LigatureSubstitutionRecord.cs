using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppTMPro;

[System.Serializable]
public sealed class LigatureSubstitutionRecord : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_ComponentGlyphIDs;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_LigatureGlyphID;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_componentGlyphIDs_Public_get_Il2CppStructArray_1_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_componentGlyphIDs_Public_set_Void_Il2CppStructArray_1_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_ligatureGlyphID_Public_get_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_ligatureGlyphID_Public_set_Void_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_LigatureSubstitutionRecord_LigatureSubstitutionRecord_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_LigatureSubstitutionRecord_LigatureSubstitutionRecord_0;

	public unsafe Il2CppStructArray<uint> m_ComponentGlyphIDs
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ComponentGlyphIDs);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ComponentGlyphIDs)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe uint m_LigatureGlyphID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LigatureGlyphID);
			return *(uint*)num;
		}
		set
		{
			*(uint*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LigatureGlyphID)) = value;
		}
	}

	public unsafe Il2CppStructArray<uint> componentGlyphIDs
	{
		[CallerCount(98)]
		[CachedScanResults(RefRangeStart = 110111, RefRangeEnd = 110209, XrefRangeStart = 110111, XrefRangeEnd = 110209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_componentGlyphIDs_Public_get_Il2CppStructArray_1_UInt32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
		}
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 110106, RefRangeEnd = 110111, XrefRangeStart = 110106, XrefRangeEnd = 110111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_componentGlyphIDs_Public_set_Void_Il2CppStructArray_1_UInt32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe uint ligatureGlyphID
	{
		[CallerCount(24)]
		[CachedScanResults(RefRangeStart = 719678, RefRangeEnd = 719702, XrefRangeStart = 719678, XrefRangeEnd = 719702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ligatureGlyphID_Public_get_UInt32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 765810, RefRangeEnd = 765814, XrefRangeStart = 765810, XrefRangeEnd = 765814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_ligatureGlyphID_Public_set_Void_UInt32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	static LigatureSubstitutionRecord()
	{
		Il2CppClassPointerStore<LigatureSubstitutionRecord>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "LigatureSubstitutionRecord");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LigatureSubstitutionRecord>.NativeClassPtr);
		NativeFieldInfoPtr_m_ComponentGlyphIDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LigatureSubstitutionRecord>.NativeClassPtr, "m_ComponentGlyphIDs");
		NativeFieldInfoPtr_m_LigatureGlyphID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LigatureSubstitutionRecord>.NativeClassPtr, "m_LigatureGlyphID");
		NativeMethodInfoPtr_get_componentGlyphIDs_Public_get_Il2CppStructArray_1_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LigatureSubstitutionRecord>.NativeClassPtr, 100663344);
		NativeMethodInfoPtr_set_componentGlyphIDs_Public_set_Void_Il2CppStructArray_1_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LigatureSubstitutionRecord>.NativeClassPtr, 100663345);
		NativeMethodInfoPtr_get_ligatureGlyphID_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LigatureSubstitutionRecord>.NativeClassPtr, 100663346);
		NativeMethodInfoPtr_set_ligatureGlyphID_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LigatureSubstitutionRecord>.NativeClassPtr, 100663347);
		NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_LigatureSubstitutionRecord_LigatureSubstitutionRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LigatureSubstitutionRecord>.NativeClassPtr, 100663348);
		NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_LigatureSubstitutionRecord_LigatureSubstitutionRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LigatureSubstitutionRecord>.NativeClassPtr, 100663349);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1113956, RefRangeEnd = 1113957, XrefRangeStart = 1113956, XrefRangeEnd = 1113956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool operator ==(LigatureSubstitutionRecord lhs, LigatureSubstitutionRecord rhs)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)lhs));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)rhs));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_LigatureSubstitutionRecord_LigatureSubstitutionRecord_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static bool operator !=(LigatureSubstitutionRecord lhs, LigatureSubstitutionRecord rhs)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)lhs));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)rhs));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_LigatureSubstitutionRecord_LigatureSubstitutionRecord_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public LigatureSubstitutionRecord(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public LigatureSubstitutionRecord()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LigatureSubstitutionRecord>.NativeClassPtr))
	{
	}
}
