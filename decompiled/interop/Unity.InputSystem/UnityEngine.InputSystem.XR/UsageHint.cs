using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace UnityEngine.InputSystem.XR;

[System.Serializable]
public sealed class UsageHint : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_content;

	public unsafe string content
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_content);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_content)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	static UsageHint()
	{
		Il2CppClassPointerStore<UsageHint>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.InputSystem.dll", "UnityEngine.InputSystem.XR", "UsageHint");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UsageHint>.NativeClassPtr);
		NativeFieldInfoPtr_content = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UsageHint>.NativeClassPtr, "content");
	}

	public UsageHint(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public UsageHint()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UsageHint>.NativeClassPtr))
	{
	}
}
