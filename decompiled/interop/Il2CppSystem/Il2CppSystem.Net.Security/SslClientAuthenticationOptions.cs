using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Security.Authentication;
using Il2CppSystem.Security.Cryptography.X509Certificates;

namespace Il2CppSystem.Net.Security;

public class SslClientAuthenticationOptions : Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr__encryptionPolicy;

	private static readonly System.IntPtr NativeFieldInfoPtr__checkCertificateRevocation;

	private static readonly System.IntPtr NativeFieldInfoPtr__enabledSslProtocols;

	private static readonly System.IntPtr NativeFieldInfoPtr__allowRenegotiation;

	private static readonly System.IntPtr NativeFieldInfoPtr__TargetHost_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__ClientCertificates_k__BackingField;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_AllowRenegotiation_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_TargetHost_Public_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_TargetHost_Public_set_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_ClientCertificates_Public_get_X509CertificateCollection_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_ClientCertificates_Public_set_Void_X509CertificateCollection_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_CertificateRevocationCheckMode_Public_set_Void_X509RevocationMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_EncryptionPolicy_Public_set_Void_EncryptionPolicy_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_EnabledSslProtocols_Public_get_SslProtocols_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_EnabledSslProtocols_Public_set_Void_SslProtocols_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe EncryptionPolicy _encryptionPolicy
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__encryptionPolicy);
			return *(EncryptionPolicy*)num;
		}
		set
		{
			*(EncryptionPolicy*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__encryptionPolicy)) = value;
		}
	}

	public unsafe X509RevocationMode _checkCertificateRevocation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__checkCertificateRevocation);
			return *(X509RevocationMode*)num;
		}
		set
		{
			*(X509RevocationMode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__checkCertificateRevocation)) = value;
		}
	}

	public unsafe SslProtocols _enabledSslProtocols
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__enabledSslProtocols);
			return *(SslProtocols*)num;
		}
		set
		{
			*(SslProtocols*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__enabledSslProtocols)) = value;
		}
	}

	public unsafe bool _allowRenegotiation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__allowRenegotiation);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__allowRenegotiation)) = value;
		}
	}

	public unsafe string _TargetHost_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__TargetHost_k__BackingField);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__TargetHost_k__BackingField)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe X509CertificateCollection _ClientCertificates_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ClientCertificates_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<X509CertificateCollection>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ClientCertificates_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe bool AllowRenegotiation
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_AllowRenegotiation_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe string TargetHost
	{
		[CallerCount(36)]
		[CachedScanResults(RefRangeStart = 32112, RefRangeEnd = 32148, XrefRangeStart = 32112, XrefRangeEnd = 32148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_TargetHost_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 32149, RefRangeEnd = 32159, XrefRangeStart = 32149, XrefRangeEnd = 32159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_TargetHost_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe X509CertificateCollection ClientCertificates
	{
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 42604, RefRangeEnd = 42610, XrefRangeStart = 42604, XrefRangeEnd = 42610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ClientCertificates_Public_get_X509CertificateCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<X509CertificateCollection>(intPtr2) : null;
		}
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 41896, RefRangeEnd = 41911, XrefRangeStart = 41896, XrefRangeEnd = 41911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_ClientCertificates_Public_set_Void_X509CertificateCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe X509RevocationMode CertificateRevocationCheckMode
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 900301, RefRangeEnd = 900302, XrefRangeStart = 900301, XrefRangeEnd = 900301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_CertificateRevocationCheckMode_Public_set_Void_X509RevocationMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe EncryptionPolicy EncryptionPolicy
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 900302, RefRangeEnd = 900303, XrefRangeStart = 900302, XrefRangeEnd = 900302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_EncryptionPolicy_Public_set_Void_EncryptionPolicy_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe SslProtocols EnabledSslProtocols
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 54510, RefRangeEnd = 54511, XrefRangeStart = 54510, XrefRangeEnd = 54511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_EnabledSslProtocols_Public_get_SslProtocols_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(SslProtocols*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 155401, RefRangeEnd = 155404, XrefRangeStart = 155401, XrefRangeEnd = 155404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_EnabledSslProtocols_Public_set_Void_SslProtocols_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	static SslClientAuthenticationOptions()
	{
		Il2CppClassPointerStore<SslClientAuthenticationOptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.Security", "SslClientAuthenticationOptions");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SslClientAuthenticationOptions>.NativeClassPtr);
		NativeFieldInfoPtr__encryptionPolicy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SslClientAuthenticationOptions>.NativeClassPtr, "_encryptionPolicy");
		NativeFieldInfoPtr__checkCertificateRevocation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SslClientAuthenticationOptions>.NativeClassPtr, "_checkCertificateRevocation");
		NativeFieldInfoPtr__enabledSslProtocols = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SslClientAuthenticationOptions>.NativeClassPtr, "_enabledSslProtocols");
		NativeFieldInfoPtr__allowRenegotiation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SslClientAuthenticationOptions>.NativeClassPtr, "_allowRenegotiation");
		NativeFieldInfoPtr__TargetHost_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SslClientAuthenticationOptions>.NativeClassPtr, "<TargetHost>k__BackingField");
		NativeFieldInfoPtr__ClientCertificates_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SslClientAuthenticationOptions>.NativeClassPtr, "<ClientCertificates>k__BackingField");
		NativeMethodInfoPtr_get_AllowRenegotiation_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SslClientAuthenticationOptions>.NativeClassPtr, 100667477);
		NativeMethodInfoPtr_get_TargetHost_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SslClientAuthenticationOptions>.NativeClassPtr, 100667478);
		NativeMethodInfoPtr_set_TargetHost_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SslClientAuthenticationOptions>.NativeClassPtr, 100667479);
		NativeMethodInfoPtr_get_ClientCertificates_Public_get_X509CertificateCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SslClientAuthenticationOptions>.NativeClassPtr, 100667480);
		NativeMethodInfoPtr_set_ClientCertificates_Public_set_Void_X509CertificateCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SslClientAuthenticationOptions>.NativeClassPtr, 100667481);
		NativeMethodInfoPtr_set_CertificateRevocationCheckMode_Public_set_Void_X509RevocationMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SslClientAuthenticationOptions>.NativeClassPtr, 100667482);
		NativeMethodInfoPtr_set_EncryptionPolicy_Public_set_Void_EncryptionPolicy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SslClientAuthenticationOptions>.NativeClassPtr, 100667483);
		NativeMethodInfoPtr_get_EnabledSslProtocols_Public_get_SslProtocols_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SslClientAuthenticationOptions>.NativeClassPtr, 100667484);
		NativeMethodInfoPtr_set_EnabledSslProtocols_Public_set_Void_SslProtocols_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SslClientAuthenticationOptions>.NativeClassPtr, 100667485);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SslClientAuthenticationOptions>.NativeClassPtr, 100667486);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 345403, RefRangeEnd = 345406, XrefRangeStart = 345403, XrefRangeEnd = 345406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SslClientAuthenticationOptions()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SslClientAuthenticationOptions>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public SslClientAuthenticationOptions(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
