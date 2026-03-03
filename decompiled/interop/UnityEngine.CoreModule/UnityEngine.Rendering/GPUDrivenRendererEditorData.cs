using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct GPUDrivenRendererEditorData
{
	private static readonly System.IntPtr NativeFieldInfoPtr_sceneCullingMask;

	[FieldOffset(0)]
	public ulong sceneCullingMask;

	static GPUDrivenRendererEditorData()
	{
		Il2CppClassPointerStore<GPUDrivenRendererEditorData>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "GPUDrivenRendererEditorData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GPUDrivenRendererEditorData>.NativeClassPtr);
		NativeFieldInfoPtr_sceneCullingMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenRendererEditorData>.NativeClassPtr, "sceneCullingMask");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GPUDrivenRendererEditorData>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
