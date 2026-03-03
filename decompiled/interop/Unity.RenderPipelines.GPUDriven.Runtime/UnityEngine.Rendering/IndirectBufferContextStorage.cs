using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Unity.Collections;
using UnityEngine.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering;

public sealed class IndirectBufferContextStorage : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_BufferLimits;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_InstanceBuffer;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_InstanceInfoBuffer;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_InstanceInfoStaging;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ArgsBuffer;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_DrawInfoBuffer;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_DrawInfoStaging;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ContextAllocCounter;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ContextIndexFromViewID;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Contexts;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ContextAllocInfo;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_AllocationCounters;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_instanceBuffer_Public_get_GraphicsBuffer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_instanceInfoBuffer_Public_get_GraphicsBuffer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_argsBuffer_Public_get_GraphicsBuffer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_drawInfoBuffer_Public_get_GraphicsBuffer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_visibleInstanceBufferHandle_Public_get_GraphicsBufferHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_indirectArgsBufferHandle_Public_get_GraphicsBufferHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ImportBuffers_Public_IndirectBufferContextHandles_RenderGraph_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_instanceInfoGlobalArray_Public_get_NativeArray_1_IndirectInstanceInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_drawInfoGlobalArray_Public_get_NativeArray_1_IndirectDrawInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_allocationCounters_Public_get_NativeArray_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Init_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AllocateInstanceBuffers_Private_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FreeInstanceBuffers_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AllocateDrawBuffers_Private_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FreeDrawBuffers_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SyncContexts_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResetAllocators_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GrowBuffers_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearContextsAndGrowBuffers_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryAllocateContext_Public_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryGetContextIndex_Public_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAllocInfoSubArray_Public_NativeArray_1_IndirectBufferAllocInfo_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAllocInfo_Public_IndirectBufferAllocInfo_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CopyFromStaging_Public_Void_CommandBuffer_byref_IndirectBufferAllocInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLimits_Public_IndirectBufferLimits_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBufferContext_Public_IndirectBufferContext_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetBufferContext_Public_Void_Int32_IndirectBufferContext_0;

	public unsafe IndirectBufferLimits m_BufferLimits
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BufferLimits);
			return *(IndirectBufferLimits*)num;
		}
		set
		{
			*(IndirectBufferLimits*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BufferLimits)) = value;
		}
	}

	public unsafe GraphicsBuffer m_InstanceBuffer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_InstanceBuffer);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GraphicsBuffer>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_InstanceBuffer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe GraphicsBuffer m_InstanceInfoBuffer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_InstanceInfoBuffer);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GraphicsBuffer>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_InstanceInfoBuffer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe NativeArray<IndirectInstanceInfo> m_InstanceInfoStaging
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_InstanceInfoStaging);
			return new NativeArray<IndirectInstanceInfo>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<IndirectInstanceInfo>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_InstanceInfoStaging), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<IndirectInstanceInfo>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe GraphicsBuffer m_ArgsBuffer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ArgsBuffer);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GraphicsBuffer>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ArgsBuffer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe GraphicsBuffer m_DrawInfoBuffer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DrawInfoBuffer);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GraphicsBuffer>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DrawInfoBuffer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe NativeArray<IndirectDrawInfo> m_DrawInfoStaging
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DrawInfoStaging);
			return new NativeArray<IndirectDrawInfo>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<IndirectDrawInfo>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DrawInfoStaging), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<IndirectDrawInfo>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe int m_ContextAllocCounter
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ContextAllocCounter);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ContextAllocCounter)) = value;
		}
	}

	public unsafe NativeHashMap<int, int> m_ContextIndexFromViewID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ContextIndexFromViewID);
			return new NativeHashMap<int, int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeHashMap<int, int>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ContextIndexFromViewID), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeHashMap<int, int>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeList<IndirectBufferContext> m_Contexts
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Contexts);
			return new NativeList<IndirectBufferContext>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeList<IndirectBufferContext>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Contexts), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<IndirectBufferContext>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeArray<IndirectBufferAllocInfo> m_ContextAllocInfo
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ContextAllocInfo);
			return new NativeArray<IndirectBufferAllocInfo>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<IndirectBufferAllocInfo>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ContextAllocInfo), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<IndirectBufferAllocInfo>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeArray<int> m_AllocationCounters
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AllocationCounters);
			return new NativeArray<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AllocationCounters), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe GraphicsBuffer instanceBuffer
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_instanceBuffer_Public_get_GraphicsBuffer_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<GraphicsBuffer>(intPtr2) : null;
		}
	}

	public unsafe GraphicsBuffer instanceInfoBuffer
	{
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 50644, RefRangeEnd = 50653, XrefRangeStart = 50644, XrefRangeEnd = 50653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_instanceInfoBuffer_Public_get_GraphicsBuffer_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<GraphicsBuffer>(intPtr2) : null;
		}
	}

	public unsafe GraphicsBuffer argsBuffer
	{
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 42604, RefRangeEnd = 42610, XrefRangeStart = 42604, XrefRangeEnd = 42610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_argsBuffer_Public_get_GraphicsBuffer_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<GraphicsBuffer>(intPtr2) : null;
		}
	}

	public unsafe GraphicsBuffer drawInfoBuffer
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 50643, RefRangeEnd = 50644, XrefRangeStart = 50643, XrefRangeEnd = 50644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_drawInfoBuffer_Public_get_GraphicsBuffer_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<GraphicsBuffer>(intPtr2) : null;
		}
	}

	public unsafe GraphicsBufferHandle visibleInstanceBufferHandle
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1073825, RefRangeEnd = 1073826, XrefRangeStart = 1073823, XrefRangeEnd = 1073825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_visibleInstanceBufferHandle_Public_get_GraphicsBufferHandle_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(GraphicsBufferHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe GraphicsBufferHandle indirectArgsBufferHandle
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1073828, RefRangeEnd = 1073829, XrefRangeStart = 1073826, XrefRangeEnd = 1073828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_indirectArgsBufferHandle_Public_get_GraphicsBufferHandle_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(GraphicsBufferHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe NativeArray<IndirectInstanceInfo> instanceInfoGlobalArray
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_instanceInfoGlobalArray_Public_get_NativeArray_1_IndirectInstanceInfo_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new NativeArray<IndirectInstanceInfo>(pointer);
		}
	}

	public unsafe NativeArray<IndirectDrawInfo> drawInfoGlobalArray
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_drawInfoGlobalArray_Public_get_NativeArray_1_IndirectDrawInfo_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new NativeArray<IndirectDrawInfo>(pointer);
		}
	}

	public unsafe NativeArray<int> allocationCounters
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_allocationCounters_Public_get_NativeArray_1_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new NativeArray<int>(pointer);
		}
	}

	static IndirectBufferContextStorage()
	{
		Il2CppClassPointerStore<IndirectBufferContextStorage>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.GPUDriven.Runtime.dll", "UnityEngine.Rendering", "IndirectBufferContextStorage");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IndirectBufferContextStorage>.NativeClassPtr);
		NativeFieldInfoPtr_m_BufferLimits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IndirectBufferContextStorage>.NativeClassPtr, "m_BufferLimits");
		NativeFieldInfoPtr_m_InstanceBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IndirectBufferContextStorage>.NativeClassPtr, "m_InstanceBuffer");
		NativeFieldInfoPtr_m_InstanceInfoBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IndirectBufferContextStorage>.NativeClassPtr, "m_InstanceInfoBuffer");
		NativeFieldInfoPtr_m_InstanceInfoStaging = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IndirectBufferContextStorage>.NativeClassPtr, "m_InstanceInfoStaging");
		NativeFieldInfoPtr_m_ArgsBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IndirectBufferContextStorage>.NativeClassPtr, "m_ArgsBuffer");
		NativeFieldInfoPtr_m_DrawInfoBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IndirectBufferContextStorage>.NativeClassPtr, "m_DrawInfoBuffer");
		NativeFieldInfoPtr_m_DrawInfoStaging = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IndirectBufferContextStorage>.NativeClassPtr, "m_DrawInfoStaging");
		NativeFieldInfoPtr_m_ContextAllocCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IndirectBufferContextStorage>.NativeClassPtr, "m_ContextAllocCounter");
		NativeFieldInfoPtr_m_ContextIndexFromViewID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IndirectBufferContextStorage>.NativeClassPtr, "m_ContextIndexFromViewID");
		NativeFieldInfoPtr_m_Contexts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IndirectBufferContextStorage>.NativeClassPtr, "m_Contexts");
		NativeFieldInfoPtr_m_ContextAllocInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IndirectBufferContextStorage>.NativeClassPtr, "m_ContextAllocInfo");
		NativeFieldInfoPtr_m_AllocationCounters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IndirectBufferContextStorage>.NativeClassPtr, "m_AllocationCounters");
		NativeMethodInfoPtr_get_instanceBuffer_Public_get_GraphicsBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndirectBufferContextStorage>.NativeClassPtr, 100663913);
		NativeMethodInfoPtr_get_instanceInfoBuffer_Public_get_GraphicsBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndirectBufferContextStorage>.NativeClassPtr, 100663914);
		NativeMethodInfoPtr_get_argsBuffer_Public_get_GraphicsBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndirectBufferContextStorage>.NativeClassPtr, 100663915);
		NativeMethodInfoPtr_get_drawInfoBuffer_Public_get_GraphicsBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndirectBufferContextStorage>.NativeClassPtr, 100663916);
		NativeMethodInfoPtr_get_visibleInstanceBufferHandle_Public_get_GraphicsBufferHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndirectBufferContextStorage>.NativeClassPtr, 100663917);
		NativeMethodInfoPtr_get_indirectArgsBufferHandle_Public_get_GraphicsBufferHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndirectBufferContextStorage>.NativeClassPtr, 100663918);
		NativeMethodInfoPtr_ImportBuffers_Public_IndirectBufferContextHandles_RenderGraph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndirectBufferContextStorage>.NativeClassPtr, 100663919);
		NativeMethodInfoPtr_get_instanceInfoGlobalArray_Public_get_NativeArray_1_IndirectInstanceInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndirectBufferContextStorage>.NativeClassPtr, 100663920);
		NativeMethodInfoPtr_get_drawInfoGlobalArray_Public_get_NativeArray_1_IndirectDrawInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndirectBufferContextStorage>.NativeClassPtr, 100663921);
		NativeMethodInfoPtr_get_allocationCounters_Public_get_NativeArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndirectBufferContextStorage>.NativeClassPtr, 100663922);
		NativeMethodInfoPtr_Init_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndirectBufferContextStorage>.NativeClassPtr, 100663923);
		NativeMethodInfoPtr_AllocateInstanceBuffers_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndirectBufferContextStorage>.NativeClassPtr, 100663924);
		NativeMethodInfoPtr_FreeInstanceBuffers_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndirectBufferContextStorage>.NativeClassPtr, 100663925);
		NativeMethodInfoPtr_AllocateDrawBuffers_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndirectBufferContextStorage>.NativeClassPtr, 100663926);
		NativeMethodInfoPtr_FreeDrawBuffers_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndirectBufferContextStorage>.NativeClassPtr, 100663927);
		NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndirectBufferContextStorage>.NativeClassPtr, 100663928);
		NativeMethodInfoPtr_SyncContexts_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndirectBufferContextStorage>.NativeClassPtr, 100663929);
		NativeMethodInfoPtr_ResetAllocators_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndirectBufferContextStorage>.NativeClassPtr, 100663930);
		NativeMethodInfoPtr_GrowBuffers_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndirectBufferContextStorage>.NativeClassPtr, 100663931);
		NativeMethodInfoPtr_ClearContextsAndGrowBuffers_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndirectBufferContextStorage>.NativeClassPtr, 100663932);
		NativeMethodInfoPtr_TryAllocateContext_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndirectBufferContextStorage>.NativeClassPtr, 100663933);
		NativeMethodInfoPtr_TryGetContextIndex_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndirectBufferContextStorage>.NativeClassPtr, 100663934);
		NativeMethodInfoPtr_GetAllocInfoSubArray_Public_NativeArray_1_IndirectBufferAllocInfo_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndirectBufferContextStorage>.NativeClassPtr, 100663935);
		NativeMethodInfoPtr_GetAllocInfo_Public_IndirectBufferAllocInfo_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndirectBufferContextStorage>.NativeClassPtr, 100663936);
		NativeMethodInfoPtr_CopyFromStaging_Public_Void_CommandBuffer_byref_IndirectBufferAllocInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndirectBufferContextStorage>.NativeClassPtr, 100663937);
		NativeMethodInfoPtr_GetLimits_Public_IndirectBufferLimits_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndirectBufferContextStorage>.NativeClassPtr, 100663938);
		NativeMethodInfoPtr_GetBufferContext_Public_IndirectBufferContext_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndirectBufferContextStorage>.NativeClassPtr, 100663939);
		NativeMethodInfoPtr_SetBufferContext_Public_Void_Int32_IndirectBufferContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndirectBufferContextStorage>.NativeClassPtr, 100663940);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1073833, RefRangeEnd = 1073834, XrefRangeStart = 1073829, XrefRangeEnd = 1073833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IndirectBufferContextHandles ImportBuffers(RenderGraph renderGraph)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderGraph);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ImportBuffers_Public_IndirectBufferContextHandles_RenderGraph_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(IndirectBufferContextHandles*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1073851, RefRangeEnd = 1073852, XrefRangeStart = 1073834, XrefRangeEnd = 1073851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Init()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Init_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1073870, RefRangeEnd = 1073872, XrefRangeStart = 1073852, XrefRangeEnd = 1073870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AllocateInstanceBuffers(int maxInstanceCount)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&maxInstanceCount);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AllocateInstanceBuffers_Private_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1073872, XrefRangeEnd = 1073877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FreeInstanceBuffers()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FreeInstanceBuffers_Private_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1073895, RefRangeEnd = 1073897, XrefRangeStart = 1073877, XrefRangeEnd = 1073895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AllocateDrawBuffers(int maxDrawCount)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&maxDrawCount);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AllocateDrawBuffers_Private_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1073902, RefRangeEnd = 1073903, XrefRangeStart = 1073897, XrefRangeEnd = 1073902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FreeDrawBuffers()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FreeDrawBuffers_Private_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1073927, RefRangeEnd = 1073928, XrefRangeStart = 1073903, XrefRangeEnd = 1073927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Dispose()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1073936, RefRangeEnd = 1073938, XrefRangeStart = 1073928, XrefRangeEnd = 1073936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SyncContexts()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SyncContexts_Private_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1073947, RefRangeEnd = 1073949, XrefRangeStart = 1073938, XrefRangeEnd = 1073947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ResetAllocators()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetAllocators_Private_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1073969, RefRangeEnd = 1073970, XrefRangeStart = 1073949, XrefRangeEnd = 1073969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GrowBuffers()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GrowBuffers_Private_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1073973, RefRangeEnd = 1073974, XrefRangeStart = 1073970, XrefRangeEnd = 1073973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ClearContextsAndGrowBuffers()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearContextsAndGrowBuffers_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1073988, RefRangeEnd = 1073989, XrefRangeStart = 1073974, XrefRangeEnd = 1073988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int TryAllocateContext(int viewID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&viewID);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryAllocateContext_Public_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1073992, RefRangeEnd = 1073994, XrefRangeStart = 1073989, XrefRangeEnd = 1073992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int TryGetContextIndex(int viewID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&viewID);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryGetContextIndex_Public_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1073997, RefRangeEnd = 1073998, XrefRangeStart = 1073994, XrefRangeEnd = 1073997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe NativeArray<IndirectBufferAllocInfo> GetAllocInfoSubArray(int contextIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&contextIndex);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAllocInfoSubArray_Public_NativeArray_1_IndirectBufferAllocInfo_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new NativeArray<IndirectBufferAllocInfo>(pointer);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1074001, RefRangeEnd = 1074003, XrefRangeStart = 1073998, XrefRangeEnd = 1074001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IndirectBufferAllocInfo GetAllocInfo(int contextIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&contextIndex);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAllocInfo_Public_IndirectBufferAllocInfo_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(IndirectBufferAllocInfo*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1074009, RefRangeEnd = 1074010, XrefRangeStart = 1074003, XrefRangeEnd = 1074009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CopyFromStaging(CommandBuffer cmd, [In] ref IndirectBufferAllocInfo allocInfo)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref allocInfo);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CopyFromStaging_Public_Void_CommandBuffer_byref_IndirectBufferAllocInfo_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1074010, RefRangeEnd = 1074011, XrefRangeStart = 1074010, XrefRangeEnd = 1074010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IndirectBufferLimits GetLimits(int contextIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&contextIndex);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLimits_Public_IndirectBufferLimits_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(IndirectBufferLimits*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1074017, RefRangeEnd = 1074019, XrefRangeStart = 1074011, XrefRangeEnd = 1074017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IndirectBufferContext GetBufferContext(int contextIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&contextIndex);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBufferContext_Public_IndirectBufferContext_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(IndirectBufferContext*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1074025, RefRangeEnd = 1074027, XrefRangeStart = 1074019, XrefRangeEnd = 1074025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetBufferContext(int contextIndex, IndirectBufferContext ctx)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&contextIndex);
		*(IndirectBufferContext**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &ctx;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetBufferContext_Public_Void_Int32_IndirectBufferContext_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public IndirectBufferContextStorage(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public IndirectBufferContextStorage()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IndirectBufferContextStorage>.NativeClassPtr))
	{
	}
}
