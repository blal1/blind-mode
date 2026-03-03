using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct FrameTimeSample
{
	private static readonly System.IntPtr NativeFieldInfoPtr_FramesPerSecond;

	private static readonly System.IntPtr NativeFieldInfoPtr_FullFrameTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_MainThreadCPUFrameTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_MainThreadCPUPresentWaitTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_RenderThreadCPUFrameTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_GPUFrameTime;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Single_0;

	[FieldOffset(0)]
	public float FramesPerSecond;

	[FieldOffset(4)]
	public float FullFrameTime;

	[FieldOffset(8)]
	public float MainThreadCPUFrameTime;

	[FieldOffset(12)]
	public float MainThreadCPUPresentWaitTime;

	[FieldOffset(16)]
	public float RenderThreadCPUFrameTime;

	[FieldOffset(20)]
	public float GPUFrameTime;

	static FrameTimeSample()
	{
		Il2CppClassPointerStore<FrameTimeSample>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "FrameTimeSample");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FrameTimeSample>.NativeClassPtr);
		NativeFieldInfoPtr_FramesPerSecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameTimeSample>.NativeClassPtr, "FramesPerSecond");
		NativeFieldInfoPtr_FullFrameTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameTimeSample>.NativeClassPtr, "FullFrameTime");
		NativeFieldInfoPtr_MainThreadCPUFrameTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameTimeSample>.NativeClassPtr, "MainThreadCPUFrameTime");
		NativeFieldInfoPtr_MainThreadCPUPresentWaitTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameTimeSample>.NativeClassPtr, "MainThreadCPUPresentWaitTime");
		NativeFieldInfoPtr_RenderThreadCPUFrameTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameTimeSample>.NativeClassPtr, "RenderThreadCPUFrameTime");
		NativeFieldInfoPtr_GPUFrameTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameTimeSample>.NativeClassPtr, "GPUFrameTime");
		NativeMethodInfoPtr__ctor_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameTimeSample>.NativeClassPtr, 100665036);
	}

	[CallerCount(0)]
	public unsafe FrameTimeSample(float initValue)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&initValue);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FrameTimeSample>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
