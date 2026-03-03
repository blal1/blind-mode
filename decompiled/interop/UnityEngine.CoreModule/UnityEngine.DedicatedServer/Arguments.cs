using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Il2CppSystem.IO;
using UnityEngine.Bindings;

namespace UnityEngine.DedicatedServer;

public static class Arguments
{
	public enum ArgumentErrorPolicy
	{
		Ignore,
		Warn,
		Fatal
	}

	private delegate void SetArgumentErrorPolicyDelegate(ArgumentErrorPolicy policy);

	private delegate ArgumentErrorPolicy GetArgumentErrorPolicyDelegate();

	private delegate bool GetBoolArgument_InjectedDelegate(System.IntPtr arg);

	private delegate bool GetIntArgument_InjectedDelegate(System.IntPtr arg, [Out] System.IntPtr intValue);

	private delegate bool GetStringArgument_InjectedDelegate(System.IntPtr arg, [Out] System.IntPtr stringValue);

	private delegate void SetBoolArgument_InjectedDelegate(System.IntPtr arg);

	private delegate void SetIntArgument_InjectedDelegate(System.IntPtr arg, int intValue);

	private delegate void SetStringArgument_InjectedDelegate(System.IntPtr arg, System.IntPtr stringValue);

	private static readonly SetArgumentErrorPolicyDelegate SetArgumentErrorPolicyDelegateField = IL2CPP.ResolveICall<SetArgumentErrorPolicyDelegate>("UnityEngine.DedicatedServer.Arguments::SetArgumentErrorPolicy");

	private static readonly GetArgumentErrorPolicyDelegate GetArgumentErrorPolicyDelegateField = IL2CPP.ResolveICall<GetArgumentErrorPolicyDelegate>("UnityEngine.DedicatedServer.Arguments::GetArgumentErrorPolicy");

	private static readonly GetBoolArgument_InjectedDelegate GetBoolArgument_InjectedDelegateField = IL2CPP.ResolveICall<GetBoolArgument_InjectedDelegate>("UnityEngine.DedicatedServer.Arguments::GetBoolArgument_Injected");

	private static readonly GetIntArgument_InjectedDelegate GetIntArgument_InjectedDelegateField = IL2CPP.ResolveICall<GetIntArgument_InjectedDelegate>("UnityEngine.DedicatedServer.Arguments::GetIntArgument_Injected");

	private static readonly GetStringArgument_InjectedDelegate GetStringArgument_InjectedDelegateField = IL2CPP.ResolveICall<GetStringArgument_InjectedDelegate>("UnityEngine.DedicatedServer.Arguments::GetStringArgument_Injected");

	private static readonly SetBoolArgument_InjectedDelegate SetBoolArgument_InjectedDelegateField = IL2CPP.ResolveICall<SetBoolArgument_InjectedDelegate>("UnityEngine.DedicatedServer.Arguments::SetBoolArgument_Injected");

	private static readonly SetIntArgument_InjectedDelegate SetIntArgument_InjectedDelegateField = IL2CPP.ResolveICall<SetIntArgument_InjectedDelegate>("UnityEngine.DedicatedServer.Arguments::SetIntArgument_Injected");

	private static readonly SetStringArgument_InjectedDelegate SetStringArgument_InjectedDelegateField = IL2CPP.ResolveICall<SetStringArgument_InjectedDelegate>("UnityEngine.DedicatedServer.Arguments::SetStringArgument_Injected");

	public unsafe static Il2CppSystem.Nullable<int> Port
	{
		get
		{
			if (GetIntArgument("port", out var intValue))
			{
				return new Il2CppSystem.Nullable<int>(intValue);
			}
			return null;
		}
		set
		{
			//IL_0008: Expected O, but got Ref
			int valueOrDefault = ((Il2CppSystem.Nullable<int>)(&value)).GetValueOrDefault();
			SetIntArgument("port", valueOrDefault);
		}
	}

	public unsafe static Il2CppSystem.Nullable<int> TargetFramerate
	{
		get
		{
			if (GetIntArgument("framerate", out var intValue))
			{
				return new Il2CppSystem.Nullable<int>(intValue);
			}
			return null;
		}
		set
		{
			//IL_0008: Expected O, but got Ref
			int valueOrDefault = ((Il2CppSystem.Nullable<int>)(&value)).GetValueOrDefault();
			SetIntArgument("framerate", valueOrDefault);
		}
	}

	public unsafe static Il2CppSystem.Nullable<int> LogLevel
	{
		get
		{
			if (GetIntArgument("loglevel", out var intValue))
			{
				return new Il2CppSystem.Nullable<int>(intValue);
			}
			return null;
		}
		set
		{
			//IL_0008: Expected O, but got Ref
			int valueOrDefault = ((Il2CppSystem.Nullable<int>)(&value)).GetValueOrDefault();
			SetIntArgument("loglevel", valueOrDefault);
		}
	}

	public static string LogPath
	{
		get
		{
			if (GetStringArgument("logpath", out var stringValue))
			{
				return stringValue;
			}
			if (GetStringArgument("logfile", out stringValue))
			{
				return Path.GetDirectoryName(stringValue);
			}
			return null;
		}
		set
		{
			SetStringArgument("logpath", value);
		}
	}

	public unsafe static Il2CppSystem.Nullable<int> QueryPort
	{
		get
		{
			if (GetIntArgument("queryport", out var intValue))
			{
				return new Il2CppSystem.Nullable<int>(intValue);
			}
			return null;
		}
		set
		{
			//IL_0008: Expected O, but got Ref
			int valueOrDefault = ((Il2CppSystem.Nullable<int>)(&value)).GetValueOrDefault();
			SetIntArgument("queryport", valueOrDefault);
		}
	}

	public static string QueryType
	{
		get
		{
			if (GetStringArgument("querytype", out var stringValue))
			{
				return stringValue;
			}
			return null;
		}
		set
		{
			SetStringArgument("querytype", value);
		}
	}

	public static ArgumentErrorPolicy ErrorPolicy
	{
		get
		{
			return GetArgumentErrorPolicy();
		}
		set
		{
			SetArgumentErrorPolicy(value);
		}
	}

	public unsafe static bool GetBoolArgument(string arg)
	{
		//IL_0018: Expected O, but got Ref
		//IL_0024: Expected O, but got Ref
		//The blocks IL_0029 are reachable both inside and outside the pinned region starting at IL_0018. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(arg, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(arg);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					return GetBoolArgument_Injected(ref managedSpanWrapper);
				}
			}
			return GetBoolArgument_Injected(ref managedSpanWrapper);
		}
		finally
		{
		}
	}

	public unsafe static bool GetIntArgument(string arg, out int intValue)
	{
		//IL_0018: Expected O, but got Ref
		//IL_0024: Expected O, but got Ref
		//The blocks IL_0029 are reachable both inside and outside the pinned region starting at IL_0018. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(arg, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(arg);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					return GetIntArgument_Injected(ref managedSpanWrapper, out intValue);
				}
			}
			return GetIntArgument_Injected(ref managedSpanWrapper, out intValue);
		}
		finally
		{
		}
	}

	public unsafe static bool GetStringArgument(string arg, out string stringValue)
	{
		//IL_0018: Expected O, but got Ref
		//IL_0024: Expected O, but got Ref
		//The blocks IL_0029 are reachable both inside and outside the pinned region starting at IL_0018. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		Unsafe.SkipInit(out ManagedSpanWrapper stringValue2);
		try
		{
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(arg, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(arg);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					return GetStringArgument_Injected(ref managedSpanWrapper, out stringValue2);
				}
			}
			return GetStringArgument_Injected(ref managedSpanWrapper, out stringValue2);
		}
		finally
		{
			stringValue = OutStringMarshaller.GetStringAndDispose(stringValue2);
		}
	}

	public unsafe static void SetBoolArgument(string arg)
	{
		//IL_0018: Expected O, but got Ref
		//IL_0024: Expected O, but got Ref
		//The blocks IL_0029 are reachable both inside and outside the pinned region starting at IL_0018. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(arg, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(arg);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					SetBoolArgument_Injected(ref managedSpanWrapper);
					return;
				}
			}
			SetBoolArgument_Injected(ref managedSpanWrapper);
		}
		finally
		{
		}
	}

	public unsafe static void SetIntArgument(string arg, int intValue)
	{
		//IL_0018: Expected O, but got Ref
		//IL_0024: Expected O, but got Ref
		//The blocks IL_0029 are reachable both inside and outside the pinned region starting at IL_0018. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(arg, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(arg);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					SetIntArgument_Injected(ref managedSpanWrapper, intValue);
					return;
				}
			}
			SetIntArgument_Injected(ref managedSpanWrapper, intValue);
		}
		finally
		{
		}
	}

	public unsafe static void SetStringArgument(string arg, string stringValue)
	{
		//IL_0018: Expected O, but got Ref
		//IL_0024: Expected O, but got Ref
		//IL_0044: Expected O, but got Ref
		//IL_0052: Expected O, but got Ref
		//The blocks IL_0029, IL_0036, IL_0044, IL_0052, IL_0057 are reachable both inside and outside the pinned region starting at IL_0018. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		//The blocks IL_0057 are reachable both inside and outside the pinned region starting at IL_0044. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		//The blocks IL_0057 are reachable both inside and outside the pinned region starting at IL_0044. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			ref ManagedSpanWrapper arg2;
			Il2CppSystem.ReadOnlySpan<char> readOnlySpan2;
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper2);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(arg, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(arg);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					arg2 = ref managedSpanWrapper;
					if (!StringMarshaller.TryMarshalEmptyOrNullString(stringValue, ref managedSpanWrapper2))
					{
						readOnlySpan2 = Il2CppSystem.MemoryExtensions.AsSpan(stringValue);
						fixed (char* begin2 = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan2)).GetPinnableReference())
						{
							managedSpanWrapper2 = new ManagedSpanWrapper(begin2, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan2)).Length);
							SetStringArgument_Injected(ref arg2, ref managedSpanWrapper2);
							return;
						}
					}
					SetStringArgument_Injected(ref arg2, ref managedSpanWrapper2);
					return;
				}
			}
			arg2 = ref managedSpanWrapper;
			if (!StringMarshaller.TryMarshalEmptyOrNullString(stringValue, ref managedSpanWrapper2))
			{
				readOnlySpan2 = Il2CppSystem.MemoryExtensions.AsSpan(stringValue);
				fixed (char* begin2 = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan2)).GetPinnableReference())
				{
					managedSpanWrapper2 = new ManagedSpanWrapper(begin2, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan2)).Length);
					SetStringArgument_Injected(ref arg2, ref managedSpanWrapper2);
					return;
				}
			}
			SetStringArgument_Injected(ref arg2, ref managedSpanWrapper2);
		}
		finally
		{
		}
	}

	public static void SetArgumentErrorPolicy(ArgumentErrorPolicy policy)
	{
		SetArgumentErrorPolicyDelegateField(policy);
	}

	public static ArgumentErrorPolicy GetArgumentErrorPolicy()
	{
		return GetArgumentErrorPolicyDelegateField();
	}

	public unsafe static bool GetBoolArgument_Injected(ref ManagedSpanWrapper arg)
	{
		return GetBoolArgument_InjectedDelegateField((nint)Unsafe.AsPointer(ref arg));
	}

	public unsafe static bool GetIntArgument_Injected(ref ManagedSpanWrapper arg, out int intValue)
	{
		return GetIntArgument_InjectedDelegateField((nint)Unsafe.AsPointer(ref arg), (nint)Unsafe.AsPointer(ref intValue));
	}

	public unsafe static bool GetStringArgument_Injected(ref ManagedSpanWrapper arg, out ManagedSpanWrapper stringValue)
	{
		return GetStringArgument_InjectedDelegateField((nint)Unsafe.AsPointer(ref arg), (nint)Unsafe.AsPointer(ref stringValue));
	}

	public unsafe static void SetBoolArgument_Injected(ref ManagedSpanWrapper arg)
	{
		SetBoolArgument_InjectedDelegateField((nint)Unsafe.AsPointer(ref arg));
	}

	public unsafe static void SetIntArgument_Injected(ref ManagedSpanWrapper arg, int intValue)
	{
		SetIntArgument_InjectedDelegateField((nint)Unsafe.AsPointer(ref arg), intValue);
	}

	public unsafe static void SetStringArgument_Injected(ref ManagedSpanWrapper arg, ref ManagedSpanWrapper stringValue)
	{
		SetStringArgument_InjectedDelegateField((nint)Unsafe.AsPointer(ref arg), (nint)Unsafe.AsPointer(ref stringValue));
	}
}
