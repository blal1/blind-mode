using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.SceneManagement;

public class SceneManagerAPI : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_s_DefaultAPI;

	private static readonly System.IntPtr NativeFieldInfoPtr__overrideAPI_k__BackingField;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_ActiveAPI_Internal_Static_get_SceneManagerAPI_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_overrideAPI_Public_Static_get_SceneManagerAPI_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_FamOrAssem_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadSceneAsyncByNameOrIndex_FamOrAssem_Virtual_New_AsyncOperation_String_Int32_LoadSceneParameters_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadFirstScene_FamOrAssem_Virtual_New_AsyncOperation_Boolean_0;

	public unsafe static SceneManagerAPI s_DefaultAPI
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_DefaultAPI, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<SceneManagerAPI>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_DefaultAPI, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static SceneManagerAPI _overrideAPI_k__BackingField
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__overrideAPI_k__BackingField, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<SceneManagerAPI>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__overrideAPI_k__BackingField, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static SceneManagerAPI ActiveAPI
	{
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1228478, RefRangeEnd = 1228482, XrefRangeStart = 1228468, XrefRangeEnd = 1228478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ActiveAPI_Internal_Static_get_SceneManagerAPI_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<SceneManagerAPI>(intPtr2) : null;
		}
	}

	public unsafe static SceneManagerAPI overrideAPI
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1228482, XrefRangeEnd = 1228486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_overrideAPI_Public_Static_get_SceneManagerAPI_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<SceneManagerAPI>(intPtr2) : null;
		}
		set
		{
			_overrideAPI_k__BackingField = value;
		}
	}

	static SceneManagerAPI()
	{
		Il2CppClassPointerStore<SceneManagerAPI>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.SceneManagement", "SceneManagerAPI");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneManagerAPI>.NativeClassPtr);
		NativeFieldInfoPtr_s_DefaultAPI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManagerAPI>.NativeClassPtr, "s_DefaultAPI");
		NativeFieldInfoPtr__overrideAPI_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManagerAPI>.NativeClassPtr, "<overrideAPI>k__BackingField");
		NativeMethodInfoPtr_get_ActiveAPI_Internal_Static_get_SceneManagerAPI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManagerAPI>.NativeClassPtr, 100667261);
		NativeMethodInfoPtr_get_overrideAPI_Public_Static_get_SceneManagerAPI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManagerAPI>.NativeClassPtr, 100667262);
		NativeMethodInfoPtr__ctor_FamOrAssem_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManagerAPI>.NativeClassPtr, 100667263);
		NativeMethodInfoPtr_LoadSceneAsyncByNameOrIndex_FamOrAssem_Virtual_New_AsyncOperation_String_Int32_LoadSceneParameters_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManagerAPI>.NativeClassPtr, 100667264);
		NativeMethodInfoPtr_LoadFirstScene_FamOrAssem_Virtual_New_AsyncOperation_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManagerAPI>.NativeClassPtr, 100667265);
	}

	[CallerCount(1950)]
	[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SceneManagerAPI()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SceneManagerAPI>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_FamOrAssem_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1228486, XrefRangeEnd = 1228487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual AsyncOperation LoadSceneAsyncByNameOrIndex(string sceneName, int sceneBuildIndex, LoadSceneParameters parameters, bool mustCompleteNextFrame)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(sceneName);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &sceneBuildIndex;
		*(LoadSceneParameters**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &parameters;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &mustCompleteNextFrame;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_LoadSceneAsyncByNameOrIndex_FamOrAssem_Virtual_New_AsyncOperation_String_Int32_LoadSceneParameters_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<AsyncOperation>(intPtr2) : null;
	}

	[CallerCount(146)]
	[CachedScanResults(RefRangeStart = 35395, RefRangeEnd = 35541, XrefRangeStart = 35395, XrefRangeEnd = 35541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual AsyncOperation LoadFirstScene(bool mustLoadAsync)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&mustLoadAsync);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_LoadFirstScene_FamOrAssem_Virtual_New_AsyncOperation_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<AsyncOperation>(intPtr2) : null;
	}

	public SceneManagerAPI(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public virtual int GetNumScenesInBuildSettings()
	{
		return SceneManagerAPIInternal.GetNumScenesInBuildSettings();
	}

	public virtual Scene GetSceneByBuildIndex(int buildIndex)
	{
		return SceneManagerAPIInternal.GetSceneByBuildIndex(buildIndex);
	}

	public virtual AsyncOperation UnloadSceneAsyncByNameOrIndex(string sceneName, int sceneBuildIndex, bool immediately, UnloadSceneOptions options, out bool outSuccess)
	{
		return SceneManagerAPIInternal.UnloadSceneNameIndexInternal(sceneName, sceneBuildIndex, immediately, options, out outSuccess);
	}
}
