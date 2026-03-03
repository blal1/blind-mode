using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Bindings;

namespace UnityEngine.Analytics;

public static class AnalyticsSessionInfo : Il2CppSystem.Object
{
	public sealed class SessionStateChanged : Il2CppSystem.MulticastDelegate
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_AnalyticsSessionState_Int64_Int64_Boolean_0;

		static SessionStateChanged()
		{
			Il2CppClassPointerStore<SessionStateChanged>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AnalyticsSessionInfo>.NativeClassPtr, "SessionStateChanged");
			NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionStateChanged>.NativeClassPtr, 100663305);
			NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_AnalyticsSessionState_Int64_Int64_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionStateChanged>.NativeClassPtr, 100663306);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407984, XrefRangeEnd = 1407987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SessionStateChanged(Il2CppSystem.Object @object, System.IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SessionStateChanged>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
			*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407987, XrefRangeEnd = 1407997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Invoke(AnalyticsSessionState sessionState, long sessionId, long sessionElapsedTime, bool sessionChanged)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[4];
			*ptr = (nint)(&sessionState);
			*(long**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &sessionId;
			*(long**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &sessionElapsedTime;
			*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &sessionChanged;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_AnalyticsSessionState_Int64_Int64_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public SessionStateChanged(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public static implicit operator SessionStateChanged(System.Action<AnalyticsSessionState, long, long, bool> P_0)
		{
			return DelegateSupport.ConvertDelegate<SessionStateChanged>((System.Delegate)P_0);
		}

		public static SessionStateChanged operator +(SessionStateChanged P_0, SessionStateChanged P_1)
		{
			return ((Il2CppObjectBase)Il2CppSystem.Delegate.Combine(P_0, P_1)).Cast<SessionStateChanged>();
		}

		public static SessionStateChanged operator -(SessionStateChanged P_0, SessionStateChanged P_1)
		{
			object obj = Il2CppSystem.Delegate.Remove(P_0, P_1);
			if (obj != null)
			{
				obj = ((Il2CppObjectBase)obj).Cast<SessionStateChanged>();
			}
			return (SessionStateChanged)obj;
		}
	}

	public sealed class IdentityTokenChanged : Il2CppSystem.MulticastDelegate
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_0;

		static IdentityTokenChanged()
		{
			Il2CppClassPointerStore<IdentityTokenChanged>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AnalyticsSessionInfo>.NativeClassPtr, "IdentityTokenChanged");
			NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdentityTokenChanged>.NativeClassPtr, 100663307);
			NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdentityTokenChanged>.NativeClassPtr, 100663308);
		}

		[CallerCount(245)]
		[CachedScanResults(RefRangeStart = 57019, RefRangeEnd = 57264, XrefRangeStart = 57019, XrefRangeEnd = 57264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IdentityTokenChanged(Il2CppSystem.Object @object, System.IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IdentityTokenChanged>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
			*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		public unsafe virtual void Invoke(string token)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(token);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public IdentityTokenChanged(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public static implicit operator IdentityTokenChanged(System.Action<string> P_0)
		{
			return DelegateSupport.ConvertDelegate<IdentityTokenChanged>((System.Delegate)P_0);
		}

		public static IdentityTokenChanged operator +(IdentityTokenChanged P_0, IdentityTokenChanged P_1)
		{
			return ((Il2CppObjectBase)Il2CppSystem.Delegate.Combine(P_0, P_1)).Cast<IdentityTokenChanged>();
		}

		public static IdentityTokenChanged operator -(IdentityTokenChanged P_0, IdentityTokenChanged P_1)
		{
			object obj = Il2CppSystem.Delegate.Remove(P_0, P_1);
			if (obj != null)
			{
				obj = ((Il2CppObjectBase)obj).Cast<IdentityTokenChanged>();
			}
			return (IdentityTokenChanged)obj;
		}
	}

	private delegate AnalyticsSessionState get_sessionStateDelegate();

	private delegate long get_sessionIdDelegate();

	private delegate long get_sessionCountDelegate();

	private delegate long get_sessionElapsedTimeDelegate();

	private delegate bool get_sessionFirstRunDelegate();

	private delegate void get_userId_InjectedDelegate([Out] System.IntPtr ret);

	private delegate void get_identityTokenInternal_InjectedDelegate([Out] System.IntPtr ret);

	private delegate void get_customUserIdInternal_InjectedDelegate([Out] System.IntPtr ret);

	private delegate void set_customUserIdInternal_InjectedDelegate(System.IntPtr value);

	private delegate void get_customDeviceIdInternal_InjectedDelegate([Out] System.IntPtr ret);

	private delegate void set_customDeviceIdInternal_InjectedDelegate(System.IntPtr value);

	private static readonly System.IntPtr NativeFieldInfoPtr_sessionStateChanged;

	private static readonly System.IntPtr NativeFieldInfoPtr_identityTokenChanged;

	private static readonly System.IntPtr NativeMethodInfoPtr_CallSessionStateChanged_Internal_Static_Void_AnalyticsSessionState_Int64_Int64_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CallIdentityTokenChanged_Internal_Static_Void_String_0;

	private static readonly get_sessionStateDelegate get_sessionStateDelegateField;

	private static readonly get_sessionIdDelegate get_sessionIdDelegateField;

	private static readonly get_sessionCountDelegate get_sessionCountDelegateField;

	private static readonly get_sessionElapsedTimeDelegate get_sessionElapsedTimeDelegateField;

	private static readonly get_sessionFirstRunDelegate get_sessionFirstRunDelegateField;

	private static readonly get_userId_InjectedDelegate get_userId_InjectedDelegateField;

	private static readonly get_identityTokenInternal_InjectedDelegate get_identityTokenInternal_InjectedDelegateField;

	private static readonly get_customUserIdInternal_InjectedDelegate get_customUserIdInternal_InjectedDelegateField;

	private static readonly set_customUserIdInternal_InjectedDelegate set_customUserIdInternal_InjectedDelegateField;

	private static readonly get_customDeviceIdInternal_InjectedDelegate get_customDeviceIdInternal_InjectedDelegateField;

	private static readonly set_customDeviceIdInternal_InjectedDelegate set_customDeviceIdInternal_InjectedDelegateField;

	public unsafe static SessionStateChanged sessionStateChanged
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_sessionStateChanged, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<SessionStateChanged>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_sessionStateChanged, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static IdentityTokenChanged identityTokenChanged
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_identityTokenChanged, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IdentityTokenChanged>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_identityTokenChanged, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public static AnalyticsSessionState sessionState => get_sessionStateDelegateField();

	public static long sessionId => get_sessionIdDelegateField();

	public static long sessionCount => get_sessionCountDelegateField();

	public static long sessionElapsedTime => get_sessionElapsedTimeDelegateField();

	public static bool sessionFirstRun => get_sessionFirstRunDelegateField();

	public static string userId
	{
		get
		{
			Unsafe.SkipInit(out ManagedSpanWrapper ret);
			string stringAndDispose;
			try
			{
				get_userId_Injected(out ret);
			}
			finally
			{
				stringAndDispose = OutStringMarshaller.GetStringAndDispose(ret);
			}
			return stringAndDispose;
		}
	}

	public static string customUserId
	{
		get
		{
			if (!Analytics.IsInitialized())
			{
				return null;
			}
			return customUserIdInternal;
		}
		set
		{
			if (Analytics.IsInitialized())
			{
				customUserIdInternal = value;
			}
		}
	}

	public static string customDeviceId
	{
		get
		{
			if (!Analytics.IsInitialized())
			{
				return null;
			}
			return customDeviceIdInternal;
		}
		set
		{
			if (Analytics.IsInitialized())
			{
				customDeviceIdInternal = value;
			}
		}
	}

	public static string identityToken
	{
		get
		{
			if (!Analytics.IsInitialized())
			{
				return null;
			}
			return identityTokenInternal;
		}
	}

	public static string identityTokenInternal
	{
		get
		{
			Unsafe.SkipInit(out ManagedSpanWrapper ret);
			string stringAndDispose;
			try
			{
				get_identityTokenInternal_Injected(out ret);
			}
			finally
			{
				stringAndDispose = OutStringMarshaller.GetStringAndDispose(ret);
			}
			return stringAndDispose;
		}
	}

	public unsafe static string customUserIdInternal
	{
		get
		{
			Unsafe.SkipInit(out ManagedSpanWrapper ret);
			string stringAndDispose;
			try
			{
				get_customUserIdInternal_Injected(out ret);
			}
			finally
			{
				stringAndDispose = OutStringMarshaller.GetStringAndDispose(ret);
			}
			return stringAndDispose;
		}
		set
		{
			//IL_0018: Expected O, but got Ref
			//IL_0024: Expected O, but got Ref
			//The blocks IL_0029 are reachable both inside and outside the pinned region starting at IL_0018. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
			try
			{
				Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
				if (!StringMarshaller.TryMarshalEmptyOrNullString(value, ref managedSpanWrapper))
				{
					Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(value);
					fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
					{
						managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
						set_customUserIdInternal_Injected(ref managedSpanWrapper);
						return;
					}
				}
				set_customUserIdInternal_Injected(ref managedSpanWrapper);
			}
			finally
			{
			}
		}
	}

	public unsafe static string customDeviceIdInternal
	{
		get
		{
			Unsafe.SkipInit(out ManagedSpanWrapper ret);
			string stringAndDispose;
			try
			{
				get_customDeviceIdInternal_Injected(out ret);
			}
			finally
			{
				stringAndDispose = OutStringMarshaller.GetStringAndDispose(ret);
			}
			return stringAndDispose;
		}
		set
		{
			//IL_0018: Expected O, but got Ref
			//IL_0024: Expected O, but got Ref
			//The blocks IL_0029 are reachable both inside and outside the pinned region starting at IL_0018. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
			try
			{
				Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
				if (!StringMarshaller.TryMarshalEmptyOrNullString(value, ref managedSpanWrapper))
				{
					Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(value);
					fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
					{
						managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
						set_customDeviceIdInternal_Injected(ref managedSpanWrapper);
						return;
					}
				}
				set_customDeviceIdInternal_Injected(ref managedSpanWrapper);
			}
			finally
			{
			}
		}
	}

	static AnalyticsSessionInfo()
	{
		Il2CppClassPointerStore<AnalyticsSessionInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UnityAnalyticsModule.dll", "UnityEngine.Analytics", "AnalyticsSessionInfo");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnalyticsSessionInfo>.NativeClassPtr);
		NativeFieldInfoPtr_sessionStateChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnalyticsSessionInfo>.NativeClassPtr, "sessionStateChanged");
		NativeFieldInfoPtr_identityTokenChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnalyticsSessionInfo>.NativeClassPtr, "identityTokenChanged");
		NativeMethodInfoPtr_CallSessionStateChanged_Internal_Static_Void_AnalyticsSessionState_Int64_Int64_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnalyticsSessionInfo>.NativeClassPtr, 100663303);
		NativeMethodInfoPtr_CallIdentityTokenChanged_Internal_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnalyticsSessionInfo>.NativeClassPtr, 100663304);
		get_sessionStateDelegateField = IL2CPP.ResolveICall<get_sessionStateDelegate>("UnityEngine.Analytics.AnalyticsSessionInfo::get_sessionState");
		get_sessionIdDelegateField = IL2CPP.ResolveICall<get_sessionIdDelegate>("UnityEngine.Analytics.AnalyticsSessionInfo::get_sessionId");
		get_sessionCountDelegateField = IL2CPP.ResolveICall<get_sessionCountDelegate>("UnityEngine.Analytics.AnalyticsSessionInfo::get_sessionCount");
		get_sessionElapsedTimeDelegateField = IL2CPP.ResolveICall<get_sessionElapsedTimeDelegate>("UnityEngine.Analytics.AnalyticsSessionInfo::get_sessionElapsedTime");
		get_sessionFirstRunDelegateField = IL2CPP.ResolveICall<get_sessionFirstRunDelegate>("UnityEngine.Analytics.AnalyticsSessionInfo::get_sessionFirstRun");
		get_userId_InjectedDelegateField = IL2CPP.ResolveICall<get_userId_InjectedDelegate>("UnityEngine.Analytics.AnalyticsSessionInfo::get_userId_Injected");
		get_identityTokenInternal_InjectedDelegateField = IL2CPP.ResolveICall<get_identityTokenInternal_InjectedDelegate>("UnityEngine.Analytics.AnalyticsSessionInfo::get_identityTokenInternal_Injected");
		get_customUserIdInternal_InjectedDelegateField = IL2CPP.ResolveICall<get_customUserIdInternal_InjectedDelegate>("UnityEngine.Analytics.AnalyticsSessionInfo::get_customUserIdInternal_Injected");
		set_customUserIdInternal_InjectedDelegateField = IL2CPP.ResolveICall<set_customUserIdInternal_InjectedDelegate>("UnityEngine.Analytics.AnalyticsSessionInfo::set_customUserIdInternal_Injected");
		get_customDeviceIdInternal_InjectedDelegateField = IL2CPP.ResolveICall<get_customDeviceIdInternal_InjectedDelegate>("UnityEngine.Analytics.AnalyticsSessionInfo::get_customDeviceIdInternal_Injected");
		set_customDeviceIdInternal_InjectedDelegateField = IL2CPP.ResolveICall<set_customDeviceIdInternal_InjectedDelegate>("UnityEngine.Analytics.AnalyticsSessionInfo::set_customDeviceIdInternal_Injected");
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407997, XrefRangeEnd = 1407999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CallSessionStateChanged(AnalyticsSessionState sessionState, long sessionId, long sessionElapsedTime, bool sessionChanged)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&sessionState);
		*(long**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &sessionId;
		*(long**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &sessionElapsedTime;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &sessionChanged;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CallSessionStateChanged_Internal_Static_Void_AnalyticsSessionState_Int64_Int64_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407999, XrefRangeEnd = 1408001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CallIdentityTokenChanged(string token)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(token);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CallIdentityTokenChanged_Internal_Static_Void_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public AnalyticsSessionInfo(System.IntPtr pointer)
		: base(pointer)
	{
	}

	[SpecialName]
	public static void add_sessionStateChanged(SessionStateChanged value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	[SpecialName]
	public static void remove_sessionStateChanged(SessionStateChanged value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	[SpecialName]
	public static void add_identityTokenChanged(IdentityTokenChanged value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	[SpecialName]
	public static void remove_identityTokenChanged(IdentityTokenChanged value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public unsafe static void get_userId_Injected(out ManagedSpanWrapper ret)
	{
		get_userId_InjectedDelegateField((nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void get_identityTokenInternal_Injected(out ManagedSpanWrapper ret)
	{
		get_identityTokenInternal_InjectedDelegateField((nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void get_customUserIdInternal_Injected(out ManagedSpanWrapper ret)
	{
		get_customUserIdInternal_InjectedDelegateField((nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void set_customUserIdInternal_Injected(ref ManagedSpanWrapper value)
	{
		set_customUserIdInternal_InjectedDelegateField((nint)Unsafe.AsPointer(ref value));
	}

	public unsafe static void get_customDeviceIdInternal_Injected(out ManagedSpanWrapper ret)
	{
		get_customDeviceIdInternal_InjectedDelegateField((nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void set_customDeviceIdInternal_Injected(ref ManagedSpanWrapper value)
	{
		set_customDeviceIdInternal_InjectedDelegateField((nint)Unsafe.AsPointer(ref value));
	}
}
