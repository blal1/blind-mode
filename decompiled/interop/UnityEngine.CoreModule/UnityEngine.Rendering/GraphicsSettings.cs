using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using UnityEngine.Bindings;

namespace UnityEngine.Rendering;

public sealed class GraphicsSettings : Object
{
	[System.Serializable]
	[ObfuscatedName("UnityEngine.Rendering.GraphicsSettings+<>c")]
	public sealed class __c : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___9;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr___cctor_b__93_0_Internal_RenderPipelineGlobalSettings_0;

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
			Il2CppClassPointerStore<__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c>.NativeClassPtr);
			NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100667737);
			NativeMethodInfoPtr___cctor_b__93_0_Internal_RenderPipelineGlobalSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100667738);
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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1232238, XrefRangeEnd = 1232256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderPipelineGlobalSettings __cctor_b__93_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr___cctor_b__93_0_Internal_RenderPipelineGlobalSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RenderPipelineGlobalSettings>(intPtr2) : null;
		}

		public __c(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private sealed class MethodInfoStoreGeneric_GetSettingsForRenderPipeline_Public_Static_RenderPipelineGlobalSettings_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_GetSettingsForRenderPipeline_Public_Static_RenderPipelineGlobalSettings_0, Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_GetRenderPipelineSettings_Public_Static_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_GetRenderPipelineSettings_Public_Static_T_0, Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_TryGetRenderPipelineSettings_Public_Static_Boolean_byref_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_TryGetRenderPipelineSettings_Public_Static_Boolean_byref_T_0, Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	[System.Serializable]
	public sealed class _003C_003Ec
	{
	}

	private delegate TransparencySortMode get_transparencySortModeDelegate();

	private delegate void set_transparencySortModeDelegate(TransparencySortMode value);

	private delegate bool get_realtimeDirectRectangularAreaLightsDelegate();

	private delegate void set_realtimeDirectRectangularAreaLightsDelegate(bool value);

	private delegate bool get_lightsUseColorTemperatureDelegate();

	private delegate uint get_defaultRenderingLayerMaskDelegate();

	private delegate void set_defaultRenderingLayerMaskDelegate(uint value);

	private delegate Camera.GateFitMode get_defaultGateFitModeDelegate();

	private delegate void set_defaultGateFitModeDelegate(Camera.GateFitMode value);

	private delegate bool get_useScriptableRenderPipelineBatchingDelegate();

	private delegate bool get_logWhenShaderIsCompiledDelegate();

	private delegate void set_logWhenShaderIsCompiledDelegate(bool value);

	private delegate bool get_disableBuiltinCustomRenderTextureUpdateDelegate();

	private delegate void set_disableBuiltinCustomRenderTextureUpdateDelegate(bool value);

	private delegate VideoShadersIncludeMode get_videoShadersIncludeModeDelegate();

	private delegate LightProbeOutsideHullStrategy get_lightProbeOutsideHullStrategyDelegate();

	private delegate void set_lightProbeOutsideHullStrategyDelegate(LightProbeOutsideHullStrategy value);

	private delegate System.IntPtr GetAllConfiguredRenderPipelinesDelegate();

	private delegate void SetShaderModeDelegate(BuiltinShaderType type, BuiltinShaderMode mode);

	private delegate BuiltinShaderMode GetShaderModeDelegate(BuiltinShaderType type);

	private delegate bool get_cameraRelativeLightCullingDelegate();

	private delegate void set_cameraRelativeLightCullingDelegate(bool value);

	private delegate bool get_cameraRelativeShadowCullingDelegate();

	private delegate void set_cameraRelativeShadowCullingDelegate(bool value);

	private delegate void Internal_RegisterRenderPipeline_InjectedDelegate(System.IntPtr renderpipelineName, System.IntPtr settings);

	private delegate void Internal_UnregisterRenderPipeline_InjectedDelegate(System.IntPtr renderpipelineName);

	private delegate System.IntPtr get_INTERNAL_currentRenderPipelineGlobalSettings_InjectedDelegate();

	private delegate void set_INTERNAL_currentRenderPipelineGlobalSettings_InjectedDelegate(System.IntPtr value);

	private delegate void get_transparencySortAxis_InjectedDelegate([Out] System.IntPtr ret);

	private delegate void set_transparencySortAxis_InjectedDelegate([In] System.IntPtr value);

	private delegate void set_INTERNAL_defaultRenderPipeline_InjectedDelegate(System.IntPtr value);

	private delegate System.IntPtr GetGraphicsSettings_InjectedDelegate();

	private delegate void SetCustomShader_InjectedDelegate(BuiltinShaderType type, System.IntPtr shader);

	private delegate System.IntPtr GetCustomShader_InjectedDelegate(BuiltinShaderType type);

	private static readonly System.IntPtr NativeFieldInfoPtr_s_CurrentRenderPipelineGlobalSettings;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_lightsUseLinearIntensity_Public_Static_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_lightsUseLinearIntensity_Public_Static_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_lightsUseColorTemperature_Public_Static_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_useScriptableRenderPipelineBatching_Public_Static_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasShaderDefine_Public_Static_Boolean_GraphicsTier_BuiltinShaderDefine_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasShaderDefine_Public_Static_Boolean_BuiltinShaderDefine_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_INTERNAL_currentRenderPipeline_Private_Static_get_ScriptableObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_currentRenderPipeline_Public_Static_get_RenderPipelineAsset_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isScriptableRenderPipelineEnabled_Public_Static_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_currentRenderPipelineAssetType_Public_Static_get_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_INTERNAL_defaultRenderPipeline_Private_Static_get_ScriptableObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_defaultRenderPipeline_Public_Static_get_RenderPipelineAsset_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDefaultShader_Internal_Static_Shader_DefaultShaderType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDefaultMaterial_Internal_Static_Material_DefaultMaterialType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_GetSettingsForRenderPipeline_Private_Static_Object_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSettingsForRenderPipeline_Public_Static_RenderPipelineGlobalSettings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_GetCurrentRenderPipelineGlobalSettings_Private_Static_RenderPipelineGlobalSettings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryGetCurrentRenderPipelineGlobalSettings_Public_Static_Boolean_byref_RenderPipelineGlobalSettings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRenderPipelineSettings_Public_Static_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryGetRenderPipelineSettings_Public_Static_Boolean_byref_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_INTERNAL_currentRenderPipeline_Injected_Private_Static_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_INTERNAL_defaultRenderPipeline_Injected_Private_Static_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_GetSettingsForRenderPipeline_Injected_Private_Static_IntPtr_byref_ManagedSpanWrapper_0;

	private static readonly get_transparencySortModeDelegate get_transparencySortModeDelegateField;

	private static readonly set_transparencySortModeDelegate set_transparencySortModeDelegateField;

	private static readonly get_realtimeDirectRectangularAreaLightsDelegate get_realtimeDirectRectangularAreaLightsDelegateField;

	private static readonly set_realtimeDirectRectangularAreaLightsDelegate set_realtimeDirectRectangularAreaLightsDelegateField;

	private static readonly get_lightsUseColorTemperatureDelegate get_lightsUseColorTemperatureDelegateField;

	private static readonly get_defaultRenderingLayerMaskDelegate get_defaultRenderingLayerMaskDelegateField;

	private static readonly set_defaultRenderingLayerMaskDelegate set_defaultRenderingLayerMaskDelegateField;

	private static readonly get_defaultGateFitModeDelegate get_defaultGateFitModeDelegateField;

	private static readonly set_defaultGateFitModeDelegate set_defaultGateFitModeDelegateField;

	private static readonly get_useScriptableRenderPipelineBatchingDelegate get_useScriptableRenderPipelineBatchingDelegateField;

	private static readonly get_logWhenShaderIsCompiledDelegate get_logWhenShaderIsCompiledDelegateField;

	private static readonly set_logWhenShaderIsCompiledDelegate set_logWhenShaderIsCompiledDelegateField;

	private static readonly get_disableBuiltinCustomRenderTextureUpdateDelegate get_disableBuiltinCustomRenderTextureUpdateDelegateField;

	private static readonly set_disableBuiltinCustomRenderTextureUpdateDelegate set_disableBuiltinCustomRenderTextureUpdateDelegateField;

	private static readonly get_videoShadersIncludeModeDelegate get_videoShadersIncludeModeDelegateField;

	private static readonly get_lightProbeOutsideHullStrategyDelegate get_lightProbeOutsideHullStrategyDelegateField;

	private static readonly set_lightProbeOutsideHullStrategyDelegate set_lightProbeOutsideHullStrategyDelegateField;

	private static readonly GetAllConfiguredRenderPipelinesDelegate GetAllConfiguredRenderPipelinesDelegateField;

	private static readonly SetShaderModeDelegate SetShaderModeDelegateField;

	private static readonly GetShaderModeDelegate GetShaderModeDelegateField;

	private static readonly get_cameraRelativeLightCullingDelegate get_cameraRelativeLightCullingDelegateField;

	private static readonly set_cameraRelativeLightCullingDelegate set_cameraRelativeLightCullingDelegateField;

	private static readonly get_cameraRelativeShadowCullingDelegate get_cameraRelativeShadowCullingDelegateField;

	private static readonly set_cameraRelativeShadowCullingDelegate set_cameraRelativeShadowCullingDelegateField;

	private static readonly Internal_RegisterRenderPipeline_InjectedDelegate Internal_RegisterRenderPipeline_InjectedDelegateField;

	private static readonly Internal_UnregisterRenderPipeline_InjectedDelegate Internal_UnregisterRenderPipeline_InjectedDelegateField;

	private static readonly get_INTERNAL_currentRenderPipelineGlobalSettings_InjectedDelegate get_INTERNAL_currentRenderPipelineGlobalSettings_InjectedDelegateField;

	private static readonly set_INTERNAL_currentRenderPipelineGlobalSettings_InjectedDelegate set_INTERNAL_currentRenderPipelineGlobalSettings_InjectedDelegateField;

	private static readonly get_transparencySortAxis_InjectedDelegate get_transparencySortAxis_InjectedDelegateField;

	private static readonly set_transparencySortAxis_InjectedDelegate set_transparencySortAxis_InjectedDelegateField;

	private static readonly set_INTERNAL_defaultRenderPipeline_InjectedDelegate set_INTERNAL_defaultRenderPipeline_InjectedDelegateField;

	private static readonly GetGraphicsSettings_InjectedDelegate GetGraphicsSettings_InjectedDelegateField;

	private static readonly SetCustomShader_InjectedDelegate SetCustomShader_InjectedDelegateField;

	private static readonly GetCustomShader_InjectedDelegate GetCustomShader_InjectedDelegateField;

	public unsafe static Il2CppSystem.Lazy<RenderPipelineGlobalSettings> s_CurrentRenderPipelineGlobalSettings
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_CurrentRenderPipelineGlobalSettings, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Lazy<RenderPipelineGlobalSettings>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_CurrentRenderPipelineGlobalSettings, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static bool lightsUseLinearIntensity
	{
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1232258, RefRangeEnd = 1232265, XrefRangeStart = 1232256, XrefRangeEnd = 1232258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_lightsUseLinearIntensity_Public_Static_get_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1232267, RefRangeEnd = 1232268, XrefRangeStart = 1232265, XrefRangeEnd = 1232267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_lightsUseLinearIntensity_Public_Static_set_Void_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe static bool lightsUseColorTemperature
	{
		get
		{
			return get_lightsUseColorTemperatureDelegateField();
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1232270, RefRangeEnd = 1232271, XrefRangeStart = 1232268, XrefRangeEnd = 1232270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_lightsUseColorTemperature_Public_Static_set_Void_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe static bool useScriptableRenderPipelineBatching
	{
		get
		{
			return get_useScriptableRenderPipelineBatchingDelegateField();
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1232273, RefRangeEnd = 1232274, XrefRangeStart = 1232271, XrefRangeEnd = 1232273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_useScriptableRenderPipelineBatching_Public_Static_set_Void_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe static ScriptableObject INTERNAL_currentRenderPipeline
	{
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1232295, RefRangeEnd = 1232299, XrefRangeStart = 1232287, XrefRangeEnd = 1232295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_INTERNAL_currentRenderPipeline_Private_Static_get_ScriptableObject_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ScriptableObject>(intPtr2) : null;
		}
	}

	public unsafe static RenderPipelineAsset currentRenderPipeline
	{
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 1232305, RefRangeEnd = 1232322, XrefRangeStart = 1232299, XrefRangeEnd = 1232305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_currentRenderPipeline_Public_Static_get_RenderPipelineAsset_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RenderPipelineAsset>(intPtr2) : null;
		}
	}

	public unsafe static bool isScriptableRenderPipelineEnabled
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1232322, XrefRangeEnd = 1232330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isScriptableRenderPipelineEnabled_Public_Static_get_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static Il2CppSystem.Type currentRenderPipelineAssetType
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1232345, RefRangeEnd = 1232348, XrefRangeStart = 1232330, XrefRangeEnd = 1232345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_currentRenderPipelineAssetType_Public_Static_get_Type_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Type>(intPtr2) : null;
		}
	}

	public unsafe static ScriptableObject INTERNAL_defaultRenderPipeline
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1232348, XrefRangeEnd = 1232356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_INTERNAL_defaultRenderPipeline_Private_Static_get_ScriptableObject_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ScriptableObject>(intPtr2) : null;
		}
		set
		{
			set_INTERNAL_defaultRenderPipeline_Injected(MarshalledUnityObject.Marshal(value));
		}
	}

	public unsafe static RenderPipelineAsset defaultRenderPipeline
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1232369, RefRangeEnd = 1232370, XrefRangeStart = 1232356, XrefRangeEnd = 1232369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_defaultRenderPipeline_Public_Static_get_RenderPipelineAsset_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RenderPipelineAsset>(intPtr2) : null;
		}
		set
		{
			INTERNAL_defaultRenderPipeline = value;
		}
	}

	public static Object INTERNAL_currentRenderPipelineGlobalSettings
	{
		get
		{
			return Unmarshal.UnmarshalUnityObject<Object>(get_INTERNAL_currentRenderPipelineGlobalSettings_Injected());
		}
		set
		{
			set_INTERNAL_currentRenderPipelineGlobalSettings_Injected(MarshalledUnityObject.Marshal(value));
		}
	}

	public static RenderPipelineGlobalSettings currentRenderPipelineGlobalSettings
	{
		get
		{
			return ((Il2CppObjectBase)INTERNAL_currentRenderPipelineGlobalSettings).TryCast<RenderPipelineGlobalSettings>();
		}
		set
		{
			INTERNAL_currentRenderPipelineGlobalSettings = value;
		}
	}

	public static TransparencySortMode transparencySortMode
	{
		get
		{
			return get_transparencySortModeDelegateField();
		}
		set
		{
			set_transparencySortModeDelegateField(value);
		}
	}

	public static Vector3 transparencySortAxis
	{
		get
		{
			get_transparencySortAxis_Injected(out var ret);
			return ret;
		}
		set
		{
			set_transparencySortAxis_Injected(ref value);
		}
	}

	public static bool realtimeDirectRectangularAreaLights
	{
		get
		{
			return get_realtimeDirectRectangularAreaLightsDelegateField();
		}
		set
		{
			set_realtimeDirectRectangularAreaLightsDelegateField(value);
		}
	}

	public static uint defaultRenderingLayerMask
	{
		get
		{
			return get_defaultRenderingLayerMaskDelegateField();
		}
		set
		{
			set_defaultRenderingLayerMaskDelegateField(value);
		}
	}

	public static Camera.GateFitMode defaultGateFitMode
	{
		get
		{
			return get_defaultGateFitModeDelegateField();
		}
		set
		{
			set_defaultGateFitModeDelegateField(value);
		}
	}

	public static bool logWhenShaderIsCompiled
	{
		get
		{
			return get_logWhenShaderIsCompiledDelegateField();
		}
		set
		{
			set_logWhenShaderIsCompiledDelegateField(value);
		}
	}

	public static bool disableBuiltinCustomRenderTextureUpdate
	{
		get
		{
			return get_disableBuiltinCustomRenderTextureUpdateDelegateField();
		}
		set
		{
			set_disableBuiltinCustomRenderTextureUpdateDelegateField(value);
		}
	}

	public static VideoShadersIncludeMode videoShadersIncludeMode => get_videoShadersIncludeModeDelegateField();

	public static LightProbeOutsideHullStrategy lightProbeOutsideHullStrategy
	{
		get
		{
			return get_lightProbeOutsideHullStrategyDelegateField();
		}
		set
		{
			set_lightProbeOutsideHullStrategyDelegateField(value);
		}
	}

	public static RenderPipelineAsset renderPipelineAsset
	{
		get
		{
			return defaultRenderPipeline;
		}
		set
		{
			defaultRenderPipeline = value;
		}
	}

	public static Il2CppReferenceArray<RenderPipelineAsset> allConfiguredRenderPipelines
	{
		get
		{
			throw new System.NotSupportedException("Method unstripping failed");
		}
	}

	public static bool cameraRelativeLightCulling
	{
		get
		{
			return get_cameraRelativeLightCullingDelegateField();
		}
		set
		{
			set_cameraRelativeLightCullingDelegateField(value);
		}
	}

	public static bool cameraRelativeShadowCulling
	{
		get
		{
			return get_cameraRelativeShadowCullingDelegateField();
		}
		set
		{
			set_cameraRelativeShadowCullingDelegateField(value);
		}
	}

	static GraphicsSettings()
	{
		Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "GraphicsSettings");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr);
		NativeFieldInfoPtr_s_CurrentRenderPipelineGlobalSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr, "s_CurrentRenderPipelineGlobalSettings");
		NativeMethodInfoPtr_get_lightsUseLinearIntensity_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr, 100667712);
		NativeMethodInfoPtr_set_lightsUseLinearIntensity_Public_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr, 100667713);
		NativeMethodInfoPtr_set_lightsUseColorTemperature_Public_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr, 100667714);
		NativeMethodInfoPtr_set_useScriptableRenderPipelineBatching_Public_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr, 100667715);
		NativeMethodInfoPtr_HasShaderDefine_Public_Static_Boolean_GraphicsTier_BuiltinShaderDefine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr, 100667716);
		NativeMethodInfoPtr_HasShaderDefine_Public_Static_Boolean_BuiltinShaderDefine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr, 100667717);
		NativeMethodInfoPtr_get_INTERNAL_currentRenderPipeline_Private_Static_get_ScriptableObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr, 100667718);
		NativeMethodInfoPtr_get_currentRenderPipeline_Public_Static_get_RenderPipelineAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr, 100667719);
		NativeMethodInfoPtr_get_isScriptableRenderPipelineEnabled_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr, 100667720);
		NativeMethodInfoPtr_get_currentRenderPipelineAssetType_Public_Static_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr, 100667721);
		NativeMethodInfoPtr_get_INTERNAL_defaultRenderPipeline_Private_Static_get_ScriptableObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr, 100667722);
		NativeMethodInfoPtr_get_defaultRenderPipeline_Public_Static_get_RenderPipelineAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr, 100667723);
		NativeMethodInfoPtr_GetDefaultShader_Internal_Static_Shader_DefaultShaderType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr, 100667724);
		NativeMethodInfoPtr_GetDefaultMaterial_Internal_Static_Material_DefaultMaterialType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr, 100667725);
		NativeMethodInfoPtr_Internal_GetSettingsForRenderPipeline_Private_Static_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr, 100667726);
		NativeMethodInfoPtr_GetSettingsForRenderPipeline_Public_Static_RenderPipelineGlobalSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr, 100667727);
		NativeMethodInfoPtr_Internal_GetCurrentRenderPipelineGlobalSettings_Private_Static_RenderPipelineGlobalSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr, 100667728);
		NativeMethodInfoPtr_TryGetCurrentRenderPipelineGlobalSettings_Public_Static_Boolean_byref_RenderPipelineGlobalSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr, 100667729);
		NativeMethodInfoPtr_GetRenderPipelineSettings_Public_Static_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr, 100667730);
		NativeMethodInfoPtr_TryGetRenderPipelineSettings_Public_Static_Boolean_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr, 100667731);
		NativeMethodInfoPtr_get_INTERNAL_currentRenderPipeline_Injected_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr, 100667733);
		NativeMethodInfoPtr_get_INTERNAL_defaultRenderPipeline_Injected_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr, 100667734);
		NativeMethodInfoPtr_Internal_GetSettingsForRenderPipeline_Injected_Private_Static_IntPtr_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr, 100667735);
		get_transparencySortModeDelegateField = IL2CPP.ResolveICall<get_transparencySortModeDelegate>("UnityEngine.Rendering.GraphicsSettings::get_transparencySortMode");
		set_transparencySortModeDelegateField = IL2CPP.ResolveICall<set_transparencySortModeDelegate>("UnityEngine.Rendering.GraphicsSettings::set_transparencySortMode");
		get_realtimeDirectRectangularAreaLightsDelegateField = IL2CPP.ResolveICall<get_realtimeDirectRectangularAreaLightsDelegate>("UnityEngine.Rendering.GraphicsSettings::get_realtimeDirectRectangularAreaLights");
		set_realtimeDirectRectangularAreaLightsDelegateField = IL2CPP.ResolveICall<set_realtimeDirectRectangularAreaLightsDelegate>("UnityEngine.Rendering.GraphicsSettings::set_realtimeDirectRectangularAreaLights");
		get_lightsUseColorTemperatureDelegateField = IL2CPP.ResolveICall<get_lightsUseColorTemperatureDelegate>("UnityEngine.Rendering.GraphicsSettings::get_lightsUseColorTemperature");
		get_defaultRenderingLayerMaskDelegateField = IL2CPP.ResolveICall<get_defaultRenderingLayerMaskDelegate>("UnityEngine.Rendering.GraphicsSettings::get_defaultRenderingLayerMask");
		set_defaultRenderingLayerMaskDelegateField = IL2CPP.ResolveICall<set_defaultRenderingLayerMaskDelegate>("UnityEngine.Rendering.GraphicsSettings::set_defaultRenderingLayerMask");
		get_defaultGateFitModeDelegateField = IL2CPP.ResolveICall<get_defaultGateFitModeDelegate>("UnityEngine.Rendering.GraphicsSettings::get_defaultGateFitMode");
		set_defaultGateFitModeDelegateField = IL2CPP.ResolveICall<set_defaultGateFitModeDelegate>("UnityEngine.Rendering.GraphicsSettings::set_defaultGateFitMode");
		get_useScriptableRenderPipelineBatchingDelegateField = IL2CPP.ResolveICall<get_useScriptableRenderPipelineBatchingDelegate>("UnityEngine.Rendering.GraphicsSettings::get_useScriptableRenderPipelineBatching");
		get_logWhenShaderIsCompiledDelegateField = IL2CPP.ResolveICall<get_logWhenShaderIsCompiledDelegate>("UnityEngine.Rendering.GraphicsSettings::get_logWhenShaderIsCompiled");
		set_logWhenShaderIsCompiledDelegateField = IL2CPP.ResolveICall<set_logWhenShaderIsCompiledDelegate>("UnityEngine.Rendering.GraphicsSettings::set_logWhenShaderIsCompiled");
		get_disableBuiltinCustomRenderTextureUpdateDelegateField = IL2CPP.ResolveICall<get_disableBuiltinCustomRenderTextureUpdateDelegate>("UnityEngine.Rendering.GraphicsSettings::get_disableBuiltinCustomRenderTextureUpdate");
		set_disableBuiltinCustomRenderTextureUpdateDelegateField = IL2CPP.ResolveICall<set_disableBuiltinCustomRenderTextureUpdateDelegate>("UnityEngine.Rendering.GraphicsSettings::set_disableBuiltinCustomRenderTextureUpdate");
		get_videoShadersIncludeModeDelegateField = IL2CPP.ResolveICall<get_videoShadersIncludeModeDelegate>("UnityEngine.Rendering.GraphicsSettings::get_videoShadersIncludeMode");
		get_lightProbeOutsideHullStrategyDelegateField = IL2CPP.ResolveICall<get_lightProbeOutsideHullStrategyDelegate>("UnityEngine.Rendering.GraphicsSettings::get_lightProbeOutsideHullStrategy");
		set_lightProbeOutsideHullStrategyDelegateField = IL2CPP.ResolveICall<set_lightProbeOutsideHullStrategyDelegate>("UnityEngine.Rendering.GraphicsSettings::set_lightProbeOutsideHullStrategy");
		GetAllConfiguredRenderPipelinesDelegateField = IL2CPP.ResolveICall<GetAllConfiguredRenderPipelinesDelegate>("UnityEngine.Rendering.GraphicsSettings::GetAllConfiguredRenderPipelines");
		SetShaderModeDelegateField = IL2CPP.ResolveICall<SetShaderModeDelegate>("UnityEngine.Rendering.GraphicsSettings::SetShaderMode");
		GetShaderModeDelegateField = IL2CPP.ResolveICall<GetShaderModeDelegate>("UnityEngine.Rendering.GraphicsSettings::GetShaderMode");
		get_cameraRelativeLightCullingDelegateField = IL2CPP.ResolveICall<get_cameraRelativeLightCullingDelegate>("UnityEngine.Rendering.GraphicsSettings::get_cameraRelativeLightCulling");
		set_cameraRelativeLightCullingDelegateField = IL2CPP.ResolveICall<set_cameraRelativeLightCullingDelegate>("UnityEngine.Rendering.GraphicsSettings::set_cameraRelativeLightCulling");
		get_cameraRelativeShadowCullingDelegateField = IL2CPP.ResolveICall<get_cameraRelativeShadowCullingDelegate>("UnityEngine.Rendering.GraphicsSettings::get_cameraRelativeShadowCulling");
		set_cameraRelativeShadowCullingDelegateField = IL2CPP.ResolveICall<set_cameraRelativeShadowCullingDelegate>("UnityEngine.Rendering.GraphicsSettings::set_cameraRelativeShadowCulling");
		Internal_RegisterRenderPipeline_InjectedDelegateField = IL2CPP.ResolveICall<Internal_RegisterRenderPipeline_InjectedDelegate>("UnityEngine.Rendering.GraphicsSettings::Internal_RegisterRenderPipeline_Injected");
		Internal_UnregisterRenderPipeline_InjectedDelegateField = IL2CPP.ResolveICall<Internal_UnregisterRenderPipeline_InjectedDelegate>("UnityEngine.Rendering.GraphicsSettings::Internal_UnregisterRenderPipeline_Injected");
		get_INTERNAL_currentRenderPipelineGlobalSettings_InjectedDelegateField = IL2CPP.ResolveICall<get_INTERNAL_currentRenderPipelineGlobalSettings_InjectedDelegate>("UnityEngine.Rendering.GraphicsSettings::get_INTERNAL_currentRenderPipelineGlobalSettings_Injected");
		set_INTERNAL_currentRenderPipelineGlobalSettings_InjectedDelegateField = IL2CPP.ResolveICall<set_INTERNAL_currentRenderPipelineGlobalSettings_InjectedDelegate>("UnityEngine.Rendering.GraphicsSettings::set_INTERNAL_currentRenderPipelineGlobalSettings_Injected");
		get_transparencySortAxis_InjectedDelegateField = IL2CPP.ResolveICall<get_transparencySortAxis_InjectedDelegate>("UnityEngine.Rendering.GraphicsSettings::get_transparencySortAxis_Injected");
		set_transparencySortAxis_InjectedDelegateField = IL2CPP.ResolveICall<set_transparencySortAxis_InjectedDelegate>("UnityEngine.Rendering.GraphicsSettings::set_transparencySortAxis_Injected");
		set_INTERNAL_defaultRenderPipeline_InjectedDelegateField = IL2CPP.ResolveICall<set_INTERNAL_defaultRenderPipeline_InjectedDelegate>("UnityEngine.Rendering.GraphicsSettings::set_INTERNAL_defaultRenderPipeline_Injected");
		GetGraphicsSettings_InjectedDelegateField = IL2CPP.ResolveICall<GetGraphicsSettings_InjectedDelegate>("UnityEngine.Rendering.GraphicsSettings::GetGraphicsSettings_Injected");
		SetCustomShader_InjectedDelegateField = IL2CPP.ResolveICall<SetCustomShader_InjectedDelegate>("UnityEngine.Rendering.GraphicsSettings::SetCustomShader_Injected");
		GetCustomShader_InjectedDelegateField = IL2CPP.ResolveICall<GetCustomShader_InjectedDelegate>("UnityEngine.Rendering.GraphicsSettings::GetCustomShader_Injected");
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1232274, XrefRangeEnd = 1232276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool HasShaderDefine(GraphicsTier tier, BuiltinShaderDefine defineHash)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&tier);
		*(BuiltinShaderDefine**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &defineHash;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasShaderDefine_Public_Static_Boolean_GraphicsTier_BuiltinShaderDefine_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1232285, RefRangeEnd = 1232287, XrefRangeStart = 1232276, XrefRangeEnd = 1232285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool HasShaderDefine(BuiltinShaderDefine defineHash)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&defineHash);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasShaderDefine_Public_Static_Boolean_BuiltinShaderDefine_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1232370, XrefRangeEnd = 1232379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Shader GetDefaultShader(DefaultShaderType type)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&type);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDefaultShader_Internal_Static_Shader_DefaultShaderType_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1232379, XrefRangeEnd = 1232388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Material GetDefaultMaterial(DefaultMaterialType type)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&type);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDefaultMaterial_Internal_Static_Material_DefaultMaterialType_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1232409, RefRangeEnd = 1232412, XrefRangeStart = 1232388, XrefRangeEnd = 1232409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Object Internal_GetSettingsForRenderPipeline(string renderpipelineName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(renderpipelineName);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_GetSettingsForRenderPipeline_Private_Static_Object_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1232422, RefRangeEnd = 1232423, XrefRangeStart = 1232412, XrefRangeEnd = 1232422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static RenderPipelineGlobalSettings GetSettingsForRenderPipeline<T>() where T : RenderPipeline
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_GetSettingsForRenderPipeline_Public_Static_RenderPipelineGlobalSettings_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RenderPipelineGlobalSettings>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1232423, XrefRangeEnd = 1232438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static RenderPipelineGlobalSettings Internal_GetCurrentRenderPipelineGlobalSettings()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_GetCurrentRenderPipelineGlobalSettings_Private_Static_RenderPipelineGlobalSettings_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RenderPipelineGlobalSettings>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1232471, RefRangeEnd = 1232473, XrefRangeStart = 1232438, XrefRangeEnd = 1232471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool TryGetCurrentRenderPipelineGlobalSettings(out RenderPipelineGlobalSettings asset)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		nint num = 0;
		*ptr = (nint)(&num);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryGetCurrentRenderPipelineGlobalSettings_Public_Static_Boolean_byref_RenderPipelineGlobalSettings_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num2 = num;
		asset = ((num2 == 0) ? null : new RenderPipelineGlobalSettings(num2));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(18)]
	[CachedScanResults(RefRangeStart = 1232491, RefRangeEnd = 1232509, XrefRangeStart = 1232473, XrefRangeEnd = 1232491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static T GetRenderPipelineSettings<T>() where T : class
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_GetRenderPipelineSettings_Public_Static_T_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
	}

	[CallerCount(15)]
	[CachedScanResults(RefRangeStart = 1232523, RefRangeEnd = 1232538, XrefRangeStart = 1232509, XrefRangeEnd = 1232523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool TryGetRenderPipelineSettings<T>(out T settings) where T : class
	{
		//IL_0026->IL0028: Incompatible stack types: I vs Ref
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		Unsafe.SkipInit(out nint num);
		ref T reference;
		if (!typeof(T).IsValueType)
		{
			num = 0;
			reference = ref *(_003F*)(&num);
		}
		else
		{
			reference = ref settings;
		}
		*ptr = (nint)Unsafe.AsPointer(ref reference);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_TryGetRenderPipelineSettings_Public_Static_Boolean_byref_T_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		if (!typeof(T).IsValueType)
		{
			nint num2 = num;
			settings = ((num2 == 0) ? null : IL2CPP.PointerToValueGeneric<T>((System.IntPtr)num2, false, false));
		}
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1232538, XrefRangeEnd = 1232540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr get_INTERNAL_currentRenderPipeline_Injected()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_INTERNAL_currentRenderPipeline_Injected_Private_Static_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1232540, XrefRangeEnd = 1232542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr get_INTERNAL_defaultRenderPipeline_Injected()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_INTERNAL_defaultRenderPipeline_Injected_Private_Static_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1232542, XrefRangeEnd = 1232544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr Internal_GetSettingsForRenderPipeline_Injected(ref ManagedSpanWrapper renderpipelineName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref renderpipelineName);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_GetSettingsForRenderPipeline_Injected_Private_Static_IntPtr_byref_ManagedSpanWrapper_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public GraphicsSettings(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public unsafe static void Internal_RegisterRenderPipeline(string renderpipelineName, Object settings)
	{
		//IL_0018: Expected O, but got Ref
		//IL_0024: Expected O, but got Ref
		//The blocks IL_0029 are reachable both inside and outside the pinned region starting at IL_0018. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(renderpipelineName, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(renderpipelineName);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					Internal_RegisterRenderPipeline_Injected(ref managedSpanWrapper, MarshalledUnityObject.Marshal(settings));
					return;
				}
			}
			Internal_RegisterRenderPipeline_Injected(ref managedSpanWrapper, MarshalledUnityObject.Marshal(settings));
		}
		finally
		{
		}
	}

	public unsafe static void Internal_UnregisterRenderPipeline(string renderpipelineName)
	{
		//IL_0018: Expected O, but got Ref
		//IL_0024: Expected O, but got Ref
		//The blocks IL_0029 are reachable both inside and outside the pinned region starting at IL_0018. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(renderpipelineName, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(renderpipelineName);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					Internal_UnregisterRenderPipeline_Injected(ref managedSpanWrapper);
					return;
				}
			}
			Internal_UnregisterRenderPipeline_Injected(ref managedSpanWrapper);
		}
		finally
		{
		}
	}

	public static void CheckRenderPipelineType(Il2CppSystem.Type renderPipelineType)
	{
		if (renderPipelineType == null)
		{
			throw new Il2CppSystem.ArgumentNullException("renderPipelineType");
		}
		if (!Il2CppSystem.Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<RenderPipeline>()).IsAssignableFrom(renderPipelineType))
		{
			throw new Il2CppSystem.ArgumentException(Il2CppSystem.String.Format("{0} must be a valid {1}", renderPipelineType, "RenderPipeline"));
		}
	}

	public static void UpdateGraphicsSettings(RenderPipelineGlobalSettings newSettings, Il2CppSystem.Type renderPipelineType)
	{
		CheckRenderPipelineType(renderPipelineType);
		if (newSettings != null)
		{
			Internal_RegisterRenderPipeline(renderPipelineType.FullName, newSettings);
		}
		else
		{
			Internal_UnregisterRenderPipeline(renderPipelineType.FullName);
		}
	}

	public static void RegisterRenderPipelineSettings(Il2CppSystem.Type renderPipelineType, RenderPipelineGlobalSettings settings)
	{
		CheckRenderPipelineType(renderPipelineType);
		Internal_RegisterRenderPipeline(renderPipelineType.FullName, settings);
	}

	public static void RegisterRenderPipelineSettings<T>(RenderPipelineGlobalSettings settings) where T : RenderPipeline
	{
		Internal_RegisterRenderPipeline(Il2CppSystem.Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()).FullName, settings);
	}

	public static void UnregisterRenderPipelineSettings<T>() where T : RenderPipeline
	{
		Internal_UnregisterRenderPipeline(Il2CppSystem.Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()).FullName);
	}

	public static void UnregisterRenderPipelineSettings(Il2CppSystem.Type renderPipelineType)
	{
		CheckRenderPipelineType(renderPipelineType);
		Internal_UnregisterRenderPipeline(renderPipelineType.FullName);
	}

	public static RenderPipelineGlobalSettings GetSettingsForRenderPipeline(Il2CppSystem.Type renderPipelineType)
	{
		CheckRenderPipelineType(renderPipelineType);
		return ((Il2CppObjectBase)Internal_GetSettingsForRenderPipeline(renderPipelineType.FullName)).TryCast<RenderPipelineGlobalSettings>();
	}

	public static Il2CppReferenceArray<ScriptableObject> GetAllConfiguredRenderPipelines()
	{
		System.IntPtr intPtr = GetAllConfiguredRenderPipelinesDelegateField();
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ScriptableObject>>(intPtr) : null;
	}

	public static Object GetGraphicsSettings()
	{
		return Unmarshal.UnmarshalUnityObject<Object>(GetGraphicsSettings_Injected());
	}

	public static void SetShaderMode(BuiltinShaderType type, BuiltinShaderMode mode)
	{
		SetShaderModeDelegateField(type, mode);
	}

	public static BuiltinShaderMode GetShaderMode(BuiltinShaderType type)
	{
		return GetShaderModeDelegateField(type);
	}

	public static void SetCustomShader(BuiltinShaderType type, Shader shader)
	{
		SetCustomShader_Injected(type, MarshalledUnityObject.Marshal(shader));
	}

	public static Shader GetCustomShader(BuiltinShaderType type)
	{
		return Unmarshal.UnmarshalUnityObject<Shader>(GetCustomShader_Injected(type));
	}

	public unsafe static void Internal_RegisterRenderPipeline_Injected(ref ManagedSpanWrapper renderpipelineName, System.IntPtr settings)
	{
		Internal_RegisterRenderPipeline_InjectedDelegateField((nint)Unsafe.AsPointer(ref renderpipelineName), settings);
	}

	public unsafe static void Internal_UnregisterRenderPipeline_Injected(ref ManagedSpanWrapper renderpipelineName)
	{
		Internal_UnregisterRenderPipeline_InjectedDelegateField((nint)Unsafe.AsPointer(ref renderpipelineName));
	}

	public static System.IntPtr get_INTERNAL_currentRenderPipelineGlobalSettings_Injected()
	{
		return get_INTERNAL_currentRenderPipelineGlobalSettings_InjectedDelegateField();
	}

	public static void set_INTERNAL_currentRenderPipelineGlobalSettings_Injected(System.IntPtr value)
	{
		set_INTERNAL_currentRenderPipelineGlobalSettings_InjectedDelegateField(value);
	}

	public unsafe static void get_transparencySortAxis_Injected(out Vector3 ret)
	{
		get_transparencySortAxis_InjectedDelegateField((nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void set_transparencySortAxis_Injected([In] ref Vector3 value)
	{
		set_transparencySortAxis_InjectedDelegateField((nint)Unsafe.AsPointer(ref value));
	}

	public static void set_INTERNAL_defaultRenderPipeline_Injected(System.IntPtr value)
	{
		set_INTERNAL_defaultRenderPipeline_InjectedDelegateField(value);
	}

	public static System.IntPtr GetGraphicsSettings_Injected()
	{
		return GetGraphicsSettings_InjectedDelegateField();
	}

	public static void SetCustomShader_Injected(BuiltinShaderType type, System.IntPtr shader)
	{
		SetCustomShader_InjectedDelegateField(type, shader);
	}

	public static System.IntPtr GetCustomShader_Injected(BuiltinShaderType type)
	{
		return GetCustomShader_InjectedDelegateField(type);
	}
}
