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

[StructLayout(LayoutKind.Explicit)]
public struct PhysicsScene
{
	private delegate bool IsValid_Internal_InjectedDelegate([In] System.IntPtr physicsScene);

	private delegate bool IsEmpty_Internal_InjectedDelegate([In] System.IntPtr physicsScene);

	private delegate bool Query_CapsuleCast_InjectedDelegate([In] System.IntPtr physicsScene, [In] System.IntPtr point1, [In] System.IntPtr point2, float radius, [In] System.IntPtr direction, float maxDistance, System.IntPtr hitInfo, int layerMask, QueryTriggerInteraction queryTriggerInteraction);

	private delegate int Internal_CapsuleCastNonAlloc_InjectedDelegate([In] System.IntPtr physicsScene, [In] System.IntPtr p0, [In] System.IntPtr p1, float radius, [In] System.IntPtr direction, System.IntPtr raycastHits, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction);

	private delegate int OverlapCapsuleNonAlloc_Internal_InjectedDelegate([In] System.IntPtr physicsScene, [In] System.IntPtr point0, [In] System.IntPtr point1, float radius, System.IntPtr results, int layerMask, QueryTriggerInteraction queryTriggerInteraction);

	private delegate bool Query_SphereCast_InjectedDelegate([In] System.IntPtr physicsScene, [In] System.IntPtr origin, float radius, [In] System.IntPtr direction, float maxDistance, System.IntPtr hitInfo, int layerMask, QueryTriggerInteraction queryTriggerInteraction);

	private delegate int Internal_SphereCastNonAlloc_InjectedDelegate([In] System.IntPtr physicsScene, [In] System.IntPtr origin, float radius, [In] System.IntPtr direction, System.IntPtr raycastHits, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction);

	private delegate int OverlapSphereNonAlloc_Internal_InjectedDelegate([In] System.IntPtr physicsScene, [In] System.IntPtr position, float radius, System.IntPtr results, int layerMask, QueryTriggerInteraction queryTriggerInteraction);

	private delegate bool Query_BoxCast_InjectedDelegate([In] System.IntPtr physicsScene, [In] System.IntPtr center, [In] System.IntPtr halfExtents, [In] System.IntPtr direction, [In] System.IntPtr orientation, float maxDistance, System.IntPtr outHit, int layerMask, QueryTriggerInteraction queryTriggerInteraction);

	private delegate int OverlapBoxNonAlloc_Internal_InjectedDelegate([In] System.IntPtr physicsScene, [In] System.IntPtr center, [In] System.IntPtr halfExtents, System.IntPtr results, [In] System.IntPtr orientation, int mask, QueryTriggerInteraction queryTriggerInteraction);

	private delegate int Internal_BoxCastNonAlloc_InjectedDelegate([In] System.IntPtr physicsScene, [In] System.IntPtr center, [In] System.IntPtr halfExtents, [In] System.IntPtr direction, System.IntPtr raycastHits, [In] System.IntPtr orientation, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction);

	private static readonly System.IntPtr NativeFieldInfoPtr_m_index;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_version;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_PhysicsScene_PhysicsScene_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_PhysicsScene_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDefaultScene_Internal_Static_PhysicsScene_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Raycast_Public_Boolean_Vector3_Vector3_Single_Int32_QueryTriggerInteraction_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_RaycastTest_Private_Static_Boolean_PhysicsScene_Ray_Single_Int32_QueryTriggerInteraction_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Raycast_Public_Boolean_Vector3_Vector3_byref_RaycastHit_Single_Int32_QueryTriggerInteraction_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_Raycast_Private_Static_Boolean_PhysicsScene_Ray_Single_byref_RaycastHit_Int32_QueryTriggerInteraction_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Raycast_Public_Int32_Vector3_Vector3_Il2CppStructArray_1_RaycastHit_Single_Int32_QueryTriggerInteraction_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_RaycastNonAlloc_Private_Static_Int32_PhysicsScene_Ray_Il2CppStructArray_1_RaycastHit_Single_Int32_QueryTriggerInteraction_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_RaycastTest_Injected_Private_Static_Boolean_byref_PhysicsScene_byref_Ray_Single_Int32_QueryTriggerInteraction_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_Raycast_Injected_Private_Static_Boolean_byref_PhysicsScene_byref_Ray_Single_byref_RaycastHit_Int32_QueryTriggerInteraction_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_RaycastNonAlloc_Injected_Private_Static_Int32_byref_PhysicsScene_byref_Ray_byref_ManagedSpanWrapper_Single_Int32_QueryTriggerInteraction_0;

	[FieldOffset(0)]
	public int m_index;

	[FieldOffset(4)]
	public int m_version;

	private static readonly IsValid_Internal_InjectedDelegate IsValid_Internal_InjectedDelegateField;

	private static readonly IsEmpty_Internal_InjectedDelegate IsEmpty_Internal_InjectedDelegateField;

	private static readonly Query_CapsuleCast_InjectedDelegate Query_CapsuleCast_InjectedDelegateField;

	private static readonly Internal_CapsuleCastNonAlloc_InjectedDelegate Internal_CapsuleCastNonAlloc_InjectedDelegateField;

	private static readonly OverlapCapsuleNonAlloc_Internal_InjectedDelegate OverlapCapsuleNonAlloc_Internal_InjectedDelegateField;

	private static readonly Query_SphereCast_InjectedDelegate Query_SphereCast_InjectedDelegateField;

	private static readonly Internal_SphereCastNonAlloc_InjectedDelegate Internal_SphereCastNonAlloc_InjectedDelegateField;

	private static readonly OverlapSphereNonAlloc_Internal_InjectedDelegate OverlapSphereNonAlloc_Internal_InjectedDelegateField;

	private static readonly Query_BoxCast_InjectedDelegate Query_BoxCast_InjectedDelegateField;

	private static readonly OverlapBoxNonAlloc_Internal_InjectedDelegate OverlapBoxNonAlloc_Internal_InjectedDelegateField;

	private static readonly Internal_BoxCastNonAlloc_InjectedDelegate Internal_BoxCastNonAlloc_InjectedDelegateField;

	static PhysicsScene()
	{
		Il2CppClassPointerStore<PhysicsScene>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.PhysicsModule.dll", "UnityEngine", "PhysicsScene");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PhysicsScene>.NativeClassPtr);
		NativeFieldInfoPtr_m_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhysicsScene>.NativeClassPtr, "m_index");
		NativeFieldInfoPtr_m_version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhysicsScene>.NativeClassPtr, "m_version");
		NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsScene>.NativeClassPtr, 100663414);
		NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_PhysicsScene_PhysicsScene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsScene>.NativeClassPtr, 100663415);
		NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsScene>.NativeClassPtr, 100663416);
		NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsScene>.NativeClassPtr, 100663417);
		NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_PhysicsScene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsScene>.NativeClassPtr, 100663418);
		NativeMethodInfoPtr_GetDefaultScene_Internal_Static_PhysicsScene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsScene>.NativeClassPtr, 100663419);
		NativeMethodInfoPtr_Raycast_Public_Boolean_Vector3_Vector3_Single_Int32_QueryTriggerInteraction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsScene>.NativeClassPtr, 100663420);
		NativeMethodInfoPtr_Internal_RaycastTest_Private_Static_Boolean_PhysicsScene_Ray_Single_Int32_QueryTriggerInteraction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsScene>.NativeClassPtr, 100663421);
		NativeMethodInfoPtr_Raycast_Public_Boolean_Vector3_Vector3_byref_RaycastHit_Single_Int32_QueryTriggerInteraction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsScene>.NativeClassPtr, 100663422);
		NativeMethodInfoPtr_Internal_Raycast_Private_Static_Boolean_PhysicsScene_Ray_Single_byref_RaycastHit_Int32_QueryTriggerInteraction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsScene>.NativeClassPtr, 100663423);
		NativeMethodInfoPtr_Raycast_Public_Int32_Vector3_Vector3_Il2CppStructArray_1_RaycastHit_Single_Int32_QueryTriggerInteraction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsScene>.NativeClassPtr, 100663424);
		NativeMethodInfoPtr_Internal_RaycastNonAlloc_Private_Static_Int32_PhysicsScene_Ray_Il2CppStructArray_1_RaycastHit_Single_Int32_QueryTriggerInteraction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsScene>.NativeClassPtr, 100663425);
		NativeMethodInfoPtr_Internal_RaycastTest_Injected_Private_Static_Boolean_byref_PhysicsScene_byref_Ray_Single_Int32_QueryTriggerInteraction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsScene>.NativeClassPtr, 100663426);
		NativeMethodInfoPtr_Internal_Raycast_Injected_Private_Static_Boolean_byref_PhysicsScene_byref_Ray_Single_byref_RaycastHit_Int32_QueryTriggerInteraction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsScene>.NativeClassPtr, 100663427);
		NativeMethodInfoPtr_Internal_RaycastNonAlloc_Injected_Private_Static_Int32_byref_PhysicsScene_byref_Ray_byref_ManagedSpanWrapper_Single_Int32_QueryTriggerInteraction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsScene>.NativeClassPtr, 100663428);
		IsValid_Internal_InjectedDelegateField = IL2CPP.ResolveICall<IsValid_Internal_InjectedDelegate>("UnityEngine.PhysicsScene::IsValid_Internal_Injected");
		IsEmpty_Internal_InjectedDelegateField = IL2CPP.ResolveICall<IsEmpty_Internal_InjectedDelegate>("UnityEngine.PhysicsScene::IsEmpty_Internal_Injected");
		Query_CapsuleCast_InjectedDelegateField = IL2CPP.ResolveICall<Query_CapsuleCast_InjectedDelegate>("UnityEngine.PhysicsScene::Query_CapsuleCast_Injected");
		Internal_CapsuleCastNonAlloc_InjectedDelegateField = IL2CPP.ResolveICall<Internal_CapsuleCastNonAlloc_InjectedDelegate>("UnityEngine.PhysicsScene::Internal_CapsuleCastNonAlloc_Injected");
		OverlapCapsuleNonAlloc_Internal_InjectedDelegateField = IL2CPP.ResolveICall<OverlapCapsuleNonAlloc_Internal_InjectedDelegate>("UnityEngine.PhysicsScene::OverlapCapsuleNonAlloc_Internal_Injected");
		Query_SphereCast_InjectedDelegateField = IL2CPP.ResolveICall<Query_SphereCast_InjectedDelegate>("UnityEngine.PhysicsScene::Query_SphereCast_Injected");
		Internal_SphereCastNonAlloc_InjectedDelegateField = IL2CPP.ResolveICall<Internal_SphereCastNonAlloc_InjectedDelegate>("UnityEngine.PhysicsScene::Internal_SphereCastNonAlloc_Injected");
		OverlapSphereNonAlloc_Internal_InjectedDelegateField = IL2CPP.ResolveICall<OverlapSphereNonAlloc_Internal_InjectedDelegate>("UnityEngine.PhysicsScene::OverlapSphereNonAlloc_Internal_Injected");
		Query_BoxCast_InjectedDelegateField = IL2CPP.ResolveICall<Query_BoxCast_InjectedDelegate>("UnityEngine.PhysicsScene::Query_BoxCast_Injected");
		OverlapBoxNonAlloc_Internal_InjectedDelegateField = IL2CPP.ResolveICall<OverlapBoxNonAlloc_Internal_InjectedDelegate>("UnityEngine.PhysicsScene::OverlapBoxNonAlloc_Internal_Injected");
		Internal_BoxCastNonAlloc_InjectedDelegateField = IL2CPP.ResolveICall<Internal_BoxCastNonAlloc_InjectedDelegate>("UnityEngine.PhysicsScene::Internal_BoxCastNonAlloc_Injected");
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259738, XrefRangeEnd = 1259745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override string ToString()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToString_Public_Virtual_String_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static bool operator ==(PhysicsScene lhs, PhysicsScene rhs)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&lhs);
		*(PhysicsScene**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &rhs;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_PhysicsScene_PhysicsScene_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259745, XrefRangeEnd = 1259751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override int GetHashCode()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259751, XrefRangeEnd = 1259754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Equals(Il2CppSystem.Object other)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)other);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual bool Equals(PhysicsScene other)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&other);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_PhysicsScene_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static PhysicsScene GetDefaultScene()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDefaultScene_Internal_Static_PhysicsScene_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(PhysicsScene*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259754, XrefRangeEnd = 1259759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Raycast(Vector3 origin, Vector3 direction, float maxDistance = float.PositiveInfinity, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&origin);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &direction;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxDistance;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &layerMask;
		*(QueryTriggerInteraction**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &queryTriggerInteraction;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Raycast_Public_Boolean_Vector3_Vector3_Single_Int32_QueryTriggerInteraction_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259759, XrefRangeEnd = 1259761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool Internal_RaycastTest(PhysicsScene physicsScene, Ray ray, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&physicsScene);
		*(Ray**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &ray;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxDistance;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &layerMask;
		*(QueryTriggerInteraction**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &queryTriggerInteraction;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_RaycastTest_Private_Static_Boolean_PhysicsScene_Ray_Single_Int32_QueryTriggerInteraction_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 1259766, RefRangeEnd = 1259774, XrefRangeStart = 1259761, XrefRangeEnd = 1259766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance = float.PositiveInfinity, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&origin);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &direction;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref hitInfo);
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxDistance;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &layerMask;
		*(QueryTriggerInteraction**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &queryTriggerInteraction;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Raycast_Public_Boolean_Vector3_Vector3_byref_RaycastHit_Single_Int32_QueryTriggerInteraction_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259774, XrefRangeEnd = 1259776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool Internal_Raycast(PhysicsScene physicsScene, Ray ray, float maxDistance, ref RaycastHit hit, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&physicsScene);
		*(Ray**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &ray;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxDistance;
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref hit);
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &layerMask;
		*(QueryTriggerInteraction**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &queryTriggerInteraction;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_Raycast_Private_Static_Boolean_PhysicsScene_Ray_Single_byref_RaycastHit_Int32_QueryTriggerInteraction_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1259789, RefRangeEnd = 1259793, XrefRangeStart = 1259776, XrefRangeEnd = 1259789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int Raycast(Vector3 origin, Vector3 direction, Il2CppStructArray<RaycastHit> raycastHits, float maxDistance = float.PositiveInfinity, int layerMask = -5, QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&origin);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &direction;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)raycastHits);
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxDistance;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &layerMask;
		*(QueryTriggerInteraction**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &queryTriggerInteraction;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Raycast_Public_Int32_Vector3_Vector3_Il2CppStructArray_1_RaycastHit_Single_Int32_QueryTriggerInteraction_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259793, XrefRangeEnd = 1259802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int Internal_RaycastNonAlloc(PhysicsScene physicsScene, Ray ray, Il2CppStructArray<RaycastHit> raycastHits, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&physicsScene);
		*(Ray**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &ray;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)raycastHits);
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxDistance;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &mask;
		*(QueryTriggerInteraction**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &queryTriggerInteraction;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_RaycastNonAlloc_Private_Static_Int32_PhysicsScene_Ray_Il2CppStructArray_1_RaycastHit_Single_Int32_QueryTriggerInteraction_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259802, XrefRangeEnd = 1259804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool Internal_RaycastTest_Injected([In] ref PhysicsScene physicsScene, [In] ref Ray ray, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)Unsafe.AsPointer(ref physicsScene);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ray);
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxDistance;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &layerMask;
		*(QueryTriggerInteraction**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &queryTriggerInteraction;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_RaycastTest_Injected_Private_Static_Boolean_byref_PhysicsScene_byref_Ray_Single_Int32_QueryTriggerInteraction_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259804, XrefRangeEnd = 1259806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool Internal_Raycast_Injected([In] ref PhysicsScene physicsScene, [In] ref Ray ray, float maxDistance, ref RaycastHit hit, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)Unsafe.AsPointer(ref physicsScene);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ray);
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxDistance;
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref hit);
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &layerMask;
		*(QueryTriggerInteraction**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &queryTriggerInteraction;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_Raycast_Injected_Private_Static_Boolean_byref_PhysicsScene_byref_Ray_Single_byref_RaycastHit_Int32_QueryTriggerInteraction_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259806, XrefRangeEnd = 1259808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int Internal_RaycastNonAlloc_Injected([In] ref PhysicsScene physicsScene, [In] ref Ray ray, ref ManagedSpanWrapper raycastHits, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)Unsafe.AsPointer(ref physicsScene);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ray);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref raycastHits);
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxDistance;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &mask;
		*(QueryTriggerInteraction**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &queryTriggerInteraction;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_RaycastNonAlloc_Injected_Private_Static_Int32_byref_PhysicsScene_byref_Ray_byref_ManagedSpanWrapper_Single_Int32_QueryTriggerInteraction_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PhysicsScene>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}

	public static bool operator !=(PhysicsScene lhs, PhysicsScene rhs)
	{
		return !(lhs == rhs);
	}

	public bool IsValid()
	{
		return IsValid_Internal(this);
	}

	public static bool IsValid_Internal(PhysicsScene physicsScene)
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

	public static bool IsEmpty_Internal(PhysicsScene physicsScene)
	{
		return IsEmpty_Internal_Injected(ref physicsScene);
	}

	public void Simulate(float step)
	{
		if (IsValid())
		{
			if (this == GetDefaultScene() && Physics.simulationMode != SimulationMode.Script)
			{
				Debug.LogWarning("PhysicsScene.Simulate(...) was called but simulation mode is not set to Script. You should set simulation mode to Script first before calling this function therefore the simulation was not run.");
			}
			else
			{
				Physics.Simulate_Internal(this, step, SimulationStage.All, SimulationOption.All);
			}
			return;
		}
		throw new Il2CppSystem.InvalidOperationException("Cannot simulate the physics scene as it is invalid.");
	}

	public void RunSimulationStages(float step, SimulationStage stages, [Optional] SimulationOption options)
	{
		if (!IsValid())
		{
			throw new Il2CppSystem.InvalidOperationException("Cannot simulate the physics scene as it is invalid.");
		}
		if (this == GetDefaultScene() && Physics.simulationMode != SimulationMode.Script)
		{
			Debug.LogWarning("PhysicsScene.Simulate(...) was called but simulation mode is not set to Script. You should set simulation mode to Script first before calling this function therefore the simulation was not run.");
		}
		else
		{
			Physics.Simulate_Internal(this, step, stages, options);
		}
	}

	public void InterpolateBodies()
	{
		if (!IsValid())
		{
			throw new Il2CppSystem.InvalidOperationException("Cannot interpolate the physics scene as it is invalid.");
		}
		if (this == Physics.defaultPhysicsScene)
		{
			Debug.LogWarning("PhysicsScene.InterpolateBodies() was called on the default Physics Scene. This is done automatically and the call will be ignored");
		}
		else
		{
			Physics.InterpolateBodies_Internal(this);
		}
	}

	public void ResetInterpolationPoses()
	{
		if (!IsValid())
		{
			throw new Il2CppSystem.InvalidOperationException("Cannot reset poses of the physics scene as it is invalid.");
		}
		if (this == Physics.defaultPhysicsScene)
		{
			Debug.LogWarning("PhysicsScene.ResetInterpolationPoses() was called on the default Physics Scene. This is done automatically and the call will be ignored");
		}
		else
		{
			Physics.ResetInterpolationPoses_Internal(this);
		}
	}

	public static bool Query_CapsuleCast(PhysicsScene physicsScene, Vector3 point1, Vector3 point2, float radius, Vector3 direction, float maxDistance, ref RaycastHit hitInfo, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
	{
		return Query_CapsuleCast_Injected(ref physicsScene, ref point1, ref point2, radius, ref direction, maxDistance, ref hitInfo, layerMask, queryTriggerInteraction);
	}

	public static bool Internal_CapsuleCast(PhysicsScene physicsScene, Vector3 point1, Vector3 point2, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
	{
		float magnitude = direction.magnitude;
		hitInfo = default(RaycastHit);
		if (magnitude > float.Epsilon)
		{
			Vector3 direction2 = direction / magnitude;
			return Query_CapsuleCast(physicsScene, point1, point2, radius, direction2, maxDistance, ref hitInfo, layerMask, queryTriggerInteraction);
		}
		return false;
	}

	public bool CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, out RaycastHit hitInfo, [Optional] float maxDistance, [Optional] int layerMask, [Optional] QueryTriggerInteraction queryTriggerInteraction)
	{
		return Internal_CapsuleCast(this, point1, point2, radius, direction, out hitInfo, maxDistance, layerMask, queryTriggerInteraction);
	}

	public unsafe static int Internal_CapsuleCastNonAlloc(PhysicsScene physicsScene, Vector3 p0, Vector3 p1, float radius, Vector3 direction, Il2CppStructArray<RaycastHit> raycastHits, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction)
	{
		//IL_0012: Expected O, but got Ref
		//IL_0019: Expected O, but got Ref
		//IL_0025: Expected O, but got Ref
		Unsafe.SkipInit(out Il2CppSystem.Span<RaycastHit> span);
		((Il2CppSystem.Span<RaycastHit>)(&span))._002Ector((Il2CppArrayBase<RaycastHit>)(object)raycastHits);
		int result;
		fixed (RaycastHit* begin = &((Il2CppSystem.Span<RaycastHit>)(&span)).GetPinnableReference())
		{
			ManagedSpanWrapper raycastHits2 = new ManagedSpanWrapper(begin, ((Il2CppSystem.Span<RaycastHit>)(&span)).Length);
			result = Internal_CapsuleCastNonAlloc_Injected(ref physicsScene, ref p0, ref p1, radius, ref direction, ref raycastHits2, maxDistance, mask, queryTriggerInteraction);
		}
		return result;
	}

	public int CapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, Il2CppStructArray<RaycastHit> results, [Optional] float maxDistance, [Optional] int layerMask, [Optional] QueryTriggerInteraction queryTriggerInteraction)
	{
		float magnitude = direction.magnitude;
		if (magnitude > float.Epsilon)
		{
			return Internal_CapsuleCastNonAlloc(this, point1, point2, radius, direction, results, maxDistance, layerMask, queryTriggerInteraction);
		}
		return 0;
	}

	public static int OverlapCapsuleNonAlloc_Internal(PhysicsScene physicsScene, Vector3 point0, Vector3 point1, float radius, Il2CppReferenceArray<Collider> results, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
	{
		return OverlapCapsuleNonAlloc_Internal_Injected(ref physicsScene, ref point0, ref point1, radius, results, layerMask, queryTriggerInteraction);
	}

	public int OverlapCapsule(Vector3 point0, Vector3 point1, float radius, Il2CppReferenceArray<Collider> results, [Optional] int layerMask, [Optional] QueryTriggerInteraction queryTriggerInteraction)
	{
		return OverlapCapsuleNonAlloc_Internal(this, point0, point1, radius, results, layerMask, queryTriggerInteraction);
	}

	public static bool Query_SphereCast(PhysicsScene physicsScene, Vector3 origin, float radius, Vector3 direction, float maxDistance, ref RaycastHit hitInfo, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
	{
		return Query_SphereCast_Injected(ref physicsScene, ref origin, radius, ref direction, maxDistance, ref hitInfo, layerMask, queryTriggerInteraction);
	}

	public static bool Internal_SphereCast(PhysicsScene physicsScene, Vector3 origin, float radius, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
	{
		float magnitude = direction.magnitude;
		hitInfo = default(RaycastHit);
		if (magnitude > float.Epsilon)
		{
			Vector3 direction2 = direction / magnitude;
			return Query_SphereCast(physicsScene, origin, radius, direction2, maxDistance, ref hitInfo, layerMask, queryTriggerInteraction);
		}
		return false;
	}

	public bool SphereCast(Vector3 origin, float radius, Vector3 direction, out RaycastHit hitInfo, [Optional] float maxDistance, [Optional] int layerMask, [Optional] QueryTriggerInteraction queryTriggerInteraction)
	{
		return Internal_SphereCast(this, origin, radius, direction, out hitInfo, maxDistance, layerMask, queryTriggerInteraction);
	}

	public unsafe static int Internal_SphereCastNonAlloc(PhysicsScene physicsScene, Vector3 origin, float radius, Vector3 direction, Il2CppStructArray<RaycastHit> raycastHits, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction)
	{
		//IL_0010: Expected O, but got Ref
		//IL_0017: Expected O, but got Ref
		//IL_0023: Expected O, but got Ref
		Unsafe.SkipInit(out Il2CppSystem.Span<RaycastHit> span);
		((Il2CppSystem.Span<RaycastHit>)(&span))._002Ector((Il2CppArrayBase<RaycastHit>)(object)raycastHits);
		int result;
		fixed (RaycastHit* begin = &((Il2CppSystem.Span<RaycastHit>)(&span)).GetPinnableReference())
		{
			ManagedSpanWrapper raycastHits2 = new ManagedSpanWrapper(begin, ((Il2CppSystem.Span<RaycastHit>)(&span)).Length);
			result = Internal_SphereCastNonAlloc_Injected(ref physicsScene, ref origin, radius, ref direction, ref raycastHits2, maxDistance, mask, queryTriggerInteraction);
		}
		return result;
	}

	public int SphereCast(Vector3 origin, float radius, Vector3 direction, Il2CppStructArray<RaycastHit> results, [Optional] float maxDistance, [Optional] int layerMask, [Optional] QueryTriggerInteraction queryTriggerInteraction)
	{
		float magnitude = direction.magnitude;
		if (magnitude > float.Epsilon)
		{
			return Internal_SphereCastNonAlloc(this, origin, radius, direction, results, maxDistance, layerMask, queryTriggerInteraction);
		}
		return 0;
	}

	public static int OverlapSphereNonAlloc_Internal(PhysicsScene physicsScene, Vector3 position, float radius, Il2CppReferenceArray<Collider> results, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
	{
		return OverlapSphereNonAlloc_Internal_Injected(ref physicsScene, ref position, radius, results, layerMask, queryTriggerInteraction);
	}

	public int OverlapSphere(Vector3 position, float radius, Il2CppReferenceArray<Collider> results, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
	{
		return OverlapSphereNonAlloc_Internal(this, position, radius, results, layerMask, queryTriggerInteraction);
	}

	public static bool Query_BoxCast(PhysicsScene physicsScene, Vector3 center, Vector3 halfExtents, Vector3 direction, Quaternion orientation, float maxDistance, ref RaycastHit outHit, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
	{
		return Query_BoxCast_Injected(ref physicsScene, ref center, ref halfExtents, ref direction, ref orientation, maxDistance, ref outHit, layerMask, queryTriggerInteraction);
	}

	public static bool Internal_BoxCast(PhysicsScene physicsScene, Vector3 center, Vector3 halfExtents, Quaternion orientation, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
	{
		float magnitude = direction.magnitude;
		hitInfo = default(RaycastHit);
		if (magnitude > float.Epsilon)
		{
			Vector3 direction2 = direction / magnitude;
			return Query_BoxCast(physicsScene, center, halfExtents, direction2, orientation, maxDistance, ref hitInfo, layerMask, queryTriggerInteraction);
		}
		return false;
	}

	public bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, out RaycastHit hitInfo, Quaternion orientation, [Optional] float maxDistance, [Optional] int layerMask, [Optional] QueryTriggerInteraction queryTriggerInteraction)
	{
		return Internal_BoxCast(this, center, halfExtents, orientation, direction, out hitInfo, maxDistance, layerMask, queryTriggerInteraction);
	}

	public bool BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, out RaycastHit hitInfo)
	{
		return Internal_BoxCast(this, center, halfExtents, Quaternion.identity, direction, out hitInfo, float.PositiveInfinity, -5, QueryTriggerInteraction.UseGlobal);
	}

	public static int OverlapBoxNonAlloc_Internal(PhysicsScene physicsScene, Vector3 center, Vector3 halfExtents, Il2CppReferenceArray<Collider> results, Quaternion orientation, int mask, QueryTriggerInteraction queryTriggerInteraction)
	{
		return OverlapBoxNonAlloc_Internal_Injected(ref physicsScene, ref center, ref halfExtents, results, ref orientation, mask, queryTriggerInteraction);
	}

	public int OverlapBox(Vector3 center, Vector3 halfExtents, Il2CppReferenceArray<Collider> results, Quaternion orientation, [Optional] int layerMask, [Optional] QueryTriggerInteraction queryTriggerInteraction)
	{
		return OverlapBoxNonAlloc_Internal(this, center, halfExtents, results, orientation, layerMask, queryTriggerInteraction);
	}

	public int OverlapBox(Vector3 center, Vector3 halfExtents, Il2CppReferenceArray<Collider> results)
	{
		return OverlapBoxNonAlloc_Internal(this, center, halfExtents, results, Quaternion.identity, -5, QueryTriggerInteraction.UseGlobal);
	}

	public unsafe static int Internal_BoxCastNonAlloc(PhysicsScene physicsScene, Vector3 center, Vector3 halfExtents, Vector3 direction, Il2CppStructArray<RaycastHit> raycastHits, Quaternion orientation, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction)
	{
		//IL_0011: Expected O, but got Ref
		//IL_0018: Expected O, but got Ref
		//IL_0024: Expected O, but got Ref
		Unsafe.SkipInit(out Il2CppSystem.Span<RaycastHit> span);
		((Il2CppSystem.Span<RaycastHit>)(&span))._002Ector((Il2CppArrayBase<RaycastHit>)(object)raycastHits);
		int result;
		fixed (RaycastHit* begin = &((Il2CppSystem.Span<RaycastHit>)(&span)).GetPinnableReference())
		{
			ManagedSpanWrapper raycastHits2 = new ManagedSpanWrapper(begin, ((Il2CppSystem.Span<RaycastHit>)(&span)).Length);
			result = Internal_BoxCastNonAlloc_Injected(ref physicsScene, ref center, ref halfExtents, ref direction, ref raycastHits2, ref orientation, maxDistance, mask, queryTriggerInteraction);
		}
		return result;
	}

	public int BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, Il2CppStructArray<RaycastHit> results, Quaternion orientation, [Optional] float maxDistance, [Optional] int layerMask, [Optional] QueryTriggerInteraction queryTriggerInteraction)
	{
		float magnitude = direction.magnitude;
		if (magnitude > float.Epsilon)
		{
			return Internal_BoxCastNonAlloc(this, center, halfExtents, direction, results, orientation, maxDistance, layerMask, queryTriggerInteraction);
		}
		return 0;
	}

	public int BoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, Il2CppStructArray<RaycastHit> results)
	{
		return BoxCast(center, halfExtents, direction, results, Quaternion.identity, float.PositiveInfinity, -5, QueryTriggerInteraction.UseGlobal);
	}

	public unsafe static bool IsValid_Internal_Injected([In] ref PhysicsScene physicsScene)
	{
		return IsValid_Internal_InjectedDelegateField((nint)Unsafe.AsPointer(ref physicsScene));
	}

	public unsafe static bool IsEmpty_Internal_Injected([In] ref PhysicsScene physicsScene)
	{
		return IsEmpty_Internal_InjectedDelegateField((nint)Unsafe.AsPointer(ref physicsScene));
	}

	public unsafe static bool Query_CapsuleCast_Injected([In] ref PhysicsScene physicsScene, [In] ref Vector3 point1, [In] ref Vector3 point2, float radius, [In] ref Vector3 direction, float maxDistance, ref RaycastHit hitInfo, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
	{
		return Query_CapsuleCast_InjectedDelegateField((nint)Unsafe.AsPointer(ref physicsScene), (nint)Unsafe.AsPointer(ref point1), (nint)Unsafe.AsPointer(ref point2), radius, (nint)Unsafe.AsPointer(ref direction), maxDistance, (nint)Unsafe.AsPointer(ref hitInfo), layerMask, queryTriggerInteraction);
	}

	public unsafe static int Internal_CapsuleCastNonAlloc_Injected([In] ref PhysicsScene physicsScene, [In] ref Vector3 p0, [In] ref Vector3 p1, float radius, [In] ref Vector3 direction, ref ManagedSpanWrapper raycastHits, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction)
	{
		return Internal_CapsuleCastNonAlloc_InjectedDelegateField((nint)Unsafe.AsPointer(ref physicsScene), (nint)Unsafe.AsPointer(ref p0), (nint)Unsafe.AsPointer(ref p1), radius, (nint)Unsafe.AsPointer(ref direction), (nint)Unsafe.AsPointer(ref raycastHits), maxDistance, mask, queryTriggerInteraction);
	}

	public unsafe static int OverlapCapsuleNonAlloc_Internal_Injected([In] ref PhysicsScene physicsScene, [In] ref Vector3 point0, [In] ref Vector3 point1, float radius, Il2CppReferenceArray<Collider> results, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
	{
		return OverlapCapsuleNonAlloc_Internal_InjectedDelegateField((nint)Unsafe.AsPointer(ref physicsScene), (nint)Unsafe.AsPointer(ref point0), (nint)Unsafe.AsPointer(ref point1), radius, IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)results), layerMask, queryTriggerInteraction);
	}

	public unsafe static bool Query_SphereCast_Injected([In] ref PhysicsScene physicsScene, [In] ref Vector3 origin, float radius, [In] ref Vector3 direction, float maxDistance, ref RaycastHit hitInfo, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
	{
		return Query_SphereCast_InjectedDelegateField((nint)Unsafe.AsPointer(ref physicsScene), (nint)Unsafe.AsPointer(ref origin), radius, (nint)Unsafe.AsPointer(ref direction), maxDistance, (nint)Unsafe.AsPointer(ref hitInfo), layerMask, queryTriggerInteraction);
	}

	public unsafe static int Internal_SphereCastNonAlloc_Injected([In] ref PhysicsScene physicsScene, [In] ref Vector3 origin, float radius, [In] ref Vector3 direction, ref ManagedSpanWrapper raycastHits, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction)
	{
		return Internal_SphereCastNonAlloc_InjectedDelegateField((nint)Unsafe.AsPointer(ref physicsScene), (nint)Unsafe.AsPointer(ref origin), radius, (nint)Unsafe.AsPointer(ref direction), (nint)Unsafe.AsPointer(ref raycastHits), maxDistance, mask, queryTriggerInteraction);
	}

	public unsafe static int OverlapSphereNonAlloc_Internal_Injected([In] ref PhysicsScene physicsScene, [In] ref Vector3 position, float radius, Il2CppReferenceArray<Collider> results, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
	{
		return OverlapSphereNonAlloc_Internal_InjectedDelegateField((nint)Unsafe.AsPointer(ref physicsScene), (nint)Unsafe.AsPointer(ref position), radius, IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)results), layerMask, queryTriggerInteraction);
	}

	public unsafe static bool Query_BoxCast_Injected([In] ref PhysicsScene physicsScene, [In] ref Vector3 center, [In] ref Vector3 halfExtents, [In] ref Vector3 direction, [In] ref Quaternion orientation, float maxDistance, ref RaycastHit outHit, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
	{
		return Query_BoxCast_InjectedDelegateField((nint)Unsafe.AsPointer(ref physicsScene), (nint)Unsafe.AsPointer(ref center), (nint)Unsafe.AsPointer(ref halfExtents), (nint)Unsafe.AsPointer(ref direction), (nint)Unsafe.AsPointer(ref orientation), maxDistance, (nint)Unsafe.AsPointer(ref outHit), layerMask, queryTriggerInteraction);
	}

	public unsafe static int OverlapBoxNonAlloc_Internal_Injected([In] ref PhysicsScene physicsScene, [In] ref Vector3 center, [In] ref Vector3 halfExtents, Il2CppReferenceArray<Collider> results, [In] ref Quaternion orientation, int mask, QueryTriggerInteraction queryTriggerInteraction)
	{
		return OverlapBoxNonAlloc_Internal_InjectedDelegateField((nint)Unsafe.AsPointer(ref physicsScene), (nint)Unsafe.AsPointer(ref center), (nint)Unsafe.AsPointer(ref halfExtents), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)results), (nint)Unsafe.AsPointer(ref orientation), mask, queryTriggerInteraction);
	}

	public unsafe static int Internal_BoxCastNonAlloc_Injected([In] ref PhysicsScene physicsScene, [In] ref Vector3 center, [In] ref Vector3 halfExtents, [In] ref Vector3 direction, ref ManagedSpanWrapper raycastHits, [In] ref Quaternion orientation, float maxDistance, int mask, QueryTriggerInteraction queryTriggerInteraction)
	{
		return Internal_BoxCastNonAlloc_InjectedDelegateField((nint)Unsafe.AsPointer(ref physicsScene), (nint)Unsafe.AsPointer(ref center), (nint)Unsafe.AsPointer(ref halfExtents), (nint)Unsafe.AsPointer(ref direction), (nint)Unsafe.AsPointer(ref raycastHits), (nint)Unsafe.AsPointer(ref orientation), maxDistance, mask, queryTriggerInteraction);
	}
}
