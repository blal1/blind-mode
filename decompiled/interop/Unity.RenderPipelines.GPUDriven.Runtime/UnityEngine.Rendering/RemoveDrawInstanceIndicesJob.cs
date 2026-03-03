using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using Unity.Collections;

namespace UnityEngine.Rendering;

public sealed class RemoveDrawInstanceIndicesJob : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_drawInstanceIndices;

	private static readonly System.IntPtr NativeFieldInfoPtr_drawInstances;

	private static readonly System.IntPtr NativeFieldInfoPtr_rangeHash;

	private static readonly System.IntPtr NativeFieldInfoPtr_batchHash;

	private static readonly System.IntPtr NativeFieldInfoPtr_drawRanges;

	private static readonly System.IntPtr NativeFieldInfoPtr_drawBatches;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveDrawRange_Public_Void_byref_RangeKey_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveDrawBatch_Public_Void_byref_DrawKey_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0;

	public unsafe NativeArray<int> drawInstanceIndices
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_drawInstanceIndices);
			return new NativeArray<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_drawInstanceIndices), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, ref *(uint*)null));
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

	public unsafe NativeParallelHashMap<DrawKey, int> batchHash
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_batchHash);
			return new NativeParallelHashMap<DrawKey, int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeParallelHashMap<DrawKey, int>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_batchHash), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeParallelHashMap<DrawKey, int>>.NativeClassPtr, ref *(uint*)null));
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

	static RemoveDrawInstanceIndicesJob()
	{
		Il2CppClassPointerStore<RemoveDrawInstanceIndicesJob>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.GPUDriven.Runtime.dll", "UnityEngine.Rendering", "RemoveDrawInstanceIndicesJob");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemoveDrawInstanceIndicesJob>.NativeClassPtr);
		NativeFieldInfoPtr_drawInstanceIndices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoveDrawInstanceIndicesJob>.NativeClassPtr, "drawInstanceIndices");
		NativeFieldInfoPtr_drawInstances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoveDrawInstanceIndicesJob>.NativeClassPtr, "drawInstances");
		NativeFieldInfoPtr_rangeHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoveDrawInstanceIndicesJob>.NativeClassPtr, "rangeHash");
		NativeFieldInfoPtr_batchHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoveDrawInstanceIndicesJob>.NativeClassPtr, "batchHash");
		NativeFieldInfoPtr_drawRanges = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoveDrawInstanceIndicesJob>.NativeClassPtr, "drawRanges");
		NativeFieldInfoPtr_drawBatches = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoveDrawInstanceIndicesJob>.NativeClassPtr, "drawBatches");
		NativeMethodInfoPtr_RemoveDrawRange_Public_Void_byref_RangeKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoveDrawInstanceIndicesJob>.NativeClassPtr, 100663613);
		NativeMethodInfoPtr_RemoveDrawBatch_Public_Void_byref_DrawKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoveDrawInstanceIndicesJob>.NativeClassPtr, 100663614);
		NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoveDrawInstanceIndicesJob>.NativeClassPtr, 100663615);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1070271, RefRangeEnd = 1070272, XrefRangeStart = 1070253, XrefRangeEnd = 1070271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveDrawRange([In] ref RangeKey key)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref key);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveDrawRange_Public_Void_byref_RangeKey_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1070299, RefRangeEnd = 1070300, XrefRangeStart = 1070272, XrefRangeEnd = 1070299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveDrawBatch([In] ref DrawKey key)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref key);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveDrawBatch_Public_Void_byref_DrawKey_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1070300, XrefRangeEnd = 1070318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Execute()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public RemoveDrawInstanceIndicesJob(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public RemoveDrawInstanceIndicesJob()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RemoveDrawInstanceIndicesJob>.NativeClassPtr))
	{
	}
}
