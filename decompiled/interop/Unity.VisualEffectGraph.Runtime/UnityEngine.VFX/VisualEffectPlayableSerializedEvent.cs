using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.VFX.Utility;

namespace UnityEngine.VFX;

[System.Serializable]
public sealed class VisualEffectPlayableSerializedEvent : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_editorColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_time;

	private static readonly System.IntPtr NativeFieldInfoPtr_timeSpace;

	private static readonly System.IntPtr NativeFieldInfoPtr_name;

	private static readonly System.IntPtr NativeFieldInfoPtr_eventAttributes;

	public unsafe Color editorColor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_editorColor);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_editorColor)) = value;
		}
	}

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

	static VisualEffectPlayableSerializedEvent()
	{
		Il2CppClassPointerStore<VisualEffectPlayableSerializedEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.VisualEffectGraph.Runtime.dll", "UnityEngine.VFX", "VisualEffectPlayableSerializedEvent");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VisualEffectPlayableSerializedEvent>.NativeClassPtr);
		NativeFieldInfoPtr_editorColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualEffectPlayableSerializedEvent>.NativeClassPtr, "editorColor");
		NativeFieldInfoPtr_time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualEffectPlayableSerializedEvent>.NativeClassPtr, "time");
		NativeFieldInfoPtr_timeSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualEffectPlayableSerializedEvent>.NativeClassPtr, "timeSpace");
		NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualEffectPlayableSerializedEvent>.NativeClassPtr, "name");
		NativeFieldInfoPtr_eventAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualEffectPlayableSerializedEvent>.NativeClassPtr, "eventAttributes");
	}

	public VisualEffectPlayableSerializedEvent(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public VisualEffectPlayableSerializedEvent()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VisualEffectPlayableSerializedEvent>.NativeClassPtr))
	{
	}
}
