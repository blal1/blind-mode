using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.InputSystem.Switch;

public static class SwitchSupportHID : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_0;

	static SwitchSupportHID()
	{
		Il2CppClassPointerStore<SwitchSupportHID>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.InputSystem.dll", "UnityEngine.InputSystem.Switch", "SwitchSupportHID");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SwitchSupportHID>.NativeClassPtr);
		NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SwitchSupportHID>.NativeClassPtr, 100666950);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1004540, RefRangeEnd = 1004542, XrefRangeStart = 1004355, XrefRangeEnd = 1004540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Initialize()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public SwitchSupportHID(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
