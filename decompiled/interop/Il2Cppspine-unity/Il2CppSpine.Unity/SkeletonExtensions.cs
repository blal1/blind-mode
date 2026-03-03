using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppSpine.Unity;

public static class SkeletonExtensions : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_ByteToFloat;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetColor_Public_Static_Color_Skeleton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetColor_Public_Static_Color_RegionAttachment_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetColor_Public_Static_Color_MeshAttachment_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetColor_Public_Static_Color_Slot_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetColorTintBlack_Public_Static_Color_Slot_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetColor_Public_Static_Void_Skeleton_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetColor_Public_Static_Void_Skeleton_Color32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetColor_Public_Static_Void_Slot_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetColor_Public_Static_Void_Slot_Color32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetColor_Public_Static_Void_RegionAttachment_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetColor_Public_Static_Void_RegionAttachment_Color32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetColor_Public_Static_Void_MeshAttachment_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetColor_Public_Static_Void_MeshAttachment_Color32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetLocalScale_Public_Static_Void_Skeleton_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMatrix4x4_Public_Static_Matrix4x4_Bone_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetLocalPosition_Public_Static_Void_Bone_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetLocalPosition_Public_Static_Void_Bone_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLocalPosition_Public_Static_Vector2_Bone_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSkeletonSpacePosition_Public_Static_Vector2_Bone_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSkeletonSpacePosition_Public_Static_Vector2_Bone_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetWorldPosition_Public_Static_Vector3_Bone_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetWorldPosition_Public_Static_Vector3_Bone_Transform_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetWorldPosition_Public_Static_Vector3_Bone_Transform_Single_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetQuaternion_Public_Static_Quaternion_Bone_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLocalQuaternion_Public_Static_Quaternion_Bone_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLocalScale_Public_Static_Vector2_Skeleton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetWorldToLocalMatrix_Public_Static_Void_Bone_byref_Single_byref_Single_byref_Single_byref_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WorldToLocal_Public_Static_Vector2_Bone_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetPositionSkeletonSpace_Public_Static_Vector2_Bone_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMaterial_Public_Static_Material_Attachment_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLocalVertices_Public_Static_Il2CppStructArray_1_Vector2_VertexAttachment_Slot_Il2CppStructArray_1_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetWorldVertices_Public_Static_Il2CppStructArray_1_Vector2_VertexAttachment_Slot_Il2CppStructArray_1_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetWorldPosition_Public_Static_Vector3_PointAttachment_Slot_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetWorldPosition_Public_Static_Vector3_PointAttachment_Bone_Transform_0;

	public unsafe static float ByteToFloat
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ByteToFloat, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ByteToFloat, (void*)(&value));
		}
	}

	static SkeletonExtensions()
	{
		Il2CppClassPointerStore<SkeletonExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("spine-unity.dll", "Spine.Unity", "SkeletonExtensions");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SkeletonExtensions>.NativeClassPtr);
		NativeFieldInfoPtr_ByteToFloat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkeletonExtensions>.NativeClassPtr, "ByteToFloat");
		NativeMethodInfoPtr_GetColor_Public_Static_Color_Skeleton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkeletonExtensions>.NativeClassPtr, 100664138);
		NativeMethodInfoPtr_GetColor_Public_Static_Color_RegionAttachment_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkeletonExtensions>.NativeClassPtr, 100664139);
		NativeMethodInfoPtr_GetColor_Public_Static_Color_MeshAttachment_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkeletonExtensions>.NativeClassPtr, 100664140);
		NativeMethodInfoPtr_GetColor_Public_Static_Color_Slot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkeletonExtensions>.NativeClassPtr, 100664141);
		NativeMethodInfoPtr_GetColorTintBlack_Public_Static_Color_Slot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkeletonExtensions>.NativeClassPtr, 100664142);
		NativeMethodInfoPtr_SetColor_Public_Static_Void_Skeleton_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkeletonExtensions>.NativeClassPtr, 100664143);
		NativeMethodInfoPtr_SetColor_Public_Static_Void_Skeleton_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkeletonExtensions>.NativeClassPtr, 100664144);
		NativeMethodInfoPtr_SetColor_Public_Static_Void_Slot_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkeletonExtensions>.NativeClassPtr, 100664145);
		NativeMethodInfoPtr_SetColor_Public_Static_Void_Slot_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkeletonExtensions>.NativeClassPtr, 100664146);
		NativeMethodInfoPtr_SetColor_Public_Static_Void_RegionAttachment_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkeletonExtensions>.NativeClassPtr, 100664147);
		NativeMethodInfoPtr_SetColor_Public_Static_Void_RegionAttachment_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkeletonExtensions>.NativeClassPtr, 100664148);
		NativeMethodInfoPtr_SetColor_Public_Static_Void_MeshAttachment_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkeletonExtensions>.NativeClassPtr, 100664149);
		NativeMethodInfoPtr_SetColor_Public_Static_Void_MeshAttachment_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkeletonExtensions>.NativeClassPtr, 100664150);
		NativeMethodInfoPtr_SetLocalScale_Public_Static_Void_Skeleton_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkeletonExtensions>.NativeClassPtr, 100664151);
		NativeMethodInfoPtr_GetMatrix4x4_Public_Static_Matrix4x4_Bone_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkeletonExtensions>.NativeClassPtr, 100664152);
		NativeMethodInfoPtr_SetLocalPosition_Public_Static_Void_Bone_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkeletonExtensions>.NativeClassPtr, 100664153);
		NativeMethodInfoPtr_SetLocalPosition_Public_Static_Void_Bone_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkeletonExtensions>.NativeClassPtr, 100664154);
		NativeMethodInfoPtr_GetLocalPosition_Public_Static_Vector2_Bone_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkeletonExtensions>.NativeClassPtr, 100664155);
		NativeMethodInfoPtr_GetSkeletonSpacePosition_Public_Static_Vector2_Bone_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkeletonExtensions>.NativeClassPtr, 100664156);
		NativeMethodInfoPtr_GetSkeletonSpacePosition_Public_Static_Vector2_Bone_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkeletonExtensions>.NativeClassPtr, 100664157);
		NativeMethodInfoPtr_GetWorldPosition_Public_Static_Vector3_Bone_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkeletonExtensions>.NativeClassPtr, 100664158);
		NativeMethodInfoPtr_GetWorldPosition_Public_Static_Vector3_Bone_Transform_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkeletonExtensions>.NativeClassPtr, 100664159);
		NativeMethodInfoPtr_GetWorldPosition_Public_Static_Vector3_Bone_Transform_Single_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkeletonExtensions>.NativeClassPtr, 100664160);
		NativeMethodInfoPtr_GetQuaternion_Public_Static_Quaternion_Bone_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkeletonExtensions>.NativeClassPtr, 100664161);
		NativeMethodInfoPtr_GetLocalQuaternion_Public_Static_Quaternion_Bone_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkeletonExtensions>.NativeClassPtr, 100664162);
		NativeMethodInfoPtr_GetLocalScale_Public_Static_Vector2_Skeleton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkeletonExtensions>.NativeClassPtr, 100664163);
		NativeMethodInfoPtr_GetWorldToLocalMatrix_Public_Static_Void_Bone_byref_Single_byref_Single_byref_Single_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkeletonExtensions>.NativeClassPtr, 100664164);
		NativeMethodInfoPtr_WorldToLocal_Public_Static_Vector2_Bone_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkeletonExtensions>.NativeClassPtr, 100664165);
		NativeMethodInfoPtr_SetPositionSkeletonSpace_Public_Static_Vector2_Bone_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkeletonExtensions>.NativeClassPtr, 100664166);
		NativeMethodInfoPtr_GetMaterial_Public_Static_Material_Attachment_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkeletonExtensions>.NativeClassPtr, 100664167);
		NativeMethodInfoPtr_GetLocalVertices_Public_Static_Il2CppStructArray_1_Vector2_VertexAttachment_Slot_Il2CppStructArray_1_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkeletonExtensions>.NativeClassPtr, 100664168);
		NativeMethodInfoPtr_GetWorldVertices_Public_Static_Il2CppStructArray_1_Vector2_VertexAttachment_Slot_Il2CppStructArray_1_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkeletonExtensions>.NativeClassPtr, 100664169);
		NativeMethodInfoPtr_GetWorldPosition_Public_Static_Vector3_PointAttachment_Slot_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkeletonExtensions>.NativeClassPtr, 100664170);
		NativeMethodInfoPtr_GetWorldPosition_Public_Static_Vector3_PointAttachment_Bone_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkeletonExtensions>.NativeClassPtr, 100664171);
	}

	[CallerCount(0)]
	public unsafe static Color GetColor(this Skeleton s)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)s);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetColor_Public_Static_Color_Skeleton_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Color*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static Color GetColor(this RegionAttachment a)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)a);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetColor_Public_Static_Color_RegionAttachment_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Color*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static Color GetColor(this MeshAttachment a)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)a);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetColor_Public_Static_Color_MeshAttachment_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Color*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static Color GetColor(this Slot s)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)s);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetColor_Public_Static_Color_Slot_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Color*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static Color GetColorTintBlack(this Slot s)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)s);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetColorTintBlack_Public_Static_Color_Slot_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Color*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 857893, RefRangeEnd = 857894, XrefRangeStart = 857893, XrefRangeEnd = 857893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetColor(this Skeleton skeleton, Color color)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)skeleton);
		*(Color**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &color;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetColor_Public_Static_Void_Skeleton_Color_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe static void SetColor(this Skeleton skeleton, Color32 color)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)skeleton);
		*(Color32**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &color;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetColor_Public_Static_Void_Skeleton_Color32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe static void SetColor(this Slot slot, Color color)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)slot);
		*(Color**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &color;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetColor_Public_Static_Void_Slot_Color_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe static void SetColor(this Slot slot, Color32 color)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)slot);
		*(Color32**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &color;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetColor_Public_Static_Void_Slot_Color32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe static void SetColor(this RegionAttachment attachment, Color color)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)attachment);
		*(Color**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &color;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetColor_Public_Static_Void_RegionAttachment_Color_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe static void SetColor(this RegionAttachment attachment, Color32 color)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)attachment);
		*(Color32**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &color;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetColor_Public_Static_Void_RegionAttachment_Color32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe static void SetColor(this MeshAttachment attachment, Color color)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)attachment);
		*(Color**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &color;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetColor_Public_Static_Void_MeshAttachment_Color_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe static void SetColor(this MeshAttachment attachment, Color32 color)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)attachment);
		*(Color32**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &color;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetColor_Public_Static_Void_MeshAttachment_Color32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe static void SetLocalScale(this Skeleton skeleton, Vector2 scale)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)skeleton);
		*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &scale;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetLocalScale_Public_Static_Void_Skeleton_Vector2_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe static Matrix4x4 GetMatrix4x4(this Bone bone)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bone);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMatrix4x4_Public_Static_Matrix4x4_Bone_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Matrix4x4*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static void SetLocalPosition(this Bone bone, Vector2 position)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bone);
		*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &position;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetLocalPosition_Public_Static_Void_Bone_Vector2_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe static void SetLocalPosition(this Bone bone, Vector3 position)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bone);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &position;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetLocalPosition_Public_Static_Void_Bone_Vector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe static Vector2 GetLocalPosition(this Bone bone)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bone);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLocalPosition_Public_Static_Vector2_Bone_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static Vector2 GetSkeletonSpacePosition(this Bone bone)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bone);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSkeletonSpacePosition_Public_Static_Vector2_Bone_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 857894, XrefRangeEnd = 857895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector2 GetSkeletonSpacePosition(this Bone bone, Vector2 boneLocal)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bone);
		*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &boneLocal;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSkeletonSpacePosition_Public_Static_Vector2_Bone_Vector2_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 857895, XrefRangeEnd = 857896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector3 GetWorldPosition(this Bone bone, Transform spineGameObjectTransform)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bone);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)spineGameObjectTransform);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetWorldPosition_Public_Static_Vector3_Bone_Transform_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 857896, XrefRangeEnd = 857897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector3 GetWorldPosition(this Bone bone, Transform spineGameObjectTransform, float positionScale)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bone);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)spineGameObjectTransform);
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &positionScale;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetWorldPosition_Public_Static_Vector3_Bone_Transform_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 857897, XrefRangeEnd = 857898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector3 GetWorldPosition(this Bone bone, Transform spineGameObjectTransform, float positionScale, Vector2 positionOffset)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bone);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)spineGameObjectTransform);
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &positionScale;
		*(Vector2**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &positionOffset;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetWorldPosition_Public_Static_Vector3_Bone_Transform_Single_Vector2_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 857898, XrefRangeEnd = 857901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Quaternion GetQuaternion(this Bone bone)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bone);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetQuaternion_Public_Static_Quaternion_Bone_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Quaternion*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 857901, XrefRangeEnd = 857903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Quaternion GetLocalQuaternion(this Bone bone)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bone);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLocalQuaternion_Public_Static_Quaternion_Bone_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Quaternion*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 857903, XrefRangeEnd = 857904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector2 GetLocalScale(this Skeleton skeleton)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)skeleton);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLocalScale_Public_Static_Vector2_Skeleton_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static void GetWorldToLocalMatrix(this Bone bone, out float ia, out float ib, out float ic, out float id)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bone);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ia);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ib);
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ic);
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref id);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetWorldToLocalMatrix_Public_Static_Void_Bone_byref_Single_byref_Single_byref_Single_byref_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 857904, XrefRangeEnd = 857905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector2 WorldToLocal(this Bone bone, Vector2 worldPosition)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bone);
		*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &worldPosition;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WorldToLocal_Public_Static_Vector2_Bone_Vector2_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 857905, XrefRangeEnd = 857906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector2 SetPositionSkeletonSpace(this Bone bone, Vector2 skeletonSpacePosition)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bone);
		*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &skeletonSpacePosition;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetPositionSkeletonSpace_Public_Static_Vector2_Bone_Vector2_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 857906, XrefRangeEnd = 857916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Material GetMaterial(this Attachment a)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)a);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMaterial_Public_Static_Material_Attachment_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 857920, RefRangeEnd = 857923, XrefRangeStart = 857916, XrefRangeEnd = 857920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<Vector2> GetLocalVertices(this VertexAttachment va, Slot slot, Il2CppStructArray<Vector2> buffer)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)va);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)slot);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buffer);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLocalVertices_Public_Static_Il2CppStructArray_1_Vector2_VertexAttachment_Slot_Il2CppStructArray_1_Vector2_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 857923, XrefRangeEnd = 857930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<Vector2> GetWorldVertices(this VertexAttachment a, Slot slot, Il2CppStructArray<Vector2> buffer)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)a);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)slot);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buffer);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetWorldVertices_Public_Static_Il2CppStructArray_1_Vector2_VertexAttachment_Slot_Il2CppStructArray_1_Vector2_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 857930, XrefRangeEnd = 857932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector3 GetWorldPosition(this PointAttachment attachment, Slot slot, Transform spineGameObjectTransform)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)attachment);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)slot);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)spineGameObjectTransform);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetWorldPosition_Public_Static_Vector3_PointAttachment_Slot_Transform_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 857932, XrefRangeEnd = 857934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector3 GetWorldPosition(this PointAttachment attachment, Bone bone, Transform spineGameObjectTransform)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)attachment);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bone);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)spineGameObjectTransform);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetWorldPosition_Public_Static_Vector3_PointAttachment_Bone_Transform_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public SkeletonExtensions(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
