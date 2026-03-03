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
using UnityEngine.Bindings;

namespace UnityEngine;

public static class RemoteSettings : Il2CppSystem.Object
{
	public sealed class UpdatedEventHandler : Il2CppSystem.MulticastDelegate
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0;

		static UpdatedEventHandler()
		{
			Il2CppClassPointerStore<UpdatedEventHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RemoteSettings>.NativeClassPtr, "UpdatedEventHandler");
			NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdatedEventHandler>.NativeClassPtr, 100663300);
			NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdatedEventHandler>.NativeClassPtr, 100663301);
		}

		[CallerCount(4109)]
		[CachedScanResults(RefRangeStart = 27728, RefRangeEnd = 31837, XrefRangeStart = 27728, XrefRangeEnd = 31837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UpdatedEventHandler(Il2CppSystem.Object @object, System.IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UpdatedEventHandler>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
			*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		public unsafe virtual void Invoke()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public UpdatedEventHandler(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public static implicit operator UpdatedEventHandler(System.Action P_0)
		{
			return DelegateSupport.ConvertDelegate<UpdatedEventHandler>((System.Delegate)P_0);
		}

		public static UpdatedEventHandler operator +(UpdatedEventHandler P_0, UpdatedEventHandler P_1)
		{
			return ((Il2CppObjectBase)Il2CppSystem.Delegate.Combine(P_0, P_1)).Cast<UpdatedEventHandler>();
		}

		public static UpdatedEventHandler operator -(UpdatedEventHandler P_0, UpdatedEventHandler P_1)
		{
			object obj = Il2CppSystem.Delegate.Remove(P_0, P_1);
			if (obj != null)
			{
				obj = ((Il2CppObjectBase)obj).Cast<UpdatedEventHandler>();
			}
			return (UpdatedEventHandler)obj;
		}
	}

	private delegate void ForceUpdateDelegate();

	private delegate bool WasLastUpdatedFromServerDelegate();

	private delegate int GetCountDelegate();

	private delegate System.IntPtr GetKeysDelegate();

	private delegate void UseSafeLockDelegate();

	private delegate void ReleaseSafeLockDelegate();

	private delegate System.IntPtr GetSafeTopMapDelegate();

	private delegate int GetInt_InjectedDelegate(System.IntPtr key, int defaultValue);

	private delegate long GetLong_InjectedDelegate(System.IntPtr key, long defaultValue);

	private delegate float GetFloat_InjectedDelegate(System.IntPtr key, float defaultValue);

	private delegate void GetString_InjectedDelegate(System.IntPtr key, System.IntPtr defaultValue, [Out] System.IntPtr ret);

	private delegate bool GetBool_InjectedDelegate(System.IntPtr key, bool defaultValue);

	private delegate bool HasKey_InjectedDelegate(System.IntPtr key);

	private delegate System.IntPtr GetAsScriptingObject_InjectedDelegate(System.IntPtr t, System.IntPtr defaultValue, System.IntPtr key);

	private static readonly System.IntPtr NativeFieldInfoPtr_Updated;

	private static readonly System.IntPtr NativeFieldInfoPtr_BeforeFetchFromServer;

	private static readonly System.IntPtr NativeFieldInfoPtr_Completed;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoteSettingsUpdated_Internal_Static_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoteSettingsBeforeFetchFromServer_Internal_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoteSettingsUpdateCompleted_Internal_Static_Void_Boolean_Boolean_Int32_0;

	private static readonly ForceUpdateDelegate ForceUpdateDelegateField;

	private static readonly WasLastUpdatedFromServerDelegate WasLastUpdatedFromServerDelegateField;

	private static readonly GetCountDelegate GetCountDelegateField;

	private static readonly GetKeysDelegate GetKeysDelegateField;

	private static readonly UseSafeLockDelegate UseSafeLockDelegateField;

	private static readonly ReleaseSafeLockDelegate ReleaseSafeLockDelegateField;

	private static readonly GetSafeTopMapDelegate GetSafeTopMapDelegateField;

	private static readonly GetInt_InjectedDelegate GetInt_InjectedDelegateField;

	private static readonly GetLong_InjectedDelegate GetLong_InjectedDelegateField;

	private static readonly GetFloat_InjectedDelegate GetFloat_InjectedDelegateField;

	private static readonly GetString_InjectedDelegate GetString_InjectedDelegateField;

	private static readonly GetBool_InjectedDelegate GetBool_InjectedDelegateField;

	private static readonly HasKey_InjectedDelegate HasKey_InjectedDelegateField;

	private static readonly GetAsScriptingObject_InjectedDelegate GetAsScriptingObject_InjectedDelegateField;

	public unsafe static UpdatedEventHandler Updated
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Updated, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<UpdatedEventHandler>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Updated, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppSystem.Action BeforeFetchFromServer
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BeforeFetchFromServer, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BeforeFetchFromServer, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppSystem.Action<bool, bool, int> Completed
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Completed, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<bool, bool, int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Completed, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static RemoteSettings()
	{
		Il2CppClassPointerStore<RemoteSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UnityAnalyticsModule.dll", "UnityEngine", "RemoteSettings");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemoteSettings>.NativeClassPtr);
		NativeFieldInfoPtr_Updated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteSettings>.NativeClassPtr, "Updated");
		NativeFieldInfoPtr_BeforeFetchFromServer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteSettings>.NativeClassPtr, "BeforeFetchFromServer");
		NativeFieldInfoPtr_Completed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteSettings>.NativeClassPtr, "Completed");
		NativeMethodInfoPtr_RemoteSettingsUpdated_Internal_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoteSettings>.NativeClassPtr, 100663297);
		NativeMethodInfoPtr_RemoteSettingsBeforeFetchFromServer_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoteSettings>.NativeClassPtr, 100663298);
		NativeMethodInfoPtr_RemoteSettingsUpdateCompleted_Internal_Static_Void_Boolean_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoteSettings>.NativeClassPtr, 100663299);
		ForceUpdateDelegateField = IL2CPP.ResolveICall<ForceUpdateDelegate>("UnityEngine.RemoteSettings::ForceUpdate");
		WasLastUpdatedFromServerDelegateField = IL2CPP.ResolveICall<WasLastUpdatedFromServerDelegate>("UnityEngine.RemoteSettings::WasLastUpdatedFromServer");
		GetCountDelegateField = IL2CPP.ResolveICall<GetCountDelegate>("UnityEngine.RemoteSettings::GetCount");
		GetKeysDelegateField = IL2CPP.ResolveICall<GetKeysDelegate>("UnityEngine.RemoteSettings::GetKeys");
		UseSafeLockDelegateField = IL2CPP.ResolveICall<UseSafeLockDelegate>("UnityEngine.RemoteSettings::UseSafeLock");
		ReleaseSafeLockDelegateField = IL2CPP.ResolveICall<ReleaseSafeLockDelegate>("UnityEngine.RemoteSettings::ReleaseSafeLock");
		GetSafeTopMapDelegateField = IL2CPP.ResolveICall<GetSafeTopMapDelegate>("UnityEngine.RemoteSettings::GetSafeTopMap");
		GetInt_InjectedDelegateField = IL2CPP.ResolveICall<GetInt_InjectedDelegate>("UnityEngine.RemoteSettings::GetInt_Injected");
		GetLong_InjectedDelegateField = IL2CPP.ResolveICall<GetLong_InjectedDelegate>("UnityEngine.RemoteSettings::GetLong_Injected");
		GetFloat_InjectedDelegateField = IL2CPP.ResolveICall<GetFloat_InjectedDelegate>("UnityEngine.RemoteSettings::GetFloat_Injected");
		GetString_InjectedDelegateField = IL2CPP.ResolveICall<GetString_InjectedDelegate>("UnityEngine.RemoteSettings::GetString_Injected");
		GetBool_InjectedDelegateField = IL2CPP.ResolveICall<GetBool_InjectedDelegate>("UnityEngine.RemoteSettings::GetBool_Injected");
		HasKey_InjectedDelegateField = IL2CPP.ResolveICall<HasKey_InjectedDelegate>("UnityEngine.RemoteSettings::HasKey_Injected");
		GetAsScriptingObject_InjectedDelegateField = IL2CPP.ResolveICall<GetAsScriptingObject_InjectedDelegate>("UnityEngine.RemoteSettings::GetAsScriptingObject_Injected");
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407978, XrefRangeEnd = 1407980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RemoteSettingsUpdated(bool wasLastUpdatedFromServer)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&wasLastUpdatedFromServer);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoteSettingsUpdated_Internal_Static_Void_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407980, XrefRangeEnd = 1407982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RemoteSettingsBeforeFetchFromServer()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoteSettingsBeforeFetchFromServer_Internal_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1407982, XrefRangeEnd = 1407984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RemoteSettingsUpdateCompleted(bool wasLastUpdatedFromServer, bool settingsChanged, int response)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&wasLastUpdatedFromServer);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &settingsChanged;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &response;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoteSettingsUpdateCompleted_Internal_Static_Void_Boolean_Boolean_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public RemoteSettings(System.IntPtr pointer)
		: base(pointer)
	{
	}

	[SpecialName]
	public static void add_Updated(UpdatedEventHandler value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	[SpecialName]
	public static void remove_Updated(UpdatedEventHandler value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	[SpecialName]
	public static void add_BeforeFetchFromServer(Il2CppSystem.Action value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	[SpecialName]
	public static void remove_BeforeFetchFromServer(Il2CppSystem.Action value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	[SpecialName]
	public static void add_Completed(Il2CppSystem.Action<bool, bool, int> value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	[SpecialName]
	public static void remove_Completed(Il2CppSystem.Action<bool, bool, int> value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public static void CallOnUpdate()
	{
		throw new Il2CppSystem.NotSupportedException("Calling CallOnUpdate() is not necessary any more and should be removed.");
	}

	public static void ForceUpdate()
	{
		ForceUpdateDelegateField();
	}

	public static bool WasLastUpdatedFromServer()
	{
		return WasLastUpdatedFromServerDelegateField();
	}

	public static int GetInt(string key)
	{
		return GetInt(key, 0);
	}

	public unsafe static int GetInt(string key, int defaultValue)
	{
		//IL_0018: Expected O, but got Ref
		//IL_0024: Expected O, but got Ref
		//The blocks IL_0029 are reachable both inside and outside the pinned region starting at IL_0018. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(key, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(key);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					return GetInt_Injected(ref managedSpanWrapper, defaultValue);
				}
			}
			return GetInt_Injected(ref managedSpanWrapper, defaultValue);
		}
		finally
		{
		}
	}

	public static long GetLong(string key)
	{
		return GetLong(key, 0L);
	}

	public unsafe static long GetLong(string key, long defaultValue)
	{
		//IL_0018: Expected O, but got Ref
		//IL_0024: Expected O, but got Ref
		//The blocks IL_0029 are reachable both inside and outside the pinned region starting at IL_0018. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(key, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(key);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					return GetLong_Injected(ref managedSpanWrapper, defaultValue);
				}
			}
			return GetLong_Injected(ref managedSpanWrapper, defaultValue);
		}
		finally
		{
		}
	}

	public static float GetFloat(string key)
	{
		return GetFloat(key, 0f);
	}

	public unsafe static float GetFloat(string key, float defaultValue)
	{
		//IL_0018: Expected O, but got Ref
		//IL_0024: Expected O, but got Ref
		//The blocks IL_0029 are reachable both inside and outside the pinned region starting at IL_0018. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(key, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(key);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					return GetFloat_Injected(ref managedSpanWrapper, defaultValue);
				}
			}
			return GetFloat_Injected(ref managedSpanWrapper, defaultValue);
		}
		finally
		{
		}
	}

	public static string GetString(string key)
	{
		return GetString(key, "");
	}

	public unsafe static string GetString(string key, string defaultValue)
	{
		//IL_0018: Expected O, but got Ref
		//IL_0024: Expected O, but got Ref
		//IL_0044: Expected O, but got Ref
		//IL_0052: Expected O, but got Ref
		//The blocks IL_0029, IL_0036, IL_0044, IL_0052, IL_0057 are reachable both inside and outside the pinned region starting at IL_0018. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		//The blocks IL_0057 are reachable both inside and outside the pinned region starting at IL_0044. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		//The blocks IL_0057 are reachable both inside and outside the pinned region starting at IL_0044. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		Unsafe.SkipInit(out ManagedSpanWrapper ret);
		string stringAndDispose;
		try
		{
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			ref ManagedSpanWrapper key2;
			Il2CppSystem.ReadOnlySpan<char> readOnlySpan2;
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper2);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(key, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(key);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					key2 = ref managedSpanWrapper;
					if (!StringMarshaller.TryMarshalEmptyOrNullString(defaultValue, ref managedSpanWrapper2))
					{
						readOnlySpan2 = Il2CppSystem.MemoryExtensions.AsSpan(defaultValue);
						fixed (char* begin2 = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan2)).GetPinnableReference())
						{
							managedSpanWrapper2 = new ManagedSpanWrapper(begin2, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan2)).Length);
							GetString_Injected(ref key2, ref managedSpanWrapper2, out ret);
						}
					}
					else
					{
						GetString_Injected(ref key2, ref managedSpanWrapper2, out ret);
					}
				}
			}
			else
			{
				key2 = ref managedSpanWrapper;
				if (!StringMarshaller.TryMarshalEmptyOrNullString(defaultValue, ref managedSpanWrapper2))
				{
					readOnlySpan2 = Il2CppSystem.MemoryExtensions.AsSpan(defaultValue);
					fixed (char* begin2 = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan2)).GetPinnableReference())
					{
						managedSpanWrapper2 = new ManagedSpanWrapper(begin2, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan2)).Length);
						GetString_Injected(ref key2, ref managedSpanWrapper2, out ret);
					}
				}
				else
				{
					GetString_Injected(ref key2, ref managedSpanWrapper2, out ret);
				}
			}
		}
		finally
		{
			stringAndDispose = OutStringMarshaller.GetStringAndDispose(ret);
		}
		return stringAndDispose;
	}

	public static bool GetBool(string key)
	{
		return GetBool(key, defaultValue: false);
	}

	public unsafe static bool GetBool(string key, bool defaultValue)
	{
		//IL_0018: Expected O, but got Ref
		//IL_0024: Expected O, but got Ref
		//The blocks IL_0029 are reachable both inside and outside the pinned region starting at IL_0018. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(key, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(key);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					return GetBool_Injected(ref managedSpanWrapper, defaultValue);
				}
			}
			return GetBool_Injected(ref managedSpanWrapper, defaultValue);
		}
		finally
		{
		}
	}

	public unsafe static bool HasKey(string key)
	{
		//IL_0018: Expected O, but got Ref
		//IL_0024: Expected O, but got Ref
		//The blocks IL_0029 are reachable both inside and outside the pinned region starting at IL_0018. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(key, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(key);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					return HasKey_Injected(ref managedSpanWrapper);
				}
			}
			return HasKey_Injected(ref managedSpanWrapper);
		}
		finally
		{
		}
	}

	public static int GetCount()
	{
		return GetCountDelegateField();
	}

	public static Il2CppStringArray GetKeys()
	{
		System.IntPtr intPtr = GetKeysDelegateField();
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr) : null;
	}

	public static T GetObject<T>([Optional] string key)
	{
		return ((Il2CppObjectBase)GetObject(Il2CppSystem.Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()), key)).Cast<T>();
	}

	public static Il2CppSystem.Object GetObject(Il2CppSystem.Type type, [Optional] string key)
	{
		if (type == null)
		{
			throw new Il2CppSystem.ArgumentNullException("type");
		}
		if (type.IsAbstract || type.IsSubclassOf(Il2CppSystem.Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<Object>())))
		{
			throw new Il2CppSystem.ArgumentException(Il2CppSystem.String.Concat("Cannot deserialize to new instances of type '", type.Name, ".'"));
		}
		return GetAsScriptingObject(type, null, key);
	}

	public static Il2CppSystem.Object GetObject(string key, Il2CppSystem.Object defaultValue)
	{
		if (defaultValue == null)
		{
			throw new Il2CppSystem.ArgumentNullException("defaultValue");
		}
		Il2CppSystem.Type type = defaultValue.GetType();
		if (type.IsAbstract || type.IsSubclassOf(Il2CppSystem.Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<Object>())))
		{
			throw new Il2CppSystem.ArgumentException(Il2CppSystem.String.Concat("Cannot deserialize to new instances of type '", type.Name, ".'"));
		}
		return GetAsScriptingObject(type, defaultValue, key);
	}

	public unsafe static Il2CppSystem.Object GetAsScriptingObject(Il2CppSystem.Type t, Il2CppSystem.Object defaultValue, string key)
	{
		//IL_001a: Expected O, but got Ref
		//IL_0026: Expected O, but got Ref
		//The blocks IL_002b are reachable both inside and outside the pinned region starting at IL_001a. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(key, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(key);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					return GetAsScriptingObject_Injected(t, defaultValue, ref managedSpanWrapper);
				}
			}
			return GetAsScriptingObject_Injected(t, defaultValue, ref managedSpanWrapper);
		}
		finally
		{
		}
	}

	public static IDictionary<string, Il2CppSystem.Object> GetDictionary([Optional] string key)
	{
		UseSafeLock();
		IDictionary<string, Il2CppSystem.Object> dictionary = RemoteConfigSettingsHelper.GetDictionary(GetSafeTopMap(), key);
		ReleaseSafeLock();
		return dictionary;
	}

	public static void UseSafeLock()
	{
		UseSafeLockDelegateField();
	}

	public static void ReleaseSafeLock()
	{
		ReleaseSafeLockDelegateField();
	}

	public static System.IntPtr GetSafeTopMap()
	{
		return GetSafeTopMapDelegateField();
	}

	public unsafe static int GetInt_Injected(ref ManagedSpanWrapper key, int defaultValue)
	{
		return GetInt_InjectedDelegateField((nint)Unsafe.AsPointer(ref key), defaultValue);
	}

	public unsafe static long GetLong_Injected(ref ManagedSpanWrapper key, long defaultValue)
	{
		return GetLong_InjectedDelegateField((nint)Unsafe.AsPointer(ref key), defaultValue);
	}

	public unsafe static float GetFloat_Injected(ref ManagedSpanWrapper key, float defaultValue)
	{
		return GetFloat_InjectedDelegateField((nint)Unsafe.AsPointer(ref key), defaultValue);
	}

	public unsafe static void GetString_Injected(ref ManagedSpanWrapper key, ref ManagedSpanWrapper defaultValue, out ManagedSpanWrapper ret)
	{
		GetString_InjectedDelegateField((nint)Unsafe.AsPointer(ref key), (nint)Unsafe.AsPointer(ref defaultValue), (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static bool GetBool_Injected(ref ManagedSpanWrapper key, bool defaultValue)
	{
		return GetBool_InjectedDelegateField((nint)Unsafe.AsPointer(ref key), defaultValue);
	}

	public unsafe static bool HasKey_Injected(ref ManagedSpanWrapper key)
	{
		return HasKey_InjectedDelegateField((nint)Unsafe.AsPointer(ref key));
	}

	public unsafe static Il2CppSystem.Object GetAsScriptingObject_Injected(Il2CppSystem.Type t, Il2CppSystem.Object defaultValue, ref ManagedSpanWrapper key)
	{
		System.IntPtr intPtr = GetAsScriptingObject_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)t), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)defaultValue), (nint)Unsafe.AsPointer(ref key));
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
	}
}
