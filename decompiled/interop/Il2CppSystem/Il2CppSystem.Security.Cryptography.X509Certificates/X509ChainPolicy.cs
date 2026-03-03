using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Cryptography.X509Certificates;

public sealed class X509ChainPolicy : Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_apps;

	private static readonly System.IntPtr NativeFieldInfoPtr_cert;

	private static readonly System.IntPtr NativeFieldInfoPtr_store;

	private static readonly System.IntPtr NativeFieldInfoPtr_store2;

	private static readonly System.IntPtr NativeFieldInfoPtr_rflag;

	private static readonly System.IntPtr NativeFieldInfoPtr_mode;

	private static readonly System.IntPtr NativeFieldInfoPtr_timeout;

	private static readonly System.IntPtr NativeFieldInfoPtr_vflags;

	private static readonly System.IntPtr NativeFieldInfoPtr_vtime;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_ExtraStore_Public_get_X509Certificate2Collection_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_ExtraStore_Internal_set_Void_X509Certificate2Collection_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_RevocationFlag_Public_get_X509RevocationFlag_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_RevocationMode_Public_get_X509RevocationMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_RevocationMode_Public_set_Void_X509RevocationMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_VerificationFlags_Public_get_X509VerificationFlags_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_VerificationFlags_Public_set_Void_X509VerificationFlags_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_VerificationTime_Public_get_DateTime_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Reset_Public_Void_0;

	public unsafe OidCollection apps
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_apps);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<OidCollection>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_apps)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe OidCollection cert
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cert);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<OidCollection>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cert)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe X509CertificateCollection store
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_store);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<X509CertificateCollection>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_store)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe X509Certificate2Collection store2
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_store2);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<X509Certificate2Collection>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_store2)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe X509RevocationFlag rflag
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rflag);
			return *(X509RevocationFlag*)num;
		}
		set
		{
			*(X509RevocationFlag*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rflag)) = value;
		}
	}

	public unsafe X509RevocationMode mode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mode);
			return *(X509RevocationMode*)num;
		}
		set
		{
			*(X509RevocationMode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mode)) = value;
		}
	}

	public unsafe TimeSpan timeout
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeout);
			return *(TimeSpan*)num;
		}
		set
		{
			*(TimeSpan*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeout)) = value;
		}
	}

	public unsafe X509VerificationFlags vflags
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vflags);
			return *(X509VerificationFlags*)num;
		}
		set
		{
			*(X509VerificationFlags*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vflags)) = value;
		}
	}

	public unsafe DateTime vtime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vtime);
			return *(DateTime*)num;
		}
		set
		{
			*(DateTime*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vtime)) = value;
		}
	}

	public unsafe X509Certificate2Collection ExtraStore
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 880461, RefRangeEnd = 880462, XrefRangeStart = 880428, XrefRangeEnd = 880461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ExtraStore_Public_get_X509Certificate2Collection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<X509Certificate2Collection>(intPtr2) : null;
		}
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 41896, RefRangeEnd = 41911, XrefRangeStart = 41896, XrefRangeEnd = 41911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_ExtraStore_Internal_set_Void_X509Certificate2Collection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe X509RevocationFlag RevocationFlag
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 66330, RefRangeEnd = 66331, XrefRangeStart = 66330, XrefRangeEnd = 66331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_RevocationFlag_Public_get_X509RevocationFlag_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(X509RevocationFlag*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe X509RevocationMode RevocationMode
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 65293, RefRangeEnd = 65294, XrefRangeStart = 65293, XrefRangeEnd = 65294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_RevocationMode_Public_get_X509RevocationMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(X509RevocationMode*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 880462, RefRangeEnd = 880463, XrefRangeStart = 880462, XrefRangeEnd = 880462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_RevocationMode_Public_set_Void_X509RevocationMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe X509VerificationFlags VerificationFlags
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_VerificationFlags_Public_get_X509VerificationFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(X509VerificationFlags*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_VerificationFlags_Public_set_Void_X509VerificationFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe DateTime VerificationTime
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 84624, RefRangeEnd = 84627, XrefRangeStart = 84624, XrefRangeEnd = 84627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_VerificationTime_Public_get_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(DateTime*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static X509ChainPolicy()
	{
		Il2CppClassPointerStore<X509ChainPolicy>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Security.Cryptography.X509Certificates", "X509ChainPolicy");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<X509ChainPolicy>.NativeClassPtr);
		NativeFieldInfoPtr_apps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509ChainPolicy>.NativeClassPtr, "apps");
		NativeFieldInfoPtr_cert = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509ChainPolicy>.NativeClassPtr, "cert");
		NativeFieldInfoPtr_store = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509ChainPolicy>.NativeClassPtr, "store");
		NativeFieldInfoPtr_store2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509ChainPolicy>.NativeClassPtr, "store2");
		NativeFieldInfoPtr_rflag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509ChainPolicy>.NativeClassPtr, "rflag");
		NativeFieldInfoPtr_mode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509ChainPolicy>.NativeClassPtr, "mode");
		NativeFieldInfoPtr_timeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509ChainPolicy>.NativeClassPtr, "timeout");
		NativeFieldInfoPtr_vflags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509ChainPolicy>.NativeClassPtr, "vflags");
		NativeFieldInfoPtr_vtime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509ChainPolicy>.NativeClassPtr, "vtime");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainPolicy>.NativeClassPtr, 100665161);
		NativeMethodInfoPtr_get_ExtraStore_Public_get_X509Certificate2Collection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainPolicy>.NativeClassPtr, 100665162);
		NativeMethodInfoPtr_set_ExtraStore_Internal_set_Void_X509Certificate2Collection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainPolicy>.NativeClassPtr, 100665163);
		NativeMethodInfoPtr_get_RevocationFlag_Public_get_X509RevocationFlag_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainPolicy>.NativeClassPtr, 100665164);
		NativeMethodInfoPtr_get_RevocationMode_Public_get_X509RevocationMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainPolicy>.NativeClassPtr, 100665165);
		NativeMethodInfoPtr_set_RevocationMode_Public_set_Void_X509RevocationMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainPolicy>.NativeClassPtr, 100665166);
		NativeMethodInfoPtr_get_VerificationFlags_Public_get_X509VerificationFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainPolicy>.NativeClassPtr, 100665167);
		NativeMethodInfoPtr_set_VerificationFlags_Public_set_Void_X509VerificationFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainPolicy>.NativeClassPtr, 100665168);
		NativeMethodInfoPtr_get_VerificationTime_Public_get_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainPolicy>.NativeClassPtr, 100665169);
		NativeMethodInfoPtr_Reset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainPolicy>.NativeClassPtr, 100665170);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 880422, RefRangeEnd = 880428, XrefRangeStart = 880403, XrefRangeEnd = 880422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe X509ChainPolicy()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509ChainPolicy>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 880463, XrefRangeEnd = 880481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Reset()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Reset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public X509ChainPolicy(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
