using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Unity.IntegerTime;

namespace UnityEngine.InputForUI;

[StructLayout(LayoutKind.Explicit)]
public struct CommandEvent
{
	[OriginalName("UnityEngine.InputForUIModule.dll", "", "Type")]
	public enum Type
	{
		Validate = 1,
		Execute
	}

	[OriginalName("UnityEngine.InputForUIModule.dll", "", "Command")]
	public enum Command
	{
		Invalid,
		Cut,
		Copy,
		Paste,
		SelectAll,
		DeselectAll,
		InvertSelection,
		Duplicate,
		Rename,
		Delete,
		SoftDelete,
		Find,
		SelectChildren,
		SelectPrefabRoot,
		UndoRedoPerformed,
		OnLostFocus,
		NewKeyboardFocus,
		ModifierKeysChanged,
		EyeDropperUpdate,
		EyeDropperClicked,
		EyeDropperCancelled,
		ColorPickerChanged,
		FrameSelected,
		FrameSelectedWithLock
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_type;

	private static readonly System.IntPtr NativeFieldInfoPtr_command;

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

	[FieldOffset(0)]
	public Type type;

	[FieldOffset(4)]
	public Command command;

	[FieldOffset(8)]
	public DiscreteTime _timestamp_k__BackingField;

	[FieldOffset(16)]
	public EventSource _eventSource_k__BackingField;

	[FieldOffset(20)]
	public uint _playerId_k__BackingField;

	[FieldOffset(24)]
	public EventModifiers _eventModifiers_k__BackingField;

	public unsafe DiscreteTime timestamp
	{
		get
		{
			return _timestamp_k__BackingField;
		}
		[CallerCount(0)]
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
		[CachedScanResults(RefRangeStart = 50668, RefRangeEnd = 50669, XrefRangeStart = 50668, XrefRangeEnd = 50669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_eventSource_Public_Virtual_Final_New_get_EventSource_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(EventSource*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 86468, RefRangeEnd = 86476, XrefRangeStart = 86468, XrefRangeEnd = 86476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 164133, RefRangeEnd = 164138, XrefRangeStart = 164133, XrefRangeEnd = 164138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		[CachedScanResults(RefRangeStart = 54510, RefRangeEnd = 54511, XrefRangeStart = 54510, XrefRangeEnd = 54511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_eventModifiers_Public_Virtual_Final_New_get_EventModifiers_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(EventModifiers*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 155401, RefRangeEnd = 155404, XrefRangeStart = 155401, XrefRangeEnd = 155404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_eventModifiers_Public_set_Void_EventModifiers_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	static CommandEvent()
	{
		Il2CppClassPointerStore<CommandEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.InputForUIModule.dll", "UnityEngine.InputForUI", "CommandEvent");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CommandEvent>.NativeClassPtr);
		NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandEvent>.NativeClassPtr, "type");
		NativeFieldInfoPtr_command = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandEvent>.NativeClassPtr, "command");
		NativeFieldInfoPtr__timestamp_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandEvent>.NativeClassPtr, "<timestamp>k__BackingField");
		NativeFieldInfoPtr__eventSource_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandEvent>.NativeClassPtr, "<eventSource>k__BackingField");
		NativeFieldInfoPtr__playerId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandEvent>.NativeClassPtr, "<playerId>k__BackingField");
		NativeFieldInfoPtr__eventModifiers_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandEvent>.NativeClassPtr, "<eventModifiers>k__BackingField");
		NativeMethodInfoPtr_set_timestamp_Public_set_Void_DiscreteTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandEvent>.NativeClassPtr, 100663297);
		NativeMethodInfoPtr_get_eventSource_Public_Virtual_Final_New_get_EventSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandEvent>.NativeClassPtr, 100663298);
		NativeMethodInfoPtr_set_eventSource_Public_set_Void_EventSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandEvent>.NativeClassPtr, 100663299);
		NativeMethodInfoPtr_set_playerId_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandEvent>.NativeClassPtr, 100663300);
		NativeMethodInfoPtr_get_eventModifiers_Public_Virtual_Final_New_get_EventModifiers_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandEvent>.NativeClassPtr, 100663301);
		NativeMethodInfoPtr_set_eventModifiers_Public_set_Void_EventModifiers_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandEvent>.NativeClassPtr, 100663302);
		NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandEvent>.NativeClassPtr, 100663303);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1250877, XrefRangeEnd = 1250886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override string ToString()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToString_Public_Virtual_String_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CommandEvent>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
