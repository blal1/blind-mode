using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;

namespace UnityEngine.XR;

public static class XRStats
{
	private delegate bool TryGetGPUTimeLastFrameDelegate([Out] IntPtr gpuTimeLastFrame);

	private delegate bool TryGetDroppedFrameCountDelegate([Out] IntPtr droppedFrameCount);

	private delegate bool TryGetFramePresentCountDelegate([Out] IntPtr framePresentCount);

	private static readonly TryGetGPUTimeLastFrameDelegate TryGetGPUTimeLastFrameDelegateField = IL2CPP.ResolveICall<TryGetGPUTimeLastFrameDelegate>("UnityEngine.XR.XRStats::TryGetGPUTimeLastFrame");

	private static readonly TryGetDroppedFrameCountDelegate TryGetDroppedFrameCountDelegateField = IL2CPP.ResolveICall<TryGetDroppedFrameCountDelegate>("UnityEngine.XR.XRStats::TryGetDroppedFrameCount");

	private static readonly TryGetFramePresentCountDelegate TryGetFramePresentCountDelegateField = IL2CPP.ResolveICall<TryGetFramePresentCountDelegate>("UnityEngine.XR.XRStats::TryGetFramePresentCount");

	public unsafe static bool TryGetGPUTimeLastFrame(out float gpuTimeLastFrame)
	{
		return TryGetGPUTimeLastFrameDelegateField((nint)Unsafe.AsPointer(ref gpuTimeLastFrame));
	}

	public unsafe static bool TryGetDroppedFrameCount(out int droppedFrameCount)
	{
		return TryGetDroppedFrameCountDelegateField((nint)Unsafe.AsPointer(ref droppedFrameCount));
	}

	public unsafe static bool TryGetFramePresentCount(out int framePresentCount)
	{
		return TryGetFramePresentCountDelegateField((nint)Unsafe.AsPointer(ref framePresentCount));
	}
}
