using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using Unity.Collections;

namespace UnityEngine.Rendering;

public sealed class PrefixSumDrawsAndInstances : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_drawRanges;

	private static readonly System.IntPtr NativeFieldInfoPtr_drawBatchIndices;

	private static readonly System.IntPtr NativeFieldInfoPtr_batchBinAllocOffsets;

	private static readonly System.IntPtr NativeFieldInfoPtr_batchBinCounts;

	private static readonly System.IntPtr NativeFieldInfoPtr_binVisibleInstanceCounts;

	private static readonly System.IntPtr NativeFieldInfoPtr_batchDrawCommandOffsets;

	private static readonly System.IntPtr NativeFieldInfoPtr_binVisibleInstanceOffsets;

	private static readonly System.IntPtr NativeFieldInfoPtr_cullingOutput;

	private static readonly System.IntPtr NativeFieldInfoPtr_indirectBufferLimits;

	private static readonly System.IntPtr NativeFieldInfoPtr_indirectBufferAllocInfo;

	private static readonly System.IntPtr NativeFieldInfoPtr_indirectAllocationCounters;

	private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0;

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

	public unsafe NativeArray<int> batchBinAllocOffsets
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_batchBinAllocOffsets);
			return new NativeArray<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_batchBinAllocOffsets), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeArray<int> batchBinCounts
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_batchBinCounts);
			return new NativeArray<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_batchBinCounts), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeArray<int> binVisibleInstanceCounts
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_binVisibleInstanceCounts);
			return new NativeArray<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_binVisibleInstanceCounts), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeArray<int> batchDrawCommandOffsets
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_batchDrawCommandOffsets);
			return new NativeArray<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_batchDrawCommandOffsets), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeArray<int> binVisibleInstanceOffsets
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_binVisibleInstanceOffsets);
			return new NativeArray<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_binVisibleInstanceOffsets), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeArray<BatchCullingOutputDrawCommands> cullingOutput
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cullingOutput);
			return new NativeArray<BatchCullingOutputDrawCommands>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<BatchCullingOutputDrawCommands>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cullingOutput), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<BatchCullingOutputDrawCommands>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe IndirectBufferLimits indirectBufferLimits
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_indirectBufferLimits);
			return *(IndirectBufferLimits*)num;
		}
		set
		{
			*(IndirectBufferLimits*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_indirectBufferLimits)) = value;
		}
	}

	public unsafe NativeArray<IndirectBufferAllocInfo> indirectBufferAllocInfo
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_indirectBufferAllocInfo);
			return new NativeArray<IndirectBufferAllocInfo>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<IndirectBufferAllocInfo>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_indirectBufferAllocInfo), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<IndirectBufferAllocInfo>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeArray<int> indirectAllocationCounters
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_indirectAllocationCounters);
			return new NativeArray<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_indirectAllocationCounters), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	static PrefixSumDrawsAndInstances()
	{
		Il2CppClassPointerStore<PrefixSumDrawsAndInstances>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.GPUDriven.Runtime.dll", "UnityEngine.Rendering", "PrefixSumDrawsAndInstances");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PrefixSumDrawsAndInstances>.NativeClassPtr);
		NativeFieldInfoPtr_drawRanges = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefixSumDrawsAndInstances>.NativeClassPtr, "drawRanges");
		NativeFieldInfoPtr_drawBatchIndices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefixSumDrawsAndInstances>.NativeClassPtr, "drawBatchIndices");
		NativeFieldInfoPtr_batchBinAllocOffsets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefixSumDrawsAndInstances>.NativeClassPtr, "batchBinAllocOffsets");
		NativeFieldInfoPtr_batchBinCounts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefixSumDrawsAndInstances>.NativeClassPtr, "batchBinCounts");
		NativeFieldInfoPtr_binVisibleInstanceCounts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefixSumDrawsAndInstances>.NativeClassPtr, "binVisibleInstanceCounts");
		NativeFieldInfoPtr_batchDrawCommandOffsets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefixSumDrawsAndInstances>.NativeClassPtr, "batchDrawCommandOffsets");
		NativeFieldInfoPtr_binVisibleInstanceOffsets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefixSumDrawsAndInstances>.NativeClassPtr, "binVisibleInstanceOffsets");
		NativeFieldInfoPtr_cullingOutput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefixSumDrawsAndInstances>.NativeClassPtr, "cullingOutput");
		NativeFieldInfoPtr_indirectBufferLimits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefixSumDrawsAndInstances>.NativeClassPtr, "indirectBufferLimits");
		NativeFieldInfoPtr_indirectBufferAllocInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefixSumDrawsAndInstances>.NativeClassPtr, "indirectBufferAllocInfo");
		NativeFieldInfoPtr_indirectAllocationCounters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefixSumDrawsAndInstances>.NativeClassPtr, "indirectAllocationCounters");
		NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefixSumDrawsAndInstances>.NativeClassPtr, 100663553);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1069420, RefRangeEnd = 1069421, XrefRangeStart = 1069385, XrefRangeEnd = 1069420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Execute()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public PrefixSumDrawsAndInstances(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public PrefixSumDrawsAndInstances()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PrefixSumDrawsAndInstances>.NativeClassPtr))
	{
	}
}
