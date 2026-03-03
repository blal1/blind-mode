using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using UnityEngine.Bindings;

namespace UnityEngine;

public class CharacterController : Collider
{
	private delegate bool SimpleMove_InjectedDelegate(IntPtr _unity_self, [In] IntPtr speed);

	private delegate CollisionFlags Move_InjectedDelegate(IntPtr _unity_self, [In] IntPtr motion);

	private delegate void get_velocity_InjectedDelegate(IntPtr _unity_self, [Out] IntPtr ret);

	private delegate bool get_isGrounded_InjectedDelegate(IntPtr _unity_self);

	private delegate CollisionFlags get_collisionFlags_InjectedDelegate(IntPtr _unity_self);

	private delegate float get_radius_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_radius_InjectedDelegate(IntPtr _unity_self, float value);

	private delegate float get_height_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_height_InjectedDelegate(IntPtr _unity_self, float value);

	private delegate void get_center_InjectedDelegate(IntPtr _unity_self, [Out] IntPtr ret);

	private delegate void set_center_InjectedDelegate(IntPtr _unity_self, [In] IntPtr value);

	private delegate float get_slopeLimit_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_slopeLimit_InjectedDelegate(IntPtr _unity_self, float value);

	private delegate float get_stepOffset_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_stepOffset_InjectedDelegate(IntPtr _unity_self, float value);

	private delegate float get_skinWidth_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_skinWidth_InjectedDelegate(IntPtr _unity_self, float value);

	private delegate float get_minMoveDistance_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_minMoveDistance_InjectedDelegate(IntPtr _unity_self, float value);

	private delegate bool get_detectCollisions_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_detectCollisions_InjectedDelegate(IntPtr _unity_self, bool value);

	private delegate bool get_enableOverlapRecovery_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_enableOverlapRecovery_InjectedDelegate(IntPtr _unity_self, bool value);

	private delegate bool get_isSupported_InjectedDelegate(IntPtr _unity_self);

	private static readonly SimpleMove_InjectedDelegate SimpleMove_InjectedDelegateField;

	private static readonly Move_InjectedDelegate Move_InjectedDelegateField;

	private static readonly get_velocity_InjectedDelegate get_velocity_InjectedDelegateField;

	private static readonly get_isGrounded_InjectedDelegate get_isGrounded_InjectedDelegateField;

	private static readonly get_collisionFlags_InjectedDelegate get_collisionFlags_InjectedDelegateField;

	private static readonly get_radius_InjectedDelegate get_radius_InjectedDelegateField;

	private static readonly set_radius_InjectedDelegate set_radius_InjectedDelegateField;

	private static readonly get_height_InjectedDelegate get_height_InjectedDelegateField;

	private static readonly set_height_InjectedDelegate set_height_InjectedDelegateField;

	private static readonly get_center_InjectedDelegate get_center_InjectedDelegateField;

	private static readonly set_center_InjectedDelegate set_center_InjectedDelegateField;

	private static readonly get_slopeLimit_InjectedDelegate get_slopeLimit_InjectedDelegateField;

	private static readonly set_slopeLimit_InjectedDelegate set_slopeLimit_InjectedDelegateField;

	private static readonly get_stepOffset_InjectedDelegate get_stepOffset_InjectedDelegateField;

	private static readonly set_stepOffset_InjectedDelegate set_stepOffset_InjectedDelegateField;

	private static readonly get_skinWidth_InjectedDelegate get_skinWidth_InjectedDelegateField;

	private static readonly set_skinWidth_InjectedDelegate set_skinWidth_InjectedDelegateField;

	private static readonly get_minMoveDistance_InjectedDelegate get_minMoveDistance_InjectedDelegateField;

	private static readonly set_minMoveDistance_InjectedDelegate set_minMoveDistance_InjectedDelegateField;

	private static readonly get_detectCollisions_InjectedDelegate get_detectCollisions_InjectedDelegateField;

	private static readonly set_detectCollisions_InjectedDelegate set_detectCollisions_InjectedDelegateField;

	private static readonly get_enableOverlapRecovery_InjectedDelegate get_enableOverlapRecovery_InjectedDelegateField;

	private static readonly set_enableOverlapRecovery_InjectedDelegate set_enableOverlapRecovery_InjectedDelegateField;

	private static readonly get_isSupported_InjectedDelegate get_isSupported_InjectedDelegateField;

	public Vector3 velocity
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			get_velocity_Injected(intPtr, out var ret);
			return ret;
		}
	}

	public bool isGrounded
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_isGrounded_Injected(intPtr);
		}
	}

	public CollisionFlags collisionFlags
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_collisionFlags_Injected(intPtr);
		}
	}

	public float radius
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_radius_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_radius_Injected(intPtr, value);
		}
	}

	public float height
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_height_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_height_Injected(intPtr, value);
		}
	}

	public Vector3 center
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			get_center_Injected(intPtr, out var ret);
			return ret;
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_center_Injected(intPtr, ref value);
		}
	}

	public float slopeLimit
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_slopeLimit_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_slopeLimit_Injected(intPtr, value);
		}
	}

	public float stepOffset
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_stepOffset_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_stepOffset_Injected(intPtr, value);
		}
	}

	public float skinWidth
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_skinWidth_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_skinWidth_Injected(intPtr, value);
		}
	}

	public float minMoveDistance
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_minMoveDistance_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_minMoveDistance_Injected(intPtr, value);
		}
	}

	public bool detectCollisions
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_detectCollisions_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_detectCollisions_Injected(intPtr, value);
		}
	}

	public bool enableOverlapRecovery
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_enableOverlapRecovery_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_enableOverlapRecovery_Injected(intPtr, value);
		}
	}

	public bool isSupported
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_isSupported_Injected(intPtr);
		}
	}

	static CharacterController()
	{
		Il2CppClassPointerStore<CharacterController>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.PhysicsModule.dll", "UnityEngine", "CharacterController");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterController>.NativeClassPtr);
		SimpleMove_InjectedDelegateField = IL2CPP.ResolveICall<SimpleMove_InjectedDelegate>("UnityEngine.CharacterController::SimpleMove_Injected");
		Move_InjectedDelegateField = IL2CPP.ResolveICall<Move_InjectedDelegate>("UnityEngine.CharacterController::Move_Injected");
		get_velocity_InjectedDelegateField = IL2CPP.ResolveICall<get_velocity_InjectedDelegate>("UnityEngine.CharacterController::get_velocity_Injected");
		get_isGrounded_InjectedDelegateField = IL2CPP.ResolveICall<get_isGrounded_InjectedDelegate>("UnityEngine.CharacterController::get_isGrounded_Injected");
		get_collisionFlags_InjectedDelegateField = IL2CPP.ResolveICall<get_collisionFlags_InjectedDelegate>("UnityEngine.CharacterController::get_collisionFlags_Injected");
		get_radius_InjectedDelegateField = IL2CPP.ResolveICall<get_radius_InjectedDelegate>("UnityEngine.CharacterController::get_radius_Injected");
		set_radius_InjectedDelegateField = IL2CPP.ResolveICall<set_radius_InjectedDelegate>("UnityEngine.CharacterController::set_radius_Injected");
		get_height_InjectedDelegateField = IL2CPP.ResolveICall<get_height_InjectedDelegate>("UnityEngine.CharacterController::get_height_Injected");
		set_height_InjectedDelegateField = IL2CPP.ResolveICall<set_height_InjectedDelegate>("UnityEngine.CharacterController::set_height_Injected");
		get_center_InjectedDelegateField = IL2CPP.ResolveICall<get_center_InjectedDelegate>("UnityEngine.CharacterController::get_center_Injected");
		set_center_InjectedDelegateField = IL2CPP.ResolveICall<set_center_InjectedDelegate>("UnityEngine.CharacterController::set_center_Injected");
		get_slopeLimit_InjectedDelegateField = IL2CPP.ResolveICall<get_slopeLimit_InjectedDelegate>("UnityEngine.CharacterController::get_slopeLimit_Injected");
		set_slopeLimit_InjectedDelegateField = IL2CPP.ResolveICall<set_slopeLimit_InjectedDelegate>("UnityEngine.CharacterController::set_slopeLimit_Injected");
		get_stepOffset_InjectedDelegateField = IL2CPP.ResolveICall<get_stepOffset_InjectedDelegate>("UnityEngine.CharacterController::get_stepOffset_Injected");
		set_stepOffset_InjectedDelegateField = IL2CPP.ResolveICall<set_stepOffset_InjectedDelegate>("UnityEngine.CharacterController::set_stepOffset_Injected");
		get_skinWidth_InjectedDelegateField = IL2CPP.ResolveICall<get_skinWidth_InjectedDelegate>("UnityEngine.CharacterController::get_skinWidth_Injected");
		set_skinWidth_InjectedDelegateField = IL2CPP.ResolveICall<set_skinWidth_InjectedDelegate>("UnityEngine.CharacterController::set_skinWidth_Injected");
		get_minMoveDistance_InjectedDelegateField = IL2CPP.ResolveICall<get_minMoveDistance_InjectedDelegate>("UnityEngine.CharacterController::get_minMoveDistance_Injected");
		set_minMoveDistance_InjectedDelegateField = IL2CPP.ResolveICall<set_minMoveDistance_InjectedDelegate>("UnityEngine.CharacterController::set_minMoveDistance_Injected");
		get_detectCollisions_InjectedDelegateField = IL2CPP.ResolveICall<get_detectCollisions_InjectedDelegate>("UnityEngine.CharacterController::get_detectCollisions_Injected");
		set_detectCollisions_InjectedDelegateField = IL2CPP.ResolveICall<set_detectCollisions_InjectedDelegate>("UnityEngine.CharacterController::set_detectCollisions_Injected");
		get_enableOverlapRecovery_InjectedDelegateField = IL2CPP.ResolveICall<get_enableOverlapRecovery_InjectedDelegate>("UnityEngine.CharacterController::get_enableOverlapRecovery_Injected");
		set_enableOverlapRecovery_InjectedDelegateField = IL2CPP.ResolveICall<set_enableOverlapRecovery_InjectedDelegate>("UnityEngine.CharacterController::set_enableOverlapRecovery_Injected");
		get_isSupported_InjectedDelegateField = IL2CPP.ResolveICall<get_isSupported_InjectedDelegate>("UnityEngine.CharacterController::get_isSupported_Injected");
	}

	public CharacterController(IntPtr pointer)
		: base(pointer)
	{
	}

	public bool SimpleMove(Vector3 speed)
	{
		IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (IntPtr)0)
		{
			ThrowHelper.ThrowNullReferenceException(this);
		}
		return SimpleMove_Injected(intPtr, ref speed);
	}

	public CollisionFlags Move(Vector3 motion)
	{
		IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (IntPtr)0)
		{
			ThrowHelper.ThrowNullReferenceException(this);
		}
		return Move_Injected(intPtr, ref motion);
	}

	public unsafe static bool SimpleMove_Injected(IntPtr _unity_self, [In] ref Vector3 speed)
	{
		return SimpleMove_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref speed));
	}

	public unsafe static CollisionFlags Move_Injected(IntPtr _unity_self, [In] ref Vector3 motion)
	{
		return Move_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref motion));
	}

	public unsafe static void get_velocity_Injected(IntPtr _unity_self, out Vector3 ret)
	{
		get_velocity_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public static bool get_isGrounded_Injected(IntPtr _unity_self)
	{
		return get_isGrounded_InjectedDelegateField(_unity_self);
	}

	public static CollisionFlags get_collisionFlags_Injected(IntPtr _unity_self)
	{
		return get_collisionFlags_InjectedDelegateField(_unity_self);
	}

	public static float get_radius_Injected(IntPtr _unity_self)
	{
		return get_radius_InjectedDelegateField(_unity_self);
	}

	public static void set_radius_Injected(IntPtr _unity_self, float value)
	{
		set_radius_InjectedDelegateField(_unity_self, value);
	}

	public static float get_height_Injected(IntPtr _unity_self)
	{
		return get_height_InjectedDelegateField(_unity_self);
	}

	public static void set_height_Injected(IntPtr _unity_self, float value)
	{
		set_height_InjectedDelegateField(_unity_self, value);
	}

	public unsafe static void get_center_Injected(IntPtr _unity_self, out Vector3 ret)
	{
		get_center_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void set_center_Injected(IntPtr _unity_self, [In] ref Vector3 value)
	{
		set_center_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref value));
	}

	public static float get_slopeLimit_Injected(IntPtr _unity_self)
	{
		return get_slopeLimit_InjectedDelegateField(_unity_self);
	}

	public static void set_slopeLimit_Injected(IntPtr _unity_self, float value)
	{
		set_slopeLimit_InjectedDelegateField(_unity_self, value);
	}

	public static float get_stepOffset_Injected(IntPtr _unity_self)
	{
		return get_stepOffset_InjectedDelegateField(_unity_self);
	}

	public static void set_stepOffset_Injected(IntPtr _unity_self, float value)
	{
		set_stepOffset_InjectedDelegateField(_unity_self, value);
	}

	public static float get_skinWidth_Injected(IntPtr _unity_self)
	{
		return get_skinWidth_InjectedDelegateField(_unity_self);
	}

	public static void set_skinWidth_Injected(IntPtr _unity_self, float value)
	{
		set_skinWidth_InjectedDelegateField(_unity_self, value);
	}

	public static float get_minMoveDistance_Injected(IntPtr _unity_self)
	{
		return get_minMoveDistance_InjectedDelegateField(_unity_self);
	}

	public static void set_minMoveDistance_Injected(IntPtr _unity_self, float value)
	{
		set_minMoveDistance_InjectedDelegateField(_unity_self, value);
	}

	public static bool get_detectCollisions_Injected(IntPtr _unity_self)
	{
		return get_detectCollisions_InjectedDelegateField(_unity_self);
	}

	public static void set_detectCollisions_Injected(IntPtr _unity_self, bool value)
	{
		set_detectCollisions_InjectedDelegateField(_unity_self, value);
	}

	public static bool get_enableOverlapRecovery_Injected(IntPtr _unity_self)
	{
		return get_enableOverlapRecovery_InjectedDelegateField(_unity_self);
	}

	public static void set_enableOverlapRecovery_Injected(IntPtr _unity_self, bool value)
	{
		set_enableOverlapRecovery_InjectedDelegateField(_unity_self, value);
	}

	public static bool get_isSupported_Injected(IntPtr _unity_self)
	{
		return get_isSupported_InjectedDelegateField(_unity_self);
	}
}
