using System;

namespace UnityEngine.Analytics;

public class AnalyticInfoAttribute : Attribute
{
	public int version
	{
		get
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}

	public string vendorKey
	{
		get
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}

	public string eventName
	{
		get
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}

	public int maxEventsPerHour
	{
		get
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}

	public int maxNumberOfElements
	{
		get
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}
}
