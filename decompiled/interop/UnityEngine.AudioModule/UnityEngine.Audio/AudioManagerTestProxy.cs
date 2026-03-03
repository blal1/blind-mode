using Il2CppInterop.Runtime;

namespace UnityEngine.Audio;

public sealed class AudioManagerTestProxy
{
	private delegate bool ComputeAudibilityConsistencyDelegate();

	private static readonly ComputeAudibilityConsistencyDelegate ComputeAudibilityConsistencyDelegateField = IL2CPP.ResolveICall<ComputeAudibilityConsistencyDelegate>("UnityEngine.Audio.AudioManagerTestProxy::ComputeAudibilityConsistency");

	public static bool ComputeAudibilityConsistency()
	{
		return ComputeAudibilityConsistencyDelegateField();
	}
}
