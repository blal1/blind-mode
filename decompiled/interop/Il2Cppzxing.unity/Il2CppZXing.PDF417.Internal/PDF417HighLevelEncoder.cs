using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Text;

namespace Il2CppZXing.PDF417.Internal;

public static class PDF417HighLevelEncoder : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_TEXT_MIXED_RAW;

	private static readonly System.IntPtr NativeFieldInfoPtr_TEXT_PUNCTUATION_RAW;

	private static readonly System.IntPtr NativeFieldInfoPtr_MIXED;

	private static readonly System.IntPtr NativeFieldInfoPtr_PUNCTUATION;

	private static readonly System.IntPtr NativeFieldInfoPtr_DEFAULT_ENCODING_NAME;

	private static readonly System.IntPtr NativeMethodInfoPtr_encodeHighLevel_Internal_Static_String_String_Compaction_Encoding_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_getEncoder_Private_Static_Encoding_Encoding_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_toBytes_Private_Static_Il2CppStructArray_1_Byte_String_Encoding_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_toBytes_Private_Static_Il2CppStructArray_1_Byte_Char_Encoding_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_encodeText_Private_Static_Int32_String_Int32_Int32_StringBuilder_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_encodeBinary_Private_Static_Void_Il2CppStructArray_1_Byte_Int32_Int32_Int32_StringBuilder_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_encodeNumeric_Private_Static_Void_String_Int32_Int32_StringBuilder_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isDigit_Private_Static_Boolean_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isAlphaUpper_Private_Static_Boolean_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isAlphaLower_Private_Static_Boolean_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isMixed_Private_Static_Boolean_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isPunctuation_Private_Static_Boolean_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isText_Private_Static_Boolean_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_determineConsecutiveDigitCount_Private_Static_Int32_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_determineConsecutiveTextCount_Private_Static_Int32_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_determineConsecutiveBinaryCount_Private_Static_Int32_String_Il2CppStructArray_1_Byte_Int32_Encoding_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_encodingECI_Private_Static_Void_Int32_StringBuilder_0;

	public unsafe static Il2CppStructArray<sbyte> TEXT_MIXED_RAW
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TEXT_MIXED_RAW, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<sbyte>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TEXT_MIXED_RAW, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<sbyte> TEXT_PUNCTUATION_RAW
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TEXT_PUNCTUATION_RAW, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<sbyte>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TEXT_PUNCTUATION_RAW, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<sbyte> MIXED
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MIXED, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<sbyte>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MIXED, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<sbyte> PUNCTUATION
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PUNCTUATION, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<sbyte>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PUNCTUATION, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static string DEFAULT_ENCODING_NAME
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DEFAULT_ENCODING_NAME, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DEFAULT_ENCODING_NAME, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	static PDF417HighLevelEncoder()
	{
		Il2CppClassPointerStore<PDF417HighLevelEncoder>.NativeClassPtr = IL2CPP.GetIl2CppClass("zxing.unity.dll", "ZXing.PDF417.Internal", "PDF417HighLevelEncoder");
		NativeFieldInfoPtr_TEXT_MIXED_RAW = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PDF417HighLevelEncoder>.NativeClassPtr, "TEXT_MIXED_RAW");
		NativeFieldInfoPtr_TEXT_PUNCTUATION_RAW = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PDF417HighLevelEncoder>.NativeClassPtr, "TEXT_PUNCTUATION_RAW");
		NativeFieldInfoPtr_MIXED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PDF417HighLevelEncoder>.NativeClassPtr, "MIXED");
		NativeFieldInfoPtr_PUNCTUATION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PDF417HighLevelEncoder>.NativeClassPtr, "PUNCTUATION");
		NativeFieldInfoPtr_DEFAULT_ENCODING_NAME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PDF417HighLevelEncoder>.NativeClassPtr, "DEFAULT_ENCODING_NAME");
		NativeMethodInfoPtr_encodeHighLevel_Internal_Static_String_String_Compaction_Encoding_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PDF417HighLevelEncoder>.NativeClassPtr, 100663993);
		NativeMethodInfoPtr_getEncoder_Private_Static_Encoding_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PDF417HighLevelEncoder>.NativeClassPtr, 100663994);
		NativeMethodInfoPtr_toBytes_Private_Static_Il2CppStructArray_1_Byte_String_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PDF417HighLevelEncoder>.NativeClassPtr, 100663995);
		NativeMethodInfoPtr_toBytes_Private_Static_Il2CppStructArray_1_Byte_Char_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PDF417HighLevelEncoder>.NativeClassPtr, 100663996);
		NativeMethodInfoPtr_encodeText_Private_Static_Int32_String_Int32_Int32_StringBuilder_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PDF417HighLevelEncoder>.NativeClassPtr, 100663997);
		NativeMethodInfoPtr_encodeBinary_Private_Static_Void_Il2CppStructArray_1_Byte_Int32_Int32_Int32_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PDF417HighLevelEncoder>.NativeClassPtr, 100663998);
		NativeMethodInfoPtr_encodeNumeric_Private_Static_Void_String_Int32_Int32_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PDF417HighLevelEncoder>.NativeClassPtr, 100663999);
		NativeMethodInfoPtr_isDigit_Private_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PDF417HighLevelEncoder>.NativeClassPtr, 100664000);
		NativeMethodInfoPtr_isAlphaUpper_Private_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PDF417HighLevelEncoder>.NativeClassPtr, 100664001);
		NativeMethodInfoPtr_isAlphaLower_Private_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PDF417HighLevelEncoder>.NativeClassPtr, 100664002);
		NativeMethodInfoPtr_isMixed_Private_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PDF417HighLevelEncoder>.NativeClassPtr, 100664003);
		NativeMethodInfoPtr_isPunctuation_Private_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PDF417HighLevelEncoder>.NativeClassPtr, 100664004);
		NativeMethodInfoPtr_isText_Private_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PDF417HighLevelEncoder>.NativeClassPtr, 100664005);
		NativeMethodInfoPtr_determineConsecutiveDigitCount_Private_Static_Int32_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PDF417HighLevelEncoder>.NativeClassPtr, 100664006);
		NativeMethodInfoPtr_determineConsecutiveTextCount_Private_Static_Int32_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PDF417HighLevelEncoder>.NativeClassPtr, 100664007);
		NativeMethodInfoPtr_determineConsecutiveBinaryCount_Private_Static_Int32_String_Il2CppStructArray_1_Byte_Int32_Encoding_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PDF417HighLevelEncoder>.NativeClassPtr, 100664008);
		NativeMethodInfoPtr_encodingECI_Private_Static_Void_Int32_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PDF417HighLevelEncoder>.NativeClassPtr, 100664009);
	}

	[CallerCount(12)]
	[CachedScanResults(RefRangeStart = 1419837, RefRangeEnd = 1419849, XrefRangeStart = 1419748, XrefRangeEnd = 1419837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string encodeHighLevel(string msg, Compaction compaction, Encoding encoding, bool disableEci)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(msg);
		*(Compaction**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &compaction;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)encoding);
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &disableEci;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_encodeHighLevel_Internal_Static_String_String_Compaction_Encoding_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1419858, RefRangeEnd = 1419861, XrefRangeStart = 1419849, XrefRangeEnd = 1419858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Encoding getEncoder(Encoding encoding)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)encoding);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getEncoder_Private_Static_Encoding_Encoding_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Encoding>(intPtr2) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1419866, RefRangeEnd = 1419870, XrefRangeStart = 1419861, XrefRangeEnd = 1419866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<byte> toBytes(string msg, Encoding encoding)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(msg);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)encoding);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_toBytes_Private_Static_Il2CppStructArray_1_Byte_String_Encoding_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1419870, XrefRangeEnd = 1419907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<byte> toBytes(char msg, Encoding encoding)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&msg);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)encoding);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_toBytes_Private_Static_Il2CppStructArray_1_Byte_Char_Encoding_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1419978, RefRangeEnd = 1419980, XrefRangeStart = 1419907, XrefRangeEnd = 1419978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int encodeText(string msg, int startpos, int count, StringBuilder sb, int initialSubmode)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(msg);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &startpos;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sb);
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &initialSubmode;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_encodeText_Private_Static_Int32_String_Int32_Int32_StringBuilder_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1419989, RefRangeEnd = 1419991, XrefRangeStart = 1419980, XrefRangeEnd = 1419989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void encodeBinary(Il2CppStructArray<byte> bytes, int startpos, int count, int startmode, StringBuilder sb)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bytes);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &startpos;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &startmode;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sb);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_encodeBinary_Private_Static_Void_Il2CppStructArray_1_Byte_Int32_Int32_Int32_StringBuilder_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1420024, RefRangeEnd = 1420026, XrefRangeStart = 1419991, XrefRangeEnd = 1420024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void encodeNumeric(string msg, int startpos, int count, StringBuilder sb)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(msg);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &startpos;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sb);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_encodeNumeric_Private_Static_Void_String_Int32_Int32_StringBuilder_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe static bool isDigit(char ch)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&ch);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isDigit_Private_Static_Boolean_Char_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static bool isAlphaUpper(char ch)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&ch);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isAlphaUpper_Private_Static_Boolean_Char_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static bool isAlphaLower(char ch)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&ch);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isAlphaLower_Private_Static_Boolean_Char_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1420030, RefRangeEnd = 1420032, XrefRangeStart = 1420026, XrefRangeEnd = 1420030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool isMixed(char ch)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&ch);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isMixed_Private_Static_Boolean_Char_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1420036, RefRangeEnd = 1420037, XrefRangeStart = 1420032, XrefRangeEnd = 1420036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool isPunctuation(char ch)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&ch);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isPunctuation_Private_Static_Boolean_Char_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static bool isText(char ch)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&ch);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isText_Private_Static_Boolean_Char_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1420037, XrefRangeEnd = 1420042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int determineConsecutiveDigitCount(string msg, int startpos)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(msg);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &startpos;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_determineConsecutiveDigitCount_Private_Static_Int32_String_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1420047, RefRangeEnd = 1420048, XrefRangeStart = 1420042, XrefRangeEnd = 1420047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int determineConsecutiveTextCount(string msg, int startpos)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(msg);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &startpos;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_determineConsecutiveTextCount_Private_Static_Int32_String_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1420056, RefRangeEnd = 1420057, XrefRangeStart = 1420048, XrefRangeEnd = 1420056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int determineConsecutiveBinaryCount(string msg, Il2CppStructArray<byte> bytes, int startpos, Encoding encoding, out int byteCount)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(msg);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bytes);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &startpos;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)encoding);
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref byteCount);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_determineConsecutiveBinaryCount_Private_Static_Int32_String_Il2CppStructArray_1_Byte_Int32_Encoding_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1420057, XrefRangeEnd = 1420059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void encodingECI(int eci, StringBuilder sb)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&eci);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sb);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_encodingECI_Private_Static_Void_Int32_StringBuilder_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public PDF417HighLevelEncoder(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
