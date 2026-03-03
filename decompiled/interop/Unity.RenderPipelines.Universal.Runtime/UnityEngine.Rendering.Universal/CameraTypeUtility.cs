using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.Universal;

public static class CameraTypeUtility : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_s_CameraTypeNames;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetName_Public_Static_String_CameraRenderType_0;

	public unsafe static Il2CppStringArray s_CameraTypeNames
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_CameraTypeNames, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_CameraTypeNames, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static CameraTypeUtility()
	{
		Il2CppClassPointerStore<CameraTypeUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "CameraTypeUtility");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CameraTypeUtility>.NativeClassPtr);
		NativeFieldInfoPtr_s_CameraTypeNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraTypeUtility>.NativeClassPtr, "s_CameraTypeNames");
		NativeMethodInfoPtr_GetName_Public_Static_String_CameraRenderType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraTypeUtility>.NativeClassPtr, 100665654);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1101487, XrefRangeEnd = 1101493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetName(this CameraRenderType type)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&type);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetName_Public_Static_String_CameraRenderType_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	public CameraTypeUtility(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
