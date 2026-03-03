using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace Il2CppZXing.QrCode.Internal;

public sealed class QRCodeDecoderMetaData : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_mirrored;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_applyMirroredCorrection_Public_Void_Il2CppReferenceArray_1_ResultPoint_0;

	public unsafe bool mirrored
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mirrored);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mirrored)) = value;
		}
	}

	static QRCodeDecoderMetaData()
	{
		Il2CppClassPointerStore<QRCodeDecoderMetaData>.NativeClassPtr = IL2CPP.GetIl2CppClass("zxing.unity.dll", "ZXing.QrCode.Internal", "QRCodeDecoderMetaData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QRCodeDecoderMetaData>.NativeClassPtr);
		NativeFieldInfoPtr_mirrored = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QRCodeDecoderMetaData>.NativeClassPtr, "mirrored");
		NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QRCodeDecoderMetaData>.NativeClassPtr, 100663624);
		NativeMethodInfoPtr_applyMirroredCorrection_Public_Void_Il2CppReferenceArray_1_ResultPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QRCodeDecoderMetaData>.NativeClassPtr, 100663625);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1413801, XrefRangeEnd = 1413802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe QRCodeDecoderMetaData(bool mirrored)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<QRCodeDecoderMetaData>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&mirrored);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1413802, XrefRangeEnd = 1413806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void applyMirroredCorrection(Il2CppReferenceArray<ResultPoint> points)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)points);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_applyMirroredCorrection_Public_Void_Il2CppReferenceArray_1_ResultPoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public QRCodeDecoderMetaData(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
