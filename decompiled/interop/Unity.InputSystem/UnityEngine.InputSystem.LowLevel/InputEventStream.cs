using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace UnityEngine.InputSystem.LowLevel;

public sealed class InputEventStream : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_NativeBuffer;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CurrentNativeEventReadPtr;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CurrentNativeEventWritePtr;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_RemainingNativeEventCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_MaxAppendedEvents;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_AppendBuffer;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CurrentAppendEventReadPtr;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CurrentAppendEventWritePtr;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_RemainingAppendEventCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_NumEventsRetainedInBuffer;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_IsOpen;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_remainingEventCount_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_numEventsRetainedInBuffer_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_currentEventPtr_Public_get_ptr_InputEvent_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_numBytesRetainedInBuffer_Public_get_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_byref_InputEventBuffer_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Close_Public_Void_byref_InputEventBuffer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CleanUpAfterException_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Write_Public_Void_ptr_InputEvent_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Advance_Public_ptr_InputEvent_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Peek_Public_ptr_InputEvent_0;

	public unsafe InputEventBuffer m_NativeBuffer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_NativeBuffer);
			return new InputEventBuffer(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InputEventBuffer>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_NativeBuffer), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<InputEventBuffer>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe InputEvent* m_CurrentNativeEventReadPtr
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CurrentNativeEventReadPtr);
			return *(InputEvent**)num;
		}
		set
		{
			*(InputEvent**)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CurrentNativeEventReadPtr)) = value;
		}
	}

	public unsafe InputEvent* m_CurrentNativeEventWritePtr
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CurrentNativeEventWritePtr);
			return *(InputEvent**)num;
		}
		set
		{
			*(InputEvent**)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CurrentNativeEventWritePtr)) = value;
		}
	}

	public unsafe int m_RemainingNativeEventCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RemainingNativeEventCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RemainingNativeEventCount)) = value;
		}
	}

	public unsafe int m_MaxAppendedEvents
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MaxAppendedEvents);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MaxAppendedEvents)) = value;
		}
	}

	public unsafe InputEventBuffer m_AppendBuffer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AppendBuffer);
			return new InputEventBuffer(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InputEventBuffer>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AppendBuffer), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<InputEventBuffer>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe InputEvent* m_CurrentAppendEventReadPtr
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CurrentAppendEventReadPtr);
			return *(InputEvent**)num;
		}
		set
		{
			*(InputEvent**)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CurrentAppendEventReadPtr)) = value;
		}
	}

	public unsafe InputEvent* m_CurrentAppendEventWritePtr
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CurrentAppendEventWritePtr);
			return *(InputEvent**)num;
		}
		set
		{
			*(InputEvent**)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CurrentAppendEventWritePtr)) = value;
		}
	}

	public unsafe int m_RemainingAppendEventCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RemainingAppendEventCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RemainingAppendEventCount)) = value;
		}
	}

	public unsafe int m_NumEventsRetainedInBuffer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_NumEventsRetainedInBuffer);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_NumEventsRetainedInBuffer)) = value;
		}
	}

	public unsafe bool m_IsOpen
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_IsOpen);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_IsOpen)) = value;
		}
	}

	public unsafe bool isOpen
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe int remainingEventCount
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1008543, RefRangeEnd = 1008546, XrefRangeStart = 1008543, XrefRangeEnd = 1008543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_remainingEventCount_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe int numEventsRetainedInBuffer
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 241445, RefRangeEnd = 241447, XrefRangeStart = 241445, XrefRangeEnd = 241447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_numEventsRetainedInBuffer_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe InputEvent* currentEventPtr
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1008546, RefRangeEnd = 1008547, XrefRangeStart = 1008546, XrefRangeEnd = 1008546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr result = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_currentEventPtr_Public_get_ptr_InputEvent_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (InputEvent*)result;
		}
	}

	public unsafe uint numBytesRetainedInBuffer
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1008547, XrefRangeEnd = 1008550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_numBytesRetainedInBuffer_Public_get_UInt32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static InputEventStream()
	{
		Il2CppClassPointerStore<InputEventStream>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.InputSystem.dll", "UnityEngine.InputSystem.LowLevel", "InputEventStream");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputEventStream>.NativeClassPtr);
		NativeFieldInfoPtr_m_NativeBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputEventStream>.NativeClassPtr, "m_NativeBuffer");
		NativeFieldInfoPtr_m_CurrentNativeEventReadPtr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputEventStream>.NativeClassPtr, "m_CurrentNativeEventReadPtr");
		NativeFieldInfoPtr_m_CurrentNativeEventWritePtr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputEventStream>.NativeClassPtr, "m_CurrentNativeEventWritePtr");
		NativeFieldInfoPtr_m_RemainingNativeEventCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputEventStream>.NativeClassPtr, "m_RemainingNativeEventCount");
		NativeFieldInfoPtr_m_MaxAppendedEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputEventStream>.NativeClassPtr, "m_MaxAppendedEvents");
		NativeFieldInfoPtr_m_AppendBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputEventStream>.NativeClassPtr, "m_AppendBuffer");
		NativeFieldInfoPtr_m_CurrentAppendEventReadPtr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputEventStream>.NativeClassPtr, "m_CurrentAppendEventReadPtr");
		NativeFieldInfoPtr_m_CurrentAppendEventWritePtr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputEventStream>.NativeClassPtr, "m_CurrentAppendEventWritePtr");
		NativeFieldInfoPtr_m_RemainingAppendEventCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputEventStream>.NativeClassPtr, "m_RemainingAppendEventCount");
		NativeFieldInfoPtr_m_NumEventsRetainedInBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputEventStream>.NativeClassPtr, "m_NumEventsRetainedInBuffer");
		NativeFieldInfoPtr_m_IsOpen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputEventStream>.NativeClassPtr, "m_IsOpen");
		NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputEventStream>.NativeClassPtr, 100667570);
		NativeMethodInfoPtr_get_remainingEventCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputEventStream>.NativeClassPtr, 100667571);
		NativeMethodInfoPtr_get_numEventsRetainedInBuffer_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputEventStream>.NativeClassPtr, 100667572);
		NativeMethodInfoPtr_get_currentEventPtr_Public_get_ptr_InputEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputEventStream>.NativeClassPtr, 100667573);
		NativeMethodInfoPtr_get_numBytesRetainedInBuffer_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputEventStream>.NativeClassPtr, 100667574);
		NativeMethodInfoPtr__ctor_Public_Void_byref_InputEventBuffer_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputEventStream>.NativeClassPtr, 100667575);
		NativeMethodInfoPtr_Close_Public_Void_byref_InputEventBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputEventStream>.NativeClassPtr, 100667576);
		NativeMethodInfoPtr_CleanUpAfterException_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputEventStream>.NativeClassPtr, 100667577);
		NativeMethodInfoPtr_Write_Public_Void_ptr_InputEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputEventStream>.NativeClassPtr, 100667578);
		NativeMethodInfoPtr_Advance_Public_ptr_InputEvent_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputEventStream>.NativeClassPtr, 100667579);
		NativeMethodInfoPtr_Peek_Public_ptr_InputEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputEventStream>.NativeClassPtr, 100667580);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1008553, RefRangeEnd = 1008554, XrefRangeStart = 1008550, XrefRangeEnd = 1008553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe InputEventStream(ref InputEventBuffer eventBuffer, int maxAppendedEvents)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputEventStream>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)eventBuffer);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxAppendedEvents;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_byref_InputEventBuffer_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1008565, RefRangeEnd = 1008566, XrefRangeStart = 1008554, XrefRangeEnd = 1008565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Close(ref InputEventBuffer eventBuffer)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)eventBuffer);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Close_Public_Void_byref_InputEventBuffer_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1008566, XrefRangeEnd = 1008570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CleanUpAfterException()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CleanUpAfterException_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1008586, RefRangeEnd = 1008588, XrefRangeStart = 1008570, XrefRangeEnd = 1008586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Write(InputEvent* eventPtr)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)eventPtr;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Write_Public_Void_ptr_InputEvent_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 1008590, RefRangeEnd = 1008597, XrefRangeStart = 1008588, XrefRangeEnd = 1008590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe InputEvent* Advance(bool leaveEventInBuffer)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&leaveEventInBuffer);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr result = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Advance_Public_ptr_InputEvent_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (InputEvent*)result;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1008598, RefRangeEnd = 1008599, XrefRangeStart = 1008597, XrefRangeEnd = 1008598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe InputEvent* Peek()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr result = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Peek_Public_ptr_InputEvent_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (InputEvent*)result;
	}

	public InputEventStream(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public InputEventStream()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputEventStream>.NativeClassPtr))
	{
	}
}
