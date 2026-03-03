using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMono.Security.X509;

namespace Il2CppSystem.Security.Cryptography.X509Certificates;

public static class X509Helper2 : Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_GetMonoCertificate_Internal_Static_X509Certificate_X509Certificate2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateChainImpl_Internal_Static_X509ChainImpl_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsValid_Public_Static_Boolean_X509ChainImpl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ThrowIfContextInvalid_Internal_Static_Void_X509ChainImpl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetInvalidChainContextException_Internal_Static_Exception_0;

	static X509Helper2()
	{
		Il2CppClassPointerStore<X509Helper2>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Security.Cryptography.X509Certificates", "X509Helper2");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<X509Helper2>.NativeClassPtr);
		NativeMethodInfoPtr_GetMonoCertificate_Internal_Static_X509Certificate_X509Certificate2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Helper2>.NativeClassPtr, 100665203);
		NativeMethodInfoPtr_CreateChainImpl_Internal_Static_X509ChainImpl_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Helper2>.NativeClassPtr, 100665204);
		NativeMethodInfoPtr_IsValid_Public_Static_Boolean_X509ChainImpl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Helper2>.NativeClassPtr, 100665205);
		NativeMethodInfoPtr_ThrowIfContextInvalid_Internal_Static_Void_X509ChainImpl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Helper2>.NativeClassPtr, 100665206);
		NativeMethodInfoPtr_GetInvalidChainContextException_Internal_Static_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Helper2>.NativeClassPtr, 100665207);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 880739, RefRangeEnd = 880745, XrefRangeStart = 880735, XrefRangeEnd = 880739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppMono.Security.X509.X509Certificate GetMonoCertificate(X509Certificate2 certificate)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)certificate);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMonoCertificate_Internal_Static_X509Certificate_X509Certificate2_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppMono.Security.X509.X509Certificate>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 880745, XrefRangeEnd = 880749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static X509ChainImpl CreateChainImpl(bool useMachineContext)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&useMachineContext);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateChainImpl_Internal_Static_X509ChainImpl_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<X509ChainImpl>(intPtr2) : null;
	}

	[CallerCount(0)]
	public unsafe static bool IsValid(X509ChainImpl impl)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)impl);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsValid_Public_Static_Boolean_X509ChainImpl_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static void ThrowIfContextInvalid(X509ChainImpl impl)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)impl);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ThrowIfContextInvalid_Internal_Static_Void_X509ChainImpl_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 880756, RefRangeEnd = 880761, XrefRangeStart = 880749, XrefRangeEnd = 880756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Exception GetInvalidChainContextException()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetInvalidChainContextException_Internal_Static_Exception_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Exception>(intPtr2) : null;
	}

	public X509Helper2(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
