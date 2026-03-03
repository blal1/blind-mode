using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using UnityEngine.Bindings;

namespace UnityEngine;

public class MarshallingTestObject : Object
{
	private delegate void Internal_CreateMarshallingTestObjectDelegate(System.IntPtr notSelf);

	private delegate int MemberFunction_InjectedDelegate(System.IntPtr _unity_self, int a);

	private delegate int get_MemberProperty_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_MemberProperty_InjectedDelegate(System.IntPtr _unity_self, int value);

	private delegate int get_FieldBoundMemberProperty_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_FieldBoundMemberProperty_InjectedDelegate(System.IntPtr _unity_self, int value);

	private delegate System.IntPtr Create_InjectedDelegate();

	private static readonly Internal_CreateMarshallingTestObjectDelegate Internal_CreateMarshallingTestObjectDelegateField = IL2CPP.ResolveICall<Internal_CreateMarshallingTestObjectDelegate>("UnityEngine.MarshallingTestObject::Internal_CreateMarshallingTestObject");

	private static readonly MemberFunction_InjectedDelegate MemberFunction_InjectedDelegateField = IL2CPP.ResolveICall<MemberFunction_InjectedDelegate>("UnityEngine.MarshallingTestObject::MemberFunction_Injected");

	private static readonly get_MemberProperty_InjectedDelegate get_MemberProperty_InjectedDelegateField = IL2CPP.ResolveICall<get_MemberProperty_InjectedDelegate>("UnityEngine.MarshallingTestObject::get_MemberProperty_Injected");

	private static readonly set_MemberProperty_InjectedDelegate set_MemberProperty_InjectedDelegateField = IL2CPP.ResolveICall<set_MemberProperty_InjectedDelegate>("UnityEngine.MarshallingTestObject::set_MemberProperty_Injected");

	private static readonly get_FieldBoundMemberProperty_InjectedDelegate get_FieldBoundMemberProperty_InjectedDelegateField = IL2CPP.ResolveICall<get_FieldBoundMemberProperty_InjectedDelegate>("UnityEngine.MarshallingTestObject::get_FieldBoundMemberProperty_Injected");

	private static readonly set_FieldBoundMemberProperty_InjectedDelegate set_FieldBoundMemberProperty_InjectedDelegateField = IL2CPP.ResolveICall<set_FieldBoundMemberProperty_InjectedDelegate>("UnityEngine.MarshallingTestObject::set_FieldBoundMemberProperty_Injected");

	private static readonly Create_InjectedDelegate Create_InjectedDelegateField = IL2CPP.ResolveICall<Create_InjectedDelegate>("UnityEngine.MarshallingTestObject::Create_Injected");

	public int MemberProperty
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_MemberProperty_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_MemberProperty_Injected(intPtr, value);
		}
	}

	public int FieldBoundMemberProperty
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_FieldBoundMemberProperty_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_FieldBoundMemberProperty_Injected(intPtr, value);
		}
	}

	public int MemberFunction(int a)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			ThrowHelper.ThrowNullReferenceException(this);
		}
		return MemberFunction_Injected(intPtr, a);
	}

	public static MarshallingTestObject Create()
	{
		return Unmarshal.UnmarshalUnityObject<MarshallingTestObject>(Create_Injected());
	}

	public static void Internal_CreateMarshallingTestObject(MarshallingTestObject notSelf)
	{
		Internal_CreateMarshallingTestObjectDelegateField(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)notSelf));
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

	public static int get_FieldBoundMemberProperty_Injected(System.IntPtr _unity_self)
	{
		return get_FieldBoundMemberProperty_InjectedDelegateField(_unity_self);
	}

	public static void set_FieldBoundMemberProperty_Injected(System.IntPtr _unity_self, int value)
	{
		set_FieldBoundMemberProperty_InjectedDelegateField(_unity_self, value);
	}

	public static System.IntPtr Create_Injected()
	{
		return Create_InjectedDelegateField();
	}
}
