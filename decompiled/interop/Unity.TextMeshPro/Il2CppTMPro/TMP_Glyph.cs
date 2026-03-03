using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppTMPro;

[Serializable]
public class TMP_Glyph : TMP_TextElement_Legacy
{
	private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Static_TMP_Glyph_TMP_Glyph_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static TMP_Glyph()
	{
		Il2CppClassPointerStore<TMP_Glyph>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TMP_Glyph");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_Glyph>.NativeClassPtr);
		NativeMethodInfoPtr_Clone_Public_Static_TMP_Glyph_TMP_Glyph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Glyph>.NativeClassPtr, 100663961);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Glyph>.NativeClassPtr, 100663962);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1124027, XrefRangeEnd = 1124031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static TMP_Glyph Clone(TMP_Glyph source)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Clone_Public_Static_TMP_Glyph_TMP_Glyph_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<TMP_Glyph>(intPtr2) : null;
	}

	[CallerCount(134)]
	[CachedScanResults(RefRangeStart = 24861, RefRangeEnd = 24995, XrefRangeStart = 24861, XrefRangeEnd = 24995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TMP_Glyph()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_Glyph>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public TMP_Glyph(IntPtr pointer)
		: base(pointer)
	{
	}
}
