using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2Cpp;

public static class UISupport : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_0;

	static UISupport()
	{
		Il2CppClassPointerStore<UISupport>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.InputSystem.dll", "", "UISupport");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UISupport>.NativeClassPtr);
		NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISupport>.NativeClassPtr, 100663297);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 962815, RefRangeEnd = 962817, XrefRangeStart = 962809, XrefRangeEnd = 962815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Initialize()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public UISupport(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
