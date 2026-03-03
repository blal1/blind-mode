using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using Unity.Collections;

namespace UnityEngine.Rendering;

public sealed class AllocateBinsPerBatch : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_binningConfig;

	private static readonly System.IntPtr NativeFieldInfoPtr_drawBatches;

	private static readonly System.IntPtr NativeFieldInfoPtr_drawInstanceIndices;

	private static readonly System.IntPtr NativeFieldInfoPtr_instanceData;

	private static readonly System.IntPtr NativeFieldInfoPtr_rendererVisibilityMasks;

	private static readonly System.IntPtr NativeFieldInfoPtr_batchBinAllocOffsets;

	private static readonly System.IntPtr NativeFieldInfoPtr_batchBinCounts;

	private static readonly System.IntPtr NativeFieldInfoPtr_binAllocCounter;

	private static readonly System.IntPtr NativeFieldInfoPtr_binConfigIndices;

	private static readonly System.IntPtr NativeFieldInfoPtr_binVisibleInstanceCounts;

	private static readonly System.IntPtr NativeFieldInfoPtr_debugCounterIndexBase;

	private static readonly System.IntPtr NativeFieldInfoPtr_splitDebugCounters;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsInstanceFlipped_Private_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPrimitiveCount_Private_Static_Int32_Int32_MeshTopology_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_0;

	public unsafe BinningConfig binningConfig
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_binningConfig);
			return *(BinningConfig*)num;
		}
		set
		{
			*(BinningConfig*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_binningConfig)) = value;
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

	public unsafe CPUInstanceData.ReadOnly instanceData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_instanceData);
			return new CPUInstanceData.ReadOnly(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CPUInstanceData.ReadOnly>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_instanceData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CPUInstanceData.ReadOnly>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeArray<byte> rendererVisibilityMasks
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rendererVisibilityMasks);
			return new NativeArray<byte>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<byte>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rendererVisibilityMasks), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<byte>>.NativeClassPtr, ref *(uint*)null));
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

	public unsafe NativeArray<int> binAllocCounter
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_binAllocCounter);
			return new NativeArray<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_binAllocCounter), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeArray<short> binConfigIndices
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_binConfigIndices);
			return new NativeArray<short>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<short>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_binConfigIndices), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<short>>.NativeClassPtr, ref *(uint*)null));
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

	public unsafe int debugCounterIndexBase
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugCounterIndexBase);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugCounterIndexBase)) = value;
		}
	}

	public unsafe NativeArray<int> splitDebugCounters
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_splitDebugCounters);
			return new NativeArray<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_splitDebugCounters), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	static AllocateBinsPerBatch()
	{
		Il2CppClassPointerStore<AllocateBinsPerBatch>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.GPUDriven.Runtime.dll", "UnityEngine.Rendering", "AllocateBinsPerBatch");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AllocateBinsPerBatch>.NativeClassPtr);
		NativeFieldInfoPtr_binningConfig = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AllocateBinsPerBatch>.NativeClassPtr, "binningConfig");
		NativeFieldInfoPtr_drawBatches = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AllocateBinsPerBatch>.NativeClassPtr, "drawBatches");
		NativeFieldInfoPtr_drawInstanceIndices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AllocateBinsPerBatch>.NativeClassPtr, "drawInstanceIndices");
		NativeFieldInfoPtr_instanceData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AllocateBinsPerBatch>.NativeClassPtr, "instanceData");
		NativeFieldInfoPtr_rendererVisibilityMasks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AllocateBinsPerBatch>.NativeClassPtr, "rendererVisibilityMasks");
		NativeFieldInfoPtr_batchBinAllocOffsets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AllocateBinsPerBatch>.NativeClassPtr, "batchBinAllocOffsets");
		NativeFieldInfoPtr_batchBinCounts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AllocateBinsPerBatch>.NativeClassPtr, "batchBinCounts");
		NativeFieldInfoPtr_binAllocCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AllocateBinsPerBatch>.NativeClassPtr, "binAllocCounter");
		NativeFieldInfoPtr_binConfigIndices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AllocateBinsPerBatch>.NativeClassPtr, "binConfigIndices");
		NativeFieldInfoPtr_binVisibleInstanceCounts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AllocateBinsPerBatch>.NativeClassPtr, "binVisibleInstanceCounts");
		NativeFieldInfoPtr_debugCounterIndexBase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AllocateBinsPerBatch>.NativeClassPtr, "debugCounterIndexBase");
		NativeFieldInfoPtr_splitDebugCounters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AllocateBinsPerBatch>.NativeClassPtr, "splitDebugCounters");
		NativeMethodInfoPtr_IsInstanceFlipped_Private_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AllocateBinsPerBatch>.NativeClassPtr, 100663550);
		NativeMethodInfoPtr_GetPrimitiveCount_Private_Static_Int32_Int32_MeshTopology_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AllocateBinsPerBatch>.NativeClassPtr, 100663551);
		NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AllocateBinsPerBatch>.NativeClassPtr, 100663552);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1069351, RefRangeEnd = 1069352, XrefRangeStart = 1069345, XrefRangeEnd = 1069351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsInstanceFlipped(int rendererIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&rendererIndex);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsInstanceFlipped_Private_Boolean_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1069352, RefRangeEnd = 1069353, XrefRangeStart = 1069352, XrefRangeEnd = 1069352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetPrimitiveCount(int indexCount, MeshTopology topology, bool nativeQuads)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&indexCount);
		*(MeshTopology**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &topology;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &nativeQuads;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPrimitiveCount_Private_Static_Int32_Int32_MeshTopology_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1069353, XrefRangeEnd = 1069385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Execute(int batchIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&batchIndex);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public AllocateBinsPerBatch(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public AllocateBinsPerBatch()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AllocateBinsPerBatch>.NativeClassPtr))
	{
	}
}
