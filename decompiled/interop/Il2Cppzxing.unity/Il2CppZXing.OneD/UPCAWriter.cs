using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppZXing.Common;

namespace Il2CppZXing.OneD;

public class UPCAWriter : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_subWriter;

	private static readonly System.IntPtr NativeMethodInfoPtr_encode_Public_Virtual_Final_New_BitMatrix_String_BarcodeFormat_Int32_Int32_IDictionary_2_EncodeHintType_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe EAN13Writer subWriter
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_subWriter);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<EAN13Writer>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_subWriter)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static UPCAWriter()
	{
		Il2CppClassPointerStore<UPCAWriter>.NativeClassPtr = IL2CPP.GetIl2CppClass("zxing.unity.dll", "ZXing.OneD", "UPCAWriter");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UPCAWriter>.NativeClassPtr);
		NativeFieldInfoPtr_subWriter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UPCAWriter>.NativeClassPtr, "subWriter");
		NativeMethodInfoPtr_encode_Public_Virtual_Final_New_BitMatrix_String_BarcodeFormat_Int32_Int32_IDictionary_2_EncodeHintType_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UPCAWriter>.NativeClassPtr, 100664197);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UPCAWriter>.NativeClassPtr, 100664198);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1423454, XrefRangeEnd = 1423468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual BitMatrix encode(string contents, BarcodeFormat format, int width, int height, IDictionary<EncodeHintType, Il2CppSystem.Object> hints)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(contents);
		*(BarcodeFormat**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &format;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &width;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &height;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)hints);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_encode_Public_Virtual_Final_New_BitMatrix_String_BarcodeFormat_Int32_Int32_IDictionary_2_EncodeHintType_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<BitMatrix>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1423474, RefRangeEnd = 1423475, XrefRangeStart = 1423468, XrefRangeEnd = 1423474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UPCAWriter()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UPCAWriter>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public UPCAWriter(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
