using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppZXing.OneD;

public sealed class Code39Writer : OneDimensionalCodeWriter
{
	private static readonly IntPtr NativeFieldInfoPtr_supportedWriteFormats;

	private static readonly IntPtr NativeMethodInfoPtr_get_SupportedWriteFormats_Protected_Virtual_get_IList_1_BarcodeFormat_0;

	private static readonly IntPtr NativeMethodInfoPtr_encode_Public_Virtual_Il2CppStructArray_1_Boolean_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_toIntArray_Private_Static_Void_Int32_Il2CppStructArray_1_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_tryToConvertToExtendedMode_Private_Static_String_String_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1421031, XrefRangeEnd = 1421035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	static Code39Writer()
	{
		Il2CppClassPointerStore<Code39Writer>.NativeClassPtr = IL2CPP.GetIl2CppClass("zxing.unity.dll", "ZXing.OneD", "Code39Writer");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Code39Writer>.NativeClassPtr);
		NativeFieldInfoPtr_supportedWriteFormats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Code39Writer>.NativeClassPtr, "supportedWriteFormats");
		NativeMethodInfoPtr_get_SupportedWriteFormats_Protected_Virtual_get_IList_1_BarcodeFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Code39Writer>.NativeClassPtr, 100664073);
		NativeMethodInfoPtr_encode_Public_Virtual_Il2CppStructArray_1_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Code39Writer>.NativeClassPtr, 100664074);
		NativeMethodInfoPtr_toIntArray_Private_Static_Void_Int32_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Code39Writer>.NativeClassPtr, 100664075);
		NativeMethodInfoPtr_tryToConvertToExtendedMode_Private_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Code39Writer>.NativeClassPtr, 100664076);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Code39Writer>.NativeClassPtr, 100664077);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1421035, XrefRangeEnd = 1421080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(0)]
	public unsafe static void toIntArray(int a, Il2CppStructArray<int> toReturn)
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&a);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)toReturn);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_toIntArray_Private_Static_Void_Int32_Il2CppStructArray_1_Int32_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1421080, XrefRangeEnd = 1421135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string tryToConvertToExtendedMode(string contents)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(contents);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_tryToConvertToExtendedMode_Private_Static_String_String_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1421139, RefRangeEnd = 1421140, XrefRangeStart = 1421135, XrefRangeEnd = 1421139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Code39Writer()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Code39Writer>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public Code39Writer(IntPtr pointer)
		: base(pointer)
	{
	}
}
