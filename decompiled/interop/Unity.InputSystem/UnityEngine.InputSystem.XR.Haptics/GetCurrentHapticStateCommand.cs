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
public struct GetCurrentHapticStateCommand
{
	private static readonly System.IntPtr NativeFieldInfoPtr_kSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_baseCommand;

	private static readonly System.IntPtr NativeFieldInfoPtr_samplesQueued;

	private static readonly System.IntPtr NativeFieldInfoPtr_samplesAvailable;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Type_Private_Static_get_FourCC_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_typeStatic_Public_Virtual_Final_New_get_FourCC_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_currentState_Public_get_HapticState_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Static_GetCurrentHapticStateCommand_0;

	[FieldOffset(0)]
	public InputDeviceCommand baseCommand;

	[FieldOffset(8)]
	public uint samplesQueued;

	[FieldOffset(12)]
	public uint samplesAvailable;

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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1000441, XrefRangeEnd = 1000442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1000442, XrefRangeEnd = 1000443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_typeStatic_Public_Virtual_Final_New_get_FourCC_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(FourCC*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe HapticState currentState
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_currentState_Public_get_HapticState_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(HapticState*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static GetCurrentHapticStateCommand()
	{
		Il2CppClassPointerStore<GetCurrentHapticStateCommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.InputSystem.dll", "UnityEngine.InputSystem.XR.Haptics", "GetCurrentHapticStateCommand");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetCurrentHapticStateCommand>.NativeClassPtr);
		NativeFieldInfoPtr_kSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetCurrentHapticStateCommand>.NativeClassPtr, "kSize");
		NativeFieldInfoPtr_baseCommand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetCurrentHapticStateCommand>.NativeClassPtr, "baseCommand");
		NativeFieldInfoPtr_samplesQueued = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetCurrentHapticStateCommand>.NativeClassPtr, "samplesQueued");
		NativeFieldInfoPtr_samplesAvailable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetCurrentHapticStateCommand>.NativeClassPtr, "samplesAvailable");
		NativeMethodInfoPtr_get_Type_Private_Static_get_FourCC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetCurrentHapticStateCommand>.NativeClassPtr, 100666532);
		NativeMethodInfoPtr_get_typeStatic_Public_Virtual_Final_New_get_FourCC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetCurrentHapticStateCommand>.NativeClassPtr, 100666533);
		NativeMethodInfoPtr_get_currentState_Public_get_HapticState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetCurrentHapticStateCommand>.NativeClassPtr, 100666534);
		NativeMethodInfoPtr_Create_Public_Static_GetCurrentHapticStateCommand_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetCurrentHapticStateCommand>.NativeClassPtr, 100666535);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1000443, XrefRangeEnd = 1000445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static GetCurrentHapticStateCommand Create()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Create_Public_Static_GetCurrentHapticStateCommand_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(GetCurrentHapticStateCommand*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GetCurrentHapticStateCommand>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
