using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Bindings;

namespace UnityEngine.XR;

public class InputDevices : Il2CppSystem.Object
{
	private delegate bool SendHapticImpulseDelegate(ulong deviceId, uint channel, float amplitude, float duration);

	private delegate void StopHapticsDelegate(ulong deviceId);

	private delegate bool IsDeviceValidDelegate(ulong deviceId);

	private delegate InputDeviceCharacteristics GetDeviceCharacteristicsDelegate(ulong deviceId);

	private delegate void GetDevices_Internal_InjectedDelegate(System.IntPtr inputDevices);

	private delegate bool SendHapticBuffer_InjectedDelegate(ulong deviceId, uint channel, System.IntPtr buffer);

	private delegate bool TryGetFeatureUsages_InjectedDelegate(ulong deviceId, System.IntPtr featureUsages);

	private delegate bool TryGetFeatureValue_bool_InjectedDelegate(ulong deviceId, System.IntPtr usage, [Out] System.IntPtr value);

	private delegate bool TryGetFeatureValue_UInt32_InjectedDelegate(ulong deviceId, System.IntPtr usage, [Out] System.IntPtr value);

	private delegate bool TryGetFeatureValue_float_InjectedDelegate(ulong deviceId, System.IntPtr usage, [Out] System.IntPtr value);

	private delegate bool TryGetFeatureValue_Vector2f_InjectedDelegate(ulong deviceId, System.IntPtr usage, [Out] System.IntPtr value);

	private delegate bool TryGetFeatureValue_Vector3f_InjectedDelegate(ulong deviceId, System.IntPtr usage, [Out] System.IntPtr value);

	private delegate bool TryGetFeatureValue_Quaternionf_InjectedDelegate(ulong deviceId, System.IntPtr usage, [Out] System.IntPtr value);

	private delegate bool TryGetFeatureValue_Custom_InjectedDelegate(ulong deviceId, System.IntPtr usage, [Out] System.IntPtr value);

	private delegate bool TryGetFeatureValueAtTime_bool_InjectedDelegate(ulong deviceId, System.IntPtr usage, long time, [Out] System.IntPtr value);

	private delegate bool TryGetFeatureValueAtTime_UInt32_InjectedDelegate(ulong deviceId, System.IntPtr usage, long time, [Out] System.IntPtr value);

	private delegate bool TryGetFeatureValueAtTime_float_InjectedDelegate(ulong deviceId, System.IntPtr usage, long time, [Out] System.IntPtr value);

	private delegate bool TryGetFeatureValueAtTime_Vector2f_InjectedDelegate(ulong deviceId, System.IntPtr usage, long time, [Out] System.IntPtr value);

	private delegate bool TryGetFeatureValueAtTime_Vector3f_InjectedDelegate(ulong deviceId, System.IntPtr usage, long time, [Out] System.IntPtr value);

	private delegate bool TryGetFeatureValueAtTime_Quaternionf_InjectedDelegate(ulong deviceId, System.IntPtr usage, long time, [Out] System.IntPtr value);

	private delegate bool TryGetFeatureValue_XRHand_InjectedDelegate(ulong deviceId, System.IntPtr usage, [Out] System.IntPtr value);

	private delegate bool TryGetFeatureValue_XRBone_InjectedDelegate(ulong deviceId, System.IntPtr usage, [Out] System.IntPtr value);

	private delegate bool TryGetFeatureValue_XREyes_InjectedDelegate(ulong deviceId, System.IntPtr usage, [Out] System.IntPtr value);

	private delegate void GetDeviceName_InjectedDelegate(ulong deviceId, [Out] System.IntPtr ret);

	private delegate void GetDeviceManufacturer_InjectedDelegate(ulong deviceId, [Out] System.IntPtr ret);

	private delegate void GetDeviceSerialNumber_InjectedDelegate(ulong deviceId, [Out] System.IntPtr ret);

	private static readonly System.IntPtr NativeFieldInfoPtr_deviceConnected;

	private static readonly System.IntPtr NativeFieldInfoPtr_deviceDisconnected;

	private static readonly System.IntPtr NativeFieldInfoPtr_deviceConfigChanged;

	private static readonly System.IntPtr NativeMethodInfoPtr_InvokeConnectionEvent_Private_Static_Void_UInt64_ConnectionChangeType_0;

	private static readonly SendHapticImpulseDelegate SendHapticImpulseDelegateField;

	private static readonly StopHapticsDelegate StopHapticsDelegateField;

	private static readonly IsDeviceValidDelegate IsDeviceValidDelegateField;

	private static readonly GetDeviceCharacteristicsDelegate GetDeviceCharacteristicsDelegateField;

	private static readonly GetDevices_Internal_InjectedDelegate GetDevices_Internal_InjectedDelegateField;

	private static readonly SendHapticBuffer_InjectedDelegate SendHapticBuffer_InjectedDelegateField;

	private static readonly TryGetFeatureUsages_InjectedDelegate TryGetFeatureUsages_InjectedDelegateField;

	private static readonly TryGetFeatureValue_bool_InjectedDelegate TryGetFeatureValue_bool_InjectedDelegateField;

	private static readonly TryGetFeatureValue_UInt32_InjectedDelegate TryGetFeatureValue_UInt32_InjectedDelegateField;

	private static readonly TryGetFeatureValue_float_InjectedDelegate TryGetFeatureValue_float_InjectedDelegateField;

	private static readonly TryGetFeatureValue_Vector2f_InjectedDelegate TryGetFeatureValue_Vector2f_InjectedDelegateField;

	private static readonly TryGetFeatureValue_Vector3f_InjectedDelegate TryGetFeatureValue_Vector3f_InjectedDelegateField;

	private static readonly TryGetFeatureValue_Quaternionf_InjectedDelegate TryGetFeatureValue_Quaternionf_InjectedDelegateField;

	private static readonly TryGetFeatureValue_Custom_InjectedDelegate TryGetFeatureValue_Custom_InjectedDelegateField;

	private static readonly TryGetFeatureValueAtTime_bool_InjectedDelegate TryGetFeatureValueAtTime_bool_InjectedDelegateField;

	private static readonly TryGetFeatureValueAtTime_UInt32_InjectedDelegate TryGetFeatureValueAtTime_UInt32_InjectedDelegateField;

	private static readonly TryGetFeatureValueAtTime_float_InjectedDelegate TryGetFeatureValueAtTime_float_InjectedDelegateField;

	private static readonly TryGetFeatureValueAtTime_Vector2f_InjectedDelegate TryGetFeatureValueAtTime_Vector2f_InjectedDelegateField;

	private static readonly TryGetFeatureValueAtTime_Vector3f_InjectedDelegate TryGetFeatureValueAtTime_Vector3f_InjectedDelegateField;

	private static readonly TryGetFeatureValueAtTime_Quaternionf_InjectedDelegate TryGetFeatureValueAtTime_Quaternionf_InjectedDelegateField;

	private static readonly TryGetFeatureValue_XRHand_InjectedDelegate TryGetFeatureValue_XRHand_InjectedDelegateField;

	private static readonly TryGetFeatureValue_XRBone_InjectedDelegate TryGetFeatureValue_XRBone_InjectedDelegateField;

	private static readonly TryGetFeatureValue_XREyes_InjectedDelegate TryGetFeatureValue_XREyes_InjectedDelegateField;

	private static readonly GetDeviceName_InjectedDelegate GetDeviceName_InjectedDelegateField;

	private static readonly GetDeviceManufacturer_InjectedDelegate GetDeviceManufacturer_InjectedDelegateField;

	private static readonly GetDeviceSerialNumber_InjectedDelegate GetDeviceSerialNumber_InjectedDelegateField;

	public unsafe static Il2CppSystem.Action<InputDevice> deviceConnected
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_deviceConnected, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<InputDevice>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_deviceConnected, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppSystem.Action<InputDevice> deviceDisconnected
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_deviceDisconnected, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<InputDevice>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_deviceDisconnected, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppSystem.Action<InputDevice> deviceConfigChanged
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_deviceConfigChanged, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<InputDevice>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_deviceConfigChanged, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static InputDevices()
	{
		Il2CppClassPointerStore<InputDevices>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.XRModule.dll", "UnityEngine.XR", "InputDevices");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputDevices>.NativeClassPtr);
		NativeFieldInfoPtr_deviceConnected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevices>.NativeClassPtr, "deviceConnected");
		NativeFieldInfoPtr_deviceDisconnected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevices>.NativeClassPtr, "deviceDisconnected");
		NativeFieldInfoPtr_deviceConfigChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputDevices>.NativeClassPtr, "deviceConfigChanged");
		NativeMethodInfoPtr_InvokeConnectionEvent_Private_Static_Void_UInt64_ConnectionChangeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputDevices>.NativeClassPtr, 100663326);
		SendHapticImpulseDelegateField = IL2CPP.ResolveICall<SendHapticImpulseDelegate>("UnityEngine.XR.InputDevices::SendHapticImpulse");
		StopHapticsDelegateField = IL2CPP.ResolveICall<StopHapticsDelegate>("UnityEngine.XR.InputDevices::StopHaptics");
		IsDeviceValidDelegateField = IL2CPP.ResolveICall<IsDeviceValidDelegate>("UnityEngine.XR.InputDevices::IsDeviceValid");
		GetDeviceCharacteristicsDelegateField = IL2CPP.ResolveICall<GetDeviceCharacteristicsDelegate>("UnityEngine.XR.InputDevices::GetDeviceCharacteristics");
		GetDevices_Internal_InjectedDelegateField = IL2CPP.ResolveICall<GetDevices_Internal_InjectedDelegate>("UnityEngine.XR.InputDevices::GetDevices_Internal_Injected");
		SendHapticBuffer_InjectedDelegateField = IL2CPP.ResolveICall<SendHapticBuffer_InjectedDelegate>("UnityEngine.XR.InputDevices::SendHapticBuffer_Injected");
		TryGetFeatureUsages_InjectedDelegateField = IL2CPP.ResolveICall<TryGetFeatureUsages_InjectedDelegate>("UnityEngine.XR.InputDevices::TryGetFeatureUsages_Injected");
		TryGetFeatureValue_bool_InjectedDelegateField = IL2CPP.ResolveICall<TryGetFeatureValue_bool_InjectedDelegate>("UnityEngine.XR.InputDevices::TryGetFeatureValue_bool_Injected");
		TryGetFeatureValue_UInt32_InjectedDelegateField = IL2CPP.ResolveICall<TryGetFeatureValue_UInt32_InjectedDelegate>("UnityEngine.XR.InputDevices::TryGetFeatureValue_UInt32_Injected");
		TryGetFeatureValue_float_InjectedDelegateField = IL2CPP.ResolveICall<TryGetFeatureValue_float_InjectedDelegate>("UnityEngine.XR.InputDevices::TryGetFeatureValue_float_Injected");
		TryGetFeatureValue_Vector2f_InjectedDelegateField = IL2CPP.ResolveICall<TryGetFeatureValue_Vector2f_InjectedDelegate>("UnityEngine.XR.InputDevices::TryGetFeatureValue_Vector2f_Injected");
		TryGetFeatureValue_Vector3f_InjectedDelegateField = IL2CPP.ResolveICall<TryGetFeatureValue_Vector3f_InjectedDelegate>("UnityEngine.XR.InputDevices::TryGetFeatureValue_Vector3f_Injected");
		TryGetFeatureValue_Quaternionf_InjectedDelegateField = IL2CPP.ResolveICall<TryGetFeatureValue_Quaternionf_InjectedDelegate>("UnityEngine.XR.InputDevices::TryGetFeatureValue_Quaternionf_Injected");
		TryGetFeatureValue_Custom_InjectedDelegateField = IL2CPP.ResolveICall<TryGetFeatureValue_Custom_InjectedDelegate>("UnityEngine.XR.InputDevices::TryGetFeatureValue_Custom_Injected");
		TryGetFeatureValueAtTime_bool_InjectedDelegateField = IL2CPP.ResolveICall<TryGetFeatureValueAtTime_bool_InjectedDelegate>("UnityEngine.XR.InputDevices::TryGetFeatureValueAtTime_bool_Injected");
		TryGetFeatureValueAtTime_UInt32_InjectedDelegateField = IL2CPP.ResolveICall<TryGetFeatureValueAtTime_UInt32_InjectedDelegate>("UnityEngine.XR.InputDevices::TryGetFeatureValueAtTime_UInt32_Injected");
		TryGetFeatureValueAtTime_float_InjectedDelegateField = IL2CPP.ResolveICall<TryGetFeatureValueAtTime_float_InjectedDelegate>("UnityEngine.XR.InputDevices::TryGetFeatureValueAtTime_float_Injected");
		TryGetFeatureValueAtTime_Vector2f_InjectedDelegateField = IL2CPP.ResolveICall<TryGetFeatureValueAtTime_Vector2f_InjectedDelegate>("UnityEngine.XR.InputDevices::TryGetFeatureValueAtTime_Vector2f_Injected");
		TryGetFeatureValueAtTime_Vector3f_InjectedDelegateField = IL2CPP.ResolveICall<TryGetFeatureValueAtTime_Vector3f_InjectedDelegate>("UnityEngine.XR.InputDevices::TryGetFeatureValueAtTime_Vector3f_Injected");
		TryGetFeatureValueAtTime_Quaternionf_InjectedDelegateField = IL2CPP.ResolveICall<TryGetFeatureValueAtTime_Quaternionf_InjectedDelegate>("UnityEngine.XR.InputDevices::TryGetFeatureValueAtTime_Quaternionf_Injected");
		TryGetFeatureValue_XRHand_InjectedDelegateField = IL2CPP.ResolveICall<TryGetFeatureValue_XRHand_InjectedDelegate>("UnityEngine.XR.InputDevices::TryGetFeatureValue_XRHand_Injected");
		TryGetFeatureValue_XRBone_InjectedDelegateField = IL2CPP.ResolveICall<TryGetFeatureValue_XRBone_InjectedDelegate>("UnityEngine.XR.InputDevices::TryGetFeatureValue_XRBone_Injected");
		TryGetFeatureValue_XREyes_InjectedDelegateField = IL2CPP.ResolveICall<TryGetFeatureValue_XREyes_InjectedDelegate>("UnityEngine.XR.InputDevices::TryGetFeatureValue_XREyes_Injected");
		GetDeviceName_InjectedDelegateField = IL2CPP.ResolveICall<GetDeviceName_InjectedDelegate>("UnityEngine.XR.InputDevices::GetDeviceName_Injected");
		GetDeviceManufacturer_InjectedDelegateField = IL2CPP.ResolveICall<GetDeviceManufacturer_InjectedDelegate>("UnityEngine.XR.InputDevices::GetDeviceManufacturer_Injected");
		GetDeviceSerialNumber_InjectedDelegateField = IL2CPP.ResolveICall<GetDeviceSerialNumber_InjectedDelegate>("UnityEngine.XR.InputDevices::GetDeviceSerialNumber_Injected");
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1411041, XrefRangeEnd = 1411047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeConnectionEvent(ulong deviceId, ConnectionChangeType change)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&deviceId);
		*(ConnectionChangeType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &change;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InvokeConnectionEvent_Private_Static_Void_UInt64_ConnectionChangeType_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public InputDevices(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public static InputDevice GetDeviceAtXRNode(XRNode node)
	{
		ulong deviceIdAtXRNode = InputTracking.GetDeviceIdAtXRNode(node);
		return new InputDevice(deviceIdAtXRNode);
	}

	public unsafe static void GetDevicesAtXRNode(XRNode node, List<InputDevice> inputDevices)
	{
		//IL_0073: Expected O, but got Ref
		//IL_0062: Expected O, but got Ref
		//IL_003a: Expected O, but got Ref
		if (inputDevices == null)
		{
			throw new Il2CppSystem.ArgumentNullException("inputDevices");
		}
		List<ulong> list = new List<ulong>();
		InputTracking.GetDeviceIdsAtXRNode_Internal(node, list);
		inputDevices.Clear();
		List<ulong>.Enumerator enumerator = list.GetEnumerator();
		try
		{
			while (((List<ulong>.Enumerator)(&enumerator)).MoveNext())
			{
				ulong current = ((List<ulong>.Enumerator)(&enumerator)).Current;
				InputDevice item = new InputDevice(current);
				if (item.isValid)
				{
					inputDevices.Add(item);
				}
			}
		}
		finally
		{
			((Il2CppSystem.IDisposable)(object)(List<ulong>.Enumerator)(&enumerator)).Dispose();
		}
	}

	public static void GetDevices(List<InputDevice> inputDevices)
	{
		if (inputDevices == null)
		{
			throw new Il2CppSystem.ArgumentNullException("inputDevices");
		}
		inputDevices.Clear();
		GetDevices_Internal(inputDevices);
	}

	public static void GetDevicesWithRole(InputDeviceRole role, List<InputDevice> inputDevices)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public static void GetDevicesWithCharacteristics(InputDeviceCharacteristics desiredCharacteristics, List<InputDevice> inputDevices)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	[SpecialName]
	public static void add_deviceConnected(Il2CppSystem.Action<InputDevice> value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	[SpecialName]
	public static void remove_deviceConnected(Il2CppSystem.Action<InputDevice> value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	[SpecialName]
	public static void add_deviceDisconnected(Il2CppSystem.Action<InputDevice> value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	[SpecialName]
	public static void remove_deviceDisconnected(Il2CppSystem.Action<InputDevice> value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	[SpecialName]
	public static void add_deviceConfigChanged(Il2CppSystem.Action<InputDevice> value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	[SpecialName]
	public static void remove_deviceConfigChanged(Il2CppSystem.Action<InputDevice> value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public static void GetDevices_Internal(List<InputDevice> inputDevices)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public static bool SendHapticImpulse(ulong deviceId, uint channel, float amplitude, float duration)
	{
		return SendHapticImpulseDelegateField(deviceId, channel, amplitude, duration);
	}

	public unsafe static bool SendHapticBuffer(ulong deviceId, uint channel, Il2CppStructArray<byte> buffer)
	{
		//IL_0019: Expected O, but got Ref
		//IL_0020: Expected O, but got Ref
		//IL_002c: Expected O, but got Ref
		if (buffer == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object)(object)buffer, "buffer");
		}
		Unsafe.SkipInit(out Il2CppSystem.Span<byte> span);
		((Il2CppSystem.Span<byte>)(&span))._002Ector((Il2CppArrayBase<byte>)(object)buffer);
		bool result;
		fixed (byte* begin = &((Il2CppSystem.Span<byte>)(&span)).GetPinnableReference())
		{
			ManagedSpanWrapper buffer2 = new ManagedSpanWrapper(begin, ((Il2CppSystem.Span<byte>)(&span)).Length);
			result = SendHapticBuffer_Injected(deviceId, channel, ref buffer2);
		}
		return result;
	}

	public static void StopHaptics(ulong deviceId)
	{
		StopHapticsDelegateField(deviceId);
	}

	public static bool TryGetFeatureUsages(ulong deviceId, List<InputFeatureUsage> featureUsages)
	{
		if (featureUsages == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(featureUsages, "featureUsages");
		}
		return TryGetFeatureUsages_Injected(deviceId, featureUsages);
	}

	public unsafe static bool TryGetFeatureValue_bool(ulong deviceId, string usage, out bool value)
	{
		//IL_0019: Expected O, but got Ref
		//IL_0025: Expected O, but got Ref
		//The blocks IL_002a are reachable both inside and outside the pinned region starting at IL_0019. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(usage, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(usage);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					return TryGetFeatureValue_bool_Injected(deviceId, ref managedSpanWrapper, out value);
				}
			}
			return TryGetFeatureValue_bool_Injected(deviceId, ref managedSpanWrapper, out value);
		}
		finally
		{
		}
	}

	public unsafe static bool TryGetFeatureValue_UInt32(ulong deviceId, string usage, out uint value)
	{
		//IL_0019: Expected O, but got Ref
		//IL_0025: Expected O, but got Ref
		//The blocks IL_002a are reachable both inside and outside the pinned region starting at IL_0019. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(usage, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(usage);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					return TryGetFeatureValue_UInt32_Injected(deviceId, ref managedSpanWrapper, out value);
				}
			}
			return TryGetFeatureValue_UInt32_Injected(deviceId, ref managedSpanWrapper, out value);
		}
		finally
		{
		}
	}

	public unsafe static bool TryGetFeatureValue_float(ulong deviceId, string usage, out float value)
	{
		//IL_0019: Expected O, but got Ref
		//IL_0025: Expected O, but got Ref
		//The blocks IL_002a are reachable both inside and outside the pinned region starting at IL_0019. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(usage, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(usage);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					return TryGetFeatureValue_float_Injected(deviceId, ref managedSpanWrapper, out value);
				}
			}
			return TryGetFeatureValue_float_Injected(deviceId, ref managedSpanWrapper, out value);
		}
		finally
		{
		}
	}

	public unsafe static bool TryGetFeatureValue_Vector2f(ulong deviceId, string usage, out Vector2 value)
	{
		//IL_0019: Expected O, but got Ref
		//IL_0025: Expected O, but got Ref
		//The blocks IL_002a are reachable both inside and outside the pinned region starting at IL_0019. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(usage, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(usage);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					return TryGetFeatureValue_Vector2f_Injected(deviceId, ref managedSpanWrapper, out value);
				}
			}
			return TryGetFeatureValue_Vector2f_Injected(deviceId, ref managedSpanWrapper, out value);
		}
		finally
		{
		}
	}

	public unsafe static bool TryGetFeatureValue_Vector3f(ulong deviceId, string usage, out Vector3 value)
	{
		//IL_0019: Expected O, but got Ref
		//IL_0025: Expected O, but got Ref
		//The blocks IL_002a are reachable both inside and outside the pinned region starting at IL_0019. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(usage, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(usage);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					return TryGetFeatureValue_Vector3f_Injected(deviceId, ref managedSpanWrapper, out value);
				}
			}
			return TryGetFeatureValue_Vector3f_Injected(deviceId, ref managedSpanWrapper, out value);
		}
		finally
		{
		}
	}

	public unsafe static bool TryGetFeatureValue_Quaternionf(ulong deviceId, string usage, out Quaternion value)
	{
		//IL_0019: Expected O, but got Ref
		//IL_0025: Expected O, but got Ref
		//The blocks IL_002a are reachable both inside and outside the pinned region starting at IL_0019. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(usage, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(usage);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					return TryGetFeatureValue_Quaternionf_Injected(deviceId, ref managedSpanWrapper, out value);
				}
			}
			return TryGetFeatureValue_Quaternionf_Injected(deviceId, ref managedSpanWrapper, out value);
		}
		finally
		{
		}
	}

	public static bool TryGetFeatureValue_Custom(ulong deviceId, string usage, [Out] Il2CppStructArray<byte> value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public unsafe static bool TryGetFeatureValueAtTime_bool(ulong deviceId, string usage, long time, out bool value)
	{
		//IL_0019: Expected O, but got Ref
		//IL_0025: Expected O, but got Ref
		//The blocks IL_002a are reachable both inside and outside the pinned region starting at IL_0019. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(usage, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(usage);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					return TryGetFeatureValueAtTime_bool_Injected(deviceId, ref managedSpanWrapper, time, out value);
				}
			}
			return TryGetFeatureValueAtTime_bool_Injected(deviceId, ref managedSpanWrapper, time, out value);
		}
		finally
		{
		}
	}

	public unsafe static bool TryGetFeatureValueAtTime_UInt32(ulong deviceId, string usage, long time, out uint value)
	{
		//IL_0019: Expected O, but got Ref
		//IL_0025: Expected O, but got Ref
		//The blocks IL_002a are reachable both inside and outside the pinned region starting at IL_0019. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(usage, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(usage);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					return TryGetFeatureValueAtTime_UInt32_Injected(deviceId, ref managedSpanWrapper, time, out value);
				}
			}
			return TryGetFeatureValueAtTime_UInt32_Injected(deviceId, ref managedSpanWrapper, time, out value);
		}
		finally
		{
		}
	}

	public unsafe static bool TryGetFeatureValueAtTime_float(ulong deviceId, string usage, long time, out float value)
	{
		//IL_0019: Expected O, but got Ref
		//IL_0025: Expected O, but got Ref
		//The blocks IL_002a are reachable both inside and outside the pinned region starting at IL_0019. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(usage, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(usage);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					return TryGetFeatureValueAtTime_float_Injected(deviceId, ref managedSpanWrapper, time, out value);
				}
			}
			return TryGetFeatureValueAtTime_float_Injected(deviceId, ref managedSpanWrapper, time, out value);
		}
		finally
		{
		}
	}

	public unsafe static bool TryGetFeatureValueAtTime_Vector2f(ulong deviceId, string usage, long time, out Vector2 value)
	{
		//IL_0019: Expected O, but got Ref
		//IL_0025: Expected O, but got Ref
		//The blocks IL_002a are reachable both inside and outside the pinned region starting at IL_0019. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(usage, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(usage);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					return TryGetFeatureValueAtTime_Vector2f_Injected(deviceId, ref managedSpanWrapper, time, out value);
				}
			}
			return TryGetFeatureValueAtTime_Vector2f_Injected(deviceId, ref managedSpanWrapper, time, out value);
		}
		finally
		{
		}
	}

	public unsafe static bool TryGetFeatureValueAtTime_Vector3f(ulong deviceId, string usage, long time, out Vector3 value)
	{
		//IL_0019: Expected O, but got Ref
		//IL_0025: Expected O, but got Ref
		//The blocks IL_002a are reachable both inside and outside the pinned region starting at IL_0019. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(usage, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(usage);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					return TryGetFeatureValueAtTime_Vector3f_Injected(deviceId, ref managedSpanWrapper, time, out value);
				}
			}
			return TryGetFeatureValueAtTime_Vector3f_Injected(deviceId, ref managedSpanWrapper, time, out value);
		}
		finally
		{
		}
	}

	public unsafe static bool TryGetFeatureValueAtTime_Quaternionf(ulong deviceId, string usage, long time, out Quaternion value)
	{
		//IL_0019: Expected O, but got Ref
		//IL_0025: Expected O, but got Ref
		//The blocks IL_002a are reachable both inside and outside the pinned region starting at IL_0019. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(usage, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(usage);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					return TryGetFeatureValueAtTime_Quaternionf_Injected(deviceId, ref managedSpanWrapper, time, out value);
				}
			}
			return TryGetFeatureValueAtTime_Quaternionf_Injected(deviceId, ref managedSpanWrapper, time, out value);
		}
		finally
		{
		}
	}

	public unsafe static bool TryGetFeatureValue_XRHand(ulong deviceId, string usage, out Hand value)
	{
		//IL_0019: Expected O, but got Ref
		//IL_0025: Expected O, but got Ref
		//The blocks IL_002a are reachable both inside and outside the pinned region starting at IL_0019. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(usage, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(usage);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					return TryGetFeatureValue_XRHand_Injected(deviceId, ref managedSpanWrapper, out value);
				}
			}
			return TryGetFeatureValue_XRHand_Injected(deviceId, ref managedSpanWrapper, out value);
		}
		finally
		{
		}
	}

	public unsafe static bool TryGetFeatureValue_XRBone(ulong deviceId, string usage, out Bone value)
	{
		//IL_0019: Expected O, but got Ref
		//IL_0025: Expected O, but got Ref
		//The blocks IL_002a are reachable both inside and outside the pinned region starting at IL_0019. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(usage, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(usage);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					return TryGetFeatureValue_XRBone_Injected(deviceId, ref managedSpanWrapper, out value);
				}
			}
			return TryGetFeatureValue_XRBone_Injected(deviceId, ref managedSpanWrapper, out value);
		}
		finally
		{
		}
	}

	public unsafe static bool TryGetFeatureValue_XREyes(ulong deviceId, string usage, out Eyes value)
	{
		//IL_0019: Expected O, but got Ref
		//IL_0025: Expected O, but got Ref
		//The blocks IL_002a are reachable both inside and outside the pinned region starting at IL_0019. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(usage, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(usage);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					return TryGetFeatureValue_XREyes_Injected(deviceId, ref managedSpanWrapper, out value);
				}
			}
			return TryGetFeatureValue_XREyes_Injected(deviceId, ref managedSpanWrapper, out value);
		}
		finally
		{
		}
	}

	public static bool IsDeviceValid(ulong deviceId)
	{
		return IsDeviceValidDelegateField(deviceId);
	}

	public static string GetDeviceName(ulong deviceId)
	{
		Unsafe.SkipInit(out ManagedSpanWrapper ret);
		string stringAndDispose;
		try
		{
			GetDeviceName_Injected(deviceId, out ret);
		}
		finally
		{
			stringAndDispose = OutStringMarshaller.GetStringAndDispose(ret);
		}
		return stringAndDispose;
	}

	public static string GetDeviceManufacturer(ulong deviceId)
	{
		Unsafe.SkipInit(out ManagedSpanWrapper ret);
		string stringAndDispose;
		try
		{
			GetDeviceManufacturer_Injected(deviceId, out ret);
		}
		finally
		{
			stringAndDispose = OutStringMarshaller.GetStringAndDispose(ret);
		}
		return stringAndDispose;
	}

	public static string GetDeviceSerialNumber(ulong deviceId)
	{
		Unsafe.SkipInit(out ManagedSpanWrapper ret);
		string stringAndDispose;
		try
		{
			GetDeviceSerialNumber_Injected(deviceId, out ret);
		}
		finally
		{
			stringAndDispose = OutStringMarshaller.GetStringAndDispose(ret);
		}
		return stringAndDispose;
	}

	public static InputDeviceCharacteristics GetDeviceCharacteristics(ulong deviceId)
	{
		return GetDeviceCharacteristicsDelegateField(deviceId);
	}

	public static InputDeviceRole GetDeviceRole(ulong deviceId)
	{
		InputDeviceCharacteristics deviceCharacteristics = GetDeviceCharacteristics(deviceId);
		if ((deviceCharacteristics & (InputDeviceCharacteristics.HeadMounted | InputDeviceCharacteristics.TrackedDevice)) == (InputDeviceCharacteristics.HeadMounted | InputDeviceCharacteristics.TrackedDevice))
		{
			return InputDeviceRole.Generic;
		}
		if ((deviceCharacteristics & (InputDeviceCharacteristics.HeldInHand | InputDeviceCharacteristics.TrackedDevice | InputDeviceCharacteristics.Left)) == (InputDeviceCharacteristics.HeldInHand | InputDeviceCharacteristics.TrackedDevice | InputDeviceCharacteristics.Left))
		{
			return InputDeviceRole.LeftHanded;
		}
		if ((deviceCharacteristics & (InputDeviceCharacteristics.HeldInHand | InputDeviceCharacteristics.TrackedDevice | InputDeviceCharacteristics.Right)) == (InputDeviceCharacteristics.HeldInHand | InputDeviceCharacteristics.TrackedDevice | InputDeviceCharacteristics.Right))
		{
			return InputDeviceRole.RightHanded;
		}
		if ((deviceCharacteristics & InputDeviceCharacteristics.Controller) == InputDeviceCharacteristics.Controller)
		{
			return InputDeviceRole.GameController;
		}
		if ((deviceCharacteristics & (InputDeviceCharacteristics.TrackedDevice | InputDeviceCharacteristics.TrackingReference)) == (InputDeviceCharacteristics.TrackedDevice | InputDeviceCharacteristics.TrackingReference))
		{
			return InputDeviceRole.TrackingReference;
		}
		if ((deviceCharacteristics & InputDeviceCharacteristics.TrackedDevice) == InputDeviceCharacteristics.TrackedDevice)
		{
			return InputDeviceRole.HardwareTracker;
		}
		return InputDeviceRole.Unknown;
	}

	public unsafe static void GetDevices_Internal_Injected(ref BlittableListWrapper inputDevices)
	{
		GetDevices_Internal_InjectedDelegateField((nint)Unsafe.AsPointer(ref inputDevices));
	}

	public unsafe static bool SendHapticBuffer_Injected(ulong deviceId, uint channel, ref ManagedSpanWrapper buffer)
	{
		return SendHapticBuffer_InjectedDelegateField(deviceId, channel, (nint)Unsafe.AsPointer(ref buffer));
	}

	public static bool TryGetFeatureUsages_Injected(ulong deviceId, List<InputFeatureUsage> featureUsages)
	{
		return TryGetFeatureUsages_InjectedDelegateField(deviceId, IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)featureUsages));
	}

	public unsafe static bool TryGetFeatureValue_bool_Injected(ulong deviceId, ref ManagedSpanWrapper usage, out bool value)
	{
		return TryGetFeatureValue_bool_InjectedDelegateField(deviceId, (nint)Unsafe.AsPointer(ref usage), (nint)Unsafe.AsPointer(ref value));
	}

	public unsafe static bool TryGetFeatureValue_UInt32_Injected(ulong deviceId, ref ManagedSpanWrapper usage, out uint value)
	{
		return TryGetFeatureValue_UInt32_InjectedDelegateField(deviceId, (nint)Unsafe.AsPointer(ref usage), (nint)Unsafe.AsPointer(ref value));
	}

	public unsafe static bool TryGetFeatureValue_float_Injected(ulong deviceId, ref ManagedSpanWrapper usage, out float value)
	{
		return TryGetFeatureValue_float_InjectedDelegateField(deviceId, (nint)Unsafe.AsPointer(ref usage), (nint)Unsafe.AsPointer(ref value));
	}

	public unsafe static bool TryGetFeatureValue_Vector2f_Injected(ulong deviceId, ref ManagedSpanWrapper usage, out Vector2 value)
	{
		return TryGetFeatureValue_Vector2f_InjectedDelegateField(deviceId, (nint)Unsafe.AsPointer(ref usage), (nint)Unsafe.AsPointer(ref value));
	}

	public unsafe static bool TryGetFeatureValue_Vector3f_Injected(ulong deviceId, ref ManagedSpanWrapper usage, out Vector3 value)
	{
		return TryGetFeatureValue_Vector3f_InjectedDelegateField(deviceId, (nint)Unsafe.AsPointer(ref usage), (nint)Unsafe.AsPointer(ref value));
	}

	public unsafe static bool TryGetFeatureValue_Quaternionf_Injected(ulong deviceId, ref ManagedSpanWrapper usage, out Quaternion value)
	{
		return TryGetFeatureValue_Quaternionf_InjectedDelegateField(deviceId, (nint)Unsafe.AsPointer(ref usage), (nint)Unsafe.AsPointer(ref value));
	}

	public unsafe static bool TryGetFeatureValue_Custom_Injected(ulong deviceId, ref ManagedSpanWrapper usage, out BlittableArrayWrapper value)
	{
		return TryGetFeatureValue_Custom_InjectedDelegateField(deviceId, (nint)Unsafe.AsPointer(ref usage), (nint)Unsafe.AsPointer(ref value));
	}

	public unsafe static bool TryGetFeatureValueAtTime_bool_Injected(ulong deviceId, ref ManagedSpanWrapper usage, long time, out bool value)
	{
		return TryGetFeatureValueAtTime_bool_InjectedDelegateField(deviceId, (nint)Unsafe.AsPointer(ref usage), time, (nint)Unsafe.AsPointer(ref value));
	}

	public unsafe static bool TryGetFeatureValueAtTime_UInt32_Injected(ulong deviceId, ref ManagedSpanWrapper usage, long time, out uint value)
	{
		return TryGetFeatureValueAtTime_UInt32_InjectedDelegateField(deviceId, (nint)Unsafe.AsPointer(ref usage), time, (nint)Unsafe.AsPointer(ref value));
	}

	public unsafe static bool TryGetFeatureValueAtTime_float_Injected(ulong deviceId, ref ManagedSpanWrapper usage, long time, out float value)
	{
		return TryGetFeatureValueAtTime_float_InjectedDelegateField(deviceId, (nint)Unsafe.AsPointer(ref usage), time, (nint)Unsafe.AsPointer(ref value));
	}

	public unsafe static bool TryGetFeatureValueAtTime_Vector2f_Injected(ulong deviceId, ref ManagedSpanWrapper usage, long time, out Vector2 value)
	{
		return TryGetFeatureValueAtTime_Vector2f_InjectedDelegateField(deviceId, (nint)Unsafe.AsPointer(ref usage), time, (nint)Unsafe.AsPointer(ref value));
	}

	public unsafe static bool TryGetFeatureValueAtTime_Vector3f_Injected(ulong deviceId, ref ManagedSpanWrapper usage, long time, out Vector3 value)
	{
		return TryGetFeatureValueAtTime_Vector3f_InjectedDelegateField(deviceId, (nint)Unsafe.AsPointer(ref usage), time, (nint)Unsafe.AsPointer(ref value));
	}

	public unsafe static bool TryGetFeatureValueAtTime_Quaternionf_Injected(ulong deviceId, ref ManagedSpanWrapper usage, long time, out Quaternion value)
	{
		return TryGetFeatureValueAtTime_Quaternionf_InjectedDelegateField(deviceId, (nint)Unsafe.AsPointer(ref usage), time, (nint)Unsafe.AsPointer(ref value));
	}

	public unsafe static bool TryGetFeatureValue_XRHand_Injected(ulong deviceId, ref ManagedSpanWrapper usage, out Hand value)
	{
		return TryGetFeatureValue_XRHand_InjectedDelegateField(deviceId, (nint)Unsafe.AsPointer(ref usage), (nint)Unsafe.AsPointer(ref value));
	}

	public unsafe static bool TryGetFeatureValue_XRBone_Injected(ulong deviceId, ref ManagedSpanWrapper usage, out Bone value)
	{
		return TryGetFeatureValue_XRBone_InjectedDelegateField(deviceId, (nint)Unsafe.AsPointer(ref usage), (nint)Unsafe.AsPointer(ref value));
	}

	public unsafe static bool TryGetFeatureValue_XREyes_Injected(ulong deviceId, ref ManagedSpanWrapper usage, out Eyes value)
	{
		return TryGetFeatureValue_XREyes_InjectedDelegateField(deviceId, (nint)Unsafe.AsPointer(ref usage), (nint)Unsafe.AsPointer(ref value));
	}

	public unsafe static void GetDeviceName_Injected(ulong deviceId, out ManagedSpanWrapper ret)
	{
		GetDeviceName_InjectedDelegateField(deviceId, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void GetDeviceManufacturer_Injected(ulong deviceId, out ManagedSpanWrapper ret)
	{
		GetDeviceManufacturer_InjectedDelegateField(deviceId, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void GetDeviceSerialNumber_Injected(ulong deviceId, out ManagedSpanWrapper ret)
	{
		GetDeviceSerialNumber_InjectedDelegateField(deviceId, (nint)Unsafe.AsPointer(ref ret));
	}
}
