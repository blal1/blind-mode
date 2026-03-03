using Il2CppInterop.Runtime;

namespace UnityEngineInternal;

public static class GIDebugVisualisation
{
	private delegate void ResetRuntimeInputTexturesDelegate();

	private delegate void PlayCycleModeDelegate();

	private delegate void PauseCycleModeDelegate();

	private delegate void StopCycleModeDelegate();

	private delegate void CycleSkipSystemsDelegate(int skip);

	private delegate void CycleSkipInstancesDelegate(int skip);

	private delegate bool get_cycleModeDelegate();

	private delegate bool get_pauseCycleModeDelegate();

	private delegate GITextureType get_texTypeDelegate();

	private delegate void set_texTypeDelegate(GITextureType value);

	private static readonly ResetRuntimeInputTexturesDelegate ResetRuntimeInputTexturesDelegateField = IL2CPP.ResolveICall<ResetRuntimeInputTexturesDelegate>("UnityEngineInternal.GIDebugVisualisation::ResetRuntimeInputTextures");

	private static readonly PlayCycleModeDelegate PlayCycleModeDelegateField = IL2CPP.ResolveICall<PlayCycleModeDelegate>("UnityEngineInternal.GIDebugVisualisation::PlayCycleMode");

	private static readonly PauseCycleModeDelegate PauseCycleModeDelegateField = IL2CPP.ResolveICall<PauseCycleModeDelegate>("UnityEngineInternal.GIDebugVisualisation::PauseCycleMode");

	private static readonly StopCycleModeDelegate StopCycleModeDelegateField = IL2CPP.ResolveICall<StopCycleModeDelegate>("UnityEngineInternal.GIDebugVisualisation::StopCycleMode");

	private static readonly CycleSkipSystemsDelegate CycleSkipSystemsDelegateField = IL2CPP.ResolveICall<CycleSkipSystemsDelegate>("UnityEngineInternal.GIDebugVisualisation::CycleSkipSystems");

	private static readonly CycleSkipInstancesDelegate CycleSkipInstancesDelegateField = IL2CPP.ResolveICall<CycleSkipInstancesDelegate>("UnityEngineInternal.GIDebugVisualisation::CycleSkipInstances");

	private static readonly get_cycleModeDelegate get_cycleModeDelegateField = IL2CPP.ResolveICall<get_cycleModeDelegate>("UnityEngineInternal.GIDebugVisualisation::get_cycleMode");

	private static readonly get_pauseCycleModeDelegate get_pauseCycleModeDelegateField = IL2CPP.ResolveICall<get_pauseCycleModeDelegate>("UnityEngineInternal.GIDebugVisualisation::get_pauseCycleMode");

	private static readonly get_texTypeDelegate get_texTypeDelegateField = IL2CPP.ResolveICall<get_texTypeDelegate>("UnityEngineInternal.GIDebugVisualisation::get_texType");

	private static readonly set_texTypeDelegate set_texTypeDelegateField = IL2CPP.ResolveICall<set_texTypeDelegate>("UnityEngineInternal.GIDebugVisualisation::set_texType");

	public static bool cycleMode => get_cycleModeDelegateField();

	public static bool pauseCycleMode => get_pauseCycleModeDelegateField();

	public static GITextureType texType
	{
		get
		{
			return get_texTypeDelegateField();
		}
		set
		{
			set_texTypeDelegateField(value);
		}
	}

	public static void ResetRuntimeInputTextures()
	{
		ResetRuntimeInputTexturesDelegateField();
	}

	public static void PlayCycleMode()
	{
		PlayCycleModeDelegateField();
	}

	public static void PauseCycleMode()
	{
		PauseCycleModeDelegateField();
	}

	public static void StopCycleMode()
	{
		StopCycleModeDelegateField();
	}

	public static void CycleSkipSystems(int skip)
	{
		CycleSkipSystemsDelegateField(skip);
	}

	public static void CycleSkipInstances(int skip)
	{
		CycleSkipInstancesDelegateField(skip);
	}
}
