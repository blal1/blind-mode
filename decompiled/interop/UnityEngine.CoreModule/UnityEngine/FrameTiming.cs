using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine;

[StructLayout(LayoutKind.Explicit)]
public struct FrameTiming
{
	private static readonly System.IntPtr NativeFieldInfoPtr_cpuFrameTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_cpuMainThreadFrameTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_cpuMainThreadPresentWaitTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_cpuRenderThreadFrameTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_gpuFrameTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_frameStartTimestamp;

	private static readonly System.IntPtr NativeFieldInfoPtr_firstSubmitTimestamp;

	private static readonly System.IntPtr NativeFieldInfoPtr_cpuTimePresentCalled;

	private static readonly System.IntPtr NativeFieldInfoPtr_cpuTimeFrameComplete;

	private static readonly System.IntPtr NativeFieldInfoPtr_heightScale;

	private static readonly System.IntPtr NativeFieldInfoPtr_widthScale;

	private static readonly System.IntPtr NativeFieldInfoPtr_syncInterval;

	[FieldOffset(0)]
	public double cpuFrameTime;

	[FieldOffset(8)]
	public double cpuMainThreadFrameTime;

	[FieldOffset(16)]
	public double cpuMainThreadPresentWaitTime;

	[FieldOffset(24)]
	public double cpuRenderThreadFrameTime;

	[FieldOffset(32)]
	public double gpuFrameTime;

	[FieldOffset(40)]
	public ulong frameStartTimestamp;

	[FieldOffset(48)]
	public ulong firstSubmitTimestamp;

	[FieldOffset(56)]
	public ulong cpuTimePresentCalled;

	[FieldOffset(64)]
	public ulong cpuTimeFrameComplete;

	[FieldOffset(72)]
	public float heightScale;

	[FieldOffset(76)]
	public float widthScale;

	[FieldOffset(80)]
	public uint syncInterval;

	static FrameTiming()
	{
		Il2CppClassPointerStore<FrameTiming>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "FrameTiming");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FrameTiming>.NativeClassPtr);
		NativeFieldInfoPtr_cpuFrameTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameTiming>.NativeClassPtr, "cpuFrameTime");
		NativeFieldInfoPtr_cpuMainThreadFrameTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameTiming>.NativeClassPtr, "cpuMainThreadFrameTime");
		NativeFieldInfoPtr_cpuMainThreadPresentWaitTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameTiming>.NativeClassPtr, "cpuMainThreadPresentWaitTime");
		NativeFieldInfoPtr_cpuRenderThreadFrameTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameTiming>.NativeClassPtr, "cpuRenderThreadFrameTime");
		NativeFieldInfoPtr_gpuFrameTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameTiming>.NativeClassPtr, "gpuFrameTime");
		NativeFieldInfoPtr_frameStartTimestamp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameTiming>.NativeClassPtr, "frameStartTimestamp");
		NativeFieldInfoPtr_firstSubmitTimestamp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameTiming>.NativeClassPtr, "firstSubmitTimestamp");
		NativeFieldInfoPtr_cpuTimePresentCalled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameTiming>.NativeClassPtr, "cpuTimePresentCalled");
		NativeFieldInfoPtr_cpuTimeFrameComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameTiming>.NativeClassPtr, "cpuTimeFrameComplete");
		NativeFieldInfoPtr_heightScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameTiming>.NativeClassPtr, "heightScale");
		NativeFieldInfoPtr_widthScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameTiming>.NativeClassPtr, "widthScale");
		NativeFieldInfoPtr_syncInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameTiming>.NativeClassPtr, "syncInterval");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FrameTiming>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
