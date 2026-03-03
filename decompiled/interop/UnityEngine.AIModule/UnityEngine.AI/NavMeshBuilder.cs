using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using UnityEngine.Bindings;

namespace UnityEngine.AI;

public static class NavMeshBuilder
{
	private delegate void CollectSourcesInternal_InjectedDelegate(int includedLayerMask, [In] IntPtr includedWorldBounds, IntPtr root, bool useBounds, NavMeshCollectGeometry geometry, int defaultArea, bool generateLinksByDefault, IntPtr markups, bool includeOnlyMarkedObjects, [Out] IntPtr ret);

	private delegate void Cancel_InjectedDelegate(IntPtr data);

	private static readonly CollectSourcesInternal_InjectedDelegate CollectSourcesInternal_InjectedDelegateField = IL2CPP.ResolveICall<CollectSourcesInternal_InjectedDelegate>("UnityEngine.AI.NavMeshBuilder::CollectSourcesInternal_Injected");

	private static readonly Cancel_InjectedDelegate Cancel_InjectedDelegateField = IL2CPP.ResolveICall<Cancel_InjectedDelegate>("UnityEngine.AI.NavMeshBuilder::Cancel_Injected");

	public static void Cancel(NavMeshData data)
	{
		Cancel_Injected(Object.MarshalledUnityObject.Marshal(data));
	}

	public unsafe static void CollectSourcesInternal_Injected(int includedLayerMask, [In] ref Bounds includedWorldBounds, IntPtr root, bool useBounds, NavMeshCollectGeometry geometry, int defaultArea, bool generateLinksByDefault, ref ManagedSpanWrapper markups, bool includeOnlyMarkedObjects, out BlittableArrayWrapper ret)
	{
		CollectSourcesInternal_InjectedDelegateField(includedLayerMask, (nint)Unsafe.AsPointer(ref includedWorldBounds), root, useBounds, geometry, defaultArea, generateLinksByDefault, (nint)Unsafe.AsPointer(ref markups), includeOnlyMarkedObjects, (nint)Unsafe.AsPointer(ref ret));
	}

	public static void Cancel_Injected(IntPtr data)
	{
		Cancel_InjectedDelegateField(data);
	}
}
