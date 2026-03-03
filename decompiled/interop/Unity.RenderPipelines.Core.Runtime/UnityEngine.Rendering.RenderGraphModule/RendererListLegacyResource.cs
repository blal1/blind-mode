using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.RenderGraphModule;

[StructLayout(LayoutKind.Explicit)]
public struct RendererListLegacyResource
{
	private static readonly System.IntPtr NativeFieldInfoPtr_rendererList;

	private static readonly System.IntPtr NativeFieldInfoPtr_isActive;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_byref_Boolean_0;

	[FieldOffset(0)]
	public RendererList rendererList;

	[FieldOffset(24)]
	[MarshalAs(UnmanagedType.U1)]
	public bool isActive;

	static RendererListLegacyResource()
	{
		Il2CppClassPointerStore<RendererListLegacyResource>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering.RenderGraphModule", "RendererListLegacyResource");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RendererListLegacyResource>.NativeClassPtr);
		NativeFieldInfoPtr_rendererList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererListLegacyResource>.NativeClassPtr, "rendererList");
		NativeFieldInfoPtr_isActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererListLegacyResource>.NativeClassPtr, "isActive");
		NativeMethodInfoPtr__ctor_Internal_Void_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererListLegacyResource>.NativeClassPtr, 100667679);
	}

	[CallerCount(0)]
	public unsafe RendererListLegacyResource([Optional][DefaultParameterValue(false)][In] ref bool active)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref active);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_byref_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RendererListLegacyResource>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
