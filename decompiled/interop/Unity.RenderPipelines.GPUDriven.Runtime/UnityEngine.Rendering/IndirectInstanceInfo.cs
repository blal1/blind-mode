using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct IndirectInstanceInfo
{
	private static readonly System.IntPtr NativeFieldInfoPtr_drawOffsetAndSplitMask;

	private static readonly System.IntPtr NativeFieldInfoPtr_instanceIndexAndCrossFade;

	[FieldOffset(0)]
	public int drawOffsetAndSplitMask;

	[FieldOffset(4)]
	public int instanceIndexAndCrossFade;

	static IndirectInstanceInfo()
	{
		Il2CppClassPointerStore<IndirectInstanceInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.GPUDriven.Runtime.dll", "UnityEngine.Rendering", "IndirectInstanceInfo");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IndirectInstanceInfo>.NativeClassPtr);
		NativeFieldInfoPtr_drawOffsetAndSplitMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IndirectInstanceInfo>.NativeClassPtr, "drawOffsetAndSplitMask");
		NativeFieldInfoPtr_instanceIndexAndCrossFade = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IndirectInstanceInfo>.NativeClassPtr, "instanceIndexAndCrossFade");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<IndirectInstanceInfo>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
