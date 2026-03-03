using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Security.Cryptography.X509Certificates;

namespace Il2CppMono.Security.Interface;

public sealed class MonoTlsSettings : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr__RemoteCertificateValidationCallback_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__ClientCertificateSelectionCallback_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__CertificateValidationTime_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__TrustAnchors_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__UserSettings_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__CertificateSearchPaths_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__SendCloseNotify_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__ClientCertificateIssuers_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__DisallowUnauthenticatedCertificateRequest_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__EnabledProtocols_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__EnabledCiphers_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr_cloned;

	private static readonly System.IntPtr NativeFieldInfoPtr_checkCertName;

	private static readonly System.IntPtr NativeFieldInfoPtr_checkCertRevocationStatus;

	private static readonly System.IntPtr NativeFieldInfoPtr_useServicePointManagerCallback;

	private static readonly System.IntPtr NativeFieldInfoPtr_skipSystemValidators;

	private static readonly System.IntPtr NativeFieldInfoPtr_callbackNeedsChain;

	private static readonly System.IntPtr NativeFieldInfoPtr_certificateValidator;

	private static readonly System.IntPtr NativeFieldInfoPtr_defaultSettings;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_RemoteCertificateValidationCallback_Public_get_MonoRemoteCertificateValidationCallback_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_RemoteCertificateValidationCallback_Public_set_Void_MonoRemoteCertificateValidationCallback_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_ClientCertificateSelectionCallback_Public_get_MonoLocalCertificateSelectionCallback_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_ClientCertificateSelectionCallback_Public_set_Void_MonoLocalCertificateSelectionCallback_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_UseServicePointManagerCallback_Public_get_Nullable_1_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_UseServicePointManagerCallback_Public_set_Void_Nullable_1_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_CallbackNeedsCertificateChain_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_CertificateValidationTime_Public_get_Nullable_1_DateTime_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_CertificateValidationTime_Public_set_Void_Nullable_1_DateTime_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_TrustAnchors_Public_get_X509CertificateCollection_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_TrustAnchors_Public_set_Void_X509CertificateCollection_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_UserSettings_Public_get_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_UserSettings_Public_set_Void_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_CertificateSearchPaths_Internal_get_Il2CppStringArray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_CertificateSearchPaths_Internal_set_Void_Il2CppStringArray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_SendCloseNotify_Internal_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_SendCloseNotify_Internal_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_ClientCertificateIssuers_Public_get_Il2CppStringArray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_ClientCertificateIssuers_Public_set_Void_Il2CppStringArray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_DisallowUnauthenticatedCertificateRequest_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_DisallowUnauthenticatedCertificateRequest_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_EnabledProtocols_Public_get_Nullable_1_TlsProtocols_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_EnabledProtocols_Public_set_Void_Nullable_1_TlsProtocols_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_EnabledCiphers_Public_get_Il2CppStructArray_1_CipherSuiteCode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_EnabledCiphers_Public_set_Void_Il2CppStructArray_1_CipherSuiteCode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_DefaultSettings_Public_Static_get_MonoTlsSettings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CopyDefaultSettings_Public_Static_MonoTlsSettings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_CertificateValidator_Public_get_ICertificateValidator_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CloneWithValidator_Public_MonoTlsSettings_ICertificateValidator_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Clone_Public_MonoTlsSettings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Private_Void_MonoTlsSettings_0;

	public unsafe MonoRemoteCertificateValidationCallback _RemoteCertificateValidationCallback_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__RemoteCertificateValidationCallback_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MonoRemoteCertificateValidationCallback>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__RemoteCertificateValidationCallback_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe MonoLocalCertificateSelectionCallback _ClientCertificateSelectionCallback_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ClientCertificateSelectionCallback_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MonoLocalCertificateSelectionCallback>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ClientCertificateSelectionCallback_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppSystem.Nullable<Il2CppSystem.DateTime> _CertificateValidationTime_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__CertificateValidationTime_k__BackingField);
			return new Il2CppSystem.Nullable<Il2CppSystem.DateTime>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Nullable<Il2CppSystem.DateTime>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__CertificateValidationTime_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Nullable<Il2CppSystem.DateTime>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe X509CertificateCollection _TrustAnchors_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__TrustAnchors_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<X509CertificateCollection>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__TrustAnchors_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppSystem.Object _UserSettings_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__UserSettings_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__UserSettings_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppStringArray _CertificateSearchPaths_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__CertificateSearchPaths_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__CertificateSearchPaths_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe bool _SendCloseNotify_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__SendCloseNotify_k__BackingField);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__SendCloseNotify_k__BackingField)) = value;
		}
	}

	public unsafe Il2CppStringArray _ClientCertificateIssuers_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ClientCertificateIssuers_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ClientCertificateIssuers_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe bool _DisallowUnauthenticatedCertificateRequest_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__DisallowUnauthenticatedCertificateRequest_k__BackingField);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__DisallowUnauthenticatedCertificateRequest_k__BackingField)) = value;
		}
	}

	public unsafe Il2CppSystem.Nullable<TlsProtocols> _EnabledProtocols_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__EnabledProtocols_k__BackingField);
			return new Il2CppSystem.Nullable<TlsProtocols>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Nullable<TlsProtocols>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__EnabledProtocols_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Nullable<TlsProtocols>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe Il2CppStructArray<CipherSuiteCode> _EnabledCiphers_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__EnabledCiphers_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<CipherSuiteCode>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__EnabledCiphers_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe bool cloned
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cloned);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cloned)) = value;
		}
	}

	public unsafe bool checkCertName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_checkCertName);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_checkCertName)) = value;
		}
	}

	public unsafe bool checkCertRevocationStatus
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_checkCertRevocationStatus);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_checkCertRevocationStatus)) = value;
		}
	}

	public unsafe Il2CppSystem.Nullable<bool> useServicePointManagerCallback
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useServicePointManagerCallback);
			return new Il2CppSystem.Nullable<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Nullable<bool>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useServicePointManagerCallback), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Nullable<bool>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe bool skipSystemValidators
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skipSystemValidators);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skipSystemValidators)) = value;
		}
	}

	public unsafe bool callbackNeedsChain
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_callbackNeedsChain);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_callbackNeedsChain)) = value;
		}
	}

	public unsafe ICertificateValidator certificateValidator
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_certificateValidator);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ICertificateValidator>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_certificateValidator)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static MonoTlsSettings defaultSettings
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_defaultSettings, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<MonoTlsSettings>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_defaultSettings, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe MonoRemoteCertificateValidationCallback RemoteCertificateValidationCallback
	{
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 50644, RefRangeEnd = 50653, XrefRangeStart = 50644, XrefRangeEnd = 50653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_RemoteCertificateValidationCallback_Public_get_MonoRemoteCertificateValidationCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<MonoRemoteCertificateValidationCallback>(intPtr2) : null;
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 42532, RefRangeEnd = 42533, XrefRangeStart = 42532, XrefRangeEnd = 42533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_RemoteCertificateValidationCallback_Public_set_Void_MonoRemoteCertificateValidationCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe MonoLocalCertificateSelectionCallback ClientCertificateSelectionCallback
	{
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 25665, RefRangeEnd = 25677, XrefRangeStart = 25665, XrefRangeEnd = 25677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ClientCertificateSelectionCallback_Public_get_MonoLocalCertificateSelectionCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<MonoLocalCertificateSelectionCallback>(intPtr2) : null;
		}
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 86477, RefRangeEnd = 86487, XrefRangeStart = 86477, XrefRangeEnd = 86487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_ClientCertificateSelectionCallback_Public_set_Void_MonoLocalCertificateSelectionCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe Il2CppSystem.Nullable<bool> UseServicePointManagerCallback
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_UseServicePointManagerCallback_Public_get_Nullable_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new Il2CppSystem.Nullable<bool>(pointer);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value));
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_UseServicePointManagerCallback_Public_set_Void_Nullable_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool CallbackNeedsCertificateChain
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_CallbackNeedsCertificateChain_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe Il2CppSystem.Nullable<Il2CppSystem.DateTime> CertificateValidationTime
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_CertificateValidationTime_Public_get_Nullable_1_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new Il2CppSystem.Nullable<Il2CppSystem.DateTime>(pointer);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value));
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_CertificateValidationTime_Public_set_Void_Nullable_1_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe X509CertificateCollection TrustAnchors
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 50643, RefRangeEnd = 50644, XrefRangeStart = 50643, XrefRangeEnd = 50644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_TrustAnchors_Public_get_X509CertificateCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<X509CertificateCollection>(intPtr2) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_TrustAnchors_Public_set_Void_X509CertificateCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe Il2CppSystem.Object UserSettings
	{
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 50653, RefRangeEnd = 50668, XrefRangeStart = 50653, XrefRangeEnd = 50668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_UserSettings_Public_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 84623, RefRangeEnd = 84624, XrefRangeStart = 84623, XrefRangeEnd = 84624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_UserSettings_Public_set_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe Il2CppStringArray CertificateSearchPaths
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_CertificateSearchPaths_Internal_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_CertificateSearchPaths_Internal_set_Void_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool SendCloseNotify
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_SendCloseNotify_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_SendCloseNotify_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe Il2CppStringArray ClientCertificateIssuers
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ClientCertificateIssuers_Public_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 42568, RefRangeEnd = 42569, XrefRangeStart = 42568, XrefRangeEnd = 42569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_ClientCertificateIssuers_Public_set_Void_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool DisallowUnauthenticatedCertificateRequest
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_DisallowUnauthenticatedCertificateRequest_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_DisallowUnauthenticatedCertificateRequest_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe Il2CppSystem.Nullable<TlsProtocols> EnabledProtocols
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_EnabledProtocols_Public_get_Nullable_1_TlsProtocols_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new Il2CppSystem.Nullable<TlsProtocols>(pointer);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value));
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_EnabledProtocols_Public_set_Void_Nullable_1_TlsProtocols_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe Il2CppStructArray<CipherSuiteCode> EnabledCiphers
	{
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 140862, RefRangeEnd = 140879, XrefRangeStart = 140862, XrefRangeEnd = 140879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_EnabledCiphers_Public_get_Il2CppStructArray_1_CipherSuiteCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<CipherSuiteCode>>(intPtr2) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_EnabledCiphers_Public_set_Void_Il2CppStructArray_1_CipherSuiteCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe static MonoTlsSettings DefaultSettings
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 693592, RefRangeEnd = 693593, XrefRangeStart = 693585, XrefRangeEnd = 693592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_DefaultSettings_Public_Static_get_MonoTlsSettings_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<MonoTlsSettings>(intPtr2) : null;
		}
	}

	public unsafe ICertificateValidator CertificateValidator
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_CertificateValidator_Public_get_ICertificateValidator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ICertificateValidator>(intPtr2) : null;
		}
	}

	static MonoTlsSettings()
	{
		Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Mono.Security.dll", "Mono.Security.Interface", "MonoTlsSettings");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr);
		NativeFieldInfoPtr__RemoteCertificateValidationCallback_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr, "<RemoteCertificateValidationCallback>k__BackingField");
		NativeFieldInfoPtr__ClientCertificateSelectionCallback_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr, "<ClientCertificateSelectionCallback>k__BackingField");
		NativeFieldInfoPtr__CertificateValidationTime_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr, "<CertificateValidationTime>k__BackingField");
		NativeFieldInfoPtr__TrustAnchors_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr, "<TrustAnchors>k__BackingField");
		NativeFieldInfoPtr__UserSettings_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr, "<UserSettings>k__BackingField");
		NativeFieldInfoPtr__CertificateSearchPaths_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr, "<CertificateSearchPaths>k__BackingField");
		NativeFieldInfoPtr__SendCloseNotify_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr, "<SendCloseNotify>k__BackingField");
		NativeFieldInfoPtr__ClientCertificateIssuers_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr, "<ClientCertificateIssuers>k__BackingField");
		NativeFieldInfoPtr__DisallowUnauthenticatedCertificateRequest_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr, "<DisallowUnauthenticatedCertificateRequest>k__BackingField");
		NativeFieldInfoPtr__EnabledProtocols_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr, "<EnabledProtocols>k__BackingField");
		NativeFieldInfoPtr__EnabledCiphers_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr, "<EnabledCiphers>k__BackingField");
		NativeFieldInfoPtr_cloned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr, "cloned");
		NativeFieldInfoPtr_checkCertName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr, "checkCertName");
		NativeFieldInfoPtr_checkCertRevocationStatus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr, "checkCertRevocationStatus");
		NativeFieldInfoPtr_useServicePointManagerCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr, "useServicePointManagerCallback");
		NativeFieldInfoPtr_skipSystemValidators = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr, "skipSystemValidators");
		NativeFieldInfoPtr_callbackNeedsChain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr, "callbackNeedsChain");
		NativeFieldInfoPtr_certificateValidator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr, "certificateValidator");
		NativeFieldInfoPtr_defaultSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr, "defaultSettings");
		NativeMethodInfoPtr_get_RemoteCertificateValidationCallback_Public_get_MonoRemoteCertificateValidationCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr, 100663643);
		NativeMethodInfoPtr_set_RemoteCertificateValidationCallback_Public_set_Void_MonoRemoteCertificateValidationCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr, 100663644);
		NativeMethodInfoPtr_get_ClientCertificateSelectionCallback_Public_get_MonoLocalCertificateSelectionCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr, 100663645);
		NativeMethodInfoPtr_set_ClientCertificateSelectionCallback_Public_set_Void_MonoLocalCertificateSelectionCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr, 100663646);
		NativeMethodInfoPtr_get_UseServicePointManagerCallback_Public_get_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr, 100663647);
		NativeMethodInfoPtr_set_UseServicePointManagerCallback_Public_set_Void_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr, 100663648);
		NativeMethodInfoPtr_get_CallbackNeedsCertificateChain_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr, 100663649);
		NativeMethodInfoPtr_get_CertificateValidationTime_Public_get_Nullable_1_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr, 100663650);
		NativeMethodInfoPtr_set_CertificateValidationTime_Public_set_Void_Nullable_1_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr, 100663651);
		NativeMethodInfoPtr_get_TrustAnchors_Public_get_X509CertificateCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr, 100663652);
		NativeMethodInfoPtr_set_TrustAnchors_Public_set_Void_X509CertificateCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr, 100663653);
		NativeMethodInfoPtr_get_UserSettings_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr, 100663654);
		NativeMethodInfoPtr_set_UserSettings_Public_set_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr, 100663655);
		NativeMethodInfoPtr_get_CertificateSearchPaths_Internal_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr, 100663656);
		NativeMethodInfoPtr_set_CertificateSearchPaths_Internal_set_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr, 100663657);
		NativeMethodInfoPtr_get_SendCloseNotify_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr, 100663658);
		NativeMethodInfoPtr_set_SendCloseNotify_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr, 100663659);
		NativeMethodInfoPtr_get_ClientCertificateIssuers_Public_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr, 100663660);
		NativeMethodInfoPtr_set_ClientCertificateIssuers_Public_set_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr, 100663661);
		NativeMethodInfoPtr_get_DisallowUnauthenticatedCertificateRequest_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr, 100663662);
		NativeMethodInfoPtr_set_DisallowUnauthenticatedCertificateRequest_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr, 100663663);
		NativeMethodInfoPtr_get_EnabledProtocols_Public_get_Nullable_1_TlsProtocols_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr, 100663664);
		NativeMethodInfoPtr_set_EnabledProtocols_Public_set_Void_Nullable_1_TlsProtocols_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr, 100663665);
		NativeMethodInfoPtr_get_EnabledCiphers_Public_get_Il2CppStructArray_1_CipherSuiteCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr, 100663666);
		NativeMethodInfoPtr_set_EnabledCiphers_Public_set_Void_Il2CppStructArray_1_CipherSuiteCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr, 100663667);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr, 100663668);
		NativeMethodInfoPtr_get_DefaultSettings_Public_Static_get_MonoTlsSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr, 100663669);
		NativeMethodInfoPtr_CopyDefaultSettings_Public_Static_MonoTlsSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr, 100663670);
		NativeMethodInfoPtr_get_CertificateValidator_Public_get_ICertificateValidator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr, 100663671);
		NativeMethodInfoPtr_CloneWithValidator_Public_MonoTlsSettings_ICertificateValidator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr, 100663672);
		NativeMethodInfoPtr_Clone_Public_MonoTlsSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr, 100663673);
		NativeMethodInfoPtr__ctor_Private_Void_MonoTlsSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr, 100663674);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 693584, XrefRangeEnd = 693585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MonoTlsSettings()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 693604, RefRangeEnd = 693607, XrefRangeStart = 693593, XrefRangeEnd = 693604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static MonoTlsSettings CopyDefaultSettings()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CopyDefaultSettings_Public_Static_MonoTlsSettings_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<MonoTlsSettings>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 693612, RefRangeEnd = 693613, XrefRangeStart = 693607, XrefRangeEnd = 693612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MonoTlsSettings CloneWithValidator(ICertificateValidator validator)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)validator);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CloneWithValidator_Public_MonoTlsSettings_ICertificateValidator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<MonoTlsSettings>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 693617, RefRangeEnd = 693618, XrefRangeStart = 693613, XrefRangeEnd = 693617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MonoTlsSettings Clone()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Clone_Public_MonoTlsSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<MonoTlsSettings>(intPtr2) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 693634, RefRangeEnd = 693637, XrefRangeStart = 693618, XrefRangeEnd = 693634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MonoTlsSettings(MonoTlsSettings other)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoTlsSettings>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)other);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Private_Void_MonoTlsSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public MonoTlsSettings(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
