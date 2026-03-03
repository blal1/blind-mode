using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Bindings;

namespace UnityEngine;

public sealed class Cloth : Component
{
	private delegate void get_vertices_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr ret);

	private delegate void get_normals_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr ret);

	private delegate void get_coefficients_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr ret);

	private delegate void set_coefficients_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr value);

	private delegate System.IntPtr get_capsuleColliders_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_capsuleColliders_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr value);

	private delegate float get_sleepThreshold_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_sleepThreshold_InjectedDelegate(System.IntPtr _unity_self, float value);

	private delegate float get_bendingStiffness_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_bendingStiffness_InjectedDelegate(System.IntPtr _unity_self, float value);

	private delegate float get_stretchingStiffness_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_stretchingStiffness_InjectedDelegate(System.IntPtr _unity_self, float value);

	private delegate float get_damping_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_damping_InjectedDelegate(System.IntPtr _unity_self, float value);

	private delegate void get_externalAcceleration_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr ret);

	private delegate void set_externalAcceleration_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr value);

	private delegate void get_randomAcceleration_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr ret);

	private delegate void set_randomAcceleration_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr value);

	private delegate bool get_useGravity_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_useGravity_InjectedDelegate(System.IntPtr _unity_self, bool value);

	private delegate bool get_enabled_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_enabled_InjectedDelegate(System.IntPtr _unity_self, bool value);

	private delegate float get_friction_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_friction_InjectedDelegate(System.IntPtr _unity_self, float value);

	private delegate float get_collisionMassScale_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_collisionMassScale_InjectedDelegate(System.IntPtr _unity_self, float value);

	private delegate bool get_enableContinuousCollision_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_enableContinuousCollision_InjectedDelegate(System.IntPtr _unity_self, bool value);

	private delegate float get_useVirtualParticles_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_useVirtualParticles_InjectedDelegate(System.IntPtr _unity_self, float value);

	private delegate float get_worldVelocityScale_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_worldVelocityScale_InjectedDelegate(System.IntPtr _unity_self, float value);

	private delegate float get_worldAccelerationScale_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_worldAccelerationScale_InjectedDelegate(System.IntPtr _unity_self, float value);

	private delegate float get_clothSolverFrequency_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_clothSolverFrequency_InjectedDelegate(System.IntPtr _unity_self, float value);

	private delegate bool get_useTethers_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_useTethers_InjectedDelegate(System.IntPtr _unity_self, bool value);

	private delegate float get_stiffnessFrequency_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_stiffnessFrequency_InjectedDelegate(System.IntPtr _unity_self, float value);

	private delegate float get_selfCollisionDistance_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_selfCollisionDistance_InjectedDelegate(System.IntPtr _unity_self, float value);

	private delegate float get_selfCollisionStiffness_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_selfCollisionStiffness_InjectedDelegate(System.IntPtr _unity_self, float value);

	private delegate void ClearTransformMotion_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void GetSelfAndInterCollisionIndices_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr indices);

	private delegate void SetSelfAndInterCollisionIndices_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr indices);

	private delegate void GetVirtualParticleIndices_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr indicesOutList);

	private delegate void SetVirtualParticleIndices_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr indicesIn);

	private delegate void GetVirtualParticleWeights_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr weightsOutList);

	private delegate void SetVirtualParticleWeights_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr weights);

	private delegate void SetEnabledFading_InjectedDelegate(System.IntPtr _unity_self, bool enabled, float interpolationTime);

	private delegate void Raycast_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr ray, float maxDistance, System.IntPtr hasHit, [Out] System.IntPtr ret);

	private static readonly get_vertices_InjectedDelegate get_vertices_InjectedDelegateField = IL2CPP.ResolveICall<get_vertices_InjectedDelegate>("UnityEngine.Cloth::get_vertices_Injected");

	private static readonly get_normals_InjectedDelegate get_normals_InjectedDelegateField = IL2CPP.ResolveICall<get_normals_InjectedDelegate>("UnityEngine.Cloth::get_normals_Injected");

	private static readonly get_coefficients_InjectedDelegate get_coefficients_InjectedDelegateField = IL2CPP.ResolveICall<get_coefficients_InjectedDelegate>("UnityEngine.Cloth::get_coefficients_Injected");

	private static readonly set_coefficients_InjectedDelegate set_coefficients_InjectedDelegateField = IL2CPP.ResolveICall<set_coefficients_InjectedDelegate>("UnityEngine.Cloth::set_coefficients_Injected");

	private static readonly get_capsuleColliders_InjectedDelegate get_capsuleColliders_InjectedDelegateField = IL2CPP.ResolveICall<get_capsuleColliders_InjectedDelegate>("UnityEngine.Cloth::get_capsuleColliders_Injected");

	private static readonly set_capsuleColliders_InjectedDelegate set_capsuleColliders_InjectedDelegateField = IL2CPP.ResolveICall<set_capsuleColliders_InjectedDelegate>("UnityEngine.Cloth::set_capsuleColliders_Injected");

	private static readonly get_sleepThreshold_InjectedDelegate get_sleepThreshold_InjectedDelegateField = IL2CPP.ResolveICall<get_sleepThreshold_InjectedDelegate>("UnityEngine.Cloth::get_sleepThreshold_Injected");

	private static readonly set_sleepThreshold_InjectedDelegate set_sleepThreshold_InjectedDelegateField = IL2CPP.ResolveICall<set_sleepThreshold_InjectedDelegate>("UnityEngine.Cloth::set_sleepThreshold_Injected");

	private static readonly get_bendingStiffness_InjectedDelegate get_bendingStiffness_InjectedDelegateField = IL2CPP.ResolveICall<get_bendingStiffness_InjectedDelegate>("UnityEngine.Cloth::get_bendingStiffness_Injected");

	private static readonly set_bendingStiffness_InjectedDelegate set_bendingStiffness_InjectedDelegateField = IL2CPP.ResolveICall<set_bendingStiffness_InjectedDelegate>("UnityEngine.Cloth::set_bendingStiffness_Injected");

	private static readonly get_stretchingStiffness_InjectedDelegate get_stretchingStiffness_InjectedDelegateField = IL2CPP.ResolveICall<get_stretchingStiffness_InjectedDelegate>("UnityEngine.Cloth::get_stretchingStiffness_Injected");

	private static readonly set_stretchingStiffness_InjectedDelegate set_stretchingStiffness_InjectedDelegateField = IL2CPP.ResolveICall<set_stretchingStiffness_InjectedDelegate>("UnityEngine.Cloth::set_stretchingStiffness_Injected");

	private static readonly get_damping_InjectedDelegate get_damping_InjectedDelegateField = IL2CPP.ResolveICall<get_damping_InjectedDelegate>("UnityEngine.Cloth::get_damping_Injected");

	private static readonly set_damping_InjectedDelegate set_damping_InjectedDelegateField = IL2CPP.ResolveICall<set_damping_InjectedDelegate>("UnityEngine.Cloth::set_damping_Injected");

	private static readonly get_externalAcceleration_InjectedDelegate get_externalAcceleration_InjectedDelegateField = IL2CPP.ResolveICall<get_externalAcceleration_InjectedDelegate>("UnityEngine.Cloth::get_externalAcceleration_Injected");

	private static readonly set_externalAcceleration_InjectedDelegate set_externalAcceleration_InjectedDelegateField = IL2CPP.ResolveICall<set_externalAcceleration_InjectedDelegate>("UnityEngine.Cloth::set_externalAcceleration_Injected");

	private static readonly get_randomAcceleration_InjectedDelegate get_randomAcceleration_InjectedDelegateField = IL2CPP.ResolveICall<get_randomAcceleration_InjectedDelegate>("UnityEngine.Cloth::get_randomAcceleration_Injected");

	private static readonly set_randomAcceleration_InjectedDelegate set_randomAcceleration_InjectedDelegateField = IL2CPP.ResolveICall<set_randomAcceleration_InjectedDelegate>("UnityEngine.Cloth::set_randomAcceleration_Injected");

	private static readonly get_useGravity_InjectedDelegate get_useGravity_InjectedDelegateField = IL2CPP.ResolveICall<get_useGravity_InjectedDelegate>("UnityEngine.Cloth::get_useGravity_Injected");

	private static readonly set_useGravity_InjectedDelegate set_useGravity_InjectedDelegateField = IL2CPP.ResolveICall<set_useGravity_InjectedDelegate>("UnityEngine.Cloth::set_useGravity_Injected");

	private static readonly get_enabled_InjectedDelegate get_enabled_InjectedDelegateField = IL2CPP.ResolveICall<get_enabled_InjectedDelegate>("UnityEngine.Cloth::get_enabled_Injected");

	private static readonly set_enabled_InjectedDelegate set_enabled_InjectedDelegateField = IL2CPP.ResolveICall<set_enabled_InjectedDelegate>("UnityEngine.Cloth::set_enabled_Injected");

	private static readonly get_friction_InjectedDelegate get_friction_InjectedDelegateField = IL2CPP.ResolveICall<get_friction_InjectedDelegate>("UnityEngine.Cloth::get_friction_Injected");

	private static readonly set_friction_InjectedDelegate set_friction_InjectedDelegateField = IL2CPP.ResolveICall<set_friction_InjectedDelegate>("UnityEngine.Cloth::set_friction_Injected");

	private static readonly get_collisionMassScale_InjectedDelegate get_collisionMassScale_InjectedDelegateField = IL2CPP.ResolveICall<get_collisionMassScale_InjectedDelegate>("UnityEngine.Cloth::get_collisionMassScale_Injected");

	private static readonly set_collisionMassScale_InjectedDelegate set_collisionMassScale_InjectedDelegateField = IL2CPP.ResolveICall<set_collisionMassScale_InjectedDelegate>("UnityEngine.Cloth::set_collisionMassScale_Injected");

	private static readonly get_enableContinuousCollision_InjectedDelegate get_enableContinuousCollision_InjectedDelegateField = IL2CPP.ResolveICall<get_enableContinuousCollision_InjectedDelegate>("UnityEngine.Cloth::get_enableContinuousCollision_Injected");

	private static readonly set_enableContinuousCollision_InjectedDelegate set_enableContinuousCollision_InjectedDelegateField = IL2CPP.ResolveICall<set_enableContinuousCollision_InjectedDelegate>("UnityEngine.Cloth::set_enableContinuousCollision_Injected");

	private static readonly get_useVirtualParticles_InjectedDelegate get_useVirtualParticles_InjectedDelegateField = IL2CPP.ResolveICall<get_useVirtualParticles_InjectedDelegate>("UnityEngine.Cloth::get_useVirtualParticles_Injected");

	private static readonly set_useVirtualParticles_InjectedDelegate set_useVirtualParticles_InjectedDelegateField = IL2CPP.ResolveICall<set_useVirtualParticles_InjectedDelegate>("UnityEngine.Cloth::set_useVirtualParticles_Injected");

	private static readonly get_worldVelocityScale_InjectedDelegate get_worldVelocityScale_InjectedDelegateField = IL2CPP.ResolveICall<get_worldVelocityScale_InjectedDelegate>("UnityEngine.Cloth::get_worldVelocityScale_Injected");

	private static readonly set_worldVelocityScale_InjectedDelegate set_worldVelocityScale_InjectedDelegateField = IL2CPP.ResolveICall<set_worldVelocityScale_InjectedDelegate>("UnityEngine.Cloth::set_worldVelocityScale_Injected");

	private static readonly get_worldAccelerationScale_InjectedDelegate get_worldAccelerationScale_InjectedDelegateField = IL2CPP.ResolveICall<get_worldAccelerationScale_InjectedDelegate>("UnityEngine.Cloth::get_worldAccelerationScale_Injected");

	private static readonly set_worldAccelerationScale_InjectedDelegate set_worldAccelerationScale_InjectedDelegateField = IL2CPP.ResolveICall<set_worldAccelerationScale_InjectedDelegate>("UnityEngine.Cloth::set_worldAccelerationScale_Injected");

	private static readonly get_clothSolverFrequency_InjectedDelegate get_clothSolverFrequency_InjectedDelegateField = IL2CPP.ResolveICall<get_clothSolverFrequency_InjectedDelegate>("UnityEngine.Cloth::get_clothSolverFrequency_Injected");

	private static readonly set_clothSolverFrequency_InjectedDelegate set_clothSolverFrequency_InjectedDelegateField = IL2CPP.ResolveICall<set_clothSolverFrequency_InjectedDelegate>("UnityEngine.Cloth::set_clothSolverFrequency_Injected");

	private static readonly get_useTethers_InjectedDelegate get_useTethers_InjectedDelegateField = IL2CPP.ResolveICall<get_useTethers_InjectedDelegate>("UnityEngine.Cloth::get_useTethers_Injected");

	private static readonly set_useTethers_InjectedDelegate set_useTethers_InjectedDelegateField = IL2CPP.ResolveICall<set_useTethers_InjectedDelegate>("UnityEngine.Cloth::set_useTethers_Injected");

	private static readonly get_stiffnessFrequency_InjectedDelegate get_stiffnessFrequency_InjectedDelegateField = IL2CPP.ResolveICall<get_stiffnessFrequency_InjectedDelegate>("UnityEngine.Cloth::get_stiffnessFrequency_Injected");

	private static readonly set_stiffnessFrequency_InjectedDelegate set_stiffnessFrequency_InjectedDelegateField = IL2CPP.ResolveICall<set_stiffnessFrequency_InjectedDelegate>("UnityEngine.Cloth::set_stiffnessFrequency_Injected");

	private static readonly get_selfCollisionDistance_InjectedDelegate get_selfCollisionDistance_InjectedDelegateField = IL2CPP.ResolveICall<get_selfCollisionDistance_InjectedDelegate>("UnityEngine.Cloth::get_selfCollisionDistance_Injected");

	private static readonly set_selfCollisionDistance_InjectedDelegate set_selfCollisionDistance_InjectedDelegateField = IL2CPP.ResolveICall<set_selfCollisionDistance_InjectedDelegate>("UnityEngine.Cloth::set_selfCollisionDistance_Injected");

	private static readonly get_selfCollisionStiffness_InjectedDelegate get_selfCollisionStiffness_InjectedDelegateField = IL2CPP.ResolveICall<get_selfCollisionStiffness_InjectedDelegate>("UnityEngine.Cloth::get_selfCollisionStiffness_Injected");

	private static readonly set_selfCollisionStiffness_InjectedDelegate set_selfCollisionStiffness_InjectedDelegateField = IL2CPP.ResolveICall<set_selfCollisionStiffness_InjectedDelegate>("UnityEngine.Cloth::set_selfCollisionStiffness_Injected");

	private static readonly ClearTransformMotion_InjectedDelegate ClearTransformMotion_InjectedDelegateField = IL2CPP.ResolveICall<ClearTransformMotion_InjectedDelegate>("UnityEngine.Cloth::ClearTransformMotion_Injected");

	private static readonly GetSelfAndInterCollisionIndices_InjectedDelegate GetSelfAndInterCollisionIndices_InjectedDelegateField = IL2CPP.ResolveICall<GetSelfAndInterCollisionIndices_InjectedDelegate>("UnityEngine.Cloth::GetSelfAndInterCollisionIndices_Injected");

	private static readonly SetSelfAndInterCollisionIndices_InjectedDelegate SetSelfAndInterCollisionIndices_InjectedDelegateField = IL2CPP.ResolveICall<SetSelfAndInterCollisionIndices_InjectedDelegate>("UnityEngine.Cloth::SetSelfAndInterCollisionIndices_Injected");

	private static readonly GetVirtualParticleIndices_InjectedDelegate GetVirtualParticleIndices_InjectedDelegateField = IL2CPP.ResolveICall<GetVirtualParticleIndices_InjectedDelegate>("UnityEngine.Cloth::GetVirtualParticleIndices_Injected");

	private static readonly SetVirtualParticleIndices_InjectedDelegate SetVirtualParticleIndices_InjectedDelegateField = IL2CPP.ResolveICall<SetVirtualParticleIndices_InjectedDelegate>("UnityEngine.Cloth::SetVirtualParticleIndices_Injected");

	private static readonly GetVirtualParticleWeights_InjectedDelegate GetVirtualParticleWeights_InjectedDelegateField = IL2CPP.ResolveICall<GetVirtualParticleWeights_InjectedDelegate>("UnityEngine.Cloth::GetVirtualParticleWeights_Injected");

	private static readonly SetVirtualParticleWeights_InjectedDelegate SetVirtualParticleWeights_InjectedDelegateField = IL2CPP.ResolveICall<SetVirtualParticleWeights_InjectedDelegate>("UnityEngine.Cloth::SetVirtualParticleWeights_Injected");

	private static readonly SetEnabledFading_InjectedDelegate SetEnabledFading_InjectedDelegateField = IL2CPP.ResolveICall<SetEnabledFading_InjectedDelegate>("UnityEngine.Cloth::SetEnabledFading_Injected");

	private static readonly Raycast_InjectedDelegate Raycast_InjectedDelegateField = IL2CPP.ResolveICall<Raycast_InjectedDelegate>("UnityEngine.Cloth::Raycast_Injected");

	public unsafe Il2CppStructArray<Vector3> vertices
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out BlittableArrayWrapper ret);
			Il2CppStructArray<Vector3> result;
			try
			{
				System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
				if (intPtr == (System.IntPtr)0)
				{
					ThrowHelper.ThrowNullReferenceException(this);
				}
				get_vertices_Injected(intPtr, out ret);
			}
			finally
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out Il2CppStructArray<Vector3> array);
				ret.Unmarshal(ref *(Il2CppArrayBase<Vector3>*)(&array));
				result = array;
			}
			return result;
		}
	}

	public unsafe Il2CppStructArray<Vector3> normals
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out BlittableArrayWrapper ret);
			Il2CppStructArray<Vector3> result;
			try
			{
				System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
				if (intPtr == (System.IntPtr)0)
				{
					ThrowHelper.ThrowNullReferenceException(this);
				}
				get_normals_Injected(intPtr, out ret);
			}
			finally
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out Il2CppStructArray<Vector3> array);
				ret.Unmarshal(ref *(Il2CppArrayBase<Vector3>*)(&array));
				result = array;
			}
			return result;
		}
	}

	public Il2CppReferenceArray<CapsuleCollider> capsuleColliders
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_capsuleColliders_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_capsuleColliders_Injected(intPtr, value);
		}
	}

	public float sleepThreshold
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_sleepThreshold_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_sleepThreshold_Injected(intPtr, value);
		}
	}

	public float bendingStiffness
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_bendingStiffness_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_bendingStiffness_Injected(intPtr, value);
		}
	}

	public float stretchingStiffness
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_stretchingStiffness_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_stretchingStiffness_Injected(intPtr, value);
		}
	}

	public float damping
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_damping_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_damping_Injected(intPtr, value);
		}
	}

	public Vector3 externalAcceleration
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			get_externalAcceleration_Injected(intPtr, out var ret);
			return ret;
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_externalAcceleration_Injected(intPtr, ref value);
		}
	}

	public Vector3 randomAcceleration
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			get_randomAcceleration_Injected(intPtr, out var ret);
			return ret;
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_randomAcceleration_Injected(intPtr, ref value);
		}
	}

	public bool useGravity
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_useGravity_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_useGravity_Injected(intPtr, value);
		}
	}

	public bool enabled
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_enabled_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_enabled_Injected(intPtr, value);
		}
	}

	public float friction
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_friction_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_friction_Injected(intPtr, value);
		}
	}

	public float collisionMassScale
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_collisionMassScale_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_collisionMassScale_Injected(intPtr, value);
		}
	}

	public bool enableContinuousCollision
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_enableContinuousCollision_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_enableContinuousCollision_Injected(intPtr, value);
		}
	}

	public float useVirtualParticles
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_useVirtualParticles_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_useVirtualParticles_Injected(intPtr, value);
		}
	}

	public float worldVelocityScale
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_worldVelocityScale_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_worldVelocityScale_Injected(intPtr, value);
		}
	}

	public float worldAccelerationScale
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_worldAccelerationScale_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_worldAccelerationScale_Injected(intPtr, value);
		}
	}

	public float clothSolverFrequency
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_clothSolverFrequency_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_clothSolverFrequency_Injected(intPtr, value);
		}
	}

	public bool solverFrequency
	{
		get
		{
			return clothSolverFrequency > 0f;
		}
		set
		{
			clothSolverFrequency = (value ? 120f : 0f);
		}
	}

	public bool useTethers
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_useTethers_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_useTethers_Injected(intPtr, value);
		}
	}

	public float stiffnessFrequency
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_stiffnessFrequency_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_stiffnessFrequency_Injected(intPtr, value);
		}
	}

	public float selfCollisionDistance
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_selfCollisionDistance_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_selfCollisionDistance_Injected(intPtr, value);
		}
	}

	public float selfCollisionStiffness
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_selfCollisionStiffness_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_selfCollisionStiffness_Injected(intPtr, value);
		}
	}

	public float useContinuousCollision
	{
		get
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			throw new NotSupportedException("Method unstripping failed");
		}
		set
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			throw new NotSupportedException("Method unstripping failed");
		}
	}

	public bool selfCollision
	{
		get
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			throw new NotSupportedException("Method unstripping failed");
		}
	}

	public void ClearTransformMotion()
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			ThrowHelper.ThrowNullReferenceException(this);
		}
		ClearTransformMotion_Injected(intPtr);
	}

	public void GetSelfAndInterCollisionIndices(List<uint> indices)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		throw new NotSupportedException("Method unstripping failed");
	}

	public void SetSelfAndInterCollisionIndices(List<uint> indices)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		throw new NotSupportedException("Method unstripping failed");
	}

	public void GetVirtualParticleIndices(List<uint> indicesOutList)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		throw new NotSupportedException("Method unstripping failed");
	}

	public void SetVirtualParticleIndices(List<uint> indicesIn)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		throw new NotSupportedException("Method unstripping failed");
	}

	public void GetVirtualParticleWeights(List<Vector3> weightsOutList)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		throw new NotSupportedException("Method unstripping failed");
	}

	public void SetVirtualParticleWeights(List<Vector3> weights)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		throw new NotSupportedException("Method unstripping failed");
	}

	public void SetEnabledFading(bool enabled, float interpolationTime)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			ThrowHelper.ThrowNullReferenceException(this);
		}
		SetEnabledFading_Injected(intPtr, enabled, interpolationTime);
	}

	public void SetEnabledFading(bool enabled)
	{
		SetEnabledFading(enabled, 0.5f);
	}

	public RaycastHit Raycast(Ray ray, float maxDistance, ref bool hasHit)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			ThrowHelper.ThrowNullReferenceException(this);
		}
		Raycast_Injected(intPtr, ref ray, maxDistance, ref hasHit, out var ret);
		return ret;
	}

	public unsafe static void get_vertices_Injected(System.IntPtr _unity_self, out BlittableArrayWrapper ret)
	{
		get_vertices_InjectedDelegateField(_unity_self, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref ret));
	}

	public unsafe static void get_normals_Injected(System.IntPtr _unity_self, out BlittableArrayWrapper ret)
	{
		get_normals_InjectedDelegateField(_unity_self, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref ret));
	}

	public unsafe static void get_coefficients_Injected(System.IntPtr _unity_self, out BlittableArrayWrapper ret)
	{
		get_coefficients_InjectedDelegateField(_unity_self, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref ret));
	}

	public unsafe static void set_coefficients_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper value)
	{
		set_coefficients_InjectedDelegateField(_unity_self, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref value));
	}

	public static Il2CppReferenceArray<CapsuleCollider> get_capsuleColliders_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr intPtr = get_capsuleColliders_InjectedDelegateField(_unity_self);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CapsuleCollider>>(intPtr) : null;
	}

	public static void set_capsuleColliders_Injected(System.IntPtr _unity_self, Il2CppReferenceArray<CapsuleCollider> value)
	{
		set_capsuleColliders_InjectedDelegateField(_unity_self, IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
	}

	public static float get_sleepThreshold_Injected(System.IntPtr _unity_self)
	{
		return get_sleepThreshold_InjectedDelegateField(_unity_self);
	}

	public static void set_sleepThreshold_Injected(System.IntPtr _unity_self, float value)
	{
		set_sleepThreshold_InjectedDelegateField(_unity_self, value);
	}

	public static float get_bendingStiffness_Injected(System.IntPtr _unity_self)
	{
		return get_bendingStiffness_InjectedDelegateField(_unity_self);
	}

	public static void set_bendingStiffness_Injected(System.IntPtr _unity_self, float value)
	{
		set_bendingStiffness_InjectedDelegateField(_unity_self, value);
	}

	public static float get_stretchingStiffness_Injected(System.IntPtr _unity_self)
	{
		return get_stretchingStiffness_InjectedDelegateField(_unity_self);
	}

	public static void set_stretchingStiffness_Injected(System.IntPtr _unity_self, float value)
	{
		set_stretchingStiffness_InjectedDelegateField(_unity_self, value);
	}

	public static float get_damping_Injected(System.IntPtr _unity_self)
	{
		return get_damping_InjectedDelegateField(_unity_self);
	}

	public static void set_damping_Injected(System.IntPtr _unity_self, float value)
	{
		set_damping_InjectedDelegateField(_unity_self, value);
	}

	public unsafe static void get_externalAcceleration_Injected(System.IntPtr _unity_self, out Vector3 ret)
	{
		get_externalAcceleration_InjectedDelegateField(_unity_self, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref ret));
	}

	public unsafe static void set_externalAcceleration_Injected(System.IntPtr _unity_self, [In] ref Vector3 value)
	{
		set_externalAcceleration_InjectedDelegateField(_unity_self, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref value));
	}

	public unsafe static void get_randomAcceleration_Injected(System.IntPtr _unity_self, out Vector3 ret)
	{
		get_randomAcceleration_InjectedDelegateField(_unity_self, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref ret));
	}

	public unsafe static void set_randomAcceleration_Injected(System.IntPtr _unity_self, [In] ref Vector3 value)
	{
		set_randomAcceleration_InjectedDelegateField(_unity_self, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref value));
	}

	public static bool get_useGravity_Injected(System.IntPtr _unity_self)
	{
		return get_useGravity_InjectedDelegateField(_unity_self);
	}

	public static void set_useGravity_Injected(System.IntPtr _unity_self, bool value)
	{
		set_useGravity_InjectedDelegateField(_unity_self, value);
	}

	public static bool get_enabled_Injected(System.IntPtr _unity_self)
	{
		return get_enabled_InjectedDelegateField(_unity_self);
	}

	public static void set_enabled_Injected(System.IntPtr _unity_self, bool value)
	{
		set_enabled_InjectedDelegateField(_unity_self, value);
	}

	public static float get_friction_Injected(System.IntPtr _unity_self)
	{
		return get_friction_InjectedDelegateField(_unity_self);
	}

	public static void set_friction_Injected(System.IntPtr _unity_self, float value)
	{
		set_friction_InjectedDelegateField(_unity_self, value);
	}

	public static float get_collisionMassScale_Injected(System.IntPtr _unity_self)
	{
		return get_collisionMassScale_InjectedDelegateField(_unity_self);
	}

	public static void set_collisionMassScale_Injected(System.IntPtr _unity_self, float value)
	{
		set_collisionMassScale_InjectedDelegateField(_unity_self, value);
	}

	public static bool get_enableContinuousCollision_Injected(System.IntPtr _unity_self)
	{
		return get_enableContinuousCollision_InjectedDelegateField(_unity_self);
	}

	public static void set_enableContinuousCollision_Injected(System.IntPtr _unity_self, bool value)
	{
		set_enableContinuousCollision_InjectedDelegateField(_unity_self, value);
	}

	public static float get_useVirtualParticles_Injected(System.IntPtr _unity_self)
	{
		return get_useVirtualParticles_InjectedDelegateField(_unity_self);
	}

	public static void set_useVirtualParticles_Injected(System.IntPtr _unity_self, float value)
	{
		set_useVirtualParticles_InjectedDelegateField(_unity_self, value);
	}

	public static float get_worldVelocityScale_Injected(System.IntPtr _unity_self)
	{
		return get_worldVelocityScale_InjectedDelegateField(_unity_self);
	}

	public static void set_worldVelocityScale_Injected(System.IntPtr _unity_self, float value)
	{
		set_worldVelocityScale_InjectedDelegateField(_unity_self, value);
	}

	public static float get_worldAccelerationScale_Injected(System.IntPtr _unity_self)
	{
		return get_worldAccelerationScale_InjectedDelegateField(_unity_self);
	}

	public static void set_worldAccelerationScale_Injected(System.IntPtr _unity_self, float value)
	{
		set_worldAccelerationScale_InjectedDelegateField(_unity_self, value);
	}

	public static float get_clothSolverFrequency_Injected(System.IntPtr _unity_self)
	{
		return get_clothSolverFrequency_InjectedDelegateField(_unity_self);
	}

	public static void set_clothSolverFrequency_Injected(System.IntPtr _unity_self, float value)
	{
		set_clothSolverFrequency_InjectedDelegateField(_unity_self, value);
	}

	public static bool get_useTethers_Injected(System.IntPtr _unity_self)
	{
		return get_useTethers_InjectedDelegateField(_unity_self);
	}

	public static void set_useTethers_Injected(System.IntPtr _unity_self, bool value)
	{
		set_useTethers_InjectedDelegateField(_unity_self, value);
	}

	public static float get_stiffnessFrequency_Injected(System.IntPtr _unity_self)
	{
		return get_stiffnessFrequency_InjectedDelegateField(_unity_self);
	}

	public static void set_stiffnessFrequency_Injected(System.IntPtr _unity_self, float value)
	{
		set_stiffnessFrequency_InjectedDelegateField(_unity_self, value);
	}

	public static float get_selfCollisionDistance_Injected(System.IntPtr _unity_self)
	{
		return get_selfCollisionDistance_InjectedDelegateField(_unity_self);
	}

	public static void set_selfCollisionDistance_Injected(System.IntPtr _unity_self, float value)
	{
		set_selfCollisionDistance_InjectedDelegateField(_unity_self, value);
	}

	public static float get_selfCollisionStiffness_Injected(System.IntPtr _unity_self)
	{
		return get_selfCollisionStiffness_InjectedDelegateField(_unity_self);
	}

	public static void set_selfCollisionStiffness_Injected(System.IntPtr _unity_self, float value)
	{
		set_selfCollisionStiffness_InjectedDelegateField(_unity_self, value);
	}

	public static void ClearTransformMotion_Injected(System.IntPtr _unity_self)
	{
		ClearTransformMotion_InjectedDelegateField(_unity_self);
	}

	public unsafe static void GetSelfAndInterCollisionIndices_Injected(System.IntPtr _unity_self, ref BlittableListWrapper indices)
	{
		GetSelfAndInterCollisionIndices_InjectedDelegateField(_unity_self, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref indices));
	}

	public unsafe static void SetSelfAndInterCollisionIndices_Injected(System.IntPtr _unity_self, ref BlittableListWrapper indices)
	{
		SetSelfAndInterCollisionIndices_InjectedDelegateField(_unity_self, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref indices));
	}

	public unsafe static void GetVirtualParticleIndices_Injected(System.IntPtr _unity_self, ref BlittableListWrapper indicesOutList)
	{
		GetVirtualParticleIndices_InjectedDelegateField(_unity_self, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref indicesOutList));
	}

	public unsafe static void SetVirtualParticleIndices_Injected(System.IntPtr _unity_self, ref BlittableListWrapper indicesIn)
	{
		SetVirtualParticleIndices_InjectedDelegateField(_unity_self, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref indicesIn));
	}

	public unsafe static void GetVirtualParticleWeights_Injected(System.IntPtr _unity_self, ref BlittableListWrapper weightsOutList)
	{
		GetVirtualParticleWeights_InjectedDelegateField(_unity_self, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref weightsOutList));
	}

	public unsafe static void SetVirtualParticleWeights_Injected(System.IntPtr _unity_self, ref BlittableListWrapper weights)
	{
		SetVirtualParticleWeights_InjectedDelegateField(_unity_self, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref weights));
	}

	public static void SetEnabledFading_Injected(System.IntPtr _unity_self, bool enabled, float interpolationTime)
	{
		SetEnabledFading_InjectedDelegateField(_unity_self, enabled, interpolationTime);
	}

	public unsafe static void Raycast_Injected(System.IntPtr _unity_self, [In] ref Ray ray, float maxDistance, ref bool hasHit, out RaycastHit ret)
	{
		Raycast_InjectedDelegateField(_unity_self, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref ray), maxDistance, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref hasHit), (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref ret));
	}
}
