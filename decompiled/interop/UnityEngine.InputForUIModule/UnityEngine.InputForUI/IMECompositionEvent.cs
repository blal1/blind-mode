using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using Unity.IntegerTime;

namespace UnityEngine.InputForUI;

public sealed class IMECompositionEvent : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_compositionString;

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

	public unsafe string compositionString
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_compositionString);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_compositionString)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe DiscreteTime _timestamp_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__timestamp_k__BackingField);
			return *(DiscreteTime*)num;
		}
		set
		{
			*(DiscreteTime*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__timestamp_k__BackingField)) = value;
		}
	}

	public unsafe EventSource _eventSource_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__eventSource_k__BackingField);
			return *(EventSource*)num;
		}
		set
		{
			*(EventSource*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__eventSource_k__BackingField)) = value;
		}
	}

	public unsafe uint _playerId_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__playerId_k__BackingField);
			return *(uint*)num;
		}
		set
		{
			*(uint*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__playerId_k__BackingField)) = value;
		}
	}

	public unsafe EventModifiers _eventModifiers_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__eventModifiers_k__BackingField);
			return *(EventModifiers*)num;
		}
		set
		{
			*(EventModifiers*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__eventModifiers_k__BackingField)) = value;
		}
	}

	public unsafe DiscreteTime timestamp
	{
		get
		{
			return _timestamp_k__BackingField;
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_timestamp_Public_set_Void_DiscreteTime_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe virtual EventSource eventSource
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 50668, RefRangeEnd = 50669, XrefRangeStart = 50668, XrefRangeEnd = 50669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_eventSource_Public_Virtual_Final_New_get_EventSource_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(EventSource*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 86468, RefRangeEnd = 86476, XrefRangeStart = 86468, XrefRangeEnd = 86476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_eventSource_Public_set_Void_EventSource_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
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
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_playerId_Public_set_Void_UInt32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe virtual EventModifiers eventModifiers
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 54510, RefRangeEnd = 54511, XrefRangeStart = 54510, XrefRangeEnd = 54511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_eventModifiers_Public_Virtual_Final_New_get_EventModifiers_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(EventModifiers*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 155401, RefRangeEnd = 155404, XrefRangeStart = 155401, XrefRangeEnd = 155404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_eventModifiers_Public_set_Void_EventModifiers_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	static IMECompositionEvent()
	{
		Il2CppClassPointerStore<IMECompositionEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.InputForUIModule.dll", "UnityEngine.InputForUI", "IMECompositionEvent");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IMECompositionEvent>.NativeClassPtr);
		NativeFieldInfoPtr_compositionString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IMECompositionEvent>.NativeClassPtr, "compositionString");
		NativeFieldInfoPtr__timestamp_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IMECompositionEvent>.NativeClassPtr, "<timestamp>k__BackingField");
		NativeFieldInfoPtr__eventSource_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IMECompositionEvent>.NativeClassPtr, "<eventSource>k__BackingField");
		NativeFieldInfoPtr__playerId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IMECompositionEvent>.NativeClassPtr, "<playerId>k__BackingField");
		NativeFieldInfoPtr__eventModifiers_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IMECompositionEvent>.NativeClassPtr, "<eventModifiers>k__BackingField");
		NativeMethodInfoPtr_set_timestamp_Public_set_Void_DiscreteTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMECompositionEvent>.NativeClassPtr, 100663344);
		NativeMethodInfoPtr_get_eventSource_Public_Virtual_Final_New_get_EventSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMECompositionEvent>.NativeClassPtr, 100663345);
		NativeMethodInfoPtr_set_eventSource_Public_set_Void_EventSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMECompositionEvent>.NativeClassPtr, 100663346);
		NativeMethodInfoPtr_set_playerId_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMECompositionEvent>.NativeClassPtr, 100663347);
		NativeMethodInfoPtr_get_eventModifiers_Public_Virtual_Final_New_get_EventModifiers_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMECompositionEvent>.NativeClassPtr, 100663348);
		NativeMethodInfoPtr_set_eventModifiers_Public_set_Void_EventModifiers_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMECompositionEvent>.NativeClassPtr, 100663349);
		NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IMECompositionEvent>.NativeClassPtr, 100663350);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1251128, XrefRangeEnd = 1251133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override string ToString()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	public IMECompositionEvent(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public IMECompositionEvent()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IMECompositionEvent>.NativeClassPtr))
	{
	}
}
