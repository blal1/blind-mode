using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppSpine;

public class InheritEnum : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_Values;

	public unsafe static Il2CppStructArray<Inherit> Values
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Values, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Inherit>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Values, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static InheritEnum()
	{
		Il2CppClassPointerStore<InheritEnum>.NativeClassPtr = IL2CPP.GetIl2CppClass("spine-csharp.dll", "Spine", "InheritEnum");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InheritEnum>.NativeClassPtr);
		NativeFieldInfoPtr_Values = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InheritEnum>.NativeClassPtr, "Values");
	}

	public InheritEnum(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
