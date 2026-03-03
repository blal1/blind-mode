using System;

namespace UnityEngine;

public class Compass
{
	public float magneticHeading
	{
		get
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}

	public float trueHeading
	{
		get
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}

	public float headingAccuracy
	{
		get
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}

	public Vector3 rawVector
	{
		get
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}

	public double timestamp
	{
		get
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}

	public bool enabled
	{
		get
		{
			return LocationService.IsHeadingUpdatesEnabled();
		}
		set
		{
			LocationService.SetHeadingUpdatesEnabled(value);
		}
	}
}
