using System;
using Il2CppInterop.Runtime;

namespace UnityEngine;

public class UnityEventQueueSystem
{
	private delegate IntPtr GetGlobalEventQueueDelegate();

	private static readonly GetGlobalEventQueueDelegate GetGlobalEventQueueDelegateField = IL2CPP.ResolveICall<GetGlobalEventQueueDelegate>("UnityEngine.UnityEventQueueSystem::GetGlobalEventQueue");

	public static string GenerateEventIdForPayload(string eventPayloadName)
	{
		throw new NotSupportedException("Method unstripping failed");
	}

	public static IntPtr GetGlobalEventQueue()
	{
		return GetGlobalEventQueueDelegateField();
	}
}
