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

public sealed class FrustumPlaneCuller : Il2CppSystem.ValueType
{
	[StructLayout(LayoutKind.Explicit)]
	public struct PlanePacket4
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_nx;

		private static readonly System.IntPtr NativeFieldInfoPtr_ny;

		private static readonly System.IntPtr NativeFieldInfoPtr_nz;

		private static readonly System.IntPtr NativeFieldInfoPtr_d;

		private static readonly System.IntPtr NativeFieldInfoPtr_nxAbs;

		private static readonly System.IntPtr NativeFieldInfoPtr_nyAbs;

		private static readonly System.IntPtr NativeFieldInfoPtr_nzAbs;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_NativeArray_1_Plane_Int32_Int32_0;

		[FieldOffset(0)]
		public float4 nx;

		[FieldOffset(16)]
		public float4 ny;

		[FieldOffset(32)]
		public float4 nz;

		[FieldOffset(48)]
		public float4 d;

		[FieldOffset(64)]
		public float4 nxAbs;

		[FieldOffset(80)]
		public float4 nyAbs;

		[FieldOffset(96)]
		public float4 nzAbs;

		static PlanePacket4()
		{
			Il2CppClassPointerStore<PlanePacket4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FrustumPlaneCuller>.NativeClassPtr, "PlanePacket4");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlanePacket4>.NativeClassPtr);
			NativeFieldInfoPtr_nx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlanePacket4>.NativeClassPtr, "nx");
			NativeFieldInfoPtr_ny = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlanePacket4>.NativeClassPtr, "ny");
			NativeFieldInfoPtr_nz = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlanePacket4>.NativeClassPtr, "nz");
			NativeFieldInfoPtr_d = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlanePacket4>.NativeClassPtr, "d");
			NativeFieldInfoPtr_nxAbs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlanePacket4>.NativeClassPtr, "nxAbs");
			NativeFieldInfoPtr_nyAbs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlanePacket4>.NativeClassPtr, "nyAbs");
			NativeFieldInfoPtr_nzAbs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlanePacket4>.NativeClassPtr, "nzAbs");
			NativeMethodInfoPtr__ctor_Public_Void_NativeArray_1_Plane_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlanePacket4>.NativeClassPtr, 100663421);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1067901, RefRangeEnd = 1067902, XrefRangeStart = 1067901, XrefRangeEnd = 1067901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlanePacket4(NativeArray<Plane> planes, int offset, int limit)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[3];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)planes));
			*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &offset;
			*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &limit;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_NativeArray_1_Plane_Int32_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PlanePacket4>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct SplitInfo
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_packetCount;

		[FieldOffset(0)]
		public int packetCount;

		static SplitInfo()
		{
			Il2CppClassPointerStore<SplitInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FrustumPlaneCuller>.NativeClassPtr, "SplitInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SplitInfo>.NativeClassPtr);
			NativeFieldInfoPtr_packetCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SplitInfo>.NativeClassPtr, "packetCount");
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SplitInfo>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_planePackets;

	private static readonly System.IntPtr NativeFieldInfoPtr_splitInfos;

	private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Internal_Void_JobHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Create_Internal_Static_FrustumPlaneCuller_byref_BatchCullingContext_NativeArray_1_Plane_byref_ReceiverSphereCuller_Allocator_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ComputeSplitVisibilityMask_Internal_Static_UInt32_NativeArray_1_PlanePacket4_NativeArray_1_SplitInfo_byref_AABB_0;

	public unsafe NativeList<PlanePacket4> planePackets
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_planePackets);
			return new NativeList<PlanePacket4>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeList<PlanePacket4>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_planePackets), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<PlanePacket4>>.NativeClassPtr, ref *(uint*)null));
		}
	}

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

	static FrustumPlaneCuller()
	{
		Il2CppClassPointerStore<FrustumPlaneCuller>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.GPUDriven.Runtime.dll", "UnityEngine.Rendering", "FrustumPlaneCuller");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FrustumPlaneCuller>.NativeClassPtr);
		NativeFieldInfoPtr_planePackets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrustumPlaneCuller>.NativeClassPtr, "planePackets");
		NativeFieldInfoPtr_splitInfos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrustumPlaneCuller>.NativeClassPtr, "splitInfos");
		NativeMethodInfoPtr_Dispose_Internal_Void_JobHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrustumPlaneCuller>.NativeClassPtr, 100663418);
		NativeMethodInfoPtr_Create_Internal_Static_FrustumPlaneCuller_byref_BatchCullingContext_NativeArray_1_Plane_byref_ReceiverSphereCuller_Allocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrustumPlaneCuller>.NativeClassPtr, 100663419);
		NativeMethodInfoPtr_ComputeSplitVisibilityMask_Internal_Static_UInt32_NativeArray_1_PlanePacket4_NativeArray_1_SplitInfo_byref_AABB_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrustumPlaneCuller>.NativeClassPtr, 100663420);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1067902, XrefRangeEnd = 1067908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Dispose(JobHandle job)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&job);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dispose_Internal_Void_JobHandle_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1067957, RefRangeEnd = 1067958, XrefRangeStart = 1067908, XrefRangeEnd = 1067957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static FrustumPlaneCuller Create([In] ref BatchCullingContext cc, NativeArray<Plane> receiverPlanes, [In] ref ReceiverSphereCuller receiverSphereCuller, Allocator allocator)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)cc);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)receiverPlanes));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)receiverSphereCuller);
		*(Allocator**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &allocator;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Create_Internal_Static_FrustumPlaneCuller_byref_BatchCullingContext_NativeArray_1_Plane_byref_ReceiverSphereCuller_Allocator_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new FrustumPlaneCuller(pointer);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1067961, RefRangeEnd = 1067962, XrefRangeStart = 1067958, XrefRangeEnd = 1067961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static uint ComputeSplitVisibilityMask(NativeArray<PlanePacket4> planePackets, NativeArray<SplitInfo> splitInfos, [In] ref AABB bounds)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)planePackets));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)splitInfos));
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref bounds);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ComputeSplitVisibilityMask_Internal_Static_UInt32_NativeArray_1_PlanePacket4_NativeArray_1_SplitInfo_byref_AABB_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public FrustumPlaneCuller(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public FrustumPlaneCuller()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FrustumPlaneCuller>.NativeClassPtr))
	{
	}
}
