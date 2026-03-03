using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.Bindings;

namespace UnityEngine;

public class HmiPlatform
{
	private delegate void LogStartupTiming_InjectedDelegate(System.IntPtr tag);

	private static readonly LogStartupTiming_InjectedDelegate LogStartupTiming_InjectedDelegateField = IL2CPP.ResolveICall<LogStartupTiming_InjectedDelegate>("UnityEngine.HmiPlatform::LogStartupTiming_Injected");

	public unsafe static void LogStartupTiming(string tag)
	{
		//IL_0018: Expected O, but got Ref
		//IL_0024: Expected O, but got Ref
		//The blocks IL_0029 are reachable both inside and outside the pinned region starting at IL_0018. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(tag, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(tag);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					LogStartupTiming_Injected(ref managedSpanWrapper);
					return;
				}
			}
			LogStartupTiming_Injected(ref managedSpanWrapper);
		}
		finally
		{
		}
	}

	public unsafe static void LogStartupTiming_Injected(ref ManagedSpanWrapper tag)
	{
		LogStartupTiming_InjectedDelegateField((nint)Unsafe.AsPointer(ref tag));
	}
}
