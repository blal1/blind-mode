using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.Universal;

public static class ShaderPropertyId : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_glossyEnvironmentColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_subtractiveShadowColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_glossyEnvironmentCubeMap;

	private static readonly System.IntPtr NativeFieldInfoPtr_glossyEnvironmentCubeMapHDR;

	private static readonly System.IntPtr NativeFieldInfoPtr_ambientSkyColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_ambientEquatorColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_ambientGroundColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_time;

	private static readonly System.IntPtr NativeFieldInfoPtr_sinTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_cosTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_deltaTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_timeParameters;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastTimeParameters;

	private static readonly System.IntPtr NativeFieldInfoPtr_scaledScreenParams;

	private static readonly System.IntPtr NativeFieldInfoPtr_worldSpaceCameraPos;

	private static readonly System.IntPtr NativeFieldInfoPtr_screenParams;

	private static readonly System.IntPtr NativeFieldInfoPtr_alphaToMaskAvailable;

	private static readonly System.IntPtr NativeFieldInfoPtr_projectionParams;

	private static readonly System.IntPtr NativeFieldInfoPtr_zBufferParams;

	private static readonly System.IntPtr NativeFieldInfoPtr_orthoParams;

	private static readonly System.IntPtr NativeFieldInfoPtr_globalMipBias;

	private static readonly System.IntPtr NativeFieldInfoPtr_screenSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_screenCoordScaleBias;

	private static readonly System.IntPtr NativeFieldInfoPtr_screenSizeOverride;

	private static readonly System.IntPtr NativeFieldInfoPtr_viewMatrix;

	private static readonly System.IntPtr NativeFieldInfoPtr_projectionMatrix;

	private static readonly System.IntPtr NativeFieldInfoPtr_viewAndProjectionMatrix;

	private static readonly System.IntPtr NativeFieldInfoPtr_inverseViewMatrix;

	private static readonly System.IntPtr NativeFieldInfoPtr_inverseProjectionMatrix;

	private static readonly System.IntPtr NativeFieldInfoPtr_inverseViewAndProjectionMatrix;

	private static readonly System.IntPtr NativeFieldInfoPtr_cameraProjectionMatrix;

	private static readonly System.IntPtr NativeFieldInfoPtr_inverseCameraProjectionMatrix;

	private static readonly System.IntPtr NativeFieldInfoPtr_worldToCameraMatrix;

	private static readonly System.IntPtr NativeFieldInfoPtr_cameraToWorldMatrix;

	private static readonly System.IntPtr NativeFieldInfoPtr_shadowBias;

	private static readonly System.IntPtr NativeFieldInfoPtr_lightDirection;

	private static readonly System.IntPtr NativeFieldInfoPtr_lightPosition;

	private static readonly System.IntPtr NativeFieldInfoPtr_cameraWorldClipPlanes;

	private static readonly System.IntPtr NativeFieldInfoPtr_billboardNormal;

	private static readonly System.IntPtr NativeFieldInfoPtr_billboardTangent;

	private static readonly System.IntPtr NativeFieldInfoPtr_billboardCameraParams;

	private static readonly System.IntPtr NativeFieldInfoPtr_previousViewProjectionNoJitter;

	private static readonly System.IntPtr NativeFieldInfoPtr_viewProjectionNoJitter;

	private static readonly System.IntPtr NativeFieldInfoPtr_previousViewProjectionNoJitterStereo;

	private static readonly System.IntPtr NativeFieldInfoPtr_viewProjectionNoJitterStereo;

	private static readonly System.IntPtr NativeFieldInfoPtr_blitTexture;

	private static readonly System.IntPtr NativeFieldInfoPtr_blitScaleBias;

	private static readonly System.IntPtr NativeFieldInfoPtr_sourceTex;

	private static readonly System.IntPtr NativeFieldInfoPtr_scaleBias;

	private static readonly System.IntPtr NativeFieldInfoPtr_scaleBiasRt;

	private static readonly System.IntPtr NativeFieldInfoPtr_rtHandleScale;

	private static readonly System.IntPtr NativeFieldInfoPtr_rendererColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_ditheringTexture;

	private static readonly System.IntPtr NativeFieldInfoPtr_ditheringTextureInvSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_renderingLayerMaxInt;

	private static readonly System.IntPtr NativeFieldInfoPtr_renderingLayerRcpMaxInt;

	private static readonly System.IntPtr NativeFieldInfoPtr_overlayUITexture;

	private static readonly System.IntPtr NativeFieldInfoPtr_hdrOutputLuminanceParams;

	private static readonly System.IntPtr NativeFieldInfoPtr_hdrOutputGradingParams;

	public unsafe static int glossyEnvironmentColor
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_glossyEnvironmentColor, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_glossyEnvironmentColor, (void*)(&value));
		}
	}

	public unsafe static int subtractiveShadowColor
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_subtractiveShadowColor, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_subtractiveShadowColor, (void*)(&value));
		}
	}

	public unsafe static int glossyEnvironmentCubeMap
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_glossyEnvironmentCubeMap, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_glossyEnvironmentCubeMap, (void*)(&value));
		}
	}

	public unsafe static int glossyEnvironmentCubeMapHDR
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_glossyEnvironmentCubeMapHDR, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_glossyEnvironmentCubeMapHDR, (void*)(&value));
		}
	}

	public unsafe static int ambientSkyColor
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ambientSkyColor, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ambientSkyColor, (void*)(&value));
		}
	}

	public unsafe static int ambientEquatorColor
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ambientEquatorColor, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ambientEquatorColor, (void*)(&value));
		}
	}

	public unsafe static int ambientGroundColor
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ambientGroundColor, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ambientGroundColor, (void*)(&value));
		}
	}

	public unsafe static int time
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_time, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_time, (void*)(&value));
		}
	}

	public unsafe static int sinTime
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_sinTime, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_sinTime, (void*)(&value));
		}
	}

	public unsafe static int cosTime
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_cosTime, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_cosTime, (void*)(&value));
		}
	}

	public unsafe static int deltaTime
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_deltaTime, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_deltaTime, (void*)(&value));
		}
	}

	public unsafe static int timeParameters
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_timeParameters, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_timeParameters, (void*)(&value));
		}
	}

	public unsafe static int lastTimeParameters
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_lastTimeParameters, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_lastTimeParameters, (void*)(&value));
		}
	}

	public unsafe static int scaledScreenParams
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_scaledScreenParams, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_scaledScreenParams, (void*)(&value));
		}
	}

	public unsafe static int worldSpaceCameraPos
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_worldSpaceCameraPos, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_worldSpaceCameraPos, (void*)(&value));
		}
	}

	public unsafe static int screenParams
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_screenParams, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_screenParams, (void*)(&value));
		}
	}

	public unsafe static int alphaToMaskAvailable
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_alphaToMaskAvailable, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_alphaToMaskAvailable, (void*)(&value));
		}
	}

	public unsafe static int projectionParams
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_projectionParams, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_projectionParams, (void*)(&value));
		}
	}

	public unsafe static int zBufferParams
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_zBufferParams, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_zBufferParams, (void*)(&value));
		}
	}

	public unsafe static int orthoParams
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_orthoParams, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_orthoParams, (void*)(&value));
		}
	}

	public unsafe static int globalMipBias
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_globalMipBias, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_globalMipBias, (void*)(&value));
		}
	}

	public unsafe static int screenSize
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_screenSize, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_screenSize, (void*)(&value));
		}
	}

	public unsafe static int screenCoordScaleBias
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_screenCoordScaleBias, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_screenCoordScaleBias, (void*)(&value));
		}
	}

	public unsafe static int screenSizeOverride
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_screenSizeOverride, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_screenSizeOverride, (void*)(&value));
		}
	}

	public unsafe static int viewMatrix
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_viewMatrix, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_viewMatrix, (void*)(&value));
		}
	}

	public unsafe static int projectionMatrix
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_projectionMatrix, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_projectionMatrix, (void*)(&value));
		}
	}

	public unsafe static int viewAndProjectionMatrix
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_viewAndProjectionMatrix, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_viewAndProjectionMatrix, (void*)(&value));
		}
	}

	public unsafe static int inverseViewMatrix
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_inverseViewMatrix, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_inverseViewMatrix, (void*)(&value));
		}
	}

	public unsafe static int inverseProjectionMatrix
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_inverseProjectionMatrix, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_inverseProjectionMatrix, (void*)(&value));
		}
	}

	public unsafe static int inverseViewAndProjectionMatrix
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_inverseViewAndProjectionMatrix, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_inverseViewAndProjectionMatrix, (void*)(&value));
		}
	}

	public unsafe static int cameraProjectionMatrix
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_cameraProjectionMatrix, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_cameraProjectionMatrix, (void*)(&value));
		}
	}

	public unsafe static int inverseCameraProjectionMatrix
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_inverseCameraProjectionMatrix, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_inverseCameraProjectionMatrix, (void*)(&value));
		}
	}

	public unsafe static int worldToCameraMatrix
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_worldToCameraMatrix, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_worldToCameraMatrix, (void*)(&value));
		}
	}

	public unsafe static int cameraToWorldMatrix
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_cameraToWorldMatrix, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_cameraToWorldMatrix, (void*)(&value));
		}
	}

	public unsafe static int shadowBias
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_shadowBias, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_shadowBias, (void*)(&value));
		}
	}

	public unsafe static int lightDirection
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_lightDirection, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_lightDirection, (void*)(&value));
		}
	}

	public unsafe static int lightPosition
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_lightPosition, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_lightPosition, (void*)(&value));
		}
	}

	public unsafe static int cameraWorldClipPlanes
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_cameraWorldClipPlanes, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_cameraWorldClipPlanes, (void*)(&value));
		}
	}

	public unsafe static int billboardNormal
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_billboardNormal, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_billboardNormal, (void*)(&value));
		}
	}

	public unsafe static int billboardTangent
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_billboardTangent, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_billboardTangent, (void*)(&value));
		}
	}

	public unsafe static int billboardCameraParams
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_billboardCameraParams, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_billboardCameraParams, (void*)(&value));
		}
	}

	public unsafe static int previousViewProjectionNoJitter
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_previousViewProjectionNoJitter, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_previousViewProjectionNoJitter, (void*)(&value));
		}
	}

	public unsafe static int viewProjectionNoJitter
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_viewProjectionNoJitter, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_viewProjectionNoJitter, (void*)(&value));
		}
	}

	public unsafe static int previousViewProjectionNoJitterStereo
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_previousViewProjectionNoJitterStereo, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_previousViewProjectionNoJitterStereo, (void*)(&value));
		}
	}

	public unsafe static int viewProjectionNoJitterStereo
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_viewProjectionNoJitterStereo, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_viewProjectionNoJitterStereo, (void*)(&value));
		}
	}

	public unsafe static int blitTexture
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_blitTexture, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_blitTexture, (void*)(&value));
		}
	}

	public unsafe static int blitScaleBias
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_blitScaleBias, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_blitScaleBias, (void*)(&value));
		}
	}

	public unsafe static int sourceTex
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_sourceTex, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_sourceTex, (void*)(&value));
		}
	}

	public unsafe static int scaleBias
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_scaleBias, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_scaleBias, (void*)(&value));
		}
	}

	public unsafe static int scaleBiasRt
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_scaleBiasRt, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_scaleBiasRt, (void*)(&value));
		}
	}

	public unsafe static int rtHandleScale
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_rtHandleScale, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_rtHandleScale, (void*)(&value));
		}
	}

	public unsafe static int rendererColor
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_rendererColor, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_rendererColor, (void*)(&value));
		}
	}

	public unsafe static int ditheringTexture
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ditheringTexture, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ditheringTexture, (void*)(&value));
		}
	}

	public unsafe static int ditheringTextureInvSize
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ditheringTextureInvSize, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ditheringTextureInvSize, (void*)(&value));
		}
	}

	public unsafe static int renderingLayerMaxInt
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_renderingLayerMaxInt, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_renderingLayerMaxInt, (void*)(&value));
		}
	}

	public unsafe static int renderingLayerRcpMaxInt
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_renderingLayerRcpMaxInt, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_renderingLayerRcpMaxInt, (void*)(&value));
		}
	}

	public unsafe static int overlayUITexture
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_overlayUITexture, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_overlayUITexture, (void*)(&value));
		}
	}

	public unsafe static int hdrOutputLuminanceParams
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_hdrOutputLuminanceParams, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_hdrOutputLuminanceParams, (void*)(&value));
		}
	}

	public unsafe static int hdrOutputGradingParams
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_hdrOutputGradingParams, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_hdrOutputGradingParams, (void*)(&value));
		}
	}

	static ShaderPropertyId()
	{
		Il2CppClassPointerStore<ShaderPropertyId>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "ShaderPropertyId");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShaderPropertyId>.NativeClassPtr);
		NativeFieldInfoPtr_glossyEnvironmentColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderPropertyId>.NativeClassPtr, "glossyEnvironmentColor");
		NativeFieldInfoPtr_subtractiveShadowColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderPropertyId>.NativeClassPtr, "subtractiveShadowColor");
		NativeFieldInfoPtr_glossyEnvironmentCubeMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderPropertyId>.NativeClassPtr, "glossyEnvironmentCubeMap");
		NativeFieldInfoPtr_glossyEnvironmentCubeMapHDR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderPropertyId>.NativeClassPtr, "glossyEnvironmentCubeMapHDR");
		NativeFieldInfoPtr_ambientSkyColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderPropertyId>.NativeClassPtr, "ambientSkyColor");
		NativeFieldInfoPtr_ambientEquatorColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderPropertyId>.NativeClassPtr, "ambientEquatorColor");
		NativeFieldInfoPtr_ambientGroundColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderPropertyId>.NativeClassPtr, "ambientGroundColor");
		NativeFieldInfoPtr_time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderPropertyId>.NativeClassPtr, "time");
		NativeFieldInfoPtr_sinTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderPropertyId>.NativeClassPtr, "sinTime");
		NativeFieldInfoPtr_cosTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderPropertyId>.NativeClassPtr, "cosTime");
		NativeFieldInfoPtr_deltaTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderPropertyId>.NativeClassPtr, "deltaTime");
		NativeFieldInfoPtr_timeParameters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderPropertyId>.NativeClassPtr, "timeParameters");
		NativeFieldInfoPtr_lastTimeParameters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderPropertyId>.NativeClassPtr, "lastTimeParameters");
		NativeFieldInfoPtr_scaledScreenParams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderPropertyId>.NativeClassPtr, "scaledScreenParams");
		NativeFieldInfoPtr_worldSpaceCameraPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderPropertyId>.NativeClassPtr, "worldSpaceCameraPos");
		NativeFieldInfoPtr_screenParams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderPropertyId>.NativeClassPtr, "screenParams");
		NativeFieldInfoPtr_alphaToMaskAvailable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderPropertyId>.NativeClassPtr, "alphaToMaskAvailable");
		NativeFieldInfoPtr_projectionParams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderPropertyId>.NativeClassPtr, "projectionParams");
		NativeFieldInfoPtr_zBufferParams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderPropertyId>.NativeClassPtr, "zBufferParams");
		NativeFieldInfoPtr_orthoParams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderPropertyId>.NativeClassPtr, "orthoParams");
		NativeFieldInfoPtr_globalMipBias = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderPropertyId>.NativeClassPtr, "globalMipBias");
		NativeFieldInfoPtr_screenSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderPropertyId>.NativeClassPtr, "screenSize");
		NativeFieldInfoPtr_screenCoordScaleBias = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderPropertyId>.NativeClassPtr, "screenCoordScaleBias");
		NativeFieldInfoPtr_screenSizeOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderPropertyId>.NativeClassPtr, "screenSizeOverride");
		NativeFieldInfoPtr_viewMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderPropertyId>.NativeClassPtr, "viewMatrix");
		NativeFieldInfoPtr_projectionMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderPropertyId>.NativeClassPtr, "projectionMatrix");
		NativeFieldInfoPtr_viewAndProjectionMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderPropertyId>.NativeClassPtr, "viewAndProjectionMatrix");
		NativeFieldInfoPtr_inverseViewMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderPropertyId>.NativeClassPtr, "inverseViewMatrix");
		NativeFieldInfoPtr_inverseProjectionMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderPropertyId>.NativeClassPtr, "inverseProjectionMatrix");
		NativeFieldInfoPtr_inverseViewAndProjectionMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderPropertyId>.NativeClassPtr, "inverseViewAndProjectionMatrix");
		NativeFieldInfoPtr_cameraProjectionMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderPropertyId>.NativeClassPtr, "cameraProjectionMatrix");
		NativeFieldInfoPtr_inverseCameraProjectionMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderPropertyId>.NativeClassPtr, "inverseCameraProjectionMatrix");
		NativeFieldInfoPtr_worldToCameraMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderPropertyId>.NativeClassPtr, "worldToCameraMatrix");
		NativeFieldInfoPtr_cameraToWorldMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderPropertyId>.NativeClassPtr, "cameraToWorldMatrix");
		NativeFieldInfoPtr_shadowBias = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderPropertyId>.NativeClassPtr, "shadowBias");
		NativeFieldInfoPtr_lightDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderPropertyId>.NativeClassPtr, "lightDirection");
		NativeFieldInfoPtr_lightPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderPropertyId>.NativeClassPtr, "lightPosition");
		NativeFieldInfoPtr_cameraWorldClipPlanes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderPropertyId>.NativeClassPtr, "cameraWorldClipPlanes");
		NativeFieldInfoPtr_billboardNormal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderPropertyId>.NativeClassPtr, "billboardNormal");
		NativeFieldInfoPtr_billboardTangent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderPropertyId>.NativeClassPtr, "billboardTangent");
		NativeFieldInfoPtr_billboardCameraParams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderPropertyId>.NativeClassPtr, "billboardCameraParams");
		NativeFieldInfoPtr_previousViewProjectionNoJitter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderPropertyId>.NativeClassPtr, "previousViewProjectionNoJitter");
		NativeFieldInfoPtr_viewProjectionNoJitter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderPropertyId>.NativeClassPtr, "viewProjectionNoJitter");
		NativeFieldInfoPtr_previousViewProjectionNoJitterStereo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderPropertyId>.NativeClassPtr, "previousViewProjectionNoJitterStereo");
		NativeFieldInfoPtr_viewProjectionNoJitterStereo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderPropertyId>.NativeClassPtr, "viewProjectionNoJitterStereo");
		NativeFieldInfoPtr_blitTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderPropertyId>.NativeClassPtr, "blitTexture");
		NativeFieldInfoPtr_blitScaleBias = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderPropertyId>.NativeClassPtr, "blitScaleBias");
		NativeFieldInfoPtr_sourceTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderPropertyId>.NativeClassPtr, "sourceTex");
		NativeFieldInfoPtr_scaleBias = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderPropertyId>.NativeClassPtr, "scaleBias");
		NativeFieldInfoPtr_scaleBiasRt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderPropertyId>.NativeClassPtr, "scaleBiasRt");
		NativeFieldInfoPtr_rtHandleScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderPropertyId>.NativeClassPtr, "rtHandleScale");
		NativeFieldInfoPtr_rendererColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderPropertyId>.NativeClassPtr, "rendererColor");
		NativeFieldInfoPtr_ditheringTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderPropertyId>.NativeClassPtr, "ditheringTexture");
		NativeFieldInfoPtr_ditheringTextureInvSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderPropertyId>.NativeClassPtr, "ditheringTextureInvSize");
		NativeFieldInfoPtr_renderingLayerMaxInt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderPropertyId>.NativeClassPtr, "renderingLayerMaxInt");
		NativeFieldInfoPtr_renderingLayerRcpMaxInt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderPropertyId>.NativeClassPtr, "renderingLayerRcpMaxInt");
		NativeFieldInfoPtr_overlayUITexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderPropertyId>.NativeClassPtr, "overlayUITexture");
		NativeFieldInfoPtr_hdrOutputLuminanceParams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderPropertyId>.NativeClassPtr, "hdrOutputLuminanceParams");
		NativeFieldInfoPtr_hdrOutputGradingParams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderPropertyId>.NativeClassPtr, "hdrOutputGradingParams");
	}

	public ShaderPropertyId(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
