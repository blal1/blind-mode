using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace UnityEngine.Rendering.RenderGraphModule;

public class IUnsafeRenderGraphBuilder : Il2CppObjectBase
{
	private sealed class MethodInfoStoreGeneric_SetRenderFunc_Public_Abstract_Virtual_New_Void_BaseRenderFunc_2_PassData_UnsafeGraphContext_0<PassData>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_SetRenderFunc_Public_Abstract_Virtual_New_Void_BaseRenderFunc_2_PassData_UnsafeGraphContext_0, Il2CppClassPointerStore<IUnsafeRenderGraphBuilder>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<PassData>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeMethodInfoPtr_SetRenderFunc_Public_Abstract_Virtual_New_Void_BaseRenderFunc_2_PassData_UnsafeGraphContext_0;

	static IUnsafeRenderGraphBuilder()
	{
		Il2CppClassPointerStore<IUnsafeRenderGraphBuilder>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering.RenderGraphModule", "IUnsafeRenderGraphBuilder");
		NativeMethodInfoPtr_SetRenderFunc_Public_Abstract_Virtual_New_Void_BaseRenderFunc_2_PassData_UnsafeGraphContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUnsafeRenderGraphBuilder>.NativeClassPtr, 100667110);
	}

	[CallerCount(0)]
	public unsafe virtual void SetRenderFunc<PassData>(BaseRenderFunc<PassData, UnsafeGraphContext> renderFunc) where PassData : class, new()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderFunc);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), MethodInfoStoreGeneric_SetRenderFunc_Public_Abstract_Virtual_New_Void_BaseRenderFunc_2_PassData_UnsafeGraphContext_0<PassData>.Pointer), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public IUnsafeRenderGraphBuilder(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
