using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;

namespace UnityEngine.Rendering;

public sealed class UpdateLODGroupDataJob : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_lodGroupInstances;

	private static readonly System.IntPtr NativeFieldInfoPtr_inputData;

	private static readonly System.IntPtr NativeFieldInfoPtr_supportDitheringCrossFade;

	private static readonly System.IntPtr NativeFieldInfoPtr_lodGroupsData;

	private static readonly System.IntPtr NativeFieldInfoPtr_lodGroupsCullingData;

	private static readonly System.IntPtr NativeFieldInfoPtr_rendererCount;

	private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_0;

	public unsafe NativeArray<GPUInstanceIndex> lodGroupInstances
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lodGroupInstances);
			return new NativeArray<GPUInstanceIndex>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<GPUInstanceIndex>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lodGroupInstances), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<GPUInstanceIndex>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe GPUDrivenLODGroupData inputData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inputData);
			return new GPUDrivenLODGroupData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GPUDrivenLODGroupData>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inputData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GPUDrivenLODGroupData>.NativeClassPtr, ref *(uint*)null));
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

	public unsafe NativeArray<LODGroupData> lodGroupsData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lodGroupsData);
			return new NativeArray<LODGroupData>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<LODGroupData>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lodGroupsData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<LODGroupData>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeArray<LODGroupCullingData> lodGroupsCullingData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lodGroupsCullingData);
			return new NativeArray<LODGroupCullingData>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<LODGroupCullingData>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lodGroupsCullingData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<LODGroupCullingData>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe UnsafeAtomicCounter32 rendererCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rendererCount);
			return *(UnsafeAtomicCounter32*)num;
		}
		set
		{
			*(UnsafeAtomicCounter32*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rendererCount)) = value;
		}
	}

	static UpdateLODGroupDataJob()
	{
		Il2CppClassPointerStore<UpdateLODGroupDataJob>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.GPUDriven.Runtime.dll", "UnityEngine.Rendering", "UpdateLODGroupDataJob");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UpdateLODGroupDataJob>.NativeClassPtr);
		NativeFieldInfoPtr_lodGroupInstances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateLODGroupDataJob>.NativeClassPtr, "lodGroupInstances");
		NativeFieldInfoPtr_inputData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateLODGroupDataJob>.NativeClassPtr, "inputData");
		NativeFieldInfoPtr_supportDitheringCrossFade = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateLODGroupDataJob>.NativeClassPtr, "supportDitheringCrossFade");
		NativeFieldInfoPtr_lodGroupsData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateLODGroupDataJob>.NativeClassPtr, "lodGroupsData");
		NativeFieldInfoPtr_lodGroupsCullingData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateLODGroupDataJob>.NativeClassPtr, "lodGroupsCullingData");
		NativeFieldInfoPtr_rendererCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateLODGroupDataJob>.NativeClassPtr, "rendererCount");
		NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateLODGroupDataJob>.NativeClassPtr, 100663942);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1074042, XrefRangeEnd = 1074056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Execute(int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&index);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public UpdateLODGroupDataJob(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public UpdateLODGroupDataJob()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UpdateLODGroupDataJob>.NativeClassPtr))
	{
	}
}
