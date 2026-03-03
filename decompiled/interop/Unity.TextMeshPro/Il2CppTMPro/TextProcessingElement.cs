using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace Il2CppTMPro;

public sealed class TextProcessingElement : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_ElementType;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_StartIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Length;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CharacterElement;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_MarkupElement;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_ElementType_Public_get_TextProcessingElementType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_ElementType_Public_set_Void_TextProcessingElementType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_StartIndex_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_StartIndex_Public_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Length_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_Length_Public_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_CharacterElement_Public_get_CharacterElement_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_MarkupElement_Public_get_MarkupElement_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_MarkupElement_Public_set_Void_MarkupElement_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_TextProcessingElementType_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_TMP_TextElement_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_CharacterElement_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_MarkupElement_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Undefined_Public_Static_get_TextProcessingElement_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DebuggerDisplay_Private_String_0;

	public unsafe TextProcessingElementType m_ElementType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ElementType);
			return *(TextProcessingElementType*)num;
		}
		set
		{
			*(TextProcessingElementType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ElementType)) = value;
		}
	}

	public unsafe int m_StartIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_StartIndex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_StartIndex)) = value;
		}
	}

	public unsafe int m_Length
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Length);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Length)) = value;
		}
	}

	public unsafe CharacterElement m_CharacterElement
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CharacterElement);
			return new CharacterElement(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CharacterElement>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CharacterElement), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CharacterElement>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe MarkupElement m_MarkupElement
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MarkupElement);
			return new MarkupElement(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MarkupElement>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MarkupElement), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<MarkupElement>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe TextProcessingElementType ElementType
	{
		[CallerCount(175)]
		[CachedScanResults(RefRangeStart = 52464, RefRangeEnd = 52639, XrefRangeStart = 52464, XrefRangeEnd = 52639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ElementType_Public_get_TextProcessingElementType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(TextProcessingElementType*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 53703, RefRangeEnd = 53715, XrefRangeStart = 53703, XrefRangeEnd = 53715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_ElementType_Public_set_Void_TextProcessingElementType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe int StartIndex
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_StartIndex_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 376349, RefRangeEnd = 376359, XrefRangeStart = 376349, XrefRangeEnd = 376359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_StartIndex_Public_set_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe int Length
	{
		[CallerCount(24)]
		[CachedScanResults(RefRangeStart = 719678, RefRangeEnd = 719702, XrefRangeStart = 719678, XrefRangeEnd = 719702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Length_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 765810, RefRangeEnd = 765814, XrefRangeStart = 765810, XrefRangeEnd = 765814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Length_Public_set_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe CharacterElement CharacterElement
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 739711, RefRangeEnd = 739712, XrefRangeStart = 739711, XrefRangeEnd = 739712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_CharacterElement_Public_get_CharacterElement_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new CharacterElement(pointer);
		}
	}

	public unsafe MarkupElement MarkupElement
	{
		[CallerCount(36)]
		[CachedScanResults(RefRangeStart = 32112, RefRangeEnd = 32148, XrefRangeStart = 32112, XrefRangeEnd = 32148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_MarkupElement_Public_get_MarkupElement_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new MarkupElement(pointer);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1134008, XrefRangeEnd = 1134012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value));
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_MarkupElement_Public_set_Void_MarkupElement_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe static TextProcessingElement Undefined
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Undefined_Public_Static_get_TextProcessingElement_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new TextProcessingElement(pointer);
		}
	}

	static TextProcessingElement()
	{
		Il2CppClassPointerStore<TextProcessingElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TextProcessingElement");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextProcessingElement>.NativeClassPtr);
		NativeFieldInfoPtr_m_ElementType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextProcessingElement>.NativeClassPtr, "m_ElementType");
		NativeFieldInfoPtr_m_StartIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextProcessingElement>.NativeClassPtr, "m_StartIndex");
		NativeFieldInfoPtr_m_Length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextProcessingElement>.NativeClassPtr, "m_Length");
		NativeFieldInfoPtr_m_CharacterElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextProcessingElement>.NativeClassPtr, "m_CharacterElement");
		NativeFieldInfoPtr_m_MarkupElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextProcessingElement>.NativeClassPtr, "m_MarkupElement");
		NativeMethodInfoPtr_get_ElementType_Public_get_TextProcessingElementType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextProcessingElement>.NativeClassPtr, 100665021);
		NativeMethodInfoPtr_set_ElementType_Public_set_Void_TextProcessingElementType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextProcessingElement>.NativeClassPtr, 100665022);
		NativeMethodInfoPtr_get_StartIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextProcessingElement>.NativeClassPtr, 100665023);
		NativeMethodInfoPtr_set_StartIndex_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextProcessingElement>.NativeClassPtr, 100665024);
		NativeMethodInfoPtr_get_Length_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextProcessingElement>.NativeClassPtr, 100665025);
		NativeMethodInfoPtr_set_Length_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextProcessingElement>.NativeClassPtr, 100665026);
		NativeMethodInfoPtr_get_CharacterElement_Public_get_CharacterElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextProcessingElement>.NativeClassPtr, 100665027);
		NativeMethodInfoPtr_get_MarkupElement_Public_get_MarkupElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextProcessingElement>.NativeClassPtr, 100665028);
		NativeMethodInfoPtr_set_MarkupElement_Public_set_Void_MarkupElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextProcessingElement>.NativeClassPtr, 100665029);
		NativeMethodInfoPtr__ctor_Public_Void_TextProcessingElementType_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextProcessingElement>.NativeClassPtr, 100665030);
		NativeMethodInfoPtr__ctor_Public_Void_TMP_TextElement_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextProcessingElement>.NativeClassPtr, 100665031);
		NativeMethodInfoPtr__ctor_Public_Void_CharacterElement_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextProcessingElement>.NativeClassPtr, 100665032);
		NativeMethodInfoPtr__ctor_Public_Void_MarkupElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextProcessingElement>.NativeClassPtr, 100665033);
		NativeMethodInfoPtr_get_Undefined_Public_Static_get_TextProcessingElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextProcessingElement>.NativeClassPtr, 100665034);
		NativeMethodInfoPtr_DebuggerDisplay_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextProcessingElement>.NativeClassPtr, 100665035);
	}

	[CallerCount(0)]
	public unsafe TextProcessingElement(TextProcessingElementType elementType, int startIndex, int length)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextProcessingElement>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&elementType);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &startIndex;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &length;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_TextProcessingElementType_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1134012, XrefRangeEnd = 1134014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TextProcessingElement(TMP_TextElement textElement, int startIndex, int length)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextProcessingElement>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)textElement);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &startIndex;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &length;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_TMP_TextElement_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1134014, XrefRangeEnd = 1134015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TextProcessingElement(CharacterElement characterElement, int startIndex, int length)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextProcessingElement>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)characterElement));
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &startIndex;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &length;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_CharacterElement_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1134015, XrefRangeEnd = 1134018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TextProcessingElement(MarkupElement markupElement)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextProcessingElement>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)markupElement));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_MarkupElement_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1134018, XrefRangeEnd = 1134027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string DebuggerDisplay()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DebuggerDisplay_Private_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	public TextProcessingElement(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public TextProcessingElement()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextProcessingElement>.NativeClassPtr))
	{
	}
}
