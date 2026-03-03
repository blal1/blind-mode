using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.SceneManagement;

namespace UnityEngine;

public static class PhysicsSceneExtensions
{
	private delegate void GetPhysicsScene_Internal_InjectedDelegate([In] System.IntPtr scene, [Out] System.IntPtr ret);

	private static readonly GetPhysicsScene_Internal_InjectedDelegate GetPhysicsScene_Internal_InjectedDelegateField = IL2CPP.ResolveICall<GetPhysicsScene_Internal_InjectedDelegate>("UnityEngine.PhysicsSceneExtensions::GetPhysicsScene_Internal_Injected");

	public static PhysicsScene GetPhysicsScene(Scene scene)
	{
		if (!scene.IsValid())
		{
			throw new Il2CppSystem.ArgumentException("Cannot get physics scene; Unity scene is invalid.", "scene");
		}
		PhysicsScene physicsScene_Internal = GetPhysicsScene_Internal(scene);
		if (physicsScene_Internal.IsValid())
		{
			return physicsScene_Internal;
		}
		throw new Il2CppSystem.Exception("The physics scene associated with the Unity scene is invalid.");
	}

	public static PhysicsScene GetPhysicsScene_Internal(Scene scene)
	{
		GetPhysicsScene_Internal_Injected(ref scene, out var ret);
		return ret;
	}

	public unsafe static void GetPhysicsScene_Internal_Injected([In] ref Scene scene, out PhysicsScene ret)
	{
		GetPhysicsScene_Internal_InjectedDelegateField((nint)Unsafe.AsPointer(ref scene), (nint)Unsafe.AsPointer(ref ret));
	}
}
