using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.Bindings;

namespace UnityEngine;

public sealed class Ping
{
	public static class BindingsMarshaller
	{
	}

	private delegate void Internal_DestroyDelegate(System.IntPtr ptr);

	private delegate System.IntPtr Internal_Create_InjectedDelegate(System.IntPtr address);

	private delegate bool Internal_IsDone_InjectedDelegate(System.IntPtr _unity_self);

	private delegate int get_time_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void get_ip_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr ret);

	private static readonly Internal_DestroyDelegate Internal_DestroyDelegateField = IL2CPP.ResolveICall<Internal_DestroyDelegate>("UnityEngine.Ping::Internal_Destroy");

	private static readonly Internal_Create_InjectedDelegate Internal_Create_InjectedDelegateField = IL2CPP.ResolveICall<Internal_Create_InjectedDelegate>("UnityEngine.Ping::Internal_Create_Injected");

	private static readonly Internal_IsDone_InjectedDelegate Internal_IsDone_InjectedDelegateField = IL2CPP.ResolveICall<Internal_IsDone_InjectedDelegate>("UnityEngine.Ping::Internal_IsDone_Injected");

	private static readonly get_time_InjectedDelegate get_time_InjectedDelegateField = IL2CPP.ResolveICall<get_time_InjectedDelegate>("UnityEngine.Ping::get_time_Injected");

	private static readonly get_ip_InjectedDelegate get_ip_InjectedDelegateField = IL2CPP.ResolveICall<get_ip_InjectedDelegate>("UnityEngine.Ping::get_ip_Injected");

	public bool isDone
	{
		get
		{
			throw new System.NotSupportedException("Method unstripping failed");
		}
	}

	public int time
	{
		get
		{
			System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object)(object)this);
			}
			return get_time_Injected(intPtr);
		}
	}

	public string ip
	{
		get
		{
			Unsafe.SkipInit(out ManagedSpanWrapper ret);
			string stringAndDispose;
			try
			{
				System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
				if (intPtr == (System.IntPtr)0)
				{
					UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object)(object)this);
				}
				get_ip_Injected(intPtr, out ret);
			}
			finally
			{
				stringAndDispose = OutStringMarshaller.GetStringAndDispose(ret);
			}
			return stringAndDispose;
		}
	}

	~Ping()
	{
		try
		{
			DestroyPing();
		}
		finally
		{
			((Il2CppSystem.Object)this).Finalize();
		}
	}

	public void DestroyPing()
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public static void Internal_Destroy(System.IntPtr ptr)
	{
		Internal_DestroyDelegateField(ptr);
	}

	public unsafe static System.IntPtr Internal_Create(string address)
	{
		//IL_0018: Expected O, but got Ref
		//IL_0024: Expected O, but got Ref
		//The blocks IL_0029 are reachable both inside and outside the pinned region starting at IL_0018. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(address, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(address);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					return Internal_Create_Injected(ref managedSpanWrapper);
				}
			}
			return Internal_Create_Injected(ref managedSpanWrapper);
		}
		finally
		{
		}
	}

	public bool Internal_IsDone()
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object)(object)this);
		}
		return Internal_IsDone_Injected(intPtr);
	}

	public unsafe static System.IntPtr Internal_Create_Injected(ref ManagedSpanWrapper address)
	{
		return Internal_Create_InjectedDelegateField((nint)Unsafe.AsPointer(ref address));
	}

	public static bool Internal_IsDone_Injected(System.IntPtr _unity_self)
	{
		return Internal_IsDone_InjectedDelegateField(_unity_self);
	}

	public static int get_time_Injected(System.IntPtr _unity_self)
	{
		return get_time_InjectedDelegateField(_unity_self);
	}

	public unsafe static void get_ip_Injected(System.IntPtr _unity_self, out ManagedSpanWrapper ret)
	{
		get_ip_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}
}
