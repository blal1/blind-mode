using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Bindings;

namespace UnityEngine.SceneManagement;

[System.Serializable]
[StructLayout(LayoutKind.Explicit)]
public struct Scene
{
	public enum LoadingState
	{
		NotLoaded,
		Loading,
		Loaded,
		Unloading
	}

	private delegate bool IsValidInternalDelegate(int sceneHandle);

	private delegate bool IsSubSceneDelegate(int sceneHandle);

	private delegate void SetIsSubSceneDelegate(int sceneHandle, bool value);

	private delegate bool GetIsLoadedInternalDelegate(int sceneHandle);

	private delegate LoadingState GetLoadingStateInternalDelegate(int sceneHandle);

	private delegate bool GetIsDirtyInternalDelegate(int sceneHandle);

	private delegate int GetDirtyIDDelegate(int sceneHandle);

	private delegate int GetBuildIndexInternalDelegate(int sceneHandle);

	private delegate int GetRootCountInternalDelegate(int sceneHandle);

	private delegate void GetRootGameObjectsInternalDelegate(int sceneHandle, System.IntPtr resultRootList);

	private delegate void GetPathInternal_InjectedDelegate(int sceneHandle, [Out] System.IntPtr ret);

	private delegate void SetPathAndGUIDInternal_InjectedDelegate(int sceneHandle, System.IntPtr path, System.IntPtr guid);

	private delegate void GetNameInternal_InjectedDelegate(int sceneHandle, [Out] System.IntPtr ret);

	private delegate void SetNameInternal_InjectedDelegate(int sceneHandle, System.IntPtr name);

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Handle;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetGUIDInternal_Private_Static_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_handle_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_guid_Internal_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetGUIDInternal_Injected_Private_Static_Void_Int32_byref_ManagedSpanWrapper_0;

	[FieldOffset(0)]
	public int m_Handle;

	private static readonly IsValidInternalDelegate IsValidInternalDelegateField;

	private static readonly IsSubSceneDelegate IsSubSceneDelegateField;

	private static readonly SetIsSubSceneDelegate SetIsSubSceneDelegateField;

	private static readonly GetIsLoadedInternalDelegate GetIsLoadedInternalDelegateField;

	private static readonly GetLoadingStateInternalDelegate GetLoadingStateInternalDelegateField;

	private static readonly GetIsDirtyInternalDelegate GetIsDirtyInternalDelegateField;

	private static readonly GetDirtyIDDelegate GetDirtyIDDelegateField;

	private static readonly GetBuildIndexInternalDelegate GetBuildIndexInternalDelegateField;

	private static readonly GetRootCountInternalDelegate GetRootCountInternalDelegateField;

	private static readonly GetRootGameObjectsInternalDelegate GetRootGameObjectsInternalDelegateField;

	private static readonly GetPathInternal_InjectedDelegate GetPathInternal_InjectedDelegateField;

	private static readonly SetPathAndGUIDInternal_InjectedDelegate SetPathAndGUIDInternal_InjectedDelegateField;

	private static readonly GetNameInternal_InjectedDelegate GetNameInternal_InjectedDelegateField;

	private static readonly SetNameInternal_InjectedDelegate SetNameInternal_InjectedDelegateField;

	public unsafe int handle
	{
		[CallerCount(256)]
		[CachedScanResults(RefRangeStart = 1153990, RefRangeEnd = 1154246, XrefRangeStart = 1153990, XrefRangeEnd = 1154246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_handle_Public_get_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe string guid
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1228445, XrefRangeEnd = 1228446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_guid_Internal_get_String_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
	}

	public LoadingState loadingState => GetLoadingStateInternal(handle);

	public string path => GetPathInternal(handle);

	public string name
	{
		get
		{
			return GetNameInternal(handle);
		}
		set
		{
			SetNameInternal(handle, value);
		}
	}

	public bool isLoaded => GetIsLoadedInternal(handle);

	public int buildIndex => GetBuildIndexInternal(handle);

	public bool isDirty => GetIsDirtyInternal(handle);

	public int dirtyID => GetDirtyID(handle);

	public int rootCount => GetRootCountInternal(handle);

	public bool isSubScene
	{
		get
		{
			return IsSubScene(handle);
		}
		set
		{
			SetIsSubScene(handle, value);
		}
	}

	static Scene()
	{
		Il2CppClassPointerStore<Scene>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.SceneManagement", "Scene");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Scene>.NativeClassPtr);
		NativeFieldInfoPtr_m_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scene>.NativeClassPtr, "m_Handle");
		NativeMethodInfoPtr_GetGUIDInternal_Private_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scene>.NativeClassPtr, 100667253);
		NativeMethodInfoPtr_get_handle_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scene>.NativeClassPtr, 100667254);
		NativeMethodInfoPtr_get_guid_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scene>.NativeClassPtr, 100667255);
		NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scene>.NativeClassPtr, 100667256);
		NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scene>.NativeClassPtr, 100667257);
		NativeMethodInfoPtr_GetGUIDInternal_Injected_Private_Static_Void_Int32_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scene>.NativeClassPtr, 100667258);
		IsValidInternalDelegateField = IL2CPP.ResolveICall<IsValidInternalDelegate>("UnityEngine.SceneManagement.Scene::IsValidInternal");
		IsSubSceneDelegateField = IL2CPP.ResolveICall<IsSubSceneDelegate>("UnityEngine.SceneManagement.Scene::IsSubScene");
		SetIsSubSceneDelegateField = IL2CPP.ResolveICall<SetIsSubSceneDelegate>("UnityEngine.SceneManagement.Scene::SetIsSubScene");
		GetIsLoadedInternalDelegateField = IL2CPP.ResolveICall<GetIsLoadedInternalDelegate>("UnityEngine.SceneManagement.Scene::GetIsLoadedInternal");
		GetLoadingStateInternalDelegateField = IL2CPP.ResolveICall<GetLoadingStateInternalDelegate>("UnityEngine.SceneManagement.Scene::GetLoadingStateInternal");
		GetIsDirtyInternalDelegateField = IL2CPP.ResolveICall<GetIsDirtyInternalDelegate>("UnityEngine.SceneManagement.Scene::GetIsDirtyInternal");
		GetDirtyIDDelegateField = IL2CPP.ResolveICall<GetDirtyIDDelegate>("UnityEngine.SceneManagement.Scene::GetDirtyID");
		GetBuildIndexInternalDelegateField = IL2CPP.ResolveICall<GetBuildIndexInternalDelegate>("UnityEngine.SceneManagement.Scene::GetBuildIndexInternal");
		GetRootCountInternalDelegateField = IL2CPP.ResolveICall<GetRootCountInternalDelegate>("UnityEngine.SceneManagement.Scene::GetRootCountInternal");
		GetRootGameObjectsInternalDelegateField = IL2CPP.ResolveICall<GetRootGameObjectsInternalDelegate>("UnityEngine.SceneManagement.Scene::GetRootGameObjectsInternal");
		GetPathInternal_InjectedDelegateField = IL2CPP.ResolveICall<GetPathInternal_InjectedDelegate>("UnityEngine.SceneManagement.Scene::GetPathInternal_Injected");
		SetPathAndGUIDInternal_InjectedDelegateField = IL2CPP.ResolveICall<SetPathAndGUIDInternal_InjectedDelegate>("UnityEngine.SceneManagement.Scene::SetPathAndGUIDInternal_Injected");
		GetNameInternal_InjectedDelegateField = IL2CPP.ResolveICall<GetNameInternal_InjectedDelegate>("UnityEngine.SceneManagement.Scene::GetNameInternal_Injected");
		SetNameInternal_InjectedDelegateField = IL2CPP.ResolveICall<SetNameInternal_InjectedDelegate>("UnityEngine.SceneManagement.Scene::SetNameInternal_Injected");
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1228444, RefRangeEnd = 1228445, XrefRangeStart = 1228439, XrefRangeEnd = 1228444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetGUIDInternal(int sceneHandle)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&sceneHandle);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetGUIDInternal_Private_Static_String_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(256)]
	[CachedScanResults(RefRangeStart = 1153990, RefRangeEnd = 1154246, XrefRangeStart = 1153990, XrefRangeEnd = 1154246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override int GetHashCode()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1228446, XrefRangeEnd = 1228449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Equals(Il2CppSystem.Object other)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)other);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1228449, XrefRangeEnd = 1228451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetGUIDInternal_Injected(int sceneHandle, out ManagedSpanWrapper ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&sceneHandle);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetGUIDInternal_Injected_Private_Static_Void_Int32_byref_ManagedSpanWrapper_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Scene>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}

	public static bool IsValidInternal(int sceneHandle)
	{
		return IsValidInternalDelegateField(sceneHandle);
	}

	public static string GetPathInternal(int sceneHandle)
	{
		Unsafe.SkipInit(out ManagedSpanWrapper ret);
		string stringAndDispose;
		try
		{
			GetPathInternal_Injected(sceneHandle, out ret);
		}
		finally
		{
			stringAndDispose = OutStringMarshaller.GetStringAndDispose(ret);
		}
		return stringAndDispose;
	}

	public unsafe static void SetPathAndGUIDInternal(int sceneHandle, string path, string guid)
	{
		//IL_0019: Expected O, but got Ref
		//IL_0025: Expected O, but got Ref
		//IL_0045: Expected O, but got Ref
		//IL_0053: Expected O, but got Ref
		//The blocks IL_002a, IL_0037, IL_0045, IL_0053, IL_0058 are reachable both inside and outside the pinned region starting at IL_0019. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		//The blocks IL_0058 are reachable both inside and outside the pinned region starting at IL_0045. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		//The blocks IL_0058 are reachable both inside and outside the pinned region starting at IL_0045. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			ref ManagedSpanWrapper reference;
			Il2CppSystem.ReadOnlySpan<char> readOnlySpan2;
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper2);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(path, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(path);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					reference = ref managedSpanWrapper;
					if (!StringMarshaller.TryMarshalEmptyOrNullString(guid, ref managedSpanWrapper2))
					{
						readOnlySpan2 = Il2CppSystem.MemoryExtensions.AsSpan(guid);
						fixed (char* begin2 = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan2)).GetPinnableReference())
						{
							managedSpanWrapper2 = new ManagedSpanWrapper(begin2, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan2)).Length);
							SetPathAndGUIDInternal_Injected(sceneHandle, ref reference, ref managedSpanWrapper2);
							return;
						}
					}
					SetPathAndGUIDInternal_Injected(sceneHandle, ref reference, ref managedSpanWrapper2);
					return;
				}
			}
			reference = ref managedSpanWrapper;
			if (!StringMarshaller.TryMarshalEmptyOrNullString(guid, ref managedSpanWrapper2))
			{
				readOnlySpan2 = Il2CppSystem.MemoryExtensions.AsSpan(guid);
				fixed (char* begin2 = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan2)).GetPinnableReference())
				{
					managedSpanWrapper2 = new ManagedSpanWrapper(begin2, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan2)).Length);
					SetPathAndGUIDInternal_Injected(sceneHandle, ref reference, ref managedSpanWrapper2);
					return;
				}
			}
			SetPathAndGUIDInternal_Injected(sceneHandle, ref reference, ref managedSpanWrapper2);
		}
		finally
		{
		}
	}

	public static string GetNameInternal(int sceneHandle)
	{
		Unsafe.SkipInit(out ManagedSpanWrapper ret);
		string stringAndDispose;
		try
		{
			GetNameInternal_Injected(sceneHandle, out ret);
		}
		finally
		{
			stringAndDispose = OutStringMarshaller.GetStringAndDispose(ret);
		}
		return stringAndDispose;
	}

	public unsafe static void SetNameInternal(int sceneHandle, string name)
	{
		//IL_0019: Expected O, but got Ref
		//IL_0025: Expected O, but got Ref
		//The blocks IL_002a are reachable both inside and outside the pinned region starting at IL_0019. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(name, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(name);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					SetNameInternal_Injected(sceneHandle, ref managedSpanWrapper);
					return;
				}
			}
			SetNameInternal_Injected(sceneHandle, ref managedSpanWrapper);
		}
		finally
		{
		}
	}

	public static bool IsSubScene(int sceneHandle)
	{
		return IsSubSceneDelegateField(sceneHandle);
	}

	public static void SetIsSubScene(int sceneHandle, bool value)
	{
		SetIsSubSceneDelegateField(sceneHandle, value);
	}

	public static bool GetIsLoadedInternal(int sceneHandle)
	{
		return GetIsLoadedInternalDelegateField(sceneHandle);
	}

	public static LoadingState GetLoadingStateInternal(int sceneHandle)
	{
		return GetLoadingStateInternalDelegateField(sceneHandle);
	}

	public static bool GetIsDirtyInternal(int sceneHandle)
	{
		return GetIsDirtyInternalDelegateField(sceneHandle);
	}

	public static int GetDirtyID(int sceneHandle)
	{
		return GetDirtyIDDelegateField(sceneHandle);
	}

	public static int GetBuildIndexInternal(int sceneHandle)
	{
		return GetBuildIndexInternalDelegateField(sceneHandle);
	}

	public static int GetRootCountInternal(int sceneHandle)
	{
		return GetRootCountInternalDelegateField(sceneHandle);
	}

	public static void GetRootGameObjectsInternal(int sceneHandle, Il2CppSystem.Object resultRootList)
	{
		GetRootGameObjectsInternalDelegateField(sceneHandle, IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)resultRootList));
	}

	public bool IsValid()
	{
		return IsValidInternal(handle);
	}

	public Il2CppReferenceArray<GameObject> GetRootGameObjects()
	{
		List<GameObject> list = new List<GameObject>(rootCount);
		GetRootGameObjects(list);
		return (Il2CppReferenceArray<GameObject>)(object)list.ToArray();
	}

	public void GetRootGameObjects(List<GameObject> rootGameObjects)
	{
		if (rootGameObjects.Capacity < rootCount)
		{
			rootGameObjects.Capacity = rootCount;
		}
		rootGameObjects.Clear();
		if (!IsValid())
		{
			throw new Il2CppSystem.ArgumentException("The scene is invalid.");
		}
		if (!Application.isPlaying && !isLoaded)
		{
			throw new Il2CppSystem.ArgumentException("The scene is not loaded.");
		}
		if (rootCount != 0)
		{
			GetRootGameObjectsInternal(handle, rootGameObjects);
		}
	}

	public static bool operator ==(Scene lhs, Scene rhs)
	{
		return lhs.handle == rhs.handle;
	}

	public static bool operator !=(Scene lhs, Scene rhs)
	{
		return lhs.handle != rhs.handle;
	}

	public void SetPathAndGuid(string path, string guid)
	{
		SetPathAndGUIDInternal(m_Handle, path, guid);
	}

	public unsafe static void GetPathInternal_Injected(int sceneHandle, out ManagedSpanWrapper ret)
	{
		GetPathInternal_InjectedDelegateField(sceneHandle, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void SetPathAndGUIDInternal_Injected(int sceneHandle, ref ManagedSpanWrapper path, ref ManagedSpanWrapper guid)
	{
		SetPathAndGUIDInternal_InjectedDelegateField(sceneHandle, (nint)Unsafe.AsPointer(ref path), (nint)Unsafe.AsPointer(ref guid));
	}

	public unsafe static void GetNameInternal_Injected(int sceneHandle, out ManagedSpanWrapper ret)
	{
		GetNameInternal_InjectedDelegateField(sceneHandle, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void SetNameInternal_Injected(int sceneHandle, ref ManagedSpanWrapper name)
	{
		SetNameInternal_InjectedDelegateField(sceneHandle, (nint)Unsafe.AsPointer(ref name));
	}
}
