using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering.Universal;

public class DebugRendererLists : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_DebugHandler;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_FilteringSettings;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_DebugRenderSetups;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ActiveDebugRendererList;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ActiveDebugRendererListHdl;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_DebugHandler_FilteringSettings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateDebugRenderSetups_Private_Void_FilteringSettings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DisposeDebugRenderLists_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateRendererListsWithDebugRenderState_Internal_Void_ScriptableRenderContext_byref_CullingResults_byref_DrawingSettings_byref_FilteringSettings_byref_RenderStateBlock_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateRendererListsWithDebugRenderState_Internal_Void_RenderGraph_byref_CullingResults_byref_DrawingSettings_byref_FilteringSettings_byref_RenderStateBlock_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PrepareRendererListForRasterPass_Internal_Void_IRasterRenderGraphBuilder_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DrawWithRendererList_Internal_Void_RasterCommandBuffer_0;

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

	public unsafe List<DebugRenderSetup> m_DebugRenderSetups
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DebugRenderSetups);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<DebugRenderSetup>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DebugRenderSetups)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe List<RendererList> m_ActiveDebugRendererList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ActiveDebugRendererList);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<RendererList>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ActiveDebugRendererList)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe List<RendererListHandle> m_ActiveDebugRendererListHdl
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ActiveDebugRendererListHdl);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<RendererListHandle>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ActiveDebugRendererListHdl)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static DebugRendererLists()
	{
		Il2CppClassPointerStore<DebugRendererLists>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "DebugRendererLists");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugRendererLists>.NativeClassPtr);
		NativeFieldInfoPtr_m_DebugHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugRendererLists>.NativeClassPtr, "m_DebugHandler");
		NativeFieldInfoPtr_m_FilteringSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugRendererLists>.NativeClassPtr, "m_FilteringSettings");
		NativeFieldInfoPtr_m_DebugRenderSetups = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugRendererLists>.NativeClassPtr, "m_DebugRenderSetups");
		NativeFieldInfoPtr_m_ActiveDebugRendererList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugRendererLists>.NativeClassPtr, "m_ActiveDebugRendererList");
		NativeFieldInfoPtr_m_ActiveDebugRendererListHdl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugRendererLists>.NativeClassPtr, "m_ActiveDebugRendererListHdl");
		NativeMethodInfoPtr__ctor_Public_Void_DebugHandler_FilteringSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugRendererLists>.NativeClassPtr, 100663896);
		NativeMethodInfoPtr_CreateDebugRenderSetups_Private_Void_FilteringSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugRendererLists>.NativeClassPtr, 100663897);
		NativeMethodInfoPtr_DisposeDebugRenderLists_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugRendererLists>.NativeClassPtr, 100663898);
		NativeMethodInfoPtr_CreateRendererListsWithDebugRenderState_Internal_Void_ScriptableRenderContext_byref_CullingResults_byref_DrawingSettings_byref_FilteringSettings_byref_RenderStateBlock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugRendererLists>.NativeClassPtr, 100663899);
		NativeMethodInfoPtr_CreateRendererListsWithDebugRenderState_Internal_Void_RenderGraph_byref_CullingResults_byref_DrawingSettings_byref_FilteringSettings_byref_RenderStateBlock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugRendererLists>.NativeClassPtr, 100663900);
		NativeMethodInfoPtr_PrepareRendererListForRasterPass_Internal_Void_IRasterRenderGraphBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugRendererLists>.NativeClassPtr, 100663901);
		NativeMethodInfoPtr_DrawWithRendererList_Internal_Void_RasterCommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugRendererLists>.NativeClassPtr, 100663902);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1080107, RefRangeEnd = 1080109, XrefRangeStart = 1080084, XrefRangeEnd = 1080107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DebugRendererLists(DebugHandler debugHandler, FilteringSettings filteringSettings)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugRendererLists>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)debugHandler);
		*(FilteringSettings**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &filteringSettings;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_DebugHandler_FilteringSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1080119, RefRangeEnd = 1080121, XrefRangeStart = 1080109, XrefRangeEnd = 1080119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CreateDebugRenderSetups(FilteringSettings filteringSettings)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&filteringSettings);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateDebugRenderSetups_Private_Void_FilteringSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1080139, RefRangeEnd = 1080140, XrefRangeStart = 1080121, XrefRangeEnd = 1080139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DisposeDebugRenderLists()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DisposeDebugRenderLists_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1080165, RefRangeEnd = 1080166, XrefRangeStart = 1080140, XrefRangeEnd = 1080165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CreateRendererListsWithDebugRenderState(ScriptableRenderContext context, ref CullingResults cullResults, ref DrawingSettings drawingSettings, ref FilteringSettings filteringSettings, ref RenderStateBlock renderStateBlock)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&context);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref cullResults);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref drawingSettings);
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref filteringSettings);
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref renderStateBlock);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateRendererListsWithDebugRenderState_Internal_Void_ScriptableRenderContext_byref_CullingResults_byref_DrawingSettings_byref_FilteringSettings_byref_RenderStateBlock_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1080191, RefRangeEnd = 1080192, XrefRangeStart = 1080166, XrefRangeEnd = 1080191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CreateRendererListsWithDebugRenderState(RenderGraph renderGraph, ref CullingResults cullResults, ref DrawingSettings drawingSettings, ref FilteringSettings filteringSettings, ref RenderStateBlock renderStateBlock)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderGraph);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref cullResults);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref drawingSettings);
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref filteringSettings);
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref renderStateBlock);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateRendererListsWithDebugRenderState_Internal_Void_RenderGraph_byref_CullingResults_byref_DrawingSettings_byref_FilteringSettings_byref_RenderStateBlock_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1080210, RefRangeEnd = 1080213, XrefRangeStart = 1080192, XrefRangeEnd = 1080210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PrepareRendererListForRasterPass(IRasterRenderGraphBuilder builder)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)builder);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PrepareRendererListForRasterPass_Internal_Void_IRasterRenderGraphBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1080248, RefRangeEnd = 1080249, XrefRangeStart = 1080213, XrefRangeEnd = 1080248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DrawWithRendererList(RasterCommandBuffer cmd)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DrawWithRendererList_Internal_Void_RasterCommandBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public DebugRendererLists(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
