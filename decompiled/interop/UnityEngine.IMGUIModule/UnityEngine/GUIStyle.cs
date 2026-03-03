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
using UnityEngine.TextCore.Text;

namespace UnityEngine;

[System.Serializable]
public sealed class GUIStyle : Il2CppSystem.Object
{
	public static class BindingsMarshaller : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeMethodInfoPtr_ConvertToNative_Public_Static_IntPtr_GUIStyle_0;

		static BindingsMarshaller()
		{
			Il2CppClassPointerStore<BindingsMarshaller>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, "BindingsMarshaller");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BindingsMarshaller>.NativeClassPtr);
			NativeMethodInfoPtr_ConvertToNative_Public_Static_IntPtr_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingsMarshaller>.NativeClassPtr, 100663681);
		}

		[CallerCount(0)]
		public unsafe static System.IntPtr ConvertToNative(GUIStyle guiStyle)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)guiStyle);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConvertToNative_Public_Static_IntPtr_GUIStyle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		public BindingsMarshaller(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private delegate float Internal_GetCursorFlashOffsetDelegate();

	private delegate void Internal_CleanupAllTextGeneratorDelegate();

	private delegate void set_font_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr value);

	private delegate void set_imagePosition_InjectedDelegate(System.IntPtr _unity_self, ImagePosition value);

	private delegate void set_wordWrap_InjectedDelegate(System.IntPtr _unity_self, bool value);

	private delegate void set_clipping_InjectedDelegate(System.IntPtr _unity_self, TextClipping value);

	private delegate void get_contentOffset_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr ret);

	private delegate void set_contentOffset_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr value);

	private delegate void set_fixedWidth_InjectedDelegate(System.IntPtr _unity_self, float value);

	private delegate void set_fixedHeight_InjectedDelegate(System.IntPtr _unity_self, float value);

	private delegate void set_fontSize_InjectedDelegate(System.IntPtr _unity_self, int value);

	private delegate void set_fontStyle_InjectedDelegate(System.IntPtr _unity_self, FontStyle value);

	private delegate void set_richText_InjectedDelegate(System.IntPtr _unity_self, bool value);

	private delegate bool get_isGizmo_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_isGizmo_InjectedDelegate(System.IntPtr _unity_self, bool value);

	private delegate void get_clipOffset_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr ret);

	private delegate void set_clipOffset_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr value);

	private delegate void set_Internal_clipOffset_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr value);

	private delegate System.IntPtr Internal_Copy_InjectedDelegate(System.IntPtr self, System.IntPtr other);

	private delegate void AssignStyleState_InjectedDelegate(System.IntPtr _unity_self, int idx, System.IntPtr srcStyleState);

	private delegate void AssignRectOffset_InjectedDelegate(System.IntPtr _unity_self, int idx, System.IntPtr srcRectOffset);

	private delegate void Internal_DrawCursor_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr position, System.IntPtr content, [In] System.IntPtr pos, [In] System.IntPtr cursorColor);

	private delegate void Internal_DrawWithTextSelection_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr screenRect, System.IntPtr content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus, bool drawSelectionAsComposition, [In] System.IntPtr cursorFirstPosition, [In] System.IntPtr cursorLastPosition, [In] System.IntPtr cursorColor, [In] System.IntPtr selectionColor);

	private delegate void Internal_CalcSize_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr content, [Out] System.IntPtr ret);

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Ptr;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Normal;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Hover;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Active;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Focused;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_OnNormal;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_OnHover;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_OnActive;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_OnFocused;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Border;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Padding;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Margin;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Overflow;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Name;

	private static readonly System.IntPtr NativeFieldInfoPtr_showKeyboardFocus;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_None;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_rawName_Internal_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_rawName_Internal_set_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_font_Public_get_Font_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_imagePosition_Public_get_ImagePosition_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_alignment_Public_get_TextAnchor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_alignment_Public_set_Void_TextAnchor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_wordWrap_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_clipping_Public_get_TextClipping_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_fixedWidth_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_fixedHeight_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_stretchWidth_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_stretchWidth_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_stretchHeight_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_stretchHeight_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_fontSize_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_fontStyle_Public_get_FontStyle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_richText_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Internal_clipOffset_Internal_get_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_Create_Private_Static_IntPtr_GUIStyle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_Destroy_Private_Static_Void_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetStyleStatePtr_Private_IntPtr_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRectOffsetPtr_Private_IntPtr_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_Draw_Private_Void_Rect_GUIContent_Boolean_Boolean_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_Draw2_Private_Void_Rect_GUIContent_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_CalcSizeWithConstraints_Internal_Vector2_GUIContent_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_CalcHeight_Private_Single_GUIContent_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_CalcMinMaxWidth_Private_Vector2_GUIContent_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_GetTextRectOffset_Internal_Vector2_Rect_GUIContent_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetMouseTooltip_Internal_Static_Void_String_Rect_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsTooltipActive_Internal_Static_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetDefaultFont_Internal_Static_Void_Font_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDefaultFont_Internal_Static_Font_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_DestroyTextGenerator_Internal_Static_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_name_Public_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_name_Public_set_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_normal_Public_get_GUIStyleState_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_margin_Public_get_RectOffset_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_padding_Public_get_RectOffset_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_lineHeight_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Draw_Public_Void_Rect_GUIContent_Boolean_Boolean_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Draw_Public_Void_Rect_GUIContent_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Draw_Public_Void_Rect_GUIContent_Int32_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Draw_Private_Void_Rect_GUIContent_Int32_Boolean_Boolean_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_GUIStyle_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_none_Public_Static_get_GUIStyle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCursorPixelPosition_Public_Vector2_Rect_GUIContent_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalcSizeWithConstraints_Internal_Vector2_GUIContent_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalcHeight_Public_Single_GUIContent_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPreferredSize_Internal_Vector2_String_Rect_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isHeightDependantOnWidth_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalcMinMaxWidth_Public_Void_GUIContent_byref_Single_byref_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMeshInfo_Internal_Static_Void_GUIStyle_Color_String_Rect_byref_Il2CppReferenceArray_1_MeshInfoBindings_byref_Vector2_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDimensions_Internal_Static_Void_GUIStyle_Color_String_Rect_byref_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLineHeight_Internal_Static_Void_GUIStyle_byref_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EmptyManagedCache_Internal_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_rawName_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_rawName_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_font_Injected_Private_Static_IntPtr_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_imagePosition_Injected_Private_Static_ImagePosition_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_alignment_Injected_Private_Static_TextAnchor_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_alignment_Injected_Private_Static_Void_IntPtr_TextAnchor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_wordWrap_Injected_Private_Static_Boolean_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_clipping_Injected_Private_Static_TextClipping_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_fixedWidth_Injected_Private_Static_Single_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_fixedHeight_Injected_Private_Static_Single_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_stretchWidth_Injected_Private_Static_Boolean_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_stretchWidth_Injected_Private_Static_Void_IntPtr_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_stretchHeight_Injected_Private_Static_Boolean_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_stretchHeight_Injected_Private_Static_Void_IntPtr_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_fontSize_Injected_Private_Static_Int32_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_fontStyle_Injected_Private_Static_FontStyle_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_richText_Injected_Private_Static_Boolean_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Internal_clipOffset_Injected_Private_Static_Void_IntPtr_byref_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetStyleStatePtr_Injected_Private_Static_IntPtr_IntPtr_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRectOffsetPtr_Injected_Private_Static_IntPtr_IntPtr_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_Draw_Injected_Private_Static_Void_IntPtr_byref_Rect_GUIContent_Boolean_Boolean_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_Draw2_Injected_Private_Static_Void_IntPtr_byref_Rect_GUIContent_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_CalcSizeWithConstraints_Injected_Private_Static_Void_IntPtr_GUIContent_byref_Vector2_byref_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_CalcHeight_Injected_Private_Static_Single_IntPtr_GUIContent_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_CalcMinMaxWidth_Injected_Private_Static_Void_IntPtr_GUIContent_byref_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_GetTextRectOffset_Injected_Private_Static_Void_IntPtr_byref_Rect_GUIContent_byref_Vector2_byref_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetMouseTooltip_Injected_Private_Static_Void_byref_ManagedSpanWrapper_byref_Rect_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsTooltipActive_Injected_Private_Static_Boolean_byref_ManagedSpanWrapper_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetDefaultFont_Injected_Private_Static_Void_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDefaultFont_Injected_Private_Static_IntPtr_0;

	private static readonly Internal_GetCursorFlashOffsetDelegate Internal_GetCursorFlashOffsetDelegateField;

	private static readonly Internal_CleanupAllTextGeneratorDelegate Internal_CleanupAllTextGeneratorDelegateField;

	private static readonly set_font_InjectedDelegate set_font_InjectedDelegateField;

	private static readonly set_imagePosition_InjectedDelegate set_imagePosition_InjectedDelegateField;

	private static readonly set_wordWrap_InjectedDelegate set_wordWrap_InjectedDelegateField;

	private static readonly set_clipping_InjectedDelegate set_clipping_InjectedDelegateField;

	private static readonly get_contentOffset_InjectedDelegate get_contentOffset_InjectedDelegateField;

	private static readonly set_contentOffset_InjectedDelegate set_contentOffset_InjectedDelegateField;

	private static readonly set_fixedWidth_InjectedDelegate set_fixedWidth_InjectedDelegateField;

	private static readonly set_fixedHeight_InjectedDelegate set_fixedHeight_InjectedDelegateField;

	private static readonly set_fontSize_InjectedDelegate set_fontSize_InjectedDelegateField;

	private static readonly set_fontStyle_InjectedDelegate set_fontStyle_InjectedDelegateField;

	private static readonly set_richText_InjectedDelegate set_richText_InjectedDelegateField;

	private static readonly get_isGizmo_InjectedDelegate get_isGizmo_InjectedDelegateField;

	private static readonly set_isGizmo_InjectedDelegate set_isGizmo_InjectedDelegateField;

	private static readonly get_clipOffset_InjectedDelegate get_clipOffset_InjectedDelegateField;

	private static readonly set_clipOffset_InjectedDelegate set_clipOffset_InjectedDelegateField;

	private static readonly set_Internal_clipOffset_InjectedDelegate set_Internal_clipOffset_InjectedDelegateField;

	private static readonly Internal_Copy_InjectedDelegate Internal_Copy_InjectedDelegateField;

	private static readonly AssignStyleState_InjectedDelegate AssignStyleState_InjectedDelegateField;

	private static readonly AssignRectOffset_InjectedDelegate AssignRectOffset_InjectedDelegateField;

	private static readonly Internal_DrawCursor_InjectedDelegate Internal_DrawCursor_InjectedDelegateField;

	private static readonly Internal_DrawWithTextSelection_InjectedDelegate Internal_DrawWithTextSelection_InjectedDelegateField;

	private static readonly Internal_CalcSize_InjectedDelegate Internal_CalcSize_InjectedDelegateField;

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

	public unsafe GUIStyleState m_Normal
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Normal);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GUIStyleState>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Normal)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe GUIStyleState m_Hover
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Hover);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GUIStyleState>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Hover)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe GUIStyleState m_Active
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Active);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GUIStyleState>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Active)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe GUIStyleState m_Focused
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Focused);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GUIStyleState>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Focused)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe GUIStyleState m_OnNormal
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_OnNormal);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GUIStyleState>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_OnNormal)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe GUIStyleState m_OnHover
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_OnHover);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GUIStyleState>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_OnHover)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe GUIStyleState m_OnActive
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_OnActive);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GUIStyleState>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_OnActive)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe GUIStyleState m_OnFocused
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_OnFocused);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GUIStyleState>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_OnFocused)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe RectOffset m_Border
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Border);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RectOffset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Border)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe RectOffset m_Padding
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Padding);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RectOffset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Padding)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe RectOffset m_Margin
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Margin);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RectOffset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Margin)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe RectOffset m_Overflow
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Overflow);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RectOffset>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Overflow)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe string m_Name
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Name);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Name)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static bool showKeyboardFocus
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_showKeyboardFocus, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_showKeyboardFocus, (void*)(&value));
		}
	}

	public unsafe static GUIStyle s_None
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_None, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_None, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe string rawName
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1247118, RefRangeEnd = 1247121, XrefRangeStart = 1247109, XrefRangeEnd = 1247118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_rawName_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
		[CallerCount(25)]
		[CachedScanResults(RefRangeStart = 1247139, RefRangeEnd = 1247164, XrefRangeStart = 1247121, XrefRangeEnd = 1247139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_rawName_Internal_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe Font font
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1247164, XrefRangeEnd = 1247174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_font_Public_get_Font_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Font>(intPtr2) : null;
		}
		set
		{
			System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_font_Injected(intPtr, Object.MarshalledUnityObject.Marshal(value));
		}
	}

	public unsafe ImagePosition imagePosition
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1247174, XrefRangeEnd = 1247181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_imagePosition_Public_get_ImagePosition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(ImagePosition*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_imagePosition_Injected(intPtr, value);
		}
	}

	public unsafe TextAnchor alignment
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1247188, RefRangeEnd = 1247189, XrefRangeStart = 1247181, XrefRangeEnd = 1247188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_alignment_Public_get_TextAnchor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(TextAnchor*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1247189, XrefRangeEnd = 1247196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_alignment_Public_set_Void_TextAnchor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool wordWrap
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1247203, RefRangeEnd = 1247204, XrefRangeStart = 1247196, XrefRangeEnd = 1247203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_wordWrap_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_wordWrap_Injected(intPtr, value);
		}
	}

	public unsafe TextClipping clipping
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1247204, XrefRangeEnd = 1247211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_clipping_Public_get_TextClipping_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(TextClipping*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_clipping_Injected(intPtr, value);
		}
	}

	public unsafe float fixedWidth
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1247218, RefRangeEnd = 1247219, XrefRangeStart = 1247211, XrefRangeEnd = 1247218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_fixedWidth_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_fixedWidth_Injected(intPtr, value);
		}
	}

	public unsafe float fixedHeight
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1247226, RefRangeEnd = 1247228, XrefRangeStart = 1247219, XrefRangeEnd = 1247226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_fixedHeight_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_fixedHeight_Injected(intPtr, value);
		}
	}

	public unsafe bool stretchWidth
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1247228, XrefRangeEnd = 1247235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_stretchWidth_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1247235, XrefRangeEnd = 1247242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_stretchWidth_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool stretchHeight
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1247242, XrefRangeEnd = 1247249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_stretchHeight_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1247249, XrefRangeEnd = 1247256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_stretchHeight_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe int fontSize
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1247256, XrefRangeEnd = 1247263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_fontSize_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_fontSize_Injected(intPtr, value);
		}
	}

	public unsafe FontStyle fontStyle
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1247263, XrefRangeEnd = 1247270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_fontStyle_Public_get_FontStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(FontStyle*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_fontStyle_Injected(intPtr, value);
		}
	}

	public unsafe bool richText
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1247270, XrefRangeEnd = 1247277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_richText_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_richText_Injected(intPtr, value);
		}
	}

	public unsafe Vector2 Internal_clipOffset
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1247277, XrefRangeEnd = 1247283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Internal_clipOffset_Internal_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_Internal_clipOffset_Injected(intPtr, ref value);
		}
	}

	public unsafe string name
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1247432, RefRangeEnd = 1247433, XrefRangeStart = 1247430, XrefRangeEnd = 1247432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1247433, XrefRangeEnd = 1247435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_name_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe GUIStyleState normal
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1247435, XrefRangeEnd = 1247447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_normal_Public_get_GUIStyleState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<GUIStyleState>(intPtr2) : null;
		}
		set
		{
			AssignStyleState(0, value.m_Ptr);
		}
	}

	public unsafe RectOffset margin
	{
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1247458, RefRangeEnd = 1247466, XrefRangeStart = 1247447, XrefRangeEnd = 1247458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_margin_Public_get_RectOffset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RectOffset>(intPtr2) : null;
		}
		set
		{
			AssignRectOffset(1, value.m_Ptr);
		}
	}

	public unsafe RectOffset padding
	{
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 1247477, RefRangeEnd = 1247490, XrefRangeStart = 1247466, XrefRangeEnd = 1247477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_padding_Public_get_RectOffset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RectOffset>(intPtr2) : null;
		}
		set
		{
			AssignRectOffset(2, value.m_Ptr);
		}
	}

	public unsafe float lineHeight
	{
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1247507, RefRangeEnd = 1247514, XrefRangeStart = 1247490, XrefRangeEnd = 1247507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_lineHeight_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static GUIStyle none
	{
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 1247583, RefRangeEnd = 1247598, XrefRangeStart = 1247572, XrefRangeEnd = 1247583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_none_Public_Static_get_GUIStyle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr2) : null;
		}
	}

	public unsafe bool isHeightDependantOnWidth
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1247659, RefRangeEnd = 1247660, XrefRangeStart = 1247641, XrefRangeEnd = 1247659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isHeightDependantOnWidth_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public Vector2 contentOffset
	{
		get
		{
			System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			get_contentOffset_Injected(intPtr, out var ret);
			return ret;
		}
		set
		{
			System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_contentOffset_Injected(intPtr, ref value);
		}
	}

	public bool isGizmo
	{
		get
		{
			System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_isGizmo_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_isGizmo_Injected(intPtr, value);
		}
	}

	public Vector2 clipOffset
	{
		get
		{
			System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			get_clipOffset_Injected(intPtr, out var ret);
			return ret;
		}
		set
		{
			System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_clipOffset_Injected(intPtr, ref value);
		}
	}

	public GUIStyleState hover
	{
		get
		{
			return m_Hover ?? (m_Hover = GUIStyleState.GetGUIStyleState(this, GetStyleStatePtr(1)));
		}
		set
		{
			AssignStyleState(1, value.m_Ptr);
		}
	}

	public GUIStyleState active
	{
		get
		{
			return m_Active ?? (m_Active = GUIStyleState.GetGUIStyleState(this, GetStyleStatePtr(2)));
		}
		set
		{
			AssignStyleState(2, value.m_Ptr);
		}
	}

	public GUIStyleState onNormal
	{
		get
		{
			return m_OnNormal ?? (m_OnNormal = GUIStyleState.GetGUIStyleState(this, GetStyleStatePtr(4)));
		}
		set
		{
			AssignStyleState(4, value.m_Ptr);
		}
	}

	public GUIStyleState onHover
	{
		get
		{
			return m_OnHover ?? (m_OnHover = GUIStyleState.GetGUIStyleState(this, GetStyleStatePtr(5)));
		}
		set
		{
			AssignStyleState(5, value.m_Ptr);
		}
	}

	public GUIStyleState onActive
	{
		get
		{
			return m_OnActive ?? (m_OnActive = GUIStyleState.GetGUIStyleState(this, GetStyleStatePtr(6)));
		}
		set
		{
			AssignStyleState(6, value.m_Ptr);
		}
	}

	public GUIStyleState focused
	{
		get
		{
			return m_Focused ?? (m_Focused = GUIStyleState.GetGUIStyleState(this, GetStyleStatePtr(3)));
		}
		set
		{
			AssignStyleState(3, value.m_Ptr);
		}
	}

	public GUIStyleState onFocused
	{
		get
		{
			return m_OnFocused ?? (m_OnFocused = GUIStyleState.GetGUIStyleState(this, GetStyleStatePtr(7)));
		}
		set
		{
			AssignStyleState(7, value.m_Ptr);
		}
	}

	public RectOffset border
	{
		get
		{
			return m_Border ?? (m_Border = new RectOffset(this, GetRectOffsetPtr(0)));
		}
		set
		{
			AssignRectOffset(0, value.m_Ptr);
		}
	}

	public RectOffset overflow
	{
		get
		{
			return m_Overflow ?? (m_Overflow = new RectOffset(this, GetRectOffsetPtr(3)));
		}
		set
		{
			AssignRectOffset(3, value.m_Ptr);
		}
	}

	static GUIStyle()
	{
		Il2CppClassPointerStore<GUIStyle>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.IMGUIModule.dll", "UnityEngine", "GUIStyle");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr);
		NativeFieldInfoPtr_m_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, "m_Ptr");
		NativeFieldInfoPtr_m_Normal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, "m_Normal");
		NativeFieldInfoPtr_m_Hover = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, "m_Hover");
		NativeFieldInfoPtr_m_Active = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, "m_Active");
		NativeFieldInfoPtr_m_Focused = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, "m_Focused");
		NativeFieldInfoPtr_m_OnNormal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, "m_OnNormal");
		NativeFieldInfoPtr_m_OnHover = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, "m_OnHover");
		NativeFieldInfoPtr_m_OnActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, "m_OnActive");
		NativeFieldInfoPtr_m_OnFocused = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, "m_OnFocused");
		NativeFieldInfoPtr_m_Border = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, "m_Border");
		NativeFieldInfoPtr_m_Padding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, "m_Padding");
		NativeFieldInfoPtr_m_Margin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, "m_Margin");
		NativeFieldInfoPtr_m_Overflow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, "m_Overflow");
		NativeFieldInfoPtr_m_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, "m_Name");
		NativeFieldInfoPtr_showKeyboardFocus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, "showKeyboardFocus");
		NativeFieldInfoPtr_s_None = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, "s_None");
		NativeMethodInfoPtr_get_rawName_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663592);
		NativeMethodInfoPtr_set_rawName_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663593);
		NativeMethodInfoPtr_get_font_Public_get_Font_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663594);
		NativeMethodInfoPtr_get_imagePosition_Public_get_ImagePosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663595);
		NativeMethodInfoPtr_get_alignment_Public_get_TextAnchor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663596);
		NativeMethodInfoPtr_set_alignment_Public_set_Void_TextAnchor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663597);
		NativeMethodInfoPtr_get_wordWrap_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663598);
		NativeMethodInfoPtr_get_clipping_Public_get_TextClipping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663599);
		NativeMethodInfoPtr_get_fixedWidth_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663600);
		NativeMethodInfoPtr_get_fixedHeight_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663601);
		NativeMethodInfoPtr_get_stretchWidth_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663602);
		NativeMethodInfoPtr_set_stretchWidth_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663603);
		NativeMethodInfoPtr_get_stretchHeight_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663604);
		NativeMethodInfoPtr_set_stretchHeight_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663605);
		NativeMethodInfoPtr_get_fontSize_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663606);
		NativeMethodInfoPtr_get_fontStyle_Public_get_FontStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663607);
		NativeMethodInfoPtr_get_richText_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663608);
		NativeMethodInfoPtr_get_Internal_clipOffset_Internal_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663609);
		NativeMethodInfoPtr_Internal_Create_Private_Static_IntPtr_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663610);
		NativeMethodInfoPtr_Internal_Destroy_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663611);
		NativeMethodInfoPtr_GetStyleStatePtr_Private_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663612);
		NativeMethodInfoPtr_GetRectOffsetPtr_Private_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663613);
		NativeMethodInfoPtr_Internal_Draw_Private_Void_Rect_GUIContent_Boolean_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663614);
		NativeMethodInfoPtr_Internal_Draw2_Private_Void_Rect_GUIContent_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663615);
		NativeMethodInfoPtr_Internal_CalcSizeWithConstraints_Internal_Vector2_GUIContent_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663616);
		NativeMethodInfoPtr_Internal_CalcHeight_Private_Single_GUIContent_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663617);
		NativeMethodInfoPtr_Internal_CalcMinMaxWidth_Private_Vector2_GUIContent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663618);
		NativeMethodInfoPtr_Internal_GetTextRectOffset_Internal_Vector2_Rect_GUIContent_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663619);
		NativeMethodInfoPtr_SetMouseTooltip_Internal_Static_Void_String_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663620);
		NativeMethodInfoPtr_IsTooltipActive_Internal_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663621);
		NativeMethodInfoPtr_SetDefaultFont_Internal_Static_Void_Font_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663622);
		NativeMethodInfoPtr_GetDefaultFont_Internal_Static_Font_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663623);
		NativeMethodInfoPtr_Internal_DestroyTextGenerator_Internal_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663624);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663625);
		NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663626);
		NativeMethodInfoPtr_get_name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663627);
		NativeMethodInfoPtr_set_name_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663628);
		NativeMethodInfoPtr_get_normal_Public_get_GUIStyleState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663629);
		NativeMethodInfoPtr_get_margin_Public_get_RectOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663630);
		NativeMethodInfoPtr_get_padding_Public_get_RectOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663631);
		NativeMethodInfoPtr_get_lineHeight_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663632);
		NativeMethodInfoPtr_Draw_Public_Void_Rect_GUIContent_Boolean_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663633);
		NativeMethodInfoPtr_Draw_Public_Void_Rect_GUIContent_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663634);
		NativeMethodInfoPtr_Draw_Public_Void_Rect_GUIContent_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663635);
		NativeMethodInfoPtr_Draw_Private_Void_Rect_GUIContent_Int32_Boolean_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663636);
		NativeMethodInfoPtr_op_Implicit_Public_Static_GUIStyle_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663637);
		NativeMethodInfoPtr_get_none_Public_Static_get_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663638);
		NativeMethodInfoPtr_GetCursorPixelPosition_Public_Vector2_Rect_GUIContent_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663639);
		NativeMethodInfoPtr_CalcSizeWithConstraints_Internal_Vector2_GUIContent_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663640);
		NativeMethodInfoPtr_CalcHeight_Public_Single_GUIContent_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663641);
		NativeMethodInfoPtr_GetPreferredSize_Internal_Vector2_String_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663642);
		NativeMethodInfoPtr_get_isHeightDependantOnWidth_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663643);
		NativeMethodInfoPtr_CalcMinMaxWidth_Public_Void_GUIContent_byref_Single_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663644);
		NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663645);
		NativeMethodInfoPtr_GetMeshInfo_Internal_Static_Void_GUIStyle_Color_String_Rect_byref_Il2CppReferenceArray_1_MeshInfoBindings_byref_Vector2_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663646);
		NativeMethodInfoPtr_GetDimensions_Internal_Static_Void_GUIStyle_Color_String_Rect_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663647);
		NativeMethodInfoPtr_GetLineHeight_Internal_Static_Void_GUIStyle_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663648);
		NativeMethodInfoPtr_EmptyManagedCache_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663649);
		NativeMethodInfoPtr_get_rawName_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663651);
		NativeMethodInfoPtr_set_rawName_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663652);
		NativeMethodInfoPtr_get_font_Injected_Private_Static_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663653);
		NativeMethodInfoPtr_get_imagePosition_Injected_Private_Static_ImagePosition_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663654);
		NativeMethodInfoPtr_get_alignment_Injected_Private_Static_TextAnchor_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663655);
		NativeMethodInfoPtr_set_alignment_Injected_Private_Static_Void_IntPtr_TextAnchor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663656);
		NativeMethodInfoPtr_get_wordWrap_Injected_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663657);
		NativeMethodInfoPtr_get_clipping_Injected_Private_Static_TextClipping_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663658);
		NativeMethodInfoPtr_get_fixedWidth_Injected_Private_Static_Single_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663659);
		NativeMethodInfoPtr_get_fixedHeight_Injected_Private_Static_Single_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663660);
		NativeMethodInfoPtr_get_stretchWidth_Injected_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663661);
		NativeMethodInfoPtr_set_stretchWidth_Injected_Private_Static_Void_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663662);
		NativeMethodInfoPtr_get_stretchHeight_Injected_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663663);
		NativeMethodInfoPtr_set_stretchHeight_Injected_Private_Static_Void_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663664);
		NativeMethodInfoPtr_get_fontSize_Injected_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663665);
		NativeMethodInfoPtr_get_fontStyle_Injected_Private_Static_FontStyle_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663666);
		NativeMethodInfoPtr_get_richText_Injected_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663667);
		NativeMethodInfoPtr_get_Internal_clipOffset_Injected_Private_Static_Void_IntPtr_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663668);
		NativeMethodInfoPtr_GetStyleStatePtr_Injected_Private_Static_IntPtr_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663669);
		NativeMethodInfoPtr_GetRectOffsetPtr_Injected_Private_Static_IntPtr_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663670);
		NativeMethodInfoPtr_Internal_Draw_Injected_Private_Static_Void_IntPtr_byref_Rect_GUIContent_Boolean_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663671);
		NativeMethodInfoPtr_Internal_Draw2_Injected_Private_Static_Void_IntPtr_byref_Rect_GUIContent_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663672);
		NativeMethodInfoPtr_Internal_CalcSizeWithConstraints_Injected_Private_Static_Void_IntPtr_GUIContent_byref_Vector2_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663673);
		NativeMethodInfoPtr_Internal_CalcHeight_Injected_Private_Static_Single_IntPtr_GUIContent_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663674);
		NativeMethodInfoPtr_Internal_CalcMinMaxWidth_Injected_Private_Static_Void_IntPtr_GUIContent_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663675);
		NativeMethodInfoPtr_Internal_GetTextRectOffset_Injected_Private_Static_Void_IntPtr_byref_Rect_GUIContent_byref_Vector2_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663676);
		NativeMethodInfoPtr_SetMouseTooltip_Injected_Private_Static_Void_byref_ManagedSpanWrapper_byref_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663677);
		NativeMethodInfoPtr_IsTooltipActive_Injected_Private_Static_Boolean_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663678);
		NativeMethodInfoPtr_SetDefaultFont_Injected_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663679);
		NativeMethodInfoPtr_GetDefaultFont_Injected_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr, 100663680);
		Internal_GetCursorFlashOffsetDelegateField = IL2CPP.ResolveICall<Internal_GetCursorFlashOffsetDelegate>("UnityEngine.GUIStyle::Internal_GetCursorFlashOffset");
		Internal_CleanupAllTextGeneratorDelegateField = IL2CPP.ResolveICall<Internal_CleanupAllTextGeneratorDelegate>("UnityEngine.GUIStyle::Internal_CleanupAllTextGenerator");
		set_font_InjectedDelegateField = IL2CPP.ResolveICall<set_font_InjectedDelegate>("UnityEngine.GUIStyle::set_font_Injected");
		set_imagePosition_InjectedDelegateField = IL2CPP.ResolveICall<set_imagePosition_InjectedDelegate>("UnityEngine.GUIStyle::set_imagePosition_Injected");
		set_wordWrap_InjectedDelegateField = IL2CPP.ResolveICall<set_wordWrap_InjectedDelegate>("UnityEngine.GUIStyle::set_wordWrap_Injected");
		set_clipping_InjectedDelegateField = IL2CPP.ResolveICall<set_clipping_InjectedDelegate>("UnityEngine.GUIStyle::set_clipping_Injected");
		get_contentOffset_InjectedDelegateField = IL2CPP.ResolveICall<get_contentOffset_InjectedDelegate>("UnityEngine.GUIStyle::get_contentOffset_Injected");
		set_contentOffset_InjectedDelegateField = IL2CPP.ResolveICall<set_contentOffset_InjectedDelegate>("UnityEngine.GUIStyle::set_contentOffset_Injected");
		set_fixedWidth_InjectedDelegateField = IL2CPP.ResolveICall<set_fixedWidth_InjectedDelegate>("UnityEngine.GUIStyle::set_fixedWidth_Injected");
		set_fixedHeight_InjectedDelegateField = IL2CPP.ResolveICall<set_fixedHeight_InjectedDelegate>("UnityEngine.GUIStyle::set_fixedHeight_Injected");
		set_fontSize_InjectedDelegateField = IL2CPP.ResolveICall<set_fontSize_InjectedDelegate>("UnityEngine.GUIStyle::set_fontSize_Injected");
		set_fontStyle_InjectedDelegateField = IL2CPP.ResolveICall<set_fontStyle_InjectedDelegate>("UnityEngine.GUIStyle::set_fontStyle_Injected");
		set_richText_InjectedDelegateField = IL2CPP.ResolveICall<set_richText_InjectedDelegate>("UnityEngine.GUIStyle::set_richText_Injected");
		get_isGizmo_InjectedDelegateField = IL2CPP.ResolveICall<get_isGizmo_InjectedDelegate>("UnityEngine.GUIStyle::get_isGizmo_Injected");
		set_isGizmo_InjectedDelegateField = IL2CPP.ResolveICall<set_isGizmo_InjectedDelegate>("UnityEngine.GUIStyle::set_isGizmo_Injected");
		get_clipOffset_InjectedDelegateField = IL2CPP.ResolveICall<get_clipOffset_InjectedDelegate>("UnityEngine.GUIStyle::get_clipOffset_Injected");
		set_clipOffset_InjectedDelegateField = IL2CPP.ResolveICall<set_clipOffset_InjectedDelegate>("UnityEngine.GUIStyle::set_clipOffset_Injected");
		set_Internal_clipOffset_InjectedDelegateField = IL2CPP.ResolveICall<set_Internal_clipOffset_InjectedDelegate>("UnityEngine.GUIStyle::set_Internal_clipOffset_Injected");
		Internal_Copy_InjectedDelegateField = IL2CPP.ResolveICall<Internal_Copy_InjectedDelegate>("UnityEngine.GUIStyle::Internal_Copy_Injected");
		AssignStyleState_InjectedDelegateField = IL2CPP.ResolveICall<AssignStyleState_InjectedDelegate>("UnityEngine.GUIStyle::AssignStyleState_Injected");
		AssignRectOffset_InjectedDelegateField = IL2CPP.ResolveICall<AssignRectOffset_InjectedDelegate>("UnityEngine.GUIStyle::AssignRectOffset_Injected");
		Internal_DrawCursor_InjectedDelegateField = IL2CPP.ResolveICall<Internal_DrawCursor_InjectedDelegate>("UnityEngine.GUIStyle::Internal_DrawCursor_Injected");
		Internal_DrawWithTextSelection_InjectedDelegateField = IL2CPP.ResolveICall<Internal_DrawWithTextSelection_InjectedDelegate>("UnityEngine.GUIStyle::Internal_DrawWithTextSelection_Injected");
		Internal_CalcSize_InjectedDelegateField = IL2CPP.ResolveICall<Internal_CalcSize_InjectedDelegate>("UnityEngine.GUIStyle::Internal_CalcSize_Injected");
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1247283, XrefRangeEnd = 1247285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr Internal_Create(GUIStyle self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_Create_Private_Static_IntPtr_GUIStyle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1247285, XrefRangeEnd = 1247287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Internal_Destroy(System.IntPtr self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_Destroy_Private_Static_Void_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1247287, XrefRangeEnd = 1247294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe System.IntPtr GetStyleStatePtr(int idx)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&idx);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetStyleStatePtr_Private_IntPtr_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1247294, XrefRangeEnd = 1247301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe System.IntPtr GetRectOffsetPtr(int idx)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&idx);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRectOffsetPtr_Private_IntPtr_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1247301, XrefRangeEnd = 1247307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Internal_Draw(Rect screenRect, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&screenRect);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)content);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &isHover;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &isActive;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &on;
		*(bool**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &hasKeyboardFocus;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_Draw_Private_Void_Rect_GUIContent_Boolean_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1247307, XrefRangeEnd = 1247313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Internal_Draw2(Rect position, GUIContent content, int controlID, bool on)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&position);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)content);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &controlID;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &on;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_Draw2_Private_Void_Rect_GUIContent_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1247313, XrefRangeEnd = 1247319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector2 Internal_CalcSizeWithConstraints(GUIContent content, Vector2 maxSize)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)content);
		*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxSize;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_CalcSizeWithConstraints_Internal_Vector2_GUIContent_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1247319, XrefRangeEnd = 1247326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float Internal_CalcHeight(GUIContent content, float width)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)content);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &width;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_CalcHeight_Private_Single_GUIContent_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1247326, XrefRangeEnd = 1247332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector2 Internal_CalcMinMaxWidth(GUIContent content)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)content);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_CalcMinMaxWidth_Private_Vector2_GUIContent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1247332, XrefRangeEnd = 1247338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector2 Internal_GetTextRectOffset(Rect screenRect, GUIContent content, Vector2 textSize)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&screenRect);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)content);
		*(Vector2**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &textSize;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_GetTextRectOffset_Internal_Vector2_Rect_GUIContent_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1247355, RefRangeEnd = 1247356, XrefRangeStart = 1247338, XrefRangeEnd = 1247355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetMouseTooltip(string tooltip, Rect screenRect)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(tooltip);
		*(Rect**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &screenRect;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetMouseTooltip_Internal_Static_Void_String_Rect_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1247373, RefRangeEnd = 1247374, XrefRangeStart = 1247356, XrefRangeEnd = 1247373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsTooltipActive(string tooltip)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(tooltip);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsTooltipActive_Internal_Static_Boolean_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1247374, XrefRangeEnd = 1247382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetDefaultFont(Font font)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)font);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetDefaultFont_Internal_Static_Void_Font_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1247382, XrefRangeEnd = 1247390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Font GetDefaultFont()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDefaultFont_Internal_Static_Font_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Font>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1247390, XrefRangeEnd = 1247392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Internal_DestroyTextGenerator(int meshInfoId)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&meshInfoId);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_DestroyTextGenerator_Internal_Static_Void_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(24)]
	[CachedScanResults(RefRangeStart = 1247398, RefRangeEnd = 1247422, XrefRangeStart = 1247392, XrefRangeEnd = 1247398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GUIStyle()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GUIStyle>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1247422, XrefRangeEnd = 1247430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void Finalize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1247514, XrefRangeEnd = 1247520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Draw(Rect position, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&position);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)content);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &isHover;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &isActive;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &on;
		*(bool**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &hasKeyboardFocus;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Draw_Public_Void_Rect_GUIContent_Boolean_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1247520, XrefRangeEnd = 1247521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Draw(Rect position, GUIContent content, int controlID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&position);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)content);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &controlID;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Draw_Public_Void_Rect_GUIContent_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1247545, RefRangeEnd = 1247547, XrefRangeStart = 1247521, XrefRangeEnd = 1247545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Draw(Rect position, GUIContent content, int controlID, bool on, bool hover)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&position);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)content);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &controlID;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &on;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &hover;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Draw_Public_Void_Rect_GUIContent_Int32_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1247553, RefRangeEnd = 1247556, XrefRangeStart = 1247547, XrefRangeEnd = 1247553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Draw(Rect position, GUIContent content, int controlId, bool isHover, bool isActive, bool on, bool hasKeyboardFocus)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = (nint)(&position);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)content);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &controlId;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &isHover;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &isActive;
		*(bool**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &on;
		*(bool**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &hasKeyboardFocus;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Draw_Private_Void_Rect_GUIContent_Int32_Boolean_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1247571, RefRangeEnd = 1247572, XrefRangeStart = 1247556, XrefRangeEnd = 1247571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static implicit operator GUIStyle(string str)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Implicit_Public_Static_GUIStyle_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1247626, RefRangeEnd = 1247627, XrefRangeStart = 1247598, XrefRangeEnd = 1247626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector2 GetCursorPixelPosition(Rect position, GUIContent content, int cursorStringIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&position);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)content);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &cursorStringIndex;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCursorPixelPosition_Public_Vector2_Rect_GUIContent_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1247627, XrefRangeEnd = 1247633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector2 CalcSizeWithConstraints(GUIContent content, Vector2 constraints)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)content);
		*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &constraints;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalcSizeWithConstraints_Internal_Vector2_GUIContent_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float CalcHeight(GUIContent content, float width)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)content);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &width;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalcHeight_Public_Single_GUIContent_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1247640, RefRangeEnd = 1247641, XrefRangeStart = 1247633, XrefRangeEnd = 1247640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector2 GetPreferredSize(string content, Rect rect)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(content);
		*(Rect**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &rect;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPreferredSize_Internal_Vector2_String_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1247660, XrefRangeEnd = 1247666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CalcMinMaxWidth(GUIContent content, out float minWidth, out float maxWidth)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)content);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref minWidth);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref maxWidth);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalcMinMaxWidth_Public_Void_GUIContent_byref_Single_byref_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1247666, XrefRangeEnd = 1247682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override string ToString()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1247682, XrefRangeEnd = 1247712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetMeshInfo(GUIStyle style, Color color, string content, Rect rect, ref Il2CppReferenceArray<MeshInfoBindings> meshInfos, ref Vector2 dimensions, ref int generationId)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)style);
		*(Color**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &color;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(content);
		*(Rect**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &rect;
		byte* num = (byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)meshInfos);
		*(System.IntPtr**)num = &intPtr;
		*(void**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref dimensions);
		*(void**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref generationId);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMeshInfo_Internal_Static_Void_GUIStyle_Color_String_Rect_byref_Il2CppReferenceArray_1_MeshInfoBindings_byref_Vector2_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		meshInfos = ((intPtr4 == (System.IntPtr)0) ? null : new Il2CppReferenceArray<MeshInfoBindings>(intPtr4));
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1247712, XrefRangeEnd = 1247719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetDimensions(GUIStyle style, Color color, string content, Rect rect, ref Vector2 dimensions)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)style);
		*(Color**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &color;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(content);
		*(Rect**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &rect;
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref dimensions);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDimensions_Internal_Static_Void_GUIStyle_Color_String_Rect_byref_Vector2_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1247719, XrefRangeEnd = 1247720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetLineHeight(GUIStyle style, ref float lineHeight)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)style);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref lineHeight);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLineHeight_Internal_Static_Void_GUIStyle_byref_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1247720, XrefRangeEnd = 1247735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void EmptyManagedCache()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EmptyManagedCache_Internal_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1247735, XrefRangeEnd = 1247737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void get_rawName_Injected(System.IntPtr _unity_self, out ManagedSpanWrapper ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_rawName_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1247737, XrefRangeEnd = 1247739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_rawName_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_rawName_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1247739, XrefRangeEnd = 1247741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr get_font_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_font_Injected_Private_Static_IntPtr_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1247741, XrefRangeEnd = 1247743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ImagePosition get_imagePosition_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_imagePosition_Injected_Private_Static_ImagePosition_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(ImagePosition*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1247743, XrefRangeEnd = 1247745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static TextAnchor get_alignment_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_alignment_Injected_Private_Static_TextAnchor_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(TextAnchor*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1247745, XrefRangeEnd = 1247747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_alignment_Injected(System.IntPtr _unity_self, TextAnchor value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(TextAnchor**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_alignment_Injected_Private_Static_Void_IntPtr_TextAnchor_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1247747, XrefRangeEnd = 1247749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool get_wordWrap_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_wordWrap_Injected_Private_Static_Boolean_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1247749, XrefRangeEnd = 1247751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static TextClipping get_clipping_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_clipping_Injected_Private_Static_TextClipping_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(TextClipping*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1247751, XrefRangeEnd = 1247753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float get_fixedWidth_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_fixedWidth_Injected_Private_Static_Single_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1247753, XrefRangeEnd = 1247755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float get_fixedHeight_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_fixedHeight_Injected_Private_Static_Single_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1247755, XrefRangeEnd = 1247757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool get_stretchWidth_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_stretchWidth_Injected_Private_Static_Boolean_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1247757, XrefRangeEnd = 1247759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_stretchWidth_Injected(System.IntPtr _unity_self, bool value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_stretchWidth_Injected_Private_Static_Void_IntPtr_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1247759, XrefRangeEnd = 1247761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool get_stretchHeight_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_stretchHeight_Injected_Private_Static_Boolean_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1247761, XrefRangeEnd = 1247763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_stretchHeight_Injected(System.IntPtr _unity_self, bool value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_stretchHeight_Injected_Private_Static_Void_IntPtr_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1247763, XrefRangeEnd = 1247765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int get_fontSize_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_fontSize_Injected_Private_Static_Int32_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1247765, XrefRangeEnd = 1247767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static FontStyle get_fontStyle_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_fontStyle_Injected_Private_Static_FontStyle_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(FontStyle*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1247767, XrefRangeEnd = 1247769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool get_richText_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_richText_Injected_Private_Static_Boolean_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1247769, XrefRangeEnd = 1247771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void get_Internal_clipOffset_Injected(System.IntPtr _unity_self, out Vector2 ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Internal_clipOffset_Injected_Private_Static_Void_IntPtr_byref_Vector2_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1247771, XrefRangeEnd = 1247773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr GetStyleStatePtr_Injected(System.IntPtr _unity_self, int idx)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &idx;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetStyleStatePtr_Injected_Private_Static_IntPtr_IntPtr_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1247773, XrefRangeEnd = 1247775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr GetRectOffsetPtr_Injected(System.IntPtr _unity_self, int idx)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &idx;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRectOffsetPtr_Injected_Private_Static_IntPtr_IntPtr_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1247775, XrefRangeEnd = 1247777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Internal_Draw_Injected(System.IntPtr _unity_self, [In] ref Rect screenRect, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref screenRect);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)content);
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &isHover;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &isActive;
		*(bool**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &on;
		*(bool**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &hasKeyboardFocus;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_Draw_Injected_Private_Static_Void_IntPtr_byref_Rect_GUIContent_Boolean_Boolean_Boolean_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1247777, XrefRangeEnd = 1247779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Internal_Draw2_Injected(System.IntPtr _unity_self, [In] ref Rect position, GUIContent content, int controlID, bool on)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref position);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)content);
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &controlID;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &on;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_Draw2_Injected_Private_Static_Void_IntPtr_byref_Rect_GUIContent_Int32_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1247779, XrefRangeEnd = 1247781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Internal_CalcSizeWithConstraints_Injected(System.IntPtr _unity_self, GUIContent content, [In] ref Vector2 maxSize, out Vector2 ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&_unity_self);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)content);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref maxSize);
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_CalcSizeWithConstraints_Injected_Private_Static_Void_IntPtr_GUIContent_byref_Vector2_byref_Vector2_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1247781, XrefRangeEnd = 1247783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float Internal_CalcHeight_Injected(System.IntPtr _unity_self, GUIContent content, float width)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&_unity_self);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)content);
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &width;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_CalcHeight_Injected_Private_Static_Single_IntPtr_GUIContent_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1247783, XrefRangeEnd = 1247785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Internal_CalcMinMaxWidth_Injected(System.IntPtr _unity_self, GUIContent content, out Vector2 ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&_unity_self);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)content);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_CalcMinMaxWidth_Injected_Private_Static_Void_IntPtr_GUIContent_byref_Vector2_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1247785, XrefRangeEnd = 1247787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Internal_GetTextRectOffset_Injected(System.IntPtr _unity_self, [In] ref Rect screenRect, GUIContent content, [In] ref Vector2 textSize, out Vector2 ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref screenRect);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)content);
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref textSize);
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_GetTextRectOffset_Injected_Private_Static_Void_IntPtr_byref_Rect_GUIContent_byref_Vector2_byref_Vector2_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1247787, XrefRangeEnd = 1247789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetMouseTooltip_Injected(ref ManagedSpanWrapper tooltip, [In] ref Rect screenRect)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref tooltip);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref screenRect);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetMouseTooltip_Injected_Private_Static_Void_byref_ManagedSpanWrapper_byref_Rect_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1247789, XrefRangeEnd = 1247791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsTooltipActive_Injected(ref ManagedSpanWrapper tooltip)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref tooltip);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsTooltipActive_Injected_Private_Static_Boolean_byref_ManagedSpanWrapper_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1247791, XrefRangeEnd = 1247793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetDefaultFont_Injected(System.IntPtr font)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&font);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetDefaultFont_Injected_Private_Static_Void_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1247793, XrefRangeEnd = 1247795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr GetDefaultFont_Injected()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDefaultFont_Injected_Private_Static_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public GUIStyle(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public static System.IntPtr Internal_Copy(GUIStyle self, GUIStyle other)
	{
		return Internal_Copy_Injected(self, (other == null) ? ((System.IntPtr)0) : BindingsMarshaller.ConvertToNative(other));
	}

	public void AssignStyleState(int idx, System.IntPtr srcStyleState)
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		AssignStyleState_Injected(intPtr, idx, srcStyleState);
	}

	public void AssignRectOffset(int idx, System.IntPtr srcRectOffset)
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		AssignRectOffset_Injected(intPtr, idx, srcRectOffset);
	}

	public void Internal_DrawCursor(Rect position, GUIContent content, Vector2 pos, Color cursorColor)
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		Internal_DrawCursor_Injected(intPtr, ref position, content, ref pos, ref cursorColor);
	}

	public void Internal_DrawWithTextSelection(Rect screenRect, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus, bool drawSelectionAsComposition, Vector2 cursorFirstPosition, Vector2 cursorLastPosition, Color cursorColor, Color selectionColor)
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		Internal_DrawWithTextSelection_Injected(intPtr, ref screenRect, content, isHover, isActive, on, hasKeyboardFocus, drawSelectionAsComposition, ref cursorFirstPosition, ref cursorLastPosition, ref cursorColor, ref selectionColor);
	}

	public Vector2 Internal_CalcSize(GUIContent content)
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		Internal_CalcSize_Injected(intPtr, content, out var ret);
		return ret;
	}

	public static float Internal_GetCursorFlashOffset()
	{
		return Internal_GetCursorFlashOffsetDelegateField();
	}

	public static void Internal_CleanupAllTextGenerator()
	{
		Internal_CleanupAllTextGeneratorDelegateField();
	}

	public static void CleanupRoots()
	{
		s_None = null;
	}

	public void InternalOnAfterDeserialize()
	{
		m_Normal = GUIStyleState.ProduceGUIStyleStateFromDeserialization(this, GetStyleStatePtr(0));
		m_Hover = GUIStyleState.ProduceGUIStyleStateFromDeserialization(this, GetStyleStatePtr(1));
		m_Active = GUIStyleState.ProduceGUIStyleStateFromDeserialization(this, GetStyleStatePtr(2));
		m_Focused = GUIStyleState.ProduceGUIStyleStateFromDeserialization(this, GetStyleStatePtr(3));
		m_OnNormal = GUIStyleState.ProduceGUIStyleStateFromDeserialization(this, GetStyleStatePtr(4));
		m_OnHover = GUIStyleState.ProduceGUIStyleStateFromDeserialization(this, GetStyleStatePtr(5));
		m_OnActive = GUIStyleState.ProduceGUIStyleStateFromDeserialization(this, GetStyleStatePtr(6));
		m_OnFocused = GUIStyleState.ProduceGUIStyleStateFromDeserialization(this, GetStyleStatePtr(7));
	}

	public void Draw(Rect position, bool isHover, bool isActive, bool on, bool hasKeyboardFocus)
	{
		Draw(position, GUIContent.none, -1, isHover, isActive, on, hasKeyboardFocus);
	}

	public void Draw(Rect position, string text, bool isHover, bool isActive, bool on, bool hasKeyboardFocus)
	{
		Draw(position, GUIContent.Temp(text), -1, isHover, isActive, on, hasKeyboardFocus);
	}

	public void Draw(Rect position, Texture image, bool isHover, bool isActive, bool on, bool hasKeyboardFocus)
	{
		Draw(position, GUIContent.Temp(image), -1, isHover, isActive, on, hasKeyboardFocus);
	}

	public void Draw(Rect position, GUIContent content, int controlID, bool on)
	{
		Draw(position, content, controlID, isHover: false, isActive: false, on, hasKeyboardFocus: false);
	}

	public void DrawCursor(Rect position, GUIContent content, int controlID, int character)
	{
		Event current = Event.current;
		if (current.type == EventType.Repaint)
		{
			Color cursorColor = new Color(0f, 0f, 0f, 0f);
			float cursorFlashSpeed = GUI.skin.settings.cursorFlashSpeed;
			float num = (Time.realtimeSinceStartup - Internal_GetCursorFlashOffset()) % cursorFlashSpeed / cursorFlashSpeed;
			if (cursorFlashSpeed == 0f || num < 0.5f)
			{
				cursorColor = GUI.skin.settings.cursorColor;
			}
			Internal_DrawCursor(position, content, GetCursorPixelPosition(position, content, character), cursorColor);
		}
	}

	public void DrawWithTextSelection(Rect position, GUIContent content, bool isActive, bool hasKeyboardFocus, int firstSelectedCharacter, int lastSelectedCharacter, bool drawSelectionAsComposition, Color selectionColor)
	{
		if (firstSelectedCharacter > lastSelectedCharacter)
		{
			int num = lastSelectedCharacter;
			lastSelectedCharacter = firstSelectedCharacter;
			firstSelectedCharacter = num;
		}
		Vector2 cursorPixelPosition = GetCursorPixelPosition(position, content, firstSelectedCharacter);
		Vector2 cursorPixelPosition2 = GetCursorPixelPosition(position, content, lastSelectedCharacter);
		Vector2 vector = new Vector2(Il2CppSystem.String.IsNullOrEmpty(content.text) ? 0f : 1f, 0f);
		cursorPixelPosition -= vector;
		cursorPixelPosition2 -= vector;
		Color cursorColor = new Color(0f, 0f, 0f, 0f);
		float cursorFlashSpeed = GUI.skin.settings.cursorFlashSpeed;
		float num2 = (Time.realtimeSinceStartup - Internal_GetCursorFlashOffset()) % cursorFlashSpeed / cursorFlashSpeed;
		if (cursorFlashSpeed == 0f || num2 < 0.5f)
		{
			cursorColor = GUI.skin.settings.cursorColor;
		}
		bool isHover = position.Contains(Event.current.mousePosition);
		Internal_DrawWithTextSelection(position, content, isHover, isActive, on: false, hasKeyboardFocus, drawSelectionAsComposition, cursorPixelPosition, cursorPixelPosition2, cursorColor, selectionColor);
	}

	public void DrawWithTextSelection(Rect position, GUIContent content, int controlID, int firstSelectedCharacter, int lastSelectedCharacter, bool drawSelectionAsComposition)
	{
		DrawWithTextSelection(position, content, controlID == GUIUtility.hotControl, controlID == GUIUtility.keyboardControl && showKeyboardFocus, firstSelectedCharacter, lastSelectedCharacter, drawSelectionAsComposition, GUI.skin.settings.selectionColor);
	}

	public void DrawWithTextSelection(Rect position, GUIContent content, int controlID, int firstSelectedCharacter, int lastSelectedCharacter)
	{
		DrawWithTextSelection(position, content, controlID, firstSelectedCharacter, lastSelectedCharacter, drawSelectionAsComposition: false);
	}

	public Il2CppStructArray<Rect> GetHyperlinkRects(IMGUITextHandle handle, Rect content)
	{
		content = padding.Remove(content);
		return handle.GetHyperlinkRects(content);
	}

	public int GetCursorStringIndex(Rect position, GUIContent content, Vector2 cursorPixelPosition)
	{
		return IMGUITextHandle.GetTextHandle(this, position, content.textWithWhitespace, Color.white).GetCursorIndexFromPosition(cursorPixelPosition);
	}

	public int GetNumCharactersThatFitWithinWidth(string text, float width)
	{
		return IMGUITextHandle.GetTextHandle(this, new Rect(0f, 0f, width, 1f), text, Color.white).GetNumCharactersThatFitWithinWidth(width);
	}

	public Vector2 CalcSize(GUIContent content)
	{
		return Internal_CalcSize(content);
	}

	public Vector2 CalcScreenSize(Vector2 contentSize)
	{
		return new Vector2((fixedWidth != 0f) ? fixedWidth : Mathf.Ceil(contentSize.x + (float)padding.left + (float)padding.right), (fixedHeight != 0f) ? fixedHeight : Mathf.Ceil(contentSize.y + (float)padding.top + (float)padding.bottom));
	}

	public static void set_font_Injected(System.IntPtr _unity_self, System.IntPtr value)
	{
		set_font_InjectedDelegateField(_unity_self, value);
	}

	public static void set_imagePosition_Injected(System.IntPtr _unity_self, ImagePosition value)
	{
		set_imagePosition_InjectedDelegateField(_unity_self, value);
	}

	public static void set_wordWrap_Injected(System.IntPtr _unity_self, bool value)
	{
		set_wordWrap_InjectedDelegateField(_unity_self, value);
	}

	public static void set_clipping_Injected(System.IntPtr _unity_self, TextClipping value)
	{
		set_clipping_InjectedDelegateField(_unity_self, value);
	}

	public unsafe static void get_contentOffset_Injected(System.IntPtr _unity_self, out Vector2 ret)
	{
		get_contentOffset_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void set_contentOffset_Injected(System.IntPtr _unity_self, [In] ref Vector2 value)
	{
		set_contentOffset_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref value));
	}

	public static void set_fixedWidth_Injected(System.IntPtr _unity_self, float value)
	{
		set_fixedWidth_InjectedDelegateField(_unity_self, value);
	}

	public static void set_fixedHeight_Injected(System.IntPtr _unity_self, float value)
	{
		set_fixedHeight_InjectedDelegateField(_unity_self, value);
	}

	public static void set_fontSize_Injected(System.IntPtr _unity_self, int value)
	{
		set_fontSize_InjectedDelegateField(_unity_self, value);
	}

	public static void set_fontStyle_Injected(System.IntPtr _unity_self, FontStyle value)
	{
		set_fontStyle_InjectedDelegateField(_unity_self, value);
	}

	public static void set_richText_Injected(System.IntPtr _unity_self, bool value)
	{
		set_richText_InjectedDelegateField(_unity_self, value);
	}

	public static bool get_isGizmo_Injected(System.IntPtr _unity_self)
	{
		return get_isGizmo_InjectedDelegateField(_unity_self);
	}

	public static void set_isGizmo_Injected(System.IntPtr _unity_self, bool value)
	{
		set_isGizmo_InjectedDelegateField(_unity_self, value);
	}

	public unsafe static void get_clipOffset_Injected(System.IntPtr _unity_self, out Vector2 ret)
	{
		get_clipOffset_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void set_clipOffset_Injected(System.IntPtr _unity_self, [In] ref Vector2 value)
	{
		set_clipOffset_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref value));
	}

	public unsafe static void set_Internal_clipOffset_Injected(System.IntPtr _unity_self, [In] ref Vector2 value)
	{
		set_Internal_clipOffset_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref value));
	}

	public static System.IntPtr Internal_Copy_Injected(GUIStyle self, System.IntPtr other)
	{
		return Internal_Copy_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self), other);
	}

	public static void AssignStyleState_Injected(System.IntPtr _unity_self, int idx, System.IntPtr srcStyleState)
	{
		AssignStyleState_InjectedDelegateField(_unity_self, idx, srcStyleState);
	}

	public static void AssignRectOffset_Injected(System.IntPtr _unity_self, int idx, System.IntPtr srcRectOffset)
	{
		AssignRectOffset_InjectedDelegateField(_unity_self, idx, srcRectOffset);
	}

	public unsafe static void Internal_DrawCursor_Injected(System.IntPtr _unity_self, [In] ref Rect position, GUIContent content, [In] ref Vector2 pos, [In] ref Color cursorColor)
	{
		Internal_DrawCursor_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref position), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)content), (nint)Unsafe.AsPointer(ref pos), (nint)Unsafe.AsPointer(ref cursorColor));
	}

	public unsafe static void Internal_DrawWithTextSelection_Injected(System.IntPtr _unity_self, [In] ref Rect screenRect, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus, bool drawSelectionAsComposition, [In] ref Vector2 cursorFirstPosition, [In] ref Vector2 cursorLastPosition, [In] ref Color cursorColor, [In] ref Color selectionColor)
	{
		Internal_DrawWithTextSelection_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref screenRect), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)content), isHover, isActive, on, hasKeyboardFocus, drawSelectionAsComposition, (nint)Unsafe.AsPointer(ref cursorFirstPosition), (nint)Unsafe.AsPointer(ref cursorLastPosition), (nint)Unsafe.AsPointer(ref cursorColor), (nint)Unsafe.AsPointer(ref selectionColor));
	}

	public unsafe static void Internal_CalcSize_Injected(System.IntPtr _unity_self, GUIContent content, out Vector2 ret)
	{
		Internal_CalcSize_InjectedDelegateField(_unity_self, IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)content), (nint)Unsafe.AsPointer(ref ret));
	}
}
