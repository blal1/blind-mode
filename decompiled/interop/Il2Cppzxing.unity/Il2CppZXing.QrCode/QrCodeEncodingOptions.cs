using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppZXing.Common;

namespace Il2CppZXing.QrCode;

[Serializable]
public class QrCodeEncodingOptions : EncodingOptions
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static QrCodeEncodingOptions()
	{
		Il2CppClassPointerStore<QrCodeEncodingOptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("zxing.unity.dll", "ZXing.QrCode", "QrCodeEncodingOptions");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QrCodeEncodingOptions>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QrCodeEncodingOptions>.NativeClassPtr, 100663552);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1413195, RefRangeEnd = 1413197, XrefRangeStart = 1413194, XrefRangeEnd = 1413195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe QrCodeEncodingOptions()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<QrCodeEncodingOptions>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public QrCodeEncodingOptions(IntPtr pointer)
		: base(pointer)
	{
	}
}
