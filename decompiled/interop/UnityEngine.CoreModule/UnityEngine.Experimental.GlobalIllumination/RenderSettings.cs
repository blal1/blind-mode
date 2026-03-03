using Il2CppInterop.Runtime;

namespace UnityEngine.Experimental.GlobalIllumination;

public class RenderSettings
{
	private delegate bool get_useRadianceAmbientProbeDelegate();

	private delegate void set_useRadianceAmbientProbeDelegate(bool value);

	private static readonly get_useRadianceAmbientProbeDelegate get_useRadianceAmbientProbeDelegateField = IL2CPP.ResolveICall<get_useRadianceAmbientProbeDelegate>("UnityEngine.Experimental.GlobalIllumination.RenderSettings::get_useRadianceAmbientProbe");

	private static readonly set_useRadianceAmbientProbeDelegate set_useRadianceAmbientProbeDelegateField = IL2CPP.ResolveICall<set_useRadianceAmbientProbeDelegate>("UnityEngine.Experimental.GlobalIllumination.RenderSettings::set_useRadianceAmbientProbe");

	public static bool useRadianceAmbientProbe
	{
		get
		{
			return get_useRadianceAmbientProbeDelegateField();
		}
		set
		{
			set_useRadianceAmbientProbeDelegateField(value);
		}
	}
}
