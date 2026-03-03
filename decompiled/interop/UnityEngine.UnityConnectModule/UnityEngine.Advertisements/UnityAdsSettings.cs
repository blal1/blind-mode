using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.Bindings;

namespace UnityEngine.Advertisements;

public static class UnityAdsSettings
{
	private delegate bool get_enabledDelegate();

	private delegate void set_enabledDelegate(bool value);

	private delegate bool get_initializeOnStartupDelegate();

	private delegate void set_initializeOnStartupDelegate(bool value);

	private delegate bool get_testModeDelegate();

	private delegate void set_testModeDelegate(bool value);

	private delegate void GetGameId_InjectedDelegate(RuntimePlatform platform, [Out] System.IntPtr ret);

	private delegate void SetGameId_InjectedDelegate(RuntimePlatform platform, System.IntPtr gameId);

	private static readonly get_enabledDelegate get_enabledDelegateField = IL2CPP.ResolveICall<get_enabledDelegate>("UnityEngine.Advertisements.UnityAdsSettings::get_enabled");

	private static readonly set_enabledDelegate set_enabledDelegateField = IL2CPP.ResolveICall<set_enabledDelegate>("UnityEngine.Advertisements.UnityAdsSettings::set_enabled");

	private static readonly get_initializeOnStartupDelegate get_initializeOnStartupDelegateField = IL2CPP.ResolveICall<get_initializeOnStartupDelegate>("UnityEngine.Advertisements.UnityAdsSettings::get_initializeOnStartup");

	private static readonly set_initializeOnStartupDelegate set_initializeOnStartupDelegateField = IL2CPP.ResolveICall<set_initializeOnStartupDelegate>("UnityEngine.Advertisements.UnityAdsSettings::set_initializeOnStartup");

	private static readonly get_testModeDelegate get_testModeDelegateField = IL2CPP.ResolveICall<get_testModeDelegate>("UnityEngine.Advertisements.UnityAdsSettings::get_testMode");

	private static readonly set_testModeDelegate set_testModeDelegateField = IL2CPP.ResolveICall<set_testModeDelegate>("UnityEngine.Advertisements.UnityAdsSettings::set_testMode");

	private static readonly GetGameId_InjectedDelegate GetGameId_InjectedDelegateField = IL2CPP.ResolveICall<GetGameId_InjectedDelegate>("UnityEngine.Advertisements.UnityAdsSettings::GetGameId_Injected");

	private static readonly SetGameId_InjectedDelegate SetGameId_InjectedDelegateField = IL2CPP.ResolveICall<SetGameId_InjectedDelegate>("UnityEngine.Advertisements.UnityAdsSettings::SetGameId_Injected");

	public static bool enabled
	{
		get
		{
			return get_enabledDelegateField();
		}
		set
		{
			set_enabledDelegateField(value);
		}
	}

	public static bool initializeOnStartup
	{
		get
		{
			return get_initializeOnStartupDelegateField();
		}
		set
		{
			set_initializeOnStartupDelegateField(value);
		}
	}

	public static bool testMode
	{
		get
		{
			return get_testModeDelegateField();
		}
		set
		{
			set_testModeDelegateField(value);
		}
	}

	public static bool IsPlatformEnabled(RuntimePlatform platform)
	{
		return true;
	}

	public static void SetPlatformEnabled(RuntimePlatform platform, bool value)
	{
	}

	public static string GetGameId(RuntimePlatform platform)
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ManagedSpanWrapper ret);
		string stringAndDispose;
		try
		{
			GetGameId_Injected(platform, out ret);
		}
		finally
		{
			stringAndDispose = OutStringMarshaller.GetStringAndDispose(ret);
		}
		return stringAndDispose;
	}

	public unsafe static void SetGameId(RuntimePlatform platform, string gameId)
	{
		//IL_0019: Expected O, but got Ref
		//IL_0025: Expected O, but got Ref
		//The blocks IL_002a are reachable both inside and outside the pinned region starting at IL_0019. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(gameId, ref managedSpanWrapper))
			{
				ReadOnlySpan<char> readOnlySpan = gameId.AsSpan();
				fixed (char* begin = &((ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((ReadOnlySpan<char>)(&readOnlySpan)).Length);
					SetGameId_Injected(platform, ref managedSpanWrapper);
					return;
				}
			}
			SetGameId_Injected(platform, ref managedSpanWrapper);
		}
		finally
		{
		}
	}

	public unsafe static void GetGameId_Injected(RuntimePlatform platform, out ManagedSpanWrapper ret)
	{
		GetGameId_InjectedDelegateField(platform, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref ret));
	}

	public unsafe static void SetGameId_Injected(RuntimePlatform platform, ref ManagedSpanWrapper gameId)
	{
		SetGameId_InjectedDelegateField(platform, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref gameId));
	}
}
