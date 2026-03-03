using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.TextCore.Text;

namespace UnityEngine.TextCore;

public sealed class NativeTextGenerationSettings : Il2CppSystem.ValueType
{
	[System.Serializable]
	[ObfuscatedName("UnityEngine.TextCore.NativeTextGenerationSettings+<>c")]
	public sealed class __c : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___9;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__20_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__get_hasLink_b__20_0_Internal_Boolean_TextSpan_0;

		public unsafe static __c __9
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<__c>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static Il2CppSystem.Predicate<TextSpan> __9__20_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__20_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Predicate<TextSpan>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__20_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		static __c()
		{
			Il2CppClassPointerStore<__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NativeTextGenerationSettings>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c>.NativeClassPtr);
			NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9");
			NativeFieldInfoPtr___9__20_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__20_0");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100663306);
			NativeMethodInfoPtr__get_hasLink_b__20_0_Internal_Boolean_TextSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100663307);
		}

		[CallerCount(1950)]
		[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		public unsafe bool _get_hasLink_b__20_0(TextSpan span)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&span);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__get_hasLink_b__20_0_Internal_Boolean_TextSpan_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		public __c(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	public sealed class _003C_003Ec
	{
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_fontAsset;

	private static readonly System.IntPtr NativeFieldInfoPtr_textSettings;

	private static readonly System.IntPtr NativeFieldInfoPtr_text;

	private static readonly System.IntPtr NativeFieldInfoPtr_screenWidth;

	private static readonly System.IntPtr NativeFieldInfoPtr_screenHeight;

	private static readonly System.IntPtr NativeFieldInfoPtr_wordWrap;

	private static readonly System.IntPtr NativeFieldInfoPtr_overflow;

	private static readonly System.IntPtr NativeFieldInfoPtr_languageDirection;

	private static readonly System.IntPtr NativeFieldInfoPtr_vertexPadding;

	private static readonly System.IntPtr NativeFieldInfoPtr_horizontalAlignment;

	private static readonly System.IntPtr NativeFieldInfoPtr_verticalAlignment;

	private static readonly System.IntPtr NativeFieldInfoPtr_fontSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_fontStyle;

	private static readonly System.IntPtr NativeFieldInfoPtr_fontWeight;

	private static readonly System.IntPtr NativeFieldInfoPtr_textSpans;

	private static readonly System.IntPtr NativeFieldInfoPtr_color;

	private static readonly System.IntPtr NativeFieldInfoPtr_characterSpacing;

	private static readonly System.IntPtr NativeFieldInfoPtr_wordSpacing;

	private static readonly System.IntPtr NativeFieldInfoPtr_paragraphSpacing;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_hasLink_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateTextSpan_Public_TextSpan_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Default_Public_Static_get_NativeTextGenerationSettings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

	public unsafe System.IntPtr fontAsset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fontAsset);
			return *(System.IntPtr*)num;
		}
		set
		{
			*(System.IntPtr*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fontAsset)) = value;
		}
	}

	public unsafe System.IntPtr textSettings
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_textSettings);
			return *(System.IntPtr*)num;
		}
		set
		{
			*(System.IntPtr*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_textSettings)) = value;
		}
	}

	public unsafe string text
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_text);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_text)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe int screenWidth
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_screenWidth);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_screenWidth)) = value;
		}
	}

	public unsafe int screenHeight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_screenHeight);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_screenHeight)) = value;
		}
	}

	public unsafe WhiteSpace wordWrap
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wordWrap);
			return *(WhiteSpace*)num;
		}
		set
		{
			*(WhiteSpace*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wordWrap)) = value;
		}
	}

	public unsafe TextOverflow overflow
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overflow);
			return *(TextOverflow*)num;
		}
		set
		{
			*(TextOverflow*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overflow)) = value;
		}
	}

	public unsafe LanguageDirection languageDirection
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_languageDirection);
			return *(LanguageDirection*)num;
		}
		set
		{
			*(LanguageDirection*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_languageDirection)) = value;
		}
	}

	public unsafe int vertexPadding
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vertexPadding);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vertexPadding)) = value;
		}
	}

	public unsafe HorizontalAlignment horizontalAlignment
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_horizontalAlignment);
			return *(HorizontalAlignment*)num;
		}
		set
		{
			*(HorizontalAlignment*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_horizontalAlignment)) = value;
		}
	}

	public unsafe VerticalAlignment verticalAlignment
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_verticalAlignment);
			return *(VerticalAlignment*)num;
		}
		set
		{
			*(VerticalAlignment*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_verticalAlignment)) = value;
		}
	}

	public unsafe int fontSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fontSize);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fontSize)) = value;
		}
	}

	public unsafe FontStyles fontStyle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fontStyle);
			return *(FontStyles*)num;
		}
		set
		{
			*(FontStyles*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fontStyle)) = value;
		}
	}

	public unsafe TextFontWeight fontWeight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fontWeight);
			return *(TextFontWeight*)num;
		}
		set
		{
			*(TextFontWeight*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fontWeight)) = value;
		}
	}

	public unsafe Il2CppStructArray<TextSpan> textSpans
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_textSpans);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<TextSpan>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_textSpans)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Color32 color
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_color);
			return *(Color32*)num;
		}
		set
		{
			*(Color32*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_color)) = value;
		}
	}

	public unsafe int characterSpacing
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_characterSpacing);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_characterSpacing)) = value;
		}
	}

	public unsafe int wordSpacing
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wordSpacing);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wordSpacing)) = value;
		}
	}

	public unsafe int paragraphSpacing
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_paragraphSpacing);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_paragraphSpacing)) = value;
		}
	}

	public unsafe bool hasLink
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1273733, RefRangeEnd = 1273734, XrefRangeStart = 1273729, XrefRangeEnd = 1273733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_hasLink_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static NativeTextGenerationSettings Default
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1273735, RefRangeEnd = 1273736, XrefRangeStart = 1273734, XrefRangeEnd = 1273735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Default_Public_Static_get_NativeTextGenerationSettings_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new NativeTextGenerationSettings(pointer);
		}
	}

	static NativeTextGenerationSettings()
	{
		Il2CppClassPointerStore<NativeTextGenerationSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TextCoreTextEngineModule.dll", "UnityEngine.TextCore", "NativeTextGenerationSettings");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeTextGenerationSettings>.NativeClassPtr);
		NativeFieldInfoPtr_fontAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeTextGenerationSettings>.NativeClassPtr, "fontAsset");
		NativeFieldInfoPtr_textSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeTextGenerationSettings>.NativeClassPtr, "textSettings");
		NativeFieldInfoPtr_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeTextGenerationSettings>.NativeClassPtr, "text");
		NativeFieldInfoPtr_screenWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeTextGenerationSettings>.NativeClassPtr, "screenWidth");
		NativeFieldInfoPtr_screenHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeTextGenerationSettings>.NativeClassPtr, "screenHeight");
		NativeFieldInfoPtr_wordWrap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeTextGenerationSettings>.NativeClassPtr, "wordWrap");
		NativeFieldInfoPtr_overflow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeTextGenerationSettings>.NativeClassPtr, "overflow");
		NativeFieldInfoPtr_languageDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeTextGenerationSettings>.NativeClassPtr, "languageDirection");
		NativeFieldInfoPtr_vertexPadding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeTextGenerationSettings>.NativeClassPtr, "vertexPadding");
		NativeFieldInfoPtr_horizontalAlignment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeTextGenerationSettings>.NativeClassPtr, "horizontalAlignment");
		NativeFieldInfoPtr_verticalAlignment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeTextGenerationSettings>.NativeClassPtr, "verticalAlignment");
		NativeFieldInfoPtr_fontSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeTextGenerationSettings>.NativeClassPtr, "fontSize");
		NativeFieldInfoPtr_fontStyle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeTextGenerationSettings>.NativeClassPtr, "fontStyle");
		NativeFieldInfoPtr_fontWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeTextGenerationSettings>.NativeClassPtr, "fontWeight");
		NativeFieldInfoPtr_textSpans = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeTextGenerationSettings>.NativeClassPtr, "textSpans");
		NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeTextGenerationSettings>.NativeClassPtr, "color");
		NativeFieldInfoPtr_characterSpacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeTextGenerationSettings>.NativeClassPtr, "characterSpacing");
		NativeFieldInfoPtr_wordSpacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeTextGenerationSettings>.NativeClassPtr, "wordSpacing");
		NativeFieldInfoPtr_paragraphSpacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeTextGenerationSettings>.NativeClassPtr, "paragraphSpacing");
		NativeMethodInfoPtr_get_hasLink_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeTextGenerationSettings>.NativeClassPtr, 100663301);
		NativeMethodInfoPtr_CreateTextSpan_Public_TextSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeTextGenerationSettings>.NativeClassPtr, 100663302);
		NativeMethodInfoPtr_get_Default_Public_Static_get_NativeTextGenerationSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeTextGenerationSettings>.NativeClassPtr, 100663303);
		NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeTextGenerationSettings>.NativeClassPtr, 100663304);
	}

	[CallerCount(0)]
	public unsafe TextSpan CreateTextSpan()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateTextSpan_Public_TextSpan_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(TextSpan*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1273736, XrefRangeEnd = 1273899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override string ToString()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	public NativeTextGenerationSettings(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public NativeTextGenerationSettings()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativeTextGenerationSettings>.NativeClassPtr))
	{
	}

	public string GetTextSpanContent(int spanIndex)
	{
		if (Il2CppSystem.String.IsNullOrEmpty(text))
		{
			throw new Il2CppSystem.InvalidOperationException("The text property is null or empty.");
		}
		if (textSpans == null || spanIndex < 0 || spanIndex >= ((Il2CppArrayBase)textSpans).Length)
		{
			throw new Il2CppSystem.ArgumentOutOfRangeException("spanIndex", "Invalid span index.");
		}
		TextSpan textSpan = ((Il2CppArrayBase<TextSpan>)(object)textSpans)[spanIndex];
		if (textSpan.startIndex < 0 || textSpan.startIndex >= text.Length || textSpan.startIndex + textSpan.length > text.Length)
		{
			throw new Il2CppSystem.ArgumentOutOfRangeException("spanIndex", "Invalid startIndex or length for the current text.");
		}
		return text.Substring(textSpan.startIndex, textSpan.length);
	}
}
