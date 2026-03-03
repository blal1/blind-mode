using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppTMPro;

[StructLayout(LayoutKind.Explicit)]
public struct TMP_SpriteInfo
{
	private static readonly System.IntPtr NativeFieldInfoPtr_spriteIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_characterIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_vertexIndex;

	[FieldOffset(0)]
	public int spriteIndex;

	[FieldOffset(4)]
	public int characterIndex;

	[FieldOffset(8)]
	public int vertexIndex;

	static TMP_SpriteInfo()
	{
		Il2CppClassPointerStore<TMP_SpriteInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TMP_SpriteInfo");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_SpriteInfo>.NativeClassPtr);
		NativeFieldInfoPtr_spriteIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SpriteInfo>.NativeClassPtr, "spriteIndex");
		NativeFieldInfoPtr_characterIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SpriteInfo>.NativeClassPtr, "characterIndex");
		NativeFieldInfoPtr_vertexIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_SpriteInfo>.NativeClassPtr, "vertexIndex");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TMP_SpriteInfo>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
