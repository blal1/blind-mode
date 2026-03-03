using System;
using Il2CppInterop.Runtime;

namespace Unity.Audio;

public struct ExecuteContextInternal
{
	private delegate void Internal_PostEventDelegate(System.IntPtr dspNodePtr, long eventTypeHashCode, System.IntPtr eventPtr, int eventSize);

	private static readonly Internal_PostEventDelegate Internal_PostEventDelegateField = IL2CPP.ResolveICall<Internal_PostEventDelegate>("Unity.Audio.ExecuteContextInternal::Internal_PostEvent");

	public unsafe static void Internal_PostEvent(void* dspNodePtr, long eventTypeHashCode, void* eventPtr, int eventSize)
	{
		Internal_PostEventDelegateField((nint)dspNodePtr, eventTypeHashCode, (nint)eventPtr, eventSize);
	}
}
