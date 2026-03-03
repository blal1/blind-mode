using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.InputSystem.XR.Haptics;

[StructLayout(LayoutKind.Explicit)]
public struct HapticState
{
	private static readonly System.IntPtr NativeFieldInfoPtr__samplesQueued_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__samplesAvailable_k__BackingField;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_samplesQueued_Public_get_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_samplesQueued_Private_set_Void_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_samplesAvailable_Public_get_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_samplesAvailable_Private_set_Void_UInt32_0;

	[FieldOffset(0)]
	public uint _samplesQueued_k__BackingField;

	[FieldOffset(4)]
	public uint _samplesAvailable_k__BackingField;

	public unsafe uint samplesQueued
	{
		[CallerCount(175)]
		[CachedScanResults(RefRangeStart = 52464, RefRangeEnd = 52639, XrefRangeStart = 52464, XrefRangeEnd = 52639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_samplesQueued_Public_get_UInt32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 53703, RefRangeEnd = 53715, XrefRangeStart = 53703, XrefRangeEnd = 53715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_samplesQueued_Private_set_Void_UInt32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe uint samplesAvailable
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_samplesAvailable_Public_get_UInt32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 376349, RefRangeEnd = 376359, XrefRangeStart = 376349, XrefRangeEnd = 376359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_samplesAvailable_Private_set_Void_UInt32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	static HapticState()
	{
		Il2CppClassPointerStore<HapticState>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.InputSystem.dll", "UnityEngine.InputSystem.XR.Haptics", "HapticState");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HapticState>.NativeClassPtr);
		NativeFieldInfoPtr__samplesQueued_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HapticState>.NativeClassPtr, "<samplesQueued>k__BackingField");
		NativeFieldInfoPtr__samplesAvailable_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HapticState>.NativeClassPtr, "<samplesAvailable>k__BackingField");
		NativeMethodInfoPtr__ctor_Public_Void_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HapticState>.NativeClassPtr, 100666527);
		NativeMethodInfoPtr_get_samplesQueued_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HapticState>.NativeClassPtr, 100666528);
		NativeMethodInfoPtr_set_samplesQueued_Private_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HapticState>.NativeClassPtr, 100666529);
		NativeMethodInfoPtr_get_samplesAvailable_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HapticState>.NativeClassPtr, 100666530);
		NativeMethodInfoPtr_set_samplesAvailable_Private_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HapticState>.NativeClassPtr, 100666531);
	}

	[CallerCount(230)]
	[CachedScanResults(RefRangeStart = 409470, RefRangeEnd = 409700, XrefRangeStart = 409470, XrefRangeEnd = 409700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe HapticState(uint samplesQueued, uint samplesAvailable)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&samplesQueued);
		*(uint**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &samplesAvailable;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_UInt32_UInt32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HapticState>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
