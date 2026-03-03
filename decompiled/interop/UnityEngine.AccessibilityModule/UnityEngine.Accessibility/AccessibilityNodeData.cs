using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Accessibility;

public sealed class AccessibilityNodeData : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr__id_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__isActive_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__label_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__value_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__hint_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__role_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__allowsDirectInteraction_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__state_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__frame_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__parentId_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__childIds_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__isFocused_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__language_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__implementsSelected_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__implementsDismissed_k__BackingField;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_id_Public_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_isActive_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_label_Public_set_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_value_Public_set_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_hint_Public_set_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_role_Public_set_Void_AccessibilityRole_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_allowsDirectInteraction_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_state_Public_set_Void_AccessibilityState_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_frame_Public_set_Void_Rect_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_parentId_Public_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_childIds_Public_set_Void_Il2CppStructArray_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_language_Internal_set_Void_SystemLanguage_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_implementsSelected_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_implementsDismissed_Public_set_Void_Boolean_0;

	public unsafe int _id_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__id_k__BackingField);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__id_k__BackingField)) = value;
		}
	}

	public unsafe bool _isActive_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__isActive_k__BackingField);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__isActive_k__BackingField)) = value;
		}
	}

	public unsafe string _label_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__label_k__BackingField);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__label_k__BackingField)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string _value_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__value_k__BackingField);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__value_k__BackingField)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string _hint_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__hint_k__BackingField);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__hint_k__BackingField)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe AccessibilityRole _role_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__role_k__BackingField);
			return *(AccessibilityRole*)num;
		}
		set
		{
			*(AccessibilityRole*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__role_k__BackingField)) = value;
		}
	}

	public unsafe bool _allowsDirectInteraction_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__allowsDirectInteraction_k__BackingField);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__allowsDirectInteraction_k__BackingField)) = value;
		}
	}

	public unsafe AccessibilityState _state_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__state_k__BackingField);
			return *(AccessibilityState*)num;
		}
		set
		{
			*(AccessibilityState*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__state_k__BackingField)) = value;
		}
	}

	public unsafe Rect _frame_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__frame_k__BackingField);
			return *(Rect*)num;
		}
		set
		{
			*(Rect*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__frame_k__BackingField)) = value;
		}
	}

	public unsafe int _parentId_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__parentId_k__BackingField);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__parentId_k__BackingField)) = value;
		}
	}

	public unsafe Il2CppStructArray<int> _childIds_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__childIds_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__childIds_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe bool _isFocused_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__isFocused_k__BackingField);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__isFocused_k__BackingField)) = value;
		}
	}

	public unsafe SystemLanguage _language_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__language_k__BackingField);
			return *(SystemLanguage*)num;
		}
		set
		{
			*(SystemLanguage*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__language_k__BackingField)) = value;
		}
	}

	public unsafe bool _implementsSelected_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__implementsSelected_k__BackingField);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__implementsSelected_k__BackingField)) = value;
		}
	}

	public unsafe bool _implementsDismissed_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__implementsDismissed_k__BackingField);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__implementsDismissed_k__BackingField)) = value;
		}
	}

	public unsafe int id
	{
		get
		{
			return _id_k__BackingField;
		}
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 53703, RefRangeEnd = 53715, XrefRangeStart = 53703, XrefRangeEnd = 53715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_id_Public_set_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool isActive
	{
		get
		{
			return _isActive_k__BackingField;
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 584882, RefRangeEnd = 584883, XrefRangeStart = 584882, XrefRangeEnd = 584883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_isActive_Public_set_Void_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe string label
	{
		get
		{
			return _label_k__BackingField;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_label_Public_set_Void_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe string value
	{
		get
		{
			return _value_k__BackingField;
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 42532, RefRangeEnd = 42533, XrefRangeStart = 42532, XrefRangeEnd = 42533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_value_Public_set_Void_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe string hint
	{
		get
		{
			return _hint_k__BackingField;
		}
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 86477, RefRangeEnd = 86487, XrefRangeStart = 86477, XrefRangeEnd = 86487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_hint_Public_set_Void_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe AccessibilityRole role
	{
		get
		{
			return _role_k__BackingField;
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_role_Public_set_Void_AccessibilityRole_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool allowsDirectInteraction
	{
		get
		{
			return _allowsDirectInteraction_k__BackingField;
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_allowsDirectInteraction_Public_set_Void_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe AccessibilityState state
	{
		get
		{
			return _state_k__BackingField;
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_state_Public_set_Void_AccessibilityState_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe Rect frame
	{
		get
		{
			return _frame_k__BackingField;
		}
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 591312, RefRangeEnd = 591315, XrefRangeStart = 591312, XrefRangeEnd = 591315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_frame_Public_set_Void_Rect_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe int parentId
	{
		get
		{
			return _parentId_k__BackingField;
		}
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 202040, RefRangeEnd = 202045, XrefRangeStart = 202040, XrefRangeEnd = 202045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_parentId_Public_set_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe Il2CppStructArray<int> childIds
	{
		get
		{
			return _childIds_k__BackingField;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_childIds_Public_set_Void_Il2CppStructArray_1_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe SystemLanguage language
	{
		get
		{
			return _language_k__BackingField;
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_language_Internal_set_Void_SystemLanguage_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool implementsSelected
	{
		get
		{
			return _implementsSelected_k__BackingField;
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_implementsSelected_Public_set_Void_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool implementsDismissed
	{
		get
		{
			return _implementsDismissed_k__BackingField;
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_implementsDismissed_Public_set_Void_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public bool isFocused => _isFocused_k__BackingField;

	static AccessibilityNodeData()
	{
		Il2CppClassPointerStore<AccessibilityNodeData>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AccessibilityModule.dll", "UnityEngine.Accessibility", "AccessibilityNodeData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AccessibilityNodeData>.NativeClassPtr);
		NativeFieldInfoPtr__id_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccessibilityNodeData>.NativeClassPtr, "<id>k__BackingField");
		NativeFieldInfoPtr__isActive_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccessibilityNodeData>.NativeClassPtr, "<isActive>k__BackingField");
		NativeFieldInfoPtr__label_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccessibilityNodeData>.NativeClassPtr, "<label>k__BackingField");
		NativeFieldInfoPtr__value_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccessibilityNodeData>.NativeClassPtr, "<value>k__BackingField");
		NativeFieldInfoPtr__hint_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccessibilityNodeData>.NativeClassPtr, "<hint>k__BackingField");
		NativeFieldInfoPtr__role_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccessibilityNodeData>.NativeClassPtr, "<role>k__BackingField");
		NativeFieldInfoPtr__allowsDirectInteraction_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccessibilityNodeData>.NativeClassPtr, "<allowsDirectInteraction>k__BackingField");
		NativeFieldInfoPtr__state_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccessibilityNodeData>.NativeClassPtr, "<state>k__BackingField");
		NativeFieldInfoPtr__frame_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccessibilityNodeData>.NativeClassPtr, "<frame>k__BackingField");
		NativeFieldInfoPtr__parentId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccessibilityNodeData>.NativeClassPtr, "<parentId>k__BackingField");
		NativeFieldInfoPtr__childIds_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccessibilityNodeData>.NativeClassPtr, "<childIds>k__BackingField");
		NativeFieldInfoPtr__isFocused_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccessibilityNodeData>.NativeClassPtr, "<isFocused>k__BackingField");
		NativeFieldInfoPtr__language_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccessibilityNodeData>.NativeClassPtr, "<language>k__BackingField");
		NativeFieldInfoPtr__implementsSelected_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccessibilityNodeData>.NativeClassPtr, "<implementsSelected>k__BackingField");
		NativeFieldInfoPtr__implementsDismissed_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccessibilityNodeData>.NativeClassPtr, "<implementsDismissed>k__BackingField");
		NativeMethodInfoPtr_set_id_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccessibilityNodeData>.NativeClassPtr, 100663340);
		NativeMethodInfoPtr_set_isActive_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccessibilityNodeData>.NativeClassPtr, 100663341);
		NativeMethodInfoPtr_set_label_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccessibilityNodeData>.NativeClassPtr, 100663342);
		NativeMethodInfoPtr_set_value_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccessibilityNodeData>.NativeClassPtr, 100663343);
		NativeMethodInfoPtr_set_hint_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccessibilityNodeData>.NativeClassPtr, 100663344);
		NativeMethodInfoPtr_set_role_Public_set_Void_AccessibilityRole_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccessibilityNodeData>.NativeClassPtr, 100663345);
		NativeMethodInfoPtr_set_allowsDirectInteraction_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccessibilityNodeData>.NativeClassPtr, 100663346);
		NativeMethodInfoPtr_set_state_Public_set_Void_AccessibilityState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccessibilityNodeData>.NativeClassPtr, 100663347);
		NativeMethodInfoPtr_set_frame_Public_set_Void_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccessibilityNodeData>.NativeClassPtr, 100663348);
		NativeMethodInfoPtr_set_parentId_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccessibilityNodeData>.NativeClassPtr, 100663349);
		NativeMethodInfoPtr_set_childIds_Public_set_Void_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccessibilityNodeData>.NativeClassPtr, 100663350);
		NativeMethodInfoPtr_set_language_Internal_set_Void_SystemLanguage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccessibilityNodeData>.NativeClassPtr, 100663351);
		NativeMethodInfoPtr_set_implementsSelected_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccessibilityNodeData>.NativeClassPtr, 100663352);
		NativeMethodInfoPtr_set_implementsDismissed_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccessibilityNodeData>.NativeClassPtr, 100663353);
	}

	public AccessibilityNodeData(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public AccessibilityNodeData()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AccessibilityNodeData>.NativeClassPtr))
	{
	}
}
