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

public sealed class OccluderContext : Il2CppSystem.ValueType
{
	public static class ShaderIDs : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr__SrcDepth;

		private static readonly System.IntPtr NativeFieldInfoPtr__DstDepth;

		private static readonly System.IntPtr NativeFieldInfoPtr_OccluderDepthPyramidConstants;

		public unsafe static int _SrcDepth
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__SrcDepth, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__SrcDepth, (void*)(&value));
			}
		}

		public unsafe static int _DstDepth
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__DstDepth, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__DstDepth, (void*)(&value));
			}
		}

		public unsafe static int OccluderDepthPyramidConstants
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_OccluderDepthPyramidConstants, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_OccluderDepthPyramidConstants, (void*)(&value));
			}
		}

		static ShaderIDs()
		{
			Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OccluderContext>.NativeClassPtr, "ShaderIDs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr);
			NativeFieldInfoPtr__SrcDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "_SrcDepth");
			NativeFieldInfoPtr__DstDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "_DstDepth");
			NativeFieldInfoPtr_OccluderDepthPyramidConstants = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "OccluderDepthPyramidConstants");
		}

		public ShaderIDs(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_version;

	private static readonly System.IntPtr NativeFieldInfoPtr_depthBufferSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_subviewData;

	private static readonly System.IntPtr NativeFieldInfoPtr_subviewValidMask;

	private static readonly System.IntPtr NativeFieldInfoPtr_occluderMipBounds;

	private static readonly System.IntPtr NativeFieldInfoPtr_occluderMipLayoutSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_occluderDepthPyramidSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_occluderDepthPyramid;

	private static readonly System.IntPtr NativeFieldInfoPtr_occlusionDebugOverlaySize;

	private static readonly System.IntPtr NativeFieldInfoPtr_occlusionDebugOverlay;

	private static readonly System.IntPtr NativeFieldInfoPtr_debugNeedsClear;

	private static readonly System.IntPtr NativeFieldInfoPtr_constantBuffer;

	private static readonly System.IntPtr NativeFieldInfoPtr_constantBufferData;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_subviewCount_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsSubviewValid_Public_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_depthBufferSizeInOccluderPixels_Public_get_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateMipBounds_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AllocateTexturesIfNecessary_Private_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetKeyword_Internal_Static_Void_ComputeCommandBuffer_ComputeShader_byref_LocalKeyword_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupFarDepthPyramidConstants_Private_OccluderDepthPyramidConstants_ReadOnlySpan_1_OccluderSubviewUpdate_NativeArray_1_Plane_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateFarDepthPyramid_Public_Void_ComputeCommandBuffer_byref_OccluderParameters_ReadOnlySpan_1_OccluderSubviewUpdate_byref_OccluderHandles_NativeArray_1_Plane_ComputeShader_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Import_Public_OccluderHandles_RenderGraph_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PrepareOccluders_Public_Void_byref_OccluderParameters_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDebugOutput_Internal_OcclusionCullingDebugOutput_0;

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

	public unsafe Vector2Int depthBufferSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_depthBufferSize);
			return *(Vector2Int*)num;
		}
		set
		{
			*(Vector2Int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_depthBufferSize)) = value;
		}
	}

	public unsafe NativeArray<OccluderDerivedData> subviewData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_subviewData);
			return new NativeArray<OccluderDerivedData>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<OccluderDerivedData>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_subviewData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<OccluderDerivedData>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe int subviewValidMask
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_subviewValidMask);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_subviewValidMask)) = value;
		}
	}

	public unsafe NativeArray<OccluderMipBounds> occluderMipBounds
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_occluderMipBounds);
			return new NativeArray<OccluderMipBounds>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<OccluderMipBounds>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_occluderMipBounds), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<OccluderMipBounds>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe Vector2Int occluderMipLayoutSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_occluderMipLayoutSize);
			return *(Vector2Int*)num;
		}
		set
		{
			*(Vector2Int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_occluderMipLayoutSize)) = value;
		}
	}

	public unsafe Vector2Int occluderDepthPyramidSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_occluderDepthPyramidSize);
			return *(Vector2Int*)num;
		}
		set
		{
			*(Vector2Int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_occluderDepthPyramidSize)) = value;
		}
	}

	public unsafe RTHandle occluderDepthPyramid
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_occluderDepthPyramid);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RTHandle>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_occluderDepthPyramid)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe int occlusionDebugOverlaySize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_occlusionDebugOverlaySize);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_occlusionDebugOverlaySize)) = value;
		}
	}

	public unsafe GraphicsBuffer occlusionDebugOverlay
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_occlusionDebugOverlay);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GraphicsBuffer>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_occlusionDebugOverlay)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe bool debugNeedsClear
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugNeedsClear);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugNeedsClear)) = value;
		}
	}

	public unsafe ComputeBuffer constantBuffer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_constantBuffer);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ComputeBuffer>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_constantBuffer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe NativeArray<OccluderDepthPyramidConstants> constantBufferData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_constantBufferData);
			return new NativeArray<OccluderDepthPyramidConstants>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<OccluderDepthPyramidConstants>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_constantBufferData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<OccluderDepthPyramidConstants>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe int subviewCount
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 54510, RefRangeEnd = 54511, XrefRangeStart = 54510, XrefRangeEnd = 54511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_subviewCount_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe Vector2 depthBufferSizeInOccluderPixels
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_depthBufferSizeInOccluderPixels_Public_get_Vector2_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static OccluderContext()
	{
		Il2CppClassPointerStore<OccluderContext>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.GPUDriven.Runtime.dll", "UnityEngine.Rendering", "OccluderContext");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OccluderContext>.NativeClassPtr);
		NativeFieldInfoPtr_version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OccluderContext>.NativeClassPtr, "version");
		NativeFieldInfoPtr_depthBufferSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OccluderContext>.NativeClassPtr, "depthBufferSize");
		NativeFieldInfoPtr_subviewData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OccluderContext>.NativeClassPtr, "subviewData");
		NativeFieldInfoPtr_subviewValidMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OccluderContext>.NativeClassPtr, "subviewValidMask");
		NativeFieldInfoPtr_occluderMipBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OccluderContext>.NativeClassPtr, "occluderMipBounds");
		NativeFieldInfoPtr_occluderMipLayoutSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OccluderContext>.NativeClassPtr, "occluderMipLayoutSize");
		NativeFieldInfoPtr_occluderDepthPyramidSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OccluderContext>.NativeClassPtr, "occluderDepthPyramidSize");
		NativeFieldInfoPtr_occluderDepthPyramid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OccluderContext>.NativeClassPtr, "occluderDepthPyramid");
		NativeFieldInfoPtr_occlusionDebugOverlaySize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OccluderContext>.NativeClassPtr, "occlusionDebugOverlaySize");
		NativeFieldInfoPtr_occlusionDebugOverlay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OccluderContext>.NativeClassPtr, "occlusionDebugOverlay");
		NativeFieldInfoPtr_debugNeedsClear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OccluderContext>.NativeClassPtr, "debugNeedsClear");
		NativeFieldInfoPtr_constantBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OccluderContext>.NativeClassPtr, "constantBuffer");
		NativeFieldInfoPtr_constantBufferData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OccluderContext>.NativeClassPtr, "constantBufferData");
		NativeMethodInfoPtr_get_subviewCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OccluderContext>.NativeClassPtr, 100663898);
		NativeMethodInfoPtr_IsSubviewValid_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OccluderContext>.NativeClassPtr, 100663899);
		NativeMethodInfoPtr_get_depthBufferSizeInOccluderPixels_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OccluderContext>.NativeClassPtr, 100663900);
		NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OccluderContext>.NativeClassPtr, 100663901);
		NativeMethodInfoPtr_UpdateMipBounds_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OccluderContext>.NativeClassPtr, 100663902);
		NativeMethodInfoPtr_AllocateTexturesIfNecessary_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OccluderContext>.NativeClassPtr, 100663903);
		NativeMethodInfoPtr_SetKeyword_Internal_Static_Void_ComputeCommandBuffer_ComputeShader_byref_LocalKeyword_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OccluderContext>.NativeClassPtr, 100663904);
		NativeMethodInfoPtr_SetupFarDepthPyramidConstants_Private_OccluderDepthPyramidConstants_ReadOnlySpan_1_OccluderSubviewUpdate_NativeArray_1_Plane_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OccluderContext>.NativeClassPtr, 100663905);
		NativeMethodInfoPtr_CreateFarDepthPyramid_Public_Void_ComputeCommandBuffer_byref_OccluderParameters_ReadOnlySpan_1_OccluderSubviewUpdate_byref_OccluderHandles_NativeArray_1_Plane_ComputeShader_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OccluderContext>.NativeClassPtr, 100663906);
		NativeMethodInfoPtr_Import_Public_OccluderHandles_RenderGraph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OccluderContext>.NativeClassPtr, 100663907);
		NativeMethodInfoPtr_PrepareOccluders_Public_Void_byref_OccluderParameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OccluderContext>.NativeClassPtr, 100663908);
		NativeMethodInfoPtr_GetDebugOutput_Internal_OcclusionCullingDebugOutput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OccluderContext>.NativeClassPtr, 100663909);
	}

	[CallerCount(0)]
	public unsafe bool IsSubviewValid(int subviewIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&subviewIndex);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsSubviewValid_Public_Boolean_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1073680, RefRangeEnd = 1073682, XrefRangeStart = 1073662, XrefRangeEnd = 1073680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Dispose()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1073692, RefRangeEnd = 1073693, XrefRangeStart = 1073682, XrefRangeEnd = 1073692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateMipBounds()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateMipBounds_Private_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1073720, RefRangeEnd = 1073721, XrefRangeStart = 1073693, XrefRangeEnd = 1073720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AllocateTexturesIfNecessary(bool debugOverlayEnabled)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&debugOverlayEnabled);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AllocateTexturesIfNecessary_Private_Void_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1073724, RefRangeEnd = 1073726, XrefRangeStart = 1073721, XrefRangeEnd = 1073724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetKeyword(ComputeCommandBuffer cmd, ComputeShader cs, [In] ref LocalKeyword keyword, bool value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cs);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)keyword);
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetKeyword_Internal_Static_Void_ComputeCommandBuffer_ComputeShader_byref_LocalKeyword_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1073737, RefRangeEnd = 1073738, XrefRangeStart = 1073726, XrefRangeEnd = 1073737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe OccluderDepthPyramidConstants SetupFarDepthPyramidConstants(Il2CppSystem.ReadOnlySpan<OccluderSubviewUpdate> occluderSubviewUpdates, NativeArray<Plane> silhouettePlanes)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)occluderSubviewUpdates));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)silhouettePlanes));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupFarDepthPyramidConstants_Private_OccluderDepthPyramidConstants_ReadOnlySpan_1_OccluderSubviewUpdate_NativeArray_1_Plane_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(OccluderDepthPyramidConstants*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1073788, RefRangeEnd = 1073789, XrefRangeStart = 1073738, XrefRangeEnd = 1073788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CreateFarDepthPyramid(ComputeCommandBuffer cmd, [In] ref OccluderParameters occluderParams, Il2CppSystem.ReadOnlySpan<OccluderSubviewUpdate> occluderSubviewUpdates, [In] ref OccluderHandles occluderHandles, NativeArray<Plane> silhouettePlanes, ComputeShader occluderDepthPyramidCS, int occluderDepthDownscaleKernel)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref occluderParams);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)occluderSubviewUpdates));
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref occluderHandles);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)silhouettePlanes));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)occluderDepthPyramidCS);
		*(int**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &occluderDepthDownscaleKernel;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateFarDepthPyramid_Public_Void_ComputeCommandBuffer_byref_OccluderParameters_ReadOnlySpan_1_OccluderSubviewUpdate_byref_OccluderHandles_NativeArray_1_Plane_ComputeShader_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1073791, RefRangeEnd = 1073794, XrefRangeStart = 1073789, XrefRangeEnd = 1073791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe OccluderHandles Import(RenderGraph renderGraph)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderGraph);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Import_Public_OccluderHandles_RenderGraph_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(OccluderHandles*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1073804, RefRangeEnd = 1073806, XrefRangeStart = 1073794, XrefRangeEnd = 1073804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PrepareOccluders([In] ref OccluderParameters occluderParams)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref occluderParams);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PrepareOccluders_Public_Void_byref_OccluderParameters_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1073810, RefRangeEnd = 1073811, XrefRangeStart = 1073806, XrefRangeEnd = 1073810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe OcclusionCullingDebugOutput GetDebugOutput()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDebugOutput_Internal_OcclusionCullingDebugOutput_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new OcclusionCullingDebugOutput(pointer);
	}

	public OccluderContext(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public OccluderContext()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OccluderContext>.NativeClassPtr))
	{
	}
}
