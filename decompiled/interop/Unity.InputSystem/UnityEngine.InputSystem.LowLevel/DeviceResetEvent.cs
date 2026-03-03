using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.LowLevel;

[StructLayout(LayoutKind.Explicit)]
public struct DeviceResetEvent
{
	private static readonly System.IntPtr NativeFieldInfoPtr_Type;

	private static readonly System.IntPtr NativeFieldInfoPtr_baseEvent;

	private static readonly System.IntPtr NativeFieldInfoPtr_hardReset;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_typeStatic_Public_Virtual_Final_New_get_FourCC_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Static_DeviceResetEvent_Int32_Boolean_Double_0;

	[FieldOffset(0)]
	public InputEvent baseEvent;

	[FieldOffset(8)]
	[MarshalAs(UnmanagedType.U1)]
	public bool hardReset;

	public unsafe static int Type
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Type, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Type, (void*)(&value));
		}
	}

	public unsafe virtual FourCC typeStatic
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_typeStatic_Public_Virtual_Final_New_get_FourCC_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(FourCC*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static DeviceResetEvent()
	{
		Il2CppClassPointerStore<DeviceResetEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.InputSystem.dll", "UnityEngine.InputSystem.LowLevel", "DeviceResetEvent");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeviceResetEvent>.NativeClassPtr);
		NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeviceResetEvent>.NativeClassPtr, "Type");
		NativeFieldInfoPtr_baseEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeviceResetEvent>.NativeClassPtr, "baseEvent");
		NativeFieldInfoPtr_hardReset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeviceResetEvent>.NativeClassPtr, "hardReset");
		NativeMethodInfoPtr_get_typeStatic_Public_Virtual_Final_New_get_FourCC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeviceResetEvent>.NativeClassPtr, 100667473);
		NativeMethodInfoPtr_Create_Public_Static_DeviceResetEvent_Int32_Boolean_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeviceResetEvent>.NativeClassPtr, 100667474);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1008196, RefRangeEnd = 1008198, XrefRangeStart = 1008191, XrefRangeEnd = 1008196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static DeviceResetEvent Create(int deviceId, bool hardReset = false, double time = -1.0)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&deviceId);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &hardReset;
		*(double**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Create_Public_Static_DeviceResetEvent_Int32_Boolean_Double_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(DeviceResetEvent*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DeviceResetEvent>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
