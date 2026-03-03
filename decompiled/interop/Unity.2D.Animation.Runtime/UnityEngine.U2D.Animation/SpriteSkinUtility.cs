using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Unity.Collections;
using Unity.Mathematics;
using UnityEngine.Rendering;

namespace UnityEngine.U2D.Animation;

public static class SpriteSkinUtility : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_CanUseGpuDeformation_Internal_Static_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsUsingGpuDeformation_Internal_Static_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsGpuDeformationActive_Internal_Static_Boolean_SpriteRenderer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CanSpriteSkinUseGpuDeformation_Internal_Static_Boolean_SpriteSkin_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Validate_Internal_Static_SpriteSkinState_SpriteSkin_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateBoneHierarchy_Internal_Static_Void_SpriteSkin_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetVertexStreamSize_Internal_Static_Int32_Sprite_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetVertexStreamOffset_Internal_Static_Int32_Sprite_VertexAttribute_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateGameObject_Private_Static_Void_Int32_Il2CppReferenceArray_1_SpriteBone_Il2CppReferenceArray_1_Transform_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHash_Private_Static_Int32_Matrix4x4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalculateTransformHash_Internal_Static_Int32_SpriteSkin_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Deform_Internal_Static_Void_Sprite_Matrix4x4_NativeSlice_1_Vector3_NativeSlice_1_Vector4_NativeSlice_1_BoneWeight_NativeArray_1_Matrix4x4_NativeSlice_1_Matrix4x4_NativeArray_1_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Deform_Internal_Static_Void_float4x4_NativeSlice_1_float3_NativeSlice_1_BoneWeight_NativeArray_1_float4x4_NativeSlice_1_float4x4_NativeSlice_1_float3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Deform_Internal_Static_Void_float4x4_NativeSlice_1_float3_NativeSlice_1_float4_NativeSlice_1_BoneWeight_NativeArray_1_float4x4_NativeSlice_1_float4x4_NativeSlice_1_float3_NativeSlice_1_float4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Deform_Internal_Static_Void_Sprite_Matrix4x4_Il2CppReferenceArray_1_Transform_NativeArray_1_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Bake_Internal_Static_Void_SpriteSkin_NativeArray_1_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalculateBounds_Internal_Static_Void_SpriteSkin_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalculateSpriteSkinBounds_Internal_Static_Bounds_NativeSlice_1_float3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateBounds_Internal_Static_Void_SpriteSkin_NativeArray_1_Byte_0;

	static SpriteSkinUtility()
	{
		Il2CppClassPointerStore<SpriteSkinUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.2D.Animation.Runtime.dll", "UnityEngine.U2D.Animation", "SpriteSkinUtility");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpriteSkinUtility>.NativeClassPtr);
		NativeMethodInfoPtr_CanUseGpuDeformation_Internal_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteSkinUtility>.NativeClassPtr, 100663733);
		NativeMethodInfoPtr_IsUsingGpuDeformation_Internal_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteSkinUtility>.NativeClassPtr, 100663734);
		NativeMethodInfoPtr_IsGpuDeformationActive_Internal_Static_Boolean_SpriteRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteSkinUtility>.NativeClassPtr, 100663735);
		NativeMethodInfoPtr_CanSpriteSkinUseGpuDeformation_Internal_Static_Boolean_SpriteSkin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteSkinUtility>.NativeClassPtr, 100663736);
		NativeMethodInfoPtr_Validate_Internal_Static_SpriteSkinState_SpriteSkin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteSkinUtility>.NativeClassPtr, 100663737);
		NativeMethodInfoPtr_CreateBoneHierarchy_Internal_Static_Void_SpriteSkin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteSkinUtility>.NativeClassPtr, 100663738);
		NativeMethodInfoPtr_GetVertexStreamSize_Internal_Static_Int32_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteSkinUtility>.NativeClassPtr, 100663739);
		NativeMethodInfoPtr_GetVertexStreamOffset_Internal_Static_Int32_Sprite_VertexAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteSkinUtility>.NativeClassPtr, 100663740);
		NativeMethodInfoPtr_CreateGameObject_Private_Static_Void_Int32_Il2CppReferenceArray_1_SpriteBone_Il2CppReferenceArray_1_Transform_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteSkinUtility>.NativeClassPtr, 100663741);
		NativeMethodInfoPtr_GetHash_Private_Static_Int32_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteSkinUtility>.NativeClassPtr, 100663742);
		NativeMethodInfoPtr_CalculateTransformHash_Internal_Static_Int32_SpriteSkin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteSkinUtility>.NativeClassPtr, 100663743);
		NativeMethodInfoPtr_Deform_Internal_Static_Void_Sprite_Matrix4x4_NativeSlice_1_Vector3_NativeSlice_1_Vector4_NativeSlice_1_BoneWeight_NativeArray_1_Matrix4x4_NativeSlice_1_Matrix4x4_NativeArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteSkinUtility>.NativeClassPtr, 100663744);
		NativeMethodInfoPtr_Deform_Internal_Static_Void_float4x4_NativeSlice_1_float3_NativeSlice_1_BoneWeight_NativeArray_1_float4x4_NativeSlice_1_float4x4_NativeSlice_1_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteSkinUtility>.NativeClassPtr, 100663745);
		NativeMethodInfoPtr_Deform_Internal_Static_Void_float4x4_NativeSlice_1_float3_NativeSlice_1_float4_NativeSlice_1_BoneWeight_NativeArray_1_float4x4_NativeSlice_1_float4x4_NativeSlice_1_float3_NativeSlice_1_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteSkinUtility>.NativeClassPtr, 100663746);
		NativeMethodInfoPtr_Deform_Internal_Static_Void_Sprite_Matrix4x4_Il2CppReferenceArray_1_Transform_NativeArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteSkinUtility>.NativeClassPtr, 100663747);
		NativeMethodInfoPtr_Bake_Internal_Static_Void_SpriteSkin_NativeArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteSkinUtility>.NativeClassPtr, 100663748);
		NativeMethodInfoPtr_CalculateBounds_Internal_Static_Void_SpriteSkin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteSkinUtility>.NativeClassPtr, 100663749);
		NativeMethodInfoPtr_CalculateSpriteSkinBounds_Internal_Static_Bounds_NativeSlice_1_float3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteSkinUtility>.NativeClassPtr, 100663750);
		NativeMethodInfoPtr_UpdateBounds_Internal_Static_Void_SpriteSkin_NativeArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteSkinUtility>.NativeClassPtr, 100663751);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 957963, XrefRangeEnd = 957964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool CanUseGpuDeformation()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CanUseGpuDeformation_Internal_Static_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 957984, RefRangeEnd = 957990, XrefRangeStart = 957964, XrefRangeEnd = 957984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsUsingGpuDeformation()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsUsingGpuDeformation_Internal_Static_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 957990, XrefRangeEnd = 957993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsGpuDeformationActive(SpriteRenderer spriteRenderer)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)spriteRenderer);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsGpuDeformationActive_Internal_Static_Boolean_SpriteRenderer_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 958012, RefRangeEnd = 958014, XrefRangeStart = 957993, XrefRangeEnd = 958012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool CanSpriteSkinUseGpuDeformation(SpriteSkin spriteSkin)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)spriteSkin);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CanSpriteSkinUseGpuDeformation_Internal_Static_Boolean_SpriteSkin_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(15)]
	[CachedScanResults(RefRangeStart = 958026, RefRangeEnd = 958041, XrefRangeStart = 958014, XrefRangeEnd = 958026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static SpriteSkinState Validate(this SpriteSkin spriteSkin)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)spriteSkin);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Validate_Internal_Static_SpriteSkinState_SpriteSkin_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(SpriteSkinState*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 958041, XrefRangeEnd = 958072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CreateBoneHierarchy(this SpriteSkin spriteSkin)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)spriteSkin);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateBoneHierarchy_Internal_Static_Void_SpriteSkin_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 958072, XrefRangeEnd = 958074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetVertexStreamSize(this Sprite sprite)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sprite);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetVertexStreamSize_Internal_Static_Int32_Sprite_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 958074, XrefRangeEnd = 958080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetVertexStreamOffset(this Sprite sprite, VertexAttribute channel)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sprite);
		*(VertexAttribute**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &channel;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetVertexStreamOffset_Internal_Static_Int32_Sprite_VertexAttribute_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 958106, RefRangeEnd = 958108, XrefRangeStart = 958080, XrefRangeEnd = 958106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CreateGameObject(int index, Il2CppReferenceArray<SpriteBone> spriteBones, Il2CppReferenceArray<Transform> transforms, Transform root)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&index);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)spriteBones);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)transforms);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)root);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateGameObject_Private_Static_Void_Int32_Il2CppReferenceArray_1_SpriteBone_Il2CppReferenceArray_1_Transform_Transform_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 958108, XrefRangeEnd = 958109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetHash(Matrix4x4 matrix)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&matrix);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHash_Private_Static_Int32_Matrix4x4_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 958109, XrefRangeEnd = 958115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int CalculateTransformHash(this SpriteSkin spriteSkin)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)spriteSkin);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalculateTransformHash_Internal_Static_Int32_SpriteSkin_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 958155, RefRangeEnd = 958156, XrefRangeStart = 958115, XrefRangeEnd = 958155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Deform(Sprite sprite, Matrix4x4 rootInv, NativeSlice<Vector3> vertices, NativeSlice<Vector4> tangents, NativeSlice<BoneWeight> boneWeights, NativeArray<Matrix4x4> boneTransforms, NativeSlice<Matrix4x4> bindPoses, NativeArray<byte> deformableVertices)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[8];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sprite);
		*(Matrix4x4**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &rootInv;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)vertices));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)tangents));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)boneWeights));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)boneTransforms));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)bindPoses));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)deformableVertices));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Deform_Internal_Static_Void_Sprite_Matrix4x4_NativeSlice_1_Vector3_NativeSlice_1_Vector4_NativeSlice_1_BoneWeight_NativeArray_1_Matrix4x4_NativeSlice_1_Matrix4x4_NativeArray_1_Byte_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 958197, RefRangeEnd = 958198, XrefRangeStart = 958156, XrefRangeEnd = 958197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Deform(float4x4 rootInv, NativeSlice<float3> vertices, NativeSlice<BoneWeight> boneWeights, NativeArray<float4x4> boneTransforms, NativeSlice<float4x4> bindPoses, NativeSlice<float3> deformed)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&rootInv);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)vertices));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)boneWeights));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)boneTransforms));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)bindPoses));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)deformed));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Deform_Internal_Static_Void_float4x4_NativeSlice_1_float3_NativeSlice_1_BoneWeight_NativeArray_1_float4x4_NativeSlice_1_float4x4_NativeSlice_1_float3_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 958264, RefRangeEnd = 958265, XrefRangeStart = 958198, XrefRangeEnd = 958264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Deform(float4x4 rootInv, NativeSlice<float3> vertices, NativeSlice<float4> tangents, NativeSlice<BoneWeight> boneWeights, NativeArray<float4x4> boneTransforms, NativeSlice<float4x4> bindPoses, NativeSlice<float3> deformed, NativeSlice<float4> deformedTangents)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[8];
		*ptr = (nint)(&rootInv);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)vertices));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)tangents));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)boneWeights));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)boneTransforms));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)bindPoses));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)deformed));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)deformedTangents));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Deform_Internal_Static_Void_float4x4_NativeSlice_1_float3_NativeSlice_1_float4_NativeSlice_1_BoneWeight_NativeArray_1_float4x4_NativeSlice_1_float4x4_NativeSlice_1_float3_NativeSlice_1_float4_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 958287, RefRangeEnd = 958290, XrefRangeStart = 958265, XrefRangeEnd = 958287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Deform(Sprite sprite, Matrix4x4 invRoot, Il2CppReferenceArray<Transform> boneTransformsArray, NativeArray<byte> deformVertexData)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sprite);
		*(Matrix4x4**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &invRoot;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)boneTransformsArray);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)deformVertexData));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Deform_Internal_Static_Void_Sprite_Matrix4x4_Il2CppReferenceArray_1_Transform_NativeArray_1_Byte_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 958290, XrefRangeEnd = 958295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Bake(this SpriteSkin spriteSkin, NativeArray<byte> deformVertexData)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)spriteSkin);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)deformVertexData));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Bake_Internal_Static_Void_SpriteSkin_NativeArray_1_Byte_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 958295, XrefRangeEnd = 958319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CalculateBounds(this SpriteSkin spriteSkin)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)spriteSkin);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalculateBounds_Internal_Static_Void_SpriteSkin_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 958335, RefRangeEnd = 958337, XrefRangeStart = 958319, XrefRangeEnd = 958335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Bounds CalculateSpriteSkinBounds(NativeSlice<float3> deformablePositions)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)deformablePositions));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalculateSpriteSkinBounds_Internal_Static_Bounds_NativeSlice_1_float3_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Bounds*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 958348, RefRangeEnd = 958350, XrefRangeStart = 958337, XrefRangeEnd = 958348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void UpdateBounds(this SpriteSkin spriteSkin, NativeArray<byte> deformedVertices)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)spriteSkin);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)deformedVertices));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateBounds_Internal_Static_Void_SpriteSkin_NativeArray_1_Byte_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public SpriteSkinUtility(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
