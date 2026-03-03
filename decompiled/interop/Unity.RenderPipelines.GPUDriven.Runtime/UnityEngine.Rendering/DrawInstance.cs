using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct DrawInstance
{
	private static readonly System.IntPtr NativeFieldInfoPtr_key;

	private static readonly System.IntPtr NativeFieldInfoPtr_instanceIndex;

	[FieldOffset(0)]
	public DrawKey key;

	[FieldOffset(56)]
	public int instanceIndex;

	static DrawInstance()
	{
		Il2CppClassPointerStore<DrawInstance>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.GPUDriven.Runtime.dll", "UnityEngine.Rendering", "DrawInstance");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DrawInstance>.NativeClassPtr);
		NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawInstance>.NativeClassPtr, "key");
		NativeFieldInfoPtr_instanceIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawInstance>.NativeClassPtr, "instanceIndex");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DrawInstance>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
