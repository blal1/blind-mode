using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Cryptography.X509Certificates;

public static class RSACertificateExtensions : Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_GetRSAPublicKey_Public_Static_RSA_X509Certificate2_0;

	static RSACertificateExtensions()
	{
		Il2CppClassPointerStore<RSACertificateExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Security.Cryptography.X509Certificates", "RSACertificateExtensions");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RSACertificateExtensions>.NativeClassPtr);
		NativeMethodInfoPtr_GetRSAPublicKey_Public_Static_RSA_X509Certificate2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSACertificateExtensions>.NativeClassPtr, 100663343);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 859461, RefRangeEnd = 859462, XrefRangeStart = 859457, XrefRangeEnd = 859461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static RSA GetRSAPublicKey(this X509Certificate2 certificate)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)certificate);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRSAPublicKey_Public_Static_RSA_X509Certificate2_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RSA>(intPtr2) : null;
	}

	public RSACertificateExtensions(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
