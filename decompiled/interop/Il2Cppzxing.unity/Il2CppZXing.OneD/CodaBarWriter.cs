using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppZXing.OneD;

public sealed class CodaBarWriter : OneDimensionalCodeWriter
{
	private static readonly IntPtr NativeFieldInfoPtr_START_END_CHARS;

	private static readonly IntPtr NativeFieldInfoPtr_ALT_START_END_CHARS;

	private static readonly IntPtr NativeFieldInfoPtr_CHARS_WHICH_ARE_TEN_LENGTH_EACH_AFTER_DECODED;

	private static readonly IntPtr NativeFieldInfoPtr_DEFAULT_GUARD;

	private static readonly IntPtr NativeFieldInfoPtr_supportedWriteFormats;

	private static readonly IntPtr NativeMethodInfoPtr_get_SupportedWriteFormats_Protected_Virtual_get_IList_1_BarcodeFormat_0;

	private static readonly IntPtr NativeMethodInfoPtr_encode_Public_Virtual_Il2CppStructArray_1_Boolean_String_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static Il2CppStructArray<char> START_END_CHARS
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_START_END_CHARS, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_START_END_CHARS, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<char> ALT_START_END_CHARS
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ALT_START_END_CHARS, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ALT_START_END_CHARS, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<char> CHARS_WHICH_ARE_TEN_LENGTH_EACH_AFTER_DECODED
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CHARS_WHICH_ARE_TEN_LENGTH_EACH_AFTER_DECODED, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CHARS_WHICH_ARE_TEN_LENGTH_EACH_AFTER_DECODED, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static char DEFAULT_GUARD
	{
		get
		{
			Unsafe.SkipInit(out char result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DEFAULT_GUARD, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DEFAULT_GUARD, (void*)(&value));
		}
	}

	public unsafe static IList<BarcodeFormat> supportedWriteFormats
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_supportedWriteFormats, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<IList<BarcodeFormat>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_supportedWriteFormats, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe override IList<BarcodeFormat> SupportedWriteFormats
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1420450, XrefRangeEnd = 1420454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_SupportedWriteFormats_Protected_Virtual_get_IList_1_BarcodeFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<IList<BarcodeFormat>>(intPtr2) : null;
		}
	}

	static CodaBarWriter()
	{
		Il2CppClassPointerStore<CodaBarWriter>.NativeClassPtr = IL2CPP.GetIl2CppClass("zxing.unity.dll", "ZXing.OneD", "CodaBarWriter");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CodaBarWriter>.NativeClassPtr);
		NativeFieldInfoPtr_START_END_CHARS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodaBarWriter>.NativeClassPtr, "START_END_CHARS");
		NativeFieldInfoPtr_ALT_START_END_CHARS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodaBarWriter>.NativeClassPtr, "ALT_START_END_CHARS");
		NativeFieldInfoPtr_CHARS_WHICH_ARE_TEN_LENGTH_EACH_AFTER_DECODED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodaBarWriter>.NativeClassPtr, "CHARS_WHICH_ARE_TEN_LENGTH_EACH_AFTER_DECODED");
		NativeFieldInfoPtr_DEFAULT_GUARD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodaBarWriter>.NativeClassPtr, "DEFAULT_GUARD");
		NativeFieldInfoPtr_supportedWriteFormats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CodaBarWriter>.NativeClassPtr, "supportedWriteFormats");
		NativeMethodInfoPtr_get_SupportedWriteFormats_Protected_Virtual_get_IList_1_BarcodeFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodaBarWriter>.NativeClassPtr, 100664050);
		NativeMethodInfoPtr_encode_Public_Virtual_Il2CppStructArray_1_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodaBarWriter>.NativeClassPtr, 100664051);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CodaBarWriter>.NativeClassPtr, 100664052);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1420454, XrefRangeEnd = 1420530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override Il2CppStructArray<bool> encode(string contents)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(contents);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_encode_Public_Virtual_Il2CppStructArray_1_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1420534, RefRangeEnd = 1420535, XrefRangeStart = 1420530, XrefRangeEnd = 1420534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CodaBarWriter()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CodaBarWriter>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public CodaBarWriter(IntPtr pointer)
		: base(pointer)
	{
	}
}
