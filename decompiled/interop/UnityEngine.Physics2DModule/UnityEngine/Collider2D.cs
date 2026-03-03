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

public class Collider2D : Behaviour
{
	[OriginalName("UnityEngine.Physics2DModule.dll", "", "CompositeOperation")]
	public enum CompositeOperation
	{
		None,
		Merge,
		Intersect,
		Difference,
		Flip
	}

	private delegate float get_density_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_density_InjectedDelegate(System.IntPtr _unity_self, float value);

	private delegate bool get_isTrigger_InjectedDelegate(System.IntPtr _unity_self);

	private delegate bool get_usedByEffector_InjectedDelegate(System.IntPtr _unity_self);

	private delegate CompositeOperation get_compositeOperation_InjectedDelegate(System.IntPtr _unity_self);

	private delegate int get_compositeOrder_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_compositeOrder_InjectedDelegate(System.IntPtr _unity_self, int value);

	private delegate System.IntPtr get_composite_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void get_offset_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr ret);

	private delegate void set_offset_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr value);

	private delegate System.IntPtr get_attachedRigidbody_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void get_localToWorldMatrix_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr ret);

	private delegate int get_shapeCount_InjectedDelegate(System.IntPtr _unity_self);

	private delegate System.IntPtr CreateMesh_InjectedDelegate(System.IntPtr _unity_self, bool useBodyPosition, bool useBodyRotation, bool useDelaunay);

	private delegate uint GetShapeHash_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void GetShapeBounds_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr bounds, bool useRadii, bool useWorldSpace, [Out] System.IntPtr ret);

	private delegate void get_bounds_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr ret);

	private delegate ColliderErrorState2D get_errorState_InjectedDelegate(System.IntPtr _unity_self);

	private delegate bool get_compositeCapable_InjectedDelegate(System.IntPtr _unity_self);

	private delegate System.IntPtr get_sharedMaterial_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_sharedMaterial_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr value);

	private delegate int get_layerOverridePriority_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_layerOverridePriority_InjectedDelegate(System.IntPtr _unity_self, int value);

	private delegate void get_excludeLayers_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr ret);

	private delegate void set_excludeLayers_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr value);

	private delegate void get_includeLayers_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr ret);

	private delegate void set_includeLayers_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr value);

	private delegate void get_forceSendLayers_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr ret);

	private delegate void set_forceSendLayers_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr value);

	private delegate void get_forceReceiveLayers_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr ret);

	private delegate void set_forceReceiveLayers_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr value);

	private delegate void get_contactCaptureLayers_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr ret);

	private delegate void set_contactCaptureLayers_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr value);

	private delegate void get_callbackLayers_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr ret);

	private delegate void set_callbackLayers_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr value);

	private delegate float get_friction_InjectedDelegate(System.IntPtr _unity_self);

	private delegate float get_bounciness_InjectedDelegate(System.IntPtr _unity_self);

	private delegate PhysicsMaterialCombine2D get_frictionCombine_InjectedDelegate(System.IntPtr _unity_self);

	private delegate PhysicsMaterialCombine2D get_bounceCombine_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void get_contactMask_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr ret);

	private delegate bool IsTouching_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr collider);

	private delegate bool IsTouching_OtherColliderWithFilter_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr collider, [In] System.IntPtr contactFilter);

	private delegate bool IsTouching_AnyColliderWithFilter_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr contactFilter);

	private delegate bool IsTouchingLayers_InjectedDelegate(System.IntPtr _unity_self, int layerMask);

	private delegate bool OverlapPoint_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr point);

	private delegate int CastArray_Internal_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr direction, float distance, [In] System.IntPtr contactFilter, bool ignoreSiblingColliders, bool checkIgnoreColliders, System.IntPtr results);

	private delegate int CastList_Internal_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr direction, float distance, bool ignoreSiblingColliders, bool checkIgnoreColliders, System.IntPtr results);

	private delegate int CastListFiltered_Internal_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr direction, float distance, [In] System.IntPtr contactFilter, bool ignoreSiblingColliders, bool checkIgnoreColliders, System.IntPtr results);

	private delegate int CastFrom_Internal_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr position, float angle, [In] System.IntPtr direction, float distance, bool ignoreSiblingColliders, bool checkIgnoreColliders, System.IntPtr results);

	private delegate int CastFromFiltered_Internal_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr position, float angle, [In] System.IntPtr direction, float distance, [In] System.IntPtr contactFilter, bool ignoreSiblingColliders, bool checkIgnoreColliders, System.IntPtr results);

	private delegate int RaycastArray_Internal_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr direction, float distance, [In] System.IntPtr contactFilter, System.IntPtr results);

	private delegate int RaycastList_Internal_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr direction, float distance, [In] System.IntPtr contactFilter, System.IntPtr results);

	private static readonly System.IntPtr NativeMethodInfoPtr_set_isTrigger_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_usedByEffector_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_compositeOperation_Public_set_Void_CompositeOperation_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_usedByComposite_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_isTrigger_Injected_Private_Static_Void_IntPtr_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_usedByEffector_Injected_Private_Static_Void_IntPtr_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_compositeOperation_Injected_Private_Static_Void_IntPtr_CompositeOperation_0;

	private static readonly get_density_InjectedDelegate get_density_InjectedDelegateField;

	private static readonly set_density_InjectedDelegate set_density_InjectedDelegateField;

	private static readonly get_isTrigger_InjectedDelegate get_isTrigger_InjectedDelegateField;

	private static readonly get_usedByEffector_InjectedDelegate get_usedByEffector_InjectedDelegateField;

	private static readonly get_compositeOperation_InjectedDelegate get_compositeOperation_InjectedDelegateField;

	private static readonly get_compositeOrder_InjectedDelegate get_compositeOrder_InjectedDelegateField;

	private static readonly set_compositeOrder_InjectedDelegate set_compositeOrder_InjectedDelegateField;

	private static readonly get_composite_InjectedDelegate get_composite_InjectedDelegateField;

	private static readonly get_offset_InjectedDelegate get_offset_InjectedDelegateField;

	private static readonly set_offset_InjectedDelegate set_offset_InjectedDelegateField;

	private static readonly get_attachedRigidbody_InjectedDelegate get_attachedRigidbody_InjectedDelegateField;

	private static readonly get_localToWorldMatrix_InjectedDelegate get_localToWorldMatrix_InjectedDelegateField;

	private static readonly get_shapeCount_InjectedDelegate get_shapeCount_InjectedDelegateField;

	private static readonly CreateMesh_InjectedDelegate CreateMesh_InjectedDelegateField;

	private static readonly GetShapeHash_InjectedDelegate GetShapeHash_InjectedDelegateField;

	private static readonly GetShapeBounds_InjectedDelegate GetShapeBounds_InjectedDelegateField;

	private static readonly get_bounds_InjectedDelegate get_bounds_InjectedDelegateField;

	private static readonly get_errorState_InjectedDelegate get_errorState_InjectedDelegateField;

	private static readonly get_compositeCapable_InjectedDelegate get_compositeCapable_InjectedDelegateField;

	private static readonly get_sharedMaterial_InjectedDelegate get_sharedMaterial_InjectedDelegateField;

	private static readonly set_sharedMaterial_InjectedDelegate set_sharedMaterial_InjectedDelegateField;

	private static readonly get_layerOverridePriority_InjectedDelegate get_layerOverridePriority_InjectedDelegateField;

	private static readonly set_layerOverridePriority_InjectedDelegate set_layerOverridePriority_InjectedDelegateField;

	private static readonly get_excludeLayers_InjectedDelegate get_excludeLayers_InjectedDelegateField;

	private static readonly set_excludeLayers_InjectedDelegate set_excludeLayers_InjectedDelegateField;

	private static readonly get_includeLayers_InjectedDelegate get_includeLayers_InjectedDelegateField;

	private static readonly set_includeLayers_InjectedDelegate set_includeLayers_InjectedDelegateField;

	private static readonly get_forceSendLayers_InjectedDelegate get_forceSendLayers_InjectedDelegateField;

	private static readonly set_forceSendLayers_InjectedDelegate set_forceSendLayers_InjectedDelegateField;

	private static readonly get_forceReceiveLayers_InjectedDelegate get_forceReceiveLayers_InjectedDelegateField;

	private static readonly set_forceReceiveLayers_InjectedDelegate set_forceReceiveLayers_InjectedDelegateField;

	private static readonly get_contactCaptureLayers_InjectedDelegate get_contactCaptureLayers_InjectedDelegateField;

	private static readonly set_contactCaptureLayers_InjectedDelegate set_contactCaptureLayers_InjectedDelegateField;

	private static readonly get_callbackLayers_InjectedDelegate get_callbackLayers_InjectedDelegateField;

	private static readonly set_callbackLayers_InjectedDelegate set_callbackLayers_InjectedDelegateField;

	private static readonly get_friction_InjectedDelegate get_friction_InjectedDelegateField;

	private static readonly get_bounciness_InjectedDelegate get_bounciness_InjectedDelegateField;

	private static readonly get_frictionCombine_InjectedDelegate get_frictionCombine_InjectedDelegateField;

	private static readonly get_bounceCombine_InjectedDelegate get_bounceCombine_InjectedDelegateField;

	private static readonly get_contactMask_InjectedDelegate get_contactMask_InjectedDelegateField;

	private static readonly IsTouching_InjectedDelegate IsTouching_InjectedDelegateField;

	private static readonly IsTouching_OtherColliderWithFilter_InjectedDelegate IsTouching_OtherColliderWithFilter_InjectedDelegateField;

	private static readonly IsTouching_AnyColliderWithFilter_InjectedDelegate IsTouching_AnyColliderWithFilter_InjectedDelegateField;

	private static readonly IsTouchingLayers_InjectedDelegate IsTouchingLayers_InjectedDelegateField;

	private static readonly OverlapPoint_InjectedDelegate OverlapPoint_InjectedDelegateField;

	private static readonly CastArray_Internal_InjectedDelegate CastArray_Internal_InjectedDelegateField;

	private static readonly CastList_Internal_InjectedDelegate CastList_Internal_InjectedDelegateField;

	private static readonly CastListFiltered_Internal_InjectedDelegate CastListFiltered_Internal_InjectedDelegateField;

	private static readonly CastFrom_Internal_InjectedDelegate CastFrom_Internal_InjectedDelegateField;

	private static readonly CastFromFiltered_Internal_InjectedDelegate CastFromFiltered_Internal_InjectedDelegateField;

	private static readonly RaycastArray_Internal_InjectedDelegate RaycastArray_Internal_InjectedDelegateField;

	private static readonly RaycastList_Internal_InjectedDelegate RaycastList_Internal_InjectedDelegateField;

	public unsafe bool isTrigger
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_isTrigger_Injected(intPtr);
		}
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1259056, RefRangeEnd = 1259060, XrefRangeStart = 1259051, XrefRangeEnd = 1259056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_isTrigger_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool usedByEffector
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_usedByEffector_Injected(intPtr);
		}
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1259065, RefRangeEnd = 1259067, XrefRangeStart = 1259060, XrefRangeEnd = 1259065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_usedByEffector_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe CompositeOperation compositeOperation
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_compositeOperation_Injected(intPtr);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259067, XrefRangeEnd = 1259072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_compositeOperation_Public_set_Void_CompositeOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool usedByComposite
	{
		get
		{
			return compositeOperation != CompositeOperation.None;
		}
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1259077, RefRangeEnd = 1259079, XrefRangeStart = 1259072, XrefRangeEnd = 1259077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_usedByComposite_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public float density
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_density_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_density_Injected(intPtr, value);
		}
	}

	public int compositeOrder
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_compositeOrder_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_compositeOrder_Injected(intPtr, value);
		}
	}

	public CompositeCollider2D composite
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return Unmarshal.UnmarshalUnityObject<CompositeCollider2D>(get_composite_Injected(intPtr));
		}
	}

	public Vector2 offset
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			get_offset_Injected(intPtr, out var ret);
			return ret;
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_offset_Injected(intPtr, ref value);
		}
	}

	public Rigidbody2D attachedRigidbody
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return Unmarshal.UnmarshalUnityObject<Rigidbody2D>(get_attachedRigidbody_Injected(intPtr));
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

	public int shapeCount
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_shapeCount_Injected(intPtr);
		}
	}

	public Bounds bounds
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			get_bounds_Injected(intPtr, out var ret);
			return ret;
		}
	}

	public ColliderErrorState2D errorState
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_errorState_Injected(intPtr);
		}
	}

	public bool compositeCapable
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_compositeCapable_Injected(intPtr);
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

	public int layerOverridePriority
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_layerOverridePriority_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_layerOverridePriority_Injected(intPtr, value);
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

	public LayerMask forceSendLayers
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			get_forceSendLayers_Injected(intPtr, out var ret);
			return ret;
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_forceSendLayers_Injected(intPtr, ref value);
		}
	}

	public LayerMask forceReceiveLayers
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			get_forceReceiveLayers_Injected(intPtr, out var ret);
			return ret;
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_forceReceiveLayers_Injected(intPtr, ref value);
		}
	}

	public LayerMask contactCaptureLayers
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			get_contactCaptureLayers_Injected(intPtr, out var ret);
			return ret;
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_contactCaptureLayers_Injected(intPtr, ref value);
		}
	}

	public LayerMask callbackLayers
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			get_callbackLayers_Injected(intPtr, out var ret);
			return ret;
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_callbackLayers_Injected(intPtr, ref value);
		}
	}

	public float friction
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_friction_Injected(intPtr);
		}
	}

	public float bounciness
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_bounciness_Injected(intPtr);
		}
	}

	public PhysicsMaterialCombine2D frictionCombine
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_frictionCombine_Injected(intPtr);
		}
	}

	public PhysicsMaterialCombine2D bounceCombine
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_bounceCombine_Injected(intPtr);
		}
	}

	public LayerMask contactMask
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			get_contactMask_Injected(intPtr, out var ret);
			return ret;
		}
	}

	static Collider2D()
	{
		Il2CppClassPointerStore<Collider2D>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Physics2DModule.dll", "UnityEngine", "Collider2D");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Collider2D>.NativeClassPtr);
		NativeMethodInfoPtr_set_isTrigger_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Collider2D>.NativeClassPtr, 100663374);
		NativeMethodInfoPtr_set_usedByEffector_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Collider2D>.NativeClassPtr, 100663375);
		NativeMethodInfoPtr_set_compositeOperation_Public_set_Void_CompositeOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Collider2D>.NativeClassPtr, 100663376);
		NativeMethodInfoPtr_set_usedByComposite_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Collider2D>.NativeClassPtr, 100663377);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Collider2D>.NativeClassPtr, 100663378);
		NativeMethodInfoPtr_set_isTrigger_Injected_Private_Static_Void_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Collider2D>.NativeClassPtr, 100663379);
		NativeMethodInfoPtr_set_usedByEffector_Injected_Private_Static_Void_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Collider2D>.NativeClassPtr, 100663380);
		NativeMethodInfoPtr_set_compositeOperation_Injected_Private_Static_Void_IntPtr_CompositeOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Collider2D>.NativeClassPtr, 100663381);
		get_density_InjectedDelegateField = IL2CPP.ResolveICall<get_density_InjectedDelegate>("UnityEngine.Collider2D::get_density_Injected");
		set_density_InjectedDelegateField = IL2CPP.ResolveICall<set_density_InjectedDelegate>("UnityEngine.Collider2D::set_density_Injected");
		get_isTrigger_InjectedDelegateField = IL2CPP.ResolveICall<get_isTrigger_InjectedDelegate>("UnityEngine.Collider2D::get_isTrigger_Injected");
		get_usedByEffector_InjectedDelegateField = IL2CPP.ResolveICall<get_usedByEffector_InjectedDelegate>("UnityEngine.Collider2D::get_usedByEffector_Injected");
		get_compositeOperation_InjectedDelegateField = IL2CPP.ResolveICall<get_compositeOperation_InjectedDelegate>("UnityEngine.Collider2D::get_compositeOperation_Injected");
		get_compositeOrder_InjectedDelegateField = IL2CPP.ResolveICall<get_compositeOrder_InjectedDelegate>("UnityEngine.Collider2D::get_compositeOrder_Injected");
		set_compositeOrder_InjectedDelegateField = IL2CPP.ResolveICall<set_compositeOrder_InjectedDelegate>("UnityEngine.Collider2D::set_compositeOrder_Injected");
		get_composite_InjectedDelegateField = IL2CPP.ResolveICall<get_composite_InjectedDelegate>("UnityEngine.Collider2D::get_composite_Injected");
		get_offset_InjectedDelegateField = IL2CPP.ResolveICall<get_offset_InjectedDelegate>("UnityEngine.Collider2D::get_offset_Injected");
		set_offset_InjectedDelegateField = IL2CPP.ResolveICall<set_offset_InjectedDelegate>("UnityEngine.Collider2D::set_offset_Injected");
		get_attachedRigidbody_InjectedDelegateField = IL2CPP.ResolveICall<get_attachedRigidbody_InjectedDelegate>("UnityEngine.Collider2D::get_attachedRigidbody_Injected");
		get_localToWorldMatrix_InjectedDelegateField = IL2CPP.ResolveICall<get_localToWorldMatrix_InjectedDelegate>("UnityEngine.Collider2D::get_localToWorldMatrix_Injected");
		get_shapeCount_InjectedDelegateField = IL2CPP.ResolveICall<get_shapeCount_InjectedDelegate>("UnityEngine.Collider2D::get_shapeCount_Injected");
		CreateMesh_InjectedDelegateField = IL2CPP.ResolveICall<CreateMesh_InjectedDelegate>("UnityEngine.Collider2D::CreateMesh_Injected");
		GetShapeHash_InjectedDelegateField = IL2CPP.ResolveICall<GetShapeHash_InjectedDelegate>("UnityEngine.Collider2D::GetShapeHash_Injected");
		GetShapeBounds_InjectedDelegateField = IL2CPP.ResolveICall<GetShapeBounds_InjectedDelegate>("UnityEngine.Collider2D::GetShapeBounds_Injected");
		get_bounds_InjectedDelegateField = IL2CPP.ResolveICall<get_bounds_InjectedDelegate>("UnityEngine.Collider2D::get_bounds_Injected");
		get_errorState_InjectedDelegateField = IL2CPP.ResolveICall<get_errorState_InjectedDelegate>("UnityEngine.Collider2D::get_errorState_Injected");
		get_compositeCapable_InjectedDelegateField = IL2CPP.ResolveICall<get_compositeCapable_InjectedDelegate>("UnityEngine.Collider2D::get_compositeCapable_Injected");
		get_sharedMaterial_InjectedDelegateField = IL2CPP.ResolveICall<get_sharedMaterial_InjectedDelegate>("UnityEngine.Collider2D::get_sharedMaterial_Injected");
		set_sharedMaterial_InjectedDelegateField = IL2CPP.ResolveICall<set_sharedMaterial_InjectedDelegate>("UnityEngine.Collider2D::set_sharedMaterial_Injected");
		get_layerOverridePriority_InjectedDelegateField = IL2CPP.ResolveICall<get_layerOverridePriority_InjectedDelegate>("UnityEngine.Collider2D::get_layerOverridePriority_Injected");
		set_layerOverridePriority_InjectedDelegateField = IL2CPP.ResolveICall<set_layerOverridePriority_InjectedDelegate>("UnityEngine.Collider2D::set_layerOverridePriority_Injected");
		get_excludeLayers_InjectedDelegateField = IL2CPP.ResolveICall<get_excludeLayers_InjectedDelegate>("UnityEngine.Collider2D::get_excludeLayers_Injected");
		set_excludeLayers_InjectedDelegateField = IL2CPP.ResolveICall<set_excludeLayers_InjectedDelegate>("UnityEngine.Collider2D::set_excludeLayers_Injected");
		get_includeLayers_InjectedDelegateField = IL2CPP.ResolveICall<get_includeLayers_InjectedDelegate>("UnityEngine.Collider2D::get_includeLayers_Injected");
		set_includeLayers_InjectedDelegateField = IL2CPP.ResolveICall<set_includeLayers_InjectedDelegate>("UnityEngine.Collider2D::set_includeLayers_Injected");
		get_forceSendLayers_InjectedDelegateField = IL2CPP.ResolveICall<get_forceSendLayers_InjectedDelegate>("UnityEngine.Collider2D::get_forceSendLayers_Injected");
		set_forceSendLayers_InjectedDelegateField = IL2CPP.ResolveICall<set_forceSendLayers_InjectedDelegate>("UnityEngine.Collider2D::set_forceSendLayers_Injected");
		get_forceReceiveLayers_InjectedDelegateField = IL2CPP.ResolveICall<get_forceReceiveLayers_InjectedDelegate>("UnityEngine.Collider2D::get_forceReceiveLayers_Injected");
		set_forceReceiveLayers_InjectedDelegateField = IL2CPP.ResolveICall<set_forceReceiveLayers_InjectedDelegate>("UnityEngine.Collider2D::set_forceReceiveLayers_Injected");
		get_contactCaptureLayers_InjectedDelegateField = IL2CPP.ResolveICall<get_contactCaptureLayers_InjectedDelegate>("UnityEngine.Collider2D::get_contactCaptureLayers_Injected");
		set_contactCaptureLayers_InjectedDelegateField = IL2CPP.ResolveICall<set_contactCaptureLayers_InjectedDelegate>("UnityEngine.Collider2D::set_contactCaptureLayers_Injected");
		get_callbackLayers_InjectedDelegateField = IL2CPP.ResolveICall<get_callbackLayers_InjectedDelegate>("UnityEngine.Collider2D::get_callbackLayers_Injected");
		set_callbackLayers_InjectedDelegateField = IL2CPP.ResolveICall<set_callbackLayers_InjectedDelegate>("UnityEngine.Collider2D::set_callbackLayers_Injected");
		get_friction_InjectedDelegateField = IL2CPP.ResolveICall<get_friction_InjectedDelegate>("UnityEngine.Collider2D::get_friction_Injected");
		get_bounciness_InjectedDelegateField = IL2CPP.ResolveICall<get_bounciness_InjectedDelegate>("UnityEngine.Collider2D::get_bounciness_Injected");
		get_frictionCombine_InjectedDelegateField = IL2CPP.ResolveICall<get_frictionCombine_InjectedDelegate>("UnityEngine.Collider2D::get_frictionCombine_Injected");
		get_bounceCombine_InjectedDelegateField = IL2CPP.ResolveICall<get_bounceCombine_InjectedDelegate>("UnityEngine.Collider2D::get_bounceCombine_Injected");
		get_contactMask_InjectedDelegateField = IL2CPP.ResolveICall<get_contactMask_InjectedDelegate>("UnityEngine.Collider2D::get_contactMask_Injected");
		IsTouching_InjectedDelegateField = IL2CPP.ResolveICall<IsTouching_InjectedDelegate>("UnityEngine.Collider2D::IsTouching_Injected");
		IsTouching_OtherColliderWithFilter_InjectedDelegateField = IL2CPP.ResolveICall<IsTouching_OtherColliderWithFilter_InjectedDelegate>("UnityEngine.Collider2D::IsTouching_OtherColliderWithFilter_Injected");
		IsTouching_AnyColliderWithFilter_InjectedDelegateField = IL2CPP.ResolveICall<IsTouching_AnyColliderWithFilter_InjectedDelegate>("UnityEngine.Collider2D::IsTouching_AnyColliderWithFilter_Injected");
		IsTouchingLayers_InjectedDelegateField = IL2CPP.ResolveICall<IsTouchingLayers_InjectedDelegate>("UnityEngine.Collider2D::IsTouchingLayers_Injected");
		OverlapPoint_InjectedDelegateField = IL2CPP.ResolveICall<OverlapPoint_InjectedDelegate>("UnityEngine.Collider2D::OverlapPoint_Injected");
		CastArray_Internal_InjectedDelegateField = IL2CPP.ResolveICall<CastArray_Internal_InjectedDelegate>("UnityEngine.Collider2D::CastArray_Internal_Injected");
		CastList_Internal_InjectedDelegateField = IL2CPP.ResolveICall<CastList_Internal_InjectedDelegate>("UnityEngine.Collider2D::CastList_Internal_Injected");
		CastListFiltered_Internal_InjectedDelegateField = IL2CPP.ResolveICall<CastListFiltered_Internal_InjectedDelegate>("UnityEngine.Collider2D::CastListFiltered_Internal_Injected");
		CastFrom_Internal_InjectedDelegateField = IL2CPP.ResolveICall<CastFrom_Internal_InjectedDelegate>("UnityEngine.Collider2D::CastFrom_Internal_Injected");
		CastFromFiltered_Internal_InjectedDelegateField = IL2CPP.ResolveICall<CastFromFiltered_Internal_InjectedDelegate>("UnityEngine.Collider2D::CastFromFiltered_Internal_Injected");
		RaycastArray_Internal_InjectedDelegateField = IL2CPP.ResolveICall<RaycastArray_Internal_InjectedDelegate>("UnityEngine.Collider2D::RaycastArray_Internal_Injected");
		RaycastList_Internal_InjectedDelegateField = IL2CPP.ResolveICall<RaycastList_Internal_InjectedDelegate>("UnityEngine.Collider2D::RaycastList_Internal_Injected");
	}

	[CallerCount(646)]
	[CachedScanResults(RefRangeStart = 1152221, RefRangeEnd = 1152867, XrefRangeStart = 1152221, XrefRangeEnd = 1152867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Collider2D()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Collider2D>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259079, XrefRangeEnd = 1259081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_isTrigger_Injected(System.IntPtr _unity_self, bool value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_isTrigger_Injected_Private_Static_Void_IntPtr_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259081, XrefRangeEnd = 1259083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_usedByEffector_Injected(System.IntPtr _unity_self, bool value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_usedByEffector_Injected_Private_Static_Void_IntPtr_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259083, XrefRangeEnd = 1259085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_compositeOperation_Injected(System.IntPtr _unity_self, CompositeOperation value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(CompositeOperation**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_compositeOperation_Injected_Private_Static_Void_IntPtr_CompositeOperation_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public Collider2D(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public Mesh CreateMesh(bool useBodyPosition, bool useBodyRotation)
	{
		return CreateMesh(useBodyPosition, useBodyRotation, useDelaunay: true);
	}

	public Mesh CreateMesh(bool useBodyPosition, bool useBodyRotation, [Optional] bool useDelaunay)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return Unmarshal.UnmarshalUnityObject<Mesh>(CreateMesh_Injected(intPtr, useBodyPosition, useBodyRotation, useDelaunay));
	}

	public uint GetShapeHash()
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return GetShapeHash_Injected(intPtr);
	}

	public int GetShapes(PhysicsShapeGroup2D physicsShapeGroup)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public int GetShapes(PhysicsShapeGroup2D physicsShapeGroup, int shapeIndex, [Optional] int shapeCount)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public Bounds GetShapeBounds(List<Bounds> bounds, bool useRadii, bool useWorldSpace)
	{
		throw new System.NotSupportedException("Method unstripping failed");
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
		return IsTouching_OtherColliderWithFilter(collider, contactFilter);
	}

	public bool IsTouching_OtherColliderWithFilter(Collider2D collider, ContactFilter2D contactFilter)
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
		return IsTouching_OtherColliderWithFilter_Injected(intPtr, intPtr2, ref contactFilter);
	}

	public bool IsTouching(ContactFilter2D contactFilter)
	{
		return IsTouching_AnyColliderWithFilter(contactFilter);
	}

	public bool IsTouching_AnyColliderWithFilter(ContactFilter2D contactFilter)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return IsTouching_AnyColliderWithFilter_Injected(intPtr, ref contactFilter);
	}

	public bool IsTouchingLayers()
	{
		return IsTouchingLayers(-1);
	}

	public bool IsTouchingLayers(int layerMask)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return IsTouchingLayers_Injected(intPtr, layerMask);
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

	public int Overlap(ContactFilter2D contactFilter, Il2CppReferenceArray<Collider2D> results)
	{
		return PhysicsScene2D.OverlapCollider(this, contactFilter, results);
	}

	public int Overlap(List<Collider2D> results)
	{
		return PhysicsScene2D.OverlapCollider(this, results);
	}

	public int Overlap(ContactFilter2D contactFilter, List<Collider2D> results)
	{
		return PhysicsScene2D.OverlapCollider(this, contactFilter, results);
	}

	public int Overlap(Vector2 position, float angle, List<Collider2D> results)
	{
		if ((bool)attachedRigidbody)
		{
			return PhysicsScene2D.OverlapCollider(position, angle, this, results);
		}
		throw new Il2CppSystem.InvalidOperationException("Cannot perform a Collider Overlap at a specific position and angle if the Collider is not attached to a Rigidbody2D.");
	}

	public int Overlap(Vector2 position, float angle, ContactFilter2D contactFilter, List<Collider2D> results)
	{
		if ((bool)attachedRigidbody)
		{
			return PhysicsScene2D.OverlapCollider(position, angle, this, contactFilter, results);
		}
		throw new Il2CppSystem.InvalidOperationException("Cannot perform a Collider Overlap at a specific position and angle if the Collider is not attached to a Rigidbody2D.");
	}

	public int Cast(Vector2 direction, Il2CppStructArray<RaycastHit2D> results)
	{
		ContactFilter2D contactFilter = default(ContactFilter2D);
		contactFilter.useTriggers = Physics2D.queriesHitTriggers;
		contactFilter.SetLayerMask(contactMask);
		return CastArray_Internal(direction, float.PositiveInfinity, contactFilter, ignoreSiblingColliders: true, checkIgnoreColliders: false, results);
	}

	public int Cast(Vector2 direction, Il2CppStructArray<RaycastHit2D> results, float distance)
	{
		ContactFilter2D contactFilter = default(ContactFilter2D);
		contactFilter.useTriggers = Physics2D.queriesHitTriggers;
		contactFilter.SetLayerMask(contactMask);
		return CastArray_Internal(direction, distance, contactFilter, ignoreSiblingColliders: true, checkIgnoreColliders: false, results);
	}

	public int Cast(Vector2 direction, Il2CppStructArray<RaycastHit2D> results, float distance, bool ignoreSiblingColliders)
	{
		ContactFilter2D contactFilter = default(ContactFilter2D);
		contactFilter.useTriggers = Physics2D.queriesHitTriggers;
		contactFilter.SetLayerMask(contactMask);
		return CastArray_Internal(direction, distance, contactFilter, ignoreSiblingColliders, checkIgnoreColliders: false, results);
	}

	public int Cast(Vector2 direction, ContactFilter2D contactFilter, Il2CppStructArray<RaycastHit2D> results)
	{
		return CastArray_Internal(direction, float.PositiveInfinity, contactFilter, ignoreSiblingColliders: true, checkIgnoreColliders: false, results);
	}

	public int Cast(Vector2 direction, ContactFilter2D contactFilter, Il2CppStructArray<RaycastHit2D> results, float distance)
	{
		return CastArray_Internal(direction, distance, contactFilter, ignoreSiblingColliders: true, checkIgnoreColliders: false, results);
	}

	public int Cast(Vector2 direction, ContactFilter2D contactFilter, Il2CppStructArray<RaycastHit2D> results, float distance, bool ignoreSiblingColliders)
	{
		return CastArray_Internal(direction, distance, contactFilter, ignoreSiblingColliders, checkIgnoreColliders: false, results);
	}

	public int Cast(Vector2 direction, List<RaycastHit2D> results, [Optional] float distance, [Optional] bool ignoreSiblingColliders)
	{
		return CastList_Internal(direction, distance, ignoreSiblingColliders, checkIgnoreColliders: false, results);
	}

	public int Cast(Vector2 direction, ContactFilter2D contactFilter, List<RaycastHit2D> results, [Optional] float distance, [Optional] bool ignoreSiblingColliders)
	{
		return CastListFiltered_Internal(direction, distance, contactFilter, ignoreSiblingColliders, checkIgnoreColliders: false, results);
	}

	public int Cast(Vector2 position, float angle, Vector2 direction, List<RaycastHit2D> results, [Optional] float distance, [Optional] bool ignoreSiblingColliders)
	{
		if ((bool)attachedRigidbody)
		{
			return CastFrom_Internal(position, angle, direction, distance, ignoreSiblingColliders, checkIgnoreColliders: false, results);
		}
		throw new Il2CppSystem.InvalidOperationException("Cannot perform a Collider Cast from a specific position and angle if the Collider is not attached to a Rigidbody2D.");
	}

	public int Cast(Vector2 position, float angle, Vector2 direction, ContactFilter2D contactFilter, List<RaycastHit2D> results, [Optional] float distance, [Optional] bool ignoreSiblingColliders)
	{
		if ((bool)attachedRigidbody)
		{
			return CastFromFiltered_Internal(position, angle, direction, distance, contactFilter, ignoreSiblingColliders, checkIgnoreColliders: false, results);
		}
		throw new Il2CppSystem.InvalidOperationException("Cannot perform a Collider Cast from a specific position and angle if the Collider is not attached to a Rigidbody2D.");
	}

	public unsafe int CastArray_Internal(Vector2 direction, float distance, ContactFilter2D contactFilter, bool ignoreSiblingColliders, bool checkIgnoreColliders, Il2CppStructArray<RaycastHit2D> results)
	{
		//IL_0033: Expected O, but got Ref
		//IL_003a: Expected O, but got Ref
		//IL_0046: Expected O, but got Ref
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
			result = CastArray_Internal_Injected(intPtr, ref direction, distance, ref contactFilter, ignoreSiblingColliders, checkIgnoreColliders, ref results2);
		}
		return result;
	}

	public int CastList_Internal(Vector2 direction, float distance, bool ignoreSiblingColliders, bool checkIgnoreColliders, List<RaycastHit2D> results)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public int CastListFiltered_Internal(Vector2 direction, float distance, ContactFilter2D contactFilter, bool ignoreSiblingColliders, bool checkIgnoreColliders, List<RaycastHit2D> results)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public int CastFrom_Internal(Vector2 position, float angle, Vector2 direction, float distance, bool ignoreSiblingColliders, bool checkIgnoreColliders, List<RaycastHit2D> results)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public int CastFromFiltered_Internal(Vector2 position, float angle, Vector2 direction, float distance, ContactFilter2D contactFilter, bool ignoreSiblingColliders, bool checkIgnoreColliders, List<RaycastHit2D> results)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public int Raycast(Vector2 direction, Il2CppStructArray<RaycastHit2D> results)
	{
		ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(-1, float.NegativeInfinity, float.PositiveInfinity);
		return RaycastArray_Internal(direction, float.PositiveInfinity, contactFilter, results);
	}

	public int Raycast(Vector2 direction, Il2CppStructArray<RaycastHit2D> results, float distance)
	{
		ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(-1, float.NegativeInfinity, float.PositiveInfinity);
		return RaycastArray_Internal(direction, distance, contactFilter, results);
	}

	public int Raycast(Vector2 direction, Il2CppStructArray<RaycastHit2D> results, float distance, int layerMask)
	{
		ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(layerMask, float.NegativeInfinity, float.PositiveInfinity);
		return RaycastArray_Internal(direction, distance, contactFilter, results);
	}

	public int Raycast(Vector2 direction, Il2CppStructArray<RaycastHit2D> results, float distance, int layerMask, float minDepth)
	{
		ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, float.PositiveInfinity);
		return RaycastArray_Internal(direction, distance, contactFilter, results);
	}

	public int Raycast(Vector2 direction, Il2CppStructArray<RaycastHit2D> results, float distance, int layerMask, float minDepth, float maxDepth)
	{
		ContactFilter2D contactFilter = ContactFilter2D.CreateLegacyFilter(layerMask, minDepth, maxDepth);
		return RaycastArray_Internal(direction, distance, contactFilter, results);
	}

	public int Raycast(Vector2 direction, ContactFilter2D contactFilter, Il2CppStructArray<RaycastHit2D> results)
	{
		return RaycastArray_Internal(direction, float.PositiveInfinity, contactFilter, results);
	}

	public int Raycast(Vector2 direction, ContactFilter2D contactFilter, Il2CppStructArray<RaycastHit2D> results, float distance)
	{
		return RaycastArray_Internal(direction, distance, contactFilter, results);
	}

	public unsafe int RaycastArray_Internal(Vector2 direction, float distance, ContactFilter2D contactFilter, Il2CppStructArray<RaycastHit2D> results)
	{
		//IL_002f: Expected O, but got Ref
		//IL_0036: Expected O, but got Ref
		//IL_0042: Expected O, but got Ref
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
			result = RaycastArray_Internal_Injected(intPtr, ref direction, distance, ref contactFilter, ref results2);
		}
		return result;
	}

	public int Raycast(Vector2 direction, ContactFilter2D contactFilter, List<RaycastHit2D> results, [Optional] float distance)
	{
		return RaycastList_Internal(direction, distance, contactFilter, results);
	}

	public int RaycastList_Internal(Vector2 direction, float distance, ContactFilter2D contactFilter, List<RaycastHit2D> results)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public Vector2 ClosestPoint(Vector2 position)
	{
		return Physics2D.ClosestPoint(position, this);
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

	public int OverlapCollider(ContactFilter2D contactFilter, Il2CppReferenceArray<Collider2D> results)
	{
		return Overlap(contactFilter, results);
	}

	public int OverlapCollider(ContactFilter2D contactFilter, List<Collider2D> results)
	{
		return Overlap(contactFilter, results);
	}

	public static float get_density_Injected(System.IntPtr _unity_self)
	{
		return get_density_InjectedDelegateField(_unity_self);
	}

	public static void set_density_Injected(System.IntPtr _unity_self, float value)
	{
		set_density_InjectedDelegateField(_unity_self, value);
	}

	public static bool get_isTrigger_Injected(System.IntPtr _unity_self)
	{
		return get_isTrigger_InjectedDelegateField(_unity_self);
	}

	public static bool get_usedByEffector_Injected(System.IntPtr _unity_self)
	{
		return get_usedByEffector_InjectedDelegateField(_unity_self);
	}

	public static CompositeOperation get_compositeOperation_Injected(System.IntPtr _unity_self)
	{
		return get_compositeOperation_InjectedDelegateField(_unity_self);
	}

	public static int get_compositeOrder_Injected(System.IntPtr _unity_self)
	{
		return get_compositeOrder_InjectedDelegateField(_unity_self);
	}

	public static void set_compositeOrder_Injected(System.IntPtr _unity_self, int value)
	{
		set_compositeOrder_InjectedDelegateField(_unity_self, value);
	}

	public static System.IntPtr get_composite_Injected(System.IntPtr _unity_self)
	{
		return get_composite_InjectedDelegateField(_unity_self);
	}

	public unsafe static void get_offset_Injected(System.IntPtr _unity_self, out Vector2 ret)
	{
		get_offset_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void set_offset_Injected(System.IntPtr _unity_self, [In] ref Vector2 value)
	{
		set_offset_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref value));
	}

	public static System.IntPtr get_attachedRigidbody_Injected(System.IntPtr _unity_self)
	{
		return get_attachedRigidbody_InjectedDelegateField(_unity_self);
	}

	public unsafe static void get_localToWorldMatrix_Injected(System.IntPtr _unity_self, out Matrix4x4 ret)
	{
		get_localToWorldMatrix_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public static int get_shapeCount_Injected(System.IntPtr _unity_self)
	{
		return get_shapeCount_InjectedDelegateField(_unity_self);
	}

	public static System.IntPtr CreateMesh_Injected(System.IntPtr _unity_self, bool useBodyPosition, bool useBodyRotation, bool useDelaunay)
	{
		return CreateMesh_InjectedDelegateField(_unity_self, useBodyPosition, useBodyRotation, useDelaunay);
	}

	public static uint GetShapeHash_Injected(System.IntPtr _unity_self)
	{
		return GetShapeHash_InjectedDelegateField(_unity_self);
	}

	public unsafe static void GetShapeBounds_Injected(System.IntPtr _unity_self, ref BlittableListWrapper bounds, bool useRadii, bool useWorldSpace, out Bounds ret)
	{
		GetShapeBounds_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref bounds), useRadii, useWorldSpace, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void get_bounds_Injected(System.IntPtr _unity_self, out Bounds ret)
	{
		get_bounds_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public static ColliderErrorState2D get_errorState_Injected(System.IntPtr _unity_self)
	{
		return get_errorState_InjectedDelegateField(_unity_self);
	}

	public static bool get_compositeCapable_Injected(System.IntPtr _unity_self)
	{
		return get_compositeCapable_InjectedDelegateField(_unity_self);
	}

	public static System.IntPtr get_sharedMaterial_Injected(System.IntPtr _unity_self)
	{
		return get_sharedMaterial_InjectedDelegateField(_unity_self);
	}

	public static void set_sharedMaterial_Injected(System.IntPtr _unity_self, System.IntPtr value)
	{
		set_sharedMaterial_InjectedDelegateField(_unity_self, value);
	}

	public static int get_layerOverridePriority_Injected(System.IntPtr _unity_self)
	{
		return get_layerOverridePriority_InjectedDelegateField(_unity_self);
	}

	public static void set_layerOverridePriority_Injected(System.IntPtr _unity_self, int value)
	{
		set_layerOverridePriority_InjectedDelegateField(_unity_self, value);
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

	public unsafe static void get_forceSendLayers_Injected(System.IntPtr _unity_self, out LayerMask ret)
	{
		get_forceSendLayers_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void set_forceSendLayers_Injected(System.IntPtr _unity_self, [In] ref LayerMask value)
	{
		set_forceSendLayers_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref value));
	}

	public unsafe static void get_forceReceiveLayers_Injected(System.IntPtr _unity_self, out LayerMask ret)
	{
		get_forceReceiveLayers_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void set_forceReceiveLayers_Injected(System.IntPtr _unity_self, [In] ref LayerMask value)
	{
		set_forceReceiveLayers_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref value));
	}

	public unsafe static void get_contactCaptureLayers_Injected(System.IntPtr _unity_self, out LayerMask ret)
	{
		get_contactCaptureLayers_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void set_contactCaptureLayers_Injected(System.IntPtr _unity_self, [In] ref LayerMask value)
	{
		set_contactCaptureLayers_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref value));
	}

	public unsafe static void get_callbackLayers_Injected(System.IntPtr _unity_self, out LayerMask ret)
	{
		get_callbackLayers_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void set_callbackLayers_Injected(System.IntPtr _unity_self, [In] ref LayerMask value)
	{
		set_callbackLayers_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref value));
	}

	public static float get_friction_Injected(System.IntPtr _unity_self)
	{
		return get_friction_InjectedDelegateField(_unity_self);
	}

	public static float get_bounciness_Injected(System.IntPtr _unity_self)
	{
		return get_bounciness_InjectedDelegateField(_unity_self);
	}

	public static PhysicsMaterialCombine2D get_frictionCombine_Injected(System.IntPtr _unity_self)
	{
		return get_frictionCombine_InjectedDelegateField(_unity_self);
	}

	public static PhysicsMaterialCombine2D get_bounceCombine_Injected(System.IntPtr _unity_self)
	{
		return get_bounceCombine_InjectedDelegateField(_unity_self);
	}

	public unsafe static void get_contactMask_Injected(System.IntPtr _unity_self, out LayerMask ret)
	{
		get_contactMask_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public static bool IsTouching_Injected(System.IntPtr _unity_self, System.IntPtr collider)
	{
		return IsTouching_InjectedDelegateField(_unity_self, collider);
	}

	public unsafe static bool IsTouching_OtherColliderWithFilter_Injected(System.IntPtr _unity_self, System.IntPtr collider, [In] ref ContactFilter2D contactFilter)
	{
		return IsTouching_OtherColliderWithFilter_InjectedDelegateField(_unity_self, collider, (nint)Unsafe.AsPointer(ref contactFilter));
	}

	public unsafe static bool IsTouching_AnyColliderWithFilter_Injected(System.IntPtr _unity_self, [In] ref ContactFilter2D contactFilter)
	{
		return IsTouching_AnyColliderWithFilter_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref contactFilter));
	}

	public static bool IsTouchingLayers_Injected(System.IntPtr _unity_self, int layerMask)
	{
		return IsTouchingLayers_InjectedDelegateField(_unity_self, layerMask);
	}

	public unsafe static bool OverlapPoint_Injected(System.IntPtr _unity_self, [In] ref Vector2 point)
	{
		return OverlapPoint_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref point));
	}

	public unsafe static int CastArray_Internal_Injected(System.IntPtr _unity_self, [In] ref Vector2 direction, float distance, [In] ref ContactFilter2D contactFilter, bool ignoreSiblingColliders, bool checkIgnoreColliders, ref ManagedSpanWrapper results)
	{
		return CastArray_Internal_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref direction), distance, (nint)Unsafe.AsPointer(ref contactFilter), ignoreSiblingColliders, checkIgnoreColliders, (nint)Unsafe.AsPointer(ref results));
	}

	public unsafe static int CastList_Internal_Injected(System.IntPtr _unity_self, [In] ref Vector2 direction, float distance, bool ignoreSiblingColliders, bool checkIgnoreColliders, ref BlittableListWrapper results)
	{
		return CastList_Internal_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref direction), distance, ignoreSiblingColliders, checkIgnoreColliders, (nint)Unsafe.AsPointer(ref results));
	}

	public unsafe static int CastListFiltered_Internal_Injected(System.IntPtr _unity_self, [In] ref Vector2 direction, float distance, [In] ref ContactFilter2D contactFilter, bool ignoreSiblingColliders, bool checkIgnoreColliders, ref BlittableListWrapper results)
	{
		return CastListFiltered_Internal_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref direction), distance, (nint)Unsafe.AsPointer(ref contactFilter), ignoreSiblingColliders, checkIgnoreColliders, (nint)Unsafe.AsPointer(ref results));
	}

	public unsafe static int CastFrom_Internal_Injected(System.IntPtr _unity_self, [In] ref Vector2 position, float angle, [In] ref Vector2 direction, float distance, bool ignoreSiblingColliders, bool checkIgnoreColliders, ref BlittableListWrapper results)
	{
		return CastFrom_Internal_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref position), angle, (nint)Unsafe.AsPointer(ref direction), distance, ignoreSiblingColliders, checkIgnoreColliders, (nint)Unsafe.AsPointer(ref results));
	}

	public unsafe static int CastFromFiltered_Internal_Injected(System.IntPtr _unity_self, [In] ref Vector2 position, float angle, [In] ref Vector2 direction, float distance, [In] ref ContactFilter2D contactFilter, bool ignoreSiblingColliders, bool checkIgnoreColliders, ref BlittableListWrapper results)
	{
		return CastFromFiltered_Internal_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref position), angle, (nint)Unsafe.AsPointer(ref direction), distance, (nint)Unsafe.AsPointer(ref contactFilter), ignoreSiblingColliders, checkIgnoreColliders, (nint)Unsafe.AsPointer(ref results));
	}

	public unsafe static int RaycastArray_Internal_Injected(System.IntPtr _unity_self, [In] ref Vector2 direction, float distance, [In] ref ContactFilter2D contactFilter, ref ManagedSpanWrapper results)
	{
		return RaycastArray_Internal_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref direction), distance, (nint)Unsafe.AsPointer(ref contactFilter), (nint)Unsafe.AsPointer(ref results));
	}

	public unsafe static int RaycastList_Internal_Injected(System.IntPtr _unity_self, [In] ref Vector2 direction, float distance, [In] ref ContactFilter2D contactFilter, ref BlittableListWrapper results)
	{
		return RaycastList_Internal_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref direction), distance, (nint)Unsafe.AsPointer(ref contactFilter), (nint)Unsafe.AsPointer(ref results));
	}
}
