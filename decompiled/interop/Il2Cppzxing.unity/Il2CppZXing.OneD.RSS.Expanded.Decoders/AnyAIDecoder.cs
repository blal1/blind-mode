using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppZXing.Common;

namespace Il2CppZXing.OneD.RSS.Expanded.Decoders;

public sealed class AnyAIDecoder : AbstractExpandedDecoder
{
	private static readonly IntPtr NativeFieldInfoPtr_HEADER_SIZE;

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

	static AnyAIDecoder()
	{
		Il2CppClassPointerStore<AnyAIDecoder>.NativeClassPtr = IL2CPP.GetIl2CppClass("zxing.unity.dll", "ZXing.OneD.RSS.Expanded.Decoders", "AnyAIDecoder");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnyAIDecoder>.NativeClassPtr);
		NativeFieldInfoPtr_HEADER_SIZE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnyAIDecoder>.NativeClassPtr, "HEADER_SIZE");
		NativeMethodInfoPtr__ctor_Internal_Void_BitArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnyAIDecoder>.NativeClassPtr, 100664372);
		NativeMethodInfoPtr_parseInformation_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnyAIDecoder>.NativeClassPtr, 100664373);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AnyAIDecoder(BitArray information)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnyAIDecoder>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)information);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_BitArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1425197, XrefRangeEnd = 1425215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override string parseInformation()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_parseInformation_Public_Virtual_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	public AnyAIDecoder(IntPtr pointer)
		: base(pointer)
	{
	}
}
