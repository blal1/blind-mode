using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Bindings;

namespace UnityEngine;

public class GUIUtility : Il2CppSystem.Object
{
	private delegate bool get_hasModalWindowDelegate();

	private delegate bool get_mouseUsedDelegate();

	private delegate void set_textFieldInputDelegate(bool value);

	private delegate bool get_manualTex2SRGBEnabledDelegate();

	private delegate void set_manualTex2SRGBEnabledDelegate(bool value);

	private delegate int GetPermanentControlIDDelegate();

	private delegate IMECompositionMode get_imeCompositionModeDelegate();

	private delegate bool GetChangedDelegate();

	private delegate void SetChangedDelegate(bool changed);

	private delegate void SetDidGUIWindowsEatLastEventDelegate(bool value);

	private delegate void get_s_EditorScreenPointOffset_InjectedDelegate([Out] System.IntPtr ret);

	private delegate void set_s_EditorScreenPointOffset_InjectedDelegate([In] System.IntPtr value);

	private delegate void get_compositionCursorPos_InjectedDelegate([Out] System.IntPtr ret);

	private delegate void Internal_MultiplyPoint_InjectedDelegate([In] System.IntPtr point, [In] System.IntPtr transform, [Out] System.IntPtr ret);

	private delegate System.IntPtr Internal_GetBuiltinSkin_InjectedDelegate(int skin);

	private delegate void InternalWindowToScreenPoint_InjectedDelegate([In] System.IntPtr windowPoint, [Out] System.IntPtr ret);

	private delegate void InternalScreenToWindowPoint_InjectedDelegate([In] System.IntPtr screenPoint, [Out] System.IntPtr ret);

	private static readonly System.IntPtr NativeFieldInfoPtr_s_ControlCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_SkinMode;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_OriginalID;

	private static readonly System.IntPtr NativeFieldInfoPtr_takeCapture;

	private static readonly System.IntPtr NativeFieldInfoPtr_releaseCapture;

	private static readonly System.IntPtr NativeFieldInfoPtr_processEvent;

	private static readonly System.IntPtr NativeFieldInfoPtr_cleanupRoots;

	private static readonly System.IntPtr NativeFieldInfoPtr_endContainerGUIFromException;

	private static readonly System.IntPtr NativeFieldInfoPtr_guiChanged;

	private static readonly System.IntPtr NativeFieldInfoPtr_beforeEventProcessed;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Event;

	private static readonly System.IntPtr NativeFieldInfoPtr__guiIsExiting_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_HasCurrentWindowKeyFocusFunc;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_pixelsPerPoint_Internal_Static_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_pixelsPerPoint_Internal_Static_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_guiDepth_Internal_Static_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_mouseUsed_Internal_Static_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_textFieldInput_Internal_Static_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_systemCopyBuffer_Public_Static_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_systemCopyBuffer_Public_Static_set_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_GetControlID_Private_Static_Int32_Int32_FocusType_Rect_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetControlID_Public_Static_Int32_Int32_FocusType_Rect_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BeginContainerFromOwner_Internal_Static_Void_ScriptableObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BeginContainer_Internal_Static_Void_ObjectGUIState_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_EndContainer_Internal_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckForTabEvent_Internal_Static_Int32_Event_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetKeyboardControlToFirstControlId_Internal_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetKeyboardControlToLastControlId_Internal_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasFocusableControls_Internal_Static_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OwnsId_Internal_Static_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AlignRectToDevice_Public_Static_Rect_Rect_byref_Int32_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_compositionString_Internal_Static_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_imeCompositionMode_Internal_Static_set_Void_IMECompositionMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_compositionCursorPos_Internal_Static_set_Void_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_GetHotControl_Private_Static_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_GetKeyboardControl_Private_Static_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_SetHotControl_Private_Static_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_SetKeyboardControl_Private_Static_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_GetDefaultSkin_Private_Static_Object_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_ExitGUI_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MarkGUIChanged_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetControlID_Public_Static_Int32_Int32_FocusType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_guiIsExiting_Internal_Static_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_hotControl_Public_Static_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_hotControl_Public_Static_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TakeCapture_Internal_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveCapture_Internal_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_keyboardControl_Public_Static_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_keyboardControl_Public_Static_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasKeyFocus_Internal_Static_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ExitGUI_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDefaultSkin_Internal_Static_GUISkin_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ProcessEvent_Internal_Static_Void_Int32_IntPtr_byref_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EndContainer_Internal_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BeginGUI_Internal_Static_Void_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DestroyGUI_Internal_Static_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EndGUI_Internal_Static_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EndGUIFromException_Internal_Static_Boolean_Exception_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EndContainerGUIFromException_Internal_Static_Boolean_Exception_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResetGlobalState_Internal_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsExitGUIException_Internal_Static_Boolean_Exception_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ShouldRethrowException_Internal_Static_Boolean_Exception_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckOnGUI_Internal_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RoundToPixelGrid_Internal_Static_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AlignRectToDevice_Public_Static_Rect_Rect_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HitTest_Internal_Static_Boolean_Rect_Vector2_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HitTest_Internal_Static_Boolean_Rect_Vector2_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HitTest_Internal_Static_Boolean_Rect_Event_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_systemCopyBuffer_Injected_Private_Static_Void_byref_ManagedSpanWrapper_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_systemCopyBuffer_Injected_Private_Static_Void_byref_ManagedSpanWrapper_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_GetControlID_Injected_Private_Static_Int32_Int32_FocusType_byref_Rect_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BeginContainerFromOwner_Injected_Private_Static_Void_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BeginContainer_Injected_Private_Static_Void_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckForTabEvent_Injected_Private_Static_Int32_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AlignRectToDevice_Injected_Private_Static_Void_byref_Rect_byref_Int32_byref_Int32_byref_Rect_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_compositionString_Injected_Private_Static_Void_byref_ManagedSpanWrapper_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_compositionCursorPos_Injected_Private_Static_Void_byref_Vector2_0;

	private static readonly get_hasModalWindowDelegate get_hasModalWindowDelegateField;

	private static readonly get_mouseUsedDelegate get_mouseUsedDelegateField;

	private static readonly set_textFieldInputDelegate set_textFieldInputDelegateField;

	private static readonly get_manualTex2SRGBEnabledDelegate get_manualTex2SRGBEnabledDelegateField;

	private static readonly set_manualTex2SRGBEnabledDelegate set_manualTex2SRGBEnabledDelegateField;

	private static readonly GetPermanentControlIDDelegate GetPermanentControlIDDelegateField;

	private static readonly get_imeCompositionModeDelegate get_imeCompositionModeDelegateField;

	private static readonly GetChangedDelegate GetChangedDelegateField;

	private static readonly SetChangedDelegate SetChangedDelegateField;

	private static readonly SetDidGUIWindowsEatLastEventDelegate SetDidGUIWindowsEatLastEventDelegateField;

	private static readonly get_s_EditorScreenPointOffset_InjectedDelegate get_s_EditorScreenPointOffset_InjectedDelegateField;

	private static readonly set_s_EditorScreenPointOffset_InjectedDelegate set_s_EditorScreenPointOffset_InjectedDelegateField;

	private static readonly get_compositionCursorPos_InjectedDelegate get_compositionCursorPos_InjectedDelegateField;

	private static readonly Internal_MultiplyPoint_InjectedDelegate Internal_MultiplyPoint_InjectedDelegateField;

	private static readonly Internal_GetBuiltinSkin_InjectedDelegate Internal_GetBuiltinSkin_InjectedDelegateField;

	private static readonly InternalWindowToScreenPoint_InjectedDelegate InternalWindowToScreenPoint_InjectedDelegateField;

	private static readonly InternalScreenToWindowPoint_InjectedDelegate InternalScreenToWindowPoint_InjectedDelegateField;

	public unsafe static int s_ControlCount
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_ControlCount, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_ControlCount, (void*)(&value));
		}
	}

	public unsafe static int s_SkinMode
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_SkinMode, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_SkinMode, (void*)(&value));
		}
	}

	public unsafe static int s_OriginalID
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_OriginalID, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_OriginalID, (void*)(&value));
		}
	}

	public unsafe static Il2CppSystem.Action takeCapture
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_takeCapture, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_takeCapture, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppSystem.Action releaseCapture
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_releaseCapture, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_releaseCapture, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppSystem.Func<int, System.IntPtr, bool> processEvent
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_processEvent, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<int, System.IntPtr, bool>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_processEvent, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppSystem.Action cleanupRoots
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_cleanupRoots, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_cleanupRoots, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppSystem.Func<Il2CppSystem.Exception, bool> endContainerGUIFromException
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_endContainerGUIFromException, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<Il2CppSystem.Exception, bool>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_endContainerGUIFromException, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppSystem.Action guiChanged
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_guiChanged, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_guiChanged, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppSystem.Action<EventType, KeyCode, EventModifiers> beforeEventProcessed
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_beforeEventProcessed, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<EventType, KeyCode, EventModifiers>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_beforeEventProcessed, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Event m_Event
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_Event, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Event>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_Event, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static bool _guiIsExiting_k__BackingField
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__guiIsExiting_k__BackingField, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__guiIsExiting_k__BackingField, (void*)(&value));
		}
	}

	public unsafe static Il2CppSystem.Func<bool> s_HasCurrentWindowKeyFocusFunc
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_HasCurrentWindowKeyFocusFunc, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<bool>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_HasCurrentWindowKeyFocusFunc, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static float pixelsPerPoint
	{
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1247809, RefRangeEnd = 1247817, XrefRangeStart = 1247807, XrefRangeEnd = 1247809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_pixelsPerPoint_Internal_Static_get_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1247819, RefRangeEnd = 1247821, XrefRangeStart = 1247817, XrefRangeEnd = 1247819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_pixelsPerPoint_Internal_Static_set_Void_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe static int guiDepth
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1247823, RefRangeEnd = 1247824, XrefRangeStart = 1247821, XrefRangeEnd = 1247823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_guiDepth_Internal_Static_get_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static bool mouseUsed
	{
		get
		{
			return get_mouseUsedDelegateField();
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1247824, XrefRangeEnd = 1247826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_mouseUsed_Internal_Static_set_Void_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe static bool textFieldInput
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1247826, XrefRangeEnd = 1247828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_textFieldInput_Internal_Static_get_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			set_textFieldInputDelegateField(value);
		}
	}

	public unsafe static string systemCopyBuffer
	{
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1247836, RefRangeEnd = 1247840, XrefRangeStart = 1247828, XrefRangeEnd = 1247836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_systemCopyBuffer_Public_Static_get_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1247857, RefRangeEnd = 1247860, XrefRangeStart = 1247840, XrefRangeEnd = 1247857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_systemCopyBuffer_Public_Static_set_Void_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe static string compositionString
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1247924, RefRangeEnd = 1247927, XrefRangeStart = 1247916, XrefRangeEnd = 1247924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_compositionString_Internal_Static_get_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
	}

	public unsafe static IMECompositionMode imeCompositionMode
	{
		get
		{
			return get_imeCompositionModeDelegateField();
		}
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1247929, RefRangeEnd = 1247933, XrefRangeStart = 1247927, XrefRangeEnd = 1247929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_imeCompositionMode_Internal_Static_set_Void_IMECompositionMode_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe static Vector2 compositionCursorPos
	{
		get
		{
			get_compositionCursorPos_Injected(out var ret);
			return ret;
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1247938, RefRangeEnd = 1247939, XrefRangeStart = 1247933, XrefRangeEnd = 1247938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_compositionCursorPos_Internal_Static_set_Void_Vector2_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe static bool guiIsExiting
	{
		get
		{
			return _guiIsExiting_k__BackingField;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1247962, XrefRangeEnd = 1247966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_guiIsExiting_Internal_Static_set_Void_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe static int hotControl
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1247971, RefRangeEnd = 1247973, XrefRangeStart = 1247966, XrefRangeEnd = 1247971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_hotControl_Public_Static_get_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1247978, RefRangeEnd = 1247981, XrefRangeStart = 1247973, XrefRangeEnd = 1247978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_hotControl_Public_Static_set_Void_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe static int keyboardControl
	{
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1247994, RefRangeEnd = 1248000, XrefRangeStart = 1247989, XrefRangeEnd = 1247994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_keyboardControl_Public_Static_get_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1248005, RefRangeEnd = 1248006, XrefRangeStart = 1248000, XrefRangeEnd = 1248005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_keyboardControl_Public_Static_set_Void_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public static bool hasModalWindow => get_hasModalWindowDelegateField();

	public static Vector2 s_EditorScreenPointOffset
	{
		get
		{
			get_s_EditorScreenPointOffset_Injected(out var ret);
			return ret;
		}
		set
		{
			set_s_EditorScreenPointOffset_Injected(ref value);
		}
	}

	public static bool manualTex2SRGBEnabled
	{
		get
		{
			return get_manualTex2SRGBEnabledDelegateField();
		}
		set
		{
			set_manualTex2SRGBEnabledDelegateField(value);
		}
	}

	static GUIUtility()
	{
		Il2CppClassPointerStore<GUIUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.IMGUIModule.dll", "UnityEngine", "GUIUtility");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr);
		NativeFieldInfoPtr_s_ControlCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, "s_ControlCount");
		NativeFieldInfoPtr_s_SkinMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, "s_SkinMode");
		NativeFieldInfoPtr_s_OriginalID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, "s_OriginalID");
		NativeFieldInfoPtr_takeCapture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, "takeCapture");
		NativeFieldInfoPtr_releaseCapture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, "releaseCapture");
		NativeFieldInfoPtr_processEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, "processEvent");
		NativeFieldInfoPtr_cleanupRoots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, "cleanupRoots");
		NativeFieldInfoPtr_endContainerGUIFromException = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, "endContainerGUIFromException");
		NativeFieldInfoPtr_guiChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, "guiChanged");
		NativeFieldInfoPtr_beforeEventProcessed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, "beforeEventProcessed");
		NativeFieldInfoPtr_m_Event = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, "m_Event");
		NativeFieldInfoPtr__guiIsExiting_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, "<guiIsExiting>k__BackingField");
		NativeFieldInfoPtr_s_HasCurrentWindowKeyFocusFunc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, "s_HasCurrentWindowKeyFocusFunc");
		NativeMethodInfoPtr_get_pixelsPerPoint_Internal_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663683);
		NativeMethodInfoPtr_set_pixelsPerPoint_Internal_Static_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663684);
		NativeMethodInfoPtr_get_guiDepth_Internal_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663685);
		NativeMethodInfoPtr_set_mouseUsed_Internal_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663686);
		NativeMethodInfoPtr_get_textFieldInput_Internal_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663687);
		NativeMethodInfoPtr_get_systemCopyBuffer_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663688);
		NativeMethodInfoPtr_set_systemCopyBuffer_Public_Static_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663689);
		NativeMethodInfoPtr_Internal_GetControlID_Private_Static_Int32_Int32_FocusType_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663690);
		NativeMethodInfoPtr_GetControlID_Public_Static_Int32_Int32_FocusType_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663691);
		NativeMethodInfoPtr_BeginContainerFromOwner_Internal_Static_Void_ScriptableObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663692);
		NativeMethodInfoPtr_BeginContainer_Internal_Static_Void_ObjectGUIState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663693);
		NativeMethodInfoPtr_Internal_EndContainer_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663694);
		NativeMethodInfoPtr_CheckForTabEvent_Internal_Static_Int32_Event_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663695);
		NativeMethodInfoPtr_SetKeyboardControlToFirstControlId_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663696);
		NativeMethodInfoPtr_SetKeyboardControlToLastControlId_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663697);
		NativeMethodInfoPtr_HasFocusableControls_Internal_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663698);
		NativeMethodInfoPtr_OwnsId_Internal_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663699);
		NativeMethodInfoPtr_AlignRectToDevice_Public_Static_Rect_Rect_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663700);
		NativeMethodInfoPtr_get_compositionString_Internal_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663701);
		NativeMethodInfoPtr_set_imeCompositionMode_Internal_Static_set_Void_IMECompositionMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663702);
		NativeMethodInfoPtr_set_compositionCursorPos_Internal_Static_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663703);
		NativeMethodInfoPtr_Internal_GetHotControl_Private_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663704);
		NativeMethodInfoPtr_Internal_GetKeyboardControl_Private_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663705);
		NativeMethodInfoPtr_Internal_SetHotControl_Private_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663706);
		NativeMethodInfoPtr_Internal_SetKeyboardControl_Private_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663707);
		NativeMethodInfoPtr_Internal_GetDefaultSkin_Private_Static_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663708);
		NativeMethodInfoPtr_Internal_ExitGUI_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663709);
		NativeMethodInfoPtr_MarkGUIChanged_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663710);
		NativeMethodInfoPtr_GetControlID_Public_Static_Int32_Int32_FocusType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663711);
		NativeMethodInfoPtr_set_guiIsExiting_Internal_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663712);
		NativeMethodInfoPtr_get_hotControl_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663713);
		NativeMethodInfoPtr_set_hotControl_Public_Static_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663714);
		NativeMethodInfoPtr_TakeCapture_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663715);
		NativeMethodInfoPtr_RemoveCapture_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663716);
		NativeMethodInfoPtr_get_keyboardControl_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663717);
		NativeMethodInfoPtr_set_keyboardControl_Public_Static_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663718);
		NativeMethodInfoPtr_HasKeyFocus_Internal_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663719);
		NativeMethodInfoPtr_ExitGUI_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663720);
		NativeMethodInfoPtr_GetDefaultSkin_Internal_Static_GUISkin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663721);
		NativeMethodInfoPtr_ProcessEvent_Internal_Static_Void_Int32_IntPtr_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663722);
		NativeMethodInfoPtr_EndContainer_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663723);
		NativeMethodInfoPtr_BeginGUI_Internal_Static_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663724);
		NativeMethodInfoPtr_DestroyGUI_Internal_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663725);
		NativeMethodInfoPtr_EndGUI_Internal_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663726);
		NativeMethodInfoPtr_EndGUIFromException_Internal_Static_Boolean_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663727);
		NativeMethodInfoPtr_EndContainerGUIFromException_Internal_Static_Boolean_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663728);
		NativeMethodInfoPtr_ResetGlobalState_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663729);
		NativeMethodInfoPtr_IsExitGUIException_Internal_Static_Boolean_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663730);
		NativeMethodInfoPtr_ShouldRethrowException_Internal_Static_Boolean_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663731);
		NativeMethodInfoPtr_CheckOnGUI_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663732);
		NativeMethodInfoPtr_RoundToPixelGrid_Internal_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663733);
		NativeMethodInfoPtr_AlignRectToDevice_Public_Static_Rect_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663734);
		NativeMethodInfoPtr_HitTest_Internal_Static_Boolean_Rect_Vector2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663735);
		NativeMethodInfoPtr_HitTest_Internal_Static_Boolean_Rect_Vector2_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663736);
		NativeMethodInfoPtr_HitTest_Internal_Static_Boolean_Rect_Event_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663737);
		NativeMethodInfoPtr_get_systemCopyBuffer_Injected_Private_Static_Void_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663739);
		NativeMethodInfoPtr_set_systemCopyBuffer_Injected_Private_Static_Void_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663740);
		NativeMethodInfoPtr_Internal_GetControlID_Injected_Private_Static_Int32_Int32_FocusType_byref_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663741);
		NativeMethodInfoPtr_BeginContainerFromOwner_Injected_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663742);
		NativeMethodInfoPtr_BeginContainer_Injected_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663743);
		NativeMethodInfoPtr_CheckForTabEvent_Injected_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663744);
		NativeMethodInfoPtr_AlignRectToDevice_Injected_Private_Static_Void_byref_Rect_byref_Int32_byref_Int32_byref_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663745);
		NativeMethodInfoPtr_get_compositionString_Injected_Private_Static_Void_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663746);
		NativeMethodInfoPtr_set_compositionCursorPos_Injected_Private_Static_Void_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIUtility>.NativeClassPtr, 100663747);
		get_hasModalWindowDelegateField = IL2CPP.ResolveICall<get_hasModalWindowDelegate>("UnityEngine.GUIUtility::get_hasModalWindow");
		get_mouseUsedDelegateField = IL2CPP.ResolveICall<get_mouseUsedDelegate>("UnityEngine.GUIUtility::get_mouseUsed");
		set_textFieldInputDelegateField = IL2CPP.ResolveICall<set_textFieldInputDelegate>("UnityEngine.GUIUtility::set_textFieldInput");
		get_manualTex2SRGBEnabledDelegateField = IL2CPP.ResolveICall<get_manualTex2SRGBEnabledDelegate>("UnityEngine.GUIUtility::get_manualTex2SRGBEnabled");
		set_manualTex2SRGBEnabledDelegateField = IL2CPP.ResolveICall<set_manualTex2SRGBEnabledDelegate>("UnityEngine.GUIUtility::set_manualTex2SRGBEnabled");
		GetPermanentControlIDDelegateField = IL2CPP.ResolveICall<GetPermanentControlIDDelegate>("UnityEngine.GUIUtility::GetPermanentControlID");
		get_imeCompositionModeDelegateField = IL2CPP.ResolveICall<get_imeCompositionModeDelegate>("UnityEngine.GUIUtility::get_imeCompositionMode");
		GetChangedDelegateField = IL2CPP.ResolveICall<GetChangedDelegate>("UnityEngine.GUIUtility::GetChanged");
		SetChangedDelegateField = IL2CPP.ResolveICall<SetChangedDelegate>("UnityEngine.GUIUtility::SetChanged");
		SetDidGUIWindowsEatLastEventDelegateField = IL2CPP.ResolveICall<SetDidGUIWindowsEatLastEventDelegate>("UnityEngine.GUIUtility::SetDidGUIWindowsEatLastEvent");
		get_s_EditorScreenPointOffset_InjectedDelegateField = IL2CPP.ResolveICall<get_s_EditorScreenPointOffset_InjectedDelegate>("UnityEngine.GUIUtility::get_s_EditorScreenPointOffset_Injected");
		set_s_EditorScreenPointOffset_InjectedDelegateField = IL2CPP.ResolveICall<set_s_EditorScreenPointOffset_InjectedDelegate>("UnityEngine.GUIUtility::set_s_EditorScreenPointOffset_Injected");
		get_compositionCursorPos_InjectedDelegateField = IL2CPP.ResolveICall<get_compositionCursorPos_InjectedDelegate>("UnityEngine.GUIUtility::get_compositionCursorPos_Injected");
		Internal_MultiplyPoint_InjectedDelegateField = IL2CPP.ResolveICall<Internal_MultiplyPoint_InjectedDelegate>("UnityEngine.GUIUtility::Internal_MultiplyPoint_Injected");
		Internal_GetBuiltinSkin_InjectedDelegateField = IL2CPP.ResolveICall<Internal_GetBuiltinSkin_InjectedDelegate>("UnityEngine.GUIUtility::Internal_GetBuiltinSkin_Injected");
		InternalWindowToScreenPoint_InjectedDelegateField = IL2CPP.ResolveICall<InternalWindowToScreenPoint_InjectedDelegate>("UnityEngine.GUIUtility::InternalWindowToScreenPoint_Injected");
		InternalScreenToWindowPoint_InjectedDelegateField = IL2CPP.ResolveICall<InternalScreenToWindowPoint_InjectedDelegate>("UnityEngine.GUIUtility::InternalScreenToWindowPoint_Injected");
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1247860, XrefRangeEnd = 1247865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int Internal_GetControlID(int hint, FocusType focusType, Rect rect)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&hint);
		*(FocusType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &focusType;
		*(Rect**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &rect;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_GetControlID_Private_Static_Int32_Int32_FocusType_Rect_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1247874, RefRangeEnd = 1247876, XrefRangeStart = 1247865, XrefRangeEnd = 1247874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetControlID(int hint, FocusType focusType, Rect rect)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&hint);
		*(FocusType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &focusType;
		*(Rect**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &rect;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetControlID_Public_Static_Int32_Int32_FocusType_Rect_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1247884, RefRangeEnd = 1247885, XrefRangeStart = 1247876, XrefRangeEnd = 1247884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void BeginContainerFromOwner(ScriptableObject owner)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)owner);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BeginContainerFromOwner_Internal_Static_Void_ScriptableObject_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1247891, RefRangeEnd = 1247892, XrefRangeStart = 1247885, XrefRangeEnd = 1247891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void BeginContainer(ObjectGUIState objectGUIState)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)objectGUIState);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BeginContainer_Internal_Static_Void_ObjectGUIState_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1247892, XrefRangeEnd = 1247894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Internal_EndContainer()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_EndContainer_Internal_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1247894, XrefRangeEnd = 1247900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int CheckForTabEvent(Event evt)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)evt);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckForTabEvent_Internal_Static_Int32_Event_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1247902, RefRangeEnd = 1247903, XrefRangeStart = 1247900, XrefRangeEnd = 1247902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetKeyboardControlToFirstControlId()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetKeyboardControlToFirstControlId_Internal_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1247905, RefRangeEnd = 1247906, XrefRangeStart = 1247903, XrefRangeEnd = 1247905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetKeyboardControlToLastControlId()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetKeyboardControlToLastControlId_Internal_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1247906, XrefRangeEnd = 1247908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool HasFocusableControls()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasFocusableControls_Internal_Static_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1247910, RefRangeEnd = 1247911, XrefRangeStart = 1247908, XrefRangeEnd = 1247910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool OwnsId(int id)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&id);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OwnsId_Internal_Static_Boolean_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1247911, XrefRangeEnd = 1247916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Rect AlignRectToDevice(Rect rect, out int widthInPixels, out int heightInPixels)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&rect);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref widthInPixels);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref heightInPixels);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AlignRectToDevice_Public_Static_Rect_Rect_byref_Int32_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Rect*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1247939, XrefRangeEnd = 1247941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int Internal_GetHotControl()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_GetHotControl_Private_Static_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1247941, XrefRangeEnd = 1247943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int Internal_GetKeyboardControl()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_GetKeyboardControl_Private_Static_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1247943, XrefRangeEnd = 1247945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Internal_SetHotControl(int value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_SetHotControl_Private_Static_Void_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1247945, XrefRangeEnd = 1247947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Internal_SetKeyboardControl(int value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_SetKeyboardControl_Private_Static_Void_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1247947, XrefRangeEnd = 1247949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppSystem.Object Internal_GetDefaultSkin(int skinMode)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&skinMode);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_GetDefaultSkin_Private_Static_Object_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1247949, XrefRangeEnd = 1247951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Internal_ExitGUI()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_ExitGUI_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1247951, XrefRangeEnd = 1247955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void MarkGUIChanged()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MarkGUIChanged_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1247960, RefRangeEnd = 1247962, XrefRangeStart = 1247955, XrefRangeEnd = 1247960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetControlID(int hint, FocusType focus)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&hint);
		*(FocusType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &focus;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetControlID_Public_Static_Int32_Int32_FocusType_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1247981, XrefRangeEnd = 1247985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void TakeCapture()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TakeCapture_Internal_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1247985, XrefRangeEnd = 1247989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RemoveCapture()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveCapture_Internal_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1248006, XrefRangeEnd = 1248014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool HasKeyFocus(int controlID)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&controlID);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasKeyFocus_Internal_Static_Boolean_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1248019, RefRangeEnd = 1248020, XrefRangeStart = 1248014, XrefRangeEnd = 1248019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ExitGUI()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ExitGUI_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1248020, XrefRangeEnd = 1248027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static GUISkin GetDefaultSkin()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDefaultSkin_Internal_Static_GUISkin_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<GUISkin>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1248027, XrefRangeEnd = 1248055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ProcessEvent(int instanceID, System.IntPtr nativeEventPtr, out bool result)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&instanceID);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &nativeEventPtr;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref result);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ProcessEvent_Internal_Static_Void_Int32_IntPtr_byref_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1248062, RefRangeEnd = 1248064, XrefRangeStart = 1248055, XrefRangeEnd = 1248062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void EndContainer()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EndContainer_Internal_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1248064, XrefRangeEnd = 1248097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void BeginGUI(int skinMode, int instanceID, int useGUILayout)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&skinMode);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &instanceID;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &useGUILayout;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BeginGUI_Internal_Static_Void_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1248097, XrefRangeEnd = 1248110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DestroyGUI(int instanceID)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&instanceID);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DestroyGUI_Internal_Static_Void_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1248110, XrefRangeEnd = 1248140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void EndGUI(int layoutType)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&layoutType);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EndGUI_Internal_Static_Void_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1248140, XrefRangeEnd = 1248153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool EndGUIFromException(Il2CppSystem.Exception exception)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)exception);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EndGUIFromException_Internal_Static_Boolean_Exception_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1248153, XrefRangeEnd = 1248157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool EndContainerGUIFromException(Il2CppSystem.Exception exception)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)exception);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EndContainerGUIFromException_Internal_Static_Boolean_Exception_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1248182, RefRangeEnd = 1248183, XrefRangeStart = 1248157, XrefRangeEnd = 1248182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ResetGlobalState()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetGlobalState_Internal_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1248188, RefRangeEnd = 1248190, XrefRangeStart = 1248183, XrefRangeEnd = 1248188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsExitGUIException(Il2CppSystem.Exception exception)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)exception);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsExitGUIException_Internal_Static_Boolean_Exception_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1248198, RefRangeEnd = 1248199, XrefRangeStart = 1248190, XrefRangeEnd = 1248198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool ShouldRethrowException(Il2CppSystem.Exception exception)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)exception);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShouldRethrowException_Internal_Static_Boolean_Exception_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(18)]
	[CachedScanResults(RefRangeStart = 1248204, RefRangeEnd = 1248222, XrefRangeStart = 1248199, XrefRangeEnd = 1248204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CheckOnGUI()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckOnGUI_Internal_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1248230, RefRangeEnd = 1248232, XrefRangeStart = 1248222, XrefRangeEnd = 1248230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float RoundToPixelGrid(float v)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&v);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RoundToPixelGrid_Internal_Static_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1248240, RefRangeEnd = 1248241, XrefRangeStart = 1248232, XrefRangeEnd = 1248240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Rect AlignRectToDevice(Rect rect)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&rect);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AlignRectToDevice_Public_Static_Rect_Rect_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Rect*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static bool HitTest(Rect rect, Vector2 point, int offset)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&rect);
		*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &point;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &offset;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HitTest_Internal_Static_Boolean_Rect_Vector2_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1248244, RefRangeEnd = 1248245, XrefRangeStart = 1248241, XrefRangeEnd = 1248244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool HitTest(Rect rect, Vector2 point, bool isDirectManipulationDevice)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&rect);
		*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &point;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &isDirectManipulationDevice;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HitTest_Internal_Static_Boolean_Rect_Vector2_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1248260, RefRangeEnd = 1248262, XrefRangeStart = 1248245, XrefRangeEnd = 1248260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool HitTest(Rect rect, Event evt)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&rect);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)evt);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HitTest_Internal_Static_Boolean_Rect_Event_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1248262, XrefRangeEnd = 1248264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void get_systemCopyBuffer_Injected(out ManagedSpanWrapper ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_systemCopyBuffer_Injected_Private_Static_Void_byref_ManagedSpanWrapper_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1248264, XrefRangeEnd = 1248266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_systemCopyBuffer_Injected(ref ManagedSpanWrapper value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_systemCopyBuffer_Injected_Private_Static_Void_byref_ManagedSpanWrapper_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1248266, XrefRangeEnd = 1248268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int Internal_GetControlID_Injected(int hint, FocusType focusType, [In] ref Rect rect)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&hint);
		*(FocusType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &focusType;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref rect);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_GetControlID_Injected_Private_Static_Int32_Int32_FocusType_byref_Rect_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1248268, XrefRangeEnd = 1248270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void BeginContainerFromOwner_Injected(System.IntPtr owner)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&owner);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BeginContainerFromOwner_Injected_Private_Static_Void_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1248270, XrefRangeEnd = 1248272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void BeginContainer_Injected(System.IntPtr objectGUIState)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&objectGUIState);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BeginContainer_Injected_Private_Static_Void_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1248272, XrefRangeEnd = 1248274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int CheckForTabEvent_Injected(System.IntPtr evt)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&evt);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckForTabEvent_Injected_Private_Static_Int32_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1248274, XrefRangeEnd = 1248276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void AlignRectToDevice_Injected([In] ref Rect rect, out int widthInPixels, out int heightInPixels, out Rect ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)Unsafe.AsPointer(ref rect);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref widthInPixels);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref heightInPixels);
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AlignRectToDevice_Injected_Private_Static_Void_byref_Rect_byref_Int32_byref_Int32_byref_Rect_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1248276, XrefRangeEnd = 1248278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void get_compositionString_Injected(out ManagedSpanWrapper ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_compositionString_Injected_Private_Static_Void_byref_ManagedSpanWrapper_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1248278, XrefRangeEnd = 1248280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_compositionCursorPos_Injected([In] ref Vector2 value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_compositionCursorPos_Injected_Private_Static_Void_byref_Vector2_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public GUIUtility(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public static int GetPermanentControlID()
	{
		return GetPermanentControlIDDelegateField();
	}

	public static Vector3 Internal_MultiplyPoint(Vector3 point, Matrix4x4 transform)
	{
		Internal_MultiplyPoint_Injected(ref point, ref transform, out var ret);
		return ret;
	}

	public static bool GetChanged()
	{
		return GetChangedDelegateField();
	}

	public static void SetChanged(bool changed)
	{
		SetChangedDelegateField(changed);
	}

	public static void SetDidGUIWindowsEatLastEvent(bool value)
	{
		SetDidGUIWindowsEatLastEventDelegateField(value);
	}

	public static Object Internal_GetBuiltinSkin(int skin)
	{
		return Unmarshal.UnmarshalUnityObject<Object>(Internal_GetBuiltinSkin_Injected(skin));
	}

	public static Vector2 InternalWindowToScreenPoint(Vector2 windowPoint)
	{
		InternalWindowToScreenPoint_Injected(ref windowPoint, out var ret);
		return ret;
	}

	public static Vector2 InternalScreenToWindowPoint(Vector2 screenPoint)
	{
		InternalScreenToWindowPoint_Injected(ref screenPoint, out var ret);
		return ret;
	}

	public static int GetControlID(FocusType focus)
	{
		return GetControlID(0, focus);
	}

	public static int GetControlID(GUIContent contents, FocusType focus)
	{
		return GetControlID(contents.hash, focus);
	}

	public static int GetControlID(FocusType focus, Rect position)
	{
		return GetControlID(0, focus, position);
	}

	public static int GetControlID(GUIContent contents, FocusType focus, Rect position)
	{
		return GetControlID(contents.hash, focus, position);
	}

	public static Il2CppSystem.Object GetStateObject(Il2CppSystem.Type t, int controlID)
	{
		return GUIStateObjects.GetStateObject(t, controlID);
	}

	public static Il2CppSystem.Object QueryStateObject(Il2CppSystem.Type t, int controlID)
	{
		return GUIStateObjects.QueryStateObject(t, controlID);
	}

	public static GUISkin GetDefaultSkin(int skinMode)
	{
		return ((Il2CppObjectBase)Internal_GetDefaultSkin(skinMode)).TryCast<GUISkin>();
	}

	public static GUISkin GetBuiltinSkin(int skin)
	{
		return ((Il2CppObjectBase)Internal_GetBuiltinSkin(skin)).TryCast<GUISkin>();
	}

	public static void CleanupRoots()
	{
		cleanupRoots?.Invoke();
	}

	public static float RoundToPixelGrid(float v, float scale)
	{
		return Mathf.Floor(v * scale + 0.48f) / scale;
	}

	public static Vector2 GUIToScreenPoint(Vector2 guiPoint)
	{
		return InternalWindowToScreenPoint(GUIClip.UnclipToWindow(guiPoint));
	}

	public static Rect GUIToScreenRect(Rect guiRect)
	{
		Vector2 vector = GUIToScreenPoint(new Vector2(guiRect.x, guiRect.y));
		guiRect.x = vector.x;
		guiRect.y = vector.y;
		return guiRect;
	}

	public static Vector2 ScreenToGUIPoint(Vector2 screenPoint)
	{
		return GUIClip.ClipToWindow(InternalScreenToWindowPoint(screenPoint));
	}

	public static Rect ScreenToGUIRect(Rect screenRect)
	{
		Vector2 vector = ScreenToGUIPoint(new Vector2(screenRect.x, screenRect.y));
		screenRect.x = vector.x;
		screenRect.y = vector.y;
		return screenRect;
	}

	public static void RotateAroundPivot(float angle, Vector2 pivotPoint)
	{
		Matrix4x4 matrix = GUI.matrix;
		GUI.matrix = Matrix4x4.identity;
		Vector2 vector = GUIClip.Unclip(pivotPoint);
		Matrix4x4 matrix4x = Matrix4x4.TRS(vector, Quaternion.Euler(0f, 0f, angle), Vector3.one) * Matrix4x4.TRS(-vector, Quaternion.identity, Vector3.one);
		GUI.matrix = matrix4x * matrix;
	}

	public static void ScaleAroundPivot(Vector2 scale, Vector2 pivotPoint)
	{
		Matrix4x4 matrix = GUI.matrix;
		Vector2 vector = GUIClip.Unclip(pivotPoint);
		Matrix4x4 matrix4x = Matrix4x4.TRS(vector, Quaternion.identity, new Vector3(scale.x, scale.y, 1f)) * Matrix4x4.TRS(-vector, Quaternion.identity, Vector3.one);
		GUI.matrix = matrix4x * matrix;
	}

	public unsafe static void get_s_EditorScreenPointOffset_Injected(out Vector2 ret)
	{
		get_s_EditorScreenPointOffset_InjectedDelegateField((nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void set_s_EditorScreenPointOffset_Injected([In] ref Vector2 value)
	{
		set_s_EditorScreenPointOffset_InjectedDelegateField((nint)Unsafe.AsPointer(ref value));
	}

	public unsafe static void get_compositionCursorPos_Injected(out Vector2 ret)
	{
		get_compositionCursorPos_InjectedDelegateField((nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void Internal_MultiplyPoint_Injected([In] ref Vector3 point, [In] ref Matrix4x4 transform, out Vector3 ret)
	{
		Internal_MultiplyPoint_InjectedDelegateField((nint)Unsafe.AsPointer(ref point), (nint)Unsafe.AsPointer(ref transform), (nint)Unsafe.AsPointer(ref ret));
	}

	public static System.IntPtr Internal_GetBuiltinSkin_Injected(int skin)
	{
		return Internal_GetBuiltinSkin_InjectedDelegateField(skin);
	}

	public unsafe static void InternalWindowToScreenPoint_Injected([In] ref Vector2 windowPoint, out Vector2 ret)
	{
		InternalWindowToScreenPoint_InjectedDelegateField((nint)Unsafe.AsPointer(ref windowPoint), (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void InternalScreenToWindowPoint_Injected([In] ref Vector2 screenPoint, out Vector2 ret)
	{
		InternalScreenToWindowPoint_InjectedDelegateField((nint)Unsafe.AsPointer(ref screenPoint), (nint)Unsafe.AsPointer(ref ret));
	}
}
