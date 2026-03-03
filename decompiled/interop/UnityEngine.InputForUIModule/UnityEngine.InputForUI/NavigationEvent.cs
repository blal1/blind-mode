using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Unity.IntegerTime;

namespace UnityEngine.InputForUI;

[StructLayout(LayoutKind.Explicit)]
public struct NavigationEvent
{
	[OriginalName("UnityEngine.InputForUIModule.dll", "", "Type")]
	public enum Type
	{
		Move = 1,
		Submit,
		Cancel
	}

	[OriginalName("UnityEngine.InputForUIModule.dll", "", "Direction")]
	public enum Direction
	{
		None,
		Left,
		Up,
		Right,
		Down,
		Next,
		Previous
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_type;

	private static readonly System.IntPtr NativeFieldInfoPtr_direction;

	private static readonly System.IntPtr NativeFieldInfoPtr_shouldBeUsed;

	private static readonly System.IntPtr NativeFieldInfoPtr__timestamp_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__eventSource_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__playerId_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__eventModifiers_k__BackingField;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_timestamp_Public_set_Void_DiscreteTime_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_eventSource_Public_Virtual_Final_New_get_EventSource_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_eventSource_Public_set_Void_EventSource_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_playerId_Public_set_Void_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_eventModifiers_Public_Virtual_Final_New_get_EventModifiers_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_eventModifiers_Public_set_Void_EventModifiers_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DetermineMoveDirection_Internal_Static_Direction_Vector2_Single_0;

	[FieldOffset(0)]
	public Type type;

	[FieldOffset(4)]
	public Direction direction;

	[FieldOffset(8)]
	[MarshalAs(UnmanagedType.U1)]
	public bool shouldBeUsed;

	[FieldOffset(16)]
	public DiscreteTime _timestamp_k__BackingField;

	[FieldOffset(24)]
	public EventSource _eventSource_k__BackingField;

	[FieldOffset(28)]
	public uint _playerId_k__BackingField;

	[FieldOffset(32)]
	public EventModifiers _eventModifiers_k__BackingField;

	public unsafe DiscreteTime timestamp
	{
		get
		{
			return _timestamp_k__BackingField;
		}
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 327424, RefRangeEnd = 327426, XrefRangeStart = 327424, XrefRangeEnd = 327426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_timestamp_Public_set_Void_DiscreteTime_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe virtual EventSource eventSource
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 54510, RefRangeEnd = 54511, XrefRangeStart = 54510, XrefRangeEnd = 54511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_eventSource_Public_Virtual_Final_New_get_EventSource_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(EventSource*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 155401, RefRangeEnd = 155404, XrefRangeStart = 155401, XrefRangeEnd = 155404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_eventSource_Public_set_Void_EventSource_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe uint playerId
	{
		get
		{
			return _playerId_k__BackingField;
		}
		[CallerCount(0)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_playerId_Public_set_Void_UInt32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe virtual EventModifiers eventModifiers
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 63233, RefRangeEnd = 63234, XrefRangeStart = 63233, XrefRangeEnd = 63234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_eventModifiers_Public_Virtual_Final_New_get_EventModifiers_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(EventModifiers*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 102244, RefRangeEnd = 102245, XrefRangeStart = 102244, XrefRangeEnd = 102245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_eventModifiers_Public_set_Void_EventModifiers_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	static NavigationEvent()
	{
		Il2CppClassPointerStore<NavigationEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.InputForUIModule.dll", "UnityEngine.InputForUI", "NavigationEvent");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NavigationEvent>.NativeClassPtr);
		NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationEvent>.NativeClassPtr, "type");
		NativeFieldInfoPtr_direction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationEvent>.NativeClassPtr, "direction");
		NativeFieldInfoPtr_shouldBeUsed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationEvent>.NativeClassPtr, "shouldBeUsed");
		NativeFieldInfoPtr__timestamp_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationEvent>.NativeClassPtr, "<timestamp>k__BackingField");
		NativeFieldInfoPtr__eventSource_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationEvent>.NativeClassPtr, "<eventSource>k__BackingField");
		NativeFieldInfoPtr__playerId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationEvent>.NativeClassPtr, "<playerId>k__BackingField");
		NativeFieldInfoPtr__eventModifiers_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationEvent>.NativeClassPtr, "<eventModifiers>k__BackingField");
		NativeMethodInfoPtr_set_timestamp_Public_set_Void_DiscreteTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationEvent>.NativeClassPtr, 100663375);
		NativeMethodInfoPtr_get_eventSource_Public_Virtual_Final_New_get_EventSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationEvent>.NativeClassPtr, 100663376);
		NativeMethodInfoPtr_set_eventSource_Public_set_Void_EventSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationEvent>.NativeClassPtr, 100663377);
		NativeMethodInfoPtr_set_playerId_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationEvent>.NativeClassPtr, 100663378);
		NativeMethodInfoPtr_get_eventModifiers_Public_Virtual_Final_New_get_EventModifiers_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationEvent>.NativeClassPtr, 100663379);
		NativeMethodInfoPtr_set_eventModifiers_Public_set_Void_EventModifiers_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationEvent>.NativeClassPtr, 100663380);
		NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationEvent>.NativeClassPtr, 100663381);
		NativeMethodInfoPtr_DetermineMoveDirection_Internal_Static_Direction_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationEvent>.NativeClassPtr, 100663382);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1251178, XrefRangeEnd = 1251200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override string ToString()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToString_Public_Virtual_String_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1251200, RefRangeEnd = 1251201, XrefRangeStart = 1251200, XrefRangeEnd = 1251200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Direction DetermineMoveDirection(Vector2 vec, float deadZone = 0.6f)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&vec);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &deadZone;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DetermineMoveDirection_Internal_Static_Direction_Vector2_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Direction*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NavigationEvent>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
