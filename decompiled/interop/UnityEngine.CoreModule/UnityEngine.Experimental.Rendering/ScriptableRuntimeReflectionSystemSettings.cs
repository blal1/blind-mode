using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Experimental.Rendering;

public static class ScriptableRuntimeReflectionSystemSettings : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_s_Instance;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_Internal_ScriptableRuntimeReflectionSystemSettings_system_Private_Static_set_Void_IScriptableRuntimeReflectionSystem_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Internal_ScriptableRuntimeReflectionSystemSettings_instance_Private_Static_get_ScriptableRuntimeReflectionSystemWrapper_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ScriptingDirtyReflectionSystemInstance_Private_Static_Void_0;

	public unsafe static ScriptableRuntimeReflectionSystemWrapper s_Instance
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_Instance, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ScriptableRuntimeReflectionSystemWrapper>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_Instance, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static IScriptableRuntimeReflectionSystem Internal_ScriptableRuntimeReflectionSystemSettings_system
	{
		get
		{
			return s_Instance.implementation;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1241072, XrefRangeEnd = 1241089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Internal_ScriptableRuntimeReflectionSystemSettings_system_Private_Static_set_Void_IScriptableRuntimeReflectionSystem_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe static ScriptableRuntimeReflectionSystemWrapper Internal_ScriptableRuntimeReflectionSystemSettings_instance
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1241089, XrefRangeEnd = 1241093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Internal_ScriptableRuntimeReflectionSystemSettings_instance_Private_Static_get_ScriptableRuntimeReflectionSystemWrapper_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ScriptableRuntimeReflectionSystemWrapper>(intPtr2) : null;
		}
	}

	public static IScriptableRuntimeReflectionSystem system
	{
		get
		{
			return Internal_ScriptableRuntimeReflectionSystemSettings_system;
		}
		set
		{
			throw new System.NotSupportedException("Method unstripping failed");
		}
	}

	static ScriptableRuntimeReflectionSystemSettings()
	{
		Il2CppClassPointerStore<ScriptableRuntimeReflectionSystemSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Experimental.Rendering", "ScriptableRuntimeReflectionSystemSettings");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptableRuntimeReflectionSystemSettings>.NativeClassPtr);
		NativeFieldInfoPtr_s_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRuntimeReflectionSystemSettings>.NativeClassPtr, "s_Instance");
		NativeMethodInfoPtr_set_Internal_ScriptableRuntimeReflectionSystemSettings_system_Private_Static_set_Void_IScriptableRuntimeReflectionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRuntimeReflectionSystemSettings>.NativeClassPtr, 100668945);
		NativeMethodInfoPtr_get_Internal_ScriptableRuntimeReflectionSystemSettings_instance_Private_Static_get_ScriptableRuntimeReflectionSystemWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRuntimeReflectionSystemSettings>.NativeClassPtr, 100668946);
		NativeMethodInfoPtr_ScriptingDirtyReflectionSystemInstance_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRuntimeReflectionSystemSettings>.NativeClassPtr, 100668947);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1241093, XrefRangeEnd = 1241103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ScriptingDirtyReflectionSystemInstance()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ScriptingDirtyReflectionSystemInstance_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public ScriptableRuntimeReflectionSystemSettings(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
