using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Text;
using UnityEngine.Bindings;

namespace UnityEngine.Networking;

public class UnityWebRequest : Il2CppSystem.Object
{
	[OriginalName("UnityEngine.UnityWebRequestModule.dll", "", "UnityWebRequestMethod")]
	public enum UnityWebRequestMethod
	{
		Get,
		Post,
		Put,
		Head,
		Custom
	}

	[OriginalName("UnityEngine.UnityWebRequestModule.dll", "", "UnityWebRequestError")]
	public enum UnityWebRequestError
	{
		OK,
		OKCached,
		Unknown,
		SDKError,
		UnsupportedProtocol,
		MalformattedUrl,
		CannotResolveProxy,
		CannotResolveHost,
		CannotConnectToHost,
		AccessDenied,
		GenericHttpError,
		WriteError,
		ReadError,
		OutOfMemory,
		Timeout,
		HTTPPostError,
		SSLCannotConnect,
		Aborted,
		TooManyRedirects,
		ReceivedNoData,
		SSLNotSupported,
		FailedToSendData,
		FailedToReceiveData,
		SSLCertificateError,
		SSLCipherNotAvailable,
		SSLCACertError,
		UnrecognizedContentEncoding,
		LoginFailed,
		SSLShutdownFailed,
		RedirectLimitInvalid,
		InvalidRedirect,
		CannotModifyRequest,
		HeaderNameContainsInvalidCharacters,
		HeaderValueContainsInvalidCharacters,
		CannotOverrideSystemHeaders,
		AlreadySent,
		InvalidMethod,
		NotImplemented,
		NoInternetConnection,
		DataProcessingError,
		InsecureConnectionNotAllowed
	}

	[OriginalName("UnityEngine.UnityWebRequestModule.dll", "", "Result")]
	public enum Result
	{
		InProgress,
		Success,
		ConnectionError,
		ProtocolError,
		DataProcessingError
	}

	public static class BindingsMarshaller : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeMethodInfoPtr_ConvertToNative_Public_Static_IntPtr_UnityWebRequest_0;

		static BindingsMarshaller()
		{
			Il2CppClassPointerStore<BindingsMarshaller>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, "BindingsMarshaller");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BindingsMarshaller>.NativeClassPtr);
			NativeMethodInfoPtr_ConvertToNative_Public_Static_IntPtr_UnityWebRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingsMarshaller>.NativeClassPtr, 100663406);
		}

		[CallerCount(0)]
		public unsafe static System.IntPtr ConvertToNative(UnityWebRequest unityWebRequest)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)unityWebRequest);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConvertToNative_Public_Static_IntPtr_UnityWebRequest_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		public BindingsMarshaller(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private delegate void GetHTTPStatusString_InjectedDelegate(long responseCode, [Out] System.IntPtr ret);

	private delegate void ClearCookieCache_InjectedDelegate(System.IntPtr domain, System.IntPtr path);

	private delegate UnityWebRequestMethod GetMethod_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void GetCustomMethod_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr ret);

	private delegate UnityWebRequestError GetError_InjectedDelegate(System.IntPtr _unity_self);

	private delegate bool get_use100Continue_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_use100Continue_InjectedDelegate(System.IntPtr _unity_self, bool value);

	private delegate void GetUrl_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr ret);

	private delegate float GetUploadProgress_InjectedDelegate(System.IntPtr _unity_self);

	private delegate bool IsExecuting_InjectedDelegate(System.IntPtr _unity_self);

	private delegate float GetDownloadProgress_InjectedDelegate(System.IntPtr _unity_self);

	private delegate ulong get_uploadedBytes_InjectedDelegate(System.IntPtr _unity_self);

	private delegate int GetRedirectLimit_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void SetRedirectLimitFromScripting_InjectedDelegate(System.IntPtr _unity_self, int limit);

	private delegate bool GetChunked_InjectedDelegate(System.IntPtr _unity_self);

	private delegate UnityWebRequestError SetChunked_InjectedDelegate(System.IntPtr _unity_self, bool chunked);

	private delegate void GetRequestHeader_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr name, [Out] System.IntPtr ret);

	private delegate System.IntPtr GetResponseHeaderKeys_InjectedDelegate(System.IntPtr _unity_self);

	private delegate UnityWebRequestError SetCertificateHandler_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr ch);

	private delegate int GetTimeoutMsec_InjectedDelegate(System.IntPtr _unity_self);

	private delegate UnityWebRequestError SetTimeoutMsec_InjectedDelegate(System.IntPtr _unity_self, int timeout);

	private delegate bool GetSuppressErrorsToConsole_InjectedDelegate(System.IntPtr _unity_self);

	private delegate UnityWebRequestError SetSuppressErrorsToConsole_InjectedDelegate(System.IntPtr _unity_self, bool suppress);

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Ptr;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_DownloadHandler;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_UploadHandler;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CertificateHandler;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Uri;

	private static readonly System.IntPtr NativeFieldInfoPtr__disposeCertificateHandlerOnDispose_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__disposeDownloadHandlerOnDispose_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__disposeUploadHandlerOnDispose_k__BackingField;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetWebErrorString_Private_Static_String_UnityWebRequestError_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_disposeCertificateHandlerOnDispose_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_disposeCertificateHandlerOnDispose_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_disposeDownloadHandlerOnDispose_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_disposeDownloadHandlerOnDispose_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_disposeUploadHandlerOnDispose_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_disposeUploadHandlerOnDispose_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Create_Internal_Static_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Release_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalDestroy_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalSetDefaults_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_DownloadHandler_UploadHandler_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DisposeHandlers_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BeginWebRequest_Internal_UnityWebRequestAsyncOperation_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SendWebRequest_Public_UnityWebRequestAsyncOperation_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Abort_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetMethod_Private_UnityWebRequestError_UnityWebRequestMethod_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalSetMethod_Internal_Void_UnityWebRequestMethod_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetCustomMethod_Private_UnityWebRequestError_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalSetCustomMethod_Internal_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_method_Public_set_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_url_Public_set_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetUrl_Private_UnityWebRequestError_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalSetUrl_Private_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_responseCode_Public_get_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isModifiable_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isDone_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_result_Public_get_Result_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_downloadedBytes_Public_get_UInt64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalSetRequestHeader_Internal_UnityWebRequestError_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetRequestHeader_Public_Void_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetResponseHeader_Public_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetUploadHandler_Private_UnityWebRequestError_UploadHandler_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_uploadHandler_Public_get_UploadHandler_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_uploadHandler_Public_set_Void_UploadHandler_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetDownloadHandler_Private_UnityWebRequestError_DownloadHandler_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_downloadHandler_Public_get_DownloadHandler_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_downloadHandler_Public_set_Void_DownloadHandler_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_certificateHandler_Public_get_CertificateHandler_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Get_Public_Static_UnityWebRequest_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetWebErrorString_Injected_Private_Static_Void_UnityWebRequestError_byref_ManagedSpanWrapper_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Release_Injected_Private_Static_Void_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BeginWebRequest_Injected_Private_Static_IntPtr_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Abort_Injected_Private_Static_Void_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetMethod_Injected_Private_Static_UnityWebRequestError_IntPtr_UnityWebRequestMethod_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetCustomMethod_Injected_Private_Static_UnityWebRequestError_IntPtr_byref_ManagedSpanWrapper_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetUrl_Injected_Private_Static_UnityWebRequestError_IntPtr_byref_ManagedSpanWrapper_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_responseCode_Injected_Private_Static_Int64_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isModifiable_Injected_Private_Static_Boolean_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_result_Injected_Private_Static_Result_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_downloadedBytes_Injected_Private_Static_UInt64_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalSetRequestHeader_Injected_Private_Static_UnityWebRequestError_IntPtr_byref_ManagedSpanWrapper_byref_ManagedSpanWrapper_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetResponseHeader_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_byref_ManagedSpanWrapper_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetUploadHandler_Injected_Private_Static_UnityWebRequestError_IntPtr_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetDownloadHandler_Injected_Private_Static_UnityWebRequestError_IntPtr_IntPtr_0;

	public const string kHttpVerbGET = "GET";

	public const string kHttpVerbHEAD = "HEAD";

	public const string kHttpVerbPOST = "POST";

	public const string kHttpVerbPUT = "PUT";

	public const string kHttpVerbCREATE = "CREATE";

	public const string kHttpVerbDELETE = "DELETE";

	private static readonly GetHTTPStatusString_InjectedDelegate GetHTTPStatusString_InjectedDelegateField;

	private static readonly ClearCookieCache_InjectedDelegate ClearCookieCache_InjectedDelegateField;

	private static readonly GetMethod_InjectedDelegate GetMethod_InjectedDelegateField;

	private static readonly GetCustomMethod_InjectedDelegate GetCustomMethod_InjectedDelegateField;

	private static readonly GetError_InjectedDelegate GetError_InjectedDelegateField;

	private static readonly get_use100Continue_InjectedDelegate get_use100Continue_InjectedDelegateField;

	private static readonly set_use100Continue_InjectedDelegate set_use100Continue_InjectedDelegateField;

	private static readonly GetUrl_InjectedDelegate GetUrl_InjectedDelegateField;

	private static readonly GetUploadProgress_InjectedDelegate GetUploadProgress_InjectedDelegateField;

	private static readonly IsExecuting_InjectedDelegate IsExecuting_InjectedDelegateField;

	private static readonly GetDownloadProgress_InjectedDelegate GetDownloadProgress_InjectedDelegateField;

	private static readonly get_uploadedBytes_InjectedDelegate get_uploadedBytes_InjectedDelegateField;

	private static readonly GetRedirectLimit_InjectedDelegate GetRedirectLimit_InjectedDelegateField;

	private static readonly SetRedirectLimitFromScripting_InjectedDelegate SetRedirectLimitFromScripting_InjectedDelegateField;

	private static readonly GetChunked_InjectedDelegate GetChunked_InjectedDelegateField;

	private static readonly SetChunked_InjectedDelegate SetChunked_InjectedDelegateField;

	private static readonly GetRequestHeader_InjectedDelegate GetRequestHeader_InjectedDelegateField;

	private static readonly GetResponseHeaderKeys_InjectedDelegate GetResponseHeaderKeys_InjectedDelegateField;

	private static readonly SetCertificateHandler_InjectedDelegate SetCertificateHandler_InjectedDelegateField;

	private static readonly GetTimeoutMsec_InjectedDelegate GetTimeoutMsec_InjectedDelegateField;

	private static readonly SetTimeoutMsec_InjectedDelegate SetTimeoutMsec_InjectedDelegateField;

	private static readonly GetSuppressErrorsToConsole_InjectedDelegate GetSuppressErrorsToConsole_InjectedDelegateField;

	private static readonly SetSuppressErrorsToConsole_InjectedDelegate SetSuppressErrorsToConsole_InjectedDelegateField;

	public unsafe System.IntPtr m_Ptr
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Ptr);
			return *(System.IntPtr*)num;
		}
		set
		{
			*(System.IntPtr*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Ptr)) = value;
		}
	}

	public unsafe DownloadHandler m_DownloadHandler
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DownloadHandler);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DownloadHandler>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DownloadHandler)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe UploadHandler m_UploadHandler
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_UploadHandler);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<UploadHandler>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_UploadHandler)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe CertificateHandler m_CertificateHandler
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CertificateHandler);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CertificateHandler>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CertificateHandler)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppSystem.Uri m_Uri
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Uri);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Uri>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Uri)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe bool _disposeCertificateHandlerOnDispose_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__disposeCertificateHandlerOnDispose_k__BackingField);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__disposeCertificateHandlerOnDispose_k__BackingField)) = value;
		}
	}

	public unsafe bool _disposeDownloadHandlerOnDispose_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__disposeDownloadHandlerOnDispose_k__BackingField);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__disposeDownloadHandlerOnDispose_k__BackingField)) = value;
		}
	}

	public unsafe bool _disposeUploadHandlerOnDispose_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__disposeUploadHandlerOnDispose_k__BackingField);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__disposeUploadHandlerOnDispose_k__BackingField)) = value;
		}
	}

	public unsafe bool disposeCertificateHandlerOnDispose
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_disposeCertificateHandlerOnDispose_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
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
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_disposeCertificateHandlerOnDispose_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool disposeDownloadHandlerOnDispose
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_disposeDownloadHandlerOnDispose_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
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
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_disposeDownloadHandlerOnDispose_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool disposeUploadHandlerOnDispose
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_disposeUploadHandlerOnDispose_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
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
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_disposeUploadHandlerOnDispose_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe string method
	{
		get
		{
			return GetMethod() switch
			{
				UnityWebRequestMethod.Get => "GET", 
				UnityWebRequestMethod.Post => "POST", 
				UnityWebRequestMethod.Put => "PUT", 
				UnityWebRequestMethod.Head => "HEAD", 
				_ => GetCustomMethod(), 
			};
		}
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1408499, RefRangeEnd = 1408501, XrefRangeStart = 1408490, XrefRangeEnd = 1408499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_method_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe string url
	{
		get
		{
			return GetUrl();
		}
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1408511, RefRangeEnd = 1408513, XrefRangeStart = 1408501, XrefRangeEnd = 1408511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_url_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe long responseCode
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1408538, RefRangeEnd = 1408539, XrefRangeStart = 1408534, XrefRangeEnd = 1408538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_responseCode_Public_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(long*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool isModifiable
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1408539, XrefRangeEnd = 1408543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isModifiable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool isDone
	{
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 1408546, RefRangeEnd = 1408556, XrefRangeStart = 1408543, XrefRangeEnd = 1408546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isDone_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe Result result
	{
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 1408560, RefRangeEnd = 1408569, XrefRangeStart = 1408556, XrefRangeEnd = 1408560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_result_Public_get_Result_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Result*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe ulong downloadedBytes
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1408573, RefRangeEnd = 1408574, XrefRangeStart = 1408569, XrefRangeEnd = 1408573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_downloadedBytes_Public_get_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(ulong*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe UploadHandler uploadHandler
	{
		[CallerCount(72)]
		[CachedScanResults(RefRangeStart = 1153270, RefRangeEnd = 1153342, XrefRangeStart = 1153270, XrefRangeEnd = 1153342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_uploadHandler_Public_get_UploadHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<UploadHandler>(intPtr2) : null;
		}
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1408657, RefRangeEnd = 1408660, XrefRangeStart = 1408637, XrefRangeEnd = 1408657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_uploadHandler_Public_set_Void_UploadHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe DownloadHandler downloadHandler
	{
		[CallerCount(34)]
		[CachedScanResults(RefRangeStart = 1153348, RefRangeEnd = 1153382, XrefRangeStart = 1153348, XrefRangeEnd = 1153382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_downloadHandler_Public_get_DownloadHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<DownloadHandler>(intPtr2) : null;
		}
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1408684, RefRangeEnd = 1408687, XrefRangeStart = 1408664, XrefRangeEnd = 1408684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_downloadHandler_Public_set_Void_DownloadHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe CertificateHandler certificateHandler
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_certificateHandler_Public_get_CertificateHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<CertificateHandler>(intPtr2) : null;
		}
		set
		{
			if (!isModifiable)
			{
				throw new Il2CppSystem.InvalidOperationException("UnityWebRequest has already been sent; cannot modify the certificate handler");
			}
			UnityWebRequestError unityWebRequestError = SetCertificateHandler(value);
			if (unityWebRequestError != 0)
			{
				throw new Il2CppSystem.InvalidOperationException(GetWebErrorString(unityWebRequestError));
			}
			m_CertificateHandler = value;
		}
	}

	public string error
	{
		get
		{
			switch (result)
			{
			case Result.InProgress:
			case Result.Success:
				return null;
			case Result.ProtocolError:
				return Il2CppSystem.String.Format("HTTP/1.1 {0} {1}", (Il2CppSystem.Object)(object)responseCode, GetHTTPStatusString(responseCode));
			default:
				return GetWebErrorString(GetError());
			}
		}
	}

	public bool use100Continue
	{
		get
		{
			System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_use100Continue_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_use100Continue_Injected(intPtr, value);
		}
	}

	public bool useHttpContinue
	{
		get
		{
			return use100Continue;
		}
		set
		{
			if (!isModifiable)
			{
				throw new Il2CppSystem.InvalidOperationException("UnityWebRequest has already been sent and its 100-Continue setting cannot be altered");
			}
			use100Continue = value;
		}
	}

	public float uploadProgress
	{
		get
		{
			if (!IsExecuting() && !isDone)
			{
				return -1f;
			}
			return GetUploadProgress();
		}
	}

	public bool isNetworkError => result == Result.ConnectionError;

	public bool isHttpError => result == Result.ProtocolError;

	public float downloadProgress
	{
		get
		{
			if (!IsExecuting() && !isDone)
			{
				return -1f;
			}
			return GetDownloadProgress();
		}
	}

	public ulong uploadedBytes
	{
		get
		{
			System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_uploadedBytes_Injected(intPtr);
		}
	}

	public int redirectLimit
	{
		get
		{
			return GetRedirectLimit();
		}
		set
		{
			SetRedirectLimitFromScripting(value);
		}
	}

	public bool chunkedTransfer
	{
		get
		{
			return GetChunked();
		}
		set
		{
			if (!isModifiable)
			{
				throw new Il2CppSystem.InvalidOperationException("UnityWebRequest has already been sent and its chunked transfer encoding setting cannot be altered");
			}
			UnityWebRequestError unityWebRequestError = SetChunked(value);
			if (unityWebRequestError != 0)
			{
				throw new Il2CppSystem.InvalidOperationException(GetWebErrorString(unityWebRequestError));
			}
		}
	}

	public int timeout
	{
		get
		{
			return GetTimeoutMsec() / 1000;
		}
		set
		{
			if (!isModifiable)
			{
				throw new Il2CppSystem.InvalidOperationException("UnityWebRequest has already been sent; cannot modify the timeout");
			}
			value = Il2CppSystem.Math.Max(value, 0);
			UnityWebRequestError unityWebRequestError = SetTimeoutMsec(value * 1000);
			if (unityWebRequestError != 0)
			{
				throw new Il2CppSystem.InvalidOperationException(GetWebErrorString(unityWebRequestError));
			}
		}
	}

	public bool suppressErrorsToConsole
	{
		get
		{
			return GetSuppressErrorsToConsole();
		}
		set
		{
			if (!isModifiable)
			{
				throw new Il2CppSystem.InvalidOperationException("UnityWebRequest has already been sent; cannot modify the timeout");
			}
			UnityWebRequestError unityWebRequestError = SetSuppressErrorsToConsole(value);
			if (unityWebRequestError != 0)
			{
				throw new Il2CppSystem.InvalidOperationException(GetWebErrorString(unityWebRequestError));
			}
		}
	}

	static UnityWebRequest()
	{
		Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UnityWebRequestModule.dll", "UnityEngine.Networking", "UnityWebRequest");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr);
		NativeFieldInfoPtr_m_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, "m_Ptr");
		NativeFieldInfoPtr_m_DownloadHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, "m_DownloadHandler");
		NativeFieldInfoPtr_m_UploadHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, "m_UploadHandler");
		NativeFieldInfoPtr_m_CertificateHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, "m_CertificateHandler");
		NativeFieldInfoPtr_m_Uri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, "m_Uri");
		NativeFieldInfoPtr__disposeCertificateHandlerOnDispose_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, "<disposeCertificateHandlerOnDispose>k__BackingField");
		NativeFieldInfoPtr__disposeDownloadHandlerOnDispose_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, "<disposeDownloadHandlerOnDispose>k__BackingField");
		NativeFieldInfoPtr__disposeUploadHandlerOnDispose_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, "<disposeUploadHandlerOnDispose>k__BackingField");
		NativeMethodInfoPtr_GetWebErrorString_Private_Static_String_UnityWebRequestError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663348);
		NativeMethodInfoPtr_get_disposeCertificateHandlerOnDispose_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663349);
		NativeMethodInfoPtr_set_disposeCertificateHandlerOnDispose_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663350);
		NativeMethodInfoPtr_get_disposeDownloadHandlerOnDispose_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663351);
		NativeMethodInfoPtr_set_disposeDownloadHandlerOnDispose_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663352);
		NativeMethodInfoPtr_get_disposeUploadHandlerOnDispose_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663353);
		NativeMethodInfoPtr_set_disposeUploadHandlerOnDispose_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663354);
		NativeMethodInfoPtr_Create_Internal_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663355);
		NativeMethodInfoPtr_Release_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663356);
		NativeMethodInfoPtr_InternalDestroy_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663357);
		NativeMethodInfoPtr_InternalSetDefaults_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663358);
		NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663359);
		NativeMethodInfoPtr__ctor_Public_Void_String_String_DownloadHandler_UploadHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663360);
		NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663361);
		NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663362);
		NativeMethodInfoPtr_DisposeHandlers_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663363);
		NativeMethodInfoPtr_BeginWebRequest_Internal_UnityWebRequestAsyncOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663364);
		NativeMethodInfoPtr_SendWebRequest_Public_UnityWebRequestAsyncOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663365);
		NativeMethodInfoPtr_Abort_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663366);
		NativeMethodInfoPtr_SetMethod_Private_UnityWebRequestError_UnityWebRequestMethod_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663367);
		NativeMethodInfoPtr_InternalSetMethod_Internal_Void_UnityWebRequestMethod_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663368);
		NativeMethodInfoPtr_SetCustomMethod_Private_UnityWebRequestError_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663369);
		NativeMethodInfoPtr_InternalSetCustomMethod_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663370);
		NativeMethodInfoPtr_set_method_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663371);
		NativeMethodInfoPtr_set_url_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663372);
		NativeMethodInfoPtr_SetUrl_Private_UnityWebRequestError_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663373);
		NativeMethodInfoPtr_InternalSetUrl_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663374);
		NativeMethodInfoPtr_get_responseCode_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663375);
		NativeMethodInfoPtr_get_isModifiable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663376);
		NativeMethodInfoPtr_get_isDone_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663377);
		NativeMethodInfoPtr_get_result_Public_get_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663378);
		NativeMethodInfoPtr_get_downloadedBytes_Public_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663379);
		NativeMethodInfoPtr_InternalSetRequestHeader_Internal_UnityWebRequestError_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663380);
		NativeMethodInfoPtr_SetRequestHeader_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663381);
		NativeMethodInfoPtr_GetResponseHeader_Public_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663382);
		NativeMethodInfoPtr_SetUploadHandler_Private_UnityWebRequestError_UploadHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663383);
		NativeMethodInfoPtr_get_uploadHandler_Public_get_UploadHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663384);
		NativeMethodInfoPtr_set_uploadHandler_Public_set_Void_UploadHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663385);
		NativeMethodInfoPtr_SetDownloadHandler_Private_UnityWebRequestError_DownloadHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663386);
		NativeMethodInfoPtr_get_downloadHandler_Public_get_DownloadHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663387);
		NativeMethodInfoPtr_set_downloadHandler_Public_set_Void_DownloadHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663388);
		NativeMethodInfoPtr_get_certificateHandler_Public_get_CertificateHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663389);
		NativeMethodInfoPtr_Get_Public_Static_UnityWebRequest_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663390);
		NativeMethodInfoPtr_GetWebErrorString_Injected_Private_Static_Void_UnityWebRequestError_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663391);
		NativeMethodInfoPtr_Release_Injected_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663392);
		NativeMethodInfoPtr_BeginWebRequest_Injected_Private_Static_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663393);
		NativeMethodInfoPtr_Abort_Injected_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663394);
		NativeMethodInfoPtr_SetMethod_Injected_Private_Static_UnityWebRequestError_IntPtr_UnityWebRequestMethod_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663395);
		NativeMethodInfoPtr_SetCustomMethod_Injected_Private_Static_UnityWebRequestError_IntPtr_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663396);
		NativeMethodInfoPtr_SetUrl_Injected_Private_Static_UnityWebRequestError_IntPtr_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663397);
		NativeMethodInfoPtr_get_responseCode_Injected_Private_Static_Int64_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663398);
		NativeMethodInfoPtr_get_isModifiable_Injected_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663399);
		NativeMethodInfoPtr_get_result_Injected_Private_Static_Result_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663400);
		NativeMethodInfoPtr_get_downloadedBytes_Injected_Private_Static_UInt64_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663401);
		NativeMethodInfoPtr_InternalSetRequestHeader_Injected_Private_Static_UnityWebRequestError_IntPtr_byref_ManagedSpanWrapper_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663402);
		NativeMethodInfoPtr_GetResponseHeader_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663403);
		NativeMethodInfoPtr_SetUploadHandler_Injected_Private_Static_UnityWebRequestError_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663404);
		NativeMethodInfoPtr_SetDownloadHandler_Injected_Private_Static_UnityWebRequestError_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr, 100663405);
		GetHTTPStatusString_InjectedDelegateField = IL2CPP.ResolveICall<GetHTTPStatusString_InjectedDelegate>("UnityEngine.Networking.UnityWebRequest::GetHTTPStatusString_Injected");
		ClearCookieCache_InjectedDelegateField = IL2CPP.ResolveICall<ClearCookieCache_InjectedDelegate>("UnityEngine.Networking.UnityWebRequest::ClearCookieCache_Injected");
		GetMethod_InjectedDelegateField = IL2CPP.ResolveICall<GetMethod_InjectedDelegate>("UnityEngine.Networking.UnityWebRequest::GetMethod_Injected");
		GetCustomMethod_InjectedDelegateField = IL2CPP.ResolveICall<GetCustomMethod_InjectedDelegate>("UnityEngine.Networking.UnityWebRequest::GetCustomMethod_Injected");
		GetError_InjectedDelegateField = IL2CPP.ResolveICall<GetError_InjectedDelegate>("UnityEngine.Networking.UnityWebRequest::GetError_Injected");
		get_use100Continue_InjectedDelegateField = IL2CPP.ResolveICall<get_use100Continue_InjectedDelegate>("UnityEngine.Networking.UnityWebRequest::get_use100Continue_Injected");
		set_use100Continue_InjectedDelegateField = IL2CPP.ResolveICall<set_use100Continue_InjectedDelegate>("UnityEngine.Networking.UnityWebRequest::set_use100Continue_Injected");
		GetUrl_InjectedDelegateField = IL2CPP.ResolveICall<GetUrl_InjectedDelegate>("UnityEngine.Networking.UnityWebRequest::GetUrl_Injected");
		GetUploadProgress_InjectedDelegateField = IL2CPP.ResolveICall<GetUploadProgress_InjectedDelegate>("UnityEngine.Networking.UnityWebRequest::GetUploadProgress_Injected");
		IsExecuting_InjectedDelegateField = IL2CPP.ResolveICall<IsExecuting_InjectedDelegate>("UnityEngine.Networking.UnityWebRequest::IsExecuting_Injected");
		GetDownloadProgress_InjectedDelegateField = IL2CPP.ResolveICall<GetDownloadProgress_InjectedDelegate>("UnityEngine.Networking.UnityWebRequest::GetDownloadProgress_Injected");
		get_uploadedBytes_InjectedDelegateField = IL2CPP.ResolveICall<get_uploadedBytes_InjectedDelegate>("UnityEngine.Networking.UnityWebRequest::get_uploadedBytes_Injected");
		GetRedirectLimit_InjectedDelegateField = IL2CPP.ResolveICall<GetRedirectLimit_InjectedDelegate>("UnityEngine.Networking.UnityWebRequest::GetRedirectLimit_Injected");
		SetRedirectLimitFromScripting_InjectedDelegateField = IL2CPP.ResolveICall<SetRedirectLimitFromScripting_InjectedDelegate>("UnityEngine.Networking.UnityWebRequest::SetRedirectLimitFromScripting_Injected");
		GetChunked_InjectedDelegateField = IL2CPP.ResolveICall<GetChunked_InjectedDelegate>("UnityEngine.Networking.UnityWebRequest::GetChunked_Injected");
		SetChunked_InjectedDelegateField = IL2CPP.ResolveICall<SetChunked_InjectedDelegate>("UnityEngine.Networking.UnityWebRequest::SetChunked_Injected");
		GetRequestHeader_InjectedDelegateField = IL2CPP.ResolveICall<GetRequestHeader_InjectedDelegate>("UnityEngine.Networking.UnityWebRequest::GetRequestHeader_Injected");
		GetResponseHeaderKeys_InjectedDelegateField = IL2CPP.ResolveICall<GetResponseHeaderKeys_InjectedDelegate>("UnityEngine.Networking.UnityWebRequest::GetResponseHeaderKeys_Injected");
		SetCertificateHandler_InjectedDelegateField = IL2CPP.ResolveICall<SetCertificateHandler_InjectedDelegate>("UnityEngine.Networking.UnityWebRequest::SetCertificateHandler_Injected");
		GetTimeoutMsec_InjectedDelegateField = IL2CPP.ResolveICall<GetTimeoutMsec_InjectedDelegate>("UnityEngine.Networking.UnityWebRequest::GetTimeoutMsec_Injected");
		SetTimeoutMsec_InjectedDelegateField = IL2CPP.ResolveICall<SetTimeoutMsec_InjectedDelegate>("UnityEngine.Networking.UnityWebRequest::SetTimeoutMsec_Injected");
		GetSuppressErrorsToConsole_InjectedDelegateField = IL2CPP.ResolveICall<GetSuppressErrorsToConsole_InjectedDelegate>("UnityEngine.Networking.UnityWebRequest::GetSuppressErrorsToConsole_Injected");
		SetSuppressErrorsToConsole_InjectedDelegateField = IL2CPP.ResolveICall<SetSuppressErrorsToConsole_InjectedDelegate>("UnityEngine.Networking.UnityWebRequest::SetSuppressErrorsToConsole_Injected");
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1408343, RefRangeEnd = 1408347, XrefRangeStart = 1408338, XrefRangeEnd = 1408343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetWebErrorString(UnityWebRequestError err)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&err);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetWebErrorString_Private_Static_String_UnityWebRequestError_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1408347, XrefRangeEnd = 1408349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr Create()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Create_Internal_Static_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1408349, XrefRangeEnd = 1408353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Release()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Release_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1408358, RefRangeEnd = 1408360, XrefRangeStart = 1408353, XrefRangeEnd = 1408358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InternalDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalDestroy_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe void InternalSetDefaults()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalSetDefaults_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1408365, RefRangeEnd = 1408368, XrefRangeStart = 1408360, XrefRangeEnd = 1408365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UnityWebRequest(string url, string method)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(url);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(method);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1408411, RefRangeEnd = 1408412, XrefRangeStart = 1408368, XrefRangeEnd = 1408411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UnityWebRequest(string url, string method, DownloadHandler downloadHandler, UploadHandler uploadHandler)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityWebRequest>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(url);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(method);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)downloadHandler);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)uploadHandler);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_String_DownloadHandler_UploadHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1408412, XrefRangeEnd = 1408417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void Finalize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1408417, XrefRangeEnd = 1408423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Dispose()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1408425, RefRangeEnd = 1408427, XrefRangeStart = 1408423, XrefRangeEnd = 1408425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DisposeHandlers()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DisposeHandlers_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1408427, XrefRangeEnd = 1408434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UnityWebRequestAsyncOperation BeginWebRequest()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BeginWebRequest_Internal_UnityWebRequestAsyncOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<UnityWebRequestAsyncOperation>(intPtr2) : null;
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1408442, RefRangeEnd = 1408447, XrefRangeStart = 1408434, XrefRangeEnd = 1408442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UnityWebRequestAsyncOperation SendWebRequest()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SendWebRequest_Public_UnityWebRequestAsyncOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<UnityWebRequestAsyncOperation>(intPtr2) : null;
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 1408451, RefRangeEnd = 1408459, XrefRangeStart = 1408447, XrefRangeEnd = 1408451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Abort()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Abort_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1408459, XrefRangeEnd = 1408463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UnityWebRequestError SetMethod(UnityWebRequestMethod methodType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&methodType);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetMethod_Private_UnityWebRequestError_UnityWebRequestMethod_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(UnityWebRequestError*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1408469, RefRangeEnd = 1408470, XrefRangeStart = 1408463, XrefRangeEnd = 1408469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InternalSetMethod(UnityWebRequestMethod methodType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&methodType);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalSetMethod_Internal_Void_UnityWebRequestMethod_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1408485, RefRangeEnd = 1408486, XrefRangeStart = 1408470, XrefRangeEnd = 1408485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UnityWebRequestError SetCustomMethod(string customMethodName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(customMethodName);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetCustomMethod_Private_UnityWebRequestError_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(UnityWebRequestError*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1408486, XrefRangeEnd = 1408490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InternalSetCustomMethod(string customMethodName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(customMethodName);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalSetCustomMethod_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1408528, RefRangeEnd = 1408530, XrefRangeStart = 1408513, XrefRangeEnd = 1408528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UnityWebRequestError SetUrl(string url)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(url);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetUrl_Private_UnityWebRequestError_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(UnityWebRequestError*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1408530, XrefRangeEnd = 1408534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InternalSetUrl(string url)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(url);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalSetUrl_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1408598, RefRangeEnd = 1408599, XrefRangeStart = 1408574, XrefRangeEnd = 1408598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UnityWebRequestError InternalSetRequestHeader(string name, string value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalSetRequestHeader_Internal_UnityWebRequestError_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(UnityWebRequestError*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(11)]
	[CachedScanResults(RefRangeStart = 1408604, RefRangeEnd = 1408615, XrefRangeStart = 1408599, XrefRangeEnd = 1408604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetRequestHeader(string name, string value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetRequestHeader_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1408632, RefRangeEnd = 1408633, XrefRangeStart = 1408615, XrefRangeEnd = 1408632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetResponseHeader(string name)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetResponseHeader_Public_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1408633, XrefRangeEnd = 1408637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UnityWebRequestError SetUploadHandler(UploadHandler uh)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)uh);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetUploadHandler_Private_UnityWebRequestError_UploadHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(UnityWebRequestError*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1408660, XrefRangeEnd = 1408664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UnityWebRequestError SetDownloadHandler(DownloadHandler dh)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dh);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetDownloadHandler_Private_UnityWebRequestError_DownloadHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(UnityWebRequestError*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1408699, RefRangeEnd = 1408701, XrefRangeStart = 1408687, XrefRangeEnd = 1408699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static UnityWebRequest Get(string uri)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(uri);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Get_Public_Static_UnityWebRequest_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<UnityWebRequest>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1408701, XrefRangeEnd = 1408703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetWebErrorString_Injected(UnityWebRequestError err, out ManagedSpanWrapper ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&err);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetWebErrorString_Injected_Private_Static_Void_UnityWebRequestError_byref_ManagedSpanWrapper_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1408703, XrefRangeEnd = 1408705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Release_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Release_Injected_Private_Static_Void_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1408705, XrefRangeEnd = 1408707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr BeginWebRequest_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BeginWebRequest_Injected_Private_Static_IntPtr_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1408707, XrefRangeEnd = 1408709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Abort_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Abort_Injected_Private_Static_Void_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1408709, XrefRangeEnd = 1408711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static UnityWebRequestError SetMethod_Injected(System.IntPtr _unity_self, UnityWebRequestMethod methodType)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(UnityWebRequestMethod**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &methodType;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetMethod_Injected_Private_Static_UnityWebRequestError_IntPtr_UnityWebRequestMethod_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(UnityWebRequestError*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1408711, XrefRangeEnd = 1408713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static UnityWebRequestError SetCustomMethod_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper customMethodName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref customMethodName);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetCustomMethod_Injected_Private_Static_UnityWebRequestError_IntPtr_byref_ManagedSpanWrapper_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(UnityWebRequestError*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1408713, XrefRangeEnd = 1408715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static UnityWebRequestError SetUrl_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper url)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref url);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetUrl_Injected_Private_Static_UnityWebRequestError_IntPtr_byref_ManagedSpanWrapper_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(UnityWebRequestError*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1408715, XrefRangeEnd = 1408717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static long get_responseCode_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_responseCode_Injected_Private_Static_Int64_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(long*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1408717, XrefRangeEnd = 1408719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool get_isModifiable_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isModifiable_Injected_Private_Static_Boolean_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1408719, XrefRangeEnd = 1408721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Result get_result_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_result_Injected_Private_Static_Result_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Result*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1408721, XrefRangeEnd = 1408723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ulong get_downloadedBytes_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_downloadedBytes_Injected_Private_Static_UInt64_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(ulong*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1408723, XrefRangeEnd = 1408725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static UnityWebRequestError InternalSetRequestHeader_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper name, ref ManagedSpanWrapper value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref name);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalSetRequestHeader_Injected_Private_Static_UnityWebRequestError_IntPtr_byref_ManagedSpanWrapper_byref_ManagedSpanWrapper_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(UnityWebRequestError*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1408725, XrefRangeEnd = 1408727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetResponseHeader_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper name, out ManagedSpanWrapper ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref name);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetResponseHeader_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_byref_ManagedSpanWrapper_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1408727, XrefRangeEnd = 1408729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static UnityWebRequestError SetUploadHandler_Injected(System.IntPtr _unity_self, System.IntPtr uh)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &uh;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetUploadHandler_Injected_Private_Static_UnityWebRequestError_IntPtr_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(UnityWebRequestError*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1408729, XrefRangeEnd = 1408731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static UnityWebRequestError SetDownloadHandler_Injected(System.IntPtr _unity_self, System.IntPtr dh)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &dh;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetDownloadHandler_Injected_Private_Static_UnityWebRequestError_IntPtr_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(UnityWebRequestError*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public UnityWebRequest(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public static string GetHTTPStatusString(long responseCode)
	{
		Unsafe.SkipInit(out ManagedSpanWrapper ret);
		string stringAndDispose;
		try
		{
			GetHTTPStatusString_Injected(responseCode, out ret);
		}
		finally
		{
			stringAndDispose = OutStringMarshaller.GetStringAndDispose(ret);
		}
		return stringAndDispose;
	}

	public static void ClearCookieCache()
	{
		ClearCookieCache(null, null);
	}

	public unsafe static void ClearCookieCache(string domain, string path)
	{
		//IL_0018: Expected O, but got Ref
		//IL_0024: Expected O, but got Ref
		//IL_0044: Expected O, but got Ref
		//IL_0052: Expected O, but got Ref
		//The blocks IL_0029, IL_0036, IL_0044, IL_0052, IL_0057 are reachable both inside and outside the pinned region starting at IL_0018. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		//The blocks IL_0057 are reachable both inside and outside the pinned region starting at IL_0044. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		//The blocks IL_0057 are reachable both inside and outside the pinned region starting at IL_0044. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			ref ManagedSpanWrapper domain2;
			Il2CppSystem.ReadOnlySpan<char> readOnlySpan2;
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper2);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(domain, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(domain);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					domain2 = ref managedSpanWrapper;
					if (!StringMarshaller.TryMarshalEmptyOrNullString(path, ref managedSpanWrapper2))
					{
						readOnlySpan2 = Il2CppSystem.MemoryExtensions.AsSpan(path);
						fixed (char* begin2 = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan2)).GetPinnableReference())
						{
							managedSpanWrapper2 = new ManagedSpanWrapper(begin2, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan2)).Length);
							ClearCookieCache_Injected(ref domain2, ref managedSpanWrapper2);
							return;
						}
					}
					ClearCookieCache_Injected(ref domain2, ref managedSpanWrapper2);
					return;
				}
			}
			domain2 = ref managedSpanWrapper;
			if (!StringMarshaller.TryMarshalEmptyOrNullString(path, ref managedSpanWrapper2))
			{
				readOnlySpan2 = Il2CppSystem.MemoryExtensions.AsSpan(path);
				fixed (char* begin2 = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan2)).GetPinnableReference())
				{
					managedSpanWrapper2 = new ManagedSpanWrapper(begin2, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan2)).Length);
					ClearCookieCache_Injected(ref domain2, ref managedSpanWrapper2);
					return;
				}
			}
			ClearCookieCache_Injected(ref domain2, ref managedSpanWrapper2);
		}
		finally
		{
		}
	}

	public AsyncOperation Send()
	{
		return SendWebRequest();
	}

	public UnityWebRequestMethod GetMethod()
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return GetMethod_Injected(intPtr);
	}

	public string GetCustomMethod()
	{
		Unsafe.SkipInit(out ManagedSpanWrapper ret);
		string stringAndDispose;
		try
		{
			System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			GetCustomMethod_Injected(intPtr, out ret);
		}
		finally
		{
			stringAndDispose = OutStringMarshaller.GetStringAndDispose(ret);
		}
		return stringAndDispose;
	}

	public UnityWebRequestError GetError()
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return GetError_Injected(intPtr);
	}

	public string GetUrl()
	{
		Unsafe.SkipInit(out ManagedSpanWrapper ret);
		string stringAndDispose;
		try
		{
			System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			GetUrl_Injected(intPtr, out ret);
		}
		finally
		{
			stringAndDispose = OutStringMarshaller.GetStringAndDispose(ret);
		}
		return stringAndDispose;
	}

	public float GetUploadProgress()
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return GetUploadProgress_Injected(intPtr);
	}

	public bool IsExecuting()
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return IsExecuting_Injected(intPtr);
	}

	public float GetDownloadProgress()
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return GetDownloadProgress_Injected(intPtr);
	}

	public int GetRedirectLimit()
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return GetRedirectLimit_Injected(intPtr);
	}

	public void SetRedirectLimitFromScripting(int limit)
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		SetRedirectLimitFromScripting_Injected(intPtr, limit);
	}

	public bool GetChunked()
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return GetChunked_Injected(intPtr);
	}

	public UnityWebRequestError SetChunked(bool chunked)
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return SetChunked_Injected(intPtr, chunked);
	}

	public unsafe string GetRequestHeader(string name)
	{
		//IL_0028: Expected O, but got Ref
		//IL_0034: Expected O, but got Ref
		//The blocks IL_0039 are reachable both inside and outside the pinned region starting at IL_0028. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		Unsafe.SkipInit(out ManagedSpanWrapper ret);
		string stringAndDispose;
		try
		{
			System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(name, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(name);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					GetRequestHeader_Injected(intPtr, ref managedSpanWrapper, out ret);
				}
			}
			else
			{
				GetRequestHeader_Injected(intPtr, ref managedSpanWrapper, out ret);
			}
		}
		finally
		{
			stringAndDispose = OutStringMarshaller.GetStringAndDispose(ret);
		}
		return stringAndDispose;
	}

	public Il2CppStringArray GetResponseHeaderKeys()
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return GetResponseHeaderKeys_Injected(intPtr);
	}

	public Dictionary<string, string> GetResponseHeaders()
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public UnityWebRequestError SetCertificateHandler(CertificateHandler ch)
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return SetCertificateHandler_Injected(intPtr, (ch == null) ? ((System.IntPtr)0) : CertificateHandler.BindingsMarshaller.ConvertToNative(ch));
	}

	public int GetTimeoutMsec()
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return GetTimeoutMsec_Injected(intPtr);
	}

	public UnityWebRequestError SetTimeoutMsec(int timeout)
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return SetTimeoutMsec_Injected(intPtr, timeout);
	}

	public bool GetSuppressErrorsToConsole()
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return GetSuppressErrorsToConsole_Injected(intPtr);
	}

	public UnityWebRequestError SetSuppressErrorsToConsole(bool suppress)
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return SetSuppressErrorsToConsole_Injected(intPtr, suppress);
	}

	public static UnityWebRequest Delete(string uri)
	{
		return new UnityWebRequest(uri, "DELETE");
	}

	public static UnityWebRequest Head(string uri)
	{
		return new UnityWebRequest(uri, "HEAD");
	}

	public static UnityWebRequest GetTexture(string uri)
	{
		throw new Il2CppSystem.NotSupportedException("UnityWebRequest.GetTexture is obsolete. Use UnityWebRequestTexture.GetTexture instead.");
	}

	public static UnityWebRequest GetTexture(string uri, bool nonReadable)
	{
		throw new Il2CppSystem.NotSupportedException("UnityWebRequest.GetTexture is obsolete. Use UnityWebRequestTexture.GetTexture instead.");
	}

	public static UnityWebRequest GetAudioClip(string uri, AudioType audioType)
	{
		return null;
	}

	public static UnityWebRequest GetAssetBundle(string uri)
	{
		return null;
	}

	public static UnityWebRequest GetAssetBundle(string uri, uint crc)
	{
		return null;
	}

	public static UnityWebRequest GetAssetBundle(string uri, uint version, uint crc)
	{
		return null;
	}

	public static UnityWebRequest GetAssetBundle(string uri, Hash128 hash, uint crc)
	{
		return null;
	}

	public static UnityWebRequest Put(string uri, Il2CppStructArray<byte> bodyData)
	{
		return new UnityWebRequest(uri, "PUT", new DownloadHandlerBuffer(), new UploadHandlerRaw(bodyData));
	}

	public static UnityWebRequest Put(string uri, string bodyData)
	{
		return new UnityWebRequest(uri, "PUT", new DownloadHandlerBuffer(), new UploadHandlerRaw(Encoding.UTF8.GetBytes(bodyData)));
	}

	public static UnityWebRequest Post(string uri, string postData)
	{
		return PostWwwForm(uri, postData);
	}

	public static UnityWebRequest PostWwwForm(string uri, string form)
	{
		UnityWebRequest request = new UnityWebRequest(uri, "POST");
		SetupPostWwwForm(request, form);
		return request;
	}

	public static void SetupPostWwwForm(UnityWebRequest request, string postData)
	{
		request.downloadHandler = new DownloadHandlerBuffer();
		if (!Il2CppSystem.String.IsNullOrEmpty(postData))
		{
			Il2CppStructArray<byte> val = null;
			string s = WWWTranscoder.DataEncode(postData, Encoding.UTF8);
			val = Encoding.UTF8.GetBytes(s);
			request.uploadHandler = new UploadHandlerRaw(val);
			request.uploadHandler.contentType = "application/x-www-form-urlencoded";
		}
	}

	public static UnityWebRequest Post(string uri, string postData, string contentType)
	{
		UnityWebRequest request = new UnityWebRequest(uri, "POST");
		SetupPost(request, postData, contentType);
		return request;
	}

	public static void SetupPost(UnityWebRequest request, string postData, string contentType)
	{
		request.downloadHandler = new DownloadHandlerBuffer();
		if (Il2CppSystem.String.IsNullOrEmpty(postData))
		{
			request.SetRequestHeader("Content-Type", contentType);
			return;
		}
		Il2CppStructArray<byte> bytes = Encoding.UTF8.GetBytes(postData);
		request.uploadHandler = new UploadHandlerRaw(bytes);
		request.uploadHandler.contentType = contentType;
	}

	public static UnityWebRequest Post(string uri, WWWForm formData)
	{
		UnityWebRequest request = new UnityWebRequest(uri, "POST");
		SetupPost(request, formData);
		return request;
	}

	public unsafe static void SetupPost(UnityWebRequest request, WWWForm formData)
	{
		//IL_008e: Expected O, but got Ref
		//IL_007d: Expected O, but got Ref
		//IL_005f: Expected O, but got Ref
		//IL_0069: Expected O, but got Ref
		//IL_0070: Expected O, but got Ref
		request.downloadHandler = new DownloadHandlerBuffer();
		if (formData == null)
		{
			return;
		}
		Il2CppStructArray<byte> val = null;
		val = formData.data;
		if (((Il2CppArrayBase)val).Length == 0)
		{
			val = null;
		}
		if (val != null)
		{
			request.uploadHandler = new UploadHandlerRaw(val);
		}
		Dictionary<string, string> headers = formData.headers;
		Dictionary<string, string>.Enumerator enumerator = headers.GetEnumerator();
		try
		{
			while (((Dictionary<string, string>.Enumerator)(&enumerator)).MoveNext())
			{
				KeyValuePair<string, string> current = ((Dictionary<string, string>.Enumerator)(&enumerator)).Current;
				request.SetRequestHeader(((KeyValuePair<string, string>)(&current)).Key, ((KeyValuePair<string, string>)(&current)).Value);
			}
		}
		finally
		{
			((Il2CppSystem.IDisposable)(object)(Dictionary<string, string>.Enumerator)(&enumerator)).Dispose();
		}
	}

	public static UnityWebRequest Post(string uri, List<IMultipartFormSection> multipartFormSections)
	{
		Il2CppStructArray<byte> boundary = GenerateBoundary();
		return Post(uri, multipartFormSections, boundary);
	}

	public static UnityWebRequest Post(string uri, List<IMultipartFormSection> multipartFormSections, Il2CppStructArray<byte> boundary)
	{
		UnityWebRequest request = new UnityWebRequest(uri, "POST");
		SetupPost(request, multipartFormSections, boundary);
		return request;
	}

	public static void SetupPost(UnityWebRequest request, List<IMultipartFormSection> multipartFormSections, Il2CppStructArray<byte> boundary)
	{
		request.downloadHandler = new DownloadHandlerBuffer();
		Il2CppStructArray<byte> val = null;
		if (multipartFormSections != null && multipartFormSections.Count != 0)
		{
			val = SerializeFormSections(multipartFormSections, boundary);
		}
		if (val != null)
		{
			UploadHandler uploadHandler = new UploadHandlerRaw(val);
			uploadHandler.contentType = Il2CppSystem.String.Concat("multipart/form-data; boundary=", Encoding.UTF8.GetString(boundary, 0, ((Il2CppArrayBase)boundary).Length));
			request.uploadHandler = uploadHandler;
		}
	}

	public static UnityWebRequest Post(string uri, Dictionary<string, string> formFields)
	{
		UnityWebRequest request = new UnityWebRequest(uri, "POST");
		SetupPost(request, formFields);
		return request;
	}

	public static void SetupPost(UnityWebRequest request, Dictionary<string, string> formFields)
	{
		request.downloadHandler = new DownloadHandlerBuffer();
		Il2CppStructArray<byte> val = null;
		if (formFields != null && formFields.Count != 0)
		{
			val = SerializeSimpleForm(formFields);
		}
		if (val != null)
		{
			UploadHandler uploadHandler = new UploadHandlerRaw(val);
			uploadHandler.contentType = "application/x-www-form-urlencoded";
			request.uploadHandler = uploadHandler;
		}
	}

	public static string EscapeURL(string s)
	{
		return EscapeURL(s, Encoding.UTF8);
	}

	public static string EscapeURL(string s, Encoding e)
	{
		if (s == null)
		{
			return null;
		}
		if (s == "")
		{
			return "";
		}
		if (e == null)
		{
			return null;
		}
		Il2CppStructArray<byte> bytes = e.GetBytes(s);
		Il2CppStructArray<byte> bytes2 = WWWTranscoder.URLEncode(bytes);
		return e.GetString(bytes2);
	}

	public static string UnEscapeURL(string s)
	{
		return UnEscapeURL(s, Encoding.UTF8);
	}

	public static string UnEscapeURL(string s, Encoding e)
	{
		if (s == null)
		{
			return null;
		}
		if (s.IndexOf('%') == -1 && s.IndexOf('+') == -1)
		{
			return s;
		}
		Il2CppStructArray<byte> bytes = e.GetBytes(s);
		Il2CppStructArray<byte> bytes2 = WWWTranscoder.URLDecode(bytes);
		return e.GetString(bytes2);
	}

	public unsafe static Il2CppStructArray<byte> SerializeFormSections(List<IMultipartFormSection> multipartFormSections, Il2CppStructArray<byte> boundary)
	{
		//IL_0081: Expected O, but got Ref
		//IL_01ba: Expected O, but got Ref
		//IL_0070: Expected O, but got Ref
		//IL_0052: Expected O, but got Ref
		//IL_01a6: Expected O, but got Ref
		//IL_009f: Expected O, but got Ref
		if (multipartFormSections == null || multipartFormSections.Count == 0)
		{
			return null;
		}
		Il2CppStructArray<byte> bytes = Encoding.UTF8.GetBytes("\r\n");
		Il2CppStructArray<byte> bytes2 = WWWForm.DefaultEncoding.GetBytes("--");
		int num = 0;
		List<IMultipartFormSection>.Enumerator enumerator = multipartFormSections.GetEnumerator();
		try
		{
			while (((List<IMultipartFormSection>.Enumerator)(&enumerator)).MoveNext())
			{
				IMultipartFormSection current = ((List<IMultipartFormSection>.Enumerator)(&enumerator)).Current;
				num += 64 + ((Il2CppArrayBase)current.sectionData).Length;
			}
		}
		finally
		{
			((Il2CppSystem.IDisposable)(object)(List<IMultipartFormSection>.Enumerator)(&enumerator)).Dispose();
		}
		List<byte> list = new List<byte>(num);
		List<IMultipartFormSection>.Enumerator enumerator2 = multipartFormSections.GetEnumerator();
		try
		{
			while (((List<IMultipartFormSection>.Enumerator)(&enumerator2)).MoveNext())
			{
				IMultipartFormSection current2 = ((List<IMultipartFormSection>.Enumerator)(&enumerator2)).Current;
				string str = "form-data";
				string sectionName = current2.sectionName;
				string fileName = current2.fileName;
				string str2 = Il2CppSystem.String.Concat("Content-Disposition: ", str);
				if (!Il2CppSystem.String.IsNullOrEmpty(sectionName))
				{
					str2 = Il2CppSystem.String.Concat(str2, "; name=\"", sectionName, "\"");
				}
				if (!Il2CppSystem.String.IsNullOrEmpty(fileName))
				{
					str2 = Il2CppSystem.String.Concat(str2, "; filename=\"", fileName, "\"");
				}
				str2 = Il2CppSystem.String.Concat(str2, "\r\n");
				string contentType = current2.contentType;
				if (!Il2CppSystem.String.IsNullOrEmpty(contentType))
				{
					str2 = Il2CppSystem.String.Concat(str2, "Content-Type: ", contentType, "\r\n");
				}
				list.AddRange((IEnumerable<byte>)(object)bytes);
				list.AddRange((IEnumerable<byte>)(object)bytes2);
				list.AddRange((IEnumerable<byte>)(object)boundary);
				list.AddRange((IEnumerable<byte>)(object)bytes);
				list.AddRange((IEnumerable<byte>)(object)Encoding.UTF8.GetBytes(str2));
				list.AddRange((IEnumerable<byte>)(object)bytes);
				list.AddRange((IEnumerable<byte>)(object)current2.sectionData);
			}
		}
		finally
		{
			((Il2CppSystem.IDisposable)(object)(List<IMultipartFormSection>.Enumerator)(&enumerator2)).Dispose();
		}
		list.AddRange((IEnumerable<byte>)(object)bytes);
		list.AddRange((IEnumerable<byte>)(object)bytes2);
		list.AddRange((IEnumerable<byte>)(object)boundary);
		list.AddRange((IEnumerable<byte>)(object)bytes2);
		list.AddRange((IEnumerable<byte>)(object)bytes);
		return (Il2CppStructArray<byte>)(object)list.ToArray();
	}

	public static Il2CppStructArray<byte> GenerateBoundary()
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public unsafe static Il2CppStructArray<byte> SerializeSimpleForm(Dictionary<string, string> formFields)
	{
		//IL_0072: Expected O, but got Ref
		//IL_0061: Expected O, but got Ref
		//IL_0018: Expected O, but got Ref
		//IL_003d: Expected O, but got Ref
		//IL_004e: Expected O, but got Ref
		string text = "";
		Dictionary<string, string>.Enumerator enumerator = formFields.GetEnumerator();
		try
		{
			while (((Dictionary<string, string>.Enumerator)(&enumerator)).MoveNext())
			{
				KeyValuePair<string, string> current = ((Dictionary<string, string>.Enumerator)(&enumerator)).Current;
				if (text.Length > 0)
				{
					text = Il2CppSystem.String.Concat(text, "&");
				}
				text = Il2CppSystem.String.Concat(text, WWWTranscoder.DataEncode(((KeyValuePair<string, string>)(&current)).Key), "=", WWWTranscoder.DataEncode(((KeyValuePair<string, string>)(&current)).Value));
			}
		}
		finally
		{
			((Il2CppSystem.IDisposable)(object)(Dictionary<string, string>.Enumerator)(&enumerator)).Dispose();
		}
		return Encoding.UTF8.GetBytes(text);
	}

	public unsafe static void GetHTTPStatusString_Injected(long responseCode, out ManagedSpanWrapper ret)
	{
		GetHTTPStatusString_InjectedDelegateField(responseCode, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void ClearCookieCache_Injected(ref ManagedSpanWrapper domain, ref ManagedSpanWrapper path)
	{
		ClearCookieCache_InjectedDelegateField((nint)Unsafe.AsPointer(ref domain), (nint)Unsafe.AsPointer(ref path));
	}

	public static UnityWebRequestMethod GetMethod_Injected(System.IntPtr _unity_self)
	{
		return GetMethod_InjectedDelegateField(_unity_self);
	}

	public unsafe static void GetCustomMethod_Injected(System.IntPtr _unity_self, out ManagedSpanWrapper ret)
	{
		GetCustomMethod_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public static UnityWebRequestError GetError_Injected(System.IntPtr _unity_self)
	{
		return GetError_InjectedDelegateField(_unity_self);
	}

	public static bool get_use100Continue_Injected(System.IntPtr _unity_self)
	{
		return get_use100Continue_InjectedDelegateField(_unity_self);
	}

	public static void set_use100Continue_Injected(System.IntPtr _unity_self, bool value)
	{
		set_use100Continue_InjectedDelegateField(_unity_self, value);
	}

	public unsafe static void GetUrl_Injected(System.IntPtr _unity_self, out ManagedSpanWrapper ret)
	{
		GetUrl_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public static float GetUploadProgress_Injected(System.IntPtr _unity_self)
	{
		return GetUploadProgress_InjectedDelegateField(_unity_self);
	}

	public static bool IsExecuting_Injected(System.IntPtr _unity_self)
	{
		return IsExecuting_InjectedDelegateField(_unity_self);
	}

	public static float GetDownloadProgress_Injected(System.IntPtr _unity_self)
	{
		return GetDownloadProgress_InjectedDelegateField(_unity_self);
	}

	public static ulong get_uploadedBytes_Injected(System.IntPtr _unity_self)
	{
		return get_uploadedBytes_InjectedDelegateField(_unity_self);
	}

	public static int GetRedirectLimit_Injected(System.IntPtr _unity_self)
	{
		return GetRedirectLimit_InjectedDelegateField(_unity_self);
	}

	public static void SetRedirectLimitFromScripting_Injected(System.IntPtr _unity_self, int limit)
	{
		SetRedirectLimitFromScripting_InjectedDelegateField(_unity_self, limit);
	}

	public static bool GetChunked_Injected(System.IntPtr _unity_self)
	{
		return GetChunked_InjectedDelegateField(_unity_self);
	}

	public static UnityWebRequestError SetChunked_Injected(System.IntPtr _unity_self, bool chunked)
	{
		return SetChunked_InjectedDelegateField(_unity_self, chunked);
	}

	public unsafe static void GetRequestHeader_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper name, out ManagedSpanWrapper ret)
	{
		GetRequestHeader_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref name), (nint)Unsafe.AsPointer(ref ret));
	}

	public static Il2CppStringArray GetResponseHeaderKeys_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr intPtr = GetResponseHeaderKeys_InjectedDelegateField(_unity_self);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr) : null;
	}

	public static UnityWebRequestError SetCertificateHandler_Injected(System.IntPtr _unity_self, System.IntPtr ch)
	{
		return SetCertificateHandler_InjectedDelegateField(_unity_self, ch);
	}

	public static int GetTimeoutMsec_Injected(System.IntPtr _unity_self)
	{
		return GetTimeoutMsec_InjectedDelegateField(_unity_self);
	}

	public static UnityWebRequestError SetTimeoutMsec_Injected(System.IntPtr _unity_self, int timeout)
	{
		return SetTimeoutMsec_InjectedDelegateField(_unity_self, timeout);
	}

	public static bool GetSuppressErrorsToConsole_Injected(System.IntPtr _unity_self)
	{
		return GetSuppressErrorsToConsole_InjectedDelegateField(_unity_self);
	}

	public static UnityWebRequestError SetSuppressErrorsToConsole_Injected(System.IntPtr _unity_self, bool suppress)
	{
		return SetSuppressErrorsToConsole_InjectedDelegateField(_unity_self, suppress);
	}
}
