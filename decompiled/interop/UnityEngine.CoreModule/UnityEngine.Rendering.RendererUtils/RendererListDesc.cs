using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.RendererUtils;

public sealed class RendererListDesc : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_sortingCriteria;

	private static readonly System.IntPtr NativeFieldInfoPtr_rendererConfiguration;

	private static readonly System.IntPtr NativeFieldInfoPtr_renderQueueRange;

	private static readonly System.IntPtr NativeFieldInfoPtr_stateBlock;

	private static readonly System.IntPtr NativeFieldInfoPtr_overrideShader;

	private static readonly System.IntPtr NativeFieldInfoPtr_overrideMaterial;

	private static readonly System.IntPtr NativeFieldInfoPtr_excludeObjectMotionVectors;

	private static readonly System.IntPtr NativeFieldInfoPtr_layerMask;

	private static readonly System.IntPtr NativeFieldInfoPtr_renderingLayerMask;

	private static readonly System.IntPtr NativeFieldInfoPtr__batchLayerMask_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr_overrideMaterialPassIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_overrideShaderPassIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr__cullingResult_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__camera_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__passName_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__passNames_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_EmptyName;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_batchLayerMask_Public_get_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_cullingResult_Internal_get_CullingResults_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_camera_Internal_get_Camera_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_passName_Internal_get_ShaderTagId_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_passNames_Internal_get_Il2CppStructArray_1_ShaderTagId_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsValid_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ConvertToParameters_Public_Static_RendererListParams_byref_RendererListDesc_0;

	public unsafe SortingCriteria sortingCriteria
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sortingCriteria);
			return *(SortingCriteria*)num;
		}
		set
		{
			*(SortingCriteria*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sortingCriteria)) = value;
		}
	}

	public unsafe PerObjectData rendererConfiguration
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rendererConfiguration);
			return *(PerObjectData*)num;
		}
		set
		{
			*(PerObjectData*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rendererConfiguration)) = value;
		}
	}

	public unsafe RenderQueueRange renderQueueRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_renderQueueRange);
			return *(RenderQueueRange*)num;
		}
		set
		{
			*(RenderQueueRange*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_renderQueueRange)) = value;
		}
	}

	public unsafe Il2CppSystem.Nullable<RenderStateBlock> stateBlock
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stateBlock);
			return new Il2CppSystem.Nullable<RenderStateBlock>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Nullable<RenderStateBlock>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stateBlock), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Nullable<RenderStateBlock>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe Shader overrideShader
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideShader);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Shader>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideShader)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Material overrideMaterial
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideMaterial);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideMaterial)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe bool excludeObjectMotionVectors
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_excludeObjectMotionVectors);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_excludeObjectMotionVectors)) = value;
		}
	}

	public unsafe int layerMask
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_layerMask);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_layerMask)) = value;
		}
	}

	public unsafe uint renderingLayerMask
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_renderingLayerMask);
			return *(uint*)num;
		}
		set
		{
			*(uint*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_renderingLayerMask)) = value;
		}
	}

	public unsafe uint _batchLayerMask_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__batchLayerMask_k__BackingField);
			return *(uint*)num;
		}
		set
		{
			*(uint*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__batchLayerMask_k__BackingField)) = value;
		}
	}

	public unsafe int overrideMaterialPassIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideMaterialPassIndex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideMaterialPassIndex)) = value;
		}
	}

	public unsafe int overrideShaderPassIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideShaderPassIndex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideShaderPassIndex)) = value;
		}
	}

	public unsafe CullingResults _cullingResult_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__cullingResult_k__BackingField);
			return *(CullingResults*)num;
		}
		set
		{
			*(CullingResults*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__cullingResult_k__BackingField)) = value;
		}
	}

	public unsafe Camera _camera_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__camera_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Camera>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__camera_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe ShaderTagId _passName_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__passName_k__BackingField);
			return *(ShaderTagId*)num;
		}
		set
		{
			*(ShaderTagId*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__passName_k__BackingField)) = value;
		}
	}

	public unsafe Il2CppStructArray<ShaderTagId> _passNames_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__passNames_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<ShaderTagId>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__passNames_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static ShaderTagId s_EmptyName
	{
		get
		{
			Unsafe.SkipInit(out ShaderTagId result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_EmptyName, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_EmptyName, (void*)(&value));
		}
	}

	public unsafe uint batchLayerMask
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_batchLayerMask_Public_get_UInt32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			_batchLayerMask_k__BackingField = value;
		}
	}

	public unsafe CullingResults cullingResult
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_cullingResult_Internal_get_CullingResults_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(CullingResults*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			_cullingResult_k__BackingField = value;
		}
	}

	public unsafe Camera camera
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 329742, RefRangeEnd = 329745, XrefRangeStart = 329742, XrefRangeEnd = 329745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_camera_Internal_get_Camera_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
		}
		set
		{
			_camera_k__BackingField = value;
		}
	}

	public unsafe ShaderTagId passName
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_passName_Internal_get_ShaderTagId_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(ShaderTagId*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			_passName_k__BackingField = value;
		}
	}

	public unsafe Il2CppStructArray<ShaderTagId> passNames
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_passNames_Internal_get_Il2CppStructArray_1_ShaderTagId_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<ShaderTagId>>(intPtr2) : null;
		}
		set
		{
			_passNames_k__BackingField = value;
		}
	}

	static RendererListDesc()
	{
		Il2CppClassPointerStore<RendererListDesc>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering.RendererUtils", "RendererListDesc");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RendererListDesc>.NativeClassPtr);
		NativeFieldInfoPtr_sortingCriteria = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererListDesc>.NativeClassPtr, "sortingCriteria");
		NativeFieldInfoPtr_rendererConfiguration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererListDesc>.NativeClassPtr, "rendererConfiguration");
		NativeFieldInfoPtr_renderQueueRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererListDesc>.NativeClassPtr, "renderQueueRange");
		NativeFieldInfoPtr_stateBlock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererListDesc>.NativeClassPtr, "stateBlock");
		NativeFieldInfoPtr_overrideShader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererListDesc>.NativeClassPtr, "overrideShader");
		NativeFieldInfoPtr_overrideMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererListDesc>.NativeClassPtr, "overrideMaterial");
		NativeFieldInfoPtr_excludeObjectMotionVectors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererListDesc>.NativeClassPtr, "excludeObjectMotionVectors");
		NativeFieldInfoPtr_layerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererListDesc>.NativeClassPtr, "layerMask");
		NativeFieldInfoPtr_renderingLayerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererListDesc>.NativeClassPtr, "renderingLayerMask");
		NativeFieldInfoPtr__batchLayerMask_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererListDesc>.NativeClassPtr, "<batchLayerMask>k__BackingField");
		NativeFieldInfoPtr_overrideMaterialPassIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererListDesc>.NativeClassPtr, "overrideMaterialPassIndex");
		NativeFieldInfoPtr_overrideShaderPassIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererListDesc>.NativeClassPtr, "overrideShaderPassIndex");
		NativeFieldInfoPtr__cullingResult_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererListDesc>.NativeClassPtr, "<cullingResult>k__BackingField");
		NativeFieldInfoPtr__camera_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererListDesc>.NativeClassPtr, "<camera>k__BackingField");
		NativeFieldInfoPtr__passName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererListDesc>.NativeClassPtr, "<passName>k__BackingField");
		NativeFieldInfoPtr__passNames_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererListDesc>.NativeClassPtr, "<passNames>k__BackingField");
		NativeFieldInfoPtr_s_EmptyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererListDesc>.NativeClassPtr, "s_EmptyName");
		NativeMethodInfoPtr_get_batchLayerMask_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererListDesc>.NativeClassPtr, 100668884);
		NativeMethodInfoPtr_get_cullingResult_Internal_get_CullingResults_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererListDesc>.NativeClassPtr, 100668885);
		NativeMethodInfoPtr_get_camera_Internal_get_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererListDesc>.NativeClassPtr, 100668886);
		NativeMethodInfoPtr_get_passName_Internal_get_ShaderTagId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererListDesc>.NativeClassPtr, 100668887);
		NativeMethodInfoPtr_get_passNames_Internal_get_Il2CppStructArray_1_ShaderTagId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererListDesc>.NativeClassPtr, 100668888);
		NativeMethodInfoPtr_IsValid_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererListDesc>.NativeClassPtr, 100668889);
		NativeMethodInfoPtr_ConvertToParameters_Public_Static_RendererListParams_byref_RendererListDesc_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererListDesc>.NativeClassPtr, 100668890);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1240633, RefRangeEnd = 1240635, XrefRangeStart = 1240621, XrefRangeEnd = 1240633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsValid()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsValid_Public_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1240729, RefRangeEnd = 1240730, XrefRangeStart = 1240635, XrefRangeEnd = 1240729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static RendererListParams ConvertToParameters([In] ref RendererListDesc desc)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)desc);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConvertToParameters_Public_Static_RendererListParams_byref_RendererListDesc_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new RendererListParams(pointer);
	}

	public RendererListDesc(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public RendererListDesc()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RendererListDesc>.NativeClassPtr))
	{
	}
}
