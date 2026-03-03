using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using UnityEngine.Rendering.RenderGraphModule;
using UnityEngine.Rendering.Universal.Internal;

namespace UnityEngine.Rendering.Universal;

public class DBufferCopyDepthPass : CopyDepthPass
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_RenderPassEvent_Shader_Boolean_Boolean_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_RecordRenderGraph_Public_Virtual_Void_RenderGraph_ContextContainer_0;

	static DBufferCopyDepthPass()
	{
		Il2CppClassPointerStore<DBufferCopyDepthPass>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "DBufferCopyDepthPass");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBufferCopyDepthPass>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_RenderPassEvent_Shader_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBufferCopyDepthPass>.NativeClassPtr, 100663949);
		NativeMethodInfoPtr_RecordRenderGraph_Public_Virtual_Void_RenderGraph_ContextContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBufferCopyDepthPass>.NativeClassPtr, 100663950);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1080589, RefRangeEnd = 1080590, XrefRangeStart = 1080588, XrefRangeEnd = 1080589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DBufferCopyDepthPass(RenderPassEvent evt, Shader copyDepthShader, bool shouldClear = false, bool copyToDepth = false, bool copyResolvedDepth = false)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DBufferCopyDepthPass>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[5];
		*ptr = (nint)(&evt);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)copyDepthShader);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &shouldClear;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = &copyToDepth;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(IntPtr)))) = &copyResolvedDepth;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_RenderPassEvent_Shader_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1080590, XrefRangeEnd = 1080613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void RecordRenderGraph(RenderGraph renderGraph, ContextContainer frameData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderGraph);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)frameData);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_RecordRenderGraph_Public_Virtual_Void_RenderGraph_ContextContainer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public DBufferCopyDepthPass(IntPtr pointer)
		: base(pointer)
	{
	}
}
