using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.XR.Haptics;

[StructLayout(LayoutKind.Explicit)]
public struct GetHapticCapabilitiesCommand
{
	private static readonly System.IntPtr NativeFieldInfoPtr_kSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_baseCommand;

	private static readonly System.IntPtr NativeFieldInfoPtr_numChannels;

	private static readonly System.IntPtr NativeFieldInfoPtr_supportsImpulse;

	private static readonly System.IntPtr NativeFieldInfoPtr_supportsBuffer;

	private static readonly System.IntPtr NativeFieldInfoPtr_frequencyHz;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxBufferSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_optimalBufferSize;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Type_Private_Static_get_FourCC_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_typeStatic_Public_Virtual_Final_New_get_FourCC_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_capabilities_Public_get_HapticCapabilities_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Static_GetHapticCapabilitiesCommand_0;

	[FieldOffset(0)]
	public InputDeviceCommand baseCommand;

	[FieldOffset(8)]
	public uint numChannels;

	[FieldOffset(12)]
	[MarshalAs(UnmanagedType.U1)]
	public bool supportsImpulse;

	[FieldOffset(13)]
	[MarshalAs(UnmanagedType.U1)]
	public bool supportsBuffer;

	[FieldOffset(16)]
	public uint frequencyHz;

	[FieldOffset(20)]
	public uint maxBufferSize;

	[FieldOffset(24)]
	public uint optimalBufferSize;

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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1000445, XrefRangeEnd = 1000446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Type_Private_Static_get_FourCC_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(FourCC*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe virtual FourCC typeStatic
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1000446, XrefRangeEnd = 1000447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_typeStatic_Public_Virtual_Final_New_get_FourCC_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(FourCC*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe HapticCapabilities capabilities
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_capabilities_Public_get_HapticCapabilities_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(HapticCapabilities*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static GetHapticCapabilitiesCommand()
	{
		Il2CppClassPointerStore<GetHapticCapabilitiesCommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.InputSystem.dll", "UnityEngine.InputSystem.XR.Haptics", "GetHapticCapabilitiesCommand");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetHapticCapabilitiesCommand>.NativeClassPtr);
		NativeFieldInfoPtr_kSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetHapticCapabilitiesCommand>.NativeClassPtr, "kSize");
		NativeFieldInfoPtr_baseCommand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetHapticCapabilitiesCommand>.NativeClassPtr, "baseCommand");
		NativeFieldInfoPtr_numChannels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetHapticCapabilitiesCommand>.NativeClassPtr, "numChannels");
		NativeFieldInfoPtr_supportsImpulse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetHapticCapabilitiesCommand>.NativeClassPtr, "supportsImpulse");
		NativeFieldInfoPtr_supportsBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetHapticCapabilitiesCommand>.NativeClassPtr, "supportsBuffer");
		NativeFieldInfoPtr_frequencyHz = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetHapticCapabilitiesCommand>.NativeClassPtr, "frequencyHz");
		NativeFieldInfoPtr_maxBufferSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetHapticCapabilitiesCommand>.NativeClassPtr, "maxBufferSize");
		NativeFieldInfoPtr_optimalBufferSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetHapticCapabilitiesCommand>.NativeClassPtr, "optimalBufferSize");
		NativeMethodInfoPtr_get_Type_Private_Static_get_FourCC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetHapticCapabilitiesCommand>.NativeClassPtr, 100666544);
		NativeMethodInfoPtr_get_typeStatic_Public_Virtual_Final_New_get_FourCC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetHapticCapabilitiesCommand>.NativeClassPtr, 100666545);
		NativeMethodInfoPtr_get_capabilities_Public_get_HapticCapabilities_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetHapticCapabilitiesCommand>.NativeClassPtr, 100666546);
		NativeMethodInfoPtr_Create_Public_Static_GetHapticCapabilitiesCommand_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetHapticCapabilitiesCommand>.NativeClassPtr, 100666547);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1000447, XrefRangeEnd = 1000449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static GetHapticCapabilitiesCommand Create()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Create_Public_Static_GetHapticCapabilitiesCommand_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(GetHapticCapabilitiesCommand*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GetHapticCapabilitiesCommand>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
