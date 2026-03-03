using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Bindings;

namespace UnityEngine.Analytics;

public class CustomEventData
{
	public static class BindingsMarshaller
	{
	}

	private delegate void Internal_DestroyDelegate(System.IntPtr ptr);

	private delegate System.IntPtr Internal_Create_InjectedDelegate(System.IntPtr ced, System.IntPtr name);

	private delegate bool AddString_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr key, System.IntPtr value);

	private delegate bool AddInt32_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr key, int value);

	private delegate bool AddUInt32_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr key, uint value);

	private delegate bool AddInt64_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr key, long value);

	private delegate bool AddUInt64_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr key, ulong value);

	private delegate bool AddBool_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr key, bool value);

	private delegate bool AddDouble_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr key, double value);

	private static readonly Internal_DestroyDelegate Internal_DestroyDelegateField = IL2CPP.ResolveICall<Internal_DestroyDelegate>("UnityEngine.Analytics.CustomEventData::Internal_Destroy");

	private static readonly Internal_Create_InjectedDelegate Internal_Create_InjectedDelegateField = IL2CPP.ResolveICall<Internal_Create_InjectedDelegate>("UnityEngine.Analytics.CustomEventData::Internal_Create_Injected");

	private static readonly AddString_InjectedDelegate AddString_InjectedDelegateField = IL2CPP.ResolveICall<AddString_InjectedDelegate>("UnityEngine.Analytics.CustomEventData::AddString_Injected");

	private static readonly AddInt32_InjectedDelegate AddInt32_InjectedDelegateField = IL2CPP.ResolveICall<AddInt32_InjectedDelegate>("UnityEngine.Analytics.CustomEventData::AddInt32_Injected");

	private static readonly AddUInt32_InjectedDelegate AddUInt32_InjectedDelegateField = IL2CPP.ResolveICall<AddUInt32_InjectedDelegate>("UnityEngine.Analytics.CustomEventData::AddUInt32_Injected");

	private static readonly AddInt64_InjectedDelegate AddInt64_InjectedDelegateField = IL2CPP.ResolveICall<AddInt64_InjectedDelegate>("UnityEngine.Analytics.CustomEventData::AddInt64_Injected");

	private static readonly AddUInt64_InjectedDelegate AddUInt64_InjectedDelegateField = IL2CPP.ResolveICall<AddUInt64_InjectedDelegate>("UnityEngine.Analytics.CustomEventData::AddUInt64_Injected");

	private static readonly AddBool_InjectedDelegate AddBool_InjectedDelegateField = IL2CPP.ResolveICall<AddBool_InjectedDelegate>("UnityEngine.Analytics.CustomEventData::AddBool_Injected");

	private static readonly AddDouble_InjectedDelegate AddDouble_InjectedDelegateField = IL2CPP.ResolveICall<AddDouble_InjectedDelegate>("UnityEngine.Analytics.CustomEventData::AddDouble_Injected");

	~CustomEventData()
	{
		try
		{
			Destroy();
		}
		finally
		{
			((Il2CppSystem.Object)this).Finalize();
		}
	}

	public void Destroy()
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public void Dispose()
	{
		Destroy();
		Il2CppSystem.GC.SuppressFinalize((Il2CppSystem.Object)(object)this);
	}

	public unsafe static System.IntPtr Internal_Create(CustomEventData ced, string name)
	{
		//IL_0019: Expected O, but got Ref
		//IL_0025: Expected O, but got Ref
		//The blocks IL_002a are reachable both inside and outside the pinned region starting at IL_0019. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(name, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(name);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					return Internal_Create_Injected(ced, ref managedSpanWrapper);
				}
			}
			return Internal_Create_Injected(ced, ref managedSpanWrapper);
		}
		finally
		{
		}
	}

	public static void Internal_Destroy(System.IntPtr ptr)
	{
		Internal_DestroyDelegateField(ptr);
	}

	public unsafe bool AddString(string key, string value)
	{
		//IL_0028: Expected O, but got Ref
		//IL_0034: Expected O, but got Ref
		//IL_0054: Expected O, but got Ref
		//IL_0062: Expected O, but got Ref
		//The blocks IL_0039, IL_0046, IL_0054, IL_0062, IL_0067 are reachable both inside and outside the pinned region starting at IL_0028. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		//The blocks IL_0067 are reachable both inside and outside the pinned region starting at IL_0054. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		//The blocks IL_0067 are reachable both inside and outside the pinned region starting at IL_0054. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object)(object)this);
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
					if (!StringMarshaller.TryMarshalEmptyOrNullString(value, ref managedSpanWrapper2))
					{
						readOnlySpan2 = Il2CppSystem.MemoryExtensions.AsSpan(value);
						fixed (char* begin2 = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan2)).GetPinnableReference())
						{
							managedSpanWrapper2 = new ManagedSpanWrapper(begin2, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan2)).Length);
							return AddString_Injected(intPtr, ref key2, ref managedSpanWrapper2);
						}
					}
					return AddString_Injected(intPtr, ref key2, ref managedSpanWrapper2);
				}
			}
			key2 = ref managedSpanWrapper;
			if (!StringMarshaller.TryMarshalEmptyOrNullString(value, ref managedSpanWrapper2))
			{
				readOnlySpan2 = Il2CppSystem.MemoryExtensions.AsSpan(value);
				fixed (char* begin2 = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan2)).GetPinnableReference())
				{
					managedSpanWrapper2 = new ManagedSpanWrapper(begin2, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan2)).Length);
					return AddString_Injected(intPtr, ref key2, ref managedSpanWrapper2);
				}
			}
			return AddString_Injected(intPtr, ref key2, ref managedSpanWrapper2);
		}
		finally
		{
		}
	}

	public unsafe bool AddInt32(string key, int value)
	{
		//IL_0028: Expected O, but got Ref
		//IL_0034: Expected O, but got Ref
		//The blocks IL_0039 are reachable both inside and outside the pinned region starting at IL_0028. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object)(object)this);
			}
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(key, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(key);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					return AddInt32_Injected(intPtr, ref managedSpanWrapper, value);
				}
			}
			return AddInt32_Injected(intPtr, ref managedSpanWrapper, value);
		}
		finally
		{
		}
	}

	public unsafe bool AddUInt32(string key, uint value)
	{
		//IL_0028: Expected O, but got Ref
		//IL_0034: Expected O, but got Ref
		//The blocks IL_0039 are reachable both inside and outside the pinned region starting at IL_0028. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object)(object)this);
			}
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(key, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(key);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					return AddUInt32_Injected(intPtr, ref managedSpanWrapper, value);
				}
			}
			return AddUInt32_Injected(intPtr, ref managedSpanWrapper, value);
		}
		finally
		{
		}
	}

	public unsafe bool AddInt64(string key, long value)
	{
		//IL_0028: Expected O, but got Ref
		//IL_0034: Expected O, but got Ref
		//The blocks IL_0039 are reachable both inside and outside the pinned region starting at IL_0028. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object)(object)this);
			}
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(key, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(key);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					return AddInt64_Injected(intPtr, ref managedSpanWrapper, value);
				}
			}
			return AddInt64_Injected(intPtr, ref managedSpanWrapper, value);
		}
		finally
		{
		}
	}

	public unsafe bool AddUInt64(string key, ulong value)
	{
		//IL_0028: Expected O, but got Ref
		//IL_0034: Expected O, but got Ref
		//The blocks IL_0039 are reachable both inside and outside the pinned region starting at IL_0028. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object)(object)this);
			}
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(key, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(key);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					return AddUInt64_Injected(intPtr, ref managedSpanWrapper, value);
				}
			}
			return AddUInt64_Injected(intPtr, ref managedSpanWrapper, value);
		}
		finally
		{
		}
	}

	public unsafe bool AddBool(string key, bool value)
	{
		//IL_0028: Expected O, but got Ref
		//IL_0034: Expected O, but got Ref
		//The blocks IL_0039 are reachable both inside and outside the pinned region starting at IL_0028. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object)(object)this);
			}
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(key, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(key);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					return AddBool_Injected(intPtr, ref managedSpanWrapper, value);
				}
			}
			return AddBool_Injected(intPtr, ref managedSpanWrapper, value);
		}
		finally
		{
		}
	}

	public unsafe bool AddDouble(string key, double value)
	{
		//IL_0028: Expected O, but got Ref
		//IL_0034: Expected O, but got Ref
		//The blocks IL_0039 are reachable both inside and outside the pinned region starting at IL_0028. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object)(object)this);
			}
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(key, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(key);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					return AddDouble_Injected(intPtr, ref managedSpanWrapper, value);
				}
			}
			return AddDouble_Injected(intPtr, ref managedSpanWrapper, value);
		}
		finally
		{
		}
	}

	public unsafe bool AddDictionary(IDictionary<string, Il2CppSystem.Object> eventData)
	{
		//IL_001d: Expected O, but got Ref
		//IL_0025: Expected O, but got Ref
		//IL_0195: Expected O, but got Ref
		IEnumerator<KeyValuePair<string, Il2CppSystem.Object>> enumerator = ((IEnumerable<KeyValuePair<string, Il2CppSystem.Object>>)(object)eventData).GetEnumerator();
		try
		{
			while (((IEnumerator)(object)enumerator).MoveNext())
			{
				KeyValuePair<string, Il2CppSystem.Object> current = enumerator.Current;
				string key = ((KeyValuePair<string, Il2CppSystem.Object>)(&current)).Key;
				Il2CppSystem.Object value = ((KeyValuePair<string, Il2CppSystem.Object>)(&current)).Value;
				if (value == null)
				{
					AddString(key, "null");
					continue;
				}
				Il2CppSystem.Type type = value.GetType();
				if (type == Il2CppSystem.Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<string>()))
				{
					AddString(key, ((Il2CppObjectBase)value).Cast<string>());
					continue;
				}
				if (type == Il2CppSystem.Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<char>()))
				{
					AddString(key, Il2CppSystem.Char.ToString((char)(object)value));
					continue;
				}
				if (type == Il2CppSystem.Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<sbyte>()))
				{
					AddInt32(key, (sbyte)(object)value);
					continue;
				}
				if (type == Il2CppSystem.Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<byte>()))
				{
					AddInt32(key, (byte)(object)value);
					continue;
				}
				if (type == Il2CppSystem.Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<short>()))
				{
					AddInt32(key, (short)(object)value);
					continue;
				}
				if (type == Il2CppSystem.Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<ushort>()))
				{
					AddUInt32(key, (ushort)(object)value);
					continue;
				}
				if (type == Il2CppSystem.Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<int>()))
				{
					AddInt32(key, (int)(object)value);
					continue;
				}
				if (type == Il2CppSystem.Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<uint>()))
				{
					AddUInt32(((KeyValuePair<string, Il2CppSystem.Object>)(&current)).Key, (uint)(object)value);
					continue;
				}
				if (type == Il2CppSystem.Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<long>()))
				{
					AddInt64(key, (long)(object)value);
					continue;
				}
				if (type == Il2CppSystem.Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<ulong>()))
				{
					AddUInt64(key, (ulong)(object)value);
					continue;
				}
				if (type == Il2CppSystem.Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<bool>()))
				{
					AddBool(key, (bool)(object)value);
					continue;
				}
				if (type == Il2CppSystem.Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<float>()))
				{
					AddDouble(key, (double)Il2CppSystem.Convert.ToDecimal((float)(object)value));
					continue;
				}
				if (type == Il2CppSystem.Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<double>()))
				{
					AddDouble(key, (double)(object)value);
					continue;
				}
				if (type == Il2CppSystem.Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<Il2CppSystem.Decimal>()))
				{
					AddDouble(key, (double)Il2CppSystem.Convert.ToDecimal((Il2CppSystem.Decimal)(object)value));
					continue;
				}
				if (type.IsValueType)
				{
					AddString(key, value.ToString());
					continue;
				}
				throw new Il2CppSystem.ArgumentException(Il2CppSystem.String.Format("Invalid type: {0} passed", (Il2CppSystem.Object)type));
			}
		}
		finally
		{
			((Il2CppSystem.IDisposable)(object)enumerator)?.Dispose();
		}
		return true;
	}

	public unsafe static System.IntPtr Internal_Create_Injected(CustomEventData ced, ref ManagedSpanWrapper name)
	{
		return Internal_Create_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ced), (nint)Unsafe.AsPointer(ref name));
	}

	public unsafe static bool AddString_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper key, ref ManagedSpanWrapper value)
	{
		return AddString_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref key), (nint)Unsafe.AsPointer(ref value));
	}

	public unsafe static bool AddInt32_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper key, int value)
	{
		return AddInt32_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref key), value);
	}

	public unsafe static bool AddUInt32_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper key, uint value)
	{
		return AddUInt32_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref key), value);
	}

	public unsafe static bool AddInt64_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper key, long value)
	{
		return AddInt64_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref key), value);
	}

	public unsafe static bool AddUInt64_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper key, ulong value)
	{
		return AddUInt64_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref key), value);
	}

	public unsafe static bool AddBool_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper key, bool value)
	{
		return AddBool_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref key), value);
	}

	public unsafe static bool AddDouble_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper key, double value)
	{
		return AddDouble_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref key), value);
	}
}
