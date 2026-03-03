using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;
using UnityEngine.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering.Universal.Internal;

public class ForwardLights : Il2CppSystem.Object
{
	public static class LightConstantBuffer : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr__MainLightPosition;

		private static readonly System.IntPtr NativeFieldInfoPtr__MainLightColor;

		private static readonly System.IntPtr NativeFieldInfoPtr__MainLightOcclusionProbesChannel;

		private static readonly System.IntPtr NativeFieldInfoPtr__MainLightLayerMask;

		private static readonly System.IntPtr NativeFieldInfoPtr__AdditionalLightsCount;

		private static readonly System.IntPtr NativeFieldInfoPtr__AdditionalLightsPosition;

		private static readonly System.IntPtr NativeFieldInfoPtr__AdditionalLightsColor;

		private static readonly System.IntPtr NativeFieldInfoPtr__AdditionalLightsAttenuation;

		private static readonly System.IntPtr NativeFieldInfoPtr__AdditionalLightsSpotDir;

		private static readonly System.IntPtr NativeFieldInfoPtr__AdditionalLightOcclusionProbeChannel;

		private static readonly System.IntPtr NativeFieldInfoPtr__AdditionalLightsLayerMasks;

		public unsafe static int _MainLightPosition
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__MainLightPosition, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__MainLightPosition, (void*)(&value));
			}
		}

		public unsafe static int _MainLightColor
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__MainLightColor, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__MainLightColor, (void*)(&value));
			}
		}

		public unsafe static int _MainLightOcclusionProbesChannel
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__MainLightOcclusionProbesChannel, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__MainLightOcclusionProbesChannel, (void*)(&value));
			}
		}

		public unsafe static int _MainLightLayerMask
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__MainLightLayerMask, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__MainLightLayerMask, (void*)(&value));
			}
		}

		public unsafe static int _AdditionalLightsCount
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__AdditionalLightsCount, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__AdditionalLightsCount, (void*)(&value));
			}
		}

		public unsafe static int _AdditionalLightsPosition
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__AdditionalLightsPosition, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__AdditionalLightsPosition, (void*)(&value));
			}
		}

		public unsafe static int _AdditionalLightsColor
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__AdditionalLightsColor, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__AdditionalLightsColor, (void*)(&value));
			}
		}

		public unsafe static int _AdditionalLightsAttenuation
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__AdditionalLightsAttenuation, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__AdditionalLightsAttenuation, (void*)(&value));
			}
		}

		public unsafe static int _AdditionalLightsSpotDir
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__AdditionalLightsSpotDir, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__AdditionalLightsSpotDir, (void*)(&value));
			}
		}

		public unsafe static int _AdditionalLightOcclusionProbeChannel
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__AdditionalLightOcclusionProbeChannel, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__AdditionalLightOcclusionProbeChannel, (void*)(&value));
			}
		}

		public unsafe static int _AdditionalLightsLayerMasks
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__AdditionalLightsLayerMasks, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__AdditionalLightsLayerMasks, (void*)(&value));
			}
		}

		static LightConstantBuffer()
		{
			Il2CppClassPointerStore<LightConstantBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ForwardLights>.NativeClassPtr, "LightConstantBuffer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightConstantBuffer>.NativeClassPtr);
			NativeFieldInfoPtr__MainLightPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightConstantBuffer>.NativeClassPtr, "_MainLightPosition");
			NativeFieldInfoPtr__MainLightColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightConstantBuffer>.NativeClassPtr, "_MainLightColor");
			NativeFieldInfoPtr__MainLightOcclusionProbesChannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightConstantBuffer>.NativeClassPtr, "_MainLightOcclusionProbesChannel");
			NativeFieldInfoPtr__MainLightLayerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightConstantBuffer>.NativeClassPtr, "_MainLightLayerMask");
			NativeFieldInfoPtr__AdditionalLightsCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightConstantBuffer>.NativeClassPtr, "_AdditionalLightsCount");
			NativeFieldInfoPtr__AdditionalLightsPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightConstantBuffer>.NativeClassPtr, "_AdditionalLightsPosition");
			NativeFieldInfoPtr__AdditionalLightsColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightConstantBuffer>.NativeClassPtr, "_AdditionalLightsColor");
			NativeFieldInfoPtr__AdditionalLightsAttenuation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightConstantBuffer>.NativeClassPtr, "_AdditionalLightsAttenuation");
			NativeFieldInfoPtr__AdditionalLightsSpotDir = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightConstantBuffer>.NativeClassPtr, "_AdditionalLightsSpotDir");
			NativeFieldInfoPtr__AdditionalLightOcclusionProbeChannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightConstantBuffer>.NativeClassPtr, "_AdditionalLightOcclusionProbeChannel");
			NativeFieldInfoPtr__AdditionalLightsLayerMasks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightConstantBuffer>.NativeClassPtr, "_AdditionalLightsLayerMasks");
		}

		public LightConstantBuffer(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public sealed class InitParams : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_lightCookieManager;

		private static readonly System.IntPtr NativeFieldInfoPtr_forwardPlus;

		private static readonly System.IntPtr NativeMethodInfoPtr_Create_Internal_Static_InitParams_0;

		public unsafe LightCookieManager lightCookieManager
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lightCookieManager);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<LightCookieManager>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lightCookieManager)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe bool forwardPlus
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forwardPlus);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forwardPlus)) = value;
			}
		}

		static InitParams()
		{
			Il2CppClassPointerStore<InitParams>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ForwardLights>.NativeClassPtr, "InitParams");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InitParams>.NativeClassPtr);
			NativeFieldInfoPtr_lightCookieManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitParams>.NativeClassPtr, "lightCookieManager");
			NativeFieldInfoPtr_forwardPlus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitParams>.NativeClassPtr, "forwardPlus");
			NativeMethodInfoPtr_Create_Internal_Static_InitParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitParams>.NativeClassPtr, 100666292);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1110062, XrefRangeEnd = 1110078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static InitParams Create()
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Create_Internal_Static_InitParams_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new InitParams(pointer);
		}

		public InitParams(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public InitParams()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InitParams>.NativeClassPtr))
		{
		}
	}

	public class SetupLightPassData : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_renderingData;

		private static readonly System.IntPtr NativeFieldInfoPtr_cameraData;

		private static readonly System.IntPtr NativeFieldInfoPtr_lightData;

		private static readonly System.IntPtr NativeFieldInfoPtr_forwardLights;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe UniversalRenderingData renderingData
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_renderingData);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<UniversalRenderingData>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_renderingData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe UniversalCameraData cameraData
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cameraData);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<UniversalCameraData>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cameraData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe UniversalLightData lightData
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lightData);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<UniversalLightData>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lightData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe ForwardLights forwardLights
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forwardLights);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ForwardLights>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forwardLights)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		static SetupLightPassData()
		{
			Il2CppClassPointerStore<SetupLightPassData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ForwardLights>.NativeClassPtr, "SetupLightPassData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetupLightPassData>.NativeClassPtr);
			NativeFieldInfoPtr_renderingData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupLightPassData>.NativeClassPtr, "renderingData");
			NativeFieldInfoPtr_cameraData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupLightPassData>.NativeClassPtr, "cameraData");
			NativeFieldInfoPtr_lightData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupLightPassData>.NativeClassPtr, "lightData");
			NativeFieldInfoPtr_forwardLights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupLightPassData>.NativeClassPtr, "forwardLights");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupLightPassData>.NativeClassPtr, 100666293);
		}

		[CallerCount(1950)]
		[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SetupLightPassData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetupLightPassData>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public SetupLightPassData(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	[ObfuscatedName("UnityEngine.Rendering.Universal.Internal.ForwardLights+<>c")]
	public sealed class __c : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___9;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__44_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__SetupRenderGraphLights_b__44_0_Internal_Void_SetupLightPassData_UnsafeGraphContext_0;

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

		public unsafe static BaseRenderFunc<SetupLightPassData, UnsafeGraphContext> __9__44_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__44_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<BaseRenderFunc<SetupLightPassData, UnsafeGraphContext>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__44_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		static __c()
		{
			Il2CppClassPointerStore<__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ForwardLights>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c>.NativeClassPtr);
			NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9");
			NativeFieldInfoPtr___9__44_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__44_0");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100666295);
			NativeMethodInfoPtr__SetupRenderGraphLights_b__44_0_Internal_Void_SetupLightPassData_UnsafeGraphContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100666296);
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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1110078, XrefRangeEnd = 1110079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _SetupRenderGraphLights_b__44_0(SetupLightPassData data, UnsafeGraphContext rgContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rgContext);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__SetupRenderGraphLights_b__44_0_Internal_Void_SetupLightPassData_UnsafeGraphContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public __c(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_m_AdditionalLightsBufferId;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_AdditionalLightsIndicesId;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_SetupLightConstants;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ProfilingSampler;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ProfilingSamplerFPSetup;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ProfilingSamplerFPComplete;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ProfilingSamplerFPUpload;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_MixedLightingSetup;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_AdditionalLightPositions;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_AdditionalLightColors;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_AdditionalLightAttenuations;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_AdditionalLightSpotDirections;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_AdditionalLightOcclusionProbeChannels;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_AdditionalLightsLayerMasks;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_UseStructuredBuffer;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_UseForwardPlus;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_DirectionalLightCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ActualTileWidth;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_TileResolution;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CullingHandle;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ZBins;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ZBinsBuffer;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_TileMasks;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_TileMasksBuffer;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_LightCookieManager;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ReflectionProbeManager;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_WordsPerTile;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ZBinScale;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ZBinOffset;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_LightCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_BinCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_SetupForwardLights;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_InitParams_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateForwardPlusBuffers_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_reflectionProbeManager_Internal_get_ReflectionProbeManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AlignByteCount_Private_Static_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetViewParams_Private_Void_Camera_float4x4_byref_Single_byref_Single_byref_float4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PreSetup_Internal_Void_UniversalRenderingData_UniversalCameraData_UniversalLightData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Setup_Public_Void_ScriptableRenderContext_byref_RenderingData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupRenderGraphLights_Internal_Void_RenderGraph_UniversalRenderingData_UniversalCameraData_UniversalLightData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupLights_Internal_Void_UnsafeCommandBuffer_UniversalRenderingData_UniversalCameraData_UniversalLightData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Cleanup_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitializeLightConstants_Private_Void_NativeArray_1_VisibleLight_Int32_Boolean_byref_Vector4_byref_Vector4_byref_Vector4_byref_Vector4_byref_Vector4_byref_UInt32_byref_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupShaderLightConstants_Private_Void_UnsafeCommandBuffer_byref_CullingResults_UniversalLightData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupMainLightConstants_Private_Void_UnsafeCommandBuffer_UniversalLightData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupAdditionalLightConstants_Private_Void_UnsafeCommandBuffer_byref_CullingResults_UniversalLightData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupPerObjectLightIndices_Private_Int32_CullingResults_UniversalLightData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Static_Boolean_VisibleReflectionProbe_VisibleReflectionProbe_0;

	public unsafe int m_AdditionalLightsBufferId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AdditionalLightsBufferId);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AdditionalLightsBufferId)) = value;
		}
	}

	public unsafe int m_AdditionalLightsIndicesId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AdditionalLightsIndicesId);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AdditionalLightsIndicesId)) = value;
		}
	}

	public unsafe static string k_SetupLightConstants
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_SetupLightConstants, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_SetupLightConstants, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static ProfilingSampler m_ProfilingSampler
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_ProfilingSampler, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_ProfilingSampler, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static ProfilingSampler m_ProfilingSamplerFPSetup
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_ProfilingSamplerFPSetup, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_ProfilingSamplerFPSetup, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static ProfilingSampler m_ProfilingSamplerFPComplete
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_ProfilingSamplerFPComplete, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_ProfilingSamplerFPComplete, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static ProfilingSampler m_ProfilingSamplerFPUpload
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_ProfilingSamplerFPUpload, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_ProfilingSamplerFPUpload, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe MixedLightingSetup m_MixedLightingSetup
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MixedLightingSetup);
			return *(MixedLightingSetup*)num;
		}
		set
		{
			*(MixedLightingSetup*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MixedLightingSetup)) = value;
		}
	}

	public unsafe Il2CppStructArray<Vector4> m_AdditionalLightPositions
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AdditionalLightPositions);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector4>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AdditionalLightPositions)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppStructArray<Vector4> m_AdditionalLightColors
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AdditionalLightColors);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector4>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AdditionalLightColors)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppStructArray<Vector4> m_AdditionalLightAttenuations
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AdditionalLightAttenuations);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector4>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AdditionalLightAttenuations)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppStructArray<Vector4> m_AdditionalLightSpotDirections
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AdditionalLightSpotDirections);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector4>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AdditionalLightSpotDirections)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppStructArray<Vector4> m_AdditionalLightOcclusionProbeChannels
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AdditionalLightOcclusionProbeChannels);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector4>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AdditionalLightOcclusionProbeChannels)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppStructArray<float> m_AdditionalLightsLayerMasks
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AdditionalLightsLayerMasks);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AdditionalLightsLayerMasks)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe bool m_UseStructuredBuffer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_UseStructuredBuffer);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_UseStructuredBuffer)) = value;
		}
	}

	public unsafe bool m_UseForwardPlus
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_UseForwardPlus);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_UseForwardPlus)) = value;
		}
	}

	public unsafe int m_DirectionalLightCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DirectionalLightCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DirectionalLightCount)) = value;
		}
	}

	public unsafe int m_ActualTileWidth
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ActualTileWidth);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ActualTileWidth)) = value;
		}
	}

	public unsafe int2 m_TileResolution
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TileResolution);
			return *(int2*)num;
		}
		set
		{
			*(int2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TileResolution)) = value;
		}
	}

	public unsafe JobHandle m_CullingHandle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CullingHandle);
			return *(JobHandle*)num;
		}
		set
		{
			*(JobHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CullingHandle)) = value;
		}
	}

	public unsafe NativeArray<uint> m_ZBins
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ZBins);
			return new NativeArray<uint>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<uint>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ZBins), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<uint>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe GraphicsBuffer m_ZBinsBuffer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ZBinsBuffer);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GraphicsBuffer>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ZBinsBuffer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe NativeArray<uint> m_TileMasks
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TileMasks);
			return new NativeArray<uint>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<uint>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TileMasks), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<uint>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe GraphicsBuffer m_TileMasksBuffer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TileMasksBuffer);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GraphicsBuffer>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TileMasksBuffer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe LightCookieManager m_LightCookieManager
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LightCookieManager);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<LightCookieManager>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LightCookieManager)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe ReflectionProbeManager m_ReflectionProbeManager
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ReflectionProbeManager);
			return new ReflectionProbeManager(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ReflectionProbeManager>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ReflectionProbeManager), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ReflectionProbeManager>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe int m_WordsPerTile
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_WordsPerTile);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_WordsPerTile)) = value;
		}
	}

	public unsafe float m_ZBinScale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ZBinScale);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ZBinScale)) = value;
		}
	}

	public unsafe float m_ZBinOffset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ZBinOffset);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ZBinOffset)) = value;
		}
	}

	public unsafe int m_LightCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LightCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LightCount)) = value;
		}
	}

	public unsafe int m_BinCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BinCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BinCount)) = value;
		}
	}

	public unsafe static ProfilingSampler s_SetupForwardLights
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_SetupForwardLights, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_SetupForwardLights, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe ReflectionProbeManager reflectionProbeManager
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_reflectionProbeManager_Internal_get_ReflectionProbeManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new ReflectionProbeManager(pointer);
		}
	}

	static ForwardLights()
	{
		Il2CppClassPointerStore<ForwardLights>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal.Internal", "ForwardLights");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ForwardLights>.NativeClassPtr);
		NativeFieldInfoPtr_m_AdditionalLightsBufferId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForwardLights>.NativeClassPtr, "m_AdditionalLightsBufferId");
		NativeFieldInfoPtr_m_AdditionalLightsIndicesId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForwardLights>.NativeClassPtr, "m_AdditionalLightsIndicesId");
		NativeFieldInfoPtr_k_SetupLightConstants = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForwardLights>.NativeClassPtr, "k_SetupLightConstants");
		NativeFieldInfoPtr_m_ProfilingSampler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForwardLights>.NativeClassPtr, "m_ProfilingSampler");
		NativeFieldInfoPtr_m_ProfilingSamplerFPSetup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForwardLights>.NativeClassPtr, "m_ProfilingSamplerFPSetup");
		NativeFieldInfoPtr_m_ProfilingSamplerFPComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForwardLights>.NativeClassPtr, "m_ProfilingSamplerFPComplete");
		NativeFieldInfoPtr_m_ProfilingSamplerFPUpload = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForwardLights>.NativeClassPtr, "m_ProfilingSamplerFPUpload");
		NativeFieldInfoPtr_m_MixedLightingSetup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForwardLights>.NativeClassPtr, "m_MixedLightingSetup");
		NativeFieldInfoPtr_m_AdditionalLightPositions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForwardLights>.NativeClassPtr, "m_AdditionalLightPositions");
		NativeFieldInfoPtr_m_AdditionalLightColors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForwardLights>.NativeClassPtr, "m_AdditionalLightColors");
		NativeFieldInfoPtr_m_AdditionalLightAttenuations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForwardLights>.NativeClassPtr, "m_AdditionalLightAttenuations");
		NativeFieldInfoPtr_m_AdditionalLightSpotDirections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForwardLights>.NativeClassPtr, "m_AdditionalLightSpotDirections");
		NativeFieldInfoPtr_m_AdditionalLightOcclusionProbeChannels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForwardLights>.NativeClassPtr, "m_AdditionalLightOcclusionProbeChannels");
		NativeFieldInfoPtr_m_AdditionalLightsLayerMasks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForwardLights>.NativeClassPtr, "m_AdditionalLightsLayerMasks");
		NativeFieldInfoPtr_m_UseStructuredBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForwardLights>.NativeClassPtr, "m_UseStructuredBuffer");
		NativeFieldInfoPtr_m_UseForwardPlus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForwardLights>.NativeClassPtr, "m_UseForwardPlus");
		NativeFieldInfoPtr_m_DirectionalLightCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForwardLights>.NativeClassPtr, "m_DirectionalLightCount");
		NativeFieldInfoPtr_m_ActualTileWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForwardLights>.NativeClassPtr, "m_ActualTileWidth");
		NativeFieldInfoPtr_m_TileResolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForwardLights>.NativeClassPtr, "m_TileResolution");
		NativeFieldInfoPtr_m_CullingHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForwardLights>.NativeClassPtr, "m_CullingHandle");
		NativeFieldInfoPtr_m_ZBins = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForwardLights>.NativeClassPtr, "m_ZBins");
		NativeFieldInfoPtr_m_ZBinsBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForwardLights>.NativeClassPtr, "m_ZBinsBuffer");
		NativeFieldInfoPtr_m_TileMasks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForwardLights>.NativeClassPtr, "m_TileMasks");
		NativeFieldInfoPtr_m_TileMasksBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForwardLights>.NativeClassPtr, "m_TileMasksBuffer");
		NativeFieldInfoPtr_m_LightCookieManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForwardLights>.NativeClassPtr, "m_LightCookieManager");
		NativeFieldInfoPtr_m_ReflectionProbeManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForwardLights>.NativeClassPtr, "m_ReflectionProbeManager");
		NativeFieldInfoPtr_m_WordsPerTile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForwardLights>.NativeClassPtr, "m_WordsPerTile");
		NativeFieldInfoPtr_m_ZBinScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForwardLights>.NativeClassPtr, "m_ZBinScale");
		NativeFieldInfoPtr_m_ZBinOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForwardLights>.NativeClassPtr, "m_ZBinOffset");
		NativeFieldInfoPtr_m_LightCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForwardLights>.NativeClassPtr, "m_LightCount");
		NativeFieldInfoPtr_m_BinCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForwardLights>.NativeClassPtr, "m_BinCount");
		NativeFieldInfoPtr_s_SetupForwardLights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForwardLights>.NativeClassPtr, "s_SetupForwardLights");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForwardLights>.NativeClassPtr, 100666274);
		NativeMethodInfoPtr__ctor_Internal_Void_InitParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForwardLights>.NativeClassPtr, 100666275);
		NativeMethodInfoPtr_CreateForwardPlusBuffers_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForwardLights>.NativeClassPtr, 100666276);
		NativeMethodInfoPtr_get_reflectionProbeManager_Internal_get_ReflectionProbeManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForwardLights>.NativeClassPtr, 100666277);
		NativeMethodInfoPtr_AlignByteCount_Private_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForwardLights>.NativeClassPtr, 100666278);
		NativeMethodInfoPtr_GetViewParams_Private_Void_Camera_float4x4_byref_Single_byref_Single_byref_float4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForwardLights>.NativeClassPtr, 100666279);
		NativeMethodInfoPtr_PreSetup_Internal_Void_UniversalRenderingData_UniversalCameraData_UniversalLightData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForwardLights>.NativeClassPtr, 100666280);
		NativeMethodInfoPtr_Setup_Public_Void_ScriptableRenderContext_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForwardLights>.NativeClassPtr, 100666281);
		NativeMethodInfoPtr_SetupRenderGraphLights_Internal_Void_RenderGraph_UniversalRenderingData_UniversalCameraData_UniversalLightData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForwardLights>.NativeClassPtr, 100666282);
		NativeMethodInfoPtr_SetupLights_Internal_Void_UnsafeCommandBuffer_UniversalRenderingData_UniversalCameraData_UniversalLightData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForwardLights>.NativeClassPtr, 100666283);
		NativeMethodInfoPtr_Cleanup_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForwardLights>.NativeClassPtr, 100666284);
		NativeMethodInfoPtr_InitializeLightConstants_Private_Void_NativeArray_1_VisibleLight_Int32_Boolean_byref_Vector4_byref_Vector4_byref_Vector4_byref_Vector4_byref_Vector4_byref_UInt32_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForwardLights>.NativeClassPtr, 100666285);
		NativeMethodInfoPtr_SetupShaderLightConstants_Private_Void_UnsafeCommandBuffer_byref_CullingResults_UniversalLightData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForwardLights>.NativeClassPtr, 100666286);
		NativeMethodInfoPtr_SetupMainLightConstants_Private_Void_UnsafeCommandBuffer_UniversalLightData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForwardLights>.NativeClassPtr, 100666287);
		NativeMethodInfoPtr_SetupAdditionalLightConstants_Private_Void_UnsafeCommandBuffer_byref_CullingResults_UniversalLightData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForwardLights>.NativeClassPtr, 100666288);
		NativeMethodInfoPtr_SetupPerObjectLightIndices_Private_Int32_CullingResults_UniversalLightData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForwardLights>.NativeClassPtr, 100666289);
		NativeMethodInfoPtr_Method_Internal_Static_Boolean_VisibleReflectionProbe_VisibleReflectionProbe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForwardLights>.NativeClassPtr, 100666291);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1110079, XrefRangeEnd = 1110096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ForwardLights()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ForwardLights>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1110181, RefRangeEnd = 1110183, XrefRangeStart = 1110096, XrefRangeEnd = 1110181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ForwardLights(InitParams initParams)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ForwardLights>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)initParams));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_InitParams_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1110211, RefRangeEnd = 1110213, XrefRangeStart = 1110183, XrefRangeEnd = 1110211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CreateForwardPlusBuffers()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateForwardPlusBuffers_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe static int AlignByteCount(int count, int align)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&count);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &align;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AlignByteCount_Private_Static_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1110227, RefRangeEnd = 1110229, XrefRangeStart = 1110213, XrefRangeEnd = 1110227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetViewParams(Camera camera, float4x4 viewToClip, out float viewPlaneBot, out float viewPlaneTop, out float4 viewToViewportScaleBias)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
		*(float4x4**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &viewToClip;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref viewPlaneBot);
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref viewPlaneTop);
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref viewToViewportScaleBias);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetViewParams_Private_Void_Camera_float4x4_byref_Single_byref_Single_byref_float4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1110382, RefRangeEnd = 1110384, XrefRangeStart = 1110229, XrefRangeEnd = 1110382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PreSetup(UniversalRenderingData renderingData, UniversalCameraData cameraData, UniversalLightData lightData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderingData);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cameraData);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)lightData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PreSetup_Internal_Void_UniversalRenderingData_UniversalCameraData_UniversalLightData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1110384, XrefRangeEnd = 1110404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Setup(ScriptableRenderContext context, ref RenderingData renderingData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&context);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)renderingData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Setup_Public_Void_ScriptableRenderContext_byref_RenderingData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1110446, RefRangeEnd = 1110448, XrefRangeStart = 1110404, XrefRangeEnd = 1110446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetupRenderGraphLights(RenderGraph renderGraph, UniversalRenderingData renderingData, UniversalCameraData cameraData, UniversalLightData lightData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderGraph);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderingData);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cameraData);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)lightData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupRenderGraphLights_Internal_Void_RenderGraph_UniversalRenderingData_UniversalCameraData_UniversalLightData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1110596, RefRangeEnd = 1110599, XrefRangeStart = 1110448, XrefRangeEnd = 1110596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetupLights(UnsafeCommandBuffer cmd, UniversalRenderingData renderingData, UniversalCameraData cameraData, UniversalLightData lightData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderingData);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cameraData);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)lightData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupLights_Internal_Void_UnsafeCommandBuffer_UniversalRenderingData_UniversalCameraData_UniversalLightData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1110613, RefRangeEnd = 1110614, XrefRangeStart = 1110599, XrefRangeEnd = 1110613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Cleanup()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Cleanup_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1110614, XrefRangeEnd = 1110632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InitializeLightConstants(NativeArray<VisibleLight> lights, int lightIndex, bool supportsLightLayers, out Vector4 lightPos, out Vector4 lightColor, out Vector4 lightAttenuation, out Vector4 lightSpotDir, out Vector4 lightOcclusionProbeChannel, out uint lightLayerMask, out bool isSubtractive)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[10];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)lights));
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &lightIndex;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &supportsLightLayers;
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref lightPos);
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref lightColor);
		*(void**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref lightAttenuation);
		*(void**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref lightSpotDir);
		*(void**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref lightOcclusionProbeChannel);
		*(void**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref lightLayerMask);
		*(void**)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref isSubtractive);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitializeLightConstants_Private_Void_NativeArray_1_VisibleLight_Int32_Boolean_byref_Vector4_byref_Vector4_byref_Vector4_byref_Vector4_byref_Vector4_byref_UInt32_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1110632, XrefRangeEnd = 1110634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetupShaderLightConstants(UnsafeCommandBuffer cmd, ref CullingResults cullResults, UniversalLightData lightData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref cullResults);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)lightData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupShaderLightConstants_Private_Void_UnsafeCommandBuffer_byref_CullingResults_UniversalLightData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1110663, RefRangeEnd = 1110665, XrefRangeStart = 1110634, XrefRangeEnd = 1110663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetupMainLightConstants(UnsafeCommandBuffer cmd, UniversalLightData lightData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)lightData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupMainLightConstants_Private_Void_UnsafeCommandBuffer_UniversalLightData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1110678, RefRangeEnd = 1110680, XrefRangeStart = 1110665, XrefRangeEnd = 1110678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetupAdditionalLightConstants(UnsafeCommandBuffer cmd, ref CullingResults cullResults, UniversalLightData lightData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref cullResults);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)lightData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupAdditionalLightConstants_Private_Void_UnsafeCommandBuffer_byref_CullingResults_UniversalLightData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1110698, RefRangeEnd = 1110699, XrefRangeStart = 1110680, XrefRangeEnd = 1110698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int SetupPerObjectLightIndices(CullingResults cullResults, UniversalLightData lightData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&cullResults);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)lightData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupPerObjectLightIndices_Private_Int32_CullingResults_UniversalLightData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1110701, RefRangeEnd = 1110702, XrefRangeStart = 1110699, XrefRangeEnd = 1110701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool Method_Internal_Static_Boolean_VisibleReflectionProbe_VisibleReflectionProbe_0(VisibleReflectionProbe probe, VisibleReflectionProbe otherProbe)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&probe);
		*(VisibleReflectionProbe**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &otherProbe;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Method_Internal_Static_Boolean_VisibleReflectionProbe_VisibleReflectionProbe_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public ForwardLights(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
