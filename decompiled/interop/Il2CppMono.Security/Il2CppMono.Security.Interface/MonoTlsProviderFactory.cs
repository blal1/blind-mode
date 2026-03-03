using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppMono.Security.Interface;

public static class MonoTlsProviderFactory : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_GetProvider_Public_Static_MonoTlsProvider_0;

	static MonoTlsProviderFactory()
	{
		Il2CppClassPointerStore<MonoTlsProviderFactory>.NativeClassPtr = IL2CPP.GetIl2CppClass("Mono.Security.dll", "Mono.Security.Interface", "MonoTlsProviderFactory");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoTlsProviderFactory>.NativeClassPtr);
		NativeMethodInfoPtr_GetProvider_Public_Static_MonoTlsProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsProviderFactory>.NativeClassPtr, 100663642);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 693581, RefRangeEnd = 693584, XrefRangeStart = 693578, XrefRangeEnd = 693581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static MonoTlsProvider GetProvider()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetProvider_Public_Static_MonoTlsProvider_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<MonoTlsProvider>(intPtr2) : null;
	}

	public MonoTlsProviderFactory(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
