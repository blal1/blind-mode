using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;
using Unity.Mathematics;

namespace UnityEngine.Rendering;

public class InstanceDataSystem : Il2CppSystem.Object
{
	public static class InstanceTransformUpdateIDs : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr__TransformUpdateQueueCount;

		private static readonly System.IntPtr NativeFieldInfoPtr__TransformUpdateOutputL2WVec4Offset;

		private static readonly System.IntPtr NativeFieldInfoPtr__TransformUpdateOutputW2LVec4Offset;

		private static readonly System.IntPtr NativeFieldInfoPtr__TransformUpdateOutputPrevL2WVec4Offset;

		private static readonly System.IntPtr NativeFieldInfoPtr__TransformUpdateOutputPrevW2LVec4Offset;

		private static readonly System.IntPtr NativeFieldInfoPtr__BoundingSphereOutputVec4Offset;

		private static readonly System.IntPtr NativeFieldInfoPtr__TransformUpdateDataQueue;

		private static readonly System.IntPtr NativeFieldInfoPtr__TransformUpdateIndexQueue;

		private static readonly System.IntPtr NativeFieldInfoPtr__BoundingSphereDataQueue;

		private static readonly System.IntPtr NativeFieldInfoPtr__OutputTransformBuffer;

		private static readonly System.IntPtr NativeFieldInfoPtr__ProbeUpdateQueueCount;

		private static readonly System.IntPtr NativeFieldInfoPtr__SHUpdateVec4Offset;

		private static readonly System.IntPtr NativeFieldInfoPtr__ProbeUpdateDataQueue;

		private static readonly System.IntPtr NativeFieldInfoPtr__ProbeOcclusionUpdateDataQueue;

		private static readonly System.IntPtr NativeFieldInfoPtr__ProbeUpdateIndexQueue;

		private static readonly System.IntPtr NativeFieldInfoPtr__OutputProbeBuffer;

		public unsafe static int _TransformUpdateQueueCount
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__TransformUpdateQueueCount, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__TransformUpdateQueueCount, (void*)(&value));
			}
		}

		public unsafe static int _TransformUpdateOutputL2WVec4Offset
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__TransformUpdateOutputL2WVec4Offset, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__TransformUpdateOutputL2WVec4Offset, (void*)(&value));
			}
		}

		public unsafe static int _TransformUpdateOutputW2LVec4Offset
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__TransformUpdateOutputW2LVec4Offset, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__TransformUpdateOutputW2LVec4Offset, (void*)(&value));
			}
		}

		public unsafe static int _TransformUpdateOutputPrevL2WVec4Offset
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__TransformUpdateOutputPrevL2WVec4Offset, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__TransformUpdateOutputPrevL2WVec4Offset, (void*)(&value));
			}
		}

		public unsafe static int _TransformUpdateOutputPrevW2LVec4Offset
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__TransformUpdateOutputPrevW2LVec4Offset, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__TransformUpdateOutputPrevW2LVec4Offset, (void*)(&value));
			}
		}

		public unsafe static int _BoundingSphereOutputVec4Offset
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__BoundingSphereOutputVec4Offset, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__BoundingSphereOutputVec4Offset, (void*)(&value));
			}
		}

		public unsafe static int _TransformUpdateDataQueue
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__TransformUpdateDataQueue, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__TransformUpdateDataQueue, (void*)(&value));
			}
		}

		public unsafe static int _TransformUpdateIndexQueue
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__TransformUpdateIndexQueue, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__TransformUpdateIndexQueue, (void*)(&value));
			}
		}

		public unsafe static int _BoundingSphereDataQueue
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__BoundingSphereDataQueue, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__BoundingSphereDataQueue, (void*)(&value));
			}
		}

		public unsafe static int _OutputTransformBuffer
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__OutputTransformBuffer, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__OutputTransformBuffer, (void*)(&value));
			}
		}

		public unsafe static int _ProbeUpdateQueueCount
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__ProbeUpdateQueueCount, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__ProbeUpdateQueueCount, (void*)(&value));
			}
		}

		public unsafe static int _SHUpdateVec4Offset
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__SHUpdateVec4Offset, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__SHUpdateVec4Offset, (void*)(&value));
			}
		}

		public unsafe static int _ProbeUpdateDataQueue
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__ProbeUpdateDataQueue, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__ProbeUpdateDataQueue, (void*)(&value));
			}
		}

		public unsafe static int _ProbeOcclusionUpdateDataQueue
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__ProbeOcclusionUpdateDataQueue, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__ProbeOcclusionUpdateDataQueue, (void*)(&value));
			}
		}

		public unsafe static int _ProbeUpdateIndexQueue
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__ProbeUpdateIndexQueue, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__ProbeUpdateIndexQueue, (void*)(&value));
			}
		}

		public unsafe static int _OutputProbeBuffer
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__OutputProbeBuffer, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__OutputProbeBuffer, (void*)(&value));
			}
		}

		static InstanceTransformUpdateIDs()
		{
			Il2CppClassPointerStore<InstanceTransformUpdateIDs>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InstanceDataSystem>.NativeClassPtr, "InstanceTransformUpdateIDs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InstanceTransformUpdateIDs>.NativeClassPtr);
			NativeFieldInfoPtr__TransformUpdateQueueCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstanceTransformUpdateIDs>.NativeClassPtr, "_TransformUpdateQueueCount");
			NativeFieldInfoPtr__TransformUpdateOutputL2WVec4Offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstanceTransformUpdateIDs>.NativeClassPtr, "_TransformUpdateOutputL2WVec4Offset");
			NativeFieldInfoPtr__TransformUpdateOutputW2LVec4Offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstanceTransformUpdateIDs>.NativeClassPtr, "_TransformUpdateOutputW2LVec4Offset");
			NativeFieldInfoPtr__TransformUpdateOutputPrevL2WVec4Offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstanceTransformUpdateIDs>.NativeClassPtr, "_TransformUpdateOutputPrevL2WVec4Offset");
			NativeFieldInfoPtr__TransformUpdateOutputPrevW2LVec4Offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstanceTransformUpdateIDs>.NativeClassPtr, "_TransformUpdateOutputPrevW2LVec4Offset");
			NativeFieldInfoPtr__BoundingSphereOutputVec4Offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstanceTransformUpdateIDs>.NativeClassPtr, "_BoundingSphereOutputVec4Offset");
			NativeFieldInfoPtr__TransformUpdateDataQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstanceTransformUpdateIDs>.NativeClassPtr, "_TransformUpdateDataQueue");
			NativeFieldInfoPtr__TransformUpdateIndexQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstanceTransformUpdateIDs>.NativeClassPtr, "_TransformUpdateIndexQueue");
			NativeFieldInfoPtr__BoundingSphereDataQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstanceTransformUpdateIDs>.NativeClassPtr, "_BoundingSphereDataQueue");
			NativeFieldInfoPtr__OutputTransformBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstanceTransformUpdateIDs>.NativeClassPtr, "_OutputTransformBuffer");
			NativeFieldInfoPtr__ProbeUpdateQueueCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstanceTransformUpdateIDs>.NativeClassPtr, "_ProbeUpdateQueueCount");
			NativeFieldInfoPtr__SHUpdateVec4Offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstanceTransformUpdateIDs>.NativeClassPtr, "_SHUpdateVec4Offset");
			NativeFieldInfoPtr__ProbeUpdateDataQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstanceTransformUpdateIDs>.NativeClassPtr, "_ProbeUpdateDataQueue");
			NativeFieldInfoPtr__ProbeOcclusionUpdateDataQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstanceTransformUpdateIDs>.NativeClassPtr, "_ProbeOcclusionUpdateDataQueue");
			NativeFieldInfoPtr__ProbeUpdateIndexQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstanceTransformUpdateIDs>.NativeClassPtr, "_ProbeUpdateIndexQueue");
			NativeFieldInfoPtr__OutputProbeBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstanceTransformUpdateIDs>.NativeClassPtr, "_OutputProbeBuffer");
		}

		public InstanceTransformUpdateIDs(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public static class InstanceWindDataUpdateIDs : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr__WindDataQueueCount;

		private static readonly System.IntPtr NativeFieldInfoPtr__WindDataUpdateIndexQueue;

		private static readonly System.IntPtr NativeFieldInfoPtr__WindDataBuffer;

		private static readonly System.IntPtr NativeFieldInfoPtr__WindParamAddressArray;

		private static readonly System.IntPtr NativeFieldInfoPtr__WindHistoryParamAddressArray;

		public unsafe static int _WindDataQueueCount
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__WindDataQueueCount, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__WindDataQueueCount, (void*)(&value));
			}
		}

		public unsafe static int _WindDataUpdateIndexQueue
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__WindDataUpdateIndexQueue, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__WindDataUpdateIndexQueue, (void*)(&value));
			}
		}

		public unsafe static int _WindDataBuffer
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__WindDataBuffer, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__WindDataBuffer, (void*)(&value));
			}
		}

		public unsafe static int _WindParamAddressArray
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__WindParamAddressArray, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__WindParamAddressArray, (void*)(&value));
			}
		}

		public unsafe static int _WindHistoryParamAddressArray
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__WindHistoryParamAddressArray, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__WindHistoryParamAddressArray, (void*)(&value));
			}
		}

		static InstanceWindDataUpdateIDs()
		{
			Il2CppClassPointerStore<InstanceWindDataUpdateIDs>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InstanceDataSystem>.NativeClassPtr, "InstanceWindDataUpdateIDs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InstanceWindDataUpdateIDs>.NativeClassPtr);
			NativeFieldInfoPtr__WindDataQueueCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstanceWindDataUpdateIDs>.NativeClassPtr, "_WindDataQueueCount");
			NativeFieldInfoPtr__WindDataUpdateIndexQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstanceWindDataUpdateIDs>.NativeClassPtr, "_WindDataUpdateIndexQueue");
			NativeFieldInfoPtr__WindDataBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstanceWindDataUpdateIDs>.NativeClassPtr, "_WindDataBuffer");
			NativeFieldInfoPtr__WindParamAddressArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstanceWindDataUpdateIDs>.NativeClassPtr, "_WindParamAddressArray");
			NativeFieldInfoPtr__WindHistoryParamAddressArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstanceWindDataUpdateIDs>.NativeClassPtr, "_WindHistoryParamAddressArray");
		}

		public InstanceWindDataUpdateIDs(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public sealed class QueryRendererGroupInstancesCountJob : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_instanceData;

		private static readonly System.IntPtr NativeFieldInfoPtr_sharedInstanceData;

		private static readonly System.IntPtr NativeFieldInfoPtr_rendererGroupInstanceMultiHash;

		private static readonly System.IntPtr NativeFieldInfoPtr_rendererGroupIDs;

		private static readonly System.IntPtr NativeFieldInfoPtr_instancesCount;

		private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_Int32_0;

		public unsafe CPUInstanceData instanceData
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_instanceData);
				return new CPUInstanceData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CPUInstanceData>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_instanceData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CPUInstanceData>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe CPUSharedInstanceData sharedInstanceData
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sharedInstanceData);
				return new CPUSharedInstanceData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CPUSharedInstanceData>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sharedInstanceData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CPUSharedInstanceData>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe NativeParallelMultiHashMap<int, InstanceHandle> rendererGroupInstanceMultiHash
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rendererGroupInstanceMultiHash);
				return new NativeParallelMultiHashMap<int, InstanceHandle>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeParallelMultiHashMap<int, InstanceHandle>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rendererGroupInstanceMultiHash), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeParallelMultiHashMap<int, InstanceHandle>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe NativeArray<int> rendererGroupIDs
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rendererGroupIDs);
				return new NativeArray<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rendererGroupIDs), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe NativeArray<int> instancesCount
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_instancesCount);
				return new NativeArray<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_instancesCount), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		static QueryRendererGroupInstancesCountJob()
		{
			Il2CppClassPointerStore<QueryRendererGroupInstancesCountJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InstanceDataSystem>.NativeClassPtr, "QueryRendererGroupInstancesCountJob");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QueryRendererGroupInstancesCountJob>.NativeClassPtr);
			NativeFieldInfoPtr_instanceData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryRendererGroupInstancesCountJob>.NativeClassPtr, "instanceData");
			NativeFieldInfoPtr_sharedInstanceData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryRendererGroupInstancesCountJob>.NativeClassPtr, "sharedInstanceData");
			NativeFieldInfoPtr_rendererGroupInstanceMultiHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryRendererGroupInstancesCountJob>.NativeClassPtr, "rendererGroupInstanceMultiHash");
			NativeFieldInfoPtr_rendererGroupIDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryRendererGroupInstancesCountJob>.NativeClassPtr, "rendererGroupIDs");
			NativeFieldInfoPtr_instancesCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryRendererGroupInstancesCountJob>.NativeClassPtr, "instancesCount");
			NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryRendererGroupInstancesCountJob>.NativeClassPtr, 100663850);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1072551, XrefRangeEnd = 1072557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		public QueryRendererGroupInstancesCountJob(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public QueryRendererGroupInstancesCountJob()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<QueryRendererGroupInstancesCountJob>.NativeClassPtr))
		{
		}
	}

	public sealed class ComputeInstancesOffsetAndResizeInstancesArrayJob : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_instancesCount;

		private static readonly System.IntPtr NativeFieldInfoPtr_instancesOffset;

		private static readonly System.IntPtr NativeFieldInfoPtr_instances;

		private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0;

		public unsafe NativeArray<int> instancesCount
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_instancesCount);
				return new NativeArray<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_instancesCount), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe NativeArray<int> instancesOffset
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_instancesOffset);
				return new NativeArray<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_instancesOffset), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe NativeList<InstanceHandle> instances
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_instances);
				return new NativeList<InstanceHandle>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeList<InstanceHandle>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_instances), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<InstanceHandle>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		static ComputeInstancesOffsetAndResizeInstancesArrayJob()
		{
			Il2CppClassPointerStore<ComputeInstancesOffsetAndResizeInstancesArrayJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InstanceDataSystem>.NativeClassPtr, "ComputeInstancesOffsetAndResizeInstancesArrayJob");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ComputeInstancesOffsetAndResizeInstancesArrayJob>.NativeClassPtr);
			NativeFieldInfoPtr_instancesCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComputeInstancesOffsetAndResizeInstancesArrayJob>.NativeClassPtr, "instancesCount");
			NativeFieldInfoPtr_instancesOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComputeInstancesOffsetAndResizeInstancesArrayJob>.NativeClassPtr, "instancesOffset");
			NativeFieldInfoPtr_instances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComputeInstancesOffsetAndResizeInstancesArrayJob>.NativeClassPtr, "instances");
			NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeInstancesOffsetAndResizeInstancesArrayJob>.NativeClassPtr, 100663851);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1072557, XrefRangeEnd = 1072560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public ComputeInstancesOffsetAndResizeInstancesArrayJob(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public ComputeInstancesOffsetAndResizeInstancesArrayJob()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ComputeInstancesOffsetAndResizeInstancesArrayJob>.NativeClassPtr))
		{
		}
	}

	public sealed class QueryRendererGroupInstancesJob : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_rendererGroupInstanceMultiHash;

		private static readonly System.IntPtr NativeFieldInfoPtr_rendererGroupIDs;

		private static readonly System.IntPtr NativeFieldInfoPtr_instances;

		private static readonly System.IntPtr NativeFieldInfoPtr_atomicNonFoundInstancesCount;

		private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_Int32_0;

		public unsafe NativeParallelMultiHashMap<int, InstanceHandle> rendererGroupInstanceMultiHash
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rendererGroupInstanceMultiHash);
				return new NativeParallelMultiHashMap<int, InstanceHandle>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeParallelMultiHashMap<int, InstanceHandle>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rendererGroupInstanceMultiHash), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeParallelMultiHashMap<int, InstanceHandle>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe NativeArray<int> rendererGroupIDs
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rendererGroupIDs);
				return new NativeArray<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rendererGroupIDs), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe NativeArray<InstanceHandle> instances
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_instances);
				return new NativeArray<InstanceHandle>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<InstanceHandle>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_instances), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<InstanceHandle>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe UnsafeAtomicCounter32 atomicNonFoundInstancesCount
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_atomicNonFoundInstancesCount);
				return *(UnsafeAtomicCounter32*)num;
			}
			set
			{
				*(UnsafeAtomicCounter32*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_atomicNonFoundInstancesCount)) = value;
			}
		}

		static QueryRendererGroupInstancesJob()
		{
			Il2CppClassPointerStore<QueryRendererGroupInstancesJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InstanceDataSystem>.NativeClassPtr, "QueryRendererGroupInstancesJob");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QueryRendererGroupInstancesJob>.NativeClassPtr);
			NativeFieldInfoPtr_rendererGroupInstanceMultiHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryRendererGroupInstancesJob>.NativeClassPtr, "rendererGroupInstanceMultiHash");
			NativeFieldInfoPtr_rendererGroupIDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryRendererGroupInstancesJob>.NativeClassPtr, "rendererGroupIDs");
			NativeFieldInfoPtr_instances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryRendererGroupInstancesJob>.NativeClassPtr, "instances");
			NativeFieldInfoPtr_atomicNonFoundInstancesCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryRendererGroupInstancesJob>.NativeClassPtr, "atomicNonFoundInstancesCount");
			NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryRendererGroupInstancesJob>.NativeClassPtr, 100663852);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1072560, XrefRangeEnd = 1072569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		public QueryRendererGroupInstancesJob(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public QueryRendererGroupInstancesJob()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<QueryRendererGroupInstancesJob>.NativeClassPtr))
		{
		}
	}

	public sealed class QueryRendererGroupInstancesMultiJob : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_rendererGroupInstanceMultiHash;

		private static readonly System.IntPtr NativeFieldInfoPtr_rendererGroupIDs;

		private static readonly System.IntPtr NativeFieldInfoPtr_instancesOffsets;

		private static readonly System.IntPtr NativeFieldInfoPtr_instancesCounts;

		private static readonly System.IntPtr NativeFieldInfoPtr_instances;

		private static readonly System.IntPtr NativeFieldInfoPtr_atomicNonFoundSharedInstancesCount;

		private static readonly System.IntPtr NativeFieldInfoPtr_atomicNonFoundInstancesCount;

		private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_Int32_0;

		public unsafe NativeParallelMultiHashMap<int, InstanceHandle> rendererGroupInstanceMultiHash
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rendererGroupInstanceMultiHash);
				return new NativeParallelMultiHashMap<int, InstanceHandle>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeParallelMultiHashMap<int, InstanceHandle>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rendererGroupInstanceMultiHash), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeParallelMultiHashMap<int, InstanceHandle>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe NativeArray<int> rendererGroupIDs
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rendererGroupIDs);
				return new NativeArray<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rendererGroupIDs), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe NativeArray<int> instancesOffsets
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_instancesOffsets);
				return new NativeArray<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_instancesOffsets), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe NativeArray<int> instancesCounts
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_instancesCounts);
				return new NativeArray<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_instancesCounts), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe NativeArray<InstanceHandle> instances
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_instances);
				return new NativeArray<InstanceHandle>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<InstanceHandle>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_instances), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<InstanceHandle>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe UnsafeAtomicCounter32 atomicNonFoundSharedInstancesCount
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_atomicNonFoundSharedInstancesCount);
				return *(UnsafeAtomicCounter32*)num;
			}
			set
			{
				*(UnsafeAtomicCounter32*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_atomicNonFoundSharedInstancesCount)) = value;
			}
		}

		public unsafe UnsafeAtomicCounter32 atomicNonFoundInstancesCount
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_atomicNonFoundInstancesCount);
				return *(UnsafeAtomicCounter32*)num;
			}
			set
			{
				*(UnsafeAtomicCounter32*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_atomicNonFoundInstancesCount)) = value;
			}
		}

		static QueryRendererGroupInstancesMultiJob()
		{
			Il2CppClassPointerStore<QueryRendererGroupInstancesMultiJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InstanceDataSystem>.NativeClassPtr, "QueryRendererGroupInstancesMultiJob");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QueryRendererGroupInstancesMultiJob>.NativeClassPtr);
			NativeFieldInfoPtr_rendererGroupInstanceMultiHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryRendererGroupInstancesMultiJob>.NativeClassPtr, "rendererGroupInstanceMultiHash");
			NativeFieldInfoPtr_rendererGroupIDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryRendererGroupInstancesMultiJob>.NativeClassPtr, "rendererGroupIDs");
			NativeFieldInfoPtr_instancesOffsets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryRendererGroupInstancesMultiJob>.NativeClassPtr, "instancesOffsets");
			NativeFieldInfoPtr_instancesCounts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryRendererGroupInstancesMultiJob>.NativeClassPtr, "instancesCounts");
			NativeFieldInfoPtr_instances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryRendererGroupInstancesMultiJob>.NativeClassPtr, "instances");
			NativeFieldInfoPtr_atomicNonFoundSharedInstancesCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryRendererGroupInstancesMultiJob>.NativeClassPtr, "atomicNonFoundSharedInstancesCount");
			NativeFieldInfoPtr_atomicNonFoundInstancesCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QueryRendererGroupInstancesMultiJob>.NativeClassPtr, "atomicNonFoundInstancesCount");
			NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryRendererGroupInstancesMultiJob>.NativeClassPtr, 100663853);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1072569, XrefRangeEnd = 1072582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		public QueryRendererGroupInstancesMultiJob(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public QueryRendererGroupInstancesMultiJob()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<QueryRendererGroupInstancesMultiJob>.NativeClassPtr))
		{
		}
	}

	public sealed class QuerySortedMeshInstancesJob : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_instanceData;

		private static readonly System.IntPtr NativeFieldInfoPtr_sharedInstanceData;

		private static readonly System.IntPtr NativeFieldInfoPtr_sortedMeshID;

		private static readonly System.IntPtr NativeFieldInfoPtr_instances;

		private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_Int32_0;

		public unsafe CPUInstanceData instanceData
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_instanceData);
				return new CPUInstanceData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CPUInstanceData>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_instanceData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CPUInstanceData>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe CPUSharedInstanceData sharedInstanceData
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sharedInstanceData);
				return new CPUSharedInstanceData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CPUSharedInstanceData>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sharedInstanceData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CPUSharedInstanceData>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe NativeArray<int> sortedMeshID
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sortedMeshID);
				return new NativeArray<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sortedMeshID), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe NativeList<InstanceHandle> instances
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_instances);
				return new NativeList<InstanceHandle>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeList<InstanceHandle>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_instances), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<InstanceHandle>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		static QuerySortedMeshInstancesJob()
		{
			Il2CppClassPointerStore<QuerySortedMeshInstancesJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InstanceDataSystem>.NativeClassPtr, "QuerySortedMeshInstancesJob");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QuerySortedMeshInstancesJob>.NativeClassPtr);
			NativeFieldInfoPtr_instanceData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuerySortedMeshInstancesJob>.NativeClassPtr, "instanceData");
			NativeFieldInfoPtr_sharedInstanceData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuerySortedMeshInstancesJob>.NativeClassPtr, "sharedInstanceData");
			NativeFieldInfoPtr_sortedMeshID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuerySortedMeshInstancesJob>.NativeClassPtr, "sortedMeshID");
			NativeFieldInfoPtr_instances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuerySortedMeshInstancesJob>.NativeClassPtr, "instances");
			NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuerySortedMeshInstancesJob>.NativeClassPtr, 100663854);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1072582, XrefRangeEnd = 1072593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		public QuerySortedMeshInstancesJob(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public QuerySortedMeshInstancesJob()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<QuerySortedMeshInstancesJob>.NativeClassPtr))
		{
		}
	}

	public sealed class CalculateInterpolatedLightAndOcclusionProbesBatchJob : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_probesCount;

		private static readonly System.IntPtr NativeFieldInfoPtr_lightProbesQuery;

		private static readonly System.IntPtr NativeFieldInfoPtr_queryPostitions;

		private static readonly System.IntPtr NativeFieldInfoPtr_compactTetrahedronCache;

		private static readonly System.IntPtr NativeFieldInfoPtr_probesSphericalHarmonics;

		private static readonly System.IntPtr NativeFieldInfoPtr_probesOcclusion;

		private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_0;

		public unsafe int probesCount
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_probesCount);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_probesCount)) = value;
			}
		}

		public unsafe LightProbesQuery lightProbesQuery
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lightProbesQuery);
				return *(LightProbesQuery*)num;
			}
			set
			{
				*(LightProbesQuery*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lightProbesQuery)) = value;
			}
		}

		public unsafe NativeArray<Vector3> queryPostitions
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_queryPostitions);
				return new NativeArray<Vector3>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<Vector3>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_queryPostitions), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<Vector3>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe NativeArray<int> compactTetrahedronCache
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_compactTetrahedronCache);
				return new NativeArray<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_compactTetrahedronCache), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe NativeArray<SphericalHarmonicsL2> probesSphericalHarmonics
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_probesSphericalHarmonics);
				return new NativeArray<SphericalHarmonicsL2>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<SphericalHarmonicsL2>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_probesSphericalHarmonics), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<SphericalHarmonicsL2>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe NativeArray<Vector4> probesOcclusion
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_probesOcclusion);
				return new NativeArray<Vector4>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<Vector4>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_probesOcclusion), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<Vector4>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		static CalculateInterpolatedLightAndOcclusionProbesBatchJob()
		{
			Il2CppClassPointerStore<CalculateInterpolatedLightAndOcclusionProbesBatchJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InstanceDataSystem>.NativeClassPtr, "CalculateInterpolatedLightAndOcclusionProbesBatchJob");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CalculateInterpolatedLightAndOcclusionProbesBatchJob>.NativeClassPtr);
			NativeFieldInfoPtr_probesCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalculateInterpolatedLightAndOcclusionProbesBatchJob>.NativeClassPtr, "probesCount");
			NativeFieldInfoPtr_lightProbesQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalculateInterpolatedLightAndOcclusionProbesBatchJob>.NativeClassPtr, "lightProbesQuery");
			NativeFieldInfoPtr_queryPostitions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalculateInterpolatedLightAndOcclusionProbesBatchJob>.NativeClassPtr, "queryPostitions");
			NativeFieldInfoPtr_compactTetrahedronCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalculateInterpolatedLightAndOcclusionProbesBatchJob>.NativeClassPtr, "compactTetrahedronCache");
			NativeFieldInfoPtr_probesSphericalHarmonics = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalculateInterpolatedLightAndOcclusionProbesBatchJob>.NativeClassPtr, "probesSphericalHarmonics");
			NativeFieldInfoPtr_probesOcclusion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CalculateInterpolatedLightAndOcclusionProbesBatchJob>.NativeClassPtr, "probesOcclusion");
			NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CalculateInterpolatedLightAndOcclusionProbesBatchJob>.NativeClassPtr, 100663855);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1072593, XrefRangeEnd = 1072606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Execute(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&index);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public CalculateInterpolatedLightAndOcclusionProbesBatchJob(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public CalculateInterpolatedLightAndOcclusionProbesBatchJob()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CalculateInterpolatedLightAndOcclusionProbesBatchJob>.NativeClassPtr))
		{
		}
	}

	public sealed class ScatterTetrahedronCacheIndicesJob : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_probeInstances;

		private static readonly System.IntPtr NativeFieldInfoPtr_compactTetrahedronCache;

		private static readonly System.IntPtr NativeFieldInfoPtr_instanceData;

		private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_0;

		public unsafe NativeArray<InstanceHandle> probeInstances
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_probeInstances);
				return new NativeArray<InstanceHandle>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<InstanceHandle>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_probeInstances), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<InstanceHandle>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe NativeArray<int> compactTetrahedronCache
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_compactTetrahedronCache);
				return new NativeArray<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_compactTetrahedronCache), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe CPUInstanceData instanceData
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_instanceData);
				return new CPUInstanceData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CPUInstanceData>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_instanceData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CPUInstanceData>.NativeClassPtr, ref *(uint*)null));
			}
		}

		static ScatterTetrahedronCacheIndicesJob()
		{
			Il2CppClassPointerStore<ScatterTetrahedronCacheIndicesJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InstanceDataSystem>.NativeClassPtr, "ScatterTetrahedronCacheIndicesJob");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScatterTetrahedronCacheIndicesJob>.NativeClassPtr);
			NativeFieldInfoPtr_probeInstances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScatterTetrahedronCacheIndicesJob>.NativeClassPtr, "probeInstances");
			NativeFieldInfoPtr_compactTetrahedronCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScatterTetrahedronCacheIndicesJob>.NativeClassPtr, "compactTetrahedronCache");
			NativeFieldInfoPtr_instanceData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScatterTetrahedronCacheIndicesJob>.NativeClassPtr, "instanceData");
			NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScatterTetrahedronCacheIndicesJob>.NativeClassPtr, 100663856);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1072606, XrefRangeEnd = 1072607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Execute(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&index);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public ScatterTetrahedronCacheIndicesJob(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public ScatterTetrahedronCacheIndicesJob()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScatterTetrahedronCacheIndicesJob>.NativeClassPtr))
		{
		}
	}

	public sealed class TransformUpdateJob : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_initialize;

		private static readonly System.IntPtr NativeFieldInfoPtr_enableBoundingSpheres;

		private static readonly System.IntPtr NativeFieldInfoPtr_instances;

		private static readonly System.IntPtr NativeFieldInfoPtr_localToWorldMatrices;

		private static readonly System.IntPtr NativeFieldInfoPtr_prevLocalToWorldMatrices;

		private static readonly System.IntPtr NativeFieldInfoPtr_atomicTransformQueueCount;

		private static readonly System.IntPtr NativeFieldInfoPtr_sharedInstanceData;

		private static readonly System.IntPtr NativeFieldInfoPtr_instanceData;

		private static readonly System.IntPtr NativeFieldInfoPtr_transformUpdateInstanceQueue;

		private static readonly System.IntPtr NativeFieldInfoPtr_transformUpdateDataQueue;

		private static readonly System.IntPtr NativeFieldInfoPtr_boundingSpheresDataQueue;

		private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_Int32_0;

		public unsafe bool initialize
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_initialize);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_initialize)) = value;
			}
		}

		public unsafe bool enableBoundingSpheres
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableBoundingSpheres);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_enableBoundingSpheres)) = value;
			}
		}

		public unsafe NativeArray<InstanceHandle> instances
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_instances);
				return new NativeArray<InstanceHandle>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<InstanceHandle>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_instances), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<InstanceHandle>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe NativeArray<Matrix4x4> localToWorldMatrices
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_localToWorldMatrices);
				return new NativeArray<Matrix4x4>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<Matrix4x4>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_localToWorldMatrices), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<Matrix4x4>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe NativeArray<Matrix4x4> prevLocalToWorldMatrices
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_prevLocalToWorldMatrices);
				return new NativeArray<Matrix4x4>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<Matrix4x4>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_prevLocalToWorldMatrices), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<Matrix4x4>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe UnsafeAtomicCounter32 atomicTransformQueueCount
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_atomicTransformQueueCount);
				return *(UnsafeAtomicCounter32*)num;
			}
			set
			{
				*(UnsafeAtomicCounter32*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_atomicTransformQueueCount)) = value;
			}
		}

		public unsafe CPUSharedInstanceData sharedInstanceData
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sharedInstanceData);
				return new CPUSharedInstanceData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CPUSharedInstanceData>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sharedInstanceData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CPUSharedInstanceData>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe CPUInstanceData instanceData
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_instanceData);
				return new CPUInstanceData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CPUInstanceData>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_instanceData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CPUInstanceData>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe NativeArray<InstanceHandle> transformUpdateInstanceQueue
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_transformUpdateInstanceQueue);
				return new NativeArray<InstanceHandle>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<InstanceHandle>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_transformUpdateInstanceQueue), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<InstanceHandle>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe NativeArray<TransformUpdatePacket> transformUpdateDataQueue
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_transformUpdateDataQueue);
				return new NativeArray<TransformUpdatePacket>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<TransformUpdatePacket>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_transformUpdateDataQueue), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<TransformUpdatePacket>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe NativeArray<float4> boundingSpheresDataQueue
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_boundingSpheresDataQueue);
				return new NativeArray<float4>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<float4>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_boundingSpheresDataQueue), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<float4>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		static TransformUpdateJob()
		{
			Il2CppClassPointerStore<TransformUpdateJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InstanceDataSystem>.NativeClassPtr, "TransformUpdateJob");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TransformUpdateJob>.NativeClassPtr);
			NativeFieldInfoPtr_initialize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformUpdateJob>.NativeClassPtr, "initialize");
			NativeFieldInfoPtr_enableBoundingSpheres = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformUpdateJob>.NativeClassPtr, "enableBoundingSpheres");
			NativeFieldInfoPtr_instances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformUpdateJob>.NativeClassPtr, "instances");
			NativeFieldInfoPtr_localToWorldMatrices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformUpdateJob>.NativeClassPtr, "localToWorldMatrices");
			NativeFieldInfoPtr_prevLocalToWorldMatrices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformUpdateJob>.NativeClassPtr, "prevLocalToWorldMatrices");
			NativeFieldInfoPtr_atomicTransformQueueCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformUpdateJob>.NativeClassPtr, "atomicTransformQueueCount");
			NativeFieldInfoPtr_sharedInstanceData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformUpdateJob>.NativeClassPtr, "sharedInstanceData");
			NativeFieldInfoPtr_instanceData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformUpdateJob>.NativeClassPtr, "instanceData");
			NativeFieldInfoPtr_transformUpdateInstanceQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformUpdateJob>.NativeClassPtr, "transformUpdateInstanceQueue");
			NativeFieldInfoPtr_transformUpdateDataQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformUpdateJob>.NativeClassPtr, "transformUpdateDataQueue");
			NativeFieldInfoPtr_boundingSpheresDataQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformUpdateJob>.NativeClassPtr, "boundingSpheresDataQueue");
			NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformUpdateJob>.NativeClassPtr, 100663857);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1072607, XrefRangeEnd = 1072643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		public TransformUpdateJob(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public TransformUpdateJob()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TransformUpdateJob>.NativeClassPtr))
		{
		}
	}

	public sealed class ProbesUpdateJob : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_instances;

		private static readonly System.IntPtr NativeFieldInfoPtr_instanceData;

		private static readonly System.IntPtr NativeFieldInfoPtr_sharedInstanceData;

		private static readonly System.IntPtr NativeFieldInfoPtr_atomicProbesQueueCount;

		private static readonly System.IntPtr NativeFieldInfoPtr_probeInstanceQueue;

		private static readonly System.IntPtr NativeFieldInfoPtr_compactTetrahedronCache;

		private static readonly System.IntPtr NativeFieldInfoPtr_probeQueryPosition;

		private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_Int32_0;

		public unsafe NativeArray<InstanceHandle> instances
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_instances);
				return new NativeArray<InstanceHandle>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<InstanceHandle>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_instances), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<InstanceHandle>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe CPUInstanceData instanceData
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_instanceData);
				return new CPUInstanceData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CPUInstanceData>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_instanceData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CPUInstanceData>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe CPUSharedInstanceData sharedInstanceData
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sharedInstanceData);
				return new CPUSharedInstanceData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CPUSharedInstanceData>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sharedInstanceData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CPUSharedInstanceData>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe UnsafeAtomicCounter32 atomicProbesQueueCount
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_atomicProbesQueueCount);
				return *(UnsafeAtomicCounter32*)num;
			}
			set
			{
				*(UnsafeAtomicCounter32*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_atomicProbesQueueCount)) = value;
			}
		}

		public unsafe NativeArray<InstanceHandle> probeInstanceQueue
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_probeInstanceQueue);
				return new NativeArray<InstanceHandle>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<InstanceHandle>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_probeInstanceQueue), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<InstanceHandle>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe NativeArray<int> compactTetrahedronCache
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_compactTetrahedronCache);
				return new NativeArray<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_compactTetrahedronCache), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe NativeArray<Vector3> probeQueryPosition
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_probeQueryPosition);
				return new NativeArray<Vector3>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<Vector3>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_probeQueryPosition), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<Vector3>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		static ProbesUpdateJob()
		{
			Il2CppClassPointerStore<ProbesUpdateJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InstanceDataSystem>.NativeClassPtr, "ProbesUpdateJob");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProbesUpdateJob>.NativeClassPtr);
			NativeFieldInfoPtr_instances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbesUpdateJob>.NativeClassPtr, "instances");
			NativeFieldInfoPtr_instanceData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbesUpdateJob>.NativeClassPtr, "instanceData");
			NativeFieldInfoPtr_sharedInstanceData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbesUpdateJob>.NativeClassPtr, "sharedInstanceData");
			NativeFieldInfoPtr_atomicProbesQueueCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbesUpdateJob>.NativeClassPtr, "atomicProbesQueueCount");
			NativeFieldInfoPtr_probeInstanceQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbesUpdateJob>.NativeClassPtr, "probeInstanceQueue");
			NativeFieldInfoPtr_compactTetrahedronCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbesUpdateJob>.NativeClassPtr, "compactTetrahedronCache");
			NativeFieldInfoPtr_probeQueryPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbesUpdateJob>.NativeClassPtr, "probeQueryPosition");
			NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbesUpdateJob>.NativeClassPtr, 100663858);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1072643, XrefRangeEnd = 1072663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		public ProbesUpdateJob(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public ProbesUpdateJob()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProbesUpdateJob>.NativeClassPtr))
		{
		}
	}

	public sealed class MotionUpdateJob : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_queueWriteBase;

		private static readonly System.IntPtr NativeFieldInfoPtr_instanceData;

		private static readonly System.IntPtr NativeFieldInfoPtr_atomicUpdateQueueCount;

		private static readonly System.IntPtr NativeFieldInfoPtr_transformUpdateInstanceQueue;

		private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_0;

		public unsafe int queueWriteBase
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_queueWriteBase);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_queueWriteBase)) = value;
			}
		}

		public unsafe CPUInstanceData instanceData
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_instanceData);
				return new CPUInstanceData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CPUInstanceData>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_instanceData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CPUInstanceData>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe UnsafeAtomicCounter32 atomicUpdateQueueCount
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_atomicUpdateQueueCount);
				return *(UnsafeAtomicCounter32*)num;
			}
			set
			{
				*(UnsafeAtomicCounter32*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_atomicUpdateQueueCount)) = value;
			}
		}

		public unsafe NativeArray<InstanceHandle> transformUpdateInstanceQueue
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_transformUpdateInstanceQueue);
				return new NativeArray<InstanceHandle>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<InstanceHandle>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_transformUpdateInstanceQueue), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<InstanceHandle>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		static MotionUpdateJob()
		{
			Il2CppClassPointerStore<MotionUpdateJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InstanceDataSystem>.NativeClassPtr, "MotionUpdateJob");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MotionUpdateJob>.NativeClassPtr);
			NativeFieldInfoPtr_queueWriteBase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotionUpdateJob>.NativeClassPtr, "queueWriteBase");
			NativeFieldInfoPtr_instanceData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotionUpdateJob>.NativeClassPtr, "instanceData");
			NativeFieldInfoPtr_atomicUpdateQueueCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotionUpdateJob>.NativeClassPtr, "atomicUpdateQueueCount");
			NativeFieldInfoPtr_transformUpdateInstanceQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MotionUpdateJob>.NativeClassPtr, "transformUpdateInstanceQueue");
			NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MotionUpdateJob>.NativeClassPtr, 100663859);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1072663, XrefRangeEnd = 1072668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Execute(int chunk_index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&chunk_index);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public MotionUpdateJob(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public MotionUpdateJob()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MotionUpdateJob>.NativeClassPtr))
		{
		}
	}

	public sealed class UpdateRendererInstancesJob : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_implicitInstanceIndices;

		private static readonly System.IntPtr NativeFieldInfoPtr_rendererData;

		private static readonly System.IntPtr NativeFieldInfoPtr_instances;

		private static readonly System.IntPtr NativeFieldInfoPtr_lodGroupDataMap;

		private static readonly System.IntPtr NativeFieldInfoPtr_instanceData;

		private static readonly System.IntPtr NativeFieldInfoPtr_sharedInstanceData;

		private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_0;

		public unsafe bool implicitInstanceIndices
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_implicitInstanceIndices);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_implicitInstanceIndices)) = value;
			}
		}

		public unsafe GPUDrivenRendererGroupData rendererData
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rendererData);
				return new GPUDrivenRendererGroupData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GPUDrivenRendererGroupData>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rendererData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GPUDrivenRendererGroupData>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe NativeArray<InstanceHandle> instances
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_instances);
				return new NativeArray<InstanceHandle>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<InstanceHandle>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_instances), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<InstanceHandle>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe NativeParallelHashMap<int, GPUInstanceIndex> lodGroupDataMap
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lodGroupDataMap);
				return new NativeParallelHashMap<int, GPUInstanceIndex>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeParallelHashMap<int, GPUInstanceIndex>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lodGroupDataMap), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeParallelHashMap<int, GPUInstanceIndex>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe CPUInstanceData instanceData
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_instanceData);
				return new CPUInstanceData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CPUInstanceData>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_instanceData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CPUInstanceData>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe CPUSharedInstanceData sharedInstanceData
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sharedInstanceData);
				return new CPUSharedInstanceData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CPUSharedInstanceData>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sharedInstanceData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CPUSharedInstanceData>.NativeClassPtr, ref *(uint*)null));
			}
		}

		static UpdateRendererInstancesJob()
		{
			Il2CppClassPointerStore<UpdateRendererInstancesJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InstanceDataSystem>.NativeClassPtr, "UpdateRendererInstancesJob");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UpdateRendererInstancesJob>.NativeClassPtr);
			NativeFieldInfoPtr_implicitInstanceIndices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateRendererInstancesJob>.NativeClassPtr, "implicitInstanceIndices");
			NativeFieldInfoPtr_rendererData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateRendererInstancesJob>.NativeClassPtr, "rendererData");
			NativeFieldInfoPtr_instances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateRendererInstancesJob>.NativeClassPtr, "instances");
			NativeFieldInfoPtr_lodGroupDataMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateRendererInstancesJob>.NativeClassPtr, "lodGroupDataMap");
			NativeFieldInfoPtr_instanceData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateRendererInstancesJob>.NativeClassPtr, "instanceData");
			NativeFieldInfoPtr_sharedInstanceData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateRendererInstancesJob>.NativeClassPtr, "sharedInstanceData");
			NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateRendererInstancesJob>.NativeClassPtr, 100663860);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1072668, XrefRangeEnd = 1072708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Execute(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&index);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public UpdateRendererInstancesJob(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public UpdateRendererInstancesJob()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UpdateRendererInstancesJob>.NativeClassPtr))
		{
		}
	}

	public sealed class CollectInstancesLODGroupsAndMasksJob : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_instances;

		private static readonly System.IntPtr NativeFieldInfoPtr_instanceData;

		private static readonly System.IntPtr NativeFieldInfoPtr_sharedInstanceData;

		private static readonly System.IntPtr NativeFieldInfoPtr_lodGroupAndMasks;

		private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_0;

		public unsafe NativeArray<InstanceHandle> instances
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_instances);
				return new NativeArray<InstanceHandle>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<InstanceHandle>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_instances), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<InstanceHandle>>.NativeClassPtr, ref *(uint*)null));
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

		public unsafe CPUSharedInstanceData.ReadOnly sharedInstanceData
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sharedInstanceData);
				return new CPUSharedInstanceData.ReadOnly(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CPUSharedInstanceData.ReadOnly>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sharedInstanceData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CPUSharedInstanceData.ReadOnly>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe NativeArray<uint> lodGroupAndMasks
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lodGroupAndMasks);
				return new NativeArray<uint>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<uint>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lodGroupAndMasks), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<uint>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		static CollectInstancesLODGroupsAndMasksJob()
		{
			Il2CppClassPointerStore<CollectInstancesLODGroupsAndMasksJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InstanceDataSystem>.NativeClassPtr, "CollectInstancesLODGroupsAndMasksJob");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CollectInstancesLODGroupsAndMasksJob>.NativeClassPtr);
			NativeFieldInfoPtr_instances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CollectInstancesLODGroupsAndMasksJob>.NativeClassPtr, "instances");
			NativeFieldInfoPtr_instanceData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CollectInstancesLODGroupsAndMasksJob>.NativeClassPtr, "instanceData");
			NativeFieldInfoPtr_sharedInstanceData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CollectInstancesLODGroupsAndMasksJob>.NativeClassPtr, "sharedInstanceData");
			NativeFieldInfoPtr_lodGroupAndMasks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CollectInstancesLODGroupsAndMasksJob>.NativeClassPtr, "lodGroupAndMasks");
			NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectInstancesLODGroupsAndMasksJob>.NativeClassPtr, 100663861);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1072708, XrefRangeEnd = 1072712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Execute(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&index);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public CollectInstancesLODGroupsAndMasksJob(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public CollectInstancesLODGroupsAndMasksJob()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CollectInstancesLODGroupsAndMasksJob>.NativeClassPtr))
		{
		}
	}

	public sealed class GetVisibleNonProcessedTreeInstancesJob : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_instanceData;

		private static readonly System.IntPtr NativeFieldInfoPtr_sharedInstanceData;

		private static readonly System.IntPtr NativeFieldInfoPtr_compactedVisibilityMasks;

		private static readonly System.IntPtr NativeFieldInfoPtr_becomeVisible;

		private static readonly System.IntPtr NativeFieldInfoPtr_processedBits;

		private static readonly System.IntPtr NativeFieldInfoPtr_rendererIDs;

		private static readonly System.IntPtr NativeFieldInfoPtr_instances;

		private static readonly System.IntPtr NativeFieldInfoPtr_atomicTreeInstancesCount;

		private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_Int32_0;

		public unsafe CPUInstanceData instanceData
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_instanceData);
				return new CPUInstanceData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CPUInstanceData>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_instanceData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CPUInstanceData>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe CPUSharedInstanceData sharedInstanceData
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sharedInstanceData);
				return new CPUSharedInstanceData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CPUSharedInstanceData>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sharedInstanceData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CPUSharedInstanceData>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe ParallelBitArray compactedVisibilityMasks
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_compactedVisibilityMasks);
				return new ParallelBitArray(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ParallelBitArray>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_compactedVisibilityMasks), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ParallelBitArray>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe bool becomeVisible
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_becomeVisible);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_becomeVisible)) = value;
			}
		}

		public unsafe ParallelBitArray processedBits
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_processedBits);
				return new ParallelBitArray(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ParallelBitArray>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_processedBits), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ParallelBitArray>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe NativeArray<int> rendererIDs
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rendererIDs);
				return new NativeArray<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rendererIDs), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe NativeArray<InstanceHandle> instances
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_instances);
				return new NativeArray<InstanceHandle>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<InstanceHandle>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_instances), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<InstanceHandle>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe UnsafeAtomicCounter32 atomicTreeInstancesCount
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_atomicTreeInstancesCount);
				return *(UnsafeAtomicCounter32*)num;
			}
			set
			{
				*(UnsafeAtomicCounter32*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_atomicTreeInstancesCount)) = value;
			}
		}

		static GetVisibleNonProcessedTreeInstancesJob()
		{
			Il2CppClassPointerStore<GetVisibleNonProcessedTreeInstancesJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InstanceDataSystem>.NativeClassPtr, "GetVisibleNonProcessedTreeInstancesJob");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetVisibleNonProcessedTreeInstancesJob>.NativeClassPtr);
			NativeFieldInfoPtr_instanceData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetVisibleNonProcessedTreeInstancesJob>.NativeClassPtr, "instanceData");
			NativeFieldInfoPtr_sharedInstanceData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetVisibleNonProcessedTreeInstancesJob>.NativeClassPtr, "sharedInstanceData");
			NativeFieldInfoPtr_compactedVisibilityMasks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetVisibleNonProcessedTreeInstancesJob>.NativeClassPtr, "compactedVisibilityMasks");
			NativeFieldInfoPtr_becomeVisible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetVisibleNonProcessedTreeInstancesJob>.NativeClassPtr, "becomeVisible");
			NativeFieldInfoPtr_processedBits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetVisibleNonProcessedTreeInstancesJob>.NativeClassPtr, "processedBits");
			NativeFieldInfoPtr_rendererIDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetVisibleNonProcessedTreeInstancesJob>.NativeClassPtr, "rendererIDs");
			NativeFieldInfoPtr_instances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetVisibleNonProcessedTreeInstancesJob>.NativeClassPtr, "instances");
			NativeFieldInfoPtr_atomicTreeInstancesCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetVisibleNonProcessedTreeInstancesJob>.NativeClassPtr, "atomicTreeInstancesCount");
			NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetVisibleNonProcessedTreeInstancesJob>.NativeClassPtr, 100663862);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1072712, XrefRangeEnd = 1072729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		public GetVisibleNonProcessedTreeInstancesJob(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public GetVisibleNonProcessedTreeInstancesJob()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GetVisibleNonProcessedTreeInstancesJob>.NativeClassPtr))
		{
		}
	}

	public sealed class UpdateCompactedInstanceVisibilityJob : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_compactedVisibilityMasks;

		private static readonly System.IntPtr NativeFieldInfoPtr_instanceData;

		private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_Int32_0;

		public unsafe ParallelBitArray compactedVisibilityMasks
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_compactedVisibilityMasks);
				return new ParallelBitArray(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ParallelBitArray>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_compactedVisibilityMasks), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ParallelBitArray>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe CPUInstanceData instanceData
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_instanceData);
				return new CPUInstanceData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CPUInstanceData>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_instanceData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CPUInstanceData>.NativeClassPtr, ref *(uint*)null));
			}
		}

		static UpdateCompactedInstanceVisibilityJob()
		{
			Il2CppClassPointerStore<UpdateCompactedInstanceVisibilityJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InstanceDataSystem>.NativeClassPtr, "UpdateCompactedInstanceVisibilityJob");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UpdateCompactedInstanceVisibilityJob>.NativeClassPtr);
			NativeFieldInfoPtr_compactedVisibilityMasks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateCompactedInstanceVisibilityJob>.NativeClassPtr, "compactedVisibilityMasks");
			NativeFieldInfoPtr_instanceData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateCompactedInstanceVisibilityJob>.NativeClassPtr, "instanceData");
			NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateCompactedInstanceVisibilityJob>.NativeClassPtr, 100663863);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1072729, XrefRangeEnd = 1072736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		public UpdateCompactedInstanceVisibilityJob(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public UpdateCompactedInstanceVisibilityJob()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UpdateCompactedInstanceVisibilityJob>.NativeClassPtr))
		{
		}
	}

	private sealed class MethodInfoStoreGeneric_AtomicAddLengthNoResize_Private_Static_Int32_byref_NativeList_1_T_Int32_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_AtomicAddLengthNoResize_Private_Static_Int32_byref_NativeList_1_T_Int32_0, Il2CppClassPointerStore<InstanceDataSystem>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_m_InstanceAllocators;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_SharedInstanceData;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_InstanceData;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_RendererGroupInstanceMultiHash;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_TransformUpdateCS;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_WindDataUpdateCS;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_TransformInitKernel;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_TransformUpdateKernel;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_MotionUpdateKernel;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ProbeUpdateKernel;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_WindDataCopyHistoryKernel;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_UpdateIndexQueueBuffer;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ProbeUpdateDataQueueBuffer;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ProbeOcclusionUpdateDataQueueBuffer;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_TransformUpdateDataQueueBuffer;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_BoundingSpheresUpdateDataQueueBuffer;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_EnableBoundingSpheres;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ScratchWindParamAddressArray;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_hasBoundingSpheres_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_instanceData_Public_get_ReadOnly_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_sharedInstanceData_Public_get_ReadOnly_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_aliveInstances_Public_get_NativeArray_1_InstanceHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Boolean_GPUResidentDrawerResources_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMaxInstancesOfType_Public_Int32_InstanceType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAliveInstancesOfType_Public_Int32_InstanceType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnsureIndexQueueBufferCapacity_Private_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnsureProbeBuffersCapacity_Private_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnsureTransformBuffersCapacity_Private_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleInterpolateProbesAndUpdateTetrahedronCache_Private_JobHandle_Int32_NativeArray_1_InstanceHandle_NativeArray_1_Int32_NativeArray_1_Vector3_NativeArray_1_SphericalHarmonicsL2_NativeArray_1_Vector4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DispatchProbeUpdateCommand_Private_Void_Int32_NativeArray_1_InstanceHandle_NativeArray_1_SphericalHarmonicsL2_NativeArray_1_Vector4_RenderersParameters_GPUInstanceDataBuffer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DispatchMotionUpdateCommand_Private_Void_Int32_NativeArray_1_InstanceHandle_RenderersParameters_GPUInstanceDataBuffer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DispatchTransformUpdateCommand_Private_Void_Boolean_Int32_NativeArray_1_InstanceHandle_NativeArray_1_TransformUpdatePacket_NativeArray_1_float4_RenderersParameters_GPUInstanceDataBuffer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DispatchWindDataCopyHistoryCommand_Private_Void_NativeArray_1_GPUInstanceIndex_RenderersParameters_GPUInstanceDataBuffer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateInstanceMotionsData_Private_Void_byref_RenderersParameters_GPUInstanceDataBuffer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateInstanceTransformsData_Private_Void_Boolean_NativeArray_1_InstanceHandle_NativeArray_1_Matrix4x4_NativeArray_1_Matrix4x4_byref_RenderersParameters_GPUInstanceDataBuffer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateInstanceProbesData_Private_Void_NativeArray_1_InstanceHandle_byref_RenderersParameters_GPUInstanceDataBuffer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateInstanceWindDataHistory_Public_Void_NativeArray_1_GPUInstanceIndex_RenderersParameters_GPUInstanceDataBuffer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReallocateAndGetInstances_Public_Void_byref_GPUDrivenRendererGroupData_NativeArray_1_InstanceHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FreeRendererGroupInstances_Public_Void_NativeArray_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleUpdateInstanceDataJob_Public_JobHandle_NativeArray_1_InstanceHandle_byref_GPUDrivenRendererGroupData_NativeParallelHashMap_2_Int32_GPUInstanceIndex_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateAllInstanceProbes_Public_Void_byref_RenderersParameters_GPUInstanceDataBuffer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitializeInstanceTransforms_Public_Void_NativeArray_1_InstanceHandle_NativeArray_1_Matrix4x4_NativeArray_1_Matrix4x4_byref_RenderersParameters_GPUInstanceDataBuffer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateInstanceTransforms_Public_Void_NativeArray_1_InstanceHandle_NativeArray_1_Matrix4x4_byref_RenderersParameters_GPUInstanceDataBuffer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateInstanceMotions_Public_Void_byref_RenderersParameters_GPUInstanceDataBuffer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleQueryRendererGroupInstancesJob_Public_JobHandle_NativeArray_1_Int32_NativeArray_1_InstanceHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleQueryRendererGroupInstancesJob_Public_JobHandle_NativeArray_1_Int32_NativeList_1_InstanceHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleQueryRendererGroupInstancesJob_Public_JobHandle_NativeArray_1_Int32_NativeArray_1_Int32_NativeArray_1_Int32_NativeList_1_InstanceHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleQuerySortedMeshInstancesJob_Public_JobHandle_NativeArray_1_Int32_NativeList_1_InstanceHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetVisibleTreeInstances_Public_Void_byref_ParallelBitArray_byref_ParallelBitArray_NativeList_1_Int32_NativeList_1_InstanceHandle_Boolean_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdatePerFrameInstanceVisibility_Public_Void_byref_ParallelBitArray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AtomicAddLengthNoResize_Private_Static_Int32_byref_NativeList_1_T_Int32_0;

	public unsafe InstanceAllocators m_InstanceAllocators
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_InstanceAllocators);
			return new InstanceAllocators(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InstanceAllocators>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_InstanceAllocators), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<InstanceAllocators>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe CPUSharedInstanceData m_SharedInstanceData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SharedInstanceData);
			return new CPUSharedInstanceData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CPUSharedInstanceData>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SharedInstanceData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CPUSharedInstanceData>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe CPUInstanceData m_InstanceData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_InstanceData);
			return new CPUInstanceData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CPUInstanceData>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_InstanceData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CPUInstanceData>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeParallelMultiHashMap<int, InstanceHandle> m_RendererGroupInstanceMultiHash
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RendererGroupInstanceMultiHash);
			return new NativeParallelMultiHashMap<int, InstanceHandle>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeParallelMultiHashMap<int, InstanceHandle>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RendererGroupInstanceMultiHash), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeParallelMultiHashMap<int, InstanceHandle>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe ComputeShader m_TransformUpdateCS
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TransformUpdateCS);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ComputeShader>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TransformUpdateCS)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe ComputeShader m_WindDataUpdateCS
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_WindDataUpdateCS);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ComputeShader>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_WindDataUpdateCS)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe int m_TransformInitKernel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TransformInitKernel);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TransformInitKernel)) = value;
		}
	}

	public unsafe int m_TransformUpdateKernel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TransformUpdateKernel);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TransformUpdateKernel)) = value;
		}
	}

	public unsafe int m_MotionUpdateKernel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MotionUpdateKernel);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MotionUpdateKernel)) = value;
		}
	}

	public unsafe int m_ProbeUpdateKernel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ProbeUpdateKernel);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ProbeUpdateKernel)) = value;
		}
	}

	public unsafe int m_WindDataCopyHistoryKernel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_WindDataCopyHistoryKernel);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_WindDataCopyHistoryKernel)) = value;
		}
	}

	public unsafe ComputeBuffer m_UpdateIndexQueueBuffer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_UpdateIndexQueueBuffer);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ComputeBuffer>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_UpdateIndexQueueBuffer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe ComputeBuffer m_ProbeUpdateDataQueueBuffer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ProbeUpdateDataQueueBuffer);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ComputeBuffer>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ProbeUpdateDataQueueBuffer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe ComputeBuffer m_ProbeOcclusionUpdateDataQueueBuffer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ProbeOcclusionUpdateDataQueueBuffer);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ComputeBuffer>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ProbeOcclusionUpdateDataQueueBuffer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe ComputeBuffer m_TransformUpdateDataQueueBuffer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TransformUpdateDataQueueBuffer);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ComputeBuffer>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TransformUpdateDataQueueBuffer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe ComputeBuffer m_BoundingSpheresUpdateDataQueueBuffer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BoundingSpheresUpdateDataQueueBuffer);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ComputeBuffer>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BoundingSpheresUpdateDataQueueBuffer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe bool m_EnableBoundingSpheres
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_EnableBoundingSpheres);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_EnableBoundingSpheres)) = value;
		}
	}

	public unsafe Il2CppStructArray<int> m_ScratchWindParamAddressArray
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ScratchWindParamAddressArray);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ScratchWindParamAddressArray)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe bool hasBoundingSpheres
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_hasBoundingSpheres_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe CPUInstanceData.ReadOnly instanceData
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1072738, RefRangeEnd = 1072739, XrefRangeStart = 1072736, XrefRangeEnd = 1072738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_instanceData_Public_get_ReadOnly_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new CPUInstanceData.ReadOnly(pointer);
		}
	}

	public unsafe CPUSharedInstanceData.ReadOnly sharedInstanceData
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1072741, RefRangeEnd = 1072743, XrefRangeStart = 1072739, XrefRangeEnd = 1072741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_sharedInstanceData_Public_get_ReadOnly_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new CPUSharedInstanceData.ReadOnly(pointer);
		}
	}

	public unsafe NativeArray<InstanceHandle> aliveInstances
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1072746, RefRangeEnd = 1072747, XrefRangeStart = 1072743, XrefRangeEnd = 1072746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_aliveInstances_Public_get_NativeArray_1_InstanceHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new NativeArray<InstanceHandle>(pointer);
		}
	}

	static InstanceDataSystem()
	{
		Il2CppClassPointerStore<InstanceDataSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.GPUDriven.Runtime.dll", "UnityEngine.Rendering", "InstanceDataSystem");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InstanceDataSystem>.NativeClassPtr);
		NativeFieldInfoPtr_m_InstanceAllocators = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstanceDataSystem>.NativeClassPtr, "m_InstanceAllocators");
		NativeFieldInfoPtr_m_SharedInstanceData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstanceDataSystem>.NativeClassPtr, "m_SharedInstanceData");
		NativeFieldInfoPtr_m_InstanceData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstanceDataSystem>.NativeClassPtr, "m_InstanceData");
		NativeFieldInfoPtr_m_RendererGroupInstanceMultiHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstanceDataSystem>.NativeClassPtr, "m_RendererGroupInstanceMultiHash");
		NativeFieldInfoPtr_m_TransformUpdateCS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstanceDataSystem>.NativeClassPtr, "m_TransformUpdateCS");
		NativeFieldInfoPtr_m_WindDataUpdateCS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstanceDataSystem>.NativeClassPtr, "m_WindDataUpdateCS");
		NativeFieldInfoPtr_m_TransformInitKernel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstanceDataSystem>.NativeClassPtr, "m_TransformInitKernel");
		NativeFieldInfoPtr_m_TransformUpdateKernel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstanceDataSystem>.NativeClassPtr, "m_TransformUpdateKernel");
		NativeFieldInfoPtr_m_MotionUpdateKernel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstanceDataSystem>.NativeClassPtr, "m_MotionUpdateKernel");
		NativeFieldInfoPtr_m_ProbeUpdateKernel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstanceDataSystem>.NativeClassPtr, "m_ProbeUpdateKernel");
		NativeFieldInfoPtr_m_WindDataCopyHistoryKernel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstanceDataSystem>.NativeClassPtr, "m_WindDataCopyHistoryKernel");
		NativeFieldInfoPtr_m_UpdateIndexQueueBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstanceDataSystem>.NativeClassPtr, "m_UpdateIndexQueueBuffer");
		NativeFieldInfoPtr_m_ProbeUpdateDataQueueBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstanceDataSystem>.NativeClassPtr, "m_ProbeUpdateDataQueueBuffer");
		NativeFieldInfoPtr_m_ProbeOcclusionUpdateDataQueueBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstanceDataSystem>.NativeClassPtr, "m_ProbeOcclusionUpdateDataQueueBuffer");
		NativeFieldInfoPtr_m_TransformUpdateDataQueueBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstanceDataSystem>.NativeClassPtr, "m_TransformUpdateDataQueueBuffer");
		NativeFieldInfoPtr_m_BoundingSpheresUpdateDataQueueBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstanceDataSystem>.NativeClassPtr, "m_BoundingSpheresUpdateDataQueueBuffer");
		NativeFieldInfoPtr_m_EnableBoundingSpheres = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstanceDataSystem>.NativeClassPtr, "m_EnableBoundingSpheres");
		NativeFieldInfoPtr_m_ScratchWindParamAddressArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstanceDataSystem>.NativeClassPtr, "m_ScratchWindParamAddressArray");
		NativeMethodInfoPtr_get_hasBoundingSpheres_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceDataSystem>.NativeClassPtr, 100663814);
		NativeMethodInfoPtr_get_instanceData_Public_get_ReadOnly_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceDataSystem>.NativeClassPtr, 100663815);
		NativeMethodInfoPtr_get_sharedInstanceData_Public_get_ReadOnly_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceDataSystem>.NativeClassPtr, 100663816);
		NativeMethodInfoPtr_get_aliveInstances_Public_get_NativeArray_1_InstanceHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceDataSystem>.NativeClassPtr, 100663817);
		NativeMethodInfoPtr__ctor_Public_Void_Int32_Boolean_GPUResidentDrawerResources_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceDataSystem>.NativeClassPtr, 100663818);
		NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceDataSystem>.NativeClassPtr, 100663819);
		NativeMethodInfoPtr_GetMaxInstancesOfType_Public_Int32_InstanceType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceDataSystem>.NativeClassPtr, 100663820);
		NativeMethodInfoPtr_GetAliveInstancesOfType_Public_Int32_InstanceType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceDataSystem>.NativeClassPtr, 100663821);
		NativeMethodInfoPtr_EnsureIndexQueueBufferCapacity_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceDataSystem>.NativeClassPtr, 100663822);
		NativeMethodInfoPtr_EnsureProbeBuffersCapacity_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceDataSystem>.NativeClassPtr, 100663823);
		NativeMethodInfoPtr_EnsureTransformBuffersCapacity_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceDataSystem>.NativeClassPtr, 100663824);
		NativeMethodInfoPtr_ScheduleInterpolateProbesAndUpdateTetrahedronCache_Private_JobHandle_Int32_NativeArray_1_InstanceHandle_NativeArray_1_Int32_NativeArray_1_Vector3_NativeArray_1_SphericalHarmonicsL2_NativeArray_1_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceDataSystem>.NativeClassPtr, 100663825);
		NativeMethodInfoPtr_DispatchProbeUpdateCommand_Private_Void_Int32_NativeArray_1_InstanceHandle_NativeArray_1_SphericalHarmonicsL2_NativeArray_1_Vector4_RenderersParameters_GPUInstanceDataBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceDataSystem>.NativeClassPtr, 100663826);
		NativeMethodInfoPtr_DispatchMotionUpdateCommand_Private_Void_Int32_NativeArray_1_InstanceHandle_RenderersParameters_GPUInstanceDataBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceDataSystem>.NativeClassPtr, 100663827);
		NativeMethodInfoPtr_DispatchTransformUpdateCommand_Private_Void_Boolean_Int32_NativeArray_1_InstanceHandle_NativeArray_1_TransformUpdatePacket_NativeArray_1_float4_RenderersParameters_GPUInstanceDataBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceDataSystem>.NativeClassPtr, 100663828);
		NativeMethodInfoPtr_DispatchWindDataCopyHistoryCommand_Private_Void_NativeArray_1_GPUInstanceIndex_RenderersParameters_GPUInstanceDataBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceDataSystem>.NativeClassPtr, 100663829);
		NativeMethodInfoPtr_UpdateInstanceMotionsData_Private_Void_byref_RenderersParameters_GPUInstanceDataBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceDataSystem>.NativeClassPtr, 100663830);
		NativeMethodInfoPtr_UpdateInstanceTransformsData_Private_Void_Boolean_NativeArray_1_InstanceHandle_NativeArray_1_Matrix4x4_NativeArray_1_Matrix4x4_byref_RenderersParameters_GPUInstanceDataBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceDataSystem>.NativeClassPtr, 100663831);
		NativeMethodInfoPtr_UpdateInstanceProbesData_Private_Void_NativeArray_1_InstanceHandle_byref_RenderersParameters_GPUInstanceDataBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceDataSystem>.NativeClassPtr, 100663832);
		NativeMethodInfoPtr_UpdateInstanceWindDataHistory_Public_Void_NativeArray_1_GPUInstanceIndex_RenderersParameters_GPUInstanceDataBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceDataSystem>.NativeClassPtr, 100663833);
		NativeMethodInfoPtr_ReallocateAndGetInstances_Public_Void_byref_GPUDrivenRendererGroupData_NativeArray_1_InstanceHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceDataSystem>.NativeClassPtr, 100663834);
		NativeMethodInfoPtr_FreeRendererGroupInstances_Public_Void_NativeArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceDataSystem>.NativeClassPtr, 100663835);
		NativeMethodInfoPtr_ScheduleUpdateInstanceDataJob_Public_JobHandle_NativeArray_1_InstanceHandle_byref_GPUDrivenRendererGroupData_NativeParallelHashMap_2_Int32_GPUInstanceIndex_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceDataSystem>.NativeClassPtr, 100663836);
		NativeMethodInfoPtr_UpdateAllInstanceProbes_Public_Void_byref_RenderersParameters_GPUInstanceDataBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceDataSystem>.NativeClassPtr, 100663837);
		NativeMethodInfoPtr_InitializeInstanceTransforms_Public_Void_NativeArray_1_InstanceHandle_NativeArray_1_Matrix4x4_NativeArray_1_Matrix4x4_byref_RenderersParameters_GPUInstanceDataBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceDataSystem>.NativeClassPtr, 100663838);
		NativeMethodInfoPtr_UpdateInstanceTransforms_Public_Void_NativeArray_1_InstanceHandle_NativeArray_1_Matrix4x4_byref_RenderersParameters_GPUInstanceDataBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceDataSystem>.NativeClassPtr, 100663839);
		NativeMethodInfoPtr_UpdateInstanceMotions_Public_Void_byref_RenderersParameters_GPUInstanceDataBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceDataSystem>.NativeClassPtr, 100663840);
		NativeMethodInfoPtr_ScheduleQueryRendererGroupInstancesJob_Public_JobHandle_NativeArray_1_Int32_NativeArray_1_InstanceHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceDataSystem>.NativeClassPtr, 100663841);
		NativeMethodInfoPtr_ScheduleQueryRendererGroupInstancesJob_Public_JobHandle_NativeArray_1_Int32_NativeList_1_InstanceHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceDataSystem>.NativeClassPtr, 100663842);
		NativeMethodInfoPtr_ScheduleQueryRendererGroupInstancesJob_Public_JobHandle_NativeArray_1_Int32_NativeArray_1_Int32_NativeArray_1_Int32_NativeList_1_InstanceHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceDataSystem>.NativeClassPtr, 100663843);
		NativeMethodInfoPtr_ScheduleQuerySortedMeshInstancesJob_Public_JobHandle_NativeArray_1_Int32_NativeList_1_InstanceHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceDataSystem>.NativeClassPtr, 100663844);
		NativeMethodInfoPtr_GetVisibleTreeInstances_Public_Void_byref_ParallelBitArray_byref_ParallelBitArray_NativeList_1_Int32_NativeList_1_InstanceHandle_Boolean_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceDataSystem>.NativeClassPtr, 100663845);
		NativeMethodInfoPtr_UpdatePerFrameInstanceVisibility_Public_Void_byref_ParallelBitArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceDataSystem>.NativeClassPtr, 100663846);
		NativeMethodInfoPtr_AtomicAddLengthNoResize_Private_Static_Int32_byref_NativeList_1_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstanceDataSystem>.NativeClassPtr, 100663847);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1072785, RefRangeEnd = 1072786, XrefRangeStart = 1072747, XrefRangeEnd = 1072785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe InstanceDataSystem(int maxInstances, bool enableBoundingSpheres, GPUResidentDrawerResources resources)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InstanceDataSystem>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&maxInstances);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &enableBoundingSpheres;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)resources);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_Boolean_GPUResidentDrawerResources_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1072797, RefRangeEnd = 1072798, XrefRangeStart = 1072786, XrefRangeEnd = 1072797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Dispose()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1072799, RefRangeEnd = 1072803, XrefRangeStart = 1072798, XrefRangeEnd = 1072799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetMaxInstancesOfType(InstanceType instanceType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&instanceType);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMaxInstancesOfType_Public_Int32_InstanceType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1072804, RefRangeEnd = 1072805, XrefRangeStart = 1072803, XrefRangeEnd = 1072804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetAliveInstancesOfType(InstanceType instanceType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&instanceType);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAliveInstancesOfType_Public_Int32_InstanceType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1072812, RefRangeEnd = 1072816, XrefRangeStart = 1072805, XrefRangeEnd = 1072812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EnsureIndexQueueBufferCapacity(int capacity)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&capacity);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnsureIndexQueueBufferCapacity_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1072816, XrefRangeEnd = 1072838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EnsureProbeBuffersCapacity(int capacity)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&capacity);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnsureProbeBuffersCapacity_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1072862, RefRangeEnd = 1072864, XrefRangeStart = 1072838, XrefRangeEnd = 1072862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EnsureTransformBuffersCapacity(int capacity)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&capacity);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnsureTransformBuffersCapacity_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1072873, RefRangeEnd = 1072875, XrefRangeStart = 1072864, XrefRangeEnd = 1072873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe JobHandle ScheduleInterpolateProbesAndUpdateTetrahedronCache(int queueCount, NativeArray<InstanceHandle> probeUpdateInstanceQueue, NativeArray<int> compactTetrahedronCache, NativeArray<Vector3> probeQueryPosition, NativeArray<SphericalHarmonicsL2> probeUpdateDataQueue, NativeArray<Vector4> probeOcclusionUpdateDataQueue)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&queueCount);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)probeUpdateInstanceQueue));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)compactTetrahedronCache));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)probeQueryPosition));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)probeUpdateDataQueue));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)probeOcclusionUpdateDataQueue));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ScheduleInterpolateProbesAndUpdateTetrahedronCache_Private_JobHandle_Int32_NativeArray_1_InstanceHandle_NativeArray_1_Int32_NativeArray_1_Vector3_NativeArray_1_SphericalHarmonicsL2_NativeArray_1_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(JobHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1072935, RefRangeEnd = 1072937, XrefRangeStart = 1072875, XrefRangeEnd = 1072935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DispatchProbeUpdateCommand(int queueCount, NativeArray<InstanceHandle> probeInstanceQueue, NativeArray<SphericalHarmonicsL2> probeUpdateDataQueue, NativeArray<Vector4> probeOcclusionUpdateDataQueue, RenderersParameters renderersParameters, GPUInstanceDataBuffer outputBuffer)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&queueCount);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)probeInstanceQueue));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)probeUpdateDataQueue));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)probeOcclusionUpdateDataQueue));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)renderersParameters));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)outputBuffer);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DispatchProbeUpdateCommand_Private_Void_Int32_NativeArray_1_InstanceHandle_NativeArray_1_SphericalHarmonicsL2_NativeArray_1_Vector4_RenderersParameters_GPUInstanceDataBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1072972, RefRangeEnd = 1072974, XrefRangeStart = 1072937, XrefRangeEnd = 1072972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DispatchMotionUpdateCommand(int motionQueueCount, NativeArray<InstanceHandle> transformInstanceQueue, RenderersParameters renderersParameters, GPUInstanceDataBuffer outputBuffer)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&motionQueueCount);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)transformInstanceQueue));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)renderersParameters));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)outputBuffer);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DispatchMotionUpdateCommand_Private_Void_Int32_NativeArray_1_InstanceHandle_RenderersParameters_GPUInstanceDataBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1073025, RefRangeEnd = 1073026, XrefRangeStart = 1072974, XrefRangeEnd = 1073025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DispatchTransformUpdateCommand(bool initialize, int transformQueueCount, NativeArray<InstanceHandle> transformInstanceQueue, NativeArray<TransformUpdatePacket> updateDataQueue, NativeArray<float4> boundingSphereUpdateDataQueue, RenderersParameters renderersParameters, GPUInstanceDataBuffer outputBuffer)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = (nint)(&initialize);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &transformQueueCount;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)transformInstanceQueue));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)updateDataQueue));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)boundingSphereUpdateDataQueue));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)renderersParameters));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)outputBuffer);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DispatchTransformUpdateCommand_Private_Void_Boolean_Int32_NativeArray_1_InstanceHandle_NativeArray_1_TransformUpdatePacket_NativeArray_1_float4_RenderersParameters_GPUInstanceDataBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1073048, RefRangeEnd = 1073049, XrefRangeStart = 1073026, XrefRangeEnd = 1073048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DispatchWindDataCopyHistoryCommand(NativeArray<GPUInstanceIndex> gpuInstanceIndices, RenderersParameters renderersParameters, GPUInstanceDataBuffer outputBuffer)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)gpuInstanceIndices));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)renderersParameters));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)outputBuffer);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DispatchWindDataCopyHistoryCommand_Private_Void_NativeArray_1_GPUInstanceIndex_RenderersParameters_GPUInstanceDataBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1073049, XrefRangeEnd = 1073061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateInstanceMotionsData([In] ref RenderersParameters renderersParameters, GPUInstanceDataBuffer outputBuffer)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)renderersParameters);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)outputBuffer);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateInstanceMotionsData_Private_Void_byref_RenderersParameters_GPUInstanceDataBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1073121, RefRangeEnd = 1073123, XrefRangeStart = 1073061, XrefRangeEnd = 1073121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateInstanceTransformsData(bool initialize, NativeArray<InstanceHandle> instances, NativeArray<Matrix4x4> localToWorldMatrices, NativeArray<Matrix4x4> prevLocalToWorldMatrices, [In] ref RenderersParameters renderersParameters, GPUInstanceDataBuffer outputBuffer)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&initialize);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)instances));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)localToWorldMatrices));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)prevLocalToWorldMatrices));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)renderersParameters);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)outputBuffer);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateInstanceTransformsData_Private_Void_Boolean_NativeArray_1_InstanceHandle_NativeArray_1_Matrix4x4_NativeArray_1_Matrix4x4_byref_RenderersParameters_GPUInstanceDataBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1073161, RefRangeEnd = 1073162, XrefRangeStart = 1073123, XrefRangeEnd = 1073161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateInstanceProbesData(NativeArray<InstanceHandle> instances, [In] ref RenderersParameters renderersParameters, GPUInstanceDataBuffer outputBuffer)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)instances));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)renderersParameters);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)outputBuffer);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateInstanceProbesData_Private_Void_NativeArray_1_InstanceHandle_byref_RenderersParameters_GPUInstanceDataBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1073163, RefRangeEnd = 1073164, XrefRangeStart = 1073162, XrefRangeEnd = 1073163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateInstanceWindDataHistory(NativeArray<GPUInstanceIndex> gpuInstanceIndices, RenderersParameters renderersParameters, GPUInstanceDataBuffer outputBuffer)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)gpuInstanceIndices));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)renderersParameters));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)outputBuffer);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateInstanceWindDataHistory_Public_Void_NativeArray_1_GPUInstanceIndex_RenderersParameters_GPUInstanceDataBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1073176, RefRangeEnd = 1073177, XrefRangeStart = 1073164, XrefRangeEnd = 1073176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ReallocateAndGetInstances([In] ref GPUDrivenRendererGroupData rendererData, NativeArray<InstanceHandle> instances)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)rendererData);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)instances));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReallocateAndGetInstances_Public_Void_byref_GPUDrivenRendererGroupData_NativeArray_1_InstanceHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1073181, RefRangeEnd = 1073182, XrefRangeStart = 1073177, XrefRangeEnd = 1073181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FreeRendererGroupInstances(NativeArray<int> rendererGroupsID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)rendererGroupsID));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FreeRendererGroupInstances_Public_Void_NativeArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1073186, RefRangeEnd = 1073187, XrefRangeStart = 1073182, XrefRangeEnd = 1073186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe JobHandle ScheduleUpdateInstanceDataJob(NativeArray<InstanceHandle> instances, [In] ref GPUDrivenRendererGroupData rendererData, NativeParallelHashMap<int, GPUInstanceIndex> lodGroupDataMap)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)instances));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)rendererData);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)lodGroupDataMap));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ScheduleUpdateInstanceDataJob_Public_JobHandle_NativeArray_1_InstanceHandle_byref_GPUDrivenRendererGroupData_NativeParallelHashMap_2_Int32_GPUInstanceIndex_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(JobHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1073191, RefRangeEnd = 1073192, XrefRangeStart = 1073187, XrefRangeEnd = 1073191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateAllInstanceProbes([In] ref RenderersParameters renderersParameters, GPUInstanceDataBuffer outputBuffer)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)renderersParameters);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)outputBuffer);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateAllInstanceProbes_Public_Void_byref_RenderersParameters_GPUInstanceDataBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1073193, RefRangeEnd = 1073194, XrefRangeStart = 1073192, XrefRangeEnd = 1073193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InitializeInstanceTransforms(NativeArray<InstanceHandle> instances, NativeArray<Matrix4x4> localToWorldMatrices, NativeArray<Matrix4x4> prevLocalToWorldMatrices, [In] ref RenderersParameters renderersParameters, GPUInstanceDataBuffer outputBuffer)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)instances));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)localToWorldMatrices));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)prevLocalToWorldMatrices));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)renderersParameters);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)outputBuffer);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitializeInstanceTransforms_Public_Void_NativeArray_1_InstanceHandle_NativeArray_1_Matrix4x4_NativeArray_1_Matrix4x4_byref_RenderersParameters_GPUInstanceDataBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1073195, RefRangeEnd = 1073196, XrefRangeStart = 1073194, XrefRangeEnd = 1073195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateInstanceTransforms(NativeArray<InstanceHandle> instances, NativeArray<Matrix4x4> localToWorldMatrices, [In] ref RenderersParameters renderersParameters, GPUInstanceDataBuffer outputBuffer)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)instances));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)localToWorldMatrices));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)renderersParameters);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)outputBuffer);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateInstanceTransforms_Public_Void_NativeArray_1_InstanceHandle_NativeArray_1_Matrix4x4_byref_RenderersParameters_GPUInstanceDataBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1073208, RefRangeEnd = 1073209, XrefRangeStart = 1073196, XrefRangeEnd = 1073208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateInstanceMotions([In] ref RenderersParameters renderersParameters, GPUInstanceDataBuffer outputBuffer)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)renderersParameters);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)outputBuffer);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateInstanceMotions_Public_Void_byref_RenderersParameters_GPUInstanceDataBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1073212, RefRangeEnd = 1073213, XrefRangeStart = 1073209, XrefRangeEnd = 1073212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe JobHandle ScheduleQueryRendererGroupInstancesJob(NativeArray<int> rendererGroupIDs, NativeArray<InstanceHandle> instances)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)rendererGroupIDs));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)instances));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ScheduleQueryRendererGroupInstancesJob_Public_JobHandle_NativeArray_1_Int32_NativeArray_1_InstanceHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(JobHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1073225, RefRangeEnd = 1073226, XrefRangeStart = 1073213, XrefRangeEnd = 1073225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe JobHandle ScheduleQueryRendererGroupInstancesJob(NativeArray<int> rendererGroupIDs, NativeList<InstanceHandle> instances)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)rendererGroupIDs));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)instances));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ScheduleQueryRendererGroupInstancesJob_Public_JobHandle_NativeArray_1_Int32_NativeList_1_InstanceHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(JobHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1073240, RefRangeEnd = 1073241, XrefRangeStart = 1073226, XrefRangeEnd = 1073240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe JobHandle ScheduleQueryRendererGroupInstancesJob(NativeArray<int> rendererGroupIDs, NativeArray<int> instancesOffset, NativeArray<int> instancesCount, NativeList<InstanceHandle> instances)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)rendererGroupIDs));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)instancesOffset));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)instancesCount));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)instances));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ScheduleQueryRendererGroupInstancesJob_Public_JobHandle_NativeArray_1_Int32_NativeArray_1_Int32_NativeArray_1_Int32_NativeList_1_InstanceHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(JobHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1073249, RefRangeEnd = 1073250, XrefRangeStart = 1073241, XrefRangeEnd = 1073249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe JobHandle ScheduleQuerySortedMeshInstancesJob(NativeArray<int> sortedMeshIDs, NativeList<InstanceHandle> instances)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)sortedMeshIDs));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)instances));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ScheduleQuerySortedMeshInstancesJob_Public_JobHandle_NativeArray_1_Int32_NativeList_1_InstanceHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(JobHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1073282, RefRangeEnd = 1073283, XrefRangeStart = 1073250, XrefRangeEnd = 1073282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetVisibleTreeInstances([In] ref ParallelBitArray compactedVisibilityMasks, [In] ref ParallelBitArray processedBits, NativeList<int> visibeTreeRendererIDs, NativeList<InstanceHandle> visibeTreeInstances, bool becomeVisibleOnly, out int becomeVisibeTreeInstancesCount)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)compactedVisibilityMasks);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)processedBits);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)visibeTreeRendererIDs));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)visibeTreeInstances));
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &becomeVisibleOnly;
		*(void**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref becomeVisibeTreeInstancesCount);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetVisibleTreeInstances_Public_Void_byref_ParallelBitArray_byref_ParallelBitArray_NativeList_1_Int32_NativeList_1_InstanceHandle_Boolean_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1073288, RefRangeEnd = 1073289, XrefRangeStart = 1073283, XrefRangeEnd = 1073288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdatePerFrameInstanceVisibility([In] ref ParallelBitArray compactedVisibilityMasks)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)compactedVisibilityMasks);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdatePerFrameInstanceVisibility_Public_Void_byref_ParallelBitArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1073291, RefRangeEnd = 1073292, XrefRangeStart = 1073289, XrefRangeEnd = 1073291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int AtomicAddLengthNoResize<T>([In] ref NativeList<T> list, int count) where T : new()
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)list);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_AtomicAddLengthNoResize_Private_Static_Int32_byref_NativeList_1_T_Int32_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public InstanceDataSystem(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
