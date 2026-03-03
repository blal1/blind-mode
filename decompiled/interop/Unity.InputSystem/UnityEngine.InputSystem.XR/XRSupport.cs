using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.InputSystem.XR;

public static class XRSupport : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_0;

	static XRSupport()
	{
		Il2CppClassPointerStore<XRSupport>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.InputSystem.dll", "UnityEngine.InputSystem.XR", "XRSupport");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XRSupport>.NativeClassPtr);
		NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRSupport>.NativeClassPtr, 100666520);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1000424, RefRangeEnd = 1000426, XrefRangeStart = 1000197, XrefRangeEnd = 1000424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Initialize()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public XRSupport(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
