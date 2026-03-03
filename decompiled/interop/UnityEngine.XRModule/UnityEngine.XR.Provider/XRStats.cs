using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.Bindings;

namespace UnityEngine.XR.Provider;

public static class XRStats
{
	private delegate bool TryGetStat_Internal_InjectedDelegate(System.IntPtr ptr, System.IntPtr tag, [Out] System.IntPtr value);

	private static readonly TryGetStat_Internal_InjectedDelegate TryGetStat_Internal_InjectedDelegateField = IL2CPP.ResolveICall<TryGetStat_Internal_InjectedDelegate>("UnityEngine.XR.Provider.XRStats::TryGetStat_Internal_Injected");

	public static bool TryGetStat(IntegratedSubsystem xrSubsystem, string tag, out float value)
	{
		return TryGetStat_Internal(xrSubsystem.m_Ptr, tag, out value);
	}

	public unsafe static bool TryGetStat_Internal(System.IntPtr ptr, string tag, out float value)
	{
		//IL_0019: Expected O, but got Ref
		//IL_0025: Expected O, but got Ref
		//The blocks IL_002a are reachable both inside and outside the pinned region starting at IL_0019. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(tag, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(tag);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					return TryGetStat_Internal_Injected(ptr, ref managedSpanWrapper, out value);
				}
			}
			return TryGetStat_Internal_Injected(ptr, ref managedSpanWrapper, out value);
		}
		finally
		{
		}
	}

	public unsafe static bool TryGetStat_Internal_Injected(System.IntPtr ptr, ref ManagedSpanWrapper tag, out float value)
	{
		return TryGetStat_Internal_InjectedDelegateField(ptr, (nint)Unsafe.AsPointer(ref tag), (nint)Unsafe.AsPointer(ref value));
	}
}
