using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.TextCore.Text;

[StructLayout(LayoutKind.Explicit)]
public struct WordInfo
{
	private static readonly System.IntPtr NativeFieldInfoPtr_firstCharacterIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastCharacterIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_characterCount;

	[FieldOffset(0)]
	public int firstCharacterIndex;

	[FieldOffset(4)]
	public int lastCharacterIndex;

	[FieldOffset(8)]
	public int characterCount;

	static WordInfo()
	{
		Il2CppClassPointerStore<WordInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TextCoreTextEngineModule.dll", "UnityEngine.TextCore.Text", "WordInfo");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WordInfo>.NativeClassPtr);
		NativeFieldInfoPtr_firstCharacterIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordInfo>.NativeClassPtr, "firstCharacterIndex");
		NativeFieldInfoPtr_lastCharacterIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordInfo>.NativeClassPtr, "lastCharacterIndex");
		NativeFieldInfoPtr_characterCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WordInfo>.NativeClassPtr, "characterCount");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WordInfo>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
