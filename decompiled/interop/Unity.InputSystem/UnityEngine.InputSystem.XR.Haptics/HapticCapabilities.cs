using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.InputSystem.XR.Haptics;

[StructLayout(LayoutKind.Explicit)]
public struct HapticCapabilities
{
	private static readonly System.IntPtr NativeFieldInfoPtr__numChannels_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__supportsImpulse_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__supportsBuffer_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__frequencyHz_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__maxBufferSize_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__optimalBufferSize_k__BackingField;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_Boolean_Boolean_UInt32_UInt32_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_UInt32_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_numChannels_Public_get_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_supportsImpulse_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_supportsBuffer_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_frequencyHz_Public_get_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_maxBufferSize_Public_get_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_optimalBufferSize_Public_get_UInt32_0;

	[FieldOffset(0)]
	public readonly uint _numChannels_k__BackingField;

	[FieldOffset(4)]
	[MarshalAs(UnmanagedType.U1)]
	public readonly bool _supportsImpulse_k__BackingField;

	[FieldOffset(5)]
	[MarshalAs(UnmanagedType.U1)]
	public readonly bool _supportsBuffer_k__BackingField;

	[FieldOffset(8)]
	public readonly uint _frequencyHz_k__BackingField;

	[FieldOffset(12)]
	public readonly uint _maxBufferSize_k__BackingField;

	[FieldOffset(16)]
	public readonly uint _optimalBufferSize_k__BackingField;

	public unsafe uint numChannels
	{
		[CallerCount(175)]
		[CachedScanResults(RefRangeStart = 52464, RefRangeEnd = 52639, XrefRangeStart = 52464, XrefRangeEnd = 52639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_numChannels_Public_get_UInt32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool supportsImpulse
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_supportsImpulse_Public_get_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool supportsBuffer
	{
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 52442, RefRangeEnd = 52450, XrefRangeStart = 52442, XrefRangeEnd = 52450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_supportsBuffer_Public_get_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe uint frequencyHz
	{
		[CallerCount(24)]
		[CachedScanResults(RefRangeStart = 719678, RefRangeEnd = 719702, XrefRangeStart = 719678, XrefRangeEnd = 719702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_frequencyHz_Public_get_UInt32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe uint maxBufferSize
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_maxBufferSize_Public_get_UInt32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe uint optimalBufferSize
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 50668, RefRangeEnd = 50669, XrefRangeStart = 50668, XrefRangeEnd = 50669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_optimalBufferSize_Public_get_UInt32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static HapticCapabilities()
	{
		Il2CppClassPointerStore<HapticCapabilities>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.InputSystem.dll", "UnityEngine.InputSystem.XR.Haptics", "HapticCapabilities");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HapticCapabilities>.NativeClassPtr);
		NativeFieldInfoPtr__numChannels_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HapticCapabilities>.NativeClassPtr, "<numChannels>k__BackingField");
		NativeFieldInfoPtr__supportsImpulse_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HapticCapabilities>.NativeClassPtr, "<supportsImpulse>k__BackingField");
		NativeFieldInfoPtr__supportsBuffer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HapticCapabilities>.NativeClassPtr, "<supportsBuffer>k__BackingField");
		NativeFieldInfoPtr__frequencyHz_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HapticCapabilities>.NativeClassPtr, "<frequencyHz>k__BackingField");
		NativeFieldInfoPtr__maxBufferSize_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HapticCapabilities>.NativeClassPtr, "<maxBufferSize>k__BackingField");
		NativeFieldInfoPtr__optimalBufferSize_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HapticCapabilities>.NativeClassPtr, "<optimalBufferSize>k__BackingField");
		NativeMethodInfoPtr__ctor_Public_Void_UInt32_Boolean_Boolean_UInt32_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HapticCapabilities>.NativeClassPtr, 100666536);
		NativeMethodInfoPtr__ctor_Public_Void_UInt32_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HapticCapabilities>.NativeClassPtr, 100666537);
		NativeMethodInfoPtr_get_numChannels_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HapticCapabilities>.NativeClassPtr, 100666538);
		NativeMethodInfoPtr_get_supportsImpulse_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HapticCapabilities>.NativeClassPtr, 100666539);
		NativeMethodInfoPtr_get_supportsBuffer_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HapticCapabilities>.NativeClassPtr, 100666540);
		NativeMethodInfoPtr_get_frequencyHz_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HapticCapabilities>.NativeClassPtr, 100666541);
		NativeMethodInfoPtr_get_maxBufferSize_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HapticCapabilities>.NativeClassPtr, 100666542);
		NativeMethodInfoPtr_get_optimalBufferSize_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HapticCapabilities>.NativeClassPtr, 100666543);
	}

	[CallerCount(0)]
	public unsafe HapticCapabilities(uint numChannels, bool supportsImpulse, bool supportsBuffer, uint frequencyHz, uint maxBufferSize, uint optimalBufferSize)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&numChannels);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &supportsImpulse;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &supportsBuffer;
		*(uint**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &frequencyHz;
		*(uint**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxBufferSize;
		*(uint**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &optimalBufferSize;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_UInt32_Boolean_Boolean_UInt32_UInt32_UInt32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe HapticCapabilities(uint numChannels, uint frequencyHz, uint maxBufferSize)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&numChannels);
		*(uint**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &frequencyHz;
		*(uint**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxBufferSize;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_UInt32_UInt32_UInt32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HapticCapabilities>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
