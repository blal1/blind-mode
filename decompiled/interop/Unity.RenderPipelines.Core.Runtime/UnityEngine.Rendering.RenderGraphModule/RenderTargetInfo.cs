using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.Experimental.Rendering;

namespace UnityEngine.Rendering.RenderGraphModule;

[StructLayout(LayoutKind.Explicit)]
public struct RenderTargetInfo
{
	private static readonly System.IntPtr NativeFieldInfoPtr_width;

	private static readonly System.IntPtr NativeFieldInfoPtr_height;

	private static readonly System.IntPtr NativeFieldInfoPtr_volumeDepth;

	private static readonly System.IntPtr NativeFieldInfoPtr_msaaSamples;

	private static readonly System.IntPtr NativeFieldInfoPtr_format;

	private static readonly System.IntPtr NativeFieldInfoPtr_bindMS;

	[FieldOffset(0)]
	public int width;

	[FieldOffset(4)]
	public int height;

	[FieldOffset(8)]
	public int volumeDepth;

	[FieldOffset(12)]
	public int msaaSamples;

	[FieldOffset(16)]
	public GraphicsFormat format;

	[FieldOffset(20)]
	[MarshalAs(UnmanagedType.U1)]
	public bool bindMS;

	static RenderTargetInfo()
	{
		Il2CppClassPointerStore<RenderTargetInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering.RenderGraphModule", "RenderTargetInfo");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderTargetInfo>.NativeClassPtr);
		NativeFieldInfoPtr_width = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTargetInfo>.NativeClassPtr, "width");
		NativeFieldInfoPtr_height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTargetInfo>.NativeClassPtr, "height");
		NativeFieldInfoPtr_volumeDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTargetInfo>.NativeClassPtr, "volumeDepth");
		NativeFieldInfoPtr_msaaSamples = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTargetInfo>.NativeClassPtr, "msaaSamples");
		NativeFieldInfoPtr_format = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTargetInfo>.NativeClassPtr, "format");
		NativeFieldInfoPtr_bindMS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTargetInfo>.NativeClassPtr, "bindMS");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RenderTargetInfo>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
