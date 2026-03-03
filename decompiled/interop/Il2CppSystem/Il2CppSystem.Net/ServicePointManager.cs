using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Concurrent;
using Il2CppSystem.Net.Security;

namespace Il2CppSystem.Net;

public class ServicePointManager : Object
{
	public class SPKey : Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_uri;

		private static readonly System.IntPtr NativeFieldInfoPtr_proxy;

		private static readonly System.IntPtr NativeFieldInfoPtr_use_connect;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Uri_Uri_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_UsesProxy_Public_get_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		public unsafe Uri uri
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_uri);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Uri>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_uri)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe Uri proxy
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_proxy);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Uri>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_proxy)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe bool use_connect
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_use_connect);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_use_connect)) = value;
			}
		}

		public unsafe bool UsesProxy
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 893717, RefRangeEnd = 893720, XrefRangeStart = 893713, XrefRangeEnd = 893717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_UsesProxy_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		static SPKey()
		{
			Il2CppClassPointerStore<SPKey>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServicePointManager>.NativeClassPtr, "SPKey");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SPKey>.NativeClassPtr);
			NativeFieldInfoPtr_uri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SPKey>.NativeClassPtr, "uri");
			NativeFieldInfoPtr_proxy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SPKey>.NativeClassPtr, "proxy");
			NativeFieldInfoPtr_use_connect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SPKey>.NativeClassPtr, "use_connect");
			NativeMethodInfoPtr__ctor_Public_Void_Uri_Uri_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPKey>.NativeClassPtr, 100666813);
			NativeMethodInfoPtr_get_UsesProxy_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPKey>.NativeClassPtr, 100666814);
			NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPKey>.NativeClassPtr, 100666815);
			NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SPKey>.NativeClassPtr, 100666816);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 772718, RefRangeEnd = 772719, XrefRangeStart = 772718, XrefRangeEnd = 772719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SPKey(Uri uri, Uri proxy, bool use_connect)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SPKey>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[3];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)uri);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)proxy);
			*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &use_connect;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Uri_Uri_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 893720, XrefRangeEnd = 893725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 893725, XrefRangeEnd = 893730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		public SPKey(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_servicePoints;

	private static readonly System.IntPtr NativeFieldInfoPtr_policy;

	private static readonly System.IntPtr NativeFieldInfoPtr_defaultConnectionLimit;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxServicePointIdleTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxServicePoints;

	private static readonly System.IntPtr NativeFieldInfoPtr_dnsRefreshTimeout;

	private static readonly System.IntPtr NativeFieldInfoPtr__checkCRL;

	private static readonly System.IntPtr NativeFieldInfoPtr__securityProtocol;

	private static readonly System.IntPtr NativeFieldInfoPtr_expectContinue;

	private static readonly System.IntPtr NativeFieldInfoPtr_useNagle;

	private static readonly System.IntPtr NativeFieldInfoPtr_server_cert_cb;

	private static readonly System.IntPtr NativeFieldInfoPtr_tcp_keepalive;

	private static readonly System.IntPtr NativeFieldInfoPtr_tcp_keepalive_time;

	private static readonly System.IntPtr NativeFieldInfoPtr_tcp_keepalive_interval;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLegacyCertificatePolicy_Internal_Static_ICertificatePolicy_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_CheckCertificateRevocationList_Public_Static_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_DnsRefreshTimeout_Public_Static_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_SecurityProtocol_Public_Static_get_SecurityProtocolType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_ServerCertValidationCallback_Internal_Static_get_ServerCertValidationCallback_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_ServerCertificateValidationCallback_Public_Static_get_RemoteCertificateValidationCallback_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindServicePoint_Public_Static_ServicePoint_Uri_IWebProxy_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveServicePoint_Internal_Static_Void_ServicePoint_0;

	public unsafe static ConcurrentDictionary<SPKey, ServicePoint> servicePoints
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_servicePoints, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ConcurrentDictionary<SPKey, ServicePoint>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_servicePoints, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static ICertificatePolicy policy
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_policy, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ICertificatePolicy>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_policy, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static int defaultConnectionLimit
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_defaultConnectionLimit, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_defaultConnectionLimit, (void*)(&value));
		}
	}

	public unsafe static int maxServicePointIdleTime
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_maxServicePointIdleTime, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_maxServicePointIdleTime, (void*)(&value));
		}
	}

	public unsafe static int maxServicePoints
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_maxServicePoints, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_maxServicePoints, (void*)(&value));
		}
	}

	public unsafe static int dnsRefreshTimeout
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_dnsRefreshTimeout, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_dnsRefreshTimeout, (void*)(&value));
		}
	}

	public unsafe static bool _checkCRL
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__checkCRL, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__checkCRL, (void*)(&value));
		}
	}

	public unsafe static SecurityProtocolType _securityProtocol
	{
		get
		{
			Unsafe.SkipInit(out SecurityProtocolType result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__securityProtocol, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__securityProtocol, (void*)(&value));
		}
	}

	public unsafe static bool expectContinue
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_expectContinue, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_expectContinue, (void*)(&value));
		}
	}

	public unsafe static bool useNagle
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_useNagle, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_useNagle, (void*)(&value));
		}
	}

	public unsafe static ServerCertValidationCallback server_cert_cb
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_server_cert_cb, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ServerCertValidationCallback>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_server_cert_cb, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static bool tcp_keepalive
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_tcp_keepalive, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_tcp_keepalive, (void*)(&value));
		}
	}

	public unsafe static int tcp_keepalive_time
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_tcp_keepalive_time, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_tcp_keepalive_time, (void*)(&value));
		}
	}

	public unsafe static int tcp_keepalive_interval
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_tcp_keepalive_interval, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_tcp_keepalive_interval, (void*)(&value));
		}
	}

	public unsafe static bool CheckCertificateRevocationList
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 893734, XrefRangeEnd = 893738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_CheckCertificateRevocationList_Public_Static_get_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static int DnsRefreshTimeout
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 893738, XrefRangeEnd = 893742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_DnsRefreshTimeout_Public_Static_get_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static SecurityProtocolType SecurityProtocol
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 893742, XrefRangeEnd = 893746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_SecurityProtocol_Public_Static_get_SecurityProtocolType_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(SecurityProtocolType*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static ServerCertValidationCallback ServerCertValidationCallback
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 893746, XrefRangeEnd = 893750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ServerCertValidationCallback_Internal_Static_get_ServerCertValidationCallback_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ServerCertValidationCallback>(intPtr2) : null;
		}
	}

	public unsafe static RemoteCertificateValidationCallback ServerCertificateValidationCallback
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 893756, RefRangeEnd = 893757, XrefRangeStart = 893750, XrefRangeEnd = 893756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ServerCertificateValidationCallback_Public_Static_get_RemoteCertificateValidationCallback_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RemoteCertificateValidationCallback>(intPtr2) : null;
		}
	}

	static ServicePointManager()
	{
		Il2CppClassPointerStore<ServicePointManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "ServicePointManager");
		NativeFieldInfoPtr_servicePoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointManager>.NativeClassPtr, "servicePoints");
		NativeFieldInfoPtr_policy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointManager>.NativeClassPtr, "policy");
		NativeFieldInfoPtr_defaultConnectionLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointManager>.NativeClassPtr, "defaultConnectionLimit");
		NativeFieldInfoPtr_maxServicePointIdleTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointManager>.NativeClassPtr, "maxServicePointIdleTime");
		NativeFieldInfoPtr_maxServicePoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointManager>.NativeClassPtr, "maxServicePoints");
		NativeFieldInfoPtr_dnsRefreshTimeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointManager>.NativeClassPtr, "dnsRefreshTimeout");
		NativeFieldInfoPtr__checkCRL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointManager>.NativeClassPtr, "_checkCRL");
		NativeFieldInfoPtr__securityProtocol = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointManager>.NativeClassPtr, "_securityProtocol");
		NativeFieldInfoPtr_expectContinue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointManager>.NativeClassPtr, "expectContinue");
		NativeFieldInfoPtr_useNagle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointManager>.NativeClassPtr, "useNagle");
		NativeFieldInfoPtr_server_cert_cb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointManager>.NativeClassPtr, "server_cert_cb");
		NativeFieldInfoPtr_tcp_keepalive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointManager>.NativeClassPtr, "tcp_keepalive");
		NativeFieldInfoPtr_tcp_keepalive_time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointManager>.NativeClassPtr, "tcp_keepalive_time");
		NativeFieldInfoPtr_tcp_keepalive_interval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServicePointManager>.NativeClassPtr, "tcp_keepalive_interval");
		NativeMethodInfoPtr_GetLegacyCertificatePolicy_Internal_Static_ICertificatePolicy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointManager>.NativeClassPtr, 100666805);
		NativeMethodInfoPtr_get_CheckCertificateRevocationList_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointManager>.NativeClassPtr, 100666806);
		NativeMethodInfoPtr_get_DnsRefreshTimeout_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointManager>.NativeClassPtr, 100666807);
		NativeMethodInfoPtr_get_SecurityProtocol_Public_Static_get_SecurityProtocolType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointManager>.NativeClassPtr, 100666808);
		NativeMethodInfoPtr_get_ServerCertValidationCallback_Internal_Static_get_ServerCertValidationCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointManager>.NativeClassPtr, 100666809);
		NativeMethodInfoPtr_get_ServerCertificateValidationCallback_Public_Static_get_RemoteCertificateValidationCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointManager>.NativeClassPtr, 100666810);
		NativeMethodInfoPtr_FindServicePoint_Public_Static_ServicePoint_Uri_IWebProxy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointManager>.NativeClassPtr, 100666811);
		NativeMethodInfoPtr_RemoveServicePoint_Internal_Static_Void_ServicePoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServicePointManager>.NativeClassPtr, 100666812);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 893730, XrefRangeEnd = 893734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ICertificatePolicy GetLegacyCertificatePolicy()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLegacyCertificatePolicy_Internal_Static_ICertificatePolicy_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ICertificatePolicy>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 893850, RefRangeEnd = 893851, XrefRangeStart = 893757, XrefRangeEnd = 893850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ServicePoint FindServicePoint(Uri address, IWebProxy proxy)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)address);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)proxy);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindServicePoint_Public_Static_ServicePoint_Uri_IWebProxy_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ServicePoint>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 893851, XrefRangeEnd = 893858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RemoveServicePoint(ServicePoint sp)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sp);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveServicePoint_Internal_Static_Void_ServicePoint_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public ServicePointManager(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
