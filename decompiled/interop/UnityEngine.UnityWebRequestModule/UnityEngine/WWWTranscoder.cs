using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Text;

namespace UnityEngine;

public class WWWTranscoder : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_ucHexChars;

	private static readonly System.IntPtr NativeFieldInfoPtr_lcHexChars;

	private static readonly System.IntPtr NativeFieldInfoPtr_urlEscapeChar;

	private static readonly System.IntPtr NativeFieldInfoPtr_urlSpace;

	private static readonly System.IntPtr NativeFieldInfoPtr_dataSpace;

	private static readonly System.IntPtr NativeFieldInfoPtr_urlForbidden;

	private static readonly System.IntPtr NativeFieldInfoPtr_qpEscapeChar;

	private static readonly System.IntPtr NativeFieldInfoPtr_qpSpace;

	private static readonly System.IntPtr NativeFieldInfoPtr_qpForbidden;

	private static readonly System.IntPtr NativeMethodInfoPtr_Hex2Byte_Private_Static_Byte_Il2CppStructArray_1_Byte_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_URLDecode_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ByteSubArrayEquals_Private_Static_Boolean_Il2CppStructArray_1_Byte_Int32_Il2CppStructArray_1_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Decode_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Byte_Il2CppStructArray_1_Byte_0;

	public unsafe static Il2CppStructArray<byte> ucHexChars
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ucHexChars, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ucHexChars, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<byte> lcHexChars
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_lcHexChars, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_lcHexChars, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static byte urlEscapeChar
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out byte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_urlEscapeChar, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_urlEscapeChar, (void*)(&value));
		}
	}

	public unsafe static Il2CppStructArray<byte> urlSpace
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_urlSpace, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_urlSpace, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<byte> dataSpace
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_dataSpace, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_dataSpace, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<byte> urlForbidden
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_urlForbidden, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_urlForbidden, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static byte qpEscapeChar
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out byte result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_qpEscapeChar, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_qpEscapeChar, (void*)(&value));
		}
	}

	public unsafe static Il2CppStructArray<byte> qpSpace
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_qpSpace, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_qpSpace, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<byte> qpForbidden
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_qpForbidden, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_qpForbidden, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static WWWTranscoder()
	{
		Il2CppClassPointerStore<WWWTranscoder>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UnityWebRequestModule.dll", "UnityEngine", "WWWTranscoder");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WWWTranscoder>.NativeClassPtr);
		NativeFieldInfoPtr_ucHexChars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WWWTranscoder>.NativeClassPtr, "ucHexChars");
		NativeFieldInfoPtr_lcHexChars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WWWTranscoder>.NativeClassPtr, "lcHexChars");
		NativeFieldInfoPtr_urlEscapeChar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WWWTranscoder>.NativeClassPtr, "urlEscapeChar");
		NativeFieldInfoPtr_urlSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WWWTranscoder>.NativeClassPtr, "urlSpace");
		NativeFieldInfoPtr_dataSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WWWTranscoder>.NativeClassPtr, "dataSpace");
		NativeFieldInfoPtr_urlForbidden = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WWWTranscoder>.NativeClassPtr, "urlForbidden");
		NativeFieldInfoPtr_qpEscapeChar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WWWTranscoder>.NativeClassPtr, "qpEscapeChar");
		NativeFieldInfoPtr_qpSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WWWTranscoder>.NativeClassPtr, "qpSpace");
		NativeFieldInfoPtr_qpForbidden = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WWWTranscoder>.NativeClassPtr, "qpForbidden");
		NativeMethodInfoPtr_Hex2Byte_Private_Static_Byte_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WWWTranscoder>.NativeClassPtr, 100663304);
		NativeMethodInfoPtr_URLDecode_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WWWTranscoder>.NativeClassPtr, 100663305);
		NativeMethodInfoPtr_ByteSubArrayEquals_Private_Static_Boolean_Il2CppStructArray_1_Byte_Int32_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WWWTranscoder>.NativeClassPtr, 100663306);
		NativeMethodInfoPtr_Decode_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WWWTranscoder>.NativeClassPtr, 100663307);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1408154, XrefRangeEnd = 1408156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static byte Hex2Byte(Il2CppStructArray<byte> b, int offset)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)b);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &offset;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Hex2Byte_Private_Static_Byte_Il2CppStructArray_1_Byte_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(byte*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1408156, XrefRangeEnd = 1408210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<byte> URLDecode(Il2CppStructArray<byte> toEncode)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)toEncode);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_URLDecode_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1408210, XrefRangeEnd = 1408211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool ByteSubArrayEquals(Il2CppStructArray<byte> array, int index, Il2CppStructArray<byte> comperand)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)array);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)comperand);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ByteSubArrayEquals_Private_Static_Boolean_Il2CppStructArray_1_Byte_Int32_Il2CppStructArray_1_Byte_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1408235, RefRangeEnd = 1408237, XrefRangeStart = 1408211, XrefRangeEnd = 1408235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<byte> Decode(Il2CppStructArray<byte> input, byte escapeChar, Il2CppStructArray<byte> space)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)input);
		*(byte**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &escapeChar;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)space);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Decode_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Byte_Il2CppStructArray_1_Byte_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
	}

	public WWWTranscoder(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public static void Byte2Hex(byte b, Il2CppStructArray<byte> hexChars, out byte byte0, out byte byte1)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public static string URLEncode(string toEncode)
	{
		return URLEncode(toEncode, Encoding.UTF8);
	}

	public static string URLEncode(string toEncode, Encoding e)
	{
		Il2CppStructArray<byte> val = Encode(e.GetBytes(toEncode), urlEscapeChar, urlSpace, urlForbidden, uppercase: false);
		return WWWForm.DefaultEncoding.GetString(val, 0, ((Il2CppArrayBase)val).Length);
	}

	public static Il2CppStructArray<byte> URLEncode(Il2CppStructArray<byte> toEncode)
	{
		return Encode(toEncode, urlEscapeChar, urlSpace, urlForbidden, uppercase: false);
	}

	public static string DataEncode(string toEncode)
	{
		return DataEncode(toEncode, Encoding.UTF8);
	}

	public static string DataEncode(string toEncode, Encoding e)
	{
		Il2CppStructArray<byte> val = Encode(e.GetBytes(toEncode), urlEscapeChar, dataSpace, urlForbidden, uppercase: false);
		return WWWForm.DefaultEncoding.GetString(val, 0, ((Il2CppArrayBase)val).Length);
	}

	public static Il2CppStructArray<byte> DataEncode(Il2CppStructArray<byte> toEncode)
	{
		return Encode(toEncode, urlEscapeChar, dataSpace, urlForbidden, uppercase: false);
	}

	public static string QPEncode(string toEncode)
	{
		return QPEncode(toEncode, Encoding.UTF8);
	}

	public static string QPEncode(string toEncode, Encoding e)
	{
		Il2CppStructArray<byte> val = Encode(e.GetBytes(toEncode), qpEscapeChar, qpSpace, qpForbidden, uppercase: true);
		return WWWForm.DefaultEncoding.GetString(val, 0, ((Il2CppArrayBase)val).Length);
	}

	public static Il2CppStructArray<byte> QPEncode(Il2CppStructArray<byte> toEncode)
	{
		return Encode(toEncode, qpEscapeChar, qpSpace, qpForbidden, uppercase: true);
	}

	public static Il2CppStructArray<byte> Encode(Il2CppStructArray<byte> input, byte escapeChar, Il2CppStructArray<byte> space, Il2CppStructArray<byte> forbidden, bool uppercase)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public static bool ByteArrayContains(Il2CppStructArray<byte> array, byte b)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public static string URLDecode(string toEncode)
	{
		return URLDecode(toEncode, Encoding.UTF8);
	}

	public static string URLDecode(string toEncode, Encoding e)
	{
		Il2CppStructArray<byte> val = Decode(WWWForm.DefaultEncoding.GetBytes(toEncode), urlEscapeChar, urlSpace);
		return e.GetString(val, 0, ((Il2CppArrayBase)val).Length);
	}

	public static string DataDecode(string toDecode)
	{
		return DataDecode(toDecode, Encoding.UTF8);
	}

	public static string DataDecode(string toDecode, Encoding e)
	{
		Il2CppStructArray<byte> val = Decode(WWWForm.DefaultEncoding.GetBytes(toDecode), urlEscapeChar, dataSpace);
		return e.GetString(val, 0, ((Il2CppArrayBase)val).Length);
	}

	public static Il2CppStructArray<byte> DataDecode(Il2CppStructArray<byte> toDecode)
	{
		return Decode(toDecode, urlEscapeChar, dataSpace);
	}

	public static string QPDecode(string toEncode)
	{
		return QPDecode(toEncode, Encoding.UTF8);
	}

	public static string QPDecode(string toEncode, Encoding e)
	{
		Il2CppStructArray<byte> val = Decode(WWWForm.DefaultEncoding.GetBytes(toEncode), qpEscapeChar, qpSpace);
		return e.GetString(val, 0, ((Il2CppArrayBase)val).Length);
	}

	public static Il2CppStructArray<byte> QPDecode(Il2CppStructArray<byte> toEncode)
	{
		return Decode(toEncode, qpEscapeChar, qpSpace);
	}

	public static bool SevenBitClean(string s)
	{
		return SevenBitClean(s, Encoding.UTF8);
	}

	public unsafe static bool SevenBitClean(string s, Encoding e)
	{
		if (Il2CppSystem.String.IsNullOrEmpty(s))
		{
			return true;
		}
		int num = s.Length * 2;
		byte* ptr = stackalloc byte[(int)(uint)num];
		int bytes;
		fixed (string text = s)
		{
			char* ptr2 = (char*)(nuint)text;
			if (ptr2 != null)
			{
				ptr2 = (char*)((byte*)ptr2 + Il2CppSystem.Runtime.CompilerServices.RuntimeHelpers.OffsetToStringData);
			}
			bytes = e.GetBytes(ptr2, s.Length, ptr, num);
		}
		return SevenBitClean(ptr, bytes);
	}

	public unsafe static bool SevenBitClean(byte* input, int inputLength)
	{
		for (int i = 0; i < inputLength; i++)
		{
			if (input[i] < 32 || input[i] > 126)
			{
				return false;
			}
		}
		return true;
	}
}
