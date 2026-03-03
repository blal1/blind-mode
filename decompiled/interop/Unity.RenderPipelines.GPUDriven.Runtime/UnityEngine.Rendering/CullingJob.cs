using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using Unity.Collections;
using Unity.Mathematics;

namespace UnityEngine.Rendering;

public sealed class CullingJob : Il2CppSystem.ValueType
{
	[OriginalName("Unity.RenderPipelines.GPUDriven.Runtime.dll", "", "CrossFadeType")]
	public enum CrossFadeType
	{
		kDisabled,
		kCrossFadeOut,
		kCrossFadeIn,
		kVisible
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_binningConfig;

	private static readonly System.IntPtr NativeFieldInfoPtr_viewType;

	private static readonly System.IntPtr NativeFieldInfoPtr_cameraPosition;

	private static readonly System.IntPtr NativeFieldInfoPtr_sqrScreenRelativeMetric;

	private static readonly System.IntPtr NativeFieldInfoPtr_minScreenRelativeHeight;

	private static readonly System.IntPtr NativeFieldInfoPtr_isOrtho;

	private static readonly System.IntPtr NativeFieldInfoPtr_cullLightmappedShadowCasters;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxLOD;

	private static readonly System.IntPtr NativeFieldInfoPtr_cullingLayerMask;

	private static readonly System.IntPtr NativeFieldInfoPtr_sceneCullingMask;

	private static readonly System.IntPtr NativeFieldInfoPtr_frustumPlanePackets;

	private static readonly System.IntPtr NativeFieldInfoPtr_frustumSplitInfos;

	private static readonly System.IntPtr NativeFieldInfoPtr_lightFacingFrustumPlanes;

	private static readonly System.IntPtr NativeFieldInfoPtr_receiverSplitInfos;

	private static readonly System.IntPtr NativeFieldInfoPtr_worldToLightSpaceRotation;

	private static readonly System.IntPtr NativeFieldInfoPtr_instanceData;

	private static readonly System.IntPtr NativeFieldInfoPtr_sharedInstanceData;

	private static readonly System.IntPtr NativeFieldInfoPtr_lodGroupCullingData;

	private static readonly System.IntPtr NativeFieldInfoPtr_occlusionBuffer;

	private static readonly System.IntPtr NativeFieldInfoPtr_rendererVisibilityMasks;

	private static readonly System.IntPtr NativeFieldInfoPtr_rendererCrossFadeValues;

	private static readonly System.IntPtr NativeMethodInfoPtr_PackFloatToUint8_Private_Static_UInt32_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalculateLODVisibility_Private_Single_Int32_Int32_InstanceFlags_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalculateVisibilityMask_Private_UInt32_Int32_Int32_InstanceFlags_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_0;

	public unsafe BinningConfig binningConfig
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_binningConfig);
			return *(BinningConfig*)num;
		}
		set
		{
			*(BinningConfig*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_binningConfig)) = value;
		}
	}

	public unsafe BatchCullingViewType viewType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_viewType);
			return *(BatchCullingViewType*)num;
		}
		set
		{
			*(BatchCullingViewType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_viewType)) = value;
		}
	}

	public unsafe float3 cameraPosition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cameraPosition);
			return *(float3*)num;
		}
		set
		{
			*(float3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cameraPosition)) = value;
		}
	}

	public unsafe float sqrScreenRelativeMetric
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sqrScreenRelativeMetric);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sqrScreenRelativeMetric)) = value;
		}
	}

	public unsafe float minScreenRelativeHeight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minScreenRelativeHeight);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minScreenRelativeHeight)) = value;
		}
	}

	public unsafe bool isOrtho
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isOrtho);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isOrtho)) = value;
		}
	}

	public unsafe bool cullLightmappedShadowCasters
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cullLightmappedShadowCasters);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cullLightmappedShadowCasters)) = value;
		}
	}

	public unsafe int maxLOD
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxLOD);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxLOD)) = value;
		}
	}

	public unsafe uint cullingLayerMask
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cullingLayerMask);
			return *(uint*)num;
		}
		set
		{
			*(uint*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cullingLayerMask)) = value;
		}
	}

	public unsafe ulong sceneCullingMask
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sceneCullingMask);
			return *(ulong*)num;
		}
		set
		{
			*(ulong*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sceneCullingMask)) = value;
		}
	}

	public unsafe NativeArray<FrustumPlaneCuller.PlanePacket4> frustumPlanePackets
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_frustumPlanePackets);
			return new NativeArray<FrustumPlaneCuller.PlanePacket4>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<FrustumPlaneCuller.PlanePacket4>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_frustumPlanePackets), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<FrustumPlaneCuller.PlanePacket4>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeArray<FrustumPlaneCuller.SplitInfo> frustumSplitInfos
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_frustumSplitInfos);
			return new NativeArray<FrustumPlaneCuller.SplitInfo>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<FrustumPlaneCuller.SplitInfo>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_frustumSplitInfos), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<FrustumPlaneCuller.SplitInfo>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeArray<Plane> lightFacingFrustumPlanes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lightFacingFrustumPlanes);
			return new NativeArray<Plane>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<Plane>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lightFacingFrustumPlanes), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<Plane>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeArray<ReceiverSphereCuller.SplitInfo> receiverSplitInfos
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_receiverSplitInfos);
			return new NativeArray<ReceiverSphereCuller.SplitInfo>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<ReceiverSphereCuller.SplitInfo>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_receiverSplitInfos), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<ReceiverSphereCuller.SplitInfo>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe float3x3 worldToLightSpaceRotation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_worldToLightSpaceRotation);
			return *(float3x3*)num;
		}
		set
		{
			*(float3x3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_worldToLightSpaceRotation)) = value;
		}
	}

	public unsafe CPUInstanceData.ReadOnly instanceData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_instanceData);
			return new CPUInstanceData.ReadOnly(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CPUInstanceData.ReadOnly>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_instanceData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CPUInstanceData.ReadOnly>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe CPUSharedInstanceData.ReadOnly sharedInstanceData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sharedInstanceData);
			return new CPUSharedInstanceData.ReadOnly(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CPUSharedInstanceData.ReadOnly>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sharedInstanceData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CPUSharedInstanceData.ReadOnly>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeList<LODGroupCullingData> lodGroupCullingData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lodGroupCullingData);
			return new NativeList<LODGroupCullingData>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeList<LODGroupCullingData>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lodGroupCullingData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<LODGroupCullingData>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe System.IntPtr occlusionBuffer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_occlusionBuffer);
			return *(System.IntPtr*)num;
		}
		set
		{
			*(System.IntPtr*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_occlusionBuffer)) = value;
		}
	}

	public unsafe NativeArray<byte> rendererVisibilityMasks
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rendererVisibilityMasks);
			return new NativeArray<byte>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<byte>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rendererVisibilityMasks), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<byte>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeArray<byte> rendererCrossFadeValues
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rendererCrossFadeValues);
			return new NativeArray<byte>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<byte>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rendererCrossFadeValues), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<byte>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	static CullingJob()
	{
		Il2CppClassPointerStore<CullingJob>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.GPUDriven.Runtime.dll", "UnityEngine.Rendering", "CullingJob");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CullingJob>.NativeClassPtr);
		NativeFieldInfoPtr_binningConfig = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CullingJob>.NativeClassPtr, "binningConfig");
		NativeFieldInfoPtr_viewType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CullingJob>.NativeClassPtr, "viewType");
		NativeFieldInfoPtr_cameraPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CullingJob>.NativeClassPtr, "cameraPosition");
		NativeFieldInfoPtr_sqrScreenRelativeMetric = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CullingJob>.NativeClassPtr, "sqrScreenRelativeMetric");
		NativeFieldInfoPtr_minScreenRelativeHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CullingJob>.NativeClassPtr, "minScreenRelativeHeight");
		NativeFieldInfoPtr_isOrtho = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CullingJob>.NativeClassPtr, "isOrtho");
		NativeFieldInfoPtr_cullLightmappedShadowCasters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CullingJob>.NativeClassPtr, "cullLightmappedShadowCasters");
		NativeFieldInfoPtr_maxLOD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CullingJob>.NativeClassPtr, "maxLOD");
		NativeFieldInfoPtr_cullingLayerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CullingJob>.NativeClassPtr, "cullingLayerMask");
		NativeFieldInfoPtr_sceneCullingMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CullingJob>.NativeClassPtr, "sceneCullingMask");
		NativeFieldInfoPtr_frustumPlanePackets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CullingJob>.NativeClassPtr, "frustumPlanePackets");
		NativeFieldInfoPtr_frustumSplitInfos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CullingJob>.NativeClassPtr, "frustumSplitInfos");
		NativeFieldInfoPtr_lightFacingFrustumPlanes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CullingJob>.NativeClassPtr, "lightFacingFrustumPlanes");
		NativeFieldInfoPtr_receiverSplitInfos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CullingJob>.NativeClassPtr, "receiverSplitInfos");
		NativeFieldInfoPtr_worldToLightSpaceRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CullingJob>.NativeClassPtr, "worldToLightSpaceRotation");
		NativeFieldInfoPtr_instanceData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CullingJob>.NativeClassPtr, "instanceData");
		NativeFieldInfoPtr_sharedInstanceData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CullingJob>.NativeClassPtr, "sharedInstanceData");
		NativeFieldInfoPtr_lodGroupCullingData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CullingJob>.NativeClassPtr, "lodGroupCullingData");
		NativeFieldInfoPtr_occlusionBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CullingJob>.NativeClassPtr, "occlusionBuffer");
		NativeFieldInfoPtr_rendererVisibilityMasks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CullingJob>.NativeClassPtr, "rendererVisibilityMasks");
		NativeFieldInfoPtr_rendererCrossFadeValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CullingJob>.NativeClassPtr, "rendererCrossFadeValues");
		NativeMethodInfoPtr_PackFloatToUint8_Private_Static_UInt32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingJob>.NativeClassPtr, 100663546);
		NativeMethodInfoPtr_CalculateLODVisibility_Private_Single_Int32_Int32_InstanceFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingJob>.NativeClassPtr, 100663547);
		NativeMethodInfoPtr_CalculateVisibilityMask_Private_UInt32_Int32_Int32_InstanceFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingJob>.NativeClassPtr, 100663548);
		NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingJob>.NativeClassPtr, 100663549);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1069283, RefRangeEnd = 1069284, XrefRangeStart = 1069282, XrefRangeEnd = 1069283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static uint PackFloatToUint8(float percent)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&percent);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PackFloatToUint8_Private_Static_UInt32_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1069316, RefRangeEnd = 1069317, XrefRangeStart = 1069284, XrefRangeEnd = 1069316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float CalculateLODVisibility(int instanceIndex, int sharedInstanceIndex, InstanceFlags instanceFlags)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&instanceIndex);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &sharedInstanceIndex;
		*(InstanceFlags**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &instanceFlags;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalculateLODVisibility_Private_Single_Int32_Int32_InstanceFlags_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1069329, RefRangeEnd = 1069330, XrefRangeStart = 1069317, XrefRangeEnd = 1069329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe uint CalculateVisibilityMask(int instanceIndex, int sharedInstanceIndex, InstanceFlags instanceFlags)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&instanceIndex);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &sharedInstanceIndex;
		*(InstanceFlags**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &instanceFlags;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalculateVisibilityMask_Private_UInt32_Int32_Int32_InstanceFlags_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1069330, XrefRangeEnd = 1069345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Execute(int instanceIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&instanceIndex);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public CullingJob(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public CullingJob()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CullingJob>.NativeClassPtr))
	{
	}
}
