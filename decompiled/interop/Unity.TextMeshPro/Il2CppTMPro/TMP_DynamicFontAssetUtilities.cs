using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppTMPro;

public class TMP_DynamicFontAssetUtilities : Il2CppSystem.Object
{
	public sealed class FontReference : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_familyName;

		private static readonly System.IntPtr NativeFieldInfoPtr_styleName;

		private static readonly System.IntPtr NativeFieldInfoPtr_faceIndex;

		private static readonly System.IntPtr NativeFieldInfoPtr_filePath;

		private static readonly System.IntPtr NativeFieldInfoPtr_hashCode;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_Int32_0;

		public unsafe string familyName
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_familyName);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_familyName)), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		public unsafe string styleName
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_styleName);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_styleName)), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		public unsafe int faceIndex
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_faceIndex);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_faceIndex)) = value;
			}
		}

		public unsafe string filePath
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_filePath);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_filePath)), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		public unsafe ulong hashCode
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hashCode);
				return *(ulong*)num;
			}
			set
			{
				*(ulong*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hashCode)) = value;
			}
		}

		static FontReference()
		{
			Il2CppClassPointerStore<FontReference>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TMP_DynamicFontAssetUtilities>.NativeClassPtr, "FontReference");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FontReference>.NativeClassPtr);
			NativeFieldInfoPtr_familyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontReference>.NativeClassPtr, "familyName");
			NativeFieldInfoPtr_styleName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontReference>.NativeClassPtr, "styleName");
			NativeFieldInfoPtr_faceIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontReference>.NativeClassPtr, "faceIndex");
			NativeFieldInfoPtr_filePath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontReference>.NativeClassPtr, "filePath");
			NativeFieldInfoPtr_hashCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontReference>.NativeClassPtr, "hashCode");
			NativeMethodInfoPtr__ctor_Public_Void_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontReference>.NativeClassPtr, 100663833);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1121627, RefRangeEnd = 1121628, XrefRangeStart = 1121604, XrefRangeEnd = 1121627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FontReference(string fontFilePath, string faceNameAndStyle, int index)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FontReference>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[3];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(fontFilePath);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(faceNameAndStyle);
			*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_String_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public FontReference(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public FontReference()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FontReference>.NativeClassPtr))
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_s_Instance;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_SystemFontLookup;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_SystemFontPaths;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_RegularStyleNameHashCode;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitializeSystemFontReferenceCache_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryGetSystemFontReference_Public_Static_Boolean_String_byref_FontReference_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryGetSystemFontReference_Public_Static_Boolean_String_String_byref_FontReference_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryGetSystemFontReferenceInternal_Private_Boolean_String_String_byref_FontReference_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static TMP_DynamicFontAssetUtilities s_Instance
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_Instance, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<TMP_DynamicFontAssetUtilities>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_Instance, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Dictionary<ulong, FontReference> s_SystemFontLookup
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_s_SystemFontLookup);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<ulong, FontReference>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_s_SystemFontLookup)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppStringArray s_SystemFontPaths
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_s_SystemFontPaths);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_s_SystemFontPaths)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe uint s_RegularStyleNameHashCode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_s_RegularStyleNameHashCode);
			return *(uint*)num;
		}
		set
		{
			*(uint*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_s_RegularStyleNameHashCode)) = value;
		}
	}

	static TMP_DynamicFontAssetUtilities()
	{
		Il2CppClassPointerStore<TMP_DynamicFontAssetUtilities>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TMP_DynamicFontAssetUtilities");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_DynamicFontAssetUtilities>.NativeClassPtr);
		NativeFieldInfoPtr_s_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_DynamicFontAssetUtilities>.NativeClassPtr, "s_Instance");
		NativeFieldInfoPtr_s_SystemFontLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_DynamicFontAssetUtilities>.NativeClassPtr, "s_SystemFontLookup");
		NativeFieldInfoPtr_s_SystemFontPaths = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_DynamicFontAssetUtilities>.NativeClassPtr, "s_SystemFontPaths");
		NativeFieldInfoPtr_s_RegularStyleNameHashCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_DynamicFontAssetUtilities>.NativeClassPtr, "s_RegularStyleNameHashCode");
		NativeMethodInfoPtr_InitializeSystemFontReferenceCache_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_DynamicFontAssetUtilities>.NativeClassPtr, 100663827);
		NativeMethodInfoPtr_TryGetSystemFontReference_Public_Static_Boolean_String_byref_FontReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_DynamicFontAssetUtilities>.NativeClassPtr, 100663828);
		NativeMethodInfoPtr_TryGetSystemFontReference_Public_Static_Boolean_String_String_byref_FontReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_DynamicFontAssetUtilities>.NativeClassPtr, 100663829);
		NativeMethodInfoPtr_TryGetSystemFontReferenceInternal_Private_Boolean_String_String_byref_FontReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_DynamicFontAssetUtilities>.NativeClassPtr, 100663830);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_DynamicFontAssetUtilities>.NativeClassPtr, 100663831);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1121718, RefRangeEnd = 1121719, XrefRangeStart = 1121628, XrefRangeEnd = 1121718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InitializeSystemFontReferenceCache()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitializeSystemFontReferenceCache_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1121719, XrefRangeEnd = 1121724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool TryGetSystemFontReference(string familyName, out FontReference fontRef)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(familyName);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryGetSystemFontReference_Public_Static_Boolean_String_byref_FontReference_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num3 = num2;
		fontRef = ((num3 == 0) ? null : new FontReference(num3));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1121724, XrefRangeEnd = 1121729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool TryGetSystemFontReference(string familyName, string styleName, out FontReference fontRef)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(familyName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(styleName);
		byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryGetSystemFontReference_Public_Static_Boolean_String_String_byref_FontReference_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num3 = num2;
		fontRef = ((num3 == 0) ? null : new FontReference(num3));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1121762, RefRangeEnd = 1121764, XrefRangeStart = 1121729, XrefRangeEnd = 1121762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool TryGetSystemFontReferenceInternal(string familyName, string styleName, out FontReference fontRef)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(familyName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(styleName);
		byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryGetSystemFontReferenceInternal_Private_Boolean_String_String_byref_FontReference_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num3 = num2;
		fontRef = ((num3 == 0) ? null : new FontReference(num3));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1121764, XrefRangeEnd = 1121765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TMP_DynamicFontAssetUtilities()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_DynamicFontAssetUtilities>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public TMP_DynamicFontAssetUtilities(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
