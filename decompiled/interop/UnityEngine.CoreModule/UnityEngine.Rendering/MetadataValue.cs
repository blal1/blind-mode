using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct MetadataValue
{
	private static readonly System.IntPtr NativeFieldInfoPtr_NameID;

	private static readonly System.IntPtr NativeFieldInfoPtr_Value;

	[FieldOffset(0)]
	public int NameID;

	[FieldOffset(4)]
	public uint Value;

	static MetadataValue()
	{
		Il2CppClassPointerStore<MetadataValue>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "MetadataValue");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MetadataValue>.NativeClassPtr);
		NativeFieldInfoPtr_NameID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MetadataValue>.NativeClassPtr, "NameID");
		NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MetadataValue>.NativeClassPtr, "Value");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MetadataValue>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
