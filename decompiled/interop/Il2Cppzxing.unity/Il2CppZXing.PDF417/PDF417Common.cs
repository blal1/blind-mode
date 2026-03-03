using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppZXing.PDF417;

public static class PDF417Common : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_INVALID_CODEWORD;

	private static readonly System.IntPtr NativeFieldInfoPtr_NUMBER_OF_CODEWORDS;

	private static readonly System.IntPtr NativeFieldInfoPtr_MAX_CODEWORDS_IN_BARCODE;

	private static readonly System.IntPtr NativeFieldInfoPtr_MIN_ROWS_IN_BARCODE;

	private static readonly System.IntPtr NativeFieldInfoPtr_MAX_ROWS_IN_BARCODE;

	private static readonly System.IntPtr NativeFieldInfoPtr_MODULES_IN_CODEWORD;

	private static readonly System.IntPtr NativeFieldInfoPtr_MODULES_IN_STOP_PATTERN;

	private static readonly System.IntPtr NativeFieldInfoPtr_BARS_IN_MODULE;

	private static readonly System.IntPtr NativeFieldInfoPtr_EMPTY_INT_ARRAY;

	private static readonly System.IntPtr NativeFieldInfoPtr_SYMBOL_TABLE;

	private static readonly System.IntPtr NativeFieldInfoPtr_CODEWORD_TABLE;

	private static readonly System.IntPtr NativeMethodInfoPtr_getCodeword_Public_Static_Int32_Int64_0;

	public unsafe static int INVALID_CODEWORD
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_INVALID_CODEWORD, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_INVALID_CODEWORD, (void*)(&value));
		}
	}

	public unsafe static int NUMBER_OF_CODEWORDS
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_NUMBER_OF_CODEWORDS, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_NUMBER_OF_CODEWORDS, (void*)(&value));
		}
	}

	public unsafe static int MAX_CODEWORDS_IN_BARCODE
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MAX_CODEWORDS_IN_BARCODE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MAX_CODEWORDS_IN_BARCODE, (void*)(&value));
		}
	}

	public unsafe static int MIN_ROWS_IN_BARCODE
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MIN_ROWS_IN_BARCODE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MIN_ROWS_IN_BARCODE, (void*)(&value));
		}
	}

	public unsafe static int MAX_ROWS_IN_BARCODE
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MAX_ROWS_IN_BARCODE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MAX_ROWS_IN_BARCODE, (void*)(&value));
		}
	}

	public unsafe static int MODULES_IN_CODEWORD
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MODULES_IN_CODEWORD, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MODULES_IN_CODEWORD, (void*)(&value));
		}
	}

	public unsafe static int MODULES_IN_STOP_PATTERN
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MODULES_IN_STOP_PATTERN, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MODULES_IN_STOP_PATTERN, (void*)(&value));
		}
	}

	public unsafe static int BARS_IN_MODULE
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BARS_IN_MODULE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BARS_IN_MODULE, (void*)(&value));
		}
	}

	public unsafe static Il2CppStructArray<int> EMPTY_INT_ARRAY
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_EMPTY_INT_ARRAY, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_EMPTY_INT_ARRAY, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<int> SYMBOL_TABLE
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SYMBOL_TABLE, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SYMBOL_TABLE, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<int> CODEWORD_TABLE
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CODEWORD_TABLE, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CODEWORD_TABLE, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static PDF417Common()
	{
		Il2CppClassPointerStore<PDF417Common>.NativeClassPtr = IL2CPP.GetIl2CppClass("zxing.unity.dll", "ZXing.PDF417", "PDF417Common");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PDF417Common>.NativeClassPtr);
		NativeFieldInfoPtr_INVALID_CODEWORD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PDF417Common>.NativeClassPtr, "INVALID_CODEWORD");
		NativeFieldInfoPtr_NUMBER_OF_CODEWORDS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PDF417Common>.NativeClassPtr, "NUMBER_OF_CODEWORDS");
		NativeFieldInfoPtr_MAX_CODEWORDS_IN_BARCODE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PDF417Common>.NativeClassPtr, "MAX_CODEWORDS_IN_BARCODE");
		NativeFieldInfoPtr_MIN_ROWS_IN_BARCODE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PDF417Common>.NativeClassPtr, "MIN_ROWS_IN_BARCODE");
		NativeFieldInfoPtr_MAX_ROWS_IN_BARCODE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PDF417Common>.NativeClassPtr, "MAX_ROWS_IN_BARCODE");
		NativeFieldInfoPtr_MODULES_IN_CODEWORD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PDF417Common>.NativeClassPtr, "MODULES_IN_CODEWORD");
		NativeFieldInfoPtr_MODULES_IN_STOP_PATTERN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PDF417Common>.NativeClassPtr, "MODULES_IN_STOP_PATTERN");
		NativeFieldInfoPtr_BARS_IN_MODULE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PDF417Common>.NativeClassPtr, "BARS_IN_MODULE");
		NativeFieldInfoPtr_EMPTY_INT_ARRAY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PDF417Common>.NativeClassPtr, "EMPTY_INT_ARRAY");
		NativeFieldInfoPtr_SYMBOL_TABLE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PDF417Common>.NativeClassPtr, "SYMBOL_TABLE");
		NativeFieldInfoPtr_CODEWORD_TABLE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PDF417Common>.NativeClassPtr, "CODEWORD_TABLE");
		NativeMethodInfoPtr_getCodeword_Public_Static_Int32_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PDF417Common>.NativeClassPtr, 100663773);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1417748, RefRangeEnd = 1417750, XrefRangeStart = 1417738, XrefRangeEnd = 1417748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int getCodeword(long symbol)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&symbol);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_getCodeword_Public_Static_Int32_Int64_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public PDF417Common(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
