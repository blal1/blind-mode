using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using Il2CppSystem.Text;

namespace Il2CppZXing.Datamatrix.Encoder;

public sealed class EdifactEncoder : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_get_EncodingMode_Public_Virtual_Final_New_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_encode_Public_Virtual_Final_New_Void_EncoderContext_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_handleEOD_Private_Static_Void_EncoderContext_StringBuilder_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_encodeChar_Private_Static_Void_Char_StringBuilder_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_encodeToCodewords_Private_Static_String_StringBuilder_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe virtual int EncodingMode
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_EncodingMode_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static EdifactEncoder()
	{
		Il2CppClassPointerStore<EdifactEncoder>.NativeClassPtr = IL2CPP.GetIl2CppClass("zxing.unity.dll", "ZXing.Datamatrix.Encoder", "EdifactEncoder");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EdifactEncoder>.NativeClassPtr);
		NativeMethodInfoPtr_get_EncodingMode_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EdifactEncoder>.NativeClassPtr, 100664501);
		NativeMethodInfoPtr_encode_Public_Virtual_Final_New_Void_EncoderContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EdifactEncoder>.NativeClassPtr, 100664502);
		NativeMethodInfoPtr_handleEOD_Private_Static_Void_EncoderContext_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EdifactEncoder>.NativeClassPtr, 100664503);
		NativeMethodInfoPtr_encodeChar_Private_Static_Void_Char_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EdifactEncoder>.NativeClassPtr, 100664504);
		NativeMethodInfoPtr_encodeToCodewords_Private_Static_String_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EdifactEncoder>.NativeClassPtr, 100664505);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EdifactEncoder>.NativeClassPtr, 100664506);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1426486, XrefRangeEnd = 1426502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void encode(EncoderContext context)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)context);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_encode_Public_Virtual_Final_New_Void_EncoderContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1426523, RefRangeEnd = 1426524, XrefRangeStart = 1426502, XrefRangeEnd = 1426523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void handleEOD(EncoderContext context, StringBuilder buffer)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)context);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buffer);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_handleEOD_Private_Static_Void_EncoderContext_StringBuilder_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1426524, XrefRangeEnd = 1426528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void encodeChar(char c, StringBuilder sb)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&c);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sb);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_encodeChar_Private_Static_Void_Char_StringBuilder_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1426548, RefRangeEnd = 1426550, XrefRangeStart = 1426528, XrefRangeEnd = 1426548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string encodeToCodewords(StringBuilder sb)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sb);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_encodeToCodewords_Private_Static_String_StringBuilder_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(1950)]
	[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe EdifactEncoder()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EdifactEncoder>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public EdifactEncoder(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
