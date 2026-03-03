using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem;

public class Keyboard : InputDevice
{
	private static readonly System.IntPtr NativeFieldInfoPtr_KeyCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_ExtendedKeyCount;

	private static readonly System.IntPtr NativeFieldInfoPtr__anyKey_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__shiftKey_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__ctrlKey_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__altKey_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__imeSelected_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__current_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_TextInputListeners;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_KeyboardLayoutName;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Keys;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ImeCompositionListeners;

	private static readonly System.IntPtr NativeMethodInfoPtr_add_onTextInput_Public_add_Void_Action_1_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_remove_onTextInput_Public_rem_Void_Action_1_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_add_onIMECompositionChange_Public_add_Void_Action_1_IMECompositionString_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_remove_onIMECompositionChange_Public_rem_Void_Action_1_IMECompositionString_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetIMEEnabled_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetIMECursorPosition_Public_Void_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_keyboardLayout_Public_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_keyboardLayout_Protected_set_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_anyKey_Public_get_AnyKeyControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_anyKey_Protected_set_Void_AnyKeyControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_spaceKey_Public_get_KeyControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_enterKey_Public_get_KeyControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_tabKey_Public_get_KeyControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_backquoteKey_Public_get_KeyControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_quoteKey_Public_get_KeyControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_semicolonKey_Public_get_KeyControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_commaKey_Public_get_KeyControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_periodKey_Public_get_KeyControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_slashKey_Public_get_KeyControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_backslashKey_Public_get_KeyControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_leftBracketKey_Public_get_KeyControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_rightBracketKey_Public_get_KeyControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_minusKey_Public_get_KeyControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_equalsKey_Public_get_KeyControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_aKey_Public_get_KeyControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_bKey_Public_get_KeyControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_cKey_Public_get_KeyControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_dKey_Public_get_KeyControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_eKey_Public_get_KeyControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_fKey_Public_get_KeyControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_gKey_Public_get_KeyControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_hKey_Public_get_KeyControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_iKey_Public_get_KeyControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_jKey_Public_get_KeyControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_kKey_Public_get_KeyControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_lKey_Public_get_KeyControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_mKey_Public_get_KeyControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_nKey_Public_get_KeyControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_oKey_Public_get_KeyControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_pKey_Public_get_KeyControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_qKey_Public_get_KeyControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_rKey_Public_get_KeyControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_sKey_Public_get_KeyControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_tKey_Public_get_KeyControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_uKey_Public_get_KeyControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_vKey_Public_get_KeyControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_wKey_Public_get_KeyControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_xKey_Public_get_KeyControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_yKey_Public_get_KeyControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_zKey_Public_get_KeyControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_digit1Key_Public_get_KeyControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_digit2Key_Public_get_KeyControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_digit3Key_Public_get_KeyControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_digit4Key_Public_get_KeyControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_digit5Key_Public_get_KeyControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_digit6Key_Public_get_KeyControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_digit7Key_Public_get_KeyControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_digit8Key_Public_get_KeyControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_digit9Key_Public_get_KeyControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_digit0Key_Public_get_KeyControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_leftShiftKey_Public_get_KeyControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_rightShiftKey_Public_get_KeyControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_leftAltKey_Public_get_KeyControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_rightAltKey_Public_get_KeyControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_leftCtrlKey_Public_get_KeyControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_rightCtrlKey_Public_get_KeyControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_leftMetaKey_Public_get_KeyControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_rightMetaKey_Public_get_KeyControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_leftWindowsKey_Public_get_KeyControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_rightWindowsKey_Public_get_KeyControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_leftAppleKey_Public_get_KeyControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_rightAppleKey_Public_get_KeyControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_leftCommandKey_Public_get_KeyControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_rightCommandKey_Public_get_KeyControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_contextMenuKey_Public_get_KeyControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_escapeKey_Public_get_KeyControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_leftArrowKey_Public_get_KeyControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_rightArrowKey_Public_get_KeyControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_upArrowKey_Public_get_KeyControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_downArrowKey_Public_get_KeyControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_backspaceKey_Public_get_KeyControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_pageDownKey_Public_get_KeyControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_pageUpKey_Public_get_KeyControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_homeKey_Public_get_KeyControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_endKey_Public_get_KeyControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_insertKey_Public_get_KeyControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_deleteKey_Public_get_KeyControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_capsLockKey_Public_get_KeyControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_scrollLockKey_Public_get_KeyControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_numLockKey_Public_get_KeyControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_printScreenKey_Public_get_KeyControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_pauseKey_Public_get_KeyControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_numpadEnterKey_Public_get_KeyControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_numpadDivideKey_Public_get_KeyControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_numpadMultiplyKey_Public_get_KeyControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_numpadMinusKey_Public_get_KeyControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_numpadPlusKey_Public_get_KeyControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_numpadPeriodKey_Public_get_KeyControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_numpadEqualsKey_Public_get_KeyControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_numpad0Key_Public_get_KeyControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_numpad1Key_Public_get_KeyControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_numpad2Key_Public_get_KeyControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_numpad3Key_Public_get_KeyControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_numpad4Key_Public_get_KeyControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_numpad5Key_Public_get_KeyControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_numpad6Key_Public_get_KeyControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_numpad7Key_Public_get_KeyControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_numpad8Key_Public_get_KeyControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_numpad9Key_Public_get_KeyControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_f1Key_Public_get_KeyControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_f2Key_Public_get_KeyControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_f3Key_Public_get_KeyControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_f4Key_Public_get_KeyControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_f5Key_Public_get_KeyControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_f6Key_Public_get_KeyControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_f7Key_Public_get_KeyControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_f8Key_Public_get_KeyControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_f9Key_Public_get_KeyControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_f10Key_Public_get_KeyControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_f11Key_Public_get_KeyControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_f12Key_Public_get_KeyControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_oem1Key_Public_get_KeyControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_oem2Key_Public_get_KeyControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_oem3Key_Public_get_KeyControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_oem4Key_Public_get_KeyControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_oem5Key_Public_get_KeyControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_f13Key_Public_get_KeyControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_f14Key_Public_get_KeyControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_f15Key_Public_get_KeyControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_f16Key_Public_get_KeyControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_f17Key_Public_get_KeyControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_f18Key_Public_get_KeyControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_f19Key_Public_get_KeyControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_f20Key_Public_get_KeyControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_f21Key_Public_get_KeyControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_f22Key_Public_get_KeyControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_f23Key_Public_get_KeyControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_f24Key_Public_get_KeyControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_shiftKey_Public_get_ButtonControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_shiftKey_Protected_set_Void_ButtonControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_ctrlKey_Public_get_ButtonControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_ctrlKey_Protected_set_Void_ButtonControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_altKey_Public_get_ButtonControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_altKey_Protected_set_Void_ButtonControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_imeSelected_Public_get_ButtonControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_imeSelected_Protected_set_Void_ButtonControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Item_Public_get_KeyControl_Key_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_allKeys_Public_get_ReadOnlyArray_1_KeyControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_current_Public_Static_get_Keyboard_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_current_Private_Static_set_Void_Keyboard_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MakeCurrent_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnRemoved_Protected_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FinishSetup_Protected_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RefreshConfiguration_Protected_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnTextInput_Public_Virtual_Final_New_Void_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindKeyOnCurrentKeyboardLayout_Public_KeyControl_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnIMECompositionChanged_Public_Virtual_Final_New_Void_IMECompositionString_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnityEngine_InputSystem_LowLevel_IEventPreProcessor_PreProcessEvent_Private_Virtual_Final_New_Boolean_InputEventPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_keys_Protected_get_Il2CppReferenceArray_1_KeyControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_keys_Protected_set_Void_Il2CppReferenceArray_1_KeyControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static int KeyCount
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_KeyCount, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_KeyCount, (void*)(&value));
		}
	}

	public unsafe static int ExtendedKeyCount
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ExtendedKeyCount, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ExtendedKeyCount, (void*)(&value));
		}
	}

	public unsafe AnyKeyControl _anyKey_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__anyKey_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AnyKeyControl>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__anyKey_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe ButtonControl _shiftKey_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__shiftKey_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ButtonControl>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__shiftKey_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe ButtonControl _ctrlKey_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ctrlKey_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ButtonControl>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ctrlKey_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe ButtonControl _altKey_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__altKey_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ButtonControl>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__altKey_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe ButtonControl _imeSelected_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__imeSelected_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ButtonControl>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__imeSelected_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Keyboard _current_k__BackingField
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__current_k__BackingField, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Keyboard>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__current_k__BackingField, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe InlinedArray<Il2CppSystem.Action<char>> m_TextInputListeners
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TextInputListeners);
			return new InlinedArray<Il2CppSystem.Action<char>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InlinedArray<Il2CppSystem.Action<char>>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TextInputListeners), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<InlinedArray<Il2CppSystem.Action<char>>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe string m_KeyboardLayoutName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_KeyboardLayoutName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_KeyboardLayoutName)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe Il2CppReferenceArray<KeyControl> m_Keys
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Keys);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<KeyControl>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Keys)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe InlinedArray<Il2CppSystem.Action<IMECompositionString>> m_ImeCompositionListeners
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ImeCompositionListeners);
			return new InlinedArray<Il2CppSystem.Action<IMECompositionString>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InlinedArray<Il2CppSystem.Action<IMECompositionString>>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ImeCompositionListeners), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<InlinedArray<Il2CppSystem.Action<IMECompositionString>>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe string keyboardLayout
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976916, XrefRangeEnd = 976917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_keyboardLayout_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_keyboardLayout_Protected_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe AnyKeyControl anyKey
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 392549, RefRangeEnd = 392550, XrefRangeStart = 392549, XrefRangeEnd = 392550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_anyKey_Public_get_AnyKeyControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<AnyKeyControl>(intPtr2) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_anyKey_Protected_set_Void_AnyKeyControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe KeyControl spaceKey
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976917, XrefRangeEnd = 976918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_spaceKey_Public_get_KeyControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<KeyControl>(intPtr2) : null;
		}
	}

	public unsafe KeyControl enterKey
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976918, XrefRangeEnd = 976919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_enterKey_Public_get_KeyControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<KeyControl>(intPtr2) : null;
		}
	}

	public unsafe KeyControl tabKey
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976919, XrefRangeEnd = 976920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_tabKey_Public_get_KeyControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<KeyControl>(intPtr2) : null;
		}
	}

	public unsafe KeyControl backquoteKey
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976920, XrefRangeEnd = 976921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_backquoteKey_Public_get_KeyControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<KeyControl>(intPtr2) : null;
		}
	}

	public unsafe KeyControl quoteKey
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976921, XrefRangeEnd = 976922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_quoteKey_Public_get_KeyControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<KeyControl>(intPtr2) : null;
		}
	}

	public unsafe KeyControl semicolonKey
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976922, XrefRangeEnd = 976923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_semicolonKey_Public_get_KeyControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<KeyControl>(intPtr2) : null;
		}
	}

	public unsafe KeyControl commaKey
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976923, XrefRangeEnd = 976924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_commaKey_Public_get_KeyControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<KeyControl>(intPtr2) : null;
		}
	}

	public unsafe KeyControl periodKey
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976924, XrefRangeEnd = 976925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_periodKey_Public_get_KeyControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<KeyControl>(intPtr2) : null;
		}
	}

	public unsafe KeyControl slashKey
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976925, XrefRangeEnd = 976926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_slashKey_Public_get_KeyControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<KeyControl>(intPtr2) : null;
		}
	}

	public unsafe KeyControl backslashKey
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976926, XrefRangeEnd = 976927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_backslashKey_Public_get_KeyControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<KeyControl>(intPtr2) : null;
		}
	}

	public unsafe KeyControl leftBracketKey
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976927, XrefRangeEnd = 976928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_leftBracketKey_Public_get_KeyControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<KeyControl>(intPtr2) : null;
		}
	}

	public unsafe KeyControl rightBracketKey
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976928, XrefRangeEnd = 976929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_rightBracketKey_Public_get_KeyControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<KeyControl>(intPtr2) : null;
		}
	}

	public unsafe KeyControl minusKey
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976929, XrefRangeEnd = 976930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_minusKey_Public_get_KeyControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<KeyControl>(intPtr2) : null;
		}
	}

	public unsafe KeyControl equalsKey
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976930, XrefRangeEnd = 976931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_equalsKey_Public_get_KeyControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<KeyControl>(intPtr2) : null;
		}
	}

	public unsafe KeyControl aKey
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976931, XrefRangeEnd = 976932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_aKey_Public_get_KeyControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<KeyControl>(intPtr2) : null;
		}
	}

	public unsafe KeyControl bKey
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976932, XrefRangeEnd = 976933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_bKey_Public_get_KeyControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<KeyControl>(intPtr2) : null;
		}
	}

	public unsafe KeyControl cKey
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976933, XrefRangeEnd = 976934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_cKey_Public_get_KeyControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<KeyControl>(intPtr2) : null;
		}
	}

	public unsafe KeyControl dKey
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976934, XrefRangeEnd = 976935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_dKey_Public_get_KeyControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<KeyControl>(intPtr2) : null;
		}
	}

	public unsafe KeyControl eKey
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976935, XrefRangeEnd = 976936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_eKey_Public_get_KeyControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<KeyControl>(intPtr2) : null;
		}
	}

	public unsafe KeyControl fKey
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976936, XrefRangeEnd = 976937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_fKey_Public_get_KeyControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<KeyControl>(intPtr2) : null;
		}
	}

	public unsafe KeyControl gKey
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976937, XrefRangeEnd = 976938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_gKey_Public_get_KeyControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<KeyControl>(intPtr2) : null;
		}
	}

	public unsafe KeyControl hKey
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976938, XrefRangeEnd = 976939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_hKey_Public_get_KeyControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<KeyControl>(intPtr2) : null;
		}
	}

	public unsafe KeyControl iKey
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976939, XrefRangeEnd = 976940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_iKey_Public_get_KeyControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<KeyControl>(intPtr2) : null;
		}
	}

	public unsafe KeyControl jKey
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976940, XrefRangeEnd = 976941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_jKey_Public_get_KeyControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<KeyControl>(intPtr2) : null;
		}
	}

	public unsafe KeyControl kKey
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976941, XrefRangeEnd = 976942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_kKey_Public_get_KeyControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<KeyControl>(intPtr2) : null;
		}
	}

	public unsafe KeyControl lKey
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976942, XrefRangeEnd = 976943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_lKey_Public_get_KeyControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<KeyControl>(intPtr2) : null;
		}
	}

	public unsafe KeyControl mKey
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976943, XrefRangeEnd = 976944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_mKey_Public_get_KeyControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<KeyControl>(intPtr2) : null;
		}
	}

	public unsafe KeyControl nKey
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976944, XrefRangeEnd = 976945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_nKey_Public_get_KeyControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<KeyControl>(intPtr2) : null;
		}
	}

	public unsafe KeyControl oKey
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976945, XrefRangeEnd = 976946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_oKey_Public_get_KeyControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<KeyControl>(intPtr2) : null;
		}
	}

	public unsafe KeyControl pKey
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976946, XrefRangeEnd = 976947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_pKey_Public_get_KeyControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<KeyControl>(intPtr2) : null;
		}
	}

	public unsafe KeyControl qKey
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976947, XrefRangeEnd = 976948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_qKey_Public_get_KeyControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<KeyControl>(intPtr2) : null;
		}
	}

	public unsafe KeyControl rKey
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976948, XrefRangeEnd = 976949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_rKey_Public_get_KeyControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<KeyControl>(intPtr2) : null;
		}
	}

	public unsafe KeyControl sKey
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976949, XrefRangeEnd = 976950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_sKey_Public_get_KeyControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<KeyControl>(intPtr2) : null;
		}
	}

	public unsafe KeyControl tKey
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976950, XrefRangeEnd = 976951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_tKey_Public_get_KeyControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<KeyControl>(intPtr2) : null;
		}
	}

	public unsafe KeyControl uKey
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976951, XrefRangeEnd = 976952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_uKey_Public_get_KeyControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<KeyControl>(intPtr2) : null;
		}
	}

	public unsafe KeyControl vKey
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976952, XrefRangeEnd = 976953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_vKey_Public_get_KeyControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<KeyControl>(intPtr2) : null;
		}
	}

	public unsafe KeyControl wKey
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976953, XrefRangeEnd = 976954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_wKey_Public_get_KeyControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<KeyControl>(intPtr2) : null;
		}
	}

	public unsafe KeyControl xKey
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976954, XrefRangeEnd = 976955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_xKey_Public_get_KeyControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<KeyControl>(intPtr2) : null;
		}
	}

	public unsafe KeyControl yKey
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976955, XrefRangeEnd = 976956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_yKey_Public_get_KeyControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<KeyControl>(intPtr2) : null;
		}
	}

	public unsafe KeyControl zKey
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976956, XrefRangeEnd = 976957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_zKey_Public_get_KeyControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<KeyControl>(intPtr2) : null;
		}
	}

	public unsafe KeyControl digit1Key
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976957, XrefRangeEnd = 976958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_digit1Key_Public_get_KeyControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<KeyControl>(intPtr2) : null;
		}
	}

	public unsafe KeyControl digit2Key
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976958, XrefRangeEnd = 976959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_digit2Key_Public_get_KeyControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<KeyControl>(intPtr2) : null;
		}
	}

	public unsafe KeyControl digit3Key
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976959, XrefRangeEnd = 976960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_digit3Key_Public_get_KeyControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<KeyControl>(intPtr2) : null;
		}
	}

	public unsafe KeyControl digit4Key
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976960, XrefRangeEnd = 976961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_digit4Key_Public_get_KeyControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<KeyControl>(intPtr2) : null;
		}
	}

	public unsafe KeyControl digit5Key
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976961, XrefRangeEnd = 976962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_digit5Key_Public_get_KeyControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<KeyControl>(intPtr2) : null;
		}
	}

	public unsafe KeyControl digit6Key
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976962, XrefRangeEnd = 976963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_digit6Key_Public_get_KeyControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<KeyControl>(intPtr2) : null;
		}
	}

	public unsafe KeyControl digit7Key
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976963, XrefRangeEnd = 976964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_digit7Key_Public_get_KeyControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<KeyControl>(intPtr2) : null;
		}
	}

	public unsafe KeyControl digit8Key
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976964, XrefRangeEnd = 976965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_digit8Key_Public_get_KeyControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<KeyControl>(intPtr2) : null;
		}
	}

	public unsafe KeyControl digit9Key
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976965, XrefRangeEnd = 976966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_digit9Key_Public_get_KeyControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<KeyControl>(intPtr2) : null;
		}
	}

	public unsafe KeyControl digit0Key
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976966, XrefRangeEnd = 976967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_digit0Key_Public_get_KeyControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<KeyControl>(intPtr2) : null;
		}
	}

	public unsafe KeyControl leftShiftKey
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 976968, RefRangeEnd = 976969, XrefRangeStart = 976967, XrefRangeEnd = 976968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_leftShiftKey_Public_get_KeyControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<KeyControl>(intPtr2) : null;
		}
	}

	public unsafe KeyControl rightShiftKey
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976969, XrefRangeEnd = 976970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_rightShiftKey_Public_get_KeyControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<KeyControl>(intPtr2) : null;
		}
	}

	public unsafe KeyControl leftAltKey
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976970, XrefRangeEnd = 976971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_leftAltKey_Public_get_KeyControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<KeyControl>(intPtr2) : null;
		}
	}

	public unsafe KeyControl rightAltKey
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976971, XrefRangeEnd = 976972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_rightAltKey_Public_get_KeyControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<KeyControl>(intPtr2) : null;
		}
	}

	public unsafe KeyControl leftCtrlKey
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976972, XrefRangeEnd = 976973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_leftCtrlKey_Public_get_KeyControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<KeyControl>(intPtr2) : null;
		}
	}

	public unsafe KeyControl rightCtrlKey
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976973, XrefRangeEnd = 976974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_rightCtrlKey_Public_get_KeyControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<KeyControl>(intPtr2) : null;
		}
	}

	public unsafe KeyControl leftMetaKey
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976974, XrefRangeEnd = 976975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_leftMetaKey_Public_get_KeyControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<KeyControl>(intPtr2) : null;
		}
	}

	public unsafe KeyControl rightMetaKey
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976975, XrefRangeEnd = 976976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_rightMetaKey_Public_get_KeyControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<KeyControl>(intPtr2) : null;
		}
	}

	public unsafe KeyControl leftWindowsKey
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_leftWindowsKey_Public_get_KeyControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<KeyControl>(intPtr2) : null;
		}
	}

	public unsafe KeyControl rightWindowsKey
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_rightWindowsKey_Public_get_KeyControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<KeyControl>(intPtr2) : null;
		}
	}

	public unsafe KeyControl leftAppleKey
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_leftAppleKey_Public_get_KeyControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<KeyControl>(intPtr2) : null;
		}
	}

	public unsafe KeyControl rightAppleKey
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_rightAppleKey_Public_get_KeyControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<KeyControl>(intPtr2) : null;
		}
	}

	public unsafe KeyControl leftCommandKey
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_leftCommandKey_Public_get_KeyControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<KeyControl>(intPtr2) : null;
		}
	}

	public unsafe KeyControl rightCommandKey
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_rightCommandKey_Public_get_KeyControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<KeyControl>(intPtr2) : null;
		}
	}

	public unsafe KeyControl contextMenuKey
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976976, XrefRangeEnd = 976977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_contextMenuKey_Public_get_KeyControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<KeyControl>(intPtr2) : null;
		}
	}

	public unsafe KeyControl escapeKey
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976977, XrefRangeEnd = 976978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_escapeKey_Public_get_KeyControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<KeyControl>(intPtr2) : null;
		}
	}

	public unsafe KeyControl leftArrowKey
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976978, XrefRangeEnd = 976979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_leftArrowKey_Public_get_KeyControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<KeyControl>(intPtr2) : null;
		}
	}

	public unsafe KeyControl rightArrowKey
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976979, XrefRangeEnd = 976980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_rightArrowKey_Public_get_KeyControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<KeyControl>(intPtr2) : null;
		}
	}

	public unsafe KeyControl upArrowKey
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976980, XrefRangeEnd = 976981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_upArrowKey_Public_get_KeyControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<KeyControl>(intPtr2) : null;
		}
	}

	public unsafe KeyControl downArrowKey
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976981, XrefRangeEnd = 976982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_downArrowKey_Public_get_KeyControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<KeyControl>(intPtr2) : null;
		}
	}

	public unsafe KeyControl backspaceKey
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976982, XrefRangeEnd = 976983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_backspaceKey_Public_get_KeyControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<KeyControl>(intPtr2) : null;
		}
	}

	public unsafe KeyControl pageDownKey
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976983, XrefRangeEnd = 976984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_pageDownKey_Public_get_KeyControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<KeyControl>(intPtr2) : null;
		}
	}

	public unsafe KeyControl pageUpKey
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976984, XrefRangeEnd = 976985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_pageUpKey_Public_get_KeyControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<KeyControl>(intPtr2) : null;
		}
	}

	public unsafe KeyControl homeKey
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976985, XrefRangeEnd = 976986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_homeKey_Public_get_KeyControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<KeyControl>(intPtr2) : null;
		}
	}

	public unsafe KeyControl endKey
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976986, XrefRangeEnd = 976987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_endKey_Public_get_KeyControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<KeyControl>(intPtr2) : null;
		}
	}

	public unsafe KeyControl insertKey
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976987, XrefRangeEnd = 976988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_insertKey_Public_get_KeyControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<KeyControl>(intPtr2) : null;
		}
	}

	public unsafe KeyControl deleteKey
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976988, XrefRangeEnd = 976989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_deleteKey_Public_get_KeyControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<KeyControl>(intPtr2) : null;
		}
	}

	public unsafe KeyControl capsLockKey
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976989, XrefRangeEnd = 976990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_capsLockKey_Public_get_KeyControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<KeyControl>(intPtr2) : null;
		}
	}

	public unsafe KeyControl scrollLockKey
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976990, XrefRangeEnd = 976991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_scrollLockKey_Public_get_KeyControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<KeyControl>(intPtr2) : null;
		}
	}

	public unsafe KeyControl numLockKey
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976991, XrefRangeEnd = 976992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_numLockKey_Public_get_KeyControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<KeyControl>(intPtr2) : null;
		}
	}

	public unsafe KeyControl printScreenKey
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976992, XrefRangeEnd = 976993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_printScreenKey_Public_get_KeyControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<KeyControl>(intPtr2) : null;
		}
	}

	public unsafe KeyControl pauseKey
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976993, XrefRangeEnd = 976994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_pauseKey_Public_get_KeyControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<KeyControl>(intPtr2) : null;
		}
	}

	public unsafe KeyControl numpadEnterKey
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976994, XrefRangeEnd = 976995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_numpadEnterKey_Public_get_KeyControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<KeyControl>(intPtr2) : null;
		}
	}

	public unsafe KeyControl numpadDivideKey
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976995, XrefRangeEnd = 976996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_numpadDivideKey_Public_get_KeyControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<KeyControl>(intPtr2) : null;
		}
	}

	public unsafe KeyControl numpadMultiplyKey
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976996, XrefRangeEnd = 976997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_numpadMultiplyKey_Public_get_KeyControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<KeyControl>(intPtr2) : null;
		}
	}

	public unsafe KeyControl numpadMinusKey
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976997, XrefRangeEnd = 976998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_numpadMinusKey_Public_get_KeyControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<KeyControl>(intPtr2) : null;
		}
	}

	public unsafe KeyControl numpadPlusKey
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976998, XrefRangeEnd = 976999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_numpadPlusKey_Public_get_KeyControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<KeyControl>(intPtr2) : null;
		}
	}

	public unsafe KeyControl numpadPeriodKey
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976999, XrefRangeEnd = 977000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_numpadPeriodKey_Public_get_KeyControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<KeyControl>(intPtr2) : null;
		}
	}

	public unsafe KeyControl numpadEqualsKey
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 977000, XrefRangeEnd = 977001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_numpadEqualsKey_Public_get_KeyControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<KeyControl>(intPtr2) : null;
		}
	}

	public unsafe KeyControl numpad0Key
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 977001, XrefRangeEnd = 977002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_numpad0Key_Public_get_KeyControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<KeyControl>(intPtr2) : null;
		}
	}

	public unsafe KeyControl numpad1Key
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 977002, XrefRangeEnd = 977003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_numpad1Key_Public_get_KeyControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<KeyControl>(intPtr2) : null;
		}
	}

	public unsafe KeyControl numpad2Key
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 977003, XrefRangeEnd = 977004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_numpad2Key_Public_get_KeyControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<KeyControl>(intPtr2) : null;
		}
	}

	public unsafe KeyControl numpad3Key
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 977004, XrefRangeEnd = 977005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_numpad3Key_Public_get_KeyControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<KeyControl>(intPtr2) : null;
		}
	}

	public unsafe KeyControl numpad4Key
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 977005, XrefRangeEnd = 977006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_numpad4Key_Public_get_KeyControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<KeyControl>(intPtr2) : null;
		}
	}

	public unsafe KeyControl numpad5Key
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 977006, XrefRangeEnd = 977007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_numpad5Key_Public_get_KeyControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<KeyControl>(intPtr2) : null;
		}
	}

	public unsafe KeyControl numpad6Key
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 977007, XrefRangeEnd = 977008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_numpad6Key_Public_get_KeyControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<KeyControl>(intPtr2) : null;
		}
	}

	public unsafe KeyControl numpad7Key
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 977008, XrefRangeEnd = 977009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_numpad7Key_Public_get_KeyControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<KeyControl>(intPtr2) : null;
		}
	}

	public unsafe KeyControl numpad8Key
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 977009, XrefRangeEnd = 977010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_numpad8Key_Public_get_KeyControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<KeyControl>(intPtr2) : null;
		}
	}

	public unsafe KeyControl numpad9Key
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 977010, XrefRangeEnd = 977011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_numpad9Key_Public_get_KeyControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<KeyControl>(intPtr2) : null;
		}
	}

	public unsafe KeyControl f1Key
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 977011, XrefRangeEnd = 977012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_f1Key_Public_get_KeyControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<KeyControl>(intPtr2) : null;
		}
	}

	public unsafe KeyControl f2Key
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 977012, XrefRangeEnd = 977013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_f2Key_Public_get_KeyControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<KeyControl>(intPtr2) : null;
		}
	}

	public unsafe KeyControl f3Key
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 977013, XrefRangeEnd = 977014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_f3Key_Public_get_KeyControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<KeyControl>(intPtr2) : null;
		}
	}

	public unsafe KeyControl f4Key
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 977014, XrefRangeEnd = 977015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_f4Key_Public_get_KeyControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<KeyControl>(intPtr2) : null;
		}
	}

	public unsafe KeyControl f5Key
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 977015, XrefRangeEnd = 977016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_f5Key_Public_get_KeyControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<KeyControl>(intPtr2) : null;
		}
	}

	public unsafe KeyControl f6Key
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 977016, XrefRangeEnd = 977017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_f6Key_Public_get_KeyControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<KeyControl>(intPtr2) : null;
		}
	}

	public unsafe KeyControl f7Key
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 977017, XrefRangeEnd = 977018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_f7Key_Public_get_KeyControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<KeyControl>(intPtr2) : null;
		}
	}

	public unsafe KeyControl f8Key
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 977018, XrefRangeEnd = 977019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_f8Key_Public_get_KeyControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<KeyControl>(intPtr2) : null;
		}
	}

	public unsafe KeyControl f9Key
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 977019, XrefRangeEnd = 977020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_f9Key_Public_get_KeyControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<KeyControl>(intPtr2) : null;
		}
	}

	public unsafe KeyControl f10Key
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 977020, XrefRangeEnd = 977021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_f10Key_Public_get_KeyControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<KeyControl>(intPtr2) : null;
		}
	}

	public unsafe KeyControl f11Key
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 977021, XrefRangeEnd = 977022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_f11Key_Public_get_KeyControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<KeyControl>(intPtr2) : null;
		}
	}

	public unsafe KeyControl f12Key
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 977022, XrefRangeEnd = 977023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_f12Key_Public_get_KeyControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<KeyControl>(intPtr2) : null;
		}
	}

	public unsafe KeyControl oem1Key
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 977023, XrefRangeEnd = 977024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_oem1Key_Public_get_KeyControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<KeyControl>(intPtr2) : null;
		}
	}

	public unsafe KeyControl oem2Key
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 977024, XrefRangeEnd = 977025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_oem2Key_Public_get_KeyControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<KeyControl>(intPtr2) : null;
		}
	}

	public unsafe KeyControl oem3Key
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 977025, XrefRangeEnd = 977026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_oem3Key_Public_get_KeyControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<KeyControl>(intPtr2) : null;
		}
	}

	public unsafe KeyControl oem4Key
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 977026, XrefRangeEnd = 977027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_oem4Key_Public_get_KeyControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<KeyControl>(intPtr2) : null;
		}
	}

	public unsafe KeyControl oem5Key
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 977027, XrefRangeEnd = 977028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_oem5Key_Public_get_KeyControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<KeyControl>(intPtr2) : null;
		}
	}

	public unsafe KeyControl f13Key
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 977028, XrefRangeEnd = 977029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_f13Key_Public_get_KeyControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<KeyControl>(intPtr2) : null;
		}
	}

	public unsafe KeyControl f14Key
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 977029, XrefRangeEnd = 977030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_f14Key_Public_get_KeyControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<KeyControl>(intPtr2) : null;
		}
	}

	public unsafe KeyControl f15Key
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 977030, XrefRangeEnd = 977031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_f15Key_Public_get_KeyControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<KeyControl>(intPtr2) : null;
		}
	}

	public unsafe KeyControl f16Key
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 977031, XrefRangeEnd = 977032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_f16Key_Public_get_KeyControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<KeyControl>(intPtr2) : null;
		}
	}

	public unsafe KeyControl f17Key
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 977032, XrefRangeEnd = 977033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_f17Key_Public_get_KeyControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<KeyControl>(intPtr2) : null;
		}
	}

	public unsafe KeyControl f18Key
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 977033, XrefRangeEnd = 977034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_f18Key_Public_get_KeyControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<KeyControl>(intPtr2) : null;
		}
	}

	public unsafe KeyControl f19Key
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 977034, XrefRangeEnd = 977035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_f19Key_Public_get_KeyControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<KeyControl>(intPtr2) : null;
		}
	}

	public unsafe KeyControl f20Key
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 977035, XrefRangeEnd = 977036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_f20Key_Public_get_KeyControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<KeyControl>(intPtr2) : null;
		}
	}

	public unsafe KeyControl f21Key
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 977036, XrefRangeEnd = 977037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_f21Key_Public_get_KeyControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<KeyControl>(intPtr2) : null;
		}
	}

	public unsafe KeyControl f22Key
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 977037, XrefRangeEnd = 977038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_f22Key_Public_get_KeyControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<KeyControl>(intPtr2) : null;
		}
	}

	public unsafe KeyControl f23Key
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 977038, XrefRangeEnd = 977039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_f23Key_Public_get_KeyControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<KeyControl>(intPtr2) : null;
		}
	}

	public unsafe KeyControl f24Key
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 977039, XrefRangeEnd = 977040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_f24Key_Public_get_KeyControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<KeyControl>(intPtr2) : null;
		}
	}

	public unsafe ButtonControl shiftKey
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 392551, RefRangeEnd = 392553, XrefRangeStart = 392551, XrefRangeEnd = 392553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_shiftKey_Public_get_ButtonControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ButtonControl>(intPtr2) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_shiftKey_Protected_set_Void_ButtonControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe ButtonControl ctrlKey
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ctrlKey_Public_get_ButtonControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ButtonControl>(intPtr2) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_ctrlKey_Protected_set_Void_ButtonControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe ButtonControl altKey
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_altKey_Public_get_ButtonControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ButtonControl>(intPtr2) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_altKey_Protected_set_Void_ButtonControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe ButtonControl imeSelected
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_imeSelected_Public_get_ButtonControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ButtonControl>(intPtr2) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_imeSelected_Protected_set_Void_ButtonControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe KeyControl this[Key key]
	{
		[CallerCount(128)]
		[CachedScanResults(RefRangeStart = 977040, RefRangeEnd = 977168, XrefRangeStart = 977040, XrefRangeEnd = 977040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&key);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Item_Public_get_KeyControl_Key_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<KeyControl>(intPtr2) : null;
		}
	}

	public unsafe ReadOnlyArray<KeyControl> allKeys
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 977168, XrefRangeEnd = 977171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_allKeys_Public_get_ReadOnlyArray_1_KeyControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new ReadOnlyArray<KeyControl>(pointer);
		}
	}

	public unsafe static Keyboard current
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 977171, XrefRangeEnd = 977173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_current_Public_Static_get_Keyboard_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Keyboard>(intPtr2) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 977173, XrefRangeEnd = 977177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_current_Private_Static_set_Void_Keyboard_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe Il2CppReferenceArray<KeyControl> keys
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_keys_Protected_get_Il2CppReferenceArray_1_KeyControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<KeyControl>>(intPtr2) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_keys_Protected_set_Void_Il2CppReferenceArray_1_KeyControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	static Keyboard()
	{
		Il2CppClassPointerStore<Keyboard>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.InputSystem.dll", "UnityEngine.InputSystem", "Keyboard");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Keyboard>.NativeClassPtr);
		NativeFieldInfoPtr_KeyCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, "KeyCount");
		NativeFieldInfoPtr_ExtendedKeyCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, "ExtendedKeyCount");
		NativeFieldInfoPtr__anyKey_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, "<anyKey>k__BackingField");
		NativeFieldInfoPtr__shiftKey_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, "<shiftKey>k__BackingField");
		NativeFieldInfoPtr__ctrlKey_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, "<ctrlKey>k__BackingField");
		NativeFieldInfoPtr__altKey_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, "<altKey>k__BackingField");
		NativeFieldInfoPtr__imeSelected_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, "<imeSelected>k__BackingField");
		NativeFieldInfoPtr__current_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, "<current>k__BackingField");
		NativeFieldInfoPtr_m_TextInputListeners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, "m_TextInputListeners");
		NativeFieldInfoPtr_m_KeyboardLayoutName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, "m_KeyboardLayoutName");
		NativeFieldInfoPtr_m_Keys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, "m_Keys");
		NativeFieldInfoPtr_m_ImeCompositionListeners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, "m_ImeCompositionListeners");
		NativeMethodInfoPtr_add_onTextInput_Public_add_Void_Action_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665022);
		NativeMethodInfoPtr_remove_onTextInput_Public_rem_Void_Action_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665023);
		NativeMethodInfoPtr_add_onIMECompositionChange_Public_add_Void_Action_1_IMECompositionString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665024);
		NativeMethodInfoPtr_remove_onIMECompositionChange_Public_rem_Void_Action_1_IMECompositionString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665025);
		NativeMethodInfoPtr_SetIMEEnabled_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665026);
		NativeMethodInfoPtr_SetIMECursorPosition_Public_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665027);
		NativeMethodInfoPtr_get_keyboardLayout_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665028);
		NativeMethodInfoPtr_set_keyboardLayout_Protected_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665029);
		NativeMethodInfoPtr_get_anyKey_Public_get_AnyKeyControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665030);
		NativeMethodInfoPtr_set_anyKey_Protected_set_Void_AnyKeyControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665031);
		NativeMethodInfoPtr_get_spaceKey_Public_get_KeyControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665032);
		NativeMethodInfoPtr_get_enterKey_Public_get_KeyControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665033);
		NativeMethodInfoPtr_get_tabKey_Public_get_KeyControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665034);
		NativeMethodInfoPtr_get_backquoteKey_Public_get_KeyControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665035);
		NativeMethodInfoPtr_get_quoteKey_Public_get_KeyControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665036);
		NativeMethodInfoPtr_get_semicolonKey_Public_get_KeyControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665037);
		NativeMethodInfoPtr_get_commaKey_Public_get_KeyControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665038);
		NativeMethodInfoPtr_get_periodKey_Public_get_KeyControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665039);
		NativeMethodInfoPtr_get_slashKey_Public_get_KeyControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665040);
		NativeMethodInfoPtr_get_backslashKey_Public_get_KeyControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665041);
		NativeMethodInfoPtr_get_leftBracketKey_Public_get_KeyControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665042);
		NativeMethodInfoPtr_get_rightBracketKey_Public_get_KeyControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665043);
		NativeMethodInfoPtr_get_minusKey_Public_get_KeyControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665044);
		NativeMethodInfoPtr_get_equalsKey_Public_get_KeyControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665045);
		NativeMethodInfoPtr_get_aKey_Public_get_KeyControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665046);
		NativeMethodInfoPtr_get_bKey_Public_get_KeyControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665047);
		NativeMethodInfoPtr_get_cKey_Public_get_KeyControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665048);
		NativeMethodInfoPtr_get_dKey_Public_get_KeyControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665049);
		NativeMethodInfoPtr_get_eKey_Public_get_KeyControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665050);
		NativeMethodInfoPtr_get_fKey_Public_get_KeyControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665051);
		NativeMethodInfoPtr_get_gKey_Public_get_KeyControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665052);
		NativeMethodInfoPtr_get_hKey_Public_get_KeyControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665053);
		NativeMethodInfoPtr_get_iKey_Public_get_KeyControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665054);
		NativeMethodInfoPtr_get_jKey_Public_get_KeyControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665055);
		NativeMethodInfoPtr_get_kKey_Public_get_KeyControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665056);
		NativeMethodInfoPtr_get_lKey_Public_get_KeyControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665057);
		NativeMethodInfoPtr_get_mKey_Public_get_KeyControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665058);
		NativeMethodInfoPtr_get_nKey_Public_get_KeyControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665059);
		NativeMethodInfoPtr_get_oKey_Public_get_KeyControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665060);
		NativeMethodInfoPtr_get_pKey_Public_get_KeyControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665061);
		NativeMethodInfoPtr_get_qKey_Public_get_KeyControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665062);
		NativeMethodInfoPtr_get_rKey_Public_get_KeyControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665063);
		NativeMethodInfoPtr_get_sKey_Public_get_KeyControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665064);
		NativeMethodInfoPtr_get_tKey_Public_get_KeyControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665065);
		NativeMethodInfoPtr_get_uKey_Public_get_KeyControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665066);
		NativeMethodInfoPtr_get_vKey_Public_get_KeyControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665067);
		NativeMethodInfoPtr_get_wKey_Public_get_KeyControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665068);
		NativeMethodInfoPtr_get_xKey_Public_get_KeyControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665069);
		NativeMethodInfoPtr_get_yKey_Public_get_KeyControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665070);
		NativeMethodInfoPtr_get_zKey_Public_get_KeyControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665071);
		NativeMethodInfoPtr_get_digit1Key_Public_get_KeyControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665072);
		NativeMethodInfoPtr_get_digit2Key_Public_get_KeyControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665073);
		NativeMethodInfoPtr_get_digit3Key_Public_get_KeyControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665074);
		NativeMethodInfoPtr_get_digit4Key_Public_get_KeyControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665075);
		NativeMethodInfoPtr_get_digit5Key_Public_get_KeyControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665076);
		NativeMethodInfoPtr_get_digit6Key_Public_get_KeyControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665077);
		NativeMethodInfoPtr_get_digit7Key_Public_get_KeyControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665078);
		NativeMethodInfoPtr_get_digit8Key_Public_get_KeyControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665079);
		NativeMethodInfoPtr_get_digit9Key_Public_get_KeyControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665080);
		NativeMethodInfoPtr_get_digit0Key_Public_get_KeyControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665081);
		NativeMethodInfoPtr_get_leftShiftKey_Public_get_KeyControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665082);
		NativeMethodInfoPtr_get_rightShiftKey_Public_get_KeyControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665083);
		NativeMethodInfoPtr_get_leftAltKey_Public_get_KeyControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665084);
		NativeMethodInfoPtr_get_rightAltKey_Public_get_KeyControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665085);
		NativeMethodInfoPtr_get_leftCtrlKey_Public_get_KeyControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665086);
		NativeMethodInfoPtr_get_rightCtrlKey_Public_get_KeyControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665087);
		NativeMethodInfoPtr_get_leftMetaKey_Public_get_KeyControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665088);
		NativeMethodInfoPtr_get_rightMetaKey_Public_get_KeyControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665089);
		NativeMethodInfoPtr_get_leftWindowsKey_Public_get_KeyControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665090);
		NativeMethodInfoPtr_get_rightWindowsKey_Public_get_KeyControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665091);
		NativeMethodInfoPtr_get_leftAppleKey_Public_get_KeyControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665092);
		NativeMethodInfoPtr_get_rightAppleKey_Public_get_KeyControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665093);
		NativeMethodInfoPtr_get_leftCommandKey_Public_get_KeyControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665094);
		NativeMethodInfoPtr_get_rightCommandKey_Public_get_KeyControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665095);
		NativeMethodInfoPtr_get_contextMenuKey_Public_get_KeyControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665096);
		NativeMethodInfoPtr_get_escapeKey_Public_get_KeyControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665097);
		NativeMethodInfoPtr_get_leftArrowKey_Public_get_KeyControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665098);
		NativeMethodInfoPtr_get_rightArrowKey_Public_get_KeyControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665099);
		NativeMethodInfoPtr_get_upArrowKey_Public_get_KeyControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665100);
		NativeMethodInfoPtr_get_downArrowKey_Public_get_KeyControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665101);
		NativeMethodInfoPtr_get_backspaceKey_Public_get_KeyControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665102);
		NativeMethodInfoPtr_get_pageDownKey_Public_get_KeyControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665103);
		NativeMethodInfoPtr_get_pageUpKey_Public_get_KeyControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665104);
		NativeMethodInfoPtr_get_homeKey_Public_get_KeyControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665105);
		NativeMethodInfoPtr_get_endKey_Public_get_KeyControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665106);
		NativeMethodInfoPtr_get_insertKey_Public_get_KeyControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665107);
		NativeMethodInfoPtr_get_deleteKey_Public_get_KeyControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665108);
		NativeMethodInfoPtr_get_capsLockKey_Public_get_KeyControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665109);
		NativeMethodInfoPtr_get_scrollLockKey_Public_get_KeyControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665110);
		NativeMethodInfoPtr_get_numLockKey_Public_get_KeyControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665111);
		NativeMethodInfoPtr_get_printScreenKey_Public_get_KeyControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665112);
		NativeMethodInfoPtr_get_pauseKey_Public_get_KeyControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665113);
		NativeMethodInfoPtr_get_numpadEnterKey_Public_get_KeyControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665114);
		NativeMethodInfoPtr_get_numpadDivideKey_Public_get_KeyControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665115);
		NativeMethodInfoPtr_get_numpadMultiplyKey_Public_get_KeyControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665116);
		NativeMethodInfoPtr_get_numpadMinusKey_Public_get_KeyControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665117);
		NativeMethodInfoPtr_get_numpadPlusKey_Public_get_KeyControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665118);
		NativeMethodInfoPtr_get_numpadPeriodKey_Public_get_KeyControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665119);
		NativeMethodInfoPtr_get_numpadEqualsKey_Public_get_KeyControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665120);
		NativeMethodInfoPtr_get_numpad0Key_Public_get_KeyControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665121);
		NativeMethodInfoPtr_get_numpad1Key_Public_get_KeyControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665122);
		NativeMethodInfoPtr_get_numpad2Key_Public_get_KeyControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665123);
		NativeMethodInfoPtr_get_numpad3Key_Public_get_KeyControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665124);
		NativeMethodInfoPtr_get_numpad4Key_Public_get_KeyControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665125);
		NativeMethodInfoPtr_get_numpad5Key_Public_get_KeyControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665126);
		NativeMethodInfoPtr_get_numpad6Key_Public_get_KeyControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665127);
		NativeMethodInfoPtr_get_numpad7Key_Public_get_KeyControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665128);
		NativeMethodInfoPtr_get_numpad8Key_Public_get_KeyControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665129);
		NativeMethodInfoPtr_get_numpad9Key_Public_get_KeyControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665130);
		NativeMethodInfoPtr_get_f1Key_Public_get_KeyControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665131);
		NativeMethodInfoPtr_get_f2Key_Public_get_KeyControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665132);
		NativeMethodInfoPtr_get_f3Key_Public_get_KeyControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665133);
		NativeMethodInfoPtr_get_f4Key_Public_get_KeyControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665134);
		NativeMethodInfoPtr_get_f5Key_Public_get_KeyControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665135);
		NativeMethodInfoPtr_get_f6Key_Public_get_KeyControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665136);
		NativeMethodInfoPtr_get_f7Key_Public_get_KeyControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665137);
		NativeMethodInfoPtr_get_f8Key_Public_get_KeyControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665138);
		NativeMethodInfoPtr_get_f9Key_Public_get_KeyControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665139);
		NativeMethodInfoPtr_get_f10Key_Public_get_KeyControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665140);
		NativeMethodInfoPtr_get_f11Key_Public_get_KeyControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665141);
		NativeMethodInfoPtr_get_f12Key_Public_get_KeyControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665142);
		NativeMethodInfoPtr_get_oem1Key_Public_get_KeyControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665143);
		NativeMethodInfoPtr_get_oem2Key_Public_get_KeyControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665144);
		NativeMethodInfoPtr_get_oem3Key_Public_get_KeyControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665145);
		NativeMethodInfoPtr_get_oem4Key_Public_get_KeyControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665146);
		NativeMethodInfoPtr_get_oem5Key_Public_get_KeyControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665147);
		NativeMethodInfoPtr_get_f13Key_Public_get_KeyControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665148);
		NativeMethodInfoPtr_get_f14Key_Public_get_KeyControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665149);
		NativeMethodInfoPtr_get_f15Key_Public_get_KeyControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665150);
		NativeMethodInfoPtr_get_f16Key_Public_get_KeyControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665151);
		NativeMethodInfoPtr_get_f17Key_Public_get_KeyControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665152);
		NativeMethodInfoPtr_get_f18Key_Public_get_KeyControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665153);
		NativeMethodInfoPtr_get_f19Key_Public_get_KeyControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665154);
		NativeMethodInfoPtr_get_f20Key_Public_get_KeyControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665155);
		NativeMethodInfoPtr_get_f21Key_Public_get_KeyControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665156);
		NativeMethodInfoPtr_get_f22Key_Public_get_KeyControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665157);
		NativeMethodInfoPtr_get_f23Key_Public_get_KeyControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665158);
		NativeMethodInfoPtr_get_f24Key_Public_get_KeyControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665159);
		NativeMethodInfoPtr_get_shiftKey_Public_get_ButtonControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665160);
		NativeMethodInfoPtr_set_shiftKey_Protected_set_Void_ButtonControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665161);
		NativeMethodInfoPtr_get_ctrlKey_Public_get_ButtonControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665162);
		NativeMethodInfoPtr_set_ctrlKey_Protected_set_Void_ButtonControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665163);
		NativeMethodInfoPtr_get_altKey_Public_get_ButtonControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665164);
		NativeMethodInfoPtr_set_altKey_Protected_set_Void_ButtonControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665165);
		NativeMethodInfoPtr_get_imeSelected_Public_get_ButtonControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665166);
		NativeMethodInfoPtr_set_imeSelected_Protected_set_Void_ButtonControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665167);
		NativeMethodInfoPtr_get_Item_Public_get_KeyControl_Key_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665168);
		NativeMethodInfoPtr_get_allKeys_Public_get_ReadOnlyArray_1_KeyControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665169);
		NativeMethodInfoPtr_get_current_Public_Static_get_Keyboard_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665170);
		NativeMethodInfoPtr_set_current_Private_Static_set_Void_Keyboard_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665171);
		NativeMethodInfoPtr_MakeCurrent_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665172);
		NativeMethodInfoPtr_OnRemoved_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665173);
		NativeMethodInfoPtr_FinishSetup_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665174);
		NativeMethodInfoPtr_RefreshConfiguration_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665175);
		NativeMethodInfoPtr_OnTextInput_Public_Virtual_Final_New_Void_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665176);
		NativeMethodInfoPtr_FindKeyOnCurrentKeyboardLayout_Public_KeyControl_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665177);
		NativeMethodInfoPtr_OnIMECompositionChanged_Public_Virtual_Final_New_Void_IMECompositionString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665178);
		NativeMethodInfoPtr_UnityEngine_InputSystem_LowLevel_IEventPreProcessor_PreProcessEvent_Private_Virtual_Final_New_Boolean_InputEventPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665179);
		NativeMethodInfoPtr_get_keys_Protected_get_Il2CppReferenceArray_1_KeyControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665180);
		NativeMethodInfoPtr_set_keys_Protected_set_Void_Il2CppReferenceArray_1_KeyControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665181);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyboard>.NativeClassPtr, 100665182);
	}

	[SpecialName]
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976890, XrefRangeEnd = 976896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void add_onTextInput(Il2CppSystem.Action<char> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_add_onTextInput_Public_add_Void_Action_1_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[SpecialName]
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976896, XrefRangeEnd = 976899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void remove_onTextInput(Il2CppSystem.Action<char> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_remove_onTextInput_Public_rem_Void_Action_1_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[SpecialName]
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976899, XrefRangeEnd = 976905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void add_onIMECompositionChange(Il2CppSystem.Action<IMECompositionString> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_add_onIMECompositionChange_Public_add_Void_Action_1_IMECompositionString_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[SpecialName]
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976905, XrefRangeEnd = 976908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void remove_onIMECompositionChange(Il2CppSystem.Action<IMECompositionString> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_remove_onIMECompositionChange_Public_rem_Void_Action_1_IMECompositionString_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976908, XrefRangeEnd = 976912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetIMEEnabled(bool enabled)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&enabled);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetIMEEnabled_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 976912, XrefRangeEnd = 976916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetIMECursorPosition(Vector2 position)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&position);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetIMECursorPosition_Public_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 977177, XrefRangeEnd = 977182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void MakeCurrent()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_MakeCurrent_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 977182, XrefRangeEnd = 977189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void OnRemoved()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_OnRemoved_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 977189, XrefRangeEnd = 977603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void FinishSetup()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_FinishSetup_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 977603, XrefRangeEnd = 977611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void RefreshConfiguration()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_RefreshConfiguration_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 977611, XrefRangeEnd = 977614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void OnTextInput(char character)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&character);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnTextInput_Public_Virtual_Final_New_Void_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 977614, XrefRangeEnd = 977623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe KeyControl FindKeyOnCurrentKeyboardLayout(string displayName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(displayName);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindKeyOnCurrentKeyboardLayout_Public_KeyControl_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<KeyControl>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 977623, XrefRangeEnd = 977626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void OnIMECompositionChanged(IMECompositionString compositionString)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&compositionString);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnIMECompositionChanged_Public_Virtual_Final_New_Void_IMECompositionString_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 977626, XrefRangeEnd = 977632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual bool UnityEngine_InputSystem_LowLevel_IEventPreProcessor_PreProcessEvent(InputEventPtr currentEventPtr)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&currentEventPtr);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnityEngine_InputSystem_LowLevel_IEventPreProcessor_PreProcessEvent_Private_Virtual_Final_New_Boolean_InputEventPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 963305, RefRangeEnd = 963314, XrefRangeStart = 963305, XrefRangeEnd = 963314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Keyboard()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Keyboard>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public Keyboard(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
