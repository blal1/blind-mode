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
public struct DualSenseHIDBluetoothOutputReport
{
	[StructLayout(LayoutKind.Explicit)]
	[ObfuscatedName("UnityEngine.InputSystem.DualShock.LowLevel.DualSenseHIDBluetoothOutputReport+<rawData>e__FixedBuffer")]
	public struct _rawData_e__FixedBuffer
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_FixedElementField;

		[FieldOffset(0)]
		public byte FixedElementField;

		static _rawData_e__FixedBuffer()
		{
			Il2CppClassPointerStore<_rawData_e__FixedBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DualSenseHIDBluetoothOutputReport>.NativeClassPtr, "<rawData>e__FixedBuffer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<_rawData_e__FixedBuffer>.NativeClassPtr);
			NativeFieldInfoPtr_FixedElementField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_rawData_e__FixedBuffer>.NativeClassPtr, "FixedElementField");
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<_rawData_e__FixedBuffer>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_kSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_baseCommand;

	private static readonly System.IntPtr NativeFieldInfoPtr_reportId;

	private static readonly System.IntPtr NativeFieldInfoPtr_tag1;

	private static readonly System.IntPtr NativeFieldInfoPtr_tag2;

	private static readonly System.IntPtr NativeFieldInfoPtr_payload;

	private static readonly System.IntPtr NativeFieldInfoPtr_crc32;

	private static readonly System.IntPtr NativeFieldInfoPtr_rawData;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Type_Public_Static_get_FourCC_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_typeStatic_Public_Virtual_Final_New_get_FourCC_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Static_DualSenseHIDBluetoothOutputReport_DualSenseHIDOutputReportPayload_Byte_Int32_0;

	[FieldOffset(0)]
	public InputDeviceCommand baseCommand;

	[FieldOffset(8)]
	public byte reportId;

	[FieldOffset(9)]
	public byte tag1;

	[FieldOffset(10)]
	public byte tag2;

	[FieldOffset(11)]
	public DualSenseHIDOutputReportPayload payload;

	[FieldOffset(82)]
	public uint crc32;

	[FieldOffset(8)]
	public _rawData_e__FixedBuffer rawData;

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

	static DualSenseHIDBluetoothOutputReport()
	{
		Il2CppClassPointerStore<DualSenseHIDBluetoothOutputReport>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.InputSystem.dll", "UnityEngine.InputSystem.DualShock.LowLevel", "DualSenseHIDBluetoothOutputReport");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DualSenseHIDBluetoothOutputReport>.NativeClassPtr);
		NativeFieldInfoPtr_kSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseHIDBluetoothOutputReport>.NativeClassPtr, "kSize");
		NativeFieldInfoPtr_baseCommand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseHIDBluetoothOutputReport>.NativeClassPtr, "baseCommand");
		NativeFieldInfoPtr_reportId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseHIDBluetoothOutputReport>.NativeClassPtr, "reportId");
		NativeFieldInfoPtr_tag1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseHIDBluetoothOutputReport>.NativeClassPtr, "tag1");
		NativeFieldInfoPtr_tag2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseHIDBluetoothOutputReport>.NativeClassPtr, "tag2");
		NativeFieldInfoPtr_payload = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseHIDBluetoothOutputReport>.NativeClassPtr, "payload");
		NativeFieldInfoPtr_crc32 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseHIDBluetoothOutputReport>.NativeClassPtr, "crc32");
		NativeFieldInfoPtr_rawData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualSenseHIDBluetoothOutputReport>.NativeClassPtr, "rawData");
		NativeMethodInfoPtr_get_Type_Public_Static_get_FourCC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseHIDBluetoothOutputReport>.NativeClassPtr, 100667268);
		NativeMethodInfoPtr_get_typeStatic_Public_Virtual_Final_New_get_FourCC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseHIDBluetoothOutputReport>.NativeClassPtr, 100667269);
		NativeMethodInfoPtr_Create_Public_Static_DualSenseHIDBluetoothOutputReport_DualSenseHIDOutputReportPayload_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualSenseHIDBluetoothOutputReport>.NativeClassPtr, 100667270);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1007792, XrefRangeEnd = 1007793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static DualSenseHIDBluetoothOutputReport Create(DualSenseHIDOutputReportPayload payload, byte outputSequenceId, int outputReportSize)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&payload);
		*(byte**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &outputSequenceId;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &outputReportSize;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Create_Public_Static_DualSenseHIDBluetoothOutputReport_DualSenseHIDOutputReportPayload_Byte_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(DualSenseHIDBluetoothOutputReport*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DualSenseHIDBluetoothOutputReport>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
