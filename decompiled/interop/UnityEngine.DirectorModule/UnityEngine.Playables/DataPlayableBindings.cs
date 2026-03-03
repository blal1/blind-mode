using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;

namespace UnityEngine.Playables;

public static class DataPlayableBindings
{
	private delegate bool CreateHandleInternal_InjectedDelegate([In] IntPtr graph, IntPtr handle);

	private static readonly CreateHandleInternal_InjectedDelegate CreateHandleInternal_InjectedDelegateField = IL2CPP.ResolveICall<CreateHandleInternal_InjectedDelegate>("UnityEngine.Playables.DataPlayableBindings::CreateHandleInternal_Injected");

	public static bool CreateHandleInternal(PlayableGraph graph, ref PlayableHandle handle)
	{
		return CreateHandleInternal_Injected(ref graph, ref handle);
	}

	public unsafe static bool CreateHandleInternal_Injected([In] ref PlayableGraph graph, ref PlayableHandle handle)
	{
		return CreateHandleInternal_InjectedDelegateField((nint)Unsafe.AsPointer(ref graph), (nint)Unsafe.AsPointer(ref handle));
	}
}
