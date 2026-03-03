using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Loading;

public static class ContentLoadInterface
{
	private delegate float get_IntegrationTimeMSDelegate();

	private delegate void set_IntegrationTimeMSDelegate(float value);

	private static readonly get_IntegrationTimeMSDelegate get_IntegrationTimeMSDelegateField = IL2CPP.ResolveICall<get_IntegrationTimeMSDelegate>("Unity.Loading.ContentLoadInterface::get_IntegrationTimeMS");

	private static readonly set_IntegrationTimeMSDelegate set_IntegrationTimeMSDelegateField = IL2CPP.ResolveICall<set_IntegrationTimeMSDelegate>("Unity.Loading.ContentLoadInterface::set_IntegrationTimeMS");

	public static float IntegrationTimeMS
	{
		get
		{
			return get_IntegrationTimeMSDelegateField();
		}
		set
		{
			set_IntegrationTimeMSDelegateField(value);
		}
	}

	public static float GetIntegrationTimeMS()
	{
		return IntegrationTimeMS;
	}

	public static void SetIntegrationTimeMS(float integrationTimeMS)
	{
		if (integrationTimeMS <= 0f)
		{
			throw new ArgumentOutOfRangeException("integrationTimeMS", "integrationTimeMS was out of range. Must be greater than zero.");
		}
		IntegrationTimeMS = integrationTimeMS;
	}
}
