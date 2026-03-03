using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Bindings;

namespace UnityEngine;

public sealed class Rigidbody2D : Component
{
	private delegate void SetRotation_Angle_InjectedDelegate(System.IntPtr _unity_self, float angle);

	private delegate void SetRotation_Quaternion_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr rotation);

	private delegate void MoveRotation_Quaternion_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr rotation);

	private delegate void MovePositionAndRotation_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr position, float angle);

	private delegate void MovePositionAndRotation_Quaternion_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr position, [In] System.IntPtr rotation);

	private delegate float get_linearVelocityX_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_linearVelocityX_InjectedDelegate(System.IntPtr _unity_self, float value);

	private delegate float get_linearVelocityY_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_linearVelocityY_InjectedDelegate(System.IntPtr _unity_self, float value);

	private delegate float get_angularVelocity_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_angularVelocity_InjectedDelegate(System.IntPtr _unity_self, float value);

	private delegate bool get_useAutoMass_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_useAutoMass_InjectedDelegate(System.IntPtr _unity_self, bool value);

	private delegate float get_mass_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_mass_InjectedDelegate(System.IntPtr _unity_self, float value);

	private delegate System.IntPtr get_sharedMaterial_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_sharedMaterial_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr value);

	private delegate void get_centerOfMass_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr ret);

	private delegate void set_centerOfMass_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr value);

	private delegate void get_worldCenterOfMass_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr ret);

	private delegate float get_inertia_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_inertia_InjectedDelegate(System.IntPtr _unity_self, float value);

	private delegate float get_linearDamping_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_linearDamping_InjectedDelegate(System.IntPtr _unity_self, float value);

	private delegate float get_angularDamping_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_angularDamping_InjectedDelegate(System.IntPtr _unity_self, float value);

	private delegate RigidbodyType2D get_bodyType_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void SetDragBehaviour_InjectedDelegate(System.IntPtr _unity_self, bool dragged);

	private delegate bool get_useFullKinematicContacts_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_useFullKinematicContacts_InjectedDelegate(System.IntPtr _unity_self, bool value);

	private delegate bool get_freezeRotation_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_freezeRotation_InjectedDelegate(System.IntPtr _unity_self, bool value);

	private delegate RigidbodyConstraints2D get_constraints_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_constraints_InjectedDelegate(System.IntPtr _unity_self, RigidbodyConstraints2D value);

	private delegate bool IsSleeping_InjectedDelegate(System.IntPtr _unity_self);

	private delegate bool IsAwake_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void Sleep_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void WakeUp_InjectedDelegate(System.IntPtr _unity_self);

	private delegate bool get_simulated_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_simulated_InjectedDelegate(System.IntPtr _unity_self, bool value);

	private delegate RigidbodyInterpolation2D get_interpolation_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_interpolation_InjectedDelegate(System.IntPtr _unity_self, RigidbodyInterpolation2D value);

	private delegate RigidbodySleepMode2D get_sleepMode_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_sleepMode_InjectedDelegate(System.IntPtr _unity_self, RigidbodySleepMode2D value);

	private delegate CollisionDetectionMode2D get_collisionDetectionMode_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_collisionDetectionMode_InjectedDelegate(System.IntPtr _unity_self, CollisionDetectionMode2D value);

	private delegate int GetAttachedColliderCount_Internal_InjectedDelegate(System.IntPtr _unity_self, bool findTriggers);

	private delegate void get_totalForce_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr ret);

	private delegate void set_totalForce_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr value);

	private delegate float get_totalTorque_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_totalTorque_InjectedDelegate(System.IntPtr _unity_self, float value);

	private delegate void get_excludeLayers_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr ret);

	private delegate void set_excludeLayers_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr value);

	private delegate void get_includeLayers_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr ret);

	private delegate void set_includeLayers_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr value);

	private delegate void get_localToWorldMatrix_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr ret);

	private delegate bool IsTouching_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr collider);

	private delegate bool IsTouching_OtherColliderWithFilter_Internal_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr collider, [In] System.IntPtr contactFilter);

	private delegate bool IsTouching_AnyColliderWithFilter_Internal_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr contactFilter);

	private delegate bool OverlapPoint_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr point);

	private delegate void AddForce_Internal_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr force, ForceMode2D mode);

	private delegate void AddRelativeForce_Internal_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr relativeForce, ForceMode2D mode);

	private delegate void AddForceAtPosition_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr force, [In] System.IntPtr position, ForceMode2D mode);

	private delegate void AddTorque_InjectedDelegate(System.IntPtr _unity_self, float torque, ForceMode2D mode);

	private delegate void GetPoint_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr point, [Out] System.IntPtr ret);

	private delegate void GetRelativePoint_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr relativePoint, [Out] System.IntPtr ret);

	private delegate void GetVector_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr vector, [Out] System.IntPtr ret);

	private delegate void GetRelativeVector_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr relativeVector, [Out] System.IntPtr ret);

	private delegate void GetPointVelocity_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr point, [Out] System.IntPtr ret);

	private delegate void GetRelativePointVelocity_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr relativePoint, [Out] System.IntPtr ret);

	private delegate int GetAttachedCollidersArray_Internal_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr results, bool findTriggers);

	private delegate int GetAttachedCollidersList_Internal_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr results, bool findTriggers);

	private delegate int CastArray_Internal_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr direction, float distance, bool checkIgnoreColliders, System.IntPtr results);

	private delegate int CastList_Internal_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr direction, float distance, bool checkIgnoreColliders, System.IntPtr results);

	private delegate int CastFilteredArray_Internal_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr direction, float distance, bool checkIgnoreColliders, [In] System.IntPtr contactFilter, System.IntPtr results);

	private delegate int CastFilteredList_Internal_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr direction, float distance, bool checkIgnoreColliders, [In] System.IntPtr contactFilter, System.IntPtr results);

	private delegate int CastFrom_Internal_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr position, float angle, [In] System.IntPtr direction, float distance, bool checkIgnoreColliders, System.IntPtr results);

	private delegate int CastFromFiltered_Internal_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr position, float angle, [In] System.IntPtr direction, float distance, bool checkIgnoreColliders, [In] System.IntPtr contactFilter, System.IntPtr results);

	private delegate int OverlapArray_Internal_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr contactFilter, System.IntPtr results);

	private delegate int OverlapList_Internal_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr results);

	private delegate int OverlapFilteredList_Internal_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr contactFilter, System.IntPtr results);

	private delegate int OverlapFromList_Internal_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr position, float angle, System.IntPtr results);

	private delegate int OverlapFromFilteredList_Internal_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr position, float angle, [In] System.IntPtr contactFilter, System.IntPtr results);

	private static readonly System.IntPtr NativeMethodInfoPtr_get_position_Public_get_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_position_Public_set_Void_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_rotation_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_rotation_Public_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MovePosition_Public_Void_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MoveRotation_Public_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MoveRotation_Angle_Private_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_linearVelocity_Public_get_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_linearVelocity_Public_set_Void_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_gravityScale_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_gravityScale_Public_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_bodyType_Public_set_Void_RigidbodyType2D_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_isKinematic_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_velocity_Public_get_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_velocity_Public_set_Void_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_position_Injected_Private_Static_Void_IntPtr_byref_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_position_Injected_Private_Static_Void_IntPtr_byref_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_rotation_Injected_Private_Static_Single_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_rotation_Injected_Private_Static_Void_IntPtr_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MovePosition_Injected_Private_Static_Void_IntPtr_byref_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MoveRotation_Angle_Injected_Private_Static_Void_IntPtr_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_linearVelocity_Injected_Private_Static_Void_IntPtr_byref_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_linearVelocity_Injected_Private_Static_Void_IntPtr_byref_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_gravityScale_Injected_Private_Static_Single_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_gravityScale_Injected_Private_Static_Void_IntPtr_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_bodyType_Injected_Private_Static_Void_IntPtr_RigidbodyType2D_0;

	private static readonly SetRotation_Angle_InjectedDelegate SetRotation_Angle_InjectedDelegateField;

	private static readonly SetRotation_Quaternion_InjectedDelegate SetRotation_Quaternion_InjectedDelegateField;

	private static readonly MoveRotation_Quaternion_InjectedDelegate MoveRotation_Quaternion_InjectedDelegateField;

	private static readonly MovePositionAndRotation_InjectedDelegate MovePositionAndRotation_InjectedDelegateField;

	private static readonly MovePositionAndRotation_Quaternion_InjectedDelegate MovePositionAndRotation_Quaternion_InjectedDelegateField;

	private static readonly get_linearVelocityX_InjectedDelegate get_linearVelocityX_InjectedDelegateField;

	private static readonly set_linearVelocityX_InjectedDelegate set_linearVelocityX_InjectedDelegateField;

	private static readonly get_linearVelocityY_InjectedDelegate get_linearVelocityY_InjectedDelegateField;

	private static readonly set_linearVelocityY_InjectedDelegate set_linearVelocityY_InjectedDelegateField;

	private static readonly get_angularVelocity_InjectedDelegate get_angularVelocity_InjectedDelegateField;

	private static readonly set_angularVelocity_InjectedDelegate set_angularVelocity_InjectedDelegateField;

	private static readonly get_useAutoMass_InjectedDelegate get_useAutoMass_InjectedDelegateField;

	private static readonly set_useAutoMass_InjectedDelegate set_useAutoMass_InjectedDelegateField;

	private static readonly get_mass_InjectedDelegate get_mass_InjectedDelegateField;

	private static readonly set_mass_InjectedDelegate set_mass_InjectedDelegateField;

	private static readonly get_sharedMaterial_InjectedDelegate get_sharedMaterial_InjectedDelegateField;

	private static readonly set_sharedMaterial_InjectedDelegate set_sharedMaterial_InjectedDelegateField;

	private static readonly get_centerOfMass_InjectedDelegate get_centerOfMass_InjectedDelegateField;

	private static readonly set_centerOfMass_InjectedDelegate set_centerOfMass_InjectedDelegateField;

	private static readonly get_worldCenterOfMass_InjectedDelegate get_worldCenterOfMass_InjectedDelegateField;

	private static readonly get_inertia_InjectedDelegate get_inertia_InjectedDelegateField;

	private static readonly set_inertia_InjectedDelegate set_inertia_InjectedDelegateField;

	private static readonly get_linearDamping_InjectedDelegate get_linearDamping_InjectedDelegateField;

	private static readonly set_linearDamping_InjectedDelegate set_linearDamping_InjectedDelegateField;

	private static readonly get_angularDamping_InjectedDelegate get_angularDamping_InjectedDelegateField;

	private static readonly set_angularDamping_InjectedDelegate set_angularDamping_InjectedDelegateField;

	private static readonly get_bodyType_InjectedDelegate get_bodyType_InjectedDelegateField;

	private static readonly SetDragBehaviour_InjectedDelegate SetDragBehaviour_InjectedDelegateField;

	private static readonly get_useFullKinematicContacts_InjectedDelegate get_useFullKinematicContacts_InjectedDelegateField;

	private static readonly set_useFullKinematicContacts_InjectedDelegate set_useFullKinematicContacts_InjectedDelegateField;

	private static readonly get_freezeRotation_InjectedDelegate get_freezeRotation_InjectedDelegateField;

	private static readonly set_freezeRotation_InjectedDelegate set_freezeRotation_InjectedDelegateField;

	private static readonly get_constraints_InjectedDelegate get_constraints_InjectedDelegateField;

	private static readonly set_constraints_InjectedDelegate set_constraints_InjectedDelegateField;

	private static readonly IsSleeping_InjectedDelegate IsSleeping_InjectedDelegateField;

	private static readonly IsAwake_InjectedDelegate IsAwake_InjectedDelegateField;

	private static readonly Sleep_InjectedDelegate Sleep_InjectedDelegateField;

	private static readonly WakeUp_InjectedDelegate WakeUp_InjectedDelegateField;

	private static readonly get_simulated_InjectedDelegate get_simulated_InjectedDelegateField;

	private static readonly set_simulated_InjectedDelegate set_simulated_InjectedDelegateField;

	private static readonly get_interpolation_InjectedDelegate get_interpolation_InjectedDelegateField;

	private static readonly set_interpolation_InjectedDelegate set_interpolation_InjectedDelegateField;

	private static readonly get_sleepMode_InjectedDelegate get_sleepMode_InjectedDelegateField;

	private static readonly set_sleepMode_InjectedDelegate set_sleepMode_InjectedDelegateField;

	private static readonly get_collisionDetectionMode_InjectedDelegate get_collisionDetectionMode_InjectedDelegateField;

	private static readonly set_collisionDetectionMode_InjectedDelegate set_collisionDetectionMode_InjectedDelegateField;

	private static readonly GetAttachedColliderCount_Internal_InjectedDelegate GetAttachedColliderCount_Internal_InjectedDelegateField;

	private static readonly get_totalForce_InjectedDelegate get_totalForce_InjectedDelegateField;

	private static readonly set_totalForce_InjectedDelegate set_totalForce_InjectedDelegateField;

	private static readonly get_totalTorque_InjectedDelegate get_totalTorque_InjectedDelegateField;

	private static readonly set_totalTorque_InjectedDelegate set_totalTorque_InjectedDelegateField;

	private static readonly get_excludeLayers_InjectedDelegate get_excludeLayers_InjectedDelegateField;

	private static readonly set_excludeLayers_InjectedDelegate set_excludeLayers_InjectedDelegateField;

	private static readonly get_includeLayers_InjectedDelegate get_includeLayers_InjectedDelegateField;

	private static readonly set_includeLayers_InjectedDelegate set_includeLayers_InjectedDelegateField;

	private static readonly get_localToWorldMatrix_InjectedDelegate get_localToWorldMatrix_InjectedDelegateField;

	private static readonly IsTouching_InjectedDelegate IsTouching_InjectedDelegateField;

	private static readonly IsTouching_OtherColliderWithFilter_Internal_InjectedDelegate IsTouching_OtherColliderWithFilter_Internal_InjectedDelegateField;

	private static readonly IsTouching_AnyColliderWithFilter_Internal_InjectedDelegate IsTouching_AnyColliderWithFilter_Internal_InjectedDelegateField;

	private static readonly OverlapPoint_InjectedDelegate OverlapPoint_InjectedDelegateField;

	private static readonly AddForce_Internal_InjectedDelegate AddForce_Internal_InjectedDelegateField;

	private static readonly AddRelativeForce_Internal_InjectedDelegate AddRelativeForce_Internal_InjectedDelegateField;

	private static readonly AddForceAtPosition_InjectedDelegate AddForceAtPosition_InjectedDelegateField;

	private static readonly AddTorque_InjectedDelegate AddTorque_InjectedDelegateField;

	private static readonly GetPoint_InjectedDelegate GetPoint_InjectedDelegateField;

	private static readonly GetRelativePoint_InjectedDelegate GetRelativePoint_InjectedDelegateField;

	private static readonly GetVector_InjectedDelegate GetVector_InjectedDelegateField;

	private static readonly GetRelativeVector_InjectedDelegate GetRelativeVector_InjectedDelegateField;

	private static readonly GetPointVelocity_InjectedDelegate GetPointVelocity_InjectedDelegateField;

	private static readonly GetRelativePointVelocity_InjectedDelegate GetRelativePointVelocity_InjectedDelegateField;

	private static readonly GetAttachedCollidersArray_Internal_InjectedDelegate GetAttachedCollidersArray_Internal_InjectedDelegateField;

	private static readonly GetAttachedCollidersList_Internal_InjectedDelegate GetAttachedCollidersList_Internal_InjectedDelegateField;

	private static readonly CastArray_Internal_InjectedDelegate CastArray_Internal_InjectedDelegateField;

	private static readonly CastList_Internal_InjectedDelegate CastList_Internal_InjectedDelegateField;

	private static readonly CastFilteredArray_Internal_InjectedDelegate CastFilteredArray_Internal_InjectedDelegateField;

	private static readonly CastFilteredList_Internal_InjectedDelegate CastFilteredList_Internal_InjectedDelegateField;

	private static readonly CastFrom_Internal_InjectedDelegate CastFrom_Internal_InjectedDelegateField;

	private static readonly CastFromFiltered_Internal_InjectedDelegate CastFromFiltered_Internal_InjectedDelegateField;

	private static readonly OverlapArray_Internal_InjectedDelegate OverlapArray_Internal_InjectedDelegateField;

	private static readonly OverlapList_Internal_InjectedDelegate OverlapList_Internal_InjectedDelegateField;

	private static readonly OverlapFilteredList_Internal_InjectedDelegate OverlapFilteredList_Internal_InjectedDelegateField;

	private static readonly OverlapFromList_Internal_InjectedDelegate OverlapFromList_Internal_InjectedDelegateField;

	private static readonly OverlapFromFilteredList_Internal_InjectedDelegate OverlapFromFilteredList_Internal_InjectedDelegateField;

	public unsafe Vector2 position
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1258958, RefRangeEnd = 1258960, XrefRangeStart = 1258954, XrefRangeEnd = 1258958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_position_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1258964, RefRangeEnd = 1258965, XrefRangeStart = 1258960, XrefRangeEnd = 1258964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_position_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe float rotation
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1258970, RefRangeEnd = 1258971, XrefRangeStart = 1258965, XrefRangeEnd = 1258970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_rotation_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1258976, RefRangeEnd = 1258977, XrefRangeStart = 1258971, XrefRangeEnd = 1258976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_rotation_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe Vector2 linearVelocity
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1258992, RefRangeEnd = 1258994, XrefRangeStart = 1258988, XrefRangeEnd = 1258992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_linearVelocity_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258994, XrefRangeEnd = 1258998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_linearVelocity_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe float gravityScale
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1259003, RefRangeEnd = 1259005, XrefRangeStart = 1258998, XrefRangeEnd = 1259003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_gravityScale_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1259010, RefRangeEnd = 1259012, XrefRangeStart = 1259005, XrefRangeEnd = 1259010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_gravityScale_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe RigidbodyType2D bodyType
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_bodyType_Injected(intPtr);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259012, XrefRangeEnd = 1259017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_bodyType_Public_set_Void_RigidbodyType2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool isKinematic
	{
		get
		{
			return bodyType == RigidbodyType2D.Kinematic;
		}
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1259022, RefRangeEnd = 1259024, XrefRangeStart = 1259017, XrefRangeEnd = 1259022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_isKinematic_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe Vector2 velocity
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1258992, RefRangeEnd = 1258994, XrefRangeStart = 1258992, XrefRangeEnd = 1258994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_velocity_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1259028, RefRangeEnd = 1259029, XrefRangeStart = 1259024, XrefRangeEnd = 1259028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_velocity_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public float linearVelocityX
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_linearVelocityX_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_linearVelocityX_Injected(intPtr, value);
		}
	}

	public float linearVelocityY
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_linearVelocityY_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_linearVelocityY_Injected(intPtr, value);
		}
	}

	public float angularVelocity
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_angularVelocity_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_angularVelocity_Injected(intPtr, value);
		}
	}

	public bool useAutoMass
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_useAutoMass_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_useAutoMass_Injected(intPtr, value);
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

	public PhysicsMaterial2D sharedMaterial
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return Unmarshal.UnmarshalUnityObject<PhysicsMaterial2D>(get_sharedMaterial_Injected(intPtr));
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_sharedMaterial_Injected(intPtr, MarshalledUnityObject.Marshal(value));
		}
	}

	public Vector2 centerOfMass
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

	public Vector2 worldCenterOfMass
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

	public float inertia
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_inertia_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_inertia_Injected(intPtr, value);
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

	public bool useFullKinematicContacts
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_useFullKinematicContacts_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_useFullKinematicContacts_Injected(intPtr, value);
		}
	}

	public bool freezeRotation
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_freezeRotation_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_freezeRotation_Injected(intPtr, value);
		}
	}

	public RigidbodyConstraints2D constraints
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

	public bool simulated
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_simulated_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_simulated_Injected(intPtr, value);
		}
	}

	public RigidbodyInterpolation2D interpolation
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

	public RigidbodySleepMode2D sleepMode
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_sleepMode_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_sleepMode_Injected(intPtr, value);
		}
	}

	public CollisionDetectionMode2D collisionDetectionMode
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

	public int attachedColliderCount => GetAttachedColliderCount_Internal(findTriggers: true);

	public Vector2 totalForce
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			get_totalForce_Injected(intPtr, out var ret);
			return ret;
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_totalForce_Injected(intPtr, ref value);
		}
	}

	public float totalTorque
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_totalTorque_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_totalTorque_Injected(intPtr, value);
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

	public Matrix4x4 localToWorldMatrix
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			get_localToWorldMatrix_Injected(intPtr, out var ret);
			return ret;
		}
	}

	public bool fixedAngle
	{
		get
		{
			return false;
		}
		set
		{
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

	public float velocityX
	{
		get
		{
			return linearVelocityX;
		}
		set
		{
			linearVelocityX = value;
		}
	}

	public float velocityY
	{
		get
		{
			return linearVelocityY;
		}
		set
		{
			linearVelocityY = value;
		}
	}

	static Rigidbody2D()
	{
		Il2CppClassPointerStore<Rigidbody2D>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Physics2DModule.dll", "UnityEngine", "Rigidbody2D");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Rigidbody2D>.NativeClassPtr);
		NativeMethodInfoPtr_get_position_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rigidbody2D>.NativeClassPtr, 100663347);
		NativeMethodInfoPtr_set_position_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rigidbody2D>.NativeClassPtr, 100663348);
		NativeMethodInfoPtr_get_rotation_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rigidbody2D>.NativeClassPtr, 100663349);
		NativeMethodInfoPtr_set_rotation_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rigidbody2D>.NativeClassPtr, 100663350);
		NativeMethodInfoPtr_MovePosition_Public_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rigidbody2D>.NativeClassPtr, 100663351);
		NativeMethodInfoPtr_MoveRotation_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rigidbody2D>.NativeClassPtr, 100663352);
		NativeMethodInfoPtr_MoveRotation_Angle_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rigidbody2D>.NativeClassPtr, 100663353);
		NativeMethodInfoPtr_get_linearVelocity_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rigidbody2D>.NativeClassPtr, 100663354);
		NativeMethodInfoPtr_set_linearVelocity_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rigidbody2D>.NativeClassPtr, 100663355);
		NativeMethodInfoPtr_get_gravityScale_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rigidbody2D>.NativeClassPtr, 100663356);
		NativeMethodInfoPtr_set_gravityScale_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rigidbody2D>.NativeClassPtr, 100663357);
		NativeMethodInfoPtr_set_bodyType_Public_set_Void_RigidbodyType2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rigidbody2D>.NativeClassPtr, 100663358);
		NativeMethodInfoPtr_set_isKinematic_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rigidbody2D>.NativeClassPtr, 100663359);
		NativeMethodInfoPtr_get_velocity_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rigidbody2D>.NativeClassPtr, 100663360);
		NativeMethodInfoPtr_set_velocity_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rigidbody2D>.NativeClassPtr, 100663361);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rigidbody2D>.NativeClassPtr, 100663362);
		NativeMethodInfoPtr_get_position_Injected_Private_Static_Void_IntPtr_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rigidbody2D>.NativeClassPtr, 100663363);
		NativeMethodInfoPtr_set_position_Injected_Private_Static_Void_IntPtr_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rigidbody2D>.NativeClassPtr, 100663364);
		NativeMethodInfoPtr_get_rotation_Injected_Private_Static_Single_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rigidbody2D>.NativeClassPtr, 100663365);
		NativeMethodInfoPtr_set_rotation_Injected_Private_Static_Void_IntPtr_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rigidbody2D>.NativeClassPtr, 100663366);
		NativeMethodInfoPtr_MovePosition_Injected_Private_Static_Void_IntPtr_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rigidbody2D>.NativeClassPtr, 100663367);
		NativeMethodInfoPtr_MoveRotation_Angle_Injected_Private_Static_Void_IntPtr_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rigidbody2D>.NativeClassPtr, 100663368);
		NativeMethodInfoPtr_get_linearVelocity_Injected_Private_Static_Void_IntPtr_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rigidbody2D>.NativeClassPtr, 100663369);
		NativeMethodInfoPtr_set_linearVelocity_Injected_Private_Static_Void_IntPtr_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rigidbody2D>.NativeClassPtr, 100663370);
		NativeMethodInfoPtr_get_gravityScale_Injected_Private_Static_Single_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rigidbody2D>.NativeClassPtr, 100663371);
		NativeMethodInfoPtr_set_gravityScale_Injected_Private_Static_Void_IntPtr_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rigidbody2D>.NativeClassPtr, 100663372);
		NativeMethodInfoPtr_set_bodyType_Injected_Private_Static_Void_IntPtr_RigidbodyType2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rigidbody2D>.NativeClassPtr, 100663373);
		SetRotation_Angle_InjectedDelegateField = IL2CPP.ResolveICall<SetRotation_Angle_InjectedDelegate>("UnityEngine.Rigidbody2D::SetRotation_Angle_Injected");
		SetRotation_Quaternion_InjectedDelegateField = IL2CPP.ResolveICall<SetRotation_Quaternion_InjectedDelegate>("UnityEngine.Rigidbody2D::SetRotation_Quaternion_Injected");
		MoveRotation_Quaternion_InjectedDelegateField = IL2CPP.ResolveICall<MoveRotation_Quaternion_InjectedDelegate>("UnityEngine.Rigidbody2D::MoveRotation_Quaternion_Injected");
		MovePositionAndRotation_InjectedDelegateField = IL2CPP.ResolveICall<MovePositionAndRotation_InjectedDelegate>("UnityEngine.Rigidbody2D::MovePositionAndRotation_Injected");
		MovePositionAndRotation_Quaternion_InjectedDelegateField = IL2CPP.ResolveICall<MovePositionAndRotation_Quaternion_InjectedDelegate>("UnityEngine.Rigidbody2D::MovePositionAndRotation_Quaternion_Injected");
		get_linearVelocityX_InjectedDelegateField = IL2CPP.ResolveICall<get_linearVelocityX_InjectedDelegate>("UnityEngine.Rigidbody2D::get_linearVelocityX_Injected");
		set_linearVelocityX_InjectedDelegateField = IL2CPP.ResolveICall<set_linearVelocityX_InjectedDelegate>("UnityEngine.Rigidbody2D::set_linearVelocityX_Injected");
		get_linearVelocityY_InjectedDelegateField = IL2CPP.ResolveICall<get_linearVelocityY_InjectedDelegate>("UnityEngine.Rigidbody2D::get_linearVelocityY_Injected");
		set_linearVelocityY_InjectedDelegateField = IL2CPP.ResolveICall<set_linearVelocityY_InjectedDelegate>("UnityEngine.Rigidbody2D::set_linearVelocityY_Injected");
		get_angularVelocity_InjectedDelegateField = IL2CPP.ResolveICall<get_angularVelocity_InjectedDelegate>("UnityEngine.Rigidbody2D::get_angularVelocity_Injected");
		set_angularVelocity_InjectedDelegateField = IL2CPP.ResolveICall<set_angularVelocity_InjectedDelegate>("UnityEngine.Rigidbody2D::set_angularVelocity_Injected");
		get_useAutoMass_InjectedDelegateField = IL2CPP.ResolveICall<get_useAutoMass_InjectedDelegate>("UnityEngine.Rigidbody2D::get_useAutoMass_Injected");
		set_useAutoMass_InjectedDelegateField = IL2CPP.ResolveICall<set_useAutoMass_InjectedDelegate>("UnityEngine.Rigidbody2D::set_useAutoMass_Injected");
		get_mass_InjectedDelegateField = IL2CPP.ResolveICall<get_mass_InjectedDelegate>("UnityEngine.Rigidbody2D::get_mass_Injected");
		set_mass_InjectedDelegateField = IL2CPP.ResolveICall<set_mass_InjectedDelegate>("UnityEngine.Rigidbody2D::set_mass_Injected");
		get_sharedMaterial_InjectedDelegateField = IL2CPP.ResolveICall<get_sharedMaterial_InjectedDelegate>("UnityEngine.Rigidbody2D::get_sharedMaterial_Injected");
		set_sharedMaterial_InjectedDelegateField = IL2CPP.ResolveICall<set_sharedMaterial_InjectedDelegate>("UnityEngine.Rigidbody2D::set_sharedMaterial_Injected");
		get_centerOfMass_InjectedDelegateField = IL2CPP.ResolveICall<get_centerOfMass_InjectedDelegate>("UnityEngine.Rigidbody2D::get_centerOfMass_Injected");
		set_centerOfMass_InjectedDelegateField = IL2CPP.ResolveICall<set_centerOfMass_InjectedDelegate>("UnityEngine.Rigidbody2D::set_centerOfMass_Injected");
		get_worldCenterOfMass_InjectedDelegateField = IL2CPP.ResolveICall<get_worldCenterOfMass_InjectedDelegate>("UnityEngine.Rigidbody2D::get_worldCenterOfMass_Injected");
		get_inertia_InjectedDelegateField = IL2CPP.ResolveICall<get_inertia_InjectedDelegate>("UnityEngine.Rigidbody2D::get_inertia_Injected");
		set_inertia_InjectedDelegateField = IL2CPP.ResolveICall<set_inertia_InjectedDelegate>("UnityEngine.Rigidbody2D::set_inertia_Injected");
		get_linearDamping_InjectedDelegateField = IL2CPP.ResolveICall<get_linearDamping_InjectedDelegate>("UnityEngine.Rigidbody2D::get_linearDamping_Injected");
		set_linearDamping_InjectedDelegateField = IL2CPP.ResolveICall<set_linearDamping_InjectedDelegate>("UnityEngine.Rigidbody2D::set_linearDamping_Injected");
		get_angularDamping_InjectedDelegateField = IL2CPP.ResolveICall<get_angularDamping_InjectedDelegate>("UnityEngine.Rigidbody2D::get_angularDamping_Injected");
		set_angularDamping_InjectedDelegateField = IL2CPP.ResolveICall<set_angularDamping_InjectedDelegate>("UnityEngine.Rigidbody2D::set_angularDamping_Injected");
		get_bodyType_InjectedDelegateField = IL2CPP.ResolveICall<get_bodyType_InjectedDelegate>("UnityEngine.Rigidbody2D::get_bodyType_Injected");
		SetDragBehaviour_InjectedDelegateField = IL2CPP.ResolveICall<SetDragBehaviour_InjectedDelegate>("UnityEngine.Rigidbody2D::SetDragBehaviour_Injected");
		get_useFullKinematicContacts_InjectedDelegateField = IL2CPP.ResolveICall<get_useFullKinematicContacts_InjectedDelegate>("UnityEngine.Rigidbody2D::get_useFullKinematicContacts_Injected");
		set_useFullKinematicContacts_InjectedDelegateField = IL2CPP.ResolveICall<set_useFullKinematicContacts_InjectedDelegate>("UnityEngine.Rigidbody2D::set_useFullKinematicContacts_Injected");
		get_freezeRotation_InjectedDelegateField = IL2CPP.ResolveICall<get_freezeRotation_InjectedDelegate>("UnityEngine.Rigidbody2D::get_freezeRotation_Injected");
		set_freezeRotation_InjectedDelegateField = IL2CPP.ResolveICall<set_freezeRotation_InjectedDelegate>("UnityEngine.Rigidbody2D::set_freezeRotation_Injected");
		get_constraints_InjectedDelegateField = IL2CPP.ResolveICall<get_constraints_InjectedDelegate>("UnityEngine.Rigidbody2D::get_constraints_Injected");
		set_constraints_InjectedDelegateField = IL2CPP.ResolveICall<set_constraints_InjectedDelegate>("UnityEngine.Rigidbody2D::set_constraints_Injected");
		IsSleeping_InjectedDelegateField = IL2CPP.ResolveICall<IsSleeping_InjectedDelegate>("UnityEngine.Rigidbody2D::IsSleeping_Injected");
		IsAwake_InjectedDelegateField = IL2CPP.ResolveICall<IsAwake_InjectedDelegate>("UnityEngine.Rigidbody2D::IsAwake_Injected");
		Sleep_InjectedDelegateField = IL2CPP.ResolveICall<Sleep_InjectedDelegate>("UnityEngine.Rigidbody2D::Sleep_Injected");
		WakeUp_InjectedDelegateField = IL2CPP.ResolveICall<WakeUp_InjectedDelegate>("UnityEngine.Rigidbody2D::WakeUp_Injected");
		get_simulated_InjectedDelegateField = IL2CPP.ResolveICall<get_simulated_InjectedDelegate>("UnityEngine.Rigidbody2D::get_simulated_Injected");
		set_simulated_InjectedDelegateField = IL2CPP.ResolveICall<set_simulated_InjectedDelegate>("UnityEngine.Rigidbody2D::set_simulated_Injected");
		get_interpolation_InjectedDelegateField = IL2CPP.ResolveICall<get_interpolation_InjectedDelegate>("UnityEngine.Rigidbody2D::get_interpolation_Injected");
		set_interpolation_InjectedDelegateField = IL2CPP.ResolveICall<set_interpolation_InjectedDelegate>("UnityEngine.Rigidbody2D::set_interpolation_Injected");
		get_sleepMode_InjectedDelegateField = IL2CPP.ResolveICall<get_sleepMode_InjectedDelegate>("UnityEngine.Rigidbody2D::get_sleepMode_Injected");
		set_sleepMode_InjectedDelegateField = IL2CPP.ResolveICall<set_sleepMode_InjectedDelegate>("UnityEngine.Rigidbody2D::set_sleepMode_Injected");
		get_collisionDetectionMode_InjectedDelegateField = IL2CPP.ResolveICall<get_collisionDetectionMode_InjectedDelegate>("UnityEngine.Rigidbody2D::get_collisionDetectionMode_Injected");
		set_collisionDetectionMode_InjectedDelegateField = IL2CPP.ResolveICall<set_collisionDetectionMode_InjectedDelegate>("UnityEngine.Rigidbody2D::set_collisionDetectionMode_Injected");
		GetAttachedColliderCount_Internal_InjectedDelegateField = IL2CPP.ResolveICall<GetAttachedColliderCount_Internal_InjectedDelegate>("UnityEngine.Rigidbody2D::GetAttachedColliderCount_Internal_Injected");
		get_totalForce_InjectedDelegateField = IL2CPP.ResolveICall<get_totalForce_InjectedDelegate>("UnityEngine.Rigidbody2D::get_totalForce_Injected");
		set_totalForce_InjectedDelegateField = IL2CPP.ResolveICall<set_totalForce_InjectedDelegate>("UnityEngine.Rigidbody2D::set_totalForce_Injected");
		get_totalTorque_InjectedDelegateField = IL2CPP.ResolveICall<get_totalTorque_InjectedDelegate>("UnityEngine.Rigidbody2D::get_totalTorque_Injected");
		set_totalTorque_InjectedDelegateField = IL2CPP.ResolveICall<set_totalTorque_InjectedDelegate>("UnityEngine.Rigidbody2D::set_totalTorque_Injected");
		get_excludeLayers_InjectedDelegateField = IL2CPP.ResolveICall<get_excludeLayers_InjectedDelegate>("UnityEngine.Rigidbody2D::get_excludeLayers_Injected");
		set_excludeLayers_InjectedDelegateField = IL2CPP.ResolveICall<set_excludeLayers_InjectedDelegate>("UnityEngine.Rigidbody2D::set_excludeLayers_Injected");
		get_includeLayers_InjectedDelegateField = IL2CPP.ResolveICall<get_includeLayers_InjectedDelegate>("UnityEngine.Rigidbody2D::get_includeLayers_Injected");
		set_includeLayers_InjectedDelegateField = IL2CPP.ResolveICall<set_includeLayers_InjectedDelegate>("UnityEngine.Rigidbody2D::set_includeLayers_Injected");
		get_localToWorldMatrix_InjectedDelegateField = IL2CPP.ResolveICall<get_localToWorldMatrix_InjectedDelegate>("UnityEngine.Rigidbody2D::get_localToWorldMatrix_Injected");
		IsTouching_InjectedDelegateField = IL2CPP.ResolveICall<IsTouching_InjectedDelegate>("UnityEngine.Rigidbody2D::IsTouching_Injected");
		IsTouching_OtherColliderWithFilter_Internal_InjectedDelegateField = IL2CPP.ResolveICall<IsTouching_OtherColliderWithFilter_Internal_InjectedDelegate>("UnityEngine.Rigidbody2D::IsTouching_OtherColliderWithFilter_Internal_Injected");
		IsTouching_AnyColliderWithFilter_Internal_InjectedDelegateField = IL2CPP.ResolveICall<IsTouching_AnyColliderWithFilter_Internal_InjectedDelegate>("UnityEngine.Rigidbody2D::IsTouching_AnyColliderWithFilter_Internal_Injected");
		OverlapPoint_InjectedDelegateField = IL2CPP.ResolveICall<OverlapPoint_InjectedDelegate>("UnityEngine.Rigidbody2D::OverlapPoint_Injected");
		AddForce_Internal_InjectedDelegateField = IL2CPP.ResolveICall<AddForce_Internal_InjectedDelegate>("UnityEngine.Rigidbody2D::AddForce_Internal_Injected");
		AddRelativeForce_Internal_InjectedDelegateField = IL2CPP.ResolveICall<AddRelativeForce_Internal_InjectedDelegate>("UnityEngine.Rigidbody2D::AddRelativeForce_Internal_Injected");
		AddForceAtPosition_InjectedDelegateField = IL2CPP.ResolveICall<AddForceAtPosition_InjectedDelegate>("UnityEngine.Rigidbody2D::AddForceAtPosition_Injected");
		AddTorque_InjectedDelegateField = IL2CPP.ResolveICall<AddTorque_InjectedDelegate>("UnityEngine.Rigidbody2D::AddTorque_Injected");
		GetPoint_InjectedDelegateField = IL2CPP.ResolveICall<GetPoint_InjectedDelegate>("UnityEngine.Rigidbody2D::GetPoint_Injected");
		GetRelativePoint_InjectedDelegateField = IL2CPP.ResolveICall<GetRelativePoint_InjectedDelegate>("UnityEngine.Rigidbody2D::GetRelativePoint_Injected");
		GetVector_InjectedDelegateField = IL2CPP.ResolveICall<GetVector_InjectedDelegate>("UnityEngine.Rigidbody2D::GetVector_Injected");
		GetRelativeVector_InjectedDelegateField = IL2CPP.ResolveICall<GetRelativeVector_InjectedDelegate>("UnityEngine.Rigidbody2D::GetRelativeVector_Injected");
		GetPointVelocity_InjectedDelegateField = IL2CPP.ResolveICall<GetPointVelocity_InjectedDelegate>("UnityEngine.Rigidbody2D::GetPointVelocity_Injected");
		GetRelativePointVelocity_InjectedDelegateField = IL2CPP.ResolveICall<GetRelativePointVelocity_InjectedDelegate>("UnityEngine.Rigidbody2D::GetRelativePointVelocity_Injected");
		GetAttachedCollidersArray_Internal_InjectedDelegateField = IL2CPP.ResolveICall<GetAttachedCollidersArray_Internal_InjectedDelegate>("UnityEngine.Rigidbody2D::GetAttachedCollidersArray_Internal_Injected");
		GetAttachedCollidersList_Internal_InjectedDelegateField = IL2CPP.ResolveICall<GetAttachedCollidersList_Internal_InjectedDelegate>("UnityEngine.Rigidbody2D::GetAttachedCollidersList_Internal_Injected");
		CastArray_Internal_InjectedDelegateField = IL2CPP.ResolveICall<CastArray_Internal_InjectedDelegate>("UnityEngine.Rigidbody2D::CastArray_Internal_Injected");
		CastList_Internal_InjectedDelegateField = IL2CPP.ResolveICall<CastList_Internal_InjectedDelegate>("UnityEngine.Rigidbody2D::CastList_Internal_Injected");
		CastFilteredArray_Internal_InjectedDelegateField = IL2CPP.ResolveICall<CastFilteredArray_Internal_InjectedDelegate>("UnityEngine.Rigidbody2D::CastFilteredArray_Internal_Injected");
		CastFilteredList_Internal_InjectedDelegateField = IL2CPP.ResolveICall<CastFilteredList_Internal_InjectedDelegate>("UnityEngine.Rigidbody2D::CastFilteredList_Internal_Injected");
		CastFrom_Internal_InjectedDelegateField = IL2CPP.ResolveICall<CastFrom_Internal_InjectedDelegate>("UnityEngine.Rigidbody2D::CastFrom_Internal_Injected");
		CastFromFiltered_Internal_InjectedDelegateField = IL2CPP.ResolveICall<CastFromFiltered_Internal_InjectedDelegate>("UnityEngine.Rigidbody2D::CastFromFiltered_Internal_Injected");
		OverlapArray_Internal_InjectedDelegateField = IL2CPP.ResolveICall<OverlapArray_Internal_InjectedDelegate>("UnityEngine.Rigidbody2D::OverlapArray_Internal_Injected");
		OverlapList_Internal_InjectedDelegateField = IL2CPP.ResolveICall<OverlapList_Internal_InjectedDelegate>("UnityEngine.Rigidbody2D::OverlapList_Internal_Injected");
		OverlapFilteredList_Internal_InjectedDelegateField = IL2CPP.ResolveICall<OverlapFilteredList_Internal_InjectedDelegate>("UnityEngine.Rigidbody2D::OverlapFilteredList_Internal_Injected");
		OverlapFromList_Internal_InjectedDelegateField = IL2CPP.ResolveICall<OverlapFromList_Internal_InjectedDelegate>("UnityEngine.Rigidbody2D::OverlapFromList_Internal_Injected");
		OverlapFromFilteredList_Internal_InjectedDelegateField = IL2CPP.ResolveICall<OverlapFromFilteredList_Internal_InjectedDelegate>("UnityEngine.Rigidbody2D::OverlapFromFilteredList_Internal_Injected");
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1258981, RefRangeEnd = 1258982, XrefRangeStart = 1258977, XrefRangeEnd = 1258981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void MovePosition(Vector2 position)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&position);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MovePosition_Public_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1258987, RefRangeEnd = 1258988, XrefRangeStart = 1258982, XrefRangeEnd = 1258987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void MoveRotation(float angle)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&angle);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MoveRotation_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1258987, RefRangeEnd = 1258988, XrefRangeStart = 1258987, XrefRangeEnd = 1258988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void MoveRotation_Angle(float angle)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&angle);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MoveRotation_Angle_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(646)]
	[CachedScanResults(RefRangeStart = 1152221, RefRangeEnd = 1152867, XrefRangeStart = 1152221, XrefRangeEnd = 1152867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Rigidbody2D()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Rigidbody2D>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259029, XrefRangeEnd = 1259031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void get_position_Injected(System.IntPtr _unity_self, out Vector2 ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_position_Injected_Private_Static_Void_IntPtr_byref_Vector2_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259031, XrefRangeEnd = 1259033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_position_Injected(System.IntPtr _unity_self, [In] ref Vector2 value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_position_Injected_Private_Static_Void_IntPtr_byref_Vector2_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259033, XrefRangeEnd = 1259035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float get_rotation_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_rotation_Injected_Private_Static_Single_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259035, XrefRangeEnd = 1259037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_rotation_Injected(System.IntPtr _unity_self, float value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_rotation_Injected_Private_Static_Void_IntPtr_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259037, XrefRangeEnd = 1259039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void MovePosition_Injected(System.IntPtr _unity_self, [In] ref Vector2 position)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref position);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MovePosition_Injected_Private_Static_Void_IntPtr_byref_Vector2_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259039, XrefRangeEnd = 1259041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void MoveRotation_Angle_Injected(System.IntPtr _unity_self, float angle)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &angle;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MoveRotation_Angle_Injected_Private_Static_Void_IntPtr_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259041, XrefRangeEnd = 1259043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void get_linearVelocity_Injected(System.IntPtr _unity_self, out Vector2 ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_linearVelocity_Injected_Private_Static_Void_IntPtr_byref_Vector2_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259043, XrefRangeEnd = 1259045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_linearVelocity_Injected(System.IntPtr _unity_self, [In] ref Vector2 value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_linearVelocity_Injected_Private_Static_Void_IntPtr_byref_Vector2_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259045, XrefRangeEnd = 1259047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float get_gravityScale_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_gravityScale_Injected_Private_Static_Single_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259047, XrefRangeEnd = 1259049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_gravityScale_Injected(System.IntPtr _unity_self, float value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_gravityScale_Injected_Private_Static_Void_IntPtr_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259049, XrefRangeEnd = 1259051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_bodyType_Injected(System.IntPtr _unity_self, RigidbodyType2D value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(RigidbodyType2D**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_bodyType_Injected_Private_Static_Void_IntPtr_RigidbodyType2D_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public Rigidbody2D(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public void SetRotation(float angle)
	{
		SetRotation_Angle(angle);
	}

	public void SetRotation_Angle(float angle)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		SetRotation_Angle_Injected(intPtr, angle);
	}

	public void SetRotation(Quaternion rotation)
	{
		SetRotation_Quaternion(rotation);
	}

	public void SetRotation_Quaternion(Quaternion rotation)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		SetRotation_Quaternion_Injected(intPtr, ref rotation);
	}

	public void MoveRotation(Quaternion rotation)
	{
		MoveRotation_Quaternion(rotation);
	}

	public void MoveRotation_Quaternion(Quaternion rotation)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		MoveRotation_Quaternion_Injected(intPtr, ref rotation);
	}

	public void MovePositionAndRotation(Vector2 position, float angle)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		MovePositionAndRotation_Injected(intPtr, ref position, angle);
	}

	public void MovePositionAndRotation(Vector2 position, Quaternion rotation)
	{
		MovePositionAndRotation_Quaternion(position, rotation);
	}

	public void MovePositionAndRotation_Quaternion(Vector2 position, Quaternion rotation)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		MovePositionAndRotation_Quaternion_Injected(intPtr, ref position, ref rotation);
	}

	public void SetDragBehaviour(bool dragged)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		SetDragBehaviour_Injected(intPtr, dragged);
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

	public bool IsAwake()
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return IsAwake_Injected(intPtr);
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

	public void WakeUp()
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		WakeUp_Injected(intPtr);
	}

	public int GetAttachedColliderCount_Internal(bool findTriggers)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return GetAttachedColliderCount_Internal_Injected(intPtr, findTriggers);
	}

	public bool IsTouching(Collider2D collider)
	{
		if ((object)collider == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(collider, "collider");
		}
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		System.IntPtr intPtr2 = MarshalledUnityObject.MarshalNotNull(collider);
		if (intPtr2 == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(collider, "collider");
		}
		return IsTouching_Injected(intPtr, intPtr2);
	}

	public bool IsTouching(Collider2D collider, ContactFilter2D contactFilter)
	{
		return IsTouching_OtherColliderWithFilter_Internal(collider, contactFilter);
	}

	public bool IsTouching_OtherColliderWithFilter_Internal(Collider2D collider, ContactFilter2D contactFilter)
	{
		if ((object)collider == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(collider, "collider");
		}
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		System.IntPtr intPtr2 = MarshalledUnityObject.MarshalNotNull(collider);
		if (intPtr2 == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(collider, "collider");
		}
		return IsTouching_OtherColliderWithFilter_Internal_Injected(intPtr, intPtr2, ref contactFilter);
	}

	public bool IsTouching(ContactFilter2D contactFilter)
	{
		return IsTouching_AnyColliderWithFilter_Internal(contactFilter);
	}

	public bool IsTouching_AnyColliderWithFilter_Internal(ContactFilter2D contactFilter)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return IsTouching_AnyColliderWithFilter_Internal_Injected(intPtr, ref contactFilter);
	}

	public bool IsTouchingLayers()
	{
		return IsTouchingLayers(-1);
	}

	public bool IsTouchingLayers([Optional] int layerMask)
	{
		ContactFilter2D contactFilter = default(ContactFilter2D);
		contactFilter.SetLayerMask(layerMask);
		contactFilter.useTriggers = Physics2D.queriesHitTriggers;
		return IsTouching(contactFilter);
	}

	public bool OverlapPoint(Vector2 point)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return OverlapPoint_Injected(intPtr, ref point);
	}

	public Vector2 ClosestPoint(Vector2 position)
	{
		return Physics2D.ClosestPoint(position, this);
	}

	public void AddForce(Vector2 force)
	{
		AddForce_Internal(force, ForceMode2D.Force);
	}

	public void AddForce(Vector2 force, [Optional] ForceMode2D mode)
	{
		AddForce_Internal(force, mode);
	}

	public void AddForceX(float force, [Optional] ForceMode2D mode)
	{
		AddForce_Internal(new Vector2(force, 0f), mode);
	}

	public void AddForceY(float force, [Optional] ForceMode2D mode)
	{
		AddForce_Internal(new Vector2(0f, force), mode);
	}

	public void AddForce_Internal(Vector2 force, ForceMode2D mode)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		AddForce_Internal_Injected(intPtr, ref force, mode);
	}

	public void AddRelativeForce(Vector2 relativeForce)
	{
		AddRelativeForce_Internal(relativeForce, ForceMode2D.Force);
	}

	public void AddRelativeForce(Vector2 relativeForce, [Optional] ForceMode2D mode)
	{
		AddRelativeForce_Internal(relativeForce, mode);
	}

	public void AddRelativeForceX(float force, [Optional] ForceMode2D mode)
	{
		AddRelativeForce_Internal(new Vector2(force, 0f), mode);
	}

	public void AddRelativeForceY(float force, [Optional] ForceMode2D mode)
	{
		AddRelativeForce_Internal(new Vector2(0f, force), mode);
	}

	public void AddRelativeForce_Internal(Vector2 relativeForce, ForceMode2D mode)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		AddRelativeForce_Internal_Injected(intPtr, ref relativeForce, mode);
	}

	public void AddForceAtPosition(Vector2 force, Vector2 position)
	{
		AddForceAtPosition(force, position, ForceMode2D.Force);
	}

	public void AddForceAtPosition(Vector2 force, Vector2 position, ForceMode2D mode)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		AddForceAtPosition_Injected(intPtr, ref force, ref position, mode);
	}

	public void AddTorque(float torque)
	{
		AddTorque(torque, ForceMode2D.Force);
	}

	public void AddTorque(float torque, ForceMode2D mode)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		AddTorque_Injected(intPtr, torque, mode);
	}

	public Vector2 GetPoint(Vector2 point)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		GetPoint_Injected(intPtr, ref point, out var ret);
		return ret;
	}

	public Vector2 GetRelativePoint(Vector2 relativePoint)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		GetRelativePoint_Injected(intPtr, ref relativePoint, out var ret);
		return ret;
	}

	public Vector2 GetVector(Vector2 vector)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		GetVector_Injected(intPtr, ref vector, out var ret);
		return ret;
	}

	public Vector2 GetRelativeVector(Vector2 relativeVector)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		GetRelativeVector_Injected(intPtr, ref relativeVector, out var ret);
		return ret;
	}

	public Vector2 GetPointVelocity(Vector2 point)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		GetPointVelocity_Injected(intPtr, ref point, out var ret);
		return ret;
	}

	public Vector2 GetRelativePointVelocity(Vector2 relativePoint)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		GetRelativePointVelocity_Injected(intPtr, ref relativePoint, out var ret);
		return ret;
	}

	public int GetContacts(Il2CppStructArray<ContactPoint2D> contacts)
	{
		return Physics2D.GetContacts(this, default(ContactFilter2D).NoFilter(), contacts);
	}

	public int GetContacts(List<ContactPoint2D> contacts)
	{
		return Physics2D.GetContacts(this, default(ContactFilter2D).NoFilter(), contacts);
	}

	public int GetContacts(ContactFilter2D contactFilter, Il2CppStructArray<ContactPoint2D> contacts)
	{
		return Physics2D.GetContacts(this, contactFilter, contacts);
	}

	public int GetContacts(ContactFilter2D contactFilter, List<ContactPoint2D> contacts)
	{
		return Physics2D.GetContacts(this, contactFilter, contacts);
	}

	public int GetContacts(Il2CppReferenceArray<Collider2D> colliders)
	{
		return Physics2D.GetContacts(this, default(ContactFilter2D).NoFilter(), colliders);
	}

	public int GetContacts(List<Collider2D> colliders)
	{
		return Physics2D.GetContacts(this, default(ContactFilter2D).NoFilter(), colliders);
	}

	public int GetContacts(ContactFilter2D contactFilter, Il2CppReferenceArray<Collider2D> colliders)
	{
		return Physics2D.GetContacts(this, contactFilter, colliders);
	}

	public int GetContacts(ContactFilter2D contactFilter, List<Collider2D> colliders)
	{
		return Physics2D.GetContacts(this, contactFilter, colliders);
	}

	public int GetAttachedColliders([Out] Il2CppReferenceArray<Collider2D> results)
	{
		return GetAttachedCollidersArray_Internal(results, findTriggers: true);
	}

	public int GetAttachedColliders(List<Collider2D> results)
	{
		return GetAttachedCollidersList_Internal(results, findTriggers: true);
	}

	public int GetAttachedColliders([Out] Il2CppReferenceArray<Collider2D> results, [Optional] bool findTriggers)
	{
		return GetAttachedCollidersArray_Internal(results, findTriggers);
	}

	public int GetAttachedColliders(List<Collider2D> results, [Optional] bool findTriggers)
	{
		return GetAttachedCollidersList_Internal(results, findTriggers);
	}

	public int GetShapes(PhysicsShapeGroup2D physicsShapeGroup)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public int Cast(Vector2 direction, Il2CppStructArray<RaycastHit2D> results)
	{
		return CastArray_Internal(direction, float.PositiveInfinity, checkIgnoreColliders: false, results);
	}

	public int Cast(Vector2 direction, Il2CppStructArray<RaycastHit2D> results, float distance)
	{
		return CastArray_Internal(direction, distance, checkIgnoreColliders: false, results);
	}

	public int Cast(Vector2 direction, List<RaycastHit2D> results, [Optional] float distance)
	{
		return CastList_Internal(direction, distance, checkIgnoreColliders: false, results);
	}

	public int Cast(Vector2 direction, ContactFilter2D contactFilter, Il2CppStructArray<RaycastHit2D> results)
	{
		return CastFilteredArray_Internal(direction, float.PositiveInfinity, checkIgnoreColliders: false, contactFilter, results);
	}

	public int Cast(Vector2 direction, ContactFilter2D contactFilter, Il2CppStructArray<RaycastHit2D> results, [Optional] float distance)
	{
		return CastFilteredArray_Internal(direction, distance, checkIgnoreColliders: false, contactFilter, results);
	}

	public int Cast(Vector2 direction, ContactFilter2D contactFilter, List<RaycastHit2D> results, [Optional] float distance)
	{
		return CastFilteredList_Internal(direction, distance, checkIgnoreColliders: false, contactFilter, results);
	}

	public int Cast(Vector2 position, float angle, Vector2 direction, List<RaycastHit2D> results, [Optional] float distance)
	{
		return CastFrom_Internal(position, angle, direction, distance, checkIgnoreColliders: false, results);
	}

	public int Cast(Vector2 position, float angle, Vector2 direction, ContactFilter2D contactFilter, List<RaycastHit2D> results, [Optional] float distance)
	{
		return CastFromFiltered_Internal(position, angle, direction, distance, checkIgnoreColliders: false, contactFilter, results);
	}

	public int Overlap(ContactFilter2D contactFilter, [Out] Il2CppReferenceArray<Collider2D> results)
	{
		return OverlapArray_Internal(contactFilter, results);
	}

	public int Overlap(List<Collider2D> results)
	{
		return OverlapList_Internal(results);
	}

	public int Overlap(ContactFilter2D contactFilter, List<Collider2D> results)
	{
		return OverlapFilteredList_Internal(contactFilter, results);
	}

	public int Overlap(Vector2 position, float angle, List<Collider2D> results)
	{
		return OverlapFromList_Internal(position, angle, results);
	}

	public int Overlap(Vector2 position, float angle, ContactFilter2D contactFilter, List<Collider2D> results)
	{
		return OverlapFromFilteredList_Internal(position, angle, contactFilter, results);
	}

	public int GetAttachedCollidersArray_Internal(Il2CppReferenceArray<Collider2D> results, bool findTriggers)
	{
		if (results == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object)(object)results, "results");
		}
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return GetAttachedCollidersArray_Internal_Injected(intPtr, results, findTriggers);
	}

	public int GetAttachedCollidersList_Internal(List<Collider2D> results, bool findTriggers)
	{
		if (results == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(results, "results");
		}
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return GetAttachedCollidersList_Internal_Injected(intPtr, results, findTriggers);
	}

	public unsafe int CastArray_Internal(Vector2 direction, float distance, bool checkIgnoreColliders, Il2CppStructArray<RaycastHit2D> results)
	{
		//IL_002e: Expected O, but got Ref
		//IL_0035: Expected O, but got Ref
		//IL_0041: Expected O, but got Ref
		if (results == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object)(object)results, "results");
		}
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		Unsafe.SkipInit(out Il2CppSystem.Span<RaycastHit2D> span);
		((Il2CppSystem.Span<RaycastHit2D>)(&span))._002Ector((Il2CppArrayBase<RaycastHit2D>)(object)results);
		int result;
		fixed (RaycastHit2D* begin = &((Il2CppSystem.Span<RaycastHit2D>)(&span)).GetPinnableReference())
		{
			ManagedSpanWrapper results2 = new ManagedSpanWrapper(begin, ((Il2CppSystem.Span<RaycastHit2D>)(&span)).Length);
			result = CastArray_Internal_Injected(intPtr, ref direction, distance, checkIgnoreColliders, ref results2);
		}
		return result;
	}

	public int CastList_Internal(Vector2 direction, float distance, bool checkIgnoreColliders, List<RaycastHit2D> results)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public unsafe int CastFilteredArray_Internal(Vector2 direction, float distance, bool checkIgnoreColliders, ContactFilter2D contactFilter, Il2CppStructArray<RaycastHit2D> results)
	{
		//IL_0030: Expected O, but got Ref
		//IL_0037: Expected O, but got Ref
		//IL_0043: Expected O, but got Ref
		if (results == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object)(object)results, "results");
		}
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		Unsafe.SkipInit(out Il2CppSystem.Span<RaycastHit2D> span);
		((Il2CppSystem.Span<RaycastHit2D>)(&span))._002Ector((Il2CppArrayBase<RaycastHit2D>)(object)results);
		int result;
		fixed (RaycastHit2D* begin = &((Il2CppSystem.Span<RaycastHit2D>)(&span)).GetPinnableReference())
		{
			ManagedSpanWrapper results2 = new ManagedSpanWrapper(begin, ((Il2CppSystem.Span<RaycastHit2D>)(&span)).Length);
			result = CastFilteredArray_Internal_Injected(intPtr, ref direction, distance, checkIgnoreColliders, ref contactFilter, ref results2);
		}
		return result;
	}

	public int CastFilteredList_Internal(Vector2 direction, float distance, bool checkIgnoreColliders, ContactFilter2D contactFilter, List<RaycastHit2D> results)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public int CastFrom_Internal(Vector2 position, float angle, Vector2 direction, float distance, bool checkIgnoreColliders, List<RaycastHit2D> results)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public int CastFromFiltered_Internal(Vector2 position, float angle, Vector2 direction, float distance, bool checkIgnoreColliders, ContactFilter2D contactFilter, List<RaycastHit2D> results)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public int OverlapArray_Internal(ContactFilter2D contactFilter, Il2CppReferenceArray<Collider2D> results)
	{
		if (results == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object)(object)results, "results");
		}
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return OverlapArray_Internal_Injected(intPtr, ref contactFilter, results);
	}

	public int OverlapList_Internal(List<Collider2D> results)
	{
		if (results == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(results, "results");
		}
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return OverlapList_Internal_Injected(intPtr, results);
	}

	public int OverlapFilteredList_Internal(ContactFilter2D contactFilter, List<Collider2D> results)
	{
		if (results == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(results, "results");
		}
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return OverlapFilteredList_Internal_Injected(intPtr, ref contactFilter, results);
	}

	public int OverlapFromList_Internal(Vector2 position, float angle, List<Collider2D> results)
	{
		if (results == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(results, "results");
		}
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return OverlapFromList_Internal_Injected(intPtr, ref position, angle, results);
	}

	public int OverlapFromFilteredList_Internal(Vector2 position, float angle, ContactFilter2D contactFilter, List<Collider2D> results)
	{
		if (results == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(results, "results");
		}
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return OverlapFromFilteredList_Internal_Injected(intPtr, ref position, angle, ref contactFilter, results);
	}

	public int OverlapCollider(ContactFilter2D contactFilter, [Out] Il2CppReferenceArray<Collider2D> results)
	{
		return Overlap(contactFilter, results);
	}

	public int OverlapCollider(ContactFilter2D contactFilter, List<Collider2D> results)
	{
		return Overlap(contactFilter, results);
	}

	public static void SetRotation_Angle_Injected(System.IntPtr _unity_self, float angle)
	{
		SetRotation_Angle_InjectedDelegateField(_unity_self, angle);
	}

	public unsafe static void SetRotation_Quaternion_Injected(System.IntPtr _unity_self, [In] ref Quaternion rotation)
	{
		SetRotation_Quaternion_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref rotation));
	}

	public unsafe static void MoveRotation_Quaternion_Injected(System.IntPtr _unity_self, [In] ref Quaternion rotation)
	{
		MoveRotation_Quaternion_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref rotation));
	}

	public unsafe static void MovePositionAndRotation_Injected(System.IntPtr _unity_self, [In] ref Vector2 position, float angle)
	{
		MovePositionAndRotation_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref position), angle);
	}

	public unsafe static void MovePositionAndRotation_Quaternion_Injected(System.IntPtr _unity_self, [In] ref Vector2 position, [In] ref Quaternion rotation)
	{
		MovePositionAndRotation_Quaternion_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref position), (nint)Unsafe.AsPointer(ref rotation));
	}

	public static float get_linearVelocityX_Injected(System.IntPtr _unity_self)
	{
		return get_linearVelocityX_InjectedDelegateField(_unity_self);
	}

	public static void set_linearVelocityX_Injected(System.IntPtr _unity_self, float value)
	{
		set_linearVelocityX_InjectedDelegateField(_unity_self, value);
	}

	public static float get_linearVelocityY_Injected(System.IntPtr _unity_self)
	{
		return get_linearVelocityY_InjectedDelegateField(_unity_self);
	}

	public static void set_linearVelocityY_Injected(System.IntPtr _unity_self, float value)
	{
		set_linearVelocityY_InjectedDelegateField(_unity_self, value);
	}

	public static float get_angularVelocity_Injected(System.IntPtr _unity_self)
	{
		return get_angularVelocity_InjectedDelegateField(_unity_self);
	}

	public static void set_angularVelocity_Injected(System.IntPtr _unity_self, float value)
	{
		set_angularVelocity_InjectedDelegateField(_unity_self, value);
	}

	public static bool get_useAutoMass_Injected(System.IntPtr _unity_self)
	{
		return get_useAutoMass_InjectedDelegateField(_unity_self);
	}

	public static void set_useAutoMass_Injected(System.IntPtr _unity_self, bool value)
	{
		set_useAutoMass_InjectedDelegateField(_unity_self, value);
	}

	public static float get_mass_Injected(System.IntPtr _unity_self)
	{
		return get_mass_InjectedDelegateField(_unity_self);
	}

	public static void set_mass_Injected(System.IntPtr _unity_self, float value)
	{
		set_mass_InjectedDelegateField(_unity_self, value);
	}

	public static System.IntPtr get_sharedMaterial_Injected(System.IntPtr _unity_self)
	{
		return get_sharedMaterial_InjectedDelegateField(_unity_self);
	}

	public static void set_sharedMaterial_Injected(System.IntPtr _unity_self, System.IntPtr value)
	{
		set_sharedMaterial_InjectedDelegateField(_unity_self, value);
	}

	public unsafe static void get_centerOfMass_Injected(System.IntPtr _unity_self, out Vector2 ret)
	{
		get_centerOfMass_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void set_centerOfMass_Injected(System.IntPtr _unity_self, [In] ref Vector2 value)
	{
		set_centerOfMass_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref value));
	}

	public unsafe static void get_worldCenterOfMass_Injected(System.IntPtr _unity_self, out Vector2 ret)
	{
		get_worldCenterOfMass_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public static float get_inertia_Injected(System.IntPtr _unity_self)
	{
		return get_inertia_InjectedDelegateField(_unity_self);
	}

	public static void set_inertia_Injected(System.IntPtr _unity_self, float value)
	{
		set_inertia_InjectedDelegateField(_unity_self, value);
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

	public static RigidbodyType2D get_bodyType_Injected(System.IntPtr _unity_self)
	{
		return get_bodyType_InjectedDelegateField(_unity_self);
	}

	public static void SetDragBehaviour_Injected(System.IntPtr _unity_self, bool dragged)
	{
		SetDragBehaviour_InjectedDelegateField(_unity_self, dragged);
	}

	public static bool get_useFullKinematicContacts_Injected(System.IntPtr _unity_self)
	{
		return get_useFullKinematicContacts_InjectedDelegateField(_unity_self);
	}

	public static void set_useFullKinematicContacts_Injected(System.IntPtr _unity_self, bool value)
	{
		set_useFullKinematicContacts_InjectedDelegateField(_unity_self, value);
	}

	public static bool get_freezeRotation_Injected(System.IntPtr _unity_self)
	{
		return get_freezeRotation_InjectedDelegateField(_unity_self);
	}

	public static void set_freezeRotation_Injected(System.IntPtr _unity_self, bool value)
	{
		set_freezeRotation_InjectedDelegateField(_unity_self, value);
	}

	public static RigidbodyConstraints2D get_constraints_Injected(System.IntPtr _unity_self)
	{
		return get_constraints_InjectedDelegateField(_unity_self);
	}

	public static void set_constraints_Injected(System.IntPtr _unity_self, RigidbodyConstraints2D value)
	{
		set_constraints_InjectedDelegateField(_unity_self, value);
	}

	public static bool IsSleeping_Injected(System.IntPtr _unity_self)
	{
		return IsSleeping_InjectedDelegateField(_unity_self);
	}

	public static bool IsAwake_Injected(System.IntPtr _unity_self)
	{
		return IsAwake_InjectedDelegateField(_unity_self);
	}

	public static void Sleep_Injected(System.IntPtr _unity_self)
	{
		Sleep_InjectedDelegateField(_unity_self);
	}

	public static void WakeUp_Injected(System.IntPtr _unity_self)
	{
		WakeUp_InjectedDelegateField(_unity_self);
	}

	public static bool get_simulated_Injected(System.IntPtr _unity_self)
	{
		return get_simulated_InjectedDelegateField(_unity_self);
	}

	public static void set_simulated_Injected(System.IntPtr _unity_self, bool value)
	{
		set_simulated_InjectedDelegateField(_unity_self, value);
	}

	public static RigidbodyInterpolation2D get_interpolation_Injected(System.IntPtr _unity_self)
	{
		return get_interpolation_InjectedDelegateField(_unity_self);
	}

	public static void set_interpolation_Injected(System.IntPtr _unity_self, RigidbodyInterpolation2D value)
	{
		set_interpolation_InjectedDelegateField(_unity_self, value);
	}

	public static RigidbodySleepMode2D get_sleepMode_Injected(System.IntPtr _unity_self)
	{
		return get_sleepMode_InjectedDelegateField(_unity_self);
	}

	public static void set_sleepMode_Injected(System.IntPtr _unity_self, RigidbodySleepMode2D value)
	{
		set_sleepMode_InjectedDelegateField(_unity_self, value);
	}

	public static CollisionDetectionMode2D get_collisionDetectionMode_Injected(System.IntPtr _unity_self)
	{
		return get_collisionDetectionMode_InjectedDelegateField(_unity_self);
	}

	public static void set_collisionDetectionMode_Injected(System.IntPtr _unity_self, CollisionDetectionMode2D value)
	{
		set_collisionDetectionMode_InjectedDelegateField(_unity_self, value);
	}

	public static int GetAttachedColliderCount_Internal_Injected(System.IntPtr _unity_self, bool findTriggers)
	{
		return GetAttachedColliderCount_Internal_InjectedDelegateField(_unity_self, findTriggers);
	}

	public unsafe static void get_totalForce_Injected(System.IntPtr _unity_self, out Vector2 ret)
	{
		get_totalForce_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void set_totalForce_Injected(System.IntPtr _unity_self, [In] ref Vector2 value)
	{
		set_totalForce_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref value));
	}

	public static float get_totalTorque_Injected(System.IntPtr _unity_self)
	{
		return get_totalTorque_InjectedDelegateField(_unity_self);
	}

	public static void set_totalTorque_Injected(System.IntPtr _unity_self, float value)
	{
		set_totalTorque_InjectedDelegateField(_unity_self, value);
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

	public unsafe static void get_localToWorldMatrix_Injected(System.IntPtr _unity_self, out Matrix4x4 ret)
	{
		get_localToWorldMatrix_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public static bool IsTouching_Injected(System.IntPtr _unity_self, System.IntPtr collider)
	{
		return IsTouching_InjectedDelegateField(_unity_self, collider);
	}

	public unsafe static bool IsTouching_OtherColliderWithFilter_Internal_Injected(System.IntPtr _unity_self, System.IntPtr collider, [In] ref ContactFilter2D contactFilter)
	{
		return IsTouching_OtherColliderWithFilter_Internal_InjectedDelegateField(_unity_self, collider, (nint)Unsafe.AsPointer(ref contactFilter));
	}

	public unsafe static bool IsTouching_AnyColliderWithFilter_Internal_Injected(System.IntPtr _unity_self, [In] ref ContactFilter2D contactFilter)
	{
		return IsTouching_AnyColliderWithFilter_Internal_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref contactFilter));
	}

	public unsafe static bool OverlapPoint_Injected(System.IntPtr _unity_self, [In] ref Vector2 point)
	{
		return OverlapPoint_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref point));
	}

	public unsafe static void AddForce_Internal_Injected(System.IntPtr _unity_self, [In] ref Vector2 force, ForceMode2D mode)
	{
		AddForce_Internal_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref force), mode);
	}

	public unsafe static void AddRelativeForce_Internal_Injected(System.IntPtr _unity_self, [In] ref Vector2 relativeForce, ForceMode2D mode)
	{
		AddRelativeForce_Internal_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref relativeForce), mode);
	}

	public unsafe static void AddForceAtPosition_Injected(System.IntPtr _unity_self, [In] ref Vector2 force, [In] ref Vector2 position, ForceMode2D mode)
	{
		AddForceAtPosition_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref force), (nint)Unsafe.AsPointer(ref position), mode);
	}

	public static void AddTorque_Injected(System.IntPtr _unity_self, float torque, ForceMode2D mode)
	{
		AddTorque_InjectedDelegateField(_unity_self, torque, mode);
	}

	public unsafe static void GetPoint_Injected(System.IntPtr _unity_self, [In] ref Vector2 point, out Vector2 ret)
	{
		GetPoint_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref point), (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void GetRelativePoint_Injected(System.IntPtr _unity_self, [In] ref Vector2 relativePoint, out Vector2 ret)
	{
		GetRelativePoint_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref relativePoint), (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void GetVector_Injected(System.IntPtr _unity_self, [In] ref Vector2 vector, out Vector2 ret)
	{
		GetVector_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref vector), (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void GetRelativeVector_Injected(System.IntPtr _unity_self, [In] ref Vector2 relativeVector, out Vector2 ret)
	{
		GetRelativeVector_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref relativeVector), (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void GetPointVelocity_Injected(System.IntPtr _unity_self, [In] ref Vector2 point, out Vector2 ret)
	{
		GetPointVelocity_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref point), (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void GetRelativePointVelocity_Injected(System.IntPtr _unity_self, [In] ref Vector2 relativePoint, out Vector2 ret)
	{
		GetRelativePointVelocity_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref relativePoint), (nint)Unsafe.AsPointer(ref ret));
	}

	public static int GetAttachedCollidersArray_Internal_Injected(System.IntPtr _unity_self, Il2CppReferenceArray<Collider2D> results, bool findTriggers)
	{
		return GetAttachedCollidersArray_Internal_InjectedDelegateField(_unity_self, IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)results), findTriggers);
	}

	public static int GetAttachedCollidersList_Internal_Injected(System.IntPtr _unity_self, List<Collider2D> results, bool findTriggers)
	{
		return GetAttachedCollidersList_Internal_InjectedDelegateField(_unity_self, IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)results), findTriggers);
	}

	public unsafe static int CastArray_Internal_Injected(System.IntPtr _unity_self, [In] ref Vector2 direction, float distance, bool checkIgnoreColliders, ref ManagedSpanWrapper results)
	{
		return CastArray_Internal_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref direction), distance, checkIgnoreColliders, (nint)Unsafe.AsPointer(ref results));
	}

	public unsafe static int CastList_Internal_Injected(System.IntPtr _unity_self, [In] ref Vector2 direction, float distance, bool checkIgnoreColliders, ref BlittableListWrapper results)
	{
		return CastList_Internal_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref direction), distance, checkIgnoreColliders, (nint)Unsafe.AsPointer(ref results));
	}

	public unsafe static int CastFilteredArray_Internal_Injected(System.IntPtr _unity_self, [In] ref Vector2 direction, float distance, bool checkIgnoreColliders, [In] ref ContactFilter2D contactFilter, ref ManagedSpanWrapper results)
	{
		return CastFilteredArray_Internal_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref direction), distance, checkIgnoreColliders, (nint)Unsafe.AsPointer(ref contactFilter), (nint)Unsafe.AsPointer(ref results));
	}

	public unsafe static int CastFilteredList_Internal_Injected(System.IntPtr _unity_self, [In] ref Vector2 direction, float distance, bool checkIgnoreColliders, [In] ref ContactFilter2D contactFilter, ref BlittableListWrapper results)
	{
		return CastFilteredList_Internal_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref direction), distance, checkIgnoreColliders, (nint)Unsafe.AsPointer(ref contactFilter), (nint)Unsafe.AsPointer(ref results));
	}

	public unsafe static int CastFrom_Internal_Injected(System.IntPtr _unity_self, [In] ref Vector2 position, float angle, [In] ref Vector2 direction, float distance, bool checkIgnoreColliders, ref BlittableListWrapper results)
	{
		return CastFrom_Internal_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref position), angle, (nint)Unsafe.AsPointer(ref direction), distance, checkIgnoreColliders, (nint)Unsafe.AsPointer(ref results));
	}

	public unsafe static int CastFromFiltered_Internal_Injected(System.IntPtr _unity_self, [In] ref Vector2 position, float angle, [In] ref Vector2 direction, float distance, bool checkIgnoreColliders, [In] ref ContactFilter2D contactFilter, ref BlittableListWrapper results)
	{
		return CastFromFiltered_Internal_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref position), angle, (nint)Unsafe.AsPointer(ref direction), distance, checkIgnoreColliders, (nint)Unsafe.AsPointer(ref contactFilter), (nint)Unsafe.AsPointer(ref results));
	}

	public unsafe static int OverlapArray_Internal_Injected(System.IntPtr _unity_self, [In] ref ContactFilter2D contactFilter, Il2CppReferenceArray<Collider2D> results)
	{
		return OverlapArray_Internal_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref contactFilter), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)results));
	}

	public static int OverlapList_Internal_Injected(System.IntPtr _unity_self, List<Collider2D> results)
	{
		return OverlapList_Internal_InjectedDelegateField(_unity_self, IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)results));
	}

	public unsafe static int OverlapFilteredList_Internal_Injected(System.IntPtr _unity_self, [In] ref ContactFilter2D contactFilter, List<Collider2D> results)
	{
		return OverlapFilteredList_Internal_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref contactFilter), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)results));
	}

	public unsafe static int OverlapFromList_Internal_Injected(System.IntPtr _unity_self, [In] ref Vector2 position, float angle, List<Collider2D> results)
	{
		return OverlapFromList_Internal_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref position), angle, IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)results));
	}

	public unsafe static int OverlapFromFilteredList_Internal_Injected(System.IntPtr _unity_self, [In] ref Vector2 position, float angle, [In] ref ContactFilter2D contactFilter, List<Collider2D> results)
	{
		return OverlapFromFilteredList_Internal_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref position), angle, (nint)Unsafe.AsPointer(ref contactFilter), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)results));
	}
}
