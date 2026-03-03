using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Bindings;
using UnityEngine.Rendering;

namespace UnityEngine.XR;

public static class XRSettings : Il2CppSystem.Object
{
	public enum StereoRenderingMode
	{
		MultiPass,
		SinglePass,
		SinglePassInstanced,
		SinglePassMultiview
	}

	private delegate void set_enabledDelegate(bool value);

	private delegate GameViewRenderMode get_gameViewRenderModeDelegate();

	private delegate void set_gameViewRenderModeDelegate(GameViewRenderMode value);

	private delegate bool get_showDeviceViewDelegate();

	private delegate void set_showDeviceViewDelegate(bool value);

	private delegate float get_eyeTextureResolutionScaleDelegate();

	private delegate void set_eyeTextureResolutionScaleDelegate(float value);

	private delegate TextureDimension get_deviceEyeTextureDimensionDelegate();

	private delegate float get_renderViewportScaleInternalDelegate();

	private delegate void set_renderViewportScaleInternalDelegate(float value);

	private delegate float get_occlusionMaskScaleDelegate();

	private delegate void set_occlusionMaskScaleDelegate(float value);

	private delegate bool get_useOcclusionMeshDelegate();

	private delegate void set_useOcclusionMeshDelegate(bool value);

	private delegate void LoadDeviceByNameDelegate(System.IntPtr prioritizedDeviceNameList);

	private delegate StereoRenderingMode get_stereoRenderingModeDelegate();

	private static readonly System.IntPtr NativeMethodInfoPtr_get_enabled_Public_Static_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isDeviceActive_Public_Static_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_eyeTextureWidth_Public_Static_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_eyeTextureHeight_Public_Static_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_eyeTextureDesc_Public_Static_get_RenderTextureDescriptor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_loadedDeviceName_Public_Static_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_supportedDevices_Public_Static_get_Il2CppStringArray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_eyeTextureDesc_Injected_Private_Static_Void_byref_RenderTextureDescriptor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_loadedDeviceName_Injected_Private_Static_Void_byref_ManagedSpanWrapper_0;

	private static readonly set_enabledDelegate set_enabledDelegateField;

	private static readonly get_gameViewRenderModeDelegate get_gameViewRenderModeDelegateField;

	private static readonly set_gameViewRenderModeDelegate set_gameViewRenderModeDelegateField;

	private static readonly get_showDeviceViewDelegate get_showDeviceViewDelegateField;

	private static readonly set_showDeviceViewDelegate set_showDeviceViewDelegateField;

	private static readonly get_eyeTextureResolutionScaleDelegate get_eyeTextureResolutionScaleDelegateField;

	private static readonly set_eyeTextureResolutionScaleDelegate set_eyeTextureResolutionScaleDelegateField;

	private static readonly get_deviceEyeTextureDimensionDelegate get_deviceEyeTextureDimensionDelegateField;

	private static readonly get_renderViewportScaleInternalDelegate get_renderViewportScaleInternalDelegateField;

	private static readonly set_renderViewportScaleInternalDelegate set_renderViewportScaleInternalDelegateField;

	private static readonly get_occlusionMaskScaleDelegate get_occlusionMaskScaleDelegateField;

	private static readonly set_occlusionMaskScaleDelegate set_occlusionMaskScaleDelegateField;

	private static readonly get_useOcclusionMeshDelegate get_useOcclusionMeshDelegateField;

	private static readonly set_useOcclusionMeshDelegate set_useOcclusionMeshDelegateField;

	private static readonly LoadDeviceByNameDelegate LoadDeviceByNameDelegateField;

	private static readonly get_stereoRenderingModeDelegate get_stereoRenderingModeDelegateField;

	public unsafe static bool enabled
	{
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 1410963, RefRangeEnd = 1410974, XrefRangeStart = 1410961, XrefRangeEnd = 1410963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_enabled_Public_Static_get_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			set_enabledDelegateField(value);
		}
	}

	public unsafe static bool isDeviceActive
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1410974, XrefRangeEnd = 1410976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isDeviceActive_Public_Static_get_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static int eyeTextureWidth
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1410976, XrefRangeEnd = 1410978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_eyeTextureWidth_Public_Static_get_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static int eyeTextureHeight
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1410978, XrefRangeEnd = 1410980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_eyeTextureHeight_Public_Static_get_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static RenderTextureDescriptor eyeTextureDesc
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1410980, XrefRangeEnd = 1410982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_eyeTextureDesc_Public_Static_get_RenderTextureDescriptor_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(RenderTextureDescriptor*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static string loadedDeviceName
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1410982, XrefRangeEnd = 1410987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_loadedDeviceName_Public_Static_get_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
	}

	public unsafe static Il2CppStringArray supportedDevices
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1410989, RefRangeEnd = 1410990, XrefRangeStart = 1410987, XrefRangeEnd = 1410989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_supportedDevices_Public_Static_get_Il2CppStringArray_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
	}

	public static GameViewRenderMode gameViewRenderMode
	{
		get
		{
			return get_gameViewRenderModeDelegateField();
		}
		set
		{
			set_gameViewRenderModeDelegateField(value);
		}
	}

	public static bool showDeviceView
	{
		get
		{
			return get_showDeviceViewDelegateField();
		}
		set
		{
			set_showDeviceViewDelegateField(value);
		}
	}

	public static float eyeTextureResolutionScale
	{
		get
		{
			return get_eyeTextureResolutionScaleDelegateField();
		}
		set
		{
			set_eyeTextureResolutionScaleDelegateField(value);
		}
	}

	public static TextureDimension deviceEyeTextureDimension => get_deviceEyeTextureDimensionDelegateField();

	public static float renderViewportScale
	{
		get
		{
			return renderViewportScaleInternal;
		}
		set
		{
			if (value < 0f || value > 1f)
			{
				throw new Il2CppSystem.ArgumentOutOfRangeException("value", "Render viewport scale should be between 0 and 1.");
			}
			renderViewportScaleInternal = value;
		}
	}

	public static float renderViewportScaleInternal
	{
		get
		{
			return get_renderViewportScaleInternalDelegateField();
		}
		set
		{
			set_renderViewportScaleInternalDelegateField(value);
		}
	}

	public static float occlusionMaskScale
	{
		get
		{
			return get_occlusionMaskScaleDelegateField();
		}
		set
		{
			set_occlusionMaskScaleDelegateField(value);
		}
	}

	public static bool useOcclusionMesh
	{
		get
		{
			return get_useOcclusionMeshDelegateField();
		}
		set
		{
			set_useOcclusionMeshDelegateField(value);
		}
	}

	public static StereoRenderingMode stereoRenderingMode => get_stereoRenderingModeDelegateField();

	static XRSettings()
	{
		Il2CppClassPointerStore<XRSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.VRModule.dll", "UnityEngine.XR", "XRSettings");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XRSettings>.NativeClassPtr);
		NativeMethodInfoPtr_get_enabled_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRSettings>.NativeClassPtr, 100663297);
		NativeMethodInfoPtr_get_isDeviceActive_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRSettings>.NativeClassPtr, 100663298);
		NativeMethodInfoPtr_get_eyeTextureWidth_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRSettings>.NativeClassPtr, 100663299);
		NativeMethodInfoPtr_get_eyeTextureHeight_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRSettings>.NativeClassPtr, 100663300);
		NativeMethodInfoPtr_get_eyeTextureDesc_Public_Static_get_RenderTextureDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRSettings>.NativeClassPtr, 100663301);
		NativeMethodInfoPtr_get_loadedDeviceName_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRSettings>.NativeClassPtr, 100663302);
		NativeMethodInfoPtr_get_supportedDevices_Public_Static_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRSettings>.NativeClassPtr, 100663303);
		NativeMethodInfoPtr_get_eyeTextureDesc_Injected_Private_Static_Void_byref_RenderTextureDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRSettings>.NativeClassPtr, 100663304);
		NativeMethodInfoPtr_get_loadedDeviceName_Injected_Private_Static_Void_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRSettings>.NativeClassPtr, 100663305);
		set_enabledDelegateField = IL2CPP.ResolveICall<set_enabledDelegate>("UnityEngine.XR.XRSettings::set_enabled");
		get_gameViewRenderModeDelegateField = IL2CPP.ResolveICall<get_gameViewRenderModeDelegate>("UnityEngine.XR.XRSettings::get_gameViewRenderMode");
		set_gameViewRenderModeDelegateField = IL2CPP.ResolveICall<set_gameViewRenderModeDelegate>("UnityEngine.XR.XRSettings::set_gameViewRenderMode");
		get_showDeviceViewDelegateField = IL2CPP.ResolveICall<get_showDeviceViewDelegate>("UnityEngine.XR.XRSettings::get_showDeviceView");
		set_showDeviceViewDelegateField = IL2CPP.ResolveICall<set_showDeviceViewDelegate>("UnityEngine.XR.XRSettings::set_showDeviceView");
		get_eyeTextureResolutionScaleDelegateField = IL2CPP.ResolveICall<get_eyeTextureResolutionScaleDelegate>("UnityEngine.XR.XRSettings::get_eyeTextureResolutionScale");
		set_eyeTextureResolutionScaleDelegateField = IL2CPP.ResolveICall<set_eyeTextureResolutionScaleDelegate>("UnityEngine.XR.XRSettings::set_eyeTextureResolutionScale");
		get_deviceEyeTextureDimensionDelegateField = IL2CPP.ResolveICall<get_deviceEyeTextureDimensionDelegate>("UnityEngine.XR.XRSettings::get_deviceEyeTextureDimension");
		get_renderViewportScaleInternalDelegateField = IL2CPP.ResolveICall<get_renderViewportScaleInternalDelegate>("UnityEngine.XR.XRSettings::get_renderViewportScaleInternal");
		set_renderViewportScaleInternalDelegateField = IL2CPP.ResolveICall<set_renderViewportScaleInternalDelegate>("UnityEngine.XR.XRSettings::set_renderViewportScaleInternal");
		get_occlusionMaskScaleDelegateField = IL2CPP.ResolveICall<get_occlusionMaskScaleDelegate>("UnityEngine.XR.XRSettings::get_occlusionMaskScale");
		set_occlusionMaskScaleDelegateField = IL2CPP.ResolveICall<set_occlusionMaskScaleDelegate>("UnityEngine.XR.XRSettings::set_occlusionMaskScale");
		get_useOcclusionMeshDelegateField = IL2CPP.ResolveICall<get_useOcclusionMeshDelegate>("UnityEngine.XR.XRSettings::get_useOcclusionMesh");
		set_useOcclusionMeshDelegateField = IL2CPP.ResolveICall<set_useOcclusionMeshDelegate>("UnityEngine.XR.XRSettings::set_useOcclusionMesh");
		LoadDeviceByNameDelegateField = IL2CPP.ResolveICall<LoadDeviceByNameDelegate>("UnityEngine.XR.XRSettings::LoadDeviceByName");
		get_stereoRenderingModeDelegateField = IL2CPP.ResolveICall<get_stereoRenderingModeDelegate>("UnityEngine.XR.XRSettings::get_stereoRenderingMode");
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1410990, XrefRangeEnd = 1410992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void get_eyeTextureDesc_Injected(out RenderTextureDescriptor ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_eyeTextureDesc_Injected_Private_Static_Void_byref_RenderTextureDescriptor_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1410992, XrefRangeEnd = 1410994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void get_loadedDeviceName_Injected(out ManagedSpanWrapper ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_loadedDeviceName_Injected_Private_Static_Void_byref_ManagedSpanWrapper_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public XRSettings(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public static void LoadDeviceByName(string deviceName)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public static void LoadDeviceByName(Il2CppStringArray prioritizedDeviceNameList)
	{
		LoadDeviceByNameDelegateField(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)prioritizedDeviceNameList));
	}
}
