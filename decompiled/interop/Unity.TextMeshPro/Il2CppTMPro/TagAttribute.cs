using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppTMPro;

[StructLayout(LayoutKind.Explicit)]
public struct TagAttribute
{
	private static readonly System.IntPtr NativeFieldInfoPtr_startIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_length;

	private static readonly System.IntPtr NativeFieldInfoPtr_hashCode;

	[FieldOffset(0)]
	public int startIndex;

	[FieldOffset(4)]
	public int length;

	[FieldOffset(8)]
	public int hashCode;

	static TagAttribute()
	{
		Il2CppClassPointerStore<TagAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TagAttribute");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TagAttribute>.NativeClassPtr);
		NativeFieldInfoPtr_startIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TagAttribute>.NativeClassPtr, "startIndex");
		NativeFieldInfoPtr_length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TagAttribute>.NativeClassPtr, "length");
		NativeFieldInfoPtr_hashCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TagAttribute>.NativeClassPtr, "hashCode");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TagAttribute>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
