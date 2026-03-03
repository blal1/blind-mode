using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppZXing.Common;

namespace Il2CppZXing.OneD;

public sealed class UPCEANExtensionSupport : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_EXTENSION_START_PATTERN;

	private static readonly System.IntPtr NativeFieldInfoPtr_twoSupport;

	private static readonly System.IntPtr NativeFieldInfoPtr_fiveSupport;

	private static readonly System.IntPtr NativeMethodInfoPtr_decodeRow_Internal_Result_Int32_BitArray_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static Il2CppStructArray<int> EXTENSION_START_PATTERN
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_EXTENSION_START_PATTERN, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_EXTENSION_START_PATTERN, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe UPCEANExtension2Support twoSupport
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_twoSupport);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<UPCEANExtension2Support>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_twoSupport)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe UPCEANExtension5Support fiveSupport
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fiveSupport);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<UPCEANExtension5Support>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fiveSupport)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static UPCEANExtensionSupport()
	{
		Il2CppClassPointerStore<UPCEANExtensionSupport>.NativeClassPtr = IL2CPP.GetIl2CppClass("zxing.unity.dll", "ZXing.OneD", "UPCEANExtensionSupport");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UPCEANExtensionSupport>.NativeClassPtr);
		NativeFieldInfoPtr_EXTENSION_START_PATTERN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UPCEANExtensionSupport>.NativeClassPtr, "EXTENSION_START_PATTERN");
		NativeFieldInfoPtr_twoSupport = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UPCEANExtensionSupport>.NativeClassPtr, "twoSupport");
		NativeFieldInfoPtr_fiveSupport = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UPCEANExtensionSupport>.NativeClassPtr, "fiveSupport");
		NativeMethodInfoPtr_decodeRow_Internal_Result_Int32_BitArray_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UPCEANExtensionSupport>.NativeClassPtr, 100664211);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UPCEANExtensionSupport>.NativeClassPtr, 100664212);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1423665, XrefRangeEnd = 1423681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Result decodeRow(int rowNumber, BitArray row, int rowOffset)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&rowNumber);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)row);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &rowOffset;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_decodeRow_Internal_Result_Int32_BitArray_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Result>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1423681, XrefRangeEnd = 1423710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UPCEANExtensionSupport()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UPCEANExtensionSupport>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public UPCEANExtensionSupport(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
