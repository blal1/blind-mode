using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct RTHandleProperties
{
	private static readonly System.IntPtr NativeFieldInfoPtr_previousViewportSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_previousRenderTargetSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentViewportSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentRenderTargetSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_rtHandleScale;

	[FieldOffset(0)]
	public Vector2Int previousViewportSize;

	[FieldOffset(8)]
	public Vector2Int previousRenderTargetSize;

	[FieldOffset(16)]
	public Vector2Int currentViewportSize;

	[FieldOffset(24)]
	public Vector2Int currentRenderTargetSize;

	[FieldOffset(32)]
	public Vector4 rtHandleScale;

	static RTHandleProperties()
	{
		Il2CppClassPointerStore<RTHandleProperties>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "RTHandleProperties");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RTHandleProperties>.NativeClassPtr);
		NativeFieldInfoPtr_previousViewportSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTHandleProperties>.NativeClassPtr, "previousViewportSize");
		NativeFieldInfoPtr_previousRenderTargetSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTHandleProperties>.NativeClassPtr, "previousRenderTargetSize");
		NativeFieldInfoPtr_currentViewportSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTHandleProperties>.NativeClassPtr, "currentViewportSize");
		NativeFieldInfoPtr_currentRenderTargetSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTHandleProperties>.NativeClassPtr, "currentRenderTargetSize");
		NativeFieldInfoPtr_rtHandleScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTHandleProperties>.NativeClassPtr, "rtHandleScale");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RTHandleProperties>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
