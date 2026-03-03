using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.InputSystem.OnScreen;

public static class UGUIOnScreenControlUtils : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_GetCanvasRectTransform_Public_Static_RectTransform_Transform_0;

	static UGUIOnScreenControlUtils()
	{
		Il2CppClassPointerStore<UGUIOnScreenControlUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.InputSystem.dll", "UnityEngine.InputSystem.OnScreen", "UGUIOnScreenControlUtils");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UGUIOnScreenControlUtils>.NativeClassPtr);
		NativeMethodInfoPtr_GetCanvasRectTransform_Public_Static_RectTransform_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UGUIOnScreenControlUtils>.NativeClassPtr, 100666978);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1004756, RefRangeEnd = 1004758, XrefRangeStart = 1004747, XrefRangeEnd = 1004756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static RectTransform GetCanvasRectTransform(Transform transform)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)transform);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCanvasRectTransform_Public_Static_RectTransform_Transform_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
	}

	public UGUIOnScreenControlUtils(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
