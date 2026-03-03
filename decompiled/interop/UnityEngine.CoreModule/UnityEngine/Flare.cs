using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine;

public sealed class Flare : Object
{
	private delegate void Internal_CreateDelegate(IntPtr self);

	private static readonly Internal_CreateDelegate Internal_CreateDelegateField;

	static Flare()
	{
		Il2CppClassPointerStore<Flare>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Flare");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Flare>.NativeClassPtr);
		Internal_CreateDelegateField = IL2CPP.ResolveICall<Internal_CreateDelegate>("UnityEngine.Flare::Internal_Create");
	}

	public Flare(IntPtr pointer)
		: base(pointer)
	{
	}

	public static void Internal_Create(Flare self)
	{
		Internal_CreateDelegateField(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)self));
	}
}
