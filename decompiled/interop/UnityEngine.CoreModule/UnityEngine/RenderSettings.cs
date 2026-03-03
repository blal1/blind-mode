using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Bindings;
using UnityEngine.Rendering;

namespace UnityEngine;

public sealed class RenderSettings : Object
{
	private delegate void set_fogDelegate(bool value);

	private delegate float get_fogStartDistanceDelegate();

	private delegate void set_fogStartDistanceDelegate(float value);

	private delegate float get_fogEndDistanceDelegate();

	private delegate void set_fogEndDistanceDelegate(float value);

	private delegate FogMode get_fogModeDelegate();

	private delegate void set_fogModeDelegate(FogMode value);

	private delegate float get_fogDensityDelegate();

	private delegate void set_fogDensityDelegate(float value);

	private delegate AmbientMode get_ambientModeDelegate();

	private delegate void set_ambientModeDelegate(AmbientMode value);

	private delegate float get_ambientIntensityDelegate();

	private delegate void set_ambientIntensityDelegate(float value);

	private delegate void set_reflectionIntensityDelegate(float value);

	private delegate int get_reflectionBouncesDelegate();

	private delegate void set_reflectionBouncesDelegate(int value);

	private delegate DefaultReflectionMode get_defaultReflectionModeDelegate();

	private delegate void set_defaultReflectionModeDelegate(DefaultReflectionMode value);

	private delegate int get_defaultReflectionResolutionDelegate();

	private delegate void set_defaultReflectionResolutionDelegate(int value);

	private delegate float get_haloStrengthDelegate();

	private delegate void set_haloStrengthDelegate(float value);

	private delegate float get_flareStrengthDelegate();

	private delegate void set_flareStrengthDelegate(float value);

	private delegate float get_flareFadeSpeedDelegate();

	private delegate void set_flareFadeSpeedDelegate(float value);

	private delegate void ResetDelegate();

	private delegate void get_fogColor_InjectedDelegate([Out] System.IntPtr ret);

	private delegate void set_fogColor_InjectedDelegate([In] System.IntPtr value);

	private delegate void set_ambientSkyColor_InjectedDelegate([In] System.IntPtr value);

	private delegate void set_ambientEquatorColor_InjectedDelegate([In] System.IntPtr value);

	private delegate void set_ambientGroundColor_InjectedDelegate([In] System.IntPtr value);

	private delegate void get_ambientLight_InjectedDelegate([Out] System.IntPtr ret);

	private delegate void set_ambientLight_InjectedDelegate([In] System.IntPtr value);

	private delegate void set_subtractiveShadowColor_InjectedDelegate([In] System.IntPtr value);

	private delegate void set_skybox_InjectedDelegate(System.IntPtr value);

	private delegate void set_sun_InjectedDelegate(System.IntPtr value);

	private delegate void set_ambientProbe_InjectedDelegate([In] System.IntPtr value);

	private delegate System.IntPtr get_customReflectionTexture_InjectedDelegate();

	private delegate void set_customReflectionTexture_InjectedDelegate(System.IntPtr value);

	private delegate System.IntPtr get_defaultReflection_InjectedDelegate();

	private delegate System.IntPtr GetRenderSettings_InjectedDelegate();

	private static readonly System.IntPtr NativeMethodInfoPtr_get_fog_Public_Static_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_ambientSkyColor_Public_Static_get_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_ambientEquatorColor_Public_Static_get_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_ambientGroundColor_Public_Static_get_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_subtractiveShadowColor_Public_Static_get_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_skybox_Public_Static_get_Material_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_sun_Public_Static_get_Light_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_ambientProbe_Public_Static_get_SphericalHarmonicsL2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_reflectionIntensity_Public_Static_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_ambientSkyColor_Injected_Private_Static_Void_byref_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_ambientEquatorColor_Injected_Private_Static_Void_byref_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_ambientGroundColor_Injected_Private_Static_Void_byref_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_subtractiveShadowColor_Injected_Private_Static_Void_byref_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_skybox_Injected_Private_Static_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_sun_Injected_Private_Static_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_ambientProbe_Injected_Private_Static_Void_byref_SphericalHarmonicsL2_0;

	private static readonly set_fogDelegate set_fogDelegateField;

	private static readonly get_fogStartDistanceDelegate get_fogStartDistanceDelegateField;

	private static readonly set_fogStartDistanceDelegate set_fogStartDistanceDelegateField;

	private static readonly get_fogEndDistanceDelegate get_fogEndDistanceDelegateField;

	private static readonly set_fogEndDistanceDelegate set_fogEndDistanceDelegateField;

	private static readonly get_fogModeDelegate get_fogModeDelegateField;

	private static readonly set_fogModeDelegate set_fogModeDelegateField;

	private static readonly get_fogDensityDelegate get_fogDensityDelegateField;

	private static readonly set_fogDensityDelegate set_fogDensityDelegateField;

	private static readonly get_ambientModeDelegate get_ambientModeDelegateField;

	private static readonly set_ambientModeDelegate set_ambientModeDelegateField;

	private static readonly get_ambientIntensityDelegate get_ambientIntensityDelegateField;

	private static readonly set_ambientIntensityDelegate set_ambientIntensityDelegateField;

	private static readonly set_reflectionIntensityDelegate set_reflectionIntensityDelegateField;

	private static readonly get_reflectionBouncesDelegate get_reflectionBouncesDelegateField;

	private static readonly set_reflectionBouncesDelegate set_reflectionBouncesDelegateField;

	private static readonly get_defaultReflectionModeDelegate get_defaultReflectionModeDelegateField;

	private static readonly set_defaultReflectionModeDelegate set_defaultReflectionModeDelegateField;

	private static readonly get_defaultReflectionResolutionDelegate get_defaultReflectionResolutionDelegateField;

	private static readonly set_defaultReflectionResolutionDelegate set_defaultReflectionResolutionDelegateField;

	private static readonly get_haloStrengthDelegate get_haloStrengthDelegateField;

	private static readonly set_haloStrengthDelegate set_haloStrengthDelegateField;

	private static readonly get_flareStrengthDelegate get_flareStrengthDelegateField;

	private static readonly set_flareStrengthDelegate set_flareStrengthDelegateField;

	private static readonly get_flareFadeSpeedDelegate get_flareFadeSpeedDelegateField;

	private static readonly set_flareFadeSpeedDelegate set_flareFadeSpeedDelegateField;

	private static readonly ResetDelegate ResetDelegateField;

	private static readonly get_fogColor_InjectedDelegate get_fogColor_InjectedDelegateField;

	private static readonly set_fogColor_InjectedDelegate set_fogColor_InjectedDelegateField;

	private static readonly set_ambientSkyColor_InjectedDelegate set_ambientSkyColor_InjectedDelegateField;

	private static readonly set_ambientEquatorColor_InjectedDelegate set_ambientEquatorColor_InjectedDelegateField;

	private static readonly set_ambientGroundColor_InjectedDelegate set_ambientGroundColor_InjectedDelegateField;

	private static readonly get_ambientLight_InjectedDelegate get_ambientLight_InjectedDelegateField;

	private static readonly set_ambientLight_InjectedDelegate set_ambientLight_InjectedDelegateField;

	private static readonly set_subtractiveShadowColor_InjectedDelegate set_subtractiveShadowColor_InjectedDelegateField;

	private static readonly set_skybox_InjectedDelegate set_skybox_InjectedDelegateField;

	private static readonly set_sun_InjectedDelegate set_sun_InjectedDelegateField;

	private static readonly set_ambientProbe_InjectedDelegate set_ambientProbe_InjectedDelegateField;

	private static readonly get_customReflectionTexture_InjectedDelegate get_customReflectionTexture_InjectedDelegateField;

	private static readonly set_customReflectionTexture_InjectedDelegate set_customReflectionTexture_InjectedDelegateField;

	private static readonly get_defaultReflection_InjectedDelegate get_defaultReflection_InjectedDelegateField;

	private static readonly GetRenderSettings_InjectedDelegate GetRenderSettings_InjectedDelegateField;

	public unsafe static bool fog
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1174894, RefRangeEnd = 1174895, XrefRangeStart = 1174892, XrefRangeEnd = 1174894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_fog_Public_Static_get_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			set_fogDelegateField(value);
		}
	}

	public unsafe static Color ambientSkyColor
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1174897, RefRangeEnd = 1174898, XrefRangeStart = 1174895, XrefRangeEnd = 1174897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ambientSkyColor_Public_Static_get_Color_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Color*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			set_ambientSkyColor_Injected(ref value);
		}
	}

	public unsafe static Color ambientEquatorColor
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1174900, RefRangeEnd = 1174901, XrefRangeStart = 1174898, XrefRangeEnd = 1174900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ambientEquatorColor_Public_Static_get_Color_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Color*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			set_ambientEquatorColor_Injected(ref value);
		}
	}

	public unsafe static Color ambientGroundColor
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1174903, RefRangeEnd = 1174904, XrefRangeStart = 1174901, XrefRangeEnd = 1174903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ambientGroundColor_Public_Static_get_Color_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Color*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			set_ambientGroundColor_Injected(ref value);
		}
	}

	public unsafe static Color subtractiveShadowColor
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1174906, RefRangeEnd = 1174907, XrefRangeStart = 1174904, XrefRangeEnd = 1174906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_subtractiveShadowColor_Public_Static_get_Color_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Color*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			set_subtractiveShadowColor_Injected(ref value);
		}
	}

	public unsafe static Material skybox
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1174912, RefRangeEnd = 1174915, XrefRangeStart = 1174907, XrefRangeEnd = 1174912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_skybox_Public_Static_get_Material_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
		}
		set
		{
			set_skybox_Injected(MarshalledUnityObject.Marshal(value));
		}
	}

	public unsafe static Light sun
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1174920, RefRangeEnd = 1174921, XrefRangeStart = 1174915, XrefRangeEnd = 1174920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_sun_Public_Static_get_Light_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Light>(intPtr2) : null;
		}
		set
		{
			set_sun_Injected(MarshalledUnityObject.Marshal(value));
		}
	}

	public unsafe static SphericalHarmonicsL2 ambientProbe
	{
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1174923, RefRangeEnd = 1174928, XrefRangeStart = 1174921, XrefRangeEnd = 1174923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ambientProbe_Public_Static_get_SphericalHarmonicsL2_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(SphericalHarmonicsL2*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			set_ambientProbe_Injected(ref value);
		}
	}

	public unsafe static float reflectionIntensity
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1174930, RefRangeEnd = 1174931, XrefRangeStart = 1174928, XrefRangeEnd = 1174930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_reflectionIntensity_Public_Static_get_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			set_reflectionIntensityDelegateField(value);
		}
	}

	public static float ambientSkyboxAmount
	{
		get
		{
			return ambientIntensity;
		}
		set
		{
			ambientIntensity = value;
		}
	}

	public static float fogStartDistance
	{
		get
		{
			return get_fogStartDistanceDelegateField();
		}
		set
		{
			set_fogStartDistanceDelegateField(value);
		}
	}

	public static float fogEndDistance
	{
		get
		{
			return get_fogEndDistanceDelegateField();
		}
		set
		{
			set_fogEndDistanceDelegateField(value);
		}
	}

	public static FogMode fogMode
	{
		get
		{
			return get_fogModeDelegateField();
		}
		set
		{
			set_fogModeDelegateField(value);
		}
	}

	public static Color fogColor
	{
		get
		{
			get_fogColor_Injected(out var ret);
			return ret;
		}
		set
		{
			set_fogColor_Injected(ref value);
		}
	}

	public static float fogDensity
	{
		get
		{
			return get_fogDensityDelegateField();
		}
		set
		{
			set_fogDensityDelegateField(value);
		}
	}

	public static AmbientMode ambientMode
	{
		get
		{
			return get_ambientModeDelegateField();
		}
		set
		{
			set_ambientModeDelegateField(value);
		}
	}

	public static float ambientIntensity
	{
		get
		{
			return get_ambientIntensityDelegateField();
		}
		set
		{
			set_ambientIntensityDelegateField(value);
		}
	}

	public static Color ambientLight
	{
		get
		{
			get_ambientLight_Injected(out var ret);
			return ret;
		}
		set
		{
			set_ambientLight_Injected(ref value);
		}
	}

	public static Cubemap customReflection
	{
		get
		{
			Cubemap cubemap = ((Il2CppObjectBase)customReflectionTexture).TryCast<Cubemap>();
			if ((object)cubemap == null)
			{
				throw new Il2CppSystem.ArgumentException("RenderSettings.customReflection is currently not referencing a cubemap.");
			}
			return cubemap;
		}
		set
		{
			customReflectionTexture = value;
		}
	}

	public static Texture customReflectionTexture
	{
		get
		{
			return Unmarshal.UnmarshalUnityObject<Texture>(get_customReflectionTexture_Injected());
		}
		set
		{
			set_customReflectionTexture_Injected(MarshalledUnityObject.Marshal(value));
		}
	}

	public static int reflectionBounces
	{
		get
		{
			return get_reflectionBouncesDelegateField();
		}
		set
		{
			set_reflectionBouncesDelegateField(value);
		}
	}

	public static Cubemap defaultReflection => Unmarshal.UnmarshalUnityObject<Cubemap>(get_defaultReflection_Injected());

	public static DefaultReflectionMode defaultReflectionMode
	{
		get
		{
			return get_defaultReflectionModeDelegateField();
		}
		set
		{
			set_defaultReflectionModeDelegateField(value);
		}
	}

	public static int defaultReflectionResolution
	{
		get
		{
			return get_defaultReflectionResolutionDelegateField();
		}
		set
		{
			set_defaultReflectionResolutionDelegateField(value);
		}
	}

	public static float haloStrength
	{
		get
		{
			return get_haloStrengthDelegateField();
		}
		set
		{
			set_haloStrengthDelegateField(value);
		}
	}

	public static float flareStrength
	{
		get
		{
			return get_flareStrengthDelegateField();
		}
		set
		{
			set_flareStrengthDelegateField(value);
		}
	}

	public static float flareFadeSpeed
	{
		get
		{
			return get_flareFadeSpeedDelegateField();
		}
		set
		{
			set_flareFadeSpeedDelegateField(value);
		}
	}

	static RenderSettings()
	{
		Il2CppClassPointerStore<RenderSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "RenderSettings");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr);
		NativeMethodInfoPtr_get_fog_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100664654);
		NativeMethodInfoPtr_get_ambientSkyColor_Public_Static_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100664655);
		NativeMethodInfoPtr_get_ambientEquatorColor_Public_Static_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100664656);
		NativeMethodInfoPtr_get_ambientGroundColor_Public_Static_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100664657);
		NativeMethodInfoPtr_get_subtractiveShadowColor_Public_Static_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100664658);
		NativeMethodInfoPtr_get_skybox_Public_Static_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100664659);
		NativeMethodInfoPtr_get_sun_Public_Static_get_Light_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100664660);
		NativeMethodInfoPtr_get_ambientProbe_Public_Static_get_SphericalHarmonicsL2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100664661);
		NativeMethodInfoPtr_get_reflectionIntensity_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100664662);
		NativeMethodInfoPtr_get_ambientSkyColor_Injected_Private_Static_Void_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100664663);
		NativeMethodInfoPtr_get_ambientEquatorColor_Injected_Private_Static_Void_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100664664);
		NativeMethodInfoPtr_get_ambientGroundColor_Injected_Private_Static_Void_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100664665);
		NativeMethodInfoPtr_get_subtractiveShadowColor_Injected_Private_Static_Void_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100664666);
		NativeMethodInfoPtr_get_skybox_Injected_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100664667);
		NativeMethodInfoPtr_get_sun_Injected_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100664668);
		NativeMethodInfoPtr_get_ambientProbe_Injected_Private_Static_Void_byref_SphericalHarmonicsL2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100664669);
		set_fogDelegateField = IL2CPP.ResolveICall<set_fogDelegate>("UnityEngine.RenderSettings::set_fog");
		get_fogStartDistanceDelegateField = IL2CPP.ResolveICall<get_fogStartDistanceDelegate>("UnityEngine.RenderSettings::get_fogStartDistance");
		set_fogStartDistanceDelegateField = IL2CPP.ResolveICall<set_fogStartDistanceDelegate>("UnityEngine.RenderSettings::set_fogStartDistance");
		get_fogEndDistanceDelegateField = IL2CPP.ResolveICall<get_fogEndDistanceDelegate>("UnityEngine.RenderSettings::get_fogEndDistance");
		set_fogEndDistanceDelegateField = IL2CPP.ResolveICall<set_fogEndDistanceDelegate>("UnityEngine.RenderSettings::set_fogEndDistance");
		get_fogModeDelegateField = IL2CPP.ResolveICall<get_fogModeDelegate>("UnityEngine.RenderSettings::get_fogMode");
		set_fogModeDelegateField = IL2CPP.ResolveICall<set_fogModeDelegate>("UnityEngine.RenderSettings::set_fogMode");
		get_fogDensityDelegateField = IL2CPP.ResolveICall<get_fogDensityDelegate>("UnityEngine.RenderSettings::get_fogDensity");
		set_fogDensityDelegateField = IL2CPP.ResolveICall<set_fogDensityDelegate>("UnityEngine.RenderSettings::set_fogDensity");
		get_ambientModeDelegateField = IL2CPP.ResolveICall<get_ambientModeDelegate>("UnityEngine.RenderSettings::get_ambientMode");
		set_ambientModeDelegateField = IL2CPP.ResolveICall<set_ambientModeDelegate>("UnityEngine.RenderSettings::set_ambientMode");
		get_ambientIntensityDelegateField = IL2CPP.ResolveICall<get_ambientIntensityDelegate>("UnityEngine.RenderSettings::get_ambientIntensity");
		set_ambientIntensityDelegateField = IL2CPP.ResolveICall<set_ambientIntensityDelegate>("UnityEngine.RenderSettings::set_ambientIntensity");
		set_reflectionIntensityDelegateField = IL2CPP.ResolveICall<set_reflectionIntensityDelegate>("UnityEngine.RenderSettings::set_reflectionIntensity");
		get_reflectionBouncesDelegateField = IL2CPP.ResolveICall<get_reflectionBouncesDelegate>("UnityEngine.RenderSettings::get_reflectionBounces");
		set_reflectionBouncesDelegateField = IL2CPP.ResolveICall<set_reflectionBouncesDelegate>("UnityEngine.RenderSettings::set_reflectionBounces");
		get_defaultReflectionModeDelegateField = IL2CPP.ResolveICall<get_defaultReflectionModeDelegate>("UnityEngine.RenderSettings::get_defaultReflectionMode");
		set_defaultReflectionModeDelegateField = IL2CPP.ResolveICall<set_defaultReflectionModeDelegate>("UnityEngine.RenderSettings::set_defaultReflectionMode");
		get_defaultReflectionResolutionDelegateField = IL2CPP.ResolveICall<get_defaultReflectionResolutionDelegate>("UnityEngine.RenderSettings::get_defaultReflectionResolution");
		set_defaultReflectionResolutionDelegateField = IL2CPP.ResolveICall<set_defaultReflectionResolutionDelegate>("UnityEngine.RenderSettings::set_defaultReflectionResolution");
		get_haloStrengthDelegateField = IL2CPP.ResolveICall<get_haloStrengthDelegate>("UnityEngine.RenderSettings::get_haloStrength");
		set_haloStrengthDelegateField = IL2CPP.ResolveICall<set_haloStrengthDelegate>("UnityEngine.RenderSettings::set_haloStrength");
		get_flareStrengthDelegateField = IL2CPP.ResolveICall<get_flareStrengthDelegate>("UnityEngine.RenderSettings::get_flareStrength");
		set_flareStrengthDelegateField = IL2CPP.ResolveICall<set_flareStrengthDelegate>("UnityEngine.RenderSettings::set_flareStrength");
		get_flareFadeSpeedDelegateField = IL2CPP.ResolveICall<get_flareFadeSpeedDelegate>("UnityEngine.RenderSettings::get_flareFadeSpeed");
		set_flareFadeSpeedDelegateField = IL2CPP.ResolveICall<set_flareFadeSpeedDelegate>("UnityEngine.RenderSettings::set_flareFadeSpeed");
		ResetDelegateField = IL2CPP.ResolveICall<ResetDelegate>("UnityEngine.RenderSettings::Reset");
		get_fogColor_InjectedDelegateField = IL2CPP.ResolveICall<get_fogColor_InjectedDelegate>("UnityEngine.RenderSettings::get_fogColor_Injected");
		set_fogColor_InjectedDelegateField = IL2CPP.ResolveICall<set_fogColor_InjectedDelegate>("UnityEngine.RenderSettings::set_fogColor_Injected");
		set_ambientSkyColor_InjectedDelegateField = IL2CPP.ResolveICall<set_ambientSkyColor_InjectedDelegate>("UnityEngine.RenderSettings::set_ambientSkyColor_Injected");
		set_ambientEquatorColor_InjectedDelegateField = IL2CPP.ResolveICall<set_ambientEquatorColor_InjectedDelegate>("UnityEngine.RenderSettings::set_ambientEquatorColor_Injected");
		set_ambientGroundColor_InjectedDelegateField = IL2CPP.ResolveICall<set_ambientGroundColor_InjectedDelegate>("UnityEngine.RenderSettings::set_ambientGroundColor_Injected");
		get_ambientLight_InjectedDelegateField = IL2CPP.ResolveICall<get_ambientLight_InjectedDelegate>("UnityEngine.RenderSettings::get_ambientLight_Injected");
		set_ambientLight_InjectedDelegateField = IL2CPP.ResolveICall<set_ambientLight_InjectedDelegate>("UnityEngine.RenderSettings::set_ambientLight_Injected");
		set_subtractiveShadowColor_InjectedDelegateField = IL2CPP.ResolveICall<set_subtractiveShadowColor_InjectedDelegate>("UnityEngine.RenderSettings::set_subtractiveShadowColor_Injected");
		set_skybox_InjectedDelegateField = IL2CPP.ResolveICall<set_skybox_InjectedDelegate>("UnityEngine.RenderSettings::set_skybox_Injected");
		set_sun_InjectedDelegateField = IL2CPP.ResolveICall<set_sun_InjectedDelegate>("UnityEngine.RenderSettings::set_sun_Injected");
		set_ambientProbe_InjectedDelegateField = IL2CPP.ResolveICall<set_ambientProbe_InjectedDelegate>("UnityEngine.RenderSettings::set_ambientProbe_Injected");
		get_customReflectionTexture_InjectedDelegateField = IL2CPP.ResolveICall<get_customReflectionTexture_InjectedDelegate>("UnityEngine.RenderSettings::get_customReflectionTexture_Injected");
		set_customReflectionTexture_InjectedDelegateField = IL2CPP.ResolveICall<set_customReflectionTexture_InjectedDelegate>("UnityEngine.RenderSettings::set_customReflectionTexture_Injected");
		get_defaultReflection_InjectedDelegateField = IL2CPP.ResolveICall<get_defaultReflection_InjectedDelegate>("UnityEngine.RenderSettings::get_defaultReflection_Injected");
		GetRenderSettings_InjectedDelegateField = IL2CPP.ResolveICall<GetRenderSettings_InjectedDelegate>("UnityEngine.RenderSettings::GetRenderSettings_Injected");
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1174931, XrefRangeEnd = 1174933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void get_ambientSkyColor_Injected(out Color ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ambientSkyColor_Injected_Private_Static_Void_byref_Color_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1174933, XrefRangeEnd = 1174935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void get_ambientEquatorColor_Injected(out Color ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ambientEquatorColor_Injected_Private_Static_Void_byref_Color_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1174935, XrefRangeEnd = 1174937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void get_ambientGroundColor_Injected(out Color ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ambientGroundColor_Injected_Private_Static_Void_byref_Color_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1174937, XrefRangeEnd = 1174939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void get_subtractiveShadowColor_Injected(out Color ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_subtractiveShadowColor_Injected_Private_Static_Void_byref_Color_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1174939, XrefRangeEnd = 1174941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr get_skybox_Injected()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_skybox_Injected_Private_Static_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1174941, XrefRangeEnd = 1174943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr get_sun_Injected()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_sun_Injected_Private_Static_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1174943, XrefRangeEnd = 1174945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void get_ambientProbe_Injected(out SphericalHarmonicsL2 ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ambientProbe_Injected_Private_Static_Void_byref_SphericalHarmonicsL2_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public RenderSettings(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public static Object GetRenderSettings()
	{
		return Unmarshal.UnmarshalUnityObject<Object>(GetRenderSettings_Injected());
	}

	public static void Reset()
	{
		ResetDelegateField();
	}

	public unsafe static void get_fogColor_Injected(out Color ret)
	{
		get_fogColor_InjectedDelegateField((nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void set_fogColor_Injected([In] ref Color value)
	{
		set_fogColor_InjectedDelegateField((nint)Unsafe.AsPointer(ref value));
	}

	public unsafe static void set_ambientSkyColor_Injected([In] ref Color value)
	{
		set_ambientSkyColor_InjectedDelegateField((nint)Unsafe.AsPointer(ref value));
	}

	public unsafe static void set_ambientEquatorColor_Injected([In] ref Color value)
	{
		set_ambientEquatorColor_InjectedDelegateField((nint)Unsafe.AsPointer(ref value));
	}

	public unsafe static void set_ambientGroundColor_Injected([In] ref Color value)
	{
		set_ambientGroundColor_InjectedDelegateField((nint)Unsafe.AsPointer(ref value));
	}

	public unsafe static void get_ambientLight_Injected(out Color ret)
	{
		get_ambientLight_InjectedDelegateField((nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void set_ambientLight_Injected([In] ref Color value)
	{
		set_ambientLight_InjectedDelegateField((nint)Unsafe.AsPointer(ref value));
	}

	public unsafe static void set_subtractiveShadowColor_Injected([In] ref Color value)
	{
		set_subtractiveShadowColor_InjectedDelegateField((nint)Unsafe.AsPointer(ref value));
	}

	public static void set_skybox_Injected(System.IntPtr value)
	{
		set_skybox_InjectedDelegateField(value);
	}

	public static void set_sun_Injected(System.IntPtr value)
	{
		set_sun_InjectedDelegateField(value);
	}

	public unsafe static void set_ambientProbe_Injected([In] ref SphericalHarmonicsL2 value)
	{
		set_ambientProbe_InjectedDelegateField((nint)Unsafe.AsPointer(ref value));
	}

	public static System.IntPtr get_customReflectionTexture_Injected()
	{
		return get_customReflectionTexture_InjectedDelegateField();
	}

	public static void set_customReflectionTexture_Injected(System.IntPtr value)
	{
		set_customReflectionTexture_InjectedDelegateField(value);
	}

	public static System.IntPtr get_defaultReflection_Injected()
	{
		return get_defaultReflection_InjectedDelegateField();
	}

	public static System.IntPtr GetRenderSettings_Injected()
	{
		return GetRenderSettings_InjectedDelegateField();
	}
}
