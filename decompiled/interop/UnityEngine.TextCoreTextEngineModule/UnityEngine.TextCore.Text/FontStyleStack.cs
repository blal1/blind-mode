using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.TextCore.Text;

[StructLayout(LayoutKind.Explicit)]
public struct FontStyleStack
{
	private static readonly System.IntPtr NativeFieldInfoPtr_bold;

	private static readonly System.IntPtr NativeFieldInfoPtr_italic;

	private static readonly System.IntPtr NativeFieldInfoPtr_underline;

	private static readonly System.IntPtr NativeFieldInfoPtr_strikethrough;

	private static readonly System.IntPtr NativeFieldInfoPtr_highlight;

	private static readonly System.IntPtr NativeFieldInfoPtr_superscript;

	private static readonly System.IntPtr NativeFieldInfoPtr_subscript;

	private static readonly System.IntPtr NativeFieldInfoPtr_uppercase;

	private static readonly System.IntPtr NativeFieldInfoPtr_lowercase;

	private static readonly System.IntPtr NativeFieldInfoPtr_smallcaps;

	private static readonly System.IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Add_Public_Byte_FontStyles_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Remove_Public_Byte_FontStyles_0;

	[FieldOffset(0)]
	public byte bold;

	[FieldOffset(1)]
	public byte italic;

	[FieldOffset(2)]
	public byte underline;

	[FieldOffset(3)]
	public byte strikethrough;

	[FieldOffset(4)]
	public byte highlight;

	[FieldOffset(5)]
	public byte superscript;

	[FieldOffset(6)]
	public byte subscript;

	[FieldOffset(7)]
	public byte uppercase;

	[FieldOffset(8)]
	public byte lowercase;

	[FieldOffset(9)]
	public byte smallcaps;

	static FontStyleStack()
	{
		Il2CppClassPointerStore<FontStyleStack>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TextCoreTextEngineModule.dll", "UnityEngine.TextCore.Text", "FontStyleStack");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FontStyleStack>.NativeClassPtr);
		NativeFieldInfoPtr_bold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontStyleStack>.NativeClassPtr, "bold");
		NativeFieldInfoPtr_italic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontStyleStack>.NativeClassPtr, "italic");
		NativeFieldInfoPtr_underline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontStyleStack>.NativeClassPtr, "underline");
		NativeFieldInfoPtr_strikethrough = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontStyleStack>.NativeClassPtr, "strikethrough");
		NativeFieldInfoPtr_highlight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontStyleStack>.NativeClassPtr, "highlight");
		NativeFieldInfoPtr_superscript = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontStyleStack>.NativeClassPtr, "superscript");
		NativeFieldInfoPtr_subscript = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontStyleStack>.NativeClassPtr, "subscript");
		NativeFieldInfoPtr_uppercase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontStyleStack>.NativeClassPtr, "uppercase");
		NativeFieldInfoPtr_lowercase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontStyleStack>.NativeClassPtr, "lowercase");
		NativeFieldInfoPtr_smallcaps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontStyleStack>.NativeClassPtr, "smallcaps");
		NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontStyleStack>.NativeClassPtr, 100664015);
		NativeMethodInfoPtr_Add_Public_Byte_FontStyles_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontStyleStack>.NativeClassPtr, 100664016);
		NativeMethodInfoPtr_Remove_Public_Byte_FontStyles_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontStyleStack>.NativeClassPtr, 100664017);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 1134027, RefRangeEnd = 1134035, XrefRangeStart = 1134027, XrefRangeEnd = 1134035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Clear()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Clear_Public_Void_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe byte Add(FontStyles style)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&style);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Add_Public_Byte_FontStyles_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(byte*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1134035, RefRangeEnd = 1134036, XrefRangeStart = 1134035, XrefRangeEnd = 1134036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe byte Remove(FontStyles style)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&style);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Remove_Public_Byte_FontStyles_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(byte*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FontStyleStack>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
