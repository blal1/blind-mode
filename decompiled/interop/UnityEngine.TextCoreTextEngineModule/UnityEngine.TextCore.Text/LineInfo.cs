using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.TextCore.Text;

[StructLayout(LayoutKind.Explicit)]
public struct LineInfo
{
	private static readonly System.IntPtr NativeFieldInfoPtr_controlCharacterCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_characterCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_visibleCharacterCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_visibleSpaceCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_spaceCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_wordCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_firstCharacterIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_firstVisibleCharacterIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastCharacterIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastVisibleCharacterIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_length;

	private static readonly System.IntPtr NativeFieldInfoPtr_lineHeight;

	private static readonly System.IntPtr NativeFieldInfoPtr_ascender;

	private static readonly System.IntPtr NativeFieldInfoPtr_baseline;

	private static readonly System.IntPtr NativeFieldInfoPtr_descender;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxAdvance;

	private static readonly System.IntPtr NativeFieldInfoPtr_width;

	private static readonly System.IntPtr NativeFieldInfoPtr_marginLeft;

	private static readonly System.IntPtr NativeFieldInfoPtr_marginRight;

	private static readonly System.IntPtr NativeFieldInfoPtr_alignment;

	private static readonly System.IntPtr NativeFieldInfoPtr_lineExtents;

	[FieldOffset(0)]
	public int controlCharacterCount;

	[FieldOffset(4)]
	public int characterCount;

	[FieldOffset(8)]
	public int visibleCharacterCount;

	[FieldOffset(12)]
	public int visibleSpaceCount;

	[FieldOffset(16)]
	public int spaceCount;

	[FieldOffset(20)]
	public int wordCount;

	[FieldOffset(24)]
	public int firstCharacterIndex;

	[FieldOffset(28)]
	public int firstVisibleCharacterIndex;

	[FieldOffset(32)]
	public int lastCharacterIndex;

	[FieldOffset(36)]
	public int lastVisibleCharacterIndex;

	[FieldOffset(40)]
	public float length;

	[FieldOffset(44)]
	public float lineHeight;

	[FieldOffset(48)]
	public float ascender;

	[FieldOffset(52)]
	public float baseline;

	[FieldOffset(56)]
	public float descender;

	[FieldOffset(60)]
	public float maxAdvance;

	[FieldOffset(64)]
	public float width;

	[FieldOffset(68)]
	public float marginLeft;

	[FieldOffset(72)]
	public float marginRight;

	[FieldOffset(76)]
	public TextAlignment alignment;

	[FieldOffset(80)]
	public Extents lineExtents;

	static LineInfo()
	{
		Il2CppClassPointerStore<LineInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TextCoreTextEngineModule.dll", "UnityEngine.TextCore.Text", "LineInfo");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LineInfo>.NativeClassPtr);
		NativeFieldInfoPtr_controlCharacterCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LineInfo>.NativeClassPtr, "controlCharacterCount");
		NativeFieldInfoPtr_characterCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LineInfo>.NativeClassPtr, "characterCount");
		NativeFieldInfoPtr_visibleCharacterCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LineInfo>.NativeClassPtr, "visibleCharacterCount");
		NativeFieldInfoPtr_visibleSpaceCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LineInfo>.NativeClassPtr, "visibleSpaceCount");
		NativeFieldInfoPtr_spaceCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LineInfo>.NativeClassPtr, "spaceCount");
		NativeFieldInfoPtr_wordCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LineInfo>.NativeClassPtr, "wordCount");
		NativeFieldInfoPtr_firstCharacterIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LineInfo>.NativeClassPtr, "firstCharacterIndex");
		NativeFieldInfoPtr_firstVisibleCharacterIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LineInfo>.NativeClassPtr, "firstVisibleCharacterIndex");
		NativeFieldInfoPtr_lastCharacterIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LineInfo>.NativeClassPtr, "lastCharacterIndex");
		NativeFieldInfoPtr_lastVisibleCharacterIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LineInfo>.NativeClassPtr, "lastVisibleCharacterIndex");
		NativeFieldInfoPtr_length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LineInfo>.NativeClassPtr, "length");
		NativeFieldInfoPtr_lineHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LineInfo>.NativeClassPtr, "lineHeight");
		NativeFieldInfoPtr_ascender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LineInfo>.NativeClassPtr, "ascender");
		NativeFieldInfoPtr_baseline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LineInfo>.NativeClassPtr, "baseline");
		NativeFieldInfoPtr_descender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LineInfo>.NativeClassPtr, "descender");
		NativeFieldInfoPtr_maxAdvance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LineInfo>.NativeClassPtr, "maxAdvance");
		NativeFieldInfoPtr_width = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LineInfo>.NativeClassPtr, "width");
		NativeFieldInfoPtr_marginLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LineInfo>.NativeClassPtr, "marginLeft");
		NativeFieldInfoPtr_marginRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LineInfo>.NativeClassPtr, "marginRight");
		NativeFieldInfoPtr_alignment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LineInfo>.NativeClassPtr, "alignment");
		NativeFieldInfoPtr_lineExtents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LineInfo>.NativeClassPtr, "lineExtents");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LineInfo>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
