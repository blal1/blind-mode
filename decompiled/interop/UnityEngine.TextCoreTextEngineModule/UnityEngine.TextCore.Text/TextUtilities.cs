using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.TextCore.Text;

public static class TextUtilities : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_ToUpperFast_Internal_Static_Char_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCodeCaseInSensitive_Public_Static_Int32_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTextFontWeightIndex_Internal_Static_Int32_TextFontWeight_0;

	public const string k_LookupStringL = "-------------------------------- !-#$%&-()*+,-./0123456789:;<=>?@abcdefghijklmnopqrstuvwxyz[-]^_`abcdefghijklmnopqrstuvwxyz{|}~-";

	public const string k_LookupStringU = "-------------------------------- !-#$%&-()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[-]^_`ABCDEFGHIJKLMNOPQRSTUVWXYZ{|}~-";

	static TextUtilities()
	{
		Il2CppClassPointerStore<TextUtilities>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TextCoreTextEngineModule.dll", "UnityEngine.TextCore.Text", "TextUtilities");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextUtilities>.NativeClassPtr);
		NativeMethodInfoPtr_ToUpperFast_Internal_Static_Char_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextUtilities>.NativeClassPtr, 100664040);
		NativeMethodInfoPtr_GetHashCodeCaseInSensitive_Public_Static_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextUtilities>.NativeClassPtr, 100664041);
		NativeMethodInfoPtr_GetTextFontWeightIndex_Internal_Static_Int32_TextFontWeight_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextUtilities>.NativeClassPtr, 100664042);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1284771, XrefRangeEnd = 1284774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static char ToUpperFast(char c)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&c);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToUpperFast_Internal_Static_Char_Char_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(char*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(15)]
	[CachedScanResults(RefRangeStart = 1284779, RefRangeEnd = 1284794, XrefRangeStart = 1284774, XrefRangeEnd = 1284779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetHashCodeCaseInSensitive(string s)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHashCodeCaseInSensitive_Public_Static_Int32_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 1284794, RefRangeEnd = 1284802, XrefRangeStart = 1284794, XrefRangeEnd = 1284794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetTextFontWeightIndex(TextFontWeight fontWeight)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&fontWeight);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTextFontWeightIndex_Internal_Static_Int32_TextFontWeight_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public TextUtilities(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public static void ResizeArray<T>(ref Il2CppArrayBase<T> array)
	{
		int newSize = NextPowerOfTwo(((Il2CppArrayBase)array).Length);
		Il2CppSystem.Array.Resize(ref array, newSize);
	}

	public static void ResizeArray<T>(ref Il2CppArrayBase<T> array, int size)
	{
		size = NextPowerOfTwo(size);
		Il2CppSystem.Array.Resize(ref array, size);
	}

	public static int NextPowerOfTwo(int v)
	{
		v |= v >> 16;
		v |= v >> 8;
		v |= v >> 4;
		v |= v >> 2;
		v |= v >> 1;
		return v + 1;
	}

	public static char ToLowerFast(char c)
	{
		if (c > "-------------------------------- !-#$%&-()*+,-./0123456789:;<=>?@abcdefghijklmnopqrstuvwxyz[-]^_`abcdefghijklmnopqrstuvwxyz{|}~-".Length - 1)
		{
			return c;
		}
		return "-------------------------------- !-#$%&-()*+,-./0123456789:;<=>?@abcdefghijklmnopqrstuvwxyz[-]^_`abcdefghijklmnopqrstuvwxyz{|}~-"[c];
	}

	public static uint ToUpperASCIIFast(uint c)
	{
		if (c > "-------------------------------- !-#$%&-()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[-]^_`ABCDEFGHIJKLMNOPQRSTUVWXYZ{|}~-".Length - 1)
		{
			return c;
		}
		return "-------------------------------- !-#$%&-()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[-]^_`ABCDEFGHIJKLMNOPQRSTUVWXYZ{|}~-"[(int)c];
	}

	public static uint ToLowerASCIIFast(uint c)
	{
		if (c > "-------------------------------- !-#$%&-()*+,-./0123456789:;<=>?@abcdefghijklmnopqrstuvwxyz[-]^_`abcdefghijklmnopqrstuvwxyz{|}~-".Length - 1)
		{
			return c;
		}
		return "-------------------------------- !-#$%&-()*+,-./0123456789:;<=>?@abcdefghijklmnopqrstuvwxyz[-]^_`abcdefghijklmnopqrstuvwxyz{|}~-"[(int)c];
	}

	public static int GetHashCodeCaseSensitive(string s)
	{
		int num = 0;
		for (int i = 0; i < s.Length; i++)
		{
			num = ((num << 5) + num) ^ s[i];
		}
		return num;
	}

	public static int GetHashCode(string s)
	{
		if (Il2CppSystem.String.IsNullOrEmpty(s))
		{
			return 0;
		}
		int num = 0;
		for (int i = 0; i < s.Length; i++)
		{
			num = ((num << 5) + num) ^ ToUpperFast(s[i]);
		}
		return num;
	}

	public static int GetSimpleHashCode(string s)
	{
		int num = 0;
		for (int i = 0; i < s.Length; i++)
		{
			num = ((num << 5) + num) ^ s[i];
		}
		return num;
	}

	public static uint GetSimpleHashCodeLowercase(string s)
	{
		uint num = 0u;
		for (int i = 0; i < s.Length; i++)
		{
			num = ((num << 5) + num) ^ ToLowerFast(s[i]);
		}
		return num;
	}

	public static uint ConvertToUTF32(uint highSurrogate, uint lowSurrogate)
	{
		return (highSurrogate - 55296) * 1024 + (lowSurrogate - 56320 + 65536);
	}

	public static uint ReadUTF16(Il2CppStructArray<uint> text, int index)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public static uint ReadUTF32(Il2CppStructArray<uint> text, int index)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public static uint HexToInt(char hex)
	{
		return hex switch
		{
			'0' => 0u, 
			'1' => 1u, 
			'2' => 2u, 
			'3' => 3u, 
			'4' => 4u, 
			'5' => 5u, 
			'6' => 6u, 
			'7' => 7u, 
			'8' => 8u, 
			'9' => 9u, 
			'A' => 10u, 
			'B' => 11u, 
			'C' => 12u, 
			'D' => 13u, 
			'E' => 14u, 
			'F' => 15u, 
			'a' => 10u, 
			'b' => 11u, 
			'c' => 12u, 
			'd' => 13u, 
			'e' => 14u, 
			'f' => 15u, 
			_ => 15u, 
		};
	}

	public static uint StringHexToInt(string s)
	{
		uint num = 0u;
		int length = s.Length;
		for (int i = 0; i < length; i++)
		{
			num += HexToInt(s[i]) * (uint)Mathf.Pow(16f, length - 1 - i);
		}
		return num;
	}

	public static string UintToString(List<uint> unicodes)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}
}
