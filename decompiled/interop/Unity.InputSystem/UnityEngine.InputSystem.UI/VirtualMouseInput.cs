using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.UI;

namespace UnityEngine.InputSystem.UI;

public class VirtualMouseInput : MonoBehaviour
{
	[OriginalName("Unity.InputSystem.dll", "", "CursorMode")]
	public enum CursorMode
	{
		SoftwareCursor,
		HardwareCursorIfAvailable
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CursorMode;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CursorGraphic;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CursorTransform;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CursorSpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ScrollSpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_StickAction;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_LeftButtonAction;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_MiddleButtonAction;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_RightButtonAction;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ForwardButtonAction;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_BackButtonAction;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ScrollWheelAction;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Canvas;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_VirtualMouse;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_SystemMouse;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_AfterInputUpdateDelegate;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ButtonActionTriggeredDelegate;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_LastTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_LastStickValue;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_cursorTransform_Public_get_RectTransform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_cursorTransform_Public_set_Void_RectTransform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_cursorSpeed_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_cursorSpeed_Public_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_cursorMode_Public_get_CursorMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_cursorMode_Public_set_Void_CursorMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_cursorGraphic_Public_get_Graphic_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_cursorGraphic_Public_set_Void_Graphic_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_scrollSpeed_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_scrollSpeed_Public_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_virtualMouse_Public_get_Mouse_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_stickAction_Public_get_InputActionProperty_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_stickAction_Public_set_Void_InputActionProperty_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_leftButtonAction_Public_get_InputActionProperty_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_leftButtonAction_Public_set_Void_InputActionProperty_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_rightButtonAction_Public_get_InputActionProperty_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_rightButtonAction_Public_set_Void_InputActionProperty_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_middleButtonAction_Public_get_InputActionProperty_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_middleButtonAction_Public_set_Void_InputActionProperty_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_forwardButtonAction_Public_get_InputActionProperty_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_forwardButtonAction_Public_set_Void_InputActionProperty_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_backButtonAction_Public_get_InputActionProperty_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_backButtonAction_Public_set_Void_InputActionProperty_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_scrollWheelAction_Public_get_InputActionProperty_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_scrollWheelAction_Public_set_Void_InputActionProperty_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Protected_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Protected_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryFindCanvas_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryEnableHardwareCursor_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateMotion_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnButtonActionTriggered_Private_Void_CallbackContext_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetActionCallback_Private_Static_Void_InputActionProperty_Action_1_CallbackContext_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetAction_Private_Static_Void_byref_InputActionProperty_InputActionProperty_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnAfterInputUpdate_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe CursorMode m_CursorMode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CursorMode);
			return *(CursorMode*)num;
		}
		set
		{
			*(CursorMode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CursorMode)) = value;
		}
	}

	public unsafe Graphic m_CursorGraphic
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CursorGraphic);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Graphic>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CursorGraphic)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe RectTransform m_CursorTransform
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CursorTransform);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RectTransform>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CursorTransform)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe float m_CursorSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CursorSpeed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CursorSpeed)) = value;
		}
	}

	public unsafe float m_ScrollSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ScrollSpeed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ScrollSpeed)) = value;
		}
	}

	public unsafe InputActionProperty m_StickAction
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_StickAction);
			return new InputActionProperty(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InputActionProperty>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_StickAction), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<InputActionProperty>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe InputActionProperty m_LeftButtonAction
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LeftButtonAction);
			return new InputActionProperty(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InputActionProperty>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LeftButtonAction), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<InputActionProperty>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe InputActionProperty m_MiddleButtonAction
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MiddleButtonAction);
			return new InputActionProperty(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InputActionProperty>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MiddleButtonAction), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<InputActionProperty>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe InputActionProperty m_RightButtonAction
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RightButtonAction);
			return new InputActionProperty(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InputActionProperty>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RightButtonAction), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<InputActionProperty>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe InputActionProperty m_ForwardButtonAction
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ForwardButtonAction);
			return new InputActionProperty(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InputActionProperty>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ForwardButtonAction), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<InputActionProperty>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe InputActionProperty m_BackButtonAction
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BackButtonAction);
			return new InputActionProperty(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InputActionProperty>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BackButtonAction), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<InputActionProperty>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe InputActionProperty m_ScrollWheelAction
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ScrollWheelAction);
			return new InputActionProperty(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InputActionProperty>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ScrollWheelAction), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<InputActionProperty>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe Canvas m_Canvas
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Canvas);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Canvas>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Canvas)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Mouse m_VirtualMouse
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_VirtualMouse);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Mouse>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_VirtualMouse)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Mouse m_SystemMouse
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SystemMouse);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Mouse>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SystemMouse)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppSystem.Action m_AfterInputUpdateDelegate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AfterInputUpdateDelegate);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AfterInputUpdateDelegate)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppSystem.Action<InputAction.CallbackContext> m_ButtonActionTriggeredDelegate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ButtonActionTriggeredDelegate);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<InputAction.CallbackContext>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ButtonActionTriggeredDelegate)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe double m_LastTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LastTime);
			return *(double*)num;
		}
		set
		{
			*(double*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LastTime)) = value;
		}
	}

	public unsafe Vector2 m_LastStickValue
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LastStickValue);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LastStickValue)) = value;
		}
	}

	public unsafe RectTransform cursorTransform
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 50643, RefRangeEnd = 50644, XrefRangeStart = 50643, XrefRangeEnd = 50644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_cursorTransform_Public_get_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_cursorTransform_Public_set_Void_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe float cursorSpeed
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_cursorSpeed_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 842832, RefRangeEnd = 842835, XrefRangeStart = 842832, XrefRangeEnd = 842835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_cursorSpeed_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe CursorMode cursorMode
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 63233, RefRangeEnd = 63234, XrefRangeStart = 63233, XrefRangeEnd = 63234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_cursorMode_Public_get_CursorMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(CursorMode*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1003891, XrefRangeEnd = 1003902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_cursorMode_Public_set_Void_CursorMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe Graphic cursorGraphic
	{
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 42604, RefRangeEnd = 42610, XrefRangeStart = 42604, XrefRangeEnd = 42610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_cursorGraphic_Public_get_Graphic_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Graphic>(intPtr2) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1003902, XrefRangeEnd = 1003908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_cursorGraphic_Public_set_Void_Graphic_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe float scrollSpeed
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_scrollSpeed_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_scrollSpeed_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe Mouse virtualMouse
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_virtualMouse_Public_get_Mouse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Mouse>(intPtr2) : null;
		}
	}

	public unsafe InputActionProperty stickAction
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_stickAction_Public_get_InputActionProperty_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new InputActionProperty(pointer);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1003908, XrefRangeEnd = 1003909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value));
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_stickAction_Public_set_Void_InputActionProperty_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe InputActionProperty leftButtonAction
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_leftButtonAction_Public_get_InputActionProperty_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new InputActionProperty(pointer);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1003909, XrefRangeEnd = 1003916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value));
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_leftButtonAction_Public_set_Void_InputActionProperty_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe InputActionProperty rightButtonAction
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_rightButtonAction_Public_get_InputActionProperty_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new InputActionProperty(pointer);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1003916, XrefRangeEnd = 1003923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value));
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_rightButtonAction_Public_set_Void_InputActionProperty_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe InputActionProperty middleButtonAction
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_middleButtonAction_Public_get_InputActionProperty_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new InputActionProperty(pointer);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1003923, XrefRangeEnd = 1003930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value));
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_middleButtonAction_Public_set_Void_InputActionProperty_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe InputActionProperty forwardButtonAction
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_forwardButtonAction_Public_get_InputActionProperty_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new InputActionProperty(pointer);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1003930, XrefRangeEnd = 1003937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value));
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_forwardButtonAction_Public_set_Void_InputActionProperty_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe InputActionProperty backButtonAction
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_backButtonAction_Public_get_InputActionProperty_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new InputActionProperty(pointer);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1003937, XrefRangeEnd = 1003944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value));
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_backButtonAction_Public_set_Void_InputActionProperty_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe InputActionProperty scrollWheelAction
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_scrollWheelAction_Public_get_InputActionProperty_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new InputActionProperty(pointer);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1003944, XrefRangeEnd = 1003945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value));
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_scrollWheelAction_Public_set_Void_InputActionProperty_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	static VirtualMouseInput()
	{
		Il2CppClassPointerStore<VirtualMouseInput>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.InputSystem.dll", "UnityEngine.InputSystem.UI", "VirtualMouseInput");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VirtualMouseInput>.NativeClassPtr);
		NativeFieldInfoPtr_m_CursorMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VirtualMouseInput>.NativeClassPtr, "m_CursorMode");
		NativeFieldInfoPtr_m_CursorGraphic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VirtualMouseInput>.NativeClassPtr, "m_CursorGraphic");
		NativeFieldInfoPtr_m_CursorTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VirtualMouseInput>.NativeClassPtr, "m_CursorTransform");
		NativeFieldInfoPtr_m_CursorSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VirtualMouseInput>.NativeClassPtr, "m_CursorSpeed");
		NativeFieldInfoPtr_m_ScrollSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VirtualMouseInput>.NativeClassPtr, "m_ScrollSpeed");
		NativeFieldInfoPtr_m_StickAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VirtualMouseInput>.NativeClassPtr, "m_StickAction");
		NativeFieldInfoPtr_m_LeftButtonAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VirtualMouseInput>.NativeClassPtr, "m_LeftButtonAction");
		NativeFieldInfoPtr_m_MiddleButtonAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VirtualMouseInput>.NativeClassPtr, "m_MiddleButtonAction");
		NativeFieldInfoPtr_m_RightButtonAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VirtualMouseInput>.NativeClassPtr, "m_RightButtonAction");
		NativeFieldInfoPtr_m_ForwardButtonAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VirtualMouseInput>.NativeClassPtr, "m_ForwardButtonAction");
		NativeFieldInfoPtr_m_BackButtonAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VirtualMouseInput>.NativeClassPtr, "m_BackButtonAction");
		NativeFieldInfoPtr_m_ScrollWheelAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VirtualMouseInput>.NativeClassPtr, "m_ScrollWheelAction");
		NativeFieldInfoPtr_m_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VirtualMouseInput>.NativeClassPtr, "m_Canvas");
		NativeFieldInfoPtr_m_VirtualMouse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VirtualMouseInput>.NativeClassPtr, "m_VirtualMouse");
		NativeFieldInfoPtr_m_SystemMouse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VirtualMouseInput>.NativeClassPtr, "m_SystemMouse");
		NativeFieldInfoPtr_m_AfterInputUpdateDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VirtualMouseInput>.NativeClassPtr, "m_AfterInputUpdateDelegate");
		NativeFieldInfoPtr_m_ButtonActionTriggeredDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VirtualMouseInput>.NativeClassPtr, "m_ButtonActionTriggeredDelegate");
		NativeFieldInfoPtr_m_LastTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VirtualMouseInput>.NativeClassPtr, "m_LastTime");
		NativeFieldInfoPtr_m_LastStickValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VirtualMouseInput>.NativeClassPtr, "m_LastStickValue");
		NativeMethodInfoPtr_get_cursorTransform_Public_get_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VirtualMouseInput>.NativeClassPtr, 100666892);
		NativeMethodInfoPtr_set_cursorTransform_Public_set_Void_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VirtualMouseInput>.NativeClassPtr, 100666893);
		NativeMethodInfoPtr_get_cursorSpeed_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VirtualMouseInput>.NativeClassPtr, 100666894);
		NativeMethodInfoPtr_set_cursorSpeed_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VirtualMouseInput>.NativeClassPtr, 100666895);
		NativeMethodInfoPtr_get_cursorMode_Public_get_CursorMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VirtualMouseInput>.NativeClassPtr, 100666896);
		NativeMethodInfoPtr_set_cursorMode_Public_set_Void_CursorMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VirtualMouseInput>.NativeClassPtr, 100666897);
		NativeMethodInfoPtr_get_cursorGraphic_Public_get_Graphic_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VirtualMouseInput>.NativeClassPtr, 100666898);
		NativeMethodInfoPtr_set_cursorGraphic_Public_set_Void_Graphic_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VirtualMouseInput>.NativeClassPtr, 100666899);
		NativeMethodInfoPtr_get_scrollSpeed_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VirtualMouseInput>.NativeClassPtr, 100666900);
		NativeMethodInfoPtr_set_scrollSpeed_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VirtualMouseInput>.NativeClassPtr, 100666901);
		NativeMethodInfoPtr_get_virtualMouse_Public_get_Mouse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VirtualMouseInput>.NativeClassPtr, 100666902);
		NativeMethodInfoPtr_get_stickAction_Public_get_InputActionProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VirtualMouseInput>.NativeClassPtr, 100666903);
		NativeMethodInfoPtr_set_stickAction_Public_set_Void_InputActionProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VirtualMouseInput>.NativeClassPtr, 100666904);
		NativeMethodInfoPtr_get_leftButtonAction_Public_get_InputActionProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VirtualMouseInput>.NativeClassPtr, 100666905);
		NativeMethodInfoPtr_set_leftButtonAction_Public_set_Void_InputActionProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VirtualMouseInput>.NativeClassPtr, 100666906);
		NativeMethodInfoPtr_get_rightButtonAction_Public_get_InputActionProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VirtualMouseInput>.NativeClassPtr, 100666907);
		NativeMethodInfoPtr_set_rightButtonAction_Public_set_Void_InputActionProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VirtualMouseInput>.NativeClassPtr, 100666908);
		NativeMethodInfoPtr_get_middleButtonAction_Public_get_InputActionProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VirtualMouseInput>.NativeClassPtr, 100666909);
		NativeMethodInfoPtr_set_middleButtonAction_Public_set_Void_InputActionProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VirtualMouseInput>.NativeClassPtr, 100666910);
		NativeMethodInfoPtr_get_forwardButtonAction_Public_get_InputActionProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VirtualMouseInput>.NativeClassPtr, 100666911);
		NativeMethodInfoPtr_set_forwardButtonAction_Public_set_Void_InputActionProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VirtualMouseInput>.NativeClassPtr, 100666912);
		NativeMethodInfoPtr_get_backButtonAction_Public_get_InputActionProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VirtualMouseInput>.NativeClassPtr, 100666913);
		NativeMethodInfoPtr_set_backButtonAction_Public_set_Void_InputActionProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VirtualMouseInput>.NativeClassPtr, 100666914);
		NativeMethodInfoPtr_get_scrollWheelAction_Public_get_InputActionProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VirtualMouseInput>.NativeClassPtr, 100666915);
		NativeMethodInfoPtr_set_scrollWheelAction_Public_set_Void_InputActionProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VirtualMouseInput>.NativeClassPtr, 100666916);
		NativeMethodInfoPtr_OnEnable_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VirtualMouseInput>.NativeClassPtr, 100666917);
		NativeMethodInfoPtr_OnDisable_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VirtualMouseInput>.NativeClassPtr, 100666918);
		NativeMethodInfoPtr_TryFindCanvas_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VirtualMouseInput>.NativeClassPtr, 100666919);
		NativeMethodInfoPtr_TryEnableHardwareCursor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VirtualMouseInput>.NativeClassPtr, 100666920);
		NativeMethodInfoPtr_UpdateMotion_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VirtualMouseInput>.NativeClassPtr, 100666921);
		NativeMethodInfoPtr_OnButtonActionTriggered_Private_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VirtualMouseInput>.NativeClassPtr, 100666922);
		NativeMethodInfoPtr_SetActionCallback_Private_Static_Void_InputActionProperty_Action_1_CallbackContext_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VirtualMouseInput>.NativeClassPtr, 100666923);
		NativeMethodInfoPtr_SetAction_Private_Static_Void_byref_InputActionProperty_InputActionProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VirtualMouseInput>.NativeClassPtr, 100666924);
		NativeMethodInfoPtr_OnAfterInputUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VirtualMouseInput>.NativeClassPtr, 100666925);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VirtualMouseInput>.NativeClassPtr, 100666926);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1003945, XrefRangeEnd = 1004017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnEnable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnEnable_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1004017, XrefRangeEnd = 1004058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDisable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDisable_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1004058, XrefRangeEnd = 1004063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TryFindCanvas()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryFindCanvas_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1004088, RefRangeEnd = 1004090, XrefRangeStart = 1004063, XrefRangeEnd = 1004088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TryEnableHardwareCursor()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryEnableHardwareCursor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1004125, RefRangeEnd = 1004126, XrefRangeStart = 1004090, XrefRangeEnd = 1004125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateMotion()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateMotion_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1004126, XrefRangeEnd = 1004152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnButtonActionTriggered(InputAction.CallbackContext context)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)context));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnButtonActionTriggered_Private_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1004152, XrefRangeEnd = 1004155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetActionCallback(InputActionProperty field, Il2CppSystem.Action<InputAction.CallbackContext> callback, bool install = true)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)field));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &install;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetActionCallback_Private_Static_Void_InputActionProperty_Action_1_CallbackContext_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 1004170, RefRangeEnd = 1004177, XrefRangeStart = 1004155, XrefRangeEnd = 1004170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetAction(ref InputActionProperty field, InputActionProperty value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)field);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetAction_Private_Static_Void_byref_InputActionProperty_InputActionProperty_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1004177, XrefRangeEnd = 1004178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnAfterInputUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnAfterInputUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1004178, XrefRangeEnd = 1004179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe VirtualMouseInput()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VirtualMouseInput>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public VirtualMouseInput(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
