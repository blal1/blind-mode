using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using Unity.Collections;

namespace UnityEngine.Rendering;

public sealed class FindMaterialDrawInstancesJob : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_materialsSorted;

	private static readonly System.IntPtr NativeFieldInfoPtr_drawInstances;

	private static readonly System.IntPtr NativeFieldInfoPtr_outDrawInstanceIndicesWriter;

	private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_Int32_0;

	public unsafe NativeArray<uint> materialsSorted
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_materialsSorted);
			return new NativeArray<uint>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<uint>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_materialsSorted), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<uint>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeList<DrawInstance> drawInstances
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_drawInstances);
			return new NativeList<DrawInstance>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeList<DrawInstance>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_drawInstances), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<DrawInstance>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeList<int>.ParallelWriter outDrawInstanceIndicesWriter
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_outDrawInstanceIndicesWriter);
			return new NativeList<int>.ParallelWriter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeList<int>.ParallelWriter>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_outDrawInstanceIndicesWriter), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<int>.ParallelWriter>.NativeClassPtr, ref *(uint*)null));
		}
	}

	static FindMaterialDrawInstancesJob()
	{
		Il2CppClassPointerStore<FindMaterialDrawInstancesJob>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.GPUDriven.Runtime.dll", "UnityEngine.Rendering", "FindMaterialDrawInstancesJob");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FindMaterialDrawInstancesJob>.NativeClassPtr);
		NativeFieldInfoPtr_materialsSorted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FindMaterialDrawInstancesJob>.NativeClassPtr, "materialsSorted");
		NativeFieldInfoPtr_drawInstances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FindMaterialDrawInstancesJob>.NativeClassPtr, "drawInstances");
		NativeFieldInfoPtr_outDrawInstanceIndicesWriter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FindMaterialDrawInstancesJob>.NativeClassPtr, "outDrawInstanceIndicesWriter");
		NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FindMaterialDrawInstancesJob>.NativeClassPtr, 100663608);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1070185, XrefRangeEnd = 1070195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	public FindMaterialDrawInstancesJob(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public FindMaterialDrawInstancesJob()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FindMaterialDrawInstancesJob>.NativeClassPtr))
	{
	}
}
