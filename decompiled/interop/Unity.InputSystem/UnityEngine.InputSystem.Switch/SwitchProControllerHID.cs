using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.InputSystem.Switch.LowLevel;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.Switch;

public class SwitchProControllerHID : Gamepad
{
	[StructLayout(LayoutKind.Explicit)]
	public struct SwitchInputOnlyReport
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_kSize;

		private static readonly System.IntPtr NativeFieldInfoPtr_buttons0;

		private static readonly System.IntPtr NativeFieldInfoPtr_buttons1;

		private static readonly System.IntPtr NativeFieldInfoPtr_hat;

		private static readonly System.IntPtr NativeFieldInfoPtr_leftX;

		private static readonly System.IntPtr NativeFieldInfoPtr_leftY;

		private static readonly System.IntPtr NativeFieldInfoPtr_rightX;

		private static readonly System.IntPtr NativeFieldInfoPtr_rightY;

		private static readonly System.IntPtr NativeMethodInfoPtr_ToHIDInputReport_Public_SwitchProControllerHIDInputState_0;

		[FieldOffset(0)]
		public byte buttons0;

		[FieldOffset(1)]
		public byte buttons1;

		[FieldOffset(2)]
		public byte hat;

		[FieldOffset(3)]
		public byte leftX;

		[FieldOffset(4)]
		public byte leftY;

		[FieldOffset(5)]
		public byte rightX;

		[FieldOffset(6)]
		public byte rightY;

		public unsafe static int kSize
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kSize, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kSize, (void*)(&value));
			}
		}

		static SwitchInputOnlyReport()
		{
			Il2CppClassPointerStore<SwitchInputOnlyReport>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SwitchProControllerHID>.NativeClassPtr, "SwitchInputOnlyReport");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SwitchInputOnlyReport>.NativeClassPtr);
			NativeFieldInfoPtr_kSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwitchInputOnlyReport>.NativeClassPtr, "kSize");
			NativeFieldInfoPtr_buttons0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwitchInputOnlyReport>.NativeClassPtr, "buttons0");
			NativeFieldInfoPtr_buttons1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwitchInputOnlyReport>.NativeClassPtr, "buttons1");
			NativeFieldInfoPtr_hat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwitchInputOnlyReport>.NativeClassPtr, "hat");
			NativeFieldInfoPtr_leftX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwitchInputOnlyReport>.NativeClassPtr, "leftX");
			NativeFieldInfoPtr_leftY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwitchInputOnlyReport>.NativeClassPtr, "leftY");
			NativeFieldInfoPtr_rightX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwitchInputOnlyReport>.NativeClassPtr, "rightX");
			NativeFieldInfoPtr_rightY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwitchInputOnlyReport>.NativeClassPtr, "rightY");
			NativeMethodInfoPtr_ToHIDInputReport_Public_SwitchProControllerHIDInputState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SwitchInputOnlyReport>.NativeClassPtr, 100666940);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1004179, XrefRangeEnd = 1004209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SwitchProControllerHIDInputState ToHIDInputReport()
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToHIDInputReport_Public_SwitchProControllerHIDInputState_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(SwitchProControllerHIDInputState*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SwitchInputOnlyReport>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct SwitchSimpleInputReport
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_kSize;

		private static readonly System.IntPtr NativeFieldInfoPtr_ExpectedReportId;

		private static readonly System.IntPtr NativeFieldInfoPtr_reportId;

		private static readonly System.IntPtr NativeFieldInfoPtr_buttons0;

		private static readonly System.IntPtr NativeFieldInfoPtr_buttons1;

		private static readonly System.IntPtr NativeFieldInfoPtr_hat;

		private static readonly System.IntPtr NativeFieldInfoPtr_leftX;

		private static readonly System.IntPtr NativeFieldInfoPtr_leftY;

		private static readonly System.IntPtr NativeFieldInfoPtr_rightX;

		private static readonly System.IntPtr NativeFieldInfoPtr_rightY;

		private static readonly System.IntPtr NativeMethodInfoPtr_ToHIDInputReport_Public_SwitchProControllerHIDInputState_0;

		[FieldOffset(0)]
		public byte reportId;

		[FieldOffset(1)]
		public byte buttons0;

		[FieldOffset(2)]
		public byte buttons1;

		[FieldOffset(3)]
		public byte hat;

		[FieldOffset(4)]
		public ushort leftX;

		[FieldOffset(6)]
		public ushort leftY;

		[FieldOffset(8)]
		public ushort rightX;

		[FieldOffset(10)]
		public ushort rightY;

		public unsafe static int kSize
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kSize, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kSize, (void*)(&value));
			}
		}

		public unsafe static byte ExpectedReportId
		{
			get
			{
				Unsafe.SkipInit(out byte result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ExpectedReportId, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ExpectedReportId, (void*)(&value));
			}
		}

		static SwitchSimpleInputReport()
		{
			Il2CppClassPointerStore<SwitchSimpleInputReport>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SwitchProControllerHID>.NativeClassPtr, "SwitchSimpleInputReport");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SwitchSimpleInputReport>.NativeClassPtr);
			NativeFieldInfoPtr_kSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwitchSimpleInputReport>.NativeClassPtr, "kSize");
			NativeFieldInfoPtr_ExpectedReportId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwitchSimpleInputReport>.NativeClassPtr, "ExpectedReportId");
			NativeFieldInfoPtr_reportId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwitchSimpleInputReport>.NativeClassPtr, "reportId");
			NativeFieldInfoPtr_buttons0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwitchSimpleInputReport>.NativeClassPtr, "buttons0");
			NativeFieldInfoPtr_buttons1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwitchSimpleInputReport>.NativeClassPtr, "buttons1");
			NativeFieldInfoPtr_hat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwitchSimpleInputReport>.NativeClassPtr, "hat");
			NativeFieldInfoPtr_leftX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwitchSimpleInputReport>.NativeClassPtr, "leftX");
			NativeFieldInfoPtr_leftY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwitchSimpleInputReport>.NativeClassPtr, "leftY");
			NativeFieldInfoPtr_rightX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwitchSimpleInputReport>.NativeClassPtr, "rightX");
			NativeFieldInfoPtr_rightY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwitchSimpleInputReport>.NativeClassPtr, "rightY");
			NativeMethodInfoPtr_ToHIDInputReport_Public_SwitchProControllerHIDInputState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SwitchSimpleInputReport>.NativeClassPtr, 100666941);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1004209, XrefRangeEnd = 1004243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SwitchProControllerHIDInputState ToHIDInputReport()
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToHIDInputReport_Public_SwitchProControllerHIDInputState_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(SwitchProControllerHIDInputState*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SwitchSimpleInputReport>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct SwitchFullInputReport
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_kSize;

		private static readonly System.IntPtr NativeFieldInfoPtr_ExpectedReportId;

		private static readonly System.IntPtr NativeFieldInfoPtr_reportId;

		private static readonly System.IntPtr NativeFieldInfoPtr_buttons0;

		private static readonly System.IntPtr NativeFieldInfoPtr_buttons1;

		private static readonly System.IntPtr NativeFieldInfoPtr_buttons2;

		private static readonly System.IntPtr NativeFieldInfoPtr_left0;

		private static readonly System.IntPtr NativeFieldInfoPtr_left1;

		private static readonly System.IntPtr NativeFieldInfoPtr_left2;

		private static readonly System.IntPtr NativeFieldInfoPtr_right0;

		private static readonly System.IntPtr NativeFieldInfoPtr_right1;

		private static readonly System.IntPtr NativeFieldInfoPtr_right2;

		private static readonly System.IntPtr NativeMethodInfoPtr_ToHIDInputReport_Public_SwitchProControllerHIDInputState_0;

		[FieldOffset(0)]
		public byte reportId;

		[FieldOffset(3)]
		public byte buttons0;

		[FieldOffset(4)]
		public byte buttons1;

		[FieldOffset(5)]
		public byte buttons2;

		[FieldOffset(6)]
		public byte left0;

		[FieldOffset(7)]
		public byte left1;

		[FieldOffset(8)]
		public byte left2;

		[FieldOffset(9)]
		public byte right0;

		[FieldOffset(10)]
		public byte right1;

		[FieldOffset(11)]
		public byte right2;

		public unsafe static int kSize
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kSize, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kSize, (void*)(&value));
			}
		}

		public unsafe static byte ExpectedReportId
		{
			get
			{
				Unsafe.SkipInit(out byte result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ExpectedReportId, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ExpectedReportId, (void*)(&value));
			}
		}

		static SwitchFullInputReport()
		{
			Il2CppClassPointerStore<SwitchFullInputReport>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SwitchProControllerHID>.NativeClassPtr, "SwitchFullInputReport");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SwitchFullInputReport>.NativeClassPtr);
			NativeFieldInfoPtr_kSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwitchFullInputReport>.NativeClassPtr, "kSize");
			NativeFieldInfoPtr_ExpectedReportId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwitchFullInputReport>.NativeClassPtr, "ExpectedReportId");
			NativeFieldInfoPtr_reportId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwitchFullInputReport>.NativeClassPtr, "reportId");
			NativeFieldInfoPtr_buttons0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwitchFullInputReport>.NativeClassPtr, "buttons0");
			NativeFieldInfoPtr_buttons1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwitchFullInputReport>.NativeClassPtr, "buttons1");
			NativeFieldInfoPtr_buttons2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwitchFullInputReport>.NativeClassPtr, "buttons2");
			NativeFieldInfoPtr_left0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwitchFullInputReport>.NativeClassPtr, "left0");
			NativeFieldInfoPtr_left1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwitchFullInputReport>.NativeClassPtr, "left1");
			NativeFieldInfoPtr_left2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwitchFullInputReport>.NativeClassPtr, "left2");
			NativeFieldInfoPtr_right0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwitchFullInputReport>.NativeClassPtr, "right0");
			NativeFieldInfoPtr_right1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwitchFullInputReport>.NativeClassPtr, "right1");
			NativeFieldInfoPtr_right2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwitchFullInputReport>.NativeClassPtr, "right2");
			NativeMethodInfoPtr_ToHIDInputReport_Public_SwitchProControllerHIDInputState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SwitchFullInputReport>.NativeClassPtr, 100666942);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1004243, XrefRangeEnd = 1004267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SwitchProControllerHIDInputState ToHIDInputReport()
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToHIDInputReport_Public_SwitchProControllerHIDInputState_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(SwitchProControllerHIDInputState*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SwitchFullInputReport>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct SwitchHIDGenericInputReport
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_reportId;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_Format_Public_Static_get_FourCC_0;

		[FieldOffset(0)]
		public byte reportId;

		public unsafe static FourCC Format
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1004267, XrefRangeEnd = 1004268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Format_Public_Static_get_FourCC_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(FourCC*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		static SwitchHIDGenericInputReport()
		{
			Il2CppClassPointerStore<SwitchHIDGenericInputReport>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SwitchProControllerHID>.NativeClassPtr, "SwitchHIDGenericInputReport");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SwitchHIDGenericInputReport>.NativeClassPtr);
			NativeFieldInfoPtr_reportId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwitchHIDGenericInputReport>.NativeClassPtr, "reportId");
			NativeMethodInfoPtr_get_Format_Public_Static_get_FourCC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SwitchHIDGenericInputReport>.NativeClassPtr, 100666943);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SwitchHIDGenericInputReport>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct SwitchMagicOutputReport
	{
		[OriginalName("Unity.InputSystem.dll", "", "ReportType")]
		public enum ReportType
		{
			Magic = 0x80
		}

		[OriginalName("Unity.InputSystem.dll", "", "CommandIdType")]
		public enum CommandIdType
		{
			Status = 1,
			Handshake,
			Highspeed,
			ForceUSB
		}

		private static readonly System.IntPtr NativeFieldInfoPtr_kSize;

		private static readonly System.IntPtr NativeFieldInfoPtr_ExpectedReplyInputReportId;

		private static readonly System.IntPtr NativeFieldInfoPtr_reportType;

		private static readonly System.IntPtr NativeFieldInfoPtr_commandId;

		[FieldOffset(0)]
		public byte reportType;

		[FieldOffset(1)]
		public byte commandId;

		public unsafe static int kSize
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kSize, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kSize, (void*)(&value));
			}
		}

		public unsafe static byte ExpectedReplyInputReportId
		{
			get
			{
				Unsafe.SkipInit(out byte result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ExpectedReplyInputReportId, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ExpectedReplyInputReportId, (void*)(&value));
			}
		}

		static SwitchMagicOutputReport()
		{
			Il2CppClassPointerStore<SwitchMagicOutputReport>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SwitchProControllerHID>.NativeClassPtr, "SwitchMagicOutputReport");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SwitchMagicOutputReport>.NativeClassPtr);
			NativeFieldInfoPtr_kSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwitchMagicOutputReport>.NativeClassPtr, "kSize");
			NativeFieldInfoPtr_ExpectedReplyInputReportId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwitchMagicOutputReport>.NativeClassPtr, "ExpectedReplyInputReportId");
			NativeFieldInfoPtr_reportType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwitchMagicOutputReport>.NativeClassPtr, "reportType");
			NativeFieldInfoPtr_commandId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwitchMagicOutputReport>.NativeClassPtr, "commandId");
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SwitchMagicOutputReport>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct SwitchMagicOutputHIDBluetooth
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_kSize;

		private static readonly System.IntPtr NativeFieldInfoPtr_baseCommand;

		private static readonly System.IntPtr NativeFieldInfoPtr_report;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_Type_Public_Static_get_FourCC_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_typeStatic_Public_Virtual_Final_New_get_FourCC_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Static_SwitchMagicOutputHIDBluetooth_CommandIdType_0;

		[FieldOffset(0)]
		public InputDeviceCommand baseCommand;

		[FieldOffset(8)]
		public SwitchMagicOutputReport report;

		public unsafe static int kSize
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kSize, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kSize, (void*)(&value));
			}
		}

		public unsafe static FourCC Type
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1004268, XrefRangeEnd = 1004269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Type_Public_Static_get_FourCC_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(FourCC*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		public unsafe virtual FourCC typeStatic
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1004269, XrefRangeEnd = 1004270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_typeStatic_Public_Virtual_Final_New_get_FourCC_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(FourCC*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		static SwitchMagicOutputHIDBluetooth()
		{
			Il2CppClassPointerStore<SwitchMagicOutputHIDBluetooth>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SwitchProControllerHID>.NativeClassPtr, "SwitchMagicOutputHIDBluetooth");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SwitchMagicOutputHIDBluetooth>.NativeClassPtr);
			NativeFieldInfoPtr_kSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwitchMagicOutputHIDBluetooth>.NativeClassPtr, "kSize");
			NativeFieldInfoPtr_baseCommand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwitchMagicOutputHIDBluetooth>.NativeClassPtr, "baseCommand");
			NativeFieldInfoPtr_report = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwitchMagicOutputHIDBluetooth>.NativeClassPtr, "report");
			NativeMethodInfoPtr_get_Type_Public_Static_get_FourCC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SwitchMagicOutputHIDBluetooth>.NativeClassPtr, 100666944);
			NativeMethodInfoPtr_get_typeStatic_Public_Virtual_Final_New_get_FourCC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SwitchMagicOutputHIDBluetooth>.NativeClassPtr, 100666945);
			NativeMethodInfoPtr_Create_Public_Static_SwitchMagicOutputHIDBluetooth_CommandIdType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SwitchMagicOutputHIDBluetooth>.NativeClassPtr, 100666946);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1004270, XrefRangeEnd = 1004272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SwitchMagicOutputHIDBluetooth Create(SwitchMagicOutputReport.CommandIdType type)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&type);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Create_Public_Static_SwitchMagicOutputHIDBluetooth_CommandIdType_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(SwitchMagicOutputHIDBluetooth*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SwitchMagicOutputHIDBluetooth>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct SwitchMagicOutputHIDUSB
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_kSize;

		private static readonly System.IntPtr NativeFieldInfoPtr_baseCommand;

		private static readonly System.IntPtr NativeFieldInfoPtr_report;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_Type_Public_Static_get_FourCC_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_typeStatic_Public_Virtual_Final_New_get_FourCC_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Static_SwitchMagicOutputHIDUSB_CommandIdType_0;

		[FieldOffset(0)]
		public InputDeviceCommand baseCommand;

		[FieldOffset(8)]
		public SwitchMagicOutputReport report;

		public unsafe static int kSize
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kSize, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kSize, (void*)(&value));
			}
		}

		public unsafe static FourCC Type
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Type_Public_Static_get_FourCC_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(FourCC*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		public unsafe virtual FourCC typeStatic
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_typeStatic_Public_Virtual_Final_New_get_FourCC_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(FourCC*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		static SwitchMagicOutputHIDUSB()
		{
			Il2CppClassPointerStore<SwitchMagicOutputHIDUSB>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SwitchProControllerHID>.NativeClassPtr, "SwitchMagicOutputHIDUSB");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SwitchMagicOutputHIDUSB>.NativeClassPtr);
			NativeFieldInfoPtr_kSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwitchMagicOutputHIDUSB>.NativeClassPtr, "kSize");
			NativeFieldInfoPtr_baseCommand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwitchMagicOutputHIDUSB>.NativeClassPtr, "baseCommand");
			NativeFieldInfoPtr_report = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwitchMagicOutputHIDUSB>.NativeClassPtr, "report");
			NativeMethodInfoPtr_get_Type_Public_Static_get_FourCC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SwitchMagicOutputHIDUSB>.NativeClassPtr, 100666947);
			NativeMethodInfoPtr_get_typeStatic_Public_Virtual_Final_New_get_FourCC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SwitchMagicOutputHIDUSB>.NativeClassPtr, 100666948);
			NativeMethodInfoPtr_Create_Public_Static_SwitchMagicOutputHIDUSB_CommandIdType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SwitchMagicOutputHIDUSB>.NativeClassPtr, 100666949);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1004272, XrefRangeEnd = 1004274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SwitchMagicOutputHIDUSB Create(SwitchMagicOutputReport.CommandIdType type)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&type);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Create_Public_Static_SwitchMagicOutputHIDUSB_CommandIdType_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(SwitchMagicOutputHIDUSB*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SwitchMagicOutputHIDUSB>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr__captureButton_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__homeButton_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_HandshakeSequence;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_HandshakeStepIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_HandshakeTimer;

	private static readonly System.IntPtr NativeFieldInfoPtr_JitterMaskLow;

	private static readonly System.IntPtr NativeFieldInfoPtr_JitterMaskHigh;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_captureButton_Public_get_ButtonControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_captureButton_Protected_set_Void_ButtonControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_homeButton_Public_get_ButtonControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_homeButton_Protected_set_Void_ButtonControl_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnAdded_Protected_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HandshakeRestart_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HandshakeTick_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnNextUpdate_Public_Virtual_Final_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnStateEvent_Public_Virtual_Final_New_Void_InputEventPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetStateOffsetForEvent_Public_Virtual_Final_New_Boolean_InputControl_InputEventPtr_byref_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PreProcessEvent_Public_Virtual_Final_New_Boolean_InputEventPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe ButtonControl _captureButton_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__captureButton_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ButtonControl>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__captureButton_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe ButtonControl _homeButton_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__homeButton_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ButtonControl>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__homeButton_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<SwitchMagicOutputReport.CommandIdType> s_HandshakeSequence
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_HandshakeSequence, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<SwitchMagicOutputReport.CommandIdType>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_HandshakeSequence, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe int m_HandshakeStepIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_HandshakeStepIndex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_HandshakeStepIndex)) = value;
		}
	}

	public unsafe double m_HandshakeTimer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_HandshakeTimer);
			return *(double*)num;
		}
		set
		{
			*(double*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_HandshakeTimer)) = value;
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

	public unsafe ButtonControl captureButton
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_captureButton_Public_get_ButtonControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
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
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_captureButton_Protected_set_Void_ButtonControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe ButtonControl homeButton
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_homeButton_Public_get_ButtonControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
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
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_homeButton_Protected_set_Void_ButtonControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	static SwitchProControllerHID()
	{
		Il2CppClassPointerStore<SwitchProControllerHID>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.InputSystem.dll", "UnityEngine.InputSystem.Switch", "SwitchProControllerHID");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SwitchProControllerHID>.NativeClassPtr);
		NativeFieldInfoPtr__captureButton_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwitchProControllerHID>.NativeClassPtr, "<captureButton>k__BackingField");
		NativeFieldInfoPtr__homeButton_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwitchProControllerHID>.NativeClassPtr, "<homeButton>k__BackingField");
		NativeFieldInfoPtr_s_HandshakeSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwitchProControllerHID>.NativeClassPtr, "s_HandshakeSequence");
		NativeFieldInfoPtr_m_HandshakeStepIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwitchProControllerHID>.NativeClassPtr, "m_HandshakeStepIndex");
		NativeFieldInfoPtr_m_HandshakeTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwitchProControllerHID>.NativeClassPtr, "m_HandshakeTimer");
		NativeFieldInfoPtr_JitterMaskLow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwitchProControllerHID>.NativeClassPtr, "JitterMaskLow");
		NativeFieldInfoPtr_JitterMaskHigh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwitchProControllerHID>.NativeClassPtr, "JitterMaskHigh");
		NativeMethodInfoPtr_get_captureButton_Public_get_ButtonControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SwitchProControllerHID>.NativeClassPtr, 100666927);
		NativeMethodInfoPtr_set_captureButton_Protected_set_Void_ButtonControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SwitchProControllerHID>.NativeClassPtr, 100666928);
		NativeMethodInfoPtr_get_homeButton_Public_get_ButtonControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SwitchProControllerHID>.NativeClassPtr, 100666929);
		NativeMethodInfoPtr_set_homeButton_Protected_set_Void_ButtonControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SwitchProControllerHID>.NativeClassPtr, 100666930);
		NativeMethodInfoPtr_OnAdded_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SwitchProControllerHID>.NativeClassPtr, 100666931);
		NativeMethodInfoPtr_HandshakeRestart_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SwitchProControllerHID>.NativeClassPtr, 100666932);
		NativeMethodInfoPtr_HandshakeTick_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SwitchProControllerHID>.NativeClassPtr, 100666933);
		NativeMethodInfoPtr_OnNextUpdate_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SwitchProControllerHID>.NativeClassPtr, 100666934);
		NativeMethodInfoPtr_OnStateEvent_Public_Virtual_Final_New_Void_InputEventPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SwitchProControllerHID>.NativeClassPtr, 100666935);
		NativeMethodInfoPtr_GetStateOffsetForEvent_Public_Virtual_Final_New_Boolean_InputControl_InputEventPtr_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SwitchProControllerHID>.NativeClassPtr, 100666936);
		NativeMethodInfoPtr_PreProcessEvent_Public_Virtual_Final_New_Boolean_InputEventPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SwitchProControllerHID>.NativeClassPtr, 100666937);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SwitchProControllerHID>.NativeClassPtr, 100666938);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1004274, XrefRangeEnd = 1004291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void OnAdded()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_OnAdded_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1004291, XrefRangeEnd = 1004296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HandshakeRestart()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HandshakeRestart_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1004319, RefRangeEnd = 1004320, XrefRangeStart = 1004296, XrefRangeEnd = 1004319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HandshakeTick()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HandshakeTick_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1004320, XrefRangeEnd = 1004321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void OnNextUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnNextUpdate_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1004321, XrefRangeEnd = 1004339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1004339, XrefRangeEnd = 1004355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual bool PreProcessEvent(InputEventPtr eventPtr)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&eventPtr);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PreProcessEvent_Public_Virtual_Final_New_Boolean_InputEventPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 963305, RefRangeEnd = 963314, XrefRangeStart = 963305, XrefRangeEnd = 963314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SwitchProControllerHID()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SwitchProControllerHID>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public SwitchProControllerHID(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
