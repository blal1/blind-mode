using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.DualShock.LowLevel;

[StructLayout(LayoutKind.Explicit)]
public struct DualShock4HIDInputReport
{
	private static readonly System.IntPtr NativeFieldInfoPtr_Format;

	private static readonly System.IntPtr NativeFieldInfoPtr_leftStickX;

	private static readonly System.IntPtr NativeFieldInfoPtr_leftStickY;

	private static readonly System.IntPtr NativeFieldInfoPtr_rightStickX;

	private static readonly System.IntPtr NativeFieldInfoPtr_rightStickY;

	private static readonly System.IntPtr NativeFieldInfoPtr_buttons1;

	private static readonly System.IntPtr NativeFieldInfoPtr_buttons2;

	private static readonly System.IntPtr NativeFieldInfoPtr_buttons3;

	private static readonly System.IntPtr NativeFieldInfoPtr_leftTrigger;

	private static readonly System.IntPtr NativeFieldInfoPtr_rightTrigger;

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
	public byte buttons1;

	[FieldOffset(5)]
	public byte buttons2;

	[FieldOffset(6)]
	public byte buttons3;

	[FieldOffset(7)]
	public byte leftTrigger;

	[FieldOffset(8)]
	public byte rightTrigger;

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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1007793, XrefRangeEnd = 1007797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_format_Public_Virtual_Final_New_get_FourCC_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(FourCC*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static DualShock4HIDInputReport()
	{
		Il2CppClassPointerStore<DualShock4HIDInputReport>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.InputSystem.dll", "UnityEngine.InputSystem.DualShock.LowLevel", "DualShock4HIDInputReport");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DualShock4HIDInputReport>.NativeClassPtr);
		NativeFieldInfoPtr_Format = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4HIDInputReport>.NativeClassPtr, "Format");
		NativeFieldInfoPtr_leftStickX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4HIDInputReport>.NativeClassPtr, "leftStickX");
		NativeFieldInfoPtr_leftStickY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4HIDInputReport>.NativeClassPtr, "leftStickY");
		NativeFieldInfoPtr_rightStickX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4HIDInputReport>.NativeClassPtr, "rightStickX");
		NativeFieldInfoPtr_rightStickY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4HIDInputReport>.NativeClassPtr, "rightStickY");
		NativeFieldInfoPtr_buttons1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4HIDInputReport>.NativeClassPtr, "buttons1");
		NativeFieldInfoPtr_buttons2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4HIDInputReport>.NativeClassPtr, "buttons2");
		NativeFieldInfoPtr_buttons3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4HIDInputReport>.NativeClassPtr, "buttons3");
		NativeFieldInfoPtr_leftTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4HIDInputReport>.NativeClassPtr, "leftTrigger");
		NativeFieldInfoPtr_rightTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4HIDInputReport>.NativeClassPtr, "rightTrigger");
		NativeMethodInfoPtr_get_format_Public_Virtual_Final_New_get_FourCC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4HIDInputReport>.NativeClassPtr, 100667271);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DualShock4HIDInputReport>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
