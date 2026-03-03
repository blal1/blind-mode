using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine;

[StructLayout(LayoutKind.Explicit)]
public struct UICharInfo
{
	private static readonly System.IntPtr NativeFieldInfoPtr_cursorPos;

	private static readonly System.IntPtr NativeFieldInfoPtr_charWidth;

	[FieldOffset(0)]
	public Vector2 cursorPos;

	[FieldOffset(8)]
	public float charWidth;

	static UICharInfo()
	{
		Il2CppClassPointerStore<UICharInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TextRenderingModule.dll", "UnityEngine", "UICharInfo");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UICharInfo>.NativeClassPtr);
		NativeFieldInfoPtr_cursorPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UICharInfo>.NativeClassPtr, "cursorPos");
		NativeFieldInfoPtr_charWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UICharInfo>.NativeClassPtr, "charWidth");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UICharInfo>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
