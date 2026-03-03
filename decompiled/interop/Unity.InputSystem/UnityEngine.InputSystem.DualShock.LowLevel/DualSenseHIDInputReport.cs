using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.DualShock.LowLevel;

[StructLayout(LayoutKind.Explicit)]
public struct DualSenseHIDInputReport
{
	private static readonly System.IntPtr NativeFieldInfoPtr_Format;

	private static readonly System.IntPtr NativeFieldInfoPtr_leftStickX;

	private static readonly System.IntPtr NativeFieldInfoPtr_leftStickY;

	private static readonly System.IntPtr NativeFieldInfoPtr_rightStickX;

	private static readonly System.IntPtr NativeFieldInfoPtr_rightStickY;

	private static readonly System.IntPtr NativeFieldInfoPtr_leftTrigger;

	private static readonly System.IntPtr NativeFieldInfoPtr_rightTrigger;

	private static readonly System.IntPtr NativeFieldInfoPtr_buttons0;

	private static readonly System.IntPtr NativeFieldInfoPtr_buttons1;

	private static readonly System.IntPtr NativeFieldInfoPtr_buttons2;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_format_Public_Virtual_Final_New_get_FourCC_0;

	[FieldOffset(0)]
	public byte leftStickX;

	[FieldOffset(1)]
	public byte leftStickY;

	[FieldOffset(2)]
	public byte rightStickX;

	[FieldOffset(3)]
	public byte rightStickY;

	[FieldOffset(4)]
	public byte leftTrigger;

	[FieldOffset(5)]
	public byte rightTrigger;

	[FieldOffset(6)]
	public byte buttons0;

	[FieldOffset(7)]
	public byte buttons1;

	[FieldOffset(8)]
	public byte buttons2;

	public unsafe static FourCC Format
	{
		get
		{
			Unsafe.SkipInit(out FourCC result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Format, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Format, (void*)(&value));
		}
	}

	public unsafe virtual FourCC format
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1007787, XrefRangeEnd = 1007791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_format_Public_Virtual_Final_New_get_FourCC_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(FourCC*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static DualSenseHIDInputReport()
	{
		Il2CppClassPointerStore<DualSenseHIDInputReport>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.InputSystem.dll", "UnityEngine.InputSystem.DualShock.LowLevel", "DualSenseHIDInputReport");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DualSenseHIDInputReport>.NativeClassPtr);
		NativeFieldInfoPtr_Format = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseHIDInputReport>.NativeClassPtr, "Format");
		NativeFieldInfoPtr_leftStickX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseHIDInputReport>.NativeClassPtr, "leftStickX");
		NativeFieldInfoPtr_leftStickY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseHIDInputReport>.NativeClassPtr, "leftStickY");
		NativeFieldInfoPtr_rightStickX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseHIDInputReport>.NativeClassPtr, "rightStickX");
		NativeFieldInfoPtr_rightStickY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseHIDInputReport>.NativeClassPtr, "rightStickY");
		NativeFieldInfoPtr_leftTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseHIDInputReport>.NativeClassPtr, "leftTrigger");
		NativeFieldInfoPtr_rightTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseHIDInputReport>.NativeClassPtr, "rightTrigger");
		NativeFieldInfoPtr_buttons0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseHIDInputReport>.NativeClassPtr, "buttons0");
		NativeFieldInfoPtr_buttons1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseHIDInputReport>.NativeClassPtr, "buttons1");
		NativeFieldInfoPtr_buttons2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseHIDInputReport>.NativeClassPtr, "buttons2");
		NativeMethodInfoPtr_get_format_Public_Virtual_Final_New_get_FourCC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseHIDInputReport>.NativeClassPtr, 100667263);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DualSenseHIDInputReport>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
