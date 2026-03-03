using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.Rendering.RenderGraphModule;

public class IRenderGraphRecorder : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_RecordRenderGraph_Public_Abstract_Virtual_New_Void_RenderGraph_ContextContainer_0;

	static IRenderGraphRecorder()
	{
		Il2CppClassPointerStore<IRenderGraphRecorder>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering.RenderGraphModule", "IRenderGraphRecorder");
		NativeMethodInfoPtr_RecordRenderGraph_Public_Abstract_Virtual_New_Void_RenderGraph_ContextContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRenderGraphRecorder>.NativeClassPtr, 100667122);
	}

	[CallerCount(0)]
	public unsafe virtual void RecordRenderGraph(RenderGraph renderGraph, ContextContainer frameData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderGraph);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)frameData);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_RecordRenderGraph_Public_Abstract_Virtual_New_Void_RenderGraph_ContextContainer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public IRenderGraphRecorder(IntPtr pointer)
		: base(pointer)
	{
	}
}
