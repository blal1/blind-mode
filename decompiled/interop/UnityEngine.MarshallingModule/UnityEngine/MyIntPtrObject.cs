using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.Bindings;

namespace UnityEngine;

public class MyIntPtrObject
{
	public static class BindingsMarshaller
	{
	}

	private delegate System.IntPtr Internal_CreateDelegate();

	private delegate void Internal_DestroyDelegate(System.IntPtr ptr);

	private delegate System.IntPtr Create_InjectedDelegate();

	private delegate int MemberFunction_InjectedDelegate(System.IntPtr _unity_self, int a);

	private delegate int get_MemberProperty_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_MemberProperty_InjectedDelegate(System.IntPtr _unity_self, int value);

	private static readonly Internal_CreateDelegate Internal_CreateDelegateField = IL2CPP.ResolveICall<Internal_CreateDelegate>("UnityEngine.MyIntPtrObject::Internal_Create");

	private static readonly Internal_DestroyDelegate Internal_DestroyDelegateField = IL2CPP.ResolveICall<Internal_DestroyDelegate>("UnityEngine.MyIntPtrObject::Internal_Destroy");

	private static readonly Create_InjectedDelegate Create_InjectedDelegateField = IL2CPP.ResolveICall<Create_InjectedDelegate>("UnityEngine.MyIntPtrObject::Create_Injected");

	private static readonly MemberFunction_InjectedDelegate MemberFunction_InjectedDelegateField = IL2CPP.ResolveICall<MemberFunction_InjectedDelegate>("UnityEngine.MyIntPtrObject::MemberFunction_Injected");

	private static readonly get_MemberProperty_InjectedDelegate get_MemberProperty_InjectedDelegateField = IL2CPP.ResolveICall<get_MemberProperty_InjectedDelegate>("UnityEngine.MyIntPtrObject::get_MemberProperty_Injected");

	private static readonly set_MemberProperty_InjectedDelegate set_MemberProperty_InjectedDelegateField = IL2CPP.ResolveICall<set_MemberProperty_InjectedDelegate>("UnityEngine.MyIntPtrObject::set_MemberProperty_Injected");

	public int MemberProperty
	{
		get
		{
			System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object)(object)this);
			}
			return get_MemberProperty_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object)(object)this);
			}
			set_MemberProperty_Injected(intPtr, value);
		}
	}

	public void Dispose()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		throw new NotSupportedException("Method unstripping failed");
	}

	public static MyIntPtrObject Create()
	{
		System.IntPtr intPtr = Create_Injected();
		return (intPtr == (System.IntPtr)0) ? null : BindingsMarshaller.ConvertToManaged(intPtr);
	}

	public int MemberFunction(int a)
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object)(object)this);
		}
		return MemberFunction_Injected(intPtr, a);
	}

	public static System.IntPtr Internal_Create()
	{
		return Internal_CreateDelegateField();
	}

	public static void Internal_Destroy(System.IntPtr ptr)
	{
		Internal_DestroyDelegateField(ptr);
	}

	public static System.IntPtr Create_Injected()
	{
		return Create_InjectedDelegateField();
	}

	public static int MemberFunction_Injected(System.IntPtr _unity_self, int a)
	{
		return MemberFunction_InjectedDelegateField(_unity_self, a);
	}

	public static int get_MemberProperty_Injected(System.IntPtr _unity_self)
	{
		return get_MemberProperty_InjectedDelegateField(_unity_self);
	}

	public static void set_MemberProperty_Injected(System.IntPtr _unity_self, int value)
	{
		set_MemberProperty_InjectedDelegateField(_unity_self, value);
	}
}
