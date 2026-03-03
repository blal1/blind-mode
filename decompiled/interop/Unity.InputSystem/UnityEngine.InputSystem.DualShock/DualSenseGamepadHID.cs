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

public class DualSenseGamepadHID : DualShockGamepad
{
	[StructLayout(LayoutKind.Explicit)]
	public struct DualSenseHIDGenericInputReport
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_reportId;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_Format_Public_Static_get_FourCC_0;

		[FieldOffset(0)]
		public byte reportId;

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

		static DualSenseHIDGenericInputReport()
		{
			Il2CppClassPointerStore<DualSenseHIDGenericInputReport>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DualSenseGamepadHID>.NativeClassPtr, "DualSenseHIDGenericInputReport");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DualSenseHIDGenericInputReport>.NativeClassPtr);
			NativeFieldInfoPtr_reportId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseHIDGenericInputReport>.NativeClassPtr, "reportId");
			NativeMethodInfoPtr_get_Format_Public_Static_get_FourCC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseHIDGenericInputReport>.NativeClassPtr, 100667228);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DualSenseHIDGenericInputReport>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct DualSenseHIDUSBInputReport
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_ExpectedReportId;

		private static readonly System.IntPtr NativeFieldInfoPtr_reportId;

		private static readonly System.IntPtr NativeFieldInfoPtr_leftStickX;

		private static readonly System.IntPtr NativeFieldInfoPtr_leftStickY;

		private static readonly System.IntPtr NativeFieldInfoPtr_rightStickX;

		private static readonly System.IntPtr NativeFieldInfoPtr_rightStickY;

		private static readonly System.IntPtr NativeFieldInfoPtr_leftTrigger;

		private static readonly System.IntPtr NativeFieldInfoPtr_rightTrigger;

		private static readonly System.IntPtr NativeFieldInfoPtr_buttons0;

		private static readonly System.IntPtr NativeFieldInfoPtr_buttons1;

		private static readonly System.IntPtr NativeFieldInfoPtr_buttons2;

		private static readonly System.IntPtr NativeMethodInfoPtr_ToHIDInputReport_Public_DualSenseHIDInputReport_0;

		[FieldOffset(0)]
		public byte reportId;

		[FieldOffset(1)]
		public byte leftStickX;

		[FieldOffset(2)]
		public byte leftStickY;

		[FieldOffset(3)]
		public byte rightStickX;

		[FieldOffset(4)]
		public byte rightStickY;

		[FieldOffset(5)]
		public byte leftTrigger;

		[FieldOffset(6)]
		public byte rightTrigger;

		[FieldOffset(8)]
		public byte buttons0;

		[FieldOffset(9)]
		public byte buttons1;

		[FieldOffset(10)]
		public byte buttons2;

		public unsafe static int ExpectedReportId
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ExpectedReportId, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ExpectedReportId, (void*)(&value));
			}
		}

		static DualSenseHIDUSBInputReport()
		{
			Il2CppClassPointerStore<DualSenseHIDUSBInputReport>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DualSenseGamepadHID>.NativeClassPtr, "DualSenseHIDUSBInputReport");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DualSenseHIDUSBInputReport>.NativeClassPtr);
			NativeFieldInfoPtr_ExpectedReportId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseHIDUSBInputReport>.NativeClassPtr, "ExpectedReportId");
			NativeFieldInfoPtr_reportId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseHIDUSBInputReport>.NativeClassPtr, "reportId");
			NativeFieldInfoPtr_leftStickX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseHIDUSBInputReport>.NativeClassPtr, "leftStickX");
			NativeFieldInfoPtr_leftStickY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseHIDUSBInputReport>.NativeClassPtr, "leftStickY");
			NativeFieldInfoPtr_rightStickX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseHIDUSBInputReport>.NativeClassPtr, "rightStickX");
			NativeFieldInfoPtr_rightStickY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseHIDUSBInputReport>.NativeClassPtr, "rightStickY");
			NativeFieldInfoPtr_leftTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseHIDUSBInputReport>.NativeClassPtr, "leftTrigger");
			NativeFieldInfoPtr_rightTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseHIDUSBInputReport>.NativeClassPtr, "rightTrigger");
			NativeFieldInfoPtr_buttons0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseHIDUSBInputReport>.NativeClassPtr, "buttons0");
			NativeFieldInfoPtr_buttons1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseHIDUSBInputReport>.NativeClassPtr, "buttons1");
			NativeFieldInfoPtr_buttons2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseHIDUSBInputReport>.NativeClassPtr, "buttons2");
			NativeMethodInfoPtr_ToHIDInputReport_Public_DualSenseHIDInputReport_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseHIDUSBInputReport>.NativeClassPtr, 100667229);
		}

		[CallerCount(0)]
		public unsafe DualSenseHIDInputReport ToHIDInputReport()
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToHIDInputReport_Public_DualSenseHIDInputReport_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(DualSenseHIDInputReport*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DualSenseHIDUSBInputReport>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct DualSenseHIDBluetoothInputReport
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_ExpectedReportId;

		private static readonly System.IntPtr NativeFieldInfoPtr_reportId;

		private static readonly System.IntPtr NativeFieldInfoPtr_leftStickX;

		private static readonly System.IntPtr NativeFieldInfoPtr_leftStickY;

		private static readonly System.IntPtr NativeFieldInfoPtr_rightStickX;

		private static readonly System.IntPtr NativeFieldInfoPtr_rightStickY;

		private static readonly System.IntPtr NativeFieldInfoPtr_leftTrigger;

		private static readonly System.IntPtr NativeFieldInfoPtr_rightTrigger;

		private static readonly System.IntPtr NativeFieldInfoPtr_buttons0;

		private static readonly System.IntPtr NativeFieldInfoPtr_buttons1;

		private static readonly System.IntPtr NativeFieldInfoPtr_buttons2;

		private static readonly System.IntPtr NativeMethodInfoPtr_ToHIDInputReport_Public_DualSenseHIDInputReport_0;

		[FieldOffset(0)]
		public byte reportId;

		[FieldOffset(2)]
		public byte leftStickX;

		[FieldOffset(3)]
		public byte leftStickY;

		[FieldOffset(4)]
		public byte rightStickX;

		[FieldOffset(5)]
		public byte rightStickY;

		[FieldOffset(6)]
		public byte leftTrigger;

		[FieldOffset(7)]
		public byte rightTrigger;

		[FieldOffset(9)]
		public byte buttons0;

		[FieldOffset(10)]
		public byte buttons1;

		[FieldOffset(11)]
		public byte buttons2;

		public unsafe static int ExpectedReportId
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ExpectedReportId, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ExpectedReportId, (void*)(&value));
			}
		}

		static DualSenseHIDBluetoothInputReport()
		{
			Il2CppClassPointerStore<DualSenseHIDBluetoothInputReport>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DualSenseGamepadHID>.NativeClassPtr, "DualSenseHIDBluetoothInputReport");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DualSenseHIDBluetoothInputReport>.NativeClassPtr);
			NativeFieldInfoPtr_ExpectedReportId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseHIDBluetoothInputReport>.NativeClassPtr, "ExpectedReportId");
			NativeFieldInfoPtr_reportId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseHIDBluetoothInputReport>.NativeClassPtr, "reportId");
			NativeFieldInfoPtr_leftStickX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseHIDBluetoothInputReport>.NativeClassPtr, "leftStickX");
			NativeFieldInfoPtr_leftStickY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseHIDBluetoothInputReport>.NativeClassPtr, "leftStickY");
			NativeFieldInfoPtr_rightStickX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseHIDBluetoothInputReport>.NativeClassPtr, "rightStickX");
			NativeFieldInfoPtr_rightStickY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseHIDBluetoothInputReport>.NativeClassPtr, "rightStickY");
			NativeFieldInfoPtr_leftTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseHIDBluetoothInputReport>.NativeClassPtr, "leftTrigger");
			NativeFieldInfoPtr_rightTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseHIDBluetoothInputReport>.NativeClassPtr, "rightTrigger");
			NativeFieldInfoPtr_buttons0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseHIDBluetoothInputReport>.NativeClassPtr, "buttons0");
			NativeFieldInfoPtr_buttons1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseHIDBluetoothInputReport>.NativeClassPtr, "buttons1");
			NativeFieldInfoPtr_buttons2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseHIDBluetoothInputReport>.NativeClassPtr, "buttons2");
			NativeMethodInfoPtr_ToHIDInputReport_Public_DualSenseHIDInputReport_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseHIDBluetoothInputReport>.NativeClassPtr, 100667230);
		}

		[CallerCount(0)]
		public unsafe DualSenseHIDInputReport ToHIDInputReport()
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToHIDInputReport_Public_DualSenseHIDInputReport_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(DualSenseHIDInputReport*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DualSenseHIDBluetoothInputReport>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct DualSenseHIDMinimalInputReport
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_ExpectedSize1;

		private static readonly System.IntPtr NativeFieldInfoPtr_ExpectedSize2;

		private static readonly System.IntPtr NativeFieldInfoPtr_reportId;

		private static readonly System.IntPtr NativeFieldInfoPtr_leftStickX;

		private static readonly System.IntPtr NativeFieldInfoPtr_leftStickY;

		private static readonly System.IntPtr NativeFieldInfoPtr_rightStickX;

		private static readonly System.IntPtr NativeFieldInfoPtr_rightStickY;

		private static readonly System.IntPtr NativeFieldInfoPtr_buttons0;

		private static readonly System.IntPtr NativeFieldInfoPtr_buttons1;

		private static readonly System.IntPtr NativeFieldInfoPtr_buttons2;

		private static readonly System.IntPtr NativeFieldInfoPtr_leftTrigger;

		private static readonly System.IntPtr NativeFieldInfoPtr_rightTrigger;

		private static readonly System.IntPtr NativeMethodInfoPtr_ToHIDInputReport_Public_DualSenseHIDInputReport_0;

		[FieldOffset(0)]
		public byte reportId;

		[FieldOffset(1)]
		public byte leftStickX;

		[FieldOffset(2)]
		public byte leftStickY;

		[FieldOffset(3)]
		public byte rightStickX;

		[FieldOffset(4)]
		public byte rightStickY;

		[FieldOffset(5)]
		public byte buttons0;

		[FieldOffset(6)]
		public byte buttons1;

		[FieldOffset(7)]
		public byte buttons2;

		[FieldOffset(8)]
		public byte leftTrigger;

		[FieldOffset(9)]
		public byte rightTrigger;

		public unsafe static int ExpectedSize1
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ExpectedSize1, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ExpectedSize1, (void*)(&value));
			}
		}

		public unsafe static int ExpectedSize2
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ExpectedSize2, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ExpectedSize2, (void*)(&value));
			}
		}

		static DualSenseHIDMinimalInputReport()
		{
			Il2CppClassPointerStore<DualSenseHIDMinimalInputReport>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DualSenseGamepadHID>.NativeClassPtr, "DualSenseHIDMinimalInputReport");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DualSenseHIDMinimalInputReport>.NativeClassPtr);
			NativeFieldInfoPtr_ExpectedSize1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseHIDMinimalInputReport>.NativeClassPtr, "ExpectedSize1");
			NativeFieldInfoPtr_ExpectedSize2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseHIDMinimalInputReport>.NativeClassPtr, "ExpectedSize2");
			NativeFieldInfoPtr_reportId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseHIDMinimalInputReport>.NativeClassPtr, "reportId");
			NativeFieldInfoPtr_leftStickX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseHIDMinimalInputReport>.NativeClassPtr, "leftStickX");
			NativeFieldInfoPtr_leftStickY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseHIDMinimalInputReport>.NativeClassPtr, "leftStickY");
			NativeFieldInfoPtr_rightStickX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseHIDMinimalInputReport>.NativeClassPtr, "rightStickX");
			NativeFieldInfoPtr_rightStickY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseHIDMinimalInputReport>.NativeClassPtr, "rightStickY");
			NativeFieldInfoPtr_buttons0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseHIDMinimalInputReport>.NativeClassPtr, "buttons0");
			NativeFieldInfoPtr_buttons1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseHIDMinimalInputReport>.NativeClassPtr, "buttons1");
			NativeFieldInfoPtr_buttons2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseHIDMinimalInputReport>.NativeClassPtr, "buttons2");
			NativeFieldInfoPtr_leftTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseHIDMinimalInputReport>.NativeClassPtr, "leftTrigger");
			NativeFieldInfoPtr_rightTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseHIDMinimalInputReport>.NativeClassPtr, "rightTrigger");
			NativeMethodInfoPtr_ToHIDInputReport_Public_DualSenseHIDInputReport_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseHIDMinimalInputReport>.NativeClassPtr, 100667231);
		}

		[CallerCount(0)]
		public unsafe DualSenseHIDInputReport ToHIDInputReport()
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToHIDInputReport_Public_DualSenseHIDInputReport_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(DualSenseHIDInputReport*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DualSenseHIDMinimalInputReport>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr__leftTriggerButton_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__rightTriggerButton_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__playStationButton_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_LowFrequencyMotorSpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_HighFrequenceyMotorSpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_LightBarColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_outputSequenceId;

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

	private static readonly System.IntPtr NativeMethodInfoPtr_SetMotorSpeedsAndLightBarColor_Public_Boolean_Nullable_1_Single_Nullable_1_Single_Nullable_1_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MergeForward_Private_Static_Boolean_ptr_DualSenseHIDUSBInputReport_ptr_DualSenseHIDUSBInputReport_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MergeForward_Private_Static_Boolean_ptr_DualSenseHIDBluetoothInputReport_ptr_DualSenseHIDBluetoothInputReport_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MergeForward_Private_Static_Boolean_ptr_DualSenseHIDMinimalInputReport_ptr_DualSenseHIDMinimalInputReport_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnityEngine_InputSystem_LowLevel_IEventMerger_MergeForward_Private_Virtual_Final_New_Boolean_InputEventPtr_InputEventPtr_0;

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

	public unsafe byte outputSequenceId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_outputSequenceId);
			return *(byte*)num;
		}
		set
		{
			*(byte*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_outputSequenceId)) = value;
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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1007422, XrefRangeEnd = 1007423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	static DualSenseGamepadHID()
	{
		Il2CppClassPointerStore<DualSenseGamepadHID>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.InputSystem.dll", "UnityEngine.InputSystem.DualShock", "DualSenseGamepadHID");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DualSenseGamepadHID>.NativeClassPtr);
		NativeFieldInfoPtr__leftTriggerButton_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseGamepadHID>.NativeClassPtr, "<leftTriggerButton>k__BackingField");
		NativeFieldInfoPtr__rightTriggerButton_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseGamepadHID>.NativeClassPtr, "<rightTriggerButton>k__BackingField");
		NativeFieldInfoPtr__playStationButton_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseGamepadHID>.NativeClassPtr, "<playStationButton>k__BackingField");
		NativeFieldInfoPtr_m_LowFrequencyMotorSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseGamepadHID>.NativeClassPtr, "m_LowFrequencyMotorSpeed");
		NativeFieldInfoPtr_m_HighFrequenceyMotorSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseGamepadHID>.NativeClassPtr, "m_HighFrequenceyMotorSpeed");
		NativeFieldInfoPtr_m_LightBarColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseGamepadHID>.NativeClassPtr, "m_LightBarColor");
		NativeFieldInfoPtr_outputSequenceId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseGamepadHID>.NativeClassPtr, "outputSequenceId");
		NativeFieldInfoPtr_JitterMaskLow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseGamepadHID>.NativeClassPtr, "JitterMaskLow");
		NativeFieldInfoPtr_JitterMaskHigh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseGamepadHID>.NativeClassPtr, "JitterMaskHigh");
		NativeMethodInfoPtr_get_leftTriggerButton_Public_get_ButtonControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseGamepadHID>.NativeClassPtr, 100667206);
		NativeMethodInfoPtr_set_leftTriggerButton_Protected_set_Void_ButtonControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseGamepadHID>.NativeClassPtr, 100667207);
		NativeMethodInfoPtr_get_rightTriggerButton_Public_get_ButtonControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseGamepadHID>.NativeClassPtr, 100667208);
		NativeMethodInfoPtr_set_rightTriggerButton_Protected_set_Void_ButtonControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseGamepadHID>.NativeClassPtr, 100667209);
		NativeMethodInfoPtr_get_playStationButton_Public_get_ButtonControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseGamepadHID>.NativeClassPtr, 100667210);
		NativeMethodInfoPtr_set_playStationButton_Protected_set_Void_ButtonControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseGamepadHID>.NativeClassPtr, 100667211);
		NativeMethodInfoPtr_FinishSetup_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseGamepadHID>.NativeClassPtr, 100667212);
		NativeMethodInfoPtr_PauseHaptics_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseGamepadHID>.NativeClassPtr, 100667213);
		NativeMethodInfoPtr_ResetHaptics_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseGamepadHID>.NativeClassPtr, 100667214);
		NativeMethodInfoPtr_ResumeHaptics_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseGamepadHID>.NativeClassPtr, 100667215);
		NativeMethodInfoPtr_SetLightBarColor_Public_Virtual_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseGamepadHID>.NativeClassPtr, 100667216);
		NativeMethodInfoPtr_SetMotorSpeeds_Public_Virtual_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseGamepadHID>.NativeClassPtr, 100667217);
		NativeMethodInfoPtr_SetMotorSpeedsAndLightBarColor_Public_Boolean_Nullable_1_Single_Nullable_1_Single_Nullable_1_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseGamepadHID>.NativeClassPtr, 100667218);
		NativeMethodInfoPtr_MergeForward_Private_Static_Boolean_ptr_DualSenseHIDUSBInputReport_ptr_DualSenseHIDUSBInputReport_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseGamepadHID>.NativeClassPtr, 100667219);
		NativeMethodInfoPtr_MergeForward_Private_Static_Boolean_ptr_DualSenseHIDBluetoothInputReport_ptr_DualSenseHIDBluetoothInputReport_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseGamepadHID>.NativeClassPtr, 100667220);
		NativeMethodInfoPtr_MergeForward_Private_Static_Boolean_ptr_DualSenseHIDMinimalInputReport_ptr_DualSenseHIDMinimalInputReport_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseGamepadHID>.NativeClassPtr, 100667221);
		NativeMethodInfoPtr_UnityEngine_InputSystem_LowLevel_IEventMerger_MergeForward_Private_Virtual_Final_New_Boolean_InputEventPtr_InputEventPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseGamepadHID>.NativeClassPtr, 100667222);
		NativeMethodInfoPtr_UnityEngine_InputSystem_LowLevel_IEventPreProcessor_PreProcessEvent_Private_Virtual_Final_New_Boolean_InputEventPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseGamepadHID>.NativeClassPtr, 100667223);
		NativeMethodInfoPtr_OnNextUpdate_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseGamepadHID>.NativeClassPtr, 100667224);
		NativeMethodInfoPtr_OnStateEvent_Public_Virtual_Final_New_Void_InputEventPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseGamepadHID>.NativeClassPtr, 100667225);
		NativeMethodInfoPtr_GetStateOffsetForEvent_Public_Virtual_Final_New_Boolean_InputControl_InputEventPtr_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseGamepadHID>.NativeClassPtr, 100667226);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseGamepadHID>.NativeClassPtr, 100667227);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1007423, XrefRangeEnd = 1007440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void FinishSetup()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_FinishSetup_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1007440, XrefRangeEnd = 1007447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void PauseHaptics()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_PauseHaptics_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1007447, XrefRangeEnd = 1007449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void ResetHaptics()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ResetHaptics_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1007449, XrefRangeEnd = 1007451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void ResumeHaptics()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ResumeHaptics_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1007451, XrefRangeEnd = 1007455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1007455, XrefRangeEnd = 1007461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1007493, RefRangeEnd = 1007498, XrefRangeStart = 1007461, XrefRangeEnd = 1007493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool SetMotorSpeedsAndLightBarColor(Il2CppSystem.Nullable<float> lowFrequency, Il2CppSystem.Nullable<float> highFrequency, Il2CppSystem.Nullable<Color> color)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)lowFrequency));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)highFrequency));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)color));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetMotorSpeedsAndLightBarColor_Public_Boolean_Nullable_1_Single_Nullable_1_Single_Nullable_1_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static bool MergeForward(DualSenseHIDUSBInputReport* currentState, DualSenseHIDUSBInputReport* nextState)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)currentState;
		*(DualSenseHIDUSBInputReport**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = nextState;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MergeForward_Private_Static_Boolean_ptr_DualSenseHIDUSBInputReport_ptr_DualSenseHIDUSBInputReport_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static bool MergeForward(DualSenseHIDBluetoothInputReport* currentState, DualSenseHIDBluetoothInputReport* nextState)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)currentState;
		*(DualSenseHIDBluetoothInputReport**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = nextState;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MergeForward_Private_Static_Boolean_ptr_DualSenseHIDBluetoothInputReport_ptr_DualSenseHIDBluetoothInputReport_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static bool MergeForward(DualSenseHIDMinimalInputReport* currentState, DualSenseHIDMinimalInputReport* nextState)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)currentState;
		*(DualSenseHIDMinimalInputReport**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = nextState;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MergeForward_Private_Static_Boolean_ptr_DualSenseHIDMinimalInputReport_ptr_DualSenseHIDMinimalInputReport_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1007498, XrefRangeEnd = 1007524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual bool UnityEngine_InputSystem_LowLevel_IEventMerger_MergeForward(InputEventPtr currentEventPtr, InputEventPtr nextEventPtr)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&currentEventPtr);
		*(InputEventPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &nextEventPtr;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnityEngine_InputSystem_LowLevel_IEventMerger_MergeForward_Private_Virtual_Final_New_Boolean_InputEventPtr_InputEventPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1007524, XrefRangeEnd = 1007538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1007538, XrefRangeEnd = 1007556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	public unsafe DualSenseGamepadHID()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DualSenseGamepadHID>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public DualSenseGamepadHID(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
