using System;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace UnityEngine.Networking;

public class MultipartFormDataSection
{
	public string sectionName
	{
		get
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}

	public Il2CppStructArray<byte> sectionData
	{
		get
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}

	public string fileName => null;

	public string contentType
	{
		get
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}
}
