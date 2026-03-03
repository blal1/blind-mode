using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.InputSystem.DualShock;

public static class DualShockSupport : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_0;

	static DualShockSupport()
	{
		Il2CppClassPointerStore<DualShockSupport>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.InputSystem.dll", "UnityEngine.InputSystem.DualShock", "DualShockSupport");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DualShockSupport>.NativeClassPtr);
		NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShockSupport>.NativeClassPtr, 100667261);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1007785, RefRangeEnd = 1007787, XrefRangeStart = 1007689, XrefRangeEnd = 1007785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Initialize()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public DualShockSupport(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
