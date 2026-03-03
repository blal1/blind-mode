using Il2CppInterop.Runtime;

namespace UnityEngine.Rendering;

public class PIX
{
	private delegate void BeginGPUCaptureDelegate();

	private delegate void EndGPUCaptureDelegate();

	private delegate bool IsAttachedDelegate();

	private static readonly BeginGPUCaptureDelegate BeginGPUCaptureDelegateField = IL2CPP.ResolveICall<BeginGPUCaptureDelegate>("UnityEngine.Rendering.PIX::BeginGPUCapture");

	private static readonly EndGPUCaptureDelegate EndGPUCaptureDelegateField = IL2CPP.ResolveICall<EndGPUCaptureDelegate>("UnityEngine.Rendering.PIX::EndGPUCapture");

	private static readonly IsAttachedDelegate IsAttachedDelegateField = IL2CPP.ResolveICall<IsAttachedDelegate>("UnityEngine.Rendering.PIX::IsAttached");

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
