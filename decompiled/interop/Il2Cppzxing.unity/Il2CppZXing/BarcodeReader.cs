using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppZXing;

public class BarcodeReader : BarcodeReaderGeneric
{
	[System.Serializable]
	[ObfuscatedName("ZXing.BarcodeReader+<>c")]
	public new sealed class __c : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___9;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr___cctor_b__9_0_Internal_LuminanceSource_Il2CppStructArray_1_Color32_Int32_Int32_0;

		public unsafe static __c __9
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<__c>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		static __c()
		{
			Il2CppClassPointerStore<__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BarcodeReader>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c>.NativeClassPtr);
			NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100663385);
			NativeMethodInfoPtr___cctor_b__9_0_Internal_LuminanceSource_Il2CppStructArray_1_Color32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100663386);
		}

		[CallerCount(1950)]
		[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1412264, XrefRangeEnd = 1412272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LuminanceSource __cctor_b__9_0(Il2CppStructArray<Color32> rawColor32, int width, int height)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[3];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rawColor32);
			*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &width;
			*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &height;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr___cctor_b__9_0_Internal_LuminanceSource_Il2CppStructArray_1_Color32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<LuminanceSource>(intPtr2) : null;
		}

		public __c(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_defaultCreateLuminanceSource;

	private static readonly System.IntPtr NativeFieldInfoPtr_createLuminanceSource;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Reader_Func_4_Il2CppStructArray_1_Color32_Int32_Int32_LuminanceSource_Func_2_LuminanceSource_Binarizer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Reader_Func_4_Il2CppStructArray_1_Color32_Int32_Int32_LuminanceSource_Func_2_LuminanceSource_Binarizer_Func_5_Il2CppStructArray_1_Byte_Int32_Int32_BitmapFormat_LuminanceSource_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_CreateLuminanceSource_Protected_get_Func_4_Il2CppStructArray_1_Color32_Int32_Int32_LuminanceSource_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Decode_Public_Virtual_Final_New_Result_Il2CppStructArray_1_Color32_Int32_Int32_0;

	public unsafe static Il2CppSystem.Func<Il2CppStructArray<Color32>, int, int, LuminanceSource> defaultCreateLuminanceSource
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_defaultCreateLuminanceSource, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<Il2CppStructArray<Color32>, int, int, LuminanceSource>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_defaultCreateLuminanceSource, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppSystem.Func<Il2CppStructArray<Color32>, int, int, LuminanceSource> createLuminanceSource
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_createLuminanceSource);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<Il2CppStructArray<Color32>, int, int, LuminanceSource>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_createLuminanceSource)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppSystem.Func<Il2CppStructArray<Color32>, int, int, LuminanceSource> CreateLuminanceSource
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 84624, RefRangeEnd = 84627, XrefRangeStart = 84624, XrefRangeEnd = 84627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_CreateLuminanceSource_Protected_get_Func_4_Il2CppStructArray_1_Color32_Int32_Int32_LuminanceSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<Il2CppStructArray<Color32>, int, int, LuminanceSource>>(intPtr2) : null;
		}
	}

	static BarcodeReader()
	{
		Il2CppClassPointerStore<BarcodeReader>.NativeClassPtr = IL2CPP.GetIl2CppClass("zxing.unity.dll", "ZXing", "BarcodeReader");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BarcodeReader>.NativeClassPtr);
		NativeFieldInfoPtr_defaultCreateLuminanceSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BarcodeReader>.NativeClassPtr, "defaultCreateLuminanceSource");
		NativeFieldInfoPtr_createLuminanceSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BarcodeReader>.NativeClassPtr, "createLuminanceSource");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BarcodeReader>.NativeClassPtr, 100663378);
		NativeMethodInfoPtr__ctor_Public_Void_Reader_Func_4_Il2CppStructArray_1_Color32_Int32_Int32_LuminanceSource_Func_2_LuminanceSource_Binarizer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BarcodeReader>.NativeClassPtr, 100663379);
		NativeMethodInfoPtr__ctor_Public_Void_Reader_Func_4_Il2CppStructArray_1_Color32_Int32_Int32_LuminanceSource_Func_2_LuminanceSource_Binarizer_Func_5_Il2CppStructArray_1_Byte_Int32_Int32_BitmapFormat_LuminanceSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BarcodeReader>.NativeClassPtr, 100663380);
		NativeMethodInfoPtr_get_CreateLuminanceSource_Protected_get_Func_4_Il2CppStructArray_1_Color32_Int32_Int32_LuminanceSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BarcodeReader>.NativeClassPtr, 100663381);
		NativeMethodInfoPtr_Decode_Public_Virtual_Final_New_Result_Il2CppStructArray_1_Color32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BarcodeReader>.NativeClassPtr, 100663382);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1412304, RefRangeEnd = 1412305, XrefRangeStart = 1412272, XrefRangeEnd = 1412304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BarcodeReader()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BarcodeReader>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1412305, XrefRangeEnd = 1412329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BarcodeReader(Reader reader, Il2CppSystem.Func<Il2CppStructArray<Color32>, int, int, LuminanceSource> createLuminanceSource, Il2CppSystem.Func<LuminanceSource, Binarizer> createBinarizer)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BarcodeReader>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)reader);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)createLuminanceSource);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)createBinarizer);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Reader_Func_4_Il2CppStructArray_1_Color32_Int32_Int32_LuminanceSource_Func_2_LuminanceSource_Binarizer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1412329, XrefRangeEnd = 1412353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BarcodeReader(Reader reader, Il2CppSystem.Func<Il2CppStructArray<Color32>, int, int, LuminanceSource> createLuminanceSource, Il2CppSystem.Func<LuminanceSource, Binarizer> createBinarizer, Il2CppSystem.Func<Il2CppStructArray<byte>, int, int, RGBLuminanceSource.BitmapFormat, LuminanceSource> createRGBLuminanceSource)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BarcodeReader>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)reader);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)createLuminanceSource);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)createBinarizer);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)createRGBLuminanceSource);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Reader_Func_4_Il2CppStructArray_1_Color32_Int32_Int32_LuminanceSource_Func_2_LuminanceSource_Binarizer_Func_5_Il2CppStructArray_1_Byte_Int32_Int32_BitmapFormat_LuminanceSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1412379, RefRangeEnd = 1412380, XrefRangeStart = 1412353, XrefRangeEnd = 1412379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual Result Decode(Il2CppStructArray<Color32> rawColor32, int width, int height)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rawColor32);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &width;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &height;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Decode_Public_Virtual_Final_New_Result_Il2CppStructArray_1_Color32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Result>(intPtr2) : null;
	}

	public BarcodeReader(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
