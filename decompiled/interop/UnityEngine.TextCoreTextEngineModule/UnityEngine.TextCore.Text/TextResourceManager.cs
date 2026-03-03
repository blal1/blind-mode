using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.TextCore.Text;

public class TextResourceManager : Il2CppSystem.Object
{
	public sealed class FontAssetRef : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_nameHashCode;

		private static readonly System.IntPtr NativeFieldInfoPtr_familyNameHashCode;

		private static readonly System.IntPtr NativeFieldInfoPtr_styleNameHashCode;

		private static readonly System.IntPtr NativeFieldInfoPtr_familyNameAndStyleHashCode;

		private static readonly System.IntPtr NativeFieldInfoPtr_fontAsset;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_FontAsset_0;

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

		public unsafe FontAsset fontAsset
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fontAsset);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<FontAsset>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fontAsset)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		static FontAssetRef()
		{
			Il2CppClassPointerStore<FontAssetRef>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TextResourceManager>.NativeClassPtr, "FontAssetRef");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FontAssetRef>.NativeClassPtr);
			NativeFieldInfoPtr_nameHashCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAssetRef>.NativeClassPtr, "nameHashCode");
			NativeFieldInfoPtr_familyNameHashCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAssetRef>.NativeClassPtr, "familyNameHashCode");
			NativeFieldInfoPtr_styleNameHashCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAssetRef>.NativeClassPtr, "styleNameHashCode");
			NativeFieldInfoPtr_familyNameAndStyleHashCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAssetRef>.NativeClassPtr, "familyNameAndStyleHashCode");
			NativeFieldInfoPtr_fontAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAssetRef>.NativeClassPtr, "fontAsset");
			NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_FontAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAssetRef>.NativeClassPtr, 100664034);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FontAssetRef(int nameHashCode, int familyNameHashCode, int styleNameHashCode, FontAsset fontAsset)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FontAssetRef>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[4];
			*ptr = (nint)(&nameHashCode);
			*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &familyNameHashCode;
			*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &styleNameHashCode;
			*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fontAsset);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_FontAsset_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
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

	private static readonly System.IntPtr NativeFieldInfoPtr_s_FontAssetReferences;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_FontAssetNameReferenceLookup;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_FontAssetFamilyNameAndStyleReferenceLookup;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_FontAssetRemovalList;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_RegularStyleHashCode;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddFontAsset_Internal_Static_Void_FontAsset_0;

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

	public unsafe static Dictionary<int, FontAsset> s_FontAssetNameReferenceLookup
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_FontAssetNameReferenceLookup, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, FontAsset>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_FontAssetNameReferenceLookup, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Dictionary<long, FontAsset> s_FontAssetFamilyNameAndStyleReferenceLookup
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_FontAssetFamilyNameAndStyleReferenceLookup, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<long, FontAsset>>(intPtr2) : null;
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

	static TextResourceManager()
	{
		Il2CppClassPointerStore<TextResourceManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TextCoreTextEngineModule.dll", "UnityEngine.TextCore.Text", "TextResourceManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextResourceManager>.NativeClassPtr);
		NativeFieldInfoPtr_s_FontAssetReferences = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextResourceManager>.NativeClassPtr, "s_FontAssetReferences");
		NativeFieldInfoPtr_s_FontAssetNameReferenceLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextResourceManager>.NativeClassPtr, "s_FontAssetNameReferenceLookup");
		NativeFieldInfoPtr_s_FontAssetFamilyNameAndStyleReferenceLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextResourceManager>.NativeClassPtr, "s_FontAssetFamilyNameAndStyleReferenceLookup");
		NativeFieldInfoPtr_s_FontAssetRemovalList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextResourceManager>.NativeClassPtr, "s_FontAssetRemovalList");
		NativeFieldInfoPtr_k_RegularStyleHashCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextResourceManager>.NativeClassPtr, "k_RegularStyleHashCode");
		NativeMethodInfoPtr_AddFontAsset_Internal_Static_Void_FontAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextResourceManager>.NativeClassPtr, 100664032);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1284458, RefRangeEnd = 1284459, XrefRangeStart = 1284392, XrefRangeEnd = 1284458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void AddFontAsset(FontAsset fontAsset)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fontAsset);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddFontAsset_Internal_Static_Void_FontAsset_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public TextResourceManager(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public static void RemoveFontAsset(FontAsset fontAsset)
	{
		int instanceID = fontAsset.instanceID;
		if (s_FontAssetReferences.TryGetValue(instanceID, out var value))
		{
			s_FontAssetNameReferenceLookup.Remove(value.nameHashCode);
			s_FontAssetFamilyNameAndStyleReferenceLookup.Remove(value.familyNameAndStyleHashCode);
			s_FontAssetReferences.Remove(instanceID);
		}
	}

	public static bool TryGetFontAssetByName(int nameHashcode, out FontAsset fontAsset)
	{
		fontAsset = null;
		return s_FontAssetNameReferenceLookup.TryGetValue(nameHashcode, out fontAsset);
	}

	public static bool TryGetFontAssetByFamilyName(int familyNameHashCode, int styleNameHashCode, out FontAsset fontAsset)
	{
		fontAsset = null;
		if (styleNameHashCode == 0)
		{
			styleNameHashCode = k_RegularStyleHashCode;
		}
		long key = ((long)styleNameHashCode << 32) | (uint)familyNameHashCode;
		return s_FontAssetFamilyNameAndStyleReferenceLookup.TryGetValue(key, out fontAsset);
	}

	public static void ClearFontAssetGlyphCache()
	{
		RebuildFontAssetCache();
	}

	public unsafe static void RebuildFontAssetCache()
	{
		//IL_0092: Expected O, but got Ref
		//IL_0081: Expected O, but got Ref
		//IL_0016: Expected O, but got Ref
		//IL_001f: Expected O, but got Ref
		//IL_0063: Expected O, but got Ref
		Dictionary<int, FontAssetRef>.Enumerator enumerator = s_FontAssetReferences.GetEnumerator();
		try
		{
			while (((Dictionary<int, FontAssetRef>.Enumerator)(&enumerator)).MoveNext())
			{
				KeyValuePair<int, FontAssetRef> current = ((Dictionary<int, FontAssetRef>.Enumerator)(&enumerator)).Current;
				FontAssetRef value = ((KeyValuePair<int, FontAssetRef>)(&current)).Value;
				FontAsset fontAsset = value.fontAsset;
				if (fontAsset == null)
				{
					s_FontAssetNameReferenceLookup.Remove(value.nameHashCode);
					s_FontAssetFamilyNameAndStyleReferenceLookup.Remove(value.familyNameAndStyleHashCode);
					s_FontAssetRemovalList.Add(((KeyValuePair<int, FontAssetRef>)(&current)).Key);
				}
				else
				{
					fontAsset.InitializeCharacterLookupDictionary();
					fontAsset.AddSynthesizedCharactersAndFaceMetrics();
				}
			}
		}
		finally
		{
			((Il2CppSystem.IDisposable)(object)(Dictionary<int, FontAssetRef>.Enumerator)(&enumerator)).Dispose();
		}
		for (int i = 0; i < s_FontAssetRemovalList.Count; i++)
		{
			s_FontAssetReferences.Remove(s_FontAssetRemovalList[i]);
		}
		s_FontAssetRemovalList.Clear();
		TextEventManager.ON_FONT_PROPERTY_CHANGED(isChanged: true, null);
	}
}
