using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.DualShock.LowLevel;

[StructLayout(LayoutKind.Explicit)]
public struct DualShock3HIDInputReport
{
	[StructLayout(LayoutKind.Explicit)]
	[ObfuscatedName("UnityEngine.InputSystem.DualShock.LowLevel.DualShock3HIDInputReport+<padding3>e__FixedBuffer")]
	public struct _padding3_e__FixedBuffer
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_FixedElementField;

		[FieldOffset(0)]
		public byte FixedElementField;

		static _padding3_e__FixedBuffer()
		{
			Il2CppClassPointerStore<_padding3_e__FixedBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DualShock3HIDInputReport>.NativeClassPtr, "<padding3>e__FixedBuffer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<_padding3_e__FixedBuffer>.NativeClassPtr);
			NativeFieldInfoPtr_FixedElementField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_padding3_e__FixedBuffer>.NativeClassPtr, "FixedElementField");
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<_padding3_e__FixedBuffer>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_padding1;

	private static readonly System.IntPtr NativeFieldInfoPtr_buttons1;

	private static readonly System.IntPtr NativeFieldInfoPtr_buttons2;

	private static readonly System.IntPtr NativeFieldInfoPtr_buttons3;

	private static readonly System.IntPtr NativeFieldInfoPtr_padding2;

	private static readonly System.IntPtr NativeFieldInfoPtr_leftStickX;

	private static readonly System.IntPtr NativeFieldInfoPtr_leftStickY;

	private static readonly System.IntPtr NativeFieldInfoPtr_rightStickX;

	private static readonly System.IntPtr NativeFieldInfoPtr_rightStickY;

	private static readonly System.IntPtr NativeFieldInfoPtr_padding3;

	private static readonly System.IntPtr NativeFieldInfoPtr_leftTrigger;

	private static readonly System.IntPtr NativeFieldInfoPtr_rightTrigger;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_format_Public_Virtual_Final_New_get_FourCC_0;

	[FieldOffset(0)]
	public ushort padding1;

	[FieldOffset(2)]
	public byte buttons1;

	[FieldOffset(3)]
	public byte buttons2;

	[FieldOffset(4)]
	public byte buttons3;

	[FieldOffset(5)]
	public byte padding2;

	[FieldOffset(6)]
	public byte leftStickX;

	[FieldOffset(7)]
	public byte leftStickY;

	[FieldOffset(8)]
	public byte rightStickX;

	[FieldOffset(9)]
	public byte rightStickY;

	[FieldOffset(10)]
	public _padding3_e__FixedBuffer padding3;

	[FieldOffset(18)]
	public byte leftTrigger;

	[FieldOffset(19)]
	public byte rightTrigger;

	public unsafe virtual FourCC format
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1007797, XrefRangeEnd = 1007798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_format_Public_Virtual_Final_New_get_FourCC_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(FourCC*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static DualShock3HIDInputReport()
	{
		Il2CppClassPointerStore<DualShock3HIDInputReport>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.InputSystem.dll", "UnityEngine.InputSystem.DualShock.LowLevel", "DualShock3HIDInputReport");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DualShock3HIDInputReport>.NativeClassPtr);
		NativeFieldInfoPtr_padding1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock3HIDInputReport>.NativeClassPtr, "padding1");
		NativeFieldInfoPtr_buttons1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock3HIDInputReport>.NativeClassPtr, "buttons1");
		NativeFieldInfoPtr_buttons2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock3HIDInputReport>.NativeClassPtr, "buttons2");
		NativeFieldInfoPtr_buttons3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock3HIDInputReport>.NativeClassPtr, "buttons3");
		NativeFieldInfoPtr_padding2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock3HIDInputReport>.NativeClassPtr, "padding2");
		NativeFieldInfoPtr_leftStickX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock3HIDInputReport>.NativeClassPtr, "leftStickX");
		NativeFieldInfoPtr_leftStickY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock3HIDInputReport>.NativeClassPtr, "leftStickY");
		NativeFieldInfoPtr_rightStickX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock3HIDInputReport>.NativeClassPtr, "rightStickX");
		NativeFieldInfoPtr_rightStickY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock3HIDInputReport>.NativeClassPtr, "rightStickY");
		NativeFieldInfoPtr_padding3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock3HIDInputReport>.NativeClassPtr, "padding3");
		NativeFieldInfoPtr_leftTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock3HIDInputReport>.NativeClassPtr, "leftTrigger");
		NativeFieldInfoPtr_rightTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock3HIDInputReport>.NativeClassPtr, "rightTrigger");
		NativeMethodInfoPtr_get_format_Public_Virtual_Final_New_get_FourCC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock3HIDInputReport>.NativeClassPtr, 100667273);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DualShock3HIDInputReport>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
