using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using Unity.Collections;

namespace UnityEngine.Rendering;

public sealed class DrawCommandOutputPerBatch : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_binningConfig;

	private static readonly System.IntPtr NativeFieldInfoPtr_batchIDs;

	private static readonly System.IntPtr NativeFieldInfoPtr_instanceDataBuffer;

	private static readonly System.IntPtr NativeFieldInfoPtr_drawBatches;

	private static readonly System.IntPtr NativeFieldInfoPtr_drawInstanceIndices;

	private static readonly System.IntPtr NativeFieldInfoPtr_instanceData;

	private static readonly System.IntPtr NativeFieldInfoPtr_rendererVisibilityMasks;

	private static readonly System.IntPtr NativeFieldInfoPtr_rendererCrossFadeValues;

	private static readonly System.IntPtr NativeFieldInfoPtr_batchBinAllocOffsets;

	private static readonly System.IntPtr NativeFieldInfoPtr_batchBinCounts;

	private static readonly System.IntPtr NativeFieldInfoPtr_batchDrawCommandOffsets;

	private static readonly System.IntPtr NativeFieldInfoPtr_binConfigIndices;

	private static readonly System.IntPtr NativeFieldInfoPtr_binVisibleInstanceOffsets;

	private static readonly System.IntPtr NativeFieldInfoPtr_binVisibleInstanceCounts;

	private static readonly System.IntPtr NativeFieldInfoPtr_cullingOutput;

	private static readonly System.IntPtr NativeFieldInfoPtr_indirectBufferLimits;

	private static readonly System.IntPtr NativeFieldInfoPtr_visibleInstancesBufferHandle;

	private static readonly System.IntPtr NativeFieldInfoPtr_indirectArgsBufferHandle;

	private static readonly System.IntPtr NativeFieldInfoPtr_indirectBufferAllocInfo;

	private static readonly System.IntPtr NativeFieldInfoPtr_indirectDrawInfoGlobalArray;

	private static readonly System.IntPtr NativeFieldInfoPtr_indirectInstanceInfoGlobalArray;

	private static readonly System.IntPtr NativeMethodInfoPtr_EncodeGPUInstanceIndexAndCrossFade_Private_Int32_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsInstanceFlipped_Private_Boolean_Int32_0;

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

	public unsafe NativeParallelHashMap<uint, BatchID> batchIDs
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_batchIDs);
			return new NativeParallelHashMap<uint, BatchID>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeParallelHashMap<uint, BatchID>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_batchIDs), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeParallelHashMap<uint, BatchID>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe GPUInstanceDataBuffer.ReadOnly instanceDataBuffer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_instanceDataBuffer);
			return new GPUInstanceDataBuffer.ReadOnly(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GPUInstanceDataBuffer.ReadOnly>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_instanceDataBuffer), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GPUInstanceDataBuffer.ReadOnly>.NativeClassPtr, ref *(uint*)null));
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

	public unsafe NativeArray<byte> rendererCrossFadeValues
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rendererCrossFadeValues);
			return new NativeArray<byte>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<byte>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rendererCrossFadeValues), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<byte>>.NativeClassPtr, ref *(uint*)null));
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

	public unsafe GraphicsBufferHandle visibleInstancesBufferHandle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_visibleInstancesBufferHandle);
			return *(GraphicsBufferHandle*)num;
		}
		set
		{
			*(GraphicsBufferHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_visibleInstancesBufferHandle)) = value;
		}
	}

	public unsafe GraphicsBufferHandle indirectArgsBufferHandle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_indirectArgsBufferHandle);
			return *(GraphicsBufferHandle*)num;
		}
		set
		{
			*(GraphicsBufferHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_indirectArgsBufferHandle)) = value;
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

	public unsafe NativeArray<IndirectDrawInfo> indirectDrawInfoGlobalArray
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_indirectDrawInfoGlobalArray);
			return new NativeArray<IndirectDrawInfo>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<IndirectDrawInfo>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_indirectDrawInfoGlobalArray), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<IndirectDrawInfo>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeArray<IndirectInstanceInfo> indirectInstanceInfoGlobalArray
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_indirectInstanceInfoGlobalArray);
			return new NativeArray<IndirectInstanceInfo>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<IndirectInstanceInfo>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_indirectInstanceInfoGlobalArray), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<IndirectInstanceInfo>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	static DrawCommandOutputPerBatch()
	{
		Il2CppClassPointerStore<DrawCommandOutputPerBatch>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.GPUDriven.Runtime.dll", "UnityEngine.Rendering", "DrawCommandOutputPerBatch");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DrawCommandOutputPerBatch>.NativeClassPtr);
		NativeFieldInfoPtr_binningConfig = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawCommandOutputPerBatch>.NativeClassPtr, "binningConfig");
		NativeFieldInfoPtr_batchIDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawCommandOutputPerBatch>.NativeClassPtr, "batchIDs");
		NativeFieldInfoPtr_instanceDataBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawCommandOutputPerBatch>.NativeClassPtr, "instanceDataBuffer");
		NativeFieldInfoPtr_drawBatches = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawCommandOutputPerBatch>.NativeClassPtr, "drawBatches");
		NativeFieldInfoPtr_drawInstanceIndices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawCommandOutputPerBatch>.NativeClassPtr, "drawInstanceIndices");
		NativeFieldInfoPtr_instanceData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawCommandOutputPerBatch>.NativeClassPtr, "instanceData");
		NativeFieldInfoPtr_rendererVisibilityMasks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawCommandOutputPerBatch>.NativeClassPtr, "rendererVisibilityMasks");
		NativeFieldInfoPtr_rendererCrossFadeValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawCommandOutputPerBatch>.NativeClassPtr, "rendererCrossFadeValues");
		NativeFieldInfoPtr_batchBinAllocOffsets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawCommandOutputPerBatch>.NativeClassPtr, "batchBinAllocOffsets");
		NativeFieldInfoPtr_batchBinCounts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawCommandOutputPerBatch>.NativeClassPtr, "batchBinCounts");
		NativeFieldInfoPtr_batchDrawCommandOffsets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawCommandOutputPerBatch>.NativeClassPtr, "batchDrawCommandOffsets");
		NativeFieldInfoPtr_binConfigIndices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawCommandOutputPerBatch>.NativeClassPtr, "binConfigIndices");
		NativeFieldInfoPtr_binVisibleInstanceOffsets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawCommandOutputPerBatch>.NativeClassPtr, "binVisibleInstanceOffsets");
		NativeFieldInfoPtr_binVisibleInstanceCounts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawCommandOutputPerBatch>.NativeClassPtr, "binVisibleInstanceCounts");
		NativeFieldInfoPtr_cullingOutput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawCommandOutputPerBatch>.NativeClassPtr, "cullingOutput");
		NativeFieldInfoPtr_indirectBufferLimits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawCommandOutputPerBatch>.NativeClassPtr, "indirectBufferLimits");
		NativeFieldInfoPtr_visibleInstancesBufferHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawCommandOutputPerBatch>.NativeClassPtr, "visibleInstancesBufferHandle");
		NativeFieldInfoPtr_indirectArgsBufferHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawCommandOutputPerBatch>.NativeClassPtr, "indirectArgsBufferHandle");
		NativeFieldInfoPtr_indirectBufferAllocInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawCommandOutputPerBatch>.NativeClassPtr, "indirectBufferAllocInfo");
		NativeFieldInfoPtr_indirectDrawInfoGlobalArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawCommandOutputPerBatch>.NativeClassPtr, "indirectDrawInfoGlobalArray");
		NativeFieldInfoPtr_indirectInstanceInfoGlobalArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawCommandOutputPerBatch>.NativeClassPtr, "indirectInstanceInfoGlobalArray");
		NativeMethodInfoPtr_EncodeGPUInstanceIndexAndCrossFade_Private_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawCommandOutputPerBatch>.NativeClassPtr, 100663554);
		NativeMethodInfoPtr_IsInstanceFlipped_Private_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawCommandOutputPerBatch>.NativeClassPtr, 100663555);
		NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawCommandOutputPerBatch>.NativeClassPtr, 100663556);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1069429, RefRangeEnd = 1069433, XrefRangeStart = 1069421, XrefRangeEnd = 1069429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int EncodeGPUInstanceIndexAndCrossFade(int rendererIndex, bool negateCrossFade)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&rendererIndex);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &negateCrossFade;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EncodeGPUInstanceIndexAndCrossFade_Private_Int32_Int32_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1069439, RefRangeEnd = 1069441, XrefRangeStart = 1069433, XrefRangeEnd = 1069439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1069441, XrefRangeEnd = 1069478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Execute(int batchIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&batchIndex);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public DrawCommandOutputPerBatch(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public DrawCommandOutputPerBatch()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DrawCommandOutputPerBatch>.NativeClassPtr))
	{
	}
}
