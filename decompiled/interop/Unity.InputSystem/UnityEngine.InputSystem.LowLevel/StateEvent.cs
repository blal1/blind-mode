using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using Unity.Collections;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.LowLevel;

[StructLayout(LayoutKind.Explicit)]
public struct StateEvent
{
	[StructLayout(LayoutKind.Explicit)]
	[ObfuscatedName("UnityEngine.InputSystem.LowLevel.StateEvent+<stateData>e__FixedBuffer")]
	public struct _stateData_e__FixedBuffer
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_FixedElementField;

		[FieldOffset(0)]
		public byte FixedElementField;

		static _stateData_e__FixedBuffer()
		{
			Il2CppClassPointerStore<_stateData_e__FixedBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StateEvent>.NativeClassPtr, "<stateData>e__FixedBuffer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<_stateData_e__FixedBuffer>.NativeClassPtr);
			NativeFieldInfoPtr_FixedElementField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_stateData_e__FixedBuffer>.NativeClassPtr, "FixedElementField");
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<_stateData_e__FixedBuffer>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	private sealed class MethodInfoStoreGeneric_GetState_Public_TState_0<TState>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_GetState_Public_TState_0, Il2CppClassPointerStore<StateEvent>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TState>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_GetState_Public_Static_TState_InputEventPtr_0<TState>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_GetState_Public_Static_TState_InputEventPtr_0, Il2CppClassPointerStore<StateEvent>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TState>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_GetEventSizeWithPayload_Public_Static_Int32_0<TState>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_GetEventSizeWithPayload_Public_Static_Int32_0, Il2CppClassPointerStore<StateEvent>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TState>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_Type;

	private static readonly System.IntPtr NativeFieldInfoPtr_kStateDataSizeToSubtract;

	private static readonly System.IntPtr NativeFieldInfoPtr_baseEvent;

	private static readonly System.IntPtr NativeFieldInfoPtr_stateFormat;

	private static readonly System.IntPtr NativeFieldInfoPtr_stateData;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_stateSizeInBytes_Public_get_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_state_Public_get_ptr_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToEventPtr_Public_InputEventPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_typeStatic_Public_Virtual_Final_New_get_FourCC_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetState_Public_TState_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetState_Public_Static_TState_InputEventPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetEventSizeWithPayload_Public_Static_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_From_Public_Static_ptr_StateEvent_InputEventPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FromUnchecked_Internal_Static_ptr_StateEvent_InputEventPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_From_Public_Static_NativeArray_1_Byte_InputDevice_byref_InputEventPtr_Allocator_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FromDefaultStateFor_Public_Static_NativeArray_1_Byte_InputDevice_byref_InputEventPtr_Allocator_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_From_Private_Static_NativeArray_1_Byte_InputDevice_byref_InputEventPtr_Allocator_Boolean_0;

	[FieldOffset(0)]
	public InputEvent baseEvent;

	[FieldOffset(20)]
	public FourCC stateFormat;

	[FieldOffset(24)]
	public _stateData_e__FixedBuffer stateData;

	public unsafe static int Type
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Type, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Type, (void*)(&value));
		}
	}

	public unsafe static int kStateDataSizeToSubtract
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kStateDataSizeToSubtract, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kStateDataSizeToSubtract, (void*)(&value));
		}
	}

	public unsafe uint stateSizeInBytes
	{
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 1009137, RefRangeEnd = 1009149, XrefRangeStart = 1009136, XrefRangeEnd = 1009137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_stateSizeInBytes_Public_get_UInt32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe void* state
	{
		[CallerCount(41)]
		[CachedScanResults(RefRangeStart = 1009149, RefRangeEnd = 1009190, XrefRangeStart = 1009149, XrefRangeEnd = 1009149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr result = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_state_Public_get_ptr_Void_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (void*)result;
		}
	}

	public unsafe virtual FourCC typeStatic
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_typeStatic_Public_Virtual_Final_New_get_FourCC_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(FourCC*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static StateEvent()
	{
		Il2CppClassPointerStore<StateEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.InputSystem.dll", "UnityEngine.InputSystem.LowLevel", "StateEvent");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StateEvent>.NativeClassPtr);
		NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateEvent>.NativeClassPtr, "Type");
		NativeFieldInfoPtr_kStateDataSizeToSubtract = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateEvent>.NativeClassPtr, "kStateDataSizeToSubtract");
		NativeFieldInfoPtr_baseEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateEvent>.NativeClassPtr, "baseEvent");
		NativeFieldInfoPtr_stateFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateEvent>.NativeClassPtr, "stateFormat");
		NativeFieldInfoPtr_stateData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateEvent>.NativeClassPtr, "stateData");
		NativeMethodInfoPtr_get_stateSizeInBytes_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateEvent>.NativeClassPtr, 100667669);
		NativeMethodInfoPtr_get_state_Public_get_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateEvent>.NativeClassPtr, 100667670);
		NativeMethodInfoPtr_ToEventPtr_Public_InputEventPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateEvent>.NativeClassPtr, 100667671);
		NativeMethodInfoPtr_get_typeStatic_Public_Virtual_Final_New_get_FourCC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateEvent>.NativeClassPtr, 100667672);
		NativeMethodInfoPtr_GetState_Public_TState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateEvent>.NativeClassPtr, 100667673);
		NativeMethodInfoPtr_GetState_Public_Static_TState_InputEventPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateEvent>.NativeClassPtr, 100667674);
		NativeMethodInfoPtr_GetEventSizeWithPayload_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateEvent>.NativeClassPtr, 100667675);
		NativeMethodInfoPtr_From_Public_Static_ptr_StateEvent_InputEventPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateEvent>.NativeClassPtr, 100667676);
		NativeMethodInfoPtr_FromUnchecked_Internal_Static_ptr_StateEvent_InputEventPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateEvent>.NativeClassPtr, 100667677);
		NativeMethodInfoPtr_From_Public_Static_NativeArray_1_Byte_InputDevice_byref_InputEventPtr_Allocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateEvent>.NativeClassPtr, 100667678);
		NativeMethodInfoPtr_FromDefaultStateFor_Public_Static_NativeArray_1_Byte_InputDevice_byref_InputEventPtr_Allocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateEvent>.NativeClassPtr, 100667679);
		NativeMethodInfoPtr_From_Private_Static_NativeArray_1_Byte_InputDevice_byref_InputEventPtr_Allocator_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateEvent>.NativeClassPtr, 100667680);
	}

	[CallerCount(1403)]
	[CachedScanResults(RefRangeStart = 106100, RefRangeEnd = 107503, XrefRangeStart = 106100, XrefRangeEnd = 107503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe InputEventPtr ToEventPtr()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToEventPtr_Public_InputEventPtr_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(InputEventPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1009190, XrefRangeEnd = 1009210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TState GetState<TState>() where TState : new()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_GetState_Public_TState_0<TState>.Pointer, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.PointerToValueGeneric<TState>(intPtr2, false, true);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1009210, XrefRangeEnd = 1009214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static TState GetState<TState>(InputEventPtr ptr) where TState : new()
	{
		System.IntPtr* ptr2 = stackalloc System.IntPtr[1];
		*ptr2 = (nint)(&ptr);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_GetState_Public_Static_TState_InputEventPtr_0<TState>.Pointer, (System.IntPtr)0, (void**)ptr2, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.PointerToValueGeneric<TState>(intPtr2, false, true);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1009215, RefRangeEnd = 1009216, XrefRangeStart = 1009214, XrefRangeEnd = 1009215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetEventSizeWithPayload<TState>() where TState : new()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_GetEventSizeWithPayload_Public_Static_Int32_0<TState>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1009220, RefRangeEnd = 1009222, XrefRangeStart = 1009216, XrefRangeEnd = 1009220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static StateEvent* From(InputEventPtr ptr)
	{
		System.IntPtr* ptr2 = stackalloc System.IntPtr[1];
		*ptr2 = (nint)(&ptr);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr result = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_From_Public_Static_ptr_StateEvent_InputEventPtr_0, (System.IntPtr)0, (void**)ptr2, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (StateEvent*)result;
	}

	[CallerCount(1403)]
	[CachedScanResults(RefRangeStart = 106100, RefRangeEnd = 107503, XrefRangeStart = 106100, XrefRangeEnd = 107503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static StateEvent* FromUnchecked(InputEventPtr ptr)
	{
		System.IntPtr* ptr2 = stackalloc System.IntPtr[1];
		*ptr2 = (nint)(&ptr);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr result = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FromUnchecked_Internal_Static_ptr_StateEvent_InputEventPtr_0, (System.IntPtr)0, (void**)ptr2, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (StateEvent*)result;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1009223, RefRangeEnd = 1009227, XrefRangeStart = 1009222, XrefRangeEnd = 1009223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static NativeArray<byte> From(InputDevice device, out InputEventPtr eventPtr, Allocator allocator = Allocator.Temp)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)device);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref eventPtr);
		*(Allocator**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &allocator;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_From_Public_Static_NativeArray_1_Byte_InputDevice_byref_InputEventPtr_Allocator_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new NativeArray<byte>(pointer);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1009227, XrefRangeEnd = 1009228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static NativeArray<byte> FromDefaultStateFor(InputDevice device, out InputEventPtr eventPtr, Allocator allocator = Allocator.Temp)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)device);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref eventPtr);
		*(Allocator**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &allocator;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FromDefaultStateFor_Public_Static_NativeArray_1_Byte_InputDevice_byref_InputEventPtr_Allocator_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new NativeArray<byte>(pointer);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1009252, RefRangeEnd = 1009254, XrefRangeStart = 1009228, XrefRangeEnd = 1009252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static NativeArray<byte> From(InputDevice device, out InputEventPtr eventPtr, Allocator allocator, bool useDefaultState)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)device);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref eventPtr);
		*(Allocator**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &allocator;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &useDefaultState;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_From_Private_Static_NativeArray_1_Byte_InputDevice_byref_InputEventPtr_Allocator_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new NativeArray<byte>(pointer);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StateEvent>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
