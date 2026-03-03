using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Experimental.Rendering;

namespace UnityEngine;

public class HDROutputSettings : Il2CppSystem.Object
{
	private delegate void SetPaperWhiteNitsDelegate(int displayIndex, float paperWhite);

	private static readonly System.IntPtr NativeFieldInfoPtr_m_DisplayIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_displays;

	private static readonly System.IntPtr NativeFieldInfoPtr__mainDisplay;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_main_Public_Static_get_HDROutputSettings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_active_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_available_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_automaticHDRTonemapping_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_automaticHDRTonemapping_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_displayColorGamut_Public_get_ColorGamut_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_graphicsFormat_Public_get_GraphicsFormat_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_paperWhiteNits_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_maxFullFrameToneMapLuminance_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_maxToneMapLuminance_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_minToneMapLuminance_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_HDRModeChangeRequested_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RequestHDRModeChange_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetActive_Private_Static_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAvailable_Private_Static_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAutomaticHDRTonemapping_Private_Static_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetAutomaticHDRTonemapping_Private_Static_Void_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDisplayColorGamut_Private_Static_ColorGamut_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetGraphicsFormat_Private_Static_GraphicsFormat_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPaperWhiteNits_Private_Static_Single_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMaxFullFrameToneMapLuminance_Private_Static_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMaxToneMapLuminance_Private_Static_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMinToneMapLuminance_Private_Static_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHDRModeChangeRequested_Private_Static_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RequestHDRModeChangeInternal_Private_Static_Void_Int32_Boolean_0;

	private static readonly SetPaperWhiteNitsDelegate SetPaperWhiteNitsDelegateField;

	public unsafe int m_DisplayIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DisplayIndex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DisplayIndex)) = value;
		}
	}

	public unsafe static Il2CppReferenceArray<HDROutputSettings> displays
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_displays, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<HDROutputSettings>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_displays, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static HDROutputSettings _mainDisplay
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__mainDisplay, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<HDROutputSettings>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__mainDisplay, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static HDROutputSettings main
	{
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 1173327, RefRangeEnd = 1173341, XrefRangeStart = 1173323, XrefRangeEnd = 1173327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_main_Public_Static_get_HDROutputSettings_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<HDROutputSettings>(intPtr2) : null;
		}
	}

	public unsafe bool active
	{
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1173346, RefRangeEnd = 1173354, XrefRangeStart = 1173341, XrefRangeEnd = 1173346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_active_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool available
	{
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 1173359, RefRangeEnd = 1173371, XrefRangeStart = 1173354, XrefRangeEnd = 1173359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_available_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool automaticHDRTonemapping
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1173371, XrefRangeEnd = 1173376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_automaticHDRTonemapping_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1173381, RefRangeEnd = 1173383, XrefRangeStart = 1173376, XrefRangeEnd = 1173381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_automaticHDRTonemapping_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe ColorGamut displayColorGamut
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1173388, RefRangeEnd = 1173391, XrefRangeStart = 1173383, XrefRangeEnd = 1173388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_displayColorGamut_Public_get_ColorGamut_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(ColorGamut*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe GraphicsFormat graphicsFormat
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1173391, XrefRangeEnd = 1173396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_graphicsFormat_Public_get_GraphicsFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(GraphicsFormat*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe float paperWhiteNits
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1173401, RefRangeEnd = 1173404, XrefRangeStart = 1173396, XrefRangeEnd = 1173401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_paperWhiteNits_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			SetPaperWhiteNits(m_DisplayIndex, value);
		}
	}

	public unsafe int maxFullFrameToneMapLuminance
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1173409, RefRangeEnd = 1173412, XrefRangeStart = 1173404, XrefRangeEnd = 1173409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_maxFullFrameToneMapLuminance_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe int maxToneMapLuminance
	{
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1173417, RefRangeEnd = 1173421, XrefRangeStart = 1173412, XrefRangeEnd = 1173417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_maxToneMapLuminance_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe int minToneMapLuminance
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1173426, RefRangeEnd = 1173429, XrefRangeStart = 1173421, XrefRangeEnd = 1173426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_minToneMapLuminance_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool HDRModeChangeRequested
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1173429, XrefRangeEnd = 1173434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_HDRModeChangeRequested_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public RenderTextureFormat format => GraphicsFormatUtility.GetRenderTextureFormat(GetGraphicsFormat(m_DisplayIndex));

	static HDROutputSettings()
	{
		Il2CppClassPointerStore<HDROutputSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "HDROutputSettings");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HDROutputSettings>.NativeClassPtr);
		NativeFieldInfoPtr_m_DisplayIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HDROutputSettings>.NativeClassPtr, "m_DisplayIndex");
		NativeFieldInfoPtr_displays = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HDROutputSettings>.NativeClassPtr, "displays");
		NativeFieldInfoPtr__mainDisplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HDROutputSettings>.NativeClassPtr, "_mainDisplay");
		NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDROutputSettings>.NativeClassPtr, 100664434);
		NativeMethodInfoPtr__ctor_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDROutputSettings>.NativeClassPtr, 100664435);
		NativeMethodInfoPtr_get_main_Public_Static_get_HDROutputSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDROutputSettings>.NativeClassPtr, 100664436);
		NativeMethodInfoPtr_get_active_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDROutputSettings>.NativeClassPtr, 100664437);
		NativeMethodInfoPtr_get_available_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDROutputSettings>.NativeClassPtr, 100664438);
		NativeMethodInfoPtr_get_automaticHDRTonemapping_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDROutputSettings>.NativeClassPtr, 100664439);
		NativeMethodInfoPtr_set_automaticHDRTonemapping_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDROutputSettings>.NativeClassPtr, 100664440);
		NativeMethodInfoPtr_get_displayColorGamut_Public_get_ColorGamut_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDROutputSettings>.NativeClassPtr, 100664441);
		NativeMethodInfoPtr_get_graphicsFormat_Public_get_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDROutputSettings>.NativeClassPtr, 100664442);
		NativeMethodInfoPtr_get_paperWhiteNits_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDROutputSettings>.NativeClassPtr, 100664443);
		NativeMethodInfoPtr_get_maxFullFrameToneMapLuminance_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDROutputSettings>.NativeClassPtr, 100664444);
		NativeMethodInfoPtr_get_maxToneMapLuminance_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDROutputSettings>.NativeClassPtr, 100664445);
		NativeMethodInfoPtr_get_minToneMapLuminance_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDROutputSettings>.NativeClassPtr, 100664446);
		NativeMethodInfoPtr_get_HDRModeChangeRequested_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDROutputSettings>.NativeClassPtr, 100664447);
		NativeMethodInfoPtr_RequestHDRModeChange_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDROutputSettings>.NativeClassPtr, 100664448);
		NativeMethodInfoPtr_GetActive_Private_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDROutputSettings>.NativeClassPtr, 100664449);
		NativeMethodInfoPtr_GetAvailable_Private_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDROutputSettings>.NativeClassPtr, 100664450);
		NativeMethodInfoPtr_GetAutomaticHDRTonemapping_Private_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDROutputSettings>.NativeClassPtr, 100664451);
		NativeMethodInfoPtr_SetAutomaticHDRTonemapping_Private_Static_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDROutputSettings>.NativeClassPtr, 100664452);
		NativeMethodInfoPtr_GetDisplayColorGamut_Private_Static_ColorGamut_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDROutputSettings>.NativeClassPtr, 100664453);
		NativeMethodInfoPtr_GetGraphicsFormat_Private_Static_GraphicsFormat_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDROutputSettings>.NativeClassPtr, 100664454);
		NativeMethodInfoPtr_GetPaperWhiteNits_Private_Static_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDROutputSettings>.NativeClassPtr, 100664455);
		NativeMethodInfoPtr_GetMaxFullFrameToneMapLuminance_Private_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDROutputSettings>.NativeClassPtr, 100664456);
		NativeMethodInfoPtr_GetMaxToneMapLuminance_Private_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDROutputSettings>.NativeClassPtr, 100664457);
		NativeMethodInfoPtr_GetMinToneMapLuminance_Private_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDROutputSettings>.NativeClassPtr, 100664458);
		NativeMethodInfoPtr_GetHDRModeChangeRequested_Private_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDROutputSettings>.NativeClassPtr, 100664459);
		NativeMethodInfoPtr_RequestHDRModeChangeInternal_Private_Static_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDROutputSettings>.NativeClassPtr, 100664460);
		SetPaperWhiteNitsDelegateField = IL2CPP.ResolveICall<SetPaperWhiteNitsDelegate>("UnityEngine.HDROutputSettings::SetPaperWhiteNits");
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 601491, RefRangeEnd = 601493, XrefRangeStart = 601491, XrefRangeEnd = 601493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe HDROutputSettings()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HDROutputSettings>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(207)]
	[CachedScanResults(RefRangeStart = 25387, RefRangeEnd = 25594, XrefRangeStart = 25387, XrefRangeEnd = 25594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe HDROutputSettings(int displayIndex)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HDROutputSettings>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&displayIndex);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1173439, RefRangeEnd = 1173441, XrefRangeStart = 1173434, XrefRangeEnd = 1173439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RequestHDRModeChange(bool enabled)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&enabled);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RequestHDRModeChange_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1173441, XrefRangeEnd = 1173443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool GetActive(int displayIndex)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&displayIndex);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetActive_Private_Static_Boolean_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1173443, XrefRangeEnd = 1173445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool GetAvailable(int displayIndex)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&displayIndex);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAvailable_Private_Static_Boolean_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1173445, XrefRangeEnd = 1173447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool GetAutomaticHDRTonemapping(int displayIndex)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&displayIndex);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAutomaticHDRTonemapping_Private_Static_Boolean_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1173447, XrefRangeEnd = 1173468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetAutomaticHDRTonemapping(int displayIndex, bool scripted)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&displayIndex);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &scripted;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetAutomaticHDRTonemapping_Private_Static_Void_Int32_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1173468, XrefRangeEnd = 1173470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ColorGamut GetDisplayColorGamut(int displayIndex)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&displayIndex);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDisplayColorGamut_Private_Static_ColorGamut_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(ColorGamut*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1173470, XrefRangeEnd = 1173472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static GraphicsFormat GetGraphicsFormat(int displayIndex)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&displayIndex);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetGraphicsFormat_Private_Static_GraphicsFormat_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(GraphicsFormat*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1173472, XrefRangeEnd = 1173474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float GetPaperWhiteNits(int displayIndex)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&displayIndex);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPaperWhiteNits_Private_Static_Single_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1173474, XrefRangeEnd = 1173476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetMaxFullFrameToneMapLuminance(int displayIndex)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&displayIndex);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMaxFullFrameToneMapLuminance_Private_Static_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1173476, XrefRangeEnd = 1173478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetMaxToneMapLuminance(int displayIndex)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&displayIndex);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMaxToneMapLuminance_Private_Static_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1173478, XrefRangeEnd = 1173480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetMinToneMapLuminance(int displayIndex)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&displayIndex);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMinToneMapLuminance_Private_Static_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1173480, XrefRangeEnd = 1173482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool GetHDRModeChangeRequested(int displayIndex)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&displayIndex);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHDRModeChangeRequested_Private_Static_Boolean_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1173482, XrefRangeEnd = 1173484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RequestHDRModeChangeInternal(int displayIndex, bool enabled)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&displayIndex);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &enabled;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RequestHDRModeChangeInternal_Private_Static_Void_Int32_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public HDROutputSettings(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public static void SetPaperWhiteInNits(float paperWhite)
	{
		int displayIndex = 0;
		if (GetAvailable(displayIndex))
		{
			SetPaperWhiteNits(displayIndex, paperWhite);
		}
	}

	public static void SetPaperWhiteNits(int displayIndex, float paperWhite)
	{
		SetPaperWhiteNitsDelegateField(displayIndex, paperWhite);
	}
}
