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
using Unity.Jobs;
using Unity.Mathematics;
using Unity.Profiling;

namespace UnityEngine.U2D.Animation;

public class BaseDeformationSystem : Il2CppSystem.Object
{
	public static class Profiling : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_transformAccessJob;

		private static readonly System.IntPtr NativeFieldInfoPtr_getSpriteSkinBatchData;

		private static readonly System.IntPtr NativeFieldInfoPtr_scheduleJobs;

		private static readonly System.IntPtr NativeFieldInfoPtr_setBatchDeformableBufferAndLocalAABB;

		private static readonly System.IntPtr NativeFieldInfoPtr_setBoneTransformsArray;

		public unsafe static ProfilerMarker transformAccessJob
		{
			get
			{
				Unsafe.SkipInit(out ProfilerMarker result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_transformAccessJob, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_transformAccessJob, (void*)(&value));
			}
		}

		public unsafe static ProfilerMarker getSpriteSkinBatchData
		{
			get
			{
				Unsafe.SkipInit(out ProfilerMarker result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_getSpriteSkinBatchData, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_getSpriteSkinBatchData, (void*)(&value));
			}
		}

		public unsafe static ProfilerMarker scheduleJobs
		{
			get
			{
				Unsafe.SkipInit(out ProfilerMarker result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_scheduleJobs, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_scheduleJobs, (void*)(&value));
			}
		}

		public unsafe static ProfilerMarker setBatchDeformableBufferAndLocalAABB
		{
			get
			{
				Unsafe.SkipInit(out ProfilerMarker result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_setBatchDeformableBufferAndLocalAABB, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_setBatchDeformableBufferAndLocalAABB, (void*)(&value));
			}
		}

		public unsafe static ProfilerMarker setBoneTransformsArray
		{
			get
			{
				Unsafe.SkipInit(out ProfilerMarker result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_setBoneTransformsArray, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_setBoneTransformsArray, (void*)(&value));
			}
		}

		static Profiling()
		{
			Il2CppClassPointerStore<Profiling>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BaseDeformationSystem>.NativeClassPtr, "Profiling");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Profiling>.NativeClassPtr);
			NativeFieldInfoPtr_transformAccessJob = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Profiling>.NativeClassPtr, "transformAccessJob");
			NativeFieldInfoPtr_getSpriteSkinBatchData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Profiling>.NativeClassPtr, "getSpriteSkinBatchData");
			NativeFieldInfoPtr_scheduleJobs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Profiling>.NativeClassPtr, "scheduleJobs");
			NativeFieldInfoPtr_setBatchDeformableBufferAndLocalAABB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Profiling>.NativeClassPtr, "setBatchDeformableBufferAndLocalAABB");
			NativeFieldInfoPtr_setBoneTransformsArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Profiling>.NativeClassPtr, "setBoneTransformsArray");
		}

		public Profiling(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ObjectId;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_SpriteSkins;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_SpriteRenderers;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_SpriteSkinsToAdd;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_SpriteSkinsToRemove;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_TransformIdsToRemove;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_DeformedVerticesBuffer;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_FinalBoneTransforms;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_IsSpriteSkinActiveForDeform;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_SpriteSkinData;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_PerSkinJobData;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_BoundsData;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Buffers;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_BufferSizes;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_BoneTransformBuffers;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_BoneLookupData;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_VertexLookupData;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_SkinBatchArray;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_LocalToWorldTransformAccessJob;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_WorldToLocalTransformAccessJob;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_DeformJobHandle;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_deformationMethod_Public_Abstract_Virtual_New_get_DeformationMethods_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveBoneTransforms_Internal_Void_SpriteSkin_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddBoneTransforms_Internal_Void_SpriteSkin_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateMaterial_Internal_Virtual_New_Void_SpriteSkin_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddSpriteSkin_Internal_Virtual_New_Boolean_SpriteSkin_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CopyToSpriteSkinData_Internal_Void_SpriteSkin_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveSpriteSkin_Internal_Void_SpriteSkin_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSpriteSkins_Internal_HashSet_1_SpriteSkin_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Internal_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitializeArrays_Protected_Virtual_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BatchRemoveSpriteSkins_Protected_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BatchAddSpriteSkins_Protected_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResizeAndCopyArrays_Protected_Virtual_New_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Cleanup_Internal_Virtual_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Update_Internal_Abstract_Virtual_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PrepareDataForDeformation_Protected_Void_byref_JobHandle_byref_JobHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ValidateSpriteSkinData_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GotVerticesToDeform_Protected_Boolean_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SchedulePrepareJob_Protected_JobHandle_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleBoneJobBatched_Protected_JobHandle_JobHandle_PerSkinJobData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleSkinDeformBatchedJob_Protected_JobHandle_JobHandle_PerSkinJobData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleCopySpriteRendererBuffersJob_Protected_JobHandle_JobHandle_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleCalculateSpriteSkinAABBJob_Protected_JobHandle_JobHandle_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DeactivateDeformableBuffers_Protected_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsSpriteSkinActiveForDeformation_Internal_Boolean_SpriteSkin_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDeformableBufferForSpriteSkin_Internal_NativeArray_1_Byte_SpriteSkin_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

	public unsafe int m_ObjectId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ObjectId);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ObjectId)) = value;
		}
	}

	public unsafe HashSet<SpriteSkin> m_SpriteSkins
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SpriteSkins);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<SpriteSkin>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SpriteSkins)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppReferenceArray<SpriteRenderer> m_SpriteRenderers
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SpriteRenderers);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SpriteRenderer>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SpriteRenderers)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe HashSet<SpriteSkin> m_SpriteSkinsToAdd
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SpriteSkinsToAdd);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<SpriteSkin>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SpriteSkinsToAdd)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe HashSet<SpriteSkin> m_SpriteSkinsToRemove
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SpriteSkinsToRemove);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<SpriteSkin>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SpriteSkinsToRemove)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe List<int> m_TransformIdsToRemove
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TransformIdsToRemove);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TransformIdsToRemove)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe NativeByteArray m_DeformedVerticesBuffer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DeformedVerticesBuffer);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NativeByteArray>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DeformedVerticesBuffer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe NativeArray<float4x4> m_FinalBoneTransforms
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_FinalBoneTransforms);
			return new NativeArray<float4x4>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<float4x4>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_FinalBoneTransforms), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<float4x4>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeArray<bool> m_IsSpriteSkinActiveForDeform
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_IsSpriteSkinActiveForDeform);
			return new NativeArray<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<bool>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_IsSpriteSkinActiveForDeform), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<bool>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeArray<SpriteSkinData> m_SpriteSkinData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SpriteSkinData);
			return new NativeArray<SpriteSkinData>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<SpriteSkinData>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SpriteSkinData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<SpriteSkinData>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeArray<PerSkinJobData> m_PerSkinJobData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_PerSkinJobData);
			return new NativeArray<PerSkinJobData>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<PerSkinJobData>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_PerSkinJobData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<PerSkinJobData>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeArray<Bounds> m_BoundsData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BoundsData);
			return new NativeArray<Bounds>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<Bounds>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BoundsData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<Bounds>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeArray<System.IntPtr> m_Buffers
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Buffers);
			return new NativeArray<System.IntPtr>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<System.IntPtr>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Buffers), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<System.IntPtr>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeArray<int> m_BufferSizes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BufferSizes);
			return new NativeArray<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BufferSizes), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeArray<System.IntPtr> m_BoneTransformBuffers
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BoneTransformBuffers);
			return new NativeArray<System.IntPtr>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<System.IntPtr>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BoneTransformBuffers), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<System.IntPtr>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeArray<int2> m_BoneLookupData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BoneLookupData);
			return new NativeArray<int2>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<int2>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BoneLookupData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int2>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeArray<int2> m_VertexLookupData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_VertexLookupData);
			return new NativeArray<int2>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<int2>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_VertexLookupData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int2>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeArray<PerSkinJobData> m_SkinBatchArray
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SkinBatchArray);
			return new NativeArray<PerSkinJobData>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<PerSkinJobData>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SkinBatchArray), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<PerSkinJobData>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe TransformAccessJob m_LocalToWorldTransformAccessJob
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LocalToWorldTransformAccessJob);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TransformAccessJob>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LocalToWorldTransformAccessJob)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe TransformAccessJob m_WorldToLocalTransformAccessJob
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_WorldToLocalTransformAccessJob);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TransformAccessJob>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_WorldToLocalTransformAccessJob)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe JobHandle m_DeformJobHandle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DeformJobHandle);
			return *(JobHandle*)num;
		}
		set
		{
			*(JobHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DeformJobHandle)) = value;
		}
	}

	public unsafe virtual DeformationMethods deformationMethod
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_deformationMethod_Public_Abstract_Virtual_New_get_DeformationMethods_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(DeformationMethods*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static BaseDeformationSystem()
	{
		Il2CppClassPointerStore<BaseDeformationSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.2D.Animation.Runtime.dll", "UnityEngine.U2D.Animation", "BaseDeformationSystem");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BaseDeformationSystem>.NativeClassPtr);
		NativeFieldInfoPtr_m_ObjectId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseDeformationSystem>.NativeClassPtr, "m_ObjectId");
		NativeFieldInfoPtr_m_SpriteSkins = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseDeformationSystem>.NativeClassPtr, "m_SpriteSkins");
		NativeFieldInfoPtr_m_SpriteRenderers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseDeformationSystem>.NativeClassPtr, "m_SpriteRenderers");
		NativeFieldInfoPtr_m_SpriteSkinsToAdd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseDeformationSystem>.NativeClassPtr, "m_SpriteSkinsToAdd");
		NativeFieldInfoPtr_m_SpriteSkinsToRemove = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseDeformationSystem>.NativeClassPtr, "m_SpriteSkinsToRemove");
		NativeFieldInfoPtr_m_TransformIdsToRemove = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseDeformationSystem>.NativeClassPtr, "m_TransformIdsToRemove");
		NativeFieldInfoPtr_m_DeformedVerticesBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseDeformationSystem>.NativeClassPtr, "m_DeformedVerticesBuffer");
		NativeFieldInfoPtr_m_FinalBoneTransforms = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseDeformationSystem>.NativeClassPtr, "m_FinalBoneTransforms");
		NativeFieldInfoPtr_m_IsSpriteSkinActiveForDeform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseDeformationSystem>.NativeClassPtr, "m_IsSpriteSkinActiveForDeform");
		NativeFieldInfoPtr_m_SpriteSkinData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseDeformationSystem>.NativeClassPtr, "m_SpriteSkinData");
		NativeFieldInfoPtr_m_PerSkinJobData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseDeformationSystem>.NativeClassPtr, "m_PerSkinJobData");
		NativeFieldInfoPtr_m_BoundsData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseDeformationSystem>.NativeClassPtr, "m_BoundsData");
		NativeFieldInfoPtr_m_Buffers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseDeformationSystem>.NativeClassPtr, "m_Buffers");
		NativeFieldInfoPtr_m_BufferSizes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseDeformationSystem>.NativeClassPtr, "m_BufferSizes");
		NativeFieldInfoPtr_m_BoneTransformBuffers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseDeformationSystem>.NativeClassPtr, "m_BoneTransformBuffers");
		NativeFieldInfoPtr_m_BoneLookupData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseDeformationSystem>.NativeClassPtr, "m_BoneLookupData");
		NativeFieldInfoPtr_m_VertexLookupData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseDeformationSystem>.NativeClassPtr, "m_VertexLookupData");
		NativeFieldInfoPtr_m_SkinBatchArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseDeformationSystem>.NativeClassPtr, "m_SkinBatchArray");
		NativeFieldInfoPtr_m_LocalToWorldTransformAccessJob = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseDeformationSystem>.NativeClassPtr, "m_LocalToWorldTransformAccessJob");
		NativeFieldInfoPtr_m_WorldToLocalTransformAccessJob = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseDeformationSystem>.NativeClassPtr, "m_WorldToLocalTransformAccessJob");
		NativeFieldInfoPtr_m_DeformJobHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseDeformationSystem>.NativeClassPtr, "m_DeformJobHandle");
		NativeMethodInfoPtr_get_deformationMethod_Public_Abstract_Virtual_New_get_DeformationMethods_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseDeformationSystem>.NativeClassPtr, 100663299);
		NativeMethodInfoPtr_RemoveBoneTransforms_Internal_Void_SpriteSkin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseDeformationSystem>.NativeClassPtr, 100663300);
		NativeMethodInfoPtr_AddBoneTransforms_Internal_Void_SpriteSkin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseDeformationSystem>.NativeClassPtr, 100663301);
		NativeMethodInfoPtr_UpdateMaterial_Internal_Virtual_New_Void_SpriteSkin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseDeformationSystem>.NativeClassPtr, 100663302);
		NativeMethodInfoPtr_AddSpriteSkin_Internal_Virtual_New_Boolean_SpriteSkin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseDeformationSystem>.NativeClassPtr, 100663303);
		NativeMethodInfoPtr_CopyToSpriteSkinData_Internal_Void_SpriteSkin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseDeformationSystem>.NativeClassPtr, 100663304);
		NativeMethodInfoPtr_RemoveSpriteSkin_Internal_Void_SpriteSkin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseDeformationSystem>.NativeClassPtr, 100663305);
		NativeMethodInfoPtr_GetSpriteSkins_Internal_HashSet_1_SpriteSkin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseDeformationSystem>.NativeClassPtr, 100663306);
		NativeMethodInfoPtr_Initialize_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseDeformationSystem>.NativeClassPtr, 100663307);
		NativeMethodInfoPtr_InitializeArrays_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseDeformationSystem>.NativeClassPtr, 100663308);
		NativeMethodInfoPtr_BatchRemoveSpriteSkins_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseDeformationSystem>.NativeClassPtr, 100663309);
		NativeMethodInfoPtr_BatchAddSpriteSkins_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseDeformationSystem>.NativeClassPtr, 100663310);
		NativeMethodInfoPtr_ResizeAndCopyArrays_Protected_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseDeformationSystem>.NativeClassPtr, 100663311);
		NativeMethodInfoPtr_Cleanup_Internal_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseDeformationSystem>.NativeClassPtr, 100663312);
		NativeMethodInfoPtr_Update_Internal_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseDeformationSystem>.NativeClassPtr, 100663313);
		NativeMethodInfoPtr_PrepareDataForDeformation_Protected_Void_byref_JobHandle_byref_JobHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseDeformationSystem>.NativeClassPtr, 100663314);
		NativeMethodInfoPtr_ValidateSpriteSkinData_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseDeformationSystem>.NativeClassPtr, 100663315);
		NativeMethodInfoPtr_GotVerticesToDeform_Protected_Boolean_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseDeformationSystem>.NativeClassPtr, 100663316);
		NativeMethodInfoPtr_SchedulePrepareJob_Protected_JobHandle_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseDeformationSystem>.NativeClassPtr, 100663317);
		NativeMethodInfoPtr_ScheduleBoneJobBatched_Protected_JobHandle_JobHandle_PerSkinJobData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseDeformationSystem>.NativeClassPtr, 100663318);
		NativeMethodInfoPtr_ScheduleSkinDeformBatchedJob_Protected_JobHandle_JobHandle_PerSkinJobData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseDeformationSystem>.NativeClassPtr, 100663319);
		NativeMethodInfoPtr_ScheduleCopySpriteRendererBuffersJob_Protected_JobHandle_JobHandle_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseDeformationSystem>.NativeClassPtr, 100663320);
		NativeMethodInfoPtr_ScheduleCalculateSpriteSkinAABBJob_Protected_JobHandle_JobHandle_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseDeformationSystem>.NativeClassPtr, 100663321);
		NativeMethodInfoPtr_DeactivateDeformableBuffers_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseDeformationSystem>.NativeClassPtr, 100663322);
		NativeMethodInfoPtr_IsSpriteSkinActiveForDeformation_Internal_Boolean_SpriteSkin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseDeformationSystem>.NativeClassPtr, 100663323);
		NativeMethodInfoPtr_GetDeformableBufferForSpriteSkin_Internal_NativeArray_1_Byte_SpriteSkin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseDeformationSystem>.NativeClassPtr, 100663324);
		NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseDeformationSystem>.NativeClassPtr, 100663325);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 953746, RefRangeEnd = 953748, XrefRangeStart = 953737, XrefRangeEnd = 953746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveBoneTransforms(SpriteSkin spriteSkin)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)spriteSkin);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveBoneTransforms_Internal_Void_SpriteSkin_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 953758, RefRangeEnd = 953761, XrefRangeStart = 953748, XrefRangeEnd = 953758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddBoneTransforms(SpriteSkin spriteSkin)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)spriteSkin);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddBoneTransforms_Internal_Void_SpriteSkin_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(19883)]
	[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 20035, XrefRangeStart = 152, XrefRangeEnd = 20035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void UpdateMaterial(SpriteSkin spriteSkin)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)spriteSkin);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_UpdateMaterial_Internal_Virtual_New_Void_SpriteSkin_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 953761, XrefRangeEnd = 953769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual bool AddSpriteSkin(SpriteSkin spriteSkin)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)spriteSkin);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_AddSpriteSkin_Internal_Virtual_New_Boolean_SpriteSkin_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 953773, RefRangeEnd = 953782, XrefRangeStart = 953769, XrefRangeEnd = 953773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CopyToSpriteSkinData(SpriteSkin spriteSkin)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)spriteSkin);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CopyToSpriteSkinData_Internal_Void_SpriteSkin_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 953806, RefRangeEnd = 953808, XrefRangeStart = 953782, XrefRangeEnd = 953806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveSpriteSkin(SpriteSkin spriteSkin)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)spriteSkin);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveSpriteSkin_Internal_Void_SpriteSkin_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(12)]
	[CachedScanResults(RefRangeStart = 25665, RefRangeEnd = 25677, XrefRangeStart = 25665, XrefRangeEnd = 25677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe HashSet<SpriteSkin> GetSpriteSkins()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSpriteSkins_Internal_HashSet_1_SpriteSkin_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<SpriteSkin>>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 953836, RefRangeEnd = 953837, XrefRangeStart = 953808, XrefRangeEnd = 953836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Initialize(int objectId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&objectId);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 953865, RefRangeEnd = 953866, XrefRangeStart = 953837, XrefRangeEnd = 953865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void InitializeArrays()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_InitializeArrays_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 953911, RefRangeEnd = 953914, XrefRangeStart = 953866, XrefRangeEnd = 953911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void BatchRemoveSpriteSkins()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BatchRemoveSpriteSkins_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 953956, RefRangeEnd = 953959, XrefRangeStart = 953914, XrefRangeEnd = 953956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void BatchAddSpriteSkins()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BatchAddSpriteSkins_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 953959, XrefRangeEnd = 953977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void ResizeAndCopyArrays(int updatedCount)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&updatedCount);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ResizeAndCopyArrays_Protected_Virtual_New_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 954018, RefRangeEnd = 954020, XrefRangeStart = 953977, XrefRangeEnd = 954018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Cleanup()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Cleanup_Internal_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Update_Internal_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 954054, RefRangeEnd = 954056, XrefRangeStart = 954020, XrefRangeEnd = 954054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PrepareDataForDeformation(out JobHandle localToWorldJobHandle, out JobHandle worldToLocalJobHandle)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref localToWorldJobHandle);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref worldToLocalJobHandle);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PrepareDataForDeformation_Protected_Void_byref_JobHandle_byref_JobHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 954078, RefRangeEnd = 954079, XrefRangeStart = 954056, XrefRangeEnd = 954078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ValidateSpriteSkinData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ValidateSpriteSkinData_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe bool GotVerticesToDeform(out int vertexBufferSize)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref vertexBufferSize);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GotVerticesToDeform_Protected_Boolean_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 954082, RefRangeEnd = 954084, XrefRangeStart = 954079, XrefRangeEnd = 954082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe JobHandle SchedulePrepareJob(int batchCount)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&batchCount);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SchedulePrepareJob_Protected_JobHandle_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(JobHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 954087, RefRangeEnd = 954089, XrefRangeStart = 954084, XrefRangeEnd = 954087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe JobHandle ScheduleBoneJobBatched(JobHandle jobHandle, PerSkinJobData skinBatch)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&jobHandle);
		*(PerSkinJobData**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &skinBatch;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ScheduleBoneJobBatched_Protected_JobHandle_JobHandle_PerSkinJobData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(JobHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 954095, RefRangeEnd = 954097, XrefRangeStart = 954089, XrefRangeEnd = 954095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe JobHandle ScheduleSkinDeformBatchedJob(JobHandle jobHandle, PerSkinJobData skinBatch)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&jobHandle);
		*(PerSkinJobData**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &skinBatch;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ScheduleSkinDeformBatchedJob_Protected_JobHandle_JobHandle_PerSkinJobData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(JobHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 954104, RefRangeEnd = 954106, XrefRangeStart = 954097, XrefRangeEnd = 954104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe JobHandle ScheduleCopySpriteRendererBuffersJob(JobHandle jobHandle, int batchCount)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&jobHandle);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &batchCount;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ScheduleCopySpriteRendererBuffersJob_Protected_JobHandle_JobHandle_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(JobHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 954112, RefRangeEnd = 954114, XrefRangeStart = 954106, XrefRangeEnd = 954112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe JobHandle ScheduleCalculateSpriteSkinAABBJob(JobHandle jobHandle, int batchCount)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&jobHandle);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &batchCount;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ScheduleCalculateSpriteSkinAABBJob_Protected_JobHandle_JobHandle_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(JobHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 954116, RefRangeEnd = 954118, XrefRangeStart = 954114, XrefRangeEnd = 954116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DeactivateDeformableBuffers()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DeactivateDeformableBuffers_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe bool IsSpriteSkinActiveForDeformation(SpriteSkin spriteSkin)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)spriteSkin);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsSpriteSkinActiveForDeformation_Internal_Boolean_SpriteSkin_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 954118, XrefRangeEnd = 954129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe NativeArray<byte> GetDeformableBufferForSpriteSkin(SpriteSkin spriteSkin)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)spriteSkin);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDeformableBufferForSpriteSkin_Internal_NativeArray_1_Byte_SpriteSkin_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new NativeArray<byte>(pointer);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 954158, RefRangeEnd = 954162, XrefRangeStart = 954129, XrefRangeEnd = 954158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BaseDeformationSystem()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaseDeformationSystem>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public BaseDeformationSystem(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
