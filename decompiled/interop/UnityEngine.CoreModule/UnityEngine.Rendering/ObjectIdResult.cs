using System;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace UnityEngine.Rendering;

public class ObjectIdResult
{
	public Il2CppReferenceArray<Object> idToObjectMapping
	{
		get
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}

	public static int DecodeIdFromColor(Color color)
	{
		return (int)(color.r * 255f) + ((int)(color.g * 255f) << 8) + ((int)(color.b * 255f) << 16) + ((int)(color.a * 255f) << 24);
	}
}
