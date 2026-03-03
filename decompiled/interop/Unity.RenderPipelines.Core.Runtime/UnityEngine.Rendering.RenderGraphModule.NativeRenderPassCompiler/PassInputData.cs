using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler;

[StructLayout(LayoutKind.Explicit)]
public struct PassInputData
{
	private static readonly System.IntPtr NativeFieldInfoPtr_resource;

	[FieldOffset(0)]
	public ResourceHandle resource;

	static PassInputData()
	{
		Il2CppClassPointerStore<PassInputData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler", "PassInputData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PassInputData>.NativeClassPtr);
		NativeFieldInfoPtr_resource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PassInputData>.NativeClassPtr, "resource");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PassInputData>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
