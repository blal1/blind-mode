using Il2CppSystem;

namespace UnityEngine.Experimental.Rendering;

public abstract class ScriptableRuntimeReflectionSystem
{
	public virtual bool TickRealtimeProbes()
	{
		return false;
	}

	public virtual void Dispose(bool disposing)
	{
	}

	public void System_002EIDisposable_002EDispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize((Il2CppSystem.Object)(object)this);
	}
}
