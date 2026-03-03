using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.TextCore.LowLevel;

namespace Il2CppTMPro;

[System.Serializable]
[StructLayout(LayoutKind.Explicit)]
public struct GlyphValueRecord_Legacy
{
	private static readonly System.IntPtr NativeFieldInfoPtr_xPlacement;

	private static readonly System.IntPtr NativeFieldInfoPtr_yPlacement;

	private static readonly System.IntPtr NativeFieldInfoPtr_xAdvance;

	private static readonly System.IntPtr NativeFieldInfoPtr_yAdvance;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_GlyphValueRecord_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_GlyphValueRecord_Legacy_GlyphValueRecord_Legacy_GlyphValueRecord_Legacy_0;

	[FieldOffset(0)]
	public float xPlacement;

	[FieldOffset(4)]
	public float yPlacement;

	[FieldOffset(8)]
	public float xAdvance;

	[FieldOffset(12)]
	public float yAdvance;

	static GlyphValueRecord_Legacy()
	{
		Il2CppClassPointerStore<GlyphValueRecord_Legacy>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "GlyphValueRecord_Legacy");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GlyphValueRecord_Legacy>.NativeClassPtr);
		NativeFieldInfoPtr_xPlacement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlyphValueRecord_Legacy>.NativeClassPtr, "xPlacement");
		NativeFieldInfoPtr_yPlacement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlyphValueRecord_Legacy>.NativeClassPtr, "yPlacement");
		NativeFieldInfoPtr_xAdvance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlyphValueRecord_Legacy>.NativeClassPtr, "xAdvance");
		NativeFieldInfoPtr_yAdvance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlyphValueRecord_Legacy>.NativeClassPtr, "yAdvance");
		NativeMethodInfoPtr__ctor_Internal_Void_GlyphValueRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphValueRecord_Legacy>.NativeClassPtr, 100663965);
		NativeMethodInfoPtr_op_Addition_Public_Static_GlyphValueRecord_Legacy_GlyphValueRecord_Legacy_GlyphValueRecord_Legacy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphValueRecord_Legacy>.NativeClassPtr, 100663966);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1124039, XrefRangeEnd = 1124043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GlyphValueRecord_Legacy(GlyphValueRecord valueRecord)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&valueRecord);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_GlyphValueRecord_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe static GlyphValueRecord_Legacy operator +(GlyphValueRecord_Legacy a, GlyphValueRecord_Legacy b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&a);
		*(GlyphValueRecord_Legacy**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Addition_Public_Static_GlyphValueRecord_Legacy_GlyphValueRecord_Legacy_GlyphValueRecord_Legacy_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(GlyphValueRecord_Legacy*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlyphValueRecord_Legacy>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
