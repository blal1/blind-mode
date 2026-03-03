using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Bindings;

namespace UnityEngine;

public sealed class Sprite : Object
{
	private delegate System.IntPtr CreateSpriteWithoutTextureScripting_InjectedDelegate([In] System.IntPtr rect, [In] System.IntPtr pivot, float pixelsToUnits, System.IntPtr texture);

	private delegate uint get_extrude_InjectedDelegate(System.IntPtr _unity_self);

	private delegate System.IntPtr GetSecondaryTexture_InjectedDelegate(System.IntPtr _unity_self, int index);

	private delegate int GetSecondaryTextureCount_InjectedDelegate(System.IntPtr _unity_self);

	private delegate int GetSecondaryTextures_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr secondaryTexture);

	private delegate float get_spriteAtlasTextureScale_InjectedDelegate(System.IntPtr _unity_self);

	private delegate int GetPhysicsShapeCount_InjectedDelegate(System.IntPtr _unity_self);

	private delegate uint GetScriptableObjectsCount_InjectedDelegate(System.IntPtr _unity_self);

	private delegate uint GetScriptableObjects_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr scriptableObjects);

	private delegate bool AddScriptableObject_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr obj);

	private delegate bool RemoveScriptableObjectAt_InjectedDelegate(System.IntPtr _unity_self, uint i);

	private delegate bool SetScriptableObjectAt_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr obj, uint i);

	private delegate int Internal_GetPhysicsShapePointCount_InjectedDelegate(System.IntPtr _unity_self, int shapeIdx);

	private delegate void GetPhysicsShapeImpl_InjectedDelegate(System.IntPtr sprite, int shapeIdx, System.IntPtr physicsShape);

	private delegate void OverridePhysicsShapeCount_InjectedDelegate(System.IntPtr sprite, int physicsShapeCount);

	private delegate void OverridePhysicsShape_InjectedDelegate(System.IntPtr sprite, System.IntPtr physicsShape, int idx);

	private delegate void OverrideGeometry_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr vertices, System.IntPtr triangles);

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPackingMode_Internal_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPackingRotation_Internal_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPacked_Internal_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTextureRect_Internal_Rect_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTextureRectOffset_Internal_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetInnerUVs_Internal_Vector4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetOuterUVs_Internal_Vector4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPadding_Internal_Vector4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateSprite_Internal_Static_Sprite_Texture2D_Rect_Vector2_Single_UInt32_SpriteMeshType_Vector4_Boolean_Il2CppReferenceArray_1_SecondarySpriteTexture_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_bounds_Public_get_Bounds_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_rect_Public_get_Rect_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_border_Public_get_Vector4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_texture_Public_get_Texture2D_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_pixelsPerUnit_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_associatedAlphaSplitTexture_Public_get_Texture2D_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_pivot_Public_get_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_packed_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_packingMode_Public_get_SpritePackingMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_packingRotation_Public_get_SpritePackingRotation_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_textureRect_Public_get_Rect_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_textureRectOffset_Public_get_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_vertices_Public_get_Il2CppStructArray_1_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_triangles_Public_get_Il2CppStructArray_1_UInt16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_uv_Public_get_Il2CppStructArray_1_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Static_Sprite_Texture2D_Rect_Vector2_Single_UInt32_SpriteMeshType_Vector4_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Static_Sprite_Texture2D_Rect_Vector2_Single_UInt32_SpriteMeshType_Vector4_Boolean_Il2CppReferenceArray_1_SecondarySpriteTexture_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Static_Sprite_Texture2D_Rect_Vector2_Single_UInt32_SpriteMeshType_Vector4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Static_Sprite_Texture2D_Rect_Vector2_Single_UInt32_SpriteMeshType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Static_Sprite_Texture2D_Rect_Vector2_Single_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Static_Sprite_Texture2D_Rect_Vector2_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Static_Sprite_Texture2D_Rect_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPackingMode_Injected_Private_Static_Int32_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPackingRotation_Injected_Private_Static_Int32_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPacked_Injected_Private_Static_Int32_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTextureRect_Injected_Private_Static_Void_IntPtr_byref_Rect_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTextureRectOffset_Injected_Private_Static_Void_IntPtr_byref_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetInnerUVs_Injected_Private_Static_Void_IntPtr_byref_Vector4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetOuterUVs_Injected_Private_Static_Void_IntPtr_byref_Vector4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPadding_Injected_Private_Static_Void_IntPtr_byref_Vector4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateSprite_Injected_Private_Static_IntPtr_IntPtr_byref_Rect_byref_Vector2_Single_UInt32_SpriteMeshType_byref_Vector4_Boolean_Il2CppReferenceArray_1_SecondarySpriteTexture_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_bounds_Injected_Private_Static_Void_IntPtr_byref_Bounds_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_rect_Injected_Private_Static_Void_IntPtr_byref_Rect_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_border_Injected_Private_Static_Void_IntPtr_byref_Vector4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_texture_Injected_Private_Static_IntPtr_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_pixelsPerUnit_Injected_Private_Static_Single_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_associatedAlphaSplitTexture_Injected_Private_Static_IntPtr_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_pivot_Injected_Private_Static_Void_IntPtr_byref_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_vertices_Injected_Private_Static_Il2CppStructArray_1_Vector2_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_triangles_Injected_Private_Static_Il2CppStructArray_1_UInt16_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_uv_Injected_Private_Static_Il2CppStructArray_1_Vector2_IntPtr_0;

	private static readonly CreateSpriteWithoutTextureScripting_InjectedDelegate CreateSpriteWithoutTextureScripting_InjectedDelegateField;

	private static readonly get_extrude_InjectedDelegate get_extrude_InjectedDelegateField;

	private static readonly GetSecondaryTexture_InjectedDelegate GetSecondaryTexture_InjectedDelegateField;

	private static readonly GetSecondaryTextureCount_InjectedDelegate GetSecondaryTextureCount_InjectedDelegateField;

	private static readonly GetSecondaryTextures_InjectedDelegate GetSecondaryTextures_InjectedDelegateField;

	private static readonly get_spriteAtlasTextureScale_InjectedDelegate get_spriteAtlasTextureScale_InjectedDelegateField;

	private static readonly GetPhysicsShapeCount_InjectedDelegate GetPhysicsShapeCount_InjectedDelegateField;

	private static readonly GetScriptableObjectsCount_InjectedDelegate GetScriptableObjectsCount_InjectedDelegateField;

	private static readonly GetScriptableObjects_InjectedDelegate GetScriptableObjects_InjectedDelegateField;

	private static readonly AddScriptableObject_InjectedDelegate AddScriptableObject_InjectedDelegateField;

	private static readonly RemoveScriptableObjectAt_InjectedDelegate RemoveScriptableObjectAt_InjectedDelegateField;

	private static readonly SetScriptableObjectAt_InjectedDelegate SetScriptableObjectAt_InjectedDelegateField;

	private static readonly Internal_GetPhysicsShapePointCount_InjectedDelegate Internal_GetPhysicsShapePointCount_InjectedDelegateField;

	private static readonly GetPhysicsShapeImpl_InjectedDelegate GetPhysicsShapeImpl_InjectedDelegateField;

	private static readonly OverridePhysicsShapeCount_InjectedDelegate OverridePhysicsShapeCount_InjectedDelegateField;

	private static readonly OverridePhysicsShape_InjectedDelegate OverridePhysicsShape_InjectedDelegateField;

	private static readonly OverrideGeometry_InjectedDelegate OverrideGeometry_InjectedDelegateField;

	public unsafe Bounds bounds
	{
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 1166740, RefRangeEnd = 1166753, XrefRangeStart = 1166736, XrefRangeEnd = 1166740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_bounds_Public_get_Bounds_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Bounds*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe Rect rect
	{
		[CallerCount(43)]
		[CachedScanResults(RefRangeStart = 1166757, RefRangeEnd = 1166800, XrefRangeStart = 1166753, XrefRangeEnd = 1166757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_rect_Public_get_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Rect*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe Vector4 border
	{
		[CallerCount(55)]
		[CachedScanResults(RefRangeStart = 1166804, RefRangeEnd = 1166859, XrefRangeStart = 1166800, XrefRangeEnd = 1166804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_border_Public_get_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Vector4*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe Texture2D texture
	{
		[CallerCount(77)]
		[CachedScanResults(RefRangeStart = 1166867, RefRangeEnd = 1166944, XrefRangeStart = 1166859, XrefRangeEnd = 1166867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_texture_Public_get_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
		}
	}

	public unsafe float pixelsPerUnit
	{
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 1166949, RefRangeEnd = 1166963, XrefRangeStart = 1166944, XrefRangeEnd = 1166949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_pixelsPerUnit_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe Texture2D associatedAlphaSplitTexture
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1166971, RefRangeEnd = 1166973, XrefRangeStart = 1166963, XrefRangeEnd = 1166971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_associatedAlphaSplitTexture_Public_get_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
		}
	}

	public unsafe Vector2 pivot
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1166977, RefRangeEnd = 1166978, XrefRangeStart = 1166973, XrefRangeEnd = 1166977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_pivot_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool packed
	{
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1166982, RefRangeEnd = 1166987, XrefRangeStart = 1166978, XrefRangeEnd = 1166982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_packed_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe SpritePackingMode packingMode
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1166687, RefRangeEnd = 1166688, XrefRangeStart = 1166687, XrefRangeEnd = 1166688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_packingMode_Public_get_SpritePackingMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(SpritePackingMode*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe SpritePackingRotation packingRotation
	{
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1166693, RefRangeEnd = 1166697, XrefRangeStart = 1166693, XrefRangeEnd = 1166697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_packingRotation_Public_get_SpritePackingRotation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(SpritePackingRotation*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe Rect textureRect
	{
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 1166991, RefRangeEnd = 1167005, XrefRangeStart = 1166987, XrefRangeEnd = 1166991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_textureRect_Public_get_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Rect*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe Vector2 textureRectOffset
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1166710, RefRangeEnd = 1166713, XrefRangeStart = 1166710, XrefRangeEnd = 1166713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_textureRectOffset_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe Il2CppStructArray<Vector2> vertices
	{
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1167010, RefRangeEnd = 1167014, XrefRangeStart = 1167005, XrefRangeEnd = 1167010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_vertices_Public_get_Il2CppStructArray_1_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(intPtr2) : null;
		}
	}

	public unsafe Il2CppStructArray<ushort> triangles
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1167019, RefRangeEnd = 1167021, XrefRangeStart = 1167014, XrefRangeEnd = 1167019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_triangles_Public_get_Il2CppStructArray_1_UInt16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<ushort>>(intPtr2) : null;
		}
	}

	public unsafe Il2CppStructArray<Vector2> uv
	{
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 1167026, RefRangeEnd = 1167041, XrefRangeStart = 1167021, XrefRangeEnd = 1167026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_uv_Public_get_Il2CppStructArray_1_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(intPtr2) : null;
		}
	}

	public uint extrude
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_extrude_Injected(intPtr);
		}
	}

	public float spriteAtlasTextureScale
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_spriteAtlasTextureScale_Injected(intPtr);
		}
	}

	static Sprite()
	{
		Il2CppClassPointerStore<Sprite>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Sprite");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Sprite>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100663697);
		NativeMethodInfoPtr_GetPackingMode_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100663698);
		NativeMethodInfoPtr_GetPackingRotation_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100663699);
		NativeMethodInfoPtr_GetPacked_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100663700);
		NativeMethodInfoPtr_GetTextureRect_Internal_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100663701);
		NativeMethodInfoPtr_GetTextureRectOffset_Internal_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100663702);
		NativeMethodInfoPtr_GetInnerUVs_Internal_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100663703);
		NativeMethodInfoPtr_GetOuterUVs_Internal_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100663704);
		NativeMethodInfoPtr_GetPadding_Internal_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100663705);
		NativeMethodInfoPtr_CreateSprite_Internal_Static_Sprite_Texture2D_Rect_Vector2_Single_UInt32_SpriteMeshType_Vector4_Boolean_Il2CppReferenceArray_1_SecondarySpriteTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100663706);
		NativeMethodInfoPtr_get_bounds_Public_get_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100663707);
		NativeMethodInfoPtr_get_rect_Public_get_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100663708);
		NativeMethodInfoPtr_get_border_Public_get_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100663709);
		NativeMethodInfoPtr_get_texture_Public_get_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100663710);
		NativeMethodInfoPtr_get_pixelsPerUnit_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100663711);
		NativeMethodInfoPtr_get_associatedAlphaSplitTexture_Public_get_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100663712);
		NativeMethodInfoPtr_get_pivot_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100663713);
		NativeMethodInfoPtr_get_packed_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100663714);
		NativeMethodInfoPtr_get_packingMode_Public_get_SpritePackingMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100663715);
		NativeMethodInfoPtr_get_packingRotation_Public_get_SpritePackingRotation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100663716);
		NativeMethodInfoPtr_get_textureRect_Public_get_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100663717);
		NativeMethodInfoPtr_get_textureRectOffset_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100663718);
		NativeMethodInfoPtr_get_vertices_Public_get_Il2CppStructArray_1_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100663719);
		NativeMethodInfoPtr_get_triangles_Public_get_Il2CppStructArray_1_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100663720);
		NativeMethodInfoPtr_get_uv_Public_get_Il2CppStructArray_1_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100663721);
		NativeMethodInfoPtr_Create_Public_Static_Sprite_Texture2D_Rect_Vector2_Single_UInt32_SpriteMeshType_Vector4_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100663722);
		NativeMethodInfoPtr_Create_Public_Static_Sprite_Texture2D_Rect_Vector2_Single_UInt32_SpriteMeshType_Vector4_Boolean_Il2CppReferenceArray_1_SecondarySpriteTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100663723);
		NativeMethodInfoPtr_Create_Public_Static_Sprite_Texture2D_Rect_Vector2_Single_UInt32_SpriteMeshType_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100663724);
		NativeMethodInfoPtr_Create_Public_Static_Sprite_Texture2D_Rect_Vector2_Single_UInt32_SpriteMeshType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100663725);
		NativeMethodInfoPtr_Create_Public_Static_Sprite_Texture2D_Rect_Vector2_Single_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100663726);
		NativeMethodInfoPtr_Create_Public_Static_Sprite_Texture2D_Rect_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100663727);
		NativeMethodInfoPtr_Create_Public_Static_Sprite_Texture2D_Rect_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100663728);
		NativeMethodInfoPtr_GetPackingMode_Injected_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100663729);
		NativeMethodInfoPtr_GetPackingRotation_Injected_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100663730);
		NativeMethodInfoPtr_GetPacked_Injected_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100663731);
		NativeMethodInfoPtr_GetTextureRect_Injected_Private_Static_Void_IntPtr_byref_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100663732);
		NativeMethodInfoPtr_GetTextureRectOffset_Injected_Private_Static_Void_IntPtr_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100663733);
		NativeMethodInfoPtr_GetInnerUVs_Injected_Private_Static_Void_IntPtr_byref_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100663734);
		NativeMethodInfoPtr_GetOuterUVs_Injected_Private_Static_Void_IntPtr_byref_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100663735);
		NativeMethodInfoPtr_GetPadding_Injected_Private_Static_Void_IntPtr_byref_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100663736);
		NativeMethodInfoPtr_CreateSprite_Injected_Private_Static_IntPtr_IntPtr_byref_Rect_byref_Vector2_Single_UInt32_SpriteMeshType_byref_Vector4_Boolean_Il2CppReferenceArray_1_SecondarySpriteTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100663737);
		NativeMethodInfoPtr_get_bounds_Injected_Private_Static_Void_IntPtr_byref_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100663738);
		NativeMethodInfoPtr_get_rect_Injected_Private_Static_Void_IntPtr_byref_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100663739);
		NativeMethodInfoPtr_get_border_Injected_Private_Static_Void_IntPtr_byref_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100663740);
		NativeMethodInfoPtr_get_texture_Injected_Private_Static_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100663741);
		NativeMethodInfoPtr_get_pixelsPerUnit_Injected_Private_Static_Single_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100663742);
		NativeMethodInfoPtr_get_associatedAlphaSplitTexture_Injected_Private_Static_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100663743);
		NativeMethodInfoPtr_get_pivot_Injected_Private_Static_Void_IntPtr_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100663744);
		NativeMethodInfoPtr_get_vertices_Injected_Private_Static_Il2CppStructArray_1_Vector2_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100663745);
		NativeMethodInfoPtr_get_triangles_Injected_Private_Static_Il2CppStructArray_1_UInt16_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100663746);
		NativeMethodInfoPtr_get_uv_Injected_Private_Static_Il2CppStructArray_1_Vector2_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100663747);
		CreateSpriteWithoutTextureScripting_InjectedDelegateField = IL2CPP.ResolveICall<CreateSpriteWithoutTextureScripting_InjectedDelegate>("UnityEngine.Sprite::CreateSpriteWithoutTextureScripting_Injected");
		get_extrude_InjectedDelegateField = IL2CPP.ResolveICall<get_extrude_InjectedDelegate>("UnityEngine.Sprite::get_extrude_Injected");
		GetSecondaryTexture_InjectedDelegateField = IL2CPP.ResolveICall<GetSecondaryTexture_InjectedDelegate>("UnityEngine.Sprite::GetSecondaryTexture_Injected");
		GetSecondaryTextureCount_InjectedDelegateField = IL2CPP.ResolveICall<GetSecondaryTextureCount_InjectedDelegate>("UnityEngine.Sprite::GetSecondaryTextureCount_Injected");
		GetSecondaryTextures_InjectedDelegateField = IL2CPP.ResolveICall<GetSecondaryTextures_InjectedDelegate>("UnityEngine.Sprite::GetSecondaryTextures_Injected");
		get_spriteAtlasTextureScale_InjectedDelegateField = IL2CPP.ResolveICall<get_spriteAtlasTextureScale_InjectedDelegate>("UnityEngine.Sprite::get_spriteAtlasTextureScale_Injected");
		GetPhysicsShapeCount_InjectedDelegateField = IL2CPP.ResolveICall<GetPhysicsShapeCount_InjectedDelegate>("UnityEngine.Sprite::GetPhysicsShapeCount_Injected");
		GetScriptableObjectsCount_InjectedDelegateField = IL2CPP.ResolveICall<GetScriptableObjectsCount_InjectedDelegate>("UnityEngine.Sprite::GetScriptableObjectsCount_Injected");
		GetScriptableObjects_InjectedDelegateField = IL2CPP.ResolveICall<GetScriptableObjects_InjectedDelegate>("UnityEngine.Sprite::GetScriptableObjects_Injected");
		AddScriptableObject_InjectedDelegateField = IL2CPP.ResolveICall<AddScriptableObject_InjectedDelegate>("UnityEngine.Sprite::AddScriptableObject_Injected");
		RemoveScriptableObjectAt_InjectedDelegateField = IL2CPP.ResolveICall<RemoveScriptableObjectAt_InjectedDelegate>("UnityEngine.Sprite::RemoveScriptableObjectAt_Injected");
		SetScriptableObjectAt_InjectedDelegateField = IL2CPP.ResolveICall<SetScriptableObjectAt_InjectedDelegate>("UnityEngine.Sprite::SetScriptableObjectAt_Injected");
		Internal_GetPhysicsShapePointCount_InjectedDelegateField = IL2CPP.ResolveICall<Internal_GetPhysicsShapePointCount_InjectedDelegate>("UnityEngine.Sprite::Internal_GetPhysicsShapePointCount_Injected");
		GetPhysicsShapeImpl_InjectedDelegateField = IL2CPP.ResolveICall<GetPhysicsShapeImpl_InjectedDelegate>("UnityEngine.Sprite::GetPhysicsShapeImpl_Injected");
		OverridePhysicsShapeCount_InjectedDelegateField = IL2CPP.ResolveICall<OverridePhysicsShapeCount_InjectedDelegate>("UnityEngine.Sprite::OverridePhysicsShapeCount_Injected");
		OverridePhysicsShape_InjectedDelegateField = IL2CPP.ResolveICall<OverridePhysicsShape_InjectedDelegate>("UnityEngine.Sprite::OverridePhysicsShape_Injected");
		OverrideGeometry_InjectedDelegateField = IL2CPP.ResolveICall<OverrideGeometry_InjectedDelegate>("UnityEngine.Sprite::OverrideGeometry_Injected");
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1166678, XrefRangeEnd = 1166682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Sprite()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Sprite>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1166687, RefRangeEnd = 1166688, XrefRangeStart = 1166682, XrefRangeEnd = 1166687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetPackingMode()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPackingMode_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1166693, RefRangeEnd = 1166697, XrefRangeStart = 1166688, XrefRangeEnd = 1166693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetPackingRotation()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPackingRotation_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1166697, XrefRangeEnd = 1166702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetPacked()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPacked_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1166702, XrefRangeEnd = 1166706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Rect GetTextureRect()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTextureRect_Internal_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Rect*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1166710, RefRangeEnd = 1166713, XrefRangeStart = 1166706, XrefRangeEnd = 1166710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector2 GetTextureRectOffset()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTextureRectOffset_Internal_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1166717, RefRangeEnd = 1166718, XrefRangeStart = 1166713, XrefRangeEnd = 1166717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector4 GetInnerUVs()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetInnerUVs_Internal_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Vector4*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1166722, RefRangeEnd = 1166723, XrefRangeStart = 1166718, XrefRangeEnd = 1166722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector4 GetOuterUVs()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetOuterUVs_Internal_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Vector4*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1166727, RefRangeEnd = 1166728, XrefRangeStart = 1166723, XrefRangeEnd = 1166727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector4 GetPadding()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPadding_Internal_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Vector4*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1166728, XrefRangeEnd = 1166736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Sprite CreateSprite(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType, Vector4 border, bool generateFallbackPhysicsShape, Il2CppReferenceArray<SecondarySpriteTexture> secondaryTexture)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[9];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)texture);
		*(Rect**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &rect;
		*(Vector2**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &pivot;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &pixelsPerUnit;
		*(uint**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &extrude;
		*(SpriteMeshType**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &meshType;
		*(Vector4**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &border;
		*(bool**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &generateFallbackPhysicsShape;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)secondaryTexture);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateSprite_Internal_Static_Sprite_Texture2D_Rect_Vector2_Single_UInt32_SpriteMeshType_Vector4_Boolean_Il2CppReferenceArray_1_SecondarySpriteTexture_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1167041, XrefRangeEnd = 1167042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType, Vector4 border, bool generateFallbackPhysicsShape)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[8];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)texture);
		*(Rect**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &rect;
		*(Vector2**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &pivot;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &pixelsPerUnit;
		*(uint**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &extrude;
		*(SpriteMeshType**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &meshType;
		*(Vector4**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &border;
		*(bool**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &generateFallbackPhysicsShape;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Create_Public_Static_Sprite_Texture2D_Rect_Vector2_Single_UInt32_SpriteMeshType_Vector4_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 1167059, RefRangeEnd = 1167065, XrefRangeStart = 1167042, XrefRangeEnd = 1167059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType, Vector4 border, bool generateFallbackPhysicsShape, Il2CppReferenceArray<SecondarySpriteTexture> secondaryTextures)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[9];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)texture);
		*(Rect**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &rect;
		*(Vector2**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &pivot;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &pixelsPerUnit;
		*(uint**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &extrude;
		*(SpriteMeshType**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &meshType;
		*(Vector4**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &border;
		*(bool**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &generateFallbackPhysicsShape;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)secondaryTextures);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Create_Public_Static_Sprite_Texture2D_Rect_Vector2_Single_UInt32_SpriteMeshType_Vector4_Boolean_Il2CppReferenceArray_1_SecondarySpriteTexture_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1167065, XrefRangeEnd = 1167066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType, Vector4 border)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)texture);
		*(Rect**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &rect;
		*(Vector2**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &pivot;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &pixelsPerUnit;
		*(uint**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &extrude;
		*(SpriteMeshType**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &meshType;
		*(Vector4**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &border;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Create_Public_Static_Sprite_Texture2D_Rect_Vector2_Single_UInt32_SpriteMeshType_Vector4_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1167069, RefRangeEnd = 1167070, XrefRangeStart = 1167066, XrefRangeEnd = 1167069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)texture);
		*(Rect**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &rect;
		*(Vector2**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &pivot;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &pixelsPerUnit;
		*(uint**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &extrude;
		*(SpriteMeshType**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &meshType;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Create_Public_Static_Sprite_Texture2D_Rect_Vector2_Single_UInt32_SpriteMeshType_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1167070, XrefRangeEnd = 1167073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)texture);
		*(Rect**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &rect;
		*(Vector2**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &pivot;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &pixelsPerUnit;
		*(uint**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &extrude;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Create_Public_Static_Sprite_Texture2D_Rect_Vector2_Single_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1167076, RefRangeEnd = 1167079, XrefRangeStart = 1167073, XrefRangeEnd = 1167076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)texture);
		*(Rect**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &rect;
		*(Vector2**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &pivot;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &pixelsPerUnit;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Create_Public_Static_Sprite_Texture2D_Rect_Vector2_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1167082, RefRangeEnd = 1167084, XrefRangeStart = 1167079, XrefRangeEnd = 1167082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)texture);
		*(Rect**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &rect;
		*(Vector2**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &pivot;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Create_Public_Static_Sprite_Texture2D_Rect_Vector2_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1167084, XrefRangeEnd = 1167086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetPackingMode_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPackingMode_Injected_Private_Static_Int32_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1167086, XrefRangeEnd = 1167088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetPackingRotation_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPackingRotation_Injected_Private_Static_Int32_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1167088, XrefRangeEnd = 1167090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetPacked_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPacked_Injected_Private_Static_Int32_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1167090, XrefRangeEnd = 1167092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetTextureRect_Injected(System.IntPtr _unity_self, out Rect ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTextureRect_Injected_Private_Static_Void_IntPtr_byref_Rect_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1167092, XrefRangeEnd = 1167094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetTextureRectOffset_Injected(System.IntPtr _unity_self, out Vector2 ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTextureRectOffset_Injected_Private_Static_Void_IntPtr_byref_Vector2_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1167094, XrefRangeEnd = 1167096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetInnerUVs_Injected(System.IntPtr _unity_self, out Vector4 ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetInnerUVs_Injected_Private_Static_Void_IntPtr_byref_Vector4_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1167096, XrefRangeEnd = 1167098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetOuterUVs_Injected(System.IntPtr _unity_self, out Vector4 ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetOuterUVs_Injected_Private_Static_Void_IntPtr_byref_Vector4_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1167098, XrefRangeEnd = 1167100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetPadding_Injected(System.IntPtr _unity_self, out Vector4 ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPadding_Injected_Private_Static_Void_IntPtr_byref_Vector4_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1167100, XrefRangeEnd = 1167102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr CreateSprite_Injected(System.IntPtr texture, [In] ref Rect rect, [In] ref Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType, [In] ref Vector4 border, bool generateFallbackPhysicsShape, Il2CppReferenceArray<SecondarySpriteTexture> secondaryTexture)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[9];
		*ptr = (nint)(&texture);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref rect);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref pivot);
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &pixelsPerUnit;
		*(uint**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &extrude;
		*(SpriteMeshType**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &meshType;
		*(void**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref border);
		*(bool**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &generateFallbackPhysicsShape;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)secondaryTexture);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateSprite_Injected_Private_Static_IntPtr_IntPtr_byref_Rect_byref_Vector2_Single_UInt32_SpriteMeshType_byref_Vector4_Boolean_Il2CppReferenceArray_1_SecondarySpriteTexture_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1167102, XrefRangeEnd = 1167104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void get_bounds_Injected(System.IntPtr _unity_self, out Bounds ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_bounds_Injected_Private_Static_Void_IntPtr_byref_Bounds_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1167104, XrefRangeEnd = 1167106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void get_rect_Injected(System.IntPtr _unity_self, out Rect ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_rect_Injected_Private_Static_Void_IntPtr_byref_Rect_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1167106, XrefRangeEnd = 1167108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void get_border_Injected(System.IntPtr _unity_self, out Vector4 ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_border_Injected_Private_Static_Void_IntPtr_byref_Vector4_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1167108, XrefRangeEnd = 1167110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr get_texture_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_texture_Injected_Private_Static_IntPtr_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1167110, XrefRangeEnd = 1167112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float get_pixelsPerUnit_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_pixelsPerUnit_Injected_Private_Static_Single_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1167112, XrefRangeEnd = 1167114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr get_associatedAlphaSplitTexture_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_associatedAlphaSplitTexture_Injected_Private_Static_IntPtr_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1167114, XrefRangeEnd = 1167116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void get_pivot_Injected(System.IntPtr _unity_self, out Vector2 ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_pivot_Injected_Private_Static_Void_IntPtr_byref_Vector2_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1167116, XrefRangeEnd = 1167118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<Vector2> get_vertices_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_vertices_Injected_Private_Static_Il2CppStructArray_1_Vector2_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1167118, XrefRangeEnd = 1167120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<ushort> get_triangles_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_triangles_Injected_Private_Static_Il2CppStructArray_1_UInt16_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<ushort>>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1167120, XrefRangeEnd = 1167122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<Vector2> get_uv_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_uv_Injected_Private_Static_Il2CppStructArray_1_Vector2_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(intPtr2) : null;
	}

	public Sprite(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public static Sprite CreateSpriteWithoutTextureScripting(Rect rect, Vector2 pivot, float pixelsToUnits, Texture2D texture)
	{
		return Unmarshal.UnmarshalUnityObject<Sprite>(CreateSpriteWithoutTextureScripting_Injected(ref rect, ref pivot, pixelsToUnits, MarshalledUnityObject.Marshal(texture)));
	}

	public Texture2D GetSecondaryTexture(int index)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return Unmarshal.UnmarshalUnityObject<Texture2D>(GetSecondaryTexture_Injected(intPtr, index));
	}

	public int GetSecondaryTextureCount()
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return GetSecondaryTextureCount_Injected(intPtr);
	}

	public int GetSecondaryTextures(Il2CppReferenceArray<SecondarySpriteTexture> secondaryTexture)
	{
		if (secondaryTexture == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object)(object)secondaryTexture, "secondaryTexture");
		}
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return GetSecondaryTextures_Injected(intPtr, secondaryTexture);
	}

	public int GetPhysicsShapeCount()
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return GetPhysicsShapeCount_Injected(intPtr);
	}

	public uint GetScriptableObjectsCount()
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return GetScriptableObjectsCount_Injected(intPtr);
	}

	public uint GetScriptableObjects(Il2CppReferenceArray<ScriptableObject> scriptableObjects)
	{
		if (scriptableObjects == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object)(object)scriptableObjects, "scriptableObjects");
		}
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return GetScriptableObjects_Injected(intPtr, scriptableObjects);
	}

	public bool AddScriptableObject(ScriptableObject obj)
	{
		if ((object)obj == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(obj, "obj");
		}
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		System.IntPtr intPtr2 = MarshalledUnityObject.MarshalNotNull(obj);
		if (intPtr2 == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(obj, "obj");
		}
		return AddScriptableObject_Injected(intPtr, intPtr2);
	}

	public bool RemoveScriptableObjectAt(uint i)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return RemoveScriptableObjectAt_Injected(intPtr, i);
	}

	public bool SetScriptableObjectAt(ScriptableObject obj, uint i)
	{
		if ((object)obj == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(obj, "obj");
		}
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		System.IntPtr intPtr2 = MarshalledUnityObject.MarshalNotNull(obj);
		if (intPtr2 == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(obj, "obj");
		}
		return SetScriptableObjectAt_Injected(intPtr, intPtr2, i);
	}

	public int GetPhysicsShapePointCount(int shapeIdx)
	{
		int physicsShapeCount = GetPhysicsShapeCount();
		if (shapeIdx < 0 || shapeIdx >= physicsShapeCount)
		{
			throw new Il2CppSystem.IndexOutOfRangeException(Il2CppSystem.String.Format("Index({0}) is out of bounds(0 - {1})", (Il2CppSystem.Object)(object)shapeIdx, (Il2CppSystem.Object)(object)(physicsShapeCount - 1)));
		}
		return Internal_GetPhysicsShapePointCount(shapeIdx);
	}

	public int Internal_GetPhysicsShapePointCount(int shapeIdx)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return Internal_GetPhysicsShapePointCount_Injected(intPtr, shapeIdx);
	}

	public int GetPhysicsShape(int shapeIdx, List<Vector2> physicsShape)
	{
		int physicsShapeCount = GetPhysicsShapeCount();
		if (shapeIdx < 0 || shapeIdx >= physicsShapeCount)
		{
			throw new Il2CppSystem.IndexOutOfRangeException(Il2CppSystem.String.Format("Index({0}) is out of bounds(0 - {1})", (Il2CppSystem.Object)(object)shapeIdx, (Il2CppSystem.Object)(object)(physicsShapeCount - 1)));
		}
		GetPhysicsShapeImpl(this, shapeIdx, physicsShape);
		return physicsShape.Count;
	}

	public static void GetPhysicsShapeImpl(Sprite sprite, int shapeIdx, List<Vector2> physicsShape)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public void OverridePhysicsShape(IList<Il2CppStructArray<Vector2>> physicsShapes)
	{
		if (physicsShapes == null)
		{
			throw new Il2CppSystem.ArgumentNullException("physicsShapes");
		}
		for (int i = 0; i < ((ICollection<Il2CppStructArray<Vector2>>)(object)physicsShapes).Count; i++)
		{
			Il2CppStructArray<Vector2> val = physicsShapes[i];
			if (val == null)
			{
				throw new Il2CppSystem.ArgumentNullException("physicsShape", Il2CppSystem.String.Format("Physics Shape at {0} is null.", (Il2CppSystem.Object)(object)i));
			}
			if (((Il2CppArrayBase)val).Length < 3)
			{
				throw new Il2CppSystem.ArgumentException(Il2CppSystem.String.Format("Physics Shape at {0} has less than 3 vertices ({1}).", (Il2CppSystem.Object)(object)i, (Il2CppSystem.Object)(object)((Il2CppArrayBase)val).Length));
			}
		}
		OverridePhysicsShapeCount(this, ((ICollection<Il2CppStructArray<Vector2>>)(object)physicsShapes).Count);
		for (int j = 0; j < ((ICollection<Il2CppStructArray<Vector2>>)(object)physicsShapes).Count; j++)
		{
			OverridePhysicsShape(this, physicsShapes[j], j);
		}
	}

	public static void OverridePhysicsShapeCount(Sprite sprite, int physicsShapeCount)
	{
		OverridePhysicsShapeCount_Injected(MarshalledUnityObject.Marshal(sprite), physicsShapeCount);
	}

	public unsafe static void OverridePhysicsShape(Sprite sprite, Il2CppStructArray<Vector2> physicsShape, int idx)
	{
		//IL_001d: Expected O, but got Ref
		//IL_0024: Expected O, but got Ref
		//IL_0030: Expected O, but got Ref
		if (physicsShape == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object)(object)physicsShape, "physicsShape");
		}
		System.IntPtr sprite2 = MarshalledUnityObject.Marshal(sprite);
		Unsafe.SkipInit(out Il2CppSystem.Span<Vector2> span);
		((Il2CppSystem.Span<Vector2>)(&span))._002Ector((Il2CppArrayBase<Vector2>)(object)physicsShape);
		fixed (Vector2* begin = &((Il2CppSystem.Span<Vector2>)(&span)).GetPinnableReference())
		{
			ManagedSpanWrapper physicsShape2 = new ManagedSpanWrapper(begin, ((Il2CppSystem.Span<Vector2>)(&span)).Length);
			OverridePhysicsShape_Injected(sprite2, ref physicsShape2, idx);
		}
	}

	public unsafe void OverrideGeometry(Il2CppStructArray<Vector2> vertices, Il2CppStructArray<ushort> triangles)
	{
		//IL_0036: Expected O, but got Ref
		//IL_003d: Expected O, but got Ref
		//IL_0049: Expected O, but got Ref
		//IL_0059: Expected O, but got Ref
		//IL_0060: Expected O, but got Ref
		//IL_006e: Expected O, but got Ref
		if (vertices == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object)(object)vertices, "vertices");
		}
		if (triangles == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object)(object)triangles, "triangles");
		}
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		Unsafe.SkipInit(out Il2CppSystem.Span<Vector2> span);
		((Il2CppSystem.Span<Vector2>)(&span))._002Ector((Il2CppArrayBase<Vector2>)(object)vertices);
		fixed (Vector2* begin = &((Il2CppSystem.Span<Vector2>)(&span)).GetPinnableReference())
		{
			ManagedSpanWrapper managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.Span<Vector2>)(&span)).Length);
			Unsafe.SkipInit(out Il2CppSystem.Span<ushort> span2);
			((Il2CppSystem.Span<ushort>)(&span2))._002Ector((Il2CppArrayBase<ushort>)(object)triangles);
			fixed (ushort* begin2 = &((Il2CppSystem.Span<ushort>)(&span2)).GetPinnableReference())
			{
				ManagedSpanWrapper managedSpanWrapper2 = new ManagedSpanWrapper(begin2, ((Il2CppSystem.Span<ushort>)(&span2)).Length);
				OverrideGeometry_Injected(intPtr, ref managedSpanWrapper, ref managedSpanWrapper2);
			}
		}
	}

	public static Sprite Create(Rect rect, Vector2 pivot, float pixelsToUnits, Texture2D texture)
	{
		return CreateSpriteWithoutTextureScripting(rect, pivot, pixelsToUnits, texture);
	}

	public static Sprite Create(Rect rect, Vector2 pivot, float pixelsToUnits)
	{
		return CreateSpriteWithoutTextureScripting(rect, pivot, pixelsToUnits, null);
	}

	public unsafe static System.IntPtr CreateSpriteWithoutTextureScripting_Injected([In] ref Rect rect, [In] ref Vector2 pivot, float pixelsToUnits, System.IntPtr texture)
	{
		return CreateSpriteWithoutTextureScripting_InjectedDelegateField((nint)Unsafe.AsPointer(ref rect), (nint)Unsafe.AsPointer(ref pivot), pixelsToUnits, texture);
	}

	public static uint get_extrude_Injected(System.IntPtr _unity_self)
	{
		return get_extrude_InjectedDelegateField(_unity_self);
	}

	public static System.IntPtr GetSecondaryTexture_Injected(System.IntPtr _unity_self, int index)
	{
		return GetSecondaryTexture_InjectedDelegateField(_unity_self, index);
	}

	public static int GetSecondaryTextureCount_Injected(System.IntPtr _unity_self)
	{
		return GetSecondaryTextureCount_InjectedDelegateField(_unity_self);
	}

	public static int GetSecondaryTextures_Injected(System.IntPtr _unity_self, Il2CppReferenceArray<SecondarySpriteTexture> secondaryTexture)
	{
		return GetSecondaryTextures_InjectedDelegateField(_unity_self, IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)secondaryTexture));
	}

	public static float get_spriteAtlasTextureScale_Injected(System.IntPtr _unity_self)
	{
		return get_spriteAtlasTextureScale_InjectedDelegateField(_unity_self);
	}

	public static int GetPhysicsShapeCount_Injected(System.IntPtr _unity_self)
	{
		return GetPhysicsShapeCount_InjectedDelegateField(_unity_self);
	}

	public static uint GetScriptableObjectsCount_Injected(System.IntPtr _unity_self)
	{
		return GetScriptableObjectsCount_InjectedDelegateField(_unity_self);
	}

	public static uint GetScriptableObjects_Injected(System.IntPtr _unity_self, Il2CppReferenceArray<ScriptableObject> scriptableObjects)
	{
		return GetScriptableObjects_InjectedDelegateField(_unity_self, IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)scriptableObjects));
	}

	public static bool AddScriptableObject_Injected(System.IntPtr _unity_self, System.IntPtr obj)
	{
		return AddScriptableObject_InjectedDelegateField(_unity_self, obj);
	}

	public static bool RemoveScriptableObjectAt_Injected(System.IntPtr _unity_self, uint i)
	{
		return RemoveScriptableObjectAt_InjectedDelegateField(_unity_self, i);
	}

	public static bool SetScriptableObjectAt_Injected(System.IntPtr _unity_self, System.IntPtr obj, uint i)
	{
		return SetScriptableObjectAt_InjectedDelegateField(_unity_self, obj, i);
	}

	public static int Internal_GetPhysicsShapePointCount_Injected(System.IntPtr _unity_self, int shapeIdx)
	{
		return Internal_GetPhysicsShapePointCount_InjectedDelegateField(_unity_self, shapeIdx);
	}

	public unsafe static void GetPhysicsShapeImpl_Injected(System.IntPtr sprite, int shapeIdx, ref BlittableListWrapper physicsShape)
	{
		GetPhysicsShapeImpl_InjectedDelegateField(sprite, shapeIdx, (nint)Unsafe.AsPointer(ref physicsShape));
	}

	public static void OverridePhysicsShapeCount_Injected(System.IntPtr sprite, int physicsShapeCount)
	{
		OverridePhysicsShapeCount_InjectedDelegateField(sprite, physicsShapeCount);
	}

	public unsafe static void OverridePhysicsShape_Injected(System.IntPtr sprite, ref ManagedSpanWrapper physicsShape, int idx)
	{
		OverridePhysicsShape_InjectedDelegateField(sprite, (nint)Unsafe.AsPointer(ref physicsShape), idx);
	}

	public unsafe static void OverrideGeometry_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper vertices, ref ManagedSpanWrapper triangles)
	{
		OverrideGeometry_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref vertices), (nint)Unsafe.AsPointer(ref triangles));
	}
}
