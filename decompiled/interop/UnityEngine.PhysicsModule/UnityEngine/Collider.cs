using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using UnityEngine.Bindings;

namespace UnityEngine;

public class Collider : Component
{
	private delegate void set_enabled_InjectedDelegate(IntPtr _unity_self, bool value);

	private delegate IntPtr get_attachedRigidbody_InjectedDelegate(IntPtr _unity_self);

	private delegate IntPtr get_attachedArticulationBody_InjectedDelegate(IntPtr _unity_self);

	private delegate bool get_isTrigger_InjectedDelegate(IntPtr _unity_self);

	private delegate float get_contactOffset_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_contactOffset_InjectedDelegate(IntPtr _unity_self, float value);

	private delegate void get_bounds_InjectedDelegate(IntPtr _unity_self, [Out] IntPtr ret);

	private delegate bool get_hasModifiableContacts_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_hasModifiableContacts_InjectedDelegate(IntPtr _unity_self, bool value);

	private delegate bool get_providesContacts_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_providesContacts_InjectedDelegate(IntPtr _unity_self, bool value);

	private delegate int get_layerOverridePriority_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_layerOverridePriority_InjectedDelegate(IntPtr _unity_self, int value);

	private delegate void get_excludeLayers_InjectedDelegate(IntPtr _unity_self, [Out] IntPtr ret);

	private delegate void set_excludeLayers_InjectedDelegate(IntPtr _unity_self, [In] IntPtr value);

	private delegate void get_includeLayers_InjectedDelegate(IntPtr _unity_self, [Out] IntPtr ret);

	private delegate void set_includeLayers_InjectedDelegate(IntPtr _unity_self, [In] IntPtr value);

	private delegate IntPtr get_sharedMaterial_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_sharedMaterial_InjectedDelegate(IntPtr _unity_self, IntPtr value);

	private delegate IntPtr get_material_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_material_InjectedDelegate(IntPtr _unity_self, IntPtr value);

	private delegate void Internal_ClosestPointOnBounds_InjectedDelegate(IntPtr _unity_self, [In] IntPtr point, IntPtr outPos, IntPtr distance);

	private static readonly IntPtr NativeMethodInfoPtr_get_enabled_Public_get_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_isTrigger_Public_set_Void_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_ClosestPoint_Public_Vector3_Vector3_0;

	private static readonly IntPtr NativeMethodInfoPtr_Raycast_Private_RaycastHit_Ray_Single_byref_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_Raycast_Public_Boolean_Ray_byref_RaycastHit_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_enabled_Injected_Private_Static_Boolean_IntPtr_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_isTrigger_Injected_Private_Static_Void_IntPtr_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_ClosestPoint_Injected_Private_Static_Void_IntPtr_byref_Vector3_byref_Vector3_0;

	private static readonly IntPtr NativeMethodInfoPtr_Raycast_Injected_Private_Static_Void_IntPtr_byref_Ray_Single_byref_Boolean_byref_RaycastHit_0;

	private static readonly set_enabled_InjectedDelegate set_enabled_InjectedDelegateField;

	private static readonly get_attachedRigidbody_InjectedDelegate get_attachedRigidbody_InjectedDelegateField;

	private static readonly get_attachedArticulationBody_InjectedDelegate get_attachedArticulationBody_InjectedDelegateField;

	private static readonly get_isTrigger_InjectedDelegate get_isTrigger_InjectedDelegateField;

	private static readonly get_contactOffset_InjectedDelegate get_contactOffset_InjectedDelegateField;

	private static readonly set_contactOffset_InjectedDelegate set_contactOffset_InjectedDelegateField;

	private static readonly get_bounds_InjectedDelegate get_bounds_InjectedDelegateField;

	private static readonly get_hasModifiableContacts_InjectedDelegate get_hasModifiableContacts_InjectedDelegateField;

	private static readonly set_hasModifiableContacts_InjectedDelegate set_hasModifiableContacts_InjectedDelegateField;

	private static readonly get_providesContacts_InjectedDelegate get_providesContacts_InjectedDelegateField;

	private static readonly set_providesContacts_InjectedDelegate set_providesContacts_InjectedDelegateField;

	private static readonly get_layerOverridePriority_InjectedDelegate get_layerOverridePriority_InjectedDelegateField;

	private static readonly set_layerOverridePriority_InjectedDelegate set_layerOverridePriority_InjectedDelegateField;

	private static readonly get_excludeLayers_InjectedDelegate get_excludeLayers_InjectedDelegateField;

	private static readonly set_excludeLayers_InjectedDelegate set_excludeLayers_InjectedDelegateField;

	private static readonly get_includeLayers_InjectedDelegate get_includeLayers_InjectedDelegateField;

	private static readonly set_includeLayers_InjectedDelegate set_includeLayers_InjectedDelegateField;

	private static readonly get_sharedMaterial_InjectedDelegate get_sharedMaterial_InjectedDelegateField;

	private static readonly set_sharedMaterial_InjectedDelegate set_sharedMaterial_InjectedDelegateField;

	private static readonly get_material_InjectedDelegate get_material_InjectedDelegateField;

	private static readonly set_material_InjectedDelegate set_material_InjectedDelegateField;

	private static readonly Internal_ClosestPointOnBounds_InjectedDelegate Internal_ClosestPointOnBounds_InjectedDelegateField;

	public unsafe bool enabled
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1259203, RefRangeEnd = 1259205, XrefRangeStart = 1259198, XrefRangeEnd = 1259203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_enabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_enabled_Injected(intPtr, value);
		}
	}

	public unsafe bool isTrigger
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_isTrigger_Injected(intPtr);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1259210, RefRangeEnd = 1259211, XrefRangeStart = 1259205, XrefRangeEnd = 1259210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_isTrigger_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public Rigidbody attachedRigidbody
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return Unmarshal.UnmarshalUnityObject<Rigidbody>(get_attachedRigidbody_Injected(intPtr));
		}
	}

	public ArticulationBody attachedArticulationBody
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return Unmarshal.UnmarshalUnityObject<ArticulationBody>(get_attachedArticulationBody_Injected(intPtr));
		}
	}

	public float contactOffset
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_contactOffset_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_contactOffset_Injected(intPtr, value);
		}
	}

	public Bounds bounds
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			get_bounds_Injected(intPtr, out var ret);
			return ret;
		}
	}

	public bool hasModifiableContacts
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_hasModifiableContacts_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_hasModifiableContacts_Injected(intPtr, value);
		}
	}

	public bool providesContacts
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_providesContacts_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_providesContacts_Injected(intPtr, value);
		}
	}

	public int layerOverridePriority
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_layerOverridePriority_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_layerOverridePriority_Injected(intPtr, value);
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

	public PhysicsMaterial sharedMaterial
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return Unmarshal.UnmarshalUnityObject<PhysicsMaterial>(get_sharedMaterial_Injected(intPtr));
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_sharedMaterial_Injected(intPtr, MarshalledUnityObject.Marshal(value));
		}
	}

	public PhysicsMaterial material
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return Unmarshal.UnmarshalUnityObject<PhysicsMaterial>(get_material_Injected(intPtr));
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_material_Injected(intPtr, MarshalledUnityObject.Marshal(value));
		}
	}

	static Collider()
	{
		Il2CppClassPointerStore<Collider>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.PhysicsModule.dll", "UnityEngine", "Collider");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Collider>.NativeClassPtr);
		NativeMethodInfoPtr_get_enabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Collider>.NativeClassPtr, 100663312);
		NativeMethodInfoPtr_set_isTrigger_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Collider>.NativeClassPtr, 100663313);
		NativeMethodInfoPtr_ClosestPoint_Public_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Collider>.NativeClassPtr, 100663314);
		NativeMethodInfoPtr_Raycast_Private_RaycastHit_Ray_Single_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Collider>.NativeClassPtr, 100663315);
		NativeMethodInfoPtr_Raycast_Public_Boolean_Ray_byref_RaycastHit_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Collider>.NativeClassPtr, 100663316);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Collider>.NativeClassPtr, 100663317);
		NativeMethodInfoPtr_get_enabled_Injected_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Collider>.NativeClassPtr, 100663318);
		NativeMethodInfoPtr_set_isTrigger_Injected_Private_Static_Void_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Collider>.NativeClassPtr, 100663319);
		NativeMethodInfoPtr_ClosestPoint_Injected_Private_Static_Void_IntPtr_byref_Vector3_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Collider>.NativeClassPtr, 100663320);
		NativeMethodInfoPtr_Raycast_Injected_Private_Static_Void_IntPtr_byref_Ray_Single_byref_Boolean_byref_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Collider>.NativeClassPtr, 100663321);
		set_enabled_InjectedDelegateField = IL2CPP.ResolveICall<set_enabled_InjectedDelegate>("UnityEngine.Collider::set_enabled_Injected");
		get_attachedRigidbody_InjectedDelegateField = IL2CPP.ResolveICall<get_attachedRigidbody_InjectedDelegate>("UnityEngine.Collider::get_attachedRigidbody_Injected");
		get_attachedArticulationBody_InjectedDelegateField = IL2CPP.ResolveICall<get_attachedArticulationBody_InjectedDelegate>("UnityEngine.Collider::get_attachedArticulationBody_Injected");
		get_isTrigger_InjectedDelegateField = IL2CPP.ResolveICall<get_isTrigger_InjectedDelegate>("UnityEngine.Collider::get_isTrigger_Injected");
		get_contactOffset_InjectedDelegateField = IL2CPP.ResolveICall<get_contactOffset_InjectedDelegate>("UnityEngine.Collider::get_contactOffset_Injected");
		set_contactOffset_InjectedDelegateField = IL2CPP.ResolveICall<set_contactOffset_InjectedDelegate>("UnityEngine.Collider::set_contactOffset_Injected");
		get_bounds_InjectedDelegateField = IL2CPP.ResolveICall<get_bounds_InjectedDelegate>("UnityEngine.Collider::get_bounds_Injected");
		get_hasModifiableContacts_InjectedDelegateField = IL2CPP.ResolveICall<get_hasModifiableContacts_InjectedDelegate>("UnityEngine.Collider::get_hasModifiableContacts_Injected");
		set_hasModifiableContacts_InjectedDelegateField = IL2CPP.ResolveICall<set_hasModifiableContacts_InjectedDelegate>("UnityEngine.Collider::set_hasModifiableContacts_Injected");
		get_providesContacts_InjectedDelegateField = IL2CPP.ResolveICall<get_providesContacts_InjectedDelegate>("UnityEngine.Collider::get_providesContacts_Injected");
		set_providesContacts_InjectedDelegateField = IL2CPP.ResolveICall<set_providesContacts_InjectedDelegate>("UnityEngine.Collider::set_providesContacts_Injected");
		get_layerOverridePriority_InjectedDelegateField = IL2CPP.ResolveICall<get_layerOverridePriority_InjectedDelegate>("UnityEngine.Collider::get_layerOverridePriority_Injected");
		set_layerOverridePriority_InjectedDelegateField = IL2CPP.ResolveICall<set_layerOverridePriority_InjectedDelegate>("UnityEngine.Collider::set_layerOverridePriority_Injected");
		get_excludeLayers_InjectedDelegateField = IL2CPP.ResolveICall<get_excludeLayers_InjectedDelegate>("UnityEngine.Collider::get_excludeLayers_Injected");
		set_excludeLayers_InjectedDelegateField = IL2CPP.ResolveICall<set_excludeLayers_InjectedDelegate>("UnityEngine.Collider::set_excludeLayers_Injected");
		get_includeLayers_InjectedDelegateField = IL2CPP.ResolveICall<get_includeLayers_InjectedDelegate>("UnityEngine.Collider::get_includeLayers_Injected");
		set_includeLayers_InjectedDelegateField = IL2CPP.ResolveICall<set_includeLayers_InjectedDelegate>("UnityEngine.Collider::set_includeLayers_Injected");
		get_sharedMaterial_InjectedDelegateField = IL2CPP.ResolveICall<get_sharedMaterial_InjectedDelegate>("UnityEngine.Collider::get_sharedMaterial_Injected");
		set_sharedMaterial_InjectedDelegateField = IL2CPP.ResolveICall<set_sharedMaterial_InjectedDelegate>("UnityEngine.Collider::set_sharedMaterial_Injected");
		get_material_InjectedDelegateField = IL2CPP.ResolveICall<get_material_InjectedDelegate>("UnityEngine.Collider::get_material_Injected");
		set_material_InjectedDelegateField = IL2CPP.ResolveICall<set_material_InjectedDelegate>("UnityEngine.Collider::set_material_Injected");
		Internal_ClosestPointOnBounds_InjectedDelegateField = IL2CPP.ResolveICall<Internal_ClosestPointOnBounds_InjectedDelegate>("UnityEngine.Collider::Internal_ClosestPointOnBounds_Injected");
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1259215, RefRangeEnd = 1259217, XrefRangeStart = 1259211, XrefRangeEnd = 1259215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 ClosestPoint(Vector3 position)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&position);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClosestPoint_Public_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259217, XrefRangeEnd = 1259221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RaycastHit Raycast(Ray ray, float maxDistance, ref bool hasHit)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = (nint)(&ray);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &maxDistance;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = Unsafe.AsPointer(ref hasHit);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Raycast_Private_RaycastHit_Ray_Single_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(RaycastHit*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1259225, RefRangeEnd = 1259228, XrefRangeStart = 1259221, XrefRangeEnd = 1259225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = (nint)(&ray);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = Unsafe.AsPointer(ref hitInfo);
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &maxDistance;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Raycast_Public_Boolean_Ray_byref_RaycastHit_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(646)]
	[CachedScanResults(RefRangeStart = 1152221, RefRangeEnd = 1152867, XrefRangeStart = 1152221, XrefRangeEnd = 1152867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Collider()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Collider>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259228, XrefRangeEnd = 1259230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool get_enabled_Injected(IntPtr _unity_self)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_enabled_Injected_Private_Static_Boolean_IntPtr_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259230, XrefRangeEnd = 1259232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_isTrigger_Injected(IntPtr _unity_self, bool value)
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &value;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_isTrigger_Injected_Private_Static_Void_IntPtr_Boolean_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259232, XrefRangeEnd = 1259234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ClosestPoint_Injected(IntPtr _unity_self, [In] ref Vector3 position, out Vector3 ret)
	{
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = Unsafe.AsPointer(ref position);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClosestPoint_Injected_Private_Static_Void_IntPtr_byref_Vector3_byref_Vector3_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259234, XrefRangeEnd = 1259236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Raycast_Injected(IntPtr _unity_self, [In] ref Ray ray, float maxDistance, ref bool hasHit, out RaycastHit ret)
	{
		IntPtr* ptr = stackalloc IntPtr[5];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = Unsafe.AsPointer(ref ray);
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &maxDistance;
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = Unsafe.AsPointer(ref hasHit);
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Raycast_Injected_Private_Static_Void_IntPtr_byref_Ray_Single_byref_Boolean_byref_RaycastHit_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public Collider(IntPtr pointer)
		: base(pointer)
	{
	}

	public T GetGeometry<T>() where T : struct
	{
		throw new NotSupportedException("Method unstripping failed");
	}

	public void Internal_ClosestPointOnBounds(Vector3 point, ref Vector3 outPos, ref float distance)
	{
		IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (IntPtr)0)
		{
			ThrowHelper.ThrowNullReferenceException(this);
		}
		Internal_ClosestPointOnBounds_Injected(intPtr, ref point, ref outPos, ref distance);
	}

	public Vector3 ClosestPointOnBounds(Vector3 position)
	{
		float distance = 0f;
		Vector3 outPos = Vector3.zero;
		Internal_ClosestPointOnBounds(position, ref outPos, ref distance);
		return outPos;
	}

	public static void set_enabled_Injected(IntPtr _unity_self, bool value)
	{
		set_enabled_InjectedDelegateField(_unity_self, value);
	}

	public static IntPtr get_attachedRigidbody_Injected(IntPtr _unity_self)
	{
		return get_attachedRigidbody_InjectedDelegateField(_unity_self);
	}

	public static IntPtr get_attachedArticulationBody_Injected(IntPtr _unity_self)
	{
		return get_attachedArticulationBody_InjectedDelegateField(_unity_self);
	}

	public static bool get_isTrigger_Injected(IntPtr _unity_self)
	{
		return get_isTrigger_InjectedDelegateField(_unity_self);
	}

	public static float get_contactOffset_Injected(IntPtr _unity_self)
	{
		return get_contactOffset_InjectedDelegateField(_unity_self);
	}

	public static void set_contactOffset_Injected(IntPtr _unity_self, float value)
	{
		set_contactOffset_InjectedDelegateField(_unity_self, value);
	}

	public unsafe static void get_bounds_Injected(IntPtr _unity_self, out Bounds ret)
	{
		get_bounds_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public static bool get_hasModifiableContacts_Injected(IntPtr _unity_self)
	{
		return get_hasModifiableContacts_InjectedDelegateField(_unity_self);
	}

	public static void set_hasModifiableContacts_Injected(IntPtr _unity_self, bool value)
	{
		set_hasModifiableContacts_InjectedDelegateField(_unity_self, value);
	}

	public static bool get_providesContacts_Injected(IntPtr _unity_self)
	{
		return get_providesContacts_InjectedDelegateField(_unity_self);
	}

	public static void set_providesContacts_Injected(IntPtr _unity_self, bool value)
	{
		set_providesContacts_InjectedDelegateField(_unity_self, value);
	}

	public static int get_layerOverridePriority_Injected(IntPtr _unity_self)
	{
		return get_layerOverridePriority_InjectedDelegateField(_unity_self);
	}

	public static void set_layerOverridePriority_Injected(IntPtr _unity_self, int value)
	{
		set_layerOverridePriority_InjectedDelegateField(_unity_self, value);
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

	public static IntPtr get_sharedMaterial_Injected(IntPtr _unity_self)
	{
		return get_sharedMaterial_InjectedDelegateField(_unity_self);
	}

	public static void set_sharedMaterial_Injected(IntPtr _unity_self, IntPtr value)
	{
		set_sharedMaterial_InjectedDelegateField(_unity_self, value);
	}

	public static IntPtr get_material_Injected(IntPtr _unity_self)
	{
		return get_material_InjectedDelegateField(_unity_self);
	}

	public static void set_material_Injected(IntPtr _unity_self, IntPtr value)
	{
		set_material_InjectedDelegateField(_unity_self, value);
	}

	public unsafe static void Internal_ClosestPointOnBounds_Injected(IntPtr _unity_self, [In] ref Vector3 point, ref Vector3 outPos, ref float distance)
	{
		Internal_ClosestPointOnBounds_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref point), (nint)Unsafe.AsPointer(ref outPos), (nint)Unsafe.AsPointer(ref distance));
	}
}
