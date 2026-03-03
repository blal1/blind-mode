using Il2CppInterop.Runtime;

namespace UnityEngine;

public class LocationService
{
	private delegate bool IsServiceEnabledByUserDelegate();

	private delegate LocationServiceStatus GetLocationStatusDelegate();

	private delegate void SetDesiredAccuracyDelegate(float value);

	private delegate void SetDistanceFilterDelegate(float value);

	private delegate void StartUpdatingLocationDelegate();

	private delegate void StopUpdatingLocationDelegate();

	private delegate bool IsHeadingUpdatesEnabledDelegate();

	private delegate void SetHeadingUpdatesEnabledDelegate(bool value);

	private static readonly IsServiceEnabledByUserDelegate IsServiceEnabledByUserDelegateField = IL2CPP.ResolveICall<IsServiceEnabledByUserDelegate>("UnityEngine.LocationService::IsServiceEnabledByUser");

	private static readonly GetLocationStatusDelegate GetLocationStatusDelegateField = IL2CPP.ResolveICall<GetLocationStatusDelegate>("UnityEngine.LocationService::GetLocationStatus");

	private static readonly SetDesiredAccuracyDelegate SetDesiredAccuracyDelegateField = IL2CPP.ResolveICall<SetDesiredAccuracyDelegate>("UnityEngine.LocationService::SetDesiredAccuracy");

	private static readonly SetDistanceFilterDelegate SetDistanceFilterDelegateField = IL2CPP.ResolveICall<SetDistanceFilterDelegate>("UnityEngine.LocationService::SetDistanceFilter");

	private static readonly StartUpdatingLocationDelegate StartUpdatingLocationDelegateField = IL2CPP.ResolveICall<StartUpdatingLocationDelegate>("UnityEngine.LocationService::StartUpdatingLocation");

	private static readonly StopUpdatingLocationDelegate StopUpdatingLocationDelegateField = IL2CPP.ResolveICall<StopUpdatingLocationDelegate>("UnityEngine.LocationService::StopUpdatingLocation");

	private static readonly IsHeadingUpdatesEnabledDelegate IsHeadingUpdatesEnabledDelegateField = IL2CPP.ResolveICall<IsHeadingUpdatesEnabledDelegate>("UnityEngine.LocationService::IsHeadingUpdatesEnabled");

	private static readonly SetHeadingUpdatesEnabledDelegate SetHeadingUpdatesEnabledDelegateField = IL2CPP.ResolveICall<SetHeadingUpdatesEnabledDelegate>("UnityEngine.LocationService::SetHeadingUpdatesEnabled");

	public bool isEnabledByUser => IsServiceEnabledByUser();

	public LocationServiceStatus status => GetLocationStatus();

	public static bool IsServiceEnabledByUser()
	{
		return IsServiceEnabledByUserDelegateField();
	}

	public static LocationServiceStatus GetLocationStatus()
	{
		return GetLocationStatusDelegateField();
	}

	public static void SetDesiredAccuracy(float value)
	{
		SetDesiredAccuracyDelegateField(value);
	}

	public static void SetDistanceFilter(float value)
	{
		SetDistanceFilterDelegateField(value);
	}

	public static void StartUpdatingLocation()
	{
		StartUpdatingLocationDelegateField();
	}

	public static void StopUpdatingLocation()
	{
		StopUpdatingLocationDelegateField();
	}

	public static bool IsHeadingUpdatesEnabled()
	{
		return IsHeadingUpdatesEnabledDelegateField();
	}

	public static void SetHeadingUpdatesEnabled(bool value)
	{
		SetHeadingUpdatesEnabledDelegateField(value);
	}

	public void Start(float desiredAccuracyInMeters, float updateDistanceInMeters)
	{
		SetDesiredAccuracy(desiredAccuracyInMeters);
		SetDistanceFilter(updateDistanceInMeters);
		StartUpdatingLocation();
	}

	public void Start(float desiredAccuracyInMeters)
	{
		Start(desiredAccuracyInMeters, 10f);
	}

	public void Start()
	{
		Start(10f, 10f);
	}

	public void Stop()
	{
		StopUpdatingLocation();
	}
}
