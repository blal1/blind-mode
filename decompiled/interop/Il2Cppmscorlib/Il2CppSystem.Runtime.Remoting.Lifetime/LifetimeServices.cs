using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Remoting.Lifetime;

public sealed class LifetimeServices : Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr__leaseManagerPollTime;

	private static readonly System.IntPtr NativeFieldInfoPtr__leaseTime;

	private static readonly System.IntPtr NativeFieldInfoPtr__renewOnCallTime;

	private static readonly System.IntPtr NativeFieldInfoPtr__sponsorshipTimeout;

	private static readonly System.IntPtr NativeFieldInfoPtr__leaseManager;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_LeaseManagerPollTime_Public_Static_get_TimeSpan_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_LeaseManagerPollTime_Public_Static_set_Void_TimeSpan_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_LeaseTime_Public_Static_get_TimeSpan_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_LeaseTime_Public_Static_set_Void_TimeSpan_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_RenewOnCallTime_Public_Static_get_TimeSpan_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_RenewOnCallTime_Public_Static_set_Void_TimeSpan_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_SponsorshipTimeout_Public_Static_get_TimeSpan_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_SponsorshipTimeout_Public_Static_set_Void_TimeSpan_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TrackLifetime_Internal_Static_Void_ServerIdentity_0;

	public unsafe static TimeSpan _leaseManagerPollTime
	{
		get
		{
			Unsafe.SkipInit(out TimeSpan result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__leaseManagerPollTime, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__leaseManagerPollTime, (void*)(&value));
		}
	}

	public unsafe static TimeSpan _leaseTime
	{
		get
		{
			Unsafe.SkipInit(out TimeSpan result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__leaseTime, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__leaseTime, (void*)(&value));
		}
	}

	public unsafe static TimeSpan _renewOnCallTime
	{
		get
		{
			Unsafe.SkipInit(out TimeSpan result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__renewOnCallTime, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__renewOnCallTime, (void*)(&value));
		}
	}

	public unsafe static TimeSpan _sponsorshipTimeout
	{
		get
		{
			Unsafe.SkipInit(out TimeSpan result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__sponsorshipTimeout, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__sponsorshipTimeout, (void*)(&value));
		}
	}

	public unsafe static LeaseManager _leaseManager
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__leaseManager, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<LeaseManager>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__leaseManager, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static TimeSpan LeaseManagerPollTime
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 793203, XrefRangeEnd = 793207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_LeaseManagerPollTime_Public_Static_get_TimeSpan_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(TimeSpan*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 793214, RefRangeEnd = 793215, XrefRangeStart = 793207, XrefRangeEnd = 793214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_LeaseManagerPollTime_Public_Static_set_Void_TimeSpan_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe static TimeSpan LeaseTime
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 793215, XrefRangeEnd = 793219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_LeaseTime_Public_Static_get_TimeSpan_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(TimeSpan*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 793219, XrefRangeEnd = 793223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_LeaseTime_Public_Static_set_Void_TimeSpan_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe static TimeSpan RenewOnCallTime
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 793223, XrefRangeEnd = 793227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_RenewOnCallTime_Public_Static_get_TimeSpan_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(TimeSpan*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 793227, XrefRangeEnd = 793231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_RenewOnCallTime_Public_Static_set_Void_TimeSpan_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe static TimeSpan SponsorshipTimeout
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 793231, XrefRangeEnd = 793235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_SponsorshipTimeout_Public_Static_get_TimeSpan_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(TimeSpan*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 793235, XrefRangeEnd = 793239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_SponsorshipTimeout_Public_Static_set_Void_TimeSpan_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	static LifetimeServices()
	{
		Il2CppClassPointerStore<LifetimeServices>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Lifetime", "LifetimeServices");
		NativeFieldInfoPtr__leaseManagerPollTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LifetimeServices>.NativeClassPtr, "_leaseManagerPollTime");
		NativeFieldInfoPtr__leaseTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LifetimeServices>.NativeClassPtr, "_leaseTime");
		NativeFieldInfoPtr__renewOnCallTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LifetimeServices>.NativeClassPtr, "_renewOnCallTime");
		NativeFieldInfoPtr__sponsorshipTimeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LifetimeServices>.NativeClassPtr, "_sponsorshipTimeout");
		NativeFieldInfoPtr__leaseManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LifetimeServices>.NativeClassPtr, "_leaseManager");
		NativeMethodInfoPtr_get_LeaseManagerPollTime_Public_Static_get_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LifetimeServices>.NativeClassPtr, 100670067);
		NativeMethodInfoPtr_set_LeaseManagerPollTime_Public_Static_set_Void_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LifetimeServices>.NativeClassPtr, 100670068);
		NativeMethodInfoPtr_get_LeaseTime_Public_Static_get_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LifetimeServices>.NativeClassPtr, 100670069);
		NativeMethodInfoPtr_set_LeaseTime_Public_Static_set_Void_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LifetimeServices>.NativeClassPtr, 100670070);
		NativeMethodInfoPtr_get_RenewOnCallTime_Public_Static_get_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LifetimeServices>.NativeClassPtr, 100670071);
		NativeMethodInfoPtr_set_RenewOnCallTime_Public_Static_set_Void_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LifetimeServices>.NativeClassPtr, 100670072);
		NativeMethodInfoPtr_get_SponsorshipTimeout_Public_Static_get_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LifetimeServices>.NativeClassPtr, 100670073);
		NativeMethodInfoPtr_set_SponsorshipTimeout_Public_Static_set_Void_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LifetimeServices>.NativeClassPtr, 100670074);
		NativeMethodInfoPtr_TrackLifetime_Internal_Static_Void_ServerIdentity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LifetimeServices>.NativeClassPtr, 100670075);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 793239, XrefRangeEnd = 793269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void TrackLifetime(ServerIdentity identity)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)identity);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TrackLifetime_Internal_Static_Void_ServerIdentity_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public LifetimeServices(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
