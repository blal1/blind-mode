using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Bindings;

namespace UnityEngine.VFX;

public sealed class VFXEventAttribute : Il2CppSystem.Object
{
	public static class BindingsMarshaller : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeMethodInfoPtr_ConvertToNative_Public_Static_IntPtr_VFXEventAttribute_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_ConvertToManaged_Public_Static_VFXEventAttribute_IntPtr_0;

		static BindingsMarshaller()
		{
			Il2CppClassPointerStore<BindingsMarshaller>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VFXEventAttribute>.NativeClassPtr, "BindingsMarshaller");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BindingsMarshaller>.NativeClassPtr);
			NativeMethodInfoPtr_ConvertToNative_Public_Static_IntPtr_VFXEventAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingsMarshaller>.NativeClassPtr, 100663339);
			NativeMethodInfoPtr_ConvertToManaged_Public_Static_VFXEventAttribute_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingsMarshaller>.NativeClassPtr, 100663340);
		}

		[CallerCount(0)]
		public unsafe static System.IntPtr ConvertToNative(VFXEventAttribute eventAttibute)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)eventAttibute);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConvertToNative_Public_Static_IntPtr_VFXEventAttribute_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1408821, XrefRangeEnd = 1408825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static VFXEventAttribute ConvertToManaged(System.IntPtr ptr)
		{
			System.IntPtr* ptr2 = stackalloc System.IntPtr[1];
			*ptr2 = (nint)(&ptr);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConvertToManaged_Public_Static_VFXEventAttribute_IntPtr_0, (System.IntPtr)0, (void**)ptr2, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<VFXEventAttribute>(intPtr2) : null;
		}

		public BindingsMarshaller(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private delegate void Internal_InitFromEventAttribute_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr vfxEventAttribute);

	private delegate bool HasMatrix4x4_InjectedDelegate(System.IntPtr _unity_self, int nameID);

	private delegate void SetMatrix4x4_InjectedDelegate(System.IntPtr _unity_self, int nameID, [In] System.IntPtr v);

	private delegate bool GetBool_InjectedDelegate(System.IntPtr _unity_self, int nameID);

	private delegate int GetInt_InjectedDelegate(System.IntPtr _unity_self, int nameID);

	private delegate uint GetUint_InjectedDelegate(System.IntPtr _unity_self, int nameID);

	private delegate float GetFloat_InjectedDelegate(System.IntPtr _unity_self, int nameID);

	private delegate void GetVector2_InjectedDelegate(System.IntPtr _unity_self, int nameID, [Out] System.IntPtr ret);

	private delegate void GetVector3_InjectedDelegate(System.IntPtr _unity_self, int nameID, [Out] System.IntPtr ret);

	private delegate void GetVector4_InjectedDelegate(System.IntPtr _unity_self, int nameID, [Out] System.IntPtr ret);

	private delegate void GetMatrix4x4_InjectedDelegate(System.IntPtr _unity_self, int nameID, [Out] System.IntPtr ret);

	private delegate void CopyValuesFrom_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr eventAttibute);

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Ptr;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Owner;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_VfxAsset;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Private_Void_IntPtr_Boolean_VisualEffectAsset_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateEventAttributeWrapper_Internal_Static_VFXEventAttribute_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetWrapValue_Internal_Void_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_Create_Internal_Static_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_InstanciateVFXEventAttribute_Internal_Static_VFXEventAttribute_VisualEffectAsset_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_InitFromAsset_Internal_Void_VisualEffectAsset_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_vfxAsset_Internal_get_VisualEffectAsset_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Release_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_Destroy_Internal_Static_Void_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasBool_Public_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasInt_Public_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasUint_Public_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasFloat_Public_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasVector2_Public_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasVector3_Public_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasVector4_Public_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetBool_Public_Void_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetInt_Public_Void_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetUint_Public_Void_Int32_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetFloat_Public_Void_Int32_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetVector2_Public_Void_Int32_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetVector3_Public_Void_Int32_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetVector4_Public_Void_Int32_Vector4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_InitFromAsset_Injected_Private_Static_Void_IntPtr_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasBool_Injected_Private_Static_Boolean_IntPtr_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasInt_Injected_Private_Static_Boolean_IntPtr_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasUint_Injected_Private_Static_Boolean_IntPtr_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasFloat_Injected_Private_Static_Boolean_IntPtr_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasVector2_Injected_Private_Static_Boolean_IntPtr_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasVector3_Injected_Private_Static_Boolean_IntPtr_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasVector4_Injected_Private_Static_Boolean_IntPtr_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetBool_Injected_Private_Static_Void_IntPtr_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetInt_Injected_Private_Static_Void_IntPtr_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetUint_Injected_Private_Static_Void_IntPtr_Int32_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetFloat_Injected_Private_Static_Void_IntPtr_Int32_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetVector2_Injected_Private_Static_Void_IntPtr_Int32_byref_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetVector3_Injected_Private_Static_Void_IntPtr_Int32_byref_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetVector4_Injected_Private_Static_Void_IntPtr_Int32_byref_Vector4_0;

	private static readonly Internal_InitFromEventAttribute_InjectedDelegate Internal_InitFromEventAttribute_InjectedDelegateField;

	private static readonly HasMatrix4x4_InjectedDelegate HasMatrix4x4_InjectedDelegateField;

	private static readonly SetMatrix4x4_InjectedDelegate SetMatrix4x4_InjectedDelegateField;

	private static readonly GetBool_InjectedDelegate GetBool_InjectedDelegateField;

	private static readonly GetInt_InjectedDelegate GetInt_InjectedDelegateField;

	private static readonly GetUint_InjectedDelegate GetUint_InjectedDelegateField;

	private static readonly GetFloat_InjectedDelegate GetFloat_InjectedDelegateField;

	private static readonly GetVector2_InjectedDelegate GetVector2_InjectedDelegateField;

	private static readonly GetVector3_InjectedDelegate GetVector3_InjectedDelegateField;

	private static readonly GetVector4_InjectedDelegate GetVector4_InjectedDelegateField;

	private static readonly GetMatrix4x4_InjectedDelegate GetMatrix4x4_InjectedDelegateField;

	private static readonly CopyValuesFrom_InjectedDelegate CopyValuesFrom_InjectedDelegateField;

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

	public unsafe bool m_Owner
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Owner);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Owner)) = value;
		}
	}

	public unsafe VisualEffectAsset m_VfxAsset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_VfxAsset);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<VisualEffectAsset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_VfxAsset)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe VisualEffectAsset vfxAsset
	{
		[CallerCount(72)]
		[CachedScanResults(RefRangeStart = 1153270, RefRangeEnd = 1153342, XrefRangeStart = 1153270, XrefRangeEnd = 1153342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_vfxAsset_Internal_get_VisualEffectAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<VisualEffectAsset>(intPtr2) : null;
		}
	}

	static VFXEventAttribute()
	{
		Il2CppClassPointerStore<VFXEventAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.VFXModule.dll", "UnityEngine.VFX", "VFXEventAttribute");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VFXEventAttribute>.NativeClassPtr);
		NativeFieldInfoPtr_m_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VFXEventAttribute>.NativeClassPtr, "m_Ptr");
		NativeFieldInfoPtr_m_Owner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VFXEventAttribute>.NativeClassPtr, "m_Owner");
		NativeFieldInfoPtr_m_VfxAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VFXEventAttribute>.NativeClassPtr, "m_VfxAsset");
		NativeMethodInfoPtr__ctor_Private_Void_IntPtr_Boolean_VisualEffectAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXEventAttribute>.NativeClassPtr, 100663297);
		NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXEventAttribute>.NativeClassPtr, 100663299);
		NativeMethodInfoPtr_CreateEventAttributeWrapper_Internal_Static_VFXEventAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXEventAttribute>.NativeClassPtr, 100663300);
		NativeMethodInfoPtr_SetWrapValue_Internal_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXEventAttribute>.NativeClassPtr, 100663301);
		NativeMethodInfoPtr_Internal_Create_Internal_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXEventAttribute>.NativeClassPtr, 100663302);
		NativeMethodInfoPtr_Internal_InstanciateVFXEventAttribute_Internal_Static_VFXEventAttribute_VisualEffectAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXEventAttribute>.NativeClassPtr, 100663303);
		NativeMethodInfoPtr_Internal_InitFromAsset_Internal_Void_VisualEffectAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXEventAttribute>.NativeClassPtr, 100663304);
		NativeMethodInfoPtr_get_vfxAsset_Internal_get_VisualEffectAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXEventAttribute>.NativeClassPtr, 100663305);
		NativeMethodInfoPtr_Release_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXEventAttribute>.NativeClassPtr, 100663306);
		NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXEventAttribute>.NativeClassPtr, 100663307);
		NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXEventAttribute>.NativeClassPtr, 100663308);
		NativeMethodInfoPtr_Internal_Destroy_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXEventAttribute>.NativeClassPtr, 100663309);
		NativeMethodInfoPtr_HasBool_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXEventAttribute>.NativeClassPtr, 100663310);
		NativeMethodInfoPtr_HasInt_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXEventAttribute>.NativeClassPtr, 100663311);
		NativeMethodInfoPtr_HasUint_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXEventAttribute>.NativeClassPtr, 100663312);
		NativeMethodInfoPtr_HasFloat_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXEventAttribute>.NativeClassPtr, 100663313);
		NativeMethodInfoPtr_HasVector2_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXEventAttribute>.NativeClassPtr, 100663314);
		NativeMethodInfoPtr_HasVector3_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXEventAttribute>.NativeClassPtr, 100663315);
		NativeMethodInfoPtr_HasVector4_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXEventAttribute>.NativeClassPtr, 100663316);
		NativeMethodInfoPtr_SetBool_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXEventAttribute>.NativeClassPtr, 100663317);
		NativeMethodInfoPtr_SetInt_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXEventAttribute>.NativeClassPtr, 100663318);
		NativeMethodInfoPtr_SetUint_Public_Void_Int32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXEventAttribute>.NativeClassPtr, 100663319);
		NativeMethodInfoPtr_SetFloat_Public_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXEventAttribute>.NativeClassPtr, 100663320);
		NativeMethodInfoPtr_SetVector2_Public_Void_Int32_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXEventAttribute>.NativeClassPtr, 100663321);
		NativeMethodInfoPtr_SetVector3_Public_Void_Int32_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXEventAttribute>.NativeClassPtr, 100663322);
		NativeMethodInfoPtr_SetVector4_Public_Void_Int32_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXEventAttribute>.NativeClassPtr, 100663323);
		NativeMethodInfoPtr_Internal_InitFromAsset_Injected_Private_Static_Void_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXEventAttribute>.NativeClassPtr, 100663324);
		NativeMethodInfoPtr_HasBool_Injected_Private_Static_Boolean_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXEventAttribute>.NativeClassPtr, 100663325);
		NativeMethodInfoPtr_HasInt_Injected_Private_Static_Boolean_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXEventAttribute>.NativeClassPtr, 100663326);
		NativeMethodInfoPtr_HasUint_Injected_Private_Static_Boolean_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXEventAttribute>.NativeClassPtr, 100663327);
		NativeMethodInfoPtr_HasFloat_Injected_Private_Static_Boolean_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXEventAttribute>.NativeClassPtr, 100663328);
		NativeMethodInfoPtr_HasVector2_Injected_Private_Static_Boolean_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXEventAttribute>.NativeClassPtr, 100663329);
		NativeMethodInfoPtr_HasVector3_Injected_Private_Static_Boolean_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXEventAttribute>.NativeClassPtr, 100663330);
		NativeMethodInfoPtr_HasVector4_Injected_Private_Static_Boolean_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXEventAttribute>.NativeClassPtr, 100663331);
		NativeMethodInfoPtr_SetBool_Injected_Private_Static_Void_IntPtr_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXEventAttribute>.NativeClassPtr, 100663332);
		NativeMethodInfoPtr_SetInt_Injected_Private_Static_Void_IntPtr_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXEventAttribute>.NativeClassPtr, 100663333);
		NativeMethodInfoPtr_SetUint_Injected_Private_Static_Void_IntPtr_Int32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXEventAttribute>.NativeClassPtr, 100663334);
		NativeMethodInfoPtr_SetFloat_Injected_Private_Static_Void_IntPtr_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXEventAttribute>.NativeClassPtr, 100663335);
		NativeMethodInfoPtr_SetVector2_Injected_Private_Static_Void_IntPtr_Int32_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXEventAttribute>.NativeClassPtr, 100663336);
		NativeMethodInfoPtr_SetVector3_Injected_Private_Static_Void_IntPtr_Int32_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXEventAttribute>.NativeClassPtr, 100663337);
		NativeMethodInfoPtr_SetVector4_Injected_Private_Static_Void_IntPtr_Int32_byref_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXEventAttribute>.NativeClassPtr, 100663338);
		Internal_InitFromEventAttribute_InjectedDelegateField = IL2CPP.ResolveICall<Internal_InitFromEventAttribute_InjectedDelegate>("UnityEngine.VFX.VFXEventAttribute::Internal_InitFromEventAttribute_Injected");
		HasMatrix4x4_InjectedDelegateField = IL2CPP.ResolveICall<HasMatrix4x4_InjectedDelegate>("UnityEngine.VFX.VFXEventAttribute::HasMatrix4x4_Injected");
		SetMatrix4x4_InjectedDelegateField = IL2CPP.ResolveICall<SetMatrix4x4_InjectedDelegate>("UnityEngine.VFX.VFXEventAttribute::SetMatrix4x4_Injected");
		GetBool_InjectedDelegateField = IL2CPP.ResolveICall<GetBool_InjectedDelegate>("UnityEngine.VFX.VFXEventAttribute::GetBool_Injected");
		GetInt_InjectedDelegateField = IL2CPP.ResolveICall<GetInt_InjectedDelegate>("UnityEngine.VFX.VFXEventAttribute::GetInt_Injected");
		GetUint_InjectedDelegateField = IL2CPP.ResolveICall<GetUint_InjectedDelegate>("UnityEngine.VFX.VFXEventAttribute::GetUint_Injected");
		GetFloat_InjectedDelegateField = IL2CPP.ResolveICall<GetFloat_InjectedDelegate>("UnityEngine.VFX.VFXEventAttribute::GetFloat_Injected");
		GetVector2_InjectedDelegateField = IL2CPP.ResolveICall<GetVector2_InjectedDelegate>("UnityEngine.VFX.VFXEventAttribute::GetVector2_Injected");
		GetVector3_InjectedDelegateField = IL2CPP.ResolveICall<GetVector3_InjectedDelegate>("UnityEngine.VFX.VFXEventAttribute::GetVector3_Injected");
		GetVector4_InjectedDelegateField = IL2CPP.ResolveICall<GetVector4_InjectedDelegate>("UnityEngine.VFX.VFXEventAttribute::GetVector4_Injected");
		GetMatrix4x4_InjectedDelegateField = IL2CPP.ResolveICall<GetMatrix4x4_InjectedDelegate>("UnityEngine.VFX.VFXEventAttribute::GetMatrix4x4_Injected");
		CopyValuesFrom_InjectedDelegateField = IL2CPP.ResolveICall<CopyValuesFrom_InjectedDelegate>("UnityEngine.VFX.VFXEventAttribute::CopyValuesFrom_Injected");
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1408825, XrefRangeEnd = 1408827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe VFXEventAttribute(System.IntPtr ptr, bool owner, VisualEffectAsset vfxAsset)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VFXEventAttribute>.NativeClassPtr))
	{
		System.IntPtr* ptr2 = stackalloc System.IntPtr[3];
		*ptr2 = (nint)(&ptr);
		*(bool**)((byte*)ptr2 + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &owner;
		*(System.IntPtr*)((byte*)ptr2 + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)vfxAsset);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Private_Void_IntPtr_Boolean_VisualEffectAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr2, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1408827, XrefRangeEnd = 1408829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe VFXEventAttribute()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VFXEventAttribute>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1408829, XrefRangeEnd = 1408834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static VFXEventAttribute CreateEventAttributeWrapper()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateEventAttributeWrapper_Internal_Static_VFXEventAttribute_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<VFXEventAttribute>(intPtr2) : null;
	}

	[CallerCount(0)]
	public unsafe void SetWrapValue(System.IntPtr ptrToEventAttribute)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&ptrToEventAttribute);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetWrapValue_Internal_Void_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1408834, XrefRangeEnd = 1408836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr Internal_Create()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_Create_Internal_Static_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1408836, XrefRangeEnd = 1408849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static VFXEventAttribute Internal_InstanciateVFXEventAttribute(VisualEffectAsset vfxAsset)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)vfxAsset);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_InstanciateVFXEventAttribute_Internal_Static_VFXEventAttribute_VisualEffectAsset_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<VFXEventAttribute>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1408849, XrefRangeEnd = 1408856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Internal_InitFromAsset(VisualEffectAsset vfxAsset)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)vfxAsset);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_InitFromAsset_Internal_Void_VisualEffectAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1408856, XrefRangeEnd = 1408859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Release()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Release_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1408859, XrefRangeEnd = 1408865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void Finalize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1408865, XrefRangeEnd = 1408872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Dispose()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1408872, XrefRangeEnd = 1408874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Internal_Destroy(System.IntPtr ptr)
	{
		System.IntPtr* ptr2 = stackalloc System.IntPtr[1];
		*ptr2 = (nint)(&ptr);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_Destroy_Internal_Static_Void_IntPtr_0, (System.IntPtr)0, (void**)ptr2, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1408878, RefRangeEnd = 1408879, XrefRangeStart = 1408874, XrefRangeEnd = 1408878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HasBool(int nameID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&nameID);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasBool_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1408883, RefRangeEnd = 1408884, XrefRangeStart = 1408879, XrefRangeEnd = 1408883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HasInt(int nameID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&nameID);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasInt_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1408888, RefRangeEnd = 1408889, XrefRangeStart = 1408884, XrefRangeEnd = 1408888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HasUint(int nameID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&nameID);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasUint_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1408893, RefRangeEnd = 1408894, XrefRangeStart = 1408889, XrefRangeEnd = 1408893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HasFloat(int nameID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&nameID);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasFloat_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1408898, RefRangeEnd = 1408899, XrefRangeStart = 1408894, XrefRangeEnd = 1408898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HasVector2(int nameID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&nameID);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasVector2_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1408903, RefRangeEnd = 1408904, XrefRangeStart = 1408899, XrefRangeEnd = 1408903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HasVector3(int nameID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&nameID);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasVector3_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1408908, RefRangeEnd = 1408909, XrefRangeStart = 1408904, XrefRangeEnd = 1408908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HasVector4(int nameID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&nameID);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasVector4_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1408913, RefRangeEnd = 1408914, XrefRangeStart = 1408909, XrefRangeEnd = 1408913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetBool(int nameID, bool b)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&nameID);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetBool_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1408918, RefRangeEnd = 1408919, XrefRangeStart = 1408914, XrefRangeEnd = 1408918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetInt(int nameID, int i)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&nameID);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &i;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetInt_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1408923, RefRangeEnd = 1408925, XrefRangeStart = 1408919, XrefRangeEnd = 1408923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetUint(int nameID, uint i)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&nameID);
		*(uint**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &i;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetUint_Public_Void_Int32_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1408929, RefRangeEnd = 1408931, XrefRangeStart = 1408925, XrefRangeEnd = 1408929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetFloat(int nameID, float f)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&nameID);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &f;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetFloat_Public_Void_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1408934, RefRangeEnd = 1408935, XrefRangeStart = 1408931, XrefRangeEnd = 1408934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetVector2(int nameID, Vector2 v)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&nameID);
		*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &v;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetVector2_Public_Void_Int32_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 1408938, RefRangeEnd = 1408945, XrefRangeStart = 1408935, XrefRangeEnd = 1408938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetVector3(int nameID, Vector3 v)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&nameID);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &v;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetVector3_Public_Void_Int32_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1408948, RefRangeEnd = 1408949, XrefRangeStart = 1408945, XrefRangeEnd = 1408948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetVector4(int nameID, Vector4 v)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&nameID);
		*(Vector4**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &v;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetVector4_Public_Void_Int32_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1408949, XrefRangeEnd = 1408951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Internal_InitFromAsset_Injected(System.IntPtr _unity_self, System.IntPtr vfxAsset)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &vfxAsset;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_InitFromAsset_Injected_Private_Static_Void_IntPtr_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1408951, XrefRangeEnd = 1408953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool HasBool_Injected(System.IntPtr _unity_self, int nameID)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &nameID;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasBool_Injected_Private_Static_Boolean_IntPtr_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1408953, XrefRangeEnd = 1408955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool HasInt_Injected(System.IntPtr _unity_self, int nameID)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &nameID;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasInt_Injected_Private_Static_Boolean_IntPtr_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1408955, XrefRangeEnd = 1408957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool HasUint_Injected(System.IntPtr _unity_self, int nameID)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &nameID;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasUint_Injected_Private_Static_Boolean_IntPtr_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1408957, XrefRangeEnd = 1408959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool HasFloat_Injected(System.IntPtr _unity_self, int nameID)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &nameID;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasFloat_Injected_Private_Static_Boolean_IntPtr_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1408959, XrefRangeEnd = 1408961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool HasVector2_Injected(System.IntPtr _unity_self, int nameID)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &nameID;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasVector2_Injected_Private_Static_Boolean_IntPtr_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1408961, XrefRangeEnd = 1408963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool HasVector3_Injected(System.IntPtr _unity_self, int nameID)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &nameID;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasVector3_Injected_Private_Static_Boolean_IntPtr_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1408963, XrefRangeEnd = 1408965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool HasVector4_Injected(System.IntPtr _unity_self, int nameID)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &nameID;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasVector4_Injected_Private_Static_Boolean_IntPtr_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1408965, XrefRangeEnd = 1408967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetBool_Injected(System.IntPtr _unity_self, int nameID, bool b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&_unity_self);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &nameID;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetBool_Injected_Private_Static_Void_IntPtr_Int32_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1408967, XrefRangeEnd = 1408969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetInt_Injected(System.IntPtr _unity_self, int nameID, int i)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&_unity_self);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &nameID;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &i;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetInt_Injected_Private_Static_Void_IntPtr_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1408969, XrefRangeEnd = 1408971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetUint_Injected(System.IntPtr _unity_self, int nameID, uint i)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&_unity_self);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &nameID;
		*(uint**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &i;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetUint_Injected_Private_Static_Void_IntPtr_Int32_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1408971, XrefRangeEnd = 1408973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetFloat_Injected(System.IntPtr _unity_self, int nameID, float f)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&_unity_self);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &nameID;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &f;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetFloat_Injected_Private_Static_Void_IntPtr_Int32_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1408973, XrefRangeEnd = 1408975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetVector2_Injected(System.IntPtr _unity_self, int nameID, [In] ref Vector2 v)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&_unity_self);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &nameID;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref v);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetVector2_Injected_Private_Static_Void_IntPtr_Int32_byref_Vector2_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1408975, XrefRangeEnd = 1408977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetVector3_Injected(System.IntPtr _unity_self, int nameID, [In] ref Vector3 v)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&_unity_self);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &nameID;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref v);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetVector3_Injected_Private_Static_Void_IntPtr_Int32_byref_Vector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1408977, XrefRangeEnd = 1408979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetVector4_Injected(System.IntPtr _unity_self, int nameID, [In] ref Vector4 v)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&_unity_self);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &nameID;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref v);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetVector4_Injected_Private_Static_Void_IntPtr_Int32_byref_Vector4_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public VFXEventAttribute(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public void Internal_InitFromEventAttribute(VFXEventAttribute vfxEventAttribute)
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		Internal_InitFromEventAttribute_Injected(intPtr, (vfxEventAttribute == null) ? ((System.IntPtr)0) : BindingsMarshaller.ConvertToNative(vfxEventAttribute));
	}

	public bool HasMatrix4x4(int nameID)
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return HasMatrix4x4_Injected(intPtr, nameID);
	}

	public void SetMatrix4x4(int nameID, Matrix4x4 v)
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		SetMatrix4x4_Injected(intPtr, nameID, ref v);
	}

	public bool GetBool(int nameID)
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return GetBool_Injected(intPtr, nameID);
	}

	public int GetInt(int nameID)
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return GetInt_Injected(intPtr, nameID);
	}

	public uint GetUint(int nameID)
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return GetUint_Injected(intPtr, nameID);
	}

	public float GetFloat(int nameID)
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return GetFloat_Injected(intPtr, nameID);
	}

	public Vector2 GetVector2(int nameID)
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		GetVector2_Injected(intPtr, nameID, out var ret);
		return ret;
	}

	public Vector3 GetVector3(int nameID)
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		GetVector3_Injected(intPtr, nameID, out var ret);
		return ret;
	}

	public Vector4 GetVector4(int nameID)
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		GetVector4_Injected(intPtr, nameID, out var ret);
		return ret;
	}

	public Matrix4x4 GetMatrix4x4(int nameID)
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		GetMatrix4x4_Injected(intPtr, nameID, out var ret);
		return ret;
	}

	public bool HasBool(string name)
	{
		return HasBool(Shader.PropertyToID(name));
	}

	public bool HasInt(string name)
	{
		return HasInt(Shader.PropertyToID(name));
	}

	public bool HasUint(string name)
	{
		return HasUint(Shader.PropertyToID(name));
	}

	public bool HasFloat(string name)
	{
		return HasFloat(Shader.PropertyToID(name));
	}

	public bool HasVector2(string name)
	{
		return HasVector2(Shader.PropertyToID(name));
	}

	public bool HasVector3(string name)
	{
		return HasVector3(Shader.PropertyToID(name));
	}

	public bool HasVector4(string name)
	{
		return HasVector4(Shader.PropertyToID(name));
	}

	public bool HasMatrix4x4(string name)
	{
		return HasMatrix4x4(Shader.PropertyToID(name));
	}

	public void SetBool(string name, bool b)
	{
		SetBool(Shader.PropertyToID(name), b);
	}

	public void SetInt(string name, int i)
	{
		SetInt(Shader.PropertyToID(name), i);
	}

	public void SetUint(string name, uint i)
	{
		SetUint(Shader.PropertyToID(name), i);
	}

	public void SetFloat(string name, float f)
	{
		SetFloat(Shader.PropertyToID(name), f);
	}

	public void SetVector2(string name, Vector2 v)
	{
		SetVector2(Shader.PropertyToID(name), v);
	}

	public void SetVector3(string name, Vector3 v)
	{
		SetVector3(Shader.PropertyToID(name), v);
	}

	public void SetVector4(string name, Vector4 v)
	{
		SetVector4(Shader.PropertyToID(name), v);
	}

	public void SetMatrix4x4(string name, Matrix4x4 v)
	{
		SetMatrix4x4(Shader.PropertyToID(name), v);
	}

	public bool GetBool(string name)
	{
		return GetBool(Shader.PropertyToID(name));
	}

	public int GetInt(string name)
	{
		return GetInt(Shader.PropertyToID(name));
	}

	public uint GetUint(string name)
	{
		return GetUint(Shader.PropertyToID(name));
	}

	public float GetFloat(string name)
	{
		return GetFloat(Shader.PropertyToID(name));
	}

	public Vector2 GetVector2(string name)
	{
		return GetVector2(Shader.PropertyToID(name));
	}

	public Vector3 GetVector3(string name)
	{
		return GetVector3(Shader.PropertyToID(name));
	}

	public Vector4 GetVector4(string name)
	{
		return GetVector4(Shader.PropertyToID(name));
	}

	public Matrix4x4 GetMatrix4x4(string name)
	{
		return GetMatrix4x4(Shader.PropertyToID(name));
	}

	public void CopyValuesFrom(VFXEventAttribute eventAttibute)
	{
		if (eventAttibute == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(eventAttibute, "eventAttibute");
		}
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		System.IntPtr intPtr2 = BindingsMarshaller.ConvertToNative(eventAttibute);
		if (intPtr2 == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(eventAttibute, "eventAttibute");
		}
		CopyValuesFrom_Injected(intPtr, intPtr2);
	}

	public static void Internal_InitFromEventAttribute_Injected(System.IntPtr _unity_self, System.IntPtr vfxEventAttribute)
	{
		Internal_InitFromEventAttribute_InjectedDelegateField(_unity_self, vfxEventAttribute);
	}

	public static bool HasMatrix4x4_Injected(System.IntPtr _unity_self, int nameID)
	{
		return HasMatrix4x4_InjectedDelegateField(_unity_self, nameID);
	}

	public unsafe static void SetMatrix4x4_Injected(System.IntPtr _unity_self, int nameID, [In] ref Matrix4x4 v)
	{
		SetMatrix4x4_InjectedDelegateField(_unity_self, nameID, (nint)Unsafe.AsPointer(ref v));
	}

	public static bool GetBool_Injected(System.IntPtr _unity_self, int nameID)
	{
		return GetBool_InjectedDelegateField(_unity_self, nameID);
	}

	public static int GetInt_Injected(System.IntPtr _unity_self, int nameID)
	{
		return GetInt_InjectedDelegateField(_unity_self, nameID);
	}

	public static uint GetUint_Injected(System.IntPtr _unity_self, int nameID)
	{
		return GetUint_InjectedDelegateField(_unity_self, nameID);
	}

	public static float GetFloat_Injected(System.IntPtr _unity_self, int nameID)
	{
		return GetFloat_InjectedDelegateField(_unity_self, nameID);
	}

	public unsafe static void GetVector2_Injected(System.IntPtr _unity_self, int nameID, out Vector2 ret)
	{
		GetVector2_InjectedDelegateField(_unity_self, nameID, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void GetVector3_Injected(System.IntPtr _unity_self, int nameID, out Vector3 ret)
	{
		GetVector3_InjectedDelegateField(_unity_self, nameID, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void GetVector4_Injected(System.IntPtr _unity_self, int nameID, out Vector4 ret)
	{
		GetVector4_InjectedDelegateField(_unity_self, nameID, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void GetMatrix4x4_Injected(System.IntPtr _unity_self, int nameID, out Matrix4x4 ret)
	{
		GetMatrix4x4_InjectedDelegateField(_unity_self, nameID, (nint)Unsafe.AsPointer(ref ret));
	}

	public static void CopyValuesFrom_Injected(System.IntPtr _unity_self, System.IntPtr eventAttibute)
	{
		CopyValuesFrom_InjectedDelegateField(_unity_self, eventAttibute);
	}
}
