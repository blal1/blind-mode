using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.Bindings;

namespace UnityEngine;

public static class ScreenCapture
{
	public enum StereoScreenCaptureMode
	{
		LeftEye = 1,
		RightEye,
		BothEyes,
		MotionVectors
	}

	private delegate void CaptureScreenshotIntoRenderTexture_InjectedDelegate(System.IntPtr renderTexture);

	private delegate void CaptureScreenshot_InjectedDelegate(System.IntPtr filename, int superSize, StereoScreenCaptureMode CaptureMode);

	private delegate System.IntPtr CaptureScreenshotAsTexture_InjectedDelegate(int superSize, StereoScreenCaptureMode stereoScreenCaptureMode);

	private static readonly CaptureScreenshotIntoRenderTexture_InjectedDelegate CaptureScreenshotIntoRenderTexture_InjectedDelegateField = IL2CPP.ResolveICall<CaptureScreenshotIntoRenderTexture_InjectedDelegate>("UnityEngine.ScreenCapture::CaptureScreenshotIntoRenderTexture_Injected");

	private static readonly CaptureScreenshot_InjectedDelegate CaptureScreenshot_InjectedDelegateField = IL2CPP.ResolveICall<CaptureScreenshot_InjectedDelegate>("UnityEngine.ScreenCapture::CaptureScreenshot_Injected");

	private static readonly CaptureScreenshotAsTexture_InjectedDelegate CaptureScreenshotAsTexture_InjectedDelegateField = IL2CPP.ResolveICall<CaptureScreenshotAsTexture_InjectedDelegate>("UnityEngine.ScreenCapture::CaptureScreenshotAsTexture_Injected");

	public static void CaptureScreenshot(string filename)
	{
		CaptureScreenshot(filename, 1, StereoScreenCaptureMode.LeftEye);
	}

	public static void CaptureScreenshot(string filename, int superSize)
	{
		CaptureScreenshot(filename, superSize, StereoScreenCaptureMode.LeftEye);
	}

	public static void CaptureScreenshot(string filename, StereoScreenCaptureMode stereoCaptureMode)
	{
		CaptureScreenshot(filename, 1, stereoCaptureMode);
	}

	public static Texture2D CaptureScreenshotAsTexture()
	{
		return CaptureScreenshotAsTexture(1, StereoScreenCaptureMode.LeftEye);
	}

	public static Texture2D CaptureScreenshotAsTexture(int superSize)
	{
		return CaptureScreenshotAsTexture(superSize, StereoScreenCaptureMode.LeftEye);
	}

	public static Texture2D CaptureScreenshotAsTexture(StereoScreenCaptureMode stereoCaptureMode)
	{
		return CaptureScreenshotAsTexture(1, stereoCaptureMode);
	}

	public static void CaptureScreenshotIntoRenderTexture(RenderTexture renderTexture)
	{
		CaptureScreenshotIntoRenderTexture_Injected(Object.MarshalledUnityObject.Marshal(renderTexture));
	}

	public unsafe static void CaptureScreenshot(string filename, int superSize, StereoScreenCaptureMode CaptureMode)
	{
		//IL_0018: Expected O, but got Ref
		//IL_0024: Expected O, but got Ref
		//The blocks IL_0029 are reachable both inside and outside the pinned region starting at IL_0018. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(filename, ref managedSpanWrapper))
			{
				ReadOnlySpan<char> readOnlySpan = filename.AsSpan();
				fixed (char* begin = &((ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((ReadOnlySpan<char>)(&readOnlySpan)).Length);
					CaptureScreenshot_Injected(ref managedSpanWrapper, superSize, CaptureMode);
					return;
				}
			}
			CaptureScreenshot_Injected(ref managedSpanWrapper, superSize, CaptureMode);
		}
		finally
		{
		}
	}

	public static Texture2D CaptureScreenshotAsTexture(int superSize, StereoScreenCaptureMode stereoScreenCaptureMode)
	{
		return Unmarshal.UnmarshalUnityObject<Texture2D>(CaptureScreenshotAsTexture_Injected(superSize, stereoScreenCaptureMode));
	}

	public static void CaptureScreenshotIntoRenderTexture_Injected(System.IntPtr renderTexture)
	{
		CaptureScreenshotIntoRenderTexture_InjectedDelegateField(renderTexture);
	}

	public unsafe static void CaptureScreenshot_Injected(ref ManagedSpanWrapper filename, int superSize, StereoScreenCaptureMode CaptureMode)
	{
		CaptureScreenshot_InjectedDelegateField((nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref filename), superSize, CaptureMode);
	}

	public static System.IntPtr CaptureScreenshotAsTexture_Injected(int superSize, StereoScreenCaptureMode stereoScreenCaptureMode)
	{
		return CaptureScreenshotAsTexture_InjectedDelegateField(superSize, stereoScreenCaptureMode);
	}
}
