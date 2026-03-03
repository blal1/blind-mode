using Il2CppInterop.Runtime;

namespace UnityEngine.Rendering;

public static class LoadStoreActionDebugModeSettings
{
	private delegate bool get_LoadStoreDebugModeEnabledDelegate();

	private delegate void set_LoadStoreDebugModeEnabledDelegate(bool value);

	private static readonly get_LoadStoreDebugModeEnabledDelegate get_LoadStoreDebugModeEnabledDelegateField = IL2CPP.ResolveICall<get_LoadStoreDebugModeEnabledDelegate>("UnityEngine.Rendering.LoadStoreActionDebugModeSettings::get_LoadStoreDebugModeEnabled");

	private static readonly set_LoadStoreDebugModeEnabledDelegate set_LoadStoreDebugModeEnabledDelegateField = IL2CPP.ResolveICall<set_LoadStoreDebugModeEnabledDelegate>("UnityEngine.Rendering.LoadStoreActionDebugModeSettings::set_LoadStoreDebugModeEnabled");

	public static bool LoadStoreDebugModeEnabled
	{
		get
		{
			return get_LoadStoreDebugModeEnabledDelegateField();
		}
		set
		{
			set_LoadStoreDebugModeEnabledDelegateField(value);
		}
	}
}
