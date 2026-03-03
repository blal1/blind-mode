using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Unity.Collections;
using UnityEngine.Bindings;

namespace UnityEngine;

public class Physics : Il2CppSystem.Object
{
	public sealed class ContactEventDelegate : Il2CppSystem.MulticastDelegate
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_PhysicsScene_ReadOnly_ContactPairHeader_0;

		static ContactEventDelegate()
		{
			Il2CppClassPointerStore<ContactEventDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Physics>.NativeClassPtr, "ContactEventDelegate");
			NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactEventDelegate>.NativeClassPtr, 100663375);
			NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_PhysicsScene_ReadOnly_ContactPairHeader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContactEventDelegate>.NativeClassPtr, 100663376);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259236, XrefRangeEnd = 1259239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ContactEventDelegate(Il2CppSystem.Object @object, System.IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContactEventDelegate>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
			*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		public unsafe virtual void Invoke(PhysicsScene scene, NativeArray<ContactPairHeader>.ReadOnly headerArray)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&scene);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)headerArray));
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_PhysicsScene_ReadOnly_ContactPairHeader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public ContactEventDelegate(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public static implicit operator ContactEventDelegate(System.Action<PhysicsScene, NativeArray<ContactPairHeader>.ReadOnly> P_0)
		{
			return DelegateSupport.ConvertDelegate<ContactEventDelegate>((System.Delegate)P_0);
		}

		public static ContactEventDelegate operator +(ContactEventDelegate P_0, ContactEventDelegate P_1)
		{
			return ((Il2CppObjectBase)Il2CppSystem.Delegate.Combine(P_0, P_1)).Cast<ContactEventDelegate>();
		}

		public static ContactEventDelegate operator -(ContactEventDelegate P_0, ContactEventDelegate P_1)
		{
			object obj = Il2CppSystem.Delegate.Remove(P_0, P_1);
			if (obj != null)
			{
				obj = ((Il2CppObjectBase)obj).Cast<ContactEventDelegate>();
			}
			return (ContactEventDelegate)obj;
		}
	}

	private delegate void GetIntegrationInfosDelegate([Out] System.IntPtr integrations, [Out] System.IntPtr integrationCount);

	private delegate void GetCurrentIntegrationInfoDelegate([Out] System.IntPtr integration);

	private delegate float get_defaultContactOffsetDelegate();

	private delegate void set_defaultContactOffsetDelegate(float value);

	private delegate float get_sleepThresholdDelegate();

	private delegate void set_sleepThresholdDelegate(float value);

	private delegate bool get_queriesHitTriggersDelegate();

	private delegate void set_queriesHitTriggersDelegate(bool value);

	private delegate bool get_queriesHitBackfacesDelegate();

	private delegate void set_queriesHitBackfacesDelegate(bool value);

	private delegate float get_bounceThresholdDelegate();

	private delegate void set_bounceThresholdDelegate(float value);

	private delegate float get_defaultMaxDepenetrationVelocityDelegate();

	private delegate void set_defaultMaxDepenetrationVelocityDelegate(float value);

	private delegate int get_defaultSolverIterationsDelegate();

	private delegate void set_defaultSolverIterationsDelegate(int value);

	private delegate int get_defaultSolverVelocityIterationsDelegate();

	private delegate void set_defaultSolverVelocityIterationsDelegate(int value);

	private delegate SimulationMode get_simulationModeDelegate();

	private delegate void set_simulationModeDelegate(SimulationMode value);

	private delegate float get_defaultMaxAngularSpeedDelegate();

	private delegate void set_defaultMaxAngularSpeedDelegate(float value);

	private delegate bool get_improvedPatchFrictionDelegate();

	private delegate void set_improvedPatchFrictionDelegate(bool value);

	private delegate void set_invokeCollisionCallbacksDelegate(bool value);

	private delegate void IgnoreLayerCollisionDelegate(int layer1, int layer2, bool ignore);

	private delegate bool GetIgnoreLayerCollisionDelegate(int layer1, int layer2);

	private delegate void SyncTransformsDelegate();

	private delegate bool get_autoSyncTransformsDelegate();

	private delegate void set_autoSyncTransformsDelegate(bool value);

	private delegate void set_reuseCollisionCallbacksDelegate(bool value);

	private delegate float get_interCollisionDistanceDelegate();

	private delegate void set_interCollisionDistanceDelegate(float value);

	private delegate float get_interCollisionStiffnessDelegate();

	private delegate void set_interCollisionStiffnessDelegate(float value);

	private delegate bool get_interCollisionSettingsToggleDelegate();

	private delegate void set_interCollisionSettingsToggleDelegate(bool value);

	private delegate void BakeMeshDelegate(int meshID, bool convex, MeshColliderCookingOptions cookingOptions);

	private delegate bool ConnectPhysicsSDKVisualDebuggerDelegate();

	private delegate void DisconnectPhysicsSDKVisualDebuggerDelegate();

	private delegate uint TranslateTriangleIndexFromIDDelegate(int instanceID, uint faceIndex);

	private delegate void get_gravity_InjectedDelegate([Out] System.IntPtr ret);

	private delegate void set_gravity_InjectedDelegate([In] System.IntPtr value);

	private delegate void IgnoreCollision_InjectedDelegate(System.IntPtr collider1, System.IntPtr collider2, bool ignore);

	private delegate bool GetIgnoreCollision_InjectedDelegate(System.IntPtr collider1, System.IntPtr collider2);

	private delegate void Query_CapsuleCastAll_InjectedDelegate([In] System.IntPtr physicsScene, [In] System.IntPtr p0, [In] System.IntPtr p1, float radius, [In] System.IntPtr direction, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction, [Out] System.IntPtr ret);

	private delegate void Query_SphereCastAll_InjectedDelegate([In] System.IntPtr physicsScene, [In] System.IntPtr origin, float radius, [In] System.IntPtr direction, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction, [Out] System.IntPtr ret);

	private delegate System.IntPtr OverlapCapsule_Internal_InjectedDelegate([In] System.IntPtr physicsScene, [In] System.IntPtr point0, [In] System.IntPtr point1, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction);

	private delegate System.IntPtr OverlapSphere_Internal_InjectedDelegate([In] System.IntPtr physicsScene, [In] System.IntPtr position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction);

	private delegate void Simulate_Internal_InjectedDelegate([In] System.IntPtr physicsScene, float step, SimulationStage stages, SimulationOption options);

	private delegate void InterpolateBodies_Internal_InjectedDelegate([In] System.IntPtr physicsScene);

	private delegate void ResetInterpolationPoses_Internal_InjectedDelegate([In] System.IntPtr physicsScene);

	private delegate bool Query_ComputePenetration_InjectedDelegate(System.IntPtr colliderA, [In] System.IntPtr positionA, [In] System.IntPtr rotationA, System.IntPtr colliderB, [In] System.IntPtr positionB, [In] System.IntPtr rotationB, System.IntPtr direction, System.IntPtr distance);

	private delegate void Query_ClosestPoint_InjectedDelegate(System.IntPtr collider, [In] System.IntPtr position, [In] System.IntPtr rotation, [In] System.IntPtr point, [Out] System.IntPtr ret);

	private delegate void get_clothGravity_InjectedDelegate([Out] System.IntPtr ret);

	private delegate void set_clothGravity_InjectedDelegate([In] System.IntPtr value);

	private delegate bool CheckSphere_Internal_InjectedDelegate([In] System.IntPtr physicsScene, [In] System.IntPtr position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction);

	private delegate bool CheckCapsule_Internal_InjectedDelegate([In] System.IntPtr physicsScene, [In] System.IntPtr start, [In] System.IntPtr end, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction);

	private delegate bool CheckBox_Internal_InjectedDelegate([In] System.IntPtr physicsScene, [In] System.IntPtr center, [In] System.IntPtr halfExtents, [In] System.IntPtr orientation, int layermask, QueryTriggerInteraction queryTriggerInteraction);

	private delegate System.IntPtr OverlapBox_Internal_InjectedDelegate([In] System.IntPtr physicsScene, [In] System.IntPtr center, [In] System.IntPtr halfExtents, [In] System.IntPtr orientation, int layerMask, QueryTriggerInteraction queryTriggerInteraction);

	private delegate void Internal_BoxCastAll_InjectedDelegate([In] System.IntPtr physicsScene, [In] System.IntPtr center, [In] System.IntPtr halfExtents, [In] System.IntPtr direction, [In] System.IntPtr orientation, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction, [Out] System.IntPtr ret);

	private delegate void RebuildBroadphaseRegions_InjectedDelegate([In] System.IntPtr worldBounds, int subdivisions);

	private static readonly System.IntPtr NativeFieldInfoPtr_ContactModifyEvent;

	private static readonly System.IntPtr NativeFieldInfoPtr_ContactModifyEventCCD;

	private static readonly System.IntPtr NativeFieldInfoPtr_GenericContactModifyEvent;

	private static readonly System.IntPtr NativeFieldInfoPtr_ContactEvent;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_ReusableCollision;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnSceneContactModify_Private_Static_Void_PhysicsScene_IntPtr_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PhysXOnSceneContactModify_Private_Static_Void_PhysicsScene_IntPtr_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_invokeCollisionCallbacks_Public_Static_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_defaultPhysicsScene_Public_Static_get_PhysicsScene_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Vector3_Vector3_Single_Int32_QueryTriggerInteraction_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Vector3_Vector3_Single_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Vector3_Vector3_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Vector3_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Vector3_Vector3_byref_RaycastHit_Single_Int32_QueryTriggerInteraction_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Vector3_Vector3_byref_RaycastHit_Single_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Vector3_Vector3_byref_RaycastHit_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Vector3_Vector3_byref_RaycastHit_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Ray_Single_Int32_QueryTriggerInteraction_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Ray_Single_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Ray_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Ray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Ray_byref_RaycastHit_Single_Int32_QueryTriggerInteraction_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Ray_byref_RaycastHit_Single_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Ray_byref_RaycastHit_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Ray_byref_RaycastHit_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_RaycastAll_Private_Static_Il2CppStructArray_1_RaycastHit_PhysicsScene_Ray_Single_Int32_QueryTriggerInteraction_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RaycastAll_Public_Static_Il2CppStructArray_1_RaycastHit_Vector3_Vector3_Single_Int32_QueryTriggerInteraction_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RaycastAll_Public_Static_Il2CppStructArray_1_RaycastHit_Vector3_Vector3_Single_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RaycastAll_Public_Static_Il2CppStructArray_1_RaycastHit_Vector3_Vector3_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RaycastAll_Public_Static_Il2CppStructArray_1_RaycastHit_Vector3_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RaycastAll_Public_Static_Il2CppStructArray_1_RaycastHit_Ray_Single_Int32_QueryTriggerInteraction_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RaycastAll_Public_Static_Il2CppStructArray_1_RaycastHit_Ray_Single_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RaycastAll_Public_Static_Il2CppStructArray_1_RaycastHit_Ray_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RaycastAll_Public_Static_Il2CppStructArray_1_RaycastHit_Ray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RaycastNonAlloc_Public_Static_Int32_Ray_Il2CppStructArray_1_RaycastHit_Single_Int32_QueryTriggerInteraction_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RaycastNonAlloc_Public_Static_Int32_Ray_Il2CppStructArray_1_RaycastHit_Single_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RaycastNonAlloc_Public_Static_Int32_Ray_Il2CppStructArray_1_RaycastHit_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RaycastNonAlloc_Public_Static_Int32_Ray_Il2CppStructArray_1_RaycastHit_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RaycastNonAlloc_Public_Static_Int32_Vector3_Vector3_Il2CppStructArray_1_RaycastHit_Single_Int32_QueryTriggerInteraction_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RaycastNonAlloc_Public_Static_Int32_Vector3_Vector3_Il2CppStructArray_1_RaycastHit_Single_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RaycastNonAlloc_Public_Static_Int32_Vector3_Vector3_Il2CppStructArray_1_RaycastHit_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RaycastNonAlloc_Public_Static_Int32_Vector3_Vector3_Il2CppStructArray_1_RaycastHit_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_reuseCollisionCallbacks_Public_Static_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetColliderByInstanceID_Internal_Static_Collider_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBodyByInstanceID_Internal_Static_Component_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SendOnCollisionEnter_Private_Static_Void_Component_Collision_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SendOnCollisionStay_Private_Static_Void_Component_Collision_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SendOnCollisionExit_Private_Static_Void_Component_Collision_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnSceneContact_Private_Static_Void_PhysicsScene_IntPtr_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReportContacts_Private_Static_Void_ReadOnly_ContactPairHeader_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCollisionToReport_Private_Static_Collision_byref_ContactPairHeader_byref_ContactPair_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_RaycastAll_Injected_Private_Static_Void_byref_PhysicsScene_byref_Ray_Single_Int32_QueryTriggerInteraction_byref_BlittableArrayWrapper_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetColliderByInstanceID_Injected_Private_Static_IntPtr_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBodyByInstanceID_Injected_Private_Static_IntPtr_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SendOnCollisionEnter_Injected_Private_Static_Void_IntPtr_Collision_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SendOnCollisionStay_Injected_Private_Static_Void_IntPtr_Collision_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SendOnCollisionExit_Injected_Private_Static_Void_IntPtr_Collision_0;

	public const float k_MaxFloatMinusEpsilon = 3.4028233E+38f;

	public const int IgnoreRaycastLayer = 4;

	public const int DefaultRaycastLayers = -5;

	public const int AllLayers = -1;

	public const int kIgnoreRaycastLayer = 4;

	public const int kDefaultRaycastLayers = -5;

	public const int kAllLayers = -1;

	private static readonly GetIntegrationInfosDelegate GetIntegrationInfosDelegateField;

	private static readonly GetCurrentIntegrationInfoDelegate GetCurrentIntegrationInfoDelegateField;

	private static readonly get_defaultContactOffsetDelegate get_defaultContactOffsetDelegateField;

	private static readonly set_defaultContactOffsetDelegate set_defaultContactOffsetDelegateField;

	private static readonly get_sleepThresholdDelegate get_sleepThresholdDelegateField;

	private static readonly set_sleepThresholdDelegate set_sleepThresholdDelegateField;

	private static readonly get_queriesHitTriggersDelegate get_queriesHitTriggersDelegateField;

	private static readonly set_queriesHitTriggersDelegate set_queriesHitTriggersDelegateField;

	private static readonly get_queriesHitBackfacesDelegate get_queriesHitBackfacesDelegateField;

	private static readonly set_queriesHitBackfacesDelegate set_queriesHitBackfacesDelegateField;

	private static readonly get_bounceThresholdDelegate get_bounceThresholdDelegateField;

	private static readonly set_bounceThresholdDelegate set_bounceThresholdDelegateField;

	private static readonly get_defaultMaxDepenetrationVelocityDelegate get_defaultMaxDepenetrationVelocityDelegateField;

	private static readonly set_defaultMaxDepenetrationVelocityDelegate set_defaultMaxDepenetrationVelocityDelegateField;

	private static readonly get_defaultSolverIterationsDelegate get_defaultSolverIterationsDelegateField;

	private static readonly set_defaultSolverIterationsDelegate set_defaultSolverIterationsDelegateField;

	private static readonly get_defaultSolverVelocityIterationsDelegate get_defaultSolverVelocityIterationsDelegateField;

	private static readonly set_defaultSolverVelocityIterationsDelegate set_defaultSolverVelocityIterationsDelegateField;

	private static readonly get_simulationModeDelegate get_simulationModeDelegateField;

	private static readonly set_simulationModeDelegate set_simulationModeDelegateField;

	private static readonly get_defaultMaxAngularSpeedDelegate get_defaultMaxAngularSpeedDelegateField;

	private static readonly set_defaultMaxAngularSpeedDelegate set_defaultMaxAngularSpeedDelegateField;

	private static readonly get_improvedPatchFrictionDelegate get_improvedPatchFrictionDelegateField;

	private static readonly set_improvedPatchFrictionDelegate set_improvedPatchFrictionDelegateField;

	private static readonly set_invokeCollisionCallbacksDelegate set_invokeCollisionCallbacksDelegateField;

	private static readonly IgnoreLayerCollisionDelegate IgnoreLayerCollisionDelegateField;

	private static readonly GetIgnoreLayerCollisionDelegate GetIgnoreLayerCollisionDelegateField;

	private static readonly SyncTransformsDelegate SyncTransformsDelegateField;

	private static readonly get_autoSyncTransformsDelegate get_autoSyncTransformsDelegateField;

	private static readonly set_autoSyncTransformsDelegate set_autoSyncTransformsDelegateField;

	private static readonly set_reuseCollisionCallbacksDelegate set_reuseCollisionCallbacksDelegateField;

	private static readonly get_interCollisionDistanceDelegate get_interCollisionDistanceDelegateField;

	private static readonly set_interCollisionDistanceDelegate set_interCollisionDistanceDelegateField;

	private static readonly get_interCollisionStiffnessDelegate get_interCollisionStiffnessDelegateField;

	private static readonly set_interCollisionStiffnessDelegate set_interCollisionStiffnessDelegateField;

	private static readonly get_interCollisionSettingsToggleDelegate get_interCollisionSettingsToggleDelegateField;

	private static readonly set_interCollisionSettingsToggleDelegate set_interCollisionSettingsToggleDelegateField;

	private static readonly BakeMeshDelegate BakeMeshDelegateField;

	private static readonly ConnectPhysicsSDKVisualDebuggerDelegate ConnectPhysicsSDKVisualDebuggerDelegateField;

	private static readonly DisconnectPhysicsSDKVisualDebuggerDelegate DisconnectPhysicsSDKVisualDebuggerDelegateField;

	private static readonly TranslateTriangleIndexFromIDDelegate TranslateTriangleIndexFromIDDelegateField;

	private static readonly get_gravity_InjectedDelegate get_gravity_InjectedDelegateField;

	private static readonly set_gravity_InjectedDelegate set_gravity_InjectedDelegateField;

	private static readonly IgnoreCollision_InjectedDelegate IgnoreCollision_InjectedDelegateField;

	private static readonly GetIgnoreCollision_InjectedDelegate GetIgnoreCollision_InjectedDelegateField;

	private static readonly Query_CapsuleCastAll_InjectedDelegate Query_CapsuleCastAll_InjectedDelegateField;

	private static readonly Query_SphereCastAll_InjectedDelegate Query_SphereCastAll_InjectedDelegateField;

	private static readonly OverlapCapsule_Internal_InjectedDelegate OverlapCapsule_Internal_InjectedDelegateField;

	private static readonly OverlapSphere_Internal_InjectedDelegate OverlapSphere_Internal_InjectedDelegateField;

	private static readonly Simulate_Internal_InjectedDelegate Simulate_Internal_InjectedDelegateField;

	private static readonly InterpolateBodies_Internal_InjectedDelegate InterpolateBodies_Internal_InjectedDelegateField;

	private static readonly ResetInterpolationPoses_Internal_InjectedDelegate ResetInterpolationPoses_Internal_InjectedDelegateField;

	private static readonly Query_ComputePenetration_InjectedDelegate Query_ComputePenetration_InjectedDelegateField;

	private static readonly Query_ClosestPoint_InjectedDelegate Query_ClosestPoint_InjectedDelegateField;

	private static readonly get_clothGravity_InjectedDelegate get_clothGravity_InjectedDelegateField;

	private static readonly set_clothGravity_InjectedDelegate set_clothGravity_InjectedDelegateField;

	private static readonly CheckSphere_Internal_InjectedDelegate CheckSphere_Internal_InjectedDelegateField;

	private static readonly CheckCapsule_Internal_InjectedDelegate CheckCapsule_Internal_InjectedDelegateField;

	private static readonly CheckBox_Internal_InjectedDelegate CheckBox_Internal_InjectedDelegateField;

	private static readonly OverlapBox_Internal_InjectedDelegate OverlapBox_Internal_InjectedDelegateField;

	private static readonly Internal_BoxCastAll_InjectedDelegate Internal_BoxCastAll_InjectedDelegateField;

	private static readonly RebuildBroadphaseRegions_InjectedDelegate RebuildBroadphaseRegions_InjectedDelegateField;

	public unsafe static Il2CppSystem.Action<PhysicsScene, NativeArray<ModifiableContactPair>> ContactModifyEvent
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ContactModifyEvent, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<PhysicsScene, NativeArray<ModifiableContactPair>>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ContactModifyEvent, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppSystem.Action<PhysicsScene, NativeArray<ModifiableContactPair>> ContactModifyEventCCD
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ContactModifyEventCCD, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<PhysicsScene, NativeArray<ModifiableContactPair>>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ContactModifyEventCCD, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppSystem.Action<PhysicsScene, System.IntPtr, int, bool> GenericContactModifyEvent
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_GenericContactModifyEvent, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<PhysicsScene, System.IntPtr, int, bool>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_GenericContactModifyEvent, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static ContactEventDelegate ContactEvent
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ContactEvent, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ContactEventDelegate>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ContactEvent, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Collision s_ReusableCollision
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_ReusableCollision, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Collision>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_ReusableCollision, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static bool invokeCollisionCallbacks
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259253, XrefRangeEnd = 1259255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_invokeCollisionCallbacks_Public_Static_get_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			set_invokeCollisionCallbacksDelegateField(value);
		}
	}

	public unsafe static PhysicsScene defaultPhysicsScene
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_defaultPhysicsScene_Public_Static_get_PhysicsScene_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(PhysicsScene*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static bool reuseCollisionCallbacks
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259483, XrefRangeEnd = 1259485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_reuseCollisionCallbacks_Public_Static_get_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			set_reuseCollisionCallbacksDelegateField(value);
		}
	}

	public static Vector3 gravity
	{
		get
		{
			get_gravity_Injected(out var ret);
			return ret;
		}
		set
		{
			set_gravity_Injected(ref value);
		}
	}

	public static float defaultContactOffset
	{
		get
		{
			return get_defaultContactOffsetDelegateField();
		}
		set
		{
			set_defaultContactOffsetDelegateField(value);
		}
	}

	public static float sleepThreshold
	{
		get
		{
			return get_sleepThresholdDelegateField();
		}
		set
		{
			set_sleepThresholdDelegateField(value);
		}
	}

	public static bool queriesHitTriggers
	{
		get
		{
			return get_queriesHitTriggersDelegateField();
		}
		set
		{
			set_queriesHitTriggersDelegateField(value);
		}
	}

	public static bool queriesHitBackfaces
	{
		get
		{
			return get_queriesHitBackfacesDelegateField();
		}
		set
		{
			set_queriesHitBackfacesDelegateField(value);
		}
	}

	public static float bounceThreshold
	{
		get
		{
			return get_bounceThresholdDelegateField();
		}
		set
		{
			set_bounceThresholdDelegateField(value);
		}
	}

	public static float defaultMaxDepenetrationVelocity
	{
		get
		{
			return get_defaultMaxDepenetrationVelocityDelegateField();
		}
		set
		{
			set_defaultMaxDepenetrationVelocityDelegateField(value);
		}
	}

	public static int defaultSolverIterations
	{
		get
		{
			return get_defaultSolverIterationsDelegateField();
		}
		set
		{
			set_defaultSolverIterationsDelegateField(value);
		}
	}

	public static int defaultSolverVelocityIterations
	{
		get
		{
			return get_defaultSolverVelocityIterationsDelegateField();
		}
		set
		{
			set_defaultSolverVelocityIterationsDelegateField(value);
		}
	}

	public static SimulationMode simulationMode
	{
		get
		{
			return get_simulationModeDelegateField();
		}
		set
		{
			set_simulationModeDelegateField(value);
		}
	}

	public static float defaultMaxAngularSpeed
	{
		get
		{
			return get_defaultMaxAngularSpeedDelegateField();
		}
		set
		{
			set_defaultMaxAngularSpeedDelegateField(value);
		}
	}

	public static bool improvedPatchFriction
	{
		get
		{
			return get_improvedPatchFrictionDelegateField();
		}
		set
		{
			set_improvedPatchFrictionDelegateField(value);
		}
	}

	public static bool autoSyncTransforms
	{
		get
		{
			return get_autoSyncTransformsDelegateField();
		}
		set
		{
			set_autoSyncTransformsDelegateField(value);
		}
	}

	public static float interCollisionDistance
	{
		get
		{
			return get_interCollisionDistanceDelegateField();
		}
		set
		{
			set_interCollisionDistanceDelegateField(value);
		}
	}

	public static float interCollisionStiffness
	{
		get
		{
			return get_interCollisionStiffnessDelegateField();
		}
		set
		{
			set_interCollisionStiffnessDelegateField(value);
		}
	}

	public static bool interCollisionSettingsToggle
	{
		get
		{
			return get_interCollisionSettingsToggleDelegateField();
		}
		set
		{
			set_interCollisionSettingsToggleDelegateField(value);
		}
	}

	public static Vector3 clothGravity
	{
		get
		{
			get_clothGravity_Injected(out var ret);
			return ret;
		}
		set
		{
			set_clothGravity_Injected(ref value);
		}
	}

	public static float minPenetrationForPenalty
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public static float bounceTreshold
	{
		get
		{
			return bounceThreshold;
		}
		set
		{
			bounceThreshold = value;
		}
	}

	public static float sleepVelocity
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public static float sleepAngularVelocity
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public static float maxAngularVelocity
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public static int solverIterationCount
	{
		get
		{
			return defaultSolverIterations;
		}
		set
		{
			defaultSolverIterations = value;
		}
	}

	public static int solverVelocityIterationCount
	{
		get
		{
			return defaultSolverVelocityIterations;
		}
		set
		{
			defaultSolverVelocityIterations = value;
		}
	}

	public static float penetrationPenaltyForce
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public static bool autoSimulation
	{
		get
		{
			return simulationMode != SimulationMode.Script;
		}
		set
		{
			simulationMode = ((!value) ? SimulationMode.Script : SimulationMode.FixedUpdate);
		}
	}

	static Physics()
	{
		Il2CppClassPointerStore<Physics>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.PhysicsModule.dll", "UnityEngine", "Physics");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Physics>.NativeClassPtr);
		NativeFieldInfoPtr_ContactModifyEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Physics>.NativeClassPtr, "ContactModifyEvent");
		NativeFieldInfoPtr_ContactModifyEventCCD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Physics>.NativeClassPtr, "ContactModifyEventCCD");
		NativeFieldInfoPtr_GenericContactModifyEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Physics>.NativeClassPtr, "GenericContactModifyEvent");
		NativeFieldInfoPtr_ContactEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Physics>.NativeClassPtr, "ContactEvent");
		NativeFieldInfoPtr_s_ReusableCollision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Physics>.NativeClassPtr, "s_ReusableCollision");
		NativeMethodInfoPtr_OnSceneContactModify_Private_Static_Void_PhysicsScene_IntPtr_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663322);
		NativeMethodInfoPtr_PhysXOnSceneContactModify_Private_Static_Void_PhysicsScene_IntPtr_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663323);
		NativeMethodInfoPtr_get_invokeCollisionCallbacks_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663324);
		NativeMethodInfoPtr_get_defaultPhysicsScene_Public_Static_get_PhysicsScene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663325);
		NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Vector3_Vector3_Single_Int32_QueryTriggerInteraction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663326);
		NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Vector3_Vector3_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663327);
		NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663328);
		NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663329);
		NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Vector3_Vector3_byref_RaycastHit_Single_Int32_QueryTriggerInteraction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663330);
		NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Vector3_Vector3_byref_RaycastHit_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663331);
		NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Vector3_Vector3_byref_RaycastHit_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663332);
		NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Vector3_Vector3_byref_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663333);
		NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Ray_Single_Int32_QueryTriggerInteraction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663334);
		NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Ray_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663335);
		NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Ray_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663336);
		NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Ray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663337);
		NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Ray_byref_RaycastHit_Single_Int32_QueryTriggerInteraction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663338);
		NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Ray_byref_RaycastHit_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663339);
		NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Ray_byref_RaycastHit_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663340);
		NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Ray_byref_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663341);
		NativeMethodInfoPtr_Internal_RaycastAll_Private_Static_Il2CppStructArray_1_RaycastHit_PhysicsScene_Ray_Single_Int32_QueryTriggerInteraction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663342);
		NativeMethodInfoPtr_RaycastAll_Public_Static_Il2CppStructArray_1_RaycastHit_Vector3_Vector3_Single_Int32_QueryTriggerInteraction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663343);
		NativeMethodInfoPtr_RaycastAll_Public_Static_Il2CppStructArray_1_RaycastHit_Vector3_Vector3_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663344);
		NativeMethodInfoPtr_RaycastAll_Public_Static_Il2CppStructArray_1_RaycastHit_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663345);
		NativeMethodInfoPtr_RaycastAll_Public_Static_Il2CppStructArray_1_RaycastHit_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663346);
		NativeMethodInfoPtr_RaycastAll_Public_Static_Il2CppStructArray_1_RaycastHit_Ray_Single_Int32_QueryTriggerInteraction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663347);
		NativeMethodInfoPtr_RaycastAll_Public_Static_Il2CppStructArray_1_RaycastHit_Ray_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663348);
		NativeMethodInfoPtr_RaycastAll_Public_Static_Il2CppStructArray_1_RaycastHit_Ray_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663349);
		NativeMethodInfoPtr_RaycastAll_Public_Static_Il2CppStructArray_1_RaycastHit_Ray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663350);
		NativeMethodInfoPtr_RaycastNonAlloc_Public_Static_Int32_Ray_Il2CppStructArray_1_RaycastHit_Single_Int32_QueryTriggerInteraction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663351);
		NativeMethodInfoPtr_RaycastNonAlloc_Public_Static_Int32_Ray_Il2CppStructArray_1_RaycastHit_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663352);
		NativeMethodInfoPtr_RaycastNonAlloc_Public_Static_Int32_Ray_Il2CppStructArray_1_RaycastHit_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663353);
		NativeMethodInfoPtr_RaycastNonAlloc_Public_Static_Int32_Ray_Il2CppStructArray_1_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663354);
		NativeMethodInfoPtr_RaycastNonAlloc_Public_Static_Int32_Vector3_Vector3_Il2CppStructArray_1_RaycastHit_Single_Int32_QueryTriggerInteraction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663355);
		NativeMethodInfoPtr_RaycastNonAlloc_Public_Static_Int32_Vector3_Vector3_Il2CppStructArray_1_RaycastHit_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663356);
		NativeMethodInfoPtr_RaycastNonAlloc_Public_Static_Int32_Vector3_Vector3_Il2CppStructArray_1_RaycastHit_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663357);
		NativeMethodInfoPtr_RaycastNonAlloc_Public_Static_Int32_Vector3_Vector3_Il2CppStructArray_1_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663358);
		NativeMethodInfoPtr_get_reuseCollisionCallbacks_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663359);
		NativeMethodInfoPtr_GetColliderByInstanceID_Internal_Static_Collider_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663360);
		NativeMethodInfoPtr_GetBodyByInstanceID_Internal_Static_Component_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663361);
		NativeMethodInfoPtr_SendOnCollisionEnter_Private_Static_Void_Component_Collision_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663362);
		NativeMethodInfoPtr_SendOnCollisionStay_Private_Static_Void_Component_Collision_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663363);
		NativeMethodInfoPtr_SendOnCollisionExit_Private_Static_Void_Component_Collision_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663364);
		NativeMethodInfoPtr_OnSceneContact_Private_Static_Void_PhysicsScene_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663365);
		NativeMethodInfoPtr_ReportContacts_Private_Static_Void_ReadOnly_ContactPairHeader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663366);
		NativeMethodInfoPtr_GetCollisionToReport_Private_Static_Collision_byref_ContactPairHeader_byref_ContactPair_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663367);
		NativeMethodInfoPtr_Internal_RaycastAll_Injected_Private_Static_Void_byref_PhysicsScene_byref_Ray_Single_Int32_QueryTriggerInteraction_byref_BlittableArrayWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663369);
		NativeMethodInfoPtr_GetColliderByInstanceID_Injected_Private_Static_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663370);
		NativeMethodInfoPtr_GetBodyByInstanceID_Injected_Private_Static_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663371);
		NativeMethodInfoPtr_SendOnCollisionEnter_Injected_Private_Static_Void_IntPtr_Collision_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663372);
		NativeMethodInfoPtr_SendOnCollisionStay_Injected_Private_Static_Void_IntPtr_Collision_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663373);
		NativeMethodInfoPtr_SendOnCollisionExit_Injected_Private_Static_Void_IntPtr_Collision_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics>.NativeClassPtr, 100663374);
		GetIntegrationInfosDelegateField = IL2CPP.ResolveICall<GetIntegrationInfosDelegate>("UnityEngine.Physics::GetIntegrationInfos");
		GetCurrentIntegrationInfoDelegateField = IL2CPP.ResolveICall<GetCurrentIntegrationInfoDelegate>("UnityEngine.Physics::GetCurrentIntegrationInfo");
		get_defaultContactOffsetDelegateField = IL2CPP.ResolveICall<get_defaultContactOffsetDelegate>("UnityEngine.Physics::get_defaultContactOffset");
		set_defaultContactOffsetDelegateField = IL2CPP.ResolveICall<set_defaultContactOffsetDelegate>("UnityEngine.Physics::set_defaultContactOffset");
		get_sleepThresholdDelegateField = IL2CPP.ResolveICall<get_sleepThresholdDelegate>("UnityEngine.Physics::get_sleepThreshold");
		set_sleepThresholdDelegateField = IL2CPP.ResolveICall<set_sleepThresholdDelegate>("UnityEngine.Physics::set_sleepThreshold");
		get_queriesHitTriggersDelegateField = IL2CPP.ResolveICall<get_queriesHitTriggersDelegate>("UnityEngine.Physics::get_queriesHitTriggers");
		set_queriesHitTriggersDelegateField = IL2CPP.ResolveICall<set_queriesHitTriggersDelegate>("UnityEngine.Physics::set_queriesHitTriggers");
		get_queriesHitBackfacesDelegateField = IL2CPP.ResolveICall<get_queriesHitBackfacesDelegate>("UnityEngine.Physics::get_queriesHitBackfaces");
		set_queriesHitBackfacesDelegateField = IL2CPP.ResolveICall<set_queriesHitBackfacesDelegate>("UnityEngine.Physics::set_queriesHitBackfaces");
		get_bounceThresholdDelegateField = IL2CPP.ResolveICall<get_bounceThresholdDelegate>("UnityEngine.Physics::get_bounceThreshold");
		set_bounceThresholdDelegateField = IL2CPP.ResolveICall<set_bounceThresholdDelegate>("UnityEngine.Physics::set_bounceThreshold");
		get_defaultMaxDepenetrationVelocityDelegateField = IL2CPP.ResolveICall<get_defaultMaxDepenetrationVelocityDelegate>("UnityEngine.Physics::get_defaultMaxDepenetrationVelocity");
		set_defaultMaxDepenetrationVelocityDelegateField = IL2CPP.ResolveICall<set_defaultMaxDepenetrationVelocityDelegate>("UnityEngine.Physics::set_defaultMaxDepenetrationVelocity");
		get_defaultSolverIterationsDelegateField = IL2CPP.ResolveICall<get_defaultSolverIterationsDelegate>("UnityEngine.Physics::get_defaultSolverIterations");
		set_defaultSolverIterationsDelegateField = IL2CPP.ResolveICall<set_defaultSolverIterationsDelegate>("UnityEngine.Physics::set_defaultSolverIterations");
		get_defaultSolverVelocityIterationsDelegateField = IL2CPP.ResolveICall<get_defaultSolverVelocityIterationsDelegate>("UnityEngine.Physics::get_defaultSolverVelocityIterations");
		set_defaultSolverVelocityIterationsDelegateField = IL2CPP.ResolveICall<set_defaultSolverVelocityIterationsDelegate>("UnityEngine.Physics::set_defaultSolverVelocityIterations");
		get_simulationModeDelegateField = IL2CPP.ResolveICall<get_simulationModeDelegate>("UnityEngine.Physics::get_simulationMode");
		set_simulationModeDelegateField = IL2CPP.ResolveICall<set_simulationModeDelegate>("UnityEngine.Physics::set_simulationMode");
		get_defaultMaxAngularSpeedDelegateField = IL2CPP.ResolveICall<get_defaultMaxAngularSpeedDelegate>("UnityEngine.Physics::get_defaultMaxAngularSpeed");
		set_defaultMaxAngularSpeedDelegateField = IL2CPP.ResolveICall<set_defaultMaxAngularSpeedDelegate>("UnityEngine.Physics::set_defaultMaxAngularSpeed");
		get_improvedPatchFrictionDelegateField = IL2CPP.ResolveICall<get_improvedPatchFrictionDelegate>("UnityEngine.Physics::get_improvedPatchFriction");
		set_improvedPatchFrictionDelegateField = IL2CPP.ResolveICall<set_improvedPatchFrictionDelegate>("UnityEngine.Physics::set_improvedPatchFriction");
		set_invokeCollisionCallbacksDelegateField = IL2CPP.ResolveICall<set_invokeCollisionCallbacksDelegate>("UnityEngine.Physics::set_invokeCollisionCallbacks");
		IgnoreLayerCollisionDelegateField = IL2CPP.ResolveICall<IgnoreLayerCollisionDelegate>("UnityEngine.Physics::IgnoreLayerCollision");
		GetIgnoreLayerCollisionDelegateField = IL2CPP.ResolveICall<GetIgnoreLayerCollisionDelegate>("UnityEngine.Physics::GetIgnoreLayerCollision");
		SyncTransformsDelegateField = IL2CPP.ResolveICall<SyncTransformsDelegate>("UnityEngine.Physics::SyncTransforms");
		get_autoSyncTransformsDelegateField = IL2CPP.ResolveICall<get_autoSyncTransformsDelegate>("UnityEngine.Physics::get_autoSyncTransforms");
		set_autoSyncTransformsDelegateField = IL2CPP.ResolveICall<set_autoSyncTransformsDelegate>("UnityEngine.Physics::set_autoSyncTransforms");
		set_reuseCollisionCallbacksDelegateField = IL2CPP.ResolveICall<set_reuseCollisionCallbacksDelegate>("UnityEngine.Physics::set_reuseCollisionCallbacks");
		get_interCollisionDistanceDelegateField = IL2CPP.ResolveICall<get_interCollisionDistanceDelegate>("UnityEngine.Physics::get_interCollisionDistance");
		set_interCollisionDistanceDelegateField = IL2CPP.ResolveICall<set_interCollisionDistanceDelegate>("UnityEngine.Physics::set_interCollisionDistance");
		get_interCollisionStiffnessDelegateField = IL2CPP.ResolveICall<get_interCollisionStiffnessDelegate>("UnityEngine.Physics::get_interCollisionStiffness");
		set_interCollisionStiffnessDelegateField = IL2CPP.ResolveICall<set_interCollisionStiffnessDelegate>("UnityEngine.Physics::set_interCollisionStiffness");
		get_interCollisionSettingsToggleDelegateField = IL2CPP.ResolveICall<get_interCollisionSettingsToggleDelegate>("UnityEngine.Physics::get_interCollisionSettingsToggle");
		set_interCollisionSettingsToggleDelegateField = IL2CPP.ResolveICall<set_interCollisionSettingsToggleDelegate>("UnityEngine.Physics::set_interCollisionSettingsToggle");
		BakeMeshDelegateField = IL2CPP.ResolveICall<BakeMeshDelegate>("UnityEngine.Physics::BakeMesh");
		ConnectPhysicsSDKVisualDebuggerDelegateField = IL2CPP.ResolveICall<ConnectPhysicsSDKVisualDebuggerDelegate>("UnityEngine.Physics::ConnectPhysicsSDKVisualDebugger");
		DisconnectPhysicsSDKVisualDebuggerDelegateField = IL2CPP.ResolveICall<DisconnectPhysicsSDKVisualDebuggerDelegate>("UnityEngine.Physics::DisconnectPhysicsSDKVisualDebugger");
		TranslateTriangleIndexFromIDDelegateField = IL2CPP.ResolveICall<TranslateTriangleIndexFromIDDelegate>("UnityEngine.Physics::TranslateTriangleIndexFromID");
		get_gravity_InjectedDelegateField = IL2CPP.ResolveICall<get_gravity_InjectedDelegate>("UnityEngine.Physics::get_gravity_Injected");
		set_gravity_InjectedDelegateField = IL2CPP.ResolveICall<set_gravity_InjectedDelegate>("UnityEngine.Physics::set_gravity_Injected");
		IgnoreCollision_InjectedDelegateField = IL2CPP.ResolveICall<IgnoreCollision_InjectedDelegate>("UnityEngine.Physics::IgnoreCollision_Injected");
		GetIgnoreCollision_InjectedDelegateField = IL2CPP.ResolveICall<GetIgnoreCollision_InjectedDelegate>("UnityEngine.Physics::GetIgnoreCollision_Injected");
		Query_CapsuleCastAll_InjectedDelegateField = IL2CPP.ResolveICall<Query_CapsuleCastAll_InjectedDelegate>("UnityEngine.Physics::Query_CapsuleCastAll_Injected");
		Query_SphereCastAll_InjectedDelegateField = IL2CPP.ResolveICall<Query_SphereCastAll_InjectedDelegate>("UnityEngine.Physics::Query_SphereCastAll_Injected");
		OverlapCapsule_Internal_InjectedDelegateField = IL2CPP.ResolveICall<OverlapCapsule_Internal_InjectedDelegate>("UnityEngine.Physics::OverlapCapsule_Internal_Injected");
		OverlapSphere_Internal_InjectedDelegateField = IL2CPP.ResolveICall<OverlapSphere_Internal_InjectedDelegate>("UnityEngine.Physics::OverlapSphere_Internal_Injected");
		Simulate_Internal_InjectedDelegateField = IL2CPP.ResolveICall<Simulate_Internal_InjectedDelegate>("UnityEngine.Physics::Simulate_Internal_Injected");
		InterpolateBodies_Internal_InjectedDelegateField = IL2CPP.ResolveICall<InterpolateBodies_Internal_InjectedDelegate>("UnityEngine.Physics::InterpolateBodies_Internal_Injected");
		ResetInterpolationPoses_Internal_InjectedDelegateField = IL2CPP.ResolveICall<ResetInterpolationPoses_Internal_InjectedDelegate>("UnityEngine.Physics::ResetInterpolationPoses_Internal_Injected");
		Query_ComputePenetration_InjectedDelegateField = IL2CPP.ResolveICall<Query_ComputePenetration_InjectedDelegate>("UnityEngine.Physics::Query_ComputePenetration_Injected");
		Query_ClosestPoint_InjectedDelegateField = IL2CPP.ResolveICall<Query_ClosestPoint_InjectedDelegate>("UnityEngine.Physics::Query_ClosestPoint_Injected");
		get_clothGravity_InjectedDelegateField = IL2CPP.ResolveICall<get_clothGravity_InjectedDelegate>("UnityEngine.Physics::get_clothGravity_Injected");
		set_clothGravity_InjectedDelegateField = IL2CPP.ResolveICall<set_clothGravity_InjectedDelegate>("UnityEngine.Physics::set_clothGravity_Injected");
		CheckSphere_Internal_InjectedDelegateField = IL2CPP.ResolveICall<CheckSphere_Internal_InjectedDelegate>("UnityEngine.Physics::CheckSphere_Internal_Injected");
		CheckCapsule_Internal_InjectedDelegateField = IL2CPP.ResolveICall<CheckCapsule_Internal_InjectedDelegate>("UnityEngine.Physics::CheckCapsule_Internal_Injected");
		CheckBox_Internal_InjectedDelegateField = IL2CPP.ResolveICall<CheckBox_Internal_InjectedDelegate>("UnityEngine.Physics::CheckBox_Internal_Injected");
		OverlapBox_Internal_InjectedDelegateField = IL2CPP.ResolveICall<OverlapBox_Internal_InjectedDelegate>("UnityEngine.Physics::OverlapBox_Internal_Injected");
		Internal_BoxCastAll_InjectedDelegateField = IL2CPP.ResolveICall<Internal_BoxCastAll_InjectedDelegate>("UnityEngine.Physics::Internal_BoxCastAll_Injected");
		RebuildBroadphaseRegions_InjectedDelegateField = IL2CPP.ResolveICall<RebuildBroadphaseRegions_InjectedDelegate>("UnityEngine.Physics::RebuildBroadphaseRegions_Injected");
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259239, XrefRangeEnd = 1259243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void OnSceneContactModify(PhysicsScene scene, System.IntPtr buffer, int count, bool isCCD)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&scene);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &buffer;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &isCCD;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnSceneContactModify_Private_Static_Void_PhysicsScene_IntPtr_Int32_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259243, XrefRangeEnd = 1259253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void PhysXOnSceneContactModify(PhysicsScene scene, System.IntPtr buffer, int count, bool isCCD)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&scene);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &buffer;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &isCCD;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PhysXOnSceneContactModify_Private_Static_Void_PhysicsScene_IntPtr_Int32_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259255, XrefRangeEnd = 1259263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool Raycast(Vector3 origin, Vector3 direction, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&origin);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &direction;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxDistance;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &layerMask;
		*(QueryTriggerInteraction**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &queryTriggerInteraction;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Vector3_Vector3_Single_Int32_QueryTriggerInteraction_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259263, XrefRangeEnd = 1259271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool Raycast(Vector3 origin, Vector3 direction, float maxDistance, int layerMask)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&origin);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &direction;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxDistance;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &layerMask;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Vector3_Vector3_Single_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259271, XrefRangeEnd = 1259279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool Raycast(Vector3 origin, Vector3 direction, float maxDistance)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&origin);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &direction;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxDistance;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Vector3_Vector3_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259279, XrefRangeEnd = 1259283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool Raycast(Vector3 origin, Vector3 direction)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&origin);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &direction;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Vector3_Vector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259283, XrefRangeEnd = 1259287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&origin);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &direction;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref hitInfo);
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxDistance;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &layerMask;
		*(QueryTriggerInteraction**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &queryTriggerInteraction;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Vector3_Vector3_byref_RaycastHit_Single_Int32_QueryTriggerInteraction_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259287, XrefRangeEnd = 1259291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&origin);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &direction;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref hitInfo);
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxDistance;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &layerMask;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Vector3_Vector3_byref_RaycastHit_Single_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259291, XrefRangeEnd = 1259295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&origin);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &direction;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref hitInfo);
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxDistance;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Vector3_Vector3_byref_RaycastHit_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259295, XrefRangeEnd = 1259299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&origin);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &direction;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref hitInfo);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Vector3_Vector3_byref_RaycastHit_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259299, XrefRangeEnd = 1259307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool Raycast(Ray ray, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&ray);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxDistance;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &layerMask;
		*(QueryTriggerInteraction**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &queryTriggerInteraction;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Ray_Single_Int32_QueryTriggerInteraction_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259307, XrefRangeEnd = 1259315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool Raycast(Ray ray, float maxDistance, int layerMask)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&ray);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxDistance;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &layerMask;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Ray_Single_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259315, XrefRangeEnd = 1259319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool Raycast(Ray ray, float maxDistance)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&ray);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxDistance;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Ray_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259319, XrefRangeEnd = 1259323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool Raycast(Ray ray)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&ray);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Ray_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259323, XrefRangeEnd = 1259327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&ray);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref hitInfo);
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxDistance;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &layerMask;
		*(QueryTriggerInteraction**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &queryTriggerInteraction;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Ray_byref_RaycastHit_Single_Int32_QueryTriggerInteraction_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1259334, RefRangeEnd = 1259336, XrefRangeStart = 1259327, XrefRangeEnd = 1259334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance, int layerMask)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&ray);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref hitInfo);
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxDistance;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &layerMask;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Ray_byref_RaycastHit_Single_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1259340, RefRangeEnd = 1259341, XrefRangeStart = 1259336, XrefRangeEnd = 1259340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&ray);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref hitInfo);
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxDistance;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Ray_byref_RaycastHit_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259341, XrefRangeEnd = 1259345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool Raycast(Ray ray, out RaycastHit hitInfo)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&ray);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref hitInfo);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Raycast_Public_Static_Boolean_Ray_byref_RaycastHit_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1259354, RefRangeEnd = 1259355, XrefRangeStart = 1259345, XrefRangeEnd = 1259354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<RaycastHit> Internal_RaycastAll(PhysicsScene physicsScene, Ray ray, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&physicsScene);
		*(Ray**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &ray;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxDistance;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &mask;
		*(QueryTriggerInteraction**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &queryTriggerInteraction;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_RaycastAll_Private_Static_Il2CppStructArray_1_RaycastHit_PhysicsScene_Ray_Single_Int32_QueryTriggerInteraction_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<RaycastHit>>(intPtr2) : null;
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 1259365, RefRangeEnd = 1259372, XrefRangeStart = 1259355, XrefRangeEnd = 1259365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<RaycastHit> RaycastAll(Vector3 origin, Vector3 direction, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&origin);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &direction;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxDistance;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &layerMask;
		*(QueryTriggerInteraction**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &queryTriggerInteraction;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RaycastAll_Public_Static_Il2CppStructArray_1_RaycastHit_Vector3_Vector3_Single_Int32_QueryTriggerInteraction_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<RaycastHit>>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259372, XrefRangeEnd = 1259376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<RaycastHit> RaycastAll(Vector3 origin, Vector3 direction, float maxDistance, int layerMask)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&origin);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &direction;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxDistance;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &layerMask;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RaycastAll_Public_Static_Il2CppStructArray_1_RaycastHit_Vector3_Vector3_Single_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<RaycastHit>>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1259380, RefRangeEnd = 1259382, XrefRangeStart = 1259376, XrefRangeEnd = 1259380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<RaycastHit> RaycastAll(Vector3 origin, Vector3 direction, float maxDistance)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&origin);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &direction;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxDistance;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RaycastAll_Public_Static_Il2CppStructArray_1_RaycastHit_Vector3_Vector3_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<RaycastHit>>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259382, XrefRangeEnd = 1259386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<RaycastHit> RaycastAll(Vector3 origin, Vector3 direction)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&origin);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &direction;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RaycastAll_Public_Static_Il2CppStructArray_1_RaycastHit_Vector3_Vector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<RaycastHit>>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259386, XrefRangeEnd = 1259390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<RaycastHit> RaycastAll(Ray ray, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&ray);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxDistance;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &layerMask;
		*(QueryTriggerInteraction**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &queryTriggerInteraction;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RaycastAll_Public_Static_Il2CppStructArray_1_RaycastHit_Ray_Single_Int32_QueryTriggerInteraction_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<RaycastHit>>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259390, XrefRangeEnd = 1259394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<RaycastHit> RaycastAll(Ray ray, float maxDistance, int layerMask)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&ray);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxDistance;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &layerMask;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RaycastAll_Public_Static_Il2CppStructArray_1_RaycastHit_Ray_Single_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<RaycastHit>>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1259398, RefRangeEnd = 1259399, XrefRangeStart = 1259394, XrefRangeEnd = 1259398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<RaycastHit> RaycastAll(Ray ray, float maxDistance)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&ray);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxDistance;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RaycastAll_Public_Static_Il2CppStructArray_1_RaycastHit_Ray_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<RaycastHit>>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259399, XrefRangeEnd = 1259403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<RaycastHit> RaycastAll(Ray ray)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&ray);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RaycastAll_Public_Static_Il2CppStructArray_1_RaycastHit_Ray_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<RaycastHit>>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259403, XrefRangeEnd = 1259407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int RaycastNonAlloc(Ray ray, Il2CppStructArray<RaycastHit> results, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&ray);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)results);
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxDistance;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &layerMask;
		*(QueryTriggerInteraction**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &queryTriggerInteraction;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RaycastNonAlloc_Public_Static_Int32_Ray_Il2CppStructArray_1_RaycastHit_Single_Int32_QueryTriggerInteraction_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259407, XrefRangeEnd = 1259411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int RaycastNonAlloc(Ray ray, Il2CppStructArray<RaycastHit> results, float maxDistance, int layerMask)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&ray);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)results);
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxDistance;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &layerMask;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RaycastNonAlloc_Public_Static_Int32_Ray_Il2CppStructArray_1_RaycastHit_Single_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259411, XrefRangeEnd = 1259427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int RaycastNonAlloc(Ray ray, Il2CppStructArray<RaycastHit> results, float maxDistance)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&ray);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)results);
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxDistance;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RaycastNonAlloc_Public_Static_Int32_Ray_Il2CppStructArray_1_RaycastHit_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259427, XrefRangeEnd = 1259443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int RaycastNonAlloc(Ray ray, Il2CppStructArray<RaycastHit> results)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&ray);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)results);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RaycastNonAlloc_Public_Static_Int32_Ray_Il2CppStructArray_1_RaycastHit_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259443, XrefRangeEnd = 1259447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int RaycastNonAlloc(Vector3 origin, Vector3 direction, Il2CppStructArray<RaycastHit> results, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&origin);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &direction;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)results);
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxDistance;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &layerMask;
		*(QueryTriggerInteraction**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &queryTriggerInteraction;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RaycastNonAlloc_Public_Static_Int32_Vector3_Vector3_Il2CppStructArray_1_RaycastHit_Single_Int32_QueryTriggerInteraction_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259447, XrefRangeEnd = 1259451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int RaycastNonAlloc(Vector3 origin, Vector3 direction, Il2CppStructArray<RaycastHit> results, float maxDistance, int layerMask)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&origin);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &direction;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)results);
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxDistance;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &layerMask;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RaycastNonAlloc_Public_Static_Int32_Vector3_Vector3_Il2CppStructArray_1_RaycastHit_Single_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259451, XrefRangeEnd = 1259467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int RaycastNonAlloc(Vector3 origin, Vector3 direction, Il2CppStructArray<RaycastHit> results, float maxDistance)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&origin);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &direction;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)results);
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxDistance;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RaycastNonAlloc_Public_Static_Int32_Vector3_Vector3_Il2CppStructArray_1_RaycastHit_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259467, XrefRangeEnd = 1259483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int RaycastNonAlloc(Vector3 origin, Vector3 direction, Il2CppStructArray<RaycastHit> results)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&origin);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &direction;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)results);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RaycastNonAlloc_Public_Static_Int32_Vector3_Vector3_Il2CppStructArray_1_RaycastHit_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259485, XrefRangeEnd = 1259493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Collider GetColliderByInstanceID(int instanceID)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&instanceID);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetColliderByInstanceID_Internal_Static_Collider_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Collider>(intPtr2) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1259501, RefRangeEnd = 1259505, XrefRangeStart = 1259493, XrefRangeEnd = 1259501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Component GetBodyByInstanceID(int instanceID)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&instanceID);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBodyByInstanceID_Internal_Static_Component_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Component>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1259513, RefRangeEnd = 1259515, XrefRangeStart = 1259505, XrefRangeEnd = 1259513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SendOnCollisionEnter(Component component, Collision collision)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)component);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)collision);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SendOnCollisionEnter_Private_Static_Void_Component_Collision_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1259542, RefRangeEnd = 1259544, XrefRangeStart = 1259515, XrefRangeEnd = 1259542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SendOnCollisionStay(Component component, Collision collision)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)component);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)collision);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SendOnCollisionStay_Private_Static_Void_Component_Collision_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1259552, RefRangeEnd = 1259554, XrefRangeStart = 1259544, XrefRangeEnd = 1259552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SendOnCollisionExit(Component component, Collision collision)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)component);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)collision);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SendOnCollisionExit_Private_Static_Void_Component_Collision_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259554, XrefRangeEnd = 1259576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void OnSceneContact(PhysicsScene scene, System.IntPtr buffer, int count)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&scene);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &buffer;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnSceneContact_Private_Static_Void_PhysicsScene_IntPtr_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1259627, RefRangeEnd = 1259628, XrefRangeStart = 1259576, XrefRangeEnd = 1259627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ReportContacts(NativeArray<ContactPairHeader>.ReadOnly array)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)array));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReportContacts_Private_Static_Void_ReadOnly_ContactPairHeader_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 1259644, RefRangeEnd = 1259650, XrefRangeStart = 1259628, XrefRangeEnd = 1259644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Collision GetCollisionToReport([In] ref ContactPairHeader header, [In] ref ContactPair pair, bool flipped)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)Unsafe.AsPointer(ref header);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref pair);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &flipped;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCollisionToReport_Private_Static_Collision_byref_ContactPairHeader_byref_ContactPair_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Collision>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259650, XrefRangeEnd = 1259652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Internal_RaycastAll_Injected([In] ref PhysicsScene physicsScene, [In] ref Ray ray, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction, out BlittableArrayWrapper ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)Unsafe.AsPointer(ref physicsScene);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ray);
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxDistance;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &mask;
		*(QueryTriggerInteraction**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &queryTriggerInteraction;
		*(void**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_RaycastAll_Injected_Private_Static_Void_byref_PhysicsScene_byref_Ray_Single_Int32_QueryTriggerInteraction_byref_BlittableArrayWrapper_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259652, XrefRangeEnd = 1259654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr GetColliderByInstanceID_Injected(int instanceID)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&instanceID);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetColliderByInstanceID_Injected_Private_Static_IntPtr_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259654, XrefRangeEnd = 1259656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr GetBodyByInstanceID_Injected(int instanceID)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&instanceID);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBodyByInstanceID_Injected_Private_Static_IntPtr_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259656, XrefRangeEnd = 1259658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SendOnCollisionEnter_Injected(System.IntPtr component, Collision collision)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&component);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)collision);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SendOnCollisionEnter_Injected_Private_Static_Void_IntPtr_Collision_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259658, XrefRangeEnd = 1259660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SendOnCollisionStay_Injected(System.IntPtr component, Collision collision)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&component);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)collision);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SendOnCollisionStay_Injected_Private_Static_Void_IntPtr_Collision_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259660, XrefRangeEnd = 1259662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SendOnCollisionExit_Injected(System.IntPtr component, Collision collision)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&component);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)collision);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SendOnCollisionExit_Injected_Private_Static_Void_IntPtr_Collision_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public Physics(System.IntPtr pointer)
		: base(pointer)
	{
	}

	[SpecialName]
	public static void add_ContactModifyEvent(Il2CppSystem.Action<PhysicsScene, NativeArray<ModifiableContactPair>> value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	[SpecialName]
	public static void remove_ContactModifyEvent(Il2CppSystem.Action<PhysicsScene, NativeArray<ModifiableContactPair>> value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	[SpecialName]
	public static void add_ContactModifyEventCCD(Il2CppSystem.Action<PhysicsScene, NativeArray<ModifiableContactPair>> value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	[SpecialName]
	public static void remove_ContactModifyEventCCD(Il2CppSystem.Action<PhysicsScene, NativeArray<ModifiableContactPair>> value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	[SpecialName]
	public static void add_GenericContactModifyEvent(Il2CppSystem.Action<PhysicsScene, System.IntPtr, int, bool> value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	[SpecialName]
	public static void remove_GenericContactModifyEvent(Il2CppSystem.Action<PhysicsScene, System.IntPtr, int, bool> value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public unsafe static void GetIntegrationInfos(out System.IntPtr integrations, out ulong integrationCount)
	{
		GetIntegrationInfosDelegateField((nint)Unsafe.AsPointer(ref integrations), (nint)Unsafe.AsPointer(ref integrationCount));
	}

	public unsafe static void GetCurrentIntegrationInfo(out System.IntPtr integration)
	{
		GetCurrentIntegrationInfoDelegateField((nint)Unsafe.AsPointer(ref integration));
	}

	public static void IgnoreCollision(Collider collider1, Collider collider2, bool ignore)
	{
		if ((object)collider1 == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(collider1, "collider1");
		}
		if ((object)collider2 == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(collider2, "collider2");
		}
		System.IntPtr intPtr = Object.MarshalledUnityObject.MarshalNotNull(collider1);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(collider1, "collider1");
		}
		System.IntPtr intPtr2 = Object.MarshalledUnityObject.MarshalNotNull(collider2);
		if (intPtr2 == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(collider2, "collider2");
		}
		IgnoreCollision_Injected(intPtr, intPtr2, ignore);
	}

	public static void IgnoreCollision(Collider collider1, Collider collider2)
	{
		IgnoreCollision(collider1, collider2, ignore: true);
	}

	public static void IgnoreLayerCollision(int layer1, int layer2, bool ignore)
	{
		IgnoreLayerCollisionDelegateField(layer1, layer2, ignore);
	}

	public static void IgnoreLayerCollision(int layer1, int layer2)
	{
		IgnoreLayerCollision(layer1, layer2, ignore: true);
	}

	public static bool GetIgnoreLayerCollision(int layer1, int layer2)
	{
		return GetIgnoreLayerCollisionDelegateField(layer1, layer2);
	}

	public static bool GetIgnoreCollision(Collider collider1, Collider collider2)
	{
		if ((object)collider1 == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(collider1, "collider1");
		}
		if ((object)collider2 == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(collider2, "collider2");
		}
		System.IntPtr intPtr = Object.MarshalledUnityObject.MarshalNotNull(collider1);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(collider1, "collider1");
		}
		System.IntPtr intPtr2 = Object.MarshalledUnityObject.MarshalNotNull(collider2);
		if (intPtr2 == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(collider2, "collider2");
		}
		return GetIgnoreCollision_Injected(intPtr, intPtr2);
	}

	public static bool Linecast(Vector3 start, Vector3 end, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
	{
		Vector3 direction = end - start;
		return defaultPhysicsScene.Raycast(start, direction, direction.magnitude, layerMask, queryTriggerInteraction);
	}

	public static bool Linecast(Vector3 start, Vector3 end, int layerMask)
	{
		return Linecast(start, end, layerMask, QueryTriggerInteraction.UseGlobal);
	}

	public static bool Linecast(Vector3 start, Vector3 end)
	{
		return Linecast(start, end, -5, QueryTriggerInteraction.UseGlobal);
	}

	public static bool Linecast(Vector3 start, Vector3 end, out RaycastHit hitInfo, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
	{
		Vector3 direction = end - start;
		return defaultPhysicsScene.Raycast(start, direction, out hitInfo, direction.magnitude, layerMask, queryTriggerInteraction);
	}

	public static bool Linecast(Vector3 start, Vector3 end, out RaycastHit hitInfo, int layerMask)
	{
		return Linecast(start, end, out hitInfo, layerMask, QueryTriggerInteraction.UseGlobal);
	}

	public static bool Linecast(Vector3 start, Vector3 end, out RaycastHit hitInfo)
	{
		return Linecast(start, end, out hitInfo, -5, QueryTriggerInteraction.UseGlobal);
	}

	public static bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
	{
		RaycastHit hitInfo;
		return defaultPhysicsScene.CapsuleCast(point1, point2, radius, direction, out hitInfo, maxDistance, layerMask, queryTriggerInteraction);
	}

	public static bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, float maxDistance, int layerMask)
	{
		return CapsuleCast(point1, point2, radius, direction, maxDistance, layerMask, QueryTriggerInteraction.UseGlobal);
	}

	public static bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, float maxDistance)
	{
		return CapsuleCast(point1, point2, radius, direction, maxDistance, -5, QueryTriggerInteraction.UseGlobal);
	}

	public static bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction)
	{
		return CapsuleCast(point1, point2, radius, direction, float.PositiveInfinity, -5, QueryTriggerInteraction.UseGlobal);
	}

	public static bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
	{
		return defaultPhysicsScene.CapsuleCast(point1, point2, radius, direction, out hitInfo, maxDistance, layerMask, queryTriggerInteraction);
	}

	public static bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask)
	{
		return CapsuleCast(point1, point2, radius, direction, out hitInfo, maxDistance, layerMask, QueryTriggerInteraction.UseGlobal);
	}

	public static bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance)
	{
		return CapsuleCast(point1, point2, radius, direction, out hitInfo, maxDistance, -5, QueryTriggerInteraction.UseGlobal);
	}

	public static bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, out RaycastHit hitInfo)
	{
		return CapsuleCast(point1, point2, radius, direction, out hitInfo, float.PositiveInfinity, -5, QueryTriggerInteraction.UseGlobal);
	}

	public static bool SphereCast(Vector3 origin, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
	{
		return defaultPhysicsScene.SphereCast(origin, radius, direction, out hitInfo, maxDistance, layerMask, queryTriggerInteraction);
	}

	public static bool SphereCast(Vector3 origin, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask)
	{
		return SphereCast(origin, radius, direction, out hitInfo, maxDistance, layerMask, QueryTriggerInteraction.UseGlobal);
	}

	public static bool SphereCast(Vector3 origin, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance)
	{
		return SphereCast(origin, radius, direction, out hitInfo, maxDistance, -5, QueryTriggerInteraction.UseGlobal);
	}

	public static bool SphereCast(Vector3 origin, float radius, Vector3 direction, out RaycastHit hitInfo)
	{
		return SphereCast(origin, radius, direction, out hitInfo, float.PositiveInfinity, -5, QueryTriggerInteraction.UseGlobal);
	}

	public static bool SphereCast(Ray ray, float radius, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
	{
		RaycastHit hitInfo;
		return SphereCast(ray.origin, radius, ray.direction, out hitInfo, maxDistance, layerMask, queryTriggerInteraction);
	}

	public static bool SphereCast(Ray ray, float radius, float maxDistance, int layerMask)
	{
		return SphereCast(ray, radius, maxDistance, layerMask, QueryTriggerInteraction.UseGlobal);
	}

	public static bool SphereCast(Ray ray, float radius, float maxDistance)
	{
		return SphereCast(ray, radius, maxDistance, -5, QueryTriggerInteraction.UseGlobal);
	}

	public static bool SphereCast(Ray ray, float radius)
	{
		return SphereCast(ray, radius, float.PositiveInfinity, -5, QueryTriggerInteraction.UseGlobal);
	}

	public static bool SphereCast(Ray ray, float radius, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
	{
		return SphereCast(ray.origin, radius, ray.direction, out hitInfo, maxDistance, layerMask, queryTriggerInteraction);
	}

	public static bool SphereCast(Ray ray, float radius, out RaycastHit hitInfo, float maxDistance, int layerMask)
	{
		return SphereCast(ray, radius, out hitInfo, maxDistance, layerMask, QueryTriggerInteraction.UseGlobal);
	}

	public static bool SphereCast(Ray ray, float radius, out RaycastHit hitInfo, float maxDistance)
	{
		return SphereCast(ray, radius, out hitInfo, maxDistance, -5, QueryTriggerInteraction.UseGlobal);
	}

	public static bool SphereCast(Ray ray, float radius, out RaycastHit hitInfo)
	{
		return SphereCast(ray, radius, out hitInfo, float.PositiveInfinity, -5, QueryTriggerInteraction.UseGlobal);
	}

	public static bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, Quaternion orientation, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
	{
		RaycastHit hitInfo;
		return defaultPhysicsScene.BoxCast(center, halfExtents, direction, out hitInfo, orientation, maxDistance, layerMask, queryTriggerInteraction);
	}

	public static bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, Quaternion orientation, float maxDistance, int layerMask)
	{
		return BoxCast(center, halfExtents, direction, orientation, maxDistance, layerMask, QueryTriggerInteraction.UseGlobal);
	}

	public static bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, Quaternion orientation, float maxDistance)
	{
		return BoxCast(center, halfExtents, direction, orientation, maxDistance, -5, QueryTriggerInteraction.UseGlobal);
	}

	public static bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, Quaternion orientation)
	{
		return BoxCast(center, halfExtents, direction, orientation, float.PositiveInfinity, -5, QueryTriggerInteraction.UseGlobal);
	}

	public static bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction)
	{
		return BoxCast(center, halfExtents, direction, Quaternion.identity, float.PositiveInfinity, -5, QueryTriggerInteraction.UseGlobal);
	}

	public static bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, out RaycastHit hitInfo, Quaternion orientation, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
	{
		return defaultPhysicsScene.BoxCast(center, halfExtents, direction, out hitInfo, orientation, maxDistance, layerMask, queryTriggerInteraction);
	}

	public static bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, out RaycastHit hitInfo, Quaternion orientation, float maxDistance, int layerMask)
	{
		return BoxCast(center, halfExtents, direction, out hitInfo, orientation, maxDistance, layerMask, QueryTriggerInteraction.UseGlobal);
	}

	public static bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, out RaycastHit hitInfo, Quaternion orientation, float maxDistance)
	{
		return BoxCast(center, halfExtents, direction, out hitInfo, orientation, maxDistance, -5, QueryTriggerInteraction.UseGlobal);
	}

	public static bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, out RaycastHit hitInfo, Quaternion orientation)
	{
		return BoxCast(center, halfExtents, direction, out hitInfo, orientation, float.PositiveInfinity, -5, QueryTriggerInteraction.UseGlobal);
	}

	public static bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, out RaycastHit hitInfo)
	{
		return BoxCast(center, halfExtents, direction, out hitInfo, Quaternion.identity, float.PositiveInfinity, -5, QueryTriggerInteraction.UseGlobal);
	}

	public unsafe static Il2CppStructArray<RaycastHit> Query_CapsuleCastAll(PhysicsScene physicsScene, Vector3 p0, Vector3 p1, float radius, Vector3 direction, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction)
	{
		Unsafe.SkipInit(out BlittableArrayWrapper ret);
		Il2CppStructArray<RaycastHit> result;
		try
		{
			Query_CapsuleCastAll_Injected(ref physicsScene, ref p0, ref p1, radius, ref direction, maxDistance, mask, queryTriggerInteraction, out ret);
		}
		finally
		{
			Unsafe.SkipInit(out Il2CppStructArray<RaycastHit> array);
			ret.Unmarshal(ref *(Il2CppArrayBase<RaycastHit>*)(&array));
			result = array;
		}
		return result;
	}

	public static Il2CppStructArray<RaycastHit> CapsuleCastAll(Vector3 point1, Vector3 point2, float radius, Vector3 direction, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public static Il2CppStructArray<RaycastHit> CapsuleCastAll(Vector3 point1, Vector3 point2, float radius, Vector3 direction, float maxDistance, int layerMask)
	{
		return CapsuleCastAll(point1, point2, radius, direction, maxDistance, layerMask, QueryTriggerInteraction.UseGlobal);
	}

	public static Il2CppStructArray<RaycastHit> CapsuleCastAll(Vector3 point1, Vector3 point2, float radius, Vector3 direction, float maxDistance)
	{
		return CapsuleCastAll(point1, point2, radius, direction, maxDistance, -5, QueryTriggerInteraction.UseGlobal);
	}

	public static Il2CppStructArray<RaycastHit> CapsuleCastAll(Vector3 point1, Vector3 point2, float radius, Vector3 direction)
	{
		return CapsuleCastAll(point1, point2, radius, direction, float.PositiveInfinity, -5, QueryTriggerInteraction.UseGlobal);
	}

	public unsafe static Il2CppStructArray<RaycastHit> Query_SphereCastAll(PhysicsScene physicsScene, Vector3 origin, float radius, Vector3 direction, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction)
	{
		Unsafe.SkipInit(out BlittableArrayWrapper ret);
		Il2CppStructArray<RaycastHit> result;
		try
		{
			Query_SphereCastAll_Injected(ref physicsScene, ref origin, radius, ref direction, maxDistance, mask, queryTriggerInteraction, out ret);
		}
		finally
		{
			Unsafe.SkipInit(out Il2CppStructArray<RaycastHit> array);
			ret.Unmarshal(ref *(Il2CppArrayBase<RaycastHit>*)(&array));
			result = array;
		}
		return result;
	}

	public static Il2CppStructArray<RaycastHit> SphereCastAll(Vector3 origin, float radius, Vector3 direction, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public static Il2CppStructArray<RaycastHit> SphereCastAll(Vector3 origin, float radius, Vector3 direction, float maxDistance, int layerMask)
	{
		return SphereCastAll(origin, radius, direction, maxDistance, layerMask, QueryTriggerInteraction.UseGlobal);
	}

	public static Il2CppStructArray<RaycastHit> SphereCastAll(Vector3 origin, float radius, Vector3 direction, float maxDistance)
	{
		return SphereCastAll(origin, radius, direction, maxDistance, -5, QueryTriggerInteraction.UseGlobal);
	}

	public static Il2CppStructArray<RaycastHit> SphereCastAll(Vector3 origin, float radius, Vector3 direction)
	{
		return SphereCastAll(origin, radius, direction, float.PositiveInfinity, -5, QueryTriggerInteraction.UseGlobal);
	}

	public static Il2CppStructArray<RaycastHit> SphereCastAll(Ray ray, float radius, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
	{
		return SphereCastAll(ray.origin, radius, ray.direction, maxDistance, layerMask, queryTriggerInteraction);
	}

	public static Il2CppStructArray<RaycastHit> SphereCastAll(Ray ray, float radius, float maxDistance, int layerMask)
	{
		return SphereCastAll(ray, radius, maxDistance, layerMask, QueryTriggerInteraction.UseGlobal);
	}

	public static Il2CppStructArray<RaycastHit> SphereCastAll(Ray ray, float radius, float maxDistance)
	{
		return SphereCastAll(ray, radius, maxDistance, -5, QueryTriggerInteraction.UseGlobal);
	}

	public static Il2CppStructArray<RaycastHit> SphereCastAll(Ray ray, float radius)
	{
		return SphereCastAll(ray, radius, float.PositiveInfinity, -5, QueryTriggerInteraction.UseGlobal);
	}

	public static Il2CppReferenceArray<Collider> OverlapCapsule_Internal(PhysicsScene physicsScene, Vector3 point0, Vector3 point1, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
	{
		return OverlapCapsule_Internal_Injected(ref physicsScene, ref point0, ref point1, radius, layerMask, queryTriggerInteraction);
	}

	public static Il2CppReferenceArray<Collider> OverlapCapsule(Vector3 point0, Vector3 point1, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
	{
		return OverlapCapsule_Internal(defaultPhysicsScene, point0, point1, radius, layerMask, queryTriggerInteraction);
	}

	public static Il2CppReferenceArray<Collider> OverlapCapsule(Vector3 point0, Vector3 point1, float radius, int layerMask)
	{
		return OverlapCapsule(point0, point1, radius, layerMask, QueryTriggerInteraction.UseGlobal);
	}

	public static Il2CppReferenceArray<Collider> OverlapCapsule(Vector3 point0, Vector3 point1, float radius)
	{
		return OverlapCapsule(point0, point1, radius, -1, QueryTriggerInteraction.UseGlobal);
	}

	public static Il2CppReferenceArray<Collider> OverlapSphere_Internal(PhysicsScene physicsScene, Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
	{
		return OverlapSphere_Internal_Injected(ref physicsScene, ref position, radius, layerMask, queryTriggerInteraction);
	}

	public static Il2CppReferenceArray<Collider> OverlapSphere(Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
	{
		return OverlapSphere_Internal(defaultPhysicsScene, position, radius, layerMask, queryTriggerInteraction);
	}

	public static Il2CppReferenceArray<Collider> OverlapSphere(Vector3 position, float radius, int layerMask)
	{
		return OverlapSphere(position, radius, layerMask, QueryTriggerInteraction.UseGlobal);
	}

	public static Il2CppReferenceArray<Collider> OverlapSphere(Vector3 position, float radius)
	{
		return OverlapSphere(position, radius, -1, QueryTriggerInteraction.UseGlobal);
	}

	public static void Simulate_Internal(PhysicsScene physicsScene, float step, SimulationStage stages, SimulationOption options)
	{
		Simulate_Internal_Injected(ref physicsScene, step, stages, options);
	}

	public static void Simulate(float step)
	{
		if (simulationMode != SimulationMode.Script)
		{
			Debug.LogWarning("Physics.Simulate(...) was called but simulation mode is not set to Script. You should set simulation mode to Script first before calling this function therefore the simulation was not run.");
		}
		else
		{
			Simulate_Internal(defaultPhysicsScene, step, SimulationStage.All, SimulationOption.All);
		}
	}

	public static void InterpolateBodies_Internal(PhysicsScene physicsScene)
	{
		InterpolateBodies_Internal_Injected(ref physicsScene);
	}

	public static void ResetInterpolationPoses_Internal(PhysicsScene physicsScene)
	{
		ResetInterpolationPoses_Internal_Injected(ref physicsScene);
	}

	public static void SyncTransforms()
	{
		SyncTransformsDelegateField();
	}

	public static bool Query_ComputePenetration(Collider colliderA, Vector3 positionA, Quaternion rotationA, Collider colliderB, Vector3 positionB, Quaternion rotationB, ref Vector3 direction, ref float distance)
	{
		if ((object)colliderA == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(colliderA, "colliderA");
		}
		if ((object)colliderB == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(colliderB, "colliderB");
		}
		System.IntPtr intPtr = Object.MarshalledUnityObject.MarshalNotNull(colliderA);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(colliderA, "colliderA");
		}
		System.IntPtr intPtr2 = Object.MarshalledUnityObject.MarshalNotNull(colliderB);
		if (intPtr2 == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(colliderB, "colliderB");
		}
		return Query_ComputePenetration_Injected(intPtr, ref positionA, ref rotationA, intPtr2, ref positionB, ref rotationB, ref direction, ref distance);
	}

	public static bool ComputePenetration(Collider colliderA, Vector3 positionA, Quaternion rotationA, Collider colliderB, Vector3 positionB, Quaternion rotationB, out Vector3 direction, out float distance)
	{
		direction = Vector3.zero;
		distance = 0f;
		return Query_ComputePenetration(colliderA, positionA, rotationA, colliderB, positionB, rotationB, ref direction, ref distance);
	}

	public static Vector3 Query_ClosestPoint(Collider collider, Vector3 position, Quaternion rotation, Vector3 point)
	{
		if ((object)collider == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(collider, "collider");
		}
		System.IntPtr intPtr = Object.MarshalledUnityObject.MarshalNotNull(collider);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(collider, "collider");
		}
		Query_ClosestPoint_Injected(intPtr, ref position, ref rotation, ref point, out var ret);
		return ret;
	}

	public static Vector3 ClosestPoint(Vector3 point, Collider collider, Vector3 position, Quaternion rotation)
	{
		return Query_ClosestPoint(collider, position, rotation, point);
	}

	public static int OverlapSphereNonAlloc(Vector3 position, float radius, Il2CppReferenceArray<Collider> results, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
	{
		return defaultPhysicsScene.OverlapSphere(position, radius, results, layerMask, queryTriggerInteraction);
	}

	public static int OverlapSphereNonAlloc(Vector3 position, float radius, Il2CppReferenceArray<Collider> results, int layerMask)
	{
		return OverlapSphereNonAlloc(position, radius, results, layerMask, QueryTriggerInteraction.UseGlobal);
	}

	public static int OverlapSphereNonAlloc(Vector3 position, float radius, Il2CppReferenceArray<Collider> results)
	{
		return OverlapSphereNonAlloc(position, radius, results, -1, QueryTriggerInteraction.UseGlobal);
	}

	public static bool CheckSphere_Internal(PhysicsScene physicsScene, Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
	{
		return CheckSphere_Internal_Injected(ref physicsScene, ref position, radius, layerMask, queryTriggerInteraction);
	}

	public static bool CheckSphere(Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
	{
		return CheckSphere_Internal(defaultPhysicsScene, position, radius, layerMask, queryTriggerInteraction);
	}

	public static bool CheckSphere(Vector3 position, float radius, int layerMask)
	{
		return CheckSphere(position, radius, layerMask, QueryTriggerInteraction.UseGlobal);
	}

	public static bool CheckSphere(Vector3 position, float radius)
	{
		return CheckSphere(position, radius, -5, QueryTriggerInteraction.UseGlobal);
	}

	public static int CapsuleCastNonAlloc(Vector3 point1, Vector3 point2, float radius, Vector3 direction, Il2CppStructArray<RaycastHit> results, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
	{
		return defaultPhysicsScene.CapsuleCast(point1, point2, radius, direction, results, maxDistance, layerMask, queryTriggerInteraction);
	}

	public static int CapsuleCastNonAlloc(Vector3 point1, Vector3 point2, float radius, Vector3 direction, Il2CppStructArray<RaycastHit> results, float maxDistance, int layerMask)
	{
		return CapsuleCastNonAlloc(point1, point2, radius, direction, results, maxDistance, layerMask, QueryTriggerInteraction.UseGlobal);
	}

	public static int CapsuleCastNonAlloc(Vector3 point1, Vector3 point2, float radius, Vector3 direction, Il2CppStructArray<RaycastHit> results, float maxDistance)
	{
		return CapsuleCastNonAlloc(point1, point2, radius, direction, results, maxDistance, -5, QueryTriggerInteraction.UseGlobal);
	}

	public static int CapsuleCastNonAlloc(Vector3 point1, Vector3 point2, float radius, Vector3 direction, Il2CppStructArray<RaycastHit> results)
	{
		return CapsuleCastNonAlloc(point1, point2, radius, direction, results, float.PositiveInfinity, -5, QueryTriggerInteraction.UseGlobal);
	}

	public static int SphereCastNonAlloc(Vector3 origin, float radius, Vector3 direction, Il2CppStructArray<RaycastHit> results, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
	{
		return defaultPhysicsScene.SphereCast(origin, radius, direction, results, maxDistance, layerMask, queryTriggerInteraction);
	}

	public static int SphereCastNonAlloc(Vector3 origin, float radius, Vector3 direction, Il2CppStructArray<RaycastHit> results, float maxDistance, int layerMask)
	{
		return SphereCastNonAlloc(origin, radius, direction, results, maxDistance, layerMask, QueryTriggerInteraction.UseGlobal);
	}

	public static int SphereCastNonAlloc(Vector3 origin, float radius, Vector3 direction, Il2CppStructArray<RaycastHit> results, float maxDistance)
	{
		return SphereCastNonAlloc(origin, radius, direction, results, maxDistance, -5, QueryTriggerInteraction.UseGlobal);
	}

	public static int SphereCastNonAlloc(Vector3 origin, float radius, Vector3 direction, Il2CppStructArray<RaycastHit> results)
	{
		return SphereCastNonAlloc(origin, radius, direction, results, float.PositiveInfinity, -5, QueryTriggerInteraction.UseGlobal);
	}

	public static int SphereCastNonAlloc(Ray ray, float radius, Il2CppStructArray<RaycastHit> results, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
	{
		return SphereCastNonAlloc(ray.origin, radius, ray.direction, results, maxDistance, layerMask, queryTriggerInteraction);
	}

	public static int SphereCastNonAlloc(Ray ray, float radius, Il2CppStructArray<RaycastHit> results, float maxDistance, int layerMask)
	{
		return SphereCastNonAlloc(ray, radius, results, maxDistance, layerMask, QueryTriggerInteraction.UseGlobal);
	}

	public static int SphereCastNonAlloc(Ray ray, float radius, Il2CppStructArray<RaycastHit> results, float maxDistance)
	{
		return SphereCastNonAlloc(ray, radius, results, maxDistance, -5, QueryTriggerInteraction.UseGlobal);
	}

	public static int SphereCastNonAlloc(Ray ray, float radius, Il2CppStructArray<RaycastHit> results)
	{
		return SphereCastNonAlloc(ray, radius, results, float.PositiveInfinity, -5, QueryTriggerInteraction.UseGlobal);
	}

	public static bool CheckCapsule_Internal(PhysicsScene physicsScene, Vector3 start, Vector3 end, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
	{
		return CheckCapsule_Internal_Injected(ref physicsScene, ref start, ref end, radius, layerMask, queryTriggerInteraction);
	}

	public static bool CheckCapsule(Vector3 start, Vector3 end, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
	{
		return CheckCapsule_Internal(defaultPhysicsScene, start, end, radius, layerMask, queryTriggerInteraction);
	}

	public static bool CheckCapsule(Vector3 start, Vector3 end, float radius, int layerMask)
	{
		return CheckCapsule(start, end, radius, layerMask, QueryTriggerInteraction.UseGlobal);
	}

	public static bool CheckCapsule(Vector3 start, Vector3 end, float radius)
	{
		return CheckCapsule(start, end, radius, -5, QueryTriggerInteraction.UseGlobal);
	}

	public static bool CheckBox_Internal(PhysicsScene physicsScene, Vector3 center, Vector3 halfExtents, Quaternion orientation, int layermask, QueryTriggerInteraction queryTriggerInteraction)
	{
		return CheckBox_Internal_Injected(ref physicsScene, ref center, ref halfExtents, ref orientation, layermask, queryTriggerInteraction);
	}

	public static bool CheckBox(Vector3 center, Vector3 halfExtents, Quaternion orientation, int layermask, QueryTriggerInteraction queryTriggerInteraction)
	{
		return CheckBox_Internal(defaultPhysicsScene, center, halfExtents, orientation, layermask, queryTriggerInteraction);
	}

	public static bool CheckBox(Vector3 center, Vector3 halfExtents, Quaternion orientation, int layerMask)
	{
		return CheckBox(center, halfExtents, orientation, layerMask, QueryTriggerInteraction.UseGlobal);
	}

	public static bool CheckBox(Vector3 center, Vector3 halfExtents, Quaternion orientation)
	{
		return CheckBox(center, halfExtents, orientation, -5, QueryTriggerInteraction.UseGlobal);
	}

	public static bool CheckBox(Vector3 center, Vector3 halfExtents)
	{
		return CheckBox(center, halfExtents, Quaternion.identity, -5, QueryTriggerInteraction.UseGlobal);
	}

	public static Il2CppReferenceArray<Collider> OverlapBox_Internal(PhysicsScene physicsScene, Vector3 center, Vector3 halfExtents, Quaternion orientation, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
	{
		return OverlapBox_Internal_Injected(ref physicsScene, ref center, ref halfExtents, ref orientation, layerMask, queryTriggerInteraction);
	}

	public static Il2CppReferenceArray<Collider> OverlapBox(Vector3 center, Vector3 halfExtents, Quaternion orientation, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
	{
		return OverlapBox_Internal(defaultPhysicsScene, center, halfExtents, orientation, layerMask, queryTriggerInteraction);
	}

	public static Il2CppReferenceArray<Collider> OverlapBox(Vector3 center, Vector3 halfExtents, Quaternion orientation, int layerMask)
	{
		return OverlapBox(center, halfExtents, orientation, layerMask, QueryTriggerInteraction.UseGlobal);
	}

	public static Il2CppReferenceArray<Collider> OverlapBox(Vector3 center, Vector3 halfExtents, Quaternion orientation)
	{
		return OverlapBox(center, halfExtents, orientation, -1, QueryTriggerInteraction.UseGlobal);
	}

	public static Il2CppReferenceArray<Collider> OverlapBox(Vector3 center, Vector3 halfExtents)
	{
		return OverlapBox(center, halfExtents, Quaternion.identity, -1, QueryTriggerInteraction.UseGlobal);
	}

	public static int OverlapBoxNonAlloc(Vector3 center, Vector3 halfExtents, Il2CppReferenceArray<Collider> results, Quaternion orientation, int mask, QueryTriggerInteraction queryTriggerInteraction)
	{
		return defaultPhysicsScene.OverlapBox(center, halfExtents, results, orientation, mask, queryTriggerInteraction);
	}

	public static int OverlapBoxNonAlloc(Vector3 center, Vector3 halfExtents, Il2CppReferenceArray<Collider> results, Quaternion orientation, int mask)
	{
		return OverlapBoxNonAlloc(center, halfExtents, results, orientation, mask, QueryTriggerInteraction.UseGlobal);
	}

	public static int OverlapBoxNonAlloc(Vector3 center, Vector3 halfExtents, Il2CppReferenceArray<Collider> results, Quaternion orientation)
	{
		return OverlapBoxNonAlloc(center, halfExtents, results, orientation, -1, QueryTriggerInteraction.UseGlobal);
	}

	public static int OverlapBoxNonAlloc(Vector3 center, Vector3 halfExtents, Il2CppReferenceArray<Collider> results)
	{
		return OverlapBoxNonAlloc(center, halfExtents, results, Quaternion.identity, -1, QueryTriggerInteraction.UseGlobal);
	}

	public static int BoxCastNonAlloc(Vector3 center, Vector3 halfExtents, Vector3 direction, Il2CppStructArray<RaycastHit> results, Quaternion orientation, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
	{
		return defaultPhysicsScene.BoxCast(center, halfExtents, direction, results, orientation, maxDistance, layerMask, queryTriggerInteraction);
	}

	public static int BoxCastNonAlloc(Vector3 center, Vector3 halfExtents, Vector3 direction, Il2CppStructArray<RaycastHit> results, Quaternion orientation)
	{
		return BoxCastNonAlloc(center, halfExtents, direction, results, orientation, float.PositiveInfinity, -5, QueryTriggerInteraction.UseGlobal);
	}

	public static int BoxCastNonAlloc(Vector3 center, Vector3 halfExtents, Vector3 direction, Il2CppStructArray<RaycastHit> results, Quaternion orientation, float maxDistance)
	{
		return BoxCastNonAlloc(center, halfExtents, direction, results, orientation, maxDistance, -5, QueryTriggerInteraction.UseGlobal);
	}

	public static int BoxCastNonAlloc(Vector3 center, Vector3 halfExtents, Vector3 direction, Il2CppStructArray<RaycastHit> results, Quaternion orientation, float maxDistance, int layerMask)
	{
		return BoxCastNonAlloc(center, halfExtents, direction, results, orientation, maxDistance, layerMask, QueryTriggerInteraction.UseGlobal);
	}

	public static int BoxCastNonAlloc(Vector3 center, Vector3 halfExtents, Vector3 direction, Il2CppStructArray<RaycastHit> results)
	{
		return BoxCastNonAlloc(center, halfExtents, direction, results, Quaternion.identity, float.PositiveInfinity, -5, QueryTriggerInteraction.UseGlobal);
	}

	public unsafe static Il2CppStructArray<RaycastHit> Internal_BoxCastAll(PhysicsScene physicsScene, Vector3 center, Vector3 halfExtents, Vector3 direction, Quaternion orientation, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
	{
		Unsafe.SkipInit(out BlittableArrayWrapper ret);
		Il2CppStructArray<RaycastHit> result;
		try
		{
			Internal_BoxCastAll_Injected(ref physicsScene, ref center, ref halfExtents, ref direction, ref orientation, maxDistance, layerMask, queryTriggerInteraction, out ret);
		}
		finally
		{
			Unsafe.SkipInit(out Il2CppStructArray<RaycastHit> array);
			ret.Unmarshal(ref *(Il2CppArrayBase<RaycastHit>*)(&array));
			result = array;
		}
		return result;
	}

	public static Il2CppStructArray<RaycastHit> BoxCastAll(Vector3 center, Vector3 halfExtents, Vector3 direction, Quaternion orientation, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public static Il2CppStructArray<RaycastHit> BoxCastAll(Vector3 center, Vector3 halfExtents, Vector3 direction, Quaternion orientation, float maxDistance, int layerMask)
	{
		return BoxCastAll(center, halfExtents, direction, orientation, maxDistance, layerMask, QueryTriggerInteraction.UseGlobal);
	}

	public static Il2CppStructArray<RaycastHit> BoxCastAll(Vector3 center, Vector3 halfExtents, Vector3 direction, Quaternion orientation, float maxDistance)
	{
		return BoxCastAll(center, halfExtents, direction, orientation, maxDistance, -5, QueryTriggerInteraction.UseGlobal);
	}

	public static Il2CppStructArray<RaycastHit> BoxCastAll(Vector3 center, Vector3 halfExtents, Vector3 direction, Quaternion orientation)
	{
		return BoxCastAll(center, halfExtents, direction, orientation, float.PositiveInfinity, -5, QueryTriggerInteraction.UseGlobal);
	}

	public static Il2CppStructArray<RaycastHit> BoxCastAll(Vector3 center, Vector3 halfExtents, Vector3 direction)
	{
		return BoxCastAll(center, halfExtents, direction, Quaternion.identity, float.PositiveInfinity, -5, QueryTriggerInteraction.UseGlobal);
	}

	public static int OverlapCapsuleNonAlloc(Vector3 point0, Vector3 point1, float radius, Il2CppReferenceArray<Collider> results, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
	{
		return defaultPhysicsScene.OverlapCapsule(point0, point1, radius, results, layerMask, queryTriggerInteraction);
	}

	public static int OverlapCapsuleNonAlloc(Vector3 point0, Vector3 point1, float radius, Il2CppReferenceArray<Collider> results, int layerMask)
	{
		return OverlapCapsuleNonAlloc(point0, point1, radius, results, layerMask, QueryTriggerInteraction.UseGlobal);
	}

	public static int OverlapCapsuleNonAlloc(Vector3 point0, Vector3 point1, float radius, Il2CppReferenceArray<Collider> results)
	{
		return OverlapCapsuleNonAlloc(point0, point1, radius, results, -1, QueryTriggerInteraction.UseGlobal);
	}

	public static void RebuildBroadphaseRegions(Bounds worldBounds, int subdivisions)
	{
		RebuildBroadphaseRegions_Injected(ref worldBounds, subdivisions);
	}

	public static void BakeMesh(int meshID, bool convex, MeshColliderCookingOptions cookingOptions)
	{
		BakeMeshDelegateField(meshID, convex, cookingOptions);
	}

	public static void BakeMesh(int meshID, bool convex)
	{
		BakeMesh(meshID, convex, MeshColliderCookingOptions.CookForFasterSimulation | MeshColliderCookingOptions.EnableMeshCleaning | MeshColliderCookingOptions.WeldColocatedVertices | MeshColliderCookingOptions.UseFastMidphase);
	}

	public static bool ConnectPhysicsSDKVisualDebugger()
	{
		return ConnectPhysicsSDKVisualDebuggerDelegateField();
	}

	public static void DisconnectPhysicsSDKVisualDebugger()
	{
		DisconnectPhysicsSDKVisualDebuggerDelegateField();
	}

	public static uint TranslateTriangleIndexFromID(int instanceID, uint faceIndex)
	{
		return TranslateTriangleIndexFromIDDelegateField(instanceID, faceIndex);
	}

	[SpecialName]
	public static void add_ContactEvent(ContactEventDelegate value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	[SpecialName]
	public static void remove_ContactEvent(ContactEventDelegate value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public unsafe static void get_gravity_Injected(out Vector3 ret)
	{
		get_gravity_InjectedDelegateField((nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void set_gravity_Injected([In] ref Vector3 value)
	{
		set_gravity_InjectedDelegateField((nint)Unsafe.AsPointer(ref value));
	}

	public static void IgnoreCollision_Injected(System.IntPtr collider1, System.IntPtr collider2, bool ignore)
	{
		IgnoreCollision_InjectedDelegateField(collider1, collider2, ignore);
	}

	public static bool GetIgnoreCollision_Injected(System.IntPtr collider1, System.IntPtr collider2)
	{
		return GetIgnoreCollision_InjectedDelegateField(collider1, collider2);
	}

	public unsafe static void Query_CapsuleCastAll_Injected([In] ref PhysicsScene physicsScene, [In] ref Vector3 p0, [In] ref Vector3 p1, float radius, [In] ref Vector3 direction, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction, out BlittableArrayWrapper ret)
	{
		Query_CapsuleCastAll_InjectedDelegateField((nint)Unsafe.AsPointer(ref physicsScene), (nint)Unsafe.AsPointer(ref p0), (nint)Unsafe.AsPointer(ref p1), radius, (nint)Unsafe.AsPointer(ref direction), maxDistance, mask, queryTriggerInteraction, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void Query_SphereCastAll_Injected([In] ref PhysicsScene physicsScene, [In] ref Vector3 origin, float radius, [In] ref Vector3 direction, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction, out BlittableArrayWrapper ret)
	{
		Query_SphereCastAll_InjectedDelegateField((nint)Unsafe.AsPointer(ref physicsScene), (nint)Unsafe.AsPointer(ref origin), radius, (nint)Unsafe.AsPointer(ref direction), maxDistance, mask, queryTriggerInteraction, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static Il2CppReferenceArray<Collider> OverlapCapsule_Internal_Injected([In] ref PhysicsScene physicsScene, [In] ref Vector3 point0, [In] ref Vector3 point1, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
	{
		System.IntPtr intPtr = OverlapCapsule_Internal_InjectedDelegateField((nint)Unsafe.AsPointer(ref physicsScene), (nint)Unsafe.AsPointer(ref point0), (nint)Unsafe.AsPointer(ref point1), radius, layerMask, queryTriggerInteraction);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Collider>>(intPtr) : null;
	}

	public unsafe static Il2CppReferenceArray<Collider> OverlapSphere_Internal_Injected([In] ref PhysicsScene physicsScene, [In] ref Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
	{
		System.IntPtr intPtr = OverlapSphere_Internal_InjectedDelegateField((nint)Unsafe.AsPointer(ref physicsScene), (nint)Unsafe.AsPointer(ref position), radius, layerMask, queryTriggerInteraction);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Collider>>(intPtr) : null;
	}

	public unsafe static void Simulate_Internal_Injected([In] ref PhysicsScene physicsScene, float step, SimulationStage stages, SimulationOption options)
	{
		Simulate_Internal_InjectedDelegateField((nint)Unsafe.AsPointer(ref physicsScene), step, stages, options);
	}

	public unsafe static void InterpolateBodies_Internal_Injected([In] ref PhysicsScene physicsScene)
	{
		InterpolateBodies_Internal_InjectedDelegateField((nint)Unsafe.AsPointer(ref physicsScene));
	}

	public unsafe static void ResetInterpolationPoses_Internal_Injected([In] ref PhysicsScene physicsScene)
	{
		ResetInterpolationPoses_Internal_InjectedDelegateField((nint)Unsafe.AsPointer(ref physicsScene));
	}

	public unsafe static bool Query_ComputePenetration_Injected(System.IntPtr colliderA, [In] ref Vector3 positionA, [In] ref Quaternion rotationA, System.IntPtr colliderB, [In] ref Vector3 positionB, [In] ref Quaternion rotationB, ref Vector3 direction, ref float distance)
	{
		return Query_ComputePenetration_InjectedDelegateField(colliderA, (nint)Unsafe.AsPointer(ref positionA), (nint)Unsafe.AsPointer(ref rotationA), colliderB, (nint)Unsafe.AsPointer(ref positionB), (nint)Unsafe.AsPointer(ref rotationB), (nint)Unsafe.AsPointer(ref direction), (nint)Unsafe.AsPointer(ref distance));
	}

	public unsafe static void Query_ClosestPoint_Injected(System.IntPtr collider, [In] ref Vector3 position, [In] ref Quaternion rotation, [In] ref Vector3 point, out Vector3 ret)
	{
		Query_ClosestPoint_InjectedDelegateField(collider, (nint)Unsafe.AsPointer(ref position), (nint)Unsafe.AsPointer(ref rotation), (nint)Unsafe.AsPointer(ref point), (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void get_clothGravity_Injected(out Vector3 ret)
	{
		get_clothGravity_InjectedDelegateField((nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void set_clothGravity_Injected([In] ref Vector3 value)
	{
		set_clothGravity_InjectedDelegateField((nint)Unsafe.AsPointer(ref value));
	}

	public unsafe static bool CheckSphere_Internal_Injected([In] ref PhysicsScene physicsScene, [In] ref Vector3 position, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
	{
		return CheckSphere_Internal_InjectedDelegateField((nint)Unsafe.AsPointer(ref physicsScene), (nint)Unsafe.AsPointer(ref position), radius, layerMask, queryTriggerInteraction);
	}

	public unsafe static bool CheckCapsule_Internal_Injected([In] ref PhysicsScene physicsScene, [In] ref Vector3 start, [In] ref Vector3 end, float radius, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
	{
		return CheckCapsule_Internal_InjectedDelegateField((nint)Unsafe.AsPointer(ref physicsScene), (nint)Unsafe.AsPointer(ref start), (nint)Unsafe.AsPointer(ref end), radius, layerMask, queryTriggerInteraction);
	}

	public unsafe static bool CheckBox_Internal_Injected([In] ref PhysicsScene physicsScene, [In] ref Vector3 center, [In] ref Vector3 halfExtents, [In] ref Quaternion orientation, int layermask, QueryTriggerInteraction queryTriggerInteraction)
	{
		return CheckBox_Internal_InjectedDelegateField((nint)Unsafe.AsPointer(ref physicsScene), (nint)Unsafe.AsPointer(ref center), (nint)Unsafe.AsPointer(ref halfExtents), (nint)Unsafe.AsPointer(ref orientation), layermask, queryTriggerInteraction);
	}

	public unsafe static Il2CppReferenceArray<Collider> OverlapBox_Internal_Injected([In] ref PhysicsScene physicsScene, [In] ref Vector3 center, [In] ref Vector3 halfExtents, [In] ref Quaternion orientation, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
	{
		System.IntPtr intPtr = OverlapBox_Internal_InjectedDelegateField((nint)Unsafe.AsPointer(ref physicsScene), (nint)Unsafe.AsPointer(ref center), (nint)Unsafe.AsPointer(ref halfExtents), (nint)Unsafe.AsPointer(ref orientation), layerMask, queryTriggerInteraction);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Collider>>(intPtr) : null;
	}

	public unsafe static void Internal_BoxCastAll_Injected([In] ref PhysicsScene physicsScene, [In] ref Vector3 center, [In] ref Vector3 halfExtents, [In] ref Vector3 direction, [In] ref Quaternion orientation, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction, out BlittableArrayWrapper ret)
	{
		Internal_BoxCastAll_InjectedDelegateField((nint)Unsafe.AsPointer(ref physicsScene), (nint)Unsafe.AsPointer(ref center), (nint)Unsafe.AsPointer(ref halfExtents), (nint)Unsafe.AsPointer(ref direction), (nint)Unsafe.AsPointer(ref orientation), maxDistance, layerMask, queryTriggerInteraction, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void RebuildBroadphaseRegions_Injected([In] ref Bounds worldBounds, int subdivisions)
	{
		RebuildBroadphaseRegions_InjectedDelegateField((nint)Unsafe.AsPointer(ref worldBounds), subdivisions);
	}
}
