using Il2CppInterop.Runtime;

namespace UnityEngine;

public static class FrameDebugger
{
	private delegate bool IsLocalEnabledDelegate();

	private delegate bool IsRemoteEnabledDelegate();

	private static readonly IsLocalEnabledDelegate IsLocalEnabledDelegateField = IL2CPP.ResolveICall<IsLocalEnabledDelegate>("UnityEngine.FrameDebugger::IsLocalEnabled");

	private static readonly IsRemoteEnabledDelegate IsRemoteEnabledDelegateField = IL2CPP.ResolveICall<IsRemoteEnabledDelegate>("UnityEngine.FrameDebugger::IsRemoteEnabled");

	public static bool enabled => IsLocalEnabled() || IsRemoteEnabled();

	public static bool IsLocalEnabled()
	{
		return IsLocalEnabledDelegateField();
	}

	public static bool IsRemoteEnabled()
	{
		return IsRemoteEnabledDelegateField();
	}
}
