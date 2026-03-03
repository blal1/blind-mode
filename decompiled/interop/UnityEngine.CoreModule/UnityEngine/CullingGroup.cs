using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Bindings;

namespace UnityEngine;

public class CullingGroup : Il2CppSystem.Object
{
	public sealed class StateChanged : Il2CppSystem.MulticastDelegate
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_CullingGroupEvent_0;

		static StateChanged()
		{
			Il2CppClassPointerStore<StateChanged>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CullingGroup>.NativeClassPtr, "StateChanged");
			NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateChanged>.NativeClassPtr, 100664044);
			NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_CullingGroupEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateChanged>.NativeClassPtr, 100664045);
		}

		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 1169207, RefRangeEnd = 1169217, XrefRangeStart = 1169204, XrefRangeEnd = 1169207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StateChanged(Il2CppSystem.Object @object, System.IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StateChanged>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
			*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		public unsafe virtual void Invoke(CullingGroupEvent sphere)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&sphere);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_CullingGroupEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public StateChanged(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public static implicit operator StateChanged(System.Action<CullingGroupEvent> P_0)
		{
			return DelegateSupport.ConvertDelegate<StateChanged>((System.Delegate)P_0);
		}

		public static StateChanged operator +(StateChanged P_0, StateChanged P_1)
		{
			return ((Il2CppObjectBase)Il2CppSystem.Delegate.Combine(P_0, P_1)).Cast<StateChanged>();
		}

		public static StateChanged operator -(StateChanged P_0, StateChanged P_1)
		{
			object obj = Il2CppSystem.Delegate.Remove(P_0, P_1);
			if (obj != null)
			{
				obj = ((Il2CppObjectBase)obj).Cast<StateChanged>();
			}
			return (StateChanged)obj;
		}
	}

	public static class BindingsMarshaller : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeMethodInfoPtr_ConvertToNative_Public_Static_IntPtr_CullingGroup_0;

		static BindingsMarshaller()
		{
			Il2CppClassPointerStore<BindingsMarshaller>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CullingGroup>.NativeClassPtr, "BindingsMarshaller");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BindingsMarshaller>.NativeClassPtr);
			NativeMethodInfoPtr_ConvertToNative_Public_Static_IntPtr_CullingGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingsMarshaller>.NativeClassPtr, 100664046);
		}

		[CallerCount(0)]
		public unsafe static System.IntPtr ConvertToNative(CullingGroup cullingGroup)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cullingGroup);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConvertToNative_Public_Static_IntPtr_CullingGroup_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		public BindingsMarshaller(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private delegate bool get_enabled_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_enabled_InjectedDelegate(System.IntPtr _unity_self, bool value);

	private delegate System.IntPtr get_targetCamera_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void EraseSwapBack_InjectedDelegate(System.IntPtr _unity_self, int index);

	private delegate bool IsVisible_InjectedDelegate(System.IntPtr _unity_self, int index);

	private delegate int GetDistance_InjectedDelegate(System.IntPtr _unity_self, int index);

	private delegate void SetDistanceReferencePoint_InternalTransform_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr transform);

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Ptr;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_OnStateChanged;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DisposeInternal_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_targetCamera_Public_set_Void_Camera_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetBoundingSpheres_Public_Void_Il2CppStructArray_1_BoundingSphere_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetBoundingSphereCount_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_QueryIndices_Public_Int32_Boolean_Il2CppStructArray_1_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_QueryIndices_Private_Int32_Boolean_Int32_CullingQueryOptions_Il2CppStructArray_1_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetBoundingDistances_Public_Void_Il2CppStructArray_1_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetDistanceReferencePoint_InternalVector3_Private_Void_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetDistanceReferencePoint_Public_Void_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SendEvents_Private_Static_Void_CullingGroup_IntPtr_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Init_Private_Static_IntPtr_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FinalizerFailure_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DisposeInternal_Injected_Private_Static_Void_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_targetCamera_Injected_Private_Static_Void_IntPtr_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetBoundingSpheres_Injected_Private_Static_Void_IntPtr_Il2CppStructArray_1_BoundingSphere_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetBoundingSphereCount_Injected_Private_Static_Void_IntPtr_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_QueryIndices_Injected_Private_Static_Int32_IntPtr_Boolean_Int32_CullingQueryOptions_byref_ManagedSpanWrapper_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetBoundingDistances_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetDistanceReferencePoint_InternalVector3_Injected_Private_Static_Void_IntPtr_byref_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FinalizerFailure_Injected_Private_Static_Void_IntPtr_0;

	private static readonly get_enabled_InjectedDelegate get_enabled_InjectedDelegateField;

	private static readonly set_enabled_InjectedDelegate set_enabled_InjectedDelegateField;

	private static readonly get_targetCamera_InjectedDelegate get_targetCamera_InjectedDelegateField;

	private static readonly EraseSwapBack_InjectedDelegate EraseSwapBack_InjectedDelegateField;

	private static readonly IsVisible_InjectedDelegate IsVisible_InjectedDelegateField;

	private static readonly GetDistance_InjectedDelegate GetDistance_InjectedDelegateField;

	private static readonly SetDistanceReferencePoint_InternalTransform_InjectedDelegate SetDistanceReferencePoint_InternalTransform_InjectedDelegateField;

	public unsafe System.IntPtr m_Ptr
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Ptr);
			return *(System.IntPtr*)num;
		}
		set
		{
			*(System.IntPtr*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Ptr)) = value;
		}
	}

	public unsafe StateChanged m_OnStateChanged
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_OnStateChanged);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<StateChanged>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_OnStateChanged)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Camera targetCamera
	{
		get
		{
			System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return Unmarshal.UnmarshalUnityObject<Camera>(get_targetCamera_Injected(intPtr));
		}
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1169242, RefRangeEnd = 1169244, XrefRangeStart = 1169235, XrefRangeEnd = 1169242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_targetCamera_Public_set_Void_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public StateChanged onStateChanged
	{
		get
		{
			return m_OnStateChanged;
		}
		set
		{
			m_OnStateChanged = value;
		}
	}

	public bool enabled
	{
		get
		{
			System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_enabled_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_enabled_Injected(intPtr, value);
		}
	}

	static CullingGroup()
	{
		Il2CppClassPointerStore<CullingGroup>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "CullingGroup");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CullingGroup>.NativeClassPtr);
		NativeFieldInfoPtr_m_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CullingGroup>.NativeClassPtr, "m_Ptr");
		NativeFieldInfoPtr_m_OnStateChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CullingGroup>.NativeClassPtr, "m_OnStateChanged");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingGroup>.NativeClassPtr, 100664021);
		NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingGroup>.NativeClassPtr, 100664022);
		NativeMethodInfoPtr_DisposeInternal_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingGroup>.NativeClassPtr, 100664023);
		NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingGroup>.NativeClassPtr, 100664024);
		NativeMethodInfoPtr_set_targetCamera_Public_set_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingGroup>.NativeClassPtr, 100664025);
		NativeMethodInfoPtr_SetBoundingSpheres_Public_Void_Il2CppStructArray_1_BoundingSphere_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingGroup>.NativeClassPtr, 100664026);
		NativeMethodInfoPtr_SetBoundingSphereCount_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingGroup>.NativeClassPtr, 100664027);
		NativeMethodInfoPtr_QueryIndices_Public_Int32_Boolean_Il2CppStructArray_1_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingGroup>.NativeClassPtr, 100664028);
		NativeMethodInfoPtr_QueryIndices_Private_Int32_Boolean_Int32_CullingQueryOptions_Il2CppStructArray_1_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingGroup>.NativeClassPtr, 100664029);
		NativeMethodInfoPtr_SetBoundingDistances_Public_Void_Il2CppStructArray_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingGroup>.NativeClassPtr, 100664030);
		NativeMethodInfoPtr_SetDistanceReferencePoint_InternalVector3_Private_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingGroup>.NativeClassPtr, 100664031);
		NativeMethodInfoPtr_SetDistanceReferencePoint_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingGroup>.NativeClassPtr, 100664032);
		NativeMethodInfoPtr_SendEvents_Private_Static_Void_CullingGroup_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingGroup>.NativeClassPtr, 100664033);
		NativeMethodInfoPtr_Init_Private_Static_IntPtr_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingGroup>.NativeClassPtr, 100664034);
		NativeMethodInfoPtr_FinalizerFailure_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingGroup>.NativeClassPtr, 100664035);
		NativeMethodInfoPtr_DisposeInternal_Injected_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingGroup>.NativeClassPtr, 100664036);
		NativeMethodInfoPtr_set_targetCamera_Injected_Private_Static_Void_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingGroup>.NativeClassPtr, 100664037);
		NativeMethodInfoPtr_SetBoundingSpheres_Injected_Private_Static_Void_IntPtr_Il2CppStructArray_1_BoundingSphere_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingGroup>.NativeClassPtr, 100664038);
		NativeMethodInfoPtr_SetBoundingSphereCount_Injected_Private_Static_Void_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingGroup>.NativeClassPtr, 100664039);
		NativeMethodInfoPtr_QueryIndices_Injected_Private_Static_Int32_IntPtr_Boolean_Int32_CullingQueryOptions_byref_ManagedSpanWrapper_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingGroup>.NativeClassPtr, 100664040);
		NativeMethodInfoPtr_SetBoundingDistances_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingGroup>.NativeClassPtr, 100664041);
		NativeMethodInfoPtr_SetDistanceReferencePoint_InternalVector3_Injected_Private_Static_Void_IntPtr_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingGroup>.NativeClassPtr, 100664042);
		NativeMethodInfoPtr_FinalizerFailure_Injected_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingGroup>.NativeClassPtr, 100664043);
		get_enabled_InjectedDelegateField = IL2CPP.ResolveICall<get_enabled_InjectedDelegate>("UnityEngine.CullingGroup::get_enabled_Injected");
		set_enabled_InjectedDelegateField = IL2CPP.ResolveICall<set_enabled_InjectedDelegate>("UnityEngine.CullingGroup::set_enabled_Injected");
		get_targetCamera_InjectedDelegateField = IL2CPP.ResolveICall<get_targetCamera_InjectedDelegate>("UnityEngine.CullingGroup::get_targetCamera_Injected");
		EraseSwapBack_InjectedDelegateField = IL2CPP.ResolveICall<EraseSwapBack_InjectedDelegate>("UnityEngine.CullingGroup::EraseSwapBack_Injected");
		IsVisible_InjectedDelegateField = IL2CPP.ResolveICall<IsVisible_InjectedDelegate>("UnityEngine.CullingGroup::IsVisible_Injected");
		GetDistance_InjectedDelegateField = IL2CPP.ResolveICall<GetDistance_InjectedDelegate>("UnityEngine.CullingGroup::GetDistance_Injected");
		SetDistanceReferencePoint_InternalTransform_InjectedDelegateField = IL2CPP.ResolveICall<SetDistanceReferencePoint_InternalTransform_InjectedDelegate>("UnityEngine.CullingGroup::SetDistanceReferencePoint_InternalTransform_Injected");
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1169221, RefRangeEnd = 1169222, XrefRangeStart = 1169217, XrefRangeEnd = 1169221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CullingGroup()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CullingGroup>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1169222, XrefRangeEnd = 1169227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void Finalize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1169227, XrefRangeEnd = 1169231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DisposeInternal()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DisposeInternal_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1169234, RefRangeEnd = 1169235, XrefRangeStart = 1169231, XrefRangeEnd = 1169234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Dispose()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1169248, RefRangeEnd = 1169250, XrefRangeStart = 1169244, XrefRangeEnd = 1169248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetBoundingSpheres(Il2CppStructArray<BoundingSphere> array)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)array);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetBoundingSpheres_Public_Void_Il2CppStructArray_1_BoundingSphere_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1169254, RefRangeEnd = 1169256, XrefRangeStart = 1169250, XrefRangeEnd = 1169254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetBoundingSphereCount(int count)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&count);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetBoundingSphereCount_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1169266, RefRangeEnd = 1169268, XrefRangeStart = 1169256, XrefRangeEnd = 1169266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int QueryIndices(bool visible, Il2CppStructArray<int> result, int firstIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&visible);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)result);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &firstIndex;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_QueryIndices_Public_Int32_Boolean_Il2CppStructArray_1_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1169268, XrefRangeEnd = 1169278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int QueryIndices(bool visible, int distanceIndex, CullingQueryOptions options, Il2CppStructArray<int> result, int firstIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&visible);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &distanceIndex;
		*(CullingQueryOptions**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &options;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)result);
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &firstIndex;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_QueryIndices_Private_Int32_Boolean_Int32_CullingQueryOptions_Il2CppStructArray_1_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1169288, RefRangeEnd = 1169290, XrefRangeStart = 1169278, XrefRangeEnd = 1169288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetBoundingDistances(Il2CppStructArray<float> distances)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)distances);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetBoundingDistances_Public_Void_Il2CppStructArray_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1169290, XrefRangeEnd = 1169293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetDistanceReferencePoint_InternalVector3(Vector3 point)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&point);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetDistanceReferencePoint_InternalVector3_Private_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1169296, RefRangeEnd = 1169298, XrefRangeStart = 1169293, XrefRangeEnd = 1169296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetDistanceReferencePoint(Vector3 point)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&point);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetDistanceReferencePoint_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe static void SendEvents(CullingGroup cullingGroup, System.IntPtr eventsPtr, int count)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cullingGroup);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &eventsPtr;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SendEvents_Private_Static_Void_CullingGroup_IntPtr_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1169298, XrefRangeEnd = 1169300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr Init(Il2CppSystem.Object scripting)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)scripting);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Init_Private_Static_IntPtr_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1169300, XrefRangeEnd = 1169304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FinalizerFailure()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FinalizerFailure_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1169304, XrefRangeEnd = 1169306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DisposeInternal_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DisposeInternal_Injected_Private_Static_Void_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1169306, XrefRangeEnd = 1169308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_targetCamera_Injected(System.IntPtr _unity_self, System.IntPtr value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_targetCamera_Injected_Private_Static_Void_IntPtr_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1169308, XrefRangeEnd = 1169310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetBoundingSpheres_Injected(System.IntPtr _unity_self, Il2CppStructArray<BoundingSphere> array)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)array);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetBoundingSpheres_Injected_Private_Static_Void_IntPtr_Il2CppStructArray_1_BoundingSphere_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1169310, XrefRangeEnd = 1169312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetBoundingSphereCount_Injected(System.IntPtr _unity_self, int count)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetBoundingSphereCount_Injected_Private_Static_Void_IntPtr_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1169312, XrefRangeEnd = 1169314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int QueryIndices_Injected(System.IntPtr _unity_self, bool visible, int distanceIndex, CullingQueryOptions options, ref ManagedSpanWrapper result, int firstIndex)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&_unity_self);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &visible;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &distanceIndex;
		*(CullingQueryOptions**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &options;
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref result);
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &firstIndex;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_QueryIndices_Injected_Private_Static_Int32_IntPtr_Boolean_Int32_CullingQueryOptions_byref_ManagedSpanWrapper_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1169314, XrefRangeEnd = 1169316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetBoundingDistances_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper distances)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref distances);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetBoundingDistances_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1169316, XrefRangeEnd = 1169318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetDistanceReferencePoint_InternalVector3_Injected(System.IntPtr _unity_self, [In] ref Vector3 point)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref point);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetDistanceReferencePoint_InternalVector3_Injected_Private_Static_Void_IntPtr_byref_Vector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1169318, XrefRangeEnd = 1169320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void FinalizerFailure_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FinalizerFailure_Injected_Private_Static_Void_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public CullingGroup(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public void EraseSwapBack(int index)
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		EraseSwapBack_Injected(intPtr, index);
	}

	public static void EraseSwapBack<T>(int index, Il2CppArrayBase<T> myArray, ref int size)
	{
		size--;
		myArray[index] = myArray[size];
	}

	public int QueryIndices(int distanceIndex, Il2CppStructArray<int> result, int firstIndex)
	{
		return QueryIndices(visible: false, distanceIndex, CullingQueryOptions.IgnoreVisibility, result, firstIndex);
	}

	public int QueryIndices(bool visible, int distanceIndex, Il2CppStructArray<int> result, int firstIndex)
	{
		return QueryIndices(visible, distanceIndex, CullingQueryOptions.Normal, result, firstIndex);
	}

	public bool IsVisible(int index)
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return IsVisible_Injected(intPtr, index);
	}

	public int GetDistance(int index)
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return GetDistance_Injected(intPtr, index);
	}

	public void SetDistanceReferencePoint_InternalTransform(Transform transform)
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		SetDistanceReferencePoint_InternalTransform_Injected(intPtr, Object.MarshalledUnityObject.Marshal(transform));
	}

	public void SetDistanceReferencePoint(Transform transform)
	{
		SetDistanceReferencePoint_InternalTransform(transform);
	}

	public static bool get_enabled_Injected(System.IntPtr _unity_self)
	{
		return get_enabled_InjectedDelegateField(_unity_self);
	}

	public static void set_enabled_Injected(System.IntPtr _unity_self, bool value)
	{
		set_enabled_InjectedDelegateField(_unity_self, value);
	}

	public static System.IntPtr get_targetCamera_Injected(System.IntPtr _unity_self)
	{
		return get_targetCamera_InjectedDelegateField(_unity_self);
	}

	public static void EraseSwapBack_Injected(System.IntPtr _unity_self, int index)
	{
		EraseSwapBack_InjectedDelegateField(_unity_self, index);
	}

	public static bool IsVisible_Injected(System.IntPtr _unity_self, int index)
	{
		return IsVisible_InjectedDelegateField(_unity_self, index);
	}

	public static int GetDistance_Injected(System.IntPtr _unity_self, int index)
	{
		return GetDistance_InjectedDelegateField(_unity_self, index);
	}

	public static void SetDistanceReferencePoint_InternalTransform_Injected(System.IntPtr _unity_self, System.IntPtr transform)
	{
		SetDistanceReferencePoint_InternalTransform_InjectedDelegateField(_unity_self, transform);
	}
}
