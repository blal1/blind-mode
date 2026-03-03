using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering;

public sealed class GPUSort : Il2CppSystem.ValueType
{
	[OriginalName("Unity.RenderPipelines.Core.Runtime.dll", "", "Stage")]
	public enum Stage
	{
		LocalBMS,
		LocalDisperse,
		BigFlip,
		BigDisperse
	}

	public sealed class Args : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_count;

		private static readonly System.IntPtr NativeFieldInfoPtr_maxDepth;

		private static readonly System.IntPtr NativeFieldInfoPtr_inputKeys;

		private static readonly System.IntPtr NativeFieldInfoPtr_inputValues;

		private static readonly System.IntPtr NativeFieldInfoPtr_resources;

		private static readonly System.IntPtr NativeFieldInfoPtr_workGroupCount;

		public unsafe uint count
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_count);
				return *(uint*)num;
			}
			set
			{
				*(uint*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_count)) = value;
			}
		}

		public unsafe uint maxDepth
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxDepth);
				return *(uint*)num;
			}
			set
			{
				*(uint*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxDepth)) = value;
			}
		}

		public unsafe GraphicsBuffer inputKeys
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inputKeys);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GraphicsBuffer>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inputKeys)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe GraphicsBuffer inputValues
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inputValues);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GraphicsBuffer>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inputValues)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe SupportResources resources
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resources);
				return new SupportResources(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SupportResources>.NativeClassPtr, (System.IntPtr)num));
			}
			set
			{
				// IL cpblk instruction
				Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resources), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SupportResources>.NativeClassPtr, ref *(uint*)null));
			}
		}

		public unsafe int workGroupCount
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_workGroupCount);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_workGroupCount)) = value;
			}
		}

		static Args()
		{
			Il2CppClassPointerStore<Args>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GPUSort>.NativeClassPtr, "Args");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Args>.NativeClassPtr);
			NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Args>.NativeClassPtr, "count");
			NativeFieldInfoPtr_maxDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Args>.NativeClassPtr, "maxDepth");
			NativeFieldInfoPtr_inputKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Args>.NativeClassPtr, "inputKeys");
			NativeFieldInfoPtr_inputValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Args>.NativeClassPtr, "inputValues");
			NativeFieldInfoPtr_resources = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Args>.NativeClassPtr, "resources");
			NativeFieldInfoPtr_workGroupCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Args>.NativeClassPtr, "workGroupCount");
		}

		public Args(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public Args()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Args>.NativeClassPtr))
		{
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct RenderGraphResources
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_sortBufferKeys;

		private static readonly System.IntPtr NativeFieldInfoPtr_sortBufferValues;

		private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Static_RenderGraphResources_Int32_RenderGraph_RenderGraphBuilder_0;

		[FieldOffset(0)]
		public BufferHandle sortBufferKeys;

		[FieldOffset(12)]
		public BufferHandle sortBufferValues;

		static RenderGraphResources()
		{
			Il2CppClassPointerStore<RenderGraphResources>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GPUSort>.NativeClassPtr, "RenderGraphResources");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderGraphResources>.NativeClassPtr);
			NativeFieldInfoPtr_sortBufferKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphResources>.NativeClassPtr, "sortBufferKeys");
			NativeFieldInfoPtr_sortBufferValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderGraphResources>.NativeClassPtr, "sortBufferValues");
			NativeMethodInfoPtr_Create_Public_Static_RenderGraphResources_Int32_RenderGraph_RenderGraphBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderGraphResources>.NativeClassPtr, 100666709);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1052957, XrefRangeEnd = 1052967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RenderGraphResources Create(int count, RenderGraph renderGraph, RenderGraphBuilder builder)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[3];
			*ptr = (nint)(&count);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderGraph);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)builder));
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Create_Public_Static_RenderGraphResources_Int32_RenderGraph_RenderGraphBuilder_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(RenderGraphResources*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RenderGraphResources>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	public sealed class SupportResources : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_sortBufferKeys;

		private static readonly System.IntPtr NativeFieldInfoPtr_sortBufferValues;

		private static readonly System.IntPtr NativeMethodInfoPtr_Load_Public_Static_SupportResources_RenderGraphResources_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Void_0;

		public unsafe GraphicsBuffer sortBufferKeys
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sortBufferKeys);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GraphicsBuffer>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sortBufferKeys)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe GraphicsBuffer sortBufferValues
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sortBufferValues);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GraphicsBuffer>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sortBufferValues)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		static SupportResources()
		{
			Il2CppClassPointerStore<SupportResources>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GPUSort>.NativeClassPtr, "SupportResources");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SupportResources>.NativeClassPtr);
			NativeFieldInfoPtr_sortBufferKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportResources>.NativeClassPtr, "sortBufferKeys");
			NativeFieldInfoPtr_sortBufferValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupportResources>.NativeClassPtr, "sortBufferValues");
			NativeMethodInfoPtr_Load_Public_Static_SupportResources_RenderGraphResources_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportResources>.NativeClassPtr, 100666710);
			NativeMethodInfoPtr_Dispose_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupportResources>.NativeClassPtr, 100666711);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1052967, XrefRangeEnd = 1052974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SupportResources Load(RenderGraphResources renderGraphResources)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&renderGraphResources);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Load_Public_Static_SupportResources_RenderGraphResources_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new SupportResources(pointer);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1052974, XrefRangeEnd = 1052978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dispose_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public SupportResources(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public SupportResources()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SupportResources>.NativeClassPtr))
		{
		}
	}

	public sealed class SystemResources : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_computeAsset;

		public unsafe ComputeShader computeAsset
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_computeAsset);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ComputeShader>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_computeAsset)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		static SystemResources()
		{
			Il2CppClassPointerStore<SystemResources>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GPUSort>.NativeClassPtr, "SystemResources");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SystemResources>.NativeClassPtr);
			NativeFieldInfoPtr_computeAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SystemResources>.NativeClassPtr, "computeAsset");
		}

		public SystemResources(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public SystemResources()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SystemResources>.NativeClassPtr))
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_kWorkGroupSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Keywords;

	private static readonly System.IntPtr NativeFieldInfoPtr_resources;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_SystemResources_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DispatchStage_Private_Void_CommandBuffer_Args_UInt32_Stage_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CopyBuffer_Private_Void_CommandBuffer_GraphicsBuffer_GraphicsBuffer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DivRoundUp_Internal_Static_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Dispatch_Public_Void_CommandBuffer_Args_0;

	public unsafe static uint kWorkGroupSize
	{
		get
		{
			Unsafe.SkipInit(out uint result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kWorkGroupSize, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kWorkGroupSize, (void*)(&value));
		}
	}

	public unsafe Il2CppReferenceArray<LocalKeyword> m_Keywords
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Keywords);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<LocalKeyword>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Keywords)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe SystemResources resources
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resources);
			return new SystemResources(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SystemResources>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_resources), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SystemResources>.NativeClassPtr, ref *(uint*)null));
		}
	}

	static GPUSort()
	{
		Il2CppClassPointerStore<GPUSort>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "GPUSort");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GPUSort>.NativeClassPtr);
		NativeFieldInfoPtr_kWorkGroupSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUSort>.NativeClassPtr, "kWorkGroupSize");
		NativeFieldInfoPtr_m_Keywords = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUSort>.NativeClassPtr, "m_Keywords");
		NativeFieldInfoPtr_resources = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUSort>.NativeClassPtr, "resources");
		NativeMethodInfoPtr__ctor_Public_Void_SystemResources_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUSort>.NativeClassPtr, 100666704);
		NativeMethodInfoPtr_DispatchStage_Private_Void_CommandBuffer_Args_UInt32_Stage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUSort>.NativeClassPtr, 100666705);
		NativeMethodInfoPtr_CopyBuffer_Private_Void_CommandBuffer_GraphicsBuffer_GraphicsBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUSort>.NativeClassPtr, 100666706);
		NativeMethodInfoPtr_DivRoundUp_Internal_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUSort>.NativeClassPtr, 100666707);
		NativeMethodInfoPtr_Dispatch_Public_Void_CommandBuffer_Args_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GPUSort>.NativeClassPtr, 100666708);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1052978, XrefRangeEnd = 1052999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GPUSort(SystemResources resources)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GPUSort>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)resources));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_SystemResources_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1053022, RefRangeEnd = 1053026, XrefRangeStart = 1052999, XrefRangeEnd = 1053022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DispatchStage(CommandBuffer cmd, Args args, uint h, Stage stage)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)args));
		*(uint**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &h;
		*(Stage**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &stage;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DispatchStage_Private_Void_CommandBuffer_Args_UInt32_Stage_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1053040, RefRangeEnd = 1053042, XrefRangeStart = 1053026, XrefRangeEnd = 1053040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CopyBuffer(CommandBuffer cmd, GraphicsBuffer src, GraphicsBuffer dst)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)src);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dst);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CopyBuffer_Private_Void_CommandBuffer_GraphicsBuffer_GraphicsBuffer_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 1037843, RefRangeEnd = 1037851, XrefRangeStart = 1037843, XrefRangeEnd = 1037851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int DivRoundUp(int x, int y)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&x);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DivRoundUp_Internal_Static_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1053042, XrefRangeEnd = 1053058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Dispatch(CommandBuffer cmd, Args args)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)args));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dispatch_Public_Void_CommandBuffer_Args_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public GPUSort(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public GPUSort()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GPUSort>.NativeClassPtr))
	{
	}
}
