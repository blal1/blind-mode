using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.XR;

[StructLayout(LayoutKind.Explicit)]
public struct InputDevice
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_DeviceId;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Initialized;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_UInt64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_deviceId_Private_get_UInt64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_InputDevice_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

	[FieldOffset(0)]
	public ulong m_DeviceId;

	[FieldOffset(8)]
	[MarshalAs(UnmanagedType.U1)]
	public bool m_Initialized;

	public unsafe ulong deviceId
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_deviceId_Private_get_UInt64_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(ulong*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public XRInputSubsystem subsystem
	{
		get
		{
			throw new System.NotSupportedException("Method unstripping failed");
		}
	}

	public bool isValid => IsValidId() && InputDevices.IsDeviceValid(m_DeviceId);

	public string name => IsValidId() ? InputDevices.GetDeviceName(m_DeviceId) : null;

	public InputDeviceRole role => IsValidId() ? InputDevices.GetDeviceRole(m_DeviceId) : InputDeviceRole.Unknown;

	public string manufacturer => IsValidId() ? InputDevices.GetDeviceManufacturer(m_DeviceId) : null;

	public string serialNumber => IsValidId() ? InputDevices.GetDeviceSerialNumber(m_DeviceId) : null;

	public InputDeviceCharacteristics characteristics => IsValidId() ? InputDevices.GetDeviceCharacteristics(m_DeviceId) : InputDeviceCharacteristics.None;

	static InputDevice()
	{
		Il2CppClassPointerStore<InputDevice>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.XRModule.dll", "UnityEngine.XR", "InputDevice");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputDevice>.NativeClassPtr);
		NativeFieldInfoPtr_m_DeviceId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, "m_DeviceId");
		NativeFieldInfoPtr_m_Initialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, "m_Initialized");
		NativeMethodInfoPtr__ctor_Internal_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100663306);
		NativeMethodInfoPtr_get_deviceId_Private_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100663307);
		NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100663308);
		NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_InputDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100663309);
		NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, 100663310);
	}

	[CallerCount(0)]
	public unsafe InputDevice(ulong deviceId)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&deviceId);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_UInt64_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1411023, XrefRangeEnd = 1411027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Equals(Il2CppSystem.Object obj)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1411027, XrefRangeEnd = 1411028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual bool Equals(InputDevice other)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&other);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_InputDevice_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1411028, XrefRangeEnd = 1411030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override int GetHashCode()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InputDevice>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}

	public bool IsValidId()
	{
		return deviceId != ulong.MaxValue;
	}

	public bool SendHapticImpulse(uint channel, float amplitude, [Optional] float duration)
	{
		if (!IsValidId())
		{
			return false;
		}
		if (amplitude < 0f)
		{
			throw new Il2CppSystem.ArgumentException("Amplitude of SendHapticImpulse cannot be negative.");
		}
		if (duration < 0f)
		{
			throw new Il2CppSystem.ArgumentException("Duration of SendHapticImpulse cannot be negative.");
		}
		return InputDevices.SendHapticImpulse(m_DeviceId, channel, amplitude, duration);
	}

	public bool SendHapticBuffer(uint channel, Il2CppStructArray<byte> buffer)
	{
		if (!IsValidId())
		{
			return false;
		}
		return InputDevices.SendHapticBuffer(m_DeviceId, channel, buffer);
	}

	public void StopHaptics()
	{
		if (IsValidId())
		{
			InputDevices.StopHaptics(m_DeviceId);
		}
	}

	public bool TryGetFeatureUsages(List<InputFeatureUsage> featureUsages)
	{
		if (IsValidId())
		{
			return InputDevices.TryGetFeatureUsages(m_DeviceId, featureUsages);
		}
		return false;
	}

	public bool CheckValidAndSetDefault<T>(out T value)
	{
		value = default(T);
		return IsValidId();
	}

	public static bool operator ==(InputDevice a, InputDevice b)
	{
		return a.Equals(b);
	}

	public static bool operator !=(InputDevice a, InputDevice b)
	{
		return !(a == b);
	}
}
