using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering.Universal;

public class DebugRenderSetup : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_DebugHandler;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_FilteringSettings;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Index;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_MaterialSettings_Private_get_DebugDisplaySettingsMaterial_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_RenderingSettings_Private_get_DebugDisplaySettingsRendering_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_LightingSettings_Private_get_DebugDisplaySettingsLighting_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Begin_Internal_Void_RasterCommandBuffer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_End_Internal_Void_RasterCommandBuffer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_DebugHandler_Int32_FilteringSettings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateRendererList_Internal_Void_ScriptableRenderContext_byref_CullingResults_byref_DrawingSettings_byref_FilteringSettings_byref_RenderStateBlock_byref_RendererList_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateRendererList_Internal_Void_RenderGraph_byref_CullingResults_byref_DrawingSettings_byref_FilteringSettings_byref_RenderStateBlock_byref_RendererListHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DrawWithRendererList_Internal_Void_RasterCommandBuffer_byref_RendererList_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateDrawingSettings_Internal_DrawingSettings_DrawingSettings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRenderStateBlock_Internal_RenderStateBlock_RenderStateBlock_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetIndex_Internal_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

	public unsafe DebugHandler m_DebugHandler
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DebugHandler);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DebugHandler>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DebugHandler)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe FilteringSettings m_FilteringSettings
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_FilteringSettings);
			return *(FilteringSettings*)num;
		}
		set
		{
			*(FilteringSettings*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_FilteringSettings)) = value;
		}
	}

	public unsafe int m_Index
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Index);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Index)) = value;
		}
	}

	public unsafe DebugDisplaySettingsMaterial MaterialSettings
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_MaterialSettings_Private_get_DebugDisplaySettingsMaterial_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<DebugDisplaySettingsMaterial>(intPtr2) : null;
		}
	}

	public unsafe DebugDisplaySettingsRendering RenderingSettings
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_RenderingSettings_Private_get_DebugDisplaySettingsRendering_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<DebugDisplaySettingsRendering>(intPtr2) : null;
		}
	}

	public unsafe DebugDisplaySettingsLighting LightingSettings
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_LightingSettings_Private_get_DebugDisplaySettingsLighting_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<DebugDisplaySettingsLighting>(intPtr2) : null;
		}
	}

	static DebugRenderSetup()
	{
		Il2CppClassPointerStore<DebugRenderSetup>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "DebugRenderSetup");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugRenderSetup>.NativeClassPtr);
		NativeFieldInfoPtr_m_DebugHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugRenderSetup>.NativeClassPtr, "m_DebugHandler");
		NativeFieldInfoPtr_m_FilteringSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugRenderSetup>.NativeClassPtr, "m_FilteringSettings");
		NativeFieldInfoPtr_m_Index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugRenderSetup>.NativeClassPtr, "m_Index");
		NativeMethodInfoPtr_get_MaterialSettings_Private_get_DebugDisplaySettingsMaterial_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugRenderSetup>.NativeClassPtr, 100663903);
		NativeMethodInfoPtr_get_RenderingSettings_Private_get_DebugDisplaySettingsRendering_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugRenderSetup>.NativeClassPtr, 100663904);
		NativeMethodInfoPtr_get_LightingSettings_Private_get_DebugDisplaySettingsLighting_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugRenderSetup>.NativeClassPtr, 100663905);
		NativeMethodInfoPtr_Begin_Internal_Void_RasterCommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugRenderSetup>.NativeClassPtr, 100663906);
		NativeMethodInfoPtr_End_Internal_Void_RasterCommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugRenderSetup>.NativeClassPtr, 100663907);
		NativeMethodInfoPtr__ctor_Internal_Void_DebugHandler_Int32_FilteringSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugRenderSetup>.NativeClassPtr, 100663908);
		NativeMethodInfoPtr_CreateRendererList_Internal_Void_ScriptableRenderContext_byref_CullingResults_byref_DrawingSettings_byref_FilteringSettings_byref_RenderStateBlock_byref_RendererList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugRenderSetup>.NativeClassPtr, 100663909);
		NativeMethodInfoPtr_CreateRendererList_Internal_Void_RenderGraph_byref_CullingResults_byref_DrawingSettings_byref_FilteringSettings_byref_RenderStateBlock_byref_RendererListHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugRenderSetup>.NativeClassPtr, 100663910);
		NativeMethodInfoPtr_DrawWithRendererList_Internal_Void_RasterCommandBuffer_byref_RendererList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugRenderSetup>.NativeClassPtr, 100663911);
		NativeMethodInfoPtr_CreateDrawingSettings_Internal_DrawingSettings_DrawingSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugRenderSetup>.NativeClassPtr, 100663912);
		NativeMethodInfoPtr_GetRenderStateBlock_Internal_RenderStateBlock_RenderStateBlock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugRenderSetup>.NativeClassPtr, 100663913);
		NativeMethodInfoPtr_GetIndex_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugRenderSetup>.NativeClassPtr, 100663914);
		NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugRenderSetup>.NativeClassPtr, 100663915);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1080249, XrefRangeEnd = 1080251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Begin(RasterCommandBuffer cmd)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Begin_Internal_Void_RasterCommandBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1080251, XrefRangeEnd = 1080253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void End(RasterCommandBuffer cmd)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_End_Internal_Void_RasterCommandBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1080253, XrefRangeEnd = 1080255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DebugRenderSetup(DebugHandler debugHandler, int index, FilteringSettings filteringSettings)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugRenderSetup>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)debugHandler);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
		*(FilteringSettings**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &filteringSettings;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_DebugHandler_Int32_FilteringSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1080255, XrefRangeEnd = 1080259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CreateRendererList(ScriptableRenderContext context, ref CullingResults cullResults, ref DrawingSettings drawingSettings, ref FilteringSettings filteringSettings, ref RenderStateBlock renderStateBlock, ref RendererList rendererList)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&context);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref cullResults);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref drawingSettings);
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref filteringSettings);
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref renderStateBlock);
		*(void**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref rendererList);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateRendererList_Internal_Void_ScriptableRenderContext_byref_CullingResults_byref_DrawingSettings_byref_FilteringSettings_byref_RenderStateBlock_byref_RendererList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1080259, XrefRangeEnd = 1080263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CreateRendererList(RenderGraph renderGraph, ref CullingResults cullResults, ref DrawingSettings drawingSettings, ref FilteringSettings filteringSettings, ref RenderStateBlock renderStateBlock, ref RendererListHandle rendererListHdl)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderGraph);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref cullResults);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref drawingSettings);
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref filteringSettings);
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref renderStateBlock);
		*(void**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref rendererListHdl);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateRendererList_Internal_Void_RenderGraph_byref_CullingResults_byref_DrawingSettings_byref_FilteringSettings_byref_RenderStateBlock_byref_RendererListHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1080263, XrefRangeEnd = 1080268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DrawWithRendererList(RasterCommandBuffer cmd, ref RendererList rendererList)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref rendererList);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DrawWithRendererList_Internal_Void_RasterCommandBuffer_byref_RendererList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1080270, RefRangeEnd = 1080272, XrefRangeStart = 1080268, XrefRangeEnd = 1080270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DrawingSettings CreateDrawingSettings(DrawingSettings drawingSettings)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&drawingSettings);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateDrawingSettings_Internal_DrawingSettings_DrawingSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(DrawingSettings*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1080305, RefRangeEnd = 1080307, XrefRangeStart = 1080272, XrefRangeEnd = 1080305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RenderStateBlock GetRenderStateBlock(RenderStateBlock renderStateBlock)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&renderStateBlock);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRenderStateBlock_Internal_RenderStateBlock_RenderStateBlock_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(RenderStateBlock*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe int GetIndex()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetIndex_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(19883)]
	[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 20035, XrefRangeStart = 152, XrefRangeEnd = 20035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Dispose()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public DebugRenderSetup(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
