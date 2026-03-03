using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Text;
using Il2CppZXing.Common;

namespace Il2CppZXing.OneD.RSS.Expanded.Decoders;

public sealed class AI013x0x1xDecoder : AI01weightDecoder
{
	private static readonly IntPtr NativeFieldInfoPtr_HEADER_SIZE;

	private static readonly IntPtr NativeFieldInfoPtr_WEIGHT_SIZE;

	private static readonly IntPtr NativeFieldInfoPtr_DATE_SIZE;

	private static readonly IntPtr NativeFieldInfoPtr_dateCode;

	private static readonly IntPtr NativeFieldInfoPtr_firstAIdigits;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_BitArray_String_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_parseInformation_Public_Virtual_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_encodeCompressedDate_Private_Void_StringBuilder_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_addWeightCode_Protected_Virtual_Void_StringBuilder_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_checkWeight_Protected_Virtual_Int32_Int32_0;

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

	public unsafe static int WEIGHT_SIZE
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_WEIGHT_SIZE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_WEIGHT_SIZE, (void*)(&value));
		}
	}

	public unsafe static int DATE_SIZE
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DATE_SIZE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DATE_SIZE, (void*)(&value));
		}
	}

	public unsafe string dateCode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dateCode);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dateCode)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string firstAIdigits
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_firstAIdigits);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_firstAIdigits)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	static AI013x0x1xDecoder()
	{
		Il2CppClassPointerStore<AI013x0x1xDecoder>.NativeClassPtr = IL2CPP.GetIl2CppClass("zxing.unity.dll", "ZXing.OneD.RSS.Expanded.Decoders", "AI013x0x1xDecoder");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AI013x0x1xDecoder>.NativeClassPtr);
		NativeFieldInfoPtr_HEADER_SIZE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AI013x0x1xDecoder>.NativeClassPtr, "HEADER_SIZE");
		NativeFieldInfoPtr_WEIGHT_SIZE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AI013x0x1xDecoder>.NativeClassPtr, "WEIGHT_SIZE");
		NativeFieldInfoPtr_DATE_SIZE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AI013x0x1xDecoder>.NativeClassPtr, "DATE_SIZE");
		NativeFieldInfoPtr_dateCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AI013x0x1xDecoder>.NativeClassPtr, "dateCode");
		NativeFieldInfoPtr_firstAIdigits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AI013x0x1xDecoder>.NativeClassPtr, "firstAIdigits");
		NativeMethodInfoPtr__ctor_Internal_Void_BitArray_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AI013x0x1xDecoder>.NativeClassPtr, 100664351);
		NativeMethodInfoPtr_parseInformation_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AI013x0x1xDecoder>.NativeClassPtr, 100664352);
		NativeMethodInfoPtr_encodeCompressedDate_Private_Void_StringBuilder_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AI013x0x1xDecoder>.NativeClassPtr, 100664353);
		NativeMethodInfoPtr_addWeightCode_Protected_Virtual_Void_StringBuilder_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AI013x0x1xDecoder>.NativeClassPtr, 100664354);
		NativeMethodInfoPtr_checkWeight_Protected_Virtual_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AI013x0x1xDecoder>.NativeClassPtr, 100664355);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1425047, RefRangeEnd = 1425048, XrefRangeStart = 1425041, XrefRangeEnd = 1425047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AI013x0x1xDecoder(BitArray information, string firstAIdigits, string dateCode)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AI013x0x1xDecoder>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)information);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(firstAIdigits);
		*(IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(dateCode);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_BitArray_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1425048, XrefRangeEnd = 1425081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override string parseInformation()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_parseInformation_Public_Virtual_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1425095, RefRangeEnd = 1425096, XrefRangeStart = 1425081, XrefRangeEnd = 1425095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void encodeCompressedDate(StringBuilder buf, int currentPos)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buf);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &currentPos;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_encodeCompressedDate_Private_Void_StringBuilder_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1425096, XrefRangeEnd = 1425101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void addWeightCode(StringBuilder buf, int weight)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buf);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &weight;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_addWeightCode_Protected_Virtual_Void_StringBuilder_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe override int checkWeight(int weight)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&weight);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_checkWeight_Protected_Virtual_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public AI013x0x1xDecoder(IntPtr pointer)
		: base(pointer)
	{
	}
}
