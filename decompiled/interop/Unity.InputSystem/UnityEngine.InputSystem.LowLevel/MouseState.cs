using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.LowLevel;

[StructLayout(LayoutKind.Explicit)]
public struct MouseState
{
	private static readonly System.IntPtr NativeFieldInfoPtr_position;

	private static readonly System.IntPtr NativeFieldInfoPtr_delta;

	private static readonly System.IntPtr NativeFieldInfoPtr_scroll;

	private static readonly System.IntPtr NativeFieldInfoPtr_buttons;

	private static readonly System.IntPtr NativeFieldInfoPtr_displayIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_clickCount;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Format_Public_Static_get_FourCC_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WithButton_Public_MouseState_MouseButton_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_format_Public_Virtual_Final_New_get_FourCC_0;

	[FieldOffset(0)]
	public Vector2 position;

	[FieldOffset(8)]
	public Vector2 delta;

	[FieldOffset(16)]
	public Vector2 scroll;

	[FieldOffset(24)]
	public ushort buttons;

	[FieldOffset(26)]
	public ushort displayIndex;

	[FieldOffset(28)]
	public ushort clickCount;

	public unsafe static FourCC Format
	{
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1008031, RefRangeEnd = 1008037, XrefRangeStart = 1008030, XrefRangeEnd = 1008031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1008040, RefRangeEnd = 1008042, XrefRangeStart = 1008039, XrefRangeEnd = 1008040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_format_Public_Virtual_Final_New_get_FourCC_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(FourCC*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static MouseState()
	{
		Il2CppClassPointerStore<MouseState>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.InputSystem.dll", "UnityEngine.InputSystem.LowLevel", "MouseState");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MouseState>.NativeClassPtr);
		NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseState>.NativeClassPtr, "position");
		NativeFieldInfoPtr_delta = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseState>.NativeClassPtr, "delta");
		NativeFieldInfoPtr_scroll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseState>.NativeClassPtr, "scroll");
		NativeFieldInfoPtr_buttons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseState>.NativeClassPtr, "buttons");
		NativeFieldInfoPtr_displayIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseState>.NativeClassPtr, "displayIndex");
		NativeFieldInfoPtr_clickCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MouseState>.NativeClassPtr, "clickCount");
		NativeMethodInfoPtr_get_Format_Public_Static_get_FourCC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseState>.NativeClassPtr, 100667398);
		NativeMethodInfoPtr_WithButton_Public_MouseState_MouseButton_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseState>.NativeClassPtr, 100667399);
		NativeMethodInfoPtr_get_format_Public_Virtual_Final_New_get_FourCC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MouseState>.NativeClassPtr, 100667400);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1008038, RefRangeEnd = 1008039, XrefRangeStart = 1008037, XrefRangeEnd = 1008038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MouseState WithButton(MouseButton button, bool state = true)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&button);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &state;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WithButton_Public_MouseState_MouseButton_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(MouseState*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MouseState>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
