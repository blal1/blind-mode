using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.Bindings;
using UnityEngine.Playables;

namespace UnityEngine.Experimental.Playables;

public static class TexturePlayableGraphExtensions
{
	private delegate bool InternalCreateTextureOutput_InjectedDelegate(System.IntPtr graph, System.IntPtr name, [Out] System.IntPtr handle);

	private static readonly InternalCreateTextureOutput_InjectedDelegate InternalCreateTextureOutput_InjectedDelegateField = IL2CPP.ResolveICall<InternalCreateTextureOutput_InjectedDelegate>("UnityEngine.Experimental.Playables.TexturePlayableGraphExtensions::InternalCreateTextureOutput_Injected");

	public unsafe static bool InternalCreateTextureOutput(ref PlayableGraph graph, string name, out PlayableOutputHandle handle)
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
					return InternalCreateTextureOutput_Injected(ref graph, ref managedSpanWrapper, out handle);
				}
			}
			return InternalCreateTextureOutput_Injected(ref graph, ref managedSpanWrapper, out handle);
		}
		finally
		{
		}
	}

	public unsafe static bool InternalCreateTextureOutput_Injected(ref PlayableGraph graph, ref ManagedSpanWrapper name, out PlayableOutputHandle handle)
	{
		return InternalCreateTextureOutput_InjectedDelegateField((nint)Unsafe.AsPointer(ref graph), (nint)Unsafe.AsPointer(ref name), (nint)Unsafe.AsPointer(ref handle));
	}
}
