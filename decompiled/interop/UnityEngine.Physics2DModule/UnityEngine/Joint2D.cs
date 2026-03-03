using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.Bindings;

namespace UnityEngine;

public class Joint2D : Behaviour
{
	private delegate IntPtr get_attachedRigidbody_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_connectedBody_InjectedDelegate(IntPtr _unity_self, IntPtr value);

	private delegate bool get_enableCollision_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_enableCollision_InjectedDelegate(IntPtr _unity_self, bool value);

	private delegate float get_breakForce_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_breakForce_InjectedDelegate(IntPtr _unity_self, float value);

	private delegate float get_breakTorque_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_breakTorque_InjectedDelegate(IntPtr _unity_self, float value);

	private delegate JointBreakAction2D get_breakAction_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_breakAction_InjectedDelegate(IntPtr _unity_self, JointBreakAction2D value);

	private delegate void get_reactionForce_InjectedDelegate(IntPtr _unity_self, [Out] IntPtr ret);

	private delegate float get_reactionTorque_InjectedDelegate(IntPtr _unity_self);

	private delegate void GetReactionForce_InjectedDelegate(IntPtr _unity_self, float timeStep, [Out] IntPtr ret);

	private delegate float GetReactionTorque_InjectedDelegate(IntPtr _unity_self, float timeStep);

	private static readonly IntPtr NativeMethodInfoPtr_get_connectedBody_Public_get_Rigidbody2D_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_connectedBody_Injected_Private_Static_IntPtr_IntPtr_0;

	private static readonly get_attachedRigidbody_InjectedDelegate get_attachedRigidbody_InjectedDelegateField;

	private static readonly set_connectedBody_InjectedDelegate set_connectedBody_InjectedDelegateField;

	private static readonly get_enableCollision_InjectedDelegate get_enableCollision_InjectedDelegateField;

	private static readonly set_enableCollision_InjectedDelegate set_enableCollision_InjectedDelegateField;

	private static readonly get_breakForce_InjectedDelegate get_breakForce_InjectedDelegateField;

	private static readonly set_breakForce_InjectedDelegate set_breakForce_InjectedDelegateField;

	private static readonly get_breakTorque_InjectedDelegate get_breakTorque_InjectedDelegateField;

	private static readonly set_breakTorque_InjectedDelegate set_breakTorque_InjectedDelegateField;

	private static readonly get_breakAction_InjectedDelegate get_breakAction_InjectedDelegateField;

	private static readonly set_breakAction_InjectedDelegate set_breakAction_InjectedDelegateField;

	private static readonly get_reactionForce_InjectedDelegate get_reactionForce_InjectedDelegateField;

	private static readonly get_reactionTorque_InjectedDelegate get_reactionTorque_InjectedDelegateField;

	private static readonly GetReactionForce_InjectedDelegate GetReactionForce_InjectedDelegateField;

	private static readonly GetReactionTorque_InjectedDelegate GetReactionTorque_InjectedDelegateField;

	public unsafe Rigidbody2D connectedBody
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1259131, RefRangeEnd = 1259132, XrefRangeStart = 1259118, XrefRangeEnd = 1259131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_connectedBody_Public_get_Rigidbody2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<Rigidbody2D>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_connectedBody_Injected(intPtr, MarshalledUnityObject.Marshal(value));
		}
	}

	public Rigidbody2D attachedRigidbody
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return Unmarshal.UnmarshalUnityObject<Rigidbody2D>(get_attachedRigidbody_Injected(intPtr));
		}
	}

	public bool enableCollision
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_enableCollision_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_enableCollision_Injected(intPtr, value);
		}
	}

	public float breakForce
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_breakForce_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_breakForce_Injected(intPtr, value);
		}
	}

	public float breakTorque
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_breakTorque_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_breakTorque_Injected(intPtr, value);
		}
	}

	public JointBreakAction2D breakAction
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_breakAction_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_breakAction_Injected(intPtr, value);
		}
	}

	public Vector2 reactionForce
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			get_reactionForce_Injected(intPtr, out var ret);
			return ret;
		}
	}

	public float reactionTorque
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_reactionTorque_Injected(intPtr);
		}
	}

	public bool collideConnected
	{
		get
		{
			return enableCollision;
		}
		set
		{
			enableCollision = value;
		}
	}

	static Joint2D()
	{
		Il2CppClassPointerStore<Joint2D>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Physics2DModule.dll", "UnityEngine", "Joint2D");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Joint2D>.NativeClassPtr);
		NativeMethodInfoPtr_get_connectedBody_Public_get_Rigidbody2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Joint2D>.NativeClassPtr, 100663386);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Joint2D>.NativeClassPtr, 100663387);
		NativeMethodInfoPtr_get_connectedBody_Injected_Private_Static_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Joint2D>.NativeClassPtr, 100663388);
		get_attachedRigidbody_InjectedDelegateField = IL2CPP.ResolveICall<get_attachedRigidbody_InjectedDelegate>("UnityEngine.Joint2D::get_attachedRigidbody_Injected");
		set_connectedBody_InjectedDelegateField = IL2CPP.ResolveICall<set_connectedBody_InjectedDelegate>("UnityEngine.Joint2D::set_connectedBody_Injected");
		get_enableCollision_InjectedDelegateField = IL2CPP.ResolveICall<get_enableCollision_InjectedDelegate>("UnityEngine.Joint2D::get_enableCollision_Injected");
		set_enableCollision_InjectedDelegateField = IL2CPP.ResolveICall<set_enableCollision_InjectedDelegate>("UnityEngine.Joint2D::set_enableCollision_Injected");
		get_breakForce_InjectedDelegateField = IL2CPP.ResolveICall<get_breakForce_InjectedDelegate>("UnityEngine.Joint2D::get_breakForce_Injected");
		set_breakForce_InjectedDelegateField = IL2CPP.ResolveICall<set_breakForce_InjectedDelegate>("UnityEngine.Joint2D::set_breakForce_Injected");
		get_breakTorque_InjectedDelegateField = IL2CPP.ResolveICall<get_breakTorque_InjectedDelegate>("UnityEngine.Joint2D::get_breakTorque_Injected");
		set_breakTorque_InjectedDelegateField = IL2CPP.ResolveICall<set_breakTorque_InjectedDelegate>("UnityEngine.Joint2D::set_breakTorque_Injected");
		get_breakAction_InjectedDelegateField = IL2CPP.ResolveICall<get_breakAction_InjectedDelegate>("UnityEngine.Joint2D::get_breakAction_Injected");
		set_breakAction_InjectedDelegateField = IL2CPP.ResolveICall<set_breakAction_InjectedDelegate>("UnityEngine.Joint2D::set_breakAction_Injected");
		get_reactionForce_InjectedDelegateField = IL2CPP.ResolveICall<get_reactionForce_InjectedDelegate>("UnityEngine.Joint2D::get_reactionForce_Injected");
		get_reactionTorque_InjectedDelegateField = IL2CPP.ResolveICall<get_reactionTorque_InjectedDelegate>("UnityEngine.Joint2D::get_reactionTorque_Injected");
		GetReactionForce_InjectedDelegateField = IL2CPP.ResolveICall<GetReactionForce_InjectedDelegate>("UnityEngine.Joint2D::GetReactionForce_Injected");
		GetReactionTorque_InjectedDelegateField = IL2CPP.ResolveICall<GetReactionTorque_InjectedDelegate>("UnityEngine.Joint2D::GetReactionTorque_Injected");
	}

	[CallerCount(646)]
	[CachedScanResults(RefRangeStart = 1152221, RefRangeEnd = 1152867, XrefRangeStart = 1152221, XrefRangeEnd = 1152867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Joint2D()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Joint2D>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259132, XrefRangeEnd = 1259134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static IntPtr get_connectedBody_Injected(IntPtr _unity_self)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_connectedBody_Injected_Private_Static_IntPtr_IntPtr_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public Joint2D(IntPtr pointer)
		: base(pointer)
	{
	}

	public Vector2 GetReactionForce(float timeStep)
	{
		IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (IntPtr)0)
		{
			ThrowHelper.ThrowNullReferenceException(this);
		}
		GetReactionForce_Injected(intPtr, timeStep, out var ret);
		return ret;
	}

	public float GetReactionTorque(float timeStep)
	{
		IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (IntPtr)0)
		{
			ThrowHelper.ThrowNullReferenceException(this);
		}
		return GetReactionTorque_Injected(intPtr, timeStep);
	}

	public static IntPtr get_attachedRigidbody_Injected(IntPtr _unity_self)
	{
		return get_attachedRigidbody_InjectedDelegateField(_unity_self);
	}

	public static void set_connectedBody_Injected(IntPtr _unity_self, IntPtr value)
	{
		set_connectedBody_InjectedDelegateField(_unity_self, value);
	}

	public static bool get_enableCollision_Injected(IntPtr _unity_self)
	{
		return get_enableCollision_InjectedDelegateField(_unity_self);
	}

	public static void set_enableCollision_Injected(IntPtr _unity_self, bool value)
	{
		set_enableCollision_InjectedDelegateField(_unity_self, value);
	}

	public static float get_breakForce_Injected(IntPtr _unity_self)
	{
		return get_breakForce_InjectedDelegateField(_unity_self);
	}

	public static void set_breakForce_Injected(IntPtr _unity_self, float value)
	{
		set_breakForce_InjectedDelegateField(_unity_self, value);
	}

	public static float get_breakTorque_Injected(IntPtr _unity_self)
	{
		return get_breakTorque_InjectedDelegateField(_unity_self);
	}

	public static void set_breakTorque_Injected(IntPtr _unity_self, float value)
	{
		set_breakTorque_InjectedDelegateField(_unity_self, value);
	}

	public static JointBreakAction2D get_breakAction_Injected(IntPtr _unity_self)
	{
		return get_breakAction_InjectedDelegateField(_unity_self);
	}

	public static void set_breakAction_Injected(IntPtr _unity_self, JointBreakAction2D value)
	{
		set_breakAction_InjectedDelegateField(_unity_self, value);
	}

	public unsafe static void get_reactionForce_Injected(IntPtr _unity_self, out Vector2 ret)
	{
		get_reactionForce_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public static float get_reactionTorque_Injected(IntPtr _unity_self)
	{
		return get_reactionTorque_InjectedDelegateField(_unity_self);
	}

	public unsafe static void GetReactionForce_Injected(IntPtr _unity_self, float timeStep, out Vector2 ret)
	{
		GetReactionForce_InjectedDelegateField(_unity_self, timeStep, (nint)Unsafe.AsPointer(ref ret));
	}

	public static float GetReactionTorque_Injected(IntPtr _unity_self, float timeStep)
	{
		return GetReactionTorque_InjectedDelegateField(_unity_self, timeStep);
	}
}
