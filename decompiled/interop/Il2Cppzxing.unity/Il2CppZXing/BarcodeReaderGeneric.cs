using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppZXing.Common;

namespace Il2CppZXing;

public class BarcodeReaderGeneric : Il2CppSystem.Object
{
	[System.Serializable]
	[ObfuscatedName("ZXing.BarcodeReaderGeneric+<>c")]
	public sealed class __c : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___9;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr___cctor_b__40_0_Internal_Binarizer_LuminanceSource_0;

		private static readonly System.IntPtr NativeMethodInfoPtr___cctor_b__40_1_Internal_LuminanceSource_Il2CppStructArray_1_Byte_Int32_Int32_BitmapFormat_0;

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
			Il2CppClassPointerStore<__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BarcodeReaderGeneric>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c>.NativeClassPtr);
			NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100663398);
			NativeMethodInfoPtr___cctor_b__40_0_Internal_Binarizer_LuminanceSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100663399);
			NativeMethodInfoPtr___cctor_b__40_1_Internal_LuminanceSource_Il2CppStructArray_1_Byte_Int32_Int32_BitmapFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100663400);
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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1412380, XrefRangeEnd = 1412384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Binarizer __cctor_b__40_0(LuminanceSource luminanceSource)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)luminanceSource);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr___cctor_b__40_0_Internal_Binarizer_LuminanceSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Binarizer>(intPtr2) : null;
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1412384, XrefRangeEnd = 1412393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LuminanceSource __cctor_b__40_1(Il2CppStructArray<byte> rawBytes, int width, int height, RGBLuminanceSource.BitmapFormat format)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[4];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rawBytes);
			*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &width;
			*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &height;
			*(RGBLuminanceSource.BitmapFormat**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &format;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr___cctor_b__40_1_Internal_LuminanceSource_Il2CppStructArray_1_Byte_Int32_Int32_BitmapFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<LuminanceSource>(intPtr2) : null;
		}

		public __c(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_defaultCreateBinarizer;

	private static readonly System.IntPtr NativeFieldInfoPtr_defaultCreateRGBLuminanceSource;

	private static readonly System.IntPtr NativeFieldInfoPtr_reader;

	private static readonly System.IntPtr NativeFieldInfoPtr_createRGBLuminanceSource;

	private static readonly System.IntPtr NativeFieldInfoPtr_createBinarizer;

	private static readonly System.IntPtr NativeFieldInfoPtr_usePreviousState;

	private static readonly System.IntPtr NativeFieldInfoPtr_options;

	private static readonly System.IntPtr NativeFieldInfoPtr_ResultFound;

	private static readonly System.IntPtr NativeFieldInfoPtr__AutoRotate_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__TryInverted_k__BackingField;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Options_Public_Virtual_Final_New_get_DecodingOptions_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Reader_Protected_get_Reader_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_AutoRotate_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_TryInverted_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_CreateBinarizer_Protected_get_Func_2_LuminanceSource_Binarizer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Reader_Func_2_LuminanceSource_Binarizer_Func_5_Il2CppStructArray_1_Byte_Int32_Int32_BitmapFormat_LuminanceSource_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Decode_Public_Virtual_New_Result_LuminanceSource_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnResultFound_Protected_Void_Result_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__get_Options_b__8_0_Private_Void_Object_EventArgs_0;

	public unsafe static Il2CppSystem.Func<LuminanceSource, Binarizer> defaultCreateBinarizer
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_defaultCreateBinarizer, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<LuminanceSource, Binarizer>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_defaultCreateBinarizer, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppSystem.Func<Il2CppStructArray<byte>, int, int, RGBLuminanceSource.BitmapFormat, LuminanceSource> defaultCreateRGBLuminanceSource
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_defaultCreateRGBLuminanceSource, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<Il2CppStructArray<byte>, int, int, RGBLuminanceSource.BitmapFormat, LuminanceSource>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_defaultCreateRGBLuminanceSource, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Reader reader
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reader);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Reader>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reader)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppSystem.Func<Il2CppStructArray<byte>, int, int, RGBLuminanceSource.BitmapFormat, LuminanceSource> createRGBLuminanceSource
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_createRGBLuminanceSource);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<Il2CppStructArray<byte>, int, int, RGBLuminanceSource.BitmapFormat, LuminanceSource>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_createRGBLuminanceSource)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppSystem.Func<LuminanceSource, Binarizer> createBinarizer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_createBinarizer);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<LuminanceSource, Binarizer>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_createBinarizer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe bool usePreviousState
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_usePreviousState);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_usePreviousState)) = value;
		}
	}

	public unsafe DecodingOptions options
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_options);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DecodingOptions>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_options)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppSystem.Action<Result> ResultFound
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ResultFound);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<Result>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ResultFound)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe bool _AutoRotate_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__AutoRotate_k__BackingField);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__AutoRotate_k__BackingField)) = value;
		}
	}

	public unsafe bool _TryInverted_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__TryInverted_k__BackingField);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__TryInverted_k__BackingField)) = value;
		}
	}

	public unsafe virtual DecodingOptions Options
	{
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1412405, RefRangeEnd = 1412410, XrefRangeStart = 1412393, XrefRangeEnd = 1412405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Options_Public_Virtual_Final_New_get_DecodingOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<DecodingOptions>(intPtr2) : null;
		}
	}

	public unsafe Reader Reader
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1412415, RefRangeEnd = 1412417, XrefRangeStart = 1412410, XrefRangeEnd = 1412415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Reader_Protected_get_Reader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Reader>(intPtr2) : null;
		}
	}

	public unsafe bool AutoRotate
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_AutoRotate_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool TryInverted
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_TryInverted_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe Il2CppSystem.Func<LuminanceSource, Binarizer> CreateBinarizer
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1412421, RefRangeEnd = 1412423, XrefRangeStart = 1412417, XrefRangeEnd = 1412421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_CreateBinarizer_Protected_get_Func_2_LuminanceSource_Binarizer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<LuminanceSource, Binarizer>>(intPtr2) : null;
		}
	}

	static BarcodeReaderGeneric()
	{
		Il2CppClassPointerStore<BarcodeReaderGeneric>.NativeClassPtr = IL2CPP.GetIl2CppClass("zxing.unity.dll", "ZXing", "BarcodeReaderGeneric");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BarcodeReaderGeneric>.NativeClassPtr);
		NativeFieldInfoPtr_defaultCreateBinarizer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BarcodeReaderGeneric>.NativeClassPtr, "defaultCreateBinarizer");
		NativeFieldInfoPtr_defaultCreateRGBLuminanceSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BarcodeReaderGeneric>.NativeClassPtr, "defaultCreateRGBLuminanceSource");
		NativeFieldInfoPtr_reader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BarcodeReaderGeneric>.NativeClassPtr, "reader");
		NativeFieldInfoPtr_createRGBLuminanceSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BarcodeReaderGeneric>.NativeClassPtr, "createRGBLuminanceSource");
		NativeFieldInfoPtr_createBinarizer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BarcodeReaderGeneric>.NativeClassPtr, "createBinarizer");
		NativeFieldInfoPtr_usePreviousState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BarcodeReaderGeneric>.NativeClassPtr, "usePreviousState");
		NativeFieldInfoPtr_options = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BarcodeReaderGeneric>.NativeClassPtr, "options");
		NativeFieldInfoPtr_ResultFound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BarcodeReaderGeneric>.NativeClassPtr, "ResultFound");
		NativeFieldInfoPtr__AutoRotate_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BarcodeReaderGeneric>.NativeClassPtr, "<AutoRotate>k__BackingField");
		NativeFieldInfoPtr__TryInverted_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BarcodeReaderGeneric>.NativeClassPtr, "<TryInverted>k__BackingField");
		NativeMethodInfoPtr_get_Options_Public_Virtual_Final_New_get_DecodingOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BarcodeReaderGeneric>.NativeClassPtr, 100663387);
		NativeMethodInfoPtr_get_Reader_Protected_get_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BarcodeReaderGeneric>.NativeClassPtr, 100663388);
		NativeMethodInfoPtr_get_AutoRotate_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BarcodeReaderGeneric>.NativeClassPtr, 100663389);
		NativeMethodInfoPtr_get_TryInverted_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BarcodeReaderGeneric>.NativeClassPtr, 100663390);
		NativeMethodInfoPtr_get_CreateBinarizer_Protected_get_Func_2_LuminanceSource_Binarizer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BarcodeReaderGeneric>.NativeClassPtr, 100663391);
		NativeMethodInfoPtr__ctor_Public_Void_Reader_Func_2_LuminanceSource_Binarizer_Func_5_Il2CppStructArray_1_Byte_Int32_Int32_BitmapFormat_LuminanceSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BarcodeReaderGeneric>.NativeClassPtr, 100663392);
		NativeMethodInfoPtr_Decode_Public_Virtual_New_Result_LuminanceSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BarcodeReaderGeneric>.NativeClassPtr, 100663393);
		NativeMethodInfoPtr_OnResultFound_Protected_Void_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BarcodeReaderGeneric>.NativeClassPtr, 100663394);
		NativeMethodInfoPtr__get_Options_b__8_0_Private_Void_Object_EventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BarcodeReaderGeneric>.NativeClassPtr, 100663396);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1412423, XrefRangeEnd = 1412438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BarcodeReaderGeneric(Reader reader, Il2CppSystem.Func<LuminanceSource, Binarizer> createBinarizer, Il2CppSystem.Func<Il2CppStructArray<byte>, int, int, RGBLuminanceSource.BitmapFormat, LuminanceSource> createRGBLuminanceSource)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BarcodeReaderGeneric>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)reader);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)createBinarizer);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)createRGBLuminanceSource);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Reader_Func_2_LuminanceSource_Binarizer_Func_5_Il2CppStructArray_1_Byte_Int32_Int32_BitmapFormat_LuminanceSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1412438, XrefRangeEnd = 1412510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual Result Decode(LuminanceSource luminanceSource)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)luminanceSource);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Decode_Public_Virtual_New_Result_LuminanceSource_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Result>(intPtr2) : null;
	}

	[CallerCount(0)]
	public unsafe void OnResultFound(Result result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)result);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnResultFound_Protected_Void_Result_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(13)]
	[CachedScanResults(RefRangeStart = 66909, RefRangeEnd = 66922, XrefRangeStart = 66909, XrefRangeEnd = 66922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _get_Options_b__8_0(Il2CppSystem.Object o, Il2CppSystem.EventArgs args)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)o);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)args);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__get_Options_b__8_0_Private_Void_Object_EventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public BarcodeReaderGeneric(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
