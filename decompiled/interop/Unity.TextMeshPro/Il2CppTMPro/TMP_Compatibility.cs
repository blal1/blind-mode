using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppTMPro;

public static class TMP_Compatibility : Il2CppSystem.Object
{
	[OriginalName("Unity.TextMeshPro.dll", "", "AnchorPositions")]
	public enum AnchorPositions
	{
		TopLeft,
		Top,
		TopRight,
		Left,
		Center,
		Right,
		BottomLeft,
		Bottom,
		BottomRight,
		BaseLine,
		None
	}

	private static readonly System.IntPtr NativeMethodInfoPtr_ConvertTextAlignmentEnumValues_Public_Static_TextAlignmentOptions_TextAlignmentOptions_0;

	static TMP_Compatibility()
	{
		Il2CppClassPointerStore<TMP_Compatibility>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TMP_Compatibility");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_Compatibility>.NativeClassPtr);
		NativeMethodInfoPtr_ConvertTextAlignmentEnumValues_Public_Static_TextAlignmentOptions_TextAlignmentOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Compatibility>.NativeClassPtr, 100663674);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1120105, RefRangeEnd = 1120106, XrefRangeStart = 1120105, XrefRangeEnd = 1120105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static TextAlignmentOptions ConvertTextAlignmentEnumValues(TextAlignmentOptions oldValue)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&oldValue);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConvertTextAlignmentEnumValues_Public_Static_TextAlignmentOptions_TextAlignmentOptions_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(TextAlignmentOptions*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public TMP_Compatibility(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
