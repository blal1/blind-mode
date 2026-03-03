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

public sealed class RectTransform : Transform
{
	[OriginalName("UnityEngine.CoreModule.dll", "", "Axis")]
	public enum Axis
	{
		Horizontal,
		Vertical
	}

	public sealed class ReapplyDrivenProperties : Il2CppSystem.MulticastDelegate
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_RectTransform_0;

		static ReapplyDrivenProperties()
		{
			Il2CppClassPointerStore<ReapplyDrivenProperties>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, "ReapplyDrivenProperties");
			NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReapplyDrivenProperties>.NativeClassPtr, 100666843);
			NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReapplyDrivenProperties>.NativeClassPtr, 100666844);
		}

		[CallerCount(245)]
		[CachedScanResults(RefRangeStart = 57019, RefRangeEnd = 57264, XrefRangeStart = 57019, XrefRangeEnd = 57264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReapplyDrivenProperties(Il2CppSystem.Object @object, System.IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReapplyDrivenProperties>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
			*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		public unsafe virtual void Invoke(RectTransform driven)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)driven);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public ReapplyDrivenProperties(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public static implicit operator ReapplyDrivenProperties(System.Action<RectTransform> P_0)
		{
			return DelegateSupport.ConvertDelegate<ReapplyDrivenProperties>((System.Delegate)P_0);
		}

		public static ReapplyDrivenProperties operator +(ReapplyDrivenProperties P_0, ReapplyDrivenProperties P_1)
		{
			return ((Il2CppObjectBase)Il2CppSystem.Delegate.Combine(P_0, P_1)).Cast<ReapplyDrivenProperties>();
		}

		public static ReapplyDrivenProperties operator -(ReapplyDrivenProperties P_0, ReapplyDrivenProperties P_1)
		{
			object obj = Il2CppSystem.Delegate.Remove(P_0, P_1);
			if (obj != null)
			{
				obj = ((Il2CppObjectBase)obj).Cast<ReapplyDrivenProperties>();
			}
			return (ReapplyDrivenProperties)obj;
		}
	}

	public enum Edge
	{
		Left,
		Right,
		Top,
		Bottom
	}

	private delegate System.IntPtr get_drivenByObject_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_drivenByObject_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr value);

	private delegate DrivenTransformProperties get_drivenProperties_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_drivenProperties_InjectedDelegate(System.IntPtr _unity_self, DrivenTransformProperties value);

	private delegate bool get_sendChildDimensionsChange_InjectedDelegate(System.IntPtr _unity_self);

	private static readonly System.IntPtr NativeFieldInfoPtr_reapplyDrivenProperties;

	private static readonly System.IntPtr NativeMethodInfoPtr_add_reapplyDrivenProperties_Public_Static_add_Void_ReapplyDrivenProperties_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_remove_reapplyDrivenProperties_Public_Static_rem_Void_ReapplyDrivenProperties_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_rect_Public_get_Rect_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_anchorMin_Public_get_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_anchorMin_Public_set_Void_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_anchorMax_Public_get_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_anchorMax_Public_set_Void_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_anchoredPosition_Public_get_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_anchoredPosition_Public_set_Void_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_sizeDelta_Public_get_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_sizeDelta_Public_set_Void_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_pivot_Public_get_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_pivot_Public_set_Void_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_anchoredPosition3D_Public_get_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_anchoredPosition3D_Public_set_Void_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_offsetMin_Public_get_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_offsetMin_Public_set_Void_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_offsetMax_Public_get_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_offsetMax_Public_set_Void_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_sendChildDimensionsChange_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ForceUpdateRectTransforms_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLocalCorners_Public_Void_Il2CppStructArray_1_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetWorldCorners_Public_Void_Il2CppStructArray_1_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetSizeWithCurrentAnchors_Public_Void_Axis_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SendReapplyDrivenProperties_Internal_Static_Void_RectTransform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetParentSize_Private_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_rect_Injected_Private_Static_Void_IntPtr_byref_Rect_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_anchorMin_Injected_Private_Static_Void_IntPtr_byref_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_anchorMin_Injected_Private_Static_Void_IntPtr_byref_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_anchorMax_Injected_Private_Static_Void_IntPtr_byref_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_anchorMax_Injected_Private_Static_Void_IntPtr_byref_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_anchoredPosition_Injected_Private_Static_Void_IntPtr_byref_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_anchoredPosition_Injected_Private_Static_Void_IntPtr_byref_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_sizeDelta_Injected_Private_Static_Void_IntPtr_byref_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_sizeDelta_Injected_Private_Static_Void_IntPtr_byref_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_pivot_Injected_Private_Static_Void_IntPtr_byref_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_pivot_Injected_Private_Static_Void_IntPtr_byref_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_sendChildDimensionsChange_Injected_Private_Static_Void_IntPtr_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ForceUpdateRectTransforms_Injected_Private_Static_Void_IntPtr_0;

	private static readonly get_drivenByObject_InjectedDelegate get_drivenByObject_InjectedDelegateField;

	private static readonly set_drivenByObject_InjectedDelegate set_drivenByObject_InjectedDelegateField;

	private static readonly get_drivenProperties_InjectedDelegate get_drivenProperties_InjectedDelegateField;

	private static readonly set_drivenProperties_InjectedDelegate set_drivenProperties_InjectedDelegateField;

	private static readonly get_sendChildDimensionsChange_InjectedDelegate get_sendChildDimensionsChange_InjectedDelegateField;

	public unsafe static ReapplyDrivenProperties reapplyDrivenProperties
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_reapplyDrivenProperties, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ReapplyDrivenProperties>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_reapplyDrivenProperties, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Rect rect
	{
		[CallerCount(374)]
		[CachedScanResults(RefRangeStart = 1216991, RefRangeEnd = 1217365, XrefRangeStart = 1216988, XrefRangeEnd = 1216991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_rect_Public_get_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Rect*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe Vector2 anchorMin
	{
		[CallerCount(28)]
		[CachedScanResults(RefRangeStart = 1217368, RefRangeEnd = 1217396, XrefRangeStart = 1217365, XrefRangeEnd = 1217368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_anchorMin_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(87)]
		[CachedScanResults(RefRangeStart = 1217399, RefRangeEnd = 1217486, XrefRangeStart = 1217396, XrefRangeEnd = 1217399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_anchorMin_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe Vector2 anchorMax
	{
		[CallerCount(25)]
		[CachedScanResults(RefRangeStart = 1217489, RefRangeEnd = 1217514, XrefRangeStart = 1217486, XrefRangeEnd = 1217489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_anchorMax_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(88)]
		[CachedScanResults(RefRangeStart = 1217517, RefRangeEnd = 1217605, XrefRangeStart = 1217514, XrefRangeEnd = 1217517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_anchorMax_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe Vector2 anchoredPosition
	{
		[CallerCount(285)]
		[CachedScanResults(RefRangeStart = 1217608, RefRangeEnd = 1217893, XrefRangeStart = 1217605, XrefRangeEnd = 1217608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_anchoredPosition_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(136)]
		[CachedScanResults(RefRangeStart = 1217896, RefRangeEnd = 1218032, XrefRangeStart = 1217893, XrefRangeEnd = 1217896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_anchoredPosition_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe Vector2 sizeDelta
	{
		[CallerCount(150)]
		[CachedScanResults(RefRangeStart = 1218035, RefRangeEnd = 1218185, XrefRangeStart = 1218032, XrefRangeEnd = 1218035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_sizeDelta_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(136)]
		[CachedScanResults(RefRangeStart = 1218188, RefRangeEnd = 1218324, XrefRangeStart = 1218185, XrefRangeEnd = 1218188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_sizeDelta_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe Vector2 pivot
	{
		[CallerCount(42)]
		[CachedScanResults(RefRangeStart = 1218327, RefRangeEnd = 1218369, XrefRangeStart = 1218324, XrefRangeEnd = 1218327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_pivot_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(46)]
		[CachedScanResults(RefRangeStart = 1218372, RefRangeEnd = 1218418, XrefRangeStart = 1218369, XrefRangeEnd = 1218372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_pivot_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe Vector3 anchoredPosition3D
	{
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 1218424, RefRangeEnd = 1218442, XrefRangeStart = 1218418, XrefRangeEnd = 1218424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_anchoredPosition3D_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1218451, RefRangeEnd = 1218457, XrefRangeStart = 1218442, XrefRangeEnd = 1218451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_anchoredPosition3D_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe Vector2 offsetMin
	{
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1218466, RefRangeEnd = 1218472, XrefRangeStart = 1218457, XrefRangeEnd = 1218466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_offsetMin_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(24)]
		[CachedScanResults(RefRangeStart = 1218498, RefRangeEnd = 1218522, XrefRangeStart = 1218472, XrefRangeEnd = 1218498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_offsetMin_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe Vector2 offsetMax
	{
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 1218533, RefRangeEnd = 1218543, XrefRangeStart = 1218522, XrefRangeEnd = 1218533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_offsetMax_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(27)]
		[CachedScanResults(RefRangeStart = 1218569, RefRangeEnd = 1218596, XrefRangeStart = 1218543, XrefRangeEnd = 1218569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_offsetMax_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool sendChildDimensionsChange
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_sendChildDimensionsChange_Injected(intPtr);
		}
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1218601, RefRangeEnd = 1218603, XrefRangeStart = 1218596, XrefRangeEnd = 1218601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_sendChildDimensionsChange_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public Object drivenByObject
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return Unmarshal.UnmarshalUnityObject<Object>(get_drivenByObject_Injected(intPtr));
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_drivenByObject_Injected(intPtr, MarshalledUnityObject.Marshal(value));
		}
	}

	public DrivenTransformProperties drivenProperties
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_drivenProperties_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_drivenProperties_Injected(intPtr, value);
		}
	}

	static RectTransform()
	{
		Il2CppClassPointerStore<RectTransform>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "RectTransform");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RectTransform>.NativeClassPtr);
		NativeFieldInfoPtr_reapplyDrivenProperties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, "reapplyDrivenProperties");
		NativeMethodInfoPtr_add_reapplyDrivenProperties_Public_Static_add_Void_ReapplyDrivenProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100666803);
		NativeMethodInfoPtr_remove_reapplyDrivenProperties_Public_Static_rem_Void_ReapplyDrivenProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100666804);
		NativeMethodInfoPtr_get_rect_Public_get_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100666805);
		NativeMethodInfoPtr_get_anchorMin_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100666806);
		NativeMethodInfoPtr_set_anchorMin_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100666807);
		NativeMethodInfoPtr_get_anchorMax_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100666808);
		NativeMethodInfoPtr_set_anchorMax_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100666809);
		NativeMethodInfoPtr_get_anchoredPosition_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100666810);
		NativeMethodInfoPtr_set_anchoredPosition_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100666811);
		NativeMethodInfoPtr_get_sizeDelta_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100666812);
		NativeMethodInfoPtr_set_sizeDelta_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100666813);
		NativeMethodInfoPtr_get_pivot_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100666814);
		NativeMethodInfoPtr_set_pivot_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100666815);
		NativeMethodInfoPtr_get_anchoredPosition3D_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100666816);
		NativeMethodInfoPtr_set_anchoredPosition3D_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100666817);
		NativeMethodInfoPtr_get_offsetMin_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100666818);
		NativeMethodInfoPtr_set_offsetMin_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100666819);
		NativeMethodInfoPtr_get_offsetMax_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100666820);
		NativeMethodInfoPtr_set_offsetMax_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100666821);
		NativeMethodInfoPtr_set_sendChildDimensionsChange_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100666822);
		NativeMethodInfoPtr_ForceUpdateRectTransforms_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100666823);
		NativeMethodInfoPtr_GetLocalCorners_Public_Void_Il2CppStructArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100666824);
		NativeMethodInfoPtr_GetWorldCorners_Public_Void_Il2CppStructArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100666825);
		NativeMethodInfoPtr_SetSizeWithCurrentAnchors_Public_Void_Axis_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100666826);
		NativeMethodInfoPtr_SendReapplyDrivenProperties_Internal_Static_Void_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100666827);
		NativeMethodInfoPtr_GetParentSize_Private_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100666828);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100666829);
		NativeMethodInfoPtr_get_rect_Injected_Private_Static_Void_IntPtr_byref_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100666830);
		NativeMethodInfoPtr_get_anchorMin_Injected_Private_Static_Void_IntPtr_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100666831);
		NativeMethodInfoPtr_set_anchorMin_Injected_Private_Static_Void_IntPtr_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100666832);
		NativeMethodInfoPtr_get_anchorMax_Injected_Private_Static_Void_IntPtr_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100666833);
		NativeMethodInfoPtr_set_anchorMax_Injected_Private_Static_Void_IntPtr_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100666834);
		NativeMethodInfoPtr_get_anchoredPosition_Injected_Private_Static_Void_IntPtr_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100666835);
		NativeMethodInfoPtr_set_anchoredPosition_Injected_Private_Static_Void_IntPtr_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100666836);
		NativeMethodInfoPtr_get_sizeDelta_Injected_Private_Static_Void_IntPtr_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100666837);
		NativeMethodInfoPtr_set_sizeDelta_Injected_Private_Static_Void_IntPtr_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100666838);
		NativeMethodInfoPtr_get_pivot_Injected_Private_Static_Void_IntPtr_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100666839);
		NativeMethodInfoPtr_set_pivot_Injected_Private_Static_Void_IntPtr_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100666840);
		NativeMethodInfoPtr_set_sendChildDimensionsChange_Injected_Private_Static_Void_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100666841);
		NativeMethodInfoPtr_ForceUpdateRectTransforms_Injected_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectTransform>.NativeClassPtr, 100666842);
		get_drivenByObject_InjectedDelegateField = IL2CPP.ResolveICall<get_drivenByObject_InjectedDelegate>("UnityEngine.RectTransform::get_drivenByObject_Injected");
		set_drivenByObject_InjectedDelegateField = IL2CPP.ResolveICall<set_drivenByObject_InjectedDelegate>("UnityEngine.RectTransform::set_drivenByObject_Injected");
		get_drivenProperties_InjectedDelegateField = IL2CPP.ResolveICall<get_drivenProperties_InjectedDelegate>("UnityEngine.RectTransform::get_drivenProperties_Injected");
		set_drivenProperties_InjectedDelegateField = IL2CPP.ResolveICall<set_drivenProperties_InjectedDelegate>("UnityEngine.RectTransform::set_drivenProperties_Injected");
		get_sendChildDimensionsChange_InjectedDelegateField = IL2CPP.ResolveICall<get_sendChildDimensionsChange_InjectedDelegate>("UnityEngine.RectTransform::get_sendChildDimensionsChange_Injected");
	}

	[SpecialName]
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1216974, XrefRangeEnd = 1216981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_reapplyDrivenProperties(ReapplyDrivenProperties value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_add_reapplyDrivenProperties_Public_Static_add_Void_ReapplyDrivenProperties_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[SpecialName]
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1216981, XrefRangeEnd = 1216988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_reapplyDrivenProperties(ReapplyDrivenProperties value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_remove_reapplyDrivenProperties_Public_Static_rem_Void_ReapplyDrivenProperties_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1218608, RefRangeEnd = 1218609, XrefRangeStart = 1218603, XrefRangeEnd = 1218608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ForceUpdateRectTransforms()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ForceUpdateRectTransforms_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1218614, RefRangeEnd = 1218616, XrefRangeStart = 1218609, XrefRangeEnd = 1218614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetLocalCorners(Il2CppStructArray<Vector3> fourCornersArray)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fourCornersArray);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLocalCorners_Public_Void_Il2CppStructArray_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(18)]
	[CachedScanResults(RefRangeStart = 1218632, RefRangeEnd = 1218650, XrefRangeStart = 1218616, XrefRangeEnd = 1218632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetWorldCorners(Il2CppStructArray<Vector3> fourCornersArray)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fourCornersArray);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetWorldCorners_Public_Void_Il2CppStructArray_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(59)]
	[CachedScanResults(RefRangeStart = 1218667, RefRangeEnd = 1218726, XrefRangeStart = 1218650, XrefRangeEnd = 1218667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetSizeWithCurrentAnchors(Axis axis, float size)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&axis);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &size;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetSizeWithCurrentAnchors_Public_Void_Axis_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1218726, XrefRangeEnd = 1218728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SendReapplyDrivenProperties(RectTransform driven)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)driven);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SendReapplyDrivenProperties_Internal_Static_Void_RectTransform_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1218748, RefRangeEnd = 1218749, XrefRangeStart = 1218728, XrefRangeEnd = 1218748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector2 GetParentSize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetParentSize_Private_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(646)]
	[CachedScanResults(RefRangeStart = 1152221, RefRangeEnd = 1152867, XrefRangeStart = 1152221, XrefRangeEnd = 1152867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RectTransform()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RectTransform>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1218749, XrefRangeEnd = 1218751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void get_rect_Injected(System.IntPtr _unity_self, out Rect ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_rect_Injected_Private_Static_Void_IntPtr_byref_Rect_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1218751, XrefRangeEnd = 1218753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void get_anchorMin_Injected(System.IntPtr _unity_self, out Vector2 ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_anchorMin_Injected_Private_Static_Void_IntPtr_byref_Vector2_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1218753, XrefRangeEnd = 1218755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_anchorMin_Injected(System.IntPtr _unity_self, [In] ref Vector2 value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_anchorMin_Injected_Private_Static_Void_IntPtr_byref_Vector2_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1218755, XrefRangeEnd = 1218757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void get_anchorMax_Injected(System.IntPtr _unity_self, out Vector2 ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_anchorMax_Injected_Private_Static_Void_IntPtr_byref_Vector2_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1218757, XrefRangeEnd = 1218759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_anchorMax_Injected(System.IntPtr _unity_self, [In] ref Vector2 value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_anchorMax_Injected_Private_Static_Void_IntPtr_byref_Vector2_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1218759, XrefRangeEnd = 1218761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void get_anchoredPosition_Injected(System.IntPtr _unity_self, out Vector2 ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_anchoredPosition_Injected_Private_Static_Void_IntPtr_byref_Vector2_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1218761, XrefRangeEnd = 1218763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_anchoredPosition_Injected(System.IntPtr _unity_self, [In] ref Vector2 value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_anchoredPosition_Injected_Private_Static_Void_IntPtr_byref_Vector2_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1218763, XrefRangeEnd = 1218765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void get_sizeDelta_Injected(System.IntPtr _unity_self, out Vector2 ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_sizeDelta_Injected_Private_Static_Void_IntPtr_byref_Vector2_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1218765, XrefRangeEnd = 1218767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_sizeDelta_Injected(System.IntPtr _unity_self, [In] ref Vector2 value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_sizeDelta_Injected_Private_Static_Void_IntPtr_byref_Vector2_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1218767, XrefRangeEnd = 1218769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void get_pivot_Injected(System.IntPtr _unity_self, out Vector2 ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_pivot_Injected_Private_Static_Void_IntPtr_byref_Vector2_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1218769, XrefRangeEnd = 1218771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_pivot_Injected(System.IntPtr _unity_self, [In] ref Vector2 value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_pivot_Injected_Private_Static_Void_IntPtr_byref_Vector2_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1218771, XrefRangeEnd = 1218773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_sendChildDimensionsChange_Injected(System.IntPtr _unity_self, bool value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_sendChildDimensionsChange_Injected_Private_Static_Void_IntPtr_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1218773, XrefRangeEnd = 1218775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ForceUpdateRectTransforms_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ForceUpdateRectTransforms_Injected_Private_Static_Void_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public RectTransform(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public void SetInsetAndSizeFromParentEdge(Edge edge, float inset, float size)
	{
		int index = ((edge == Edge.Top || edge == Edge.Bottom) ? 1 : 0);
		bool flag = edge == Edge.Top || edge == Edge.Right;
		float value = (flag ? 1 : 0);
		Vector2 vector = anchorMin;
		vector[index] = value;
		anchorMin = vector;
		vector = anchorMax;
		vector[index] = value;
		anchorMax = vector;
		Vector2 vector2 = sizeDelta;
		vector2[index] = size;
		sizeDelta = vector2;
		Vector2 vector3 = anchoredPosition;
		vector3[index] = (flag ? (0f - inset - size * (1f - pivot[index])) : (inset + size * pivot[index]));
		anchoredPosition = vector3;
	}

	public Rect GetRectInParentSpace()
	{
		Rect result = rect;
		Vector2 vector = offsetMin + Vector2.Scale(pivot, result.size);
		if ((bool)base.parent)
		{
			RectTransform component = base.parent.GetComponent<RectTransform>();
			if ((bool)component)
			{
				vector += Vector2.Scale(anchorMin, component.rect.size);
			}
		}
		result.x += vector.x;
		result.y += vector.y;
		return result;
	}

	public static System.IntPtr get_drivenByObject_Injected(System.IntPtr _unity_self)
	{
		return get_drivenByObject_InjectedDelegateField(_unity_self);
	}

	public static void set_drivenByObject_Injected(System.IntPtr _unity_self, System.IntPtr value)
	{
		set_drivenByObject_InjectedDelegateField(_unity_self, value);
	}

	public static DrivenTransformProperties get_drivenProperties_Injected(System.IntPtr _unity_self)
	{
		return get_drivenProperties_InjectedDelegateField(_unity_self);
	}

	public static void set_drivenProperties_Injected(System.IntPtr _unity_self, DrivenTransformProperties value)
	{
		set_drivenProperties_InjectedDelegateField(_unity_self, value);
	}

	public static bool get_sendChildDimensionsChange_Injected(System.IntPtr _unity_self)
	{
		return get_sendChildDimensionsChange_InjectedDelegateField(_unity_self);
	}
}
