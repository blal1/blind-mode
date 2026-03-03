using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.TextCore.Text;

namespace UnityEngine.TextCore;

[StructLayout(LayoutKind.Explicit)]
public struct TextSpan
{
	private static readonly System.IntPtr NativeFieldInfoPtr_startIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_length;

	private static readonly System.IntPtr NativeFieldInfoPtr_fontAsset;

	private static readonly System.IntPtr NativeFieldInfoPtr_fontSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_color;

	private static readonly System.IntPtr NativeFieldInfoPtr_fontStyle;

	private static readonly System.IntPtr NativeFieldInfoPtr_fontWeight;

	private static readonly System.IntPtr NativeFieldInfoPtr_linkID;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

	[FieldOffset(0)]
	public int startIndex;

	[FieldOffset(4)]
	public int length;

	[FieldOffset(8)]
	public System.IntPtr fontAsset;

	[FieldOffset(16)]
	public int fontSize;

	[FieldOffset(20)]
	public Color32 color;

	[FieldOffset(24)]
	public FontStyles fontStyle;

	[FieldOffset(28)]
	public TextFontWeight fontWeight;

	[FieldOffset(32)]
	public int linkID;

	static TextSpan()
	{
		Il2CppClassPointerStore<TextSpan>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TextCoreTextEngineModule.dll", "UnityEngine.TextCore", "TextSpan");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextSpan>.NativeClassPtr);
		NativeFieldInfoPtr_startIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextSpan>.NativeClassPtr, "startIndex");
		NativeFieldInfoPtr_length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextSpan>.NativeClassPtr, "length");
		NativeFieldInfoPtr_fontAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextSpan>.NativeClassPtr, "fontAsset");
		NativeFieldInfoPtr_fontSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextSpan>.NativeClassPtr, "fontSize");
		NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextSpan>.NativeClassPtr, "color");
		NativeFieldInfoPtr_fontStyle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextSpan>.NativeClassPtr, "fontStyle");
		NativeFieldInfoPtr_fontWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextSpan>.NativeClassPtr, "fontWeight");
		NativeFieldInfoPtr_linkID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextSpan>.NativeClassPtr, "linkID");
		NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextSpan>.NativeClassPtr, 100663308);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1273964, RefRangeEnd = 1273965, XrefRangeStart = 1273899, XrefRangeEnd = 1273964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override string ToString()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToString_Public_Virtual_String_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TextSpan>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
