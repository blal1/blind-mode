using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMono.Security.Interface;
using Il2CppSystem.IO;
using Il2CppSystem.Net.Security;
using Il2CppSystem.Security.Cryptography.X509Certificates;

namespace Il2CppMono.Net.Security;

public class MobileTlsProvider : MonoTlsProvider
{
	private static readonly IntPtr NativeMethodInfoPtr_CreateSslStream_Internal_Abstract_Virtual_New_MobileAuthenticatedStream_SslStream_Stream_Boolean_MonoTlsSettings_0;

	private static readonly IntPtr NativeMethodInfoPtr_ValidateCertificate_Internal_Abstract_Virtual_New_Boolean_ChainValidationHelper_String_Boolean_X509CertificateCollection_Boolean_byref_X509Chain_byref_SslPolicyErrors_byref_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

	static MobileTlsProvider()
	{
		Il2CppClassPointerStore<MobileTlsProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "Mono.Net.Security", "MobileTlsProvider");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MobileTlsProvider>.NativeClassPtr);
		NativeMethodInfoPtr_CreateSslStream_Internal_Abstract_Virtual_New_MobileAuthenticatedStream_SslStream_Stream_Boolean_MonoTlsSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileTlsProvider>.NativeClassPtr, 100663613);
		NativeMethodInfoPtr_ValidateCertificate_Internal_Abstract_Virtual_New_Boolean_ChainValidationHelper_String_Boolean_X509CertificateCollection_Boolean_byref_X509Chain_byref_SslPolicyErrors_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileTlsProvider>.NativeClassPtr, 100663614);
		NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MobileTlsProvider>.NativeClassPtr, 100663615);
	}

	[CallerCount(0)]
	public unsafe virtual MobileAuthenticatedStream CreateSslStream(SslStream sslStream, Stream innerStream, bool leaveInnerStreamOpen, MonoTlsSettings settings)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sslStream);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)innerStream);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &leaveInnerStreamOpen;
		*(IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)settings);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_CreateSslStream_Internal_Abstract_Virtual_New_MobileAuthenticatedStream_SslStream_Stream_Boolean_MonoTlsSettings_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<MobileAuthenticatedStream>(intPtr2) : null;
	}

	[CallerCount(0)]
	public unsafe virtual bool ValidateCertificate(ChainValidationHelper validator, string targetHost, bool serverMode, X509CertificateCollection certificates, bool wantsChain, ref X509Chain chain, ref SslPolicyErrors errors, ref int status11)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[8];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)validator);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(targetHost);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &serverMode;
		*(IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)certificates);
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(IntPtr)))) = &wantsChain;
		byte* num = (byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(IntPtr)));
		IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chain);
		*(IntPtr**)num = &intPtr;
		*(void**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(IntPtr)))) = Unsafe.AsPointer(ref errors);
		*(void**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(IntPtr)))) = Unsafe.AsPointer(ref status11);
		Unsafe.SkipInit(out IntPtr intPtr2);
		IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ValidateCertificate_Internal_Abstract_Virtual_New_Boolean_ChainValidationHelper_String_Boolean_X509CertificateCollection_Boolean_byref_X509Chain_byref_SslPolicyErrors_byref_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr4 = intPtr;
		chain = ((intPtr4 == (IntPtr)0) ? null : new X509Chain(intPtr4));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr3);
	}

	[CallerCount(134)]
	[CachedScanResults(RefRangeStart = 24861, RefRangeEnd = 24995, XrefRangeStart = 24861, XrefRangeEnd = 24995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MobileTlsProvider()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MobileTlsProvider>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public MobileTlsProvider(IntPtr pointer)
		: base(pointer)
	{
	}
}
