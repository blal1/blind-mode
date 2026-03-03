using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Accessibility;

public class AccessibilityNode : Il2CppSystem.Object
{
	public class ObservableList<T> : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_m_Items;

		private static readonly System.IntPtr NativeFieldInfoPtr_listChanged;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_T_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_T_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_add_listChanged_Public_add_Void_Action_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_remove_listChanged_Public_rem_Void_Action_0;

		public unsafe List<T> m_Items
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Items);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<T>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Items)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe Il2CppSystem.Action listChanged
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_listChanged);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_listChanged)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe virtual int Count
		{
			[CallerCount(55)]
			[CachedScanResults(RefRangeStart = 54455, RefRangeEnd = 54510, XrefRangeStart = 54455, XrefRangeEnd = 54510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		public unsafe virtual T this[int index]
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1148011, RefRangeEnd = 1148014, XrefRangeStart = 1148009, XrefRangeEnd = 1148011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&index);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_T_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
			}
		}

		static ObservableList()
		{
			Il2CppClassPointerStore<ObservableList<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AccessibilityNode>.NativeClassPtr, "ObservableList`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObservableList<T>>.NativeClassPtr);
			NativeFieldInfoPtr_m_Items = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObservableList<T>>.NativeClassPtr, "m_Items");
			NativeFieldInfoPtr_listChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObservableList<T>>.NativeClassPtr, "listChanged");
			NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObservableList<T>>.NativeClassPtr, 100663421);
			NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObservableList<T>>.NativeClassPtr, 100663422);
			NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObservableList<T>>.NativeClassPtr, 100663423);
			NativeMethodInfoPtr_add_listChanged_Public_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObservableList<T>>.NativeClassPtr, 100663424);
			NativeMethodInfoPtr_remove_listChanged_Public_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObservableList<T>>.NativeClassPtr, 100663425);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1148016, RefRangeEnd = 1148017, XrefRangeStart = 1148014, XrefRangeEnd = 1148016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator<T> GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IEnumerator<T>>(intPtr2) : null;
		}

		[SpecialName]
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1148017, XrefRangeEnd = 1148021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_listChanged(Il2CppSystem.Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_add_listChanged_Public_add_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[SpecialName]
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1148025, RefRangeEnd = 1148027, XrefRangeStart = 1148021, XrefRangeEnd = 1148025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_listChanged(Il2CppSystem.Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_remove_listChanged_Public_rem_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public ObservableList(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr__id_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_FrameGetter;

	private static readonly System.IntPtr NativeFieldInfoPtr_focusChanged;

	private static readonly System.IntPtr NativeFieldInfoPtr_selected;

	private static readonly System.IntPtr NativeFieldInfoPtr_incremented;

	private static readonly System.IntPtr NativeFieldInfoPtr_decremented;

	private static readonly System.IntPtr NativeFieldInfoPtr_dismissed;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Label;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Value;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Hint;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_IsActive;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Role;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_AllowsDirectInteraction;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_State;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Parent;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Children;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Actions;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Frame;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Language;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Hierarchy;

	private static readonly System.IntPtr NativeMethodInfoPtr_FreeNative_Internal_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_id_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_label_Public_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_value_Public_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_hint_Public_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isActive_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_role_Public_get_AccessibilityRole_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_allowsDirectInteraction_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_state_Public_get_AccessibilityState_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_parent_Public_get_AccessibilityNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_childList_Internal_get_IList_1_AccessibilityNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_frame_Public_get_Rect_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetFrame_Private_Void_Rect_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_frameGetter_Public_get_Func_1_Rect_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalculateFrame_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_language_Internal_get_SystemLanguage_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetNodeData_Internal_Void_byref_AccessibilityNodeData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChildrenChanged_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ActionsChanged_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsInActiveHierarchy_Private_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NotifyFocusChanged_Internal_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InvokeFocusChanged_Internal_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InvokeSelected_Internal_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InvokeIncremented_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InvokeDecremented_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Dismissed_Internal_Boolean_0;

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

	public unsafe Il2CppSystem.Func<Rect> m_FrameGetter
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_FrameGetter);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<Rect>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_FrameGetter)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppSystem.Action<AccessibilityNode, bool> focusChanged
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_focusChanged);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<AccessibilityNode, bool>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_focusChanged)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppSystem.Func<bool> selected
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_selected);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<bool>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_selected)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppSystem.Action incremented
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_incremented);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_incremented)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppSystem.Action decremented
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_decremented);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_decremented)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppSystem.Func<bool> dismissed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dismissed);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<bool>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dismissed)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe string m_Label
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Label);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Label)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string m_Value
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Value);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Value)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string m_Hint
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Hint);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Hint)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe bool m_IsActive
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_IsActive);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_IsActive)) = value;
		}
	}

	public unsafe AccessibilityRole m_Role
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Role);
			return *(AccessibilityRole*)num;
		}
		set
		{
			*(AccessibilityRole*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Role)) = value;
		}
	}

	public unsafe bool m_AllowsDirectInteraction
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AllowsDirectInteraction);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AllowsDirectInteraction)) = value;
		}
	}

	public unsafe AccessibilityState m_State
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_State);
			return *(AccessibilityState*)num;
		}
		set
		{
			*(AccessibilityState*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_State)) = value;
		}
	}

	public unsafe AccessibilityNode m_Parent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Parent);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AccessibilityNode>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Parent)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe ObservableList<AccessibilityNode> m_Children
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Children);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ObservableList<AccessibilityNode>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Children)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe ObservableList<AccessibilityAction> m_Actions
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Actions);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ObservableList<AccessibilityAction>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Actions)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Rect m_Frame
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Frame);
			return *(Rect*)num;
		}
		set
		{
			*(Rect*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Frame)) = value;
		}
	}

	public unsafe SystemLanguage m_Language
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Language);
			return *(SystemLanguage*)num;
		}
		set
		{
			*(SystemLanguage*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Language)) = value;
		}
	}

	public unsafe AccessibilityHierarchy m_Hierarchy
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Hierarchy);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AccessibilityHierarchy>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Hierarchy)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe int id
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 50668, RefRangeEnd = 50669, XrefRangeStart = 50668, XrefRangeEnd = 50669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_id_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			_id_k__BackingField = value;
		}
	}

	public unsafe string label
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 84624, RefRangeEnd = 84627, XrefRangeStart = 84624, XrefRangeEnd = 84627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_label_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
		set
		{
			if (!Il2CppSystem.String.Equals(m_Label, value))
			{
				m_Label = value;
				if (IsInActiveHierarchy())
				{
					AccessibilityNodeManager.SetLabel(id, value);
				}
			}
		}
	}

	public unsafe string value
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_value_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
		set
		{
			if (!Il2CppSystem.String.Equals(m_Value, value))
			{
				m_Value = value;
				if (IsInActiveHierarchy())
				{
					AccessibilityNodeManager.SetValue(id, value);
				}
			}
		}
	}

	public unsafe string hint
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 84632, RefRangeEnd = 84633, XrefRangeStart = 84632, XrefRangeEnd = 84633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_hint_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
		set
		{
			if (!Il2CppSystem.String.Equals(m_Hint, value))
			{
				m_Hint = value;
				if (IsInActiveHierarchy())
				{
					AccessibilityNodeManager.SetHint(id, value);
				}
			}
		}
	}

	public unsafe bool isActive
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isActive_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			if (m_IsActive != value)
			{
				m_IsActive = value;
				if (IsInActiveHierarchy())
				{
					AccessibilityNodeManager.SetIsActive(id, value);
				}
			}
		}
	}

	public unsafe AccessibilityRole role
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_role_Public_get_AccessibilityRole_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(AccessibilityRole*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			if (m_Role != value)
			{
				m_Role = value;
				if (IsInActiveHierarchy())
				{
					AccessibilityNodeManager.SetRole(id, value);
				}
			}
		}
	}

	public unsafe bool allowsDirectInteraction
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_allowsDirectInteraction_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			if (value && !Application.isEditor && Application.platform != RuntimePlatform.IPhonePlayer)
			{
				throw new Il2CppSystem.PlatformNotSupportedException("allowsDirectInteraction is only supported on iOS.");
			}
			if (m_AllowsDirectInteraction != value)
			{
				m_AllowsDirectInteraction = value;
				if (IsInActiveHierarchy())
				{
					AccessibilityNodeManager.SetAllowsDirectInteraction(id, value);
				}
			}
		}
	}

	public unsafe AccessibilityState state
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_state_Public_get_AccessibilityState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(AccessibilityState*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			if (m_State != value)
			{
				m_State = value;
				if (IsInActiveHierarchy())
				{
					AccessibilityNodeManager.SetState(id, value);
				}
			}
		}
	}

	public unsafe AccessibilityNode parent
	{
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 140862, RefRangeEnd = 140879, XrefRangeStart = 140862, XrefRangeEnd = 140879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_parent_Public_get_AccessibilityNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<AccessibilityNode>(intPtr2) : null;
		}
	}

	public unsafe IList<AccessibilityNode> childList
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 140861, RefRangeEnd = 140862, XrefRangeStart = 140861, XrefRangeEnd = 140862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_childList_Internal_get_IList_1_AccessibilityNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IList<AccessibilityNode>>(intPtr2) : null;
		}
		set
		{
			if (m_Children != null)
			{
				m_Children.remove_listChanged(new Il2CppSystem.Action(this, (nint)__ldftn(AccessibilityNode.ChildrenChanged)));
			}
			m_Children = new ObservableList<AccessibilityNode>((IEnumerable<AccessibilityNode>)(object)value);
			ChildrenChanged();
			m_Children.add_listChanged(new Il2CppSystem.Action(this, (nint)__ldftn(AccessibilityNode.ChildrenChanged)));
		}
	}

	public unsafe Rect frame
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1148080, RefRangeEnd = 1148082, XrefRangeStart = 1148072, XrefRangeEnd = 1148080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_frame_Public_get_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Rect*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			SetFrame(value);
		}
	}

	public unsafe Il2CppSystem.Func<Rect> frameGetter
	{
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 25665, RefRangeEnd = 25677, XrefRangeStart = 25665, XrefRangeEnd = 25677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_frameGetter_Public_get_Func_1_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<Rect>>(intPtr2) : null;
		}
		set
		{
			if (!(m_FrameGetter == value))
			{
				m_FrameGetter = value;
				if (IsInActiveHierarchy())
				{
					AccessibilityNodeManager.SetFrame(id, frame);
				}
			}
		}
	}

	public unsafe SystemLanguage language
	{
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 178480, RefRangeEnd = 178492, XrefRangeStart = 178480, XrefRangeEnd = 178492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_language_Internal_get_SystemLanguage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(SystemLanguage*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			if (m_Language != value)
			{
				m_Language = value;
				if (IsInActiveHierarchy())
				{
					AccessibilityNodeManager.SetLanguage(id, value);
				}
			}
		}
	}

	public IReadOnlyList<AccessibilityNode> children => (IReadOnlyList<AccessibilityNode>)(object)m_Children;

	public unsafe IList<AccessibilityAction> actions
	{
		get
		{
			return (IList<AccessibilityAction>)(object)m_Actions;
		}
		set
		{
			if (m_Actions != null)
			{
				m_Actions.remove_listChanged(new Il2CppSystem.Action(this, (nint)__ldftn(AccessibilityNode.ActionsChanged)));
			}
			m_Actions = new ObservableList<AccessibilityAction>((IEnumerable<AccessibilityAction>)(object)value);
			ActionsChanged();
			m_Actions.add_listChanged(new Il2CppSystem.Action(this, (nint)__ldftn(AccessibilityNode.ActionsChanged)));
		}
	}

	public bool isFocused => IsInActiveHierarchy() && AccessibilityNodeManager.GetIsFocused(id);

	static AccessibilityNode()
	{
		Il2CppClassPointerStore<AccessibilityNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AccessibilityModule.dll", "UnityEngine.Accessibility", "AccessibilityNode");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AccessibilityNode>.NativeClassPtr);
		NativeFieldInfoPtr__id_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccessibilityNode>.NativeClassPtr, "<id>k__BackingField");
		NativeFieldInfoPtr_m_FrameGetter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccessibilityNode>.NativeClassPtr, "m_FrameGetter");
		NativeFieldInfoPtr_focusChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccessibilityNode>.NativeClassPtr, "focusChanged");
		NativeFieldInfoPtr_selected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccessibilityNode>.NativeClassPtr, "selected");
		NativeFieldInfoPtr_incremented = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccessibilityNode>.NativeClassPtr, "incremented");
		NativeFieldInfoPtr_decremented = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccessibilityNode>.NativeClassPtr, "decremented");
		NativeFieldInfoPtr_dismissed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccessibilityNode>.NativeClassPtr, "dismissed");
		NativeFieldInfoPtr_m_Label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccessibilityNode>.NativeClassPtr, "m_Label");
		NativeFieldInfoPtr_m_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccessibilityNode>.NativeClassPtr, "m_Value");
		NativeFieldInfoPtr_m_Hint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccessibilityNode>.NativeClassPtr, "m_Hint");
		NativeFieldInfoPtr_m_IsActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccessibilityNode>.NativeClassPtr, "m_IsActive");
		NativeFieldInfoPtr_m_Role = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccessibilityNode>.NativeClassPtr, "m_Role");
		NativeFieldInfoPtr_m_AllowsDirectInteraction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccessibilityNode>.NativeClassPtr, "m_AllowsDirectInteraction");
		NativeFieldInfoPtr_m_State = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccessibilityNode>.NativeClassPtr, "m_State");
		NativeFieldInfoPtr_m_Parent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccessibilityNode>.NativeClassPtr, "m_Parent");
		NativeFieldInfoPtr_m_Children = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccessibilityNode>.NativeClassPtr, "m_Children");
		NativeFieldInfoPtr_m_Actions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccessibilityNode>.NativeClassPtr, "m_Actions");
		NativeFieldInfoPtr_m_Frame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccessibilityNode>.NativeClassPtr, "m_Frame");
		NativeFieldInfoPtr_m_Language = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccessibilityNode>.NativeClassPtr, "m_Language");
		NativeFieldInfoPtr_m_Hierarchy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccessibilityNode>.NativeClassPtr, "m_Hierarchy");
		NativeMethodInfoPtr_FreeNative_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccessibilityNode>.NativeClassPtr, 100663395);
		NativeMethodInfoPtr_get_id_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccessibilityNode>.NativeClassPtr, 100663396);
		NativeMethodInfoPtr_get_label_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccessibilityNode>.NativeClassPtr, 100663397);
		NativeMethodInfoPtr_get_value_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccessibilityNode>.NativeClassPtr, 100663398);
		NativeMethodInfoPtr_get_hint_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccessibilityNode>.NativeClassPtr, 100663399);
		NativeMethodInfoPtr_get_isActive_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccessibilityNode>.NativeClassPtr, 100663400);
		NativeMethodInfoPtr_get_role_Public_get_AccessibilityRole_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccessibilityNode>.NativeClassPtr, 100663401);
		NativeMethodInfoPtr_get_allowsDirectInteraction_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccessibilityNode>.NativeClassPtr, 100663402);
		NativeMethodInfoPtr_get_state_Public_get_AccessibilityState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccessibilityNode>.NativeClassPtr, 100663403);
		NativeMethodInfoPtr_get_parent_Public_get_AccessibilityNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccessibilityNode>.NativeClassPtr, 100663404);
		NativeMethodInfoPtr_get_childList_Internal_get_IList_1_AccessibilityNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccessibilityNode>.NativeClassPtr, 100663405);
		NativeMethodInfoPtr_get_frame_Public_get_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccessibilityNode>.NativeClassPtr, 100663406);
		NativeMethodInfoPtr_SetFrame_Private_Void_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccessibilityNode>.NativeClassPtr, 100663407);
		NativeMethodInfoPtr_get_frameGetter_Public_get_Func_1_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccessibilityNode>.NativeClassPtr, 100663408);
		NativeMethodInfoPtr_CalculateFrame_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccessibilityNode>.NativeClassPtr, 100663409);
		NativeMethodInfoPtr_get_language_Internal_get_SystemLanguage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccessibilityNode>.NativeClassPtr, 100663410);
		NativeMethodInfoPtr_GetNodeData_Internal_Void_byref_AccessibilityNodeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccessibilityNode>.NativeClassPtr, 100663411);
		NativeMethodInfoPtr_ChildrenChanged_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccessibilityNode>.NativeClassPtr, 100663412);
		NativeMethodInfoPtr_ActionsChanged_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccessibilityNode>.NativeClassPtr, 100663413);
		NativeMethodInfoPtr_IsInActiveHierarchy_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccessibilityNode>.NativeClassPtr, 100663414);
		NativeMethodInfoPtr_NotifyFocusChanged_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccessibilityNode>.NativeClassPtr, 100663415);
		NativeMethodInfoPtr_InvokeFocusChanged_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccessibilityNode>.NativeClassPtr, 100663416);
		NativeMethodInfoPtr_InvokeSelected_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccessibilityNode>.NativeClassPtr, 100663417);
		NativeMethodInfoPtr_InvokeIncremented_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccessibilityNode>.NativeClassPtr, 100663418);
		NativeMethodInfoPtr_InvokeDecremented_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccessibilityNode>.NativeClassPtr, 100663419);
		NativeMethodInfoPtr_Dismissed_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccessibilityNode>.NativeClassPtr, 100663420);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1148070, RefRangeEnd = 1148072, XrefRangeStart = 1148027, XrefRangeEnd = 1148070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FreeNative(bool freeChildren)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&freeChildren);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FreeNative_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1148082, XrefRangeEnd = 1148088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetFrame(Rect frame)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&frame);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetFrame_Private_Void_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1148088, XrefRangeEnd = 1148096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CalculateFrame()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalculateFrame_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1148114, RefRangeEnd = 1148115, XrefRangeStart = 1148096, XrefRangeEnd = 1148114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetNodeData(ref AccessibilityNodeData nodeData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)nodeData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetNodeData_Internal_Void_byref_AccessibilityNodeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1148115, XrefRangeEnd = 1148140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ChildrenChanged()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChildrenChanged_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1148140, XrefRangeEnd = 1148159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ActionsChanged()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ActionsChanged_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1148159, XrefRangeEnd = 1148160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsInActiveHierarchy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsInActiveHierarchy_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1148160, XrefRangeEnd = 1148165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void NotifyFocusChanged(bool isNodeFocused)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&isNodeFocused);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NotifyFocusChanged_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe void InvokeFocusChanged(bool isNodeFocused)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&isNodeFocused);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InvokeFocusChanged_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe bool InvokeSelected()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InvokeSelected_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void InvokeIncremented()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InvokeIncremented_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 282893, RefRangeEnd = 282894, XrefRangeStart = 282893, XrefRangeEnd = 282894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InvokeDecremented()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InvokeDecremented_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe bool Dismissed()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dismissed_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public AccessibilityNode(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public unsafe void CreateNativeNodeWithData(ref AccessibilityNodeData nodeData)
	{
		//IL_0055: Expected O, but got Ref
		//IL_0019: Expected O, but got Ref
		//IL_0030: Expected O, but got Ref
		//IL_0039: Expected O, but got Ref
		if (AccessibilityManager.isSupportedPlatform)
		{
			while (!AccessibilityNodeManager.CreateNativeNodeWithData(nodeData))
			{
				Debug.LogWarning(Il2CppSystem.String.Format("AccessibilityNode.CreateNativeNodeWithData: id '{0}' is already used", (Il2CppSystem.Object)(object)((AccessibilityNodeData)Unsafe.AsPointer(ref nodeData)).id));
				((AccessibilityNodeData)Unsafe.AsPointer(ref nodeData)).id++;
			}
		}
		id = ((AccessibilityNodeData)Unsafe.AsPointer(ref nodeData)).id;
	}

	public unsafe void AllocateNative()
	{
		//IL_0029: Expected O, but got Ref
		//IL_0037: Expected O, but got Ref
		//IL_0045: Expected O, but got Ref
		//IL_0053: Expected O, but got Ref
		//IL_0061: Expected O, but got Ref
		//IL_006f: Expected O, but got Ref
		//IL_007d: Expected O, but got Ref
		//IL_008b: Expected O, but got Ref
		//IL_00a5: Expected O, but got Ref
		//IL_00b3: Expected O, but got Ref
		//IL_00c1: Expected O, but got Ref
		//IL_00d2: Expected O, but got Ref
		//IL_00e3: Expected O, but got Ref
		if (!IsInActiveHierarchy())
		{
			return;
		}
		AccessibilityNodeData accessibilityNodeData = null;
		((AccessibilityNodeData)(&accessibilityNodeData)).id = id;
		((AccessibilityNodeData)(&accessibilityNodeData)).label = label;
		((AccessibilityNodeData)(&accessibilityNodeData)).value = value;
		((AccessibilityNodeData)(&accessibilityNodeData)).hint = hint;
		((AccessibilityNodeData)(&accessibilityNodeData)).isActive = isActive;
		((AccessibilityNodeData)(&accessibilityNodeData)).role = role;
		((AccessibilityNodeData)(&accessibilityNodeData)).allowsDirectInteraction = allowsDirectInteraction;
		((AccessibilityNodeData)(&accessibilityNodeData)).state = state;
		((AccessibilityNodeData)(&accessibilityNodeData)).parentId = parent?.id ?? (-1);
		((AccessibilityNodeData)(&accessibilityNodeData)).frame = frame;
		((AccessibilityNodeData)(&accessibilityNodeData)).language = language;
		((AccessibilityNodeData)(&accessibilityNodeData)).implementsSelected = (object)selected != null;
		((AccessibilityNodeData)(&accessibilityNodeData)).implementsDismissed = (object)dismissed != null;
		AccessibilityNodeData nodeData = accessibilityNodeData;
		CreateNativeNodeWithData(ref nodeData);
		ActionsChanged();
		m_Actions.add_listChanged(new Il2CppSystem.Action(this, (nint)__ldftn(AccessibilityNode.ActionsChanged)));
		IEnumerator<AccessibilityNode> enumerator = m_Children.GetEnumerator();
		try
		{
			while (((IEnumerator)(object)enumerator).MoveNext())
			{
				AccessibilityNode current = enumerator.Current;
				current.AllocateNative();
			}
		}
		finally
		{
			((Il2CppSystem.IDisposable)(object)enumerator)?.Dispose();
		}
		ChildrenChanged();
		m_Children.add_listChanged(new Il2CppSystem.Action(this, (nint)__ldftn(AccessibilityNode.ChildrenChanged)));
	}

	public void SetParent(AccessibilityNode parent, [Optional] int index)
	{
		m_Parent = parent;
		if (IsInActiveHierarchy())
		{
			int parentId = parent?.id ?? (-1);
			AccessibilityNodeManager.SetParent(id, parentId, index);
		}
	}

	[SpecialName]
	public void add_focusChanged(Il2CppSystem.Action<AccessibilityNode, bool> value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	[SpecialName]
	public void remove_focusChanged(Il2CppSystem.Action<AccessibilityNode, bool> value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	[SpecialName]
	public void add_selected(Il2CppSystem.Func<bool> value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	[SpecialName]
	public void remove_selected(Il2CppSystem.Func<bool> value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	[SpecialName]
	public void add_incremented(Il2CppSystem.Action value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	[SpecialName]
	public void remove_incremented(Il2CppSystem.Action value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	[SpecialName]
	public void add_decremented(Il2CppSystem.Action value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	[SpecialName]
	public void remove_decremented(Il2CppSystem.Action value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	[SpecialName]
	public void add_dismissed(Il2CppSystem.Func<bool> value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	[SpecialName]
	public void remove_dismissed(Il2CppSystem.Func<bool> value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public void Destroy(bool destroyChildren)
	{
		FreeNative(destroyChildren);
		((ICollection<AccessibilityNode>)(object)parent?.childList).Remove(this);
		if (destroyChildren)
		{
			for (int num = ((ICollection<AccessibilityNode>)(object)childList).Count - 1; num >= 0; num--)
			{
				childList[num].Destroy(destroyChildren: true);
			}
		}
		else
		{
			IEnumerator<AccessibilityNode> enumerator = ((IEnumerable<AccessibilityNode>)(object)childList).GetEnumerator();
			try
			{
				while (((IEnumerator)(object)enumerator).MoveNext())
				{
					AccessibilityNode current = enumerator.Current;
					current.SetParent(parent, -1);
					((ICollection<AccessibilityNode>)(object)parent?.childList).Add(current);
				}
			}
			finally
			{
				((Il2CppSystem.IDisposable)(object)enumerator)?.Dispose();
			}
		}
		((ICollection<AccessibilityNode>)(object)childList).Clear();
		m_Hierarchy = null;
	}

	public override int GetHashCode()
	{
		return id;
	}

	public override string ToString()
	{
		return Il2CppSystem.String.Format("AccessibilityNode(ID: {0}, Label: {1})", (Il2CppSystem.Object)(object)id, label);
	}
}
