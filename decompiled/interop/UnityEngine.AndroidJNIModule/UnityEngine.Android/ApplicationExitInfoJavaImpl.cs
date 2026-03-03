using System;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Text;

namespace UnityEngine.Android;

public class ApplicationExitInfoJavaImpl
{
	public string description
	{
		get
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}

	public int describeContents
	{
		get
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}

	public int definingUid
	{
		get
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}

	public ProcessImportance importance
	{
		get
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}

	public int packageUid
	{
		get
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}

	public int pid
	{
		get
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}

	public string processName
	{
		get
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}

	public Il2CppStructArray<sbyte> processStateSummary
	{
		get
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}

	public long pss
	{
		get
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}

	public int realUid
	{
		get
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}

	public ExitReason reason
	{
		get
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}

	public long rss
	{
		get
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}

	public int status
	{
		get
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}

	public long timestamp
	{
		get
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}

	public Il2CppStructArray<byte> trace => GetTrace();

	public string traceAsString
	{
		get
		{
			Il2CppStructArray<byte> val = GetTrace();
			if (val == null || ((Il2CppArrayBase)val).Length == 0)
			{
				return null;
			}
			return Encoding.UTF8.GetString(val, 0, ((Il2CppArrayBase)val).Length);
		}
	}

	public Il2CppStructArray<byte> GetTrace()
	{
		throw new NotSupportedException("Method unstripping failed");
	}

	public override int GetHashCode()
	{
		throw new NotSupportedException("Method unstripping failed");
	}

	public override string ToString()
	{
		throw new NotSupportedException("Method unstripping failed");
	}
}
