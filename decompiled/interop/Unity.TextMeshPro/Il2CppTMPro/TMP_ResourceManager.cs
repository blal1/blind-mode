using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppTMPro;

public class TMP_ResourceManager : Il2CppSystem.Object
{
	public sealed class FontAssetRef : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_nameHashCode;

		private static readonly System.IntPtr NativeFieldInfoPtr_familyNameHashCode;

		private static readonly System.IntPtr NativeFieldInfoPtr_styleNameHashCode;

		private static readonly System.IntPtr NativeFieldInfoPtr_familyNameAndStyleHashCode;

		private static readonly System.IntPtr NativeFieldInfoPtr_fontAsset;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_TMP_FontAsset_0;

		public unsafe int nameHashCode
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nameHashCode);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nameHashCode)) = value;
			}
		}

		public unsafe int familyNameHashCode
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_familyNameHashCode);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_familyNameHashCode)) = value;
			}
		}

		public unsafe int styleNameHashCode
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_styleNameHashCode);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_styleNameHashCode)) = value;
			}
		}

		public unsafe long familyNameAndStyleHashCode
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_familyNameAndStyleHashCode);
				return *(long*)num;
			}
			set
			{
				*(long*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_familyNameAndStyleHashCode)) = value;
			}
		}

		public unsafe TMP_FontAsset fontAsset
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fontAsset);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TMP_FontAsset>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fontAsset)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		static FontAssetRef()
		{
			Il2CppClassPointerStore<FontAssetRef>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TMP_ResourceManager>.NativeClassPtr, "FontAssetRef");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FontAssetRef>.NativeClassPtr);
			NativeFieldInfoPtr_nameHashCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAssetRef>.NativeClassPtr, "nameHashCode");
			NativeFieldInfoPtr_familyNameHashCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAssetRef>.NativeClassPtr, "familyNameHashCode");
			NativeFieldInfoPtr_styleNameHashCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAssetRef>.NativeClassPtr, "styleNameHashCode");
			NativeFieldInfoPtr_familyNameAndStyleHashCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAssetRef>.NativeClassPtr, "familyNameAndStyleHashCode");
			NativeFieldInfoPtr_fontAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAssetRef>.NativeClassPtr, "fontAsset");
			NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_TMP_FontAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAssetRef>.NativeClassPtr, 100664393);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128185, XrefRangeEnd = 1128186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FontAssetRef(int nameHashCode, int familyNameHashCode, int styleNameHashCode, TMP_FontAsset fontAsset)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FontAssetRef>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[4];
			*ptr = (nint)(&nameHashCode);
			*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &familyNameHashCode;
			*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &styleNameHashCode;
			*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fontAsset);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_TMP_FontAsset_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public FontAssetRef(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public FontAssetRef()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FontAssetRef>.NativeClassPtr))
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_s_TextSettings;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_FontAssetReferences;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_FontAssetNameReferenceLookup;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_FontAssetFamilyNameAndStyleReferenceLookup;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_FontAssetRemovalList;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_RegularStyleHashCode;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTextSettings_Internal_Static_TMP_Settings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddFontAsset_Public_Static_Void_TMP_FontAsset_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveFontAsset_Public_Static_Void_TMP_FontAsset_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryGetFontAssetByName_Internal_Static_Boolean_Int32_byref_TMP_FontAsset_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryGetFontAssetByFamilyName_Internal_Static_Boolean_Int32_Int32_byref_TMP_FontAsset_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearFontAssetGlyphCache_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RebuildFontAssetCache_Internal_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static TMP_Settings s_TextSettings
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_TextSettings, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<TMP_Settings>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_TextSettings, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Dictionary<int, FontAssetRef> s_FontAssetReferences
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_FontAssetReferences, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, FontAssetRef>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_FontAssetReferences, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Dictionary<int, TMP_FontAsset> s_FontAssetNameReferenceLookup
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_FontAssetNameReferenceLookup, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, TMP_FontAsset>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_FontAssetNameReferenceLookup, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Dictionary<long, TMP_FontAsset> s_FontAssetFamilyNameAndStyleReferenceLookup
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_FontAssetFamilyNameAndStyleReferenceLookup, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<long, TMP_FontAsset>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_FontAssetFamilyNameAndStyleReferenceLookup, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static List<int> s_FontAssetRemovalList
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_FontAssetRemovalList, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_FontAssetRemovalList, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static int k_RegularStyleHashCode
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_RegularStyleHashCode, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_RegularStyleHashCode, (void*)(&value));
		}
	}

	static TMP_ResourceManager()
	{
		Il2CppClassPointerStore<TMP_ResourceManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TMP_ResourceManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_ResourceManager>.NativeClassPtr);
		NativeFieldInfoPtr_s_TextSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_ResourceManager>.NativeClassPtr, "s_TextSettings");
		NativeFieldInfoPtr_s_FontAssetReferences = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_ResourceManager>.NativeClassPtr, "s_FontAssetReferences");
		NativeFieldInfoPtr_s_FontAssetNameReferenceLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_ResourceManager>.NativeClassPtr, "s_FontAssetNameReferenceLookup");
		NativeFieldInfoPtr_s_FontAssetFamilyNameAndStyleReferenceLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_ResourceManager>.NativeClassPtr, "s_FontAssetFamilyNameAndStyleReferenceLookup");
		NativeFieldInfoPtr_s_FontAssetRemovalList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_ResourceManager>.NativeClassPtr, "s_FontAssetRemovalList");
		NativeFieldInfoPtr_k_RegularStyleHashCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_ResourceManager>.NativeClassPtr, "k_RegularStyleHashCode");
		NativeMethodInfoPtr_GetTextSettings_Internal_Static_TMP_Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_ResourceManager>.NativeClassPtr, 100664384);
		NativeMethodInfoPtr_AddFontAsset_Public_Static_Void_TMP_FontAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_ResourceManager>.NativeClassPtr, 100664385);
		NativeMethodInfoPtr_RemoveFontAsset_Public_Static_Void_TMP_FontAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_ResourceManager>.NativeClassPtr, 100664386);
		NativeMethodInfoPtr_TryGetFontAssetByName_Internal_Static_Boolean_Int32_byref_TMP_FontAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_ResourceManager>.NativeClassPtr, 100664387);
		NativeMethodInfoPtr_TryGetFontAssetByFamilyName_Internal_Static_Boolean_Int32_Int32_byref_TMP_FontAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_ResourceManager>.NativeClassPtr, 100664388);
		NativeMethodInfoPtr_ClearFontAssetGlyphCache_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_ResourceManager>.NativeClassPtr, 100664389);
		NativeMethodInfoPtr_RebuildFontAssetCache_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_ResourceManager>.NativeClassPtr, 100664390);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_ResourceManager>.NativeClassPtr, 100664391);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128186, XrefRangeEnd = 1128207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static TMP_Settings GetTextSettings()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTextSettings_Internal_Static_TMP_Settings_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<TMP_Settings>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1128273, RefRangeEnd = 1128274, XrefRangeStart = 1128207, XrefRangeEnd = 1128273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void AddFontAsset(TMP_FontAsset fontAsset)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fontAsset);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddFontAsset_Public_Static_Void_TMP_FontAsset_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1128296, RefRangeEnd = 1128297, XrefRangeStart = 1128274, XrefRangeEnd = 1128296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RemoveFontAsset(TMP_FontAsset fontAsset)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fontAsset);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveFontAsset_Public_Static_Void_TMP_FontAsset_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128297, XrefRangeEnd = 1128350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool TryGetFontAssetByName(int nameHashcode, out TMP_FontAsset fontAsset)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&nameHashcode);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryGetFontAssetByName_Internal_Static_Boolean_Int32_byref_TMP_FontAsset_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num3 = num2;
		fontAsset = ((num3 == 0) ? null : new TMP_FontAsset(num3));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128350, XrefRangeEnd = 1128361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool TryGetFontAssetByFamilyName(int familyNameHashCode, int styleNameHashCode, out TMP_FontAsset fontAsset)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&familyNameHashCode);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &styleNameHashCode;
		byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryGetFontAssetByFamilyName_Internal_Static_Boolean_Int32_Int32_byref_TMP_FontAsset_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num3 = num2;
		fontAsset = ((num3 == 0) ? null : new TMP_FontAsset(num3));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1128361, XrefRangeEnd = 1128365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ClearFontAssetGlyphCache()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearFontAssetGlyphCache_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1128426, RefRangeEnd = 1128427, XrefRangeStart = 1128365, XrefRangeEnd = 1128426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RebuildFontAssetCache()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RebuildFontAssetCache_Internal_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1950)]
	[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TMP_ResourceManager()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_ResourceManager>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public TMP_ResourceManager(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
