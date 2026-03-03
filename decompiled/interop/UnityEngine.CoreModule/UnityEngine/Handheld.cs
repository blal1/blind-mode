using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.Bindings;

namespace UnityEngine;

public class Handheld
{
	private delegate void VibrateDelegate();

	private delegate bool GetUse32BitDisplayBuffer_BindingsDelegate();

	private delegate void SetActivityIndicatorStyleImpl_BindingsDelegate(int style);

	private delegate int GetActivityIndicatorStyleDelegate();

	private delegate void StartActivityIndicatorDelegate();

	private delegate void StopActivityIndicatorDelegate();

	private delegate void ClearShaderCacheDelegate();

	private delegate bool PlayFullScreenMovie_Bindings_InjectedDelegate(System.IntPtr path, [In] System.IntPtr bgColor, FullScreenMovieControlMode controlMode, FullScreenMovieScalingMode scalingMode);

	private static readonly VibrateDelegate VibrateDelegateField = IL2CPP.ResolveICall<VibrateDelegate>("UnityEngine.Handheld::Vibrate");

	private static readonly GetUse32BitDisplayBuffer_BindingsDelegate GetUse32BitDisplayBuffer_BindingsDelegateField = IL2CPP.ResolveICall<GetUse32BitDisplayBuffer_BindingsDelegate>("UnityEngine.Handheld::GetUse32BitDisplayBuffer_Bindings");

	private static readonly SetActivityIndicatorStyleImpl_BindingsDelegate SetActivityIndicatorStyleImpl_BindingsDelegateField = IL2CPP.ResolveICall<SetActivityIndicatorStyleImpl_BindingsDelegate>("UnityEngine.Handheld::SetActivityIndicatorStyleImpl_Bindings");

	private static readonly GetActivityIndicatorStyleDelegate GetActivityIndicatorStyleDelegateField = IL2CPP.ResolveICall<GetActivityIndicatorStyleDelegate>("UnityEngine.Handheld::GetActivityIndicatorStyle");

	private static readonly StartActivityIndicatorDelegate StartActivityIndicatorDelegateField = IL2CPP.ResolveICall<StartActivityIndicatorDelegate>("UnityEngine.Handheld::StartActivityIndicator");

	private static readonly StopActivityIndicatorDelegate StopActivityIndicatorDelegateField = IL2CPP.ResolveICall<StopActivityIndicatorDelegate>("UnityEngine.Handheld::StopActivityIndicator");

	private static readonly ClearShaderCacheDelegate ClearShaderCacheDelegateField = IL2CPP.ResolveICall<ClearShaderCacheDelegate>("UnityEngine.Handheld::ClearShaderCache");

	private static readonly PlayFullScreenMovie_Bindings_InjectedDelegate PlayFullScreenMovie_Bindings_InjectedDelegateField = IL2CPP.ResolveICall<PlayFullScreenMovie_Bindings_InjectedDelegate>("UnityEngine.Handheld::PlayFullScreenMovie_Bindings_Injected");

	public static bool use32BitDisplayBuffer
	{
		get
		{
			return GetUse32BitDisplayBuffer_Bindings();
		}
		set
		{
		}
	}

	public static bool PlayFullScreenMovie(string path, Color bgColor, FullScreenMovieControlMode controlMode, FullScreenMovieScalingMode scalingMode)
	{
		return PlayFullScreenMovie_Bindings(path, bgColor, controlMode, scalingMode);
	}

	public static bool PlayFullScreenMovie(string path, Color bgColor, FullScreenMovieControlMode controlMode)
	{
		FullScreenMovieScalingMode scalingMode = FullScreenMovieScalingMode.AspectFit;
		return PlayFullScreenMovie_Bindings(path, bgColor, controlMode, scalingMode);
	}

	public static bool PlayFullScreenMovie(string path, Color bgColor)
	{
		FullScreenMovieScalingMode scalingMode = FullScreenMovieScalingMode.AspectFit;
		FullScreenMovieControlMode controlMode = FullScreenMovieControlMode.Full;
		return PlayFullScreenMovie_Bindings(path, bgColor, controlMode, scalingMode);
	}

	public static bool PlayFullScreenMovie(string path)
	{
		FullScreenMovieScalingMode scalingMode = FullScreenMovieScalingMode.AspectFit;
		FullScreenMovieControlMode controlMode = FullScreenMovieControlMode.Full;
		Color black = Color.black;
		return PlayFullScreenMovie_Bindings(path, black, controlMode, scalingMode);
	}

	public unsafe static bool PlayFullScreenMovie_Bindings(string path, Color bgColor, FullScreenMovieControlMode controlMode, FullScreenMovieScalingMode scalingMode)
	{
		//IL_0018: Expected O, but got Ref
		//IL_0024: Expected O, but got Ref
		//The blocks IL_0029 are reachable both inside and outside the pinned region starting at IL_0018. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(path, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(path);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					return PlayFullScreenMovie_Bindings_Injected(ref managedSpanWrapper, ref bgColor, controlMode, scalingMode);
				}
			}
			return PlayFullScreenMovie_Bindings_Injected(ref managedSpanWrapper, ref bgColor, controlMode, scalingMode);
		}
		finally
		{
		}
	}

	public static void Vibrate()
	{
		VibrateDelegateField();
	}

	public static bool GetUse32BitDisplayBuffer_Bindings()
	{
		return GetUse32BitDisplayBuffer_BindingsDelegateField();
	}

	public static void SetActivityIndicatorStyleImpl_Bindings(int style)
	{
		SetActivityIndicatorStyleImpl_BindingsDelegateField(style);
	}

	public static void SetActivityIndicatorStyle(AndroidActivityIndicatorStyle style)
	{
		SetActivityIndicatorStyleImpl_Bindings((int)style);
	}

	public static int GetActivityIndicatorStyle()
	{
		return GetActivityIndicatorStyleDelegateField();
	}

	public static void StartActivityIndicator()
	{
		StartActivityIndicatorDelegateField();
	}

	public static void StopActivityIndicator()
	{
		StopActivityIndicatorDelegateField();
	}

	public static void ClearShaderCache()
	{
		ClearShaderCacheDelegateField();
	}

	public unsafe static bool PlayFullScreenMovie_Bindings_Injected(ref ManagedSpanWrapper path, [In] ref Color bgColor, FullScreenMovieControlMode controlMode, FullScreenMovieScalingMode scalingMode)
	{
		return PlayFullScreenMovie_Bindings_InjectedDelegateField((nint)Unsafe.AsPointer(ref path), (nint)Unsafe.AsPointer(ref bgColor), controlMode, scalingMode);
	}
}
