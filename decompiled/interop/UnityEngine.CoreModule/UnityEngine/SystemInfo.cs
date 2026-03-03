using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using UnityEngine.Bindings;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Rendering;

namespace UnityEngine;

public sealed class SystemInfo : Il2CppSystem.Object
{
	private delegate float GetBatteryLevelDelegate();

	private delegate BatteryStatus GetBatteryStatusDelegate();

	private delegate int GetProcessorFrequencyMHzDelegate();

	private delegate int GetProcessorCountDelegate();

	private delegate int GetPhysicalMemoryMBDelegate();

	private delegate bool SupportsAccelerometerDelegate();

	private delegate bool IsGyroAvailableDelegate();

	private delegate bool SupportsLocationServiceDelegate();

	private delegate bool SupportsVibrationDelegate();

	private delegate bool SupportsAudioDelegate();

	private delegate int GetGraphicsMemorySizeDelegate();

	private delegate int GetGraphicsDeviceIDDelegate();

	private delegate bool GetGraphicsMultiThreadedDelegate();

	private delegate bool HasDynamicUniformArrayIndexingInFragmentShadersDelegate();

	private delegate bool SupportsRawShadowDepthSamplingDelegate();

	private delegate bool SupportsMotionVectorsDelegate();

	private delegate bool Supports3DTexturesDelegate();

	private delegate bool SupportsCompressed3DTexturesDelegate();

	private delegate bool Supports2DArrayTexturesDelegate();

	private delegate bool Supports3DRenderTexturesDelegate();

	private delegate bool SupportsCubemapArrayTexturesDelegate();

	private delegate bool SupportsAnisotropicFilterDelegate();

	private delegate bool SupportsGeometryShadersDelegate();

	private delegate bool SupportsTessellationShadersDelegate();

	private delegate bool SupportsHardwareQuadTopologyDelegate();

	private delegate bool Supports32bitsIndexBufferDelegate();

	private delegate bool SupportsSparseTexturesDelegate();

	private delegate bool SupportsSeparatedRenderTargetsBlendDelegate();

	private delegate int SupportedRandomWriteTargetCountDelegate();

	private delegate int MaxComputeBufferInputsVertexDelegate();

	private delegate int MaxComputeBufferInputsFragmentDelegate();

	private delegate int MaxComputeBufferInputsGeometryDelegate();

	private delegate int MaxComputeBufferInputsDomainDelegate();

	private delegate int MaxComputeBufferInputsHullDelegate();

	private delegate int MaxComputeBufferInputsComputeDelegate();

	private delegate bool SupportsMultisampled2DArrayTexturesDelegate();

	private delegate int SupportsTextureWrapMirrorOnceDelegate();

	private delegate bool SupportsBlendingOnRenderTextureFormatNativeDelegate(RenderTextureFormat format);

	private delegate bool SupportsRandomWriteOnRenderTextureFormatNativeDelegate(RenderTextureFormat format);

	private delegate bool SupportsVertexAttributeFormatNativeDelegate(VertexAttributeFormat format, int dimension);

	private delegate NPOTSupport GetNPOTSupportDelegate();

	private delegate int GetMaxTexture3DSizeDelegate();

	private delegate int GetMaxTextureArraySlicesDelegate();

	private delegate int GetMaxCubemapSizeDelegate();

	private delegate int GetMaxAnisotropyLevelDelegate();

	private delegate int GetMaxComputeWorkGroupSizeDelegate();

	private delegate int GetMaxComputeWorkGroupSizeXDelegate();

	private delegate int GetMaxComputeWorkGroupSizeYDelegate();

	private delegate int GetMaxComputeWorkGroupSizeZDelegate();

	private delegate int GetComputeSubGroupSizeDelegate();

	private delegate bool SupportsAsyncComputeDelegate();

	private delegate bool SupportsGpuRecorderDelegate();

	private delegate bool SupportsAsyncGPUReadbackDelegate();

	private delegate bool SupportsParallelPSOCreationDelegate();

	private delegate bool SupportsRayTracingDelegate();

	private delegate bool SupportsRayTracingShadersDelegate();

	private delegate bool SupportsInlineRayTracingDelegate();

	private delegate bool SupportsIndirectDispatchRaysDelegate();

	private delegate bool SupportsSetConstantBufferDelegate();

	private delegate int MinConstantBufferOffsetAlignmentDelegate();

	private delegate int MaxConstantBufferSizeDelegate();

	private delegate bool HasMipMaxLevelDelegate();

	private delegate bool SupportsMipStreamingDelegate();

	private delegate bool SupportsConservativeRasterDelegate();

	private delegate bool SupportsDepthFetchInRenderPassDelegate();

	private delegate void GetProcessorType_InjectedDelegate([Out] System.IntPtr ret);

	private delegate void GetProcessorModel_InjectedDelegate([Out] System.IntPtr ret);

	private delegate void GetProcessorManufacturer_InjectedDelegate([Out] System.IntPtr ret);

	private delegate void GetDeviceUniqueIdentifier_InjectedDelegate([Out] System.IntPtr ret);

	private delegate void GetDeviceName_InjectedDelegate([Out] System.IntPtr ret);

	private delegate void GetGraphicsDeviceVersion_InjectedDelegate([Out] System.IntPtr ret);

	private static readonly System.IntPtr NativeMethodInfoPtr_get_operatingSystem_Public_Static_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_operatingSystemFamily_Public_Static_get_OperatingSystemFamily_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_deviceModel_Public_Static_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_deviceType_Public_Static_get_DeviceType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_graphicsDeviceName_Public_Static_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_graphicsDeviceVendor_Public_Static_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_graphicsDeviceVendorID_Public_Static_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_graphicsDeviceType_Public_Static_get_GraphicsDeviceType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_graphicsUVStartsAtTop_Public_Static_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_graphicsShaderLevel_Public_Static_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_renderingThreadingMode_Public_Static_get_RenderingThreadingMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_foveatedRenderingCaps_Public_Static_get_FoveatedRenderingCaps_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_hasHiddenSurfaceRemovalOnGPU_Public_Static_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_supportsShadows_Public_Static_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_copyTextureSupport_Public_Static_get_CopyTextureSupport_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_supportsComputeShaders_Public_Static_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_supportsRenderTargetArrayIndexFromVertexShader_Public_Static_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_supportsInstancing_Public_Static_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_supportedRenderTargetCount_Public_Static_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_supportsMultisampledTextures_Public_Static_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_supportsMultisampledBackBuffer_Public_Static_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_supportsMultisampleAutoResolve_Public_Static_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_usesReversedZBuffer_Public_Static_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsValidEnumValue_Private_Static_Boolean_Enum_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SupportsRenderTextureFormat_Public_Static_Boolean_RenderTextureFormat_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SupportsTextureFormat_Public_Static_Boolean_TextureFormat_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_maxTextureSize_Public_Static_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_maxRenderTextureSize_Internal_Static_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_supportsGraphicsFence_Public_Static_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_maxGraphicsBufferSize_Public_Static_get_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_usesLoadStoreActions_Public_Static_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_hdrDisplaySupportFlags_Public_Static_get_HDRDisplaySupportFlags_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_supportsMultiview_Public_Static_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_supportsStoreAndResolveAction_Public_Static_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_supportsMultisampleResolveDepth_Public_Static_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_supportsMultisampleResolveStencil_Public_Static_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_supportsIndirectArgumentsBuffer_Public_Static_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetOperatingSystem_Private_Static_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetOperatingSystemFamily_Private_Static_OperatingSystemFamily_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDeviceModel_Private_Static_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDeviceType_Private_Static_DeviceType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetGraphicsDeviceName_Private_Static_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetGraphicsDeviceVendor_Private_Static_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetGraphicsDeviceVendorID_Private_Static_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetGraphicsDeviceType_Private_Static_GraphicsDeviceType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetGraphicsUVStartsAtTop_Private_Static_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetGraphicsShaderLevel_Private_Static_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRenderingThreadingMode_Private_Static_RenderingThreadingMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFoveatedRenderingCaps_Private_Static_FoveatedRenderingCaps_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasHiddenSurfaceRemovalOnGPU_Private_Static_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SupportsShadows_Private_Static_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCopyTextureSupport_Private_Static_CopyTextureSupport_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SupportsComputeShaders_Private_Static_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SupportsRenderTargetArrayIndexFromVertexShader_Private_Static_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SupportsInstancing_Private_Static_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SupportedRenderTargetCount_Private_Static_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SupportsMultisampledTextures_Private_Static_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SupportsMultisampledBackBuffer_Private_Static_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SupportsMultisampleAutoResolve_Private_Static_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UsesReversedZBuffer_Private_Static_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasRenderTextureNative_Private_Static_Boolean_RenderTextureFormat_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SupportsTextureFormatNative_Private_Static_Boolean_TextureFormat_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMaxTextureSize_Private_Static_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMaxRenderTextureSize_Private_Static_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SupportsGPUFence_Private_Static_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MaxGraphicsBufferSize_Private_Static_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsFormatSupported_Public_Static_Boolean_GraphicsFormat_GraphicsFormatUsage_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCompatibleFormat_Public_Static_GraphicsFormat_GraphicsFormat_GraphicsFormatUsage_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetGraphicsFormat_Public_Static_GraphicsFormat_DefaultFormat_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRenderTextureSupportedMSAASampleCount_Public_Static_Int32_RenderTextureDescriptor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UsesLoadStoreActions_Private_Static_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHDRDisplaySupportFlags_Private_Static_HDRDisplaySupportFlags_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SupportsMultiview_Private_Static_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SupportsStoreAndResolveAction_Private_Static_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SupportsMultisampleResolveDepth_Private_Static_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SupportsMultisampleResolveStencil_Private_Static_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SupportsIndirectArgumentsBuffer_Private_Static_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetOperatingSystem_Injected_Private_Static_Void_byref_ManagedSpanWrapper_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDeviceModel_Injected_Private_Static_Void_byref_ManagedSpanWrapper_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetGraphicsDeviceName_Injected_Private_Static_Void_byref_ManagedSpanWrapper_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetGraphicsDeviceVendor_Injected_Private_Static_Void_byref_ManagedSpanWrapper_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRenderTextureSupportedMSAASampleCount_Injected_Private_Static_Int32_byref_RenderTextureDescriptor_0;

	public const string unsupportedIdentifier = "n/a";

	private static readonly GetBatteryLevelDelegate GetBatteryLevelDelegateField;

	private static readonly GetBatteryStatusDelegate GetBatteryStatusDelegateField;

	private static readonly GetProcessorFrequencyMHzDelegate GetProcessorFrequencyMHzDelegateField;

	private static readonly GetProcessorCountDelegate GetProcessorCountDelegateField;

	private static readonly GetPhysicalMemoryMBDelegate GetPhysicalMemoryMBDelegateField;

	private static readonly SupportsAccelerometerDelegate SupportsAccelerometerDelegateField;

	private static readonly IsGyroAvailableDelegate IsGyroAvailableDelegateField;

	private static readonly SupportsLocationServiceDelegate SupportsLocationServiceDelegateField;

	private static readonly SupportsVibrationDelegate SupportsVibrationDelegateField;

	private static readonly SupportsAudioDelegate SupportsAudioDelegateField;

	private static readonly GetGraphicsMemorySizeDelegate GetGraphicsMemorySizeDelegateField;

	private static readonly GetGraphicsDeviceIDDelegate GetGraphicsDeviceIDDelegateField;

	private static readonly GetGraphicsMultiThreadedDelegate GetGraphicsMultiThreadedDelegateField;

	private static readonly HasDynamicUniformArrayIndexingInFragmentShadersDelegate HasDynamicUniformArrayIndexingInFragmentShadersDelegateField;

	private static readonly SupportsRawShadowDepthSamplingDelegate SupportsRawShadowDepthSamplingDelegateField;

	private static readonly SupportsMotionVectorsDelegate SupportsMotionVectorsDelegateField;

	private static readonly Supports3DTexturesDelegate Supports3DTexturesDelegateField;

	private static readonly SupportsCompressed3DTexturesDelegate SupportsCompressed3DTexturesDelegateField;

	private static readonly Supports2DArrayTexturesDelegate Supports2DArrayTexturesDelegateField;

	private static readonly Supports3DRenderTexturesDelegate Supports3DRenderTexturesDelegateField;

	private static readonly SupportsCubemapArrayTexturesDelegate SupportsCubemapArrayTexturesDelegateField;

	private static readonly SupportsAnisotropicFilterDelegate SupportsAnisotropicFilterDelegateField;

	private static readonly SupportsGeometryShadersDelegate SupportsGeometryShadersDelegateField;

	private static readonly SupportsTessellationShadersDelegate SupportsTessellationShadersDelegateField;

	private static readonly SupportsHardwareQuadTopologyDelegate SupportsHardwareQuadTopologyDelegateField;

	private static readonly Supports32bitsIndexBufferDelegate Supports32bitsIndexBufferDelegateField;

	private static readonly SupportsSparseTexturesDelegate SupportsSparseTexturesDelegateField;

	private static readonly SupportsSeparatedRenderTargetsBlendDelegate SupportsSeparatedRenderTargetsBlendDelegateField;

	private static readonly SupportedRandomWriteTargetCountDelegate SupportedRandomWriteTargetCountDelegateField;

	private static readonly MaxComputeBufferInputsVertexDelegate MaxComputeBufferInputsVertexDelegateField;

	private static readonly MaxComputeBufferInputsFragmentDelegate MaxComputeBufferInputsFragmentDelegateField;

	private static readonly MaxComputeBufferInputsGeometryDelegate MaxComputeBufferInputsGeometryDelegateField;

	private static readonly MaxComputeBufferInputsDomainDelegate MaxComputeBufferInputsDomainDelegateField;

	private static readonly MaxComputeBufferInputsHullDelegate MaxComputeBufferInputsHullDelegateField;

	private static readonly MaxComputeBufferInputsComputeDelegate MaxComputeBufferInputsComputeDelegateField;

	private static readonly SupportsMultisampled2DArrayTexturesDelegate SupportsMultisampled2DArrayTexturesDelegateField;

	private static readonly SupportsTextureWrapMirrorOnceDelegate SupportsTextureWrapMirrorOnceDelegateField;

	private static readonly SupportsBlendingOnRenderTextureFormatNativeDelegate SupportsBlendingOnRenderTextureFormatNativeDelegateField;

	private static readonly SupportsRandomWriteOnRenderTextureFormatNativeDelegate SupportsRandomWriteOnRenderTextureFormatNativeDelegateField;

	private static readonly SupportsVertexAttributeFormatNativeDelegate SupportsVertexAttributeFormatNativeDelegateField;

	private static readonly GetNPOTSupportDelegate GetNPOTSupportDelegateField;

	private static readonly GetMaxTexture3DSizeDelegate GetMaxTexture3DSizeDelegateField;

	private static readonly GetMaxTextureArraySlicesDelegate GetMaxTextureArraySlicesDelegateField;

	private static readonly GetMaxCubemapSizeDelegate GetMaxCubemapSizeDelegateField;

	private static readonly GetMaxAnisotropyLevelDelegate GetMaxAnisotropyLevelDelegateField;

	private static readonly GetMaxComputeWorkGroupSizeDelegate GetMaxComputeWorkGroupSizeDelegateField;

	private static readonly GetMaxComputeWorkGroupSizeXDelegate GetMaxComputeWorkGroupSizeXDelegateField;

	private static readonly GetMaxComputeWorkGroupSizeYDelegate GetMaxComputeWorkGroupSizeYDelegateField;

	private static readonly GetMaxComputeWorkGroupSizeZDelegate GetMaxComputeWorkGroupSizeZDelegateField;

	private static readonly GetComputeSubGroupSizeDelegate GetComputeSubGroupSizeDelegateField;

	private static readonly SupportsAsyncComputeDelegate SupportsAsyncComputeDelegateField;

	private static readonly SupportsGpuRecorderDelegate SupportsGpuRecorderDelegateField;

	private static readonly SupportsAsyncGPUReadbackDelegate SupportsAsyncGPUReadbackDelegateField;

	private static readonly SupportsParallelPSOCreationDelegate SupportsParallelPSOCreationDelegateField;

	private static readonly SupportsRayTracingDelegate SupportsRayTracingDelegateField;

	private static readonly SupportsRayTracingShadersDelegate SupportsRayTracingShadersDelegateField;

	private static readonly SupportsInlineRayTracingDelegate SupportsInlineRayTracingDelegateField;

	private static readonly SupportsIndirectDispatchRaysDelegate SupportsIndirectDispatchRaysDelegateField;

	private static readonly SupportsSetConstantBufferDelegate SupportsSetConstantBufferDelegateField;

	private static readonly MinConstantBufferOffsetAlignmentDelegate MinConstantBufferOffsetAlignmentDelegateField;

	private static readonly MaxConstantBufferSizeDelegate MaxConstantBufferSizeDelegateField;

	private static readonly HasMipMaxLevelDelegate HasMipMaxLevelDelegateField;

	private static readonly SupportsMipStreamingDelegate SupportsMipStreamingDelegateField;

	private static readonly SupportsConservativeRasterDelegate SupportsConservativeRasterDelegateField;

	private static readonly SupportsDepthFetchInRenderPassDelegate SupportsDepthFetchInRenderPassDelegateField;

	private static readonly GetProcessorType_InjectedDelegate GetProcessorType_InjectedDelegateField;

	private static readonly GetProcessorModel_InjectedDelegate GetProcessorModel_InjectedDelegateField;

	private static readonly GetProcessorManufacturer_InjectedDelegate GetProcessorManufacturer_InjectedDelegateField;

	private static readonly GetDeviceUniqueIdentifier_InjectedDelegate GetDeviceUniqueIdentifier_InjectedDelegateField;

	private static readonly GetDeviceName_InjectedDelegate GetDeviceName_InjectedDelegateField;

	private static readonly GetGraphicsDeviceVersion_InjectedDelegate GetGraphicsDeviceVersion_InjectedDelegateField;

	public unsafe static string operatingSystem
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1215692, RefRangeEnd = 1215695, XrefRangeStart = 1215691, XrefRangeEnd = 1215692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_operatingSystem_Public_Static_get_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
	}

	public unsafe static OperatingSystemFamily operatingSystemFamily
	{
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1215697, RefRangeEnd = 1215705, XrefRangeStart = 1215695, XrefRangeEnd = 1215697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_operatingSystemFamily_Public_Static_get_OperatingSystemFamily_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(OperatingSystemFamily*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static string deviceModel
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1215706, RefRangeEnd = 1215707, XrefRangeStart = 1215705, XrefRangeEnd = 1215706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_deviceModel_Public_Static_get_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
	}

	public unsafe static DeviceType deviceType
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1215709, RefRangeEnd = 1215710, XrefRangeStart = 1215707, XrefRangeEnd = 1215709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_deviceType_Public_Static_get_DeviceType_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(DeviceType*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static string graphicsDeviceName
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1215711, RefRangeEnd = 1215712, XrefRangeStart = 1215710, XrefRangeEnd = 1215711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_graphicsDeviceName_Public_Static_get_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
	}

	public unsafe static string graphicsDeviceVendor
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1215713, RefRangeEnd = 1215714, XrefRangeStart = 1215712, XrefRangeEnd = 1215713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_graphicsDeviceVendor_Public_Static_get_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
	}

	public unsafe static int graphicsDeviceVendorID
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1215716, RefRangeEnd = 1215718, XrefRangeStart = 1215714, XrefRangeEnd = 1215716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_graphicsDeviceVendorID_Public_Static_get_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static GraphicsDeviceType graphicsDeviceType
	{
		[CallerCount(62)]
		[CachedScanResults(RefRangeStart = 1215720, RefRangeEnd = 1215782, XrefRangeStart = 1215718, XrefRangeEnd = 1215720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_graphicsDeviceType_Public_Static_get_GraphicsDeviceType_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(GraphicsDeviceType*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static bool graphicsUVStartsAtTop
	{
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 1215784, RefRangeEnd = 1215799, XrefRangeStart = 1215782, XrefRangeEnd = 1215784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_graphicsUVStartsAtTop_Public_Static_get_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static int graphicsShaderLevel
	{
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1215801, RefRangeEnd = 1215809, XrefRangeStart = 1215799, XrefRangeEnd = 1215801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_graphicsShaderLevel_Public_Static_get_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static RenderingThreadingMode renderingThreadingMode
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1215811, RefRangeEnd = 1215812, XrefRangeStart = 1215809, XrefRangeEnd = 1215811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_renderingThreadingMode_Public_Static_get_RenderingThreadingMode_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(RenderingThreadingMode*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static FoveatedRenderingCaps foveatedRenderingCaps
	{
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1215814, RefRangeEnd = 1215818, XrefRangeStart = 1215812, XrefRangeEnd = 1215814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_foveatedRenderingCaps_Public_Static_get_FoveatedRenderingCaps_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(FoveatedRenderingCaps*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static bool hasHiddenSurfaceRemovalOnGPU
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1215820, RefRangeEnd = 1215821, XrefRangeStart = 1215818, XrefRangeEnd = 1215820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_hasHiddenSurfaceRemovalOnGPU_Public_Static_get_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static bool supportsShadows
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1215823, RefRangeEnd = 1215825, XrefRangeStart = 1215821, XrefRangeEnd = 1215823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_supportsShadows_Public_Static_get_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static CopyTextureSupport copyTextureSupport
	{
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1215827, RefRangeEnd = 1215834, XrefRangeStart = 1215825, XrefRangeEnd = 1215827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_copyTextureSupport_Public_Static_get_CopyTextureSupport_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(CopyTextureSupport*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static bool supportsComputeShaders
	{
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 1215836, RefRangeEnd = 1215849, XrefRangeStart = 1215834, XrefRangeEnd = 1215836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_supportsComputeShaders_Public_Static_get_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static bool supportsRenderTargetArrayIndexFromVertexShader
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1215851, RefRangeEnd = 1215852, XrefRangeStart = 1215849, XrefRangeEnd = 1215851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_supportsRenderTargetArrayIndexFromVertexShader_Public_Static_get_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static bool supportsInstancing
	{
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 1215854, RefRangeEnd = 1215863, XrefRangeStart = 1215852, XrefRangeEnd = 1215854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_supportsInstancing_Public_Static_get_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static int supportedRenderTargetCount
	{
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1215865, RefRangeEnd = 1215873, XrefRangeStart = 1215863, XrefRangeEnd = 1215865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_supportedRenderTargetCount_Public_Static_get_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static int supportsMultisampledTextures
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1215875, RefRangeEnd = 1215878, XrefRangeStart = 1215873, XrefRangeEnd = 1215875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_supportsMultisampledTextures_Public_Static_get_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static bool supportsMultisampledBackBuffer
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1215880, RefRangeEnd = 1215881, XrefRangeStart = 1215878, XrefRangeEnd = 1215880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_supportsMultisampledBackBuffer_Public_Static_get_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static bool supportsMultisampleAutoResolve
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1215883, RefRangeEnd = 1215885, XrefRangeStart = 1215881, XrefRangeEnd = 1215883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_supportsMultisampleAutoResolve_Public_Static_get_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static bool usesReversedZBuffer
	{
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1215887, RefRangeEnd = 1215891, XrefRangeStart = 1215885, XrefRangeEnd = 1215887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_usesReversedZBuffer_Public_Static_get_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static int maxTextureSize
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1215919, RefRangeEnd = 1215922, XrefRangeStart = 1215917, XrefRangeEnd = 1215919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_maxTextureSize_Public_Static_get_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static int maxRenderTextureSize
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1215924, RefRangeEnd = 1215926, XrefRangeStart = 1215922, XrefRangeEnd = 1215924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_maxRenderTextureSize_Internal_Static_get_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static bool supportsGraphicsFence
	{
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1215928, RefRangeEnd = 1215933, XrefRangeStart = 1215926, XrefRangeEnd = 1215928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_supportsGraphicsFence_Public_Static_get_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static long maxGraphicsBufferSize
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1215935, RefRangeEnd = 1215936, XrefRangeStart = 1215933, XrefRangeEnd = 1215935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_maxGraphicsBufferSize_Public_Static_get_Int64_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(long*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static bool usesLoadStoreActions
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1215938, RefRangeEnd = 1215939, XrefRangeStart = 1215936, XrefRangeEnd = 1215938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_usesLoadStoreActions_Public_Static_get_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static HDRDisplaySupportFlags hdrDisplaySupportFlags
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1215941, RefRangeEnd = 1215944, XrefRangeStart = 1215939, XrefRangeEnd = 1215941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_hdrDisplaySupportFlags_Public_Static_get_HDRDisplaySupportFlags_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(HDRDisplaySupportFlags*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static bool supportsMultiview
	{
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1215946, RefRangeEnd = 1215953, XrefRangeStart = 1215944, XrefRangeEnd = 1215946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_supportsMultiview_Public_Static_get_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static bool supportsStoreAndResolveAction
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1215955, RefRangeEnd = 1215956, XrefRangeStart = 1215953, XrefRangeEnd = 1215955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_supportsStoreAndResolveAction_Public_Static_get_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static bool supportsMultisampleResolveDepth
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1215958, RefRangeEnd = 1215959, XrefRangeStart = 1215956, XrefRangeEnd = 1215958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_supportsMultisampleResolveDepth_Public_Static_get_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static bool supportsMultisampleResolveStencil
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1215961, RefRangeEnd = 1215962, XrefRangeStart = 1215959, XrefRangeEnd = 1215961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_supportsMultisampleResolveStencil_Public_Static_get_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static bool supportsIndirectArgumentsBuffer
	{
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1215964, RefRangeEnd = 1215972, XrefRangeStart = 1215962, XrefRangeEnd = 1215964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_supportsIndirectArgumentsBuffer_Public_Static_get_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public static float batteryLevel => GetBatteryLevel();

	public static BatteryStatus batteryStatus => GetBatteryStatus();

	public static string processorType => GetProcessorType();

	public static string processorModel => GetProcessorModel();

	public static string processorManufacturer => GetProcessorManufacturer();

	public static int processorFrequency => GetProcessorFrequencyMHz();

	public static int processorCount => GetProcessorCount();

	public static int systemMemorySize => GetPhysicalMemoryMB();

	public static string deviceUniqueIdentifier => GetDeviceUniqueIdentifier();

	public static string deviceName => GetDeviceName();

	public static bool supportsAccelerometer => SupportsAccelerometer();

	public static bool supportsGyroscope => IsGyroAvailable();

	public static bool supportsLocationService => SupportsLocationService();

	public static bool supportsVibration => SupportsVibration();

	public static bool supportsAudio => SupportsAudio();

	public static int graphicsMemorySize => GetGraphicsMemorySize();

	public static int graphicsDeviceID => GetGraphicsDeviceID();

	public static string graphicsDeviceVersion => GetGraphicsDeviceVersion();

	public static bool graphicsMultiThreaded => GetGraphicsMultiThreaded();

	public static bool hasDynamicUniformArrayIndexingInFragmentShaders => HasDynamicUniformArrayIndexingInFragmentShaders();

	public static bool supportsRawShadowDepthSampling => SupportsRawShadowDepthSampling();

	public static bool supportsRenderTextures => true;

	public static bool supportsMotionVectors => SupportsMotionVectors();

	public static bool supportsRenderToCubemap => true;

	public static bool supportsImageEffects => true;

	public static bool supports3DTextures => Supports3DTextures();

	public static bool supportsCompressed3DTextures => SupportsCompressed3DTextures();

	public static bool supports2DArrayTextures => Supports2DArrayTextures();

	public static bool supports3DRenderTextures => Supports3DRenderTextures();

	public static bool supportsCubemapArrayTextures => SupportsCubemapArrayTextures();

	public static bool supportsAnisotropicFilter => SupportsAnisotropicFilter();

	public static bool supportsGeometryShaders => SupportsGeometryShaders();

	public static bool supportsTessellationShaders => SupportsTessellationShaders();

	public static bool supportsHardwareQuadTopology => SupportsHardwareQuadTopology();

	public static bool supports32bitsIndexBuffer => Supports32bitsIndexBuffer();

	public static bool supportsSparseTextures => SupportsSparseTextures();

	public static bool supportsSeparatedRenderTargetsBlend => SupportsSeparatedRenderTargetsBlend();

	public static int supportedRandomWriteTargetCount => SupportedRandomWriteTargetCount();

	public static bool supportsMultisampled2DArrayTextures => SupportsMultisampled2DArrayTextures();

	public static int supportsTextureWrapMirrorOnce => SupportsTextureWrapMirrorOnce();

	public static int supportsStencil => 1;

	public static NPOTSupport npotSupport => GetNPOTSupport();

	public static int maxTexture3DSize => GetMaxTexture3DSize();

	public static int maxTextureArraySlices => GetMaxTextureArraySlices();

	public static int maxCubemapSize => GetMaxCubemapSize();

	public static int maxAnisotropyLevel => GetMaxAnisotropyLevel();

	public static int maxComputeBufferInputsVertex => MaxComputeBufferInputsVertex();

	public static int maxComputeBufferInputsFragment => MaxComputeBufferInputsFragment();

	public static int maxComputeBufferInputsGeometry => MaxComputeBufferInputsGeometry();

	public static int maxComputeBufferInputsDomain => MaxComputeBufferInputsDomain();

	public static int maxComputeBufferInputsHull => MaxComputeBufferInputsHull();

	public static int maxComputeBufferInputsCompute => MaxComputeBufferInputsCompute();

	public static int maxComputeWorkGroupSize => GetMaxComputeWorkGroupSize();

	public static int maxComputeWorkGroupSizeX => GetMaxComputeWorkGroupSizeX();

	public static int maxComputeWorkGroupSizeY => GetMaxComputeWorkGroupSizeY();

	public static int maxComputeWorkGroupSizeZ => GetMaxComputeWorkGroupSizeZ();

	public static int computeSubGroupSize => GetComputeSubGroupSize();

	public static bool supportsAsyncCompute => SupportsAsyncCompute();

	public static bool supportsGpuRecorder => SupportsGpuRecorder();

	public static bool supportsAsyncGPUReadback => SupportsAsyncGPUReadback();

	public static bool supportsParallelPSOCreation => SupportsParallelPSOCreation();

	public static bool supportsRayTracingShaders => SupportsRayTracingShaders();

	public static bool supportsRayTracing => SupportsRayTracing();

	public static bool supportsInlineRayTracing => SupportsInlineRayTracing();

	public static bool supportsIndirectDispatchRays => SupportsIndirectDispatchRays();

	public static bool supportsSetConstantBuffer => SupportsSetConstantBuffer();

	public static int constantBufferOffsetAlignment => MinConstantBufferOffsetAlignment();

	public static int maxConstantBufferSize => MaxConstantBufferSize();

	public static bool minConstantBufferOffsetAlignment => false;

	public static bool hasMipMaxLevel => HasMipMaxLevel();

	public static bool supportsMipStreaming => SupportsMipStreaming();

	public static int graphicsPixelFillrate => -1;

	public static bool supportsConservativeRaster => SupportsConservativeRaster();

	public static bool supportsDepthFetchInRenderPass => SupportsDepthFetchInRenderPass();

	public static bool supportsVertexPrograms => true;

	public static bool supportsGPUFence => false;

	static SystemInfo()
	{
		Il2CppClassPointerStore<SystemInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "SystemInfo");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr);
		NativeMethodInfoPtr_get_operatingSystem_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666655);
		NativeMethodInfoPtr_get_operatingSystemFamily_Public_Static_get_OperatingSystemFamily_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666656);
		NativeMethodInfoPtr_get_deviceModel_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666657);
		NativeMethodInfoPtr_get_deviceType_Public_Static_get_DeviceType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666658);
		NativeMethodInfoPtr_get_graphicsDeviceName_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666659);
		NativeMethodInfoPtr_get_graphicsDeviceVendor_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666660);
		NativeMethodInfoPtr_get_graphicsDeviceVendorID_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666661);
		NativeMethodInfoPtr_get_graphicsDeviceType_Public_Static_get_GraphicsDeviceType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666662);
		NativeMethodInfoPtr_get_graphicsUVStartsAtTop_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666663);
		NativeMethodInfoPtr_get_graphicsShaderLevel_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666664);
		NativeMethodInfoPtr_get_renderingThreadingMode_Public_Static_get_RenderingThreadingMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666665);
		NativeMethodInfoPtr_get_foveatedRenderingCaps_Public_Static_get_FoveatedRenderingCaps_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666666);
		NativeMethodInfoPtr_get_hasHiddenSurfaceRemovalOnGPU_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666667);
		NativeMethodInfoPtr_get_supportsShadows_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666668);
		NativeMethodInfoPtr_get_copyTextureSupport_Public_Static_get_CopyTextureSupport_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666669);
		NativeMethodInfoPtr_get_supportsComputeShaders_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666670);
		NativeMethodInfoPtr_get_supportsRenderTargetArrayIndexFromVertexShader_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666671);
		NativeMethodInfoPtr_get_supportsInstancing_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666672);
		NativeMethodInfoPtr_get_supportedRenderTargetCount_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666673);
		NativeMethodInfoPtr_get_supportsMultisampledTextures_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666674);
		NativeMethodInfoPtr_get_supportsMultisampledBackBuffer_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666675);
		NativeMethodInfoPtr_get_supportsMultisampleAutoResolve_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666676);
		NativeMethodInfoPtr_get_usesReversedZBuffer_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666677);
		NativeMethodInfoPtr_IsValidEnumValue_Private_Static_Boolean_Enum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666678);
		NativeMethodInfoPtr_SupportsRenderTextureFormat_Public_Static_Boolean_RenderTextureFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666679);
		NativeMethodInfoPtr_SupportsTextureFormat_Public_Static_Boolean_TextureFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666680);
		NativeMethodInfoPtr_get_maxTextureSize_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666681);
		NativeMethodInfoPtr_get_maxRenderTextureSize_Internal_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666682);
		NativeMethodInfoPtr_get_supportsGraphicsFence_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666683);
		NativeMethodInfoPtr_get_maxGraphicsBufferSize_Public_Static_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666684);
		NativeMethodInfoPtr_get_usesLoadStoreActions_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666685);
		NativeMethodInfoPtr_get_hdrDisplaySupportFlags_Public_Static_get_HDRDisplaySupportFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666686);
		NativeMethodInfoPtr_get_supportsMultiview_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666687);
		NativeMethodInfoPtr_get_supportsStoreAndResolveAction_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666688);
		NativeMethodInfoPtr_get_supportsMultisampleResolveDepth_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666689);
		NativeMethodInfoPtr_get_supportsMultisampleResolveStencil_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666690);
		NativeMethodInfoPtr_get_supportsIndirectArgumentsBuffer_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666691);
		NativeMethodInfoPtr_GetOperatingSystem_Private_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666692);
		NativeMethodInfoPtr_GetOperatingSystemFamily_Private_Static_OperatingSystemFamily_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666693);
		NativeMethodInfoPtr_GetDeviceModel_Private_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666694);
		NativeMethodInfoPtr_GetDeviceType_Private_Static_DeviceType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666695);
		NativeMethodInfoPtr_GetGraphicsDeviceName_Private_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666696);
		NativeMethodInfoPtr_GetGraphicsDeviceVendor_Private_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666697);
		NativeMethodInfoPtr_GetGraphicsDeviceVendorID_Private_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666698);
		NativeMethodInfoPtr_GetGraphicsDeviceType_Private_Static_GraphicsDeviceType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666699);
		NativeMethodInfoPtr_GetGraphicsUVStartsAtTop_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666700);
		NativeMethodInfoPtr_GetGraphicsShaderLevel_Private_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666701);
		NativeMethodInfoPtr_GetRenderingThreadingMode_Private_Static_RenderingThreadingMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666702);
		NativeMethodInfoPtr_GetFoveatedRenderingCaps_Private_Static_FoveatedRenderingCaps_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666703);
		NativeMethodInfoPtr_HasHiddenSurfaceRemovalOnGPU_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666704);
		NativeMethodInfoPtr_SupportsShadows_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666705);
		NativeMethodInfoPtr_GetCopyTextureSupport_Private_Static_CopyTextureSupport_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666706);
		NativeMethodInfoPtr_SupportsComputeShaders_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666707);
		NativeMethodInfoPtr_SupportsRenderTargetArrayIndexFromVertexShader_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666708);
		NativeMethodInfoPtr_SupportsInstancing_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666709);
		NativeMethodInfoPtr_SupportedRenderTargetCount_Private_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666710);
		NativeMethodInfoPtr_SupportsMultisampledTextures_Private_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666711);
		NativeMethodInfoPtr_SupportsMultisampledBackBuffer_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666712);
		NativeMethodInfoPtr_SupportsMultisampleAutoResolve_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666713);
		NativeMethodInfoPtr_UsesReversedZBuffer_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666714);
		NativeMethodInfoPtr_HasRenderTextureNative_Private_Static_Boolean_RenderTextureFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666715);
		NativeMethodInfoPtr_SupportsTextureFormatNative_Private_Static_Boolean_TextureFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666716);
		NativeMethodInfoPtr_GetMaxTextureSize_Private_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666717);
		NativeMethodInfoPtr_GetMaxRenderTextureSize_Private_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666718);
		NativeMethodInfoPtr_SupportsGPUFence_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666719);
		NativeMethodInfoPtr_MaxGraphicsBufferSize_Private_Static_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666720);
		NativeMethodInfoPtr_IsFormatSupported_Public_Static_Boolean_GraphicsFormat_GraphicsFormatUsage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666721);
		NativeMethodInfoPtr_GetCompatibleFormat_Public_Static_GraphicsFormat_GraphicsFormat_GraphicsFormatUsage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666722);
		NativeMethodInfoPtr_GetGraphicsFormat_Public_Static_GraphicsFormat_DefaultFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666723);
		NativeMethodInfoPtr_GetRenderTextureSupportedMSAASampleCount_Public_Static_Int32_RenderTextureDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666724);
		NativeMethodInfoPtr_UsesLoadStoreActions_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666725);
		NativeMethodInfoPtr_GetHDRDisplaySupportFlags_Private_Static_HDRDisplaySupportFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666726);
		NativeMethodInfoPtr_SupportsMultiview_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666727);
		NativeMethodInfoPtr_SupportsStoreAndResolveAction_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666728);
		NativeMethodInfoPtr_SupportsMultisampleResolveDepth_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666729);
		NativeMethodInfoPtr_SupportsMultisampleResolveStencil_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666730);
		NativeMethodInfoPtr_SupportsIndirectArgumentsBuffer_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666731);
		NativeMethodInfoPtr_GetOperatingSystem_Injected_Private_Static_Void_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666732);
		NativeMethodInfoPtr_GetDeviceModel_Injected_Private_Static_Void_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666733);
		NativeMethodInfoPtr_GetGraphicsDeviceName_Injected_Private_Static_Void_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666734);
		NativeMethodInfoPtr_GetGraphicsDeviceVendor_Injected_Private_Static_Void_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666735);
		NativeMethodInfoPtr_GetRenderTextureSupportedMSAASampleCount_Injected_Private_Static_Int32_byref_RenderTextureDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemInfo>.NativeClassPtr, 100666736);
		GetBatteryLevelDelegateField = IL2CPP.ResolveICall<GetBatteryLevelDelegate>("UnityEngine.SystemInfo::GetBatteryLevel");
		GetBatteryStatusDelegateField = IL2CPP.ResolveICall<GetBatteryStatusDelegate>("UnityEngine.SystemInfo::GetBatteryStatus");
		GetProcessorFrequencyMHzDelegateField = IL2CPP.ResolveICall<GetProcessorFrequencyMHzDelegate>("UnityEngine.SystemInfo::GetProcessorFrequencyMHz");
		GetProcessorCountDelegateField = IL2CPP.ResolveICall<GetProcessorCountDelegate>("UnityEngine.SystemInfo::GetProcessorCount");
		GetPhysicalMemoryMBDelegateField = IL2CPP.ResolveICall<GetPhysicalMemoryMBDelegate>("UnityEngine.SystemInfo::GetPhysicalMemoryMB");
		SupportsAccelerometerDelegateField = IL2CPP.ResolveICall<SupportsAccelerometerDelegate>("UnityEngine.SystemInfo::SupportsAccelerometer");
		IsGyroAvailableDelegateField = IL2CPP.ResolveICall<IsGyroAvailableDelegate>("UnityEngine.SystemInfo::IsGyroAvailable");
		SupportsLocationServiceDelegateField = IL2CPP.ResolveICall<SupportsLocationServiceDelegate>("UnityEngine.SystemInfo::SupportsLocationService");
		SupportsVibrationDelegateField = IL2CPP.ResolveICall<SupportsVibrationDelegate>("UnityEngine.SystemInfo::SupportsVibration");
		SupportsAudioDelegateField = IL2CPP.ResolveICall<SupportsAudioDelegate>("UnityEngine.SystemInfo::SupportsAudio");
		GetGraphicsMemorySizeDelegateField = IL2CPP.ResolveICall<GetGraphicsMemorySizeDelegate>("UnityEngine.SystemInfo::GetGraphicsMemorySize");
		GetGraphicsDeviceIDDelegateField = IL2CPP.ResolveICall<GetGraphicsDeviceIDDelegate>("UnityEngine.SystemInfo::GetGraphicsDeviceID");
		GetGraphicsMultiThreadedDelegateField = IL2CPP.ResolveICall<GetGraphicsMultiThreadedDelegate>("UnityEngine.SystemInfo::GetGraphicsMultiThreaded");
		HasDynamicUniformArrayIndexingInFragmentShadersDelegateField = IL2CPP.ResolveICall<HasDynamicUniformArrayIndexingInFragmentShadersDelegate>("UnityEngine.SystemInfo::HasDynamicUniformArrayIndexingInFragmentShaders");
		SupportsRawShadowDepthSamplingDelegateField = IL2CPP.ResolveICall<SupportsRawShadowDepthSamplingDelegate>("UnityEngine.SystemInfo::SupportsRawShadowDepthSampling");
		SupportsMotionVectorsDelegateField = IL2CPP.ResolveICall<SupportsMotionVectorsDelegate>("UnityEngine.SystemInfo::SupportsMotionVectors");
		Supports3DTexturesDelegateField = IL2CPP.ResolveICall<Supports3DTexturesDelegate>("UnityEngine.SystemInfo::Supports3DTextures");
		SupportsCompressed3DTexturesDelegateField = IL2CPP.ResolveICall<SupportsCompressed3DTexturesDelegate>("UnityEngine.SystemInfo::SupportsCompressed3DTextures");
		Supports2DArrayTexturesDelegateField = IL2CPP.ResolveICall<Supports2DArrayTexturesDelegate>("UnityEngine.SystemInfo::Supports2DArrayTextures");
		Supports3DRenderTexturesDelegateField = IL2CPP.ResolveICall<Supports3DRenderTexturesDelegate>("UnityEngine.SystemInfo::Supports3DRenderTextures");
		SupportsCubemapArrayTexturesDelegateField = IL2CPP.ResolveICall<SupportsCubemapArrayTexturesDelegate>("UnityEngine.SystemInfo::SupportsCubemapArrayTextures");
		SupportsAnisotropicFilterDelegateField = IL2CPP.ResolveICall<SupportsAnisotropicFilterDelegate>("UnityEngine.SystemInfo::SupportsAnisotropicFilter");
		SupportsGeometryShadersDelegateField = IL2CPP.ResolveICall<SupportsGeometryShadersDelegate>("UnityEngine.SystemInfo::SupportsGeometryShaders");
		SupportsTessellationShadersDelegateField = IL2CPP.ResolveICall<SupportsTessellationShadersDelegate>("UnityEngine.SystemInfo::SupportsTessellationShaders");
		SupportsHardwareQuadTopologyDelegateField = IL2CPP.ResolveICall<SupportsHardwareQuadTopologyDelegate>("UnityEngine.SystemInfo::SupportsHardwareQuadTopology");
		Supports32bitsIndexBufferDelegateField = IL2CPP.ResolveICall<Supports32bitsIndexBufferDelegate>("UnityEngine.SystemInfo::Supports32bitsIndexBuffer");
		SupportsSparseTexturesDelegateField = IL2CPP.ResolveICall<SupportsSparseTexturesDelegate>("UnityEngine.SystemInfo::SupportsSparseTextures");
		SupportsSeparatedRenderTargetsBlendDelegateField = IL2CPP.ResolveICall<SupportsSeparatedRenderTargetsBlendDelegate>("UnityEngine.SystemInfo::SupportsSeparatedRenderTargetsBlend");
		SupportedRandomWriteTargetCountDelegateField = IL2CPP.ResolveICall<SupportedRandomWriteTargetCountDelegate>("UnityEngine.SystemInfo::SupportedRandomWriteTargetCount");
		MaxComputeBufferInputsVertexDelegateField = IL2CPP.ResolveICall<MaxComputeBufferInputsVertexDelegate>("UnityEngine.SystemInfo::MaxComputeBufferInputsVertex");
		MaxComputeBufferInputsFragmentDelegateField = IL2CPP.ResolveICall<MaxComputeBufferInputsFragmentDelegate>("UnityEngine.SystemInfo::MaxComputeBufferInputsFragment");
		MaxComputeBufferInputsGeometryDelegateField = IL2CPP.ResolveICall<MaxComputeBufferInputsGeometryDelegate>("UnityEngine.SystemInfo::MaxComputeBufferInputsGeometry");
		MaxComputeBufferInputsDomainDelegateField = IL2CPP.ResolveICall<MaxComputeBufferInputsDomainDelegate>("UnityEngine.SystemInfo::MaxComputeBufferInputsDomain");
		MaxComputeBufferInputsHullDelegateField = IL2CPP.ResolveICall<MaxComputeBufferInputsHullDelegate>("UnityEngine.SystemInfo::MaxComputeBufferInputsHull");
		MaxComputeBufferInputsComputeDelegateField = IL2CPP.ResolveICall<MaxComputeBufferInputsComputeDelegate>("UnityEngine.SystemInfo::MaxComputeBufferInputsCompute");
		SupportsMultisampled2DArrayTexturesDelegateField = IL2CPP.ResolveICall<SupportsMultisampled2DArrayTexturesDelegate>("UnityEngine.SystemInfo::SupportsMultisampled2DArrayTextures");
		SupportsTextureWrapMirrorOnceDelegateField = IL2CPP.ResolveICall<SupportsTextureWrapMirrorOnceDelegate>("UnityEngine.SystemInfo::SupportsTextureWrapMirrorOnce");
		SupportsBlendingOnRenderTextureFormatNativeDelegateField = IL2CPP.ResolveICall<SupportsBlendingOnRenderTextureFormatNativeDelegate>("UnityEngine.SystemInfo::SupportsBlendingOnRenderTextureFormatNative");
		SupportsRandomWriteOnRenderTextureFormatNativeDelegateField = IL2CPP.ResolveICall<SupportsRandomWriteOnRenderTextureFormatNativeDelegate>("UnityEngine.SystemInfo::SupportsRandomWriteOnRenderTextureFormatNative");
		SupportsVertexAttributeFormatNativeDelegateField = IL2CPP.ResolveICall<SupportsVertexAttributeFormatNativeDelegate>("UnityEngine.SystemInfo::SupportsVertexAttributeFormatNative");
		GetNPOTSupportDelegateField = IL2CPP.ResolveICall<GetNPOTSupportDelegate>("UnityEngine.SystemInfo::GetNPOTSupport");
		GetMaxTexture3DSizeDelegateField = IL2CPP.ResolveICall<GetMaxTexture3DSizeDelegate>("UnityEngine.SystemInfo::GetMaxTexture3DSize");
		GetMaxTextureArraySlicesDelegateField = IL2CPP.ResolveICall<GetMaxTextureArraySlicesDelegate>("UnityEngine.SystemInfo::GetMaxTextureArraySlices");
		GetMaxCubemapSizeDelegateField = IL2CPP.ResolveICall<GetMaxCubemapSizeDelegate>("UnityEngine.SystemInfo::GetMaxCubemapSize");
		GetMaxAnisotropyLevelDelegateField = IL2CPP.ResolveICall<GetMaxAnisotropyLevelDelegate>("UnityEngine.SystemInfo::GetMaxAnisotropyLevel");
		GetMaxComputeWorkGroupSizeDelegateField = IL2CPP.ResolveICall<GetMaxComputeWorkGroupSizeDelegate>("UnityEngine.SystemInfo::GetMaxComputeWorkGroupSize");
		GetMaxComputeWorkGroupSizeXDelegateField = IL2CPP.ResolveICall<GetMaxComputeWorkGroupSizeXDelegate>("UnityEngine.SystemInfo::GetMaxComputeWorkGroupSizeX");
		GetMaxComputeWorkGroupSizeYDelegateField = IL2CPP.ResolveICall<GetMaxComputeWorkGroupSizeYDelegate>("UnityEngine.SystemInfo::GetMaxComputeWorkGroupSizeY");
		GetMaxComputeWorkGroupSizeZDelegateField = IL2CPP.ResolveICall<GetMaxComputeWorkGroupSizeZDelegate>("UnityEngine.SystemInfo::GetMaxComputeWorkGroupSizeZ");
		GetComputeSubGroupSizeDelegateField = IL2CPP.ResolveICall<GetComputeSubGroupSizeDelegate>("UnityEngine.SystemInfo::GetComputeSubGroupSize");
		SupportsAsyncComputeDelegateField = IL2CPP.ResolveICall<SupportsAsyncComputeDelegate>("UnityEngine.SystemInfo::SupportsAsyncCompute");
		SupportsGpuRecorderDelegateField = IL2CPP.ResolveICall<SupportsGpuRecorderDelegate>("UnityEngine.SystemInfo::SupportsGpuRecorder");
		SupportsAsyncGPUReadbackDelegateField = IL2CPP.ResolveICall<SupportsAsyncGPUReadbackDelegate>("UnityEngine.SystemInfo::SupportsAsyncGPUReadback");
		SupportsParallelPSOCreationDelegateField = IL2CPP.ResolveICall<SupportsParallelPSOCreationDelegate>("UnityEngine.SystemInfo::SupportsParallelPSOCreation");
		SupportsRayTracingDelegateField = IL2CPP.ResolveICall<SupportsRayTracingDelegate>("UnityEngine.SystemInfo::SupportsRayTracing");
		SupportsRayTracingShadersDelegateField = IL2CPP.ResolveICall<SupportsRayTracingShadersDelegate>("UnityEngine.SystemInfo::SupportsRayTracingShaders");
		SupportsInlineRayTracingDelegateField = IL2CPP.ResolveICall<SupportsInlineRayTracingDelegate>("UnityEngine.SystemInfo::SupportsInlineRayTracing");
		SupportsIndirectDispatchRaysDelegateField = IL2CPP.ResolveICall<SupportsIndirectDispatchRaysDelegate>("UnityEngine.SystemInfo::SupportsIndirectDispatchRays");
		SupportsSetConstantBufferDelegateField = IL2CPP.ResolveICall<SupportsSetConstantBufferDelegate>("UnityEngine.SystemInfo::SupportsSetConstantBuffer");
		MinConstantBufferOffsetAlignmentDelegateField = IL2CPP.ResolveICall<MinConstantBufferOffsetAlignmentDelegate>("UnityEngine.SystemInfo::MinConstantBufferOffsetAlignment");
		MaxConstantBufferSizeDelegateField = IL2CPP.ResolveICall<MaxConstantBufferSizeDelegate>("UnityEngine.SystemInfo::MaxConstantBufferSize");
		HasMipMaxLevelDelegateField = IL2CPP.ResolveICall<HasMipMaxLevelDelegate>("UnityEngine.SystemInfo::HasMipMaxLevel");
		SupportsMipStreamingDelegateField = IL2CPP.ResolveICall<SupportsMipStreamingDelegate>("UnityEngine.SystemInfo::SupportsMipStreaming");
		SupportsConservativeRasterDelegateField = IL2CPP.ResolveICall<SupportsConservativeRasterDelegate>("UnityEngine.SystemInfo::SupportsConservativeRaster");
		SupportsDepthFetchInRenderPassDelegateField = IL2CPP.ResolveICall<SupportsDepthFetchInRenderPassDelegate>("UnityEngine.SystemInfo::SupportsDepthFetchInRenderPass");
		GetProcessorType_InjectedDelegateField = IL2CPP.ResolveICall<GetProcessorType_InjectedDelegate>("UnityEngine.SystemInfo::GetProcessorType_Injected");
		GetProcessorModel_InjectedDelegateField = IL2CPP.ResolveICall<GetProcessorModel_InjectedDelegate>("UnityEngine.SystemInfo::GetProcessorModel_Injected");
		GetProcessorManufacturer_InjectedDelegateField = IL2CPP.ResolveICall<GetProcessorManufacturer_InjectedDelegate>("UnityEngine.SystemInfo::GetProcessorManufacturer_Injected");
		GetDeviceUniqueIdentifier_InjectedDelegateField = IL2CPP.ResolveICall<GetDeviceUniqueIdentifier_InjectedDelegate>("UnityEngine.SystemInfo::GetDeviceUniqueIdentifier_Injected");
		GetDeviceName_InjectedDelegateField = IL2CPP.ResolveICall<GetDeviceName_InjectedDelegate>("UnityEngine.SystemInfo::GetDeviceName_Injected");
		GetGraphicsDeviceVersion_InjectedDelegateField = IL2CPP.ResolveICall<GetGraphicsDeviceVersion_InjectedDelegate>("UnityEngine.SystemInfo::GetGraphicsDeviceVersion_Injected");
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1215891, XrefRangeEnd = 1215895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsValidEnumValue(Il2CppSystem.Enum value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsValidEnumValue_Private_Static_Boolean_Enum_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1215904, RefRangeEnd = 1215907, XrefRangeStart = 1215895, XrefRangeEnd = 1215904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool SupportsRenderTextureFormat(RenderTextureFormat format)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&format);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SupportsRenderTextureFormat_Public_Static_Boolean_RenderTextureFormat_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1215916, RefRangeEnd = 1215917, XrefRangeStart = 1215907, XrefRangeEnd = 1215916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool SupportsTextureFormat(TextureFormat format)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&format);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SupportsTextureFormat_Public_Static_Boolean_TextureFormat_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1215977, RefRangeEnd = 1215978, XrefRangeStart = 1215972, XrefRangeEnd = 1215977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetOperatingSystem()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetOperatingSystem_Private_Static_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 1215697, RefRangeEnd = 1215705, XrefRangeStart = 1215697, XrefRangeEnd = 1215705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static OperatingSystemFamily GetOperatingSystemFamily()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetOperatingSystemFamily_Private_Static_OperatingSystemFamily_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(OperatingSystemFamily*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1215983, RefRangeEnd = 1215984, XrefRangeStart = 1215978, XrefRangeEnd = 1215983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetDeviceModel()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDeviceModel_Private_Static_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1215709, RefRangeEnd = 1215710, XrefRangeStart = 1215709, XrefRangeEnd = 1215710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static DeviceType GetDeviceType()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDeviceType_Private_Static_DeviceType_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(DeviceType*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1215989, RefRangeEnd = 1215990, XrefRangeStart = 1215984, XrefRangeEnd = 1215989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetGraphicsDeviceName()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetGraphicsDeviceName_Private_Static_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1215995, RefRangeEnd = 1215996, XrefRangeStart = 1215990, XrefRangeEnd = 1215995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetGraphicsDeviceVendor()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetGraphicsDeviceVendor_Private_Static_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1215716, RefRangeEnd = 1215718, XrefRangeStart = 1215716, XrefRangeEnd = 1215718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetGraphicsDeviceVendorID()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetGraphicsDeviceVendorID_Private_Static_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(62)]
	[CachedScanResults(RefRangeStart = 1215720, RefRangeEnd = 1215782, XrefRangeStart = 1215720, XrefRangeEnd = 1215782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static GraphicsDeviceType GetGraphicsDeviceType()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetGraphicsDeviceType_Private_Static_GraphicsDeviceType_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(GraphicsDeviceType*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(15)]
	[CachedScanResults(RefRangeStart = 1215784, RefRangeEnd = 1215799, XrefRangeStart = 1215784, XrefRangeEnd = 1215799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool GetGraphicsUVStartsAtTop()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetGraphicsUVStartsAtTop_Private_Static_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 1215801, RefRangeEnd = 1215809, XrefRangeStart = 1215801, XrefRangeEnd = 1215809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetGraphicsShaderLevel()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetGraphicsShaderLevel_Private_Static_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1215811, RefRangeEnd = 1215812, XrefRangeStart = 1215811, XrefRangeEnd = 1215812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static RenderingThreadingMode GetRenderingThreadingMode()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRenderingThreadingMode_Private_Static_RenderingThreadingMode_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(RenderingThreadingMode*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1215814, RefRangeEnd = 1215818, XrefRangeStart = 1215814, XrefRangeEnd = 1215818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static FoveatedRenderingCaps GetFoveatedRenderingCaps()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFoveatedRenderingCaps_Private_Static_FoveatedRenderingCaps_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(FoveatedRenderingCaps*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1215820, RefRangeEnd = 1215821, XrefRangeStart = 1215820, XrefRangeEnd = 1215821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool HasHiddenSurfaceRemovalOnGPU()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasHiddenSurfaceRemovalOnGPU_Private_Static_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1215823, RefRangeEnd = 1215825, XrefRangeStart = 1215823, XrefRangeEnd = 1215825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool SupportsShadows()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SupportsShadows_Private_Static_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 1215827, RefRangeEnd = 1215834, XrefRangeStart = 1215827, XrefRangeEnd = 1215834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static CopyTextureSupport GetCopyTextureSupport()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCopyTextureSupport_Private_Static_CopyTextureSupport_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(CopyTextureSupport*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(13)]
	[CachedScanResults(RefRangeStart = 1215836, RefRangeEnd = 1215849, XrefRangeStart = 1215836, XrefRangeEnd = 1215849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool SupportsComputeShaders()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SupportsComputeShaders_Private_Static_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1215851, RefRangeEnd = 1215852, XrefRangeStart = 1215851, XrefRangeEnd = 1215852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool SupportsRenderTargetArrayIndexFromVertexShader()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SupportsRenderTargetArrayIndexFromVertexShader_Private_Static_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 1215854, RefRangeEnd = 1215863, XrefRangeStart = 1215854, XrefRangeEnd = 1215863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool SupportsInstancing()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SupportsInstancing_Private_Static_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 1215865, RefRangeEnd = 1215873, XrefRangeStart = 1215865, XrefRangeEnd = 1215873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int SupportedRenderTargetCount()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SupportedRenderTargetCount_Private_Static_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1215875, RefRangeEnd = 1215878, XrefRangeStart = 1215875, XrefRangeEnd = 1215878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int SupportsMultisampledTextures()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SupportsMultisampledTextures_Private_Static_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1215880, RefRangeEnd = 1215881, XrefRangeStart = 1215880, XrefRangeEnd = 1215881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool SupportsMultisampledBackBuffer()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SupportsMultisampledBackBuffer_Private_Static_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1215883, RefRangeEnd = 1215885, XrefRangeStart = 1215883, XrefRangeEnd = 1215885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool SupportsMultisampleAutoResolve()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SupportsMultisampleAutoResolve_Private_Static_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1215887, RefRangeEnd = 1215891, XrefRangeStart = 1215887, XrefRangeEnd = 1215891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool UsesReversedZBuffer()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UsesReversedZBuffer_Private_Static_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1215996, XrefRangeEnd = 1215998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool HasRenderTextureNative(RenderTextureFormat format)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&format);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasRenderTextureNative_Private_Static_Boolean_RenderTextureFormat_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1215998, XrefRangeEnd = 1216000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool SupportsTextureFormatNative(TextureFormat format)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&format);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SupportsTextureFormatNative_Private_Static_Boolean_TextureFormat_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1215919, RefRangeEnd = 1215922, XrefRangeStart = 1215919, XrefRangeEnd = 1215922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetMaxTextureSize()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMaxTextureSize_Private_Static_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1215924, RefRangeEnd = 1215926, XrefRangeStart = 1215924, XrefRangeEnd = 1215926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetMaxRenderTextureSize()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMaxRenderTextureSize_Private_Static_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1215928, RefRangeEnd = 1215933, XrefRangeStart = 1215928, XrefRangeEnd = 1215933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool SupportsGPUFence()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SupportsGPUFence_Private_Static_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1215935, RefRangeEnd = 1215936, XrefRangeStart = 1215935, XrefRangeEnd = 1215936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static long MaxGraphicsBufferSize()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MaxGraphicsBufferSize_Private_Static_Int64_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(long*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(34)]
	[CachedScanResults(RefRangeStart = 1216002, RefRangeEnd = 1216036, XrefRangeStart = 1216000, XrefRangeEnd = 1216002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsFormatSupported(GraphicsFormat format, GraphicsFormatUsage usage)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&format);
		*(GraphicsFormatUsage**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &usage;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsFormatSupported_Public_Static_Boolean_GraphicsFormat_GraphicsFormatUsage_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1216038, RefRangeEnd = 1216040, XrefRangeStart = 1216036, XrefRangeEnd = 1216038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static GraphicsFormat GetCompatibleFormat(GraphicsFormat format, GraphicsFormatUsage usage)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&format);
		*(GraphicsFormatUsage**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &usage;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCompatibleFormat_Public_Static_GraphicsFormat_GraphicsFormat_GraphicsFormatUsage_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(GraphicsFormat*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(21)]
	[CachedScanResults(RefRangeStart = 1216042, RefRangeEnd = 1216063, XrefRangeStart = 1216040, XrefRangeEnd = 1216042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static GraphicsFormat GetGraphicsFormat(DefaultFormat format)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&format);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetGraphicsFormat_Public_Static_GraphicsFormat_DefaultFormat_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(GraphicsFormat*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1216065, RefRangeEnd = 1216066, XrefRangeStart = 1216063, XrefRangeEnd = 1216065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetRenderTextureSupportedMSAASampleCount(RenderTextureDescriptor desc)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&desc);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRenderTextureSupportedMSAASampleCount_Public_Static_Int32_RenderTextureDescriptor_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1215938, RefRangeEnd = 1215939, XrefRangeStart = 1215938, XrefRangeEnd = 1215939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool UsesLoadStoreActions()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UsesLoadStoreActions_Private_Static_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1215941, RefRangeEnd = 1215944, XrefRangeStart = 1215941, XrefRangeEnd = 1215944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static HDRDisplaySupportFlags GetHDRDisplaySupportFlags()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHDRDisplaySupportFlags_Private_Static_HDRDisplaySupportFlags_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(HDRDisplaySupportFlags*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 1215946, RefRangeEnd = 1215953, XrefRangeStart = 1215946, XrefRangeEnd = 1215953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool SupportsMultiview()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SupportsMultiview_Private_Static_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1215955, RefRangeEnd = 1215956, XrefRangeStart = 1215955, XrefRangeEnd = 1215956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool SupportsStoreAndResolveAction()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SupportsStoreAndResolveAction_Private_Static_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1215958, RefRangeEnd = 1215959, XrefRangeStart = 1215958, XrefRangeEnd = 1215959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool SupportsMultisampleResolveDepth()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SupportsMultisampleResolveDepth_Private_Static_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1215961, RefRangeEnd = 1215962, XrefRangeStart = 1215961, XrefRangeEnd = 1215962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool SupportsMultisampleResolveStencil()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SupportsMultisampleResolveStencil_Private_Static_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 1215964, RefRangeEnd = 1215972, XrefRangeStart = 1215964, XrefRangeEnd = 1215972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool SupportsIndirectArgumentsBuffer()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SupportsIndirectArgumentsBuffer_Private_Static_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1216066, XrefRangeEnd = 1216068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetOperatingSystem_Injected(out ManagedSpanWrapper ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetOperatingSystem_Injected_Private_Static_Void_byref_ManagedSpanWrapper_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1216068, XrefRangeEnd = 1216070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetDeviceModel_Injected(out ManagedSpanWrapper ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDeviceModel_Injected_Private_Static_Void_byref_ManagedSpanWrapper_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1216070, XrefRangeEnd = 1216072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetGraphicsDeviceName_Injected(out ManagedSpanWrapper ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetGraphicsDeviceName_Injected_Private_Static_Void_byref_ManagedSpanWrapper_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1216072, XrefRangeEnd = 1216074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetGraphicsDeviceVendor_Injected(out ManagedSpanWrapper ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetGraphicsDeviceVendor_Injected_Private_Static_Void_byref_ManagedSpanWrapper_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1216074, XrefRangeEnd = 1216076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetRenderTextureSupportedMSAASampleCount_Injected([In] ref RenderTextureDescriptor desc)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref desc);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRenderTextureSupportedMSAASampleCount_Injected_Private_Static_Int32_byref_RenderTextureDescriptor_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public SystemInfo(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public static bool SupportsBlendingOnRenderTextureFormat(RenderTextureFormat format)
	{
		if (!IsValidEnumValue((Il2CppSystem.Enum)(object)format))
		{
			throw new Il2CppSystem.ArgumentException("Failed SupportsBlendingOnRenderTextureFormat; format is not a valid RenderTextureFormat");
		}
		return SupportsBlendingOnRenderTextureFormatNative(format);
	}

	public static bool SupportsRandomWriteOnRenderTextureFormat(RenderTextureFormat format)
	{
		if (!IsValidEnumValue((Il2CppSystem.Enum)(object)format))
		{
			throw new Il2CppSystem.ArgumentException("Failed SupportsRandomWriteOnRenderTextureFormat; format is not a valid RenderTextureFormat");
		}
		return SupportsRandomWriteOnRenderTextureFormatNative(format);
	}

	public static bool SupportsVertexAttributeFormat(VertexAttributeFormat format, int dimension)
	{
		if (!IsValidEnumValue((Il2CppSystem.Enum)(object)format))
		{
			throw new Il2CppSystem.ArgumentException("Failed SupportsVertexAttributeFormat; format is not a valid VertexAttributeFormat");
		}
		if (dimension < 1 || dimension > 4)
		{
			throw new Il2CppSystem.ArgumentException("Failed SupportsVertexAttributeFormat; dimension must be in 1..4 range");
		}
		return SupportsVertexAttributeFormatNative(format, dimension);
	}

	public static float GetBatteryLevel()
	{
		return GetBatteryLevelDelegateField();
	}

	public static BatteryStatus GetBatteryStatus()
	{
		return GetBatteryStatusDelegateField();
	}

	public static string GetProcessorType()
	{
		Unsafe.SkipInit(out ManagedSpanWrapper ret);
		string stringAndDispose;
		try
		{
			GetProcessorType_Injected(out ret);
		}
		finally
		{
			stringAndDispose = OutStringMarshaller.GetStringAndDispose(ret);
		}
		return stringAndDispose;
	}

	public static string GetProcessorModel()
	{
		Unsafe.SkipInit(out ManagedSpanWrapper ret);
		string stringAndDispose;
		try
		{
			GetProcessorModel_Injected(out ret);
		}
		finally
		{
			stringAndDispose = OutStringMarshaller.GetStringAndDispose(ret);
		}
		return stringAndDispose;
	}

	public static string GetProcessorManufacturer()
	{
		Unsafe.SkipInit(out ManagedSpanWrapper ret);
		string stringAndDispose;
		try
		{
			GetProcessorManufacturer_Injected(out ret);
		}
		finally
		{
			stringAndDispose = OutStringMarshaller.GetStringAndDispose(ret);
		}
		return stringAndDispose;
	}

	public static int GetProcessorFrequencyMHz()
	{
		return GetProcessorFrequencyMHzDelegateField();
	}

	public static int GetProcessorCount()
	{
		return GetProcessorCountDelegateField();
	}

	public static int GetPhysicalMemoryMB()
	{
		return GetPhysicalMemoryMBDelegateField();
	}

	public static string GetDeviceUniqueIdentifier()
	{
		Unsafe.SkipInit(out ManagedSpanWrapper ret);
		string stringAndDispose;
		try
		{
			GetDeviceUniqueIdentifier_Injected(out ret);
		}
		finally
		{
			stringAndDispose = OutStringMarshaller.GetStringAndDispose(ret);
		}
		return stringAndDispose;
	}

	public static string GetDeviceName()
	{
		Unsafe.SkipInit(out ManagedSpanWrapper ret);
		string stringAndDispose;
		try
		{
			GetDeviceName_Injected(out ret);
		}
		finally
		{
			stringAndDispose = OutStringMarshaller.GetStringAndDispose(ret);
		}
		return stringAndDispose;
	}

	public static bool SupportsAccelerometer()
	{
		return SupportsAccelerometerDelegateField();
	}

	public static bool IsGyroAvailable()
	{
		return IsGyroAvailableDelegateField();
	}

	public static bool SupportsLocationService()
	{
		return SupportsLocationServiceDelegateField();
	}

	public static bool SupportsVibration()
	{
		return SupportsVibrationDelegateField();
	}

	public static bool SupportsAudio()
	{
		return SupportsAudioDelegateField();
	}

	public static int GetGraphicsMemorySize()
	{
		return GetGraphicsMemorySizeDelegateField();
	}

	public static int GetGraphicsDeviceID()
	{
		return GetGraphicsDeviceIDDelegateField();
	}

	public static string GetGraphicsDeviceVersion()
	{
		Unsafe.SkipInit(out ManagedSpanWrapper ret);
		string stringAndDispose;
		try
		{
			GetGraphicsDeviceVersion_Injected(out ret);
		}
		finally
		{
			stringAndDispose = OutStringMarshaller.GetStringAndDispose(ret);
		}
		return stringAndDispose;
	}

	public static bool GetGraphicsMultiThreaded()
	{
		return GetGraphicsMultiThreadedDelegateField();
	}

	public static bool HasDynamicUniformArrayIndexingInFragmentShaders()
	{
		return HasDynamicUniformArrayIndexingInFragmentShadersDelegateField();
	}

	public static bool SupportsRawShadowDepthSampling()
	{
		return SupportsRawShadowDepthSamplingDelegateField();
	}

	public static bool SupportsMotionVectors()
	{
		return SupportsMotionVectorsDelegateField();
	}

	public static bool Supports3DTextures()
	{
		return Supports3DTexturesDelegateField();
	}

	public static bool SupportsCompressed3DTextures()
	{
		return SupportsCompressed3DTexturesDelegateField();
	}

	public static bool Supports2DArrayTextures()
	{
		return Supports2DArrayTexturesDelegateField();
	}

	public static bool Supports3DRenderTextures()
	{
		return Supports3DRenderTexturesDelegateField();
	}

	public static bool SupportsCubemapArrayTextures()
	{
		return SupportsCubemapArrayTexturesDelegateField();
	}

	public static bool SupportsAnisotropicFilter()
	{
		return SupportsAnisotropicFilterDelegateField();
	}

	public static bool SupportsGeometryShaders()
	{
		return SupportsGeometryShadersDelegateField();
	}

	public static bool SupportsTessellationShaders()
	{
		return SupportsTessellationShadersDelegateField();
	}

	public static bool SupportsHardwareQuadTopology()
	{
		return SupportsHardwareQuadTopologyDelegateField();
	}

	public static bool Supports32bitsIndexBuffer()
	{
		return Supports32bitsIndexBufferDelegateField();
	}

	public static bool SupportsSparseTextures()
	{
		return SupportsSparseTexturesDelegateField();
	}

	public static bool SupportsSeparatedRenderTargetsBlend()
	{
		return SupportsSeparatedRenderTargetsBlendDelegateField();
	}

	public static int SupportedRandomWriteTargetCount()
	{
		return SupportedRandomWriteTargetCountDelegateField();
	}

	public static int MaxComputeBufferInputsVertex()
	{
		return MaxComputeBufferInputsVertexDelegateField();
	}

	public static int MaxComputeBufferInputsFragment()
	{
		return MaxComputeBufferInputsFragmentDelegateField();
	}

	public static int MaxComputeBufferInputsGeometry()
	{
		return MaxComputeBufferInputsGeometryDelegateField();
	}

	public static int MaxComputeBufferInputsDomain()
	{
		return MaxComputeBufferInputsDomainDelegateField();
	}

	public static int MaxComputeBufferInputsHull()
	{
		return MaxComputeBufferInputsHullDelegateField();
	}

	public static int MaxComputeBufferInputsCompute()
	{
		return MaxComputeBufferInputsComputeDelegateField();
	}

	public static bool SupportsMultisampled2DArrayTextures()
	{
		return SupportsMultisampled2DArrayTexturesDelegateField();
	}

	public static int SupportsTextureWrapMirrorOnce()
	{
		return SupportsTextureWrapMirrorOnceDelegateField();
	}

	public static bool SupportsBlendingOnRenderTextureFormatNative(RenderTextureFormat format)
	{
		return SupportsBlendingOnRenderTextureFormatNativeDelegateField(format);
	}

	public static bool SupportsRandomWriteOnRenderTextureFormatNative(RenderTextureFormat format)
	{
		return SupportsRandomWriteOnRenderTextureFormatNativeDelegateField(format);
	}

	public static bool SupportsVertexAttributeFormatNative(VertexAttributeFormat format, int dimension)
	{
		return SupportsVertexAttributeFormatNativeDelegateField(format, dimension);
	}

	public static NPOTSupport GetNPOTSupport()
	{
		return GetNPOTSupportDelegateField();
	}

	public static int GetMaxTexture3DSize()
	{
		return GetMaxTexture3DSizeDelegateField();
	}

	public static int GetMaxTextureArraySlices()
	{
		return GetMaxTextureArraySlicesDelegateField();
	}

	public static int GetMaxCubemapSize()
	{
		return GetMaxCubemapSizeDelegateField();
	}

	public static int GetMaxAnisotropyLevel()
	{
		return GetMaxAnisotropyLevelDelegateField();
	}

	public static int GetMaxComputeWorkGroupSize()
	{
		return GetMaxComputeWorkGroupSizeDelegateField();
	}

	public static int GetMaxComputeWorkGroupSizeX()
	{
		return GetMaxComputeWorkGroupSizeXDelegateField();
	}

	public static int GetMaxComputeWorkGroupSizeY()
	{
		return GetMaxComputeWorkGroupSizeYDelegateField();
	}

	public static int GetMaxComputeWorkGroupSizeZ()
	{
		return GetMaxComputeWorkGroupSizeZDelegateField();
	}

	public static int GetComputeSubGroupSize()
	{
		return GetComputeSubGroupSizeDelegateField();
	}

	public static bool SupportsAsyncCompute()
	{
		return SupportsAsyncComputeDelegateField();
	}

	public static bool SupportsGpuRecorder()
	{
		return SupportsGpuRecorderDelegateField();
	}

	public static bool SupportsAsyncGPUReadback()
	{
		return SupportsAsyncGPUReadbackDelegateField();
	}

	public static bool SupportsParallelPSOCreation()
	{
		return SupportsParallelPSOCreationDelegateField();
	}

	public static bool SupportsRayTracing()
	{
		return SupportsRayTracingDelegateField();
	}

	public static bool SupportsRayTracingShaders()
	{
		return SupportsRayTracingShadersDelegateField();
	}

	public static bool SupportsInlineRayTracing()
	{
		return SupportsInlineRayTracingDelegateField();
	}

	public static bool SupportsIndirectDispatchRays()
	{
		return SupportsIndirectDispatchRaysDelegateField();
	}

	public static bool SupportsSetConstantBuffer()
	{
		return SupportsSetConstantBufferDelegateField();
	}

	public static int MinConstantBufferOffsetAlignment()
	{
		return MinConstantBufferOffsetAlignmentDelegateField();
	}

	public static int MaxConstantBufferSize()
	{
		return MaxConstantBufferSizeDelegateField();
	}

	public static bool HasMipMaxLevel()
	{
		return HasMipMaxLevelDelegateField();
	}

	public static bool SupportsMipStreaming()
	{
		return SupportsMipStreamingDelegateField();
	}

	public static bool IsFormatSupported(GraphicsFormat format, FormatUsage usage)
	{
		GraphicsFormatUsage usage2 = (GraphicsFormatUsage)(1 << (int)usage);
		return IsFormatSupported(format, usage2);
	}

	public static GraphicsFormat GetCompatibleFormat(GraphicsFormat format, FormatUsage usage)
	{
		GraphicsFormatUsage usage2 = (GraphicsFormatUsage)(1 << (int)usage);
		return GetCompatibleFormat(format, usage2);
	}

	public static bool SupportsConservativeRaster()
	{
		return SupportsConservativeRasterDelegateField();
	}

	public static bool SupportsDepthFetchInRenderPass()
	{
		return SupportsDepthFetchInRenderPassDelegateField();
	}

	public unsafe static void GetProcessorType_Injected(out ManagedSpanWrapper ret)
	{
		GetProcessorType_InjectedDelegateField((nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void GetProcessorModel_Injected(out ManagedSpanWrapper ret)
	{
		GetProcessorModel_InjectedDelegateField((nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void GetProcessorManufacturer_Injected(out ManagedSpanWrapper ret)
	{
		GetProcessorManufacturer_InjectedDelegateField((nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void GetDeviceUniqueIdentifier_Injected(out ManagedSpanWrapper ret)
	{
		GetDeviceUniqueIdentifier_InjectedDelegateField((nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void GetDeviceName_Injected(out ManagedSpanWrapper ret)
	{
		GetDeviceName_InjectedDelegateField((nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void GetGraphicsDeviceVersion_Injected(out ManagedSpanWrapper ret)
	{
		GetGraphicsDeviceVersion_InjectedDelegateField((nint)Unsafe.AsPointer(ref ret));
	}
}
