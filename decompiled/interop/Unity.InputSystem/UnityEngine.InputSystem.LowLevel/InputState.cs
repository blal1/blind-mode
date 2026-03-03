using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.LowLevel;

public static class InputState : Il2CppSystem.Object
{
	public class StateChangeMonitorDelegate : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_valueChangeCallback;

		private static readonly System.IntPtr NativeFieldInfoPtr_timerExpiredCallback;

		private static readonly System.IntPtr NativeMethodInfoPtr_NotifyControlStateChanged_Public_Virtual_Final_New_Void_InputControl_Double_InputEventPtr_Int64_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_NotifyTimerExpired_Public_Virtual_Final_New_Void_InputControl_Double_Int64_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe Il2CppSystem.Action<InputControl, double, InputEventPtr, long> valueChangeCallback
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_valueChangeCallback);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<InputControl, double, InputEventPtr, long>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_valueChangeCallback)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe Il2CppSystem.Action<InputControl, double, long, int> timerExpiredCallback
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timerExpiredCallback);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<InputControl, double, long, int>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timerExpiredCallback)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		static StateChangeMonitorDelegate()
		{
			Il2CppClassPointerStore<StateChangeMonitorDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputState>.NativeClassPtr, "StateChangeMonitorDelegate");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StateChangeMonitorDelegate>.NativeClassPtr);
			NativeFieldInfoPtr_valueChangeCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateChangeMonitorDelegate>.NativeClassPtr, "valueChangeCallback");
			NativeFieldInfoPtr_timerExpiredCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateChangeMonitorDelegate>.NativeClassPtr, "timerExpiredCallback");
			NativeMethodInfoPtr_NotifyControlStateChanged_Public_Virtual_Final_New_Void_InputControl_Double_InputEventPtr_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateChangeMonitorDelegate>.NativeClassPtr, 100667816);
			NativeMethodInfoPtr_NotifyTimerExpired_Public_Virtual_Final_New_Void_InputControl_Double_Int64_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateChangeMonitorDelegate>.NativeClassPtr, 100667817);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateChangeMonitorDelegate>.NativeClassPtr, 100667818);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1009492, XrefRangeEnd = 1009493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void NotifyControlStateChanged(InputControl control, double time, InputEventPtr eventPtr, long monitorIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[4];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)control);
			*(double**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
			*(InputEventPtr**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &eventPtr;
			*(long**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &monitorIndex;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NotifyControlStateChanged_Public_Virtual_Final_New_Void_InputControl_Double_InputEventPtr_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		public unsafe virtual void NotifyTimerExpired(InputControl control, double time, long monitorIndex, int timerIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[4];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)control);
			*(double**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
			*(long**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &monitorIndex;
			*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &timerIndex;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NotifyTimerExpired_Public_Virtual_Final_New_Void_InputControl_Double_Int64_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(1950)]
		[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StateChangeMonitorDelegate()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StateChangeMonitorDelegate>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public StateChangeMonitorDelegate(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private sealed class MethodInfoStoreGeneric_Change_Public_Static_Void_InputControl_TState_InputUpdateType_InputEventPtr_0<TState>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_Change_Public_Static_Void_InputControl_TState_InputUpdateType_InputEventPtr_0, Il2CppClassPointerStore<InputState>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TState>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_Change_Public_Static_Void_InputControl_byref_TState_InputUpdateType_InputEventPtr_0<TState>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_Change_Public_Static_Void_InputControl_byref_TState_InputUpdateType_InputEventPtr_0, Il2CppClassPointerStore<InputState>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TState>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeMethodInfoPtr_get_currentUpdateType_Public_Static_get_InputUpdateType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_updateCount_Public_Static_get_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_currentTime_Public_Static_get_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_add_onChange_Public_Static_add_Void_Action_2_InputDevice_InputEventPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_remove_onChange_Public_Static_rem_Void_Action_2_InputDevice_InputEventPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Change_Public_Static_Void_InputDevice_InputEventPtr_InputUpdateType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Change_Public_Static_Void_InputControl_TState_InputUpdateType_InputEventPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Change_Public_Static_Void_InputControl_byref_TState_InputUpdateType_InputEventPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsIntegerFormat_Public_Static_Boolean_FourCC_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddChangeMonitor_Public_Static_Void_InputControl_IInputStateChangeMonitor_Int64_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddChangeMonitor_Public_Static_IInputStateChangeMonitor_InputControl_Action_4_InputControl_Double_InputEventPtr_Int64_Int32_Action_4_InputControl_Double_Int64_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveChangeMonitor_Public_Static_Void_InputControl_IInputStateChangeMonitor_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddChangeMonitorTimeout_Public_Static_Void_InputControl_IInputStateChangeMonitor_Double_Int64_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveChangeMonitorTimeout_Public_Static_Void_IInputStateChangeMonitor_Int64_Int32_0;

	public unsafe static InputUpdateType currentUpdateType
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1009493, XrefRangeEnd = 1009495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_currentUpdateType_Public_Static_get_InputUpdateType_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(InputUpdateType*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static uint updateCount
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1009495, XrefRangeEnd = 1009497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_updateCount_Public_Static_get_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static double currentTime
	{
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 1009503, RefRangeEnd = 1009514, XrefRangeStart = 1009497, XrefRangeEnd = 1009503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_currentTime_Public_Static_get_Double_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(double*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static InputState()
	{
		Il2CppClassPointerStore<InputState>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.InputSystem.dll", "UnityEngine.InputSystem.LowLevel", "InputState");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputState>.NativeClassPtr);
		NativeMethodInfoPtr_get_currentUpdateType_Public_Static_get_InputUpdateType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputState>.NativeClassPtr, 100667802);
		NativeMethodInfoPtr_get_updateCount_Public_Static_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputState>.NativeClassPtr, 100667803);
		NativeMethodInfoPtr_get_currentTime_Public_Static_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputState>.NativeClassPtr, 100667804);
		NativeMethodInfoPtr_add_onChange_Public_Static_add_Void_Action_2_InputDevice_InputEventPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputState>.NativeClassPtr, 100667805);
		NativeMethodInfoPtr_remove_onChange_Public_Static_rem_Void_Action_2_InputDevice_InputEventPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputState>.NativeClassPtr, 100667806);
		NativeMethodInfoPtr_Change_Public_Static_Void_InputDevice_InputEventPtr_InputUpdateType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputState>.NativeClassPtr, 100667807);
		NativeMethodInfoPtr_Change_Public_Static_Void_InputControl_TState_InputUpdateType_InputEventPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputState>.NativeClassPtr, 100667808);
		NativeMethodInfoPtr_Change_Public_Static_Void_InputControl_byref_TState_InputUpdateType_InputEventPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputState>.NativeClassPtr, 100667809);
		NativeMethodInfoPtr_IsIntegerFormat_Public_Static_Boolean_FourCC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputState>.NativeClassPtr, 100667810);
		NativeMethodInfoPtr_AddChangeMonitor_Public_Static_Void_InputControl_IInputStateChangeMonitor_Int64_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputState>.NativeClassPtr, 100667811);
		NativeMethodInfoPtr_AddChangeMonitor_Public_Static_IInputStateChangeMonitor_InputControl_Action_4_InputControl_Double_InputEventPtr_Int64_Int32_Action_4_InputControl_Double_Int64_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputState>.NativeClassPtr, 100667812);
		NativeMethodInfoPtr_RemoveChangeMonitor_Public_Static_Void_InputControl_IInputStateChangeMonitor_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputState>.NativeClassPtr, 100667813);
		NativeMethodInfoPtr_AddChangeMonitorTimeout_Public_Static_Void_InputControl_IInputStateChangeMonitor_Double_Int64_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputState>.NativeClassPtr, 100667814);
		NativeMethodInfoPtr_RemoveChangeMonitorTimeout_Public_Static_Void_IInputStateChangeMonitor_Int64_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputState>.NativeClassPtr, 100667815);
	}

	[SpecialName]
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1009514, XrefRangeEnd = 1009520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_onChange(Il2CppSystem.Action<InputDevice, InputEventPtr> value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_add_onChange_Public_Static_add_Void_Action_2_InputDevice_InputEventPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[SpecialName]
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1009520, XrefRangeEnd = 1009526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_onChange(Il2CppSystem.Action<InputDevice, InputEventPtr> value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_remove_onChange_Public_Static_rem_Void_Action_2_InputDevice_InputEventPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 1009543, RefRangeEnd = 1009550, XrefRangeStart = 1009526, XrefRangeEnd = 1009543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Change(InputDevice device, InputEventPtr eventPtr, InputUpdateType updateType = InputUpdateType.None)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)device);
		*(InputEventPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &eventPtr;
		*(InputUpdateType**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &updateType;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Change_Public_Static_Void_InputDevice_InputEventPtr_InputUpdateType_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1009552, RefRangeEnd = 1009554, XrefRangeStart = 1009550, XrefRangeEnd = 1009552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Change<TState>(InputControl control, TState state, InputUpdateType updateType = InputUpdateType.None, InputEventPtr eventPtr = default(InputEventPtr)) where TState : new()
	{
		//IL_0057->IL005a: Incompatible stack types: I vs Ref
		//IL_004a->IL005a: Incompatible stack types: I vs Ref
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)control);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		ref TState reference;
		if (!typeof(TState).IsValueType)
		{
			object obj = state;
			reference = ref *(_003F*)((!(obj is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)((obj is Il2CppObjectBase) ? obj : null)) : IL2CPP.ManagedStringToIl2Cpp(obj as string));
		}
		else
		{
			reference = ref state;
		}
		*(void**)num = Unsafe.AsPointer(ref reference);
		*(InputUpdateType**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &updateType;
		*(InputEventPtr**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &eventPtr;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_Change_Public_Static_Void_InputControl_TState_InputUpdateType_InputEventPtr_0<TState>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1009583, RefRangeEnd = 1009584, XrefRangeStart = 1009554, XrefRangeEnd = 1009583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Change<TState>(InputControl control, ref TState state, InputUpdateType updateType = InputUpdateType.None, InputEventPtr eventPtr = default(InputEventPtr)) where TState : new()
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)control);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)Unsafe.As<TState, object>(ref state));
		*(System.IntPtr**)num = &intPtr;
		*(InputUpdateType**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &updateType;
		*(InputEventPtr**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &eventPtr;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_Change_Public_Static_Void_InputControl_byref_TState_InputUpdateType_InputEventPtr_0<TState>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		Unsafe.As<TState, object>(ref state) = ((intPtr4 == (System.IntPtr)0) ? ((TState)null) : IL2CPP.PointerToValueGeneric<TState>(intPtr4, false, false));
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1009604, RefRangeEnd = 1009606, XrefRangeStart = 1009584, XrefRangeEnd = 1009604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsIntegerFormat(this FourCC format)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&format);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsIntegerFormat_Public_Static_Boolean_FourCC_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1009612, RefRangeEnd = 1009614, XrefRangeStart = 1009606, XrefRangeEnd = 1009612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void AddChangeMonitor(InputControl control, IInputStateChangeMonitor monitor, long monitorIndex = -1L, uint groupIndex = 0u)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)control);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)monitor);
		*(long**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &monitorIndex;
		*(uint**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &groupIndex;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddChangeMonitor_Public_Static_Void_InputControl_IInputStateChangeMonitor_Int64_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1009614, XrefRangeEnd = 1009621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static IInputStateChangeMonitor AddChangeMonitor(InputControl control, Il2CppSystem.Action<InputControl, double, InputEventPtr, long> valueChangeCallback, int monitorIndex = -1, Il2CppSystem.Action<InputControl, double, long, int> timerExpiredCallback = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)control);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)valueChangeCallback);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &monitorIndex;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)timerExpiredCallback);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddChangeMonitor_Public_Static_IInputStateChangeMonitor_InputControl_Action_4_InputControl_Double_InputEventPtr_Int64_Int32_Action_4_InputControl_Double_Int64_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IInputStateChangeMonitor>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1009621, XrefRangeEnd = 1009626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RemoveChangeMonitor(InputControl control, IInputStateChangeMonitor monitor, long monitorIndex = -1L)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)control);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)monitor);
		*(long**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &monitorIndex;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveChangeMonitor_Public_Static_Void_InputControl_IInputStateChangeMonitor_Int64_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1009626, XrefRangeEnd = 1009631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void AddChangeMonitorTimeout(InputControl control, IInputStateChangeMonitor monitor, double time, long monitorIndex = -1L, int timerIndex = -1)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)control);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)monitor);
		*(double**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		*(long**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &monitorIndex;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &timerIndex;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddChangeMonitorTimeout_Public_Static_Void_InputControl_IInputStateChangeMonitor_Double_Int64_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1009631, XrefRangeEnd = 1009636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RemoveChangeMonitorTimeout(IInputStateChangeMonitor monitor, long monitorIndex = -1L, int timerIndex = -1)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)monitor);
		*(long**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &monitorIndex;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &timerIndex;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveChangeMonitorTimeout_Public_Static_Void_IInputStateChangeMonitor_Int64_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public InputState(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
