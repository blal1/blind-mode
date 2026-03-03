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
using UnityEngine.Analytics;
using UnityEngine.Bindings;

namespace UnityEngine;

public class RemoteConfigSettings : Il2CppSystem.Object
{
	public static class BindingsMarshaller
	{
	}

	private delegate void Internal_DestroyDelegate(System.IntPtr ptr);

	private delegate bool SendDeviceInfoInConfigRequestDelegate();

	private delegate System.IntPtr Internal_Create_InjectedDelegate(System.IntPtr rcs, System.IntPtr configKey);

	private delegate AnalyticsResult QueueConfig_InjectedDelegate(System.IntPtr name, System.IntPtr param, int ver, System.IntPtr prefix);

	private delegate void AddSessionTag_InjectedDelegate(System.IntPtr tag);

	private delegate void ForceUpdate_InjectedDelegate(System.IntPtr _unity_self);

	private delegate bool WasLastUpdatedFromServer_InjectedDelegate(System.IntPtr _unity_self);

	private delegate int GetInt_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr key, int defaultValue);

	private delegate long GetLong_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr key, long defaultValue);

	private delegate float GetFloat_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr key, float defaultValue);

	private delegate void GetString_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr key, System.IntPtr defaultValue, [Out] System.IntPtr ret);

	private delegate bool GetBool_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr key, bool defaultValue);

	private delegate bool HasKey_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr key);

	private delegate int GetCount_InjectedDelegate(System.IntPtr _unity_self);

	private delegate System.IntPtr GetKeys_InjectedDelegate(System.IntPtr _unity_self);

	private delegate System.IntPtr GetAsScriptingObject_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr t, System.IntPtr defaultValue, System.IntPtr key);

	private delegate void UseSafeLock_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void ReleaseSafeLock_InjectedDelegate(System.IntPtr _unity_self);

	private delegate System.IntPtr GetSafeTopMap_InjectedDelegate(System.IntPtr _unity_self);

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Ptr;

	private static readonly System.IntPtr NativeFieldInfoPtr_Updated;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoteConfigSettingsUpdated_Internal_Static_Void_RemoteConfigSettings_Boolean_0;

	private static readonly Internal_DestroyDelegate Internal_DestroyDelegateField;

	private static readonly SendDeviceInfoInConfigRequestDelegate SendDeviceInfoInConfigRequestDelegateField;

	private static readonly Internal_Create_InjectedDelegate Internal_Create_InjectedDelegateField;

	private static readonly QueueConfig_InjectedDelegate QueueConfig_InjectedDelegateField;

	private static readonly AddSessionTag_InjectedDelegate AddSessionTag_InjectedDelegateField;

	private static readonly ForceUpdate_InjectedDelegate ForceUpdate_InjectedDelegateField;

	private static readonly WasLastUpdatedFromServer_InjectedDelegate WasLastUpdatedFromServer_InjectedDelegateField;

	private static readonly GetInt_InjectedDelegate GetInt_InjectedDelegateField;

	private static readonly GetLong_InjectedDelegate GetLong_InjectedDelegateField;

	private static readonly GetFloat_InjectedDelegate GetFloat_InjectedDelegateField;

	private static readonly GetString_InjectedDelegate GetString_InjectedDelegateField;

	private static readonly GetBool_InjectedDelegate GetBool_InjectedDelegateField;

	private static readonly HasKey_InjectedDelegate HasKey_InjectedDelegateField;

	private static readonly GetCount_InjectedDelegate GetCount_InjectedDelegateField;

	private static readonly GetKeys_InjectedDelegate GetKeys_InjectedDelegateField;

	private static readonly GetAsScriptingObject_InjectedDelegate GetAsScriptingObject_InjectedDelegateField;

	private static readonly UseSafeLock_InjectedDelegate UseSafeLock_InjectedDelegateField;

	private static readonly ReleaseSafeLock_InjectedDelegate ReleaseSafeLock_InjectedDelegateField;

	private static readonly GetSafeTopMap_InjectedDelegate GetSafeTopMap_InjectedDelegateField;

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

	public unsafe Il2CppSystem.Action<bool> Updated
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Updated);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<bool>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Updated)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static RemoteConfigSettings()
	{
		Il2CppClassPointerStore<RemoteConfigSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UnityAnalyticsModule.dll", "UnityEngine", "RemoteConfigSettings");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemoteConfigSettings>.NativeClassPtr);
		NativeFieldInfoPtr_m_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteConfigSettings>.NativeClassPtr, "m_Ptr");
		NativeFieldInfoPtr_Updated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteConfigSettings>.NativeClassPtr, "Updated");
		NativeMethodInfoPtr_RemoteConfigSettingsUpdated_Internal_Static_Void_RemoteConfigSettings_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoteConfigSettings>.NativeClassPtr, 100663302);
		Internal_DestroyDelegateField = IL2CPP.ResolveICall<Internal_DestroyDelegate>("UnityEngine.RemoteConfigSettings::Internal_Destroy");
		SendDeviceInfoInConfigRequestDelegateField = IL2CPP.ResolveICall<SendDeviceInfoInConfigRequestDelegate>("UnityEngine.RemoteConfigSettings::SendDeviceInfoInConfigRequest");
		Internal_Create_InjectedDelegateField = IL2CPP.ResolveICall<Internal_Create_InjectedDelegate>("UnityEngine.RemoteConfigSettings::Internal_Create_Injected");
		QueueConfig_InjectedDelegateField = IL2CPP.ResolveICall<QueueConfig_InjectedDelegate>("UnityEngine.RemoteConfigSettings::QueueConfig_Injected");
		AddSessionTag_InjectedDelegateField = IL2CPP.ResolveICall<AddSessionTag_InjectedDelegate>("UnityEngine.RemoteConfigSettings::AddSessionTag_Injected");
		ForceUpdate_InjectedDelegateField = IL2CPP.ResolveICall<ForceUpdate_InjectedDelegate>("UnityEngine.RemoteConfigSettings::ForceUpdate_Injected");
		WasLastUpdatedFromServer_InjectedDelegateField = IL2CPP.ResolveICall<WasLastUpdatedFromServer_InjectedDelegate>("UnityEngine.RemoteConfigSettings::WasLastUpdatedFromServer_Injected");
		GetInt_InjectedDelegateField = IL2CPP.ResolveICall<GetInt_InjectedDelegate>("UnityEngine.RemoteConfigSettings::GetInt_Injected");
		GetLong_InjectedDelegateField = IL2CPP.ResolveICall<GetLong_InjectedDelegate>("UnityEngine.RemoteConfigSettings::GetLong_Injected");
		GetFloat_InjectedDelegateField = IL2CPP.ResolveICall<GetFloat_InjectedDelegate>("UnityEngine.RemoteConfigSettings::GetFloat_Injected");
		GetString_InjectedDelegateField = IL2CPP.ResolveICall<GetString_InjectedDelegate>("UnityEngine.RemoteConfigSettings::GetString_Injected");
		GetBool_InjectedDelegateField = IL2CPP.ResolveICall<GetBool_InjectedDelegate>("UnityEngine.RemoteConfigSettings::GetBool_Injected");
		HasKey_InjectedDelegateField = IL2CPP.ResolveICall<HasKey_InjectedDelegate>("UnityEngine.RemoteConfigSettings::HasKey_Injected");
		GetCount_InjectedDelegateField = IL2CPP.ResolveICall<GetCount_InjectedDelegate>("UnityEngine.RemoteConfigSettings::GetCount_Injected");
		GetKeys_InjectedDelegateField = IL2CPP.ResolveICall<GetKeys_InjectedDelegate>("UnityEngine.RemoteConfigSettings::GetKeys_Injected");
		GetAsScriptingObject_InjectedDelegateField = IL2CPP.ResolveICall<GetAsScriptingObject_InjectedDelegate>("UnityEngine.RemoteConfigSettings::GetAsScriptingObject_Injected");
		UseSafeLock_InjectedDelegateField = IL2CPP.ResolveICall<UseSafeLock_InjectedDelegate>("UnityEngine.RemoteConfigSettings::UseSafeLock_Injected");
		ReleaseSafeLock_InjectedDelegateField = IL2CPP.ResolveICall<ReleaseSafeLock_InjectedDelegate>("UnityEngine.RemoteConfigSettings::ReleaseSafeLock_Injected");
		GetSafeTopMap_InjectedDelegateField = IL2CPP.ResolveICall<GetSafeTopMap_InjectedDelegate>("UnityEngine.RemoteConfigSettings::GetSafeTopMap_Injected");
	}

	[CallerCount(0)]
	public unsafe static void RemoteConfigSettingsUpdated(RemoteConfigSettings rcs, bool wasLastUpdatedFromServer)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rcs);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &wasLastUpdatedFromServer;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoteConfigSettingsUpdated_Internal_Static_Void_RemoteConfigSettings_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public RemoteConfigSettings(System.IntPtr pointer)
		: base(pointer)
	{
	}

	[SpecialName]
	public void add_Updated(Il2CppSystem.Action<bool> value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	[SpecialName]
	public void remove_Updated(Il2CppSystem.Action<bool> value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	~RemoteConfigSettings()
	{
		Destroy();
	}

	public void Destroy()
	{
		if (m_Ptr != Il2CppSystem.IntPtr.Zero)
		{
			Internal_Destroy(m_Ptr);
			m_Ptr = Il2CppSystem.IntPtr.Zero;
		}
	}

	public void Dispose()
	{
		Destroy();
		Il2CppSystem.GC.SuppressFinalize(this);
	}

	public unsafe static System.IntPtr Internal_Create(RemoteConfigSettings rcs, string configKey)
	{
		//IL_0019: Expected O, but got Ref
		//IL_0025: Expected O, but got Ref
		//The blocks IL_002a are reachable both inside and outside the pinned region starting at IL_0019. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(configKey, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(configKey);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					return Internal_Create_Injected(rcs, ref managedSpanWrapper);
				}
			}
			return Internal_Create_Injected(rcs, ref managedSpanWrapper);
		}
		finally
		{
		}
	}

	public static void Internal_Destroy(System.IntPtr ptr)
	{
		Internal_DestroyDelegateField(ptr);
	}

	public unsafe static AnalyticsResult QueueConfig(string name, Il2CppSystem.Object param, [Optional] int ver, [Optional] string prefix)
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
			ref ManagedSpanWrapper name2;
			Il2CppSystem.Object param2;
			int ver2;
			Il2CppSystem.ReadOnlySpan<char> readOnlySpan2;
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper2);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(name, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(name);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					name2 = ref managedSpanWrapper;
					param2 = param;
					ver2 = ver;
					if (!StringMarshaller.TryMarshalEmptyOrNullString(prefix, ref managedSpanWrapper2))
					{
						readOnlySpan2 = Il2CppSystem.MemoryExtensions.AsSpan(prefix);
						fixed (char* begin2 = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan2)).GetPinnableReference())
						{
							managedSpanWrapper2 = new ManagedSpanWrapper(begin2, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan2)).Length);
							return QueueConfig_Injected(ref name2, param2, ver2, ref managedSpanWrapper2);
						}
					}
					return QueueConfig_Injected(ref name2, param2, ver2, ref managedSpanWrapper2);
				}
			}
			name2 = ref managedSpanWrapper;
			param2 = param;
			ver2 = ver;
			if (!StringMarshaller.TryMarshalEmptyOrNullString(prefix, ref managedSpanWrapper2))
			{
				readOnlySpan2 = Il2CppSystem.MemoryExtensions.AsSpan(prefix);
				fixed (char* begin2 = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan2)).GetPinnableReference())
				{
					managedSpanWrapper2 = new ManagedSpanWrapper(begin2, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan2)).Length);
					return QueueConfig_Injected(ref name2, param2, ver2, ref managedSpanWrapper2);
				}
			}
			return QueueConfig_Injected(ref name2, param2, ver2, ref managedSpanWrapper2);
		}
		finally
		{
		}
	}

	public static bool SendDeviceInfoInConfigRequest()
	{
		return SendDeviceInfoInConfigRequestDelegateField();
	}

	public unsafe static void AddSessionTag(string tag)
	{
		//IL_0018: Expected O, but got Ref
		//IL_0024: Expected O, but got Ref
		//The blocks IL_0029 are reachable both inside and outside the pinned region starting at IL_0018. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(tag, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(tag);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					AddSessionTag_Injected(ref managedSpanWrapper);
					return;
				}
			}
			AddSessionTag_Injected(ref managedSpanWrapper);
		}
		finally
		{
		}
	}

	public void ForceUpdate()
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		ForceUpdate_Injected(intPtr);
	}

	public bool WasLastUpdatedFromServer()
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return WasLastUpdatedFromServer_Injected(intPtr);
	}

	public int GetInt(string key)
	{
		return GetInt(key, 0);
	}

	public unsafe int GetInt(string key, int defaultValue)
	{
		//IL_0028: Expected O, but got Ref
		//IL_0034: Expected O, but got Ref
		//The blocks IL_0039 are reachable both inside and outside the pinned region starting at IL_0028. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(key, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(key);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					return GetInt_Injected(intPtr, ref managedSpanWrapper, defaultValue);
				}
			}
			return GetInt_Injected(intPtr, ref managedSpanWrapper, defaultValue);
		}
		finally
		{
		}
	}

	public long GetLong(string key)
	{
		return GetLong(key, 0L);
	}

	public unsafe long GetLong(string key, long defaultValue)
	{
		//IL_0028: Expected O, but got Ref
		//IL_0034: Expected O, but got Ref
		//The blocks IL_0039 are reachable both inside and outside the pinned region starting at IL_0028. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(key, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(key);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					return GetLong_Injected(intPtr, ref managedSpanWrapper, defaultValue);
				}
			}
			return GetLong_Injected(intPtr, ref managedSpanWrapper, defaultValue);
		}
		finally
		{
		}
	}

	public float GetFloat(string key)
	{
		return GetFloat(key, 0f);
	}

	public unsafe float GetFloat(string key, float defaultValue)
	{
		//IL_0028: Expected O, but got Ref
		//IL_0034: Expected O, but got Ref
		//The blocks IL_0039 are reachable both inside and outside the pinned region starting at IL_0028. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(key, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(key);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					return GetFloat_Injected(intPtr, ref managedSpanWrapper, defaultValue);
				}
			}
			return GetFloat_Injected(intPtr, ref managedSpanWrapper, defaultValue);
		}
		finally
		{
		}
	}

	public string GetString(string key)
	{
		return GetString(key, "");
	}

	public unsafe string GetString(string key, string defaultValue)
	{
		//IL_0028: Expected O, but got Ref
		//IL_0034: Expected O, but got Ref
		//IL_0054: Expected O, but got Ref
		//IL_0062: Expected O, but got Ref
		//The blocks IL_0039, IL_0046, IL_0054, IL_0062, IL_0067 are reachable both inside and outside the pinned region starting at IL_0028. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		//The blocks IL_0067 are reachable both inside and outside the pinned region starting at IL_0054. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		//The blocks IL_0067 are reachable both inside and outside the pinned region starting at IL_0054. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
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
							GetString_Injected(intPtr, ref key2, ref managedSpanWrapper2, out ret);
						}
					}
					else
					{
						GetString_Injected(intPtr, ref key2, ref managedSpanWrapper2, out ret);
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
						GetString_Injected(intPtr, ref key2, ref managedSpanWrapper2, out ret);
					}
				}
				else
				{
					GetString_Injected(intPtr, ref key2, ref managedSpanWrapper2, out ret);
				}
			}
		}
		finally
		{
			stringAndDispose = OutStringMarshaller.GetStringAndDispose(ret);
		}
		return stringAndDispose;
	}

	public bool GetBool(string key)
	{
		return GetBool(key, defaultValue: false);
	}

	public unsafe bool GetBool(string key, bool defaultValue)
	{
		//IL_0028: Expected O, but got Ref
		//IL_0034: Expected O, but got Ref
		//The blocks IL_0039 are reachable both inside and outside the pinned region starting at IL_0028. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(key, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(key);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					return GetBool_Injected(intPtr, ref managedSpanWrapper, defaultValue);
				}
			}
			return GetBool_Injected(intPtr, ref managedSpanWrapper, defaultValue);
		}
		finally
		{
		}
	}

	public unsafe bool HasKey(string key)
	{
		//IL_0028: Expected O, but got Ref
		//IL_0034: Expected O, but got Ref
		//The blocks IL_0039 are reachable both inside and outside the pinned region starting at IL_0028. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(key, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(key);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					return HasKey_Injected(intPtr, ref managedSpanWrapper);
				}
			}
			return HasKey_Injected(intPtr, ref managedSpanWrapper);
		}
		finally
		{
		}
	}

	public int GetCount()
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return GetCount_Injected(intPtr);
	}

	public Il2CppStringArray GetKeys()
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return GetKeys_Injected(intPtr);
	}

	public T GetObject<T>([Optional] string key)
	{
		return ((Il2CppObjectBase)GetObject(Il2CppSystem.Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()), key)).Cast<T>();
	}

	public Il2CppSystem.Object GetObject(Il2CppSystem.Type type, [Optional] string key)
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

	public Il2CppSystem.Object GetObject(string key, Il2CppSystem.Object defaultValue)
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

	public unsafe Il2CppSystem.Object GetAsScriptingObject(Il2CppSystem.Type t, Il2CppSystem.Object defaultValue, string key)
	{
		//IL_002a: Expected O, but got Ref
		//IL_0036: Expected O, but got Ref
		//The blocks IL_003b are reachable both inside and outside the pinned region starting at IL_002a. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(key, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(key);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					return GetAsScriptingObject_Injected(intPtr, t, defaultValue, ref managedSpanWrapper);
				}
			}
			return GetAsScriptingObject_Injected(intPtr, t, defaultValue, ref managedSpanWrapper);
		}
		finally
		{
		}
	}

	public IDictionary<string, Il2CppSystem.Object> GetDictionary([Optional] string key)
	{
		UseSafeLock();
		IDictionary<string, Il2CppSystem.Object> dictionary = RemoteConfigSettingsHelper.GetDictionary(GetSafeTopMap(), key);
		ReleaseSafeLock();
		return dictionary;
	}

	public void UseSafeLock()
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		UseSafeLock_Injected(intPtr);
	}

	public void ReleaseSafeLock()
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		ReleaseSafeLock_Injected(intPtr);
	}

	public System.IntPtr GetSafeTopMap()
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return GetSafeTopMap_Injected(intPtr);
	}

	public unsafe static System.IntPtr Internal_Create_Injected(RemoteConfigSettings rcs, ref ManagedSpanWrapper configKey)
	{
		return Internal_Create_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rcs), (nint)Unsafe.AsPointer(ref configKey));
	}

	public unsafe static AnalyticsResult QueueConfig_Injected(ref ManagedSpanWrapper name, Il2CppSystem.Object param, int ver, ref ManagedSpanWrapper prefix)
	{
		return QueueConfig_InjectedDelegateField((nint)Unsafe.AsPointer(ref name), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)param), ver, (nint)Unsafe.AsPointer(ref prefix));
	}

	public unsafe static void AddSessionTag_Injected(ref ManagedSpanWrapper tag)
	{
		AddSessionTag_InjectedDelegateField((nint)Unsafe.AsPointer(ref tag));
	}

	public static void ForceUpdate_Injected(System.IntPtr _unity_self)
	{
		ForceUpdate_InjectedDelegateField(_unity_self);
	}

	public static bool WasLastUpdatedFromServer_Injected(System.IntPtr _unity_self)
	{
		return WasLastUpdatedFromServer_InjectedDelegateField(_unity_self);
	}

	public unsafe static int GetInt_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper key, int defaultValue)
	{
		return GetInt_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref key), defaultValue);
	}

	public unsafe static long GetLong_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper key, long defaultValue)
	{
		return GetLong_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref key), defaultValue);
	}

	public unsafe static float GetFloat_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper key, float defaultValue)
	{
		return GetFloat_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref key), defaultValue);
	}

	public unsafe static void GetString_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper key, ref ManagedSpanWrapper defaultValue, out ManagedSpanWrapper ret)
	{
		GetString_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref key), (nint)Unsafe.AsPointer(ref defaultValue), (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static bool GetBool_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper key, bool defaultValue)
	{
		return GetBool_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref key), defaultValue);
	}

	public unsafe static bool HasKey_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper key)
	{
		return HasKey_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref key));
	}

	public static int GetCount_Injected(System.IntPtr _unity_self)
	{
		return GetCount_InjectedDelegateField(_unity_self);
	}

	public static Il2CppStringArray GetKeys_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr intPtr = GetKeys_InjectedDelegateField(_unity_self);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr) : null;
	}

	public unsafe static Il2CppSystem.Object GetAsScriptingObject_Injected(System.IntPtr _unity_self, Il2CppSystem.Type t, Il2CppSystem.Object defaultValue, ref ManagedSpanWrapper key)
	{
		System.IntPtr intPtr = GetAsScriptingObject_InjectedDelegateField(_unity_self, IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)t), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)defaultValue), (nint)Unsafe.AsPointer(ref key));
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
	}

	public static void UseSafeLock_Injected(System.IntPtr _unity_self)
	{
		UseSafeLock_InjectedDelegateField(_unity_self);
	}

	public static void ReleaseSafeLock_Injected(System.IntPtr _unity_self)
	{
		ReleaseSafeLock_InjectedDelegateField(_unity_self);
	}

	public static System.IntPtr GetSafeTopMap_Injected(System.IntPtr _unity_self)
	{
		return GetSafeTopMap_InjectedDelegateField(_unity_self);
	}
}
