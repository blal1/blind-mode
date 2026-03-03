using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using UnityEngine.Bindings;

namespace UnityEngine.Playables;

public static class DataPlayableOutputExtensions
{
	private delegate bool InternalCreateDataOutput_InjectedDelegate(System.IntPtr graph, System.IntPtr name, System.IntPtr type, [Out] System.IntPtr handle);

	private static readonly InternalCreateDataOutput_InjectedDelegate InternalCreateDataOutput_InjectedDelegateField = IL2CPP.ResolveICall<InternalCreateDataOutput_InjectedDelegate>("UnityEngine.Playables.DataPlayableOutputExtensions::InternalCreateDataOutput_Injected");

	public unsafe static bool InternalCreateDataOutput(ref PlayableGraph graph, string name, Il2CppSystem.Type type, out PlayableOutputHandle handle)
	{
		//IL_0019: Expected O, but got Ref
		//IL_0025: Expected O, but got Ref
		//The blocks IL_002a are reachable both inside and outside the pinned region starting at IL_0019. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(name, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(name);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					return InternalCreateDataOutput_Injected(ref graph, ref managedSpanWrapper, type, out handle);
				}
			}
			return InternalCreateDataOutput_Injected(ref graph, ref managedSpanWrapper, type, out handle);
		}
		finally
		{
		}
	}

	public unsafe static bool InternalCreateDataOutput_Injected(ref PlayableGraph graph, ref ManagedSpanWrapper name, Il2CppSystem.Type type, out PlayableOutputHandle handle)
	{
		return InternalCreateDataOutput_InjectedDelegateField((nint)Unsafe.AsPointer(ref graph), (nint)Unsafe.AsPointer(ref name), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type), (nint)Unsafe.AsPointer(ref handle));
	}
}
