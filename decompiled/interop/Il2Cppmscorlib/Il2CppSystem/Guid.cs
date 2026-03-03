using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem;

[System.Serializable]
[StructLayout(LayoutKind.Explicit)]
public struct Guid
{
	[OriginalName("mscorlib.dll", "", "GuidStyles")]
	[System.Flags]
	public enum GuidStyles
	{
		None = 0,
		AllowParenthesis = 1,
		AllowBraces = 2,
		AllowDashes = 4,
		AllowHexPrefix = 8,
		RequireParenthesis = 0x10,
		RequireBraces = 0x20,
		RequireDashes = 0x40,
		RequireHexPrefix = 0x80,
		HexFormat = 0xA0,
		NumberFormat = 0,
		DigitFormat = 0x40,
		BraceFormat = 0x60,
		ParenthesisFormat = 0x50,
		Any = 0xF
	}

	[OriginalName("mscorlib.dll", "", "GuidParseThrowStyle")]
	public enum GuidParseThrowStyle
	{
		None,
		All,
		AllButOverflow
	}

	[OriginalName("mscorlib.dll", "", "ParseFailureKind")]
	public enum ParseFailureKind
	{
		None,
		ArgumentNull,
		Format,
		FormatWithParameter,
		NativeException,
		FormatWithInnerException
	}

	public sealed class GuidResult : ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr__parsedGuid;

		private static readonly System.IntPtr NativeFieldInfoPtr__throwStyle;

		private static readonly System.IntPtr NativeFieldInfoPtr__failure;

		private static readonly System.IntPtr NativeFieldInfoPtr__failureMessageID;

		private static readonly System.IntPtr NativeFieldInfoPtr__failureMessageFormatArgument;

		private static readonly System.IntPtr NativeFieldInfoPtr__failureArgumentName;

		private static readonly System.IntPtr NativeFieldInfoPtr__innerException;

		private static readonly System.IntPtr NativeMethodInfoPtr_Init_Internal_Void_GuidParseThrowStyle_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_SetFailure_Internal_Void_Exception_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_SetFailure_Internal_Void_ParseFailureKind_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_SetFailure_Internal_Void_ParseFailureKind_String_Object_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_SetFailure_Internal_Void_ParseFailureKind_String_Object_String_Exception_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetGuidParseException_Internal_Exception_0;

		public unsafe Guid _parsedGuid
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__parsedGuid);
				return *(Guid*)num;
			}
			set
			{
				*(Guid*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__parsedGuid)) = value;
			}
		}

		public unsafe GuidParseThrowStyle _throwStyle
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__throwStyle);
				return *(GuidParseThrowStyle*)num;
			}
			set
			{
				*(GuidParseThrowStyle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__throwStyle)) = value;
			}
		}

		public unsafe ParseFailureKind _failure
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__failure);
				return *(ParseFailureKind*)num;
			}
			set
			{
				*(ParseFailureKind*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__failure)) = value;
			}
		}

		public unsafe string _failureMessageID
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__failureMessageID);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__failureMessageID)), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		public unsafe Object _failureMessageFormatArgument
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__failureMessageFormatArgument);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Object>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__failureMessageFormatArgument)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe string _failureArgumentName
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__failureArgumentName);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__failureArgumentName)), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		public unsafe Exception _innerException
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__innerException);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Exception>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__innerException)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		static GuidResult()
		{
			Il2CppClassPointerStore<GuidResult>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Guid>.NativeClassPtr, "GuidResult");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GuidResult>.NativeClassPtr);
			NativeFieldInfoPtr__parsedGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuidResult>.NativeClassPtr, "_parsedGuid");
			NativeFieldInfoPtr__throwStyle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuidResult>.NativeClassPtr, "_throwStyle");
			NativeFieldInfoPtr__failure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuidResult>.NativeClassPtr, "_failure");
			NativeFieldInfoPtr__failureMessageID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuidResult>.NativeClassPtr, "_failureMessageID");
			NativeFieldInfoPtr__failureMessageFormatArgument = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuidResult>.NativeClassPtr, "_failureMessageFormatArgument");
			NativeFieldInfoPtr__failureArgumentName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuidResult>.NativeClassPtr, "_failureArgumentName");
			NativeFieldInfoPtr__innerException = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuidResult>.NativeClassPtr, "_innerException");
			NativeMethodInfoPtr_Init_Internal_Void_GuidParseThrowStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuidResult>.NativeClassPtr, 100665148);
			NativeMethodInfoPtr_SetFailure_Internal_Void_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuidResult>.NativeClassPtr, 100665149);
			NativeMethodInfoPtr_SetFailure_Internal_Void_ParseFailureKind_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuidResult>.NativeClassPtr, 100665150);
			NativeMethodInfoPtr_SetFailure_Internal_Void_ParseFailureKind_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuidResult>.NativeClassPtr, 100665151);
			NativeMethodInfoPtr_SetFailure_Internal_Void_ParseFailureKind_String_Object_String_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuidResult>.NativeClassPtr, 100665152);
			NativeMethodInfoPtr_GetGuidParseException_Internal_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuidResult>.NativeClassPtr, 100665153);
		}

		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 86468, RefRangeEnd = 86476, XrefRangeStart = 86468, XrefRangeEnd = 86476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init(GuidParseThrowStyle canThrow)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&canThrow);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Init_Internal_Void_GuidParseThrowStyle_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 727825, XrefRangeEnd = 727826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFailure(Exception nativeException)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)nativeException);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetFailure_Internal_Void_Exception_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 727830, RefRangeEnd = 727835, XrefRangeStart = 727826, XrefRangeEnd = 727830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFailure(ParseFailureKind failure, string failureMessageID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&failure);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(failureMessageID);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetFailure_Internal_Void_ParseFailureKind_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 727839, RefRangeEnd = 727843, XrefRangeStart = 727835, XrefRangeEnd = 727839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFailure(ParseFailureKind failure, string failureMessageID, Object failureMessageFormatArgument)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[3];
			*ptr = (nint)(&failure);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(failureMessageID);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)failureMessageFormatArgument);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetFailure_Internal_Void_ParseFailureKind_String_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 727843, XrefRangeEnd = 727847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFailure(ParseFailureKind failure, string failureMessageID, Object failureMessageFormatArgument, string failureArgumentName, Exception innerException)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[5];
			*ptr = (nint)(&failure);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(failureMessageID);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)failureMessageFormatArgument);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(failureArgumentName);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)innerException);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetFailure_Internal_Void_ParseFailureKind_String_Object_String_Exception_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 727847, XrefRangeEnd = 727854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Exception GetGuidParseException()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetGuidParseException_Internal_Exception_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Exception>(intPtr2) : null;
		}

		public GuidResult(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public GuidResult()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GuidResult>.NativeClassPtr))
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_Empty;

	private static readonly System.IntPtr NativeFieldInfoPtr__a;

	private static readonly System.IntPtr NativeFieldInfoPtr__b;

	private static readonly System.IntPtr NativeFieldInfoPtr__c;

	private static readonly System.IntPtr NativeFieldInfoPtr__d;

	private static readonly System.IntPtr NativeFieldInfoPtr__e;

	private static readonly System.IntPtr NativeFieldInfoPtr__f;

	private static readonly System.IntPtr NativeFieldInfoPtr__g;

	private static readonly System.IntPtr NativeFieldInfoPtr__h;

	private static readonly System.IntPtr NativeFieldInfoPtr__i;

	private static readonly System.IntPtr NativeFieldInfoPtr__j;

	private static readonly System.IntPtr NativeFieldInfoPtr__k;

	private static readonly System.IntPtr NativeMethodInfoPtr_NewGuid_Public_Static_Guid_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ReadOnlySpan_1_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int16_Int16_Byte_Byte_Byte_Byte_Byte_Byte_Byte_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Parse_Public_Static_Guid_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Parse_Public_Static_Guid_ReadOnlySpan_1_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryParse_Public_Static_Boolean_String_byref_Guid_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryParse_Public_Static_Boolean_ReadOnlySpan_1_Char_byref_Guid_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryParseGuid_Private_Static_Boolean_ReadOnlySpan_1_Char_GuidStyles_byref_GuidResult_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryParseGuidWithHexPrefix_Private_Static_Boolean_ReadOnlySpan_1_Char_byref_GuidResult_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryParseGuidWithNoStyle_Private_Static_Boolean_ReadOnlySpan_1_Char_byref_GuidResult_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryParseGuidWithDashes_Private_Static_Boolean_ReadOnlySpan_1_Char_byref_GuidResult_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StringToShort_Private_Static_Boolean_ReadOnlySpan_1_Char_Int32_Int32_byref_Int16_byref_GuidResult_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StringToShort_Private_Static_Boolean_ReadOnlySpan_1_Char_byref_Int32_Int32_Int32_byref_Int16_byref_GuidResult_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StringToInt_Private_Static_Boolean_ReadOnlySpan_1_Char_Int32_Int32_byref_Int32_byref_GuidResult_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StringToInt_Private_Static_Boolean_ReadOnlySpan_1_Char_byref_Int32_Int32_Int32_byref_Int32_byref_GuidResult_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StringToLong_Private_Static_Boolean_ReadOnlySpan_1_Char_byref_Int32_Int32_byref_Int64_byref_GuidResult_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EatAllWhitespace_Private_Static_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsHexPrefix_Private_Static_Boolean_ReadOnlySpan_1_Char_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Guid_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetResult_Private_Int32_UInt32_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Guid_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Guid_Guid_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Guid_Guid_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HexToChar_Private_Static_Char_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HexsToChars_Private_Static_Int32_ptr_Char_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HexsToCharsHexOutput_Private_Static_Int32_ptr_Char_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryFormat_Public_Boolean_Span_1_Char_byref_Int32_ReadOnlySpan_1_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_System_ISpanFormattable_TryFormat_Private_Virtual_Final_New_Boolean_Span_1_Char_byref_Int32_ReadOnlySpan_1_Char_IFormatProvider_0;

	[FieldOffset(0)]
	public int _a;

	[FieldOffset(4)]
	public short _b;

	[FieldOffset(6)]
	public short _c;

	[FieldOffset(8)]
	public byte _d;

	[FieldOffset(9)]
	public byte _e;

	[FieldOffset(10)]
	public byte _f;

	[FieldOffset(11)]
	public byte _g;

	[FieldOffset(12)]
	public byte _h;

	[FieldOffset(13)]
	public byte _i;

	[FieldOffset(14)]
	public byte _j;

	[FieldOffset(15)]
	public byte _k;

	public unsafe static Guid Empty
	{
		get
		{
			Unsafe.SkipInit(out Guid result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Empty, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Empty, (void*)(&value));
		}
	}

	static Guid()
	{
		Il2CppClassPointerStore<Guid>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "Guid");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Guid>.NativeClassPtr);
		NativeFieldInfoPtr_Empty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Guid>.NativeClassPtr, "Empty");
		NativeFieldInfoPtr__a = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Guid>.NativeClassPtr, "_a");
		NativeFieldInfoPtr__b = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Guid>.NativeClassPtr, "_b");
		NativeFieldInfoPtr__c = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Guid>.NativeClassPtr, "_c");
		NativeFieldInfoPtr__d = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Guid>.NativeClassPtr, "_d");
		NativeFieldInfoPtr__e = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Guid>.NativeClassPtr, "_e");
		NativeFieldInfoPtr__f = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Guid>.NativeClassPtr, "_f");
		NativeFieldInfoPtr__g = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Guid>.NativeClassPtr, "_g");
		NativeFieldInfoPtr__h = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Guid>.NativeClassPtr, "_h");
		NativeFieldInfoPtr__i = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Guid>.NativeClassPtr, "_i");
		NativeFieldInfoPtr__j = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Guid>.NativeClassPtr, "_j");
		NativeFieldInfoPtr__k = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Guid>.NativeClassPtr, "_k");
		NativeMethodInfoPtr_NewGuid_Public_Static_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid>.NativeClassPtr, 100665112);
		NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid>.NativeClassPtr, 100665113);
		NativeMethodInfoPtr__ctor_Public_Void_ReadOnlySpan_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid>.NativeClassPtr, 100665114);
		NativeMethodInfoPtr__ctor_Public_Void_Int32_Int16_Int16_Byte_Byte_Byte_Byte_Byte_Byte_Byte_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid>.NativeClassPtr, 100665115);
		NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid>.NativeClassPtr, 100665116);
		NativeMethodInfoPtr_Parse_Public_Static_Guid_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid>.NativeClassPtr, 100665117);
		NativeMethodInfoPtr_Parse_Public_Static_Guid_ReadOnlySpan_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid>.NativeClassPtr, 100665118);
		NativeMethodInfoPtr_TryParse_Public_Static_Boolean_String_byref_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid>.NativeClassPtr, 100665119);
		NativeMethodInfoPtr_TryParse_Public_Static_Boolean_ReadOnlySpan_1_Char_byref_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid>.NativeClassPtr, 100665120);
		NativeMethodInfoPtr_TryParseGuid_Private_Static_Boolean_ReadOnlySpan_1_Char_GuidStyles_byref_GuidResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid>.NativeClassPtr, 100665121);
		NativeMethodInfoPtr_TryParseGuidWithHexPrefix_Private_Static_Boolean_ReadOnlySpan_1_Char_byref_GuidResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid>.NativeClassPtr, 100665122);
		NativeMethodInfoPtr_TryParseGuidWithNoStyle_Private_Static_Boolean_ReadOnlySpan_1_Char_byref_GuidResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid>.NativeClassPtr, 100665123);
		NativeMethodInfoPtr_TryParseGuidWithDashes_Private_Static_Boolean_ReadOnlySpan_1_Char_byref_GuidResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid>.NativeClassPtr, 100665124);
		NativeMethodInfoPtr_StringToShort_Private_Static_Boolean_ReadOnlySpan_1_Char_Int32_Int32_byref_Int16_byref_GuidResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid>.NativeClassPtr, 100665125);
		NativeMethodInfoPtr_StringToShort_Private_Static_Boolean_ReadOnlySpan_1_Char_byref_Int32_Int32_Int32_byref_Int16_byref_GuidResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid>.NativeClassPtr, 100665126);
		NativeMethodInfoPtr_StringToInt_Private_Static_Boolean_ReadOnlySpan_1_Char_Int32_Int32_byref_Int32_byref_GuidResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid>.NativeClassPtr, 100665127);
		NativeMethodInfoPtr_StringToInt_Private_Static_Boolean_ReadOnlySpan_1_Char_byref_Int32_Int32_Int32_byref_Int32_byref_GuidResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid>.NativeClassPtr, 100665128);
		NativeMethodInfoPtr_StringToLong_Private_Static_Boolean_ReadOnlySpan_1_Char_byref_Int32_Int32_byref_Int64_byref_GuidResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid>.NativeClassPtr, 100665129);
		NativeMethodInfoPtr_EatAllWhitespace_Private_Static_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid>.NativeClassPtr, 100665130);
		NativeMethodInfoPtr_IsHexPrefix_Private_Static_Boolean_ReadOnlySpan_1_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid>.NativeClassPtr, 100665131);
		NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid>.NativeClassPtr, 100665132);
		NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid>.NativeClassPtr, 100665133);
		NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid>.NativeClassPtr, 100665134);
		NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid>.NativeClassPtr, 100665135);
		NativeMethodInfoPtr_GetResult_Private_Int32_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid>.NativeClassPtr, 100665136);
		NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid>.NativeClassPtr, 100665137);
		NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid>.NativeClassPtr, 100665138);
		NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Guid_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid>.NativeClassPtr, 100665139);
		NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Guid_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid>.NativeClassPtr, 100665140);
		NativeMethodInfoPtr_ToString_Public_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid>.NativeClassPtr, 100665141);
		NativeMethodInfoPtr_HexToChar_Private_Static_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid>.NativeClassPtr, 100665142);
		NativeMethodInfoPtr_HexsToChars_Private_Static_Int32_ptr_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid>.NativeClassPtr, 100665143);
		NativeMethodInfoPtr_HexsToCharsHexOutput_Private_Static_Int32_ptr_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid>.NativeClassPtr, 100665144);
		NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid>.NativeClassPtr, 100665145);
		NativeMethodInfoPtr_TryFormat_Public_Boolean_Span_1_Char_byref_Int32_ReadOnlySpan_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid>.NativeClassPtr, 100665146);
		NativeMethodInfoPtr_System_ISpanFormattable_TryFormat_Private_Virtual_Final_New_Boolean_Span_1_Char_byref_Int32_ReadOnlySpan_1_Char_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Guid>.NativeClassPtr, 100665147);
	}

	[CallerCount(20)]
	[CachedScanResults(RefRangeStart = 727855, RefRangeEnd = 727875, XrefRangeStart = 727854, XrefRangeEnd = 727855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Guid NewGuid()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NewGuid_Public_Static_Guid_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Guid*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 727877, RefRangeEnd = 727880, XrefRangeStart = 727875, XrefRangeEnd = 727877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Guid(Il2CppStructArray<byte> b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)b);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 727881, RefRangeEnd = 727882, XrefRangeStart = 727880, XrefRangeEnd = 727881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Guid(ReadOnlySpan<byte> b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)b));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_ReadOnlySpan_1_Byte_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 727882, RefRangeEnd = 727883, XrefRangeStart = 727882, XrefRangeEnd = 727882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Guid(int a, short b, short c, byte d, byte e, byte f, byte g, byte h, byte i, byte j, byte k)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[11];
		*ptr = (nint)(&a);
		*(short**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		*(short**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &c;
		*(byte**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &d;
		*(byte**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &e;
		*(byte**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &f;
		*(byte**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &g;
		*(byte**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &h;
		*(byte**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = &i;
		*(byte**)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = &j;
		*(byte**)((byte*)ptr + checked((nuint)10u * unchecked((nuint)sizeof(System.IntPtr)))) = &k;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_Int16_Int16_Byte_Byte_Byte_Byte_Byte_Byte_Byte_Byte_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(25)]
	[CachedScanResults(RefRangeStart = 727886, RefRangeEnd = 727911, XrefRangeStart = 727883, XrefRangeEnd = 727886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Guid(string g)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(g);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 727911, XrefRangeEnd = 727914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Guid Parse(string input)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Parse_Public_Static_Guid_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Guid*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 727914, XrefRangeEnd = 727915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Guid Parse(ReadOnlySpan<char> input)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)input));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Parse_Public_Static_Guid_ReadOnlySpan_1_Char_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Guid*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 727918, RefRangeEnd = 727919, XrefRangeStart = 727915, XrefRangeEnd = 727918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool TryParse(string input, out Guid result)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref result);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryParse_Public_Static_Boolean_String_byref_Guid_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 727919, XrefRangeEnd = 727920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool TryParse(ReadOnlySpan<char> input, out Guid result)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)input));
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref result);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryParse_Public_Static_Boolean_ReadOnlySpan_1_Char_byref_Guid_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 727928, RefRangeEnd = 727933, XrefRangeStart = 727920, XrefRangeEnd = 727928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool TryParseGuid(ReadOnlySpan<char> guidString, GuidStyles flags, ref GuidResult result)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)guidString));
		*(GuidStyles**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &flags;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)result);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryParseGuid_Private_Static_Boolean_ReadOnlySpan_1_Char_GuidStyles_byref_GuidResult_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 727933, XrefRangeEnd = 728025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool TryParseGuidWithHexPrefix(ReadOnlySpan<char> guidString, ref GuidResult result)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)guidString));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)result);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryParseGuidWithHexPrefix_Private_Static_Boolean_ReadOnlySpan_1_Char_byref_GuidResult_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 728025, XrefRangeEnd = 728052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool TryParseGuidWithNoStyle(ReadOnlySpan<char> guidString, ref GuidResult result)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)guidString));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)result);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryParseGuidWithNoStyle_Private_Static_Boolean_ReadOnlySpan_1_Char_byref_GuidResult_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 728052, XrefRangeEnd = 728057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool TryParseGuidWithDashes(ReadOnlySpan<char> guidString, ref GuidResult result)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)guidString));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)result);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryParseGuidWithDashes_Private_Static_Boolean_ReadOnlySpan_1_Char_byref_GuidResult_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 728057, XrefRangeEnd = 728058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool StringToShort(ReadOnlySpan<char> str, int requiredLength, int flags, out short result, ref GuidResult parseResult)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)str));
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &requiredLength;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &flags;
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref result);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)parseResult);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StringToShort_Private_Static_Boolean_ReadOnlySpan_1_Char_Int32_Int32_byref_Int16_byref_GuidResult_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 728058, XrefRangeEnd = 728059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool StringToShort(ReadOnlySpan<char> str, ref int parsePos, int requiredLength, int flags, out short result, ref GuidResult parseResult)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)str));
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref parsePos);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &requiredLength;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &flags;
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref result);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)parseResult);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StringToShort_Private_Static_Boolean_ReadOnlySpan_1_Char_byref_Int32_Int32_Int32_byref_Int16_byref_GuidResult_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 728059, XrefRangeEnd = 728060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool StringToInt(ReadOnlySpan<char> str, int requiredLength, int flags, out int result, ref GuidResult parseResult)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)str));
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &requiredLength;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &flags;
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref result);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)parseResult);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StringToInt_Private_Static_Boolean_ReadOnlySpan_1_Char_Int32_Int32_byref_Int32_byref_GuidResult_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(11)]
	[CachedScanResults(RefRangeStart = 728064, RefRangeEnd = 728075, XrefRangeStart = 728060, XrefRangeEnd = 728064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool StringToInt(ReadOnlySpan<char> str, ref int parsePos, int requiredLength, int flags, out int result, ref GuidResult parseResult)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)str));
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref parsePos);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &requiredLength;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &flags;
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref result);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)parseResult);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StringToInt_Private_Static_Boolean_ReadOnlySpan_1_Char_byref_Int32_Int32_Int32_byref_Int32_byref_GuidResult_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 728076, RefRangeEnd = 728077, XrefRangeStart = 728075, XrefRangeEnd = 728076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool StringToLong(ReadOnlySpan<char> str, ref int parsePos, int flags, out long result, ref GuidResult parseResult)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)str));
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref parsePos);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &flags;
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref result);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)parseResult);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StringToLong_Private_Static_Boolean_ReadOnlySpan_1_Char_byref_Int32_Int32_byref_Int64_byref_GuidResult_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 728102, RefRangeEnd = 728103, XrefRangeStart = 728077, XrefRangeEnd = 728102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ReadOnlySpan<char> EatAllWhitespace(ReadOnlySpan<char> str)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)str));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EatAllWhitespace_Private_Static_ReadOnlySpan_1_Char_ReadOnlySpan_1_Char_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new ReadOnlySpan<char>(pointer);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 728104, RefRangeEnd = 728105, XrefRangeStart = 728103, XrefRangeEnd = 728104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsHexPrefix(ReadOnlySpan<char> str, int i)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)str));
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &i;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsHexPrefix_Private_Static_Boolean_ReadOnlySpan_1_Char_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(30)]
	[CachedScanResults(RefRangeStart = 728108, RefRangeEnd = 728138, XrefRangeStart = 728105, XrefRangeEnd = 728108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override string ToString()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToString_Public_Virtual_String_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 728138, RefRangeEnd = 728139, XrefRangeStart = 728138, XrefRangeEnd = 728138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override int GetHashCode()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 728142, RefRangeEnd = 728143, XrefRangeStart = 728139, XrefRangeEnd = 728142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Equals(Object o)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)o);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual bool Equals(Guid g)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&g);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Guid_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe int GetResult(uint me, uint them)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&me);
		*(uint**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &them;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetResult_Private_Int32_UInt32_UInt32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 728143, XrefRangeEnd = 728146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual int CompareTo(Object value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe virtual int CompareTo(Guid value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Guid_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(15)]
	[CachedScanResults(RefRangeStart = 728146, RefRangeEnd = 728161, XrefRangeStart = 728146, XrefRangeEnd = 728146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool operator ==(Guid a, Guid b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&a);
		*(Guid**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Guid_Guid_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 728161, RefRangeEnd = 728162, XrefRangeStart = 728161, XrefRangeEnd = 728161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool operator !=(Guid a, Guid b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&a);
		*(Guid**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Guid_Guid_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 728163, RefRangeEnd = 728170, XrefRangeStart = 728162, XrefRangeEnd = 728163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string ToString(string format)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToString_Public_String_String_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static char HexToChar(int a)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&a);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HexToChar_Private_Static_Char_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(char*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static int HexsToChars(char* guidChars, int a, int b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)guidChars;
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &a;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HexsToChars_Private_Static_Int32_ptr_Char_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static int HexsToCharsHexOutput(char* guidChars, int a, int b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)guidChars;
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &a;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HexsToCharsHexOutput_Private_Static_Int32_ptr_Char_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 728185, RefRangeEnd = 728187, XrefRangeStart = 728170, XrefRangeEnd = 728185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual string ToString(string format, IFormatProvider provider)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)provider);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 728204, RefRangeEnd = 728206, XrefRangeStart = 728187, XrefRangeEnd = 728204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)destination));
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref charsWritten);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)format));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryFormat_Public_Boolean_Span_1_Char_byref_Int32_ReadOnlySpan_1_Char_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 728206, XrefRangeEnd = 728207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual bool System_ISpanFormattable_TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider provider)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)destination));
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref charsWritten);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)format));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)provider);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_ISpanFormattable_TryFormat_Private_Virtual_Final_New_Boolean_Span_1_Char_byref_Int32_ReadOnlySpan_1_Char_IFormatProvider_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public unsafe Object BoxIl2CppObject()
	{
		return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Guid>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
