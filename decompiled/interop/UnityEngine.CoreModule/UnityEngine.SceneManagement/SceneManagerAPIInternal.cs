using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Bindings;

namespace UnityEngine.SceneManagement;

public static class SceneManagerAPIInternal : Il2CppSystem.Object
{
	private delegate int GetNumScenesInBuildSettingsDelegate();

	private delegate void GetSceneByBuildIndex_InjectedDelegate(int buildIndex, [Out] System.IntPtr ret);

	private delegate System.IntPtr UnloadSceneNameIndexInternal_InjectedDelegate(System.IntPtr sceneName, int sceneBuildIndex, bool immediately, UnloadSceneOptions options, [Out] System.IntPtr outSuccess);

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadSceneAsyncNameIndexInternal_Public_Static_AsyncOperation_String_Int32_LoadSceneParameters_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadSceneAsyncNameIndexInternal_Injected_Private_Static_IntPtr_byref_ManagedSpanWrapper_Int32_byref_LoadSceneParameters_Boolean_0;

	private static readonly GetNumScenesInBuildSettingsDelegate GetNumScenesInBuildSettingsDelegateField;

	private static readonly GetSceneByBuildIndex_InjectedDelegate GetSceneByBuildIndex_InjectedDelegateField;

	private static readonly UnloadSceneNameIndexInternal_InjectedDelegate UnloadSceneNameIndexInternal_InjectedDelegateField;

	static SceneManagerAPIInternal()
	{
		Il2CppClassPointerStore<SceneManagerAPIInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.SceneManagement", "SceneManagerAPIInternal");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneManagerAPIInternal>.NativeClassPtr);
		NativeMethodInfoPtr_LoadSceneAsyncNameIndexInternal_Public_Static_AsyncOperation_String_Int32_LoadSceneParameters_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManagerAPIInternal>.NativeClassPtr, 100667259);
		NativeMethodInfoPtr_LoadSceneAsyncNameIndexInternal_Injected_Private_Static_IntPtr_byref_ManagedSpanWrapper_Int32_byref_LoadSceneParameters_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManagerAPIInternal>.NativeClassPtr, 100667260);
		GetNumScenesInBuildSettingsDelegateField = IL2CPP.ResolveICall<GetNumScenesInBuildSettingsDelegate>("UnityEngine.SceneManagement.SceneManagerAPIInternal::GetNumScenesInBuildSettings");
		GetSceneByBuildIndex_InjectedDelegateField = IL2CPP.ResolveICall<GetSceneByBuildIndex_InjectedDelegate>("UnityEngine.SceneManagement.SceneManagerAPIInternal::GetSceneByBuildIndex_Injected");
		UnloadSceneNameIndexInternal_InjectedDelegateField = IL2CPP.ResolveICall<UnloadSceneNameIndexInternal_InjectedDelegate>("UnityEngine.SceneManagement.SceneManagerAPIInternal::UnloadSceneNameIndexInternal_Injected");
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1228465, RefRangeEnd = 1228466, XrefRangeStart = 1228451, XrefRangeEnd = 1228465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AsyncOperation LoadSceneAsyncNameIndexInternal(string sceneName, int sceneBuildIndex, LoadSceneParameters parameters, bool mustCompleteNextFrame)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(sceneName);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &sceneBuildIndex;
		*(LoadSceneParameters**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &parameters;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &mustCompleteNextFrame;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadSceneAsyncNameIndexInternal_Public_Static_AsyncOperation_String_Int32_LoadSceneParameters_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<AsyncOperation>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1228466, XrefRangeEnd = 1228468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr LoadSceneAsyncNameIndexInternal_Injected(ref ManagedSpanWrapper sceneName, int sceneBuildIndex, [In] ref LoadSceneParameters parameters, bool mustCompleteNextFrame)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)Unsafe.AsPointer(ref sceneName);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &sceneBuildIndex;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref parameters);
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &mustCompleteNextFrame;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadSceneAsyncNameIndexInternal_Injected_Private_Static_IntPtr_byref_ManagedSpanWrapper_Int32_byref_LoadSceneParameters_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public SceneManagerAPIInternal(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public static int GetNumScenesInBuildSettings()
	{
		return GetNumScenesInBuildSettingsDelegateField();
	}

	public static Scene GetSceneByBuildIndex(int buildIndex)
	{
		GetSceneByBuildIndex_Injected(buildIndex, out var ret);
		return ret;
	}

	public unsafe static AsyncOperation UnloadSceneNameIndexInternal(string sceneName, int sceneBuildIndex, bool immediately, UnloadSceneOptions options, out bool outSuccess)
	{
		//IL_0018: Expected O, but got Ref
		//IL_0024: Expected O, but got Ref
		//The blocks IL_0029 are reachable both inside and outside the pinned region starting at IL_0018. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		Unsafe.SkipInit(out System.IntPtr intPtr);
		AsyncOperation result;
		try
		{
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(sceneName, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(sceneName);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					intPtr = UnloadSceneNameIndexInternal_Injected(ref managedSpanWrapper, sceneBuildIndex, immediately, options, out outSuccess);
				}
			}
			else
			{
				intPtr = UnloadSceneNameIndexInternal_Injected(ref managedSpanWrapper, sceneBuildIndex, immediately, options, out outSuccess);
			}
		}
		finally
		{
			System.IntPtr intPtr2 = intPtr;
			result = ((intPtr2 == (System.IntPtr)0) ? null : AsyncOperation.BindingsMarshaller.ConvertToManaged(intPtr2));
		}
		return result;
	}

	public unsafe static void GetSceneByBuildIndex_Injected(int buildIndex, out Scene ret)
	{
		GetSceneByBuildIndex_InjectedDelegateField(buildIndex, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static System.IntPtr UnloadSceneNameIndexInternal_Injected(ref ManagedSpanWrapper sceneName, int sceneBuildIndex, bool immediately, UnloadSceneOptions options, out bool outSuccess)
	{
		return UnloadSceneNameIndexInternal_InjectedDelegateField((nint)Unsafe.AsPointer(ref sceneName), sceneBuildIndex, immediately, options, (nint)Unsafe.AsPointer(ref outSuccess));
	}
}
