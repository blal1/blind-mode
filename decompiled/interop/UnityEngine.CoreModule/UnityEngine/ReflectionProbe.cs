using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Bindings;
using UnityEngine.Rendering;

namespace UnityEngine;

public sealed class ReflectionProbe : Behaviour
{
	[OriginalName("UnityEngine.CoreModule.dll", "", "ReflectionProbeEvent")]
	public enum ReflectionProbeEvent
	{
		ReflectionProbeAdded,
		ReflectionProbeRemoved
	}

	public sealed class _003C_003Ec__DisplayClass95_0
	{
	}

	public sealed class _003C_003Ec__DisplayClass98_0
	{
	}

	private delegate void UpdateCachedStateDelegate();

	private delegate int get_minBakedCubemapResolutionDelegate();

	private delegate int get_maxBakedCubemapResolutionDelegate();

	private delegate ReflectionProbeType get_type_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_type_InjectedDelegate(System.IntPtr _unity_self, ReflectionProbeType value);

	private delegate void get_size_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr ret);

	private delegate void set_size_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr value);

	private delegate void get_center_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr ret);

	private delegate void set_center_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr value);

	private delegate float get_nearClipPlane_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_nearClipPlane_InjectedDelegate(System.IntPtr _unity_self, float value);

	private delegate float get_farClipPlane_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_farClipPlane_InjectedDelegate(System.IntPtr _unity_self, float value);

	private delegate float get_intensity_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_intensity_InjectedDelegate(System.IntPtr _unity_self, float value);

	private delegate void get_bounds_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr ret);

	private delegate bool get_hdr_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_hdr_InjectedDelegate(System.IntPtr _unity_self, bool value);

	private delegate bool get_renderDynamicObjects_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_renderDynamicObjects_InjectedDelegate(System.IntPtr _unity_self, bool value);

	private delegate float get_shadowDistance_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_shadowDistance_InjectedDelegate(System.IntPtr _unity_self, float value);

	private delegate int get_resolution_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_resolution_InjectedDelegate(System.IntPtr _unity_self, int value);

	private delegate int get_cullingMask_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_cullingMask_InjectedDelegate(System.IntPtr _unity_self, int value);

	private delegate ReflectionProbeClearFlags get_clearFlags_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_clearFlags_InjectedDelegate(System.IntPtr _unity_self, ReflectionProbeClearFlags value);

	private delegate void get_backgroundColor_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr ret);

	private delegate void set_backgroundColor_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr value);

	private delegate float get_blendDistance_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_blendDistance_InjectedDelegate(System.IntPtr _unity_self, float value);

	private delegate bool get_boxProjection_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_boxProjection_InjectedDelegate(System.IntPtr _unity_self, bool value);

	private delegate ReflectionProbeMode get_mode_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_mode_InjectedDelegate(System.IntPtr _unity_self, ReflectionProbeMode value);

	private delegate int get_importance_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_importance_InjectedDelegate(System.IntPtr _unity_self, int value);

	private delegate void set_refreshMode_InjectedDelegate(System.IntPtr _unity_self, ReflectionProbeRefreshMode value);

	private delegate ReflectionProbeTimeSlicingMode get_timeSlicingMode_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_timeSlicingMode_InjectedDelegate(System.IntPtr _unity_self, ReflectionProbeTimeSlicingMode value);

	private delegate System.IntPtr get_bakedTexture_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_bakedTexture_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr value);

	private delegate System.IntPtr get_customBakedTexture_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_customBakedTexture_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr value);

	private delegate System.IntPtr get_realtimeTexture_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_realtimeTexture_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr value);

	private delegate System.IntPtr get_texture_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void get_textureHDRDecodeValues_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr ret);

	private delegate void Reset_InjectedDelegate(System.IntPtr _unity_self);

	private delegate bool IsFinishedRendering_InjectedDelegate(System.IntPtr _unity_self, int renderId);

	private delegate int ScheduleRender_InjectedDelegate(System.IntPtr _unity_self, ReflectionProbeTimeSlicingMode timeSlicingMode, System.IntPtr targetTexture);

	private delegate bool BlendCubemap_InjectedDelegate(System.IntPtr src, System.IntPtr dst, float blend, System.IntPtr target);

	private static readonly System.IntPtr NativeFieldInfoPtr_reflectionProbeChanged;

	private static readonly System.IntPtr NativeFieldInfoPtr_registeredDefaultReflectionSetActions;

	private static readonly System.IntPtr NativeFieldInfoPtr_registeredDefaultReflectionTextureActions;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_refreshMode_Public_get_ReflectionProbeRefreshMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_defaultTextureHDRDecodeValues_Public_Static_get_Vector4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_defaultTexture_Public_Static_get_Texture_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CallReflectionProbeEvent_Private_Static_Void_ReflectionProbe_ReflectionProbeEvent_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CallSetDefaultReflection_Private_Static_Void_Texture_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_refreshMode_Injected_Private_Static_ReflectionProbeRefreshMode_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_defaultTextureHDRDecodeValues_Injected_Private_Static_Void_byref_Vector4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_defaultTexture_Injected_Private_Static_IntPtr_0;

	private static readonly UpdateCachedStateDelegate UpdateCachedStateDelegateField;

	private static readonly get_minBakedCubemapResolutionDelegate get_minBakedCubemapResolutionDelegateField;

	private static readonly get_maxBakedCubemapResolutionDelegate get_maxBakedCubemapResolutionDelegateField;

	private static readonly get_type_InjectedDelegate get_type_InjectedDelegateField;

	private static readonly set_type_InjectedDelegate set_type_InjectedDelegateField;

	private static readonly get_size_InjectedDelegate get_size_InjectedDelegateField;

	private static readonly set_size_InjectedDelegate set_size_InjectedDelegateField;

	private static readonly get_center_InjectedDelegate get_center_InjectedDelegateField;

	private static readonly set_center_InjectedDelegate set_center_InjectedDelegateField;

	private static readonly get_nearClipPlane_InjectedDelegate get_nearClipPlane_InjectedDelegateField;

	private static readonly set_nearClipPlane_InjectedDelegate set_nearClipPlane_InjectedDelegateField;

	private static readonly get_farClipPlane_InjectedDelegate get_farClipPlane_InjectedDelegateField;

	private static readonly set_farClipPlane_InjectedDelegate set_farClipPlane_InjectedDelegateField;

	private static readonly get_intensity_InjectedDelegate get_intensity_InjectedDelegateField;

	private static readonly set_intensity_InjectedDelegate set_intensity_InjectedDelegateField;

	private static readonly get_bounds_InjectedDelegate get_bounds_InjectedDelegateField;

	private static readonly get_hdr_InjectedDelegate get_hdr_InjectedDelegateField;

	private static readonly set_hdr_InjectedDelegate set_hdr_InjectedDelegateField;

	private static readonly get_renderDynamicObjects_InjectedDelegate get_renderDynamicObjects_InjectedDelegateField;

	private static readonly set_renderDynamicObjects_InjectedDelegate set_renderDynamicObjects_InjectedDelegateField;

	private static readonly get_shadowDistance_InjectedDelegate get_shadowDistance_InjectedDelegateField;

	private static readonly set_shadowDistance_InjectedDelegate set_shadowDistance_InjectedDelegateField;

	private static readonly get_resolution_InjectedDelegate get_resolution_InjectedDelegateField;

	private static readonly set_resolution_InjectedDelegate set_resolution_InjectedDelegateField;

	private static readonly get_cullingMask_InjectedDelegate get_cullingMask_InjectedDelegateField;

	private static readonly set_cullingMask_InjectedDelegate set_cullingMask_InjectedDelegateField;

	private static readonly get_clearFlags_InjectedDelegate get_clearFlags_InjectedDelegateField;

	private static readonly set_clearFlags_InjectedDelegate set_clearFlags_InjectedDelegateField;

	private static readonly get_backgroundColor_InjectedDelegate get_backgroundColor_InjectedDelegateField;

	private static readonly set_backgroundColor_InjectedDelegate set_backgroundColor_InjectedDelegateField;

	private static readonly get_blendDistance_InjectedDelegate get_blendDistance_InjectedDelegateField;

	private static readonly set_blendDistance_InjectedDelegate set_blendDistance_InjectedDelegateField;

	private static readonly get_boxProjection_InjectedDelegate get_boxProjection_InjectedDelegateField;

	private static readonly set_boxProjection_InjectedDelegate set_boxProjection_InjectedDelegateField;

	private static readonly get_mode_InjectedDelegate get_mode_InjectedDelegateField;

	private static readonly set_mode_InjectedDelegate set_mode_InjectedDelegateField;

	private static readonly get_importance_InjectedDelegate get_importance_InjectedDelegateField;

	private static readonly set_importance_InjectedDelegate set_importance_InjectedDelegateField;

	private static readonly set_refreshMode_InjectedDelegate set_refreshMode_InjectedDelegateField;

	private static readonly get_timeSlicingMode_InjectedDelegate get_timeSlicingMode_InjectedDelegateField;

	private static readonly set_timeSlicingMode_InjectedDelegate set_timeSlicingMode_InjectedDelegateField;

	private static readonly get_bakedTexture_InjectedDelegate get_bakedTexture_InjectedDelegateField;

	private static readonly set_bakedTexture_InjectedDelegate set_bakedTexture_InjectedDelegateField;

	private static readonly get_customBakedTexture_InjectedDelegate get_customBakedTexture_InjectedDelegateField;

	private static readonly set_customBakedTexture_InjectedDelegate set_customBakedTexture_InjectedDelegateField;

	private static readonly get_realtimeTexture_InjectedDelegate get_realtimeTexture_InjectedDelegateField;

	private static readonly set_realtimeTexture_InjectedDelegate set_realtimeTexture_InjectedDelegateField;

	private static readonly get_texture_InjectedDelegate get_texture_InjectedDelegateField;

	private static readonly get_textureHDRDecodeValues_InjectedDelegate get_textureHDRDecodeValues_InjectedDelegateField;

	private static readonly Reset_InjectedDelegate Reset_InjectedDelegateField;

	private static readonly IsFinishedRendering_InjectedDelegate IsFinishedRendering_InjectedDelegateField;

	private static readonly ScheduleRender_InjectedDelegate ScheduleRender_InjectedDelegateField;

	private static readonly BlendCubemap_InjectedDelegate BlendCubemap_InjectedDelegateField;

	public unsafe static Il2CppSystem.Action<ReflectionProbe, ReflectionProbeEvent> reflectionProbeChanged
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_reflectionProbeChanged, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<ReflectionProbe, ReflectionProbeEvent>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_reflectionProbeChanged, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Dictionary<int, Il2CppSystem.Action<Texture>> registeredDefaultReflectionSetActions
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_registeredDefaultReflectionSetActions, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, Il2CppSystem.Action<Texture>>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_registeredDefaultReflectionSetActions, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static List<Il2CppSystem.Action<Texture>> registeredDefaultReflectionTextureActions
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_registeredDefaultReflectionTextureActions, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Il2CppSystem.Action<Texture>>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_registeredDefaultReflectionTextureActions, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe ReflectionProbeRefreshMode refreshMode
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1169328, RefRangeEnd = 1169329, XrefRangeStart = 1169320, XrefRangeEnd = 1169328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_refreshMode_Public_get_ReflectionProbeRefreshMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(ReflectionProbeRefreshMode*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_refreshMode_Injected(intPtr, value);
		}
	}

	public unsafe static Vector4 defaultTextureHDRDecodeValues
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1169334, RefRangeEnd = 1169336, XrefRangeStart = 1169329, XrefRangeEnd = 1169334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_defaultTextureHDRDecodeValues_Public_Static_get_Vector4_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Vector4*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static Texture defaultTexture
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1169344, RefRangeEnd = 1169345, XrefRangeStart = 1169336, XrefRangeEnd = 1169344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_defaultTexture_Public_Static_get_Texture_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Texture>(intPtr2) : null;
		}
	}

	public ReflectionProbeType type
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_type_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_type_Injected(intPtr, value);
		}
	}

	public Vector3 size
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			get_size_Injected(intPtr, out var ret);
			return ret;
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_size_Injected(intPtr, ref value);
		}
	}

	public Vector3 center
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			get_center_Injected(intPtr, out var ret);
			return ret;
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_center_Injected(intPtr, ref value);
		}
	}

	public float nearClipPlane
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_nearClipPlane_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_nearClipPlane_Injected(intPtr, value);
		}
	}

	public float farClipPlane
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_farClipPlane_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_farClipPlane_Injected(intPtr, value);
		}
	}

	public float intensity
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_intensity_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_intensity_Injected(intPtr, value);
		}
	}

	public Bounds bounds
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			get_bounds_Injected(intPtr, out var ret);
			return ret;
		}
	}

	public bool hdr
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_hdr_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_hdr_Injected(intPtr, value);
		}
	}

	public bool renderDynamicObjects
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_renderDynamicObjects_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_renderDynamicObjects_Injected(intPtr, value);
		}
	}

	public float shadowDistance
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_shadowDistance_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_shadowDistance_Injected(intPtr, value);
		}
	}

	public int resolution
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_resolution_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_resolution_Injected(intPtr, value);
		}
	}

	public int cullingMask
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_cullingMask_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_cullingMask_Injected(intPtr, value);
		}
	}

	public ReflectionProbeClearFlags clearFlags
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_clearFlags_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_clearFlags_Injected(intPtr, value);
		}
	}

	public Color backgroundColor
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			get_backgroundColor_Injected(intPtr, out var ret);
			return ret;
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_backgroundColor_Injected(intPtr, ref value);
		}
	}

	public float blendDistance
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_blendDistance_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_blendDistance_Injected(intPtr, value);
		}
	}

	public bool boxProjection
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_boxProjection_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_boxProjection_Injected(intPtr, value);
		}
	}

	public ReflectionProbeMode mode
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_mode_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_mode_Injected(intPtr, value);
		}
	}

	public int importance
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_importance_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_importance_Injected(intPtr, value);
		}
	}

	public ReflectionProbeTimeSlicingMode timeSlicingMode
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_timeSlicingMode_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_timeSlicingMode_Injected(intPtr, value);
		}
	}

	public Texture bakedTexture
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return Unmarshal.UnmarshalUnityObject<Texture>(get_bakedTexture_Injected(intPtr));
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_bakedTexture_Injected(intPtr, MarshalledUnityObject.Marshal(value));
		}
	}

	public Texture customBakedTexture
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return Unmarshal.UnmarshalUnityObject<Texture>(get_customBakedTexture_Injected(intPtr));
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_customBakedTexture_Injected(intPtr, MarshalledUnityObject.Marshal(value));
		}
	}

	public RenderTexture realtimeTexture
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return Unmarshal.UnmarshalUnityObject<RenderTexture>(get_realtimeTexture_Injected(intPtr));
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_realtimeTexture_Injected(intPtr, MarshalledUnityObject.Marshal(value));
		}
	}

	public Texture texture
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return Unmarshal.UnmarshalUnityObject<Texture>(get_texture_Injected(intPtr));
		}
	}

	public Vector4 textureHDRDecodeValues
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			get_textureHDRDecodeValues_Injected(intPtr, out var ret);
			return ret;
		}
	}

	public static int minBakedCubemapResolution => get_minBakedCubemapResolutionDelegateField();

	public static int maxBakedCubemapResolution => get_maxBakedCubemapResolutionDelegateField();

	static ReflectionProbe()
	{
		Il2CppClassPointerStore<ReflectionProbe>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "ReflectionProbe");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReflectionProbe>.NativeClassPtr);
		NativeFieldInfoPtr_reflectionProbeChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionProbe>.NativeClassPtr, "reflectionProbeChanged");
		NativeFieldInfoPtr_registeredDefaultReflectionSetActions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionProbe>.NativeClassPtr, "registeredDefaultReflectionSetActions");
		NativeFieldInfoPtr_registeredDefaultReflectionTextureActions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionProbe>.NativeClassPtr, "registeredDefaultReflectionTextureActions");
		NativeMethodInfoPtr_get_refreshMode_Public_get_ReflectionProbeRefreshMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionProbe>.NativeClassPtr, 100664047);
		NativeMethodInfoPtr_get_defaultTextureHDRDecodeValues_Public_Static_get_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionProbe>.NativeClassPtr, 100664048);
		NativeMethodInfoPtr_get_defaultTexture_Public_Static_get_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionProbe>.NativeClassPtr, 100664049);
		NativeMethodInfoPtr_CallReflectionProbeEvent_Private_Static_Void_ReflectionProbe_ReflectionProbeEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionProbe>.NativeClassPtr, 100664050);
		NativeMethodInfoPtr_CallSetDefaultReflection_Private_Static_Void_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionProbe>.NativeClassPtr, 100664051);
		NativeMethodInfoPtr_get_refreshMode_Injected_Private_Static_ReflectionProbeRefreshMode_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionProbe>.NativeClassPtr, 100664053);
		NativeMethodInfoPtr_get_defaultTextureHDRDecodeValues_Injected_Private_Static_Void_byref_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionProbe>.NativeClassPtr, 100664054);
		NativeMethodInfoPtr_get_defaultTexture_Injected_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionProbe>.NativeClassPtr, 100664055);
		UpdateCachedStateDelegateField = IL2CPP.ResolveICall<UpdateCachedStateDelegate>("UnityEngine.ReflectionProbe::UpdateCachedState");
		get_minBakedCubemapResolutionDelegateField = IL2CPP.ResolveICall<get_minBakedCubemapResolutionDelegate>("UnityEngine.ReflectionProbe::get_minBakedCubemapResolution");
		get_maxBakedCubemapResolutionDelegateField = IL2CPP.ResolveICall<get_maxBakedCubemapResolutionDelegate>("UnityEngine.ReflectionProbe::get_maxBakedCubemapResolution");
		get_type_InjectedDelegateField = IL2CPP.ResolveICall<get_type_InjectedDelegate>("UnityEngine.ReflectionProbe::get_type_Injected");
		set_type_InjectedDelegateField = IL2CPP.ResolveICall<set_type_InjectedDelegate>("UnityEngine.ReflectionProbe::set_type_Injected");
		get_size_InjectedDelegateField = IL2CPP.ResolveICall<get_size_InjectedDelegate>("UnityEngine.ReflectionProbe::get_size_Injected");
		set_size_InjectedDelegateField = IL2CPP.ResolveICall<set_size_InjectedDelegate>("UnityEngine.ReflectionProbe::set_size_Injected");
		get_center_InjectedDelegateField = IL2CPP.ResolveICall<get_center_InjectedDelegate>("UnityEngine.ReflectionProbe::get_center_Injected");
		set_center_InjectedDelegateField = IL2CPP.ResolveICall<set_center_InjectedDelegate>("UnityEngine.ReflectionProbe::set_center_Injected");
		get_nearClipPlane_InjectedDelegateField = IL2CPP.ResolveICall<get_nearClipPlane_InjectedDelegate>("UnityEngine.ReflectionProbe::get_nearClipPlane_Injected");
		set_nearClipPlane_InjectedDelegateField = IL2CPP.ResolveICall<set_nearClipPlane_InjectedDelegate>("UnityEngine.ReflectionProbe::set_nearClipPlane_Injected");
		get_farClipPlane_InjectedDelegateField = IL2CPP.ResolveICall<get_farClipPlane_InjectedDelegate>("UnityEngine.ReflectionProbe::get_farClipPlane_Injected");
		set_farClipPlane_InjectedDelegateField = IL2CPP.ResolveICall<set_farClipPlane_InjectedDelegate>("UnityEngine.ReflectionProbe::set_farClipPlane_Injected");
		get_intensity_InjectedDelegateField = IL2CPP.ResolveICall<get_intensity_InjectedDelegate>("UnityEngine.ReflectionProbe::get_intensity_Injected");
		set_intensity_InjectedDelegateField = IL2CPP.ResolveICall<set_intensity_InjectedDelegate>("UnityEngine.ReflectionProbe::set_intensity_Injected");
		get_bounds_InjectedDelegateField = IL2CPP.ResolveICall<get_bounds_InjectedDelegate>("UnityEngine.ReflectionProbe::get_bounds_Injected");
		get_hdr_InjectedDelegateField = IL2CPP.ResolveICall<get_hdr_InjectedDelegate>("UnityEngine.ReflectionProbe::get_hdr_Injected");
		set_hdr_InjectedDelegateField = IL2CPP.ResolveICall<set_hdr_InjectedDelegate>("UnityEngine.ReflectionProbe::set_hdr_Injected");
		get_renderDynamicObjects_InjectedDelegateField = IL2CPP.ResolveICall<get_renderDynamicObjects_InjectedDelegate>("UnityEngine.ReflectionProbe::get_renderDynamicObjects_Injected");
		set_renderDynamicObjects_InjectedDelegateField = IL2CPP.ResolveICall<set_renderDynamicObjects_InjectedDelegate>("UnityEngine.ReflectionProbe::set_renderDynamicObjects_Injected");
		get_shadowDistance_InjectedDelegateField = IL2CPP.ResolveICall<get_shadowDistance_InjectedDelegate>("UnityEngine.ReflectionProbe::get_shadowDistance_Injected");
		set_shadowDistance_InjectedDelegateField = IL2CPP.ResolveICall<set_shadowDistance_InjectedDelegate>("UnityEngine.ReflectionProbe::set_shadowDistance_Injected");
		get_resolution_InjectedDelegateField = IL2CPP.ResolveICall<get_resolution_InjectedDelegate>("UnityEngine.ReflectionProbe::get_resolution_Injected");
		set_resolution_InjectedDelegateField = IL2CPP.ResolveICall<set_resolution_InjectedDelegate>("UnityEngine.ReflectionProbe::set_resolution_Injected");
		get_cullingMask_InjectedDelegateField = IL2CPP.ResolveICall<get_cullingMask_InjectedDelegate>("UnityEngine.ReflectionProbe::get_cullingMask_Injected");
		set_cullingMask_InjectedDelegateField = IL2CPP.ResolveICall<set_cullingMask_InjectedDelegate>("UnityEngine.ReflectionProbe::set_cullingMask_Injected");
		get_clearFlags_InjectedDelegateField = IL2CPP.ResolveICall<get_clearFlags_InjectedDelegate>("UnityEngine.ReflectionProbe::get_clearFlags_Injected");
		set_clearFlags_InjectedDelegateField = IL2CPP.ResolveICall<set_clearFlags_InjectedDelegate>("UnityEngine.ReflectionProbe::set_clearFlags_Injected");
		get_backgroundColor_InjectedDelegateField = IL2CPP.ResolveICall<get_backgroundColor_InjectedDelegate>("UnityEngine.ReflectionProbe::get_backgroundColor_Injected");
		set_backgroundColor_InjectedDelegateField = IL2CPP.ResolveICall<set_backgroundColor_InjectedDelegate>("UnityEngine.ReflectionProbe::set_backgroundColor_Injected");
		get_blendDistance_InjectedDelegateField = IL2CPP.ResolveICall<get_blendDistance_InjectedDelegate>("UnityEngine.ReflectionProbe::get_blendDistance_Injected");
		set_blendDistance_InjectedDelegateField = IL2CPP.ResolveICall<set_blendDistance_InjectedDelegate>("UnityEngine.ReflectionProbe::set_blendDistance_Injected");
		get_boxProjection_InjectedDelegateField = IL2CPP.ResolveICall<get_boxProjection_InjectedDelegate>("UnityEngine.ReflectionProbe::get_boxProjection_Injected");
		set_boxProjection_InjectedDelegateField = IL2CPP.ResolveICall<set_boxProjection_InjectedDelegate>("UnityEngine.ReflectionProbe::set_boxProjection_Injected");
		get_mode_InjectedDelegateField = IL2CPP.ResolveICall<get_mode_InjectedDelegate>("UnityEngine.ReflectionProbe::get_mode_Injected");
		set_mode_InjectedDelegateField = IL2CPP.ResolveICall<set_mode_InjectedDelegate>("UnityEngine.ReflectionProbe::set_mode_Injected");
		get_importance_InjectedDelegateField = IL2CPP.ResolveICall<get_importance_InjectedDelegate>("UnityEngine.ReflectionProbe::get_importance_Injected");
		set_importance_InjectedDelegateField = IL2CPP.ResolveICall<set_importance_InjectedDelegate>("UnityEngine.ReflectionProbe::set_importance_Injected");
		set_refreshMode_InjectedDelegateField = IL2CPP.ResolveICall<set_refreshMode_InjectedDelegate>("UnityEngine.ReflectionProbe::set_refreshMode_Injected");
		get_timeSlicingMode_InjectedDelegateField = IL2CPP.ResolveICall<get_timeSlicingMode_InjectedDelegate>("UnityEngine.ReflectionProbe::get_timeSlicingMode_Injected");
		set_timeSlicingMode_InjectedDelegateField = IL2CPP.ResolveICall<set_timeSlicingMode_InjectedDelegate>("UnityEngine.ReflectionProbe::set_timeSlicingMode_Injected");
		get_bakedTexture_InjectedDelegateField = IL2CPP.ResolveICall<get_bakedTexture_InjectedDelegate>("UnityEngine.ReflectionProbe::get_bakedTexture_Injected");
		set_bakedTexture_InjectedDelegateField = IL2CPP.ResolveICall<set_bakedTexture_InjectedDelegate>("UnityEngine.ReflectionProbe::set_bakedTexture_Injected");
		get_customBakedTexture_InjectedDelegateField = IL2CPP.ResolveICall<get_customBakedTexture_InjectedDelegate>("UnityEngine.ReflectionProbe::get_customBakedTexture_Injected");
		set_customBakedTexture_InjectedDelegateField = IL2CPP.ResolveICall<set_customBakedTexture_InjectedDelegate>("UnityEngine.ReflectionProbe::set_customBakedTexture_Injected");
		get_realtimeTexture_InjectedDelegateField = IL2CPP.ResolveICall<get_realtimeTexture_InjectedDelegate>("UnityEngine.ReflectionProbe::get_realtimeTexture_Injected");
		set_realtimeTexture_InjectedDelegateField = IL2CPP.ResolveICall<set_realtimeTexture_InjectedDelegate>("UnityEngine.ReflectionProbe::set_realtimeTexture_Injected");
		get_texture_InjectedDelegateField = IL2CPP.ResolveICall<get_texture_InjectedDelegate>("UnityEngine.ReflectionProbe::get_texture_Injected");
		get_textureHDRDecodeValues_InjectedDelegateField = IL2CPP.ResolveICall<get_textureHDRDecodeValues_InjectedDelegate>("UnityEngine.ReflectionProbe::get_textureHDRDecodeValues_Injected");
		Reset_InjectedDelegateField = IL2CPP.ResolveICall<Reset_InjectedDelegate>("UnityEngine.ReflectionProbe::Reset_Injected");
		IsFinishedRendering_InjectedDelegateField = IL2CPP.ResolveICall<IsFinishedRendering_InjectedDelegate>("UnityEngine.ReflectionProbe::IsFinishedRendering_Injected");
		ScheduleRender_InjectedDelegateField = IL2CPP.ResolveICall<ScheduleRender_InjectedDelegate>("UnityEngine.ReflectionProbe::ScheduleRender_Injected");
		BlendCubemap_InjectedDelegateField = IL2CPP.ResolveICall<BlendCubemap_InjectedDelegate>("UnityEngine.ReflectionProbe::BlendCubemap_Injected");
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1169345, XrefRangeEnd = 1169349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CallReflectionProbeEvent(ReflectionProbe probe, ReflectionProbeEvent probeEvent)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)probe);
		*(ReflectionProbeEvent**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &probeEvent;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CallReflectionProbeEvent_Private_Static_Void_ReflectionProbe_ReflectionProbeEvent_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1169349, XrefRangeEnd = 1169367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CallSetDefaultReflection(Texture defaultReflectionCubemap)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)defaultReflectionCubemap);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CallSetDefaultReflection_Private_Static_Void_Texture_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1169367, XrefRangeEnd = 1169369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ReflectionProbeRefreshMode get_refreshMode_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_refreshMode_Injected_Private_Static_ReflectionProbeRefreshMode_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(ReflectionProbeRefreshMode*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1169369, XrefRangeEnd = 1169371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void get_defaultTextureHDRDecodeValues_Injected(out Vector4 ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_defaultTextureHDRDecodeValues_Injected_Private_Static_Void_byref_Vector4_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1169371, XrefRangeEnd = 1169373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr get_defaultTexture_Injected()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_defaultTexture_Injected_Private_Static_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public ReflectionProbe(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public void Reset()
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		Reset_Injected(intPtr);
	}

	public int RenderProbe()
	{
		return RenderProbe(null);
	}

	public int RenderProbe(RenderTexture targetTexture)
	{
		return ScheduleRender(timeSlicingMode, targetTexture);
	}

	public bool IsFinishedRendering(int renderId)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return IsFinishedRendering_Injected(intPtr, renderId);
	}

	public int ScheduleRender(ReflectionProbeTimeSlicingMode timeSlicingMode, RenderTexture targetTexture)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return ScheduleRender_Injected(intPtr, timeSlicingMode, MarshalledUnityObject.Marshal(targetTexture));
	}

	public static bool BlendCubemap(Texture src, Texture dst, float blend, RenderTexture target)
	{
		return BlendCubemap_Injected(MarshalledUnityObject.Marshal(src), MarshalledUnityObject.Marshal(dst), blend, MarshalledUnityObject.Marshal(target));
	}

	public static void UpdateCachedState()
	{
		UpdateCachedStateDelegateField();
	}

	[SpecialName]
	public static void add_reflectionProbeChanged(Il2CppSystem.Action<ReflectionProbe, ReflectionProbeEvent> value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	[SpecialName]
	public static void remove_reflectionProbeChanged(Il2CppSystem.Action<ReflectionProbe, ReflectionProbeEvent> value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	[SpecialName]
	public static void add_defaultReflectionSet(Il2CppSystem.Action<Cubemap> value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	[SpecialName]
	public static void remove_defaultReflectionSet(Il2CppSystem.Action<Cubemap> value)
	{
		if (registeredDefaultReflectionSetActions.TryGetValue(value.Method.GetHashCode(), out var value2))
		{
			remove_defaultReflectionTexture(value2);
			registeredDefaultReflectionSetActions.Remove(value.Method.GetHashCode());
		}
	}

	[SpecialName]
	public static void add_defaultReflectionTexture(Il2CppSystem.Action<Texture> value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	[SpecialName]
	public static void remove_defaultReflectionTexture(Il2CppSystem.Action<Texture> value)
	{
		registeredDefaultReflectionTextureActions.Remove(value);
	}

	public static ReflectionProbeType get_type_Injected(System.IntPtr _unity_self)
	{
		return get_type_InjectedDelegateField(_unity_self);
	}

	public static void set_type_Injected(System.IntPtr _unity_self, ReflectionProbeType value)
	{
		set_type_InjectedDelegateField(_unity_self, value);
	}

	public unsafe static void get_size_Injected(System.IntPtr _unity_self, out Vector3 ret)
	{
		get_size_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void set_size_Injected(System.IntPtr _unity_self, [In] ref Vector3 value)
	{
		set_size_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref value));
	}

	public unsafe static void get_center_Injected(System.IntPtr _unity_self, out Vector3 ret)
	{
		get_center_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void set_center_Injected(System.IntPtr _unity_self, [In] ref Vector3 value)
	{
		set_center_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref value));
	}

	public static float get_nearClipPlane_Injected(System.IntPtr _unity_self)
	{
		return get_nearClipPlane_InjectedDelegateField(_unity_self);
	}

	public static void set_nearClipPlane_Injected(System.IntPtr _unity_self, float value)
	{
		set_nearClipPlane_InjectedDelegateField(_unity_self, value);
	}

	public static float get_farClipPlane_Injected(System.IntPtr _unity_self)
	{
		return get_farClipPlane_InjectedDelegateField(_unity_self);
	}

	public static void set_farClipPlane_Injected(System.IntPtr _unity_self, float value)
	{
		set_farClipPlane_InjectedDelegateField(_unity_self, value);
	}

	public static float get_intensity_Injected(System.IntPtr _unity_self)
	{
		return get_intensity_InjectedDelegateField(_unity_self);
	}

	public static void set_intensity_Injected(System.IntPtr _unity_self, float value)
	{
		set_intensity_InjectedDelegateField(_unity_self, value);
	}

	public unsafe static void get_bounds_Injected(System.IntPtr _unity_self, out Bounds ret)
	{
		get_bounds_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public static bool get_hdr_Injected(System.IntPtr _unity_self)
	{
		return get_hdr_InjectedDelegateField(_unity_self);
	}

	public static void set_hdr_Injected(System.IntPtr _unity_self, bool value)
	{
		set_hdr_InjectedDelegateField(_unity_self, value);
	}

	public static bool get_renderDynamicObjects_Injected(System.IntPtr _unity_self)
	{
		return get_renderDynamicObjects_InjectedDelegateField(_unity_self);
	}

	public static void set_renderDynamicObjects_Injected(System.IntPtr _unity_self, bool value)
	{
		set_renderDynamicObjects_InjectedDelegateField(_unity_self, value);
	}

	public static float get_shadowDistance_Injected(System.IntPtr _unity_self)
	{
		return get_shadowDistance_InjectedDelegateField(_unity_self);
	}

	public static void set_shadowDistance_Injected(System.IntPtr _unity_self, float value)
	{
		set_shadowDistance_InjectedDelegateField(_unity_self, value);
	}

	public static int get_resolution_Injected(System.IntPtr _unity_self)
	{
		return get_resolution_InjectedDelegateField(_unity_self);
	}

	public static void set_resolution_Injected(System.IntPtr _unity_self, int value)
	{
		set_resolution_InjectedDelegateField(_unity_self, value);
	}

	public static int get_cullingMask_Injected(System.IntPtr _unity_self)
	{
		return get_cullingMask_InjectedDelegateField(_unity_self);
	}

	public static void set_cullingMask_Injected(System.IntPtr _unity_self, int value)
	{
		set_cullingMask_InjectedDelegateField(_unity_self, value);
	}

	public static ReflectionProbeClearFlags get_clearFlags_Injected(System.IntPtr _unity_self)
	{
		return get_clearFlags_InjectedDelegateField(_unity_self);
	}

	public static void set_clearFlags_Injected(System.IntPtr _unity_self, ReflectionProbeClearFlags value)
	{
		set_clearFlags_InjectedDelegateField(_unity_self, value);
	}

	public unsafe static void get_backgroundColor_Injected(System.IntPtr _unity_self, out Color ret)
	{
		get_backgroundColor_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void set_backgroundColor_Injected(System.IntPtr _unity_self, [In] ref Color value)
	{
		set_backgroundColor_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref value));
	}

	public static float get_blendDistance_Injected(System.IntPtr _unity_self)
	{
		return get_blendDistance_InjectedDelegateField(_unity_self);
	}

	public static void set_blendDistance_Injected(System.IntPtr _unity_self, float value)
	{
		set_blendDistance_InjectedDelegateField(_unity_self, value);
	}

	public static bool get_boxProjection_Injected(System.IntPtr _unity_self)
	{
		return get_boxProjection_InjectedDelegateField(_unity_self);
	}

	public static void set_boxProjection_Injected(System.IntPtr _unity_self, bool value)
	{
		set_boxProjection_InjectedDelegateField(_unity_self, value);
	}

	public static ReflectionProbeMode get_mode_Injected(System.IntPtr _unity_self)
	{
		return get_mode_InjectedDelegateField(_unity_self);
	}

	public static void set_mode_Injected(System.IntPtr _unity_self, ReflectionProbeMode value)
	{
		set_mode_InjectedDelegateField(_unity_self, value);
	}

	public static int get_importance_Injected(System.IntPtr _unity_self)
	{
		return get_importance_InjectedDelegateField(_unity_self);
	}

	public static void set_importance_Injected(System.IntPtr _unity_self, int value)
	{
		set_importance_InjectedDelegateField(_unity_self, value);
	}

	public static void set_refreshMode_Injected(System.IntPtr _unity_self, ReflectionProbeRefreshMode value)
	{
		set_refreshMode_InjectedDelegateField(_unity_self, value);
	}

	public static ReflectionProbeTimeSlicingMode get_timeSlicingMode_Injected(System.IntPtr _unity_self)
	{
		return get_timeSlicingMode_InjectedDelegateField(_unity_self);
	}

	public static void set_timeSlicingMode_Injected(System.IntPtr _unity_self, ReflectionProbeTimeSlicingMode value)
	{
		set_timeSlicingMode_InjectedDelegateField(_unity_self, value);
	}

	public static System.IntPtr get_bakedTexture_Injected(System.IntPtr _unity_self)
	{
		return get_bakedTexture_InjectedDelegateField(_unity_self);
	}

	public static void set_bakedTexture_Injected(System.IntPtr _unity_self, System.IntPtr value)
	{
		set_bakedTexture_InjectedDelegateField(_unity_self, value);
	}

	public static System.IntPtr get_customBakedTexture_Injected(System.IntPtr _unity_self)
	{
		return get_customBakedTexture_InjectedDelegateField(_unity_self);
	}

	public static void set_customBakedTexture_Injected(System.IntPtr _unity_self, System.IntPtr value)
	{
		set_customBakedTexture_InjectedDelegateField(_unity_self, value);
	}

	public static System.IntPtr get_realtimeTexture_Injected(System.IntPtr _unity_self)
	{
		return get_realtimeTexture_InjectedDelegateField(_unity_self);
	}

	public static void set_realtimeTexture_Injected(System.IntPtr _unity_self, System.IntPtr value)
	{
		set_realtimeTexture_InjectedDelegateField(_unity_self, value);
	}

	public static System.IntPtr get_texture_Injected(System.IntPtr _unity_self)
	{
		return get_texture_InjectedDelegateField(_unity_self);
	}

	public unsafe static void get_textureHDRDecodeValues_Injected(System.IntPtr _unity_self, out Vector4 ret)
	{
		get_textureHDRDecodeValues_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public static void Reset_Injected(System.IntPtr _unity_self)
	{
		Reset_InjectedDelegateField(_unity_self);
	}

	public static bool IsFinishedRendering_Injected(System.IntPtr _unity_self, int renderId)
	{
		return IsFinishedRendering_InjectedDelegateField(_unity_self, renderId);
	}

	public static int ScheduleRender_Injected(System.IntPtr _unity_self, ReflectionProbeTimeSlicingMode timeSlicingMode, System.IntPtr targetTexture)
	{
		return ScheduleRender_InjectedDelegateField(_unity_self, timeSlicingMode, targetTexture);
	}

	public static bool BlendCubemap_Injected(System.IntPtr src, System.IntPtr dst, float blend, System.IntPtr target)
	{
		return BlendCubemap_InjectedDelegateField(src, dst, blend, target);
	}
}
