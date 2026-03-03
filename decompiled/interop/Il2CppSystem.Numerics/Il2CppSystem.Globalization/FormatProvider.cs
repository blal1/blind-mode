using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Text;

namespace Il2CppSystem.Globalization;

public class FormatProvider : Object
{
	public class Number : Object
	{
		[StructLayout(LayoutKind.Explicit)]
		public struct NumberBuffer
		{
			private static readonly System.IntPtr NativeFieldInfoPtr_precision;

			private static readonly System.IntPtr NativeFieldInfoPtr_scale;

			private static readonly System.IntPtr NativeFieldInfoPtr_sign;

			private static readonly System.IntPtr NativeFieldInfoPtr_overrideDigits;

			private static readonly System.IntPtr NativeMethodInfoPtr_get_digits_Public_get_ptr_Char_0;

			[FieldOffset(0)]
			public int precision;

			[FieldOffset(4)]
			public int scale;

			[FieldOffset(8)]
			[MarshalAs(UnmanagedType.U1)]
			public bool sign;

			[FieldOffset(16)]
			public System.IntPtr overrideDigits;

			public unsafe char* digits
			{
				[CallerCount(9)]
				[CachedScanResults(RefRangeStart = 50644, RefRangeEnd = 50653, XrefRangeStart = 50644, XrefRangeEnd = 50653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					System.IntPtr* ptr = null;
					Unsafe.SkipInit(out System.IntPtr intPtr);
					System.IntPtr result = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_digits_Public_get_ptr_Char_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
					Il2CppException.RaiseExceptionIfNecessary(intPtr);
					return (char*)result;
				}
			}

			static NumberBuffer()
			{
				Il2CppClassPointerStore<NumberBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Number>.NativeClassPtr, "NumberBuffer");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NumberBuffer>.NativeClassPtr);
				NativeFieldInfoPtr_precision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberBuffer>.NativeClassPtr, "precision");
				NativeFieldInfoPtr_scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberBuffer>.NativeClassPtr, "scale");
				NativeFieldInfoPtr_sign = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberBuffer>.NativeClassPtr, "sign");
				NativeFieldInfoPtr_overrideDigits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberBuffer>.NativeClassPtr, "overrideDigits");
				NativeMethodInfoPtr_get_digits_Public_get_ptr_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberBuffer>.NativeClassPtr, 100663359);
			}

			public unsafe Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NumberBuffer>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
			}
		}

		private static readonly System.IntPtr NativeFieldInfoPtr_s_posCurrencyFormats;

		private static readonly System.IntPtr NativeFieldInfoPtr_s_negCurrencyFormats;

		private static readonly System.IntPtr NativeFieldInfoPtr_s_posPercentFormats;

		private static readonly System.IntPtr NativeFieldInfoPtr_s_negPercentFormats;

		private static readonly System.IntPtr NativeFieldInfoPtr_s_negNumberFormats;

		private static readonly System.IntPtr NativeFieldInfoPtr_s_posNumberFormat;

		private static readonly System.IntPtr NativeMethodInfoPtr_Int32ToDecChars_Internal_Static_Void_ptr_Char_byref_Int32_UInt32_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_ParseFormatSpecifier_Internal_Static_Char_ReadOnlySpan_1_Char_byref_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_NumberToString_Internal_Static_Void_byref_ValueStringBuilder_byref_NumberBuffer_Char_Int32_NumberFormatInfo_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_FormatCurrency_Private_Static_Void_byref_ValueStringBuilder_byref_NumberBuffer_Int32_Int32_NumberFormatInfo_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_wcslen_Private_Static_Int32_ptr_Char_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_FormatFixed_Private_Static_Void_byref_ValueStringBuilder_byref_NumberBuffer_Int32_Int32_NumberFormatInfo_Il2CppStructArray_1_Int32_String_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_FormatNumber_Private_Static_Void_byref_ValueStringBuilder_byref_NumberBuffer_Int32_Int32_NumberFormatInfo_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_FormatScientific_Private_Static_Void_byref_ValueStringBuilder_byref_NumberBuffer_Int32_Int32_NumberFormatInfo_Char_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_FormatExponent_Private_Static_Void_byref_ValueStringBuilder_NumberFormatInfo_Int32_Char_Int32_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_FormatGeneral_Private_Static_Void_byref_ValueStringBuilder_byref_NumberBuffer_Int32_Int32_NumberFormatInfo_Char_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_FormatPercent_Private_Static_Void_byref_ValueStringBuilder_byref_NumberBuffer_Int32_Int32_NumberFormatInfo_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_RoundNumber_Private_Static_Void_byref_NumberBuffer_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_FindSection_Private_Static_Int32_ReadOnlySpan_1_Char_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_NumberToStringFormat_Internal_Static_Void_byref_ValueStringBuilder_byref_NumberBuffer_ReadOnlySpan_1_Char_NumberFormatInfo_0;

		public unsafe static Il2CppStringArray s_posCurrencyFormats
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_posCurrencyFormats, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_posCurrencyFormats, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static Il2CppStringArray s_negCurrencyFormats
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_negCurrencyFormats, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_negCurrencyFormats, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static Il2CppStringArray s_posPercentFormats
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_posPercentFormats, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_posPercentFormats, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static Il2CppStringArray s_negPercentFormats
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_negPercentFormats, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_negPercentFormats, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static Il2CppStringArray s_negNumberFormats
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_negNumberFormats, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_negNumberFormats, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static string s_posNumberFormat
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_posNumberFormat, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_posNumberFormat, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		static Number()
		{
			Il2CppClassPointerStore<Number>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FormatProvider>.NativeClassPtr, "Number");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Number>.NativeClassPtr);
			NativeFieldInfoPtr_s_posCurrencyFormats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Number>.NativeClassPtr, "s_posCurrencyFormats");
			NativeFieldInfoPtr_s_negCurrencyFormats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Number>.NativeClassPtr, "s_negCurrencyFormats");
			NativeFieldInfoPtr_s_posPercentFormats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Number>.NativeClassPtr, "s_posPercentFormats");
			NativeFieldInfoPtr_s_negPercentFormats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Number>.NativeClassPtr, "s_negPercentFormats");
			NativeFieldInfoPtr_s_negNumberFormats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Number>.NativeClassPtr, "s_negNumberFormats");
			NativeFieldInfoPtr_s_posNumberFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Number>.NativeClassPtr, "s_posNumberFormat");
			NativeMethodInfoPtr_Int32ToDecChars_Internal_Static_Void_ptr_Char_byref_Int32_UInt32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100663344);
			NativeMethodInfoPtr_ParseFormatSpecifier_Internal_Static_Char_ReadOnlySpan_1_Char_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100663345);
			NativeMethodInfoPtr_NumberToString_Internal_Static_Void_byref_ValueStringBuilder_byref_NumberBuffer_Char_Int32_NumberFormatInfo_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100663346);
			NativeMethodInfoPtr_FormatCurrency_Private_Static_Void_byref_ValueStringBuilder_byref_NumberBuffer_Int32_Int32_NumberFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100663347);
			NativeMethodInfoPtr_wcslen_Private_Static_Int32_ptr_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100663348);
			NativeMethodInfoPtr_FormatFixed_Private_Static_Void_byref_ValueStringBuilder_byref_NumberBuffer_Int32_Int32_NumberFormatInfo_Il2CppStructArray_1_Int32_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100663349);
			NativeMethodInfoPtr_FormatNumber_Private_Static_Void_byref_ValueStringBuilder_byref_NumberBuffer_Int32_Int32_NumberFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100663350);
			NativeMethodInfoPtr_FormatScientific_Private_Static_Void_byref_ValueStringBuilder_byref_NumberBuffer_Int32_Int32_NumberFormatInfo_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100663351);
			NativeMethodInfoPtr_FormatExponent_Private_Static_Void_byref_ValueStringBuilder_NumberFormatInfo_Int32_Char_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100663352);
			NativeMethodInfoPtr_FormatGeneral_Private_Static_Void_byref_ValueStringBuilder_byref_NumberBuffer_Int32_Int32_NumberFormatInfo_Char_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100663353);
			NativeMethodInfoPtr_FormatPercent_Private_Static_Void_byref_ValueStringBuilder_byref_NumberBuffer_Int32_Int32_NumberFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100663354);
			NativeMethodInfoPtr_RoundNumber_Private_Static_Void_byref_NumberBuffer_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100663355);
			NativeMethodInfoPtr_FindSection_Private_Static_Int32_ReadOnlySpan_1_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100663356);
			NativeMethodInfoPtr_NumberToStringFormat_Internal_Static_Void_byref_ValueStringBuilder_byref_NumberBuffer_ReadOnlySpan_1_Char_NumberFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Number>.NativeClassPtr, 100663357);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 901085, XrefRangeEnd = 901086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Int32ToDecChars(char* buffer, ref int index, uint value, int digits)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[4];
			*ptr = (nint)buffer;
			*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref index);
			*(uint**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
			*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &digits;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Int32ToDecChars_Internal_Static_Void_ptr_Char_byref_Int32_UInt32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 901091, RefRangeEnd = 901093, XrefRangeStart = 901086, XrefRangeEnd = 901091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static char ParseFormatSpecifier(ReadOnlySpan<char> format, out int digits)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)format));
			*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref digits);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ParseFormatSpecifier_Internal_Static_Char_ReadOnlySpan_1_Char_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(char*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 901119, RefRangeEnd = 901121, XrefRangeStart = 901093, XrefRangeEnd = 901119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void NumberToString(ref ValueStringBuilder sb, ref NumberBuffer number, char format, int nMaxDigits, NumberFormatInfo info, bool isDecimal)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[6];
			*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)sb);
			*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref number);
			*(char**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &format;
			*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &nMaxDigits;
			*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)info);
			*(bool**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &isDecimal;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NumberToString_Internal_Static_Void_byref_ValueStringBuilder_byref_NumberBuffer_Char_Int32_NumberFormatInfo_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 901121, XrefRangeEnd = 901140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FormatCurrency(ref ValueStringBuilder sb, ref NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[5];
			*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)sb);
			*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref number);
			*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &nMinDigits;
			*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &nMaxDigits;
			*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)info);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FormatCurrency_Private_Static_Void_byref_ValueStringBuilder_byref_NumberBuffer_Int32_Int32_NumberFormatInfo_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		public unsafe static int wcslen(char* s)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)s;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_wcslen_Private_Static_Int32_ptr_Char_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 901172, RefRangeEnd = 901176, XrefRangeStart = 901140, XrefRangeEnd = 901172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FormatFixed(ref ValueStringBuilder sb, ref NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info, Il2CppStructArray<int> groupDigits, string sDecimal, string sGroup)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[8];
			*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)sb);
			*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref number);
			*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &nMinDigits;
			*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &nMaxDigits;
			*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)info);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)groupDigits);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(sDecimal);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(sGroup);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FormatFixed_Private_Static_Void_byref_ValueStringBuilder_byref_NumberBuffer_Int32_Int32_NumberFormatInfo_Il2CppStructArray_1_Int32_String_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 901176, XrefRangeEnd = 901193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FormatNumber(ref ValueStringBuilder sb, ref NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[5];
			*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)sb);
			*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref number);
			*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &nMinDigits;
			*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &nMaxDigits;
			*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)info);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FormatNumber_Private_Static_Void_byref_ValueStringBuilder_byref_NumberBuffer_Int32_Int32_NumberFormatInfo_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 901193, XrefRangeEnd = 901207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FormatScientific(ref ValueStringBuilder sb, ref NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info, char expChar)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[6];
			*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)sb);
			*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref number);
			*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &nMinDigits;
			*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &nMaxDigits;
			*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)info);
			*(char**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &expChar;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FormatScientific_Private_Static_Void_byref_ValueStringBuilder_byref_NumberBuffer_Int32_Int32_NumberFormatInfo_Char_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 901220, RefRangeEnd = 901223, XrefRangeStart = 901207, XrefRangeEnd = 901220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FormatExponent(ref ValueStringBuilder sb, NumberFormatInfo info, int value, char expChar, int minDigits, bool positiveSign)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[6];
			*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)sb);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)info);
			*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
			*(char**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &expChar;
			*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &minDigits;
			*(bool**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &positiveSign;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FormatExponent_Private_Static_Void_byref_ValueStringBuilder_NumberFormatInfo_Int32_Char_Int32_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 901223, XrefRangeEnd = 901245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FormatGeneral(ref ValueStringBuilder sb, ref NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info, char expChar, bool bSuppressScientific)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[7];
			*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)sb);
			*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref number);
			*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &nMinDigits;
			*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &nMaxDigits;
			*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)info);
			*(char**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &expChar;
			*(bool**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &bSuppressScientific;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FormatGeneral_Private_Static_Void_byref_ValueStringBuilder_byref_NumberBuffer_Int32_Int32_NumberFormatInfo_Char_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 901264, RefRangeEnd = 901265, XrefRangeStart = 901245, XrefRangeEnd = 901264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FormatPercent(ref ValueStringBuilder sb, ref NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[5];
			*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)sb);
			*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref number);
			*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &nMinDigits;
			*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &nMaxDigits;
			*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)info);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FormatPercent_Private_Static_Void_byref_ValueStringBuilder_byref_NumberBuffer_Int32_Int32_NumberFormatInfo_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 901265, RefRangeEnd = 901268, XrefRangeStart = 901265, XrefRangeEnd = 901265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RoundNumber(ref NumberBuffer number, int pos)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)Unsafe.AsPointer(ref number);
			*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &pos;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RoundNumber_Private_Static_Void_byref_NumberBuffer_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 901272, RefRangeEnd = 901273, XrefRangeStart = 901268, XrefRangeEnd = 901272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int FindSection(ReadOnlySpan<char> format, int section)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)format));
			*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &section;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FindSection_Private_Static_Int32_ReadOnlySpan_1_Char_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 901363, RefRangeEnd = 901365, XrefRangeStart = 901273, XrefRangeEnd = 901363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void NumberToStringFormat(ref ValueStringBuilder sb, ref NumberBuffer number, ReadOnlySpan<char> format, NumberFormatInfo info)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[4];
			*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)sb);
			*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref number);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)format));
			*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)info);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NumberToStringFormat_Internal_Static_Void_byref_ValueStringBuilder_byref_NumberBuffer_ReadOnlySpan_1_Char_NumberFormatInfo_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public Number(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeMethodInfoPtr_FormatBigInteger_Internal_Static_Void_byref_ValueStringBuilder_Int32_Int32_Boolean_ReadOnlySpan_1_Char_NumberFormatInfo_Il2CppStructArray_1_Char_Int32_0;

	static FormatProvider()
	{
		Il2CppClassPointerStore<FormatProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Numerics.dll", "System.Globalization", "FormatProvider");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FormatProvider>.NativeClassPtr);
		NativeMethodInfoPtr_FormatBigInteger_Internal_Static_Void_byref_ValueStringBuilder_Int32_Int32_Boolean_ReadOnlySpan_1_Char_NumberFormatInfo_Il2CppStructArray_1_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatProvider>.NativeClassPtr, 100663343);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 901365, XrefRangeEnd = 901376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void FormatBigInteger(ref ValueStringBuilder sb, int precision, int scale, bool sign, ReadOnlySpan<char> format, NumberFormatInfo numberFormatInfo, Il2CppStructArray<char> digits, int startIndex)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[8];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)sb);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &precision;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &scale;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &sign;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)format));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)numberFormatInfo);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)digits);
		*(int**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &startIndex;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FormatBigInteger_Internal_Static_Void_byref_ValueStringBuilder_Int32_Int32_Boolean_ReadOnlySpan_1_Char_NumberFormatInfo_Il2CppStructArray_1_Char_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public FormatProvider(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
