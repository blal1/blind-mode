using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.InputSystem.XR.Haptics;

public sealed class BufferedRumble : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr__capabilities_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__device_k__BackingField;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_capabilities_Public_get_HapticCapabilities_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_capabilities_Private_set_Void_HapticCapabilities_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_device_Private_get_InputDevice_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_device_Private_set_Void_InputDevice_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_InputDevice_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnqueueRumble_Public_Void_Il2CppStructArray_1_Byte_0;

	public unsafe HapticCapabilities _capabilities_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__capabilities_k__BackingField);
			return *(HapticCapabilities*)num;
		}
		set
		{
			*(HapticCapabilities*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__capabilities_k__BackingField)) = value;
		}
	}

	public unsafe InputDevice _device_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__device_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InputDevice>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__device_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe HapticCapabilities capabilities
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_capabilities_Public_get_HapticCapabilities_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(HapticCapabilities*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1000426, RefRangeEnd = 1000428, XrefRangeStart = 1000426, XrefRangeEnd = 1000426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_capabilities_Private_set_Void_HapticCapabilities_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe InputDevice device
	{
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 25665, RefRangeEnd = 25677, XrefRangeStart = 25665, XrefRangeEnd = 25677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_device_Private_get_InputDevice_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<InputDevice>(intPtr2) : null;
		}
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 86477, RefRangeEnd = 86487, XrefRangeStart = 86477, XrefRangeEnd = 86487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_device_Private_set_Void_InputDevice_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	static BufferedRumble()
	{
		Il2CppClassPointerStore<BufferedRumble>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.InputSystem.dll", "UnityEngine.InputSystem.XR.Haptics", "BufferedRumble");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BufferedRumble>.NativeClassPtr);
		NativeFieldInfoPtr__capabilities_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BufferedRumble>.NativeClassPtr, "<capabilities>k__BackingField");
		NativeFieldInfoPtr__device_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BufferedRumble>.NativeClassPtr, "<device>k__BackingField");
		NativeMethodInfoPtr_get_capabilities_Public_get_HapticCapabilities_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferedRumble>.NativeClassPtr, 100666521);
		NativeMethodInfoPtr_set_capabilities_Private_set_Void_HapticCapabilities_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferedRumble>.NativeClassPtr, 100666522);
		NativeMethodInfoPtr_get_device_Private_get_InputDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferedRumble>.NativeClassPtr, 100666523);
		NativeMethodInfoPtr_set_device_Private_set_Void_InputDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferedRumble>.NativeClassPtr, 100666524);
		NativeMethodInfoPtr__ctor_Public_Void_InputDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferedRumble>.NativeClassPtr, 100666525);
		NativeMethodInfoPtr_EnqueueRumble_Public_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BufferedRumble>.NativeClassPtr, 100666526);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1000428, XrefRangeEnd = 1000434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BufferedRumble(InputDevice device)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BufferedRumble>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)device);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_InputDevice_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1000434, XrefRangeEnd = 1000441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EnqueueRumble(Il2CppStructArray<byte> samples)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)samples);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnqueueRumble_Public_Void_Il2CppStructArray_1_Byte_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public BufferedRumble(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public BufferedRumble()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BufferedRumble>.NativeClassPtr))
	{
	}
}
