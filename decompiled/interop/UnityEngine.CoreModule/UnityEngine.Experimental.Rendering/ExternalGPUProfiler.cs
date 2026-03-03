using Il2CppInterop.Runtime;

namespace UnityEngine.Experimental.Rendering;

public static class ExternalGPUProfiler
{
	private delegate void BeginGPUCaptureDelegate();

	private delegate void EndGPUCaptureDelegate();

	private delegate bool IsAttachedDelegate();

	private static readonly BeginGPUCaptureDelegate BeginGPUCaptureDelegateField = IL2CPP.ResolveICall<BeginGPUCaptureDelegate>("UnityEngine.Experimental.Rendering.ExternalGPUProfiler::BeginGPUCapture");

	private static readonly EndGPUCaptureDelegate EndGPUCaptureDelegateField = IL2CPP.ResolveICall<EndGPUCaptureDelegate>("UnityEngine.Experimental.Rendering.ExternalGPUProfiler::EndGPUCapture");

	private static readonly IsAttachedDelegate IsAttachedDelegateField = IL2CPP.ResolveICall<IsAttachedDelegate>("UnityEngine.Experimental.Rendering.ExternalGPUProfiler::IsAttached");

	public static void BeginGPUCapture()
	{
		BeginGPUCaptureDelegateField();
	}

	public static void EndGPUCapture()
	{
		EndGPUCaptureDelegateField();
	}

	public static bool IsAttached()
	{
		return IsAttachedDelegateField();
	}
}
