using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.DualShock.LowLevel;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.DualShock;

public class DualShock4GamepadHID : DualShockGamepad
{
	[StructLayout(LayoutKind.Explicit)]
	public struct DualShock4HIDGenericInputReport
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_leftStickX;

		private static readonly System.IntPtr NativeFieldInfoPtr_leftStickY;

		private static readonly System.IntPtr NativeFieldInfoPtr_rightStickX;

		private static readonly System.IntPtr NativeFieldInfoPtr_rightStickY;

		private static readonly System.IntPtr NativeFieldInfoPtr_buttons0;

		private static readonly System.IntPtr NativeFieldInfoPtr_buttons1;

		private static readonly System.IntPtr NativeFieldInfoPtr_buttons2;

		private static readonly System.IntPtr NativeFieldInfoPtr_leftTrigger;

		private static readonly System.IntPtr NativeFieldInfoPtr_rightTrigger;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_Format_Public_Static_get_FourCC_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_ToHIDInputReport_Public_DualShock4HIDInputReport_0;

		[FieldOffset(0)]
		public byte leftStickX;

		[FieldOffset(1)]
		public byte leftStickY;

		[FieldOffset(2)]
		public byte rightStickX;

		[FieldOffset(3)]
		public byte rightStickY;

		[FieldOffset(4)]
		public byte buttons0;

		[FieldOffset(5)]
		public byte buttons1;

		[FieldOffset(6)]
		public byte buttons2;

		[FieldOffset(7)]
		public byte leftTrigger;

		[FieldOffset(8)]
		public byte rightTrigger;

		public unsafe static FourCC Format
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Format_Public_Static_get_FourCC_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(FourCC*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		static DualShock4HIDGenericInputReport()
		{
			Il2CppClassPointerStore<DualShock4HIDGenericInputReport>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DualShock4GamepadHID>.NativeClassPtr, "DualShock4HIDGenericInputReport");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DualShock4HIDGenericInputReport>.NativeClassPtr);
			NativeFieldInfoPtr_leftStickX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4HIDGenericInputReport>.NativeClassPtr, "leftStickX");
			NativeFieldInfoPtr_leftStickY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4HIDGenericInputReport>.NativeClassPtr, "leftStickY");
			NativeFieldInfoPtr_rightStickX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4HIDGenericInputReport>.NativeClassPtr, "rightStickX");
			NativeFieldInfoPtr_rightStickY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4HIDGenericInputReport>.NativeClassPtr, "rightStickY");
			NativeFieldInfoPtr_buttons0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4HIDGenericInputReport>.NativeClassPtr, "buttons0");
			NativeFieldInfoPtr_buttons1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4HIDGenericInputReport>.NativeClassPtr, "buttons1");
			NativeFieldInfoPtr_buttons2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4HIDGenericInputReport>.NativeClassPtr, "buttons2");
			NativeFieldInfoPtr_leftTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4HIDGenericInputReport>.NativeClassPtr, "leftTrigger");
			NativeFieldInfoPtr_rightTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4HIDGenericInputReport>.NativeClassPtr, "rightTrigger");
			NativeMethodInfoPtr_get_Format_Public_Static_get_FourCC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4HIDGenericInputReport>.NativeClassPtr, 100667251);
			NativeMethodInfoPtr_ToHIDInputReport_Public_DualShock4HIDInputReport_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4HIDGenericInputReport>.NativeClassPtr, 100667252);
		}

		[CallerCount(0)]
		public unsafe DualShock4HIDInputReport ToHIDInputReport()
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToHIDInputReport_Public_DualShock4HIDInputReport_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(DualShock4HIDInputReport*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DualShock4HIDGenericInputReport>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr__leftTriggerButton_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__rightTriggerButton_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__playStationButton_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_LowFrequencyMotorSpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_HighFrequenceyMotorSpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_LightBarColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_JitterMaskLow;

	private static readonly System.IntPtr NativeFieldInfoPtr_JitterMaskHigh;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_leftTriggerButton_Public_get_ButtonControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_leftTriggerButton_Protected_set_Void_ButtonControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_rightTriggerButton_Public_get_ButtonControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_rightTriggerButton_Protected_set_Void_ButtonControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_playStationButton_Public_get_ButtonControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_playStationButton_Protected_set_Void_ButtonControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FinishSetup_Protected_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PauseHaptics_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResetHaptics_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResumeHaptics_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetLightBarColor_Public_Virtual_Void_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetMotorSpeeds_Public_Virtual_Void_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetMotorSpeedsAndLightBarColor_Public_Boolean_Single_Single_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnityEngine_InputSystem_LowLevel_IEventPreProcessor_PreProcessEvent_Private_Virtual_Final_New_Boolean_InputEventPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnNextUpdate_Public_Virtual_Final_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnStateEvent_Public_Virtual_Final_New_Void_InputEventPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetStateOffsetForEvent_Public_Virtual_Final_New_Boolean_InputControl_InputEventPtr_byref_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe ButtonControl _leftTriggerButton_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__leftTriggerButton_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ButtonControl>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__leftTriggerButton_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe ButtonControl _rightTriggerButton_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__rightTriggerButton_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ButtonControl>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__rightTriggerButton_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe ButtonControl _playStationButton_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__playStationButton_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ButtonControl>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__playStationButton_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppSystem.Nullable<float> m_LowFrequencyMotorSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LowFrequencyMotorSpeed);
			return new Il2CppSystem.Nullable<float>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Nullable<float>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LowFrequencyMotorSpeed), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Nullable<float>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe Il2CppSystem.Nullable<float> m_HighFrequenceyMotorSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_HighFrequenceyMotorSpeed);
			return new Il2CppSystem.Nullable<float>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Nullable<float>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_HighFrequenceyMotorSpeed), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Nullable<float>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe Il2CppSystem.Nullable<Color> m_LightBarColor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LightBarColor);
			return new Il2CppSystem.Nullable<Color>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Nullable<Color>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LightBarColor), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Nullable<Color>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe static byte JitterMaskLow
	{
		get
		{
			Unsafe.SkipInit(out byte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_JitterMaskLow, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_JitterMaskLow, (void*)(&value));
		}
	}

	public unsafe static byte JitterMaskHigh
	{
		get
		{
			Unsafe.SkipInit(out byte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_JitterMaskHigh, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_JitterMaskHigh, (void*)(&value));
		}
	}

	public unsafe ButtonControl leftTriggerButton
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_leftTriggerButton_Public_get_ButtonControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
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
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_leftTriggerButton_Protected_set_Void_ButtonControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe ButtonControl rightTriggerButton
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_rightTriggerButton_Public_get_ButtonControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
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
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_rightTriggerButton_Protected_set_Void_ButtonControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe ButtonControl playStationButton
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_playStationButton_Public_get_ButtonControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
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
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_playStationButton_Protected_set_Void_ButtonControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	static DualShock4GamepadHID()
	{
		Il2CppClassPointerStore<DualShock4GamepadHID>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.InputSystem.dll", "UnityEngine.InputSystem.DualShock", "DualShock4GamepadHID");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DualShock4GamepadHID>.NativeClassPtr);
		NativeFieldInfoPtr__leftTriggerButton_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4GamepadHID>.NativeClassPtr, "<leftTriggerButton>k__BackingField");
		NativeFieldInfoPtr__rightTriggerButton_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4GamepadHID>.NativeClassPtr, "<rightTriggerButton>k__BackingField");
		NativeFieldInfoPtr__playStationButton_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4GamepadHID>.NativeClassPtr, "<playStationButton>k__BackingField");
		NativeFieldInfoPtr_m_LowFrequencyMotorSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4GamepadHID>.NativeClassPtr, "m_LowFrequencyMotorSpeed");
		NativeFieldInfoPtr_m_HighFrequenceyMotorSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4GamepadHID>.NativeClassPtr, "m_HighFrequenceyMotorSpeed");
		NativeFieldInfoPtr_m_LightBarColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4GamepadHID>.NativeClassPtr, "m_LightBarColor");
		NativeFieldInfoPtr_JitterMaskLow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4GamepadHID>.NativeClassPtr, "JitterMaskLow");
		NativeFieldInfoPtr_JitterMaskHigh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4GamepadHID>.NativeClassPtr, "JitterMaskHigh");
		NativeMethodInfoPtr_get_leftTriggerButton_Public_get_ButtonControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4GamepadHID>.NativeClassPtr, 100667233);
		NativeMethodInfoPtr_set_leftTriggerButton_Protected_set_Void_ButtonControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4GamepadHID>.NativeClassPtr, 100667234);
		NativeMethodInfoPtr_get_rightTriggerButton_Public_get_ButtonControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4GamepadHID>.NativeClassPtr, 100667235);
		NativeMethodInfoPtr_set_rightTriggerButton_Protected_set_Void_ButtonControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4GamepadHID>.NativeClassPtr, 100667236);
		NativeMethodInfoPtr_get_playStationButton_Public_get_ButtonControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4GamepadHID>.NativeClassPtr, 100667237);
		NativeMethodInfoPtr_set_playStationButton_Protected_set_Void_ButtonControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4GamepadHID>.NativeClassPtr, 100667238);
		NativeMethodInfoPtr_FinishSetup_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4GamepadHID>.NativeClassPtr, 100667239);
		NativeMethodInfoPtr_PauseHaptics_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4GamepadHID>.NativeClassPtr, 100667240);
		NativeMethodInfoPtr_ResetHaptics_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4GamepadHID>.NativeClassPtr, 100667241);
		NativeMethodInfoPtr_ResumeHaptics_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4GamepadHID>.NativeClassPtr, 100667242);
		NativeMethodInfoPtr_SetLightBarColor_Public_Virtual_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4GamepadHID>.NativeClassPtr, 100667243);
		NativeMethodInfoPtr_SetMotorSpeeds_Public_Virtual_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4GamepadHID>.NativeClassPtr, 100667244);
		NativeMethodInfoPtr_SetMotorSpeedsAndLightBarColor_Public_Boolean_Single_Single_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4GamepadHID>.NativeClassPtr, 100667245);
		NativeMethodInfoPtr_UnityEngine_InputSystem_LowLevel_IEventPreProcessor_PreProcessEvent_Private_Virtual_Final_New_Boolean_InputEventPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4GamepadHID>.NativeClassPtr, 100667246);
		NativeMethodInfoPtr_OnNextUpdate_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4GamepadHID>.NativeClassPtr, 100667247);
		NativeMethodInfoPtr_OnStateEvent_Public_Virtual_Final_New_Void_InputEventPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4GamepadHID>.NativeClassPtr, 100667248);
		NativeMethodInfoPtr_GetStateOffsetForEvent_Public_Virtual_Final_New_Boolean_InputControl_InputEventPtr_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4GamepadHID>.NativeClassPtr, 100667249);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4GamepadHID>.NativeClassPtr, 100667250);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1007556, XrefRangeEnd = 1007573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void FinishSetup()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_FinishSetup_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1007573, XrefRangeEnd = 1007579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void PauseHaptics()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_PauseHaptics_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1007579, XrefRangeEnd = 1007585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void ResetHaptics()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ResetHaptics_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1007585, XrefRangeEnd = 1007604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void ResumeHaptics()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ResumeHaptics_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1007604, XrefRangeEnd = 1007614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void SetLightBarColor(Color color)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&color);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SetLightBarColor_Public_Virtual_Void_Color_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1007614, XrefRangeEnd = 1007625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void SetMotorSpeeds(float lowFrequency, float highFrequency)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&lowFrequency);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &highFrequency;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_SetMotorSpeeds_Public_Virtual_Void_Single_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1007625, XrefRangeEnd = 1007642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool SetMotorSpeedsAndLightBarColor(float lowFrequency, float highFrequency, Color color)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&lowFrequency);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &highFrequency;
		*(Color**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &color;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetMotorSpeedsAndLightBarColor_Public_Boolean_Single_Single_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1007642, XrefRangeEnd = 1007654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual bool UnityEngine_InputSystem_LowLevel_IEventPreProcessor_PreProcessEvent(InputEventPtr eventPtr)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&eventPtr);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnityEngine_InputSystem_LowLevel_IEventPreProcessor_PreProcessEvent_Private_Virtual_Final_New_Boolean_InputEventPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(19883)]
	[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 20035, XrefRangeStart = 152, XrefRangeEnd = 20035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void OnNextUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnNextUpdate_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1007654, XrefRangeEnd = 1007672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void OnStateEvent(InputEventPtr eventPtr)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&eventPtr);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnStateEvent_Public_Virtual_Final_New_Void_InputEventPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(143)]
	[CachedScanResults(RefRangeStart = 9, RefRangeEnd = 152, XrefRangeStart = 9, XrefRangeEnd = 152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual bool GetStateOffsetForEvent(InputControl control, InputEventPtr eventPtr, ref uint offset)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)control);
		*(InputEventPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &eventPtr;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref offset);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetStateOffsetForEvent_Public_Virtual_Final_New_Boolean_InputControl_InputEventPtr_byref_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 963305, RefRangeEnd = 963314, XrefRangeStart = 963305, XrefRangeEnd = 963314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DualShock4GamepadHID()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DualShock4GamepadHID>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public DualShock4GamepadHID(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
