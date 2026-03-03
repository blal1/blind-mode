using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppTMPro;

[StructLayout(LayoutKind.Explicit)]
public struct RichTextTagAttribute
{
	private static readonly System.IntPtr NativeFieldInfoPtr_nameHashCode;

	private static readonly System.IntPtr NativeFieldInfoPtr_valueHashCode;

	private static readonly System.IntPtr NativeFieldInfoPtr_valueType;

	private static readonly System.IntPtr NativeFieldInfoPtr_valueStartIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_valueLength;

	private static readonly System.IntPtr NativeFieldInfoPtr_unitType;

	[FieldOffset(0)]
	public int nameHashCode;

	[FieldOffset(4)]
	public int valueHashCode;

	[FieldOffset(8)]
	public TagValueType valueType;

	[FieldOffset(12)]
	public int valueStartIndex;

	[FieldOffset(16)]
	public int valueLength;

	[FieldOffset(20)]
	public TagUnitType unitType;

	static RichTextTagAttribute()
	{
		Il2CppClassPointerStore<RichTextTagAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "RichTextTagAttribute");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RichTextTagAttribute>.NativeClassPtr);
		NativeFieldInfoPtr_nameHashCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RichTextTagAttribute>.NativeClassPtr, "nameHashCode");
		NativeFieldInfoPtr_valueHashCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RichTextTagAttribute>.NativeClassPtr, "valueHashCode");
		NativeFieldInfoPtr_valueType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RichTextTagAttribute>.NativeClassPtr, "valueType");
		NativeFieldInfoPtr_valueStartIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RichTextTagAttribute>.NativeClassPtr, "valueStartIndex");
		NativeFieldInfoPtr_valueLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RichTextTagAttribute>.NativeClassPtr, "valueLength");
		NativeFieldInfoPtr_unitType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RichTextTagAttribute>.NativeClassPtr, "unitType");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RichTextTagAttribute>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
