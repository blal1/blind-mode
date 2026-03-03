using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace Il2CppTMPro;

[System.Serializable]
public sealed class FontAssetCreationSettings : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_sourceFontFileName;

	private static readonly System.IntPtr NativeFieldInfoPtr_sourceFontFileGUID;

	private static readonly System.IntPtr NativeFieldInfoPtr_faceIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_pointSizeSamplingMode;

	private static readonly System.IntPtr NativeFieldInfoPtr_pointSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_padding;

	private static readonly System.IntPtr NativeFieldInfoPtr_paddingMode;

	private static readonly System.IntPtr NativeFieldInfoPtr_packingMode;

	private static readonly System.IntPtr NativeFieldInfoPtr_atlasWidth;

	private static readonly System.IntPtr NativeFieldInfoPtr_atlasHeight;

	private static readonly System.IntPtr NativeFieldInfoPtr_characterSetSelectionMode;

	private static readonly System.IntPtr NativeFieldInfoPtr_characterSequence;

	private static readonly System.IntPtr NativeFieldInfoPtr_referencedFontAssetGUID;

	private static readonly System.IntPtr NativeFieldInfoPtr_referencedTextAssetGUID;

	private static readonly System.IntPtr NativeFieldInfoPtr_fontStyle;

	private static readonly System.IntPtr NativeFieldInfoPtr_fontStyleModifier;

	private static readonly System.IntPtr NativeFieldInfoPtr_renderMode;

	private static readonly System.IntPtr NativeFieldInfoPtr_includeFontFeatures;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_Int32_Int32_Int32_Int32_Int32_Int32_Int32_String_Int32_0;

	public unsafe string sourceFontFileName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sourceFontFileName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sourceFontFileName)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string sourceFontFileGUID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sourceFontFileGUID);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sourceFontFileGUID)), IL2CPP.ManagedStringToIl2Cpp(value));
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

	public unsafe int pointSizeSamplingMode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pointSizeSamplingMode);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pointSizeSamplingMode)) = value;
		}
	}

	public unsafe int pointSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pointSize);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pointSize)) = value;
		}
	}

	public unsafe int padding
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_padding);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_padding)) = value;
		}
	}

	public unsafe int paddingMode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_paddingMode);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_paddingMode)) = value;
		}
	}

	public unsafe int packingMode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_packingMode);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_packingMode)) = value;
		}
	}

	public unsafe int atlasWidth
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_atlasWidth);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_atlasWidth)) = value;
		}
	}

	public unsafe int atlasHeight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_atlasHeight);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_atlasHeight)) = value;
		}
	}

	public unsafe int characterSetSelectionMode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_characterSetSelectionMode);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_characterSetSelectionMode)) = value;
		}
	}

	public unsafe string characterSequence
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_characterSequence);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_characterSequence)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string referencedFontAssetGUID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_referencedFontAssetGUID);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_referencedFontAssetGUID)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string referencedTextAssetGUID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_referencedTextAssetGUID);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_referencedTextAssetGUID)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe int fontStyle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fontStyle);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fontStyle)) = value;
		}
	}

	public unsafe float fontStyleModifier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fontStyleModifier);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fontStyleModifier)) = value;
		}
	}

	public unsafe int renderMode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_renderMode);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_renderMode)) = value;
		}
	}

	public unsafe bool includeFontFeatures
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_includeFontFeatures);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_includeFontFeatures)) = value;
		}
	}

	static FontAssetCreationSettings()
	{
		Il2CppClassPointerStore<FontAssetCreationSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "FontAssetCreationSettings");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FontAssetCreationSettings>.NativeClassPtr);
		NativeFieldInfoPtr_sourceFontFileName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAssetCreationSettings>.NativeClassPtr, "sourceFontFileName");
		NativeFieldInfoPtr_sourceFontFileGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAssetCreationSettings>.NativeClassPtr, "sourceFontFileGUID");
		NativeFieldInfoPtr_faceIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAssetCreationSettings>.NativeClassPtr, "faceIndex");
		NativeFieldInfoPtr_pointSizeSamplingMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAssetCreationSettings>.NativeClassPtr, "pointSizeSamplingMode");
		NativeFieldInfoPtr_pointSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAssetCreationSettings>.NativeClassPtr, "pointSize");
		NativeFieldInfoPtr_padding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAssetCreationSettings>.NativeClassPtr, "padding");
		NativeFieldInfoPtr_paddingMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAssetCreationSettings>.NativeClassPtr, "paddingMode");
		NativeFieldInfoPtr_packingMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAssetCreationSettings>.NativeClassPtr, "packingMode");
		NativeFieldInfoPtr_atlasWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAssetCreationSettings>.NativeClassPtr, "atlasWidth");
		NativeFieldInfoPtr_atlasHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAssetCreationSettings>.NativeClassPtr, "atlasHeight");
		NativeFieldInfoPtr_characterSetSelectionMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAssetCreationSettings>.NativeClassPtr, "characterSetSelectionMode");
		NativeFieldInfoPtr_characterSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAssetCreationSettings>.NativeClassPtr, "characterSequence");
		NativeFieldInfoPtr_referencedFontAssetGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAssetCreationSettings>.NativeClassPtr, "referencedFontAssetGUID");
		NativeFieldInfoPtr_referencedTextAssetGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAssetCreationSettings>.NativeClassPtr, "referencedTextAssetGUID");
		NativeFieldInfoPtr_fontStyle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAssetCreationSettings>.NativeClassPtr, "fontStyle");
		NativeFieldInfoPtr_fontStyleModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAssetCreationSettings>.NativeClassPtr, "fontStyleModifier");
		NativeFieldInfoPtr_renderMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAssetCreationSettings>.NativeClassPtr, "renderMode");
		NativeFieldInfoPtr_includeFontFeatures = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAssetCreationSettings>.NativeClassPtr, "includeFontFeatures");
		NativeMethodInfoPtr__ctor_Internal_Void_String_Int32_Int32_Int32_Int32_Int32_Int32_Int32_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontAssetCreationSettings>.NativeClassPtr, 100663963);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1124031, XrefRangeEnd = 1124039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe FontAssetCreationSettings(string sourceFontFileGUID, int pointSize, int pointSizeSamplingMode, int padding, int packingMode, int atlasWidth, int atlasHeight, int characterSelectionMode, string characterSet, int renderMode)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FontAssetCreationSettings>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[10];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(sourceFontFileGUID);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &pointSize;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &pointSizeSamplingMode;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &padding;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &packingMode;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &atlasWidth;
		*(int**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &atlasHeight;
		*(int**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &characterSelectionMode;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(characterSet);
		*(int**)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = &renderMode;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_String_Int32_Int32_Int32_Int32_Int32_Int32_Int32_String_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public FontAssetCreationSettings(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public FontAssetCreationSettings()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FontAssetCreationSettings>.NativeClassPtr))
	{
	}
}
