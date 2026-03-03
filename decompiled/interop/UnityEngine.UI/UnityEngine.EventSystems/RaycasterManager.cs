using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.EventSystems;

public static class RaycasterManager : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_s_Raycasters;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddRaycaster_Internal_Static_Void_BaseRaycaster_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRaycasters_Public_Static_List_1_BaseRaycaster_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveRaycasters_Internal_Static_Void_BaseRaycaster_0;

	public unsafe static List<BaseRaycaster> s_Raycasters
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_Raycasters, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<BaseRaycaster>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_Raycasters, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static RaycasterManager()
	{
		Il2CppClassPointerStore<RaycasterManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.EventSystems", "RaycasterManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RaycasterManager>.NativeClassPtr);
		NativeFieldInfoPtr_s_Raycasters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RaycasterManager>.NativeClassPtr, "s_Raycasters");
		NativeMethodInfoPtr_AddRaycaster_Internal_Static_Void_BaseRaycaster_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RaycasterManager>.NativeClassPtr, 100665153);
		NativeMethodInfoPtr_GetRaycasters_Public_Static_List_1_BaseRaycaster_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RaycasterManager>.NativeClassPtr, 100665154);
		NativeMethodInfoPtr_RemoveRaycasters_Internal_Static_Void_BaseRaycaster_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RaycasterManager>.NativeClassPtr, 100665155);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1302388, XrefRangeEnd = 1302401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void AddRaycaster(BaseRaycaster baseRaycaster)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)baseRaycaster);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddRaycaster_Internal_Static_Void_BaseRaycaster_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1302401, XrefRangeEnd = 1302405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static List<BaseRaycaster> GetRaycasters()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRaycasters_Public_Static_List_1_BaseRaycaster_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<BaseRaycaster>>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1302405, XrefRangeEnd = 1302418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RemoveRaycasters(BaseRaycaster baseRaycaster)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)baseRaycaster);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveRaycasters_Internal_Static_Void_BaseRaycaster_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public RaycasterManager(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
