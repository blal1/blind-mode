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

[StructLayout(LayoutKind.Explicit)]
public struct PhysicsScene2D
{
	private delegate bool IsValid_Internal_InjectedDelegate([In] System.IntPtr physicsScene);

	private delegate bool IsEmpty_Internal_InjectedDelegate([In] System.IntPtr physicsScene);

	private delegate int SubStepCount_Internal_InjectedDelegate([In] System.IntPtr physicsScene);

	private delegate float SubStepLostTime_Internal_InjectedDelegate([In] System.IntPtr physicsScene);

	private delegate void Linecast_Internal_InjectedDelegate([In] System.IntPtr physicsScene, [In] System.IntPtr start, [In] System.IntPtr end, [In] System.IntPtr contactFilter, [Out] System.IntPtr ret);

	private delegate int LinecastArray_Internal_InjectedDelegate([In] System.IntPtr physicsScene, [In] System.IntPtr start, [In] System.IntPtr end, [In] System.IntPtr contactFilter, System.IntPtr results);

	private delegate int LinecastList_Internal_InjectedDelegate([In] System.IntPtr physicsScene, [In] System.IntPtr start, [In] System.IntPtr end, [In] System.IntPtr contactFilter, System.IntPtr results);

	private delegate void CircleCast_Internal_InjectedDelegate([In] System.IntPtr physicsScene, [In] System.IntPtr origin, float radius, [In] System.IntPtr direction, float distance, [In] System.IntPtr contactFilter, [Out] System.IntPtr ret);

	private delegate int CircleCastArray_Internal_InjectedDelegate([In] System.IntPtr physicsScene, [In] System.IntPtr origin, float radius, [In] System.IntPtr direction, float distance, [In] System.IntPtr contactFilter, System.IntPtr results);

	private delegate int CircleCastList_Internal_InjectedDelegate([In] System.IntPtr physicsScene, [In] System.IntPtr origin, float radius, [In] System.IntPtr direction, float distance, [In] System.IntPtr contactFilter, System.IntPtr results);

	private delegate void BoxCast_Internal_InjectedDelegate([In] System.IntPtr physicsScene, [In] System.IntPtr origin, [In] System.IntPtr size, float angle, [In] System.IntPtr direction, float distance, [In] System.IntPtr contactFilter, [Out] System.IntPtr ret);

	private delegate int BoxCastArray_Internal_InjectedDelegate([In] System.IntPtr physicsScene, [In] System.IntPtr origin, [In] System.IntPtr size, float angle, [In] System.IntPtr direction, float distance, [In] System.IntPtr contactFilter, System.IntPtr results);

	private delegate int BoxCastList_Internal_InjectedDelegate([In] System.IntPtr physicsScene, [In] System.IntPtr origin, [In] System.IntPtr size, float angle, [In] System.IntPtr direction, float distance, [In] System.IntPtr contactFilter, System.IntPtr results);

	private delegate void CapsuleCast_Internal_InjectedDelegate([In] System.IntPtr physicsScene, [In] System.IntPtr origin, [In] System.IntPtr size, CapsuleDirection2D capsuleDirection, float angle, [In] System.IntPtr direction, float distance, [In] System.IntPtr contactFilter, [Out] System.IntPtr ret);

	private delegate int CapsuleCastArray_Internal_InjectedDelegate([In] System.IntPtr physicsScene, [In] System.IntPtr origin, [In] System.IntPtr size, CapsuleDirection2D capsuleDirection, float angle, [In] System.IntPtr direction, float distance, [In] System.IntPtr contactFilter, System.IntPtr results);

	private delegate int CapsuleCastList_Internal_InjectedDelegate([In] System.IntPtr physicsScene, [In] System.IntPtr origin, [In] System.IntPtr size, CapsuleDirection2D capsuleDirection, float angle, [In] System.IntPtr direction, float distance, [In] System.IntPtr contactFilter, System.IntPtr results);

	private delegate int GetRayIntersectionList_Internal_InjectedDelegate([In] System.IntPtr physicsScene, [In] System.IntPtr origin, [In] System.IntPtr direction, float distance, int layerMask, System.IntPtr results);

	private delegate System.IntPtr OverlapPoint_Internal_InjectedDelegate([In] System.IntPtr physicsScene, [In] System.IntPtr point, [In] System.IntPtr contactFilter);

	private delegate int OverlapPointArray_Internal_InjectedDelegate([In] System.IntPtr physicsScene, [In] System.IntPtr point, [In] System.IntPtr contactFilter, System.IntPtr results);

	private delegate int OverlapPointList_Internal_InjectedDelegate([In] System.IntPtr physicsScene, [In] System.IntPtr point, [In] System.IntPtr contactFilter, System.IntPtr results);

	private delegate System.IntPtr OverlapCircle_Internal_InjectedDelegate([In] System.IntPtr physicsScene, [In] System.IntPtr point, float radius, [In] System.IntPtr contactFilter);

	private delegate int OverlapCircleArray_Internal_InjectedDelegate([In] System.IntPtr physicsScene, [In] System.IntPtr point, float radius, [In] System.IntPtr contactFilter, System.IntPtr results);

	private delegate int OverlapCircleList_Internal_InjectedDelegate([In] System.IntPtr physicsScene, [In] System.IntPtr point, float radius, [In] System.IntPtr contactFilter, System.IntPtr results);

	private delegate System.IntPtr OverlapBox_Internal_InjectedDelegate([In] System.IntPtr physicsScene, [In] System.IntPtr point, [In] System.IntPtr size, float angle, [In] System.IntPtr contactFilter);

	private delegate int OverlapBoxArray_Internal_InjectedDelegate([In] System.IntPtr physicsScene, [In] System.IntPtr point, [In] System.IntPtr size, float angle, [In] System.IntPtr contactFilter, System.IntPtr results);

	private delegate int OverlapBoxList_Internal_InjectedDelegate([In] System.IntPtr physicsScene, [In] System.IntPtr point, [In] System.IntPtr size, float angle, [In] System.IntPtr contactFilter, System.IntPtr results);

	private delegate System.IntPtr OverlapCapsule_Internal_InjectedDelegate([In] System.IntPtr physicsScene, [In] System.IntPtr point, [In] System.IntPtr size, CapsuleDirection2D direction, float angle, [In] System.IntPtr contactFilter);

	private delegate int OverlapCapsuleArray_Internal_InjectedDelegate([In] System.IntPtr physicsScene, [In] System.IntPtr point, [In] System.IntPtr size, CapsuleDirection2D direction, float angle, [In] System.IntPtr contactFilter, System.IntPtr results);

	private delegate int OverlapCapsuleList_Internal_InjectedDelegate([In] System.IntPtr physicsScene, [In] System.IntPtr point, [In] System.IntPtr size, CapsuleDirection2D direction, float angle, [In] System.IntPtr contactFilter, System.IntPtr results);

	private delegate int OverlapColliderFilteredArray_Internal_InjectedDelegate(System.IntPtr collider, [In] System.IntPtr contactFilter, System.IntPtr results);

	private delegate int OverlapColliderList_Internal_InjectedDelegate(System.IntPtr collider, System.IntPtr results);

	private delegate int OverlapColliderFilteredList_Internal_InjectedDelegate(System.IntPtr collider, [In] System.IntPtr contactFilter, System.IntPtr results);

	private delegate int OverlapColliderFromList_Internal_InjectedDelegate([In] System.IntPtr position, float angle, System.IntPtr collider, System.IntPtr results);

	private delegate int OverlapColliderFromFilteredList_Internal_InjectedDelegate([In] System.IntPtr position, float angle, System.IntPtr collider, [In] System.IntPtr contactFilter, System.IntPtr results);

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Handle;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_PhysicsScene2D_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Raycast_Public_RaycastHit2D_Vector2_Vector2_Single_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Raycast_Public_RaycastHit2D_Vector2_Vector2_Single_ContactFilter2D_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Raycast_Public_Int32_Vector2_Vector2_Single_ContactFilter2D_Il2CppStructArray_1_RaycastHit2D_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Raycast_Public_Int32_Vector2_Vector2_Single_ContactFilter2D_List_1_RaycastHit2D_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Raycast_Internal_Private_Static_RaycastHit2D_PhysicsScene2D_Vector2_Vector2_Single_ContactFilter2D_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RaycastArray_Internal_Private_Static_Int32_PhysicsScene2D_Vector2_Vector2_Single_ContactFilter2D_Il2CppStructArray_1_RaycastHit2D_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RaycastList_Internal_Private_Static_Int32_PhysicsScene2D_Vector2_Vector2_Single_ContactFilter2D_List_1_RaycastHit2D_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRayIntersection_Public_RaycastHit2D_Ray_Single_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRayIntersection_Public_Int32_Ray_Single_Il2CppStructArray_1_RaycastHit2D_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRayIntersection_Internal_Private_Static_RaycastHit2D_PhysicsScene2D_Vector3_Vector3_Single_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRayIntersectionArray_Internal_Private_Static_Int32_PhysicsScene2D_Vector3_Vector3_Single_Int32_Il2CppStructArray_1_RaycastHit2D_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Raycast_Internal_Injected_Private_Static_Void_byref_PhysicsScene2D_byref_Vector2_byref_Vector2_Single_byref_ContactFilter2D_byref_RaycastHit2D_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RaycastArray_Internal_Injected_Private_Static_Int32_byref_PhysicsScene2D_byref_Vector2_byref_Vector2_Single_byref_ContactFilter2D_byref_ManagedSpanWrapper_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RaycastList_Internal_Injected_Private_Static_Int32_byref_PhysicsScene2D_byref_Vector2_byref_Vector2_Single_byref_ContactFilter2D_byref_BlittableListWrapper_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRayIntersection_Internal_Injected_Private_Static_Void_byref_PhysicsScene2D_byref_Vector3_byref_Vector3_Single_Int32_byref_RaycastHit2D_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRayIntersectionArray_Internal_Injected_Private_Static_Int32_byref_PhysicsScene2D_byref_Vector3_byref_Vector3_Single_Int32_byref_ManagedSpanWrapper_0;

	[FieldOffset(0)]
	public int m_Handle;

	private static readonly IsValid_Internal_InjectedDelegate IsValid_Internal_InjectedDelegateField;

	private static readonly IsEmpty_Internal_InjectedDelegate IsEmpty_Internal_InjectedDelegateField;

	private static readonly SubStepCount_Internal_InjectedDelegate SubStepCount_Internal_InjectedDelegateField;

	private static readonly SubStepLostTime_Internal_InjectedDelegate SubStepLostTime_Internal_InjectedDelegateField;

	private static readonly Linecast_Internal_InjectedDelegate Linecast_Internal_InjectedDelegateField;

	private static readonly LinecastArray_Internal_InjectedDelegate LinecastArray_Internal_InjectedDelegateField;

	private static readonly LinecastList_Internal_InjectedDelegate LinecastList_Internal_InjectedDelegateField;

	private static readonly CircleCast_Internal_InjectedDelegate CircleCast_Internal_InjectedDelegateField;

	private static readonly CircleCastArray_Internal_InjectedDelegate CircleCastArray_Internal_InjectedDelegateField;

	private static readonly CircleCastList_Internal_InjectedDelegate CircleCastList_Internal_InjectedDelegateField;

	private static readonly BoxCast_Internal_InjectedDelegate BoxCast_Internal_InjectedDelegateField;

	private static readonly BoxCastArray_Internal_InjectedDelegate BoxCastArray_Internal_InjectedDelegateField;

	private static readonly BoxCastList_Internal_InjectedDelegate BoxCastList_Internal_InjectedDelegateField;

	private static readonly CapsuleCast_Internal_InjectedDelegate CapsuleCast_Internal_InjectedDelegateField;

	private static readonly CapsuleCastArray_Internal_InjectedDelegate CapsuleCastArray_Internal_InjectedDelegateField;

	private static readonly CapsuleCastList_Internal_InjectedDelegate CapsuleCastList_Internal_InjectedDelegateField;

	private static readonly GetRayIntersectionList_Internal_InjectedDelegate GetRayIntersectionList_Internal_InjectedDelegateField;

	private static readonly OverlapPoint_Internal_InjectedDelegate OverlapPoint_Internal_InjectedDelegateField;

	private static readonly OverlapPointArray_Internal_InjectedDelegate OverlapPointArray_Internal_InjectedDelegateField;

	private static readonly OverlapPointList_Internal_InjectedDelegate OverlapPointList_Internal_InjectedDelegateField;

	private static readonly OverlapCircle_Internal_InjectedDelegate OverlapCircle_Internal_InjectedDelegateField;

	private static readonly OverlapCircleArray_Internal_InjectedDelegate OverlapCircleArray_Internal_InjectedDelegateField;

	private static readonly OverlapCircleList_Internal_InjectedDelegate OverlapCircleList_Internal_InjectedDelegateField;

	private static readonly OverlapBox_Internal_InjectedDelegate OverlapBox_Internal_InjectedDelegateField;

	private static readonly OverlapBoxArray_Internal_InjectedDelegate OverlapBoxArray_Internal_InjectedDelegateField;

	private static readonly OverlapBoxList_Internal_InjectedDelegate OverlapBoxList_Internal_InjectedDelegateField;

	private static readonly OverlapCapsule_Internal_InjectedDelegate OverlapCapsule_Internal_InjectedDelegateField;

	private static readonly OverlapCapsuleArray_Internal_InjectedDelegate OverlapCapsuleArray_Internal_InjectedDelegateField;

	private static readonly OverlapCapsuleList_Internal_InjectedDelegate OverlapCapsuleList_Internal_InjectedDelegateField;

	private static readonly OverlapColliderFilteredArray_Internal_InjectedDelegate OverlapColliderFilteredArray_Internal_InjectedDelegateField;

	private static readonly OverlapColliderList_Internal_InjectedDelegate OverlapColliderList_Internal_InjectedDelegateField;

	private static readonly OverlapColliderFilteredList_Internal_InjectedDelegate OverlapColliderFilteredList_Internal_InjectedDelegateField;

	private static readonly OverlapColliderFromList_Internal_InjectedDelegate OverlapColliderFromList_Internal_InjectedDelegateField;

	private static readonly OverlapColliderFromFilteredList_Internal_InjectedDelegate OverlapColliderFromFilteredList_Internal_InjectedDelegateField;

	public int subStepCount => SubStepCount_Internal(this);

	public float subStepLostTime => SubStepLostTime_Internal(this);

	static PhysicsScene2D()
	{
		Il2CppClassPointerStore<PhysicsScene2D>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Physics2DModule.dll", "UnityEngine", "PhysicsScene2D");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PhysicsScene2D>.NativeClassPtr);
		NativeFieldInfoPtr_m_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhysicsScene2D>.NativeClassPtr, "m_Handle");
		NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsScene2D>.NativeClassPtr, 100663297);
		NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsScene2D>.NativeClassPtr, 100663298);
		NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsScene2D>.NativeClassPtr, 100663299);
		NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_PhysicsScene2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsScene2D>.NativeClassPtr, 100663300);
		NativeMethodInfoPtr_Raycast_Public_RaycastHit2D_Vector2_Vector2_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsScene2D>.NativeClassPtr, 100663301);
		NativeMethodInfoPtr_Raycast_Public_RaycastHit2D_Vector2_Vector2_Single_ContactFilter2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsScene2D>.NativeClassPtr, 100663302);
		NativeMethodInfoPtr_Raycast_Public_Int32_Vector2_Vector2_Single_ContactFilter2D_Il2CppStructArray_1_RaycastHit2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsScene2D>.NativeClassPtr, 100663303);
		NativeMethodInfoPtr_Raycast_Public_Int32_Vector2_Vector2_Single_ContactFilter2D_List_1_RaycastHit2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsScene2D>.NativeClassPtr, 100663304);
		NativeMethodInfoPtr_Raycast_Internal_Private_Static_RaycastHit2D_PhysicsScene2D_Vector2_Vector2_Single_ContactFilter2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsScene2D>.NativeClassPtr, 100663305);
		NativeMethodInfoPtr_RaycastArray_Internal_Private_Static_Int32_PhysicsScene2D_Vector2_Vector2_Single_ContactFilter2D_Il2CppStructArray_1_RaycastHit2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsScene2D>.NativeClassPtr, 100663306);
		NativeMethodInfoPtr_RaycastList_Internal_Private_Static_Int32_PhysicsScene2D_Vector2_Vector2_Single_ContactFilter2D_List_1_RaycastHit2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsScene2D>.NativeClassPtr, 100663307);
		NativeMethodInfoPtr_GetRayIntersection_Public_RaycastHit2D_Ray_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsScene2D>.NativeClassPtr, 100663308);
		NativeMethodInfoPtr_GetRayIntersection_Public_Int32_Ray_Single_Il2CppStructArray_1_RaycastHit2D_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsScene2D>.NativeClassPtr, 100663309);
		NativeMethodInfoPtr_GetRayIntersection_Internal_Private_Static_RaycastHit2D_PhysicsScene2D_Vector3_Vector3_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsScene2D>.NativeClassPtr, 100663310);
		NativeMethodInfoPtr_GetRayIntersectionArray_Internal_Private_Static_Int32_PhysicsScene2D_Vector3_Vector3_Single_Int32_Il2CppStructArray_1_RaycastHit2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsScene2D>.NativeClassPtr, 100663311);
		NativeMethodInfoPtr_Raycast_Internal_Injected_Private_Static_Void_byref_PhysicsScene2D_byref_Vector2_byref_Vector2_Single_byref_ContactFilter2D_byref_RaycastHit2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsScene2D>.NativeClassPtr, 100663312);
		NativeMethodInfoPtr_RaycastArray_Internal_Injected_Private_Static_Int32_byref_PhysicsScene2D_byref_Vector2_byref_Vector2_Single_byref_ContactFilter2D_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsScene2D>.NativeClassPtr, 100663313);
		NativeMethodInfoPtr_RaycastList_Internal_Injected_Private_Static_Int32_byref_PhysicsScene2D_byref_Vector2_byref_Vector2_Single_byref_ContactFilter2D_byref_BlittableListWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsScene2D>.NativeClassPtr, 100663314);
		NativeMethodInfoPtr_GetRayIntersection_Internal_Injected_Private_Static_Void_byref_PhysicsScene2D_byref_Vector3_byref_Vector3_Single_Int32_byref_RaycastHit2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsScene2D>.NativeClassPtr, 100663315);
		NativeMethodInfoPtr_GetRayIntersectionArray_Internal_Injected_Private_Static_Int32_byref_PhysicsScene2D_byref_Vector3_byref_Vector3_Single_Int32_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsScene2D>.NativeClassPtr, 100663316);
		IsValid_Internal_InjectedDelegateField = IL2CPP.ResolveICall<IsValid_Internal_InjectedDelegate>("UnityEngine.PhysicsScene2D::IsValid_Internal_Injected");
		IsEmpty_Internal_InjectedDelegateField = IL2CPP.ResolveICall<IsEmpty_Internal_InjectedDelegate>("UnityEngine.PhysicsScene2D::IsEmpty_Internal_Injected");
		SubStepCount_Internal_InjectedDelegateField = IL2CPP.ResolveICall<SubStepCount_Internal_InjectedDelegate>("UnityEngine.PhysicsScene2D::SubStepCount_Internal_Injected");
		SubStepLostTime_Internal_InjectedDelegateField = IL2CPP.ResolveICall<SubStepLostTime_Internal_InjectedDelegate>("UnityEngine.PhysicsScene2D::SubStepLostTime_Internal_Injected");
		Linecast_Internal_InjectedDelegateField = IL2CPP.ResolveICall<Linecast_Internal_InjectedDelegate>("UnityEngine.PhysicsScene2D::Linecast_Internal_Injected");
		LinecastArray_Internal_InjectedDelegateField = IL2CPP.ResolveICall<LinecastArray_Internal_InjectedDelegate>("UnityEngine.PhysicsScene2D::LinecastArray_Internal_Injected");
		LinecastList_Internal_InjectedDelegateField = IL2CPP.ResolveICall<LinecastList_Internal_InjectedDelegate>("UnityEngine.PhysicsScene2D::LinecastList_Internal_Injected");
		CircleCast_Internal_InjectedDelegateField = IL2CPP.ResolveICall<CircleCast_Internal_InjectedDelegate>("UnityEngine.PhysicsScene2D::CircleCast_Internal_Injected");
		CircleCastArray_Internal_InjectedDelegateField = IL2CPP.ResolveICall<CircleCastArray_Internal_InjectedDelegate>("UnityEngine.PhysicsScene2D::CircleCastArray_Internal_Injected");
		CircleCastList_Internal_InjectedDelegateField = IL2CPP.ResolveICall<CircleCastList_Internal_InjectedDelegate>("UnityEngine.PhysicsScene2D::CircleCastList_Internal_Injected");
		BoxCast_Internal_InjectedDelegateField = IL2CPP.ResolveICall<BoxCast_Internal_InjectedDelegate>("UnityEngine.PhysicsScene2D::BoxCast_Internal_Injected");
		BoxCastArray_Internal_InjectedDelegateField = IL2CPP.ResolveICall<BoxCastArray_Internal_InjectedDelegate>("UnityEngine.PhysicsScene2D::BoxCastArray_Internal_Injected");
		BoxCastList_Internal_InjectedDelegateField = IL2CPP.ResolveICall<BoxCastList_Internal_InjectedDelegate>("UnityEngine.PhysicsScene2D::BoxCastList_Internal_Injected");
		CapsuleCast_Internal_InjectedDelegateField = IL2CPP.ResolveICall<CapsuleCast_Internal_InjectedDelegate>("UnityEngine.PhysicsScene2D::CapsuleCast_Internal_Injected");
		CapsuleCastArray_Internal_InjectedDelegateField = IL2CPP.ResolveICall<CapsuleCastArray_Internal_InjectedDelegate>("UnityEngine.PhysicsScene2D::CapsuleCastArray_Internal_Injected");
		CapsuleCastList_Internal_InjectedDelegateField = IL2CPP.ResolveICall<CapsuleCastList_Internal_InjectedDelegate>("UnityEngine.PhysicsScene2D::CapsuleCastList_Internal_Injected");
		GetRayIntersectionList_Internal_InjectedDelegateField = IL2CPP.ResolveICall<GetRayIntersectionList_Internal_InjectedDelegate>("UnityEngine.PhysicsScene2D::GetRayIntersectionList_Internal_Injected");
		OverlapPoint_Internal_InjectedDelegateField = IL2CPP.ResolveICall<OverlapPoint_Internal_InjectedDelegate>("UnityEngine.PhysicsScene2D::OverlapPoint_Internal_Injected");
		OverlapPointArray_Internal_InjectedDelegateField = IL2CPP.ResolveICall<OverlapPointArray_Internal_InjectedDelegate>("UnityEngine.PhysicsScene2D::OverlapPointArray_Internal_Injected");
		OverlapPointList_Internal_InjectedDelegateField = IL2CPP.ResolveICall<OverlapPointList_Internal_InjectedDelegate>("UnityEngine.PhysicsScene2D::OverlapPointList_Internal_Injected");
		OverlapCircle_Internal_InjectedDelegateField = IL2CPP.ResolveICall<OverlapCircle_Internal_InjectedDelegate>("UnityEngine.PhysicsScene2D::OverlapCircle_Internal_Injected");
		OverlapCircleArray_Internal_InjectedDelegateField = IL2CPP.ResolveICall<OverlapCircleArray_Internal_InjectedDelegate>("UnityEngine.PhysicsScene2D::OverlapCircleArray_Internal_Injected");
		OverlapCircleList_Internal_InjectedDelegateField = IL2CPP.ResolveICall<OverlapCircleList_Internal_InjectedDelegate>("UnityEngine.PhysicsScene2D::OverlapCircleList_Internal_Injected");
		OverlapBox_Internal_InjectedDelegateField = IL2CPP.ResolveICall<OverlapBox_Internal_InjectedDelegate>("UnityEngine.PhysicsScene2D::OverlapBox_Internal_Injected");
		OverlapBoxArray_Internal_InjectedDelegateField = IL2CPP.ResolveICall<OverlapBoxArray_Internal_InjectedDelegate>("UnityEngine.PhysicsScene2D::OverlapBoxArray_Internal_Injected");
		OverlapBoxList_Internal_InjectedDelegateField = IL2CPP.ResolveICall<OverlapBoxList_Internal_InjectedDelegate>("UnityEngine.PhysicsScene2D::OverlapBoxList_Internal_Injected");
		OverlapCapsule_Internal_InjectedDelegateField = IL2CPP.ResolveICall<OverlapCapsule_Internal_InjectedDelegate>("UnityEngine.PhysicsScene2D::OverlapCapsule_Internal_Injected");
		OverlapCapsuleArray_Internal_InjectedDelegateField = IL2CPP.ResolveICall<OverlapCapsuleArray_Internal_InjectedDelegate>("UnityEngine.PhysicsScene2D::OverlapCapsuleArray_Internal_Injected");
		OverlapCapsuleList_Internal_InjectedDelegateField = IL2CPP.ResolveICall<OverlapCapsuleList_Internal_InjectedDelegate>("UnityEngine.PhysicsScene2D::OverlapCapsuleList_Internal_Injected");
		OverlapColliderFilteredArray_Internal_InjectedDelegateField = IL2CPP.ResolveICall<OverlapColliderFilteredArray_Internal_InjectedDelegate>("UnityEngine.PhysicsScene2D::OverlapColliderFilteredArray_Internal_Injected");
		OverlapColliderList_Internal_InjectedDelegateField = IL2CPP.ResolveICall<OverlapColliderList_Internal_InjectedDelegate>("UnityEngine.PhysicsScene2D::OverlapColliderList_Internal_Injected");
		OverlapColliderFilteredList_Internal_InjectedDelegateField = IL2CPP.ResolveICall<OverlapColliderFilteredList_Internal_InjectedDelegate>("UnityEngine.PhysicsScene2D::OverlapColliderFilteredList_Internal_Injected");
		OverlapColliderFromList_Internal_InjectedDelegateField = IL2CPP.ResolveICall<OverlapColliderFromList_Internal_InjectedDelegate>("UnityEngine.PhysicsScene2D::OverlapColliderFromList_Internal_Injected");
		OverlapColliderFromFilteredList_Internal_InjectedDelegateField = IL2CPP.ResolveICall<OverlapColliderFromFilteredList_Internal_InjectedDelegate>("UnityEngine.PhysicsScene2D::OverlapColliderFromFilteredList_Internal_Injected");
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258659, XrefRangeEnd = 1258669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override string ToString()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToString_Public_Virtual_String_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(256)]
	[CachedScanResults(RefRangeStart = 1153990, RefRangeEnd = 1154246, XrefRangeStart = 1153990, XrefRangeEnd = 1154246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override int GetHashCode()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258669, XrefRangeEnd = 1258672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Equals(Il2CppSystem.Object other)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)other);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1177403, RefRangeEnd = 1177406, XrefRangeStart = 1177403, XrefRangeEnd = 1177406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual bool Equals(PhysicsScene2D other)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&other);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_PhysicsScene2D_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1258675, RefRangeEnd = 1258676, XrefRangeStart = 1258672, XrefRangeEnd = 1258675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, int layerMask = -5)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&origin);
		*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &direction;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &distance;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &layerMask;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Raycast_Public_RaycastHit2D_Vector2_Vector2_Single_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(RaycastHit2D*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258676, XrefRangeEnd = 1258678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&origin);
		*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &direction;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &distance;
		*(ContactFilter2D**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &contactFilter;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Raycast_Public_RaycastHit2D_Vector2_Vector2_Single_ContactFilter2D_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(RaycastHit2D*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258678, XrefRangeEnd = 1258690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int Raycast(Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter, Il2CppStructArray<RaycastHit2D> results)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&origin);
		*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &direction;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &distance;
		*(ContactFilter2D**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &contactFilter;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)results);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Raycast_Public_Int32_Vector2_Vector2_Single_ContactFilter2D_Il2CppStructArray_1_RaycastHit2D_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258690, XrefRangeEnd = 1258691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int Raycast(Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter, List<RaycastHit2D> results)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&origin);
		*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &direction;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &distance;
		*(ContactFilter2D**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &contactFilter;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)results);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Raycast_Public_Int32_Vector2_Vector2_Single_ContactFilter2D_List_1_RaycastHit2D_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258691, XrefRangeEnd = 1258693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static RaycastHit2D Raycast_Internal(PhysicsScene2D physicsScene, Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&physicsScene);
		*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &origin;
		*(Vector2**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &direction;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &distance;
		*(ContactFilter2D**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &contactFilter;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Raycast_Internal_Private_Static_RaycastHit2D_PhysicsScene2D_Vector2_Vector2_Single_ContactFilter2D_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(RaycastHit2D*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258693, XrefRangeEnd = 1258705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int RaycastArray_Internal(PhysicsScene2D physicsScene, Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter, Il2CppStructArray<RaycastHit2D> results)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&physicsScene);
		*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &origin;
		*(Vector2**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &direction;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &distance;
		*(ContactFilter2D**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &contactFilter;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)results);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RaycastArray_Internal_Private_Static_Int32_PhysicsScene2D_Vector2_Vector2_Single_ContactFilter2D_Il2CppStructArray_1_RaycastHit2D_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1258719, RefRangeEnd = 1258721, XrefRangeStart = 1258705, XrefRangeEnd = 1258719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int RaycastList_Internal(PhysicsScene2D physicsScene, Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter, List<RaycastHit2D> results)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&physicsScene);
		*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &origin;
		*(Vector2**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &direction;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &distance;
		*(ContactFilter2D**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &contactFilter;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)results);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RaycastList_Internal_Private_Static_Int32_PhysicsScene2D_Vector2_Vector2_Single_ContactFilter2D_List_1_RaycastHit2D_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258721, XrefRangeEnd = 1258723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RaycastHit2D GetRayIntersection(Ray ray, float distance, int layerMask = -5)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&ray);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &distance;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &layerMask;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRayIntersection_Public_RaycastHit2D_Ray_Single_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(RaycastHit2D*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258723, XrefRangeEnd = 1258735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetRayIntersection(Ray ray, float distance, Il2CppStructArray<RaycastHit2D> results, int layerMask = -5)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&ray);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &distance;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)results);
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &layerMask;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRayIntersection_Public_Int32_Ray_Single_Il2CppStructArray_1_RaycastHit2D_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258735, XrefRangeEnd = 1258737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static RaycastHit2D GetRayIntersection_Internal(PhysicsScene2D physicsScene, Vector3 origin, Vector3 direction, float distance, int layerMask)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&physicsScene);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &origin;
		*(Vector3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &direction;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &distance;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &layerMask;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRayIntersection_Internal_Private_Static_RaycastHit2D_PhysicsScene2D_Vector3_Vector3_Single_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(RaycastHit2D*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258737, XrefRangeEnd = 1258749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetRayIntersectionArray_Internal(PhysicsScene2D physicsScene, Vector3 origin, Vector3 direction, float distance, int layerMask, Il2CppStructArray<RaycastHit2D> results)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&physicsScene);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &origin;
		*(Vector3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &direction;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &distance;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &layerMask;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)results);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRayIntersectionArray_Internal_Private_Static_Int32_PhysicsScene2D_Vector3_Vector3_Single_Int32_Il2CppStructArray_1_RaycastHit2D_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258749, XrefRangeEnd = 1258751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Raycast_Internal_Injected([In] ref PhysicsScene2D physicsScene, [In] ref Vector2 origin, [In] ref Vector2 direction, float distance, [In] ref ContactFilter2D contactFilter, out RaycastHit2D ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)Unsafe.AsPointer(ref physicsScene);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref origin);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref direction);
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &distance;
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref contactFilter);
		*(void**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Raycast_Internal_Injected_Private_Static_Void_byref_PhysicsScene2D_byref_Vector2_byref_Vector2_Single_byref_ContactFilter2D_byref_RaycastHit2D_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258751, XrefRangeEnd = 1258753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int RaycastArray_Internal_Injected([In] ref PhysicsScene2D physicsScene, [In] ref Vector2 origin, [In] ref Vector2 direction, float distance, [In] ref ContactFilter2D contactFilter, ref ManagedSpanWrapper results)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)Unsafe.AsPointer(ref physicsScene);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref origin);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref direction);
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &distance;
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref contactFilter);
		*(void**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref results);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RaycastArray_Internal_Injected_Private_Static_Int32_byref_PhysicsScene2D_byref_Vector2_byref_Vector2_Single_byref_ContactFilter2D_byref_ManagedSpanWrapper_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258753, XrefRangeEnd = 1258755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int RaycastList_Internal_Injected([In] ref PhysicsScene2D physicsScene, [In] ref Vector2 origin, [In] ref Vector2 direction, float distance, [In] ref ContactFilter2D contactFilter, ref BlittableListWrapper results)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)Unsafe.AsPointer(ref physicsScene);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref origin);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref direction);
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &distance;
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref contactFilter);
		*(void**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref results);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RaycastList_Internal_Injected_Private_Static_Int32_byref_PhysicsScene2D_byref_Vector2_byref_Vector2_Single_byref_ContactFilter2D_byref_BlittableListWrapper_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258755, XrefRangeEnd = 1258757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetRayIntersection_Internal_Injected([In] ref PhysicsScene2D physicsScene, [In] ref Vector3 origin, [In] ref Vector3 direction, float distance, int layerMask, out RaycastHit2D ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)Unsafe.AsPointer(ref physicsScene);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref origin);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref direction);
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &distance;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &layerMask;
		*(void**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRayIntersection_Internal_Injected_Private_Static_Void_byref_PhysicsScene2D_byref_Vector3_byref_Vector3_Single_Int32_byref_RaycastHit2D_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258757, XrefRangeEnd = 1258759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetRayIntersectionArray_Internal_Injected([In] ref PhysicsScene2D physicsScene, [In] ref Vector3 origin, [In] ref Vector3 direction, float distance, int layerMask, ref ManagedSpanWrapper results)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)Unsafe.AsPointer(ref physicsScene);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref origin);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref direction);
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &distance;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &layerMask;
		*(void**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref results);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRayIntersectionArray_Internal_Injected_Private_Static_Int32_byref_PhysicsScene2D_byref_Vector3_byref_Vector3_Single_Int32_byref_ManagedSpanWrapper_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PhysicsScene2D>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}

	public static bool operator ==(PhysicsScene2D lhs, PhysicsScene2D rhs)
	{
		return lhs.m_Handle == rhs.m_Handle;
	}

	public static bool operator !=(PhysicsScene2D lhs, PhysicsScene2D rhs)
	{
		return lhs.m_Handle != rhs.m_Handle;
	}

	public bool IsValid()
	{
		return IsValid_Internal(this);
	}

	public static bool IsValid_Internal(PhysicsScene2D physicsScene)
	{
		return IsValid_Internal_Injected(ref physicsScene);
	}

	public bool IsEmpty()
	{
		if (IsValid())
		{
			return IsEmpty_Internal(this);
		}
		throw new Il2CppSystem.InvalidOperationException("Cannot check if physics scene is empty as it is invalid.");
	}

	public static bool IsEmpty_Internal(PhysicsScene2D physicsScene)
	{
		return IsEmpty_Internal_Injected(ref physicsScene);
	}

	public static int SubStepCount_Internal(PhysicsScene2D physicsScene)
	{
		return SubStepCount_Internal_Injected(ref physicsScene);
	}

	public static float SubStepLostTime_Internal(PhysicsScene2D physicsScene)
	{
		return SubStepLostTime_Internal_Injected(ref physicsScene);
	}

	public bool Simulate(float deltaTime)
	{
		return Simulate(deltaTime, -1);
	}

	public bool Simulate(float deltaTime, [Optional] int simulationLayers)
	{
		if (IsValid())
		{
			return Physics2D.Simulate_Internal(this, deltaTime, simulationLayers);
		}
		throw new Il2CppSystem.InvalidOperationException("Cannot simulate the physics scene as it is invalid.");
	}

	public RaycastHit2D Linecast(Vector2 start, Vector2 end, [Optional] int layerMask)
	{
		ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
		return Linecast_Internal(this, start, end, contactFilter);
	}

	public RaycastHit2D Linecast(Vector2 start, Vector2 end, ContactFilter2D contactFilter)
	{
		return Linecast_Internal(this, start, end, contactFilter);
	}

	public int Linecast(Vector2 start, Vector2 end, Il2CppStructArray<RaycastHit2D> results, [Optional] int layerMask)
	{
		ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
		return LinecastArray_Internal(this, start, end, contactFilter, results);
	}

	public int Linecast(Vector2 start, Vector2 end, ContactFilter2D contactFilter, Il2CppStructArray<RaycastHit2D> results)
	{
		return LinecastArray_Internal(this, start, end, contactFilter, results);
	}

	public int Linecast(Vector2 start, Vector2 end, ContactFilter2D contactFilter, List<RaycastHit2D> results)
	{
		return LinecastList_Internal(this, start, end, contactFilter, results);
	}

	public static RaycastHit2D Linecast_Internal(PhysicsScene2D physicsScene, Vector2 start, Vector2 end, ContactFilter2D contactFilter)
	{
		Linecast_Internal_Injected(ref physicsScene, ref start, ref end, ref contactFilter, out var ret);
		return ret;
	}

	public unsafe static int LinecastArray_Internal(PhysicsScene2D physicsScene, Vector2 start, Vector2 end, ContactFilter2D contactFilter, Il2CppStructArray<RaycastHit2D> results)
	{
		//IL_0022: Expected O, but got Ref
		//IL_0029: Expected O, but got Ref
		//IL_0035: Expected O, but got Ref
		if (results == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object)(object)results, "results");
		}
		Unsafe.SkipInit(out Il2CppSystem.Span<RaycastHit2D> span);
		((Il2CppSystem.Span<RaycastHit2D>)(&span))._002Ector((Il2CppArrayBase<RaycastHit2D>)(object)results);
		int result;
		fixed (RaycastHit2D* begin = &((Il2CppSystem.Span<RaycastHit2D>)(&span)).GetPinnableReference())
		{
			ManagedSpanWrapper results2 = new ManagedSpanWrapper(begin, ((Il2CppSystem.Span<RaycastHit2D>)(&span)).Length);
			result = LinecastArray_Internal_Injected(ref physicsScene, ref start, ref end, ref contactFilter, ref results2);
		}
		return result;
	}

	public static int LinecastList_Internal(PhysicsScene2D physicsScene, Vector2 start, Vector2 end, ContactFilter2D contactFilter, List<RaycastHit2D> results)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public int Raycast(Vector2 origin, Vector2 direction, float distance, Il2CppStructArray<RaycastHit2D> results, [Optional] int layerMask)
	{
		ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
		return RaycastArray_Internal(this, origin, direction, distance, contactFilter, results);
	}

	public RaycastHit2D CircleCast(Vector2 origin, float radius, Vector2 direction, float distance, [Optional] int layerMask)
	{
		ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
		return CircleCast_Internal(this, origin, radius, direction, distance, contactFilter);
	}

	public RaycastHit2D CircleCast(Vector2 origin, float radius, Vector2 direction, float distance, ContactFilter2D contactFilter)
	{
		return CircleCast_Internal(this, origin, radius, direction, distance, contactFilter);
	}

	public int CircleCast(Vector2 origin, float radius, Vector2 direction, float distance, Il2CppStructArray<RaycastHit2D> results, [Optional] int layerMask)
	{
		ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
		return CircleCastArray_Internal(this, origin, radius, direction, distance, contactFilter, results);
	}

	public int CircleCast(Vector2 origin, float radius, Vector2 direction, float distance, ContactFilter2D contactFilter, Il2CppStructArray<RaycastHit2D> results)
	{
		return CircleCastArray_Internal(this, origin, radius, direction, distance, contactFilter, results);
	}

	public int CircleCast(Vector2 origin, float radius, Vector2 direction, float distance, ContactFilter2D contactFilter, List<RaycastHit2D> results)
	{
		return CircleCastList_Internal(this, origin, radius, direction, distance, contactFilter, results);
	}

	public static RaycastHit2D CircleCast_Internal(PhysicsScene2D physicsScene, Vector2 origin, float radius, Vector2 direction, float distance, ContactFilter2D contactFilter)
	{
		CircleCast_Internal_Injected(ref physicsScene, ref origin, radius, ref direction, distance, ref contactFilter, out var ret);
		return ret;
	}

	public unsafe static int CircleCastArray_Internal(PhysicsScene2D physicsScene, Vector2 origin, float radius, Vector2 direction, float distance, ContactFilter2D contactFilter, Il2CppStructArray<RaycastHit2D> results)
	{
		//IL_0025: Expected O, but got Ref
		//IL_002c: Expected O, but got Ref
		//IL_0038: Expected O, but got Ref
		if (results == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object)(object)results, "results");
		}
		Unsafe.SkipInit(out Il2CppSystem.Span<RaycastHit2D> span);
		((Il2CppSystem.Span<RaycastHit2D>)(&span))._002Ector((Il2CppArrayBase<RaycastHit2D>)(object)results);
		int result;
		fixed (RaycastHit2D* begin = &((Il2CppSystem.Span<RaycastHit2D>)(&span)).GetPinnableReference())
		{
			ManagedSpanWrapper results2 = new ManagedSpanWrapper(begin, ((Il2CppSystem.Span<RaycastHit2D>)(&span)).Length);
			result = CircleCastArray_Internal_Injected(ref physicsScene, ref origin, radius, ref direction, distance, ref contactFilter, ref results2);
		}
		return result;
	}

	public static int CircleCastList_Internal(PhysicsScene2D physicsScene, Vector2 origin, float radius, Vector2 direction, float distance, ContactFilter2D contactFilter, List<RaycastHit2D> results)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public RaycastHit2D BoxCast(Vector2 origin, Vector2 size, float angle, Vector2 direction, float distance, [Optional] int layerMask)
	{
		ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
		return BoxCast_Internal(this, origin, size, angle, direction, distance, contactFilter);
	}

	public RaycastHit2D BoxCast(Vector2 origin, Vector2 size, float angle, Vector2 direction, float distance, ContactFilter2D contactFilter)
	{
		return BoxCast_Internal(this, origin, size, angle, direction, distance, contactFilter);
	}

	public int BoxCast(Vector2 origin, Vector2 size, float angle, Vector2 direction, float distance, Il2CppStructArray<RaycastHit2D> results, [Optional] int layerMask)
	{
		ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
		return BoxCastArray_Internal(this, origin, size, angle, direction, distance, contactFilter, results);
	}

	public int BoxCast(Vector2 origin, Vector2 size, float angle, Vector2 direction, float distance, ContactFilter2D contactFilter, Il2CppStructArray<RaycastHit2D> results)
	{
		return BoxCastArray_Internal(this, origin, size, angle, direction, distance, contactFilter, results);
	}

	public int BoxCast(Vector2 origin, Vector2 size, float angle, Vector2 direction, float distance, ContactFilter2D contactFilter, List<RaycastHit2D> results)
	{
		return BoxCastList_Internal(this, origin, size, angle, direction, distance, contactFilter, results);
	}

	public static RaycastHit2D BoxCast_Internal(PhysicsScene2D physicsScene, Vector2 origin, Vector2 size, float angle, Vector2 direction, float distance, ContactFilter2D contactFilter)
	{
		BoxCast_Internal_Injected(ref physicsScene, ref origin, ref size, angle, ref direction, distance, ref contactFilter, out var ret);
		return ret;
	}

	public unsafe static int BoxCastArray_Internal(PhysicsScene2D physicsScene, Vector2 origin, Vector2 size, float angle, Vector2 direction, float distance, ContactFilter2D contactFilter, Il2CppStructArray<RaycastHit2D> results)
	{
		//IL_0027: Expected O, but got Ref
		//IL_002e: Expected O, but got Ref
		//IL_003a: Expected O, but got Ref
		if (results == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object)(object)results, "results");
		}
		Unsafe.SkipInit(out Il2CppSystem.Span<RaycastHit2D> span);
		((Il2CppSystem.Span<RaycastHit2D>)(&span))._002Ector((Il2CppArrayBase<RaycastHit2D>)(object)results);
		int result;
		fixed (RaycastHit2D* begin = &((Il2CppSystem.Span<RaycastHit2D>)(&span)).GetPinnableReference())
		{
			ManagedSpanWrapper results2 = new ManagedSpanWrapper(begin, ((Il2CppSystem.Span<RaycastHit2D>)(&span)).Length);
			result = BoxCastArray_Internal_Injected(ref physicsScene, ref origin, ref size, angle, ref direction, distance, ref contactFilter, ref results2);
		}
		return result;
	}

	public static int BoxCastList_Internal(PhysicsScene2D physicsScene, Vector2 origin, Vector2 size, float angle, Vector2 direction, float distance, ContactFilter2D contactFilter, List<RaycastHit2D> results)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public RaycastHit2D CapsuleCast(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction, float distance, [Optional] int layerMask)
	{
		ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
		return CapsuleCast_Internal(this, origin, size, capsuleDirection, angle, direction, distance, contactFilter);
	}

	public RaycastHit2D CapsuleCast(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction, float distance, ContactFilter2D contactFilter)
	{
		return CapsuleCast_Internal(this, origin, size, capsuleDirection, angle, direction, distance, contactFilter);
	}

	public int CapsuleCast(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction, float distance, Il2CppStructArray<RaycastHit2D> results, [Optional] int layerMask)
	{
		ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
		return CapsuleCastArray_Internal(this, origin, size, capsuleDirection, angle, direction, distance, contactFilter, results);
	}

	public int CapsuleCast(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction, float distance, ContactFilter2D contactFilter, Il2CppStructArray<RaycastHit2D> results)
	{
		return CapsuleCastArray_Internal(this, origin, size, capsuleDirection, angle, direction, distance, contactFilter, results);
	}

	public int CapsuleCast(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction, float distance, ContactFilter2D contactFilter, List<RaycastHit2D> results)
	{
		return CapsuleCastList_Internal(this, origin, size, capsuleDirection, angle, direction, distance, contactFilter, results);
	}

	public static RaycastHit2D CapsuleCast_Internal(PhysicsScene2D physicsScene, Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction, float distance, ContactFilter2D contactFilter)
	{
		CapsuleCast_Internal_Injected(ref physicsScene, ref origin, ref size, capsuleDirection, angle, ref direction, distance, ref contactFilter, out var ret);
		return ret;
	}

	public unsafe static int CapsuleCastArray_Internal(PhysicsScene2D physicsScene, Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction, float distance, ContactFilter2D contactFilter, Il2CppStructArray<RaycastHit2D> results)
	{
		//IL_0029: Expected O, but got Ref
		//IL_0030: Expected O, but got Ref
		//IL_003c: Expected O, but got Ref
		if (results == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object)(object)results, "results");
		}
		Unsafe.SkipInit(out Il2CppSystem.Span<RaycastHit2D> span);
		((Il2CppSystem.Span<RaycastHit2D>)(&span))._002Ector((Il2CppArrayBase<RaycastHit2D>)(object)results);
		int result;
		fixed (RaycastHit2D* begin = &((Il2CppSystem.Span<RaycastHit2D>)(&span)).GetPinnableReference())
		{
			ManagedSpanWrapper results2 = new ManagedSpanWrapper(begin, ((Il2CppSystem.Span<RaycastHit2D>)(&span)).Length);
			result = CapsuleCastArray_Internal_Injected(ref physicsScene, ref origin, ref size, capsuleDirection, angle, ref direction, distance, ref contactFilter, ref results2);
		}
		return result;
	}

	public static int CapsuleCastList_Internal(PhysicsScene2D physicsScene, Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction, float distance, ContactFilter2D contactFilter, List<RaycastHit2D> results)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public int GetRayIntersection(Ray ray, float distance, List<RaycastHit2D> results, [Optional] int layerMask)
	{
		return GetRayIntersectionList_Internal(this, ray.origin, ray.direction, distance, layerMask, results);
	}

	public static int GetRayIntersectionList_Internal(PhysicsScene2D physicsScene, Vector3 origin, Vector3 direction, float distance, int layerMask, List<RaycastHit2D> results)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public Collider2D OverlapPoint(Vector2 point, [Optional] int layerMask)
	{
		ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
		return OverlapPoint_Internal(this, point, contactFilter);
	}

	public Collider2D OverlapPoint(Vector2 point, ContactFilter2D contactFilter)
	{
		return OverlapPoint_Internal(this, point, contactFilter);
	}

	public int OverlapPoint(Vector2 point, Il2CppReferenceArray<Collider2D> results, [Optional] int layerMask)
	{
		ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
		return OverlapPointArray_Internal(this, point, contactFilter, results);
	}

	public int OverlapPoint(Vector2 point, ContactFilter2D contactFilter, Il2CppReferenceArray<Collider2D> results)
	{
		return OverlapPointArray_Internal(this, point, contactFilter, results);
	}

	public int OverlapPoint(Vector2 point, ContactFilter2D contactFilter, List<Collider2D> results)
	{
		return OverlapPointList_Internal(this, point, contactFilter, results);
	}

	public static Collider2D OverlapPoint_Internal(PhysicsScene2D physicsScene, Vector2 point, ContactFilter2D contactFilter)
	{
		return Unmarshal.UnmarshalUnityObject<Collider2D>(OverlapPoint_Internal_Injected(ref physicsScene, ref point, ref contactFilter));
	}

	public static int OverlapPointArray_Internal(PhysicsScene2D physicsScene, Vector2 point, ContactFilter2D contactFilter, Il2CppReferenceArray<Collider2D> results)
	{
		if (results == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object)(object)results, "results");
		}
		return OverlapPointArray_Internal_Injected(ref physicsScene, ref point, ref contactFilter, results);
	}

	public static int OverlapPointList_Internal(PhysicsScene2D physicsScene, Vector2 point, ContactFilter2D contactFilter, List<Collider2D> results)
	{
		if (results == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(results, "results");
		}
		return OverlapPointList_Internal_Injected(ref physicsScene, ref point, ref contactFilter, results);
	}

	public Collider2D OverlapCircle(Vector2 point, float radius, [Optional] int layerMask)
	{
		ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
		return OverlapCircle_Internal(this, point, radius, contactFilter);
	}

	public Collider2D OverlapCircle(Vector2 point, float radius, ContactFilter2D contactFilter)
	{
		return OverlapCircle_Internal(this, point, radius, contactFilter);
	}

	public int OverlapCircle(Vector2 point, float radius, Il2CppReferenceArray<Collider2D> results, [Optional] int layerMask)
	{
		ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
		return OverlapCircleArray_Internal(this, point, radius, contactFilter, results);
	}

	public int OverlapCircle(Vector2 point, float radius, ContactFilter2D contactFilter, Il2CppReferenceArray<Collider2D> results)
	{
		return OverlapCircleArray_Internal(this, point, radius, contactFilter, results);
	}

	public int OverlapCircle(Vector2 point, float radius, ContactFilter2D contactFilter, List<Collider2D> results)
	{
		return OverlapCircleList_Internal(this, point, radius, contactFilter, results);
	}

	public static Collider2D OverlapCircle_Internal(PhysicsScene2D physicsScene, Vector2 point, float radius, ContactFilter2D contactFilter)
	{
		return Unmarshal.UnmarshalUnityObject<Collider2D>(OverlapCircle_Internal_Injected(ref physicsScene, ref point, radius, ref contactFilter));
	}

	public static int OverlapCircleArray_Internal(PhysicsScene2D physicsScene, Vector2 point, float radius, ContactFilter2D contactFilter, Il2CppReferenceArray<Collider2D> results)
	{
		if (results == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object)(object)results, "results");
		}
		return OverlapCircleArray_Internal_Injected(ref physicsScene, ref point, radius, ref contactFilter, results);
	}

	public static int OverlapCircleList_Internal(PhysicsScene2D physicsScene, Vector2 point, float radius, ContactFilter2D contactFilter, List<Collider2D> results)
	{
		if (results == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(results, "results");
		}
		return OverlapCircleList_Internal_Injected(ref physicsScene, ref point, radius, ref contactFilter, results);
	}

	public Collider2D OverlapBox(Vector2 point, Vector2 size, float angle, [Optional] int layerMask)
	{
		ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
		return OverlapBox_Internal(this, point, size, angle, contactFilter);
	}

	public Collider2D OverlapBox(Vector2 point, Vector2 size, float angle, ContactFilter2D contactFilter)
	{
		return OverlapBox_Internal(this, point, size, angle, contactFilter);
	}

	public int OverlapBox(Vector2 point, Vector2 size, float angle, Il2CppReferenceArray<Collider2D> results, [Optional] int layerMask)
	{
		ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
		return OverlapBoxArray_Internal(this, point, size, angle, contactFilter, results);
	}

	public int OverlapBox(Vector2 point, Vector2 size, float angle, ContactFilter2D contactFilter, Il2CppReferenceArray<Collider2D> results)
	{
		return OverlapBoxArray_Internal(this, point, size, angle, contactFilter, results);
	}

	public int OverlapBox(Vector2 point, Vector2 size, float angle, ContactFilter2D contactFilter, List<Collider2D> results)
	{
		return OverlapBoxList_Internal(this, point, size, angle, contactFilter, results);
	}

	public static Collider2D OverlapBox_Internal(PhysicsScene2D physicsScene, Vector2 point, Vector2 size, float angle, ContactFilter2D contactFilter)
	{
		return Unmarshal.UnmarshalUnityObject<Collider2D>(OverlapBox_Internal_Injected(ref physicsScene, ref point, ref size, angle, ref contactFilter));
	}

	public static int OverlapBoxArray_Internal(PhysicsScene2D physicsScene, Vector2 point, Vector2 size, float angle, ContactFilter2D contactFilter, Il2CppReferenceArray<Collider2D> results)
	{
		if (results == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object)(object)results, "results");
		}
		return OverlapBoxArray_Internal_Injected(ref physicsScene, ref point, ref size, angle, ref contactFilter, results);
	}

	public static int OverlapBoxList_Internal(PhysicsScene2D physicsScene, Vector2 point, Vector2 size, float angle, ContactFilter2D contactFilter, List<Collider2D> results)
	{
		if (results == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(results, "results");
		}
		return OverlapBoxList_Internal_Injected(ref physicsScene, ref point, ref size, angle, ref contactFilter, results);
	}

	public Collider2D OverlapArea(Vector2 pointA, Vector2 pointB, [Optional] int layerMask)
	{
		ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
		return OverlapAreaToBoxArray_Internal(pointA, pointB, contactFilter);
	}

	public Collider2D OverlapArea(Vector2 pointA, Vector2 pointB, ContactFilter2D contactFilter)
	{
		return OverlapAreaToBoxArray_Internal(pointA, pointB, contactFilter);
	}

	public Collider2D OverlapAreaToBoxArray_Internal(Vector2 pointA, Vector2 pointB, ContactFilter2D contactFilter)
	{
		Vector2 point = (pointA + pointB) * 0.5f;
		Vector2 size = new Vector2(Mathf.Abs(pointA.x - pointB.x), Il2CppSystem.Math.Abs(pointA.y - pointB.y));
		return OverlapBox(point, size, 0f, contactFilter);
	}

	public int OverlapArea(Vector2 pointA, Vector2 pointB, Il2CppReferenceArray<Collider2D> results, [Optional] int layerMask)
	{
		ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
		return OverlapAreaToBoxArray_Internal(pointA, pointB, contactFilter, results);
	}

	public int OverlapArea(Vector2 pointA, Vector2 pointB, ContactFilter2D contactFilter, Il2CppReferenceArray<Collider2D> results)
	{
		return OverlapAreaToBoxArray_Internal(pointA, pointB, contactFilter, results);
	}

	public int OverlapAreaToBoxArray_Internal(Vector2 pointA, Vector2 pointB, ContactFilter2D contactFilter, Il2CppReferenceArray<Collider2D> results)
	{
		Vector2 point = (pointA + pointB) * 0.5f;
		Vector2 size = new Vector2(Mathf.Abs(pointA.x - pointB.x), Il2CppSystem.Math.Abs(pointA.y - pointB.y));
		return OverlapBox(point, size, 0f, contactFilter, results);
	}

	public int OverlapArea(Vector2 pointA, Vector2 pointB, ContactFilter2D contactFilter, List<Collider2D> results)
	{
		return OverlapAreaToBoxList_Internal(pointA, pointB, contactFilter, results);
	}

	public int OverlapAreaToBoxList_Internal(Vector2 pointA, Vector2 pointB, ContactFilter2D contactFilter, List<Collider2D> results)
	{
		Vector2 point = (pointA + pointB) * 0.5f;
		Vector2 size = new Vector2(Mathf.Abs(pointA.x - pointB.x), Il2CppSystem.Math.Abs(pointA.y - pointB.y));
		return OverlapBox(point, size, 0f, contactFilter, results);
	}

	public Collider2D OverlapCapsule(Vector2 point, Vector2 size, CapsuleDirection2D direction, float angle, [Optional] int layerMask)
	{
		ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
		return OverlapCapsule_Internal(this, point, size, direction, angle, contactFilter);
	}

	public Collider2D OverlapCapsule(Vector2 point, Vector2 size, CapsuleDirection2D direction, float angle, ContactFilter2D contactFilter)
	{
		return OverlapCapsule_Internal(this, point, size, direction, angle, contactFilter);
	}

	public int OverlapCapsule(Vector2 point, Vector2 size, CapsuleDirection2D direction, float angle, Il2CppReferenceArray<Collider2D> results, [Optional] int layerMask)
	{
		ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
		return OverlapCapsuleArray_Internal(this, point, size, direction, angle, contactFilter, results);
	}

	public int OverlapCapsule(Vector2 point, Vector2 size, CapsuleDirection2D direction, float angle, ContactFilter2D contactFilter, Il2CppReferenceArray<Collider2D> results)
	{
		return OverlapCapsuleArray_Internal(this, point, size, direction, angle, contactFilter, results);
	}

	public int OverlapCapsule(Vector2 point, Vector2 size, CapsuleDirection2D direction, float angle, ContactFilter2D contactFilter, List<Collider2D> results)
	{
		return OverlapCapsuleList_Internal(this, point, size, direction, angle, contactFilter, results);
	}

	public static Collider2D OverlapCapsule_Internal(PhysicsScene2D physicsScene, Vector2 point, Vector2 size, CapsuleDirection2D direction, float angle, ContactFilter2D contactFilter)
	{
		return Unmarshal.UnmarshalUnityObject<Collider2D>(OverlapCapsule_Internal_Injected(ref physicsScene, ref point, ref size, direction, angle, ref contactFilter));
	}

	public static int OverlapCapsuleArray_Internal(PhysicsScene2D physicsScene, Vector2 point, Vector2 size, CapsuleDirection2D direction, float angle, ContactFilter2D contactFilter, Il2CppReferenceArray<Collider2D> results)
	{
		if (results == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object)(object)results, "results");
		}
		return OverlapCapsuleArray_Internal_Injected(ref physicsScene, ref point, ref size, direction, angle, ref contactFilter, results);
	}

	public static int OverlapCapsuleList_Internal(PhysicsScene2D physicsScene, Vector2 point, Vector2 size, CapsuleDirection2D direction, float angle, ContactFilter2D contactFilter, List<Collider2D> results)
	{
		if (results == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(results, "results");
		}
		return OverlapCapsuleList_Internal_Injected(ref physicsScene, ref point, ref size, direction, angle, ref contactFilter, results);
	}

	public static int OverlapCollider(Collider2D collider, Il2CppReferenceArray<Collider2D> results, [Optional] int layerMask)
	{
		ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
		return OverlapColliderFilteredArray_Internal(collider, contactFilter, results);
	}

	public static int OverlapCollider(Collider2D collider, ContactFilter2D contactFilter, Il2CppReferenceArray<Collider2D> results)
	{
		return OverlapColliderFilteredArray_Internal(collider, contactFilter, results);
	}

	public static int OverlapCollider(Collider2D collider, List<Collider2D> results)
	{
		return OverlapColliderList_Internal(collider, results);
	}

	public static int OverlapCollider(Collider2D collider, ContactFilter2D contactFilter, List<Collider2D> results)
	{
		return OverlapColliderFilteredList_Internal(collider, contactFilter, results);
	}

	public static int OverlapCollider(Vector2 position, float angle, Collider2D collider, List<Collider2D> results)
	{
		if ((bool)collider.attachedRigidbody)
		{
			return OverlapColliderFromList_Internal(position, angle, collider, results);
		}
		throw new Il2CppSystem.InvalidOperationException("Cannot perform a Collider Overlap at a specific position and angle if the Collider is not attached to a Rigidbody2D.");
	}

	public static int OverlapCollider(Vector2 position, float angle, Collider2D collider, ContactFilter2D contactFilter, List<Collider2D> results)
	{
		if ((bool)collider.attachedRigidbody)
		{
			return OverlapColliderFromFilteredList_Internal(position, angle, collider, contactFilter, results);
		}
		throw new Il2CppSystem.InvalidOperationException("Cannot perform a Collider Overlap at a specific position and angle if the Collider is not attached to a Rigidbody2D.");
	}

	public static int OverlapColliderFilteredArray_Internal(Collider2D collider, ContactFilter2D contactFilter, Il2CppReferenceArray<Collider2D> results)
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
		return OverlapColliderFilteredArray_Internal_Injected(intPtr, ref contactFilter, results);
	}

	public static int OverlapColliderList_Internal(Collider2D collider, List<Collider2D> results)
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
		return OverlapColliderList_Internal_Injected(intPtr, results);
	}

	public static int OverlapColliderFilteredList_Internal(Collider2D collider, ContactFilter2D contactFilter, List<Collider2D> results)
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
		return OverlapColliderFilteredList_Internal_Injected(intPtr, ref contactFilter, results);
	}

	public static int OverlapColliderFromList_Internal(Vector2 position, float angle, Collider2D collider, List<Collider2D> results)
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
		return OverlapColliderFromList_Internal_Injected(ref position, angle, intPtr, results);
	}

	public static int OverlapColliderFromFilteredList_Internal(Vector2 position, float angle, Collider2D collider, ContactFilter2D contactFilter, List<Collider2D> results)
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
		return OverlapColliderFromFilteredList_Internal_Injected(ref position, angle, intPtr, ref contactFilter, results);
	}

	public unsafe static bool IsValid_Internal_Injected([In] ref PhysicsScene2D physicsScene)
	{
		return IsValid_Internal_InjectedDelegateField((nint)Unsafe.AsPointer(ref physicsScene));
	}

	public unsafe static bool IsEmpty_Internal_Injected([In] ref PhysicsScene2D physicsScene)
	{
		return IsEmpty_Internal_InjectedDelegateField((nint)Unsafe.AsPointer(ref physicsScene));
	}

	public unsafe static int SubStepCount_Internal_Injected([In] ref PhysicsScene2D physicsScene)
	{
		return SubStepCount_Internal_InjectedDelegateField((nint)Unsafe.AsPointer(ref physicsScene));
	}

	public unsafe static float SubStepLostTime_Internal_Injected([In] ref PhysicsScene2D physicsScene)
	{
		return SubStepLostTime_Internal_InjectedDelegateField((nint)Unsafe.AsPointer(ref physicsScene));
	}

	public unsafe static void Linecast_Internal_Injected([In] ref PhysicsScene2D physicsScene, [In] ref Vector2 start, [In] ref Vector2 end, [In] ref ContactFilter2D contactFilter, out RaycastHit2D ret)
	{
		Linecast_Internal_InjectedDelegateField((nint)Unsafe.AsPointer(ref physicsScene), (nint)Unsafe.AsPointer(ref start), (nint)Unsafe.AsPointer(ref end), (nint)Unsafe.AsPointer(ref contactFilter), (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static int LinecastArray_Internal_Injected([In] ref PhysicsScene2D physicsScene, [In] ref Vector2 start, [In] ref Vector2 end, [In] ref ContactFilter2D contactFilter, ref ManagedSpanWrapper results)
	{
		return LinecastArray_Internal_InjectedDelegateField((nint)Unsafe.AsPointer(ref physicsScene), (nint)Unsafe.AsPointer(ref start), (nint)Unsafe.AsPointer(ref end), (nint)Unsafe.AsPointer(ref contactFilter), (nint)Unsafe.AsPointer(ref results));
	}

	public unsafe static int LinecastList_Internal_Injected([In] ref PhysicsScene2D physicsScene, [In] ref Vector2 start, [In] ref Vector2 end, [In] ref ContactFilter2D contactFilter, ref BlittableListWrapper results)
	{
		return LinecastList_Internal_InjectedDelegateField((nint)Unsafe.AsPointer(ref physicsScene), (nint)Unsafe.AsPointer(ref start), (nint)Unsafe.AsPointer(ref end), (nint)Unsafe.AsPointer(ref contactFilter), (nint)Unsafe.AsPointer(ref results));
	}

	public unsafe static void CircleCast_Internal_Injected([In] ref PhysicsScene2D physicsScene, [In] ref Vector2 origin, float radius, [In] ref Vector2 direction, float distance, [In] ref ContactFilter2D contactFilter, out RaycastHit2D ret)
	{
		CircleCast_Internal_InjectedDelegateField((nint)Unsafe.AsPointer(ref physicsScene), (nint)Unsafe.AsPointer(ref origin), radius, (nint)Unsafe.AsPointer(ref direction), distance, (nint)Unsafe.AsPointer(ref contactFilter), (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static int CircleCastArray_Internal_Injected([In] ref PhysicsScene2D physicsScene, [In] ref Vector2 origin, float radius, [In] ref Vector2 direction, float distance, [In] ref ContactFilter2D contactFilter, ref ManagedSpanWrapper results)
	{
		return CircleCastArray_Internal_InjectedDelegateField((nint)Unsafe.AsPointer(ref physicsScene), (nint)Unsafe.AsPointer(ref origin), radius, (nint)Unsafe.AsPointer(ref direction), distance, (nint)Unsafe.AsPointer(ref contactFilter), (nint)Unsafe.AsPointer(ref results));
	}

	public unsafe static int CircleCastList_Internal_Injected([In] ref PhysicsScene2D physicsScene, [In] ref Vector2 origin, float radius, [In] ref Vector2 direction, float distance, [In] ref ContactFilter2D contactFilter, ref BlittableListWrapper results)
	{
		return CircleCastList_Internal_InjectedDelegateField((nint)Unsafe.AsPointer(ref physicsScene), (nint)Unsafe.AsPointer(ref origin), radius, (nint)Unsafe.AsPointer(ref direction), distance, (nint)Unsafe.AsPointer(ref contactFilter), (nint)Unsafe.AsPointer(ref results));
	}

	public unsafe static void BoxCast_Internal_Injected([In] ref PhysicsScene2D physicsScene, [In] ref Vector2 origin, [In] ref Vector2 size, float angle, [In] ref Vector2 direction, float distance, [In] ref ContactFilter2D contactFilter, out RaycastHit2D ret)
	{
		BoxCast_Internal_InjectedDelegateField((nint)Unsafe.AsPointer(ref physicsScene), (nint)Unsafe.AsPointer(ref origin), (nint)Unsafe.AsPointer(ref size), angle, (nint)Unsafe.AsPointer(ref direction), distance, (nint)Unsafe.AsPointer(ref contactFilter), (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static int BoxCastArray_Internal_Injected([In] ref PhysicsScene2D physicsScene, [In] ref Vector2 origin, [In] ref Vector2 size, float angle, [In] ref Vector2 direction, float distance, [In] ref ContactFilter2D contactFilter, ref ManagedSpanWrapper results)
	{
		return BoxCastArray_Internal_InjectedDelegateField((nint)Unsafe.AsPointer(ref physicsScene), (nint)Unsafe.AsPointer(ref origin), (nint)Unsafe.AsPointer(ref size), angle, (nint)Unsafe.AsPointer(ref direction), distance, (nint)Unsafe.AsPointer(ref contactFilter), (nint)Unsafe.AsPointer(ref results));
	}

	public unsafe static int BoxCastList_Internal_Injected([In] ref PhysicsScene2D physicsScene, [In] ref Vector2 origin, [In] ref Vector2 size, float angle, [In] ref Vector2 direction, float distance, [In] ref ContactFilter2D contactFilter, ref BlittableListWrapper results)
	{
		return BoxCastList_Internal_InjectedDelegateField((nint)Unsafe.AsPointer(ref physicsScene), (nint)Unsafe.AsPointer(ref origin), (nint)Unsafe.AsPointer(ref size), angle, (nint)Unsafe.AsPointer(ref direction), distance, (nint)Unsafe.AsPointer(ref contactFilter), (nint)Unsafe.AsPointer(ref results));
	}

	public unsafe static void CapsuleCast_Internal_Injected([In] ref PhysicsScene2D physicsScene, [In] ref Vector2 origin, [In] ref Vector2 size, CapsuleDirection2D capsuleDirection, float angle, [In] ref Vector2 direction, float distance, [In] ref ContactFilter2D contactFilter, out RaycastHit2D ret)
	{
		CapsuleCast_Internal_InjectedDelegateField((nint)Unsafe.AsPointer(ref physicsScene), (nint)Unsafe.AsPointer(ref origin), (nint)Unsafe.AsPointer(ref size), capsuleDirection, angle, (nint)Unsafe.AsPointer(ref direction), distance, (nint)Unsafe.AsPointer(ref contactFilter), (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static int CapsuleCastArray_Internal_Injected([In] ref PhysicsScene2D physicsScene, [In] ref Vector2 origin, [In] ref Vector2 size, CapsuleDirection2D capsuleDirection, float angle, [In] ref Vector2 direction, float distance, [In] ref ContactFilter2D contactFilter, ref ManagedSpanWrapper results)
	{
		return CapsuleCastArray_Internal_InjectedDelegateField((nint)Unsafe.AsPointer(ref physicsScene), (nint)Unsafe.AsPointer(ref origin), (nint)Unsafe.AsPointer(ref size), capsuleDirection, angle, (nint)Unsafe.AsPointer(ref direction), distance, (nint)Unsafe.AsPointer(ref contactFilter), (nint)Unsafe.AsPointer(ref results));
	}

	public unsafe static int CapsuleCastList_Internal_Injected([In] ref PhysicsScene2D physicsScene, [In] ref Vector2 origin, [In] ref Vector2 size, CapsuleDirection2D capsuleDirection, float angle, [In] ref Vector2 direction, float distance, [In] ref ContactFilter2D contactFilter, ref BlittableListWrapper results)
	{
		return CapsuleCastList_Internal_InjectedDelegateField((nint)Unsafe.AsPointer(ref physicsScene), (nint)Unsafe.AsPointer(ref origin), (nint)Unsafe.AsPointer(ref size), capsuleDirection, angle, (nint)Unsafe.AsPointer(ref direction), distance, (nint)Unsafe.AsPointer(ref contactFilter), (nint)Unsafe.AsPointer(ref results));
	}

	public unsafe static int GetRayIntersectionList_Internal_Injected([In] ref PhysicsScene2D physicsScene, [In] ref Vector3 origin, [In] ref Vector3 direction, float distance, int layerMask, ref BlittableListWrapper results)
	{
		return GetRayIntersectionList_Internal_InjectedDelegateField((nint)Unsafe.AsPointer(ref physicsScene), (nint)Unsafe.AsPointer(ref origin), (nint)Unsafe.AsPointer(ref direction), distance, layerMask, (nint)Unsafe.AsPointer(ref results));
	}

	public unsafe static System.IntPtr OverlapPoint_Internal_Injected([In] ref PhysicsScene2D physicsScene, [In] ref Vector2 point, [In] ref ContactFilter2D contactFilter)
	{
		return OverlapPoint_Internal_InjectedDelegateField((nint)Unsafe.AsPointer(ref physicsScene), (nint)Unsafe.AsPointer(ref point), (nint)Unsafe.AsPointer(ref contactFilter));
	}

	public unsafe static int OverlapPointArray_Internal_Injected([In] ref PhysicsScene2D physicsScene, [In] ref Vector2 point, [In] ref ContactFilter2D contactFilter, Il2CppReferenceArray<Collider2D> results)
	{
		return OverlapPointArray_Internal_InjectedDelegateField((nint)Unsafe.AsPointer(ref physicsScene), (nint)Unsafe.AsPointer(ref point), (nint)Unsafe.AsPointer(ref contactFilter), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)results));
	}

	public unsafe static int OverlapPointList_Internal_Injected([In] ref PhysicsScene2D physicsScene, [In] ref Vector2 point, [In] ref ContactFilter2D contactFilter, List<Collider2D> results)
	{
		return OverlapPointList_Internal_InjectedDelegateField((nint)Unsafe.AsPointer(ref physicsScene), (nint)Unsafe.AsPointer(ref point), (nint)Unsafe.AsPointer(ref contactFilter), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)results));
	}

	public unsafe static System.IntPtr OverlapCircle_Internal_Injected([In] ref PhysicsScene2D physicsScene, [In] ref Vector2 point, float radius, [In] ref ContactFilter2D contactFilter)
	{
		return OverlapCircle_Internal_InjectedDelegateField((nint)Unsafe.AsPointer(ref physicsScene), (nint)Unsafe.AsPointer(ref point), radius, (nint)Unsafe.AsPointer(ref contactFilter));
	}

	public unsafe static int OverlapCircleArray_Internal_Injected([In] ref PhysicsScene2D physicsScene, [In] ref Vector2 point, float radius, [In] ref ContactFilter2D contactFilter, Il2CppReferenceArray<Collider2D> results)
	{
		return OverlapCircleArray_Internal_InjectedDelegateField((nint)Unsafe.AsPointer(ref physicsScene), (nint)Unsafe.AsPointer(ref point), radius, (nint)Unsafe.AsPointer(ref contactFilter), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)results));
	}

	public unsafe static int OverlapCircleList_Internal_Injected([In] ref PhysicsScene2D physicsScene, [In] ref Vector2 point, float radius, [In] ref ContactFilter2D contactFilter, List<Collider2D> results)
	{
		return OverlapCircleList_Internal_InjectedDelegateField((nint)Unsafe.AsPointer(ref physicsScene), (nint)Unsafe.AsPointer(ref point), radius, (nint)Unsafe.AsPointer(ref contactFilter), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)results));
	}

	public unsafe static System.IntPtr OverlapBox_Internal_Injected([In] ref PhysicsScene2D physicsScene, [In] ref Vector2 point, [In] ref Vector2 size, float angle, [In] ref ContactFilter2D contactFilter)
	{
		return OverlapBox_Internal_InjectedDelegateField((nint)Unsafe.AsPointer(ref physicsScene), (nint)Unsafe.AsPointer(ref point), (nint)Unsafe.AsPointer(ref size), angle, (nint)Unsafe.AsPointer(ref contactFilter));
	}

	public unsafe static int OverlapBoxArray_Internal_Injected([In] ref PhysicsScene2D physicsScene, [In] ref Vector2 point, [In] ref Vector2 size, float angle, [In] ref ContactFilter2D contactFilter, Il2CppReferenceArray<Collider2D> results)
	{
		return OverlapBoxArray_Internal_InjectedDelegateField((nint)Unsafe.AsPointer(ref physicsScene), (nint)Unsafe.AsPointer(ref point), (nint)Unsafe.AsPointer(ref size), angle, (nint)Unsafe.AsPointer(ref contactFilter), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)results));
	}

	public unsafe static int OverlapBoxList_Internal_Injected([In] ref PhysicsScene2D physicsScene, [In] ref Vector2 point, [In] ref Vector2 size, float angle, [In] ref ContactFilter2D contactFilter, List<Collider2D> results)
	{
		return OverlapBoxList_Internal_InjectedDelegateField((nint)Unsafe.AsPointer(ref physicsScene), (nint)Unsafe.AsPointer(ref point), (nint)Unsafe.AsPointer(ref size), angle, (nint)Unsafe.AsPointer(ref contactFilter), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)results));
	}

	public unsafe static System.IntPtr OverlapCapsule_Internal_Injected([In] ref PhysicsScene2D physicsScene, [In] ref Vector2 point, [In] ref Vector2 size, CapsuleDirection2D direction, float angle, [In] ref ContactFilter2D contactFilter)
	{
		return OverlapCapsule_Internal_InjectedDelegateField((nint)Unsafe.AsPointer(ref physicsScene), (nint)Unsafe.AsPointer(ref point), (nint)Unsafe.AsPointer(ref size), direction, angle, (nint)Unsafe.AsPointer(ref contactFilter));
	}

	public unsafe static int OverlapCapsuleArray_Internal_Injected([In] ref PhysicsScene2D physicsScene, [In] ref Vector2 point, [In] ref Vector2 size, CapsuleDirection2D direction, float angle, [In] ref ContactFilter2D contactFilter, Il2CppReferenceArray<Collider2D> results)
	{
		return OverlapCapsuleArray_Internal_InjectedDelegateField((nint)Unsafe.AsPointer(ref physicsScene), (nint)Unsafe.AsPointer(ref point), (nint)Unsafe.AsPointer(ref size), direction, angle, (nint)Unsafe.AsPointer(ref contactFilter), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)results));
	}

	public unsafe static int OverlapCapsuleList_Internal_Injected([In] ref PhysicsScene2D physicsScene, [In] ref Vector2 point, [In] ref Vector2 size, CapsuleDirection2D direction, float angle, [In] ref ContactFilter2D contactFilter, List<Collider2D> results)
	{
		return OverlapCapsuleList_Internal_InjectedDelegateField((nint)Unsafe.AsPointer(ref physicsScene), (nint)Unsafe.AsPointer(ref point), (nint)Unsafe.AsPointer(ref size), direction, angle, (nint)Unsafe.AsPointer(ref contactFilter), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)results));
	}

	public unsafe static int OverlapColliderFilteredArray_Internal_Injected(System.IntPtr collider, [In] ref ContactFilter2D contactFilter, Il2CppReferenceArray<Collider2D> results)
	{
		return OverlapColliderFilteredArray_Internal_InjectedDelegateField(collider, (nint)Unsafe.AsPointer(ref contactFilter), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)results));
	}

	public static int OverlapColliderList_Internal_Injected(System.IntPtr collider, List<Collider2D> results)
	{
		return OverlapColliderList_Internal_InjectedDelegateField(collider, IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)results));
	}

	public unsafe static int OverlapColliderFilteredList_Internal_Injected(System.IntPtr collider, [In] ref ContactFilter2D contactFilter, List<Collider2D> results)
	{
		return OverlapColliderFilteredList_Internal_InjectedDelegateField(collider, (nint)Unsafe.AsPointer(ref contactFilter), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)results));
	}

	public unsafe static int OverlapColliderFromList_Internal_Injected([In] ref Vector2 position, float angle, System.IntPtr collider, List<Collider2D> results)
	{
		return OverlapColliderFromList_Internal_InjectedDelegateField((nint)Unsafe.AsPointer(ref position), angle, collider, IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)results));
	}

	public unsafe static int OverlapColliderFromFilteredList_Internal_Injected([In] ref Vector2 position, float angle, System.IntPtr collider, [In] ref ContactFilter2D contactFilter, List<Collider2D> results)
	{
		return OverlapColliderFromFilteredList_Internal_InjectedDelegateField((nint)Unsafe.AsPointer(ref position), angle, collider, (nint)Unsafe.AsPointer(ref contactFilter), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)results));
	}
}
