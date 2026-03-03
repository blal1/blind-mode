using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using Il2CppSystem.Xml;

namespace Il2CppMS.Internal.Xml.XPath;

public sealed class XPathScanner : Il2CppSystem.Object
{
	[OriginalName("System.Xml.dll", "", "LexKind")]
	public enum LexKind
	{
		Comma = 44,
		Slash = 47,
		At = 64,
		Dot = 46,
		LParens = 40,
		RParens = 41,
		LBracket = 91,
		RBracket = 93,
		Star = 42,
		Plus = 43,
		Minus = 45,
		Eq = 61,
		Lt = 60,
		Gt = 62,
		Bang = 33,
		Dollar = 36,
		Apos = 39,
		Quote = 34,
		Union = 124,
		Ne = 78,
		Le = 76,
		Ge = 71,
		And = 65,
		Or = 79,
		DotDot = 68,
		SlashSlash = 83,
		Name = 110,
		String = 115,
		Number = 100,
		Axe = 97,
		Eof = 69
	}

	private static readonly System.IntPtr NativeFieldInfoPtr__xpathExpr;

	private static readonly System.IntPtr NativeFieldInfoPtr__xpathExprIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr__kind;

	private static readonly System.IntPtr NativeFieldInfoPtr__currentChar;

	private static readonly System.IntPtr NativeFieldInfoPtr__name;

	private static readonly System.IntPtr NativeFieldInfoPtr__prefix;

	private static readonly System.IntPtr NativeFieldInfoPtr__stringValue;

	private static readonly System.IntPtr NativeFieldInfoPtr__numberValue;

	private static readonly System.IntPtr NativeFieldInfoPtr__canBeFunction;

	private static readonly System.IntPtr NativeFieldInfoPtr__xmlCharType;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_SourceText_Public_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_CurrentChar_Private_get_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NextChar_Private_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Kind_Public_get_LexKind_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Name_Public_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Prefix_Public_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_StringValue_Public_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_NumberValue_Public_get_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_CanBeFunction_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SkipSpace_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NextLex_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ScanNumber_Private_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ScanFraction_Private_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ScanString_Private_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ScanName_Private_String_0;

	public unsafe string _xpathExpr
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__xpathExpr);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__xpathExpr)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe int _xpathExprIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__xpathExprIndex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__xpathExprIndex)) = value;
		}
	}

	public unsafe LexKind _kind
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__kind);
			return *(LexKind*)num;
		}
		set
		{
			*(LexKind*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__kind)) = value;
		}
	}

	public unsafe char _currentChar
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__currentChar);
			return *(char*)num;
		}
		set
		{
			*(char*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__currentChar)) = value;
		}
	}

	public unsafe string _name
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__name);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__name)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string _prefix
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__prefix);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__prefix)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string _stringValue
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__stringValue);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__stringValue)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe double _numberValue
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__numberValue);
			return *(double*)num;
		}
		set
		{
			*(double*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__numberValue)) = value;
		}
	}

	public unsafe bool _canBeFunction
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__canBeFunction);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__canBeFunction)) = value;
		}
	}

	public unsafe XmlCharType _xmlCharType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__xmlCharType);
			return new XmlCharType(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__xmlCharType), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe string SourceText
	{
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 50644, RefRangeEnd = 50653, XrefRangeStart = 50644, XrefRangeEnd = 50653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_SourceText_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
	}

	public unsafe char CurrentChar
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_CurrentChar_Private_get_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(char*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe LexKind Kind
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Kind_Public_get_LexKind_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(LexKind*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe string Name
	{
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 42604, RefRangeEnd = 42610, XrefRangeStart = 42604, XrefRangeEnd = 42610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
	}

	public unsafe string Prefix
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 50643, RefRangeEnd = 50644, XrefRangeStart = 50643, XrefRangeEnd = 50644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Prefix_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
	}

	public unsafe string StringValue
	{
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 50653, RefRangeEnd = 50668, XrefRangeStart = 50653, XrefRangeEnd = 50668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_StringValue_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
	}

	public unsafe double NumberValue
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_NumberValue_Public_get_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(double*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool CanBeFunction
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_CanBeFunction_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static XPathScanner()
	{
		Il2CppClassPointerStore<XPathScanner>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "MS.Internal.Xml.XPath", "XPathScanner");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XPathScanner>.NativeClassPtr);
		NativeFieldInfoPtr__xpathExpr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathScanner>.NativeClassPtr, "_xpathExpr");
		NativeFieldInfoPtr__xpathExprIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathScanner>.NativeClassPtr, "_xpathExprIndex");
		NativeFieldInfoPtr__kind = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathScanner>.NativeClassPtr, "_kind");
		NativeFieldInfoPtr__currentChar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathScanner>.NativeClassPtr, "_currentChar");
		NativeFieldInfoPtr__name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathScanner>.NativeClassPtr, "_name");
		NativeFieldInfoPtr__prefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathScanner>.NativeClassPtr, "_prefix");
		NativeFieldInfoPtr__stringValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathScanner>.NativeClassPtr, "_stringValue");
		NativeFieldInfoPtr__numberValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathScanner>.NativeClassPtr, "_numberValue");
		NativeFieldInfoPtr__canBeFunction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathScanner>.NativeClassPtr, "_canBeFunction");
		NativeFieldInfoPtr__xmlCharType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathScanner>.NativeClassPtr, "_xmlCharType");
		NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathScanner>.NativeClassPtr, 100668731);
		NativeMethodInfoPtr_get_SourceText_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathScanner>.NativeClassPtr, 100668732);
		NativeMethodInfoPtr_get_CurrentChar_Private_get_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathScanner>.NativeClassPtr, 100668733);
		NativeMethodInfoPtr_NextChar_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathScanner>.NativeClassPtr, 100668734);
		NativeMethodInfoPtr_get_Kind_Public_get_LexKind_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathScanner>.NativeClassPtr, 100668735);
		NativeMethodInfoPtr_get_Name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathScanner>.NativeClassPtr, 100668736);
		NativeMethodInfoPtr_get_Prefix_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathScanner>.NativeClassPtr, 100668737);
		NativeMethodInfoPtr_get_StringValue_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathScanner>.NativeClassPtr, 100668738);
		NativeMethodInfoPtr_get_NumberValue_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathScanner>.NativeClassPtr, 100668739);
		NativeMethodInfoPtr_get_CanBeFunction_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathScanner>.NativeClassPtr, 100668740);
		NativeMethodInfoPtr_SkipSpace_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathScanner>.NativeClassPtr, 100668741);
		NativeMethodInfoPtr_NextLex_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathScanner>.NativeClassPtr, 100668742);
		NativeMethodInfoPtr_ScanNumber_Private_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathScanner>.NativeClassPtr, 100668743);
		NativeMethodInfoPtr_ScanFraction_Private_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathScanner>.NativeClassPtr, 100668744);
		NativeMethodInfoPtr_ScanString_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathScanner>.NativeClassPtr, 100668745);
		NativeMethodInfoPtr_ScanName_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathScanner>.NativeClassPtr, 100668746);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 953457, XrefRangeEnd = 953471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe XPathScanner(string xpathExpr)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XPathScanner>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(xpathExpr);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(14)]
	[CachedScanResults(RefRangeStart = 953471, RefRangeEnd = 953485, XrefRangeStart = 953471, XrefRangeEnd = 953471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool NextChar()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NextChar_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 953488, RefRangeEnd = 953489, XrefRangeStart = 953485, XrefRangeEnd = 953488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SkipSpace()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SkipSpace_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(37)]
	[CachedScanResults(RefRangeStart = 953563, RefRangeEnd = 953600, XrefRangeStart = 953489, XrefRangeEnd = 953563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool NextLex()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NextLex_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 953616, RefRangeEnd = 953617, XrefRangeStart = 953600, XrefRangeEnd = 953616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe double ScanNumber()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ScanNumber_Private_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(double*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 953617, XrefRangeEnd = 953627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe double ScanFraction()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ScanFraction_Private_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(double*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 953637, RefRangeEnd = 953638, XrefRangeStart = 953627, XrefRangeEnd = 953637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string ScanString()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ScanString_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 953644, RefRangeEnd = 953646, XrefRangeStart = 953638, XrefRangeEnd = 953644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string ScanName()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ScanName_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	public XPathScanner(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
