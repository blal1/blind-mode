using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine.Bindings;
using UnityEngine.Events;

namespace UnityEngine.SceneManagement;

public class SceneManager : Il2CppSystem.Object
{
	private delegate int get_loadedSceneCountDelegate();

	private delegate bool CanSetAsActiveScene_InjectedDelegate([In] System.IntPtr scene);

	private delegate bool SetActiveScene_InjectedDelegate([In] System.IntPtr scene);

	private delegate void GetSceneByPath_InjectedDelegate(System.IntPtr scenePath, [Out] System.IntPtr ret);

	private delegate void GetSceneByName_InjectedDelegate(System.IntPtr name, [Out] System.IntPtr ret);

	private delegate void CreateScene_InjectedDelegate(System.IntPtr sceneName, [In] System.IntPtr parameters, [Out] System.IntPtr ret);

	private delegate bool UnloadSceneInternal_InjectedDelegate([In] System.IntPtr scene, UnloadSceneOptions options);

	private delegate System.IntPtr UnloadSceneAsyncInternal_InjectedDelegate([In] System.IntPtr scene, UnloadSceneOptions options);

	private delegate void MergeScenes_InjectedDelegate([In] System.IntPtr sourceScene, [In] System.IntPtr destinationScene);

	private delegate void MoveGameObjectToScene_InjectedDelegate(System.IntPtr go, [In] System.IntPtr scene);

	private delegate void MoveGameObjectsToSceneByInstanceId_InjectedDelegate(System.IntPtr instanceIds, int instanceCount, [In] System.IntPtr scene);

	private static readonly System.IntPtr NativeFieldInfoPtr_s_AllowLoadScene;

	private static readonly System.IntPtr NativeFieldInfoPtr_sceneLoaded;

	private static readonly System.IntPtr NativeFieldInfoPtr_sceneUnloaded;

	private static readonly System.IntPtr NativeFieldInfoPtr_activeSceneChanged;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_sceneCount_Public_Static_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetActiveScene_Public_Static_Scene_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSceneAt_Public_Static_Scene_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadSceneAsyncNameIndexInternal_Private_Static_AsyncOperation_String_Int32_LoadSceneParameters_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadFirstScene_Internal_Internal_Static_AsyncOperation_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_add_sceneLoaded_Public_Static_add_Void_UnityAction_2_Scene_LoadSceneMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_remove_sceneLoaded_Public_Static_rem_Void_UnityAction_2_Scene_LoadSceneMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadScene_Public_Static_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadScene_Public_Static_Scene_String_LoadSceneParameters_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_SceneLoaded_Private_Static_Void_Scene_LoadSceneMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_SceneUnloaded_Private_Static_Void_Scene_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_ActiveSceneChanged_Private_Static_Void_Scene_Scene_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetActiveScene_Injected_Private_Static_Void_byref_Scene_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSceneAt_Injected_Private_Static_Void_Int32_byref_Scene_0;

	private static readonly get_loadedSceneCountDelegate get_loadedSceneCountDelegateField;

	private static readonly CanSetAsActiveScene_InjectedDelegate CanSetAsActiveScene_InjectedDelegateField;

	private static readonly SetActiveScene_InjectedDelegate SetActiveScene_InjectedDelegateField;

	private static readonly GetSceneByPath_InjectedDelegate GetSceneByPath_InjectedDelegateField;

	private static readonly GetSceneByName_InjectedDelegate GetSceneByName_InjectedDelegateField;

	private static readonly CreateScene_InjectedDelegate CreateScene_InjectedDelegateField;

	private static readonly UnloadSceneInternal_InjectedDelegate UnloadSceneInternal_InjectedDelegateField;

	private static readonly UnloadSceneAsyncInternal_InjectedDelegate UnloadSceneAsyncInternal_InjectedDelegateField;

	private static readonly MergeScenes_InjectedDelegate MergeScenes_InjectedDelegateField;

	private static readonly MoveGameObjectToScene_InjectedDelegate MoveGameObjectToScene_InjectedDelegateField;

	private static readonly MoveGameObjectsToSceneByInstanceId_InjectedDelegate MoveGameObjectsToSceneByInstanceId_InjectedDelegateField;

	public unsafe static bool s_AllowLoadScene
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_AllowLoadScene, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_AllowLoadScene, (void*)(&value));
		}
	}

	public unsafe static UnityAction<Scene, LoadSceneMode> sceneLoaded
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_sceneLoaded, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<UnityAction<Scene, LoadSceneMode>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_sceneLoaded, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static UnityAction<Scene> sceneUnloaded
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_sceneUnloaded, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<UnityAction<Scene>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_sceneUnloaded, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static UnityAction<Scene, Scene> activeSceneChanged
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_activeSceneChanged, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<UnityAction<Scene, Scene>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_activeSceneChanged, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static int sceneCount
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1228487, XrefRangeEnd = 1228489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_sceneCount_Public_Static_get_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public static int loadedSceneCount => get_loadedSceneCountDelegateField();

	public static int sceneCountInBuildSettings => SceneManagerAPI.ActiveAPI.GetNumScenesInBuildSettings();

	static SceneManager()
	{
		Il2CppClassPointerStore<SceneManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.SceneManagement", "SceneManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneManager>.NativeClassPtr);
		NativeFieldInfoPtr_s_AllowLoadScene = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "s_AllowLoadScene");
		NativeFieldInfoPtr_sceneLoaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "sceneLoaded");
		NativeFieldInfoPtr_sceneUnloaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "sceneUnloaded");
		NativeFieldInfoPtr_activeSceneChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "activeSceneChanged");
		NativeMethodInfoPtr_get_sceneCount_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100667267);
		NativeMethodInfoPtr_GetActiveScene_Public_Static_Scene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100667268);
		NativeMethodInfoPtr_GetSceneAt_Public_Static_Scene_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100667269);
		NativeMethodInfoPtr_LoadSceneAsyncNameIndexInternal_Private_Static_AsyncOperation_String_Int32_LoadSceneParameters_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100667270);
		NativeMethodInfoPtr_LoadFirstScene_Internal_Internal_Static_AsyncOperation_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100667271);
		NativeMethodInfoPtr_add_sceneLoaded_Public_Static_add_Void_UnityAction_2_Scene_LoadSceneMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100667272);
		NativeMethodInfoPtr_remove_sceneLoaded_Public_Static_rem_Void_UnityAction_2_Scene_LoadSceneMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100667273);
		NativeMethodInfoPtr_LoadScene_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100667274);
		NativeMethodInfoPtr_LoadScene_Public_Static_Scene_String_LoadSceneParameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100667275);
		NativeMethodInfoPtr_Internal_SceneLoaded_Private_Static_Void_Scene_LoadSceneMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100667276);
		NativeMethodInfoPtr_Internal_SceneUnloaded_Private_Static_Void_Scene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100667277);
		NativeMethodInfoPtr_Internal_ActiveSceneChanged_Private_Static_Void_Scene_Scene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100667278);
		NativeMethodInfoPtr_GetActiveScene_Injected_Private_Static_Void_byref_Scene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100667280);
		NativeMethodInfoPtr_GetSceneAt_Injected_Private_Static_Void_Int32_byref_Scene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100667281);
		get_loadedSceneCountDelegateField = IL2CPP.ResolveICall<get_loadedSceneCountDelegate>("UnityEngine.SceneManagement.SceneManager::get_loadedSceneCount");
		CanSetAsActiveScene_InjectedDelegateField = IL2CPP.ResolveICall<CanSetAsActiveScene_InjectedDelegate>("UnityEngine.SceneManagement.SceneManager::CanSetAsActiveScene_Injected");
		SetActiveScene_InjectedDelegateField = IL2CPP.ResolveICall<SetActiveScene_InjectedDelegate>("UnityEngine.SceneManagement.SceneManager::SetActiveScene_Injected");
		GetSceneByPath_InjectedDelegateField = IL2CPP.ResolveICall<GetSceneByPath_InjectedDelegate>("UnityEngine.SceneManagement.SceneManager::GetSceneByPath_Injected");
		GetSceneByName_InjectedDelegateField = IL2CPP.ResolveICall<GetSceneByName_InjectedDelegate>("UnityEngine.SceneManagement.SceneManager::GetSceneByName_Injected");
		CreateScene_InjectedDelegateField = IL2CPP.ResolveICall<CreateScene_InjectedDelegate>("UnityEngine.SceneManagement.SceneManager::CreateScene_Injected");
		UnloadSceneInternal_InjectedDelegateField = IL2CPP.ResolveICall<UnloadSceneInternal_InjectedDelegate>("UnityEngine.SceneManagement.SceneManager::UnloadSceneInternal_Injected");
		UnloadSceneAsyncInternal_InjectedDelegateField = IL2CPP.ResolveICall<UnloadSceneAsyncInternal_InjectedDelegate>("UnityEngine.SceneManagement.SceneManager::UnloadSceneAsyncInternal_Injected");
		MergeScenes_InjectedDelegateField = IL2CPP.ResolveICall<MergeScenes_InjectedDelegate>("UnityEngine.SceneManagement.SceneManager::MergeScenes_Injected");
		MoveGameObjectToScene_InjectedDelegateField = IL2CPP.ResolveICall<MoveGameObjectToScene_InjectedDelegate>("UnityEngine.SceneManagement.SceneManager::MoveGameObjectToScene_Injected");
		MoveGameObjectsToSceneByInstanceId_InjectedDelegateField = IL2CPP.ResolveICall<MoveGameObjectsToSceneByInstanceId_InjectedDelegate>("UnityEngine.SceneManagement.SceneManager::MoveGameObjectsToSceneByInstanceId_Injected");
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1228494, RefRangeEnd = 1228495, XrefRangeStart = 1228489, XrefRangeEnd = 1228494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Scene GetActiveScene()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetActiveScene_Public_Static_Scene_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Scene*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1228495, XrefRangeEnd = 1228500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Scene GetSceneAt(int index)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&index);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSceneAt_Public_Static_Scene_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Scene*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1228500, XrefRangeEnd = 1228509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AsyncOperation LoadSceneAsyncNameIndexInternal(string sceneName, int sceneBuildIndex, LoadSceneParameters parameters, bool mustCompleteNextFrame)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(sceneName);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &sceneBuildIndex;
		*(LoadSceneParameters**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &parameters;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &mustCompleteNextFrame;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadSceneAsyncNameIndexInternal_Private_Static_AsyncOperation_String_Int32_LoadSceneParameters_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<AsyncOperation>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1228509, XrefRangeEnd = 1228514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AsyncOperation LoadFirstScene_Internal(bool async)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&async);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadFirstScene_Internal_Internal_Static_AsyncOperation_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<AsyncOperation>(intPtr2) : null;
	}

	[SpecialName]
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1228527, RefRangeEnd = 1228528, XrefRangeStart = 1228514, XrefRangeEnd = 1228527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_sceneLoaded(UnityAction<Scene, LoadSceneMode> value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_add_sceneLoaded_Public_Static_add_Void_UnityAction_2_Scene_LoadSceneMode_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[SpecialName]
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1228541, RefRangeEnd = 1228542, XrefRangeStart = 1228528, XrefRangeEnd = 1228541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_sceneLoaded(UnityAction<Scene, LoadSceneMode> value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_remove_sceneLoaded_Public_Static_rem_Void_UnityAction_2_Scene_LoadSceneMode_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1228563, RefRangeEnd = 1228565, XrefRangeStart = 1228542, XrefRangeEnd = 1228563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void LoadScene(string sceneName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(sceneName);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadScene_Public_Static_Void_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1228565, XrefRangeEnd = 1228583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Scene LoadScene(string sceneName, LoadSceneParameters parameters)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(sceneName);
		*(LoadSceneParameters**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &parameters;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadScene_Public_Static_Scene_String_LoadSceneParameters_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Scene*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1228583, XrefRangeEnd = 1228589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Internal_SceneLoaded(Scene scene, LoadSceneMode mode)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&scene);
		*(LoadSceneMode**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &mode;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_SceneLoaded_Private_Static_Void_Scene_LoadSceneMode_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1228589, XrefRangeEnd = 1228595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Internal_SceneUnloaded(Scene scene)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&scene);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_SceneUnloaded_Private_Static_Void_Scene_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1228595, XrefRangeEnd = 1228601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Internal_ActiveSceneChanged(Scene previousActiveScene, Scene newActiveScene)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&previousActiveScene);
		*(Scene**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &newActiveScene;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_ActiveSceneChanged_Private_Static_Void_Scene_Scene_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1228601, XrefRangeEnd = 1228603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetActiveScene_Injected(out Scene ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetActiveScene_Injected_Private_Static_Void_byref_Scene_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1228603, XrefRangeEnd = 1228605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetSceneAt_Injected(int index, out Scene ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&index);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSceneAt_Injected_Private_Static_Void_Int32_byref_Scene_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public SceneManager(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public static bool CanSetAsActiveScene(Scene scene)
	{
		return CanSetAsActiveScene_Injected(ref scene);
	}

	public static bool SetActiveScene(Scene scene)
	{
		return SetActiveScene_Injected(ref scene);
	}

	public unsafe static Scene GetSceneByPath(string scenePath)
	{
		//IL_0018: Expected O, but got Ref
		//IL_0024: Expected O, but got Ref
		//The blocks IL_0029 are reachable both inside and outside the pinned region starting at IL_0018. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		Unsafe.SkipInit(out Scene ret);
		Scene result;
		try
		{
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(scenePath, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(scenePath);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					GetSceneByPath_Injected(ref managedSpanWrapper, out ret);
				}
			}
			else
			{
				GetSceneByPath_Injected(ref managedSpanWrapper, out ret);
			}
		}
		finally
		{
			result = ret;
		}
		return result;
	}

	public unsafe static Scene GetSceneByName(string name)
	{
		//IL_0018: Expected O, but got Ref
		//IL_0024: Expected O, but got Ref
		//The blocks IL_0029 are reachable both inside and outside the pinned region starting at IL_0018. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		Unsafe.SkipInit(out Scene ret);
		Scene result;
		try
		{
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(name, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(name);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					GetSceneByName_Injected(ref managedSpanWrapper, out ret);
				}
			}
			else
			{
				GetSceneByName_Injected(ref managedSpanWrapper, out ret);
			}
		}
		finally
		{
			result = ret;
		}
		return result;
	}

	public static Scene GetSceneByBuildIndex(int buildIndex)
	{
		return SceneManagerAPI.ActiveAPI.GetSceneByBuildIndex(buildIndex);
	}

	public unsafe static Scene CreateScene(string sceneName, CreateSceneParameters parameters)
	{
		//IL_0027: Expected O, but got Ref
		//IL_0033: Expected O, but got Ref
		//The blocks IL_0038 are reachable both inside and outside the pinned region starting at IL_0027. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		if (sceneName == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(sceneName, "sceneName");
		}
		Unsafe.SkipInit(out Scene ret);
		Scene result;
		try
		{
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(sceneName, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(sceneName);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					CreateScene_Injected(ref managedSpanWrapper, ref parameters, out ret);
				}
			}
			else
			{
				CreateScene_Injected(ref managedSpanWrapper, ref parameters, out ret);
			}
		}
		finally
		{
			result = ret;
		}
		return result;
	}

	public static bool UnloadSceneInternal(Scene scene, UnloadSceneOptions options)
	{
		return UnloadSceneInternal_Injected(ref scene, options);
	}

	public static AsyncOperation UnloadSceneAsyncInternal(Scene scene, UnloadSceneOptions options)
	{
		System.IntPtr intPtr = UnloadSceneAsyncInternal_Injected(ref scene, options);
		return (intPtr == (System.IntPtr)0) ? null : AsyncOperation.BindingsMarshaller.ConvertToManaged(intPtr);
	}

	public static AsyncOperation UnloadSceneNameIndexInternal(string sceneName, int sceneBuildIndex, bool immediately, UnloadSceneOptions options, out bool outSuccess)
	{
		if (!s_AllowLoadScene)
		{
			outSuccess = false;
			return null;
		}
		return SceneManagerAPI.ActiveAPI.UnloadSceneAsyncByNameOrIndex(sceneName, sceneBuildIndex, immediately, options, out outSuccess);
	}

	public static void MergeScenes(Scene sourceScene, Scene destinationScene)
	{
		MergeScenes_Injected(ref sourceScene, ref destinationScene);
	}

	public static void MoveGameObjectToScene(GameObject go, Scene scene)
	{
		if ((object)go == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(go, "go");
		}
		System.IntPtr intPtr = Object.MarshalledUnityObject.MarshalNotNull(go);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(go, "go");
		}
		MoveGameObjectToScene_Injected(intPtr, ref scene);
	}

	public static void MoveGameObjectsToSceneByInstanceId(System.IntPtr instanceIds, int instanceCount, Scene scene)
	{
		MoveGameObjectsToSceneByInstanceId_Injected(instanceIds, instanceCount, ref scene);
	}

	public unsafe static void MoveGameObjectsToScene(NativeArray<int> instanceIDs, Scene scene)
	{
		//IL_0008: Expected O, but got Ref
		//IL_0026: Expected O, but got Ref
		//IL_0041: Expected O, but got Ref
		if (!((NativeArray<int>)(&instanceIDs)).IsCreated)
		{
			throw new Il2CppSystem.ArgumentException("NativeArray is uninitialized", "instanceIDs");
		}
		if (((NativeArray<int>)(&instanceIDs)).Length != 0)
		{
			MoveGameObjectsToSceneByInstanceId((System.IntPtr)instanceIDs.GetUnsafeReadOnlyPtr(), ((NativeArray<int>)(&instanceIDs)).Length, scene);
		}
	}

	[SpecialName]
	public static void add_sceneUnloaded(UnityAction<Scene> value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	[SpecialName]
	public static void remove_sceneUnloaded(UnityAction<Scene> value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	[SpecialName]
	public static void add_activeSceneChanged(UnityAction<Scene, Scene> value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	[SpecialName]
	public static void remove_activeSceneChanged(UnityAction<Scene, Scene> value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public static Il2CppStructArray<Scene> GetAllScenes()
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public static Scene CreateScene(string sceneName)
	{
		CreateSceneParameters parameters = new CreateSceneParameters(LocalPhysicsMode.None);
		return CreateScene(sceneName, parameters);
	}

	public static void LoadScene(string sceneName, LoadSceneMode mode)
	{
		LoadSceneParameters parameters = new LoadSceneParameters(mode);
		LoadScene(sceneName, parameters);
	}

	public static void LoadScene(int sceneBuildIndex, LoadSceneMode mode)
	{
		LoadSceneParameters parameters = new LoadSceneParameters(mode);
		LoadScene(sceneBuildIndex, parameters);
	}

	public static void LoadScene(int sceneBuildIndex)
	{
		LoadSceneParameters parameters = new LoadSceneParameters(LoadSceneMode.Single);
		LoadScene(sceneBuildIndex, parameters);
	}

	public static Scene LoadScene(int sceneBuildIndex, LoadSceneParameters parameters)
	{
		LoadSceneAsyncNameIndexInternal(null, sceneBuildIndex, parameters, mustCompleteNextFrame: true);
		return GetSceneAt(sceneCount - 1);
	}

	public static AsyncOperation LoadSceneAsync(int sceneBuildIndex, LoadSceneMode mode)
	{
		LoadSceneParameters parameters = new LoadSceneParameters(mode);
		return LoadSceneAsync(sceneBuildIndex, parameters);
	}

	public static AsyncOperation LoadSceneAsync(int sceneBuildIndex)
	{
		LoadSceneParameters parameters = new LoadSceneParameters(LoadSceneMode.Single);
		return LoadSceneAsync(sceneBuildIndex, parameters);
	}

	public static AsyncOperation LoadSceneAsync(int sceneBuildIndex, LoadSceneParameters parameters)
	{
		return LoadSceneAsyncNameIndexInternal(null, sceneBuildIndex, parameters, mustCompleteNextFrame: false);
	}

	public static AsyncOperation LoadSceneAsync(string sceneName, LoadSceneMode mode)
	{
		LoadSceneParameters parameters = new LoadSceneParameters(mode);
		return LoadSceneAsync(sceneName, parameters);
	}

	public static AsyncOperation LoadSceneAsync(string sceneName)
	{
		LoadSceneParameters parameters = new LoadSceneParameters(LoadSceneMode.Single);
		return LoadSceneAsync(sceneName, parameters);
	}

	public static AsyncOperation LoadSceneAsync(string sceneName, LoadSceneParameters parameters)
	{
		return LoadSceneAsyncNameIndexInternal(sceneName, -1, parameters, mustCompleteNextFrame: false);
	}

	public static bool UnloadScene(Scene scene)
	{
		return UnloadSceneInternal(scene, UnloadSceneOptions.None);
	}

	public static bool UnloadScene(int sceneBuildIndex)
	{
		UnloadSceneNameIndexInternal("", sceneBuildIndex, immediately: true, UnloadSceneOptions.None, out var outSuccess);
		return outSuccess;
	}

	public static bool UnloadScene(string sceneName)
	{
		UnloadSceneNameIndexInternal(sceneName, -1, immediately: true, UnloadSceneOptions.None, out var outSuccess);
		return outSuccess;
	}

	public static AsyncOperation UnloadSceneAsync(int sceneBuildIndex)
	{
		bool outSuccess;
		return UnloadSceneNameIndexInternal("", sceneBuildIndex, immediately: false, UnloadSceneOptions.None, out outSuccess);
	}

	public static AsyncOperation UnloadSceneAsync(string sceneName)
	{
		bool outSuccess;
		return UnloadSceneNameIndexInternal(sceneName, -1, immediately: false, UnloadSceneOptions.None, out outSuccess);
	}

	public static AsyncOperation UnloadSceneAsync(Scene scene)
	{
		return UnloadSceneAsyncInternal(scene, UnloadSceneOptions.None);
	}

	public static AsyncOperation UnloadSceneAsync(int sceneBuildIndex, UnloadSceneOptions options)
	{
		bool outSuccess;
		return UnloadSceneNameIndexInternal("", sceneBuildIndex, immediately: false, options, out outSuccess);
	}

	public static AsyncOperation UnloadSceneAsync(string sceneName, UnloadSceneOptions options)
	{
		bool outSuccess;
		return UnloadSceneNameIndexInternal(sceneName, -1, immediately: false, options, out outSuccess);
	}

	public static AsyncOperation UnloadSceneAsync(Scene scene, UnloadSceneOptions options)
	{
		return UnloadSceneAsyncInternal(scene, options);
	}

	public unsafe static bool CanSetAsActiveScene_Injected([In] ref Scene scene)
	{
		return CanSetAsActiveScene_InjectedDelegateField((nint)Unsafe.AsPointer(ref scene));
	}

	public unsafe static bool SetActiveScene_Injected([In] ref Scene scene)
	{
		return SetActiveScene_InjectedDelegateField((nint)Unsafe.AsPointer(ref scene));
	}

	public unsafe static void GetSceneByPath_Injected(ref ManagedSpanWrapper scenePath, out Scene ret)
	{
		GetSceneByPath_InjectedDelegateField((nint)Unsafe.AsPointer(ref scenePath), (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void GetSceneByName_Injected(ref ManagedSpanWrapper name, out Scene ret)
	{
		GetSceneByName_InjectedDelegateField((nint)Unsafe.AsPointer(ref name), (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void CreateScene_Injected(ref ManagedSpanWrapper sceneName, [In] ref CreateSceneParameters parameters, out Scene ret)
	{
		CreateScene_InjectedDelegateField((nint)Unsafe.AsPointer(ref sceneName), (nint)Unsafe.AsPointer(ref parameters), (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static bool UnloadSceneInternal_Injected([In] ref Scene scene, UnloadSceneOptions options)
	{
		return UnloadSceneInternal_InjectedDelegateField((nint)Unsafe.AsPointer(ref scene), options);
	}

	public unsafe static System.IntPtr UnloadSceneAsyncInternal_Injected([In] ref Scene scene, UnloadSceneOptions options)
	{
		return UnloadSceneAsyncInternal_InjectedDelegateField((nint)Unsafe.AsPointer(ref scene), options);
	}

	public unsafe static void MergeScenes_Injected([In] ref Scene sourceScene, [In] ref Scene destinationScene)
	{
		MergeScenes_InjectedDelegateField((nint)Unsafe.AsPointer(ref sourceScene), (nint)Unsafe.AsPointer(ref destinationScene));
	}

	public unsafe static void MoveGameObjectToScene_Injected(System.IntPtr go, [In] ref Scene scene)
	{
		MoveGameObjectToScene_InjectedDelegateField(go, (nint)Unsafe.AsPointer(ref scene));
	}

	public unsafe static void MoveGameObjectsToSceneByInstanceId_Injected(System.IntPtr instanceIds, int instanceCount, [In] ref Scene scene)
	{
		MoveGameObjectsToSceneByInstanceId_InjectedDelegateField(instanceIds, instanceCount, (nint)Unsafe.AsPointer(ref scene));
	}
}
