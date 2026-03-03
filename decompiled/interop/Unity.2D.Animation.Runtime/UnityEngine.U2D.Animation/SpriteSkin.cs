using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Unity.Collections;
using Unity.Profiling;

namespace UnityEngine.U2D.Animation;

public sealed class SpriteSkin : MonoBehaviour
{
	public static class Profiling : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_cacheCurrentSprite;

		private static readonly System.IntPtr NativeFieldInfoPtr_cacheHierarchy;

		private static readonly System.IntPtr NativeFieldInfoPtr_getSpriteBonesTransformFromGuid;

		private static readonly System.IntPtr NativeFieldInfoPtr_getSpriteBonesTransformFromPath;

		public unsafe static ProfilerMarker cacheCurrentSprite
		{
			get
			{
				Unsafe.SkipInit(out ProfilerMarker result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_cacheCurrentSprite, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_cacheCurrentSprite, (void*)(&value));
			}
		}

		public unsafe static ProfilerMarker cacheHierarchy
		{
			get
			{
				Unsafe.SkipInit(out ProfilerMarker result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_cacheHierarchy, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_cacheHierarchy, (void*)(&value));
			}
		}

		public unsafe static ProfilerMarker getSpriteBonesTransformFromGuid
		{
			get
			{
				Unsafe.SkipInit(out ProfilerMarker result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_getSpriteBonesTransformFromGuid, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_getSpriteBonesTransformFromGuid, (void*)(&value));
			}
		}

		public unsafe static ProfilerMarker getSpriteBonesTransformFromPath
		{
			get
			{
				Unsafe.SkipInit(out ProfilerMarker result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_getSpriteBonesTransformFromPath, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_getSpriteBonesTransformFromPath, (void*)(&value));
			}
		}

		static Profiling()
		{
			Il2CppClassPointerStore<Profiling>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpriteSkin>.NativeClassPtr, "Profiling");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Profiling>.NativeClassPtr);
			NativeFieldInfoPtr_cacheCurrentSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Profiling>.NativeClassPtr, "cacheCurrentSprite");
			NativeFieldInfoPtr_cacheHierarchy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Profiling>.NativeClassPtr, "cacheHierarchy");
			NativeFieldInfoPtr_getSpriteBonesTransformFromGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Profiling>.NativeClassPtr, "getSpriteBonesTransformFromGuid");
			NativeFieldInfoPtr_getSpriteBonesTransformFromPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Profiling>.NativeClassPtr, "getSpriteBonesTransformFromPath");
		}

		public Profiling(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public sealed class TransformData : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_fullName;

		private static readonly System.IntPtr NativeFieldInfoPtr_transform;

		public unsafe string fullName
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fullName);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fullName)), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		public unsafe Transform transform
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_transform);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_transform)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		static TransformData()
		{
			Il2CppClassPointerStore<TransformData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpriteSkin>.NativeClassPtr, "TransformData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TransformData>.NativeClassPtr);
			NativeFieldInfoPtr_fullName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformData>.NativeClassPtr, "fullName");
			NativeFieldInfoPtr_transform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformData>.NativeClassPtr, "transform");
		}

		public TransformData(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public TransformData()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TransformData>.NativeClassPtr))
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_m_RootBone;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_BoneTransforms;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Bounds;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_AlwaysUpdate;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_AutoRebind;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_DeformedVertices;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CurrentDeformVerticesLength;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_SpriteRenderer;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CurrentDeformSprite;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_SpriteId;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_IsValid;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_State;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_TransformsHash;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ForceCpuDeformation;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_TextureId;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_TransformId;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_BoneTransformId;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_RootBoneTransformId;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_SpriteVertices;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_SpriteTangents;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_SpriteBoneWeights;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_SpriteBindPoses;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_BoneTransformIdNativeSlice;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_SpriteHasTangents;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_SpriteVertexStreamSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_SpriteVertexCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_SpriteTangentVertexOffset;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_DataIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_BoneCacheUpdateToDate;

	private static readonly System.IntPtr NativeFieldInfoPtr_hierarchyCache;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_OutlineIndexCache;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_StaticOutlineVertexCache;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_DeformedOutlineVertexCache;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_VertexDeformationHash;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Sprite;

	private static readonly System.IntPtr NativeFieldInfoPtr__currentDeformationMethod_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__deformationSystem_k__BackingField;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_boneTransformId_Internal_get_NativeArray_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_rootBoneTransformId_Internal_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_currentDeformationMethod_Internal_get_DeformationMethods_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_currentDeformationMethod_Private_set_Void_DeformationMethods_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_deformationSystem_Internal_get_BaseDeformationSystem_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_deformationSystem_Private_set_Void_BaseDeformationSystem_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_outlineIndices_Internal_get_NativeArray_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_outlineVertices_Internal_get_NativeArray_1_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_vertexDeformationHash_Internal_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_sprite_Internal_get_Sprite_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_spriteRenderer_Internal_get_SpriteRenderer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_spriteBoneWeights_Internal_get_NativeCustomSlice_1_BoneWeight_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_dataIndex_Internal_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetDataIndex_Internal_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_autoRebind_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_autoRebind_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_boneTransforms_Public_get_Il2CppReferenceArray_1_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetBoneTransforms_Public_SpriteSkinState_Il2CppReferenceArray_1_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_rootBone_Public_get_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetRootBone_Public_SpriteSkinState_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_bounds_Internal_get_Bounds_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_bounds_Internal_set_Void_Bounds_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_alwaysUpdate_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_alwaysUpdate_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_forceCpuDeformation_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_forceCpuDeformation_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResetBindPose_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isValid_Internal_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RefreshBoneTransforms_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnSpriteChanged_Private_Void_SpriteRenderer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CacheBoneTransformIds_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnBoneTransformChanged_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnBeforeSerializeBatch_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnAfterSerializeBatch_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnEditorEnable_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CacheValidFlag_Private_SpriteSkinState_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BatchValidate_Internal_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Reset_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResetBoneTransformIdCache_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDeformedVertices_Internal_NativeByteArray_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasCurrentDeformedVertices_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCurrentDeformedVertices_Internal_NativeArray_1_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCurrentDeformedVertexPositions_Internal_NativeSlice_1_PositionVertex_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCurrentDeformedVertexPositionsAndTangents_Internal_NativeSlice_1_PositionTangentVertex_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDeformedVertexPositionData_Public_IEnumerable_1_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDeformedVertexTangentData_Public_IEnumerable_1_Vector4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DisposeOutlineCaches_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnPreviewUpdate_Public_Virtual_Final_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsInGUIUpdateLoop_Private_Static_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Deform_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PostDeform_Internal_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CacheCurrentSprite_Private_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSpriteDeformationData_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateDeformedOutlineCache_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CacheSpriteOutline_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CacheOutlineIndices_Private_Void_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CacheOutlineVertices_Private_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CopyToSpriteSkinData_Internal_Void_byref_SpriteSkinData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NeedToUpdateDeformationCache_Internal_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CacheHierarchy_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DeactivateSkinning_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResetSprite_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetDeformationSystem_Internal_Void_BaseDeformationSystem_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CountChildren_Private_Static_Int32_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetNewVertexDeformationHash_Private_Static_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe Transform m_RootBone
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RootBone);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RootBone)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppReferenceArray<Transform> m_BoneTransforms
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BoneTransforms);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BoneTransforms)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Bounds m_Bounds
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Bounds);
			return *(Bounds*)num;
		}
		set
		{
			*(Bounds*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Bounds)) = value;
		}
	}

	public unsafe bool m_AlwaysUpdate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AlwaysUpdate);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AlwaysUpdate)) = value;
		}
	}

	public unsafe bool m_AutoRebind
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AutoRebind);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AutoRebind)) = value;
		}
	}

	public unsafe NativeByteArray m_DeformedVertices
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DeformedVertices);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NativeByteArray>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DeformedVertices)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe int m_CurrentDeformVerticesLength
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CurrentDeformVerticesLength);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CurrentDeformVerticesLength)) = value;
		}
	}

	public unsafe SpriteRenderer m_SpriteRenderer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SpriteRenderer);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SpriteRenderer>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SpriteRenderer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe int m_CurrentDeformSprite
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CurrentDeformSprite);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CurrentDeformSprite)) = value;
		}
	}

	public unsafe int m_SpriteId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SpriteId);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SpriteId)) = value;
		}
	}

	public unsafe bool m_IsValid
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_IsValid);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_IsValid)) = value;
		}
	}

	public unsafe SpriteSkinState m_State
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_State);
			return *(SpriteSkinState*)num;
		}
		set
		{
			*(SpriteSkinState*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_State)) = value;
		}
	}

	public unsafe int m_TransformsHash
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TransformsHash);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TransformsHash)) = value;
		}
	}

	public unsafe bool m_ForceCpuDeformation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ForceCpuDeformation);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ForceCpuDeformation)) = value;
		}
	}

	public unsafe int m_TextureId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TextureId);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TextureId)) = value;
		}
	}

	public unsafe int m_TransformId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TransformId);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TransformId)) = value;
		}
	}

	public unsafe NativeArray<int> m_BoneTransformId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BoneTransformId);
			return new NativeArray<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BoneTransformId), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe int m_RootBoneTransformId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RootBoneTransformId);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RootBoneTransformId)) = value;
		}
	}

	public unsafe NativeCustomSlice<Vector3> m_SpriteVertices
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SpriteVertices);
			return new NativeCustomSlice<Vector3>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeCustomSlice<Vector3>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SpriteVertices), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeCustomSlice<Vector3>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeCustomSlice<Vector4> m_SpriteTangents
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SpriteTangents);
			return new NativeCustomSlice<Vector4>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeCustomSlice<Vector4>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SpriteTangents), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeCustomSlice<Vector4>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeCustomSlice<BoneWeight> m_SpriteBoneWeights
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SpriteBoneWeights);
			return new NativeCustomSlice<BoneWeight>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeCustomSlice<BoneWeight>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SpriteBoneWeights), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeCustomSlice<BoneWeight>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeCustomSlice<Matrix4x4> m_SpriteBindPoses
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SpriteBindPoses);
			return new NativeCustomSlice<Matrix4x4>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeCustomSlice<Matrix4x4>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SpriteBindPoses), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeCustomSlice<Matrix4x4>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeCustomSlice<int> m_BoneTransformIdNativeSlice
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BoneTransformIdNativeSlice);
			return new NativeCustomSlice<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeCustomSlice<int>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BoneTransformIdNativeSlice), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeCustomSlice<int>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe bool m_SpriteHasTangents
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SpriteHasTangents);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SpriteHasTangents)) = value;
		}
	}

	public unsafe int m_SpriteVertexStreamSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SpriteVertexStreamSize);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SpriteVertexStreamSize)) = value;
		}
	}

	public unsafe int m_SpriteVertexCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SpriteVertexCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SpriteVertexCount)) = value;
		}
	}

	public unsafe int m_SpriteTangentVertexOffset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SpriteTangentVertexOffset);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SpriteTangentVertexOffset)) = value;
		}
	}

	public unsafe int m_DataIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DataIndex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DataIndex)) = value;
		}
	}

	public unsafe bool m_BoneCacheUpdateToDate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BoneCacheUpdateToDate);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BoneCacheUpdateToDate)) = value;
		}
	}

	public unsafe Dictionary<int, List<TransformData>> hierarchyCache
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hierarchyCache);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, List<TransformData>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hierarchyCache)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe NativeArray<int> m_OutlineIndexCache
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_OutlineIndexCache);
			return new NativeArray<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_OutlineIndexCache), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeArray<Vector3> m_StaticOutlineVertexCache
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_StaticOutlineVertexCache);
			return new NativeArray<Vector3>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<Vector3>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_StaticOutlineVertexCache), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<Vector3>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeArray<Vector3> m_DeformedOutlineVertexCache
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DeformedOutlineVertexCache);
			return new NativeArray<Vector3>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<Vector3>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DeformedOutlineVertexCache), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<Vector3>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe int m_VertexDeformationHash
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_VertexDeformationHash);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_VertexDeformationHash)) = value;
		}
	}

	public unsafe Sprite m_Sprite
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Sprite);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Sprite>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Sprite)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe DeformationMethods _currentDeformationMethod_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__currentDeformationMethod_k__BackingField);
			return *(DeformationMethods*)num;
		}
		set
		{
			*(DeformationMethods*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__currentDeformationMethod_k__BackingField)) = value;
		}
	}

	public unsafe BaseDeformationSystem _deformationSystem_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__deformationSystem_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<BaseDeformationSystem>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__deformationSystem_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe NativeArray<int> boneTransformId
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_boneTransformId_Internal_get_NativeArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new NativeArray<int>(pointer);
		}
	}

	public unsafe int rootBoneTransformId
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_rootBoneTransformId_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe DeformationMethods currentDeformationMethod
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_currentDeformationMethod_Internal_get_DeformationMethods_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(DeformationMethods*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_currentDeformationMethod_Private_set_Void_DeformationMethods_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe BaseDeformationSystem deformationSystem
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_deformationSystem_Internal_get_BaseDeformationSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<BaseDeformationSystem>(intPtr2) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_deformationSystem_Private_set_Void_BaseDeformationSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe NativeArray<int> outlineIndices
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_outlineIndices_Internal_get_NativeArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new NativeArray<int>(pointer);
		}
	}

	public unsafe NativeArray<Vector3> outlineVertices
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_outlineVertices_Internal_get_NativeArray_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new NativeArray<Vector3>(pointer);
		}
	}

	public unsafe int vertexDeformationHash
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_vertexDeformationHash_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe Sprite sprite
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 391880, RefRangeEnd = 391881, XrefRangeStart = 391880, XrefRangeEnd = 391881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_sprite_Internal_get_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
		}
	}

	public unsafe SpriteRenderer spriteRenderer
	{
		[CallerCount(45)]
		[CachedScanResults(RefRangeStart = 162634, RefRangeEnd = 162679, XrefRangeStart = 162634, XrefRangeEnd = 162679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_spriteRenderer_Internal_get_SpriteRenderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<SpriteRenderer>(intPtr2) : null;
		}
	}

	public unsafe NativeCustomSlice<BoneWeight> spriteBoneWeights
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_spriteBoneWeights_Internal_get_NativeCustomSlice_1_BoneWeight_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new NativeCustomSlice<BoneWeight>(pointer);
		}
	}

	public unsafe int dataIndex
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_dataIndex_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool autoRebind
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_autoRebind_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 957123, XrefRangeEnd = 957131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_autoRebind_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe Il2CppReferenceArray<Transform> boneTransforms
	{
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 42604, RefRangeEnd = 42610, XrefRangeStart = 42604, XrefRangeEnd = 42610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_boneTransforms_Public_get_Il2CppReferenceArray_1_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
		}
	}

	public unsafe Transform rootBone
	{
		[CallerCount(36)]
		[CachedScanResults(RefRangeStart = 32112, RefRangeEnd = 32148, XrefRangeStart = 32112, XrefRangeEnd = 32148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_rootBone_Public_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
		}
	}

	public unsafe Bounds bounds
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_bounds_Internal_get_Bounds_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Bounds*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_bounds_Internal_set_Void_Bounds_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool alwaysUpdate
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_alwaysUpdate_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_alwaysUpdate_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool forceCpuDeformation
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_forceCpuDeformation_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 957143, XrefRangeEnd = 957146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_forceCpuDeformation_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool isValid
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 957158, XrefRangeEnd = 957159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isValid_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static SpriteSkin()
	{
		Il2CppClassPointerStore<SpriteSkin>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.2D.Animation.Runtime.dll", "UnityEngine.U2D.Animation", "SpriteSkin");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpriteSkin>.NativeClassPtr);
		NativeFieldInfoPtr_m_RootBone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteSkin>.NativeClassPtr, "m_RootBone");
		NativeFieldInfoPtr_m_BoneTransforms = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteSkin>.NativeClassPtr, "m_BoneTransforms");
		NativeFieldInfoPtr_m_Bounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteSkin>.NativeClassPtr, "m_Bounds");
		NativeFieldInfoPtr_m_AlwaysUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteSkin>.NativeClassPtr, "m_AlwaysUpdate");
		NativeFieldInfoPtr_m_AutoRebind = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteSkin>.NativeClassPtr, "m_AutoRebind");
		NativeFieldInfoPtr_m_DeformedVertices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteSkin>.NativeClassPtr, "m_DeformedVertices");
		NativeFieldInfoPtr_m_CurrentDeformVerticesLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteSkin>.NativeClassPtr, "m_CurrentDeformVerticesLength");
		NativeFieldInfoPtr_m_SpriteRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteSkin>.NativeClassPtr, "m_SpriteRenderer");
		NativeFieldInfoPtr_m_CurrentDeformSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteSkin>.NativeClassPtr, "m_CurrentDeformSprite");
		NativeFieldInfoPtr_m_SpriteId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteSkin>.NativeClassPtr, "m_SpriteId");
		NativeFieldInfoPtr_m_IsValid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteSkin>.NativeClassPtr, "m_IsValid");
		NativeFieldInfoPtr_m_State = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteSkin>.NativeClassPtr, "m_State");
		NativeFieldInfoPtr_m_TransformsHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteSkin>.NativeClassPtr, "m_TransformsHash");
		NativeFieldInfoPtr_m_ForceCpuDeformation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteSkin>.NativeClassPtr, "m_ForceCpuDeformation");
		NativeFieldInfoPtr_m_TextureId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteSkin>.NativeClassPtr, "m_TextureId");
		NativeFieldInfoPtr_m_TransformId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteSkin>.NativeClassPtr, "m_TransformId");
		NativeFieldInfoPtr_m_BoneTransformId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteSkin>.NativeClassPtr, "m_BoneTransformId");
		NativeFieldInfoPtr_m_RootBoneTransformId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteSkin>.NativeClassPtr, "m_RootBoneTransformId");
		NativeFieldInfoPtr_m_SpriteVertices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteSkin>.NativeClassPtr, "m_SpriteVertices");
		NativeFieldInfoPtr_m_SpriteTangents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteSkin>.NativeClassPtr, "m_SpriteTangents");
		NativeFieldInfoPtr_m_SpriteBoneWeights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteSkin>.NativeClassPtr, "m_SpriteBoneWeights");
		NativeFieldInfoPtr_m_SpriteBindPoses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteSkin>.NativeClassPtr, "m_SpriteBindPoses");
		NativeFieldInfoPtr_m_BoneTransformIdNativeSlice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteSkin>.NativeClassPtr, "m_BoneTransformIdNativeSlice");
		NativeFieldInfoPtr_m_SpriteHasTangents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteSkin>.NativeClassPtr, "m_SpriteHasTangents");
		NativeFieldInfoPtr_m_SpriteVertexStreamSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteSkin>.NativeClassPtr, "m_SpriteVertexStreamSize");
		NativeFieldInfoPtr_m_SpriteVertexCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteSkin>.NativeClassPtr, "m_SpriteVertexCount");
		NativeFieldInfoPtr_m_SpriteTangentVertexOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteSkin>.NativeClassPtr, "m_SpriteTangentVertexOffset");
		NativeFieldInfoPtr_m_DataIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteSkin>.NativeClassPtr, "m_DataIndex");
		NativeFieldInfoPtr_m_BoneCacheUpdateToDate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteSkin>.NativeClassPtr, "m_BoneCacheUpdateToDate");
		NativeFieldInfoPtr_hierarchyCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteSkin>.NativeClassPtr, "hierarchyCache");
		NativeFieldInfoPtr_m_OutlineIndexCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteSkin>.NativeClassPtr, "m_OutlineIndexCache");
		NativeFieldInfoPtr_m_StaticOutlineVertexCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteSkin>.NativeClassPtr, "m_StaticOutlineVertexCache");
		NativeFieldInfoPtr_m_DeformedOutlineVertexCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteSkin>.NativeClassPtr, "m_DeformedOutlineVertexCache");
		NativeFieldInfoPtr_m_VertexDeformationHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteSkin>.NativeClassPtr, "m_VertexDeformationHash");
		NativeFieldInfoPtr_m_Sprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteSkin>.NativeClassPtr, "m_Sprite");
		NativeFieldInfoPtr__currentDeformationMethod_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteSkin>.NativeClassPtr, "<currentDeformationMethod>k__BackingField");
		NativeFieldInfoPtr__deformationSystem_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteSkin>.NativeClassPtr, "<deformationSystem>k__BackingField");
		NativeMethodInfoPtr_get_boneTransformId_Internal_get_NativeArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteSkin>.NativeClassPtr, 100663636);
		NativeMethodInfoPtr_get_rootBoneTransformId_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteSkin>.NativeClassPtr, 100663637);
		NativeMethodInfoPtr_get_currentDeformationMethod_Internal_get_DeformationMethods_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteSkin>.NativeClassPtr, 100663638);
		NativeMethodInfoPtr_set_currentDeformationMethod_Private_set_Void_DeformationMethods_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteSkin>.NativeClassPtr, 100663639);
		NativeMethodInfoPtr_get_deformationSystem_Internal_get_BaseDeformationSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteSkin>.NativeClassPtr, 100663640);
		NativeMethodInfoPtr_set_deformationSystem_Private_set_Void_BaseDeformationSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteSkin>.NativeClassPtr, 100663641);
		NativeMethodInfoPtr_get_outlineIndices_Internal_get_NativeArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteSkin>.NativeClassPtr, 100663642);
		NativeMethodInfoPtr_get_outlineVertices_Internal_get_NativeArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteSkin>.NativeClassPtr, 100663643);
		NativeMethodInfoPtr_get_vertexDeformationHash_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteSkin>.NativeClassPtr, 100663644);
		NativeMethodInfoPtr_get_sprite_Internal_get_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteSkin>.NativeClassPtr, 100663645);
		NativeMethodInfoPtr_get_spriteRenderer_Internal_get_SpriteRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteSkin>.NativeClassPtr, 100663646);
		NativeMethodInfoPtr_get_spriteBoneWeights_Internal_get_NativeCustomSlice_1_BoneWeight_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteSkin>.NativeClassPtr, 100663647);
		NativeMethodInfoPtr_get_dataIndex_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteSkin>.NativeClassPtr, 100663648);
		NativeMethodInfoPtr_SetDataIndex_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteSkin>.NativeClassPtr, 100663649);
		NativeMethodInfoPtr_get_autoRebind_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteSkin>.NativeClassPtr, 100663650);
		NativeMethodInfoPtr_set_autoRebind_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteSkin>.NativeClassPtr, 100663651);
		NativeMethodInfoPtr_get_boneTransforms_Public_get_Il2CppReferenceArray_1_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteSkin>.NativeClassPtr, 100663652);
		NativeMethodInfoPtr_SetBoneTransforms_Public_SpriteSkinState_Il2CppReferenceArray_1_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteSkin>.NativeClassPtr, 100663653);
		NativeMethodInfoPtr_get_rootBone_Public_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteSkin>.NativeClassPtr, 100663654);
		NativeMethodInfoPtr_SetRootBone_Public_SpriteSkinState_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteSkin>.NativeClassPtr, 100663655);
		NativeMethodInfoPtr_get_bounds_Internal_get_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteSkin>.NativeClassPtr, 100663656);
		NativeMethodInfoPtr_set_bounds_Internal_set_Void_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteSkin>.NativeClassPtr, 100663657);
		NativeMethodInfoPtr_get_alwaysUpdate_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteSkin>.NativeClassPtr, 100663658);
		NativeMethodInfoPtr_set_alwaysUpdate_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteSkin>.NativeClassPtr, 100663659);
		NativeMethodInfoPtr_get_forceCpuDeformation_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteSkin>.NativeClassPtr, 100663660);
		NativeMethodInfoPtr_set_forceCpuDeformation_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteSkin>.NativeClassPtr, 100663661);
		NativeMethodInfoPtr_ResetBindPose_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteSkin>.NativeClassPtr, 100663662);
		NativeMethodInfoPtr_get_isValid_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteSkin>.NativeClassPtr, 100663663);
		NativeMethodInfoPtr_Awake_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteSkin>.NativeClassPtr, 100663664);
		NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteSkin>.NativeClassPtr, 100663665);
		NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteSkin>.NativeClassPtr, 100663666);
		NativeMethodInfoPtr_RefreshBoneTransforms_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteSkin>.NativeClassPtr, 100663667);
		NativeMethodInfoPtr_OnSpriteChanged_Private_Void_SpriteRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteSkin>.NativeClassPtr, 100663668);
		NativeMethodInfoPtr_CacheBoneTransformIds_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteSkin>.NativeClassPtr, 100663669);
		NativeMethodInfoPtr_OnBoneTransformChanged_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteSkin>.NativeClassPtr, 100663670);
		NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteSkin>.NativeClassPtr, 100663671);
		NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteSkin>.NativeClassPtr, 100663672);
		NativeMethodInfoPtr_OnBeforeSerializeBatch_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteSkin>.NativeClassPtr, 100663673);
		NativeMethodInfoPtr_OnAfterSerializeBatch_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteSkin>.NativeClassPtr, 100663674);
		NativeMethodInfoPtr_OnEditorEnable_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteSkin>.NativeClassPtr, 100663675);
		NativeMethodInfoPtr_CacheValidFlag_Private_SpriteSkinState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteSkin>.NativeClassPtr, 100663676);
		NativeMethodInfoPtr_BatchValidate_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteSkin>.NativeClassPtr, 100663677);
		NativeMethodInfoPtr_Reset_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteSkin>.NativeClassPtr, 100663678);
		NativeMethodInfoPtr_ResetBoneTransformIdCache_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteSkin>.NativeClassPtr, 100663679);
		NativeMethodInfoPtr_GetDeformedVertices_Internal_NativeByteArray_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteSkin>.NativeClassPtr, 100663680);
		NativeMethodInfoPtr_HasCurrentDeformedVertices_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteSkin>.NativeClassPtr, 100663681);
		NativeMethodInfoPtr_GetCurrentDeformedVertices_Internal_NativeArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteSkin>.NativeClassPtr, 100663682);
		NativeMethodInfoPtr_GetCurrentDeformedVertexPositions_Internal_NativeSlice_1_PositionVertex_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteSkin>.NativeClassPtr, 100663683);
		NativeMethodInfoPtr_GetCurrentDeformedVertexPositionsAndTangents_Internal_NativeSlice_1_PositionTangentVertex_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteSkin>.NativeClassPtr, 100663684);
		NativeMethodInfoPtr_GetDeformedVertexPositionData_Public_IEnumerable_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteSkin>.NativeClassPtr, 100663685);
		NativeMethodInfoPtr_GetDeformedVertexTangentData_Public_IEnumerable_1_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteSkin>.NativeClassPtr, 100663686);
		NativeMethodInfoPtr_DisposeOutlineCaches_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteSkin>.NativeClassPtr, 100663687);
		NativeMethodInfoPtr_OnPreviewUpdate_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteSkin>.NativeClassPtr, 100663688);
		NativeMethodInfoPtr_IsInGUIUpdateLoop_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteSkin>.NativeClassPtr, 100663689);
		NativeMethodInfoPtr_Deform_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteSkin>.NativeClassPtr, 100663690);
		NativeMethodInfoPtr_PostDeform_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteSkin>.NativeClassPtr, 100663691);
		NativeMethodInfoPtr_CacheCurrentSprite_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteSkin>.NativeClassPtr, 100663692);
		NativeMethodInfoPtr_UpdateSpriteDeformationData_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteSkin>.NativeClassPtr, 100663693);
		NativeMethodInfoPtr_UpdateDeformedOutlineCache_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteSkin>.NativeClassPtr, 100663694);
		NativeMethodInfoPtr_CacheSpriteOutline_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteSkin>.NativeClassPtr, 100663695);
		NativeMethodInfoPtr_CacheOutlineIndices_Private_Void_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteSkin>.NativeClassPtr, 100663696);
		NativeMethodInfoPtr_CacheOutlineVertices_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteSkin>.NativeClassPtr, 100663697);
		NativeMethodInfoPtr_CopyToSpriteSkinData_Internal_Void_byref_SpriteSkinData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteSkin>.NativeClassPtr, 100663698);
		NativeMethodInfoPtr_NeedToUpdateDeformationCache_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteSkin>.NativeClassPtr, 100663699);
		NativeMethodInfoPtr_CacheHierarchy_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteSkin>.NativeClassPtr, 100663700);
		NativeMethodInfoPtr_DeactivateSkinning_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteSkin>.NativeClassPtr, 100663701);
		NativeMethodInfoPtr_ResetSprite_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteSkin>.NativeClassPtr, 100663702);
		NativeMethodInfoPtr_SetDeformationSystem_Internal_Void_BaseDeformationSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteSkin>.NativeClassPtr, 100663703);
		NativeMethodInfoPtr_CountChildren_Private_Static_Int32_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteSkin>.NativeClassPtr, 100663704);
		NativeMethodInfoPtr_GetNewVertexDeformationHash_Private_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteSkin>.NativeClassPtr, 100663705);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteSkin>.NativeClassPtr, 100663706);
	}

	[CallerCount(0)]
	public unsafe void SetDataIndex(int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&index);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetDataIndex_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 957135, RefRangeEnd = 957136, XrefRangeStart = 957131, XrefRangeEnd = 957135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SpriteSkinState SetBoneTransforms(Il2CppReferenceArray<Transform> boneTransformsArray)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)boneTransformsArray);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetBoneTransforms_Public_SpriteSkinState_Il2CppReferenceArray_1_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(SpriteSkinState*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 957136, XrefRangeEnd = 957143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SpriteSkinState SetRootBone(Transform rootBoneTransform)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rootBoneTransform);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetRootBone_Public_SpriteSkinState_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(SpriteSkinState*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 957146, XrefRangeEnd = 957158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool ResetBindPose()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetBindPose_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 957170, RefRangeEnd = 957173, XrefRangeStart = 957159, XrefRangeEnd = 957170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Awake_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 957173, XrefRangeEnd = 957204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnEnable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 957204, XrefRangeEnd = 957228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDisable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 957240, RefRangeEnd = 957247, XrefRangeStart = 957228, XrefRangeEnd = 957240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RefreshBoneTransforms()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RefreshBoneTransforms_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 957247, XrefRangeEnd = 957254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnSpriteChanged(SpriteRenderer updatedSpriteRenderer)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)updatedSpriteRenderer);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnSpriteChanged_Private_Void_SpriteRenderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 957295, RefRangeEnd = 957296, XrefRangeStart = 957254, XrefRangeEnd = 957295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CacheBoneTransformIds()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CacheBoneTransformIds_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 957301, RefRangeEnd = 957302, XrefRangeStart = 957296, XrefRangeEnd = 957301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnBoneTransformChanged()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnBoneTransformChanged_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(19883)]
	[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 20035, XrefRangeStart = 152, XrefRangeEnd = 20035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void OnBeforeSerialize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(19883)]
	[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 20035, XrefRangeStart = 152, XrefRangeEnd = 20035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void OnAfterDeserialize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(19883)]
	[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 20035, XrefRangeStart = 152, XrefRangeEnd = 20035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnBeforeSerializeBatch()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnBeforeSerializeBatch_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(19883)]
	[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 20035, XrefRangeStart = 152, XrefRangeEnd = 20035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnAfterSerializeBatch()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnAfterSerializeBatch_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 957302, XrefRangeEnd = 957303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnEditorEnable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnEditorEnable_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 957303, XrefRangeEnd = 957305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SpriteSkinState CacheValidFlag()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CacheValidFlag_Private_SpriteSkinState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(SpriteSkinState*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 957305, XrefRangeEnd = 957308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool BatchValidate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BatchValidate_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 957308, XrefRangeEnd = 957314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Reset()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Reset_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 957314, XrefRangeEnd = 957317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ResetBoneTransformIdCache()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetBoneTransformIdCache_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 957317, XrefRangeEnd = 957326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe NativeByteArray GetDeformedVertices(int spriteVertexCount)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&spriteVertexCount);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDeformedVertices_Internal_NativeByteArray_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<NativeByteArray>(intPtr2) : null;
	}

	[CallerCount(0)]
	public unsafe bool HasCurrentDeformedVertices()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasCurrentDeformedVertices_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 957341, RefRangeEnd = 957347, XrefRangeStart = 957326, XrefRangeEnd = 957341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe NativeArray<byte> GetCurrentDeformedVertices()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCurrentDeformedVertices_Internal_NativeArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new NativeArray<byte>(pointer);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 957347, XrefRangeEnd = 957356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe NativeSlice<PositionVertex> GetCurrentDeformedVertexPositions()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCurrentDeformedVertexPositions_Internal_NativeSlice_1_PositionVertex_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new NativeSlice<PositionVertex>(pointer);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 957356, XrefRangeEnd = 957365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe NativeSlice<PositionTangentVertex> GetCurrentDeformedVertexPositionsAndTangents()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCurrentDeformedVertexPositionsAndTangents_Internal_NativeSlice_1_PositionTangentVertex_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new NativeSlice<PositionTangentVertex>(pointer);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 957365, XrefRangeEnd = 957379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerable<Vector3> GetDeformedVertexPositionData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDeformedVertexPositionData_Public_IEnumerable_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IEnumerable<Vector3>>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 957379, XrefRangeEnd = 957394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerable<Vector4> GetDeformedVertexTangentData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDeformedVertexTangentData_Public_IEnumerable_1_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IEnumerable<Vector4>>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 957402, RefRangeEnd = 957404, XrefRangeStart = 957394, XrefRangeEnd = 957402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DisposeOutlineCaches()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DisposeOutlineCaches_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(19883)]
	[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 20035, XrefRangeStart = 152, XrefRangeEnd = 20035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void OnPreviewUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnPreviewUpdate_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsInGUIUpdateLoop()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsInGUIUpdateLoop_Private_Static_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 957404, XrefRangeEnd = 957447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Deform()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Deform_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 957456, RefRangeEnd = 957459, XrefRangeStart = 957447, XrefRangeEnd = 957456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PostDeform(bool didDeform)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&didDeform);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PostDeform_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 957499, RefRangeEnd = 957506, XrefRangeStart = 957459, XrefRangeEnd = 957499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CacheCurrentSprite(bool rebind)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&rebind);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CacheCurrentSprite_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 957565, RefRangeEnd = 957569, XrefRangeStart = 957506, XrefRangeEnd = 957565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateSpriteDeformationData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateSpriteDeformationData_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 957569, XrefRangeEnd = 957577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateDeformedOutlineCache()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateDeformedOutlineCache_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 957601, RefRangeEnd = 957602, XrefRangeStart = 957577, XrefRangeEnd = 957601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CacheSpriteOutline()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CacheSpriteOutline_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 957602, XrefRangeEnd = 957610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CacheOutlineIndices(out int maxIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref maxIndex);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CacheOutlineIndices_Private_Void_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 957610, XrefRangeEnd = 957621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CacheOutlineVertices(int cacheSize)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&cacheSize);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CacheOutlineVertices_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 957621, XrefRangeEnd = 957623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CopyToSpriteSkinData(ref SpriteSkinData data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)data);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CopyToSpriteSkinData_Internal_Void_byref_SpriteSkinData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 957633, RefRangeEnd = 957634, XrefRangeStart = 957623, XrefRangeEnd = 957633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool NeedToUpdateDeformationCache()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NeedToUpdateDeformationCache_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 957682, RefRangeEnd = 957685, XrefRangeStart = 957634, XrefRangeEnd = 957682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CacheHierarchy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CacheHierarchy_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(12)]
	[CachedScanResults(RefRangeStart = 957695, RefRangeEnd = 957707, XrefRangeStart = 957685, XrefRangeEnd = 957695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DeactivateSkinning()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DeactivateSkinning_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 957707, XrefRangeEnd = 957709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ResetSprite()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetSprite_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 957709, XrefRangeEnd = 957710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetDeformationSystem(BaseDeformationSystem newDeformationSystem)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newDeformationSystem);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetDeformationSystem_Internal_Void_BaseDeformationSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 957713, RefRangeEnd = 957715, XrefRangeStart = 957710, XrefRangeEnd = 957713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int CountChildren(Transform transform)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)transform);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CountChildren_Private_Static_Int32_Transform_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetNewVertexDeformationHash()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetNewVertexDeformationHash_Private_Static_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 957715, XrefRangeEnd = 957727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SpriteSkin()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpriteSkin>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public SpriteSkin(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
