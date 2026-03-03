using Il2CppInterop.Runtime;

namespace UnityEngineInternal;

public class MemorylessManager
{
	private delegate MemorylessMode GetFramebufferDepthMemorylessModeDelegate();

	private delegate void SetFramebufferDepthMemorylessModeDelegate(MemorylessMode mode);

	private static readonly GetFramebufferDepthMemorylessModeDelegate GetFramebufferDepthMemorylessModeDelegateField = IL2CPP.ResolveICall<GetFramebufferDepthMemorylessModeDelegate>("UnityEngineInternal.MemorylessManager::GetFramebufferDepthMemorylessMode");

	private static readonly SetFramebufferDepthMemorylessModeDelegate SetFramebufferDepthMemorylessModeDelegateField = IL2CPP.ResolveICall<SetFramebufferDepthMemorylessModeDelegate>("UnityEngineInternal.MemorylessManager::SetFramebufferDepthMemorylessMode");

	public static MemorylessMode depthMemorylessMode
	{
		get
		{
			return GetFramebufferDepthMemorylessMode();
		}
		set
		{
			SetFramebufferDepthMemorylessMode(value);
		}
	}

	public static MemorylessMode GetFramebufferDepthMemorylessMode()
	{
		return GetFramebufferDepthMemorylessModeDelegateField();
	}

	public static void SetFramebufferDepthMemorylessMode(MemorylessMode mode)
	{
		SetFramebufferDepthMemorylessModeDelegateField(mode);
	}
}
