using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering;

public sealed class GPUInstanceDataBufferGrower : Il2CppSystem.ValueType
{
	public static class CopyInstancesKernelIDs : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr__InputValidComponentCounts;

		private static readonly System.IntPtr NativeFieldInfoPtr__InstanceCounts;

		private static readonly System.IntPtr NativeFieldInfoPtr__InstanceOffset;

		private static readonly System.IntPtr NativeFieldInfoPtr__OutputInstanceOffset;

		private static readonly System.IntPtr NativeFieldInfoPtr__ValidComponentIndices;

		private static readonly System.IntPtr NativeFieldInfoPtr__ComponentByteCounts;

		private static readonly System.IntPtr NativeFieldInfoPtr__InputComponentAddresses;

		private static readonly System.IntPtr NativeFieldInfoPtr__OutputComponentAddresses;

		private static readonly System.IntPtr NativeFieldInfoPtr__InputComponentInstanceIndexRanges;

		private static readonly System.IntPtr NativeFieldInfoPtr__InputBuffer;

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

		public unsafe static int _InstanceCounts
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__InstanceCounts, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__InstanceCounts, (void*)(&value));
			}
		}

		public unsafe static int _InstanceOffset
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__InstanceOffset, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__InstanceOffset, (void*)(&value));
			}
		}

		public unsafe static int _OutputInstanceOffset
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__OutputInstanceOffset, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__OutputInstanceOffset, (void*)(&value));
			}
		}

		public unsafe static int _ValidComponentIndices
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__ValidComponentIndices, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__ValidComponentIndices, (void*)(&value));
			}
		}

		public unsafe static int _ComponentByteCounts
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__ComponentByteCounts, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__ComponentByteCounts, (void*)(&value));
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

		public unsafe static int _OutputComponentAddresses
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__OutputComponentAddresses, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__OutputComponentAddresses, (void*)(&value));
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

		public unsafe static int _InputBuffer
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__InputBuffer, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__InputBuffer, (void*)(&value));
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

		static CopyInstancesKernelIDs()
		{
			Il2CppClassPointerStore<CopyInstancesKernelIDs>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GPUInstanceDataBufferGrower>.NativeClassPtr, "CopyInstancesKernelIDs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CopyInstancesKernelIDs>.NativeClassPtr);
			NativeFieldInfoPtr__InputValidComponentCounts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyInstancesKernelIDs>.NativeClassPtr, "_InputValidComponentCounts");
			NativeFieldInfoPtr__InstanceCounts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyInstancesKernelIDs>.NativeClassPtr, "_InstanceCounts");
			NativeFieldInfoPtr__InstanceOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyInstancesKernelIDs>.NativeClassPtr, "_InstanceOffset");
			NativeFieldInfoPtr__OutputInstanceOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyInstancesKernelIDs>.NativeClassPtr, "_OutputInstanceOffset");
			NativeFieldInfoPtr__ValidComponentIndices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyInstancesKernelIDs>.NativeClassPtr, "_ValidComponentIndices");
			NativeFieldInfoPtr__ComponentByteCounts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyInstancesKernelIDs>.NativeClassPtr, "_ComponentByteCounts");
			NativeFieldInfoPtr__InputComponentAddresses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyInstancesKernelIDs>.NativeClassPtr, "_InputComponentAddresses");
			NativeFieldInfoPtr__OutputComponentAddresses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyInstancesKernelIDs>.NativeClassPtr, "_OutputComponentAddresses");
			NativeFieldInfoPtr__InputComponentInstanceIndexRanges = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyInstancesKernelIDs>.NativeClassPtr, "_InputComponentInstanceIndexRanges");
			NativeFieldInfoPtr__InputBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyInstancesKernelIDs>.NativeClassPtr, "_InputBuffer");
			NativeFieldInfoPtr__OutputBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyInstancesKernelIDs>.NativeClassPtr, "_OutputBuffer");
		}

		public CopyInstancesKernelIDs(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public sealed class GPUResources : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_cs;

		private static readonly System.IntPtr NativeFieldInfoPtr_kernelId;

		private static readonly System.IntPtr NativeMethodInfoPtr_LoadShaders_Public_Void_GPUResidentDrawerResources_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_CreateResources_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

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

		static GPUResources()
		{
			Il2CppClassPointerStore<GPUResources>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GPUInstanceDataBufferGrower>.NativeClassPtr, "GPUResources");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GPUResources>.NativeClassPtr);
			NativeFieldInfoPtr_cs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUResources>.NativeClassPtr, "cs");
			NativeFieldInfoPtr_kernelId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUResources>.NativeClassPtr, "kernelId");
			NativeMethodInfoPtr_LoadShaders_Public_Void_GPUResidentDrawerResources_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUResources>.NativeClassPtr, 100663712);
			NativeMethodInfoPtr_CreateResources_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUResources>.NativeClassPtr, 100663713);
			NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUResources>.NativeClassPtr, 100663714);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1071795, RefRangeEnd = 1071796, XrefRangeStart = 1071787, XrefRangeEnd = 1071795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadShaders(GPUResidentDrawerResources resources)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)resources);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadShaders_Public_Void_GPUResidentDrawerResources_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(19883)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 20035, XrefRangeStart = 152, XrefRangeEnd = 20035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateResources()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateResources_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(51)]
		[CachedScanResults(RefRangeStart = 843220, RefRangeEnd = 843271, XrefRangeStart = 843220, XrefRangeEnd = 843271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	private static readonly System.IntPtr NativeFieldInfoPtr_m_SrcBuffer;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_DstBuffer;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_GPUInstanceDataBuffer_byref_InstanceNumInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SubmitToGpu_Public_GPUInstanceDataBuffer_byref_GPUResources_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

	public unsafe GPUInstanceDataBuffer m_SrcBuffer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SrcBuffer);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GPUInstanceDataBuffer>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SrcBuffer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe GPUInstanceDataBuffer m_DstBuffer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DstBuffer);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GPUInstanceDataBuffer>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DstBuffer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static GPUInstanceDataBufferGrower()
	{
		Il2CppClassPointerStore<GPUInstanceDataBufferGrower>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.GPUDriven.Runtime.dll", "UnityEngine.Rendering", "GPUInstanceDataBufferGrower");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GPUInstanceDataBufferGrower>.NativeClassPtr);
		NativeFieldInfoPtr_m_SrcBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUInstanceDataBufferGrower>.NativeClassPtr, "m_SrcBuffer");
		NativeFieldInfoPtr_m_DstBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUInstanceDataBufferGrower>.NativeClassPtr, "m_DstBuffer");
		NativeMethodInfoPtr__ctor_Public_Void_GPUInstanceDataBuffer_byref_InstanceNumInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUInstanceDataBufferGrower>.NativeClassPtr, 100663708);
		NativeMethodInfoPtr_SubmitToGpu_Public_GPUInstanceDataBuffer_byref_GPUResources_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUInstanceDataBufferGrower>.NativeClassPtr, 100663709);
		NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUInstanceDataBufferGrower>.NativeClassPtr, 100663710);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1071819, RefRangeEnd = 1071820, XrefRangeStart = 1071796, XrefRangeEnd = 1071819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GPUInstanceDataBufferGrower(GPUInstanceDataBuffer sourceBuffer, [In] ref InstanceNumInfo instanceNumInfo)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GPUInstanceDataBufferGrower>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sourceBuffer);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref instanceNumInfo);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_GPUInstanceDataBuffer_byref_InstanceNumInfo_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1071850, RefRangeEnd = 1071851, XrefRangeStart = 1071820, XrefRangeEnd = 1071850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GPUInstanceDataBuffer SubmitToGpu(ref GPUResources gpuResources)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)gpuResources);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SubmitToGpu_Public_GPUInstanceDataBuffer_byref_GPUResources_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<GPUInstanceDataBuffer>(intPtr2) : null;
	}

	[CallerCount(19883)]
	[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 20035, XrefRangeStart = 152, XrefRangeEnd = 20035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Dispose()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public GPUInstanceDataBufferGrower(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public GPUInstanceDataBufferGrower()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GPUInstanceDataBufferGrower>.NativeClassPtr))
	{
	}
}
