using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;

namespace UnityEngine.Rendering;

public sealed class UpdateLODGroupTransformJob : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_lodGroupDataHash;

	private static readonly System.IntPtr NativeFieldInfoPtr_lodGroupIDs;

	private static readonly System.IntPtr NativeFieldInfoPtr_worldSpaceReferencePoints;

	private static readonly System.IntPtr NativeFieldInfoPtr_worldSpaceSizes;

	private static readonly System.IntPtr NativeFieldInfoPtr_requiresGPUUpload;

	private static readonly System.IntPtr NativeFieldInfoPtr_supportDitheringCrossFade;

	private static readonly System.IntPtr NativeFieldInfoPtr_lodGroupData;

	private static readonly System.IntPtr NativeFieldInfoPtr_lodGroupCullingData;

	private static readonly System.IntPtr NativeFieldInfoPtr_atomicUpdateCount;

	private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_0;

	public unsafe NativeParallelHashMap<int, GPUInstanceIndex> lodGroupDataHash
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lodGroupDataHash);
			return new NativeParallelHashMap<int, GPUInstanceIndex>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeParallelHashMap<int, GPUInstanceIndex>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lodGroupDataHash), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeParallelHashMap<int, GPUInstanceIndex>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeArray<int> lodGroupIDs
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lodGroupIDs);
			return new NativeArray<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lodGroupIDs), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeArray<Vector3> worldSpaceReferencePoints
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_worldSpaceReferencePoints);
			return new NativeArray<Vector3>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<Vector3>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_worldSpaceReferencePoints), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<Vector3>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeArray<float> worldSpaceSizes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_worldSpaceSizes);
			return new NativeArray<float>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<float>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_worldSpaceSizes), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<float>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe bool requiresGPUUpload
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_requiresGPUUpload);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_requiresGPUUpload)) = value;
		}
	}

	public unsafe bool supportDitheringCrossFade
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_supportDitheringCrossFade);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_supportDitheringCrossFade)) = value;
		}
	}

	public unsafe NativeList<LODGroupData> lodGroupData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lodGroupData);
			return new NativeList<LODGroupData>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeList<LODGroupData>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lodGroupData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<LODGroupData>>.NativeClassPtr, ref *(uint*)null));
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

	public unsafe UnsafeAtomicCounter32 atomicUpdateCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_atomicUpdateCount);
			return *(UnsafeAtomicCounter32*)num;
		}
		set
		{
			*(UnsafeAtomicCounter32*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_atomicUpdateCount)) = value;
		}
	}

	static UpdateLODGroupTransformJob()
	{
		Il2CppClassPointerStore<UpdateLODGroupTransformJob>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.GPUDriven.Runtime.dll", "UnityEngine.Rendering", "UpdateLODGroupTransformJob");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UpdateLODGroupTransformJob>.NativeClassPtr);
		NativeFieldInfoPtr_lodGroupDataHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateLODGroupTransformJob>.NativeClassPtr, "lodGroupDataHash");
		NativeFieldInfoPtr_lodGroupIDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateLODGroupTransformJob>.NativeClassPtr, "lodGroupIDs");
		NativeFieldInfoPtr_worldSpaceReferencePoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateLODGroupTransformJob>.NativeClassPtr, "worldSpaceReferencePoints");
		NativeFieldInfoPtr_worldSpaceSizes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateLODGroupTransformJob>.NativeClassPtr, "worldSpaceSizes");
		NativeFieldInfoPtr_requiresGPUUpload = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateLODGroupTransformJob>.NativeClassPtr, "requiresGPUUpload");
		NativeFieldInfoPtr_supportDitheringCrossFade = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateLODGroupTransformJob>.NativeClassPtr, "supportDitheringCrossFade");
		NativeFieldInfoPtr_lodGroupData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateLODGroupTransformJob>.NativeClassPtr, "lodGroupData");
		NativeFieldInfoPtr_lodGroupCullingData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateLODGroupTransformJob>.NativeClassPtr, "lodGroupCullingData");
		NativeFieldInfoPtr_atomicUpdateCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateLODGroupTransformJob>.NativeClassPtr, "atomicUpdateCount");
		NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateLODGroupTransformJob>.NativeClassPtr, 100663941);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1074027, XrefRangeEnd = 1074042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Execute(int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&index);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public UpdateLODGroupTransformJob(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public UpdateLODGroupTransformJob()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UpdateLODGroupTransformJob>.NativeClassPtr))
	{
	}
}
