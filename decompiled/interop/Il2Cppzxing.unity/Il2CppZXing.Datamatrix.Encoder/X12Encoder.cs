using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Text;

namespace Il2CppZXing.Datamatrix.Encoder;

public sealed class X12Encoder : C40Encoder
{
	private static readonly IntPtr NativeMethodInfoPtr_get_EncodingMode_Public_Virtual_get_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_encode_Public_Virtual_Void_EncoderContext_0;

	private static readonly IntPtr NativeMethodInfoPtr_encodeChar_Protected_Virtual_Int32_Char_StringBuilder_0;

	private static readonly IntPtr NativeMethodInfoPtr_handleEOD_Protected_Virtual_Void_EncoderContext_StringBuilder_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe override int EncodingMode
	{
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 86858, RefRangeEnd = 86864, XrefRangeStart = 86858, XrefRangeEnd = 86864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_EncodingMode_Public_Virtual_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static X12Encoder()
	{
		Il2CppClassPointerStore<X12Encoder>.NativeClassPtr = IL2CPP.GetIl2CppClass("zxing.unity.dll", "ZXing.Datamatrix.Encoder", "X12Encoder");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<X12Encoder>.NativeClassPtr);
		NativeMethodInfoPtr_get_EncodingMode_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X12Encoder>.NativeClassPtr, 100664568);
		NativeMethodInfoPtr_encode_Public_Virtual_Void_EncoderContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X12Encoder>.NativeClassPtr, 100664569);
		NativeMethodInfoPtr_encodeChar_Protected_Virtual_Int32_Char_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X12Encoder>.NativeClassPtr, 100664570);
		NativeMethodInfoPtr_handleEOD_Protected_Virtual_Void_EncoderContext_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X12Encoder>.NativeClassPtr, 100664571);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X12Encoder>.NativeClassPtr, 100664572);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1427269, XrefRangeEnd = 1427278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void encode(EncoderContext context)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)context);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_encode_Public_Virtual_Void_EncoderContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1427278, XrefRangeEnd = 1427284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override int encodeChar(char c, StringBuilder sb)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&c);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sb);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_encodeChar_Protected_Virtual_Int32_Char_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1427284, XrefRangeEnd = 1427289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void handleEOD(EncoderContext context, StringBuilder buffer)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)context);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buffer);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_handleEOD_Protected_Virtual_Void_EncoderContext_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1950)]
	[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe X12Encoder()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X12Encoder>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public X12Encoder(IntPtr pointer)
		: base(pointer)
	{
	}
}
