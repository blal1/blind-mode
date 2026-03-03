using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.LowLevel;

[StructLayout(LayoutKind.Explicit)]
public struct GamepadState
{
	private static readonly System.IntPtr NativeFieldInfoPtr_ButtonSouthShortDisplayName;

	private static readonly System.IntPtr NativeFieldInfoPtr_ButtonNorthShortDisplayName;

	private static readonly System.IntPtr NativeFieldInfoPtr_ButtonWestShortDisplayName;

	private static readonly System.IntPtr NativeFieldInfoPtr_ButtonEastShortDisplayName;

	private static readonly System.IntPtr NativeFieldInfoPtr_buttons;

	private static readonly System.IntPtr NativeFieldInfoPtr_leftStick;

	private static readonly System.IntPtr NativeFieldInfoPtr_rightStick;

	private static readonly System.IntPtr NativeFieldInfoPtr_leftTrigger;

	private static readonly System.IntPtr NativeFieldInfoPtr_rightTrigger;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Format_Public_Static_get_FourCC_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_format_Public_Virtual_Final_New_get_FourCC_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_GamepadButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WithButton_Public_GamepadState_GamepadButton_Boolean_0;

	[FieldOffset(0)]
	public uint buttons;

	[FieldOffset(4)]
	public Vector2 leftStick;

	[FieldOffset(12)]
	public Vector2 rightStick;

	[FieldOffset(20)]
	public float leftTrigger;

	[FieldOffset(24)]
	public float rightTrigger;

	public unsafe static string ButtonSouthShortDisplayName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ButtonSouthShortDisplayName, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ButtonSouthShortDisplayName, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string ButtonNorthShortDisplayName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ButtonNorthShortDisplayName, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ButtonNorthShortDisplayName, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string ButtonWestShortDisplayName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ButtonWestShortDisplayName, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ButtonWestShortDisplayName, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string ButtonEastShortDisplayName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ButtonEastShortDisplayName, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ButtonEastShortDisplayName, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static FourCC Format
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1008004, XrefRangeEnd = 1008005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Format_Public_Static_get_FourCC_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(FourCC*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe virtual FourCC format
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1008005, XrefRangeEnd = 1008006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_format_Public_Virtual_Final_New_get_FourCC_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(FourCC*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static GamepadState()
	{
		Il2CppClassPointerStore<GamepadState>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.InputSystem.dll", "UnityEngine.InputSystem.LowLevel", "GamepadState");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GamepadState>.NativeClassPtr);
		NativeFieldInfoPtr_ButtonSouthShortDisplayName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadState>.NativeClassPtr, "ButtonSouthShortDisplayName");
		NativeFieldInfoPtr_ButtonNorthShortDisplayName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadState>.NativeClassPtr, "ButtonNorthShortDisplayName");
		NativeFieldInfoPtr_ButtonWestShortDisplayName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadState>.NativeClassPtr, "ButtonWestShortDisplayName");
		NativeFieldInfoPtr_ButtonEastShortDisplayName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadState>.NativeClassPtr, "ButtonEastShortDisplayName");
		NativeFieldInfoPtr_buttons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadState>.NativeClassPtr, "buttons");
		NativeFieldInfoPtr_leftStick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadState>.NativeClassPtr, "leftStick");
		NativeFieldInfoPtr_rightStick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadState>.NativeClassPtr, "rightStick");
		NativeFieldInfoPtr_leftTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadState>.NativeClassPtr, "leftTrigger");
		NativeFieldInfoPtr_rightTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GamepadState>.NativeClassPtr, "rightTrigger");
		NativeMethodInfoPtr_get_Format_Public_Static_get_FourCC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadState>.NativeClassPtr, 100667375);
		NativeMethodInfoPtr_get_format_Public_Virtual_Final_New_get_FourCC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadState>.NativeClassPtr, 100667376);
		NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_GamepadButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadState>.NativeClassPtr, 100667377);
		NativeMethodInfoPtr_WithButton_Public_GamepadState_GamepadButton_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GamepadState>.NativeClassPtr, 100667378);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1008006, XrefRangeEnd = 1008007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GamepadState([Optional] Il2CppStructArray<GamepadButton> buttons)
	{
		if (buttons == null)
		{
			buttons = new Il2CppStructArray<GamepadButton>(0L);
		}
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buttons);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_GamepadButton_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1008007, XrefRangeEnd = 1008008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GamepadState WithButton(GamepadButton button, bool value = true)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&button);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WithButton_Public_GamepadState_GamepadButton_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(GamepadState*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public GamepadState(params GamepadButton[] buttons)
		: this(new Il2CppStructArray<GamepadButton>(buttons))
	{
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GamepadState>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
