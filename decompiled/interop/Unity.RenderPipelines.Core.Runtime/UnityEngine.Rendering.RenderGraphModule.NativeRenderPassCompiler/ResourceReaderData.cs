using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler;

[StructLayout(LayoutKind.Explicit)]
public struct ResourceReaderData
{
	private static readonly System.IntPtr NativeFieldInfoPtr_passId;

	private static readonly System.IntPtr NativeFieldInfoPtr_inputSlot;

	[FieldOffset(0)]
	public int passId;

	[FieldOffset(4)]
	public int inputSlot;

	static ResourceReaderData()
	{
		Il2CppClassPointerStore<ResourceReaderData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler", "ResourceReaderData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResourceReaderData>.NativeClassPtr);
		NativeFieldInfoPtr_passId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceReaderData>.NativeClassPtr, "passId");
		NativeFieldInfoPtr_inputSlot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceReaderData>.NativeClassPtr, "inputSlot");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ResourceReaderData>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
