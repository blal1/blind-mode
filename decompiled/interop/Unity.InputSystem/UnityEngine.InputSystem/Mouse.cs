using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.LowLevel;

namespace UnityEngine.InputSystem;

public class Mouse : Pointer
{
	private static readonly IntPtr NativeFieldInfoPtr__scroll_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__leftButton_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__middleButton_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__rightButton_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__backButton_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__forwardButton_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__clickCount_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__current_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr_s_PlatformMouseDevice;

	private static readonly IntPtr NativeMethodInfoPtr_get_scroll_Public_get_DeltaControl_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_scroll_Protected_set_Void_DeltaControl_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_leftButton_Public_get_ButtonControl_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_leftButton_Protected_set_Void_ButtonControl_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_middleButton_Public_get_ButtonControl_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_middleButton_Protected_set_Void_ButtonControl_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_rightButton_Public_get_ButtonControl_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_rightButton_Protected_set_Void_ButtonControl_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_backButton_Public_get_ButtonControl_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_backButton_Protected_set_Void_ButtonControl_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_forwardButton_Public_get_ButtonControl_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_forwardButton_Protected_set_Void_ButtonControl_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_clickCount_Public_get_IntegerControl_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_clickCount_Protected_set_Void_IntegerControl_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_current_Public_Static_get_Mouse_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_current_Private_Static_set_Void_Mouse_0;

	private static readonly IntPtr NativeMethodInfoPtr_MakeCurrent_Public_Virtual_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnAdded_Protected_Virtual_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnRemoved_Protected_Virtual_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_WarpCursorPosition_Public_Void_Vector2_0;

	private static readonly IntPtr NativeMethodInfoPtr_FinishSetup_Protected_Virtual_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnNextUpdate_Protected_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnStateEvent_Protected_Void_InputEventPtr_0;

	private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_InputSystem_LowLevel_IInputStateCallbackReceiver_OnNextUpdate_Private_Virtual_Final_New_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_InputSystem_LowLevel_IInputStateCallbackReceiver_OnStateEvent_Private_Virtual_Final_New_Void_InputEventPtr_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe DeltaControl _scroll_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__scroll_k__BackingField);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<DeltaControl>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__scroll_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe ButtonControl _leftButton_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__leftButton_k__BackingField);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<ButtonControl>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__leftButton_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe ButtonControl _middleButton_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__middleButton_k__BackingField);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<ButtonControl>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__middleButton_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe ButtonControl _rightButton_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__rightButton_k__BackingField);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<ButtonControl>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__rightButton_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe ButtonControl _backButton_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__backButton_k__BackingField);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<ButtonControl>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__backButton_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe ButtonControl _forwardButton_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__forwardButton_k__BackingField);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<ButtonControl>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__forwardButton_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe IntegerControl _clickCount_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__clickCount_k__BackingField);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<IntegerControl>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__clickCount_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public new unsafe static Mouse _current_k__BackingField
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__current_k__BackingField, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<Mouse>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__current_k__BackingField, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Mouse s_PlatformMouseDevice
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_PlatformMouseDevice, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<Mouse>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_PlatformMouseDevice, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe DeltaControl scroll
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_scroll_Public_get_DeltaControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<DeltaControl>(intPtr2) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_scroll_Protected_set_Void_DeltaControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe ButtonControl leftButton
	{
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 392554, RefRangeEnd = 392564, XrefRangeStart = 392554, XrefRangeEnd = 392564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_leftButton_Public_get_ButtonControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<ButtonControl>(intPtr2) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_leftButton_Protected_set_Void_ButtonControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe ButtonControl middleButton
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_middleButton_Public_get_ButtonControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<ButtonControl>(intPtr2) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_middleButton_Protected_set_Void_ButtonControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe ButtonControl rightButton
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_rightButton_Public_get_ButtonControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<ButtonControl>(intPtr2) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_rightButton_Protected_set_Void_ButtonControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe ButtonControl backButton
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_backButton_Public_get_ButtonControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<ButtonControl>(intPtr2) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_backButton_Protected_set_Void_ButtonControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe ButtonControl forwardButton
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_forwardButton_Public_get_ButtonControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<ButtonControl>(intPtr2) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_forwardButton_Protected_set_Void_ButtonControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe IntegerControl clickCount
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_clickCount_Public_get_IntegerControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<IntegerControl>(intPtr2) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_clickCount_Protected_set_Void_IntegerControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public new unsafe static Mouse current
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 977632, XrefRangeEnd = 977634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_current_Public_Static_get_Mouse_0, (IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<Mouse>(intPtr2) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 977634, XrefRangeEnd = 977638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_current_Private_Static_set_Void_Mouse_0, (IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	static Mouse()
	{
		Il2CppClassPointerStore<Mouse>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.InputSystem.dll", "UnityEngine.InputSystem", "Mouse");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Mouse>.NativeClassPtr);
		NativeFieldInfoPtr__scroll_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mouse>.NativeClassPtr, "<scroll>k__BackingField");
		NativeFieldInfoPtr__leftButton_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mouse>.NativeClassPtr, "<leftButton>k__BackingField");
		NativeFieldInfoPtr__middleButton_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mouse>.NativeClassPtr, "<middleButton>k__BackingField");
		NativeFieldInfoPtr__rightButton_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mouse>.NativeClassPtr, "<rightButton>k__BackingField");
		NativeFieldInfoPtr__backButton_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mouse>.NativeClassPtr, "<backButton>k__BackingField");
		NativeFieldInfoPtr__forwardButton_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mouse>.NativeClassPtr, "<forwardButton>k__BackingField");
		NativeFieldInfoPtr__clickCount_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mouse>.NativeClassPtr, "<clickCount>k__BackingField");
		NativeFieldInfoPtr__current_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mouse>.NativeClassPtr, "<current>k__BackingField");
		NativeFieldInfoPtr_s_PlatformMouseDevice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mouse>.NativeClassPtr, "s_PlatformMouseDevice");
		NativeMethodInfoPtr_get_scroll_Public_get_DeltaControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mouse>.NativeClassPtr, 100665183);
		NativeMethodInfoPtr_set_scroll_Protected_set_Void_DeltaControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mouse>.NativeClassPtr, 100665184);
		NativeMethodInfoPtr_get_leftButton_Public_get_ButtonControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mouse>.NativeClassPtr, 100665185);
		NativeMethodInfoPtr_set_leftButton_Protected_set_Void_ButtonControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mouse>.NativeClassPtr, 100665186);
		NativeMethodInfoPtr_get_middleButton_Public_get_ButtonControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mouse>.NativeClassPtr, 100665187);
		NativeMethodInfoPtr_set_middleButton_Protected_set_Void_ButtonControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mouse>.NativeClassPtr, 100665188);
		NativeMethodInfoPtr_get_rightButton_Public_get_ButtonControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mouse>.NativeClassPtr, 100665189);
		NativeMethodInfoPtr_set_rightButton_Protected_set_Void_ButtonControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mouse>.NativeClassPtr, 100665190);
		NativeMethodInfoPtr_get_backButton_Public_get_ButtonControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mouse>.NativeClassPtr, 100665191);
		NativeMethodInfoPtr_set_backButton_Protected_set_Void_ButtonControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mouse>.NativeClassPtr, 100665192);
		NativeMethodInfoPtr_get_forwardButton_Public_get_ButtonControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mouse>.NativeClassPtr, 100665193);
		NativeMethodInfoPtr_set_forwardButton_Protected_set_Void_ButtonControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mouse>.NativeClassPtr, 100665194);
		NativeMethodInfoPtr_get_clickCount_Public_get_IntegerControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mouse>.NativeClassPtr, 100665195);
		NativeMethodInfoPtr_set_clickCount_Protected_set_Void_IntegerControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mouse>.NativeClassPtr, 100665196);
		NativeMethodInfoPtr_get_current_Public_Static_get_Mouse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mouse>.NativeClassPtr, 100665197);
		NativeMethodInfoPtr_set_current_Private_Static_set_Void_Mouse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mouse>.NativeClassPtr, 100665198);
		NativeMethodInfoPtr_MakeCurrent_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mouse>.NativeClassPtr, 100665199);
		NativeMethodInfoPtr_OnAdded_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mouse>.NativeClassPtr, 100665200);
		NativeMethodInfoPtr_OnRemoved_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mouse>.NativeClassPtr, 100665201);
		NativeMethodInfoPtr_WarpCursorPosition_Public_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mouse>.NativeClassPtr, 100665202);
		NativeMethodInfoPtr_FinishSetup_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mouse>.NativeClassPtr, 100665203);
		NativeMethodInfoPtr_OnNextUpdate_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mouse>.NativeClassPtr, 100665204);
		NativeMethodInfoPtr_OnStateEvent_Protected_Void_InputEventPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mouse>.NativeClassPtr, 100665205);
		NativeMethodInfoPtr_UnityEngine_InputSystem_LowLevel_IInputStateCallbackReceiver_OnNextUpdate_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mouse>.NativeClassPtr, 100665206);
		NativeMethodInfoPtr_UnityEngine_InputSystem_LowLevel_IInputStateCallbackReceiver_OnStateEvent_Private_Virtual_Final_New_Void_InputEventPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mouse>.NativeClassPtr, 100665207);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mouse>.NativeClassPtr, 100665208);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 977638, XrefRangeEnd = 977647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void MakeCurrent()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_MakeCurrent_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 977647, XrefRangeEnd = 977653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void OnAdded()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_OnAdded_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 977653, XrefRangeEnd = 977660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void OnRemoved()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_OnRemoved_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 977664, RefRangeEnd = 977667, XrefRangeStart = 977660, XrefRangeEnd = 977664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void WarpCursorPosition(Vector2 position)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&position);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WarpCursorPosition_Public_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 977667, XrefRangeEnd = 977711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void FinishSetup()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_FinishSetup_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 977711, XrefRangeEnd = 977717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void OnNextUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnNextUpdate_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 977717, XrefRangeEnd = 977722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void OnStateEvent(InputEventPtr eventPtr)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&eventPtr);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnStateEvent_Protected_Void_InputEventPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe virtual void UnityEngine_InputSystem_LowLevel_IInputStateCallbackReceiver_OnNextUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnityEngine_InputSystem_LowLevel_IInputStateCallbackReceiver_OnNextUpdate_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe virtual void UnityEngine_InputSystem_LowLevel_IInputStateCallbackReceiver_OnStateEvent(InputEventPtr eventPtr)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&eventPtr);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnityEngine_InputSystem_LowLevel_IInputStateCallbackReceiver_OnStateEvent_Private_Virtual_Final_New_Void_InputEventPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 963305, RefRangeEnd = 963314, XrefRangeStart = 963305, XrefRangeEnd = 963314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Mouse()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Mouse>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public Mouse(IntPtr pointer)
		: base(pointer)
	{
	}
}
