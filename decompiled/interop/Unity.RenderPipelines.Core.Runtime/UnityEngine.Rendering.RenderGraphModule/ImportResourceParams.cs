using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.RenderGraphModule;

[StructLayout(LayoutKind.Explicit)]
public struct ImportResourceParams
{
	private static readonly System.IntPtr NativeFieldInfoPtr_clearOnFirstUse;

	private static readonly System.IntPtr NativeFieldInfoPtr_clearColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_discardOnLastUse;

	[FieldOffset(0)]
	[MarshalAs(UnmanagedType.U1)]
	public bool clearOnFirstUse;

	[FieldOffset(4)]
	public Color clearColor;

	[FieldOffset(20)]
	[MarshalAs(UnmanagedType.U1)]
	public bool discardOnLastUse;

	static ImportResourceParams()
	{
		Il2CppClassPointerStore<ImportResourceParams>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering.RenderGraphModule", "ImportResourceParams");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ImportResourceParams>.NativeClassPtr);
		NativeFieldInfoPtr_clearOnFirstUse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImportResourceParams>.NativeClassPtr, "clearOnFirstUse");
		NativeFieldInfoPtr_clearColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImportResourceParams>.NativeClassPtr, "clearColor");
		NativeFieldInfoPtr_discardOnLastUse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImportResourceParams>.NativeClassPtr, "discardOnLastUse");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ImportResourceParams>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
