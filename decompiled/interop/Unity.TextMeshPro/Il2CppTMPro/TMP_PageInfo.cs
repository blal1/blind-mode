using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppTMPro;

[StructLayout(LayoutKind.Explicit)]
public struct TMP_PageInfo
{
	private static readonly System.IntPtr NativeFieldInfoPtr_firstCharacterIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastCharacterIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_ascender;

	private static readonly System.IntPtr NativeFieldInfoPtr_baseLine;

	private static readonly System.IntPtr NativeFieldInfoPtr_descender;

	[FieldOffset(0)]
	public int firstCharacterIndex;

	[FieldOffset(4)]
	public int lastCharacterIndex;

	[FieldOffset(8)]
	public float ascender;

	[FieldOffset(12)]
	public float baseLine;

	[FieldOffset(16)]
	public float descender;

	static TMP_PageInfo()
	{
		Il2CppClassPointerStore<TMP_PageInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TMP_PageInfo");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_PageInfo>.NativeClassPtr);
		NativeFieldInfoPtr_firstCharacterIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_PageInfo>.NativeClassPtr, "firstCharacterIndex");
		NativeFieldInfoPtr_lastCharacterIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_PageInfo>.NativeClassPtr, "lastCharacterIndex");
		NativeFieldInfoPtr_ascender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_PageInfo>.NativeClassPtr, "ascender");
		NativeFieldInfoPtr_baseLine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_PageInfo>.NativeClassPtr, "baseLine");
		NativeFieldInfoPtr_descender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_PageInfo>.NativeClassPtr, "descender");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TMP_PageInfo>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
