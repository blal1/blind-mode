using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.TextCore.Text;

namespace UnityEngine;

public class TextEditor : Il2CppSystem.Object
{
	[OriginalName("UnityEngine.IMGUIModule.dll", "", "DblClickSnapping")]
	public enum DblClickSnapping : byte
	{
		WORDS,
		PARAGRAPHS
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Content;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_TextSelecting;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_TextEditing;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_TextHandle;

	private static readonly System.IntPtr NativeFieldInfoPtr_keyboardOnScreen;

	private static readonly System.IntPtr NativeFieldInfoPtr_controlID;

	private static readonly System.IntPtr NativeFieldInfoPtr_style;

	private static readonly System.IntPtr NativeFieldInfoPtr_hasHorizontalCursorPos;

	private static readonly System.IntPtr NativeFieldInfoPtr_isPasswordField;

	private static readonly System.IntPtr NativeFieldInfoPtr_scrollOffset;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_TextWithWhitespace;

	private static readonly System.IntPtr NativeFieldInfoPtr__position_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr_graphicalCursorPos;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastCursorPos;

	private static readonly System.IntPtr NativeFieldInfoPtr_previousContentSize;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_showCursor_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_text_Public_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_text_Public_set_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_textWithWhitespace_Internal_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_textWithWhitespace_Internal_set_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_position_Public_get_Rect_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnTextChangedHandle_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnContentTextChangedHandle_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateTextHandle_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateScrollOffset_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnCursorIndexChange_Internal_Virtual_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnSelectIndexChange_Internal_Virtual_New_Void_0;

	public unsafe GUIContent m_Content
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Content);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GUIContent>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Content)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe TextSelectingUtilities m_TextSelecting
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TextSelecting);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TextSelectingUtilities>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TextSelecting)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe TextEditingUtilities m_TextEditing
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TextEditing);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TextEditingUtilities>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TextEditing)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe IMGUITextHandle m_TextHandle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TextHandle);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IMGUITextHandle>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TextHandle)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe TouchScreenKeyboard keyboardOnScreen
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_keyboardOnScreen);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TouchScreenKeyboard>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_keyboardOnScreen)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe int controlID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_controlID);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_controlID)) = value;
		}
	}

	public unsafe GUIStyle style
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_style);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_style)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
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

	public unsafe bool isPasswordField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isPasswordField);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isPasswordField)) = value;
		}
	}

	public unsafe Vector2 scrollOffset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_scrollOffset);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_scrollOffset)) = value;
		}
	}

	public unsafe string m_TextWithWhitespace
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TextWithWhitespace);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TextWithWhitespace)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe Rect _position_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__position_k__BackingField);
			return *(Rect*)num;
		}
		set
		{
			*(Rect*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__position_k__BackingField)) = value;
		}
	}

	public unsafe Vector2 graphicalCursorPos
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_graphicalCursorPos);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_graphicalCursorPos)) = value;
		}
	}

	public unsafe Vector2 lastCursorPos
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastCursorPos);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastCursorPos)) = value;
		}
	}

	public unsafe Vector2 previousContentSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_previousContentSize);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_previousContentSize)) = value;
		}
	}

	public unsafe bool showCursor
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_showCursor_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			m_TextSelecting.revealCursor = value;
		}
	}

	public unsafe string text
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_text_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1249644, XrefRangeEnd = 1249651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	public unsafe string textWithWhitespace
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1249651, XrefRangeEnd = 1249656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_textWithWhitespace_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1249662, RefRangeEnd = 1249666, XrefRangeStart = 1249656, XrefRangeEnd = 1249662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_textWithWhitespace_Internal_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe Rect position
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_position_Public_get_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Rect*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			_position_k__BackingField = value;
		}
	}

	public bool isMultiline
	{
		get
		{
			return m_TextEditing.multiline;
		}
		set
		{
			m_TextEditing.multiline = value;
		}
	}

	public bool hasHorizontalCursor
	{
		get
		{
			return m_TextSelecting.hasHorizontalCursorPos;
		}
		set
		{
			m_TextSelecting.hasHorizontalCursorPos = value;
		}
	}

	public bool m_HasFocus
	{
		get
		{
			throw new System.NotSupportedException("Method unstripping failed");
		}
		set
		{
			throw new System.NotSupportedException("Method unstripping failed");
		}
	}

	public GUIContent content
	{
		get
		{
			throw new Il2CppSystem.NotImplementedException("Please use 'text' instead of 'content'");
		}
		set
		{
			throw new Il2CppSystem.NotImplementedException("Please use 'text' instead of 'content'");
		}
	}

	public virtual Rect localPosition => style.padding.Remove(position);

	public int cursorIndex
	{
		get
		{
			return m_TextSelecting.cursorIndex;
		}
		set
		{
			m_TextSelecting.cursorIndex = value;
		}
	}

	public int stringCursorIndex
	{
		get
		{
			return m_TextEditing.stringCursorIndex;
		}
		set
		{
			m_TextEditing.stringCursorIndex = value;
		}
	}

	public int selectIndex
	{
		get
		{
			return m_TextSelecting.selectIndex;
		}
		set
		{
			m_TextSelecting.selectIndex = value;
		}
	}

	public int stringSelectIndex
	{
		get
		{
			return m_TextEditing.stringSelectIndex;
		}
		set
		{
			m_TextEditing.stringSelectIndex = value;
		}
	}

	public DblClickSnapping doubleClickSnapping
	{
		get
		{
			return m_TextSelecting.dblClickSnap;
		}
		set
		{
			m_TextSelecting.dblClickSnap = value;
		}
	}

	public int altCursorPosition
	{
		get
		{
			return m_TextSelecting.iAltCursorPos;
		}
		set
		{
			m_TextSelecting.iAltCursorPos = value;
		}
	}

	public bool hasSelection => m_TextSelecting.hasSelection;

	public string SelectedText => m_TextSelecting.selectedText;

	static TextEditor()
	{
		Il2CppClassPointerStore<TextEditor>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.IMGUIModule.dll", "UnityEngine", "TextEditor");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextEditor>.NativeClassPtr);
		NativeFieldInfoPtr_m_Content = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, "m_Content");
		NativeFieldInfoPtr_m_TextSelecting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, "m_TextSelecting");
		NativeFieldInfoPtr_m_TextEditing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, "m_TextEditing");
		NativeFieldInfoPtr_m_TextHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, "m_TextHandle");
		NativeFieldInfoPtr_keyboardOnScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, "keyboardOnScreen");
		NativeFieldInfoPtr_controlID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, "controlID");
		NativeFieldInfoPtr_style = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, "style");
		NativeFieldInfoPtr_hasHorizontalCursorPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, "hasHorizontalCursorPos");
		NativeFieldInfoPtr_isPasswordField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, "isPasswordField");
		NativeFieldInfoPtr_scrollOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, "scrollOffset");
		NativeFieldInfoPtr_m_TextWithWhitespace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, "m_TextWithWhitespace");
		NativeFieldInfoPtr__position_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, "<position>k__BackingField");
		NativeFieldInfoPtr_graphicalCursorPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, "graphicalCursorPos");
		NativeFieldInfoPtr_lastCursorPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, "lastCursorPos");
		NativeFieldInfoPtr_previousContentSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, "previousContentSize");
		NativeMethodInfoPtr_get_showCursor_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, 100663857);
		NativeMethodInfoPtr_get_text_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, 100663858);
		NativeMethodInfoPtr_set_text_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, 100663859);
		NativeMethodInfoPtr_get_textWithWhitespace_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, 100663860);
		NativeMethodInfoPtr_set_textWithWhitespace_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, 100663861);
		NativeMethodInfoPtr_get_position_Public_get_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, 100663862);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, 100663863);
		NativeMethodInfoPtr_OnTextChangedHandle_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, 100663864);
		NativeMethodInfoPtr_OnContentTextChangedHandle_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, 100663865);
		NativeMethodInfoPtr_UpdateTextHandle_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, 100663866);
		NativeMethodInfoPtr_UpdateScrollOffset_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, 100663867);
		NativeMethodInfoPtr_OnCursorIndexChange_Internal_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, 100663868);
		NativeMethodInfoPtr_OnSelectIndexChange_Internal_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditor>.NativeClassPtr, 100663869);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1249666, XrefRangeEnd = 1249749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TextEditor()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextEditor>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1249749, XrefRangeEnd = 1249753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnTextChangedHandle()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnTextChangedHandle_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1249753, XrefRangeEnd = 1249763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnContentTextChangedHandle()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnContentTextChangedHandle_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1249780, RefRangeEnd = 1249783, XrefRangeStart = 1249763, XrefRangeEnd = 1249780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateTextHandle()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateTextHandle_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1249807, RefRangeEnd = 1249809, XrefRangeStart = 1249783, XrefRangeEnd = 1249807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateScrollOffset()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateScrollOffset_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1249809, XrefRangeEnd = 1249810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void OnCursorIndexChange()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_OnCursorIndexChange_Internal_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void OnSelectIndexChange()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_OnSelectIndexChange_Internal_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public TextEditor(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public void OnFocus()
	{
		m_HasFocus = true;
		m_TextSelecting.OnFocus();
	}

	public void OnLostFocus()
	{
		m_HasFocus = false;
	}

	public bool HasClickedOnLink(Vector2 mousePosition, out string linkData)
	{
		Vector2 vector = mousePosition + scrollOffset;
		linkData = "";
		int num = m_TextHandle.FindIntersectingLink(vector - new Vector2(position.x, position.y));
		if (num < 0)
		{
			return false;
		}
		LinkInfo linkInfo = ((Il2CppArrayBase<LinkInfo>)(object)m_TextHandle.textInfo.linkInfo)[num];
		if (linkInfo.linkId != null && linkInfo.linkIdLength > 0)
		{
			linkData = new string(linkInfo.linkId);
			return true;
		}
		return false;
	}

	public bool HasClickedOnHREF(Vector2 mousePosition, out string href)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public bool HandleKeyEvent(Event e)
	{
		return m_TextEditing.HandleKeyEvent(e) || m_TextSelecting.HandleKeyEvent(e);
	}

	public bool DeleteLineBack()
	{
		return m_TextEditing.DeleteLineBack();
	}

	public bool DeleteWordBack()
	{
		return m_TextEditing.DeleteWordBack();
	}

	public bool DeleteWordForward()
	{
		return m_TextEditing.DeleteWordForward();
	}

	public bool Delete()
	{
		return m_TextEditing.Delete();
	}

	public bool CanPaste()
	{
		return m_TextEditing.CanPaste();
	}

	public bool Backspace()
	{
		return m_TextEditing.Backspace();
	}

	public void SelectAll()
	{
		m_TextSelecting.SelectAll();
	}

	public void SelectNone()
	{
		m_TextSelecting.SelectNone();
	}

	public bool DeleteSelection()
	{
		return m_TextEditing.DeleteSelection();
	}

	public void ReplaceSelection(string replace)
	{
		m_TextEditing.ReplaceSelection(replace);
	}

	public void Insert(char c)
	{
		m_TextEditing.Insert(c);
	}

	public void MoveSelectionToAltCursor()
	{
		m_TextEditing.MoveSelectionToAltCursor();
	}

	public void MoveRight()
	{
		m_TextSelecting.MoveRight();
	}

	public void MoveLeft()
	{
		m_TextSelecting.MoveLeft();
	}

	public void MoveUp()
	{
		m_TextSelecting.MoveUp();
	}

	public void MoveDown()
	{
		m_TextSelecting.MoveDown();
	}

	public void MoveLineStart()
	{
		m_TextSelecting.MoveLineStart();
	}

	public void MoveLineEnd()
	{
		m_TextSelecting.MoveLineEnd();
	}

	public void MoveGraphicalLineStart()
	{
		m_TextSelecting.MoveGraphicalLineStart();
	}

	public void MoveGraphicalLineEnd()
	{
		m_TextSelecting.MoveGraphicalLineEnd();
	}

	public void MoveTextStart()
	{
		m_TextSelecting.MoveTextStart();
	}

	public void MoveTextEnd()
	{
		m_TextSelecting.MoveTextEnd();
	}

	public void MoveParagraphForward()
	{
		m_TextSelecting.MoveParagraphForward();
	}

	public void MoveParagraphBackward()
	{
		m_TextSelecting.MoveParagraphBackward();
	}

	public void MoveCursorToPosition(Vector2 cursorPosition)
	{
		MoveCursorToPosition_Internal(cursorPosition, Event.current.shift);
	}

	public void MoveCursorToPosition_Internal(Vector2 cursorPosition, bool shift)
	{
		m_TextSelecting.MoveCursorToPosition_Internal(GetLocalCursorPosition(cursorPosition), shift);
	}

	public void MoveAltCursorToPosition(Vector2 cursorPosition)
	{
		m_TextSelecting.MoveAltCursorToPosition(GetLocalCursorPosition(cursorPosition));
	}

	public bool IsOverSelection(Vector2 cursorPosition)
	{
		return m_TextSelecting.IsOverSelection(GetLocalCursorPosition(cursorPosition));
	}

	public void SelectToPosition(Vector2 cursorPosition)
	{
		m_TextSelecting.SelectToPosition(GetLocalCursorPosition(cursorPosition));
	}

	public Vector2 GetLocalCursorPosition(Vector2 cursorPosition)
	{
		return cursorPosition - style.Internal_GetTextRectOffset(position, m_Content, new Vector2(m_TextHandle.preferredSize.x, (m_TextHandle.preferredSize.y > 0f) ? m_TextHandle.preferredSize.y : style.lineHeight)) + scrollOffset;
	}

	public void SelectLeft()
	{
		m_TextSelecting.SelectLeft();
	}

	public void SelectRight()
	{
		m_TextSelecting.SelectRight();
	}

	public void SelectUp()
	{
		m_TextSelecting.SelectUp();
	}

	public void SelectDown()
	{
		m_TextSelecting.SelectDown();
	}

	public void SelectTextEnd()
	{
		m_TextSelecting.SelectTextEnd();
	}

	public void SelectTextStart()
	{
		m_TextSelecting.SelectTextStart();
	}

	public void MouseDragSelectsWholeWords(bool on)
	{
		m_TextSelecting.MouseDragSelectsWholeWords(on);
	}

	public void DblClickSnap(DblClickSnapping snapping)
	{
		m_TextSelecting.DblClickSnap(snapping);
	}

	public void MoveWordRight()
	{
		m_TextSelecting.MoveWordRight();
	}

	public void MoveToStartOfNextWord()
	{
		m_TextSelecting.MoveToStartOfNextWord();
	}

	public void MoveToEndOfPreviousWord()
	{
		m_TextSelecting.MoveToEndOfPreviousWord();
	}

	public void SelectToStartOfNextWord()
	{
		m_TextSelecting.SelectToStartOfNextWord();
	}

	public void SelectToEndOfPreviousWord()
	{
		m_TextSelecting.SelectToEndOfPreviousWord();
	}

	public int FindStartOfNextWord(int p)
	{
		return m_TextSelecting.FindStartOfNextWord(p);
	}

	public void MoveWordLeft()
	{
		m_TextSelecting.MoveWordLeft();
	}

	public void SelectWordRight()
	{
		m_TextSelecting.SelectWordRight();
	}

	public void SelectWordLeft()
	{
		m_TextSelecting.SelectWordLeft();
	}

	public void ExpandSelectGraphicalLineStart()
	{
		m_TextSelecting.ExpandSelectGraphicalLineStart();
	}

	public void ExpandSelectGraphicalLineEnd()
	{
		m_TextSelecting.ExpandSelectGraphicalLineEnd();
	}

	public void SelectGraphicalLineStart()
	{
		m_TextSelecting.SelectGraphicalLineStart();
	}

	public void SelectGraphicalLineEnd()
	{
		m_TextSelecting.SelectGraphicalLineEnd();
	}

	public void SelectParagraphForward()
	{
		m_TextSelecting.SelectParagraphForward();
	}

	public void SelectParagraphBackward()
	{
		m_TextSelecting.SelectParagraphBackward();
	}

	public void SelectCurrentWord()
	{
		m_TextSelecting.SelectCurrentWord();
	}

	public void SelectCurrentParagraph()
	{
		m_TextSelecting.SelectCurrentParagraph();
	}

	public void UpdateScrollOffsetIfNeeded(Event evt)
	{
		if (evt.type != EventType.Repaint && evt.type != EventType.Layout)
		{
			UpdateScrollOffset();
		}
	}

	public void DrawCursor(string newText)
	{
		string text = this.text;
		int cursorStringIndex = cursorIndex;
		if (GUIUtility.compositionString.Length > 0)
		{
			m_Content.text = Il2CppSystem.String.Concat(newText.Substring(0, cursorIndex), GUIUtility.compositionString, newText.Substring(selectIndex));
		}
		else
		{
			m_Content.text = newText;
		}
		graphicalCursorPos = style.GetCursorPixelPosition(position, m_Content, cursorStringIndex) + new Vector2(0f, style.lineHeight);
		Vector2 contentOffset = style.contentOffset;
		style.contentOffset -= scrollOffset;
		style.Internal_clipOffset = scrollOffset;
		GUIUtility.compositionCursorPos = GUIClip.UnclipToWindow(graphicalCursorPos - scrollOffset);
		if (GUIUtility.compositionString.Length > 0)
		{
			style.DrawWithTextSelection(position, m_Content, controlID, cursorIndex, cursorIndex + GUIUtility.compositionString.Length, drawSelectionAsComposition: true);
		}
		else
		{
			style.DrawWithTextSelection(position, m_Content, controlID, cursorIndex, selectIndex);
		}
		if (m_TextSelecting.iAltCursorPos != -1)
		{
			style.DrawCursor(position, m_Content, controlID, m_TextSelecting.iAltCursorPos);
		}
		style.contentOffset = contentOffset;
		style.Internal_clipOffset = Vector2.zero;
		m_Content.text = text;
	}

	public void SaveBackup()
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public void Undo()
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public bool Cut()
	{
		if (isPasswordField)
		{
			return false;
		}
		bool result = m_TextEditing.Cut();
		UpdateTextHandle();
		return result;
	}

	public void Copy()
	{
		if (!isPasswordField)
		{
			m_TextSelecting.Copy();
		}
	}

	public Il2CppStructArray<Rect> GetHyperlinksRect()
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public bool Paste()
	{
		return m_TextEditing.Paste();
	}

	public void DetectFocusChange()
	{
		OnDetectFocusChange();
	}

	public virtual void OnDetectFocusChange()
	{
		if (m_HasFocus && controlID != GUIUtility.keyboardControl)
		{
			OnLostFocus();
		}
		if (!m_HasFocus && controlID == GUIUtility.keyboardControl)
		{
			OnFocus();
		}
	}
}
