using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppZXing.Common;

namespace Il2CppZXing.OneD;

public sealed class Code128Writer : OneDimensionalCodeWriter
{
	[OriginalName("zxing.unity.dll", "", "CType")]
	public enum CType
	{
		UNCODABLE,
		ONE_DIGIT,
		TWO_DIGITS,
		FNC_1
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_forceCodesetB;

	private static readonly System.IntPtr NativeFieldInfoPtr_supportedWriteFormats;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_SupportedWriteFormats_Protected_Virtual_get_IList_1_BarcodeFormat_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_encode_Public_Virtual_BitMatrix_String_BarcodeFormat_Int32_Int32_IDictionary_2_EncodeHintType_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_encode_Public_Virtual_Il2CppStructArray_1_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_findCType_Private_Static_CType_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_chooseCode_Private_Int32_String_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe bool forceCodesetB
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceCodesetB);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceCodesetB)) = value;
		}
	}

	public unsafe static IList<BarcodeFormat> supportedWriteFormats
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_supportedWriteFormats, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IList<BarcodeFormat>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_supportedWriteFormats, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe override IList<BarcodeFormat> SupportedWriteFormats
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1420715, XrefRangeEnd = 1420719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_SupportedWriteFormats_Protected_Virtual_get_IList_1_BarcodeFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IList<BarcodeFormat>>(intPtr2) : null;
		}
	}

	static Code128Writer()
	{
		Il2CppClassPointerStore<Code128Writer>.NativeClassPtr = IL2CPP.GetIl2CppClass("zxing.unity.dll", "ZXing.OneD", "Code128Writer");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Code128Writer>.NativeClassPtr);
		NativeFieldInfoPtr_forceCodesetB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Code128Writer>.NativeClassPtr, "forceCodesetB");
		NativeFieldInfoPtr_supportedWriteFormats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Code128Writer>.NativeClassPtr, "supportedWriteFormats");
		NativeMethodInfoPtr_get_SupportedWriteFormats_Protected_Virtual_get_IList_1_BarcodeFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Code128Writer>.NativeClassPtr, 100664059);
		NativeMethodInfoPtr_encode_Public_Virtual_BitMatrix_String_BarcodeFormat_Int32_Int32_IDictionary_2_EncodeHintType_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Code128Writer>.NativeClassPtr, 100664060);
		NativeMethodInfoPtr_encode_Public_Virtual_Il2CppStructArray_1_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Code128Writer>.NativeClassPtr, 100664061);
		NativeMethodInfoPtr_findCType_Private_Static_CType_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Code128Writer>.NativeClassPtr, 100664062);
		NativeMethodInfoPtr_chooseCode_Private_Int32_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Code128Writer>.NativeClassPtr, 100664063);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Code128Writer>.NativeClassPtr, 100664064);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1420719, XrefRangeEnd = 1420747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override BitMatrix encode(string contents, BarcodeFormat format, int width, int height, IDictionary<EncodeHintType, Il2CppSystem.Object> hints)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(contents);
		*(BarcodeFormat**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &format;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &width;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &height;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hints);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_encode_Public_Virtual_BitMatrix_String_BarcodeFormat_Int32_Int32_IDictionary_2_EncodeHintType_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<BitMatrix>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1420747, XrefRangeEnd = 1420826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override Il2CppStructArray<bool> encode(string contents)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(contents);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_encode_Public_Virtual_Il2CppStructArray_1_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr2) : null;
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1420828, RefRangeEnd = 1420833, XrefRangeStart = 1420826, XrefRangeEnd = 1420828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static CType findCType(string value, int start)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &start;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_findCType_Private_Static_CType_String_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(CType*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1420856, RefRangeEnd = 1420857, XrefRangeStart = 1420833, XrefRangeEnd = 1420856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int chooseCode(string value, int start, int oldCode)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &start;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &oldCode;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_chooseCode_Private_Int32_String_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1420861, RefRangeEnd = 1420862, XrefRangeStart = 1420857, XrefRangeEnd = 1420861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Code128Writer()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Code128Writer>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public Code128Writer(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
