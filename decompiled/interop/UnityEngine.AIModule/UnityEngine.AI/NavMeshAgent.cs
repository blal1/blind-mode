using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.Bindings;

namespace UnityEngine.AI;

public sealed class NavMeshAgent : Behaviour
{
	private delegate bool SetDestination_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr target);

	private delegate void get_destination_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr ret);

	private delegate void set_destination_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr value);

	private delegate float get_stoppingDistance_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_stoppingDistance_InjectedDelegate(System.IntPtr _unity_self, float value);

	private delegate void get_velocity_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr ret);

	private delegate void set_velocity_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr value);

	private delegate void get_nextPosition_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr ret);

	private delegate void set_nextPosition_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr value);

	private delegate void get_steeringTarget_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr ret);

	private delegate void get_desiredVelocity_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr ret);

	private delegate float get_remainingDistance_InjectedDelegate(System.IntPtr _unity_self);

	private delegate float get_baseOffset_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_baseOffset_InjectedDelegate(System.IntPtr _unity_self, float value);

	private delegate bool get_isOnOffMeshLink_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void ActivateCurrentOffMeshLink_InjectedDelegate(System.IntPtr _unity_self, bool activated);

	private delegate void CompleteOffMeshLink_InjectedDelegate(System.IntPtr _unity_self);

	private delegate bool get_autoTraverseOffMeshLink_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_autoTraverseOffMeshLink_InjectedDelegate(System.IntPtr _unity_self, bool value);

	private delegate bool get_autoBraking_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_autoBraking_InjectedDelegate(System.IntPtr _unity_self, bool value);

	private delegate bool get_autoRepath_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_autoRepath_InjectedDelegate(System.IntPtr _unity_self, bool value);

	private delegate bool get_hasPath_InjectedDelegate(System.IntPtr _unity_self);

	private delegate bool get_pathPending_InjectedDelegate(System.IntPtr _unity_self);

	private delegate bool get_isPathStale_InjectedDelegate(System.IntPtr _unity_self);

	private delegate NavMeshPathStatus get_pathStatus_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void get_pathEndPosition_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr ret);

	private delegate bool Warp_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr newPosition);

	private delegate void Move_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr offset);

	private delegate void Stop_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void Resume_InjectedDelegate(System.IntPtr _unity_self);

	private delegate bool get_isStopped_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_isStopped_InjectedDelegate(System.IntPtr _unity_self, bool value);

	private delegate void ResetPath_InjectedDelegate(System.IntPtr _unity_self);

	private delegate bool SetPath_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr path);

	private delegate void CopyPathTo_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr path);

	private delegate bool CalculatePathInternal_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr targetPosition, System.IntPtr path);

	private delegate void SetLayerCost_InjectedDelegate(System.IntPtr _unity_self, int layer, float cost);

	private delegate float GetLayerCost_InjectedDelegate(System.IntPtr _unity_self, int layer);

	private delegate void SetAreaCost_InjectedDelegate(System.IntPtr _unity_self, int areaIndex, float areaCost);

	private delegate float GetAreaCost_InjectedDelegate(System.IntPtr _unity_self, int areaIndex);

	private delegate int get_agentTypeID_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_agentTypeID_InjectedDelegate(System.IntPtr _unity_self, int value);

	private delegate System.IntPtr GetOwnerInternal_InjectedDelegate(System.IntPtr _unity_self);

	private delegate int get_areaMask_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_areaMask_InjectedDelegate(System.IntPtr _unity_self, int value);

	private delegate float get_speed_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_speed_InjectedDelegate(System.IntPtr _unity_self, float value);

	private delegate float get_angularSpeed_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_angularSpeed_InjectedDelegate(System.IntPtr _unity_self, float value);

	private delegate float get_acceleration_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_acceleration_InjectedDelegate(System.IntPtr _unity_self, float value);

	private delegate bool get_updatePosition_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_updatePosition_InjectedDelegate(System.IntPtr _unity_self, bool value);

	private delegate bool get_updateRotation_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_updateRotation_InjectedDelegate(System.IntPtr _unity_self, bool value);

	private delegate bool get_updateUpAxis_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_updateUpAxis_InjectedDelegate(System.IntPtr _unity_self, bool value);

	private delegate float get_radius_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_radius_InjectedDelegate(System.IntPtr _unity_self, float value);

	private delegate float get_height_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_height_InjectedDelegate(System.IntPtr _unity_self, float value);

	private delegate ObstacleAvoidanceType get_obstacleAvoidanceType_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_obstacleAvoidanceType_InjectedDelegate(System.IntPtr _unity_self, ObstacleAvoidanceType value);

	private delegate int get_avoidancePriority_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_avoidancePriority_InjectedDelegate(System.IntPtr _unity_self, int value);

	private delegate bool get_isOnNavMesh_InjectedDelegate(System.IntPtr _unity_self);

	private static readonly SetDestination_InjectedDelegate SetDestination_InjectedDelegateField = IL2CPP.ResolveICall<SetDestination_InjectedDelegate>("UnityEngine.AI.NavMeshAgent::SetDestination_Injected");

	private static readonly get_destination_InjectedDelegate get_destination_InjectedDelegateField = IL2CPP.ResolveICall<get_destination_InjectedDelegate>("UnityEngine.AI.NavMeshAgent::get_destination_Injected");

	private static readonly set_destination_InjectedDelegate set_destination_InjectedDelegateField = IL2CPP.ResolveICall<set_destination_InjectedDelegate>("UnityEngine.AI.NavMeshAgent::set_destination_Injected");

	private static readonly get_stoppingDistance_InjectedDelegate get_stoppingDistance_InjectedDelegateField = IL2CPP.ResolveICall<get_stoppingDistance_InjectedDelegate>("UnityEngine.AI.NavMeshAgent::get_stoppingDistance_Injected");

	private static readonly set_stoppingDistance_InjectedDelegate set_stoppingDistance_InjectedDelegateField = IL2CPP.ResolveICall<set_stoppingDistance_InjectedDelegate>("UnityEngine.AI.NavMeshAgent::set_stoppingDistance_Injected");

	private static readonly get_velocity_InjectedDelegate get_velocity_InjectedDelegateField = IL2CPP.ResolveICall<get_velocity_InjectedDelegate>("UnityEngine.AI.NavMeshAgent::get_velocity_Injected");

	private static readonly set_velocity_InjectedDelegate set_velocity_InjectedDelegateField = IL2CPP.ResolveICall<set_velocity_InjectedDelegate>("UnityEngine.AI.NavMeshAgent::set_velocity_Injected");

	private static readonly get_nextPosition_InjectedDelegate get_nextPosition_InjectedDelegateField = IL2CPP.ResolveICall<get_nextPosition_InjectedDelegate>("UnityEngine.AI.NavMeshAgent::get_nextPosition_Injected");

	private static readonly set_nextPosition_InjectedDelegate set_nextPosition_InjectedDelegateField = IL2CPP.ResolveICall<set_nextPosition_InjectedDelegate>("UnityEngine.AI.NavMeshAgent::set_nextPosition_Injected");

	private static readonly get_steeringTarget_InjectedDelegate get_steeringTarget_InjectedDelegateField = IL2CPP.ResolveICall<get_steeringTarget_InjectedDelegate>("UnityEngine.AI.NavMeshAgent::get_steeringTarget_Injected");

	private static readonly get_desiredVelocity_InjectedDelegate get_desiredVelocity_InjectedDelegateField = IL2CPP.ResolveICall<get_desiredVelocity_InjectedDelegate>("UnityEngine.AI.NavMeshAgent::get_desiredVelocity_Injected");

	private static readonly get_remainingDistance_InjectedDelegate get_remainingDistance_InjectedDelegateField = IL2CPP.ResolveICall<get_remainingDistance_InjectedDelegate>("UnityEngine.AI.NavMeshAgent::get_remainingDistance_Injected");

	private static readonly get_baseOffset_InjectedDelegate get_baseOffset_InjectedDelegateField = IL2CPP.ResolveICall<get_baseOffset_InjectedDelegate>("UnityEngine.AI.NavMeshAgent::get_baseOffset_Injected");

	private static readonly set_baseOffset_InjectedDelegate set_baseOffset_InjectedDelegateField = IL2CPP.ResolveICall<set_baseOffset_InjectedDelegate>("UnityEngine.AI.NavMeshAgent::set_baseOffset_Injected");

	private static readonly get_isOnOffMeshLink_InjectedDelegate get_isOnOffMeshLink_InjectedDelegateField = IL2CPP.ResolveICall<get_isOnOffMeshLink_InjectedDelegate>("UnityEngine.AI.NavMeshAgent::get_isOnOffMeshLink_Injected");

	private static readonly ActivateCurrentOffMeshLink_InjectedDelegate ActivateCurrentOffMeshLink_InjectedDelegateField = IL2CPP.ResolveICall<ActivateCurrentOffMeshLink_InjectedDelegate>("UnityEngine.AI.NavMeshAgent::ActivateCurrentOffMeshLink_Injected");

	private static readonly CompleteOffMeshLink_InjectedDelegate CompleteOffMeshLink_InjectedDelegateField = IL2CPP.ResolveICall<CompleteOffMeshLink_InjectedDelegate>("UnityEngine.AI.NavMeshAgent::CompleteOffMeshLink_Injected");

	private static readonly get_autoTraverseOffMeshLink_InjectedDelegate get_autoTraverseOffMeshLink_InjectedDelegateField = IL2CPP.ResolveICall<get_autoTraverseOffMeshLink_InjectedDelegate>("UnityEngine.AI.NavMeshAgent::get_autoTraverseOffMeshLink_Injected");

	private static readonly set_autoTraverseOffMeshLink_InjectedDelegate set_autoTraverseOffMeshLink_InjectedDelegateField = IL2CPP.ResolveICall<set_autoTraverseOffMeshLink_InjectedDelegate>("UnityEngine.AI.NavMeshAgent::set_autoTraverseOffMeshLink_Injected");

	private static readonly get_autoBraking_InjectedDelegate get_autoBraking_InjectedDelegateField = IL2CPP.ResolveICall<get_autoBraking_InjectedDelegate>("UnityEngine.AI.NavMeshAgent::get_autoBraking_Injected");

	private static readonly set_autoBraking_InjectedDelegate set_autoBraking_InjectedDelegateField = IL2CPP.ResolveICall<set_autoBraking_InjectedDelegate>("UnityEngine.AI.NavMeshAgent::set_autoBraking_Injected");

	private static readonly get_autoRepath_InjectedDelegate get_autoRepath_InjectedDelegateField = IL2CPP.ResolveICall<get_autoRepath_InjectedDelegate>("UnityEngine.AI.NavMeshAgent::get_autoRepath_Injected");

	private static readonly set_autoRepath_InjectedDelegate set_autoRepath_InjectedDelegateField = IL2CPP.ResolveICall<set_autoRepath_InjectedDelegate>("UnityEngine.AI.NavMeshAgent::set_autoRepath_Injected");

	private static readonly get_hasPath_InjectedDelegate get_hasPath_InjectedDelegateField = IL2CPP.ResolveICall<get_hasPath_InjectedDelegate>("UnityEngine.AI.NavMeshAgent::get_hasPath_Injected");

	private static readonly get_pathPending_InjectedDelegate get_pathPending_InjectedDelegateField = IL2CPP.ResolveICall<get_pathPending_InjectedDelegate>("UnityEngine.AI.NavMeshAgent::get_pathPending_Injected");

	private static readonly get_isPathStale_InjectedDelegate get_isPathStale_InjectedDelegateField = IL2CPP.ResolveICall<get_isPathStale_InjectedDelegate>("UnityEngine.AI.NavMeshAgent::get_isPathStale_Injected");

	private static readonly get_pathStatus_InjectedDelegate get_pathStatus_InjectedDelegateField = IL2CPP.ResolveICall<get_pathStatus_InjectedDelegate>("UnityEngine.AI.NavMeshAgent::get_pathStatus_Injected");

	private static readonly get_pathEndPosition_InjectedDelegate get_pathEndPosition_InjectedDelegateField = IL2CPP.ResolveICall<get_pathEndPosition_InjectedDelegate>("UnityEngine.AI.NavMeshAgent::get_pathEndPosition_Injected");

	private static readonly Warp_InjectedDelegate Warp_InjectedDelegateField = IL2CPP.ResolveICall<Warp_InjectedDelegate>("UnityEngine.AI.NavMeshAgent::Warp_Injected");

	private static readonly Move_InjectedDelegate Move_InjectedDelegateField = IL2CPP.ResolveICall<Move_InjectedDelegate>("UnityEngine.AI.NavMeshAgent::Move_Injected");

	private static readonly Stop_InjectedDelegate Stop_InjectedDelegateField = IL2CPP.ResolveICall<Stop_InjectedDelegate>("UnityEngine.AI.NavMeshAgent::Stop_Injected");

	private static readonly Resume_InjectedDelegate Resume_InjectedDelegateField = IL2CPP.ResolveICall<Resume_InjectedDelegate>("UnityEngine.AI.NavMeshAgent::Resume_Injected");

	private static readonly get_isStopped_InjectedDelegate get_isStopped_InjectedDelegateField = IL2CPP.ResolveICall<get_isStopped_InjectedDelegate>("UnityEngine.AI.NavMeshAgent::get_isStopped_Injected");

	private static readonly set_isStopped_InjectedDelegate set_isStopped_InjectedDelegateField = IL2CPP.ResolveICall<set_isStopped_InjectedDelegate>("UnityEngine.AI.NavMeshAgent::set_isStopped_Injected");

	private static readonly ResetPath_InjectedDelegate ResetPath_InjectedDelegateField = IL2CPP.ResolveICall<ResetPath_InjectedDelegate>("UnityEngine.AI.NavMeshAgent::ResetPath_Injected");

	private static readonly SetPath_InjectedDelegate SetPath_InjectedDelegateField = IL2CPP.ResolveICall<SetPath_InjectedDelegate>("UnityEngine.AI.NavMeshAgent::SetPath_Injected");

	private static readonly CopyPathTo_InjectedDelegate CopyPathTo_InjectedDelegateField = IL2CPP.ResolveICall<CopyPathTo_InjectedDelegate>("UnityEngine.AI.NavMeshAgent::CopyPathTo_Injected");

	private static readonly CalculatePathInternal_InjectedDelegate CalculatePathInternal_InjectedDelegateField = IL2CPP.ResolveICall<CalculatePathInternal_InjectedDelegate>("UnityEngine.AI.NavMeshAgent::CalculatePathInternal_Injected");

	private static readonly SetLayerCost_InjectedDelegate SetLayerCost_InjectedDelegateField = IL2CPP.ResolveICall<SetLayerCost_InjectedDelegate>("UnityEngine.AI.NavMeshAgent::SetLayerCost_Injected");

	private static readonly GetLayerCost_InjectedDelegate GetLayerCost_InjectedDelegateField = IL2CPP.ResolveICall<GetLayerCost_InjectedDelegate>("UnityEngine.AI.NavMeshAgent::GetLayerCost_Injected");

	private static readonly SetAreaCost_InjectedDelegate SetAreaCost_InjectedDelegateField = IL2CPP.ResolveICall<SetAreaCost_InjectedDelegate>("UnityEngine.AI.NavMeshAgent::SetAreaCost_Injected");

	private static readonly GetAreaCost_InjectedDelegate GetAreaCost_InjectedDelegateField = IL2CPP.ResolveICall<GetAreaCost_InjectedDelegate>("UnityEngine.AI.NavMeshAgent::GetAreaCost_Injected");

	private static readonly get_agentTypeID_InjectedDelegate get_agentTypeID_InjectedDelegateField = IL2CPP.ResolveICall<get_agentTypeID_InjectedDelegate>("UnityEngine.AI.NavMeshAgent::get_agentTypeID_Injected");

	private static readonly set_agentTypeID_InjectedDelegate set_agentTypeID_InjectedDelegateField = IL2CPP.ResolveICall<set_agentTypeID_InjectedDelegate>("UnityEngine.AI.NavMeshAgent::set_agentTypeID_Injected");

	private static readonly GetOwnerInternal_InjectedDelegate GetOwnerInternal_InjectedDelegateField = IL2CPP.ResolveICall<GetOwnerInternal_InjectedDelegate>("UnityEngine.AI.NavMeshAgent::GetOwnerInternal_Injected");

	private static readonly get_areaMask_InjectedDelegate get_areaMask_InjectedDelegateField = IL2CPP.ResolveICall<get_areaMask_InjectedDelegate>("UnityEngine.AI.NavMeshAgent::get_areaMask_Injected");

	private static readonly set_areaMask_InjectedDelegate set_areaMask_InjectedDelegateField = IL2CPP.ResolveICall<set_areaMask_InjectedDelegate>("UnityEngine.AI.NavMeshAgent::set_areaMask_Injected");

	private static readonly get_speed_InjectedDelegate get_speed_InjectedDelegateField = IL2CPP.ResolveICall<get_speed_InjectedDelegate>("UnityEngine.AI.NavMeshAgent::get_speed_Injected");

	private static readonly set_speed_InjectedDelegate set_speed_InjectedDelegateField = IL2CPP.ResolveICall<set_speed_InjectedDelegate>("UnityEngine.AI.NavMeshAgent::set_speed_Injected");

	private static readonly get_angularSpeed_InjectedDelegate get_angularSpeed_InjectedDelegateField = IL2CPP.ResolveICall<get_angularSpeed_InjectedDelegate>("UnityEngine.AI.NavMeshAgent::get_angularSpeed_Injected");

	private static readonly set_angularSpeed_InjectedDelegate set_angularSpeed_InjectedDelegateField = IL2CPP.ResolveICall<set_angularSpeed_InjectedDelegate>("UnityEngine.AI.NavMeshAgent::set_angularSpeed_Injected");

	private static readonly get_acceleration_InjectedDelegate get_acceleration_InjectedDelegateField = IL2CPP.ResolveICall<get_acceleration_InjectedDelegate>("UnityEngine.AI.NavMeshAgent::get_acceleration_Injected");

	private static readonly set_acceleration_InjectedDelegate set_acceleration_InjectedDelegateField = IL2CPP.ResolveICall<set_acceleration_InjectedDelegate>("UnityEngine.AI.NavMeshAgent::set_acceleration_Injected");

	private static readonly get_updatePosition_InjectedDelegate get_updatePosition_InjectedDelegateField = IL2CPP.ResolveICall<get_updatePosition_InjectedDelegate>("UnityEngine.AI.NavMeshAgent::get_updatePosition_Injected");

	private static readonly set_updatePosition_InjectedDelegate set_updatePosition_InjectedDelegateField = IL2CPP.ResolveICall<set_updatePosition_InjectedDelegate>("UnityEngine.AI.NavMeshAgent::set_updatePosition_Injected");

	private static readonly get_updateRotation_InjectedDelegate get_updateRotation_InjectedDelegateField = IL2CPP.ResolveICall<get_updateRotation_InjectedDelegate>("UnityEngine.AI.NavMeshAgent::get_updateRotation_Injected");

	private static readonly set_updateRotation_InjectedDelegate set_updateRotation_InjectedDelegateField = IL2CPP.ResolveICall<set_updateRotation_InjectedDelegate>("UnityEngine.AI.NavMeshAgent::set_updateRotation_Injected");

	private static readonly get_updateUpAxis_InjectedDelegate get_updateUpAxis_InjectedDelegateField = IL2CPP.ResolveICall<get_updateUpAxis_InjectedDelegate>("UnityEngine.AI.NavMeshAgent::get_updateUpAxis_Injected");

	private static readonly set_updateUpAxis_InjectedDelegate set_updateUpAxis_InjectedDelegateField = IL2CPP.ResolveICall<set_updateUpAxis_InjectedDelegate>("UnityEngine.AI.NavMeshAgent::set_updateUpAxis_Injected");

	private static readonly get_radius_InjectedDelegate get_radius_InjectedDelegateField = IL2CPP.ResolveICall<get_radius_InjectedDelegate>("UnityEngine.AI.NavMeshAgent::get_radius_Injected");

	private static readonly set_radius_InjectedDelegate set_radius_InjectedDelegateField = IL2CPP.ResolveICall<set_radius_InjectedDelegate>("UnityEngine.AI.NavMeshAgent::set_radius_Injected");

	private static readonly get_height_InjectedDelegate get_height_InjectedDelegateField = IL2CPP.ResolveICall<get_height_InjectedDelegate>("UnityEngine.AI.NavMeshAgent::get_height_Injected");

	private static readonly set_height_InjectedDelegate set_height_InjectedDelegateField = IL2CPP.ResolveICall<set_height_InjectedDelegate>("UnityEngine.AI.NavMeshAgent::set_height_Injected");

	private static readonly get_obstacleAvoidanceType_InjectedDelegate get_obstacleAvoidanceType_InjectedDelegateField = IL2CPP.ResolveICall<get_obstacleAvoidanceType_InjectedDelegate>("UnityEngine.AI.NavMeshAgent::get_obstacleAvoidanceType_Injected");

	private static readonly set_obstacleAvoidanceType_InjectedDelegate set_obstacleAvoidanceType_InjectedDelegateField = IL2CPP.ResolveICall<set_obstacleAvoidanceType_InjectedDelegate>("UnityEngine.AI.NavMeshAgent::set_obstacleAvoidanceType_Injected");

	private static readonly get_avoidancePriority_InjectedDelegate get_avoidancePriority_InjectedDelegateField = IL2CPP.ResolveICall<get_avoidancePriority_InjectedDelegate>("UnityEngine.AI.NavMeshAgent::get_avoidancePriority_Injected");

	private static readonly set_avoidancePriority_InjectedDelegate set_avoidancePriority_InjectedDelegateField = IL2CPP.ResolveICall<set_avoidancePriority_InjectedDelegate>("UnityEngine.AI.NavMeshAgent::set_avoidancePriority_Injected");

	private static readonly get_isOnNavMesh_InjectedDelegate get_isOnNavMesh_InjectedDelegateField = IL2CPP.ResolveICall<get_isOnNavMesh_InjectedDelegate>("UnityEngine.AI.NavMeshAgent::get_isOnNavMesh_Injected");

	public Vector3 destination
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			get_destination_Injected(intPtr, out var ret);
			return ret;
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_destination_Injected(intPtr, ref value);
		}
	}

	public float stoppingDistance
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_stoppingDistance_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_stoppingDistance_Injected(intPtr, value);
		}
	}

	public Vector3 velocity
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			get_velocity_Injected(intPtr, out var ret);
			return ret;
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_velocity_Injected(intPtr, ref value);
		}
	}

	public Vector3 nextPosition
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			get_nextPosition_Injected(intPtr, out var ret);
			return ret;
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_nextPosition_Injected(intPtr, ref value);
		}
	}

	public Vector3 steeringTarget
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			get_steeringTarget_Injected(intPtr, out var ret);
			return ret;
		}
	}

	public Vector3 desiredVelocity
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			get_desiredVelocity_Injected(intPtr, out var ret);
			return ret;
		}
	}

	public float remainingDistance
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_remainingDistance_Injected(intPtr);
		}
	}

	public float baseOffset
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_baseOffset_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_baseOffset_Injected(intPtr, value);
		}
	}

	public bool isOnOffMeshLink
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_isOnOffMeshLink_Injected(intPtr);
		}
	}

	public bool autoTraverseOffMeshLink
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_autoTraverseOffMeshLink_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_autoTraverseOffMeshLink_Injected(intPtr, value);
		}
	}

	public bool autoBraking
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_autoBraking_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_autoBraking_Injected(intPtr, value);
		}
	}

	public bool autoRepath
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_autoRepath_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_autoRepath_Injected(intPtr, value);
		}
	}

	public bool hasPath
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_hasPath_Injected(intPtr);
		}
	}

	public bool pathPending
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_pathPending_Injected(intPtr);
		}
	}

	public bool isPathStale
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_isPathStale_Injected(intPtr);
		}
	}

	public NavMeshPathStatus pathStatus
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_pathStatus_Injected(intPtr);
		}
	}

	public Vector3 pathEndPosition
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			get_pathEndPosition_Injected(intPtr, out var ret);
			return ret;
		}
	}

	public bool isStopped
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_isStopped_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_isStopped_Injected(intPtr, value);
		}
	}

	public NavMeshPath path
	{
		get
		{
			NavMeshPath result = new NavMeshPath();
			CopyPathTo(result);
			return result;
		}
		set
		{
			if (value == null)
			{
				throw new Il2CppSystem.NullReferenceException();
			}
			SetPath(value);
		}
	}

	public Object navMeshOwner => GetOwnerInternal();

	public int agentTypeID
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_agentTypeID_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_agentTypeID_Injected(intPtr, value);
		}
	}

	public int walkableMask
	{
		get
		{
			return areaMask;
		}
		set
		{
			areaMask = value;
		}
	}

	public int areaMask
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_areaMask_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_areaMask_Injected(intPtr, value);
		}
	}

	public float speed
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_speed_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_speed_Injected(intPtr, value);
		}
	}

	public float angularSpeed
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_angularSpeed_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_angularSpeed_Injected(intPtr, value);
		}
	}

	public float acceleration
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_acceleration_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_acceleration_Injected(intPtr, value);
		}
	}

	public bool updatePosition
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_updatePosition_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_updatePosition_Injected(intPtr, value);
		}
	}

	public bool updateRotation
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_updateRotation_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_updateRotation_Injected(intPtr, value);
		}
	}

	public bool updateUpAxis
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_updateUpAxis_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_updateUpAxis_Injected(intPtr, value);
		}
	}

	public float radius
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_radius_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_radius_Injected(intPtr, value);
		}
	}

	public float height
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_height_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_height_Injected(intPtr, value);
		}
	}

	public ObstacleAvoidanceType obstacleAvoidanceType
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_obstacleAvoidanceType_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_obstacleAvoidanceType_Injected(intPtr, value);
		}
	}

	public int avoidancePriority
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_avoidancePriority_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_avoidancePriority_Injected(intPtr, value);
		}
	}

	public bool isOnNavMesh
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_isOnNavMesh_Injected(intPtr);
		}
	}

	public bool SetDestination(Vector3 target)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return SetDestination_Injected(intPtr, ref target);
	}

	public void ActivateCurrentOffMeshLink(bool activated)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		ActivateCurrentOffMeshLink_Injected(intPtr, activated);
	}

	public void CompleteOffMeshLink()
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		CompleteOffMeshLink_Injected(intPtr);
	}

	public bool Warp(Vector3 newPosition)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return Warp_Injected(intPtr, ref newPosition);
	}

	public void Move(Vector3 offset)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		Move_Injected(intPtr, ref offset);
	}

	public void Stop()
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		Stop_Injected(intPtr);
	}

	public void Stop(bool stopUpdates)
	{
		Stop();
	}

	public void Resume()
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		Resume_Injected(intPtr);
	}

	public void ResetPath()
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		ResetPath_Injected(intPtr);
	}

	public bool SetPath(NavMeshPath path)
	{
		if (path == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object)(object)path, "path");
		}
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		System.IntPtr intPtr2 = NavMeshPath.BindingsMarshaller.ConvertToNative(path);
		if (intPtr2 == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object)(object)path, "path");
		}
		return SetPath_Injected(intPtr, intPtr2);
	}

	public void CopyPathTo(NavMeshPath path)
	{
		if (path == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object)(object)path, "path");
		}
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		System.IntPtr intPtr2 = NavMeshPath.BindingsMarshaller.ConvertToNative(path);
		if (intPtr2 == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object)(object)path, "path");
		}
		CopyPathTo_Injected(intPtr, intPtr2);
	}

	public bool CalculatePath(Vector3 targetPosition, NavMeshPath path)
	{
		path.ClearCorners();
		return CalculatePathInternal(targetPosition, path);
	}

	public bool CalculatePathInternal(Vector3 targetPosition, NavMeshPath path)
	{
		if (path == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object)(object)path, "path");
		}
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		System.IntPtr intPtr2 = NavMeshPath.BindingsMarshaller.ConvertToNative(path);
		if (intPtr2 == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object)(object)path, "path");
		}
		return CalculatePathInternal_Injected(intPtr, ref targetPosition, intPtr2);
	}

	public void SetLayerCost(int layer, float cost)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		SetLayerCost_Injected(intPtr, layer, cost);
	}

	public float GetLayerCost(int layer)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return GetLayerCost_Injected(intPtr, layer);
	}

	public void SetAreaCost(int areaIndex, float areaCost)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		SetAreaCost_Injected(intPtr, areaIndex, areaCost);
	}

	public float GetAreaCost(int areaIndex)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return GetAreaCost_Injected(intPtr, areaIndex);
	}

	public Object GetOwnerInternal()
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return Unmarshal.UnmarshalUnityObject<Object>(GetOwnerInternal_Injected(intPtr));
	}

	public unsafe static bool SetDestination_Injected(System.IntPtr _unity_self, [In] ref Vector3 target)
	{
		return SetDestination_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref target));
	}

	public unsafe static void get_destination_Injected(System.IntPtr _unity_self, out Vector3 ret)
	{
		get_destination_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void set_destination_Injected(System.IntPtr _unity_self, [In] ref Vector3 value)
	{
		set_destination_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref value));
	}

	public static float get_stoppingDistance_Injected(System.IntPtr _unity_self)
	{
		return get_stoppingDistance_InjectedDelegateField(_unity_self);
	}

	public static void set_stoppingDistance_Injected(System.IntPtr _unity_self, float value)
	{
		set_stoppingDistance_InjectedDelegateField(_unity_self, value);
	}

	public unsafe static void get_velocity_Injected(System.IntPtr _unity_self, out Vector3 ret)
	{
		get_velocity_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void set_velocity_Injected(System.IntPtr _unity_self, [In] ref Vector3 value)
	{
		set_velocity_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref value));
	}

	public unsafe static void get_nextPosition_Injected(System.IntPtr _unity_self, out Vector3 ret)
	{
		get_nextPosition_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void set_nextPosition_Injected(System.IntPtr _unity_self, [In] ref Vector3 value)
	{
		set_nextPosition_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref value));
	}

	public unsafe static void get_steeringTarget_Injected(System.IntPtr _unity_self, out Vector3 ret)
	{
		get_steeringTarget_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void get_desiredVelocity_Injected(System.IntPtr _unity_self, out Vector3 ret)
	{
		get_desiredVelocity_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public static float get_remainingDistance_Injected(System.IntPtr _unity_self)
	{
		return get_remainingDistance_InjectedDelegateField(_unity_self);
	}

	public static float get_baseOffset_Injected(System.IntPtr _unity_self)
	{
		return get_baseOffset_InjectedDelegateField(_unity_self);
	}

	public static void set_baseOffset_Injected(System.IntPtr _unity_self, float value)
	{
		set_baseOffset_InjectedDelegateField(_unity_self, value);
	}

	public static bool get_isOnOffMeshLink_Injected(System.IntPtr _unity_self)
	{
		return get_isOnOffMeshLink_InjectedDelegateField(_unity_self);
	}

	public static void ActivateCurrentOffMeshLink_Injected(System.IntPtr _unity_self, bool activated)
	{
		ActivateCurrentOffMeshLink_InjectedDelegateField(_unity_self, activated);
	}

	public static void CompleteOffMeshLink_Injected(System.IntPtr _unity_self)
	{
		CompleteOffMeshLink_InjectedDelegateField(_unity_self);
	}

	public static bool get_autoTraverseOffMeshLink_Injected(System.IntPtr _unity_self)
	{
		return get_autoTraverseOffMeshLink_InjectedDelegateField(_unity_self);
	}

	public static void set_autoTraverseOffMeshLink_Injected(System.IntPtr _unity_self, bool value)
	{
		set_autoTraverseOffMeshLink_InjectedDelegateField(_unity_self, value);
	}

	public static bool get_autoBraking_Injected(System.IntPtr _unity_self)
	{
		return get_autoBraking_InjectedDelegateField(_unity_self);
	}

	public static void set_autoBraking_Injected(System.IntPtr _unity_self, bool value)
	{
		set_autoBraking_InjectedDelegateField(_unity_self, value);
	}

	public static bool get_autoRepath_Injected(System.IntPtr _unity_self)
	{
		return get_autoRepath_InjectedDelegateField(_unity_self);
	}

	public static void set_autoRepath_Injected(System.IntPtr _unity_self, bool value)
	{
		set_autoRepath_InjectedDelegateField(_unity_self, value);
	}

	public static bool get_hasPath_Injected(System.IntPtr _unity_self)
	{
		return get_hasPath_InjectedDelegateField(_unity_self);
	}

	public static bool get_pathPending_Injected(System.IntPtr _unity_self)
	{
		return get_pathPending_InjectedDelegateField(_unity_self);
	}

	public static bool get_isPathStale_Injected(System.IntPtr _unity_self)
	{
		return get_isPathStale_InjectedDelegateField(_unity_self);
	}

	public static NavMeshPathStatus get_pathStatus_Injected(System.IntPtr _unity_self)
	{
		return get_pathStatus_InjectedDelegateField(_unity_self);
	}

	public unsafe static void get_pathEndPosition_Injected(System.IntPtr _unity_self, out Vector3 ret)
	{
		get_pathEndPosition_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static bool Warp_Injected(System.IntPtr _unity_self, [In] ref Vector3 newPosition)
	{
		return Warp_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref newPosition));
	}

	public unsafe static void Move_Injected(System.IntPtr _unity_self, [In] ref Vector3 offset)
	{
		Move_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref offset));
	}

	public static void Stop_Injected(System.IntPtr _unity_self)
	{
		Stop_InjectedDelegateField(_unity_self);
	}

	public static void Resume_Injected(System.IntPtr _unity_self)
	{
		Resume_InjectedDelegateField(_unity_self);
	}

	public static bool get_isStopped_Injected(System.IntPtr _unity_self)
	{
		return get_isStopped_InjectedDelegateField(_unity_self);
	}

	public static void set_isStopped_Injected(System.IntPtr _unity_self, bool value)
	{
		set_isStopped_InjectedDelegateField(_unity_self, value);
	}

	public static void ResetPath_Injected(System.IntPtr _unity_self)
	{
		ResetPath_InjectedDelegateField(_unity_self);
	}

	public static bool SetPath_Injected(System.IntPtr _unity_self, System.IntPtr path)
	{
		return SetPath_InjectedDelegateField(_unity_self, path);
	}

	public static void CopyPathTo_Injected(System.IntPtr _unity_self, System.IntPtr path)
	{
		CopyPathTo_InjectedDelegateField(_unity_self, path);
	}

	public unsafe static bool CalculatePathInternal_Injected(System.IntPtr _unity_self, [In] ref Vector3 targetPosition, System.IntPtr path)
	{
		return CalculatePathInternal_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref targetPosition), path);
	}

	public static void SetLayerCost_Injected(System.IntPtr _unity_self, int layer, float cost)
	{
		SetLayerCost_InjectedDelegateField(_unity_self, layer, cost);
	}

	public static float GetLayerCost_Injected(System.IntPtr _unity_self, int layer)
	{
		return GetLayerCost_InjectedDelegateField(_unity_self, layer);
	}

	public static void SetAreaCost_Injected(System.IntPtr _unity_self, int areaIndex, float areaCost)
	{
		SetAreaCost_InjectedDelegateField(_unity_self, areaIndex, areaCost);
	}

	public static float GetAreaCost_Injected(System.IntPtr _unity_self, int areaIndex)
	{
		return GetAreaCost_InjectedDelegateField(_unity_self, areaIndex);
	}

	public static int get_agentTypeID_Injected(System.IntPtr _unity_self)
	{
		return get_agentTypeID_InjectedDelegateField(_unity_self);
	}

	public static void set_agentTypeID_Injected(System.IntPtr _unity_self, int value)
	{
		set_agentTypeID_InjectedDelegateField(_unity_self, value);
	}

	public static System.IntPtr GetOwnerInternal_Injected(System.IntPtr _unity_self)
	{
		return GetOwnerInternal_InjectedDelegateField(_unity_self);
	}

	public static int get_areaMask_Injected(System.IntPtr _unity_self)
	{
		return get_areaMask_InjectedDelegateField(_unity_self);
	}

	public static void set_areaMask_Injected(System.IntPtr _unity_self, int value)
	{
		set_areaMask_InjectedDelegateField(_unity_self, value);
	}

	public static float get_speed_Injected(System.IntPtr _unity_self)
	{
		return get_speed_InjectedDelegateField(_unity_self);
	}

	public static void set_speed_Injected(System.IntPtr _unity_self, float value)
	{
		set_speed_InjectedDelegateField(_unity_self, value);
	}

	public static float get_angularSpeed_Injected(System.IntPtr _unity_self)
	{
		return get_angularSpeed_InjectedDelegateField(_unity_self);
	}

	public static void set_angularSpeed_Injected(System.IntPtr _unity_self, float value)
	{
		set_angularSpeed_InjectedDelegateField(_unity_self, value);
	}

	public static float get_acceleration_Injected(System.IntPtr _unity_self)
	{
		return get_acceleration_InjectedDelegateField(_unity_self);
	}

	public static void set_acceleration_Injected(System.IntPtr _unity_self, float value)
	{
		set_acceleration_InjectedDelegateField(_unity_self, value);
	}

	public static bool get_updatePosition_Injected(System.IntPtr _unity_self)
	{
		return get_updatePosition_InjectedDelegateField(_unity_self);
	}

	public static void set_updatePosition_Injected(System.IntPtr _unity_self, bool value)
	{
		set_updatePosition_InjectedDelegateField(_unity_self, value);
	}

	public static bool get_updateRotation_Injected(System.IntPtr _unity_self)
	{
		return get_updateRotation_InjectedDelegateField(_unity_self);
	}

	public static void set_updateRotation_Injected(System.IntPtr _unity_self, bool value)
	{
		set_updateRotation_InjectedDelegateField(_unity_self, value);
	}

	public static bool get_updateUpAxis_Injected(System.IntPtr _unity_self)
	{
		return get_updateUpAxis_InjectedDelegateField(_unity_self);
	}

	public static void set_updateUpAxis_Injected(System.IntPtr _unity_self, bool value)
	{
		set_updateUpAxis_InjectedDelegateField(_unity_self, value);
	}

	public static float get_radius_Injected(System.IntPtr _unity_self)
	{
		return get_radius_InjectedDelegateField(_unity_self);
	}

	public static void set_radius_Injected(System.IntPtr _unity_self, float value)
	{
		set_radius_InjectedDelegateField(_unity_self, value);
	}

	public static float get_height_Injected(System.IntPtr _unity_self)
	{
		return get_height_InjectedDelegateField(_unity_self);
	}

	public static void set_height_Injected(System.IntPtr _unity_self, float value)
	{
		set_height_InjectedDelegateField(_unity_self, value);
	}

	public static ObstacleAvoidanceType get_obstacleAvoidanceType_Injected(System.IntPtr _unity_self)
	{
		return get_obstacleAvoidanceType_InjectedDelegateField(_unity_self);
	}

	public static void set_obstacleAvoidanceType_Injected(System.IntPtr _unity_self, ObstacleAvoidanceType value)
	{
		set_obstacleAvoidanceType_InjectedDelegateField(_unity_self, value);
	}

	public static int get_avoidancePriority_Injected(System.IntPtr _unity_self)
	{
		return get_avoidancePriority_InjectedDelegateField(_unity_self);
	}

	public static void set_avoidancePriority_Injected(System.IntPtr _unity_self, int value)
	{
		set_avoidancePriority_InjectedDelegateField(_unity_self, value);
	}

	public static bool get_isOnNavMesh_Injected(System.IntPtr _unity_self)
	{
		return get_isOnNavMesh_InjectedDelegateField(_unity_self);
	}
}
