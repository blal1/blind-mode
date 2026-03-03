using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering.Universal.Internal;

public class AdditionalLightsShadowCasterPass : ScriptableRenderPass
{
	public static class AdditionalShadowsConstantBuffer : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr__AdditionalLightsWorldToShadow;

		private static readonly System.IntPtr NativeFieldInfoPtr__AdditionalShadowParams;

		private static readonly System.IntPtr NativeFieldInfoPtr__AdditionalShadowOffset0;

		private static readonly System.IntPtr NativeFieldInfoPtr__AdditionalShadowOffset1;

		private static readonly System.IntPtr NativeFieldInfoPtr__AdditionalShadowFadeParams;

		private static readonly System.IntPtr NativeFieldInfoPtr__AdditionalShadowmapSize;

		private static readonly System.IntPtr NativeFieldInfoPtr__AdditionalLightsShadowmapID;

		private static readonly System.IntPtr NativeFieldInfoPtr__AdditionalLightsWorldToShadow_SSBO;

		private static readonly System.IntPtr NativeFieldInfoPtr__AdditionalShadowParams_SSBO;

		public unsafe static int _AdditionalLightsWorldToShadow
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__AdditionalLightsWorldToShadow, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__AdditionalLightsWorldToShadow, (void*)(&value));
			}
		}

		public unsafe static int _AdditionalShadowParams
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__AdditionalShadowParams, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__AdditionalShadowParams, (void*)(&value));
			}
		}

		public unsafe static int _AdditionalShadowOffset0
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__AdditionalShadowOffset0, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__AdditionalShadowOffset0, (void*)(&value));
			}
		}

		public unsafe static int _AdditionalShadowOffset1
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__AdditionalShadowOffset1, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__AdditionalShadowOffset1, (void*)(&value));
			}
		}

		public unsafe static int _AdditionalShadowFadeParams
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__AdditionalShadowFadeParams, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__AdditionalShadowFadeParams, (void*)(&value));
			}
		}

		public unsafe static int _AdditionalShadowmapSize
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__AdditionalShadowmapSize, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__AdditionalShadowmapSize, (void*)(&value));
			}
		}

		public unsafe static int _AdditionalLightsShadowmapID
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__AdditionalLightsShadowmapID, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__AdditionalLightsShadowmapID, (void*)(&value));
			}
		}

		public unsafe static int _AdditionalLightsWorldToShadow_SSBO
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__AdditionalLightsWorldToShadow_SSBO, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__AdditionalLightsWorldToShadow_SSBO, (void*)(&value));
			}
		}

		public unsafe static int _AdditionalShadowParams_SSBO
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__AdditionalShadowParams_SSBO, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__AdditionalShadowParams_SSBO, (void*)(&value));
			}
		}

		static AdditionalShadowsConstantBuffer()
		{
			Il2CppClassPointerStore<AdditionalShadowsConstantBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass>.NativeClassPtr, "AdditionalShadowsConstantBuffer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AdditionalShadowsConstantBuffer>.NativeClassPtr);
			NativeFieldInfoPtr__AdditionalLightsWorldToShadow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalShadowsConstantBuffer>.NativeClassPtr, "_AdditionalLightsWorldToShadow");
			NativeFieldInfoPtr__AdditionalShadowParams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalShadowsConstantBuffer>.NativeClassPtr, "_AdditionalShadowParams");
			NativeFieldInfoPtr__AdditionalShadowOffset0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalShadowsConstantBuffer>.NativeClassPtr, "_AdditionalShadowOffset0");
			NativeFieldInfoPtr__AdditionalShadowOffset1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalShadowsConstantBuffer>.NativeClassPtr, "_AdditionalShadowOffset1");
			NativeFieldInfoPtr__AdditionalShadowFadeParams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalShadowsConstantBuffer>.NativeClassPtr, "_AdditionalShadowFadeParams");
			NativeFieldInfoPtr__AdditionalShadowmapSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalShadowsConstantBuffer>.NativeClassPtr, "_AdditionalShadowmapSize");
			NativeFieldInfoPtr__AdditionalLightsShadowmapID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalShadowsConstantBuffer>.NativeClassPtr, "_AdditionalLightsShadowmapID");
			NativeFieldInfoPtr__AdditionalLightsWorldToShadow_SSBO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalShadowsConstantBuffer>.NativeClassPtr, "_AdditionalLightsWorldToShadow_SSBO");
			NativeFieldInfoPtr__AdditionalShadowParams_SSBO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalShadowsConstantBuffer>.NativeClassPtr, "_AdditionalShadowParams_SSBO");
		}

		public AdditionalShadowsConstantBuffer(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class PassData : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_shadowmapID;

		private static readonly System.IntPtr NativeFieldInfoPtr_emptyShadowmap;

		private static readonly System.IntPtr NativeFieldInfoPtr_setKeywordForEmptyShadowmap;

		private static readonly System.IntPtr NativeFieldInfoPtr_useStructuredBuffer;

		private static readonly System.IntPtr NativeFieldInfoPtr_stripShadowsOffVariants;

		private static readonly System.IntPtr NativeFieldInfoPtr_viewMatrix;

		private static readonly System.IntPtr NativeFieldInfoPtr_allocatedShadowAtlasSize;

		private static readonly System.IntPtr NativeFieldInfoPtr_shadowmapTexture;

		private static readonly System.IntPtr NativeFieldInfoPtr_lightData;

		private static readonly System.IntPtr NativeFieldInfoPtr_shadowData;

		private static readonly System.IntPtr NativeFieldInfoPtr_pass;

		private static readonly System.IntPtr NativeFieldInfoPtr_shadowRendererLists;

		private static readonly System.IntPtr NativeFieldInfoPtr_shadowRendererListsHdl;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe int shadowmapID
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shadowmapID);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shadowmapID)) = value;
			}
		}

		public unsafe bool emptyShadowmap
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_emptyShadowmap);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_emptyShadowmap)) = value;
			}
		}

		public unsafe bool setKeywordForEmptyShadowmap
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_setKeywordForEmptyShadowmap);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_setKeywordForEmptyShadowmap)) = value;
			}
		}

		public unsafe bool useStructuredBuffer
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useStructuredBuffer);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useStructuredBuffer)) = value;
			}
		}

		public unsafe bool stripShadowsOffVariants
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stripShadowsOffVariants);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stripShadowsOffVariants)) = value;
			}
		}

		public unsafe Matrix4x4 viewMatrix
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_viewMatrix);
				return *(Matrix4x4*)num;
			}
			set
			{
				*(Matrix4x4*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_viewMatrix)) = value;
			}
		}

		public unsafe Vector2Int allocatedShadowAtlasSize
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allocatedShadowAtlasSize);
				return *(Vector2Int*)num;
			}
			set
			{
				*(Vector2Int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allocatedShadowAtlasSize)) = value;
			}
		}

		public unsafe TextureHandle shadowmapTexture
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shadowmapTexture);
				return *(TextureHandle*)num;
			}
			set
			{
				*(TextureHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shadowmapTexture)) = value;
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

		public unsafe UniversalShadowData shadowData
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shadowData);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<UniversalShadowData>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shadowData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe AdditionalLightsShadowCasterPass pass
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pass);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AdditionalLightsShadowCasterPass>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pass)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe Il2CppStructArray<RendererList> shadowRendererLists
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shadowRendererLists);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<RendererList>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shadowRendererLists)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe Il2CppStructArray<RendererListHandle> shadowRendererListsHdl
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shadowRendererListsHdl);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<RendererListHandle>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shadowRendererListsHdl)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		static PassData()
		{
			Il2CppClassPointerStore<PassData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass>.NativeClassPtr, "PassData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PassData>.NativeClassPtr);
			NativeFieldInfoPtr_shadowmapID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PassData>.NativeClassPtr, "shadowmapID");
			NativeFieldInfoPtr_emptyShadowmap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PassData>.NativeClassPtr, "emptyShadowmap");
			NativeFieldInfoPtr_setKeywordForEmptyShadowmap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PassData>.NativeClassPtr, "setKeywordForEmptyShadowmap");
			NativeFieldInfoPtr_useStructuredBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PassData>.NativeClassPtr, "useStructuredBuffer");
			NativeFieldInfoPtr_stripShadowsOffVariants = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PassData>.NativeClassPtr, "stripShadowsOffVariants");
			NativeFieldInfoPtr_viewMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PassData>.NativeClassPtr, "viewMatrix");
			NativeFieldInfoPtr_allocatedShadowAtlasSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PassData>.NativeClassPtr, "allocatedShadowAtlasSize");
			NativeFieldInfoPtr_shadowmapTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PassData>.NativeClassPtr, "shadowmapTexture");
			NativeFieldInfoPtr_lightData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PassData>.NativeClassPtr, "lightData");
			NativeFieldInfoPtr_shadowData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PassData>.NativeClassPtr, "shadowData");
			NativeFieldInfoPtr_pass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PassData>.NativeClassPtr, "pass");
			NativeFieldInfoPtr_shadowRendererLists = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PassData>.NativeClassPtr, "shadowRendererLists");
			NativeFieldInfoPtr_shadowRendererListsHdl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PassData>.NativeClassPtr, "shadowRendererListsHdl");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PassData>.NativeClassPtr, 100666270);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1109300, XrefRangeEnd = 1109309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PassData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PassData>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public PassData(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	[ObfuscatedName("UnityEngine.Rendering.Universal.Internal.AdditionalLightsShadowCasterPass+<>c")]
	public sealed class __c : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___9;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__64_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__Render_b__64_0_Internal_Void_PassData_RasterGraphContext_0;

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

		public unsafe static BaseRenderFunc<PassData, RasterGraphContext> __9__64_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__64_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<BaseRenderFunc<PassData, RasterGraphContext>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__64_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		static __c()
		{
			Il2CppClassPointerStore<__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c>.NativeClassPtr);
			NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9");
			NativeFieldInfoPtr___9__64_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__64_0");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100666272);
			NativeMethodInfoPtr__Render_b__64_0_Internal_Void_PassData_RasterGraphContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100666273);
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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1109309, XrefRangeEnd = 1109317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Render_b__64_0(PassData data, RasterGraphContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)context));
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Render_b__64_0_Internal_Void_PassData_RasterGraphContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public __c(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_m_AdditionalShadowsBufferId;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_AdditionalShadowsIndicesId;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_AdditionalLightsShadowmapHandle;

	private static readonly System.IntPtr NativeFieldInfoPtr_renderTargetWidth;

	private static readonly System.IntPtr NativeFieldInfoPtr_renderTargetHeight;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CreateEmptyShadowmap;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_SetKeywordForEmptyShadowmap;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_EmptyShadowmapNeedsClear;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_IssuedMessageAboutShadowSlicesTooMany;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_IssuedMessageAboutShadowMapsRescale;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_IssuedMessageAboutShadowMapsTooBig;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_IssuedMessageAboutRemovedShadowSlices;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_IssuedMessageAboutPointLightHardShadowResolutionTooSmall;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_IssuedMessageAboutPointLightSoftShadowResolutionTooSmall;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_UseStructuredBuffer;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_MaxShadowDistanceSq;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CascadeBorder;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_PassData;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_EmptyAdditionalLightShadowmapTexture;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_VisibleLightIndexToIsCastingShadows;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_VisibleLightIndexToAdditionalLightIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_AdditionalLightIndexToVisibleLightIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_AdditionalLightIndexToShadowParams;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_AdditionalLightShadowSliceIndexTo_WorldShadowMatrix;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_AdditionalLightsShadowSlices;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_GlobalShadowSliceIndexToPerLightShadowSliceIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ShadowSliceToAdditionalLightIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ShadowRequestsHashes;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ProfilingSetupSampler;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_AdditionalLightShadowDescriptor;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_ShadowmapBufferBits;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_EmptyShadowMapDimensions;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_LightTypeIdentifierInShadowParams_Spot;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_LightTypeIdentifierInShadowParams_Point;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_AdditionalLightShadowMapTextureName;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_EmptyAdditionalLightShadowMapTextureName;

	private static readonly System.IntPtr NativeFieldInfoPtr_c_DefaultShadowParams;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_EmptyAdditionalShadowFadeParams;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_EmptyAdditionalLightIndexToShadowParams;

	private static readonly System.IntPtr NativeFieldInfoPtr_isAdditionalShadowParamsDirty;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_RenderPassEvent_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalcGuardAngle_Internal_Static_Single_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPointLightShadowFrustumFovBiasInDegrees_Internal_Static_Single_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResolutionLog2ForHash_Private_UInt64_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ComputeShadowRequestHash_Private_UInt64_UniversalLightData_UniversalShadowData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLightTypeIdentifierForShadowParams_Private_Single_LightType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UsesBakedShadows_Private_Boolean_Light_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Setup_Public_Boolean_byref_RenderingData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Setup_Public_Boolean_UniversalRenderingData_UniversalCameraData_UniversalLightData_UniversalShadowData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateTextureDescriptorIfNeeded_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AnyAdditionalLightHasMixedShadows_Private_Boolean_UniversalLightData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupForEmptyRendering_Private_Boolean_Boolean_Boolean_UniversalLightData_UniversalShadowData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Configure_Public_Virtual_Void_CommandBuffer_RenderTextureDescriptor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetShadowLightIndexFromLightIndex_Public_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Clear_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetShadowParamsForEmptyShadowmap_Internal_Static_Void_RasterCommandBuffer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RenderAdditionalShadowmapAtlas_Private_Void_RasterCommandBuffer_byref_PassData_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupAdditionalLightsShadowReceiverConstants_Private_Void_RasterCommandBuffer_Vector2Int_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitPassData_Private_Void_byref_PassData_UniversalCameraData_UniversalLightData_UniversalShadowData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitRendererLists_Private_Void_byref_CullingResults_byref_PassData_ScriptableRenderContext_RenderGraph_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Render_Internal_TextureHandle_RenderGraph_ContextContainer_0;

	public unsafe static int m_AdditionalShadowsBufferId
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_AdditionalShadowsBufferId, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_AdditionalShadowsBufferId, (void*)(&value));
		}
	}

	public unsafe static int m_AdditionalShadowsIndicesId
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_AdditionalShadowsIndicesId, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_AdditionalShadowsIndicesId, (void*)(&value));
		}
	}

	public unsafe RTHandle m_AdditionalLightsShadowmapHandle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AdditionalLightsShadowmapHandle);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RTHandle>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AdditionalLightsShadowmapHandle)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe int renderTargetWidth
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_renderTargetWidth);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_renderTargetWidth)) = value;
		}
	}

	public unsafe int renderTargetHeight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_renderTargetHeight);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_renderTargetHeight)) = value;
		}
	}

	public unsafe bool m_CreateEmptyShadowmap
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CreateEmptyShadowmap);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CreateEmptyShadowmap)) = value;
		}
	}

	public unsafe bool m_SetKeywordForEmptyShadowmap
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SetKeywordForEmptyShadowmap);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SetKeywordForEmptyShadowmap)) = value;
		}
	}

	public unsafe bool m_EmptyShadowmapNeedsClear
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_EmptyShadowmapNeedsClear);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_EmptyShadowmapNeedsClear)) = value;
		}
	}

	public unsafe bool m_IssuedMessageAboutShadowSlicesTooMany
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_IssuedMessageAboutShadowSlicesTooMany);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_IssuedMessageAboutShadowSlicesTooMany)) = value;
		}
	}

	public unsafe bool m_IssuedMessageAboutShadowMapsRescale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_IssuedMessageAboutShadowMapsRescale);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_IssuedMessageAboutShadowMapsRescale)) = value;
		}
	}

	public unsafe bool m_IssuedMessageAboutShadowMapsTooBig
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_IssuedMessageAboutShadowMapsTooBig);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_IssuedMessageAboutShadowMapsTooBig)) = value;
		}
	}

	public unsafe bool m_IssuedMessageAboutRemovedShadowSlices
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_IssuedMessageAboutRemovedShadowSlices);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_IssuedMessageAboutRemovedShadowSlices)) = value;
		}
	}

	public unsafe static bool m_IssuedMessageAboutPointLightHardShadowResolutionTooSmall
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_IssuedMessageAboutPointLightHardShadowResolutionTooSmall, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_IssuedMessageAboutPointLightHardShadowResolutionTooSmall, (void*)(&value));
		}
	}

	public unsafe static bool m_IssuedMessageAboutPointLightSoftShadowResolutionTooSmall
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_IssuedMessageAboutPointLightSoftShadowResolutionTooSmall, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_IssuedMessageAboutPointLightSoftShadowResolutionTooSmall, (void*)(&value));
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

	public unsafe float m_MaxShadowDistanceSq
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MaxShadowDistanceSq);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MaxShadowDistanceSq)) = value;
		}
	}

	public unsafe float m_CascadeBorder
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CascadeBorder);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CascadeBorder)) = value;
		}
	}

	public unsafe PassData m_PassData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_PassData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PassData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_PassData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe RTHandle m_EmptyAdditionalLightShadowmapTexture
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_EmptyAdditionalLightShadowmapTexture);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RTHandle>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_EmptyAdditionalLightShadowmapTexture)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppStructArray<bool> m_VisibleLightIndexToIsCastingShadows
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_VisibleLightIndexToIsCastingShadows);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_VisibleLightIndexToIsCastingShadows)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppStructArray<short> m_VisibleLightIndexToAdditionalLightIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_VisibleLightIndexToAdditionalLightIndex);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<short>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_VisibleLightIndexToAdditionalLightIndex)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppStructArray<short> m_AdditionalLightIndexToVisibleLightIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AdditionalLightIndexToVisibleLightIndex);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<short>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AdditionalLightIndexToVisibleLightIndex)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppStructArray<Vector4> m_AdditionalLightIndexToShadowParams
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AdditionalLightIndexToShadowParams);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector4>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AdditionalLightIndexToShadowParams)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppStructArray<Matrix4x4> m_AdditionalLightShadowSliceIndexTo_WorldShadowMatrix
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AdditionalLightShadowSliceIndexTo_WorldShadowMatrix);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Matrix4x4>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AdditionalLightShadowSliceIndexTo_WorldShadowMatrix)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppStructArray<ShadowSliceData> m_AdditionalLightsShadowSlices
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AdditionalLightsShadowSlices);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<ShadowSliceData>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AdditionalLightsShadowSlices)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe List<byte> m_GlobalShadowSliceIndexToPerLightShadowSliceIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_GlobalShadowSliceIndexToPerLightShadowSliceIndex);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<byte>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_GlobalShadowSliceIndexToPerLightShadowSliceIndex)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe List<short> m_ShadowSliceToAdditionalLightIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ShadowSliceToAdditionalLightIndex);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<short>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ShadowSliceToAdditionalLightIndex)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Dictionary<int, ulong> m_ShadowRequestsHashes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ShadowRequestsHashes);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, ulong>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ShadowRequestsHashes)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe ProfilingSampler m_ProfilingSetupSampler
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ProfilingSetupSampler);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ProfilingSetupSampler)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe RenderTextureDescriptor m_AdditionalLightShadowDescriptor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AdditionalLightShadowDescriptor);
			return *(RenderTextureDescriptor*)num;
		}
		set
		{
			*(RenderTextureDescriptor*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AdditionalLightShadowDescriptor)) = value;
		}
	}

	public unsafe static int k_ShadowmapBufferBits
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_ShadowmapBufferBits, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_ShadowmapBufferBits, (void*)(&value));
		}
	}

	public unsafe static int k_EmptyShadowMapDimensions
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_EmptyShadowMapDimensions, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_EmptyShadowMapDimensions, (void*)(&value));
		}
	}

	public unsafe static float k_LightTypeIdentifierInShadowParams_Spot
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_LightTypeIdentifierInShadowParams_Spot, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_LightTypeIdentifierInShadowParams_Spot, (void*)(&value));
		}
	}

	public unsafe static float k_LightTypeIdentifierInShadowParams_Point
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_LightTypeIdentifierInShadowParams_Point, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_LightTypeIdentifierInShadowParams_Point, (void*)(&value));
		}
	}

	public unsafe static string k_AdditionalLightShadowMapTextureName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_AdditionalLightShadowMapTextureName, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_AdditionalLightShadowMapTextureName, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string k_EmptyAdditionalLightShadowMapTextureName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_EmptyAdditionalLightShadowMapTextureName, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_EmptyAdditionalLightShadowMapTextureName, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static Vector4 c_DefaultShadowParams
	{
		get
		{
			Unsafe.SkipInit(out Vector4 result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_c_DefaultShadowParams, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_c_DefaultShadowParams, (void*)(&value));
		}
	}

	public unsafe static Vector4 s_EmptyAdditionalShadowFadeParams
	{
		get
		{
			Unsafe.SkipInit(out Vector4 result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_EmptyAdditionalShadowFadeParams, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_EmptyAdditionalShadowFadeParams, (void*)(&value));
		}
	}

	public unsafe static Il2CppStructArray<Vector4> s_EmptyAdditionalLightIndexToShadowParams
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_EmptyAdditionalLightIndexToShadowParams, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector4>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_EmptyAdditionalLightIndexToShadowParams, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static bool isAdditionalShadowParamsDirty
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isAdditionalShadowParamsDirty, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isAdditionalShadowParamsDirty, (void*)(&value));
		}
	}

	static AdditionalLightsShadowCasterPass()
	{
		Il2CppClassPointerStore<AdditionalLightsShadowCasterPass>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal.Internal", "AdditionalLightsShadowCasterPass");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass>.NativeClassPtr);
		NativeFieldInfoPtr_m_AdditionalShadowsBufferId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass>.NativeClassPtr, "m_AdditionalShadowsBufferId");
		NativeFieldInfoPtr_m_AdditionalShadowsIndicesId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass>.NativeClassPtr, "m_AdditionalShadowsIndicesId");
		NativeFieldInfoPtr_m_AdditionalLightsShadowmapHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass>.NativeClassPtr, "m_AdditionalLightsShadowmapHandle");
		NativeFieldInfoPtr_renderTargetWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass>.NativeClassPtr, "renderTargetWidth");
		NativeFieldInfoPtr_renderTargetHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass>.NativeClassPtr, "renderTargetHeight");
		NativeFieldInfoPtr_m_CreateEmptyShadowmap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass>.NativeClassPtr, "m_CreateEmptyShadowmap");
		NativeFieldInfoPtr_m_SetKeywordForEmptyShadowmap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass>.NativeClassPtr, "m_SetKeywordForEmptyShadowmap");
		NativeFieldInfoPtr_m_EmptyShadowmapNeedsClear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass>.NativeClassPtr, "m_EmptyShadowmapNeedsClear");
		NativeFieldInfoPtr_m_IssuedMessageAboutShadowSlicesTooMany = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass>.NativeClassPtr, "m_IssuedMessageAboutShadowSlicesTooMany");
		NativeFieldInfoPtr_m_IssuedMessageAboutShadowMapsRescale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass>.NativeClassPtr, "m_IssuedMessageAboutShadowMapsRescale");
		NativeFieldInfoPtr_m_IssuedMessageAboutShadowMapsTooBig = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass>.NativeClassPtr, "m_IssuedMessageAboutShadowMapsTooBig");
		NativeFieldInfoPtr_m_IssuedMessageAboutRemovedShadowSlices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass>.NativeClassPtr, "m_IssuedMessageAboutRemovedShadowSlices");
		NativeFieldInfoPtr_m_IssuedMessageAboutPointLightHardShadowResolutionTooSmall = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass>.NativeClassPtr, "m_IssuedMessageAboutPointLightHardShadowResolutionTooSmall");
		NativeFieldInfoPtr_m_IssuedMessageAboutPointLightSoftShadowResolutionTooSmall = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass>.NativeClassPtr, "m_IssuedMessageAboutPointLightSoftShadowResolutionTooSmall");
		NativeFieldInfoPtr_m_UseStructuredBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass>.NativeClassPtr, "m_UseStructuredBuffer");
		NativeFieldInfoPtr_m_MaxShadowDistanceSq = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass>.NativeClassPtr, "m_MaxShadowDistanceSq");
		NativeFieldInfoPtr_m_CascadeBorder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass>.NativeClassPtr, "m_CascadeBorder");
		NativeFieldInfoPtr_m_PassData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass>.NativeClassPtr, "m_PassData");
		NativeFieldInfoPtr_m_EmptyAdditionalLightShadowmapTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass>.NativeClassPtr, "m_EmptyAdditionalLightShadowmapTexture");
		NativeFieldInfoPtr_m_VisibleLightIndexToIsCastingShadows = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass>.NativeClassPtr, "m_VisibleLightIndexToIsCastingShadows");
		NativeFieldInfoPtr_m_VisibleLightIndexToAdditionalLightIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass>.NativeClassPtr, "m_VisibleLightIndexToAdditionalLightIndex");
		NativeFieldInfoPtr_m_AdditionalLightIndexToVisibleLightIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass>.NativeClassPtr, "m_AdditionalLightIndexToVisibleLightIndex");
		NativeFieldInfoPtr_m_AdditionalLightIndexToShadowParams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass>.NativeClassPtr, "m_AdditionalLightIndexToShadowParams");
		NativeFieldInfoPtr_m_AdditionalLightShadowSliceIndexTo_WorldShadowMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass>.NativeClassPtr, "m_AdditionalLightShadowSliceIndexTo_WorldShadowMatrix");
		NativeFieldInfoPtr_m_AdditionalLightsShadowSlices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass>.NativeClassPtr, "m_AdditionalLightsShadowSlices");
		NativeFieldInfoPtr_m_GlobalShadowSliceIndexToPerLightShadowSliceIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass>.NativeClassPtr, "m_GlobalShadowSliceIndexToPerLightShadowSliceIndex");
		NativeFieldInfoPtr_m_ShadowSliceToAdditionalLightIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass>.NativeClassPtr, "m_ShadowSliceToAdditionalLightIndex");
		NativeFieldInfoPtr_m_ShadowRequestsHashes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass>.NativeClassPtr, "m_ShadowRequestsHashes");
		NativeFieldInfoPtr_m_ProfilingSetupSampler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass>.NativeClassPtr, "m_ProfilingSetupSampler");
		NativeFieldInfoPtr_m_AdditionalLightShadowDescriptor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass>.NativeClassPtr, "m_AdditionalLightShadowDescriptor");
		NativeFieldInfoPtr_k_ShadowmapBufferBits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass>.NativeClassPtr, "k_ShadowmapBufferBits");
		NativeFieldInfoPtr_k_EmptyShadowMapDimensions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass>.NativeClassPtr, "k_EmptyShadowMapDimensions");
		NativeFieldInfoPtr_k_LightTypeIdentifierInShadowParams_Spot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass>.NativeClassPtr, "k_LightTypeIdentifierInShadowParams_Spot");
		NativeFieldInfoPtr_k_LightTypeIdentifierInShadowParams_Point = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass>.NativeClassPtr, "k_LightTypeIdentifierInShadowParams_Point");
		NativeFieldInfoPtr_k_AdditionalLightShadowMapTextureName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass>.NativeClassPtr, "k_AdditionalLightShadowMapTextureName");
		NativeFieldInfoPtr_k_EmptyAdditionalLightShadowMapTextureName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass>.NativeClassPtr, "k_EmptyAdditionalLightShadowMapTextureName");
		NativeFieldInfoPtr_c_DefaultShadowParams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass>.NativeClassPtr, "c_DefaultShadowParams");
		NativeFieldInfoPtr_s_EmptyAdditionalShadowFadeParams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass>.NativeClassPtr, "s_EmptyAdditionalShadowFadeParams");
		NativeFieldInfoPtr_s_EmptyAdditionalLightIndexToShadowParams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass>.NativeClassPtr, "s_EmptyAdditionalLightIndexToShadowParams");
		NativeFieldInfoPtr_isAdditionalShadowParamsDirty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass>.NativeClassPtr, "isAdditionalShadowParamsDirty");
		NativeMethodInfoPtr__ctor_Public_Void_RenderPassEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass>.NativeClassPtr, 100666245);
		NativeMethodInfoPtr_Dispose_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass>.NativeClassPtr, 100666246);
		NativeMethodInfoPtr_CalcGuardAngle_Internal_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass>.NativeClassPtr, 100666247);
		NativeMethodInfoPtr_GetPointLightShadowFrustumFovBiasInDegrees_Internal_Static_Single_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass>.NativeClassPtr, 100666248);
		NativeMethodInfoPtr_ResolutionLog2ForHash_Private_UInt64_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass>.NativeClassPtr, 100666249);
		NativeMethodInfoPtr_ComputeShadowRequestHash_Private_UInt64_UniversalLightData_UniversalShadowData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass>.NativeClassPtr, 100666250);
		NativeMethodInfoPtr_GetLightTypeIdentifierForShadowParams_Private_Single_LightType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass>.NativeClassPtr, 100666251);
		NativeMethodInfoPtr_UsesBakedShadows_Private_Boolean_Light_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass>.NativeClassPtr, 100666252);
		NativeMethodInfoPtr_Setup_Public_Boolean_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass>.NativeClassPtr, 100666253);
		NativeMethodInfoPtr_Setup_Public_Boolean_UniversalRenderingData_UniversalCameraData_UniversalLightData_UniversalShadowData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass>.NativeClassPtr, 100666254);
		NativeMethodInfoPtr_UpdateTextureDescriptorIfNeeded_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass>.NativeClassPtr, 100666255);
		NativeMethodInfoPtr_AnyAdditionalLightHasMixedShadows_Private_Boolean_UniversalLightData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass>.NativeClassPtr, 100666256);
		NativeMethodInfoPtr_SetupForEmptyRendering_Private_Boolean_Boolean_Boolean_UniversalLightData_UniversalShadowData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass>.NativeClassPtr, 100666257);
		NativeMethodInfoPtr_Configure_Public_Virtual_Void_CommandBuffer_RenderTextureDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass>.NativeClassPtr, 100666258);
		NativeMethodInfoPtr_Execute_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass>.NativeClassPtr, 100666259);
		NativeMethodInfoPtr_GetShadowLightIndexFromLightIndex_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass>.NativeClassPtr, 100666260);
		NativeMethodInfoPtr_Clear_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass>.NativeClassPtr, 100666261);
		NativeMethodInfoPtr_SetShadowParamsForEmptyShadowmap_Internal_Static_Void_RasterCommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass>.NativeClassPtr, 100666262);
		NativeMethodInfoPtr_RenderAdditionalShadowmapAtlas_Private_Void_RasterCommandBuffer_byref_PassData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass>.NativeClassPtr, 100666263);
		NativeMethodInfoPtr_SetupAdditionalLightsShadowReceiverConstants_Private_Void_RasterCommandBuffer_Vector2Int_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass>.NativeClassPtr, 100666264);
		NativeMethodInfoPtr_InitPassData_Private_Void_byref_PassData_UniversalCameraData_UniversalLightData_UniversalShadowData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass>.NativeClassPtr, 100666265);
		NativeMethodInfoPtr_InitRendererLists_Private_Void_byref_CullingResults_byref_PassData_ScriptableRenderContext_RenderGraph_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass>.NativeClassPtr, 100666266);
		NativeMethodInfoPtr_Render_Internal_TextureHandle_RenderGraph_ContextContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass>.NativeClassPtr, 100666267);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1109414, RefRangeEnd = 1109415, XrefRangeStart = 1109317, XrefRangeEnd = 1109414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AdditionalLightsShadowCasterPass(RenderPassEvent evt)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AdditionalLightsShadowCasterPass>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&evt);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_RenderPassEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1109417, RefRangeEnd = 1109419, XrefRangeStart = 1109415, XrefRangeEnd = 1109417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Dispose()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dispose_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1109419, XrefRangeEnd = 1109421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float CalcGuardAngle(float frustumAngleInDegrees, float guardBandSizeInTexels, float sliceResolutionInTexels)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&frustumAngleInDegrees);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &guardBandSizeInTexels;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &sliceResolutionInTexels;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalcGuardAngle_Internal_Static_Single_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1109443, RefRangeEnd = 1109445, XrefRangeStart = 1109421, XrefRangeEnd = 1109443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float GetPointLightShadowFrustumFovBiasInDegrees(int shadowSliceResolution, bool shadowFiltering)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&shadowSliceResolution);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &shadowFiltering;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPointLightShadowFrustumFovBiasInDegrees_Internal_Static_Single_Int32_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe ulong ResolutionLog2ForHash(int resolution)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&resolution);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResolutionLog2ForHash_Private_UInt64_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(ulong*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1109445, XrefRangeEnd = 1109470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ulong ComputeShadowRequestHash(UniversalLightData lightData, UniversalShadowData shadowData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)lightData);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)shadowData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ComputeShadowRequestHash_Private_UInt64_UniversalLightData_UniversalShadowData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(ulong*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe float GetLightTypeIdentifierForShadowParams(LightType lightType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&lightType);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLightTypeIdentifierForShadowParams_Private_Single_LightType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1109470, XrefRangeEnd = 1109471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool UsesBakedShadows(Light light)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)light);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UsesBakedShadows_Private_Boolean_Light_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1109471, XrefRangeEnd = 1109484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Setup(ref RenderingData renderingData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)renderingData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Setup_Public_Boolean_byref_RenderingData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1109682, RefRangeEnd = 1109684, XrefRangeStart = 1109484, XrefRangeEnd = 1109682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Setup(UniversalRenderingData renderingData, UniversalCameraData cameraData, UniversalLightData lightData, UniversalShadowData shadowData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderingData);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cameraData);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)lightData);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)shadowData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Setup_Public_Boolean_UniversalRenderingData_UniversalCameraData_UniversalLightData_UniversalShadowData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1109684, XrefRangeEnd = 1109687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateTextureDescriptorIfNeeded()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateTextureDescriptorIfNeeded_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1109687, XrefRangeEnd = 1109693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool AnyAdditionalLightHasMixedShadows(UniversalLightData lightData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)lightData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AnyAdditionalLightHasMixedShadows_Private_Boolean_UniversalLightData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1109765, RefRangeEnd = 1109768, XrefRangeStart = 1109693, XrefRangeEnd = 1109765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool SetupForEmptyRendering(bool stripShadowsOffVariants, bool shadowsEnabled, UniversalLightData lightData, UniversalShadowData shadowData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&stripShadowsOffVariants);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &shadowsEnabled;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)lightData);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)shadowData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupForEmptyRendering_Private_Boolean_Boolean_Boolean_UniversalLightData_UniversalShadowData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1109768, XrefRangeEnd = 1109782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Configure(CommandBuffer cmd, RenderTextureDescriptor cameraTextureDescriptor)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(RenderTextureDescriptor**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &cameraTextureDescriptor;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Configure_Public_Virtual_Void_CommandBuffer_RenderTextureDescriptor_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1109782, XrefRangeEnd = 1109810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&context);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)renderingData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Execute_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1109810, RefRangeEnd = 1109813, XrefRangeStart = 1109810, XrefRangeEnd = 1109810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetShadowLightIndexFromLightIndex(int visibleLightIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&visibleLightIndex);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetShadowLightIndexFromLightIndex_Public_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1109813, XrefRangeEnd = 1109815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Clear()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Clear_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1109842, RefRangeEnd = 1109845, XrefRangeStart = 1109815, XrefRangeEnd = 1109842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetShadowParamsForEmptyShadowmap(RasterCommandBuffer rasterCommandBuffer)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rasterCommandBuffer);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetShadowParamsForEmptyShadowmap_Internal_Static_Void_RasterCommandBuffer_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1109908, RefRangeEnd = 1109910, XrefRangeStart = 1109845, XrefRangeEnd = 1109908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RenderAdditionalShadowmapAtlas(RasterCommandBuffer cmd, ref PassData data, bool useRenderGraph)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
		*(System.IntPtr**)num = &intPtr;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &useRenderGraph;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RenderAdditionalShadowmapAtlas_Private_Void_RasterCommandBuffer_byref_PassData_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		data = ((intPtr4 == (System.IntPtr)0) ? null : new PassData(intPtr4));
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1109948, RefRangeEnd = 1109949, XrefRangeStart = 1109910, XrefRangeEnd = 1109948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetupAdditionalLightsShadowReceiverConstants(RasterCommandBuffer cmd, Vector2Int allocatedShadowAtlasSize, bool useStructuredBuffer, bool softShadows)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(Vector2Int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &allocatedShadowAtlasSize;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &useStructuredBuffer;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &softShadows;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupAdditionalLightsShadowReceiverConstants_Private_Void_RasterCommandBuffer_Vector2Int_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1109953, RefRangeEnd = 1109954, XrefRangeStart = 1109949, XrefRangeEnd = 1109953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InitPassData(ref PassData passData, UniversalCameraData cameraData, UniversalLightData lightData, UniversalShadowData shadowData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)passData);
		*ptr = (nint)(&intPtr);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cameraData);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)lightData);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)shadowData);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitPassData_Private_Void_byref_PassData_UniversalCameraData_UniversalLightData_UniversalShadowData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		passData = ((intPtr4 == (System.IntPtr)0) ? null : new PassData(intPtr4));
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1109973, RefRangeEnd = 1109975, XrefRangeStart = 1109954, XrefRangeEnd = 1109973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InitRendererLists(ref CullingResults cullResults, ref PassData passData, ScriptableRenderContext context, RenderGraph renderGraph, bool useRenderGraph)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)Unsafe.AsPointer(ref cullResults);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)passData);
		*(System.IntPtr**)num = &intPtr;
		*(ScriptableRenderContext**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &context;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderGraph);
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &useRenderGraph;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitRendererLists_Private_Void_byref_CullingResults_byref_PassData_ScriptableRenderContext_RenderGraph_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		passData = ((intPtr4 == (System.IntPtr)0) ? null : new PassData(intPtr4));
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1110061, RefRangeEnd = 1110062, XrefRangeStart = 1109975, XrefRangeEnd = 1110061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TextureHandle Render(RenderGraph graph, ContextContainer frameData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)graph);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)frameData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Render_Internal_TextureHandle_RenderGraph_ContextContainer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(TextureHandle*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public AdditionalLightsShadowCasterPass(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
