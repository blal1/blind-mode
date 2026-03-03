using Il2CppSystem;

namespace UnityEngine;

public class AndroidJavaObjectUnityOwned : AndroidJavaObject
{
	public override void Dispose(bool disposing)
	{
		if (disposing)
		{
			throw new Exception("The object is owned by Unity runtime, you shouldn't call Dispose on it.");
		}
		base.Dispose(disposing);
	}
}
