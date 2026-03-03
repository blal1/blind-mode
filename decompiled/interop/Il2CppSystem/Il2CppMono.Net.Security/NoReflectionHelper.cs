using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppMono.Net.Security;

public static class NoReflectionHelper : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_GetProvider_Internal_Static_Object_0;

	static NoReflectionHelper()
	{
		Il2CppClassPointerStore<NoReflectionHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "Mono.Net.Security", "NoReflectionHelper");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NoReflectionHelper>.NativeClassPtr);
		NativeMethodInfoPtr_GetProvider_Internal_Static_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoReflectionHelper>.NativeClassPtr, 100663664);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 864705, RefRangeEnd = 864706, XrefRangeStart = 864698, XrefRangeEnd = 864705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppSystem.Object GetProvider()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetProvider_Internal_Static_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
	}

	public NoReflectionHelper(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
