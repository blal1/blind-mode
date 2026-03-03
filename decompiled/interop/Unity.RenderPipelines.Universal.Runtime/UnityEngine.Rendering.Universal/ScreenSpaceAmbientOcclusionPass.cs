using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering.Universal;

public class ScreenSpaceAmbientOcclusionPass : ScriptableRenderPass
{
	[OriginalName("Unity.RenderPipelines.Universal.Runtime.dll", "", "BlurTypes")]
	public enum BlurTypes
	{
		Bilateral,
		Gaussian,
		Kawase
	}

	[OriginalName("Unity.RenderPipelines.Universal.Runtime.dll", "", "ShaderPasses")]
	public enum ShaderPasses
	{
		AmbientOcclusion,
		BilateralBlurHorizontal,
		BilateralBlurVertical,
		BilateralBlurFinal,
		BilateralAfterOpaque,
		GaussianBlurHorizontal,
		GaussianBlurVertical,
		GaussianAfterOpaque,
		KawaseBlur,
		KawaseAfterOpaque
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct SSAOMaterialParams
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_orthographicCamera;

		private static readonly System.IntPtr NativeFieldInfoPtr_aoBlueNoise;

		private static readonly System.IntPtr NativeFieldInfoPtr_aoInterleavedGradient;

		private static readonly System.IntPtr NativeFieldInfoPtr_sampleCountHigh;

		private static readonly System.IntPtr NativeFieldInfoPtr_sampleCountMedium;

		private static readonly System.IntPtr NativeFieldInfoPtr_sampleCountLow;

		private static readonly System.IntPtr NativeFieldInfoPtr_sourceDepthNormals;

		private static readonly System.IntPtr NativeFieldInfoPtr_sourceDepthHigh;

		private static readonly System.IntPtr NativeFieldInfoPtr_sourceDepthMedium;

		private static readonly System.IntPtr NativeFieldInfoPtr_sourceDepthLow;

		private static readonly System.IntPtr NativeFieldInfoPtr_ssaoParams;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_byref_ScreenSpaceAmbientOcclusionSettings_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Internal_Boolean_byref_SSAOMaterialParams_0;

		[FieldOffset(0)]
		[MarshalAs(UnmanagedType.U1)]
		public bool orthographicCamera;

		[FieldOffset(1)]
		[MarshalAs(UnmanagedType.U1)]
		public bool aoBlueNoise;

		[FieldOffset(2)]
		[MarshalAs(UnmanagedType.U1)]
		public bool aoInterleavedGradient;

		[FieldOffset(3)]
		[MarshalAs(UnmanagedType.U1)]
		public bool sampleCountHigh;

		[FieldOffset(4)]
		[MarshalAs(UnmanagedType.U1)]
		public bool sampleCountMedium;

		[FieldOffset(5)]
		[MarshalAs(UnmanagedType.U1)]
		public bool sampleCountLow;

		[FieldOffset(6)]
		[MarshalAs(UnmanagedType.U1)]
		public bool sourceDepthNormals;

		[FieldOffset(7)]
		[MarshalAs(UnmanagedType.U1)]
		public bool sourceDepthHigh;

		[FieldOffset(8)]
		[MarshalAs(UnmanagedType.U1)]
		public bool sourceDepthMedium;

		[FieldOffset(9)]
		[MarshalAs(UnmanagedType.U1)]
		public bool sourceDepthLow;

		[FieldOffset(12)]
		public Vector4 ssaoParams;

		static SSAOMaterialParams()
		{
			Il2CppClassPointerStore<SSAOMaterialParams>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusionPass>.NativeClassPtr, "SSAOMaterialParams");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SSAOMaterialParams>.NativeClassPtr);
			NativeFieldInfoPtr_orthographicCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SSAOMaterialParams>.NativeClassPtr, "orthographicCamera");
			NativeFieldInfoPtr_aoBlueNoise = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SSAOMaterialParams>.NativeClassPtr, "aoBlueNoise");
			NativeFieldInfoPtr_aoInterleavedGradient = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SSAOMaterialParams>.NativeClassPtr, "aoInterleavedGradient");
			NativeFieldInfoPtr_sampleCountHigh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SSAOMaterialParams>.NativeClassPtr, "sampleCountHigh");
			NativeFieldInfoPtr_sampleCountMedium = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SSAOMaterialParams>.NativeClassPtr, "sampleCountMedium");
			NativeFieldInfoPtr_sampleCountLow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SSAOMaterialParams>.NativeClassPtr, "sampleCountLow");
			NativeFieldInfoPtr_sourceDepthNormals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SSAOMaterialParams>.NativeClassPtr, "sourceDepthNormals");
			NativeFieldInfoPtr_sourceDepthHigh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SSAOMaterialParams>.NativeClassPtr, "sourceDepthHigh");
			NativeFieldInfoPtr_sourceDepthMedium = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SSAOMaterialParams>.NativeClassPtr, "sourceDepthMedium");
			NativeFieldInfoPtr_sourceDepthLow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SSAOMaterialParams>.NativeClassPtr, "sourceDepthLow");
			NativeFieldInfoPtr_ssaoParams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SSAOMaterialParams>.NativeClassPtr, "ssaoParams");
			NativeMethodInfoPtr__ctor_Internal_Void_byref_ScreenSpaceAmbientOcclusionSettings_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SSAOMaterialParams>.NativeClassPtr, 100665124);
			NativeMethodInfoPtr_Equals_Internal_Boolean_byref_SSAOMaterialParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SSAOMaterialParams>.NativeClassPtr, 100665125);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1095131, RefRangeEnd = 1095132, XrefRangeStart = 1095128, XrefRangeEnd = 1095131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SSAOMaterialParams(ref ScreenSpaceAmbientOcclusionSettings settings, bool isOrthographic)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)settings);
			*ptr = (nint)(&intPtr);
			*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &isOrthographic;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_byref_ScreenSpaceAmbientOcclusionSettings_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			System.IntPtr intPtr4 = intPtr;
			settings = ((intPtr4 == (System.IntPtr)0) ? null : new ScreenSpaceAmbientOcclusionSettings(intPtr4));
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1095132, RefRangeEnd = 1095133, XrefRangeStart = 1095132, XrefRangeEnd = 1095132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(ref SSAOMaterialParams other)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)Unsafe.AsPointer(ref other);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Internal_Boolean_byref_SSAOMaterialParams_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SSAOMaterialParams>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	public class SSAOPassData : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_afterOpaque;

		private static readonly System.IntPtr NativeFieldInfoPtr_BlurQuality;

		private static readonly System.IntPtr NativeFieldInfoPtr_material;

		private static readonly System.IntPtr NativeFieldInfoPtr_directLightingStrength;

		private static readonly System.IntPtr NativeFieldInfoPtr_cameraColor;

		private static readonly System.IntPtr NativeFieldInfoPtr_AOTexture;

		private static readonly System.IntPtr NativeFieldInfoPtr_finalTexture;

		private static readonly System.IntPtr NativeFieldInfoPtr_blurTexture;

		private static readonly System.IntPtr NativeFieldInfoPtr_cameraNormalsTexture;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe bool afterOpaque
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_afterOpaque);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_afterOpaque)) = value;
			}
		}

		public unsafe ScreenSpaceAmbientOcclusionSettings.BlurQualityOptions BlurQuality
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BlurQuality);
				return *(ScreenSpaceAmbientOcclusionSettings.BlurQualityOptions*)num;
			}
			set
			{
				*(ScreenSpaceAmbientOcclusionSettings.BlurQualityOptions*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BlurQuality)) = value;
			}
		}

		public unsafe Material material
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_material);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_material)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe float directLightingStrength
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_directLightingStrength);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_directLightingStrength)) = value;
			}
		}

		public unsafe TextureHandle cameraColor
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cameraColor);
				return *(TextureHandle*)num;
			}
			set
			{
				*(TextureHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cameraColor)) = value;
			}
		}

		public unsafe TextureHandle AOTexture
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AOTexture);
				return *(TextureHandle*)num;
			}
			set
			{
				*(TextureHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AOTexture)) = value;
			}
		}

		public unsafe TextureHandle finalTexture
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_finalTexture);
				return *(TextureHandle*)num;
			}
			set
			{
				*(TextureHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_finalTexture)) = value;
			}
		}

		public unsafe TextureHandle blurTexture
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blurTexture);
				return *(TextureHandle*)num;
			}
			set
			{
				*(TextureHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blurTexture)) = value;
			}
		}

		public unsafe TextureHandle cameraNormalsTexture
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cameraNormalsTexture);
				return *(TextureHandle*)num;
			}
			set
			{
				*(TextureHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cameraNormalsTexture)) = value;
			}
		}

		static SSAOPassData()
		{
			Il2CppClassPointerStore<SSAOPassData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusionPass>.NativeClassPtr, "SSAOPassData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SSAOPassData>.NativeClassPtr);
			NativeFieldInfoPtr_afterOpaque = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SSAOPassData>.NativeClassPtr, "afterOpaque");
			NativeFieldInfoPtr_BlurQuality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SSAOPassData>.NativeClassPtr, "BlurQuality");
			NativeFieldInfoPtr_material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SSAOPassData>.NativeClassPtr, "material");
			NativeFieldInfoPtr_directLightingStrength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SSAOPassData>.NativeClassPtr, "directLightingStrength");
			NativeFieldInfoPtr_cameraColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SSAOPassData>.NativeClassPtr, "cameraColor");
			NativeFieldInfoPtr_AOTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SSAOPassData>.NativeClassPtr, "AOTexture");
			NativeFieldInfoPtr_finalTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SSAOPassData>.NativeClassPtr, "finalTexture");
			NativeFieldInfoPtr_blurTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SSAOPassData>.NativeClassPtr, "blurTexture");
			NativeFieldInfoPtr_cameraNormalsTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SSAOPassData>.NativeClassPtr, "cameraNormalsTexture");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SSAOPassData>.NativeClassPtr, 100665126);
		}

		[CallerCount(1950)]
		[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SSAOPassData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SSAOPassData>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public SSAOPassData(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	[ObfuscatedName("UnityEngine.Rendering.Universal.ScreenSpaceAmbientOcclusionPass+<>c")]
	public sealed class __c : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___9;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__52_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__RecordRenderGraph_b__52_0_Internal_Void_SSAOPassData_UnsafeGraphContext_0;

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

		public unsafe static BaseRenderFunc<SSAOPassData, UnsafeGraphContext> __9__52_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__52_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<BaseRenderFunc<SSAOPassData, UnsafeGraphContext>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__52_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		static __c()
		{
			Il2CppClassPointerStore<__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusionPass>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c>.NativeClassPtr);
			NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9");
			NativeFieldInfoPtr___9__52_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__52_0");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100665128);
			NativeMethodInfoPtr__RecordRenderGraph_b__52_0_Internal_Void_SSAOPassData_UnsafeGraphContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100665129);
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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1095133, XrefRangeEnd = 1095204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _RecordRenderGraph_b__52_0(SSAOPassData data, UnsafeGraphContext rgContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rgContext);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RecordRenderGraph_b__52_0_Internal_Void_SSAOPassData_UnsafeGraphContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public __c(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_m_SupportsR8RenderTextureFormat;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_BlueNoiseTextureIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Material;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_PassData;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_BlueNoiseTextures;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CameraTopLeftCorner;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CameraXExtent;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CameraYExtent;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CameraZExtent;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_SSAOTextures;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_BlurType;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CameraViewProjections;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ProfilingSampler;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Renderer;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_AOPassDescriptor;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CurrentSettings;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_SSAOTextureName;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_AmbientOcclusionParamName;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_AmbientOcclusionParamID;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_SSAOParamsID;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_SSAOBlueNoiseParamsID;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_BlueNoiseTextureID;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_SSAOFinalTextureID;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_CameraViewXExtentID;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_CameraViewYExtentID;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_CameraViewZExtentID;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_ProjectionParams2ID;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_CameraViewProjectionsID;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_CameraViewTopLeftCornerID;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_CameraDepthTextureID;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_CameraNormalsTextureID;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_BilateralTexturesIndices;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_BilateralPasses;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_BilateralAfterOpaquePasses;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_GaussianTexturesIndices;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_GaussianPasses;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_GaussianAfterOpaquePasses;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_KawaseTexturesIndices;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_KawasePasses;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_KawaseAfterOpaquePasses;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_SSAOParamsPrev;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isRendererDeferred_Private_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Setup_Internal_Boolean_byref_ScreenSpaceAmbientOcclusionSettings_byref_ScriptableRenderer_byref_Material_byref_Il2CppReferenceArray_1_Texture2D_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsAfterOpaquePass_Private_Static_Boolean_byref_ShaderPasses_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupKeywordsAndParameters_Private_Void_byref_ScreenSpaceAmbientOcclusionSettings_byref_UniversalCameraData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitSSAOPassData_Private_Void_byref_SSAOPassData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RecordRenderGraph_Public_Virtual_Void_RenderGraph_ContextContainer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateRenderTextureHandles_Private_Void_RenderGraph_UniversalResourceData_UniversalCameraData_byref_TextureHandle_byref_TextureHandle_byref_TextureHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnCameraSetup_Public_Virtual_Void_CommandBuffer_byref_RenderingData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RenderAndSetBaseMap_Private_Static_Void_byref_CommandBuffer_byref_RenderingData_byref_ScriptableRenderer_byref_Material_byref_RTHandle_byref_RTHandle_ShaderPasses_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPassOrder_Private_Static_Void_BlurTypes_Boolean_byref_Il2CppStructArray_1_Int32_byref_Il2CppStructArray_1_ShaderPasses_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnCameraCleanup_Public_Virtual_Void_CommandBuffer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Void_0;

	public unsafe bool m_SupportsR8RenderTextureFormat
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SupportsR8RenderTextureFormat);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SupportsR8RenderTextureFormat)) = value;
		}
	}

	public unsafe int m_BlueNoiseTextureIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BlueNoiseTextureIndex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BlueNoiseTextureIndex)) = value;
		}
	}

	public unsafe Material m_Material
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Material);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Material)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe SSAOPassData m_PassData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_PassData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SSAOPassData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_PassData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppReferenceArray<Texture2D> m_BlueNoiseTextures
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BlueNoiseTextures);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Texture2D>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BlueNoiseTextures)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppStructArray<Vector4> m_CameraTopLeftCorner
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CameraTopLeftCorner);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector4>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CameraTopLeftCorner)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppStructArray<Vector4> m_CameraXExtent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CameraXExtent);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector4>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CameraXExtent)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppStructArray<Vector4> m_CameraYExtent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CameraYExtent);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector4>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CameraYExtent)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppStructArray<Vector4> m_CameraZExtent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CameraZExtent);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector4>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CameraZExtent)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppReferenceArray<RTHandle> m_SSAOTextures
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SSAOTextures);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RTHandle>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SSAOTextures)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe BlurTypes m_BlurType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BlurType);
			return *(BlurTypes*)num;
		}
		set
		{
			*(BlurTypes*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BlurType)) = value;
		}
	}

	public unsafe Il2CppStructArray<Matrix4x4> m_CameraViewProjections
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CameraViewProjections);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Matrix4x4>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CameraViewProjections)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe ProfilingSampler m_ProfilingSampler
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ProfilingSampler);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ProfilingSampler)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe ScriptableRenderer m_Renderer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Renderer);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ScriptableRenderer>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Renderer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe RenderTextureDescriptor m_AOPassDescriptor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AOPassDescriptor);
			return *(RenderTextureDescriptor*)num;
		}
		set
		{
			*(RenderTextureDescriptor*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AOPassDescriptor)) = value;
		}
	}

	public unsafe ScreenSpaceAmbientOcclusionSettings m_CurrentSettings
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CurrentSettings);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ScreenSpaceAmbientOcclusionSettings>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CurrentSettings)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static string k_SSAOTextureName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_SSAOTextureName, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_SSAOTextureName, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string k_AmbientOcclusionParamName
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_k_AmbientOcclusionParamName, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_k_AmbientOcclusionParamName, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static int s_AmbientOcclusionParamID
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_AmbientOcclusionParamID, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_AmbientOcclusionParamID, (void*)(&value));
		}
	}

	public unsafe static int s_SSAOParamsID
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_SSAOParamsID, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_SSAOParamsID, (void*)(&value));
		}
	}

	public unsafe static int s_SSAOBlueNoiseParamsID
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_SSAOBlueNoiseParamsID, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_SSAOBlueNoiseParamsID, (void*)(&value));
		}
	}

	public unsafe static int s_BlueNoiseTextureID
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_BlueNoiseTextureID, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_BlueNoiseTextureID, (void*)(&value));
		}
	}

	public unsafe static int s_SSAOFinalTextureID
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_SSAOFinalTextureID, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_SSAOFinalTextureID, (void*)(&value));
		}
	}

	public unsafe static int s_CameraViewXExtentID
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_CameraViewXExtentID, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_CameraViewXExtentID, (void*)(&value));
		}
	}

	public unsafe static int s_CameraViewYExtentID
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_CameraViewYExtentID, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_CameraViewYExtentID, (void*)(&value));
		}
	}

	public unsafe static int s_CameraViewZExtentID
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_CameraViewZExtentID, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_CameraViewZExtentID, (void*)(&value));
		}
	}

	public unsafe static int s_ProjectionParams2ID
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_ProjectionParams2ID, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_ProjectionParams2ID, (void*)(&value));
		}
	}

	public unsafe static int s_CameraViewProjectionsID
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_CameraViewProjectionsID, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_CameraViewProjectionsID, (void*)(&value));
		}
	}

	public unsafe static int s_CameraViewTopLeftCornerID
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_CameraViewTopLeftCornerID, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_CameraViewTopLeftCornerID, (void*)(&value));
		}
	}

	public unsafe static int s_CameraDepthTextureID
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_CameraDepthTextureID, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_CameraDepthTextureID, (void*)(&value));
		}
	}

	public unsafe static int s_CameraNormalsTextureID
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_CameraNormalsTextureID, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_CameraNormalsTextureID, (void*)(&value));
		}
	}

	public unsafe static Il2CppStructArray<int> m_BilateralTexturesIndices
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_BilateralTexturesIndices, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_BilateralTexturesIndices, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<ShaderPasses> m_BilateralPasses
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_BilateralPasses, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<ShaderPasses>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_BilateralPasses, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<ShaderPasses> m_BilateralAfterOpaquePasses
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_BilateralAfterOpaquePasses, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<ShaderPasses>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_BilateralAfterOpaquePasses, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<int> m_GaussianTexturesIndices
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_GaussianTexturesIndices, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_GaussianTexturesIndices, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<ShaderPasses> m_GaussianPasses
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_GaussianPasses, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<ShaderPasses>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_GaussianPasses, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<ShaderPasses> m_GaussianAfterOpaquePasses
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_GaussianAfterOpaquePasses, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<ShaderPasses>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_GaussianAfterOpaquePasses, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<int> m_KawaseTexturesIndices
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_KawaseTexturesIndices, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_KawaseTexturesIndices, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<ShaderPasses> m_KawasePasses
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_KawasePasses, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<ShaderPasses>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_KawasePasses, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppStructArray<ShaderPasses> m_KawaseAfterOpaquePasses
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_KawaseAfterOpaquePasses, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<ShaderPasses>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_KawaseAfterOpaquePasses, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe SSAOMaterialParams m_SSAOParamsPrev
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SSAOParamsPrev);
			return *(SSAOMaterialParams*)num;
		}
		set
		{
			*(SSAOMaterialParams*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SSAOParamsPrev)) = value;
		}
	}

	public unsafe bool isRendererDeferred
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1095204, XrefRangeEnd = 1095207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isRendererDeferred_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static ScreenSpaceAmbientOcclusionPass()
	{
		Il2CppClassPointerStore<ScreenSpaceAmbientOcclusionPass>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "ScreenSpaceAmbientOcclusionPass");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusionPass>.NativeClassPtr);
		NativeFieldInfoPtr_m_SupportsR8RenderTextureFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusionPass>.NativeClassPtr, "m_SupportsR8RenderTextureFormat");
		NativeFieldInfoPtr_m_BlueNoiseTextureIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusionPass>.NativeClassPtr, "m_BlueNoiseTextureIndex");
		NativeFieldInfoPtr_m_Material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusionPass>.NativeClassPtr, "m_Material");
		NativeFieldInfoPtr_m_PassData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusionPass>.NativeClassPtr, "m_PassData");
		NativeFieldInfoPtr_m_BlueNoiseTextures = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusionPass>.NativeClassPtr, "m_BlueNoiseTextures");
		NativeFieldInfoPtr_m_CameraTopLeftCorner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusionPass>.NativeClassPtr, "m_CameraTopLeftCorner");
		NativeFieldInfoPtr_m_CameraXExtent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusionPass>.NativeClassPtr, "m_CameraXExtent");
		NativeFieldInfoPtr_m_CameraYExtent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusionPass>.NativeClassPtr, "m_CameraYExtent");
		NativeFieldInfoPtr_m_CameraZExtent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusionPass>.NativeClassPtr, "m_CameraZExtent");
		NativeFieldInfoPtr_m_SSAOTextures = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusionPass>.NativeClassPtr, "m_SSAOTextures");
		NativeFieldInfoPtr_m_BlurType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusionPass>.NativeClassPtr, "m_BlurType");
		NativeFieldInfoPtr_m_CameraViewProjections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusionPass>.NativeClassPtr, "m_CameraViewProjections");
		NativeFieldInfoPtr_m_ProfilingSampler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusionPass>.NativeClassPtr, "m_ProfilingSampler");
		NativeFieldInfoPtr_m_Renderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusionPass>.NativeClassPtr, "m_Renderer");
		NativeFieldInfoPtr_m_AOPassDescriptor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusionPass>.NativeClassPtr, "m_AOPassDescriptor");
		NativeFieldInfoPtr_m_CurrentSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusionPass>.NativeClassPtr, "m_CurrentSettings");
		NativeFieldInfoPtr_k_SSAOTextureName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusionPass>.NativeClassPtr, "k_SSAOTextureName");
		NativeFieldInfoPtr_k_AmbientOcclusionParamName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusionPass>.NativeClassPtr, "k_AmbientOcclusionParamName");
		NativeFieldInfoPtr_s_AmbientOcclusionParamID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusionPass>.NativeClassPtr, "s_AmbientOcclusionParamID");
		NativeFieldInfoPtr_s_SSAOParamsID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusionPass>.NativeClassPtr, "s_SSAOParamsID");
		NativeFieldInfoPtr_s_SSAOBlueNoiseParamsID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusionPass>.NativeClassPtr, "s_SSAOBlueNoiseParamsID");
		NativeFieldInfoPtr_s_BlueNoiseTextureID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusionPass>.NativeClassPtr, "s_BlueNoiseTextureID");
		NativeFieldInfoPtr_s_SSAOFinalTextureID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusionPass>.NativeClassPtr, "s_SSAOFinalTextureID");
		NativeFieldInfoPtr_s_CameraViewXExtentID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusionPass>.NativeClassPtr, "s_CameraViewXExtentID");
		NativeFieldInfoPtr_s_CameraViewYExtentID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusionPass>.NativeClassPtr, "s_CameraViewYExtentID");
		NativeFieldInfoPtr_s_CameraViewZExtentID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusionPass>.NativeClassPtr, "s_CameraViewZExtentID");
		NativeFieldInfoPtr_s_ProjectionParams2ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusionPass>.NativeClassPtr, "s_ProjectionParams2ID");
		NativeFieldInfoPtr_s_CameraViewProjectionsID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusionPass>.NativeClassPtr, "s_CameraViewProjectionsID");
		NativeFieldInfoPtr_s_CameraViewTopLeftCornerID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusionPass>.NativeClassPtr, "s_CameraViewTopLeftCornerID");
		NativeFieldInfoPtr_s_CameraDepthTextureID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusionPass>.NativeClassPtr, "s_CameraDepthTextureID");
		NativeFieldInfoPtr_s_CameraNormalsTextureID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusionPass>.NativeClassPtr, "s_CameraNormalsTextureID");
		NativeFieldInfoPtr_m_BilateralTexturesIndices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusionPass>.NativeClassPtr, "m_BilateralTexturesIndices");
		NativeFieldInfoPtr_m_BilateralPasses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusionPass>.NativeClassPtr, "m_BilateralPasses");
		NativeFieldInfoPtr_m_BilateralAfterOpaquePasses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusionPass>.NativeClassPtr, "m_BilateralAfterOpaquePasses");
		NativeFieldInfoPtr_m_GaussianTexturesIndices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusionPass>.NativeClassPtr, "m_GaussianTexturesIndices");
		NativeFieldInfoPtr_m_GaussianPasses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusionPass>.NativeClassPtr, "m_GaussianPasses");
		NativeFieldInfoPtr_m_GaussianAfterOpaquePasses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusionPass>.NativeClassPtr, "m_GaussianAfterOpaquePasses");
		NativeFieldInfoPtr_m_KawaseTexturesIndices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusionPass>.NativeClassPtr, "m_KawaseTexturesIndices");
		NativeFieldInfoPtr_m_KawasePasses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusionPass>.NativeClassPtr, "m_KawasePasses");
		NativeFieldInfoPtr_m_KawaseAfterOpaquePasses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusionPass>.NativeClassPtr, "m_KawaseAfterOpaquePasses");
		NativeFieldInfoPtr_m_SSAOParamsPrev = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusionPass>.NativeClassPtr, "m_SSAOParamsPrev");
		NativeMethodInfoPtr_get_isRendererDeferred_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusionPass>.NativeClassPtr, 100665109);
		NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusionPass>.NativeClassPtr, 100665110);
		NativeMethodInfoPtr_Setup_Internal_Boolean_byref_ScreenSpaceAmbientOcclusionSettings_byref_ScriptableRenderer_byref_Material_byref_Il2CppReferenceArray_1_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusionPass>.NativeClassPtr, 100665111);
		NativeMethodInfoPtr_IsAfterOpaquePass_Private_Static_Boolean_byref_ShaderPasses_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusionPass>.NativeClassPtr, 100665112);
		NativeMethodInfoPtr_SetupKeywordsAndParameters_Private_Void_byref_ScreenSpaceAmbientOcclusionSettings_byref_UniversalCameraData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusionPass>.NativeClassPtr, 100665113);
		NativeMethodInfoPtr_InitSSAOPassData_Private_Void_byref_SSAOPassData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusionPass>.NativeClassPtr, 100665114);
		NativeMethodInfoPtr_RecordRenderGraph_Public_Virtual_Void_RenderGraph_ContextContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusionPass>.NativeClassPtr, 100665115);
		NativeMethodInfoPtr_CreateRenderTextureHandles_Private_Void_RenderGraph_UniversalResourceData_UniversalCameraData_byref_TextureHandle_byref_TextureHandle_byref_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusionPass>.NativeClassPtr, 100665116);
		NativeMethodInfoPtr_OnCameraSetup_Public_Virtual_Void_CommandBuffer_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusionPass>.NativeClassPtr, 100665117);
		NativeMethodInfoPtr_Execute_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusionPass>.NativeClassPtr, 100665118);
		NativeMethodInfoPtr_RenderAndSetBaseMap_Private_Static_Void_byref_CommandBuffer_byref_RenderingData_byref_ScriptableRenderer_byref_Material_byref_RTHandle_byref_RTHandle_ShaderPasses_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusionPass>.NativeClassPtr, 100665119);
		NativeMethodInfoPtr_GetPassOrder_Private_Static_Void_BlurTypes_Boolean_byref_Il2CppStructArray_1_Int32_byref_Il2CppStructArray_1_ShaderPasses_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusionPass>.NativeClassPtr, 100665120);
		NativeMethodInfoPtr_OnCameraCleanup_Public_Virtual_Void_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusionPass>.NativeClassPtr, 100665121);
		NativeMethodInfoPtr_Dispose_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusionPass>.NativeClassPtr, 100665122);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1095247, RefRangeEnd = 1095248, XrefRangeStart = 1095207, XrefRangeEnd = 1095247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ScreenSpaceAmbientOcclusionPass()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScreenSpaceAmbientOcclusionPass>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1095263, RefRangeEnd = 1095264, XrefRangeStart = 1095248, XrefRangeEnd = 1095263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Setup(ref ScreenSpaceAmbientOcclusionSettings featureSettings, ref ScriptableRenderer renderer, ref Material material, ref Il2CppReferenceArray<Texture2D> blueNoiseTextures)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)featureSettings);
		*ptr = (nint)(&intPtr);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderer);
		*(System.IntPtr**)num = &intPtr2;
		byte* num2 = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr3 = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material);
		*(System.IntPtr**)num2 = &intPtr3;
		byte* num3 = (byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr4 = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)blueNoiseTextures);
		*(System.IntPtr**)num3 = &intPtr4;
		Unsafe.SkipInit(out System.IntPtr intPtr5);
		System.IntPtr intPtr6 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Setup_Internal_Boolean_byref_ScreenSpaceAmbientOcclusionSettings_byref_ScriptableRenderer_byref_Material_byref_Il2CppReferenceArray_1_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr5);
		Il2CppException.RaiseExceptionIfNecessary(intPtr5);
		System.IntPtr intPtr7 = intPtr;
		featureSettings = ((intPtr7 == (System.IntPtr)0) ? null : new ScreenSpaceAmbientOcclusionSettings(intPtr7));
		System.IntPtr intPtr8 = intPtr2;
		renderer = ((intPtr8 == (System.IntPtr)0) ? null : new ScriptableRenderer(intPtr8));
		System.IntPtr intPtr9 = intPtr3;
		material = ((intPtr9 == (System.IntPtr)0) ? null : new Material(intPtr9));
		System.IntPtr intPtr10 = intPtr4;
		blueNoiseTextures = ((intPtr10 == (System.IntPtr)0) ? null : new Il2CppReferenceArray<Texture2D>(intPtr10));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr6);
	}

	[CallerCount(0)]
	public unsafe static bool IsAfterOpaquePass(ref ShaderPasses pass)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref pass);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsAfterOpaquePass_Private_Static_Boolean_byref_ShaderPasses_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1095344, RefRangeEnd = 1095346, XrefRangeStart = 1095264, XrefRangeEnd = 1095344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetupKeywordsAndParameters(ref ScreenSpaceAmbientOcclusionSettings settings, ref UniversalCameraData cameraData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)settings);
		*ptr = (nint)(&intPtr);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cameraData);
		*(System.IntPtr**)num = &intPtr2;
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr4 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupKeywordsAndParameters_Private_Void_byref_ScreenSpaceAmbientOcclusionSettings_byref_UniversalCameraData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr5 = intPtr;
		settings = ((intPtr5 == (System.IntPtr)0) ? null : new ScreenSpaceAmbientOcclusionSettings(intPtr5));
		System.IntPtr intPtr6 = intPtr2;
		cameraData = ((intPtr6 == (System.IntPtr)0) ? null : new UniversalCameraData(intPtr6));
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1095347, RefRangeEnd = 1095348, XrefRangeStart = 1095346, XrefRangeEnd = 1095347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InitSSAOPassData(ref SSAOPassData data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
		*ptr = (nint)(&intPtr);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitSSAOPassData_Private_Void_byref_SSAOPassData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		data = ((intPtr4 == (System.IntPtr)0) ? null : new SSAOPassData(intPtr4));
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1095348, XrefRangeEnd = 1095435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void RecordRenderGraph(RenderGraph renderGraph, ContextContainer frameData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderGraph);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)frameData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_RecordRenderGraph_Public_Virtual_Void_RenderGraph_ContextContainer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1095464, RefRangeEnd = 1095465, XrefRangeStart = 1095435, XrefRangeEnd = 1095464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CreateRenderTextureHandles(RenderGraph renderGraph, UniversalResourceData resourceData, UniversalCameraData cameraData, out TextureHandle aoTexture, out TextureHandle blurTexture, out TextureHandle finalTexture)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderGraph);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)resourceData);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cameraData);
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref aoTexture);
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref blurTexture);
		*(void**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref finalTexture);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateRenderTextureHandles_Private_Void_RenderGraph_UniversalResourceData_UniversalCameraData_byref_TextureHandle_byref_TextureHandle_byref_TextureHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1095465, XrefRangeEnd = 1095499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void OnCameraSetup(CommandBuffer cmd, ref RenderingData renderingData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)renderingData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_OnCameraSetup_Public_Virtual_Void_CommandBuffer_byref_RenderingData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1095499, XrefRangeEnd = 1095558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1095570, RefRangeEnd = 1095572, XrefRangeStart = 1095558, XrefRangeEnd = 1095570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RenderAndSetBaseMap(ref CommandBuffer cmd, ref RenderingData renderingData, ref ScriptableRenderer renderer, ref Material mat, ref RTHandle baseMap, ref RTHandle target, ShaderPasses pass)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*ptr = (nint)(&intPtr);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)renderingData);
		byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderer);
		*(System.IntPtr**)num = &intPtr2;
		byte* num2 = (byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr3 = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mat);
		*(System.IntPtr**)num2 = &intPtr3;
		byte* num3 = (byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr4 = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)baseMap);
		*(System.IntPtr**)num3 = &intPtr4;
		byte* num4 = (byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr5 = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)target);
		*(System.IntPtr**)num4 = &intPtr5;
		*(ShaderPasses**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &pass;
		Unsafe.SkipInit(out System.IntPtr intPtr6);
		System.IntPtr intPtr7 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RenderAndSetBaseMap_Private_Static_Void_byref_CommandBuffer_byref_RenderingData_byref_ScriptableRenderer_byref_Material_byref_RTHandle_byref_RTHandle_ShaderPasses_0, (System.IntPtr)0, (void**)ptr, ref intPtr6);
		Il2CppException.RaiseExceptionIfNecessary(intPtr6);
		System.IntPtr intPtr8 = intPtr;
		cmd = ((intPtr8 == (System.IntPtr)0) ? null : new CommandBuffer(intPtr8));
		System.IntPtr intPtr9 = intPtr2;
		renderer = ((intPtr9 == (System.IntPtr)0) ? null : new ScriptableRenderer(intPtr9));
		System.IntPtr intPtr10 = intPtr3;
		mat = ((intPtr10 == (System.IntPtr)0) ? null : new Material(intPtr10));
		System.IntPtr intPtr11 = intPtr4;
		baseMap = ((intPtr11 == (System.IntPtr)0) ? null : new RTHandle(intPtr11));
		System.IntPtr intPtr12 = intPtr5;
		target = ((intPtr12 == (System.IntPtr)0) ? null : new RTHandle(intPtr12));
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1095611, RefRangeEnd = 1095612, XrefRangeStart = 1095572, XrefRangeEnd = 1095611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetPassOrder(BlurTypes blurType, bool isAfterOpaque, out Il2CppStructArray<int> textureIndices, out Il2CppStructArray<ShaderPasses> shaderPasses)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&blurType);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &isAfterOpaque;
		byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		byte* num3 = (byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num4 = 0;
		*(nint**)num3 = &num4;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPassOrder_Private_Static_Void_BlurTypes_Boolean_byref_Il2CppStructArray_1_Int32_byref_Il2CppStructArray_1_ShaderPasses_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num5 = num2;
		textureIndices = ((num5 == 0) ? null : new Il2CppStructArray<int>((System.IntPtr)num5));
		nint num6 = num4;
		shaderPasses = ((num6 == 0) ? null : new Il2CppStructArray<ShaderPasses>((System.IntPtr)num6));
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1095612, XrefRangeEnd = 1095615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void OnCameraCleanup(CommandBuffer cmd)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_OnCameraCleanup_Public_Virtual_Void_CommandBuffer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1095615, XrefRangeEnd = 1095619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Dispose()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dispose_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public ScreenSpaceAmbientOcclusionPass(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
