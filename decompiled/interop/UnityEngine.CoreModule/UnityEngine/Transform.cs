using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine.Bindings;

namespace UnityEngine;

public class Transform : Component
{
	public class Enumerator : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_outer;

		private static readonly System.IntPtr NativeFieldInfoPtr_currentIndex;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Transform_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0;

		public unsafe Transform outer
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_outer);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_outer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe int currentIndex
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentIndex);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentIndex)) = value;
			}
		}

		public unsafe virtual Il2CppSystem.Object Current
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1218775, XrefRangeEnd = 1218783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
			}
		}

		static Enumerator()
		{
			Il2CppClassPointerStore<Enumerator>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Transform>.NativeClassPtr, "Enumerator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Enumerator>.NativeClassPtr);
			NativeFieldInfoPtr_outer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerator>.NativeClassPtr, "outer");
			NativeFieldInfoPtr_currentIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Enumerator>.NativeClassPtr, "currentIndex");
			NativeMethodInfoPtr__ctor_Internal_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerator>.NativeClassPtr, 100666944);
			NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerator>.NativeClassPtr, 100666945);
			NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerator>.NativeClassPtr, 100666946);
			NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Enumerator>.NativeClassPtr, 100666947);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Enumerator(Transform outer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Enumerator>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)outer);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1218783, XrefRangeEnd = 1218786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(0)]
		public unsafe virtual void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public Enumerator(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private delegate void GetLocalEulerAngles_InjectedDelegate(System.IntPtr _unity_self, RotationOrder order, [Out] System.IntPtr ret);

	private delegate void SetLocalEulerAngles_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr euler, RotationOrder order);

	private delegate void SetLocalEulerHint_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr euler);

	private delegate int GetRotationOrderInternal_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void SetRotationOrderInternal_InjectedDelegate(System.IntPtr _unity_self, RotationOrder rotationOrder);

	private delegate void GetPositionAndRotation_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr position, [Out] System.IntPtr rotation);

	private delegate void GetLocalPositionAndRotation_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr localPosition, [Out] System.IntPtr localRotation);

	private delegate void TransformDirectionsInternal_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr directions, System.IntPtr transformedDirections);

	private delegate void InverseTransformDirectionsInternal_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr directions, System.IntPtr transformedDirections);

	private delegate void TransformVectorsInternal_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr vectors, System.IntPtr transformedVectors);

	private delegate void InverseTransformVectorsInternal_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr vectors, System.IntPtr transformedVectors);

	private delegate void TransformPointsInternal_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr positions, System.IntPtr transformedPositions);

	private delegate void InverseTransformPointsInternal_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr positions, System.IntPtr transformedPositions);

	private delegate void DetachChildren_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void MoveAfterSibling_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr transform, bool notifyEditorAndMarkDirty);

	private delegate void SendTransformChangedScale_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void RotateAround_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr axis, float angle);

	private delegate void RotateAroundLocal_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr axis, float angle);

	private delegate int GetChildCount_InjectedDelegate(System.IntPtr _unity_self);

	private delegate int internal_getHierarchyCapacity_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void internal_setHierarchyCapacity_InjectedDelegate(System.IntPtr _unity_self, int value);

	private delegate int internal_getHierarchyCount_InjectedDelegate(System.IntPtr _unity_self);

	private delegate bool IsNonUniformScaleTransform_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void SetConstrainProportionsScale_InjectedDelegate(System.IntPtr _unity_self, bool isLinked);

	private delegate bool IsConstrainProportionsScale_InjectedDelegate(System.IntPtr _unity_self);

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_position_Public_get_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_position_Public_set_Void_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_localPosition_Public_get_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_localPosition_Public_set_Void_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_eulerAngles_Public_get_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_eulerAngles_Public_set_Void_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_localEulerAngles_Public_get_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_localEulerAngles_Public_set_Void_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_right_Public_get_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_up_Public_get_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_forward_Public_get_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_forward_Public_set_Void_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_rotation_Public_get_Quaternion_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_rotation_Public_set_Void_Quaternion_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_localRotation_Public_get_Quaternion_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_localRotation_Public_set_Void_Quaternion_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_localScale_Public_get_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_localScale_Public_set_Void_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_parent_Public_get_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_parent_Public_set_Void_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_parentInternal_Internal_get_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_parentInternal_Internal_set_Void_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetParent_Private_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetParent_Public_Void_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetParent_Public_Void_Transform_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_worldToLocalMatrix_Public_get_Matrix4x4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_localToWorldMatrix_Public_get_Matrix4x4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetPositionAndRotation_Public_Void_Vector3_Quaternion_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetLocalPositionAndRotation_Public_Void_Vector3_Quaternion_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Translate_Public_Void_Vector3_Space_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Translate_Public_Void_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rotate_Public_Void_Vector3_Space_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rotate_Public_Void_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rotate_Public_Void_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RotateAroundInternal_Internal_Void_Vector3_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rotate_Public_Void_Vector3_Single_Space_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rotate_Public_Void_Vector3_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LookAt_Public_Void_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LookAt_Public_Void_Vector3_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LookAt_Public_Void_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_LookAt_Private_Void_Vector3_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TransformDirection_Public_Vector3_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InverseTransformDirection_Public_Vector3_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TransformVector_Public_Vector3_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InverseTransformVector_Public_Vector3_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TransformPoint_Public_Vector3_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InverseTransformPoint_Public_Vector3_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_root_Public_get_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRoot_Private_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_childCount_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetAsFirstSibling_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetAsLastSibling_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetSiblingIndex_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSiblingIndex_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindRelativeTransformWithPath_Private_Transform_String_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Find_Public_Transform_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_lossyScale_Public_get_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsChildOf_Public_Boolean_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_hasChanged_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_hasChanged_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetChild_Public_Transform_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_position_Injected_Private_Static_Void_IntPtr_byref_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_position_Injected_Private_Static_Void_IntPtr_byref_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_localPosition_Injected_Private_Static_Void_IntPtr_byref_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_localPosition_Injected_Private_Static_Void_IntPtr_byref_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_rotation_Injected_Private_Static_Void_IntPtr_byref_Quaternion_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_rotation_Injected_Private_Static_Void_IntPtr_byref_Quaternion_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_localRotation_Injected_Private_Static_Void_IntPtr_byref_Quaternion_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_localRotation_Injected_Private_Static_Void_IntPtr_byref_Quaternion_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_localScale_Injected_Private_Static_Void_IntPtr_byref_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_localScale_Injected_Private_Static_Void_IntPtr_byref_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetParent_Injected_Private_Static_IntPtr_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetParent_Injected_Private_Static_Void_IntPtr_IntPtr_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_worldToLocalMatrix_Injected_Private_Static_Void_IntPtr_byref_Matrix4x4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_localToWorldMatrix_Injected_Private_Static_Void_IntPtr_byref_Matrix4x4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetPositionAndRotation_Injected_Private_Static_Void_IntPtr_byref_Vector3_byref_Quaternion_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetLocalPositionAndRotation_Injected_Private_Static_Void_IntPtr_byref_Vector3_byref_Quaternion_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RotateAroundInternal_Injected_Private_Static_Void_IntPtr_byref_Vector3_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_LookAt_Injected_Private_Static_Void_IntPtr_byref_Vector3_byref_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TransformDirection_Injected_Private_Static_Void_IntPtr_byref_Vector3_byref_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InverseTransformDirection_Injected_Private_Static_Void_IntPtr_byref_Vector3_byref_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TransformVector_Injected_Private_Static_Void_IntPtr_byref_Vector3_byref_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InverseTransformVector_Injected_Private_Static_Void_IntPtr_byref_Vector3_byref_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TransformPoint_Injected_Private_Static_Void_IntPtr_byref_Vector3_byref_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InverseTransformPoint_Injected_Private_Static_Void_IntPtr_byref_Vector3_byref_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRoot_Injected_Private_Static_IntPtr_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_childCount_Injected_Private_Static_Int32_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetAsFirstSibling_Injected_Private_Static_Void_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetAsLastSibling_Injected_Private_Static_Void_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetSiblingIndex_Injected_Private_Static_Void_IntPtr_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSiblingIndex_Injected_Private_Static_Int32_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindRelativeTransformWithPath_Injected_Private_Static_IntPtr_IntPtr_byref_ManagedSpanWrapper_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_lossyScale_Injected_Private_Static_Void_IntPtr_byref_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsChildOf_Injected_Private_Static_Boolean_IntPtr_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_hasChanged_Injected_Private_Static_Boolean_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_hasChanged_Injected_Private_Static_Void_IntPtr_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetChild_Injected_Private_Static_IntPtr_IntPtr_Int32_0;

	private static readonly GetLocalEulerAngles_InjectedDelegate GetLocalEulerAngles_InjectedDelegateField;

	private static readonly SetLocalEulerAngles_InjectedDelegate SetLocalEulerAngles_InjectedDelegateField;

	private static readonly SetLocalEulerHint_InjectedDelegate SetLocalEulerHint_InjectedDelegateField;

	private static readonly GetRotationOrderInternal_InjectedDelegate GetRotationOrderInternal_InjectedDelegateField;

	private static readonly SetRotationOrderInternal_InjectedDelegate SetRotationOrderInternal_InjectedDelegateField;

	private static readonly GetPositionAndRotation_InjectedDelegate GetPositionAndRotation_InjectedDelegateField;

	private static readonly GetLocalPositionAndRotation_InjectedDelegate GetLocalPositionAndRotation_InjectedDelegateField;

	private static readonly TransformDirectionsInternal_InjectedDelegate TransformDirectionsInternal_InjectedDelegateField;

	private static readonly InverseTransformDirectionsInternal_InjectedDelegate InverseTransformDirectionsInternal_InjectedDelegateField;

	private static readonly TransformVectorsInternal_InjectedDelegate TransformVectorsInternal_InjectedDelegateField;

	private static readonly InverseTransformVectorsInternal_InjectedDelegate InverseTransformVectorsInternal_InjectedDelegateField;

	private static readonly TransformPointsInternal_InjectedDelegate TransformPointsInternal_InjectedDelegateField;

	private static readonly InverseTransformPointsInternal_InjectedDelegate InverseTransformPointsInternal_InjectedDelegateField;

	private static readonly DetachChildren_InjectedDelegate DetachChildren_InjectedDelegateField;

	private static readonly MoveAfterSibling_InjectedDelegate MoveAfterSibling_InjectedDelegateField;

	private static readonly SendTransformChangedScale_InjectedDelegate SendTransformChangedScale_InjectedDelegateField;

	private static readonly RotateAround_InjectedDelegate RotateAround_InjectedDelegateField;

	private static readonly RotateAroundLocal_InjectedDelegate RotateAroundLocal_InjectedDelegateField;

	private static readonly GetChildCount_InjectedDelegate GetChildCount_InjectedDelegateField;

	private static readonly internal_getHierarchyCapacity_InjectedDelegate internal_getHierarchyCapacity_InjectedDelegateField;

	private static readonly internal_setHierarchyCapacity_InjectedDelegate internal_setHierarchyCapacity_InjectedDelegateField;

	private static readonly internal_getHierarchyCount_InjectedDelegate internal_getHierarchyCount_InjectedDelegateField;

	private static readonly IsNonUniformScaleTransform_InjectedDelegate IsNonUniformScaleTransform_InjectedDelegateField;

	private static readonly SetConstrainProportionsScale_InjectedDelegate SetConstrainProportionsScale_InjectedDelegateField;

	private static readonly IsConstrainProportionsScale_InjectedDelegate IsConstrainProportionsScale_InjectedDelegateField;

	public unsafe Vector3 position
	{
		[CallerCount(460)]
		[CachedScanResults(RefRangeStart = 1218789, RefRangeEnd = 1219249, XrefRangeStart = 1218786, XrefRangeEnd = 1218789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_position_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(208)]
		[CachedScanResults(RefRangeStart = 1219252, RefRangeEnd = 1219460, XrefRangeStart = 1219249, XrefRangeEnd = 1219252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	public unsafe Vector3 localPosition
	{
		[CallerCount(81)]
		[CachedScanResults(RefRangeStart = 1219463, RefRangeEnd = 1219544, XrefRangeStart = 1219460, XrefRangeEnd = 1219463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_localPosition_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(143)]
		[CachedScanResults(RefRangeStart = 1219547, RefRangeEnd = 1219690, XrefRangeStart = 1219544, XrefRangeEnd = 1219547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_localPosition_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe Vector3 eulerAngles
	{
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 1219695, RefRangeEnd = 1219705, XrefRangeStart = 1219690, XrefRangeEnd = 1219695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_eulerAngles_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 1219709, RefRangeEnd = 1219718, XrefRangeStart = 1219705, XrefRangeEnd = 1219709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_eulerAngles_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe Vector3 localEulerAngles
	{
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 1219723, RefRangeEnd = 1219734, XrefRangeStart = 1219718, XrefRangeEnd = 1219723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_localEulerAngles_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(24)]
		[CachedScanResults(RefRangeStart = 1219738, RefRangeEnd = 1219762, XrefRangeStart = 1219734, XrefRangeEnd = 1219738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_localEulerAngles_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe Vector3 right
	{
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1219768, RefRangeEnd = 1219772, XrefRangeStart = 1219762, XrefRangeEnd = 1219768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_right_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			rotation = Quaternion.FromToRotation(Vector3.right, value);
		}
	}

	public unsafe Vector3 up
	{
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1219778, RefRangeEnd = 1219786, XrefRangeStart = 1219772, XrefRangeEnd = 1219778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_up_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			rotation = Quaternion.FromToRotation(Vector3.up, value);
		}
	}

	public unsafe Vector3 forward
	{
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 1219792, RefRangeEnd = 1219811, XrefRangeStart = 1219786, XrefRangeEnd = 1219792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_forward_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1219815, RefRangeEnd = 1219816, XrefRangeStart = 1219811, XrefRangeEnd = 1219815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_forward_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe Quaternion rotation
	{
		[CallerCount(131)]
		[CachedScanResults(RefRangeStart = 1219819, RefRangeEnd = 1219950, XrefRangeStart = 1219816, XrefRangeEnd = 1219819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_rotation_Public_get_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Quaternion*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(103)]
		[CachedScanResults(RefRangeStart = 1219953, RefRangeEnd = 1220056, XrefRangeStart = 1219950, XrefRangeEnd = 1219953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	public unsafe Quaternion localRotation
	{
		[CallerCount(24)]
		[CachedScanResults(RefRangeStart = 1220059, RefRangeEnd = 1220083, XrefRangeStart = 1220056, XrefRangeEnd = 1220059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_localRotation_Public_get_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Quaternion*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(77)]
		[CachedScanResults(RefRangeStart = 1220086, RefRangeEnd = 1220163, XrefRangeStart = 1220083, XrefRangeEnd = 1220086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_localRotation_Public_set_Void_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe Vector3 localScale
	{
		[CallerCount(88)]
		[CachedScanResults(RefRangeStart = 1220166, RefRangeEnd = 1220254, XrefRangeStart = 1220163, XrefRangeEnd = 1220166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_localScale_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(270)]
		[CachedScanResults(RefRangeStart = 1220257, RefRangeEnd = 1220527, XrefRangeStart = 1220254, XrefRangeEnd = 1220257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_localScale_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe Transform parent
	{
		[CallerCount(264)]
		[CachedScanResults(RefRangeStart = 1220535, RefRangeEnd = 1220799, XrefRangeStart = 1220527, XrefRangeEnd = 1220535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_parent_Public_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
		}
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1220815, RefRangeEnd = 1220819, XrefRangeStart = 1220799, XrefRangeEnd = 1220815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_parent_Public_set_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe Transform parentInternal
	{
		[CallerCount(264)]
		[CachedScanResults(RefRangeStart = 1220535, RefRangeEnd = 1220799, XrefRangeStart = 1220535, XrefRangeEnd = 1220799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_parentInternal_Internal_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
		}
		[CallerCount(71)]
		[CachedScanResults(RefRangeStart = 1220828, RefRangeEnd = 1220899, XrefRangeStart = 1220819, XrefRangeEnd = 1220828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_parentInternal_Internal_set_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe Matrix4x4 worldToLocalMatrix
	{
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 1221077, RefRangeEnd = 1221093, XrefRangeStart = 1221074, XrefRangeEnd = 1221077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_worldToLocalMatrix_Public_get_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Matrix4x4*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe Matrix4x4 localToWorldMatrix
	{
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 1221096, RefRangeEnd = 1221114, XrefRangeStart = 1221093, XrefRangeEnd = 1221096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_localToWorldMatrix_Public_get_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Matrix4x4*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe Transform root
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1221336, RefRangeEnd = 1221338, XrefRangeStart = 1221328, XrefRangeEnd = 1221336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_root_Public_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
		}
	}

	public unsafe int childCount
	{
		[CallerCount(95)]
		[CachedScanResults(RefRangeStart = 1221343, RefRangeEnd = 1221438, XrefRangeStart = 1221338, XrefRangeEnd = 1221343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_childCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe Vector3 lossyScale
	{
		[CallerCount(55)]
		[CachedScanResults(RefRangeStart = 1221594, RefRangeEnd = 1221649, XrefRangeStart = 1221591, XrefRangeEnd = 1221594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_lossyScale_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool hasChanged
	{
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1221671, RefRangeEnd = 1221675, XrefRangeStart = 1221666, XrefRangeEnd = 1221671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_hasChanged_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1221680, RefRangeEnd = 1221683, XrefRangeStart = 1221675, XrefRangeEnd = 1221680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_hasChanged_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public RotationOrder rotationOrder
	{
		get
		{
			return (RotationOrder)GetRotationOrderInternal();
		}
		set
		{
			SetRotationOrderInternal(value);
		}
	}

	public int hierarchyCapacity
	{
		get
		{
			return internal_getHierarchyCapacity();
		}
		set
		{
			internal_setHierarchyCapacity(value);
		}
	}

	public int hierarchyCount => internal_getHierarchyCount();

	public bool constrainProportionsScale
	{
		get
		{
			return IsConstrainProportionsScale();
		}
		set
		{
			SetConstrainProportionsScale(value);
		}
	}

	static Transform()
	{
		Il2CppClassPointerStore<Transform>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Transform");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Transform>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666845);
		NativeMethodInfoPtr_get_position_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666846);
		NativeMethodInfoPtr_set_position_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666847);
		NativeMethodInfoPtr_get_localPosition_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666848);
		NativeMethodInfoPtr_set_localPosition_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666849);
		NativeMethodInfoPtr_get_eulerAngles_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666850);
		NativeMethodInfoPtr_set_eulerAngles_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666851);
		NativeMethodInfoPtr_get_localEulerAngles_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666852);
		NativeMethodInfoPtr_set_localEulerAngles_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666853);
		NativeMethodInfoPtr_get_right_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666854);
		NativeMethodInfoPtr_get_up_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666855);
		NativeMethodInfoPtr_get_forward_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666856);
		NativeMethodInfoPtr_set_forward_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666857);
		NativeMethodInfoPtr_get_rotation_Public_get_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666858);
		NativeMethodInfoPtr_set_rotation_Public_set_Void_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666859);
		NativeMethodInfoPtr_get_localRotation_Public_get_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666860);
		NativeMethodInfoPtr_set_localRotation_Public_set_Void_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666861);
		NativeMethodInfoPtr_get_localScale_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666862);
		NativeMethodInfoPtr_set_localScale_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666863);
		NativeMethodInfoPtr_get_parent_Public_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666864);
		NativeMethodInfoPtr_set_parent_Public_set_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666865);
		NativeMethodInfoPtr_get_parentInternal_Internal_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666866);
		NativeMethodInfoPtr_set_parentInternal_Internal_set_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666867);
		NativeMethodInfoPtr_GetParent_Private_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666868);
		NativeMethodInfoPtr_SetParent_Public_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666869);
		NativeMethodInfoPtr_SetParent_Public_Void_Transform_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666870);
		NativeMethodInfoPtr_get_worldToLocalMatrix_Public_get_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666871);
		NativeMethodInfoPtr_get_localToWorldMatrix_Public_get_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666872);
		NativeMethodInfoPtr_SetPositionAndRotation_Public_Void_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666873);
		NativeMethodInfoPtr_SetLocalPositionAndRotation_Public_Void_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666874);
		NativeMethodInfoPtr_Translate_Public_Void_Vector3_Space_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666875);
		NativeMethodInfoPtr_Translate_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666876);
		NativeMethodInfoPtr_Rotate_Public_Void_Vector3_Space_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666877);
		NativeMethodInfoPtr_Rotate_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666878);
		NativeMethodInfoPtr_Rotate_Public_Void_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666879);
		NativeMethodInfoPtr_RotateAroundInternal_Internal_Void_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666880);
		NativeMethodInfoPtr_Rotate_Public_Void_Vector3_Single_Space_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666881);
		NativeMethodInfoPtr_Rotate_Public_Void_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666882);
		NativeMethodInfoPtr_LookAt_Public_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666883);
		NativeMethodInfoPtr_LookAt_Public_Void_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666884);
		NativeMethodInfoPtr_LookAt_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666885);
		NativeMethodInfoPtr_Internal_LookAt_Private_Void_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666886);
		NativeMethodInfoPtr_TransformDirection_Public_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666887);
		NativeMethodInfoPtr_InverseTransformDirection_Public_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666888);
		NativeMethodInfoPtr_TransformVector_Public_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666889);
		NativeMethodInfoPtr_InverseTransformVector_Public_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666890);
		NativeMethodInfoPtr_TransformPoint_Public_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666891);
		NativeMethodInfoPtr_InverseTransformPoint_Public_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666892);
		NativeMethodInfoPtr_get_root_Public_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666893);
		NativeMethodInfoPtr_GetRoot_Private_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666894);
		NativeMethodInfoPtr_get_childCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666895);
		NativeMethodInfoPtr_SetAsFirstSibling_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666896);
		NativeMethodInfoPtr_SetAsLastSibling_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666897);
		NativeMethodInfoPtr_SetSiblingIndex_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666898);
		NativeMethodInfoPtr_GetSiblingIndex_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666899);
		NativeMethodInfoPtr_FindRelativeTransformWithPath_Private_Transform_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666900);
		NativeMethodInfoPtr_Find_Public_Transform_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666901);
		NativeMethodInfoPtr_get_lossyScale_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666902);
		NativeMethodInfoPtr_IsChildOf_Public_Boolean_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666903);
		NativeMethodInfoPtr_get_hasChanged_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666904);
		NativeMethodInfoPtr_set_hasChanged_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666905);
		NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666906);
		NativeMethodInfoPtr_GetChild_Public_Transform_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666907);
		NativeMethodInfoPtr_get_position_Injected_Private_Static_Void_IntPtr_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666908);
		NativeMethodInfoPtr_set_position_Injected_Private_Static_Void_IntPtr_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666909);
		NativeMethodInfoPtr_get_localPosition_Injected_Private_Static_Void_IntPtr_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666910);
		NativeMethodInfoPtr_set_localPosition_Injected_Private_Static_Void_IntPtr_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666911);
		NativeMethodInfoPtr_get_rotation_Injected_Private_Static_Void_IntPtr_byref_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666912);
		NativeMethodInfoPtr_set_rotation_Injected_Private_Static_Void_IntPtr_byref_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666913);
		NativeMethodInfoPtr_get_localRotation_Injected_Private_Static_Void_IntPtr_byref_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666914);
		NativeMethodInfoPtr_set_localRotation_Injected_Private_Static_Void_IntPtr_byref_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666915);
		NativeMethodInfoPtr_get_localScale_Injected_Private_Static_Void_IntPtr_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666916);
		NativeMethodInfoPtr_set_localScale_Injected_Private_Static_Void_IntPtr_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666917);
		NativeMethodInfoPtr_GetParent_Injected_Private_Static_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666918);
		NativeMethodInfoPtr_SetParent_Injected_Private_Static_Void_IntPtr_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666919);
		NativeMethodInfoPtr_get_worldToLocalMatrix_Injected_Private_Static_Void_IntPtr_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666920);
		NativeMethodInfoPtr_get_localToWorldMatrix_Injected_Private_Static_Void_IntPtr_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666921);
		NativeMethodInfoPtr_SetPositionAndRotation_Injected_Private_Static_Void_IntPtr_byref_Vector3_byref_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666922);
		NativeMethodInfoPtr_SetLocalPositionAndRotation_Injected_Private_Static_Void_IntPtr_byref_Vector3_byref_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666923);
		NativeMethodInfoPtr_RotateAroundInternal_Injected_Private_Static_Void_IntPtr_byref_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666924);
		NativeMethodInfoPtr_Internal_LookAt_Injected_Private_Static_Void_IntPtr_byref_Vector3_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666925);
		NativeMethodInfoPtr_TransformDirection_Injected_Private_Static_Void_IntPtr_byref_Vector3_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666926);
		NativeMethodInfoPtr_InverseTransformDirection_Injected_Private_Static_Void_IntPtr_byref_Vector3_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666927);
		NativeMethodInfoPtr_TransformVector_Injected_Private_Static_Void_IntPtr_byref_Vector3_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666928);
		NativeMethodInfoPtr_InverseTransformVector_Injected_Private_Static_Void_IntPtr_byref_Vector3_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666929);
		NativeMethodInfoPtr_TransformPoint_Injected_Private_Static_Void_IntPtr_byref_Vector3_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666930);
		NativeMethodInfoPtr_InverseTransformPoint_Injected_Private_Static_Void_IntPtr_byref_Vector3_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666931);
		NativeMethodInfoPtr_GetRoot_Injected_Private_Static_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666932);
		NativeMethodInfoPtr_get_childCount_Injected_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666933);
		NativeMethodInfoPtr_SetAsFirstSibling_Injected_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666934);
		NativeMethodInfoPtr_SetAsLastSibling_Injected_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666935);
		NativeMethodInfoPtr_SetSiblingIndex_Injected_Private_Static_Void_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666936);
		NativeMethodInfoPtr_GetSiblingIndex_Injected_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666937);
		NativeMethodInfoPtr_FindRelativeTransformWithPath_Injected_Private_Static_IntPtr_IntPtr_byref_ManagedSpanWrapper_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666938);
		NativeMethodInfoPtr_get_lossyScale_Injected_Private_Static_Void_IntPtr_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666939);
		NativeMethodInfoPtr_IsChildOf_Injected_Private_Static_Boolean_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666940);
		NativeMethodInfoPtr_get_hasChanged_Injected_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666941);
		NativeMethodInfoPtr_set_hasChanged_Injected_Private_Static_Void_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666942);
		NativeMethodInfoPtr_GetChild_Injected_Private_Static_IntPtr_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Transform>.NativeClassPtr, 100666943);
		GetLocalEulerAngles_InjectedDelegateField = IL2CPP.ResolveICall<GetLocalEulerAngles_InjectedDelegate>("UnityEngine.Transform::GetLocalEulerAngles_Injected");
		SetLocalEulerAngles_InjectedDelegateField = IL2CPP.ResolveICall<SetLocalEulerAngles_InjectedDelegate>("UnityEngine.Transform::SetLocalEulerAngles_Injected");
		SetLocalEulerHint_InjectedDelegateField = IL2CPP.ResolveICall<SetLocalEulerHint_InjectedDelegate>("UnityEngine.Transform::SetLocalEulerHint_Injected");
		GetRotationOrderInternal_InjectedDelegateField = IL2CPP.ResolveICall<GetRotationOrderInternal_InjectedDelegate>("UnityEngine.Transform::GetRotationOrderInternal_Injected");
		SetRotationOrderInternal_InjectedDelegateField = IL2CPP.ResolveICall<SetRotationOrderInternal_InjectedDelegate>("UnityEngine.Transform::SetRotationOrderInternal_Injected");
		GetPositionAndRotation_InjectedDelegateField = IL2CPP.ResolveICall<GetPositionAndRotation_InjectedDelegate>("UnityEngine.Transform::GetPositionAndRotation_Injected");
		GetLocalPositionAndRotation_InjectedDelegateField = IL2CPP.ResolveICall<GetLocalPositionAndRotation_InjectedDelegate>("UnityEngine.Transform::GetLocalPositionAndRotation_Injected");
		TransformDirectionsInternal_InjectedDelegateField = IL2CPP.ResolveICall<TransformDirectionsInternal_InjectedDelegate>("UnityEngine.Transform::TransformDirectionsInternal_Injected");
		InverseTransformDirectionsInternal_InjectedDelegateField = IL2CPP.ResolveICall<InverseTransformDirectionsInternal_InjectedDelegate>("UnityEngine.Transform::InverseTransformDirectionsInternal_Injected");
		TransformVectorsInternal_InjectedDelegateField = IL2CPP.ResolveICall<TransformVectorsInternal_InjectedDelegate>("UnityEngine.Transform::TransformVectorsInternal_Injected");
		InverseTransformVectorsInternal_InjectedDelegateField = IL2CPP.ResolveICall<InverseTransformVectorsInternal_InjectedDelegate>("UnityEngine.Transform::InverseTransformVectorsInternal_Injected");
		TransformPointsInternal_InjectedDelegateField = IL2CPP.ResolveICall<TransformPointsInternal_InjectedDelegate>("UnityEngine.Transform::TransformPointsInternal_Injected");
		InverseTransformPointsInternal_InjectedDelegateField = IL2CPP.ResolveICall<InverseTransformPointsInternal_InjectedDelegate>("UnityEngine.Transform::InverseTransformPointsInternal_Injected");
		DetachChildren_InjectedDelegateField = IL2CPP.ResolveICall<DetachChildren_InjectedDelegate>("UnityEngine.Transform::DetachChildren_Injected");
		MoveAfterSibling_InjectedDelegateField = IL2CPP.ResolveICall<MoveAfterSibling_InjectedDelegate>("UnityEngine.Transform::MoveAfterSibling_Injected");
		SendTransformChangedScale_InjectedDelegateField = IL2CPP.ResolveICall<SendTransformChangedScale_InjectedDelegate>("UnityEngine.Transform::SendTransformChangedScale_Injected");
		RotateAround_InjectedDelegateField = IL2CPP.ResolveICall<RotateAround_InjectedDelegate>("UnityEngine.Transform::RotateAround_Injected");
		RotateAroundLocal_InjectedDelegateField = IL2CPP.ResolveICall<RotateAroundLocal_InjectedDelegate>("UnityEngine.Transform::RotateAroundLocal_Injected");
		GetChildCount_InjectedDelegateField = IL2CPP.ResolveICall<GetChildCount_InjectedDelegate>("UnityEngine.Transform::GetChildCount_Injected");
		internal_getHierarchyCapacity_InjectedDelegateField = IL2CPP.ResolveICall<internal_getHierarchyCapacity_InjectedDelegate>("UnityEngine.Transform::internal_getHierarchyCapacity_Injected");
		internal_setHierarchyCapacity_InjectedDelegateField = IL2CPP.ResolveICall<internal_setHierarchyCapacity_InjectedDelegate>("UnityEngine.Transform::internal_setHierarchyCapacity_Injected");
		internal_getHierarchyCount_InjectedDelegateField = IL2CPP.ResolveICall<internal_getHierarchyCount_InjectedDelegate>("UnityEngine.Transform::internal_getHierarchyCount_Injected");
		IsNonUniformScaleTransform_InjectedDelegateField = IL2CPP.ResolveICall<IsNonUniformScaleTransform_InjectedDelegate>("UnityEngine.Transform::IsNonUniformScaleTransform_Injected");
		SetConstrainProportionsScale_InjectedDelegateField = IL2CPP.ResolveICall<SetConstrainProportionsScale_InjectedDelegate>("UnityEngine.Transform::SetConstrainProportionsScale_Injected");
		IsConstrainProportionsScale_InjectedDelegateField = IL2CPP.ResolveICall<IsConstrainProportionsScale_InjectedDelegate>("UnityEngine.Transform::IsConstrainProportionsScale_Injected");
	}

	[CallerCount(646)]
	[CachedScanResults(RefRangeStart = 1152221, RefRangeEnd = 1152867, XrefRangeStart = 1152221, XrefRangeEnd = 1152867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Transform()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Transform>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(264)]
	[CachedScanResults(RefRangeStart = 1220535, RefRangeEnd = 1220799, XrefRangeStart = 1220535, XrefRangeEnd = 1220799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Transform GetParent()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetParent_Private_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
	}

	[CallerCount(71)]
	[CachedScanResults(RefRangeStart = 1220828, RefRangeEnd = 1220899, XrefRangeStart = 1220828, XrefRangeEnd = 1220899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetParent(Transform p)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)p);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetParent_Public_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(166)]
	[CachedScanResults(RefRangeStart = 1220908, RefRangeEnd = 1221074, XrefRangeStart = 1220899, XrefRangeEnd = 1220908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetParent(Transform parent, bool worldPositionStays)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parent);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &worldPositionStays;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetParent_Public_Void_Transform_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 1221117, RefRangeEnd = 1221123, XrefRangeStart = 1221114, XrefRangeEnd = 1221117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetPositionAndRotation(Vector3 position, Quaternion rotation)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&position);
		*(Quaternion**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &rotation;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetPositionAndRotation_Public_Void_Vector3_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221123, XrefRangeEnd = 1221126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetLocalPositionAndRotation(Vector3 localPosition, Quaternion localRotation)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&localPosition);
		*(Quaternion**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &localRotation;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetLocalPositionAndRotation_Public_Void_Vector3_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1221135, RefRangeEnd = 1221136, XrefRangeStart = 1221126, XrefRangeEnd = 1221135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Translate(Vector3 translation, Space relativeTo)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&translation);
		*(Space**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &relativeTo;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Translate_Public_Void_Vector3_Space_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1221137, RefRangeEnd = 1221138, XrefRangeStart = 1221136, XrefRangeEnd = 1221137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Translate(Vector3 translation)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&translation);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Translate_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1221152, RefRangeEnd = 1221154, XrefRangeStart = 1221138, XrefRangeEnd = 1221152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Rotate(Vector3 eulers, Space relativeTo)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&eulers);
		*(Space**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &relativeTo;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rotate_Public_Void_Vector3_Space_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 1221155, RefRangeEnd = 1221162, XrefRangeStart = 1221154, XrefRangeEnd = 1221155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Rotate(Vector3 eulers)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&eulers);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rotate_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1221163, RefRangeEnd = 1221166, XrefRangeStart = 1221162, XrefRangeEnd = 1221163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Rotate(float xAngle, float yAngle, float zAngle)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&xAngle);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &yAngle;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &zAngle;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rotate_Public_Void_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221166, XrefRangeEnd = 1221169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RotateAroundInternal(Vector3 axis, float angle)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&axis);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &angle;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RotateAroundInternal_Internal_Void_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221169, XrefRangeEnd = 1221172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Rotate(Vector3 axis, float angle, Space relativeTo)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&axis);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &angle;
		*(Space**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &relativeTo;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rotate_Public_Void_Vector3_Single_Space_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1221179, RefRangeEnd = 1221181, XrefRangeStart = 1221172, XrefRangeEnd = 1221179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Rotate(Vector3 axis, float angle)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&axis);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &angle;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rotate_Public_Void_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1221198, RefRangeEnd = 1221199, XrefRangeStart = 1221181, XrefRangeEnd = 1221198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LookAt(Transform target)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)target);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LookAt_Public_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221199, XrefRangeEnd = 1221202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LookAt(Vector3 worldPosition, Vector3 worldUp)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&worldPosition);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &worldUp;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LookAt_Public_Void_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1221207, RefRangeEnd = 1221208, XrefRangeStart = 1221202, XrefRangeEnd = 1221207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LookAt(Vector3 worldPosition)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&worldPosition);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LookAt_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221208, XrefRangeEnd = 1221211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Internal_LookAt(Vector3 worldPosition, Vector3 worldUp)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&worldPosition);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &worldUp;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_LookAt_Private_Void_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1221214, RefRangeEnd = 1221215, XrefRangeStart = 1221211, XrefRangeEnd = 1221214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 TransformDirection(Vector3 direction)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&direction);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TransformDirection_Public_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221215, XrefRangeEnd = 1221218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 InverseTransformDirection(Vector3 direction)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&direction);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InverseTransformDirection_Public_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 1221221, RefRangeEnd = 1221229, XrefRangeStart = 1221218, XrefRangeEnd = 1221221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 TransformVector(Vector3 vector)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&vector);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TransformVector_Public_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1221232, RefRangeEnd = 1221235, XrefRangeStart = 1221229, XrefRangeEnd = 1221232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 InverseTransformVector(Vector3 vector)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&vector);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InverseTransformVector_Public_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(74)]
	[CachedScanResults(RefRangeStart = 1221238, RefRangeEnd = 1221312, XrefRangeStart = 1221235, XrefRangeEnd = 1221238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 TransformPoint(Vector3 position)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&position);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TransformPoint_Public_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(13)]
	[CachedScanResults(RefRangeStart = 1221315, RefRangeEnd = 1221328, XrefRangeStart = 1221312, XrefRangeEnd = 1221315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 InverseTransformPoint(Vector3 position)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&position);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InverseTransformPoint_Public_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1221336, RefRangeEnd = 1221338, XrefRangeStart = 1221336, XrefRangeEnd = 1221338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Transform GetRoot()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRoot_Private_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
	}

	[CallerCount(12)]
	[CachedScanResults(RefRangeStart = 1221443, RefRangeEnd = 1221455, XrefRangeStart = 1221438, XrefRangeEnd = 1221443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetAsFirstSibling()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetAsFirstSibling_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(37)]
	[CachedScanResults(RefRangeStart = 1221460, RefRangeEnd = 1221497, XrefRangeStart = 1221455, XrefRangeEnd = 1221460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetAsLastSibling()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetAsLastSibling_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(20)]
	[CachedScanResults(RefRangeStart = 1221502, RefRangeEnd = 1221522, XrefRangeStart = 1221497, XrefRangeEnd = 1221502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetSiblingIndex(int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&index);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetSiblingIndex_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 1221527, RefRangeEnd = 1221535, XrefRangeStart = 1221522, XrefRangeEnd = 1221527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetSiblingIndex()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSiblingIndex_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1221552, RefRangeEnd = 1221553, XrefRangeStart = 1221535, XrefRangeEnd = 1221552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Transform FindRelativeTransformWithPath(string path, bool isActiveOnly)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &isActiveOnly;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindRelativeTransformWithPath_Private_Transform_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
	}

	[CallerCount(31)]
	[CachedScanResults(RefRangeStart = 1221560, RefRangeEnd = 1221591, XrefRangeStart = 1221553, XrefRangeEnd = 1221560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Transform Find(string n)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(n);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Find_Public_Transform_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 1221659, RefRangeEnd = 1221666, XrefRangeStart = 1221649, XrefRangeEnd = 1221659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsChildOf(Transform parent)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)parent);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsChildOf_Public_Boolean_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(26)]
	[CachedScanResults(RefRangeStart = 1221688, RefRangeEnd = 1221714, XrefRangeStart = 1221683, XrefRangeEnd = 1221688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual IEnumerator GetEnumerator()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
	}

	[CallerCount(104)]
	[CachedScanResults(RefRangeStart = 1221722, RefRangeEnd = 1221826, XrefRangeStart = 1221714, XrefRangeEnd = 1221722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Transform GetChild(int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&index);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetChild_Public_Transform_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221826, XrefRangeEnd = 1221828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221828, XrefRangeEnd = 1221830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221830, XrefRangeEnd = 1221832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void get_localPosition_Injected(System.IntPtr _unity_self, out Vector3 ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_localPosition_Injected_Private_Static_Void_IntPtr_byref_Vector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221832, XrefRangeEnd = 1221834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_localPosition_Injected(System.IntPtr _unity_self, [In] ref Vector3 value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_localPosition_Injected_Private_Static_Void_IntPtr_byref_Vector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221834, XrefRangeEnd = 1221836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221836, XrefRangeEnd = 1221838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221838, XrefRangeEnd = 1221840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void get_localRotation_Injected(System.IntPtr _unity_self, out Quaternion ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_localRotation_Injected_Private_Static_Void_IntPtr_byref_Quaternion_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221840, XrefRangeEnd = 1221842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_localRotation_Injected(System.IntPtr _unity_self, [In] ref Quaternion value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_localRotation_Injected_Private_Static_Void_IntPtr_byref_Quaternion_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221842, XrefRangeEnd = 1221844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void get_localScale_Injected(System.IntPtr _unity_self, out Vector3 ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_localScale_Injected_Private_Static_Void_IntPtr_byref_Vector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221844, XrefRangeEnd = 1221846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_localScale_Injected(System.IntPtr _unity_self, [In] ref Vector3 value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_localScale_Injected_Private_Static_Void_IntPtr_byref_Vector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221846, XrefRangeEnd = 1221848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr GetParent_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetParent_Injected_Private_Static_IntPtr_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221848, XrefRangeEnd = 1221850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetParent_Injected(System.IntPtr _unity_self, System.IntPtr parent, bool worldPositionStays)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&_unity_self);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &parent;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &worldPositionStays;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetParent_Injected_Private_Static_Void_IntPtr_IntPtr_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221850, XrefRangeEnd = 1221852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void get_worldToLocalMatrix_Injected(System.IntPtr _unity_self, out Matrix4x4 ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_worldToLocalMatrix_Injected_Private_Static_Void_IntPtr_byref_Matrix4x4_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221852, XrefRangeEnd = 1221854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void get_localToWorldMatrix_Injected(System.IntPtr _unity_self, out Matrix4x4 ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_localToWorldMatrix_Injected_Private_Static_Void_IntPtr_byref_Matrix4x4_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221854, XrefRangeEnd = 1221856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetPositionAndRotation_Injected(System.IntPtr _unity_self, [In] ref Vector3 position, [In] ref Quaternion rotation)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref position);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref rotation);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetPositionAndRotation_Injected_Private_Static_Void_IntPtr_byref_Vector3_byref_Quaternion_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221856, XrefRangeEnd = 1221858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetLocalPositionAndRotation_Injected(System.IntPtr _unity_self, [In] ref Vector3 localPosition, [In] ref Quaternion localRotation)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref localPosition);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref localRotation);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetLocalPositionAndRotation_Injected_Private_Static_Void_IntPtr_byref_Vector3_byref_Quaternion_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221858, XrefRangeEnd = 1221860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RotateAroundInternal_Injected(System.IntPtr _unity_self, [In] ref Vector3 axis, float angle)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref axis);
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &angle;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RotateAroundInternal_Injected_Private_Static_Void_IntPtr_byref_Vector3_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221860, XrefRangeEnd = 1221862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Internal_LookAt_Injected(System.IntPtr _unity_self, [In] ref Vector3 worldPosition, [In] ref Vector3 worldUp)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref worldPosition);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref worldUp);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_LookAt_Injected_Private_Static_Void_IntPtr_byref_Vector3_byref_Vector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221862, XrefRangeEnd = 1221864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void TransformDirection_Injected(System.IntPtr _unity_self, [In] ref Vector3 direction, out Vector3 ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref direction);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TransformDirection_Injected_Private_Static_Void_IntPtr_byref_Vector3_byref_Vector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221864, XrefRangeEnd = 1221866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InverseTransformDirection_Injected(System.IntPtr _unity_self, [In] ref Vector3 direction, out Vector3 ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref direction);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InverseTransformDirection_Injected_Private_Static_Void_IntPtr_byref_Vector3_byref_Vector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221866, XrefRangeEnd = 1221868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void TransformVector_Injected(System.IntPtr _unity_self, [In] ref Vector3 vector, out Vector3 ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref vector);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TransformVector_Injected_Private_Static_Void_IntPtr_byref_Vector3_byref_Vector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221868, XrefRangeEnd = 1221870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InverseTransformVector_Injected(System.IntPtr _unity_self, [In] ref Vector3 vector, out Vector3 ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref vector);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InverseTransformVector_Injected_Private_Static_Void_IntPtr_byref_Vector3_byref_Vector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221870, XrefRangeEnd = 1221872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void TransformPoint_Injected(System.IntPtr _unity_self, [In] ref Vector3 position, out Vector3 ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref position);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TransformPoint_Injected_Private_Static_Void_IntPtr_byref_Vector3_byref_Vector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221872, XrefRangeEnd = 1221874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InverseTransformPoint_Injected(System.IntPtr _unity_self, [In] ref Vector3 position, out Vector3 ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref position);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InverseTransformPoint_Injected_Private_Static_Void_IntPtr_byref_Vector3_byref_Vector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221874, XrefRangeEnd = 1221876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr GetRoot_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRoot_Injected_Private_Static_IntPtr_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221876, XrefRangeEnd = 1221878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int get_childCount_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_childCount_Injected_Private_Static_Int32_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221878, XrefRangeEnd = 1221880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetAsFirstSibling_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetAsFirstSibling_Injected_Private_Static_Void_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221880, XrefRangeEnd = 1221882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetAsLastSibling_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetAsLastSibling_Injected_Private_Static_Void_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221882, XrefRangeEnd = 1221884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetSiblingIndex_Injected(System.IntPtr _unity_self, int index)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetSiblingIndex_Injected_Private_Static_Void_IntPtr_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221884, XrefRangeEnd = 1221886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetSiblingIndex_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSiblingIndex_Injected_Private_Static_Int32_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221886, XrefRangeEnd = 1221888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr FindRelativeTransformWithPath_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper path, bool isActiveOnly)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref path);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &isActiveOnly;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindRelativeTransformWithPath_Injected_Private_Static_IntPtr_IntPtr_byref_ManagedSpanWrapper_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221888, XrefRangeEnd = 1221890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void get_lossyScale_Injected(System.IntPtr _unity_self, out Vector3 ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_lossyScale_Injected_Private_Static_Void_IntPtr_byref_Vector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221890, XrefRangeEnd = 1221892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsChildOf_Injected(System.IntPtr _unity_self, System.IntPtr parent)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &parent;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsChildOf_Injected_Private_Static_Boolean_IntPtr_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221892, XrefRangeEnd = 1221894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool get_hasChanged_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_hasChanged_Injected_Private_Static_Boolean_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221894, XrefRangeEnd = 1221896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_hasChanged_Injected(System.IntPtr _unity_self, bool value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_hasChanged_Injected_Private_Static_Void_IntPtr_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1221896, XrefRangeEnd = 1221898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr GetChild_Injected(System.IntPtr _unity_self, int index)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetChild_Injected_Private_Static_IntPtr_IntPtr_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public Transform(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public Vector3 GetLocalEulerAngles(RotationOrder order)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		GetLocalEulerAngles_Injected(intPtr, order, out var ret);
		return ret;
	}

	public void SetLocalEulerAngles(Vector3 euler, RotationOrder order)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		SetLocalEulerAngles_Injected(intPtr, ref euler, order);
	}

	public void SetLocalEulerHint(Vector3 euler)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		SetLocalEulerHint_Injected(intPtr, ref euler);
	}

	public int GetRotationOrderInternal()
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return GetRotationOrderInternal_Injected(intPtr);
	}

	public void SetRotationOrderInternal(RotationOrder rotationOrder)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		SetRotationOrderInternal_Injected(intPtr, rotationOrder);
	}

	public void GetPositionAndRotation(out Vector3 position, out Quaternion rotation)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		GetPositionAndRotation_Injected(intPtr, out position, out rotation);
	}

	public void GetLocalPositionAndRotation(out Vector3 localPosition, out Quaternion localRotation)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		GetLocalPositionAndRotation_Injected(intPtr, out localPosition, out localRotation);
	}

	public void Translate(float x, float y, float z, Space relativeTo)
	{
		Translate(new Vector3(x, y, z), relativeTo);
	}

	public void Translate(float x, float y, float z)
	{
		Translate(new Vector3(x, y, z), Space.Self);
	}

	public void Translate(Vector3 translation, Transform relativeTo)
	{
		if ((bool)relativeTo)
		{
			position += relativeTo.TransformDirection(translation);
		}
		else
		{
			position += translation;
		}
	}

	public void Translate(float x, float y, float z, Transform relativeTo)
	{
		Translate(new Vector3(x, y, z), relativeTo);
	}

	public void Rotate(float xAngle, float yAngle, float zAngle, Space relativeTo)
	{
		Rotate(new Vector3(xAngle, yAngle, zAngle), relativeTo);
	}

	public void RotateAround(Vector3 point, Vector3 axis, float angle)
	{
		Vector3 vector = position;
		Quaternion quaternion = Quaternion.AngleAxis(angle, axis);
		Vector3 vector2 = vector - point;
		vector2 = quaternion * vector2;
		vector = point + vector2;
		position = vector;
		RotateAroundInternal(axis, angle * (MathF.PI / 180f));
	}

	public void LookAt(Transform target, Vector3 worldUp)
	{
		if ((bool)target)
		{
			LookAt(target.position, worldUp);
		}
	}

	public Vector3 TransformDirection(float x, float y, float z)
	{
		return TransformDirection(new Vector3(x, y, z));
	}

	public unsafe void TransformDirectionsInternal(Il2CppSystem.ReadOnlySpan<Vector3> directions, Il2CppSystem.Span<Vector3> transformedDirections)
	{
		//IL_0019: Expected O, but got Ref
		//IL_0025: Expected O, but got Ref
		//IL_0036: Expected O, but got Ref
		//IL_0044: Expected O, but got Ref
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		Il2CppSystem.ReadOnlySpan<Vector3> readOnlySpan = directions;
		fixed (Vector3* begin = &((Il2CppSystem.ReadOnlySpan<Vector3>)(&readOnlySpan)).GetPinnableReference())
		{
			ManagedSpanWrapper directions2 = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<Vector3>)(&readOnlySpan)).Length);
			Il2CppSystem.Span<Vector3> span = transformedDirections;
			fixed (Vector3* begin2 = &((Il2CppSystem.Span<Vector3>)(&span)).GetPinnableReference())
			{
				ManagedSpanWrapper transformedDirections2 = new ManagedSpanWrapper(begin2, ((Il2CppSystem.Span<Vector3>)(&span)).Length);
				TransformDirectionsInternal_Injected(intPtr, ref directions2, ref transformedDirections2);
			}
		}
	}

	public unsafe void TransformDirections(Il2CppSystem.ReadOnlySpan<Vector3> directions, Il2CppSystem.Span<Vector3> transformedDirections)
	{
		//IL_0008: Expected O, but got Ref
		//IL_000f: Expected O, but got Ref
		if (((Il2CppSystem.ReadOnlySpan<Vector3>)(&directions)).Length != ((Il2CppSystem.Span<Vector3>)(&transformedDirections)).Length)
		{
			throw new Il2CppSystem.InvalidOperationException("Both spans passed to Transform.TransformDirections() must be the same length");
		}
		TransformDirectionsInternal(directions, transformedDirections);
	}

	public void TransformDirections(Il2CppSystem.Span<Vector3> directions)
	{
		TransformDirectionsInternal(directions, directions);
	}

	public Vector3 InverseTransformDirection(float x, float y, float z)
	{
		return InverseTransformDirection(new Vector3(x, y, z));
	}

	public unsafe void InverseTransformDirectionsInternal(Il2CppSystem.ReadOnlySpan<Vector3> directions, Il2CppSystem.Span<Vector3> transformedDirections)
	{
		//IL_0019: Expected O, but got Ref
		//IL_0025: Expected O, but got Ref
		//IL_0036: Expected O, but got Ref
		//IL_0044: Expected O, but got Ref
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		Il2CppSystem.ReadOnlySpan<Vector3> readOnlySpan = directions;
		fixed (Vector3* begin = &((Il2CppSystem.ReadOnlySpan<Vector3>)(&readOnlySpan)).GetPinnableReference())
		{
			ManagedSpanWrapper directions2 = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<Vector3>)(&readOnlySpan)).Length);
			Il2CppSystem.Span<Vector3> span = transformedDirections;
			fixed (Vector3* begin2 = &((Il2CppSystem.Span<Vector3>)(&span)).GetPinnableReference())
			{
				ManagedSpanWrapper transformedDirections2 = new ManagedSpanWrapper(begin2, ((Il2CppSystem.Span<Vector3>)(&span)).Length);
				InverseTransformDirectionsInternal_Injected(intPtr, ref directions2, ref transformedDirections2);
			}
		}
	}

	public unsafe void InverseTransformDirections(Il2CppSystem.ReadOnlySpan<Vector3> directions, Il2CppSystem.Span<Vector3> transformedDirections)
	{
		//IL_0008: Expected O, but got Ref
		//IL_000f: Expected O, but got Ref
		if (((Il2CppSystem.ReadOnlySpan<Vector3>)(&directions)).Length != ((Il2CppSystem.Span<Vector3>)(&transformedDirections)).Length)
		{
			throw new Il2CppSystem.InvalidOperationException("Both spans passed to Transform.InverseTransformDirections() must be the same length");
		}
		InverseTransformDirectionsInternal(directions, transformedDirections);
	}

	public void InverseTransformDirections(Il2CppSystem.Span<Vector3> directions)
	{
		InverseTransformDirectionsInternal(directions, directions);
	}

	public Vector3 TransformVector(float x, float y, float z)
	{
		return TransformVector(new Vector3(x, y, z));
	}

	public unsafe void TransformVectorsInternal(Il2CppSystem.ReadOnlySpan<Vector3> vectors, Il2CppSystem.Span<Vector3> transformedVectors)
	{
		//IL_0019: Expected O, but got Ref
		//IL_0025: Expected O, but got Ref
		//IL_0036: Expected O, but got Ref
		//IL_0044: Expected O, but got Ref
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		Il2CppSystem.ReadOnlySpan<Vector3> readOnlySpan = vectors;
		fixed (Vector3* begin = &((Il2CppSystem.ReadOnlySpan<Vector3>)(&readOnlySpan)).GetPinnableReference())
		{
			ManagedSpanWrapper vectors2 = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<Vector3>)(&readOnlySpan)).Length);
			Il2CppSystem.Span<Vector3> span = transformedVectors;
			fixed (Vector3* begin2 = &((Il2CppSystem.Span<Vector3>)(&span)).GetPinnableReference())
			{
				ManagedSpanWrapper transformedVectors2 = new ManagedSpanWrapper(begin2, ((Il2CppSystem.Span<Vector3>)(&span)).Length);
				TransformVectorsInternal_Injected(intPtr, ref vectors2, ref transformedVectors2);
			}
		}
	}

	public unsafe void TransformVectors(Il2CppSystem.ReadOnlySpan<Vector3> vectors, Il2CppSystem.Span<Vector3> transformedVectors)
	{
		//IL_0008: Expected O, but got Ref
		//IL_000f: Expected O, but got Ref
		if (((Il2CppSystem.ReadOnlySpan<Vector3>)(&vectors)).Length != ((Il2CppSystem.Span<Vector3>)(&transformedVectors)).Length)
		{
			throw new Il2CppSystem.InvalidOperationException("Both spans passed to Transform.TransformVectors() must be the same length");
		}
		TransformVectorsInternal(vectors, transformedVectors);
	}

	public void TransformVectors(Il2CppSystem.Span<Vector3> vectors)
	{
		TransformVectorsInternal(vectors, vectors);
	}

	public Vector3 InverseTransformVector(float x, float y, float z)
	{
		return InverseTransformVector(new Vector3(x, y, z));
	}

	public unsafe void InverseTransformVectorsInternal(Il2CppSystem.ReadOnlySpan<Vector3> vectors, Il2CppSystem.Span<Vector3> transformedVectors)
	{
		//IL_0019: Expected O, but got Ref
		//IL_0025: Expected O, but got Ref
		//IL_0036: Expected O, but got Ref
		//IL_0044: Expected O, but got Ref
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		Il2CppSystem.ReadOnlySpan<Vector3> readOnlySpan = vectors;
		fixed (Vector3* begin = &((Il2CppSystem.ReadOnlySpan<Vector3>)(&readOnlySpan)).GetPinnableReference())
		{
			ManagedSpanWrapper vectors2 = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<Vector3>)(&readOnlySpan)).Length);
			Il2CppSystem.Span<Vector3> span = transformedVectors;
			fixed (Vector3* begin2 = &((Il2CppSystem.Span<Vector3>)(&span)).GetPinnableReference())
			{
				ManagedSpanWrapper transformedVectors2 = new ManagedSpanWrapper(begin2, ((Il2CppSystem.Span<Vector3>)(&span)).Length);
				InverseTransformVectorsInternal_Injected(intPtr, ref vectors2, ref transformedVectors2);
			}
		}
	}

	public unsafe void InverseTransformVectors(Il2CppSystem.ReadOnlySpan<Vector3> vectors, Il2CppSystem.Span<Vector3> transformedVectors)
	{
		//IL_0008: Expected O, but got Ref
		//IL_000f: Expected O, but got Ref
		if (((Il2CppSystem.ReadOnlySpan<Vector3>)(&vectors)).Length != ((Il2CppSystem.Span<Vector3>)(&transformedVectors)).Length)
		{
			throw new Il2CppSystem.InvalidOperationException("Both spans passed to Transform.InverseTransformVectors() must be the same length");
		}
		InverseTransformVectorsInternal(vectors, transformedVectors);
	}

	public void InverseTransformVectors(Il2CppSystem.Span<Vector3> vectors)
	{
		InverseTransformVectorsInternal(vectors, vectors);
	}

	public Vector3 TransformPoint(float x, float y, float z)
	{
		return TransformPoint(new Vector3(x, y, z));
	}

	public unsafe void TransformPointsInternal(Il2CppSystem.ReadOnlySpan<Vector3> positions, Il2CppSystem.Span<Vector3> transformedPositions)
	{
		//IL_0019: Expected O, but got Ref
		//IL_0025: Expected O, but got Ref
		//IL_0036: Expected O, but got Ref
		//IL_0044: Expected O, but got Ref
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		Il2CppSystem.ReadOnlySpan<Vector3> readOnlySpan = positions;
		fixed (Vector3* begin = &((Il2CppSystem.ReadOnlySpan<Vector3>)(&readOnlySpan)).GetPinnableReference())
		{
			ManagedSpanWrapper positions2 = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<Vector3>)(&readOnlySpan)).Length);
			Il2CppSystem.Span<Vector3> span = transformedPositions;
			fixed (Vector3* begin2 = &((Il2CppSystem.Span<Vector3>)(&span)).GetPinnableReference())
			{
				ManagedSpanWrapper transformedPositions2 = new ManagedSpanWrapper(begin2, ((Il2CppSystem.Span<Vector3>)(&span)).Length);
				TransformPointsInternal_Injected(intPtr, ref positions2, ref transformedPositions2);
			}
		}
	}

	public unsafe void TransformPoints(Il2CppSystem.ReadOnlySpan<Vector3> positions, Il2CppSystem.Span<Vector3> transformedPositions)
	{
		//IL_0008: Expected O, but got Ref
		//IL_000f: Expected O, but got Ref
		if (((Il2CppSystem.ReadOnlySpan<Vector3>)(&positions)).Length != ((Il2CppSystem.Span<Vector3>)(&transformedPositions)).Length)
		{
			throw new Il2CppSystem.InvalidOperationException("Both spans passed to Transform.TransformPoints() must be the same length");
		}
		TransformPointsInternal(positions, transformedPositions);
	}

	public void TransformPoints(Il2CppSystem.Span<Vector3> positions)
	{
		TransformPointsInternal(positions, positions);
	}

	public Vector3 InverseTransformPoint(float x, float y, float z)
	{
		return InverseTransformPoint(new Vector3(x, y, z));
	}

	public unsafe void InverseTransformPointsInternal(Il2CppSystem.ReadOnlySpan<Vector3> positions, Il2CppSystem.Span<Vector3> transformedPositions)
	{
		//IL_0019: Expected O, but got Ref
		//IL_0025: Expected O, but got Ref
		//IL_0036: Expected O, but got Ref
		//IL_0044: Expected O, but got Ref
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		Il2CppSystem.ReadOnlySpan<Vector3> readOnlySpan = positions;
		fixed (Vector3* begin = &((Il2CppSystem.ReadOnlySpan<Vector3>)(&readOnlySpan)).GetPinnableReference())
		{
			ManagedSpanWrapper positions2 = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<Vector3>)(&readOnlySpan)).Length);
			Il2CppSystem.Span<Vector3> span = transformedPositions;
			fixed (Vector3* begin2 = &((Il2CppSystem.Span<Vector3>)(&span)).GetPinnableReference())
			{
				ManagedSpanWrapper transformedPositions2 = new ManagedSpanWrapper(begin2, ((Il2CppSystem.Span<Vector3>)(&span)).Length);
				InverseTransformPointsInternal_Injected(intPtr, ref positions2, ref transformedPositions2);
			}
		}
	}

	public unsafe void InverseTransformPoints(Il2CppSystem.ReadOnlySpan<Vector3> positions, Il2CppSystem.Span<Vector3> transformedPositions)
	{
		//IL_0008: Expected O, but got Ref
		//IL_000f: Expected O, but got Ref
		if (((Il2CppSystem.ReadOnlySpan<Vector3>)(&positions)).Length != ((Il2CppSystem.Span<Vector3>)(&transformedPositions)).Length)
		{
			throw new Il2CppSystem.InvalidOperationException("Both spans passed to Transform.InverseTransformPoints() must be the same length");
		}
		InverseTransformPointsInternal(positions, transformedPositions);
	}

	public void InverseTransformPoints(Il2CppSystem.Span<Vector3> positions)
	{
		InverseTransformPoints(positions, positions);
	}

	public void DetachChildren()
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		DetachChildren_Injected(intPtr);
	}

	public void MoveAfterSibling(Transform transform, bool notifyEditorAndMarkDirty)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		MoveAfterSibling_Injected(intPtr, MarshalledUnityObject.Marshal(transform), notifyEditorAndMarkDirty);
	}

	public void SendTransformChangedScale()
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		SendTransformChangedScale_Injected(intPtr);
	}

	public Transform FindChild(string n)
	{
		return Find(n);
	}

	public void RotateAround(Vector3 axis, float angle)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		RotateAround_Injected(intPtr, ref axis, angle);
	}

	public void RotateAroundLocal(Vector3 axis, float angle)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		RotateAroundLocal_Injected(intPtr, ref axis, angle);
	}

	public int GetChildCount()
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return GetChildCount_Injected(intPtr);
	}

	public int internal_getHierarchyCapacity()
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return internal_getHierarchyCapacity_Injected(intPtr);
	}

	public void internal_setHierarchyCapacity(int value)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		internal_setHierarchyCapacity_Injected(intPtr, value);
	}

	public int internal_getHierarchyCount()
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return internal_getHierarchyCount_Injected(intPtr);
	}

	public bool IsNonUniformScaleTransform()
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return IsNonUniformScaleTransform_Injected(intPtr);
	}

	public void SetConstrainProportionsScale(bool isLinked)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		SetConstrainProportionsScale_Injected(intPtr, isLinked);
	}

	public bool IsConstrainProportionsScale()
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return IsConstrainProportionsScale_Injected(intPtr);
	}

	public unsafe static void GetLocalEulerAngles_Injected(System.IntPtr _unity_self, RotationOrder order, out Vector3 ret)
	{
		GetLocalEulerAngles_InjectedDelegateField(_unity_self, order, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void SetLocalEulerAngles_Injected(System.IntPtr _unity_self, [In] ref Vector3 euler, RotationOrder order)
	{
		SetLocalEulerAngles_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref euler), order);
	}

	public unsafe static void SetLocalEulerHint_Injected(System.IntPtr _unity_self, [In] ref Vector3 euler)
	{
		SetLocalEulerHint_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref euler));
	}

	public static int GetRotationOrderInternal_Injected(System.IntPtr _unity_self)
	{
		return GetRotationOrderInternal_InjectedDelegateField(_unity_self);
	}

	public static void SetRotationOrderInternal_Injected(System.IntPtr _unity_self, RotationOrder rotationOrder)
	{
		SetRotationOrderInternal_InjectedDelegateField(_unity_self, rotationOrder);
	}

	public unsafe static void GetPositionAndRotation_Injected(System.IntPtr _unity_self, out Vector3 position, out Quaternion rotation)
	{
		GetPositionAndRotation_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref position), (nint)Unsafe.AsPointer(ref rotation));
	}

	public unsafe static void GetLocalPositionAndRotation_Injected(System.IntPtr _unity_self, out Vector3 localPosition, out Quaternion localRotation)
	{
		GetLocalPositionAndRotation_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref localPosition), (nint)Unsafe.AsPointer(ref localRotation));
	}

	public unsafe static void TransformDirectionsInternal_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper directions, ref ManagedSpanWrapper transformedDirections)
	{
		TransformDirectionsInternal_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref directions), (nint)Unsafe.AsPointer(ref transformedDirections));
	}

	public unsafe static void InverseTransformDirectionsInternal_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper directions, ref ManagedSpanWrapper transformedDirections)
	{
		InverseTransformDirectionsInternal_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref directions), (nint)Unsafe.AsPointer(ref transformedDirections));
	}

	public unsafe static void TransformVectorsInternal_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper vectors, ref ManagedSpanWrapper transformedVectors)
	{
		TransformVectorsInternal_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref vectors), (nint)Unsafe.AsPointer(ref transformedVectors));
	}

	public unsafe static void InverseTransformVectorsInternal_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper vectors, ref ManagedSpanWrapper transformedVectors)
	{
		InverseTransformVectorsInternal_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref vectors), (nint)Unsafe.AsPointer(ref transformedVectors));
	}

	public unsafe static void TransformPointsInternal_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper positions, ref ManagedSpanWrapper transformedPositions)
	{
		TransformPointsInternal_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref positions), (nint)Unsafe.AsPointer(ref transformedPositions));
	}

	public unsafe static void InverseTransformPointsInternal_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper positions, ref ManagedSpanWrapper transformedPositions)
	{
		InverseTransformPointsInternal_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref positions), (nint)Unsafe.AsPointer(ref transformedPositions));
	}

	public static void DetachChildren_Injected(System.IntPtr _unity_self)
	{
		DetachChildren_InjectedDelegateField(_unity_self);
	}

	public static void MoveAfterSibling_Injected(System.IntPtr _unity_self, System.IntPtr transform, bool notifyEditorAndMarkDirty)
	{
		MoveAfterSibling_InjectedDelegateField(_unity_self, transform, notifyEditorAndMarkDirty);
	}

	public static void SendTransformChangedScale_Injected(System.IntPtr _unity_self)
	{
		SendTransformChangedScale_InjectedDelegateField(_unity_self);
	}

	public unsafe static void RotateAround_Injected(System.IntPtr _unity_self, [In] ref Vector3 axis, float angle)
	{
		RotateAround_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref axis), angle);
	}

	public unsafe static void RotateAroundLocal_Injected(System.IntPtr _unity_self, [In] ref Vector3 axis, float angle)
	{
		RotateAroundLocal_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref axis), angle);
	}

	public static int GetChildCount_Injected(System.IntPtr _unity_self)
	{
		return GetChildCount_InjectedDelegateField(_unity_self);
	}

	public static int internal_getHierarchyCapacity_Injected(System.IntPtr _unity_self)
	{
		return internal_getHierarchyCapacity_InjectedDelegateField(_unity_self);
	}

	public static void internal_setHierarchyCapacity_Injected(System.IntPtr _unity_self, int value)
	{
		internal_setHierarchyCapacity_InjectedDelegateField(_unity_self, value);
	}

	public static int internal_getHierarchyCount_Injected(System.IntPtr _unity_self)
	{
		return internal_getHierarchyCount_InjectedDelegateField(_unity_self);
	}

	public static bool IsNonUniformScaleTransform_Injected(System.IntPtr _unity_self)
	{
		return IsNonUniformScaleTransform_InjectedDelegateField(_unity_self);
	}

	public static void SetConstrainProportionsScale_Injected(System.IntPtr _unity_self, bool isLinked)
	{
		SetConstrainProportionsScale_InjectedDelegateField(_unity_self, isLinked);
	}

	public static bool IsConstrainProportionsScale_Injected(System.IntPtr _unity_self)
	{
		return IsConstrainProportionsScale_InjectedDelegateField(_unity_self);
	}
}
