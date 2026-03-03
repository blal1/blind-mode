using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppZXing.Common;

public static class StringUtils : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_SHIFT_JIS;

	private static readonly System.IntPtr NativeFieldInfoPtr_GB2312;

	private static readonly System.IntPtr NativeFieldInfoPtr_ASSUME_SHIFT_JIS;

	private static readonly System.IntPtr NativeMethodInfoPtr_guessEncoding_Public_Static_String_Il2CppStructArray_1_Byte_IDictionary_2_DecodeHintType_Object_0;

	public unsafe static string SHIFT_JIS
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SHIFT_JIS, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SHIFT_JIS, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string GB2312
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_GB2312, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_GB2312, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static bool ASSUME_SHIFT_JIS
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ASSUME_SHIFT_JIS, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ASSUME_SHIFT_JIS, (void*)(&value));
		}
	}

	static StringUtils()
	{
		Il2CppClassPointerStore<StringUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("zxing.unity.dll", "ZXing.Common", "StringUtils");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StringUtils>.NativeClassPtr);
		NativeFieldInfoPtr_SHIFT_JIS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringUtils>.NativeClassPtr, "SHIFT_JIS");
		NativeFieldInfoPtr_GB2312 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringUtils>.NativeClassPtr, "GB2312");
		NativeFieldInfoPtr_ASSUME_SHIFT_JIS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringUtils>.NativeClassPtr, "ASSUME_SHIFT_JIS");
		NativeMethodInfoPtr_guessEncoding_Public_Static_String_Il2CppStructArray_1_Byte_IDictionary_2_DecodeHintType_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringUtils>.NativeClassPtr, 100664789);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1429458, RefRangeEnd = 1429459, XrefRangeStart = 1429449, XrefRangeEnd = 1429458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string guessEncoding(Il2CppStructArray<byte> bytes, IDictionary<DecodeHintType, Il2CppSystem.Object> hints)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bytes);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hints);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_guessEncoding_Public_Static_String_Il2CppStructArray_1_Byte_IDictionary_2_DecodeHintType_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	public StringUtils(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
