using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppZXing.Common;

namespace Il2CppZXing.OneD.RSS.Expanded.Decoders;

public sealed class AI01393xDecoder : AI01decoder
{
	private static readonly IntPtr NativeFieldInfoPtr_HEADER_SIZE;

	private static readonly IntPtr NativeFieldInfoPtr_LAST_DIGIT_SIZE;

	private static readonly IntPtr NativeFieldInfoPtr_FIRST_THREE_DIGITS_SIZE;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_BitArray_0;

	private static readonly IntPtr NativeMethodInfoPtr_parseInformation_Public_Virtual_String_0;

	public unsafe static int HEADER_SIZE
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_HEADER_SIZE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_HEADER_SIZE, (void*)(&value));
		}
	}

	public unsafe static int LAST_DIGIT_SIZE
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LAST_DIGIT_SIZE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LAST_DIGIT_SIZE, (void*)(&value));
		}
	}

	public unsafe static int FIRST_THREE_DIGITS_SIZE
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_FIRST_THREE_DIGITS_SIZE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_FIRST_THREE_DIGITS_SIZE, (void*)(&value));
		}
	}

	static AI01393xDecoder()
	{
		Il2CppClassPointerStore<AI01393xDecoder>.NativeClassPtr = IL2CPP.GetIl2CppClass("zxing.unity.dll", "ZXing.OneD.RSS.Expanded.Decoders", "AI01393xDecoder");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AI01393xDecoder>.NativeClassPtr);
		NativeFieldInfoPtr_HEADER_SIZE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AI01393xDecoder>.NativeClassPtr, "HEADER_SIZE");
		NativeFieldInfoPtr_LAST_DIGIT_SIZE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AI01393xDecoder>.NativeClassPtr, "LAST_DIGIT_SIZE");
		NativeFieldInfoPtr_FIRST_THREE_DIGITS_SIZE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AI01393xDecoder>.NativeClassPtr, "FIRST_THREE_DIGITS_SIZE");
		NativeMethodInfoPtr__ctor_Internal_Void_BitArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AI01393xDecoder>.NativeClassPtr, 100664348);
		NativeMethodInfoPtr_parseInformation_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AI01393xDecoder>.NativeClassPtr, 100664349);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1424990, XrefRangeEnd = 1424994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AI01393xDecoder(BitArray information)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AI01393xDecoder>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)information);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_BitArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1424994, XrefRangeEnd = 1425041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override string parseInformation()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_parseInformation_Public_Virtual_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	public AI01393xDecoder(IntPtr pointer)
		: base(pointer)
	{
	}
}
