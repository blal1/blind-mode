using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;

namespace UnityEngine.Rendering;

public sealed class ReceiverSphereCuller : Il2CppSystem.ValueType
{
	[StructLayout(LayoutKind.Explicit)]
	public struct SplitInfo
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_receiverSphereLightSpace;

		private static readonly System.IntPtr NativeFieldInfoPtr_cascadeBlendCullingFactor;

		[FieldOffset(0)]
		public float4 receiverSphereLightSpace;

		[FieldOffset(16)]
		public float cascadeBlendCullingFactor;

		static SplitInfo()
		{
			Il2CppClassPointerStore<SplitInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReceiverSphereCuller>.NativeClassPtr, "SplitInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SplitInfo>.NativeClassPtr);
			NativeFieldInfoPtr_receiverSphereLightSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SplitInfo>.NativeClassPtr, "receiverSphereLightSpace");
			NativeFieldInfoPtr_cascadeBlendCullingFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SplitInfo>.NativeClassPtr, "cascadeBlendCullingFactor");
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SplitInfo>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_splitInfos;

	private static readonly System.IntPtr NativeFieldInfoPtr_worldToLightSpaceRotation;

	private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Internal_Void_JobHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UseReceiverPlanes_Internal_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Create_Internal_Static_ReceiverSphereCuller_byref_BatchCullingContext_Allocator_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DistanceUntilCylinderFullyCrossesPlane_Internal_Static_Single_float3_float3_Single_Plane_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ComputeSplitVisibilityMask_Internal_Static_UInt32_NativeArray_1_Plane_NativeArray_1_SplitInfo_float3x3_byref_AABB_0;

	public unsafe NativeList<SplitInfo> splitInfos
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_splitInfos);
			return new NativeList<SplitInfo>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeList<SplitInfo>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_splitInfos), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<SplitInfo>>.NativeClassPtr, ref *(uint*)null));
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

	static ReceiverSphereCuller()
	{
		Il2CppClassPointerStore<ReceiverSphereCuller>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.GPUDriven.Runtime.dll", "UnityEngine.Rendering", "ReceiverSphereCuller");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReceiverSphereCuller>.NativeClassPtr);
		NativeFieldInfoPtr_splitInfos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceiverSphereCuller>.NativeClassPtr, "splitInfos");
		NativeFieldInfoPtr_worldToLightSpaceRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceiverSphereCuller>.NativeClassPtr, "worldToLightSpaceRotation");
		NativeMethodInfoPtr_Dispose_Internal_Void_JobHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceiverSphereCuller>.NativeClassPtr, 100663422);
		NativeMethodInfoPtr_UseReceiverPlanes_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceiverSphereCuller>.NativeClassPtr, 100663423);
		NativeMethodInfoPtr_Create_Internal_Static_ReceiverSphereCuller_byref_BatchCullingContext_Allocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceiverSphereCuller>.NativeClassPtr, 100663424);
		NativeMethodInfoPtr_DistanceUntilCylinderFullyCrossesPlane_Internal_Static_Single_float3_float3_Single_Plane_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceiverSphereCuller>.NativeClassPtr, 100663425);
		NativeMethodInfoPtr_ComputeSplitVisibilityMask_Internal_Static_UInt32_NativeArray_1_Plane_NativeArray_1_SplitInfo_float3x3_byref_AABB_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceiverSphereCuller>.NativeClassPtr, 100663426);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1067962, XrefRangeEnd = 1067965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Dispose(JobHandle job)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&job);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dispose_Internal_Void_JobHandle_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1067965, XrefRangeEnd = 1067968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool UseReceiverPlanes()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UseReceiverPlanes_Internal_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1067981, RefRangeEnd = 1067982, XrefRangeStart = 1067968, XrefRangeEnd = 1067981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ReceiverSphereCuller Create([In] ref BatchCullingContext cc, Allocator allocator)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)cc);
		*(Allocator**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &allocator;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Create_Internal_Static_ReceiverSphereCuller_byref_BatchCullingContext_Allocator_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new ReceiverSphereCuller(pointer);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1067985, RefRangeEnd = 1067986, XrefRangeStart = 1067982, XrefRangeEnd = 1067985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float DistanceUntilCylinderFullyCrossesPlane(float3 cylinderCenter, float3 cylinderDirection, float cylinderRadius, Plane plane)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&cylinderCenter);
		*(float3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &cylinderDirection;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &cylinderRadius;
		*(Plane**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &plane;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DistanceUntilCylinderFullyCrossesPlane_Internal_Static_Single_float3_float3_Single_Plane_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1067988, RefRangeEnd = 1067989, XrefRangeStart = 1067986, XrefRangeEnd = 1067988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static uint ComputeSplitVisibilityMask(NativeArray<Plane> lightFacingFrustumPlanes, NativeArray<SplitInfo> splitInfos, float3x3 worldToLightSpaceRotation, [In] ref AABB bounds)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)lightFacingFrustumPlanes));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)splitInfos));
		*(float3x3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &worldToLightSpaceRotation;
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref bounds);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ComputeSplitVisibilityMask_Internal_Static_UInt32_NativeArray_1_Plane_NativeArray_1_SplitInfo_float3x3_byref_AABB_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public ReceiverSphereCuller(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public ReceiverSphereCuller()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReceiverSphereCuller>.NativeClassPtr))
	{
	}
}
