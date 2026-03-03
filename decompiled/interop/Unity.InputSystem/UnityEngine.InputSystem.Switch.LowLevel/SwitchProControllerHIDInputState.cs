using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.Switch.LowLevel;

[StructLayout(LayoutKind.Explicit)]
public struct SwitchProControllerHIDInputState
{
	[OriginalName("Unity.InputSystem.dll", "", "Button")]
	public enum Button
	{
		Up = 0,
		Right = 1,
		Down = 2,
		Left = 3,
		West = 4,
		North = 5,
		South = 6,
		East = 7,
		L = 8,
		R = 9,
		StickL = 10,
		StickR = 11,
		ZL = 12,
		ZR = 13,
		Plus = 14,
		Minus = 15,
		Capture = 16,
		Home = 17,
		X = 5,
		B = 6,
		Y = 4,
		A = 7
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_Format;

	private static readonly System.IntPtr NativeFieldInfoPtr_leftStickX;

	private static readonly System.IntPtr NativeFieldInfoPtr_leftStickY;

	private static readonly System.IntPtr NativeFieldInfoPtr_rightStickX;

	private static readonly System.IntPtr NativeFieldInfoPtr_rightStickY;

	private static readonly System.IntPtr NativeFieldInfoPtr_buttons1;

	private static readonly System.IntPtr NativeFieldInfoPtr_buttons2;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_format_Public_Virtual_Final_New_get_FourCC_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WithButton_Public_SwitchProControllerHIDInputState_Button_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_Button_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Press_Public_Void_Button_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Release_Public_Void_Button_0;

	[FieldOffset(0)]
	public byte leftStickX;

	[FieldOffset(1)]
	public byte leftStickY;

	[FieldOffset(2)]
	public byte rightStickX;

	[FieldOffset(3)]
	public byte rightStickY;

	[FieldOffset(4)]
	public ushort buttons1;

	[FieldOffset(6)]
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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1004542, XrefRangeEnd = 1004546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_format_Public_Virtual_Final_New_get_FourCC_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(FourCC*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static SwitchProControllerHIDInputState()
	{
		Il2CppClassPointerStore<SwitchProControllerHIDInputState>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.InputSystem.dll", "UnityEngine.InputSystem.Switch.LowLevel", "SwitchProControllerHIDInputState");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SwitchProControllerHIDInputState>.NativeClassPtr);
		NativeFieldInfoPtr_Format = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwitchProControllerHIDInputState>.NativeClassPtr, "Format");
		NativeFieldInfoPtr_leftStickX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwitchProControllerHIDInputState>.NativeClassPtr, "leftStickX");
		NativeFieldInfoPtr_leftStickY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwitchProControllerHIDInputState>.NativeClassPtr, "leftStickY");
		NativeFieldInfoPtr_rightStickX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwitchProControllerHIDInputState>.NativeClassPtr, "rightStickX");
		NativeFieldInfoPtr_rightStickY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwitchProControllerHIDInputState>.NativeClassPtr, "rightStickY");
		NativeFieldInfoPtr_buttons1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwitchProControllerHIDInputState>.NativeClassPtr, "buttons1");
		NativeFieldInfoPtr_buttons2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwitchProControllerHIDInputState>.NativeClassPtr, "buttons2");
		NativeMethodInfoPtr_get_format_Public_Virtual_Final_New_get_FourCC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SwitchProControllerHIDInputState>.NativeClassPtr, 100666951);
		NativeMethodInfoPtr_WithButton_Public_SwitchProControllerHIDInputState_Button_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SwitchProControllerHIDInputState>.NativeClassPtr, 100666952);
		NativeMethodInfoPtr_Set_Public_Void_Button_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SwitchProControllerHIDInputState>.NativeClassPtr, 100666953);
		NativeMethodInfoPtr_Press_Public_Void_Button_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SwitchProControllerHIDInputState>.NativeClassPtr, 100666954);
		NativeMethodInfoPtr_Release_Public_Void_Button_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SwitchProControllerHIDInputState>.NativeClassPtr, 100666955);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1004546, XrefRangeEnd = 1004552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SwitchProControllerHIDInputState WithButton(Button button, bool value = true)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&button);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WithButton_Public_SwitchProControllerHIDInputState_Button_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(SwitchProControllerHIDInputState*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe void Set(Button button, bool state)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&button);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &state;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Set_Public_Void_Button_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1004552, XrefRangeEnd = 1004555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Press(Button button)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&button);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Press_Public_Void_Button_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1004555, XrefRangeEnd = 1004558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Release(Button button)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&button);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Release_Public_Void_Button_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SwitchProControllerHIDInputState>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
