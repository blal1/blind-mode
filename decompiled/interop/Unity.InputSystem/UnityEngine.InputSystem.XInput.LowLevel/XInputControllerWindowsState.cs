using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.XInput.LowLevel;

[StructLayout(LayoutKind.Explicit)]
public struct XInputControllerWindowsState
{
	[OriginalName("Unity.InputSystem.dll", "", "Button")]
	public enum Button
	{
		DPadUp = 0,
		DPadDown = 1,
		DPadLeft = 2,
		DPadRight = 3,
		Start = 4,
		Select = 5,
		LeftThumbstickPress = 6,
		RightThumbstickPress = 7,
		LeftShoulder = 8,
		RightShoulder = 9,
		A = 12,
		B = 13,
		X = 14,
		Y = 15
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_buttons;

	private static readonly System.IntPtr NativeFieldInfoPtr_leftTrigger;

	private static readonly System.IntPtr NativeFieldInfoPtr_rightTrigger;

	private static readonly System.IntPtr NativeFieldInfoPtr_leftStickX;

	private static readonly System.IntPtr NativeFieldInfoPtr_leftStickY;

	private static readonly System.IntPtr NativeFieldInfoPtr_rightStickX;

	private static readonly System.IntPtr NativeFieldInfoPtr_rightStickY;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_format_Public_Virtual_Final_New_get_FourCC_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WithButton_Public_XInputControllerWindowsState_Button_0;

	[FieldOffset(0)]
	public ushort buttons;

	[FieldOffset(2)]
	public byte leftTrigger;

	[FieldOffset(3)]
	public byte rightTrigger;

	[FieldOffset(4)]
	public short leftStickX;

	[FieldOffset(6)]
	public short leftStickY;

	[FieldOffset(8)]
	public short rightStickX;

	[FieldOffset(10)]
	public short rightStickY;

	public unsafe virtual FourCC format
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1000490, XrefRangeEnd = 1000491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_format_Public_Virtual_Final_New_get_FourCC_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(FourCC*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static XInputControllerWindowsState()
	{
		Il2CppClassPointerStore<XInputControllerWindowsState>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.InputSystem.dll", "UnityEngine.InputSystem.XInput.LowLevel", "XInputControllerWindowsState");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XInputControllerWindowsState>.NativeClassPtr);
		NativeFieldInfoPtr_buttons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XInputControllerWindowsState>.NativeClassPtr, "buttons");
		NativeFieldInfoPtr_leftTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XInputControllerWindowsState>.NativeClassPtr, "leftTrigger");
		NativeFieldInfoPtr_rightTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XInputControllerWindowsState>.NativeClassPtr, "rightTrigger");
		NativeFieldInfoPtr_leftStickX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XInputControllerWindowsState>.NativeClassPtr, "leftStickX");
		NativeFieldInfoPtr_leftStickY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XInputControllerWindowsState>.NativeClassPtr, "leftStickY");
		NativeFieldInfoPtr_rightStickX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XInputControllerWindowsState>.NativeClassPtr, "rightStickX");
		NativeFieldInfoPtr_rightStickY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XInputControllerWindowsState>.NativeClassPtr, "rightStickY");
		NativeMethodInfoPtr_get_format_Public_Virtual_Final_New_get_FourCC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XInputControllerWindowsState>.NativeClassPtr, 100666566);
		NativeMethodInfoPtr_WithButton_Public_XInputControllerWindowsState_Button_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XInputControllerWindowsState>.NativeClassPtr, 100666567);
	}

	[CallerCount(0)]
	public unsafe XInputControllerWindowsState WithButton(Button button)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&button);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WithButton_Public_XInputControllerWindowsState_Button_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(XInputControllerWindowsState*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<XInputControllerWindowsState>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
