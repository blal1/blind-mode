using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.LowLevel;

[StructLayout(LayoutKind.Explicit)]
public struct PointerState
{
	private static readonly System.IntPtr NativeFieldInfoPtr_pointerId;

	private static readonly System.IntPtr NativeFieldInfoPtr_position;

	private static readonly System.IntPtr NativeFieldInfoPtr_delta;

	private static readonly System.IntPtr NativeFieldInfoPtr_pressure;

	private static readonly System.IntPtr NativeFieldInfoPtr_radius;

	private static readonly System.IntPtr NativeFieldInfoPtr_buttons;

	private static readonly System.IntPtr NativeFieldInfoPtr_displayIndex;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_kFormat_Public_Static_get_FourCC_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_format_Public_Virtual_Final_New_get_FourCC_0;

	[FieldOffset(0)]
	public uint pointerId;

	[FieldOffset(4)]
	public Vector2 position;

	[FieldOffset(12)]
	public Vector2 delta;

	[FieldOffset(20)]
	public float pressure;

	[FieldOffset(24)]
	public Vector2 radius;

	[FieldOffset(32)]
	public ushort buttons;

	[FieldOffset(34)]
	public ushort displayIndex;

	public unsafe static FourCC kFormat
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1008045, XrefRangeEnd = 1008046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_kFormat_Public_Static_get_FourCC_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(FourCC*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe virtual FourCC format
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1008046, XrefRangeEnd = 1008047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_format_Public_Virtual_Final_New_get_FourCC_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(FourCC*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static PointerState()
	{
		Il2CppClassPointerStore<PointerState>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.InputSystem.dll", "UnityEngine.InputSystem.LowLevel", "PointerState");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PointerState>.NativeClassPtr);
		NativeFieldInfoPtr_pointerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerState>.NativeClassPtr, "pointerId");
		NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerState>.NativeClassPtr, "position");
		NativeFieldInfoPtr_delta = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerState>.NativeClassPtr, "delta");
		NativeFieldInfoPtr_pressure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerState>.NativeClassPtr, "pressure");
		NativeFieldInfoPtr_radius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerState>.NativeClassPtr, "radius");
		NativeFieldInfoPtr_buttons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerState>.NativeClassPtr, "buttons");
		NativeFieldInfoPtr_displayIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PointerState>.NativeClassPtr, "displayIndex");
		NativeMethodInfoPtr_get_kFormat_Public_Static_get_FourCC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerState>.NativeClassPtr, 100667404);
		NativeMethodInfoPtr_get_format_Public_Virtual_Final_New_get_FourCC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PointerState>.NativeClassPtr, 100667405);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PointerState>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
