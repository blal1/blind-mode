using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Android;

public sealed class AndroidConfiguration : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr__colorMode_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__densityDpi_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__fontScale_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__fontWeightAdjustment_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__keyboard_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__hardKeyboardHidden_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__keyboardHidden_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__mobileCountryCode_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__mobileNetworkCode_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__navigation_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__navigationHidden_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__orientation_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__screenHeightDp_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__screenWidthDp_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__smallestScreenWidthDp_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__screenLayout_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__touchScreen_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__uiMode_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__primaryLocaleCountry_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__primaryLocaleLanguage_k__BackingField;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_colorMode_Private_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_densityDpi_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_fontScale_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_fontWeightAdjustment_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_keyboard_Public_get_AndroidKeyboard_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_hardKeyboardHidden_Public_get_AndroidHardwareKeyboardHidden_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_keyboardHidden_Public_get_AndroidKeyboardHidden_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_mobileCountryCode_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_mobileNetworkCode_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_navigation_Public_get_AndroidNavigation_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_navigationHidden_Public_get_AndroidNavigationHidden_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_orientation_Public_get_AndroidOrientation_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_screenHeightDp_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_screenWidthDp_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_smallestScreenWidthDp_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_screenLayout_Private_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_touchScreen_Public_get_AndroidTouchScreen_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_uiMode_Private_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_primaryLocaleCountry_Private_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_primaryLocaleLanguage_Private_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_locales_Public_get_Il2CppReferenceArray_1_AndroidLocale_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_colorModeHdr_Public_get_AndroidColorModeHdr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_colorModeWideColorGamut_Public_get_AndroidColorModeWideColorGamut_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_screenLayoutDirection_Public_get_AndroidScreenLayoutDirection_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_screenLayoutLong_Public_get_AndroidScreenLayoutLong_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_screenLayoutRound_Public_get_AndroidScreenLayoutRound_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_screenLayoutSize_Public_get_AndroidScreenLayoutSize_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_uiModeNight_Public_get_AndroidUIModeNight_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_uiModeType_Public_get_AndroidUIModeType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

	public const int UiModeNightMask = 48;

	public const int UiModeTypeMask = 15;

	public const int ScreenLayoutDirectionMask = 192;

	public const int ScreenLayoutLongMask = 48;

	public const int ScreenLayoutRoundMask = 768;

	public const int ScreenLayoutSizeMask = 15;

	public const int ColorModeHdrMask = 12;

	public const int ColorModeWideColorGamutMask = 3;

	public unsafe int _colorMode_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__colorMode_k__BackingField);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__colorMode_k__BackingField)) = value;
		}
	}

	public unsafe int _densityDpi_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__densityDpi_k__BackingField);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__densityDpi_k__BackingField)) = value;
		}
	}

	public unsafe float _fontScale_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__fontScale_k__BackingField);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__fontScale_k__BackingField)) = value;
		}
	}

	public unsafe int _fontWeightAdjustment_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__fontWeightAdjustment_k__BackingField);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__fontWeightAdjustment_k__BackingField)) = value;
		}
	}

	public unsafe AndroidKeyboard _keyboard_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__keyboard_k__BackingField);
			return *(AndroidKeyboard*)num;
		}
		set
		{
			*(AndroidKeyboard*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__keyboard_k__BackingField)) = value;
		}
	}

	public unsafe AndroidHardwareKeyboardHidden _hardKeyboardHidden_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__hardKeyboardHidden_k__BackingField);
			return *(AndroidHardwareKeyboardHidden*)num;
		}
		set
		{
			*(AndroidHardwareKeyboardHidden*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__hardKeyboardHidden_k__BackingField)) = value;
		}
	}

	public unsafe AndroidKeyboardHidden _keyboardHidden_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__keyboardHidden_k__BackingField);
			return *(AndroidKeyboardHidden*)num;
		}
		set
		{
			*(AndroidKeyboardHidden*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__keyboardHidden_k__BackingField)) = value;
		}
	}

	public unsafe int _mobileCountryCode_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__mobileCountryCode_k__BackingField);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__mobileCountryCode_k__BackingField)) = value;
		}
	}

	public unsafe int _mobileNetworkCode_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__mobileNetworkCode_k__BackingField);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__mobileNetworkCode_k__BackingField)) = value;
		}
	}

	public unsafe AndroidNavigation _navigation_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__navigation_k__BackingField);
			return *(AndroidNavigation*)num;
		}
		set
		{
			*(AndroidNavigation*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__navigation_k__BackingField)) = value;
		}
	}

	public unsafe AndroidNavigationHidden _navigationHidden_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__navigationHidden_k__BackingField);
			return *(AndroidNavigationHidden*)num;
		}
		set
		{
			*(AndroidNavigationHidden*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__navigationHidden_k__BackingField)) = value;
		}
	}

	public unsafe AndroidOrientation _orientation_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__orientation_k__BackingField);
			return *(AndroidOrientation*)num;
		}
		set
		{
			*(AndroidOrientation*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__orientation_k__BackingField)) = value;
		}
	}

	public unsafe int _screenHeightDp_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__screenHeightDp_k__BackingField);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__screenHeightDp_k__BackingField)) = value;
		}
	}

	public unsafe int _screenWidthDp_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__screenWidthDp_k__BackingField);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__screenWidthDp_k__BackingField)) = value;
		}
	}

	public unsafe int _smallestScreenWidthDp_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__smallestScreenWidthDp_k__BackingField);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__smallestScreenWidthDp_k__BackingField)) = value;
		}
	}

	public unsafe int _screenLayout_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__screenLayout_k__BackingField);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__screenLayout_k__BackingField)) = value;
		}
	}

	public unsafe AndroidTouchScreen _touchScreen_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__touchScreen_k__BackingField);
			return *(AndroidTouchScreen*)num;
		}
		set
		{
			*(AndroidTouchScreen*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__touchScreen_k__BackingField)) = value;
		}
	}

	public unsafe int _uiMode_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__uiMode_k__BackingField);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__uiMode_k__BackingField)) = value;
		}
	}

	public unsafe string _primaryLocaleCountry_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__primaryLocaleCountry_k__BackingField);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__primaryLocaleCountry_k__BackingField)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string _primaryLocaleLanguage_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__primaryLocaleLanguage_k__BackingField);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__primaryLocaleLanguage_k__BackingField)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe int colorMode
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 50668, RefRangeEnd = 50669, XrefRangeStart = 50668, XrefRangeEnd = 50669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_colorMode_Private_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			_colorMode_k__BackingField = value;
		}
	}

	public unsafe int densityDpi
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 82717, RefRangeEnd = 82718, XrefRangeStart = 82717, XrefRangeEnd = 82718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_densityDpi_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			_densityDpi_k__BackingField = value;
		}
	}

	public unsafe float fontScale
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_fontScale_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			_fontScale_k__BackingField = value;
		}
	}

	public unsafe int fontWeightAdjustment
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_fontWeightAdjustment_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			_fontWeightAdjustment_k__BackingField = value;
		}
	}

	public unsafe AndroidKeyboard keyboard
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 63233, RefRangeEnd = 63234, XrefRangeStart = 63233, XrefRangeEnd = 63234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_keyboard_Public_get_AndroidKeyboard_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(AndroidKeyboard*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			_keyboard_k__BackingField = value;
		}
	}

	public unsafe AndroidHardwareKeyboardHidden hardKeyboardHidden
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_hardKeyboardHidden_Public_get_AndroidHardwareKeyboardHidden_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(AndroidHardwareKeyboardHidden*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			_hardKeyboardHidden_k__BackingField = value;
		}
	}

	public unsafe AndroidKeyboardHidden keyboardHidden
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 80842, RefRangeEnd = 80843, XrefRangeStart = 80842, XrefRangeEnd = 80843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_keyboardHidden_Public_get_AndroidKeyboardHidden_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(AndroidKeyboardHidden*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			_keyboardHidden_k__BackingField = value;
		}
	}

	public unsafe int mobileCountryCode
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_mobileCountryCode_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			_mobileCountryCode_k__BackingField = value;
		}
	}

	public unsafe int mobileNetworkCode
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 66330, RefRangeEnd = 66331, XrefRangeStart = 66330, XrefRangeEnd = 66331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_mobileNetworkCode_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			_mobileNetworkCode_k__BackingField = value;
		}
	}

	public unsafe AndroidNavigation navigation
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 65293, RefRangeEnd = 65294, XrefRangeStart = 65293, XrefRangeEnd = 65294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_navigation_Public_get_AndroidNavigation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(AndroidNavigation*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			_navigation_k__BackingField = value;
		}
	}

	public unsafe AndroidNavigationHidden navigationHidden
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_navigationHidden_Public_get_AndroidNavigationHidden_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(AndroidNavigationHidden*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			_navigationHidden_k__BackingField = value;
		}
	}

	public unsafe AndroidOrientation orientation
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_orientation_Public_get_AndroidOrientation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(AndroidOrientation*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			_orientation_k__BackingField = value;
		}
	}

	public unsafe int screenHeightDp
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_screenHeightDp_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			_screenHeightDp_k__BackingField = value;
		}
	}

	public unsafe int screenWidthDp
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_screenWidthDp_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			_screenWidthDp_k__BackingField = value;
		}
	}

	public unsafe int smallestScreenWidthDp
	{
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 174524, RefRangeEnd = 174528, XrefRangeStart = 174524, XrefRangeEnd = 174528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_smallestScreenWidthDp_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			_smallestScreenWidthDp_k__BackingField = value;
		}
	}

	public unsafe int screenLayout
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_screenLayout_Private_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			_screenLayout_k__BackingField = value;
		}
	}

	public unsafe AndroidTouchScreen touchScreen
	{
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 180373, RefRangeEnd = 180378, XrefRangeStart = 180373, XrefRangeEnd = 180378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_touchScreen_Public_get_AndroidTouchScreen_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(AndroidTouchScreen*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			_touchScreen_k__BackingField = value;
		}
	}

	public unsafe int uiMode
	{
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 148973, RefRangeEnd = 148983, XrefRangeStart = 148973, XrefRangeEnd = 148983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_uiMode_Private_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			_uiMode_k__BackingField = value;
		}
	}

	public unsafe string primaryLocaleCountry
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 84632, RefRangeEnd = 84633, XrefRangeStart = 84632, XrefRangeEnd = 84633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_primaryLocaleCountry_Private_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
		set
		{
			_primaryLocaleCountry_k__BackingField = value;
		}
	}

	public unsafe string primaryLocaleLanguage
	{
		[CallerCount(45)]
		[CachedScanResults(RefRangeStart = 162634, RefRangeEnd = 162679, XrefRangeStart = 162634, XrefRangeEnd = 162679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_primaryLocaleLanguage_Private_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
		set
		{
			_primaryLocaleLanguage_k__BackingField = value;
		}
	}

	public unsafe Il2CppReferenceArray<AndroidLocale> locales
	{
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1151664, RefRangeEnd = 1151668, XrefRangeStart = 1151651, XrefRangeEnd = 1151664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_locales_Public_get_Il2CppReferenceArray_1_AndroidLocale_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AndroidLocale>>(intPtr2) : null;
		}
	}

	public unsafe AndroidColorModeHdr colorModeHdr
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_colorModeHdr_Public_get_AndroidColorModeHdr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(AndroidColorModeHdr*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe AndroidColorModeWideColorGamut colorModeWideColorGamut
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_colorModeWideColorGamut_Public_get_AndroidColorModeWideColorGamut_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(AndroidColorModeWideColorGamut*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe AndroidScreenLayoutDirection screenLayoutDirection
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_screenLayoutDirection_Public_get_AndroidScreenLayoutDirection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(AndroidScreenLayoutDirection*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe AndroidScreenLayoutLong screenLayoutLong
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_screenLayoutLong_Public_get_AndroidScreenLayoutLong_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(AndroidScreenLayoutLong*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe AndroidScreenLayoutRound screenLayoutRound
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_screenLayoutRound_Public_get_AndroidScreenLayoutRound_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(AndroidScreenLayoutRound*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe AndroidScreenLayoutSize screenLayoutSize
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_screenLayoutSize_Public_get_AndroidScreenLayoutSize_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(AndroidScreenLayoutSize*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe AndroidUIModeNight uiModeNight
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_uiModeNight_Public_get_AndroidUIModeNight_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(AndroidUIModeNight*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe AndroidUIModeType uiModeType
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_uiModeType_Public_get_AndroidUIModeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(AndroidUIModeType*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static AndroidConfiguration()
	{
		Il2CppClassPointerStore<AndroidConfiguration>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AndroidJNIModule.dll", "UnityEngine.Android", "AndroidConfiguration");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AndroidConfiguration>.NativeClassPtr);
		NativeFieldInfoPtr__colorMode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidConfiguration>.NativeClassPtr, "<colorMode>k__BackingField");
		NativeFieldInfoPtr__densityDpi_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidConfiguration>.NativeClassPtr, "<densityDpi>k__BackingField");
		NativeFieldInfoPtr__fontScale_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidConfiguration>.NativeClassPtr, "<fontScale>k__BackingField");
		NativeFieldInfoPtr__fontWeightAdjustment_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidConfiguration>.NativeClassPtr, "<fontWeightAdjustment>k__BackingField");
		NativeFieldInfoPtr__keyboard_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidConfiguration>.NativeClassPtr, "<keyboard>k__BackingField");
		NativeFieldInfoPtr__hardKeyboardHidden_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidConfiguration>.NativeClassPtr, "<hardKeyboardHidden>k__BackingField");
		NativeFieldInfoPtr__keyboardHidden_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidConfiguration>.NativeClassPtr, "<keyboardHidden>k__BackingField");
		NativeFieldInfoPtr__mobileCountryCode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidConfiguration>.NativeClassPtr, "<mobileCountryCode>k__BackingField");
		NativeFieldInfoPtr__mobileNetworkCode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidConfiguration>.NativeClassPtr, "<mobileNetworkCode>k__BackingField");
		NativeFieldInfoPtr__navigation_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidConfiguration>.NativeClassPtr, "<navigation>k__BackingField");
		NativeFieldInfoPtr__navigationHidden_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidConfiguration>.NativeClassPtr, "<navigationHidden>k__BackingField");
		NativeFieldInfoPtr__orientation_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidConfiguration>.NativeClassPtr, "<orientation>k__BackingField");
		NativeFieldInfoPtr__screenHeightDp_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidConfiguration>.NativeClassPtr, "<screenHeightDp>k__BackingField");
		NativeFieldInfoPtr__screenWidthDp_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidConfiguration>.NativeClassPtr, "<screenWidthDp>k__BackingField");
		NativeFieldInfoPtr__smallestScreenWidthDp_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidConfiguration>.NativeClassPtr, "<smallestScreenWidthDp>k__BackingField");
		NativeFieldInfoPtr__screenLayout_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidConfiguration>.NativeClassPtr, "<screenLayout>k__BackingField");
		NativeFieldInfoPtr__touchScreen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidConfiguration>.NativeClassPtr, "<touchScreen>k__BackingField");
		NativeFieldInfoPtr__uiMode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidConfiguration>.NativeClassPtr, "<uiMode>k__BackingField");
		NativeFieldInfoPtr__primaryLocaleCountry_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidConfiguration>.NativeClassPtr, "<primaryLocaleCountry>k__BackingField");
		NativeFieldInfoPtr__primaryLocaleLanguage_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidConfiguration>.NativeClassPtr, "<primaryLocaleLanguage>k__BackingField");
		NativeMethodInfoPtr_get_colorMode_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidConfiguration>.NativeClassPtr, 100663569);
		NativeMethodInfoPtr_get_densityDpi_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidConfiguration>.NativeClassPtr, 100663570);
		NativeMethodInfoPtr_get_fontScale_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidConfiguration>.NativeClassPtr, 100663571);
		NativeMethodInfoPtr_get_fontWeightAdjustment_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidConfiguration>.NativeClassPtr, 100663572);
		NativeMethodInfoPtr_get_keyboard_Public_get_AndroidKeyboard_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidConfiguration>.NativeClassPtr, 100663573);
		NativeMethodInfoPtr_get_hardKeyboardHidden_Public_get_AndroidHardwareKeyboardHidden_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidConfiguration>.NativeClassPtr, 100663574);
		NativeMethodInfoPtr_get_keyboardHidden_Public_get_AndroidKeyboardHidden_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidConfiguration>.NativeClassPtr, 100663575);
		NativeMethodInfoPtr_get_mobileCountryCode_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidConfiguration>.NativeClassPtr, 100663576);
		NativeMethodInfoPtr_get_mobileNetworkCode_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidConfiguration>.NativeClassPtr, 100663577);
		NativeMethodInfoPtr_get_navigation_Public_get_AndroidNavigation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidConfiguration>.NativeClassPtr, 100663578);
		NativeMethodInfoPtr_get_navigationHidden_Public_get_AndroidNavigationHidden_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidConfiguration>.NativeClassPtr, 100663579);
		NativeMethodInfoPtr_get_orientation_Public_get_AndroidOrientation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidConfiguration>.NativeClassPtr, 100663580);
		NativeMethodInfoPtr_get_screenHeightDp_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidConfiguration>.NativeClassPtr, 100663581);
		NativeMethodInfoPtr_get_screenWidthDp_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidConfiguration>.NativeClassPtr, 100663582);
		NativeMethodInfoPtr_get_smallestScreenWidthDp_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidConfiguration>.NativeClassPtr, 100663583);
		NativeMethodInfoPtr_get_screenLayout_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidConfiguration>.NativeClassPtr, 100663584);
		NativeMethodInfoPtr_get_touchScreen_Public_get_AndroidTouchScreen_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidConfiguration>.NativeClassPtr, 100663585);
		NativeMethodInfoPtr_get_uiMode_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidConfiguration>.NativeClassPtr, 100663586);
		NativeMethodInfoPtr_get_primaryLocaleCountry_Private_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidConfiguration>.NativeClassPtr, 100663587);
		NativeMethodInfoPtr_get_primaryLocaleLanguage_Private_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidConfiguration>.NativeClassPtr, 100663588);
		NativeMethodInfoPtr_get_locales_Public_get_Il2CppReferenceArray_1_AndroidLocale_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidConfiguration>.NativeClassPtr, 100663589);
		NativeMethodInfoPtr_get_colorModeHdr_Public_get_AndroidColorModeHdr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidConfiguration>.NativeClassPtr, 100663590);
		NativeMethodInfoPtr_get_colorModeWideColorGamut_Public_get_AndroidColorModeWideColorGamut_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidConfiguration>.NativeClassPtr, 100663591);
		NativeMethodInfoPtr_get_screenLayoutDirection_Public_get_AndroidScreenLayoutDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidConfiguration>.NativeClassPtr, 100663592);
		NativeMethodInfoPtr_get_screenLayoutLong_Public_get_AndroidScreenLayoutLong_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidConfiguration>.NativeClassPtr, 100663593);
		NativeMethodInfoPtr_get_screenLayoutRound_Public_get_AndroidScreenLayoutRound_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidConfiguration>.NativeClassPtr, 100663594);
		NativeMethodInfoPtr_get_screenLayoutSize_Public_get_AndroidScreenLayoutSize_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidConfiguration>.NativeClassPtr, 100663595);
		NativeMethodInfoPtr_get_uiModeNight_Public_get_AndroidUIModeNight_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidConfiguration>.NativeClassPtr, 100663596);
		NativeMethodInfoPtr_get_uiModeType_Public_get_AndroidUIModeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidConfiguration>.NativeClassPtr, 100663597);
		NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidConfiguration>.NativeClassPtr, 100663598);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1151668, XrefRangeEnd = 1151842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override string ToString()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	public AndroidConfiguration(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public void CopyFrom(AndroidConfiguration otherConfiguration)
	{
		colorMode = otherConfiguration.colorMode;
		densityDpi = otherConfiguration.densityDpi;
		fontScale = otherConfiguration.fontScale;
		fontWeightAdjustment = otherConfiguration.fontWeightAdjustment;
		keyboard = otherConfiguration.keyboard;
		hardKeyboardHidden = otherConfiguration.hardKeyboardHidden;
		keyboardHidden = otherConfiguration.keyboardHidden;
		mobileCountryCode = otherConfiguration.mobileCountryCode;
		mobileNetworkCode = otherConfiguration.mobileNetworkCode;
		navigation = otherConfiguration.navigation;
		navigationHidden = otherConfiguration.navigationHidden;
		orientation = otherConfiguration.orientation;
		screenHeightDp = otherConfiguration.screenHeightDp;
		screenWidthDp = otherConfiguration.screenWidthDp;
		smallestScreenWidthDp = otherConfiguration.smallestScreenWidthDp;
		screenLayout = otherConfiguration.screenLayout;
		touchScreen = otherConfiguration.touchScreen;
		uiMode = otherConfiguration.uiMode;
		primaryLocaleCountry = otherConfiguration.primaryLocaleCountry;
		primaryLocaleLanguage = otherConfiguration.primaryLocaleLanguage;
	}
}
