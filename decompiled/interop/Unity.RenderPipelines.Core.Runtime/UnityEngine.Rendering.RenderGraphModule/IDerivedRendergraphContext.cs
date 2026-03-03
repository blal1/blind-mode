using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.Rendering.RenderGraphModule;

public class IDerivedRendergraphContext : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_FromInternalContext_Public_Abstract_Virtual_New_Void_InternalRenderGraphContext_0;

	static IDerivedRendergraphContext()
	{
		Il2CppClassPointerStore<IDerivedRendergraphContext>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering.RenderGraphModule", "IDerivedRendergraphContext");
		NativeMethodInfoPtr_FromInternalContext_Public_Abstract_Virtual_New_Void_InternalRenderGraphContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDerivedRendergraphContext>.NativeClassPtr, 100667280);
	}

	[CallerCount(0)]
	public unsafe virtual void FromInternalContext(InternalRenderGraphContext context)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)context);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_FromInternalContext_Public_Abstract_Virtual_New_Void_InternalRenderGraphContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public IDerivedRendergraphContext(IntPtr pointer)
		: base(pointer)
	{
	}
}
