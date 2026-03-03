using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using UnityEngine.InputSystem.Utilities;
using UnityEngineInternal.Input;

namespace UnityEngine.InputSystem.LowLevel;

[StructLayout(LayoutKind.Explicit)]
public struct InputEvent
{
	private static readonly System.IntPtr NativeFieldInfoPtr_kHandledMask;

	private static readonly System.IntPtr NativeFieldInfoPtr_kIdMask;

	private static readonly System.IntPtr NativeFieldInfoPtr_kBaseEventSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_InvalidEventId;

	private static readonly System.IntPtr NativeFieldInfoPtr_kAlignment;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Event;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_type_Public_get_FourCC_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_type_Public_set_Void_FourCC_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_sizeInBytes_Public_get_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_sizeInBytes_Public_set_Void_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_eventId_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_eventId_Public_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_deviceId_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_deviceId_Public_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_time_Public_get_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_time_Public_set_Void_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_internalTime_Internal_get_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_internalTime_Internal_set_Void_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_FourCC_Int32_Int32_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_handled_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_handled_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetNextInMemory_Internal_Static_ptr_InputEvent_ptr_InputEvent_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetNextInMemoryChecked_Internal_Static_ptr_InputEvent_ptr_InputEvent_byref_InputEventBuffer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Static_Boolean_ptr_InputEvent_ptr_InputEvent_0;

	[FieldOffset(0)]
	public NativeInputEvent m_Event;

	public unsafe static uint kHandledMask
	{
		get
		{
			Unsafe.SkipInit(out uint result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kHandledMask, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kHandledMask, (void*)(&value));
		}
	}

	public unsafe static uint kIdMask
	{
		get
		{
			Unsafe.SkipInit(out uint result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kIdMask, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kIdMask, (void*)(&value));
		}
	}

	public unsafe static int kBaseEventSize
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kBaseEventSize, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kBaseEventSize, (void*)(&value));
		}
	}

	public unsafe static int InvalidEventId
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_InvalidEventId, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_InvalidEventId, (void*)(&value));
		}
	}

	public unsafe static int kAlignment
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kAlignment, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kAlignment, (void*)(&value));
		}
	}

	public unsafe FourCC type
	{
		[CallerCount(175)]
		[CachedScanResults(RefRangeStart = 52464, RefRangeEnd = 52639, XrefRangeStart = 52464, XrefRangeEnd = 52639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_type_Public_get_FourCC_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(FourCC*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 53703, RefRangeEnd = 53715, XrefRangeStart = 53703, XrefRangeEnd = 53715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_type_Public_set_Void_FourCC_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe uint sizeInBytes
	{
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 545405, RefRangeEnd = 545411, XrefRangeStart = 545405, XrefRangeEnd = 545411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_sizeInBytes_Public_get_UInt32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1008215, RefRangeEnd = 1008217, XrefRangeStart = 1008215, XrefRangeEnd = 1008215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_sizeInBytes_Public_set_Void_UInt32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe int eventId
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1008217, RefRangeEnd = 1008219, XrefRangeStart = 1008217, XrefRangeEnd = 1008217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_eventId_Public_get_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1008219, RefRangeEnd = 1008220, XrefRangeStart = 1008219, XrefRangeEnd = 1008219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_eventId_Public_set_Void_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe int deviceId
	{
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 546088, RefRangeEnd = 546092, XrefRangeStart = 546088, XrefRangeEnd = 546092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_deviceId_Public_get_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 546092, RefRangeEnd = 546096, XrefRangeStart = 546092, XrefRangeEnd = 546096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_deviceId_Public_set_Void_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe double time
	{
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1008222, RefRangeEnd = 1008226, XrefRangeStart = 1008220, XrefRangeEnd = 1008222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_time_Public_get_Double_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(double*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1008228, RefRangeEnd = 1008230, XrefRangeStart = 1008226, XrefRangeEnd = 1008228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_time_Public_set_Void_Double_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe double internalTime
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 968555, RefRangeEnd = 968557, XrefRangeStart = 968555, XrefRangeEnd = 968557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_internalTime_Internal_get_Double_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(double*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_internalTime_Internal_set_Void_Double_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool handled
	{
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1005298, RefRangeEnd = 1005302, XrefRangeStart = 1005298, XrefRangeEnd = 1005302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_handled_Public_get_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1008244, RefRangeEnd = 1008246, XrefRangeStart = 1008244, XrefRangeEnd = 1008244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_handled_Public_set_Void_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	static InputEvent()
	{
		Il2CppClassPointerStore<InputEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.InputSystem.dll", "UnityEngine.InputSystem.LowLevel", "InputEvent");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputEvent>.NativeClassPtr);
		NativeFieldInfoPtr_kHandledMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputEvent>.NativeClassPtr, "kHandledMask");
		NativeFieldInfoPtr_kIdMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputEvent>.NativeClassPtr, "kIdMask");
		NativeFieldInfoPtr_kBaseEventSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputEvent>.NativeClassPtr, "kBaseEventSize");
		NativeFieldInfoPtr_InvalidEventId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputEvent>.NativeClassPtr, "InvalidEventId");
		NativeFieldInfoPtr_kAlignment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputEvent>.NativeClassPtr, "kAlignment");
		NativeFieldInfoPtr_m_Event = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputEvent>.NativeClassPtr, "m_Event");
		NativeMethodInfoPtr_get_type_Public_get_FourCC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputEvent>.NativeClassPtr, 100667490);
		NativeMethodInfoPtr_set_type_Public_set_Void_FourCC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputEvent>.NativeClassPtr, 100667491);
		NativeMethodInfoPtr_get_sizeInBytes_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputEvent>.NativeClassPtr, 100667492);
		NativeMethodInfoPtr_set_sizeInBytes_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputEvent>.NativeClassPtr, 100667493);
		NativeMethodInfoPtr_get_eventId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputEvent>.NativeClassPtr, 100667494);
		NativeMethodInfoPtr_set_eventId_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputEvent>.NativeClassPtr, 100667495);
		NativeMethodInfoPtr_get_deviceId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputEvent>.NativeClassPtr, 100667496);
		NativeMethodInfoPtr_set_deviceId_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputEvent>.NativeClassPtr, 100667497);
		NativeMethodInfoPtr_get_time_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputEvent>.NativeClassPtr, 100667498);
		NativeMethodInfoPtr_set_time_Public_set_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputEvent>.NativeClassPtr, 100667499);
		NativeMethodInfoPtr_get_internalTime_Internal_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputEvent>.NativeClassPtr, 100667500);
		NativeMethodInfoPtr_set_internalTime_Internal_set_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputEvent>.NativeClassPtr, 100667501);
		NativeMethodInfoPtr__ctor_Public_Void_FourCC_Int32_Int32_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputEvent>.NativeClassPtr, 100667502);
		NativeMethodInfoPtr_get_handled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputEvent>.NativeClassPtr, 100667503);
		NativeMethodInfoPtr_set_handled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputEvent>.NativeClassPtr, 100667504);
		NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputEvent>.NativeClassPtr, 100667505);
		NativeMethodInfoPtr_GetNextInMemory_Internal_Static_ptr_InputEvent_ptr_InputEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputEvent>.NativeClassPtr, 100667506);
		NativeMethodInfoPtr_GetNextInMemoryChecked_Internal_Static_ptr_InputEvent_ptr_InputEvent_byref_InputEventBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputEvent>.NativeClassPtr, 100667507);
		NativeMethodInfoPtr_Equals_Public_Static_Boolean_ptr_InputEvent_ptr_InputEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputEvent>.NativeClassPtr, 100667508);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 1008235, RefRangeEnd = 1008244, XrefRangeStart = 1008230, XrefRangeEnd = 1008235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe InputEvent(FourCC type, int sizeInBytes, int deviceId, double time = -1.0)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&type);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &sizeInBytes;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &deviceId;
		*(double**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_FourCC_Int32_Int32_Double_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1008275, RefRangeEnd = 1008276, XrefRangeStart = 1008246, XrefRangeEnd = 1008275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override string ToString()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToString_Public_Virtual_String_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1008276, RefRangeEnd = 1008277, XrefRangeStart = 1008276, XrefRangeEnd = 1008276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static InputEvent* GetNextInMemory(InputEvent* currentPtr)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)currentPtr;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr result = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetNextInMemory_Internal_Static_ptr_InputEvent_ptr_InputEvent_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (InputEvent*)result;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1008277, XrefRangeEnd = 1008280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static InputEvent* GetNextInMemoryChecked(InputEvent* currentPtr, ref InputEventBuffer buffer)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)currentPtr;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)buffer);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr result = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetNextInMemoryChecked_Internal_Static_ptr_InputEvent_ptr_InputEvent_byref_InputEventBuffer_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (InputEvent*)result;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1008280, XrefRangeEnd = 1008281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool Equals(InputEvent* first, InputEvent* second)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)first;
		*(InputEvent**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = second;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Static_Boolean_ptr_InputEvent_ptr_InputEvent_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InputEvent>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
