using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace UnityEngine;

public struct StaticBatchingHelper
{
	private delegate void CombineMeshes_InjectedDelegate(IntPtr gos, IntPtr staticBatchRoot);

	private static readonly CombineMeshes_InjectedDelegate CombineMeshes_InjectedDelegateField = IL2CPP.ResolveICall<CombineMeshes_InjectedDelegate>("UnityEngine.StaticBatchingHelper::CombineMeshes_Injected");

	public static void CombineMeshes(Il2CppReferenceArray<GameObject> gos, GameObject staticBatchRoot)
	{
		CombineMeshes_Injected(gos, Object.MarshalledUnityObject.Marshal(staticBatchRoot));
	}

	public static void CombineMeshes_Injected(Il2CppReferenceArray<GameObject> gos, IntPtr staticBatchRoot)
	{
		CombineMeshes_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)gos), staticBatchRoot);
	}
}
