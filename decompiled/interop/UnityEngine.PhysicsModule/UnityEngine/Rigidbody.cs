using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using UnityEngine.Bindings;

namespace UnityEngine;

public class Rigidbody : Component
{
	private delegate void get_linearVelocity_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr ret);

	private delegate void set_linearVelocity_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr value);

	private delegate void get_angularVelocity_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr ret);

	private delegate void set_angularVelocity_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr value);

	private delegate float get_linearDamping_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_linearDamping_InjectedDelegate(System.IntPtr _unity_self, float value);

	private delegate float get_angularDamping_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_angularDamping_InjectedDelegate(System.IntPtr _unity_self, float value);

	private delegate float get_mass_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_mass_InjectedDelegate(System.IntPtr _unity_self, float value);

	private delegate void SetDensity_InjectedDelegate(System.IntPtr _unity_self, float density);

	private delegate bool get_useGravity_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_useGravity_InjectedDelegate(System.IntPtr _unity_self, bool value);

	private delegate float get_maxDepenetrationVelocity_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_maxDepenetrationVelocity_InjectedDelegate(System.IntPtr _unity_self, float value);

	private delegate bool get_isKinematic_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_isKinematic_InjectedDelegate(System.IntPtr _unity_self, bool value);

	private delegate RigidbodyConstraints get_constraints_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_constraints_InjectedDelegate(System.IntPtr _unity_self, RigidbodyConstraints value);

	private delegate CollisionDetectionMode get_collisionDetectionMode_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_collisionDetectionMode_InjectedDelegate(System.IntPtr _unity_self, CollisionDetectionMode value);

	private delegate bool get_automaticCenterOfMass_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_automaticCenterOfMass_InjectedDelegate(System.IntPtr _unity_self, bool value);

	private delegate void get_centerOfMass_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr ret);

	private delegate void set_centerOfMass_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr value);

	private delegate void get_worldCenterOfMass_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr ret);

	private delegate bool get_automaticInertiaTensor_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_automaticInertiaTensor_InjectedDelegate(System.IntPtr _unity_self, bool value);

	private delegate void get_inertiaTensorRotation_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr ret);

	private delegate void set_inertiaTensorRotation_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr value);

	private delegate void get_inertiaTensor_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr ret);

	private delegate void set_inertiaTensor_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr value);

	private delegate void get_worldInertiaTensorMatrix_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr ret);

	private delegate bool get_detectCollisions_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_detectCollisions_InjectedDelegate(System.IntPtr _unity_self, bool value);

	private delegate RigidbodyInterpolation get_interpolation_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_interpolation_InjectedDelegate(System.IntPtr _unity_self, RigidbodyInterpolation value);

	private delegate int get_solverIterations_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_solverIterations_InjectedDelegate(System.IntPtr _unity_self, int value);

	private delegate float get_sleepThreshold_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_sleepThreshold_InjectedDelegate(System.IntPtr _unity_self, float value);

	private delegate float get_maxAngularVelocity_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_maxAngularVelocity_InjectedDelegate(System.IntPtr _unity_self, float value);

	private delegate float get_maxLinearVelocity_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_maxLinearVelocity_InjectedDelegate(System.IntPtr _unity_self, float value);

	private delegate void Move_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr position, [In] System.IntPtr rotation);

	private delegate void Sleep_InjectedDelegate(System.IntPtr _unity_self);

	private delegate bool IsSleeping_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void WakeUp_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void ResetCenterOfMass_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void ResetInertiaTensor_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void GetRelativePointVelocity_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr relativePoint, [Out] System.IntPtr ret);

	private delegate void GetPointVelocity_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr worldPoint, [Out] System.IntPtr ret);

	private delegate int get_solverVelocityIterations_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_solverVelocityIterations_InjectedDelegate(System.IntPtr _unity_self, int value);

	private delegate void PublishTransform_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void get_excludeLayers_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr ret);

	private delegate void set_excludeLayers_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr value);

	private delegate void get_includeLayers_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr ret);

	private delegate void set_includeLayers_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr value);

	private delegate void GetAccumulatedForce_InjectedDelegate(System.IntPtr _unity_self, float step, [Out] System.IntPtr ret);

	private delegate void GetAccumulatedTorque_InjectedDelegate(System.IntPtr _unity_self, float step, [Out] System.IntPtr ret);

	private delegate void AddForce_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr force, ForceMode mode);

	private delegate void AddRelativeForce_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr force, ForceMode mode);

	private delegate void AddTorque_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr torque, ForceMode mode);

	private delegate void AddRelativeTorque_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr torque, ForceMode mode);

	private delegate void AddForceAtPosition_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr force, [In] System.IntPtr position, ForceMode mode);

	private delegate void AddExplosionForce_InjectedDelegate(System.IntPtr _unity_self, float explosionForce, [In] System.IntPtr explosionPosition, float explosionRadius, float upwardsModifier, ForceMode mode);

	private delegate void Internal_ClosestPointOnBounds_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr point, System.IntPtr outPos, System.IntPtr distance);

	private delegate void SweepTest_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr direction, float maxDistance, QueryTriggerInteraction queryTriggerInteraction, System.IntPtr hasHit, [Out] System.IntPtr ret);

	private delegate void Internal_SweepTestAll_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr direction, float maxDistance, QueryTriggerInteraction queryTriggerInteraction, [Out] System.IntPtr ret);

	private static readonly System.IntPtr NativeMethodInfoPtr_get_position_Public_get_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_position_Public_set_Void_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_rotation_Public_get_Quaternion_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_rotation_Public_set_Void_Quaternion_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MovePosition_Public_Void_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MoveRotation_Public_Void_Quaternion_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_position_Injected_Private_Static_Void_IntPtr_byref_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_position_Injected_Private_Static_Void_IntPtr_byref_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_rotation_Injected_Private_Static_Void_IntPtr_byref_Quaternion_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_rotation_Injected_Private_Static_Void_IntPtr_byref_Quaternion_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MovePosition_Injected_Private_Static_Void_IntPtr_byref_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MoveRotation_Injected_Private_Static_Void_IntPtr_byref_Quaternion_0;

	private static readonly get_linearVelocity_InjectedDelegate get_linearVelocity_InjectedDelegateField;

	private static readonly set_linearVelocity_InjectedDelegate set_linearVelocity_InjectedDelegateField;

	private static readonly get_angularVelocity_InjectedDelegate get_angularVelocity_InjectedDelegateField;

	private static readonly set_angularVelocity_InjectedDelegate set_angularVelocity_InjectedDelegateField;

	private static readonly get_linearDamping_InjectedDelegate get_linearDamping_InjectedDelegateField;

	private static readonly set_linearDamping_InjectedDelegate set_linearDamping_InjectedDelegateField;

	private static readonly get_angularDamping_InjectedDelegate get_angularDamping_InjectedDelegateField;

	private static readonly set_angularDamping_InjectedDelegate set_angularDamping_InjectedDelegateField;

	private static readonly get_mass_InjectedDelegate get_mass_InjectedDelegateField;

	private static readonly set_mass_InjectedDelegate set_mass_InjectedDelegateField;

	private static readonly SetDensity_InjectedDelegate SetDensity_InjectedDelegateField;

	private static readonly get_useGravity_InjectedDelegate get_useGravity_InjectedDelegateField;

	private static readonly set_useGravity_InjectedDelegate set_useGravity_InjectedDelegateField;

	private static readonly get_maxDepenetrationVelocity_InjectedDelegate get_maxDepenetrationVelocity_InjectedDelegateField;

	private static readonly set_maxDepenetrationVelocity_InjectedDelegate set_maxDepenetrationVelocity_InjectedDelegateField;

	private static readonly get_isKinematic_InjectedDelegate get_isKinematic_InjectedDelegateField;

	private static readonly set_isKinematic_InjectedDelegate set_isKinematic_InjectedDelegateField;

	private static readonly get_constraints_InjectedDelegate get_constraints_InjectedDelegateField;

	private static readonly set_constraints_InjectedDelegate set_constraints_InjectedDelegateField;

	private static readonly get_collisionDetectionMode_InjectedDelegate get_collisionDetectionMode_InjectedDelegateField;

	private static readonly set_collisionDetectionMode_InjectedDelegate set_collisionDetectionMode_InjectedDelegateField;

	private static readonly get_automaticCenterOfMass_InjectedDelegate get_automaticCenterOfMass_InjectedDelegateField;

	private static readonly set_automaticCenterOfMass_InjectedDelegate set_automaticCenterOfMass_InjectedDelegateField;

	private static readonly get_centerOfMass_InjectedDelegate get_centerOfMass_InjectedDelegateField;

	private static readonly set_centerOfMass_InjectedDelegate set_centerOfMass_InjectedDelegateField;

	private static readonly get_worldCenterOfMass_InjectedDelegate get_worldCenterOfMass_InjectedDelegateField;

	private static readonly get_automaticInertiaTensor_InjectedDelegate get_automaticInertiaTensor_InjectedDelegateField;

	private static readonly set_automaticInertiaTensor_InjectedDelegate set_automaticInertiaTensor_InjectedDelegateField;

	private static readonly get_inertiaTensorRotation_InjectedDelegate get_inertiaTensorRotation_InjectedDelegateField;

	private static readonly set_inertiaTensorRotation_InjectedDelegate set_inertiaTensorRotation_InjectedDelegateField;

	private static readonly get_inertiaTensor_InjectedDelegate get_inertiaTensor_InjectedDelegateField;

	private static readonly set_inertiaTensor_InjectedDelegate set_inertiaTensor_InjectedDelegateField;

	private static readonly get_worldInertiaTensorMatrix_InjectedDelegate get_worldInertiaTensorMatrix_InjectedDelegateField;

	private static readonly get_detectCollisions_InjectedDelegate get_detectCollisions_InjectedDelegateField;

	private static readonly set_detectCollisions_InjectedDelegate set_detectCollisions_InjectedDelegateField;

	private static readonly get_interpolation_InjectedDelegate get_interpolation_InjectedDelegateField;

	private static readonly set_interpolation_InjectedDelegate set_interpolation_InjectedDelegateField;

	private static readonly get_solverIterations_InjectedDelegate get_solverIterations_InjectedDelegateField;

	private static readonly set_solverIterations_InjectedDelegate set_solverIterations_InjectedDelegateField;

	private static readonly get_sleepThreshold_InjectedDelegate get_sleepThreshold_InjectedDelegateField;

	private static readonly set_sleepThreshold_InjectedDelegate set_sleepThreshold_InjectedDelegateField;

	private static readonly get_maxAngularVelocity_InjectedDelegate get_maxAngularVelocity_InjectedDelegateField;

	private static readonly set_maxAngularVelocity_InjectedDelegate set_maxAngularVelocity_InjectedDelegateField;

	private static readonly get_maxLinearVelocity_InjectedDelegate get_maxLinearVelocity_InjectedDelegateField;

	private static readonly set_maxLinearVelocity_InjectedDelegate set_maxLinearVelocity_InjectedDelegateField;

	private static readonly Move_InjectedDelegate Move_InjectedDelegateField;

	private static readonly Sleep_InjectedDelegate Sleep_InjectedDelegateField;

	private static readonly IsSleeping_InjectedDelegate IsSleeping_InjectedDelegateField;

	private static readonly WakeUp_InjectedDelegate WakeUp_InjectedDelegateField;

	private static readonly ResetCenterOfMass_InjectedDelegate ResetCenterOfMass_InjectedDelegateField;

	private static readonly ResetInertiaTensor_InjectedDelegate ResetInertiaTensor_InjectedDelegateField;

	private static readonly GetRelativePointVelocity_InjectedDelegate GetRelativePointVelocity_InjectedDelegateField;

	private static readonly GetPointVelocity_InjectedDelegate GetPointVelocity_InjectedDelegateField;

	private static readonly get_solverVelocityIterations_InjectedDelegate get_solverVelocityIterations_InjectedDelegateField;

	private static readonly set_solverVelocityIterations_InjectedDelegate set_solverVelocityIterations_InjectedDelegateField;

	private static readonly PublishTransform_InjectedDelegate PublishTransform_InjectedDelegateField;

	private static readonly get_excludeLayers_InjectedDelegate get_excludeLayers_InjectedDelegateField;

	private static readonly set_excludeLayers_InjectedDelegate set_excludeLayers_InjectedDelegateField;

	private static readonly get_includeLayers_InjectedDelegate get_includeLayers_InjectedDelegateField;

	private static readonly set_includeLayers_InjectedDelegate set_includeLayers_InjectedDelegateField;

	private static readonly GetAccumulatedForce_InjectedDelegate GetAccumulatedForce_InjectedDelegateField;

	private static readonly GetAccumulatedTorque_InjectedDelegate GetAccumulatedTorque_InjectedDelegateField;

	private static readonly AddForce_InjectedDelegate AddForce_InjectedDelegateField;

	private static readonly AddRelativeForce_InjectedDelegate AddRelativeForce_InjectedDelegateField;

	private static readonly AddTorque_InjectedDelegate AddTorque_InjectedDelegateField;

	private static readonly AddRelativeTorque_InjectedDelegate AddRelativeTorque_InjectedDelegateField;

	private static readonly AddForceAtPosition_InjectedDelegate AddForceAtPosition_InjectedDelegateField;

	private static readonly AddExplosionForce_InjectedDelegate AddExplosionForce_InjectedDelegateField;

	private static readonly Internal_ClosestPointOnBounds_InjectedDelegate Internal_ClosestPointOnBounds_InjectedDelegateField;

	private static readonly SweepTest_InjectedDelegate SweepTest_InjectedDelegateField;

	private static readonly Internal_SweepTestAll_InjectedDelegate Internal_SweepTestAll_InjectedDelegateField;

	public unsafe Vector3 position
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1259824, RefRangeEnd = 1259825, XrefRangeStart = 1259820, XrefRangeEnd = 1259824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_position_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1259829, RefRangeEnd = 1259830, XrefRangeStart = 1259825, XrefRangeEnd = 1259829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_position_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe Quaternion rotation
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1259834, RefRangeEnd = 1259835, XrefRangeStart = 1259830, XrefRangeEnd = 1259834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_rotation_Public_get_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Quaternion*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1259839, RefRangeEnd = 1259840, XrefRangeStart = 1259835, XrefRangeEnd = 1259839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_rotation_Public_set_Void_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public Vector3 linearVelocity
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			get_linearVelocity_Injected(intPtr, out var ret);
			return ret;
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_linearVelocity_Injected(intPtr, ref value);
		}
	}

	public Vector3 angularVelocity
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			get_angularVelocity_Injected(intPtr, out var ret);
			return ret;
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_angularVelocity_Injected(intPtr, ref value);
		}
	}

	public float linearDamping
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_linearDamping_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_linearDamping_Injected(intPtr, value);
		}
	}

	public float angularDamping
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_angularDamping_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_angularDamping_Injected(intPtr, value);
		}
	}

	public float mass
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_mass_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_mass_Injected(intPtr, value);
		}
	}

	public bool useGravity
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_useGravity_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_useGravity_Injected(intPtr, value);
		}
	}

	public float maxDepenetrationVelocity
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_maxDepenetrationVelocity_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_maxDepenetrationVelocity_Injected(intPtr, value);
		}
	}

	public bool isKinematic
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_isKinematic_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_isKinematic_Injected(intPtr, value);
		}
	}

	public bool freezeRotation
	{
		get
		{
			return ((Il2CppSystem.Enum)constraints).HasFlag((Il2CppSystem.Enum)(object)RigidbodyConstraints.FreezeRotation);
		}
		set
		{
			if (value)
			{
				constraints |= RigidbodyConstraints.FreezeRotation;
			}
			else
			{
				constraints &= RigidbodyConstraints.FreezePosition;
			}
		}
	}

	public RigidbodyConstraints constraints
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_constraints_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_constraints_Injected(intPtr, value);
		}
	}

	public CollisionDetectionMode collisionDetectionMode
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_collisionDetectionMode_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_collisionDetectionMode_Injected(intPtr, value);
		}
	}

	public bool automaticCenterOfMass
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_automaticCenterOfMass_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_automaticCenterOfMass_Injected(intPtr, value);
		}
	}

	public Vector3 centerOfMass
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			get_centerOfMass_Injected(intPtr, out var ret);
			return ret;
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_centerOfMass_Injected(intPtr, ref value);
		}
	}

	public Vector3 worldCenterOfMass
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			get_worldCenterOfMass_Injected(intPtr, out var ret);
			return ret;
		}
	}

	public bool automaticInertiaTensor
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_automaticInertiaTensor_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_automaticInertiaTensor_Injected(intPtr, value);
		}
	}

	public Quaternion inertiaTensorRotation
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			get_inertiaTensorRotation_Injected(intPtr, out var ret);
			return ret;
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_inertiaTensorRotation_Injected(intPtr, ref value);
		}
	}

	public Vector3 inertiaTensor
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			get_inertiaTensor_Injected(intPtr, out var ret);
			return ret;
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_inertiaTensor_Injected(intPtr, ref value);
		}
	}

	public Matrix4x4 worldInertiaTensorMatrix
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			get_worldInertiaTensorMatrix_Injected(intPtr, out var ret);
			return ret;
		}
	}

	public bool detectCollisions
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_detectCollisions_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_detectCollisions_Injected(intPtr, value);
		}
	}

	public RigidbodyInterpolation interpolation
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_interpolation_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_interpolation_Injected(intPtr, value);
		}
	}

	public int solverIterations
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_solverIterations_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_solverIterations_Injected(intPtr, value);
		}
	}

	public float sleepThreshold
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_sleepThreshold_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_sleepThreshold_Injected(intPtr, value);
		}
	}

	public float maxAngularVelocity
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_maxAngularVelocity_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_maxAngularVelocity_Injected(intPtr, value);
		}
	}

	public float maxLinearVelocity
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_maxLinearVelocity_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_maxLinearVelocity_Injected(intPtr, value);
		}
	}

	public int solverVelocityIterations
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_solverVelocityIterations_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_solverVelocityIterations_Injected(intPtr, value);
		}
	}

	public LayerMask excludeLayers
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			get_excludeLayers_Injected(intPtr, out var ret);
			return ret;
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_excludeLayers_Injected(intPtr, ref value);
		}
	}

	public LayerMask includeLayers
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			get_includeLayers_Injected(intPtr, out var ret);
			return ret;
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_includeLayers_Injected(intPtr, ref value);
		}
	}

	public float drag
	{
		get
		{
			return linearDamping;
		}
		set
		{
			linearDamping = value;
		}
	}

	public float angularDrag
	{
		get
		{
			return angularDamping;
		}
		set
		{
			angularDamping = value;
		}
	}

	public Vector3 velocity
	{
		get
		{
			return linearVelocity;
		}
		set
		{
			linearVelocity = value;
		}
	}

	public float sleepVelocity
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float sleepAngularVelocity
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public bool useConeFriction
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public int solverIterationCount
	{
		get
		{
			return solverIterations;
		}
		set
		{
			solverIterations = value;
		}
	}

	public int solverVelocityIterationCount
	{
		get
		{
			return solverVelocityIterations;
		}
		set
		{
			solverVelocityIterations = value;
		}
	}

	static Rigidbody()
	{
		Il2CppClassPointerStore<Rigidbody>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.PhysicsModule.dll", "UnityEngine", "Rigidbody");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Rigidbody>.NativeClassPtr);
		NativeMethodInfoPtr_get_position_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rigidbody>.NativeClassPtr, 100663433);
		NativeMethodInfoPtr_set_position_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rigidbody>.NativeClassPtr, 100663434);
		NativeMethodInfoPtr_get_rotation_Public_get_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rigidbody>.NativeClassPtr, 100663435);
		NativeMethodInfoPtr_set_rotation_Public_set_Void_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rigidbody>.NativeClassPtr, 100663436);
		NativeMethodInfoPtr_MovePosition_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rigidbody>.NativeClassPtr, 100663437);
		NativeMethodInfoPtr_MoveRotation_Public_Void_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rigidbody>.NativeClassPtr, 100663438);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rigidbody>.NativeClassPtr, 100663439);
		NativeMethodInfoPtr_get_position_Injected_Private_Static_Void_IntPtr_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rigidbody>.NativeClassPtr, 100663440);
		NativeMethodInfoPtr_set_position_Injected_Private_Static_Void_IntPtr_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rigidbody>.NativeClassPtr, 100663441);
		NativeMethodInfoPtr_get_rotation_Injected_Private_Static_Void_IntPtr_byref_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rigidbody>.NativeClassPtr, 100663442);
		NativeMethodInfoPtr_set_rotation_Injected_Private_Static_Void_IntPtr_byref_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rigidbody>.NativeClassPtr, 100663443);
		NativeMethodInfoPtr_MovePosition_Injected_Private_Static_Void_IntPtr_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rigidbody>.NativeClassPtr, 100663444);
		NativeMethodInfoPtr_MoveRotation_Injected_Private_Static_Void_IntPtr_byref_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rigidbody>.NativeClassPtr, 100663445);
		get_linearVelocity_InjectedDelegateField = IL2CPP.ResolveICall<get_linearVelocity_InjectedDelegate>("UnityEngine.Rigidbody::get_linearVelocity_Injected");
		set_linearVelocity_InjectedDelegateField = IL2CPP.ResolveICall<set_linearVelocity_InjectedDelegate>("UnityEngine.Rigidbody::set_linearVelocity_Injected");
		get_angularVelocity_InjectedDelegateField = IL2CPP.ResolveICall<get_angularVelocity_InjectedDelegate>("UnityEngine.Rigidbody::get_angularVelocity_Injected");
		set_angularVelocity_InjectedDelegateField = IL2CPP.ResolveICall<set_angularVelocity_InjectedDelegate>("UnityEngine.Rigidbody::set_angularVelocity_Injected");
		get_linearDamping_InjectedDelegateField = IL2CPP.ResolveICall<get_linearDamping_InjectedDelegate>("UnityEngine.Rigidbody::get_linearDamping_Injected");
		set_linearDamping_InjectedDelegateField = IL2CPP.ResolveICall<set_linearDamping_InjectedDelegate>("UnityEngine.Rigidbody::set_linearDamping_Injected");
		get_angularDamping_InjectedDelegateField = IL2CPP.ResolveICall<get_angularDamping_InjectedDelegate>("UnityEngine.Rigidbody::get_angularDamping_Injected");
		set_angularDamping_InjectedDelegateField = IL2CPP.ResolveICall<set_angularDamping_InjectedDelegate>("UnityEngine.Rigidbody::set_angularDamping_Injected");
		get_mass_InjectedDelegateField = IL2CPP.ResolveICall<get_mass_InjectedDelegate>("UnityEngine.Rigidbody::get_mass_Injected");
		set_mass_InjectedDelegateField = IL2CPP.ResolveICall<set_mass_InjectedDelegate>("UnityEngine.Rigidbody::set_mass_Injected");
		SetDensity_InjectedDelegateField = IL2CPP.ResolveICall<SetDensity_InjectedDelegate>("UnityEngine.Rigidbody::SetDensity_Injected");
		get_useGravity_InjectedDelegateField = IL2CPP.ResolveICall<get_useGravity_InjectedDelegate>("UnityEngine.Rigidbody::get_useGravity_Injected");
		set_useGravity_InjectedDelegateField = IL2CPP.ResolveICall<set_useGravity_InjectedDelegate>("UnityEngine.Rigidbody::set_useGravity_Injected");
		get_maxDepenetrationVelocity_InjectedDelegateField = IL2CPP.ResolveICall<get_maxDepenetrationVelocity_InjectedDelegate>("UnityEngine.Rigidbody::get_maxDepenetrationVelocity_Injected");
		set_maxDepenetrationVelocity_InjectedDelegateField = IL2CPP.ResolveICall<set_maxDepenetrationVelocity_InjectedDelegate>("UnityEngine.Rigidbody::set_maxDepenetrationVelocity_Injected");
		get_isKinematic_InjectedDelegateField = IL2CPP.ResolveICall<get_isKinematic_InjectedDelegate>("UnityEngine.Rigidbody::get_isKinematic_Injected");
		set_isKinematic_InjectedDelegateField = IL2CPP.ResolveICall<set_isKinematic_InjectedDelegate>("UnityEngine.Rigidbody::set_isKinematic_Injected");
		get_constraints_InjectedDelegateField = IL2CPP.ResolveICall<get_constraints_InjectedDelegate>("UnityEngine.Rigidbody::get_constraints_Injected");
		set_constraints_InjectedDelegateField = IL2CPP.ResolveICall<set_constraints_InjectedDelegate>("UnityEngine.Rigidbody::set_constraints_Injected");
		get_collisionDetectionMode_InjectedDelegateField = IL2CPP.ResolveICall<get_collisionDetectionMode_InjectedDelegate>("UnityEngine.Rigidbody::get_collisionDetectionMode_Injected");
		set_collisionDetectionMode_InjectedDelegateField = IL2CPP.ResolveICall<set_collisionDetectionMode_InjectedDelegate>("UnityEngine.Rigidbody::set_collisionDetectionMode_Injected");
		get_automaticCenterOfMass_InjectedDelegateField = IL2CPP.ResolveICall<get_automaticCenterOfMass_InjectedDelegate>("UnityEngine.Rigidbody::get_automaticCenterOfMass_Injected");
		set_automaticCenterOfMass_InjectedDelegateField = IL2CPP.ResolveICall<set_automaticCenterOfMass_InjectedDelegate>("UnityEngine.Rigidbody::set_automaticCenterOfMass_Injected");
		get_centerOfMass_InjectedDelegateField = IL2CPP.ResolveICall<get_centerOfMass_InjectedDelegate>("UnityEngine.Rigidbody::get_centerOfMass_Injected");
		set_centerOfMass_InjectedDelegateField = IL2CPP.ResolveICall<set_centerOfMass_InjectedDelegate>("UnityEngine.Rigidbody::set_centerOfMass_Injected");
		get_worldCenterOfMass_InjectedDelegateField = IL2CPP.ResolveICall<get_worldCenterOfMass_InjectedDelegate>("UnityEngine.Rigidbody::get_worldCenterOfMass_Injected");
		get_automaticInertiaTensor_InjectedDelegateField = IL2CPP.ResolveICall<get_automaticInertiaTensor_InjectedDelegate>("UnityEngine.Rigidbody::get_automaticInertiaTensor_Injected");
		set_automaticInertiaTensor_InjectedDelegateField = IL2CPP.ResolveICall<set_automaticInertiaTensor_InjectedDelegate>("UnityEngine.Rigidbody::set_automaticInertiaTensor_Injected");
		get_inertiaTensorRotation_InjectedDelegateField = IL2CPP.ResolveICall<get_inertiaTensorRotation_InjectedDelegate>("UnityEngine.Rigidbody::get_inertiaTensorRotation_Injected");
		set_inertiaTensorRotation_InjectedDelegateField = IL2CPP.ResolveICall<set_inertiaTensorRotation_InjectedDelegate>("UnityEngine.Rigidbody::set_inertiaTensorRotation_Injected");
		get_inertiaTensor_InjectedDelegateField = IL2CPP.ResolveICall<get_inertiaTensor_InjectedDelegate>("UnityEngine.Rigidbody::get_inertiaTensor_Injected");
		set_inertiaTensor_InjectedDelegateField = IL2CPP.ResolveICall<set_inertiaTensor_InjectedDelegate>("UnityEngine.Rigidbody::set_inertiaTensor_Injected");
		get_worldInertiaTensorMatrix_InjectedDelegateField = IL2CPP.ResolveICall<get_worldInertiaTensorMatrix_InjectedDelegate>("UnityEngine.Rigidbody::get_worldInertiaTensorMatrix_Injected");
		get_detectCollisions_InjectedDelegateField = IL2CPP.ResolveICall<get_detectCollisions_InjectedDelegate>("UnityEngine.Rigidbody::get_detectCollisions_Injected");
		set_detectCollisions_InjectedDelegateField = IL2CPP.ResolveICall<set_detectCollisions_InjectedDelegate>("UnityEngine.Rigidbody::set_detectCollisions_Injected");
		get_interpolation_InjectedDelegateField = IL2CPP.ResolveICall<get_interpolation_InjectedDelegate>("UnityEngine.Rigidbody::get_interpolation_Injected");
		set_interpolation_InjectedDelegateField = IL2CPP.ResolveICall<set_interpolation_InjectedDelegate>("UnityEngine.Rigidbody::set_interpolation_Injected");
		get_solverIterations_InjectedDelegateField = IL2CPP.ResolveICall<get_solverIterations_InjectedDelegate>("UnityEngine.Rigidbody::get_solverIterations_Injected");
		set_solverIterations_InjectedDelegateField = IL2CPP.ResolveICall<set_solverIterations_InjectedDelegate>("UnityEngine.Rigidbody::set_solverIterations_Injected");
		get_sleepThreshold_InjectedDelegateField = IL2CPP.ResolveICall<get_sleepThreshold_InjectedDelegate>("UnityEngine.Rigidbody::get_sleepThreshold_Injected");
		set_sleepThreshold_InjectedDelegateField = IL2CPP.ResolveICall<set_sleepThreshold_InjectedDelegate>("UnityEngine.Rigidbody::set_sleepThreshold_Injected");
		get_maxAngularVelocity_InjectedDelegateField = IL2CPP.ResolveICall<get_maxAngularVelocity_InjectedDelegate>("UnityEngine.Rigidbody::get_maxAngularVelocity_Injected");
		set_maxAngularVelocity_InjectedDelegateField = IL2CPP.ResolveICall<set_maxAngularVelocity_InjectedDelegate>("UnityEngine.Rigidbody::set_maxAngularVelocity_Injected");
		get_maxLinearVelocity_InjectedDelegateField = IL2CPP.ResolveICall<get_maxLinearVelocity_InjectedDelegate>("UnityEngine.Rigidbody::get_maxLinearVelocity_Injected");
		set_maxLinearVelocity_InjectedDelegateField = IL2CPP.ResolveICall<set_maxLinearVelocity_InjectedDelegate>("UnityEngine.Rigidbody::set_maxLinearVelocity_Injected");
		Move_InjectedDelegateField = IL2CPP.ResolveICall<Move_InjectedDelegate>("UnityEngine.Rigidbody::Move_Injected");
		Sleep_InjectedDelegateField = IL2CPP.ResolveICall<Sleep_InjectedDelegate>("UnityEngine.Rigidbody::Sleep_Injected");
		IsSleeping_InjectedDelegateField = IL2CPP.ResolveICall<IsSleeping_InjectedDelegate>("UnityEngine.Rigidbody::IsSleeping_Injected");
		WakeUp_InjectedDelegateField = IL2CPP.ResolveICall<WakeUp_InjectedDelegate>("UnityEngine.Rigidbody::WakeUp_Injected");
		ResetCenterOfMass_InjectedDelegateField = IL2CPP.ResolveICall<ResetCenterOfMass_InjectedDelegate>("UnityEngine.Rigidbody::ResetCenterOfMass_Injected");
		ResetInertiaTensor_InjectedDelegateField = IL2CPP.ResolveICall<ResetInertiaTensor_InjectedDelegate>("UnityEngine.Rigidbody::ResetInertiaTensor_Injected");
		GetRelativePointVelocity_InjectedDelegateField = IL2CPP.ResolveICall<GetRelativePointVelocity_InjectedDelegate>("UnityEngine.Rigidbody::GetRelativePointVelocity_Injected");
		GetPointVelocity_InjectedDelegateField = IL2CPP.ResolveICall<GetPointVelocity_InjectedDelegate>("UnityEngine.Rigidbody::GetPointVelocity_Injected");
		get_solverVelocityIterations_InjectedDelegateField = IL2CPP.ResolveICall<get_solverVelocityIterations_InjectedDelegate>("UnityEngine.Rigidbody::get_solverVelocityIterations_Injected");
		set_solverVelocityIterations_InjectedDelegateField = IL2CPP.ResolveICall<set_solverVelocityIterations_InjectedDelegate>("UnityEngine.Rigidbody::set_solverVelocityIterations_Injected");
		PublishTransform_InjectedDelegateField = IL2CPP.ResolveICall<PublishTransform_InjectedDelegate>("UnityEngine.Rigidbody::PublishTransform_Injected");
		get_excludeLayers_InjectedDelegateField = IL2CPP.ResolveICall<get_excludeLayers_InjectedDelegate>("UnityEngine.Rigidbody::get_excludeLayers_Injected");
		set_excludeLayers_InjectedDelegateField = IL2CPP.ResolveICall<set_excludeLayers_InjectedDelegate>("UnityEngine.Rigidbody::set_excludeLayers_Injected");
		get_includeLayers_InjectedDelegateField = IL2CPP.ResolveICall<get_includeLayers_InjectedDelegate>("UnityEngine.Rigidbody::get_includeLayers_Injected");
		set_includeLayers_InjectedDelegateField = IL2CPP.ResolveICall<set_includeLayers_InjectedDelegate>("UnityEngine.Rigidbody::set_includeLayers_Injected");
		GetAccumulatedForce_InjectedDelegateField = IL2CPP.ResolveICall<GetAccumulatedForce_InjectedDelegate>("UnityEngine.Rigidbody::GetAccumulatedForce_Injected");
		GetAccumulatedTorque_InjectedDelegateField = IL2CPP.ResolveICall<GetAccumulatedTorque_InjectedDelegate>("UnityEngine.Rigidbody::GetAccumulatedTorque_Injected");
		AddForce_InjectedDelegateField = IL2CPP.ResolveICall<AddForce_InjectedDelegate>("UnityEngine.Rigidbody::AddForce_Injected");
		AddRelativeForce_InjectedDelegateField = IL2CPP.ResolveICall<AddRelativeForce_InjectedDelegate>("UnityEngine.Rigidbody::AddRelativeForce_Injected");
		AddTorque_InjectedDelegateField = IL2CPP.ResolveICall<AddTorque_InjectedDelegate>("UnityEngine.Rigidbody::AddTorque_Injected");
		AddRelativeTorque_InjectedDelegateField = IL2CPP.ResolveICall<AddRelativeTorque_InjectedDelegate>("UnityEngine.Rigidbody::AddRelativeTorque_Injected");
		AddForceAtPosition_InjectedDelegateField = IL2CPP.ResolveICall<AddForceAtPosition_InjectedDelegate>("UnityEngine.Rigidbody::AddForceAtPosition_Injected");
		AddExplosionForce_InjectedDelegateField = IL2CPP.ResolveICall<AddExplosionForce_InjectedDelegate>("UnityEngine.Rigidbody::AddExplosionForce_Injected");
		Internal_ClosestPointOnBounds_InjectedDelegateField = IL2CPP.ResolveICall<Internal_ClosestPointOnBounds_InjectedDelegate>("UnityEngine.Rigidbody::Internal_ClosestPointOnBounds_Injected");
		SweepTest_InjectedDelegateField = IL2CPP.ResolveICall<SweepTest_InjectedDelegate>("UnityEngine.Rigidbody::SweepTest_Injected");
		Internal_SweepTestAll_InjectedDelegateField = IL2CPP.ResolveICall<Internal_SweepTestAll_InjectedDelegate>("UnityEngine.Rigidbody::Internal_SweepTestAll_Injected");
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1259844, RefRangeEnd = 1259845, XrefRangeStart = 1259840, XrefRangeEnd = 1259844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void MovePosition(Vector3 position)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&position);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MovePosition_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1259849, RefRangeEnd = 1259850, XrefRangeStart = 1259845, XrefRangeEnd = 1259849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void MoveRotation(Quaternion rot)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&rot);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MoveRotation_Public_Void_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(646)]
	[CachedScanResults(RefRangeStart = 1152221, RefRangeEnd = 1152867, XrefRangeStart = 1152221, XrefRangeEnd = 1152867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Rigidbody()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Rigidbody>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259850, XrefRangeEnd = 1259852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void get_position_Injected(System.IntPtr _unity_self, out Vector3 ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_position_Injected_Private_Static_Void_IntPtr_byref_Vector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259852, XrefRangeEnd = 1259854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_position_Injected(System.IntPtr _unity_self, [In] ref Vector3 value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_position_Injected_Private_Static_Void_IntPtr_byref_Vector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259854, XrefRangeEnd = 1259856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void get_rotation_Injected(System.IntPtr _unity_self, out Quaternion ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_rotation_Injected_Private_Static_Void_IntPtr_byref_Quaternion_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259856, XrefRangeEnd = 1259858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_rotation_Injected(System.IntPtr _unity_self, [In] ref Quaternion value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_rotation_Injected_Private_Static_Void_IntPtr_byref_Quaternion_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259858, XrefRangeEnd = 1259860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void MovePosition_Injected(System.IntPtr _unity_self, [In] ref Vector3 position)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref position);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MovePosition_Injected_Private_Static_Void_IntPtr_byref_Vector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259860, XrefRangeEnd = 1259862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void MoveRotation_Injected(System.IntPtr _unity_self, [In] ref Quaternion rot)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref rot);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MoveRotation_Injected_Private_Static_Void_IntPtr_byref_Quaternion_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public Rigidbody(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public void SetDensity(float density)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		SetDensity_Injected(intPtr, density);
	}

	public void Move(Vector3 position, Quaternion rotation)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		Move_Injected(intPtr, ref position, ref rotation);
	}

	public void Sleep()
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		Sleep_Injected(intPtr);
	}

	public bool IsSleeping()
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return IsSleeping_Injected(intPtr);
	}

	public void WakeUp()
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		WakeUp_Injected(intPtr);
	}

	public void ResetCenterOfMass()
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		ResetCenterOfMass_Injected(intPtr);
	}

	public void ResetInertiaTensor()
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		ResetInertiaTensor_Injected(intPtr);
	}

	public Vector3 GetRelativePointVelocity(Vector3 relativePoint)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		GetRelativePointVelocity_Injected(intPtr, ref relativePoint, out var ret);
		return ret;
	}

	public Vector3 GetPointVelocity(Vector3 worldPoint)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		GetPointVelocity_Injected(intPtr, ref worldPoint, out var ret);
		return ret;
	}

	public void PublishTransform()
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		PublishTransform_Injected(intPtr);
	}

	public Vector3 GetAccumulatedForce(float step)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		GetAccumulatedForce_Injected(intPtr, step, out var ret);
		return ret;
	}

	public Vector3 GetAccumulatedForce()
	{
		return GetAccumulatedForce(Time.fixedDeltaTime);
	}

	public Vector3 GetAccumulatedTorque(float step)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		GetAccumulatedTorque_Injected(intPtr, step, out var ret);
		return ret;
	}

	public Vector3 GetAccumulatedTorque()
	{
		return GetAccumulatedTorque(Time.fixedDeltaTime);
	}

	public void AddForce(Vector3 force, ForceMode mode)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		AddForce_Injected(intPtr, ref force, mode);
	}

	public void AddForce(Vector3 force)
	{
		AddForce(force, ForceMode.Force);
	}

	public void AddForce(float x, float y, float z, ForceMode mode)
	{
		AddForce(new Vector3(x, y, z), mode);
	}

	public void AddForce(float x, float y, float z)
	{
		AddForce(new Vector3(x, y, z), ForceMode.Force);
	}

	public void AddRelativeForce(Vector3 force, ForceMode mode)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		AddRelativeForce_Injected(intPtr, ref force, mode);
	}

	public void AddRelativeForce(Vector3 force)
	{
		AddRelativeForce(force, ForceMode.Force);
	}

	public void AddRelativeForce(float x, float y, float z, ForceMode mode)
	{
		AddRelativeForce(new Vector3(x, y, z), mode);
	}

	public void AddRelativeForce(float x, float y, float z)
	{
		AddRelativeForce(new Vector3(x, y, z), ForceMode.Force);
	}

	public void AddTorque(Vector3 torque, ForceMode mode)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		AddTorque_Injected(intPtr, ref torque, mode);
	}

	public void AddTorque(Vector3 torque)
	{
		AddTorque(torque, ForceMode.Force);
	}

	public void AddTorque(float x, float y, float z, ForceMode mode)
	{
		AddTorque(new Vector3(x, y, z), mode);
	}

	public void AddTorque(float x, float y, float z)
	{
		AddTorque(new Vector3(x, y, z), ForceMode.Force);
	}

	public void AddRelativeTorque(Vector3 torque, ForceMode mode)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		AddRelativeTorque_Injected(intPtr, ref torque, mode);
	}

	public void AddRelativeTorque(Vector3 torque)
	{
		AddRelativeTorque(torque, ForceMode.Force);
	}

	public void AddRelativeTorque(float x, float y, float z, ForceMode mode)
	{
		AddRelativeTorque(new Vector3(x, y, z), mode);
	}

	public void AddRelativeTorque(float x, float y, float z)
	{
		AddRelativeTorque(x, y, z, ForceMode.Force);
	}

	public void AddForceAtPosition(Vector3 force, Vector3 position, ForceMode mode)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		AddForceAtPosition_Injected(intPtr, ref force, ref position, mode);
	}

	public void AddForceAtPosition(Vector3 force, Vector3 position)
	{
		AddForceAtPosition(force, position, ForceMode.Force);
	}

	public void AddExplosionForce(float explosionForce, Vector3 explosionPosition, float explosionRadius, float upwardsModifier, ForceMode mode)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		AddExplosionForce_Injected(intPtr, explosionForce, ref explosionPosition, explosionRadius, upwardsModifier, mode);
	}

	public void AddExplosionForce(float explosionForce, Vector3 explosionPosition, float explosionRadius, float upwardsModifier)
	{
		AddExplosionForce(explosionForce, explosionPosition, explosionRadius, upwardsModifier, ForceMode.Force);
	}

	public void AddExplosionForce(float explosionForce, Vector3 explosionPosition, float explosionRadius)
	{
		AddExplosionForce(explosionForce, explosionPosition, explosionRadius, 0f, ForceMode.Force);
	}

	public void Internal_ClosestPointOnBounds(Vector3 point, ref Vector3 outPos, ref float distance)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		Internal_ClosestPointOnBounds_Injected(intPtr, ref point, ref outPos, ref distance);
	}

	public Vector3 ClosestPointOnBounds(Vector3 position)
	{
		float distance = 0f;
		Vector3 outPos = Vector3.zero;
		Internal_ClosestPointOnBounds(position, ref outPos, ref distance);
		return outPos;
	}

	public RaycastHit SweepTest(Vector3 direction, float maxDistance, QueryTriggerInteraction queryTriggerInteraction, ref bool hasHit)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		SweepTest_Injected(intPtr, ref direction, maxDistance, queryTriggerInteraction, ref hasHit, out var ret);
		return ret;
	}

	public bool SweepTest(Vector3 direction, out RaycastHit hitInfo, float maxDistance, QueryTriggerInteraction queryTriggerInteraction)
	{
		float magnitude = direction.magnitude;
		if (magnitude > float.Epsilon)
		{
			Vector3 direction2 = direction / magnitude;
			bool hasHit = false;
			hitInfo = SweepTest(direction2, maxDistance, queryTriggerInteraction, ref hasHit);
			return hasHit;
		}
		hitInfo = default(RaycastHit);
		return false;
	}

	public bool SweepTest(Vector3 direction, out RaycastHit hitInfo, float maxDistance)
	{
		return SweepTest(direction, out hitInfo, maxDistance, QueryTriggerInteraction.UseGlobal);
	}

	public bool SweepTest(Vector3 direction, out RaycastHit hitInfo)
	{
		return SweepTest(direction, out hitInfo, float.PositiveInfinity, QueryTriggerInteraction.UseGlobal);
	}

	public unsafe Il2CppStructArray<RaycastHit> Internal_SweepTestAll(Vector3 direction, float maxDistance, QueryTriggerInteraction queryTriggerInteraction)
	{
		Unsafe.SkipInit(out BlittableArrayWrapper ret);
		Il2CppStructArray<RaycastHit> result;
		try
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			Internal_SweepTestAll_Injected(intPtr, ref direction, maxDistance, queryTriggerInteraction, out ret);
		}
		finally
		{
			Unsafe.SkipInit(out Il2CppStructArray<RaycastHit> array);
			ret.Unmarshal(ref *(Il2CppArrayBase<RaycastHit>*)(&array));
			result = array;
		}
		return result;
	}

	public Il2CppStructArray<RaycastHit> SweepTestAll(Vector3 direction, float maxDistance, QueryTriggerInteraction queryTriggerInteraction)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public Il2CppStructArray<RaycastHit> SweepTestAll(Vector3 direction, float maxDistance)
	{
		return SweepTestAll(direction, maxDistance, QueryTriggerInteraction.UseGlobal);
	}

	public Il2CppStructArray<RaycastHit> SweepTestAll(Vector3 direction)
	{
		return SweepTestAll(direction, float.PositiveInfinity, QueryTriggerInteraction.UseGlobal);
	}

	public void SetMaxAngularVelocity(float a)
	{
		maxAngularVelocity = a;
	}

	public unsafe static void get_linearVelocity_Injected(System.IntPtr _unity_self, out Vector3 ret)
	{
		get_linearVelocity_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void set_linearVelocity_Injected(System.IntPtr _unity_self, [In] ref Vector3 value)
	{
		set_linearVelocity_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref value));
	}

	public unsafe static void get_angularVelocity_Injected(System.IntPtr _unity_self, out Vector3 ret)
	{
		get_angularVelocity_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void set_angularVelocity_Injected(System.IntPtr _unity_self, [In] ref Vector3 value)
	{
		set_angularVelocity_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref value));
	}

	public static float get_linearDamping_Injected(System.IntPtr _unity_self)
	{
		return get_linearDamping_InjectedDelegateField(_unity_self);
	}

	public static void set_linearDamping_Injected(System.IntPtr _unity_self, float value)
	{
		set_linearDamping_InjectedDelegateField(_unity_self, value);
	}

	public static float get_angularDamping_Injected(System.IntPtr _unity_self)
	{
		return get_angularDamping_InjectedDelegateField(_unity_self);
	}

	public static void set_angularDamping_Injected(System.IntPtr _unity_self, float value)
	{
		set_angularDamping_InjectedDelegateField(_unity_self, value);
	}

	public static float get_mass_Injected(System.IntPtr _unity_self)
	{
		return get_mass_InjectedDelegateField(_unity_self);
	}

	public static void set_mass_Injected(System.IntPtr _unity_self, float value)
	{
		set_mass_InjectedDelegateField(_unity_self, value);
	}

	public static void SetDensity_Injected(System.IntPtr _unity_self, float density)
	{
		SetDensity_InjectedDelegateField(_unity_self, density);
	}

	public static bool get_useGravity_Injected(System.IntPtr _unity_self)
	{
		return get_useGravity_InjectedDelegateField(_unity_self);
	}

	public static void set_useGravity_Injected(System.IntPtr _unity_self, bool value)
	{
		set_useGravity_InjectedDelegateField(_unity_self, value);
	}

	public static float get_maxDepenetrationVelocity_Injected(System.IntPtr _unity_self)
	{
		return get_maxDepenetrationVelocity_InjectedDelegateField(_unity_self);
	}

	public static void set_maxDepenetrationVelocity_Injected(System.IntPtr _unity_self, float value)
	{
		set_maxDepenetrationVelocity_InjectedDelegateField(_unity_self, value);
	}

	public static bool get_isKinematic_Injected(System.IntPtr _unity_self)
	{
		return get_isKinematic_InjectedDelegateField(_unity_self);
	}

	public static void set_isKinematic_Injected(System.IntPtr _unity_self, bool value)
	{
		set_isKinematic_InjectedDelegateField(_unity_self, value);
	}

	public static RigidbodyConstraints get_constraints_Injected(System.IntPtr _unity_self)
	{
		return get_constraints_InjectedDelegateField(_unity_self);
	}

	public static void set_constraints_Injected(System.IntPtr _unity_self, RigidbodyConstraints value)
	{
		set_constraints_InjectedDelegateField(_unity_self, value);
	}

	public static CollisionDetectionMode get_collisionDetectionMode_Injected(System.IntPtr _unity_self)
	{
		return get_collisionDetectionMode_InjectedDelegateField(_unity_self);
	}

	public static void set_collisionDetectionMode_Injected(System.IntPtr _unity_self, CollisionDetectionMode value)
	{
		set_collisionDetectionMode_InjectedDelegateField(_unity_self, value);
	}

	public static bool get_automaticCenterOfMass_Injected(System.IntPtr _unity_self)
	{
		return get_automaticCenterOfMass_InjectedDelegateField(_unity_self);
	}

	public static void set_automaticCenterOfMass_Injected(System.IntPtr _unity_self, bool value)
	{
		set_automaticCenterOfMass_InjectedDelegateField(_unity_self, value);
	}

	public unsafe static void get_centerOfMass_Injected(System.IntPtr _unity_self, out Vector3 ret)
	{
		get_centerOfMass_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void set_centerOfMass_Injected(System.IntPtr _unity_self, [In] ref Vector3 value)
	{
		set_centerOfMass_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref value));
	}

	public unsafe static void get_worldCenterOfMass_Injected(System.IntPtr _unity_self, out Vector3 ret)
	{
		get_worldCenterOfMass_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public static bool get_automaticInertiaTensor_Injected(System.IntPtr _unity_self)
	{
		return get_automaticInertiaTensor_InjectedDelegateField(_unity_self);
	}

	public static void set_automaticInertiaTensor_Injected(System.IntPtr _unity_self, bool value)
	{
		set_automaticInertiaTensor_InjectedDelegateField(_unity_self, value);
	}

	public unsafe static void get_inertiaTensorRotation_Injected(System.IntPtr _unity_self, out Quaternion ret)
	{
		get_inertiaTensorRotation_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void set_inertiaTensorRotation_Injected(System.IntPtr _unity_self, [In] ref Quaternion value)
	{
		set_inertiaTensorRotation_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref value));
	}

	public unsafe static void get_inertiaTensor_Injected(System.IntPtr _unity_self, out Vector3 ret)
	{
		get_inertiaTensor_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void set_inertiaTensor_Injected(System.IntPtr _unity_self, [In] ref Vector3 value)
	{
		set_inertiaTensor_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref value));
	}

	public unsafe static void get_worldInertiaTensorMatrix_Injected(System.IntPtr _unity_self, out Matrix4x4 ret)
	{
		get_worldInertiaTensorMatrix_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public static bool get_detectCollisions_Injected(System.IntPtr _unity_self)
	{
		return get_detectCollisions_InjectedDelegateField(_unity_self);
	}

	public static void set_detectCollisions_Injected(System.IntPtr _unity_self, bool value)
	{
		set_detectCollisions_InjectedDelegateField(_unity_self, value);
	}

	public static RigidbodyInterpolation get_interpolation_Injected(System.IntPtr _unity_self)
	{
		return get_interpolation_InjectedDelegateField(_unity_self);
	}

	public static void set_interpolation_Injected(System.IntPtr _unity_self, RigidbodyInterpolation value)
	{
		set_interpolation_InjectedDelegateField(_unity_self, value);
	}

	public static int get_solverIterations_Injected(System.IntPtr _unity_self)
	{
		return get_solverIterations_InjectedDelegateField(_unity_self);
	}

	public static void set_solverIterations_Injected(System.IntPtr _unity_self, int value)
	{
		set_solverIterations_InjectedDelegateField(_unity_self, value);
	}

	public static float get_sleepThreshold_Injected(System.IntPtr _unity_self)
	{
		return get_sleepThreshold_InjectedDelegateField(_unity_self);
	}

	public static void set_sleepThreshold_Injected(System.IntPtr _unity_self, float value)
	{
		set_sleepThreshold_InjectedDelegateField(_unity_self, value);
	}

	public static float get_maxAngularVelocity_Injected(System.IntPtr _unity_self)
	{
		return get_maxAngularVelocity_InjectedDelegateField(_unity_self);
	}

	public static void set_maxAngularVelocity_Injected(System.IntPtr _unity_self, float value)
	{
		set_maxAngularVelocity_InjectedDelegateField(_unity_self, value);
	}

	public static float get_maxLinearVelocity_Injected(System.IntPtr _unity_self)
	{
		return get_maxLinearVelocity_InjectedDelegateField(_unity_self);
	}

	public static void set_maxLinearVelocity_Injected(System.IntPtr _unity_self, float value)
	{
		set_maxLinearVelocity_InjectedDelegateField(_unity_self, value);
	}

	public unsafe static void Move_Injected(System.IntPtr _unity_self, [In] ref Vector3 position, [In] ref Quaternion rotation)
	{
		Move_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref position), (nint)Unsafe.AsPointer(ref rotation));
	}

	public static void Sleep_Injected(System.IntPtr _unity_self)
	{
		Sleep_InjectedDelegateField(_unity_self);
	}

	public static bool IsSleeping_Injected(System.IntPtr _unity_self)
	{
		return IsSleeping_InjectedDelegateField(_unity_self);
	}

	public static void WakeUp_Injected(System.IntPtr _unity_self)
	{
		WakeUp_InjectedDelegateField(_unity_self);
	}

	public static void ResetCenterOfMass_Injected(System.IntPtr _unity_self)
	{
		ResetCenterOfMass_InjectedDelegateField(_unity_self);
	}

	public static void ResetInertiaTensor_Injected(System.IntPtr _unity_self)
	{
		ResetInertiaTensor_InjectedDelegateField(_unity_self);
	}

	public unsafe static void GetRelativePointVelocity_Injected(System.IntPtr _unity_self, [In] ref Vector3 relativePoint, out Vector3 ret)
	{
		GetRelativePointVelocity_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref relativePoint), (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void GetPointVelocity_Injected(System.IntPtr _unity_self, [In] ref Vector3 worldPoint, out Vector3 ret)
	{
		GetPointVelocity_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref worldPoint), (nint)Unsafe.AsPointer(ref ret));
	}

	public static int get_solverVelocityIterations_Injected(System.IntPtr _unity_self)
	{
		return get_solverVelocityIterations_InjectedDelegateField(_unity_self);
	}

	public static void set_solverVelocityIterations_Injected(System.IntPtr _unity_self, int value)
	{
		set_solverVelocityIterations_InjectedDelegateField(_unity_self, value);
	}

	public static void PublishTransform_Injected(System.IntPtr _unity_self)
	{
		PublishTransform_InjectedDelegateField(_unity_self);
	}

	public unsafe static void get_excludeLayers_Injected(System.IntPtr _unity_self, out LayerMask ret)
	{
		get_excludeLayers_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void set_excludeLayers_Injected(System.IntPtr _unity_self, [In] ref LayerMask value)
	{
		set_excludeLayers_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref value));
	}

	public unsafe static void get_includeLayers_Injected(System.IntPtr _unity_self, out LayerMask ret)
	{
		get_includeLayers_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void set_includeLayers_Injected(System.IntPtr _unity_self, [In] ref LayerMask value)
	{
		set_includeLayers_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref value));
	}

	public unsafe static void GetAccumulatedForce_Injected(System.IntPtr _unity_self, float step, out Vector3 ret)
	{
		GetAccumulatedForce_InjectedDelegateField(_unity_self, step, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void GetAccumulatedTorque_Injected(System.IntPtr _unity_self, float step, out Vector3 ret)
	{
		GetAccumulatedTorque_InjectedDelegateField(_unity_self, step, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void AddForce_Injected(System.IntPtr _unity_self, [In] ref Vector3 force, ForceMode mode)
	{
		AddForce_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref force), mode);
	}

	public unsafe static void AddRelativeForce_Injected(System.IntPtr _unity_self, [In] ref Vector3 force, ForceMode mode)
	{
		AddRelativeForce_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref force), mode);
	}

	public unsafe static void AddTorque_Injected(System.IntPtr _unity_self, [In] ref Vector3 torque, ForceMode mode)
	{
		AddTorque_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref torque), mode);
	}

	public unsafe static void AddRelativeTorque_Injected(System.IntPtr _unity_self, [In] ref Vector3 torque, ForceMode mode)
	{
		AddRelativeTorque_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref torque), mode);
	}

	public unsafe static void AddForceAtPosition_Injected(System.IntPtr _unity_self, [In] ref Vector3 force, [In] ref Vector3 position, ForceMode mode)
	{
		AddForceAtPosition_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref force), (nint)Unsafe.AsPointer(ref position), mode);
	}

	public unsafe static void AddExplosionForce_Injected(System.IntPtr _unity_self, float explosionForce, [In] ref Vector3 explosionPosition, float explosionRadius, float upwardsModifier, ForceMode mode)
	{
		AddExplosionForce_InjectedDelegateField(_unity_self, explosionForce, (nint)Unsafe.AsPointer(ref explosionPosition), explosionRadius, upwardsModifier, mode);
	}

	public unsafe static void Internal_ClosestPointOnBounds_Injected(System.IntPtr _unity_self, [In] ref Vector3 point, ref Vector3 outPos, ref float distance)
	{
		Internal_ClosestPointOnBounds_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref point), (nint)Unsafe.AsPointer(ref outPos), (nint)Unsafe.AsPointer(ref distance));
	}

	public unsafe static void SweepTest_Injected(System.IntPtr _unity_self, [In] ref Vector3 direction, float maxDistance, QueryTriggerInteraction queryTriggerInteraction, ref bool hasHit, out RaycastHit ret)
	{
		SweepTest_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref direction), maxDistance, queryTriggerInteraction, (nint)Unsafe.AsPointer(ref hasHit), (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void Internal_SweepTestAll_Injected(System.IntPtr _unity_self, [In] ref Vector3 direction, float maxDistance, QueryTriggerInteraction queryTriggerInteraction, out BlittableArrayWrapper ret)
	{
		Internal_SweepTestAll_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref direction), maxDistance, queryTriggerInteraction, (nint)Unsafe.AsPointer(ref ret));
	}
}
