using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.DualShock.LowLevel;

[StructLayout(LayoutKind.Explicit)]
public struct DualShockHIDOutputReport
{
	[OriginalName("Unity.InputSystem.dll", "", "Flags")]
	[System.Flags]
	public enum Flags
	{
		Rumble = 1,
		Color = 2
	}

	[StructLayout(LayoutKind.Explicit)]
	[ObfuscatedName("UnityEngine.InputSystem.DualShock.LowLevel.DualShockHIDOutputReport+<unknown1>e__FixedBuffer")]
	public struct _unknown1_e__FixedBuffer
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_FixedElementField;

		[FieldOffset(0)]
		public byte FixedElementField;

		static _unknown1_e__FixedBuffer()
		{
			Il2CppClassPointerStore<_unknown1_e__FixedBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DualShockHIDOutputReport>.NativeClassPtr, "<unknown1>e__FixedBuffer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<_unknown1_e__FixedBuffer>.NativeClassPtr);
			NativeFieldInfoPtr_FixedElementField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_unknown1_e__FixedBuffer>.NativeClassPtr, "FixedElementField");
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<_unknown1_e__FixedBuffer>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	[ObfuscatedName("UnityEngine.InputSystem.DualShock.LowLevel.DualShockHIDOutputReport+<unknown2>e__FixedBuffer")]
	public struct _unknown2_e__FixedBuffer
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_FixedElementField;

		[FieldOffset(0)]
		public byte FixedElementField;

		static _unknown2_e__FixedBuffer()
		{
			Il2CppClassPointerStore<_unknown2_e__FixedBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DualShockHIDOutputReport>.NativeClassPtr, "<unknown2>e__FixedBuffer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<_unknown2_e__FixedBuffer>.NativeClassPtr);
			NativeFieldInfoPtr_FixedElementField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_unknown2_e__FixedBuffer>.NativeClassPtr, "FixedElementField");
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<_unknown2_e__FixedBuffer>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_kSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_kReportId;

	private static readonly System.IntPtr NativeFieldInfoPtr_baseCommand;

	private static readonly System.IntPtr NativeFieldInfoPtr_reportId;

	private static readonly System.IntPtr NativeFieldInfoPtr_flags;

	private static readonly System.IntPtr NativeFieldInfoPtr_unknown1;

	private static readonly System.IntPtr NativeFieldInfoPtr_highFrequencyMotorSpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_lowFrequencyMotorSpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_redColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_greenColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_blueColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_unknown2;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Type_Public_Static_get_FourCC_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_typeStatic_Public_Virtual_Final_New_get_FourCC_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetMotorSpeeds_Public_Void_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetColor_Public_Void_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Static_DualShockHIDOutputReport_Int32_0;

	[FieldOffset(0)]
	public InputDeviceCommand baseCommand;

	[FieldOffset(8)]
	public byte reportId;

	[FieldOffset(9)]
	public byte flags;

	[FieldOffset(10)]
	public _unknown1_e__FixedBuffer unknown1;

	[FieldOffset(12)]
	public byte highFrequencyMotorSpeed;

	[FieldOffset(13)]
	public byte lowFrequencyMotorSpeed;

	[FieldOffset(14)]
	public byte redColor;

	[FieldOffset(15)]
	public byte greenColor;

	[FieldOffset(16)]
	public byte blueColor;

	[FieldOffset(17)]
	public _unknown2_e__FixedBuffer unknown2;

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

	public unsafe static int kReportId
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kReportId, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kReportId, (void*)(&value));
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

	static DualShockHIDOutputReport()
	{
		Il2CppClassPointerStore<DualShockHIDOutputReport>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.InputSystem.dll", "UnityEngine.InputSystem.DualShock.LowLevel", "DualShockHIDOutputReport");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DualShockHIDOutputReport>.NativeClassPtr);
		NativeFieldInfoPtr_kSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShockHIDOutputReport>.NativeClassPtr, "kSize");
		NativeFieldInfoPtr_kReportId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShockHIDOutputReport>.NativeClassPtr, "kReportId");
		NativeFieldInfoPtr_baseCommand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShockHIDOutputReport>.NativeClassPtr, "baseCommand");
		NativeFieldInfoPtr_reportId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShockHIDOutputReport>.NativeClassPtr, "reportId");
		NativeFieldInfoPtr_flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShockHIDOutputReport>.NativeClassPtr, "flags");
		NativeFieldInfoPtr_unknown1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShockHIDOutputReport>.NativeClassPtr, "unknown1");
		NativeFieldInfoPtr_highFrequencyMotorSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShockHIDOutputReport>.NativeClassPtr, "highFrequencyMotorSpeed");
		NativeFieldInfoPtr_lowFrequencyMotorSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShockHIDOutputReport>.NativeClassPtr, "lowFrequencyMotorSpeed");
		NativeFieldInfoPtr_redColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShockHIDOutputReport>.NativeClassPtr, "redColor");
		NativeFieldInfoPtr_greenColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShockHIDOutputReport>.NativeClassPtr, "greenColor");
		NativeFieldInfoPtr_blueColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShockHIDOutputReport>.NativeClassPtr, "blueColor");
		NativeFieldInfoPtr_unknown2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShockHIDOutputReport>.NativeClassPtr, "unknown2");
		NativeMethodInfoPtr_get_Type_Public_Static_get_FourCC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShockHIDOutputReport>.NativeClassPtr, 100667274);
		NativeMethodInfoPtr_get_typeStatic_Public_Virtual_Final_New_get_FourCC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShockHIDOutputReport>.NativeClassPtr, 100667275);
		NativeMethodInfoPtr_SetMotorSpeeds_Public_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShockHIDOutputReport>.NativeClassPtr, 100667276);
		NativeMethodInfoPtr_SetColor_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShockHIDOutputReport>.NativeClassPtr, 100667277);
		NativeMethodInfoPtr_Create_Public_Static_DualShockHIDOutputReport_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShockHIDOutputReport>.NativeClassPtr, 100667278);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1007798, XrefRangeEnd = 1007799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetMotorSpeeds(float lowFreq, float highFreq)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&lowFreq);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &highFreq;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetMotorSpeeds_Public_Void_Single_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1007799, XrefRangeEnd = 1007801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetColor(Color color)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&color);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetColor_Public_Void_Color_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1007801, XrefRangeEnd = 1007802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static DualShockHIDOutputReport Create(int outputReportSize)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&outputReportSize);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Create_Public_Static_DualShockHIDOutputReport_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(DualShockHIDOutputReport*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DualShockHIDOutputReport>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
