using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Unity.Collections.LowLevel.Unsafe;

namespace UnityEngineInternal.Input;

public class NativeInputSystem : Il2CppSystem.Object
{
	private delegate ulong GetBackgroundEventBufferSizeDelegate();

	private delegate bool get_allowInputDeviceCreationFromEventsDelegate();

	private delegate void set_allowInputDeviceCreationFromEventsDelegate(bool value);

	private static readonly System.IntPtr NativeFieldInfoPtr_onUpdate;

	private static readonly System.IntPtr NativeFieldInfoPtr_onBeforeUpdate;

	private static readonly System.IntPtr NativeFieldInfoPtr_onShouldRunUpdate;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_OnDeviceDiscoveredCallback;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_onDeviceDiscovered_Public_Static_get_Action_2_Int32_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_onDeviceDiscovered_Public_Static_set_Void_Action_2_Int32_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NotifyBeforeUpdate_Internal_Static_Void_NativeInputUpdateType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NotifyUpdate_Internal_Static_Void_NativeInputUpdateType_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NotifyDeviceDiscovered_Internal_Static_Void_Int32_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ShouldRunUpdate_Internal_Static_Void_NativeInputUpdateType_byref_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_hasDeviceDiscoveredCallback_Internal_Static_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_currentTime_Public_Static_get_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_currentTimeOffsetToRealtimeSinceStartup_Public_Static_get_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AllocateDeviceId_Public_Static_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_QueueInputEvent_Public_Static_Void_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IOCTL_Public_Static_Int64_Int32_Int32_IntPtr_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetPollingFrequency_Public_Static_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Update_Public_Static_Void_NativeInputUpdateType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_normalizeScrollWheelDelta_Internal_Static_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_normalizeScrollWheelDelta_Internal_Static_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetScrollWheelDeltaPerTick_Internal_Static_Single_0;

	private static readonly GetBackgroundEventBufferSizeDelegate GetBackgroundEventBufferSizeDelegateField;

	private static readonly get_allowInputDeviceCreationFromEventsDelegate get_allowInputDeviceCreationFromEventsDelegateField;

	private static readonly set_allowInputDeviceCreationFromEventsDelegate set_allowInputDeviceCreationFromEventsDelegateField;

	public unsafe static NativeUpdateCallback onUpdate
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_onUpdate, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<NativeUpdateCallback>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_onUpdate, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppSystem.Action<NativeInputUpdateType> onBeforeUpdate
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_onBeforeUpdate, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<NativeInputUpdateType>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_onBeforeUpdate, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppSystem.Func<NativeInputUpdateType, bool> onShouldRunUpdate
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_onShouldRunUpdate, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<NativeInputUpdateType, bool>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_onShouldRunUpdate, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppSystem.Action<int, string> s_OnDeviceDiscoveredCallback
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_OnDeviceDiscoveredCallback, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<int, string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_OnDeviceDiscoveredCallback, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppSystem.Action<int, string> onDeviceDiscovered
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1253163, RefRangeEnd = 1253164, XrefRangeStart = 1253159, XrefRangeEnd = 1253163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_onDeviceDiscovered_Public_Static_get_Action_2_Int32_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<int, string>>(intPtr2) : null;
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1253173, RefRangeEnd = 1253174, XrefRangeStart = 1253164, XrefRangeEnd = 1253173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_onDeviceDiscovered_Public_Static_set_Void_Action_2_Int32_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe static bool hasDeviceDiscoveredCallback
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1253190, XrefRangeEnd = 1253192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_hasDeviceDiscoveredCallback_Internal_Static_set_Void_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe static double currentTime
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1253194, RefRangeEnd = 1253195, XrefRangeStart = 1253192, XrefRangeEnd = 1253194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_currentTime_Public_Static_get_Double_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(double*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static double currentTimeOffsetToRealtimeSinceStartup
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1253197, RefRangeEnd = 1253199, XrefRangeStart = 1253195, XrefRangeEnd = 1253197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_currentTimeOffsetToRealtimeSinceStartup_Public_Static_get_Double_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(double*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static bool normalizeScrollWheelDelta
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1253218, RefRangeEnd = 1253219, XrefRangeStart = 1253216, XrefRangeEnd = 1253218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_normalizeScrollWheelDelta_Internal_Static_get_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1253221, RefRangeEnd = 1253222, XrefRangeStart = 1253219, XrefRangeEnd = 1253221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_normalizeScrollWheelDelta_Internal_Static_set_Void_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public static bool allowInputDeviceCreationFromEvents
	{
		get
		{
			return get_allowInputDeviceCreationFromEventsDelegateField();
		}
		set
		{
			set_allowInputDeviceCreationFromEventsDelegateField(value);
		}
	}

	static NativeInputSystem()
	{
		Il2CppClassPointerStore<NativeInputSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.InputModule.dll", "UnityEngineInternal.Input", "NativeInputSystem");
		NativeFieldInfoPtr_onUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeInputSystem>.NativeClassPtr, "onUpdate");
		NativeFieldInfoPtr_onBeforeUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeInputSystem>.NativeClassPtr, "onBeforeUpdate");
		NativeFieldInfoPtr_onShouldRunUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeInputSystem>.NativeClassPtr, "onShouldRunUpdate");
		NativeFieldInfoPtr_s_OnDeviceDiscoveredCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeInputSystem>.NativeClassPtr, "s_OnDeviceDiscoveredCallback");
		NativeMethodInfoPtr_get_onDeviceDiscovered_Public_Static_get_Action_2_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeInputSystem>.NativeClassPtr, 100663299);
		NativeMethodInfoPtr_set_onDeviceDiscovered_Public_Static_set_Void_Action_2_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeInputSystem>.NativeClassPtr, 100663300);
		NativeMethodInfoPtr_NotifyBeforeUpdate_Internal_Static_Void_NativeInputUpdateType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeInputSystem>.NativeClassPtr, 100663302);
		NativeMethodInfoPtr_NotifyUpdate_Internal_Static_Void_NativeInputUpdateType_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeInputSystem>.NativeClassPtr, 100663303);
		NativeMethodInfoPtr_NotifyDeviceDiscovered_Internal_Static_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeInputSystem>.NativeClassPtr, 100663304);
		NativeMethodInfoPtr_ShouldRunUpdate_Internal_Static_Void_NativeInputUpdateType_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeInputSystem>.NativeClassPtr, 100663305);
		NativeMethodInfoPtr_set_hasDeviceDiscoveredCallback_Internal_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeInputSystem>.NativeClassPtr, 100663306);
		NativeMethodInfoPtr_get_currentTime_Public_Static_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeInputSystem>.NativeClassPtr, 100663307);
		NativeMethodInfoPtr_get_currentTimeOffsetToRealtimeSinceStartup_Public_Static_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeInputSystem>.NativeClassPtr, 100663308);
		NativeMethodInfoPtr_AllocateDeviceId_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeInputSystem>.NativeClassPtr, 100663309);
		NativeMethodInfoPtr_QueueInputEvent_Public_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeInputSystem>.NativeClassPtr, 100663310);
		NativeMethodInfoPtr_IOCTL_Public_Static_Int64_Int32_Int32_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeInputSystem>.NativeClassPtr, 100663311);
		NativeMethodInfoPtr_SetPollingFrequency_Public_Static_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeInputSystem>.NativeClassPtr, 100663312);
		NativeMethodInfoPtr_Update_Public_Static_Void_NativeInputUpdateType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeInputSystem>.NativeClassPtr, 100663313);
		NativeMethodInfoPtr_get_normalizeScrollWheelDelta_Internal_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeInputSystem>.NativeClassPtr, 100663314);
		NativeMethodInfoPtr_set_normalizeScrollWheelDelta_Internal_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeInputSystem>.NativeClassPtr, 100663315);
		NativeMethodInfoPtr_GetScrollWheelDeltaPerTick_Internal_Static_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeInputSystem>.NativeClassPtr, 100663316);
		GetBackgroundEventBufferSizeDelegateField = IL2CPP.ResolveICall<GetBackgroundEventBufferSizeDelegate>("UnityEngineInternal.Input.NativeInputSystem::GetBackgroundEventBufferSize");
		get_allowInputDeviceCreationFromEventsDelegateField = IL2CPP.ResolveICall<get_allowInputDeviceCreationFromEventsDelegate>("UnityEngineInternal.Input.NativeInputSystem::get_allowInputDeviceCreationFromEvents");
		set_allowInputDeviceCreationFromEventsDelegateField = IL2CPP.ResolveICall<set_allowInputDeviceCreationFromEventsDelegate>("UnityEngineInternal.Input.NativeInputSystem::set_allowInputDeviceCreationFromEvents");
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1253174, XrefRangeEnd = 1253178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void NotifyBeforeUpdate(NativeInputUpdateType updateType)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&updateType);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NotifyBeforeUpdate_Internal_Static_Void_NativeInputUpdateType_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1253178, XrefRangeEnd = 1253182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void NotifyUpdate(NativeInputUpdateType updateType, System.IntPtr eventBuffer)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&updateType);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &eventBuffer;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NotifyUpdate_Internal_Static_Void_NativeInputUpdateType_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1253182, XrefRangeEnd = 1253186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void NotifyDeviceDiscovered(int deviceId, string deviceDescriptor)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&deviceId);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(deviceDescriptor);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NotifyDeviceDiscovered_Internal_Static_Void_Int32_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1253186, XrefRangeEnd = 1253190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ShouldRunUpdate(NativeInputUpdateType updateType, out bool retval)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&updateType);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref retval);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShouldRunUpdate_Internal_Static_Void_NativeInputUpdateType_byref_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1253201, RefRangeEnd = 1253202, XrefRangeStart = 1253199, XrefRangeEnd = 1253201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int AllocateDeviceId()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AllocateDeviceId_Public_Static_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1253204, RefRangeEnd = 1253205, XrefRangeStart = 1253202, XrefRangeEnd = 1253204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void QueueInputEvent(System.IntPtr inputEvent)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&inputEvent);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_QueueInputEvent_Public_Static_Void_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1253207, RefRangeEnd = 1253208, XrefRangeStart = 1253205, XrefRangeEnd = 1253207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static long IOCTL(int deviceId, int code, System.IntPtr data, int sizeInBytes)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&deviceId);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &code;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &data;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &sizeInBytes;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IOCTL_Public_Static_Int64_Int32_Int32_IntPtr_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(long*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1253210, RefRangeEnd = 1253211, XrefRangeStart = 1253208, XrefRangeEnd = 1253210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetPollingFrequency(float hertz)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&hertz);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetPollingFrequency_Public_Static_Void_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1253215, RefRangeEnd = 1253216, XrefRangeStart = 1253211, XrefRangeEnd = 1253215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Update(NativeInputUpdateType updateType)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&updateType);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Public_Static_Void_NativeInputUpdateType_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1253224, RefRangeEnd = 1253225, XrefRangeStart = 1253222, XrefRangeEnd = 1253224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float GetScrollWheelDeltaPerTick()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetScrollWheelDeltaPerTick_Internal_Static_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public NativeInputSystem(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public unsafe static void QueueInputEvent<TInputEvent>(ref TInputEvent inputEvent) where TInputEvent : struct
	{
		QueueInputEvent((System.IntPtr)UnsafeUtility.AddressOf(ref inputEvent));
	}

	public static ulong GetBackgroundEventBufferSize()
	{
		return GetBackgroundEventBufferSizeDelegateField();
	}

	public static void SetUpdateMask(NativeInputUpdateType mask)
	{
	}
}
