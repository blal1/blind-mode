using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.LowLevel;

[StructLayout(LayoutKind.Explicit)]
public struct PenState
{
	private static readonly System.IntPtr NativeFieldInfoPtr_position;

	private static readonly System.IntPtr NativeFieldInfoPtr_delta;

	private static readonly System.IntPtr NativeFieldInfoPtr_tilt;

	private static readonly System.IntPtr NativeFieldInfoPtr_pressure;

	private static readonly System.IntPtr NativeFieldInfoPtr_twist;

	private static readonly System.IntPtr NativeFieldInfoPtr_buttons;

	private static readonly System.IntPtr NativeFieldInfoPtr_displayIndex;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Format_Public_Static_get_FourCC_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WithButton_Public_PenState_PenButton_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_format_Public_Virtual_Final_New_get_FourCC_0;

	[FieldOffset(0)]
	public Vector2 position;

	[FieldOffset(8)]
	public Vector2 delta;

	[FieldOffset(16)]
	public Vector2 tilt;

	[FieldOffset(24)]
	public float pressure;

	[FieldOffset(28)]
	public float twist;

	[FieldOffset(32)]
	public ushort buttons;

	[FieldOffset(34)]
	public ushort displayIndex;

	public unsafe static FourCC Format
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1008042, XrefRangeEnd = 1008043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1008044, XrefRangeEnd = 1008045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_format_Public_Virtual_Final_New_get_FourCC_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(FourCC*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static PenState()
	{
		Il2CppClassPointerStore<PenState>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.InputSystem.dll", "UnityEngine.InputSystem.LowLevel", "PenState");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PenState>.NativeClassPtr);
		NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PenState>.NativeClassPtr, "position");
		NativeFieldInfoPtr_delta = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PenState>.NativeClassPtr, "delta");
		NativeFieldInfoPtr_tilt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PenState>.NativeClassPtr, "tilt");
		NativeFieldInfoPtr_pressure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PenState>.NativeClassPtr, "pressure");
		NativeFieldInfoPtr_twist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PenState>.NativeClassPtr, "twist");
		NativeFieldInfoPtr_buttons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PenState>.NativeClassPtr, "buttons");
		NativeFieldInfoPtr_displayIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PenState>.NativeClassPtr, "displayIndex");
		NativeMethodInfoPtr_get_Format_Public_Static_get_FourCC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PenState>.NativeClassPtr, 100667401);
		NativeMethodInfoPtr_WithButton_Public_PenState_PenButton_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PenState>.NativeClassPtr, 100667402);
		NativeMethodInfoPtr_get_format_Public_Virtual_Final_New_get_FourCC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PenState>.NativeClassPtr, 100667403);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1008043, XrefRangeEnd = 1008044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PenState WithButton(PenButton button, bool state = true)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&button);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &state;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WithButton_Public_PenState_PenButton_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(PenState*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PenState>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
