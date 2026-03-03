using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using Unity.Collections;
using Unity.Jobs;

namespace UnityEngine.Rendering;

public sealed class ReceiverPlanes : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_planes;

	private static readonly System.IntPtr NativeFieldInfoPtr_lightFacingPlaneCount;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsSignBitSet_Private_Static_Boolean_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LightFacingFrustumPlaneSubArray_Internal_NativeArray_1_Plane_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SilhouettePlaneSubArray_Internal_NativeArray_1_Plane_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Internal_Void_JobHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Create_Internal_Static_ReceiverPlanes_byref_BatchCullingContext_Allocator_0;

	public unsafe NativeList<Plane> planes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_planes);
			return new NativeList<Plane>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeList<Plane>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_planes), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<Plane>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe int lightFacingPlaneCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lightFacingPlaneCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lightFacingPlaneCount)) = value;
		}
	}

	static ReceiverPlanes()
	{
		Il2CppClassPointerStore<ReceiverPlanes>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.GPUDriven.Runtime.dll", "UnityEngine.Rendering", "ReceiverPlanes");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReceiverPlanes>.NativeClassPtr);
		NativeFieldInfoPtr_planes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceiverPlanes>.NativeClassPtr, "planes");
		NativeFieldInfoPtr_lightFacingPlaneCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceiverPlanes>.NativeClassPtr, "lightFacingPlaneCount");
		NativeMethodInfoPtr_IsSignBitSet_Private_Static_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceiverPlanes>.NativeClassPtr, 100663413);
		NativeMethodInfoPtr_LightFacingFrustumPlaneSubArray_Internal_NativeArray_1_Plane_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceiverPlanes>.NativeClassPtr, 100663414);
		NativeMethodInfoPtr_SilhouettePlaneSubArray_Internal_NativeArray_1_Plane_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceiverPlanes>.NativeClassPtr, 100663415);
		NativeMethodInfoPtr_Dispose_Internal_Void_JobHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceiverPlanes>.NativeClassPtr, 100663416);
		NativeMethodInfoPtr_Create_Internal_Static_ReceiverPlanes_byref_BatchCullingContext_Allocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceiverPlanes>.NativeClassPtr, 100663417);
	}

	[CallerCount(0)]
	public unsafe static bool IsSignBitSet(float x)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&x);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsSignBitSet_Private_Static_Boolean_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1067842, XrefRangeEnd = 1067848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe NativeArray<Plane> LightFacingFrustumPlaneSubArray()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LightFacingFrustumPlaneSubArray_Internal_NativeArray_1_Plane_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new NativeArray<Plane>(pointer);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1067848, XrefRangeEnd = 1067857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe NativeArray<Plane> SilhouettePlaneSubArray()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SilhouettePlaneSubArray_Internal_NativeArray_1_Plane_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new NativeArray<Plane>(pointer);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1067857, XrefRangeEnd = 1067860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 1067900, RefRangeEnd = 1067901, XrefRangeStart = 1067860, XrefRangeEnd = 1067900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ReceiverPlanes Create([In] ref BatchCullingContext cc, Allocator allocator)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)cc);
		*(Allocator**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &allocator;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Create_Internal_Static_ReceiverPlanes_byref_BatchCullingContext_Allocator_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new ReceiverPlanes(pointer);
	}

	public ReceiverPlanes(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public ReceiverPlanes()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReceiverPlanes>.NativeClassPtr))
	{
	}
}
