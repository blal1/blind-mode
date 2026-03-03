namespace UnityEngine;

public class iPhoneSettings
{
	public static bool verticalOrientation => false;

	public static bool screenCanDarken => false;

	public static bool locationServiceEnabledByUser => false;

	public static void StartLocationServiceUpdates(float desiredAccuracyInMeters, float updateDistanceInMeters)
	{
	}

	public static void StartLocationServiceUpdates(float desiredAccuracyInMeters)
	{
	}

	public static void StartLocationServiceUpdates()
	{
	}

	public static void StopLocationServiceUpdates()
	{
	}
}
