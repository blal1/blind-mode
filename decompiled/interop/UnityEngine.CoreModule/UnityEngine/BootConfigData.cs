using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Bindings;

namespace UnityEngine;

public class BootConfigData : Il2CppSystem.Object
{
	public static class BindingsMarshaller
	{
	}

	private delegate void Append_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr key, System.IntPtr value);

	private delegate void Set_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr key, System.IntPtr value);

	private delegate void GetValue_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr key, int index, [Out] System.IntPtr ret);

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Ptr;

	private static readonly System.IntPtr NativeMethodInfoPtr_WrapBootConfigData_Private_Static_BootConfigData_IntPtr_0;

	private static readonly Append_InjectedDelegate Append_InjectedDelegateField;

	private static readonly Set_InjectedDelegate Set_InjectedDelegateField;

	private static readonly GetValue_InjectedDelegate GetValue_InjectedDelegateField;

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

	static BootConfigData()
	{
		Il2CppClassPointerStore<BootConfigData>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "BootConfigData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BootConfigData>.NativeClassPtr);
		NativeFieldInfoPtr_m_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BootConfigData>.NativeClassPtr, "m_Ptr");
		NativeMethodInfoPtr_WrapBootConfigData_Private_Static_BootConfigData_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BootConfigData>.NativeClassPtr, 100663867);
		Append_InjectedDelegateField = IL2CPP.ResolveICall<Append_InjectedDelegate>("UnityEngine.BootConfigData::Append_Injected");
		Set_InjectedDelegateField = IL2CPP.ResolveICall<Set_InjectedDelegate>("UnityEngine.BootConfigData::Set_Injected");
		GetValue_InjectedDelegateField = IL2CPP.ResolveICall<GetValue_InjectedDelegate>("UnityEngine.BootConfigData::GetValue_Injected");
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1168082, XrefRangeEnd = 1168086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static BootConfigData WrapBootConfigData(System.IntPtr nativeHandle)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&nativeHandle);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WrapBootConfigData_Private_Static_BootConfigData_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<BootConfigData>(intPtr2) : null;
	}

	public BootConfigData(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public void AddKey(string key)
	{
		Append(key, null);
	}

	public string Get(string key)
	{
		return GetValue(key, 0);
	}

	public string Get(string key, int index)
	{
		return GetValue(key, index);
	}

	public unsafe void Append(string key, string value)
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
					if (!StringMarshaller.TryMarshalEmptyOrNullString(value, ref managedSpanWrapper2))
					{
						readOnlySpan2 = Il2CppSystem.MemoryExtensions.AsSpan(value);
						fixed (char* begin2 = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan2)).GetPinnableReference())
						{
							managedSpanWrapper2 = new ManagedSpanWrapper(begin2, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan2)).Length);
							Append_Injected(intPtr, ref key2, ref managedSpanWrapper2);
							return;
						}
					}
					Append_Injected(intPtr, ref key2, ref managedSpanWrapper2);
					return;
				}
			}
			key2 = ref managedSpanWrapper;
			if (!StringMarshaller.TryMarshalEmptyOrNullString(value, ref managedSpanWrapper2))
			{
				readOnlySpan2 = Il2CppSystem.MemoryExtensions.AsSpan(value);
				fixed (char* begin2 = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan2)).GetPinnableReference())
				{
					managedSpanWrapper2 = new ManagedSpanWrapper(begin2, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan2)).Length);
					Append_Injected(intPtr, ref key2, ref managedSpanWrapper2);
					return;
				}
			}
			Append_Injected(intPtr, ref key2, ref managedSpanWrapper2);
		}
		finally
		{
		}
	}

	public unsafe void Set(string key, string value)
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
					if (!StringMarshaller.TryMarshalEmptyOrNullString(value, ref managedSpanWrapper2))
					{
						readOnlySpan2 = Il2CppSystem.MemoryExtensions.AsSpan(value);
						fixed (char* begin2 = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan2)).GetPinnableReference())
						{
							managedSpanWrapper2 = new ManagedSpanWrapper(begin2, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan2)).Length);
							Set_Injected(intPtr, ref key2, ref managedSpanWrapper2);
							return;
						}
					}
					Set_Injected(intPtr, ref key2, ref managedSpanWrapper2);
					return;
				}
			}
			key2 = ref managedSpanWrapper;
			if (!StringMarshaller.TryMarshalEmptyOrNullString(value, ref managedSpanWrapper2))
			{
				readOnlySpan2 = Il2CppSystem.MemoryExtensions.AsSpan(value);
				fixed (char* begin2 = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan2)).GetPinnableReference())
				{
					managedSpanWrapper2 = new ManagedSpanWrapper(begin2, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan2)).Length);
					Set_Injected(intPtr, ref key2, ref managedSpanWrapper2);
					return;
				}
			}
			Set_Injected(intPtr, ref key2, ref managedSpanWrapper2);
		}
		finally
		{
		}
	}

	public unsafe string GetValue(string key, int index)
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
			if (!StringMarshaller.TryMarshalEmptyOrNullString(key, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(key);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					GetValue_Injected(intPtr, ref managedSpanWrapper, index, out ret);
				}
			}
			else
			{
				GetValue_Injected(intPtr, ref managedSpanWrapper, index, out ret);
			}
		}
		finally
		{
			stringAndDispose = OutStringMarshaller.GetStringAndDispose(ret);
		}
		return stringAndDispose;
	}

	public unsafe static void Append_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper key, ref ManagedSpanWrapper value)
	{
		Append_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref key), (nint)Unsafe.AsPointer(ref value));
	}

	public unsafe static void Set_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper key, ref ManagedSpanWrapper value)
	{
		Set_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref key), (nint)Unsafe.AsPointer(ref value));
	}

	public unsafe static void GetValue_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper key, int index, out ManagedSpanWrapper ret)
	{
		GetValue_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref key), index, (nint)Unsafe.AsPointer(ref ret));
	}
}
