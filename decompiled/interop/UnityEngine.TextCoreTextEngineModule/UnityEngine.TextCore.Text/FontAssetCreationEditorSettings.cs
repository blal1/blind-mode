using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace UnityEngine.TextCore.Text;

[System.Serializable]
public sealed class FontAssetCreationEditorSettings : Il2CppSystem.ValueType
{
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

	public unsafe float pointSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pointSize);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pointSize)) = value;
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

	static FontAssetCreationEditorSettings()
	{
		Il2CppClassPointerStore<FontAssetCreationEditorSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TextCoreTextEngineModule.dll", "UnityEngine.TextCore.Text", "FontAssetCreationEditorSettings");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FontAssetCreationEditorSettings>.NativeClassPtr);
		NativeFieldInfoPtr_sourceFontFileGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAssetCreationEditorSettings>.NativeClassPtr, "sourceFontFileGUID");
		NativeFieldInfoPtr_faceIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAssetCreationEditorSettings>.NativeClassPtr, "faceIndex");
		NativeFieldInfoPtr_pointSizeSamplingMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAssetCreationEditorSettings>.NativeClassPtr, "pointSizeSamplingMode");
		NativeFieldInfoPtr_pointSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAssetCreationEditorSettings>.NativeClassPtr, "pointSize");
		NativeFieldInfoPtr_padding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAssetCreationEditorSettings>.NativeClassPtr, "padding");
		NativeFieldInfoPtr_paddingMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAssetCreationEditorSettings>.NativeClassPtr, "paddingMode");
		NativeFieldInfoPtr_packingMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAssetCreationEditorSettings>.NativeClassPtr, "packingMode");
		NativeFieldInfoPtr_atlasWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAssetCreationEditorSettings>.NativeClassPtr, "atlasWidth");
		NativeFieldInfoPtr_atlasHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAssetCreationEditorSettings>.NativeClassPtr, "atlasHeight");
		NativeFieldInfoPtr_characterSetSelectionMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAssetCreationEditorSettings>.NativeClassPtr, "characterSetSelectionMode");
		NativeFieldInfoPtr_characterSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAssetCreationEditorSettings>.NativeClassPtr, "characterSequence");
		NativeFieldInfoPtr_referencedFontAssetGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAssetCreationEditorSettings>.NativeClassPtr, "referencedFontAssetGUID");
		NativeFieldInfoPtr_referencedTextAssetGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAssetCreationEditorSettings>.NativeClassPtr, "referencedTextAssetGUID");
		NativeFieldInfoPtr_fontStyle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAssetCreationEditorSettings>.NativeClassPtr, "fontStyle");
		NativeFieldInfoPtr_fontStyleModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAssetCreationEditorSettings>.NativeClassPtr, "fontStyleModifier");
		NativeFieldInfoPtr_renderMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAssetCreationEditorSettings>.NativeClassPtr, "renderMode");
		NativeFieldInfoPtr_includeFontFeatures = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontAssetCreationEditorSettings>.NativeClassPtr, "includeFontFeatures");
	}

	public FontAssetCreationEditorSettings(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public FontAssetCreationEditorSettings()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FontAssetCreationEditorSettings>.NativeClassPtr))
	{
	}
}
