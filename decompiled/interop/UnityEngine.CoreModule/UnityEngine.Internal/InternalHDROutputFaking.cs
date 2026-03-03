using Il2CppInterop.Runtime;

namespace UnityEngine.Internal;

public static class InternalHDROutputFaking
{
	private delegate void SetEnabledDelegate(bool enabled);

	private static readonly SetEnabledDelegate SetEnabledDelegateField = IL2CPP.ResolveICall<SetEnabledDelegate>("UnityEngine.Internal.InternalHDROutputFaking::SetEnabled");

	public static void SetEnabled(bool enabled)
	{
		SetEnabledDelegateField(enabled);
	}
}
