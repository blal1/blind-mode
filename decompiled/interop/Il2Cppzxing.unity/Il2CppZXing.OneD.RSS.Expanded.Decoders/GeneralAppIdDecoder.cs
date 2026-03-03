using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Text;
using Il2CppZXing.Common;

namespace Il2CppZXing.OneD.RSS.Expanded.Decoders;

public sealed class GeneralAppIdDecoder : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_information;

	private static readonly System.IntPtr NativeFieldInfoPtr_current;

	private static readonly System.IntPtr NativeFieldInfoPtr_buffer;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_BitArray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_decodeAllCodes_Internal_String_StringBuilder_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isStillNumeric_Private_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_decodeNumeric_Private_DecodedNumeric_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_extractNumericValueFromBitArray_Internal_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_extractNumericValueFromBitArray_Internal_Static_Int32_BitArray_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_decodeGeneralPurposeField_Internal_DecodedInformation_Int32_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_parseBlocks_Private_DecodedInformation_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_parseNumericBlock_Private_BlockParsedResult_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_parseIsoIec646Block_Private_BlockParsedResult_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_parseAlphaBlock_Private_BlockParsedResult_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isStillIsoIec646_Private_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_decodeIsoIec646_Private_DecodedChar_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isStillAlpha_Private_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_decodeAlphanumeric_Private_DecodedChar_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isAlphaTo646ToAlphaLatch_Private_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isAlphaOr646ToNumericLatch_Private_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_isNumericToAlphaNumericLatch_Private_Boolean_Int32_0;

	public unsafe BitArray information
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_information);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<BitArray>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_information)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe CurrentParsingState current
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_current);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CurrentParsingState>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_current)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe StringBuilder buffer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_buffer);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_buffer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static GeneralAppIdDecoder()
	{
		Il2CppClassPointerStore<GeneralAppIdDecoder>.NativeClassPtr = IL2CPP.GetIl2CppClass("zxing.unity.dll", "ZXing.OneD.RSS.Expanded.Decoders", "GeneralAppIdDecoder");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GeneralAppIdDecoder>.NativeClassPtr);
		NativeFieldInfoPtr_information = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneralAppIdDecoder>.NativeClassPtr, "information");
		NativeFieldInfoPtr_current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneralAppIdDecoder>.NativeClassPtr, "current");
		NativeFieldInfoPtr_buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneralAppIdDecoder>.NativeClassPtr, "buffer");
		NativeMethodInfoPtr__ctor_Internal_Void_BitArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneralAppIdDecoder>.NativeClassPtr, 100664410);
		NativeMethodInfoPtr_decodeAllCodes_Internal_String_StringBuilder_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneralAppIdDecoder>.NativeClassPtr, 100664411);
		NativeMethodInfoPtr_isStillNumeric_Private_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneralAppIdDecoder>.NativeClassPtr, 100664412);
		NativeMethodInfoPtr_decodeNumeric_Private_DecodedNumeric_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneralAppIdDecoder>.NativeClassPtr, 100664413);
		NativeMethodInfoPtr_extractNumericValueFromBitArray_Internal_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneralAppIdDecoder>.NativeClassPtr, 100664414);
		NativeMethodInfoPtr_extractNumericValueFromBitArray_Internal_Static_Int32_BitArray_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneralAppIdDecoder>.NativeClassPtr, 100664415);
		NativeMethodInfoPtr_decodeGeneralPurposeField_Internal_DecodedInformation_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneralAppIdDecoder>.NativeClassPtr, 100664416);
		NativeMethodInfoPtr_parseBlocks_Private_DecodedInformation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneralAppIdDecoder>.NativeClassPtr, 100664417);
		NativeMethodInfoPtr_parseNumericBlock_Private_BlockParsedResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneralAppIdDecoder>.NativeClassPtr, 100664418);
		NativeMethodInfoPtr_parseIsoIec646Block_Private_BlockParsedResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneralAppIdDecoder>.NativeClassPtr, 100664419);
		NativeMethodInfoPtr_parseAlphaBlock_Private_BlockParsedResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneralAppIdDecoder>.NativeClassPtr, 100664420);
		NativeMethodInfoPtr_isStillIsoIec646_Private_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneralAppIdDecoder>.NativeClassPtr, 100664421);
		NativeMethodInfoPtr_decodeIsoIec646_Private_DecodedChar_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneralAppIdDecoder>.NativeClassPtr, 100664422);
		NativeMethodInfoPtr_isStillAlpha_Private_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneralAppIdDecoder>.NativeClassPtr, 100664423);
		NativeMethodInfoPtr_decodeAlphanumeric_Private_DecodedChar_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneralAppIdDecoder>.NativeClassPtr, 100664424);
		NativeMethodInfoPtr_isAlphaTo646ToAlphaLatch_Private_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneralAppIdDecoder>.NativeClassPtr, 100664425);
		NativeMethodInfoPtr_isAlphaOr646ToNumericLatch_Private_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneralAppIdDecoder>.NativeClassPtr, 100664426);
		NativeMethodInfoPtr_isNumericToAlphaNumericLatch_Private_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneralAppIdDecoder>.NativeClassPtr, 100664427);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1425363, XrefRangeEnd = 1425375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GeneralAppIdDecoder(BitArray information)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GeneralAppIdDecoder>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)information);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_BitArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1425375, XrefRangeEnd = 1425385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string decodeAllCodes(StringBuilder buff, int initialPosition)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buff);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &initialPosition;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_decodeAllCodes_Internal_String_StringBuilder_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1425385, XrefRangeEnd = 1425387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool isStillNumeric(int pos)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&pos);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isStillNumeric_Private_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1425398, RefRangeEnd = 1425399, XrefRangeStart = 1425387, XrefRangeEnd = 1425398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DecodedNumeric decodeNumeric(int pos)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&pos);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_decodeNumeric_Private_DecodedNumeric_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<DecodedNumeric>(intPtr2) : null;
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 1425400, RefRangeEnd = 1425408, XrefRangeStart = 1425399, XrefRangeEnd = 1425400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int extractNumericValueFromBitArray(int pos, int bits)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&pos);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &bits;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_extractNumericValueFromBitArray_Internal_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1425408, XrefRangeEnd = 1425409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int extractNumericValueFromBitArray(BitArray information, int pos, int bits)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)information);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &pos;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &bits;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_extractNumericValueFromBitArray_Internal_Static_Int32_BitArray_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 1425421, RefRangeEnd = 1425429, XrefRangeStart = 1425409, XrefRangeEnd = 1425421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DecodedInformation decodeGeneralPurposeField(int pos, string remaining)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&pos);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(remaining);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_decodeGeneralPurposeField_Internal_DecodedInformation_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<DecodedInformation>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1425429, XrefRangeEnd = 1425434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DecodedInformation parseBlocks()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_parseBlocks_Private_DecodedInformation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<DecodedInformation>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1425456, RefRangeEnd = 1425458, XrefRangeStart = 1425434, XrefRangeEnd = 1425456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BlockParsedResult parseNumericBlock()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_parseNumericBlock_Private_BlockParsedResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<BlockParsedResult>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1425479, RefRangeEnd = 1425481, XrefRangeStart = 1425458, XrefRangeEnd = 1425479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BlockParsedResult parseIsoIec646Block()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_parseIsoIec646Block_Private_BlockParsedResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<BlockParsedResult>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1425500, RefRangeEnd = 1425502, XrefRangeStart = 1425481, XrefRangeEnd = 1425500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BlockParsedResult parseAlphaBlock()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_parseAlphaBlock_Private_BlockParsedResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<BlockParsedResult>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1425502, XrefRangeEnd = 1425505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool isStillIsoIec646(int pos)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&pos);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isStillIsoIec646_Private_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1425510, RefRangeEnd = 1425511, XrefRangeStart = 1425505, XrefRangeEnd = 1425510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DecodedChar decodeIsoIec646(int pos)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&pos);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_decodeIsoIec646_Private_DecodedChar_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<DecodedChar>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1425511, XrefRangeEnd = 1425512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool isStillAlpha(int pos)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&pos);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isStillAlpha_Private_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1425522, RefRangeEnd = 1425523, XrefRangeStart = 1425512, XrefRangeEnd = 1425522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DecodedChar decodeAlphanumeric(int pos)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&pos);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_decodeAlphanumeric_Private_DecodedChar_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<DecodedChar>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1425523, XrefRangeEnd = 1425524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool isAlphaTo646ToAlphaLatch(int pos)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&pos);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isAlphaTo646ToAlphaLatch_Private_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1425524, XrefRangeEnd = 1425525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool isAlphaOr646ToNumericLatch(int pos)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&pos);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isAlphaOr646ToNumericLatch_Private_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1425525, XrefRangeEnd = 1425526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool isNumericToAlphaNumericLatch(int pos)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&pos);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_isNumericToAlphaNumericLatch_Private_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public GeneralAppIdDecoder(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
