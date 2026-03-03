using System;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace UnityEngine.Android;

public struct Permission
{
	public const string Camera = "android.permission.CAMERA";

	public const string Microphone = "android.permission.RECORD_AUDIO";

	public const string FineLocation = "android.permission.ACCESS_FINE_LOCATION";

	public const string CoarseLocation = "android.permission.ACCESS_COARSE_LOCATION";

	public const string ExternalStorageRead = "android.permission.READ_EXTERNAL_STORAGE";

	public const string ExternalStorageWrite = "android.permission.WRITE_EXTERNAL_STORAGE";

	public static AndroidJavaObject GetUnityPermissions()
	{
		throw new NotSupportedException("Method unstripping failed");
	}

	public static bool ShouldShowRequestPermissionRationale(string permission)
	{
		throw new NotSupportedException("Method unstripping failed");
	}

	public static bool HasUserAuthorizedPermission(string permission)
	{
		throw new NotSupportedException("Method unstripping failed");
	}

	public static void RequestUserPermission(string permission)
	{
		throw new NotSupportedException("Method unstripping failed");
	}

	public static void RequestUserPermissions(Il2CppStringArray permissions)
	{
		if (permissions != null && ((Il2CppArrayBase)permissions).Length != 0)
		{
			RequestUserPermissions(permissions, null);
		}
	}

	public static void RequestUserPermission(string permission, PermissionCallbacks callbacks)
	{
		throw new NotSupportedException("Method unstripping failed");
	}

	public static void RequestUserPermissions(Il2CppStringArray permissions, PermissionCallbacks callbacks)
	{
		throw new NotSupportedException("Method unstripping failed");
	}
}
