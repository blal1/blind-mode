using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Text;

public class EncodingProvider : Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_s_InternalSyncObject;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_providers;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetEncoding_Public_Abstract_Virtual_New_Encoding_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetEncoding_Public_Abstract_Virtual_New_Encoding_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetEncoding_Public_Virtual_New_Encoding_Int32_EncoderFallback_DecoderFallback_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetEncodingFromProvider_Internal_Static_Encoding_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetEncodingFromProvider_Internal_Static_Encoding_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetEncodingFromProvider_Internal_Static_Encoding_Int32_EncoderFallback_DecoderFallback_0;

	public unsafe static Object s_InternalSyncObject
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_InternalSyncObject, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_InternalSyncObject, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppReferenceArray<EncodingProvider> s_providers
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_providers, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<EncodingProvider>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_providers, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static EncodingProvider()
	{
		Il2CppClassPointerStore<EncodingProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Text", "EncodingProvider");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EncodingProvider>.NativeClassPtr);
		NativeFieldInfoPtr_s_InternalSyncObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EncodingProvider>.NativeClassPtr, "s_InternalSyncObject");
		NativeFieldInfoPtr_s_providers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EncodingProvider>.NativeClassPtr, "s_providers");
		NativeMethodInfoPtr_GetEncoding_Public_Abstract_Virtual_New_Encoding_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncodingProvider>.NativeClassPtr, 100668672);
		NativeMethodInfoPtr_GetEncoding_Public_Abstract_Virtual_New_Encoding_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncodingProvider>.NativeClassPtr, 100668673);
		NativeMethodInfoPtr_GetEncoding_Public_Virtual_New_Encoding_Int32_EncoderFallback_DecoderFallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncodingProvider>.NativeClassPtr, 100668674);
		NativeMethodInfoPtr_GetEncodingFromProvider_Internal_Static_Encoding_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncodingProvider>.NativeClassPtr, 100668675);
		NativeMethodInfoPtr_GetEncodingFromProvider_Internal_Static_Encoding_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncodingProvider>.NativeClassPtr, 100668676);
		NativeMethodInfoPtr_GetEncodingFromProvider_Internal_Static_Encoding_Int32_EncoderFallback_DecoderFallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncodingProvider>.NativeClassPtr, 100668677);
	}

	[CallerCount(0)]
	public unsafe virtual Encoding GetEncoding(string name)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetEncoding_Public_Abstract_Virtual_New_Encoding_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Encoding>(intPtr2) : null;
	}

	[CallerCount(0)]
	public unsafe virtual Encoding GetEncoding(int codepage)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&codepage);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetEncoding_Public_Abstract_Virtual_New_Encoding_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Encoding>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 777340, XrefRangeEnd = 777344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual Encoding GetEncoding(int codepage, EncoderFallback encoderFallback, DecoderFallback decoderFallback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&codepage);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)encoderFallback);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)decoderFallback);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GetEncoding_Public_Virtual_New_Encoding_Int32_EncoderFallback_DecoderFallback_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Encoding>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 777354, RefRangeEnd = 777355, XrefRangeStart = 777344, XrefRangeEnd = 777354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Encoding GetEncodingFromProvider(int codepage)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&codepage);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetEncodingFromProvider_Internal_Static_Encoding_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Encoding>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 777365, RefRangeEnd = 777366, XrefRangeStart = 777355, XrefRangeEnd = 777365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Encoding GetEncodingFromProvider(string encodingName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(encodingName);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetEncodingFromProvider_Internal_Static_Encoding_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Encoding>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 777376, RefRangeEnd = 777377, XrefRangeStart = 777366, XrefRangeEnd = 777376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Encoding GetEncodingFromProvider(int codepage, EncoderFallback enc, DecoderFallback dec)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&codepage);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)enc);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)dec);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetEncodingFromProvider_Internal_Static_Encoding_Int32_EncoderFallback_DecoderFallback_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Encoding>(intPtr2) : null;
	}

	public EncodingProvider(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
