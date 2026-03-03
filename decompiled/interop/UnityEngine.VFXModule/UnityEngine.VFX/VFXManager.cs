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
using UnityEngine.Rendering;

namespace UnityEngine.VFX;

public static class VFXManager : Il2CppSystem.Object
{
	private delegate System.IntPtr GetComponentsDelegate();

	private delegate void set_fixedTimeStepDelegate(float value);

	private delegate void set_maxDeltaTimeDelegate(float value);

	private delegate uint get_maxCapacityDelegate();

	private delegate void set_maxCapacityDelegate(uint value);

	private delegate void set_maxScrubTimeDelegate(float value);

	private delegate uint get_batchEmptyLifetimeDelegate();

	private delegate void set_batchEmptyLifetimeDelegate(uint value);

	private delegate void CleanupEmptyBatchesDelegate(bool force);

	private delegate void SetRayTracingEnabledDelegate(bool enabled);

	private delegate void RequestRtasAabbConstructionDelegate();

	private delegate void get_renderPipeSettingsPath_InjectedDelegate([Out] System.IntPtr ret);

	private delegate void GetBatchedEffectInfo_InjectedDelegate(System.IntPtr vfx, [Out] System.IntPtr ret);

	private delegate void GetBatchedEffectInfos_InjectedDelegate(System.IntPtr infos);

	private delegate void GetBatchInfo_InjectedDelegate(System.IntPtr vfx, uint batchIndex, [Out] System.IntPtr ret);

	private static readonly System.IntPtr NativeFieldInfoPtr_kDefaultCameraXRSettings;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_runtimeResources_Internal_Static_get_ScriptableObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_fixedTimeStep_Public_Static_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_maxDeltaTime_Public_Static_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_maxScrubTime_Internal_Static_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PrepareCamera_Public_Static_Void_Camera_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PrepareCamera_Public_Static_Void_Camera_VFXCameraXRSettings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ProcessCameraCommand_Public_Static_Void_Camera_CommandBuffer_VFXCameraXRSettings_CullingResults_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_ProcessCameraCommand_Private_Static_Void_Camera_CommandBuffer_VFXCameraXRSettings_IntPtr_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsCameraBufferNeeded_Public_Static_VFXCameraBufferTypes_Camera_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetCameraBuffer_Public_Static_Void_Camera_VFXCameraBufferTypes_Texture_Int32_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_runtimeResources_Injected_Private_Static_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PrepareCamera_Injected_Private_Static_Void_IntPtr_byref_VFXCameraXRSettings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_ProcessCameraCommand_Injected_Private_Static_Void_IntPtr_IntPtr_byref_VFXCameraXRSettings_IntPtr_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsCameraBufferNeeded_Injected_Private_Static_VFXCameraBufferTypes_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetCameraBuffer_Injected_Private_Static_Void_IntPtr_VFXCameraBufferTypes_IntPtr_Int32_Int32_Int32_Int32_0;

	private static readonly GetComponentsDelegate GetComponentsDelegateField;

	private static readonly set_fixedTimeStepDelegate set_fixedTimeStepDelegateField;

	private static readonly set_maxDeltaTimeDelegate set_maxDeltaTimeDelegateField;

	private static readonly get_maxCapacityDelegate get_maxCapacityDelegateField;

	private static readonly set_maxCapacityDelegate set_maxCapacityDelegateField;

	private static readonly set_maxScrubTimeDelegate set_maxScrubTimeDelegateField;

	private static readonly get_batchEmptyLifetimeDelegate get_batchEmptyLifetimeDelegateField;

	private static readonly set_batchEmptyLifetimeDelegate set_batchEmptyLifetimeDelegateField;

	private static readonly CleanupEmptyBatchesDelegate CleanupEmptyBatchesDelegateField;

	private static readonly SetRayTracingEnabledDelegate SetRayTracingEnabledDelegateField;

	private static readonly RequestRtasAabbConstructionDelegate RequestRtasAabbConstructionDelegateField;

	private static readonly get_renderPipeSettingsPath_InjectedDelegate get_renderPipeSettingsPath_InjectedDelegateField;

	private static readonly GetBatchedEffectInfo_InjectedDelegate GetBatchedEffectInfo_InjectedDelegateField;

	private static readonly GetBatchedEffectInfos_InjectedDelegate GetBatchedEffectInfos_InjectedDelegateField;

	private static readonly GetBatchInfo_InjectedDelegate GetBatchInfo_InjectedDelegateField;

	public unsafe static VFXCameraXRSettings kDefaultCameraXRSettings
	{
		get
		{
			Unsafe.SkipInit(out VFXCameraXRSettings result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kDefaultCameraXRSettings, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kDefaultCameraXRSettings, (void*)(&value));
		}
	}

	public unsafe static ScriptableObject runtimeResources
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1409029, RefRangeEnd = 1409032, XrefRangeStart = 1409021, XrefRangeEnd = 1409029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_runtimeResources_Internal_Static_get_ScriptableObject_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ScriptableObject>(intPtr2) : null;
		}
	}

	public unsafe static float fixedTimeStep
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1409034, RefRangeEnd = 1409035, XrefRangeStart = 1409032, XrefRangeEnd = 1409034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_fixedTimeStep_Public_Static_get_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			set_fixedTimeStepDelegateField(value);
		}
	}

	public unsafe static float maxDeltaTime
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1409037, RefRangeEnd = 1409040, XrefRangeStart = 1409035, XrefRangeEnd = 1409037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_maxDeltaTime_Public_Static_get_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			set_maxDeltaTimeDelegateField(value);
		}
	}

	public unsafe static float maxScrubTime
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1409042, RefRangeEnd = 1409043, XrefRangeStart = 1409040, XrefRangeEnd = 1409042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_maxScrubTime_Internal_Static_get_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			set_maxScrubTimeDelegateField(value);
		}
	}

	public static uint maxCapacity
	{
		get
		{
			return get_maxCapacityDelegateField();
		}
		set
		{
			set_maxCapacityDelegateField(value);
		}
	}

	public static string renderPipeSettingsPath
	{
		get
		{
			Unsafe.SkipInit(out ManagedSpanWrapper ret);
			string stringAndDispose;
			try
			{
				get_renderPipeSettingsPath_Injected(out ret);
			}
			finally
			{
				stringAndDispose = OutStringMarshaller.GetStringAndDispose(ret);
			}
			return stringAndDispose;
		}
	}

	public static uint batchEmptyLifetime
	{
		get
		{
			return get_batchEmptyLifetimeDelegateField();
		}
		set
		{
			set_batchEmptyLifetimeDelegateField(value);
		}
	}

	static VFXManager()
	{
		Il2CppClassPointerStore<VFXManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.VFXModule.dll", "UnityEngine.VFX", "VFXManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VFXManager>.NativeClassPtr);
		NativeFieldInfoPtr_kDefaultCameraXRSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VFXManager>.NativeClassPtr, "kDefaultCameraXRSettings");
		NativeMethodInfoPtr_get_runtimeResources_Internal_Static_get_ScriptableObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXManager>.NativeClassPtr, 100663354);
		NativeMethodInfoPtr_get_fixedTimeStep_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXManager>.NativeClassPtr, 100663355);
		NativeMethodInfoPtr_get_maxDeltaTime_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXManager>.NativeClassPtr, 100663356);
		NativeMethodInfoPtr_get_maxScrubTime_Internal_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXManager>.NativeClassPtr, 100663357);
		NativeMethodInfoPtr_PrepareCamera_Public_Static_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXManager>.NativeClassPtr, 100663358);
		NativeMethodInfoPtr_PrepareCamera_Public_Static_Void_Camera_VFXCameraXRSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXManager>.NativeClassPtr, 100663359);
		NativeMethodInfoPtr_ProcessCameraCommand_Public_Static_Void_Camera_CommandBuffer_VFXCameraXRSettings_CullingResults_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXManager>.NativeClassPtr, 100663360);
		NativeMethodInfoPtr_Internal_ProcessCameraCommand_Private_Static_Void_Camera_CommandBuffer_VFXCameraXRSettings_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXManager>.NativeClassPtr, 100663361);
		NativeMethodInfoPtr_IsCameraBufferNeeded_Public_Static_VFXCameraBufferTypes_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXManager>.NativeClassPtr, 100663362);
		NativeMethodInfoPtr_SetCameraBuffer_Public_Static_Void_Camera_VFXCameraBufferTypes_Texture_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXManager>.NativeClassPtr, 100663363);
		NativeMethodInfoPtr_get_runtimeResources_Injected_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXManager>.NativeClassPtr, 100663365);
		NativeMethodInfoPtr_PrepareCamera_Injected_Private_Static_Void_IntPtr_byref_VFXCameraXRSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXManager>.NativeClassPtr, 100663366);
		NativeMethodInfoPtr_Internal_ProcessCameraCommand_Injected_Private_Static_Void_IntPtr_IntPtr_byref_VFXCameraXRSettings_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXManager>.NativeClassPtr, 100663367);
		NativeMethodInfoPtr_IsCameraBufferNeeded_Injected_Private_Static_VFXCameraBufferTypes_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXManager>.NativeClassPtr, 100663368);
		NativeMethodInfoPtr_SetCameraBuffer_Injected_Private_Static_Void_IntPtr_VFXCameraBufferTypes_IntPtr_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXManager>.NativeClassPtr, 100663369);
		GetComponentsDelegateField = IL2CPP.ResolveICall<GetComponentsDelegate>("UnityEngine.VFX.VFXManager::GetComponents");
		set_fixedTimeStepDelegateField = IL2CPP.ResolveICall<set_fixedTimeStepDelegate>("UnityEngine.VFX.VFXManager::set_fixedTimeStep");
		set_maxDeltaTimeDelegateField = IL2CPP.ResolveICall<set_maxDeltaTimeDelegate>("UnityEngine.VFX.VFXManager::set_maxDeltaTime");
		get_maxCapacityDelegateField = IL2CPP.ResolveICall<get_maxCapacityDelegate>("UnityEngine.VFX.VFXManager::get_maxCapacity");
		set_maxCapacityDelegateField = IL2CPP.ResolveICall<set_maxCapacityDelegate>("UnityEngine.VFX.VFXManager::set_maxCapacity");
		set_maxScrubTimeDelegateField = IL2CPP.ResolveICall<set_maxScrubTimeDelegate>("UnityEngine.VFX.VFXManager::set_maxScrubTime");
		get_batchEmptyLifetimeDelegateField = IL2CPP.ResolveICall<get_batchEmptyLifetimeDelegate>("UnityEngine.VFX.VFXManager::get_batchEmptyLifetime");
		set_batchEmptyLifetimeDelegateField = IL2CPP.ResolveICall<set_batchEmptyLifetimeDelegate>("UnityEngine.VFX.VFXManager::set_batchEmptyLifetime");
		CleanupEmptyBatchesDelegateField = IL2CPP.ResolveICall<CleanupEmptyBatchesDelegate>("UnityEngine.VFX.VFXManager::CleanupEmptyBatches");
		SetRayTracingEnabledDelegateField = IL2CPP.ResolveICall<SetRayTracingEnabledDelegate>("UnityEngine.VFX.VFXManager::SetRayTracingEnabled");
		RequestRtasAabbConstructionDelegateField = IL2CPP.ResolveICall<RequestRtasAabbConstructionDelegate>("UnityEngine.VFX.VFXManager::RequestRtasAabbConstruction");
		get_renderPipeSettingsPath_InjectedDelegateField = IL2CPP.ResolveICall<get_renderPipeSettingsPath_InjectedDelegate>("UnityEngine.VFX.VFXManager::get_renderPipeSettingsPath_Injected");
		GetBatchedEffectInfo_InjectedDelegateField = IL2CPP.ResolveICall<GetBatchedEffectInfo_InjectedDelegate>("UnityEngine.VFX.VFXManager::GetBatchedEffectInfo_Injected");
		GetBatchedEffectInfos_InjectedDelegateField = IL2CPP.ResolveICall<GetBatchedEffectInfos_InjectedDelegate>("UnityEngine.VFX.VFXManager::GetBatchedEffectInfos_Injected");
		GetBatchInfo_InjectedDelegateField = IL2CPP.ResolveICall<GetBatchInfo_InjectedDelegate>("UnityEngine.VFX.VFXManager::GetBatchInfo_Injected");
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1409056, RefRangeEnd = 1409057, XrefRangeStart = 1409043, XrefRangeEnd = 1409056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void PrepareCamera(Camera cam)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cam);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PrepareCamera_Public_Static_Void_Camera_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1409066, RefRangeEnd = 1409068, XrefRangeStart = 1409057, XrefRangeEnd = 1409066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void PrepareCamera(Camera cam, VFXCameraXRSettings camXRSettings)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cam);
		*(VFXCameraXRSettings**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &camXRSettings;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PrepareCamera_Public_Static_Void_Camera_VFXCameraXRSettings_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1409081, RefRangeEnd = 1409083, XrefRangeStart = 1409068, XrefRangeEnd = 1409081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ProcessCameraCommand(Camera cam, CommandBuffer cmd, VFXCameraXRSettings camXRSettings, CullingResults results)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cam);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(VFXCameraXRSettings**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &camXRSettings;
		*(CullingResults**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &results;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ProcessCameraCommand_Public_Static_Void_Camera_CommandBuffer_VFXCameraXRSettings_CullingResults_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1409083, XrefRangeEnd = 1409092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Internal_ProcessCameraCommand(Camera cam, CommandBuffer cmd, VFXCameraXRSettings camXRSettings, System.IntPtr cullResults, System.IntPtr customPassCullResults)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cam);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(VFXCameraXRSettings**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &camXRSettings;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &cullResults;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &customPassCullResults;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_ProcessCameraCommand_Private_Static_Void_Camera_CommandBuffer_VFXCameraXRSettings_IntPtr_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1409104, RefRangeEnd = 1409105, XrefRangeStart = 1409092, XrefRangeEnd = 1409104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static VFXCameraBufferTypes IsCameraBufferNeeded(Camera cam)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cam);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsCameraBufferNeeded_Public_Static_VFXCameraBufferTypes_Camera_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(VFXCameraBufferTypes*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1409122, RefRangeEnd = 1409124, XrefRangeStart = 1409105, XrefRangeEnd = 1409122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetCameraBuffer(Camera cam, VFXCameraBufferTypes type, Texture buffer, int x, int y, int width, int height)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cam);
		*(VFXCameraBufferTypes**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &type;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buffer);
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &x;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &width;
		*(int**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &height;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetCameraBuffer_Public_Static_Void_Camera_VFXCameraBufferTypes_Texture_Int32_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1409124, XrefRangeEnd = 1409126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr get_runtimeResources_Injected()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_runtimeResources_Injected_Private_Static_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1409126, XrefRangeEnd = 1409128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void PrepareCamera_Injected(System.IntPtr cam, [In] ref VFXCameraXRSettings camXRSettings)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&cam);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref camXRSettings);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PrepareCamera_Injected_Private_Static_Void_IntPtr_byref_VFXCameraXRSettings_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1409128, XrefRangeEnd = 1409130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Internal_ProcessCameraCommand_Injected(System.IntPtr cam, System.IntPtr cmd, [In] ref VFXCameraXRSettings camXRSettings, System.IntPtr cullResults, System.IntPtr customPassCullResults)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&cam);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &cmd;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref camXRSettings);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &cullResults;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &customPassCullResults;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_ProcessCameraCommand_Injected_Private_Static_Void_IntPtr_IntPtr_byref_VFXCameraXRSettings_IntPtr_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1409130, XrefRangeEnd = 1409132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static VFXCameraBufferTypes IsCameraBufferNeeded_Injected(System.IntPtr cam)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&cam);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsCameraBufferNeeded_Injected_Private_Static_VFXCameraBufferTypes_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(VFXCameraBufferTypes*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1409132, XrefRangeEnd = 1409134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetCameraBuffer_Injected(System.IntPtr cam, VFXCameraBufferTypes type, System.IntPtr buffer, int x, int y, int width, int height)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = (nint)(&cam);
		*(VFXCameraBufferTypes**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &type;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &buffer;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &x;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &width;
		*(int**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &height;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetCameraBuffer_Injected_Private_Static_Void_IntPtr_VFXCameraBufferTypes_IntPtr_Int32_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public VFXManager(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public static Il2CppReferenceArray<VisualEffect> GetComponents()
	{
		System.IntPtr intPtr = GetComponentsDelegateField();
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<VisualEffect>>(intPtr) : null;
	}

	public static void CleanupEmptyBatches([Optional] bool force)
	{
		CleanupEmptyBatchesDelegateField(force);
	}

	public static void FlushEmptyBatches()
	{
		CleanupEmptyBatches(force: true);
	}

	public static VFXBatchedEffectInfo GetBatchedEffectInfo(VisualEffectAsset vfx)
	{
		if ((object)vfx == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(vfx, "vfx");
		}
		System.IntPtr intPtr = Object.MarshalledUnityObject.MarshalNotNull(vfx);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(vfx, "vfx");
		}
		GetBatchedEffectInfo_Injected(intPtr, out var ret);
		return ret;
	}

	public static void GetBatchedEffectInfos(List<VFXBatchedEffectInfo> infos)
	{
		if (infos == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(infos, "infos");
		}
		GetBatchedEffectInfos_Injected(infos);
	}

	public static VFXBatchInfo GetBatchInfo(VisualEffectAsset vfx, uint batchIndex)
	{
		GetBatchInfo_Injected(Object.MarshalledUnityObject.Marshal(vfx), batchIndex, out var ret);
		return ret;
	}

	public static void ProcessCamera(Camera cam)
	{
		PrepareCamera(cam, kDefaultCameraXRSettings);
		Internal_ProcessCameraCommand(cam, null, kDefaultCameraXRSettings, Il2CppSystem.IntPtr.Zero, Il2CppSystem.IntPtr.Zero);
	}

	public static void ProcessCameraCommand(Camera cam, CommandBuffer cmd)
	{
		Internal_ProcessCameraCommand(cam, cmd, kDefaultCameraXRSettings, Il2CppSystem.IntPtr.Zero, Il2CppSystem.IntPtr.Zero);
	}

	public static void ProcessCameraCommand(Camera cam, CommandBuffer cmd, VFXCameraXRSettings camXRSettings)
	{
		Internal_ProcessCameraCommand(cam, cmd, camXRSettings, Il2CppSystem.IntPtr.Zero, Il2CppSystem.IntPtr.Zero);
	}

	public static void ProcessCameraCommand(Camera cam, CommandBuffer cmd, VFXCameraXRSettings camXRSettings, CullingResults results, CullingResults customPassResults)
	{
		Internal_ProcessCameraCommand(cam, cmd, camXRSettings, results.ptr, customPassResults.ptr);
	}

	public static void SetRayTracingEnabled(bool enabled)
	{
		SetRayTracingEnabledDelegateField(enabled);
	}

	public static void RequestRtasAabbConstruction()
	{
		RequestRtasAabbConstructionDelegateField();
	}

	public unsafe static void get_renderPipeSettingsPath_Injected(out ManagedSpanWrapper ret)
	{
		get_renderPipeSettingsPath_InjectedDelegateField((nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void GetBatchedEffectInfo_Injected(System.IntPtr vfx, out VFXBatchedEffectInfo ret)
	{
		GetBatchedEffectInfo_InjectedDelegate getBatchedEffectInfo_InjectedDelegateField = GetBatchedEffectInfo_InjectedDelegateField;
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ret);
		getBatchedEffectInfo_InjectedDelegateField(vfx, (nint)(&intPtr));
	}

	public static void GetBatchedEffectInfos_Injected(List<VFXBatchedEffectInfo> infos)
	{
		GetBatchedEffectInfos_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)infos));
	}

	public unsafe static void GetBatchInfo_Injected(System.IntPtr vfx, uint batchIndex, out VFXBatchInfo ret)
	{
		GetBatchInfo_InjectedDelegateField(vfx, batchIndex, (nint)Unsafe.AsPointer(ref ret));
	}
}
