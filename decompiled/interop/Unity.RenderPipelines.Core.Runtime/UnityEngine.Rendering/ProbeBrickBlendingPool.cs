using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Rendering;

public class ProbeBrickBlendingPool : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_stateBlendShader;

	private static readonly System.IntPtr NativeFieldInfoPtr_scenarioBlendingKernel;

	private static readonly System.IntPtr NativeFieldInfoPtr__PoolDim_LerpFactor;

	private static readonly System.IntPtr NativeFieldInfoPtr__ChunkList;

	private static readonly System.IntPtr NativeFieldInfoPtr__State0_L0_L1Rx;

	private static readonly System.IntPtr NativeFieldInfoPtr__State0_L1G_L1Ry;

	private static readonly System.IntPtr NativeFieldInfoPtr__State0_L1B_L1Rz;

	private static readonly System.IntPtr NativeFieldInfoPtr__State0_L2_0;

	private static readonly System.IntPtr NativeFieldInfoPtr__State0_L2_1;

	private static readonly System.IntPtr NativeFieldInfoPtr__State0_L2_2;

	private static readonly System.IntPtr NativeFieldInfoPtr__State0_L2_3;

	private static readonly System.IntPtr NativeFieldInfoPtr__State0_ProbeOcclusion;

	private static readonly System.IntPtr NativeFieldInfoPtr__State1_L0_L1Rx;

	private static readonly System.IntPtr NativeFieldInfoPtr__State1_L1G_L1Ry;

	private static readonly System.IntPtr NativeFieldInfoPtr__State1_L1B_L1Rz;

	private static readonly System.IntPtr NativeFieldInfoPtr__State1_L2_0;

	private static readonly System.IntPtr NativeFieldInfoPtr__State1_L2_1;

	private static readonly System.IntPtr NativeFieldInfoPtr__State1_L2_2;

	private static readonly System.IntPtr NativeFieldInfoPtr__State1_L2_3;

	private static readonly System.IntPtr NativeFieldInfoPtr__State1_ProbeOcclusion;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ChunkList;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_MappedChunks;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_State0;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_State1;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_MemoryBudget;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ShBands;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ProbeOcclusion;

	private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Internal_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isAllocated_Internal_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_estimatedVMemCost_Internal_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPoolWidth_Internal_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPoolHeight_Internal_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPoolDepth_Internal_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ProbeVolumeBlendingTextureMemoryBudget_ProbeVolumeSHBands_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AllocateResourcesIfNeeded_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Update_Internal_Void_DataLocation_List_1_BrickChunkAlloc_List_1_BrickChunkAlloc_Int32_ProbeVolumeSHBands_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Update_Internal_Void_CommandBuffer_CellStreamingScratchBuffer_CellStreamingScratchBufferLayout_List_1_BrickChunkAlloc_ProbeVolumeSHBands_Int32_Texture_Boolean_Texture_Boolean_Texture_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PerformBlending_Internal_Void_CommandBuffer_Single_ProbeBrickPool_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BlendChunks_Internal_Void_Cell_ProbeBrickPool_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Clear_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Allocate_Internal_Boolean_Int32_List_1_BrickChunkAlloc_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Deallocate_Internal_Void_List_1_BrickChunkAlloc_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnsureTextureValidity_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Cleanup_Internal_Void_0;

	public unsafe static ComputeShader stateBlendShader
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_stateBlendShader, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ComputeShader>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_stateBlendShader, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static int scenarioBlendingKernel
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_scenarioBlendingKernel, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_scenarioBlendingKernel, (void*)(&value));
		}
	}

	public unsafe static int _PoolDim_LerpFactor
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__PoolDim_LerpFactor, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__PoolDim_LerpFactor, (void*)(&value));
		}
	}

	public unsafe static int _ChunkList
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__ChunkList, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__ChunkList, (void*)(&value));
		}
	}

	public unsafe static int _State0_L0_L1Rx
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__State0_L0_L1Rx, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__State0_L0_L1Rx, (void*)(&value));
		}
	}

	public unsafe static int _State0_L1G_L1Ry
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__State0_L1G_L1Ry, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__State0_L1G_L1Ry, (void*)(&value));
		}
	}

	public unsafe static int _State0_L1B_L1Rz
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__State0_L1B_L1Rz, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__State0_L1B_L1Rz, (void*)(&value));
		}
	}

	public unsafe static int _State0_L2_0
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__State0_L2_0, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__State0_L2_0, (void*)(&value));
		}
	}

	public unsafe static int _State0_L2_1
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__State0_L2_1, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__State0_L2_1, (void*)(&value));
		}
	}

	public unsafe static int _State0_L2_2
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__State0_L2_2, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__State0_L2_2, (void*)(&value));
		}
	}

	public unsafe static int _State0_L2_3
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__State0_L2_3, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__State0_L2_3, (void*)(&value));
		}
	}

	public unsafe static int _State0_ProbeOcclusion
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__State0_ProbeOcclusion, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__State0_ProbeOcclusion, (void*)(&value));
		}
	}

	public unsafe static int _State1_L0_L1Rx
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__State1_L0_L1Rx, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__State1_L0_L1Rx, (void*)(&value));
		}
	}

	public unsafe static int _State1_L1G_L1Ry
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__State1_L1G_L1Ry, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__State1_L1G_L1Ry, (void*)(&value));
		}
	}

	public unsafe static int _State1_L1B_L1Rz
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__State1_L1B_L1Rz, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__State1_L1B_L1Rz, (void*)(&value));
		}
	}

	public unsafe static int _State1_L2_0
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__State1_L2_0, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__State1_L2_0, (void*)(&value));
		}
	}

	public unsafe static int _State1_L2_1
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__State1_L2_1, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__State1_L2_1, (void*)(&value));
		}
	}

	public unsafe static int _State1_L2_2
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__State1_L2_2, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__State1_L2_2, (void*)(&value));
		}
	}

	public unsafe static int _State1_L2_3
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__State1_L2_3, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__State1_L2_3, (void*)(&value));
		}
	}

	public unsafe static int _State1_ProbeOcclusion
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__State1_ProbeOcclusion, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__State1_ProbeOcclusion, (void*)(&value));
		}
	}

	public unsafe Il2CppStructArray<Vector4> m_ChunkList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ChunkList);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector4>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ChunkList)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe int m_MappedChunks
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MappedChunks);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MappedChunks)) = value;
		}
	}

	public unsafe ProbeBrickPool m_State0
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_State0);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ProbeBrickPool>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_State0)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe ProbeBrickPool m_State1
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_State1);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ProbeBrickPool>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_State1)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe ProbeVolumeTextureMemoryBudget m_MemoryBudget
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MemoryBudget);
			return *(ProbeVolumeTextureMemoryBudget*)num;
		}
		set
		{
			*(ProbeVolumeTextureMemoryBudget*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MemoryBudget)) = value;
		}
	}

	public unsafe ProbeVolumeSHBands m_ShBands
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ShBands);
			return *(ProbeVolumeSHBands*)num;
		}
		set
		{
			*(ProbeVolumeSHBands*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ShBands)) = value;
		}
	}

	public unsafe bool m_ProbeOcclusion
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ProbeOcclusion);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ProbeOcclusion)) = value;
		}
	}

	public unsafe bool isAllocated
	{
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 869932, RefRangeEnd = 869937, XrefRangeStart = 869932, XrefRangeEnd = 869937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isAllocated_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe int estimatedVMemCost
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1038415, RefRangeEnd = 1038416, XrefRangeStart = 1038397, XrefRangeEnd = 1038415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_estimatedVMemCost_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static ProbeBrickBlendingPool()
	{
		Il2CppClassPointerStore<ProbeBrickBlendingPool>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "ProbeBrickBlendingPool");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProbeBrickBlendingPool>.NativeClassPtr);
		NativeFieldInfoPtr_stateBlendShader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickBlendingPool>.NativeClassPtr, "stateBlendShader");
		NativeFieldInfoPtr_scenarioBlendingKernel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickBlendingPool>.NativeClassPtr, "scenarioBlendingKernel");
		NativeFieldInfoPtr__PoolDim_LerpFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickBlendingPool>.NativeClassPtr, "_PoolDim_LerpFactor");
		NativeFieldInfoPtr__ChunkList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickBlendingPool>.NativeClassPtr, "_ChunkList");
		NativeFieldInfoPtr__State0_L0_L1Rx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickBlendingPool>.NativeClassPtr, "_State0_L0_L1Rx");
		NativeFieldInfoPtr__State0_L1G_L1Ry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickBlendingPool>.NativeClassPtr, "_State0_L1G_L1Ry");
		NativeFieldInfoPtr__State0_L1B_L1Rz = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickBlendingPool>.NativeClassPtr, "_State0_L1B_L1Rz");
		NativeFieldInfoPtr__State0_L2_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickBlendingPool>.NativeClassPtr, "_State0_L2_0");
		NativeFieldInfoPtr__State0_L2_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickBlendingPool>.NativeClassPtr, "_State0_L2_1");
		NativeFieldInfoPtr__State0_L2_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickBlendingPool>.NativeClassPtr, "_State0_L2_2");
		NativeFieldInfoPtr__State0_L2_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickBlendingPool>.NativeClassPtr, "_State0_L2_3");
		NativeFieldInfoPtr__State0_ProbeOcclusion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickBlendingPool>.NativeClassPtr, "_State0_ProbeOcclusion");
		NativeFieldInfoPtr__State1_L0_L1Rx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickBlendingPool>.NativeClassPtr, "_State1_L0_L1Rx");
		NativeFieldInfoPtr__State1_L1G_L1Ry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickBlendingPool>.NativeClassPtr, "_State1_L1G_L1Ry");
		NativeFieldInfoPtr__State1_L1B_L1Rz = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickBlendingPool>.NativeClassPtr, "_State1_L1B_L1Rz");
		NativeFieldInfoPtr__State1_L2_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickBlendingPool>.NativeClassPtr, "_State1_L2_0");
		NativeFieldInfoPtr__State1_L2_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickBlendingPool>.NativeClassPtr, "_State1_L2_1");
		NativeFieldInfoPtr__State1_L2_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickBlendingPool>.NativeClassPtr, "_State1_L2_2");
		NativeFieldInfoPtr__State1_L2_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickBlendingPool>.NativeClassPtr, "_State1_L2_3");
		NativeFieldInfoPtr__State1_ProbeOcclusion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickBlendingPool>.NativeClassPtr, "_State1_ProbeOcclusion");
		NativeFieldInfoPtr_m_ChunkList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickBlendingPool>.NativeClassPtr, "m_ChunkList");
		NativeFieldInfoPtr_m_MappedChunks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickBlendingPool>.NativeClassPtr, "m_MappedChunks");
		NativeFieldInfoPtr_m_State0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickBlendingPool>.NativeClassPtr, "m_State0");
		NativeFieldInfoPtr_m_State1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickBlendingPool>.NativeClassPtr, "m_State1");
		NativeFieldInfoPtr_m_MemoryBudget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickBlendingPool>.NativeClassPtr, "m_MemoryBudget");
		NativeFieldInfoPtr_m_ShBands = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickBlendingPool>.NativeClassPtr, "m_ShBands");
		NativeFieldInfoPtr_m_ProbeOcclusion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickBlendingPool>.NativeClassPtr, "m_ProbeOcclusion");
		NativeMethodInfoPtr_Initialize_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeBrickBlendingPool>.NativeClassPtr, 100665335);
		NativeMethodInfoPtr_get_isAllocated_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeBrickBlendingPool>.NativeClassPtr, 100665336);
		NativeMethodInfoPtr_get_estimatedVMemCost_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeBrickBlendingPool>.NativeClassPtr, 100665337);
		NativeMethodInfoPtr_GetPoolWidth_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeBrickBlendingPool>.NativeClassPtr, 100665338);
		NativeMethodInfoPtr_GetPoolHeight_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeBrickBlendingPool>.NativeClassPtr, 100665339);
		NativeMethodInfoPtr_GetPoolDepth_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeBrickBlendingPool>.NativeClassPtr, 100665340);
		NativeMethodInfoPtr__ctor_Internal_Void_ProbeVolumeBlendingTextureMemoryBudget_ProbeVolumeSHBands_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeBrickBlendingPool>.NativeClassPtr, 100665341);
		NativeMethodInfoPtr_AllocateResourcesIfNeeded_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeBrickBlendingPool>.NativeClassPtr, 100665342);
		NativeMethodInfoPtr_Update_Internal_Void_DataLocation_List_1_BrickChunkAlloc_List_1_BrickChunkAlloc_Int32_ProbeVolumeSHBands_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeBrickBlendingPool>.NativeClassPtr, 100665343);
		NativeMethodInfoPtr_Update_Internal_Void_CommandBuffer_CellStreamingScratchBuffer_CellStreamingScratchBufferLayout_List_1_BrickChunkAlloc_ProbeVolumeSHBands_Int32_Texture_Boolean_Texture_Boolean_Texture_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeBrickBlendingPool>.NativeClassPtr, 100665344);
		NativeMethodInfoPtr_PerformBlending_Internal_Void_CommandBuffer_Single_ProbeBrickPool_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeBrickBlendingPool>.NativeClassPtr, 100665345);
		NativeMethodInfoPtr_BlendChunks_Internal_Void_Cell_ProbeBrickPool_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeBrickBlendingPool>.NativeClassPtr, 100665346);
		NativeMethodInfoPtr_Clear_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeBrickBlendingPool>.NativeClassPtr, 100665347);
		NativeMethodInfoPtr_Allocate_Internal_Boolean_Int32_List_1_BrickChunkAlloc_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeBrickBlendingPool>.NativeClassPtr, 100665348);
		NativeMethodInfoPtr_Deallocate_Internal_Void_List_1_BrickChunkAlloc_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeBrickBlendingPool>.NativeClassPtr, 100665349);
		NativeMethodInfoPtr_EnsureTextureValidity_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeBrickBlendingPool>.NativeClassPtr, 100665350);
		NativeMethodInfoPtr_Cleanup_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeBrickBlendingPool>.NativeClassPtr, 100665351);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1038396, RefRangeEnd = 1038397, XrefRangeStart = 1038367, XrefRangeEnd = 1038396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Initialize()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_Internal_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe int GetPoolWidth()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPoolWidth_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe int GetPoolHeight()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPoolHeight_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe int GetPoolDepth()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPoolDepth_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1038417, RefRangeEnd = 1038418, XrefRangeStart = 1038416, XrefRangeEnd = 1038417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ProbeBrickBlendingPool(ProbeVolumeBlendingTextureMemoryBudget memoryBudget, ProbeVolumeSHBands shBands, bool probeOcclusion)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProbeBrickBlendingPool>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&memoryBudget);
		*(ProbeVolumeSHBands**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &shBands;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &probeOcclusion;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_ProbeVolumeBlendingTextureMemoryBudget_ProbeVolumeSHBands_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1038418, XrefRangeEnd = 1038431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AllocateResourcesIfNeeded()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AllocateResourcesIfNeeded_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1038432, RefRangeEnd = 1038433, XrefRangeStart = 1038431, XrefRangeEnd = 1038432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update(ProbeBrickPool.DataLocation source, List<ProbeBrickPool.BrickChunkAlloc> srcLocations, List<ProbeBrickPool.BrickChunkAlloc> dstLocations, int destStartIndex, ProbeVolumeSHBands bands, int state)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)source));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)srcLocations);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dstLocations);
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &destStartIndex;
		*(ProbeVolumeSHBands**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &bands;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &state;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Internal_Void_DataLocation_List_1_BrickChunkAlloc_List_1_BrickChunkAlloc_Int32_ProbeVolumeSHBands_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1038434, RefRangeEnd = 1038435, XrefRangeStart = 1038433, XrefRangeEnd = 1038434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update(CommandBuffer cmd, ProbeReferenceVolume.CellStreamingScratchBuffer dataBuffer, ProbeReferenceVolume.CellStreamingScratchBufferLayout layout, List<ProbeBrickPool.BrickChunkAlloc> dstLocations, ProbeVolumeSHBands bands, int state, Texture validityTexture, bool skyOcclusion, Texture skyOcclusionTexture, bool skyShadingDirections, Texture skyShadingDirectionsTexture, bool probeOcclusion)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[12];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dataBuffer);
		*(ProbeReferenceVolume.CellStreamingScratchBufferLayout**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &layout;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dstLocations);
		*(ProbeVolumeSHBands**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &bands;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &state;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)validityTexture);
		*(bool**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &skyOcclusion;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)skyOcclusionTexture);
		*(bool**)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = &skyShadingDirections;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)10u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)skyShadingDirectionsTexture);
		*(bool**)((byte*)ptr + checked((nuint)11u * unchecked((nuint)sizeof(System.IntPtr)))) = &probeOcclusion;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Internal_Void_CommandBuffer_CellStreamingScratchBuffer_CellStreamingScratchBufferLayout_List_1_BrickChunkAlloc_ProbeVolumeSHBands_Int32_Texture_Boolean_Texture_Boolean_Texture_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1038557, RefRangeEnd = 1038558, XrefRangeStart = 1038435, XrefRangeEnd = 1038557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PerformBlending(CommandBuffer cmd, float factor, ProbeBrickPool dstPool)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &factor;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dstPool);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PerformBlending_Internal_Void_CommandBuffer_Single_ProbeBrickPool_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1038565, RefRangeEnd = 1038566, XrefRangeStart = 1038558, XrefRangeEnd = 1038565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void BlendChunks(ProbeReferenceVolume.Cell cell, ProbeBrickPool dstPool)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cell);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dstPool);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BlendChunks_Internal_Void_Cell_ProbeBrickPool_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1038569, RefRangeEnd = 1038570, XrefRangeStart = 1038566, XrefRangeEnd = 1038569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Clear()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Clear_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1038584, RefRangeEnd = 1038585, XrefRangeStart = 1038570, XrefRangeEnd = 1038584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Allocate(int numberOfBrickChunks, List<ProbeBrickPool.BrickChunkAlloc> outAllocations)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&numberOfBrickChunks);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)outAllocations);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Allocate_Internal_Boolean_Int32_List_1_BrickChunkAlloc_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1038587, RefRangeEnd = 1038590, XrefRangeStart = 1038585, XrefRangeEnd = 1038587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Deallocate(List<ProbeBrickPool.BrickChunkAlloc> allocations)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)allocations);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Deallocate_Internal_Void_List_1_BrickChunkAlloc_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1038592, RefRangeEnd = 1038593, XrefRangeStart = 1038590, XrefRangeEnd = 1038592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EnsureTextureValidity()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnsureTextureValidity_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1038595, RefRangeEnd = 1038596, XrefRangeStart = 1038593, XrefRangeEnd = 1038595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Cleanup()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Cleanup_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public ProbeBrickBlendingPool(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
