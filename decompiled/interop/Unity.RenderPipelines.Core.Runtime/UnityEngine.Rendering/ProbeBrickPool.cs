using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Experimental.Rendering;

namespace UnityEngine.Rendering;

public class ProbeBrickPool : Il2CppSystem.Object
{
	[StructLayout(LayoutKind.Explicit)]
	public struct BrickChunkAlloc
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_x;

		private static readonly System.IntPtr NativeFieldInfoPtr_y;

		private static readonly System.IntPtr NativeFieldInfoPtr_z;

		private static readonly System.IntPtr NativeMethodInfoPtr_flattenIndex_Internal_Int32_Int32_Int32_0;

		[FieldOffset(0)]
		public int x;

		[FieldOffset(4)]
		public int y;

		[FieldOffset(8)]
		public int z;

		static BrickChunkAlloc()
		{
			Il2CppClassPointerStore<BrickChunkAlloc>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProbeBrickPool>.NativeClassPtr, "BrickChunkAlloc");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BrickChunkAlloc>.NativeClassPtr);
			NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BrickChunkAlloc>.NativeClassPtr, "x");
			NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BrickChunkAlloc>.NativeClassPtr, "y");
			NativeFieldInfoPtr_z = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BrickChunkAlloc>.NativeClassPtr, "z");
			NativeMethodInfoPtr_flattenIndex_Internal_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickChunkAlloc>.NativeClassPtr, 100665333);
		}

		[CallerCount(0)]
		public unsafe int flattenIndex(int sx, int sy)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&sx);
			*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &sy;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_flattenIndex_Internal_Int32_Int32_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BrickChunkAlloc>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	public sealed class DataLocation : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_TexL0_L1rx;

		private static readonly System.IntPtr NativeFieldInfoPtr_TexL1_G_ry;

		private static readonly System.IntPtr NativeFieldInfoPtr_TexL1_B_rz;

		private static readonly System.IntPtr NativeFieldInfoPtr_TexL2_0;

		private static readonly System.IntPtr NativeFieldInfoPtr_TexL2_1;

		private static readonly System.IntPtr NativeFieldInfoPtr_TexL2_2;

		private static readonly System.IntPtr NativeFieldInfoPtr_TexL2_3;

		private static readonly System.IntPtr NativeFieldInfoPtr_TexProbeOcclusion;

		private static readonly System.IntPtr NativeFieldInfoPtr_TexValidity;

		private static readonly System.IntPtr NativeFieldInfoPtr_TexSkyOcclusion;

		private static readonly System.IntPtr NativeFieldInfoPtr_TexSkyShadingDirectionIndices;

		private static readonly System.IntPtr NativeFieldInfoPtr_width;

		private static readonly System.IntPtr NativeFieldInfoPtr_height;

		private static readonly System.IntPtr NativeFieldInfoPtr_depth;

		private static readonly System.IntPtr NativeMethodInfoPtr_Cleanup_Internal_Void_0;

		public unsafe Texture TexL0_L1rx
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TexL0_L1rx);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Texture>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TexL0_L1rx)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe Texture TexL1_G_ry
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TexL1_G_ry);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Texture>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TexL1_G_ry)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe Texture TexL1_B_rz
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TexL1_B_rz);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Texture>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TexL1_B_rz)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe Texture TexL2_0
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TexL2_0);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Texture>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TexL2_0)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe Texture TexL2_1
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TexL2_1);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Texture>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TexL2_1)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe Texture TexL2_2
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TexL2_2);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Texture>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TexL2_2)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe Texture TexL2_3
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TexL2_3);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Texture>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TexL2_3)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe Texture TexProbeOcclusion
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TexProbeOcclusion);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Texture>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TexProbeOcclusion)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe Texture TexValidity
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TexValidity);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Texture>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TexValidity)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe Texture TexSkyOcclusion
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TexSkyOcclusion);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Texture>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TexSkyOcclusion)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe Texture TexSkyShadingDirectionIndices
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TexSkyShadingDirectionIndices);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Texture>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TexSkyShadingDirectionIndices)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe int width
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_width);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_width)) = value;
			}
		}

		public unsafe int height
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_height);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_height)) = value;
			}
		}

		public unsafe int depth
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_depth);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_depth)) = value;
			}
		}

		static DataLocation()
		{
			Il2CppClassPointerStore<DataLocation>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProbeBrickPool>.NativeClassPtr, "DataLocation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DataLocation>.NativeClassPtr);
			NativeFieldInfoPtr_TexL0_L1rx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataLocation>.NativeClassPtr, "TexL0_L1rx");
			NativeFieldInfoPtr_TexL1_G_ry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataLocation>.NativeClassPtr, "TexL1_G_ry");
			NativeFieldInfoPtr_TexL1_B_rz = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataLocation>.NativeClassPtr, "TexL1_B_rz");
			NativeFieldInfoPtr_TexL2_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataLocation>.NativeClassPtr, "TexL2_0");
			NativeFieldInfoPtr_TexL2_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataLocation>.NativeClassPtr, "TexL2_1");
			NativeFieldInfoPtr_TexL2_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataLocation>.NativeClassPtr, "TexL2_2");
			NativeFieldInfoPtr_TexL2_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataLocation>.NativeClassPtr, "TexL2_3");
			NativeFieldInfoPtr_TexProbeOcclusion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataLocation>.NativeClassPtr, "TexProbeOcclusion");
			NativeFieldInfoPtr_TexValidity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataLocation>.NativeClassPtr, "TexValidity");
			NativeFieldInfoPtr_TexSkyOcclusion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataLocation>.NativeClassPtr, "TexSkyOcclusion");
			NativeFieldInfoPtr_TexSkyShadingDirectionIndices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataLocation>.NativeClassPtr, "TexSkyShadingDirectionIndices");
			NativeFieldInfoPtr_width = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataLocation>.NativeClassPtr, "width");
			NativeFieldInfoPtr_height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataLocation>.NativeClassPtr, "height");
			NativeFieldInfoPtr_depth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataLocation>.NativeClassPtr, "depth");
			NativeMethodInfoPtr_Cleanup_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataLocation>.NativeClassPtr, 100665334);
		}

		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1037836, RefRangeEnd = 1037843, XrefRangeStart = 1037811, XrefRangeEnd = 1037836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Cleanup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Cleanup_Internal_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public DataLocation(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public DataLocation()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DataLocation>.NativeClassPtr))
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr__Out_L0_L1Rx;

	private static readonly System.IntPtr NativeFieldInfoPtr__Out_L1G_L1Ry;

	private static readonly System.IntPtr NativeFieldInfoPtr__Out_L1B_L1Rz;

	private static readonly System.IntPtr NativeFieldInfoPtr__Out_Shared;

	private static readonly System.IntPtr NativeFieldInfoPtr__Out_ProbeOcclusion;

	private static readonly System.IntPtr NativeFieldInfoPtr__Out_SkyOcclusionL0L1;

	private static readonly System.IntPtr NativeFieldInfoPtr__Out_SkyShadingDirectionIndices;

	private static readonly System.IntPtr NativeFieldInfoPtr__Out_L2_0;

	private static readonly System.IntPtr NativeFieldInfoPtr__Out_L2_1;

	private static readonly System.IntPtr NativeFieldInfoPtr__Out_L2_2;

	private static readonly System.IntPtr NativeFieldInfoPtr__Out_L2_3;

	private static readonly System.IntPtr NativeFieldInfoPtr__ProbeVolumeScratchBufferLayout;

	private static readonly System.IntPtr NativeFieldInfoPtr__ProbeVolumeScratchBuffer;

	private static readonly System.IntPtr NativeFieldInfoPtr_kChunkSizeInBricks;

	private static readonly System.IntPtr NativeFieldInfoPtr_kBrickCellCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_kBrickProbeCountPerDim;

	private static readonly System.IntPtr NativeFieldInfoPtr_kBrickProbeCountTotal;

	private static readonly System.IntPtr NativeFieldInfoPtr_kChunkProbeCountPerDim;

	private static readonly System.IntPtr NativeFieldInfoPtr__estimatedVMemCost_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr_kMaxPoolWidth;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Pool;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_NextFreeChunk;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_FreeList;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_AvailableChunkCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_SHBands;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ContainsValidity;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ContainsProbeOcclusion;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ContainsRenderingLayers;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ContainsSkyOcclusion;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ContainsSkyShadingDirection;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_DataUploadCS;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_DataUploadKernel;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_DataUploadL2CS;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_DataUploadL2Kernel;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_DataUpload_Shared;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_DataUpload_ProbeOcclusion;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_DataUpload_SkyOcclusion;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_DataUpload_SkyShadingDirection;

	private static readonly System.IntPtr NativeMethodInfoPtr_DivRoundUp_Internal_Static_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_estimatedVMemCost_Internal_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_estimatedVMemCost_Private_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Internal_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetValidityTexture_Internal_Texture_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSkyOcclusionTexture_Internal_Texture_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSkyShadingDirectionIndicesTexture_Internal_Texture_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetProbeOcclusionTexture_Internal_Texture_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ProbeVolumeTextureMemoryBudget_ProbeVolumeSHBands_Boolean_Boolean_Boolean_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AllocatePool_Internal_Void_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRemainingChunkCount_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnsureTextureValidity_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnsureTextureValidity_Internal_Boolean_Boolean_Boolean_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetChunkSizeInBrickCount_Internal_Static_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetChunkSizeInProbeCount_Internal_Static_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPoolWidth_Internal_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPoolHeight_Internal_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPoolDimensions_Internal_Vector3Int_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRuntimeResources_Internal_Void_byref_RuntimeResources_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Clear_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetChunkCount_Internal_Static_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Allocate_Internal_Boolean_Int32_List_1_BrickChunkAlloc_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Deallocate_Internal_Void_List_1_BrickChunkAlloc_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Update_Internal_Void_DataLocation_List_1_BrickChunkAlloc_List_1_BrickChunkAlloc_Int32_ProbeVolumeSHBands_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Update_Internal_Void_CommandBuffer_CellStreamingScratchBuffer_CellStreamingScratchBufferLayout_List_1_BrickChunkAlloc_Boolean_Texture_ProbeVolumeSHBands_Boolean_Texture_Boolean_Texture_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateValidity_Internal_Void_DataLocation_List_1_BrickChunkAlloc_List_1_BrickChunkAlloc_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ProbeCountToDataLocSize_Internal_Static_Vector3Int_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EstimateMemoryCost_Private_Static_Int32_Int32_Int32_Int32_GraphicsFormat_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EstimateMemoryCostForBlending_Internal_Static_Int32_ProbeVolumeTextureMemoryBudget_Boolean_ProbeVolumeSHBands_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateDataTexture_Public_Static_Texture_Int32_Int32_Int32_GraphicsFormat_String_Boolean_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateDataLocation_Public_Static_DataLocation_Int32_Boolean_ProbeVolumeSHBands_String_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DerivePoolSizeFromBudget_Private_Static_Void_ProbeVolumeTextureMemoryBudget_byref_Int32_byref_Int32_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Cleanup_Internal_Void_0;

	public unsafe static int _Out_L0_L1Rx
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__Out_L0_L1Rx, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__Out_L0_L1Rx, (void*)(&value));
		}
	}

	public unsafe static int _Out_L1G_L1Ry
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__Out_L1G_L1Ry, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__Out_L1G_L1Ry, (void*)(&value));
		}
	}

	public unsafe static int _Out_L1B_L1Rz
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__Out_L1B_L1Rz, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__Out_L1B_L1Rz, (void*)(&value));
		}
	}

	public unsafe static int _Out_Shared
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__Out_Shared, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__Out_Shared, (void*)(&value));
		}
	}

	public unsafe static int _Out_ProbeOcclusion
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__Out_ProbeOcclusion, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__Out_ProbeOcclusion, (void*)(&value));
		}
	}

	public unsafe static int _Out_SkyOcclusionL0L1
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__Out_SkyOcclusionL0L1, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__Out_SkyOcclusionL0L1, (void*)(&value));
		}
	}

	public unsafe static int _Out_SkyShadingDirectionIndices
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__Out_SkyShadingDirectionIndices, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__Out_SkyShadingDirectionIndices, (void*)(&value));
		}
	}

	public unsafe static int _Out_L2_0
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__Out_L2_0, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__Out_L2_0, (void*)(&value));
		}
	}

	public unsafe static int _Out_L2_1
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__Out_L2_1, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__Out_L2_1, (void*)(&value));
		}
	}

	public unsafe static int _Out_L2_2
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__Out_L2_2, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__Out_L2_2, (void*)(&value));
		}
	}

	public unsafe static int _Out_L2_3
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__Out_L2_3, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__Out_L2_3, (void*)(&value));
		}
	}

	public unsafe static int _ProbeVolumeScratchBufferLayout
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__ProbeVolumeScratchBufferLayout, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__ProbeVolumeScratchBufferLayout, (void*)(&value));
		}
	}

	public unsafe static int _ProbeVolumeScratchBuffer
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__ProbeVolumeScratchBuffer, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__ProbeVolumeScratchBuffer, (void*)(&value));
		}
	}

	public unsafe static int kChunkSizeInBricks
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kChunkSizeInBricks, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kChunkSizeInBricks, (void*)(&value));
		}
	}

	public unsafe static int kBrickCellCount
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kBrickCellCount, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kBrickCellCount, (void*)(&value));
		}
	}

	public unsafe static int kBrickProbeCountPerDim
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kBrickProbeCountPerDim, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kBrickProbeCountPerDim, (void*)(&value));
		}
	}

	public unsafe static int kBrickProbeCountTotal
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kBrickProbeCountTotal, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kBrickProbeCountTotal, (void*)(&value));
		}
	}

	public unsafe static int kChunkProbeCountPerDim
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kChunkProbeCountPerDim, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kChunkProbeCountPerDim, (void*)(&value));
		}
	}

	public unsafe int _estimatedVMemCost_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__estimatedVMemCost_k__BackingField);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__estimatedVMemCost_k__BackingField)) = value;
		}
	}

	public unsafe static int kMaxPoolWidth
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kMaxPoolWidth, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kMaxPoolWidth, (void*)(&value));
		}
	}

	public unsafe DataLocation m_Pool
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Pool);
			return new DataLocation(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DataLocation>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Pool), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DataLocation>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe BrickChunkAlloc m_NextFreeChunk
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_NextFreeChunk);
			return *(BrickChunkAlloc*)num;
		}
		set
		{
			*(BrickChunkAlloc*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_NextFreeChunk)) = value;
		}
	}

	public unsafe Stack<BrickChunkAlloc> m_FreeList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_FreeList);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Stack<BrickChunkAlloc>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_FreeList)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe int m_AvailableChunkCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AvailableChunkCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AvailableChunkCount)) = value;
		}
	}

	public unsafe ProbeVolumeSHBands m_SHBands
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SHBands);
			return *(ProbeVolumeSHBands*)num;
		}
		set
		{
			*(ProbeVolumeSHBands*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SHBands)) = value;
		}
	}

	public unsafe bool m_ContainsValidity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ContainsValidity);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ContainsValidity)) = value;
		}
	}

	public unsafe bool m_ContainsProbeOcclusion
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ContainsProbeOcclusion);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ContainsProbeOcclusion)) = value;
		}
	}

	public unsafe bool m_ContainsRenderingLayers
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ContainsRenderingLayers);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ContainsRenderingLayers)) = value;
		}
	}

	public unsafe bool m_ContainsSkyOcclusion
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ContainsSkyOcclusion);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ContainsSkyOcclusion)) = value;
		}
	}

	public unsafe bool m_ContainsSkyShadingDirection
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ContainsSkyShadingDirection);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ContainsSkyShadingDirection)) = value;
		}
	}

	public unsafe static ComputeShader s_DataUploadCS
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_DataUploadCS, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ComputeShader>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_DataUploadCS, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static int s_DataUploadKernel
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_DataUploadKernel, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_DataUploadKernel, (void*)(&value));
		}
	}

	public unsafe static ComputeShader s_DataUploadL2CS
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_DataUploadL2CS, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ComputeShader>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_DataUploadL2CS, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static int s_DataUploadL2Kernel
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_DataUploadL2Kernel, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_DataUploadL2Kernel, (void*)(&value));
		}
	}

	public unsafe static LocalKeyword s_DataUpload_Shared
	{
		get
		{
			System.IntPtr intPtr = (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<LocalKeyword>.NativeClassPtr, ref *(uint*)null)];
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_DataUpload_Shared, (void*)intPtr);
			return new LocalKeyword(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LocalKeyword>.NativeClassPtr, intPtr));
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_DataUpload_Shared, (void*)IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value)));
		}
	}

	public unsafe static LocalKeyword s_DataUpload_ProbeOcclusion
	{
		get
		{
			System.IntPtr intPtr = (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<LocalKeyword>.NativeClassPtr, ref *(uint*)null)];
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_DataUpload_ProbeOcclusion, (void*)intPtr);
			return new LocalKeyword(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LocalKeyword>.NativeClassPtr, intPtr));
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_DataUpload_ProbeOcclusion, (void*)IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value)));
		}
	}

	public unsafe static LocalKeyword s_DataUpload_SkyOcclusion
	{
		get
		{
			System.IntPtr intPtr = (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<LocalKeyword>.NativeClassPtr, ref *(uint*)null)];
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_DataUpload_SkyOcclusion, (void*)intPtr);
			return new LocalKeyword(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LocalKeyword>.NativeClassPtr, intPtr));
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_DataUpload_SkyOcclusion, (void*)IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value)));
		}
	}

	public unsafe static LocalKeyword s_DataUpload_SkyShadingDirection
	{
		get
		{
			System.IntPtr intPtr = (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<LocalKeyword>.NativeClassPtr, ref *(uint*)null)];
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_DataUpload_SkyShadingDirection, (void*)intPtr);
			return new LocalKeyword(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LocalKeyword>.NativeClassPtr, intPtr));
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_DataUpload_SkyShadingDirection, (void*)IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value)));
		}
	}

	public unsafe int estimatedVMemCost
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 50668, RefRangeEnd = 50669, XrefRangeStart = 50668, XrefRangeEnd = 50669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_estimatedVMemCost_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 86468, RefRangeEnd = 86476, XrefRangeStart = 86468, XrefRangeEnd = 86476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_estimatedVMemCost_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	static ProbeBrickPool()
	{
		Il2CppClassPointerStore<ProbeBrickPool>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "ProbeBrickPool");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProbeBrickPool>.NativeClassPtr);
		NativeFieldInfoPtr__Out_L0_L1Rx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickPool>.NativeClassPtr, "_Out_L0_L1Rx");
		NativeFieldInfoPtr__Out_L1G_L1Ry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickPool>.NativeClassPtr, "_Out_L1G_L1Ry");
		NativeFieldInfoPtr__Out_L1B_L1Rz = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickPool>.NativeClassPtr, "_Out_L1B_L1Rz");
		NativeFieldInfoPtr__Out_Shared = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickPool>.NativeClassPtr, "_Out_Shared");
		NativeFieldInfoPtr__Out_ProbeOcclusion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickPool>.NativeClassPtr, "_Out_ProbeOcclusion");
		NativeFieldInfoPtr__Out_SkyOcclusionL0L1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickPool>.NativeClassPtr, "_Out_SkyOcclusionL0L1");
		NativeFieldInfoPtr__Out_SkyShadingDirectionIndices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickPool>.NativeClassPtr, "_Out_SkyShadingDirectionIndices");
		NativeFieldInfoPtr__Out_L2_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickPool>.NativeClassPtr, "_Out_L2_0");
		NativeFieldInfoPtr__Out_L2_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickPool>.NativeClassPtr, "_Out_L2_1");
		NativeFieldInfoPtr__Out_L2_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickPool>.NativeClassPtr, "_Out_L2_2");
		NativeFieldInfoPtr__Out_L2_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickPool>.NativeClassPtr, "_Out_L2_3");
		NativeFieldInfoPtr__ProbeVolumeScratchBufferLayout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickPool>.NativeClassPtr, "_ProbeVolumeScratchBufferLayout");
		NativeFieldInfoPtr__ProbeVolumeScratchBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickPool>.NativeClassPtr, "_ProbeVolumeScratchBuffer");
		NativeFieldInfoPtr_kChunkSizeInBricks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickPool>.NativeClassPtr, "kChunkSizeInBricks");
		NativeFieldInfoPtr_kBrickCellCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickPool>.NativeClassPtr, "kBrickCellCount");
		NativeFieldInfoPtr_kBrickProbeCountPerDim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickPool>.NativeClassPtr, "kBrickProbeCountPerDim");
		NativeFieldInfoPtr_kBrickProbeCountTotal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickPool>.NativeClassPtr, "kBrickProbeCountTotal");
		NativeFieldInfoPtr_kChunkProbeCountPerDim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickPool>.NativeClassPtr, "kChunkProbeCountPerDim");
		NativeFieldInfoPtr__estimatedVMemCost_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickPool>.NativeClassPtr, "<estimatedVMemCost>k__BackingField");
		NativeFieldInfoPtr_kMaxPoolWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickPool>.NativeClassPtr, "kMaxPoolWidth");
		NativeFieldInfoPtr_m_Pool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickPool>.NativeClassPtr, "m_Pool");
		NativeFieldInfoPtr_m_NextFreeChunk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickPool>.NativeClassPtr, "m_NextFreeChunk");
		NativeFieldInfoPtr_m_FreeList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickPool>.NativeClassPtr, "m_FreeList");
		NativeFieldInfoPtr_m_AvailableChunkCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickPool>.NativeClassPtr, "m_AvailableChunkCount");
		NativeFieldInfoPtr_m_SHBands = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickPool>.NativeClassPtr, "m_SHBands");
		NativeFieldInfoPtr_m_ContainsValidity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickPool>.NativeClassPtr, "m_ContainsValidity");
		NativeFieldInfoPtr_m_ContainsProbeOcclusion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickPool>.NativeClassPtr, "m_ContainsProbeOcclusion");
		NativeFieldInfoPtr_m_ContainsRenderingLayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickPool>.NativeClassPtr, "m_ContainsRenderingLayers");
		NativeFieldInfoPtr_m_ContainsSkyOcclusion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickPool>.NativeClassPtr, "m_ContainsSkyOcclusion");
		NativeFieldInfoPtr_m_ContainsSkyShadingDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickPool>.NativeClassPtr, "m_ContainsSkyShadingDirection");
		NativeFieldInfoPtr_s_DataUploadCS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickPool>.NativeClassPtr, "s_DataUploadCS");
		NativeFieldInfoPtr_s_DataUploadKernel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickPool>.NativeClassPtr, "s_DataUploadKernel");
		NativeFieldInfoPtr_s_DataUploadL2CS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickPool>.NativeClassPtr, "s_DataUploadL2CS");
		NativeFieldInfoPtr_s_DataUploadL2Kernel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickPool>.NativeClassPtr, "s_DataUploadL2Kernel");
		NativeFieldInfoPtr_s_DataUpload_Shared = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickPool>.NativeClassPtr, "s_DataUpload_Shared");
		NativeFieldInfoPtr_s_DataUpload_ProbeOcclusion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickPool>.NativeClassPtr, "s_DataUpload_ProbeOcclusion");
		NativeFieldInfoPtr_s_DataUpload_SkyOcclusion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickPool>.NativeClassPtr, "s_DataUpload_SkyOcclusion");
		NativeFieldInfoPtr_s_DataUpload_SkyShadingDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeBrickPool>.NativeClassPtr, "s_DataUpload_SkyShadingDirection");
		NativeMethodInfoPtr_DivRoundUp_Internal_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeBrickPool>.NativeClassPtr, 100665299);
		NativeMethodInfoPtr_get_estimatedVMemCost_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeBrickPool>.NativeClassPtr, 100665300);
		NativeMethodInfoPtr_set_estimatedVMemCost_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeBrickPool>.NativeClassPtr, 100665301);
		NativeMethodInfoPtr_Initialize_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeBrickPool>.NativeClassPtr, 100665302);
		NativeMethodInfoPtr_GetValidityTexture_Internal_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeBrickPool>.NativeClassPtr, 100665303);
		NativeMethodInfoPtr_GetSkyOcclusionTexture_Internal_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeBrickPool>.NativeClassPtr, 100665304);
		NativeMethodInfoPtr_GetSkyShadingDirectionIndicesTexture_Internal_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeBrickPool>.NativeClassPtr, 100665305);
		NativeMethodInfoPtr_GetProbeOcclusionTexture_Internal_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeBrickPool>.NativeClassPtr, 100665306);
		NativeMethodInfoPtr__ctor_Internal_Void_ProbeVolumeTextureMemoryBudget_ProbeVolumeSHBands_Boolean_Boolean_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeBrickPool>.NativeClassPtr, 100665307);
		NativeMethodInfoPtr_AllocatePool_Internal_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeBrickPool>.NativeClassPtr, 100665308);
		NativeMethodInfoPtr_GetRemainingChunkCount_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeBrickPool>.NativeClassPtr, 100665309);
		NativeMethodInfoPtr_EnsureTextureValidity_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeBrickPool>.NativeClassPtr, 100665310);
		NativeMethodInfoPtr_EnsureTextureValidity_Internal_Boolean_Boolean_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeBrickPool>.NativeClassPtr, 100665311);
		NativeMethodInfoPtr_GetChunkSizeInBrickCount_Internal_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeBrickPool>.NativeClassPtr, 100665312);
		NativeMethodInfoPtr_GetChunkSizeInProbeCount_Internal_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeBrickPool>.NativeClassPtr, 100665313);
		NativeMethodInfoPtr_GetPoolWidth_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeBrickPool>.NativeClassPtr, 100665314);
		NativeMethodInfoPtr_GetPoolHeight_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeBrickPool>.NativeClassPtr, 100665315);
		NativeMethodInfoPtr_GetPoolDimensions_Internal_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeBrickPool>.NativeClassPtr, 100665316);
		NativeMethodInfoPtr_GetRuntimeResources_Internal_Void_byref_RuntimeResources_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeBrickPool>.NativeClassPtr, 100665317);
		NativeMethodInfoPtr_Clear_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeBrickPool>.NativeClassPtr, 100665318);
		NativeMethodInfoPtr_GetChunkCount_Internal_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeBrickPool>.NativeClassPtr, 100665319);
		NativeMethodInfoPtr_Allocate_Internal_Boolean_Int32_List_1_BrickChunkAlloc_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeBrickPool>.NativeClassPtr, 100665320);
		NativeMethodInfoPtr_Deallocate_Internal_Void_List_1_BrickChunkAlloc_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeBrickPool>.NativeClassPtr, 100665321);
		NativeMethodInfoPtr_Update_Internal_Void_DataLocation_List_1_BrickChunkAlloc_List_1_BrickChunkAlloc_Int32_ProbeVolumeSHBands_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeBrickPool>.NativeClassPtr, 100665322);
		NativeMethodInfoPtr_Update_Internal_Void_CommandBuffer_CellStreamingScratchBuffer_CellStreamingScratchBufferLayout_List_1_BrickChunkAlloc_Boolean_Texture_ProbeVolumeSHBands_Boolean_Texture_Boolean_Texture_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeBrickPool>.NativeClassPtr, 100665323);
		NativeMethodInfoPtr_UpdateValidity_Internal_Void_DataLocation_List_1_BrickChunkAlloc_List_1_BrickChunkAlloc_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeBrickPool>.NativeClassPtr, 100665324);
		NativeMethodInfoPtr_ProbeCountToDataLocSize_Internal_Static_Vector3Int_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeBrickPool>.NativeClassPtr, 100665325);
		NativeMethodInfoPtr_EstimateMemoryCost_Private_Static_Int32_Int32_Int32_Int32_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeBrickPool>.NativeClassPtr, 100665326);
		NativeMethodInfoPtr_EstimateMemoryCostForBlending_Internal_Static_Int32_ProbeVolumeTextureMemoryBudget_Boolean_ProbeVolumeSHBands_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeBrickPool>.NativeClassPtr, 100665327);
		NativeMethodInfoPtr_CreateDataTexture_Public_Static_Texture_Int32_Int32_Int32_GraphicsFormat_String_Boolean_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeBrickPool>.NativeClassPtr, 100665328);
		NativeMethodInfoPtr_CreateDataLocation_Public_Static_DataLocation_Int32_Boolean_ProbeVolumeSHBands_String_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeBrickPool>.NativeClassPtr, 100665329);
		NativeMethodInfoPtr_DerivePoolSizeFromBudget_Private_Static_Void_ProbeVolumeTextureMemoryBudget_byref_Int32_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeBrickPool>.NativeClassPtr, 100665330);
		NativeMethodInfoPtr_Cleanup_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeBrickPool>.NativeClassPtr, 100665331);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 1037843, RefRangeEnd = 1037851, XrefRangeStart = 1037843, XrefRangeEnd = 1037843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1037944, RefRangeEnd = 1037945, XrefRangeStart = 1037851, XrefRangeEnd = 1037944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Initialize()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_Internal_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 84632, RefRangeEnd = 84633, XrefRangeStart = 84632, XrefRangeEnd = 84633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Texture GetValidityTexture()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetValidityTexture_Internal_Texture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Texture>(intPtr2) : null;
	}

	[CallerCount(45)]
	[CachedScanResults(RefRangeStart = 162634, RefRangeEnd = 162679, XrefRangeStart = 162634, XrefRangeEnd = 162679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Texture GetSkyOcclusionTexture()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSkyOcclusionTexture_Internal_Texture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Texture>(intPtr2) : null;
	}

	[CallerCount(17)]
	[CachedScanResults(RefRangeStart = 140862, RefRangeEnd = 140879, XrefRangeStart = 140862, XrefRangeEnd = 140879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Texture GetSkyShadingDirectionIndicesTexture()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSkyShadingDirectionIndicesTexture_Internal_Texture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Texture>(intPtr2) : null;
	}

	[CallerCount(0)]
	public unsafe Texture GetProbeOcclusionTexture()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetProbeOcclusionTexture_Internal_Texture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Texture>(intPtr2) : null;
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1037957, RefRangeEnd = 1037962, XrefRangeStart = 1037945, XrefRangeEnd = 1037957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ProbeBrickPool(ProbeVolumeTextureMemoryBudget memoryBudget, ProbeVolumeSHBands shBands, bool allocateValidityData = false, bool allocateRenderingLayerData = false, bool allocateSkyOcclusion = false, bool allocateSkyShadingData = false, bool allocateProbeOcclusionData = false)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProbeBrickPool>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = (nint)(&memoryBudget);
		*(ProbeVolumeSHBands**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &shBands;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &allocateValidityData;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &allocateRenderingLayerData;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &allocateSkyOcclusion;
		*(bool**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &allocateSkyShadingData;
		*(bool**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &allocateProbeOcclusionData;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_ProbeVolumeTextureMemoryBudget_ProbeVolumeSHBands_Boolean_Boolean_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1037969, RefRangeEnd = 1037972, XrefRangeStart = 1037962, XrefRangeEnd = 1037969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AllocatePool(int width, int height, int depth)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&width);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &height;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &depth;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AllocatePool_Internal_Void_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe int GetRemainingChunkCount()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRemainingChunkCount_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1037978, RefRangeEnd = 1037981, XrefRangeStart = 1037972, XrefRangeEnd = 1037978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EnsureTextureValidity()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnsureTextureValidity_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1037984, RefRangeEnd = 1037985, XrefRangeStart = 1037981, XrefRangeEnd = 1037984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool EnsureTextureValidity(bool renderingLayers, bool skyOcclusion, bool skyDirection, bool probeOcclusion)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&renderingLayers);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &skyOcclusion;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &skyDirection;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &probeOcclusion;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnsureTextureValidity_Internal_Boolean_Boolean_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 1037985, RefRangeEnd = 1037992, XrefRangeStart = 1037985, XrefRangeEnd = 1037985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetChunkSizeInBrickCount()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetChunkSizeInBrickCount_Internal_Static_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1037992, RefRangeEnd = 1037996, XrefRangeStart = 1037992, XrefRangeEnd = 1037992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetChunkSizeInProbeCount()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetChunkSizeInProbeCount_Internal_Static_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 42195, RefRangeEnd = 42198, XrefRangeStart = 42195, XrefRangeEnd = 42198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetPoolWidth()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPoolWidth_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 33830, RefRangeEnd = 33833, XrefRangeStart = 33830, XrefRangeEnd = 33833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetPoolHeight()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPoolHeight_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1037996, RefRangeEnd = 1037997, XrefRangeStart = 1037996, XrefRangeEnd = 1037996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3Int GetPoolDimensions()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPoolDimensions_Internal_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Vector3Int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1038042, RefRangeEnd = 1038044, XrefRangeStart = 1037997, XrefRangeEnd = 1038042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetRuntimeResources(ref ProbeReferenceVolume.RuntimeResources rr)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)rr);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRuntimeResources_Internal_Void_byref_RuntimeResources_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1038047, RefRangeEnd = 1038048, XrefRangeStart = 1038044, XrefRangeEnd = 1038047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Clear()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Clear_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1038048, RefRangeEnd = 1038050, XrefRangeStart = 1038048, XrefRangeEnd = 1038048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetChunkCount(int brickCount)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&brickCount);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetChunkCount_Internal_Static_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1038064, RefRangeEnd = 1038067, XrefRangeStart = 1038050, XrefRangeEnd = 1038064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Allocate(int numberOfBrickChunks, List<BrickChunkAlloc> outAllocations, bool ignoreErrorLog)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&numberOfBrickChunks);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)outAllocations);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &ignoreErrorLog;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Allocate_Internal_Boolean_Int32_List_1_BrickChunkAlloc_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 1038085, RefRangeEnd = 1038094, XrefRangeStart = 1038067, XrefRangeEnd = 1038085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Deallocate(List<BrickChunkAlloc> allocations)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)allocations);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Deallocate_Internal_Void_List_1_BrickChunkAlloc_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1038125, RefRangeEnd = 1038126, XrefRangeStart = 1038094, XrefRangeEnd = 1038125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update(DataLocation source, List<BrickChunkAlloc> srcLocations, List<BrickChunkAlloc> dstLocations, int destStartIndex, ProbeVolumeSHBands bands)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)source));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)srcLocations);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dstLocations);
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &destStartIndex;
		*(ProbeVolumeSHBands**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &bands;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Internal_Void_DataLocation_List_1_BrickChunkAlloc_List_1_BrickChunkAlloc_Int32_ProbeVolumeSHBands_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1038227, RefRangeEnd = 1038228, XrefRangeStart = 1038126, XrefRangeEnd = 1038227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update(CommandBuffer cmd, ProbeReferenceVolume.CellStreamingScratchBuffer dataBuffer, ProbeReferenceVolume.CellStreamingScratchBufferLayout layout, List<BrickChunkAlloc> dstLocations, bool updateSharedData, Texture validityTexture, ProbeVolumeSHBands bands, bool skyOcclusion, Texture skyOcclusionTexture, bool skyShadingDirections, Texture skyShadingDirectionsTexture, bool probeOcclusion)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[12];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dataBuffer);
		*(ProbeReferenceVolume.CellStreamingScratchBufferLayout**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &layout;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dstLocations);
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &updateSharedData;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)validityTexture);
		*(ProbeVolumeSHBands**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &bands;
		*(bool**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &skyOcclusion;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)skyOcclusionTexture);
		*(bool**)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = &skyShadingDirections;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)10u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)skyShadingDirectionsTexture);
		*(bool**)((byte*)ptr + checked((nuint)11u * unchecked((nuint)sizeof(System.IntPtr)))) = &probeOcclusion;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Internal_Void_CommandBuffer_CellStreamingScratchBuffer_CellStreamingScratchBufferLayout_List_1_BrickChunkAlloc_Boolean_Texture_ProbeVolumeSHBands_Boolean_Texture_Boolean_Texture_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1038239, RefRangeEnd = 1038240, XrefRangeStart = 1038228, XrefRangeEnd = 1038239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateValidity(DataLocation source, List<BrickChunkAlloc> srcLocations, List<BrickChunkAlloc> dstLocations, int destStartIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)source));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)srcLocations);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dstLocations);
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &destStartIndex;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateValidity_Internal_Void_DataLocation_List_1_BrickChunkAlloc_List_1_BrickChunkAlloc_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1038241, RefRangeEnd = 1038242, XrefRangeStart = 1038240, XrefRangeEnd = 1038241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector3Int ProbeCountToDataLocSize(int numProbes)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&numProbes);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ProbeCountToDataLocSize_Internal_Static_Vector3Int_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Vector3Int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static int EstimateMemoryCost(int width, int height, int depth, GraphicsFormat format)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&width);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &height;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &depth;
		*(GraphicsFormat**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &format;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EstimateMemoryCost_Private_Static_Int32_Int32_Int32_Int32_GraphicsFormat_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1038242, XrefRangeEnd = 1038250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int EstimateMemoryCostForBlending(ProbeVolumeTextureMemoryBudget memoryBudget, bool compressed, ProbeVolumeSHBands bands)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&memoryBudget);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &compressed;
		*(ProbeVolumeSHBands**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &bands;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EstimateMemoryCostForBlending_Internal_Static_Int32_ProbeVolumeTextureMemoryBudget_Boolean_ProbeVolumeSHBands_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(11)]
	[CachedScanResults(RefRangeStart = 1038270, RefRangeEnd = 1038281, XrefRangeStart = 1038250, XrefRangeEnd = 1038270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Texture CreateDataTexture(int width, int height, int depth, GraphicsFormat format, string name, bool allocateRendertexture, ref int allocatedBytes)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = (nint)(&width);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &height;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &depth;
		*(GraphicsFormat**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &format;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(name);
		*(bool**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &allocateRendertexture;
		*(void**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref allocatedBytes);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateDataTexture_Public_Static_Texture_Int32_Int32_Int32_GraphicsFormat_String_Boolean_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Texture>(intPtr2) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1038362, RefRangeEnd = 1038365, XrefRangeStart = 1038281, XrefRangeEnd = 1038362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static DataLocation CreateDataLocation(int numProbes, bool compressed, ProbeVolumeSHBands bands, string name, bool allocateRendertexture, bool allocateValidityData, bool allocateRenderingLayers, bool allocateSkyOcclusionData, bool allocateSkyShadingDirectionData, bool allocateProbeOcclusionData, out int allocatedBytes)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[11];
		*ptr = (nint)(&numProbes);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &compressed;
		*(ProbeVolumeSHBands**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &bands;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(name);
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &allocateRendertexture;
		*(bool**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &allocateValidityData;
		*(bool**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &allocateRenderingLayers;
		*(bool**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &allocateSkyOcclusionData;
		*(bool**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = &allocateSkyShadingDirectionData;
		*(bool**)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = &allocateProbeOcclusionData;
		*(void**)((byte*)ptr + checked((nuint)10u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref allocatedBytes);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateDataLocation_Public_Static_DataLocation_Int32_Boolean_ProbeVolumeSHBands_String_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new DataLocation(pointer);
	}

	[CallerCount(0)]
	public unsafe static void DerivePoolSizeFromBudget(ProbeVolumeTextureMemoryBudget memoryBudget, out int width, out int height, out int depth)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&memoryBudget);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref width);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref height);
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref depth);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DerivePoolSizeFromBudget_Private_Static_Void_ProbeVolumeTextureMemoryBudget_byref_Int32_byref_Int32_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1038366, RefRangeEnd = 1038367, XrefRangeStart = 1038365, XrefRangeEnd = 1038366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Cleanup()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Cleanup_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public ProbeBrickPool(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
