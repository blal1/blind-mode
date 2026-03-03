using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using UnityEngine.SceneManagement;

namespace UnityEngine.Rendering;

public static class SceneExtensions : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_s_SceneGUID;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetGUID_Public_Static_String_Scene_0;

	public unsafe static PropertyInfo s_SceneGUID
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_SceneGUID, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<PropertyInfo>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_SceneGUID, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static SceneExtensions()
	{
		Il2CppClassPointerStore<SceneExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "SceneExtensions");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneExtensions>.NativeClassPtr);
		NativeFieldInfoPtr_s_SceneGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneExtensions>.NativeClassPtr, "s_SceneGUID");
		NativeMethodInfoPtr_GetGUID_Public_Static_String_Scene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneExtensions>.NativeClassPtr, 100665737);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1043851, RefRangeEnd = 1043855, XrefRangeStart = 1043842, XrefRangeEnd = 1043851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetGUID(this Scene scene)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&scene);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetGUID_Public_Static_String_Scene_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	public SceneExtensions(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
