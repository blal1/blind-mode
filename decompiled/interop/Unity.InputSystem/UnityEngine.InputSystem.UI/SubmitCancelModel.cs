using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.EventSystems;

namespace UnityEngine.InputSystem.UI;

public sealed class SubmitCancelModel : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_eventData;

	private static readonly System.IntPtr NativeFieldInfoPtr_device;

	public unsafe BaseEventData eventData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_eventData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<BaseEventData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_eventData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe InputDevice device
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_device);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InputDevice>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_device)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static SubmitCancelModel()
	{
		Il2CppClassPointerStore<SubmitCancelModel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.InputSystem.dll", "UnityEngine.InputSystem.UI", "SubmitCancelModel");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SubmitCancelModel>.NativeClassPtr);
		NativeFieldInfoPtr_eventData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubmitCancelModel>.NativeClassPtr, "eventData");
		NativeFieldInfoPtr_device = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubmitCancelModel>.NativeClassPtr, "device");
	}

	public SubmitCancelModel(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public SubmitCancelModel()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SubmitCancelModel>.NativeClassPtr))
	{
	}
}
