using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using Unity.Collections;

namespace UnityEngine.Rendering;

public sealed class FindNonRegisteredMeshesJob : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_instanceIDs;

	private static readonly System.IntPtr NativeFieldInfoPtr_hashMap;

	private static readonly System.IntPtr NativeFieldInfoPtr_outInstancesWriter;

	private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_Int32_0;

	public unsafe NativeArray<int> instanceIDs
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_instanceIDs);
			return new NativeArray<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_instanceIDs), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeParallelHashMap<int, BatchMeshID> hashMap
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hashMap);
			return new NativeParallelHashMap<int, BatchMeshID>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeParallelHashMap<int, BatchMeshID>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hashMap), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeParallelHashMap<int, BatchMeshID>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeList<int>.ParallelWriter outInstancesWriter
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_outInstancesWriter);
			return new NativeList<int>.ParallelWriter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeList<int>.ParallelWriter>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_outInstancesWriter), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<int>.ParallelWriter>.NativeClassPtr, ref *(uint*)null));
		}
	}

	static FindNonRegisteredMeshesJob()
	{
		Il2CppClassPointerStore<FindNonRegisteredMeshesJob>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.GPUDriven.Runtime.dll", "UnityEngine.Rendering", "FindNonRegisteredMeshesJob");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FindNonRegisteredMeshesJob>.NativeClassPtr);
		NativeFieldInfoPtr_instanceIDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FindNonRegisteredMeshesJob>.NativeClassPtr, "instanceIDs");
		NativeFieldInfoPtr_hashMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FindNonRegisteredMeshesJob>.NativeClassPtr, "hashMap");
		NativeFieldInfoPtr_outInstancesWriter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FindNonRegisteredMeshesJob>.NativeClassPtr, "outInstancesWriter");
		NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FindNonRegisteredMeshesJob>.NativeClassPtr, 100663609);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1070195, XrefRangeEnd = 1070212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	public FindNonRegisteredMeshesJob(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public FindNonRegisteredMeshesJob()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FindNonRegisteredMeshesJob>.NativeClassPtr))
	{
	}
}
