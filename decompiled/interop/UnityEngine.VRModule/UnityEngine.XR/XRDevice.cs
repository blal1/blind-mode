using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.XR;

public static class XRDevice : Il2CppSystem.Object
{
	private delegate float get_refreshRateDelegate();

	private delegate System.IntPtr GetNativePtrDelegate();

	private delegate TrackingSpaceType GetTrackingSpaceTypeDelegate();

	private delegate bool SetTrackingSpaceTypeDelegate(TrackingSpaceType trackingSpaceType);

	private delegate void UpdateEyeTextureMSAASettingDelegate();

	private delegate float get_fovZoomFactorDelegate();

	private delegate void set_fovZoomFactorDelegate(float value);

	private static readonly System.IntPtr NativeFieldInfoPtr_deviceLoaded;

	private static readonly System.IntPtr NativeMethodInfoPtr_DisableAutoXRCameraTracking_Public_Static_Void_Camera_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InvokeDeviceLoaded_Private_Static_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DisableAutoXRCameraTracking_Injected_Private_Static_Void_IntPtr_Boolean_0;

	private static readonly get_refreshRateDelegate get_refreshRateDelegateField;

	private static readonly GetNativePtrDelegate GetNativePtrDelegateField;

	private static readonly GetTrackingSpaceTypeDelegate GetTrackingSpaceTypeDelegateField;

	private static readonly SetTrackingSpaceTypeDelegate SetTrackingSpaceTypeDelegateField;

	private static readonly UpdateEyeTextureMSAASettingDelegate UpdateEyeTextureMSAASettingDelegateField;

	private static readonly get_fovZoomFactorDelegate get_fovZoomFactorDelegateField;

	private static readonly set_fovZoomFactorDelegate set_fovZoomFactorDelegateField;

	public unsafe static Il2CppSystem.Action<string> deviceLoaded
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_deviceLoaded, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_deviceLoaded, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public static bool isPresent
	{
		get
		{
			throw new Il2CppSystem.NotSupportedException("XRDevice is Obsolete. Instead, find the active XRDisplaySubsystem and check to see if it is running.");
		}
	}

	public static float refreshRate => get_refreshRateDelegateField();

	public static float fovZoomFactor
	{
		get
		{
			return get_fovZoomFactorDelegateField();
		}
		set
		{
			set_fovZoomFactorDelegateField(value);
		}
	}

	static XRDevice()
	{
		Il2CppClassPointerStore<XRDevice>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.VRModule.dll", "UnityEngine.XR", "XRDevice");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XRDevice>.NativeClassPtr);
		NativeFieldInfoPtr_deviceLoaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRDevice>.NativeClassPtr, "deviceLoaded");
		NativeMethodInfoPtr_DisableAutoXRCameraTracking_Public_Static_Void_Camera_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRDevice>.NativeClassPtr, 100663306);
		NativeMethodInfoPtr_InvokeDeviceLoaded_Private_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRDevice>.NativeClassPtr, 100663307);
		NativeMethodInfoPtr_DisableAutoXRCameraTracking_Injected_Private_Static_Void_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRDevice>.NativeClassPtr, 100663308);
		get_refreshRateDelegateField = IL2CPP.ResolveICall<get_refreshRateDelegate>("UnityEngine.XR.XRDevice::get_refreshRate");
		GetNativePtrDelegateField = IL2CPP.ResolveICall<GetNativePtrDelegate>("UnityEngine.XR.XRDevice::GetNativePtr");
		GetTrackingSpaceTypeDelegateField = IL2CPP.ResolveICall<GetTrackingSpaceTypeDelegate>("UnityEngine.XR.XRDevice::GetTrackingSpaceType");
		SetTrackingSpaceTypeDelegateField = IL2CPP.ResolveICall<SetTrackingSpaceTypeDelegate>("UnityEngine.XR.XRDevice::SetTrackingSpaceType");
		UpdateEyeTextureMSAASettingDelegateField = IL2CPP.ResolveICall<UpdateEyeTextureMSAASettingDelegate>("UnityEngine.XR.XRDevice::UpdateEyeTextureMSAASetting");
		get_fovZoomFactorDelegateField = IL2CPP.ResolveICall<get_fovZoomFactorDelegate>("UnityEngine.XR.XRDevice::get_fovZoomFactor");
		set_fovZoomFactorDelegateField = IL2CPP.ResolveICall<set_fovZoomFactorDelegate>("UnityEngine.XR.XRDevice::set_fovZoomFactor");
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1411003, RefRangeEnd = 1411005, XrefRangeStart = 1410994, XrefRangeEnd = 1411003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DisableAutoXRCameraTracking(Camera camera, bool disabled)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &disabled;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DisableAutoXRCameraTracking_Public_Static_Void_Camera_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1411005, XrefRangeEnd = 1411007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeDeviceLoaded(string loadedDeviceName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(loadedDeviceName);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InvokeDeviceLoaded_Private_Static_Void_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1411007, XrefRangeEnd = 1411009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DisableAutoXRCameraTracking_Injected(System.IntPtr camera, bool disabled)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&camera);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &disabled;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DisableAutoXRCameraTracking_Injected_Private_Static_Void_IntPtr_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public XRDevice(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public static System.IntPtr GetNativePtr()
	{
		return GetNativePtrDelegateField();
	}

	public static TrackingSpaceType GetTrackingSpaceType()
	{
		return GetTrackingSpaceTypeDelegateField();
	}

	public static bool SetTrackingSpaceType(TrackingSpaceType trackingSpaceType)
	{
		return SetTrackingSpaceTypeDelegateField(trackingSpaceType);
	}

	public static void UpdateEyeTextureMSAASetting()
	{
		UpdateEyeTextureMSAASettingDelegateField();
	}

	[SpecialName]
	public static void add_deviceLoaded(Il2CppSystem.Action<string> value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	[SpecialName]
	public static void remove_deviceLoaded(Il2CppSystem.Action<string> value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}
}
