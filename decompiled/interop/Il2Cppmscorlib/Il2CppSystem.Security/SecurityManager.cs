using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Security;

public static class SecurityManager : Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_EnsureElevatedPermissions_Internal_Static_Void_0;

	static SecurityManager()
	{
		Il2CppClassPointerStore<SecurityManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security", "SecurityManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SecurityManager>.NativeClassPtr);
		NativeMethodInfoPtr_EnsureElevatedPermissions_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecurityManager>.NativeClassPtr, 100669109);
	}

	[CallerCount(19883)]
	[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 20035, XrefRangeStart = 152, XrefRangeEnd = 20035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void EnsureElevatedPermissions()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnsureElevatedPermissions_Internal_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public SecurityManager(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
