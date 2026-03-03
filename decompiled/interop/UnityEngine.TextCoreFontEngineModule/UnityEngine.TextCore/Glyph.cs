using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using UnityEngine.TextCore.LowLevel;

namespace UnityEngine.TextCore;

[System.Serializable]
public class Glyph : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_Index;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Metrics;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_GlyphRect;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Scale;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_AtlasIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ClassDefinitionType;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_index_Public_get_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_index_Public_set_Void_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_metrics_Public_get_GlyphMetrics_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_metrics_Public_set_Void_GlyphMetrics_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_glyphRect_Public_get_GlyphRect_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_glyphRect_Public_set_Void_GlyphRect_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_scale_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_scale_Public_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_atlasIndex_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_atlasIndex_Public_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_GlyphMarshallingStruct_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_GlyphMetrics_GlyphRect_Single_Int32_0;

	public unsafe uint m_Index
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Index);
			return *(uint*)num;
		}
		set
		{
			*(uint*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Index)) = value;
		}
	}

	public unsafe GlyphMetrics m_Metrics
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Metrics);
			return *(GlyphMetrics*)num;
		}
		set
		{
			*(GlyphMetrics*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Metrics)) = value;
		}
	}

	public unsafe GlyphRect m_GlyphRect
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_GlyphRect);
			return *(GlyphRect*)num;
		}
		set
		{
			*(GlyphRect*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_GlyphRect)) = value;
		}
	}

	public unsafe float m_Scale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Scale);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Scale)) = value;
		}
	}

	public unsafe int m_AtlasIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AtlasIndex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AtlasIndex)) = value;
		}
	}

	public unsafe GlyphClassDefinitionType m_ClassDefinitionType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ClassDefinitionType);
			return *(GlyphClassDefinitionType*)num;
		}
		set
		{
			*(GlyphClassDefinitionType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ClassDefinitionType)) = value;
		}
	}

	public unsafe uint index
	{
		[CallerCount(60)]
		[CachedScanResults(RefRangeStart = 1167244, RefRangeEnd = 1167304, XrefRangeStart = 1167244, XrefRangeEnd = 1167304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_index_Public_get_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
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
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_index_Public_set_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe GlyphMetrics metrics
	{
		[CallerCount(42)]
		[CachedScanResults(RefRangeStart = 1272656, RefRangeEnd = 1272698, XrefRangeStart = 1272656, XrefRangeEnd = 1272656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_metrics_Public_get_GlyphMetrics_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(GlyphMetrics*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1272698, RefRangeEnd = 1272701, XrefRangeStart = 1272698, XrefRangeEnd = 1272698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_metrics_Public_set_Void_GlyphMetrics_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe GlyphRect glyphRect
	{
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 1254708, RefRangeEnd = 1254727, XrefRangeStart = 1254708, XrefRangeEnd = 1254727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_glyphRect_Public_get_GlyphRect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(GlyphRect*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 591312, RefRangeEnd = 591315, XrefRangeStart = 591312, XrefRangeEnd = 591315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_glyphRect_Public_set_Void_GlyphRect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe float scale
	{
		[CallerCount(45)]
		[CachedScanResults(RefRangeStart = 1114260, RefRangeEnd = 1114305, XrefRangeStart = 1114260, XrefRangeEnd = 1114305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_scale_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 842832, RefRangeEnd = 842835, XrefRangeStart = 842832, XrefRangeEnd = 842835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_scale_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe int atlasIndex
	{
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1272701, RefRangeEnd = 1272708, XrefRangeStart = 1272701, XrefRangeEnd = 1272701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_atlasIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 143832, RefRangeEnd = 143841, XrefRangeStart = 143832, XrefRangeEnd = 143841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_atlasIndex_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public GlyphClassDefinitionType classDefinitionType
	{
		get
		{
			return m_ClassDefinitionType;
		}
		set
		{
			m_ClassDefinitionType = value;
		}
	}

	static Glyph()
	{
		Il2CppClassPointerStore<Glyph>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TextCoreFontEngineModule.dll", "UnityEngine.TextCore", "Glyph");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Glyph>.NativeClassPtr);
		NativeFieldInfoPtr_m_Index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Glyph>.NativeClassPtr, "m_Index");
		NativeFieldInfoPtr_m_Metrics = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Glyph>.NativeClassPtr, "m_Metrics");
		NativeFieldInfoPtr_m_GlyphRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Glyph>.NativeClassPtr, "m_GlyphRect");
		NativeFieldInfoPtr_m_Scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Glyph>.NativeClassPtr, "m_Scale");
		NativeFieldInfoPtr_m_AtlasIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Glyph>.NativeClassPtr, "m_AtlasIndex");
		NativeFieldInfoPtr_m_ClassDefinitionType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Glyph>.NativeClassPtr, "m_ClassDefinitionType");
		NativeMethodInfoPtr_get_index_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Glyph>.NativeClassPtr, 100663341);
		NativeMethodInfoPtr_set_index_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Glyph>.NativeClassPtr, 100663342);
		NativeMethodInfoPtr_get_metrics_Public_get_GlyphMetrics_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Glyph>.NativeClassPtr, 100663343);
		NativeMethodInfoPtr_set_metrics_Public_set_Void_GlyphMetrics_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Glyph>.NativeClassPtr, 100663344);
		NativeMethodInfoPtr_get_glyphRect_Public_get_GlyphRect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Glyph>.NativeClassPtr, 100663345);
		NativeMethodInfoPtr_set_glyphRect_Public_set_Void_GlyphRect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Glyph>.NativeClassPtr, 100663346);
		NativeMethodInfoPtr_get_scale_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Glyph>.NativeClassPtr, 100663347);
		NativeMethodInfoPtr_set_scale_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Glyph>.NativeClassPtr, 100663348);
		NativeMethodInfoPtr_get_atlasIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Glyph>.NativeClassPtr, 100663349);
		NativeMethodInfoPtr_set_atlasIndex_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Glyph>.NativeClassPtr, 100663350);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Glyph>.NativeClassPtr, 100663351);
		NativeMethodInfoPtr__ctor_Internal_Void_GlyphMarshallingStruct_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Glyph>.NativeClassPtr, 100663352);
		NativeMethodInfoPtr__ctor_Public_Void_UInt32_GlyphMetrics_GlyphRect_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Glyph>.NativeClassPtr, 100663353);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1272709, RefRangeEnd = 1272714, XrefRangeStart = 1272708, XrefRangeEnd = 1272709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Glyph()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Glyph>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1272714, XrefRangeEnd = 1272715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Glyph(GlyphMarshallingStruct glyphStruct)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Glyph>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&glyphStruct);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_GlyphMarshallingStruct_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1272715, XrefRangeEnd = 1272716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Glyph(uint index, GlyphMetrics metrics, GlyphRect glyphRect, float scale, int atlasIndex)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Glyph>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&index);
		*(GlyphMetrics**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &metrics;
		*(GlyphRect**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &glyphRect;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &scale;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &atlasIndex;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_UInt32_GlyphMetrics_GlyphRect_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public Glyph(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public bool Compare(Glyph other)
	{
		return index == other.index && metrics == other.metrics && glyphRect == other.glyphRect && scale == other.scale && atlasIndex == other.atlasIndex;
	}
}
