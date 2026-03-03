using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.TextCore.Text;

[StructLayout(LayoutKind.Explicit)]
public struct TextCoreVertex
{
	private static readonly System.IntPtr NativeFieldInfoPtr_position;

	private static readonly System.IntPtr NativeFieldInfoPtr_color;

	private static readonly System.IntPtr NativeFieldInfoPtr_uv0;

	private static readonly System.IntPtr NativeFieldInfoPtr_uv2;

	[FieldOffset(0)]
	public Vector3 position;

	[FieldOffset(12)]
	public Color32 color;

	[FieldOffset(16)]
	public Vector2 uv0;

	[FieldOffset(24)]
	public Vector2 uv2;

	static TextCoreVertex()
	{
		Il2CppClassPointerStore<TextCoreVertex>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TextCoreTextEngineModule.dll", "UnityEngine.TextCore.Text", "TextCoreVertex");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextCoreVertex>.NativeClassPtr);
		NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextCoreVertex>.NativeClassPtr, "position");
		NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextCoreVertex>.NativeClassPtr, "color");
		NativeFieldInfoPtr_uv0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextCoreVertex>.NativeClassPtr, "uv0");
		NativeFieldInfoPtr_uv2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextCoreVertex>.NativeClassPtr, "uv2");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TextCoreVertex>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
