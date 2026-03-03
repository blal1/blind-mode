using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using UnityEngine.Bindings;

namespace UnityEngine;

public sealed class TextMesh : Component
{
	private delegate void get_text_InjectedDelegate(IntPtr _unity_self, [Out] IntPtr ret);

	private delegate IntPtr get_font_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_font_InjectedDelegate(IntPtr _unity_self, IntPtr value);

	private delegate int get_fontSize_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_fontSize_InjectedDelegate(IntPtr _unity_self, int value);

	private delegate FontStyle get_fontStyle_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_fontStyle_InjectedDelegate(IntPtr _unity_self, FontStyle value);

	private delegate float get_offsetZ_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_offsetZ_InjectedDelegate(IntPtr _unity_self, float value);

	private delegate TextAlignment get_alignment_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_alignment_InjectedDelegate(IntPtr _unity_self, TextAlignment value);

	private delegate TextAnchor get_anchor_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_anchor_InjectedDelegate(IntPtr _unity_self, TextAnchor value);

	private delegate float get_characterSize_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_characterSize_InjectedDelegate(IntPtr _unity_self, float value);

	private delegate float get_lineSpacing_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_lineSpacing_InjectedDelegate(IntPtr _unity_self, float value);

	private delegate float get_tabSize_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_tabSize_InjectedDelegate(IntPtr _unity_self, float value);

	private delegate bool get_richText_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_richText_InjectedDelegate(IntPtr _unity_self, bool value);

	private delegate void get_color_InjectedDelegate(IntPtr _unity_self, [Out] IntPtr ret);

	private delegate void set_color_InjectedDelegate(IntPtr _unity_self, [In] IntPtr value);

	private static readonly IntPtr NativeMethodInfoPtr_set_text_Public_set_Void_String_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_text_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_0;

	private static readonly get_text_InjectedDelegate get_text_InjectedDelegateField;

	private static readonly get_font_InjectedDelegate get_font_InjectedDelegateField;

	private static readonly set_font_InjectedDelegate set_font_InjectedDelegateField;

	private static readonly get_fontSize_InjectedDelegate get_fontSize_InjectedDelegateField;

	private static readonly set_fontSize_InjectedDelegate set_fontSize_InjectedDelegateField;

	private static readonly get_fontStyle_InjectedDelegate get_fontStyle_InjectedDelegateField;

	private static readonly set_fontStyle_InjectedDelegate set_fontStyle_InjectedDelegateField;

	private static readonly get_offsetZ_InjectedDelegate get_offsetZ_InjectedDelegateField;

	private static readonly set_offsetZ_InjectedDelegate set_offsetZ_InjectedDelegateField;

	private static readonly get_alignment_InjectedDelegate get_alignment_InjectedDelegateField;

	private static readonly set_alignment_InjectedDelegate set_alignment_InjectedDelegateField;

	private static readonly get_anchor_InjectedDelegate get_anchor_InjectedDelegateField;

	private static readonly set_anchor_InjectedDelegate set_anchor_InjectedDelegateField;

	private static readonly get_characterSize_InjectedDelegate get_characterSize_InjectedDelegateField;

	private static readonly set_characterSize_InjectedDelegate set_characterSize_InjectedDelegateField;

	private static readonly get_lineSpacing_InjectedDelegate get_lineSpacing_InjectedDelegateField;

	private static readonly set_lineSpacing_InjectedDelegate set_lineSpacing_InjectedDelegateField;

	private static readonly get_tabSize_InjectedDelegate get_tabSize_InjectedDelegateField;

	private static readonly set_tabSize_InjectedDelegate set_tabSize_InjectedDelegateField;

	private static readonly get_richText_InjectedDelegate get_richText_InjectedDelegateField;

	private static readonly set_richText_InjectedDelegate set_richText_InjectedDelegateField;

	private static readonly get_color_InjectedDelegate get_color_InjectedDelegateField;

	private static readonly set_color_InjectedDelegate set_color_InjectedDelegateField;

	public unsafe string text
	{
		get
		{
			Unsafe.SkipInit(out ManagedSpanWrapper ret);
			string stringAndDispose;
			try
			{
				IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
				if (intPtr == (IntPtr)0)
				{
					ThrowHelper.ThrowNullReferenceException(this);
				}
				get_text_Injected(intPtr, out ret);
			}
			finally
			{
				stringAndDispose = OutStringMarshaller.GetStringAndDispose(ret);
			}
			return stringAndDispose;
		}
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1285198, RefRangeEnd = 1285200, XrefRangeStart = 1285182, XrefRangeEnd = 1285198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_text_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public Font font
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return Unmarshal.UnmarshalUnityObject<Font>(get_font_Injected(intPtr));
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_font_Injected(intPtr, MarshalledUnityObject.Marshal(value));
		}
	}

	public int fontSize
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_fontSize_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_fontSize_Injected(intPtr, value);
		}
	}

	public FontStyle fontStyle
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_fontStyle_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_fontStyle_Injected(intPtr, value);
		}
	}

	public float offsetZ
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_offsetZ_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_offsetZ_Injected(intPtr, value);
		}
	}

	public TextAlignment alignment
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_alignment_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_alignment_Injected(intPtr, value);
		}
	}

	public TextAnchor anchor
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_anchor_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_anchor_Injected(intPtr, value);
		}
	}

	public float characterSize
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_characterSize_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_characterSize_Injected(intPtr, value);
		}
	}

	public float lineSpacing
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_lineSpacing_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_lineSpacing_Injected(intPtr, value);
		}
	}

	public float tabSize
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_tabSize_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_tabSize_Injected(intPtr, value);
		}
	}

	public bool richText
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_richText_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_richText_Injected(intPtr, value);
		}
	}

	public Color color
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			get_color_Injected(intPtr, out var ret);
			return ret;
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_color_Injected(intPtr, ref value);
		}
	}

	static TextMesh()
	{
		Il2CppClassPointerStore<TextMesh>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TextRenderingModule.dll", "UnityEngine", "TextMesh");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextMesh>.NativeClassPtr);
		NativeMethodInfoPtr_set_text_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMesh>.NativeClassPtr, 100663337);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMesh>.NativeClassPtr, 100663338);
		NativeMethodInfoPtr_set_text_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextMesh>.NativeClassPtr, 100663339);
		get_text_InjectedDelegateField = IL2CPP.ResolveICall<get_text_InjectedDelegate>("UnityEngine.TextMesh::get_text_Injected");
		get_font_InjectedDelegateField = IL2CPP.ResolveICall<get_font_InjectedDelegate>("UnityEngine.TextMesh::get_font_Injected");
		set_font_InjectedDelegateField = IL2CPP.ResolveICall<set_font_InjectedDelegate>("UnityEngine.TextMesh::set_font_Injected");
		get_fontSize_InjectedDelegateField = IL2CPP.ResolveICall<get_fontSize_InjectedDelegate>("UnityEngine.TextMesh::get_fontSize_Injected");
		set_fontSize_InjectedDelegateField = IL2CPP.ResolveICall<set_fontSize_InjectedDelegate>("UnityEngine.TextMesh::set_fontSize_Injected");
		get_fontStyle_InjectedDelegateField = IL2CPP.ResolveICall<get_fontStyle_InjectedDelegate>("UnityEngine.TextMesh::get_fontStyle_Injected");
		set_fontStyle_InjectedDelegateField = IL2CPP.ResolveICall<set_fontStyle_InjectedDelegate>("UnityEngine.TextMesh::set_fontStyle_Injected");
		get_offsetZ_InjectedDelegateField = IL2CPP.ResolveICall<get_offsetZ_InjectedDelegate>("UnityEngine.TextMesh::get_offsetZ_Injected");
		set_offsetZ_InjectedDelegateField = IL2CPP.ResolveICall<set_offsetZ_InjectedDelegate>("UnityEngine.TextMesh::set_offsetZ_Injected");
		get_alignment_InjectedDelegateField = IL2CPP.ResolveICall<get_alignment_InjectedDelegate>("UnityEngine.TextMesh::get_alignment_Injected");
		set_alignment_InjectedDelegateField = IL2CPP.ResolveICall<set_alignment_InjectedDelegate>("UnityEngine.TextMesh::set_alignment_Injected");
		get_anchor_InjectedDelegateField = IL2CPP.ResolveICall<get_anchor_InjectedDelegate>("UnityEngine.TextMesh::get_anchor_Injected");
		set_anchor_InjectedDelegateField = IL2CPP.ResolveICall<set_anchor_InjectedDelegate>("UnityEngine.TextMesh::set_anchor_Injected");
		get_characterSize_InjectedDelegateField = IL2CPP.ResolveICall<get_characterSize_InjectedDelegate>("UnityEngine.TextMesh::get_characterSize_Injected");
		set_characterSize_InjectedDelegateField = IL2CPP.ResolveICall<set_characterSize_InjectedDelegate>("UnityEngine.TextMesh::set_characterSize_Injected");
		get_lineSpacing_InjectedDelegateField = IL2CPP.ResolveICall<get_lineSpacing_InjectedDelegate>("UnityEngine.TextMesh::get_lineSpacing_Injected");
		set_lineSpacing_InjectedDelegateField = IL2CPP.ResolveICall<set_lineSpacing_InjectedDelegate>("UnityEngine.TextMesh::set_lineSpacing_Injected");
		get_tabSize_InjectedDelegateField = IL2CPP.ResolveICall<get_tabSize_InjectedDelegate>("UnityEngine.TextMesh::get_tabSize_Injected");
		set_tabSize_InjectedDelegateField = IL2CPP.ResolveICall<set_tabSize_InjectedDelegate>("UnityEngine.TextMesh::set_tabSize_Injected");
		get_richText_InjectedDelegateField = IL2CPP.ResolveICall<get_richText_InjectedDelegate>("UnityEngine.TextMesh::get_richText_Injected");
		set_richText_InjectedDelegateField = IL2CPP.ResolveICall<set_richText_InjectedDelegate>("UnityEngine.TextMesh::set_richText_Injected");
		get_color_InjectedDelegateField = IL2CPP.ResolveICall<get_color_InjectedDelegate>("UnityEngine.TextMesh::get_color_Injected");
		set_color_InjectedDelegateField = IL2CPP.ResolveICall<set_color_InjectedDelegate>("UnityEngine.TextMesh::set_color_Injected");
	}

	[CallerCount(646)]
	[CachedScanResults(RefRangeStart = 1152221, RefRangeEnd = 1152867, XrefRangeStart = 1152221, XrefRangeEnd = 1152867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TextMesh()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextMesh>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1285200, XrefRangeEnd = 1285202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_text_Injected(IntPtr _unity_self, ref ManagedSpanWrapper value)
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = Unsafe.AsPointer(ref value);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_text_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public TextMesh(IntPtr pointer)
		: base(pointer)
	{
	}

	public unsafe static void get_text_Injected(IntPtr _unity_self, out ManagedSpanWrapper ret)
	{
		get_text_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public static IntPtr get_font_Injected(IntPtr _unity_self)
	{
		return get_font_InjectedDelegateField(_unity_self);
	}

	public static void set_font_Injected(IntPtr _unity_self, IntPtr value)
	{
		set_font_InjectedDelegateField(_unity_self, value);
	}

	public static int get_fontSize_Injected(IntPtr _unity_self)
	{
		return get_fontSize_InjectedDelegateField(_unity_self);
	}

	public static void set_fontSize_Injected(IntPtr _unity_self, int value)
	{
		set_fontSize_InjectedDelegateField(_unity_self, value);
	}

	public static FontStyle get_fontStyle_Injected(IntPtr _unity_self)
	{
		return get_fontStyle_InjectedDelegateField(_unity_self);
	}

	public static void set_fontStyle_Injected(IntPtr _unity_self, FontStyle value)
	{
		set_fontStyle_InjectedDelegateField(_unity_self, value);
	}

	public static float get_offsetZ_Injected(IntPtr _unity_self)
	{
		return get_offsetZ_InjectedDelegateField(_unity_self);
	}

	public static void set_offsetZ_Injected(IntPtr _unity_self, float value)
	{
		set_offsetZ_InjectedDelegateField(_unity_self, value);
	}

	public static TextAlignment get_alignment_Injected(IntPtr _unity_self)
	{
		return get_alignment_InjectedDelegateField(_unity_self);
	}

	public static void set_alignment_Injected(IntPtr _unity_self, TextAlignment value)
	{
		set_alignment_InjectedDelegateField(_unity_self, value);
	}

	public static TextAnchor get_anchor_Injected(IntPtr _unity_self)
	{
		return get_anchor_InjectedDelegateField(_unity_self);
	}

	public static void set_anchor_Injected(IntPtr _unity_self, TextAnchor value)
	{
		set_anchor_InjectedDelegateField(_unity_self, value);
	}

	public static float get_characterSize_Injected(IntPtr _unity_self)
	{
		return get_characterSize_InjectedDelegateField(_unity_self);
	}

	public static void set_characterSize_Injected(IntPtr _unity_self, float value)
	{
		set_characterSize_InjectedDelegateField(_unity_self, value);
	}

	public static float get_lineSpacing_Injected(IntPtr _unity_self)
	{
		return get_lineSpacing_InjectedDelegateField(_unity_self);
	}

	public static void set_lineSpacing_Injected(IntPtr _unity_self, float value)
	{
		set_lineSpacing_InjectedDelegateField(_unity_self, value);
	}

	public static float get_tabSize_Injected(IntPtr _unity_self)
	{
		return get_tabSize_InjectedDelegateField(_unity_self);
	}

	public static void set_tabSize_Injected(IntPtr _unity_self, float value)
	{
		set_tabSize_InjectedDelegateField(_unity_self, value);
	}

	public static bool get_richText_Injected(IntPtr _unity_self)
	{
		return get_richText_InjectedDelegateField(_unity_self);
	}

	public static void set_richText_Injected(IntPtr _unity_self, bool value)
	{
		set_richText_InjectedDelegateField(_unity_self, value);
	}

	public unsafe static void get_color_Injected(IntPtr _unity_self, out Color ret)
	{
		get_color_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void set_color_Injected(IntPtr _unity_self, [In] ref Color value)
	{
		set_color_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref value));
	}
}
