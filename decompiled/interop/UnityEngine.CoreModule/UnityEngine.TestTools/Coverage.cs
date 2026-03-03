using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace UnityEngine.TestTools;

public static class Coverage
{
	private delegate bool get_enabledDelegate();

	private delegate void set_enabledDelegate(bool value);

	private delegate void ResetFor_InternalDelegate(System.IntPtr method);

	private delegate void ResetAllDelegate();

	private static readonly get_enabledDelegate get_enabledDelegateField = IL2CPP.ResolveICall<get_enabledDelegate>("UnityEngine.TestTools.Coverage::get_enabled");

	private static readonly set_enabledDelegate set_enabledDelegateField = IL2CPP.ResolveICall<set_enabledDelegate>("UnityEngine.TestTools.Coverage::set_enabled");

	private static readonly ResetFor_InternalDelegate ResetFor_InternalDelegateField = IL2CPP.ResolveICall<ResetFor_InternalDelegate>("UnityEngine.TestTools.Coverage::ResetFor_Internal");

	private static readonly ResetAllDelegate ResetAllDelegateField = IL2CPP.ResolveICall<ResetAllDelegate>("UnityEngine.TestTools.Coverage::ResetAll");

	public static bool enabled
	{
		get
		{
			return get_enabledDelegateField();
		}
		set
		{
			set_enabledDelegateField(value);
		}
	}

	public static void ResetFor_Internal(MethodBase method)
	{
		ResetFor_InternalDelegateField(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)method));
	}

	public static void ResetFor(MethodBase method)
	{
		if (method == null)
		{
			throw new Il2CppSystem.ArgumentNullException("method");
		}
		ResetFor_Internal(method);
	}

	public static void ResetAll()
	{
		ResetAllDelegateField();
	}
}
