using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.VFX.Utility;

namespace UnityEngine.VFX;

[System.Serializable]
public sealed class VisualEffectPlayableSerializedEventNoColor : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_time;

	private static readonly System.IntPtr NativeFieldInfoPtr_timeSpace;

	private static readonly System.IntPtr NativeFieldInfoPtr_name;

	private static readonly System.IntPtr NativeFieldInfoPtr_eventAttributes;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_VisualEffectPlayableSerializedEvent_VisualEffectPlayableSerializedEventNoColor_0;

	public unsafe double time
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_time);
			return *(double*)num;
		}
		set
		{
			*(double*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_time)) = value;
		}
	}

	public unsafe PlayableTimeSpace timeSpace
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeSpace);
			return *(PlayableTimeSpace*)num;
		}
		set
		{
			*(PlayableTimeSpace*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeSpace)) = value;
		}
	}

	public unsafe ExposedProperty name
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_name);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ExposedProperty>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_name)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe EventAttributes eventAttributes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_eventAttributes);
			return new EventAttributes(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EventAttributes>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_eventAttributes), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<EventAttributes>.NativeClassPtr, ref *(uint*)null));
		}
	}

	static VisualEffectPlayableSerializedEventNoColor()
	{
		Il2CppClassPointerStore<VisualEffectPlayableSerializedEventNoColor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.VisualEffectGraph.Runtime.dll", "UnityEngine.VFX", "VisualEffectPlayableSerializedEventNoColor");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VisualEffectPlayableSerializedEventNoColor>.NativeClassPtr);
		NativeFieldInfoPtr_time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualEffectPlayableSerializedEventNoColor>.NativeClassPtr, "time");
		NativeFieldInfoPtr_timeSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualEffectPlayableSerializedEventNoColor>.NativeClassPtr, "timeSpace");
		NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualEffectPlayableSerializedEventNoColor>.NativeClassPtr, "name");
		NativeFieldInfoPtr_eventAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualEffectPlayableSerializedEventNoColor>.NativeClassPtr, "eventAttributes");
		NativeMethodInfoPtr_op_Implicit_Public_Static_VisualEffectPlayableSerializedEvent_VisualEffectPlayableSerializedEventNoColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualEffectPlayableSerializedEventNoColor>.NativeClassPtr, 100663402);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1143473, XrefRangeEnd = 1143475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static implicit operator VisualEffectPlayableSerializedEvent(VisualEffectPlayableSerializedEventNoColor evt)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)evt));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Implicit_Public_Static_VisualEffectPlayableSerializedEvent_VisualEffectPlayableSerializedEventNoColor_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new VisualEffectPlayableSerializedEvent(pointer);
	}

	public VisualEffectPlayableSerializedEventNoColor(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public VisualEffectPlayableSerializedEventNoColor()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VisualEffectPlayableSerializedEventNoColor>.NativeClassPtr))
	{
	}
}
