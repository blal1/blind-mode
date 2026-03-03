using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Text;
using Il2CppZXing.Common;

namespace Il2CppZXing.OneD.RSS.Expanded.Decoders;

public class AI01decoder : AbstractExpandedDecoder
{
	private static readonly IntPtr NativeFieldInfoPtr_GTIN_SIZE;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_BitArray_0;

	private static readonly IntPtr NativeMethodInfoPtr_encodeCompressedGtin_Protected_Void_StringBuilder_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_encodeCompressedGtinWithoutAI_Protected_Void_StringBuilder_Int32_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_appendCheckDigit_Private_Static_Void_StringBuilder_Int32_0;

	public unsafe static int GTIN_SIZE
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_GTIN_SIZE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_GTIN_SIZE, (void*)(&value));
		}
	}

	static AI01decoder()
	{
		Il2CppClassPointerStore<AI01decoder>.NativeClassPtr = IL2CPP.GetIl2CppClass("zxing.unity.dll", "ZXing.OneD.RSS.Expanded.Decoders", "AI01decoder");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AI01decoder>.NativeClassPtr);
		NativeFieldInfoPtr_GTIN_SIZE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AI01decoder>.NativeClassPtr, "GTIN_SIZE");
		NativeMethodInfoPtr__ctor_Internal_Void_BitArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AI01decoder>.NativeClassPtr, 100664363);
		NativeMethodInfoPtr_encodeCompressedGtin_Protected_Void_StringBuilder_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AI01decoder>.NativeClassPtr, 100664364);
		NativeMethodInfoPtr_encodeCompressedGtinWithoutAI_Protected_Void_StringBuilder_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AI01decoder>.NativeClassPtr, 100664365);
		NativeMethodInfoPtr_appendCheckDigit_Private_Static_Void_StringBuilder_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AI01decoder>.NativeClassPtr, 100664366);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1425166, XrefRangeEnd = 1425167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AI01decoder(BitArray information)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AI01decoder>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)information);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_BitArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1425167, XrefRangeEnd = 1425173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void encodeCompressedGtin(StringBuilder buf, int currentPos)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buf);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &currentPos;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_encodeCompressedGtin_Protected_Void_StringBuilder_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 1425184, RefRangeEnd = 1425190, XrefRangeStart = 1425173, XrefRangeEnd = 1425184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void encodeCompressedGtinWithoutAI(StringBuilder buf, int currentPos, int initialBufferPosition)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buf);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &currentPos;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &initialBufferPosition;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_encodeCompressedGtinWithoutAI_Protected_Void_StringBuilder_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1425190, XrefRangeEnd = 1425193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void appendCheckDigit(StringBuilder buf, int currentPos)
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buf);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &currentPos;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_appendCheckDigit_Private_Static_Void_StringBuilder_Int32_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public AI01decoder(IntPtr pointer)
		: base(pointer)
	{
	}
}
