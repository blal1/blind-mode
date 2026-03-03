using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.Bindings;

namespace UnityEngine.Connect;

public class UnityConnectSettings : Object
{
	private delegate bool get_enabledDelegate();

	private delegate void set_enabledDelegate(bool value);

	private delegate bool get_testModeDelegate();

	private delegate void set_testModeDelegate(bool value);

	private delegate int get_testInitModeDelegate();

	private delegate void set_testInitModeDelegate(int value);

	private delegate void get_eventUrl_InjectedDelegate([Out] System.IntPtr ret);

	private delegate void set_eventUrl_InjectedDelegate(System.IntPtr value);

	private delegate void get_eventOldUrl_InjectedDelegate([Out] System.IntPtr ret);

	private delegate void set_eventOldUrl_InjectedDelegate(System.IntPtr value);

	private delegate void get_configUrl_InjectedDelegate([Out] System.IntPtr ret);

	private delegate void set_configUrl_InjectedDelegate(System.IntPtr value);

	private static readonly get_enabledDelegate get_enabledDelegateField = IL2CPP.ResolveICall<get_enabledDelegate>("UnityEngine.Connect.UnityConnectSettings::get_enabled");

	private static readonly set_enabledDelegate set_enabledDelegateField = IL2CPP.ResolveICall<set_enabledDelegate>("UnityEngine.Connect.UnityConnectSettings::set_enabled");

	private static readonly get_testModeDelegate get_testModeDelegateField = IL2CPP.ResolveICall<get_testModeDelegate>("UnityEngine.Connect.UnityConnectSettings::get_testMode");

	private static readonly set_testModeDelegate set_testModeDelegateField = IL2CPP.ResolveICall<set_testModeDelegate>("UnityEngine.Connect.UnityConnectSettings::set_testMode");

	private static readonly get_testInitModeDelegate get_testInitModeDelegateField = IL2CPP.ResolveICall<get_testInitModeDelegate>("UnityEngine.Connect.UnityConnectSettings::get_testInitMode");

	private static readonly set_testInitModeDelegate set_testInitModeDelegateField = IL2CPP.ResolveICall<set_testInitModeDelegate>("UnityEngine.Connect.UnityConnectSettings::set_testInitMode");

	private static readonly get_eventUrl_InjectedDelegate get_eventUrl_InjectedDelegateField = IL2CPP.ResolveICall<get_eventUrl_InjectedDelegate>("UnityEngine.Connect.UnityConnectSettings::get_eventUrl_Injected");

	private static readonly set_eventUrl_InjectedDelegate set_eventUrl_InjectedDelegateField = IL2CPP.ResolveICall<set_eventUrl_InjectedDelegate>("UnityEngine.Connect.UnityConnectSettings::set_eventUrl_Injected");

	private static readonly get_eventOldUrl_InjectedDelegate get_eventOldUrl_InjectedDelegateField = IL2CPP.ResolveICall<get_eventOldUrl_InjectedDelegate>("UnityEngine.Connect.UnityConnectSettings::get_eventOldUrl_Injected");

	private static readonly set_eventOldUrl_InjectedDelegate set_eventOldUrl_InjectedDelegateField = IL2CPP.ResolveICall<set_eventOldUrl_InjectedDelegate>("UnityEngine.Connect.UnityConnectSettings::set_eventOldUrl_Injected");

	private static readonly get_configUrl_InjectedDelegate get_configUrl_InjectedDelegateField = IL2CPP.ResolveICall<get_configUrl_InjectedDelegate>("UnityEngine.Connect.UnityConnectSettings::get_configUrl_Injected");

	private static readonly set_configUrl_InjectedDelegate set_configUrl_InjectedDelegateField = IL2CPP.ResolveICall<set_configUrl_InjectedDelegate>("UnityEngine.Connect.UnityConnectSettings::set_configUrl_Injected");

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

	public unsafe static string eventUrl
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out ManagedSpanWrapper ret);
			string stringAndDispose;
			try
			{
				get_eventUrl_Injected(out ret);
			}
			finally
			{
				stringAndDispose = OutStringMarshaller.GetStringAndDispose(ret);
			}
			return stringAndDispose;
		}
		set
		{
			//IL_0018: Expected O, but got Ref
			//IL_0024: Expected O, but got Ref
			//The blocks IL_0029 are reachable both inside and outside the pinned region starting at IL_0018. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
			try
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
				if (!StringMarshaller.TryMarshalEmptyOrNullString(value, ref managedSpanWrapper))
				{
					ReadOnlySpan<char> readOnlySpan = value.AsSpan();
					fixed (char* begin = &((ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
					{
						managedSpanWrapper = new ManagedSpanWrapper(begin, ((ReadOnlySpan<char>)(&readOnlySpan)).Length);
						set_eventUrl_Injected(ref managedSpanWrapper);
						return;
					}
				}
				set_eventUrl_Injected(ref managedSpanWrapper);
			}
			finally
			{
			}
		}
	}

	public unsafe static string eventOldUrl
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out ManagedSpanWrapper ret);
			string stringAndDispose;
			try
			{
				get_eventOldUrl_Injected(out ret);
			}
			finally
			{
				stringAndDispose = OutStringMarshaller.GetStringAndDispose(ret);
			}
			return stringAndDispose;
		}
		set
		{
			//IL_0018: Expected O, but got Ref
			//IL_0024: Expected O, but got Ref
			//The blocks IL_0029 are reachable both inside and outside the pinned region starting at IL_0018. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
			try
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
				if (!StringMarshaller.TryMarshalEmptyOrNullString(value, ref managedSpanWrapper))
				{
					ReadOnlySpan<char> readOnlySpan = value.AsSpan();
					fixed (char* begin = &((ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
					{
						managedSpanWrapper = new ManagedSpanWrapper(begin, ((ReadOnlySpan<char>)(&readOnlySpan)).Length);
						set_eventOldUrl_Injected(ref managedSpanWrapper);
						return;
					}
				}
				set_eventOldUrl_Injected(ref managedSpanWrapper);
			}
			finally
			{
			}
		}
	}

	public unsafe static string configUrl
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out ManagedSpanWrapper ret);
			string stringAndDispose;
			try
			{
				get_configUrl_Injected(out ret);
			}
			finally
			{
				stringAndDispose = OutStringMarshaller.GetStringAndDispose(ret);
			}
			return stringAndDispose;
		}
		set
		{
			//IL_0018: Expected O, but got Ref
			//IL_0024: Expected O, but got Ref
			//The blocks IL_0029 are reachable both inside and outside the pinned region starting at IL_0018. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
			try
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
				if (!StringMarshaller.TryMarshalEmptyOrNullString(value, ref managedSpanWrapper))
				{
					ReadOnlySpan<char> readOnlySpan = value.AsSpan();
					fixed (char* begin = &((ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
					{
						managedSpanWrapper = new ManagedSpanWrapper(begin, ((ReadOnlySpan<char>)(&readOnlySpan)).Length);
						set_configUrl_Injected(ref managedSpanWrapper);
						return;
					}
				}
				set_configUrl_Injected(ref managedSpanWrapper);
			}
			finally
			{
			}
		}
	}

	public static int testInitMode
	{
		get
		{
			return get_testInitModeDelegateField();
		}
		set
		{
			set_testInitModeDelegateField(value);
		}
	}

	public unsafe static void get_eventUrl_Injected(out ManagedSpanWrapper ret)
	{
		get_eventUrl_InjectedDelegateField((nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref ret));
	}

	public unsafe static void set_eventUrl_Injected(ref ManagedSpanWrapper value)
	{
		set_eventUrl_InjectedDelegateField((nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref value));
	}

	public unsafe static void get_eventOldUrl_Injected(out ManagedSpanWrapper ret)
	{
		get_eventOldUrl_InjectedDelegateField((nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref ret));
	}

	public unsafe static void set_eventOldUrl_Injected(ref ManagedSpanWrapper value)
	{
		set_eventOldUrl_InjectedDelegateField((nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref value));
	}

	public unsafe static void get_configUrl_Injected(out ManagedSpanWrapper ret)
	{
		get_configUrl_InjectedDelegateField((nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref ret));
	}

	public unsafe static void set_configUrl_Injected(ref ManagedSpanWrapper value)
	{
		set_configUrl_InjectedDelegateField((nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref value));
	}
}
