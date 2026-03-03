using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppTMPro;

[System.Serializable]
public class KerningPair : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_FirstGlyph;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_FirstGlyphAdjustments;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_SecondGlyph;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_SecondGlyphAdjustments;

	private static readonly System.IntPtr NativeFieldInfoPtr_xOffset;

	private static readonly System.IntPtr NativeFieldInfoPtr_empty;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_IgnoreSpacingAdjustments;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_firstGlyph_Public_get_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_firstGlyph_Public_set_Void_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_firstGlyphAdjustments_Public_get_GlyphValueRecord_Legacy_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_secondGlyph_Public_get_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_secondGlyph_Public_set_Void_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_secondGlyphAdjustments_Public_get_GlyphValueRecord_Legacy_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_ignoreSpacingAdjustments_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_UInt32_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_GlyphValueRecord_Legacy_UInt32_GlyphValueRecord_Legacy_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ConvertLegacyKerningData_Internal_Void_0;

	public unsafe uint m_FirstGlyph
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_FirstGlyph);
			return *(uint*)num;
		}
		set
		{
			*(uint*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_FirstGlyph)) = value;
		}
	}

	public unsafe GlyphValueRecord_Legacy m_FirstGlyphAdjustments
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_FirstGlyphAdjustments);
			return *(GlyphValueRecord_Legacy*)num;
		}
		set
		{
			*(GlyphValueRecord_Legacy*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_FirstGlyphAdjustments)) = value;
		}
	}

	public unsafe uint m_SecondGlyph
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SecondGlyph);
			return *(uint*)num;
		}
		set
		{
			*(uint*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SecondGlyph)) = value;
		}
	}

	public unsafe GlyphValueRecord_Legacy m_SecondGlyphAdjustments
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SecondGlyphAdjustments);
			return *(GlyphValueRecord_Legacy*)num;
		}
		set
		{
			*(GlyphValueRecord_Legacy*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SecondGlyphAdjustments)) = value;
		}
	}

	public unsafe float xOffset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_xOffset);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_xOffset)) = value;
		}
	}

	public unsafe static KerningPair empty
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_empty, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<KerningPair>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_empty, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe bool m_IgnoreSpacingAdjustments
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_IgnoreSpacingAdjustments);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_IgnoreSpacingAdjustments)) = value;
		}
	}

	public unsafe uint firstGlyph
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 50668, RefRangeEnd = 50669, XrefRangeStart = 50668, XrefRangeEnd = 50669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_firstGlyph_Public_get_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 86468, RefRangeEnd = 86476, XrefRangeStart = 86468, XrefRangeEnd = 86476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_firstGlyph_Public_set_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe GlyphValueRecord_Legacy firstGlyphAdjustments
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_firstGlyphAdjustments_Public_get_GlyphValueRecord_Legacy_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(GlyphValueRecord_Legacy*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe uint secondGlyph
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_secondGlyph_Public_get_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_secondGlyph_Public_set_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe GlyphValueRecord_Legacy secondGlyphAdjustments
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_secondGlyphAdjustments_Public_get_GlyphValueRecord_Legacy_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(GlyphValueRecord_Legacy*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool ignoreSpacingAdjustments
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ignoreSpacingAdjustments_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static KerningPair()
	{
		Il2CppClassPointerStore<KerningPair>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "KerningPair");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KerningPair>.NativeClassPtr);
		NativeFieldInfoPtr_m_FirstGlyph = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KerningPair>.NativeClassPtr, "m_FirstGlyph");
		NativeFieldInfoPtr_m_FirstGlyphAdjustments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KerningPair>.NativeClassPtr, "m_FirstGlyphAdjustments");
		NativeFieldInfoPtr_m_SecondGlyph = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KerningPair>.NativeClassPtr, "m_SecondGlyph");
		NativeFieldInfoPtr_m_SecondGlyphAdjustments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KerningPair>.NativeClassPtr, "m_SecondGlyphAdjustments");
		NativeFieldInfoPtr_xOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KerningPair>.NativeClassPtr, "xOffset");
		NativeFieldInfoPtr_empty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KerningPair>.NativeClassPtr, "empty");
		NativeFieldInfoPtr_m_IgnoreSpacingAdjustments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KerningPair>.NativeClassPtr, "m_IgnoreSpacingAdjustments");
		NativeMethodInfoPtr_get_firstGlyph_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KerningPair>.NativeClassPtr, 100663967);
		NativeMethodInfoPtr_set_firstGlyph_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KerningPair>.NativeClassPtr, 100663968);
		NativeMethodInfoPtr_get_firstGlyphAdjustments_Public_get_GlyphValueRecord_Legacy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KerningPair>.NativeClassPtr, 100663969);
		NativeMethodInfoPtr_get_secondGlyph_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KerningPair>.NativeClassPtr, 100663970);
		NativeMethodInfoPtr_set_secondGlyph_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KerningPair>.NativeClassPtr, 100663971);
		NativeMethodInfoPtr_get_secondGlyphAdjustments_Public_get_GlyphValueRecord_Legacy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KerningPair>.NativeClassPtr, 100663972);
		NativeMethodInfoPtr_get_ignoreSpacingAdjustments_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KerningPair>.NativeClassPtr, 100663973);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KerningPair>.NativeClassPtr, 100663974);
		NativeMethodInfoPtr__ctor_Public_Void_UInt32_UInt32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KerningPair>.NativeClassPtr, 100663975);
		NativeMethodInfoPtr__ctor_Public_Void_UInt32_GlyphValueRecord_Legacy_UInt32_GlyphValueRecord_Legacy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KerningPair>.NativeClassPtr, 100663976);
		NativeMethodInfoPtr_ConvertLegacyKerningData_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KerningPair>.NativeClassPtr, 100663977);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1124043, XrefRangeEnd = 1124044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe KerningPair()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KerningPair>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1124044, XrefRangeEnd = 1124045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe KerningPair(uint left, uint right, float offset)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KerningPair>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&left);
		*(uint**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &right;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &offset;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_UInt32_UInt32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1124045, XrefRangeEnd = 1124046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe KerningPair(uint firstGlyph, GlyphValueRecord_Legacy firstGlyphAdjustments, uint secondGlyph, GlyphValueRecord_Legacy secondGlyphAdjustments)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KerningPair>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&firstGlyph);
		*(GlyphValueRecord_Legacy**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &firstGlyphAdjustments;
		*(uint**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &secondGlyph;
		*(GlyphValueRecord_Legacy**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &secondGlyphAdjustments;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_UInt32_GlyphValueRecord_Legacy_UInt32_GlyphValueRecord_Legacy_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe void ConvertLegacyKerningData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConvertLegacyKerningData_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public KerningPair(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
