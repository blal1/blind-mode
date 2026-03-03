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

public class AnimationCurve : Il2CppSystem.Object
{
	public static class BindingsMarshaller : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeMethodInfoPtr_ConvertToNative_Public_Static_IntPtr_AnimationCurve_0;

		static BindingsMarshaller()
		{
			Il2CppClassPointerStore<BindingsMarshaller>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, "BindingsMarshaller");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BindingsMarshaller>.NativeClassPtr);
			NativeMethodInfoPtr_ConvertToNative_Public_Static_IntPtr_AnimationCurve_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingsMarshaller>.NativeClassPtr, 100663811);
		}

		[CallerCount(0)]
		public unsafe static System.IntPtr ConvertToNative(AnimationCurve animationCurve)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)animationCurve);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConvertToNative_Public_Static_IntPtr_AnimationCurve_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		public BindingsMarshaller(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private delegate WrapMode get_preWrapMode_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_preWrapMode_InjectedDelegate(System.IntPtr _unity_self, WrapMode value);

	private delegate WrapMode get_postWrapMode_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_postWrapMode_InjectedDelegate(System.IntPtr _unity_self, WrapMode value);

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Ptr;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_RequiresNativeCleanup;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_Destroy_Private_Static_Void_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_Create_Private_Static_IntPtr_Il2CppStructArray_1_Keyframe_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_Equals_Private_Boolean_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_CopyFrom_Private_Void_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Evaluate_Public_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_keys_Public_get_Il2CppStructArray_1_Keyframe_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_keys_Public_set_Void_Il2CppStructArray_1_Keyframe_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddKey_Public_Int32_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddKey_Public_Int32_Keyframe_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddKey_Internal_Private_Int32_Keyframe_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MoveKey_Public_Int32_Int32_Keyframe_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearKeys_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveKey_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Item_Public_get_Keyframe_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_length_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetKeys_Private_Void_Il2CppStructArray_1_Keyframe_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetKey_Private_Keyframe_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetKeys_Private_Il2CppStructArray_1_Keyframe_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SmoothTangents_Public_Void_Int32_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Constant_Public_Static_AnimationCurve_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Linear_Public_Static_AnimationCurve_Single_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EaseInOut_Public_Static_AnimationCurve_Single_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Keyframe_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_IntPtr_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AnimationCurve_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CopyFrom_Public_Void_AnimationCurve_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_Create_Injected_Private_Static_IntPtr_byref_ManagedSpanWrapper_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_Equals_Injected_Private_Static_Boolean_IntPtr_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_CopyFrom_Injected_Private_Static_Void_IntPtr_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Evaluate_Injected_Private_Static_Single_IntPtr_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddKey_Injected_Private_Static_Int32_IntPtr_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddKey_Internal_Injected_Private_Static_Int32_IntPtr_byref_Keyframe_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MoveKey_Injected_Private_Static_Int32_IntPtr_Int32_byref_Keyframe_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearKeys_Injected_Private_Static_Void_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveKey_Injected_Private_Static_Void_IntPtr_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_length_Injected_Private_Static_Int32_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetKeys_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetKey_Injected_Private_Static_Void_IntPtr_Int32_byref_Keyframe_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetKeys_Injected_Private_Static_Void_IntPtr_byref_BlittableArrayWrapper_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Injected_Private_Static_Int32_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SmoothTangents_Injected_Private_Static_Void_IntPtr_Int32_Single_0;

	private static readonly get_preWrapMode_InjectedDelegate get_preWrapMode_InjectedDelegateField;

	private static readonly set_preWrapMode_InjectedDelegate set_preWrapMode_InjectedDelegateField;

	private static readonly get_postWrapMode_InjectedDelegate get_postWrapMode_InjectedDelegateField;

	private static readonly set_postWrapMode_InjectedDelegate set_postWrapMode_InjectedDelegateField;

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

	public unsafe bool m_RequiresNativeCleanup
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RequiresNativeCleanup);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RequiresNativeCleanup)) = value;
		}
	}

	public unsafe Il2CppStructArray<Keyframe> keys
	{
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 1167367, RefRangeEnd = 1167390, XrefRangeStart = 1167366, XrefRangeEnd = 1167367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_keys_Public_get_Il2CppStructArray_1_Keyframe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Keyframe>>(intPtr2) : null;
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1167400, RefRangeEnd = 1167401, XrefRangeStart = 1167390, XrefRangeEnd = 1167400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_keys_Public_set_Void_Il2CppStructArray_1_Keyframe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe Keyframe this[int index]
	{
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1167433, RefRangeEnd = 1167438, XrefRangeStart = 1167430, XrefRangeEnd = 1167433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&index);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Item_Public_get_Keyframe_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Keyframe*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe int length
	{
		[CallerCount(24)]
		[CachedScanResults(RefRangeStart = 1167442, RefRangeEnd = 1167466, XrefRangeStart = 1167438, XrefRangeEnd = 1167442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_length_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public WrapMode preWrapMode
	{
		get
		{
			System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_preWrapMode_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_preWrapMode_Injected(intPtr, value);
		}
	}

	public WrapMode postWrapMode
	{
		get
		{
			System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_postWrapMode_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_postWrapMode_Injected(intPtr, value);
		}
	}

	static AnimationCurve()
	{
		Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "AnimationCurve");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr);
		NativeFieldInfoPtr_m_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, "m_Ptr");
		NativeFieldInfoPtr_m_RequiresNativeCleanup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, "m_RequiresNativeCleanup");
		NativeMethodInfoPtr_Internal_Destroy_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663766);
		NativeMethodInfoPtr_Internal_Create_Private_Static_IntPtr_Il2CppStructArray_1_Keyframe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663767);
		NativeMethodInfoPtr_Internal_Equals_Private_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663768);
		NativeMethodInfoPtr_Internal_CopyFrom_Private_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663769);
		NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663770);
		NativeMethodInfoPtr_Evaluate_Public_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663771);
		NativeMethodInfoPtr_get_keys_Public_get_Il2CppStructArray_1_Keyframe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663772);
		NativeMethodInfoPtr_set_keys_Public_set_Void_Il2CppStructArray_1_Keyframe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663773);
		NativeMethodInfoPtr_AddKey_Public_Int32_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663774);
		NativeMethodInfoPtr_AddKey_Public_Int32_Keyframe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663775);
		NativeMethodInfoPtr_AddKey_Internal_Private_Int32_Keyframe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663776);
		NativeMethodInfoPtr_MoveKey_Public_Int32_Int32_Keyframe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663777);
		NativeMethodInfoPtr_ClearKeys_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663778);
		NativeMethodInfoPtr_RemoveKey_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663779);
		NativeMethodInfoPtr_get_Item_Public_get_Keyframe_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663780);
		NativeMethodInfoPtr_get_length_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663781);
		NativeMethodInfoPtr_SetKeys_Private_Void_Il2CppStructArray_1_Keyframe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663782);
		NativeMethodInfoPtr_GetKey_Private_Keyframe_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663783);
		NativeMethodInfoPtr_GetKeys_Private_Il2CppStructArray_1_Keyframe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663784);
		NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663785);
		NativeMethodInfoPtr_SmoothTangents_Public_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663786);
		NativeMethodInfoPtr_Constant_Public_Static_AnimationCurve_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663787);
		NativeMethodInfoPtr_Linear_Public_Static_AnimationCurve_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663788);
		NativeMethodInfoPtr_EaseInOut_Public_Static_AnimationCurve_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663789);
		NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Keyframe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663790);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663791);
		NativeMethodInfoPtr__ctor_Internal_Void_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663792);
		NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663793);
		NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AnimationCurve_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663794);
		NativeMethodInfoPtr_CopyFrom_Public_Void_AnimationCurve_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663795);
		NativeMethodInfoPtr_Internal_Create_Injected_Private_Static_IntPtr_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663796);
		NativeMethodInfoPtr_Internal_Equals_Injected_Private_Static_Boolean_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663797);
		NativeMethodInfoPtr_Internal_CopyFrom_Injected_Private_Static_Void_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663798);
		NativeMethodInfoPtr_Evaluate_Injected_Private_Static_Single_IntPtr_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663799);
		NativeMethodInfoPtr_AddKey_Injected_Private_Static_Int32_IntPtr_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663800);
		NativeMethodInfoPtr_AddKey_Internal_Injected_Private_Static_Int32_IntPtr_byref_Keyframe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663801);
		NativeMethodInfoPtr_MoveKey_Injected_Private_Static_Int32_IntPtr_Int32_byref_Keyframe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663802);
		NativeMethodInfoPtr_ClearKeys_Injected_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663803);
		NativeMethodInfoPtr_RemoveKey_Injected_Private_Static_Void_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663804);
		NativeMethodInfoPtr_get_length_Injected_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663805);
		NativeMethodInfoPtr_SetKeys_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663806);
		NativeMethodInfoPtr_GetKey_Injected_Private_Static_Void_IntPtr_Int32_byref_Keyframe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663807);
		NativeMethodInfoPtr_GetKeys_Injected_Private_Static_Void_IntPtr_byref_BlittableArrayWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663808);
		NativeMethodInfoPtr_GetHashCode_Injected_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663809);
		NativeMethodInfoPtr_SmoothTangents_Injected_Private_Static_Void_IntPtr_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr, 100663810);
		get_preWrapMode_InjectedDelegateField = IL2CPP.ResolveICall<get_preWrapMode_InjectedDelegate>("UnityEngine.AnimationCurve::get_preWrapMode_Injected");
		set_preWrapMode_InjectedDelegateField = IL2CPP.ResolveICall<set_preWrapMode_InjectedDelegate>("UnityEngine.AnimationCurve::set_preWrapMode_Injected");
		get_postWrapMode_InjectedDelegateField = IL2CPP.ResolveICall<get_postWrapMode_InjectedDelegate>("UnityEngine.AnimationCurve::get_postWrapMode_Injected");
		set_postWrapMode_InjectedDelegateField = IL2CPP.ResolveICall<set_postWrapMode_InjectedDelegate>("UnityEngine.AnimationCurve::set_postWrapMode_Injected");
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1167304, XrefRangeEnd = 1167306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Internal_Destroy(System.IntPtr ptr)
	{
		System.IntPtr* ptr2 = stackalloc System.IntPtr[1];
		*ptr2 = (nint)(&ptr);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_Destroy_Private_Static_Void_IntPtr_0, (System.IntPtr)0, (void**)ptr2, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1167315, RefRangeEnd = 1167320, XrefRangeStart = 1167306, XrefRangeEnd = 1167315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr Internal_Create(Il2CppStructArray<Keyframe> keys)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)keys);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_Create_Private_Static_IntPtr_Il2CppStructArray_1_Keyframe_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1167320, XrefRangeEnd = 1167324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Internal_Equals(System.IntPtr other)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&other);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_Equals_Private_Boolean_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1167324, XrefRangeEnd = 1167328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Internal_CopyFrom(System.IntPtr other)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&other);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_CopyFrom_Private_Void_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1167328, XrefRangeEnd = 1167333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void Finalize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(29)]
	[CachedScanResults(RefRangeStart = 1167337, RefRangeEnd = 1167366, XrefRangeStart = 1167333, XrefRangeEnd = 1167337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float Evaluate(float time)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&time);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Evaluate_Public_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1167405, RefRangeEnd = 1167406, XrefRangeStart = 1167401, XrefRangeEnd = 1167405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int AddKey(float time, float value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&time);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddKey_Public_Int32_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1167409, RefRangeEnd = 1167412, XrefRangeStart = 1167406, XrefRangeEnd = 1167409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int AddKey(Keyframe key)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&key);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddKey_Public_Int32_Keyframe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1167412, XrefRangeEnd = 1167415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int AddKey_Internal(Keyframe key)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&key);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddKey_Internal_Private_Int32_Keyframe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1167418, RefRangeEnd = 1167419, XrefRangeStart = 1167415, XrefRangeEnd = 1167418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int MoveKey(int index, Keyframe key)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&index);
		*(Keyframe**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &key;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MoveKey_Public_Int32_Int32_Keyframe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1167423, RefRangeEnd = 1167425, XrefRangeStart = 1167419, XrefRangeEnd = 1167423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ClearKeys()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearKeys_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1167429, RefRangeEnd = 1167430, XrefRangeStart = 1167425, XrefRangeEnd = 1167429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveKey(int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&index);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveKey_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1167400, RefRangeEnd = 1167401, XrefRangeStart = 1167400, XrefRangeEnd = 1167401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetKeys(Il2CppStructArray<Keyframe> keys)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)keys);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetKeys_Private_Void_Il2CppStructArray_1_Keyframe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1167466, XrefRangeEnd = 1167469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Keyframe GetKey(int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&index);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetKey_Private_Keyframe_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Keyframe*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1167476, RefRangeEnd = 1167477, XrefRangeStart = 1167469, XrefRangeEnd = 1167476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppStructArray<Keyframe> GetKeys()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetKeys_Private_Il2CppStructArray_1_Keyframe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Keyframe>>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1167477, XrefRangeEnd = 1167481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override int GetHashCode()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1167485, RefRangeEnd = 1167486, XrefRangeStart = 1167481, XrefRangeEnd = 1167485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SmoothTangents(int index, float weight)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&index);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &weight;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SmoothTangents_Public_Void_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1167497, RefRangeEnd = 1167499, XrefRangeStart = 1167486, XrefRangeEnd = 1167497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AnimationCurve Constant(float timeStart, float timeEnd, float value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&timeStart);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &timeEnd;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Constant_Public_Static_AnimationCurve_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1167510, RefRangeEnd = 1167514, XrefRangeStart = 1167499, XrefRangeEnd = 1167510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AnimationCurve Linear(float timeStart, float valueStart, float timeEnd, float valueEnd)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&timeStart);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &valueStart;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &timeEnd;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &valueEnd;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Linear_Public_Static_AnimationCurve_Single_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 1167525, RefRangeEnd = 1167531, XrefRangeStart = 1167514, XrefRangeEnd = 1167525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AnimationCurve EaseInOut(float timeStart, float valueStart, float timeEnd, float valueEnd)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&timeStart);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &valueStart;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &timeEnd;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &valueEnd;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EaseInOut_Public_Static_AnimationCurve_Single_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
	}

	[CallerCount(34)]
	[CachedScanResults(RefRangeStart = 1167533, RefRangeEnd = 1167567, XrefRangeStart = 1167531, XrefRangeEnd = 1167533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AnimationCurve([Optional] Il2CppStructArray<Keyframe> keys)
	{
		if (keys == null)
		{
			keys = new Il2CppStructArray<Keyframe>(0L);
		}
		this._002Ector(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr));
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)keys);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Keyframe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1167569, RefRangeEnd = 1167574, XrefRangeStart = 1167567, XrefRangeEnd = 1167569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AnimationCurve()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1167575, RefRangeEnd = 1167577, XrefRangeStart = 1167574, XrefRangeEnd = 1167575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AnimationCurve(System.IntPtr ptr, bool ownMemory)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnimationCurve>.NativeClassPtr))
	{
		System.IntPtr* ptr2 = stackalloc System.IntPtr[2];
		*ptr2 = (nint)(&ptr);
		*(bool**)((byte*)ptr2 + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &ownMemory;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_IntPtr_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr2, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1167577, XrefRangeEnd = 1167594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override bool Equals(Il2CppSystem.Object o)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)o);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1167594, XrefRangeEnd = 1167597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual bool Equals(AnimationCurve other)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)other);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AnimationCurve_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1167601, RefRangeEnd = 1167602, XrefRangeStart = 1167597, XrefRangeEnd = 1167601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CopyFrom(AnimationCurve other)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)other);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CopyFrom_Public_Void_AnimationCurve_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1167602, XrefRangeEnd = 1167604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr Internal_Create_Injected(ref ManagedSpanWrapper keys)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref keys);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_Create_Injected_Private_Static_IntPtr_byref_ManagedSpanWrapper_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1167604, XrefRangeEnd = 1167606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool Internal_Equals_Injected(System.IntPtr _unity_self, System.IntPtr other)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &other;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_Equals_Injected_Private_Static_Boolean_IntPtr_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1167606, XrefRangeEnd = 1167608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Internal_CopyFrom_Injected(System.IntPtr _unity_self, System.IntPtr other)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &other;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_CopyFrom_Injected_Private_Static_Void_IntPtr_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1167608, XrefRangeEnd = 1167610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float Evaluate_Injected(System.IntPtr _unity_self, float time)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Evaluate_Injected_Private_Static_Single_IntPtr_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1167610, XrefRangeEnd = 1167612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int AddKey_Injected(System.IntPtr _unity_self, float time, float value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&_unity_self);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddKey_Injected_Private_Static_Int32_IntPtr_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1167612, XrefRangeEnd = 1167614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int AddKey_Internal_Injected(System.IntPtr _unity_self, [In] ref Keyframe key)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref key);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddKey_Internal_Injected_Private_Static_Int32_IntPtr_byref_Keyframe_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1167614, XrefRangeEnd = 1167616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int MoveKey_Injected(System.IntPtr _unity_self, int index, [In] ref Keyframe key)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&_unity_self);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref key);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MoveKey_Injected_Private_Static_Int32_IntPtr_Int32_byref_Keyframe_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1167616, XrefRangeEnd = 1167618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ClearKeys_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearKeys_Injected_Private_Static_Void_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1167618, XrefRangeEnd = 1167620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RemoveKey_Injected(System.IntPtr _unity_self, int index)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveKey_Injected_Private_Static_Void_IntPtr_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1167620, XrefRangeEnd = 1167622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int get_length_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_length_Injected_Private_Static_Int32_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1167622, XrefRangeEnd = 1167624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetKeys_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper keys)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref keys);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetKeys_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1167624, XrefRangeEnd = 1167626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetKey_Injected(System.IntPtr _unity_self, int index, out Keyframe ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&_unity_self);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetKey_Injected_Private_Static_Void_IntPtr_Int32_byref_Keyframe_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1167626, XrefRangeEnd = 1167628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetKeys_Injected(System.IntPtr _unity_self, out BlittableArrayWrapper ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetKeys_Injected_Private_Static_Void_IntPtr_byref_BlittableArrayWrapper_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1167628, XrefRangeEnd = 1167630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetHashCode_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHashCode_Injected_Private_Static_Int32_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1167630, XrefRangeEnd = 1167632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SmoothTangents_Injected(System.IntPtr _unity_self, int index, float weight)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&_unity_self);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &weight;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SmoothTangents_Injected_Private_Static_Void_IntPtr_Int32_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public AnimationCurve(params Keyframe[] keys)
		: this(new Il2CppStructArray<Keyframe>(keys))
	{
	}

	public AnimationCurve(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public static WrapMode get_preWrapMode_Injected(System.IntPtr _unity_self)
	{
		return get_preWrapMode_InjectedDelegateField(_unity_self);
	}

	public static void set_preWrapMode_Injected(System.IntPtr _unity_self, WrapMode value)
	{
		set_preWrapMode_InjectedDelegateField(_unity_self, value);
	}

	public static WrapMode get_postWrapMode_Injected(System.IntPtr _unity_self)
	{
		return get_postWrapMode_InjectedDelegateField(_unity_self);
	}

	public static void set_postWrapMode_Injected(System.IntPtr _unity_self, WrapMode value)
	{
		set_postWrapMode_InjectedDelegateField(_unity_self, value);
	}
}
