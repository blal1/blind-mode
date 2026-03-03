using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace UnityEngine.InputSystem.Haptics;

[StructLayout(LayoutKind.Explicit)]
public struct DualMotorRumble
{
	private static readonly System.IntPtr NativeFieldInfoPtr__lowFrequencyMotorSpeed_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__highFrequencyMotorSpeed_k__BackingField;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_lowFrequencyMotorSpeed_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_lowFrequencyMotorSpeed_Private_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_highFrequencyMotorSpeed_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_highFrequencyMotorSpeed_Private_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isRumbling_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PauseHaptics_Public_Void_InputDevice_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResumeHaptics_Public_Void_InputDevice_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResetHaptics_Public_Void_InputDevice_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetMotorSpeeds_Public_Void_InputDevice_Single_Single_0;

	[FieldOffset(0)]
	public float _lowFrequencyMotorSpeed_k__BackingField;

	[FieldOffset(4)]
	public float _highFrequencyMotorSpeed_k__BackingField;

	public unsafe float lowFrequencyMotorSpeed
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_lowFrequencyMotorSpeed_Public_get_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 1007806, RefRangeEnd = 1007828, XrefRangeStart = 1007806, XrefRangeEnd = 1007806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_lowFrequencyMotorSpeed_Private_set_Void_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe float highFrequencyMotorSpeed
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_highFrequencyMotorSpeed_Public_get_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 968557, RefRangeEnd = 968572, XrefRangeStart = 968557, XrefRangeEnd = 968572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_highFrequencyMotorSpeed_Private_set_Void_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool isRumbling
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1007828, XrefRangeEnd = 1007829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isRumbling_Public_get_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static DualMotorRumble()
	{
		Il2CppClassPointerStore<DualMotorRumble>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.InputSystem.dll", "UnityEngine.InputSystem.Haptics", "DualMotorRumble");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DualMotorRumble>.NativeClassPtr);
		NativeFieldInfoPtr__lowFrequencyMotorSpeed_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualMotorRumble>.NativeClassPtr, "<lowFrequencyMotorSpeed>k__BackingField");
		NativeFieldInfoPtr__highFrequencyMotorSpeed_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualMotorRumble>.NativeClassPtr, "<highFrequencyMotorSpeed>k__BackingField");
		NativeMethodInfoPtr_get_lowFrequencyMotorSpeed_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualMotorRumble>.NativeClassPtr, 100667287);
		NativeMethodInfoPtr_set_lowFrequencyMotorSpeed_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualMotorRumble>.NativeClassPtr, 100667288);
		NativeMethodInfoPtr_get_highFrequencyMotorSpeed_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualMotorRumble>.NativeClassPtr, 100667289);
		NativeMethodInfoPtr_set_highFrequencyMotorSpeed_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualMotorRumble>.NativeClassPtr, 100667290);
		NativeMethodInfoPtr_get_isRumbling_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualMotorRumble>.NativeClassPtr, 100667291);
		NativeMethodInfoPtr_PauseHaptics_Public_Void_InputDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualMotorRumble>.NativeClassPtr, 100667292);
		NativeMethodInfoPtr_ResumeHaptics_Public_Void_InputDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualMotorRumble>.NativeClassPtr, 100667293);
		NativeMethodInfoPtr_ResetHaptics_Public_Void_InputDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualMotorRumble>.NativeClassPtr, 100667294);
		NativeMethodInfoPtr_SetMotorSpeeds_Public_Void_InputDevice_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualMotorRumble>.NativeClassPtr, 100667295);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1007835, RefRangeEnd = 1007836, XrefRangeStart = 1007829, XrefRangeEnd = 1007835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PauseHaptics(InputDevice device)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)device);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PauseHaptics_Public_Void_InputDevice_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1007839, RefRangeEnd = 1007840, XrefRangeStart = 1007836, XrefRangeEnd = 1007839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ResumeHaptics(InputDevice device)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)device);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResumeHaptics_Public_Void_InputDevice_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1007843, RefRangeEnd = 1007844, XrefRangeStart = 1007840, XrefRangeEnd = 1007843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ResetHaptics(InputDevice device)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)device);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetHaptics_Public_Void_InputDevice_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1007850, RefRangeEnd = 1007853, XrefRangeStart = 1007844, XrefRangeEnd = 1007850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetMotorSpeeds(InputDevice device, float lowFrequency, float highFrequency)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)device);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &lowFrequency;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &highFrequency;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetMotorSpeeds_Public_Void_InputDevice_Single_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DualMotorRumble>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
