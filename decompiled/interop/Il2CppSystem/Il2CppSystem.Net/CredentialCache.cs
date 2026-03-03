using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Net;

public class CredentialCache : Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_get_DefaultCredentials_Public_Static_get_ICredentials_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_DefaultNetworkCredentials_Public_Static_get_NetworkCredential_0;

	public unsafe static ICredentials DefaultCredentials
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 887615, XrefRangeEnd = 887619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_DefaultCredentials_Public_Static_get_ICredentials_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ICredentials>(intPtr2) : null;
		}
	}

	public unsafe static NetworkCredential DefaultNetworkCredentials
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 887619, XrefRangeEnd = 887623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_DefaultNetworkCredentials_Public_Static_get_NetworkCredential_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<NetworkCredential>(intPtr2) : null;
		}
	}

	static CredentialCache()
	{
		Il2CppClassPointerStore<CredentialCache>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "CredentialCache");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CredentialCache>.NativeClassPtr);
		NativeMethodInfoPtr_get_DefaultCredentials_Public_Static_get_ICredentials_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CredentialCache>.NativeClassPtr, 100666117);
		NativeMethodInfoPtr_get_DefaultNetworkCredentials_Public_Static_get_NetworkCredential_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CredentialCache>.NativeClassPtr, 100666118);
	}

	public CredentialCache(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
