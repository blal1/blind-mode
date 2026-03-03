using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using Unity.Collections;

namespace UnityEngine.Rendering;

public sealed class PrefixSumDrawInstancesJob : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_rangeHash;

	private static readonly System.IntPtr NativeFieldInfoPtr_drawRanges;

	private static readonly System.IntPtr NativeFieldInfoPtr_drawBatches;

	private static readonly System.IntPtr NativeFieldInfoPtr_drawBatchIndices;

	private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0;

	public unsafe NativeParallelHashMap<RangeKey, int> rangeHash
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rangeHash);
			return new NativeParallelHashMap<RangeKey, int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeParallelHashMap<RangeKey, int>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rangeHash), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeParallelHashMap<RangeKey, int>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeList<DrawRange> drawRanges
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_drawRanges);
			return new NativeList<DrawRange>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeList<DrawRange>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_drawRanges), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<DrawRange>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeList<DrawBatch> drawBatches
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_drawBatches);
			return new NativeList<DrawBatch>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeList<DrawBatch>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_drawBatches), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<DrawBatch>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeArray<int> drawBatchIndices
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_drawBatchIndices);
			return new NativeArray<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_drawBatchIndices), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	static PrefixSumDrawInstancesJob()
	{
		Il2CppClassPointerStore<PrefixSumDrawInstancesJob>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.GPUDriven.Runtime.dll", "UnityEngine.Rendering", "PrefixSumDrawInstancesJob");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PrefixSumDrawInstancesJob>.NativeClassPtr);
		NativeFieldInfoPtr_rangeHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefixSumDrawInstancesJob>.NativeClassPtr, "rangeHash");
		NativeFieldInfoPtr_drawRanges = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefixSumDrawInstancesJob>.NativeClassPtr, "drawRanges");
		NativeFieldInfoPtr_drawBatches = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefixSumDrawInstancesJob>.NativeClassPtr, "drawBatches");
		NativeFieldInfoPtr_drawBatchIndices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefixSumDrawInstancesJob>.NativeClassPtr, "drawBatchIndices");
		NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefixSumDrawInstancesJob>.NativeClassPtr, 100663604);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1070124, XrefRangeEnd = 1070153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Execute()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public PrefixSumDrawInstancesJob(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public PrefixSumDrawInstancesJob()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PrefixSumDrawInstancesJob>.NativeClassPtr))
	{
	}
}
