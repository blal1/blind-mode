using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.Rendering.RenderGraphModule;

public class IRenderGraphEnabledRenderPipeline : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_get_isImmediateModeSupported_Public_Abstract_Virtual_New_get_Boolean_0;

	public unsafe virtual bool isImmediateModeSupported
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_isImmediateModeSupported_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static IRenderGraphEnabledRenderPipeline()
	{
		Il2CppClassPointerStore<IRenderGraphEnabledRenderPipeline>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering.RenderGraphModule", "IRenderGraphEnabledRenderPipeline");
		NativeMethodInfoPtr_get_isImmediateModeSupported_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRenderGraphEnabledRenderPipeline>.NativeClassPtr, 100667121);
	}

	public IRenderGraphEnabledRenderPipeline(IntPtr pointer)
		: base(pointer)
	{
	}
}
