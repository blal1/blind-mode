using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.TextCore.LowLevel;

[StructLayout(LayoutKind.Explicit)]
public struct GlyphMarshallingStruct
{
	private static readonly System.IntPtr NativeFieldInfoPtr_index;

	private static readonly System.IntPtr NativeFieldInfoPtr_metrics;

	private static readonly System.IntPtr NativeFieldInfoPtr_glyphRect;

	private static readonly System.IntPtr NativeFieldInfoPtr_scale;

	private static readonly System.IntPtr NativeFieldInfoPtr_atlasIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_classDefinitionType;

	[FieldOffset(0)]
	public uint index;

	[FieldOffset(4)]
	public GlyphMetrics metrics;

	[FieldOffset(24)]
	public GlyphRect glyphRect;

	[FieldOffset(40)]
	public float scale;

	[FieldOffset(44)]
	public int atlasIndex;

	[FieldOffset(48)]
	public GlyphClassDefinitionType classDefinitionType;

	static GlyphMarshallingStruct()
	{
		Il2CppClassPointerStore<GlyphMarshallingStruct>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TextCoreFontEngineModule.dll", "UnityEngine.TextCore.LowLevel", "GlyphMarshallingStruct");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GlyphMarshallingStruct>.NativeClassPtr);
		NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlyphMarshallingStruct>.NativeClassPtr, "index");
		NativeFieldInfoPtr_metrics = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlyphMarshallingStruct>.NativeClassPtr, "metrics");
		NativeFieldInfoPtr_glyphRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlyphMarshallingStruct>.NativeClassPtr, "glyphRect");
		NativeFieldInfoPtr_scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlyphMarshallingStruct>.NativeClassPtr, "scale");
		NativeFieldInfoPtr_atlasIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlyphMarshallingStruct>.NativeClassPtr, "atlasIndex");
		NativeFieldInfoPtr_classDefinitionType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlyphMarshallingStruct>.NativeClassPtr, "classDefinitionType");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlyphMarshallingStruct>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
