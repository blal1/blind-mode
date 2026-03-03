using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppSpine.Unity.AttachmentTools;

public static class AtlasUtilities : Il2CppSystem.Object
{
	public sealed class IntAndAtlasRegionKey : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_i;

		private static readonly System.IntPtr NativeFieldInfoPtr_region;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_AtlasRegion_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		public unsafe int i
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_i);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_i)) = value;
			}
		}

		public unsafe AtlasRegion region
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_region);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AtlasRegion>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_region)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		static IntAndAtlasRegionKey()
		{
			Il2CppClassPointerStore<IntAndAtlasRegionKey>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AtlasUtilities>.NativeClassPtr, "IntAndAtlasRegionKey");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IntAndAtlasRegionKey>.NativeClassPtr);
			NativeFieldInfoPtr_i = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntAndAtlasRegionKey>.NativeClassPtr, "i");
			NativeFieldInfoPtr_region = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntAndAtlasRegionKey>.NativeClassPtr, "region");
			NativeMethodInfoPtr__ctor_Public_Void_Int32_AtlasRegion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntAndAtlasRegionKey>.NativeClassPtr, 100664251);
			NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntAndAtlasRegionKey>.NativeClassPtr, 100664252);
		}

		[CallerCount(31)]
		[CachedScanResults(RefRangeStart = 506934, RefRangeEnd = 506965, XrefRangeStart = 506934, XrefRangeEnd = 506965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntAndAtlasRegionKey(int i, AtlasRegion region)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IntAndAtlasRegionKey>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&i);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)region);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_AtlasRegion_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 858247, XrefRangeEnd = 858248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		public IntAndAtlasRegionKey(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public IntAndAtlasRegionKey()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IntAndAtlasRegionKey>.NativeClassPtr))
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_SpineTextureFormat;

	private static readonly System.IntPtr NativeFieldInfoPtr_DefaultMipmapBias;

	private static readonly System.IntPtr NativeFieldInfoPtr_UseMipMaps;

	private static readonly System.IntPtr NativeFieldInfoPtr_DefaultScale;

	private static readonly System.IntPtr NativeFieldInfoPtr_NonrenderingRegion;

	private static readonly System.IntPtr NativeFieldInfoPtr_existingRegions;

	private static readonly System.IntPtr NativeFieldInfoPtr_regionIndices;

	private static readonly System.IntPtr NativeFieldInfoPtr_originalRegions;

	private static readonly System.IntPtr NativeFieldInfoPtr_repackedRegions;

	private static readonly System.IntPtr NativeFieldInfoPtr_texturesToPackAtParam;

	private static readonly System.IntPtr NativeFieldInfoPtr_inoutAttachments;

	private static readonly System.IntPtr NativeFieldInfoPtr_CachedRegionTextures;

	private static readonly System.IntPtr NativeFieldInfoPtr_CachedRegionTexturesList;

	private static readonly System.IntPtr NativeMethodInfoPtr_Init_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToAtlasRegion_Public_Static_AtlasRegion_Texture2D_Material_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToAtlasRegion_Public_Static_AtlasRegion_Texture2D_Shader_Single_Material_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToAtlasRegionPMAClone_Public_Static_AtlasRegion_Texture2D_Material_TextureFormat_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToAtlasRegionPMAClone_Public_Static_AtlasRegion_Texture2D_Shader_TextureFormat_Boolean_Material_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToSpineAtlasPage_Public_Static_AtlasPage_Material_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToAtlasRegion_Public_Static_AtlasRegion_Sprite_AtlasPage_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToAtlasRegion_Public_Static_AtlasRegion_Sprite_Material_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToAtlasRegionPMAClone_Public_Static_AtlasRegion_Sprite_Material_TextureFormat_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToAtlasRegionPMAClone_Public_Static_AtlasRegion_Sprite_Shader_TextureFormat_Boolean_Material_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToAtlasRegion_Internal_Static_AtlasRegion_Sprite_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRepackedAttachments_Public_Static_Void_List_1_Attachment_List_1_Attachment_Material_byref_Material_byref_Texture2D_Int32_Int32_TextureFormat_Boolean_String_Boolean_Boolean_Il2CppStructArray_1_Int32_Il2CppReferenceArray_1_Texture2D_Il2CppStructArray_1_TextureFormat_Il2CppStructArray_1_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRepackedAttachments_Public_Static_Void_List_1_Attachment_List_1_Attachment_Shader_byref_Material_byref_Texture2D_Int32_Int32_TextureFormat_Boolean_String_Material_Boolean_Boolean_Il2CppStructArray_1_Int32_Il2CppReferenceArray_1_Texture2D_Il2CppStructArray_1_TextureFormat_Il2CppStructArray_1_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddRegionTexturesToPack_Private_Static_Void_Int32_AtlasRegion_TextureFormat_Boolean_Il2CppStructArray_1_TextureFormat_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRepackedSkin_Public_Static_Skin_Skin_String_Material_byref_Material_byref_Texture2D_Int32_Int32_TextureFormat_Boolean_Boolean_Boolean_Il2CppStructArray_1_Int32_Il2CppReferenceArray_1_Texture2D_Il2CppStructArray_1_TextureFormat_Il2CppStructArray_1_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRepackedSkin_Public_Static_Skin_Skin_String_Shader_byref_Material_byref_Texture2D_Int32_Int32_TextureFormat_Boolean_Material_Boolean_Boolean_Il2CppStructArray_1_Int32_Il2CppReferenceArray_1_Texture2D_Il2CppStructArray_1_TextureFormat_Il2CppStructArray_1_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToSprite_Public_Static_Sprite_AtlasRegion_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearCache_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToTexture_Public_Static_Texture2D_AtlasRegion_TextureFormat_Boolean_Int32_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToTexture_Private_Static_Texture2D_Sprite_TextureFormat_Boolean_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetClone_Private_Static_Texture2D_Texture2D_TextureFormat_Boolean_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CopyTexture_Private_Static_Void_Texture2D_Rect_Texture2D_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CopyTextureApplyPMA_Private_Static_Void_Texture2D_Rect_Texture2D_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsRenderable_Private_Static_Boolean_Attachment_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SpineUnityFlipRect_Private_Static_Rect_Rect_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetUnityRect_Private_Static_Rect_AtlasRegion_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetUnityRect_Private_Static_Rect_AtlasRegion_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSpineAtlasRect_Private_Static_Rect_AtlasRegion_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UVRectToTextureRect_Private_Static_Rect_Rect_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TextureRectToUVRect_Private_Static_Rect_Rect_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UVRectToAtlasRegion_Private_Static_AtlasRegion_Rect_AtlasRegion_AtlasPage_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMainTexture_Private_Static_Texture2D_AtlasRegion_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTexture_Private_Static_Texture2D_AtlasRegion_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTexture_Private_Static_Texture2D_AtlasRegion_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CopyTextureAttributesFrom_Private_Static_Void_Texture2D_Texture2D_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InverseLerp_Private_Static_Single_Single_Single_Single_0;

	public unsafe static TextureFormat SpineTextureFormat
	{
		get
		{
			Unsafe.SkipInit(out TextureFormat result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SpineTextureFormat, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SpineTextureFormat, (void*)(&value));
		}
	}

	public unsafe static float DefaultMipmapBias
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DefaultMipmapBias, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DefaultMipmapBias, (void*)(&value));
		}
	}

	public unsafe static bool UseMipMaps
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UseMipMaps, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UseMipMaps, (void*)(&value));
		}
	}

	public unsafe static float DefaultScale
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DefaultScale, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DefaultScale, (void*)(&value));
		}
	}

	public unsafe static int NonrenderingRegion
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_NonrenderingRegion, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_NonrenderingRegion, (void*)(&value));
		}
	}

	public unsafe static Dictionary<AtlasRegion, int> existingRegions
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_existingRegions, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<AtlasRegion, int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_existingRegions, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static List<int> regionIndices
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_regionIndices, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_regionIndices, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static List<AtlasRegion> originalRegions
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_originalRegions, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<AtlasRegion>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_originalRegions, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static List<AtlasRegion> repackedRegions
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_repackedRegions, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<AtlasRegion>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_repackedRegions, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppReferenceArray<List<Texture2D>> texturesToPackAtParam
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_texturesToPackAtParam, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<List<Texture2D>>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_texturesToPackAtParam, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static List<Attachment> inoutAttachments
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_inoutAttachments, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Attachment>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_inoutAttachments, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Dictionary<IntAndAtlasRegionKey, Texture2D> CachedRegionTextures
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CachedRegionTextures, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<IntAndAtlasRegionKey, Texture2D>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CachedRegionTextures, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static List<Texture2D> CachedRegionTexturesList
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CachedRegionTexturesList, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Texture2D>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CachedRegionTexturesList, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static AtlasUtilities()
	{
		Il2CppClassPointerStore<AtlasUtilities>.NativeClassPtr = IL2CPP.GetIl2CppClass("spine-unity.dll", "Spine.Unity.AttachmentTools", "AtlasUtilities");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AtlasUtilities>.NativeClassPtr);
		NativeFieldInfoPtr_SpineTextureFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AtlasUtilities>.NativeClassPtr, "SpineTextureFormat");
		NativeFieldInfoPtr_DefaultMipmapBias = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AtlasUtilities>.NativeClassPtr, "DefaultMipmapBias");
		NativeFieldInfoPtr_UseMipMaps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AtlasUtilities>.NativeClassPtr, "UseMipMaps");
		NativeFieldInfoPtr_DefaultScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AtlasUtilities>.NativeClassPtr, "DefaultScale");
		NativeFieldInfoPtr_NonrenderingRegion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AtlasUtilities>.NativeClassPtr, "NonrenderingRegion");
		NativeFieldInfoPtr_existingRegions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AtlasUtilities>.NativeClassPtr, "existingRegions");
		NativeFieldInfoPtr_regionIndices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AtlasUtilities>.NativeClassPtr, "regionIndices");
		NativeFieldInfoPtr_originalRegions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AtlasUtilities>.NativeClassPtr, "originalRegions");
		NativeFieldInfoPtr_repackedRegions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AtlasUtilities>.NativeClassPtr, "repackedRegions");
		NativeFieldInfoPtr_texturesToPackAtParam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AtlasUtilities>.NativeClassPtr, "texturesToPackAtParam");
		NativeFieldInfoPtr_inoutAttachments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AtlasUtilities>.NativeClassPtr, "inoutAttachments");
		NativeFieldInfoPtr_CachedRegionTextures = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AtlasUtilities>.NativeClassPtr, "CachedRegionTextures");
		NativeFieldInfoPtr_CachedRegionTexturesList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AtlasUtilities>.NativeClassPtr, "CachedRegionTexturesList");
		NativeMethodInfoPtr_Init_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AtlasUtilities>.NativeClassPtr, 100664214);
		NativeMethodInfoPtr_ToAtlasRegion_Public_Static_AtlasRegion_Texture2D_Material_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AtlasUtilities>.NativeClassPtr, 100664215);
		NativeMethodInfoPtr_ToAtlasRegion_Public_Static_AtlasRegion_Texture2D_Shader_Single_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AtlasUtilities>.NativeClassPtr, 100664216);
		NativeMethodInfoPtr_ToAtlasRegionPMAClone_Public_Static_AtlasRegion_Texture2D_Material_TextureFormat_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AtlasUtilities>.NativeClassPtr, 100664217);
		NativeMethodInfoPtr_ToAtlasRegionPMAClone_Public_Static_AtlasRegion_Texture2D_Shader_TextureFormat_Boolean_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AtlasUtilities>.NativeClassPtr, 100664218);
		NativeMethodInfoPtr_ToSpineAtlasPage_Public_Static_AtlasPage_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AtlasUtilities>.NativeClassPtr, 100664219);
		NativeMethodInfoPtr_ToAtlasRegion_Public_Static_AtlasRegion_Sprite_AtlasPage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AtlasUtilities>.NativeClassPtr, 100664220);
		NativeMethodInfoPtr_ToAtlasRegion_Public_Static_AtlasRegion_Sprite_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AtlasUtilities>.NativeClassPtr, 100664221);
		NativeMethodInfoPtr_ToAtlasRegionPMAClone_Public_Static_AtlasRegion_Sprite_Material_TextureFormat_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AtlasUtilities>.NativeClassPtr, 100664222);
		NativeMethodInfoPtr_ToAtlasRegionPMAClone_Public_Static_AtlasRegion_Sprite_Shader_TextureFormat_Boolean_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AtlasUtilities>.NativeClassPtr, 100664223);
		NativeMethodInfoPtr_ToAtlasRegion_Internal_Static_AtlasRegion_Sprite_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AtlasUtilities>.NativeClassPtr, 100664224);
		NativeMethodInfoPtr_GetRepackedAttachments_Public_Static_Void_List_1_Attachment_List_1_Attachment_Material_byref_Material_byref_Texture2D_Int32_Int32_TextureFormat_Boolean_String_Boolean_Boolean_Il2CppStructArray_1_Int32_Il2CppReferenceArray_1_Texture2D_Il2CppStructArray_1_TextureFormat_Il2CppStructArray_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AtlasUtilities>.NativeClassPtr, 100664225);
		NativeMethodInfoPtr_GetRepackedAttachments_Public_Static_Void_List_1_Attachment_List_1_Attachment_Shader_byref_Material_byref_Texture2D_Int32_Int32_TextureFormat_Boolean_String_Material_Boolean_Boolean_Il2CppStructArray_1_Int32_Il2CppReferenceArray_1_Texture2D_Il2CppStructArray_1_TextureFormat_Il2CppStructArray_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AtlasUtilities>.NativeClassPtr, 100664226);
		NativeMethodInfoPtr_AddRegionTexturesToPack_Private_Static_Void_Int32_AtlasRegion_TextureFormat_Boolean_Il2CppStructArray_1_TextureFormat_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AtlasUtilities>.NativeClassPtr, 100664227);
		NativeMethodInfoPtr_GetRepackedSkin_Public_Static_Skin_Skin_String_Material_byref_Material_byref_Texture2D_Int32_Int32_TextureFormat_Boolean_Boolean_Boolean_Il2CppStructArray_1_Int32_Il2CppReferenceArray_1_Texture2D_Il2CppStructArray_1_TextureFormat_Il2CppStructArray_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AtlasUtilities>.NativeClassPtr, 100664228);
		NativeMethodInfoPtr_GetRepackedSkin_Public_Static_Skin_Skin_String_Shader_byref_Material_byref_Texture2D_Int32_Int32_TextureFormat_Boolean_Material_Boolean_Boolean_Il2CppStructArray_1_Int32_Il2CppReferenceArray_1_Texture2D_Il2CppStructArray_1_TextureFormat_Il2CppStructArray_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AtlasUtilities>.NativeClassPtr, 100664229);
		NativeMethodInfoPtr_ToSprite_Public_Static_Sprite_AtlasRegion_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AtlasUtilities>.NativeClassPtr, 100664230);
		NativeMethodInfoPtr_ClearCache_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AtlasUtilities>.NativeClassPtr, 100664231);
		NativeMethodInfoPtr_ToTexture_Public_Static_Texture2D_AtlasRegion_TextureFormat_Boolean_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AtlasUtilities>.NativeClassPtr, 100664232);
		NativeMethodInfoPtr_ToTexture_Private_Static_Texture2D_Sprite_TextureFormat_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AtlasUtilities>.NativeClassPtr, 100664233);
		NativeMethodInfoPtr_GetClone_Private_Static_Texture2D_Texture2D_TextureFormat_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AtlasUtilities>.NativeClassPtr, 100664234);
		NativeMethodInfoPtr_CopyTexture_Private_Static_Void_Texture2D_Rect_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AtlasUtilities>.NativeClassPtr, 100664235);
		NativeMethodInfoPtr_CopyTextureApplyPMA_Private_Static_Void_Texture2D_Rect_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AtlasUtilities>.NativeClassPtr, 100664236);
		NativeMethodInfoPtr_IsRenderable_Private_Static_Boolean_Attachment_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AtlasUtilities>.NativeClassPtr, 100664237);
		NativeMethodInfoPtr_SpineUnityFlipRect_Private_Static_Rect_Rect_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AtlasUtilities>.NativeClassPtr, 100664238);
		NativeMethodInfoPtr_GetUnityRect_Private_Static_Rect_AtlasRegion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AtlasUtilities>.NativeClassPtr, 100664239);
		NativeMethodInfoPtr_GetUnityRect_Private_Static_Rect_AtlasRegion_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AtlasUtilities>.NativeClassPtr, 100664240);
		NativeMethodInfoPtr_GetSpineAtlasRect_Private_Static_Rect_AtlasRegion_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AtlasUtilities>.NativeClassPtr, 100664241);
		NativeMethodInfoPtr_UVRectToTextureRect_Private_Static_Rect_Rect_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AtlasUtilities>.NativeClassPtr, 100664242);
		NativeMethodInfoPtr_TextureRectToUVRect_Private_Static_Rect_Rect_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AtlasUtilities>.NativeClassPtr, 100664243);
		NativeMethodInfoPtr_UVRectToAtlasRegion_Private_Static_AtlasRegion_Rect_AtlasRegion_AtlasPage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AtlasUtilities>.NativeClassPtr, 100664244);
		NativeMethodInfoPtr_GetMainTexture_Private_Static_Texture2D_AtlasRegion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AtlasUtilities>.NativeClassPtr, 100664245);
		NativeMethodInfoPtr_GetTexture_Private_Static_Texture2D_AtlasRegion_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AtlasUtilities>.NativeClassPtr, 100664246);
		NativeMethodInfoPtr_GetTexture_Private_Static_Texture2D_AtlasRegion_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AtlasUtilities>.NativeClassPtr, 100664247);
		NativeMethodInfoPtr_CopyTextureAttributesFrom_Private_Static_Void_Texture2D_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AtlasUtilities>.NativeClassPtr, 100664248);
		NativeMethodInfoPtr_InverseLerp_Private_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AtlasUtilities>.NativeClassPtr, 100664249);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 858248, XrefRangeEnd = 858252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Init()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Init_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 858252, XrefRangeEnd = 858257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AtlasRegion ToAtlasRegion(this Texture2D t, Material materialPropertySource, float scale = 0.01f)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)t);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)materialPropertySource);
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &scale;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToAtlasRegion_Public_Static_AtlasRegion_Texture2D_Material_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<AtlasRegion>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 858282, RefRangeEnd = 858284, XrefRangeStart = 858257, XrefRangeEnd = 858282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AtlasRegion ToAtlasRegion(this Texture2D t, Shader shader, float scale = 0.01f, Material materialPropertySource = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)t);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)shader);
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &scale;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)materialPropertySource);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToAtlasRegion_Public_Static_AtlasRegion_Texture2D_Shader_Single_Material_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<AtlasRegion>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 858284, XrefRangeEnd = 858289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AtlasRegion ToAtlasRegionPMAClone(this Texture2D t, Material materialPropertySource, TextureFormat textureFormat = TextureFormat.RGBA32, bool mipmaps = false)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)t);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)materialPropertySource);
		*(TextureFormat**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &textureFormat;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &mipmaps;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToAtlasRegionPMAClone_Public_Static_AtlasRegion_Texture2D_Material_TextureFormat_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<AtlasRegion>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 858317, RefRangeEnd = 858318, XrefRangeStart = 858289, XrefRangeEnd = 858317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AtlasRegion ToAtlasRegionPMAClone(this Texture2D t, Shader shader, TextureFormat textureFormat = TextureFormat.RGBA32, bool mipmaps = false, Material materialPropertySource = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)t);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)shader);
		*(TextureFormat**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &textureFormat;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &mipmaps;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)materialPropertySource);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToAtlasRegionPMAClone_Public_Static_AtlasRegion_Texture2D_Shader_TextureFormat_Boolean_Material_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<AtlasRegion>(intPtr2) : null;
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 858330, RefRangeEnd = 858337, XrefRangeStart = 858318, XrefRangeEnd = 858330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AtlasPage ToSpineAtlasPage(this Material m)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)m);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToSpineAtlasPage_Public_Static_AtlasPage_Material_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<AtlasPage>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 858337, XrefRangeEnd = 858342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AtlasRegion ToAtlasRegion(this Sprite s, AtlasPage page)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)s);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)page);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToAtlasRegion_Public_Static_AtlasRegion_Sprite_AtlasPage_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<AtlasRegion>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 858342, XrefRangeEnd = 858348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AtlasRegion ToAtlasRegion(this Sprite s, Material material)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)s);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToAtlasRegion_Public_Static_AtlasRegion_Sprite_Material_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<AtlasRegion>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 858348, XrefRangeEnd = 858353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AtlasRegion ToAtlasRegionPMAClone(this Sprite s, Material materialPropertySource, TextureFormat textureFormat = TextureFormat.RGBA32, bool mipmaps = false)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)s);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)materialPropertySource);
		*(TextureFormat**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &textureFormat;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &mipmaps;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToAtlasRegionPMAClone_Public_Static_AtlasRegion_Sprite_Material_TextureFormat_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<AtlasRegion>(intPtr2) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 858381, RefRangeEnd = 858385, XrefRangeStart = 858353, XrefRangeEnd = 858381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AtlasRegion ToAtlasRegionPMAClone(this Sprite s, Shader shader, TextureFormat textureFormat = TextureFormat.RGBA32, bool mipmaps = false, Material materialPropertySource = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)s);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)shader);
		*(TextureFormat**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &textureFormat;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &mipmaps;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)materialPropertySource);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToAtlasRegionPMAClone_Public_Static_AtlasRegion_Sprite_Shader_TextureFormat_Boolean_Material_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<AtlasRegion>(intPtr2) : null;
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 858408, RefRangeEnd = 858413, XrefRangeStart = 858385, XrefRangeEnd = 858408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AtlasRegion ToAtlasRegion(this Sprite s, bool isolatedTexture = false)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)s);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &isolatedTexture;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToAtlasRegion_Internal_Static_AtlasRegion_Sprite_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<AtlasRegion>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 858413, XrefRangeEnd = 858426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetRepackedAttachments(List<Attachment> sourceAttachments, List<Attachment> outputAttachments, Material materialPropertySource, out Material outputMaterial, out Texture2D outputTexture, int maxAtlasSize = 1024, int padding = 2, TextureFormat textureFormat = TextureFormat.RGBA32, bool mipmaps = false, string newAssetName = "Repacked Attachments", bool clearCache = false, bool useOriginalNonrenderables = true, Il2CppStructArray<int> additionalTexturePropertyIDsToCopy = null, Il2CppReferenceArray<Texture2D> additionalOutputTextures = null, Il2CppStructArray<TextureFormat> additionalTextureFormats = null, Il2CppStructArray<bool> additionalTextureIsLinear = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[16];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sourceAttachments);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)outputAttachments);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)materialPropertySource);
		byte* num = (byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		byte* num3 = (byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num4 = 0;
		*(nint**)num3 = &num4;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxAtlasSize;
		*(int**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &padding;
		*(TextureFormat**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &textureFormat;
		*(bool**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = &mipmaps;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(newAssetName);
		*(bool**)((byte*)ptr + checked((nuint)10u * unchecked((nuint)sizeof(System.IntPtr)))) = &clearCache;
		*(bool**)((byte*)ptr + checked((nuint)11u * unchecked((nuint)sizeof(System.IntPtr)))) = &useOriginalNonrenderables;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)12u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)additionalTexturePropertyIDsToCopy);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)13u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)additionalOutputTextures);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)14u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)additionalTextureFormats);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)15u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)additionalTextureIsLinear);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRepackedAttachments_Public_Static_Void_List_1_Attachment_List_1_Attachment_Material_byref_Material_byref_Texture2D_Int32_Int32_TextureFormat_Boolean_String_Boolean_Boolean_Il2CppStructArray_1_Int32_Il2CppReferenceArray_1_Texture2D_Il2CppStructArray_1_TextureFormat_Il2CppStructArray_1_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num5 = num2;
		outputMaterial = ((num5 == 0) ? null : new Material(num5));
		nint num6 = num4;
		outputTexture = ((num6 == 0) ? null : new Texture2D(num6));
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 858670, RefRangeEnd = 858672, XrefRangeStart = 858426, XrefRangeEnd = 858670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetRepackedAttachments(List<Attachment> sourceAttachments, List<Attachment> outputAttachments, Shader shader, out Material outputMaterial, out Texture2D outputTexture, int maxAtlasSize = 1024, int padding = 2, TextureFormat textureFormat = TextureFormat.RGBA32, bool mipmaps = false, string newAssetName = "Repacked Attachments", Material materialPropertySource = null, bool clearCache = false, bool useOriginalNonrenderables = true, Il2CppStructArray<int> additionalTexturePropertyIDsToCopy = null, Il2CppReferenceArray<Texture2D> additionalOutputTextures = null, Il2CppStructArray<TextureFormat> additionalTextureFormats = null, Il2CppStructArray<bool> additionalTextureIsLinear = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[17];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sourceAttachments);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)outputAttachments);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)shader);
		byte* num = (byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		byte* num3 = (byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num4 = 0;
		*(nint**)num3 = &num4;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxAtlasSize;
		*(int**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &padding;
		*(TextureFormat**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &textureFormat;
		*(bool**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = &mipmaps;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(newAssetName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)10u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)materialPropertySource);
		*(bool**)((byte*)ptr + checked((nuint)11u * unchecked((nuint)sizeof(System.IntPtr)))) = &clearCache;
		*(bool**)((byte*)ptr + checked((nuint)12u * unchecked((nuint)sizeof(System.IntPtr)))) = &useOriginalNonrenderables;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)13u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)additionalTexturePropertyIDsToCopy);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)14u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)additionalOutputTextures);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)15u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)additionalTextureFormats);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)16u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)additionalTextureIsLinear);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRepackedAttachments_Public_Static_Void_List_1_Attachment_List_1_Attachment_Shader_byref_Material_byref_Texture2D_Int32_Int32_TextureFormat_Boolean_String_Material_Boolean_Boolean_Il2CppStructArray_1_Int32_Il2CppReferenceArray_1_Texture2D_Il2CppStructArray_1_TextureFormat_Il2CppStructArray_1_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num5 = num2;
		outputMaterial = ((num5 == 0) ? null : new Material(num5));
		nint num6 = num4;
		outputTexture = ((num6 == 0) ? null : new Texture2D(num6));
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 858686, RefRangeEnd = 858688, XrefRangeStart = 858672, XrefRangeEnd = 858686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void AddRegionTexturesToPack(int numTextureParamsToRepack, AtlasRegion region, TextureFormat textureFormat, bool mipmaps, Il2CppStructArray<TextureFormat> additionalTextureFormats, Il2CppStructArray<int> additionalTexturePropertyIDsToCopy, Il2CppStructArray<bool> additionalTextureIsLinear)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = (nint)(&numTextureParamsToRepack);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)region);
		*(TextureFormat**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &textureFormat;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &mipmaps;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)additionalTextureFormats);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)additionalTexturePropertyIDsToCopy);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)additionalTextureIsLinear);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddRegionTexturesToPack_Private_Static_Void_Int32_AtlasRegion_TextureFormat_Boolean_Il2CppStructArray_1_TextureFormat_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 858688, XrefRangeEnd = 858693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Skin GetRepackedSkin(this Skin o, string newName, Material materialPropertySource, out Material outputMaterial, out Texture2D outputTexture, int maxAtlasSize = 1024, int padding = 2, TextureFormat textureFormat = TextureFormat.RGBA32, bool mipmaps = false, bool useOriginalNonrenderables = true, bool clearCache = false, Il2CppStructArray<int> additionalTexturePropertyIDsToCopy = null, Il2CppReferenceArray<Texture2D> additionalOutputTextures = null, Il2CppStructArray<TextureFormat> additionalTextureFormats = null, Il2CppStructArray<bool> additionalTextureIsLinear = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[15];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)o);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(newName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)materialPropertySource);
		byte* num = (byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		byte* num3 = (byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num4 = 0;
		*(nint**)num3 = &num4;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxAtlasSize;
		*(int**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &padding;
		*(TextureFormat**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &textureFormat;
		*(bool**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = &mipmaps;
		*(bool**)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = &useOriginalNonrenderables;
		*(bool**)((byte*)ptr + checked((nuint)10u * unchecked((nuint)sizeof(System.IntPtr)))) = &clearCache;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)11u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)additionalTexturePropertyIDsToCopy);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)12u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)additionalOutputTextures);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)13u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)additionalTextureFormats);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)14u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)additionalTextureIsLinear);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRepackedSkin_Public_Static_Skin_Skin_String_Material_byref_Material_byref_Texture2D_Int32_Int32_TextureFormat_Boolean_Boolean_Boolean_Il2CppStructArray_1_Int32_Il2CppReferenceArray_1_Texture2D_Il2CppStructArray_1_TextureFormat_Il2CppStructArray_1_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num5 = num2;
		outputMaterial = ((num5 == 0) ? null : new Material(num5));
		nint num6 = num4;
		outputTexture = ((num6 == 0) ? null : new Texture2D(num6));
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Skin>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 858773, RefRangeEnd = 858774, XrefRangeStart = 858693, XrefRangeEnd = 858773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Skin GetRepackedSkin(this Skin o, string newName, Shader shader, out Material outputMaterial, out Texture2D outputTexture, int maxAtlasSize = 1024, int padding = 2, TextureFormat textureFormat = TextureFormat.RGBA32, bool mipmaps = false, Material materialPropertySource = null, bool clearCache = false, bool useOriginalNonrenderables = true, Il2CppStructArray<int> additionalTexturePropertyIDsToCopy = null, Il2CppReferenceArray<Texture2D> additionalOutputTextures = null, Il2CppStructArray<TextureFormat> additionalTextureFormats = null, Il2CppStructArray<bool> additionalTextureIsLinear = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[16];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)o);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(newName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)shader);
		byte* num = (byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		byte* num3 = (byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num4 = 0;
		*(nint**)num3 = &num4;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxAtlasSize;
		*(int**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &padding;
		*(TextureFormat**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &textureFormat;
		*(bool**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = &mipmaps;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)materialPropertySource);
		*(bool**)((byte*)ptr + checked((nuint)10u * unchecked((nuint)sizeof(System.IntPtr)))) = &clearCache;
		*(bool**)((byte*)ptr + checked((nuint)11u * unchecked((nuint)sizeof(System.IntPtr)))) = &useOriginalNonrenderables;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)12u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)additionalTexturePropertyIDsToCopy);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)13u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)additionalOutputTextures);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)14u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)additionalTextureFormats);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)15u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)additionalTextureIsLinear);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRepackedSkin_Public_Static_Skin_Skin_String_Shader_byref_Material_byref_Texture2D_Int32_Int32_TextureFormat_Boolean_Material_Boolean_Boolean_Il2CppStructArray_1_Int32_Il2CppReferenceArray_1_Texture2D_Il2CppStructArray_1_TextureFormat_Il2CppStructArray_1_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num5 = num2;
		outputMaterial = ((num5 == 0) ? null : new Material(num5));
		nint num6 = num4;
		outputTexture = ((num6 == 0) ? null : new Texture2D(num6));
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Skin>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 858774, XrefRangeEnd = 858782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Sprite ToSprite(this AtlasRegion ar, float pixelsPerUnit = 100f)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ar);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &pixelsPerUnit;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToSprite_Public_Static_Sprite_AtlasRegion_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 858813, RefRangeEnd = 858815, XrefRangeStart = 858782, XrefRangeEnd = 858813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ClearCache()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearCache_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 858875, RefRangeEnd = 858876, XrefRangeStart = 858815, XrefRangeEnd = 858875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Texture2D ToTexture(this AtlasRegion ar, TextureFormat textureFormat = TextureFormat.RGBA32, bool mipmaps = false, int texturePropertyId = 0, bool linear = false, bool applyPMA = false)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ar);
		*(TextureFormat**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &textureFormat;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &mipmaps;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &texturePropertyId;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &linear;
		*(bool**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &applyPMA;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToTexture_Public_Static_Texture2D_AtlasRegion_TextureFormat_Boolean_Int32_Boolean_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 858921, RefRangeEnd = 858922, XrefRangeStart = 858876, XrefRangeEnd = 858921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Texture2D ToTexture(this Sprite s, TextureFormat textureFormat = TextureFormat.RGBA32, bool mipmaps = false, bool linear = false, bool applyPMA = false)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)s);
		*(TextureFormat**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &textureFormat;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &mipmaps;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &linear;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &applyPMA;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToTexture_Private_Static_Texture2D_Sprite_TextureFormat_Boolean_Boolean_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 858947, RefRangeEnd = 858948, XrefRangeStart = 858922, XrefRangeEnd = 858947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Texture2D GetClone(this Texture2D t, TextureFormat textureFormat = TextureFormat.RGBA32, bool mipmaps = false, bool linear = false, bool applyPMA = false)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)t);
		*(TextureFormat**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &textureFormat;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &mipmaps;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &linear;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &applyPMA;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetClone_Private_Static_Texture2D_Texture2D_TextureFormat_Boolean_Boolean_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 858953, RefRangeEnd = 858956, XrefRangeStart = 858948, XrefRangeEnd = 858953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CopyTexture(Texture2D source, Rect sourceRect, Texture2D destination)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		*(Rect**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &sourceRect;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)destination);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CopyTexture_Private_Static_Void_Texture2D_Rect_Texture2D_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 858956, XrefRangeEnd = 858961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CopyTextureApplyPMA(Texture2D source, Rect sourceRect, Texture2D destination)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		*(Rect**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &sourceRect;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)destination);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CopyTextureApplyPMA_Private_Static_Void_Texture2D_Rect_Texture2D_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 858961, XrefRangeEnd = 858964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsRenderable(Attachment a)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)a);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsRenderable_Private_Static_Boolean_Attachment_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static Rect SpineUnityFlipRect(this Rect rect, int textureHeight)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&rect);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &textureHeight;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SpineUnityFlipRect_Private_Static_Rect_Rect_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Rect*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 858964, XrefRangeEnd = 858967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Rect GetUnityRect(this AtlasRegion region)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)region);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetUnityRect_Private_Static_Rect_AtlasRegion_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Rect*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 858967, XrefRangeEnd = 858970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Rect GetUnityRect(this AtlasRegion region, int textureHeight)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)region);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &textureHeight;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetUnityRect_Private_Static_Rect_AtlasRegion_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Rect*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static Rect GetSpineAtlasRect(this AtlasRegion region, bool includeRotate = true)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)region);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &includeRotate;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSpineAtlasRect_Private_Static_Rect_AtlasRegion_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Rect*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static Rect UVRectToTextureRect(Rect uvRect, int texWidth, int texHeight)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&uvRect);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &texWidth;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &texHeight;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UVRectToTextureRect_Private_Static_Rect_Rect_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Rect*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 858974, RefRangeEnd = 858975, XrefRangeStart = 858970, XrefRangeEnd = 858974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Rect TextureRectToUVRect(Rect textureRect, int texWidth, int texHeight)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&textureRect);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &texWidth;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &texHeight;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TextureRectToUVRect_Private_Static_Rect_Rect_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Rect*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 858988, RefRangeEnd = 858989, XrefRangeStart = 858975, XrefRangeEnd = 858988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AtlasRegion UVRectToAtlasRegion(Rect uvRect, AtlasRegion referenceRegion, AtlasPage page)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&uvRect);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)referenceRegion);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)page);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UVRectToAtlasRegion_Private_Static_AtlasRegion_Rect_AtlasRegion_AtlasPage_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<AtlasRegion>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 858994, RefRangeEnd = 858996, XrefRangeStart = 858989, XrefRangeEnd = 858994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Texture2D GetMainTexture(this AtlasRegion region)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)region);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMainTexture_Private_Static_Texture2D_AtlasRegion_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 858996, XrefRangeEnd = 859001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Texture2D GetTexture(this AtlasRegion region, string texturePropertyName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)region);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(texturePropertyName);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTexture_Private_Static_Texture2D_AtlasRegion_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 859001, XrefRangeEnd = 859006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Texture2D GetTexture(this AtlasRegion region, int texturePropertyId)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)region);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &texturePropertyId;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTexture_Private_Static_Texture2D_AtlasRegion_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 859017, RefRangeEnd = 859018, XrefRangeStart = 859006, XrefRangeEnd = 859017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CopyTextureAttributesFrom(this Texture2D destination, Texture2D source)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)destination);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CopyTextureAttributesFrom_Private_Static_Void_Texture2D_Texture2D_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe static float InverseLerp(float a, float b, float value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&a);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InverseLerp_Private_Static_Single_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public AtlasUtilities(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
