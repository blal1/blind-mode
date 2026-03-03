using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.Bindings;

namespace UnityEngine.Apple;

public class FrameCapture
{
	private delegate bool IsDestinationSupportedImplDelegate(FrameCaptureDestination dest);

	private delegate void EndCaptureImplDelegate();

	private delegate void BeginCaptureImpl_InjectedDelegate(FrameCaptureDestination dest, System.IntPtr path);

	private delegate void CaptureNextFrameImpl_InjectedDelegate(FrameCaptureDestination dest, System.IntPtr path);

	private static readonly IsDestinationSupportedImplDelegate IsDestinationSupportedImplDelegateField = IL2CPP.ResolveICall<IsDestinationSupportedImplDelegate>("UnityEngine.Apple.FrameCapture::IsDestinationSupportedImpl");

	private static readonly EndCaptureImplDelegate EndCaptureImplDelegateField = IL2CPP.ResolveICall<EndCaptureImplDelegate>("UnityEngine.Apple.FrameCapture::EndCaptureImpl");

	private static readonly BeginCaptureImpl_InjectedDelegate BeginCaptureImpl_InjectedDelegateField = IL2CPP.ResolveICall<BeginCaptureImpl_InjectedDelegate>("UnityEngine.Apple.FrameCapture::BeginCaptureImpl_Injected");

	private static readonly CaptureNextFrameImpl_InjectedDelegate CaptureNextFrameImpl_InjectedDelegateField = IL2CPP.ResolveICall<CaptureNextFrameImpl_InjectedDelegate>("UnityEngine.Apple.FrameCapture::CaptureNextFrameImpl_Injected");

	public static bool IsDestinationSupportedImpl(FrameCaptureDestination dest)
	{
		return IsDestinationSupportedImplDelegateField(dest);
	}

	public unsafe static void BeginCaptureImpl(FrameCaptureDestination dest, string path)
	{
		//IL_0019: Expected O, but got Ref
		//IL_0025: Expected O, but got Ref
		//The blocks IL_002a are reachable both inside and outside the pinned region starting at IL_0019. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(path, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(path);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					BeginCaptureImpl_Injected(dest, ref managedSpanWrapper);
					return;
				}
			}
			BeginCaptureImpl_Injected(dest, ref managedSpanWrapper);
		}
		finally
		{
		}
	}

	public static void EndCaptureImpl()
	{
		EndCaptureImplDelegateField();
	}

	public unsafe static void CaptureNextFrameImpl(FrameCaptureDestination dest, string path)
	{
		//IL_0019: Expected O, but got Ref
		//IL_0025: Expected O, but got Ref
		//The blocks IL_002a are reachable both inside and outside the pinned region starting at IL_0019. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(path, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(path);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					CaptureNextFrameImpl_Injected(dest, ref managedSpanWrapper);
					return;
				}
			}
			CaptureNextFrameImpl_Injected(dest, ref managedSpanWrapper);
		}
		finally
		{
		}
	}

	public static bool IsDestinationSupported(FrameCaptureDestination dest)
	{
		if (dest != FrameCaptureDestination.DevTools && dest != FrameCaptureDestination.GPUTraceDocument)
		{
			throw new Il2CppSystem.ArgumentException("dest", "Argument dest has bad value (not one of FrameCaptureDestination enum values)");
		}
		return IsDestinationSupportedImpl(dest);
	}

	public static void BeginCaptureToXcode()
	{
		if (!IsDestinationSupported(FrameCaptureDestination.DevTools))
		{
			throw new Il2CppSystem.InvalidOperationException("Frame Capture with DevTools is not supported.");
		}
		BeginCaptureImpl(FrameCaptureDestination.DevTools, null);
	}

	public static void BeginCaptureToFile(string path)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public static void EndCapture()
	{
		EndCaptureImpl();
	}

	public static void CaptureNextFrameToXcode()
	{
		if (!IsDestinationSupported(FrameCaptureDestination.DevTools))
		{
			throw new Il2CppSystem.InvalidOperationException("Frame Capture with DevTools is not supported.");
		}
		CaptureNextFrameImpl(FrameCaptureDestination.DevTools, null);
	}

	public static void CaptureNextFrameToFile(string path)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public unsafe static void BeginCaptureImpl_Injected(FrameCaptureDestination dest, ref ManagedSpanWrapper path)
	{
		BeginCaptureImpl_InjectedDelegateField(dest, (nint)Unsafe.AsPointer(ref path));
	}

	public unsafe static void CaptureNextFrameImpl_Injected(FrameCaptureDestination dest, ref ManagedSpanWrapper path)
	{
		CaptureNextFrameImpl_InjectedDelegateField(dest, (nint)Unsafe.AsPointer(ref path));
	}
}
