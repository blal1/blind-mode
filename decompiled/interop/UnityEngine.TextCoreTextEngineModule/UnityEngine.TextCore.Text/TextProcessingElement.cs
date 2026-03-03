using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.TextCore.Text;

[StructLayout(LayoutKind.Explicit)]
public struct TextProcessingElement
{
	private static readonly System.IntPtr NativeFieldInfoPtr_elementType;

	private static readonly System.IntPtr NativeFieldInfoPtr_unicode;

	private static readonly System.IntPtr NativeFieldInfoPtr_stringIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_length;

	[FieldOffset(0)]
	public TextProcessingElementType elementType;

	[FieldOffset(4)]
	public uint unicode;

	[FieldOffset(8)]
	public int stringIndex;

	[FieldOffset(12)]
	public int length;

	static TextProcessingElement()
	{
		Il2CppClassPointerStore<TextProcessingElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TextCoreTextEngineModule.dll", "UnityEngine.TextCore.Text", "TextProcessingElement");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextProcessingElement>.NativeClassPtr);
		NativeFieldInfoPtr_elementType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextProcessingElement>.NativeClassPtr, "elementType");
		NativeFieldInfoPtr_unicode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextProcessingElement>.NativeClassPtr, "unicode");
		NativeFieldInfoPtr_stringIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextProcessingElement>.NativeClassPtr, "stringIndex");
		NativeFieldInfoPtr_length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextProcessingElement>.NativeClassPtr, "length");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TextProcessingElement>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
