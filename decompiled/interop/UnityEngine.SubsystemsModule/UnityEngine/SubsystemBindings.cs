using System;
using Il2CppInterop.Runtime;

namespace UnityEngine;

public static class SubsystemBindings
{
	private delegate void DestroySubsystemDelegate(IntPtr nativePtr);

	private static readonly DestroySubsystemDelegate DestroySubsystemDelegateField = IL2CPP.ResolveICall<DestroySubsystemDelegate>("UnityEngine.SubsystemBindings::DestroySubsystem");

	public static void DestroySubsystem(IntPtr nativePtr)
	{
		DestroySubsystemDelegateField(nativePtr);
	}
}
