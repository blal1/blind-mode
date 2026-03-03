using System;
using System.Runtime.CompilerServices;
using Il2CppSystem;

namespace UnityEngine.Android;

public class PermissionCallbacks : AndroidJavaProxy
{
	public enum Result
	{
		Dismissed,
		Granted,
		Denied,
		DeniedDontAskAgain
	}

	[SpecialName]
	public void add_PermissionGranted(Il2CppSystem.Action<string> value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	[SpecialName]
	public void remove_PermissionGranted(Il2CppSystem.Action<string> value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	[SpecialName]
	public void add_PermissionDenied(Il2CppSystem.Action<string> value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	[SpecialName]
	public void remove_PermissionDenied(Il2CppSystem.Action<string> value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	[SpecialName]
	public void add_PermissionDeniedAndDontAskAgain(Il2CppSystem.Action<string> value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	[SpecialName]
	public void remove_PermissionDeniedAndDontAskAgain(Il2CppSystem.Action<string> value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	[SpecialName]
	public void add_PermissionRequestDismissed(Il2CppSystem.Action<string> value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	[SpecialName]
	public void remove_PermissionRequestDismissed(Il2CppSystem.Action<string> value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public override System.IntPtr Invoke(string methodName, System.IntPtr javaArgs)
	{
		if (methodName == "onPermissionResult")
		{
			onPermissionResult(javaArgs);
			return Il2CppSystem.IntPtr.Zero;
		}
		return base.Invoke(methodName, javaArgs);
	}

	public void onPermissionResult(System.IntPtr javaArgs)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}
}
