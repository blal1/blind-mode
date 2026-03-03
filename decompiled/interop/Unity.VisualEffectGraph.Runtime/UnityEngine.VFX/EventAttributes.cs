using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.VFX;

[System.Serializable]
public sealed class EventAttributes : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_content;

	public unsafe Il2CppReferenceArray<EventAttribute> content
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_content);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<EventAttribute>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_content)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static EventAttributes()
	{
		Il2CppClassPointerStore<EventAttributes>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.VisualEffectGraph.Runtime.dll", "UnityEngine.VFX", "EventAttributes");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventAttributes>.NativeClassPtr);
		NativeFieldInfoPtr_content = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventAttributes>.NativeClassPtr, "content");
	}

	public EventAttributes(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public EventAttributes()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventAttributes>.NativeClassPtr))
	{
	}
}
