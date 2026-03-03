using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppZXing.QrCode.Internal;

public sealed class FormatInformation : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_FORMAT_INFO_DECODE_LOOKUP;

	private static readonly System.IntPtr NativeFieldInfoPtr_BITS_SET_IN_HALF_BYTE;

	private static readonly System.IntPtr NativeFieldInfoPtr_errorCorrectionLevel;

	private static readonly System.IntPtr NativeFieldInfoPtr_dataMask;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Private_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_numBitsDiffering_Internal_Static_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_decodeFormatInformation_Internal_Static_FormatInformation_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_doDecodeFormatInformation_Private_Static_FormatInformation_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_ErrorCorrectionLevel_Internal_get_ErrorCorrectionLevel_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_DataMask_Internal_get_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

	public unsafe static Il2CppReferenceArray<Il2CppStructArray<int>> FORMAT_INFO_DECODE_LOOKUP
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_FORMAT_INFO_DECODE_LOOKUP, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppStructArray<int>>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_FORMAT_INFO_DECODE_LOOKUP, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<int> BITS_SET_IN_HALF_BYTE
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BITS_SET_IN_HALF_BYTE, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BITS_SET_IN_HALF_BYTE, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe ErrorCorrectionLevel errorCorrectionLevel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_errorCorrectionLevel);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ErrorCorrectionLevel>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_errorCorrectionLevel)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe byte dataMask
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dataMask);
			return *(byte*)num;
		}
		set
		{
			*(byte*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dataMask)) = value;
		}
	}

	public unsafe ErrorCorrectionLevel ErrorCorrectionLevel
	{
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 50644, RefRangeEnd = 50653, XrefRangeStart = 50644, XrefRangeEnd = 50653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ErrorCorrectionLevel_Internal_get_ErrorCorrectionLevel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ErrorCorrectionLevel>(intPtr2) : null;
		}
	}

	public unsafe byte DataMask
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_DataMask_Internal_get_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(byte*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static FormatInformation()
	{
		Il2CppClassPointerStore<FormatInformation>.NativeClassPtr = IL2CPP.GetIl2CppClass("zxing.unity.dll", "ZXing.QrCode.Internal", "FormatInformation");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FormatInformation>.NativeClassPtr);
		NativeFieldInfoPtr_FORMAT_INFO_DECODE_LOOKUP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FormatInformation>.NativeClassPtr, "FORMAT_INFO_DECODE_LOOKUP");
		NativeFieldInfoPtr_BITS_SET_IN_HALF_BYTE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FormatInformation>.NativeClassPtr, "BITS_SET_IN_HALF_BYTE");
		NativeFieldInfoPtr_errorCorrectionLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FormatInformation>.NativeClassPtr, "errorCorrectionLevel");
		NativeFieldInfoPtr_dataMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FormatInformation>.NativeClassPtr, "dataMask");
		NativeMethodInfoPtr__ctor_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatInformation>.NativeClassPtr, 100663606);
		NativeMethodInfoPtr_numBitsDiffering_Internal_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatInformation>.NativeClassPtr, 100663607);
		NativeMethodInfoPtr_decodeFormatInformation_Internal_Static_FormatInformation_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatInformation>.NativeClassPtr, 100663608);
		NativeMethodInfoPtr_doDecodeFormatInformation_Private_Static_FormatInformation_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatInformation>.NativeClassPtr, 100663609);
		NativeMethodInfoPtr_get_ErrorCorrectionLevel_Internal_get_ErrorCorrectionLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatInformation>.NativeClassPtr, 100663610);
		NativeMethodInfoPtr_get_DataMask_Internal_get_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatInformation>.NativeClassPtr, 100663611);
		NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatInformation>.NativeClassPtr, 100663612);
		NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormatInformation>.NativeClassPtr, 100663613);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1413747, RefRangeEnd = 1413748, XrefRangeStart = 1413735, XrefRangeEnd = 1413747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe FormatInformation(int formatInfo)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FormatInformation>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&formatInfo);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1413752, RefRangeEnd = 1413755, XrefRangeStart = 1413748, XrefRangeEnd = 1413752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int numBitsDiffering(int a, int b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&a);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_numBitsDiffering_Internal_Static_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1413755, XrefRangeEnd = 1413762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static FormatInformation decodeFormatInformation(int maskedFormatInfo1, int maskedFormatInfo2)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&maskedFormatInfo1);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &maskedFormatInfo2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_decodeFormatInformation_Internal_Static_FormatInformation_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<FormatInformation>(intPtr2) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1413775, RefRangeEnd = 1413779, XrefRangeStart = 1413762, XrefRangeEnd = 1413775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static FormatInformation doDecodeFormatInformation(int maskedFormatInfo1, int maskedFormatInfo2)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&maskedFormatInfo1);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &maskedFormatInfo2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_doDecodeFormatInformation_Private_Static_FormatInformation_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<FormatInformation>(intPtr2) : null;
	}

	[CallerCount(0)]
	public unsafe override int GetHashCode()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1413779, XrefRangeEnd = 1413781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override bool Equals(Il2CppSystem.Object o)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)o);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public FormatInformation(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
