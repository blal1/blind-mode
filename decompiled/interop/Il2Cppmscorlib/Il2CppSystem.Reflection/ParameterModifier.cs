using System;
using System.Reflection;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Reflection;

[System.Reflection.DefaultMember("Item")]
public sealed class ParameterModifier : ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr__byRef;

	public unsafe Il2CppStructArray<bool> _byRef
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__byRef);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__byRef)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static ParameterModifier()
	{
		Il2CppClassPointerStore<ParameterModifier>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "ParameterModifier");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParameterModifier>.NativeClassPtr);
		NativeFieldInfoPtr__byRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParameterModifier>.NativeClassPtr, "_byRef");
	}

	public ParameterModifier(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public ParameterModifier()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParameterModifier>.NativeClassPtr))
	{
	}
}
