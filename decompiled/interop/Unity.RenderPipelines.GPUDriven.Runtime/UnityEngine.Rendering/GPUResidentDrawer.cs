using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Unity.Collections;
using Unity.Jobs;
using UnityEngine.Rendering.RenderGraphModule;
using UnityEngine.SceneManagement;

namespace UnityEngine.Rendering;

public class GPUResidentDrawer : Il2CppSystem.Object
{
	public sealed class FindRenderersFromMaterialOrMeshJob : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_materialIDs;

		private static readonly System.IntPtr NativeFieldInfoPtr_materialIDArrays;

		private static readonly System.IntPtr NativeFieldInfoPtr_meshIDs;

		private static readonly System.IntPtr NativeFieldInfoPtr_meshIDArray;

		private static readonly System.IntPtr NativeFieldInfoPtr_rendererGroupIDs;

		private static readonly System.IntPtr NativeFieldInfoPtr_sortedExcludeRendererIDs;

		private static readonly System.IntPtr NativeFieldInfoPtr_selectedRenderGroupsForMaterials;

		private static readonly System.IntPtr NativeFieldInfoPtr_selectedRenderGroupsForMeshes;

		private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_Int32_0;

		public unsafe NativeHashSet<int>.ReadOnly materialIDs
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_materialIDs);
				return new NativeHashSet<int>.ReadOnly(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeHashSet<int>.ReadOnly>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_materialIDs), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeHashSet<int>.ReadOnly>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe NativeArray<SmallIntegerArray>.ReadOnly materialIDArrays
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_materialIDArrays);
				return new NativeArray<SmallIntegerArray>.ReadOnly(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<SmallIntegerArray>.ReadOnly>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_materialIDArrays), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<SmallIntegerArray>.ReadOnly>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe NativeArray<int>.ReadOnly meshIDs
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_meshIDs);
				return new NativeArray<int>.ReadOnly(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<int>.ReadOnly>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_meshIDs), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>.ReadOnly>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe NativeArray<int>.ReadOnly meshIDArray
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_meshIDArray);
				return new NativeArray<int>.ReadOnly(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<int>.ReadOnly>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_meshIDArray), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>.ReadOnly>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe NativeArray<int>.ReadOnly rendererGroupIDs
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rendererGroupIDs);
				return new NativeArray<int>.ReadOnly(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<int>.ReadOnly>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rendererGroupIDs), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>.ReadOnly>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe NativeArray<int>.ReadOnly sortedExcludeRendererIDs
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sortedExcludeRendererIDs);
				return new NativeArray<int>.ReadOnly(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<int>.ReadOnly>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sortedExcludeRendererIDs), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>.ReadOnly>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe NativeList<int>.ParallelWriter selectedRenderGroupsForMaterials
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_selectedRenderGroupsForMaterials);
				return new NativeList<int>.ParallelWriter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeList<int>.ParallelWriter>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_selectedRenderGroupsForMaterials), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<int>.ParallelWriter>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe NativeList<int>.ParallelWriter selectedRenderGroupsForMeshes
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_selectedRenderGroupsForMeshes);
				return new NativeList<int>.ParallelWriter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeList<int>.ParallelWriter>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_selectedRenderGroupsForMeshes), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<int>.ParallelWriter>.NativeClassPtr, ref *(uint*)null));
			}
		}

		static FindRenderersFromMaterialOrMeshJob()
		{
			Il2CppClassPointerStore<FindRenderersFromMaterialOrMeshJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GPUResidentDrawer>.NativeClassPtr, "FindRenderersFromMaterialOrMeshJob");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FindRenderersFromMaterialOrMeshJob>.NativeClassPtr);
			NativeFieldInfoPtr_materialIDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FindRenderersFromMaterialOrMeshJob>.NativeClassPtr, "materialIDs");
			NativeFieldInfoPtr_materialIDArrays = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FindRenderersFromMaterialOrMeshJob>.NativeClassPtr, "materialIDArrays");
			NativeFieldInfoPtr_meshIDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FindRenderersFromMaterialOrMeshJob>.NativeClassPtr, "meshIDs");
			NativeFieldInfoPtr_meshIDArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FindRenderersFromMaterialOrMeshJob>.NativeClassPtr, "meshIDArray");
			NativeFieldInfoPtr_rendererGroupIDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FindRenderersFromMaterialOrMeshJob>.NativeClassPtr, "rendererGroupIDs");
			NativeFieldInfoPtr_sortedExcludeRendererIDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FindRenderersFromMaterialOrMeshJob>.NativeClassPtr, "sortedExcludeRendererIDs");
			NativeFieldInfoPtr_selectedRenderGroupsForMaterials = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FindRenderersFromMaterialOrMeshJob>.NativeClassPtr, "selectedRenderGroupsForMaterials");
			NativeFieldInfoPtr_selectedRenderGroupsForMeshes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FindRenderersFromMaterialOrMeshJob>.NativeClassPtr, "selectedRenderGroupsForMeshes");
			NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FindRenderersFromMaterialOrMeshJob>.NativeClassPtr, 100663496);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1068173, XrefRangeEnd = 1068216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Execute(int startIndex, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&startIndex);
			*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public FindRenderersFromMaterialOrMeshJob(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public FindRenderersFromMaterialOrMeshJob()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FindRenderersFromMaterialOrMeshJob>.NativeClassPtr))
		{
		}
	}

	public static class Strings : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_drawerModeDisabled;

		private static readonly System.IntPtr NativeFieldInfoPtr_allowInEditModeDisabled;

		private static readonly System.IntPtr NativeFieldInfoPtr_notGPUResidentRenderPipeline;

		private static readonly System.IntPtr NativeFieldInfoPtr_rawBufferNotSupportedByPlatform;

		private static readonly System.IntPtr NativeFieldInfoPtr_kernelNotPresent;

		private static readonly System.IntPtr NativeFieldInfoPtr_batchRendererGroupShaderStrippingModeInvalid;

		private static readonly System.IntPtr NativeFieldInfoPtr_visionOSNotSupported;

		public unsafe static string drawerModeDisabled
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_drawerModeDisabled, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_drawerModeDisabled, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		public unsafe static string allowInEditModeDisabled
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_allowInEditModeDisabled, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_allowInEditModeDisabled, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		public unsafe static string notGPUResidentRenderPipeline
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_notGPUResidentRenderPipeline, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_notGPUResidentRenderPipeline, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		public unsafe static string rawBufferNotSupportedByPlatform
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_rawBufferNotSupportedByPlatform, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_rawBufferNotSupportedByPlatform, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		public unsafe static string kernelNotPresent
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kernelNotPresent, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kernelNotPresent, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		public unsafe static string batchRendererGroupShaderStrippingModeInvalid
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_batchRendererGroupShaderStrippingModeInvalid, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_batchRendererGroupShaderStrippingModeInvalid, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		public unsafe static string visionOSNotSupported
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_visionOSNotSupported, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_visionOSNotSupported, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		static Strings()
		{
			Il2CppClassPointerStore<Strings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GPUResidentDrawer>.NativeClassPtr, "Strings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Strings>.NativeClassPtr);
			NativeFieldInfoPtr_drawerModeDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Strings>.NativeClassPtr, "drawerModeDisabled");
			NativeFieldInfoPtr_allowInEditModeDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Strings>.NativeClassPtr, "allowInEditModeDisabled");
			NativeFieldInfoPtr_notGPUResidentRenderPipeline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Strings>.NativeClassPtr, "notGPUResidentRenderPipeline");
			NativeFieldInfoPtr_rawBufferNotSupportedByPlatform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Strings>.NativeClassPtr, "rawBufferNotSupportedByPlatform");
			NativeFieldInfoPtr_kernelNotPresent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Strings>.NativeClassPtr, "kernelNotPresent");
			NativeFieldInfoPtr_batchRendererGroupShaderStrippingModeInvalid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Strings>.NativeClassPtr, "batchRendererGroupShaderStrippingModeInvalid");
			NativeFieldInfoPtr_visionOSNotSupported = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Strings>.NativeClassPtr, "visionOSNotSupported");
		}

		public Strings(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_s_Instance;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ContextIntPtr;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Settings;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_GPUDrivenProcessor;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_BatchersContext;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Batcher;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Dispatcher;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_instance_Internal_Static_get_GPUResidentDrawer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsInstanceOcclusionCullingEnabled_Public_Static_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PostCullBeginCameraRendering_Public_Static_Void_RenderRequestBatcherContext_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InstanceOcclusionTest_Public_Static_Void_RenderGraph_byref_OcclusionCullingSettings_ReadOnlySpan_1_SubviewOcclusionTest_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateInstanceOccluders_Public_Static_Void_RenderGraph_byref_OccluderParameters_ReadOnlySpan_1_OccluderSubviewUpdate_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReinitializeIfNeeded_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RenderDebugOcclusionTestOverlay_Public_Static_Void_RenderGraph_DebugDisplayGPUResidentDrawer_Int32_TextureHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RenderDebugOccluderOverlay_Public_Static_Void_RenderGraph_DebugDisplayGPUResidentDrawer_Vector2_Single_TextureHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDebugStats_Internal_Static_DebugRendererBatcherStats_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InsertIntoPlayerLoop_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveFromPlayerLoop_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsEnabled_Internal_Static_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetGlobalSettingsFromRPAsset_Internal_Static_GPUResidentDrawerSettings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsForcedOnViaCommandLine_Private_Static_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsOcclusionForcedOnViaCommandLine_Private_Static_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Reinitialize_Internal_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CleanUp_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Recreate_Private_Static_Void_GPUResidentDrawerSettings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_batcher_Internal_get_GPUResidentBatcher_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_settings_Internal_get_GPUResidentDrawerSettings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Private_Void_GPUResidentDrawerSettings_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnSceneLoaded_Private_Void_Scene_LoadSceneMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PostPostLateUpdateStatic_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnBeginContextRendering_Private_Void_ScriptableRenderContext_List_1_Camera_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnEndContextRendering_Private_Void_ScriptableRenderContext_List_1_Camera_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnBeginCameraRendering_Private_Void_ScriptableRenderContext_Camera_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnEndCameraRendering_Private_Void_ScriptableRenderContext_Camera_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PostPostLateUpdate_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ProcessMaterials_Private_Void_NativeArray_1_Int32_NativeArray_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ProcessMeshes_Private_Void_NativeArray_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ProcessLODGroups_Private_Void_NativeArray_1_Int32_NativeArray_1_Int32_NativeArray_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ProcessRendererMaterialAndMeshChanges_Private_Void_NativeArray_1_Int32_NativeArray_1_Int32_NativeArray_1_GPUDrivenPackedMaterialData_NativeArray_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ProcessRenderers_Private_Void_TypeDispatchData_NativeArray_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TransformInstances_Private_Void_NativeArray_1_InstanceHandle_NativeArray_1_Matrix4x4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FreeRendererGroupInstances_Private_Void_NativeArray_1_Int32_NativeArray_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleQueryRendererGroupInstancesJob_Private_JobHandle_NativeArray_1_Int32_NativeArray_1_InstanceHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleQueryMeshInstancesJob_Private_JobHandle_NativeArray_1_Int32_NativeList_1_InstanceHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClassifyMaterials_Private_Void_NativeArray_1_Int32_byref_NativeList_1_Int32_byref_NativeList_1_Int32_byref_NativeList_1_GPUDrivenPackedMaterialData_Allocator_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindUnsupportedRenderers_Private_NativeList_1_Int32_NativeArray_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMaterialsWithChangedPackedMaterial_Private_NativeHashSet_1_Int32_NativeArray_1_Int32_NativeArray_1_GPUDrivenPackedMaterialData_Allocator_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindRenderersFromMaterialsOrMeshes_Private_ValueTuple_2_NativeList_1_Int32_NativeList_1_Int32_NativeArray_1_Int32_NativeHashSet_1_Int32_NativeArray_1_Int32_Allocator_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsProjectSupported_Internal_Static_Boolean_byref_String_byref_LogType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsGPUResidentDrawerSupportedBySRP_Internal_Static_Boolean_GPUResidentDrawerSettings_byref_String_byref_LogType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LogMessage_Internal_Static_Void_String_LogType_0;

	public unsafe static GPUResidentDrawer s_Instance
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_Instance, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<GPUResidentDrawer>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_Instance, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe System.IntPtr m_ContextIntPtr
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ContextIntPtr);
			return *(System.IntPtr*)num;
		}
		set
		{
			*(System.IntPtr*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ContextIntPtr)) = value;
		}
	}

	public unsafe GPUResidentDrawerSettings m_Settings
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Settings);
			return new GPUResidentDrawerSettings(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GPUResidentDrawerSettings>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Settings), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GPUResidentDrawerSettings>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe GPUDrivenProcessor m_GPUDrivenProcessor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_GPUDrivenProcessor);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GPUDrivenProcessor>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_GPUDrivenProcessor)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe RenderersBatchersContext m_BatchersContext
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BatchersContext);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RenderersBatchersContext>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BatchersContext)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe GPUResidentBatcher m_Batcher
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Batcher);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GPUResidentBatcher>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Batcher)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe ObjectDispatcher m_Dispatcher
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Dispatcher);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ObjectDispatcher>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Dispatcher)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static GPUResidentDrawer instance
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1068216, XrefRangeEnd = 1068218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_instance_Internal_Static_get_GPUResidentDrawer_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<GPUResidentDrawer>(intPtr2) : null;
		}
	}

	public unsafe GPUResidentBatcher batcher
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_batcher_Internal_get_GPUResidentBatcher_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<GPUResidentBatcher>(intPtr2) : null;
		}
	}

	public unsafe GPUResidentDrawerSettings settings
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_settings_Internal_get_GPUResidentDrawerSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new GPUResidentDrawerSettings(pointer);
		}
	}

	static GPUResidentDrawer()
	{
		Il2CppClassPointerStore<GPUResidentDrawer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.GPUDriven.Runtime.dll", "UnityEngine.Rendering", "GPUResidentDrawer");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GPUResidentDrawer>.NativeClassPtr);
		NativeFieldInfoPtr_s_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUResidentDrawer>.NativeClassPtr, "s_Instance");
		NativeFieldInfoPtr_m_ContextIntPtr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUResidentDrawer>.NativeClassPtr, "m_ContextIntPtr");
		NativeFieldInfoPtr_m_Settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUResidentDrawer>.NativeClassPtr, "m_Settings");
		NativeFieldInfoPtr_m_GPUDrivenProcessor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUResidentDrawer>.NativeClassPtr, "m_GPUDrivenProcessor");
		NativeFieldInfoPtr_m_BatchersContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUResidentDrawer>.NativeClassPtr, "m_BatchersContext");
		NativeFieldInfoPtr_m_Batcher = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUResidentDrawer>.NativeClassPtr, "m_Batcher");
		NativeFieldInfoPtr_m_Dispatcher = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUResidentDrawer>.NativeClassPtr, "m_Dispatcher");
		NativeMethodInfoPtr_get_instance_Internal_Static_get_GPUResidentDrawer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUResidentDrawer>.NativeClassPtr, 100663451);
		NativeMethodInfoPtr_IsInstanceOcclusionCullingEnabled_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUResidentDrawer>.NativeClassPtr, 100663452);
		NativeMethodInfoPtr_PostCullBeginCameraRendering_Public_Static_Void_RenderRequestBatcherContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUResidentDrawer>.NativeClassPtr, 100663453);
		NativeMethodInfoPtr_InstanceOcclusionTest_Public_Static_Void_RenderGraph_byref_OcclusionCullingSettings_ReadOnlySpan_1_SubviewOcclusionTest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUResidentDrawer>.NativeClassPtr, 100663454);
		NativeMethodInfoPtr_UpdateInstanceOccluders_Public_Static_Void_RenderGraph_byref_OccluderParameters_ReadOnlySpan_1_OccluderSubviewUpdate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUResidentDrawer>.NativeClassPtr, 100663455);
		NativeMethodInfoPtr_ReinitializeIfNeeded_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUResidentDrawer>.NativeClassPtr, 100663456);
		NativeMethodInfoPtr_RenderDebugOcclusionTestOverlay_Public_Static_Void_RenderGraph_DebugDisplayGPUResidentDrawer_Int32_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUResidentDrawer>.NativeClassPtr, 100663457);
		NativeMethodInfoPtr_RenderDebugOccluderOverlay_Public_Static_Void_RenderGraph_DebugDisplayGPUResidentDrawer_Vector2_Single_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUResidentDrawer>.NativeClassPtr, 100663458);
		NativeMethodInfoPtr_GetDebugStats_Internal_Static_DebugRendererBatcherStats_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUResidentDrawer>.NativeClassPtr, 100663459);
		NativeMethodInfoPtr_InsertIntoPlayerLoop_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUResidentDrawer>.NativeClassPtr, 100663460);
		NativeMethodInfoPtr_RemoveFromPlayerLoop_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUResidentDrawer>.NativeClassPtr, 100663461);
		NativeMethodInfoPtr_IsEnabled_Internal_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUResidentDrawer>.NativeClassPtr, 100663462);
		NativeMethodInfoPtr_GetGlobalSettingsFromRPAsset_Internal_Static_GPUResidentDrawerSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUResidentDrawer>.NativeClassPtr, 100663463);
		NativeMethodInfoPtr_IsForcedOnViaCommandLine_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUResidentDrawer>.NativeClassPtr, 100663464);
		NativeMethodInfoPtr_IsOcclusionForcedOnViaCommandLine_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUResidentDrawer>.NativeClassPtr, 100663465);
		NativeMethodInfoPtr_Reinitialize_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUResidentDrawer>.NativeClassPtr, 100663466);
		NativeMethodInfoPtr_CleanUp_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUResidentDrawer>.NativeClassPtr, 100663467);
		NativeMethodInfoPtr_Recreate_Private_Static_Void_GPUResidentDrawerSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUResidentDrawer>.NativeClassPtr, 100663468);
		NativeMethodInfoPtr_get_batcher_Internal_get_GPUResidentBatcher_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUResidentDrawer>.NativeClassPtr, 100663469);
		NativeMethodInfoPtr_get_settings_Internal_get_GPUResidentDrawerSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUResidentDrawer>.NativeClassPtr, 100663470);
		NativeMethodInfoPtr__ctor_Private_Void_GPUResidentDrawerSettings_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUResidentDrawer>.NativeClassPtr, 100663471);
		NativeMethodInfoPtr_Dispose_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUResidentDrawer>.NativeClassPtr, 100663472);
		NativeMethodInfoPtr_OnSceneLoaded_Private_Void_Scene_LoadSceneMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUResidentDrawer>.NativeClassPtr, 100663473);
		NativeMethodInfoPtr_PostPostLateUpdateStatic_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUResidentDrawer>.NativeClassPtr, 100663474);
		NativeMethodInfoPtr_OnBeginContextRendering_Private_Void_ScriptableRenderContext_List_1_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUResidentDrawer>.NativeClassPtr, 100663475);
		NativeMethodInfoPtr_OnEndContextRendering_Private_Void_ScriptableRenderContext_List_1_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUResidentDrawer>.NativeClassPtr, 100663476);
		NativeMethodInfoPtr_OnBeginCameraRendering_Private_Void_ScriptableRenderContext_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUResidentDrawer>.NativeClassPtr, 100663477);
		NativeMethodInfoPtr_OnEndCameraRendering_Private_Void_ScriptableRenderContext_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUResidentDrawer>.NativeClassPtr, 100663478);
		NativeMethodInfoPtr_PostPostLateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUResidentDrawer>.NativeClassPtr, 100663479);
		NativeMethodInfoPtr_ProcessMaterials_Private_Void_NativeArray_1_Int32_NativeArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUResidentDrawer>.NativeClassPtr, 100663480);
		NativeMethodInfoPtr_ProcessMeshes_Private_Void_NativeArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUResidentDrawer>.NativeClassPtr, 100663481);
		NativeMethodInfoPtr_ProcessLODGroups_Private_Void_NativeArray_1_Int32_NativeArray_1_Int32_NativeArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUResidentDrawer>.NativeClassPtr, 100663482);
		NativeMethodInfoPtr_ProcessRendererMaterialAndMeshChanges_Private_Void_NativeArray_1_Int32_NativeArray_1_Int32_NativeArray_1_GPUDrivenPackedMaterialData_NativeArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUResidentDrawer>.NativeClassPtr, 100663483);
		NativeMethodInfoPtr_ProcessRenderers_Private_Void_TypeDispatchData_NativeArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUResidentDrawer>.NativeClassPtr, 100663484);
		NativeMethodInfoPtr_TransformInstances_Private_Void_NativeArray_1_InstanceHandle_NativeArray_1_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUResidentDrawer>.NativeClassPtr, 100663485);
		NativeMethodInfoPtr_FreeRendererGroupInstances_Private_Void_NativeArray_1_Int32_NativeArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUResidentDrawer>.NativeClassPtr, 100663486);
		NativeMethodInfoPtr_ScheduleQueryRendererGroupInstancesJob_Private_JobHandle_NativeArray_1_Int32_NativeArray_1_InstanceHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUResidentDrawer>.NativeClassPtr, 100663487);
		NativeMethodInfoPtr_ScheduleQueryMeshInstancesJob_Private_JobHandle_NativeArray_1_Int32_NativeList_1_InstanceHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUResidentDrawer>.NativeClassPtr, 100663488);
		NativeMethodInfoPtr_ClassifyMaterials_Private_Void_NativeArray_1_Int32_byref_NativeList_1_Int32_byref_NativeList_1_Int32_byref_NativeList_1_GPUDrivenPackedMaterialData_Allocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUResidentDrawer>.NativeClassPtr, 100663489);
		NativeMethodInfoPtr_FindUnsupportedRenderers_Private_NativeList_1_Int32_NativeArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUResidentDrawer>.NativeClassPtr, 100663490);
		NativeMethodInfoPtr_GetMaterialsWithChangedPackedMaterial_Private_NativeHashSet_1_Int32_NativeArray_1_Int32_NativeArray_1_GPUDrivenPackedMaterialData_Allocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUResidentDrawer>.NativeClassPtr, 100663491);
		NativeMethodInfoPtr_FindRenderersFromMaterialsOrMeshes_Private_ValueTuple_2_NativeList_1_Int32_NativeList_1_Int32_NativeArray_1_Int32_NativeHashSet_1_Int32_NativeArray_1_Int32_Allocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUResidentDrawer>.NativeClassPtr, 100663492);
		NativeMethodInfoPtr_IsProjectSupported_Internal_Static_Boolean_byref_String_byref_LogType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUResidentDrawer>.NativeClassPtr, 100663493);
		NativeMethodInfoPtr_IsGPUResidentDrawerSupportedBySRP_Internal_Static_Boolean_GPUResidentDrawerSettings_byref_String_byref_LogType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUResidentDrawer>.NativeClassPtr, 100663494);
		NativeMethodInfoPtr_LogMessage_Internal_Static_Void_String_LogType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUResidentDrawer>.NativeClassPtr, 100663495);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1068220, RefRangeEnd = 1068221, XrefRangeStart = 1068218, XrefRangeEnd = 1068220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsInstanceOcclusionCullingEnabled()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsInstanceOcclusionCullingEnabled_Public_Static_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1068224, RefRangeEnd = 1068225, XrefRangeStart = 1068221, XrefRangeEnd = 1068224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void PostCullBeginCameraRendering(RenderRequestBatcherContext context)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)context));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PostCullBeginCameraRendering_Public_Static_Void_RenderRequestBatcherContext_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1068230, RefRangeEnd = 1068231, XrefRangeStart = 1068225, XrefRangeEnd = 1068230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InstanceOcclusionTest(RenderGraph renderGraph, [In] ref OcclusionCullingSettings settings, Il2CppSystem.ReadOnlySpan<SubviewOcclusionTest> subviewOcclusionTests)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderGraph);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref settings);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)subviewOcclusionTests));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InstanceOcclusionTest_Public_Static_Void_RenderGraph_byref_OcclusionCullingSettings_ReadOnlySpan_1_SubviewOcclusionTest_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1068235, RefRangeEnd = 1068236, XrefRangeStart = 1068231, XrefRangeEnd = 1068235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void UpdateInstanceOccluders(RenderGraph renderGraph, [In] ref OccluderParameters occluderParameters, Il2CppSystem.ReadOnlySpan<OccluderSubviewUpdate> occluderSubviewUpdates)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderGraph);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref occluderParameters);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)occluderSubviewUpdates));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateInstanceOccluders_Public_Static_Void_RenderGraph_byref_OccluderParameters_ReadOnlySpan_1_OccluderSubviewUpdate_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(19883)]
	[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 20035, XrefRangeStart = 152, XrefRangeEnd = 20035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ReinitializeIfNeeded()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReinitializeIfNeeded_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1068239, RefRangeEnd = 1068240, XrefRangeStart = 1068236, XrefRangeEnd = 1068239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RenderDebugOcclusionTestOverlay(RenderGraph renderGraph, DebugDisplayGPUResidentDrawer debugSettings, int viewInstanceID, TextureHandle colorBuffer)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderGraph);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)debugSettings);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &viewInstanceID;
		*(TextureHandle**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &colorBuffer;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RenderDebugOcclusionTestOverlay_Public_Static_Void_RenderGraph_DebugDisplayGPUResidentDrawer_Int32_TextureHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1068243, RefRangeEnd = 1068244, XrefRangeStart = 1068240, XrefRangeEnd = 1068243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RenderDebugOccluderOverlay(RenderGraph renderGraph, DebugDisplayGPUResidentDrawer debugSettings, Vector2 screenPos, float maxHeight, TextureHandle colorBuffer)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderGraph);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)debugSettings);
		*(Vector2**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &screenPos;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxHeight;
		*(TextureHandle**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &colorBuffer;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RenderDebugOccluderOverlay_Public_Static_Void_RenderGraph_DebugDisplayGPUResidentDrawer_Vector2_Single_TextureHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1068246, RefRangeEnd = 1068248, XrefRangeStart = 1068244, XrefRangeEnd = 1068246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static DebugRendererBatcherStats GetDebugStats()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDebugStats_Internal_Static_DebugRendererBatcherStats_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<DebugRendererBatcherStats>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1068292, RefRangeEnd = 1068293, XrefRangeStart = 1068248, XrefRangeEnd = 1068292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InsertIntoPlayerLoop()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InsertIntoPlayerLoop_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1068321, RefRangeEnd = 1068322, XrefRangeStart = 1068293, XrefRangeEnd = 1068321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveFromPlayerLoop()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveFromPlayerLoop_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsEnabled()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsEnabled_Internal_Static_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1068331, RefRangeEnd = 1068334, XrefRangeStart = 1068322, XrefRangeEnd = 1068331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static GPUResidentDrawerSettings GetGlobalSettingsFromRPAsset()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetGlobalSettingsFromRPAsset_Internal_Static_GPUResidentDrawerSettings_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new GPUResidentDrawerSettings(pointer);
	}

	[CallerCount(143)]
	[CachedScanResults(RefRangeStart = 9, RefRangeEnd = 152, XrefRangeStart = 9, XrefRangeEnd = 152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsForcedOnViaCommandLine()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsForcedOnViaCommandLine_Private_Static_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(143)]
	[CachedScanResults(RefRangeStart = 9, RefRangeEnd = 152, XrefRangeStart = 9, XrefRangeEnd = 152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsOcclusionForcedOnViaCommandLine()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsOcclusionForcedOnViaCommandLine_Private_Static_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1068347, RefRangeEnd = 1068349, XrefRangeStart = 1068334, XrefRangeEnd = 1068347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Reinitialize()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Reinitialize_Internal_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1068349, XrefRangeEnd = 1068355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CleanUp()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CleanUp_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1068355, XrefRangeEnd = 1068367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Recreate(GPUResidentDrawerSettings settings)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)settings));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Recreate_Private_Static_Void_GPUResidentDrawerSettings_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1068367, XrefRangeEnd = 1068486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GPUResidentDrawer(GPUResidentDrawerSettings settings, int maxInstanceCount, int maxTreeInstanceCount)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GPUResidentDrawer>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)settings));
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxInstanceCount;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxTreeInstanceCount;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Private_Void_GPUResidentDrawerSettings_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1068541, RefRangeEnd = 1068545, XrefRangeStart = 1068486, XrefRangeEnd = 1068541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Dispose()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dispose_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1068545, XrefRangeEnd = 1068546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnSceneLoaded(Scene scene, LoadSceneMode mode)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&scene);
		*(LoadSceneMode**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &mode;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnSceneLoaded_Private_Void_Scene_LoadSceneMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1068546, XrefRangeEnd = 1068549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void PostPostLateUpdateStatic()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PostPostLateUpdateStatic_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1068549, XrefRangeEnd = 1068557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnBeginContextRendering(ScriptableRenderContext context, List<Camera> cameras)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&context);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cameras);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnBeginContextRendering_Private_Void_ScriptableRenderContext_List_1_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1068557, XrefRangeEnd = 1068564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnEndContextRendering(ScriptableRenderContext context, List<Camera> cameras)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&context);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cameras);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnEndContextRendering_Private_Void_ScriptableRenderContext_List_1_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1068564, XrefRangeEnd = 1068565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnBeginCameraRendering(ScriptableRenderContext context, Camera camera)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&context);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnBeginCameraRendering_Private_Void_ScriptableRenderContext_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnEndCameraRendering(ScriptableRenderContext context, Camera camera)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&context);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnEndCameraRendering_Private_Void_ScriptableRenderContext_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1068656, RefRangeEnd = 1068657, XrefRangeStart = 1068565, XrefRangeEnd = 1068656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PostPostLateUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PostPostLateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1068657, XrefRangeEnd = 1068659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ProcessMaterials(NativeArray<int> destroyedID, NativeArray<int> unsupportedMaterials)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)destroyedID));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)unsupportedMaterials));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ProcessMaterials_Private_Void_NativeArray_1_Int32_NativeArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1068659, XrefRangeEnd = 1068673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ProcessMeshes(NativeArray<int> destroyedID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)destroyedID));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ProcessMeshes_Private_Void_NativeArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1068673, XrefRangeEnd = 1068676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ProcessLODGroups(NativeArray<int> changedID, NativeArray<int> destroyed, NativeArray<int> transformedID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)changedID));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)destroyed));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)transformedID));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ProcessLODGroups_Private_Void_NativeArray_1_Int32_NativeArray_1_Int32_NativeArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1068700, RefRangeEnd = 1068701, XrefRangeStart = 1068676, XrefRangeEnd = 1068700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ProcessRendererMaterialAndMeshChanges(NativeArray<int> excludedRenderers, NativeArray<int> changedMaterials, NativeArray<GPUDrivenPackedMaterialData> changedPackedMaterialDatas, NativeArray<int> changedMeshes)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)excludedRenderers));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)changedMaterials));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)changedPackedMaterialDatas));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)changedMeshes));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ProcessRendererMaterialAndMeshChanges_Private_Void_NativeArray_1_Int32_NativeArray_1_Int32_NativeArray_1_GPUDrivenPackedMaterialData_NativeArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1068728, RefRangeEnd = 1068729, XrefRangeStart = 1068701, XrefRangeEnd = 1068728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ProcessRenderers(TypeDispatchData rendererChanges, NativeArray<int> unsupportedRenderers)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)rendererChanges));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)unsupportedRenderers));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ProcessRenderers_Private_Void_TypeDispatchData_NativeArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1068729, XrefRangeEnd = 1068730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TransformInstances(NativeArray<InstanceHandle> instances, NativeArray<Matrix4x4> localToWorldMatrices)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)instances));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)localToWorldMatrices));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TransformInstances_Private_Void_NativeArray_1_InstanceHandle_NativeArray_1_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1068730, XrefRangeEnd = 1068736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FreeRendererGroupInstances(NativeArray<int> rendererGroupIDs, NativeArray<int> unsupportedRendererGroupIDs)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)rendererGroupIDs));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)unsupportedRendererGroupIDs));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FreeRendererGroupInstances_Private_Void_NativeArray_1_Int32_NativeArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1068736, XrefRangeEnd = 1068737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe JobHandle ScheduleQueryRendererGroupInstancesJob(NativeArray<int> rendererGroupIDs, NativeArray<InstanceHandle> instances)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)rendererGroupIDs));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)instances));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ScheduleQueryRendererGroupInstancesJob_Private_JobHandle_NativeArray_1_Int32_NativeArray_1_InstanceHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(JobHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1068737, XrefRangeEnd = 1068738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe JobHandle ScheduleQueryMeshInstancesJob(NativeArray<int> sortedMeshIDs, NativeList<InstanceHandle> instances)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)sortedMeshIDs));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)instances));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ScheduleQueryMeshInstancesJob_Private_JobHandle_NativeArray_1_Int32_NativeList_1_InstanceHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(JobHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1068738, XrefRangeEnd = 1068753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ClassifyMaterials(NativeArray<int> materials, out NativeList<int> unsupportedMaterials, out NativeList<int> supportedMaterials, out NativeList<GPUDrivenPackedMaterialData> supportedPackedMaterialDatas, Allocator allocator)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)materials));
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		byte* num3 = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num4 = 0;
		*(nint**)num3 = &num4;
		byte* num5 = (byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num6 = 0;
		*(nint**)num5 = &num6;
		*(Allocator**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &allocator;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClassifyMaterials_Private_Void_NativeArray_1_Int32_byref_NativeList_1_Int32_byref_NativeList_1_Int32_byref_NativeList_1_GPUDrivenPackedMaterialData_Allocator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num7 = num2;
		unsupportedMaterials = ((num7 == 0) ? null : new NativeList<int>(num7));
		nint num8 = num4;
		supportedMaterials = ((num8 == 0) ? null : new NativeList<int>(num8));
		nint num9 = num6;
		supportedPackedMaterialDatas = ((num9 == 0) ? null : new NativeList<GPUDrivenPackedMaterialData>(num9));
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1068753, XrefRangeEnd = 1068762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe NativeList<int> FindUnsupportedRenderers(NativeArray<int> unsupportedMaterials)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)unsupportedMaterials));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindUnsupportedRenderers_Private_NativeList_1_Int32_NativeArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new NativeList<int>(pointer);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1068762, XrefRangeEnd = 1068770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe NativeHashSet<int> GetMaterialsWithChangedPackedMaterial(NativeArray<int> materials, NativeArray<GPUDrivenPackedMaterialData> packedMaterialDatas, Allocator allocator)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)materials));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)packedMaterialDatas));
		*(Allocator**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &allocator;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMaterialsWithChangedPackedMaterial_Private_NativeHashSet_1_Int32_NativeArray_1_Int32_NativeArray_1_GPUDrivenPackedMaterialData_Allocator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new NativeHashSet<int>(pointer);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1068770, XrefRangeEnd = 1068799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppSystem.ValueTuple<NativeList<int>, NativeList<int>> FindRenderersFromMaterialsOrMeshes(NativeArray<int> sortedExcludeRenderers, NativeHashSet<int> materials, NativeArray<int> meshes, Allocator rendererListAllocator)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)sortedExcludeRenderers));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)materials));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)meshes));
		*(Allocator**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &rendererListAllocator;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindRenderersFromMaterialsOrMeshes_Private_ValueTuple_2_NativeList_1_Int32_NativeList_1_Int32_NativeArray_1_Int32_NativeHashSet_1_Int32_NativeArray_1_Int32_Allocator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new Il2CppSystem.ValueTuple<NativeList<int>, NativeList<int>>(pointer);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1068799, XrefRangeEnd = 1068807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsProjectSupported(out string message, out LogType severity)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		nint num = 0;
		*ptr = (nint)(&num);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref severity);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsProjectSupported_Internal_Static_Boolean_byref_String_byref_LogType_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		message = IL2CPP.Il2CppStringToManaged((System.IntPtr)num);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1068827, RefRangeEnd = 1068831, XrefRangeStart = 1068807, XrefRangeEnd = 1068827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsGPUResidentDrawerSupportedBySRP(GPUResidentDrawerSettings settings, out string message, out LogType severity)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)settings));
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref severity);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsGPUResidentDrawerSupportedBySRP_Internal_Static_Boolean_GPUResidentDrawerSettings_byref_String_byref_LogType_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		message = IL2CPP.Il2CppStringToManaged((System.IntPtr)num2);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1068831, XrefRangeEnd = 1068835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void LogMessage(string message, LogType severity)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
		*(LogType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &severity;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LogMessage_Internal_Static_Void_String_LogType_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public GPUResidentDrawer(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
