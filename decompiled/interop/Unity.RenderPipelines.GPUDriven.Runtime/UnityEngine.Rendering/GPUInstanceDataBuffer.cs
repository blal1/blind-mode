using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Unity.Collections;

namespace UnityEngine.Rendering;

public class GPUInstanceDataBuffer : Il2CppSystem.Object
{
	public sealed class ReadOnly : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_instancesNumPrefixSum;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_GPUInstanceDataBuffer_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_CPUInstanceToGPUInstance_Public_GPUInstanceIndex_InstanceHandle_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_CPUInstanceArrayToGPUInstanceArray_Public_Void_NativeArray_1_InstanceHandle_NativeArray_1_GPUInstanceIndex_0;

		public unsafe NativeArray<int> instancesNumPrefixSum
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_instancesNumPrefixSum);
				return new NativeArray<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_instancesNumPrefixSum), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		static ReadOnly()
		{
			Il2CppClassPointerStore<ReadOnly>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GPUInstanceDataBuffer>.NativeClassPtr, "ReadOnly");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReadOnly>.NativeClassPtr);
			NativeFieldInfoPtr_instancesNumPrefixSum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadOnly>.NativeClassPtr, "instancesNumPrefixSum");
			NativeMethodInfoPtr__ctor_Public_Void_GPUInstanceDataBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnly>.NativeClassPtr, 100663684);
			NativeMethodInfoPtr_CPUInstanceToGPUInstance_Public_GPUInstanceIndex_InstanceHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnly>.NativeClassPtr, 100663685);
			NativeMethodInfoPtr_CPUInstanceArrayToGPUInstanceArray_Public_Void_NativeArray_1_InstanceHandle_NativeArray_1_GPUInstanceIndex_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnly>.NativeClassPtr, 100663686);
		}

		[CallerCount(0)]
		public unsafe ReadOnly(GPUInstanceDataBuffer buffer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReadOnly>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buffer);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_GPUInstanceDataBuffer_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1071321, RefRangeEnd = 1071322, XrefRangeStart = 1071320, XrefRangeEnd = 1071321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GPUInstanceIndex CPUInstanceToGPUInstance(InstanceHandle instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&instance);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CPUInstanceToGPUInstance_Public_GPUInstanceIndex_InstanceHandle_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(GPUInstanceIndex*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1071326, RefRangeEnd = 1071327, XrefRangeStart = 1071322, XrefRangeEnd = 1071326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CPUInstanceArrayToGPUInstanceArray(NativeArray<InstanceHandle> instances, NativeArray<GPUInstanceIndex> gpuInstanceIndices)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)instances));
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)gpuInstanceIndices));
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CPUInstanceArrayToGPUInstanceArray_Public_Void_NativeArray_1_InstanceHandle_NativeArray_1_GPUInstanceIndex_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public ReadOnly(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public ReadOnly()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReadOnly>.NativeClassPtr))
		{
		}
	}

	public sealed class ConvertCPUInstancesToGPUInstancesJob : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_instancesNumPrefixSum;

		private static readonly System.IntPtr NativeFieldInfoPtr_instances;

		private static readonly System.IntPtr NativeFieldInfoPtr_gpuInstanceIndices;

		private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_0;

		public unsafe NativeArray<int> instancesNumPrefixSum
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_instancesNumPrefixSum);
				return new NativeArray<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_instancesNumPrefixSum), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, ref *(uint*)null));
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

		public unsafe NativeArray<GPUInstanceIndex> gpuInstanceIndices
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gpuInstanceIndices);
				return new NativeArray<GPUInstanceIndex>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<GPUInstanceIndex>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gpuInstanceIndices), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<GPUInstanceIndex>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		static ConvertCPUInstancesToGPUInstancesJob()
		{
			Il2CppClassPointerStore<ConvertCPUInstancesToGPUInstancesJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GPUInstanceDataBuffer>.NativeClassPtr, "ConvertCPUInstancesToGPUInstancesJob");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConvertCPUInstancesToGPUInstancesJob>.NativeClassPtr);
			NativeFieldInfoPtr_instancesNumPrefixSum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConvertCPUInstancesToGPUInstancesJob>.NativeClassPtr, "instancesNumPrefixSum");
			NativeFieldInfoPtr_instances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConvertCPUInstancesToGPUInstancesJob>.NativeClassPtr, "instances");
			NativeFieldInfoPtr_gpuInstanceIndices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConvertCPUInstancesToGPUInstancesJob>.NativeClassPtr, "gpuInstanceIndices");
			NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConvertCPUInstancesToGPUInstancesJob>.NativeClassPtr, 100663687);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1071327, XrefRangeEnd = 1071328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Execute(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&index);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public ConvertCPUInstancesToGPUInstancesJob(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public ConvertCPUInstancesToGPUInstancesJob()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConvertCPUInstancesToGPUInstancesJob>.NativeClassPtr))
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_s_NextLayoutVersion;

	private static readonly System.IntPtr NativeFieldInfoPtr_instanceNumInfo;

	private static readonly System.IntPtr NativeFieldInfoPtr_instancesNumPrefixSum;

	private static readonly System.IntPtr NativeFieldInfoPtr_instancesSpan;

	private static readonly System.IntPtr NativeFieldInfoPtr_byteSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_perInstanceComponentCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_version;

	private static readonly System.IntPtr NativeFieldInfoPtr_layoutVersion;

	private static readonly System.IntPtr NativeFieldInfoPtr_gpuBuffer;

	private static readonly System.IntPtr NativeFieldInfoPtr_validComponentsIndicesGpuBuffer;

	private static readonly System.IntPtr NativeFieldInfoPtr_componentAddressesGpuBuffer;

	private static readonly System.IntPtr NativeFieldInfoPtr_componentInstanceIndexRangesGpuBuffer;

	private static readonly System.IntPtr NativeFieldInfoPtr_componentByteCountsGpuBuffer;

	private static readonly System.IntPtr NativeFieldInfoPtr_descriptions;

	private static readonly System.IntPtr NativeFieldInfoPtr_defaultMetadata;

	private static readonly System.IntPtr NativeFieldInfoPtr_gpuBufferComponentAddress;

	private static readonly System.IntPtr NativeFieldInfoPtr_nameToMetadataMap;

	private static readonly System.IntPtr NativeMethodInfoPtr_NextVersion_Public_Static_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CPUInstanceToGPUInstance_Private_Static_GPUInstanceIndex_byref_NativeArray_1_Int32_InstanceHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPropertyIndex_Public_Int32_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetGpuAddress_Public_Int32_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CPUInstanceArrayToGPUInstanceArray_Public_Void_NativeArray_1_InstanceHandle_NativeArray_1_GPUInstanceIndex_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AsReadOnly_Public_ReadOnly_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static int s_NextLayoutVersion
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_NextLayoutVersion, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_NextLayoutVersion, (void*)(&value));
		}
	}

	public unsafe InstanceNumInfo instanceNumInfo
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_instanceNumInfo);
			return *(InstanceNumInfo*)num;
		}
		set
		{
			*(InstanceNumInfo*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_instanceNumInfo)) = value;
		}
	}

	public unsafe NativeArray<int> instancesNumPrefixSum
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_instancesNumPrefixSum);
			return new NativeArray<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_instancesNumPrefixSum), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeArray<int> instancesSpan
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_instancesSpan);
			return new NativeArray<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_instancesSpan), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe int byteSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_byteSize);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_byteSize)) = value;
		}
	}

	public unsafe int perInstanceComponentCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_perInstanceComponentCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_perInstanceComponentCount)) = value;
		}
	}

	public unsafe int version
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_version);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_version)) = value;
		}
	}

	public unsafe int layoutVersion
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_layoutVersion);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_layoutVersion)) = value;
		}
	}

	public unsafe GraphicsBuffer gpuBuffer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gpuBuffer);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GraphicsBuffer>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gpuBuffer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe GraphicsBuffer validComponentsIndicesGpuBuffer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_validComponentsIndicesGpuBuffer);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GraphicsBuffer>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_validComponentsIndicesGpuBuffer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe GraphicsBuffer componentAddressesGpuBuffer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_componentAddressesGpuBuffer);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GraphicsBuffer>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_componentAddressesGpuBuffer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe GraphicsBuffer componentInstanceIndexRangesGpuBuffer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_componentInstanceIndexRangesGpuBuffer);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GraphicsBuffer>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_componentInstanceIndexRangesGpuBuffer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe GraphicsBuffer componentByteCountsGpuBuffer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_componentByteCountsGpuBuffer);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GraphicsBuffer>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_componentByteCountsGpuBuffer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe NativeArray<GPUInstanceComponentDesc> descriptions
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_descriptions);
			return new NativeArray<GPUInstanceComponentDesc>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<GPUInstanceComponentDesc>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_descriptions), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<GPUInstanceComponentDesc>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeArray<MetadataValue> defaultMetadata
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_defaultMetadata);
			return new NativeArray<MetadataValue>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<MetadataValue>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_defaultMetadata), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<MetadataValue>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeArray<int> gpuBufferComponentAddress
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gpuBufferComponentAddress);
			return new NativeArray<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gpuBufferComponentAddress), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeParallelHashMap<int, int> nameToMetadataMap
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nameToMetadataMap);
			return new NativeParallelHashMap<int, int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeParallelHashMap<int, int>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nameToMetadataMap), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeParallelHashMap<int, int>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	static GPUInstanceDataBuffer()
	{
		Il2CppClassPointerStore<GPUInstanceDataBuffer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.GPUDriven.Runtime.dll", "UnityEngine.Rendering", "GPUInstanceDataBuffer");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GPUInstanceDataBuffer>.NativeClassPtr);
		NativeFieldInfoPtr_s_NextLayoutVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUInstanceDataBuffer>.NativeClassPtr, "s_NextLayoutVersion");
		NativeFieldInfoPtr_instanceNumInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUInstanceDataBuffer>.NativeClassPtr, "instanceNumInfo");
		NativeFieldInfoPtr_instancesNumPrefixSum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUInstanceDataBuffer>.NativeClassPtr, "instancesNumPrefixSum");
		NativeFieldInfoPtr_instancesSpan = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUInstanceDataBuffer>.NativeClassPtr, "instancesSpan");
		NativeFieldInfoPtr_byteSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUInstanceDataBuffer>.NativeClassPtr, "byteSize");
		NativeFieldInfoPtr_perInstanceComponentCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUInstanceDataBuffer>.NativeClassPtr, "perInstanceComponentCount");
		NativeFieldInfoPtr_version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUInstanceDataBuffer>.NativeClassPtr, "version");
		NativeFieldInfoPtr_layoutVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUInstanceDataBuffer>.NativeClassPtr, "layoutVersion");
		NativeFieldInfoPtr_gpuBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUInstanceDataBuffer>.NativeClassPtr, "gpuBuffer");
		NativeFieldInfoPtr_validComponentsIndicesGpuBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUInstanceDataBuffer>.NativeClassPtr, "validComponentsIndicesGpuBuffer");
		NativeFieldInfoPtr_componentAddressesGpuBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUInstanceDataBuffer>.NativeClassPtr, "componentAddressesGpuBuffer");
		NativeFieldInfoPtr_componentInstanceIndexRangesGpuBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUInstanceDataBuffer>.NativeClassPtr, "componentInstanceIndexRangesGpuBuffer");
		NativeFieldInfoPtr_componentByteCountsGpuBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUInstanceDataBuffer>.NativeClassPtr, "componentByteCountsGpuBuffer");
		NativeFieldInfoPtr_descriptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUInstanceDataBuffer>.NativeClassPtr, "descriptions");
		NativeFieldInfoPtr_defaultMetadata = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUInstanceDataBuffer>.NativeClassPtr, "defaultMetadata");
		NativeFieldInfoPtr_gpuBufferComponentAddress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUInstanceDataBuffer>.NativeClassPtr, "gpuBufferComponentAddress");
		NativeFieldInfoPtr_nameToMetadataMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUInstanceDataBuffer>.NativeClassPtr, "nameToMetadataMap");
		NativeMethodInfoPtr_NextVersion_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUInstanceDataBuffer>.NativeClassPtr, 100663676);
		NativeMethodInfoPtr_CPUInstanceToGPUInstance_Private_Static_GPUInstanceIndex_byref_NativeArray_1_Int32_InstanceHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUInstanceDataBuffer>.NativeClassPtr, 100663677);
		NativeMethodInfoPtr_GetPropertyIndex_Public_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUInstanceDataBuffer>.NativeClassPtr, 100663678);
		NativeMethodInfoPtr_GetGpuAddress_Public_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUInstanceDataBuffer>.NativeClassPtr, 100663679);
		NativeMethodInfoPtr_CPUInstanceArrayToGPUInstanceArray_Public_Void_NativeArray_1_InstanceHandle_NativeArray_1_GPUInstanceIndex_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUInstanceDataBuffer>.NativeClassPtr, 100663680);
		NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUInstanceDataBuffer>.NativeClassPtr, 100663681);
		NativeMethodInfoPtr_AsReadOnly_Public_ReadOnly_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUInstanceDataBuffer>.NativeClassPtr, 100663682);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUInstanceDataBuffer>.NativeClassPtr, 100663683);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1071328, XrefRangeEnd = 1071330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int NextVersion()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NextVersion_Public_Static_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1071352, RefRangeEnd = 1071354, XrefRangeStart = 1071330, XrefRangeEnd = 1071352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static GPUInstanceIndex CPUInstanceToGPUInstance([In] ref NativeArray<int> instancesNumPrefixSum, InstanceHandle instance)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)instancesNumPrefixSum);
		*(InstanceHandle**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &instance;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CPUInstanceToGPUInstance_Private_Static_GPUInstanceIndex_byref_NativeArray_1_Int32_InstanceHandle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(GPUInstanceIndex*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 1071357, RefRangeEnd = 1071366, XrefRangeStart = 1071354, XrefRangeEnd = 1071357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetPropertyIndex(int propertyID, bool assertOnFail = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&propertyID);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &assertOnFail;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPropertyIndex_Public_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 1071369, RefRangeEnd = 1071378, XrefRangeStart = 1071366, XrefRangeEnd = 1071369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetGpuAddress(int propertyID, bool assertOnFail = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&propertyID);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &assertOnFail;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetGpuAddress_Public_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1071378, XrefRangeEnd = 1071382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CPUInstanceArrayToGPUInstanceArray(NativeArray<InstanceHandle> instances, NativeArray<GPUInstanceIndex> gpuInstanceIndices)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)instances));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)gpuInstanceIndices));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CPUInstanceArrayToGPUInstanceArray_Public_Void_NativeArray_1_InstanceHandle_NativeArray_1_GPUInstanceIndex_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1071409, RefRangeEnd = 1071411, XrefRangeStart = 1071382, XrefRangeEnd = 1071409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Dispose()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1071411, RefRangeEnd = 1071412, XrefRangeStart = 1071411, XrefRangeEnd = 1071411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ReadOnly AsReadOnly()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AsReadOnly_Public_ReadOnly_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new ReadOnly(pointer);
	}

	[CallerCount(1950)]
	[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GPUInstanceDataBuffer()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GPUInstanceDataBuffer>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public GPUInstanceDataBuffer(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
