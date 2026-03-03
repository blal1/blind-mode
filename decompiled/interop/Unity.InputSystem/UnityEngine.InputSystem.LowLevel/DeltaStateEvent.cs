using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using Unity.Collections;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.LowLevel;

[StructLayout(LayoutKind.Explicit)]
public struct DeltaStateEvent
{
	[StructLayout(LayoutKind.Explicit)]
	[ObfuscatedName("UnityEngine.InputSystem.LowLevel.DeltaStateEvent+<stateData>e__FixedBuffer")]
	public struct _stateData_e__FixedBuffer
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_FixedElementField;

		[FieldOffset(0)]
		public byte FixedElementField;

		static _stateData_e__FixedBuffer()
		{
			Il2CppClassPointerStore<_stateData_e__FixedBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DeltaStateEvent>.NativeClassPtr, "<stateData>e__FixedBuffer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<_stateData_e__FixedBuffer>.NativeClassPtr);
			NativeFieldInfoPtr_FixedElementField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_stateData_e__FixedBuffer>.NativeClassPtr, "FixedElementField");
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<_stateData_e__FixedBuffer>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_Type;

	private static readonly System.IntPtr NativeFieldInfoPtr_baseEvent;

	private static readonly System.IntPtr NativeFieldInfoPtr_stateFormat;

	private static readonly System.IntPtr NativeFieldInfoPtr_stateOffset;

	private static readonly System.IntPtr NativeFieldInfoPtr_stateData;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_deltaStateSizeInBytes_Public_get_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_deltaState_Public_get_ptr_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_typeStatic_Public_Virtual_Final_New_get_FourCC_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToEventPtr_Public_InputEventPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_From_Public_Static_ptr_DeltaStateEvent_InputEventPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FromUnchecked_Internal_Static_ptr_DeltaStateEvent_InputEventPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_From_Public_Static_NativeArray_1_Byte_InputControl_byref_InputEventPtr_Allocator_0;

	[FieldOffset(0)]
	public InputEvent baseEvent;

	[FieldOffset(20)]
	public FourCC stateFormat;

	[FieldOffset(24)]
	public uint stateOffset;

	[FieldOffset(28)]
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

	public unsafe uint deltaStateSizeInBytes
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1008143, RefRangeEnd = 1008146, XrefRangeStart = 1008143, XrefRangeEnd = 1008143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_deltaStateSizeInBytes_Public_get_UInt32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe void* deltaState
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1008146, RefRangeEnd = 1008149, XrefRangeStart = 1008146, XrefRangeEnd = 1008146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr result = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_deltaState_Public_get_ptr_Void_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
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

	static DeltaStateEvent()
	{
		Il2CppClassPointerStore<DeltaStateEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.InputSystem.dll", "UnityEngine.InputSystem.LowLevel", "DeltaStateEvent");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeltaStateEvent>.NativeClassPtr);
		NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeltaStateEvent>.NativeClassPtr, "Type");
		NativeFieldInfoPtr_baseEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeltaStateEvent>.NativeClassPtr, "baseEvent");
		NativeFieldInfoPtr_stateFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeltaStateEvent>.NativeClassPtr, "stateFormat");
		NativeFieldInfoPtr_stateOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeltaStateEvent>.NativeClassPtr, "stateOffset");
		NativeFieldInfoPtr_stateData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeltaStateEvent>.NativeClassPtr, "stateData");
		NativeMethodInfoPtr_get_deltaStateSizeInBytes_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeltaStateEvent>.NativeClassPtr, 100667460);
		NativeMethodInfoPtr_get_deltaState_Public_get_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeltaStateEvent>.NativeClassPtr, 100667461);
		NativeMethodInfoPtr_get_typeStatic_Public_Virtual_Final_New_get_FourCC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeltaStateEvent>.NativeClassPtr, 100667462);
		NativeMethodInfoPtr_ToEventPtr_Public_InputEventPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeltaStateEvent>.NativeClassPtr, 100667463);
		NativeMethodInfoPtr_From_Public_Static_ptr_DeltaStateEvent_InputEventPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeltaStateEvent>.NativeClassPtr, 100667464);
		NativeMethodInfoPtr_FromUnchecked_Internal_Static_ptr_DeltaStateEvent_InputEventPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeltaStateEvent>.NativeClassPtr, 100667465);
		NativeMethodInfoPtr_From_Public_Static_NativeArray_1_Byte_InputControl_byref_InputEventPtr_Allocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeltaStateEvent>.NativeClassPtr, 100667466);
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

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1008152, RefRangeEnd = 1008154, XrefRangeStart = 1008149, XrefRangeEnd = 1008152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static DeltaStateEvent* From(InputEventPtr ptr)
	{
		System.IntPtr* ptr2 = stackalloc System.IntPtr[1];
		*ptr2 = (nint)(&ptr);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr result = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_From_Public_Static_ptr_DeltaStateEvent_InputEventPtr_0, (System.IntPtr)0, (void**)ptr2, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (DeltaStateEvent*)result;
	}

	[CallerCount(1403)]
	[CachedScanResults(RefRangeStart = 106100, RefRangeEnd = 107503, XrefRangeStart = 106100, XrefRangeEnd = 107503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static DeltaStateEvent* FromUnchecked(InputEventPtr ptr)
	{
		System.IntPtr* ptr2 = stackalloc System.IntPtr[1];
		*ptr2 = (nint)(&ptr);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr result = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FromUnchecked_Internal_Static_ptr_DeltaStateEvent_InputEventPtr_0, (System.IntPtr)0, (void**)ptr2, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (DeltaStateEvent*)result;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1008154, XrefRangeEnd = 1008180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static NativeArray<byte> From(InputControl control, out InputEventPtr eventPtr, Allocator allocator = Allocator.Temp)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)control);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref eventPtr);
		*(Allocator**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &allocator;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_From_Public_Static_NativeArray_1_Byte_InputControl_byref_InputEventPtr_Allocator_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new NativeArray<byte>(pointer);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DeltaStateEvent>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
