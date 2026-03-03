using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.TextCore.Text;

namespace UnityEngine;

public class TextEditingUtilities : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_TextSelectingUtility;

	private static readonly System.IntPtr NativeFieldInfoPtr_textHandle;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CursorIndexSavedState;

	private static readonly System.IntPtr NativeFieldInfoPtr_isCompositionActive;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_UpdateImeWindowPosition;

	private static readonly System.IntPtr NativeFieldInfoPtr_OnTextChanged;

	private static readonly System.IntPtr NativeFieldInfoPtr_multiline;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Text;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_KeyEditOps;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_HighSurrogate;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_hasSelection_Private_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_revealCursor_Internal_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_stringCursorIndex_Internal_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_cursorIndex_Private_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_cursorIndex_Private_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_cursorIndexNoValidation_Private_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_cursorIndexNoValidation_Private_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_selectIndexNoValidation_Private_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_stringSelectIndex_Internal_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_selectIndex_Private_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_selectIndex_Private_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_text_Public_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_text_Public_set_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetTextWithoutNotify_Internal_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_TextSelectingUtilities_TextHandle_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateImeState_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ShouldUpdateImeWindowPosition_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetImeWindowPosition_Public_Void_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GeneratePreviewString_Public_String_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnableCursorPreviewState_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RestoreCursorState_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HandleKeyEvent_Internal_Boolean_Event_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PerformOperation_Private_Void_TextEditOp_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MapKey_Private_Static_Void_String_TextEditOp_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitKeyActions_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DeleteLineBack_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DeleteWordBack_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DeleteWordForward_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Delete_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Backspace_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DeleteSelection_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReplaceSelection_Public_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Insert_Public_Boolean_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CanPaste_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Cut_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Paste_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReplaceNewlinesWithSpaces_Private_Static_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnBlur_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TouchScreenKeyboardShouldBeUsed_Internal_Boolean_0;

	public unsafe TextSelectingUtilities m_TextSelectingUtility
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TextSelectingUtility);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TextSelectingUtilities>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TextSelectingUtility)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe TextHandle textHandle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_textHandle);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TextHandle>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_textHandle)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe int m_CursorIndexSavedState
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CursorIndexSavedState);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CursorIndexSavedState)) = value;
		}
	}

	public unsafe bool isCompositionActive
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isCompositionActive);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isCompositionActive)) = value;
		}
	}

	public unsafe bool m_UpdateImeWindowPosition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_UpdateImeWindowPosition);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_UpdateImeWindowPosition)) = value;
		}
	}

	public unsafe Il2CppSystem.Action OnTextChanged
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnTextChanged);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnTextChanged)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe bool multiline
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_multiline);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_multiline)) = value;
		}
	}

	public unsafe string m_Text
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Text);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Text)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static Dictionary<Event, TextEditOp> s_KeyEditOps
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_KeyEditOps, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<Event, TextEditOp>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_KeyEditOps, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe char m_HighSurrogate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_HighSurrogate);
			return *(char*)num;
		}
		set
		{
			*(char*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_HighSurrogate)) = value;
		}
	}

	public unsafe bool hasSelection
	{
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1249196, RefRangeEnd = 1249201, XrefRangeStart = 1249192, XrefRangeEnd = 1249196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_hasSelection_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool revealCursor
	{
		get
		{
			return m_TextSelectingUtility.revealCursor;
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_revealCursor_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe int stringCursorIndex
	{
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 1249205, RefRangeEnd = 1249217, XrefRangeStart = 1249201, XrefRangeEnd = 1249205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_stringCursorIndex_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			cursorIndex = textHandle.GetCorrespondingCodePointIndex(value);
		}
	}

	public unsafe int cursorIndex
	{
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 1249218, RefRangeEnd = 1249233, XrefRangeStart = 1249217, XrefRangeEnd = 1249218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_cursorIndex_Private_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_cursorIndex_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe int cursorIndexNoValidation
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_cursorIndexNoValidation_Private_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_cursorIndexNoValidation_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe int selectIndexNoValidation
	{
		get
		{
			return m_TextSelectingUtility.selectIndexNoValidation;
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_selectIndexNoValidation_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe int stringSelectIndex
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1249237, RefRangeEnd = 1249240, XrefRangeStart = 1249233, XrefRangeEnd = 1249237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_stringSelectIndex_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			selectIndex = textHandle.GetCorrespondingCodePointIndex(value);
		}
	}

	public unsafe int selectIndex
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1249241, RefRangeEnd = 1249244, XrefRangeStart = 1249240, XrefRangeEnd = 1249241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_selectIndex_Private_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_selectIndex_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe string text
	{
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 50653, RefRangeEnd = 50668, XrefRangeStart = 50653, XrefRangeEnd = 50668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_text_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1249247, RefRangeEnd = 1249249, XrefRangeStart = 1249244, XrefRangeEnd = 1249247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_text_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public string SelectedText => m_TextSelectingUtility.selectedText;

	public int m_iAltCursorPos => m_TextSelectingUtility.iAltCursorPos;

	public int stringCursorIndexNoValidation => textHandle.GetCorrespondingStringIndex(m_TextSelectingUtility.cursorIndexNoValidation);

	static TextEditingUtilities()
	{
		Il2CppClassPointerStore<TextEditingUtilities>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.IMGUIModule.dll", "UnityEngine", "TextEditingUtilities");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextEditingUtilities>.NativeClassPtr);
		NativeFieldInfoPtr_m_TextSelectingUtility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextEditingUtilities>.NativeClassPtr, "m_TextSelectingUtility");
		NativeFieldInfoPtr_textHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextEditingUtilities>.NativeClassPtr, "textHandle");
		NativeFieldInfoPtr_m_CursorIndexSavedState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextEditingUtilities>.NativeClassPtr, "m_CursorIndexSavedState");
		NativeFieldInfoPtr_isCompositionActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextEditingUtilities>.NativeClassPtr, "isCompositionActive");
		NativeFieldInfoPtr_m_UpdateImeWindowPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextEditingUtilities>.NativeClassPtr, "m_UpdateImeWindowPosition");
		NativeFieldInfoPtr_OnTextChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextEditingUtilities>.NativeClassPtr, "OnTextChanged");
		NativeFieldInfoPtr_multiline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextEditingUtilities>.NativeClassPtr, "multiline");
		NativeFieldInfoPtr_m_Text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextEditingUtilities>.NativeClassPtr, "m_Text");
		NativeFieldInfoPtr_s_KeyEditOps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextEditingUtilities>.NativeClassPtr, "s_KeyEditOps");
		NativeFieldInfoPtr_m_HighSurrogate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextEditingUtilities>.NativeClassPtr, "m_HighSurrogate");
		NativeMethodInfoPtr_get_hasSelection_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditingUtilities>.NativeClassPtr, 100663818);
		NativeMethodInfoPtr_set_revealCursor_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditingUtilities>.NativeClassPtr, 100663819);
		NativeMethodInfoPtr_get_stringCursorIndex_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditingUtilities>.NativeClassPtr, 100663820);
		NativeMethodInfoPtr_get_cursorIndex_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditingUtilities>.NativeClassPtr, 100663821);
		NativeMethodInfoPtr_set_cursorIndex_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditingUtilities>.NativeClassPtr, 100663822);
		NativeMethodInfoPtr_get_cursorIndexNoValidation_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditingUtilities>.NativeClassPtr, 100663823);
		NativeMethodInfoPtr_set_cursorIndexNoValidation_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditingUtilities>.NativeClassPtr, 100663824);
		NativeMethodInfoPtr_set_selectIndexNoValidation_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditingUtilities>.NativeClassPtr, 100663825);
		NativeMethodInfoPtr_get_stringSelectIndex_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditingUtilities>.NativeClassPtr, 100663826);
		NativeMethodInfoPtr_get_selectIndex_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditingUtilities>.NativeClassPtr, 100663827);
		NativeMethodInfoPtr_set_selectIndex_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditingUtilities>.NativeClassPtr, 100663828);
		NativeMethodInfoPtr_get_text_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditingUtilities>.NativeClassPtr, 100663829);
		NativeMethodInfoPtr_set_text_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditingUtilities>.NativeClassPtr, 100663830);
		NativeMethodInfoPtr_SetTextWithoutNotify_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditingUtilities>.NativeClassPtr, 100663831);
		NativeMethodInfoPtr__ctor_Public_Void_TextSelectingUtilities_TextHandle_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditingUtilities>.NativeClassPtr, 100663832);
		NativeMethodInfoPtr_UpdateImeState_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditingUtilities>.NativeClassPtr, 100663833);
		NativeMethodInfoPtr_ShouldUpdateImeWindowPosition_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditingUtilities>.NativeClassPtr, 100663834);
		NativeMethodInfoPtr_SetImeWindowPosition_Public_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditingUtilities>.NativeClassPtr, 100663835);
		NativeMethodInfoPtr_GeneratePreviewString_Public_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditingUtilities>.NativeClassPtr, 100663836);
		NativeMethodInfoPtr_EnableCursorPreviewState_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditingUtilities>.NativeClassPtr, 100663837);
		NativeMethodInfoPtr_RestoreCursorState_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditingUtilities>.NativeClassPtr, 100663838);
		NativeMethodInfoPtr_HandleKeyEvent_Internal_Boolean_Event_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditingUtilities>.NativeClassPtr, 100663839);
		NativeMethodInfoPtr_PerformOperation_Private_Void_TextEditOp_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditingUtilities>.NativeClassPtr, 100663840);
		NativeMethodInfoPtr_MapKey_Private_Static_Void_String_TextEditOp_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditingUtilities>.NativeClassPtr, 100663841);
		NativeMethodInfoPtr_InitKeyActions_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditingUtilities>.NativeClassPtr, 100663842);
		NativeMethodInfoPtr_DeleteLineBack_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditingUtilities>.NativeClassPtr, 100663843);
		NativeMethodInfoPtr_DeleteWordBack_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditingUtilities>.NativeClassPtr, 100663844);
		NativeMethodInfoPtr_DeleteWordForward_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditingUtilities>.NativeClassPtr, 100663845);
		NativeMethodInfoPtr_Delete_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditingUtilities>.NativeClassPtr, 100663846);
		NativeMethodInfoPtr_Backspace_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditingUtilities>.NativeClassPtr, 100663847);
		NativeMethodInfoPtr_DeleteSelection_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditingUtilities>.NativeClassPtr, 100663848);
		NativeMethodInfoPtr_ReplaceSelection_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditingUtilities>.NativeClassPtr, 100663849);
		NativeMethodInfoPtr_Insert_Public_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditingUtilities>.NativeClassPtr, 100663850);
		NativeMethodInfoPtr_CanPaste_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditingUtilities>.NativeClassPtr, 100663851);
		NativeMethodInfoPtr_Cut_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditingUtilities>.NativeClassPtr, 100663852);
		NativeMethodInfoPtr_Paste_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditingUtilities>.NativeClassPtr, 100663853);
		NativeMethodInfoPtr_ReplaceNewlinesWithSpaces_Private_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditingUtilities>.NativeClassPtr, 100663854);
		NativeMethodInfoPtr_OnBlur_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditingUtilities>.NativeClassPtr, 100663855);
		NativeMethodInfoPtr_TouchScreenKeyboardShouldBeUsed_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditingUtilities>.NativeClassPtr, 100663856);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 84623, RefRangeEnd = 84624, XrefRangeStart = 84623, XrefRangeEnd = 84624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetTextWithoutNotify(string value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetTextWithoutNotify_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1249253, RefRangeEnd = 1249254, XrefRangeStart = 1249249, XrefRangeEnd = 1249253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TextEditingUtilities(TextSelectingUtilities selectingUtilities, TextHandle textHandle, string text)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextEditingUtilities>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)selectingUtilities);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textHandle);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(text);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_TextSelectingUtilities_TextHandle_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1249258, RefRangeEnd = 1249260, XrefRangeStart = 1249254, XrefRangeEnd = 1249258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool UpdateImeState()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateImeState_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1249260, RefRangeEnd = 1249261, XrefRangeStart = 1249260, XrefRangeEnd = 1249260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool ShouldUpdateImeWindowPosition()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShouldUpdateImeWindowPosition_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1249268, RefRangeEnd = 1249269, XrefRangeStart = 1249261, XrefRangeEnd = 1249268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetImeWindowPosition(Vector2 worldPosition)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&worldPosition);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetImeWindowPosition_Public_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1249281, RefRangeEnd = 1249282, XrefRangeStart = 1249269, XrefRangeEnd = 1249281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GeneratePreviewString(bool richText)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&richText);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GeneratePreviewString_Public_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1249286, RefRangeEnd = 1249287, XrefRangeStart = 1249282, XrefRangeEnd = 1249286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EnableCursorPreviewState()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnableCursorPreviewState_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 1249287, RefRangeEnd = 1249297, XrefRangeStart = 1249287, XrefRangeEnd = 1249287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RestoreCursorState()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RestoreCursorState_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1249314, RefRangeEnd = 1249315, XrefRangeStart = 1249297, XrefRangeEnd = 1249314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HandleKeyEvent(Event e)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)e);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HandleKeyEvent_Internal_Boolean_Event_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1249319, RefRangeEnd = 1249320, XrefRangeStart = 1249315, XrefRangeEnd = 1249319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PerformOperation(TextEditOp operation)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&operation);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PerformOperation_Private_Void_TextEditOp_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(23)]
	[CachedScanResults(RefRangeStart = 1249327, RefRangeEnd = 1249350, XrefRangeStart = 1249320, XrefRangeEnd = 1249327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void MapKey(string key, TextEditOp action)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		*(TextEditOp**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &action;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MapKey_Private_Static_Void_String_TextEditOp_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1249453, RefRangeEnd = 1249454, XrefRangeStart = 1249350, XrefRangeEnd = 1249453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InitKeyActions()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitKeyActions_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1249454, XrefRangeEnd = 1249474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool DeleteLineBack()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DeleteLineBack_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1249474, XrefRangeEnd = 1249488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool DeleteWordBack()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DeleteWordBack_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1249488, XrefRangeEnd = 1249503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool DeleteWordForward()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DeleteWordForward_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1249503, XrefRangeEnd = 1249506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Delete()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Delete_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1249506, XrefRangeEnd = 1249541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Backspace()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Backspace_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 1249568, RefRangeEnd = 1249574, XrefRangeStart = 1249541, XrefRangeEnd = 1249568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool DeleteSelection()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DeleteSelection_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1249588, RefRangeEnd = 1249589, XrefRangeStart = 1249574, XrefRangeEnd = 1249588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ReplaceSelection(string replace)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(replace);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReplaceSelection_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1249589, XrefRangeEnd = 1249604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Insert(char c)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&c);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Insert_Public_Boolean_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1249608, RefRangeEnd = 1249609, XrefRangeStart = 1249604, XrefRangeEnd = 1249608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool CanPaste()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CanPaste_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1249609, XrefRangeEnd = 1249612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Cut()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Cut_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1249612, XrefRangeEnd = 1249620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Paste()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Paste_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1249620, XrefRangeEnd = 1249628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string ReplaceNewlinesWithSpaces(string value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReplaceNewlinesWithSpaces_Private_Static_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1249631, RefRangeEnd = 1249633, XrefRangeStart = 1249628, XrefRangeEnd = 1249631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnBlur()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnBlur_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1249639, RefRangeEnd = 1249644, XrefRangeStart = 1249633, XrefRangeEnd = 1249639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool TouchScreenKeyboardShouldBeUsed()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TouchScreenKeyboardShouldBeUsed_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public TextEditingUtilities(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public void MoveSelectionToAltCursor()
	{
		RestoreCursorState();
		if (m_iAltCursorPos != -1)
		{
			int iAltCursorPos = m_iAltCursorPos;
			string selectedText = SelectedText;
			text = text.Insert(iAltCursorPos, selectedText);
			if (iAltCursorPos < cursorIndex)
			{
				cursorIndex += selectedText.Length;
				selectIndex += selectedText.Length;
			}
			DeleteSelection();
			int num2 = (cursorIndex = iAltCursorPos);
			selectIndex = num2;
			m_TextSelectingUtility.ClearCursorPos();
		}
	}
}
