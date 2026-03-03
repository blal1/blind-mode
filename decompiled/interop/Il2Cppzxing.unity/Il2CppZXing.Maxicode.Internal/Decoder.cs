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
using Il2CppZXing.Common.ReedSolomon;

namespace Il2CppZXing.Maxicode.Internal;

public sealed class Decoder : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_rsDecoder;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_decode_Public_DecoderResult_BitMatrix_IDictionary_2_DecodeHintType_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_correctErrors_Private_Boolean_Il2CppStructArray_1_Byte_Int32_Int32_Int32_Int32_0;

	public unsafe ReedSolomonDecoder rsDecoder
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rsDecoder);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ReedSolomonDecoder>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rsDecoder)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static Decoder()
	{
		Il2CppClassPointerStore<Decoder>.NativeClassPtr = IL2CPP.GetIl2CppClass("zxing.unity.dll", "ZXing.Maxicode.Internal", "Decoder");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Decoder>.NativeClassPtr);
		NativeFieldInfoPtr_rsDecoder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Decoder>.NativeClassPtr, "rsDecoder");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decoder>.NativeClassPtr, 100664446);
		NativeMethodInfoPtr_decode_Public_DecoderResult_BitMatrix_IDictionary_2_DecodeHintType_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decoder>.NativeClassPtr, 100664447);
		NativeMethodInfoPtr_correctErrors_Private_Boolean_Il2CppStructArray_1_Byte_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Decoder>.NativeClassPtr, 100664448);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1425834, XrefRangeEnd = 1425844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Decoder()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Decoder>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1425880, RefRangeEnd = 1425881, XrefRangeStart = 1425844, XrefRangeEnd = 1425880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DecoderResult decode(BitMatrix bits, IDictionary<DecodeHintType, Il2CppSystem.Object> hints)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)bits);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hints);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_decode_Public_DecoderResult_BitMatrix_IDictionary_2_DecodeHintType_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<DecoderResult>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1425881, XrefRangeEnd = 1425885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool correctErrors(Il2CppStructArray<byte> codewordBytes, int start, int dataCodewords, int ecCodewords, int mode)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)codewordBytes);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &start;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &dataCodewords;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &ecCodewords;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &mode;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_correctErrors_Private_Boolean_Il2CppStructArray_1_Byte_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public Decoder(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
