using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Bindings;

namespace UnityEngine;

public class Physics2D : Il2CppSystem.Object
{
	public enum GizmoOptions
	{
		AllColliders = 1,
		CollidersOutlined = 2,
		CollidersFilled = 4,
		CollidersSleeping = 8,
		ColliderContacts = 0x10,
		ColliderBounds = 0x20
	}

	private delegate int get_velocityIterationsDelegate();

	private delegate void set_velocityIterationsDelegate(int value);

	private delegate int get_positionIterationsDelegate();

	private delegate void set_positionIterationsDelegate(int value);

	private delegate void set_queriesHitTriggersDelegate(bool value);

	private delegate bool get_queriesStartInCollidersDelegate();

	private delegate void set_queriesStartInCollidersDelegate(bool value);

	private delegate bool get_callbacksOnDisableDelegate();

	private delegate void set_callbacksOnDisableDelegate(bool value);

	private delegate bool get_reuseCollisionCallbacksDelegate();

	private delegate void set_reuseCollisionCallbacksDelegate(bool value);

	private delegate bool get_autoSyncTransformsDelegate();

	private delegate void set_autoSyncTransformsDelegate(bool value);

	private delegate SimulationMode2D get_simulationModeDelegate();

	private delegate void set_simulationModeDelegate(SimulationMode2D value);

	private delegate bool get_useSubSteppingDelegate();

	private delegate void set_useSubSteppingDelegate(bool value);

	private delegate bool get_useSubStepContactsDelegate();

	private delegate void set_useSubStepContactsDelegate(bool value);

	private delegate float get_minSubStepFPSDelegate();

	private delegate void set_minSubStepFPSDelegate(float value);

	private delegate int get_maxSubStepCountDelegate();

	private delegate void set_maxSubStepCountDelegate(int value);

	private delegate float get_bounceThresholdDelegate();

	private delegate void set_bounceThresholdDelegate(float value);

	private delegate float get_contactThresholdDelegate();

	private delegate void set_contactThresholdDelegate(float value);

	private delegate float get_maxLinearCorrectionDelegate();

	private delegate void set_maxLinearCorrectionDelegate(float value);

	private delegate float get_maxAngularCorrectionDelegate();

	private delegate void set_maxAngularCorrectionDelegate(float value);

	private delegate float get_maxTranslationSpeedDelegate();

	private delegate void set_maxTranslationSpeedDelegate(float value);

	private delegate float get_maxRotationSpeedDelegate();

	private delegate void set_maxRotationSpeedDelegate(float value);

	private delegate float get_defaultContactOffsetDelegate();

	private delegate void set_defaultContactOffsetDelegate(float value);

	private delegate float get_baumgarteScaleDelegate();

	private delegate void set_baumgarteScaleDelegate(float value);

	private delegate float get_baumgarteTOIScaleDelegate();

	private delegate void set_baumgarteTOIScaleDelegate(float value);

	private delegate float get_timeToSleepDelegate();

	private delegate void set_timeToSleepDelegate(float value);

	private delegate float get_linearSleepToleranceDelegate();

	private delegate void set_linearSleepToleranceDelegate(float value);

	private delegate float get_angularSleepToleranceDelegate();

	private delegate void set_angularSleepToleranceDelegate(float value);

	private delegate void SyncTransformsDelegate();

	private delegate void IgnoreLayerCollision_InternalDelegate(int layer1, int layer2, bool ignore);

	private delegate bool GetIgnoreLayerCollision_InternalDelegate(int layer1, int layer2);

	private delegate void SetLayerCollisionMask_InternalDelegate(int layer, int layerMask);

	private delegate int GetLayerCollisionMask_InternalDelegate(int layer);

	private delegate void set_gravity_InjectedDelegate([In] System.IntPtr value);

	private delegate void get_simulationLayers_InjectedDelegate([Out] System.IntPtr ret);

	private delegate void set_simulationLayers_InjectedDelegate([In] System.IntPtr value);

	private delegate bool Simulate_Internal_InjectedDelegate([In] System.IntPtr physicsScene, float deltaTime, int simulationLayers);

	private delegate void IgnoreCollision_InjectedDelegate(System.IntPtr collider1, System.IntPtr collider2, bool ignore);

	private delegate bool GetIgnoreCollision_InjectedDelegate(System.IntPtr collider1, System.IntPtr collider2);

	private delegate bool IsTouching_InjectedDelegate(System.IntPtr collider1, System.IntPtr collider2);

	private delegate bool IsTouching_TwoCollidersWithFilter_InjectedDelegate(System.IntPtr collider1, System.IntPtr collider2, [In] System.IntPtr contactFilter);

	private delegate bool IsTouching_SingleColliderWithFilter_InjectedDelegate(System.IntPtr collider, [In] System.IntPtr contactFilter);

	private delegate bool IsTouchingLayers_InjectedDelegate(System.IntPtr collider, int layerMask);

	private delegate void ClosestPoint_Collider_InjectedDelegate([In] System.IntPtr position, System.IntPtr collider, [Out] System.IntPtr ret);

	private delegate void ClosestPoint_Rigidbody_InjectedDelegate([In] System.IntPtr position, System.IntPtr rigidbody, [Out] System.IntPtr ret);

	private delegate void LinecastAll_Internal_InjectedDelegate([In] System.IntPtr physicsScene, [In] System.IntPtr start, [In] System.IntPtr end, [In] System.IntPtr contactFilter, [Out] System.IntPtr ret);

	private delegate void RaycastAll_Internal_InjectedDelegate([In] System.IntPtr physicsScene, [In] System.IntPtr origin, [In] System.IntPtr direction, float distance, [In] System.IntPtr contactFilter, [Out] System.IntPtr ret);

	private delegate void CircleCastAll_Internal_InjectedDelegate([In] System.IntPtr physicsScene, [In] System.IntPtr origin, float radius, [In] System.IntPtr direction, float distance, [In] System.IntPtr contactFilter, [Out] System.IntPtr ret);

	private delegate void BoxCastAll_Internal_InjectedDelegate([In] System.IntPtr physicsScene, [In] System.IntPtr origin, [In] System.IntPtr size, float angle, [In] System.IntPtr direction, float distance, [In] System.IntPtr contactFilter, [Out] System.IntPtr ret);

	private delegate void CapsuleCastAll_Internal_InjectedDelegate([In] System.IntPtr physicsScene, [In] System.IntPtr origin, [In] System.IntPtr size, CapsuleDirection2D capsuleDirection, float angle, [In] System.IntPtr direction, float distance, [In] System.IntPtr contactFilter, [Out] System.IntPtr ret);

	private delegate System.IntPtr OverlapPointAll_Internal_InjectedDelegate([In] System.IntPtr physicsScene, [In] System.IntPtr point, [In] System.IntPtr contactFilter);

	private delegate System.IntPtr OverlapCircleAll_Internal_InjectedDelegate([In] System.IntPtr physicsScene, [In] System.IntPtr point, float radius, [In] System.IntPtr contactFilter);

	private delegate System.IntPtr OverlapBoxAll_Internal_InjectedDelegate([In] System.IntPtr physicsScene, [In] System.IntPtr point, [In] System.IntPtr size, float angle, [In] System.IntPtr contactFilter);

	private delegate System.IntPtr OverlapCapsuleAll_Internal_InjectedDelegate([In] System.IntPtr physicsScene, [In] System.IntPtr point, [In] System.IntPtr size, CapsuleDirection2D direction, float angle, [In] System.IntPtr contactFilter);

	private delegate int GetColliderContactsArray_InjectedDelegate(System.IntPtr collider, [In] System.IntPtr contactFilter, System.IntPtr results);

	private delegate int GetColliderColliderContactsArray_InjectedDelegate(System.IntPtr collider1, System.IntPtr collider2, [In] System.IntPtr contactFilter, System.IntPtr results);

	private delegate int GetRigidbodyContactsArray_InjectedDelegate(System.IntPtr rigidbody, [In] System.IntPtr contactFilter, System.IntPtr results);

	private delegate int GetColliderContactsCollidersOnlyArray_InjectedDelegate(System.IntPtr collider, [In] System.IntPtr contactFilter, System.IntPtr results);

	private delegate int GetRigidbodyContactsCollidersOnlyArray_InjectedDelegate(System.IntPtr rigidbody, [In] System.IntPtr contactFilter, System.IntPtr results);

	private delegate int GetColliderContactsList_InjectedDelegate(System.IntPtr collider, [In] System.IntPtr contactFilter, System.IntPtr results);

	private delegate int GetColliderColliderContactsList_InjectedDelegate(System.IntPtr collider1, System.IntPtr collider2, [In] System.IntPtr contactFilter, System.IntPtr results);

	private delegate int GetRigidbodyContactsList_InjectedDelegate(System.IntPtr rigidbody, [In] System.IntPtr contactFilter, System.IntPtr results);

	private delegate int GetColliderContactsCollidersOnlyList_InjectedDelegate(System.IntPtr collider, [In] System.IntPtr contactFilter, System.IntPtr results);

	private delegate int GetRigidbodyContactsCollidersOnlyList_InjectedDelegate(System.IntPtr rigidbody, [In] System.IntPtr contactFilter, System.IntPtr results);

	private static readonly System.IntPtr NativeFieldInfoPtr_m_LastDisabledRigidbody2D;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_defaultPhysicsScene_Public_Static_get_PhysicsScene2D_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_gravity_Public_Static_get_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_queriesHitTriggers_Public_Static_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Raycast_Public_Static_RaycastHit2D_Vector2_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Raycast_Public_Static_RaycastHit2D_Vector2_Vector2_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Raycast_Public_Static_RaycastHit2D_Vector2_Vector2_Single_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Raycast_Public_Static_RaycastHit2D_Vector2_Vector2_Single_Int32_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Raycast_Public_Static_RaycastHit2D_Vector2_Vector2_Single_Int32_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Raycast_Public_Static_Int32_Vector2_Vector2_ContactFilter2D_Il2CppStructArray_1_RaycastHit2D_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Raycast_Public_Static_Int32_Vector2_Vector2_ContactFilter2D_Il2CppStructArray_1_RaycastHit2D_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Raycast_Public_Static_Int32_Vector2_Vector2_ContactFilter2D_List_1_RaycastHit2D_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRayIntersection_Public_Static_RaycastHit2D_Ray_Single_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRayIntersectionAll_Public_Static_Il2CppStructArray_1_RaycastHit2D_Ray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRayIntersectionAll_Public_Static_Il2CppStructArray_1_RaycastHit2D_Ray_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRayIntersectionAll_Public_Static_Il2CppStructArray_1_RaycastHit2D_Ray_Single_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRayIntersectionAll_Internal_Private_Static_Il2CppStructArray_1_RaycastHit2D_PhysicsScene2D_Vector3_Vector3_Single_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRayIntersectionNonAlloc_Public_Static_Int32_Ray_Il2CppStructArray_1_RaycastHit2D_Single_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRayIntersectionNonAlloc_Public_Static_Int32_Ray_Il2CppStructArray_1_RaycastHit2D_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRayIntersectionNonAlloc_Public_Static_Int32_Ray_Il2CppStructArray_1_RaycastHit2D_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_gravity_Injected_Private_Static_Void_byref_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRayIntersectionAll_Internal_Injected_Private_Static_Void_byref_PhysicsScene2D_byref_Vector3_byref_Vector3_Single_Int32_byref_BlittableArrayWrapper_0;

	public const int IgnoreRaycastLayer = 4;

	public const int DefaultRaycastLayers = -5;

	public const int AllLayers = -1;

	public const int MaxPolygonShapeVertices = 8;

	private static readonly get_velocityIterationsDelegate get_velocityIterationsDelegateField;

	private static readonly set_velocityIterationsDelegate set_velocityIterationsDelegateField;

	private static readonly get_positionIterationsDelegate get_positionIterationsDelegateField;

	private static readonly set_positionIterationsDelegate set_positionIterationsDelegateField;

	private static readonly set_queriesHitTriggersDelegate set_queriesHitTriggersDelegateField;

	private static readonly get_queriesStartInCollidersDelegate get_queriesStartInCollidersDelegateField;

	private static readonly set_queriesStartInCollidersDelegate set_queriesStartInCollidersDelegateField;

	private static readonly get_callbacksOnDisableDelegate get_callbacksOnDisableDelegateField;

	private static readonly set_callbacksOnDisableDelegate set_callbacksOnDisableDelegateField;

	private static readonly get_reuseCollisionCallbacksDelegate get_reuseCollisionCallbacksDelegateField;

	private static readonly set_reuseCollisionCallbacksDelegate set_reuseCollisionCallbacksDelegateField;

	private static readonly get_autoSyncTransformsDelegate get_autoSyncTransformsDelegateField;

	private static readonly set_autoSyncTransformsDelegate set_autoSyncTransformsDelegateField;

	private static readonly get_simulationModeDelegate get_simulationModeDelegateField;

	private static readonly set_simulationModeDelegate set_simulationModeDelegateField;

	private static readonly get_useSubSteppingDelegate get_useSubSteppingDelegateField;

	private static readonly set_useSubSteppingDelegate set_useSubSteppingDelegateField;

	private static readonly get_useSubStepContactsDelegate get_useSubStepContactsDelegateField;

	private static readonly set_useSubStepContactsDelegate set_useSubStepContactsDelegateField;

	private static readonly get_minSubStepFPSDelegate get_minSubStepFPSDelegateField;

	private static readonly set_minSubStepFPSDelegate set_minSubStepFPSDelegateField;

	private static readonly get_maxSubStepCountDelegate get_maxSubStepCountDelegateField;

	private static readonly set_maxSubStepCountDelegate set_maxSubStepCountDelegateField;

	private static readonly get_bounceThresholdDelegate get_bounceThresholdDelegateField;

	private static readonly set_bounceThresholdDelegate set_bounceThresholdDelegateField;

	private static readonly get_contactThresholdDelegate get_contactThresholdDelegateField;

	private static readonly set_contactThresholdDelegate set_contactThresholdDelegateField;

	private static readonly get_maxLinearCorrectionDelegate get_maxLinearCorrectionDelegateField;

	private static readonly set_maxLinearCorrectionDelegate set_maxLinearCorrectionDelegateField;

	private static readonly get_maxAngularCorrectionDelegate get_maxAngularCorrectionDelegateField;

	private static readonly set_maxAngularCorrectionDelegate set_maxAngularCorrectionDelegateField;

	private static readonly get_maxTranslationSpeedDelegate get_maxTranslationSpeedDelegateField;

	private static readonly set_maxTranslationSpeedDelegate set_maxTranslationSpeedDelegateField;

	private static readonly get_maxRotationSpeedDelegate get_maxRotationSpeedDelegateField;

	private static readonly set_maxRotationSpeedDelegate set_maxRotationSpeedDelegateField;

	private static readonly get_defaultContactOffsetDelegate get_defaultContactOffsetDelegateField;

	private static readonly set_defaultContactOffsetDelegate set_defaultContactOffsetDelegateField;

	private static readonly get_baumgarteScaleDelegate get_baumgarteScaleDelegateField;

	private static readonly set_baumgarteScaleDelegate set_baumgarteScaleDelegateField;

	private static readonly get_baumgarteTOIScaleDelegate get_baumgarteTOIScaleDelegateField;

	private static readonly set_baumgarteTOIScaleDelegate set_baumgarteTOIScaleDelegateField;

	private static readonly get_timeToSleepDelegate get_timeToSleepDelegateField;

	private static readonly set_timeToSleepDelegate set_timeToSleepDelegateField;

	private static readonly get_linearSleepToleranceDelegate get_linearSleepToleranceDelegateField;

	private static readonly set_linearSleepToleranceDelegate set_linearSleepToleranceDelegateField;

	private static readonly get_angularSleepToleranceDelegate get_angularSleepToleranceDelegateField;

	private static readonly set_angularSleepToleranceDelegate set_angularSleepToleranceDelegateField;

	private static readonly SyncTransformsDelegate SyncTransformsDelegateField;

	private static readonly IgnoreLayerCollision_InternalDelegate IgnoreLayerCollision_InternalDelegateField;

	private static readonly GetIgnoreLayerCollision_InternalDelegate GetIgnoreLayerCollision_InternalDelegateField;

	private static readonly SetLayerCollisionMask_InternalDelegate SetLayerCollisionMask_InternalDelegateField;

	private static readonly GetLayerCollisionMask_InternalDelegate GetLayerCollisionMask_InternalDelegateField;

	private static readonly set_gravity_InjectedDelegate set_gravity_InjectedDelegateField;

	private static readonly get_simulationLayers_InjectedDelegate get_simulationLayers_InjectedDelegateField;

	private static readonly set_simulationLayers_InjectedDelegate set_simulationLayers_InjectedDelegateField;

	private static readonly Simulate_Internal_InjectedDelegate Simulate_Internal_InjectedDelegateField;

	private static readonly IgnoreCollision_InjectedDelegate IgnoreCollision_InjectedDelegateField;

	private static readonly GetIgnoreCollision_InjectedDelegate GetIgnoreCollision_InjectedDelegateField;

	private static readonly IsTouching_InjectedDelegate IsTouching_InjectedDelegateField;

	private static readonly IsTouching_TwoCollidersWithFilter_InjectedDelegate IsTouching_TwoCollidersWithFilter_InjectedDelegateField;

	private static readonly IsTouching_SingleColliderWithFilter_InjectedDelegate IsTouching_SingleColliderWithFilter_InjectedDelegateField;

	private static readonly IsTouchingLayers_InjectedDelegate IsTouchingLayers_InjectedDelegateField;

	private static readonly ClosestPoint_Collider_InjectedDelegate ClosestPoint_Collider_InjectedDelegateField;

	private static readonly ClosestPoint_Rigidbody_InjectedDelegate ClosestPoint_Rigidbody_InjectedDelegateField;

	private static readonly LinecastAll_Internal_InjectedDelegate LinecastAll_Internal_InjectedDelegateField;

	private static readonly RaycastAll_Internal_InjectedDelegate RaycastAll_Internal_InjectedDelegateField;

	private static readonly CircleCastAll_Internal_InjectedDelegate CircleCastAll_Internal_InjectedDelegateField;

	private static readonly BoxCastAll_Internal_InjectedDelegate BoxCastAll_Internal_InjectedDelegateField;

	private static readonly CapsuleCastAll_Internal_InjectedDelegate CapsuleCastAll_Internal_InjectedDelegateField;

	private static readonly OverlapPointAll_Internal_InjectedDelegate OverlapPointAll_Internal_InjectedDelegateField;

	private static readonly OverlapCircleAll_Internal_InjectedDelegate OverlapCircleAll_Internal_InjectedDelegateField;

	private static readonly OverlapBoxAll_Internal_InjectedDelegate OverlapBoxAll_Internal_InjectedDelegateField;

	private static readonly OverlapCapsuleAll_Internal_InjectedDelegate OverlapCapsuleAll_Internal_InjectedDelegateField;

	private static readonly GetColliderContactsArray_InjectedDelegate GetColliderContactsArray_InjectedDelegateField;

	private static readonly GetColliderColliderContactsArray_InjectedDelegate GetColliderColliderContactsArray_InjectedDelegateField;

	private static readonly GetRigidbodyContactsArray_InjectedDelegate GetRigidbodyContactsArray_InjectedDelegateField;

	private static readonly GetColliderContactsCollidersOnlyArray_InjectedDelegate GetColliderContactsCollidersOnlyArray_InjectedDelegateField;

	private static readonly GetRigidbodyContactsCollidersOnlyArray_InjectedDelegate GetRigidbodyContactsCollidersOnlyArray_InjectedDelegateField;

	private static readonly GetColliderContactsList_InjectedDelegate GetColliderContactsList_InjectedDelegateField;

	private static readonly GetColliderColliderContactsList_InjectedDelegate GetColliderColliderContactsList_InjectedDelegateField;

	private static readonly GetRigidbodyContactsList_InjectedDelegate GetRigidbodyContactsList_InjectedDelegateField;

	private static readonly GetColliderContactsCollidersOnlyList_InjectedDelegate GetColliderContactsCollidersOnlyList_InjectedDelegateField;

	private static readonly GetRigidbodyContactsCollidersOnlyList_InjectedDelegate GetRigidbodyContactsCollidersOnlyList_InjectedDelegateField;

	public unsafe static List<Rigidbody2D> m_LastDisabledRigidbody2D
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_LastDisabledRigidbody2D, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Rigidbody2D>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_LastDisabledRigidbody2D, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static PhysicsScene2D defaultPhysicsScene
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_defaultPhysicsScene_Public_Static_get_PhysicsScene2D_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(PhysicsScene2D*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static Vector2 gravity
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1258764, RefRangeEnd = 1258766, XrefRangeStart = 1258759, XrefRangeEnd = 1258764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_gravity_Public_Static_get_Vector2_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			set_gravity_Injected(ref value);
		}
	}

	public unsafe static bool queriesHitTriggers
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258766, XrefRangeEnd = 1258768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_queriesHitTriggers_Public_Static_get_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			set_queriesHitTriggersDelegateField(value);
		}
	}

	public static int velocityIterations
	{
		get
		{
			return get_velocityIterationsDelegateField();
		}
		set
		{
			set_velocityIterationsDelegateField(value);
		}
	}

	public static int positionIterations
	{
		get
		{
			return get_positionIterationsDelegateField();
		}
		set
		{
			set_positionIterationsDelegateField(value);
		}
	}

	public static bool queriesStartInColliders
	{
		get
		{
			return get_queriesStartInCollidersDelegateField();
		}
		set
		{
			set_queriesStartInCollidersDelegateField(value);
		}
	}

	public static bool callbacksOnDisable
	{
		get
		{
			return get_callbacksOnDisableDelegateField();
		}
		set
		{
			set_callbacksOnDisableDelegateField(value);
		}
	}

	public static bool reuseCollisionCallbacks
	{
		get
		{
			return get_reuseCollisionCallbacksDelegateField();
		}
		set
		{
			set_reuseCollisionCallbacksDelegateField(value);
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

	public static SimulationMode2D simulationMode
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

	public static LayerMask simulationLayers
	{
		get
		{
			get_simulationLayers_Injected(out var ret);
			return ret;
		}
		set
		{
			set_simulationLayers_Injected(ref value);
		}
	}

	public static bool useSubStepping
	{
		get
		{
			return get_useSubSteppingDelegateField();
		}
		set
		{
			set_useSubSteppingDelegateField(value);
		}
	}

	public static bool useSubStepContacts
	{
		get
		{
			return get_useSubStepContactsDelegateField();
		}
		set
		{
			set_useSubStepContactsDelegateField(value);
		}
	}

	public static float minSubStepFPS
	{
		get
		{
			return get_minSubStepFPSDelegateField();
		}
		set
		{
			set_minSubStepFPSDelegateField(value);
		}
	}

	public static int maxSubStepCount
	{
		get
		{
			return get_maxSubStepCountDelegateField();
		}
		set
		{
			set_maxSubStepCountDelegateField(value);
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

	public static float contactThreshold
	{
		get
		{
			return get_contactThresholdDelegateField();
		}
		set
		{
			set_contactThresholdDelegateField(value);
		}
	}

	public static float maxLinearCorrection
	{
		get
		{
			return get_maxLinearCorrectionDelegateField();
		}
		set
		{
			set_maxLinearCorrectionDelegateField(value);
		}
	}

	public static float maxAngularCorrection
	{
		get
		{
			return get_maxAngularCorrectionDelegateField();
		}
		set
		{
			set_maxAngularCorrectionDelegateField(value);
		}
	}

	public static float maxTranslationSpeed
	{
		get
		{
			return get_maxTranslationSpeedDelegateField();
		}
		set
		{
			set_maxTranslationSpeedDelegateField(value);
		}
	}

	public static float maxRotationSpeed
	{
		get
		{
			return get_maxRotationSpeedDelegateField();
		}
		set
		{
			set_maxRotationSpeedDelegateField(value);
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

	public static float baumgarteScale
	{
		get
		{
			return get_baumgarteScaleDelegateField();
		}
		set
		{
			set_baumgarteScaleDelegateField(value);
		}
	}

	public static float baumgarteTOIScale
	{
		get
		{
			return get_baumgarteTOIScaleDelegateField();
		}
		set
		{
			set_baumgarteTOIScaleDelegateField(value);
		}
	}

	public static float timeToSleep
	{
		get
		{
			return get_timeToSleepDelegateField();
		}
		set
		{
			set_timeToSleepDelegateField(value);
		}
	}

	public static float linearSleepTolerance
	{
		get
		{
			return get_linearSleepToleranceDelegateField();
		}
		set
		{
			set_linearSleepToleranceDelegateField(value);
		}
	}

	public static float angularSleepTolerance
	{
		get
		{
			return get_angularSleepToleranceDelegateField();
		}
		set
		{
			set_angularSleepToleranceDelegateField(value);
		}
	}

	public static bool raycastsHitTriggers
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static bool raycastsStartInColliders
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static bool deleteStopsCallbacks
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static bool changeStopsCallbacks
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static float minPenetrationForPenalty
	{
		get
		{
			return defaultContactOffset;
		}
		set
		{
			defaultContactOffset = value;
		}
	}

	public static float velocityThreshold
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

	public static bool autoSimulation
	{
		get
		{
			return simulationMode != SimulationMode2D.Script;
		}
		set
		{
			simulationMode = ((!value) ? SimulationMode2D.Script : SimulationMode2D.FixedUpdate);
		}
	}

	public static Color colliderAwakeColor
	{
		get
		{
			return Color.magenta;
		}
		set
		{
		}
	}

	public static Color colliderAsleepColor
	{
		get
		{
			return Color.magenta;
		}
		set
		{
		}
	}

	public static Color colliderContactColor
	{
		get
		{
			return Color.magenta;
		}
		set
		{
		}
	}

	public static Color colliderAABBColor
	{
		get
		{
			return Color.magenta;
		}
		set
		{
		}
	}

	public static float contactArrowScale
	{
		get
		{
			return 0.2f;
		}
		set
		{
		}
	}

	public static bool alwaysShowColliders
	{
		get
		{
			throw new System.NotSupportedException("Method unstripping failed");
		}
		set
		{
			throw new System.NotSupportedException("Method unstripping failed");
		}
	}

	public static bool showCollidersFilled
	{
		get
		{
			throw new System.NotSupportedException("Method unstripping failed");
		}
		set
		{
			throw new System.NotSupportedException("Method unstripping failed");
		}
	}

	public static bool showColliderSleep
	{
		get
		{
			throw new System.NotSupportedException("Method unstripping failed");
		}
		set
		{
			throw new System.NotSupportedException("Method unstripping failed");
		}
	}

	public static bool showColliderContacts
	{
		get
		{
			throw new System.NotSupportedException("Method unstripping failed");
		}
		set
		{
			throw new System.NotSupportedException("Method unstripping failed");
		}
	}

	public static bool showColliderAABB
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	static Physics2D()
	{
		Il2CppClassPointerStore<Physics2D>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Physics2DModule.dll", "UnityEngine", "Physics2D");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Physics2D>.NativeClassPtr);
		NativeFieldInfoPtr_m_LastDisabledRigidbody2D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Physics2D>.NativeClassPtr, "m_LastDisabledRigidbody2D");
		NativeMethodInfoPtr_get_defaultPhysicsScene_Public_Static_get_PhysicsScene2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics2D>.NativeClassPtr, 100663317);
		NativeMethodInfoPtr_get_gravity_Public_Static_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics2D>.NativeClassPtr, 100663318);
		NativeMethodInfoPtr_get_queriesHitTriggers_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics2D>.NativeClassPtr, 100663319);
		NativeMethodInfoPtr_Raycast_Public_Static_RaycastHit2D_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics2D>.NativeClassPtr, 100663320);
		NativeMethodInfoPtr_Raycast_Public_Static_RaycastHit2D_Vector2_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics2D>.NativeClassPtr, 100663321);
		NativeMethodInfoPtr_Raycast_Public_Static_RaycastHit2D_Vector2_Vector2_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics2D>.NativeClassPtr, 100663322);
		NativeMethodInfoPtr_Raycast_Public_Static_RaycastHit2D_Vector2_Vector2_Single_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics2D>.NativeClassPtr, 100663323);
		NativeMethodInfoPtr_Raycast_Public_Static_RaycastHit2D_Vector2_Vector2_Single_Int32_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics2D>.NativeClassPtr, 100663324);
		NativeMethodInfoPtr_Raycast_Public_Static_Int32_Vector2_Vector2_ContactFilter2D_Il2CppStructArray_1_RaycastHit2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics2D>.NativeClassPtr, 100663325);
		NativeMethodInfoPtr_Raycast_Public_Static_Int32_Vector2_Vector2_ContactFilter2D_Il2CppStructArray_1_RaycastHit2D_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics2D>.NativeClassPtr, 100663326);
		NativeMethodInfoPtr_Raycast_Public_Static_Int32_Vector2_Vector2_ContactFilter2D_List_1_RaycastHit2D_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics2D>.NativeClassPtr, 100663327);
		NativeMethodInfoPtr_GetRayIntersection_Public_Static_RaycastHit2D_Ray_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics2D>.NativeClassPtr, 100663328);
		NativeMethodInfoPtr_GetRayIntersectionAll_Public_Static_Il2CppStructArray_1_RaycastHit2D_Ray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics2D>.NativeClassPtr, 100663329);
		NativeMethodInfoPtr_GetRayIntersectionAll_Public_Static_Il2CppStructArray_1_RaycastHit2D_Ray_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics2D>.NativeClassPtr, 100663330);
		NativeMethodInfoPtr_GetRayIntersectionAll_Public_Static_Il2CppStructArray_1_RaycastHit2D_Ray_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics2D>.NativeClassPtr, 100663331);
		NativeMethodInfoPtr_GetRayIntersectionAll_Internal_Private_Static_Il2CppStructArray_1_RaycastHit2D_PhysicsScene2D_Vector3_Vector3_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics2D>.NativeClassPtr, 100663332);
		NativeMethodInfoPtr_GetRayIntersectionNonAlloc_Public_Static_Int32_Ray_Il2CppStructArray_1_RaycastHit2D_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics2D>.NativeClassPtr, 100663333);
		NativeMethodInfoPtr_GetRayIntersectionNonAlloc_Public_Static_Int32_Ray_Il2CppStructArray_1_RaycastHit2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics2D>.NativeClassPtr, 100663334);
		NativeMethodInfoPtr_GetRayIntersectionNonAlloc_Public_Static_Int32_Ray_Il2CppStructArray_1_RaycastHit2D_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics2D>.NativeClassPtr, 100663335);
		NativeMethodInfoPtr_get_gravity_Injected_Private_Static_Void_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics2D>.NativeClassPtr, 100663337);
		NativeMethodInfoPtr_GetRayIntersectionAll_Internal_Injected_Private_Static_Void_byref_PhysicsScene2D_byref_Vector3_byref_Vector3_Single_Int32_byref_BlittableArrayWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Physics2D>.NativeClassPtr, 100663338);
		get_velocityIterationsDelegateField = IL2CPP.ResolveICall<get_velocityIterationsDelegate>("UnityEngine.Physics2D::get_velocityIterations");
		set_velocityIterationsDelegateField = IL2CPP.ResolveICall<set_velocityIterationsDelegate>("UnityEngine.Physics2D::set_velocityIterations");
		get_positionIterationsDelegateField = IL2CPP.ResolveICall<get_positionIterationsDelegate>("UnityEngine.Physics2D::get_positionIterations");
		set_positionIterationsDelegateField = IL2CPP.ResolveICall<set_positionIterationsDelegate>("UnityEngine.Physics2D::set_positionIterations");
		set_queriesHitTriggersDelegateField = IL2CPP.ResolveICall<set_queriesHitTriggersDelegate>("UnityEngine.Physics2D::set_queriesHitTriggers");
		get_queriesStartInCollidersDelegateField = IL2CPP.ResolveICall<get_queriesStartInCollidersDelegate>("UnityEngine.Physics2D::get_queriesStartInColliders");
		set_queriesStartInCollidersDelegateField = IL2CPP.ResolveICall<set_queriesStartInCollidersDelegate>("UnityEngine.Physics2D::set_queriesStartInColliders");
		get_callbacksOnDisableDelegateField = IL2CPP.ResolveICall<get_callbacksOnDisableDelegate>("UnityEngine.Physics2D::get_callbacksOnDisable");
		set_callbacksOnDisableDelegateField = IL2CPP.ResolveICall<set_callbacksOnDisableDelegate>("UnityEngine.Physics2D::set_callbacksOnDisable");
		get_reuseCollisionCallbacksDelegateField = IL2CPP.ResolveICall<get_reuseCollisionCallbacksDelegate>("UnityEngine.Physics2D::get_reuseCollisionCallbacks");
		set_reuseCollisionCallbacksDelegateField = IL2CPP.ResolveICall<set_reuseCollisionCallbacksDelegate>("UnityEngine.Physics2D::set_reuseCollisionCallbacks");
		get_autoSyncTransformsDelegateField = IL2CPP.ResolveICall<get_autoSyncTransformsDelegate>("UnityEngine.Physics2D::get_autoSyncTransforms");
		set_autoSyncTransformsDelegateField = IL2CPP.ResolveICall<set_autoSyncTransformsDelegate>("UnityEngine.Physics2D::set_autoSyncTransforms");
		get_simulationModeDelegateField = IL2CPP.ResolveICall<get_simulationModeDelegate>("UnityEngine.Physics2D::get_simulationMode");
		set_simulationModeDelegateField = IL2CPP.ResolveICall<set_simulationModeDelegate>("UnityEngine.Physics2D::set_simulationMode");
		get_useSubSteppingDelegateField = IL2CPP.ResolveICall<get_useSubSteppingDelegate>("UnityEngine.Physics2D::get_useSubStepping");
		set_useSubSteppingDelegateField = IL2CPP.ResolveICall<set_useSubSteppingDelegate>("UnityEngine.Physics2D::set_useSubStepping");
		get_useSubStepContactsDelegateField = IL2CPP.ResolveICall<get_useSubStepContactsDelegate>("UnityEngine.Physics2D::get_useSubStepContacts");
		set_useSubStepContactsDelegateField = IL2CPP.ResolveICall<set_useSubStepContactsDelegate>("UnityEngine.Physics2D::set_useSubStepContacts");
		get_minSubStepFPSDelegateField = IL2CPP.ResolveICall<get_minSubStepFPSDelegate>("UnityEngine.Physics2D::get_minSubStepFPS");
		set_minSubStepFPSDelegateField = IL2CPP.ResolveICall<set_minSubStepFPSDelegate>("UnityEngine.Physics2D::set_minSubStepFPS");
		get_maxSubStepCountDelegateField = IL2CPP.ResolveICall<get_maxSubStepCountDelegate>("UnityEngine.Physics2D::get_maxSubStepCount");
		set_maxSubStepCountDelegateField = IL2CPP.ResolveICall<set_maxSubStepCountDelegate>("UnityEngine.Physics2D::set_maxSubStepCount");
		get_bounceThresholdDelegateField = IL2CPP.ResolveICall<get_bounceThresholdDelegate>("UnityEngine.Physics2D::get_bounceThreshold");
		set_bounceThresholdDelegateField = IL2CPP.ResolveICall<set_bounceThresholdDelegate>("UnityEngine.Physics2D::set_bounceThreshold");
		get_contactThresholdDelegateField = IL2CPP.ResolveICall<get_contactThresholdDelegate>("UnityEngine.Physics2D::get_contactThreshold");
		set_contactThresholdDelegateField = IL2CPP.ResolveICall<set_contactThresholdDelegate>("UnityEngine.Physics2D::set_contactThreshold");
		get_maxLinearCorrectionDelegateField = IL2CPP.ResolveICall<get_maxLinearCorrectionDelegate>("UnityEngine.Physics2D::get_maxLinearCorrection");
		set_maxLinearCorrectionDelegateField = IL2CPP.ResolveICall<set_maxLinearCorrectionDelegate>("UnityEngine.Physics2D::set_maxLinearCorrection");
		get_maxAngularCorrectionDelegateField = IL2CPP.ResolveICall<get_maxAngularCorrectionDelegate>("UnityEngine.Physics2D::get_maxAngularCorrection");
		set_maxAngularCorrectionDelegateField = IL2CPP.ResolveICall<set_maxAngularCorrectionDelegate>("UnityEngine.Physics2D::set_maxAngularCorrection");
		get_maxTranslationSpeedDelegateField = IL2CPP.ResolveICall<get_maxTranslationSpeedDelegate>("UnityEngine.Physics2D::get_maxTranslationSpeed");
		set_maxTranslationSpeedDelegateField = IL2CPP.ResolveICall<set_maxTranslationSpeedDelegate>("UnityEngine.Physics2D::set_maxTranslationSpeed");
		get_maxRotationSpeedDelegateField = IL2CPP.ResolveICall<get_maxRotationSpeedDelegate>("UnityEngine.Physics2D::get_maxRotationSpeed");
		set_maxRotationSpeedDelegateField = IL2CPP.ResolveICall<set_maxRotationSpeedDelegate>("UnityEngine.Physics2D::set_maxRotationSpeed");
		get_defaultContactOffsetDelegateField = IL2CPP.ResolveICall<get_defaultContactOffsetDelegate>("UnityEngine.Physics2D::get_defaultContactOffset");
		set_defaultContactOffsetDelegateField = IL2CPP.ResolveICall<set_defaultContactOffsetDelegate>("UnityEngine.Physics2D::set_defaultContactOffset");
		get_baumgarteScaleDelegateField = IL2CPP.ResolveICall<get_baumgarteScaleDelegate>("UnityEngine.Physics2D::get_baumgarteScale");
		set_baumgarteScaleDelegateField = IL2CPP.ResolveICall<set_baumgarteScaleDelegate>("UnityEngine.Physics2D::set_baumgarteScale");
		get_baumgarteTOIScaleDelegateField = IL2CPP.ResolveICall<get_baumgarteTOIScaleDelegate>("UnityEngine.Physics2D::get_baumgarteTOIScale");
		set_baumgarteTOIScaleDelegateField = IL2CPP.ResolveICall<set_baumgarteTOIScaleDelegate>("UnityEngine.Physics2D::set_baumgarteTOIScale");
		get_timeToSleepDelegateField = IL2CPP.ResolveICall<get_timeToSleepDelegate>("UnityEngine.Physics2D::get_timeToSleep");
		set_timeToSleepDelegateField = IL2CPP.ResolveICall<set_timeToSleepDelegate>("UnityEngine.Physics2D::set_timeToSleep");
		get_linearSleepToleranceDelegateField = IL2CPP.ResolveICall<get_linearSleepToleranceDelegate>("UnityEngine.Physics2D::get_linearSleepTolerance");
		set_linearSleepToleranceDelegateField = IL2CPP.ResolveICall<set_linearSleepToleranceDelegate>("UnityEngine.Physics2D::set_linearSleepTolerance");
		get_angularSleepToleranceDelegateField = IL2CPP.ResolveICall<get_angularSleepToleranceDelegate>("UnityEngine.Physics2D::get_angularSleepTolerance");
		set_angularSleepToleranceDelegateField = IL2CPP.ResolveICall<set_angularSleepToleranceDelegate>("UnityEngine.Physics2D::set_angularSleepTolerance");
		SyncTransformsDelegateField = IL2CPP.ResolveICall<SyncTransformsDelegate>("UnityEngine.Physics2D::SyncTransforms");
		IgnoreLayerCollision_InternalDelegateField = IL2CPP.ResolveICall<IgnoreLayerCollision_InternalDelegate>("UnityEngine.Physics2D::IgnoreLayerCollision_Internal");
		GetIgnoreLayerCollision_InternalDelegateField = IL2CPP.ResolveICall<GetIgnoreLayerCollision_InternalDelegate>("UnityEngine.Physics2D::GetIgnoreLayerCollision_Internal");
		SetLayerCollisionMask_InternalDelegateField = IL2CPP.ResolveICall<SetLayerCollisionMask_InternalDelegate>("UnityEngine.Physics2D::SetLayerCollisionMask_Internal");
		GetLayerCollisionMask_InternalDelegateField = IL2CPP.ResolveICall<GetLayerCollisionMask_InternalDelegate>("UnityEngine.Physics2D::GetLayerCollisionMask_Internal");
		set_gravity_InjectedDelegateField = IL2CPP.ResolveICall<set_gravity_InjectedDelegate>("UnityEngine.Physics2D::set_gravity_Injected");
		get_simulationLayers_InjectedDelegateField = IL2CPP.ResolveICall<get_simulationLayers_InjectedDelegate>("UnityEngine.Physics2D::get_simulationLayers_Injected");
		set_simulationLayers_InjectedDelegateField = IL2CPP.ResolveICall<set_simulationLayers_InjectedDelegate>("UnityEngine.Physics2D::set_simulationLayers_Injected");
		Simulate_Internal_InjectedDelegateField = IL2CPP.ResolveICall<Simulate_Internal_InjectedDelegate>("UnityEngine.Physics2D::Simulate_Internal_Injected");
		IgnoreCollision_InjectedDelegateField = IL2CPP.ResolveICall<IgnoreCollision_InjectedDelegate>("UnityEngine.Physics2D::IgnoreCollision_Injected");
		GetIgnoreCollision_InjectedDelegateField = IL2CPP.ResolveICall<GetIgnoreCollision_InjectedDelegate>("UnityEngine.Physics2D::GetIgnoreCollision_Injected");
		IsTouching_InjectedDelegateField = IL2CPP.ResolveICall<IsTouching_InjectedDelegate>("UnityEngine.Physics2D::IsTouching_Injected");
		IsTouching_TwoCollidersWithFilter_InjectedDelegateField = IL2CPP.ResolveICall<IsTouching_TwoCollidersWithFilter_InjectedDelegate>("UnityEngine.Physics2D::IsTouching_TwoCollidersWithFilter_Injected");
		IsTouching_SingleColliderWithFilter_InjectedDelegateField = IL2CPP.ResolveICall<IsTouching_SingleColliderWithFilter_InjectedDelegate>("UnityEngine.Physics2D::IsTouching_SingleColliderWithFilter_Injected");
		IsTouchingLayers_InjectedDelegateField = IL2CPP.ResolveICall<IsTouchingLayers_InjectedDelegate>("UnityEngine.Physics2D::IsTouchingLayers_Injected");
		ClosestPoint_Collider_InjectedDelegateField = IL2CPP.ResolveICall<ClosestPoint_Collider_InjectedDelegate>("UnityEngine.Physics2D::ClosestPoint_Collider_Injected");
		ClosestPoint_Rigidbody_InjectedDelegateField = IL2CPP.ResolveICall<ClosestPoint_Rigidbody_InjectedDelegate>("UnityEngine.Physics2D::ClosestPoint_Rigidbody_Injected");
		LinecastAll_Internal_InjectedDelegateField = IL2CPP.ResolveICall<LinecastAll_Internal_InjectedDelegate>("UnityEngine.Physics2D::LinecastAll_Internal_Injected");
		RaycastAll_Internal_InjectedDelegateField = IL2CPP.ResolveICall<RaycastAll_Internal_InjectedDelegate>("UnityEngine.Physics2D::RaycastAll_Internal_Injected");
		CircleCastAll_Internal_InjectedDelegateField = IL2CPP.ResolveICall<CircleCastAll_Internal_InjectedDelegate>("UnityEngine.Physics2D::CircleCastAll_Internal_Injected");
		BoxCastAll_Internal_InjectedDelegateField = IL2CPP.ResolveICall<BoxCastAll_Internal_InjectedDelegate>("UnityEngine.Physics2D::BoxCastAll_Internal_Injected");
		CapsuleCastAll_Internal_InjectedDelegateField = IL2CPP.ResolveICall<CapsuleCastAll_Internal_InjectedDelegate>("UnityEngine.Physics2D::CapsuleCastAll_Internal_Injected");
		OverlapPointAll_Internal_InjectedDelegateField = IL2CPP.ResolveICall<OverlapPointAll_Internal_InjectedDelegate>("UnityEngine.Physics2D::OverlapPointAll_Internal_Injected");
		OverlapCircleAll_Internal_InjectedDelegateField = IL2CPP.ResolveICall<OverlapCircleAll_Internal_InjectedDelegate>("UnityEngine.Physics2D::OverlapCircleAll_Internal_Injected");
		OverlapBoxAll_Internal_InjectedDelegateField = IL2CPP.ResolveICall<OverlapBoxAll_Internal_InjectedDelegate>("UnityEngine.Physics2D::OverlapBoxAll_Internal_Injected");
		OverlapCapsuleAll_Internal_InjectedDelegateField = IL2CPP.ResolveICall<OverlapCapsuleAll_Internal_InjectedDelegate>("UnityEngine.Physics2D::OverlapCapsuleAll_Internal_Injected");
		GetColliderContactsArray_InjectedDelegateField = IL2CPP.ResolveICall<GetColliderContactsArray_InjectedDelegate>("UnityEngine.Physics2D::GetColliderContactsArray_Injected");
		GetColliderColliderContactsArray_InjectedDelegateField = IL2CPP.ResolveICall<GetColliderColliderContactsArray_InjectedDelegate>("UnityEngine.Physics2D::GetColliderColliderContactsArray_Injected");
		GetRigidbodyContactsArray_InjectedDelegateField = IL2CPP.ResolveICall<GetRigidbodyContactsArray_InjectedDelegate>("UnityEngine.Physics2D::GetRigidbodyContactsArray_Injected");
		GetColliderContactsCollidersOnlyArray_InjectedDelegateField = IL2CPP.ResolveICall<GetColliderContactsCollidersOnlyArray_InjectedDelegate>("UnityEngine.Physics2D::GetColliderContactsCollidersOnlyArray_Injected");
		GetRigidbodyContactsCollidersOnlyArray_InjectedDelegateField = IL2CPP.ResolveICall<GetRigidbodyContactsCollidersOnlyArray_InjectedDelegate>("UnityEngine.Physics2D::GetRigidbodyContactsCollidersOnlyArray_Injected");
		GetColliderContactsList_InjectedDelegateField = IL2CPP.ResolveICall<GetColliderContactsList_InjectedDelegate>("UnityEngine.Physics2D::GetColliderContactsList_Injected");
		GetColliderColliderContactsList_InjectedDelegateField = IL2CPP.ResolveICall<GetColliderColliderContactsList_InjectedDelegate>("UnityEngine.Physics2D::GetColliderColliderContactsList_Injected");
		GetRigidbodyContactsList_InjectedDelegateField = IL2CPP.ResolveICall<GetRigidbodyContactsList_InjectedDelegate>("UnityEngine.Physics2D::GetRigidbodyContactsList_Injected");
		GetColliderContactsCollidersOnlyList_InjectedDelegateField = IL2CPP.ResolveICall<GetColliderContactsCollidersOnlyList_InjectedDelegate>("UnityEngine.Physics2D::GetColliderContactsCollidersOnlyList_Injected");
		GetRigidbodyContactsCollidersOnlyList_InjectedDelegateField = IL2CPP.ResolveICall<GetRigidbodyContactsCollidersOnlyList_InjectedDelegate>("UnityEngine.Physics2D::GetRigidbodyContactsCollidersOnlyList_Injected");
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258768, XrefRangeEnd = 1258774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static RaycastHit2D Raycast(Vector2 origin, Vector2 direction)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&origin);
		*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &direction;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Raycast_Public_Static_RaycastHit2D_Vector2_Vector2_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(RaycastHit2D*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258774, XrefRangeEnd = 1258778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&origin);
		*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &direction;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &distance;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Raycast_Public_Static_RaycastHit2D_Vector2_Vector2_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(RaycastHit2D*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258778, XrefRangeEnd = 1258784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, int layerMask)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&origin);
		*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &direction;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &distance;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &layerMask;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Raycast_Public_Static_RaycastHit2D_Vector2_Vector2_Single_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(RaycastHit2D*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258784, XrefRangeEnd = 1258790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, int layerMask, float minDepth)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&origin);
		*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &direction;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &distance;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &layerMask;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &minDepth;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Raycast_Public_Static_RaycastHit2D_Vector2_Vector2_Single_Int32_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(RaycastHit2D*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258790, XrefRangeEnd = 1258796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, int layerMask, float minDepth, float maxDepth)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&origin);
		*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &direction;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &distance;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &layerMask;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &minDepth;
		*(float**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxDepth;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Raycast_Public_Static_RaycastHit2D_Vector2_Vector2_Single_Int32_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(RaycastHit2D*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258796, XrefRangeEnd = 1258811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int Raycast(Vector2 origin, Vector2 direction, ContactFilter2D contactFilter, Il2CppStructArray<RaycastHit2D> results)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&origin);
		*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &direction;
		*(ContactFilter2D**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &contactFilter;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)results);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Raycast_Public_Static_Int32_Vector2_Vector2_ContactFilter2D_Il2CppStructArray_1_RaycastHit2D_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258811, XrefRangeEnd = 1258826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int Raycast(Vector2 origin, Vector2 direction, ContactFilter2D contactFilter, Il2CppStructArray<RaycastHit2D> results, float distance)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&origin);
		*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &direction;
		*(ContactFilter2D**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &contactFilter;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)results);
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &distance;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Raycast_Public_Static_Int32_Vector2_Vector2_ContactFilter2D_Il2CppStructArray_1_RaycastHit2D_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258826, XrefRangeEnd = 1258830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int Raycast(Vector2 origin, Vector2 direction, ContactFilter2D contactFilter, List<RaycastHit2D> results, float distance = float.PositiveInfinity)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&origin);
		*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &direction;
		*(ContactFilter2D**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &contactFilter;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)results);
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &distance;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Raycast_Public_Static_Int32_Vector2_Vector2_ContactFilter2D_List_1_RaycastHit2D_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1258835, RefRangeEnd = 1258836, XrefRangeStart = 1258830, XrefRangeEnd = 1258835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static RaycastHit2D GetRayIntersection(Ray ray, float distance, int layerMask = -5)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&ray);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &distance;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &layerMask;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRayIntersection_Public_Static_RaycastHit2D_Ray_Single_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(RaycastHit2D*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258836, XrefRangeEnd = 1258840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<RaycastHit2D> GetRayIntersectionAll(Ray ray)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&ray);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRayIntersectionAll_Public_Static_Il2CppStructArray_1_RaycastHit2D_Ray_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<RaycastHit2D>>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258840, XrefRangeEnd = 1258844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<RaycastHit2D> GetRayIntersectionAll(Ray ray, float distance)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&ray);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &distance;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRayIntersectionAll_Public_Static_Il2CppStructArray_1_RaycastHit2D_Ray_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<RaycastHit2D>>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258844, XrefRangeEnd = 1258848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<RaycastHit2D> GetRayIntersectionAll(Ray ray, float distance, int layerMask = -5)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&ray);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &distance;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &layerMask;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRayIntersectionAll_Public_Static_Il2CppStructArray_1_RaycastHit2D_Ray_Single_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<RaycastHit2D>>(intPtr2) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1258857, RefRangeEnd = 1258860, XrefRangeStart = 1258848, XrefRangeEnd = 1258857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<RaycastHit2D> GetRayIntersectionAll_Internal(PhysicsScene2D physicsScene, Vector3 origin, Vector3 direction, float distance, int layerMask)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&physicsScene);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &origin;
		*(Vector3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &direction;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &distance;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &layerMask;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRayIntersectionAll_Internal_Private_Static_Il2CppStructArray_1_RaycastHit2D_PhysicsScene2D_Vector3_Vector3_Single_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<RaycastHit2D>>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258860, XrefRangeEnd = 1258875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetRayIntersectionNonAlloc(Ray ray, Il2CppStructArray<RaycastHit2D> results, float distance, int layerMask = -5)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&ray);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)results);
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &distance;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &layerMask;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRayIntersectionNonAlloc_Public_Static_Int32_Ray_Il2CppStructArray_1_RaycastHit2D_Single_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258875, XrefRangeEnd = 1258890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetRayIntersectionNonAlloc(Ray ray, Il2CppStructArray<RaycastHit2D> results)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&ray);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)results);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRayIntersectionNonAlloc_Public_Static_Int32_Ray_Il2CppStructArray_1_RaycastHit2D_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258890, XrefRangeEnd = 1258905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetRayIntersectionNonAlloc(Ray ray, Il2CppStructArray<RaycastHit2D> results, float distance)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&ray);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)results);
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &distance;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRayIntersectionNonAlloc_Public_Static_Int32_Ray_Il2CppStructArray_1_RaycastHit2D_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258905, XrefRangeEnd = 1258907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void get_gravity_Injected(out Vector2 ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_gravity_Injected_Private_Static_Void_byref_Vector2_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258907, XrefRangeEnd = 1258909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetRayIntersectionAll_Internal_Injected([In] ref PhysicsScene2D physicsScene, [In] ref Vector3 origin, [In] ref Vector3 direction, float distance, int layerMask, out BlittableArrayWrapper ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)Unsafe.AsPointer(ref physicsScene);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref origin);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref direction);
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &distance;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &layerMask;
		*(void**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRayIntersectionAll_Internal_Injected_Private_Static_Void_byref_PhysicsScene2D_byref_Vector3_byref_Vector3_Single_Int32_byref_BlittableArrayWrapper_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public Physics2D(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public static bool Simulate(float deltaTime)
	{
		return Simulate_Internal(defaultPhysicsScene, deltaTime, -1);
	}

	public static bool Simulate(float deltaTime, [Optional] int simulationLayers)
	{
		return Simulate_Internal(defaultPhysicsScene, deltaTime, simulationLayers);
	}

	public static bool Simulate_Internal(PhysicsScene2D physicsScene, float deltaTime, int simulationLayers)
	{
		return Simulate_Internal_Injected(ref physicsScene, deltaTime, simulationLayers);
	}

	public static void SyncTransforms()
	{
		SyncTransformsDelegateField();
	}

	public static void IgnoreCollision(Collider2D collider1, Collider2D collider2)
	{
		IgnoreCollision(collider1, collider2, ignore: true);
	}

	public static void IgnoreCollision(Collider2D collider1, Collider2D collider2, bool ignore)
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

	public static bool GetIgnoreCollision(Collider2D collider1, Collider2D collider2)
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

	public static void IgnoreLayerCollision(int layer1, int layer2)
	{
		IgnoreLayerCollision(layer1, layer2, ignore: true);
	}

	public static void IgnoreLayerCollision(int layer1, int layer2, bool ignore)
	{
		if (layer1 < 0 || layer1 > 31)
		{
			throw new Il2CppSystem.ArgumentOutOfRangeException("layer1 is out of range. Layer numbers must be in the range 0 to 31.");
		}
		if (layer2 < 0 || layer2 > 31)
		{
			throw new Il2CppSystem.ArgumentOutOfRangeException("layer2 is out of range. Layer numbers must be in the range 0 to 31.");
		}
		IgnoreLayerCollision_Internal(layer1, layer2, ignore);
	}

	public static void IgnoreLayerCollision_Internal(int layer1, int layer2, bool ignore)
	{
		IgnoreLayerCollision_InternalDelegateField(layer1, layer2, ignore);
	}

	public static bool GetIgnoreLayerCollision(int layer1, int layer2)
	{
		if (layer1 < 0 || layer1 > 31)
		{
			throw new Il2CppSystem.ArgumentOutOfRangeException("layer1 is out of range. Layer numbers must be in the range 0 to 31.");
		}
		if (layer2 < 0 || layer2 > 31)
		{
			throw new Il2CppSystem.ArgumentOutOfRangeException("layer2 is out of range. Layer numbers must be in the range 0 to 31.");
		}
		return GetIgnoreLayerCollision_Internal(layer1, layer2);
	}

	public static bool GetIgnoreLayerCollision_Internal(int layer1, int layer2)
	{
		return GetIgnoreLayerCollision_InternalDelegateField(layer1, layer2);
	}

	public static void SetLayerCollisionMask(int layer, int layerMask)
	{
		if (layer < 0 || layer > 31)
		{
			throw new Il2CppSystem.ArgumentOutOfRangeException("layer1 is out of range. Layer numbers must be in the range 0 to 31.");
		}
		SetLayerCollisionMask_Internal(layer, layerMask);
	}

	public static void SetLayerCollisionMask_Internal(int layer, int layerMask)
	{
		SetLayerCollisionMask_InternalDelegateField(layer, layerMask);
	}

	public static int GetLayerCollisionMask(int layer)
	{
		if (layer < 0 || layer > 31)
		{
			throw new Il2CppSystem.ArgumentOutOfRangeException("layer1 is out of range. Layer numbers must be in the range 0 to 31.");
		}
		return GetLayerCollisionMask_Internal(layer);
	}

	public static int GetLayerCollisionMask_Internal(int layer)
	{
		return GetLayerCollisionMask_InternalDelegateField(layer);
	}

	public static bool IsTouching(Collider2D collider1, Collider2D collider2)
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
		return IsTouching_Injected(intPtr, intPtr2);
	}

	public static bool IsTouching(Collider2D collider1, Collider2D collider2, ContactFilter2D contactFilter)
	{
		return IsTouching_TwoCollidersWithFilter(collider1, collider2, contactFilter);
	}

	public static bool IsTouching_TwoCollidersWithFilter(Collider2D collider1, Collider2D collider2, ContactFilter2D contactFilter)
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
		return IsTouching_TwoCollidersWithFilter_Injected(intPtr, intPtr2, ref contactFilter);
	}

	public static bool IsTouching(Collider2D collider, ContactFilter2D contactFilter)
	{
		return IsTouching_SingleColliderWithFilter(collider, contactFilter);
	}

	public static bool IsTouching_SingleColliderWithFilter(Collider2D collider, ContactFilter2D contactFilter)
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
		return IsTouching_SingleColliderWithFilter_Injected(intPtr, ref contactFilter);
	}

	public static bool IsTouchingLayers(Collider2D collider)
	{
		return IsTouchingLayers(collider, -1);
	}

	public static bool IsTouchingLayers(Collider2D collider, int layerMask)
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
		return IsTouchingLayers_Injected(intPtr, layerMask);
	}

	public static Vector2 ClosestPoint(Vector2 position, Collider2D collider)
	{
		if (collider == null)
		{
			throw new Il2CppSystem.ArgumentNullException("Collider cannot be NULL.");
		}
		return ClosestPoint_Collider(position, collider);
	}

	public static Vector2 ClosestPoint(Vector2 position, Rigidbody2D rigidbody)
	{
		if (rigidbody == null)
		{
			throw new Il2CppSystem.ArgumentNullException("Rigidbody cannot be NULL.");
		}
		return ClosestPoint_Rigidbody(position, rigidbody);
	}

	public static Vector2 ClosestPoint_Collider(Vector2 position, Collider2D collider)
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
		ClosestPoint_Collider_Injected(ref position, intPtr, out var ret);
		return ret;
	}

	public static Vector2 ClosestPoint_Rigidbody(Vector2 position, Rigidbody2D rigidbody)
	{
		if ((object)rigidbody == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(rigidbody, "rigidbody");
		}
		System.IntPtr intPtr = Object.MarshalledUnityObject.MarshalNotNull(rigidbody);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(rigidbody, "rigidbody");
		}
		ClosestPoint_Rigidbody_Injected(ref position, intPtr, out var ret);
		return ret;
	}

	public static RaycastHit2D Linecast(Vector2 start, Vector2 end)
	{
		return defaultPhysicsScene.Linecast(start, end, -5);
	}

	public static RaycastHit2D Linecast(Vector2 start, Vector2 end, int layerMask)
	{
		ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
		return defaultPhysicsScene.Linecast(start, end, contactFilter);
	}

	public static RaycastHit2D Linecast(Vector2 start, Vector2 end, int layerMask, float minDepth)
	{
		ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, float.PositiveInfinity);
		return defaultPhysicsScene.Linecast(start, end, contactFilter);
	}

	public static RaycastHit2D Linecast(Vector2 start, Vector2 end, int layerMask, float minDepth, float maxDepth)
	{
		ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, maxDepth);
		return defaultPhysicsScene.Linecast(start, end, contactFilter);
	}

	public static int Linecast(Vector2 start, Vector2 end, ContactFilter2D contactFilter, Il2CppStructArray<RaycastHit2D> results)
	{
		return defaultPhysicsScene.Linecast(start, end, contactFilter, results);
	}

	public static int Linecast(Vector2 start, Vector2 end, ContactFilter2D contactFilter, List<RaycastHit2D> results)
	{
		return defaultPhysicsScene.Linecast(start, end, contactFilter, results);
	}

	public static Il2CppStructArray<RaycastHit2D> LinecastAll(Vector2 start, Vector2 end)
	{
		ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(-5, float.NegativeInfinity, float.PositiveInfinity);
		return LinecastAll_Internal(defaultPhysicsScene, start, end, contactFilter);
	}

	public static Il2CppStructArray<RaycastHit2D> LinecastAll(Vector2 start, Vector2 end, int layerMask)
	{
		ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
		return LinecastAll_Internal(defaultPhysicsScene, start, end, contactFilter);
	}

	public static Il2CppStructArray<RaycastHit2D> LinecastAll(Vector2 start, Vector2 end, int layerMask, float minDepth)
	{
		ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, float.PositiveInfinity);
		return LinecastAll_Internal(defaultPhysicsScene, start, end, contactFilter);
	}

	public static Il2CppStructArray<RaycastHit2D> LinecastAll(Vector2 start, Vector2 end, int layerMask, float minDepth, float maxDepth)
	{
		ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, maxDepth);
		return LinecastAll_Internal(defaultPhysicsScene, start, end, contactFilter);
	}

	public unsafe static Il2CppStructArray<RaycastHit2D> LinecastAll_Internal(PhysicsScene2D physicsScene, Vector2 start, Vector2 end, ContactFilter2D contactFilter)
	{
		Unsafe.SkipInit(out BlittableArrayWrapper ret);
		Il2CppStructArray<RaycastHit2D> result;
		try
		{
			LinecastAll_Internal_Injected(ref physicsScene, ref start, ref end, ref contactFilter, out ret);
		}
		finally
		{
			Unsafe.SkipInit(out Il2CppStructArray<RaycastHit2D> array);
			ret.Unmarshal(ref *(Il2CppArrayBase<RaycastHit2D>*)(&array));
			result = array;
		}
		return result;
	}

	public static int RaycastNonAlloc(Vector2 origin, Vector2 direction, Il2CppStructArray<RaycastHit2D> results, float distance, int layerMask)
	{
		ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
		return defaultPhysicsScene.Raycast(origin, direction, distance, contactFilter, results);
	}

	public static Il2CppStructArray<RaycastHit2D> RaycastAll(Vector2 origin, Vector2 direction)
	{
		ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(-5, float.NegativeInfinity, float.PositiveInfinity);
		return RaycastAll_Internal(defaultPhysicsScene, origin, direction, float.PositiveInfinity, contactFilter);
	}

	public static Il2CppStructArray<RaycastHit2D> RaycastAll(Vector2 origin, Vector2 direction, float distance)
	{
		ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(-5, float.NegativeInfinity, float.PositiveInfinity);
		return RaycastAll_Internal(defaultPhysicsScene, origin, direction, distance, contactFilter);
	}

	public static Il2CppStructArray<RaycastHit2D> RaycastAll(Vector2 origin, Vector2 direction, float distance, int layerMask)
	{
		ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
		return RaycastAll_Internal(defaultPhysicsScene, origin, direction, distance, contactFilter);
	}

	public static Il2CppStructArray<RaycastHit2D> RaycastAll(Vector2 origin, Vector2 direction, float distance, int layerMask, float minDepth)
	{
		ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, float.PositiveInfinity);
		return RaycastAll_Internal(defaultPhysicsScene, origin, direction, distance, contactFilter);
	}

	public static Il2CppStructArray<RaycastHit2D> RaycastAll(Vector2 origin, Vector2 direction, float distance, int layerMask, float minDepth, float maxDepth)
	{
		ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, maxDepth);
		return RaycastAll_Internal(defaultPhysicsScene, origin, direction, distance, contactFilter);
	}

	public unsafe static Il2CppStructArray<RaycastHit2D> RaycastAll_Internal(PhysicsScene2D physicsScene, Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter)
	{
		Unsafe.SkipInit(out BlittableArrayWrapper ret);
		Il2CppStructArray<RaycastHit2D> result;
		try
		{
			RaycastAll_Internal_Injected(ref physicsScene, ref origin, ref direction, distance, ref contactFilter, out ret);
		}
		finally
		{
			Unsafe.SkipInit(out Il2CppStructArray<RaycastHit2D> array);
			ret.Unmarshal(ref *(Il2CppArrayBase<RaycastHit2D>*)(&array));
			result = array;
		}
		return result;
	}

	public static RaycastHit2D CircleCast(Vector2 origin, float radius, Vector2 direction)
	{
		return defaultPhysicsScene.CircleCast(origin, radius, direction, float.PositiveInfinity, -5);
	}

	public static RaycastHit2D CircleCast(Vector2 origin, float radius, Vector2 direction, float distance)
	{
		return defaultPhysicsScene.CircleCast(origin, radius, direction, distance, -5);
	}

	public static RaycastHit2D CircleCast(Vector2 origin, float radius, Vector2 direction, float distance, int layerMask)
	{
		ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
		return defaultPhysicsScene.CircleCast(origin, radius, direction, distance, contactFilter);
	}

	public static RaycastHit2D CircleCast(Vector2 origin, float radius, Vector2 direction, float distance, int layerMask, float minDepth)
	{
		ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, float.PositiveInfinity);
		return defaultPhysicsScene.CircleCast(origin, radius, direction, distance, contactFilter);
	}

	public static RaycastHit2D CircleCast(Vector2 origin, float radius, Vector2 direction, float distance, int layerMask, float minDepth, float maxDepth)
	{
		ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, maxDepth);
		return defaultPhysicsScene.CircleCast(origin, radius, direction, distance, contactFilter);
	}

	public static int CircleCast(Vector2 origin, float radius, Vector2 direction, ContactFilter2D contactFilter, Il2CppStructArray<RaycastHit2D> results)
	{
		return defaultPhysicsScene.CircleCast(origin, radius, direction, float.PositiveInfinity, contactFilter, results);
	}

	public static int CircleCast(Vector2 origin, float radius, Vector2 direction, ContactFilter2D contactFilter, Il2CppStructArray<RaycastHit2D> results, float distance)
	{
		return defaultPhysicsScene.CircleCast(origin, radius, direction, distance, contactFilter, results);
	}

	public static int CircleCast(Vector2 origin, float radius, Vector2 direction, ContactFilter2D contactFilter, List<RaycastHit2D> results, [Optional] float distance)
	{
		return defaultPhysicsScene.CircleCast(origin, radius, direction, distance, contactFilter, results);
	}

	public static Il2CppStructArray<RaycastHit2D> CircleCastAll(Vector2 origin, float radius, Vector2 direction)
	{
		ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(-5, float.NegativeInfinity, float.PositiveInfinity);
		return CircleCastAll_Internal(defaultPhysicsScene, origin, radius, direction, float.PositiveInfinity, contactFilter);
	}

	public static Il2CppStructArray<RaycastHit2D> CircleCastAll(Vector2 origin, float radius, Vector2 direction, float distance)
	{
		ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(-5, float.NegativeInfinity, float.PositiveInfinity);
		return CircleCastAll_Internal(defaultPhysicsScene, origin, radius, direction, distance, contactFilter);
	}

	public static Il2CppStructArray<RaycastHit2D> CircleCastAll(Vector2 origin, float radius, Vector2 direction, float distance, int layerMask)
	{
		ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
		return CircleCastAll_Internal(defaultPhysicsScene, origin, radius, direction, distance, contactFilter);
	}

	public static Il2CppStructArray<RaycastHit2D> CircleCastAll(Vector2 origin, float radius, Vector2 direction, float distance, int layerMask, float minDepth)
	{
		ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, float.PositiveInfinity);
		return CircleCastAll_Internal(defaultPhysicsScene, origin, radius, direction, distance, contactFilter);
	}

	public static Il2CppStructArray<RaycastHit2D> CircleCastAll(Vector2 origin, float radius, Vector2 direction, float distance, int layerMask, float minDepth, float maxDepth)
	{
		ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, maxDepth);
		return CircleCastAll_Internal(defaultPhysicsScene, origin, radius, direction, distance, contactFilter);
	}

	public unsafe static Il2CppStructArray<RaycastHit2D> CircleCastAll_Internal(PhysicsScene2D physicsScene, Vector2 origin, float radius, Vector2 direction, float distance, ContactFilter2D contactFilter)
	{
		Unsafe.SkipInit(out BlittableArrayWrapper ret);
		Il2CppStructArray<RaycastHit2D> result;
		try
		{
			CircleCastAll_Internal_Injected(ref physicsScene, ref origin, radius, ref direction, distance, ref contactFilter, out ret);
		}
		finally
		{
			Unsafe.SkipInit(out Il2CppStructArray<RaycastHit2D> array);
			ret.Unmarshal(ref *(Il2CppArrayBase<RaycastHit2D>*)(&array));
			result = array;
		}
		return result;
	}

	public static RaycastHit2D BoxCast(Vector2 origin, Vector2 size, float angle, Vector2 direction)
	{
		return defaultPhysicsScene.BoxCast(origin, size, angle, direction, float.PositiveInfinity, -5);
	}

	public static RaycastHit2D BoxCast(Vector2 origin, Vector2 size, float angle, Vector2 direction, float distance)
	{
		return defaultPhysicsScene.BoxCast(origin, size, angle, direction, distance, -5);
	}

	public static RaycastHit2D BoxCast(Vector2 origin, Vector2 size, float angle, Vector2 direction, float distance, int layerMask)
	{
		ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
		return defaultPhysicsScene.BoxCast(origin, size, angle, direction, distance, contactFilter);
	}

	public static RaycastHit2D BoxCast(Vector2 origin, Vector2 size, float angle, Vector2 direction, float distance, int layerMask, float minDepth)
	{
		ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, float.PositiveInfinity);
		return defaultPhysicsScene.BoxCast(origin, size, angle, direction, distance, contactFilter);
	}

	public static RaycastHit2D BoxCast(Vector2 origin, Vector2 size, float angle, Vector2 direction, float distance, int layerMask, float minDepth, float maxDepth)
	{
		ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, maxDepth);
		return defaultPhysicsScene.BoxCast(origin, size, angle, direction, distance, contactFilter);
	}

	public static int BoxCast(Vector2 origin, Vector2 size, float angle, Vector2 direction, ContactFilter2D contactFilter, Il2CppStructArray<RaycastHit2D> results)
	{
		return defaultPhysicsScene.BoxCast(origin, size, angle, direction, float.PositiveInfinity, contactFilter, results);
	}

	public static int BoxCast(Vector2 origin, Vector2 size, float angle, Vector2 direction, ContactFilter2D contactFilter, Il2CppStructArray<RaycastHit2D> results, float distance)
	{
		return defaultPhysicsScene.BoxCast(origin, size, angle, direction, distance, contactFilter, results);
	}

	public static int BoxCast(Vector2 origin, Vector2 size, float angle, Vector2 direction, ContactFilter2D contactFilter, List<RaycastHit2D> results, [Optional] float distance)
	{
		return defaultPhysicsScene.BoxCast(origin, size, angle, direction, distance, contactFilter, results);
	}

	public static Il2CppStructArray<RaycastHit2D> BoxCastAll(Vector2 origin, Vector2 size, float angle, Vector2 direction)
	{
		ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(-5, float.NegativeInfinity, float.PositiveInfinity);
		return BoxCastAll_Internal(defaultPhysicsScene, origin, size, angle, direction, float.PositiveInfinity, contactFilter);
	}

	public static Il2CppStructArray<RaycastHit2D> BoxCastAll(Vector2 origin, Vector2 size, float angle, Vector2 direction, float distance)
	{
		ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(-5, float.NegativeInfinity, float.PositiveInfinity);
		return BoxCastAll_Internal(defaultPhysicsScene, origin, size, angle, direction, distance, contactFilter);
	}

	public static Il2CppStructArray<RaycastHit2D> BoxCastAll(Vector2 origin, Vector2 size, float angle, Vector2 direction, float distance, int layerMask)
	{
		ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
		return BoxCastAll_Internal(defaultPhysicsScene, origin, size, angle, direction, distance, contactFilter);
	}

	public static Il2CppStructArray<RaycastHit2D> BoxCastAll(Vector2 origin, Vector2 size, float angle, Vector2 direction, float distance, int layerMask, float minDepth)
	{
		ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, float.PositiveInfinity);
		return BoxCastAll_Internal(defaultPhysicsScene, origin, size, angle, direction, distance, contactFilter);
	}

	public static Il2CppStructArray<RaycastHit2D> BoxCastAll(Vector2 origin, Vector2 size, float angle, Vector2 direction, float distance, int layerMask, float minDepth, float maxDepth)
	{
		ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, maxDepth);
		return BoxCastAll_Internal(defaultPhysicsScene, origin, size, angle, direction, distance, contactFilter);
	}

	public unsafe static Il2CppStructArray<RaycastHit2D> BoxCastAll_Internal(PhysicsScene2D physicsScene, Vector2 origin, Vector2 size, float angle, Vector2 direction, float distance, ContactFilter2D contactFilter)
	{
		Unsafe.SkipInit(out BlittableArrayWrapper ret);
		Il2CppStructArray<RaycastHit2D> result;
		try
		{
			BoxCastAll_Internal_Injected(ref physicsScene, ref origin, ref size, angle, ref direction, distance, ref contactFilter, out ret);
		}
		finally
		{
			Unsafe.SkipInit(out Il2CppStructArray<RaycastHit2D> array);
			ret.Unmarshal(ref *(Il2CppArrayBase<RaycastHit2D>*)(&array));
			result = array;
		}
		return result;
	}

	public static RaycastHit2D CapsuleCast(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction)
	{
		return defaultPhysicsScene.CapsuleCast(origin, size, capsuleDirection, angle, direction, float.PositiveInfinity, -5);
	}

	public static RaycastHit2D CapsuleCast(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction, float distance)
	{
		return defaultPhysicsScene.CapsuleCast(origin, size, capsuleDirection, angle, direction, distance, -5);
	}

	public static RaycastHit2D CapsuleCast(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction, float distance, int layerMask)
	{
		ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
		return defaultPhysicsScene.CapsuleCast(origin, size, capsuleDirection, angle, direction, distance, contactFilter);
	}

	public static RaycastHit2D CapsuleCast(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction, float distance, int layerMask, float minDepth)
	{
		ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, float.PositiveInfinity);
		return defaultPhysicsScene.CapsuleCast(origin, size, capsuleDirection, angle, direction, distance, contactFilter);
	}

	public static RaycastHit2D CapsuleCast(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction, float distance, int layerMask, float minDepth, float maxDepth)
	{
		ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, maxDepth);
		return defaultPhysicsScene.CapsuleCast(origin, size, capsuleDirection, angle, direction, distance, contactFilter);
	}

	public static int CapsuleCast(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction, ContactFilter2D contactFilter, Il2CppStructArray<RaycastHit2D> results)
	{
		return defaultPhysicsScene.CapsuleCast(origin, size, capsuleDirection, angle, direction, float.PositiveInfinity, contactFilter, results);
	}

	public static int CapsuleCast(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction, ContactFilter2D contactFilter, Il2CppStructArray<RaycastHit2D> results, float distance)
	{
		return defaultPhysicsScene.CapsuleCast(origin, size, capsuleDirection, angle, direction, distance, contactFilter, results);
	}

	public static int CapsuleCast(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction, ContactFilter2D contactFilter, List<RaycastHit2D> results, [Optional] float distance)
	{
		return defaultPhysicsScene.CapsuleCast(origin, size, capsuleDirection, angle, direction, distance, contactFilter, results);
	}

	public static Il2CppStructArray<RaycastHit2D> CapsuleCastAll(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction)
	{
		ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(-5, float.NegativeInfinity, float.PositiveInfinity);
		return CapsuleCastAll_Internal(defaultPhysicsScene, origin, size, capsuleDirection, angle, direction, float.PositiveInfinity, contactFilter);
	}

	public static Il2CppStructArray<RaycastHit2D> CapsuleCastAll(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction, float distance)
	{
		ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(-5, float.NegativeInfinity, float.PositiveInfinity);
		return CapsuleCastAll_Internal(defaultPhysicsScene, origin, size, capsuleDirection, angle, direction, distance, contactFilter);
	}

	public unsafe static Il2CppStructArray<RaycastHit2D> CapsuleCastAll_Internal(PhysicsScene2D physicsScene, Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction, float distance, ContactFilter2D contactFilter)
	{
		Unsafe.SkipInit(out BlittableArrayWrapper ret);
		Il2CppStructArray<RaycastHit2D> result;
		try
		{
			CapsuleCastAll_Internal_Injected(ref physicsScene, ref origin, ref size, capsuleDirection, angle, ref direction, distance, ref contactFilter, out ret);
		}
		finally
		{
			Unsafe.SkipInit(out Il2CppStructArray<RaycastHit2D> array);
			ret.Unmarshal(ref *(Il2CppArrayBase<RaycastHit2D>*)(&array));
			result = array;
		}
		return result;
	}

	public static Il2CppStructArray<RaycastHit2D> CapsuleCastAll(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction, float distance, int layerMask)
	{
		ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
		return CapsuleCastAll_Internal(defaultPhysicsScene, origin, size, capsuleDirection, angle, direction, distance, contactFilter);
	}

	public static Il2CppStructArray<RaycastHit2D> CapsuleCastAll(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction, float distance, int layerMask, float minDepth)
	{
		ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, float.PositiveInfinity);
		return CapsuleCastAll_Internal(defaultPhysicsScene, origin, size, capsuleDirection, angle, direction, distance, contactFilter);
	}

	public static Il2CppStructArray<RaycastHit2D> CapsuleCastAll(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction, float distance, int layerMask, float minDepth, float maxDepth)
	{
		ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, maxDepth);
		return CapsuleCastAll_Internal(defaultPhysicsScene, origin, size, capsuleDirection, angle, direction, distance, contactFilter);
	}

	public static RaycastHit2D GetRayIntersection(Ray ray)
	{
		return defaultPhysicsScene.GetRayIntersection(ray, float.PositiveInfinity);
	}

	public static RaycastHit2D GetRayIntersection(Ray ray, float distance)
	{
		return defaultPhysicsScene.GetRayIntersection(ray, distance);
	}

	public static int GetRayIntersection(Ray ray, float distance, List<RaycastHit2D> results, [Optional] int layerMask)
	{
		return defaultPhysicsScene.GetRayIntersection(ray, distance, results, layerMask);
	}

	public static Collider2D OverlapPoint(Vector2 point)
	{
		return defaultPhysicsScene.OverlapPoint(point, -5);
	}

	public static Collider2D OverlapPoint(Vector2 point, int layerMask)
	{
		ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
		return defaultPhysicsScene.OverlapPoint(point, contactFilter);
	}

	public static Collider2D OverlapPoint(Vector2 point, int layerMask, float minDepth)
	{
		ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, float.PositiveInfinity);
		return defaultPhysicsScene.OverlapPoint(point, contactFilter);
	}

	public static Collider2D OverlapPoint(Vector2 point, int layerMask, float minDepth, float maxDepth)
	{
		ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, maxDepth);
		return defaultPhysicsScene.OverlapPoint(point, contactFilter);
	}

	public static int OverlapPoint(Vector2 point, ContactFilter2D contactFilter, Il2CppReferenceArray<Collider2D> results)
	{
		return defaultPhysicsScene.OverlapPoint(point, contactFilter, results);
	}

	public static int OverlapPoint(Vector2 point, ContactFilter2D contactFilter, List<Collider2D> results)
	{
		return defaultPhysicsScene.OverlapPoint(point, contactFilter, results);
	}

	public static Il2CppReferenceArray<Collider2D> OverlapPointAll(Vector2 point)
	{
		ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(-5, float.NegativeInfinity, float.PositiveInfinity);
		return OverlapPointAll_Internal(defaultPhysicsScene, point, contactFilter);
	}

	public static Il2CppReferenceArray<Collider2D> OverlapPointAll(Vector2 point, int layerMask)
	{
		ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
		return OverlapPointAll_Internal(defaultPhysicsScene, point, contactFilter);
	}

	public static Il2CppReferenceArray<Collider2D> OverlapPointAll(Vector2 point, int layerMask, float minDepth)
	{
		ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, float.PositiveInfinity);
		return OverlapPointAll_Internal(defaultPhysicsScene, point, contactFilter);
	}

	public static Il2CppReferenceArray<Collider2D> OverlapPointAll(Vector2 point, int layerMask, float minDepth, float maxDepth)
	{
		ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, maxDepth);
		return OverlapPointAll_Internal(defaultPhysicsScene, point, contactFilter);
	}

	public static Il2CppReferenceArray<Collider2D> OverlapPointAll_Internal(PhysicsScene2D physicsScene, Vector2 point, ContactFilter2D contactFilter)
	{
		return OverlapPointAll_Internal_Injected(ref physicsScene, ref point, ref contactFilter);
	}

	public static Collider2D OverlapCircle(Vector2 point, float radius)
	{
		return defaultPhysicsScene.OverlapCircle(point, radius, -5);
	}

	public static Collider2D OverlapCircle(Vector2 point, float radius, int layerMask)
	{
		ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
		return defaultPhysicsScene.OverlapCircle(point, radius, contactFilter);
	}

	public static Collider2D OverlapCircle(Vector2 point, float radius, int layerMask, float minDepth)
	{
		ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, float.PositiveInfinity);
		return defaultPhysicsScene.OverlapCircle(point, radius, contactFilter);
	}

	public static Collider2D OverlapCircle(Vector2 point, float radius, int layerMask, float minDepth, float maxDepth)
	{
		ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, maxDepth);
		return defaultPhysicsScene.OverlapCircle(point, radius, contactFilter);
	}

	public static int OverlapCircle(Vector2 point, float radius, ContactFilter2D contactFilter, Il2CppReferenceArray<Collider2D> results)
	{
		return defaultPhysicsScene.OverlapCircle(point, radius, contactFilter, results);
	}

	public static int OverlapCircle(Vector2 point, float radius, ContactFilter2D contactFilter, List<Collider2D> results)
	{
		return defaultPhysicsScene.OverlapCircle(point, radius, contactFilter, results);
	}

	public static Il2CppReferenceArray<Collider2D> OverlapCircleAll(Vector2 point, float radius)
	{
		ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(-5, float.NegativeInfinity, float.PositiveInfinity);
		return OverlapCircleAll_Internal(defaultPhysicsScene, point, radius, contactFilter);
	}

	public static Il2CppReferenceArray<Collider2D> OverlapCircleAll(Vector2 point, float radius, int layerMask)
	{
		ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
		return OverlapCircleAll_Internal(defaultPhysicsScene, point, radius, contactFilter);
	}

	public static Il2CppReferenceArray<Collider2D> OverlapCircleAll(Vector2 point, float radius, int layerMask, float minDepth)
	{
		ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, float.PositiveInfinity);
		return OverlapCircleAll_Internal(defaultPhysicsScene, point, radius, contactFilter);
	}

	public static Il2CppReferenceArray<Collider2D> OverlapCircleAll(Vector2 point, float radius, int layerMask, float minDepth, float maxDepth)
	{
		ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, maxDepth);
		return OverlapCircleAll_Internal(defaultPhysicsScene, point, radius, contactFilter);
	}

	public static Il2CppReferenceArray<Collider2D> OverlapCircleAll_Internal(PhysicsScene2D physicsScene, Vector2 point, float radius, ContactFilter2D contactFilter)
	{
		return OverlapCircleAll_Internal_Injected(ref physicsScene, ref point, radius, ref contactFilter);
	}

	public static Collider2D OverlapBox(Vector2 point, Vector2 size, float angle)
	{
		return defaultPhysicsScene.OverlapBox(point, size, angle, -5);
	}

	public static Collider2D OverlapBox(Vector2 point, Vector2 size, float angle, int layerMask)
	{
		ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
		return defaultPhysicsScene.OverlapBox(point, size, angle, contactFilter);
	}

	public static Collider2D OverlapBox(Vector2 point, Vector2 size, float angle, int layerMask, float minDepth)
	{
		ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, float.PositiveInfinity);
		return defaultPhysicsScene.OverlapBox(point, size, angle, contactFilter);
	}

	public static Collider2D OverlapBox(Vector2 point, Vector2 size, float angle, int layerMask, float minDepth, float maxDepth)
	{
		ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, maxDepth);
		return defaultPhysicsScene.OverlapBox(point, size, angle, contactFilter);
	}

	public static int OverlapBox(Vector2 point, Vector2 size, float angle, ContactFilter2D contactFilter, Il2CppReferenceArray<Collider2D> results)
	{
		return defaultPhysicsScene.OverlapBox(point, size, angle, contactFilter, results);
	}

	public static int OverlapBox(Vector2 point, Vector2 size, float angle, ContactFilter2D contactFilter, List<Collider2D> results)
	{
		return defaultPhysicsScene.OverlapBox(point, size, angle, contactFilter, results);
	}

	public static Il2CppReferenceArray<Collider2D> OverlapBoxAll(Vector2 point, Vector2 size, float angle)
	{
		ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(-5, float.NegativeInfinity, float.PositiveInfinity);
		return OverlapBoxAll_Internal(defaultPhysicsScene, point, size, angle, contactFilter);
	}

	public static Il2CppReferenceArray<Collider2D> OverlapBoxAll(Vector2 point, Vector2 size, float angle, int layerMask)
	{
		ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
		return OverlapBoxAll_Internal(defaultPhysicsScene, point, size, angle, contactFilter);
	}

	public static Il2CppReferenceArray<Collider2D> OverlapBoxAll(Vector2 point, Vector2 size, float angle, int layerMask, float minDepth)
	{
		ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, float.PositiveInfinity);
		return OverlapBoxAll_Internal(defaultPhysicsScene, point, size, angle, contactFilter);
	}

	public static Il2CppReferenceArray<Collider2D> OverlapBoxAll(Vector2 point, Vector2 size, float angle, int layerMask, float minDepth, float maxDepth)
	{
		ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, maxDepth);
		return OverlapBoxAll_Internal(defaultPhysicsScene, point, size, angle, contactFilter);
	}

	public static Il2CppReferenceArray<Collider2D> OverlapBoxAll_Internal(PhysicsScene2D physicsScene, Vector2 point, Vector2 size, float angle, ContactFilter2D contactFilter)
	{
		return OverlapBoxAll_Internal_Injected(ref physicsScene, ref point, ref size, angle, ref contactFilter);
	}

	public static Collider2D OverlapArea(Vector2 pointA, Vector2 pointB)
	{
		return defaultPhysicsScene.OverlapArea(pointA, pointB, -5);
	}

	public static Collider2D OverlapArea(Vector2 pointA, Vector2 pointB, int layerMask)
	{
		ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
		return defaultPhysicsScene.OverlapArea(pointA, pointB, contactFilter);
	}

	public static Collider2D OverlapArea(Vector2 pointA, Vector2 pointB, int layerMask, float minDepth)
	{
		ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, float.PositiveInfinity);
		return defaultPhysicsScene.OverlapArea(pointA, pointB, contactFilter);
	}

	public static Collider2D OverlapArea(Vector2 pointA, Vector2 pointB, int layerMask, float minDepth, float maxDepth)
	{
		ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, maxDepth);
		return defaultPhysicsScene.OverlapArea(pointA, pointB, contactFilter);
	}

	public static int OverlapArea(Vector2 pointA, Vector2 pointB, ContactFilter2D contactFilter, Il2CppReferenceArray<Collider2D> results)
	{
		return defaultPhysicsScene.OverlapArea(pointA, pointB, contactFilter, results);
	}

	public static int OverlapArea(Vector2 pointA, Vector2 pointB, ContactFilter2D contactFilter, List<Collider2D> results)
	{
		return defaultPhysicsScene.OverlapArea(pointA, pointB, contactFilter, results);
	}

	public static Il2CppReferenceArray<Collider2D> OverlapAreaAll(Vector2 pointA, Vector2 pointB)
	{
		return OverlapAreaAllToBox_Internal(pointA, pointB, -5, float.NegativeInfinity, float.PositiveInfinity);
	}

	public static Il2CppReferenceArray<Collider2D> OverlapAreaAll(Vector2 pointA, Vector2 pointB, int layerMask)
	{
		return OverlapAreaAllToBox_Internal(pointA, pointB, layerMask, float.NegativeInfinity, float.PositiveInfinity);
	}

	public static Il2CppReferenceArray<Collider2D> OverlapAreaAll(Vector2 pointA, Vector2 pointB, int layerMask, float minDepth)
	{
		return OverlapAreaAllToBox_Internal(pointA, pointB, layerMask, minDepth, float.PositiveInfinity);
	}

	public static Il2CppReferenceArray<Collider2D> OverlapAreaAll(Vector2 pointA, Vector2 pointB, int layerMask, float minDepth, float maxDepth)
	{
		return OverlapAreaAllToBox_Internal(pointA, pointB, layerMask, minDepth, maxDepth);
	}

	public static Il2CppReferenceArray<Collider2D> OverlapAreaAllToBox_Internal(Vector2 pointA, Vector2 pointB, int layerMask, float minDepth, float maxDepth)
	{
		Vector2 point = (pointA + pointB) * 0.5f;
		Vector2 size = new Vector2(Mathf.Abs(pointA.x - pointB.x), Il2CppSystem.Math.Abs(pointA.y - pointB.y));
		return OverlapBoxAll(point, size, 0f, layerMask, minDepth, maxDepth);
	}

	public static Collider2D OverlapCapsule(Vector2 point, Vector2 size, CapsuleDirection2D direction, float angle)
	{
		return defaultPhysicsScene.OverlapCapsule(point, size, direction, angle, -5);
	}

	public static Collider2D OverlapCapsule(Vector2 point, Vector2 size, CapsuleDirection2D direction, float angle, int layerMask)
	{
		ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
		return defaultPhysicsScene.OverlapCapsule(point, size, direction, angle, contactFilter);
	}

	public static Collider2D OverlapCapsule(Vector2 point, Vector2 size, CapsuleDirection2D direction, float angle, int layerMask, float minDepth)
	{
		ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, float.PositiveInfinity);
		return defaultPhysicsScene.OverlapCapsule(point, size, direction, angle, contactFilter);
	}

	public static Collider2D OverlapCapsule(Vector2 point, Vector2 size, CapsuleDirection2D direction, float angle, int layerMask, float minDepth, float maxDepth)
	{
		ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, maxDepth);
		return defaultPhysicsScene.OverlapCapsule(point, size, direction, angle, contactFilter);
	}

	public static int OverlapCapsule(Vector2 point, Vector2 size, CapsuleDirection2D direction, float angle, ContactFilter2D contactFilter, Il2CppReferenceArray<Collider2D> results)
	{
		return defaultPhysicsScene.OverlapCapsule(point, size, direction, angle, contactFilter, results);
	}

	public static int OverlapCapsule(Vector2 point, Vector2 size, CapsuleDirection2D direction, float angle, ContactFilter2D contactFilter, List<Collider2D> results)
	{
		return defaultPhysicsScene.OverlapCapsule(point, size, direction, angle, contactFilter, results);
	}

	public static Il2CppReferenceArray<Collider2D> OverlapCapsuleAll(Vector2 point, Vector2 size, CapsuleDirection2D direction, float angle)
	{
		ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(-5, float.NegativeInfinity, float.PositiveInfinity);
		return OverlapCapsuleAll_Internal(defaultPhysicsScene, point, size, direction, angle, contactFilter);
	}

	public static Il2CppReferenceArray<Collider2D> OverlapCapsuleAll(Vector2 point, Vector2 size, CapsuleDirection2D direction, float angle, int layerMask)
	{
		ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
		return OverlapCapsuleAll_Internal(defaultPhysicsScene, point, size, direction, angle, contactFilter);
	}

	public static Il2CppReferenceArray<Collider2D> OverlapCapsuleAll(Vector2 point, Vector2 size, CapsuleDirection2D direction, float angle, int layerMask, float minDepth)
	{
		ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, float.PositiveInfinity);
		return OverlapCapsuleAll_Internal(defaultPhysicsScene, point, size, direction, angle, contactFilter);
	}

	public static Il2CppReferenceArray<Collider2D> OverlapCapsuleAll(Vector2 point, Vector2 size, CapsuleDirection2D direction, float angle, int layerMask, float minDepth, float maxDepth)
	{
		ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, maxDepth);
		return OverlapCapsuleAll_Internal(defaultPhysicsScene, point, size, direction, angle, contactFilter);
	}

	public static Il2CppReferenceArray<Collider2D> OverlapCapsuleAll_Internal(PhysicsScene2D physicsScene, Vector2 point, Vector2 size, CapsuleDirection2D direction, float angle, ContactFilter2D contactFilter)
	{
		return OverlapCapsuleAll_Internal_Injected(ref physicsScene, ref point, ref size, direction, angle, ref contactFilter);
	}

	public static int OverlapCollider(Collider2D collider, ContactFilter2D contactFilter, Il2CppReferenceArray<Collider2D> results)
	{
		return PhysicsScene2D.OverlapCollider(collider, contactFilter, results);
	}

	public static int OverlapCollider(Collider2D collider, ContactFilter2D contactFilter, List<Collider2D> results)
	{
		return PhysicsScene2D.OverlapCollider(collider, contactFilter, results);
	}

	public static int OverlapCollider(Collider2D collider, List<Collider2D> results)
	{
		return PhysicsScene2D.OverlapCollider(collider, results);
	}

	public static int GetContacts(Collider2D collider1, Collider2D collider2, ContactFilter2D contactFilter, Il2CppStructArray<ContactPoint2D> contacts)
	{
		return GetColliderColliderContactsArray(collider1, collider2, contactFilter, contacts);
	}

	public static int GetContacts(Collider2D collider, Il2CppStructArray<ContactPoint2D> contacts)
	{
		return GetColliderContactsArray(collider, default(ContactFilter2D).NoFilter(), contacts);
	}

	public static int GetContacts(Collider2D collider, ContactFilter2D contactFilter, Il2CppStructArray<ContactPoint2D> contacts)
	{
		return GetColliderContactsArray(collider, contactFilter, contacts);
	}

	public static int GetContacts(Collider2D collider, Il2CppReferenceArray<Collider2D> colliders)
	{
		return GetColliderContactsCollidersOnlyArray(collider, default(ContactFilter2D).NoFilter(), colliders);
	}

	public static int GetContacts(Collider2D collider, ContactFilter2D contactFilter, Il2CppReferenceArray<Collider2D> colliders)
	{
		return GetColliderContactsCollidersOnlyArray(collider, contactFilter, colliders);
	}

	public static int GetContacts(Rigidbody2D rigidbody, Il2CppStructArray<ContactPoint2D> contacts)
	{
		return GetRigidbodyContactsArray(rigidbody, default(ContactFilter2D).NoFilter(), contacts);
	}

	public static int GetContacts(Rigidbody2D rigidbody, ContactFilter2D contactFilter, Il2CppStructArray<ContactPoint2D> contacts)
	{
		return GetRigidbodyContactsArray(rigidbody, contactFilter, contacts);
	}

	public static int GetContacts(Rigidbody2D rigidbody, Il2CppReferenceArray<Collider2D> colliders)
	{
		return GetRigidbodyContactsCollidersOnlyArray(rigidbody, default(ContactFilter2D).NoFilter(), colliders);
	}

	public static int GetContacts(Rigidbody2D rigidbody, ContactFilter2D contactFilter, Il2CppReferenceArray<Collider2D> colliders)
	{
		return GetRigidbodyContactsCollidersOnlyArray(rigidbody, contactFilter, colliders);
	}

	public unsafe static int GetColliderContactsArray(Collider2D collider, ContactFilter2D contactFilter, Il2CppStructArray<ContactPoint2D> results)
	{
		//IL_003d: Expected O, but got Ref
		//IL_0044: Expected O, but got Ref
		//IL_0050: Expected O, but got Ref
		if ((object)collider == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(collider, "collider");
		}
		if (results == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object)(object)results, "results");
		}
		System.IntPtr intPtr = Object.MarshalledUnityObject.MarshalNotNull(collider);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(collider, "collider");
		}
		Unsafe.SkipInit(out Il2CppSystem.Span<ContactPoint2D> span);
		((Il2CppSystem.Span<ContactPoint2D>)(&span))._002Ector((Il2CppArrayBase<ContactPoint2D>)(object)results);
		int colliderContactsArray_Injected;
		fixed (ContactPoint2D* begin = &((Il2CppSystem.Span<ContactPoint2D>)(&span)).GetPinnableReference())
		{
			ManagedSpanWrapper results2 = new ManagedSpanWrapper(begin, ((Il2CppSystem.Span<ContactPoint2D>)(&span)).Length);
			colliderContactsArray_Injected = GetColliderContactsArray_Injected(intPtr, ref contactFilter, ref results2);
		}
		return colliderContactsArray_Injected;
	}

	public unsafe static int GetColliderColliderContactsArray(Collider2D collider1, Collider2D collider2, ContactFilter2D contactFilter, Il2CppStructArray<ContactPoint2D> results)
	{
		//IL_0061: Expected O, but got Ref
		//IL_0068: Expected O, but got Ref
		//IL_0074: Expected O, but got Ref
		if ((object)collider1 == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(collider1, "collider1");
		}
		if ((object)collider2 == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(collider2, "collider2");
		}
		if (results == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object)(object)results, "results");
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
		Unsafe.SkipInit(out Il2CppSystem.Span<ContactPoint2D> span);
		((Il2CppSystem.Span<ContactPoint2D>)(&span))._002Ector((Il2CppArrayBase<ContactPoint2D>)(object)results);
		int colliderColliderContactsArray_Injected;
		fixed (ContactPoint2D* begin = &((Il2CppSystem.Span<ContactPoint2D>)(&span)).GetPinnableReference())
		{
			ManagedSpanWrapper results2 = new ManagedSpanWrapper(begin, ((Il2CppSystem.Span<ContactPoint2D>)(&span)).Length);
			colliderColliderContactsArray_Injected = GetColliderColliderContactsArray_Injected(intPtr, intPtr2, ref contactFilter, ref results2);
		}
		return colliderColliderContactsArray_Injected;
	}

	public unsafe static int GetRigidbodyContactsArray(Rigidbody2D rigidbody, ContactFilter2D contactFilter, Il2CppStructArray<ContactPoint2D> results)
	{
		//IL_003d: Expected O, but got Ref
		//IL_0044: Expected O, but got Ref
		//IL_0050: Expected O, but got Ref
		if ((object)rigidbody == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(rigidbody, "rigidbody");
		}
		if (results == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object)(object)results, "results");
		}
		System.IntPtr intPtr = Object.MarshalledUnityObject.MarshalNotNull(rigidbody);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(rigidbody, "rigidbody");
		}
		Unsafe.SkipInit(out Il2CppSystem.Span<ContactPoint2D> span);
		((Il2CppSystem.Span<ContactPoint2D>)(&span))._002Ector((Il2CppArrayBase<ContactPoint2D>)(object)results);
		int rigidbodyContactsArray_Injected;
		fixed (ContactPoint2D* begin = &((Il2CppSystem.Span<ContactPoint2D>)(&span)).GetPinnableReference())
		{
			ManagedSpanWrapper results2 = new ManagedSpanWrapper(begin, ((Il2CppSystem.Span<ContactPoint2D>)(&span)).Length);
			rigidbodyContactsArray_Injected = GetRigidbodyContactsArray_Injected(intPtr, ref contactFilter, ref results2);
		}
		return rigidbodyContactsArray_Injected;
	}

	public static int GetColliderContactsCollidersOnlyArray(Collider2D collider, ContactFilter2D contactFilter, Il2CppReferenceArray<Collider2D> results)
	{
		if ((object)collider == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(collider, "collider");
		}
		if (results == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object)(object)results, "results");
		}
		System.IntPtr intPtr = Object.MarshalledUnityObject.MarshalNotNull(collider);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(collider, "collider");
		}
		return GetColliderContactsCollidersOnlyArray_Injected(intPtr, ref contactFilter, results);
	}

	public static int GetRigidbodyContactsCollidersOnlyArray(Rigidbody2D rigidbody, ContactFilter2D contactFilter, Il2CppReferenceArray<Collider2D> results)
	{
		if ((object)rigidbody == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(rigidbody, "rigidbody");
		}
		if (results == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object)(object)results, "results");
		}
		System.IntPtr intPtr = Object.MarshalledUnityObject.MarshalNotNull(rigidbody);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(rigidbody, "rigidbody");
		}
		return GetRigidbodyContactsCollidersOnlyArray_Injected(intPtr, ref contactFilter, results);
	}

	public static int GetContacts(Collider2D collider1, Collider2D collider2, ContactFilter2D contactFilter, List<ContactPoint2D> contacts)
	{
		return GetColliderColliderContactsList(collider1, collider2, contactFilter, contacts);
	}

	public static int GetContacts(Collider2D collider, List<ContactPoint2D> contacts)
	{
		return GetColliderContactsList(collider, default(ContactFilter2D).NoFilter(), contacts);
	}

	public static int GetContacts(Collider2D collider, ContactFilter2D contactFilter, List<ContactPoint2D> contacts)
	{
		return GetColliderContactsList(collider, contactFilter, contacts);
	}

	public static int GetContacts(Collider2D collider, List<Collider2D> colliders)
	{
		return GetColliderContactsCollidersOnlyList(collider, default(ContactFilter2D).NoFilter(), colliders);
	}

	public static int GetContacts(Collider2D collider, ContactFilter2D contactFilter, List<Collider2D> colliders)
	{
		return GetColliderContactsCollidersOnlyList(collider, contactFilter, colliders);
	}

	public static int GetContacts(Rigidbody2D rigidbody, List<ContactPoint2D> contacts)
	{
		return GetRigidbodyContactsList(rigidbody, default(ContactFilter2D).NoFilter(), contacts);
	}

	public static int GetContacts(Rigidbody2D rigidbody, ContactFilter2D contactFilter, List<ContactPoint2D> contacts)
	{
		return GetRigidbodyContactsList(rigidbody, contactFilter, contacts);
	}

	public static int GetContacts(Rigidbody2D rigidbody, List<Collider2D> colliders)
	{
		return GetRigidbodyContactsCollidersOnlyList(rigidbody, default(ContactFilter2D).NoFilter(), colliders);
	}

	public static int GetContacts(Rigidbody2D rigidbody, ContactFilter2D contactFilter, List<Collider2D> colliders)
	{
		return GetRigidbodyContactsCollidersOnlyList(rigidbody, contactFilter, colliders);
	}

	public static int GetColliderContactsList(Collider2D collider, ContactFilter2D contactFilter, List<ContactPoint2D> results)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public static int GetColliderColliderContactsList(Collider2D collider1, Collider2D collider2, ContactFilter2D contactFilter, List<ContactPoint2D> results)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public static int GetRigidbodyContactsList(Rigidbody2D rigidbody, ContactFilter2D contactFilter, List<ContactPoint2D> results)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public static int GetColliderContactsCollidersOnlyList(Collider2D collider, ContactFilter2D contactFilter, List<Collider2D> results)
	{
		if ((object)collider == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(collider, "collider");
		}
		if (results == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(results, "results");
		}
		System.IntPtr intPtr = Object.MarshalledUnityObject.MarshalNotNull(collider);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(collider, "collider");
		}
		return GetColliderContactsCollidersOnlyList_Injected(intPtr, ref contactFilter, results);
	}

	public static int GetRigidbodyContactsCollidersOnlyList(Rigidbody2D rigidbody, ContactFilter2D contactFilter, List<Collider2D> results)
	{
		if ((object)rigidbody == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(rigidbody, "rigidbody");
		}
		if (results == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(results, "results");
		}
		System.IntPtr intPtr = Object.MarshalledUnityObject.MarshalNotNull(rigidbody);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(rigidbody, "rigidbody");
		}
		return GetRigidbodyContactsCollidersOnlyList_Injected(intPtr, ref contactFilter, results);
	}

	public static void SetEditorDragMovement(bool dragging, Il2CppReferenceArray<GameObject> objs)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public static int LinecastNonAlloc(Vector2 start, Vector2 end, Il2CppStructArray<RaycastHit2D> results)
	{
		return defaultPhysicsScene.Linecast(start, end, results, -5);
	}

	public static int LinecastNonAlloc(Vector2 start, Vector2 end, Il2CppStructArray<RaycastHit2D> results, int layerMask)
	{
		ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
		return defaultPhysicsScene.Linecast(start, end, contactFilter, results);
	}

	public static int LinecastNonAlloc(Vector2 start, Vector2 end, Il2CppStructArray<RaycastHit2D> results, int layerMask, float minDepth)
	{
		ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, float.PositiveInfinity);
		return defaultPhysicsScene.Linecast(start, end, contactFilter, results);
	}

	public static int LinecastNonAlloc(Vector2 start, Vector2 end, Il2CppStructArray<RaycastHit2D> results, int layerMask, float minDepth, float maxDepth)
	{
		ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, maxDepth);
		return defaultPhysicsScene.Linecast(start, end, contactFilter, results);
	}

	public static int RaycastNonAlloc(Vector2 origin, Vector2 direction, Il2CppStructArray<RaycastHit2D> results)
	{
		return defaultPhysicsScene.Raycast(origin, direction, float.PositiveInfinity, results, -5);
	}

	public static int RaycastNonAlloc(Vector2 origin, Vector2 direction, Il2CppStructArray<RaycastHit2D> results, float distance)
	{
		return defaultPhysicsScene.Raycast(origin, direction, distance, results, -5);
	}

	public static int RaycastNonAlloc(Vector2 origin, Vector2 direction, Il2CppStructArray<RaycastHit2D> results, float distance, int layerMask, float minDepth)
	{
		ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, float.PositiveInfinity);
		return defaultPhysicsScene.Raycast(origin, direction, distance, contactFilter, results);
	}

	public static int RaycastNonAlloc(Vector2 origin, Vector2 direction, Il2CppStructArray<RaycastHit2D> results, float distance, int layerMask, float minDepth, float maxDepth)
	{
		ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, maxDepth);
		return defaultPhysicsScene.Raycast(origin, direction, distance, contactFilter, results);
	}

	public static int CircleCastNonAlloc(Vector2 origin, float radius, Vector2 direction, Il2CppStructArray<RaycastHit2D> results)
	{
		return defaultPhysicsScene.CircleCast(origin, radius, direction, float.PositiveInfinity, results, -5);
	}

	public static int CircleCastNonAlloc(Vector2 origin, float radius, Vector2 direction, Il2CppStructArray<RaycastHit2D> results, float distance)
	{
		return defaultPhysicsScene.CircleCast(origin, radius, direction, distance, results, -5);
	}

	public static int CircleCastNonAlloc(Vector2 origin, float radius, Vector2 direction, Il2CppStructArray<RaycastHit2D> results, float distance, int layerMask)
	{
		ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
		return defaultPhysicsScene.CircleCast(origin, radius, direction, distance, contactFilter, results);
	}

	public static int CircleCastNonAlloc(Vector2 origin, float radius, Vector2 direction, Il2CppStructArray<RaycastHit2D> results, float distance, int layerMask, float minDepth)
	{
		ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, float.PositiveInfinity);
		return defaultPhysicsScene.CircleCast(origin, radius, direction, distance, contactFilter, results);
	}

	public static int CircleCastNonAlloc(Vector2 origin, float radius, Vector2 direction, Il2CppStructArray<RaycastHit2D> results, float distance, int layerMask, float minDepth, float maxDepth)
	{
		ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, maxDepth);
		return defaultPhysicsScene.CircleCast(origin, radius, direction, distance, contactFilter, results);
	}

	public static int BoxCastNonAlloc(Vector2 origin, Vector2 size, float angle, Vector2 direction, Il2CppStructArray<RaycastHit2D> results)
	{
		return defaultPhysicsScene.BoxCast(origin, size, angle, direction, float.PositiveInfinity, results, -5);
	}

	public static int BoxCastNonAlloc(Vector2 origin, Vector2 size, float angle, Vector2 direction, Il2CppStructArray<RaycastHit2D> results, float distance)
	{
		return defaultPhysicsScene.BoxCast(origin, size, angle, direction, distance, results, -5);
	}

	public static int BoxCastNonAlloc(Vector2 origin, Vector2 size, float angle, Vector2 direction, Il2CppStructArray<RaycastHit2D> results, float distance, int layerMask)
	{
		ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
		return defaultPhysicsScene.BoxCast(origin, size, angle, direction, distance, contactFilter, results);
	}

	public static int BoxCastNonAlloc(Vector2 origin, Vector2 size, float angle, Vector2 direction, Il2CppStructArray<RaycastHit2D> results, float distance, int layerMask, float minDepth)
	{
		ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, float.PositiveInfinity);
		return defaultPhysicsScene.BoxCast(origin, size, angle, direction, distance, contactFilter, results);
	}

	public static int BoxCastNonAlloc(Vector2 origin, Vector2 size, float angle, Vector2 direction, Il2CppStructArray<RaycastHit2D> results, float distance, int layerMask, float minDepth, float maxDepth)
	{
		ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, maxDepth);
		return defaultPhysicsScene.BoxCast(origin, size, angle, direction, distance, contactFilter, results);
	}

	public static int CapsuleCastNonAlloc(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction, Il2CppStructArray<RaycastHit2D> results)
	{
		return defaultPhysicsScene.CapsuleCast(origin, size, capsuleDirection, angle, direction, float.PositiveInfinity, results, -5);
	}

	public static int CapsuleCastNonAlloc(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction, Il2CppStructArray<RaycastHit2D> results, float distance)
	{
		return defaultPhysicsScene.CapsuleCast(origin, size, capsuleDirection, angle, direction, distance, results, -5);
	}

	public static int CapsuleCastNonAlloc(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction, Il2CppStructArray<RaycastHit2D> results, float distance, int layerMask)
	{
		ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
		return defaultPhysicsScene.CapsuleCast(origin, size, capsuleDirection, angle, direction, distance, contactFilter, results);
	}

	public static int CapsuleCastNonAlloc(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction, Il2CppStructArray<RaycastHit2D> results, float distance, int layerMask, float minDepth)
	{
		ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, float.PositiveInfinity);
		return defaultPhysicsScene.CapsuleCast(origin, size, capsuleDirection, angle, direction, distance, contactFilter, results);
	}

	public static int CapsuleCastNonAlloc(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction, Il2CppStructArray<RaycastHit2D> results, float distance, int layerMask, float minDepth, float maxDepth)
	{
		ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, maxDepth);
		return defaultPhysicsScene.CapsuleCast(origin, size, capsuleDirection, angle, direction, distance, contactFilter, results);
	}

	public static int OverlapPointNonAlloc(Vector2 point, Il2CppReferenceArray<Collider2D> results)
	{
		return defaultPhysicsScene.OverlapPoint(point, results, -5);
	}

	public static int OverlapPointNonAlloc(Vector2 point, Il2CppReferenceArray<Collider2D> results, int layerMask)
	{
		ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
		return defaultPhysicsScene.OverlapPoint(point, contactFilter, results);
	}

	public static int OverlapPointNonAlloc(Vector2 point, Il2CppReferenceArray<Collider2D> results, int layerMask, float minDepth)
	{
		ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, float.PositiveInfinity);
		return defaultPhysicsScene.OverlapPoint(point, contactFilter, results);
	}

	public static int OverlapPointNonAlloc(Vector2 point, Il2CppReferenceArray<Collider2D> results, int layerMask, float minDepth, float maxDepth)
	{
		ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, maxDepth);
		return defaultPhysicsScene.OverlapPoint(point, contactFilter, results);
	}

	public static int OverlapCircleNonAlloc(Vector2 point, float radius, Il2CppReferenceArray<Collider2D> results)
	{
		return defaultPhysicsScene.OverlapCircle(point, radius, results, -5);
	}

	public static int OverlapCircleNonAlloc(Vector2 point, float radius, Il2CppReferenceArray<Collider2D> results, int layerMask)
	{
		ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
		return defaultPhysicsScene.OverlapCircle(point, radius, contactFilter, results);
	}

	public static int OverlapCircleNonAlloc(Vector2 point, float radius, Il2CppReferenceArray<Collider2D> results, int layerMask, float minDepth)
	{
		ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, float.PositiveInfinity);
		return defaultPhysicsScene.OverlapCircle(point, radius, contactFilter, results);
	}

	public static int OverlapCircleNonAlloc(Vector2 point, float radius, Il2CppReferenceArray<Collider2D> results, int layerMask, float minDepth, float maxDepth)
	{
		ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, maxDepth);
		return defaultPhysicsScene.OverlapCircle(point, radius, contactFilter, results);
	}

	public static int OverlapBoxNonAlloc(Vector2 point, Vector2 size, float angle, Il2CppReferenceArray<Collider2D> results)
	{
		return defaultPhysicsScene.OverlapBox(point, size, angle, results, -5);
	}

	public static int OverlapBoxNonAlloc(Vector2 point, Vector2 size, float angle, Il2CppReferenceArray<Collider2D> results, int layerMask)
	{
		ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
		return defaultPhysicsScene.OverlapBox(point, size, angle, contactFilter, results);
	}

	public static int OverlapBoxNonAlloc(Vector2 point, Vector2 size, float angle, Il2CppReferenceArray<Collider2D> results, int layerMask, float minDepth)
	{
		ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, float.PositiveInfinity);
		return defaultPhysicsScene.OverlapBox(point, size, angle, contactFilter, results);
	}

	public static int OverlapBoxNonAlloc(Vector2 point, Vector2 size, float angle, Il2CppReferenceArray<Collider2D> results, int layerMask, float minDepth, float maxDepth)
	{
		ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, maxDepth);
		return defaultPhysicsScene.OverlapBox(point, size, angle, contactFilter, results);
	}

	public static int OverlapAreaNonAlloc(Vector2 pointA, Vector2 pointB, Il2CppReferenceArray<Collider2D> results)
	{
		return defaultPhysicsScene.OverlapArea(pointA, pointB, results, -5);
	}

	public static int OverlapAreaNonAlloc(Vector2 pointA, Vector2 pointB, Il2CppReferenceArray<Collider2D> results, int layerMask)
	{
		ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
		return defaultPhysicsScene.OverlapArea(pointA, pointB, contactFilter, results);
	}

	public static int OverlapAreaNonAlloc(Vector2 pointA, Vector2 pointB, Il2CppReferenceArray<Collider2D> results, int layerMask, float minDepth)
	{
		ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, float.PositiveInfinity);
		return defaultPhysicsScene.OverlapArea(pointA, pointB, contactFilter, results);
	}

	public static int OverlapAreaNonAlloc(Vector2 pointA, Vector2 pointB, Il2CppReferenceArray<Collider2D> results, int layerMask, float minDepth, float maxDepth)
	{
		ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, maxDepth);
		return defaultPhysicsScene.OverlapArea(pointA, pointB, contactFilter, results);
	}

	public static int OverlapCapsuleNonAlloc(Vector2 point, Vector2 size, CapsuleDirection2D direction, float angle, Il2CppReferenceArray<Collider2D> results)
	{
		return defaultPhysicsScene.OverlapCapsule(point, size, direction, angle, results, -5);
	}

	public static int OverlapCapsuleNonAlloc(Vector2 point, Vector2 size, CapsuleDirection2D direction, float angle, Il2CppReferenceArray<Collider2D> results, int layerMask)
	{
		ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
		return defaultPhysicsScene.OverlapCapsule(point, size, direction, angle, contactFilter, results);
	}

	public static int OverlapCapsuleNonAlloc(Vector2 point, Vector2 size, CapsuleDirection2D direction, float angle, Il2CppReferenceArray<Collider2D> results, int layerMask, float minDepth)
	{
		ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, float.PositiveInfinity);
		return defaultPhysicsScene.OverlapCapsule(point, size, direction, angle, contactFilter, results);
	}

	public static int OverlapCapsuleNonAlloc(Vector2 point, Vector2 size, CapsuleDirection2D direction, float angle, Il2CppReferenceArray<Collider2D> results, int layerMask, float minDepth, float maxDepth)
	{
		ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, maxDepth);
		return defaultPhysicsScene.OverlapCapsule(point, size, direction, angle, contactFilter, results);
	}

	public unsafe static void set_gravity_Injected([In] ref Vector2 value)
	{
		set_gravity_InjectedDelegateField((nint)Unsafe.AsPointer(ref value));
	}

	public unsafe static void get_simulationLayers_Injected(out LayerMask ret)
	{
		get_simulationLayers_InjectedDelegateField((nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void set_simulationLayers_Injected([In] ref LayerMask value)
	{
		set_simulationLayers_InjectedDelegateField((nint)Unsafe.AsPointer(ref value));
	}

	public unsafe static bool Simulate_Internal_Injected([In] ref PhysicsScene2D physicsScene, float deltaTime, int simulationLayers)
	{
		return Simulate_Internal_InjectedDelegateField((nint)Unsafe.AsPointer(ref physicsScene), deltaTime, simulationLayers);
	}

	public static void IgnoreCollision_Injected(System.IntPtr collider1, System.IntPtr collider2, bool ignore)
	{
		IgnoreCollision_InjectedDelegateField(collider1, collider2, ignore);
	}

	public static bool GetIgnoreCollision_Injected(System.IntPtr collider1, System.IntPtr collider2)
	{
		return GetIgnoreCollision_InjectedDelegateField(collider1, collider2);
	}

	public static bool IsTouching_Injected(System.IntPtr collider1, System.IntPtr collider2)
	{
		return IsTouching_InjectedDelegateField(collider1, collider2);
	}

	public unsafe static bool IsTouching_TwoCollidersWithFilter_Injected(System.IntPtr collider1, System.IntPtr collider2, [In] ref ContactFilter2D contactFilter)
	{
		return IsTouching_TwoCollidersWithFilter_InjectedDelegateField(collider1, collider2, (nint)Unsafe.AsPointer(ref contactFilter));
	}

	public unsafe static bool IsTouching_SingleColliderWithFilter_Injected(System.IntPtr collider, [In] ref ContactFilter2D contactFilter)
	{
		return IsTouching_SingleColliderWithFilter_InjectedDelegateField(collider, (nint)Unsafe.AsPointer(ref contactFilter));
	}

	public static bool IsTouchingLayers_Injected(System.IntPtr collider, int layerMask)
	{
		return IsTouchingLayers_InjectedDelegateField(collider, layerMask);
	}

	public unsafe static void ClosestPoint_Collider_Injected([In] ref Vector2 position, System.IntPtr collider, out Vector2 ret)
	{
		ClosestPoint_Collider_InjectedDelegateField((nint)Unsafe.AsPointer(ref position), collider, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void ClosestPoint_Rigidbody_Injected([In] ref Vector2 position, System.IntPtr rigidbody, out Vector2 ret)
	{
		ClosestPoint_Rigidbody_InjectedDelegateField((nint)Unsafe.AsPointer(ref position), rigidbody, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void LinecastAll_Internal_Injected([In] ref PhysicsScene2D physicsScene, [In] ref Vector2 start, [In] ref Vector2 end, [In] ref ContactFilter2D contactFilter, out BlittableArrayWrapper ret)
	{
		LinecastAll_Internal_InjectedDelegateField((nint)Unsafe.AsPointer(ref physicsScene), (nint)Unsafe.AsPointer(ref start), (nint)Unsafe.AsPointer(ref end), (nint)Unsafe.AsPointer(ref contactFilter), (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void RaycastAll_Internal_Injected([In] ref PhysicsScene2D physicsScene, [In] ref Vector2 origin, [In] ref Vector2 direction, float distance, [In] ref ContactFilter2D contactFilter, out BlittableArrayWrapper ret)
	{
		RaycastAll_Internal_InjectedDelegateField((nint)Unsafe.AsPointer(ref physicsScene), (nint)Unsafe.AsPointer(ref origin), (nint)Unsafe.AsPointer(ref direction), distance, (nint)Unsafe.AsPointer(ref contactFilter), (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void CircleCastAll_Internal_Injected([In] ref PhysicsScene2D physicsScene, [In] ref Vector2 origin, float radius, [In] ref Vector2 direction, float distance, [In] ref ContactFilter2D contactFilter, out BlittableArrayWrapper ret)
	{
		CircleCastAll_Internal_InjectedDelegateField((nint)Unsafe.AsPointer(ref physicsScene), (nint)Unsafe.AsPointer(ref origin), radius, (nint)Unsafe.AsPointer(ref direction), distance, (nint)Unsafe.AsPointer(ref contactFilter), (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void BoxCastAll_Internal_Injected([In] ref PhysicsScene2D physicsScene, [In] ref Vector2 origin, [In] ref Vector2 size, float angle, [In] ref Vector2 direction, float distance, [In] ref ContactFilter2D contactFilter, out BlittableArrayWrapper ret)
	{
		BoxCastAll_Internal_InjectedDelegateField((nint)Unsafe.AsPointer(ref physicsScene), (nint)Unsafe.AsPointer(ref origin), (nint)Unsafe.AsPointer(ref size), angle, (nint)Unsafe.AsPointer(ref direction), distance, (nint)Unsafe.AsPointer(ref contactFilter), (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void CapsuleCastAll_Internal_Injected([In] ref PhysicsScene2D physicsScene, [In] ref Vector2 origin, [In] ref Vector2 size, CapsuleDirection2D capsuleDirection, float angle, [In] ref Vector2 direction, float distance, [In] ref ContactFilter2D contactFilter, out BlittableArrayWrapper ret)
	{
		CapsuleCastAll_Internal_InjectedDelegateField((nint)Unsafe.AsPointer(ref physicsScene), (nint)Unsafe.AsPointer(ref origin), (nint)Unsafe.AsPointer(ref size), capsuleDirection, angle, (nint)Unsafe.AsPointer(ref direction), distance, (nint)Unsafe.AsPointer(ref contactFilter), (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static Il2CppReferenceArray<Collider2D> OverlapPointAll_Internal_Injected([In] ref PhysicsScene2D physicsScene, [In] ref Vector2 point, [In] ref ContactFilter2D contactFilter)
	{
		System.IntPtr intPtr = OverlapPointAll_Internal_InjectedDelegateField((nint)Unsafe.AsPointer(ref physicsScene), (nint)Unsafe.AsPointer(ref point), (nint)Unsafe.AsPointer(ref contactFilter));
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Collider2D>>(intPtr) : null;
	}

	public unsafe static Il2CppReferenceArray<Collider2D> OverlapCircleAll_Internal_Injected([In] ref PhysicsScene2D physicsScene, [In] ref Vector2 point, float radius, [In] ref ContactFilter2D contactFilter)
	{
		System.IntPtr intPtr = OverlapCircleAll_Internal_InjectedDelegateField((nint)Unsafe.AsPointer(ref physicsScene), (nint)Unsafe.AsPointer(ref point), radius, (nint)Unsafe.AsPointer(ref contactFilter));
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Collider2D>>(intPtr) : null;
	}

	public unsafe static Il2CppReferenceArray<Collider2D> OverlapBoxAll_Internal_Injected([In] ref PhysicsScene2D physicsScene, [In] ref Vector2 point, [In] ref Vector2 size, float angle, [In] ref ContactFilter2D contactFilter)
	{
		System.IntPtr intPtr = OverlapBoxAll_Internal_InjectedDelegateField((nint)Unsafe.AsPointer(ref physicsScene), (nint)Unsafe.AsPointer(ref point), (nint)Unsafe.AsPointer(ref size), angle, (nint)Unsafe.AsPointer(ref contactFilter));
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Collider2D>>(intPtr) : null;
	}

	public unsafe static Il2CppReferenceArray<Collider2D> OverlapCapsuleAll_Internal_Injected([In] ref PhysicsScene2D physicsScene, [In] ref Vector2 point, [In] ref Vector2 size, CapsuleDirection2D direction, float angle, [In] ref ContactFilter2D contactFilter)
	{
		System.IntPtr intPtr = OverlapCapsuleAll_Internal_InjectedDelegateField((nint)Unsafe.AsPointer(ref physicsScene), (nint)Unsafe.AsPointer(ref point), (nint)Unsafe.AsPointer(ref size), direction, angle, (nint)Unsafe.AsPointer(ref contactFilter));
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Collider2D>>(intPtr) : null;
	}

	public unsafe static int GetColliderContactsArray_Injected(System.IntPtr collider, [In] ref ContactFilter2D contactFilter, ref ManagedSpanWrapper results)
	{
		return GetColliderContactsArray_InjectedDelegateField(collider, (nint)Unsafe.AsPointer(ref contactFilter), (nint)Unsafe.AsPointer(ref results));
	}

	public unsafe static int GetColliderColliderContactsArray_Injected(System.IntPtr collider1, System.IntPtr collider2, [In] ref ContactFilter2D contactFilter, ref ManagedSpanWrapper results)
	{
		return GetColliderColliderContactsArray_InjectedDelegateField(collider1, collider2, (nint)Unsafe.AsPointer(ref contactFilter), (nint)Unsafe.AsPointer(ref results));
	}

	public unsafe static int GetRigidbodyContactsArray_Injected(System.IntPtr rigidbody, [In] ref ContactFilter2D contactFilter, ref ManagedSpanWrapper results)
	{
		return GetRigidbodyContactsArray_InjectedDelegateField(rigidbody, (nint)Unsafe.AsPointer(ref contactFilter), (nint)Unsafe.AsPointer(ref results));
	}

	public unsafe static int GetColliderContactsCollidersOnlyArray_Injected(System.IntPtr collider, [In] ref ContactFilter2D contactFilter, Il2CppReferenceArray<Collider2D> results)
	{
		return GetColliderContactsCollidersOnlyArray_InjectedDelegateField(collider, (nint)Unsafe.AsPointer(ref contactFilter), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)results));
	}

	public unsafe static int GetRigidbodyContactsCollidersOnlyArray_Injected(System.IntPtr rigidbody, [In] ref ContactFilter2D contactFilter, Il2CppReferenceArray<Collider2D> results)
	{
		return GetRigidbodyContactsCollidersOnlyArray_InjectedDelegateField(rigidbody, (nint)Unsafe.AsPointer(ref contactFilter), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)results));
	}

	public unsafe static int GetColliderContactsList_Injected(System.IntPtr collider, [In] ref ContactFilter2D contactFilter, ref BlittableListWrapper results)
	{
		return GetColliderContactsList_InjectedDelegateField(collider, (nint)Unsafe.AsPointer(ref contactFilter), (nint)Unsafe.AsPointer(ref results));
	}

	public unsafe static int GetColliderColliderContactsList_Injected(System.IntPtr collider1, System.IntPtr collider2, [In] ref ContactFilter2D contactFilter, ref BlittableListWrapper results)
	{
		return GetColliderColliderContactsList_InjectedDelegateField(collider1, collider2, (nint)Unsafe.AsPointer(ref contactFilter), (nint)Unsafe.AsPointer(ref results));
	}

	public unsafe static int GetRigidbodyContactsList_Injected(System.IntPtr rigidbody, [In] ref ContactFilter2D contactFilter, ref BlittableListWrapper results)
	{
		return GetRigidbodyContactsList_InjectedDelegateField(rigidbody, (nint)Unsafe.AsPointer(ref contactFilter), (nint)Unsafe.AsPointer(ref results));
	}

	public unsafe static int GetColliderContactsCollidersOnlyList_Injected(System.IntPtr collider, [In] ref ContactFilter2D contactFilter, List<Collider2D> results)
	{
		return GetColliderContactsCollidersOnlyList_InjectedDelegateField(collider, (nint)Unsafe.AsPointer(ref contactFilter), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)results));
	}

	public unsafe static int GetRigidbodyContactsCollidersOnlyList_Injected(System.IntPtr rigidbody, [In] ref ContactFilter2D contactFilter, List<Collider2D> results)
	{
		return GetRigidbodyContactsCollidersOnlyList_InjectedDelegateField(rigidbody, (nint)Unsafe.AsPointer(ref contactFilter), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)results));
	}
}
