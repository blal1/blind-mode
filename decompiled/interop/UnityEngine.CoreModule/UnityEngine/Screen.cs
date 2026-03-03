using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Bindings;

namespace UnityEngine;

public sealed class Screen : Il2CppSystem.Object
{
	private delegate void RequestOrientationDelegate(ScreenOrientation orient);

	private delegate int get_sleepTimeoutDelegate();

	private delegate bool IsOrientationEnabledDelegate(EnabledOrientation orient);

	private delegate FullScreenMode get_fullScreenModeDelegate();

	private delegate void set_fullScreenModeDelegate(FullScreenMode value);

	private delegate float get_brightnessDelegate();

	private delegate void set_brightnessDelegate(float value);

	private delegate void get_cutouts_InjectedDelegate([Out] System.IntPtr ret);

	private static readonly System.IntPtr NativeMethodInfoPtr_get_width_Public_Static_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_height_Public_Static_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_dpi_Public_Static_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetScreenOrientation_Private_Static_ScreenOrientation_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_orientation_Public_Static_get_ScreenOrientation_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_sleepTimeout_Public_Static_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetOrientationEnabled_Private_Static_Void_EnabledOrientation_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_autorotateToPortraitUpsideDown_Public_Static_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_autorotateToLandscapeLeft_Public_Static_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_autorotateToLandscapeRight_Public_Static_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_currentResolution_Public_Static_get_Resolution_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_fullScreen_Public_Static_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_fullScreen_Public_Static_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_safeArea_Public_Static_get_Rect_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetResolution_Public_Static_Void_Int32_Int32_FullScreenMode_RefreshRate_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetResolution_Public_Static_Void_Int32_Int32_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetResolution_Public_Static_Void_Int32_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetMSAASamples_Public_Static_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMSAASamples_Private_Static_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_msaaSamples_Public_Static_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_mainWindowPosition_Public_Static_get_Vector2Int_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMainWindowPosition_Private_Static_Vector2Int_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_resolutions_Public_Static_get_Il2CppStructArray_1_Resolution_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_currentResolution_Injected_Private_Static_Void_byref_Resolution_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_safeArea_Injected_Private_Static_Void_byref_Rect_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetResolution_Injected_Private_Static_Void_Int32_Int32_FullScreenMode_byref_RefreshRate_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMainWindowPosition_Injected_Private_Static_Void_byref_Vector2Int_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_resolutions_Injected_Private_Static_Void_byref_BlittableArrayWrapper_0;

	private static readonly RequestOrientationDelegate RequestOrientationDelegateField;

	private static readonly get_sleepTimeoutDelegate get_sleepTimeoutDelegateField;

	private static readonly IsOrientationEnabledDelegate IsOrientationEnabledDelegateField;

	private static readonly get_fullScreenModeDelegate get_fullScreenModeDelegateField;

	private static readonly set_fullScreenModeDelegate set_fullScreenModeDelegateField;

	private static readonly get_brightnessDelegate get_brightnessDelegateField;

	private static readonly set_brightnessDelegate set_brightnessDelegateField;

	private static readonly get_cutouts_InjectedDelegate get_cutouts_InjectedDelegateField;

	public unsafe static int width
	{
		[CallerCount(92)]
		[CachedScanResults(RefRangeStart = 1172261, RefRangeEnd = 1172353, XrefRangeStart = 1172259, XrefRangeEnd = 1172261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_width_Public_Static_get_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static int height
	{
		[CallerCount(108)]
		[CachedScanResults(RefRangeStart = 1172355, RefRangeEnd = 1172463, XrefRangeStart = 1172353, XrefRangeEnd = 1172355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_height_Public_Static_get_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static float dpi
	{
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1172465, RefRangeEnd = 1172473, XrefRangeStart = 1172463, XrefRangeEnd = 1172465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_dpi_Public_Static_get_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static ScreenOrientation orientation
	{
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1172475, RefRangeEnd = 1172479, XrefRangeStart = 1172475, XrefRangeEnd = 1172479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_orientation_Public_Static_get_ScreenOrientation_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(ScreenOrientation*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			if (value == ScreenOrientation.Unknown)
			{
				Debug.Log("ScreenOrientation.Unknown is deprecated. Please use ScreenOrientation.AutoRotation");
				value = ScreenOrientation.AutoRotation;
			}
			RequestOrientation(value);
		}
	}

	public unsafe static int sleepTimeout
	{
		get
		{
			return get_sleepTimeoutDelegateField();
		}
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 1172481, RefRangeEnd = 1172494, XrefRangeStart = 1172479, XrefRangeEnd = 1172481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_sleepTimeout_Public_Static_set_Void_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe static bool autorotateToPortraitUpsideDown
	{
		get
		{
			return IsOrientationEnabled(EnabledOrientation.kAutorotateToPortraitUpsideDown);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1172498, RefRangeEnd = 1172499, XrefRangeStart = 1172496, XrefRangeEnd = 1172498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_autorotateToPortraitUpsideDown_Public_Static_set_Void_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe static bool autorotateToLandscapeLeft
	{
		get
		{
			return IsOrientationEnabled(EnabledOrientation.kAutorotateToLandscapeLeft);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1172501, RefRangeEnd = 1172502, XrefRangeStart = 1172499, XrefRangeEnd = 1172501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_autorotateToLandscapeLeft_Public_Static_set_Void_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe static bool autorotateToLandscapeRight
	{
		get
		{
			return IsOrientationEnabled(EnabledOrientation.kAutorotateToLandscapeRight);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1172504, RefRangeEnd = 1172505, XrefRangeStart = 1172502, XrefRangeEnd = 1172504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_autorotateToLandscapeRight_Public_Static_set_Void_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe static Resolution currentResolution
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1172507, RefRangeEnd = 1172509, XrefRangeStart = 1172505, XrefRangeEnd = 1172507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_currentResolution_Public_Static_get_Resolution_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Resolution*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static bool fullScreen
	{
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 1172511, RefRangeEnd = 1172523, XrefRangeStart = 1172509, XrefRangeEnd = 1172511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_fullScreen_Public_Static_get_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1172525, RefRangeEnd = 1172528, XrefRangeStart = 1172523, XrefRangeEnd = 1172525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_fullScreen_Public_Static_set_Void_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe static Rect safeArea
	{
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1172530, RefRangeEnd = 1172534, XrefRangeStart = 1172528, XrefRangeEnd = 1172530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_safeArea_Public_Static_get_Rect_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Rect*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static int msaaSamples
	{
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1172551, RefRangeEnd = 1172555, XrefRangeStart = 1172551, XrefRangeEnd = 1172555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_msaaSamples_Public_Static_get_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static Vector2Int mainWindowPosition
	{
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1172557, RefRangeEnd = 1172563, XrefRangeStart = 1172555, XrefRangeEnd = 1172557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_mainWindowPosition_Public_Static_get_Vector2Int_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Vector2Int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static Il2CppStructArray<Resolution> resolutions
	{
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1172569, RefRangeEnd = 1172575, XrefRangeStart = 1172563, XrefRangeEnd = 1172569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_resolutions_Public_Static_get_Il2CppStructArray_1_Resolution_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Resolution>>(intPtr2) : null;
		}
	}

	public static bool autorotateToPortrait
	{
		get
		{
			return IsOrientationEnabled(EnabledOrientation.kAutorotateToPortrait);
		}
		set
		{
			SetOrientationEnabled(EnabledOrientation.kAutorotateToPortrait, value);
		}
	}

	public static FullScreenMode fullScreenMode
	{
		get
		{
			return get_fullScreenModeDelegateField();
		}
		set
		{
			set_fullScreenModeDelegateField(value);
		}
	}

	public unsafe static Il2CppStructArray<Rect> cutouts
	{
		get
		{
			Unsafe.SkipInit(out BlittableArrayWrapper ret);
			Il2CppStructArray<Rect> result;
			try
			{
				get_cutouts_Injected(out ret);
			}
			finally
			{
				Unsafe.SkipInit(out Il2CppStructArray<Rect> array);
				ret.Unmarshal(ref *(Il2CppArrayBase<Rect>*)(&array));
				result = array;
			}
			return result;
		}
	}

	public static float brightness
	{
		get
		{
			return get_brightnessDelegateField();
		}
		set
		{
			set_brightnessDelegateField(value);
		}
	}

	public static bool lockCursor
	{
		get
		{
			return CursorLockMode.Locked == Cursor.lockState;
		}
		set
		{
			if (value)
			{
				Cursor.visible = false;
				Cursor.lockState = CursorLockMode.Locked;
			}
			else
			{
				Cursor.lockState = CursorLockMode.None;
				Cursor.visible = true;
			}
		}
	}

	static Screen()
	{
		Il2CppClassPointerStore<Screen>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Screen");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Screen>.NativeClassPtr);
		NativeMethodInfoPtr_get_width_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Screen>.NativeClassPtr, 100664319);
		NativeMethodInfoPtr_get_height_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Screen>.NativeClassPtr, 100664320);
		NativeMethodInfoPtr_get_dpi_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Screen>.NativeClassPtr, 100664321);
		NativeMethodInfoPtr_GetScreenOrientation_Private_Static_ScreenOrientation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Screen>.NativeClassPtr, 100664322);
		NativeMethodInfoPtr_get_orientation_Public_Static_get_ScreenOrientation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Screen>.NativeClassPtr, 100664323);
		NativeMethodInfoPtr_set_sleepTimeout_Public_Static_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Screen>.NativeClassPtr, 100664324);
		NativeMethodInfoPtr_SetOrientationEnabled_Private_Static_Void_EnabledOrientation_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Screen>.NativeClassPtr, 100664325);
		NativeMethodInfoPtr_set_autorotateToPortraitUpsideDown_Public_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Screen>.NativeClassPtr, 100664326);
		NativeMethodInfoPtr_set_autorotateToLandscapeLeft_Public_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Screen>.NativeClassPtr, 100664327);
		NativeMethodInfoPtr_set_autorotateToLandscapeRight_Public_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Screen>.NativeClassPtr, 100664328);
		NativeMethodInfoPtr_get_currentResolution_Public_Static_get_Resolution_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Screen>.NativeClassPtr, 100664329);
		NativeMethodInfoPtr_get_fullScreen_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Screen>.NativeClassPtr, 100664330);
		NativeMethodInfoPtr_set_fullScreen_Public_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Screen>.NativeClassPtr, 100664331);
		NativeMethodInfoPtr_get_safeArea_Public_Static_get_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Screen>.NativeClassPtr, 100664332);
		NativeMethodInfoPtr_SetResolution_Public_Static_Void_Int32_Int32_FullScreenMode_RefreshRate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Screen>.NativeClassPtr, 100664333);
		NativeMethodInfoPtr_SetResolution_Public_Static_Void_Int32_Int32_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Screen>.NativeClassPtr, 100664334);
		NativeMethodInfoPtr_SetResolution_Public_Static_Void_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Screen>.NativeClassPtr, 100664335);
		NativeMethodInfoPtr_SetMSAASamples_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Screen>.NativeClassPtr, 100664336);
		NativeMethodInfoPtr_GetMSAASamples_Private_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Screen>.NativeClassPtr, 100664337);
		NativeMethodInfoPtr_get_msaaSamples_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Screen>.NativeClassPtr, 100664338);
		NativeMethodInfoPtr_get_mainWindowPosition_Public_Static_get_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Screen>.NativeClassPtr, 100664339);
		NativeMethodInfoPtr_GetMainWindowPosition_Private_Static_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Screen>.NativeClassPtr, 100664340);
		NativeMethodInfoPtr_get_resolutions_Public_Static_get_Il2CppStructArray_1_Resolution_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Screen>.NativeClassPtr, 100664341);
		NativeMethodInfoPtr_get_currentResolution_Injected_Private_Static_Void_byref_Resolution_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Screen>.NativeClassPtr, 100664342);
		NativeMethodInfoPtr_get_safeArea_Injected_Private_Static_Void_byref_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Screen>.NativeClassPtr, 100664343);
		NativeMethodInfoPtr_SetResolution_Injected_Private_Static_Void_Int32_Int32_FullScreenMode_byref_RefreshRate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Screen>.NativeClassPtr, 100664344);
		NativeMethodInfoPtr_GetMainWindowPosition_Injected_Private_Static_Void_byref_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Screen>.NativeClassPtr, 100664345);
		NativeMethodInfoPtr_get_resolutions_Injected_Private_Static_Void_byref_BlittableArrayWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Screen>.NativeClassPtr, 100664346);
		RequestOrientationDelegateField = IL2CPP.ResolveICall<RequestOrientationDelegate>("UnityEngine.Screen::RequestOrientation");
		get_sleepTimeoutDelegateField = IL2CPP.ResolveICall<get_sleepTimeoutDelegate>("UnityEngine.Screen::get_sleepTimeout");
		IsOrientationEnabledDelegateField = IL2CPP.ResolveICall<IsOrientationEnabledDelegate>("UnityEngine.Screen::IsOrientationEnabled");
		get_fullScreenModeDelegateField = IL2CPP.ResolveICall<get_fullScreenModeDelegate>("UnityEngine.Screen::get_fullScreenMode");
		set_fullScreenModeDelegateField = IL2CPP.ResolveICall<set_fullScreenModeDelegate>("UnityEngine.Screen::set_fullScreenMode");
		get_brightnessDelegateField = IL2CPP.ResolveICall<get_brightnessDelegate>("UnityEngine.Screen::get_brightness");
		set_brightnessDelegateField = IL2CPP.ResolveICall<set_brightnessDelegate>("UnityEngine.Screen::set_brightness");
		get_cutouts_InjectedDelegateField = IL2CPP.ResolveICall<get_cutouts_InjectedDelegate>("UnityEngine.Screen::get_cutouts_Injected");
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1172475, RefRangeEnd = 1172479, XrefRangeStart = 1172473, XrefRangeEnd = 1172475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ScreenOrientation GetScreenOrientation()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetScreenOrientation_Private_Static_ScreenOrientation_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(ScreenOrientation*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1172494, XrefRangeEnd = 1172496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetOrientationEnabled(EnabledOrientation orient, bool enabled)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&orient);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &enabled;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetOrientationEnabled_Private_Static_Void_EnabledOrientation_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1172534, XrefRangeEnd = 1172536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetResolution(int width, int height, FullScreenMode fullscreenMode, RefreshRate preferredRefreshRate)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&width);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &height;
		*(FullScreenMode**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &fullscreenMode;
		*(RefreshRate**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &preferredRefreshRate;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetResolution_Public_Static_Void_Int32_Int32_FullScreenMode_RefreshRate_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1172536, XrefRangeEnd = 1172538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetResolution(int width, int height, bool fullscreen, int preferredRefreshRate)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&width);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &height;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &fullscreen;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &preferredRefreshRate;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetResolution_Public_Static_Void_Int32_Int32_Boolean_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 1172540, RefRangeEnd = 1172546, XrefRangeStart = 1172538, XrefRangeEnd = 1172540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetResolution(int width, int height, bool fullscreen)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&width);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &height;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &fullscreen;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetResolution_Public_Static_Void_Int32_Int32_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1172548, RefRangeEnd = 1172549, XrefRangeStart = 1172546, XrefRangeEnd = 1172548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetMSAASamples(int numSamples)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&numSamples);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetMSAASamples_Public_Static_Void_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1172551, RefRangeEnd = 1172555, XrefRangeStart = 1172549, XrefRangeEnd = 1172551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetMSAASamples()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMSAASamples_Private_Static_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 1172557, RefRangeEnd = 1172563, XrefRangeStart = 1172557, XrefRangeEnd = 1172563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector2Int GetMainWindowPosition()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMainWindowPosition_Private_Static_Vector2Int_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Vector2Int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1172575, XrefRangeEnd = 1172577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void get_currentResolution_Injected(out Resolution ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_currentResolution_Injected_Private_Static_Void_byref_Resolution_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1172577, XrefRangeEnd = 1172579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void get_safeArea_Injected(out Rect ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_safeArea_Injected_Private_Static_Void_byref_Rect_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1172579, XrefRangeEnd = 1172581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetResolution_Injected(int width, int height, FullScreenMode fullscreenMode, [In] ref RefreshRate preferredRefreshRate)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&width);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &height;
		*(FullScreenMode**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &fullscreenMode;
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref preferredRefreshRate);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetResolution_Injected_Private_Static_Void_Int32_Int32_FullScreenMode_byref_RefreshRate_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1172581, XrefRangeEnd = 1172583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetMainWindowPosition_Injected(out Vector2Int ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMainWindowPosition_Injected_Private_Static_Void_byref_Vector2Int_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1172583, XrefRangeEnd = 1172585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void get_resolutions_Injected(out BlittableArrayWrapper ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_resolutions_Injected_Private_Static_Void_byref_BlittableArrayWrapper_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public Screen(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public static void RequestOrientation(ScreenOrientation orient)
	{
		RequestOrientationDelegateField(orient);
	}

	public static bool IsOrientationEnabled(EnabledOrientation orient)
	{
		return IsOrientationEnabledDelegateField(orient);
	}

	public static void SetResolution(int width, int height, FullScreenMode fullscreenMode, int preferredRefreshRate)
	{
		if (preferredRefreshRate < 0)
		{
			preferredRefreshRate = 0;
		}
		SetResolution(width, height, fullscreenMode, new RefreshRate
		{
			numerator = (uint)preferredRefreshRate,
			denominator = 1u
		});
	}

	public static void SetResolution(int width, int height, FullScreenMode fullscreenMode)
	{
		SetResolution(width, height, fullscreenMode, new RefreshRate
		{
			numerator = 0u,
			denominator = 1u
		});
	}

	public unsafe static void get_cutouts_Injected(out BlittableArrayWrapper ret)
	{
		get_cutouts_InjectedDelegateField((nint)Unsafe.AsPointer(ref ret));
	}
}
