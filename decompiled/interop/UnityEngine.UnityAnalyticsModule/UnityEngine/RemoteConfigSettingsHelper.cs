using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Bindings;

namespace UnityEngine;

public static class RemoteConfigSettingsHelper : Il2CppSystem.Object
{
	[OriginalName("UnityEngine.UnityAnalyticsModule.dll", "", "Tag")]
	public enum Tag
	{
		kUnknown,
		kIntVal,
		kInt64Val,
		kUInt64Val,
		kDoubleVal,
		kBoolVal,
		kStringVal,
		kArrayVal,
		kMixedArrayVal,
		kMapVal,
		kMaxTags
	}

	private delegate System.IntPtr GetSafeMapKeysDelegate(System.IntPtr m);

	private delegate long GetSafeArraySizeDelegate(System.IntPtr a);

	private delegate System.IntPtr GetSafeArrayArrayDelegate(System.IntPtr a, long i);

	private delegate System.IntPtr GetSafeArrayMapDelegate(System.IntPtr a, long i);

	private delegate Tag GetSafeArrayTypeDelegate(System.IntPtr a, long i);

	private delegate long GetSafeNumberArrayDelegate(System.IntPtr a, long i);

	private delegate float GetSafeArrayFloatDelegate(System.IntPtr a, long i);

	private delegate bool GetSafeArrayBoolDelegate(System.IntPtr a, long i);

	private delegate System.IntPtr GetSafeMap_InjectedDelegate(System.IntPtr m, System.IntPtr key);

	private delegate void GetSafeMapTypes_InjectedDelegate(System.IntPtr m, [Out] System.IntPtr ret);

	private delegate long GetSafeNumber_InjectedDelegate(System.IntPtr m, System.IntPtr key, long defaultValue);

	private delegate float GetSafeFloat_InjectedDelegate(System.IntPtr m, System.IntPtr key, float defaultValue);

	private delegate bool GetSafeBool_InjectedDelegate(System.IntPtr m, System.IntPtr key, bool defaultValue);

	private delegate void GetSafeStringValue_InjectedDelegate(System.IntPtr m, System.IntPtr key, System.IntPtr defaultValue, [Out] System.IntPtr ret);

	private delegate System.IntPtr GetSafeArray_InjectedDelegate(System.IntPtr m, System.IntPtr key);

	private delegate void GetSafeArrayStringValue_InjectedDelegate(System.IntPtr a, long i, [Out] System.IntPtr ret);

	private static readonly GetSafeMapKeysDelegate GetSafeMapKeysDelegateField;

	private static readonly GetSafeArraySizeDelegate GetSafeArraySizeDelegateField;

	private static readonly GetSafeArrayArrayDelegate GetSafeArrayArrayDelegateField;

	private static readonly GetSafeArrayMapDelegate GetSafeArrayMapDelegateField;

	private static readonly GetSafeArrayTypeDelegate GetSafeArrayTypeDelegateField;

	private static readonly GetSafeNumberArrayDelegate GetSafeNumberArrayDelegateField;

	private static readonly GetSafeArrayFloatDelegate GetSafeArrayFloatDelegateField;

	private static readonly GetSafeArrayBoolDelegate GetSafeArrayBoolDelegateField;

	private static readonly GetSafeMap_InjectedDelegate GetSafeMap_InjectedDelegateField;

	private static readonly GetSafeMapTypes_InjectedDelegate GetSafeMapTypes_InjectedDelegateField;

	private static readonly GetSafeNumber_InjectedDelegate GetSafeNumber_InjectedDelegateField;

	private static readonly GetSafeFloat_InjectedDelegate GetSafeFloat_InjectedDelegateField;

	private static readonly GetSafeBool_InjectedDelegate GetSafeBool_InjectedDelegateField;

	private static readonly GetSafeStringValue_InjectedDelegate GetSafeStringValue_InjectedDelegateField;

	private static readonly GetSafeArray_InjectedDelegate GetSafeArray_InjectedDelegateField;

	private static readonly GetSafeArrayStringValue_InjectedDelegate GetSafeArrayStringValue_InjectedDelegateField;

	static RemoteConfigSettingsHelper()
	{
		Il2CppClassPointerStore<RemoteConfigSettingsHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UnityAnalyticsModule.dll", "UnityEngine", "RemoteConfigSettingsHelper");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemoteConfigSettingsHelper>.NativeClassPtr);
		GetSafeMapKeysDelegateField = IL2CPP.ResolveICall<GetSafeMapKeysDelegate>("UnityEngine.RemoteConfigSettingsHelper::GetSafeMapKeys");
		GetSafeArraySizeDelegateField = IL2CPP.ResolveICall<GetSafeArraySizeDelegate>("UnityEngine.RemoteConfigSettingsHelper::GetSafeArraySize");
		GetSafeArrayArrayDelegateField = IL2CPP.ResolveICall<GetSafeArrayArrayDelegate>("UnityEngine.RemoteConfigSettingsHelper::GetSafeArrayArray");
		GetSafeArrayMapDelegateField = IL2CPP.ResolveICall<GetSafeArrayMapDelegate>("UnityEngine.RemoteConfigSettingsHelper::GetSafeArrayMap");
		GetSafeArrayTypeDelegateField = IL2CPP.ResolveICall<GetSafeArrayTypeDelegate>("UnityEngine.RemoteConfigSettingsHelper::GetSafeArrayType");
		GetSafeNumberArrayDelegateField = IL2CPP.ResolveICall<GetSafeNumberArrayDelegate>("UnityEngine.RemoteConfigSettingsHelper::GetSafeNumberArray");
		GetSafeArrayFloatDelegateField = IL2CPP.ResolveICall<GetSafeArrayFloatDelegate>("UnityEngine.RemoteConfigSettingsHelper::GetSafeArrayFloat");
		GetSafeArrayBoolDelegateField = IL2CPP.ResolveICall<GetSafeArrayBoolDelegate>("UnityEngine.RemoteConfigSettingsHelper::GetSafeArrayBool");
		GetSafeMap_InjectedDelegateField = IL2CPP.ResolveICall<GetSafeMap_InjectedDelegate>("UnityEngine.RemoteConfigSettingsHelper::GetSafeMap_Injected");
		GetSafeMapTypes_InjectedDelegateField = IL2CPP.ResolveICall<GetSafeMapTypes_InjectedDelegate>("UnityEngine.RemoteConfigSettingsHelper::GetSafeMapTypes_Injected");
		GetSafeNumber_InjectedDelegateField = IL2CPP.ResolveICall<GetSafeNumber_InjectedDelegate>("UnityEngine.RemoteConfigSettingsHelper::GetSafeNumber_Injected");
		GetSafeFloat_InjectedDelegateField = IL2CPP.ResolveICall<GetSafeFloat_InjectedDelegate>("UnityEngine.RemoteConfigSettingsHelper::GetSafeFloat_Injected");
		GetSafeBool_InjectedDelegateField = IL2CPP.ResolveICall<GetSafeBool_InjectedDelegate>("UnityEngine.RemoteConfigSettingsHelper::GetSafeBool_Injected");
		GetSafeStringValue_InjectedDelegateField = IL2CPP.ResolveICall<GetSafeStringValue_InjectedDelegate>("UnityEngine.RemoteConfigSettingsHelper::GetSafeStringValue_Injected");
		GetSafeArray_InjectedDelegateField = IL2CPP.ResolveICall<GetSafeArray_InjectedDelegate>("UnityEngine.RemoteConfigSettingsHelper::GetSafeArray_Injected");
		GetSafeArrayStringValue_InjectedDelegateField = IL2CPP.ResolveICall<GetSafeArrayStringValue_InjectedDelegate>("UnityEngine.RemoteConfigSettingsHelper::GetSafeArrayStringValue_Injected");
	}

	public RemoteConfigSettingsHelper(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public unsafe static System.IntPtr GetSafeMap(System.IntPtr m, string key)
	{
		//IL_0019: Expected O, but got Ref
		//IL_0025: Expected O, but got Ref
		//The blocks IL_002a are reachable both inside and outside the pinned region starting at IL_0019. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(key, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(key);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					return GetSafeMap_Injected(m, ref managedSpanWrapper);
				}
			}
			return GetSafeMap_Injected(m, ref managedSpanWrapper);
		}
		finally
		{
		}
	}

	public static Il2CppStringArray GetSafeMapKeys(System.IntPtr m)
	{
		System.IntPtr intPtr = GetSafeMapKeysDelegateField(m);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr) : null;
	}

	public unsafe static Il2CppStructArray<Tag> GetSafeMapTypes(System.IntPtr m)
	{
		Unsafe.SkipInit(out BlittableArrayWrapper ret);
		Il2CppStructArray<Tag> result;
		try
		{
			GetSafeMapTypes_Injected(m, out ret);
		}
		finally
		{
			Unsafe.SkipInit(out Il2CppStructArray<Tag> array);
			ret.Unmarshal(ref *(Il2CppArrayBase<Tag>*)(&array));
			result = array;
		}
		return result;
	}

	public unsafe static long GetSafeNumber(System.IntPtr m, string key, long defaultValue)
	{
		//IL_0019: Expected O, but got Ref
		//IL_0025: Expected O, but got Ref
		//The blocks IL_002a are reachable both inside and outside the pinned region starting at IL_0019. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(key, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(key);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					return GetSafeNumber_Injected(m, ref managedSpanWrapper, defaultValue);
				}
			}
			return GetSafeNumber_Injected(m, ref managedSpanWrapper, defaultValue);
		}
		finally
		{
		}
	}

	public unsafe static float GetSafeFloat(System.IntPtr m, string key, float defaultValue)
	{
		//IL_0019: Expected O, but got Ref
		//IL_0025: Expected O, but got Ref
		//The blocks IL_002a are reachable both inside and outside the pinned region starting at IL_0019. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(key, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(key);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					return GetSafeFloat_Injected(m, ref managedSpanWrapper, defaultValue);
				}
			}
			return GetSafeFloat_Injected(m, ref managedSpanWrapper, defaultValue);
		}
		finally
		{
		}
	}

	public unsafe static bool GetSafeBool(System.IntPtr m, string key, bool defaultValue)
	{
		//IL_0019: Expected O, but got Ref
		//IL_0025: Expected O, but got Ref
		//The blocks IL_002a are reachable both inside and outside the pinned region starting at IL_0019. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(key, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(key);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					return GetSafeBool_Injected(m, ref managedSpanWrapper, defaultValue);
				}
			}
			return GetSafeBool_Injected(m, ref managedSpanWrapper, defaultValue);
		}
		finally
		{
		}
	}

	public unsafe static string GetSafeStringValue(System.IntPtr m, string key, string defaultValue)
	{
		//IL_0019: Expected O, but got Ref
		//IL_0025: Expected O, but got Ref
		//IL_0045: Expected O, but got Ref
		//IL_0053: Expected O, but got Ref
		//The blocks IL_002a, IL_0037, IL_0045, IL_0053, IL_0058 are reachable both inside and outside the pinned region starting at IL_0019. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		//The blocks IL_0058 are reachable both inside and outside the pinned region starting at IL_0045. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		//The blocks IL_0058 are reachable both inside and outside the pinned region starting at IL_0045. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
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
							GetSafeStringValue_Injected(m, ref key2, ref managedSpanWrapper2, out ret);
						}
					}
					else
					{
						GetSafeStringValue_Injected(m, ref key2, ref managedSpanWrapper2, out ret);
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
						GetSafeStringValue_Injected(m, ref key2, ref managedSpanWrapper2, out ret);
					}
				}
				else
				{
					GetSafeStringValue_Injected(m, ref key2, ref managedSpanWrapper2, out ret);
				}
			}
		}
		finally
		{
			stringAndDispose = OutStringMarshaller.GetStringAndDispose(ret);
		}
		return stringAndDispose;
	}

	public unsafe static System.IntPtr GetSafeArray(System.IntPtr m, string key)
	{
		//IL_0019: Expected O, but got Ref
		//IL_0025: Expected O, but got Ref
		//The blocks IL_002a are reachable both inside and outside the pinned region starting at IL_0019. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(key, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(key);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					return GetSafeArray_Injected(m, ref managedSpanWrapper);
				}
			}
			return GetSafeArray_Injected(m, ref managedSpanWrapper);
		}
		finally
		{
		}
	}

	public static long GetSafeArraySize(System.IntPtr a)
	{
		return GetSafeArraySizeDelegateField(a);
	}

	public static System.IntPtr GetSafeArrayArray(System.IntPtr a, long i)
	{
		return GetSafeArrayArrayDelegateField(a, i);
	}

	public static System.IntPtr GetSafeArrayMap(System.IntPtr a, long i)
	{
		return GetSafeArrayMapDelegateField(a, i);
	}

	public static Tag GetSafeArrayType(System.IntPtr a, long i)
	{
		return GetSafeArrayTypeDelegateField(a, i);
	}

	public static long GetSafeNumberArray(System.IntPtr a, long i)
	{
		return GetSafeNumberArrayDelegateField(a, i);
	}

	public static float GetSafeArrayFloat(System.IntPtr a, long i)
	{
		return GetSafeArrayFloatDelegateField(a, i);
	}

	public static bool GetSafeArrayBool(System.IntPtr a, long i)
	{
		return GetSafeArrayBoolDelegateField(a, i);
	}

	public static string GetSafeArrayStringValue(System.IntPtr a, long i)
	{
		Unsafe.SkipInit(out ManagedSpanWrapper ret);
		string stringAndDispose;
		try
		{
			GetSafeArrayStringValue_Injected(a, i, out ret);
		}
		finally
		{
			stringAndDispose = OutStringMarshaller.GetStringAndDispose(ret);
		}
		return stringAndDispose;
	}

	public static IDictionary<string, Il2CppSystem.Object> GetDictionary(System.IntPtr m, string key)
	{
		if (m == Il2CppSystem.IntPtr.Zero)
		{
			return null;
		}
		if (!Il2CppSystem.String.IsNullOrEmpty(key))
		{
			m = GetSafeMap(m, key);
			if (m == Il2CppSystem.IntPtr.Zero)
			{
				return null;
			}
		}
		return GetDictionary(m);
	}

	public static IDictionary<string, Il2CppSystem.Object> GetDictionary(System.IntPtr m)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public static Il2CppSystem.Object GetArrayArrayEntries(System.IntPtr a, long i)
	{
		return GetArrayEntries(GetSafeArrayArray(a, i));
	}

	public static IDictionary<string, Il2CppSystem.Object> GetArrayMapEntries(System.IntPtr a, long i)
	{
		return GetDictionary(GetSafeArrayMap(a, i));
	}

	public static Il2CppArrayBase<T> GetArrayEntriesType<T>(System.IntPtr a, long size, Il2CppSystem.Func<System.IntPtr, long, T> f)
	{
		Il2CppArrayBase<T> val = (Il2CppArrayBase<T>)(object)new Il2CppReferenceArray<T>((long)checked((nint)size));
		for (long num = 0L; num < size; num++)
		{
			val[(int)checked((nint)num)] = f.Invoke(a, num);
		}
		return val;
	}

	public unsafe static Il2CppSystem.Object GetArrayEntries(System.IntPtr a)
	{
		long safeArraySize = GetSafeArraySize(a);
		if (safeArraySize == 0)
		{
			return null;
		}
		switch (GetSafeArrayType(a, 0L))
		{
		case Tag.kIntVal:
		case Tag.kInt64Val:
			return (Il2CppSystem.Object)(object)GetArrayEntriesType(a, safeArraySize, new Il2CppSystem.Func<System.IntPtr, long, long>(null, (nint)(delegate*<System.IntPtr, long, long>)(&GetSafeNumberArray)));
		case Tag.kDoubleVal:
			return (Il2CppSystem.Object)(object)GetArrayEntriesType(a, safeArraySize, new Il2CppSystem.Func<System.IntPtr, long, float>(null, (nint)(delegate*<System.IntPtr, long, float>)(&GetSafeArrayFloat)));
		case Tag.kBoolVal:
			return (Il2CppSystem.Object)(object)GetArrayEntriesType(a, safeArraySize, new Il2CppSystem.Func<System.IntPtr, long, bool>(null, (nint)(delegate*<System.IntPtr, long, bool>)(&GetSafeArrayBool)));
		case Tag.kStringVal:
			return (Il2CppSystem.Object)(object)GetArrayEntriesType(a, safeArraySize, new Il2CppSystem.Func<System.IntPtr, long, string>(null, (nint)(delegate*<System.IntPtr, long, string>)(&GetSafeArrayStringValue)));
		case Tag.kArrayVal:
			return (Il2CppSystem.Object)(object)GetArrayEntriesType(a, safeArraySize, new Il2CppSystem.Func<System.IntPtr, long, Il2CppSystem.Object>(null, (nint)(delegate*<System.IntPtr, long, Il2CppSystem.Object>)(&GetArrayArrayEntries)));
		case Tag.kMapVal:
			return (Il2CppSystem.Object)(object)GetArrayEntriesType(a, safeArraySize, new Il2CppSystem.Func<System.IntPtr, long, IDictionary<string, Il2CppSystem.Object>>(null, (nint)(delegate*<System.IntPtr, long, IDictionary<string, Il2CppSystem.Object>>)(&GetArrayMapEntries)));
		default:
			return null;
		}
	}

	public static Il2CppSystem.Object GetMixedArrayEntries(System.IntPtr a)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public static void SetDictKeyType(System.IntPtr m, IDictionary<string, Il2CppSystem.Object> dict, string key, Tag tag)
	{
		switch (tag)
		{
		case Tag.kIntVal:
		case Tag.kInt64Val:
			dict[key] = (Il2CppSystem.Object)(object)GetSafeNumber(m, key, 0L);
			break;
		case Tag.kDoubleVal:
			dict[key] = (Il2CppSystem.Object)(object)GetSafeFloat(m, key, 0f);
			break;
		case Tag.kBoolVal:
			dict[key] = (Il2CppSystem.Object)(object)GetSafeBool(m, key, defaultValue: false);
			break;
		case Tag.kStringVal:
			dict[key] = GetSafeStringValue(m, key, "");
			break;
		case Tag.kArrayVal:
			dict[key] = GetArrayEntries(GetSafeArray(m, key));
			break;
		case Tag.kMixedArrayVal:
			dict[key] = GetMixedArrayEntries(GetSafeArray(m, key));
			break;
		case Tag.kMapVal:
			dict[key] = (Il2CppSystem.Object)(object)GetDictionary(GetSafeMap(m, key));
			break;
		case Tag.kUInt64Val:
			break;
		}
	}

	public unsafe static System.IntPtr GetSafeMap_Injected(System.IntPtr m, ref ManagedSpanWrapper key)
	{
		return GetSafeMap_InjectedDelegateField(m, (nint)Unsafe.AsPointer(ref key));
	}

	public unsafe static void GetSafeMapTypes_Injected(System.IntPtr m, out BlittableArrayWrapper ret)
	{
		GetSafeMapTypes_InjectedDelegateField(m, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static long GetSafeNumber_Injected(System.IntPtr m, ref ManagedSpanWrapper key, long defaultValue)
	{
		return GetSafeNumber_InjectedDelegateField(m, (nint)Unsafe.AsPointer(ref key), defaultValue);
	}

	public unsafe static float GetSafeFloat_Injected(System.IntPtr m, ref ManagedSpanWrapper key, float defaultValue)
	{
		return GetSafeFloat_InjectedDelegateField(m, (nint)Unsafe.AsPointer(ref key), defaultValue);
	}

	public unsafe static bool GetSafeBool_Injected(System.IntPtr m, ref ManagedSpanWrapper key, bool defaultValue)
	{
		return GetSafeBool_InjectedDelegateField(m, (nint)Unsafe.AsPointer(ref key), defaultValue);
	}

	public unsafe static void GetSafeStringValue_Injected(System.IntPtr m, ref ManagedSpanWrapper key, ref ManagedSpanWrapper defaultValue, out ManagedSpanWrapper ret)
	{
		GetSafeStringValue_InjectedDelegateField(m, (nint)Unsafe.AsPointer(ref key), (nint)Unsafe.AsPointer(ref defaultValue), (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static System.IntPtr GetSafeArray_Injected(System.IntPtr m, ref ManagedSpanWrapper key)
	{
		return GetSafeArray_InjectedDelegateField(m, (nint)Unsafe.AsPointer(ref key));
	}

	public unsafe static void GetSafeArrayStringValue_Injected(System.IntPtr a, long i, out ManagedSpanWrapper ret)
	{
		GetSafeArrayStringValue_InjectedDelegateField(a, i, (nint)Unsafe.AsPointer(ref ret));
	}
}
