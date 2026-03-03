using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnityEngine.Bindings;

namespace UnityEngine.Analytics;

public static class Analytics
{
	private delegate AnalyticsResult ResumeInitializationInternalDelegate();

	private delegate bool get_initializeOnStartupInternalDelegate();

	private delegate void set_initializeOnStartupInternalDelegate(bool value);

	private delegate bool IsInitializedDelegate();

	private delegate bool get_enabledInternalDelegate();

	private delegate void set_enabledInternalDelegate(bool value);

	private delegate bool get_playerOptedOutInternalDelegate();

	private delegate bool get_limitUserTrackingInternalDelegate();

	private delegate void set_limitUserTrackingInternalDelegate(bool value);

	private delegate bool get_deviceStatsEnabledInternalDelegate();

	private delegate void set_deviceStatsEnabledInternalDelegate(bool value);

	private delegate bool FlushArchivedEventsDelegate();

	private delegate void get_eventUrlInternal_InjectedDelegate([Out] System.IntPtr ret);

	private delegate void get_configUrlInternal_InjectedDelegate([Out] System.IntPtr ret);

	private delegate void get_dashboardUrlInternal_InjectedDelegate([Out] System.IntPtr ret);

	private delegate AnalyticsResult Transaction_InjectedDelegate(System.IntPtr productId, double amount, System.IntPtr currency, System.IntPtr receiptPurchaseData, System.IntPtr signature, bool usingIAPService);

	private delegate AnalyticsResult SendCustomEventName_InjectedDelegate(System.IntPtr customEventName);

	private delegate AnalyticsResult SendCustomEvent_InjectedDelegate(System.IntPtr eventData);

	private delegate AnalyticsResult IsCustomEventWithLimitEnabled_InjectedDelegate(System.IntPtr customEventName);

	private delegate AnalyticsResult EnableCustomEventWithLimit_InjectedDelegate(System.IntPtr customEventName, bool enable);

	private delegate AnalyticsResult IsEventWithLimitEnabled_InjectedDelegate(System.IntPtr eventName, int ver, System.IntPtr prefix);

	private delegate AnalyticsResult EnableEventWithLimit_InjectedDelegate(System.IntPtr eventName, bool enable, int ver, System.IntPtr prefix);

	private delegate AnalyticsResult RegisterEventWithLimit_InjectedDelegate(System.IntPtr eventName, int maxEventPerHour, int maxItems, System.IntPtr vendorKey, int ver, System.IntPtr prefix, System.IntPtr assemblyInfo, bool notifyServer);

	private delegate AnalyticsResult RegisterEventsWithLimit_InjectedDelegate(System.IntPtr eventName, int maxEventPerHour, int maxItems, System.IntPtr vendorKey, int ver, System.IntPtr prefix, System.IntPtr assemblyInfo, bool notifyServer);

	private delegate AnalyticsResult SendEventWithLimit_InjectedDelegate(System.IntPtr eventName, System.IntPtr parameters, int ver, System.IntPtr prefix);

	private delegate AnalyticsResult SetEventWithLimitEndPoint_InjectedDelegate(System.IntPtr eventName, System.IntPtr endPoint, int ver, System.IntPtr prefix);

	private delegate AnalyticsResult SetEventWithLimitPriority_InjectedDelegate(System.IntPtr eventName, AnalyticsEventPriority eventPriority, int ver, System.IntPtr prefix);

	private delegate AnalyticsResult QueueEvent_InjectedDelegate(System.IntPtr eventName, System.IntPtr parameters, int ver, System.IntPtr prefix);

	private static readonly ResumeInitializationInternalDelegate ResumeInitializationInternalDelegateField = IL2CPP.ResolveICall<ResumeInitializationInternalDelegate>("UnityEngine.Analytics.Analytics::ResumeInitializationInternal");

	private static readonly get_initializeOnStartupInternalDelegate get_initializeOnStartupInternalDelegateField = IL2CPP.ResolveICall<get_initializeOnStartupInternalDelegate>("UnityEngine.Analytics.Analytics::get_initializeOnStartupInternal");

	private static readonly set_initializeOnStartupInternalDelegate set_initializeOnStartupInternalDelegateField = IL2CPP.ResolveICall<set_initializeOnStartupInternalDelegate>("UnityEngine.Analytics.Analytics::set_initializeOnStartupInternal");

	private static readonly IsInitializedDelegate IsInitializedDelegateField = IL2CPP.ResolveICall<IsInitializedDelegate>("UnityEngine.Analytics.Analytics::IsInitialized");

	private static readonly get_enabledInternalDelegate get_enabledInternalDelegateField = IL2CPP.ResolveICall<get_enabledInternalDelegate>("UnityEngine.Analytics.Analytics::get_enabledInternal");

	private static readonly set_enabledInternalDelegate set_enabledInternalDelegateField = IL2CPP.ResolveICall<set_enabledInternalDelegate>("UnityEngine.Analytics.Analytics::set_enabledInternal");

	private static readonly get_playerOptedOutInternalDelegate get_playerOptedOutInternalDelegateField = IL2CPP.ResolveICall<get_playerOptedOutInternalDelegate>("UnityEngine.Analytics.Analytics::get_playerOptedOutInternal");

	private static readonly get_limitUserTrackingInternalDelegate get_limitUserTrackingInternalDelegateField = IL2CPP.ResolveICall<get_limitUserTrackingInternalDelegate>("UnityEngine.Analytics.Analytics::get_limitUserTrackingInternal");

	private static readonly set_limitUserTrackingInternalDelegate set_limitUserTrackingInternalDelegateField = IL2CPP.ResolveICall<set_limitUserTrackingInternalDelegate>("UnityEngine.Analytics.Analytics::set_limitUserTrackingInternal");

	private static readonly get_deviceStatsEnabledInternalDelegate get_deviceStatsEnabledInternalDelegateField = IL2CPP.ResolveICall<get_deviceStatsEnabledInternalDelegate>("UnityEngine.Analytics.Analytics::get_deviceStatsEnabledInternal");

	private static readonly set_deviceStatsEnabledInternalDelegate set_deviceStatsEnabledInternalDelegateField = IL2CPP.ResolveICall<set_deviceStatsEnabledInternalDelegate>("UnityEngine.Analytics.Analytics::set_deviceStatsEnabledInternal");

	private static readonly FlushArchivedEventsDelegate FlushArchivedEventsDelegateField = IL2CPP.ResolveICall<FlushArchivedEventsDelegate>("UnityEngine.Analytics.Analytics::FlushArchivedEvents");

	private static readonly get_eventUrlInternal_InjectedDelegate get_eventUrlInternal_InjectedDelegateField = IL2CPP.ResolveICall<get_eventUrlInternal_InjectedDelegate>("UnityEngine.Analytics.Analytics::get_eventUrlInternal_Injected");

	private static readonly get_configUrlInternal_InjectedDelegate get_configUrlInternal_InjectedDelegateField = IL2CPP.ResolveICall<get_configUrlInternal_InjectedDelegate>("UnityEngine.Analytics.Analytics::get_configUrlInternal_Injected");

	private static readonly get_dashboardUrlInternal_InjectedDelegate get_dashboardUrlInternal_InjectedDelegateField = IL2CPP.ResolveICall<get_dashboardUrlInternal_InjectedDelegate>("UnityEngine.Analytics.Analytics::get_dashboardUrlInternal_Injected");

	private static readonly Transaction_InjectedDelegate Transaction_InjectedDelegateField = IL2CPP.ResolveICall<Transaction_InjectedDelegate>("UnityEngine.Analytics.Analytics::Transaction_Injected");

	private static readonly SendCustomEventName_InjectedDelegate SendCustomEventName_InjectedDelegateField = IL2CPP.ResolveICall<SendCustomEventName_InjectedDelegate>("UnityEngine.Analytics.Analytics::SendCustomEventName_Injected");

	private static readonly SendCustomEvent_InjectedDelegate SendCustomEvent_InjectedDelegateField = IL2CPP.ResolveICall<SendCustomEvent_InjectedDelegate>("UnityEngine.Analytics.Analytics::SendCustomEvent_Injected");

	private static readonly IsCustomEventWithLimitEnabled_InjectedDelegate IsCustomEventWithLimitEnabled_InjectedDelegateField = IL2CPP.ResolveICall<IsCustomEventWithLimitEnabled_InjectedDelegate>("UnityEngine.Analytics.Analytics::IsCustomEventWithLimitEnabled_Injected");

	private static readonly EnableCustomEventWithLimit_InjectedDelegate EnableCustomEventWithLimit_InjectedDelegateField = IL2CPP.ResolveICall<EnableCustomEventWithLimit_InjectedDelegate>("UnityEngine.Analytics.Analytics::EnableCustomEventWithLimit_Injected");

	private static readonly IsEventWithLimitEnabled_InjectedDelegate IsEventWithLimitEnabled_InjectedDelegateField = IL2CPP.ResolveICall<IsEventWithLimitEnabled_InjectedDelegate>("UnityEngine.Analytics.Analytics::IsEventWithLimitEnabled_Injected");

	private static readonly EnableEventWithLimit_InjectedDelegate EnableEventWithLimit_InjectedDelegateField = IL2CPP.ResolveICall<EnableEventWithLimit_InjectedDelegate>("UnityEngine.Analytics.Analytics::EnableEventWithLimit_Injected");

	private static readonly RegisterEventWithLimit_InjectedDelegate RegisterEventWithLimit_InjectedDelegateField = IL2CPP.ResolveICall<RegisterEventWithLimit_InjectedDelegate>("UnityEngine.Analytics.Analytics::RegisterEventWithLimit_Injected");

	private static readonly RegisterEventsWithLimit_InjectedDelegate RegisterEventsWithLimit_InjectedDelegateField = IL2CPP.ResolveICall<RegisterEventsWithLimit_InjectedDelegate>("UnityEngine.Analytics.Analytics::RegisterEventsWithLimit_Injected");

	private static readonly SendEventWithLimit_InjectedDelegate SendEventWithLimit_InjectedDelegateField = IL2CPP.ResolveICall<SendEventWithLimit_InjectedDelegate>("UnityEngine.Analytics.Analytics::SendEventWithLimit_Injected");

	private static readonly SetEventWithLimitEndPoint_InjectedDelegate SetEventWithLimitEndPoint_InjectedDelegateField = IL2CPP.ResolveICall<SetEventWithLimitEndPoint_InjectedDelegate>("UnityEngine.Analytics.Analytics::SetEventWithLimitEndPoint_Injected");

	private static readonly SetEventWithLimitPriority_InjectedDelegate SetEventWithLimitPriority_InjectedDelegateField = IL2CPP.ResolveICall<SetEventWithLimitPriority_InjectedDelegate>("UnityEngine.Analytics.Analytics::SetEventWithLimitPriority_Injected");

	private static readonly QueueEvent_InjectedDelegate QueueEvent_InjectedDelegateField = IL2CPP.ResolveICall<QueueEvent_InjectedDelegate>("UnityEngine.Analytics.Analytics::QueueEvent_Injected");

	public static bool initializeOnStartup
	{
		get
		{
			if (!IsInitialized())
			{
				return false;
			}
			return initializeOnStartupInternal;
		}
		set
		{
			if (IsInitialized())
			{
				initializeOnStartupInternal = value;
			}
		}
	}

	public static bool initializeOnStartupInternal
	{
		get
		{
			return get_initializeOnStartupInternalDelegateField();
		}
		set
		{
			set_initializeOnStartupInternalDelegateField(value);
		}
	}

	public static bool enabledInternal
	{
		get
		{
			return get_enabledInternalDelegateField();
		}
		set
		{
			set_enabledInternalDelegateField(value);
		}
	}

	public static bool playerOptedOutInternal => get_playerOptedOutInternalDelegateField();

	public static string eventUrlInternal
	{
		get
		{
			Unsafe.SkipInit(out ManagedSpanWrapper ret);
			string stringAndDispose;
			try
			{
				get_eventUrlInternal_Injected(out ret);
			}
			finally
			{
				stringAndDispose = OutStringMarshaller.GetStringAndDispose(ret);
			}
			return stringAndDispose;
		}
	}

	public static string configUrlInternal
	{
		get
		{
			Unsafe.SkipInit(out ManagedSpanWrapper ret);
			string stringAndDispose;
			try
			{
				get_configUrlInternal_Injected(out ret);
			}
			finally
			{
				stringAndDispose = OutStringMarshaller.GetStringAndDispose(ret);
			}
			return stringAndDispose;
		}
	}

	public static string dashboardUrlInternal
	{
		get
		{
			Unsafe.SkipInit(out ManagedSpanWrapper ret);
			string stringAndDispose;
			try
			{
				get_dashboardUrlInternal_Injected(out ret);
			}
			finally
			{
				stringAndDispose = OutStringMarshaller.GetStringAndDispose(ret);
			}
			return stringAndDispose;
		}
	}

	public static bool limitUserTrackingInternal
	{
		get
		{
			return get_limitUserTrackingInternalDelegateField();
		}
		set
		{
			set_limitUserTrackingInternalDelegateField(value);
		}
	}

	public static bool deviceStatsEnabledInternal
	{
		get
		{
			return get_deviceStatsEnabledInternalDelegateField();
		}
		set
		{
			set_deviceStatsEnabledInternalDelegateField(value);
		}
	}

	public static bool playerOptedOut
	{
		get
		{
			if (!IsInitialized())
			{
				return false;
			}
			return playerOptedOutInternal;
		}
	}

	public static string eventUrl
	{
		get
		{
			if (!IsInitialized())
			{
				return Il2CppSystem.String.Empty;
			}
			return eventUrlInternal;
		}
	}

	public static string dashboardUrl
	{
		get
		{
			if (!IsInitialized())
			{
				return Il2CppSystem.String.Empty;
			}
			return dashboardUrlInternal;
		}
	}

	public static string configUrl
	{
		get
		{
			if (!IsInitialized())
			{
				return Il2CppSystem.String.Empty;
			}
			return configUrlInternal;
		}
	}

	public static bool limitUserTracking
	{
		get
		{
			if (!IsInitialized())
			{
				return false;
			}
			return limitUserTrackingInternal;
		}
		set
		{
			if (IsInitialized())
			{
				limitUserTrackingInternal = value;
			}
		}
	}

	public static bool deviceStatsEnabled
	{
		get
		{
			if (!IsInitialized())
			{
				return false;
			}
			return deviceStatsEnabledInternal;
		}
		set
		{
			if (IsInitialized())
			{
				deviceStatsEnabledInternal = value;
			}
		}
	}

	public static bool enabled
	{
		get
		{
			if (!IsInitialized())
			{
				return false;
			}
			return enabledInternal;
		}
		set
		{
			if (IsInitialized())
			{
				enabledInternal = value;
			}
		}
	}

	public static AnalyticsResult ResumeInitialization()
	{
		if (!IsInitialized())
		{
			return AnalyticsResult.NotInitialized;
		}
		return ResumeInitializationInternal();
	}

	public static AnalyticsResult ResumeInitializationInternal()
	{
		return ResumeInitializationInternalDelegateField();
	}

	public static bool IsInitialized()
	{
		return IsInitializedDelegateField();
	}

	public static bool FlushArchivedEvents()
	{
		return FlushArchivedEventsDelegateField();
	}

	public unsafe static AnalyticsResult Transaction(string productId, double amount, string currency, string receiptPurchaseData, string signature, bool usingIAPService)
	{
		//IL_0018: Expected O, but got Ref
		//IL_0024: Expected O, but got Ref
		//IL_0045: Expected O, but got Ref
		//IL_0053: Expected O, but got Ref
		//IL_0074: Expected O, but got Ref
		//IL_0082: Expected O, but got Ref
		//IL_00a5: Expected O, but got Ref
		//IL_00b3: Expected O, but got Ref
		//The blocks IL_0029, IL_0037, IL_0045, IL_0053, IL_0058, IL_0065, IL_0074, IL_0082, IL_0087, IL_0095, IL_00a5, IL_00b3, IL_00b8 are reachable both inside and outside the pinned region starting at IL_0018. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		//The blocks IL_0058, IL_0065, IL_0074, IL_0082, IL_0087, IL_0095, IL_00a5, IL_00b3, IL_00b8 are reachable both inside and outside the pinned region starting at IL_0045. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		//The blocks IL_0087, IL_0095, IL_00a5, IL_00b3, IL_00b8 are reachable both inside and outside the pinned region starting at IL_0074. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		//The blocks IL_00b8 are reachable both inside and outside the pinned region starting at IL_00a5. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		//The blocks IL_00b8 are reachable both inside and outside the pinned region starting at IL_00a5. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		//The blocks IL_0087, IL_0095, IL_00a5, IL_00b3, IL_00b8 are reachable both inside and outside the pinned region starting at IL_0074. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		//The blocks IL_00b8 are reachable both inside and outside the pinned region starting at IL_00a5. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		//The blocks IL_00b8 are reachable both inside and outside the pinned region starting at IL_00a5. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		//The blocks IL_0058, IL_0065, IL_0074, IL_0082, IL_0087, IL_0095, IL_00a5, IL_00b3, IL_00b8 are reachable both inside and outside the pinned region starting at IL_0045. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		//The blocks IL_0087, IL_0095, IL_00a5, IL_00b3, IL_00b8 are reachable both inside and outside the pinned region starting at IL_0074. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		//The blocks IL_00b8 are reachable both inside and outside the pinned region starting at IL_00a5. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		//The blocks IL_00b8 are reachable both inside and outside the pinned region starting at IL_00a5. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		//The blocks IL_0087, IL_0095, IL_00a5, IL_00b3, IL_00b8 are reachable both inside and outside the pinned region starting at IL_0074. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		//The blocks IL_00b8 are reachable both inside and outside the pinned region starting at IL_00a5. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		//The blocks IL_00b8 are reachable both inside and outside the pinned region starting at IL_00a5. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			ref ManagedSpanWrapper productId2;
			double amount2;
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper2);
			Il2CppSystem.ReadOnlySpan<char> readOnlySpan2;
			ref ManagedSpanWrapper currency2;
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper3);
			Il2CppSystem.ReadOnlySpan<char> readOnlySpan3;
			ref ManagedSpanWrapper receiptPurchaseData2;
			Il2CppSystem.ReadOnlySpan<char> readOnlySpan4;
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper4);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(productId, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(productId);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					productId2 = ref managedSpanWrapper;
					amount2 = amount;
					if (!StringMarshaller.TryMarshalEmptyOrNullString(currency, ref managedSpanWrapper2))
					{
						readOnlySpan2 = Il2CppSystem.MemoryExtensions.AsSpan(currency);
						fixed (char* begin2 = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan2)).GetPinnableReference())
						{
							managedSpanWrapper2 = new ManagedSpanWrapper(begin2, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan2)).Length);
							currency2 = ref managedSpanWrapper2;
							if (!StringMarshaller.TryMarshalEmptyOrNullString(receiptPurchaseData, ref managedSpanWrapper3))
							{
								readOnlySpan3 = Il2CppSystem.MemoryExtensions.AsSpan(receiptPurchaseData);
								fixed (char* begin3 = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan3)).GetPinnableReference())
								{
									managedSpanWrapper3 = new ManagedSpanWrapper(begin3, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan3)).Length);
									receiptPurchaseData2 = ref managedSpanWrapper3;
									if (!StringMarshaller.TryMarshalEmptyOrNullString(signature, ref managedSpanWrapper4))
									{
										readOnlySpan4 = Il2CppSystem.MemoryExtensions.AsSpan(signature);
										fixed (char* begin4 = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan4)).GetPinnableReference())
										{
											managedSpanWrapper4 = new ManagedSpanWrapper(begin4, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan4)).Length);
											return Transaction_Injected(ref productId2, amount2, ref currency2, ref receiptPurchaseData2, ref managedSpanWrapper4, usingIAPService);
										}
									}
									return Transaction_Injected(ref productId2, amount2, ref currency2, ref receiptPurchaseData2, ref managedSpanWrapper4, usingIAPService);
								}
							}
							receiptPurchaseData2 = ref managedSpanWrapper3;
							if (!StringMarshaller.TryMarshalEmptyOrNullString(signature, ref managedSpanWrapper4))
							{
								readOnlySpan4 = Il2CppSystem.MemoryExtensions.AsSpan(signature);
								fixed (char* begin4 = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan4)).GetPinnableReference())
								{
									managedSpanWrapper4 = new ManagedSpanWrapper(begin4, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan4)).Length);
									return Transaction_Injected(ref productId2, amount2, ref currency2, ref receiptPurchaseData2, ref managedSpanWrapper4, usingIAPService);
								}
							}
							return Transaction_Injected(ref productId2, amount2, ref currency2, ref receiptPurchaseData2, ref managedSpanWrapper4, usingIAPService);
						}
					}
					currency2 = ref managedSpanWrapper2;
					if (!StringMarshaller.TryMarshalEmptyOrNullString(receiptPurchaseData, ref managedSpanWrapper3))
					{
						readOnlySpan3 = Il2CppSystem.MemoryExtensions.AsSpan(receiptPurchaseData);
						fixed (char* begin3 = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan3)).GetPinnableReference())
						{
							managedSpanWrapper3 = new ManagedSpanWrapper(begin3, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan3)).Length);
							receiptPurchaseData2 = ref managedSpanWrapper3;
							if (!StringMarshaller.TryMarshalEmptyOrNullString(signature, ref managedSpanWrapper4))
							{
								readOnlySpan4 = Il2CppSystem.MemoryExtensions.AsSpan(signature);
								fixed (char* begin4 = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan4)).GetPinnableReference())
								{
									managedSpanWrapper4 = new ManagedSpanWrapper(begin4, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan4)).Length);
									return Transaction_Injected(ref productId2, amount2, ref currency2, ref receiptPurchaseData2, ref managedSpanWrapper4, usingIAPService);
								}
							}
							return Transaction_Injected(ref productId2, amount2, ref currency2, ref receiptPurchaseData2, ref managedSpanWrapper4, usingIAPService);
						}
					}
					receiptPurchaseData2 = ref managedSpanWrapper3;
					if (!StringMarshaller.TryMarshalEmptyOrNullString(signature, ref managedSpanWrapper4))
					{
						readOnlySpan4 = Il2CppSystem.MemoryExtensions.AsSpan(signature);
						fixed (char* begin4 = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan4)).GetPinnableReference())
						{
							managedSpanWrapper4 = new ManagedSpanWrapper(begin4, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan4)).Length);
							return Transaction_Injected(ref productId2, amount2, ref currency2, ref receiptPurchaseData2, ref managedSpanWrapper4, usingIAPService);
						}
					}
					return Transaction_Injected(ref productId2, amount2, ref currency2, ref receiptPurchaseData2, ref managedSpanWrapper4, usingIAPService);
				}
			}
			productId2 = ref managedSpanWrapper;
			amount2 = amount;
			if (!StringMarshaller.TryMarshalEmptyOrNullString(currency, ref managedSpanWrapper2))
			{
				readOnlySpan2 = Il2CppSystem.MemoryExtensions.AsSpan(currency);
				fixed (char* begin2 = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan2)).GetPinnableReference())
				{
					managedSpanWrapper2 = new ManagedSpanWrapper(begin2, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan2)).Length);
					currency2 = ref managedSpanWrapper2;
					if (!StringMarshaller.TryMarshalEmptyOrNullString(receiptPurchaseData, ref managedSpanWrapper3))
					{
						readOnlySpan3 = Il2CppSystem.MemoryExtensions.AsSpan(receiptPurchaseData);
						fixed (char* begin3 = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan3)).GetPinnableReference())
						{
							managedSpanWrapper3 = new ManagedSpanWrapper(begin3, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan3)).Length);
							receiptPurchaseData2 = ref managedSpanWrapper3;
							if (!StringMarshaller.TryMarshalEmptyOrNullString(signature, ref managedSpanWrapper4))
							{
								readOnlySpan4 = Il2CppSystem.MemoryExtensions.AsSpan(signature);
								fixed (char* begin4 = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan4)).GetPinnableReference())
								{
									managedSpanWrapper4 = new ManagedSpanWrapper(begin4, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan4)).Length);
									return Transaction_Injected(ref productId2, amount2, ref currency2, ref receiptPurchaseData2, ref managedSpanWrapper4, usingIAPService);
								}
							}
							return Transaction_Injected(ref productId2, amount2, ref currency2, ref receiptPurchaseData2, ref managedSpanWrapper4, usingIAPService);
						}
					}
					receiptPurchaseData2 = ref managedSpanWrapper3;
					if (!StringMarshaller.TryMarshalEmptyOrNullString(signature, ref managedSpanWrapper4))
					{
						readOnlySpan4 = Il2CppSystem.MemoryExtensions.AsSpan(signature);
						fixed (char* begin4 = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan4)).GetPinnableReference())
						{
							managedSpanWrapper4 = new ManagedSpanWrapper(begin4, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan4)).Length);
							return Transaction_Injected(ref productId2, amount2, ref currency2, ref receiptPurchaseData2, ref managedSpanWrapper4, usingIAPService);
						}
					}
					return Transaction_Injected(ref productId2, amount2, ref currency2, ref receiptPurchaseData2, ref managedSpanWrapper4, usingIAPService);
				}
			}
			currency2 = ref managedSpanWrapper2;
			if (!StringMarshaller.TryMarshalEmptyOrNullString(receiptPurchaseData, ref managedSpanWrapper3))
			{
				readOnlySpan3 = Il2CppSystem.MemoryExtensions.AsSpan(receiptPurchaseData);
				fixed (char* begin3 = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan3)).GetPinnableReference())
				{
					managedSpanWrapper3 = new ManagedSpanWrapper(begin3, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan3)).Length);
					receiptPurchaseData2 = ref managedSpanWrapper3;
					if (!StringMarshaller.TryMarshalEmptyOrNullString(signature, ref managedSpanWrapper4))
					{
						readOnlySpan4 = Il2CppSystem.MemoryExtensions.AsSpan(signature);
						fixed (char* begin4 = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan4)).GetPinnableReference())
						{
							managedSpanWrapper4 = new ManagedSpanWrapper(begin4, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan4)).Length);
							return Transaction_Injected(ref productId2, amount2, ref currency2, ref receiptPurchaseData2, ref managedSpanWrapper4, usingIAPService);
						}
					}
					return Transaction_Injected(ref productId2, amount2, ref currency2, ref receiptPurchaseData2, ref managedSpanWrapper4, usingIAPService);
				}
			}
			receiptPurchaseData2 = ref managedSpanWrapper3;
			if (!StringMarshaller.TryMarshalEmptyOrNullString(signature, ref managedSpanWrapper4))
			{
				readOnlySpan4 = Il2CppSystem.MemoryExtensions.AsSpan(signature);
				fixed (char* begin4 = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan4)).GetPinnableReference())
				{
					managedSpanWrapper4 = new ManagedSpanWrapper(begin4, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan4)).Length);
					return Transaction_Injected(ref productId2, amount2, ref currency2, ref receiptPurchaseData2, ref managedSpanWrapper4, usingIAPService);
				}
			}
			return Transaction_Injected(ref productId2, amount2, ref currency2, ref receiptPurchaseData2, ref managedSpanWrapper4, usingIAPService);
		}
		finally
		{
		}
	}

	public unsafe static AnalyticsResult SendCustomEventName(string customEventName)
	{
		//IL_0018: Expected O, but got Ref
		//IL_0024: Expected O, but got Ref
		//The blocks IL_0029 are reachable both inside and outside the pinned region starting at IL_0018. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(customEventName, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(customEventName);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					return SendCustomEventName_Injected(ref managedSpanWrapper);
				}
			}
			return SendCustomEventName_Injected(ref managedSpanWrapper);
		}
		finally
		{
		}
	}

	public static AnalyticsResult SendCustomEvent(CustomEventData eventData)
	{
		return SendCustomEvent_Injected((eventData == null) ? ((System.IntPtr)0) : CustomEventData.BindingsMarshaller.ConvertToNative(eventData));
	}

	public unsafe static AnalyticsResult IsCustomEventWithLimitEnabled(string customEventName)
	{
		//IL_0018: Expected O, but got Ref
		//IL_0024: Expected O, but got Ref
		//The blocks IL_0029 are reachable both inside and outside the pinned region starting at IL_0018. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(customEventName, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(customEventName);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					return IsCustomEventWithLimitEnabled_Injected(ref managedSpanWrapper);
				}
			}
			return IsCustomEventWithLimitEnabled_Injected(ref managedSpanWrapper);
		}
		finally
		{
		}
	}

	public unsafe static AnalyticsResult EnableCustomEventWithLimit(string customEventName, bool enable)
	{
		//IL_0018: Expected O, but got Ref
		//IL_0024: Expected O, but got Ref
		//The blocks IL_0029 are reachable both inside and outside the pinned region starting at IL_0018. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(customEventName, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(customEventName);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					return EnableCustomEventWithLimit_Injected(ref managedSpanWrapper, enable);
				}
			}
			return EnableCustomEventWithLimit_Injected(ref managedSpanWrapper, enable);
		}
		finally
		{
		}
	}

	public unsafe static AnalyticsResult IsEventWithLimitEnabled(string eventName, int ver, string prefix)
	{
		//IL_0018: Expected O, but got Ref
		//IL_0024: Expected O, but got Ref
		//IL_0045: Expected O, but got Ref
		//IL_0053: Expected O, but got Ref
		//The blocks IL_0029, IL_0037, IL_0045, IL_0053, IL_0058 are reachable both inside and outside the pinned region starting at IL_0018. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		//The blocks IL_0058 are reachable both inside and outside the pinned region starting at IL_0045. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		//The blocks IL_0058 are reachable both inside and outside the pinned region starting at IL_0045. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			ref ManagedSpanWrapper eventName2;
			int ver2;
			Il2CppSystem.ReadOnlySpan<char> readOnlySpan2;
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper2);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(eventName, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(eventName);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					eventName2 = ref managedSpanWrapper;
					ver2 = ver;
					if (!StringMarshaller.TryMarshalEmptyOrNullString(prefix, ref managedSpanWrapper2))
					{
						readOnlySpan2 = Il2CppSystem.MemoryExtensions.AsSpan(prefix);
						fixed (char* begin2 = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan2)).GetPinnableReference())
						{
							managedSpanWrapper2 = new ManagedSpanWrapper(begin2, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan2)).Length);
							return IsEventWithLimitEnabled_Injected(ref eventName2, ver2, ref managedSpanWrapper2);
						}
					}
					return IsEventWithLimitEnabled_Injected(ref eventName2, ver2, ref managedSpanWrapper2);
				}
			}
			eventName2 = ref managedSpanWrapper;
			ver2 = ver;
			if (!StringMarshaller.TryMarshalEmptyOrNullString(prefix, ref managedSpanWrapper2))
			{
				readOnlySpan2 = Il2CppSystem.MemoryExtensions.AsSpan(prefix);
				fixed (char* begin2 = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan2)).GetPinnableReference())
				{
					managedSpanWrapper2 = new ManagedSpanWrapper(begin2, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan2)).Length);
					return IsEventWithLimitEnabled_Injected(ref eventName2, ver2, ref managedSpanWrapper2);
				}
			}
			return IsEventWithLimitEnabled_Injected(ref eventName2, ver2, ref managedSpanWrapper2);
		}
		finally
		{
		}
	}

	public unsafe static AnalyticsResult EnableEventWithLimit(string eventName, bool enable, int ver, string prefix)
	{
		//IL_0018: Expected O, but got Ref
		//IL_0024: Expected O, but got Ref
		//IL_0046: Expected O, but got Ref
		//IL_0054: Expected O, but got Ref
		//The blocks IL_0029, IL_0038, IL_0046, IL_0054, IL_0059 are reachable both inside and outside the pinned region starting at IL_0018. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		//The blocks IL_0059 are reachable both inside and outside the pinned region starting at IL_0046. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		//The blocks IL_0059 are reachable both inside and outside the pinned region starting at IL_0046. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			ref ManagedSpanWrapper eventName2;
			bool enable2;
			int ver2;
			Il2CppSystem.ReadOnlySpan<char> readOnlySpan2;
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper2);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(eventName, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(eventName);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					eventName2 = ref managedSpanWrapper;
					enable2 = enable;
					ver2 = ver;
					if (!StringMarshaller.TryMarshalEmptyOrNullString(prefix, ref managedSpanWrapper2))
					{
						readOnlySpan2 = Il2CppSystem.MemoryExtensions.AsSpan(prefix);
						fixed (char* begin2 = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan2)).GetPinnableReference())
						{
							managedSpanWrapper2 = new ManagedSpanWrapper(begin2, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan2)).Length);
							return EnableEventWithLimit_Injected(ref eventName2, enable2, ver2, ref managedSpanWrapper2);
						}
					}
					return EnableEventWithLimit_Injected(ref eventName2, enable2, ver2, ref managedSpanWrapper2);
				}
			}
			eventName2 = ref managedSpanWrapper;
			enable2 = enable;
			ver2 = ver;
			if (!StringMarshaller.TryMarshalEmptyOrNullString(prefix, ref managedSpanWrapper2))
			{
				readOnlySpan2 = Il2CppSystem.MemoryExtensions.AsSpan(prefix);
				fixed (char* begin2 = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan2)).GetPinnableReference())
				{
					managedSpanWrapper2 = new ManagedSpanWrapper(begin2, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan2)).Length);
					return EnableEventWithLimit_Injected(ref eventName2, enable2, ver2, ref managedSpanWrapper2);
				}
			}
			return EnableEventWithLimit_Injected(ref eventName2, enable2, ver2, ref managedSpanWrapper2);
		}
		finally
		{
		}
	}

	public unsafe static AnalyticsResult RegisterEventWithLimit(string eventName, int maxEventPerHour, int maxItems, string vendorKey, int ver, string prefix, string assemblyInfo, bool notifyServer)
	{
		//IL_0018: Expected O, but got Ref
		//IL_0024: Expected O, but got Ref
		//IL_0046: Expected O, but got Ref
		//IL_0054: Expected O, but got Ref
		//IL_0079: Expected O, but got Ref
		//IL_0087: Expected O, but got Ref
		//IL_00aa: Expected O, but got Ref
		//IL_00b8: Expected O, but got Ref
		//The blocks IL_0029, IL_0038, IL_0046, IL_0054, IL_0059, IL_0069, IL_0079, IL_0087, IL_008c, IL_009a, IL_00aa, IL_00b8, IL_00bd are reachable both inside and outside the pinned region starting at IL_0018. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		//The blocks IL_0059, IL_0069, IL_0079, IL_0087, IL_008c, IL_009a, IL_00aa, IL_00b8, IL_00bd are reachable both inside and outside the pinned region starting at IL_0046. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		//The blocks IL_008c, IL_009a, IL_00aa, IL_00b8, IL_00bd are reachable both inside and outside the pinned region starting at IL_0079. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		//The blocks IL_00bd are reachable both inside and outside the pinned region starting at IL_00aa. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		//The blocks IL_00bd are reachable both inside and outside the pinned region starting at IL_00aa. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		//The blocks IL_008c, IL_009a, IL_00aa, IL_00b8, IL_00bd are reachable both inside and outside the pinned region starting at IL_0079. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		//The blocks IL_00bd are reachable both inside and outside the pinned region starting at IL_00aa. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		//The blocks IL_00bd are reachable both inside and outside the pinned region starting at IL_00aa. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		//The blocks IL_0059, IL_0069, IL_0079, IL_0087, IL_008c, IL_009a, IL_00aa, IL_00b8, IL_00bd are reachable both inside and outside the pinned region starting at IL_0046. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		//The blocks IL_008c, IL_009a, IL_00aa, IL_00b8, IL_00bd are reachable both inside and outside the pinned region starting at IL_0079. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		//The blocks IL_00bd are reachable both inside and outside the pinned region starting at IL_00aa. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		//The blocks IL_00bd are reachable both inside and outside the pinned region starting at IL_00aa. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		//The blocks IL_008c, IL_009a, IL_00aa, IL_00b8, IL_00bd are reachable both inside and outside the pinned region starting at IL_0079. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		//The blocks IL_00bd are reachable both inside and outside the pinned region starting at IL_00aa. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		//The blocks IL_00bd are reachable both inside and outside the pinned region starting at IL_00aa. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			ref ManagedSpanWrapper eventName2;
			int maxEventPerHour2;
			int maxItems2;
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper2);
			Il2CppSystem.ReadOnlySpan<char> readOnlySpan2;
			ref ManagedSpanWrapper vendorKey2;
			int ver2;
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper3);
			Il2CppSystem.ReadOnlySpan<char> readOnlySpan3;
			ref ManagedSpanWrapper prefix2;
			Il2CppSystem.ReadOnlySpan<char> readOnlySpan4;
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper4);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(eventName, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(eventName);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					eventName2 = ref managedSpanWrapper;
					maxEventPerHour2 = maxEventPerHour;
					maxItems2 = maxItems;
					if (!StringMarshaller.TryMarshalEmptyOrNullString(vendorKey, ref managedSpanWrapper2))
					{
						readOnlySpan2 = Il2CppSystem.MemoryExtensions.AsSpan(vendorKey);
						fixed (char* begin2 = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan2)).GetPinnableReference())
						{
							managedSpanWrapper2 = new ManagedSpanWrapper(begin2, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan2)).Length);
							vendorKey2 = ref managedSpanWrapper2;
							ver2 = ver;
							if (!StringMarshaller.TryMarshalEmptyOrNullString(prefix, ref managedSpanWrapper3))
							{
								readOnlySpan3 = Il2CppSystem.MemoryExtensions.AsSpan(prefix);
								fixed (char* begin3 = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan3)).GetPinnableReference())
								{
									managedSpanWrapper3 = new ManagedSpanWrapper(begin3, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan3)).Length);
									prefix2 = ref managedSpanWrapper3;
									if (!StringMarshaller.TryMarshalEmptyOrNullString(assemblyInfo, ref managedSpanWrapper4))
									{
										readOnlySpan4 = Il2CppSystem.MemoryExtensions.AsSpan(assemblyInfo);
										fixed (char* begin4 = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan4)).GetPinnableReference())
										{
											managedSpanWrapper4 = new ManagedSpanWrapper(begin4, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan4)).Length);
											return RegisterEventWithLimit_Injected(ref eventName2, maxEventPerHour2, maxItems2, ref vendorKey2, ver2, ref prefix2, ref managedSpanWrapper4, notifyServer);
										}
									}
									return RegisterEventWithLimit_Injected(ref eventName2, maxEventPerHour2, maxItems2, ref vendorKey2, ver2, ref prefix2, ref managedSpanWrapper4, notifyServer);
								}
							}
							prefix2 = ref managedSpanWrapper3;
							if (!StringMarshaller.TryMarshalEmptyOrNullString(assemblyInfo, ref managedSpanWrapper4))
							{
								readOnlySpan4 = Il2CppSystem.MemoryExtensions.AsSpan(assemblyInfo);
								fixed (char* begin4 = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan4)).GetPinnableReference())
								{
									managedSpanWrapper4 = new ManagedSpanWrapper(begin4, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan4)).Length);
									return RegisterEventWithLimit_Injected(ref eventName2, maxEventPerHour2, maxItems2, ref vendorKey2, ver2, ref prefix2, ref managedSpanWrapper4, notifyServer);
								}
							}
							return RegisterEventWithLimit_Injected(ref eventName2, maxEventPerHour2, maxItems2, ref vendorKey2, ver2, ref prefix2, ref managedSpanWrapper4, notifyServer);
						}
					}
					vendorKey2 = ref managedSpanWrapper2;
					ver2 = ver;
					if (!StringMarshaller.TryMarshalEmptyOrNullString(prefix, ref managedSpanWrapper3))
					{
						readOnlySpan3 = Il2CppSystem.MemoryExtensions.AsSpan(prefix);
						fixed (char* begin3 = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan3)).GetPinnableReference())
						{
							managedSpanWrapper3 = new ManagedSpanWrapper(begin3, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan3)).Length);
							prefix2 = ref managedSpanWrapper3;
							if (!StringMarshaller.TryMarshalEmptyOrNullString(assemblyInfo, ref managedSpanWrapper4))
							{
								readOnlySpan4 = Il2CppSystem.MemoryExtensions.AsSpan(assemblyInfo);
								fixed (char* begin4 = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan4)).GetPinnableReference())
								{
									managedSpanWrapper4 = new ManagedSpanWrapper(begin4, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan4)).Length);
									return RegisterEventWithLimit_Injected(ref eventName2, maxEventPerHour2, maxItems2, ref vendorKey2, ver2, ref prefix2, ref managedSpanWrapper4, notifyServer);
								}
							}
							return RegisterEventWithLimit_Injected(ref eventName2, maxEventPerHour2, maxItems2, ref vendorKey2, ver2, ref prefix2, ref managedSpanWrapper4, notifyServer);
						}
					}
					prefix2 = ref managedSpanWrapper3;
					if (!StringMarshaller.TryMarshalEmptyOrNullString(assemblyInfo, ref managedSpanWrapper4))
					{
						readOnlySpan4 = Il2CppSystem.MemoryExtensions.AsSpan(assemblyInfo);
						fixed (char* begin4 = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan4)).GetPinnableReference())
						{
							managedSpanWrapper4 = new ManagedSpanWrapper(begin4, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan4)).Length);
							return RegisterEventWithLimit_Injected(ref eventName2, maxEventPerHour2, maxItems2, ref vendorKey2, ver2, ref prefix2, ref managedSpanWrapper4, notifyServer);
						}
					}
					return RegisterEventWithLimit_Injected(ref eventName2, maxEventPerHour2, maxItems2, ref vendorKey2, ver2, ref prefix2, ref managedSpanWrapper4, notifyServer);
				}
			}
			eventName2 = ref managedSpanWrapper;
			maxEventPerHour2 = maxEventPerHour;
			maxItems2 = maxItems;
			if (!StringMarshaller.TryMarshalEmptyOrNullString(vendorKey, ref managedSpanWrapper2))
			{
				readOnlySpan2 = Il2CppSystem.MemoryExtensions.AsSpan(vendorKey);
				fixed (char* begin2 = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan2)).GetPinnableReference())
				{
					managedSpanWrapper2 = new ManagedSpanWrapper(begin2, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan2)).Length);
					vendorKey2 = ref managedSpanWrapper2;
					ver2 = ver;
					if (!StringMarshaller.TryMarshalEmptyOrNullString(prefix, ref managedSpanWrapper3))
					{
						readOnlySpan3 = Il2CppSystem.MemoryExtensions.AsSpan(prefix);
						fixed (char* begin3 = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan3)).GetPinnableReference())
						{
							managedSpanWrapper3 = new ManagedSpanWrapper(begin3, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan3)).Length);
							prefix2 = ref managedSpanWrapper3;
							if (!StringMarshaller.TryMarshalEmptyOrNullString(assemblyInfo, ref managedSpanWrapper4))
							{
								readOnlySpan4 = Il2CppSystem.MemoryExtensions.AsSpan(assemblyInfo);
								fixed (char* begin4 = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan4)).GetPinnableReference())
								{
									managedSpanWrapper4 = new ManagedSpanWrapper(begin4, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan4)).Length);
									return RegisterEventWithLimit_Injected(ref eventName2, maxEventPerHour2, maxItems2, ref vendorKey2, ver2, ref prefix2, ref managedSpanWrapper4, notifyServer);
								}
							}
							return RegisterEventWithLimit_Injected(ref eventName2, maxEventPerHour2, maxItems2, ref vendorKey2, ver2, ref prefix2, ref managedSpanWrapper4, notifyServer);
						}
					}
					prefix2 = ref managedSpanWrapper3;
					if (!StringMarshaller.TryMarshalEmptyOrNullString(assemblyInfo, ref managedSpanWrapper4))
					{
						readOnlySpan4 = Il2CppSystem.MemoryExtensions.AsSpan(assemblyInfo);
						fixed (char* begin4 = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan4)).GetPinnableReference())
						{
							managedSpanWrapper4 = new ManagedSpanWrapper(begin4, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan4)).Length);
							return RegisterEventWithLimit_Injected(ref eventName2, maxEventPerHour2, maxItems2, ref vendorKey2, ver2, ref prefix2, ref managedSpanWrapper4, notifyServer);
						}
					}
					return RegisterEventWithLimit_Injected(ref eventName2, maxEventPerHour2, maxItems2, ref vendorKey2, ver2, ref prefix2, ref managedSpanWrapper4, notifyServer);
				}
			}
			vendorKey2 = ref managedSpanWrapper2;
			ver2 = ver;
			if (!StringMarshaller.TryMarshalEmptyOrNullString(prefix, ref managedSpanWrapper3))
			{
				readOnlySpan3 = Il2CppSystem.MemoryExtensions.AsSpan(prefix);
				fixed (char* begin3 = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan3)).GetPinnableReference())
				{
					managedSpanWrapper3 = new ManagedSpanWrapper(begin3, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan3)).Length);
					prefix2 = ref managedSpanWrapper3;
					if (!StringMarshaller.TryMarshalEmptyOrNullString(assemblyInfo, ref managedSpanWrapper4))
					{
						readOnlySpan4 = Il2CppSystem.MemoryExtensions.AsSpan(assemblyInfo);
						fixed (char* begin4 = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan4)).GetPinnableReference())
						{
							managedSpanWrapper4 = new ManagedSpanWrapper(begin4, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan4)).Length);
							return RegisterEventWithLimit_Injected(ref eventName2, maxEventPerHour2, maxItems2, ref vendorKey2, ver2, ref prefix2, ref managedSpanWrapper4, notifyServer);
						}
					}
					return RegisterEventWithLimit_Injected(ref eventName2, maxEventPerHour2, maxItems2, ref vendorKey2, ver2, ref prefix2, ref managedSpanWrapper4, notifyServer);
				}
			}
			prefix2 = ref managedSpanWrapper3;
			if (!StringMarshaller.TryMarshalEmptyOrNullString(assemblyInfo, ref managedSpanWrapper4))
			{
				readOnlySpan4 = Il2CppSystem.MemoryExtensions.AsSpan(assemblyInfo);
				fixed (char* begin4 = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan4)).GetPinnableReference())
				{
					managedSpanWrapper4 = new ManagedSpanWrapper(begin4, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan4)).Length);
					return RegisterEventWithLimit_Injected(ref eventName2, maxEventPerHour2, maxItems2, ref vendorKey2, ver2, ref prefix2, ref managedSpanWrapper4, notifyServer);
				}
			}
			return RegisterEventWithLimit_Injected(ref eventName2, maxEventPerHour2, maxItems2, ref vendorKey2, ver2, ref prefix2, ref managedSpanWrapper4, notifyServer);
		}
		finally
		{
		}
	}

	public unsafe static AnalyticsResult RegisterEventsWithLimit(Il2CppStringArray eventName, int maxEventPerHour, int maxItems, string vendorKey, int ver, string prefix, string assemblyInfo, bool notifyServer)
	{
		//IL_001b: Expected O, but got Ref
		//IL_0027: Expected O, but got Ref
		//IL_004b: Expected O, but got Ref
		//IL_0059: Expected O, but got Ref
		//IL_007c: Expected O, but got Ref
		//IL_008a: Expected O, but got Ref
		//The blocks IL_002c, IL_003c, IL_004b, IL_0059, IL_005e, IL_006c, IL_007c, IL_008a, IL_008f are reachable both inside and outside the pinned region starting at IL_001b. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		//The blocks IL_005e, IL_006c, IL_007c, IL_008a, IL_008f are reachable both inside and outside the pinned region starting at IL_004b. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		//The blocks IL_008f are reachable both inside and outside the pinned region starting at IL_007c. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		//The blocks IL_008f are reachable both inside and outside the pinned region starting at IL_007c. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		//The blocks IL_005e, IL_006c, IL_007c, IL_008a, IL_008f are reachable both inside and outside the pinned region starting at IL_004b. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		//The blocks IL_008f are reachable both inside and outside the pinned region starting at IL_007c. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		//The blocks IL_008f are reachable both inside and outside the pinned region starting at IL_007c. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			ref ManagedSpanWrapper vendorKey2;
			int ver2;
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper2);
			Il2CppSystem.ReadOnlySpan<char> readOnlySpan2;
			ref ManagedSpanWrapper prefix2;
			Il2CppSystem.ReadOnlySpan<char> readOnlySpan3;
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper3);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(vendorKey, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(vendorKey);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					vendorKey2 = ref managedSpanWrapper;
					ver2 = ver;
					if (!StringMarshaller.TryMarshalEmptyOrNullString(prefix, ref managedSpanWrapper2))
					{
						readOnlySpan2 = Il2CppSystem.MemoryExtensions.AsSpan(prefix);
						fixed (char* begin2 = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan2)).GetPinnableReference())
						{
							managedSpanWrapper2 = new ManagedSpanWrapper(begin2, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan2)).Length);
							prefix2 = ref managedSpanWrapper2;
							if (!StringMarshaller.TryMarshalEmptyOrNullString(assemblyInfo, ref managedSpanWrapper3))
							{
								readOnlySpan3 = Il2CppSystem.MemoryExtensions.AsSpan(assemblyInfo);
								fixed (char* begin3 = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan3)).GetPinnableReference())
								{
									managedSpanWrapper3 = new ManagedSpanWrapper(begin3, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan3)).Length);
									return RegisterEventsWithLimit_Injected(eventName, maxEventPerHour, maxItems, ref vendorKey2, ver2, ref prefix2, ref managedSpanWrapper3, notifyServer);
								}
							}
							return RegisterEventsWithLimit_Injected(eventName, maxEventPerHour, maxItems, ref vendorKey2, ver2, ref prefix2, ref managedSpanWrapper3, notifyServer);
						}
					}
					prefix2 = ref managedSpanWrapper2;
					if (!StringMarshaller.TryMarshalEmptyOrNullString(assemblyInfo, ref managedSpanWrapper3))
					{
						readOnlySpan3 = Il2CppSystem.MemoryExtensions.AsSpan(assemblyInfo);
						fixed (char* begin3 = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan3)).GetPinnableReference())
						{
							managedSpanWrapper3 = new ManagedSpanWrapper(begin3, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan3)).Length);
							return RegisterEventsWithLimit_Injected(eventName, maxEventPerHour, maxItems, ref vendorKey2, ver2, ref prefix2, ref managedSpanWrapper3, notifyServer);
						}
					}
					return RegisterEventsWithLimit_Injected(eventName, maxEventPerHour, maxItems, ref vendorKey2, ver2, ref prefix2, ref managedSpanWrapper3, notifyServer);
				}
			}
			vendorKey2 = ref managedSpanWrapper;
			ver2 = ver;
			if (!StringMarshaller.TryMarshalEmptyOrNullString(prefix, ref managedSpanWrapper2))
			{
				readOnlySpan2 = Il2CppSystem.MemoryExtensions.AsSpan(prefix);
				fixed (char* begin2 = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan2)).GetPinnableReference())
				{
					managedSpanWrapper2 = new ManagedSpanWrapper(begin2, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan2)).Length);
					prefix2 = ref managedSpanWrapper2;
					if (!StringMarshaller.TryMarshalEmptyOrNullString(assemblyInfo, ref managedSpanWrapper3))
					{
						readOnlySpan3 = Il2CppSystem.MemoryExtensions.AsSpan(assemblyInfo);
						fixed (char* begin3 = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan3)).GetPinnableReference())
						{
							managedSpanWrapper3 = new ManagedSpanWrapper(begin3, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan3)).Length);
							return RegisterEventsWithLimit_Injected(eventName, maxEventPerHour, maxItems, ref vendorKey2, ver2, ref prefix2, ref managedSpanWrapper3, notifyServer);
						}
					}
					return RegisterEventsWithLimit_Injected(eventName, maxEventPerHour, maxItems, ref vendorKey2, ver2, ref prefix2, ref managedSpanWrapper3, notifyServer);
				}
			}
			prefix2 = ref managedSpanWrapper2;
			if (!StringMarshaller.TryMarshalEmptyOrNullString(assemblyInfo, ref managedSpanWrapper3))
			{
				readOnlySpan3 = Il2CppSystem.MemoryExtensions.AsSpan(assemblyInfo);
				fixed (char* begin3 = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan3)).GetPinnableReference())
				{
					managedSpanWrapper3 = new ManagedSpanWrapper(begin3, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan3)).Length);
					return RegisterEventsWithLimit_Injected(eventName, maxEventPerHour, maxItems, ref vendorKey2, ver2, ref prefix2, ref managedSpanWrapper3, notifyServer);
				}
			}
			return RegisterEventsWithLimit_Injected(eventName, maxEventPerHour, maxItems, ref vendorKey2, ver2, ref prefix2, ref managedSpanWrapper3, notifyServer);
		}
		finally
		{
		}
	}

	public unsafe static AnalyticsResult SendEventWithLimit(string eventName, Il2CppSystem.Object parameters, int ver, string prefix)
	{
		//IL_0018: Expected O, but got Ref
		//IL_0024: Expected O, but got Ref
		//IL_0046: Expected O, but got Ref
		//IL_0054: Expected O, but got Ref
		//The blocks IL_0029, IL_0038, IL_0046, IL_0054, IL_0059 are reachable both inside and outside the pinned region starting at IL_0018. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		//The blocks IL_0059 are reachable both inside and outside the pinned region starting at IL_0046. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		//The blocks IL_0059 are reachable both inside and outside the pinned region starting at IL_0046. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			ref ManagedSpanWrapper eventName2;
			Il2CppSystem.Object parameters2;
			int ver2;
			Il2CppSystem.ReadOnlySpan<char> readOnlySpan2;
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper2);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(eventName, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(eventName);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					eventName2 = ref managedSpanWrapper;
					parameters2 = parameters;
					ver2 = ver;
					if (!StringMarshaller.TryMarshalEmptyOrNullString(prefix, ref managedSpanWrapper2))
					{
						readOnlySpan2 = Il2CppSystem.MemoryExtensions.AsSpan(prefix);
						fixed (char* begin2 = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan2)).GetPinnableReference())
						{
							managedSpanWrapper2 = new ManagedSpanWrapper(begin2, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan2)).Length);
							return SendEventWithLimit_Injected(ref eventName2, parameters2, ver2, ref managedSpanWrapper2);
						}
					}
					return SendEventWithLimit_Injected(ref eventName2, parameters2, ver2, ref managedSpanWrapper2);
				}
			}
			eventName2 = ref managedSpanWrapper;
			parameters2 = parameters;
			ver2 = ver;
			if (!StringMarshaller.TryMarshalEmptyOrNullString(prefix, ref managedSpanWrapper2))
			{
				readOnlySpan2 = Il2CppSystem.MemoryExtensions.AsSpan(prefix);
				fixed (char* begin2 = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan2)).GetPinnableReference())
				{
					managedSpanWrapper2 = new ManagedSpanWrapper(begin2, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan2)).Length);
					return SendEventWithLimit_Injected(ref eventName2, parameters2, ver2, ref managedSpanWrapper2);
				}
			}
			return SendEventWithLimit_Injected(ref eventName2, parameters2, ver2, ref managedSpanWrapper2);
		}
		finally
		{
		}
	}

	public unsafe static AnalyticsResult SetEventWithLimitEndPoint(string eventName, string endPoint, int ver, string prefix)
	{
		//IL_0018: Expected O, but got Ref
		//IL_0024: Expected O, but got Ref
		//IL_0044: Expected O, but got Ref
		//IL_0052: Expected O, but got Ref
		//IL_0074: Expected O, but got Ref
		//IL_0082: Expected O, but got Ref
		//The blocks IL_0029, IL_0036, IL_0044, IL_0052, IL_0057, IL_0065, IL_0074, IL_0082, IL_0087 are reachable both inside and outside the pinned region starting at IL_0018. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		//The blocks IL_0057, IL_0065, IL_0074, IL_0082, IL_0087 are reachable both inside and outside the pinned region starting at IL_0044. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		//The blocks IL_0087 are reachable both inside and outside the pinned region starting at IL_0074. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		//The blocks IL_0087 are reachable both inside and outside the pinned region starting at IL_0074. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		//The blocks IL_0057, IL_0065, IL_0074, IL_0082, IL_0087 are reachable both inside and outside the pinned region starting at IL_0044. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		//The blocks IL_0087 are reachable both inside and outside the pinned region starting at IL_0074. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		//The blocks IL_0087 are reachable both inside and outside the pinned region starting at IL_0074. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			ref ManagedSpanWrapper eventName2;
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper2);
			Il2CppSystem.ReadOnlySpan<char> readOnlySpan2;
			ref ManagedSpanWrapper endPoint2;
			int ver2;
			Il2CppSystem.ReadOnlySpan<char> readOnlySpan3;
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper3);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(eventName, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(eventName);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					eventName2 = ref managedSpanWrapper;
					if (!StringMarshaller.TryMarshalEmptyOrNullString(endPoint, ref managedSpanWrapper2))
					{
						readOnlySpan2 = Il2CppSystem.MemoryExtensions.AsSpan(endPoint);
						fixed (char* begin2 = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan2)).GetPinnableReference())
						{
							managedSpanWrapper2 = new ManagedSpanWrapper(begin2, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan2)).Length);
							endPoint2 = ref managedSpanWrapper2;
							ver2 = ver;
							if (!StringMarshaller.TryMarshalEmptyOrNullString(prefix, ref managedSpanWrapper3))
							{
								readOnlySpan3 = Il2CppSystem.MemoryExtensions.AsSpan(prefix);
								fixed (char* begin3 = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan3)).GetPinnableReference())
								{
									managedSpanWrapper3 = new ManagedSpanWrapper(begin3, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan3)).Length);
									return SetEventWithLimitEndPoint_Injected(ref eventName2, ref endPoint2, ver2, ref managedSpanWrapper3);
								}
							}
							return SetEventWithLimitEndPoint_Injected(ref eventName2, ref endPoint2, ver2, ref managedSpanWrapper3);
						}
					}
					endPoint2 = ref managedSpanWrapper2;
					ver2 = ver;
					if (!StringMarshaller.TryMarshalEmptyOrNullString(prefix, ref managedSpanWrapper3))
					{
						readOnlySpan3 = Il2CppSystem.MemoryExtensions.AsSpan(prefix);
						fixed (char* begin3 = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan3)).GetPinnableReference())
						{
							managedSpanWrapper3 = new ManagedSpanWrapper(begin3, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan3)).Length);
							return SetEventWithLimitEndPoint_Injected(ref eventName2, ref endPoint2, ver2, ref managedSpanWrapper3);
						}
					}
					return SetEventWithLimitEndPoint_Injected(ref eventName2, ref endPoint2, ver2, ref managedSpanWrapper3);
				}
			}
			eventName2 = ref managedSpanWrapper;
			if (!StringMarshaller.TryMarshalEmptyOrNullString(endPoint, ref managedSpanWrapper2))
			{
				readOnlySpan2 = Il2CppSystem.MemoryExtensions.AsSpan(endPoint);
				fixed (char* begin2 = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan2)).GetPinnableReference())
				{
					managedSpanWrapper2 = new ManagedSpanWrapper(begin2, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan2)).Length);
					endPoint2 = ref managedSpanWrapper2;
					ver2 = ver;
					if (!StringMarshaller.TryMarshalEmptyOrNullString(prefix, ref managedSpanWrapper3))
					{
						readOnlySpan3 = Il2CppSystem.MemoryExtensions.AsSpan(prefix);
						fixed (char* begin3 = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan3)).GetPinnableReference())
						{
							managedSpanWrapper3 = new ManagedSpanWrapper(begin3, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan3)).Length);
							return SetEventWithLimitEndPoint_Injected(ref eventName2, ref endPoint2, ver2, ref managedSpanWrapper3);
						}
					}
					return SetEventWithLimitEndPoint_Injected(ref eventName2, ref endPoint2, ver2, ref managedSpanWrapper3);
				}
			}
			endPoint2 = ref managedSpanWrapper2;
			ver2 = ver;
			if (!StringMarshaller.TryMarshalEmptyOrNullString(prefix, ref managedSpanWrapper3))
			{
				readOnlySpan3 = Il2CppSystem.MemoryExtensions.AsSpan(prefix);
				fixed (char* begin3 = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan3)).GetPinnableReference())
				{
					managedSpanWrapper3 = new ManagedSpanWrapper(begin3, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan3)).Length);
					return SetEventWithLimitEndPoint_Injected(ref eventName2, ref endPoint2, ver2, ref managedSpanWrapper3);
				}
			}
			return SetEventWithLimitEndPoint_Injected(ref eventName2, ref endPoint2, ver2, ref managedSpanWrapper3);
		}
		finally
		{
		}
	}

	public unsafe static AnalyticsResult SetEventWithLimitPriority(string eventName, AnalyticsEventPriority eventPriority, int ver, string prefix)
	{
		//IL_0018: Expected O, but got Ref
		//IL_0024: Expected O, but got Ref
		//IL_0046: Expected O, but got Ref
		//IL_0054: Expected O, but got Ref
		//The blocks IL_0029, IL_0038, IL_0046, IL_0054, IL_0059 are reachable both inside and outside the pinned region starting at IL_0018. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		//The blocks IL_0059 are reachable both inside and outside the pinned region starting at IL_0046. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		//The blocks IL_0059 are reachable both inside and outside the pinned region starting at IL_0046. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			ref ManagedSpanWrapper eventName2;
			AnalyticsEventPriority eventPriority2;
			int ver2;
			Il2CppSystem.ReadOnlySpan<char> readOnlySpan2;
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper2);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(eventName, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(eventName);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					eventName2 = ref managedSpanWrapper;
					eventPriority2 = eventPriority;
					ver2 = ver;
					if (!StringMarshaller.TryMarshalEmptyOrNullString(prefix, ref managedSpanWrapper2))
					{
						readOnlySpan2 = Il2CppSystem.MemoryExtensions.AsSpan(prefix);
						fixed (char* begin2 = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan2)).GetPinnableReference())
						{
							managedSpanWrapper2 = new ManagedSpanWrapper(begin2, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan2)).Length);
							return SetEventWithLimitPriority_Injected(ref eventName2, eventPriority2, ver2, ref managedSpanWrapper2);
						}
					}
					return SetEventWithLimitPriority_Injected(ref eventName2, eventPriority2, ver2, ref managedSpanWrapper2);
				}
			}
			eventName2 = ref managedSpanWrapper;
			eventPriority2 = eventPriority;
			ver2 = ver;
			if (!StringMarshaller.TryMarshalEmptyOrNullString(prefix, ref managedSpanWrapper2))
			{
				readOnlySpan2 = Il2CppSystem.MemoryExtensions.AsSpan(prefix);
				fixed (char* begin2 = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan2)).GetPinnableReference())
				{
					managedSpanWrapper2 = new ManagedSpanWrapper(begin2, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan2)).Length);
					return SetEventWithLimitPriority_Injected(ref eventName2, eventPriority2, ver2, ref managedSpanWrapper2);
				}
			}
			return SetEventWithLimitPriority_Injected(ref eventName2, eventPriority2, ver2, ref managedSpanWrapper2);
		}
		finally
		{
		}
	}

	public unsafe static AnalyticsResult QueueEvent(string eventName, Il2CppSystem.Object parameters, int ver, string prefix)
	{
		//IL_0018: Expected O, but got Ref
		//IL_0024: Expected O, but got Ref
		//IL_0046: Expected O, but got Ref
		//IL_0054: Expected O, but got Ref
		//The blocks IL_0029, IL_0038, IL_0046, IL_0054, IL_0059 are reachable both inside and outside the pinned region starting at IL_0018. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		//The blocks IL_0059 are reachable both inside and outside the pinned region starting at IL_0046. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		//The blocks IL_0059 are reachable both inside and outside the pinned region starting at IL_0046. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			ref ManagedSpanWrapper eventName2;
			Il2CppSystem.Object parameters2;
			int ver2;
			Il2CppSystem.ReadOnlySpan<char> readOnlySpan2;
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper2);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(eventName, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(eventName);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					eventName2 = ref managedSpanWrapper;
					parameters2 = parameters;
					ver2 = ver;
					if (!StringMarshaller.TryMarshalEmptyOrNullString(prefix, ref managedSpanWrapper2))
					{
						readOnlySpan2 = Il2CppSystem.MemoryExtensions.AsSpan(prefix);
						fixed (char* begin2 = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan2)).GetPinnableReference())
						{
							managedSpanWrapper2 = new ManagedSpanWrapper(begin2, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan2)).Length);
							return QueueEvent_Injected(ref eventName2, parameters2, ver2, ref managedSpanWrapper2);
						}
					}
					return QueueEvent_Injected(ref eventName2, parameters2, ver2, ref managedSpanWrapper2);
				}
			}
			eventName2 = ref managedSpanWrapper;
			parameters2 = parameters;
			ver2 = ver;
			if (!StringMarshaller.TryMarshalEmptyOrNullString(prefix, ref managedSpanWrapper2))
			{
				readOnlySpan2 = Il2CppSystem.MemoryExtensions.AsSpan(prefix);
				fixed (char* begin2 = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan2)).GetPinnableReference())
				{
					managedSpanWrapper2 = new ManagedSpanWrapper(begin2, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan2)).Length);
					return QueueEvent_Injected(ref eventName2, parameters2, ver2, ref managedSpanWrapper2);
				}
			}
			return QueueEvent_Injected(ref eventName2, parameters2, ver2, ref managedSpanWrapper2);
		}
		finally
		{
		}
	}

	public static AnalyticsResult FlushEvents()
	{
		if (!IsInitialized())
		{
			return AnalyticsResult.NotInitialized;
		}
		return (!FlushArchivedEvents()) ? AnalyticsResult.NotInitialized : AnalyticsResult.Ok;
	}

	public static AnalyticsResult SetUserId(string userId)
	{
		if (Il2CppSystem.String.IsNullOrEmpty(userId))
		{
			throw new Il2CppSystem.ArgumentException("Cannot set userId to an empty or null string");
		}
		return AnalyticsResult.InvalidData;
	}

	public static AnalyticsResult SetUserGender(Gender gender)
	{
		return AnalyticsResult.InvalidData;
	}

	public static AnalyticsResult SetUserBirthYear(int birthYear)
	{
		return AnalyticsResult.InvalidData;
	}

	public static AnalyticsResult SendUserInfoEvent(Il2CppSystem.Object param)
	{
		return AnalyticsResult.InvalidData;
	}

	public static AnalyticsResult Transaction(string productId, Il2CppSystem.Decimal amount, string currency)
	{
		return Transaction(productId, amount, currency, null, null, usingIAPService: false);
	}

	public static AnalyticsResult Transaction(string productId, Il2CppSystem.Decimal amount, string currency, string receiptPurchaseData, string signature)
	{
		return Transaction(productId, amount, currency, receiptPurchaseData, signature, usingIAPService: false);
	}

	public static AnalyticsResult Transaction(string productId, Il2CppSystem.Decimal amount, string currency, string receiptPurchaseData, string signature, bool usingIAPService)
	{
		if (Il2CppSystem.String.IsNullOrEmpty(productId))
		{
			throw new Il2CppSystem.ArgumentException("Cannot set productId to an empty or null string");
		}
		if (Il2CppSystem.String.IsNullOrEmpty(currency))
		{
			throw new Il2CppSystem.ArgumentException("Cannot set currency to an empty or null string");
		}
		if (!IsInitialized())
		{
			return AnalyticsResult.NotInitialized;
		}
		if (receiptPurchaseData == null)
		{
			receiptPurchaseData = Il2CppSystem.String.Empty;
		}
		if (signature == null)
		{
			signature = Il2CppSystem.String.Empty;
		}
		return Transaction(productId, Il2CppSystem.Convert.ToDouble(amount), currency, receiptPurchaseData, signature, usingIAPService);
	}

	public static AnalyticsResult CustomEvent(string customEventName)
	{
		if (Il2CppSystem.String.IsNullOrEmpty(customEventName))
		{
			throw new Il2CppSystem.ArgumentException("Cannot set custom event name to an empty or null string");
		}
		if (!IsInitialized())
		{
			return AnalyticsResult.NotInitialized;
		}
		return SendCustomEventName(customEventName);
	}

	public static AnalyticsResult CustomEvent(string customEventName, Vector3 position)
	{
		if (Il2CppSystem.String.IsNullOrEmpty(customEventName))
		{
			throw new Il2CppSystem.ArgumentException("Cannot set custom event name to an empty or null string");
		}
		if (!IsInitialized())
		{
			return AnalyticsResult.NotInitialized;
		}
		CustomEventData customEventData = new CustomEventData(customEventName);
		customEventData.AddDouble("x", (double)Il2CppSystem.Convert.ToDecimal(position.x));
		customEventData.AddDouble("y", (double)Il2CppSystem.Convert.ToDecimal(position.y));
		customEventData.AddDouble("z", (double)Il2CppSystem.Convert.ToDecimal(position.z));
		AnalyticsResult result = SendCustomEvent(customEventData);
		customEventData.Dispose();
		return result;
	}

	public static AnalyticsResult CustomEvent(string customEventName, IDictionary<string, Il2CppSystem.Object> eventData)
	{
		if (Il2CppSystem.String.IsNullOrEmpty(customEventName))
		{
			throw new Il2CppSystem.ArgumentException("Cannot set custom event name to an empty or null string");
		}
		if (!IsInitialized())
		{
			return AnalyticsResult.NotInitialized;
		}
		if (eventData == null)
		{
			return SendCustomEventName(customEventName);
		}
		CustomEventData customEventData = new CustomEventData(customEventName);
		AnalyticsResult result = AnalyticsResult.InvalidData;
		try
		{
			customEventData.AddDictionary(eventData);
			result = SendCustomEvent(customEventData);
		}
		finally
		{
			customEventData.Dispose();
		}
		return result;
	}

	public static AnalyticsResult EnableCustomEvent(string customEventName, bool enabled)
	{
		if (Il2CppSystem.String.IsNullOrEmpty(customEventName))
		{
			throw new Il2CppSystem.ArgumentException("Cannot set event name to an empty or null string");
		}
		if (!IsInitialized())
		{
			return AnalyticsResult.NotInitialized;
		}
		return EnableCustomEventWithLimit(customEventName, enabled);
	}

	public static AnalyticsResult IsCustomEventEnabled(string customEventName)
	{
		if (Il2CppSystem.String.IsNullOrEmpty(customEventName))
		{
			throw new Il2CppSystem.ArgumentException("Cannot set event name to an empty or null string");
		}
		if (!IsInitialized())
		{
			return AnalyticsResult.NotInitialized;
		}
		return IsCustomEventWithLimitEnabled(customEventName);
	}

	public static AnalyticsResult RegisterEvent(string eventName, int maxEventPerHour, int maxItems, [Optional] string vendorKey, [Optional] string prefix)
	{
		string empty = Il2CppSystem.String.Empty;
		empty = Assembly.GetCallingAssembly().FullName;
		return RegisterEvent(eventName, maxEventPerHour, maxItems, vendorKey, 1, prefix, empty);
	}

	public static AnalyticsResult RegisterEvent(string eventName, int maxEventPerHour, int maxItems, string vendorKey, int ver, [Optional] string prefix)
	{
		string empty = Il2CppSystem.String.Empty;
		empty = Assembly.GetCallingAssembly().FullName;
		return RegisterEvent(eventName, maxEventPerHour, maxItems, vendorKey, ver, prefix, empty);
	}

	public static AnalyticsResult RegisterEvent(string eventName, int maxEventPerHour, int maxItems, string vendorKey, int ver, string prefix, string assemblyInfo)
	{
		if (Il2CppSystem.String.IsNullOrEmpty(eventName))
		{
			throw new Il2CppSystem.ArgumentException("Cannot set event name to an empty or null string");
		}
		if (!IsInitialized())
		{
			return AnalyticsResult.NotInitialized;
		}
		return RegisterEventWithLimit(eventName, maxEventPerHour, maxItems, vendorKey, ver, prefix, assemblyInfo, notifyServer: true);
	}

	public static AnalyticsResult SendEvent(string eventName, Il2CppSystem.Object parameters, [Optional] int ver, [Optional] string prefix)
	{
		if (Il2CppSystem.String.IsNullOrEmpty(eventName))
		{
			throw new Il2CppSystem.ArgumentException("Cannot set event name to an empty or null string");
		}
		if (parameters == null)
		{
			throw new Il2CppSystem.ArgumentException("Cannot set parameters to null");
		}
		if (!IsInitialized())
		{
			return AnalyticsResult.NotInitialized;
		}
		return SendEventWithLimit(eventName, parameters, ver, prefix);
	}

	public static AnalyticsResult SetEventEndPoint(string eventName, string endPoint, [Optional] int ver, [Optional] string prefix)
	{
		if (Il2CppSystem.String.IsNullOrEmpty(eventName))
		{
			throw new Il2CppSystem.ArgumentException("Cannot set event name to an empty or null string");
		}
		if (endPoint == null)
		{
			throw new Il2CppSystem.ArgumentException("Cannot set parameters to null");
		}
		if (!IsInitialized())
		{
			return AnalyticsResult.NotInitialized;
		}
		return SetEventWithLimitEndPoint(eventName, endPoint, ver, prefix);
	}

	public static AnalyticsResult SetEventPriority(string eventName, AnalyticsEventPriority eventPriority, [Optional] int ver, [Optional] string prefix)
	{
		if (Il2CppSystem.String.IsNullOrEmpty(eventName))
		{
			throw new Il2CppSystem.ArgumentException("Cannot set event name to an empty or null string");
		}
		if (!IsInitialized())
		{
			return AnalyticsResult.NotInitialized;
		}
		return SetEventWithLimitPriority(eventName, eventPriority, ver, prefix);
	}

	public static AnalyticsResult EnableEvent(string eventName, bool enabled, [Optional] int ver, [Optional] string prefix)
	{
		if (Il2CppSystem.String.IsNullOrEmpty(eventName))
		{
			throw new Il2CppSystem.ArgumentException("Cannot set event name to an empty or null string");
		}
		if (!IsInitialized())
		{
			return AnalyticsResult.NotInitialized;
		}
		return EnableEventWithLimit(eventName, enabled, ver, prefix);
	}

	public static AnalyticsResult IsEventEnabled(string eventName, [Optional] int ver, [Optional] string prefix)
	{
		if (Il2CppSystem.String.IsNullOrEmpty(eventName))
		{
			throw new Il2CppSystem.ArgumentException("Cannot set event name to an empty or null string");
		}
		if (!IsInitialized())
		{
			return AnalyticsResult.NotInitialized;
		}
		return IsEventWithLimitEnabled(eventName, ver, prefix);
	}

	public unsafe static void get_eventUrlInternal_Injected(out ManagedSpanWrapper ret)
	{
		get_eventUrlInternal_InjectedDelegateField((nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void get_configUrlInternal_Injected(out ManagedSpanWrapper ret)
	{
		get_configUrlInternal_InjectedDelegateField((nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void get_dashboardUrlInternal_Injected(out ManagedSpanWrapper ret)
	{
		get_dashboardUrlInternal_InjectedDelegateField((nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static AnalyticsResult Transaction_Injected(ref ManagedSpanWrapper productId, double amount, ref ManagedSpanWrapper currency, ref ManagedSpanWrapper receiptPurchaseData, ref ManagedSpanWrapper signature, bool usingIAPService)
	{
		return Transaction_InjectedDelegateField((nint)Unsafe.AsPointer(ref productId), amount, (nint)Unsafe.AsPointer(ref currency), (nint)Unsafe.AsPointer(ref receiptPurchaseData), (nint)Unsafe.AsPointer(ref signature), usingIAPService);
	}

	public unsafe static AnalyticsResult SendCustomEventName_Injected(ref ManagedSpanWrapper customEventName)
	{
		return SendCustomEventName_InjectedDelegateField((nint)Unsafe.AsPointer(ref customEventName));
	}

	public static AnalyticsResult SendCustomEvent_Injected(System.IntPtr eventData)
	{
		return SendCustomEvent_InjectedDelegateField(eventData);
	}

	public unsafe static AnalyticsResult IsCustomEventWithLimitEnabled_Injected(ref ManagedSpanWrapper customEventName)
	{
		return IsCustomEventWithLimitEnabled_InjectedDelegateField((nint)Unsafe.AsPointer(ref customEventName));
	}

	public unsafe static AnalyticsResult EnableCustomEventWithLimit_Injected(ref ManagedSpanWrapper customEventName, bool enable)
	{
		return EnableCustomEventWithLimit_InjectedDelegateField((nint)Unsafe.AsPointer(ref customEventName), enable);
	}

	public unsafe static AnalyticsResult IsEventWithLimitEnabled_Injected(ref ManagedSpanWrapper eventName, int ver, ref ManagedSpanWrapper prefix)
	{
		return IsEventWithLimitEnabled_InjectedDelegateField((nint)Unsafe.AsPointer(ref eventName), ver, (nint)Unsafe.AsPointer(ref prefix));
	}

	public unsafe static AnalyticsResult EnableEventWithLimit_Injected(ref ManagedSpanWrapper eventName, bool enable, int ver, ref ManagedSpanWrapper prefix)
	{
		return EnableEventWithLimit_InjectedDelegateField((nint)Unsafe.AsPointer(ref eventName), enable, ver, (nint)Unsafe.AsPointer(ref prefix));
	}

	public unsafe static AnalyticsResult RegisterEventWithLimit_Injected(ref ManagedSpanWrapper eventName, int maxEventPerHour, int maxItems, ref ManagedSpanWrapper vendorKey, int ver, ref ManagedSpanWrapper prefix, ref ManagedSpanWrapper assemblyInfo, bool notifyServer)
	{
		return RegisterEventWithLimit_InjectedDelegateField((nint)Unsafe.AsPointer(ref eventName), maxEventPerHour, maxItems, (nint)Unsafe.AsPointer(ref vendorKey), ver, (nint)Unsafe.AsPointer(ref prefix), (nint)Unsafe.AsPointer(ref assemblyInfo), notifyServer);
	}

	public unsafe static AnalyticsResult RegisterEventsWithLimit_Injected(Il2CppStringArray eventName, int maxEventPerHour, int maxItems, ref ManagedSpanWrapper vendorKey, int ver, ref ManagedSpanWrapper prefix, ref ManagedSpanWrapper assemblyInfo, bool notifyServer)
	{
		return RegisterEventsWithLimit_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)eventName), maxEventPerHour, maxItems, (nint)Unsafe.AsPointer(ref vendorKey), ver, (nint)Unsafe.AsPointer(ref prefix), (nint)Unsafe.AsPointer(ref assemblyInfo), notifyServer);
	}

	public unsafe static AnalyticsResult SendEventWithLimit_Injected(ref ManagedSpanWrapper eventName, Il2CppSystem.Object parameters, int ver, ref ManagedSpanWrapper prefix)
	{
		return SendEventWithLimit_InjectedDelegateField((nint)Unsafe.AsPointer(ref eventName), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parameters), ver, (nint)Unsafe.AsPointer(ref prefix));
	}

	public unsafe static AnalyticsResult SetEventWithLimitEndPoint_Injected(ref ManagedSpanWrapper eventName, ref ManagedSpanWrapper endPoint, int ver, ref ManagedSpanWrapper prefix)
	{
		return SetEventWithLimitEndPoint_InjectedDelegateField((nint)Unsafe.AsPointer(ref eventName), (nint)Unsafe.AsPointer(ref endPoint), ver, (nint)Unsafe.AsPointer(ref prefix));
	}

	public unsafe static AnalyticsResult SetEventWithLimitPriority_Injected(ref ManagedSpanWrapper eventName, AnalyticsEventPriority eventPriority, int ver, ref ManagedSpanWrapper prefix)
	{
		return SetEventWithLimitPriority_InjectedDelegateField((nint)Unsafe.AsPointer(ref eventName), eventPriority, ver, (nint)Unsafe.AsPointer(ref prefix));
	}

	public unsafe static AnalyticsResult QueueEvent_Injected(ref ManagedSpanWrapper eventName, Il2CppSystem.Object parameters, int ver, ref ManagedSpanWrapper prefix)
	{
		return QueueEvent_InjectedDelegateField((nint)Unsafe.AsPointer(ref eventName), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parameters), ver, (nint)Unsafe.AsPointer(ref prefix));
	}
}
