using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.TextCore.Text;

[StructLayout(LayoutKind.Explicit)]
public struct NativeTextElementInfo
{
	private static readonly System.IntPtr NativeFieldInfoPtr_glyphID;

	private static readonly System.IntPtr NativeFieldInfoPtr_bottomLeft;

	private static readonly System.IntPtr NativeFieldInfoPtr_topLeft;

	private static readonly System.IntPtr NativeFieldInfoPtr_topRight;

	private static readonly System.IntPtr NativeFieldInfoPtr_bottomRight;

	[FieldOffset(0)]
	public int glyphID;

	[FieldOffset(4)]
	public TextCoreVertex bottomLeft;

	[FieldOffset(36)]
	public TextCoreVertex topLeft;

	[FieldOffset(68)]
	public TextCoreVertex topRight;

	[FieldOffset(100)]
	public TextCoreVertex bottomRight;

	static NativeTextElementInfo()
	{
		Il2CppClassPointerStore<NativeTextElementInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TextCoreTextEngineModule.dll", "UnityEngine.TextCore.Text", "NativeTextElementInfo");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeTextElementInfo>.NativeClassPtr);
		NativeFieldInfoPtr_glyphID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeTextElementInfo>.NativeClassPtr, "glyphID");
		NativeFieldInfoPtr_bottomLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeTextElementInfo>.NativeClassPtr, "bottomLeft");
		NativeFieldInfoPtr_topLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeTextElementInfo>.NativeClassPtr, "topLeft");
		NativeFieldInfoPtr_topRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeTextElementInfo>.NativeClassPtr, "topRight");
		NativeFieldInfoPtr_bottomRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeTextElementInfo>.NativeClassPtr, "bottomRight");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeTextElementInfo>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
