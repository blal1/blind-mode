using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.TextCore.Text;

namespace UnityEngine;

public class TextSelectingUtilities : Il2CppSystem.Object
{
	[OriginalName("UnityEngine.IMGUIModule.dll", "", "CharacterType")]
	public enum CharacterType
	{
		LetterLike,
		Symbol,
		Symbol2,
		WhiteSpace,
		NewLine
	}

	[OriginalName("UnityEngine.IMGUIModule.dll", "", "Direction")]
	public enum Direction
	{
		Forward,
		Backward
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_dblClickSnap;

	private static readonly System.IntPtr NativeFieldInfoPtr_iAltCursorPos;

	private static readonly System.IntPtr NativeFieldInfoPtr_hasHorizontalCursorPos;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_bJustSelected;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_MouseDragSelectsWholeWords;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_DblClickInitPosStart;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_DblClickInitPosEnd;

	private static readonly System.IntPtr NativeFieldInfoPtr_textHandle;

	private static readonly System.IntPtr NativeFieldInfoPtr_kMoveDownHeight;

	private static readonly System.IntPtr NativeFieldInfoPtr_kNewLineChar;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_RevealCursor;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CursorIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_SelectIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_KeySelectOps;

	private static readonly System.IntPtr NativeFieldInfoPtr_OnCursorIndexChange;

	private static readonly System.IntPtr NativeFieldInfoPtr_OnSelectIndexChange;

	private static readonly System.IntPtr NativeFieldInfoPtr_OnRevealCursorChange;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_hasSelection_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_revealCursor_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_revealCursor_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_m_CharacterCount_Private_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_characterCount_Private_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_m_TextElementInfos_Private_get_Il2CppReferenceArray_1_TextElementInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_cursorIndex_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_cursorIndex_Public_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_cursorIndexNoValidation_Internal_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_cursorIndexNoValidation_Internal_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetCursorIndexWithoutNotify_Internal_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_selectIndex_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_selectIndex_Public_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_selectIndexNoValidation_Internal_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetSelectIndexWithoutNotify_Internal_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_selectedText_Public_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_TextHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HandleKeyEvent_Internal_Boolean_Event_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PerformOperation_Private_Boolean_TextSelectOp_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MapKey_Private_Static_Void_String_TextSelectOp_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitKeyActions_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearCursorPos_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnFocus_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SelectAll_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SelectNone_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SelectLeft_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SelectRight_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SelectUp_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SelectDown_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SelectTextEnd_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SelectTextStart_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SelectToStartOfNextWord_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SelectToEndOfPreviousWord_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SelectWordRight_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SelectWordLeft_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SelectGraphicalLineStart_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SelectGraphicalLineEnd_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SelectParagraphForward_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SelectParagraphBackward_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SelectCurrentWord_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SelectCurrentParagraph_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MoveRight_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MoveLeft_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MoveUp_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MoveDown_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MoveLineStart_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MoveLineEnd_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MoveGraphicalLineStart_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MoveGraphicalLineEnd_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MoveTextStart_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MoveTextEnd_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MoveParagraphForward_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MoveParagraphBackward_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MoveWordRight_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MoveToStartOfNextWord_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MoveToEndOfPreviousWord_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MoveWordLeft_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MouseDragSelectsWholeWords_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ExpandSelectGraphicalLineStart_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ExpandSelectGraphicalLineEnd_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DblClickSnap_Public_Void_DblClickSnapping_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MoveCursorToPosition_Internal_FamOrAssem_Void_Vector2_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SelectToPosition_Public_Void_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindNextSeperator_Private_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindPrevSeperator_Private_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindStartOfNextWord_Public_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindEndOfPreviousWord_Public_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FindEndOfClassification_Private_Int32_Int32_Direction_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClampTextIndex_Private_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IndexOfEndOfLine_Private_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PreviousCodePointIndex_Public_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NextCodePointIndex_Public_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetGraphicalLineStart_Private_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetGraphicalLineEnd_Private_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Copy_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClassifyChar_Private_CharacterType_Int32_0;

	public unsafe TextEditor.DblClickSnapping dblClickSnap
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dblClickSnap);
			return *(TextEditor.DblClickSnapping*)num;
		}
		set
		{
			*(TextEditor.DblClickSnapping*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dblClickSnap)) = value;
		}
	}

	public unsafe int iAltCursorPos
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_iAltCursorPos);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_iAltCursorPos)) = value;
		}
	}

	public unsafe bool hasHorizontalCursorPos
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hasHorizontalCursorPos);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hasHorizontalCursorPos)) = value;
		}
	}

	public unsafe bool m_bJustSelected
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_bJustSelected);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_bJustSelected)) = value;
		}
	}

	public unsafe bool m_MouseDragSelectsWholeWords
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MouseDragSelectsWholeWords);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MouseDragSelectsWholeWords)) = value;
		}
	}

	public unsafe int m_DblClickInitPosStart
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DblClickInitPosStart);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DblClickInitPosStart)) = value;
		}
	}

	public unsafe int m_DblClickInitPosEnd
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DblClickInitPosEnd);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DblClickInitPosEnd)) = value;
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

	public unsafe static int kMoveDownHeight
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kMoveDownHeight, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kMoveDownHeight, (void*)(&value));
		}
	}

	public unsafe static char kNewLineChar
	{
		get
		{
			Unsafe.SkipInit(out char result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kNewLineChar, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kNewLineChar, (void*)(&value));
		}
	}

	public unsafe bool m_RevealCursor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RevealCursor);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RevealCursor)) = value;
		}
	}

	public unsafe int m_CursorIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CursorIndex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CursorIndex)) = value;
		}
	}

	public unsafe int m_SelectIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SelectIndex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SelectIndex)) = value;
		}
	}

	public unsafe static Dictionary<Event, TextSelectOp> s_KeySelectOps
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_KeySelectOps, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<Event, TextSelectOp>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_KeySelectOps, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppSystem.Action OnCursorIndexChange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnCursorIndexChange);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnCursorIndexChange)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppSystem.Action OnSelectIndexChange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnSelectIndexChange);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnSelectIndexChange)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppSystem.Action OnRevealCursorChange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnRevealCursorChange);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnRevealCursorChange)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe bool hasSelection
	{
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1249814, RefRangeEnd = 1249819, XrefRangeStart = 1249810, XrefRangeEnd = 1249814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_hasSelection_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool revealCursor
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_revealCursor_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_revealCursor_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe int m_CharacterCount
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1249819, XrefRangeEnd = 1249821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_m_CharacterCount_Private_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe int characterCount
	{
		[CallerCount(195)]
		[CachedScanResults(RefRangeStart = 1249826, RefRangeEnd = 1250021, XrefRangeStart = 1249821, XrefRangeEnd = 1249826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_characterCount_Private_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe Il2CppReferenceArray<TextElementInfo> m_TextElementInfos
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1250021, XrefRangeEnd = 1250022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_m_TextElementInfos_Private_get_Il2CppReferenceArray_1_TextElementInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TextElementInfo>>(intPtr2) : null;
		}
	}

	public unsafe int cursorIndex
	{
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 1250023, RefRangeEnd = 1250043, XrefRangeStart = 1250022, XrefRangeEnd = 1250023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_cursorIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1250043, RefRangeEnd = 1250044, XrefRangeStart = 1250043, XrefRangeEnd = 1250043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_cursorIndex_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
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
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_cursorIndexNoValidation_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1250043, RefRangeEnd = 1250044, XrefRangeStart = 1250043, XrefRangeEnd = 1250044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_cursorIndexNoValidation_Internal_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe int selectIndex
	{
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 1250045, RefRangeEnd = 1250063, XrefRangeStart = 1250044, XrefRangeEnd = 1250045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_selectIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1250063, RefRangeEnd = 1250064, XrefRangeStart = 1250063, XrefRangeEnd = 1250063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_selectIndex_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe int selectIndexNoValidation
	{
		get
		{
			return m_SelectIndex;
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1250063, RefRangeEnd = 1250064, XrefRangeStart = 1250063, XrefRangeEnd = 1250064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_selectIndexNoValidation_Internal_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe string selectedText
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1250081, RefRangeEnd = 1250082, XrefRangeStart = 1250064, XrefRangeEnd = 1250081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_selectedText_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
	}

	static TextSelectingUtilities()
	{
		Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.IMGUIModule.dll", "UnityEngine", "TextSelectingUtilities");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr);
		NativeFieldInfoPtr_dblClickSnap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, "dblClickSnap");
		NativeFieldInfoPtr_iAltCursorPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, "iAltCursorPos");
		NativeFieldInfoPtr_hasHorizontalCursorPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, "hasHorizontalCursorPos");
		NativeFieldInfoPtr_m_bJustSelected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, "m_bJustSelected");
		NativeFieldInfoPtr_m_MouseDragSelectsWholeWords = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, "m_MouseDragSelectsWholeWords");
		NativeFieldInfoPtr_m_DblClickInitPosStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, "m_DblClickInitPosStart");
		NativeFieldInfoPtr_m_DblClickInitPosEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, "m_DblClickInitPosEnd");
		NativeFieldInfoPtr_textHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, "textHandle");
		NativeFieldInfoPtr_kMoveDownHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, "kMoveDownHeight");
		NativeFieldInfoPtr_kNewLineChar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, "kNewLineChar");
		NativeFieldInfoPtr_m_RevealCursor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, "m_RevealCursor");
		NativeFieldInfoPtr_m_CursorIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, "m_CursorIndex");
		NativeFieldInfoPtr_m_SelectIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, "m_SelectIndex");
		NativeFieldInfoPtr_s_KeySelectOps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, "s_KeySelectOps");
		NativeFieldInfoPtr_OnCursorIndexChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, "OnCursorIndexChange");
		NativeFieldInfoPtr_OnSelectIndexChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, "OnSelectIndexChange");
		NativeFieldInfoPtr_OnRevealCursorChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, "OnRevealCursorChange");
		NativeMethodInfoPtr_get_hasSelection_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663870);
		NativeMethodInfoPtr_get_revealCursor_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663871);
		NativeMethodInfoPtr_set_revealCursor_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663872);
		NativeMethodInfoPtr_get_m_CharacterCount_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663873);
		NativeMethodInfoPtr_get_characterCount_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663874);
		NativeMethodInfoPtr_get_m_TextElementInfos_Private_get_Il2CppReferenceArray_1_TextElementInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663875);
		NativeMethodInfoPtr_get_cursorIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663876);
		NativeMethodInfoPtr_set_cursorIndex_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663877);
		NativeMethodInfoPtr_get_cursorIndexNoValidation_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663878);
		NativeMethodInfoPtr_set_cursorIndexNoValidation_Internal_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663879);
		NativeMethodInfoPtr_SetCursorIndexWithoutNotify_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663880);
		NativeMethodInfoPtr_get_selectIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663881);
		NativeMethodInfoPtr_set_selectIndex_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663882);
		NativeMethodInfoPtr_set_selectIndexNoValidation_Internal_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663883);
		NativeMethodInfoPtr_SetSelectIndexWithoutNotify_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663884);
		NativeMethodInfoPtr_get_selectedText_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663885);
		NativeMethodInfoPtr__ctor_Public_Void_TextHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663886);
		NativeMethodInfoPtr_HandleKeyEvent_Internal_Boolean_Event_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663887);
		NativeMethodInfoPtr_PerformOperation_Private_Boolean_TextSelectOp_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663888);
		NativeMethodInfoPtr_MapKey_Private_Static_Void_String_TextSelectOp_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663889);
		NativeMethodInfoPtr_InitKeyActions_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663890);
		NativeMethodInfoPtr_ClearCursorPos_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663891);
		NativeMethodInfoPtr_OnFocus_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663892);
		NativeMethodInfoPtr_SelectAll_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663893);
		NativeMethodInfoPtr_SelectNone_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663894);
		NativeMethodInfoPtr_SelectLeft_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663895);
		NativeMethodInfoPtr_SelectRight_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663896);
		NativeMethodInfoPtr_SelectUp_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663897);
		NativeMethodInfoPtr_SelectDown_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663898);
		NativeMethodInfoPtr_SelectTextEnd_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663899);
		NativeMethodInfoPtr_SelectTextStart_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663900);
		NativeMethodInfoPtr_SelectToStartOfNextWord_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663901);
		NativeMethodInfoPtr_SelectToEndOfPreviousWord_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663902);
		NativeMethodInfoPtr_SelectWordRight_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663903);
		NativeMethodInfoPtr_SelectWordLeft_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663904);
		NativeMethodInfoPtr_SelectGraphicalLineStart_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663905);
		NativeMethodInfoPtr_SelectGraphicalLineEnd_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663906);
		NativeMethodInfoPtr_SelectParagraphForward_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663907);
		NativeMethodInfoPtr_SelectParagraphBackward_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663908);
		NativeMethodInfoPtr_SelectCurrentWord_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663909);
		NativeMethodInfoPtr_SelectCurrentParagraph_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663910);
		NativeMethodInfoPtr_MoveRight_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663911);
		NativeMethodInfoPtr_MoveLeft_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663912);
		NativeMethodInfoPtr_MoveUp_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663913);
		NativeMethodInfoPtr_MoveDown_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663914);
		NativeMethodInfoPtr_MoveLineStart_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663915);
		NativeMethodInfoPtr_MoveLineEnd_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663916);
		NativeMethodInfoPtr_MoveGraphicalLineStart_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663917);
		NativeMethodInfoPtr_MoveGraphicalLineEnd_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663918);
		NativeMethodInfoPtr_MoveTextStart_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663919);
		NativeMethodInfoPtr_MoveTextEnd_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663920);
		NativeMethodInfoPtr_MoveParagraphForward_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663921);
		NativeMethodInfoPtr_MoveParagraphBackward_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663922);
		NativeMethodInfoPtr_MoveWordRight_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663923);
		NativeMethodInfoPtr_MoveToStartOfNextWord_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663924);
		NativeMethodInfoPtr_MoveToEndOfPreviousWord_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663925);
		NativeMethodInfoPtr_MoveWordLeft_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663926);
		NativeMethodInfoPtr_MouseDragSelectsWholeWords_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663927);
		NativeMethodInfoPtr_ExpandSelectGraphicalLineStart_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663928);
		NativeMethodInfoPtr_ExpandSelectGraphicalLineEnd_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663929);
		NativeMethodInfoPtr_DblClickSnap_Public_Void_DblClickSnapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663930);
		NativeMethodInfoPtr_MoveCursorToPosition_Internal_FamOrAssem_Void_Vector2_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663931);
		NativeMethodInfoPtr_SelectToPosition_Public_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663932);
		NativeMethodInfoPtr_FindNextSeperator_Private_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663933);
		NativeMethodInfoPtr_FindPrevSeperator_Private_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663934);
		NativeMethodInfoPtr_FindStartOfNextWord_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663935);
		NativeMethodInfoPtr_FindEndOfPreviousWord_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663936);
		NativeMethodInfoPtr_FindEndOfClassification_Private_Int32_Int32_Direction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663937);
		NativeMethodInfoPtr_ClampTextIndex_Private_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663938);
		NativeMethodInfoPtr_IndexOfEndOfLine_Private_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663939);
		NativeMethodInfoPtr_PreviousCodePointIndex_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663940);
		NativeMethodInfoPtr_NextCodePointIndex_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663941);
		NativeMethodInfoPtr_GetGraphicalLineStart_Private_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663942);
		NativeMethodInfoPtr_GetGraphicalLineEnd_Private_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663943);
		NativeMethodInfoPtr_Copy_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663944);
		NativeMethodInfoPtr_ClassifyChar_Private_CharacterType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr, 100663945);
	}

	[CallerCount(0)]
	public unsafe void SetCursorIndexWithoutNotify(int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&index);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetCursorIndexWithoutNotify_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 202040, RefRangeEnd = 202045, XrefRangeStart = 202040, XrefRangeEnd = 202045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetSelectIndexWithoutNotify(int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&index);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetSelectIndexWithoutNotify_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1250084, RefRangeEnd = 1250085, XrefRangeStart = 1250082, XrefRangeEnd = 1250084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TextSelectingUtilities(TextHandle textHandle)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextSelectingUtilities>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textHandle);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_TextHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1250101, RefRangeEnd = 1250102, XrefRangeStart = 1250085, XrefRangeEnd = 1250101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 1250106, RefRangeEnd = 1250107, XrefRangeStart = 1250102, XrefRangeEnd = 1250106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool PerformOperation(TextSelectOp operation)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&operation);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PerformOperation_Private_Boolean_TextSelectOp_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(12)]
	[CachedScanResults(RefRangeStart = 1250114, RefRangeEnd = 1250126, XrefRangeStart = 1250107, XrefRangeEnd = 1250114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void MapKey(string key, TextSelectOp action)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		*(TextSelectOp**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &action;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MapKey_Private_Static_Void_String_TextSelectOp_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1250192, RefRangeEnd = 1250193, XrefRangeStart = 1250126, XrefRangeEnd = 1250192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InitKeyActions()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitKeyActions_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe void ClearCursorPos()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearCursorPos_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1250193, RefRangeEnd = 1250195, XrefRangeStart = 1250193, XrefRangeEnd = 1250193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnFocus(bool selectAll = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&selectAll);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnFocus_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1250195, RefRangeEnd = 1250197, XrefRangeStart = 1250195, XrefRangeEnd = 1250195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SelectAll()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SelectAll_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1250199, RefRangeEnd = 1250201, XrefRangeStart = 1250197, XrefRangeEnd = 1250199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SelectNone()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SelectNone_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1250212, RefRangeEnd = 1250213, XrefRangeStart = 1250201, XrefRangeEnd = 1250212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SelectLeft()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SelectLeft_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1250213, XrefRangeEnd = 1250225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SelectRight()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SelectRight_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1250225, XrefRangeEnd = 1250228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SelectUp()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SelectUp_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1250228, XrefRangeEnd = 1250231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SelectDown()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SelectDown_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1250231, XrefRangeEnd = 1250232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SelectTextEnd()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SelectTextEnd_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe void SelectTextStart()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SelectTextStart_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1250232, XrefRangeEnd = 1250235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SelectToStartOfNextWord()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SelectToStartOfNextWord_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1250235, XrefRangeEnd = 1250238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SelectToEndOfPreviousWord()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SelectToEndOfPreviousWord_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1250238, XrefRangeEnd = 1250247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SelectWordRight()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SelectWordRight_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1250247, XrefRangeEnd = 1250256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SelectWordLeft()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SelectWordLeft_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1250256, XrefRangeEnd = 1250259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SelectGraphicalLineStart()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SelectGraphicalLineStart_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1250259, XrefRangeEnd = 1250262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SelectGraphicalLineEnd()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SelectGraphicalLineEnd_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1250262, XrefRangeEnd = 1250276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SelectParagraphForward()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SelectParagraphForward_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1250276, XrefRangeEnd = 1250289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SelectParagraphBackward()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SelectParagraphBackward_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1250363, RefRangeEnd = 1250364, XrefRangeStart = 1250289, XrefRangeEnd = 1250363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SelectCurrentWord()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SelectCurrentWord_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1250374, RefRangeEnd = 1250375, XrefRangeStart = 1250364, XrefRangeEnd = 1250374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SelectCurrentParagraph()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SelectCurrentParagraph_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1250375, XrefRangeEnd = 1250386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void MoveRight()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MoveRight_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1250405, RefRangeEnd = 1250406, XrefRangeStart = 1250386, XrefRangeEnd = 1250405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void MoveLeft()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MoveLeft_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1250406, XrefRangeEnd = 1250419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void MoveUp()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MoveUp_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1250419, XrefRangeEnd = 1250434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void MoveDown()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MoveDown_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1250434, XrefRangeEnd = 1250443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void MoveLineStart()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MoveLineStart_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1250443, XrefRangeEnd = 1250452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void MoveLineEnd()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MoveLineEnd_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1250452, XrefRangeEnd = 1250460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void MoveGraphicalLineStart()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MoveGraphicalLineStart_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1250460, XrefRangeEnd = 1250468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void MoveGraphicalLineEnd()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MoveGraphicalLineEnd_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe void MoveTextStart()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MoveTextStart_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1250468, XrefRangeEnd = 1250469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void MoveTextEnd()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MoveTextEnd_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1250469, XrefRangeEnd = 1250483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void MoveParagraphForward()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MoveParagraphForward_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1250483, XrefRangeEnd = 1250495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void MoveParagraphBackward()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MoveParagraphBackward_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1250522, RefRangeEnd = 1250523, XrefRangeStart = 1250495, XrefRangeEnd = 1250522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void MoveWordRight()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MoveWordRight_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1250523, XrefRangeEnd = 1250530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void MoveToStartOfNextWord()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MoveToStartOfNextWord_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1250530, XrefRangeEnd = 1250537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void MoveToEndOfPreviousWord()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MoveToEndOfPreviousWord_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1250555, RefRangeEnd = 1250556, XrefRangeStart = 1250537, XrefRangeEnd = 1250555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void MoveWordLeft()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MoveWordLeft_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1250570, RefRangeEnd = 1250573, XrefRangeStart = 1250556, XrefRangeEnd = 1250570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void MouseDragSelectsWholeWords(bool on)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&on);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MouseDragSelectsWholeWords_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1250573, XrefRangeEnd = 1250582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ExpandSelectGraphicalLineStart()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ExpandSelectGraphicalLineStart_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1250582, XrefRangeEnd = 1250591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ExpandSelectGraphicalLineEnd()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ExpandSelectGraphicalLineEnd_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 86557, RefRangeEnd = 86558, XrefRangeStart = 86557, XrefRangeEnd = 86558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DblClickSnap(TextEditor.DblClickSnapping snapping)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&snapping);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DblClickSnap_Public_Void_DblClickSnapping_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1250594, RefRangeEnd = 1250596, XrefRangeStart = 1250591, XrefRangeEnd = 1250594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void MoveCursorToPosition_Internal(Vector2 cursorPosition, bool shift)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&cursorPosition);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &shift;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MoveCursorToPosition_Internal_FamOrAssem_Void_Vector2_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1250682, RefRangeEnd = 1250683, XrefRangeStart = 1250596, XrefRangeEnd = 1250682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SelectToPosition(Vector2 cursorPosition)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&cursorPosition);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SelectToPosition_Public_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1250683, XrefRangeEnd = 1250696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int FindNextSeperator(int startPos)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&startPos);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindNextSeperator_Private_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1250711, RefRangeEnd = 1250713, XrefRangeStart = 1250696, XrefRangeEnd = 1250711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int FindPrevSeperator(int startPos)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&startPos);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindPrevSeperator_Private_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1250738, RefRangeEnd = 1250742, XrefRangeStart = 1250713, XrefRangeEnd = 1250738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int FindStartOfNextWord(int p)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&p);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindStartOfNextWord_Public_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1250759, RefRangeEnd = 1250763, XrefRangeStart = 1250742, XrefRangeEnd = 1250759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int FindEndOfPreviousWord(int p)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&p);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindEndOfPreviousWord_Public_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1250788, RefRangeEnd = 1250789, XrefRangeStart = 1250763, XrefRangeEnd = 1250788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int FindEndOfClassification(int p, Direction dir)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&p);
		*(Direction**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &dir;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindEndOfClassification_Private_Int32_Int32_Direction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1250789, XrefRangeEnd = 1250790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int ClampTextIndex(int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&index);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClampTextIndex_Private_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1250792, RefRangeEnd = 1250793, XrefRangeStart = 1250790, XrefRangeEnd = 1250792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int IndexOfEndOfLine(int startIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&startIndex);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IndexOfEndOfLine_Private_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1250793, XrefRangeEnd = 1250794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int PreviousCodePointIndex(int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&index);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PreviousCodePointIndex_Public_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 1250796, RefRangeEnd = 1250803, XrefRangeStart = 1250794, XrefRangeEnd = 1250796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int NextCodePointIndex(int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&index);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NextCodePointIndex_Public_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1250811, RefRangeEnd = 1250814, XrefRangeStart = 1250803, XrefRangeEnd = 1250811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetGraphicalLineStart(int p)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&p);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetGraphicalLineStart_Private_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1250822, RefRangeEnd = 1250825, XrefRangeStart = 1250814, XrefRangeEnd = 1250822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetGraphicalLineEnd(int p)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&p);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetGraphicalLineEnd_Private_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1250834, RefRangeEnd = 1250836, XrefRangeStart = 1250825, XrefRangeEnd = 1250834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Copy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Copy_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(33)]
	[CachedScanResults(RefRangeStart = 1250844, RefRangeEnd = 1250877, XrefRangeStart = 1250836, XrefRangeEnd = 1250844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CharacterType ClassifyChar(int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&index);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClassifyChar_Private_CharacterType_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(CharacterType*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public TextSelectingUtilities(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public void MoveAltCursorToPosition(Vector2 cursorPosition)
	{
		if (cursorIndex == 0 && selectIndex == characterCount)
		{
			iAltCursorPos = -1;
			return;
		}
		int cursorIndexFromPosition = textHandle.GetCursorIndexFromPosition(cursorPosition);
		iAltCursorPos = Mathf.Min(characterCount, cursorIndexFromPosition);
	}

	public bool IsOverSelection(Vector2 cursorPosition)
	{
		int cursorIndexFromPosition = textHandle.GetCursorIndexFromPosition(cursorPosition);
		return cursorIndexFromPosition < Mathf.Max(cursorIndex, selectIndex) && cursorIndexFromPosition > Mathf.Min(cursorIndex, selectIndex);
	}
}
