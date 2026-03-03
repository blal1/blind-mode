using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using UnityEngine.Bindings;

namespace UnityEngine;

public sealed class HingeJoint2D : AnchoredJoint2D
{
	private delegate bool get_useMotor_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_useMotor_InjectedDelegate(IntPtr _unity_self, bool value);

	private delegate bool get_useLimits_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_useLimits_InjectedDelegate(IntPtr _unity_self, bool value);

	private delegate bool get_useConnectedAnchor_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_useConnectedAnchor_InjectedDelegate(IntPtr _unity_self, bool value);

	private delegate JointLimitState2D get_limitState_InjectedDelegate(IntPtr _unity_self);

	private delegate float get_referenceAngle_InjectedDelegate(IntPtr _unity_self);

	private delegate float get_jointAngle_InjectedDelegate(IntPtr _unity_self);

	private delegate float get_jointSpeed_InjectedDelegate(IntPtr _unity_self);

	private delegate float GetMotorTorque_InjectedDelegate(IntPtr _unity_self, float timeStep);

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly get_useMotor_InjectedDelegate get_useMotor_InjectedDelegateField;

	private static readonly set_useMotor_InjectedDelegate set_useMotor_InjectedDelegateField;

	private static readonly get_useLimits_InjectedDelegate get_useLimits_InjectedDelegateField;

	private static readonly set_useLimits_InjectedDelegate set_useLimits_InjectedDelegateField;

	private static readonly get_useConnectedAnchor_InjectedDelegate get_useConnectedAnchor_InjectedDelegateField;

	private static readonly set_useConnectedAnchor_InjectedDelegate set_useConnectedAnchor_InjectedDelegateField;

	private static readonly get_limitState_InjectedDelegate get_limitState_InjectedDelegateField;

	private static readonly get_referenceAngle_InjectedDelegate get_referenceAngle_InjectedDelegateField;

	private static readonly get_jointAngle_InjectedDelegate get_jointAngle_InjectedDelegateField;

	private static readonly get_jointSpeed_InjectedDelegate get_jointSpeed_InjectedDelegateField;

	private static readonly GetMotorTorque_InjectedDelegate GetMotorTorque_InjectedDelegateField;

	public bool useMotor
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_useMotor_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_useMotor_Injected(intPtr, value);
		}
	}

	public bool useLimits
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_useLimits_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_useLimits_Injected(intPtr, value);
		}
	}

	public bool useConnectedAnchor
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_useConnectedAnchor_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_useConnectedAnchor_Injected(intPtr, value);
		}
	}

	public JointLimitState2D limitState
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_limitState_Injected(intPtr);
		}
	}

	public float referenceAngle
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_referenceAngle_Injected(intPtr);
		}
	}

	public float jointAngle
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_jointAngle_Injected(intPtr);
		}
	}

	public float jointSpeed
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_jointSpeed_Injected(intPtr);
		}
	}

	static HingeJoint2D()
	{
		Il2CppClassPointerStore<HingeJoint2D>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Physics2DModule.dll", "UnityEngine", "HingeJoint2D");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HingeJoint2D>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HingeJoint2D>.NativeClassPtr, 100663392);
		get_useMotor_InjectedDelegateField = IL2CPP.ResolveICall<get_useMotor_InjectedDelegate>("UnityEngine.HingeJoint2D::get_useMotor_Injected");
		set_useMotor_InjectedDelegateField = IL2CPP.ResolveICall<set_useMotor_InjectedDelegate>("UnityEngine.HingeJoint2D::set_useMotor_Injected");
		get_useLimits_InjectedDelegateField = IL2CPP.ResolveICall<get_useLimits_InjectedDelegate>("UnityEngine.HingeJoint2D::get_useLimits_Injected");
		set_useLimits_InjectedDelegateField = IL2CPP.ResolveICall<set_useLimits_InjectedDelegate>("UnityEngine.HingeJoint2D::set_useLimits_Injected");
		get_useConnectedAnchor_InjectedDelegateField = IL2CPP.ResolveICall<get_useConnectedAnchor_InjectedDelegate>("UnityEngine.HingeJoint2D::get_useConnectedAnchor_Injected");
		set_useConnectedAnchor_InjectedDelegateField = IL2CPP.ResolveICall<set_useConnectedAnchor_InjectedDelegate>("UnityEngine.HingeJoint2D::set_useConnectedAnchor_Injected");
		get_limitState_InjectedDelegateField = IL2CPP.ResolveICall<get_limitState_InjectedDelegate>("UnityEngine.HingeJoint2D::get_limitState_Injected");
		get_referenceAngle_InjectedDelegateField = IL2CPP.ResolveICall<get_referenceAngle_InjectedDelegate>("UnityEngine.HingeJoint2D::get_referenceAngle_Injected");
		get_jointAngle_InjectedDelegateField = IL2CPP.ResolveICall<get_jointAngle_InjectedDelegate>("UnityEngine.HingeJoint2D::get_jointAngle_Injected");
		get_jointSpeed_InjectedDelegateField = IL2CPP.ResolveICall<get_jointSpeed_InjectedDelegate>("UnityEngine.HingeJoint2D::get_jointSpeed_Injected");
		GetMotorTorque_InjectedDelegateField = IL2CPP.ResolveICall<GetMotorTorque_InjectedDelegate>("UnityEngine.HingeJoint2D::GetMotorTorque_Injected");
	}

	[CallerCount(646)]
	[CachedScanResults(RefRangeStart = 1152221, RefRangeEnd = 1152867, XrefRangeStart = 1152221, XrefRangeEnd = 1152867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe HingeJoint2D()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HingeJoint2D>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public HingeJoint2D(IntPtr pointer)
		: base(pointer)
	{
	}

	public float GetMotorTorque(float timeStep)
	{
		IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (IntPtr)0)
		{
			ThrowHelper.ThrowNullReferenceException(this);
		}
		return GetMotorTorque_Injected(intPtr, timeStep);
	}

	public static bool get_useMotor_Injected(IntPtr _unity_self)
	{
		return get_useMotor_InjectedDelegateField(_unity_self);
	}

	public static void set_useMotor_Injected(IntPtr _unity_self, bool value)
	{
		set_useMotor_InjectedDelegateField(_unity_self, value);
	}

	public static bool get_useLimits_Injected(IntPtr _unity_self)
	{
		return get_useLimits_InjectedDelegateField(_unity_self);
	}

	public static void set_useLimits_Injected(IntPtr _unity_self, bool value)
	{
		set_useLimits_InjectedDelegateField(_unity_self, value);
	}

	public static bool get_useConnectedAnchor_Injected(IntPtr _unity_self)
	{
		return get_useConnectedAnchor_InjectedDelegateField(_unity_self);
	}

	public static void set_useConnectedAnchor_Injected(IntPtr _unity_self, bool value)
	{
		set_useConnectedAnchor_InjectedDelegateField(_unity_self, value);
	}

	public static JointLimitState2D get_limitState_Injected(IntPtr _unity_self)
	{
		return get_limitState_InjectedDelegateField(_unity_self);
	}

	public static float get_referenceAngle_Injected(IntPtr _unity_self)
	{
		return get_referenceAngle_InjectedDelegateField(_unity_self);
	}

	public static float get_jointAngle_Injected(IntPtr _unity_self)
	{
		return get_jointAngle_InjectedDelegateField(_unity_self);
	}

	public static float get_jointSpeed_Injected(IntPtr _unity_self)
	{
		return get_jointSpeed_InjectedDelegateField(_unity_self);
	}

	public static float GetMotorTorque_Injected(IntPtr _unity_self, float timeStep)
	{
		return GetMotorTorque_InjectedDelegateField(_unity_self, timeStep);
	}
}
