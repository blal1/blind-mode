using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine;

[StructLayout(LayoutKind.Explicit)]
public struct UILineInfo
{
	private static readonly System.IntPtr NativeFieldInfoPtr_startCharIdx;

	private static readonly System.IntPtr NativeFieldInfoPtr_height;

	private static readonly System.IntPtr NativeFieldInfoPtr_topY;

	private static readonly System.IntPtr NativeFieldInfoPtr_leading;

	[FieldOffset(0)]
	public int startCharIdx;

	[FieldOffset(4)]
	public int height;

	[FieldOffset(8)]
	public float topY;

	[FieldOffset(12)]
	public float leading;

	static UILineInfo()
	{
		Il2CppClassPointerStore<UILineInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TextRenderingModule.dll", "UnityEngine", "UILineInfo");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UILineInfo>.NativeClassPtr);
		NativeFieldInfoPtr_startCharIdx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILineInfo>.NativeClassPtr, "startCharIdx");
		NativeFieldInfoPtr_height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILineInfo>.NativeClassPtr, "height");
		NativeFieldInfoPtr_topY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILineInfo>.NativeClassPtr, "topY");
		NativeFieldInfoPtr_leading = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UILineInfo>.NativeClassPtr, "leading");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UILineInfo>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
