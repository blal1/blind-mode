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
using Unity.Jobs;

namespace UnityEngine.Rendering;

public sealed class GPUInstanceDataBufferUploader : Il2CppSystem.ValueType
{
	public static class UploadKernelIDs : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr__InputValidComponentCounts;

		private static readonly System.IntPtr NativeFieldInfoPtr__InputInstanceCounts;

		private static readonly System.IntPtr NativeFieldInfoPtr__InputInstanceByteSize;

		private static readonly System.IntPtr NativeFieldInfoPtr__InputComponentOffsets;

		private static readonly System.IntPtr NativeFieldInfoPtr__InputInstanceData;

		private static readonly System.IntPtr NativeFieldInfoPtr__InputInstanceIndices;

		private static readonly System.IntPtr NativeFieldInfoPtr__InputValidComponentIndices;

		private static readonly System.IntPtr NativeFieldInfoPtr__InputComponentAddresses;

		private static readonly System.IntPtr NativeFieldInfoPtr__InputComponentByteCounts;

		private static readonly System.IntPtr NativeFieldInfoPtr__InputComponentInstanceIndexRanges;

		private static readonly System.IntPtr NativeFieldInfoPtr__OutputBuffer;

		public unsafe static int _InputValidComponentCounts
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__InputValidComponentCounts, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__InputValidComponentCounts, (void*)(&value));
			}
		}

		public unsafe static int _InputInstanceCounts
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__InputInstanceCounts, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__InputInstanceCounts, (void*)(&value));
			}
		}

		public unsafe static int _InputInstanceByteSize
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__InputInstanceByteSize, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__InputInstanceByteSize, (void*)(&value));
			}
		}

		public unsafe static int _InputComponentOffsets
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__InputComponentOffsets, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__InputComponentOffsets, (void*)(&value));
			}
		}

		public unsafe static int _InputInstanceData
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__InputInstanceData, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__InputInstanceData, (void*)(&value));
			}
		}

		public unsafe static int _InputInstanceIndices
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__InputInstanceIndices, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__InputInstanceIndices, (void*)(&value));
			}
		}

		public unsafe static int _InputValidComponentIndices
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__InputValidComponentIndices, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__InputValidComponentIndices, (void*)(&value));
			}
		}

		public unsafe static int _InputComponentAddresses
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__InputComponentAddresses, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__InputComponentAddresses, (void*)(&value));
			}
		}

		public unsafe static int _InputComponentByteCounts
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__InputComponentByteCounts, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__InputComponentByteCounts, (void*)(&value));
			}
		}

		public unsafe static int _InputComponentInstanceIndexRanges
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__InputComponentInstanceIndexRanges, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__InputComponentInstanceIndexRanges, (void*)(&value));
			}
		}

		public unsafe static int _OutputBuffer
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__OutputBuffer, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__OutputBuffer, (void*)(&value));
			}
		}

		static UploadKernelIDs()
		{
			Il2CppClassPointerStore<UploadKernelIDs>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GPUInstanceDataBufferUploader>.NativeClassPtr, "UploadKernelIDs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UploadKernelIDs>.NativeClassPtr);
			NativeFieldInfoPtr__InputValidComponentCounts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UploadKernelIDs>.NativeClassPtr, "_InputValidComponentCounts");
			NativeFieldInfoPtr__InputInstanceCounts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UploadKernelIDs>.NativeClassPtr, "_InputInstanceCounts");
			NativeFieldInfoPtr__InputInstanceByteSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UploadKernelIDs>.NativeClassPtr, "_InputInstanceByteSize");
			NativeFieldInfoPtr__InputComponentOffsets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UploadKernelIDs>.NativeClassPtr, "_InputComponentOffsets");
			NativeFieldInfoPtr__InputInstanceData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UploadKernelIDs>.NativeClassPtr, "_InputInstanceData");
			NativeFieldInfoPtr__InputInstanceIndices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UploadKernelIDs>.NativeClassPtr, "_InputInstanceIndices");
			NativeFieldInfoPtr__InputValidComponentIndices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UploadKernelIDs>.NativeClassPtr, "_InputValidComponentIndices");
			NativeFieldInfoPtr__InputComponentAddresses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UploadKernelIDs>.NativeClassPtr, "_InputComponentAddresses");
			NativeFieldInfoPtr__InputComponentByteCounts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UploadKernelIDs>.NativeClassPtr, "_InputComponentByteCounts");
			NativeFieldInfoPtr__InputComponentInstanceIndexRanges = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UploadKernelIDs>.NativeClassPtr, "_InputComponentInstanceIndexRanges");
			NativeFieldInfoPtr__OutputBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UploadKernelIDs>.NativeClassPtr, "_OutputBuffer");
		}

		public UploadKernelIDs(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public sealed class GPUResources : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_instanceData;

		private static readonly System.IntPtr NativeFieldInfoPtr_instanceIndices;

		private static readonly System.IntPtr NativeFieldInfoPtr_inputComponentOffsets;

		private static readonly System.IntPtr NativeFieldInfoPtr_validComponentIndices;

		private static readonly System.IntPtr NativeFieldInfoPtr_cs;

		private static readonly System.IntPtr NativeFieldInfoPtr_kernelId;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_InstanceDataByteSize;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_InstanceCount;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_ComponentCounts;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_ValidComponentIndicesCount;

		private static readonly System.IntPtr NativeMethodInfoPtr_LoadShaders_Public_Void_GPUResidentDrawerResources_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_CreateResources_Public_Void_Int32_Int32_Int32_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		public unsafe ComputeBuffer instanceData
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_instanceData);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ComputeBuffer>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_instanceData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe ComputeBuffer instanceIndices
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_instanceIndices);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ComputeBuffer>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_instanceIndices)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe ComputeBuffer inputComponentOffsets
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inputComponentOffsets);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ComputeBuffer>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inputComponentOffsets)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe ComputeBuffer validComponentIndices
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_validComponentIndices);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ComputeBuffer>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_validComponentIndices)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe ComputeShader cs
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cs);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ComputeShader>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cs)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe int kernelId
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_kernelId);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_kernelId)) = value;
			}
		}

		public unsafe int m_InstanceDataByteSize
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_InstanceDataByteSize);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_InstanceDataByteSize)) = value;
			}
		}

		public unsafe int m_InstanceCount
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_InstanceCount);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_InstanceCount)) = value;
			}
		}

		public unsafe int m_ComponentCounts
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ComponentCounts);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ComponentCounts)) = value;
			}
		}

		public unsafe int m_ValidComponentIndicesCount
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ValidComponentIndicesCount);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ValidComponentIndicesCount)) = value;
			}
		}

		static GPUResources()
		{
			Il2CppClassPointerStore<GPUResources>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GPUInstanceDataBufferUploader>.NativeClassPtr, "GPUResources");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GPUResources>.NativeClassPtr);
			NativeFieldInfoPtr_instanceData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUResources>.NativeClassPtr, "instanceData");
			NativeFieldInfoPtr_instanceIndices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUResources>.NativeClassPtr, "instanceIndices");
			NativeFieldInfoPtr_inputComponentOffsets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUResources>.NativeClassPtr, "inputComponentOffsets");
			NativeFieldInfoPtr_validComponentIndices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUResources>.NativeClassPtr, "validComponentIndices");
			NativeFieldInfoPtr_cs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUResources>.NativeClassPtr, "cs");
			NativeFieldInfoPtr_kernelId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUResources>.NativeClassPtr, "kernelId");
			NativeFieldInfoPtr_m_InstanceDataByteSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUResources>.NativeClassPtr, "m_InstanceDataByteSize");
			NativeFieldInfoPtr_m_InstanceCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUResources>.NativeClassPtr, "m_InstanceCount");
			NativeFieldInfoPtr_m_ComponentCounts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUResources>.NativeClassPtr, "m_ComponentCounts");
			NativeFieldInfoPtr_m_ValidComponentIndicesCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUResources>.NativeClassPtr, "m_ValidComponentIndicesCount");
			NativeMethodInfoPtr_LoadShaders_Public_Void_GPUResidentDrawerResources_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUResources>.NativeClassPtr, 100663704);
			NativeMethodInfoPtr_CreateResources_Public_Void_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUResources>.NativeClassPtr, 100663705);
			NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUResources>.NativeClassPtr, 100663706);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1071564, RefRangeEnd = 1071565, XrefRangeStart = 1071556, XrefRangeEnd = 1071564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadShaders(GPUResidentDrawerResources resources)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)resources);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadShaders_Public_Void_GPUResidentDrawerResources_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1071587, RefRangeEnd = 1071588, XrefRangeStart = 1071565, XrefRangeEnd = 1071587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateResources(int newInstanceCount, int sizePerInstance, int newComponentCounts, int validComponentIndicesCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[4];
			*ptr = (nint)(&newInstanceCount);
			*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &sizePerInstance;
			*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &newComponentCounts;
			*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &validComponentIndicesCount;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateResources_Public_Void_Int32_Int32_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1071593, RefRangeEnd = 1071594, XrefRangeStart = 1071588, XrefRangeEnd = 1071593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public GPUResources(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public GPUResources()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GPUResources>.NativeClassPtr))
		{
		}
	}

	public sealed class WriteInstanceDataParameterJob : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_gatherData;

		private static readonly System.IntPtr NativeFieldInfoPtr_parameterIndex;

		private static readonly System.IntPtr NativeFieldInfoPtr_uintPerParameter;

		private static readonly System.IntPtr NativeFieldInfoPtr_uintPerInstance;

		private static readonly System.IntPtr NativeFieldInfoPtr_componentDataIndex;

		private static readonly System.IntPtr NativeFieldInfoPtr_gatherIndices;

		private static readonly System.IntPtr NativeFieldInfoPtr_instanceData;

		private static readonly System.IntPtr NativeFieldInfoPtr_tmpDataBuffer;

		private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_0;

		public unsafe bool gatherData
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gatherData);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gatherData)) = value;
			}
		}

		public unsafe int parameterIndex
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_parameterIndex);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_parameterIndex)) = value;
			}
		}

		public unsafe int uintPerParameter
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_uintPerParameter);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_uintPerParameter)) = value;
			}
		}

		public unsafe int uintPerInstance
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_uintPerInstance);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_uintPerInstance)) = value;
			}
		}

		public unsafe NativeArray<int> componentDataIndex
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_componentDataIndex);
				return new NativeArray<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_componentDataIndex), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe NativeArray<int> gatherIndices
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gatherIndices);
				return new NativeArray<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gatherIndices), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe NativeArray<uint> instanceData
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_instanceData);
				return new NativeArray<uint>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<uint>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_instanceData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<uint>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe NativeArray<uint> tmpDataBuffer
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tmpDataBuffer);
				return new NativeArray<uint>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<uint>>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tmpDataBuffer), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<uint>>.NativeClassPtr, ref *(uint*)null));
			}
		}

		static WriteInstanceDataParameterJob()
		{
			Il2CppClassPointerStore<WriteInstanceDataParameterJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GPUInstanceDataBufferUploader>.NativeClassPtr, "WriteInstanceDataParameterJob");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WriteInstanceDataParameterJob>.NativeClassPtr);
			NativeFieldInfoPtr_gatherData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WriteInstanceDataParameterJob>.NativeClassPtr, "gatherData");
			NativeFieldInfoPtr_parameterIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WriteInstanceDataParameterJob>.NativeClassPtr, "parameterIndex");
			NativeFieldInfoPtr_uintPerParameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WriteInstanceDataParameterJob>.NativeClassPtr, "uintPerParameter");
			NativeFieldInfoPtr_uintPerInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WriteInstanceDataParameterJob>.NativeClassPtr, "uintPerInstance");
			NativeFieldInfoPtr_componentDataIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WriteInstanceDataParameterJob>.NativeClassPtr, "componentDataIndex");
			NativeFieldInfoPtr_gatherIndices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WriteInstanceDataParameterJob>.NativeClassPtr, "gatherIndices");
			NativeFieldInfoPtr_instanceData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WriteInstanceDataParameterJob>.NativeClassPtr, "instanceData");
			NativeFieldInfoPtr_tmpDataBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WriteInstanceDataParameterJob>.NativeClassPtr, "tmpDataBuffer");
			NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WriteInstanceDataParameterJob>.NativeClassPtr, 100663707);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1071594, XrefRangeEnd = 1071634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Execute(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&index);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public WriteInstanceDataParameterJob(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public WriteInstanceDataParameterJob()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WriteInstanceDataParameterJob>.NativeClassPtr))
		{
		}
	}

	private sealed class MethodInfoStoreGeneric_PrepareParamWrite_Public_Int32_Int32_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_PrepareParamWrite_Public_Int32_Int32_0, Il2CppClassPointerStore<GPUInstanceDataBufferUploader>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_WriteInstanceDataJob_Public_JobHandle_Int32_NativeArray_1_T_NativeArray_1_Int32_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_WriteInstanceDataJob_Public_JobHandle_Int32_NativeArray_1_T_NativeArray_1_Int32_0, Il2CppClassPointerStore<GPUInstanceDataBufferUploader>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_m_UintPerInstance;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Capacity;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_InstanceCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ComponentIsInstanced;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ComponentDataIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_DescriptionsUintSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_TmpDataBuffer;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_WritenComponentIndices;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_DummyArray;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_byref_NativeArray_1_GPUInstanceComponentDesc_Int32_InstanceType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetUploadBufferPtr_Public_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetUIntPerInstance_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetParamUIntOffset_Public_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PrepareParamWrite_Public_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AllocateUploadHandles_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WriteInstanceDataJob_Public_JobHandle_Int32_NativeArray_1_T_NativeArray_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SubmitToGpu_Public_Void_GPUInstanceDataBuffer_NativeArray_1_GPUInstanceIndex_byref_GPUResources_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SubmitToGpu_Public_Void_GPUInstanceDataBuffer_NativeArray_1_InstanceHandle_byref_GPUResources_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

	public unsafe int m_UintPerInstance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_UintPerInstance);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_UintPerInstance)) = value;
		}
	}

	public unsafe int m_Capacity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Capacity);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Capacity)) = value;
		}
	}

	public unsafe int m_InstanceCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_InstanceCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_InstanceCount)) = value;
		}
	}

	public unsafe NativeArray<bool> m_ComponentIsInstanced
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ComponentIsInstanced);
			return new NativeArray<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<bool>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ComponentIsInstanced), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<bool>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeArray<int> m_ComponentDataIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ComponentDataIndex);
			return new NativeArray<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ComponentDataIndex), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeArray<int> m_DescriptionsUintSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DescriptionsUintSize);
			return new NativeArray<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DescriptionsUintSize), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeArray<uint> m_TmpDataBuffer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TmpDataBuffer);
			return new NativeArray<uint>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<uint>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TmpDataBuffer), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<uint>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeList<int> m_WritenComponentIndices
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_WritenComponentIndices);
			return new NativeList<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeList<int>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_WritenComponentIndices), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<int>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeArray<int> m_DummyArray
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DummyArray);
			return new NativeArray<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DummyArray), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	static GPUInstanceDataBufferUploader()
	{
		Il2CppClassPointerStore<GPUInstanceDataBufferUploader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.GPUDriven.Runtime.dll", "UnityEngine.Rendering", "GPUInstanceDataBufferUploader");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GPUInstanceDataBufferUploader>.NativeClassPtr);
		NativeFieldInfoPtr_m_UintPerInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUInstanceDataBufferUploader>.NativeClassPtr, "m_UintPerInstance");
		NativeFieldInfoPtr_m_Capacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUInstanceDataBufferUploader>.NativeClassPtr, "m_Capacity");
		NativeFieldInfoPtr_m_InstanceCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUInstanceDataBufferUploader>.NativeClassPtr, "m_InstanceCount");
		NativeFieldInfoPtr_m_ComponentIsInstanced = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUInstanceDataBufferUploader>.NativeClassPtr, "m_ComponentIsInstanced");
		NativeFieldInfoPtr_m_ComponentDataIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUInstanceDataBufferUploader>.NativeClassPtr, "m_ComponentDataIndex");
		NativeFieldInfoPtr_m_DescriptionsUintSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUInstanceDataBufferUploader>.NativeClassPtr, "m_DescriptionsUintSize");
		NativeFieldInfoPtr_m_TmpDataBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUInstanceDataBufferUploader>.NativeClassPtr, "m_TmpDataBuffer");
		NativeFieldInfoPtr_m_WritenComponentIndices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUInstanceDataBufferUploader>.NativeClassPtr, "m_WritenComponentIndices");
		NativeFieldInfoPtr_m_DummyArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUInstanceDataBufferUploader>.NativeClassPtr, "m_DummyArray");
		NativeMethodInfoPtr__ctor_Public_Void_byref_NativeArray_1_GPUInstanceComponentDesc_Int32_InstanceType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUInstanceDataBufferUploader>.NativeClassPtr, 100663693);
		NativeMethodInfoPtr_GetUploadBufferPtr_Public_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUInstanceDataBufferUploader>.NativeClassPtr, 100663694);
		NativeMethodInfoPtr_GetUIntPerInstance_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUInstanceDataBufferUploader>.NativeClassPtr, 100663695);
		NativeMethodInfoPtr_GetParamUIntOffset_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUInstanceDataBufferUploader>.NativeClassPtr, 100663696);
		NativeMethodInfoPtr_PrepareParamWrite_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUInstanceDataBufferUploader>.NativeClassPtr, 100663697);
		NativeMethodInfoPtr_AllocateUploadHandles_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUInstanceDataBufferUploader>.NativeClassPtr, 100663698);
		NativeMethodInfoPtr_WriteInstanceDataJob_Public_JobHandle_Int32_NativeArray_1_T_NativeArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUInstanceDataBufferUploader>.NativeClassPtr, 100663699);
		NativeMethodInfoPtr_SubmitToGpu_Public_Void_GPUInstanceDataBuffer_NativeArray_1_GPUInstanceIndex_byref_GPUResources_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUInstanceDataBufferUploader>.NativeClassPtr, 100663700);
		NativeMethodInfoPtr_SubmitToGpu_Public_Void_GPUInstanceDataBuffer_NativeArray_1_InstanceHandle_byref_GPUResources_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUInstanceDataBufferUploader>.NativeClassPtr, 100663701);
		NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUInstanceDataBufferUploader>.NativeClassPtr, 100663702);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1071654, RefRangeEnd = 1071655, XrefRangeStart = 1071634, XrefRangeEnd = 1071654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GPUInstanceDataBufferUploader([In] ref NativeArray<GPUInstanceComponentDesc> descriptions, int capacity, InstanceType instanceType)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GPUInstanceDataBufferUploader>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)descriptions);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &capacity;
		*(InstanceType**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &instanceType;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_byref_NativeArray_1_GPUInstanceComponentDesc_Int32_InstanceType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1071658, RefRangeEnd = 1071659, XrefRangeStart = 1071655, XrefRangeEnd = 1071658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe System.IntPtr GetUploadBufferPtr()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetUploadBufferPtr_Public_IntPtr_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(175)]
	[CachedScanResults(RefRangeStart = 52464, RefRangeEnd = 52639, XrefRangeStart = 52464, XrefRangeEnd = 52639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetUIntPerInstance()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetUIntPerInstance_Public_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1071659, RefRangeEnd = 1071664, XrefRangeStart = 1071659, XrefRangeEnd = 1071659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetParamUIntOffset(int parameterIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&parameterIndex);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetParamUIntOffset_Public_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1071673, RefRangeEnd = 1071674, XrefRangeStart = 1071664, XrefRangeEnd = 1071673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int PrepareParamWrite<T>(int parameterIndex) where T : new()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&parameterIndex);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_PrepareParamWrite_Public_Int32_Int32_0<T>.Pointer, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 765810, RefRangeEnd = 765814, XrefRangeStart = 765810, XrefRangeEnd = 765814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AllocateUploadHandles(int handlesLength)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&handlesLength);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AllocateUploadHandles_Public_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1071687, RefRangeEnd = 1071688, XrefRangeStart = 1071674, XrefRangeEnd = 1071687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe JobHandle WriteInstanceDataJob<T>(int parameterIndex, NativeArray<T> instanceData, NativeArray<int> gatherIndices) where T : new()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&parameterIndex);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)instanceData));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)gatherIndices));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_WriteInstanceDataJob_Public_JobHandle_Int32_NativeArray_1_T_NativeArray_1_Int32_0<T>.Pointer, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(JobHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1071751, RefRangeEnd = 1071753, XrefRangeStart = 1071688, XrefRangeEnd = 1071751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SubmitToGpu(GPUInstanceDataBuffer instanceDataBuffer, NativeArray<GPUInstanceIndex> gpuInstanceIndices, ref GPUResources gpuResources, bool submitOnlyWrittenParams)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)instanceDataBuffer);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)gpuInstanceIndices));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)gpuResources);
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &submitOnlyWrittenParams;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SubmitToGpu_Public_Void_GPUInstanceDataBuffer_NativeArray_1_GPUInstanceIndex_byref_GPUResources_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1071764, RefRangeEnd = 1071765, XrefRangeStart = 1071753, XrefRangeEnd = 1071764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SubmitToGpu(GPUInstanceDataBuffer instanceDataBuffer, NativeArray<InstanceHandle> instances, ref GPUResources gpuResources, bool submitOnlyWrittenParams)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)instanceDataBuffer);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)instances));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)gpuResources);
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &submitOnlyWrittenParams;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SubmitToGpu_Public_Void_GPUInstanceDataBuffer_NativeArray_1_InstanceHandle_byref_GPUResources_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1071785, RefRangeEnd = 1071787, XrefRangeStart = 1071765, XrefRangeEnd = 1071785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Dispose()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public GPUInstanceDataBufferUploader(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public GPUInstanceDataBufferUploader()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GPUInstanceDataBufferUploader>.NativeClassPtr))
	{
	}
}
