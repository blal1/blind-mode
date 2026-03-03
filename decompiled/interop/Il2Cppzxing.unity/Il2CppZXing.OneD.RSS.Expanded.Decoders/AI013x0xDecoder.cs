using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppZXing.Common;

namespace Il2CppZXing.OneD.RSS.Expanded.Decoders;

public class AI013x0xDecoder : AI01weightDecoder
{
	private static readonly IntPtr NativeFieldInfoPtr_HEADER_SIZE;

	private static readonly IntPtr NativeFieldInfoPtr_WEIGHT_SIZE;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_BitArray_0;

	private static readonly IntPtr NativeMethodInfoPtr_parseInformation_Public_Virtual_String_0;

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

	static AI013x0xDecoder()
	{
		Il2CppClassPointerStore<AI013x0xDecoder>.NativeClassPtr = IL2CPP.GetIl2CppClass("zxing.unity.dll", "ZXing.OneD.RSS.Expanded.Decoders", "AI013x0xDecoder");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AI013x0xDecoder>.NativeClassPtr);
		NativeFieldInfoPtr_HEADER_SIZE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AI013x0xDecoder>.NativeClassPtr, "HEADER_SIZE");
		NativeFieldInfoPtr_WEIGHT_SIZE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AI013x0xDecoder>.NativeClassPtr, "WEIGHT_SIZE");
		NativeMethodInfoPtr__ctor_Internal_Void_BitArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AI013x0xDecoder>.NativeClassPtr, 100664357);
		NativeMethodInfoPtr_parseInformation_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AI013x0xDecoder>.NativeClassPtr, 100664358);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1425101, XrefRangeEnd = 1425105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AI013x0xDecoder(BitArray information)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AI013x0xDecoder>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)information);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_BitArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1425105, XrefRangeEnd = 1425135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override string parseInformation()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_parseInformation_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	public AI013x0xDecoder(IntPtr pointer)
		: base(pointer)
	{
	}
}
