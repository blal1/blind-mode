using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.LowLevel;

[StructLayout(LayoutKind.Explicit)]
public struct ActionEvent
{
	[StructLayout(LayoutKind.Explicit)]
	[ObfuscatedName("UnityEngine.InputSystem.LowLevel.ActionEvent+<m_ValueData>e__FixedBuffer")]
	public struct _m_ValueData_e__FixedBuffer
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_FixedElementField;

		[FieldOffset(0)]
		public byte FixedElementField;

		static _m_ValueData_e__FixedBuffer()
		{
			Il2CppClassPointerStore<_m_ValueData_e__FixedBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ActionEvent>.NativeClassPtr, "<m_ValueData>e__FixedBuffer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<_m_ValueData_e__FixedBuffer>.NativeClassPtr);
			NativeFieldInfoPtr_FixedElementField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_m_ValueData_e__FixedBuffer>.NativeClassPtr, "FixedElementField");
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<_m_ValueData_e__FixedBuffer>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_baseEvent;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ControlIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_BindingIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_InteractionIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_StateIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Phase;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_StartTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ValueData;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Type_Public_Static_get_FourCC_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_startTime_Public_get_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_startTime_Public_set_Void_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_phase_Public_get_InputActionPhase_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_phase_Public_set_Void_InputActionPhase_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_valueData_Public_get_ptr_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_valueSizeInBytes_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_stateIndex_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_stateIndex_Public_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_controlIndex_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_controlIndex_Public_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_bindingIndex_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_bindingIndex_Public_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_interactionIndex_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_interactionIndex_Public_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToEventPtr_Public_InputEventPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_typeStatic_Public_Virtual_Final_New_get_FourCC_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetEventSizeWithValueSize_Public_Static_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_From_Public_Static_ptr_ActionEvent_InputEventPtr_0;

	[FieldOffset(0)]
	public InputEvent baseEvent;

	[FieldOffset(20)]
	public ushort m_ControlIndex;

	[FieldOffset(22)]
	public ushort m_BindingIndex;

	[FieldOffset(24)]
	public ushort m_InteractionIndex;

	[FieldOffset(26)]
	public byte m_StateIndex;

	[FieldOffset(27)]
	public byte m_Phase;

	[FieldOffset(28)]
	public double m_StartTime;

	[FieldOffset(36)]
	public _m_ValueData_e__FixedBuffer m_ValueData;

	public unsafe static FourCC Type
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1008122, RefRangeEnd = 1008123, XrefRangeStart = 1008121, XrefRangeEnd = 1008122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Type_Public_Static_get_FourCC_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(FourCC*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe double startTime
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_startTime_Public_get_Double_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(double*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_startTime_Public_set_Void_Double_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe InputActionPhase phase
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_phase_Public_get_InputActionPhase_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(InputActionPhase*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 617443, RefRangeEnd = 617444, XrefRangeStart = 617443, XrefRangeEnd = 617444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_phase_Public_set_Void_InputActionPhase_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe byte* valueData
	{
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1008123, RefRangeEnd = 1008127, XrefRangeStart = 1008123, XrefRangeEnd = 1008123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr result = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_valueData_Public_get_ptr_Byte_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (byte*)result;
		}
	}

	public unsafe int valueSizeInBytes
	{
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1008127, RefRangeEnd = 1008131, XrefRangeStart = 1008127, XrefRangeEnd = 1008127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_valueSizeInBytes_Public_get_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe int stateIndex
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_stateIndex_Public_get_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1008131, RefRangeEnd = 1008132, XrefRangeStart = 1008131, XrefRangeEnd = 1008131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_stateIndex_Public_set_Void_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe int controlIndex
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_controlIndex_Public_get_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1008132, RefRangeEnd = 1008133, XrefRangeStart = 1008132, XrefRangeEnd = 1008132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_controlIndex_Public_set_Void_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe int bindingIndex
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_bindingIndex_Public_get_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1008133, RefRangeEnd = 1008134, XrefRangeStart = 1008133, XrefRangeEnd = 1008133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_bindingIndex_Public_set_Void_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe int interactionIndex
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1008134, RefRangeEnd = 1008136, XrefRangeStart = 1008134, XrefRangeEnd = 1008134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_interactionIndex_Public_get_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1008136, RefRangeEnd = 1008137, XrefRangeStart = 1008136, XrefRangeEnd = 1008136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_interactionIndex_Public_set_Void_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe virtual FourCC typeStatic
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1008138, RefRangeEnd = 1008139, XrefRangeStart = 1008137, XrefRangeEnd = 1008138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_typeStatic_Public_Virtual_Final_New_get_FourCC_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(FourCC*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static ActionEvent()
	{
		Il2CppClassPointerStore<ActionEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.InputSystem.dll", "UnityEngine.InputSystem.LowLevel", "ActionEvent");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActionEvent>.NativeClassPtr);
		NativeFieldInfoPtr_baseEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionEvent>.NativeClassPtr, "baseEvent");
		NativeFieldInfoPtr_m_ControlIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionEvent>.NativeClassPtr, "m_ControlIndex");
		NativeFieldInfoPtr_m_BindingIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionEvent>.NativeClassPtr, "m_BindingIndex");
		NativeFieldInfoPtr_m_InteractionIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionEvent>.NativeClassPtr, "m_InteractionIndex");
		NativeFieldInfoPtr_m_StateIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionEvent>.NativeClassPtr, "m_StateIndex");
		NativeFieldInfoPtr_m_Phase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionEvent>.NativeClassPtr, "m_Phase");
		NativeFieldInfoPtr_m_StartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionEvent>.NativeClassPtr, "m_StartTime");
		NativeFieldInfoPtr_m_ValueData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionEvent>.NativeClassPtr, "m_ValueData");
		NativeMethodInfoPtr_get_Type_Public_Static_get_FourCC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionEvent>.NativeClassPtr, 100667441);
		NativeMethodInfoPtr_get_startTime_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionEvent>.NativeClassPtr, 100667442);
		NativeMethodInfoPtr_set_startTime_Public_set_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionEvent>.NativeClassPtr, 100667443);
		NativeMethodInfoPtr_get_phase_Public_get_InputActionPhase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionEvent>.NativeClassPtr, 100667444);
		NativeMethodInfoPtr_set_phase_Public_set_Void_InputActionPhase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionEvent>.NativeClassPtr, 100667445);
		NativeMethodInfoPtr_get_valueData_Public_get_ptr_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionEvent>.NativeClassPtr, 100667446);
		NativeMethodInfoPtr_get_valueSizeInBytes_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionEvent>.NativeClassPtr, 100667447);
		NativeMethodInfoPtr_get_stateIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionEvent>.NativeClassPtr, 100667448);
		NativeMethodInfoPtr_set_stateIndex_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionEvent>.NativeClassPtr, 100667449);
		NativeMethodInfoPtr_get_controlIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionEvent>.NativeClassPtr, 100667450);
		NativeMethodInfoPtr_set_controlIndex_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionEvent>.NativeClassPtr, 100667451);
		NativeMethodInfoPtr_get_bindingIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionEvent>.NativeClassPtr, 100667452);
		NativeMethodInfoPtr_set_bindingIndex_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionEvent>.NativeClassPtr, 100667453);
		NativeMethodInfoPtr_get_interactionIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionEvent>.NativeClassPtr, 100667454);
		NativeMethodInfoPtr_set_interactionIndex_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionEvent>.NativeClassPtr, 100667455);
		NativeMethodInfoPtr_ToEventPtr_Public_InputEventPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionEvent>.NativeClassPtr, 100667456);
		NativeMethodInfoPtr_get_typeStatic_Public_Virtual_Final_New_get_FourCC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionEvent>.NativeClassPtr, 100667457);
		NativeMethodInfoPtr_GetEventSizeWithValueSize_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionEvent>.NativeClassPtr, 100667458);
		NativeMethodInfoPtr_From_Public_Static_ptr_ActionEvent_InputEventPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionEvent>.NativeClassPtr, 100667459);
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

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1008139, RefRangeEnd = 1008140, XrefRangeStart = 1008139, XrefRangeEnd = 1008139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetEventSizeWithValueSize(int valueSizeInBytes)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&valueSizeInBytes);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetEventSizeWithValueSize_Public_Static_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1008140, XrefRangeEnd = 1008143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ActionEvent* From(InputEventPtr ptr)
	{
		System.IntPtr* ptr2 = stackalloc System.IntPtr[1];
		*ptr2 = (nint)(&ptr);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr result = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_From_Public_Static_ptr_ActionEvent_InputEventPtr_0, (System.IntPtr)0, (void**)ptr2, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (ActionEvent*)result;
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ActionEvent>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
