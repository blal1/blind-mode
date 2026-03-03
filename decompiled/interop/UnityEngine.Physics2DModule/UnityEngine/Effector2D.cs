using System;
using Il2CppInterop.Runtime;
using UnityEngine.Bindings;

namespace UnityEngine;

public class Effector2D : Behaviour
{
	private delegate bool get_useColliderMask_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_useColliderMask_InjectedDelegate(IntPtr _unity_self, bool value);

	private delegate int get_colliderMask_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_colliderMask_InjectedDelegate(IntPtr _unity_self, int value);

	private delegate bool get_requiresCollider_InjectedDelegate(IntPtr _unity_self);

	private delegate bool get_designedForTrigger_InjectedDelegate(IntPtr _unity_self);

	private delegate bool get_designedForNonTrigger_InjectedDelegate(IntPtr _unity_self);

	private static readonly get_useColliderMask_InjectedDelegate get_useColliderMask_InjectedDelegateField = IL2CPP.ResolveICall<get_useColliderMask_InjectedDelegate>("UnityEngine.Effector2D::get_useColliderMask_Injected");

	private static readonly set_useColliderMask_InjectedDelegate set_useColliderMask_InjectedDelegateField = IL2CPP.ResolveICall<set_useColliderMask_InjectedDelegate>("UnityEngine.Effector2D::set_useColliderMask_Injected");

	private static readonly get_colliderMask_InjectedDelegate get_colliderMask_InjectedDelegateField = IL2CPP.ResolveICall<get_colliderMask_InjectedDelegate>("UnityEngine.Effector2D::get_colliderMask_Injected");

	private static readonly set_colliderMask_InjectedDelegate set_colliderMask_InjectedDelegateField = IL2CPP.ResolveICall<set_colliderMask_InjectedDelegate>("UnityEngine.Effector2D::set_colliderMask_Injected");

	private static readonly get_requiresCollider_InjectedDelegate get_requiresCollider_InjectedDelegateField = IL2CPP.ResolveICall<get_requiresCollider_InjectedDelegate>("UnityEngine.Effector2D::get_requiresCollider_Injected");

	private static readonly get_designedForTrigger_InjectedDelegate get_designedForTrigger_InjectedDelegateField = IL2CPP.ResolveICall<get_designedForTrigger_InjectedDelegate>("UnityEngine.Effector2D::get_designedForTrigger_Injected");

	private static readonly get_designedForNonTrigger_InjectedDelegate get_designedForNonTrigger_InjectedDelegateField = IL2CPP.ResolveICall<get_designedForNonTrigger_InjectedDelegate>("UnityEngine.Effector2D::get_designedForNonTrigger_Injected");

	public bool useColliderMask
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_useColliderMask_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_useColliderMask_Injected(intPtr, value);
		}
	}

	public int colliderMask
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_colliderMask_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_colliderMask_Injected(intPtr, value);
		}
	}

	public bool requiresCollider
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_requiresCollider_Injected(intPtr);
		}
	}

	public bool designedForTrigger
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_designedForTrigger_Injected(intPtr);
		}
	}

	public bool designedForNonTrigger
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_designedForNonTrigger_Injected(intPtr);
		}
	}

	public static bool get_useColliderMask_Injected(IntPtr _unity_self)
	{
		return get_useColliderMask_InjectedDelegateField(_unity_self);
	}

	public static void set_useColliderMask_Injected(IntPtr _unity_self, bool value)
	{
		set_useColliderMask_InjectedDelegateField(_unity_self, value);
	}

	public static int get_colliderMask_Injected(IntPtr _unity_self)
	{
		return get_colliderMask_InjectedDelegateField(_unity_self);
	}

	public static void set_colliderMask_Injected(IntPtr _unity_self, int value)
	{
		set_colliderMask_InjectedDelegateField(_unity_self, value);
	}

	public static bool get_requiresCollider_Injected(IntPtr _unity_self)
	{
		return get_requiresCollider_InjectedDelegateField(_unity_self);
	}

	public static bool get_designedForTrigger_Injected(IntPtr _unity_self)
	{
		return get_designedForTrigger_InjectedDelegateField(_unity_self);
	}

	public static bool get_designedForNonTrigger_Injected(IntPtr _unity_self)
	{
		return get_designedForNonTrigger_InjectedDelegateField(_unity_self);
	}
}
