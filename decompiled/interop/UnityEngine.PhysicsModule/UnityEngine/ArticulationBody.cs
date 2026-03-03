using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Bindings;

namespace UnityEngine;

public class ArticulationBody : Behaviour
{
	private delegate ArticulationJointType get_jointType_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_jointType_InjectedDelegate(IntPtr _unity_self, ArticulationJointType value);

	private delegate void get_anchorPosition_InjectedDelegate(IntPtr _unity_self, [Out] IntPtr ret);

	private delegate void set_anchorPosition_InjectedDelegate(IntPtr _unity_self, [In] IntPtr value);

	private delegate void get_parentAnchorPosition_InjectedDelegate(IntPtr _unity_self, [Out] IntPtr ret);

	private delegate void set_parentAnchorPosition_InjectedDelegate(IntPtr _unity_self, [In] IntPtr value);

	private delegate void get_anchorRotation_InjectedDelegate(IntPtr _unity_self, [Out] IntPtr ret);

	private delegate void set_anchorRotation_InjectedDelegate(IntPtr _unity_self, [In] IntPtr value);

	private delegate void get_parentAnchorRotation_InjectedDelegate(IntPtr _unity_self, [Out] IntPtr ret);

	private delegate void set_parentAnchorRotation_InjectedDelegate(IntPtr _unity_self, [In] IntPtr value);

	private delegate bool get_isRoot_InjectedDelegate(IntPtr _unity_self);

	private delegate bool get_matchAnchors_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_matchAnchors_InjectedDelegate(IntPtr _unity_self, bool value);

	private delegate ArticulationDofLock get_linearLockX_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_linearLockX_InjectedDelegate(IntPtr _unity_self, ArticulationDofLock value);

	private delegate ArticulationDofLock get_linearLockY_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_linearLockY_InjectedDelegate(IntPtr _unity_self, ArticulationDofLock value);

	private delegate ArticulationDofLock get_linearLockZ_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_linearLockZ_InjectedDelegate(IntPtr _unity_self, ArticulationDofLock value);

	private delegate ArticulationDofLock get_swingYLock_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_swingYLock_InjectedDelegate(IntPtr _unity_self, ArticulationDofLock value);

	private delegate ArticulationDofLock get_swingZLock_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_swingZLock_InjectedDelegate(IntPtr _unity_self, ArticulationDofLock value);

	private delegate ArticulationDofLock get_twistLock_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_twistLock_InjectedDelegate(IntPtr _unity_self, ArticulationDofLock value);

	private delegate bool get_immovable_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_immovable_InjectedDelegate(IntPtr _unity_self, bool value);

	private delegate bool get_useGravity_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_useGravity_InjectedDelegate(IntPtr _unity_self, bool value);

	private delegate float get_linearDamping_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_linearDamping_InjectedDelegate(IntPtr _unity_self, float value);

	private delegate float get_angularDamping_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_angularDamping_InjectedDelegate(IntPtr _unity_self, float value);

	private delegate float get_jointFriction_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_jointFriction_InjectedDelegate(IntPtr _unity_self, float value);

	private delegate void get_excludeLayers_InjectedDelegate(IntPtr _unity_self, [Out] IntPtr ret);

	private delegate void set_excludeLayers_InjectedDelegate(IntPtr _unity_self, [In] IntPtr value);

	private delegate void get_includeLayers_InjectedDelegate(IntPtr _unity_self, [Out] IntPtr ret);

	private delegate void set_includeLayers_InjectedDelegate(IntPtr _unity_self, [In] IntPtr value);

	private delegate void GetAccumulatedForce_InjectedDelegate(IntPtr _unity_self, float step, [Out] IntPtr ret);

	private delegate void GetAccumulatedTorque_InjectedDelegate(IntPtr _unity_self, float step, [Out] IntPtr ret);

	private delegate void AddForce_InjectedDelegate(IntPtr _unity_self, [In] IntPtr force, ForceMode mode);

	private delegate void AddRelativeForce_InjectedDelegate(IntPtr _unity_self, [In] IntPtr force, ForceMode mode);

	private delegate void AddTorque_InjectedDelegate(IntPtr _unity_self, [In] IntPtr torque, ForceMode mode);

	private delegate void AddRelativeTorque_InjectedDelegate(IntPtr _unity_self, [In] IntPtr torque, ForceMode mode);

	private delegate void AddForceAtPosition_InjectedDelegate(IntPtr _unity_self, [In] IntPtr force, [In] IntPtr position, ForceMode mode);

	private delegate void get_linearVelocity_InjectedDelegate(IntPtr _unity_self, [Out] IntPtr ret);

	private delegate void set_linearVelocity_InjectedDelegate(IntPtr _unity_self, [In] IntPtr value);

	private delegate void get_angularVelocity_InjectedDelegate(IntPtr _unity_self, [Out] IntPtr ret);

	private delegate void set_angularVelocity_InjectedDelegate(IntPtr _unity_self, [In] IntPtr value);

	private delegate float get_mass_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_mass_InjectedDelegate(IntPtr _unity_self, float value);

	private delegate bool get_automaticCenterOfMass_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_automaticCenterOfMass_InjectedDelegate(IntPtr _unity_self, bool value);

	private delegate void get_centerOfMass_InjectedDelegate(IntPtr _unity_self, [Out] IntPtr ret);

	private delegate void set_centerOfMass_InjectedDelegate(IntPtr _unity_self, [In] IntPtr value);

	private delegate void get_worldCenterOfMass_InjectedDelegate(IntPtr _unity_self, [Out] IntPtr ret);

	private delegate bool get_automaticInertiaTensor_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_automaticInertiaTensor_InjectedDelegate(IntPtr _unity_self, bool value);

	private delegate void get_inertiaTensor_InjectedDelegate(IntPtr _unity_self, [Out] IntPtr ret);

	private delegate void set_inertiaTensor_InjectedDelegate(IntPtr _unity_self, [In] IntPtr value);

	private delegate void get_worldInertiaTensorMatrix_InjectedDelegate(IntPtr _unity_self, [Out] IntPtr ret);

	private delegate void get_inertiaTensorRotation_InjectedDelegate(IntPtr _unity_self, [Out] IntPtr ret);

	private delegate void set_inertiaTensorRotation_InjectedDelegate(IntPtr _unity_self, [In] IntPtr value);

	private delegate void ResetCenterOfMass_InjectedDelegate(IntPtr _unity_self);

	private delegate void ResetInertiaTensor_InjectedDelegate(IntPtr _unity_self);

	private delegate void Sleep_InjectedDelegate(IntPtr _unity_self);

	private delegate bool IsSleeping_InjectedDelegate(IntPtr _unity_self);

	private delegate void WakeUp_InjectedDelegate(IntPtr _unity_self);

	private delegate float get_sleepThreshold_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_sleepThreshold_InjectedDelegate(IntPtr _unity_self, float value);

	private delegate int get_solverIterations_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_solverIterations_InjectedDelegate(IntPtr _unity_self, int value);

	private delegate int get_solverVelocityIterations_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_solverVelocityIterations_InjectedDelegate(IntPtr _unity_self, int value);

	private delegate float get_maxAngularVelocity_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_maxAngularVelocity_InjectedDelegate(IntPtr _unity_self, float value);

	private delegate float get_maxLinearVelocity_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_maxLinearVelocity_InjectedDelegate(IntPtr _unity_self, float value);

	private delegate float get_maxJointVelocity_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_maxJointVelocity_InjectedDelegate(IntPtr _unity_self, float value);

	private delegate float get_maxDepenetrationVelocity_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_maxDepenetrationVelocity_InjectedDelegate(IntPtr _unity_self, float value);

	private delegate int get_dofCount_InjectedDelegate(IntPtr _unity_self);

	private delegate int get_index_InjectedDelegate(IntPtr _unity_self);

	private delegate void TeleportRoot_InjectedDelegate(IntPtr _unity_self, [In] IntPtr position, [In] IntPtr rotation);

	private delegate void GetClosestPoint_InjectedDelegate(IntPtr _unity_self, [In] IntPtr point, [Out] IntPtr ret);

	private delegate void GetRelativePointVelocity_InjectedDelegate(IntPtr _unity_self, [In] IntPtr relativePoint, [Out] IntPtr ret);

	private delegate void GetPointVelocity_InjectedDelegate(IntPtr _unity_self, [In] IntPtr worldPoint, [Out] IntPtr ret);

	private delegate int GetJointPositions_InjectedDelegate(IntPtr _unity_self, IntPtr positions);

	private delegate void SetJointPositions_InjectedDelegate(IntPtr _unity_self, IntPtr positions);

	private delegate int GetJointVelocities_InjectedDelegate(IntPtr _unity_self, IntPtr velocities);

	private delegate void SetJointVelocities_InjectedDelegate(IntPtr _unity_self, IntPtr velocities);

	private delegate int GetJointAccelerations_InjectedDelegate(IntPtr _unity_self, IntPtr accelerations);

	private delegate int GetJointForces_InjectedDelegate(IntPtr _unity_self, IntPtr forces);

	private delegate void SetJointForces_InjectedDelegate(IntPtr _unity_self, IntPtr forces);

	private delegate int GetDriveForces_InjectedDelegate(IntPtr _unity_self, IntPtr forces);

	private delegate int GetJointGravityForces_InjectedDelegate(IntPtr _unity_self, IntPtr forces);

	private delegate int GetJointCoriolisCentrifugalForces_InjectedDelegate(IntPtr _unity_self, IntPtr forces);

	private delegate int GetJointExternalForces_InjectedDelegate(IntPtr _unity_self, IntPtr forces, float step);

	private delegate int GetDriveTargets_InjectedDelegate(IntPtr _unity_self, IntPtr targets);

	private delegate void SetDriveTargets_InjectedDelegate(IntPtr _unity_self, IntPtr targets);

	private delegate int GetDriveTargetVelocities_InjectedDelegate(IntPtr _unity_self, IntPtr targetVelocities);

	private delegate void SetDriveTargetVelocities_InjectedDelegate(IntPtr _unity_self, IntPtr targetVelocities);

	private delegate int GetDofStartIndices_InjectedDelegate(IntPtr _unity_self, IntPtr dofStartIndices);

	private delegate void SetDriveTarget_InjectedDelegate(IntPtr _unity_self, ArticulationDriveAxis axis, float value);

	private delegate void SetDriveTargetVelocity_InjectedDelegate(IntPtr _unity_self, ArticulationDriveAxis axis, float value);

	private delegate void SetDriveLimits_InjectedDelegate(IntPtr _unity_self, ArticulationDriveAxis axis, float lower, float upper);

	private delegate void SetDriveStiffness_InjectedDelegate(IntPtr _unity_self, ArticulationDriveAxis axis, float value);

	private delegate void SetDriveDamping_InjectedDelegate(IntPtr _unity_self, ArticulationDriveAxis axis, float value);

	private delegate void SetDriveForceLimit_InjectedDelegate(IntPtr _unity_self, ArticulationDriveAxis axis, float value);

	private delegate CollisionDetectionMode get_collisionDetectionMode_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_collisionDetectionMode_InjectedDelegate(IntPtr _unity_self, CollisionDetectionMode value);

	private delegate void PublishTransform_InjectedDelegate(IntPtr _unity_self);

	private delegate void SetJointAccelerations_InjectedDelegate(IntPtr _unity_self, IntPtr accelerations);

	private static readonly get_jointType_InjectedDelegate get_jointType_InjectedDelegateField = IL2CPP.ResolveICall<get_jointType_InjectedDelegate>("UnityEngine.ArticulationBody::get_jointType_Injected");

	private static readonly set_jointType_InjectedDelegate set_jointType_InjectedDelegateField = IL2CPP.ResolveICall<set_jointType_InjectedDelegate>("UnityEngine.ArticulationBody::set_jointType_Injected");

	private static readonly get_anchorPosition_InjectedDelegate get_anchorPosition_InjectedDelegateField = IL2CPP.ResolveICall<get_anchorPosition_InjectedDelegate>("UnityEngine.ArticulationBody::get_anchorPosition_Injected");

	private static readonly set_anchorPosition_InjectedDelegate set_anchorPosition_InjectedDelegateField = IL2CPP.ResolveICall<set_anchorPosition_InjectedDelegate>("UnityEngine.ArticulationBody::set_anchorPosition_Injected");

	private static readonly get_parentAnchorPosition_InjectedDelegate get_parentAnchorPosition_InjectedDelegateField = IL2CPP.ResolveICall<get_parentAnchorPosition_InjectedDelegate>("UnityEngine.ArticulationBody::get_parentAnchorPosition_Injected");

	private static readonly set_parentAnchorPosition_InjectedDelegate set_parentAnchorPosition_InjectedDelegateField = IL2CPP.ResolveICall<set_parentAnchorPosition_InjectedDelegate>("UnityEngine.ArticulationBody::set_parentAnchorPosition_Injected");

	private static readonly get_anchorRotation_InjectedDelegate get_anchorRotation_InjectedDelegateField = IL2CPP.ResolveICall<get_anchorRotation_InjectedDelegate>("UnityEngine.ArticulationBody::get_anchorRotation_Injected");

	private static readonly set_anchorRotation_InjectedDelegate set_anchorRotation_InjectedDelegateField = IL2CPP.ResolveICall<set_anchorRotation_InjectedDelegate>("UnityEngine.ArticulationBody::set_anchorRotation_Injected");

	private static readonly get_parentAnchorRotation_InjectedDelegate get_parentAnchorRotation_InjectedDelegateField = IL2CPP.ResolveICall<get_parentAnchorRotation_InjectedDelegate>("UnityEngine.ArticulationBody::get_parentAnchorRotation_Injected");

	private static readonly set_parentAnchorRotation_InjectedDelegate set_parentAnchorRotation_InjectedDelegateField = IL2CPP.ResolveICall<set_parentAnchorRotation_InjectedDelegate>("UnityEngine.ArticulationBody::set_parentAnchorRotation_Injected");

	private static readonly get_isRoot_InjectedDelegate get_isRoot_InjectedDelegateField = IL2CPP.ResolveICall<get_isRoot_InjectedDelegate>("UnityEngine.ArticulationBody::get_isRoot_Injected");

	private static readonly get_matchAnchors_InjectedDelegate get_matchAnchors_InjectedDelegateField = IL2CPP.ResolveICall<get_matchAnchors_InjectedDelegate>("UnityEngine.ArticulationBody::get_matchAnchors_Injected");

	private static readonly set_matchAnchors_InjectedDelegate set_matchAnchors_InjectedDelegateField = IL2CPP.ResolveICall<set_matchAnchors_InjectedDelegate>("UnityEngine.ArticulationBody::set_matchAnchors_Injected");

	private static readonly get_linearLockX_InjectedDelegate get_linearLockX_InjectedDelegateField = IL2CPP.ResolveICall<get_linearLockX_InjectedDelegate>("UnityEngine.ArticulationBody::get_linearLockX_Injected");

	private static readonly set_linearLockX_InjectedDelegate set_linearLockX_InjectedDelegateField = IL2CPP.ResolveICall<set_linearLockX_InjectedDelegate>("UnityEngine.ArticulationBody::set_linearLockX_Injected");

	private static readonly get_linearLockY_InjectedDelegate get_linearLockY_InjectedDelegateField = IL2CPP.ResolveICall<get_linearLockY_InjectedDelegate>("UnityEngine.ArticulationBody::get_linearLockY_Injected");

	private static readonly set_linearLockY_InjectedDelegate set_linearLockY_InjectedDelegateField = IL2CPP.ResolveICall<set_linearLockY_InjectedDelegate>("UnityEngine.ArticulationBody::set_linearLockY_Injected");

	private static readonly get_linearLockZ_InjectedDelegate get_linearLockZ_InjectedDelegateField = IL2CPP.ResolveICall<get_linearLockZ_InjectedDelegate>("UnityEngine.ArticulationBody::get_linearLockZ_Injected");

	private static readonly set_linearLockZ_InjectedDelegate set_linearLockZ_InjectedDelegateField = IL2CPP.ResolveICall<set_linearLockZ_InjectedDelegate>("UnityEngine.ArticulationBody::set_linearLockZ_Injected");

	private static readonly get_swingYLock_InjectedDelegate get_swingYLock_InjectedDelegateField = IL2CPP.ResolveICall<get_swingYLock_InjectedDelegate>("UnityEngine.ArticulationBody::get_swingYLock_Injected");

	private static readonly set_swingYLock_InjectedDelegate set_swingYLock_InjectedDelegateField = IL2CPP.ResolveICall<set_swingYLock_InjectedDelegate>("UnityEngine.ArticulationBody::set_swingYLock_Injected");

	private static readonly get_swingZLock_InjectedDelegate get_swingZLock_InjectedDelegateField = IL2CPP.ResolveICall<get_swingZLock_InjectedDelegate>("UnityEngine.ArticulationBody::get_swingZLock_Injected");

	private static readonly set_swingZLock_InjectedDelegate set_swingZLock_InjectedDelegateField = IL2CPP.ResolveICall<set_swingZLock_InjectedDelegate>("UnityEngine.ArticulationBody::set_swingZLock_Injected");

	private static readonly get_twistLock_InjectedDelegate get_twistLock_InjectedDelegateField = IL2CPP.ResolveICall<get_twistLock_InjectedDelegate>("UnityEngine.ArticulationBody::get_twistLock_Injected");

	private static readonly set_twistLock_InjectedDelegate set_twistLock_InjectedDelegateField = IL2CPP.ResolveICall<set_twistLock_InjectedDelegate>("UnityEngine.ArticulationBody::set_twistLock_Injected");

	private static readonly get_immovable_InjectedDelegate get_immovable_InjectedDelegateField = IL2CPP.ResolveICall<get_immovable_InjectedDelegate>("UnityEngine.ArticulationBody::get_immovable_Injected");

	private static readonly set_immovable_InjectedDelegate set_immovable_InjectedDelegateField = IL2CPP.ResolveICall<set_immovable_InjectedDelegate>("UnityEngine.ArticulationBody::set_immovable_Injected");

	private static readonly get_useGravity_InjectedDelegate get_useGravity_InjectedDelegateField = IL2CPP.ResolveICall<get_useGravity_InjectedDelegate>("UnityEngine.ArticulationBody::get_useGravity_Injected");

	private static readonly set_useGravity_InjectedDelegate set_useGravity_InjectedDelegateField = IL2CPP.ResolveICall<set_useGravity_InjectedDelegate>("UnityEngine.ArticulationBody::set_useGravity_Injected");

	private static readonly get_linearDamping_InjectedDelegate get_linearDamping_InjectedDelegateField = IL2CPP.ResolveICall<get_linearDamping_InjectedDelegate>("UnityEngine.ArticulationBody::get_linearDamping_Injected");

	private static readonly set_linearDamping_InjectedDelegate set_linearDamping_InjectedDelegateField = IL2CPP.ResolveICall<set_linearDamping_InjectedDelegate>("UnityEngine.ArticulationBody::set_linearDamping_Injected");

	private static readonly get_angularDamping_InjectedDelegate get_angularDamping_InjectedDelegateField = IL2CPP.ResolveICall<get_angularDamping_InjectedDelegate>("UnityEngine.ArticulationBody::get_angularDamping_Injected");

	private static readonly set_angularDamping_InjectedDelegate set_angularDamping_InjectedDelegateField = IL2CPP.ResolveICall<set_angularDamping_InjectedDelegate>("UnityEngine.ArticulationBody::set_angularDamping_Injected");

	private static readonly get_jointFriction_InjectedDelegate get_jointFriction_InjectedDelegateField = IL2CPP.ResolveICall<get_jointFriction_InjectedDelegate>("UnityEngine.ArticulationBody::get_jointFriction_Injected");

	private static readonly set_jointFriction_InjectedDelegate set_jointFriction_InjectedDelegateField = IL2CPP.ResolveICall<set_jointFriction_InjectedDelegate>("UnityEngine.ArticulationBody::set_jointFriction_Injected");

	private static readonly get_excludeLayers_InjectedDelegate get_excludeLayers_InjectedDelegateField = IL2CPP.ResolveICall<get_excludeLayers_InjectedDelegate>("UnityEngine.ArticulationBody::get_excludeLayers_Injected");

	private static readonly set_excludeLayers_InjectedDelegate set_excludeLayers_InjectedDelegateField = IL2CPP.ResolveICall<set_excludeLayers_InjectedDelegate>("UnityEngine.ArticulationBody::set_excludeLayers_Injected");

	private static readonly get_includeLayers_InjectedDelegate get_includeLayers_InjectedDelegateField = IL2CPP.ResolveICall<get_includeLayers_InjectedDelegate>("UnityEngine.ArticulationBody::get_includeLayers_Injected");

	private static readonly set_includeLayers_InjectedDelegate set_includeLayers_InjectedDelegateField = IL2CPP.ResolveICall<set_includeLayers_InjectedDelegate>("UnityEngine.ArticulationBody::set_includeLayers_Injected");

	private static readonly GetAccumulatedForce_InjectedDelegate GetAccumulatedForce_InjectedDelegateField = IL2CPP.ResolveICall<GetAccumulatedForce_InjectedDelegate>("UnityEngine.ArticulationBody::GetAccumulatedForce_Injected");

	private static readonly GetAccumulatedTorque_InjectedDelegate GetAccumulatedTorque_InjectedDelegateField = IL2CPP.ResolveICall<GetAccumulatedTorque_InjectedDelegate>("UnityEngine.ArticulationBody::GetAccumulatedTorque_Injected");

	private static readonly AddForce_InjectedDelegate AddForce_InjectedDelegateField = IL2CPP.ResolveICall<AddForce_InjectedDelegate>("UnityEngine.ArticulationBody::AddForce_Injected");

	private static readonly AddRelativeForce_InjectedDelegate AddRelativeForce_InjectedDelegateField = IL2CPP.ResolveICall<AddRelativeForce_InjectedDelegate>("UnityEngine.ArticulationBody::AddRelativeForce_Injected");

	private static readonly AddTorque_InjectedDelegate AddTorque_InjectedDelegateField = IL2CPP.ResolveICall<AddTorque_InjectedDelegate>("UnityEngine.ArticulationBody::AddTorque_Injected");

	private static readonly AddRelativeTorque_InjectedDelegate AddRelativeTorque_InjectedDelegateField = IL2CPP.ResolveICall<AddRelativeTorque_InjectedDelegate>("UnityEngine.ArticulationBody::AddRelativeTorque_Injected");

	private static readonly AddForceAtPosition_InjectedDelegate AddForceAtPosition_InjectedDelegateField = IL2CPP.ResolveICall<AddForceAtPosition_InjectedDelegate>("UnityEngine.ArticulationBody::AddForceAtPosition_Injected");

	private static readonly get_linearVelocity_InjectedDelegate get_linearVelocity_InjectedDelegateField = IL2CPP.ResolveICall<get_linearVelocity_InjectedDelegate>("UnityEngine.ArticulationBody::get_linearVelocity_Injected");

	private static readonly set_linearVelocity_InjectedDelegate set_linearVelocity_InjectedDelegateField = IL2CPP.ResolveICall<set_linearVelocity_InjectedDelegate>("UnityEngine.ArticulationBody::set_linearVelocity_Injected");

	private static readonly get_angularVelocity_InjectedDelegate get_angularVelocity_InjectedDelegateField = IL2CPP.ResolveICall<get_angularVelocity_InjectedDelegate>("UnityEngine.ArticulationBody::get_angularVelocity_Injected");

	private static readonly set_angularVelocity_InjectedDelegate set_angularVelocity_InjectedDelegateField = IL2CPP.ResolveICall<set_angularVelocity_InjectedDelegate>("UnityEngine.ArticulationBody::set_angularVelocity_Injected");

	private static readonly get_mass_InjectedDelegate get_mass_InjectedDelegateField = IL2CPP.ResolveICall<get_mass_InjectedDelegate>("UnityEngine.ArticulationBody::get_mass_Injected");

	private static readonly set_mass_InjectedDelegate set_mass_InjectedDelegateField = IL2CPP.ResolveICall<set_mass_InjectedDelegate>("UnityEngine.ArticulationBody::set_mass_Injected");

	private static readonly get_automaticCenterOfMass_InjectedDelegate get_automaticCenterOfMass_InjectedDelegateField = IL2CPP.ResolveICall<get_automaticCenterOfMass_InjectedDelegate>("UnityEngine.ArticulationBody::get_automaticCenterOfMass_Injected");

	private static readonly set_automaticCenterOfMass_InjectedDelegate set_automaticCenterOfMass_InjectedDelegateField = IL2CPP.ResolveICall<set_automaticCenterOfMass_InjectedDelegate>("UnityEngine.ArticulationBody::set_automaticCenterOfMass_Injected");

	private static readonly get_centerOfMass_InjectedDelegate get_centerOfMass_InjectedDelegateField = IL2CPP.ResolveICall<get_centerOfMass_InjectedDelegate>("UnityEngine.ArticulationBody::get_centerOfMass_Injected");

	private static readonly set_centerOfMass_InjectedDelegate set_centerOfMass_InjectedDelegateField = IL2CPP.ResolveICall<set_centerOfMass_InjectedDelegate>("UnityEngine.ArticulationBody::set_centerOfMass_Injected");

	private static readonly get_worldCenterOfMass_InjectedDelegate get_worldCenterOfMass_InjectedDelegateField = IL2CPP.ResolveICall<get_worldCenterOfMass_InjectedDelegate>("UnityEngine.ArticulationBody::get_worldCenterOfMass_Injected");

	private static readonly get_automaticInertiaTensor_InjectedDelegate get_automaticInertiaTensor_InjectedDelegateField = IL2CPP.ResolveICall<get_automaticInertiaTensor_InjectedDelegate>("UnityEngine.ArticulationBody::get_automaticInertiaTensor_Injected");

	private static readonly set_automaticInertiaTensor_InjectedDelegate set_automaticInertiaTensor_InjectedDelegateField = IL2CPP.ResolveICall<set_automaticInertiaTensor_InjectedDelegate>("UnityEngine.ArticulationBody::set_automaticInertiaTensor_Injected");

	private static readonly get_inertiaTensor_InjectedDelegate get_inertiaTensor_InjectedDelegateField = IL2CPP.ResolveICall<get_inertiaTensor_InjectedDelegate>("UnityEngine.ArticulationBody::get_inertiaTensor_Injected");

	private static readonly set_inertiaTensor_InjectedDelegate set_inertiaTensor_InjectedDelegateField = IL2CPP.ResolveICall<set_inertiaTensor_InjectedDelegate>("UnityEngine.ArticulationBody::set_inertiaTensor_Injected");

	private static readonly get_worldInertiaTensorMatrix_InjectedDelegate get_worldInertiaTensorMatrix_InjectedDelegateField = IL2CPP.ResolveICall<get_worldInertiaTensorMatrix_InjectedDelegate>("UnityEngine.ArticulationBody::get_worldInertiaTensorMatrix_Injected");

	private static readonly get_inertiaTensorRotation_InjectedDelegate get_inertiaTensorRotation_InjectedDelegateField = IL2CPP.ResolveICall<get_inertiaTensorRotation_InjectedDelegate>("UnityEngine.ArticulationBody::get_inertiaTensorRotation_Injected");

	private static readonly set_inertiaTensorRotation_InjectedDelegate set_inertiaTensorRotation_InjectedDelegateField = IL2CPP.ResolveICall<set_inertiaTensorRotation_InjectedDelegate>("UnityEngine.ArticulationBody::set_inertiaTensorRotation_Injected");

	private static readonly ResetCenterOfMass_InjectedDelegate ResetCenterOfMass_InjectedDelegateField = IL2CPP.ResolveICall<ResetCenterOfMass_InjectedDelegate>("UnityEngine.ArticulationBody::ResetCenterOfMass_Injected");

	private static readonly ResetInertiaTensor_InjectedDelegate ResetInertiaTensor_InjectedDelegateField = IL2CPP.ResolveICall<ResetInertiaTensor_InjectedDelegate>("UnityEngine.ArticulationBody::ResetInertiaTensor_Injected");

	private static readonly Sleep_InjectedDelegate Sleep_InjectedDelegateField = IL2CPP.ResolveICall<Sleep_InjectedDelegate>("UnityEngine.ArticulationBody::Sleep_Injected");

	private static readonly IsSleeping_InjectedDelegate IsSleeping_InjectedDelegateField = IL2CPP.ResolveICall<IsSleeping_InjectedDelegate>("UnityEngine.ArticulationBody::IsSleeping_Injected");

	private static readonly WakeUp_InjectedDelegate WakeUp_InjectedDelegateField = IL2CPP.ResolveICall<WakeUp_InjectedDelegate>("UnityEngine.ArticulationBody::WakeUp_Injected");

	private static readonly get_sleepThreshold_InjectedDelegate get_sleepThreshold_InjectedDelegateField = IL2CPP.ResolveICall<get_sleepThreshold_InjectedDelegate>("UnityEngine.ArticulationBody::get_sleepThreshold_Injected");

	private static readonly set_sleepThreshold_InjectedDelegate set_sleepThreshold_InjectedDelegateField = IL2CPP.ResolveICall<set_sleepThreshold_InjectedDelegate>("UnityEngine.ArticulationBody::set_sleepThreshold_Injected");

	private static readonly get_solverIterations_InjectedDelegate get_solverIterations_InjectedDelegateField = IL2CPP.ResolveICall<get_solverIterations_InjectedDelegate>("UnityEngine.ArticulationBody::get_solverIterations_Injected");

	private static readonly set_solverIterations_InjectedDelegate set_solverIterations_InjectedDelegateField = IL2CPP.ResolveICall<set_solverIterations_InjectedDelegate>("UnityEngine.ArticulationBody::set_solverIterations_Injected");

	private static readonly get_solverVelocityIterations_InjectedDelegate get_solverVelocityIterations_InjectedDelegateField = IL2CPP.ResolveICall<get_solverVelocityIterations_InjectedDelegate>("UnityEngine.ArticulationBody::get_solverVelocityIterations_Injected");

	private static readonly set_solverVelocityIterations_InjectedDelegate set_solverVelocityIterations_InjectedDelegateField = IL2CPP.ResolveICall<set_solverVelocityIterations_InjectedDelegate>("UnityEngine.ArticulationBody::set_solverVelocityIterations_Injected");

	private static readonly get_maxAngularVelocity_InjectedDelegate get_maxAngularVelocity_InjectedDelegateField = IL2CPP.ResolveICall<get_maxAngularVelocity_InjectedDelegate>("UnityEngine.ArticulationBody::get_maxAngularVelocity_Injected");

	private static readonly set_maxAngularVelocity_InjectedDelegate set_maxAngularVelocity_InjectedDelegateField = IL2CPP.ResolveICall<set_maxAngularVelocity_InjectedDelegate>("UnityEngine.ArticulationBody::set_maxAngularVelocity_Injected");

	private static readonly get_maxLinearVelocity_InjectedDelegate get_maxLinearVelocity_InjectedDelegateField = IL2CPP.ResolveICall<get_maxLinearVelocity_InjectedDelegate>("UnityEngine.ArticulationBody::get_maxLinearVelocity_Injected");

	private static readonly set_maxLinearVelocity_InjectedDelegate set_maxLinearVelocity_InjectedDelegateField = IL2CPP.ResolveICall<set_maxLinearVelocity_InjectedDelegate>("UnityEngine.ArticulationBody::set_maxLinearVelocity_Injected");

	private static readonly get_maxJointVelocity_InjectedDelegate get_maxJointVelocity_InjectedDelegateField = IL2CPP.ResolveICall<get_maxJointVelocity_InjectedDelegate>("UnityEngine.ArticulationBody::get_maxJointVelocity_Injected");

	private static readonly set_maxJointVelocity_InjectedDelegate set_maxJointVelocity_InjectedDelegateField = IL2CPP.ResolveICall<set_maxJointVelocity_InjectedDelegate>("UnityEngine.ArticulationBody::set_maxJointVelocity_Injected");

	private static readonly get_maxDepenetrationVelocity_InjectedDelegate get_maxDepenetrationVelocity_InjectedDelegateField = IL2CPP.ResolveICall<get_maxDepenetrationVelocity_InjectedDelegate>("UnityEngine.ArticulationBody::get_maxDepenetrationVelocity_Injected");

	private static readonly set_maxDepenetrationVelocity_InjectedDelegate set_maxDepenetrationVelocity_InjectedDelegateField = IL2CPP.ResolveICall<set_maxDepenetrationVelocity_InjectedDelegate>("UnityEngine.ArticulationBody::set_maxDepenetrationVelocity_Injected");

	private static readonly get_dofCount_InjectedDelegate get_dofCount_InjectedDelegateField = IL2CPP.ResolveICall<get_dofCount_InjectedDelegate>("UnityEngine.ArticulationBody::get_dofCount_Injected");

	private static readonly get_index_InjectedDelegate get_index_InjectedDelegateField = IL2CPP.ResolveICall<get_index_InjectedDelegate>("UnityEngine.ArticulationBody::get_index_Injected");

	private static readonly TeleportRoot_InjectedDelegate TeleportRoot_InjectedDelegateField = IL2CPP.ResolveICall<TeleportRoot_InjectedDelegate>("UnityEngine.ArticulationBody::TeleportRoot_Injected");

	private static readonly GetClosestPoint_InjectedDelegate GetClosestPoint_InjectedDelegateField = IL2CPP.ResolveICall<GetClosestPoint_InjectedDelegate>("UnityEngine.ArticulationBody::GetClosestPoint_Injected");

	private static readonly GetRelativePointVelocity_InjectedDelegate GetRelativePointVelocity_InjectedDelegateField = IL2CPP.ResolveICall<GetRelativePointVelocity_InjectedDelegate>("UnityEngine.ArticulationBody::GetRelativePointVelocity_Injected");

	private static readonly GetPointVelocity_InjectedDelegate GetPointVelocity_InjectedDelegateField = IL2CPP.ResolveICall<GetPointVelocity_InjectedDelegate>("UnityEngine.ArticulationBody::GetPointVelocity_Injected");

	private static readonly GetJointPositions_InjectedDelegate GetJointPositions_InjectedDelegateField = IL2CPP.ResolveICall<GetJointPositions_InjectedDelegate>("UnityEngine.ArticulationBody::GetJointPositions_Injected");

	private static readonly SetJointPositions_InjectedDelegate SetJointPositions_InjectedDelegateField = IL2CPP.ResolveICall<SetJointPositions_InjectedDelegate>("UnityEngine.ArticulationBody::SetJointPositions_Injected");

	private static readonly GetJointVelocities_InjectedDelegate GetJointVelocities_InjectedDelegateField = IL2CPP.ResolveICall<GetJointVelocities_InjectedDelegate>("UnityEngine.ArticulationBody::GetJointVelocities_Injected");

	private static readonly SetJointVelocities_InjectedDelegate SetJointVelocities_InjectedDelegateField = IL2CPP.ResolveICall<SetJointVelocities_InjectedDelegate>("UnityEngine.ArticulationBody::SetJointVelocities_Injected");

	private static readonly GetJointAccelerations_InjectedDelegate GetJointAccelerations_InjectedDelegateField = IL2CPP.ResolveICall<GetJointAccelerations_InjectedDelegate>("UnityEngine.ArticulationBody::GetJointAccelerations_Injected");

	private static readonly GetJointForces_InjectedDelegate GetJointForces_InjectedDelegateField = IL2CPP.ResolveICall<GetJointForces_InjectedDelegate>("UnityEngine.ArticulationBody::GetJointForces_Injected");

	private static readonly SetJointForces_InjectedDelegate SetJointForces_InjectedDelegateField = IL2CPP.ResolveICall<SetJointForces_InjectedDelegate>("UnityEngine.ArticulationBody::SetJointForces_Injected");

	private static readonly GetDriveForces_InjectedDelegate GetDriveForces_InjectedDelegateField = IL2CPP.ResolveICall<GetDriveForces_InjectedDelegate>("UnityEngine.ArticulationBody::GetDriveForces_Injected");

	private static readonly GetJointGravityForces_InjectedDelegate GetJointGravityForces_InjectedDelegateField = IL2CPP.ResolveICall<GetJointGravityForces_InjectedDelegate>("UnityEngine.ArticulationBody::GetJointGravityForces_Injected");

	private static readonly GetJointCoriolisCentrifugalForces_InjectedDelegate GetJointCoriolisCentrifugalForces_InjectedDelegateField = IL2CPP.ResolveICall<GetJointCoriolisCentrifugalForces_InjectedDelegate>("UnityEngine.ArticulationBody::GetJointCoriolisCentrifugalForces_Injected");

	private static readonly GetJointExternalForces_InjectedDelegate GetJointExternalForces_InjectedDelegateField = IL2CPP.ResolveICall<GetJointExternalForces_InjectedDelegate>("UnityEngine.ArticulationBody::GetJointExternalForces_Injected");

	private static readonly GetDriveTargets_InjectedDelegate GetDriveTargets_InjectedDelegateField = IL2CPP.ResolveICall<GetDriveTargets_InjectedDelegate>("UnityEngine.ArticulationBody::GetDriveTargets_Injected");

	private static readonly SetDriveTargets_InjectedDelegate SetDriveTargets_InjectedDelegateField = IL2CPP.ResolveICall<SetDriveTargets_InjectedDelegate>("UnityEngine.ArticulationBody::SetDriveTargets_Injected");

	private static readonly GetDriveTargetVelocities_InjectedDelegate GetDriveTargetVelocities_InjectedDelegateField = IL2CPP.ResolveICall<GetDriveTargetVelocities_InjectedDelegate>("UnityEngine.ArticulationBody::GetDriveTargetVelocities_Injected");

	private static readonly SetDriveTargetVelocities_InjectedDelegate SetDriveTargetVelocities_InjectedDelegateField = IL2CPP.ResolveICall<SetDriveTargetVelocities_InjectedDelegate>("UnityEngine.ArticulationBody::SetDriveTargetVelocities_Injected");

	private static readonly GetDofStartIndices_InjectedDelegate GetDofStartIndices_InjectedDelegateField = IL2CPP.ResolveICall<GetDofStartIndices_InjectedDelegate>("UnityEngine.ArticulationBody::GetDofStartIndices_Injected");

	private static readonly SetDriveTarget_InjectedDelegate SetDriveTarget_InjectedDelegateField = IL2CPP.ResolveICall<SetDriveTarget_InjectedDelegate>("UnityEngine.ArticulationBody::SetDriveTarget_Injected");

	private static readonly SetDriveTargetVelocity_InjectedDelegate SetDriveTargetVelocity_InjectedDelegateField = IL2CPP.ResolveICall<SetDriveTargetVelocity_InjectedDelegate>("UnityEngine.ArticulationBody::SetDriveTargetVelocity_Injected");

	private static readonly SetDriveLimits_InjectedDelegate SetDriveLimits_InjectedDelegateField = IL2CPP.ResolveICall<SetDriveLimits_InjectedDelegate>("UnityEngine.ArticulationBody::SetDriveLimits_Injected");

	private static readonly SetDriveStiffness_InjectedDelegate SetDriveStiffness_InjectedDelegateField = IL2CPP.ResolveICall<SetDriveStiffness_InjectedDelegate>("UnityEngine.ArticulationBody::SetDriveStiffness_Injected");

	private static readonly SetDriveDamping_InjectedDelegate SetDriveDamping_InjectedDelegateField = IL2CPP.ResolveICall<SetDriveDamping_InjectedDelegate>("UnityEngine.ArticulationBody::SetDriveDamping_Injected");

	private static readonly SetDriveForceLimit_InjectedDelegate SetDriveForceLimit_InjectedDelegateField = IL2CPP.ResolveICall<SetDriveForceLimit_InjectedDelegate>("UnityEngine.ArticulationBody::SetDriveForceLimit_Injected");

	private static readonly get_collisionDetectionMode_InjectedDelegate get_collisionDetectionMode_InjectedDelegateField = IL2CPP.ResolveICall<get_collisionDetectionMode_InjectedDelegate>("UnityEngine.ArticulationBody::get_collisionDetectionMode_Injected");

	private static readonly set_collisionDetectionMode_InjectedDelegate set_collisionDetectionMode_InjectedDelegateField = IL2CPP.ResolveICall<set_collisionDetectionMode_InjectedDelegate>("UnityEngine.ArticulationBody::set_collisionDetectionMode_Injected");

	private static readonly PublishTransform_InjectedDelegate PublishTransform_InjectedDelegateField = IL2CPP.ResolveICall<PublishTransform_InjectedDelegate>("UnityEngine.ArticulationBody::PublishTransform_Injected");

	private static readonly SetJointAccelerations_InjectedDelegate SetJointAccelerations_InjectedDelegateField = IL2CPP.ResolveICall<SetJointAccelerations_InjectedDelegate>("UnityEngine.ArticulationBody::SetJointAccelerations_Injected");

	public ArticulationJointType jointType
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_jointType_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_jointType_Injected(intPtr, value);
		}
	}

	public Vector3 anchorPosition
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			get_anchorPosition_Injected(intPtr, out var ret);
			return ret;
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_anchorPosition_Injected(intPtr, ref value);
		}
	}

	public Vector3 parentAnchorPosition
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			get_parentAnchorPosition_Injected(intPtr, out var ret);
			return ret;
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_parentAnchorPosition_Injected(intPtr, ref value);
		}
	}

	public Quaternion anchorRotation
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			get_anchorRotation_Injected(intPtr, out var ret);
			return ret;
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_anchorRotation_Injected(intPtr, ref value);
		}
	}

	public Quaternion parentAnchorRotation
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			get_parentAnchorRotation_Injected(intPtr, out var ret);
			return ret;
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_parentAnchorRotation_Injected(intPtr, ref value);
		}
	}

	public bool isRoot
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_isRoot_Injected(intPtr);
		}
	}

	public bool matchAnchors
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_matchAnchors_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_matchAnchors_Injected(intPtr, value);
		}
	}

	public ArticulationDofLock linearLockX
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_linearLockX_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_linearLockX_Injected(intPtr, value);
		}
	}

	public ArticulationDofLock linearLockY
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_linearLockY_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_linearLockY_Injected(intPtr, value);
		}
	}

	public ArticulationDofLock linearLockZ
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_linearLockZ_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_linearLockZ_Injected(intPtr, value);
		}
	}

	public ArticulationDofLock swingYLock
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_swingYLock_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_swingYLock_Injected(intPtr, value);
		}
	}

	public ArticulationDofLock swingZLock
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_swingZLock_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_swingZLock_Injected(intPtr, value);
		}
	}

	public ArticulationDofLock twistLock
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_twistLock_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_twistLock_Injected(intPtr, value);
		}
	}

	public bool immovable
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_immovable_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_immovable_Injected(intPtr, value);
		}
	}

	public bool useGravity
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_useGravity_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_useGravity_Injected(intPtr, value);
		}
	}

	public float linearDamping
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_linearDamping_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_linearDamping_Injected(intPtr, value);
		}
	}

	public float angularDamping
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_angularDamping_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_angularDamping_Injected(intPtr, value);
		}
	}

	public float jointFriction
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_jointFriction_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_jointFriction_Injected(intPtr, value);
		}
	}

	public LayerMask excludeLayers
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			get_excludeLayers_Injected(intPtr, out var ret);
			return ret;
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_excludeLayers_Injected(intPtr, ref value);
		}
	}

	public LayerMask includeLayers
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			get_includeLayers_Injected(intPtr, out var ret);
			return ret;
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_includeLayers_Injected(intPtr, ref value);
		}
	}

	public Vector3 linearVelocity
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			get_linearVelocity_Injected(intPtr, out var ret);
			return ret;
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_linearVelocity_Injected(intPtr, ref value);
		}
	}

	public Vector3 angularVelocity
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			get_angularVelocity_Injected(intPtr, out var ret);
			return ret;
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_angularVelocity_Injected(intPtr, ref value);
		}
	}

	public float mass
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_mass_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_mass_Injected(intPtr, value);
		}
	}

	public bool automaticCenterOfMass
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_automaticCenterOfMass_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_automaticCenterOfMass_Injected(intPtr, value);
		}
	}

	public Vector3 centerOfMass
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			get_centerOfMass_Injected(intPtr, out var ret);
			return ret;
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_centerOfMass_Injected(intPtr, ref value);
		}
	}

	public Vector3 worldCenterOfMass
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			get_worldCenterOfMass_Injected(intPtr, out var ret);
			return ret;
		}
	}

	public bool automaticInertiaTensor
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_automaticInertiaTensor_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_automaticInertiaTensor_Injected(intPtr, value);
		}
	}

	public Vector3 inertiaTensor
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			get_inertiaTensor_Injected(intPtr, out var ret);
			return ret;
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_inertiaTensor_Injected(intPtr, ref value);
		}
	}

	public Matrix4x4 worldInertiaTensorMatrix
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			get_worldInertiaTensorMatrix_Injected(intPtr, out var ret);
			return ret;
		}
	}

	public Quaternion inertiaTensorRotation
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			get_inertiaTensorRotation_Injected(intPtr, out var ret);
			return ret;
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_inertiaTensorRotation_Injected(intPtr, ref value);
		}
	}

	public float sleepThreshold
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_sleepThreshold_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_sleepThreshold_Injected(intPtr, value);
		}
	}

	public int solverIterations
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_solverIterations_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_solverIterations_Injected(intPtr, value);
		}
	}

	public int solverVelocityIterations
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_solverVelocityIterations_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_solverVelocityIterations_Injected(intPtr, value);
		}
	}

	public float maxAngularVelocity
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_maxAngularVelocity_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_maxAngularVelocity_Injected(intPtr, value);
		}
	}

	public float maxLinearVelocity
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_maxLinearVelocity_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_maxLinearVelocity_Injected(intPtr, value);
		}
	}

	public float maxJointVelocity
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_maxJointVelocity_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_maxJointVelocity_Injected(intPtr, value);
		}
	}

	public float maxDepenetrationVelocity
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_maxDepenetrationVelocity_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_maxDepenetrationVelocity_Injected(intPtr, value);
		}
	}

	public int dofCount
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_dofCount_Injected(intPtr);
		}
	}

	public int index
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_index_Injected(intPtr);
		}
	}

	public CollisionDetectionMode collisionDetectionMode
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_collisionDetectionMode_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_collisionDetectionMode_Injected(intPtr, value);
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

	public bool computeParentAnchor
	{
		get
		{
			return matchAnchors;
		}
		set
		{
			matchAnchors = value;
		}
	}

	public Vector3 GetAccumulatedForce(float step)
	{
		IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (IntPtr)0)
		{
			ThrowHelper.ThrowNullReferenceException(this);
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
		IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (IntPtr)0)
		{
			ThrowHelper.ThrowNullReferenceException(this);
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
		IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (IntPtr)0)
		{
			ThrowHelper.ThrowNullReferenceException(this);
		}
		AddForce_Injected(intPtr, ref force, mode);
	}

	public void AddForce(Vector3 force)
	{
		AddForce(force, ForceMode.Force);
	}

	public void AddRelativeForce(Vector3 force, ForceMode mode)
	{
		IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (IntPtr)0)
		{
			ThrowHelper.ThrowNullReferenceException(this);
		}
		AddRelativeForce_Injected(intPtr, ref force, mode);
	}

	public void AddRelativeForce(Vector3 force)
	{
		AddRelativeForce(force, ForceMode.Force);
	}

	public void AddTorque(Vector3 torque, ForceMode mode)
	{
		IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (IntPtr)0)
		{
			ThrowHelper.ThrowNullReferenceException(this);
		}
		AddTorque_Injected(intPtr, ref torque, mode);
	}

	public void AddTorque(Vector3 torque)
	{
		AddTorque(torque, ForceMode.Force);
	}

	public void AddRelativeTorque(Vector3 torque, ForceMode mode)
	{
		IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (IntPtr)0)
		{
			ThrowHelper.ThrowNullReferenceException(this);
		}
		AddRelativeTorque_Injected(intPtr, ref torque, mode);
	}

	public void AddRelativeTorque(Vector3 torque)
	{
		AddRelativeTorque(torque, ForceMode.Force);
	}

	public void AddForceAtPosition(Vector3 force, Vector3 position, ForceMode mode)
	{
		IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (IntPtr)0)
		{
			ThrowHelper.ThrowNullReferenceException(this);
		}
		AddForceAtPosition_Injected(intPtr, ref force, ref position, mode);
	}

	public void AddForceAtPosition(Vector3 force, Vector3 position)
	{
		AddForceAtPosition(force, position, ForceMode.Force);
	}

	public void ResetCenterOfMass()
	{
		IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (IntPtr)0)
		{
			ThrowHelper.ThrowNullReferenceException(this);
		}
		ResetCenterOfMass_Injected(intPtr);
	}

	public void ResetInertiaTensor()
	{
		IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (IntPtr)0)
		{
			ThrowHelper.ThrowNullReferenceException(this);
		}
		ResetInertiaTensor_Injected(intPtr);
	}

	public void Sleep()
	{
		IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (IntPtr)0)
		{
			ThrowHelper.ThrowNullReferenceException(this);
		}
		Sleep_Injected(intPtr);
	}

	public bool IsSleeping()
	{
		IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (IntPtr)0)
		{
			ThrowHelper.ThrowNullReferenceException(this);
		}
		return IsSleeping_Injected(intPtr);
	}

	public void WakeUp()
	{
		IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (IntPtr)0)
		{
			ThrowHelper.ThrowNullReferenceException(this);
		}
		WakeUp_Injected(intPtr);
	}

	public void TeleportRoot(Vector3 position, Quaternion rotation)
	{
		IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (IntPtr)0)
		{
			ThrowHelper.ThrowNullReferenceException(this);
		}
		TeleportRoot_Injected(intPtr, ref position, ref rotation);
	}

	public Vector3 GetClosestPoint(Vector3 point)
	{
		IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (IntPtr)0)
		{
			ThrowHelper.ThrowNullReferenceException(this);
		}
		GetClosestPoint_Injected(intPtr, ref point, out var ret);
		return ret;
	}

	public Vector3 GetRelativePointVelocity(Vector3 relativePoint)
	{
		IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (IntPtr)0)
		{
			ThrowHelper.ThrowNullReferenceException(this);
		}
		GetRelativePointVelocity_Injected(intPtr, ref relativePoint, out var ret);
		return ret;
	}

	public Vector3 GetPointVelocity(Vector3 worldPoint)
	{
		IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (IntPtr)0)
		{
			ThrowHelper.ThrowNullReferenceException(this);
		}
		GetPointVelocity_Injected(intPtr, ref worldPoint, out var ret);
		return ret;
	}

	public int GetJointPositions(List<float> positions)
	{
		throw new NotSupportedException("Method unstripping failed");
	}

	public void SetJointPositions(List<float> positions)
	{
		throw new NotSupportedException("Method unstripping failed");
	}

	public int GetJointVelocities(List<float> velocities)
	{
		throw new NotSupportedException("Method unstripping failed");
	}

	public void SetJointVelocities(List<float> velocities)
	{
		throw new NotSupportedException("Method unstripping failed");
	}

	public int GetJointAccelerations(List<float> accelerations)
	{
		throw new NotSupportedException("Method unstripping failed");
	}

	public int GetJointForces(List<float> forces)
	{
		throw new NotSupportedException("Method unstripping failed");
	}

	public void SetJointForces(List<float> forces)
	{
		throw new NotSupportedException("Method unstripping failed");
	}

	public int GetDriveForces(List<float> forces)
	{
		throw new NotSupportedException("Method unstripping failed");
	}

	public int GetJointGravityForces(List<float> forces)
	{
		throw new NotSupportedException("Method unstripping failed");
	}

	public int GetJointCoriolisCentrifugalForces(List<float> forces)
	{
		throw new NotSupportedException("Method unstripping failed");
	}

	public int GetJointExternalForces(List<float> forces, float step)
	{
		throw new NotSupportedException("Method unstripping failed");
	}

	public int GetDriveTargets(List<float> targets)
	{
		throw new NotSupportedException("Method unstripping failed");
	}

	public void SetDriveTargets(List<float> targets)
	{
		throw new NotSupportedException("Method unstripping failed");
	}

	public int GetDriveTargetVelocities(List<float> targetVelocities)
	{
		throw new NotSupportedException("Method unstripping failed");
	}

	public void SetDriveTargetVelocities(List<float> targetVelocities)
	{
		throw new NotSupportedException("Method unstripping failed");
	}

	public int GetDofStartIndices(List<int> dofStartIndices)
	{
		throw new NotSupportedException("Method unstripping failed");
	}

	public void SetDriveTarget(ArticulationDriveAxis axis, float value)
	{
		IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (IntPtr)0)
		{
			ThrowHelper.ThrowNullReferenceException(this);
		}
		SetDriveTarget_Injected(intPtr, axis, value);
	}

	public void SetDriveTargetVelocity(ArticulationDriveAxis axis, float value)
	{
		IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (IntPtr)0)
		{
			ThrowHelper.ThrowNullReferenceException(this);
		}
		SetDriveTargetVelocity_Injected(intPtr, axis, value);
	}

	public void SetDriveLimits(ArticulationDriveAxis axis, float lower, float upper)
	{
		IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (IntPtr)0)
		{
			ThrowHelper.ThrowNullReferenceException(this);
		}
		SetDriveLimits_Injected(intPtr, axis, lower, upper);
	}

	public void SetDriveStiffness(ArticulationDriveAxis axis, float value)
	{
		IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (IntPtr)0)
		{
			ThrowHelper.ThrowNullReferenceException(this);
		}
		SetDriveStiffness_Injected(intPtr, axis, value);
	}

	public void SetDriveDamping(ArticulationDriveAxis axis, float value)
	{
		IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (IntPtr)0)
		{
			ThrowHelper.ThrowNullReferenceException(this);
		}
		SetDriveDamping_Injected(intPtr, axis, value);
	}

	public void SetDriveForceLimit(ArticulationDriveAxis axis, float value)
	{
		IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (IntPtr)0)
		{
			ThrowHelper.ThrowNullReferenceException(this);
		}
		SetDriveForceLimit_Injected(intPtr, axis, value);
	}

	public void PublishTransform()
	{
		IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (IntPtr)0)
		{
			ThrowHelper.ThrowNullReferenceException(this);
		}
		PublishTransform_Injected(intPtr);
	}

	public void SnapAnchorToClosestContact()
	{
		if ((bool)base.transform.parent)
		{
			ArticulationBody componentInParent = base.transform.parent.GetComponentInParent<ArticulationBody>();
			while ((bool)componentInParent && !componentInParent.enabled)
			{
				componentInParent = componentInParent.transform.parent.GetComponentInParent<ArticulationBody>();
			}
			if ((bool)componentInParent)
			{
				Vector3 vector = componentInParent.worldCenterOfMass;
				Vector3 closestPoint = GetClosestPoint(vector);
				anchorPosition = base.transform.InverseTransformPoint(closestPoint);
				anchorRotation = Quaternion.FromToRotation(Vector3.right, base.transform.InverseTransformDirection(vector - closestPoint).normalized);
			}
		}
	}

	public void SetJointAccelerations(List<float> accelerations)
	{
		throw new NotSupportedException("Method unstripping failed");
	}

	public static ArticulationJointType get_jointType_Injected(IntPtr _unity_self)
	{
		return get_jointType_InjectedDelegateField(_unity_self);
	}

	public static void set_jointType_Injected(IntPtr _unity_self, ArticulationJointType value)
	{
		set_jointType_InjectedDelegateField(_unity_self, value);
	}

	public unsafe static void get_anchorPosition_Injected(IntPtr _unity_self, out Vector3 ret)
	{
		get_anchorPosition_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void set_anchorPosition_Injected(IntPtr _unity_self, [In] ref Vector3 value)
	{
		set_anchorPosition_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref value));
	}

	public unsafe static void get_parentAnchorPosition_Injected(IntPtr _unity_self, out Vector3 ret)
	{
		get_parentAnchorPosition_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void set_parentAnchorPosition_Injected(IntPtr _unity_self, [In] ref Vector3 value)
	{
		set_parentAnchorPosition_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref value));
	}

	public unsafe static void get_anchorRotation_Injected(IntPtr _unity_self, out Quaternion ret)
	{
		get_anchorRotation_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void set_anchorRotation_Injected(IntPtr _unity_self, [In] ref Quaternion value)
	{
		set_anchorRotation_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref value));
	}

	public unsafe static void get_parentAnchorRotation_Injected(IntPtr _unity_self, out Quaternion ret)
	{
		get_parentAnchorRotation_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void set_parentAnchorRotation_Injected(IntPtr _unity_self, [In] ref Quaternion value)
	{
		set_parentAnchorRotation_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref value));
	}

	public static bool get_isRoot_Injected(IntPtr _unity_self)
	{
		return get_isRoot_InjectedDelegateField(_unity_self);
	}

	public static bool get_matchAnchors_Injected(IntPtr _unity_self)
	{
		return get_matchAnchors_InjectedDelegateField(_unity_self);
	}

	public static void set_matchAnchors_Injected(IntPtr _unity_self, bool value)
	{
		set_matchAnchors_InjectedDelegateField(_unity_self, value);
	}

	public static ArticulationDofLock get_linearLockX_Injected(IntPtr _unity_self)
	{
		return get_linearLockX_InjectedDelegateField(_unity_self);
	}

	public static void set_linearLockX_Injected(IntPtr _unity_self, ArticulationDofLock value)
	{
		set_linearLockX_InjectedDelegateField(_unity_self, value);
	}

	public static ArticulationDofLock get_linearLockY_Injected(IntPtr _unity_self)
	{
		return get_linearLockY_InjectedDelegateField(_unity_self);
	}

	public static void set_linearLockY_Injected(IntPtr _unity_self, ArticulationDofLock value)
	{
		set_linearLockY_InjectedDelegateField(_unity_self, value);
	}

	public static ArticulationDofLock get_linearLockZ_Injected(IntPtr _unity_self)
	{
		return get_linearLockZ_InjectedDelegateField(_unity_self);
	}

	public static void set_linearLockZ_Injected(IntPtr _unity_self, ArticulationDofLock value)
	{
		set_linearLockZ_InjectedDelegateField(_unity_self, value);
	}

	public static ArticulationDofLock get_swingYLock_Injected(IntPtr _unity_self)
	{
		return get_swingYLock_InjectedDelegateField(_unity_self);
	}

	public static void set_swingYLock_Injected(IntPtr _unity_self, ArticulationDofLock value)
	{
		set_swingYLock_InjectedDelegateField(_unity_self, value);
	}

	public static ArticulationDofLock get_swingZLock_Injected(IntPtr _unity_self)
	{
		return get_swingZLock_InjectedDelegateField(_unity_self);
	}

	public static void set_swingZLock_Injected(IntPtr _unity_self, ArticulationDofLock value)
	{
		set_swingZLock_InjectedDelegateField(_unity_self, value);
	}

	public static ArticulationDofLock get_twistLock_Injected(IntPtr _unity_self)
	{
		return get_twistLock_InjectedDelegateField(_unity_self);
	}

	public static void set_twistLock_Injected(IntPtr _unity_self, ArticulationDofLock value)
	{
		set_twistLock_InjectedDelegateField(_unity_self, value);
	}

	public static bool get_immovable_Injected(IntPtr _unity_self)
	{
		return get_immovable_InjectedDelegateField(_unity_self);
	}

	public static void set_immovable_Injected(IntPtr _unity_self, bool value)
	{
		set_immovable_InjectedDelegateField(_unity_self, value);
	}

	public static bool get_useGravity_Injected(IntPtr _unity_self)
	{
		return get_useGravity_InjectedDelegateField(_unity_self);
	}

	public static void set_useGravity_Injected(IntPtr _unity_self, bool value)
	{
		set_useGravity_InjectedDelegateField(_unity_self, value);
	}

	public static float get_linearDamping_Injected(IntPtr _unity_self)
	{
		return get_linearDamping_InjectedDelegateField(_unity_self);
	}

	public static void set_linearDamping_Injected(IntPtr _unity_self, float value)
	{
		set_linearDamping_InjectedDelegateField(_unity_self, value);
	}

	public static float get_angularDamping_Injected(IntPtr _unity_self)
	{
		return get_angularDamping_InjectedDelegateField(_unity_self);
	}

	public static void set_angularDamping_Injected(IntPtr _unity_self, float value)
	{
		set_angularDamping_InjectedDelegateField(_unity_self, value);
	}

	public static float get_jointFriction_Injected(IntPtr _unity_self)
	{
		return get_jointFriction_InjectedDelegateField(_unity_self);
	}

	public static void set_jointFriction_Injected(IntPtr _unity_self, float value)
	{
		set_jointFriction_InjectedDelegateField(_unity_self, value);
	}

	public unsafe static void get_excludeLayers_Injected(IntPtr _unity_self, out LayerMask ret)
	{
		get_excludeLayers_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void set_excludeLayers_Injected(IntPtr _unity_self, [In] ref LayerMask value)
	{
		set_excludeLayers_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref value));
	}

	public unsafe static void get_includeLayers_Injected(IntPtr _unity_self, out LayerMask ret)
	{
		get_includeLayers_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void set_includeLayers_Injected(IntPtr _unity_self, [In] ref LayerMask value)
	{
		set_includeLayers_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref value));
	}

	public unsafe static void GetAccumulatedForce_Injected(IntPtr _unity_self, float step, out Vector3 ret)
	{
		GetAccumulatedForce_InjectedDelegateField(_unity_self, step, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void GetAccumulatedTorque_Injected(IntPtr _unity_self, float step, out Vector3 ret)
	{
		GetAccumulatedTorque_InjectedDelegateField(_unity_self, step, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void AddForce_Injected(IntPtr _unity_self, [In] ref Vector3 force, ForceMode mode)
	{
		AddForce_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref force), mode);
	}

	public unsafe static void AddRelativeForce_Injected(IntPtr _unity_self, [In] ref Vector3 force, ForceMode mode)
	{
		AddRelativeForce_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref force), mode);
	}

	public unsafe static void AddTorque_Injected(IntPtr _unity_self, [In] ref Vector3 torque, ForceMode mode)
	{
		AddTorque_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref torque), mode);
	}

	public unsafe static void AddRelativeTorque_Injected(IntPtr _unity_self, [In] ref Vector3 torque, ForceMode mode)
	{
		AddRelativeTorque_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref torque), mode);
	}

	public unsafe static void AddForceAtPosition_Injected(IntPtr _unity_self, [In] ref Vector3 force, [In] ref Vector3 position, ForceMode mode)
	{
		AddForceAtPosition_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref force), (nint)Unsafe.AsPointer(ref position), mode);
	}

	public unsafe static void get_linearVelocity_Injected(IntPtr _unity_self, out Vector3 ret)
	{
		get_linearVelocity_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void set_linearVelocity_Injected(IntPtr _unity_self, [In] ref Vector3 value)
	{
		set_linearVelocity_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref value));
	}

	public unsafe static void get_angularVelocity_Injected(IntPtr _unity_self, out Vector3 ret)
	{
		get_angularVelocity_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void set_angularVelocity_Injected(IntPtr _unity_self, [In] ref Vector3 value)
	{
		set_angularVelocity_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref value));
	}

	public static float get_mass_Injected(IntPtr _unity_self)
	{
		return get_mass_InjectedDelegateField(_unity_self);
	}

	public static void set_mass_Injected(IntPtr _unity_self, float value)
	{
		set_mass_InjectedDelegateField(_unity_self, value);
	}

	public static bool get_automaticCenterOfMass_Injected(IntPtr _unity_self)
	{
		return get_automaticCenterOfMass_InjectedDelegateField(_unity_self);
	}

	public static void set_automaticCenterOfMass_Injected(IntPtr _unity_self, bool value)
	{
		set_automaticCenterOfMass_InjectedDelegateField(_unity_self, value);
	}

	public unsafe static void get_centerOfMass_Injected(IntPtr _unity_self, out Vector3 ret)
	{
		get_centerOfMass_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void set_centerOfMass_Injected(IntPtr _unity_self, [In] ref Vector3 value)
	{
		set_centerOfMass_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref value));
	}

	public unsafe static void get_worldCenterOfMass_Injected(IntPtr _unity_self, out Vector3 ret)
	{
		get_worldCenterOfMass_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public static bool get_automaticInertiaTensor_Injected(IntPtr _unity_self)
	{
		return get_automaticInertiaTensor_InjectedDelegateField(_unity_self);
	}

	public static void set_automaticInertiaTensor_Injected(IntPtr _unity_self, bool value)
	{
		set_automaticInertiaTensor_InjectedDelegateField(_unity_self, value);
	}

	public unsafe static void get_inertiaTensor_Injected(IntPtr _unity_self, out Vector3 ret)
	{
		get_inertiaTensor_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void set_inertiaTensor_Injected(IntPtr _unity_self, [In] ref Vector3 value)
	{
		set_inertiaTensor_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref value));
	}

	public unsafe static void get_worldInertiaTensorMatrix_Injected(IntPtr _unity_self, out Matrix4x4 ret)
	{
		get_worldInertiaTensorMatrix_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void get_inertiaTensorRotation_Injected(IntPtr _unity_self, out Quaternion ret)
	{
		get_inertiaTensorRotation_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void set_inertiaTensorRotation_Injected(IntPtr _unity_self, [In] ref Quaternion value)
	{
		set_inertiaTensorRotation_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref value));
	}

	public static void ResetCenterOfMass_Injected(IntPtr _unity_self)
	{
		ResetCenterOfMass_InjectedDelegateField(_unity_self);
	}

	public static void ResetInertiaTensor_Injected(IntPtr _unity_self)
	{
		ResetInertiaTensor_InjectedDelegateField(_unity_self);
	}

	public static void Sleep_Injected(IntPtr _unity_self)
	{
		Sleep_InjectedDelegateField(_unity_self);
	}

	public static bool IsSleeping_Injected(IntPtr _unity_self)
	{
		return IsSleeping_InjectedDelegateField(_unity_self);
	}

	public static void WakeUp_Injected(IntPtr _unity_self)
	{
		WakeUp_InjectedDelegateField(_unity_self);
	}

	public static float get_sleepThreshold_Injected(IntPtr _unity_self)
	{
		return get_sleepThreshold_InjectedDelegateField(_unity_self);
	}

	public static void set_sleepThreshold_Injected(IntPtr _unity_self, float value)
	{
		set_sleepThreshold_InjectedDelegateField(_unity_self, value);
	}

	public static int get_solverIterations_Injected(IntPtr _unity_self)
	{
		return get_solverIterations_InjectedDelegateField(_unity_self);
	}

	public static void set_solverIterations_Injected(IntPtr _unity_self, int value)
	{
		set_solverIterations_InjectedDelegateField(_unity_self, value);
	}

	public static int get_solverVelocityIterations_Injected(IntPtr _unity_self)
	{
		return get_solverVelocityIterations_InjectedDelegateField(_unity_self);
	}

	public static void set_solverVelocityIterations_Injected(IntPtr _unity_self, int value)
	{
		set_solverVelocityIterations_InjectedDelegateField(_unity_self, value);
	}

	public static float get_maxAngularVelocity_Injected(IntPtr _unity_self)
	{
		return get_maxAngularVelocity_InjectedDelegateField(_unity_self);
	}

	public static void set_maxAngularVelocity_Injected(IntPtr _unity_self, float value)
	{
		set_maxAngularVelocity_InjectedDelegateField(_unity_self, value);
	}

	public static float get_maxLinearVelocity_Injected(IntPtr _unity_self)
	{
		return get_maxLinearVelocity_InjectedDelegateField(_unity_self);
	}

	public static void set_maxLinearVelocity_Injected(IntPtr _unity_self, float value)
	{
		set_maxLinearVelocity_InjectedDelegateField(_unity_self, value);
	}

	public static float get_maxJointVelocity_Injected(IntPtr _unity_self)
	{
		return get_maxJointVelocity_InjectedDelegateField(_unity_self);
	}

	public static void set_maxJointVelocity_Injected(IntPtr _unity_self, float value)
	{
		set_maxJointVelocity_InjectedDelegateField(_unity_self, value);
	}

	public static float get_maxDepenetrationVelocity_Injected(IntPtr _unity_self)
	{
		return get_maxDepenetrationVelocity_InjectedDelegateField(_unity_self);
	}

	public static void set_maxDepenetrationVelocity_Injected(IntPtr _unity_self, float value)
	{
		set_maxDepenetrationVelocity_InjectedDelegateField(_unity_self, value);
	}

	public static int get_dofCount_Injected(IntPtr _unity_self)
	{
		return get_dofCount_InjectedDelegateField(_unity_self);
	}

	public static int get_index_Injected(IntPtr _unity_self)
	{
		return get_index_InjectedDelegateField(_unity_self);
	}

	public unsafe static void TeleportRoot_Injected(IntPtr _unity_self, [In] ref Vector3 position, [In] ref Quaternion rotation)
	{
		TeleportRoot_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref position), (nint)Unsafe.AsPointer(ref rotation));
	}

	public unsafe static void GetClosestPoint_Injected(IntPtr _unity_self, [In] ref Vector3 point, out Vector3 ret)
	{
		GetClosestPoint_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref point), (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void GetRelativePointVelocity_Injected(IntPtr _unity_self, [In] ref Vector3 relativePoint, out Vector3 ret)
	{
		GetRelativePointVelocity_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref relativePoint), (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void GetPointVelocity_Injected(IntPtr _unity_self, [In] ref Vector3 worldPoint, out Vector3 ret)
	{
		GetPointVelocity_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref worldPoint), (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static int GetJointPositions_Injected(IntPtr _unity_self, ref BlittableListWrapper positions)
	{
		return GetJointPositions_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref positions));
	}

	public unsafe static void SetJointPositions_Injected(IntPtr _unity_self, ref BlittableListWrapper positions)
	{
		SetJointPositions_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref positions));
	}

	public unsafe static int GetJointVelocities_Injected(IntPtr _unity_self, ref BlittableListWrapper velocities)
	{
		return GetJointVelocities_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref velocities));
	}

	public unsafe static void SetJointVelocities_Injected(IntPtr _unity_self, ref BlittableListWrapper velocities)
	{
		SetJointVelocities_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref velocities));
	}

	public unsafe static int GetJointAccelerations_Injected(IntPtr _unity_self, ref BlittableListWrapper accelerations)
	{
		return GetJointAccelerations_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref accelerations));
	}

	public unsafe static int GetJointForces_Injected(IntPtr _unity_self, ref BlittableListWrapper forces)
	{
		return GetJointForces_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref forces));
	}

	public unsafe static void SetJointForces_Injected(IntPtr _unity_self, ref BlittableListWrapper forces)
	{
		SetJointForces_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref forces));
	}

	public unsafe static int GetDriveForces_Injected(IntPtr _unity_self, ref BlittableListWrapper forces)
	{
		return GetDriveForces_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref forces));
	}

	public unsafe static int GetJointGravityForces_Injected(IntPtr _unity_self, ref BlittableListWrapper forces)
	{
		return GetJointGravityForces_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref forces));
	}

	public unsafe static int GetJointCoriolisCentrifugalForces_Injected(IntPtr _unity_self, ref BlittableListWrapper forces)
	{
		return GetJointCoriolisCentrifugalForces_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref forces));
	}

	public unsafe static int GetJointExternalForces_Injected(IntPtr _unity_self, ref BlittableListWrapper forces, float step)
	{
		return GetJointExternalForces_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref forces), step);
	}

	public unsafe static int GetDriveTargets_Injected(IntPtr _unity_self, ref BlittableListWrapper targets)
	{
		return GetDriveTargets_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref targets));
	}

	public unsafe static void SetDriveTargets_Injected(IntPtr _unity_self, ref BlittableListWrapper targets)
	{
		SetDriveTargets_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref targets));
	}

	public unsafe static int GetDriveTargetVelocities_Injected(IntPtr _unity_self, ref BlittableListWrapper targetVelocities)
	{
		return GetDriveTargetVelocities_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref targetVelocities));
	}

	public unsafe static void SetDriveTargetVelocities_Injected(IntPtr _unity_self, ref BlittableListWrapper targetVelocities)
	{
		SetDriveTargetVelocities_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref targetVelocities));
	}

	public unsafe static int GetDofStartIndices_Injected(IntPtr _unity_self, ref BlittableListWrapper dofStartIndices)
	{
		return GetDofStartIndices_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref dofStartIndices));
	}

	public static void SetDriveTarget_Injected(IntPtr _unity_self, ArticulationDriveAxis axis, float value)
	{
		SetDriveTarget_InjectedDelegateField(_unity_self, axis, value);
	}

	public static void SetDriveTargetVelocity_Injected(IntPtr _unity_self, ArticulationDriveAxis axis, float value)
	{
		SetDriveTargetVelocity_InjectedDelegateField(_unity_self, axis, value);
	}

	public static void SetDriveLimits_Injected(IntPtr _unity_self, ArticulationDriveAxis axis, float lower, float upper)
	{
		SetDriveLimits_InjectedDelegateField(_unity_self, axis, lower, upper);
	}

	public static void SetDriveStiffness_Injected(IntPtr _unity_self, ArticulationDriveAxis axis, float value)
	{
		SetDriveStiffness_InjectedDelegateField(_unity_self, axis, value);
	}

	public static void SetDriveDamping_Injected(IntPtr _unity_self, ArticulationDriveAxis axis, float value)
	{
		SetDriveDamping_InjectedDelegateField(_unity_self, axis, value);
	}

	public static void SetDriveForceLimit_Injected(IntPtr _unity_self, ArticulationDriveAxis axis, float value)
	{
		SetDriveForceLimit_InjectedDelegateField(_unity_self, axis, value);
	}

	public static CollisionDetectionMode get_collisionDetectionMode_Injected(IntPtr _unity_self)
	{
		return get_collisionDetectionMode_InjectedDelegateField(_unity_self);
	}

	public static void set_collisionDetectionMode_Injected(IntPtr _unity_self, CollisionDetectionMode value)
	{
		set_collisionDetectionMode_InjectedDelegateField(_unity_self, value);
	}

	public static void PublishTransform_Injected(IntPtr _unity_self)
	{
		PublishTransform_InjectedDelegateField(_unity_self);
	}

	public unsafe static void SetJointAccelerations_Injected(IntPtr _unity_self, ref BlittableListWrapper accelerations)
	{
		SetJointAccelerations_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref accelerations));
	}
}
