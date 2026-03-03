using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.InputSystem.XInput;

public static class XInputSupport : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_0;

	static XInputSupport()
	{
		Il2CppClassPointerStore<XInputSupport>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.InputSystem.dll", "UnityEngine.InputSystem.XInput", "XInputSupport");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XInputSupport>.NativeClassPtr);
		NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XInputSupport>.NativeClassPtr, 100666565);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1000488, RefRangeEnd = 1000490, XrefRangeStart = 1000470, XrefRangeEnd = 1000488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Initialize()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public XInputSupport(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
