using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.Bindings;

namespace UnityEngine.SceneManagement;

public static class SceneUtility
{
	private delegate void GetScenePathByBuildIndex_InjectedDelegate(int buildIndex, [Out] System.IntPtr ret);

	private delegate int GetBuildIndexByScenePath_InjectedDelegate(System.IntPtr scenePath);

	private static readonly GetScenePathByBuildIndex_InjectedDelegate GetScenePathByBuildIndex_InjectedDelegateField = IL2CPP.ResolveICall<GetScenePathByBuildIndex_InjectedDelegate>("UnityEngine.SceneManagement.SceneUtility::GetScenePathByBuildIndex_Injected");

	private static readonly GetBuildIndexByScenePath_InjectedDelegate GetBuildIndexByScenePath_InjectedDelegateField = IL2CPP.ResolveICall<GetBuildIndexByScenePath_InjectedDelegate>("UnityEngine.SceneManagement.SceneUtility::GetBuildIndexByScenePath_Injected");

	public static string GetScenePathByBuildIndex(int buildIndex)
	{
		Unsafe.SkipInit(out ManagedSpanWrapper ret);
		string stringAndDispose;
		try
		{
			GetScenePathByBuildIndex_Injected(buildIndex, out ret);
		}
		finally
		{
			stringAndDispose = OutStringMarshaller.GetStringAndDispose(ret);
		}
		return stringAndDispose;
	}

	public unsafe static int GetBuildIndexByScenePath(string scenePath)
	{
		//IL_0018: Expected O, but got Ref
		//IL_0024: Expected O, but got Ref
		//The blocks IL_0029 are reachable both inside and outside the pinned region starting at IL_0018. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(scenePath, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(scenePath);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					return GetBuildIndexByScenePath_Injected(ref managedSpanWrapper);
				}
			}
			return GetBuildIndexByScenePath_Injected(ref managedSpanWrapper);
		}
		finally
		{
		}
	}

	public unsafe static void GetScenePathByBuildIndex_Injected(int buildIndex, out ManagedSpanWrapper ret)
	{
		GetScenePathByBuildIndex_InjectedDelegateField(buildIndex, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static int GetBuildIndexByScenePath_Injected(ref ManagedSpanWrapper scenePath)
	{
		return GetBuildIndexByScenePath_InjectedDelegateField((nint)Unsafe.AsPointer(ref scenePath));
	}
}
