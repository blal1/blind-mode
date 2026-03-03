using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppZXing.OneD;

public class UPCEWriter : UPCEANWriter
{
	private static readonly IntPtr NativeFieldInfoPtr_supportedWriteFormats;

	private static readonly IntPtr NativeMethodInfoPtr_get_SupportedWriteFormats_Protected_Virtual_get_IList_1_BarcodeFormat_0;

	private static readonly IntPtr NativeMethodInfoPtr_encode_Public_Virtual_Il2CppStructArray_1_Boolean_String_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static IList<BarcodeFormat> supportedWriteFormats
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_supportedWriteFormats, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<IList<BarcodeFormat>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_supportedWriteFormats, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe override IList<BarcodeFormat> SupportedWriteFormats
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1424065, XrefRangeEnd = 1424069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_SupportedWriteFormats_Protected_Virtual_get_IList_1_BarcodeFormat_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<IList<BarcodeFormat>>(intPtr2) : null;
		}
	}

	static UPCEWriter()
	{
		Il2CppClassPointerStore<UPCEWriter>.NativeClassPtr = IL2CPP.GetIl2CppClass("zxing.unity.dll", "ZXing.OneD", "UPCEWriter");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UPCEWriter>.NativeClassPtr);
		NativeFieldInfoPtr_supportedWriteFormats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UPCEWriter>.NativeClassPtr, "supportedWriteFormats");
		NativeMethodInfoPtr_get_SupportedWriteFormats_Protected_Virtual_get_IList_1_BarcodeFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UPCEWriter>.NativeClassPtr, 100664238);
		NativeMethodInfoPtr_encode_Public_Virtual_Il2CppStructArray_1_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UPCEWriter>.NativeClassPtr, 100664239);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UPCEWriter>.NativeClassPtr, 100664240);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1424069, XrefRangeEnd = 1424124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override Il2CppStructArray<bool> encode(string contents)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(contents);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_encode_Public_Virtual_Il2CppStructArray_1_Boolean_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr2) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1423973, RefRangeEnd = 1423976, XrefRangeStart = 1423973, XrefRangeEnd = 1423976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UPCEWriter()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UPCEWriter>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public UPCEWriter(IntPtr pointer)
		: base(pointer)
	{
	}
}
